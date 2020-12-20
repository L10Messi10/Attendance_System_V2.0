Imports System.Data.SqlClient
Public Class cs_option
    Dim secrs, cc, cc2 As String
    Private Sub cs_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcourse()
        loadpartcourse()
    End Sub
    Sub loadcourse()
        'On Error Resume Next
        connect()
        'replaced
        strsql = "select * from course"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("course_desc"), 0)
                .SubItems.Add(sqlreader("cs_per_session"))
                .SubItems.Add(sqlreader("Course_code"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        secrs = ""
    End Sub

    Sub loadpartcourse()
        connect()
        'replaced
        strsql = "select * from Viewparticipants where evnt_code='" & startsat.vt & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        ListView2.Items.Clear()

        Do While sqlreader.Read = True
            With ListView2.Items.Add(sqlreader("course_desc"), 0)
                .SubItems.Add(sqlreader("cs_per_session"))
                .SubItems.Add(sqlreader("Course_code"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        secrs = ""
        cc = ""
        cc2 = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Checkparticipants()
    End Sub

    Sub Checkparticipants()
        connect()
        'replaced
        strsql = "select * from Viewparticipants where evnt_code='" & startsat.vt & "' and course_desc ='" & secrs & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqlreader = sqlcmd.ExecuteReader
        If sqlreader.Read = False Then
            sqlcmd.Dispose()
            sqlreader.Close()
            strsql = "insert into tblParticipants(evnt_code,course_code) values ('" _
                 & startsat.vt & "','" _
                 & cc & "')"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            loadpartcourse()
        Else
            MsgBox("Course Already Selected for This Event!", MsgBoxStyle.Exclamation, "Select Course")
        End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        On Error Resume Next
        secrs = ListView1.SelectedItems(0).Text
        cc = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        On Error Resume Next
        secrs = ListView1.SelectedItems(0).Text
        cc = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Are you sure to Add All Courses to this Event?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Add All") = MsgBoxResult.Yes Then
            connect()
            'replaced
            strsql = "select * from course"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlreader = sqlcmd.ExecuteReader
            'a = sqlreader("count")
            Do While sqlreader.Read = True

                cc = sqlreader("course_code")
                Dim sqlreader2 As SqlDataReader
                Dim sqlcmd3 As New SqlCommand
                'sqlcmd.Dispose()
                strsql = "select * from Viewparticipants where evnt_code='" & startsat.vt & "' and course_code ='" & cc & "'"
                sqlcmd3.CommandText = strsql
                sqlcmd3.Connection = sqlcon
                sqlreader2 = sqlcmd3.ExecuteReader
                If sqlreader2.Read = False Then
                    Call saveallcourse()
                End If
                sqlcmd.Dispose()
                sqlreader2.Close()
                sqlcmd3.Dispose()
                'loadpartcourse()
            Loop
            loadpartcourse()
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
        Else
            sqlcon.Close()
        End If
    End Sub
    Sub saveallcourse()
        Dim sqlcmd2 As New SqlCommand
        strsql = "insert into tblParticipants(evnt_code,course_code) values ('" _
                 & startsat.vt & "','" _
                 & cc & "')"
        sqlcmd2.CommandText = strsql
        sqlcmd2.Connection = sqlcon
        sqlcmd2.ExecuteNonQuery()
        sqlcmd2.Dispose()
        'sqlcon.Close()
        cc = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are you sure to remove all Participating Course(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Remove All Participants") = MsgBoxResult.Yes Then
            connect()
            'replaced
            strsql = "delete tblParticipants  where evnt_code='" & startsat.vt & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            loadcourse()
            loadpartcourse()
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ListView2.Items.Count <> 0 Then
            If cc2 <> "" Then
                connect()
                'replaced
                strsql = "delete tblParticipants  where evnt_code='" & startsat.vt & "' and course_code ='" & cc2 & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                sqlcon.Close()
                loadcourse()
                loadpartcourse()
            Else
                MsgBox("Please Select a Data from the  Participating Course List on the right Side list!", MsgBoxStyle.Exclamation, Me.Text)
            End If
        Else
            MsgBox("No Data to remove!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        On Error Resume Next
        secrs = ListView1.SelectedItems(0).Text
        cc = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        On Error Resume Next
        cc2 = ListView2.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub ListView2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView2.KeyDown
        On Error Resume Next
        cc2 = ListView2.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView2_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView2.KeyUp
        On Error Resume Next
        cc2 = ListView2.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub cs_option_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ListView2.Items.Count <> 0 Then
            Hide()
        Else
            If MsgBox("Participants' list is Empty, Do you still want to close This Window?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Hide()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class