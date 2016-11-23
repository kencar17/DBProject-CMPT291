Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class AddNewUser
    Private callingForm As UserAdmin
    Private chosenFile As String = ""

    Public WriteOnly Property CallingFormProperty As UserAdmin
        Set(value As UserAdmin)
            callingForm = value
        End Set
    End Property

    Private Sub AddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.AcceptButton = SubmitButton
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

        Dim branchSql As String = "SELECT * FROM Branch"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        With columns
            .Add("BID")
            .Add("PostalCode")
            .Add("StreetAddress")
            .Add("City")
            .Add("State")
            .Add("Country")
            .Add("Email")
            .Add("Phone")
            .Add("Fax")
            .Add("ManagerID")
        End With
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(branchSql, params, columns)
            Dim aBranch As New Branch
            aBranch.BidProperty = result("BID")
            aBranch.PostcodeProperty = result("PostalCode")
            aBranch.AddressProperty = result("StreetAddress")
            aBranch.CityProperty = result("City")
            aBranch.StateProperty = result("State")
            aBranch.CountryProperty = result("Country")
            aBranch.EmailProperty = result("Email")
            aBranch.PhoneProperty = result("Phone")
            aBranch.FaxProperty = result("Fax")
            aBranch.ManidProperty = result("ManagerID")
            BranchSelection.Items.Add(aBranch)
        Next
    End Sub

    Private Sub AddNewUser_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing

    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' First, do some error checking
        Me.ErrorLabel.Visible = False

        If UsernameBox.Text.Equals("") Then
            ErrorLabel.Text = "A username must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If PassBox.Text.Equals("") Then
            ErrorLabel.Text = "A password must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If FirstnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A first name must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If LastnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A last name must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If EmailBox.Text.Equals("") Then
            ErrorLabel.Text = "An email must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If BranchSelection.SelectedItem Is Nothing Then
            ErrorLabel.Text = "A branch must me selected."
            ErrorLabel.Visible = True
            Return
        End If
        ' Check if the user already exists using the check implemented in my User class
        If User.FindUser(Me.UsernameBox.Text) IsNot Nothing Then
            ErrorLabel.Text = String.Format("{0} already exists", UsernameBox.Text)
            ErrorLabel.Visible = True
            Return
        End If

        ' Hash the password
        Dim hashedPass As String = BCrypt.Net.BCrypt.HashPassword(PassBox.Text)
        Dim selectedBranch As Branch = BranchSelection.SelectedItem

        Dim insertEmployeeSql As String = "INSERT INTO Employee (FirstName, LastName, PostalCode, StreetAddress, City, State, Country, Email, Branch) VALUES (@firstname, @lastname, @pcode, @addr, @city, @state, @country, @email, @branch)"
        Dim insertEmployeeParams As New Dictionary(Of String, String)
        With insertEmployeeParams
            .Add("@firstname", FirstnameBox.Text)
            .Add("@lastname", LastnameBox.Text)
            .Add("@pcode", PostcodeBox.Text)
            .Add("@addr", AddressBox.Text)
            .Add("@city", CityBox.Text)
            .Add("@state", StateBox.Text)
            .Add("@country", CountryBox.Text)
            .Add("@email", EmailBox.Text)
            .Add("@branch", selectedBranch.BidProperty)
        End With
        SQLConnection.DoNonQuery(insertEmployeeSql, insertEmployeeParams)

        Dim selectEidSql As String = "SELECT EID FROM Employee WHERE FirstName = @firstname AND LastName = @lastname AND Email = @email"
        Dim selectEidParams As New Dictionary(Of String, String)
        With selectEidParams
            .Add("@firstname", FirstnameBox.Text)
            .Add("@lastname", LastnameBox.Text)
            .Add("@email", EmailBox.Text)
        End With
        Dim selectEidColumns As New List(Of String)
        selectEidColumns.Add("EID")
        Dim selectEidResults As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectEidSql, selectEidParams, selectEidColumns)
        Dim eid As Integer = selectEidResults(0)("EID")


        Dim uploadUrl As String = "http://res.cloudinary.com/dmhf7fjrc/image/upload/c_scale,h_141,w_100/v1479153691/sample.jpg"
        If Not chosenFile.Equals("") Then
            uploadUrl = Faces.upload(chosenFile)
        End If

        Dim userInsertSql As String = "INSERT INTO User (Username, Password, PersonID, ImgUrl) VALUES (@username, @pass, @eid, @url)"
        Dim userInsertParams As New Dictionary(Of String, String)
        With userInsertParams
            .Add("@username", UsernameBox.Text)
            .Add("@pass", hashedPass)
            .Add("@eid", eid)
            .Add("@url", uploadUrl)
        End With
        SQLConnection.DoNonQuery(userInsertSql, userInsertParams)

        MsgBox("User added!")
        Me.Close()
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