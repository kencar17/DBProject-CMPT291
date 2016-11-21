Imports MySql.Data.MySqlClient
Public Class AddNewVehicle
    Private Sub AddNewVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Me.addVehicle

        Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT Type FROM Types"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim vehicleTypes As New VehicleInfo()
                    vehicleTypes.VClassProperty = sqlReader("Type").ToString()
                    ClassCB.Items.Add(vehicleTypes)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        dbconn = SQLConnection.Instance.GetConnection()
        Using sqlComm As New MySqlCommand()
            With sqlComm
                .Connection = dbconn
                .CommandText = "SELECT BID, StreetAddress FROM Branch"
                .CommandType = CommandType.Text
            End With
            Try
                Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                While sqlReader.Read()
                    Dim branchName As New Branch()
                    branchName.BidProperty = CInt(sqlReader("BID").ToString())
                    branchName.AddressProperty = sqlReader("StreetAddress").ToString()
                    BranchCB.Items.Add(branchName)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        SQLConnection.Instance.CloseConnection()

        TransCB.Items.Add("Automatic")
        TransCB.Items.Add("Manual")

        AvailCB.Items.Add("Yes")
        AvailCB.Items.Add("No")
    End Sub

    Private Sub addVehicle_Click(sender As Object, e As EventArgs) Handles addVehicle.Click
        Me.wrongInfo.Visible = False
        Dim avail As String
        Dim trans As String

        If VINbox.Text.Equals("") Then
            wrongInfo.Text = "A VIN number must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If MakeBox.Text.Equals("") Then
            wrongInfo.Text = "A vehicle make must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If ModelBox.Text.Equals("") Then
            wrongInfo.Text = "A vehicle model must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If KMBox.Text.Equals("") Then
            wrongInfo.Text = "The Kilometers of the vehicle must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If YearBox.Text.Equals("") Then
            wrongInfo.Text = "The year the vehicle was made must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If SeatsBox.Text.Equals("") Then
            wrongInfo.Text = "Seating capacity must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If GVWRBox.Text.Equals("") Then
            wrongInfo.Text = "The Gross Vehicle Weight Rating must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        If CoverageBox.Text.Equals("") Then
            wrongInfo.Text = "The coverage of the vehicle must be given"
            Me.wrongInfo.Visible = True
            Return
        End If

        Dim vehicle = Inventory.FindVehicle(Me.VINbox.Text)
        If Not Inventory.FindVehicle(Me.VINbox.Text) Is Nothing Then
            wrongInfo.Text = "VIN already in database"
            wrongInfo.Visible = True
            Return
        End If

        If AvailCB.SelectedItem.Equals("Yes") Then
            avail = "1"
        Else
            avail = "0"
        End If

        If TransCB.SelectedItem.Equals("Automatic") Then
            trans = "1"
        Else
            trans = "0"
        End If

        Dim selectedBranch As Branch = BranchCB.SelectedItem
        Dim selectedClass As VehicleInfo = ClassCB.SelectedItem
        Dim vehicleInsertSql As String = "INSERT INTO Vehicle (VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage, BID) VALUES (@vin, @make, @model, @class, @km, @year, @seats, @gvwr, @trans, @license, @avail, @coverage, @bid)"
        Dim vehicleInsertParams As New Dictionary(Of String, String)
        With vehicleInsertParams
            .Add("@vin", VINbox.Text)
            .Add("@make", MakeBox.Text)
            .Add("@model", ModelBox.Text)
            .Add("@class", selectedClass.VClassProperty)
            .Add("@km", KMBox.Text)
            .Add("@year", YearBox.Text)
            .Add("@seats", SeatsBox.Text)
            .Add("@gvwr", GVWRBox.Text)
            .Add("@trans", trans)
            .Add("@license", PlateBox.Text)
            .Add("@avail", avail)
            .Add("@coverage", CoverageBox.Text)
	    .Add("@bid", selectedBranch.BidProperty)
        End With
        SQLConnection.DoNonQuery(vehicleInsertSql, vehicleInsertParams)

	MsgBox("Vehicle Added")
        Me.Close()
    End Sub


    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("addNewVehicle")
    End Sub

    'FIDD.Items.Add(Something)

    'Something must have ToString implemented to display it.
End Class
