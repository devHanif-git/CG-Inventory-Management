Public Class frmMM
    Public SQL As New SQLControl
    Private Sub frmMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        dgvMM.DoubleBuffered(True)

        SetupDGV()
        LoadDatatoDGV()
        cbxSearch.SelectedIndex = 0
    End Sub

    Private Sub SetupDGV()
        Dim dataGridViewRec As DataGridView = dgvMM

        dataGridViewRec.RowHeadersVisible = False
        dataGridViewRec.EnableHeadersVisualStyles = False
        dataGridViewRec.ColumnCount = 8

        dataGridViewRec.Columns(0).Name = "No."
        dataGridViewRec.Columns(1).Name = "Part Number"
        dataGridViewRec.Columns(2).Name = "Part Type"
        dataGridViewRec.Columns(3).Name = "CG Code"
        dataGridViewRec.Columns(4).Name = "Part Description"
        dataGridViewRec.Columns(5).Name = "Qty Per Part"
        dataGridViewRec.Columns(6).Name = "Update Time"
        dataGridViewRec.Columns(7).Name = "Updater"

        dataGridViewRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewRec.AutoResizeColumns()

        dataGridViewRec.Columns("No.").Width = 40
        dataGridViewRec.Columns("Part Number").Width = 180
        dataGridViewRec.Columns("Part Type").Width = 148
        dataGridViewRec.Columns("CG Code").Width = 160
        dataGridViewRec.Columns("Part Description").Width = 470
        dataGridViewRec.Columns("Qty Per Part").Width = 90
        dataGridViewRec.Columns("Update Time").Width = 100

        dataGridViewRec.RowTemplate.Height = 30
        dataGridViewRec.AllowUserToResizeRows = False

        dataGridViewRec.RowsDefaultCellStyle.BackColor = Color.White
        dataGridViewRec.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)

        With dataGridViewRec.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(dataGridViewRec.Font, FontStyle.Bold)
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        Try
            dgvMM.Rows.Clear()

            SQL.ExecQuery("SELECT * FROM PartManagement")

            If SQL.HasException(True) Then Exit Sub

            For i As Integer = 1 To SQL.DBDT.Rows.Count

                dgvMM.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                      SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                      SQL.DBDT.Rows(i - 1)("QtyPerPart"), SQL.DBDT.Rows(i - 1)("UpdateTime"), SQL.DBDT.Rows(i - 1)("Updater")})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Then
            dgvMM.ClearSelection()
            'dgvInventory.CurrentCell = Nothing
            Return
        End If

        Dim text As String = cbxSearch.Text

        For i As Integer = 1 To dgvMM.Rows.Count
            If InStr(dgvMM.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvMM.ClearSelection()
                dgvMM.Rows(i - 1).Selected = True
                dgvMM.FirstDisplayedScrollingRowIndex = (i - 1)
                Return
            End If

            If Not InStr(dgvMM.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvMM.ClearSelection()
            End If
        Next
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmImport.ShowDialog()

    End Sub

    Private Sub DoDelete()
        Try
            SQL.AddParam("@pn", dgvMM.SelectedRows(0).Cells("Part Number").Value)
            SQL.ExecQuery("DELETE FROM PartManagement WHERE PartNumber = @pn")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DeletePartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePartNumberToolStripMenuItem.Click
        If dgvMM.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvMM.Focus()
        Else
            'check in inventory if this part number exist
            Dim exist As Boolean = False
            Dim pn As String = dgvMM.SelectedRows(0).Cells("Part Number").Value
            SQL.AddParam("@pn", pn)
            SQL.ExecQuery("SELECT TOP 1 * FROM Inventory WHERE PartNumber = @pn")

            If SQL.RecordCount > 0 Then
                exist = True
            End If

            If exist Then
                MessageBox.Show("This part number is in stock and requires this information.", "Part Number is in Stock!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Confirm to delete below part number information?" & vbCrLf & vbCrLf & "Part Number: " & dgvMM.SelectedRows(0).Cells("Part Number").Value & vbCrLf & "Part Type: " & dgvMM.SelectedRows(0).Cells("Part Type").Value & vbCrLf & "CG Code: " & dgvMM.SelectedRows(0).Cells("CG Code").Value & vbCrLf & "Qty Per Part: " & dgvMM.SelectedRows(0).Cells("Qty Per Part").Value, "Delete User Login Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    DoDelete()
                    LoadDatatoDGV()
                End If
            End If
        End If
    End Sub

    Private Sub EditPartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPartNumberToolStripMenuItem.Click
        If dgvMM.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvMM.Focus()
        Else
            frmEditPN.Text = "Edit Part Number: " + dgvMM.SelectedRows(0).Cells("Part Number").Value
            frmEditPN.txtPN.Text = dgvMM.SelectedRows(0).Cells("Part Number").Value
            frmEditPN.txtPT.Text = dgvMM.SelectedRows(0).Cells("Part Type").Value
            frmEditPN.txtCGCode.Text = dgvMM.SelectedRows(0).Cells("CG Code").Value
            frmEditPN.txtPD.Text = dgvMM.SelectedRows(0).Cells("Part Description").Value
            frmEditPN.txtQPP.Value = dgvMM.SelectedRows(0).Cells("Qty Per Part").Value
            frmEditPN.ShowDialog()
        End If
    End Sub

    Private Sub dgvMM_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvMM.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim hti = dgvMM.HitTest(e.X, e.Y)
            If hti.RowIndex = -1 Then Return

            dgvMM.ClearSelection()
            dgvMM.Rows(hti.RowIndex).Selected = True

        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                Dim filtertext As String = ""

                If cbxSearch.SelectedIndex = 0 Then
                    filtertext = "PartNumber"
                ElseIf cbxSearch.SelectedIndex = 1 Then
                    filtertext = "PartType"
                ElseIf cbxSearch.SelectedIndex = 2 Then
                    filtertext = "CGCode"
                ElseIf cbxSearch.SelectedIndex = 3 Then
                    filtertext = "PN_Desc"
                End If

                If txtSearch.Text = "" Then
                    LoadDatatoDGV()
                Else
                    SQL.AddParam("@filter", "%" & txtSearch.Text.Trim.ToUpper & "%")

                    SQL.ExecQuery("SELECT * FROM PartManagement WHERE " & filtertext & " LIKE @filter")
                    If SQL.HasException(True) Then Exit Sub

                    If SQL.RecordCount > 0 Then
                        dgvMM.Rows.Clear()

                        For i As Integer = 1 To SQL.DBDT.Rows.Count

                            dgvMM.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                                  SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                                  SQL.DBDT.Rows(i - 1)("QtyPerPart"), SQL.DBDT.Rows(i - 1)("UpdateTime"), SQL.DBDT.Rows(i - 1)("Updater")})
                        Next
                    End If
                End If

            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class