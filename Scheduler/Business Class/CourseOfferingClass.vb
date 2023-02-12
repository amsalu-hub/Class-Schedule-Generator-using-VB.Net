Imports System.Data.SqlClient
Public Class CourseOffer
    Private _Course_ID As String
    Private _Teacher_ID As String
    Private _Section_ID As String
    Private _Schedule_status As String
    Private _Asistant_ID As String
    Dim dataaccess As New DataAccessClass
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
    Public Property Schedule_status() As String
        Get
            Return _Schedule_status
        End Get
        Set(ByVal value As String)
            _Schedule_status = value
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
#End Region
#Region "methods"
    Public Function save(ByVal courseoffered As CourseOffer) As Boolean
        Try
            Dim query As String = "INSERT INTO Course_offerred VALUES ('" + courseoffered.Course_ID + "','" + courseoffered.Teacher_ID + "','" + courseoffered.Section_ID + "','" + courseoffered.Schedule_status + "','" + courseoffered.Section_ID + "','No','" + "','" + courseoffered.Asistant_ID + "')"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal courseoffered As CourseOffer) As Boolean
        Try
            Dim query As String = "update Course_offerred set Course_ID='" + courseoffered.Course_ID + "',Teacher_ID='" + courseoffered.Teacher_ID + "',Section_ID='" + courseoffered.Section_ID + "',Sechedule_status='" + courseoffered.Schedule_status + "',Asistant_ID='" + courseoffered.Asistant_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal course_ID As String, ByVal teacher_id As String, ByVal program As String, ByVal accyear As String, ByVal sec As String) As Boolean
        Try
            Dim query As String = "delete Course_offerred where Course_ID= '" + course_ID + "' and Teacher_ID='" + teacher_id + "' and Section_ID='" + sec + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadCourseOfferred(ByVal lvcourseoffered As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            lvcourseoffered.Items.Clear()
            Dim i As Integer = 0
            While reader.Read()
                lvcourseoffered.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                'lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                'lvcourseoffered.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                i = i + 1
            End While
            reader.Close()
            If lvcourseoffered.Items.Count > 0 Then
                Try
                    lvcourseoffered.Items(0).Focused = True
                    lvcourseoffered.Items(0).Selected = True
                    lvcourseoffered.Items(0).EnsureVisible()
                    lvcourseoffered.Focus()
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
