Imports System.Threading
Public Class frm_LiveMonitor

    Private Sub frm_LiveMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Xmonitor()
    End Sub

    Sub Xmonitor()
        Dim evnt_name, session As String

        sqlcon.Close()
        connect()
        strsql = "select * from V_LiveMonitoring Order by Time_Attended"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ListView1.Items.Clear()
        'If sqlreader.Read = True Then
        Do While sqlreader.Read = True
            With ListView1.Items.Add(sqlreader("stud_ID"), 0)
                .SubItems.Add(sqlreader("lname"))
                .SubItems.Add(sqlreader("fname"))
                .SubItems.Add(sqlreader("course_desc"))
                .SubItems.Add(sqlreader("Time_Attended"))
                .SubItems.Add(sqlreader("Event_name"))
            End With
        Loop


        'Else
        '    Me.Text = "Live Monitoring (No Data from Client(s)"
        'End If
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ctr As Integer = 0
        ctr += 1
        ToolStripLabel2.Text = "Refreshing Data in " & ctr
        If ctr = 15 Then
            Call Xmonitor()
            ctr = 0
        End If
    End Sub

    Private Sub frm_LiveMonitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
        Dispose()
    End Sub
End Class