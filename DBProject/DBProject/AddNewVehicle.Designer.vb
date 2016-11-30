<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewVehicle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.enterVehicleLabel = New System.Windows.Forms.Label()
        Me.vinLabel = New System.Windows.Forms.Label()
        Me.VINbox = New System.Windows.Forms.TextBox()
        Me.GVWRBox = New System.Windows.Forms.TextBox()
        Me.PlateBox = New System.Windows.Forms.TextBox()
        Me.CoverageBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.KMBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.makeLabel = New System.Windows.Forms.Label()
        Me.availableLabel = New System.Windows.Forms.Label()
        Me.plateLabel = New System.Windows.Forms.Label()
        Me.transmissionLabel = New System.Windows.Forms.Label()
        Me.gvwrLabel = New System.Windows.Forms.Label()
        Me.seatingLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.kmLabel = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.modelLabel = New System.Windows.Forms.Label()
        Me.coverageLabel = New System.Windows.Forms.Label()
        Me.addVehicle = New System.Windows.Forms.Button()
        Me.wrongInfo = New System.Windows.Forms.Label()
        Me.GoBack = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ClassCB = New System.Windows.Forms.ComboBox()
        Me.TransCB = New System.Windows.Forms.ComboBox()
        Me.AvailCB = New System.Windows.Forms.ComboBox()
        Me.branchLabel = New System.Windows.Forms.Label()
        Me.BranchCB = New System.Windows.Forms.ComboBox()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.VehiclePicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.seatsCB = New System.Windows.Forms.ComboBox()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enterVehicleLabel
        '
        Me.enterVehicleLabel.AutoSize = True
        Me.enterVehicleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterVehicleLabel.Location = New System.Drawing.Point(12, 87)
        Me.enterVehicleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.enterVehicleLabel.Name = "enterVehicleLabel"
        Me.enterVehicleLabel.Size = New System.Drawing.Size(261, 25)
        Me.enterVehicleLabel.TabIndex = 99
        Me.enterVehicleLabel.Text = "Enter Vehicle Information:"
        '
        'vinLabel
        '
        Me.vinLabel.AutoSize = True
        Me.vinLabel.Location = New System.Drawing.Point(160, 172)
        Me.vinLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vinLabel.Name = "vinLabel"
        Me.vinLabel.Size = New System.Drawing.Size(45, 25)
        Me.vinLabel.TabIndex = 1
        Me.vinLabel.Text = "VIN"
        '
        'VINbox
        '
        Me.VINbox.Location = New System.Drawing.Point(211, 168)
        Me.VINbox.Margin = New System.Windows.Forms.Padding(2)
        Me.VINbox.MaxLength = 13
        Me.VINbox.Name = "VINbox"
        Me.VINbox.Size = New System.Drawing.Size(266, 29)
        Me.VINbox.TabIndex = 0
        '
        'GVWRBox
        '
        Me.GVWRBox.Location = New System.Drawing.Point(711, 301)
        Me.GVWRBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GVWRBox.MaxLength = 7
        Me.GVWRBox.Name = "GVWRBox"
        Me.GVWRBox.Size = New System.Drawing.Size(264, 29)
        Me.GVWRBox.TabIndex = 7
        '
        'PlateBox
        '
        Me.PlateBox.Location = New System.Drawing.Point(711, 349)
        Me.PlateBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PlateBox.MaxLength = 10
        Me.PlateBox.Name = "PlateBox"
        Me.PlateBox.Size = New System.Drawing.Size(264, 29)
        Me.PlateBox.TabIndex = 9
        '
        'CoverageBox
        '
        Me.CoverageBox.Location = New System.Drawing.Point(711, 388)
        Me.CoverageBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CoverageBox.Name = "CoverageBox"
        Me.CoverageBox.Size = New System.Drawing.Size(264, 29)
        Me.CoverageBox.TabIndex = 11
        '
        'YearBox
        '
        Me.YearBox.Location = New System.Drawing.Point(711, 257)
        Me.YearBox.Margin = New System.Windows.Forms.Padding(4)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(264, 29)
        Me.YearBox.TabIndex = 101
        '
        'KMBox
        '
        Me.KMBox.Location = New System.Drawing.Point(212, 256)
        Me.KMBox.Margin = New System.Windows.Forms.Padding(2)
        Me.KMBox.MaxLength = 7
        Me.KMBox.Name = "KMBox"
        Me.KMBox.Size = New System.Drawing.Size(265, 29)
        Me.KMBox.TabIndex = 4
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(211, 212)
        Me.ModelBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelBox.MaxLength = 25
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(266, 29)
        Me.ModelBox.TabIndex = 2
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(711, 168)
        Me.MakeBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MakeBox.MaxLength = 20
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(264, 29)
        Me.MakeBox.TabIndex = 1
        '
        'makeLabel
        '
        Me.makeLabel.AutoSize = True
        Me.makeLabel.Location = New System.Drawing.Point(488, 172)
        Me.makeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.makeLabel.Name = "makeLabel"
        Me.makeLabel.Size = New System.Drawing.Size(61, 25)
        Me.makeLabel.TabIndex = 16
        Me.makeLabel.Text = "Make"
        '
        'availableLabel
        '
        Me.availableLabel.AutoSize = True
        Me.availableLabel.Location = New System.Drawing.Point(114, 395)
        Me.availableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.availableLabel.Name = "availableLabel"
        Me.availableLabel.Size = New System.Drawing.Size(92, 25)
        Me.availableLabel.TabIndex = 17
        Me.availableLabel.Text = "Available"
        '
        'plateLabel
        '
        Me.plateLabel.AutoSize = True
        Me.plateLabel.Location = New System.Drawing.Point(488, 349)
        Me.plateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.plateLabel.Name = "plateLabel"
        Me.plateLabel.Size = New System.Drawing.Size(203, 25)
        Me.plateLabel.TabIndex = 18
        Me.plateLabel.Text = "License Plate Number"
        '
        'transmissionLabel
        '
        Me.transmissionLabel.AutoSize = True
        Me.transmissionLabel.Location = New System.Drawing.Point(81, 349)
        Me.transmissionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transmissionLabel.Name = "transmissionLabel"
        Me.transmissionLabel.Size = New System.Drawing.Size(129, 25)
        Me.transmissionLabel.TabIndex = 19
        Me.transmissionLabel.Text = "Transmission"
        '
        'gvwrLabel
        '
        Me.gvwrLabel.AutoSize = True
        Me.gvwrLabel.Location = New System.Drawing.Point(488, 305)
        Me.gvwrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gvwrLabel.Name = "gvwrLabel"
        Me.gvwrLabel.Size = New System.Drawing.Size(74, 25)
        Me.gvwrLabel.TabIndex = 20
        Me.gvwrLabel.Text = "GVWR"
        '
        'seatingLabel
        '
        Me.seatingLabel.AutoSize = True
        Me.seatingLabel.Location = New System.Drawing.Point(46, 299)
        Me.seatingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.seatingLabel.Name = "seatingLabel"
        Me.seatingLabel.Size = New System.Drawing.Size(161, 25)
        Me.seatingLabel.TabIndex = 21
        Me.seatingLabel.Text = "Seating Capacity"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Location = New System.Drawing.Point(488, 262)
        Me.yearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(53, 25)
        Me.yearLabel.TabIndex = 22
        Me.yearLabel.Text = "Year"
        '
        'kmLabel
        '
        Me.kmLabel.AutoSize = True
        Me.kmLabel.Location = New System.Drawing.Point(163, 260)
        Me.kmLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.kmLabel.Name = "kmLabel"
        Me.kmLabel.Size = New System.Drawing.Size(43, 25)
        Me.kmLabel.TabIndex = 23
        Me.kmLabel.Text = "KM"
        '
        'classLabel
        '
        Me.classLabel.AutoSize = True
        Me.classLabel.Location = New System.Drawing.Point(488, 216)
        Me.classLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(132, 25)
        Me.classLabel.TabIndex = 24
        Me.classLabel.Text = "Vehicle Class"
        '
        'modelLabel
        '
        Me.modelLabel.AutoSize = True
        Me.modelLabel.Location = New System.Drawing.Point(139, 216)
        Me.modelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.modelLabel.Name = "modelLabel"
        Me.modelLabel.Size = New System.Drawing.Size(66, 25)
        Me.modelLabel.TabIndex = 25
        Me.modelLabel.Text = "Model"
        '
        'coverageLabel
        '
        Me.coverageLabel.AutoSize = True
        Me.coverageLabel.Location = New System.Drawing.Point(488, 395)
        Me.coverageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.coverageLabel.Name = "coverageLabel"
        Me.coverageLabel.Size = New System.Drawing.Size(98, 25)
        Me.coverageLabel.TabIndex = 26
        Me.coverageLabel.Text = "Coverage"
        '
        'addVehicle
        '
        Me.addVehicle.Location = New System.Drawing.Point(215, 801)
        Me.addVehicle.Margin = New System.Windows.Forms.Padding(4)
        Me.addVehicle.Name = "addVehicle"
        Me.addVehicle.Size = New System.Drawing.Size(171, 48)
        Me.addVehicle.TabIndex = 14
        Me.addVehicle.Text = "Add Vehicle"
        Me.addVehicle.UseVisualStyleBackColor = True
        '
        'wrongInfo
        '
        Me.wrongInfo.AutoSize = True
        Me.wrongInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wrongInfo.ForeColor = System.Drawing.Color.Red
        Me.wrongInfo.Location = New System.Drawing.Point(592, 810)
        Me.wrongInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wrongInfo.Name = "wrongInfo"
        Me.wrongInfo.Size = New System.Drawing.Size(231, 29)
        Me.wrongInfo.TabIndex = 28
        Me.wrongInfo.Text = "Incorrect Information"
        Me.wrongInfo.Visible = False
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(414, 801)
        Me.GoBack.Margin = New System.Windows.Forms.Padding(4)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(171, 48)
        Me.GoBack.TabIndex = 16
        Me.GoBack.Text = "Back"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(17, 801)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(171, 48)
        Me.HelpButton.TabIndex = 15
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ClassCB
        '
        Me.ClassCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassCB.FormattingEnabled = True
        Me.ClassCB.Location = New System.Drawing.Point(711, 210)
        Me.ClassCB.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassCB.Name = "ClassCB"
        Me.ClassCB.Size = New System.Drawing.Size(264, 32)
        Me.ClassCB.TabIndex = 3
        '
        'TransCB
        '
        Me.TransCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransCB.FormattingEnabled = True
        Me.TransCB.Location = New System.Drawing.Point(213, 343)
        Me.TransCB.Margin = New System.Windows.Forms.Padding(4)
        Me.TransCB.Name = "TransCB"
        Me.TransCB.Size = New System.Drawing.Size(264, 32)
        Me.TransCB.TabIndex = 8
        '
        'AvailCB
        '
        Me.AvailCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AvailCB.FormattingEnabled = True
        Me.AvailCB.Location = New System.Drawing.Point(213, 390)
        Me.AvailCB.Margin = New System.Windows.Forms.Padding(4)
        Me.AvailCB.Name = "AvailCB"
        Me.AvailCB.Size = New System.Drawing.Size(264, 32)
        Me.AvailCB.TabIndex = 10
        '
        'branchLabel
        '
        Me.branchLabel.AutoSize = True
        Me.branchLabel.Location = New System.Drawing.Point(55, 441)
        Me.branchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.branchLabel.Name = "branchLabel"
        Me.branchLabel.Size = New System.Drawing.Size(152, 25)
        Me.branchLabel.TabIndex = 31
        Me.branchLabel.Text = "Branch Address"
        '
        'BranchCB
        '
        Me.BranchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchCB.FormattingEnabled = True
        Me.BranchCB.Location = New System.Drawing.Point(213, 436)
        Me.BranchCB.Margin = New System.Windows.Forms.Padding(4)
        Me.BranchCB.Name = "BranchCB"
        Me.BranchCB.Size = New System.Drawing.Size(264, 32)
        Me.BranchCB.TabIndex = 12
        '
        'ImageButton
        '
        Me.ImageButton.Location = New System.Drawing.Point(777, 434)
        Me.ImageButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(138, 42)
        Me.ImageButton.TabIndex = 13
        Me.ImageButton.Text = "Select"
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(490, 441)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 25)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Image"
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Location = New System.Drawing.Point(491, 497)
        Me.ImageLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(0, 25)
        Me.ImageLabel.TabIndex = 34
        '
        'VehiclePicture
        '
        Me.VehiclePicture.Location = New System.Drawing.Point(51, 497)
        Me.VehiclePicture.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.VehiclePicture.Name = "VehiclePicture"
        Me.VehiclePicture.Size = New System.Drawing.Size(429, 286)
        Me.VehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VehiclePicture.TabIndex = 100
        Me.VehiclePicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'seatsCB
        '
        Me.seatsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seatsCB.FormattingEnabled = True
        Me.seatsCB.Location = New System.Drawing.Point(213, 297)
        Me.seatsCB.Name = "seatsCB"
        Me.seatsCB.Size = New System.Drawing.Size(264, 32)
        Me.seatsCB.TabIndex = 6
        '
        'AddNewVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.seatsCB)
        Me.Controls.Add(Me.VehiclePicture)
        Me.Controls.Add(Me.ImageLabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ImageButton)
        Me.Controls.Add(Me.BranchCB)
        Me.Controls.Add(Me.branchLabel)
        Me.Controls.Add(Me.AvailCB)
        Me.Controls.Add(Me.TransCB)
        Me.Controls.Add(Me.ClassCB)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.wrongInfo)
        Me.Controls.Add(Me.addVehicle)
        Me.Controls.Add(Me.coverageLabel)
        Me.Controls.Add(Me.modelLabel)
        Me.Controls.Add(Me.classLabel)
        Me.Controls.Add(Me.kmLabel)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.seatingLabel)
        Me.Controls.Add(Me.gvwrLabel)
        Me.Controls.Add(Me.transmissionLabel)
        Me.Controls.Add(Me.plateLabel)
        Me.Controls.Add(Me.availableLabel)
        Me.Controls.Add(Me.makeLabel)
        Me.Controls.Add(Me.MakeBox)
        Me.Controls.Add(Me.ModelBox)
        Me.Controls.Add(Me.KMBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.CoverageBox)
        Me.Controls.Add(Me.PlateBox)
        Me.Controls.Add(Me.GVWRBox)
        Me.Controls.Add(Me.VINbox)
        Me.Controls.Add(Me.vinLabel)
        Me.Controls.Add(Me.enterVehicleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddNewVehicle"
        Me.Text = "AddNewVehicle"
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enterVehicleLabel As Label
    Friend WithEvents vinLabel As Label
    Friend WithEvents VINbox As TextBox
    Friend WithEvents GVWRBox As TextBox
    Friend WithEvents PlateBox As TextBox
    Friend WithEvents CoverageBox As TextBox
    Friend WithEvents YearBox As TextBox
    Friend WithEvents KMBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents makeLabel As Label
    Friend WithEvents availableLabel As Label
    Friend WithEvents plateLabel As Label
    Friend WithEvents transmissionLabel As Label
    Friend WithEvents gvwrLabel As Label
    Friend WithEvents seatingLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents kmLabel As Label
    Friend WithEvents classLabel As Label
    Friend WithEvents modelLabel As Label
    Friend WithEvents coverageLabel As Label
    Friend WithEvents addVehicle As Button
    Friend WithEvents wrongInfo As Label
    Friend WithEvents GoBack As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents ClassCB As ComboBox
    Friend WithEvents TransCB As ComboBox
    Friend WithEvents AvailCB As ComboBox
    Friend WithEvents branchLabel As Label
    Friend WithEvents BranchCB As ComboBox
    Friend WithEvents ImageButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents ImageLabel As Label
    Friend WithEvents VehiclePicture As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seatsCB As ComboBox
End Class
