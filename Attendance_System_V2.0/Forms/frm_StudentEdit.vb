Public Class frm_StudentEdit
    Private Sub frm_StudentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        'replaced
        strsql = "select * from course"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ' course.Items.Clear()
        course.Items.Clear()

        Do While sqlreader.Read = True
            With course.Items
                .Add(sqlreader("course_desc"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        connect()
        'replaced
        strsql = "select * from year"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        yr.Items.Clear()
        Do While sqlreader.Read = True
            With yr.Items
                .Add(sqlreader("year_desc"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        connect()
        'replaced
        strsql = "select * from status"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        stdstatus.Items.Clear()

        Do While sqlreader.Read = True
            With stdstatus.Items
                .Add(sqlreader("stud_status"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        Call View_Stu()


    End Sub
    Sub View_Stu()
        'On Error Resume Next
        ' for combobox course yr and status

        connect()
        'replaced
        strsql = "select * from student_view where stud_id='" & frm_Students.TextBox1.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader

        If sqlreader.Read Then
            studid.Text = (sqlreader("stud_id"))
            lname.Text = (sqlreader("lname"))
            fname.Text = (sqlreader("fname"))
            mi.Text = (sqlreader("mname"))
            course.Text = (sqlreader("course_desc"))
            yr.Text = sqlreader("year_desc")
            yrcode.Text = sqlreader("year_code")
            oldstud.Text = (sqlreader("stud_id"))
            stdstatus.Text = (sqlreader("stud_status"))
            TextBox1.Text = sqlreader("address")
            TextBox2.Text = sqlreader("Tel_No")
            TextBox3.Text = sqlreader("P_Em_Name")
            TextBox4.Text = sqlreader("P_Em_Address")
            TextBox5.Text = sqlreader("P_Em_Contact_Num")
            coursecode.Text = sqlreader("course_code")
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        connect()
        'replaced
        Dim table As New DataTable


        sqladapter.Fill(table)
        studid.Text = table.Rows(0)(0).ToString()
        Dim img() As Byte
        img = table.Rows(0)(4)
        Dim ms As New System.IO.MemoryStream(img)
        PictureBox1.BackgroundImage = Image.FromStream(ms)
        sqlcon.Close()


    End Sub
    Sub yrcdsub()
        connect()
        'replaced
        strsql = "select * from year where year_desc ='" & yr.SelectedItem & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader

        If sqlreader.Read = True Then
            yrcode.Text = (sqlreader("year_code"))

        End If
        sqlcon.Close()
    End Sub
    Sub coursecdsub()
        connect()
        'replaced
        strsql = "select * from course where course_desc ='" & course.SelectedItem & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read = True Then
            coursecode.Text = (sqlreader("course_code"))

        End If
        sqlcon.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If studid.Text = "" Or lname.Text = "" Or fname.Text = "" Or mi.Text = "" Or course.Text = "" Or yr.Text = "" Or stdstatus.Text = "" Then
            MsgBox("Please fill the form completely", MsgBoxStyle.Exclamation, Text)
        Else
            Xsavess()
        End If
    End Sub

    Sub Xsavess()
        Try
            sqlcon.Close()
            Dim ms As New System.IO.MemoryStream
            PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
            ms.ToArray()
            connect()
            'replaced
            strsql = "update student set lname='" & lname.Text &
              "',stud_id = '" & studid.Text &
             "',fname = '" & fname.Text &
               "',mname = '" & mi.Text &
              "',year_code = '" & yrcode.Text &
               "',course_code = '" & coursecode.Text &
              "',stud_status = '" & stdstatus.Text &
              "',address = '" & TextBox1.Text &
              "',Tel_No = '" & TextBox2.Text &
              "',P_Em_Name = '" & TextBox3.Text &
              "',P_Em_Address = '" & TextBox4.Text &
              "',P_Em_Contact_Num = '" & TextBox5.Text &
              "'" & "where stud_id='" & frm_Students.TextBox1.Text & "'"

            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()

            connect()
            'replaced
            strsql = "update student set picture=@pic where stud_id = @studid"
            sqlcmd.Parameters.Add("@studid", SqlDbType.VarChar).Value = oldstud.Text()
            sqlcmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            sqlcmd.Parameters.Clear()
            frm_Students.stud()
            MsgBox("Record Succesfully Modified!", MsgBoxStyle.Information, "Saved")
            Dispose()
        Catch ex As Exception
            MsgBox("Student ID exist, Please Double Check on the Student ID and try Saving it again!", MsgBoxStyle.Critical, "Duplicate ID Found")
            sqlcmd.Parameters.Clear()
            sqlcon.Close()
            studid.SelectAll()
            studid.Select()
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dispose()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(opf.FileName)

        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        captureform.ShowDialog()
    End Sub

    Private Sub course_DropDownClosed(sender As Object, e As EventArgs) Handles course.DropDownClosed

        If course.Text.Contains("BS") Then
            yr.Items.Clear()
            With yr.Items
                .Add("1")
                .Add("2")
                .Add("3")
                .Add("4")
            End With
        ElseIf course.Text.Contains("Grade 11") Then
            yr.Items.Clear()
            With yr.Items
                .Add("11")
            End With
        ElseIf course.Text.Contains("Grade 12") Then
            yr.Items.Clear()
            With yr.Items
                .Add("12")
            End With
        Else
            yr.Items.Clear()
            With yr.Items
                .Add("1")
                .Add("2")
            End With

        End If
        coursecdsub()
    End Sub

    Private Sub yr_DropDownClosed(sender As Object, e As EventArgs) Handles yr.DropDownClosed
        Call yrcdsub()
    End Sub

    Private Sub frm_StudentEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class