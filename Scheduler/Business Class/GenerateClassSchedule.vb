Imports System.Data.SqlServerCe
Public Class GenerateClassSchedule
    Private dataaccess As New DataAccessClass
    Private classschedule As New ClassSchedule
    Dim daysassigned() As String = New String() {"", "", "", "", "", "", ""}
    Dim days() As String = New String() {"Mo", "Tu", "We", "Th", "Fr"}
    Dim twoperiods() As String = New String() {"1,2", "2,3", "3,4", "4,5", "5,6", "6,7", "7,8"}
    Dim oneperiod() As String = New String() {"1", "2", "3", "4", "5", "6", "7", "8"}
    Dim indexdays As Integer = 0
    Public Function AssignDay(ByVal day As String) As Boolean
        Try
            Dim yes As Boolean = False
            For i = 0 To indexdays
                If day = daysassigned(i).ToString Then
                    yes = True
                End If
            Next
            Return yes
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function GenerateSchedule(ByVal school As String, ByVal section As String) As Boolean
        Try
            Dim cods As DataSet = dataaccess.ReturnDataset("select*from Course_offerred where Schedule_status='No' and Section_ID='" + section + "'")
            Dim ds As DataSet = dataaccess.ReturnDataset("select Room_ID,Block_no from Room where Room_type='Class room' and School_name='" + school + "'")
            Dim rooms_asigned As Integer = ds.Tables(0).Rows.Count
            Dim query As String
            Dim offereds As Integer = 0
            Dim scheduled As Boolean = False
            Dim crhr As Integer
            If rooms_asigned > 0 Then
                If cods.Tables(0).Rows.Count > 0 Then
                    While offereds < cods.Tables(0).Rows.Count
                        indexdays = 0
                        classschedule.Course_ID = cods.Tables(0).Rows(offereds).Item(0).ToString
                        classschedule.Teacher_ID = cods.Tables(0).Rows(offereds).Item(1).ToString
                        classschedule.Section_ID = cods.Tables(0).Rows(offereds).Item(4).ToString

                        crhr = dataaccess.ExecuteScalar("select Chr from Course where Course_ID='" + classschedule.Course_ID + "'")
anotherperiod:
                        While crhr > 0
                            If crhr >= 2 Then
                                For i = 0 To 4     'days of week
                                    If Not AssignDay(days(i)) Then
                                        For j = 0 To 6   'twoperiods
                                            If j = 6 Then
                                                query = "' and (Schedule_period='" + twoperiods(j - 1).ToString + "'or Schedule_period='" + twoperiods(j).ToString + "'or Schedule_period='" + twoperiods(j).Substring(0, 1).ToString + "' or Schedule_period='" + twoperiods(j).Substring(2).ToString + "')"
                                            ElseIf j > 0 Then
                                                query = "' and (Schedule_period='" + twoperiods(j - 1).ToString + "'or Schedule_period='" + twoperiods(j).ToString + "'or Schedule_period='" + twoperiods(j + 1).ToString + "'or Schedule_period='" + twoperiods(j).Substring(0, 1).ToString + "' or Schedule_period='" + twoperiods(j).Substring(2).ToString + "')"
                                            Else
                                                query = "'and (Schedule_period='" + twoperiods(j).ToString + "'or Schedule_period='" + twoperiods(j + 1).ToString + "'or Schedule_period='" + twoperiods(j).Substring(0, 1).ToString + "' or Schedule_period='" + twoperiods(j).Substring(2).ToString + "')"
                                            End If
                                            If dataaccess.ExecuteScalar("select * from Class_schedule where Teacher_ID='" + classschedule.Teacher_ID.ToString + "' and Schedule_day='" + days(i).ToString + query) = "" And dataaccess.ExecuteScalar("select*from Class_schedule where Section_ID='" + classschedule.Section_ID.ToString + "' and Schedule_day='" + days(i).ToString + query) = "" Then
                                                For k = 0 To ds.Tables(0).Rows.Count - 1
                                                    If dataaccess.ExecuteScalar("select*from Class_schedule where Room_ID='" + ds.Tables(0).Rows(k).Item(0).ToString + "'and Schedule_day='" + days(i).ToString + query) = "" Then
                                                        classschedule.Schedule_day = days(i).ToString  'AssignPeriod("two")
                                                        classschedule.Period = twoperiods(j).ToString
                                                        classschedule.Room_no = ds.Tables(0).Rows(k).Item(0).ToString
                                                        classschedule.Block_no = ds.Tables(0).Rows(k).Item(1).ToString
                                                        If classschedule.save(classschedule) Then
                                                            crhr = crhr - 2
                                                            daysassigned(indexdays) = classschedule.Schedule_day
                                                            indexdays = indexdays + 1
                                                            scheduled = True
                                                            dataaccess.ExecuteNonQuery("update Course_offerred set Schedule_status='Yes' where Course_ID='" + classschedule.Course_ID + "'and Teacher_ID='" + classschedule.Teacher_ID + "' and Section_ID='" + classschedule.Section_ID + "'")
                                                            GoTo anotherperiod
                                                        End If
                                                    Else
                                                    End If
                                                Next
                                            Else
                                            End If
                                        Next
                                    End If
                                Next
                            Else
                                For i = 0 To 4  'days of week
                                    If Not AssignDay(days(i)) Then
                                        For j = 0 To 7  'periods
                                            If j = 7 Then
                                                query = "' and (Schedule_period='" + oneperiod(j).ToString + "' or Schedule_period='" + oneperiod(j - 1).ToString + oneperiod(j).ToString + "')"
                                            ElseIf j > 0 Then
                                                query = "' and (Schedule_period='" + oneperiod(j).ToString + "' or Schedule_period='" + oneperiod(j - 1).ToString + oneperiod(j).ToString + "' or Schedule_period='" + oneperiod(j).ToString + oneperiod(j + 1).ToString + "')"
                                            Else
                                                query = "' and (Schedule_period='" + oneperiod(j).ToString + "' or Schedule_period='" + oneperiod(j).ToString + oneperiod(j + 1).ToString + "')"
                                            End If
                                            If dataaccess.ExecuteScalar("select*from Class_schedule where Teacher_ID='" + classschedule.Teacher_ID.ToString + "' and Schedule_day='" + days(i) + query) = "" And dataaccess.ExecuteScalar("select*from Class_schedule where Section_ID='" + classschedule.Section_ID.ToString + "' and Schedule_day='" + days(i).ToString + query) = "" Then
                                                For k = 0 To ds.Tables(0).Rows.Count - 1
                                                    If dataaccess.ExecuteScalar("select*from Class_schedule where Room_ID='" + ds.Tables(0).Rows(k).Item(0).ToString + "'and Schedule_day='" + days(i).ToString + query) = "" Then
                                                        classschedule.Schedule_day = days(i) 'AssignPeriod("two")
                                                        classschedule.Period = oneperiod(j)
                                                        classschedule.Room_no = ds.Tables(0).Rows(k).Item(0).ToString
                                                        classschedule.Block_no = ds.Tables(0).Rows(k).Item(1).ToString
                                                        If classschedule.save(classschedule) Then
                                                            crhr = crhr - 1
                                                            daysassigned(indexdays) = classschedule.Schedule_day
                                                            indexdays = indexdays + 1
                                                            scheduled = True
                                                            dataaccess.ExecuteNonQuery("update Course_offerred set Schedule_status='Yes' where Course_ID='" + classschedule.Course_ID + "'and Teacher_ID='" + classschedule.Teacher_ID + "' and Section_ID='" + classschedule.Section_ID + "'")
                                                            GoTo anotherperiod
                                                        End If
                                                    End If
                                                Next
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        End While
                        offereds = offereds + 1
                    End While
                Else
                    MessageBox.Show("No course is offerred for this section." + vbNewLine + " Or all the courses offered where scheduled.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No class room is asigned for this school." + vbNewLine + " Or all classrooms of this school were reserved for other sections.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return scheduled
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
