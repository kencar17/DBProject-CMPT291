Public Class OrderSummary
    Private callingform As createOrder

    Public WriteOnly Property CallingformProperty As createOrder
        Set
            callingform = Value
        End Set
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub finishButton_Click(sender As Object, e As EventArgs) Handles finishButton.Click
        callingform.doAThing()
        Close()
    End Sub
End Class