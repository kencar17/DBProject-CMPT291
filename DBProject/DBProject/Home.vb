Imports DBProject

Public Class Home
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
        Me.NameLabel.Text = loggedInUser.NameProperty
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Home_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
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
End Class
