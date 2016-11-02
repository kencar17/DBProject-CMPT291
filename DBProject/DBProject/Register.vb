Public Class Register
    Private user As User = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Delete the old user if it existed
        user = Nothing


    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not user Is Nothing Then
            Me.UserNameBox.Text = user.getUsername()
            Me.UserPassBox.Text = user.getPassword()
        End If
    End Sub

    Public Sub SetUser(user As User)
        Me.user = user
    End Sub
End Class