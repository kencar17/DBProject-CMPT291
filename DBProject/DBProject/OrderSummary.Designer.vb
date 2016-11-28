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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Firstname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.cityProv = New System.Windows.Forms.Label()
        Me.countryPostal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pickUp = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Fname = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.finishButton = New System.Windows.Forms.Button()
        Me.vehicle = New System.Windows.Forms.DataGridView()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.branchConPos = New System.Windows.Forms.Label()
        Me.branchCityPro = New System.Windows.Forms.Label()
        Me.branchAdd = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.branchEmail = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.branchPhone = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.branchFax = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.branchMan = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.daysLabel = New System.Windows.Forms.Label()
        CType(Me.vehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Information:"
        '
        'Firstname
        '
        Me.Firstname.AutoSize = True
        Me.Firstname.Location = New System.Drawing.Point(42, 47)
        Me.Firstname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(55, 13)
        Me.Firstname.TabIndex = 1
        Me.Firstname.Text = "Firstname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lastname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email:"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(299, 47)
        Me.address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(44, 13)
        Me.address.TabIndex = 5
        Me.address.Text = "address"
        '
        'cityProv
        '
        Me.cityProv.AutoSize = True
        Me.cityProv.Location = New System.Drawing.Point(299, 68)
        Me.cityProv.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cityProv.Name = "cityProv"
        Me.cityProv.Size = New System.Drawing.Size(71, 13)
        Me.cityProv.TabIndex = 6
        Me.cityProv.Text = "city, Province"
        '
        'countryPostal
        '
        Me.countryPostal.AutoSize = True
        Me.countryPostal.Location = New System.Drawing.Point(299, 90)
        Me.countryPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.countryPostal.Name = "countryPostal"
        Me.countryPostal.Size = New System.Drawing.Size(106, 13)
        Me.countryPostal.TabIndex = 7
        Me.countryPostal.Text = "Country, Postal Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 177)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Dates:"
        '
        'pickUp
        '
        Me.pickUp.AutoSize = True
        Me.pickUp.Location = New System.Drawing.Point(429, 177)
        Me.pickUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pickUp.Name = "pickUp"
        Me.pickUp.Size = New System.Drawing.Size(30, 13)
        Me.pickUp.TabIndex = 9
        Me.pickUp.Text = "From"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 281)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Vehicle Information:"
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Location = New System.Drawing.Point(103, 47)
        Me.Fname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(45, 13)
        Me.Fname.TabIndex = 26
        Me.Fname.Text = "Label26"
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(103, 68)
        Me.Lname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(45, 13)
        Me.Lname.TabIndex = 27
        Me.Lname.Text = "Label27"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(103, 90)
        Me.email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(45, 13)
        Me.email.TabIndex = 28
        Me.email.Text = "Label28"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Location = New System.Drawing.Point(103, 113)
        Me.age.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(45, 13)
        Me.age.TabIndex = 29
        Me.age.Text = "Label29"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(28, 421)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(51, 22)
        Me.backButton.TabIndex = 32
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'finishButton
        '
        Me.finishButton.Location = New System.Drawing.Point(766, 421)
        Me.finishButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.finishButton.Name = "finishButton"
        Me.finishButton.Size = New System.Drawing.Size(51, 22)
        Me.finishButton.TabIndex = 33
        Me.finishButton.Text = "Finish"
        Me.finishButton.UseVisualStyleBackColor = True
        '
        'vehicle
        '
        Me.vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicle.Location = New System.Drawing.Point(28, 310)
        Me.vehicle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.RowTemplate.Height = 31
        Me.vehicle.Size = New System.Drawing.Size(789, 88)
        Me.vehicle.TabIndex = 34
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(106, 421)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(51, 22)
        Me.helpButton.TabIndex = 35
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 151)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Branch Information:"
        '
        'branchConPos
        '
        Me.branchConPos.AutoSize = True
        Me.branchConPos.Location = New System.Drawing.Point(42, 241)
        Me.branchConPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchConPos.Name = "branchConPos"
        Me.branchConPos.Size = New System.Drawing.Size(106, 13)
        Me.branchConPos.TabIndex = 39
        Me.branchConPos.Text = "Country, Postal Code"
        '
        'branchCityPro
        '
        Me.branchCityPro.AutoSize = True
        Me.branchCityPro.Location = New System.Drawing.Point(42, 221)
        Me.branchCityPro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchCityPro.Name = "branchCityPro"
        Me.branchCityPro.Size = New System.Drawing.Size(71, 13)
        Me.branchCityPro.TabIndex = 38
        Me.branchCityPro.Text = "city, Province"
        '
        'branchAdd
        '
        Me.branchAdd.AutoSize = True
        Me.branchAdd.Location = New System.Drawing.Point(42, 199)
        Me.branchAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchAdd.Name = "branchAdd"
        Me.branchAdd.Size = New System.Drawing.Size(44, 13)
        Me.branchAdd.TabIndex = 37
        Me.branchAdd.Text = "address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Email:"
        '
        'branchEmail
        '
        Me.branchEmail.AutoSize = True
        Me.branchEmail.Location = New System.Drawing.Point(221, 199)
        Me.branchEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchEmail.Name = "branchEmail"
        Me.branchEmail.Size = New System.Drawing.Size(39, 13)
        Me.branchEmail.TabIndex = 41
        Me.branchEmail.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 221)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Phone:"
        '
        'branchPhone
        '
        Me.branchPhone.AutoSize = True
        Me.branchPhone.Location = New System.Drawing.Point(221, 221)
        Me.branchPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchPhone.Name = "branchPhone"
        Me.branchPhone.Size = New System.Drawing.Size(39, 13)
        Me.branchPhone.TabIndex = 43
        Me.branchPhone.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 241)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Fax:"
        '
        'branchFax
        '
        Me.branchFax.AutoSize = True
        Me.branchFax.Location = New System.Drawing.Point(221, 241)
        Me.branchFax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchFax.Name = "branchFax"
        Me.branchFax.Size = New System.Drawing.Size(45, 13)
        Me.branchFax.TabIndex = 45
        Me.branchFax.Text = "Label10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 177)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Manager:"
        '
        'branchMan
        '
        Me.branchMan.AutoSize = True
        Me.branchMan.Location = New System.Drawing.Point(103, 177)
        Me.branchMan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.branchMan.Name = "branchMan"
        Me.branchMan.Size = New System.Drawing.Size(45, 13)
        Me.branchMan.TabIndex = 47
        Me.branchMan.Text = "Label12"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(370, 151)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Rate Information:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(381, 199)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Days:"
        '
        'daysLabel
        '
        Me.daysLabel.AutoSize = True
        Me.daysLabel.Location = New System.Drawing.Point(430, 199)
        Me.daysLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.daysLabel.Name = "daysLabel"
        Me.daysLabel.Size = New System.Drawing.Size(29, 13)
        Me.daysLabel.TabIndex = 50
        Me.daysLabel.Text = "days"
        '
        'OrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 480)
        Me.Controls.Add(Me.daysLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.branchMan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.branchFax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.branchPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.branchEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.branchConPos)
        Me.Controls.Add(Me.branchCityPro)
        Me.Controls.Add(Me.branchAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.finishButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pickUp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.countryPostal)
        Me.Controls.Add(Me.cityProv)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "OrderSummary"
        Me.Text = "OrderSummary"
        CType(Me.vehicle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Firstname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents address As Label
    Friend WithEvents cityProv As Label
    Friend WithEvents countryPostal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pickUp As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Fname As Label
    Friend WithEvents Lname As Label
    Friend WithEvents email As Label
    Friend WithEvents age As Label
    Friend WithEvents backButton As Button
    Friend WithEvents finishButton As Button
    Friend WithEvents vehicle As DataGridView
    Friend WithEvents helpButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents branchConPos As Label
    Friend WithEvents branchCityPro As Label
    Friend WithEvents branchAdd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents branchEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents branchPhone As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents branchFax As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents branchMan As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents daysLabel As Label
End Class
