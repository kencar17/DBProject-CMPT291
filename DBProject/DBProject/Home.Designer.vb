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
        Me.UserAdminButton.Location = New System.Drawing.Point(12, 11)
        Me.UserAdminButton.Name = "UserAdminButton"
        Me.UserAdminButton.Size = New System.Drawing.Size(116, 23)
        Me.UserAdminButton.TabIndex = 0
        Me.UserAdminButton.Text = "User Administration"
        Me.UserAdminButton.UseVisualStyleBackColor = True
        '
        'CarAdminButton
        '
        Me.CarAdminButton.Enabled = False
        Me.CarAdminButton.Location = New System.Drawing.Point(12, 41)
        Me.CarAdminButton.Name = "CarAdminButton"
        Me.CarAdminButton.Size = New System.Drawing.Size(116, 23)
        Me.CarAdminButton.TabIndex = 1
        Me.CarAdminButton.Text = "Car Administration"
        Me.CarAdminButton.UseVisualStyleBackColor = True
        '
        'RentalButton
        '
        Me.RentalButton.Enabled = False
        Me.RentalButton.Location = New System.Drawing.Point(12, 70)
        Me.RentalButton.Name = "RentalButton"
        Me.RentalButton.Size = New System.Drawing.Size(116, 23)
        Me.RentalButton.TabIndex = 2
        Me.RentalButton.Text = "Rentals"
        Me.RentalButton.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Enabled = False
        Me.BackupButton.Location = New System.Drawing.Point(12, 99)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(116, 23)
        Me.BackupButton.TabIndex = 3
        Me.BackupButton.Text = "Back Up System"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Enabled = False
        Me.HelpButton.Location = New System.Drawing.Point(12, 158)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(116, 23)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(134, 158)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(116, 23)
        Me.LogOutButton.TabIndex = 5
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(134, 46)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Name"
        '
        'UnusedLabel1
        '
        Me.UnusedLabel1.AutoSize = True
        Me.UnusedLabel1.Location = New System.Drawing.Point(135, 21)
        Me.UnusedLabel1.Name = "UnusedLabel1"
        Me.UnusedLabel1.Size = New System.Drawing.Size(71, 13)
        Me.UnusedLabel1.TabIndex = 8
        Me.UnusedLabel1.Text = "Logged in as:"
        '
        'ReportsButton
        '
        Me.ReportsButton.Location = New System.Drawing.Point(13, 129)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(115, 23)
        Me.ReportsButton.TabIndex = 9
        Me.ReportsButton.Text = "Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 193)
        Me.Controls.Add(Me.ReportsButton)
        Me.Controls.Add(Me.UnusedLabel1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.RentalButton)
        Me.Controls.Add(Me.CarAdminButton)
        Me.Controls.Add(Me.UserAdminButton)
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
