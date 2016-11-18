Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class ModifyType
    Private Sub ModifyType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.Type.Handle, &H1501, 0, "Description")

        Dim selectSql As String = "SELECT * FROM Types"
        Dim selectParams As Dictionary(Of String, String)
        Dim selectColumns As New List(Of String)
        With selectColumns
            .Add("Type")
            .Add("TID")
            .Add("DailyRate")
            .Add("WeeklyRate")
            .Add("MonthlyRate")
        End With
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectSql, selectParams, selectColumns)

        For Each result As Dictionary(Of String, String) In results
            Dim atype As New Type(result("Type"))
            With atype
                .TidProperty = CInt(result("TID"))
                .DailyRateProperty = CDec(result("DailyRate"))
                .WeeklyRateProperty = CDec(result("WeeklyRate"))
                .MonthlyRateProperty = CDec(result("MonthlyRate"))
                TypeSelection.Items.Add(atype)
            End With
        Next
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

        Dim updateSql As String = "UPDATE Types SET DailyRate=@dr, WeeklyRate=@wr, MonthlyRate=@mr, Type=@type WHERE TID=@tid"
        Dim updateParams As New Dictionary(Of String, String)
        With updateParams
            .Add("@dr", DailyRate.Text)
            .Add("@wr", WeeklyRate.Text)
            .Add("@mr", MonthlyRate.Text)
            .Add("@type", Type.Text)
            .Add("@tid", selectedType.TidProperty)
        End With

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