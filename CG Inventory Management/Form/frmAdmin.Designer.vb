<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxSPass = New System.Windows.Forms.CheckBox()
        Me.split = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtULvl = New System.Windows.Forms.ComboBox()
        Me.txtUGroup = New System.Windows.Forms.ComboBox()
        Me.cbxSuspend = New System.Windows.Forms.RadioButton()
        Me.cbxActive = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btncgidConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCGID = New System.Windows.Forms.Label()
        Me.txtCGID = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2ContextMenuStrip4 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHWID = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2ContextMenuStrip3 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCGIDNumber = New System.Windows.Forms.TextBox()
        Me.btnCancelS = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtyyMM = New System.Windows.Forms.TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.CreateNewRackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnACancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.lbxRack = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRackName = New System.Windows.Forms.TextBox()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2ContextMenuStrip4.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2ContextMenuStrip3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2ContextMenuStrip2.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvUsers)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1270, 775)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Control"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsers.Location = New System.Drawing.Point(3, 3)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(1264, 574)
        Me.dgvUsers.TabIndex = 78
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.EditEmployeeDetailsToolStripMenuItem, Me.DeleteEmployeeAccountToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(227, 70)
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.user_add
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add New Employee Account"
        '
        'EditEmployeeDetailsToolStripMenuItem
        '
        Me.EditEmployeeDetailsToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.EditEmployeeDetailsToolStripMenuItem.Name = "EditEmployeeDetailsToolStripMenuItem"
        Me.EditEmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EditEmployeeDetailsToolStripMenuItem.Text = "Edit Employee Account"
        '
        'DeleteEmployeeAccountToolStripMenuItem
        '
        Me.DeleteEmployeeAccountToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.deletes
        Me.DeleteEmployeeAccountToolStripMenuItem.Name = "DeleteEmployeeAccountToolStripMenuItem"
        Me.DeleteEmployeeAccountToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DeleteEmployeeAccountToolStripMenuItem.Text = "Delete Employee Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.cbxSPass)
        Me.Panel1.Controls.Add(Me.split)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtULvl)
        Me.Panel1.Controls.Add(Me.txtUGroup)
        Me.Panel1.Controls.Add(Me.cbxSuspend)
        Me.Panel1.Controls.Add(Me.cbxActive)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPass2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 577)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 195)
        Me.Panel1.TabIndex = 77
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
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(1111, 84)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 60)
        Me.btnCancel.TabIndex = 91
        Me.btnCancel.Text = "Cancel"
        '
        'btnCreate
        '
        Me.btnCreate.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.BorderThickness = 1
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCreate.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCreate.Location = New System.Drawing.Point(962, 84)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(136, 60)
        Me.btnCreate.TabIndex = 90
        Me.btnCreate.Text = "Create"
        '
        'cbxSPass
        '
        Me.cbxSPass.AutoSize = True
        Me.cbxSPass.Location = New System.Drawing.Point(459, 157)
        Me.cbxSPass.Name = "cbxSPass"
        Me.cbxSPass.Size = New System.Drawing.Size(142, 24)
        Me.cbxSPass.TabIndex = 89
        Me.cbxSPass.Text = "Show Password"
        Me.cbxSPass.UseVisualStyleBackColor = True
        '
        'split
        '
        Me.split.BackColor = System.Drawing.Color.DarkGray
        Me.split.Location = New System.Drawing.Point(1104, 84)
        Me.split.Name = "split"
        Me.split.Size = New System.Drawing.Size(1, 60)
        Me.split.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(658, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(658, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "User Level:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(658, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "User Group:"
        '
        'txtULvl
        '
        Me.txtULvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtULvl.FormattingEnabled = True
        Me.txtULvl.Location = New System.Drawing.Point(662, 102)
        Me.txtULvl.Name = "txtULvl"
        Me.txtULvl.Size = New System.Drawing.Size(258, 28)
        Me.txtULvl.TabIndex = 7
        '
        'txtUGroup
        '
        Me.txtUGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUGroup.FormattingEnabled = True
        Me.txtUGroup.Location = New System.Drawing.Point(662, 49)
        Me.txtUGroup.Name = "txtUGroup"
        Me.txtUGroup.Size = New System.Drawing.Size(258, 28)
        Me.txtUGroup.TabIndex = 6
        '
        'cbxSuspend
        '
        Me.cbxSuspend.AutoSize = True
        Me.cbxSuspend.Location = New System.Drawing.Point(742, 155)
        Me.cbxSuspend.Name = "cbxSuspend"
        Me.cbxSuspend.Size = New System.Drawing.Size(88, 24)
        Me.cbxSuspend.TabIndex = 11
        Me.cbxSuspend.Text = "Suspend"
        Me.cbxSuspend.UseVisualStyleBackColor = True
        '
        'cbxActive
        '
        Me.cbxActive.AutoSize = True
        Me.cbxActive.Checked = True
        Me.cbxActive.Location = New System.Drawing.Point(660, 154)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(76, 24)
        Me.cbxActive.TabIndex = 10
        Me.cbxActive.TabStop = True
        Me.cbxActive.Text = "Active"
        Me.cbxActive.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(230, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(226, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Re-type password:"
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(230, 155)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(221, 26)
        Me.txtPass2.TabIndex = 4
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Employee ID:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1264, 24)
        Me.Panel2.TabIndex = 67
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 20)
        Me.lblTitle.TabIndex = 88
        Me.lblTitle.Text = "Employee Account Details"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(7, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(221, 26)
        Me.txtID.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(7, 155)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(217, 26)
        Me.txtPass.TabIndex = 3
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(234, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(367, 26)
        Me.txtEmail.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(7, 103)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(594, 26)
        Me.txtName.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox4)
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox3)
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox2)
        Me.TabPage1.Controls.Add(Me.Guna2GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1270, 775)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Application Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GroupBox4.Controls.Add(Me.btncgidConfirm)
        Me.Guna2GroupBox4.Controls.Add(Me.lblCGID)
        Me.Guna2GroupBox4.Controls.Add(Me.txtCGID)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(411, 283)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(426, 131)
        Me.Guna2GroupBox4.TabIndex = 103
        Me.Guna2GroupBox4.Text = "Remove Part That Printing Error But Already Stock In"
        '
        'btncgidConfirm
        '
        Me.btncgidConfirm.BorderColor = System.Drawing.Color.DarkGray
        Me.btncgidConfirm.BorderThickness = 1
        Me.btncgidConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncgidConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncgidConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncgidConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncgidConfirm.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btncgidConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btncgidConfirm.ForeColor = System.Drawing.Color.Black
        Me.btncgidConfirm.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.btncgidConfirm.ImageSize = New System.Drawing.Size(25, 25)
        Me.btncgidConfirm.Location = New System.Drawing.Point(275, 65)
        Me.btncgidConfirm.Name = "btncgidConfirm"
        Me.btncgidConfirm.Size = New System.Drawing.Size(127, 44)
        Me.btncgidConfirm.TabIndex = 28
        Me.btncgidConfirm.Text = "Delete"
        '
        'lblCGID
        '
        Me.lblCGID.AutoSize = True
        Me.lblCGID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGID.ForeColor = System.Drawing.Color.Black
        Me.lblCGID.Location = New System.Drawing.Point(20, 59)
        Me.lblCGID.Name = "lblCGID"
        Me.lblCGID.Size = New System.Drawing.Size(120, 20)
        Me.lblCGID.TabIndex = 4
        Me.lblCGID.Text = "CGID Number: "
        '
        'txtCGID
        '
        Me.txtCGID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCGID.Location = New System.Drawing.Point(24, 82)
        Me.txtCGID.Name = "txtCGID"
        Me.txtCGID.Size = New System.Drawing.Size(233, 27)
        Me.txtCGID.TabIndex = 3
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GroupBox3.ContextMenuStrip = Me.Guna2ContextMenuStrip4
        Me.Guna2GroupBox3.Controls.Add(Me.Label13)
        Me.Guna2GroupBox3.Controls.Add(Me.txtHWID)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(457, 626)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(327, 134)
        Me.Guna2GroupBox3.TabIndex = 102
        Me.Guna2GroupBox3.Text = "System HWID ( FOR CHECKING )"
        '
        'Guna2ContextMenuStrip4
        '
        Me.Guna2ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.Guna2ContextMenuStrip4.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip4.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip4.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip4.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip4.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip4.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip4.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip4.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip4.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip4.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip4.Size = New System.Drawing.Size(137, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem1.Text = "Copy HWID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(20, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "HWID:"
        '
        'txtHWID
        '
        Me.txtHWID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHWID.Enabled = False
        Me.txtHWID.Location = New System.Drawing.Point(24, 82)
        Me.txtHWID.Name = "txtHWID"
        Me.txtHWID.ReadOnly = True
        Me.txtHWID.Size = New System.Drawing.Size(282, 27)
        Me.txtHWID.TabIndex = 0
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GroupBox2.ContextMenuStrip = Me.Guna2ContextMenuStrip3
        Me.Guna2GroupBox2.Controls.Add(Me.Label11)
        Me.Guna2GroupBox2.Controls.Add(Me.txtCGIDNumber)
        Me.Guna2GroupBox2.Controls.Add(Me.btnCancelS)
        Me.Guna2GroupBox2.Controls.Add(Me.btnSave)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Controls.Add(Me.txtyyMM)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(411, 420)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(426, 200)
        Me.Guna2GroupBox2.TabIndex = 101
        Me.Guna2GroupBox2.Text = "System Management"
        '
        'Guna2ContextMenuStrip3
        '
        Me.Guna2ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.Guna2ContextMenuStrip3.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip3.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip3.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip3.Size = New System.Drawing.Size(210, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem2.Text = "Edit System Management"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "CGID Number Setting:"
        '
        'txtCGIDNumber
        '
        Me.txtCGIDNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCGIDNumber.Enabled = False
        Me.txtCGIDNumber.Location = New System.Drawing.Point(24, 145)
        Me.txtCGIDNumber.Name = "txtCGIDNumber"
        Me.txtCGIDNumber.Size = New System.Drawing.Size(213, 27)
        Me.txtCGIDNumber.TabIndex = 29
        '
        'btnCancelS
        '
        Me.btnCancelS.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelS.BorderThickness = 1
        Me.btnCancelS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelS.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancelS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelS.ForeColor = System.Drawing.Color.Black
        Me.btnCancelS.Image = Global.CG_Inventory_Management.My.Resources.Resources.delete
        Me.btnCancelS.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCancelS.Location = New System.Drawing.Point(275, 130)
        Me.btnCancelS.Name = "btnCancelS"
        Me.btnCancelS.Size = New System.Drawing.Size(127, 44)
        Me.btnCancelS.TabIndex = 28
        Me.btnCancelS.Text = "Cancel"
        Me.btnCancelS.Visible = False
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
        Me.btnSave.Image = Global.CG_Inventory_Management.My.Resources.Resources.add
        Me.btnSave.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSave.Location = New System.Drawing.Point(275, 80)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 44)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(20, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "yyMM Setting:"
        '
        'txtyyMM
        '
        Me.txtyyMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtyyMM.Enabled = False
        Me.txtyyMM.Location = New System.Drawing.Point(24, 82)
        Me.txtyyMM.Name = "txtyyMM"
        Me.txtyyMM.Size = New System.Drawing.Size(213, 27)
        Me.txtyyMM.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GroupBox1.ContextMenuStrip = Me.Guna2ContextMenuStrip2
        Me.Guna2GroupBox1.Controls.Add(Me.btnACancel)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAdd)
        Me.Guna2GroupBox1.Controls.Add(Me.lbxRack)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtRackName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(388, 16)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(473, 261)
        Me.Guna2GroupBox1.TabIndex = 100
        Me.Guna2GroupBox1.Text = "Rack Management"
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewRackToolStripMenuItem, Me.EditRackToolStripMenuItem, Me.DeleteRackToolStripMenuItem})
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(152, 70)
        '
        'CreateNewRackToolStripMenuItem
        '
        Me.CreateNewRackToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.add
        Me.CreateNewRackToolStripMenuItem.Name = "CreateNewRackToolStripMenuItem"
        Me.CreateNewRackToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CreateNewRackToolStripMenuItem.Text = "Add New Rack"
        '
        'EditRackToolStripMenuItem
        '
        Me.EditRackToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.EditRackToolStripMenuItem.Name = "EditRackToolStripMenuItem"
        Me.EditRackToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.EditRackToolStripMenuItem.Text = "Edit Rack"
        '
        'DeleteRackToolStripMenuItem
        '
        Me.DeleteRackToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.deletes
        Me.DeleteRackToolStripMenuItem.Name = "DeleteRackToolStripMenuItem"
        Me.DeleteRackToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DeleteRackToolStripMenuItem.Text = "Delete Rack"
        '
        'btnACancel
        '
        Me.btnACancel.BorderColor = System.Drawing.Color.DarkGray
        Me.btnACancel.BorderThickness = 1
        Me.btnACancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnACancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnACancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnACancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnACancel.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnACancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnACancel.ForeColor = System.Drawing.Color.Black
        Me.btnACancel.Image = Global.CG_Inventory_Management.My.Resources.Resources.delete
        Me.btnACancel.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnACancel.Location = New System.Drawing.Point(133, 156)
        Me.btnACancel.Name = "btnACancel"
        Me.btnACancel.Size = New System.Drawing.Size(103, 44)
        Me.btnACancel.TabIndex = 28
        Me.btnACancel.Text = "Cancel"
        Me.btnACancel.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = Global.CG_Inventory_Management.My.Resources.Resources.add
        Me.btnAdd.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(23, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 44)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Visible = False
        '
        'lbxRack
        '
        Me.lbxRack.FormattingEnabled = True
        Me.lbxRack.ItemHeight = 19
        Me.lbxRack.Location = New System.Drawing.Point(258, 53)
        Me.lbxRack.Name = "lbxRack"
        Me.lbxRack.Size = New System.Drawing.Size(200, 194)
        Me.lbxRack.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rack Name:"
        '
        'txtRackName
        '
        Me.txtRackName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRackName.Enabled = False
        Me.txtRackName.Location = New System.Drawing.Point(23, 108)
        Me.txtRackName.Name = "txtRackName"
        Me.txtRackName.Size = New System.Drawing.Size(213, 27)
        Me.txtRackName.TabIndex = 0
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1278, 823)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Red
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Red
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 99
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.Maroon
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2ContextMenuStrip4.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2ContextMenuStrip3.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2ContextMenuStrip2.ResumeLayout(False)
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxSuspend As RadioButton
    Friend WithEvents cbxActive As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtULvl As ComboBox
    Friend WithEvents txtUGroup As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents split As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditEmployeeDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteEmployeeAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbxSPass As CheckBox
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lbxRack As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRackName As TextBox
    Friend WithEvents btnACancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents CreateNewRackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditRackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnCancelS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtyyMM As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCGIDNumber As TextBox
    Friend WithEvents Guna2ContextMenuStrip3 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHWID As TextBox
    Friend WithEvents Guna2ContextMenuStrip4 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btncgidConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCGID As Label
    Friend WithEvents txtCGID As TextBox
End Class
