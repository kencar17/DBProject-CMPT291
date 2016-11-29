Imports MySql.Data.MySqlClient
Public Class ChooseLocation
    Private rental As New RentalInfo
    Private conditionTestP As Integer
    Private conditionTestD As Integer
    Private conditionTestL As Integer
    Private conditionTestPT As Integer
    Private conditionTestDT As Integer
    Private callingForm As Home

    Public Property CallingFormProperty As Home
        Get
            Return callingForm
        End Get
        Set
            callingForm = Value
        End Set
    End Property

    Public Property RentalProperty As RentalInfo
        Get
            Return rental
        End Get
        Set
            rental = Value
        End Set
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        prepareInfo()
        If conditionTestP.Equals(0) AndAlso conditionTestD.Equals(0) AndAlso conditionTestL.Equals(0) AndAlso
            conditionTestPT.Equals(0) AndAlso conditionTestDT.Equals(0) Then
            Dim rentalWindow As New ChooseRental
            rentalWindow.RentalProperty = Me.RentalProperty
            rentalWindow.MdiParent = Me.MdiParent
            rentalWindow.CallingFormProperty = Me
            rentalWindow.Show()
        End If
        ' Did not choose location
        If conditionTestL.Equals(1) Then
            errorLocation.ForeColor = Color.Red
            errorLocation.Visible = True
        End If

        ' pickup error check
        If conditionTestP.Equals(1) Then
            invalidPdate.ForeColor = Color.Red
            invalidPdate.Visible = True
        End If
        ' Drop off error check
        If conditionTestD.Equals(1) Then
            invalidDDate.ForeColor = Color.Red
            invalidDDate.Visible = True
        End If
        ' pickup time error check
        If conditionTestPT.Equals(1) Then
            invalidPT.ForeColor = Color.Red
            invalidPT.Visible = True
        End If
        ' dropoff time error check
        If conditionTestDT.Equals(1) Then
            InvalidDT.ForeColor = Color.Red
            InvalidDT.Visible = True
        End If


    End Sub

    Private Sub prepareInfo()
        If locationCombBox.SelectedItem.Equals("Location") Then
            conditionTestL = 1
        Else
            Dim branch As Branch = locationCombBox.SelectedItem
            conditionTestL = 0
            rental.LocationProperty = branch
        End If

        Dim todayDate As Date = Date.Today
        Dim pickDate As Date = pickUp.SelectionStart
        Dim dropDate As Date = dropOff.SelectionStart

        If todayDate > pickDate Then
            ' in past, pickupdate before today
            conditionTestP = 1
        Else
            ' Valid Date
            conditionTestP = 0
            rental.PickUpProperty = pickDate
        End If

        If pickDate > dropDate Then
            ' Invalid Date, dropdate before pickdate
            conditionTestD = 1
        Else
            ' Valid Date
            rental.DropOffProperty = dropDate
            conditionTestD = 0
        End If

        If pickUpTime.SelectedItem.Equals("00:00") Then
            ' Invalid time selected
            conditionTestPT = 1
        Else
            ' valid time selected
            conditionTestPT = 0
            rental.PickUpTimeProperty = pickUpTime.SelectedItem
        End If

        If dropOffTime.SelectedItem.Equals("00:00") Then
            'invalid time selected
            conditionTestDT = 1
        Else
            ' valid time selected
            conditionTestDT = 0
            rental.DropOffTimeProperty = dropOffTime.SelectedItem
        End If


    End Sub

    Public Sub doAThing()
        Hide()
    End Sub

    Private Sub ChooseLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        locationCombBox.Items.Add("Location")
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT DISTINCT * From Branch"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim branch = New Branch()
                    branch.BidProperty = sqlReader("BID").ToString()
                    branch.PostcodeProperty = sqlReader("PostalCode").ToString()
                    branch.AddressProperty = sqlReader("StreetAddress").ToString()
                    branch.CityProperty = sqlReader("City").ToString()
                    branch.StateProperty = sqlReader("State").ToString()
                    branch.CountryProperty = sqlReader("Country").ToString()
                    branch.EmailProperty = sqlReader("Email").ToString()
                    branch.PhoneProperty = sqlReader("Phone").ToString()
                    branch.FaxProperty = sqlReader("Fax").ToString()
                    branch.ManidProperty = sqlReader("ManagerID").ToString()
                    locationCombBox.Items.Add(branch)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
        locationCombBox.SelectedItem = "Location"

        pickUpTime.Items.Add("00:00")
        dropOffTime.Items.Add("00:00")

        For time As Integer = 8 To 19
            Dim num As String = CStr(time)
            If time.Equals(8) OrElse time.Equals(9) Then
                num = "0" + CStr(time)
            End If

            Dim number As String = CStr(num) + ":00"
            pickUpTime.Items.Add(number)
            dropOffTime.Items.Add(number)

            Dim number2 As String = CStr(num) + ":30"
            pickUpTime.Items.Add(number2)
            dropOffTime.Items.Add(number2)
        Next
        pickUpTime.SelectedItem = "00:00"
        dropOffTime.SelectedItem = "00:00"

        locationLabel.BackColor = Color.Transparent
        pickLabel.BackColor = Color.Transparent
        dropLabel.BackColor = Color.Transparent
        dtimeLabel.BackColor = Color.Transparent
        ptimeLabel.BackColor = Color.Transparent
        errorLocation.BackColor = Color.Transparent
        invalidDDate.BackColor = Color.Transparent
        invalidPdate.BackColor = Color.Transparent
        invalidPT.BackColor = Color.Transparent
        InvalidDT.BackColor = Color.Transparent

    End Sub

    Private Sub locationCombBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles locationCombBox.SelectedIndexChanged
        errorLocation.Visible = False
    End Sub

    Private Sub pickUp_DateChanged(sender As Object, e As DateRangeEventArgs) Handles pickUp.DateChanged
        invalidPdate.Visible = False
    End Sub

    Private Sub dropOff_DateChanged(sender As Object, e As DateRangeEventArgs) Handles dropOff.DateChanged
        invalidDDate.Visible = False
    End Sub

    Private Sub pickUpTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pickUpTime.SelectedIndexChanged
        invalidPT.Visible = False
    End Sub

    Private Sub dropOffTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropOffTime.SelectedIndexChanged
        InvalidDT.Visible = False
    End Sub

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        Help.GetHelp("rentals")
    End Sub
End Class