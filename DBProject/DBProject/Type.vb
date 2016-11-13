Public Class Type
    Private tid As Integer
    Private drate As Decimal
    Private wrate As Decimal
    Private mrate As Decimal
    Private type As String

    Public Property TidProperty As Integer
        Get
            Return tid
        End Get
        Set
            tid = Value
        End Set
    End Property

    Public Property DrateProperty As Decimal
        Get
            Return drate
        End Get
        Set
            drate = Value
        End Set
    End Property

    Public Property WrateProperty As Decimal
        Get
            Return wrate
        End Get
        Set
            wrate = Value
        End Set
    End Property

    Public Property MrateProperty As Decimal
        Get
            Return mrate
        End Get
        Set
            mrate = Value
        End Set
    End Property

    Public Property TypeProperty As String
        Get
            Return type
        End Get
        Set
            type = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return type
    End Function
End Class
