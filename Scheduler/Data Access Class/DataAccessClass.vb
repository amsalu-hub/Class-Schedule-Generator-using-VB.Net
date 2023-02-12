Imports System.Data.SqlClient
Public Class DataAccessClass
    Private connection As SqlConnection
    Private command As SqlCommand
    Private transaction As SqlTransaction
    Private connstring As String = My.Settings.InstitutionalLevelSchedulerConnectionString'"Data Source=localhost,1433;Network Library=DBMSSOCN;Initial Catalog=SCHEDULER;User ID=sa;Password=mysqlserver;"
    Public Function OpenConnection() As Boolean
        Try
            connection = New SqlConnection '(connstring)
            connection.ConnectionString = connstring
            connection.Open()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function CloseConnection() As Boolean
        Try
            If IsDBNull(connection) Then
                Return True
            End If
            If connection.State = ConnectionState.Closed Then
                Return True
            End If
            connection.Close()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ReturnConnString() As String
        Try

            If IsDBNull(connection) Then
                Return ""
            End If
            If connection.State = ConnectionState.Closed Then
                Return ""
            End If
            Dim ConnString As String = connection.ConnectionString
            Return ConnString
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function CreateCommand(ByVal query As String) As String
        Try

            Dim result As Boolean = OpenConnection()
            If result Then
                If IsDBNull(command) Then
                    command = New SqlCommand()
                End If
                command = New SqlCommand()
                command.CommandText = query
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ReturnCommand() As String
        Try
            If IsDBNull(command) Then
                Return ""
            End If
            If (command.CommandText = "") Then
                Return ""
            End If
            Dim commandtext As String = command.CommandText
            Return commandtext
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function SetConnToCommand() As Boolean
        Try
            If IsDBNull(connection) Then
                Return False
            End If
            If IsDBNull(command) Then
                Return False
            End If
            command.Connection = connection
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function PrepareCommand(ByVal conn As SqlConnection, ByVal query As String) As SqlCommand
        Try
            If IsDBNull(conn) Then
                Return Nothing
            End If
            If IsDBNull(command) Then
                command = New SqlCommand(query, conn)
            End If
            command = New SqlCommand '(query, conn)
            command.Connection = conn
            command.CommandType = CommandType.Text
            command.CommandText = query
            Return command
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub TransactionRollback()
        Try
            If IsDBNull(connection) Then
                Return
            End If
            'transaction.Rollback();
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub BeginTransaction()
        Try
            If IsDBNull(connection) Then
                Return
            End If
            AssigneTransactiontoCommand()
            transaction = connection.BeginTransaction()
        Catch ex As Exception
            TransactionRollback()
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub CommitTransaction()
        Try
            If IsDBNull(transaction) Then
                TransactionRollback()
                Return
            End If
            transaction.Commit()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub AssigneTransactiontoCommand()
        Try
            If IsDBNull(command) Then
                Return
            End If
            command.Transaction = transaction
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ExecuteNonQuery(ByVal query As String) As Integer
        Try
            Dim ResultConn As Boolean = OpenConnection()
            Dim result As Integer
            Dim comm As SqlCommand = PrepareCommand(connection, query)
            If ResultConn Then
                'comm = PrepareCommand(connection, query)
                'comm.Transaction = transaction
                'If IsDBNull(comm) Then
                '    result = -1
                'End If
                result = comm.ExecuteNonQuery()
            Else
                MessageBox.Show("Error in making connection to Database Server." + vbNewLine + "Please check your local connection or contact the database administrator of the system.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' MsgBox(result.ToString)
            CloseConnection()
            Return result
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ExecuteReader(ByVal query As String) As SqlDataReader
        Try
            Dim ResultConn As Boolean = OpenConnection()
            Dim comm As SqlCommand = PrepareCommand(connection, query)
            If IsDBNull(comm) Then
                Return Nothing
            End If
            Dim reader As SqlDataReader = comm.ExecuteReader()
            'CloseConnection()
            Return reader
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ReturnRows(ByVal query As String) As Integer
        Try

            Dim ResultConn As Boolean = OpenConnection()
            Dim comm As SqlCommand = PrepareCommand(connection, query)
            If IsDBNull(comm) Then
                Return Nothing
            End If
            Dim reader As SqlDataReader = comm.ExecuteReader()
            CloseConnection()
            Return Integer.Parse(reader.RecordsAffected)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ExecuteScalar(ByVal query As String) As String
        Try
            Dim ResultConn As Boolean = OpenConnection()
            Dim comm As SqlCommand = PrepareCommand(connection, query)
            Dim result As String
            If IsDBNull(comm) Then
                result = -1
            End If
            result = comm.ExecuteScalar()
            'CloseConnection()
            Return result
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function CheckRedendency(ByVal query As String) As Boolean
        Try
            If ExecuteNonQuery(query) < 1 Or ExecuteNonQuery(query) = -1 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ReturnDataset(ByVal query As String) As DataSet
        Try
            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter
            OpenConnection()
            command = PrepareCommand(connection, query)
            adapter.SelectCommand = command
            CloseConnection()
            adapter.Fill(dataset)
            Return dataset
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ReturnCombobox(ByVal query As String) As ComboBox
        Try
            Dim dataset As New DataSet
            Dim combobox As New ComboBox
            dataset = ReturnDataset(query)
            For i = 0 To dataset.Tables(0).Rows.Count - 1
                combobox.Items.Add(dataset.Tables(0).Rows(i).Item(0).ToString)
            Next
            Return combobox
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class



