Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class UpdateUser
    Private callingForm As UserAdmin
    Private chosenFile As String = ""

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

        Init()
    End Sub

    Private Sub Init()
        UserSelection.Items.Clear()

        Dim sql As String = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        With columns
            .Add("Username")
            .Add("EID")
            .Add("City")
            .Add("Country")
            .Add("Email")
            .Add("FirstName")
            .Add("LastName")
            .Add("StreetAddress")
            .Add("PostalCode")
            .Add("State")
        End With
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(sql, params, columns)
        For Each result As Dictionary(Of String, String) In results
            Dim newUser As New User(result("Username"), "")
            newUser.IdProperty = CInt(result("EID"))
            newUser.CityProperty = result("City")
            newUser.CountryProperty = result("Country")
            newUser.EmailProperty = result("Email")
            newUser.FirstNameProperty = result("FirstName")
            newUser.LastNameProperty = result("LastName")
            newUser.StreetAddressProperty = result("StreetAddress")
            newUser.PostCodeProperty = result("PostalCode")
            newUser.StateProperty = result("State")
            UserSelection.Items.Add(newUser)
        Next

        UserSelection.SelectedItem = Nothing


        Me.ImgButton.Enabled = False
        Me.SubmitButton.Enabled = False
        Me.AddressBox.Enabled = False
        Me.AddressBox.Text = ""
        Me.CityBox.Enabled = False
        Me.CityBox.Text = ""
        Me.CountryBox.Enabled = False
        Me.CountryBox.Text = ""
        Me.EmailBox.Enabled = False
        Me.EmailBox.Text = ""
        Me.FirstnameBox.Enabled = False
        Me.FirstnameBox.Text = ""
        Me.LastnameBox.Enabled = False
        Me.LastnameBox.Text = ""
        Me.PassBox.Enabled = False
        Me.PostcodeBox.Enabled = False
        Me.PostcodeBox.Text = ""
        Me.StateBox.Enabled = False
        Me.StateBox.Text = ""
        Me.UsernameBox.Text = ""
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim selectedUser As User = UserSelection.SelectedItem

        ' If a user hasn't been selected, don't continue
        If Not Me.SubmitButton.Enabled Then
            Return
        End If
        Dim updateEmployeeSql As String = "UPDATE Employee SET FirstName=@firstname, LastName=@lastname, StreetAddress=@address, PostalCode=@postcode, City=@city, State=@state, Country=@country, Email=@email WHERE Employee.EID = @eid"
        Dim updateEmployeeParams As New Dictionary(Of String, String)
        With updateEmployeeParams
            .Add("@firstname", FirstnameBox.Text)
            .Add("@lastname", LastnameBox.Text)
            .Add("@address", AddressBox.Text)
            .Add("@postcode", PostcodeBox.Text)
            .Add("@city", CityBox.Text)
            .Add("@state", StateBox.Text)
            .Add("@country", CountryBox.Text)
            .Add("@email", EmailBox.Text)
            .Add("@eid", selectedUser.IdProperty)
        End With
        SQLConnection.DoNonQuery(updateEmployeeSql, updateEmployeeParams)


        If Not chosenFile.Equals("") Then
            Dim uploadUrl As String = Faces.upload(chosenFile)
            Dim uploadSql As String = "UPDATE User SET ImgUrl=@url WHERE Username=@username"
            Dim uploadParams As New Dictionary(Of String, String)
            With uploadParams
                .Add("@url", uploadUrl)
                .Add("@username", UsernameBox.Text)
            End With
            SQLConnection.DoNonQuery(uploadSql, uploadParams)
        End If

        If (Not PassBox.Text.Equals("")) Then
            Dim newPassword As String = BCrypt.Net.BCrypt.HashPassword(PassBox.Text)
            Dim passSql As String = "UPDATE User SET Password=@password WHERE Username=@username"
            Dim passParams As New Dictionary(Of String, String)
            With passParams
                .Add("@password", newPassword)
                .Add("@username", UsernameBox.Text)
            End With
            SQLConnection.DoNonQuery(passSql, passParams)

            PassBox.Text = ""
        End If
        Init()

        MsgBox(selectedUser.UsernameProperty & " has been updated.")
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub UserSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserSelection.SelectedIndexChanged
        Dim selectedUser As User = UserSelection.SelectedItem

        If selectedUser Is Nothing Then
            Return
        End If

        Me.ImgButton.Enabled = True
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

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("ua")
    End Sub

    Private Sub ImgButton_Click(sender As Object, e As EventArgs) Handles ImgButton.Click
        Dim fd As New OpenFileDialog

        With fd
            .Title = "Choose an image"
            .InitialDirectory = SpecialDirectories.MyPictures
            .Filter = "All Images (*.bmp, *.gif, *.jpg, *.jpeg, *.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png"

            If .ShowDialog() = DialogResult.OK Then
                chosenFile = .FileName
                PicturePath.Text = chosenFile
            End If
        End With
    End Sub
End Class