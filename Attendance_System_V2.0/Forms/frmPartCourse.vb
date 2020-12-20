Public Class frmPartCourse
    Private Sub frmPartCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadpartcourse()
    End Sub
    Sub loadpartcourse()
        connect()
        'replaced
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub frmPartCourse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class