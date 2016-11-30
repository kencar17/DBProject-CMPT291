<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSummary
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
        Me.customerLabel = New System.Windows.Forms.Label()
        Me.FnameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.LnameLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.cityProv = New System.Windows.Forms.Label()
        Me.countryPostal = New System.Windows.Forms.Label()
        Me.rateDatesLabel = New System.Windows.Forms.Label()
        Me.pickUp = New System.Windows.Forms.Label()
        Me.vehicleLabel = New System.Windows.Forms.Label()
        Me.Fname = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.finishButton = New System.Windows.Forms.Button()
        Me.vehicle = New System.Windows.Forms.DataGridView()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.branchLabel = New System.Windows.Forms.Label()
        Me.branchConPos = New System.Windows.Forms.Label()
        Me.branchCityPro = New System.Windows.Forms.Label()
        Me.branchAdd = New System.Windows.Forms.Label()
        Me.BemailLabel = New System.Windows.Forms.Label()
        Me.branchEmail = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.branchPhone = New System.Windows.Forms.Label()
        Me.faxLabel = New System.Windows.Forms.Label()
        Me.branchFax = New System.Windows.Forms.Label()
        Me.managerLabel = New System.Windows.Forms.Label()
        Me.branchMan = New System.Windows.Forms.Label()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.rateDaysLabel = New System.Windows.Forms.Label()
        Me.daysLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.costlabel = New System.Windows.Forms.Label()
        Me.goldLabel = New System.Windows.Forms.Label()
        CType(Me.vehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customerLabel
        '
        Me.customerLabel.AutoSize = True
        Me.customerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerLabel.Location = New System.Drawing.Point(24, 74)
        Me.customerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.customerLabel.Name = "customerLabel"
        Me.customerLabel.Size = New System.Drawing.Size(130, 13)
        Me.customerLabel.TabIndex = 0
        Me.customerLabel.Text = "Customer Information:"
        '
        'FnameLabel
        '
        Me.FnameLabel.AutoSize = True
        Me.FnameLabel.Location = New System.Drawing.Point(40, 101)
        Me.FnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FnameLabel.Name = "FnameLabel"
        Me.FnameLabel.Size = New System.Drawing.Size(55, 13)
        Me.FnameLabel.TabIndex = 1
        Me.FnameLabel.Text = "Firstname:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Location = New System.Drawing.Point(40, 167)
        Me.ageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(29, 13)
        Me.ageLabel.TabIndex = 2
        Me.ageLabel.Text = "Age:"
        '
        'LnameLabel
        '
        Me.LnameLabel.AutoSize = True
        Me.LnameLabel.Location = New System.Drawing.Point(40, 122)
        Me.LnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LnameLabel.Name = "LnameLabel"
        Me.LnameLabel.Size = New System.Drawing.Size(56, 13)
        Me.LnameLabel.TabIndex = 3
        Me.LnameLabel.Text = "Lastname:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(40, 144)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(35, 13)
        Me.emailLabel.TabIndex = 4
        Me.emailLabel.Text = "Email:"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(298, 101)
        Me.address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(44, 13)
        Me.address.TabIndex = 5
        Me.address.Text = "address"
        '
        'cityProv
        '
        Me.cityProv.AutoSize = True
        Me.cityProv.Location = New System.Drawing.Point(298, 122)
        Me.cityProv.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cityProv.Name = "cityProv"
        Me.cityProv.Size = New System.Drawing.Size(71, 13)
        Me.cityProv.TabIndex = 6
        Me.cityProv.Text = "city, Province"
        '
        'countryPostal
        '
        Me.countryPostal.AutoSize = True
        Me.countryPostal.Location = New System.Drawing.Point(298, 144)
        Me.countryPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.countryPostal.Name = "countryPostal"
        Me.countryPostal.Size = New System.Drawing.Size(106, 13)
        Me.countryPostal.TabIndex = 7
        Me.countryPostal.Text = "Country, Postal Code"
        '
        'rateDatesLabel
        '
        Me.rateDatesLabel.AutoSize = True
        Me.rateDatesLabel.Location = New System.Drawing.Point(380, 231)
        Me.rateDatesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateDatesLabel.Name = "rateDatesLabel"
        Me.rateDatesLabel.Size = New System.Drawing.Size(38, 13)
        Me.rateDatesLabel.TabIndex = 8
        Me.rateDatesLabel.Text = "Dates:"
        '
        'pickUp
        '
        Me.pickUp.AutoSize = True
        Me.pickUp.Location = New System.Drawing.Point(428, 231)
        Me.pickUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pickUp.Name = "pickUp"
        Me.pickUp.Size = New System.Drawing.Size(30, 13)
        Me.pickUp.TabIndex = 9
        Me.pickUp.Text = "From"
        '
        'vehicleLabel
        '
        Me.vehicleLabel.AutoSize = True
        Me.vehicleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleLabel.Location = New System.Drawing.Point(25, 324)
        Me.vehicleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.vehicleLabel.Name = "vehicleLabel"
        Me.vehicleLabel.Size = New System.Drawing.Size(120, 13)
        Me.vehicleLabel.TabIndex = 11
        Me.vehicleLabel.Text = "Vehicle Information:"
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Location = New System.Drawing.Point(102, 101)
        Me.Fname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(45, 13)
        Me.Fname.TabIndex = 26
        Me.Fname.Text = "Label26"
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(102, 122)
        Me.Lname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(45, 13)
        Me.Lname.TabIndex = 27
        Me.Lname.Text = "Label27"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(102, 144)
        Me.email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(45, 13)
        Me.email.TabIndex = 28
        Me.email.Text = "Label28"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Location = New System.Drawing.Point(102, 167)
        Me.age.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(45, 13)
        Me.age.TabIndex = 29
        Me.age.Text = "Label29"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(28, 453)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(52, 22)
        Me.backButton.TabIndex = 32
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'finishButton
        '
        Me.finishButton.Location = New System.Drawing.Point(659, 453)
        Me.finishButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.finishButton.Name = "finishButton"
        Me.finishButton.Size = New System.Drawing.Size(52, 22)
        Me.finishButton.TabIndex = 33
        Me.finishButton.Text = "Finish"
        Me.finishButton.UseVisualStyleBackColor = True
        '
        'vehicle
        '
        Me.vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicle.Location = New System.Drawing.Point(28, 351)
        Me.vehicle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.RowTemplate.Height = 31
        Me.vehicle.Size = New System.Drawing.Size(682, 88)
        Me.vehicle.TabIndex = 34
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(106, 453)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(52, 22)
        Me.helpButton.TabIndex = 35
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'branchLabel
        '
        Me.branchLabel.AutoSize = True
        Me.branchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branchLabel.Location = New System.Drawing.Point(24, 205)
        Me.branchLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchLabel.Name = "branchLabel"
        Me.branchLabel.Size = New System.Drawing.Size(118, 13)
        Me.branchLabel.TabIndex = 36
        Me.branchLabel.Text = "Branch Information:"
        '
        'branchConPos
        '
        Me.branchConPos.AutoSize = True
        Me.branchConPos.Location = New System.Drawing.Point(40, 295)
        Me.branchConPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchConPos.Name = "branchConPos"
        Me.branchConPos.Size = New System.Drawing.Size(106, 13)
        Me.branchConPos.TabIndex = 39
        Me.branchConPos.Text = "Country, Postal Code"
        '
        'branchCityPro
        '
        Me.branchCityPro.AutoSize = True
        Me.branchCityPro.Location = New System.Drawing.Point(40, 275)
        Me.branchCityPro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchCityPro.Name = "branchCityPro"
        Me.branchCityPro.Size = New System.Drawing.Size(71, 13)
        Me.branchCityPro.TabIndex = 38
        Me.branchCityPro.Text = "city, Province"
        '
        'branchAdd
        '
        Me.branchAdd.AutoSize = True
        Me.branchAdd.Location = New System.Drawing.Point(40, 253)
        Me.branchAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchAdd.Name = "branchAdd"
        Me.branchAdd.Size = New System.Drawing.Size(44, 13)
        Me.branchAdd.TabIndex = 37
        Me.branchAdd.Text = "address"
        '
        'BemailLabel
        '
        Me.BemailLabel.AutoSize = True
        Me.BemailLabel.Location = New System.Drawing.Point(166, 253)
        Me.BemailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BemailLabel.Name = "BemailLabel"
        Me.BemailLabel.Size = New System.Drawing.Size(35, 13)
        Me.BemailLabel.TabIndex = 40
        Me.BemailLabel.Text = "Email:"
        '
        'branchEmail
        '
        Me.branchEmail.AutoSize = True
        Me.branchEmail.Location = New System.Drawing.Point(220, 253)
        Me.branchEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchEmail.Name = "branchEmail"
        Me.branchEmail.Size = New System.Drawing.Size(39, 13)
        Me.branchEmail.TabIndex = 41
        Me.branchEmail.Text = "Label7"
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(166, 275)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(41, 13)
        Me.phoneLabel.TabIndex = 42
        Me.phoneLabel.Text = "Phone:"
        '
        'branchPhone
        '
        Me.branchPhone.AutoSize = True
        Me.branchPhone.Location = New System.Drawing.Point(220, 275)
        Me.branchPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchPhone.Name = "branchPhone"
        Me.branchPhone.Size = New System.Drawing.Size(39, 13)
        Me.branchPhone.TabIndex = 43
        Me.branchPhone.Text = "Label9"
        '
        'faxLabel
        '
        Me.faxLabel.AutoSize = True
        Me.faxLabel.Location = New System.Drawing.Point(166, 295)
        Me.faxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.faxLabel.Name = "faxLabel"
        Me.faxLabel.Size = New System.Drawing.Size(27, 13)
        Me.faxLabel.TabIndex = 44
        Me.faxLabel.Text = "Fax:"
        '
        'branchFax
        '
        Me.branchFax.AutoSize = True
        Me.branchFax.Location = New System.Drawing.Point(220, 295)
        Me.branchFax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchFax.Name = "branchFax"
        Me.branchFax.Size = New System.Drawing.Size(45, 13)
        Me.branchFax.TabIndex = 45
        Me.branchFax.Text = "Label10"
        '
        'managerLabel
        '
        Me.managerLabel.AutoSize = True
        Me.managerLabel.Location = New System.Drawing.Point(40, 231)
        Me.managerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.managerLabel.Name = "managerLabel"
        Me.managerLabel.Size = New System.Drawing.Size(52, 13)
        Me.managerLabel.TabIndex = 46
        Me.managerLabel.Text = "Manager:"
        '
        'branchMan
        '
        Me.branchMan.AutoSize = True
        Me.branchMan.Location = New System.Drawing.Point(102, 231)
        Me.branchMan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchMan.Name = "branchMan"
        Me.branchMan.Size = New System.Drawing.Size(45, 13)
        Me.branchMan.TabIndex = 47
        Me.branchMan.Text = "Label12"
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateLabel.Location = New System.Drawing.Point(368, 205)
        Me.rateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(105, 13)
        Me.rateLabel.TabIndex = 48
        Me.rateLabel.Text = "Rate Information:"
        '
        'rateDaysLabel
        '
        Me.rateDaysLabel.AutoSize = True
        Me.rateDaysLabel.Location = New System.Drawing.Point(380, 253)
        Me.rateDaysLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateDaysLabel.Name = "rateDaysLabel"
        Me.rateDaysLabel.Size = New System.Drawing.Size(34, 13)
        Me.rateDaysLabel.TabIndex = 49
        Me.rateDaysLabel.Text = "Days:"
        '
        'daysLabel
        '
        Me.daysLabel.AutoSize = True
        Me.daysLabel.Location = New System.Drawing.Point(428, 253)
        Me.daysLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.daysLabel.Name = "daysLabel"
        Me.daysLabel.Size = New System.Drawing.Size(29, 13)
        Me.daysLabel.TabIndex = 50
        Me.daysLabel.Text = "days"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 533)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(380, 275)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Cost:"
        '
        'costlabel
        '
        Me.costlabel.AutoSize = True
        Me.costlabel.Location = New System.Drawing.Point(406, 275)
        Me.costlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.costlabel.Name = "costlabel"
        Me.costlabel.Size = New System.Drawing.Size(45, 13)
        Me.costlabel.TabIndex = 52
        Me.costlabel.Text = "Label15"
        '
        'goldLabel
        '
        Me.goldLabel.AutoSize = True
        Me.goldLabel.ForeColor = System.Drawing.Color.Olive
        Me.goldLabel.Location = New System.Drawing.Point(298, 325)
        Me.goldLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.goldLabel.Name = "goldLabel"
        Me.goldLabel.Size = New System.Drawing.Size(60, 13)
        Me.goldLabel.TabIndex = 53
        Me.goldLabel.Text = "GoldCheck"
        Me.goldLabel.Visible = False
        '
        'OrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 532)
        Me.Controls.Add(Me.goldLabel)
        Me.Controls.Add(Me.costlabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.daysLabel)
        Me.Controls.Add(Me.rateDaysLabel)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.branchMan)
        Me.Controls.Add(Me.managerLabel)
        Me.Controls.Add(Me.branchFax)
        Me.Controls.Add(Me.faxLabel)
        Me.Controls.Add(Me.branchPhone)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.branchEmail)
        Me.Controls.Add(Me.BemailLabel)
        Me.Controls.Add(Me.branchConPos)
        Me.Controls.Add(Me.branchCityPro)
        Me.Controls.Add(Me.branchAdd)
        Me.Controls.Add(Me.branchLabel)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.finishButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.vehicleLabel)
        Me.Controls.Add(Me.pickUp)
        Me.Controls.Add(Me.rateDatesLabel)
        Me.Controls.Add(Me.countryPostal)
        Me.Controls.Add(Me.cityProv)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.LnameLabel)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.FnameLabel)
        Me.Controls.Add(Me.customerLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "OrderSummary"
        Me.Text = "OrderSummary"
        CType(Me.vehicle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerLabel As Label
    Friend WithEvents FnameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents LnameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents address As Label
    Friend WithEvents cityProv As Label
    Friend WithEvents countryPostal As Label
    Friend WithEvents rateDatesLabel As Label
    Friend WithEvents pickUp As Label
    Friend WithEvents vehicleLabel As Label
    Friend WithEvents Fname As Label
    Friend WithEvents Lname As Label
    Friend WithEvents email As Label
    Friend WithEvents age As Label
    Friend WithEvents backButton As Button
    Friend WithEvents finishButton As Button
    Friend WithEvents vehicle As DataGridView
    Friend WithEvents helpButton As Button
    Friend WithEvents branchLabel As Label
    Friend WithEvents branchConPos As Label
    Friend WithEvents branchCityPro As Label
    Friend WithEvents branchAdd As Label
    Friend WithEvents BemailLabel As Label
    Friend WithEvents branchEmail As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents branchPhone As Label
    Friend WithEvents faxLabel As Label
    Friend WithEvents branchFax As Label
    Friend WithEvents managerLabel As Label
    Friend WithEvents branchMan As Label
    Friend WithEvents rateLabel As Label
    Friend WithEvents rateDaysLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents daysLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents costlabel As Label
    Friend WithEvents goldLabel As Label
End Class
