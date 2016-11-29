Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class createOrder
    Private callingForm As ChooseRental
    Private rental As RentalInfo
    Private conditionTest As Integer

    Public Property RentalProperty As RentalInfo
        Get
            Return rental
        End Get
        Set
            rental = Value
        End Set
    End Property

    Public Property CallingFormProperty As ChooseRental
        Set
            callingForm = Value
        End Set
        Get
            Return callingForm
        End Get
    End Property


    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        prepareInfo()

        If conditionTest.Equals(0) Then
            Dim orderSummaryWindow As New OrderSummary
            orderSummaryWindow.RentalProperty = Me.RentalProperty
            orderSummaryWindow.MdiParent = Me.MdiParent
            orderSummaryWindow.CallingformProperty = Me
            orderSummaryWindow.Show()
        End If


    End Sub

    Private Sub prepareInfo()
        'Dim personTest As Person = 
        Dim person As New Person

        If existingCustomers.SelectedItem IsNot Nothing Then

            Console.WriteLine("selected index")
            person = existingCustomers.SelectedItem
            rental.CustomerProperty = person
            conditionTest = 0
        Else
            Dim count As Integer = 0

            If CFnameTextField.Text = "" Then
                SendMessage(Me.CFnameTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.FnameProperty = CFnameTextField.Text
                count = count + 1
            End If
            If CLnameTextField.Text = "" Then
                SendMessage(Me.CLnameTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.LnameProperty = CLnameTextField.Text
                count = count + 1
            End If
            If CPostalTextField.Text = "" Then
                SendMessage(Me.CPostalTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.PostcodeProperty = CPostalTextField.Text
                count = count + 1
            End If
            If CAddressTextField.Text = "" Then
                SendMessage(Me.CAddressTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.AddressProperty = CAddressTextField.Text
                count = count + 1
            End If
            If CCityTextField.Text = "" Then
                SendMessage(Me.CCityTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.CityProperty = CCityTextField.Text
                count = count + 1
            End If
            If CProvinceTextField.Text = "" Then
                SendMessage(Me.CProvinceTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.StateProperty = CProvinceTextField.Text
                count = count + 1
            End If
            If CCountryTextField.Text = "" Then
                SendMessage(Me.CCountryTextField.Handle, &H1501, 0, "*Invaild")
            Else
                person.CountryProperty = CCountryTextField.Text
                count = count + 1
            End If
            If CEmailTextBox.Text = "" Then
                SendMessage(Me.CEmailTextBox.Handle, &H1501, 0, "*Invaild")
            Else
                person.EmailProperty = CEmailTextBox.Text
                count = count + 1
            End If
            If CAgeTextBox.Text = "" Then
                SendMessage(Me.CAgeTextBox.Handle, &H1501, 0, "*Invaild")
            Else
                person.ageProperty = CAgeTextBox.Text = ""
                count = count + 1
            End If
            If creditCardTextbox.Text = "" Then
                SendMessage(Me.creditCardTextbox.Handle, &H1501, 0, "*Invaild")
            Else
                person.CreditcardProperty = creditCardTextbox.Text
                count = count + 1
            End If
            If cvvTextbox.Text = "" Then
                SendMessage(Me.cvvTextbox.Handle, &H1501, 0, "*Invaild")
            Else
                person.CVVProperty = cvvTextbox.Text
                count = count + 1
            End If

            If count.Equals(11) Then
                conditionTest = 0
                RentalProperty.CustomerProperty = person

                ' Insert the new customer
                Dim isql As String = "INSERT INTO Customer (FirstName, LastName, CreditCard, PostalCode, StreetAddress, City, State, Country, Email, Age, Username, CVV) VALUES (@fname, @lname, @ccard, @pcode, @addr, @city, @state, @cty, @email, @age, @username, @cvv)"
                Dim params As New Dictionary(Of String, String)
                With params
                    .Add("@fname", CFnameTextField.Text)
                    .Add("@lname", CLnameTextField.Text)
                    .Add("@ccard", creditCardTextbox.Text)
                    .Add("@pcode", CPostalTextField.Text)
                    .Add("@addr", CAddressTextField.Text)
                    .Add("@city", CCityTextField.Text)
                    .Add("@state", CProvinceTextField.Text)
                    .Add("@cty", CCountryTextField.Text)
                    .Add("@email", CEmailTextBox.Text)
                    .Add("@age", CAgeTextBox.Text)
                    .Add("@username", CLnameTextField.Text & CFnameTextField.Text.Substring(0, 1))
                    .Add("@cvv", cvvTextbox.Text)
                End With
                SQLConnection.DoNonQuery(isql, params)

                Dim ssql As String = "SELECT CID FROM Customer WHERE FirstName=@f AND LastName=@l AND CreditCard=@ccard AND PostalCode=@p"
                params = New Dictionary(Of String, String)
                params.Add("@f", CFnameTextField.Text)
                params.Add("@l", CLnameTextField.Text)
                params.Add("@ccard", creditCardTextbox.Text)
                params.Add("@p", CPostalTextField.Text)
                Dim columns As New List(Of String)
                columns.Add("CID")
                Dim cid As Integer
                For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(ssql, params, columns)
                    cid = CInt(result("CID"))
                Next
                person.IdProperty = cid
            End If

        End If



    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub

    Private Sub createOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conditionTest = 1
        MdiParent.Size = New Size(748, 594)
        existingLabel.BackColor = Color.Transparent
        customerLabel.BackColor = Color.Transparent
        cardLabel.BackColor = Color.Transparent
        lastname1Label.BackColor = Color.Transparent
        CFnameLabel.BackColor = Color.Transparent
        CLnameLabel.BackColor = Color.Transparent
        CemailLabel.BackColor = Color.Transparent
        AgeLabel.BackColor = Color.Transparent
        addressLabel.BackColor = Color.Transparent
        postalLabel.BackColor = Color.Transparent
        provinceLabel.BackColor = Color.Transparent
        countryLabel.BackColor = Color.Transparent
        cardNumberLabel.BackColor = Color.Transparent
        cvvLabel.BackColor = Color.Transparent
        cityLabel.BackColor = Color.Transparent
    End Sub

    Private Sub existingTextfield_TextChanged(sender As Object, e As EventArgs) Handles existingTextfield.TextChanged
        If (existingTextfield.Text.Count Mod 3).Equals(0) Then
            Dim text As String = "SELECT DISTINCT * FROM Customer where Customer.LastName like '" & existingTextfield.Text & "%'"
            Console.WriteLine(existingTextfield.Text.Count Mod 3)
            existingCustomers.Items.Clear()
            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = text
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Dim person = New Person()
                        person.FnameProperty = sqlReader("FirstName").ToString()
                        person.LnameProperty = sqlReader("LastName").ToString()
                        person.EmailProperty = sqlReader("Email").ToString()
                        person.PostcodeProperty = sqlReader("PostalCode").ToString()
                        person.AddressProperty = sqlReader("StreetAddress").ToString()
                        person.CityProperty = sqlReader("City").ToString()
                        person.StateProperty = sqlReader("State").ToString()
                        person.CountryProperty = sqlReader("Country").ToString()
                        person.ageProperty = sqlReader("age").ToString()
                        person.IdProperty = sqlReader("CID").ToString()
                        'person.PhoneProperty = sqlReader("Phone").ToString()

                        existingCustomers.Items.Add(person)
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()
        End If

    End Sub

    Private Sub existingCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles existingCustomers.SelectedIndexChanged
        If existingCustomers.SelectedItem IsNot Nothing AndAlso existingCustomers.SelectedItem.ToString() <> "" Then
            Dim person As Person = existingCustomers.SelectedItem
            CFnameTextField.Text = person.FnameProperty
            CLnameTextField.Text = person.LnameProperty
            CEmailTextBox.Text = person.EmailProperty
            CAgeTextBox.Text = person.ageProperty
            CAddressTextField.Text = person.AddressProperty
            CCityTextField.Text = person.CityProperty
            CProvinceTextField.Text = person.StateProperty
            CCountryTextField.Text = person.CountryProperty
            CPostalTextField.Text = person.PostcodeProperty
            Return
        End If

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        existingCustomers.Items.Clear()
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT DISTINCT * FROM Customer where Customer.LastName like '" & existingTextfield.Text & "%'"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim person = New Person()
                    person.FnameProperty = sqlReader("FirstName").ToString()
                    person.LnameProperty = sqlReader("LastName").ToString()
                    person.EmailProperty = sqlReader("Email").ToString()
                    person.PostcodeProperty = sqlReader("PostalCode").ToString()
                    person.AddressProperty = sqlReader("StreetAddress").ToString()
                    person.CityProperty = sqlReader("City").ToString()
                    person.StateProperty = sqlReader("State").ToString()
                    person.CountryProperty = sqlReader("Country").ToString()
                    person.ageProperty = sqlReader("age").ToString()
                    'person.PhoneProperty = sqlReader("Phone").ToString()
                    person.IdProperty = sqlReader("CID").ToString()
                    existingCustomers.Items.Add(person)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        existingCustomers.ClearSelected()
        CFnameTextField.Text = ""
        CLnameTextField.Text = ""
        CEmailTextBox.Text = ""
        CAgeTextBox.Text = ""
        CAddressTextField.Text = ""
        CCityTextField.Text = ""
        CProvinceTextField.Text = ""
        CCountryTextField.Text = ""
        CPostalTextField.Text = ""
        creditCardTextbox.Text = ""
        cvvTextbox.Text = ""
        conditionTest = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Help.GetHelp("rentals")
    End Sub


End Class