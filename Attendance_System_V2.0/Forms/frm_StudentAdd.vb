Public Class frm_StudentAdd
    Private Sub frm_StudentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XLoad()
    End Sub

    Sub XLoad()
        '  yrcdsub()
        ' for course and year
        connect()
        'replaced
        strsql = "select * from course"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        course.Items.Clear()

        Do While sqlreader.Read = True

            With course.Items.Add(sqlreader("course_desc"))

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

            With yr.Items.Add(sqlreader("year_desc"))

            End With

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
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

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dispose()
    End Sub

    Private Sub course_Click(sender As Object, e As EventArgs) Handles course.Click
        course.Items.Clear()
        connect()
        'replaced
        strsql = "select * from course"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        Do While sqlreader.Read = True
            With course.Items.Add(sqlreader("course_desc"))

            End With


        Loop
        sqlcon.Close()
    End Sub

    Private Sub course_SelectedValueChanged(sender As Object, e As EventArgs) Handles course.SelectedValueChanged
        coursecdsub()
    End Sub
    Private Sub yr_SelectedValueChanged(sender As Object, e As EventArgs) Handles yr.SelectedValueChanged
        yrcdsub()
    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        'If course.Text = "BSHRM" Or course.Text = "BSIT" Or course.Text = "BSCRIM" Or course.Text = "BSED" Or course.Text = "BSBA" Then

    End Sub
    Sub adstud()
        Try
            Dim ms As New System.IO.MemoryStream
            PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
            ms.ToArray()
            connect()
            'replaced
            strsql = "insert into student(stud_id,lname,fname,mname,address,Tel_No,P_Em_Name,P_Em_Address,P_Em_Contact_Num,course_code,year_code,stud_status) values( '" _
                        & studid.Text & "','" _
                        & lname.Text & "','" _
                        & fname.Text & "','" _
                        & mi.Text & "','" _
                        & TextBox1.Text & "','" _
                        & TextBox2.Text & "','" _
                        & TextBox3.Text & "','" _
                        & TextBox4.Text & "','" _
                        & TextBox5.Text & "','" _
                        & coursecode.Text & "','" _
                        & yrcode.Text & "','" _
                        & "Active" & "')"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            'for saving picture
            connect()
            strsql = "update student set picture=@pic where stud_id = @studid"
            sqlcmd.Parameters.Add("@studid", SqlDbType.VarChar).Value = studid.Text()
            sqlcmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            sqlcmd.Parameters.Clear()
            MsgBox("Record Succesfully Added", MsgBoxStyle.Information, Text)
            Dispose()
            'If MsgBox("Do you want to add another Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '    studid.Text = ""
            '    lname.Text = ""
            '    fname.Text = ""
            '    mi.Text = ""
            '    coursecode.Text = ""
            '    yrcode.Text = ""
            '    course.Items.Clear()
            '    yr.Items.Clear()
            '    TextBox1.Text = ""
            '    TextBox2.Text = ""
            '    TextBox3.Text = ""
            '    TextBox4.Text = ""
            '    TextBox5.Text = ""
            '    PictureBox1 = Nothing
            '    XLoad()

            'Else
            '    Dispose()
            'End If
        Catch ex As Exception
            MsgBox("Student ID exist, Please Double Check on the Student ID and try Saving it again!", MsgBoxStyle.Critical, "Duplicate ID Found!")
            sqlcmd.Parameters.Clear()
            sqlcon.Close()
            studid.SelectAll()
            studid.Select()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If studid.Text = "" Or lname.Text = "" Or fname.Text = "" Or mi.Text = "" Or course.Text = "" Or yr.Text = "" Then
            MsgBox("Please fill the form completely", MsgBoxStyle.Exclamation, Text)

        Else
            adstud()
        End If
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
    End Sub

    Private Sub yr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yr.SelectedIndexChanged

    End Sub
End Class