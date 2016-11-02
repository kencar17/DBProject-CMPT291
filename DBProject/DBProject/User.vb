Imports MySql.Data.MySqlClient

Public Class User
    Private username As String
    Private password As String
    Private employee As Boolean

    Public Sub New(username As String, password As String, isEmployee As Boolean)
        Me.username = username
        Me.password = password
        Me.employee = isEmployee
    End Sub

    Public Function getUsername() As String
        Return Me.username
    End Function

    Public Function getPassword() As String
        Return Me.password
    End Function

    Public Function IsEmployee() As Boolean
        Return Me.employee
    End Function

    Public Shared Function CheckPassword(username As String, passwordToCheck As String) As Boolean
        If username Is Nothing Or passwordToCheck Is Nothing Or username.Equals("") Or passwordToCheck.Equals("") Then
            Return False
        End If
        Dim user As User = FindUser(username)
        If Not (user Is Nothing And user.getUsername().Equals("")) Then
            Return BCrypt.Net.BCrypt.Verify(passwordToCheck, user.password)
        End If

        Return False
    End Function

    Public Shared Function FindUser(username As String) As User
        Dim checkSQL As String = "SELECT Username, Password, IsEmployee FROM User WHERE Username = @username"
        Dim returnedUsername As String = ""
        Dim returnedPass As String = ""
        Dim employee As Boolean

        Dim dbConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbConnection
                .CommandText = checkSQL
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@username", username)
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    returnedUsername = sqlReader("Username").ToString()
                    returnedPass = sqlReader("Password").ToString()
                    employee = sqlReader("IsEmployee").ToString().Equals("1")
                End While
            Catch ex As Exception
                Return Nothing
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        Return New User(returnedUsername, returnedPass, employee)
    End Function
End Class
