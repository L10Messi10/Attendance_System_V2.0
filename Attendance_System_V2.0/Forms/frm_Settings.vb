Public Class frm_Settings
    Dim sched_stat As String
    Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewcourse()

    End Sub

    Sub viewcourse()
        On Error Resume Next
        ' sqlcon.Close()
        connect()
        'replaced
        strsql = "select * from course"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("course_desc"), 0)
                .SubItems.Add(sqlreader("course_code"))
                .SubItems.Add(sqlreader("fines_hours"))
                .SubItems.Add(sqlreader("fines_amount"))
                .SubItems.Add(sqlreader("cs_per_session"))
            End With

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        TextBox1.Text = ""
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        On Error Resume Next

        TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
        If e.KeyCode = Keys.Delete Then
            MsgBox("This action will Remove the Selected Record!", MsgBoxStyle.Critical, "Warning!")
            If MsgBox("This Action Cannot be Undone, and will also Remove all Student(s) Registered in This Course! Do you want to Continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                connect()
                'replaced
                strsql = "delete from course where course_code='" & TextBox1.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                Call viewcourse()
                MsgBox("Record Succesfully Deleted", MsgBoxStyle.Information, Me.Text)
                sqlcon.Close()
                sqlcmd.Dispose()
            End If
        End If
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        On Error Resume Next
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        frmCourseAE.Caddmode = True
        frmCourseAE.ShowDialog()
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        If TextBox1.Text <> "" Then
            frmCourseAE.Caddmode = False
            frmCourseAE.ShowDialog()
        Else
            MsgBox("Please Select a Course to Modify!", MsgBoxStyle.Exclamation, "Select")
        End If
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Call viewcourse()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dispose()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class