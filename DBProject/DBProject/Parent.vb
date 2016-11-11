Public Class Parent
    Private Sub Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.CallingFormProperty = Me
        f1.Show()
    End Sub
End Class