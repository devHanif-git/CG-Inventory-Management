﻿Imports Microsoft.Office.Interop
Public Class frmImport

    Public SQL As New SQLControl
    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        dgvImport.DoubleBuffered(True)
        lblred.Left = (lblred.Parent.Width \ 2) - (lblred.Width \ 2) 'horizontal centering
        btnBrowse.Focus()
        SetupDGV()
    End Sub

    Private Sub SetupDGV()
        Dim dataGridViewRec As DataGridView = dgvImport

        dataGridViewRec.RowHeadersVisible = False
        dataGridViewRec.EnableHeadersVisualStyles = False
        dataGridViewRec.ColumnCount = 5

        dataGridViewRec.Columns(0).Name = "Part Number"
        dataGridViewRec.Columns(1).Name = "Part Type"
        dataGridViewRec.Columns(2).Name = "CG Code"
        dataGridViewRec.Columns(3).Name = "Part Description"
        dataGridViewRec.Columns(4).Name = "Qty Per Part"

        dataGridViewRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewRec.AutoResizeColumns()

        dataGridViewRec.Columns("Part Number").Width = 180
        dataGridViewRec.Columns("Part Type").Width = 128
        dataGridViewRec.Columns("CG Code").Width = 160
        dataGridViewRec.Columns("Part Description").Width = 350
        dataGridViewRec.Columns("Qty Per Part").Width = 100

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

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range
        Dim xlRow As Integer

        Dim strFileName As String

        dgvImport.Rows.Clear()
        dgvImport.Refresh()

        Try
            With OpenFileDialog1
                .Filter = "Excel Office| *.xls;*.xlsx"
                .InitialDirectory = Application.StartupPath
                .ShowDialog()
                strFileName = .FileName
            End With

            If strFileName <> String.Empty Then
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Open(strFileName)
                xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
                xlRange = xlWorkSheet.UsedRange

                If xlRange.Cells(1, 1).Text <> "PartNumber" And xlRange.Cells(1, 2).Text <> "Type" And xlRange.Cells(1, 3).Text <> "CGCode" And xlRange.Cells(1, 4).Text <> "Description" And xlRange.Cells(1, 5).Text <> "QPP" Then
                    MsgBox("Wrong Template!", MsgBoxStyle.Critical)
                    btnBrowse.Focus()
                    Exit Sub
                End If

                If xlRange.Rows.Count < 2 Then
                    MessageBox.Show("This file contains no data.", "Import Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnBrowse.Focus()
                    Exit Sub
                End If

                For xlRow = 2 To xlRange.Rows.Count
                    If xlRange.Cells(xlRow, 1).Text <> String.Empty And xlRange.Cells(xlRow, 2).Text <> String.Empty And xlRange.Cells(xlRow, 3).Text <> String.Empty And xlRange.Cells(xlRow, 4).Text <> String.Empty And xlRange.Cells(xlRow, 5).Text <> String.Empty Then
                        dgvImport.Rows.Add(New Object() {xlRange.Cells(xlRow, 1).Text, xlRange.Cells(xlRow, 2).Text, xlRange.Cells(xlRow, 3).Text,
                                       xlRange.Cells(xlRow, 4).Text, xlRange.Cells(xlRow, 5).Text})
                    End If
                Next
                xlWorkBook.Close()
                xlApp.Quit()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Function ExPN(pn As String) As Boolean
        SQL.AddParam("@pn", pn)

        SQL.ExecQuery("SELECT TOP 1 * FROM PartManagement WHERE PartNumber = @pn")
        Dim result As Boolean = False
        If SQL.RecordCount > 0 Then
            result = True
        End If
        Return result
    End Function

    Private Sub SaveMM()
        'get current user
        SQL.AddParam("@name", frmMain.lblUser.Text)
        SQL.ExecQuery("SELECT UserID FROM Users WHERE Name = @name")

        If SQL.RecordCount < 1 Then Exit Sub
        Dim uid As String = ""
        For Each r As DataRow In SQL.DBDT.Rows
            uid = r("UserID")
        Next
        For i As Integer = 1 To dgvImport.Rows.Count

            Dim oldpn As String = dgvImport.Rows(i - 1).Cells("Part Number").Value
            Dim checkpn As Boolean = ExPN(oldpn)
            If checkpn Then

                SQL.AddParam("@pn", dgvImport.Rows(i - 1).Cells("Part Number").Value)
                SQL.AddParam("@type", dgvImport.Rows(i - 1).Cells("Part Type").Value.ToUpper)
                SQL.AddParam("@code", dgvImport.Rows(i - 1).Cells("CG Code").Value)
                SQL.AddParam("@desc", dgvImport.Rows(i - 1).Cells("Part Description").Value)
                SQL.AddParam("@qpr", dgvImport.Rows(i - 1).Cells("Qty Per Part").Value)
                SQL.AddParam("@uid", uid.ToString)
                SQL.AddParam("@oldpn", oldpn.ToString)

                SQL.ExecQuery("UPDATE PartManagement SET PartNumber = @pn, PartType = @type, CGCode = @code, " _
                              & "PN_Desc = @desc, QtyPerPart = @qpr, UpdateTime = GETDATE(), Updater = @uid " _
                              & "WHERE PartNumber = @oldpn")
            Else

                SQL.AddParam("@pn", dgvImport.Rows(i - 1).Cells("Part Number").Value)
                SQL.AddParam("@type", dgvImport.Rows(i - 1).Cells("Part Type").Value.ToUpper)
                SQL.AddParam("@code", dgvImport.Rows(i - 1).Cells("CG Code").Value)
                SQL.AddParam("@desc", dgvImport.Rows(i - 1).Cells("Part Description").Value)
                SQL.AddParam("@qpr", dgvImport.Rows(i - 1).Cells("Qty Per Part").Value)
                SQL.AddParam("@uid", uid.ToString)

                SQL.ExecQuery("INSERT INTO PartManagement(PartNumber, PartType, CGCode, PN_Desc, QtyPerPart, UpdateTime, Updater) " _
                            & "VALUES (@pn, @type, @code, @desc, @qpr, GETDATE(), @uid)")
            End If
        Next
        If SQL.HasException(True) Then Exit Sub

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvImport.Rows.Count < 1 Then
            MessageBox.Show("Please first import the excel/template file.", "Import Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnBrowse.Focus()
            Exit Sub
        End If
        SaveMM()
        dgvImport.Rows.Clear()
        dgvImport.Refresh()
        frmMain.btnMM.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvImport.Rows.Clear()
        dgvImport.Refresh()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        dgvImport.Rows.Clear()
        dgvImport.Refresh()
        Me.Close()
    End Sub
End Class