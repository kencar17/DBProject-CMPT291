﻿Public Class CarAdministrationvb
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

    Private Sub SearchB_Click(sender As Object, e As EventArgs) Handles SearchB.Click
        Dim SearchVehicles As New SearchVehicles
        SearchVehicles.MdiParent = Me.MdiParent
        SearchVehicles.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class