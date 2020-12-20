Imports System.Data.SqlClient
Public Class startsat
    Public vt As Integer
    Dim sid As String
    Public mor, after, evening As String
    Dim crs, sy_sem_term As String
    Public hr As String
    Public min As String
    Public strArr() As String
    Dim inout As String
    Dim theDate As DateTime = System.DateTime.Now
    Dim expanded As Boolean
    Public XtoBeExempted As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("This Action will clear the settings you've just made" & vbCrLf & vbCrLf & "Do you want to Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Clear Settings") = MsgBoxResult.Yes Then
            Call Filcomboboxes()
            vt = 0
            sid = ""
            mor = ""
            after = ""
            evening = ""
            crs = ""
            sy_sem_term = ""
            ComboBox1.Items.Clear()
            'ComboBox2.Items.Clear()

            Button4.Visible = False
            Label7.Visible = False
            GroupBox2.Enabled = False
            Button5.Enabled = False
            GroupBox1.Enabled = True
        End If

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And e.KeyChar <> ":" Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Then
            MsgBox("Please Select an Event before starting the Attendance!", MsgBoxStyle.Exclamation, "No Event")

        Else


            connect()
            'replaced
            strsql = "Select * from atndance where evnt_code='" & vt & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqladapter.SelectCommand = sqlcmd
            sqlreader = sqlcmd.ExecuteReader
            If sqlreader.Read = True Then
                MsgBox("This Event is already added Please Check again!", MsgBoxStyle.Critical, "Event Already Added")
                'Call Filcomboboxes()
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Exit Sub
            End If


        End If
        If ComboBox1.Text <> "" Then

            'check if there are participants
            connect()
                'replaced
                strsql = "Select * from tblparticipants where evnt_code='" & vt & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqladapter.SelectCommand = sqlcmd
                sqlreader = sqlcmd.ExecuteReader
            If sqlreader.Read = False Then
                MsgBox("No Participants in this Event, Please Select a Participants for this Event!", MsgBoxStyle.Critical, "No Participants")
                cs_option.Label3.Text = "Select a Course To Participate on the Event " & ComboBox1.Text
                cs_option.ShowDialog()
            Else
                If MsgBox("Are You Sure To Add This Event?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Add Event") = MsgBoxResult.Yes Then
                    Call Addstudents()
                End If
            End If
                sqlcmd.Dispose()
                sqlreader.Close()
            sqlcon.Close()
        End If

    End Sub
    Sub Addstudents()
        Me.Cursor = Cursors.WaitCursor

        connect()
        'replaced
        strsql = "Select * from Viewparticipants where evnt_code='" & vt & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        Do While sqlreader.Read
            Dim sqlreader2 As SqlDataReader
            Dim sqlcmd3 As New SqlCommand
            crs = sqlreader("course_desc")
            strsql = "select * from student_view where course_desc='" & crs & "' and stud_status ='" & "active" & "'"
            sqlcmd3.CommandText = strsql
            sqlcmd3.Connection = sqlcon
            sqlreader2 = sqlcmd3.ExecuteReader
            Do While sqlreader2.Read
                sid = sqlreader2("stud_id")
                Call Savestuds()
            Loop
            sqlcmd.Dispose()
            sqlreader2.Close()
            sqlcmd3.Dispose()
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        Me.Cursor = Cursors.Default



        '********Add to Session Status**********

        If mor = 1 And after = 1 And evening = 1 Then
            '*****all session selected
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()
        ElseIf mor = 1 And after = 0 And evening = 0 Then
            '****morning session only

            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()

        ElseIf mor = 0 And after = 1 And evening = 0 Then
            '****afternoon session only
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()

        ElseIf mor = 0 And after = 0 And evening = 1 Then
            '****evening session only
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()

        ElseIf mor = 1 And after = 1 And evening = 0 Then
            '****morning And Afternoon session only
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()
        ElseIf mor = 0 And after = 1 And evening = 1 Then
            '****Evening And Afternoon session only
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()

        ElseIf mor = 1 And after = 0 And evening = 1 Then
            '****Evening And morning session only
            connect()
            'replaced
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into tblSessionstatus (evnt_code,morinstat,moroutstat,afterinstat,afteroutstat,eveinstat,eveoutstat,DOTE) values ('" _
                 & vt & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & 1 & "','" _
                 & 1 & "','" _
                 & 0 & "','" _
                 & 0 & "','" _
                 & DateTimePicker1.Value & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sqlcon.Close()
        End If

        MsgBox("Attendance Added!", MsgBoxStyle.Information, "Success")
        frm_ScheduledEvents.loadsched()


        'Me.Dispose()
        '****************************TIME CONFIGURATION*********************88
        'strArr = DateTimePicker1.Text.Split(":")
        'hr = (strArr(0) * 60) * 60
        'min = (strArr(1) * 60)
        'startsatb.ctrhr = hr
        'startsatb.ctrmin = min
        'startsatb.lbl_timer.Text = hr + min
        'startsatb.lbl_etitle.Text = ComboBox1.Text.ToUpper
        'startsatb.lbl_timeinout.Text = ComboBox2.Text.ToUpper + " " + inout.ToUpper
        'startsatb.lbl_ecode.Text = vt
        'startsatb.Show()
        'Me.Close()
        'startsatb.Timer1.Start()
    End Sub

    Sub PartStuds()
        Call connect()
        strsql = "Select * from attendance_view where evnt_code ='" & vt & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read
            With ListView1.Items.Add(sqlreader("stud_id"), 0)
                .SubItems.Add(sqlreader("fname"))
                .SubItems.Add(sqlreader("lname"))
                .SubItems.Add(sqlreader("course_desc"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        XtoBeExempted = ""
        ToolStripTextBox1.Text = ""
        Label12.Text = "Total Participants for this event: " & ListView1.Items.Count
    End Sub


    Sub Savestuds()
        '*************for morning afternoon and evening decision

        'retrieve cs / Session on each course selected
        Dim cs_per_session As String
        Dim sqlreader3 As SqlDataReader
        Dim sqlcmd4 As New SqlCommand
        strsql = "Select * from course where course_desc='" & crs & "'"
        sqlcmd4.CommandText = strsql
        sqlcmd4.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd4
        sqlreader3 = sqlcmd4.ExecuteReader
        If sqlreader3.Read = True Then
            cs_per_session = sqlreader3("cs_per_session")

        End If

        sqlcmd4.Dispose()
        sqlreader3.Close()

        If mor = 1 And after = 1 And evening = 1 Then
            '*****all session selected
            cs_per_session = cs_per_session * 6
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""

        ElseIf mor = 1 And after = 0 And evening = 0 Then
            '****morning session only
            cs_per_session = cs_per_session * 2
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""

        ElseIf mor = 0 And after = 1 And evening = 0 Then
            '****afternoon session only
            cs_per_session = cs_per_session * 2
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""

        ElseIf mor = 0 And after = 0 And evening = 1 Then
            '****evening session only
            cs_per_session = cs_per_session * 2
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""

        ElseIf mor = 1 And after = 1 And evening = 0 Then
            '****morning And Afternoon session only
            cs_per_session = cs_per_session * 4
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""
        ElseIf mor = 0 And after = 1 And evening = 1 Then
            '****Evening And Afternoon session only
            cs_per_session = cs_per_session * 4
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""

        ElseIf mor = 1 And after = 0 And evening = 1 Then
            '****Evening And morning session only
            cs_per_session = cs_per_session * 4
            Dim sqlcmd2 As New SqlCommand
            strsql = "insert into atndance (evnt_code,stud_id,attendance_date,morningin,morningout,afternoonin,afternoonout,eveningin,eveningout,sy_sem_term,attendance_ttl_cs) values ('" _
                 & vt & "','" _
                 & sid & "','" _
                 & DateTimePicker1.Value & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & "No Session" & "','" _
                 & "No Session" & "','" _
                 & "Not Attended" & "','" _
                 & "Not Attended" & "','" _
                 & sy_sem_term & "','" _
                 & cs_per_session & "')"
            sqlcmd2.CommandText = strsql
            sqlcmd2.Connection = sqlcon
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Dispose()
            sid = ""
            cs_per_session = ""
        End If
    End Sub
    Dim csnull As Integer = 0
    Sub Filcomboboxes()
        ComboBox3.Items.Clear()

        For i As Integer = 0 To 1
            ComboBox3.Items.Add(Date.Now.Year + i)
        Next

        ComboBox4.Items.Clear()
        With ComboBox4.Items
            .Add("First Semester")
            .Add("Second Semester")
            .Add("Summer")
        End With

        TextBox2.Text = ""
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  Label1.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        loadevnt()
        If ComboBox1.Text = "" Then
            Label7.Visible = False
            Button4.Visible = False
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'cs_option.Text = "Select a Course To Participate on the Event " & ComboBox1.Text
        cs_option.Label3.Text = "Select a Course To Participate on the Event " & ComboBox1.Text
        cs_option.ShowDialog()
    End Sub



    Private Sub ComboBox3_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox3.DropDownClosed
        If ComboBox3.Text <> "" Then
            TextBox2.Text = Val(ComboBox3.Text) + 1
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyUp
        If ComboBox3.Text <> "" Then
            TextBox2.Text = Val(ComboBox3.Text) + 1
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        If ComboBox3.Text <> "" Then
            TextBox2.Text = Val(ComboBox3.Text) + 1
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub startsat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Xcheck4Students()
        Call Filcomboboxes()
        DateTimePicker1.Value = Now
        expanded = False
        Width = 585
    End Sub

    Sub Xcheck4Students()
        connect()
        'replaced
        strsql = "Select * from student where stud_status = '" & "Active" & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read = False Then
            MsgBox("There are No Current Active Student(s) Registered or No Registered Student Detected!", MsgBoxStyle.Critical, "No Student Found!")
            Me.Dispose()
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox1.DropDownClosed
        'Try
        If ComboBox1.Text = "" Then
                Label7.Visible = False
                Button4.Visible = False
            Else
                Label7.Visible = True
                Button4.Visible = True
                'chkses.Clear()
                sqlcon.Close()
                connect()
                'replaced
                strsql = "select * from evnt where evnt_desc='" & ComboBox1.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqladapter.SelectCommand = sqlcmd
                sqlreader = sqlcmd.ExecuteReader
                sqlreader.Read()
                vt = sqlreader("evnt_code")
            'Dim txtstring As String = sqlreader("evnt_session")
            'Dim TestArray() As String = Split(txtstring)
            ' Dim LastNonEmpty As Integer = -1
            '**********************
            mor = sqlreader("mortrue")
            after = sqlreader("aftertrue")
            evening = sqlreader("evetrue")
            'ComboBox2.Items.Clear()

            '    For i As Integer = 0 To TestArray.Length - 1
            '        If TestArray(i) <> "" Then
            '            LastNonEmpty += 1
            '            TestArray(LastNonEmpty) = TestArray(i)

            '            With ComboBox2.Items.Add(TestArray(LastNonEmpty))

            '            End With


            '        End If
            '    Next

            sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()

            End If

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Enabled = False
        GroupBox1.Enabled = True
        Button5.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If vt = Nothing Then Exit Sub
        If expanded = True Then
            Width = 585
            expanded = False
        Else
            Width = 1279
            expanded = True
        End If
        Call PartStuds()
        Call Exempted_Studs()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dispose()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        XtoBeExempted = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox3.Text <> "" And ComboBox4.Text <> "" Then
            If MsgBox("SY / Sem. / Term Settings Summary:" & vbCrLf & vbCrLf & "School Year: " & ComboBox3.Text & "-" & TextBox2.Text & vbCrLf & "Semester: " & ComboBox4.Text & vbCrLf & "Do you want to Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Check Settings") = MsgBoxResult.Yes Then

                sy_sem_term = ComboBox3.Text & "-" + TextBox2.Text & " - " + ComboBox4.Text
                Button5.Enabled = True
                GroupBox1.Enabled = False
                GroupBox2.Enabled = True
            End If

        Else
            MsgBox("Please Fill Completely this Settings!", MsgBoxStyle.Exclamation, GroupBox1.Text)
        End If
    End Sub

    Sub loadevnt()
        connect()
        'replaced
        strsql = "Select * from evnt where evnt_stat <> '" & 1 & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While sqlreader.Read = True
            With ComboBox1.Items.Add(sqlreader("evnt_desc"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If XtoBeExempted <> "" Then
            MsgBox("Warning: Adding a Student to Exempted list cannot be undone!", MsgBoxStyle.Exclamation, "Add to Exempted Students")
            If MsgBox("Are you sure to Add " & ListView1.SelectedItems(0).SubItems(2).Text & " to Exempted list for this event??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Add to Exempted Students") = MsgBoxResult.Yes Then
                connect()
                'replaced
                strsql = "update atndance set morningin='" & "Exempted" &
                      "',morningout = '" & "Exempted" &
                     "',afternoonin = '" & "Exempted" &
                       "',afternoonout = '" & "Exempted" &
                      "',eveningin = '" & "Exempted" &
                       "',eveningout = '" & "Exempted" &
                       "', attendance_ttl_cs='" & "0" &
                      "'" & "where stud_id='" & XtoBeExempted & "' and evnt_code ='" & vt & "'"

                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                Call Exempted_Studs()
                XtoBeExempted = ""
            Else
                MsgBox("Action Cancelled, " & ListView1.SelectedItems(0).SubItems(2).Text & " has not been added to Exempted Student List!", MsgBoxStyle.Information, "Action Cancelled")
            End If
        Else
            MsgBox("Please Select a Student on The List of Participating Student(s)!!", MsgBoxStyle.Exclamation, "Add to Exempted List")
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Sub Exempted_Studs()
        Call connect()
        strsql = "Select * from attendance_view where evnt_code ='" & vt & "' and morningin='" & "Exempted" & "' "
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView2.Items.Clear()

        Do While sqlreader.Read
            With ListView2.Items.Add(sqlreader("stud_id"), 0)
                .SubItems.Add(sqlreader("fname"))
                .SubItems.Add(sqlreader("lname"))
                .SubItems.Add(sqlreader("course_desc"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        XtoBeExempted = ""
        Label13.Text = "Total Exempted Participants for this event: " & ListView2.Items.Count
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call PartStuds()
        Call Exempted_Studs()
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        On Error Resume Next
        XtoBeExempted = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        On Error Resume Next
        XtoBeExempted = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Try
            Call connect()
            strsql = "Select * from attendance_view where evnt_code ='" & vt & "' AND stud_id+fname+lname+course_desc like '%" & ToolStripTextBox1.Text & "%'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqladapter.SelectCommand = sqlcmd
            sqlreader = sqlcmd.ExecuteReader
            ListView1.Items.Clear()

            Do While sqlreader.Read
                With ListView1.Items.Add(sqlreader("stud_id"), 0)
                    .SubItems.Add(sqlreader("fname"))
                    .SubItems.Add(sqlreader("lname"))
                    .SubItems.Add(sqlreader("course_desc"))
                End With
            Loop
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            XtoBeExempted = ""
            Label12.Text = "Total Participants for this event: " & ListView1.Items.Count
        Catch ex As Exception
            XtoBeExempted = ""
            ListView1.Items.Clear()
            Exit Sub
        End Try
    End Sub
End Class