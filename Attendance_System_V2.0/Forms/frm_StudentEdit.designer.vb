﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StudentEdit
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_StudentEdit))
        Me.coursecode = New System.Windows.Forms.Label()
        Me.yrcode = New System.Windows.Forms.Label()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.yr = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.course = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mi = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.fname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lname = New MetroFramework.Controls.MetroTextBox()
        Me.studid = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.btn_browse = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.oldstud = New System.Windows.Forms.Label()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.stdstatus = New MetroFramework.Controls.MetroComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'coursecode
        '
        Me.coursecode.AutoSize = True
        Me.coursecode.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.coursecode.Location = New System.Drawing.Point(452, 481)
        Me.coursecode.Name = "coursecode"
        Me.coursecode.Size = New System.Drawing.Size(65, 15)
        Me.coursecode.TabIndex = 67
        Me.coursecode.Text = "Year:"
        Me.coursecode.Visible = False
        '
        'yrcode
        '
        Me.yrcode.AutoSize = True
        Me.yrcode.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.yrcode.Location = New System.Drawing.Point(452, 514)
        Me.yrcode.Name = "yrcode"
        Me.yrcode.Size = New System.Drawing.Size(65, 15)
        Me.yrcode.TabIndex = 66
        Me.yrcode.Text = "Year:"
        Me.yrcode.Visible = False
        '
        'MetroButton4
        '
        Me.MetroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton4.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton4.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton4.Location = New System.Drawing.Point(467, 577)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(159, 43)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton4.TabIndex = 55
        Me.MetroButton4.Text = "&Cancel"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Button2.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.Button2.Location = New System.Drawing.Point(236, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 43)
        Me.Button2.Style = MetroFramework.MetroColorStyle.Green
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "&Save"
        Me.Button2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button2.UseSelectable = True
        Me.Button2.UseStyleColors = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(79, 506)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(49, 25)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel14.TabIndex = 65
        Me.MetroLabel14.Text = "Year:"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel14.UseStyleColors = True
        '
        'yr
        '
        Me.yr.FormattingEnabled = True
        Me.yr.ItemHeight = 23
        Me.yr.Location = New System.Drawing.Point(134, 506)
        Me.yr.Name = "yr"
        Me.yr.Size = New System.Drawing.Size(260, 29)
        Me.yr.Style = MetroFramework.MetroColorStyle.Green
        Me.yr.TabIndex = 52
        Me.yr.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yr.UseSelectable = True
        Me.yr.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(59, 471)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel13.TabIndex = 64
        Me.MetroLabel13.Text = "Course:"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel13.UseStyleColors = True
        '
        'course
        '
        Me.course.FormattingEnabled = True
        Me.course.ItemHeight = 23
        Me.course.Location = New System.Drawing.Point(134, 471)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(260, 29)
        Me.course.Style = MetroFramework.MetroColorStyle.Green
        Me.course.TabIndex = 51
        Me.course.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.course.UseSelectable = True
        Me.course.UseStyleColors = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.ForeColor = System.Drawing.SystemColors.Control
        Me.MetroLabel12.Location = New System.Drawing.Point(21, 449)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(605, 19)
        Me.MetroLabel12.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel12.TabIndex = 63
        Me.MetroLabel12.Text = "Course And Year"
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(38, 421)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 62
        Me.MetroLabel10.Text = "Contact #:"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseStyleColors = True
        '
        'TextBox5
        '
        Me.TextBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextBox5.Lines = New String(-1) {}
        Me.TextBox5.Location = New System.Drawing.Point(134, 423)
        Me.TextBox5.MaxLength = 32767
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.Size = New System.Drawing.Size(383, 23)
        Me.TextBox5.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox5.TabIndex = 49
        Me.TextBox5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox5.UseSelectable = True
        Me.TextBox5.UseStyleColors = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(52, 351)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel11.TabIndex = 61
        Me.MetroLabel11.Text = "Address:"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel11.UseStyleColors = True
        '
        'TextBox4
        '
        Me.TextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextBox4.Lines = New String(-1) {}
        Me.TextBox4.Location = New System.Drawing.Point(134, 353)
        Me.TextBox4.MaxLength = 32767
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.Size = New System.Drawing.Size(383, 64)
        Me.TextBox4.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox4.TabIndex = 47
        Me.TextBox4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox4.UseSelectable = True
        Me.TextBox4.UseStyleColors = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(35, 324)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 25)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel9.TabIndex = 60
        Me.MetroLabel9.Text = "Full Name:"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseStyleColors = True
        '
        'TextBox3
        '
        Me.TextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextBox3.Lines = New String(-1) {}
        Me.TextBox3.Location = New System.Drawing.Point(134, 324)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.Size = New System.Drawing.Size(383, 23)
        Me.TextBox3.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox3.TabIndex = 45
        Me.TextBox3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox3.UseSelectable = True
        Me.TextBox3.UseStyleColors = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.ForeColor = System.Drawing.SystemColors.Control
        Me.MetroLabel8.Location = New System.Drawing.Point(21, 302)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(605, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel8.TabIndex = 59
        Me.MetroLabel8.Text = "Person to be Contacted in Case of Emergency"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(38, 274)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 57
        Me.MetroLabel7.Text = "Contact #:"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseStyleColors = True
        '
        'TextBox2
        '
        Me.TextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextBox2.Lines = New String(-1) {}
        Me.TextBox2.Location = New System.Drawing.Point(134, 276)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(383, 23)
        Me.TextBox2.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox2.TabIndex = 41
        Me.TextBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox2.UseSelectable = True
        Me.TextBox2.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(52, 204)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 56
        Me.MetroLabel6.Text = "Address:"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseStyleColors = True
        '
        'TextBox1
        '
        Me.TextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextBox1.Lines = New String(-1) {}
        Me.TextBox1.Location = New System.Drawing.Point(134, 206)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(383, 64)
        Me.TextBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox1.TabIndex = 40
        Me.TextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(37, 175)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(91, 25)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 54
        Me.MetroLabel5.Text = "Middle In.:"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseStyleColors = True
        '
        'mi
        '
        Me.mi.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mi.Lines = New String(-1) {}
        Me.mi.Location = New System.Drawing.Point(134, 177)
        Me.mi.MaxLength = 32767
        Me.mi.Name = "mi"
        Me.mi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mi.SelectedText = ""
        Me.mi.Size = New System.Drawing.Size(260, 23)
        Me.mi.Style = MetroFramework.MetroColorStyle.Green
        Me.mi.TabIndex = 39
        Me.mi.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mi.UseSelectable = True
        Me.mi.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(31, 146)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 50
        Me.MetroLabel4.Text = "First Name:"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseStyleColors = True
        '
        'fname
        '
        Me.fname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.fname.Lines = New String(-1) {}
        Me.fname.Location = New System.Drawing.Point(134, 148)
        Me.fname.MaxLength = 32767
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fname.SelectedText = ""
        Me.fname.Size = New System.Drawing.Size(260, 23)
        Me.fname.Style = MetroFramework.MetroColorStyle.Green
        Me.fname.TabIndex = 38
        Me.fname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.fname.UseSelectable = True
        Me.fname.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.MetroLabel3.Location = New System.Drawing.Point(21, 97)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(373, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel3.TabIndex = 48
        Me.MetroLabel3.Text = "Personal Information"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 117)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(96, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 46
        Me.MetroLabel2.Text = "Last Name:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(80, 61)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(48, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 44
        Me.MetroLabel1.Text = "ID #:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'lname
        '
        Me.lname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.lname.Lines = New String(-1) {}
        Me.lname.Location = New System.Drawing.Point(134, 119)
        Me.lname.MaxLength = 32767
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lname.SelectedText = ""
        Me.lname.Size = New System.Drawing.Size(260, 23)
        Me.lname.Style = MetroFramework.MetroColorStyle.Green
        Me.lname.TabIndex = 37
        Me.lname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lname.UseSelectable = True
        Me.lname.UseStyleColors = True
        '
        'studid
        '
        Me.studid.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.studid.Lines = New String(-1) {}
        Me.studid.Location = New System.Drawing.Point(134, 63)
        Me.studid.MaxLength = 32767
        Me.studid.Name = "studid"
        Me.studid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.studid.SelectedText = ""
        Me.studid.Size = New System.Drawing.Size(260, 23)
        Me.studid.Style = MetroFramework.MetroColorStyle.Orange
        Me.studid.TabIndex = 36
        Me.studid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.studid.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.studid.UseSelectable = True
        Me.studid.UseStyleColors = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(597, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 31)
        Me.Button1.Style = MetroFramework.MetroColorStyle.Lime
        Me.Button1.TabIndex = 43
        Me.Button1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button1.UseSelectable = True
        '
        'btn_browse
        '
        Me.btn_browse.BackgroundImage = CType(resources.GetObject("btn_browse.BackgroundImage"), System.Drawing.Image)
        Me.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_browse.Location = New System.Drawing.Point(562, 169)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(29, 31)
        Me.btn_browse.Style = MetroFramework.MetroColorStyle.Lime
        Me.btn_browse.TabIndex = 42
        Me.btn_browse.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_browse.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(400, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'oldstud
        '
        Me.oldstud.AutoSize = True
        Me.oldstud.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.oldstud.Location = New System.Drawing.Point(545, 514)
        Me.oldstud.Name = "oldstud"
        Me.oldstud.Size = New System.Drawing.Size(65, 15)
        Me.oldstud.TabIndex = 68
        Me.oldstud.Text = "Year:"
        Me.oldstud.Visible = False
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.Location = New System.Drawing.Point(67, 541)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(61, 25)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel15.TabIndex = 70
        Me.MetroLabel15.Text = "Status:"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel15.UseStyleColors = True
        '
        'stdstatus
        '
        Me.stdstatus.FormattingEnabled = True
        Me.stdstatus.ItemHeight = 23
        Me.stdstatus.Location = New System.Drawing.Point(134, 541)
        Me.stdstatus.Name = "stdstatus"
        Me.stdstatus.Size = New System.Drawing.Size(260, 29)
        Me.stdstatus.Style = MetroFramework.MetroColorStyle.Green
        Me.stdstatus.TabIndex = 69
        Me.stdstatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.stdstatus.UseSelectable = True
        Me.stdstatus.UseStyleColors = True
        '
        'frm_StudentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 639)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.stdstatus)
        Me.Controls.Add(Me.oldstud)
        Me.Controls.Add(Me.coursecode)
        Me.Controls.Add(Me.yrcode)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.yr)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.mi)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.studid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_StudentEdit"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Modify Student"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coursecode As Label
    Friend WithEvents yrcode As Label
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents yr As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents course As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_browse As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents studid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents oldstud As Label
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents stdstatus As MetroFramework.Controls.MetroComboBox
End Class
