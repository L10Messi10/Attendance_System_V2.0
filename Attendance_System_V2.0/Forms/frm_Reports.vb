Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frm_Reports
    Public printWhere, Strreport As String
    Public mreport As New ReportDocument

    Private Sub frm_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        mreport = New ReportDocument()
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        With crConnectionInfo
            .ServerName = "CSReport"
            .DatabaseName = "attedance"
            .UserID = uid
            .Password = passw
        End With


        Select Case Strreport
            Case "CS"
                Me.Text = "CS Report Print Preview"

                mreport.Load("..\Reports\CSReport.rpt")
                CrTables = mreport.Database.Tables
                For Each CrTable In CrTables
                    crtableLogoninfo = CrTable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo
                    CrTable.ApplyLogOnInfo(crtableLogoninfo)
                Next
                mreport.RecordSelectionFormula = printWhere


        End Select
        CrystalReportViewer1.ReportSource = mreport
        CrystalReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
    End Sub
End Class