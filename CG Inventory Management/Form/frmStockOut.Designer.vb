<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOut))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCGID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGRN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOverIssue = New System.Windows.Forms.RadioButton()
        Me.btnIssue = New System.Windows.Forms.RadioButton()
        Me.btnDO = New Guna.UI2.WinForms.Guna2Button()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnOthers = New System.Windows.Forms.RadioButton()
        Me.txtMsgLog = New System.Windows.Forms.RichTextBox()
        Me.lblMessageLogs = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStockOutRemark = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMTF = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(370, 212)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 32)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Remark:"
        '
        'txtRemark
        '
        Me.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemark.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(494, 214)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(732, 31)
        Me.txtRemark.TabIndex = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 212)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 32)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Location:"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(159, 264)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(102, 47)
        Me.txtQty.TabIndex = 68
        Me.txtQty.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 271)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 32)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(384, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 32)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Unique Number:"
        '
        'txtCGID
        '
        Me.txtCGID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGID.Location = New System.Drawing.Point(611, 157)
        Me.txtCGID.Name = "txtCGID"
        Me.txtCGID.ReadOnly = True
        Me.txtCGID.Size = New System.Drawing.Size(615, 31)
        Me.txtCGID.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 155)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 32)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "CG Code:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(173, 156)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(204, 31)
        Me.txtCode.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(857, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 32)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "GRN Number:"
        '
        'txtGRN
        '
        Me.txtGRN.BackColor = System.Drawing.SystemColors.Control
        Me.txtGRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGRN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRN.Location = New System.Drawing.Point(1052, 103)
        Me.txtGRN.Name = "txtGRN"
        Me.txtGRN.ReadOnly = True
        Me.txtGRN.Size = New System.Drawing.Size(174, 31)
        Me.txtGRN.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(534, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 32)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Date Code:"
        '
        'txtDC
        '
        Me.txtDC.BackColor = System.Drawing.SystemColors.Control
        Me.txtDC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDC.Location = New System.Drawing.Point(700, 101)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.ReadOnly = True
        Me.txtDC.Size = New System.Drawing.Size(153, 31)
        Me.txtDC.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Part Number:"
        '
        'txtPN
        '
        Me.txtPN.BackColor = System.Drawing.SystemColors.Control
        Me.txtPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPN.Location = New System.Drawing.Point(211, 101)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.ReadOnly = True
        Me.txtPN.Size = New System.Drawing.Size(316, 31)
        Me.txtPN.TabIndex = 57
        '
        'txtScan
        '
        Me.txtScan.BackColor = System.Drawing.Color.Yellow
        Me.txtScan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtScan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.Location = New System.Drawing.Point(239, 45)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(987, 31)
        Me.txtScan.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 32)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Scan QR Code:"
        '
        'btnOverIssue
        '
        Me.btnOverIssue.AutoSize = True
        Me.btnOverIssue.BackColor = System.Drawing.Color.Transparent
        Me.btnOverIssue.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverIssue.ForeColor = System.Drawing.Color.Black
        Me.btnOverIssue.Location = New System.Drawing.Point(533, 274)
        Me.btnOverIssue.Name = "btnOverIssue"
        Me.btnOverIssue.Size = New System.Drawing.Size(233, 27)
        Me.btnOverIssue.TabIndex = 1
        Me.btnOverIssue.Text = "Material Over Request"
        Me.btnOverIssue.UseVisualStyleBackColor = False
        '
        'btnIssue
        '
        Me.btnIssue.AutoSize = True
        Me.btnIssue.BackColor = System.Drawing.Color.Transparent
        Me.btnIssue.Checked = True
        Me.btnIssue.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.Color.Black
        Me.btnIssue.Location = New System.Drawing.Point(278, 274)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(209, 27)
        Me.btnIssue.TabIndex = 0
        Me.btnIssue.TabStop = True
        Me.btnIssue.Text = "Material Requisition"
        Me.btnIssue.UseVisualStyleBackColor = False
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
        Me.btnDO.Location = New System.Drawing.Point(983, 295)
        Me.btnDO.Name = "btnDO"
        Me.btnDO.Size = New System.Drawing.Size(243, 121)
        Me.btnDO.TabIndex = 45
        Me.btnDO.Text = "Stock Out"
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.Location = New System.Drawing.Point(159, 214)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.ReadOnly = True
        Me.txtLoc.Size = New System.Drawing.Size(204, 31)
        Me.txtLoc.TabIndex = 77
        '
        'btnOthers
        '
        Me.btnOthers.AutoSize = True
        Me.btnOthers.BackColor = System.Drawing.Color.Transparent
        Me.btnOthers.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOthers.ForeColor = System.Drawing.Color.Black
        Me.btnOthers.Location = New System.Drawing.Point(812, 274)
        Me.btnOthers.Name = "btnOthers"
        Me.btnOthers.Size = New System.Drawing.Size(87, 27)
        Me.btnOthers.TabIndex = 46
        Me.btnOthers.Text = "Others"
        Me.btnOthers.UseVisualStyleBackColor = False
        '
        'txtMsgLog
        '
        Me.txtMsgLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMsgLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsgLog.Location = New System.Drawing.Point(0, 625)
        Me.txtMsgLog.Name = "txtMsgLog"
        Me.txtMsgLog.ReadOnly = True
        Me.txtMsgLog.Size = New System.Drawing.Size(1278, 198)
        Me.txtMsgLog.TabIndex = 79
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
        Me.lblMessageLogs.TabIndex = 78
        Me.lblMessageLogs.Text = "- Message Logs -"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(25, 390)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(259, 32)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Stock Out Remark:"
        '
        'txtStockOutRemark
        '
        Me.txtStockOutRemark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStockOutRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockOutRemark.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockOutRemark.Location = New System.Drawing.Point(284, 392)
        Me.txtStockOutRemark.Name = "txtStockOutRemark"
        Me.txtStockOutRemark.ReadOnly = True
        Me.txtStockOutRemark.Size = New System.Drawing.Size(628, 31)
        Me.txtStockOutRemark.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(499, 330)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 32)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.BackColor = System.Drawing.Color.Yellow
        Me.txtEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(687, 332)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(225, 31)
        Me.txtEmployeeID.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 330)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 32)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "MTF Number:"
        '
        'txtMTF
        '
        Me.txtMTF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMTF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTF.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTF.Location = New System.Drawing.Point(209, 332)
        Me.txtMTF.Name = "txtMTF"
        Me.txtMTF.ReadOnly = True
        Me.txtMTF.Size = New System.Drawing.Size(283, 31)
        Me.txtMTF.TabIndex = 1
        '
        'frmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMTF)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStockOutRemark)
        Me.Controls.Add(Me.btnOthers)
        Me.Controls.Add(Me.txtMsgLog)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.lblMessageLogs)
        Me.Controls.Add(Me.btnOverIssue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtQty)
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
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmStockOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Out"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCGID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGRN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPN As TextBox
    Friend WithEvents txtScan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIssue As RadioButton
    Friend WithEvents btnOverIssue As RadioButton
    Friend WithEvents btnDO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnOthers As RadioButton
    Friend WithEvents txtMsgLog As RichTextBox
    Friend WithEvents lblMessageLogs As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStockOutRemark As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMTF As TextBox
End Class
