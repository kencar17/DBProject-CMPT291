Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class AddNewUser
    Private callingForm As UserAdmin

    Public WriteOnly Property CallingFormProperty As UserAdmin
        Set(value As UserAdmin)
            callingForm = value
        End Set
    End Property

    Private Sub AddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.AcceptButton = SubmitButton
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
        ' 5. Create a User with the given info
        Me.ErrorLabel.Visible = False

        If UsernameBox.Text.Equals("") Then
            ErrorLabel.Text = "A username must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If PassBox.Text.Equals("") Then
            ErrorLabel.Text = "A password must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If FirstnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A first name must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If LastnameBox.Text.Equals("") Then
            ErrorLabel.Text = "A last name must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If EmailBox.Text.Equals("") Then
            ErrorLabel.Text = "An email must be given."
            Me.ErrorLabel.Visible = True
            Return
        End If
        If Not User.FindUser(Me.UsernameBox.Text) Is Nothing Then
            ErrorLabel.Text = String.Format("{0} already exists", UsernameBox.Text)
            ErrorLabel.Visible = True
            Return
        End If

        Dim hashedPass As String = BCrypt.Net.BCrypt.HashPassword(PassBox.Text)

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "INSERT INTO Employee (FirstName, LastName, PostalCode, StreetAddress, City, State, Country, Email) VALUES (@firstname, @lastname, @pcode, @addr, @city, @state, @country, @email)"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@firstname", FirstnameBox.Text)
                .Parameters.AddWithValue("@lastname", LastnameBox.Text)
                .Parameters.AddWithValue("@pcode", PostcodeBox.Text)
                .Parameters.AddWithValue("@addr", AddressBox.Text)
                .Parameters.AddWithValue("@city", CityBox.Text)
                .Parameters.AddWithValue("@state", StateBox.Text)
                .Parameters.AddWithValue("@country", CountryBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        dbconn = SQLConnection.Instance.GetConnection()
        Dim eid As String
        Using sqlComma As New MySqlCommand()
            With sqlComma
                .Connection = dbconn
                .CommandText = "SELECT EID FROM Employee WHERE FirstName = @firstname AND LastName = @lastname AND Email = @email"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@firstname", FirstnameBox.Text)
                .Parameters.AddWithValue("@lastname", LastnameBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComma.ExecuteReader()
                While sqlReader.Read()
                    eid = sqlReader("EID").ToString()
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlCommb As New MySqlCommand()
            With sqlCommb
                .Connection = dbconn
                .CommandText = "INSERT INTO User (Username, Password, PersonID) VALUES (@username, @pass, @eid)"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@username", UsernameBox.Text)
                .Parameters.AddWithValue("@pass", hashedPass)
                .Parameters.AddWithValue("@eid", eid)
            End With
            Try
                sqlCommb.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox("User added!")
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class