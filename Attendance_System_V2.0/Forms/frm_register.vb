Public Class frm_register
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroButton1.Text = "Activate Trial" Then
            My.Settings.TrailActive = "True"
            My.Settings.StartDate = Date.Today
            My.Settings.TrialUsed = "False"
            My.Settings.Save()
            MsgBox("You have activated your free Trial for 15 Days", MsgBoxStyle.Information, "Trial Activated")
            Hide()
            frm_Server.Show()
        Else
            CheckDate()
        End If
    End Sub
    Sub CheckDate()
        Dim dt As Date = My.Settings.StartDate
        Dim days As Double = (Date.Now.AddDays(-15).Subtract(dt)).TotalDays
        If days <= 0 Then
            MetroButton1.Enabled = False
            My.Settings.TrailActive = "True"
            My.Settings.Save()
            MsgBox("You Only have " & days & " days on using this product", MsgBoxStyle.Information, "Trial Period")
            Me.Hide()
            frm_Server.Show()

        Else
            My.Settings.TrailActive = "False"
            My.Settings.TrialUsed = "True"
            My.Settings.Save()
            MsgBox("You Trial Period has ended! Please Purchase an Activation Key!", MsgBoxStyle.Information, "Trial Period")
            MetroTextBox1.Select()
        End If
    End Sub

    Private Sub frm_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim act As String
        act = My.Settings.TrailActive
        If act = "False" Then
            MetroButton1.Text = "Activate Trial"
        Else
            MetroButton1.Text = "Check Remaining Days"
        End If
        Call CheckActivation()
        'CheckDate()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If MetroTextBox1.Text <> "" Then
            If MetroTextBox1.Text = "187-987-990" Then
                My.Settings.Activation = "True"
                My.Settings.Save()
                MsgBox("Thank you for Purchasing this product!", MsgBoxStyle.Information, "Product Activated")
                Hide()
                frm_Server.Show()
            Else
                MsgBox("Invalid Product Key!", MsgBoxStyle.Exclamation, "Invalid Key")
                MetroTextBox1.Select()
            End If
        Else
            MsgBox("Please Enter a valid Product Key!", MsgBoxStyle.Exclamation, "Product Key")
            MetroTextBox1.Select()
        End If
    End Sub
    Sub CheckActivation()
        ' On Error Resume Next
        Dim acti As String
        acti = My.Settings.Activation
        'MetroButton2.Text = My.Settings.Activation
        If acti = "True" Then
            MsgBox("Thank you for Purchasing this product!", MsgBoxStyle.Information, "Product Activated")

            Hide()
            'Refresh()
            frm_Server.Show()
        End If
    End Sub
End Class