Imports MySql.Data.MySqlClient
Public Class ChooseLocation

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim rentalWindow As New ChooseRental
        rentalWindow.MdiParent = Me.MdiParent
        rentalWindow.CallingFormProperty = Me
        rentalWindow.Show()
    End Sub

    Public Sub doAThing()
        Hide()
    End Sub

    Private Sub ChooseLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        locationCombBox.Items.Add("Location")
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT DISTINCT Branch.StreetAddress, Branch.City From Branch"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim address As String = sqlReader("StreetAddress").ToString()
                    Dim city As String = sqlReader("City").ToString()
                    Dim location As String = address + ", " + city

                    locationCombBox.Items.Add(location)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
        locationCombBox.SelectedItem = "Location"

        timeComboOne.Items.Add("00:00")
        timeComboTwo.Items.Add("00:00")
        For time As Integer = 8 To 19
            Dim num As String = CStr(time)
            If time.Equals(8) OrElse time.Equals(9) Then
                num = "0" + CStr(time)
            End If

            Dim number As String = CStr(num) + ":00"
            timeComboOne.Items.Add(number)
            timeComboTwo.Items.Add(number)

            Dim number2 As String = CStr(num) + ":30"
            timeComboOne.Items.Add(number2)
            timeComboTwo.Items.Add(number2)
        Next
        timeComboOne.SelectedItem = "00:00"
        timeComboTwo.SelectedItem = "00:00"


    End Sub

    Private Sub locationCombBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles locationCombBox.SelectedIndexChanged

    End Sub
End Class