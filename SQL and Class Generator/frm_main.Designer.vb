<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckctrusted = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboserver = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grpbox = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.rd3 = New System.Windows.Forms.RadioButton()
        Me.btnprocedure = New System.Windows.Forms.Button()
        Me.rd5 = New System.Windows.Forms.RadioButton()
        Me.rd4 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgdetails = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCountSub = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.rmytxt = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenNewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnclass = New System.Windows.Forms.Button()
        Me.rdc = New System.Windows.Forms.RadioButton()
        Me.rdvb = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbotable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbodatabase = New System.Windows.Forms.ComboBox()
        Me.cntxtmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpbox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnconnect)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ckctrusted)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboserver)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1162, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authentication"
        '
        'btnconnect
        '
        Me.btnconnect.BackColor = System.Drawing.SystemColors.Control
        Me.btnconnect.Location = New System.Drawing.Point(802, 30)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnconnect.TabIndex = 8
        Me.btnconnect.Text = "Connect..."
        Me.btnconnect.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(656, 32)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(141, 20)
        Me.txtpassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(698, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(509, 32)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(141, 20)
        Me.txtusername.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(535, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'ckctrusted
        '
        Me.ckctrusted.AutoSize = True
        Me.ckctrusted.Location = New System.Drawing.Point(389, 20)
        Me.ckctrusted.Name = "ckctrusted"
        Me.ckctrusted.Size = New System.Drawing.Size(119, 17)
        Me.ckctrusted.TabIndex = 3
        Me.ckctrusted.Text = "Trusted Connection"
        Me.ckctrusted.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SQL Server:"
        '
        'cboserver
        '
        Me.cboserver.FormattingEnabled = True
        Me.cboserver.Location = New System.Drawing.Point(183, 19)
        Me.cboserver.Name = "cboserver"
        Me.cboserver.Size = New System.Drawing.Size(191, 21)
        Me.cboserver.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.Location = New System.Drawing.Point(19, 20)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'grpbox
        '
        Me.grpbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpbox.Controls.Add(Me.GroupBox3)
        Me.grpbox.Controls.Add(Me.SplitContainer1)
        Me.grpbox.Controls.Add(Me.GroupBox2)
        Me.grpbox.Controls.Add(Me.Label5)
        Me.grpbox.Controls.Add(Me.cbotable)
        Me.grpbox.Controls.Add(Me.Label4)
        Me.grpbox.Controls.Add(Me.cbodatabase)
        Me.grpbox.Location = New System.Drawing.Point(13, 72)
        Me.grpbox.Name = "grpbox"
        Me.grpbox.Size = New System.Drawing.Size(1161, 437)
        Me.grpbox.TabIndex = 1
        Me.grpbox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rd1)
        Me.GroupBox3.Controls.Add(Me.rd3)
        Me.GroupBox3.Controls.Add(Me.btnprocedure)
        Me.GroupBox3.Controls.Add(Me.rd5)
        Me.GroupBox3.Controls.Add(Me.rd4)
        Me.GroupBox3.Controls.Add(Me.rd2)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(441, 42)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generate SQL Query / Class"
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.BackColor = System.Drawing.Color.Transparent
        Me.rd1.Checked = True
        Me.rd1.Location = New System.Drawing.Point(9, 15)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(101, 17)
        Me.rd1.TabIndex = 7
        Me.rd1.TabStop = True
        Me.rd1.Text = "Append_update"
        Me.rd1.UseVisualStyleBackColor = False
        '
        'rd3
        '
        Me.rd3.AutoSize = True
        Me.rd3.BackColor = System.Drawing.Color.Transparent
        Me.rd3.Location = New System.Drawing.Point(175, 15)
        Me.rd3.Name = "rd3"
        Me.rd3.Size = New System.Drawing.Size(51, 17)
        Me.rd3.TabIndex = 6
        Me.rd3.Text = "Insert"
        Me.rd3.UseVisualStyleBackColor = False
        '
        'btnprocedure
        '
        Me.btnprocedure.BackColor = System.Drawing.SystemColors.Control
        Me.btnprocedure.Location = New System.Drawing.Point(356, 12)
        Me.btnprocedure.Name = "btnprocedure"
        Me.btnprocedure.Size = New System.Drawing.Size(75, 23)
        Me.btnprocedure.TabIndex = 4
        Me.btnprocedure.Text = "&Procedure"
        Me.btnprocedure.UseVisualStyleBackColor = False
        '
        'rd5
        '
        Me.rd5.AutoSize = True
        Me.rd5.BackColor = System.Drawing.Color.Transparent
        Me.rd5.Location = New System.Drawing.Point(298, 15)
        Me.rd5.Name = "rd5"
        Me.rd5.Size = New System.Drawing.Size(56, 17)
        Me.rd5.TabIndex = 3
        Me.rd5.Text = "Delete"
        Me.rd5.UseVisualStyleBackColor = False
        '
        'rd4
        '
        Me.rd4.AutoSize = True
        Me.rd4.BackColor = System.Drawing.Color.Transparent
        Me.rd4.Location = New System.Drawing.Point(232, 15)
        Me.rd4.Name = "rd4"
        Me.rd4.Size = New System.Drawing.Size(60, 17)
        Me.rd4.TabIndex = 2
        Me.rd4.Text = "Update"
        Me.rd4.UseVisualStyleBackColor = False
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.BackColor = System.Drawing.Color.Transparent
        Me.rd2.Location = New System.Drawing.Point(114, 15)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(55, 17)
        Me.rd2.TabIndex = 1
        Me.rd2.Text = "Select"
        Me.rd2.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(18, 106)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgdetails)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rmytxt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1126, 325)
        Me.SplitContainer1.SplitterDistance = 451
        Me.SplitContainer1.TabIndex = 7
        '
        'dgdetails
        '
        Me.dgdetails.AllowUserToAddRows = False
        Me.dgdetails.AllowUserToDeleteRows = False
        Me.dgdetails.AllowUserToResizeRows = False
        Me.dgdetails.BackgroundColor = System.Drawing.Color.White
        Me.dgdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.colid, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgdetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdetails.Location = New System.Drawing.Point(0, 0)
        Me.dgdetails.Name = "dgdetails"
        Me.dgdetails.RowHeadersVisible = False
        Me.dgdetails.Size = New System.Drawing.Size(451, 301)
        Me.dgdetails.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.FalseValue = "0"
        Me.Column1.HeaderText = ""
        Me.Column1.IndeterminateValue = "0"
        Me.Column1.Name = "Column1"
        Me.Column1.TrueValue = "1"
        Me.Column1.Width = 40
        '
        'colid
        '
        Me.colid.HeaderText = "colid"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 120.0!
        Me.Column2.HeaderText = "Column Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Data Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.FillWeight = 60.0!
        Me.Column4.HeaderText = "Length"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "IsNull"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "IsPrimary"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btncheck)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 301)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 24)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lblCountSub)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(3, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(142, 22)
        Me.Panel3.TabIndex = 77
        '
        'lblCountSub
        '
        Me.lblCountSub.AutoSize = True
        Me.lblCountSub.BackColor = System.Drawing.Color.Transparent
        Me.lblCountSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountSub.ForeColor = System.Drawing.Color.Black
        Me.lblCountSub.Location = New System.Drawing.Point(86, 4)
        Me.lblCountSub.Name = "lblCountSub"
        Me.lblCountSub.Size = New System.Drawing.Size(16, 16)
        Me.lblCountSub.TabIndex = 1
        Me.lblCountSub.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "No. of Records:"
        '
        'btncheck
        '
        Me.btncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncheck.BackColor = System.Drawing.SystemColors.Control
        Me.btncheck.Enabled = False
        Me.btncheck.Location = New System.Drawing.Point(373, 0)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(75, 23)
        Me.btncheck.TabIndex = 0
        Me.btncheck.Text = "&Check All"
        Me.btncheck.UseVisualStyleBackColor = False
        '
        'rmytxt
        '
        Me.rmytxt.ContextMenuStrip = Me.ContextMenuStrip1
        Me.rmytxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rmytxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rmytxt.Location = New System.Drawing.Point(0, 0)
        Me.rmytxt.Name = "rmytxt"
        Me.rmytxt.Size = New System.Drawing.Size(671, 301)
        Me.rmytxt.TabIndex = 2
        Me.rmytxt.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenNewWindowToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitApplicationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 76)
        '
        'OpenNewWindowToolStripMenuItem
        '
        Me.OpenNewWindowToolStripMenuItem.Name = "OpenNewWindowToolStripMenuItem"
        Me.OpenNewWindowToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpenNewWindowToolStripMenuItem.Text = "Open new window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem1.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit application"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbllength)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 24)
        Me.Panel1.TabIndex = 1
        '
        'lbllength
        '
        Me.lbllength.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbllength.AutoSize = True
        Me.lbllength.BackColor = System.Drawing.Color.Transparent
        Me.lbllength.Location = New System.Drawing.Point(8, 5)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(43, 13)
        Me.lbllength.TabIndex = 0
        Me.lbllength.Text = "Length:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnclass)
        Me.GroupBox2.Controls.Add(Me.rdc)
        Me.GroupBox2.Controls.Add(Me.rdvb)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 39)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Language for class"
        '
        'btnclass
        '
        Me.btnclass.BackColor = System.Drawing.SystemColors.Control
        Me.btnclass.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnclass.Location = New System.Drawing.Point(162, 12)
        Me.btnclass.Name = "btnclass"
        Me.btnclass.Size = New System.Drawing.Size(75, 23)
        Me.btnclass.TabIndex = 6
        Me.btnclass.Text = "&Class"
        Me.btnclass.UseVisualStyleBackColor = False
        '
        'rdc
        '
        Me.rdc.AutoSize = True
        Me.rdc.Location = New System.Drawing.Point(117, 15)
        Me.rdc.Name = "rdc"
        Me.rdc.Size = New System.Drawing.Size(39, 17)
        Me.rdc.TabIndex = 1
        Me.rdc.Text = "C#"
        Me.rdc.UseVisualStyleBackColor = True
        '
        'rdvb
        '
        Me.rdvb.AutoSize = True
        Me.rdvb.Checked = True
        Me.rdvb.Location = New System.Drawing.Point(32, 15)
        Me.rdvb.Name = "rdvb"
        Me.rdvb.Size = New System.Drawing.Size(55, 17)
        Me.rdvb.TabIndex = 0
        Me.rdvb.TabStop = True
        Me.rdvb.Text = "vb.net"
        Me.rdvb.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Select Table"
        '
        'cbotable
        '
        Me.cbotable.FormattingEnabled = True
        Me.cbotable.Location = New System.Drawing.Point(228, 34)
        Me.cbotable.Name = "cbotable"
        Me.cbotable.Size = New System.Drawing.Size(191, 21)
        Me.cbotable.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Database"
        '
        'cbodatabase
        '
        Me.cbodatabase.FormattingEnabled = True
        Me.cbodatabase.Location = New System.Drawing.Point(18, 34)
        Me.cbodatabase.Name = "cbodatabase"
        Me.cbodatabase.Size = New System.Drawing.Size(191, 21)
        Me.cbodatabase.TabIndex = 2
        '
        'cntxtmenu
        '
        Me.cntxtmenu.Name = "cntxtmenu"
        Me.cntxtmenu.Size = New System.Drawing.Size(61, 4)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1186, 521)
        Me.Controls.Add(Me.grpbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbox.ResumeLayout(False)
        Me.grpbox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboserver As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ckctrusted As System.Windows.Forms.CheckBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnconnect As System.Windows.Forms.Button
    Friend WithEvents grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbotable As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbodatabase As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdc As System.Windows.Forms.RadioButton
    Friend WithEvents rdvb As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rd5 As System.Windows.Forms.RadioButton
    Friend WithEvents rd4 As System.Windows.Forms.RadioButton
    Friend WithEvents rd2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnprocedure As System.Windows.Forms.Button
    Friend WithEvents rmytxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbllength As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenNewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rd3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgdetails As System.Windows.Forms.DataGridView
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCountSub As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rd1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnclass As System.Windows.Forms.Button
    Friend WithEvents cntxtmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
