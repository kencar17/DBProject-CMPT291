﻿Imports DBProject

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
    End Sub

    Private Sub Home_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.Show()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()
    End Sub

    Private Sub UserAdminButton_Click(sender As Object, e As EventArgs) Handles UserAdminButton.Click
        ' Open user admin window
        Dim userAdminForm As New UserAdmin
        userAdminForm.CallingFormProperty = Me
        userAdminForm.Show()
    End Sub

    Private Sub ReportsButton_Click(sender As Object, e As EventArgs) Handles ReportsButton.Click
        Dim reportForm As New Reports
        reportForm.Show()
    End Sub
End Class