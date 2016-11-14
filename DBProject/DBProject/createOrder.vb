Public Class createOrder
    Private callingForm As ChooseRental

    Public WriteOnly Property CallingFormProperty As ChooseRental
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CLnameLabel.Click

    End Sub

    Private Sub CnameLabel_Click(sender As Object, e As EventArgs) Handles CFnameLabel.Click

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim orderSummaryWindow As New OrderSummary
        orderSummaryWindow.MdiParent = Me.MdiParent
        orderSummaryWindow.CallingformProperty = Me
        orderSummaryWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub

End Class