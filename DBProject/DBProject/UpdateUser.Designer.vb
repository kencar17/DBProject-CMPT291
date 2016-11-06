<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUser
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
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.PostcodeBox = New System.Windows.Forms.TextBox()
        Me.LastnameBox = New System.Windows.Forms.TextBox()
        Me.FirstnameBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.UserSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(19, 196)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(95, 13)
        Me.ErrorLabel.TabIndex = 23
        Me.ErrorLabel.Text = "User already exists"
        Me.ErrorLabel.Visible = False
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(161, 171)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(100, 23)
        Me.SubmitButton.TabIndex = 22
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'EmailBox
        '
        Me.EmailBox.Enabled = False
        Me.EmailBox.Location = New System.Drawing.Point(22, 171)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailBox.TabIndex = 21
        '
        'CountryBox
        '
        Me.CountryBox.Enabled = False
        Me.CountryBox.Location = New System.Drawing.Point(161, 144)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryBox.TabIndex = 20
        '
        'StateBox
        '
        Me.StateBox.Enabled = False
        Me.StateBox.Location = New System.Drawing.Point(22, 144)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(100, 20)
        Me.StateBox.TabIndex = 19
        '
        'CityBox
        '
        Me.CityBox.Enabled = False
        Me.CityBox.Location = New System.Drawing.Point(161, 118)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 18
        '
        'AddressBox
        '
        Me.AddressBox.Enabled = False
        Me.AddressBox.Location = New System.Drawing.Point(22, 91)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(239, 20)
        Me.AddressBox.TabIndex = 16
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Enabled = False
        Me.PostcodeBox.Location = New System.Drawing.Point(22, 117)
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(100, 20)
        Me.PostcodeBox.TabIndex = 17
        '
        'LastnameBox
        '
        Me.LastnameBox.Enabled = False
        Me.LastnameBox.Location = New System.Drawing.Point(161, 65)
        Me.LastnameBox.Name = "LastnameBox"
        Me.LastnameBox.Size = New System.Drawing.Size(100, 20)
        Me.LastnameBox.TabIndex = 15
        '
        'FirstnameBox
        '
        Me.FirstnameBox.Enabled = False
        Me.FirstnameBox.Location = New System.Drawing.Point(22, 65)
        Me.FirstnameBox.Name = "FirstnameBox"
        Me.FirstnameBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstnameBox.TabIndex = 14
        '
        'PassBox
        '
        Me.PassBox.Enabled = False
        Me.PassBox.Location = New System.Drawing.Point(161, 39)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(100, 20)
        Me.PassBox.TabIndex = 13
        '
        'UsernameBox
        '
        Me.UsernameBox.Enabled = False
        Me.UsernameBox.Location = New System.Drawing.Point(22, 39)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameBox.TabIndex = 12
        '
        'UserSelection
        '
        Me.UserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserSelection.FormattingEnabled = True
        Me.UserSelection.Location = New System.Drawing.Point(82, 12)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(121, 21)
        Me.UserSelection.TabIndex = 24
        '
        'UpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 219)
        Me.Controls.Add(Me.UserSelection)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.PostcodeBox)
        Me.Controls.Add(Me.LastnameBox)
        Me.Controls.Add(Me.FirstnameBox)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Name = "UpdateUser"
        Me.Text = "Update a User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorLabel As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents PostcodeBox As TextBox
    Friend WithEvents LastnameBox As TextBox
    Friend WithEvents FirstnameBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents UserSelection As ComboBox
End Class
