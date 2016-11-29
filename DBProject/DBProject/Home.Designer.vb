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
        Me.CheckInButton = New System.Windows.Forms.Button()
        Me.DeliveryBox = New System.Windows.Forms.ListBox()
        Me.PickupTab = New System.Windows.Forms.TabPage()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.PickupBox = New System.Windows.Forms.ListBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.DeliveryTab.SuspendLayout()
        Me.PickupTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAdminButton
        '
        Me.UserAdminButton.Location = New System.Drawing.Point(22, 539)
        Me.UserAdminButton.Margin = New System.Windows.Forms.Padding(6)
        Me.UserAdminButton.Name = "UserAdminButton"
        Me.UserAdminButton.Size = New System.Drawing.Size(213, 42)
        Me.UserAdminButton.TabIndex = 0
        Me.UserAdminButton.Text = "User Administration"
        Me.UserAdminButton.UseVisualStyleBackColor = True
        '
        'CarAdminButton
        '
        Me.CarAdminButton.Location = New System.Drawing.Point(22, 646)
        Me.CarAdminButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CarAdminButton.Name = "CarAdminButton"
        Me.CarAdminButton.Size = New System.Drawing.Size(213, 42)
        Me.CarAdminButton.TabIndex = 1
        Me.CarAdminButton.Text = "Car Administration"
        Me.CarAdminButton.UseVisualStyleBackColor = True
        '
        'RentalButton
        '
        Me.RentalButton.Location = New System.Drawing.Point(22, 807)
        Me.RentalButton.Margin = New System.Windows.Forms.Padding(6)
        Me.RentalButton.Name = "RentalButton"
        Me.RentalButton.Size = New System.Drawing.Size(213, 42)
        Me.RentalButton.TabIndex = 2
        Me.RentalButton.Text = "Rentals"
        Me.RentalButton.UseVisualStyleBackColor = True
        '
        'BackupButton
        '
        Me.BackupButton.Location = New System.Drawing.Point(293, 807)
        Me.BackupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(213, 42)
        Me.BackupButton.TabIndex = 3
        Me.BackupButton.Text = "Back Up System"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(779, 807)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(213, 42)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Location = New System.Drawing.Point(1021, 807)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(6)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(213, 42)
        Me.LogOutButton.TabIndex = 5
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(22, 500)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(64, 25)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Name"
        '
        'UnusedLabel1
        '
        Me.UnusedLabel1.AutoSize = True
        Me.UnusedLabel1.Location = New System.Drawing.Point(22, 458)
        Me.UnusedLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.UnusedLabel1.Name = "UnusedLabel1"
        Me.UnusedLabel1.Size = New System.Drawing.Size(130, 25)
        Me.UnusedLabel1.TabIndex = 8
        Me.UnusedLabel1.Text = "Logged in as:"
        '
        'ReportsButton
        '
        Me.ReportsButton.Location = New System.Drawing.Point(535, 807)
        Me.ReportsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(213, 42)
        Me.ReportsButton.TabIndex = 9
        Me.ReportsButton.Text = "Reports"
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Location = New System.Drawing.Point(22, 753)
        Me.BranchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(213, 42)
        Me.BranchButton.TabIndex = 10
        Me.BranchButton.Text = "Branches"
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'TypeButton
        '
        Me.TypeButton.Location = New System.Drawing.Point(22, 700)
        Me.TypeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.TypeButton.Name = "TypeButton"
        Me.TypeButton.Size = New System.Drawing.Size(213, 42)
        Me.TypeButton.TabIndex = 11
        Me.TypeButton.Text = "Car Types"
        Me.TypeButton.UseVisualStyleBackColor = True
        '
        'FaceBox
        '
        Me.FaceBox.Location = New System.Drawing.Point(22, 133)
        Me.FaceBox.Margin = New System.Windows.Forms.Padding(6)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(213, 303)
        Me.FaceBox.TabIndex = 12
        Me.FaceBox.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DeliveryTab)
        Me.TabControl1.Controls.Add(Me.PickupTab)
        Me.TabControl1.Location = New System.Drawing.Point(293, 172)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(941, 616)
        Me.TabControl1.TabIndex = 13
        '
        'DeliveryTab
        '
        Me.DeliveryTab.Controls.Add(Me.CheckInButton)
        Me.DeliveryTab.Controls.Add(Me.DeliveryBox)
        Me.DeliveryTab.Location = New System.Drawing.Point(4, 33)
        Me.DeliveryTab.Margin = New System.Windows.Forms.Padding(6)
        Me.DeliveryTab.Name = "DeliveryTab"
        Me.DeliveryTab.Padding = New System.Windows.Forms.Padding(6)
        Me.DeliveryTab.Size = New System.Drawing.Size(933, 579)
        Me.DeliveryTab.TabIndex = 0
        Me.DeliveryTab.Text = "Today's Deliveries"
        Me.DeliveryTab.UseVisualStyleBackColor = True
        '
        'CheckInButton
        '
        Me.CheckInButton.Location = New System.Drawing.Point(755, 526)
        Me.CheckInButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckInButton.Name = "CheckInButton"
        Me.CheckInButton.Size = New System.Drawing.Size(138, 42)
        Me.CheckInButton.TabIndex = 1
        Me.CheckInButton.Text = "Check In"
        Me.CheckInButton.UseVisualStyleBackColor = True
        '
        'DeliveryBox
        '
        Me.DeliveryBox.FormattingEnabled = True
        Me.DeliveryBox.ItemHeight = 24
        Me.DeliveryBox.Location = New System.Drawing.Point(11, 11)
        Me.DeliveryBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DeliveryBox.Name = "DeliveryBox"
        Me.DeliveryBox.Size = New System.Drawing.Size(879, 508)
        Me.DeliveryBox.TabIndex = 0
        '
        'PickupTab
        '
        Me.PickupTab.Controls.Add(Me.CheckOutButton)
        Me.PickupTab.Controls.Add(Me.PickupBox)
        Me.PickupTab.Location = New System.Drawing.Point(4, 33)
        Me.PickupTab.Margin = New System.Windows.Forms.Padding(6)
        Me.PickupTab.Name = "PickupTab"
        Me.PickupTab.Padding = New System.Windows.Forms.Padding(6)
        Me.PickupTab.Size = New System.Drawing.Size(933, 579)
        Me.PickupTab.TabIndex = 1
        Me.PickupTab.Text = "Today's Pickups"
        Me.PickupTab.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(755, 526)
        Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(138, 42)
        Me.CheckOutButton.TabIndex = 1
        Me.CheckOutButton.Text = "Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'PickupBox
        '
        Me.PickupBox.FormattingEnabled = True
        Me.PickupBox.ItemHeight = 24
        Me.PickupBox.Location = New System.Drawing.Point(11, 11)
        Me.PickupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PickupBox.Name = "PickupBox"
        Me.PickupBox.Size = New System.Drawing.Size(879, 508)
        Me.PickupBox.TabIndex = 0
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(22, 593)
        Me.BrowseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(213, 42)
        Me.BrowseButton.TabIndex = 14
        Me.BrowseButton.Text = "Browse Inventory"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.BrowseButton)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.DeliveryTab.ResumeLayout(False)
        Me.PickupTab.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BrowseButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
