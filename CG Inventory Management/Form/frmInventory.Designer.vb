<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblpn = New System.Windows.Forms.Label()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.DeletePartNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblpn)
        Me.Panel1.Controls.Add(Me.cbxSearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 729)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 94)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Label2"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Location = New System.Drawing.Point(1104, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 35)
        Me.Panel3.TabIndex = 92
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
        Me.btnExport.Location = New System.Drawing.Point(1117, 34)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(136, 41)
        Me.btnExport.TabIndex = 91
        Me.btnExport.Text = "Export"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(423, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Like"
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
        Me.txtSearch.Location = New System.Drawing.Point(491, 41)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(597, 28)
        Me.txtSearch.TabIndex = 3
        '
        'lblpn
        '
        Me.lblpn.AutoSize = True
        Me.lblpn.BackColor = System.Drawing.Color.Transparent
        Me.lblpn.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpn.ForeColor = System.Drawing.Color.Black
        Me.lblpn.Location = New System.Drawing.Point(17, 41)
        Me.lblpn.Name = "lblpn"
        Me.lblpn.Size = New System.Drawing.Size(83, 25)
        Me.lblpn.TabIndex = 7
        Me.lblpn.Text = "Search"
        '
        'cbxSearch
        '
        Me.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"Part Number", "Part Type", "CG Code", "Part Description"})
        Me.cbxSearch.Location = New System.Drawing.Point(106, 41)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(296, 28)
        Me.cbxSearch.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1278, 17)
        Me.Panel2.TabIndex = 0
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.dgvInventory.Location = New System.Drawing.Point(0, 0)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(1278, 729)
        Me.dgvInventory.TabIndex = 3
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePartNumberToolStripMenuItem})
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
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(170, 26)
        '
        'DeletePartNumberToolStripMenuItem
        '
        Me.DeletePartNumberToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.printer__1_
        Me.DeletePartNumberToolStripMenuItem.Name = "DeletePartNumberToolStripMenuItem"
        Me.DeletePartNumberToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeletePartNumberToolStripMenuItem.Text = "Print Label Carton"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents cbxSearch As ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblpn As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents DeletePartNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
