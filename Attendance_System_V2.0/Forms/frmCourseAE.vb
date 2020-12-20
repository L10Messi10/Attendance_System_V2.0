Public Class frmCourseAE
    Public Caddmode As Boolean
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            If Caddmode = True Then
                Call Xadmode()
            Else
                Call Xeditmode()
            End If

        Else
            MsgBox("Please Fill all fields", MsgBoxStyle.Exclamation, "Enter Data")
            TextBox1.Select()
        End If
    End Sub

    Sub Xadmode()
        Try
            connect()
            'replaced

            strsql = "insert into course(course_desc,fines_hours,fines_amount,cs_per_session) values ('" _
                  & TextBox1.Text & "','" _
                  & TextBox2.Text & "','" _
                  & TextBox3.Text & "','" _
                  & TextBox4.Text & "')"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            frm_Settings.viewcourse()
            MsgBox("Record Succesfully Added", MsgBoxStyle.Information, "Course")
            Dispose()
        Catch ex As Exception
            sqlcon.Close()
            MsgBox("Course Description is already in the Record please Check again!", MsgBoxStyle.Exclamation, "Duplicate Entry")
            TextBox1.Select()
        End Try
    End Sub

    Sub Xeditmode()
        Try
            connect()
            'replaced
            strsql = "update course set course_desc='" & TextBox1.Text &
              "',fines_hours = '" & TextBox2.Text &
              "',fines_amount = '" & TextBox3.Text &
              "',cs_per_session = '" & TextBox4.Text &
              "'" & "where course_code='" & Label3.Text & "'"

            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            frm_Settings.viewcourse()
            MsgBox("Record Succesfully Modified", MsgBoxStyle.Information, Me.Text)
            Dispose()
        Catch ex As Exception
            sqlcon.Close()
            MsgBox("Course Description is already in the Record please Check again!", MsgBoxStyle.Exclamation, "Duplicate Entry")
            TextBox1.Select()
        End Try
    End Sub

    Private Sub frmCourseAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Caddmode = False Then
            Call XdisplayCourse()
            Text = "Modify Course"
        Else
            Text = "Register Course"
        End If
    End Sub

    Sub XdisplayCourse()
        On Error Resume Next
        connect()
        'replaced
        strsql = "select * from course where course_code='" & frm_Settings.TextBox1.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        Do While sqlreader.Read = True
            TextBox1.Text = (sqlreader("course_desc"))
            Label3.Text = (sqlreader("course_code"))
            TextBox2.Text = sqlreader("fines_hours")
            TextBox3.Text = sqlreader("fines_amount")
            TextBox4.Text = sqlreader("cs_per_session")
        Loop
        sqlcon.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class