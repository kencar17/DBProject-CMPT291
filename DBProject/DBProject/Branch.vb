Public Class Branch
    Private bid As Integer
    Private postcode As String
    Private address As String
    Private city As String
    Private state As String
    Private country As String
    Private email As String
    Private phone As String
    Private fax As String
    Private manid As Integer
    Private manname As String

    Public Property BidProperty As Integer
        Get
            Return bid
        End Get
        Set
            bid = Value
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

    Public Property PhoneProperty As String
        Get
            Return phone
        End Get
        Set
            phone = Value
        End Set
    End Property

    Public Property FaxProperty As String
        Get
            Return fax
        End Get
        Set
            fax = Value
        End Set
    End Property

    Public Property ManidProperty As Integer
        Get
            Return manid
        End Get
        Set
            manid = Value
        End Set
    End Property

    Public Property MannameProperty As String
        Get
            Return manname
        End Get
        Set
            manname = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return address & ", " & city
    End Function
End Class
