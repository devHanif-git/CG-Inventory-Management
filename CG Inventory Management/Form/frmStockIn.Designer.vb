<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockIn))
        Me.txtMsgLog = New System.Windows.Forms.RichTextBox()
        Me.lblMessageLogs = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnReturn = New System.Windows.Forms.RadioButton()
        Me.btnStockIn = New System.Windows.Forms.RadioButton()
        Me.btnDO = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGRN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCGID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.cbxLoc = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.txtSRRemark = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMsgLog
        '
        Me.txtMsgLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMsgLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsgLog.Location = New System.Drawing.Point(0, 625)
        Me.txtMsgLog.Name = "txtMsgLog"
        Me.txtMsgLog.ReadOnly = True
        Me.txtMsgLog.Size = New System.Drawing.Size(1278, 198)
        Me.txtMsgLog.TabIndex = 27
        Me.txtMsgLog.Text = ""
        '
        'lblMessageLogs
        '
        Me.lblMessageLogs.AutoSize = True
        Me.lblMessageLogs.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMessageLogs.Location = New System.Drawing.Point(506, 581)
        Me.lblMessageLogs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessageLogs.Name = "lblMessageLogs"
        Me.lblMessageLogs.Size = New System.Drawing.Size(304, 41)
        Me.lblMessageLogs.TabIndex = 26
        Me.lblMessageLogs.Text = "- Message Logs -"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btnReturn)
        Me.Guna2GroupBox1.Controls.Add(Me.btnStockIn)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDO)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(826, 149)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(405, 246)
        Me.Guna2GroupBox1.TabIndex = 29
        Me.Guna2GroupBox1.Text = "Mode:"
        '
        'btnReturn
        '
        Me.btnReturn.AutoSize = True
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(238, 53)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(85, 27)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.AutoSize = True
        Me.btnStockIn.BackColor = System.Drawing.Color.Transparent
        Me.btnStockIn.Checked = True
        Me.btnStockIn.ForeColor = System.Drawing.Color.Black
        Me.btnStockIn.Location = New System.Drawing.Point(80, 53)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(100, 27)
        Me.btnStockIn.TabIndex = 0
        Me.btnStockIn.TabStop = True
        Me.btnStockIn.Text = "Stock In"
        Me.btnStockIn.UseVisualStyleBackColor = False
        '
        'btnDO
        '
        Me.btnDO.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDO.BorderThickness = 1
        Me.btnDO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDO.Enabled = False
        Me.btnDO.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnDO.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnDO.ForeColor = System.Drawing.Color.Black
        Me.btnDO.Image = CType(resources.GetObject("btnDO.Image"), System.Drawing.Image)
        Me.btnDO.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDO.Location = New System.Drawing.Point(80, 101)
        Me.btnDO.Name = "btnDO"
        Me.btnDO.Size = New System.Drawing.Size(243, 125)
        Me.btnDO.TabIndex = 45
        Me.btnDO.Text = "Stock In"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 32)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Scan QR Code:"
        '
        'txtScan
        '
        Me.txtScan.BackColor = System.Drawing.Color.Yellow
        Me.txtScan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtScan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.Location = New System.Drawing.Point(244, 37)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(404, 31)
        Me.txtScan.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(655, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Part Number:"
        '
        'txtPN
        '
        Me.txtPN.BackColor = System.Drawing.SystemColors.Control
        Me.txtPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPN.Location = New System.Drawing.Point(841, 37)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.ReadOnly = True
        Me.txtPN.Size = New System.Drawing.Size(390, 31)
        Me.txtPN.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 32)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Date Code:"
        '
        'txtDC
        '
        Me.txtDC.BackColor = System.Drawing.SystemColors.Control
        Me.txtDC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDC.Location = New System.Drawing.Point(196, 93)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.ReadOnly = True
        Me.txtDC.Size = New System.Drawing.Size(194, 31)
        Me.txtDC.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(397, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "GRN Number:"
        '
        'txtGRN
        '
        Me.txtGRN.BackColor = System.Drawing.SystemColors.Control
        Me.txtGRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGRN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRN.Location = New System.Drawing.Point(592, 95)
        Me.txtGRN.Name = "txtGRN"
        Me.txtGRN.ReadOnly = True
        Me.txtGRN.Size = New System.Drawing.Size(280, 31)
        Me.txtGRN.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(879, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 32)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "CG Code:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(1027, 95)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(204, 31)
        Me.txtCode.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 32)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Unique Number:"
        '
        'txtCGID
        '
        Me.txtCGID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGID.Location = New System.Drawing.Point(257, 149)
        Me.txtCGID.Name = "txtCGID"
        Me.txtCGID.ReadOnly = True
        Me.txtCGID.Size = New System.Drawing.Size(553, 31)
        Me.txtCGID.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(567, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 32)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(708, 260)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(102, 47)
        Me.txtQty.TabIndex = 44
        Me.txtQty.Text = "0"
        '
        'cbxLoc
        '
        Me.cbxLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLoc.Enabled = False
        Me.cbxLoc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cbxLoc.FormattingEnabled = True
        Me.cbxLoc.Location = New System.Drawing.Point(164, 206)
        Me.cbxLoc.Name = "cbxLoc"
        Me.cbxLoc.Size = New System.Drawing.Size(216, 31)
        Me.cbxLoc.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(387, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 32)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Employee ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 204)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 32)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Location:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.BackColor = System.Drawing.Color.Yellow
        Me.txtEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(575, 205)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(235, 31)
        Me.txtEmployeeID.TabIndex = 46
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.Yellow
        Me.txtOut.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(708, 313)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(102, 47)
        Me.txtOut.TabIndex = 51
        Me.txtOut.Text = "0"
        Me.txtOut.Visible = False
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.ForeColor = System.Drawing.Color.Black
        Me.lblOut.Location = New System.Drawing.Point(512, 319)
        Me.lblOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(189, 32)
        Me.lblOut.TabIndex = 50
        Me.lblOut.Text = "Quantity Out:"
        Me.lblOut.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 253)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 32)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Remark:"
        '
        'txtRemark
        '
        Me.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemark.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(36, 288)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(456, 31)
        Me.txtRemark.TabIndex = 52
        '
        'txtnew
        '
        Me.txtnew.BackColor = System.Drawing.Color.Yellow
        Me.txtnew.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnew.Location = New System.Drawing.Point(708, 366)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.ReadOnly = True
        Me.txtnew.Size = New System.Drawing.Size(102, 47)
        Me.txtnew.TabIndex = 55
        Me.txtnew.Text = "0"
        Me.txtnew.Visible = False
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnew.ForeColor = System.Drawing.Color.Black
        Me.lblnew.Location = New System.Drawing.Point(507, 372)
        Me.lblnew.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(201, 32)
        Me.lblnew.TabIndex = 54
        Me.lblnew.Text = "New Quantity:"
        Me.lblnew.Visible = False
        '
        'lblremarks
        '
        Me.lblremarks.AutoSize = True
        Me.lblremarks.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremarks.ForeColor = System.Drawing.Color.Black
        Me.lblremarks.Location = New System.Drawing.Point(30, 338)
        Me.lblremarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(236, 32)
        Me.lblremarks.TabIndex = 83
        Me.lblremarks.Text = "Stock In Remark:"
        '
        'txtSRRemark
        '
        Me.txtSRRemark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSRRemark.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRRemark.Location = New System.Drawing.Point(36, 373)
        Me.txtSRRemark.Name = "txtSRRemark"
        Me.txtSRRemark.ReadOnly = True
        Me.txtSRRemark.Size = New System.Drawing.Size(456, 31)
        Me.txtSRRemark.TabIndex = 82
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.lblremarks)
        Me.Controls.Add(Me.txtSRRemark)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxLoc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCGID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGRN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.txtScan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.txtMsgLog)
        Me.Controls.Add(Me.lblMessageLogs)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock In/Return"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMsgLog As RichTextBox
    Friend WithEvents lblMessageLogs As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnReturn As RadioButton
    Friend WithEvents btnStockIn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGRN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCGID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnDO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxLoc As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblOut As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtnew As TextBox
    Friend WithEvents lblnew As Label
    Friend WithEvents lblremarks As Label
    Friend WithEvents txtSRRemark As TextBox
End Class
