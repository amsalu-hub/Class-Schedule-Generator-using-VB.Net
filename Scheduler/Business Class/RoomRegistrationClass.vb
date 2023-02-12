Imports System.Data.SqlClient
Public Class Room
    Private _Room_NO As String
    Private _Block_No As String
    Private _Floor_No As String
    Private _Room_type As String
    Private _Head_name As String
    Private _Head_phone As String
    Private _Head_email As String
    Private _School As String
    Private dataaccess As New DataAccessClass
#Region "properties.."
    Public Property Room_No() As String
        Get
            Return _Room_NO
        End Get
        Set(ByVal value As String)
            _Room_NO = value
        End Set
    End Property
    Public Property Block_No() As String
        Get
            Return _Block_No
        End Get
        Set(ByVal value As String)
            _Block_No = value
        End Set
    End Property
    Public Property Floor_No() As String
        Get
            Return _Floor_No
        End Get
        Set(ByVal value As String)
            _Floor_No = value
        End Set
    End Property
    Public Property Room_Type() As String
        Get
            Return _Room_type
        End Get
        Set(ByVal value As String)
            _Room_type = value
        End Set
    End Property
    Public Property Head_phone() As String
        Get
            Return _Head_phone
        End Get
        Set(ByVal value As String)
            _Head_phone = value
        End Set
    End Property
    Public Property Head_name() As String
        Get
            Return _Head_name
        End Get
        Set(ByVal value As String)
            _Head_name = value
        End Set
    End Property
    Public Property Head_email() As String
        Get
            Return _Head_email
        End Get
        Set(ByVal value As String)
            _Head_email = value
        End Set
    End Property
    Public Property School() As String
        Get
            Return _School
        End Get
        Set(ByVal value As String)
            _School = value
        End Set
    End Property
#End Region
#Region "methods.."
    Public Function save(ByVal room As Room) As Boolean
        Try
            Dim query As String = "INSERT INTO Room VALUES ('" + room.Room_No + "','" + room.Block_No + "','" + room.Floor_No + "','" + room.Room_Type + "','" + room.Head_name + "','" + room.Head_phone + "','" + room._Head_email + "','" + room.School + "')"
            Dim testquery As String = "select*from Room where Room_ID='" + room.Room_No + "' and Block_no='" + room.Room_No + "'"
            If Not dataaccess.CheckRedendency(testquery) Then
                If dataaccess.ExecuteNonQuery(query) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                'Return False
                MessageBox.Show("There is a Room already registered with this course code", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal room As Room) As Boolean
        Try
            Dim query As String = "update Room set Room_ID='" + room.Room_No + "',Block_no='" + room.Block_No + "',Floor_no='" + room.Floor_No + "',Room_Head='" + room.Head_name + "',Head_phone_no='" + room.Head_phone + "',Head_email='" + room.Head_email + "',School_name='" + room.School + "',Room_type='" + room.Room_Type + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal room_ID As String, ByVal block_no As String) As Boolean
        Try
            Dim query As String = "delete Room where Room_ID= '" + room_ID + "' and Block_no='" + block_no + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadRoom(ByVal lvroom As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            Dim i As Integer = 0
            While reader.Read()
                lvroom.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                lvroom.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(7)))
                i = i + 1
            End While
            reader.Close()
            If lvroom.Items.Count > 0 Then
                Try
                    lvroom.Items(0).Focused = True
                    lvroom.Items(0).Selected = True
                    lvroom.Items(0).EnsureVisible()
                    lvroom.Focus()
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
