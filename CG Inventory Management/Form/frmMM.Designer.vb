<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMM))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImport = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblpn = New System.Windows.Forms.Label()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLast = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFirst = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrev = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.lblTotalHis = New System.Windows.Forms.Label()
        Me.dgvMM = New System.Windows.Forms.DataGridView()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.EditPartNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePartNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblpn)
        Me.Panel1.Controls.Add(Me.cbxSearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 716)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 107)
        Me.Panel1.TabIndex = 2
        '
        'btnImport
        '
        Me.btnImport.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImport.BorderThickness = 1
        Me.btnImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImport.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnImport.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnImport.ForeColor = System.Drawing.Color.Black
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnImport.Location = New System.Drawing.Point(953, 47)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(136, 41)
        Me.btnImport.TabIndex = 93
        Me.btnImport.Text = "Import"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Location = New System.Drawing.Point(1101, 51)
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
        Me.btnExport.Location = New System.Drawing.Point(1114, 47)
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
        Me.Label1.Location = New System.Drawing.Point(342, 54)
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
        Me.txtSearch.Location = New System.Drawing.Point(410, 54)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(526, 28)
        Me.txtSearch.TabIndex = 3
        '
        'lblpn
        '
        Me.lblpn.AutoSize = True
        Me.lblpn.BackColor = System.Drawing.Color.Transparent
        Me.lblpn.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpn.ForeColor = System.Drawing.Color.Black
        Me.lblpn.Location = New System.Drawing.Point(17, 54)
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
        Me.cbxSearch.Location = New System.Drawing.Point(106, 54)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(219, 28)
        Me.cbxSearch.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.btnLast)
        Me.Panel2.Controls.Add(Me.btnFirst)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Controls.Add(Me.lblPage)
        Me.Panel2.Controls.Add(Me.lblTotalHis)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1278, 29)
        Me.Panel2.TabIndex = 0
        '
        'btnLast
        '
        Me.btnLast.AutoRoundedCorners = True
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.BorderColor = System.Drawing.Color.White
        Me.btnLast.BorderRadius = 8
        Me.btnLast.BorderThickness = 1
        Me.btnLast.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLast.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLast.FillColor = System.Drawing.Color.White
        Me.btnLast.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLast.Location = New System.Drawing.Point(1209, 5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(57, 18)
        Me.btnLast.TabIndex = 100
        Me.btnLast.Text = "Last"
        Me.btnLast.UseTransparentBackground = True
        '
        'btnFirst
        '
        Me.btnFirst.AutoRoundedCorners = True
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.BorderColor = System.Drawing.Color.White
        Me.btnFirst.BorderRadius = 8
        Me.btnFirst.BorderThickness = 1
        Me.btnFirst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFirst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFirst.FillColor = System.Drawing.Color.White
        Me.btnFirst.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnFirst.Location = New System.Drawing.Point(905, 5)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(57, 18)
        Me.btnFirst.TabIndex = 99
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseTransparentBackground = True
        '
        'btnNext
        '
        Me.btnNext.AutoRoundedCorners = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderColor = System.Drawing.Color.White
        Me.btnNext.BorderRadius = 8
        Me.btnNext.BorderThickness = 1
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnNext.Location = New System.Drawing.Point(1146, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(57, 18)
        Me.btnNext.TabIndex = 98
        Me.btnNext.Text = "Next"
        Me.btnNext.UseTransparentBackground = True
        '
        'btnPrev
        '
        Me.btnPrev.AutoRoundedCorners = True
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.BorderColor = System.Drawing.Color.White
        Me.btnPrev.BorderRadius = 8
        Me.btnPrev.BorderThickness = 1
        Me.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrev.FillColor = System.Drawing.Color.White
        Me.btnPrev.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrev.ForeColor = System.Drawing.Color.Black
        Me.btnPrev.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnPrev.Location = New System.Drawing.Point(968, 5)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(57, 18)
        Me.btnPrev.TabIndex = 97
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseTransparentBackground = True
        '
        'lblPage
        '
        Me.lblPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPage.ForeColor = System.Drawing.Color.White
        Me.lblPage.Location = New System.Drawing.Point(1031, 3)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(109, 20)
        Me.lblPage.TabIndex = 96
        Me.lblPage.Text = "Page {0} of {1}"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalHis
        '
        Me.lblTotalHis.AutoSize = True
        Me.lblTotalHis.ForeColor = System.Drawing.Color.White
        Me.lblTotalHis.Location = New System.Drawing.Point(12, 3)
        Me.lblTotalHis.Name = "lblTotalHis"
        Me.lblTotalHis.Size = New System.Drawing.Size(418, 20)
        Me.lblTotalHis.TabIndex = 90
        Me.lblTotalHis.Text = "{0} records overall, {1} pages, and 200 records per page."
        '
        'dgvMM
        '
        Me.dgvMM.AllowUserToAddRows = False
        Me.dgvMM.AllowUserToDeleteRows = False
        Me.dgvMM.BackgroundColor = System.Drawing.Color.White
        Me.dgvMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMM.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.dgvMM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMM.Location = New System.Drawing.Point(0, 0)
        Me.dgvMM.Name = "dgvMM"
        Me.dgvMM.ReadOnly = True
        Me.dgvMM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMM.Size = New System.Drawing.Size(1278, 716)
        Me.dgvMM.TabIndex = 3
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPartNumberToolStripMenuItem, Me.DeletePartNumberToolStripMenuItem})
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
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(179, 48)
        '
        'EditPartNumberToolStripMenuItem
        '
        Me.EditPartNumberToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.edit
        Me.EditPartNumberToolStripMenuItem.Name = "EditPartNumberToolStripMenuItem"
        Me.EditPartNumberToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EditPartNumberToolStripMenuItem.Text = "Edit Part Number"
        '
        'DeletePartNumberToolStripMenuItem
        '
        Me.DeletePartNumberToolStripMenuItem.Image = Global.CG_Inventory_Management.My.Resources.Resources.deletes
        Me.DeletePartNumberToolStripMenuItem.Name = "DeletePartNumberToolStripMenuItem"
        Me.DeletePartNumberToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DeletePartNumberToolStripMenuItem.Text = "Delete Part Number"
        '
        'frmMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 823)
        Me.Controls.Add(Me.dgvMM)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Part Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblpn As Label
    Friend WithEvents cbxSearch As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMM As DataGridView
    Friend WithEvents btnImport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents DeletePartNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPartNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotalHis As Label
    Friend WithEvents btnLast As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFirst As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPage As Label
End Class
