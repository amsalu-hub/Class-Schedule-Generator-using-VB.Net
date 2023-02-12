Imports System.Data.SqlClient
Public Class Course
    Private _Course_ID As String
    Private _Title As String
    Private _ECTS As Integer
    Private _Chr As String
    Private _Requires_lab As String
    Private _Program As String
    Private _Class_year As String
    Private _Semester As String
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
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property
    Public Property ECTS() As Integer
        Get
            Return _ECTS
        End Get
        Set(ByVal value As Integer)
            _ECTS = value
        End Set
    End Property

    Public Property Chr() As String
        Get
            Return _Chr
        End Get
        Set(ByVal value As String)
            _Chr = value
        End Set
    End Property
    Public Property Requires_lab() As String
        Get
            Return _Requires_lab
        End Get
        Set(ByVal value As String)
            _Requires_lab = value
        End Set
    End Property
    Public Property Program() As String
        Get
            Return _Program
        End Get
        Set(ByVal value As String)
            _Program = value
        End Set
    End Property
    Public Property Class_year() As String
        Get
            Return _Class_year
        End Get
        Set(ByVal value As String)
            _Class_year = value
        End Set
    End Property
    Public Property Semester() As String
        Get
            Return _Semester
        End Get
        Set(ByVal value As String)
            _Semester = value
        End Set
    End Property
#End Region
#Region "methods"
    Public Function save(ByVal course As Course) As Boolean
        Try
            Dim query As String = "INSERT INTO Course VALUES ('" + course.Course_ID + "','" + course.Title + "','" + course.ECTS + "','" + course.Chr + "','" + course.Requires_lab + "','" + course.Class_year + "','" + course.Program + "','" + course.Semester + "')"
            Dim testquery As String = "select*from Course where Course_ID='" + course.Course_ID + "'"
            If Not dataaccess.CheckRedendency(testquery) Then
                If dataaccess.ExecuteNonQuery(query) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                'Return False
                MessageBox.Show("There is a course already registered with this course code", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal course As Course) As Boolean
        Try
            Dim query As String = "update Course set Course_ID='" + course.Course_ID + "',Title='" + course.Title + "','" + course.ECTS + "',Chr='" + course.Chr + "',Requires_lab='" + course.Requires_lab + "', Class_year='" + course.Class_year + "', Program='" + course.Program + "',Semester='" + course.Semester + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal course_ID As String) As Boolean
        Try
            Dim query As String = "delete Course where Course_ID= '" + course_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadCourse(ByVal lvcourse As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            Dim i As Integer = 0
            While reader.Read()
                lvcourse.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                lvcourse.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                i = i + 1
            End While
            reader.Close()
            If lvcourse.Items.Count > 0 Then
                Try
                    lvcourse.Items(0).Focused = True
                    lvcourse.Items(0).Selected = True
                    lvcourse.Items(0).EnsureVisible()
                    lvcourse.Focus()
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

