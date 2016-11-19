Public Class VehicleInfo
    Private make As String
    Private model As String
    Private vClass As String
    Private year As String
    Private seats As String
    Private gvwr As String
    Private transmission As String
    Private coverage As String
    Private dailyRate As String
    Private weeklyRate As String
    Private monthlyRate As String


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

    Public Property YearProperty As String
        Get
            Return year
        End Get
        Set(value As String)
            year = value
        End Set
    End Property

    Public Property SeatsProperty As String
        Get
            Return seats
        End Get
        Set(value As String)
            seats = value
        End Set
    End Property

    Public Property GvwrProperty As String
        Get
            Return gvwr
        End Get
        Set(value As String)
            gvwr = value
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

    Public Property CoverageProperty As String
        Get
            Return coverage
        End Get
        Set(value As String)
            coverage = value
        End Set
    End Property

    Public Property DailyRateProperty As String
        Get
            Return dailyRate
        End Get
        Set(value As String)
            dailyRate = value
        End Set
    End Property

    Public Property WeeklyRateProperty As String
        Get
            Return weeklyRate
        End Get
        Set(value As String)
            weeklyRate = value
        End Set
    End Property

    Public Property MonthlyRateProperty As String
        Get
            Return monthlyRate
        End Get
        Set(value As String)
            monthlyRate = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return vClass
    End Function

End Class
