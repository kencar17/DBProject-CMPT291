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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CLnameTextField = New System.Windows.Forms.TextBox()
        Me.CemailLabel = New System.Windows.Forms.Label()
        Me.CEmailTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.CAgeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CCountryTextField = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CAddressTextField = New System.Windows.Forms.TextBox()
        Me.provinceLabel = New System.Windows.Forms.Label()
        Me.CCityTextField = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CProvinceTextField = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CPostalTextField = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.existingTextfield = New System.Windows.Forms.TextBox()
        Me.existingCustomers = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(639, 705)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(129, 41)
        Me.nextButton.TabIndex = 0
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'CFnameLabel
        '
        Me.CFnameLabel.AutoSize = True
        Me.CFnameLabel.Location = New System.Drawing.Point(74, 298)
        Me.CFnameLabel.Name = "CFnameLabel"
        Me.CFnameLabel.Size = New System.Drawing.Size(93, 25)
        Me.CFnameLabel.TabIndex = 1
        Me.CFnameLabel.Text = "Firstame:"
        '
        'CFnameTextField
        '
        Me.CFnameTextField.Location = New System.Drawing.Point(215, 298)
        Me.CFnameTextField.Name = "CFnameTextField"
        Me.CFnameTextField.Size = New System.Drawing.Size(161, 29)
        Me.CFnameTextField.TabIndex = 2
        '
        'CLnameLabel
        '
        Me.CLnameLabel.AutoSize = True
        Me.CLnameLabel.Location = New System.Drawing.Point(74, 348)
        Me.CLnameLabel.Name = "CLnameLabel"
        Me.CLnameLabel.Size = New System.Drawing.Size(104, 25)
        Me.CLnameLabel.TabIndex = 3
        Me.CLnameLabel.Text = "Lastname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Information:"
        '
        'CLnameTextField
        '
        Me.CLnameTextField.Location = New System.Drawing.Point(215, 348)
        Me.CLnameTextField.Name = "CLnameTextField"
        Me.CLnameTextField.Size = New System.Drawing.Size(161, 29)
        Me.CLnameTextField.TabIndex = 5
        '
        'CemailLabel
        '
        Me.CemailLabel.AutoSize = True
        Me.CemailLabel.Location = New System.Drawing.Point(74, 398)
        Me.CemailLabel.Name = "CemailLabel"
        Me.CemailLabel.Size = New System.Drawing.Size(66, 25)
        Me.CemailLabel.TabIndex = 6
        Me.CemailLabel.Text = "Email:"
        '
        'CEmailTextBox
        '
        Me.CEmailTextBox.Location = New System.Drawing.Point(215, 398)
        Me.CEmailTextBox.Name = "CEmailTextBox"
        Me.CEmailTextBox.Size = New System.Drawing.Size(161, 29)
        Me.CEmailTextBox.TabIndex = 7
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(77, 448)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(54, 25)
        Me.AgeLabel.TabIndex = 8
        Me.AgeLabel.Text = "Age:"
        '
        'CAgeTextBox
        '
        Me.CAgeTextBox.Location = New System.Drawing.Point(215, 448)
        Me.CAgeTextBox.Name = "CAgeTextBox"
        Me.CAgeTextBox.Size = New System.Drawing.Size(61, 29)
        Me.CAgeTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Address:"
        '
        'CCountryTextField
        '
        Me.CCountryTextField.Location = New System.Drawing.Point(549, 448)
        Me.CCountryTextField.Name = "CCountryTextField"
        Me.CCountryTextField.Size = New System.Drawing.Size(219, 29)
        Me.CCountryTextField.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "City:"
        '
        'CAddressTextField
        '
        Me.CAddressTextField.Location = New System.Drawing.Point(549, 298)
        Me.CAddressTextField.Name = "CAddressTextField"
        Me.CAddressTextField.Size = New System.Drawing.Size(219, 29)
        Me.CAddressTextField.TabIndex = 13
        '
        'provinceLabel
        '
        Me.provinceLabel.AutoSize = True
        Me.provinceLabel.Location = New System.Drawing.Point(411, 398)
        Me.provinceLabel.Name = "provinceLabel"
        Me.provinceLabel.Size = New System.Drawing.Size(94, 25)
        Me.provinceLabel.TabIndex = 14
        Me.provinceLabel.Text = "Province:"
        '
        'CCityTextField
        '
        Me.CCityTextField.Location = New System.Drawing.Point(549, 348)
        Me.CCityTextField.Name = "CCityTextField"
        Me.CCityTextField.Size = New System.Drawing.Size(219, 29)
        Me.CCityTextField.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Country"
        '
        'CProvinceTextField
        '
        Me.CProvinceTextField.Location = New System.Drawing.Point(549, 398)
        Me.CProvinceTextField.Name = "CProvinceTextField"
        Me.CProvinceTextField.Size = New System.Drawing.Size(219, 29)
        Me.CProvinceTextField.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Postal Code:"
        '
        'CPostalTextField
        '
        Me.CPostalTextField.Location = New System.Drawing.Point(549, 498)
        Me.CPostalTextField.Name = "CPostalTextField"
        Me.CPostalTextField.Size = New System.Drawing.Size(219, 29)
        Me.CPostalTextField.TabIndex = 19
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(49, 705)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(129, 41)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 548)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Card Information:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 585)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Card Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 635)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "CVV:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(215, 585)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 29)
        Me.TextBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(215, 635)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 29)
        Me.TextBox2.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Existing Customer:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Lastname:"
        '
        'existingTextfield
        '
        Me.existingTextfield.Location = New System.Drawing.Point(215, 81)
        Me.existingTextfield.Name = "existingTextfield"
        Me.existingTextfield.Size = New System.Drawing.Size(161, 29)
        Me.existingTextfield.TabIndex = 28
        '
        'existingCustomers
        '
        Me.existingCustomers.FormattingEnabled = True
        Me.existingCustomers.ItemHeight = 24
        Me.existingCustomers.Location = New System.Drawing.Point(416, 81)
        Me.existingCustomers.Name = "existingCustomers"
        Me.existingCustomers.Size = New System.Drawing.Size(352, 148)
        Me.existingCustomers.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 705)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 41)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(215, 188)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(161, 41)
        Me.searchButton.TabIndex = 31
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'createOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 826)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.existingCustomers)
        Me.Controls.Add(Me.existingTextfield)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.CPostalTextField)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CProvinceTextField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CCityTextField)
        Me.Controls.Add(Me.provinceLabel)
        Me.Controls.Add(Me.CAddressTextField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CCountryTextField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CAgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.CEmailTextBox)
        Me.Controls.Add(Me.CemailLabel)
        Me.Controls.Add(Me.CLnameTextField)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CLnameLabel)
        Me.Controls.Add(Me.CFnameTextField)
        Me.Controls.Add(Me.CFnameLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Name = "createOrder"
        Me.Text = "createOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextButton As Button
    Friend WithEvents CFnameLabel As Label
    Friend WithEvents CFnameTextField As TextBox
    Friend WithEvents CLnameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CLnameTextField As TextBox
    Friend WithEvents CemailLabel As Label
    Friend WithEvents CEmailTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents CAgeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CCountryTextField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CAddressTextField As TextBox
    Friend WithEvents provinceLabel As Label
    Friend WithEvents CCityTextField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CProvinceTextField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CPostalTextField As TextBox
    Friend WithEvents backButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents existingTextfield As TextBox
    Friend WithEvents existingCustomers As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents searchButton As Button
End Class
