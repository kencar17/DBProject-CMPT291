Public Class createOrder
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
        orderSummaryWindow.Show()
    End Sub
End Class