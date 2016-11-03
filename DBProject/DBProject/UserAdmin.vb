Public Class UserAdmin
    Private callingForm As Home

    Public WriteOnly Property CallingFormProperty As Home
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub UserAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserAdmin_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.Show()
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim newUserForm As New AddNewUser
        newUserForm.CallingFormProperty = Me
        newUserForm.Show()
    End Sub
End Class