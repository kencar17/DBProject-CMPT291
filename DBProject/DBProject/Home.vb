Imports DBProject

Public Class Home
    Private Class Delivery
        Dim transactionID As Integer
        Dim make As String
        Dim model As String
        Dim name As String
        Dim thedate As Date

        Public Property NameProperty As String
            Get
                Return name
            End Get
            Set
                name = Value
            End Set
        End Property

        Public Property DateProperty As Date
            Get
                Return thedate
            End Get
            Set
                thedate = Value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return "Transaction " & CStr(transactionID) & ": " & make & " " & model & ", " & name & " (" & thedate.ToString("MMM d, yyyy") & ")"
        End Function

        Public Property TransactionIdProperty As Integer
            Get
                Return transactionID
            End Get
            Set
                transactionID = Value
            End Set
        End Property

        Public Property MakeProperty As String
            Get
                Return make
            End Get
            Set
                make = Value
            End Set
        End Property

        Public Property ModelProperty As String
            Get
                Return model
            End Get
            Set
                model = Value
            End Set
        End Property
    End Class

    Private loggedInUser As User
    Private callingForm As Form1

    Public WriteOnly Property LoggedInUserProperty As User
        Set(value As User)
            loggedInUser = value
        End Set
    End Property

    Public WriteOnly Property CallingFormProperty As Form1
        Set(value As Form1)
            callingForm = value
        End Set
    End Property

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        Me.NameLabel.Text = loggedInUser.NameProperty
        Me.WindowState = FormWindowState.Maximized
        FaceBox.Load(loggedInUser.ImgProperty)

        NameLabel.BackColor = Color.Transparent

        Init()
    End Sub

    Private Sub Init()
        DeliveryBox.Items.Clear()
        Dim deliveriesSql As String = "SELECT FirstName, LastName, TID, Make, Model, ToDate FROM Transaction JOIN Vehicle ON Transaction.VIN = Vehicle.VIN JOIN Customer ON Transaction.CID = Customer.CID WHERE ToDate <= CURDATE() AND ToBID = @branch AND Complete=0 AND PickedUp=1"
        Dim params As New Dictionary(Of String, String)
        params.Add("@branch", loggedInUser.BranchProperty)
        Dim columns As New List(Of String)
        columns.Add("TID")
        columns.Add("Make")
        columns.Add("Model")
        columns.Add("FirstName")
        columns.Add("LastName")
        columns.Add("ToDate")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(deliveriesSql, params, columns)
            Dim aDelivery As New Delivery
            aDelivery.MakeProperty = result("Make").ToString()
            aDelivery.ModelProperty = result("Model").ToString()
            aDelivery.TransactionIdProperty = CInt(result("TID").ToString())
            aDelivery.NameProperty = result("FirstName") & " " & result("LastName")
            aDelivery.DateProperty = Date.ParseExact(Replace(result("ToDate"), " AM", ""), "yyyy-MM-dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            DeliveryBox.Items.Add(aDelivery)
        Next

        PickupBox.Items.Clear()
        Dim pickupsSql As String = "SELECT FirstName, LastName, TID, Make, Model, FromDate FROM Transaction JOIN Vehicle ON Transaction.VIN = Vehicle.VIN JOIN Customer ON Transaction.CID = Customer.CID WHERE FromDate <= CURDATE() AND FromBID = @branch AND Complete=0 AND PickedUp=0"
        params = New Dictionary(Of String, String)
        params.Add("@branch", loggedInUser.BranchProperty)
        columns = New List(Of String)
        columns.Add("TID")
        columns.Add("Make")
        columns.Add("Model")
        columns.Add("FirstName")
        columns.Add("LastName")
        columns.Add("FromDate")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(pickupsSql, params, columns)
            Dim aDelivery As New Delivery
            aDelivery.MakeProperty = result("Make").ToString()
            aDelivery.ModelProperty = result("Model").ToString()
            aDelivery.TransactionIdProperty = CInt(result("TID").ToString())
            aDelivery.NameProperty = result("FirstName") & " " & result("LastName")
            aDelivery.DateProperty = Date.ParseExact(Replace(result("FromDate"), " AM", ""), "yyyy-MM-dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            Dim diff As Long = DateDiff(DateInterval.Day, aDelivery.DateProperty, Date.Today) + 1
            If diff < 3 Then
                PickupBox.Items.Add(aDelivery)
            Else
                Dim setCompleteSql As String = "UPDATE Transaction SET Complete=1 WHERE TID=@tid"
                Dim uparams As New Dictionary(Of String, String)
                uparams.Add("@tid", aDelivery.TransactionIdProperty)
                SQLConnection.DoNonQuery(setCompleteSql, uparams)
                Continue For
            End If
        Next
    End Sub

    Private Sub Home_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        'MdiParent.Size = New Size(748, 571)
        callingForm.Show()
        callingForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()
    End Sub

    Private Sub UserAdminButton_Click(sender As Object, e As EventArgs) Handles UserAdminButton.Click
        ' Open user admin window
        Dim userAdminForm As New UserAdmin
        userAdminForm.MdiParent = Me.MdiParent
        userAdminForm.CallingFormProperty = Me
        userAdminForm.Show()
    End Sub

    Private Sub ReportsButton_Click(sender As Object, e As EventArgs) Handles ReportsButton.Click
        Dim reportForm As New Reports
        reportForm.MdiParent = Me.MdiParent
        reportForm.Show()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("home")
    End Sub

    Private Sub CarAdminButton_Click(sender As Object, e As EventArgs) Handles CarAdminButton.Click
        Dim carAdminForm As New CarAdministrationvb
        carAdminForm.MdiParent = Me.MdiParent
        carAdminForm.Show()
    End Sub

    Private Sub BackupButton_Click(sender As Object, e As EventArgs) Handles BackupButton.Click
        Dim bakForm As New Backup
        bakForm.MdiParent = Me.MdiParent
        bakForm.Show()

    End Sub

    Private Sub BranchButton_Click(sender As Object, e As EventArgs) Handles BranchButton.Click
        Dim branchWindow As New Branches
        branchWindow.MdiParent = Me.MdiParent
        branchWindow.Show()
    End Sub

    Private Sub TypeButton_Click(sender As Object, e As EventArgs) Handles TypeButton.Click
        Dim types As New TypesAdministration
        types.MdiParent = Me.MdiParent
        types.Show()
    End Sub

    Private Sub RentalButton_Click(sender As Object, e As EventArgs) Handles RentalButton.Click
        Dim locationWindow As New ChooseLocation
        locationWindow.MdiParent = Me.MdiParent
        locationWindow.Show()
    End Sub

    Private Sub CheckInButton_Click(sender As Object, e As EventArgs) Handles CheckInButton.Click
        Dim selectedDelivery As Delivery = DeliveryBox.SelectedItem
        If selectedDelivery Is Nothing Then
            Return
        End If

        Dim comp As Integer = DateTime.Compare(selectedDelivery.DateProperty, Date.Today)
        Dim diff As Long = DateDiff(DateInterval.Day, selectedDelivery.DateProperty, Date.Today) + 1

        If DateTime.Compare(selectedDelivery.DateProperty, Date.Today) < 0 Then
            MsgBox("The delivery is " & diff & " days later than scheduled. A charge of $" & diff * 20 & " will be applied.")
        End If

        Dim sql As String = "UPDATE Transaction SET Complete=1 WHERE TID=@tid"
        Dim params As New Dictionary(Of String, String)
        params.Add("@tid", selectedDelivery.TransactionIdProperty)
        SQLConnection.DoNonQuery(sql, params)

        Init()
    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        Dim selectedDelivery As Delivery = PickupBox.SelectedItem
        If selectedDelivery Is Nothing Then
            Return
        End If

        Dim sql As String = "UPDATE Transaction SET PickedUp=1 WHERE TID=@tid"
        Dim params As New Dictionary(Of String, String)
        params.Add("@tid", selectedDelivery.TransactionIdProperty)
        SQLConnection.DoNonQuery(sql, params)

        Init()
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim viewInventory As New ViewInventory
        viewInventory.MdiParent = Me.MdiParent
        viewInventory.CallingFormProperty = Me
        viewInventory.Show()
    End Sub


End Class
