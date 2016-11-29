Public Class OrderSummary
    Private callingform As createOrder
    Private rental As RentalInfo
    Private cost As Double

    Public Property RentalProperty As RentalInfo
        Get
            Return rental
        End Get
        Set
            rental = Value
        End Set
    End Property

    Public WriteOnly Property CallingformProperty As createOrder
        Set
            callingform = Value
        End Set
    End Property

    Private Sub createOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        If RentalProperty IsNot Nothing Then
            Fname.Text = RentalProperty.CustomerProperty.FnameProperty
            Fname.BackColor = Color.Transparent
            Lname.Text = RentalProperty.CustomerProperty.LnameProperty
            Lname.BackColor = Color.Transparent
            email.Text = RentalProperty.CustomerProperty.EmailProperty
            email.BackColor = Color.Transparent
            age.Text = RentalProperty.CustomerProperty.ageProperty
            age.BackColor = Color.Transparent
            address.Text = RentalProperty.CustomerProperty.AddressProperty
            address.BackColor = Color.Transparent
            Dim state As String = RentalProperty.CustomerProperty.StateProperty
            Dim city As String = RentalProperty.CustomerProperty.FnameProperty
            Dim country As String = RentalProperty.CustomerProperty.CountryProperty
            Dim postal As String = RentalProperty.CustomerProperty.PostcodeProperty
            cityProv.Text = city & ", " & state
            cityProv.BackColor = Color.Transparent
            countryPostal.Text = country & ", " & postal
            countryPostal.BackColor = Color.Transparent

            Dim pickUpDate As DateTime = RentalProperty.PickUpProperty
            Dim dropOffDate As DateTime = RentalProperty.DropOffProperty
            Dim pickTime As String = RentalProperty.PickUpTimeProperty
            Dim dropTime As String = RentalProperty.DropOffTimeProperty
            pickUp.Text = pickUpDate & " at " & pickTime & "  to  " & dropOffDate & " at " & dropTime
            pickUp.BackColor = Color.Transparent
            Dim days As Int32 = dropOffDate.Subtract(pickUpDate).Days
            If days = 0 Then
                days = 1
            End If

            daysLabel.Text = days.ToString
            daysLabel.BackColor = Color.Transparent

            Dim d As New DateTime(New TimeSpan(days, 0, 0, 0).Ticks)
            Dim months As Integer = d.Month - 1
            Dim tdays As Integer = d.Day - 1
            Dim weeks As Integer = 0
            If tdays >= 7 Then
                weeks = Math.Floor(tdays / 7)
                tdays = tdays Mod 7
            End If

            cost = tdays * rental.VehicleProperty.DailyRate + weeks * rental.VehicleProperty.WeeklyRate + months * rental.VehicleProperty.MonthlyRate
            costlabel.Text = "$" & cost

            Dim stateBranch As String = RentalProperty.LocationProperty.StateProperty
            Dim cityBranch As String = RentalProperty.LocationProperty.CityProperty
            Dim countryBranch As String = RentalProperty.LocationProperty.CountryProperty
            Dim postalBranch As String = RentalProperty.LocationProperty.PostcodeProperty
            branchAdd.Text = RentalProperty.LocationProperty.AddressProperty
            branchAdd.BackColor = Color.Transparent
            branchCityPro.Text = cityBranch & ", " & stateBranch
            branchCityPro.BackColor = Color.Transparent
            branchConPos.Text = countryBranch & ", " & postalBranch
            branchConPos.BackColor = Color.Transparent
            branchEmail.Text = RentalProperty.LocationProperty.EmailProperty
            branchEmail.BackColor = Color.Transparent
            branchPhone.Text = RentalProperty.LocationProperty.PhoneProperty
            branchPhone.BackColor = Color.Transparent
            branchFax.Text = RentalProperty.LocationProperty.FaxProperty
            branchFax.BackColor = Color.Transparent
            branchMan.Text = RentalProperty.LocationProperty.MannameProperty
            branchMan.BackColor = Color.Transparent

            customerLabel.BackColor = Color.Transparent
            FnameLabel.BackColor = Color.Transparent
            LnameLabel.BackColor = Color.Transparent
            emailLabel.BackColor = Color.Transparent
            ageLabel.BackColor = Color.Transparent
            managerLabel.BackColor = Color.Transparent
            BemailLabel.BackColor = Color.Transparent
            phoneLabel.BackColor = Color.Transparent
            faxLabel.BackColor = Color.Transparent
            rateDatesLabel.BackColor = Color.Transparent
            rateDaysLabel.BackColor = Color.Transparent
            branchLabel.BackColor = Color.Transparent
            vehicleLabel.BackColor = Color.Transparent
            rateLabel.BackColor = Color.Transparent

            Dim list As New List(Of VehicleInfo)
            list.Add(RentalProperty.VehicleProperty)

            vehicle.DataSource = list

            vehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            vehicle.Columns(0).Visible = False
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub finishButton_Click(sender As Object, e As EventArgs) Handles finishButton.Click
        Dim vehicle As VehicleInfo = rental.VehicleProperty

        ' Commit to DB
        Dim sql As String = "INSERT INTO Transaction (VIN, CID, EID, FromBID, ToBID, FromDate, ToDate, Cost) VALUES (@vin, @cid, @eid, @frombid, @tobid, @fromdate, @todate, @cost)"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@vin", vehicle.VinProperty)
            .Add("@cid", RentalProperty.CustomerProperty.IdProperty)
            .Add("@eid", callingform.CallingFormProperty.CallingFormProperty.CallingFormProperty.LoggedInUserProperty.IdProperty)
            .Add("@frombid", callingform.CallingFormProperty.CallingFormProperty.CallingFormProperty.LoggedInUserProperty.BranchProperty)
            .Add("@tobid", rental.LocationProperty.BidProperty)
            .Add("@fromdate", rental.PickUpProperty)
            .Add("@todate", rental.DropOffProperty)
            .Add("@cost", cost)
        End With
        SQLConnection.DoNonQuery(sql, params)
        MsgBox("The transaction has been created.")

        callingform.doAThing()
        Close()
    End Sub

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        Help.GetHelp("rentals")
    End Sub

    Private Sub OrderSummary_Unload() Handles MyBase.Closing
        MdiParent.Size = New Size(722, 535)
    End Sub
End Class
