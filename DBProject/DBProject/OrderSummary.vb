Public Class OrderSummary
    Private callingform As createOrder
    Private rental As RentalInfo

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

            daysLabel.Text = days.ToString
            daysLabel.BackColor = Color.Transparent


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
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub finishButton_Click(sender As Object, e As EventArgs) Handles finishButton.Click
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
