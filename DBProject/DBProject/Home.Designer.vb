<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.UserAdminButton = New System.Windows.Forms.Button()
        Me.CarAdminButton = New System.Windows.Forms.Button()
        Me.RentalButton = New System.Windows.Forms.Button()
        Me.BackupButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UnusedLabel1 = New System.Windows.Forms.Label()
        Me.ReportsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserAdminButton
        '
        Me.UserAdminButton.Location = New System.Drawing.Point(24, 21)
        Me.UserAdminButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UserAdminButton.Name = "UserAdminButton"
        Me.UserAdminButton.Size = New System.Drawing.Size(232, 44)
        Me.UserAdminButton.TabIndex = 0
        Me.UserAdminButton.Text = "User Administration"
        Me.UserAdminButton.UseVisualStyleBackColor = True
        '
        'CarAdminButton
        '
        Me.CarAdminButton.Location = New System.Drawing.Point(24, 79)
        Me.CarAdminButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CarAdminButton.Name = "CarAdminButton"
        Me.CarAdminButton.Size = New System.Drawing.Size(232, 44)
        Me.CarAdminButton.TabIndex = 1
        Me.CarAdminButton.Text = "Car Administration"
        Me.CarAdminButton.UseVisualStyleBackColor = True
        '
        'RentalButton
        '
        Me.RentalButton.Enabled = False
        Me.RentalButton.Location = New System.Drawing.Point(24, 135)
        Me.RentalButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RentalButton.Name = "RentalButton"
        Me.RentalButton.Size = New System.Drawing.Size(232, 44)
        Me.RentalButton.TabIndex = 2
        Me.RentalButton.Text = "Rentals"
        Me.RentalButton.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Location = New System.Drawing.Point(12, 99)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(232, 44)
        Me.BackupButton.TabIndex = 3
        Me.BackupButton.Text = "Back Up System"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(24, 304)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(232, 44)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(268, 304)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(232, 44)
        Me.LogOutButton.TabIndex = 5
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(268, 88)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 25)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Name"
        '
        'UnusedLabel1
        '
        Me.UnusedLabel1.AutoSize = True
        Me.UnusedLabel1.Location = New System.Drawing.Point(270, 40)
        Me.UnusedLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.UnusedLabel1.Name = "UnusedLabel1"
        Me.UnusedLabel1.Size = New System.Drawing.Size(142, 25)
        Me.UnusedLabel1.TabIndex = 8
        Me.UnusedLabel1.Text = "Logged in as:"
        '
        'ReportsButton
        '
        Me.ReportsButton.Location = New System.Drawing.Point(26, 248)
        Me.ReportsButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(230, 44)
        Me.ReportsButton.TabIndex = 9
        Me.ReportsButton.Text = "Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 371)
        Me.Controls.Add(Me.ReportsButton)
        Me.Controls.Add(Me.UnusedLabel1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.RentalButton)
        Me.Controls.Add(Me.CarAdminButton)
        Me.Controls.Add(Me.UserAdminButton)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserAdminButton As Button
    Friend WithEvents CarAdminButton As Button
    Friend WithEvents RentalButton As Button
    Friend WithEvents BackupButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents UnusedLabel1 As Label
    Friend WithEvents ReportsButton As Button
End Class
