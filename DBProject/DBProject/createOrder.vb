Imports MySql.Data.MySqlClient
Public Class createOrder
    Private callingForm As ChooseRental

    Public WriteOnly Property CallingFormProperty As ChooseRental
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CLnameLabel.Click

    End Sub

    Private Sub CnameLabel_Click(sender As Object, e As EventArgs) Handles CFnameLabel.Click

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim orderSummaryWindow As New OrderSummary
        orderSummaryWindow.MdiParent = Me.MdiParent
        orderSummaryWindow.CallingformProperty = Me
        orderSummaryWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub

    Private Sub createOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

                    existingCustomers.Items.Add(person)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub


End Class