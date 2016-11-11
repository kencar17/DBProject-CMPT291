Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Backup
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp()
    End Sub

    Private Sub BackupButton_Click(sender As Object, e As EventArgs) Handles BackupButton.Click
        Dim fileName As String = "CarRentals " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".sql"
        Dim filepath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fileName)
        Dim dbConnection As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            Using mb As New MySqlBackup(sqlComm)
                sqlComm.Connection = dbConnection
                mb.ExportToFile(filepath)
            End Using
        End Using
        MsgBox("System saved to " & filepath)
    End Sub
End Class