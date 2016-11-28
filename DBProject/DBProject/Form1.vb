Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim callingForm As Parent

    Public Property CallingFormProperty As Parent
        Get
            Return callingForm
        End Get
        Set
            callingForm = Value
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = SignInButton
        SendMessage(Me.UserBox.Handle, &H1501, 0, "Username")
        SendMessage(Me.PassBox.Handle, &H1501, 0, "Password")
        Me.PassBox.PasswordChar = "*"
        Me.NotFoundLabel.Visible = False
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = callingForm
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.NotFoundLabel.Visible = False
        Dim aUser As User = User.FindUser(UserBox.Text)
        If aUser Is Nothing Then
            Me.NotFoundLabel.Visible = True
            Me.NotFoundLabel.Text = "Invalid user credentials"
            Return
        End If

        Dim valid As Boolean = aUser.CheckPassword(PassBox.Text)
        If Not valid Then
            Me.NotFoundLabel.Visible = True
            Me.NotFoundLabel.Text = "Invalid user credentials"
        Else
            Dim homeForm As New Home
            homeForm.LoggedInUserProperty = aUser
            homeForm.CallingFormProperty = Me
            homeForm.MdiParent = Me.MdiParent
            homeForm.Show()
            Me.UserBox.Text = ""
            Me.PassBox.Text = ""
        End If
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        ' Launch the view inventory form
        Dim viewInventory As New ViewInventory
        viewInventory.MdiParent = Me.MdiParent
        viewInventory.CallingFormProperty = Me
        viewInventory.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.MdiParent.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("gs")
    End Sub

    Private Sub RateButton_Click(sender As Object, e As EventArgs) Handles RateButton.Click
        Dim fback As New Feedback
        fback.MdiParent = Me.MdiParent
        fback.CallingFormProperty = Me
        fback.Show()
    End Sub

    Private Sub Form1_LostFocus() Handles MyBase.LostFocus
        UserBox.Text = ""
        PassBox.Text = ""
    End Sub
End Class
