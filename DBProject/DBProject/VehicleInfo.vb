Public Class VehicleInfo
    Private _make As String
    Private _model As String
    Private _vClass As String
    Private _year As String
    Private _seats As String
    Private _gvwr As String
    Private _transmission As String
    Private _coverage As String
    Private _dailyRate As String
    Private _weeklyRate As String
    Private _monthlyRate As String

    Private vin As String

    Public Property VinProperty As String
        Get
            Return vin
        End Get
        Set
            vin = Value
        End Set
    End Property


    Public Property Make As String
        Get
            Return _make
        End Get
        Set
            _make = Value
        End Set
    End Property

    Public Property Model As String
        Get
            Return _model
        End Get
        Set
            _model = Value
        End Set
    End Property

    Public Property VClass As String
        Get
            Return _vClass
        End Get
        Set
            _vClass = Value
        End Set
    End Property

    Public Property Year As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Public Property Seats As String
        Get
            Return _seats
        End Get
        Set(value As String)
            _seats = value
        End Set
    End Property

    Public Property Gvwr As String
        Get
            Return _gvwr
        End Get
        Set(value As String)
            _gvwr = value
        End Set
    End Property

    Public Property Transmission As String
        Get
            Return _transmission
        End Get
        Set
            _transmission = Value
        End Set
    End Property

    Public Property Coverage As String
        Get
            Return _coverage
        End Get
        Set(value As String)
            _coverage = value
        End Set
    End Property

    Public Property DailyRate As String
        Get
            Return _dailyRate
        End Get
        Set(value As String)
            _dailyRate = value
        End Set
    End Property

    Public Property WeeklyRate As String
        Get
            Return _weeklyRate
        End Get
        Set(value As String)
            _weeklyRate = value
        End Set
    End Property

    Public Property MonthlyRate As String
        Get
            Return _monthlyRate
        End Get
        Set(value As String)
            _monthlyRate = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _vClass
    End Function

End Class
