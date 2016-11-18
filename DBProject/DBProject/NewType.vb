Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class NewType
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("types")
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ErrLabel.Visible = False

        If TypeBox.Text.Equals("") Then
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

        Dim insertSql As String = "INSERT INTO Types (DailyRate, WeeklyRate, MonthlyRate, Type) VALUES (@dr, @wr, @mr, @type)"
        Dim insertParams As New Dictionary(Of String, String)
        With insertParams
            .Add("@dr", DailyRate.Value)
            .Add("@wr", WeeklyRate.Value)
            .Add("@mr", MonthlyRate.Value)
            .Add("@type", TypeBox.Text)
        End With
        SQLConnection.DoNonQuery(insertSql, insertParams)

        MsgBox(TypeBox.Text & " has been created.")
        Close()
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub NewType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.TypeBox.Handle, &H1501, 0, "Description")
        AcceptButton = SubmitButton
    End Sub
End Class