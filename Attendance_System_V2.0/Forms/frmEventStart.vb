Public Class frmEventStart
    Dim morin, morout, afterin, afterout, evein, eveout, selectedsession As String
    Public currnt_session As String
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If ComboBox1.Text = "Morning" Then
            selectedsession = morin
            currnt_session = "morningIN"
        ElseIf ComboBox1.Text = "Afternoon" Then
            selectedsession = afterin
            currnt_session = "afternoonIN"
        ElseIf ComboBox1.Text = "Evening" Then
            selectedsession = evein
            currnt_session = "EveningIN"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If ComboBox1.Text = "Morning" Then
            selectedsession = morout
            currnt_session = "morningOUT"
        ElseIf ComboBox1.Text = "Afternoon" Then
            selectedsession = afterout
            currnt_session = "AfternoonOUT"
        ElseIf ComboBox1.Text = "Evening" Then
            selectedsession = eveout
            currnt_session = "EveningOUT"
        End If
    End Sub

    Private Sub frmEventStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadselectedevent()
    End Sub
    Sub loadselectedevent()
        connect()
        ''replaced
        strsql = "Select * from View_Events where evnt_code= '" & frm_ScheduledEvents.evnt_code & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read Then
            Label3.Text = sqlreader("evnt_code")
            Label4.Text = sqlreader("evnt_desc")
            Label6.Text = sqlreader("evnt_session")
            morin = sqlreader("morinstat")
            morout = sqlreader("moroutstat")
            afterin = sqlreader("afterinstat")
            afterout = sqlreader("afteroutstat")
            evein = sqlreader("eveinstat")
            eveout = sqlreader("eveoutstat")
            Dim txtstring As String = sqlreader("evnt_session")
            Dim TestArray() As String = Split(txtstring)
            Dim LastNonEmpty As Integer = -1
            ComboBox1.Items.Clear()

            For i As Integer = 0 To TestArray.Length - 1
                If TestArray(i) <> "" Then
                    LastNonEmpty += 1
                    TestArray(LastNonEmpty) = TestArray(i)

                    With ComboBox1.Items.Add(TestArray(LastNonEmpty))

                    End With


                End If
            Next
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        selectedsession = ""
        currnt_session = ""
        '***************************************************************8

        connect()
        ''replaced
        strsql = "Select distinct course_desc from attendance_view where evnt_code='" & frm_ScheduledEvents.evnt_code & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read
            With ListView1.Items.Add(sqlreader("Course_desc"), 0)
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Enabled = True
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text <> "" Then
            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Please Select Session First", MsgBoxStyle.Exclamation, "Session")
                Exit Sub

            End If
            If selectedsession <> 1 Then
                Me.Hide()
                frmMain.Hide()
                frmstartmonitoring.ShowDialog()
            Else
                MsgBox("This Session has already been Ended! Please Check again!", MsgBoxStyle.Exclamation, "Session Ended")
            End If
        Else
                MsgBox("Please Select Session First", MsgBoxStyle.Exclamation, "Session")
        End If
    End Sub
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click

    End Sub

    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox1.DropDownClosed
        If ComboBox1.Text <> "" Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Enabled = False
            Button3.Enabled = True
        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click

    End Sub

    Private Sub frmEventStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class