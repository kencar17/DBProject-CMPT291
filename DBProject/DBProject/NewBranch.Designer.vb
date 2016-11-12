<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBranch
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
        Me.ManagerBox = New System.Windows.Forms.ComboBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.PostcodeBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.FaxBox = New System.Windows.Forms.TextBox()
        Me.HButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ManagerBox
        '
        Me.ManagerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ManagerBox.FormattingEnabled = True
        Me.ManagerBox.Location = New System.Drawing.Point(81, 12)
        Me.ManagerBox.Name = "ManagerBox"
        Me.ManagerBox.Size = New System.Drawing.Size(121, 21)
        Me.ManagerBox.TabIndex = 0
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(12, 39)
        Me.AddressBox.MaxLength = 50
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressBox.TabIndex = 1
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Location = New System.Drawing.Point(151, 39)
        Me.PostcodeBox.MaxLength = 10
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(121, 20)
        Me.PostcodeBox.TabIndex = 2
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(12, 65)
        Me.CityBox.MaxLength = 50
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(121, 20)
        Me.CityBox.TabIndex = 3
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(151, 65)
        Me.StateBox.MaxLength = 50
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(121, 20)
        Me.StateBox.TabIndex = 4
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(12, 91)
        Me.CountryBox.MaxLength = 50
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(121, 20)
        Me.CountryBox.TabIndex = 5
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(151, 91)
        Me.EmailBox.MaxLength = 100
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(121, 20)
        Me.EmailBox.TabIndex = 6
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(12, 117)
        Me.PhoneBox.MaxLength = 20
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(121, 20)
        Me.PhoneBox.TabIndex = 7
        '
        'FaxBox
        '
        Me.FaxBox.Location = New System.Drawing.Point(151, 117)
        Me.FaxBox.MaxLength = 20
        Me.FaxBox.Name = "FaxBox"
        Me.FaxBox.Size = New System.Drawing.Size(121, 20)
        Me.FaxBox.TabIndex = 8
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(13, 144)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(75, 23)
        Me.HButton.TabIndex = 9
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(104, 144)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(197, 144)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(101, 170)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrLabel.TabIndex = 12
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
        '
        'NewBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 197)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.FaxBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.PostcodeBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.ManagerBox)
        Me.Name = "NewBranch"
        Me.Text = "NewBranch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ManagerBox As ComboBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents PostcodeBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents FaxBox As TextBox
    Friend WithEvents HButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
End Class
