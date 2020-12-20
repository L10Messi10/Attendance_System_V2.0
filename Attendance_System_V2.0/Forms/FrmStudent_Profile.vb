Public Class FrmStudent_Profile
    Dim ttlcs_temp, ttlcs, crs, amnt As String
    Dim fins_hrs, temp, total_payable As String
    Private Sub FrmStudent_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call XProfile()
    End Sub

    Sub XProfile()
        connect()
        'replaced
        strsql = "select * from student_view where stud_id='" & frm_Students.TextBox1.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader

        If sqlreader.Read Then
            Label17.Text = (sqlreader("stud_id"))
            Label18.Text = (sqlreader("lname"))
            Label19.Text = (sqlreader("fname"))
            Label20.Text = (sqlreader("mname"))
            Label23.Text = (sqlreader("course_desc"))
            Label24.Text = (sqlreader("year_desc"))
            Label33.Text = (sqlreader("stud_status"))
            Label21.Text = sqlreader("address")
            Label22.Text = sqlreader("Tel_No")
            Label25.Text = sqlreader("P_Em_Name")
            Label26.Text = sqlreader("P_Em_Address")
            Label27.Text = sqlreader("P_Em_Contact_Num")
            crs = sqlreader("course_code")
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        connect()
        'replaced
        Dim table As New DataTable


        sqladapter.Fill(table)
        Label17.Text = table.Rows(0)(0).ToString()
        Dim img() As Byte
        img = table.Rows(0)(4)
        Dim ms As New System.IO.MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
        sqlcon.Close()
        '*************************************************
        connect()
        'replaced
        strsql = "Select distinct sy_sem_term from attendance_view"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While sqlreader.Read
            ComboBox1.Items.Add(sqlreader("sy_sem_term"))
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox1.DropDownClosed
        ' Dim fines, cs_hrs, ttl_fine As String
        If ComboBox1.Text = "" Then Exit Sub : 
        ttlcs = 0
        temp = 0
        total_payable = 0
        ttlcs_temp = 0
        amnt = 0
        fins_hrs = 0
        connect()
        'replaced
        strsql = "Select * from attendance_view where sy_sem_term LIKE '" & ComboBox1.Text & "' and stud_id = '" & Label17.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        Do While sqlreader.Read
            'MsgBox("No data")
            With ListView1.Items.Add(sqlreader("evnt_desc"), 0)
                .SubItems.Add(sqlreader("attendance_date"))
                .SubItems.Add(sqlreader("morningin"))
                .SubItems.Add(sqlreader("morningout"))
                .SubItems.Add(sqlreader("afternoonin"))
                .SubItems.Add(sqlreader("afternoonout"))
                .SubItems.Add(sqlreader("eveningin"))
                .SubItems.Add(sqlreader("eveningout"))
                .SubItems.Add(sqlreader("attendance_ttl_cs"))
                ttlcs_temp = sqlreader("attendance_ttl_cs")
                ttlcs = Val(ttlcs) + Val(ttlcs_temp)
            End With
        Loop
        Label29.Text = ttlcs
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        'For Calculating the Fines *******************************************
        connect()
        'replaced
        strsql = "select * from course where course_code='" & crs & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read Then
            amnt = (sqlreader("fines_amount"))
            fins_hrs = sqlreader("fines_hours")
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        temp = Val(ttlcs) / Val(fins_hrs)
        total_payable = temp * amnt
        Label31.Text = total_payable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub FrmStudent_Profile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
End Class