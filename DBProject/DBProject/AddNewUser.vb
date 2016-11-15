Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class AddNewUser
    Private callingForm As UserAdmin
    Private chosenFile As String = ""

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
        ' First, do some error checking
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
        ' Check if the user already exists using the check implemented in my User class
        If Not User.FindUser(Me.UsernameBox.Text) Is Nothing Then
            ErrorLabel.Text = String.Format("{0} already exists", UsernameBox.Text)
            ErrorLabel.Visible = True
            Return
        End If

        ' Hash the password
        Dim hashedPass As String = BCrypt.Net.BCrypt.HashPassword(PassBox.Text)

        ' Get a connection to the database
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        ' Set up a command to run some SQL with
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn ' Tell the sql command to use the connection we got just above
                ' Give the command some sql to run
                .CommandText = "INSERT INTO Employee (FirstName, LastName, PostalCode, StreetAddress, City, State, Country, Email) VALUES (@firstname, @lastname, @pcode, @addr, @city, @state, @country, @email)"
                .CommandType = CommandType.Text
                ' Add the values. The sql above has keys such as @firstname which will now be replaced:
                .Parameters.AddWithValue("@firstname", FirstnameBox.Text)
                .Parameters.AddWithValue("@lastname", LastnameBox.Text)
                .Parameters.AddWithValue("@pcode", PostcodeBox.Text)
                .Parameters.AddWithValue("@addr", AddressBox.Text)
                .Parameters.AddWithValue("@city", CityBox.Text)
                .Parameters.AddWithValue("@state", StateBox.Text)
                .Parameters.AddWithValue("@country", CountryBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
            End With
            ' Run the command. This command doesn't give back any results, so can just use ExecuteNonQuery
            sqlComm.ExecuteNonQuery()
        End Using
        ' Finally close the connection
        SQLConnection.Instance.CloseConnection()

        ' Get another connection and command
        dbconn = SQLConnection.Instance.GetConnection()
        Dim eid As String
        Using sqlComma As New MySqlCommand()
            ' Give the command the sql stuff to get the EID of the Employee just inserted above
            With sqlComma
                .Connection = dbconn
                .CommandText = "SELECT EID FROM Employee WHERE FirstName = @firstname AND LastName = @lastname AND Email = @email"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@firstname", FirstnameBox.Text)
                .Parameters.AddWithValue("@lastname", LastnameBox.Text)
                .Parameters.AddWithValue("@email", EmailBox.Text)
            End With
            Try
                ' This time I need data returned so I get a data reader
                Dim sqlReader As MySqlDataReader = sqlComma.ExecuteReader()
                While sqlReader.Read()
                    ' While I'm reading the results of the query, I look for the column EID and store the contents into my variable eid
                    eid = sqlReader("EID").ToString()
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        ' Finally close the connection
        SQLConnection.Instance.CloseConnection()

        Dim uploadUrl As String = "http://res.cloudinary.com/dmhf7fjrc/image/upload/c_scale,h_141,w_100/v1479153691/sample.jpg"
        If Not chosenFile.Equals("") Then
            uploadUrl = Faces.upload(chosenFile)
        End If

        ' Get another connection and do another insert similar to the first one, this time using the eid I got above
        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlCommb As New MySqlCommand()
            With sqlCommb
                .Connection = dbconn
                .CommandText = "INSERT INTO User (Username, Password, PersonID, ImgUrl) VALUES (@username, @pass, @eid, @url)"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@username", UsernameBox.Text)
                .Parameters.AddWithValue("@pass", hashedPass)
                .Parameters.AddWithValue("@eid", eid)
                .Parameters.AddWithValue("@url", uploadUrl)
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

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("ua")
    End Sub

    Private Sub ImgButton_Click(sender As Object, e As EventArgs) Handles ImgButton.Click
        Dim fd As New OpenFileDialog

        With fd
            .Title = "Choose an image"
            .InitialDirectory = SpecialDirectories.MyPictures
            .Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|All Images (*.bmp, *.gif, *.jpg, *.jpeg, *.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png"

            If .ShowDialog() = DialogResult.OK Then
                chosenFile = .FileName
                PicturePath.Text = chosenFile
            End If
        End With
    End Sub
End Class