Imports System.Runtime.InteropServices

Public Class Feedback
    Private stars As New List(Of PictureBox)
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
        For Each yellowStar As PictureBox In stars.GetRange(0, starIndex)
            yellowStar.Image = My.Resources.star
        Next
        For Each whiteStar As PictureBox In stars.GetRange(starIndex, stars.Count - starIndex)
            whiteStar.Image = My.Resources.star_empty
        Next
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendMessage(Me.OrderIDBox.Handle, &H1501, 0, "Order ID")
        SendMessage(Me.ReviewBox.Handle, &H1501, 0, "Enter your review...")
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

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

End Class