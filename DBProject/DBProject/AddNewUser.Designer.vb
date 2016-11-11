<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewUser
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
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.FirstnameBox = New System.Windows.Forms.TextBox()
        Me.LastnameBox = New System.Windows.Forms.TextBox()
        Me.PostcodeBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(24, 23)
        Me.UsernameBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(196, 31)
        Me.UsernameBox.TabIndex = 0
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(302, 23)
        Me.PassBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(196, 31)
        Me.PassBox.TabIndex = 1
        '
        'FirstnameBox
        '
        Me.FirstnameBox.Location = New System.Drawing.Point(24, 73)
        Me.FirstnameBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.FirstnameBox.Name = "FirstnameBox"
        Me.FirstnameBox.Size = New System.Drawing.Size(196, 31)
        Me.FirstnameBox.TabIndex = 2
        '
        'LastnameBox
        '
        Me.LastnameBox.Location = New System.Drawing.Point(302, 73)
        Me.LastnameBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.LastnameBox.Name = "LastnameBox"
        Me.LastnameBox.Size = New System.Drawing.Size(196, 31)
        Me.LastnameBox.TabIndex = 3
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Location = New System.Drawing.Point(24, 173)
        Me.PostcodeBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(196, 31)
        Me.PostcodeBox.TabIndex = 5
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(24, 123)
        Me.AddressBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(474, 31)
        Me.AddressBox.TabIndex = 4
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(302, 175)
        Me.CityBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(196, 31)
        Me.CityBox.TabIndex = 6
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(24, 225)
        Me.StateBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(196, 31)
        Me.StateBox.TabIndex = 7
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(302, 225)
        Me.CountryBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(196, 31)
        Me.CountryBox.TabIndex = 8
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(24, 277)
        Me.EmailBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(196, 31)
        Me.EmailBox.TabIndex = 9
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(302, 277)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(200, 44)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(18, 325)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(196, 25)
        Me.ErrorLabel.TabIndex = 11
        Me.ErrorLabel.Text = "User already exists"
        Me.ErrorLabel.Visible = False
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(26, 358)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(198, 44)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(302, 356)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(200, 44)
        Me.HelpButton.TabIndex = 13
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'AddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 433)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.CloseButton)
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
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "AddNewUser"
        Me.Text = "Add New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents FirstnameBox As TextBox
    Friend WithEvents LastnameBox As TextBox
    Friend WithEvents PostcodeBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents HelpButton As Button
End Class
