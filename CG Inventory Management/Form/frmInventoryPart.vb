Public Class frmInventoryPart
    Public SQL As New SQLControl

    Private searchMode As Boolean
    Private searchType As String = ""
    Private searchText As String = ""

    Private Sub frmInventoryPart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        dgvInventory.DoubleBuffered(True)
        LoadDatatoInventoryPart()

        cbxSearch.SelectedIndex = 0
        txtSearch.Focus()
    End Sub

    Private Sub LoadDatatoInventoryPart()
        dgvInventory.Rows.Clear()

        If searchMode Then
            SQL.AddParam("@pn", lblpn.Text)
            SQL.AddParam("@filter", "%" & searchText & "%")

            SQL.ExecQuery("SELECT * FROM Inventory WHERE PartNumber = @pn AND " & searchType & " LIKE @filter ORDER BY DateCode, Qty")
        Else
            SQL.AddParam("@pn", lblpn.Text)
            SQL.ExecQuery("SELECT * FROM Inventory WHERE PartNumber = @pn ORDER BY DateCode, Qty")
        End If

        If SQL.HasException(True) Then Exit Sub

        'MsgBox(SQL.RecordCount)
        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim textstate As String = ""

                If SQL.DBDT.Rows(i - 1)("State") = 0 Then
                    textstate = "-"

                ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                    textstate = "-"
                End If

                dgvInventory.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("CGID"), SQL.DBDT.Rows(i - 1)("PartNumber"),
                                                       SQL.DBDT.Rows(i - 1)("Rack"), SQL.DBDT.Rows(i - 1)("DateCode"), SQL.DBDT.Rows(i - 1)("Qty"),
                                                       SQL.DBDT.Rows(i - 1)("GRN"), SQL.DBDT.Rows(i - 1)("UpdateTime"), SQL.DBDT.Rows(i - 1)("Updater"),
                                                       textstate, SQL.DBDT.Rows(i - 1)("Remark")})

                If textstate = "STATE 0" Then
                    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.FromArgb(255, 192, 192)

                ElseIf textstate = "STATE 1" Then
                    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.Blue

                ElseIf textstate = "STATE 2" Then
                    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.Green

                ElseIf textstate = "STATE 3" Then
                    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.Black
                End If

            Next
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        txtSearch.Focus()
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

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                If txtSearch.Text = "" Then
                    searchMode = False
                Else
                    searchMode = True

                    Dim dataTypes As String() = {"CGID", "Rack", "Qty", "GRN", "Remark"}

                    searchType = dataTypes(cbxSearch.SelectedIndex)

                    searchText = txtSearch.Text.Trim.ToUpper
                End If
                LoadDatatoInventoryPart()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub CalcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItem.Click
        frmFindExact.ShowDialog()
    End Sub
End Class