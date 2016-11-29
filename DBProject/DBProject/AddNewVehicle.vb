Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient
Public Class AddNewVehicle
    Dim chosenFile As String = ""

    Private Sub AddNewVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent.Size = New Size(748, 594)
        Me.AcceptButton = Me.addVehicle
        vinLabel.BackColor = Color.Transparent
        modelLabel.BackColor = Color.Transparent
        kmLabel.BackColor = Color.Transparent
        seatingLabel.BackColor = Color.Transparent
        transmissionLabel.BackColor = Color.Transparent
        availableLabel.BackColor = Color.Transparent
        branchLabel.BackColor = Color.Transparent
        makeLabel.BackColor = Color.Transparent
        classLabel.BackColor = Color.Transparent
        yearLabel.BackColor = Color.Transparent
        gvwrLabel.BackColor = Color.Transparent
        plateLabel.BackColor = Color.Transparent
        coverageLabel.BackColor = Color.Transparent
        wrongInfo.BackColor = Color.Transparent
        enterVehicleLabel.BackColor = Color.Transparent

        Dim seatsList = New List(Of String)
        For seat As Integer = 1 To 10
            seatsList.Add(seat.ToString)
        Next
        seatsCB.DataSource = seatsList

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
                    vehicleTypes.VClass = sqlReader("Type").ToString()
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
        ElseIf VINbox.Text.Length < 13 Then
            wrongInfo.Text = "VIN must atleast 13 characters"
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
        ElseIf YearBox.Text.Length < 4 Then
            wrongInfo.Text = "The year must be 4 digits long"
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

        Dim uploadUrl As String = "http://res.cloudinary.com/dmhf7fjrc/image/upload/c_scale,h_75,w_113/v1480226236/car-clipart-blue-toy-car-clipart_1_gkkjjn.png"
        If Not chosenFile.Equals("") Then
            uploadUrl = Faces.uploadVehicle(chosenFile)
        End If

        Dim selectedBranch As Branch = BranchCB.SelectedItem
        Dim selectedClass As VehicleInfo = ClassCB.SelectedItem
        Dim vehicleInsertSql As String = "INSERT INTO Vehicle (VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage, BID, ImageUrl) VALUES (@vin, @make, @model, @class, @km, @year, @seats, @gvwr, @trans, @license, @avail, @coverage, @bid, @img)"
        Dim vehicleInsertParams As New Dictionary(Of String, String)
        With vehicleInsertParams
            .Add("@vin", VINbox.Text)
            .Add("@make", MakeBox.Text)
            .Add("@model", ModelBox.Text)
            .Add("@class", selectedClass.VClass)
            .Add("@km", KMBox.Text)
            .Add("@year", YearBox.Text)
            .Add("@seats", seatsCB.SelectedItem)
            .Add("@gvwr", GVWRBox.Text)
            .Add("@trans", trans)
            .Add("@license", PlateBox.Text)
            .Add("@avail", avail)
            .Add("@coverage", CoverageBox.Text)
            .Add("@bid", selectedBranch.BidProperty)
            .Add("@img", uploadUrl)
        End With
        SQLConnection.DoNonQuery(vehicleInsertSql, vehicleInsertParams)

        MsgBox("Vehicle Added")
        Me.Close()
    End Sub


    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("ca")
    End Sub

    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        Dim fd As New OpenFileDialog

        With fd
            .Title = "Choose an image"
            .InitialDirectory = SpecialDirectories.MyPictures
            .Filter = "All Images (*.bmp, *.gif, *.jpg, *.jpeg, *.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png"

            If .ShowDialog() = DialogResult.OK Then
                chosenFile = .FileName
                ImageLabel.Text = chosenFile
                VehiclePicture.Load(chosenFile)
            End If
        End With
    End Sub

    Private Sub VINBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles VINbox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub YearBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles YearBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GVWRBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles GVWRBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KMBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles KMBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CoverageBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles CoverageBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub
End Class
