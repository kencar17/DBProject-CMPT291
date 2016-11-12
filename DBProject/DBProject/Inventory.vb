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

    Public Sub New(vin As String)
        Me.VinProperty = vin
    End Sub


    Public Shared Function FindVehicle(vin As String) As Inventory
        Dim checkSQL As String = "SELECT VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage FROM Vehicle WHERE VIN = @vin"
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

        Dim dbConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbConnection
                .CommandText = checkSQL
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@vin", vin)
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    returnedVin = sqlReader("VIN").ToString()
                    returnedMake = sqlReader("Make").ToString()
                    returnedModel = sqlReader("Model").ToString()
                    returnedClass = sqlReader("Class").ToString()
                    returnedKm = sqlReader("Km").ToString()
                    returnedYear = sqlReader("Year").ToString()
                    returnedSeats = sqlReader("Seats").ToString()
                    returnedGVWR = sqlReader("GVWR").ToString()
                    returnedTrans = sqlReader("Transmission").ToString()
                    returnedPlate = sqlReader("License").ToString()
                    returnedAvail = sqlReader("Available").ToString()
                    returnedCoverage = sqlReader("Coverage").ToString()
                End While
            Catch ex As Exception
                Return Nothing
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

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
        End With

        Return newVehicle
    End Function

    Public Overrides Function ToString() As String
        Return vin
    End Function
End Class