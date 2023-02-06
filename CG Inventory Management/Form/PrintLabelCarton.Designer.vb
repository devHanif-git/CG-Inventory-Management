<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintCartonLabel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintCartonLabel))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpn = New System.Windows.Forms.Label()
        Me.lblcgcode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnprint2 = New System.Windows.Forms.Button()
        Me.btnprint1 = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Confirm to print carton label"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "with below part number information?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Part Number:"
        '
        'lblpn
        '
        Me.lblpn.AutoSize = True
        Me.lblpn.Location = New System.Drawing.Point(196, 91)
        Me.lblpn.Name = "lblpn"
        Me.lblpn.Size = New System.Drawing.Size(28, 20)
        Me.lblpn.TabIndex = 4
        Me.lblpn.Text = "pn"
        '
        'lblcgcode
        '
        Me.lblcgcode.AutoSize = True
        Me.lblcgcode.Location = New System.Drawing.Point(176, 111)
        Me.lblcgcode.Name = "lblcgcode"
        Me.lblcgcode.Size = New System.Drawing.Size(69, 20)
        Me.lblcgcode.TabIndex = 6
        Me.lblcgcode.Text = "cgcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CG Code:"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(204, 131)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 20)
        Me.lblqty.TabIndex = 8
        Me.lblqty.Text = "qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Quantity:"
        '
        'btnprint2
        '
        Me.btnprint2.Location = New System.Drawing.Point(202, 16)
        Me.btnprint2.Name = "btnprint2"
        Me.btnprint2.Size = New System.Drawing.Size(87, 36)
        Me.btnprint2.TabIndex = 9
        Me.btnprint2.Text = "Print 2"
        Me.btnprint2.UseVisualStyleBackColor = True
        '
        'btnprint1
        '
        Me.btnprint1.Location = New System.Drawing.Point(109, 16)
        Me.btnprint1.Name = "btnprint1"
        Me.btnprint1.Size = New System.Drawing.Size(87, 36)
        Me.btnprint1.TabIndex = 10
        Me.btnprint1.Text = "Print 1"
        Me.btnprint1.UseVisualStyleBackColor = True
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(295, 16)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(87, 36)
        Me.btnno.TabIndex = 11
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnno)
        Me.Panel1.Controls.Add(Me.btnprint1)
        Me.Panel1.Controls.Add(Me.btnprint2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 100)
        Me.Panel1.TabIndex = 12
        '
        'PrintCartonLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 236)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblcgcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblpn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintCartonLabel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Carton Label"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpn As Label
    Friend WithEvents lblcgcode As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblqty As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnprint2 As Button
    Friend WithEvents btnprint1 As Button
    Friend WithEvents btnno As Button
    Friend WithEvents Panel1 As Panel
End Class
