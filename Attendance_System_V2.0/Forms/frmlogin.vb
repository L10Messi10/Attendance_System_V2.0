Public Class frmlogin
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(60, 100, 100, 100)
        'Panel3.BackColor = Color.FromArgb(90, 100, 100, 100)
        NotifyIcon1.Visible = True
        username.Text = ""
        password.Text = ""
        username.Select()

    End Sub
    Sub logconnect()
        connect()
        'replaced
        strsql = "select * from dbo.login where username='" & username.Text & "' AND password='" & password.Text & "'"
        sqladapter.SelectCommand = sqlcmd
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read = True Then
            sys_user = username.Text
            sys_desig = sqlreader("designation")
            MetroFramework.MetroMessageBox.Show(Me, "Access Granted!", "EAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox("Acces Granted", MsgBoxStyle.Information, "Login Successfull")

            Me.Hide()
            username.Text = ""
            password.Text = ""
            'add_stud.Show()
            '  frmMain.ToolStripStatusLabel6.Text = sqlreader("full_name") + " , " + sqlreader("Designation")
            frmMain.ShowDialog()
        Else
            MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Login Failed")
        End If
        sqlcon.Close()
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            logconnect()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        logconnect()
    End Sub

    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'NotifyIcon1.Visible = False
        'End
    End Sub

    Private Sub frmlogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            NotifyIcon1.BalloonTipText = "EAS is minimized, Double click the icon to Activate!"
            NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        ' NotifyIcon1.Visible = False
    End Sub

    Private Sub frmlogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        username.Select()
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MsgBox("Are you sure to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Password_Click(sender As Object, e As EventArgs) Handles password.Click

    End Sub
End Class