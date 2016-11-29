<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateVehicle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.KmBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.SeatBox = New System.Windows.Forms.TextBox()
        Me.GVWRBox = New System.Windows.Forms.TextBox()
        Me.PlateBox = New System.Windows.Forms.TextBox()
        Me.CoverageBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BranchCB = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TransCB = New System.Windows.Forms.ComboBox()
        Me.ClassCB = New System.Windows.Forms.ComboBox()
        Me.AvailCB = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.PicturePath = New System.Windows.Forms.Label()
        Me.VinBox = New System.Windows.Forms.ComboBox()
        Me.VehiclePicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the VIN of the vehicle you want to update:"
        '
        'MakeBox
        '
        Me.MakeBox.Enabled = False
        Me.MakeBox.Location = New System.Drawing.Point(86, 132)
        Me.MakeBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MakeBox.MaxLength = 20
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(101, 20)
        Me.MakeBox.TabIndex = 3
        '
        'ModelBox
        '
        Me.ModelBox.Enabled = False
        Me.ModelBox.Location = New System.Drawing.Point(276, 132)
        Me.ModelBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ModelBox.MaxLength = 25
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(101, 20)
        Me.ModelBox.TabIndex = 4
        '
        'KmBox
        '
        Me.KmBox.Enabled = False
        Me.KmBox.Location = New System.Drawing.Point(276, 156)
        Me.KmBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.KmBox.MaxLength = 7
        Me.KmBox.Name = "KmBox"
        Me.KmBox.Size = New System.Drawing.Size(101, 20)
        Me.KmBox.TabIndex = 6
        '
        'YearBox
        '
        Me.YearBox.Enabled = False
        Me.YearBox.Location = New System.Drawing.Point(86, 181)
        Me.YearBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.YearBox.MaxLength = 4
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(101, 20)
        Me.YearBox.TabIndex = 7
        '
        'SeatBox
        '
        Me.SeatBox.Enabled = False
        Me.SeatBox.Location = New System.Drawing.Point(276, 181)
        Me.SeatBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SeatBox.MaxLength = 2
        Me.SeatBox.Name = "SeatBox"
        Me.SeatBox.Size = New System.Drawing.Size(101, 20)
        Me.SeatBox.TabIndex = 8
        '
        'GVWRBox
        '
        Me.GVWRBox.Enabled = False
        Me.GVWRBox.Location = New System.Drawing.Point(86, 205)
        Me.GVWRBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GVWRBox.MaxLength = 7
        Me.GVWRBox.Name = "GVWRBox"
        Me.GVWRBox.Size = New System.Drawing.Size(101, 20)
        Me.GVWRBox.TabIndex = 9
        '
        'PlateBox
        '
        Me.PlateBox.Enabled = False
        Me.PlateBox.Location = New System.Drawing.Point(86, 229)
        Me.PlateBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlateBox.MaxLength = 10
        Me.PlateBox.Name = "PlateBox"
        Me.PlateBox.Size = New System.Drawing.Size(101, 20)
        Me.PlateBox.TabIndex = 11
        '
        'CoverageBox
        '
        Me.CoverageBox.Enabled = False
        Me.CoverageBox.Location = New System.Drawing.Point(86, 253)
        Me.CoverageBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CoverageBox.MaxLength = 7
        Me.CoverageBox.Name = "CoverageBox"
        Me.CoverageBox.Size = New System.Drawing.Size(101, 20)
        Me.CoverageBox.TabIndex = 13
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(276, 323)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(101, 30)
        Me.SubmitButton.TabIndex = 16
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(9, 326)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(54, 25)
        Me.BackButton.TabIndex = 17
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(86, 326)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(54, 25)
        Me.HelpButton.TabIndex = 18
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(11, 353)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(102, 13)
        Me.ErrorLabel.TabIndex = 19
        Me.ErrorLabel.Text = "Incorrect Arguments"
        Me.ErrorLabel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Coverage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Plate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "GVWR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Class"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 232)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Availablity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(191, 210)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Transmission"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 184)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Seats"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(191, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "KM"
        '
        'BranchCB
        '
        Me.BranchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchCB.Enabled = False
        Me.BranchCB.FormattingEnabled = True
        Me.BranchCB.Location = New System.Drawing.Point(276, 254)
        Me.BranchCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BranchCB.Name = "BranchCB"
        Me.BranchCB.Size = New System.Drawing.Size(101, 21)
        Me.BranchCB.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(191, 257)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Branch Address"
        '
        'TransCB
        '
        Me.TransCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransCB.Enabled = False
        Me.TransCB.FormattingEnabled = True
        Me.TransCB.Location = New System.Drawing.Point(276, 205)
        Me.TransCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TransCB.Name = "TransCB"
        Me.TransCB.Size = New System.Drawing.Size(101, 21)
        Me.TransCB.TabIndex = 10
        '
        'ClassCB
        '
        Me.ClassCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassCB.Enabled = False
        Me.ClassCB.FormattingEnabled = True
        Me.ClassCB.Location = New System.Drawing.Point(86, 156)
        Me.ClassCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClassCB.Name = "ClassCB"
        Me.ClassCB.Size = New System.Drawing.Size(101, 21)
        Me.ClassCB.TabIndex = 5
        '
        'AvailCB
        '
        Me.AvailCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AvailCB.Enabled = False
        Me.AvailCB.FormattingEnabled = True
        Me.AvailCB.Location = New System.Drawing.Point(276, 229)
        Me.AvailCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AvailCB.Name = "AvailCB"
        Me.AvailCB.Size = New System.Drawing.Size(101, 21)
        Me.AvailCB.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 283)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Picture"
        '
        'ImageButton
        '
        Me.ImageButton.Enabled = False
        Me.ImageButton.Location = New System.Drawing.Point(86, 278)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(75, 23)
        Me.ImageButton.TabIndex = 35
        Me.ImageButton.Text = "Select"
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'PicturePath
        '
        Me.PicturePath.AutoSize = True
        Me.PicturePath.Location = New System.Drawing.Point(191, 283)
        Me.PicturePath.Name = "PicturePath"
        Me.PicturePath.Size = New System.Drawing.Size(0, 13)
        Me.PicturePath.TabIndex = 36
        '
        'VinBox
        '
        Me.VinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VinBox.FormattingEnabled = True
        Me.VinBox.Location = New System.Drawing.Point(9, 75)
        Me.VinBox.Name = "VinBox"
        Me.VinBox.Size = New System.Drawing.Size(237, 21)
        Me.VinBox.TabIndex = 37
        '
        'VehiclePicture
        '
        Me.VehiclePicture.Location = New System.Drawing.Point(427, 120)
        Me.VehiclePicture.Name = "VehiclePicture"
        Me.VehiclePicture.Size = New System.Drawing.Size(234, 155)
        Me.VehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VehiclePicture.TabIndex = 101
        Me.VehiclePicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 533)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'UpdateVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 532)
        Me.Controls.Add(Me.VehiclePicture)
        Me.Controls.Add(Me.VinBox)
        Me.Controls.Add(Me.PicturePath)
        Me.Controls.Add(Me.ImageButton)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.AvailCB)
        Me.Controls.Add(Me.ClassCB)
        Me.Controls.Add(Me.TransCB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BranchCB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.CoverageBox)
        Me.Controls.Add(Me.PlateBox)
        Me.Controls.Add(Me.GVWRBox)
        Me.Controls.Add(Me.SeatBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.KmBox)
        Me.Controls.Add(Me.ModelBox)
        Me.Controls.Add(Me.MakeBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UpdateVehicle"
        Me.Text = "UpdateVehicle"
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents KmBox As TextBox
    Friend WithEvents YearBox As TextBox
    Friend WithEvents SeatBox As TextBox
    Friend WithEvents GVWRBox As TextBox
    Friend WithEvents PlateBox As TextBox
    Friend WithEvents CoverageBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BranchCB As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TransCB As ComboBox
    Friend WithEvents ClassCB As ComboBox
    Friend WithEvents AvailCB As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ImageButton As Button
    Friend WithEvents PicturePath As Label
    Friend WithEvents VinBox As ComboBox
    Friend WithEvents VehiclePicture As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
