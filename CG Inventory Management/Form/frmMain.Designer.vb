<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelBarTop = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnML = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMSO = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMSI = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIncoming = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLvl = New System.Windows.Forms.Label()
        Me.lblSignOut = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelBarTop.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarTop
        '
        Me.PanelBarTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelBarTop.BackgroundImage = CType(resources.GetObject("PanelBarTop.BackgroundImage"), System.Drawing.Image)
        Me.PanelBarTop.Controls.Add(Me.btnExit)
        Me.PanelBarTop.Controls.Add(Me.Label1)
        Me.PanelBarTop.Controls.Add(Me.btnMinimize)
        Me.PanelBarTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarTop.Name = "PanelBarTop"
        Me.PanelBarTop.Size = New System.Drawing.Size(1284, 45)
        Me.PanelBarTop.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1247, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(37, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 7
        Me.btnExit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CG Inventory Management"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1214, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(36, 35)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 9
        Me.btnMinimize.TabStop = False
        '
        'PanelButton
        '
        Me.PanelButton.BackColor = System.Drawing.Color.White
        Me.PanelButton.Controls.Add(Me.btnInventory)
        Me.PanelButton.Controls.Add(Me.btnML)
        Me.PanelButton.Controls.Add(Me.btnMM)
        Me.PanelButton.Controls.Add(Me.btnAdmin)
        Me.PanelButton.Controls.Add(Me.btnMSO)
        Me.PanelButton.Controls.Add(Me.btnMSI)
        Me.PanelButton.Controls.Add(Me.btnIncoming)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 45)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(1284, 87)
        Me.PanelButton.TabIndex = 5
        '
        'btnInventory
        '
        Me.btnInventory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnInventory.Checked = True
        Me.btnInventory.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnInventory.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnInventory.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnInventory.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInventory.FillColor = System.Drawing.Color.White
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventory.Location = New System.Drawing.Point(0, 0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(183, 87)
        Me.btnInventory.TabIndex = 7
        Me.btnInventory.Text = "Inventory"
        '
        'btnML
        '
        Me.btnML.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnML.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnML.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnML.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnML.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnML.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnML.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnML.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnML.FillColor = System.Drawing.Color.White
        Me.btnML.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnML.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnML.Location = New System.Drawing.Point(915, 0)
        Me.btnML.Name = "btnML"
        Me.btnML.Size = New System.Drawing.Size(183, 87)
        Me.btnML.TabIndex = 6
        Me.btnML.Text = "Part Log"
        '
        'btnMM
        '
        Me.btnMM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMM.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnMM.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnMM.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnMM.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnMM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMM.FillColor = System.Drawing.Color.White
        Me.btnMM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMM.Location = New System.Drawing.Point(732, 0)
        Me.btnMM.Name = "btnMM"
        Me.btnMM.Size = New System.Drawing.Size(183, 87)
        Me.btnMM.TabIndex = 5
        Me.btnMM.Text = "Part Management"
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnAdmin.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnAdmin.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnAdmin.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdmin.FillColor = System.Drawing.Color.White
        Me.btnAdmin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdmin.Location = New System.Drawing.Point(1098, 0)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(192, 87)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Administration"
        '
        'btnMSO
        '
        Me.btnMSO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMSO.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnMSO.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnMSO.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnMSO.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnMSO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMSO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMSO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMSO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMSO.FillColor = System.Drawing.Color.White
        Me.btnMSO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMSO.Location = New System.Drawing.Point(549, 0)
        Me.btnMSO.Name = "btnMSO"
        Me.btnMSO.Size = New System.Drawing.Size(183, 87)
        Me.btnMSO.TabIndex = 3
        Me.btnMSO.Text = "Part Stock Out"
        '
        'btnMSI
        '
        Me.btnMSI.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMSI.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnMSI.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnMSI.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnMSI.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnMSI.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMSI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMSI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMSI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMSI.FillColor = System.Drawing.Color.White
        Me.btnMSI.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMSI.Location = New System.Drawing.Point(366, 0)
        Me.btnMSI.Name = "btnMSI"
        Me.btnMSI.Size = New System.Drawing.Size(183, 87)
        Me.btnMSI.TabIndex = 2
        Me.btnMSI.Text = "Part Stock In"
        '
        'btnIncoming
        '
        Me.btnIncoming.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnIncoming.CheckedState.CustomBorderColor = System.Drawing.Color.Red
        Me.btnIncoming.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnIncoming.CustomBorderColor = System.Drawing.Color.Maroon
        Me.btnIncoming.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnIncoming.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIncoming.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIncoming.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIncoming.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIncoming.FillColor = System.Drawing.Color.White
        Me.btnIncoming.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncoming.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIncoming.Location = New System.Drawing.Point(183, 0)
        Me.btnIncoming.Name = "btnIncoming"
        Me.btnIncoming.Size = New System.Drawing.Size(183, 87)
        Me.btnIncoming.TabIndex = 1
        Me.btnIncoming.Text = "Incoming Part"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblLvl)
        Me.Panel1.Controls.Add(Me.lblSignOut)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 976)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 29)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1183, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblLvl
        '
        Me.lblLvl.AutoSize = True
        Me.lblLvl.BackColor = System.Drawing.Color.Transparent
        Me.lblLvl.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLvl.ForeColor = System.Drawing.Color.White
        Me.lblLvl.Location = New System.Drawing.Point(315, 5)
        Me.lblLvl.Name = "lblLvl"
        Me.lblLvl.Size = New System.Drawing.Size(16, 18)
        Me.lblLvl.TabIndex = 3
        Me.lblLvl.Text = "3"
        Me.lblLvl.Visible = False
        '
        'lblSignOut
        '
        Me.lblSignOut.AutoSize = True
        Me.lblSignOut.BackColor = System.Drawing.Color.Transparent
        Me.lblSignOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignOut.ForeColor = System.Drawing.Color.White
        Me.lblSignOut.Location = New System.Drawing.Point(1205, 6)
        Me.lblSignOut.Name = "lblSignOut"
        Me.lblSignOut.Size = New System.Drawing.Size(69, 18)
        Me.lblSignOut.TabIndex = 2
        Me.lblSignOut.Text = "Sign Out"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(127, 5)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(214, 18)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "MUHAMMAD HANIF FIRDAUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current User:"
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 132)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1284, 844)
        Me.PanelMain.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1005)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelBarTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CG Inventory Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBarTop.ResumeLayout(False)
        Me.PanelBarTop.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents PanelButton As Panel
    Friend WithEvents btnIncoming As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMSO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMSI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnML As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents lblSignOut As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblLvl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
