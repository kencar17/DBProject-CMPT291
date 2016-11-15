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
        Me.BranchButton = New System.Windows.Forms.Button()
        Me.TypeButton = New System.Windows.Forms.Button()
        Me.FaceBox = New System.Windows.Forms.PictureBox()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CarAdminButton.Location = New System.Drawing.Point(12, 41)
        Me.CarAdminButton.Name = "CarAdminButton"
        Me.CarAdminButton.Size = New System.Drawing.Size(116, 23)
        Me.CarAdminButton.TabIndex = 1
        Me.CarAdminButton.Text = "Car Administration"
        Me.CarAdminButton.UseVisualStyleBackColor = True
        '
        'RentalButton
        '
        Me.RentalButton.Location = New System.Drawing.Point(12, 70)
        Me.RentalButton.Name = "RentalButton"
        Me.RentalButton.Size = New System.Drawing.Size(116, 23)
        Me.RentalButton.TabIndex = 2
        Me.RentalButton.Text = "Rentals"
        Me.RentalButton.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Location = New System.Drawing.Point(11, 157)
        Me.BackupButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(117, 23)
        Me.BackupButton.TabIndex = 3
        Me.BackupButton.Text = "Back Up System"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(10, 217)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(118, 23)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(133, 217)
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
        Me.ReportsButton.Location = New System.Drawing.Point(11, 188)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(117, 23)
        Me.ReportsButton.TabIndex = 9
        Me.ReportsButton.Text = "Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Location = New System.Drawing.Point(12, 129)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(116, 23)
        Me.BranchButton.TabIndex = 10
        Me.BranchButton.Text = "Branches"
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'TypeButton
        '
        Me.TypeButton.Location = New System.Drawing.Point(12, 100)
        Me.TypeButton.Name = "TypeButton"
        Me.TypeButton.Size = New System.Drawing.Size(116, 23)
        Me.TypeButton.TabIndex = 11
        Me.TypeButton.Text = "Car Types"
        Me.TypeButton.UseVisualStyleBackColor = True
        '
        'FaceBox
        '
        Me.FaceBox.Location = New System.Drawing.Point(138, 70)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(100, 141)
        Me.FaceBox.TabIndex = 12
        Me.FaceBox.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 253)
        Me.Controls.Add(Me.FaceBox)
        Me.Controls.Add(Me.TypeButton)
        Me.Controls.Add(Me.BranchButton)
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
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BranchButton As Button
    Friend WithEvents TypeButton As Button
    Friend WithEvents FaceBox As PictureBox
End Class
