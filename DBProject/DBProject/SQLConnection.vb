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
End Class
