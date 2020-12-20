Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Public Class frm_GenReports
    Dim fileRPT As String
    Private Sub frm_GenReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fillcombo()
    End Sub
    Sub Fillcombo()
        '****For Courses Report

        '********************************************
        'SY / SEM / TERM for courses
        ListView1.Items.Clear()
        connect()
        'replaced
        strsql = "Select distinct sy_sem_term from attendance_view"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ComboBox2.Items.Clear()

        Do While sqlreader.Read = True
            ComboBox2.Items.Add(sqlreader("sy_sem_term"))

        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
        '********************************************
        'course
        ComboBox3.Items.Clear()

        Label4.Text = Label2.Text
        Label5.Text = "Null"
        Label6.Text = "Course:"
        Label7.Text = "Null"
        Label9.Text = "0 Hour(s)"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call CRO()
    End Sub
    Sub CRO()
        ' On Error Resume Next
        If ComboBox2.Text <> "" And ComboBox3.Text <> "" Then
            Dim fines, fins_hrs, temp, cs_hrs, ttl_fine As String
            connect()
            'replaced
            strsql = "Select * from v_report where sy_sem_term='" & ComboBox2.Text & "' and course_desc='" & ComboBox3.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqladapter.SelectCommand = sqlcmd
            sqlreader = sqlcmd.ExecuteReader
            ListView1.Items.Clear()
            Do While sqlreader.Read = True
                With ListView1.Items.Add(sqlreader("stud_id"), 0)
                    .SubItems.Add(sqlreader("lname"))
                    .SubItems.Add(sqlreader("fname"))
                    .SubItems.Add(sqlreader("course_desc"))
                    .SubItems.Add(sqlreader("totalcs"))
                    fins_hrs = sqlreader("fines_hours")
                    cs_hrs = (sqlreader("totalcs"))
                    temp = Val(cs_hrs) / Val(fins_hrs)
                    fines = sqlreader("fines_amount")
                    ttl_fine = temp * fines
                    .SubItems.Add(ttl_fine)
                    ttl_fine = 0
                    cs_hrs = 0
                    fines = 0
                End With
            Loop
            sqlcmd.Dispose()
            sqlreader.Close()
            sqlcon.Close()
            Label4.Text = Label2.Text
            Label5.Text = ComboBox2.Text
            Label6.Text = "Course"
            Label7.Text = ComboBox3.Text
            connect()
            'replaced
            strsql = "Select sum(attendance_ttl_cs) as ttlCS from attendance_view where sy_sem_term='" & ComboBox2.Text & "' and course_desc='" & ComboBox3.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlcon
            sqladapter.SelectCommand = sqlcmd
            sqlreader = sqlcmd.ExecuteReader
            If sqlreader.Read Then
                Label9.Text = "Total CS: " & sqlreader("ttlCS") & " Hour(s)"
            Else
                Label9.Text = "0 Hour(s)"
            End If

        Else
            MsgBox("Please Select an Event and Department!", MsgBoxStyle.Exclamation, "Display")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Sub Export_Excel()
        'Try
        Me.Cursor = Cursors.WaitCursor
            'Export the listview to an Excel spreadsheet
            SaveFileDialog1.Title = "Save Excel File"
            SaveFileDialog1.FileName = fileRPT
            SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
            SaveFileDialog1.ShowDialog()
            'exit if no file selected
            If SaveFileDialog1.FileName = "" Then
                Exit Sub
            End If
            'create objects to interface to Excel
            Dim xls As New Excel.Application
            Dim book As Excel.Workbook
            Dim sheet As Excel.Worksheet
            'create a workbook and get reference to first worksheet

            xls.Workbooks.Add()
            book = xls.ActiveWorkbook
            sheet = book.ActiveSheet

            'step through rows and columns and copy data to worksheet
            Dim row As Integer = 1
            Dim col As Integer = 1

            '///////Displaying Column

            'Dim col As Integer = 1
            For j As Integer = 0 To ListView1.Columns.Count - 1

                sheet.Cells(1, col) = ListView1.Columns(j).Text.ToString

                col = col + 1

            Next

            'Fethching data from the listview
            For i = 0 To ListView1.Items.Count - 1
            sheet.Cells(i + 2, 1) = ListView1.Items.Item(i).Text.ToString
            'sheet.Range(i + 2, 1).Cells.Locked = True
            sheet.Cells(i + 2, 2) = ListView1.Items.Item(i).SubItems(1).Text
            ' sheet.Range(i + 2, 2).Cells.Locked = True
            sheet.Cells(i + 2, 3) = ListView1.Items.Item(i).SubItems(2).Text
            'sheet.Range(i + 2, 3).Cells.Locked = True
            sheet.Cells(i + 2, 4) = ListView1.Items.Item(i).SubItems(3).Text
            ' sheet.Range(i + 2, 4).Cells.Locked = True
            sheet.Cells(i + 2, 5) = ListView1.Items.Item(i).SubItems(4).Text
            'sheet.Range(i + 2, 5).Cells.Locked = True
            sheet.Cells(i + 2, 6) = ListView1.Items.Item(i).SubItems(5).Text
            ' sheet.Range(i + 2, 6).Cells.Locked = True
            'sheet.Cells(i + 2, 7) = ListView1.Items.Item(i).SubItems(6).Text
            'sheet.Cells(i + 2, 8) = ListView1.Items.Item(i).SubItems(7).Text
            'sheet.Cells(i + 2, 9) = ListView1.Items.Item(i).SubItems(8).Text
            'sheet.Cells(i + 2, 10) = ListView1.Items.Item(i).SubItems(9).Text
            'sheet.Cells(i + 2, 11) = ListView1.Items.Item(i).SubItems(10).Text
            'sheet.Cells(i + 2, 12) = ListView1.Items.Item(i).SubItems(11).Text
            'sheet.Cells(i + 2, 13) = ListView1.Items.Item(i).SubItems(12).Text
            'sheet.Cells(i + 2, 14) = ListView1.Items.Item(i).SubItems(13).Text
        Next

        'save the workbook and clean up
        sheet.Rows.Item(1).EntireColumn.AutoFit()
        book.SaveAs(SaveFileDialog1.FileName)
        xls.Workbooks.Close()
            xls.Quit()
            releaseObject(sheet)
            releaseObject(book)
            releaseObject(xls)
            Cursor = Cursors.Default
        'Catch ex As Exception
        '    Exit Sub
        'End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox2.Text <> "" And ComboBox3.Text <> "" Then
            fileRPT = ComboBox2.Text + ComboBox3.Text
            Call Export_Excel()
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If ComboBox2.Text = "" And ComboBox3.Text = "" And ListView1.Items.Count = 0 Then Exit Sub : 
        If MsgBox("Are you Sure to Clear the Result?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Fillcombo()
        End If
    End Sub

    Private Sub ComboBox2_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox2.DropDownClosed
        connect()
        'replaced
        strsql = "Select distinct course_desc from attendance_view where sy_sem_term='" & ComboBox2.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlcon
        sqladapter.SelectCommand = sqlcmd
        sqlreader = sqlcmd.ExecuteReader
        ComboBox3.Items.Clear()

        Do While sqlreader.Read = True
            ComboBox3.Items.Add(sqlreader("course_desc"))
        Loop
        sqlcmd.Dispose()
        sqlreader.Close()
        sqlcon.Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If ComboBox2.Text = "" Then
            MsgBox("Please Select Academic Year and Semester!", MsgBoxStyle.Exclamation, "Print")
            Exit Sub
        ElseIf ComboBox3.Text = "" Then
            MsgBox("Please Select a Course!", MsgBoxStyle.Exclamation, "Print")
            Exit Sub
        ElseIf ListView1.Items.Count = 0 Then
            MsgBox("The List is Empty, there is nothing to Print as of this moment!", MsgBoxStyle.Exclamation, "Nothing to Print")
            Exit Sub
        Else
            With frm_Reports
                .Strreport = "CS"
                .printWhere = "{V_Report.sy_sem_term}='" & ComboBox2.Text & "' And {V_Report.course_desc}='" & ComboBox3.Text & "'"
                .ShowDialog()
            End With
        End If
    End Sub
End Class