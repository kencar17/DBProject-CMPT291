Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.UserBox.Handle, &H1501, 0, "Username")
        SendMessage(Me.PassBox.Handle, &H1501, 0, "Password")
        Me.PassBox.PasswordChar = "*"
        Me.NotFoundLabel.Visible = False
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.NotFoundLabel.Visible = False
        Dim valid As Boolean = User.CheckPassword(UserBox.Text, PassBox.Text)
        If Not valid Then
            Me.NotFoundLabel.Visible = True
            Me.NotFoundLabel.Text = "Invalid user, please register"
        End If
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim username As String = UserBox.Text
        Dim password As String = PassBox.Text
        Dim newUser As New User(username, password, False)
    End Sub
End Class
