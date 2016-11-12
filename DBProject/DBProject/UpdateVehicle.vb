Imports MySql.Data.MySqlClient
Public Class UpdateVehicle

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim vehicle = Inventory.FindVehicle(Me.VINUpdate.Text)
        If vehicle Is Nothing Then
            ErrorLabel.Text = "VIN not found"
            ErrorLabel.Visible = True
            Return
        End If

        MakeBox.Text = vehicle.MakeProperty
        ModelBox.Text = vehicle.ModelProperty
        ClassBox.Text = vehicle.VClassProperty
        KmBox.Text = vehicle.KmProperty
        YearBox.Text = vehicle.YearProperty
        SeatBox.Text = vehicle.SeatsProperty
        GVWRBox.Text = vehicle.GvwrProperty
        TransBox.Text = vehicle.TransmissionProperty
        PlateBox.Text = vehicle.LPlateNumProperty
        AvailBox.Text = vehicle.AvailableProperty
        CoverageBox.Text = vehicle.CoverageProperty

    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Me.ErrorLabel.Visible = False

        If MakeBox.Text.Equals("") Then
            ErrorLabel.Text = "A vehicle make must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If ModelBox.Text.Equals("") Then
            ErrorLabel.Text = "A vehicle model must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If ClassBox.Text.Equals("") Then
            ErrorLabel.Text = "A vehicle class must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If KmBox.Text.Equals("") Then
            ErrorLabel.Text = "The Kilometers of the vehicle must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If YearBox.Text.Equals("") Then
            ErrorLabel.Text = "The year the vehicle was made must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If SeatBox.Text.Equals("") Then
            ErrorLabel.Text = "Seating capacity must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If GVWRBox.Text.Equals("") Then
            ErrorLabel.Text = "The Gross Vehicle Weight Rating must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If TransBox.Text.Equals("") Then
            ErrorLabel.Text = "The type of transmission must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If AvailBox.Text.Equals("") Then
            ErrorLabel.Text = "Must have availability"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If CoverageBox.Text.Equals("") Then
            ErrorLabel.Text = "The coverage of the vehicle must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()

        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "UPDATE Vehicle SET Make=@make, Model=@model, Class=@class, Km=@km, Year=@year, Seats=@seats, GVWR=@gvwr, Transmission=@trans, License=@license, Available=@avail, Coverage=@coverage WHERE Vehicle.VIN = @vin"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@vin", VINUpdate.Text)
                .Parameters.AddWithValue("@make", MakeBox.Text)
                .Parameters.AddWithValue("@model", ModelBox.Text)
                .Parameters.AddWithValue("@class", ClassBox.Text)
                .Parameters.AddWithValue("@km", KmBox.Text)
                .Parameters.AddWithValue("@year", YearBox.Text)
                .Parameters.AddWithValue("@seats", SeatBox.Text)
                .Parameters.AddWithValue("@gvwr", GVWRBox.Text)
                .Parameters.AddWithValue("@trans", TransBox.Text)
                .Parameters.AddWithValue("@license", PlateBox.Text)
                .Parameters.AddWithValue("@avail", AvailBox.Text)
                .Parameters.AddWithValue("@coverage", CoverageBox.Text)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()
        MsgBox("Vehicle Updated")
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("UpdateVehicle")
    End Sub
End Class