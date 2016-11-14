Public Class Type
    Private tid As String
    Private dailyRate As Decimal
    Private weeklyRate As Decimal
    Private monthlyRate As Decimal
    Private vehicleType As String

    Public Property TidProperty As String
        Get
            Return tid
        End Get
        Set(value As String)
            tid = value
        End Set
    End Property

    Public Property DailyRateProperty As Decimal
        Get
            Return dailyRate
        End Get
        Set(value As Decimal)
            dailyRate = value
        End Set
    End Property

    Public Property WeeklyRateProperty As Decimal
        Get
            Return weeklyRate
        End Get
        Set(value As Decimal)
            weeklyRate = value
        End Set
    End Property

    Public Property MonthlyRateProperty As Decimal
        Get
            Return monthlyRate
        End Get
        Set(value As Decimal)
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
