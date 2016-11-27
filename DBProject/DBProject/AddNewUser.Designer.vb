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
        Me.ImgButton = New System.Windows.Forms.Button()
        Me.PicturePath = New System.Windows.Forms.Label()
        Me.BranchSelection = New System.Windows.Forms.ComboBox()
        Me.FaceBox = New System.Windows.Forms.PictureBox()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(233, 112)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameBox.TabIndex = 0
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(372, 112)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(100, 20)
        Me.PassBox.TabIndex = 1
        '
        'FirstnameBox
        '
        Me.FirstnameBox.Location = New System.Drawing.Point(233, 138)
        Me.FirstnameBox.Name = "FirstnameBox"
        Me.FirstnameBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstnameBox.TabIndex = 2
        '
        'LastnameBox
        '
        Me.LastnameBox.Location = New System.Drawing.Point(372, 138)
        Me.LastnameBox.Name = "LastnameBox"
        Me.LastnameBox.Size = New System.Drawing.Size(100, 20)
        Me.LastnameBox.TabIndex = 3
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Location = New System.Drawing.Point(233, 190)
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(100, 20)
        Me.PostcodeBox.TabIndex = 5
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(233, 164)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(239, 20)
        Me.AddressBox.TabIndex = 4
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(372, 191)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 6
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(233, 217)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(100, 20)
        Me.StateBox.TabIndex = 7
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(372, 217)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryBox.TabIndex = 8
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(233, 244)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailBox.TabIndex = 9
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(233, 320)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(100, 23)
        Me.SubmitButton.TabIndex = 12
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(369, 325)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(95, 13)
        Me.ErrorLabel.TabIndex = 11
        Me.ErrorLabel.Text = "User already exists"
        Me.ErrorLabel.Visible = False
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(233, 349)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 23)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(372, 349)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(100, 23)
        Me.HelpButton.TabIndex = 14
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ImgButton
        '
        Me.ImgButton.Location = New System.Drawing.Point(372, 244)
        Me.ImgButton.Name = "ImgButton"
        Me.ImgButton.Size = New System.Drawing.Size(100, 23)
        Me.ImgButton.TabIndex = 10
        Me.ImgButton.Text = "Select Image"
        Me.ImgButton.UseVisualStyleBackColor = True
        '
        'PicturePath
        '
        Me.PicturePath.AutoSize = True
        Me.PicturePath.Location = New System.Drawing.Point(233, 267)
        Me.PicturePath.Name = "PicturePath"
        Me.PicturePath.Size = New System.Drawing.Size(0, 13)
        Me.PicturePath.TabIndex = 15
        '
        'BranchSelection
        '
        Me.BranchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchSelection.FormattingEnabled = True
        Me.BranchSelection.Location = New System.Drawing.Point(233, 293)
        Me.BranchSelection.Name = "BranchSelection"
        Me.BranchSelection.Size = New System.Drawing.Size(239, 21)
        Me.BranchSelection.TabIndex = 11
        '
        'FaceBox
        '
        Me.FaceBox.Location = New System.Drawing.Point(502, 112)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(173, 202)
        Me.FaceBox.TabIndex = 16
        Me.FaceBox.TabStop = False
        '
        'AddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.FaceBox)
        Me.Controls.Add(Me.BranchSelection)
        Me.Controls.Add(Me.PicturePath)
        Me.Controls.Add(Me.ImgButton)
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
        Me.Name = "AddNewUser"
        Me.Text = "Add New User"
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ImgButton As Button
    Friend WithEvents PicturePath As Label
    Friend WithEvents BranchSelection As ComboBox
    Friend WithEvents FaceBox As PictureBox
End Class
