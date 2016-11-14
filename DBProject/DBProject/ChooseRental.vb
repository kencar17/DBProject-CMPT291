Public Class ChooseRental
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim createOrderWindow As New createOrder
        createOrderWindow.MdiParent = Me.MdiParent
        createOrderWindow.Show()
    End Sub
End Class