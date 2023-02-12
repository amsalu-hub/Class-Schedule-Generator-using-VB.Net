Imports System.Data.SqlClient
Public Class Section
    Private _school As String
    Private _Program As String
    Private _Accademic_year As String
    Private _Section As String
    Private _Rep_name As String
    Private _Rep_phone As String
    Private _Rep_email As String
    Private dataaccess As New DataAccessClass
#Region "properties.."
    Public Property School() As String
        Get
            Return _school
        End Get
        Set(ByVal value As String)
            _school = value
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
    Public Property Accademic_year() As String
        Get
            Return _Accademic_year
        End Get
        Set(ByVal value As String)
            _Accademic_year = value
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
    Public Property Rep_phone() As String
        Get
            Return _Rep_phone
        End Get
        Set(ByVal value As String)
            _Rep_phone = value
        End Set
    End Property
    Public Property Rep_email() As String
        Get
            Return _Rep_email
        End Get
        Set(ByVal value As String)
            _Rep_email = value
        End Set
    End Property
    Public Property Rep_name() As String
        Get
            Return _Rep_name
        End Get
        Set(ByVal value As String)
            _Rep_name = value
        End Set
    End Property
#End Region
#Region "methods..."
    Public Function save(ByVal section As Section) As Boolean
        Try
            Dim query As String = "INSERT INTO Section VALUES ('" + section.Section + "','" + section.Program + "','" + section.Accademic_year + "','" + section.School + "','" + section.Rep_name + "','" + section.Rep_phone + "','" + section.Rep_email + "')"
            Dim testquery As String = "select*from Section where Section_ID='" + section.Section + "' and Accademic_year='" + section.Accademic_year + "' and Program='" + section.Program + "'"
            If Not dataaccess.CheckRedendency(testquery) Then
                If dataaccess.ExecuteNonQuery(query) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                'Return False
                MessageBox.Show("There is a Section already registered with this course code", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function update(ByVal section As Section) As Boolean
        Try
            Dim query As String = "update Section set Section_ID='" + section.Section + "',Accademic_year='" + section.Accademic_year + "',Program='" + section.Program + "',Representative_name='" + section.Rep_name + "',Representative_phone='" + section.Rep_phone + "',Representative_email='" + section.Rep_email + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal section_ID As String, ByVal accademic_year As String, ByVal program As String) As Boolean
        Try
            Dim query As String = "delete Section where Section_ID= '" + section_ID + "' and Accademic_year='" + accademic_year + "' and Program='" + program + "'"
            If dataaccess.ExecuteNonQuery(query) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub LoadSection(ByVal lvsection As ListView, ByVal query As String)
        Try
            Dim reader As SqlDataReader = dataaccess.ExecuteReader(query)
            Dim i As Integer = 0
            While reader.Read()
                lvsection.Items.Add(New ListViewItem("" + Convert.ToString(reader.GetValue(0)), 20))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(1)))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(2)))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(3)))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(4)))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(5)))
                lvsection.Items(i).SubItems.Add(Convert.ToString(reader.GetValue(6)))
                i = i + 1
            End While
            reader.Close()
            If lvsection.Items.Count > 0 Then
                Try
                    lvsection.Items(0).Focused = True
                    lvsection.Items(0).Selected = True
                    lvsection.Items(0).EnsureVisible()
                    lvsection.Focus()
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
