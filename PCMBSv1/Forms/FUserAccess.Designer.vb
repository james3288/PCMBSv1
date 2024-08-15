<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUserAccess
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUserAccess))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PMain = New System.Windows.Forms.Panel()
        Me.pPanel_Right = New System.Windows.Forms.Panel()
        Me.pRightDgvContainer = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pPanel_Left = New System.Windows.Forms.Panel()
        Me.pLeftDgvContainer = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PHeader = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cms_userAccess_dgv_right = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_userAccess_dgv_left = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnselectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PMain.SuspendLayout()
        Me.pPanel_Right.SuspendLayout()
        Me.pRightDgvContainer.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pPanel_Left.SuspendLayout()
        Me.pLeftDgvContainer.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PHeader.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_userAccess_dgv_right.SuspendLayout()
        Me.cms_userAccess_dgv_left.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PMain, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1328, 647)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PMain
        '
        Me.PMain.BackgroundImage = CType(resources.GetObject("PMain.BackgroundImage"), System.Drawing.Image)
        Me.PMain.Controls.Add(Me.pPanel_Right)
        Me.PMain.Controls.Add(Me.pPanel_Left)
        Me.PMain.Controls.Add(Me.PHeader)
        Me.PMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PMain.Location = New System.Drawing.Point(53, 53)
        Me.PMain.Name = "PMain"
        Me.PMain.Size = New System.Drawing.Size(1222, 541)
        Me.PMain.TabIndex = 0
        '
        'pPanel_Right
        '
        Me.pPanel_Right.Controls.Add(Me.pRightDgvContainer)
        Me.pPanel_Right.Controls.Add(Me.Panel1)
        Me.pPanel_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPanel_Right.Location = New System.Drawing.Point(458, 46)
        Me.pPanel_Right.Name = "pPanel_Right"
        Me.pPanel_Right.Size = New System.Drawing.Size(764, 495)
        Me.pPanel_Right.TabIndex = 2
        '
        'pRightDgvContainer
        '
        Me.pRightDgvContainer.Controls.Add(Me.DataGridView2)
        Me.pRightDgvContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRightDgvContainer.Location = New System.Drawing.Point(0, 0)
        Me.pRightDgvContainer.Name = "pRightDgvContainer"
        Me.pRightDgvContainer.Size = New System.Drawing.Size(764, 432)
        Me.pRightDgvContainer.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.cms_userAccess_dgv_right
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.SlateGray
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(764, 432)
        Me.DataGridView2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 432)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 63)
        Me.Panel1.TabIndex = 0
        '
        'pPanel_Left
        '
        Me.pPanel_Left.Controls.Add(Me.pLeftDgvContainer)
        Me.pPanel_Left.Controls.Add(Me.Panel2)
        Me.pPanel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pPanel_Left.Location = New System.Drawing.Point(0, 46)
        Me.pPanel_Left.Name = "pPanel_Left"
        Me.pPanel_Left.Size = New System.Drawing.Size(458, 495)
        Me.pPanel_Left.TabIndex = 1
        '
        'pLeftDgvContainer
        '
        Me.pLeftDgvContainer.Controls.Add(Me.DataGridView1)
        Me.pLeftDgvContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pLeftDgvContainer.Location = New System.Drawing.Point(0, 0)
        Me.pLeftDgvContainer.Name = "pLeftDgvContainer"
        Me.pLeftDgvContainer.Size = New System.Drawing.Size(458, 432)
        Me.pLeftDgvContainer.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.cms_userAccess_dgv_left
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SlateGray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(458, 432)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 63)
        Me.Panel2.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.PCMBSv1.My.Resources.Resources.save
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(314, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 38)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Update"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'PHeader
        '
        Me.PHeader.BackgroundImage = CType(resources.GetObject("PHeader.BackgroundImage"), System.Drawing.Image)
        Me.PHeader.Controls.Add(Me.PictureBox10)
        Me.PHeader.Controls.Add(Me.Label2)
        Me.PHeader.Controls.Add(Me.PictureBox1)
        Me.PHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PHeader.Location = New System.Drawing.Point(0, 0)
        Me.PHeader.Name = "PHeader"
        Me.PHeader.Size = New System.Drawing.Size(1222, 46)
        Me.PHeader.TabIndex = 0
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(21, 11)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox10.TabIndex = 23
        Me.PictureBox10.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label2.Location = New System.Drawing.Point(55, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "User Access"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PCMBSv1.My.Resources.Resources.close_button3
        Me.PictureBox1.Location = New System.Drawing.Point(1190, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cms_userAccess_dgv_right
        '
        Me.cms_userAccess_dgv_right.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_userAccess_dgv_right.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem})
        Me.cms_userAccess_dgv_right.Name = "cms_rs"
        Me.cms_userAccess_dgv_right.Size = New System.Drawing.Size(110, 26)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByRSToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'SearchByRSToolStripMenuItem
        '
        Me.SearchByRSToolStripMenuItem.Name = "SearchByRSToolStripMenuItem"
        Me.SearchByRSToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SearchByRSToolStripMenuItem.Text = "Search by Name"
        '
        'cms_userAccess_dgv_left
        '
        Me.cms_userAccess_dgv_left.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_userAccess_dgv_left.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cms_userAccess_dgv_left.Name = "cms_rs"
        Me.cms_userAccess_dgv_left.Size = New System.Drawing.Size(153, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.UnselectToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Select"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Select All"
        '
        'UnselectToolStripMenuItem
        '
        Me.UnselectToolStripMenuItem.Name = "UnselectToolStripMenuItem"
        Me.UnselectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnselectToolStripMenuItem.Text = "Unselect All"
        '
        'FUserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1328, 647)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FUserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PMain.ResumeLayout(False)
        Me.pPanel_Right.ResumeLayout(False)
        Me.pRightDgvContainer.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pPanel_Left.ResumeLayout(False)
        Me.pLeftDgvContainer.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PHeader.ResumeLayout(False)
        Me.PHeader.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_userAccess_dgv_right.ResumeLayout(False)
        Me.cms_userAccess_dgv_left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PMain As Panel
    Friend WithEvents PHeader As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents pPanel_Right As Panel
    Friend WithEvents pPanel_Left As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pRightDgvContainer As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pLeftDgvContainer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents cms_userAccess_dgv_right As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchByRSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cms_userAccess_dgv_left As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UnselectToolStripMenuItem As ToolStripMenuItem
End Class
