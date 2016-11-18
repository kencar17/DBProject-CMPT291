Imports MySql.Data.MySqlClient

Public NotInheritable Class SQLConnection
    Private Shared ReadOnly _instance As New Lazy(Of SQLConnection)(Function() New SQLConnection(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As SQLConnection
        Get
            Return _instance.Value
        End Get
    End Property

    Dim conn As New MySqlConnection
    Public Function GetConnection()
        Dim databaseName As String = "CarRentals"
        Dim server As String = "45.79.94.244"
        Dim userName As String = "cmpt291"
        Dim password As String = "cmpt291"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, databaseName)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conn
    End Function

    Public Sub CloseConnection()
        If Not conn Is Nothing Then conn.Close()
    End Sub

    Public Shared Sub DoNonQuery(sqlText As String, parameters As Dictionary(Of String, String))
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = sqlText
                .CommandType = CommandType.Text

                For Each parameterPair As KeyValuePair(Of String, String) In parameters
                    Dim parameter As String = parameterPair.Key
                    Dim value As String = parameterPair.Value
                    .Parameters.AddWithValue(parameter, value)
                Next

            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Public Shared Function DoQuery(sqlText As String, parameters As Dictionary(Of String, String), columns As List(Of String)) As List(Of Dictionary(Of String, String))
        Dim resultList As New List(Of Dictionary(Of String, String))


        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = sqlText
                .CommandType = CommandType.Text

                For Each parameterPair As KeyValuePair(Of String, String) In parameters
                    Dim parameter As String = parameterPair.Key
                    Dim value As String = parameterPair.Value
                    .Parameters.AddWithValue(parameter, value)
                Next
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim currentResult As New Dictionary(Of String, String)
                    With currentResult
                        For Each column In columns
                            .Add(column, sqlReader(column).ToString())
                        Next
                    End With

                    resultList.Add(currentResult)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Return resultList
    End Function
End Class
