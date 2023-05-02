Public Class frmML
    Public SQL As New SQLControl

    Private currentPage As Integer = 1
    Private pageSize As Integer = 100
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private pageType As Integer = 0
    Private searchMode As Boolean
    Private searchType As String = ""
    Private searchText As String = ""

    Private Sub frmML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()
        dgvLog.DoubleBuffered(True)
        SetupDGV()

        LoadData(999)

        cbxSearch.SelectedIndex = 0
        cbxType.SelectedIndex = 0
        Loading.Close()
        Me.Show()
        txtSearch.Focus()

    End Sub

    Private Sub LoadData(type As Integer)
        Dim query As String = "SELECT COUNT(*) FROM PartLog"

        If type <> 999 And searchMode = False Then
            SQL.AddParam("@type", type)
            query &= " WHERE Type = @type"

        ElseIf type <> 999 And searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            SQL.AddParam("@type", type)
            query &= " WHERE Type = @type AND " & searchType & " LIKE @searchText"

        ElseIf type = 999 And searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            query &= " WHERE " & searchType & " LIKE @searchText"

        End If

        SQL.ExecQuery(query)

        If SQL.HasException(True) Then Exit Sub

        totalRecords = SQL.DBDT.Rows(0)(0)

        ' Calculate the number of pages needed
        totalPages = Math.Ceiling(totalRecords / pageSize)

        lblTotalHis.Text = If(totalPages < 1, "0 records overall, 0 pages, and 100 records per page.",
            String.Format("{0} records overall, {1} pages, and 100 records per page.", totalRecords, totalPages))

        ' Update the navigation buttons
        UpdateNavButtons()

        ' Load first page of data
        LoadDatatoDGV()
    End Sub

    Private Sub CalculateFunction(mode As Integer)
        If dgvLog.SelectedRows.Count > 0 And mode = 0 Then 'for out
            Dim total As Integer = 0
            For Each row As DataGridViewRow In dgvLog.SelectedRows
                If row.Cells("Quantity Out").Value.ToString().StartsWith("+") Or row.Cells("Quantity Out").Value.ToString() = "-" Then
                    total += 0
                Else
                    total += CInt(row.Cells("Quantity Out").Value)
                End If
            Next
            MessageBox.Show("Total Quantity Out: " & total)
        ElseIf dgvLog.SelectedRows.Count > 0 And mode = 1 Then  'for in
            Dim total As Integer = 0
            For Each row As DataGridViewRow In dgvLog.SelectedRows
                If Not row.Cells("Type").Value.ToString().StartsWith("Part Stock In") Then
                    MessageBox.Show("Please select the correct row/type before pressing the calculate button.")
                    Exit Sub
                End If

                If row.Cells("Type").Value.ToString().StartsWith("Part Stock In") Then
                    total += CInt(row.Cells("Quantity").Value)
                Else
                    total += 0
                End If
            Next
            MessageBox.Show("Total Quantity In: " & total)
        Else
            MessageBox.Show("Please select at least one row before pressing the calculate button.")
        End If
    End Sub

    Private Sub UpdateNavButtons()
        btnFirst.Enabled = (currentPage > 1)
        btnPrev.Enabled = (currentPage > 1)
        btnNext.Enabled = (currentPage < totalPages)
        btnLast.Enabled = (currentPage < totalPages)

        ' Update the page label
        lblPage.Text = If(totalPages < 1, "Page 0 of 0", String.Format("Page {0} of {1}", currentPage, totalPages))
    End Sub

    Private Sub SetupDGV()
        With dgvLog
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 12
            .RowTemplate.Height = 35
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)
            .ColumnHeadersDefaultCellStyle.Font = New Font(.Font, FontStyle.Bold)

            Dim columns As String() = {"No.", "Record Time", "Part Number", "CGID", "Quantity", "Quantity Out",
                                       "Location", "GRN Number", "MTF Number", "Type", "Updater", "Remark"}
            Dim widths As Integer() = {40, 100, 150, 150, 75, 75, 78, 120, 110, 180, 90}
            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next

            ' dataGridViewRec.Columns("Date Code").DefaultCellStyle.Format = "dd-MM-yyyy"
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvLog.Rows.Clear()

        ' Retrieve the records for the current page
        Dim offset As Integer = (currentPage - 1) * pageSize
        SQL.AddParam("@offset", offset)
        SQL.AddParam("@fetch", pageSize)

        If pageType <> 0 And searchMode = False Then
            'Query for != "Show All" but without search.
            SQL.AddParam("@type", pageType - 1)
            SQL.ExecQuery("SELECT * FROM PartLog WHERE Type = @type ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY")

        ElseIf pageType <> 0 And searchMode Then
            'Query for Selection Mode != "Show All" but Make search.
            SQL.AddParam("@searchText", "%" & searchText & "%")
            SQL.AddParam("@type", pageType - 1)
            SQL.ExecQuery("SELECT * FROM PartLog WHERE Type = @type AND " & searchType & " LIKE @searchText ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY")

        ElseIf pageType = 0 And searchMode = False Then
            'Query for "Show All" but without search.
            SQL.ExecQuery("SELECT * FROM PartLog ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY")

        ElseIf pageType = 0 And searchMode Then
            'Query for "Show All" but Make Search.
            SQL.AddParam("@searchText", "%" & searchText & "%")
            SQL.ExecQuery("SELECT * FROM PartLog WHERE " & searchType & " LIKE @searchText ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY")

        End If

        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim texttype As String

                Dim typeTexts() As String = {"Incoming Print Label", "Part Stock In After Printing",
                    "Part Stock In", "Part Issued (Material Requisition)", "Part Over Request",
                    "Part Issued (Others)", "Return And Stock In Complete"}

                texttype = typeTexts(SQL.DBDT.Rows(i - 1)("Type"))

                Dim textout As String

                textout = If(SQL.DBDT.Rows(i - 1)("QtyOut") = 0, "-", SQL.DBDT.Rows(i - 1)("QtyOut"))
                If SQL.DBDT.Rows(i - 1)("QtyOut").ToString.StartsWith("-") Then
                    textout = "+" & textout.Substring(1)
                End If

                Dim textmtf As String
                Dim textgrn As String

                textmtf = If(String.IsNullOrEmpty(SQL.DBDT.Rows(i - 1)("MTFNumber").ToString()), "-", SQL.DBDT.Rows(i - 1)("MTFNumber"))
                textgrn = If(String.IsNullOrEmpty(SQL.DBDT.Rows(i - 1)("GRN").ToString()), "-", SQL.DBDT.Rows(i - 1)("GRN"))

                dgvLog.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("CGID"),
                                SQL.DBDT.Rows(i - 1)("Qty"), textout, SQL.DBDT.Rows(i - 1)("Rack"), textgrn, textmtf, texttype,
                                SQL.DBDT.Rows(i - 1)("Updater"), SQL.DBDT.Rows(i - 1)("Remark")})


                If texttype = "STATE 0" Then
                    '    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.FromArgb(255, 192, 192)
                    '
                ElseIf texttype = "STATE 1" Then
                    '    'dgvInventory.Rows(i - 1).Cells("State").Style.BackColor = Color.Blue
                    '
                End If
            Next

        End If
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Then
            dgvLog.ClearSelection()
            Return
        End If

        Dim text As String = cbxSearch.Text

        For i As Integer = 1 To dgvLog.Rows.Count
            If InStr(dgvLog.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvLog.ClearSelection()
                dgvLog.Rows(i - 1).Selected = True
                dgvLog.FirstDisplayedScrollingRowIndex = (i - 1)
                Return
            End If

            If Not InStr(dgvLog.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvLog.ClearSelection()
            End If
        Next
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        Dim typetext As String
        currentPage = 1

        pageType = cbxType.SelectedIndex
        typetext = If(pageType = 0, 999, pageType - 1)

        LoadData(typetext)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try

                If txtSearch.Text = "" Then
                    searchMode = False
                Else
                    currentPage = 1
                    searchMode = True

                    Dim dataTypes As String() = {"PartNumber", "CGID", "Rack", "GRN", "MTFNumber", "Remark"}

                    searchType = dataTypes(cbxSearch.SelectedIndex)

                    searchText = txtSearch.Text.Trim.ToUpper
                End If

                LoadData(If(pageType = 0, 999, pageType - 1))
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub dgvLog_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvLog.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim hti = dgvLog.HitTest(e.X, e.Y)
            If hti.RowIndex = -1 Then Return

            'dgvLog.ClearSelection()
            dgvLog.Rows(hti.RowIndex).Selected = True

        End If
    End Sub

    Private Sub CalcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItem.Click
        CalculateFunction(0)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        ' Set current page to 1 and reload data
        currentPage = 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ' Decrement current page and reload data
        currentPage -= 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Increment current page and reload data
        currentPage += 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ' Set current page to last page and reload data
        currentPage = totalPages
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub CalculateTotalOfQuantityInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateTotalOfQuantityInToolStripMenuItem.Click
        CalculateFunction(1)
    End Sub
End Class