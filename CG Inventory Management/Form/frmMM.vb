Public Class frmMM
    Public SQL As New SQLControl

    Private currentPage As Integer = 1
    Private pageSize As Integer = 200
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private searchMode As Boolean
    Private searchType As String = ""
    Private searchText As String = ""
    Private Sub frmMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()
        dgvMM.DoubleBuffered(True)
        SetupDGV()

        LoadData()

        cbxSearch.SelectedIndex = 0
        Loading.Close()
        Me.Show()
        txtSearch.Focus()

    End Sub

    Private Sub UpdateNavButtons()
        btnFirst.Enabled = (currentPage > 1)
        btnPrev.Enabled = (currentPage > 1)
        btnNext.Enabled = (currentPage < totalPages)
        btnLast.Enabled = (currentPage < totalPages)

        ' Update the page label
        lblPage.Text = If(totalPages < 1, "Page 0 of 0", String.Format("Page {0} of {1}", currentPage, totalPages))
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT COUNT(*) FROM PartManagement"

        If searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            query &= " WHERE " & searchType & " LIKE @searchText"
        End If

        SQL.ExecQuery(query)

        If SQL.HasException(True) Then Exit Sub

        totalRecords = SQL.DBDT.Rows(0)(0)

        ' Calculate the number of pages needed
        totalPages = Math.Ceiling(totalRecords / pageSize)

        lblTotalHis.Text = If(totalPages < 1, "0 records overall, 0 pages, and 200 records per page.",
            String.Format("{0} records overall, {1} pages, and 200 records per page.", totalRecords, totalPages))

        ' Update the navigation buttons
        UpdateNavButtons()

        ' Load first page of data
        LoadDatatoDGV()
    End Sub

    Private Sub SetupDGV()
        With dgvMM
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 8
            .RowTemplate.Height = 30
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)
            .ColumnHeadersDefaultCellStyle.Font = New Font(.Font, FontStyle.Bold)

            Dim columns As String() = {"No.", "Part Number", "Part Type", "CG Code", "Part Description",
                                        "Qty Per Part", "Update Time", "Updater"}

            Dim widths As Integer() = {40, 180, 148, 160, 470, 90, 100, 82}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvMM.Rows.Clear()

        ' Retrieve the records for the current page
        Dim offset As Integer = (currentPage - 1) * pageSize
        SQL.AddParam("@offset", offset)
        SQL.AddParam("@fetch", pageSize)

        Dim query As String = "SELECT * FROM PartManagement"

        If searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            query &= " WHERE " & searchType & " LIKE @searchText ORDER BY PartNumber ASC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY"
        Else
            query &= " ORDER BY PartNumber ASC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY"
        End If

        SQL.ExecQuery(query)

        If SQL.HasException(True) Then Exit Sub

        For i As Integer = 1 To SQL.DBDT.Rows.Count

            dgvMM.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                      SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                      SQL.DBDT.Rows(i - 1)("QtyPerPart"), SQL.DBDT.Rows(i - 1)("UpdateTime"), SQL.DBDT.Rows(i - 1)("Updater")})
        Next
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Then
            dgvMM.ClearSelection()
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
                If MessageBox.Show("Confirm to delete below part number information?" & vbCrLf & vbCrLf & "Part Number: " & dgvMM.SelectedRows(0).Cells("Part Number").Value & vbCrLf & "Part Type: " & dgvMM.SelectedRows(0).Cells("Part Type").Value & vbCrLf & "CG Code: " & dgvMM.SelectedRows(0).Cells("CG Code").Value & vbCrLf & "Qty Per Part: " & dgvMM.SelectedRows(0).Cells("Qty Per Part").Value, "Delete Part Management Info.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    DoDelete()
                    LoadData()
                    MessageBox.Show("Data has been deleted successfully.", "Delete Part Management Info.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub EditPartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPartNumberToolStripMenuItem.Click
        If dgvMM.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvMM.Focus()
        Else
            With frmEditPN
                .Text = "Edit Part Number: " + dgvMM.SelectedRows(0).Cells("Part Number").Value
                .txtPN.Text = dgvMM.SelectedRows(0).Cells("Part Number").Value
                .txtPT.Text = dgvMM.SelectedRows(0).Cells("Part Type").Value
                .txtCGCode.Text = dgvMM.SelectedRows(0).Cells("CG Code").Value
                .txtPD.Text = dgvMM.SelectedRows(0).Cells("Part Description").Value
                .txtQPP.Value = dgvMM.SelectedRows(0).Cells("Qty Per Part").Value
                .ShowDialog()
            End With
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
                If txtSearch.Text = "" Then
                    searchMode = False
                Else
                    currentPage = 1
                    searchMode = True

                    Dim dataTypes As String() = {"PartNumber", "PartType", "CGCode", "PN_Desc"}

                    searchType = dataTypes(cbxSearch.SelectedIndex)

                    searchText = txtSearch.Text.Trim.ToUpper
                End If

                LoadData()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class