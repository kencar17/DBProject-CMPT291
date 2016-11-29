Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class NewBranch
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("branches")
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ErrLabel.Visible = False

        If AddressBox.Text.Equals("") Then
            ErrLabel.Text = "Address cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If PostcodeBox.Text.Equals("") Then
            ErrLabel.Text = "Postal code cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If CityBox.Text.Equals("") Then
            ErrLabel.Text = "City cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If StateBox.Text.Equals("") Then
            ErrLabel.Text = "State cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If CountryBox.Text.Equals("") Then
            ErrLabel.Text = "Country cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If EmailBox.Text.Equals("") Then
            ErrLabel.Text = "Email cannot be empty"
            ErrLabel.Visible = True
            Return
        End If
        If PhoneBox.Text.Equals("") Then
            ErrLabel.Text = "Phone number cannot be empty"
            ErrLabel.Visible = True
            Return
        End If

        Dim selectedUser As User = ManagerBox.SelectedItem

        Dim insertSql As String = "INSERT INTO Branch (PostalCode, StreetAddress, City, State, Country, Email, Phone, Fax, ManagerID) VALUES (@pcode, @addr, @city, @state, @country, @email, @phone, @fax, @mid)"
        Dim insertParams As New Dictionary(Of String, String)
        With insertParams
            .Add("@pcode", PostcodeBox.Text)
            .Add("@addr", AddressBox.Text)
            .Add("@city", CityBox.Text)
            .Add("@state", StateBox.Text)
            .Add("@country", CountryBox.Text)
            .Add("@email", EmailBox.Text)
            .Add("@phone", PhoneBox.Text)
            .Add("@fax", FaxBox.Text)
            .Add("@mid", selectedUser.IdProperty)
        End With
        SQLConnection.DoNonQuery(insertSql, insertParams)

        MsgBox("Branch has been created.")
        Close()
    End Sub

    Private Sub NewBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        SendMessage(Me.AddressBox.Handle, &H1501, 0, "Address")
        SendMessage(Me.PostcodeBox.Handle, &H1501, 0, "Postal Code")
        SendMessage(Me.CityBox.Handle, &H1501, 0, "City")
        SendMessage(Me.StateBox.Handle, &H1501, 0, "State")
        SendMessage(Me.CountryBox.Handle, &H1501, 0, "Country")
        SendMessage(Me.EmailBox.Handle, &H1501, 0, "Email")
        SendMessage(Me.PhoneBox.Handle, &H1501, 0, "Phone")
        SendMessage(Me.FaxBox.Handle, &H1501, 0, "Fax")

        Me.AcceptButton = SubmitButton

        Dim selectSql As String = "SELECT EID, FirstName, LastName FROM Employee"
        Dim selectParams As New Dictionary(Of String, String)
        Dim selectColumns As New List(Of String)
        selectColumns.Add("FirstName")
        selectColumns.Add("LastName")
        selectColumns.Add("EID")
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectSql, selectParams, selectColumns)

        For Each result As Dictionary(Of String, String) In results
            Dim newUser As New User(result("FirstName") & " " & result("LastName"), "")
            newUser.IdProperty = CInt(result("EID"))
            ManagerBox.Items.Add(newUser)
        Next

        ManagerBox.SelectedIndex = 0

        ErrLabel.BackColor = Color.Transparent
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

End Class
