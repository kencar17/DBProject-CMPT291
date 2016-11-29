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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ImgButton = New System.Windows.Forms.Button()
        Me.PicturePath = New System.Windows.Forms.Label()
        Me.BranchSelection = New System.Windows.Forms.ComboBox()
        Me.FaceBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(406, 362)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(95, 13)
        Me.ErrorLabel.TabIndex = 23
        Me.ErrorLabel.Text = "User already exists"
        Me.ErrorLabel.Visible = False
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(270, 357)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(100, 23)
        Me.SubmitButton.TabIndex = 22
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'EmailBox
        '
        Me.EmailBox.Enabled = False
        Me.EmailBox.Location = New System.Drawing.Point(270, 278)
        Me.EmailBox.MaxLength = 100
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailBox.TabIndex = 21
        '
        'CountryBox
        '
        Me.CountryBox.Enabled = False
        Me.CountryBox.Location = New System.Drawing.Point(409, 251)
        Me.CountryBox.MaxLength = 50
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryBox.TabIndex = 20
        '
        'StateBox
        '
        Me.StateBox.Enabled = False
        Me.StateBox.Location = New System.Drawing.Point(270, 251)
        Me.StateBox.MaxLength = 50
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(100, 20)
        Me.StateBox.TabIndex = 19
        '
        'CityBox
        '
        Me.CityBox.Enabled = False
        Me.CityBox.Location = New System.Drawing.Point(409, 225)
        Me.CityBox.MaxLength = 50
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 18
        '
        'AddressBox
        '
        Me.AddressBox.Enabled = False
        Me.AddressBox.Location = New System.Drawing.Point(270, 198)
        Me.AddressBox.MaxLength = 50
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(239, 20)
        Me.AddressBox.TabIndex = 16
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Enabled = False
        Me.PostcodeBox.Location = New System.Drawing.Point(270, 224)
        Me.PostcodeBox.MaxLength = 6
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(100, 20)
        Me.PostcodeBox.TabIndex = 17
        '
        'LastnameBox
        '
        Me.LastnameBox.Enabled = False
        Me.LastnameBox.Location = New System.Drawing.Point(409, 172)
        Me.LastnameBox.MaxLength = 40
        Me.LastnameBox.Name = "LastnameBox"
        Me.LastnameBox.Size = New System.Drawing.Size(100, 20)
        Me.LastnameBox.TabIndex = 15
        '
        'FirstnameBox
        '
        Me.FirstnameBox.Enabled = False
        Me.FirstnameBox.Location = New System.Drawing.Point(270, 172)
        Me.FirstnameBox.MaxLength = 20
        Me.FirstnameBox.Name = "FirstnameBox"
        Me.FirstnameBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstnameBox.TabIndex = 14
        '
        'PassBox
        '
        Me.PassBox.Enabled = False
        Me.PassBox.Location = New System.Drawing.Point(409, 146)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(100, 20)
        Me.PassBox.TabIndex = 13
        '
        'UsernameBox
        '
        Me.UsernameBox.Enabled = False
        Me.UsernameBox.Location = New System.Drawing.Point(270, 146)
        Me.UsernameBox.MaxLength = 16
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameBox.TabIndex = 12
        '
        'UserSelection
        '
        Me.UserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserSelection.FormattingEnabled = True
        Me.UserSelection.Location = New System.Drawing.Point(330, 119)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(121, 21)
        Me.UserSelection.TabIndex = 24
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(270, 386)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(99, 23)
        Me.CloseButton.TabIndex = 25
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(409, 386)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(100, 23)
        Me.HelpButton.TabIndex = 26
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ImgButton
        '
        Me.ImgButton.Enabled = False
        Me.ImgButton.Location = New System.Drawing.Point(409, 278)
        Me.ImgButton.Name = "ImgButton"
        Me.ImgButton.Size = New System.Drawing.Size(100, 23)
        Me.ImgButton.TabIndex = 27
        Me.ImgButton.Text = "Change Image"
        Me.ImgButton.UseVisualStyleBackColor = True
        '
        'PicturePath
        '
        Me.PicturePath.AutoSize = True
        Me.PicturePath.Location = New System.Drawing.Point(267, 309)
        Me.PicturePath.Name = "PicturePath"
        Me.PicturePath.Size = New System.Drawing.Size(0, 13)
        Me.PicturePath.TabIndex = 28
        '
        'BranchSelection
        '
        Me.BranchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchSelection.Enabled = False
        Me.BranchSelection.FormattingEnabled = True
        Me.BranchSelection.Location = New System.Drawing.Point(270, 330)
        Me.BranchSelection.Name = "BranchSelection"
        Me.BranchSelection.Size = New System.Drawing.Size(239, 21)
        Me.BranchSelection.TabIndex = 29
        '
        'FaceBox
        '
        Me.FaceBox.Location = New System.Drawing.Point(83, 142)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(173, 205)
        Me.FaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FaceBox.TabIndex = 30
        Me.FaceBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 533)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'UpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 532)
        Me.Controls.Add(Me.FaceBox)
        Me.Controls.Add(Me.BranchSelection)
        Me.Controls.Add(Me.PicturePath)
        Me.Controls.Add(Me.ImgButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.CloseButton)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UpdateUser"
        Me.Text = "Update a User"
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CloseButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents ImgButton As Button
    Friend WithEvents PicturePath As Label
    Friend WithEvents BranchSelection As ComboBox
    Friend WithEvents FaceBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
