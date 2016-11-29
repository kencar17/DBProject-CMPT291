<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createOrder
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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.CFnameLabel = New System.Windows.Forms.Label()
        Me.CFnameTextField = New System.Windows.Forms.TextBox()
        Me.CLnameLabel = New System.Windows.Forms.Label()
        Me.customerLabel = New System.Windows.Forms.Label()
        Me.CLnameTextField = New System.Windows.Forms.TextBox()
        Me.CemailLabel = New System.Windows.Forms.Label()
        Me.CEmailTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.CAgeTextBox = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.CCountryTextField = New System.Windows.Forms.TextBox()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.CAddressTextField = New System.Windows.Forms.TextBox()
        Me.provinceLabel = New System.Windows.Forms.Label()
        Me.CCityTextField = New System.Windows.Forms.TextBox()
        Me.countryLabel = New System.Windows.Forms.Label()
        Me.CProvinceTextField = New System.Windows.Forms.TextBox()
        Me.postalLabel = New System.Windows.Forms.Label()
        Me.CPostalTextField = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.cardLabel = New System.Windows.Forms.Label()
        Me.cardNumberLabel = New System.Windows.Forms.Label()
        Me.cvvLabel = New System.Windows.Forms.Label()
        Me.creditCardTextbox = New System.Windows.Forms.TextBox()
        Me.cvvTextbox = New System.Windows.Forms.TextBox()
        Me.existingLabel = New System.Windows.Forms.Label()
        Me.lastname1Label = New System.Windows.Forms.Label()
        Me.existingTextfield = New System.Windows.Forms.TextBox()
        Me.existingCustomers = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(923, 833)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(128, 41)
        Me.nextButton.TabIndex = 0
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'CFnameLabel
        '
        Me.CFnameLabel.AutoSize = True
        Me.CFnameLabel.Location = New System.Drawing.Point(275, 449)
        Me.CFnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CFnameLabel.Name = "CFnameLabel"
        Me.CFnameLabel.Size = New System.Drawing.Size(93, 25)
        Me.CFnameLabel.TabIndex = 1
        Me.CFnameLabel.Text = "Firstame:"
        '
        'CFnameTextField
        '
        Me.CFnameTextField.Location = New System.Drawing.Point(414, 449)
        Me.CFnameTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CFnameTextField.Name = "CFnameTextField"
        Me.CFnameTextField.Size = New System.Drawing.Size(162, 29)
        Me.CFnameTextField.TabIndex = 2
        '
        'CLnameLabel
        '
        Me.CLnameLabel.AutoSize = True
        Me.CLnameLabel.Location = New System.Drawing.Point(275, 498)
        Me.CLnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CLnameLabel.Name = "CLnameLabel"
        Me.CLnameLabel.Size = New System.Drawing.Size(104, 25)
        Me.CLnameLabel.TabIndex = 3
        Me.CLnameLabel.Text = "Lastname:"
        '
        'customerLabel
        '
        Me.customerLabel.AutoSize = True
        Me.customerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerLabel.Location = New System.Drawing.Point(248, 413)
        Me.customerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.customerLabel.Name = "customerLabel"
        Me.customerLabel.Size = New System.Drawing.Size(204, 25)
        Me.customerLabel.TabIndex = 4
        Me.customerLabel.Text = "Customer Information:"
        '
        'CLnameTextField
        '
        Me.CLnameTextField.Location = New System.Drawing.Point(414, 494)
        Me.CLnameTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CLnameTextField.Name = "CLnameTextField"
        Me.CLnameTextField.Size = New System.Drawing.Size(162, 29)
        Me.CLnameTextField.TabIndex = 5
        '
        'CemailLabel
        '
        Me.CemailLabel.AutoSize = True
        Me.CemailLabel.Location = New System.Drawing.Point(275, 545)
        Me.CemailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CemailLabel.Name = "CemailLabel"
        Me.CemailLabel.Size = New System.Drawing.Size(66, 25)
        Me.CemailLabel.TabIndex = 6
        Me.CemailLabel.Text = "Email:"
        '
        'CEmailTextBox
        '
        Me.CEmailTextBox.Location = New System.Drawing.Point(414, 545)
        Me.CEmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CEmailTextBox.Name = "CEmailTextBox"
        Me.CEmailTextBox.Size = New System.Drawing.Size(162, 29)
        Me.CEmailTextBox.TabIndex = 7
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(275, 594)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(54, 25)
        Me.AgeLabel.TabIndex = 8
        Me.AgeLabel.Text = "Age:"
        '
        'CAgeTextBox
        '
        Me.CAgeTextBox.Location = New System.Drawing.Point(414, 590)
        Me.CAgeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CAgeTextBox.Name = "CAgeTextBox"
        Me.CAgeTextBox.Size = New System.Drawing.Size(61, 29)
        Me.CAgeTextBox.TabIndex = 9
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Location = New System.Drawing.Point(733, 449)
        Me.addressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(91, 25)
        Me.addressLabel.TabIndex = 10
        Me.addressLabel.Text = "Address:"
        '
        'CCountryTextField
        '
        Me.CCountryTextField.Location = New System.Drawing.Point(832, 586)
        Me.CCountryTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CCountryTextField.Name = "CCountryTextField"
        Me.CCountryTextField.Size = New System.Drawing.Size(219, 29)
        Me.CCountryTextField.TabIndex = 11
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.Location = New System.Drawing.Point(733, 498)
        Me.cityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(52, 25)
        Me.cityLabel.TabIndex = 12
        Me.cityLabel.Text = "City:"
        '
        'CAddressTextField
        '
        Me.CAddressTextField.Location = New System.Drawing.Point(832, 449)
        Me.CAddressTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CAddressTextField.Name = "CAddressTextField"
        Me.CAddressTextField.Size = New System.Drawing.Size(219, 29)
        Me.CAddressTextField.TabIndex = 13
        '
        'provinceLabel
        '
        Me.provinceLabel.AutoSize = True
        Me.provinceLabel.Location = New System.Drawing.Point(733, 545)
        Me.provinceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.provinceLabel.Name = "provinceLabel"
        Me.provinceLabel.Size = New System.Drawing.Size(94, 25)
        Me.provinceLabel.TabIndex = 14
        Me.provinceLabel.Text = "Province:"
        '
        'CCityTextField
        '
        Me.CCityTextField.Location = New System.Drawing.Point(832, 498)
        Me.CCityTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CCityTextField.Name = "CCityTextField"
        Me.CCityTextField.Size = New System.Drawing.Size(219, 29)
        Me.CCityTextField.TabIndex = 15
        '
        'countryLabel
        '
        Me.countryLabel.AutoSize = True
        Me.countryLabel.Location = New System.Drawing.Point(733, 590)
        Me.countryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.countryLabel.Name = "countryLabel"
        Me.countryLabel.Size = New System.Drawing.Size(81, 25)
        Me.countryLabel.TabIndex = 16
        Me.countryLabel.Text = "Country"
        '
        'CProvinceTextField
        '
        Me.CProvinceTextField.Location = New System.Drawing.Point(832, 545)
        Me.CProvinceTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CProvinceTextField.Name = "CProvinceTextField"
        Me.CProvinceTextField.Size = New System.Drawing.Size(219, 29)
        Me.CProvinceTextField.TabIndex = 17
        '
        'postalLabel
        '
        Me.postalLabel.AutoSize = True
        Me.postalLabel.Location = New System.Drawing.Point(733, 635)
        Me.postalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postalLabel.Name = "postalLabel"
        Me.postalLabel.Size = New System.Drawing.Size(125, 25)
        Me.postalLabel.TabIndex = 18
        Me.postalLabel.Text = "Postal Code:"
        '
        'CPostalTextField
        '
        Me.CPostalTextField.Location = New System.Drawing.Point(866, 635)
        Me.CPostalTextField.Margin = New System.Windows.Forms.Padding(4)
        Me.CPostalTextField.Name = "CPostalTextField"
        Me.CPostalTextField.Size = New System.Drawing.Size(185, 29)
        Me.CPostalTextField.TabIndex = 19
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(253, 833)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(128, 41)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'cardLabel
        '
        Me.cardLabel.AutoSize = True
        Me.cardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardLabel.Location = New System.Drawing.Point(248, 675)
        Me.cardLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cardLabel.Name = "cardLabel"
        Me.cardLabel.Size = New System.Drawing.Size(162, 25)
        Me.cardLabel.TabIndex = 21
        Me.cardLabel.Text = "Card Information:"
        '
        'cardNumberLabel
        '
        Me.cardNumberLabel.AutoSize = True
        Me.cardNumberLabel.Location = New System.Drawing.Point(275, 716)
        Me.cardNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cardNumberLabel.Name = "cardNumberLabel"
        Me.cardNumberLabel.Size = New System.Drawing.Size(135, 25)
        Me.cardNumberLabel.TabIndex = 22
        Me.cardNumberLabel.Text = "Card Number:"
        '
        'cvvLabel
        '
        Me.cvvLabel.AutoSize = True
        Me.cvvLabel.Location = New System.Drawing.Point(275, 766)
        Me.cvvLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cvvLabel.Name = "cvvLabel"
        Me.cvvLabel.Size = New System.Drawing.Size(61, 25)
        Me.cvvLabel.TabIndex = 23
        Me.cvvLabel.Text = "CVV:"
        '
        'creditCardTextbox
        '
        Me.creditCardTextbox.Location = New System.Drawing.Point(414, 716)
        Me.creditCardTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.creditCardTextbox.Name = "creditCardTextbox"
        Me.creditCardTextbox.Size = New System.Drawing.Size(180, 29)
        Me.creditCardTextbox.TabIndex = 24
        '
        'cvvTextbox
        '
        Me.cvvTextbox.Location = New System.Drawing.Point(418, 763)
        Me.cvvTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.cvvTextbox.Name = "cvvTextbox"
        Me.cvvTextbox.Size = New System.Drawing.Size(99, 29)
        Me.cvvTextbox.TabIndex = 25
        '
        'existingLabel
        '
        Me.existingLabel.AutoSize = True
        Me.existingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.existingLabel.Location = New System.Drawing.Point(248, 197)
        Me.existingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.existingLabel.Name = "existingLabel"
        Me.existingLabel.Size = New System.Drawing.Size(176, 25)
        Me.existingLabel.TabIndex = 26
        Me.existingLabel.Text = "Existing Customer:"
        '
        'lastname1Label
        '
        Me.lastname1Label.AutoSize = True
        Me.lastname1Label.Location = New System.Drawing.Point(275, 248)
        Me.lastname1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lastname1Label.Name = "lastname1Label"
        Me.lastname1Label.Size = New System.Drawing.Size(104, 25)
        Me.lastname1Label.TabIndex = 27
        Me.lastname1Label.Text = "Lastname:"
        '
        'existingTextfield
        '
        Me.existingTextfield.Location = New System.Drawing.Point(414, 245)
        Me.existingTextfield.Margin = New System.Windows.Forms.Padding(4)
        Me.existingTextfield.Name = "existingTextfield"
        Me.existingTextfield.Size = New System.Drawing.Size(162, 29)
        Me.existingTextfield.TabIndex = 28
        '
        'existingCustomers
        '
        Me.existingCustomers.FormattingEnabled = True
        Me.existingCustomers.ItemHeight = 24
        Me.existingCustomers.Location = New System.Drawing.Point(626, 245)
        Me.existingCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.existingCustomers.Name = "existingCustomers"
        Me.existingCustomers.Size = New System.Drawing.Size(425, 148)
        Me.existingCustomers.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(418, 833)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 41)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(414, 294)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(161, 41)
        Me.searchButton.TabIndex = 31
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(414, 352)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(161, 41)
        Me.clearButton.TabIndex = 32
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'createOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.existingCustomers)
        Me.Controls.Add(Me.existingTextfield)
        Me.Controls.Add(Me.lastname1Label)
        Me.Controls.Add(Me.existingLabel)
        Me.Controls.Add(Me.cvvTextbox)
        Me.Controls.Add(Me.creditCardTextbox)
        Me.Controls.Add(Me.cvvLabel)
        Me.Controls.Add(Me.cardNumberLabel)
        Me.Controls.Add(Me.cardLabel)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.CPostalTextField)
        Me.Controls.Add(Me.postalLabel)
        Me.Controls.Add(Me.CProvinceTextField)
        Me.Controls.Add(Me.countryLabel)
        Me.Controls.Add(Me.CCityTextField)
        Me.Controls.Add(Me.provinceLabel)
        Me.Controls.Add(Me.CAddressTextField)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Me.CCountryTextField)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.CAgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.CEmailTextBox)
        Me.Controls.Add(Me.CemailLabel)
        Me.Controls.Add(Me.CLnameTextField)
        Me.Controls.Add(Me.customerLabel)
        Me.Controls.Add(Me.CLnameLabel)
        Me.Controls.Add(Me.CFnameTextField)
        Me.Controls.Add(Me.CFnameLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "createOrder"
        Me.Text = "createOrder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextButton As Button
    Friend WithEvents CFnameLabel As Label
    Friend WithEvents CFnameTextField As TextBox
    Friend WithEvents CLnameLabel As Label
    Friend WithEvents customerLabel As Label
    Friend WithEvents CLnameTextField As TextBox
    Friend WithEvents CemailLabel As Label
    Friend WithEvents CEmailTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents CAgeTextBox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents CCountryTextField As TextBox
    Friend WithEvents cityLabel As Label
    Friend WithEvents CAddressTextField As TextBox
    Friend WithEvents provinceLabel As Label
    Friend WithEvents CCityTextField As TextBox
    Friend WithEvents countryLabel As Label
    Friend WithEvents CProvinceTextField As TextBox
    Friend WithEvents postalLabel As Label
    Friend WithEvents CPostalTextField As TextBox
    Friend WithEvents backButton As Button
    Friend WithEvents cardLabel As Label
    Friend WithEvents cardNumberLabel As Label
    Friend WithEvents cvvLabel As Label
    Friend WithEvents creditCardTextbox As TextBox
    Friend WithEvents cvvTextbox As TextBox
    Friend WithEvents existingLabel As Label
    Friend WithEvents lastname1Label As Label
    Friend WithEvents existingTextfield As TextBox
    Friend WithEvents existingCustomers As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
