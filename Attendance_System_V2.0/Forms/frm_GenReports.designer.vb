<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GenReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GenReports))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Button3 = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.ComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.ComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(20, 175)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1349, 424)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID #"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Last Name"
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "First Name"
        Me.ColumnHeader3.Width = 144
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Course"
        Me.ColumnHeader4.Width = 114
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Total CS"
        Me.ColumnHeader13.Width = 106
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Total CS Fine"
        Me.ColumnHeader14.Width = 123
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton2)
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1349, 115)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton2.Location = New System.Drawing.Point(482, 66)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(343, 31)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 21
        Me.MetroButton2.Text = "Print"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton1.Location = New System.Drawing.Point(831, 28)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(134, 69)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 20
        Me.MetroButton1.Text = "Clear"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(110, 65)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 19
        Me.MetroLabel2.Text = "Course:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.Style = MetroFramework.MetroColorStyle.Green
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "AY / Sem:"
        Me.Label2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Label2.UseStyleColors = True
        '
        'Button3
        '
        Me.Button3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Button3.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.Button3.Location = New System.Drawing.Point(653, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 31)
        Me.Button3.Style = MetroFramework.MetroColorStyle.Green
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Export To Excel"
        Me.Button3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button3.UseSelectable = True
        Me.Button3.UseStyleColors = True
        '
        'Button2
        '
        Me.Button2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Button2.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.Button2.Location = New System.Drawing.Point(482, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 31)
        Me.Button2.Style = MetroFramework.MetroColorStyle.Green
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Display"
        Me.Button2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button2.UseSelectable = True
        Me.Button2.UseStyleColors = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.ItemHeight = 23
        Me.ComboBox3.Location = New System.Drawing.Point(169, 68)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(307, 29)
        Me.ComboBox3.Style = MetroFramework.MetroColorStyle.Green
        Me.ComboBox3.TabIndex = 15
        Me.ComboBox3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ComboBox3.UseSelectable = True
        Me.ComboBox3.UseStyleColors = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 23
        Me.ComboBox2.Location = New System.Drawing.Point(169, 33)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(307, 29)
        Me.ComboBox2.Style = MetroFramework.MetroColorStyle.Green
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ComboBox2.UseSelectable = True
        Me.ComboBox2.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label9)
        Me.MetroPanel1.Controls.Add(Me.Label7)
        Me.MetroPanel1.Controls.Add(Me.Label6)
        Me.MetroPanel1.Controls.Add(Me.Label5)
        Me.MetroPanel1.Controls.Add(Me.Label4)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 599)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1349, 26)
        Me.MetroPanel1.TabIndex = 20
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label9.Location = New System.Drawing.Point(354, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "MetroLabel3"
        Me.Label9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label7.Location = New System.Drawing.Point(260, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "MetroLabel3"
        Me.Label7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(177, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "MetroLabel3"
        Me.Label6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label5.Location = New System.Drawing.Point(83, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "MetroLabel3"
        Me.Label5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MetroLabel3"
        Me.Label4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackgroundImage = CType(resources.GetObject("MetroPanel2.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(206, 15)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(44, 39)
        Me.MetroPanel2.TabIndex = 21
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'frm_GenReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 645)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_GenReports"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Generate Reports"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button3 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
