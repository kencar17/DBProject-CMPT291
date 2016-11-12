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

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "DELETE FROM Vehicle WHERE VIN = @vin"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@vin", VINRemoveBox.Text)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox(VINRemoveBox.Text & " has been deleted.")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("RemoveVehicle")
    End Sub
End Class