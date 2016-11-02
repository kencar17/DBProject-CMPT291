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
        Console.WriteLine("Loaded")
    End Sub

    Private Sub Home_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.Show()
    End Sub
End Class