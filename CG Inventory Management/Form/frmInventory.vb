Public Class frmInventory
    Public SQL As New SQLControl
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()

        'HWID
        Dim hw As New clsComputerInfo

        Dim hdd As String
        Dim cpu As String
        Dim mb As String
        Dim mac As String

        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()

        'MsgBox(cpu & "   " & hdd & "   " & mb & "   " & mac)

        Dim hwid As String = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

        ' MessageBox.Show(Strings.UCase(hwid))

        'TextBox1.Text = hwid
        'MsgBox(hwid)

        'END HWID

        If hwid = "7C654D04A9EE2967620C99DD5DD1A0F1" Or hwid = "05EA3FF0C220883F0020347582CCD983" Then
            Guna2ContextMenuStrip1.Enabled = True
        Else
            Guna2ContextMenuStrip1.Enabled = False
        End If

        dgvInventory.DoubleBuffered(True)
        frmInventoryPart.dgvInventory.DoubleBuffered(True)
        SetupDGV()
        LoadDatatoDGV()

        SetupInventoryPart()
        cbxSearch.SelectedIndex = 0
    End Sub

    Private Sub SetupDGV()
        Dim dataGridViewRec As DataGridView = dgvInventory

        dataGridViewRec.RowHeadersVisible = False
        dataGridViewRec.EnableHeadersVisualStyles = False
        dataGridViewRec.ColumnCount = 6

        dataGridViewRec.Columns(0).Name = "Part Number"
        dataGridViewRec.Columns(1).Name = "Part Type"
        dataGridViewRec.Columns(2).Name = "CG Code"
        dataGridViewRec.Columns(3).Name = "Part Description"
        dataGridViewRec.Columns(4).Name = "NoC"
        dataGridViewRec.Columns(5).Name = "Total Quantity"

        dataGridViewRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewRec.AutoResizeColumns()

        dataGridViewRec.Columns("Part Number").Width = 180
        dataGridViewRec.Columns("Part Type").Width = 128
        dataGridViewRec.Columns("CG Code").Width = 160
        dataGridViewRec.Columns("Part Description").Width = 450
        dataGridViewRec.Columns("NoC").Width = 40
        dataGridViewRec.Columns("Total Quantity").Width = 140

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

    Private Sub SetupInventoryPart()

        Dim dataGridViewRec As DataGridView = frmInventoryPart.dgvInventory

        dataGridViewRec.RowHeadersVisible = False
        dataGridViewRec.EnableHeadersVisualStyles = False
        dataGridViewRec.ColumnCount = 11

        dataGridViewRec.Columns(0).Name = "No."
        dataGridViewRec.Columns(1).Name = "CGID"
        dataGridViewRec.Columns(2).Name = "Part Number"
        dataGridViewRec.Columns(3).Name = "Location"
        dataGridViewRec.Columns(4).Name = "Date Code"
        dataGridViewRec.Columns(5).Name = "Quantity"
        dataGridViewRec.Columns(6).Name = "GRN No."
        dataGridViewRec.Columns(7).Name = "Update Time"
        dataGridViewRec.Columns(8).Name = "Updater"
        dataGridViewRec.Columns(9).Name = "State"
        dataGridViewRec.Columns(10).Name = "Remark"

        dataGridViewRec.RowTemplate.Height = 35
        dataGridViewRec.AllowUserToResizeRows = False

        dataGridViewRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewRec.AutoResizeColumns()

        dataGridViewRec.Columns("No.").Width = 40
        dataGridViewRec.Columns("CGID").Width = 150
        dataGridViewRec.Columns("Part Number").Width = 180
        dataGridViewRec.Columns("Location").Width = 78
        dataGridViewRec.Columns("Date Code").Width = 85
        dataGridViewRec.Columns("Quantity").Width = 75
        dataGridViewRec.Columns("Update Time").Width = 100
        dataGridViewRec.Columns("Updater").Width = 75
        dataGridViewRec.Columns("State").Width = 100

        dataGridViewRec.Columns("Date Code").DefaultCellStyle.Format = "dd-MM-yyyy"

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
            dgvInventory.Rows.Clear()

            SQL.ExecQuery("SELECT PartManagement.PartNumber, PartManagement.PartType," _
                & "PartManagement.CGCode, PartManagement.PN_Desc, COUNT(Inventory.PartNumber) AS NoC," _
                & "SUM(Inventory.Qty) AS 'Total Quantity'" _
                & "FROM Inventory JOIN PartManagement " _
                & "ON Inventory.PartNumber=PartManagement.PartNumber " _
                & "GROUP BY PartManagement.PartNumber, PartManagement.PartType, " _
                & "PartManagement.CGCode, PartManagement.PN_Desc;")

            If SQL.HasException(True) Then Exit Sub

            For i As Integer = 1 To SQL.DBDT.Rows.Count

                dgvInventory.Rows.Add(New Object() {SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                      SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                      SQL.DBDT.Rows(i - 1)("NoC"), SQL.DBDT.Rows(i - 1)("Total Quantity")})
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvInventory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellDoubleClick
        frmInventoryPart.Text = "Inventory for Part Number: " + dgvInventory.CurrentRow.Cells(0).Value.ToString

        frmInventoryPart.dgvInventory.Refresh()
        frmMain.Hide()
        frmInventoryPart.ShowDialog()
    End Sub

    Private Sub dgvInventory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInventory.SelectionChanged

        frmInventoryPart.lblpn.Text = dgvInventory.CurrentRow.Cells(0).Value.ToString()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Then
            dgvInventory.ClearSelection()
            'dgvInventory.CurrentCell = Nothing
            Return
        End If

        Dim text As String = cbxSearch.Text

        For i As Integer = 1 To dgvInventory.Rows.Count
            If InStr(dgvInventory.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvInventory.ClearSelection()
                dgvInventory.Rows(i - 1).Selected = True
                dgvInventory.FirstDisplayedScrollingRowIndex = (i - 1)
                Return
            End If

            If Not InStr(dgvInventory.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvInventory.ClearSelection()
            End If
        Next

    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                Dim filtertext As String = ""
                If cbxSearch.SelectedIndex = 0 Then
                    filtertext = "PartManagement.PartNumber"
                ElseIf cbxSearch.SelectedIndex = 1 Then
                    filtertext = "PartManagement.PartType"
                ElseIf cbxSearch.SelectedIndex = 2 Then
                    filtertext = "PartManagement.CGCode"
                ElseIf cbxSearch.SelectedIndex = 3 Then
                    filtertext = "PartManagement.PN_Desc"
                End If

                If txtSearch.Text = "" Then
                    LoadDatatoDGV()
                Else
                    SQL.AddParam("@filter", "%" & txtSearch.Text.Trim.ToUpper & "%")

                    SQL.ExecQuery("SELECT PartManagement.PartNumber, PartManagement.PartType," _
                                & "PartManagement.CGCode, PartManagement.PN_Desc, COUNT(Inventory.PartNumber) AS NoC," _
                                & "SUM(Inventory.Qty) AS 'Total Quantity'" _
                                & "FROM Inventory JOIN PartManagement " _
                                & "ON Inventory.PartNumber=PartManagement.PartNumber " _
                                & "WHERE " & filtertext & " LIKE @filter " _
                                & "GROUP BY PartManagement.PartNumber, PartManagement.PartType, " _
                                & "PartManagement.CGCode, PartManagement.PN_Desc;")

                    If SQL.HasException(True) Then Exit Sub

                    If SQL.RecordCount > 0 Then
                        dgvInventory.Rows.Clear()
                        For i As Integer = 1 To SQL.DBDT.Rows.Count
                            dgvInventory.Rows.Add(New Object() {SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                      SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                      SQL.DBDT.Rows(i - 1)("NoC"), SQL.DBDT.Rows(i - 1)("Total Quantity")})
                        Next
                    Else
                        dgvInventory.Rows.Clear()
                    End If
                End If

            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub DeletePartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePartNumberToolStripMenuItem.Click
        'If MessageBox.Show("Confirm to print label carton" & vbCrLf & "with below part number information?" & vbCrLf & vbCrLf & "Part Number: " & dgvInventory.SelectedRows(0).Cells("Part Number").Value & vbCrLf & "CG Code: " & dgvInventory.SelectedRows(0).Cells("CG Code").Value & vbCrLf & "Total Quantity: " & dgvInventory.SelectedRows(0).Cells("Total Quantity").Value, "Print Label Carton", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        '    PrintBar()
        'End If

        PrintCartonLabel.lblpn.Text = dgvInventory.SelectedRows(0).Cells("Part Number").Value
        PrintCartonLabel.lblcgcode.Text = dgvInventory.SelectedRows(0).Cells("CG Code").Value
        PrintCartonLabel.lblqty.Text = dgvInventory.SelectedRows(0).Cells("Total Quantity").Value

        PrintCartonLabel.ShowDialog()

    End Sub

    Private Sub dgvInventory_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvInventory.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim hti = dgvInventory.HitTest(e.X, e.Y)
            If hti.RowIndex = -1 Then Return

            dgvInventory.ClearSelection()
            dgvInventory.Rows(hti.RowIndex).Selected = True

        End If
    End Sub
End Class