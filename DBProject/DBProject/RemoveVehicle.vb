Imports MySql.Data.MySqlClient
Public Class RemoveVehicle
    Private Sub RMVButton_Click(sender As Object, e As EventArgs) Handles RMVButton.Click
        ErrorLabel.Visible = False
        Dim vin As String = VinBox.SelectedItem

        If vin Is Nothing OrElse vin.Equals("") Then
            ErrorLabel.Text = "Must select a VIN."
            ErrorLabel.Visible = True
            Return
        End If

        Dim deleteSql As String = "DELETE FROM Vehicle WHERE VIN=@vin"
        Dim deleteParams As New Dictionary(Of String, String)
        deleteParams.Add("@vin", vin)
        SQLConnection.DoNonQuery(deleteSql, deleteParams)

        MsgBox(vin & " has been deleted.")
        Init()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("RemoveVehicle")
    End Sub

    Private Sub RemoveVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub Init()
        VinBox.Items.Clear()
        Dim sql As String = "SELECT VIN FROM Vehicle"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        columns.Add("VIN")
        For Each vin As Dictionary(Of String, String) In SQLConnection.DoQuery(sql, params, columns)
            VinBox.Items.Add(vin("VIN"))
        Next
    End Sub
End Class