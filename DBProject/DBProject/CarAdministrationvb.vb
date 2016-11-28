Public Class CarAdministrationvb
    Private Sub AddVehicleB_Click(sender As Object, e As EventArgs) Handles AddVehicleB.Click
        Dim AddVehicle As New AddNewVehicle
        AddVehicle.MdiParent = Me.MdiParent
        AddVehicle.Show()
    End Sub

    Private Sub RemoveVehicleB_Click(sender As Object, e As EventArgs) Handles RemoveVehicleB.Click
        Dim RemoveVehicle As New RemoveVehicle
        RemoveVehicle.MdiParent = Me.MdiParent
        RemoveVehicle.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim UpdateVehicle As New UpdateVehicle
        UpdateVehicle.MdiParent = Me.MdiParent
        UpdateVehicle.Show()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("ca")
    End Sub
End Class