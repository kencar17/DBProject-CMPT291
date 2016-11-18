Imports MySql.Data.MySqlClient

Public Class User
    Private username As String
    Private password As String
    Private email As String
    Private streetAddress As String
    Private postCode As String
    Private city As String
    Private state As String
    Private country As String
    Private name As String
    Private id As Integer
    Private firstName As String
    Private lastName As String
    Private img As String

    Public Property ImgProperty As String
        Get
            Return img
        End Get
        Set
            img = Value
        End Set
    End Property

    Public Property FirstNameProperty As String
        Get
            Return firstName
        End Get
        Set
            firstName = Value
        End Set
    End Property

    Public Property LastNameProperty As String
        Get
            Return lastName
        End Get
        Set
            lastName = Value
        End Set
    End Property

    Public Property IdProperty As Integer
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property

    Public Property NameProperty As String
        Get
            Return name
        End Get
        Set
            name = Value
        End Set
    End Property

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

    Public Sub New(username As String, password As String)
        Me.UsernameProperty = username
        Me.PasswordProperty = password
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
        Dim checkSQL As String = "SELECT Result.Username, Password, Employee.FirstName, Employee.LastName, Employee.PostalCode, Employee.StreetAddress, Employee.Email, Employee.City, Employee.State, Employee.Country, ImgUrl FROM (SELECT Username, Password, PersonID, ImgUrl FROM User WHERE Username = @username) Result LEFT JOIN Employee ON Result.PersonID = Employee.EID"
        Dim returnedUsername As String = ""
        Dim returnedPass As String = ""
        Dim returnedEmail As String
        Dim address As String
        Dim pcode As String
        Dim returnedCity As String
        Dim returnedState As String
        Dim returnedCountry As String
        Dim employeeName As String
        Dim image As String
        Dim params As New Dictionary(Of String, String)
        params.Add("@username", username)
        Dim columns As New List(Of String)
        With columns
            .Add("Username")
            .Add("Password")
            .Add("Email")
            .Add("StreetAddress")
            .Add("PostalCode")
            .Add("City")
            .Add("State")
            .Add("Country")
            .Add("FirstName")
            .Add("LastName")
            .Add("ImgUrl")
        End With
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(checkSQL, params, columns)
        For Each result As Dictionary(Of String, String) In results
            returnedUsername = result("Username")
            returnedPass = result("Password")
            returnedEmail = result("Email")
            address = result("StreetAddress")
            pcode = result("PostalCode")
            returnedCity = result("City")
            returnedState = result("State")
            returnedCountry = result("Country")
            employeeName = result("FirstName") & " " & result("LastName")
            image = result("ImgUrl")
        Next

        If Not returnedUsername.Equals(username) Then
            Return Nothing
        End If

        Dim newUser As New User(returnedUsername, returnedPass)

        With newUser
            .CityProperty = returnedCity
            .CountryProperty = returnedCountry
            .EmailProperty = returnedEmail
            .PostCodeProperty = pcode
            .StateProperty = returnedState
            .StreetAddressProperty = address
            .NameProperty = employeeName
            .ImgProperty = image
        End With

        Return newUser
    End Function

    Public Overrides Function ToString() As String
        Return username
    End Function
End Class
