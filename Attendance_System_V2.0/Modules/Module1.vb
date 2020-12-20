Imports System.Data.SqlClient

Module Module1
    Public sqlcmd As New SqlCommand
    Public sqlccmd As New SqlCommand
    Public sqlcon As New SqlConnection
    Public sqladapter As New SqlDataAdapter
    Public selectedbutton As String
    Public sqlreader As SqlDataReader
    Public strsql As String
    Public con As SqlConnection
    Public cons, ipadd, uid, passw, sys_user, sys_desig As String


    Sub connect()
        Try
            '" & server.TextBox1.Text & "'
            sqlcon.Close()
            sqlcon.ConnectionString = ("server=" & ipadd & ";network library=dbmssocn;initial catalog=attedance;user id='" & uid & "';password='" & passw & "';MultipleActiveResultSets = True;")
            'sqlcon.ConnectionString = ("server=desktop-8sc363v;network library=dbmssocn;initial catalog=attedance;user id=sa;password=green;")
            'sqlcon.ConnectionString = ("server='" & server.TextBox1.Text & "';network library=dbmssocn;initial catalog=attedance;user id=sa;password=administrator02;")
            sqlcon.Open()
            ' sqlcon.Close()

        Catch ex As Exception
            MsgBox("Sorry cannot open connection!", MsgBoxStyle.Critical, "Connection Failed")
            MsgBox("Please Make sure to correct the IP address and the server services is running!", MsgBoxStyle.Information, "Configure Server")
            'Dim proc As New System.Diagnostics.Process()
            'proc = Process.Start("C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn\ManagementStudio\ssms.exe", "")
            frm_Server.Show()
            Exit Sub
        End Try 'Else
        '    'replaced
        'End If
        'DESKTOP-8SC363V
        '74:     c6 : 3b:2f:c2 : 3b
    End Sub
    Public Function DISPLAY(ByVal QUERY As String) As DataTable
        Call connect()
        ' sqlcon.Open
        Dim COMM As New SqlCommand(QUERY, sqlcon)
        Dim DT As New DataTable
        Dim ADP As New SqlDataAdapter(COMM)
        ADP.Fill(DT)
        Return DT
    End Function
    Public Sub LoadChildform(ByRef myFORM As Form, ByRef myMdiFORM As Form)

        myFORM.MdiParent = myMdiFORM
        'myFORM.Width = myMdiFORM.Width
        'myFORM.Height = myMdiFORM.Height
        myFORM.WindowState = FormWindowState.Normal
        myFORM.Activate()
        myFORM.Focus()
        myFORM.Show()
    End Sub
    Public Sub Test()
        'Try
        'ipadd = My.Settings.ipadd
        '    uid = My.Settings.userid
        '    passw = My.Settings.pssword
        ' cons = "server='" & ipadd & "' ;Network Library=DBMSSOCN;Initial Catalog=Water_System;User ID='" & uid & "';Password='" & passw & "';"
        sqlcon.ConnectionString = "server=" & ipadd & " ;Network Library=DBMSSOCN;Initial Catalog=attedance;User ID=" & uid & " ;Password=" & passw & ";"
            sqlcon.Open()
            Select Case selectedbutton
                Case "ButtonOK"
                    'MsgBox("Server is now open!", MsgBoxStyle.Information, "Server Testing")
                    sqlcon.Close()
                    frm_Server.Hide()
                    frmlogin.ShowDialog()
                Case "ButtonTest"
                    MsgBox("Server is now open!", MsgBoxStyle.Information, "Server Testing")
                    frm_Server.Button3.Enabled = True
                    sqlcon.Close()
            End Select


        'Catch ex As Exception
        '    MsgBox("Sorry cannot open connection!", MsgBoxStyle.Critical, "Test Connection")
        '    MsgBox("Please Make sure to correct the IP address and the server services is running!", MsgBoxStyle.Information, "Configure Server")

        '    'Dim proc As New System.Diagnostics.Process()
        '    'proc = Process.Start("C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn\ManagementStudio\ssms.exe", "")
        '    frm_Server.Button3.Enabled = False
        '    frm_Server.Show()

        'End Try


    End Sub

End Module
