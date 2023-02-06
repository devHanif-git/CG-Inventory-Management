Public Class frmML
    Public SQL As New SQLControl
    Private Sub frmML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        dgvLog.DoubleBuffered(True)
        SetupDGV()

        cbxSearch.SelectedIndex = 0
        cbxType.SelectedIndex = 0
        txtSearch.Focus()
    End Sub

    Private Sub SetupDGV()

        Dim dataGridViewRec As DataGridView = dgvLog

        dataGridViewRec.RowHeadersVisible = False
        dataGridViewRec.EnableHeadersVisualStyles = False
        dataGridViewRec.ColumnCount = 11

        dataGridViewRec.Columns(0).Name = "No."
        dataGridViewRec.Columns(1).Name = "Record Time"
        dataGridViewRec.Columns(2).Name = "Part Number"
        dataGridViewRec.Columns(3).Name = "CGID"
        dataGridViewRec.Columns(4).Name = "Quantity"
        dataGridViewRec.Columns(5).Name = "Quantity Out"
        dataGridViewRec.Columns(6).Name = "Location"
        dataGridViewRec.Columns(7).Name = "MTF Number"
        dataGridViewRec.Columns(8).Name = "Type"
        dataGridViewRec.Columns(9).Name = "Updater"
        dataGridViewRec.Columns(10).Name = "Remark"

        dataGridViewRec.RowTemplate.Height = 35
        dataGridViewRec.AllowUserToResizeRows = False

        dataGridViewRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewRec.AutoResizeColumns()

        dataGridViewRec.Columns("No.").Width = 40
        dataGridViewRec.Columns("CGID").Width = 150
        dataGridViewRec.Columns("Part Number").Width = 180
        dataGridViewRec.Columns("Location").Width = 78
        dataGridViewRec.Columns("Quantity").Width = 75
        dataGridViewRec.Columns("Record Time").Width = 105
        dataGridViewRec.Columns("Updater").Width = 90
        dataGridViewRec.Columns("Quantity Out").Width = 75
        dataGridViewRec.Columns("Type").Width = 200
        dataGridViewRec.Columns("MTF Number").Width = 120

        'dataGridViewRec.Columns("Date Code").DefaultCellStyle.Format = "dd-MM-yyyy"

        dataGridViewRec.RowsDefaultCellStyle.BackColor = Color.White
        dataGridViewRec.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)

        With dataGridViewRec.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(dataGridViewRec.Font, FontStyle.Bold)
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvLog.Rows.Clear()

        SQL.ExecQuery("SELECT * FROM PartLog ORDER BY RecordTime DESC")

        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim texttype As String

                If SQL.DBDT.Rows(i - 1)("Type") = 0 Then
                    texttype = "Incoming Print Label"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 1 Then
                    texttype = "Part Stock In After Printing"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 2 Then
                    texttype = "Part Stock In"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 3 Then
                    texttype = "Part Issued (Material Requisition)"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 4 Then
                    texttype = "Part Over Request"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 5 Then
                    texttype = "Part Issued (Others)"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 6 Then
                    texttype = "Return And Stock In Complete"
                Else
                    texttype = ""
                End If

                Dim textout As String

                If SQL.DBDT.Rows(i - 1)("QtyOut") = 0 Then
                    textout = "-"
                Else
                    textout = SQL.DBDT.Rows(i - 1)("QtyOut")
                    If textout.StartsWith("-") Then
                        textout = "+" & textout.Substring(1)
                    End If
                End If

                Dim textmtf As String

                If SQL.DBDT.Rows(i - 1)("MTFNumber").ToString = "" Then
                    textmtf = "-"
                Else
                    textmtf = SQL.DBDT.Rows(i - 1)("MTFNumber")
                    'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                    '    textstate = "-"
                End If

                dgvLog.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("CGID"),
                                SQL.DBDT.Rows(i - 1)("Qty"), textout, SQL.DBDT.Rows(i - 1)("Rack"), textmtf, texttype, ' SQL.DBDT.Rows(i - 1)("MTFNumber")
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
            'dgvInventory.CurrentCell = Nothing
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
        Dim typetext As String = ""

        If cbxType.SelectedIndex = 0 Then
            LoadDatatoDGV()
            Exit Sub
        ElseIf cbxType.SelectedIndex = 1 Then
            typetext = 0
        ElseIf cbxType.SelectedIndex = 2 Then
            typetext = 1
        ElseIf cbxType.SelectedIndex = 3 Then
            typetext = 2
        ElseIf cbxType.SelectedIndex = 4 Then
            typetext = 3
        ElseIf cbxType.SelectedIndex = 5 Then
            typetext = 4
        ElseIf cbxType.SelectedIndex = 6 Then
            typetext = 5
        ElseIf cbxType.SelectedIndex = 7 Then
            typetext = 6
        End If

        SQL.AddParam("@type", typetext)

        SQL.ExecQuery("SELECT * FROM PartLog WHERE Type = @type ORDER BY RecordTime DESC")

        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            dgvLog.Rows.Clear()

            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim texttype As String

                If SQL.DBDT.Rows(i - 1)("Type") = 0 Then
                    texttype = "Incoming Print Label"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 1 Then
                    texttype = "Part Stock In After Printing"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 2 Then
                    texttype = "Part Stock In"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 3 Then
                    texttype = "Part Issued (Material Requisition)"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 4 Then
                    texttype = "Part Over Request"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 5 Then
                    texttype = "Part Issued (Others)"

                ElseIf SQL.DBDT.Rows(i - 1)("Type") = 6 Then
                    texttype = "Return And Stock In Complete"
                Else
                    texttype = ""
                End If

                Dim textout As String

                If SQL.DBDT.Rows(i - 1)("QtyOut") = 0 Then
                    textout = "-"
                Else
                    textout = SQL.DBDT.Rows(i - 1)("QtyOut")
                    'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                    '    textstate = "-"
                End If

                Dim textmtf As String

                If SQL.DBDT.Rows(i - 1)("MTFNumber").ToString = "" Then
                    textmtf = "-"
                Else
                    textmtf = SQL.DBDT.Rows(i - 1)("MTFNumber")
                    'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                    '    textstate = "-"
                End If

                dgvLog.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("CGID"),
                                SQL.DBDT.Rows(i - 1)("Qty"), textout, SQL.DBDT.Rows(i - 1)("Rack"), textmtf, texttype, ' SQL.DBDT.Rows(i - 1)("MTFNumber")
                                SQL.DBDT.Rows(i - 1)("Updater"), SQL.DBDT.Rows(i - 1)("Remark")})
            Next

        Else
            dgvLog.Rows.Clear()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                Dim typetext As String = ""
                If cbxType.SelectedIndex = 0 Then
                    typetext = 9
                ElseIf cbxType.SelectedIndex = 1 Then
                    typetext = 0
                ElseIf cbxType.SelectedIndex = 2 Then
                    typetext = 1
                ElseIf cbxType.SelectedIndex = 3 Then
                    typetext = 2
                ElseIf cbxType.SelectedIndex = 4 Then
                    typetext = 3
                ElseIf cbxType.SelectedIndex = 5 Then
                    typetext = 4
                ElseIf cbxType.SelectedIndex = 6 Then
                    typetext = 5
                ElseIf cbxType.SelectedIndex = 7 Then
                    typetext = 6
                End If

                If txtSearch.Text = "" Then
                    If typetext = 9 Then
                        SQL.ExecQuery("SELECT * FROM PartLog ORDER BY RecordTime DESC")
                    Else
                        SQL.AddParam("@type", typetext)
                        SQL.ExecQuery("SELECT * FROM PartLog WHERE Type = @type ORDER BY RecordTime DESC")
                    End If

                    If SQL.HasException(True) Then Exit Sub

                    If SQL.RecordCount > 0 Then
                        dgvLog.Rows.Clear()

                        For i As Integer = 1 To SQL.DBDT.Rows.Count
                            Dim texttype As String

                            If SQL.DBDT.Rows(i - 1)("Type") = 0 Then
                                texttype = "Incoming Print Label"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 1 Then
                                texttype = "Part Stock In After Printing"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 2 Then
                                texttype = "Part Stock In"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 3 Then
                                texttype = "Part Issued (Material Requisition)"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 4 Then
                                texttype = "Part Over Request"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 5 Then
                                texttype = "Part Issued (Others)"

                            ElseIf SQL.DBDT.Rows(i - 1)("Type") = 6 Then
                                texttype = "Return And Stock In Complete"
                            Else
                                texttype = ""
                            End If

                            Dim textout As String

                            If SQL.DBDT.Rows(i - 1)("QtyOut") = 0 Then
                                textout = "-"
                            Else
                                textout = SQL.DBDT.Rows(i - 1)("QtyOut")
                                'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                                '    textstate = "-"
                            End If

                            Dim textmtf As String

                            If SQL.DBDT.Rows(i - 1)("MTFNumber").ToString = "" Then
                                textmtf = "-"
                            Else
                                textmtf = SQL.DBDT.Rows(i - 1)("MTFNumber")
                                'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                                '    textstate = "-"
                            End If

                            dgvLog.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("CGID"),
                                SQL.DBDT.Rows(i - 1)("Qty"), textout, SQL.DBDT.Rows(i - 1)("Rack"), textmtf, texttype, ' SQL.DBDT.Rows(i - 1)("MTFNumber")
                                SQL.DBDT.Rows(i - 1)("Updater"), SQL.DBDT.Rows(i - 1)("Remark")})
                        Next
                    End If
                End If

                Dim filtertext As String = ""
                If cbxSearch.SelectedIndex = 0 Then
                    filtertext = "PartNumber"
                ElseIf cbxSearch.SelectedIndex = 1 Then
                    filtertext = "CGID"
                ElseIf cbxSearch.SelectedIndex = 2 Then
                    filtertext = "Rack"
                ElseIf cbxSearch.SelectedIndex = 3 Then
                    filtertext = "MTFNumber"
                ElseIf cbxSearch.SelectedIndex = 4 Then
                    filtertext = "Remark"
                End If

                If typetext = 9 Then
                    SQL.AddParam("@filter", "%" & txtSearch.Text.Trim.ToUpper & "%")
                    SQL.ExecQuery("SELECT * FROM PartLog WHERE " & filtertext & " LIKE @filter ORDER BY RecordTime DESC")
                Else
                    SQL.AddParam("@type", typetext)
                    SQL.AddParam("@filter", "%" & txtSearch.Text.Trim.ToUpper & "%")

                    SQL.ExecQuery("SELECT * FROM PartLog WHERE Type = @type AND " & filtertext & " LIKE @filter ORDER BY RecordTime DESC")
                End If

                If SQL.HasException(True) Then Exit Sub

                If SQL.RecordCount > 0 Then
                    dgvLog.Rows.Clear()

                    For i As Integer = 1 To SQL.DBDT.Rows.Count
                        Dim texttype As String

                        If SQL.DBDT.Rows(i - 1)("Type") = 0 Then
                            texttype = "Incoming Print Label"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 1 Then
                            texttype = "Part Stock In After Printing"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 2 Then
                            texttype = "Part Stock In"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 3 Then
                            texttype = "Part Issued (Material Requisition)"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 4 Then
                            texttype = "Part Over Request"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 5 Then
                            texttype = "Part Issued (Others)"

                        ElseIf SQL.DBDT.Rows(i - 1)("Type") = 6 Then
                            texttype = "Return And Stock In Complete"
                        Else
                            texttype = ""
                        End If

                        Dim textout As String

                        If SQL.DBDT.Rows(i - 1)("QtyOut") = 0 Then
                            textout = "-"
                        Else
                            textout = SQL.DBDT.Rows(i - 1)("QtyOut")
                            'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                            '    textstate = "-"
                        End If

                        Dim textmtf As String

                        If SQL.DBDT.Rows(i - 1)("MTFNumber").ToString = "" Then
                            textmtf = "-"
                        Else
                            textmtf = SQL.DBDT.Rows(i - 1)("MTFNumber")
                            'ElseIf SQL.DBDT.Rows(i - 1)("State") = 1 Then
                            '    textstate = "-"
                        End If

                        dgvLog.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("PartNumber"), SQL.DBDT.Rows(i - 1)("CGID"),
                                SQL.DBDT.Rows(i - 1)("Qty"), textout, SQL.DBDT.Rows(i - 1)("Rack"), textmtf, texttype, ' SQL.DBDT.Rows(i - 1)("MTFNumber")
                                SQL.DBDT.Rows(i - 1)("Updater"), SQL.DBDT.Rows(i - 1)("Remark")})
                    Next
                End If

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
        If dgvLog.SelectedRows.Count > 0 Then
            Dim total As Integer = 0
            For Each row As DataGridViewRow In dgvLog.SelectedRows
                If row.Cells("Quantity Out").Value.ToString().StartsWith("+") Or row.Cells("Quantity Out").Value.ToString() = "-" Then
                    total += 0
                Else
                    total += CInt(row.Cells("Quantity Out").Value)
                End If
            Next
            MessageBox.Show("Total Quantity Out: " & total)
        Else
            MessageBox.Show("Please select at least one row before pressing the calculate button.")
        End If
    End Sub
End Class