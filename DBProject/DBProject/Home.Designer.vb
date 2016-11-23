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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DeliveryTab = New System.Windows.Forms.TabPage()
        Me.PickupTab = New System.Windows.Forms.TabPage()
        Me.DeliveryBox = New System.Windows.Forms.ListBox()
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.PickupBox = New System.Windows.Forms.ListBox()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.DeliveryTab.SuspendLayout()
        Me.PickupTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserAdminButton
        '
        Me.UserAdminButton.Location = New System.Drawing.Point(12, 159)
        Me.UserAdminButton.Name = "UserAdminButton"
        Me.UserAdminButton.Size = New System.Drawing.Size(116, 23)
        Me.UserAdminButton.TabIndex = 0
        Me.UserAdminButton.Text = "User Administration"
        Me.UserAdminButton.UseVisualStyleBackColor = True
        '
        'CarAdminButton
        '
        Me.CarAdminButton.Location = New System.Drawing.Point(12, 188)
        Me.CarAdminButton.Name = "CarAdminButton"
        Me.CarAdminButton.Size = New System.Drawing.Size(116, 23)
        Me.CarAdminButton.TabIndex = 1
        Me.CarAdminButton.Text = "Car Administration"
        Me.CarAdminButton.UseVisualStyleBackColor = True
        '
        'RentalButton
        '
        Me.RentalButton.Location = New System.Drawing.Point(12, 217)
        Me.RentalButton.Name = "RentalButton"
        Me.RentalButton.Size = New System.Drawing.Size(116, 23)
        Me.RentalButton.TabIndex = 2
        Me.RentalButton.Text = "Rentals"
        Me.RentalButton.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Location = New System.Drawing.Point(12, 303)
        Me.BackupButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(116, 23)
        Me.BackupButton.TabIndex = 3
        Me.BackupButton.Text = "Back Up System"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(12, 360)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(116, 23)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(12, 389)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(116, 23)
        Me.LogOutButton.TabIndex = 5
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(118, 34)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Name"
        '
        'UnusedLabel1
        '
        Me.UnusedLabel1.AutoSize = True
        Me.UnusedLabel1.Location = New System.Drawing.Point(118, 12)
        Me.UnusedLabel1.Name = "UnusedLabel1"
        Me.UnusedLabel1.Size = New System.Drawing.Size(71, 13)
        Me.UnusedLabel1.TabIndex = 8
        Me.UnusedLabel1.Text = "Logged in as:"
        '
        'ReportsButton
        '
        Me.ReportsButton.Location = New System.Drawing.Point(12, 331)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(116, 23)
        Me.ReportsButton.TabIndex = 9
        Me.ReportsButton.Text = "Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Location = New System.Drawing.Point(12, 275)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(116, 23)
        Me.BranchButton.TabIndex = 10
        Me.BranchButton.Text = "Branches"
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'TypeButton
        '
        Me.TypeButton.Location = New System.Drawing.Point(12, 246)
        Me.TypeButton.Name = "TypeButton"
        Me.TypeButton.Size = New System.Drawing.Size(116, 23)
        Me.TypeButton.TabIndex = 11
        Me.TypeButton.Text = "Car Types"
        Me.TypeButton.UseVisualStyleBackColor = True
        '
        'FaceBox
        '
        Me.FaceBox.Location = New System.Drawing.Point(12, 12)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(100, 141)
        Me.FaceBox.TabIndex = 12
        Me.FaceBox.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DeliveryTab)
        Me.TabControl1.Controls.Add(Me.PickupTab)
        Me.TabControl1.Location = New System.Drawing.Point(172, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(501, 340)
        Me.TabControl1.TabIndex = 13
        '
        'DeliveryTab
        '
        Me.DeliveryTab.Controls.Add(Me.CheckInButton)
        Me.DeliveryTab.Controls.Add(Me.DeliveryBox)
        Me.DeliveryTab.Location = New System.Drawing.Point(4, 22)
        Me.DeliveryTab.Name = "DeliveryTab"
        Me.DeliveryTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DeliveryTab.Size = New System.Drawing.Size(493, 314)
        Me.DeliveryTab.TabIndex = 0
        Me.DeliveryTab.Text = "Today's Deliveries"
        Me.DeliveryTab.UseVisualStyleBackColor = True
        '
        'PickupTab
        '
        Me.PickupTab.Controls.Add(Me.CheckOutButton)
        Me.PickupTab.Controls.Add(Me.PickupBox)
        Me.PickupTab.Location = New System.Drawing.Point(4, 22)
        Me.PickupTab.Name = "PickupTab"
        Me.PickupTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PickupTab.Size = New System.Drawing.Size(493, 314)
        Me.PickupTab.TabIndex = 1
        Me.PickupTab.Text = "Today's Pickups"
        Me.PickupTab.UseVisualStyleBackColor = True
        '
        'DeliveryBox
        '
        Me.DeliveryBox.FormattingEnabled = True
        Me.DeliveryBox.Location = New System.Drawing.Point(6, 6)
        Me.DeliveryBox.Name = "DeliveryBox"
        Me.DeliveryBox.Size = New System.Drawing.Size(481, 277)
        Me.DeliveryBox.TabIndex = 0
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(412, 285)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckInButton.TabIndex = 1
        Me.CheckInButton.Text = "Check In"
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'PickupBox
        '
        Me.PickupBox.FormattingEnabled = True
        Me.PickupBox.Location = New System.Drawing.Point(6, 6)
        Me.PickupBox.Name = "PickupBox"
        Me.PickupBox.Size = New System.Drawing.Size(481, 277)
        Me.PickupBox.TabIndex = 0
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(412, 285)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckOutButton.TabIndex = 1
        Me.CheckOutButton.Text = "Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 546)
        Me.Controls.Add(Me.TabControl1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.DeliveryTab.ResumeLayout(False)
        Me.PickupTab.ResumeLayout(False)
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DeliveryTab As TabPage
    Friend WithEvents PickupTab As TabPage
    Friend WithEvents CheckInButton As Button
    Friend WithEvents DeliveryBox As ListBox
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents PickupBox As ListBox
End Class
