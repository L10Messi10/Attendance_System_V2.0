<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EventsAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EventsAdd))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroCheckBox4 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox3 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox2 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(48, 101)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(108, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Event Name:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'TextBox1
        '
        Me.TextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.TextBox1.Lines = New String(-1) {}
        Me.TextBox1.Location = New System.Drawing.Point(162, 101)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(327, 74)
        Me.TextBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.UseStyleColors = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.MetroTabControl1.Location = New System.Drawing.Point(162, 184)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(326, 137)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroCheckBox4)
        Me.MetroTabPage1.Controls.Add(Me.CheckBox3)
        Me.MetroTabPage1.Controls.Add(Me.CheckBox2)
        Me.MetroTabPage1.Controls.Add(Me.CheckBox1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(318, 95)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Session Selection"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroCheckBox4
        '
        Me.MetroCheckBox4.AutoSize = True
        Me.MetroCheckBox4.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox4.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.MetroCheckBox4.Location = New System.Drawing.Point(216, 66)
        Me.MetroCheckBox4.Name = "MetroCheckBox4"
        Me.MetroCheckBox4.Size = New System.Drawing.Size(96, 25)
        Me.MetroCheckBox4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroCheckBox4.TabIndex = 5
        Me.MetroCheckBox4.Text = "Select All"
        Me.MetroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroCheckBox4.UseSelectable = True
        Me.MetroCheckBox4.UseStyleColors = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.CheckBox3.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.CheckBox3.Location = New System.Drawing.Point(62, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(88, 25)
        Me.CheckBox3.Style = MetroFramework.MetroColorStyle.Green
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Evening"
        Me.CheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckBox3.UseSelectable = True
        Me.CheckBox3.UseStyleColors = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.CheckBox2.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.CheckBox2.Location = New System.Drawing.Point(62, 41)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 25)
        Me.CheckBox2.Style = MetroFramework.MetroColorStyle.Green
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Afternoon"
        Me.CheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckBox2.UseSelectable = True
        Me.CheckBox2.UseStyleColors = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.CheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.CheckBox1.Location = New System.Drawing.Point(62, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 25)
        Me.CheckBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Morning"
        Me.CheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckBox1.UseSelectable = True
        Me.CheckBox1.UseStyleColors = True
        '
        'Button2
        '
        Me.Button2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Button2.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.Button2.Location = New System.Drawing.Point(338, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 47)
        Me.Button2.Style = MetroFramework.MetroColorStyle.Green
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Cancel"
        Me.Button2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button2.UseSelectable = True
        Me.Button2.UseStyleColors = True
        '
        'Button1
        '
        Me.Button1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Button1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.Button1.Location = New System.Drawing.Point(181, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 47)
        Me.Button1.Style = MetroFramework.MetroColorStyle.Green
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Save"
        Me.Button1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button1.UseSelectable = True
        Me.Button1.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackgroundImage = CType(resources.GetObject("MetroPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(137, 9)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(41, 49)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'frm_EventsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(524, 454)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_EventsAdd"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "New Event"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents CheckBox3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
End Class
