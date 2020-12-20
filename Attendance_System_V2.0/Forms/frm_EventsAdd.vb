Public Class frm_EventsAdd
    Dim startDate As String
    Dim endDate As String
    Dim ses As String
    Private Sub MetroCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox4.CheckedChanged
        If MetroCheckBox4.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub frm_EventsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroCheckBox4.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter event title", MsgBoxStyle.Exclamation, "Enter Event Title")
            TextBox1.Focus()

        Else
            If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
                ses = CheckBox1.Text + " " + CheckBox2.Text + " " + CheckBox3.Text
            ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
                ses = CheckBox1.Text + " " + CheckBox2.Text + " "
            ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
                ses = CheckBox1.Text + " " + CheckBox3.Text
            ElseIf CheckBox1.Checked = True Then
                ses = CheckBox1.Text
            ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
                ses = CheckBox2.Text + " " + CheckBox3.Text
            ElseIf CheckBox3.Checked = True Then
                ses = CheckBox3.Text
            ElseIf CheckBox2.Checked = True Then
                ses = CheckBox2.Text
            Else
                MsgBox("Please select atleast ONE(1) session!", MsgBoxStyle.Exclamation, "No Session Selected")
                Exit Sub
            End If

            If MsgBox("Are you sure To Save This event?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Try
                'morning, afternoon, evening
                If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 1 & "','" _
                        & 1 & "','" _
                        & 1 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'morning only
                ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 1 & "','" _
                        & 0 & "','" _
                        & 0 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'afternoon only
                ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 0 & "','" _
                        & 1 & "','" _
                        & 0 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'evening only
                ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 0 & "','" _
                        & 0 & "','" _
                        & 1 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'morning & Afternoon only
                ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = False Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 1 & "','" _
                        & 1 & "','" _
                        & 0 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'afternoon & evening only
                ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = True Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 0 & "','" _
                        & 1 & "','" _
                        & 1 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                    'morning & evening only
                ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = True Then
                    connect()
                    'replaced

                    strsql = "insert into evnt(evnt_desc,evnt_session,mortrue,aftertrue,evetrue,evnt_stat) values ('" _
                        & TextBox1.Text & "','" _
                        & ses & "','" _
                        & 1 & "','" _
                        & 0 & "','" _
                        & 1 & "','" _
                        & 0 & "')"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("Event Succesfully Added, This Event Can be scheduled now!", MsgBoxStyle.Information, "Event Added")
                    sqlcmd.Dispose()
                    sqlreader.Close()
                    sqlcon.Close()
                End If
                'Catch ex As Exception
                '    MsgBox(ex.Message)

                '    Exit Sub


                'End Try
                frm_Events.viewevent()
                Call frmMain.XcheckEvents()
                Dispose()

            End If
        End If
    End Sub

    Private Sub frm_EventsAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class