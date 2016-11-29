<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBranch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManagerBox
        '
        Me.ManagerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ManagerBox.FormattingEnabled = True
        Me.ManagerBox.Location = New System.Drawing.Point(570, 281)
        Me.ManagerBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ManagerBox.Name = "ManagerBox"
        Me.ManagerBox.Size = New System.Drawing.Size(219, 32)
        Me.ManagerBox.TabIndex = 0
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(444, 330)
        Me.AddressBox.Margin = New System.Windows.Forms.Padding(6)
        Me.AddressBox.MaxLength = 50
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(219, 29)
        Me.AddressBox.TabIndex = 1
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Location = New System.Drawing.Point(699, 330)
        Me.PostcodeBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PostcodeBox.MaxLength = 10
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(219, 29)
        Me.PostcodeBox.TabIndex = 2
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(444, 378)
        Me.CityBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CityBox.MaxLength = 50
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(219, 29)
        Me.CityBox.TabIndex = 3
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(699, 378)
        Me.StateBox.Margin = New System.Windows.Forms.Padding(6)
        Me.StateBox.MaxLength = 50
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(219, 29)
        Me.StateBox.TabIndex = 4
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(444, 426)
        Me.CountryBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CountryBox.MaxLength = 50
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(219, 29)
        Me.CountryBox.TabIndex = 5
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(699, 426)
        Me.EmailBox.Margin = New System.Windows.Forms.Padding(6)
        Me.EmailBox.MaxLength = 100
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(219, 29)
        Me.EmailBox.TabIndex = 6
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(444, 474)
        Me.PhoneBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PhoneBox.MaxLength = 20
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(219, 29)
        Me.PhoneBox.TabIndex = 7
        '
        'FaxBox
        '
        Me.FaxBox.Location = New System.Drawing.Point(699, 474)
        Me.FaxBox.Margin = New System.Windows.Forms.Padding(6)
        Me.FaxBox.MaxLength = 20
        Me.FaxBox.Name = "FaxBox"
        Me.FaxBox.Size = New System.Drawing.Size(219, 29)
        Me.FaxBox.TabIndex = 8
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(446, 524)
        Me.HButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(138, 42)
        Me.HButton.TabIndex = 9
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(613, 524)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(138, 42)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(783, 524)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(138, 42)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(607, 572)
        Me.ErrLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(71, 25)
        Me.ErrLabel.TabIndex = 12
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'NewBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "NewBranch"
        Me.Text = "NewBranch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
