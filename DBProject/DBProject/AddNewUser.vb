Imports System.Runtime.InteropServices

Public Class AddNewUser
    Private callingForm As UserAdmin

    Public WriteOnly Property CallingFormProperty As UserAdmin
        Set(value As UserAdmin)
            callingForm = value
        End Set
    End Property

    Private Sub AddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.UsernameBox.Handle, &H1501, 0, "Username")
        SendMessage(Me.PassBox.Handle, &H1501, 0, "Password")
        Me.PassBox.PasswordChar = "*"
        SendMessage(Me.FirstnameBox.Handle, &H1501, 0, "First Name")
        SendMessage(Me.LastnameBox.Handle, &H1501, 0, "Last Name")
        SendMessage(Me.AddressBox.Handle, &H1501, 0, "Address")
        SendMessage(Me.PostcodeBox.Handle, &H1501, 0, "Postal Code")
        SendMessage(Me.CityBox.Handle, &H1501, 0, "City")
        SendMessage(Me.StateBox.Handle, &H1501, 0, "State")
        SendMessage(Me.CountryBox.Handle, &H1501, 0, "Country")
        SendMessage(Me.EmailBox.Handle, &H1501, 0, "Email")
    End Sub

    Private Sub AddNewUser_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing

    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' 2. Ensure a password is given
        ' 3. Create an Employee with given info
        ' 4. Select the new Employee to get EID
        ' 5. Create a User with the given info
        Me.ErrorLabel.Visible = False
        If User.FindUser(Me.UsernameBox.Text) Is Nothing Then
            ErrorLabel.Text = String.Format("{0} already exists", UsernameBox.Text)
            ErrorLabel.Visible = True
            Return
        End If

        If UsernameBox.Text.Equals("") Then
            ErrorLabel.Text = "A username must be given."
        End If
        If PassBox.Text.Equals("") Then
            ErrorLabel.Text = "A password must be given."
        End If
        If FirstnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A first name must be given."
        End If
        If LastnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A last name must be given."
        End If
    End Sub
End Class