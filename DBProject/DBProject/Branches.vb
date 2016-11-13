Public Class Branches
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim create As New NewBranch
        create.MdiParent = Me.MdiParent
        create.Show()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim upbranch As New UpdateBranch
        upbranch.MdiParent = Me.MdiParent
        upbranch.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim dbranch As New DeleteBranch
        dbranch.MdiParent = Me.MdiParent
        dbranch.Show()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("branches")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class