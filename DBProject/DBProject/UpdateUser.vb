Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class UpdateUser
    Private callingForm As UserAdmin

    Public WriteOnly Property CallingFormProperty As UserAdmin
        Set(value As UserAdmin)
            callingForm = value
        End Set
    End Property

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Me.SubmitButton
        SendMessage(Me.UsernameBox.Handle, &H1501, 0, "Username")
        SendMessage(Me.PassBox.Handle, &H1501, 0, "Password")
        Me.PassBox.PasswordChar = "*"
        SendMessage(Me.FirstnameBox.Handle, &H1501, 0, "First Name")
        SendMessage(Me.LastnameBox.Handle, &H1501, 0, "Last Name")
        SendMessage(Me.AddressBox.Handle, &H1501, 0, "Address")
        SendMessage(Me.PostcodeBox.Handle, &H1501, 0, "Postal Code")
        SendMessage(Me.CityBox.Handle, &H1501, 0, "City")
        SendMessage(Me.StateBox.Handle, &H1501, 0, "State")
        SendMessage(Me.CountryBox.Handle, &H1501, 0, "Country")
        SendMessage(Me.EmailBox.Handle, &H1501, 0, "Email")

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim newUser As New User(sqlReader("Username").ToString(), "")
                    newUser.IdProperty = CInt(sqlReader("EID").ToString())
                    newUser.CityProperty = sqlReader("City").ToString()
                    newUser.CountryProperty = sqlReader("Country").ToString()
                    newUser.EmailProperty = sqlReader("Email").ToString()
                    newUser.FirstNameProperty = sqlReader("FirstName").ToString()
                    newUser.LastNameProperty = sqlReader("LastName").ToString()
                    newUser.StreetAddressProperty = sqlReader("StreetAddress").ToString()
                    newUser.PostCodeProperty = sqlReader("PostalCode").ToString()
                    newUser.StateProperty = sqlReader("State").ToString()
                    UserSelection.Items.Add(newUser)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' If a user hasn't been selected, don't continue
        If Not Me.SubmitButton.Enabled Then
            Return
        End If
        Dim selectedUser As User = UserSelection.SelectedItem

        ' Update the Employee entry
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "UPDATE Employee SET FirstName=@firstname, LastName=@lastname, StreetAddress=@address, PostalCode=@postcode, City=@city, State=@state, Country=@country, Email=@email WHERE Employee.EID = @eid"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@firstname", FirstnameBox.Text)
                .Parameters.AddWithValue("@lastname", LastnameBox.Text)
                .Parameters.AddWithValue("@address", AddressBox.Text)
                .Parameters.AddWithValue("@postcode", PostcodeBox.Text)
                .Parameters.AddWithValue("@city", CityBox.Text)
                .Parameters.AddWithValue("@state", StateBox.Text)
                .Parameters.AddWithValue("@country", CountryBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
                .Parameters.AddWithValue("@eid", selectedUser.IdProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        If (Not PassBox.Text.Equals("")) Then
            Dim newPassword As String = BCrypt.Net.BCrypt.HashPassword(PassBox.Text)

            dbconn = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "UPDATE User SET Password=@password WHERE Username=@username"
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@password", newPassword)
                    .Parameters.AddWithValue("@username", UsernameBox.Text)
                End With
                sqlComm.ExecuteNonQuery()
            End Using
            SQLConnection.Instance.CloseConnection()
            PassBox.Text = ""
        End If

        MsgBox(selectedUser.UsernameProperty & " has been updateed.")
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub UserSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserSelection.SelectedIndexChanged
        Dim selectedUser As User = UserSelection.SelectedItem
        Me.SubmitButton.Enabled = True
        Me.AddressBox.Enabled = True
        Me.AddressBox.Text = selectedUser.StreetAddressProperty
        Me.CityBox.Enabled = True
        Me.CityBox.Text = selectedUser.CityProperty
        Me.CountryBox.Enabled = True
        Me.CountryBox.Text = selectedUser.CountryProperty
        Me.EmailBox.Enabled = True
        Me.EmailBox.Text = selectedUser.EmailProperty
        Me.FirstnameBox.Enabled = True
        Me.FirstnameBox.Text = selectedUser.FirstNameProperty
        Me.LastnameBox.Enabled = True
        Me.LastnameBox.Text = selectedUser.LastNameProperty
        Me.PassBox.Enabled = True
        Me.PostcodeBox.Enabled = True
        Me.PostcodeBox.Text = selectedUser.PostCodeProperty
        Me.StateBox.Enabled = True
        Me.StateBox.Text = selectedUser.StateProperty
        Me.UsernameBox.Text = selectedUser.UsernameProperty
    End Sub
End Class