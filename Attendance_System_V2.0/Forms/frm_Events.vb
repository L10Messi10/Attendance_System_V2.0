Public Class frm_Events
    Dim sched_stat As String
    Private Sub frm_Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewevent()
    End Sub
    Sub viewevent()

        ' sqlcon.Close()
        connect()
        'replaced
        strsql = "select * from evnt"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("evnt_desc"), 0)
                .SubItems.Add(sqlreader("evnt_session"))
                .SubItems.Add(sqlreader("evnt_code"))
                sched_stat = sqlreader("evnt_stat")
                If sched_stat = 1 Then
                    .SubItems.Add("Recent")
                Else
                    .SubItems.Add("Upcoming")
                End If
            End With

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If MsgBox("Are you sure to Remove the Event " & (ListView1.SelectedItems(0).Text) & " ? This Action cannot be undone Do you want to Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Event") = MsgBoxResult.Yes Then
                connect()
                'replaced
                strsql = "delete from evnt where evnt_code='" & TextBox1.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                sqlcon.Close()
                viewevent()
                MsgBox("Event Successfully Removed!", MsgBoxStyle.Information, "Event Deleted")
                Call frmMain.XcheckEvents()
            End If
        Else
            MsgBox("No Event Selected!", MsgBoxStyle.Exclamation, "Delete")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call viewevent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_EventsAdd.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub frm_Events_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are you sure to Remove all the Event(s)? This Action cannot be undone Do you want to Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Event") = MsgBoxResult.Yes Then
            connect()
            'replaced
            strsql = "delete from evnt"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()
            viewevent()
            MsgBox("Event(s) Successfully Removed!", MsgBoxStyle.Information, "Event Deleted")
            Call frmMain.XcheckEvents()
        End If
    End Sub
End Class