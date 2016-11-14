Imports MySql.Data.MySqlClient
Public Class ViewInventory
    Private callingForm As Form1

    Public WriteOnly Property CallingFormProperty As Form1
        Set(value As Form1)
            callingForm = value
        End Set
    End Property

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT TID, DailyRate, WeeklyRate, MonthlyRate, Type FROM Types"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim newType As New Type(sqlReader("Type").ToString())
                    newType.TidProperty = sqlReader("TID").ToString()
                    newType.DailyRateProperty = sqlReader("DailyRate").ToString()
                    newType.WeeklyRateProperty = sqlReader("WeeklyRate").ToString()
                    newType.MonthlyRateProperty = sqlReader("MonthlyRate").ToString()
                    TypeCB.Items.Add(newType)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("ViewInventory")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub ViewInventory_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.WindowState = FormWindowState.Maximized
    End Sub
End Class