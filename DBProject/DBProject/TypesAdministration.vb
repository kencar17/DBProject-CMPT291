Public Class TypesAdministration
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("types")
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim ntype As New NewType
        ntype.MdiParent = Me.MdiParent
        ntype.Show()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim mtype As New ModifyType
        mtype.MdiParent = Me.MdiParent
        mtype.Show()
    End Sub

    Private Sub TypesAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
    End Sub
End Class