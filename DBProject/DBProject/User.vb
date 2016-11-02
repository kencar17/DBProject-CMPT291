Imports MySql.Data.MySqlClient

Public Class User
    Private username As String
    Private password As String
    Private employee As Boolean
    Private email As String
    Private streetAddress As String
    Private postCode As String
    Private city As String
    Private state As String
    Private country As String

    Public Property UsernameProperty As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property PasswordProperty As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property EmployeeProperty As Boolean
        Get
            Return employee
        End Get
        Set(value As Boolean)
            employee = value
        End Set
    End Property

    Public Property EmailProperty As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property StreetAddressProperty As String
        Get
            Return streetAddress
        End Get
        Set(value As String)
            streetAddress = value
        End Set
    End Property

    Public Property PostCodeProperty As String
        Get
            Return postCode
        End Get
        Set(value As String)
            postCode = value
        End Set
    End Property

    Public Property CityProperty As String
        Get
            Return city
        End Get
        Set(value As String)
            city = value
        End Set
    End Property

    Public Property StateProperty As String
        Get
            Return state
        End Get
        Set(value As String)
            state = value
        End Set
    End Property

    Public Property CountryProperty As String
        Get
            Return country
        End Get
        Set(value As String)
            country = value
        End Set
    End Property

    Public Sub New(username As String, password As String, isEmployee As Boolean)
        Me.UsernameProperty = username
        Me.PasswordProperty = password
        Me.EmployeeProperty = isEmployee
    End Sub

    Public Function CheckPassword(passwordToCheck As String) As Boolean
        If username Is Nothing Or passwordToCheck Is Nothing Or username.Equals("") Or passwordToCheck.Equals("") Then
            Return False
        End If
        If Not (Me.UsernameProperty.Equals("")) Then
            Return BCrypt.Net.BCrypt.Verify(passwordToCheck, Me.password)
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
