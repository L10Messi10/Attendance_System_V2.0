<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim Animation2 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim Animation3 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddedEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sidemenu = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Button5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_start = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Picturebox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.se = New System.Windows.Forms.Panel()
        Me.stt = New System.Windows.Forms.Panel()
        Me.rpt = New System.Windows.Forms.Panel()
        Me.ev = New System.Windows.Forms.Panel()
        Me.stu = New System.Windows.Forms.Panel()
        Me.sc = New System.Windows.Forms.Panel()
        Me.lm = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.PictureAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.LabelAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.MenuStrip.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.sidemenu.SuspendLayout
        Me.MetroPanel4.SuspendLayout
        CType(Me.BunifuImageButton1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Picturebox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddedEventsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AddedEventsToolStripMenuItem
        '
        Me.AddedEventsToolStripMenuItem.Image = CType(resources.GetObject("AddedEventsToolStripMenuItem.Image"),System.Drawing.Image)
        Me.AddedEventsToolStripMenuItem.Name = "AddedEventsToolStripMenuItem"
        Me.AddedEventsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H),System.Windows.Forms.Keys)
        Me.AddedEventsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddedEventsToolStripMenuItem.Text = "Scheduled Events"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"),System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T),System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = true
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(177,Byte),Integer), CType(CType(89,Byte),Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.Label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.Label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.Label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(177,Byte),Integer), CType(CType(89,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 22)
        Me.Label2.Style = MetroFramework.MetroColorStyle.Lime
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "MetroLabel1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTip.SetToolTip(Me.Label2, "View Profile")
        Me.Label2.UseCustomForeColor = true
        '
        'ViewMenu
        '
        Me.ViewMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentRecordToolStripMenuItem, Me.CourseToolStripMenuItem, Me.EventToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ViewMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ViewMenu.ForeColor = System.Drawing.Color.Black
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(43, 20)
        Me.ViewMenu.Text = "Files"
        '
        'StudentRecordToolStripMenuItem
        '
        Me.StudentRecordToolStripMenuItem.Image = CType(resources.GetObject("StudentRecordToolStripMenuItem.Image"),System.Drawing.Image)
        Me.StudentRecordToolStripMenuItem.Name = "StudentRecordToolStripMenuItem"
        Me.StudentRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.StudentRecordToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.StudentRecordToolStripMenuItem.Text = "Student Record"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Image = CType(resources.GetObject("CourseToolStripMenuItem.Image"),System.Drawing.Image)
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.Image = CType(resources.GetObject("EventToolStripMenuItem.Image"),System.Drawing.Image)
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E),System.Windows.Forms.Keys)
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EventToolStripMenuItem.Text = "Event"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.PictureAnimator.SetDecoration(Me.MenuStrip, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.MenuStrip, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.MenuStrip, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMenu, Me.ViewToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(270, 60)
        Me.MenuStrip.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.ShowItemToolTips = true
        Me.MenuStrip.Size = New System.Drawing.Size(1116, 24)
        Me.MenuStrip.TabIndex = 16
        Me.MenuStrip.Text = "MenuStrip"
        Me.MenuStrip.Visible = false
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'StatusStrip1
        '
        Me.PictureAnimator.SetDecoration(Me.StatusStrip1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.StatusStrip1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.StatusStrip1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Light", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(20, 953)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1354, 26)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(46, 21)
        Me.ToolStripStatusLabel1.Text = "Date:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(46, 21)
        Me.ToolStripStatusLabel2.Text = "Date:"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(30, 21)
        Me.ToolStripStatusLabel3.Text = "     "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(150, 21)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'sidemenu
        '
        Me.sidemenu.Controls.Add(Me.MetroPanel2)
        Me.sidemenu.Controls.Add(Me.Label3)
        Me.sidemenu.Controls.Add(Me.ListView1)
        Me.sidemenu.Controls.Add(Me.Button5)
        Me.sidemenu.Controls.Add(Me.Button3)
        Me.sidemenu.Controls.Add(Me.Button1)
        Me.sidemenu.Controls.Add(Me.Button2)
        Me.sidemenu.Controls.Add(Me.Button4)
        Me.sidemenu.Controls.Add(Me.btn_start)
        Me.sidemenu.Controls.Add(Me.BunifuFlatButton1)
        Me.sidemenu.Controls.Add(Me.MetroPanel4)
        Me.sidemenu.Controls.Add(Me.Panel1)
        Me.PanelAnimator.SetDecoration(Me.sidemenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.sidemenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.sidemenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidemenu.HorizontalScrollbarBarColor = true
        Me.sidemenu.HorizontalScrollbarHighlightOnWheel = false
        Me.sidemenu.HorizontalScrollbarSize = 10
        Me.sidemenu.Location = New System.Drawing.Point(20, 60)
        Me.sidemenu.Name = "sidemenu"
        Me.sidemenu.Size = New System.Drawing.Size(260, 893)
        Me.sidemenu.TabIndex = 21
        Me.sidemenu.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.sidemenu.VerticalScrollbarBarColor = true
        Me.sidemenu.VerticalScrollbarHighlightOnWheel = false
        Me.sidemenu.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(177,Byte),Integer), CType(CType(89,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.MetroPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.MetroPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.MetroPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = true
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(5, 602)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(255, 2)
        Me.MetroPanel2.TabIndex = 24
        Me.MetroPanel2.UseCustomBackColor = true
        Me.MetroPanel2.VerticalScrollbarBarColor = true
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Label3
        '
        Me.PanelAnimator.SetDecoration(Me.Label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.Label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.Label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.ForeColor = System.Drawing.Color.LightCoral
        Me.Label3.Location = New System.Drawing.Point(5, 727)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 19)
        Me.Label3.Style = MetroFramework.MetroColorStyle.Lime
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "MetroLabel1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Label3.UseCustomForeColor = true
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.PanelAnimator.SetDecoration(Me.ListView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.ListView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.ListView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ListView1.GridLines = true
        Me.ListView1.HideSelection = false
        Me.ListView1.Location = New System.Drawing.Point(5, 746)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(255, 147)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = false
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Event #"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 108
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Session(s)"
        '
        'Button5
        '
        Me.Button5.Active = false
        Me.Button5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.BorderRadius = 0
        Me.Button5.ButtonText = "     Scheduled Events"
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.Button5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Button5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.Button5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Button5.DisabledColor = System.Drawing.Color.Gray
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.Iconcolor = System.Drawing.Color.Transparent
        Me.Button5.Iconimage = CType(resources.GetObject("Button5.Iconimage"),System.Drawing.Image)
        Me.Button5.Iconimage_right = Nothing
        Me.Button5.Iconimage_right_Selected = Nothing
        Me.Button5.Iconimage_Selected = Nothing
        Me.Button5.IconMarginLeft = 0
        Me.Button5.IconMarginRight = 0
        Me.Button5.IconRightVisible = true
        Me.Button5.IconRightZoom = 0R
        Me.Button5.IconVisible = true
        Me.Button5.IconZoom = 90R
        Me.Button5.IsTab = false
        Me.Button5.Location = New System.Drawing.Point(5, 550)
        Me.Button5.Name = "Button5"
        Me.Button5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.Button5.OnHoverTextColor = System.Drawing.Color.White
        Me.Button5.selected = false
        Me.Button5.Size = New System.Drawing.Size(255, 52)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "     Scheduled Events"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Textcolor = System.Drawing.Color.White
        Me.Button5.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Button3
        '
        Me.Button3.Active = false
        Me.Button3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.BorderRadius = 0
        Me.Button3.ButtonText = "     Settings"
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.Button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.Button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Button3.DisabledColor = System.Drawing.Color.Gray
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Iconcolor = System.Drawing.Color.Transparent
        Me.Button3.Iconimage = CType(resources.GetObject("Button3.Iconimage"),System.Drawing.Image)
        Me.Button3.Iconimage_right = Nothing
        Me.Button3.Iconimage_right_Selected = Nothing
        Me.Button3.Iconimage_Selected = Nothing
        Me.Button3.IconMarginLeft = 0
        Me.Button3.IconMarginRight = 0
        Me.Button3.IconRightVisible = true
        Me.Button3.IconRightZoom = 0R
        Me.Button3.IconVisible = true
        Me.Button3.IconZoom = 90R
        Me.Button3.IsTab = false
        Me.Button3.Location = New System.Drawing.Point(5, 492)
        Me.Button3.Name = "Button3"
        Me.Button3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.Button3.OnHoverTextColor = System.Drawing.Color.White
        Me.Button3.selected = false
        Me.Button3.Size = New System.Drawing.Size(255, 58)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "     Settings"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Textcolor = System.Drawing.Color.White
        Me.Button3.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Button1
        '
        Me.Button1.Active = false
        Me.Button1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.BorderRadius = 0
        Me.Button1.ButtonText = "     Reports"
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.Button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.Button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Button1.DisabledColor = System.Drawing.Color.Gray
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Iconcolor = System.Drawing.Color.Transparent
        Me.Button1.Iconimage = CType(resources.GetObject("Button1.Iconimage"),System.Drawing.Image)
        Me.Button1.Iconimage_right = Nothing
        Me.Button1.Iconimage_right_Selected = Nothing
        Me.Button1.Iconimage_Selected = Nothing
        Me.Button1.IconMarginLeft = 0
        Me.Button1.IconMarginRight = 0
        Me.Button1.IconRightVisible = true
        Me.Button1.IconRightZoom = 0R
        Me.Button1.IconVisible = true
        Me.Button1.IconZoom = 90R
        Me.Button1.IsTab = false
        Me.Button1.Location = New System.Drawing.Point(5, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.Button1.OnHoverTextColor = System.Drawing.Color.White
        Me.Button1.selected = false
        Me.Button1.Size = New System.Drawing.Size(255, 58)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "     Reports"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Textcolor = System.Drawing.Color.White
        Me.Button1.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Button2
        '
        Me.Button2.Active = false
        Me.Button2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.BorderRadius = 0
        Me.Button2.ButtonText = "     Events"
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.Button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.Button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Button2.DisabledColor = System.Drawing.Color.Gray
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Iconcolor = System.Drawing.Color.Transparent
        Me.Button2.Iconimage = CType(resources.GetObject("Button2.Iconimage"),System.Drawing.Image)
        Me.Button2.Iconimage_right = Nothing
        Me.Button2.Iconimage_right_Selected = Nothing
        Me.Button2.Iconimage_Selected = Nothing
        Me.Button2.IconMarginLeft = 0
        Me.Button2.IconMarginRight = 0
        Me.Button2.IconRightVisible = true
        Me.Button2.IconRightZoom = 0R
        Me.Button2.IconVisible = true
        Me.Button2.IconZoom = 90R
        Me.Button2.IsTab = false
        Me.Button2.Location = New System.Drawing.Point(5, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.Button2.OnHoverTextColor = System.Drawing.Color.White
        Me.Button2.selected = false
        Me.Button2.Size = New System.Drawing.Size(255, 58)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "     Events"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Textcolor = System.Drawing.Color.White
        Me.Button2.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Button4
        '
        Me.Button4.Active = false
        Me.Button4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.BorderRadius = 0
        Me.Button4.ButtonText = "     Students"
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.Button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.Button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Button4.DisabledColor = System.Drawing.Color.Gray
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Iconcolor = System.Drawing.Color.Transparent
        Me.Button4.Iconimage = CType(resources.GetObject("Button4.Iconimage"),System.Drawing.Image)
        Me.Button4.Iconimage_right = Nothing
        Me.Button4.Iconimage_right_Selected = Nothing
        Me.Button4.Iconimage_Selected = Nothing
        Me.Button4.IconMarginLeft = 0
        Me.Button4.IconMarginRight = 0
        Me.Button4.IconRightVisible = true
        Me.Button4.IconRightZoom = 0R
        Me.Button4.IconVisible = true
        Me.Button4.IconZoom = 90R
        Me.Button4.IsTab = false
        Me.Button4.Location = New System.Drawing.Point(5, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Button4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.Button4.OnHoverTextColor = System.Drawing.Color.White
        Me.Button4.selected = false
        Me.Button4.Size = New System.Drawing.Size(255, 58)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "     Students"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Textcolor = System.Drawing.Color.White
        Me.Button4.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'btn_start
        '
        Me.btn_start.Active = false
        Me.btn_start.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.btn_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_start.BorderRadius = 0
        Me.btn_start.ButtonText = "     Scheduling"
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.btn_start, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.btn_start, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.btn_start, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btn_start.DisabledColor = System.Drawing.Color.Gray
        Me.btn_start.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_start.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_start.Iconimage = CType(resources.GetObject("btn_start.Iconimage"),System.Drawing.Image)
        Me.btn_start.Iconimage_right = Nothing
        Me.btn_start.Iconimage_right_Selected = Nothing
        Me.btn_start.Iconimage_Selected = Nothing
        Me.btn_start.IconMarginLeft = 0
        Me.btn_start.IconMarginRight = 0
        Me.btn_start.IconRightVisible = true
        Me.btn_start.IconRightZoom = 0R
        Me.btn_start.IconVisible = true
        Me.btn_start.IconZoom = 90R
        Me.btn_start.IsTab = false
        Me.btn_start.Location = New System.Drawing.Point(5, 257)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.btn_start.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.btn_start.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_start.selected = false
        Me.btn_start.Size = New System.Drawing.Size(255, 61)
        Me.btn_start.TabIndex = 10
        Me.btn_start.Text = "     Scheduling"
        Me.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_start.Textcolor = System.Drawing.Color.White
        Me.btn_start.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = false
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(87,Byte),Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "    Live Monitoring"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAnimator.SetDecoration(Me.BunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror)
        Me.PictureAnimator.SetDecoration(Me.BunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"),System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = true
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = true
        Me.BunifuFlatButton1.IconZoom = 90R
        Me.BunifuFlatButton1.IsTab = false
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(5, 205)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36,Byte),Integer), CType(CType(129,Byte),Integer), CType(CType(77,Byte),Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = false
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(255, 52)
        Me.BunifuFlatButton1.TabIndex = 32
        Me.BunifuFlatButton1.Text = "    Live Monitoring"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.Label2)
        Me.MetroPanel4.Controls.Add(Me.BunifuImageButton1)
        Me.MetroPanel4.Controls.Add(Me.Picturebox1)
        Me.MetroPanel4.Controls.Add(Me.ShapeContainer1)
        Me.MetroPanel4.Controls.Add(Me.MetroPanel1)
        Me.PanelAnimator.SetDecoration(Me.MetroPanel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.MetroPanel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.MetroPanel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.MetroPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel4.HorizontalScrollbarBarColor = true
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(5, 0)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(255, 205)
        Me.MetroPanel4.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroPanel4.TabIndex = 9
        Me.MetroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel4.VerticalScrollbarBarColor = true
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'BunifuImageButton1
        '
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"),System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(8, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(46, 45)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 10
        Me.BunifuImageButton1.TabStop = false
        Me.BunifuImageButton1.Zoom = 10
        '
        'Picturebox1
        '
        Me.Picturebox1.AllowFocused = false
        Me.Picturebox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Picturebox1.BorderRadius = 61
        Me.PanelAnimator.SetDecoration(Me.Picturebox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.Picturebox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.Picturebox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Picturebox1.Image = CType(resources.GetObject("Picturebox1.Image"),System.Drawing.Image)
        Me.Picturebox1.IsCircle = true
        Me.Picturebox1.Location = New System.Drawing.Point(62, 53)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(122, 122)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturebox1.TabIndex = 8
        Me.Picturebox1.TabStop = false
        Me.Picturebox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'ShapeContainer1
        '
        Me.PanelAnimator.SetDecoration(Me.ShapeContainer1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.ShapeContainer1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.ShapeContainer1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(255, 203)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = false
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 260
        Me.LineShape1.Y1 = 199
        Me.LineShape1.Y2 = 199
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(177,Byte),Integer), CType(CType(89,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.MetroPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.MetroPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.MetroPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = true
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 203)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(255, 2)
        Me.MetroPanel1.TabIndex = 14
        Me.MetroPanel1.UseCustomBackColor = true
        Me.MetroPanel1.VerticalScrollbarBarColor = true
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.se)
        Me.Panel1.Controls.Add(Me.stt)
        Me.Panel1.Controls.Add(Me.rpt)
        Me.Panel1.Controls.Add(Me.ev)
        Me.Panel1.Controls.Add(Me.stu)
        Me.Panel1.Controls.Add(Me.sc)
        Me.Panel1.Controls.Add(Me.lm)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.PanelAnimator.SetDecoration(Me.Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 893)
        Me.Panel1.TabIndex = 40
        '
        'se
        '
        Me.se.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.se, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.se, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.se, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.se.Dock = System.Windows.Forms.DockStyle.Top
        Me.se.Location = New System.Drawing.Point(0, 550)
        Me.se.Name = "se"
        Me.se.Size = New System.Drawing.Size(5, 52)
        Me.se.TabIndex = 55
        '
        'stt
        '
        Me.stt.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.stt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.stt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.stt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.stt.Dock = System.Windows.Forms.DockStyle.Top
        Me.stt.Location = New System.Drawing.Point(0, 492)
        Me.stt.Name = "stt"
        Me.stt.Size = New System.Drawing.Size(5, 58)
        Me.stt.TabIndex = 54
        '
        'rpt
        '
        Me.rpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.rpt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.rpt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.rpt, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.rpt.Dock = System.Windows.Forms.DockStyle.Top
        Me.rpt.Location = New System.Drawing.Point(0, 434)
        Me.rpt.Name = "rpt"
        Me.rpt.Size = New System.Drawing.Size(5, 58)
        Me.rpt.TabIndex = 53
        '
        'ev
        '
        Me.ev.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.ev, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.ev, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.ev, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ev.Dock = System.Windows.Forms.DockStyle.Top
        Me.ev.Location = New System.Drawing.Point(0, 376)
        Me.ev.Name = "ev"
        Me.ev.Size = New System.Drawing.Size(5, 58)
        Me.ev.TabIndex = 52
        '
        'stu
        '
        Me.stu.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.stu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.stu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.stu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.stu.Dock = System.Windows.Forms.DockStyle.Top
        Me.stu.Location = New System.Drawing.Point(0, 318)
        Me.stu.Name = "stu"
        Me.stu.Size = New System.Drawing.Size(5, 58)
        Me.stu.TabIndex = 51
        '
        'sc
        '
        Me.sc.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.sc, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.sc, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.sc, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.sc.Dock = System.Windows.Forms.DockStyle.Top
        Me.sc.Location = New System.Drawing.Point(0, 257)
        Me.sc.Name = "sc"
        Me.sc.Size = New System.Drawing.Size(5, 61)
        Me.sc.TabIndex = 50
        '
        'lm
        '
        Me.lm.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.PanelAnimator.SetDecoration(Me.lm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.lm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.lm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lm.Dock = System.Windows.Forms.DockStyle.Top
        Me.lm.Location = New System.Drawing.Point(0, 205)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(5, 52)
        Me.lm.TabIndex = 49
        '
        'Panel2
        '
        Me.PanelAnimator.SetDecoration(Me.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PictureAnimator.SetDecoration(Me.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 205)
        Me.Panel2.TabIndex = 48
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide
        Me.PanelAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = true
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"),System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"),System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"),System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"),System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"),System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation1
        '
        'PictureAnimator
        '
        Me.PictureAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic
        Me.PictureAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = true
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"),System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"),System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"),System.Drawing.PointF)
        Animation2.MosaicSize = 20
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"),System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"),System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.PictureAnimator.DefaultAnimation = Animation2
        '
        'LabelAnimator
        '
        Me.LabelAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Particles
        Me.LabelAnimator.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = true
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"),System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"),System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"),System.Drawing.PointF)
        Animation3.MosaicSize = 1
        Animation3.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"),System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"),System.Drawing.PointF)
        Animation3.TimeCoeff = 2!
        Animation3.TransparencyCoeff = 0!
        Me.LabelAnimator.DefaultAnimation = Animation3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1394, 999)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.sidemenu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.PictureAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LabelAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Main Menu"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.sidemenu.ResumeLayout(false)
        Me.MetroPanel4.ResumeLayout(false)
        CType(Me.BunifuImageButton1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Picturebox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddedEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents EventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sidemenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Picturebox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Button4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_start As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Button2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Button3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Button5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents PanelAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents PictureAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents LabelAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents se As Panel
    Friend WithEvents stt As Panel
    Friend WithEvents rpt As Panel
    Friend WithEvents ev As Panel
    Friend WithEvents stu As Panel
    Friend WithEvents sc As Panel
    Friend WithEvents lm As Panel
    Friend WithEvents Panel2 As Panel
End Class
