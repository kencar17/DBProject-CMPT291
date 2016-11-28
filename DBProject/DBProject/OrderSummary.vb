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
        If RentalProperty IsNot Nothing Then
            Fname.Text = RentalProperty.CustomerProperty.FnameProperty
            Lname.Text = RentalProperty.CustomerProperty.LnameProperty
            email.Text = RentalProperty.CustomerProperty.EmailProperty
            age.Text = RentalProperty.CustomerProperty.ageProperty
            address.Text = RentalProperty.CustomerProperty.AddressProperty
            Dim state As String = RentalProperty.CustomerProperty.StateProperty
            Dim city As String = RentalProperty.CustomerProperty.FnameProperty
            Dim country As String = RentalProperty.CustomerProperty.CountryProperty
            Dim postal As String = RentalProperty.CustomerProperty.PostcodeProperty
            cityProv.Text = city & ", " & state
            countryPostal.Text = country & ", " & postal

            Dim pickUpDate As DateTime = RentalProperty.PickUpProperty
            Dim dropOffDate As DateTime = RentalProperty.DropOffProperty
            Dim pickTime As String = RentalProperty.PickUpTimeProperty
            Dim dropTime As String = RentalProperty.DropOffTimeProperty
            pickUp.Text = pickUpDate & " at " & pickTime & "  to  " & dropOffDate & " at " & dropTime
            Dim days As Int32 = dropOffDate.Subtract(pickUpDate).Days
            Console.WriteLine(days)
            daysLabel.Text = days.ToString


            Dim stateBranch As String = RentalProperty.LocationProperty.StateProperty
            Dim cityBranch As String = RentalProperty.LocationProperty.CityProperty
            Dim countryBranch As String = RentalProperty.LocationProperty.CountryProperty
            Dim postalBranch As String = RentalProperty.LocationProperty.PostcodeProperty
            branchAdd.Text = RentalProperty.LocationProperty.AddressProperty
            branchCityPro.Text = cityBranch & ", " & stateBranch
            branchConPos.Text = countryBranch & ", " & postalBranch
            branchEmail.Text = RentalProperty.LocationProperty.EmailProperty
            branchPhone.Text = RentalProperty.LocationProperty.PhoneProperty
            branchFax.Text = RentalProperty.LocationProperty.FaxProperty
            branchMan.Text = RentalProperty.LocationProperty.MannameProperty

            Dim list As New List(Of VehicleInfo)
            list.Add(RentalProperty.VehicleProperty)

            vehicle.DataSource = list

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
End Class