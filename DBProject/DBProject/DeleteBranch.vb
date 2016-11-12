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

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "DELETE FROM Branch WHERE Bid=@bid"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@bid", selectedBranch.BidProperty)
            End With
            sqlComm.ExecuteNonQuery()
        End Using
        SQLConnection.Instance.CloseConnection()

        MsgBox("The branch has been deleted.")
        Init()
    End Sub

    Private Sub HButton_Click(sender As Object, e As EventArgs) Handles HButton.Click
        Help.GetHelp()
    End Sub

    Private Sub DeleteBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = SubmitButton
        Init()
    End Sub

    Private Sub Init()
        BranchSelection.Items.Clear()
        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT StreetAddress, City, BID FROM Branch"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim thebranch As New Branch
                    thebranch.BidProperty = CInt(sqlReader("BID").ToString())
                    thebranch.AddressProperty = sqlReader("StreetAddress").ToString()
                    thebranch.CityProperty = sqlReader("City").ToString()
                    BranchSelection.Items.Add(thebranch)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()
    End Sub
End Class