Public Class Type
    Private tid As String
    Private dailyRate As String
    Private weeklyRate As String
    Private monthlyRate As String
    Private vehicleType As String

    Public Property TidProperty As String
        Get
            Return tid
        End Get
        Set(value As String)
            tid = value
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

    Public Property VehicleTypeProperty As String
        Get
            Return vehicleType
        End Get
        Set
            vehicleType = Value
        End Set
    End Property

    Public Sub New(type As String)
        Me.VehicleTypeProperty = type
    End Sub

    Public Overrides Function ToString() As String
        Return vehicleType
    End Function
End Class
