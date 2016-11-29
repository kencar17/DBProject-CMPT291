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

    Public Property CallingFormProperty As ChooseLocation
        Set
            callingForm = Value
        End Set
        Get
            Return callingForm
        End Get
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' Error check
        Dim mode As SelectionMode = vehicleTable.SelectionMode
        If mode = SelectionMode.None Then
            Return
        End If

        prepareInfo()
        Dim createOrderWindow As New createOrder
        createOrderWindow.RentalProperty = Me.RentalProperty
        createOrderWindow.MdiParent = Me.MdiParent
        createOrderWindow.CallingFormProperty = Me
        createOrderWindow.Show()
    End Sub

    Private Sub prepareInfo()
        Dim row As Integer = vehicleTable.SelectedCells(0).RowIndex
        Dim vin As String = vehicleTable.Rows(row).Cells(0).Value
        Dim vehicle As VehicleInfo = TryCast(vehicleTable.Rows(row).DataBoundItem, VehicleInfo)
        rental.VehicleProperty = vehicle
    End Sub


    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub

    Private Sub ChooseRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        Dim seatsList = New List(Of String)
        seatsList.Add("All")
        For seat As Integer = 1 To 10
            seatsList.Add(seat.ToString)
        Next
        seatsCombo.DataSource = seatsList
        seatsCombo.SelectedItem = "All"

        Dim branch As String = RentalProperty.LocationProperty.BidProperty
        'Dim sqltext As String = "SELECT DISTINCT Vehicle.VIN, Make, Model, Class, Year, Seats, GVWR, Transmission, Coverage, DailyRate, WeeklyRate, MonthlyRate, FromDate, ToDate FROM Vehicle JOIN Types ON Vehicle.Class = Types.Type LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN where Vehicle.Available = 1 and NOT (" & rental.PickUpProperty & " < ToDate AND " & rental.DropOffProperty & " > FromDate) AND Vehicle.BID = " & branch & " GROUP BY (Vehicle.VIN)"
        Dim sqltext As String = "SELECT DISTINCT Vehicle.VIN, Make, Model, Class, Year, Seats, GVWR, Transmission, Coverage, DailyRate, WeeklyRate, MonthlyRate
FROM Vehicle
  JOIN Types on Vehicle.Class = Types.Type
  LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN
WHERE Vehicle.Available = 1
  AND Vehicle.BID = " & callingForm.CallingFormProperty.LoggedInUserProperty.BranchProperty & "
  AND Vehicle.VIN NOT IN (
    SELECT Vehicle.VIN
    FROM Vehicle
      JOIN Types on Vehicle.Class = Types.Type
      LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN
    WHERE CAST('" & rental.PickUpProperty & "' AS DATE) < ToDate AND CAST('" & rental.DropOffProperty & "' AS DATE) > FromDate
  )
GROUP BY Vehicle.VIN"

        Dim vehiclesList = New List(Of VehicleInfo)
        Dim makeList = New List(Of String)
        makeList.Add("All")
        Dim typeList = New List(Of String)
        typeList.Add("All")
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = sqltext
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
            .Add("Coverage")
            .Add("DailyRate")
            .Add("WeeklyRate")
            .Add("MonthlyRate")
            .Add("VIN")
        End With
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(sqltext, params, columns)
            Dim vehicleInfo As New VehicleInfo
            vehicleInfo.Make = result("Make")
            vehicleInfo.Model = result("Model")
            vehicleInfo.VClass = result("Class")
            vehicleInfo.Year = result("Year")
            vehicleInfo.Seats = result("Seats")
            vehicleInfo.Gvwr = result("GVWR")
            Dim transmission As String = ""
            If result("Transmission").Equals("0") Then
                transmission = "Manual"
            Else
                transmission = "Automatic"
            End If
            vehicleInfo.Transmission = transmission
            vehicleInfo.Coverage = result("Coverage")
            vehicleInfo.DailyRate = result("DailyRate")
            vehicleInfo.WeeklyRate = result("WeeklyRate")
            vehicleInfo.MonthlyRate = result("MonthlyRate")
            vehicleInfo.VinProperty = result("VIN")
            vehiclesList.Add(vehicleInfo)

            If Not makeList.Contains(result("Make")) Then
                makeList.Add(result("Make"))
            End If

            If Not typeList.Contains(result("Class")) Then
                typeList.Add(result("Class"))
            End If

        Next

        vehicleTable.MultiSelect = False
        vehicleTable.DataSource = vehiclesList

        typeCombo.DataSource = typeList
        typeCombo.SelectedItem = "All"
        makeCombo.DataSource = makeList
        makeCombo.SelectedItem = "All"

        vehicleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        vehicleTable.Columns(0).Visible = False

        typeLabel.BackColor = Color.Transparent
        makeLabel.BackColor = Color.Transparent
        seatsLabel.BackColor = Color.Transparent
        transmissionLabel.BackColor = Color.Transparent
        BothRadio.BackColor = Color.Transparent
        stanRadio.BackColor = Color.Transparent
        autoRadio.BackColor = Color.Transparent

    End Sub

    Sub populateVehiclesTable(sqlText As String)

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
            .Add("Coverage")
            .Add("DailyRate")
            .Add("WeeklyRate")
            .Add("MonthlyRate")
            .Add("VIN")
        End With
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(sqlText, params, columns)
            Dim vehicleInfo As New VehicleInfo
            vehicleInfo.Make = result("Make")
            vehicleInfo.Model = result("Model")
            vehicleInfo.VClass = result("Class")
            vehicleInfo.Year = result("Year")
            vehicleInfo.Seats = result("Seats")
            vehicleInfo.Gvwr = result("GVWR")
            Dim transmission As String = ""
            If result("Transmission").Equals("0") Then
                transmission = "Manual"
            Else
                transmission = "Automatic"
            End If
            vehicleInfo.Transmission = transmission
            vehicleInfo.Coverage = result("Coverage")
            vehicleInfo.DailyRate = result("DailyRate")
            vehicleInfo.WeeklyRate = result("WeeklyRate")
            vehicleInfo.MonthlyRate = result("MonthlyRate")
            vehicleInfo.VinProperty = result("VIN")
            vehiclesList.Add(vehicleInfo)
        Next
        vehicleTable.MultiSelect = False
        vehicleTable.DataSource = vehiclesList

        vehicleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


    End Sub

    Public Function buildQueryString()
        Dim branch As String = RentalProperty.LocationProperty.BidProperty
        'Dim original As String = "SELECT DISTINCT Vehicle.VIN, Make, Model, Class, Year, Seats, GVWR, Transmission, Coverage, DailyRate, WeeklyRate, MonthlyRate, FromDate, ToDate FROM Vehicle JOIN Types ON Vehicle.Class = Types.Type LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN where Vehicle.Available = 1 and NOT (" & rental.PickUpProperty & " < ToDate AND " & rental.DropOffProperty & " > FromDate) AND Vehicle.BID = " & branch & " GROUP BY (Vehicle.VIN)"
        Dim original As String = "SELECT DISTINCT Vehicle.VIN, Make, Model, Class, Year, Seats, GVWR, Transmission, Coverage, DailyRate, WeeklyRate, MonthlyRate
FROM Vehicle
  JOIN Types on Vehicle.Class = Types.Type
  LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN
WHERE Vehicle.Available = 1
  AND Vehicle.BID = " & callingForm.CallingFormProperty.LoggedInUserProperty.BranchProperty & "
  AND Vehicle.VIN NOT IN (
    SELECT Vehicle.VIN
    FROM Vehicle
      JOIN Types on Vehicle.Class = Types.Type
      LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN
    WHERE CAST('" & rental.PickUpProperty & "' AS DATE) < ToDate AND CAST('" & rental.DropOffProperty & "' AS DATE) > FromDate
  )"

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
            newQuery = newQuery & " and Vehicle.Transmission = '1'"
        ElseIf stanRadio.Checked = True Then
            newQuery = newQuery & " and Vehicle.Transmission = '0'"
        End If

        Return newQuery & " GROUP BY Vehicle.VIN"
    End Function

    Private Sub vehicleTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehicleTable.CellClick
        Dim mode As SelectionMode = vehicleTable.SelectionMode
        If mode = SelectionMode.None Then
            Return
        End If
        Dim row As Integer = vehicleTable.SelectedCells(0).RowIndex
        Dim vin As String = vehicleTable.Rows(row).Cells(0).Value

        Dim imgSql = "SELECT ImageUrl FROM Vehicle WHERE VIN=@vin"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@vin", vin)
        End With
        Dim columns As New List(Of String)
        columns.Add("ImageUrl")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(imgSql, params, columns)
            Dim url As String = result("ImageUrl")
            If url IsNot Nothing AndAlso Not url.Equals("") Then
                VehiclePicture.Load(result("ImageUrl"))
            Else
                VehiclePicture.Image = Nothing
            End If
        Next
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        seatsCombo.SelectedItem = "All"
        typeCombo.SelectedItem = "All"
        makeCombo.SelectedItem = "All"
        BothRadio.Checked = True
        autoRadio.Checked = False
        stanRadio.Checked = False

        populateVehiclesTable(buildQueryString())
    End Sub

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        Help.GetHelp("rentals")
    End Sub
End Class
