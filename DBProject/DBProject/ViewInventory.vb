Imports MySql.Data.MySqlClient
Public Class ViewInventory
    Private callingForm As Form

    Public WriteOnly Property CallingFormProperty As Form
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        callingForm.WindowState = FormWindowState.Maximized
        Close()
    End Sub

    Private Sub seatsCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seatsCombo.SelectedIndexChanged
        vehicleTable.Rows.Clear()
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(typeSql, typeParams, typeColumns)
            typeCombo.Items.Add(result("Type"))
        Next
        typeCombo.SelectedItem = "All"

        makeCombo.Items.Add("All")
        Dim makeSql As String = "SELECT DISTINCT Make FROM Vehicle"
        Dim makeParams As New Dictionary(Of String, String)
        Dim makeColumns As New List(Of String)
        makeColumns.Add("Make")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(makeSql, makeParams, makeColumns)
            makeCombo.Items.Add(result("Make"))
        Next
        makeCombo.SelectedItem = "All"

        BothRadio.Checked = True

        populateVehiclesTable("SELECT Make, Model, Class, Year, Seats, GVWR, Transmission, DailyRate, WeeklyRate, MonthlyRate
                                FROM Vehicle, Types where Vehicle.Class = Types.Type
                                and Vehicle.Available = 1")

    End Sub

    Private Sub ChooseRental_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        'callingForm.WindowState = FormWindowState.Maximized
    End Sub

    Sub populateVehiclesTable(sqlText As String)
        vehicleTable.Rows.Clear()
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
            Dim transmission As String = result("Transmission")
            If transmission IsNot Nothing Then
                If transmission.Equals("1") Or transmission.ToLower().Equals("automatic") Then
                    vehicleInfo.Transmission = "Automatic"
                Else
                    vehicleInfo.Transmission = "Standard"
                End If
            End If
            vehicleInfo.DailyRate = result("DailyRate")
            vehicleInfo.WeeklyRate = result("WeeklyRate")
            vehicleInfo.MonthlyRate = result("MonthlyRate")

            Dim row = New String() {vehicleInfo.Make, vehicleInfo.Model,
                                  vehicleInfo.VClass, vehicleInfo.Year,
                                  vehicleInfo.Seats, vehicleInfo.Transmission,
                                  vehicleInfo.Gvwr, vehicleInfo.DailyRate,
                                  vehicleInfo.WeeklyRate, vehicleInfo.MonthlyRate}
            vehicleTable.Rows.Add(row)
        Next
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
            newQuery = newQuery & " and Vehicle.Transmission = '1'"
        ElseIf stanRadio.Checked = True Then
            newQuery = newQuery & " and Vehicle.Transmission = '0'"
        End If

        Return newQuery
    End Function

    Private Sub makeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles makeCombo.SelectedIndexChanged, typeCombo.SelectedIndexChanged, BothRadio.CheckedChanged, autoRadio.CheckedChanged, stanRadio.CheckedChanged
        vehicleTable.Rows.Clear()
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub
End Class
