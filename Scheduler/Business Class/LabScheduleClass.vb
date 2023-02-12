Imports System.Data.SqlClient
Public Class LabSchedule
    Private _Course_ID As String
    Private _Teacher_ID As String
    Private _Asistant_ID As String
    Private _Section_ID As String
    Private _Room_no As String
    Private _Block_no As String
    Private _Schedule_day As String
    Private _Period As String
    Private dataaccess As New DataAccessClass
#Region "properties..."
    Public Property Course_ID() As String
        Get
            Return _Course_ID
        End Get
        Set(ByVal value As String)
            _Course_ID = value
        End Set
    End Property
    Public Property Teacher_ID() As String
        Get
            Return _Teacher_ID
        End Get
        Set(ByVal value As String)
            _Teacher_ID = value
        End Set
    End Property
    Public Property Asistant_ID() As String
        Get
            Return _Asistant_ID
        End Get
        Set(ByVal value As String)
            _Asistant_ID = value
        End Set
    End Property
    Public Property Section_ID() As String
        Get
            Return _Section_ID
        End Get
        Set(ByVal value As String)
            _Section_ID = value
        End Set
    End Property
    Public Property Room_no() As String
        Get
            Return _Room_no
        End Get
        Set(ByVal value As String)
            _Room_no = value
        End Set
    End Property
    Public Property Block_no() As String
        Get
            Return _Block_no
        End Get
        Set(ByVal value As String)
            _Block_NO = value
        End Set
    End Property
    Public Property Schedule_day() As String
        Get
            Return _Schedule_day
        End Get
        Set(ByVal value As String)
            _Schedule_day = value
        End Set
    End Property
    Public Property Period() As String
        Get
            Return _Period
        End Get
        Set(ByVal value As String)
            _Period = value
        End Set
    End Property
#End Region
#Region "methods..."
    Public Function save(ByVal labschedule As LabSchedule) As Boolean
        Try
            Dim query As String = "INSERT INTO Lab_schedule VALUES ('" + labschedule.Course_ID + "','" + labschedule.Teacher_ID + "','" + labschedule.Asistant_ID + "','" + labschedule.Section_ID + "','" + labschedule.Room_no + "','" + labschedule.Block_no + "','" + labschedule.Schedule_day + "','" + labschedule.Period + "')"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal labschedule As LabSchedule) As Boolean
        Try
            Dim query As String = "update Lab_schedule set Course_ID='" + labschedule.Course_ID + "',Asistant_ID='" + labschedule.Asistant_ID + "',Teacher_ID='" + labschedule.Teacher_ID + "',Section_ID='" + labschedule.Section_ID + "',Room_no='" + labschedule.Room_no + "',Block_no='" + labschedule.Block_no + "',Schedule_day='" + labschedule.Schedule_day + "',Schedule_period='" + labschedule.Period + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal schedule_ID As String) As Boolean
        Try
            Dim query As String = "delete Lab_schedule where Schedule_ID= '" + schedule_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadLabschedule(ByVal lvlabschedule As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            lvlabschedule.Items.Clear()
            Dim i As Integer = 0
            While reader.Read()
                lvlabschedule.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(8)))
                'lvlabschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(9)))
                i = i + 1
            End While
            reader.Close()
            If lvlabschedule.Items.Count > 0 Then
                Try
                    lvlabschedule.Items(0).Focused = True
                    lvlabschedule.Items(0).Selected = True
                    lvlabschedule.Items(0).EnsureVisible()
                    lvlabschedule.Focus()
                Catch aooreE As ArgumentOutOfRangeException
                Catch nreE As NullReferenceException
                End Try
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
End Class
