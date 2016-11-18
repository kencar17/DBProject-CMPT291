Imports MySql.Data.MySqlClient

Public Class DeleteBranch
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ErrLabel.Visible = False
        Dim selectedBranch As Branch = BranchSelection.SelectedItem
        If selectedBranch Is Nothing Then
            ErrLabel.Text = "Please select a branch."
            ErrLabel.Visible = True
            Return
        End If

        Dim deleteSql As String = "DELETE FROM Branch WHERE Bid=@bid"
        Dim deleteparams As New Dictionary(Of String, String)
        deleteparams.Add("@bid", selectedBranch.BidProperty)
        SQLConnection.DoNonQuery(deleteSql, deleteparams)

        MsgBox("The branch has been deleted.")
        Init()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp("branches")
    End Sub

    Private Sub DeleteBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = SubmitButton
        Init()
    End Sub

    Private Sub Init()
        BranchSelection.Items.Clear()

        Dim selectSql As String = "SELECT StreetAddress, City, BID FROM Branch"
        Dim selectParams As New Dictionary(Of String, String)
        Dim selectColumns As New List(Of String)
        With selectColumns
            .Add("BID")
            .Add("StreetAddress")
            .Add("City")
        End With
        Dim results As List(Of Dictionary(Of String, String)) = SQLConnection.DoQuery(selectSql, selectParams, selectColumns)

        For Each result As Dictionary(Of String, String) In results
            Dim newBranch As New Branch
            newBranch.BidProperty = CInt(result("BID"))
            newBranch.AddressProperty = result("StreetAddress")
            newBranch.CityProperty = result("City")
            BranchSelection.Items.Add(newBranch)
        Next

    End Sub
End Class