﻿Imports MySql.Data.MySqlClient
Public Class ChooseRental
    Private callingForm As ChooseLocation

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
        seatsCombo.Items.Add("All")
        For seat As Integer = 1 To 4
            seatsCombo.Items.Add(seat)
        Next
        seatsCombo.SelectedItem = "All"

        typeCombo.Items.Add("All")
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT Type FROM Types"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim a As String = sqlReader("Type").ToString()
                    typeCombo.Items.Add(a)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
        typeCombo.SelectedItem = "All"

        makeCombo.Items.Add("All")
        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT DISTINCT Make FROM Vehicle"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim Inventory As String = sqlReader("Make").ToString()
                    makeCombo.Items.Add(Inventory)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
        makeCombo.SelectedItem = "All"

        BothRadio.Checked = True

        populateVehiclesTable("SELECT Make, Model, Class, Year, Seats, GVWR, Transmission, DailyRate, WeeklyRate, MonthlyRate
                                FROM Vehicle, Types where Vehicle.Class = Types.Type
                                and Vehicle.Available = 1")

    End Sub

    Sub populateVehiclesTable(sqlText As String)
        vehicleTable.Rows.Clear()
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
                    Dim vehicleInfo As New VehicleInfo
                    vehicleInfo.MakeProperty = sqlReader("Make").ToString()
                    vehicleInfo.ModelProperty = sqlReader("Model").ToString()
                    vehicleInfo.VClassProperty = sqlReader("Class").ToString()
                    vehicleInfo.YearProperty = sqlReader("Year").ToString()
                    vehicleInfo.SeatsProperty = sqlReader("Seats").ToString()
                    vehicleInfo.GvwrProperty = sqlReader("GVWR").ToString()
                    vehicleInfo.TransmissionProperty = sqlReader("Transmission").ToString()
                    vehicleInfo.DailyRateProperty = sqlReader("DailyRate").ToString()
                    vehicleInfo.WeeklyRateProperty = sqlReader("WeeklyRate").ToString()
                    vehicleInfo.MonthlyRateProperty = sqlReader("MonthlyRate").ToString()

                    Dim row = New String() {vehicleInfo.MakeProperty, vehicleInfo.ModelProperty,
                                          vehicleInfo.VClassProperty, vehicleInfo.YearProperty,
                                          vehicleInfo.SeatsProperty, vehicleInfo.TransmissionProperty,
                                          vehicleInfo.GvwrProperty, vehicleInfo.DailyRateProperty,
                                          vehicleInfo.WeeklyRateProperty, vehicleInfo.MonthlyRateProperty}
                    vehicleTable.Rows.Add(row)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
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
        vehicleTable.Rows.Clear()
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

    Private Sub typeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeCombo.SelectedIndexChanged
        vehicleTable.Rows.Clear()
        If Not (typeCombo.Items.Count = 0 Or makeCombo.Items.Count = 0) Then
            populateVehiclesTable(buildQueryString())
        End If
    End Sub

End Class