Public Class frmstartmonitoring
    Dim totaltime As Long
    Private Sub frmstartmonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main_button.Enabled = False
        cphr.Maximum = 0
        Call Evnt()
        Call XParticipatingStudents()
    End Sub

    Sub XParticipatingStudents()
        connect()
        'replaced
        strsql = "select * from attendance_view where evnt_code='" & Label6.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("stud_id"), 0)
                .SubItems.Add(sqlreader("lname"))
                .SubItems.Add(sqlreader("fname"))
            End With

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Sub Evnt()
        Label6.Text = frmEventStart.Label3.Text
        Label8.Text = frmEventStart.Label4.Text
        Label10.Text = frmEventStart.Label6.Text
        Label36.Text = sys_desig
        If frmEventStart.RadioButton1.Checked = True Then
            Label14.Text = frmEventStart.ComboBox1.Text + " " & frmEventStart.RadioButton1.Text
        Else
            Label14.Text = frmEventStart.ComboBox1.Text + " " & frmEventStart.RadioButton2.Text
        End If
    End Sub





    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label16.Text = Date.Today
        Label18.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Sub Updatestudent()

        '****************************************************
        'load course for identifying CS
        Dim session_CS, ttalCS, newCS As String
        Dim min, mout, aftin, aftout, evein, eveout As String
        connect()
        'replaced
        strsql = "select * from course where course_desc='" & Label26.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read Then
            session_CS = sqlreader("cs_per_session")
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        '****************************************************
        'load current total attendance for update
        connect()
        'replaced
        strsql = "select * from atndance where evnt_code='" & Label6.Text & "' and stud_id='" & txtbox_idnumber.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read Then
            ttalCS = sqlreader("attendance_ttl_cs")
            min = sqlreader("morningin")
            mout = sqlreader("morningout")
            aftin = sqlreader("afternoonin")
            aftout = sqlreader("afternoonout")
            evein = sqlreader("eveningin")
            eveout = sqlreader("eveningout")
        Else
            MsgBox("Student ID Not Found!" & vbCrLf & " " & vbCrLf & "Either The Student is not included in the Participants or The Student is not Registered!", MsgBoxStyle.Exclamation, "ID # Not Found")
            Label23.Text = "Please Scan an ID"
            Label21.Text = "Please Scan an ID"
            Label19.Text = "Please Scan an ID"
            Label30.Text = "Please Scan an ID"
            Label26.Text = "Please Scan an ID"
            Label28.Text = "Please Scan an ID"
            PictureBox1.BackgroundImage = Nothing
            txtbox_idnumber.Text = ""
            txtbox_idnumber.Select()
            Exit Sub
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        newCS = Val(ttalCS) - Val(session_CS)

        '****************************************************
        'updating attendance
        Dim att As String
        att = "Attended: Date:" & Date.Today & " Time:" & Now
        'MORNING IN ATTENDANCE UPDATE ACTION
        If Label14.Text = "Morning IN" Then
            If min = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set morningin='" & att & "'," _
                        & "attendance_ttl_cs='" & newCS & "'" _
                        & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()

            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
            'MORNING OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Morning OUT" Then
            If mout = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set morningout='" & att & "'," _
                            & "attendance_ttl_cs='" & newCS & "'" _
                            & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
            'aFTERNOON IN ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Afternoon IN" Then
            If aftin = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set afternoonin='" & att & "'," _
                            & "attendance_ttl_cs='" & newCS & "'" _
                            & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
            'aFTERNOON OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Afternoon OUT" Then
            If aftout = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set afternoonout='" & att & "'," _
                            & "attendance_ttl_cs='" & newCS & "'" _
                            & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
            'evening IN ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Evening IN" Then
            If evein = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set eveningin='" & att & "'," _
                            & "attendance_ttl_cs='" & newCS & "'" _
                            & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
            'evening OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Evening OUT" Then
            If eveout = "Not Attended" Then
                connect()
                'replaced
                strsql = "update atndance set eveningout='" & att & "'," _
                            & "attendance_ttl_cs='" & newCS & "'" _
                            & "where stud_id='" & Label23.Text & "' and evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                Call ADDtoLive()
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            Else
                MsgBox("Student Already Attended!", MsgBoxStyle.Exclamation, "Student Already Attended")
                Label23.Text = "Please Scan an ID"
                Label21.Text = "Please Scan an ID"
                Label19.Text = "Please Scan an ID"
                Label30.Text = "Please Scan an ID"
                Label26.Text = "Please Scan an ID"
                Label28.Text = "Please Scan an ID"
                PictureBox1.BackgroundImage = Nothing
                txtbox_idnumber.Text = ""
                txtbox_idnumber.Select()
            End If
        End If
    End Sub

    Private Sub txtbox_idnumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_idnumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtbox_idnumber.Text <> "" Then
                'Label23.Text = txtbox_idnumber.Text
                connect()
                'replaced
                strsql = "Select * from attendance_view where evnt_code='" & Label6.Text & "' and stud_id='" & txtbox_idnumber.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqladapter.SelectCommand = sqlcmd
                sqlreader = sqlcmd.ExecuteReader
                If sqlreader.Read Then
                    Label23.Text = sqlreader("stud_id")
                    Label21.Text = sqlreader("fname")
                    Label19.Text = sqlreader("lname")
                    Label30.Text = sqlreader("mname")
                    Label26.Text = sqlreader("course_desc")
                    Label28.Text = sqlreader("year_desc")
                    Dim img() As Byte
                    img = (sqlreader("picture"))
                    Dim ms As New System.IO.MemoryStream(img)
                    PictureBox1.BackgroundImage = Image.FromStream(ms)
                End If
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                'End If
                Call Updatestudent()

            End If
        End If
    End Sub

    Sub ADDtoLive()
        connect()
        'replaced
        strsql = "insert into tbl_Live_Monitoring(stud_ID,Event_name,serv_Session,Time_Attended) values ('" _
            & txtbox_idnumber.Text & "','" _
            & Label8.Text & "','" _
            & Label14.Text & "','" _
            & TimeOfDay.ToShortTimeString & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub txtbox_idnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_idnumber.KeyPress
        'If Asc(e.KeyChar) <> 8 And e.KeyChar <> "-" Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True

        '    End If
        'End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sys_desig <> "System Administrator" Then Exit Sub
        If MsgBox("This Action will End " & Label14.Text & " Session." & vbCrLf &
                  " " & vbCrLf &
                  "Note: This Action cannot be undone" & vbCrLf &
                  "Do you Want to Continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "End Session") = MsgBoxResult.Yes Then
            'MORNING IN END SESSION UPDATE
            If Label14.Text = "Morning IN" Then

                connect()
                'replaced
                strsql = "update tblSessionstatus set morinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                'MORNING OUT ATTENDANCE UPDATE ACTION
            ElseIf Label14.Text = "Morning OUT" Then
                connect()
                'replaced
                strsql = "update tblSessionstatus set moroutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                'aFTERNOON IN ATTENDANCE UPDATE ACTION
            ElseIf Label14.Text = "Afternoon IN" Then
                connect()
                'replaced
                strsql = "update tblSessionstatus set afterinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                'aFTERNOON OUT ATTENDANCE UPDATE ACTION
            ElseIf Label14.Text = "Afternoon OUT" Then
                connect()
                'replaced
                strsql = "update tblSessionstatus set afteroutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                'evening IN ATTENDANCE UPDATE ACTION
            ElseIf Label14.Text = "Evening IN" Then
                connect()
                'replaced
                strsql = "update tblSessionstatus set eveinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
                'evening OUT ATTENDANCE UPDATE ACTION
            ElseIf Label14.Text = "Evening OUT" Then

                connect()
                'replaced
                strsql = "update tblSessionstatus set eveoutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlreader = sqlcmd.ExecuteReader
                sqlcmd.Dispose()
                sqlreader.Close()
                sqlcon.Close()
                '***************update event status***************
                connect()
                strsql = "update evnt set evnt_stat='" & 1 &
               "'" & "where evnt_code='" & Label6.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcon.Close()
            End If

            'Delete from Live
            connect()
            strsql = "delete from tbl_Live_Monitoring"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()

            MsgBox("Session Ended!", MsgBoxStyle.Information, "End Session")
            Dispose()
            frmMain.Show()
        End If

    End Sub
    Sub XTimeOver()
        'MORNING IN END SESSION UPDATE
        If Label14.Text = "Morning IN" Then

            connect()
            'replaced
            strsql = "update tblSessionstatus set morinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'MORNING OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Morning OUT" Then
            connect()
            'replaced
            strsql = "update tblSessionstatus set moroutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'aFTERNOON IN ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Afternoon IN" Then
            connect()
            'replaced
            strsql = "update tblSessionstatus set afterinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'aFTERNOON OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Afternoon OUT" Then
            connect()
            'replaced
            strsql = "update tblSessionstatus set afteroutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'evening IN ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Evening IN" Then
            connect()
            'replaced
            strsql = "update tblSessionstatus set eveinstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'evening OUT ATTENDANCE UPDATE ACTION
        ElseIf Label14.Text = "Evening OUT" Then

            connect()
            'replaced
            strsql = "update tblSessionstatus set eveoutstat='" & 1 & "'" _
                         & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            '***************update event status***************
            connect()
            strsql = "update evnt set evnt_stat='" & 1 &
           "'" & "where evnt_code='" & Label6.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
        End If
        'Delete from Live
        connect()
        strsql = "delete from tbl_Live_Monitoring"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()
        sqlcmd.Dispose()
        sqlcon.Close()
        MsgBox("Countdown Time Ended, This Attendance Session will now End!", MsgBoxStyle.Information, "End Session")
        Dispose()
        frmMain.Show()
    End Sub

    Private Sub frmstartmonitoring_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If sys_desig <> "System Administrator" Then
            e.Cancel = True
            Exit Sub
        End If
        Dispose()
        frmMain.Show()
    End Sub

    Private Sub set_button_Click(sender As Object, e As EventArgs) Handles set_button.Click
        totaltime = hr_input.Value * 60 * 60 + min_input.Value * 60 + sec_input.Value
        If totaltime <> 0 Then
            main_button.Enabled = True
            hr_label.Text = AddZero(totaltime \ 3600)
            mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
            sec_label.Text = AddZero((totaltime Mod 3600) Mod 60)
            main_button.Text = "Start"
            set_button.Enabled = False
            main_button.Select()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "This should not be left empty!", "EAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Time should not be left empty!")
        End If
    End Sub
    Function AddZero(ByVal par As Integer) As String
        Dim a = ""
        If par < 10 Then
            a = "0" & par
        Else
            a = par
        End If
        Return a
    End Function

    Private Sub main_button_Click(sender As Object, e As EventArgs) Handles main_button.Click

        If main_button.Text = "Start" Then
            hr_input.Enabled = False
            min_input.Enabled = False
            sec_input.Enabled = False
            count.Enabled = True
            main_button.Text = "Pause"
            txtbox_idnumber.Enabled = True
            txtbox_idnumber.Select()
        ElseIf main_button.Text = "Continue" Then
            If sys_desig <> "System Administrator" Then Exit Sub : 
            hr_input.Enabled = False
            min_input.Enabled = False
            sec_input.Enabled = False
            count.Enabled = True
            main_button.Text = "Pause"
            txtbox_idnumber.Enabled = True
            txtbox_idnumber.Select()
        Else
            If sys_desig <> "System Administrator" Then Exit Sub : 
            main_button.Text = "Continue"
            hr_input.Enabled = True
            min_input.Enabled = True
            sec_input.Enabled = True
            count.Enabled = False
            set_button.Enabled = True
            txtbox_idnumber.Enabled = False

        End If
    End Sub

    Private Sub count_Tick(sender As Object, e As EventArgs) Handles count.Tick
        If totaltime > 0 Then
            totaltime -= 1
        Else
            count.Enabled = False
            MetroFramework.MetroMessageBox.Show(Me, "Timer is over!", "EAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox("Time is over!", MsgBoxStyle.Information, "EAS")
            main_button.Text = "Start"
            hr_input.Enabled = True
            min_input.Enabled = True
            sec_input.Enabled = True
            count.Enabled = False
            If sys_desig = "System Administrator" Then
                If MsgBox("The Time has Ended, Do you want to End this Session or just Manually End it?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "EAS") = MsgBoxResult.Yes Then
                    Call XTimeOver()
                End If
            Else
                Call XTimeOver()
            End If
        End If

        hr_label.Text = AddZero(totaltime \ 3600)
        mn_label.Text = AddZero((totaltime Mod 3600) \ 60)
        sec_label.Text = AddZero((totaltime Mod 3600) Mod 60)
        cphr.Maximum = hr_input.Value
        cphr.Value = hr_label.Text
        cphr.Text = hr_label.Text
        cpmin.Maximum = 59
        cpmin.Value = mn_label.Text
        cpmin.Text = mn_label.Text
        cpsec.Maximum = 59
        cpsec.Value = sec_label.Text
        cpsec.Text = sec_label.Text
    End Sub

    Private Sub hr_input_KeyDown(sender As Object, e As KeyEventArgs) Handles hr_input.KeyDown
        If e.KeyCode = Keys.Enter Then
            min_input.Select()

        End If
    End Sub

    Private Sub min_input_KeyDown(sender As Object, e As KeyEventArgs) Handles min_input.KeyDown
        If e.KeyCode = Keys.Enter Then
            sec_input.Select()
        End If
    End Sub

    Private Sub sec_input_ValueChanged(sender As Object, e As EventArgs) Handles sec_input.ValueChanged

    End Sub

    Private Sub sec_input_KeyDown(sender As Object, e As KeyEventArgs) Handles sec_input.KeyDown
        If e.KeyCode = Keys.Enter Then
            set_button.Select()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        connect()
        'replaced
        strsql = "select * from attendance_view where evnt_code='" & Label6.Text & "' and stud_id+lname like'%" & TextBox1.Text & "%'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("stud_id"), 0)
                .SubItems.Add(sqlreader("lname"))
                .SubItems.Add(sqlreader("fname"))
            End With

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        txtbox_idnumber.Text = ListView1.SelectedItems(0).Text
        txtbox_idnumber.Select()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Close()
    End Sub

    Private Sub Txtbox_idnumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class