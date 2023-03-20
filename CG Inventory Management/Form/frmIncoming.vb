Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class frmIncoming
    Dim _btw_path = ""
    Dim _PrinterName = ""
    Public SQL As New SQLControl

    Dim flagpn As Boolean = False
    Private Sub frmIncoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()

        lblMessageLogs.Left = (lblMessageLogs.Parent.Width \ 2) - (lblMessageLogs.Width \ 2) 'horizontal centering
        'Label1.Top = (Label1.Parent.Height \ 2) - (Label1.Height \ 2) ' Ver centering

        txtPN.Focus()

        Dim printers As Seagull.BarTender.Print.Printers = New Seagull.BarTender.Print.Printers()

        If printers.Count > 0 Then
            _PrinterName = printers.[Default].PrinterName
        End If

        _btw_path = Application.StartupPath + "\Barcode.btw"
        txtPN.Focus()
    End Sub

    Private Sub GetRack()
        Dim name As String

        Dim codes As String() = {"MCT", "KTXS", "ACM", "GPI", "PCBLITE"}
        name = Array.Find(codes, Function(x) txtCode.Text.Trim.Contains(x))
        If name = "PCBLITE" Then name = "PCB LITE"
        If name Is Nothing Then name = ""

        'If InStr(txtCode.Text.Trim, "MCT") Then
        '    name = "MCT"
        'ElseIf InStr(txtCode.Text.Trim, "KTXS") Then
        '    name = "KTXS"
        'ElseIf InStr(txtCode.Text.Trim, "ACM") Then
        '    name = "ACM"
        'ElseIf InStr(txtCode.Text.Trim, "GPI") Then
        '    name = "GPI"
        'ElseIf InStr(txtCode.Text.Trim, "PCBLITE") Then
        '    name = "PCB LITE"
        'Else
        '    name = ""
        'End If

        If name <> "" Then
            SQL.AddParam("@name", "%" & name & "%")
            SQL.ExecQuery("SELECT * FROM Rack WHERE RackName LIKE @name OR RackName LIKE '%IC%' ORDER BY CASE WHEN RackName LIKE '%IC%' THEN 1 ELSE NULL END;")
            'SQL.ExecQuery("SELECT * FROM Rack WHERE RackName LIKE @name")
        Else
            SQL.ExecQuery("SELECT * FROM Rack")
        End If

        If SQL.HasException(True) Then Exit Sub
        cbxLoc.Items.Clear()

        For Each r As DataRow In SQL.DBDT.Rows
            cbxLoc.Items.Add(r("RackName"))
        Next
    End Sub

    Private Sub PrintBar(ByVal Optional isPreView As Boolean = False)
        Using btEngine As Seagull.BarTender.Print.Engine = New Seagull.BarTender.Print.Engine(True)
            Dim labelFormat As Seagull.BarTender.Print.LabelFormatDocument = btEngine.Documents.Open(_btw_path)

            Try
                'QR Code
                labelFormat.SubStrings.SetSubString("pn", txtPN.Text.Trim)
                labelFormat.SubStrings.SetSubString("cgid", txtCGID.Text.Trim)
                labelFormat.SubStrings.SetSubString("grn", txtGRN.Text.Trim)
                labelFormat.SubStrings.SetSubString("dc", txtDC.Text.Trim)
                labelFormat.SubStrings.SetSubString("cgcode", txtCode.Text.Trim)
                labelFormat.SubStrings.SetSubString("qty", txtQty.Value.ToString)
                'Others
            Catch ex As Exception
                MessageBox.Show("Error in modifying content" & ex.Message, "Printing Error!")
            End Try

            If isPreView Then Return

            If _PrinterName <> "" Then
                labelFormat.PrintSetup.PrinterName = _PrinterName
                labelFormat.Print("CGIM" & DateTime.Now, 5)

                txtMsgLog.Text += "Print complete: " & txtCGID.Text & vbCrLf
                txtMsgLog.Select(txtMsgLog.TextLength - 33, 33)
                txtMsgLog.SelectionColor = Color.Green

                txtPN.Focus()
            Else
                MessageBox.Show("Please select a printer first", "Select Printer!")
            End If
        End Using
    End Sub

    Private Sub txtQty_Enter(sender As Object, e As EventArgs) Handles txtQty.Enter
        txtQty.Select(0, txtQty.Text.Length)
    End Sub

    Private Sub txtPrintQ_Enter(sender As Object, e As EventArgs) Handles txtPrintQ.Enter
        txtPrintQ.Select(0, txtPrintQ.Text.Length)
    End Sub

    Private Function FindPN(pn As String) As Boolean
        SQL.AddParam("@pn", pn)
        SQL.ExecQuery("SELECT TOP 1 * FROM PartManagement WHERE PartNumber = @pn")
        Dim result As Boolean
        If SQL.RecordCount > 0 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Private Sub txtPN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPN.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                Dim fpn As Boolean = FindPN(txtPN.Text.Trim)
                If fpn Then
                    SQL.AddParam("@pn", txtPN.Text.Trim)

                    SQL.ExecQuery("SELECT TOP 1 * FROM PartManagement WHERE PartNumber = @pn")

                    txtCode.Text = SQL.DBDT.Rows(0)("CGCode").ToString
                    txtDesc.Text = SQL.DBDT.Rows(0)("PN_Desc").ToString
                    txtQty.Value = SQL.DBDT.Rows(0)("QtyPerPart").ToString

                    flagpn = True
                    txtDC.Focus()
                    GetRack()
                Else
                    If txtPN.Text = "" Then
                        GetRack()
                        Exit Sub
                    End If

                    txtMsgLog.Clear()
                    txtMsgLog.Text += "Part number entered is not available; please add this part number first." & vbCrLf
                    txtMsgLog.Select(txtMsgLog.TextLength - 73, 73)
                    txtMsgLog.SelectionColor = Color.Red
                    txtPN.Select(0, txtPN.Text.Length)
                    txtPrintQ.Value = 1
                    txtDC.Text = ""
                    txtQty.Text = "0"
                    txtGRN.Text = ""
                    txtCode.Text = ""
                    txtCGID.Text = ""
                    txtDesc.Text = ""
                    txtRemark.Text = ""

                    GetRack()
                    Exit Sub
                End If
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtPrintQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrintQ.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnPrint.PerformClick()
                txtPrintQ.Select(0, txtPrintQ.Text.Length)
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim GRN As String = txtGRN.Text.Trim
        Dim GRNStyle As String = "GRN/"
        Dim ret As Integer

        If flagpn = False Then
            txtMsgLog.Clear()
            txtMsgLog.Text += "Please enter part number first. (PRESS ENTER)" & vbCrLf
            txtMsgLog.Select(txtMsgLog.TextLength - 46, 46)
            txtMsgLog.SelectionColor = Color.Red
            flagpn = False
            txtPN.Focus()
            Exit Sub
        End If

        If GRN = "" Then
            MessageBox.Show("Please enter the GRN Number.!", "GRN Number!")
            txtGRN.Focus()
            Exit Sub
        End If

        ret = InStr(GRN, GRNStyle)

        If ret = 0 Then
            MessageBox.Show("Please enter a correct GRN Number.!", "GRN Number!")
            txtGRN.Focus()
            Exit Sub
        End If

        Dim dc As DateTime = Date.Today
        Dim reformatted As String = dc.ToString("yyMM")
        Dim dcnotfill As String = dc.ToString("dd/MM/yyyy")

        Dim n05 = "00000"
        Dim n04 = "0000"
        Dim n03 = "000"
        Dim n02 = "00"
        Dim n01 = "0"
        Dim n00 = ""

        If txtDC.Text = "" Then
            txtDC.Text = dcnotfill
        End If

        'CheckValidDate
        Dim regex As Regex = New Regex("(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$")

        'Verify whether date entered in dd/MM/yyyy format.
        Dim isValid As Boolean = regex.IsMatch(txtDC.Text.Trim)

        'Verify whether entered date is Valid date.
        Dim dt As DateTime
        isValid = DateTime.TryParseExact(txtDC.Text, "dd/MM/yyyy", New CultureInfo("en-GB"), DateTimeStyles.None, dt)
        If Not isValid Then
            txtMsgLog.Clear()
            txtMsgLog.Text += "Invalid Date Format!."
            txtMsgLog.Select(txtMsgLog.TextLength - 21, 21)
            txtMsgLog.SelectionColor = Color.Red
            txtMsgLog.Text += vbCrLf & "Use this format dd/MM/yyyy!" & vbCrLf
            txtMsgLog.Select(txtMsgLog.TextLength - 28, 28)
            txtMsgLog.SelectionColor = Color.Green
            txtDC.Focus()
            txtDC.Select(0, txtDC.Text.Length)
            Exit Sub
        End If

        SQL.ExecQuery("SELECT * FROM CGIDNum")

        If SQL.HasException(True) Then Exit Sub

        Dim CGIDNo As Integer = SQL.DBDT.Rows(0)("CGIDNo")
        Dim CGIDyyMM As String = SQL.DBDT.Rows(0)("CGIDYYMM")

        If reformatted <> CGIDyyMM Then 'bulan baru
            SQL.AddParam("@newyyMM", reformatted)

            SQL.ExecQuery("UPDATE CGIDNum SET CGIDYYMM = @newyyMM, CGIDNo = 1")

            If SQL.HasException(True) Then Exit Sub
            CGIDNo = "0"
            CGIDyyMM = reformatted
        End If

        If cbxStockIn.Checked = True Then
            'check rack and employee id if got proceed to next
            If cbxLoc.Text = "" Then
                MessageBox.Show("Please select location first.", "Select Location!")
                cbxLoc.Focus()
                cbxLoc.DroppedDown = True
                Cursor.Current = Cursors.Default
            ElseIf txtEmployeeID.Text = "" Then
                MessageBox.Show("Please enter your employee id.", "Employee ID!")
                txtEmployeeID.Focus()
            Else
                SQL.AddParam("@uid", txtEmployeeID.Text)
                SQL.ExecQuery("SELECT TOP 1 * FROM Users Where UserID = @uid")

                If SQL.RecordCount > 0 Then
                    Loading.Show()

                    For i As Integer = 1 To txtPrintQ.Value
                        If CGIDNo <= 9 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n05 & CGIDNo
                        End If
                        If CGIDNo >= 10 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n04 & CGIDNo
                        End If
                        If CGIDNo >= 100 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n03 & CGIDNo
                        End If
                        If CGIDNo >= 1000 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n02 & CGIDNo
                        End If
                        If CGIDNo >= 10000 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n01 & CGIDNo
                        End If
                        If CGIDNo >= 100000 Then
                            txtCGID.Text = "CGID-" & reformatted & "-" & n00 & CGIDNo
                        End If

                        Try
                            Dim strDate As DateTime
                            strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
                            Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
                            formatInfo.LongDatePattern = "MM/dd/yyyy"
                            Dim strStartDate As String = strDate.ToString("MM/dd/yyyy", formatInfo)

                            Dim printcode As String = txtPN.Text.Trim & ";" & txtCGID.Text.Trim & ";" & txtGRN.Text.Trim & ";" & txtDC.Text.Trim & ";" & txtCode.Text.Trim

                            SQL.AddParam("@printcode", printcode)
                            SQL.AddParam("@pn", txtPN.Text.Trim)
                            SQL.AddParam("@cgid", txtCGID.Text.Trim)
                            SQL.AddParam("@grn", txtGRN.Text.Trim)
                            SQL.AddParam("@dc", strStartDate)
                            SQL.AddParam("@qty", txtQty.Value.ToString)
                            SQL.AddParam("@cgcode", txtCode.Text.Trim)
                            SQL.AddParam("@remark", txtRemark.Text.Trim)

                            SQL.ExecQuery("INSERT INTO PrintedCode(PrintCode, CGID, PartNumber, DateCode, CGCode, Qty, GRN, Remark) VALUES(@printcode, @cgid, @pn, @dc, @cgcode, @qty, @grn, @remark);")

                            If SQL.HasException(True) Then Exit Sub

                            PrintBar()
                            CGIDNo += 1
                            SQL.AddParam("@newno", CGIDNo)
                            SQL.ExecQuery("UPDATE CGIDNum SET CGIDNo = @newno")

                            If SQL.HasException(True) Then Exit Sub

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        'stock in function here
                        Try
                            Dim strDate As DateTime
                            strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
                            Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
                            formatInfo.LongDatePattern = "MM/dd/yyyy"
                            Dim strStartDate As String = strDate.ToString("MM/dd/yyyy", formatInfo)

                            SQL.AddParam("@cgid", txtCGID.Text.Trim)
                            SQL.AddParam("@pn", txtPN.Text.Trim)
                            SQL.AddParam("@rack", cbxLoc.Text.Trim)
                            SQL.AddParam("@dc", strStartDate)
                            SQL.AddParam("@qty", txtQty.Value.ToString)
                            SQL.AddParam("@grn", txtGRN.Text.Trim)
                            SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                            SQL.AddParam("@remark", txtRemark.Text.Trim)

                            SQL.ExecQuery("INSERT INTO Inventory(CGID, PartNumber, Rack, DateCode, Qty, GRN, " _
                                          & "UpdateTime, Updater, State, Remark) " _
                                          & "VALUES(@cgid, @pn, @rack, @dc, @qty, @grn, GETDATE(), @uid, 0, @remark)")

                            If SQL.HasException(True) Then Exit Sub

                            SQL.AddParam("@cgid", txtCGID.Text.Trim)
                            SQL.AddParam("@pn", txtPN.Text.Trim)
                            SQL.AddParam("@rack", cbxLoc.Text.Trim)
                            SQL.AddParam("@dc", strStartDate)
                            SQL.AddParam("@qty", txtQty.Value.ToString)
                            SQL.AddParam("@grn", txtGRN.Text.Trim)
                            SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                            SQL.AddParam("@remark", txtRemark.Text.Trim)

                            SQL.ExecQuery("INSERT INTO PartLog(RecordTime, PartNumber, CGID, Qty, QtyOut, Rack, GRN, Type, Updater, Remark) " _
                                          & "VALUES(GETDATE(), @pn, @cgid, @qty, 0, @rack, @grn, 1, @uid, @remark);")

                            If SQL.HasException(True) Then Exit Sub

                            txtMsgLog.Text += "Stock in complete: " & txtCGID.Text & vbCrLf
                            txtMsgLog.Select(txtMsgLog.TextLength - 33, 33)
                            txtMsgLog.SelectionColor = Color.Green

                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                        End Try
                    Next
                    Loading.Close()
                Else
                    MessageBox.Show("Employee ID not found.", "Employee ID!")
                    txtEmployeeID.Focus()
                    txtEmployeeID.Select(0, txtEmployeeID.Text.Length)
                    Exit Sub
                End If

            End If
        Else
            Loading.Show()

            For i As Integer = 1 To txtPrintQ.Value
                If CGIDNo <= 9 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n05 & CGIDNo
                End If
                If CGIDNo >= 10 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n04 & CGIDNo
                End If
                If CGIDNo >= 100 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n03 & CGIDNo
                End If
                If CGIDNo >= 1000 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n02 & CGIDNo
                End If
                If CGIDNo >= 10000 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n01 & CGIDNo
                End If
                If CGIDNo >= 100000 Then
                    txtCGID.Text = "CGID-" & reformatted & "-" & n00 & CGIDNo
                End If

                Try
                    Dim strDate As DateTime
                    strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
                    Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
                    formatInfo.LongDatePattern = "MM/dd/yyyy"
                    Dim strStartDate As String = strDate.ToString("MM/dd/yyyy", formatInfo)

                    Dim printcode As String = txtPN.Text.Trim & ";" & txtCGID.Text.Trim & ";" & txtGRN.Text.Trim & ";" & txtDC.Text.Trim & ";" & txtCode.Text.Trim

                    SQL.AddParam("@printcode", printcode)
                    SQL.AddParam("@pn", txtPN.Text.Trim)
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.AddParam("@grn", txtGRN.Text.Trim)
                    SQL.AddParam("@dc", strStartDate)
                    SQL.AddParam("@qty", txtQty.Value.ToString)
                    SQL.AddParam("@cgcode", txtCode.Text.Trim)
                    SQL.AddParam("@remark", txtRemark.Text.Trim)

                    SQL.ExecQuery("INSERT INTO PrintedCode(PrintCode, CGID, PartNumber, DateCode, CGCode, Qty, GRN, Remark) VALUES(@printcode, @cgid, @pn, @dc, @cgcode, @qty, @grn, @remark);")
                    If SQL.HasException(True) Then Exit Sub


                    SQL.AddParam("@pn", txtPN.Text.Trim)
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.AddParam("@grn", txtGRN.Text.Trim)
                    SQL.AddParam("@qty", txtQty.Value.ToString)
                    SQL.AddParam("@remark", txtRemark.Text.Trim)

                    SQL.ExecQuery("INSERT INTO PartLog(RecordTime, PartNumber, CGID, Qty, QtyOut, GRN, Type, Remark) " _
                    & "VALUES(GETDATE(), @pn, @cgid, @qty, 0, @grn, 0, @remark);")

                    If SQL.HasException(True) Then Exit Sub
                    PrintBar()
                    CGIDNo += 1
                    SQL.AddParam("@newno", CGIDNo)
                    SQL.ExecQuery("UPDATE CGIDNum SET CGIDNo = @newno")

                    If SQL.HasException(True) Then Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            Loading.Close()
        End If

        If cbxClear.Checked = False Then
            txtPrintQ.Value = 1
        Else
            txtPrintQ.Value = 1
            txtPN.Text = ""
            txtDC.Text = ""
            txtQty.Text = "0"
            txtGRN.Text = ""
            txtCode.Text = ""
            txtCGID.Text = ""
            txtDesc.Text = ""
            txtRemark.Text = ""
        End If
    End Sub

    Private Sub cbxStockIn_CheckedChanged(sender As Object, e As EventArgs) Handles cbxStockIn.CheckedChanged
        If cbxStockIn.Checked = True Then

            GetRack()
            Guna2GroupBox1.Visible = True
        Else
            Guna2GroupBox1.Visible = False
        End If
    End Sub

    Private Sub txtDC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtGRN.Focus()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtGRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGRN.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtPrintQ.Focus()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtRemark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemark.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtPrintQ.Focus()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtGRN.Focus()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtPN_TextChanged(sender As Object, e As EventArgs) Handles txtPN.TextChanged
        flagpn = False
    End Sub

    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnPrint.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtGRN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGRN.KeyDown
        ' Get the value of the textbox
        Dim value As String = txtGRN.Text

        ' Check if the textbox has reached the maximum length of the pattern
        If txtGRN.Text.Length >= 12 And Not e.KeyCode = Keys.Back Then
            ' If the textbox has reached the maximum length, prevent any further input
            e.SuppressKeyPress = True
            Return
        End If

        ' Check if the backspace key was pressed
        If e.KeyCode = Keys.Back Then
            ' If the backspace key was pressed, skip the code that adds the "/" character
            Return
        End If

        ' Check if the third character is not a "/"
        If value.Length = 3 AndAlso value(2) <> "/" Then

            ' If it is not a "/" , add one after the third character
            txtGRN.Text = value.Substring(0, 3) & "/" & value.Substring(3)

            ' Move the cursor to the position after the "/" character
            txtGRN.SelectionStart = 4
        End If

        If value.Length = 7 AndAlso value(6) <> "/" Then

            txtGRN.Text = value.Substring(0, 7) & "/" & value.Substring(7)

            txtGRN.SelectionStart = 8
        End If
    End Sub

    Private Sub txtDC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDC.KeyDown
        ' Get the value of the textbox
        Dim value As String = txtDC.Text

        ' Check if the textbox has reached the maximum length of the pattern
        If txtDC.Text.Length >= 10 And Not e.KeyCode = Keys.Back Then
            ' If the textbox has reached the maximum length, prevent any further input
            e.SuppressKeyPress = True
            Return
        End If

        ' Check if the backspace key was pressed
        If e.KeyCode = Keys.Back Then
            ' If the backspace key was pressed, skip the code that adds the "/" character
            Return
        End If
        
        ' Check if the third character is not a "/"
        If value.Length = 2 AndAlso value(1) <> "/" Then

            ' If it is not a "/" , add one after the third character
            txtDC.Text = value.Substring(0, 2) & "/" & value.Substring(2)

            ' Move the cursor to the position after the "/" character
            txtDC.SelectionStart = 3
        End If

        If value.Length = 5 AndAlso value(4) <> "/" Then

            txtDC.Text = value.Substring(0, 5) & "/" & value.Substring(5)

            txtDC.SelectionStart = 6
        End If
    End Sub
End Class