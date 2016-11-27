Imports MySql.Data.MySqlClient
Public Class ChooseRental
    Private callingForm As ChooseLocation
    Private rental As RentalInfo

    Public Property RentalProperty As RentalInfo
        Get
            Return rental
        End Get
        Set
            rental = Value
        End Set
    End Property

    Public WriteOnly Property CallingFormProperty As ChooseLocation
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim createOrderWindow As New createOrder
        createOrderWindow.MdiParent = Me.MdiParent
        createOrderWindow.CallingFormProperty = Me
        createOrderWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub

    Private Sub seatsCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seatsCombo.SelectedIndexChanged
        vehicleTable.Rows.Clear()
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub ChooseRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(rental.PickUpProperty)
        Console.WriteLine(rental.PickUpTimeProperty)
        Console.WriteLine(rental.DropOffProperty)
        Console.WriteLine(rental.DropOffTimeProperty)
        Console.WriteLine(rental.LocationProperty)
        Console.WriteLine()

        seatsCombo.Items.Add("All")
        For seat As Integer = 1 To 4
            seatsCombo.Items.Add(seat)
        Next
        seatsCombo.SelectedItem = "All"

        typeCombo.Items.Add("All")
        Dim typeSql As String = "SELECT Type FROM Types"
        Dim typeParams As New Dictionary(Of String, String)
        Dim typeColumns As New List(Of String)
        typeColumns.Add("Type")
        For Each result In SQLConnection.DoQuery(typeSql, typeParams, typeColumns)
            typeCombo.Items.Add(result("Type"))
        Next
        typeCombo.SelectedItem = "All"

        makeCombo.Items.Add("All")
        Dim makeSql As String = "SELECT DISTINCT Make FROM Vehicle"
        Dim makeParams As New Dictionary(Of String, String)
        Dim makeColumns As New List(Of String)
        makeColumns.Add("Make")
        For Each result In SQLConnection.DoQuery(makeSql, makeParams, makeColumns)
            makeCombo.Items.Add(result("Make"))
        Next
        makeCombo.SelectedItem = "All"

        BothRadio.Checked = True

        populateVehiclesTable("SELECT Make, Model, Class, Year, Seats, GVWR, Transmission, DailyRate, WeeklyRate, MonthlyRate
                                FROM Vehicle, Types where Vehicle.Class = Types.Type
                                and Vehicle.Available = 1")

    End Sub

    Sub populateVehiclesTable(sqlText As String)
        'vehicleTable.Rows.Clear()
        Dim vehiclesList = New List(Of VehicleInfo)
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = sqlText
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        With columns
            .Add("Make")
            .Add("Model")
            .Add("Class")
            .Add("Year")
            .Add("Seats")
            .Add("GVWR")
            .Add("Transmission")
            .Add("DailyRate")
            .Add("WeeklyRate")
            .Add("MonthlyRate")
        End With
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(sqlText, params, columns)
            Dim vehicleInfo As New VehicleInfo
            vehicleInfo.MakeProperty = result("Make")
            vehicleInfo.ModelProperty = result("Model")
            vehicleInfo.VClassProperty = result("Class")
            vehicleInfo.YearProperty = result("Year")
            vehicleInfo.SeatsProperty = result("Seats")
            vehicleInfo.GvwrProperty = result("GVWR")
            Dim transmission As String = ""
            If result("Transmission").Equals(0) Then
                transmission = "Manual"
            Else
                transmission = "Automatic"
            End If
            vehicleInfo.TransmissionProperty = transmission
            vehicleInfo.DailyRateProperty = result("DailyRate")
            vehicleInfo.WeeklyRateProperty = result("WeeklyRate")
            vehicleInfo.MonthlyRateProperty = result("MonthlyRate")

            vehiclesList.Add(vehicleInfo)

            'Dim row = New String() {vehicleInfo.MakeProperty, vehicleInfo.ModelProperty,
            'vehicleInfo.VClassProperty, vehicleInfo.YearProperty,
            'vehicleInfo.SeatsProperty, vehicleInfo.TransmissionProperty,
            'vehicleInfo.GvwrProperty, vehicleInfo.DailyRateProperty,
            'vehicleInfo.WeeklyRateProperty, vehicleInfo.MonthlyRateProperty}

            'vehicleTable.Rows.Add(row)
        Next
        vehicleTable.DataSource = vehiclesList

    End Sub

    Public Function buildQueryString()
        Dim original As String = "SELECT Make, Model, Class, Year, Seats, GVWR, Transmission, DailyRate, WeeklyRate, MonthlyRate
                                FROM Vehicle, Types where Vehicle.Class = Types.Type
                                and Vehicle.Available = 1"
        Dim newQuery As String = ""

        newQuery = original
        ' Vehicle seats
        If seatsCombo.SelectedItem.Equals("All") = True Then
            ' Do nothing
        Else
            newQuery = newQuery & " and Vehicle.Seats = " & seatsCombo.SelectedItem
        End If

        ' Vehicle class
        If typeCombo.SelectedItem.Equals("All") = True Then
            ' Do nothing
        Else
            newQuery = newQuery & " and Vehicle.Class = '" & typeCombo.SelectedItem & "'"
        End If

        ' Make of vehicles
        If makeCombo.SelectedItem.Equals("All") = True Then
            ' Do nothing
        Else
            newQuery = newQuery & " and Vehicle.Make = '" & makeCombo.SelectedItem & "'"
        End If

        ' Make of Transmission
        If BothRadio.Checked = True Then
            ' Do nothing
        ElseIf autoRadio.Checked = True Then
            newQuery = newQuery & " and Vehicle.Transmission = 'Automatic'"
        ElseIf stanRadio.Checked = True Then
            newQuery = newQuery & " and Vehicle.Transmission = 'Standard'"
        End If

        Return newQuery
    End Function

    Private Sub makeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles makeCombo.SelectedIndexChanged

        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub typeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeCombo.SelectedIndexChanged

        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

End Class
