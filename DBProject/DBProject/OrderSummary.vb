Public Class OrderSummary
    Private callingform As createOrder
    Private rental As RentalInfo

    Public Property RentalProperty As RentalInfo
        Get
            Return rental
        End Get
        Set
            rental = Value
        End Set
    End Property

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