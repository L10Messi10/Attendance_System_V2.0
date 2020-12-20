Public Class frm_Students
    Dim strsearch As String
    Dim s, ln, fn As String
    Dim sortColumn As Integer = -1
    Dim blnAscending As Boolean = True
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dispose()
    End Sub

    Private Sub frm_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call stud()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        If ListView1.SelectedItems.Count = 0 Then
            PictureBox1.BackgroundImage = Nothing
            TextBox1.Text = ""
        Else
            PictureBox1.Visible = True
            TextBox1.Text = ListView1.SelectedItems(0).Text
            sqlcon.Close()
            connect()
            'replaced
            strsql = "select * from student_view where stud_id='" & TextBox1.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqladapter.SelectCommand = sqlcmd
            sqlreader = sqlcmd.ExecuteReader
            If sqlreader.Read = True Then

                lstud_id.Text = (sqlreader("stud_id"))
                llastname.Text = (sqlreader("lname"))
                lfirstname.Text = (sqlreader("fname"))
                lmi.Text = (sqlreader("mname"))
                lcourse.Text = (sqlreader("course_desc"))
                lyear.Text = (sqlreader("year_desc"))
                Label1.Text = (sqlreader("stud_status"))
            End If
            sqlreader.Close()
            sqlcmd.Dispose()
            sqlcon.Close()
            Dim table As New DataTable

            PictureBox1.Visible = True
            sqladapter.Fill(table)
            TextBox1.Text = table.Rows(0)(0).ToString()
            Dim img() As Byte
            img = table.Rows(0)(4)
            Dim ms As New System.IO.MemoryStream(img)
            PictureBox1.BackgroundImage = Image.FromStream(ms)
        End If

    End Sub

    Sub stud()
        TextBox1.Text = ""
        lstud_id.Text = ""
        llastname.Text = ""
        lfirstname.Text = ""
        lmi.Text = ""
        lcourse.Text = ""
        lyear.Text = ""
        Label1.Text = ""
        connect()
        'replaced
        strsql = "select TOP 100 * from student_view"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("stud_id"), 0)
                ln = sqlreader("lname")
                .SubItems.Add(ln.ToUpper)
                '.SubItems(1).Font = New Font(Font, FontStyle.Bold)
                fn = sqlreader("fname")
                .SubItems.Add(fn.ToUpperInvariant)
                s = (sqlreader("mname"))
                .SubItems.Add(s.Substring(0, 1).ToUpper + ".")
                .SubItems.Add(sqlreader("course_desc"))
                .SubItems.Add(sqlreader("year_desc"))
                .SubItems.Add(sqlreader("stud_status"))
            End With

        Loop
        For Each lvi As ListViewItem In ListView1.Items
            lvi.UseItemStyleForSubItems = False
            lvi.SubItems(1).Font = New Font(lvi.Font, FontStyle.Bold)
        Next
        ToolStripLabel2.Text = "Total Records Displayed: " & ListView1.Items.Count
        PictureBox1.BackgroundImage = Nothing
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        strsearch = ""
        ToolStripTextBox1.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_StudentAdd.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Select a Student record to Modify!", MsgBoxStyle.Exclamation, "No Record Selected")
            Exit Sub
        Else
            frm_StudentEdit.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Select student record to view its Profile", MsgBoxStyle.Exclamation, "No Record Selected")
            Exit Sub
        Else
            FrmStudent_Profile.ShowDialog()
        End If

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If TextBox1.Text = "" Then
            MsgBox("No record to be Deleted")
        Else
            If MsgBox("Are you sure you want to Delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete?") = DialogResult.Yes Then
                sqlcon.Close()
                connect()
                'replaced
                strsql = "delete from student where stud_id='" & TextBox1.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                MsgBox("Record Succesfully Deleted", MsgBoxStyle.Information, Me.Text)


                sqlcon.Close()
                sqlcmd.Dispose()
            End If

            ListView1.Sorting = SortOrder.None

            stud()
            Me.Refresh()
            ToolStripTextBox1.Text = ""
            PictureBox1.Image = Nothing
            If TextBox1.Text = "" Then

                lstud_id.Text = ""
                llastname.Text = ""
                lfirstname.Text = ""
                lmi.Text = ""
                lcourse.Text = ""
                lyear.Text = ""
                Label1.Text = ""
                PictureBox1.Visible = False
            End If
        End If

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Call stud()
    End Sub


    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If ToolStripTextBox1.Text <> "" Then
                    connect()
                    'replaced
                    strsql = " select * from student_view where stud_id+lname+fname+course_desc like '%" & ToolStripTextBox1.Text & "%'"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlcon
                    sqladapter.SelectCommand = sqlcmd
                    sqlreader = sqlcmd.ExecuteReader
                    ListView1.Items.Clear()
                    Do While sqlreader.Read = True
                        With ListView1.Items.Add(sqlreader("stud_id"), 0)
                            ln = sqlreader("lname")
                            .SubItems.Add(ln.ToUpper)

                            .SubItems(1).Font = New Font(Font, FontStyle.Bold)
                            fn = sqlreader("fname")
                            .SubItems.Add(fn.ToUpperInvariant)
                            s = (sqlreader("mname"))
                            .SubItems.Add(s.Substring(0, 1).ToUpper + ".")
                            .SubItems.Add(sqlreader("course_desc"))
                            .SubItems.Add(sqlreader("year_desc"))
                            .SubItems.Add(sqlreader("stud_status"))
                        End With
                        For Each lvi As ListViewItem In ListView1.Items
                            lvi.UseItemStyleForSubItems = False
                            lvi.SubItems(1).Font = New Font(lvi.Font, FontStyle.Bold)
                        Next
                    Loop
                    ToolStripLabel2.Text = "Total Records Found: " & ListView1.Items.Count
                    sqlreader.Close()
                    sqlcmd.Dispose()
                    sqlcon.Close()
                Else
                    Call stud()
                End If
            Catch ex As Exception

                'MsgBox("Please select Column to Find your query!", MsgBoxStyle.Exclamation, "Search")
                'ToolStripComboBox1.Focus()
                ListView1.Items.Clear()
                ToolStripTextBox1.Text = ""
                'Exit Sub
                'Finally
                '    sqlreader.Close()
                '    sqlcmd.Dispose()
                '    sqlcon.Close()


            End Try
            sqlreader.Close()
            sqlcmd.Dispose()
            sqlcon.Close()
        End If
    End Sub
End Class