Public Class frm_ScheduledEvents
    Public evnt_code As String
    Private Sub frm_ScheduledEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadsched()
    End Sub
    Sub loadsched()
        connect()
        ''replaced
        strsql = "Select * from View_Events where morinstat <> '" & 1 & "' or moroutstat <> '" & 1 & "' or afterinstat <> '" & 1 & "' or afteroutstat <> '" & 1 & "' or eveinstat <> '" & 1 & "' or eveoutstat <> '" & 1 & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()

        Do While sqlreader.Read
            With ListView1.Items.Add(sqlreader("evnt_code"), 0)
                .SubItems.Add(sqlreader("evnt_desc"))
                .SubItems.Add(sqlreader("morinstat"))
                .SubItems.Add(sqlreader("moroutstat"))
                .SubItems.Add(sqlreader("afterinstat"))
                .SubItems.Add(sqlreader("afteroutstat"))
                .SubItems.Add(sqlreader("eveinstat"))
                .SubItems.Add(sqlreader("eveoutstat"))
                .SubItems.Add(sqlreader("DOTE"))
            End With
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        evnt_code = ""
        If ListView1.Items.Count <> 0 Then
            Label1.Text = "1 Means The Session is already Finished and 0 means the Session has not been started yet or finished."
        Else
            Label1.Text = "No Scheduled Events Added!"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If evnt_code <> "" Then
            frmEventStart.ShowDialog()
        Else
            MsgBox("Please Select an Scheduled Event to Start!", MsgBoxStyle.Exclamation, "Select Scheduled Event")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If evnt_code <> "" Then
            frmPartCourse.ShowDialog()
        Else
            MsgBox("Please Select an Scheduled Event to show Participating Course(s)", MsgBoxStyle.Exclamation, "Select Scheduled Event")
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Call loadsched()
        Call frmMain.XcheckEvents()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        evnt_code = ListView1.SelectedItems(0).Text
    End Sub
End Class