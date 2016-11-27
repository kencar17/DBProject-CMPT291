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
                                FROM Vehicle, Types where Vehicle.Class = Types.Type")

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
            vehicleInfo.DailyRate = result("DailyRate")
            vehicleInfo.WeeklyRate = result("WeeklyRate")
            vehicleInfo.MonthlyRate = result("MonthlyRate")

            vehiclesList.Add(vehicleInfo)
        Next
        vehicleTable.DataSource = vehiclesList

    End Sub

    Public Function buildQueryString()
        Dim original As String = "SELECT Make, Model, Class, Year, Seats, GVWR, Transmission, DailyRate, WeeklyRate, MonthlyRate
                                FROM Vehicle, Types where Vehicle.Class = Types.Type"
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

        Return newQuery
    End Function

    Private Sub makeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles makeCombo.SelectedIndexChanged, typeCombo.SelectedIndexChanged, BothRadio.CheckedChanged, autoRadio.CheckedChanged, stanRadio.CheckedChanged
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub vehicleTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehicleTable.CellClick
        'Console.WriteLine("Clicked")
        Dim mode As SelectionMode = vehicleTable.SelectionMode
        If mode = SelectionMode.None Then
            Return
        End If
        Dim row As Integer = vehicleTable.SelectedCells(0).RowIndex
        Dim make As String = vehicleTable.Rows(row).Cells(0).Value
        Dim model As String = vehicleTable.Rows(row).Cells(1).Value
        Dim year As String = vehicleTable.Rows(row).Cells(3).Value

        Dim imgSql = "SELECT ImageUrl FROM Vehicle WHERE make=@make AND model=@model AND year=@year"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@make", make)
            .Add("@model", model)
            .Add("@year", year)
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
End Class
