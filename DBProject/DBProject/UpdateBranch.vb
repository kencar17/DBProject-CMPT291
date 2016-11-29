Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class UpdateBranch
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("branches")
    End Sub

    Private Sub UpdateBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim sql As String = "SELECT FirstName, LastName, EID FROM Employee"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        columns.Add("FirstName")
        columns.Add("LastName")
        columns.Add("EID")
        Dim moreresults As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(sql, params, columns)
        For Each result As Dictionary(Of String, String) In moreresults
            Dim aUser As New User("", "")
            aUser.IdProperty = CInt(result("EID"))
            aUser.NameProperty = result("FirstName") & " " & result("LastName")
            aUser.UsernameProperty = aUser.NameProperty
            MBox.Items.Add(aUser)
        Next

        ErrLabel.BackColor = Color.Transparent
        Init()
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
        Dim sql As String = "UPDATE Branch SET Email=@email, Phone=@phone, Fax=@fax, ManagerID=@manid WHERE BID = @bid"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@email", EmailBox.Text)
            .Add("@fax", FaxBox.Text)
            .Add("@phone", PhoneBox.Text)
            .Add("@manid", manager.IdProperty)
            .Add("@bid", BranchSelection.SelectedItem.BidProperty)
        End With
        SQLConnection.DoNonQuery(sql, params)

        Init()

        MsgBox("The branch has been updated.")
    End Sub

    Private Sub Init()
        BranchSelection.Items.Clear()
        EmailBox.Enabled = False
        PhoneBox.Enabled = False
        FaxBox.Enabled = False
        MBox.Enabled = False

        Dim selectSql As String = "SELECT BID, Branch.PostalCode, Branch.StreetAddress, Branch.City, Branch.State, Branch.Country, Branch.Email, Phone, Fax, FirstName, LastName, ManagerID FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID"
        Dim selectParams As New Dictionary(Of String, String)
        Dim selectColumns As New List(Of String)
        With selectColumns
            .Add("BID")
            .Add("PostalCode")
            .Add("StreetAddress")
            .Add("City")
            .Add("State")
            .Add("Country")
            .Add("Email")
            .Add("Phone")
            .Add("Fax")
            .Add("FirstName")
            .Add("LastName")
            .Add("ManagerID")
        End With
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectSql, selectParams, selectColumns)
        For Each result As Dictionary(Of String, String) In results
            Dim b As New Branch
            With b
                .BidProperty = CInt(result("BID"))
                .PostcodeProperty = result("PostalCode")
                .AddressProperty = result("StreetAddress")
                .CityProperty = result("City")
                .StateProperty = result("State")
                .CountryProperty = result("Country")
                .EmailProperty = result("Email")
                .PhoneProperty = result("Phone")
                .FaxProperty = result("Fax")
                .MannameProperty = result("FirstName") & " " & result("LastName")
                .ManidProperty = result("ManagerID")
            End With
            BranchSelection.Items.Add(b)
        Next
    End Sub
End Class
