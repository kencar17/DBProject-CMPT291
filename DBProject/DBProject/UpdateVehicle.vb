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

        Dim sql As String = "UPDATE Vehicle SET Make=@make, Model=@model, Class=@class, Km=@km, Year=@year, Seats=@seats, GVWR=@gvwr, Transmission=@trans, License=@license, Available=@avail, Coverage=@coverage WHERE Vehicle.VIN = @vin"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@vin", VINUpdate.Text)
            .Add("@make", MakeBox.Text)
            .Add("@model", ModelBox.Text)
            .Add("@class", ClassBox.Text)
            .Add("@km", KmBox.Text)
            .Add("@year", YearBox.Text)
            .Add("@seats", SeatBox.Text)
            .Add("@gvwr", GVWRBox.Text)
            .Add("@trans", TransBox.Text)
            .Add("@license", PlateBox.Text)
            .Add("@avail", If(AvailBox.Text.Equals("True"), 1, 0))
            .Add("@coverage", CoverageBox.Text)
        End With
        SQLConnection.DoNonQuery(sql, params)

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