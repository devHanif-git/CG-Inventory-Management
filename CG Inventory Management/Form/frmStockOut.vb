Public Class frmStockOut
    Public SQL As New SQLControl
    Dim oldscan As String
    Dim valid As Boolean
    Private Sub frmStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()
        lblMessageLogs.Left = (lblMessageLogs.Parent.Width \ 2) - (lblMessageLogs.Width \ 2) 'horizontal centering
        'Label1.Top = (Label1.Parent.Height \ 2) - (Label1.Height \ 2) ' Ver centering
        Loading.Close()
        Me.Show()
        txtScan.Focus()
    End Sub

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                If txtScan.Text = "" Then
                    Exit Sub
                End If

                If txtScan.Text.Trim = oldscan Then
                    If btnDO.Enabled = False Then
                        txtScan.Select(0, txtScan.Text.Length)
                        txtScan.Focus()
                        Exit Sub
                    End If
                    btnDO.PerformClick()
                    txtScan.Text = ""
                    Exit Sub
                End If

                oldscan = txtScan.Text.Trim

                Dim str As String
                Dim strArr() As String
                Dim strCGID As String
                Dim strCGCode As String

                Dim count As Integer

                Dim strC(5) As String 'collect

                str = txtScan.Text.Trim
                strArr = str.Split(";")

                For count = 0 To strArr.Length - 1
                    strC(count) = strArr(count)
                Next

                'cancel if read less than 3 ";"
                If count < 3 Then
                    txtPN.Text = ""
                    txtDC.Text = ""
                    txtGRN.Text = ""
                    txtCode.Text = ""
                    txtCGID.Text = ""
                    txtLoc.Text = ""
                    txtRemark.Text = ""
                    txtQty.Text = "0"
                    btnIssue.Checked = True
                    btnDO.Enabled = False
                    txtEmployeeID.ReadOnly = True
                    txtStockOutRemark.ReadOnly = True
                    txtMTF.ReadOnly = True
                    txtScan.Focus()
                    txtScan.Select(0, txtScan.Text.Length)
                    Exit Sub
                End If

                strCGID = strC(1)
                strCGCode = strC(4)

                SQL.AddParam("@cgid", strCGID)
                SQL.ExecQuery("SELECT TOP 1 * FROM Inventory WHERE CGID = @cgid")

                If SQL.HasException(True) Then Exit Sub

                If SQL.RecordCount > 0 Then
                    txtScan.Text = ""
                    Dim strDate As DateTime
                    strDate = DateTime.Parse(SQL.DBDT.Rows(0)("DateCode"), System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
                    Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
                    formatInfo.LongDatePattern = "dd/MM/yyyy"
                    Dim strStartDate As String = strDate.ToString("dd/MM/yyyy", formatInfo)

                    txtPN.Text = SQL.DBDT.Rows(0)("PartNumber")
                    txtDC.Text = strStartDate
                    txtGRN.Text = SQL.DBDT.Rows(0)("GRN")
                    txtCode.Text = strCGCode
                    txtCGID.Text = SQL.DBDT.Rows(0)("CGID")
                    txtLoc.Text = SQL.DBDT.Rows(0)("Rack")
                    txtRemark.Text = SQL.DBDT.Rows(0)("Remark")
                    txtQty.Text = SQL.DBDT.Rows(0)("Qty")


                    txtMTF.ReadOnly = False
                    txtEmployeeID.ReadOnly = False
                    txtStockOutRemark.ReadOnly = False
                    btnDO.Enabled = True

                    If valid Then
                        txtScan.Focus()
                    Else
                        txtMTF.Focus()
                    End If
                Else
                    MessageBox.Show("This part is not available on the rack!" & vbCrLf &
                                            "Please begin with a stockin or return.", "Part not available!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPN.Text = ""
                    txtDC.Text = ""
                    txtGRN.Text = ""
                    txtCode.Text = ""
                    txtCGID.Text = ""
                    txtLoc.Text = ""
                    txtRemark.Text = ""
                    txtQty.Text = "0"
                    btnIssue.Checked = True
                    btnDO.Enabled = False
                    txtEmployeeID.ReadOnly = True
                    txtStockOutRemark.ReadOnly = True
                    txtMTF.ReadOnly = True
                    txtScan.Focus()
                    txtScan.Select(0, txtScan.Text.Length)
                End If
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtMTF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMTF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtEmployeeID.Focus()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtStockOutRemark.Focus()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtStockOutRemark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockOutRemark.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnDO.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub DoInsert()
        Dim strDate As DateTime
        strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
        'Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
        'formatInfo.LongDatePattern = "MM/dd/yyyy"
        'Dim strStartDate As String = strDate.ToString("MM/dd/yyyy", formatInfo)

        Dim type As Integer = 0

        If btnIssue.Checked = True Then
            type = 3
        ElseIf btnOverIssue.Checked = True Then
            type = 4
        ElseIf btnOthers.Checked = True Then
            type = 5
        End If

        SQL.AddParam("@printcode", oldscan)
        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@pn", txtPN.Text.Trim)
        SQL.AddParam("@rack", txtLoc.Text.Trim)
        SQL.AddParam("@mtf", txtMTF.Text.Trim)
        SQL.AddParam("@type", type)
        SQL.AddParam("@dc", strDate)
        SQL.AddParam("@qty", txtQty.Text.Trim)
        SQL.AddParam("@grn", txtGRN.Text.Trim)
        SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
        SQL.AddParam("@remark", txtStockOutRemark.Text.Trim)


        SQL.ExecQuery("INSERT INTO PartOut(PrintCode, CGID, PartNumber, Rack, MTFNumber, Type, DateCode, Qty, GRN," _
                      & " UpdateTime, Updater, State, Remark) VALUES(@printcode, @cgid, @pn, @rack, @mtf, @type, @dc, @qty, @grn, GETDATE(), @uid, 0, @remark)")

        If SQL.HasException(True) Then Exit Sub

        SQL.AddParam("@printcode", oldscan)
        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@pn", txtPN.Text.Trim)
        SQL.AddParam("@rack", txtLoc.Text.Trim)
        SQL.AddParam("@mtf", txtMTF.Text.Trim)
        SQL.AddParam("@type", type)
        SQL.AddParam("@dc", strDate)
        SQL.AddParam("@qty", txtQty.Text.Trim)
        SQL.AddParam("@grn", txtGRN.Text.Trim)
        SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
        SQL.AddParam("@remark", txtStockOutRemark.Text.Trim)

        SQL.ExecQuery("INSERT INTO PartLog(RecordTime, PartNumber, CGID, Qty, QtyOut, Rack, GRN, MTFNumber, Type, Updater, Remark) " _
                                          & "VALUES(GETDATE(), @pn, @cgid, @qty, @qty, @rack, @grn, @mtf, @type, @uid, @remark);")

        If SQL.HasException(True) Then Exit Sub

        txtMsgLog.Text += "Stock out complete: " & txtCGID.Text & vbCrLf
        txtMsgLog.Select(txtMsgLog.TextLength - 37, 37)
        txtMsgLog.SelectionColor = Color.Green

        txtPN.Text = ""
        txtDC.Text = ""
        txtGRN.Text = ""
        txtCode.Text = ""
        txtCGID.Text = ""
        txtLoc.Text = ""
        txtRemark.Text = ""
        txtQty.Text = "0"
        btnIssue.Checked = True
        btnDO.Enabled = False
        txtEmployeeID.ReadOnly = True
        txtStockOutRemark.ReadOnly = True
        txtMTF.ReadOnly = True
        txtScan.Focus()
        txtScan.Select(0, txtScan.Text.Length)
    End Sub

    Private Sub DoOut()
        SQL.AddParam("@cgid", txtCGID.Text)
        SQL.ExecQuery("DELETE FROM Inventory WHERE CGID = @cgid")

        If SQL.HasException(True) Then Exit Sub
        DoInsert()
    End Sub

    Private Sub btnDO_Click(sender As Object, e As EventArgs) Handles btnDO.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("Please enter your employee id.", "Employee ID!")
            txtEmployeeID.Focus()
        Else
            SQL.AddParam("@uid", txtEmployeeID.Text)
            SQL.ExecQuery("SELECT TOP 1 * FROM Users Where UserID = @uid")

            If SQL.RecordCount > 0 Then
                DoOut()
                valid = True
            Else
                MessageBox.Show("Employee ID not found.", "Employee ID!")
                txtEmployeeID.Focus()
                txtEmployeeID.Select(0, txtEmployeeID.Text.Length)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtMTF_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMTF.KeyDown
        ' Get the value of the textbox
        Dim value As String = txtMTF.Text

        ' Check if the textbox has reached the maximum length of the pattern
        If txtMTF.Text.Length >= 12 And Not e.KeyCode = Keys.Back Then
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
            txtMTF.Text = value.Substring(0, 3) & "/" & value.Substring(3)

            ' Move the cursor to the position after the "/" character
            txtMTF.SelectionStart = 4
        End If

        If value.Length = 7 AndAlso value(6) <> "/" Then

            txtMTF.Text = value.Substring(0, 7) & "/" & value.Substring(7)

            txtMTF.SelectionStart = 8
        End If
    End Sub

    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged
        valid = False
    End Sub
End Class