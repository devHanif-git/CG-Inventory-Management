Public Class frmInventory
    Public SQL As New SQLControl
    Public hwid As String = frmMain.hwid

    Private searchMode As Boolean
    Private searchType As String = ""
    Private searchText As String = ""

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()

        Guna2ContextMenuStrip1.Enabled = hwid = "7C654D04A9EE2967620C99DD5DD1A0F1" Or hwid = "05EA3FF0C220883F0020347582CCD983"

        dgvInventory.DoubleBuffered(True)
        frmInventoryPart.dgvInventory.DoubleBuffered(True)
        SetupDGV()
        SetupInventoryPart()

        LoadDatatoDGV()

        cbxSearch.SelectedIndex = 0
        Loading.Close()
        Me.Show()
    End Sub

    Private Sub SetupDGV()
        With dgvInventory
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 6
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .RowTemplate.Height = 30
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)
            .ColumnHeadersDefaultCellStyle.Font = New Font(.Font, FontStyle.Bold)

            Dim columnNames() As String = {"Part Number", "Part Type", "CG Code", "Part Description", "NoC", "Total Quantity"}
            Dim columnWidths() As Integer = {180, 128, 160, 450, 40, 140}

            For i As Integer = 0 To columnNames.Length - 1
                .Columns(i).Name = columnNames(i)
                .Columns(i).Width = columnWidths(i)
            Next

        End With
    End Sub

    Private Sub SetupInventoryPart()
        With frmInventoryPart.dgvInventory
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 11
            .RowTemplate.Height = 35
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)
            .ColumnHeadersDefaultCellStyle.Font = New Font(.Font, FontStyle.Bold)

            Dim columnNames As String() = {"No.", "CGID", "Part Number", "Location", "Date Code", "Quantity", "GRN No.", "Update Time", "Updater", "State", "Remark"}

            For i As Integer = 0 To columnNames.Length - 1
                .Columns(i).Name = columnNames(i)
            Next

            .Columns("Date Code").DefaultCellStyle.Format = "dd-MM-yyyy"

            .Columns("No.").Width = 40
            .Columns("CGID").Width = 150
            .Columns("Part Number").Width = 180
            .Columns("Location").Width = 78
            .Columns("Date Code").Width = 85
            .Columns("Quantity").Width = 75
            .Columns("Update Time").Width = 100
            .Columns("Updater").Width = 75
            .Columns("State").Width = 100
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvInventory.Rows.Clear()

        If searchMode Then
            SQL.AddParam("@findtxt", "%" & searchText & "%")
            SQL.ExecQuery("SELECT PartManagement.PartNumber, PartManagement.PartType," _
                        & "PartManagement.CGCode, PartManagement.PN_Desc, COUNT(Inventory.PartNumber) AS NoC," _
                        & "SUM(Inventory.Qty) AS 'Total Quantity'" _
                        & "FROM Inventory JOIN PartManagement " _
                        & "ON Inventory.PartNumber=PartManagement.PartNumber " _
                        & "WHERE " & searchType & " LIKE @findtxt " _
                        & "GROUP BY PartManagement.PartNumber, PartManagement.PartType, " _
                        & "PartManagement.CGCode, PartManagement.PN_Desc;")

        Else
            SQL.ExecQuery("SELECT PartManagement.PartNumber, PartManagement.PartType," _
                        & "PartManagement.CGCode, PartManagement.PN_Desc, COUNT(Inventory.PartNumber) AS NoC," _
                        & "SUM(Inventory.Qty) AS 'Total Quantity'" _
                        & "FROM Inventory JOIN PartManagement " _
                        & "ON Inventory.PartNumber=PartManagement.PartNumber " _
                        & "GROUP BY PartManagement.PartNumber, PartManagement.PartType, " _
                        & "PartManagement.CGCode, PartManagement.PN_Desc;")
        End If

        If SQL.HasException(True) Then Exit Sub

        For i As Integer = 1 To SQL.DBDT.Rows.Count

            dgvInventory.Rows.Add(New Object() {SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("PartType"),
                                  SQL.DBDT.Rows(i - 1)("CGCode"), SQL.DBDT.Rows(i - 1)("PN_Desc"),
                                  SQL.DBDT.Rows(i - 1)("NoC"), SQL.DBDT.Rows(i - 1)("Total Quantity")})
        Next
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        Label2.Text = dgvInventory.CurrentCell.Value
        frmInventoryPart.Text = "Inventory for Part Number: " + dgvInventory.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub dgvInventory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellDoubleClick
        'frmInventoryPart.Text = "Inventory for Part Number: " + dgvInventory.CurrentRow.Cells(0).Value.ToString

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
                If txtSearch.Text = "" Then
                    searchMode = False
                Else
                    searchMode = True

                    Dim dataTypes As String() = {"PartManagement.PartNumber", "PartManagement.PartType",
                                                "PartManagement.CGCode", "PartManagement.PN_Desc"}

                    searchType = dataTypes(cbxSearch.SelectedIndex)

                    searchText = txtSearch.Text.Trim.ToUpper
                End If
                LoadDatatoDGV()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub DeletePartNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePartNumberToolStripMenuItem.Click

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