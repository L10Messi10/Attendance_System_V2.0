Public Class frm_Server
    Private Sub frm_Server_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frm_register.Show()
        Try
            TextBox3.Text = My.Settings.ipadd
            TextBox1.Text = My.Settings.userid
            TextBox2.Text = My.Settings.pssword

            If TextBox3.Text = "" Then
                Label4.ForeColor = Color.Red
                Label4.Text = "Please Enter IP Address!"
                TextBox3.Select()
                GroupBox1.Enabled = False
                TextBox1.Text = ""
                TextBox2.Text = ""
                CheckBox1.Checked = False
            Else
                If My.Computer.Network.Ping(TextBox3.Text) Then
                    Label4.Text = "IP Address Found"
                    Label4.ForeColor = Color.Green
                    GroupBox1.Enabled = True
                    CheckBox1.Checked = True
                    ' MsgBox("IP Address Found!", MsgBoxStyle.Information, "IP Found")
                Else
                    Label4.Text = "Network Connection is Not Available!"
                    Label4.ForeColor = Color.Red
                    GroupBox1.Enabled = False
                    TextBox3.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Network Error")
            Label4.Text = "Network Connection is Not Available!"
            Label4.ForeColor = Color.Red
            GroupBox1.Enabled = False
            TextBox3.Select()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox3.Text <> "" Then
                If My.Computer.Network.Ping(TextBox3.Text) Then
                    Label4.Text = "IP Address Found"
                    Label4.ForeColor = Color.Green
                    GroupBox1.Enabled = True
                    MsgBox("IP Address Found!", MsgBoxStyle.Information, "IP Found")
                    Button1.Select()
                Else
                    Label4.Text = "Network Connection is Not Available!"
                    Label4.ForeColor = Color.Red
                    GroupBox1.Enabled = False
                    TextBox3.Select()
                End If
            Else
                MsgBox("Please Enter IP address on the textbox!", MsgBoxStyle.Critical, "IP Address Error")
                TextBox3.Select()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Network Error")
            Label4.Text = "Either The Network Connection is Not Available, or the IP Address is Wrong!"
            Label4.ForeColor = Color.Red
            GroupBox1.Enabled = False
            Button3.Enabled = False
            TextBox3.Select()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox3.Text = "" Then
            MsgBox("Please Enter IP Address!", MsgBoxStyle.Exclamation, "Enter IP")
            TextBox3.Select()
            CheckBox1.Checked = False
            Exit Sub
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please Enter Database's User ID", MsgBoxStyle.Exclamation, "Enter User ID")
            TextBox1.Select()
            CheckBox1.Checked = False
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Enter Database's Password!", MsgBoxStyle.Exclamation, "Enter Password")
            TextBox2.Select()
            CheckBox1.Checked = False
            Exit Sub

        End If
        If CheckBox1.Checked = True Then
            My.Settings.ipadd = TextBox3.Text
            My.Settings.userid = TextBox1.Text
            My.Settings.pssword = TextBox2.Text
            My.Settings.Save()
        Else
            My.Settings.ipadd = ""
            My.Settings.userid = ""
            My.Settings.pssword = ""
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Then
            MsgBox("Please Enter IP Address!", MsgBoxStyle.Exclamation, "Enter IP")
            TextBox3.Select()
            Exit Sub
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please Enter Database's User ID", MsgBoxStyle.Exclamation, "Enter User ID")
            TextBox1.Select()
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Enter Database's Password!", MsgBoxStyle.Exclamation, "Enter Password")
            TextBox2.Select()
            Exit Sub
        End If
        ipadd = TextBox3.Text
        uid = TextBox1.Text
        passw = TextBox2.Text
        If CheckBox1.Checked = True Then
            My.Settings.ipadd = TextBox3.Text
            My.Settings.userid = TextBox1.Text
            My.Settings.pssword = TextBox2.Text
            My.Settings.Save()
        Else
            My.Settings.ipadd = ""
            My.Settings.userid = ""
            My.Settings.pssword = ""
            My.Settings.Save()
        End If
        selectedbutton = "ButtonTest"
        Call Test()
        Button3.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Then
            MsgBox("Please Enter IP Address!", MsgBoxStyle.Exclamation, "Enter IP")
            TextBox3.Select()
            CheckBox1.Checked = False
            Exit Sub
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please Enter Database's User ID", MsgBoxStyle.Exclamation, "Enter User ID")
            TextBox1.Select()
            CheckBox1.Checked = False
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Enter Database's Password!", MsgBoxStyle.Exclamation, "Enter Password")
            TextBox2.Select()
            CheckBox1.Checked = False
            Exit Sub

        End If
        If CheckBox1.Checked = True Then
            My.Settings.ipadd = TextBox3.Text
            My.Settings.userid = TextBox1.Text
            My.Settings.pssword = TextBox2.Text
            My.Settings.Save()
        Else
            My.Settings.ipadd = ""
            My.Settings.userid = ""
            My.Settings.pssword = ""
            My.Settings.Save()
        End If
        selectedbutton = "ButtonOK"
        Call Test()
    End Sub

    Private Sub frm_Server_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class