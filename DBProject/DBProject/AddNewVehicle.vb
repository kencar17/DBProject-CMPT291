Imports MySql.Data.MySqlClient
Public Class AddNewVehicle
    Private Sub addVehicle_Click(sender As Object, e As EventArgs) Handles addVehicle.Click
        Me.wrongInfo.Visible = False

        If VINbox.Text.Equals("") Then
            wrongInfo.Text = "A VIN number must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If MakeBox.Text.Equals("") Then
            wrongInfo.Text = "A vehicle make must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If ModelBox.Text.Equals("") Then
            wrongInfo.Text = "A vehicle model must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If ClassBox.Text.Equals("") Then
            wrongInfo.Text = "A vehicle class must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If KMBox.Text.Equals("") Then
            wrongInfo.Text = "The Kilometers of the vehicle must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If YearBox.Text.Equals("") Then
            wrongInfo.Text = "The year the vehicle was made must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If SeatsBox.Text.Equals("") Then
            wrongInfo.Text = "Seating capacity must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If GVWRBox.Text.Equals("") Then
            wrongInfo.Text = "The Gross Vehicle Weight Rating must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If TransBox.Text.Equals("") Then
            wrongInfo.Text = "The type of transmission must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If AvailBox.Text.Equals("") Then
            wrongInfo.Text = "Must have availability"
            Me.wrongInfo.Visible = True
            Return
        End If

        If CoverageBox.Text.Equals("") Then
            wrongInfo.Text = "The coverage of the vehicle must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        Dim vehicle = Inventory.FindVehicle(Me.VINbox.Text)
        If vehicle IsNot Nothing Then
            wrongInfo.Text = "VIN already in database"
            wrongInfo.Visible = True
            Return
        End If

        Dim vehicleInsertSql As String = "INSERT INTO Vehicle (VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage) VALUES (@vin, @make, @model, @class, @km, @year, @seats, @gvwr, @trans, @license, @avail, @coverage)"
        Dim vehicleInsertParams As New Dictionary(Of String, String)
        With vehicleInsertParams
            .Add("@vin", VINbox.Text)
            .Add("@make", MakeBox.Text)
            .Add("@model", ModelBox.Text)
            .Add("@class", ClassBox.Text)
            .Add("@km", KMBox.Text)
            .Add("@year", YearBox.Text)
            .Add("@seats", SeatsBox.Text)
            .Add("@gvwr", GVWRBox.Text)
            .Add("@trans", TransBox.Text)
            .Add("@license", PlateBox.Text)
            .Add("@avail", AvailBox.Text)
            .Add("@coverage", CoverageBox.Text)
        End With
        SQLConnection.DoNonQuery(vehicleInsertSql, vehicleInsertParams)

        MsgBox("Vehicle Added")
        Me.Close()
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("addNewVehicle")
    End Sub

    'FIDD.Items.Add(Something)

    'Something must have ToString implemented to display it.
End Class