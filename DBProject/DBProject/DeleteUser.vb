Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class DeleteUser
    Private callingForm As UserAdmin

    Public WriteOnly Property CallingFormProperty As UserAdmin
        Set(value As UserAdmin)
            callingForm = value
        End Set
    End Property

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Init()
    End Sub

    Private Sub Init()
        Me.AcceptButton = Me.DeleteButton
        Me.UserSelection.Items.Clear()

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT Username, PersonID FROM User"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim username As String = sqlReader("Username").ToString()
                    Dim newUser As New User(username, "")
                    newUser.IdProperty = CInt(sqlReader("PersonID").ToString())
                    UserSelection.Items.Add(newUser)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim selectedUser As User = UserSelection.SelectedItem
        If selectedUser Is Nothing Then
            MsgBox("Please select a user.")
            Return
        End If

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "DELETE FROM User WHERE Username = @username"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@username", selectedUser.UsernameProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "DELETE FROM Employee WHERE EID = @id"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", selectedUser.IdProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox(selectedUser.UsernameProperty & " has been deleted.")
        Init()
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("ua")
    End Sub
End Class