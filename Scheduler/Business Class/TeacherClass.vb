Imports System.Data.SqlClient
Public Class Teacher
    Private _Teacher_ID As String
    Private _Fisrt_name As String
    Private _Last_name As String
    Private _Block_no As String
    Private _Floor_no As String
    Private _Office_no As String
    Private _Phone As String
    Private _Email As String
    Private dataaccess As New DataAccessClass
#Region "properties..."
    Public Property Teacher_ID() As String
        Get
            Return _Teacher_ID
        End Get
        Set(ByVal value As String)
            _Teacher_ID = value
        End Set
    End Property
    Public Property First_name() As String
        Get
            Return _Fisrt_name
        End Get
        Set(ByVal value As String)
            _Fisrt_name = value
        End Set
    End Property
    Public Property Last_name() As String
        Get
            Return _Last_name
        End Get
        Set(ByVal value As String)
            _Last_name = value
        End Set
    End Property
    Public Property Block_no() As String
        Get
            Return _Block_no
        End Get
        Set(ByVal value As String)
            _Block_no = value
        End Set
    End Property
    Public Property Floor_no() As String
        Get
            Return _Floor_no
        End Get
        Set(ByVal value As String)
            _Floor_no = value
        End Set
    End Property
    Public Property Office_no() As String
        Get
            Return _Office_no
        End Get
        Set(ByVal value As String)
            _Office_no = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
#End Region
#Region "methods..."
    Public Function save(ByVal teacher As Teacher) As Boolean
        Try
            Dim query As String = "INSERT INTO Teacher VALUES ('" + teacher.Teacher_ID + "','" + teacher.First_name + "','" + teacher.Last_name + "','" + teacher.Block_no + "','" + teacher.Floor_no + "','" + teacher.Office_no + "','" + teacher.Phone + "','" + teacher._Email + "')"
            Dim testquery As String = "select*from Teacher where Teacher_ID='" + teacher.Teacher_ID + "'"
            If Not dataaccess.CheckRedendency(testquery) Then
                If dataaccess.ExecuteNonQuery(query) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                'Return False
                MessageBox.Show("There is another teacher already registered with this ID number", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal teacher As Teacher) As Boolean
        Try
            Dim query As String = "update Teacher set Fname='" + teacher.First_name + "',Lname='" + teacher.Last_name + "',Block_no='" + teacher.Block_no + "',Floor_no='" + teacher.Floor_no + "',Office_no" + teacher.Office_no + "',Phone_no='" + teacher.Phone + "',Email='" + teacher.Email + "' where Teacher_ID='" + teacher.Teacher_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal teacher_ID As String) As Boolean
        Try
            Dim query As String = "delete Teacher where Teacher_ID= '" + teacher_ID + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadTeacher(ByVal lvteacher As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            Dim i As Integer = 0
            While reader.Read()
                lvteacher.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                lvteacher.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                i = i + 1
            End While
            reader.Close()
            If lvteacher.Items.Count > 0 Then
                Try
                    lvteacher.Items(0).Focused = True
                    lvteacher.Items(0).Selected = True
                    lvteacher.Items(0).EnsureVisible()
                    lvteacher.Focus()
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
