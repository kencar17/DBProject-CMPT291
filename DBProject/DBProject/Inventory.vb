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
    Private bid As String

    Public Property VinProperty As String
        Get
            Return vin
        End Get
        Set(value As String)
            vin = value
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
        Set(value As String)
            km = value
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

    Public Property LPlateNumProperty As String
        Get
            Return lPlateNum
        End Get
        Set(value As String)
            lPlateNum = value
        End Set
    End Property

    Public Property AvailableProperty As String
        Get
            Return available
        End Get
        Set(value As String)
            available = value
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

    Public Property BidProperty As String
        Get
            Return bid
        End Get
        Set(value As String)
            bid = value
        End Set
    End Property

    Public Sub New(vin As String)
        Me.VinProperty = vin
    End Sub


    Public Shared Function FindVehicle(vin As String) As Inventory
        Dim checkSQL As String = "SELECT VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage, BID FROM Vehicle WHERE VIN = @vin"
        Dim returnedVin As String = ""
        Dim returnedMake As String
        Dim returnedModel As String
        Dim returnedClass As String
        Dim returnedKm As String
        Dim returnedYear As String
        Dim returnedSeats As String
        Dim returnedGVWR As String
        Dim returnedTrans As String
        Dim returnedPlate As String
        Dim returnedAvail As String
        Dim returnedCoverage As String
        Dim returnedBid As String

        Dim checkParams As New Dictionary(Of String, String)
        checkParams.Add("@vin", vin)
        Dim checkColumns As New List(Of String)
        With checkColumns
            .Add("VIN")
            .Add("Make")
            .Add("Model")
            .Add("Class")
            .Add("Km")
            .Add("Year")
            .Add("Seats")
            .Add("GVWR")
            .Add("Transmission")
            .Add("License")
            .Add("Available")
            .Add("Coverage")
            .Add("BID")
        End With
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(checkSQL, checkParams, checkColumns)
            returnedVin = result("VIN")
            returnedMake = result("Make")
            returnedModel = result("Model")
            returnedClass = result("Class")
            returnedKm = result("Km")
            returnedYear = result("Year")
            returnedSeats = result("Seats")
            returnedGVWR = result("GVWR")
            returnedTrans = result("Transmission")
            returnedPlate = result("License")
            returnedAvail = result("Available")
            returnedCoverage = result("Coverage")
            returnedBid = result("BID")
        Next

        If Not returnedVin.Equals(vin) Then
            Return Nothing
        End If

        Dim newVehicle As New Inventory(returnedVin)

        With newVehicle
            .MakeProperty = returnedMake
            .ModelProperty = returnedModel
            .VClassProperty = returnedClass
            .KmProperty = returnedKm
            .YearProperty = returnedYear
            .SeatsProperty = returnedSeats
            .GvwrProperty = returnedGVWR
            .TransmissionProperty = returnedTrans
            .LPlateNumProperty = returnedPlate
            .AvailableProperty = returnedAvail
            .CoverageProperty = returnedCoverage
            .BidProperty = returnedBid
        End With

        Return newVehicle
    End Function

    Public Overrides Function ToString() As String
        Return vin
    End Function
End Class