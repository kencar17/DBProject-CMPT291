Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class UpdateBranch
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp()
    End Sub

    Private Sub UpdateBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                .CommandText = "SELECT BID, Branch.PostalCode, Branch.StreetAddress, Branch.City, Branch.State, Branch.Country, Branch.Email, Phone, Fax, FirstName, LastName, ManagerID FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim b As New Branch
                    b.BidProperty = CInt(sqlReader("BID").ToString())
                    b.PostcodeProperty = sqlReader("PostalCode").ToString()
                    b.AddressProperty = sqlReader("StreetAddress").ToString()
                    b.CityProperty = sqlReader("City").ToString()
                    b.StateProperty = sqlReader("State").ToString()
                    b.CountryProperty = sqlReader("Country").ToString()
                    b.EmailProperty = sqlReader("Email").ToString()
                    b.PhoneProperty = sqlReader("Phone").ToString()
                    b.FaxProperty = sqlReader("Fax").ToString()
                    b.MannameProperty = sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()
                    b.ManidProperty = sqlReader("ManagerID").ToString()
                    BranchSelection.Items.Add(b)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT FirstName, LastName, EID FROM Employee"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim aUser As New User("", "")
                    aUser.IdProperty = CInt(sqlReader("EID").ToString())
                    aUser.NameProperty = sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()
                    aUser.UsernameProperty = aUser.NameProperty
                    MBox.Items.Add(aUser)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub BranchSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchSelection.SelectedIndexChanged
        Dim selectedBranch As Branch = BranchSelection.SelectedItem
        AddressBox.Text = selectedBranch.AddressProperty
        PostcodeBox.Text = selectedBranch.PostcodeProperty
        CityBox.Text = selectedBranch.CityProperty
        StateBox.Text = selectedBranch.StateProperty
        CountryBox.Text = selectedBranch.CountryProperty
        EmailBox.Text = selectedBranch.EmailProperty
        PhoneBox.Text = selectedBranch.PhoneProperty
        FaxBox.Text = selectedBranch.FaxProperty

        For Each candidate As User In MBox.Items
            If candidate.IdProperty = selectedBranch.ManidProperty Then
                MBox.SelectedItem = candidate
                Exit For
            End If
        Next

        EmailBox.Enabled = True
        PhoneBox.Enabled = True
        FaxBox.Enabled = True
        MBox.Enabled = True
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ErrLabel.Visible = False

        If BranchSelection.SelectedItem Is Nothing Then
            ErrLabel.Text = "A branch must be selected"
            ErrLabel.Visible = True
            Return
        End If
        If EmailBox.Text.Equals("") Then
            ErrLabel.Text = "An email must be entered"
            ErrLabel.Visible = True
            Return
        End If
        If PhoneBox.Text.Equals("") Then
            ErrLabel.Text = "A phone must be given"
            ErrLabel.Visible = True
            Return
        End If
        If FaxBox.Text.Equals("") Then
            ErrLabel.Text = "A fax must be given"
            ErrLabel.Visible = True
            Return
        End If

        Dim manager As User = MBox.SelectedItem

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "UPDATE Branch SET Email=@email, Phone=@phone, Fax=@fax, ManagerID=@manid WHERE BID = @bid"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@email", EmailBox.Text)
                .Parameters.AddWithValue("@fax", FaxBox.Text)
                .Parameters.AddWithValue("@phone", PhoneBox.Text)
                .Parameters.AddWithValue("@manid", manager.IdProperty)
                .Parameters.AddWithValue("@bid", BranchSelection.SelectedItem.BidProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox("The branch has been updated.")
    End Sub
End Class