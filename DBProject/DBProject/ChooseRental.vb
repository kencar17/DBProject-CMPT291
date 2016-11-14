Public Class ChooseRental
    Private callingForm As ChooseLocation

    Public WriteOnly Property CallingFormProperty As ChooseLocation
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim createOrderWindow As New createOrder
        createOrderWindow.MdiParent = Me.MdiParent
        createOrderWindow.CallingFormProperty = Me
        createOrderWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
        callingForm.doAThing()
    End Sub
End Class