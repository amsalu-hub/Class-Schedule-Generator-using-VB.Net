Imports System.Data.SqlServerCe
Public Class GenerateLabSchedule
    Private dataaccess As New DataAccessClass
    Private labschedule As New LabSchedule
     Dim days() As String = New String() {"Mo", "Tu", "We", "Th", "Fr"}
    Dim periods() As String = New String() {"2,3,4", "5,6,7", "6,7,8"}
    Dim indexdays As Integer = 0
    Public Function CheckClassSchedule(ByVal day As Integer, ByVal period As Integer) As Boolean
        Try
            Dim query As String = ""
            If period = 0 Then
                query = "select*from Class_schedule where Section_ID='" + labschedule.Section_ID + "' and Schedule_day='" + days(day).ToString + "' and (Schedule_period='2' or Schedule_period='3' or Schedule_period='4' or Schedule_period='1,2' or Schedule_period='2,3' or Schedule_period='3,4' or Schedule_period='4,5')"
            ElseIf period = 1 Then
                query = "select*from Class_schedule where Section_ID='" + labschedule.Section_ID + "' and Schedule_day='" + days(day).ToString + "' and (Schedule_period='5' or Schedule_period='6' or Schedule_period='7' or Schedule_period='4,5' or Schedule_period='5,6' or Schedule_period='6,7' or Schedule_period='7,8')"
            ElseIf period = 2 Then
                query = "select*from Class_schedule where Section_ID='" + labschedule.Section_ID + "' and Schedule_day='" + days(day).ToString + "' and (Schedule_period='6' or Schedule_period='7' or Schedule_period='8' or Schedule_period='5,6' or Schedule_period='6,7' or Schedule_period='7,8')"
            End If
            If dataaccess.ExecuteScalar(query) = "" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function GenerateSchedule(ByVal school As String, ByVal section As String) As Boolean
        Try
            Dim cods As DataSet = dataaccess.ReturnDataset("select Course.Course_ID,Course_offerred.Teacher_ID,Course_offerred.Section_ID,Course_offerred.Asistant_ID from Course,Course_offerred where Course.Requires_lab='Yes' and Course_offerred.Schedule_status='Yes' and Course.Course_ID=Course_offerred.Course_ID and Course_offerred.Section_ID='" + section + "'")
            Dim ds As DataSet = dataaccess.ReturnDataset("select Room_ID,Block_no from Room where Room_type='Lab room' and School_name='" + school + "'")
            Dim rooms_asigned As Integer = ds.Tables(0).Rows.Count
            Dim query As String = ""
            Dim offereds As Integer = 0
            Dim scheduled As Boolean = False
            If rooms_asigned > 0 Then
                If cods.Tables(0).Rows.Count > 0 Then
                    While offereds < cods.Tables(0).Rows.Count
                        indexdays = 0
                        labschedule.Course_ID = cods.Tables(0).Rows(offereds).Item(0).ToString
                        labschedule.Teacher_ID = cods.Tables(0).Rows(offereds).Item(1).ToString
                        labschedule.Asistant_ID = cods.Tables(0).Rows(offereds).Item(3).ToString
                        labschedule.Section_ID = cods.Tables(0).Rows(offereds).Item(2).ToString
                        For i = 0 To 4     'days of week
                            For j = 0 To 2   'periods
                                If j = 1 Or j = 2 Then
                                    query = "' and (Schedule_period='" + periods(1).ToString + "' or Schedule_period='" + periods(2).ToString + "')"
                                Else
                                    query = "' and Schedule_period='" + periods(j).ToString + "'"
                                End If
                                If dataaccess.ExecuteScalar("select*from Lab_schedule where Asistant_ID='" + labschedule.Asistant_ID + "' and Schedule_day='" + days(i).ToString + query) = "" And dataaccess.ExecuteScalar("select*from Lab_schedule where Section_ID='" + labschedule.Section_ID.ToString + "' and Schedule_day='" + days(i).ToString + query) = "" And CheckClassSchedule(i, j) Then
                                    For k = 0 To ds.Tables(0).Rows.Count - 1
                                        If dataaccess.ExecuteScalar("select*from Lab_schedule where Room_ID='" + ds.Tables(0).Rows(k).Item(0).ToString + "'and Schedule_day='" + days(i).ToString + query) = "" Then
                                            labschedule.Schedule_day = days(i) 'AssignPeriod("two")
                                            labschedule.Period = periods(j)
                                            labschedule.Room_no = ds.Tables(0).Rows(k).Item(0).ToString
                                            labschedule.Block_no = ds.Tables(0).Rows(k).Item(1).ToString
                                            If labschedule.save(labschedule) Then
                                                scheduled = True
                                                dataaccess.ExecuteNonQuery("update Course_offerred set Requires_lab='No' where Course_ID='" + cods.Tables(0).Rows(offereds).Item(0).ToString + "'and Teacher_ID='" + cods.Tables(0).Rows(offereds).Item(1).ToString + "' and Section_ID='" + labschedule.Section_ID + "'")
                                                GoTo asignanother
                                            End If
                                        End If
                                    Next
                                End If
                            Next
                        Next
asignanother:
                        offereds = offereds + 1
                    End While
                Else
                    MessageBox.Show("No course which needs laboratory is offerred for this section", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No laboratory room is asigned for this school", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return scheduled
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
