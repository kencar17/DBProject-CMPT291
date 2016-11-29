Public Class Person
    Private Fname As String
    Private Lname As String
    Private postcode As String
    Private address As String
    Private city As String
    Private state As String
    Private country As String
    Private email As String
    'Private phone As String
    Private age As String
    Private Creditcard As String
    Private CVV As String

    Private id As String

    Public Property IdProperty As String
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property


    Public Property FnameProperty As String
        Get
            Return Fname
        End Get
        Set
            Fname = Value
        End Set
    End Property

    Public Property LnameProperty As String
        Get
            Return Lname
        End Get
        Set
            Lname = Value
        End Set
    End Property

    Public Property PostcodeProperty As String
        Get
            Return postcode
        End Get
        Set
            postcode = Value
        End Set
    End Property

    Public Property AddressProperty As String
        Get
            Return address
        End Get
        Set
            address = Value
        End Set
    End Property

    Public Property CityProperty As String
        Get
            Return city
        End Get
        Set
            city = Value
        End Set
    End Property

    Public Property StateProperty As String
        Get
            Return state
        End Get
        Set
            state = Value
        End Set
    End Property

    Public Property CountryProperty As String
        Get
            Return country
        End Get
        Set
            country = Value
        End Set
    End Property

    Public Property EmailProperty As String
        Get
            Return email
        End Get
        Set
            email = Value
        End Set
    End Property

    'Public Property PhoneProperty As String
    'Get
    'Return phone
    'End Get
    'Set
    '       phone = Value
    'End Set
    'End Property

    Public Property ageProperty As String
        Get
            Return age
        End Get
        Set
            age = Value
        End Set
    End Property

    Public Property CreditcardProperty As String
        Get
            Return Creditcard
        End Get
        Set
            Creditcard = Value
        End Set
    End Property

    Public Property CVVProperty As String
        Get
            Return CVV
        End Get
        Set
            CVV = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Lname & ", " & Fname & ", " '& phone
    End Function

End Class
