Imports System.Data.SqlServerCe
Public Class Exam
    Private _Course_ID As String
    Private _Teacher_ID As String
    Private _Program As String
    Private _Accademic_year As String
    Private _Section As String
    Private _Examinar_name As String
    Private _Invagilators_name As String
    Private _Time_allowed As String
    Private dataaccess As New DataAccessClass
#Region "properties.."
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
    Public Property Program() As String
        Get
            Return _Program
        End Get
        Set(ByVal value As String)
            _Program = value
        End Set
    End Property
    Public Property Section() As String
        Get
            Return _Section
        End Get
        Set(ByVal value As String)
            _Section = value
        End Set
    End Property
    Public Property Accademic_year() As String
        Get
            Return _Accademic_year
        End Get
        Set(ByVal value As String)
            _Accademic_year = value
        End Set
    End Property
    Public Property Examinar_name() As String
        Get
            Return _Examinar_name
        End Get
        Set(ByVal value As String)
            _Examinar_name = value
        End Set
    End Property
    Public Property Invagilators_name() As String
        Get
            Return _Invagilators_name
        End Get
        Set(ByVal value As String)
            _Invagilators_name = value
        End Set
    End Property
    Public Property Time_allowed() As String
        Get
            Return _Time_allowed
        End Get
        Set(ByVal value As String)
            _Time_allowed = value
        End Set
    End Property
#End Region
#Region "methods"
    Public Function save(ByVal exam As Exam) As Boolean
        Try
            Dim query As String = "INSERT INTO Exam VALUES ('" + exam.Course_ID + "','" + exam.Teacher_ID + "','" + exam.Section + "','" + exam.Accademic_year + "','" + exam.Program + "','" + exam.Examinar_name + "','" + exam.Invagilators_name + "','" + exam.Time_allowed.ToString + "')"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal exam As Exam) As Boolean
        Try
            Dim query As String = "update Exam set Course_ID='" + exam.Course_ID + "',Teacher_ID='" + exam.Teacher_ID + "',Program='" + exam.Program + "',Accademic_year='" + exam.Accademic_year + "',Section_ID='" + exam.Section + "',Examinar_name='" + exam.Examinar_name + "',Invagilators_name='" + exam.Invagilators_name + "',Time_allowed='" + exam.Time_allowed.ToString + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal exam_ID As String) As Boolean
        Try
            Dim query As String = "delete Exam where Exam_ID= '" + exam_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
End Class
