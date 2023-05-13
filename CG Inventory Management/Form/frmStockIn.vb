Imports Seagull.BarTender.Print
Public Class frmStockIn
    Public SQL As New SQLControl
    Private oldscan As String
    Private oldpn As String
    Private _btw_path = ""
    Private _PrinterName = ""

    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Loading.Show()

        lblMessageLogs.Left = (lblMessageLogs.Parent.Width \ 2) - (lblMessageLogs.Width \ 2) 'horizontal centering
        'Label1.Top = (Label1.Parent.Height \ 2) - (Label1.Height \ 2) ' Ver centering

        Dim printers As Printers = New Printers()

        If printers.Count > 0 Then
            _PrinterName = printers.[Default].PrinterName
        End If

        _btw_path = Application.StartupPath + "\Barcode.btw"

        txtnew.Text = txtQty.Text - txtOut.Text

        Me.Show()
        Loading.Close()
        txtScan.Focus()
    End Sub

    Private Sub GetRack()
        Dim name As String

        Dim codes As String() = {"UMCG", "KTXS", "ACM", "GPI", "PCBLITE", "TEST"}
        name = Array.Find(codes, Function(x) txtCode.Text.Trim.Contains(x))
        If name = "PCBLITE" Then name = "PCB LITE"
        If name Is Nothing Then name = ""

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

    Private Sub btnStockIn_CheckedChanged(sender As Object, e As EventArgs) Handles btnStockIn.CheckedChanged
        lblOut.Visible = Not btnStockIn.Checked
        txtOut.Visible = Not btnStockIn.Checked
        lblnew.Visible = Not btnStockIn.Checked
        txtnew.Visible = Not btnStockIn.Checked

        btnDO.Text = If(btnStockIn.Checked, "Stock In", "Update")
        lblremarks.Text = If(btnStockIn.Checked, "Stock In Remark:", "Return Remark:")
    End Sub

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress

        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                If txtScan.Text = "" Then
                    Exit Sub
                End If

                Dim str As String
                Dim strArr() As String
                Dim strCGID As String

                Dim count As Integer

                Dim strC(5) As String

                str = txtScan.Text.Trim
                strArr = str.Split(";")

                For count = 0 To strArr.Length - 1
                    strC(count) = strArr(count)
                Next

                strCGID = strC(1)

                If txtScan.Text.Trim = oldscan Then
                    SQL.AddParam("@cgid", strCGID)
                    SQL.ExecQuery("SELECT TOP 1 * FROM Inventory WHERE CGID = @cgid")

                    If SQL.RecordCount > 0 Then
                        GoTo onrecord
                    Else
                        btnDO.PerformClick()
                        txtScan.Text = ""
                        Exit Sub
                    End If
                End If

                oldscan = txtScan.Text.Trim

                SQL.AddParam("@printcode", oldscan)
                SQL.ExecQuery("SELECT TOP 1 * FROM PartOut WHERE PrintCode = @printcode")

                If SQL.RecordCount > 0 Then
                    btnReturn.Checked = True
                    txtOut.ReadOnly = False
                    txtnew.ReadOnly = False
                    btnStockIn.Enabled = False
                End If

                SQL.AddParam("@cgid", strCGID)
                SQL.ExecQuery("SELECT TOP 1 * FROM Inventory WHERE CGID = @cgid")

                If SQL.RecordCount > 0 Then
onrecord:
                    MessageBox.Show("This part is still on the rack!" & vbCrLf &
                                            "Please begin with a stockout.", "Part Need to Stockout!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPN.Text = ""
                    txtDC.Text = ""
                    txtGRN.Text = ""
                    txtCode.Text = ""
                    txtCGID.Text = ""
                    txtRemark.Text = ""
                    txtQty.Text = "0"
                    txtOut.Text = "0"
                    txtnew.Text = "0"
                    'cbxLoc.Items.  ()
                    'txtEmployeeID.Text = ""
                    cbxLoc.Enabled = False
                    txtEmployeeID.ReadOnly = True
                    txtScan.Select(0, txtScan.Text.Length)
                    btnDO.Enabled = False
                    btnStockIn.Checked = True
                    btnStockIn.Enabled = True
                    txtSRRemark.ReadOnly = True
                    Exit Sub
                End If

                SQL.AddParam("@printcode", txtScan.Text.Trim)

                SQL.ExecQuery("SELECT TOP 1 * FROM PrintedCode WHERE PrintCode = @printcode")

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
                    txtCode.Text = SQL.DBDT.Rows(0)("CGCode")
                    txtCGID.Text = SQL.DBDT.Rows(0)("CGID")
                    txtRemark.Text = SQL.DBDT.Rows(0)("Remark")
                    txtQty.Text = SQL.DBDT.Rows(0)("Qty")

                    cbxLoc.Enabled = True
                    txtEmployeeID.ReadOnly = False
                    btnDO.Enabled = True
                    txtSRRemark.ReadOnly = False

                    If cbxLoc.Items.Count < 1 Then
                        GetRack()
                    End If

                    If txtEmployeeID.Text <> "" And cbxLoc.Text <> "" And oldpn = txtPN.Text Then
                        txtScan.Focus()
                        txtnew.Text = txtQty.Text - txtOut.Text
                    ElseIf txtPN.Text <> oldpn Then
                        cbxLoc.DroppedDown = True
                        Cursor.Current = Cursors.Default
                        txtEmployeeID.Focus()
                        txtnew.Text = txtQty.Text - txtOut.Text
                    Else
                        cbxLoc.DroppedDown = True
                        Cursor.Current = Cursors.Default
                        txtEmployeeID.Focus()
                        txtnew.Text = txtQty.Text - txtOut.Text
                    End If

                    oldpn = txtPN.Text.Trim
                Else
                    txtPN.Text = ""
                    txtDC.Text = ""
                    txtGRN.Text = ""
                    txtCode.Text = ""
                    txtCGID.Text = ""
                    txtRemark.Text = ""
                    txtQty.Text = "0"
                    txtOut.Text = "0"
                    txtnew.Text = "0"
                    cbxLoc.Items.Clear()
                    txtEmployeeID.Text = ""
                    cbxLoc.Enabled = False
                    txtEmployeeID.ReadOnly = True
                    txtScan.Focus()
                    txtScan.Select(0, txtScan.Text.Length)
                    btnDO.Enabled = False
                    btnStockIn.Checked = True
                    btnStockIn.Enabled = True
                    txtSRRemark.ReadOnly = True
                End If
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub cbxLoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLoc.SelectedIndexChanged
        txtEmployeeID.Focus()
    End Sub

    Private Sub txtScan_TextChanged(sender As Object, e As EventArgs) Handles txtScan.TextChanged
        btnDO.Enabled = False
    End Sub

    Private Sub DOStockIn()
        Dim strDate As DateTime
        strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)
        Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
        formatInfo.LongDatePattern = "MM/dd/yyyy"
        Dim strStartDate As String = strDate.ToString("MM/dd/yyyy", formatInfo)

        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@pn", txtPN.Text.Trim)
        SQL.AddParam("@rack", cbxLoc.Text.Trim)
        SQL.AddParam("@dc", strStartDate)
        SQL.AddParam("@qty", txtQty.Text.Trim)
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
        SQL.AddParam("@qty", txtQty.Text.Trim)
        SQL.AddParam("@grn", txtGRN.Text.Trim)
        SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
        SQL.AddParam("@remark", txtSRRemark.Text.Trim)

        SQL.ExecQuery("INSERT INTO PartLog(RecordTime, PartNumber, CGID, Qty, QtyOut, Rack, GRN, Type, Updater, Remark) " _
                                          & "VALUES(GETDATE(), @pn, @cgid, @qty, 0, @rack, @grn, 2, @uid, @remark);")

        If SQL.HasException(True) Then Exit Sub

        txtMsgLog.Text += "Stock in complete: " & txtCGID.Text & vbCrLf
        txtMsgLog.Select(txtMsgLog.TextLength - 36, 36)
        txtMsgLog.SelectionColor = Color.Green

        txtPN.Text = ""
        txtDC.Text = ""
        txtGRN.Text = ""
        txtCode.Text = ""
        txtCGID.Text = ""
        txtRemark.Text = ""
        txtQty.Text = "0"
        txtOut.Text = "0"
        txtnew.Text = "0"
        'cbxLoc.Items.Clear()
        'txtEmployeeID.Text = ""
        cbxLoc.Enabled = False
        txtEmployeeID.ReadOnly = True
        txtScan.Focus()
        txtScan.Select(0, txtScan.Text.Length)
        btnDO.Enabled = False
        btnStockIn.Checked = True
        btnStockIn.Enabled = True
        txtSRRemark.ReadOnly = True
    End Sub

    Private Sub DoUpdate(condition As Boolean)
        If initEngine.bgwInitEngine.IsBusy Then
            ' Wait for the background worker to complete before accessing the engine
            While initEngine.bgwInitEngine.IsBusy
                Application.DoEvents()
            End While
        End If
        'Load btw
        Dim labelFormat As LabelFormatDocument = initEngine._btEngine.Documents.Open(_btw_path)

        SQL.AddParam("@oldscan", oldscan)
        SQL.AddParam("@newqty", txtnew.Text.Trim)

        SQL.ExecQuery("UPDATE PrintedCode SET Qty = @newqty WHERE PrintCode = @oldscan")

        If SQL.HasException(True) Then Exit Sub

        'get mtf
        Dim mtf As String = ""
        SQL.AddParam("@printcode", oldscan)

        SQL.ExecQuery("SELECT TOP 1 * FROM PartOut WHERE PrintCode = @printcode")

        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            mtf = SQL.DBDT.Rows(0)("MTFNumber")
        End If

        Dim out As String

        If txtOut.Text = "0" Or txtOut.Text = "" Then
            out = txtQty.Text - txtnew.Text
        Else
            out = txtOut.Text.Trim
        End If

        SQL.AddParam("@out", out)
        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@qty", txtQty.Text.Trim)
        SQL.AddParam("@mtf", mtf)

        SQL.ExecQuery("UPDATE PartLog SET QtyOut = @out WHERE CGID = @cgid AND Qty = @qty AND MTFNumber = @mtf")

        If SQL.HasException(True) Then Exit Sub

        SQL.AddParam("@oldscan", oldscan)

        SQL.ExecQuery("DELETE FROM PartOut WHERE PrintCode = @oldscan")

        If SQL.HasException(True) Then Exit Sub

        If condition Then
            ' Update the data source
            With labelFormat.SubStrings
                .SetSubString("pn", txtPN.Text.Trim)
                .SetSubString("cgid", txtCGID.Text.Trim)
                .SetSubString("grn", txtGRN.Text.Trim)
                .SetSubString("dc", txtDC.Text.Trim)
                .SetSubString("cgcode", txtCode.Text.Trim)
                .SetSubString("qty", txtnew.Text.Trim)
                ' set other SubStrings as needed
            End With

            ' Print the label(s)
            If Not String.IsNullOrEmpty(_PrinterName) Then
                labelFormat.PrintSetup.PrinterName = _PrinterName
                labelFormat.Print("CGIM" & DateTime.Now, 2000)

                ' Update UI and reset fields
                txtMsgLog.AppendText("Update complete: " & txtCGID.Text & vbCrLf)
                txtMsgLog.Select(txtMsgLog.TextLength - 34, 34)
                txtMsgLog.SelectionColor = Color.Green

                Dim fieldsToReset() As Control = {txtPN, txtDC, txtGRN, txtCode, txtCGID, txtRemark}
                For Each field As Control In fieldsToReset
                    field.Text = ""
                Next

                txtQty.Text = "0"
                txtOut.Text = "0"
                txtnew.Text = "0"
                cbxLoc.Enabled = False
                txtEmployeeID.ReadOnly = True
                txtScan.Focus()
                txtScan.SelectAll()
                btnDO.Enabled = False
                btnStockIn.Checked = True
                btnStockIn.Enabled = True
                txtSRRemark.ReadOnly = True
            Else
                MessageBox.Show("Please select a printer first", "Select Printer")
            End If
        Else
            ' Update UI and reset fields
            txtMsgLog.AppendText("Update complete: " & txtCGID.Text & vbCrLf)
            txtMsgLog.Select(txtMsgLog.TextLength - 34, 34)
            txtMsgLog.SelectionColor = Color.Green

            Dim fieldsToReset() As Control = {txtPN, txtDC, txtGRN, txtCode, txtCGID, txtRemark}
            For Each field As Control In fieldsToReset
                field.Text = ""
            Next

            txtQty.Text = "0"
            txtOut.Text = "0"
            txtnew.Text = "0"
            cbxLoc.Enabled = False
            txtEmployeeID.ReadOnly = True
            txtScan.Focus()
            txtScan.SelectAll()
            btnDO.Enabled = False
            btnStockIn.Checked = True
            btnStockIn.Enabled = True
            txtSRRemark.ReadOnly = True
        End If
    End Sub

    Private Sub DoStockInUpdate(condition As Boolean)
        Dim strDate As DateTime
        strDate = DateTime.Parse(txtDC.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-GB").DateTimeFormat)

        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@pn", txtPN.Text.Trim)
        SQL.AddParam("@rack", cbxLoc.Text.Trim)
        SQL.AddParam("@dc", strDate)
        SQL.AddParam("@qty", txtnew.Text.Trim)
        SQL.AddParam("@grn", txtGRN.Text.Trim)
        SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
        SQL.AddParam("@remark", txtRemark.Text.Trim)

        SQL.ExecQuery("INSERT INTO Inventory(CGID, PartNumber, Rack, DateCode, Qty, GRN, " _
                     & "UpdateTime, Updater, State, Remark) " _
                     & "VALUES(@cgid, @pn, @rack, @dc, @qty, @grn, GETDATE(), @uid, 0, @remark)")

        If SQL.HasException(True) Then Exit Sub

        'get mtf
        Dim mtf As String = ""
        SQL.AddParam("@printcode", oldscan)

        SQL.ExecQuery("SELECT TOP 1 * FROM PartOut WHERE PrintCode = @printcode")

        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            mtf = SQL.DBDT.Rows(0)("MTFNumber")
        End If

        SQL.AddParam("@cgid", txtCGID.Text.Trim)
        SQL.AddParam("@pn", txtPN.Text.Trim)
        SQL.AddParam("@rack", cbxLoc.Text.Trim)
        SQL.AddParam("@dc", strDate)
        SQL.AddParam("@qty", txtnew.Text.Trim)
        SQL.AddParam("@grn", txtGRN.Text.Trim)
        SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
        SQL.AddParam("@remark", txtSRRemark.Text.Trim)
        SQL.AddParam("@mtf", mtf)

        SQL.ExecQuery("INSERT INTO PartLog(RecordTime, PartNumber, CGID, Qty, QtyOut, Rack, GRN, MTFNumber, Type, Updater, Remark) " _
                                          & "VALUES(GETDATE(), @pn, @cgid, @qty, 0, @rack, @grn, @mtf, 6, @uid, @remark);")

        If SQL.HasException(True) Then Exit Sub

        DoUpdate(condition)
    End Sub

    Private Sub btnDO_Click(sender As Object, e As EventArgs) Handles btnDO.Click
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

            If SQL.RecordCount = 0 Then
                MessageBox.Show("Employee ID not found.", "Employee ID!")
                txtEmployeeID.Focus()
                txtEmployeeID.SelectAll()
                Exit Sub
            End If

            If btnDO.Text = "Stock In" Then
                DOStockIn()

            ElseIf txtnew.Text = 0 Then
                MessageBox.Show("The new quantity is 0!? What exactly do you mean by 'update it'?", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txtnew.Text = txtQty.Text Then
                SQL.AddParam("@printcode", oldscan)
                SQL.ExecQuery("SELECT TOP 1 * FROM PartOut WHERE PrintCode = @printcode")

                If SQL.RecordCount > 0 Then
                    DoStockInUpdate(False)
                Else
                    MessageBox.Show("This part has never been stockout before!?" & vbCrLf &
                        "Please begin with a stockin.", "Part Need to Stockin!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnStockIn.Checked = True
                    btnStockIn.Enabled = True
                End If
            Else
                SQL.AddParam("@printcode", oldscan)
                SQL.ExecQuery("SELECT TOP 1 * FROM PartOut WHERE PrintCode = @printcode")

                If SQL.RecordCount > 0 Then
                    DoStockInUpdate(True)
                Else
                    MessageBox.Show("This part has never been stockout before!?" & vbCrLf &
                        "Please begin with a stockin.", "Part Need to Stockin!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    btnStockIn.Checked = True
                    btnStockIn.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtOut_TextChanged(sender As Object, e As EventArgs) Handles txtOut.TextChanged
        If Not IsNumeric(txtOut.Text.Trim) Then
            txtOut.Text = ""
            txtnew.Text = txtQty.Text - 0
        End If

        If txtOut.Text <> "" Then
            txtnew.Text = txtQty.Text - txtOut.Text
        Else
            txtnew.Text = txtQty.Text - 0
        End If
    End Sub

    Private Sub txtnew_TextChanged(sender As Object, e As EventArgs) Handles txtnew.TextChanged
        If txtOut.Text = "" Then
            txtnew.Text = txtQty.Text - 0
        End If

        If Not IsNumeric(txtnew.Text.Trim) Then
            txtnew.Text = txtQty.Text - txtOut.Text
        End If
    End Sub

    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                If txtnew.Enabled = False Then
                    txtOut.Focus()
                Else
                    btnDO.PerformClick()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOut.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtnew.Focus()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtnew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnew.KeyPress
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
End Class