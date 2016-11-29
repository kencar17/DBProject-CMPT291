Imports System.Runtime.InteropServices

Public Class Register
    Private user As User = Nothing
    Private callingForm As Home

    Private WriteOnly Property CallingFormProperty() As Home
        Set(value As Home)
            Me.callingForm = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Delete the old user if it existed


    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        SendMessage(Me.UserNameBox.Handle, &H1501, 0, "Username")
        SendMessage(Me.UserPassBox.Handle, &H1501, 0, "Password")
        SendMessage(Me.FirstNameBox.Handle, &H1501, 0, "First Name")
        SendMessage(Me.LastNameBox.Handle, &H1501, 0, "Last Name")
        SendMessage(Me.AddressBox.Handle, &H1501, 0, "Address")
        SendMessage(Me.PostBox.Handle, &H1501, 0, "Post Code")
        SendMessage(Me.CityBox.Handle, &H1501, 0, "City")
        SendMessage(Me.StateBox.Handle, &H1501, 0, "State")
        SendMessage(Me.CountryBox.Handle, &H1501, 0, "Country")
        SendMessage(Me.EmailBox.Handle, &H1501, 0, "Email")
        If Not user Is Nothing Then
            Me.UserNameBox.Text = user.UsernameProperty
            Me.UserPassBox.Text = user.PasswordProperty
        End If
    End Sub

    Public Sub SetUser(user As User)
        Me.user = user
    End Sub

    Public Sub Register_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.Show()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
End Class