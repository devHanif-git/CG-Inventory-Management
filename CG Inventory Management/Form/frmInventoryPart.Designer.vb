<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryPart))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.lblpn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.btnExport)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbxSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 698)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1175, 99)
        Me.Panel2.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Location = New System.Drawing.Point(1009, 41)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 35)
        Me.Panel8.TabIndex = 93
        '
        'btnExport
        '
        Me.btnExport.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.BorderThickness = 1
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnExport.Location = New System.Drawing.Point(1027, 37)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(123, 41)
        Me.btnExport.TabIndex = 96
        Me.btnExport.Text = "Export"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(-14, 106)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2180, 10)
        Me.Panel6.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1175, 17)
        Me.Panel3.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.DarkGray
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(405, 44)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(587, 28)
        Me.txtSearch.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(336, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Like"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Search"
        '
        'cbxSearch
        '
        Me.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"CGID", "Location", "Quantity", "GRN No.", "Remark"})
        Me.cbxSearch.Location = New System.Drawing.Point(111, 44)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(198, 28)
        Me.cbxSearch.TabIndex = 92
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(-9, -29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 2180)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(1174, -21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 2180)
        Me.Panel5.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.lblpn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 73)
        Me.Panel1.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(-30, -9)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(2180, 10)
        Me.Panel7.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1129, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 56)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 10
        Me.btnExit.TabStop = False
        '
        'lblpn
        '
        Me.lblpn.AutoSize = True
        Me.lblpn.BackColor = System.Drawing.Color.Transparent
        Me.lblpn.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpn.ForeColor = System.Drawing.Color.White
        Me.lblpn.Location = New System.Drawing.Point(285, 25)
        Me.lblpn.Name = "lblpn"
        Me.lblpn.Size = New System.Drawing.Size(134, 25)
        Me.lblpn.TabIndex = 6
        Me.lblpn.Text = "PartNumber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inventory for Part Number:"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventory.Location = New System.Drawing.Point(0, 73)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(1175, 625)
        Me.dgvInventory.TabIndex = 2
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcToolStripMenuItem})
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
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(200, 26)
        '
        'CalcToolStripMenuItem
        '
        Me.CalcToolStripMenuItem.Image = CType(resources.GetObject("CalcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CalcToolStripMenuItem.Text = "Find The Exact Quantity"
        '
        'frmInventoryPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 797)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryPart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Part"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblpn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxSearch As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents CalcToolStripMenuItem As ToolStripMenuItem
End Class
