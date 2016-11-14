Public Class ChooseLocation

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim rentalWindow As New ChooseRental
        rentalWindow.MdiParent = Me.MdiParent
        rentalWindow.CallingFormProperty = Me
        rentalWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
    End Sub
End Class