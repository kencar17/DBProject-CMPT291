﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBranch
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
        Me.BranchSelection = New System.Windows.Forms.ComboBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.PostcodeBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.FaxBox = New System.Windows.Forms.TextBox()
        Me.MBox = New System.Windows.Forms.ComboBox()
        Me.HButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchSelection
        '
        Me.BranchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchSelection.FormattingEnabled = True
        Me.BranchSelection.Location = New System.Drawing.Point(242, 152)
        Me.BranchSelection.Name = "BranchSelection"
        Me.BranchSelection.Size = New System.Drawing.Size(260, 21)
        Me.BranchSelection.TabIndex = 0
        '
        'AddressBox
        '
        Me.AddressBox.Enabled = False
        Me.AddressBox.Location = New System.Drawing.Point(242, 179)
        Me.AddressBox.MaxLength = 50
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressBox.TabIndex = 1
        '
        'PostcodeBox
        '
        Me.PostcodeBox.Enabled = False
        Me.PostcodeBox.Location = New System.Drawing.Point(381, 179)
        Me.PostcodeBox.MaxLength = 10
        Me.PostcodeBox.Name = "PostcodeBox"
        Me.PostcodeBox.Size = New System.Drawing.Size(121, 20)
        Me.PostcodeBox.TabIndex = 2
        '
        'CityBox
        '
        Me.CityBox.Enabled = False
        Me.CityBox.Location = New System.Drawing.Point(242, 205)
        Me.CityBox.MaxLength = 50
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(121, 20)
        Me.CityBox.TabIndex = 3
        '
        'StateBox
        '
        Me.StateBox.Enabled = False
        Me.StateBox.Location = New System.Drawing.Point(381, 205)
        Me.StateBox.MaxLength = 50
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(121, 20)
        Me.StateBox.TabIndex = 4
        '
        'CountryBox
        '
        Me.CountryBox.Enabled = False
        Me.CountryBox.Location = New System.Drawing.Point(242, 232)
        Me.CountryBox.MaxLength = 50
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(121, 20)
        Me.CountryBox.TabIndex = 5
        '
        'EmailBox
        '
        Me.EmailBox.Enabled = False
        Me.EmailBox.Location = New System.Drawing.Point(381, 232)
        Me.EmailBox.MaxLength = 50
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(121, 20)
        Me.EmailBox.TabIndex = 6
        '
        'PhoneBox
        '
        Me.PhoneBox.Enabled = False
        Me.PhoneBox.Location = New System.Drawing.Point(242, 259)
        Me.PhoneBox.MaxLength = 20
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(121, 20)
        Me.PhoneBox.TabIndex = 7
        '
        'FaxBox
        '
        Me.FaxBox.Enabled = False
        Me.FaxBox.Location = New System.Drawing.Point(381, 259)
        Me.FaxBox.MaxLength = 20
        Me.FaxBox.Name = "FaxBox"
        Me.FaxBox.Size = New System.Drawing.Size(121, 20)
        Me.FaxBox.TabIndex = 8
        '
        'MBox
        '
        Me.MBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MBox.Enabled = False
        Me.MBox.FormattingEnabled = True
        Me.MBox.Location = New System.Drawing.Point(309, 285)
        Me.MBox.Name = "MBox"
        Me.MBox.Size = New System.Drawing.Size(121, 21)
        Me.MBox.TabIndex = 9
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(242, 312)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(75, 23)
        Me.HButton.TabIndex = 10
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(335, 312)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 11
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(427, 312)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(335, 342)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrLabel.TabIndex = 13
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 533)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'UpdateBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 532)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.MBox)
        Me.Controls.Add(Me.FaxBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.PostcodeBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.BranchSelection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UpdateBranch"
        Me.Text = "UpdateBranch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BranchSelection As ComboBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents PostcodeBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents FaxBox As TextBox
    Friend WithEvents MBox As ComboBox
    Friend WithEvents HButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
