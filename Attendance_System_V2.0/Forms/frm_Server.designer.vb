<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Server
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Server))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.TextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Button3 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackgroundImage = CType(resources.GetObject("MetroPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(533, 27)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(85, 97)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(29, 130)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(129, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Server Address:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'TextBox3
        '
        Me.TextBox3.Lines = New String() {"MetroTextBox1"}
        Me.TextBox3.Location = New System.Drawing.Point(164, 132)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.Size = New System.Drawing.Size(265, 23)
        Me.TextBox3.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "MetroTextBox1"
        Me.TextBox3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox3.UseSelectable = True
        Me.TextBox3.UseStyleColors = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 25)
        Me.Button2.Style = MetroFramework.MetroColorStyle.Green
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Contact"
        Me.Button2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button2.UseSelectable = True
        Me.Button2.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroTabPage1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.SelectedIndex = 0
        Me.GroupBox1.Size = New System.Drawing.Size(593, 169)
        Me.GroupBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GroupBox1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.Button1)
        Me.MetroTabPage1.Controls.Add(Me.CheckBox1)
        Me.MetroTabPage1.Controls.Add(Me.TextBox2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.TextBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(585, 127)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Database Login Configuration"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 25)
        Me.Button1.Style = MetroFramework.MetroColorStyle.Green
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Test"
        Me.Button1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button1.UseSelectable = True
        Me.Button1.UseStyleColors = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(255, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 15)
        Me.CheckBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Remember Configuration"
        Me.CheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CheckBox1.UseSelectable = True
        Me.CheckBox1.UseStyleColors = True
        '
        'TextBox2
        '
        Me.TextBox2.Lines = New String(-1) {}
        Me.TextBox2.Location = New System.Drawing.Point(255, 41)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(265, 23)
        Me.TextBox2.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox2.UseSelectable = True
        Me.TextBox2.UseStyleColors = True
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(163, 39)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Password:"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseStyleColors = True
        '
        'TextBox1
        '
        Me.TextBox1.Lines = New String(-1) {}
        Me.TextBox1.Location = New System.Drawing.Point(255, 12)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(265, 23)
        Me.TextBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(178, 10)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "User ID:"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(33, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(585, 25)
        Me.Label4.Style = MetroFramework.MetroColorStyle.Lime
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Server Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Label4.UseCustomForeColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(357, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 25)
        Me.Button3.Style = MetroFramework.MetroColorStyle.Green
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "OK"
        Me.Button3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button3.UseSelectable = True
        Me.Button3.UseStyleColors = True
        '
        'frm_Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(645, 425)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Server"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Server Configuration"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GroupBox1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button3 As MetroFramework.Controls.MetroButton
End Class
