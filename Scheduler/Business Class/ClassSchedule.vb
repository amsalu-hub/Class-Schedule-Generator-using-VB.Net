Imports System.Data.SqlClient
Public Class ClassSchedule
    Private _Course_ID As String
    Private _Teacher_ID As String
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
            Return _Block_NO
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
    Public Function save(ByVal classschedule As ClassSchedule) As Boolean
        Try
            'MsgBox("day" + classschedule.Schedule_day + "per" + classschedule.Period)
            Dim query As String = "INSERT INTO Class_schedule VALUES ('" + classschedule.Course_ID + "','" + classschedule.Teacher_ID + "','" + classschedule.Section_ID + "','" + classschedule.Room_no + "','" + classschedule.Block_no + "','" + classschedule.Schedule_day + "','" + classschedule.Period + "')"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal classschedule As ClassSchedule) As Boolean
        Try
            Dim query As String = "update Class_schedule set Course_ID='" + classschedule.Course_ID + "',Teacher_ID='" + classschedule.Teacher_ID + "',Section_ID='" + classschedule.Section_ID + "',Room_ID='" + classschedule.Room_no + "',Block_no='" + classschedule.Block_no + "',Schedule_day='" + classschedule.Schedule_day + "',Schedule_period='" + classschedule.Period + "'"
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
            Dim query As String = "delete Class_schedule where Schedule_ID= '" + schedule_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub Loadclasschedule(ByVal lvclasschedule As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            lvclasschedule.Items.Clear()
            Dim i As Integer = 0
            While reader.Read()
                lvclasschedule.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(8)))
                lvclasschedule.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(9)))
                i = i + 1
            End While
            reader.Close()
            If lvclasschedule.Items.Count > 0 Then
                Try
                    lvclasschedule.Items(0).Focused = True
                    lvclasschedule.Items(0).Selected = True
                    lvclasschedule.Items(0).EnsureVisible()
                    lvclasschedule.Focus()
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
