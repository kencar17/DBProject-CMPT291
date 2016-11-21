Imports MySql.Data.MySqlClient
Public Class RemoveVehicle
    Private Sub RMVButton_Click(sender As Object, e As EventArgs) Handles RMVButton.Click
        ErrorLabel.Visible = False

        If VINRemoveBox.Text.Equals("") Then
            ErrorLabel.Text = "Must enter a VIN to remove"
            ErrorLabel.Visible = True
            Return
        End If

        Dim vehicle = Inventory.FindVehicle(VINRemoveBox.Text)
        If vehicle Is Nothing Then
            ErrorLabel.Text = "VIN not Found"
            ErrorLabel.Visible = True
            Return
        End If

        Dim deleteSql As String = "DELETE FROM Vehicle WHERE VIN=@vin"
        Dim deleteParams As New Dictionary(Of String, String)
        deleteParams.Add("@vin", VINRemoveBox.Text)
        SQLConnection.DoNonQuery(deleteSql, deleteParams)

        MsgBox(VINRemoveBox.Text & " has been deleted.")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("RemoveVehicle")
    End Sub
End Class