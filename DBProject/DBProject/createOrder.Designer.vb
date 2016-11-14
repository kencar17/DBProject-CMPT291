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
        Me.CaddressTextField = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CcityTextField = New System.Windows.Forms.TextBox()
        Me.provinceLabel = New System.Windows.Forms.Label()
        Me.CProvinceTextField = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CCountryTextField = New System.Windows.Forms.TextBox()
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(517, 515)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(129, 41)
        Me.nextButton.TabIndex = 0
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'CFnameLabel
        '
        Me.CFnameLabel.AutoSize = True
        Me.CFnameLabel.Location = New System.Drawing.Point(47, 79)
        Me.CFnameLabel.Name = "CFnameLabel"
        Me.CFnameLabel.Size = New System.Drawing.Size(93, 25)
        Me.CFnameLabel.TabIndex = 1
        Me.CFnameLabel.Text = "Firstame:"
        '
        'CFnameTextField
        '
        Me.CFnameTextField.Location = New System.Drawing.Point(167, 79)
        Me.CFnameTextField.Name = "CFnameTextField"
        Me.CFnameTextField.Size = New System.Drawing.Size(161, 29)
        Me.CFnameTextField.TabIndex = 2
        '
        'CLnameLabel
        '
        Me.CLnameLabel.AutoSize = True
        Me.CLnameLabel.Location = New System.Drawing.Point(47, 121)
        Me.CLnameLabel.Name = "CLnameLabel"
        Me.CLnameLabel.Size = New System.Drawing.Size(104, 25)
        Me.CLnameLabel.TabIndex = 3
        Me.CLnameLabel.Text = "Lastname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Information:"
        '
        'CLnameTextField
        '
        Me.CLnameTextField.Location = New System.Drawing.Point(167, 121)
        Me.CLnameTextField.Name = "CLnameTextField"
        Me.CLnameTextField.Size = New System.Drawing.Size(161, 29)
        Me.CLnameTextField.TabIndex = 5
        '
        'CemailLabel
        '
        Me.CemailLabel.AutoSize = True
        Me.CemailLabel.Location = New System.Drawing.Point(47, 163)
        Me.CemailLabel.Name = "CemailLabel"
        Me.CemailLabel.Size = New System.Drawing.Size(66, 25)
        Me.CemailLabel.TabIndex = 6
        Me.CemailLabel.Text = "Email:"
        '
        'CEmailTextBox
        '
        Me.CEmailTextBox.Location = New System.Drawing.Point(167, 163)
        Me.CEmailTextBox.Name = "CEmailTextBox"
        Me.CEmailTextBox.Size = New System.Drawing.Size(161, 29)
        Me.CEmailTextBox.TabIndex = 7
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(52, 207)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(54, 25)
        Me.AgeLabel.TabIndex = 8
        Me.AgeLabel.Text = "Age:"
        '
        'CAgeTextBox
        '
        Me.CAgeTextBox.Location = New System.Drawing.Point(167, 207)
        Me.CAgeTextBox.Name = "CAgeTextBox"
        Me.CAgeTextBox.Size = New System.Drawing.Size(61, 29)
        Me.CAgeTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Address:"
        '
        'CaddressTextField
        '
        Me.CaddressTextField.Location = New System.Drawing.Point(485, 79)
        Me.CaddressTextField.Name = "CaddressTextField"
        Me.CaddressTextField.Size = New System.Drawing.Size(161, 29)
        Me.CaddressTextField.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "City:"
        '
        'CcityTextField
        '
        Me.CcityTextField.Location = New System.Drawing.Point(485, 121)
        Me.CcityTextField.Name = "CcityTextField"
        Me.CcityTextField.Size = New System.Drawing.Size(161, 29)
        Me.CcityTextField.TabIndex = 13
        '
        'provinceLabel
        '
        Me.provinceLabel.AutoSize = True
        Me.provinceLabel.Location = New System.Drawing.Point(380, 163)
        Me.provinceLabel.Name = "provinceLabel"
        Me.provinceLabel.Size = New System.Drawing.Size(94, 25)
        Me.provinceLabel.TabIndex = 14
        Me.provinceLabel.Text = "Province:"
        '
        'CProvinceTextField
        '
        Me.CProvinceTextField.Location = New System.Drawing.Point(485, 163)
        Me.CProvinceTextField.Name = "CProvinceTextField"
        Me.CProvinceTextField.Size = New System.Drawing.Size(161, 29)
        Me.CProvinceTextField.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Country"
        '
        'CCountryTextField
        '
        Me.CCountryTextField.Location = New System.Drawing.Point(485, 207)
        Me.CCountryTextField.Name = "CCountryTextField"
        Me.CCountryTextField.Size = New System.Drawing.Size(161, 29)
        Me.CCountryTextField.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Postal Code:"
        '
        'CPostalTextField
        '
        Me.CPostalTextField.Location = New System.Drawing.Point(517, 249)
        Me.CPostalTextField.Name = "CPostalTextField"
        Me.CPostalTextField.Size = New System.Drawing.Size(129, 29)
        Me.CPostalTextField.TabIndex = 19
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(52, 515)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(129, 41)
        Me.backButton.TabIndex = 20
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Card Information:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Card Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "CVV"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(193, 403)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 29)
        Me.TextBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(193, 452)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 29)
        Me.TextBox2.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Password:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(167, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 29)
        Me.TextBox3.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(490, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(156, 29)
        Me.TextBox4.TabIndex = 29
        '
        'createOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 577)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
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
        Me.Controls.Add(Me.CCountryTextField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CProvinceTextField)
        Me.Controls.Add(Me.provinceLabel)
        Me.Controls.Add(Me.CcityTextField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CaddressTextField)
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
    Friend WithEvents CaddressTextField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CcityTextField As TextBox
    Friend WithEvents provinceLabel As Label
    Friend WithEvents CProvinceTextField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CCountryTextField As TextBox
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
