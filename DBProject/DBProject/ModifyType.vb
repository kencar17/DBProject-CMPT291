Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class ModifyType
    Private Sub ModifyType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.Type.Handle, &H1501, 0, "Description")

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT * FROM Types"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim atype As New Type(sqlReader("Type").ToString())
                    atype.TidProperty = CInt(sqlReader("TID").ToString())
                    atype.DailyRateProperty = CDec(sqlReader("DailyRate").ToString())
                    atype.WeeklyRateProperty = CDec(sqlReader("WeeklyRate").ToString())
                    atype.MonthlyRateProperty = CDec(sqlReader("MonthlyRate").ToString())
                    TypeSelection.Items.Add(atype)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("types")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ErrLabel.Visible = False

        If TypeSelection.SelectedItem Is Nothing Then
            ErrLabel.Text = "A type must be selected."
            ErrLabel.Visible = True
            Return
        End If
        If Type.Text.Equals("") Then
            ErrLabel.Text = "A description must be given."
            ErrLabel.Visible = True
            Return
        End If
        If DailyRate.Value.Equals(Decimal.Zero) Then
            ErrLabel.Text = "A daily rate must be given."
            ErrLabel.Visible = True
            Return
        End If
        If WeeklyRate.Value.Equals(Decimal.Zero) Then
            ErrLabel.Text = "A weekly rate must be given."
            ErrLabel.Visible = True
            Return
        End If
        If MonthlyRate.Value.Equals(Decimal.Zero) Then
            ErrLabel.Text = "A monthly rate must be given."
            ErrLabel.Visible = True
            Return
        End If

        Dim selectedType As Type = TypeSelection.SelectedItem

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "UPDATE Types SET DailyRate=@dr, WeeklyRate=@wr, MonthlyRate=@mr, Type=@type WHERE TID=@tid"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@dr", DailyRate.Text)
                .Parameters.AddWithValue("@wr", WeeklyRate.Text)
                .Parameters.AddWithValue("@mr", MonthlyRate.Text)
                .Parameters.AddWithValue("@type", Type.Text)
                .Parameters.AddWithValue("@tid", selectedType.TidProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox(Type.Text & " has been updated.")
    End Sub

    Private Sub TypeSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeSelection.SelectedIndexChanged
        Dim selectedType As Type = TypeSelection.SelectedItem
        Type.Text = selectedType.VehicleTypeProperty
        DailyRate.Value = selectedType.DailyRateProperty
        WeeklyRate.Value = selectedType.WeeklyRateProperty
        MonthlyRate.Value = selectedType.MonthlyRateProperty

        Type.Enabled = True
        DailyRate.Enabled = True
        WeeklyRate.Enabled = True
        MonthlyRate.Enabled = True
    End Sub
End Class