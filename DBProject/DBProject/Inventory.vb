Imports MySql.Data.MySqlClient
Public Class Inventory
    Private vin As String
    Private make As String
    Private model As String
    Private vClass As String
    Private km As String
    Private year As String
    Private seats As String
    Private gvwr As String
    Private transmission As String
    Private lPlateNum As String
    Private available As String
    Private coverage As String

    Public Property VinProperty As String
        Get
            Return vin
        End Get
        Set
            vin = Value
        End Set
    End Property

    Public Property MakeProperty As String
        Get
            Return make
        End Get
        Set
            make = Value
        End Set
    End Property

    Public Property ModelProperty As String
        Get
            Return model
        End Get
        Set
            model = Value
        End Set
    End Property

    Public Property VClassProperty As String
        Get
            Return vClass
        End Get
        Set
            vClass = Value
        End Set
    End Property

    Public Property KmProperty As String
        Get
            Return km
        End Get
        Set
            km = Value
        End Set
    End Property

    Public Property YearProperty As String
        Get
            Return year
        End Get
        Set
            year = Value
        End Set
    End Property

    Public Property SeatsProperty As String
        Get
            Return seats
        End Get
        Set
            seats = Value
        End Set
    End Property

    Public Property GvwrProperty As String
        Get
            Return gvwr
        End Get
        Set
            gvwr = Value
        End Set
    End Property

    Public Property TransmissionProperty As String
        Get
            Return transmission
        End Get
        Set
            transmission = Value
        End Set
    End Property

    Public Property LPlateNumProperty As String
        Get
            Return lPlateNum
        End Get
        Set
            lPlateNum = Value
        End Set
    End Property

    Public Property AvailableProperty As String
        Get
            Return available
        End Get
        Set
            available = Value
        End Set
    End Property

    Public Property CoverageProperty As String
        Get
            Return coverage
        End Get
        Set
            coverage = Value
        End Set
    End Property

End Class