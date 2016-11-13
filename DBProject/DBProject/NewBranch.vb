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

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "INSERT INTO Branch (PostalCode, StreetAddress, City, State, Country, Email, Phone, Fax, ManagerID) VALUES (@pcode, @addr, @city, @state, @country, @email, @phone, @fax, @mid)"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@pcode", PostcodeBox.Text)
                .Parameters.AddWithValue("@addr", AddressBox.Text)
                .Parameters.AddWithValue("@city", CityBox.Text)
                .Parameters.AddWithValue("@state", StateBox.Text)
                .Parameters.AddWithValue("@country", CountryBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
                .Parameters.AddWithValue("@phone", PhoneBox.Text)
                .Parameters.AddWithValue("@fax", FaxBox.Text)
                .Parameters.AddWithValue("@mid", selectedUser.IdProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox("Branch has been created.")
        Close()
    End Sub

    Private Sub NewBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.AddressBox.Handle, &H1501, 0, "Address")
        SendMessage(Me.PostcodeBox.Handle, &H1501, 0, "Postal Code")
        SendMessage(Me.CityBox.Handle, &H1501, 0, "City")
        SendMessage(Me.StateBox.Handle, &H1501, 0, "State")
        SendMessage(Me.CountryBox.Handle, &H1501, 0, "Country")
        SendMessage(Me.EmailBox.Handle, &H1501, 0, "Email")
        SendMessage(Me.PhoneBox.Handle, &H1501, 0, "Phone")
        SendMessage(Me.FaxBox.Handle, &H1501, 0, "Fax")

        Me.AcceptButton = SubmitButton
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT EID, FirstName, LastName FROM Employee"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim name As String = sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()
                    Dim newUser As New User(name, "")
                    newUser.IdProperty = CInt(sqlReader("EID").ToString())
                    ManagerBox.Items.Add(newUser)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        ManagerBox.SelectedIndex = 0
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

End Class