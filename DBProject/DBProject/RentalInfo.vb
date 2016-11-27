Public Class RentalInfo
    Private location As Branch
    Private pickUp As Date
    Private dropOff As Date
    Private pickUpTime As String
    Private dropOffTime As String
    Private vehicle As VehicleInfo
    Private customer As Person



    Public Property LocationProperty As Branch
        Get
            Return location
        End Get
        Set
            location = Value
        End Set
    End Property

    Public Property PickUpProperty As Date
        Get
            Return pickUp
        End Get
        Set
            pickUp = Value
        End Set
    End Property

    Public Property DropOffProperty As Date
        Get
            Return dropOff
        End Get
        Set
            dropOff = Value
        End Set
    End Property

    Public Property PickUpTimeProperty As String
        Get
            Return pickUpTime
        End Get
        Set
            pickUpTime = Value
        End Set
    End Property

    Public Property DropOffTimeProperty As String
        Get
            Return dropOffTime
        End Get
        Set
            dropOffTime = Value
        End Set
    End Property

    Public Property VehicleProperty As VehicleInfo
        Get
            Return vehicle
        End Get
        Set
            vehicle = Value
        End Set
    End Property

    Public Property CustomerProperty As Person
        Get
            Return customer
        End Get
        Set
            customer = Value
        End Set
    End Property

End Class
