Public Class frmSystem_User
    Private Sub frmSystem_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call My_Profile()
    End Sub

    Sub My_Profile()
        connect()
        'replaced
        strsql = "select * from login where username='" & sys_user & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader

        If sqlreader.Read Then
            TextBox1.Text = (sqlreader("username"))
            TextBox2.Text = (sqlreader("password"))
            TextBox3.Text = (sqlreader("full_name"))
            TextBox4.Text = (sqlreader("address"))
            TextBox5.Text = (sqlreader("contact_num"))
            Label12.Text = (sqlreader("designation"))

        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()

        connect()
        Dim table As New DataTable
        sqladapter.Fill(table)
        TextBox1.Text = table.Rows(0)(5).ToString()
        Dim img() As Byte
        img = table.Rows(0)(7)
        Dim ms As New System.IO.MemoryStream(img)
        PictureBox1.BackgroundImage = Image.FromStream(ms)
        sqlcon.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"
        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.BackgroundImage = Image.FromFile(opf.FileName)
        End If
        'PictureBox1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        sqlcon.Close()
            Dim ms As New System.IO.MemoryStream
            PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
            ms.ToArray()
            connect()
        'replaced
        strsql = "update login set username='" & TextBox1.Text &
              "',password = '" & TextBox2.Text &
              "',full_name = '" & TextBox3.Text &
              "',address = '" & TextBox4.Text &
              "',Contact_Num = '" & TextBox5.Text &
              "'" & "where username='" & sys_user & "'"

        sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
        sys_user = TextBox1.Text
        connect()
        'replaced
        strsql = "update login set my_img=@pic where username = @uname"
        sqlcmd.Parameters.Add("@uname", SqlDbType.VarChar).Value = sys_user
        sqlcmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcon.Close()
            sqlcmd.Parameters.Clear()
        frm_Students.stud()
        ' MsgBox("Record Succesfully Modified!", MsgBoxStyle.Information, "Saved")
        frmMain.Show_user()
        Dispose()
        'Catch ex As Exception
        '    MsgBox("Student ID exist, Please Double Check on the Student ID and try Saving it again!", MsgBoxStyle.Critical, "Duplicate ID Found")
        '    sqlcmd.Parameters.Clear()
        '    sqlcon.Close()
        '    studid.SelectAll()
        '    studid.Select()


        'End Try
    End Sub
End Class