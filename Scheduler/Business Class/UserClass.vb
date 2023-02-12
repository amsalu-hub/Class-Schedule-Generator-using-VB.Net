Imports System.Data.SqlClient
Public Class User
    Private _username As String
    Private _password As String
    Private _usertype As String
    Private _securityquestion As String
    Private _securityanswer As String
    Private dataaccess As New DataAccessClass
#Region "properties..."
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Public Property User_type() As String
        Get
            Return _usertype
        End Get
        Set(ByVal value As String)
            _usertype = value
        End Set
    End Property
    Public Property Security_question() As String
        Get
            Return _securityquestion
        End Get
        Set(ByVal value As String)
            _securityquestion = value
        End Set
    End Property
    Public Property Security_answer() As String
        Get
            Return _securityanswer
        End Get
        Set(ByVal value As String)
            _securityanswer = value
        End Set
    End Property
#End Region
#Region "Methods..."
    Public Function save(ByVal user As User) As Boolean
        Try
            Dim query As String = "INSERT INTO Users VALUES ('" + user.Username + "','" + user.Password + "','" + user.User_type + "','" + user.Security_question + "','" + user.Security_answer + "')"
            Dim testquery As String = "select*from Users where User_name='" + user.Username + "' and Password='" + user.Password + "'and User_type='" + user.User_type + "'"
            If Not dataaccess.CheckRedendency(testquery) Then
                If dataaccess.ExecuteNonQuery(query) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal user As User) As Boolean
        Try
            Dim query As String = "update Users set User_name='" + user.Username + "',Password='" + user.Password + "',User_type='" + user.User_type + "',Security_question='" + user.Security_question + "',Security_answer='" + user.Security_answer + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal user_ID As Integer) As Boolean
        Try
            Dim query As String = "delete Users where UserID= " & user_ID & " and User_name<>'admin' and User_type<>'Admin'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadUser(ByVal lvsuer As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            Dim i As Integer = 0
            While reader.Read()
                lvsuer.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvsuer.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvsuer.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvsuer.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvsuer.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvsuer.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                i = i + 1
            End While
            reader.Close()
            If lvsuer.Items.Count > 0 Then
                Try
                    lvsuer.Items(0).Focused = True
                    lvsuer.Items(0).Selected = True
                    lvsuer.Items(0).EnsureVisible()
                    lvsuer.Focus()
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
