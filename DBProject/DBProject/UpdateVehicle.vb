Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient
Public Class UpdateVehicle
    Private chosenFile As String = ""

    Private Sub UpdateVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vsql As String = "SELECT Type FROM Types"
        Dim vparams As New Dictionary(Of String, String)
        Dim vcolumns As New List(Of String)
        vcolumns.Add("Type")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(vsql, vparams, vcolumns)
            Dim avehicle As New VehicleInfo
            avehicle.VClass = result("Type")
            ClassCB.Items.Add(avehicle)
        Next

        Dim bselectSql As String = "SELECT BID, StreetAddress FROM Branch"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        columns.Add("BID")
        columns.Add("StreetAddress")
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(bselectSql, params, columns)
            Dim abranch As New Branch
            abranch.BidProperty = CInt(result("BID"))
            abranch.AddressProperty = result("StreetAddress")
            BranchCB.Items.Add(abranch)
        Next


        TransCB.Items.Add("Automatic")
        TransCB.Items.Add("Manual")

        AvailCB.Items.Add("Yes")
        AvailCB.Items.Add("No")
    End Sub
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim vehicle = Inventory.FindVehicle(Me.VINUpdate.Text)
        If vehicle Is Nothing Then
            ErrorLabel.Text = "VIN not found"
            ErrorLabel.Visible = True
            Return
        End If


        MakeBox.Text = vehicle.MakeProperty
        ModelBox.Text = vehicle.ModelProperty
        For Each v As VehicleInfo In ClassCB.Items
            If v.VClass = vehicle.VClassProperty Then
                ClassCB.SelectedItem = v
            End If
        Next
        KmBox.Text = vehicle.KmProperty
        YearBox.Text = vehicle.YearProperty
        SeatBox.Text = vehicle.SeatsProperty
        GVWRBox.Text = vehicle.GvwrProperty

        If vehicle.TransmissionProperty.Equals("1") Then
            TransCB.SelectedIndex = 0
        Else
            TransCB.SelectedIndex = 1
        End If
        PlateBox.Text = vehicle.LPlateNumProperty
        If vehicle.AvailableProperty.Equals("True") Then
            AvailCB.SelectedIndex = 0
        Else
            AvailCB.SelectedIndex = 1
        End If
        AvailCB.SelectedItem = vehicle.AvailableProperty
        CoverageBox.Text = vehicle.CoverageProperty

        Dim i As Integer = 0
        While i < BranchCB.Items.Count
            Dim branch As New Branch
            branch = BranchCB.Items.Item(i)
            If branch.BidProperty.ToString().Equals(vehicle.BidProperty) Then
                BranchCB.SelectedItem = branch
            End If
            i += 1
        End While

    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Me.ErrorLabel.Visible = False
        Dim avail As String
        Dim trans As String

        If MakeBox.Text.Equals("") Then
            ErrorLabel.Text = "A vehicle make must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If ModelBox.Text.Equals("") Then
            ErrorLabel.Text = "A vehicle model must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If


        If KmBox.Text.Equals("") Then
            ErrorLabel.Text = "The Kilometers of the vehicle must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If YearBox.Text.Equals("") Then
            ErrorLabel.Text = "The year the vehicle was made must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If SeatBox.Text.Equals("") Then
            ErrorLabel.Text = "Seating capacity must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If GVWRBox.Text.Equals("") Then
            ErrorLabel.Text = "The Gross Vehicle Weight Rating must be given"
            Me.ErrorLabel.Visible = True
            Return
        End If

        If CoverageBox.Text.Equals("") Then
            ErrorLabel.Text = "The coverage of the vehicle must be given"
            Me.ErrorLabel.Visible = True
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

        Dim abranch As Branch = BranchCB.SelectedItem
        Console.WriteLine("~~~~~~~~~~~~" & abranch.BidProperty & "~~~~~~~~~~~~")
        Dim vehicle As VehicleInfo = ClassCB.SelectedItem
        Dim sql As String = "UPDATE Vehicle SET Make=@make, Model=@model, Class=@class, Km=@km, Year=@year, Seats=@seats, GVWR=@gvwr, Transmission=@trans, License=@license, Available=@avail, Coverage=@coverage, BID=@bid WHERE Vehicle.VIN = @vin"
        Dim params As New Dictionary(Of String, String)
        With params
            .Add("@vin", VINUpdate.Text)
            .Add("@make", MakeBox.Text)
            .Add("@model", ModelBox.Text)
            .Add("@class", vehicle.VClass)
            .Add("@km", KmBox.Text)
            .Add("@year", YearBox.Text)
            .Add("@seats", SeatBox.Text)
            .Add("@gvwr", GVWRBox.Text)
            .Add("@trans", trans)
            .Add("@license", PlateBox.Text)
            .Add("@avail", avail)
            .Add("@coverage", CoverageBox.Text)
            .Add("@bid", abranch.BidProperty)
        End With
        SQLConnection.DoNonQuery(sql, params)

        If Not chosenFile.Equals("") Then
            Dim uploadUrl As String = Faces.uploadVehicle(chosenFile)
            Dim uploadSql As String = "UPDATE Vehicle SET ImageUrl=@url WHERE Vehicle.VIN = @vin"
            Dim uploadParams As New Dictionary(Of String, String)
            With uploadParams
                .Add("@url", uploadUrl)
                .Add("@vin", VINUpdate.Text)
            End With
            SQLConnection.DoNonQuery(uploadSql, uploadParams)
        End If

        MsgBox("Vehicle Updated")
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("UpdateVehicle")
    End Sub

    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        Dim fd As New OpenFileDialog

        With fd
            .Title = "Choose an image"
            .InitialDirectory = SpecialDirectories.MyPictures
            .Filter = "All Images (*.bmp, *.gif, *.jpg, *.jpeg, *.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png"

            If .ShowDialog() = DialogResult.OK Then
                chosenFile = .FileName
                PicturePath.Text = chosenFile
            End If
        End With
    End Sub
End Class