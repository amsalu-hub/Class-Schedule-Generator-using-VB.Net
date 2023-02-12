Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class ViewClassSchedule
    Private classschedule As New ClassSchedule
    Private labschedule As New LabSchedule
    Private dataaccess As New DataAccessClass
    Private Function GetSectionNo(ByVal program As String, ByVal academic_year As String, ByVal section_no As String) As String
        Dim secno As String = ""
        Try
            secno = dataaccess.ExecuteScalar("select Section_ID from Section where Academic_year='" + academic_year + "' and Program='" + program + "' and Section_no='" + section_no + "'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return secno
    End Function

    Private Sub btnViewclassSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewclassSchedule.Click
        Try
            Dim query As String = "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID) on Course.Course_ID=Class_schedule.Course_ID"
            If cmbseclassschedule.SelectedItem = "Teacher" Then
                query = "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID and class_schedule.Teacher_ID='" + txtvalueclassschedule.Text + "') on Course.Course_ID=Class_schedule.Course_ID"
            ElseIf cmbseclassschedule.SelectedItem = "Course" Then
                query = "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID) on Course.Course_ID=Class_schedule.Course_ID and Class_schedule.Course_ID='" + txtvalueclassschedule.Text + "'"
            ElseIf cmbseclassschedule.SelectedItem = "Room" Then
                query = "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID) on Course.Course_ID=Class_schedule.Course_ID and Class_schedule.Room_no='" + txtvalue2.Text + "' and Class_schedule.Block_no='" + txtvalueclassschedule.Text + "'"
            ElseIf cmbseclassschedule.SelectedItem = "Section" Then
                query = "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID) on Course.Course_ID=Class_schedule.Course_ID and Class_schedule.Section_ID='" + GetSectionNo(txtvalueclassschedule.Text, txtvalue2.Text, txtvalue3.Text) + "'"
            End If
            classschedule.Loadclasschedule(lvClassSchedule, query)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ViewClassSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        classschedule.Loadclasschedule(lvClassSchedule, "select Class_schedule.CSchedule_ID,Course.Course_ID,Course.Title,Course.Chr,Teacher.Fname,Class_schedule.Section_ID,Class_schedule.Block_no,Class_schedule.Room_no,Class_schedule.Schedule_day,Class_schedule.Schedule_period from Course inner join (Teacher inner join Class_schedule on Teacher.Teacher_ID=Class_schedule.Teacher_ID) on Course.Course_ID=Class_schedule.Course_ID")
        labschedule.LoadLabschedule(lvLabSchedule, "select Lab_schedule.LSchedule_ID,Course.Course_ID,Course.Title,Teacher.Fname,Teacher.Fname,Lab_schedule.Section_ID,Lab_schedule.Block_no,Lab_schedule.Room_no,Lab_schedule.Schedule_day,Lab_schedule.Schedule_period from Course inner join (Teacher inner join Lab_schedule on Teacher.Teacher_ID=Lab_schedule.Teacher_ID) on Course.Course_ID=Lab_schedule.Course_ID")
        lblvalue2.Visible = False
        lblvalue3.Visible = False
        txtvalue2.Visible = False
        txtvalue3.Visible = False
    End Sub

    Private Sub cmbseclassschedule_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbseclassschedule.SelectedIndexChanged
        If cmbseclassschedule.SelectedItem = "Section" Then
            Label2.Text = "Prog"
            lblvalue2.Text = "A.year"
            lblvalue3.Text = "Sec"
            lblvalue2.Visible = True
            lblvalue3.Visible = True
            txtvalue2.Visible = True
            txtvalue3.Visible = True
            txtvalue2.Clear()
            txtvalue3.Clear()
            txtvalueclassschedule.Clear()
            ' btnViewclassSchedule
        ElseIf cmbseclassschedule.SelectedItem = "Room" Then
            Label2.Text = "B No"
            lblvalue2.Text = "R No "
            lblvalue2.Visible = True
            lblvalue3.Visible = False
            txtvalue2.Visible = True
            txtvalue3.Visible = False
            txtvalue2.Clear()
            txtvalue3.Clear()
            txtvalueclassschedule.Clear()
        Else
            lblvalue2.Visible = False
            lblvalue3.Visible = False
            txtvalue2.Visible = False
            txtvalue3.Visible = False
            Label2.Text = "ID"
            txtvalue2.Clear()
            txtvalue3.Clear()
            txtvalueclassschedule.Clear()
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim listview As New ListView
            If TabControl1.SelectedTab Is tpclassschedule Then
                listview = lvClassSchedule
            ElseIf TabControl1.SelectedTab Is tplabschedule Then
                listview = lvLabSchedule
            End If
            Dim objExcel As New Excel.Application
            Dim bkWorkBook As Workbook
            Dim shWorkSheet As Worksheet
            Dim i As Integer
            Dim j As Integer

            objExcel = New Excel.Application
            bkWorkBook = objExcel.Workbooks.Add
            shWorkSheet = CType(bkWorkBook.ActiveSheet, Worksheet)
            For i = 0 To listview.Columns.Count - 1
                shWorkSheet.Cells(1, i + 1) = listview.Columns(i).Text
            Next
            For i = 0 To listview.Items.Count - 1
                For j = 0 To listview.Items(i).SubItems.Count - 1
                    shWorkSheet.Cells(i + 2, j + 1) = listview.Items(i).SubItems(j).Text
                Next
            Next
            objExcel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        MsgBox("Service under construction!! will be available soon")
    End Sub
End Class