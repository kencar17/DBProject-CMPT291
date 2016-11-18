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

        Dim selectSql As String = "SELECT Username, PersonID FROM User"
        Dim selectParams As New Dictionary(Of String, String)
        Dim selectColumns As New List(Of String)
        selectColumns.Add("Username")
        selectColumns.Add("PersonID")
        Dim selectResults As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectSql, selectParams, selectColumns)

        For Each result As Dictionary(Of String, String) In selectResults
            Dim newuser As New User(result("Username"), "")
            newuser.IdProperty = CInt(result("PersonID"))
            UserSelection.Items.Add(newuser)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim selectedUser As User = UserSelection.SelectedItem
        If selectedUser Is Nothing Then
            MsgBox("Please select a user.")
            Return
        End If

        Dim userdelSql As String = "DELETE FROM User WHERE Username = @username"
        Dim userdelParams As New Dictionary(Of String, String)
        userdelParams.Add("@username", selectedUser.UsernameProperty)
        SQLConnection.DoNonQuery(userdelSql, userdelParams)

        Dim empdelSql As String = "DELETE FROM Employee WHERE EID = @id"
        Dim empdelParams As New Dictionary(Of String, String)
        empdelParams.Add("@id", selectedUser.IdProperty)
        SQLConnection.DoNonQuery(empdelSql, empdelParams)

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