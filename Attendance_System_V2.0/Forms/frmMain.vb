Imports System.Windows.Forms

Public Class frmMain
    ReadOnly dt As Date = DateTime.Now
    Private m_ChildFormNumber As Integer
    Dim theDate As DateTime = System.DateTime.Now
    Private Sub AddedEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddedEventsToolStripMenuItem.Click
        LoadChildform(frm_ScheduledEvents, Me)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChildform(frm_ScheduledEvents, Me)
        Timer1.Start()
        Call Show_user()
        Call XcheckEvents()
    End Sub

    Sub Show_user()
        On Error Resume Next
        connect()
        'replaced
        strsql = "select * from login where username='" & sys_user & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader

        If sqlreader.Read Then
            Label2.Text = "Welcome, " & sys_user & "!"
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        connect()
        Dim table As New DataTable
        sqladapter.Fill(table)
        sys_user = table.Rows(0)(5).ToString()
        Dim img() As Byte
        img = table.Rows(0)(7)
        Dim ms As New System.IO.MemoryStream(img)
        Picturebox1.Image = Image.FromStream(ms)
        sqlcon.Close()
        If sys_desig <> "System Administrator" Then

            frm_Students.ToolStripButton2.Enabled = False
            'frm_Students.ToolStripButton1.Enabled = False
            frm_Students.ToolStripButton4.Enabled = False
            Label2.Text = "Welcome, " & sys_user & "!"
            Label2.Enabled = False
            btn_start.Enabled = False
            SettingsToolStripMenuItem.Enabled = False
            CourseToolStripMenuItem.Enabled = False
            EventToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            'Button4.Enabled = False
        End If

    End Sub

    Sub XcheckEvents()
        'show unscheduled events
        connect()
        'replaced
        strsql = "Select * from evnt where evnt_stat = '" & 0 & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        Do While sqlreader.Read
            With ListView1.Items.Add(sqlreader("evnt_code"), 0)
                .SubItems.Add(sqlreader("evnt_desc"))
                .SubItems.Add(sqlreader("evnt_session"))
            End With

            Label3.Visible = False
        Loop
        If ListView1.Items.Count <> 0 Then
            ListView1.Visible = True
            Label3.Visible = False
        Else
            ListView1.Visible = False
            Label3.Visible = True
            Label3.Text = "No Events Added!"
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        '***************************
        connect()
        'replaced
        strsql = "Select * from evnt where evnt_stat = '" & 0 & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read Then
            Label3.Visible = False
        Else
            Label3.Visible = True
        End If


        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub StudentRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRecordToolStripMenuItem.Click
        LoadChildform(frm_Students, Me)
    End Sub

    Private Sub EventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventToolStripMenuItem.Click
        frm_Events.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        LoadChildform(frm_GenReports, Me)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = theDate.ToString("MMMM dd,yyyy")
        ToolStripStatusLabel4.Text = TimeOfDay
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        frmlogin.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_Settings.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
        frmlogin.Show()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            Dispose()
            frmlogin.Show()

        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(0, 177, 89)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(17, 17, 17)
        If ListView1.Items.Count <> 0 Then
            startsat.ShowDialog()
        Else
            MsgBox("No Added Events!", MsgBoxStyle.Exclamation, "No Events")
            If MsgBox("Do you want to Open Events?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Open Events Forn") = MsgBoxResult.Yes Then
                frm_Events.ShowDialog()
            End If
        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(0, 177, 89)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(17, 17, 17)
        LoadChildform(frm_Students, Me)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(0, 177, 89)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(17, 17, 17)
        frm_Events.ShowDialog()

    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(0, 177, 89)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(17, 17, 17)
        LoadChildform(frm_GenReports, Me)

    End Sub

    Private Sub BunifuFlatButton1_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(0, 177, 89)
        se.BackColor = Color.FromArgb(17, 17, 17)
        frm_Settings.ShowDialog()

    End Sub

    Private Sub BunifuFlatButton1_Click_3(sender As Object, e As EventArgs) Handles Button5.Click
        lm.BackColor = Color.FromArgb(17, 17, 17)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(0, 177, 89)
        LoadChildform(frm_ScheduledEvents, Me)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If sidemenu.Width = 60 Then
            sidemenu.Visible = False
            sidemenu.Width = 260
            Label2.Visible = True

            PanelAnimator.ShowSync(sidemenu)
            PictureAnimator.ShowSync(Picturebox1)
            LabelAnimator.ShowSync(Label2)
            If ListView1.Items.Count <> 0 Then
                ListView1.Visible = True
                Label3.Visible = False
            Else
                ListView1.Visible = False
                Label3.Visible = True
                Label3.Text = "No Events Added!"
            End If
        Else
            PictureAnimator.Hide(Picturebox1)
            LabelAnimator.ShowSync(Label2)
            Label2.Visible = False

            sidemenu.Visible = False
            sidemenu.Width = 60
            PanelAnimator.ShowSync(sidemenu)
            If ListView1.Items.Count <> 0 Then
                ListView1.Visible = True
                Label3.Visible = False
            Else
                ListView1.Visible = False

                Label3.Text = "No Events Added!"
            End If
            Label3.Visible = False
        End If
    End Sub

    Private Sub Picturebox1_Click_1(sender As Object, e As EventArgs) Handles Picturebox1.Click
        frmSystem_User.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmSystem_User.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton1_Click_4(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        LoadChildform(frm_LiveMonitor, Me)
        lm.BackColor = Color.FromArgb(0, 177, 89)
        sc.BackColor = Color.FromArgb(17, 17, 17)
        stu.BackColor = Color.FromArgb(17, 17, 17)
        ev.BackColor = Color.FromArgb(17, 17, 17)
        rpt.BackColor = Color.FromArgb(17, 17, 17)
        stt.BackColor = Color.FromArgb(17, 17, 17)
        se.BackColor = Color.FromArgb(17, 17, 17)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
