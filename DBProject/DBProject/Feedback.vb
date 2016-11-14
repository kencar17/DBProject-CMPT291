Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Feedback
    Private stars As New List(Of PictureBox)
    Private starCount As Integer = 1
    Private callingForm As Form1

    Public WriteOnly Property CallingFormProperty As Form1
        Set(value As Form1)
            callingForm = value
        End Set
    End Property

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateStars(starIndex As Integer)
        ' Update the stars
        starCount = starIndex
        For Each yellowStar As PictureBox In stars.GetRange(0, starIndex)
            yellowStar.Image = My.Resources.star
        Next
        For Each whiteStar As PictureBox In stars.GetRange(starIndex, stars.Count - starIndex)
            whiteStar.Image = My.Resources.star_empty
        Next
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CharCounter.ForeColor = Color.Green
        TIDBox.TextAlign = HorizontalAlignment.Right
        stars.Add(Me.s1)
        stars.Add(Me.s2)
        stars.Add(Me.s3)
        stars.Add(Me.s4)
        stars.Add(Me.s5)
        stars.Add(Me.s6)
        stars.Add(Me.s7)
        stars.Add(Me.s8)
        stars.Add(Me.s9)
        stars.Add(Me.s10)
    End Sub

    Private Sub Feedback_Unload(sender As Object, e As EventArgs) Handles MyBase.Closing
        callingForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub s1_Click(sender As Object, e As EventArgs) Handles s1.Click
        UpdateStars(1)
    End Sub

    Private Sub s2_Click(sender As Object, e As EventArgs) Handles s2.Click
        UpdateStars(2)
    End Sub

    Private Sub s3_Click(sender As Object, e As EventArgs) Handles s3.Click
        UpdateStars(3)
    End Sub

    Private Sub s4_Click(sender As Object, e As EventArgs) Handles s4.Click
        UpdateStars(4)
    End Sub

    Private Sub s5_Click(sender As Object, e As EventArgs) Handles s5.Click
        UpdateStars(5)
    End Sub

    Private Sub s6_Click(sender As Object, e As EventArgs) Handles s6.Click
        UpdateStars(6)
    End Sub

    Private Sub s7_Click(sender As Object, e As EventArgs) Handles s7.Click
        UpdateStars(7)
    End Sub

    Private Sub s8_Click(sender As Object, e As EventArgs) Handles s8.Click
        UpdateStars(8)
    End Sub

    Private Sub s9_Click(sender As Object, e As EventArgs) Handles s9.Click
        UpdateStars(9)
    End Sub

    Private Sub s10_Click(sender As Object, e As EventArgs) Handles s10.Click
        UpdateStars(10)
    End Sub
    Private Sub ReviewBox_TextChanged(sender As Object, e As EventArgs) Handles ReviewBox.TextChanged
        Dim charCount As Integer = ReviewBox.Text.Length
        If charCount <= 400 Then
            CharCounter.ForeColor = Color.Green
        Else
            CharCounter.ForeColor = Color.Red
        End If
        CharCounter.Text = charCount & " / 500"
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' 1. Check that the given orderID exists. If it does, store it
        ' 2. 
        ' UPDATE Transaction SET ExperienceRating=@stars,ReviewComments=@comments WHERE TID=@identifier
        errorLabel.Visible = False

        If TIDBox.Text.Length < 1 Then
            errorLabel.Text = "Transaction ID required"
            errorLabel.Visible = True
            Return
        End If

        Dim dbConn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbConn
                .CommandText = "UPDATE Transaction SET ExperienceRating=@stars,ReviewComments=@comments WHERE TID=@identifier"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@stars", starCount)
                .Parameters.AddWithValue("@comments", ReviewBox.Text)
                .Parameters.AddWithValue("@identifier", CInt(TIDBox.Text))
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        dbConn.Close()
        MsgBox("Your feedback has been recorded. Thank you!")
        Me.Close()
    End Sub

    Private Sub TIDBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TIDBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("feedback")
    End Sub
End Class