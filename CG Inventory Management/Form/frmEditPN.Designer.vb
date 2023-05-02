<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditPN))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.txtPT = New System.Windows.Forms.TextBox()
        Me.txtCGCode = New System.Windows.Forms.TextBox()
        Me.txtPD = New System.Windows.Forms.TextBox()
        Me.txtQPP = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.txtQPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Part Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Part Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CG Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Part Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Qty Per Part"
        '
        'txtPN
        '
        Me.txtPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPN.Location = New System.Drawing.Point(16, 32)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(231, 26)
        Me.txtPN.TabIndex = 6
        '
        'txtPT
        '
        Me.txtPT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPT.Location = New System.Drawing.Point(16, 94)
        Me.txtPT.Name = "txtPT"
        Me.txtPT.Size = New System.Drawing.Size(143, 26)
        Me.txtPT.TabIndex = 7
        '
        'txtCGCode
        '
        Me.txtCGCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCGCode.Enabled = False
        Me.txtCGCode.Location = New System.Drawing.Point(16, 155)
        Me.txtCGCode.Name = "txtCGCode"
        Me.txtCGCode.Size = New System.Drawing.Size(143, 26)
        Me.txtCGCode.TabIndex = 8
        '
        'txtPD
        '
        Me.txtPD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPD.Location = New System.Drawing.Point(276, 32)
        Me.txtPD.Multiline = True
        Me.txtPD.Name = "txtPD"
        Me.txtPD.Size = New System.Drawing.Size(276, 88)
        Me.txtPD.TabIndex = 9
        '
        'txtQPP
        '
        Me.txtQPP.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQPP.Location = New System.Drawing.Point(276, 155)
        Me.txtQPP.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.txtQPP.Name = "txtQPP"
        Me.txtQPP.Size = New System.Drawing.Size(92, 31)
        Me.txtQPP.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.BorderThickness = 1
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.btnSave.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSave.Location = New System.Drawing.Point(428, 197)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 39)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = Global.CG_Inventory_Management.My.Resources.Resources.delete
        Me.btnCancel.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(16, 197)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 39)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        '
        'frmEditPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 249)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtQPP)
        Me.Controls.Add(Me.txtPD)
        Me.Controls.Add(Me.txtCGCode)
        Me.Controls.Add(Me.txtPT)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditPN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Part Number: "
        CType(Me.txtQPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPN As TextBox
    Friend WithEvents txtPT As TextBox
    Friend WithEvents txtCGCode As TextBox
    Friend WithEvents txtPD As TextBox
    Friend WithEvents txtQPP As NumericUpDown
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
