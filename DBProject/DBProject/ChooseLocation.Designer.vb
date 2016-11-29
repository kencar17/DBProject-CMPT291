<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseLocation
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
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.locationCombBox = New System.Windows.Forms.ComboBox()
        Me.pickLabel = New System.Windows.Forms.Label()
        Me.dropLabel = New System.Windows.Forms.Label()
        Me.ptimeLabel = New System.Windows.Forms.Label()
        Me.pickUpTime = New System.Windows.Forms.ComboBox()
        Me.dtimeLabel = New System.Windows.Forms.Label()
        Me.dropOffTime = New System.Windows.Forms.ComboBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.pickUp = New System.Windows.Forms.MonthCalendar()
        Me.dropOff = New System.Windows.Forms.MonthCalendar()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.invalidPdate = New System.Windows.Forms.Label()
        Me.invalidDDate = New System.Windows.Forms.Label()
        Me.errorLocation = New System.Windows.Forms.Label()
        Me.invalidPT = New System.Windows.Forms.Label()
        Me.InvalidDT = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locationLabel
        '
        Me.locationLabel.AutoSize = True
        Me.locationLabel.Location = New System.Drawing.Point(251, 146)
        Me.locationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(160, 25)
        Me.locationLabel.TabIndex = 0
        Me.locationLabel.Text = "Choose Location"
        '
        'locationCombBox
        '
        Me.locationCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.locationCombBox.FormattingEnabled = True
        Me.locationCombBox.Location = New System.Drawing.Point(433, 143)
        Me.locationCombBox.Margin = New System.Windows.Forms.Padding(4)
        Me.locationCombBox.Name = "locationCombBox"
        Me.locationCombBox.Size = New System.Drawing.Size(380, 32)
        Me.locationCombBox.TabIndex = 1
        '
        'pickLabel
        '
        Me.pickLabel.AutoSize = True
        Me.pickLabel.Location = New System.Drawing.Point(251, 240)
        Me.pickLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pickLabel.Name = "pickLabel"
        Me.pickLabel.Size = New System.Drawing.Size(82, 25)
        Me.pickLabel.TabIndex = 3
        Me.pickLabel.Text = "Pick up:"
        '
        'dropLabel
        '
        Me.dropLabel.AutoSize = True
        Me.dropLabel.Location = New System.Drawing.Point(733, 240)
        Me.dropLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dropLabel.Name = "dropLabel"
        Me.dropLabel.Size = New System.Drawing.Size(91, 25)
        Me.dropLabel.TabIndex = 4
        Me.dropLabel.Text = "Drop Off:"
        '
        'ptimeLabel
        '
        Me.ptimeLabel.AutoSize = True
        Me.ptimeLabel.Location = New System.Drawing.Point(251, 631)
        Me.ptimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ptimeLabel.Name = "ptimeLabel"
        Me.ptimeLabel.Size = New System.Drawing.Size(62, 25)
        Me.ptimeLabel.TabIndex = 6
        Me.ptimeLabel.Text = "Time:"
        '
        'pickUpTime
        '
        Me.pickUpTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pickUpTime.FormattingEnabled = True
        Me.pickUpTime.Location = New System.Drawing.Point(256, 660)
        Me.pickUpTime.Margin = New System.Windows.Forms.Padding(4)
        Me.pickUpTime.Name = "pickUpTime"
        Me.pickUpTime.Size = New System.Drawing.Size(189, 32)
        Me.pickUpTime.TabIndex = 7
        '
        'dtimeLabel
        '
        Me.dtimeLabel.AutoSize = True
        Me.dtimeLabel.Location = New System.Drawing.Point(733, 631)
        Me.dtimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dtimeLabel.Name = "dtimeLabel"
        Me.dtimeLabel.Size = New System.Drawing.Size(62, 25)
        Me.dtimeLabel.TabIndex = 8
        Me.dtimeLabel.Text = "Time:"
        '
        'dropOffTime
        '
        Me.dropOffTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropOffTime.FormattingEnabled = True
        Me.dropOffTime.Location = New System.Drawing.Point(733, 660)
        Me.dropOffTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dropOffTime.Name = "dropOffTime"
        Me.dropOffTime.Size = New System.Drawing.Size(195, 32)
        Me.dropOffTime.TabIndex = 9
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(958, 831)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(128, 39)
        Me.nextButton.TabIndex = 10
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(256, 831)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(95, 39)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'pickUp
        '
        Me.pickUp.Location = New System.Drawing.Point(256, 274)
        Me.pickUp.MaxSelectionCount = 1
        Me.pickUp.Name = "pickUp"
        Me.pickUp.TabIndex = 12
        '
        'dropOff
        '
        Me.dropOff.Location = New System.Drawing.Point(733, 274)
        Me.dropOff.MaxSelectionCount = 1
        Me.dropOff.Name = "dropOff"
        Me.dropOff.TabIndex = 13
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(359, 831)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(95, 39)
        Me.helpButton.TabIndex = 14
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'invalidPdate
        '
        Me.invalidPdate.AutoSize = True
        Me.invalidPdate.Location = New System.Drawing.Point(251, 581)
        Me.invalidPdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.invalidPdate.Name = "invalidPdate"
        Me.invalidPdate.Size = New System.Drawing.Size(186, 25)
        Me.invalidPdate.TabIndex = 15
        Me.invalidPdate.Text = "*Invalid Pickup Date"
        Me.invalidPdate.Visible = False
        '
        'invalidDDate
        '
        Me.invalidDDate.AutoSize = True
        Me.invalidDDate.Location = New System.Drawing.Point(733, 581)
        Me.invalidDDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.invalidDDate.Name = "invalidDDate"
        Me.invalidDDate.Size = New System.Drawing.Size(195, 25)
        Me.invalidDDate.TabIndex = 16
        Me.invalidDDate.Text = "*Invalid DropOff Date"
        Me.invalidDDate.Visible = False
        '
        'errorLocation
        '
        Me.errorLocation.AutoSize = True
        Me.errorLocation.Location = New System.Drawing.Point(428, 188)
        Me.errorLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.errorLocation.Name = "errorLocation"
        Me.errorLocation.Size = New System.Drawing.Size(282, 25)
        Me.errorLocation.TabIndex = 17
        Me.errorLocation.Text = "*Please select Branch Lcoation"
        Me.errorLocation.Visible = False
        '
        'invalidPT
        '
        Me.invalidPT.AutoSize = True
        Me.invalidPT.Location = New System.Drawing.Point(251, 709)
        Me.invalidPT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.invalidPT.Name = "invalidPT"
        Me.invalidPT.Size = New System.Drawing.Size(205, 25)
        Me.invalidPT.TabIndex = 18
        Me.invalidPT.Text = "*Please Select a Time"
        Me.invalidPT.Visible = False
        '
        'InvalidDT
        '
        Me.InvalidDT.AutoSize = True
        Me.InvalidDT.Location = New System.Drawing.Point(733, 709)
        Me.InvalidDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InvalidDT.Name = "InvalidDT"
        Me.InvalidDT.Size = New System.Drawing.Size(205, 25)
        Me.InvalidDT.TabIndex = 19
        Me.InvalidDT.Text = "*Please Select a Time"
        Me.InvalidDT.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ChooseLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.InvalidDT)
        Me.Controls.Add(Me.invalidPT)
        Me.Controls.Add(Me.errorLocation)
        Me.Controls.Add(Me.invalidDDate)
        Me.Controls.Add(Me.invalidPdate)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.dropOff)
        Me.Controls.Add(Me.pickUp)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.dropOffTime)
        Me.Controls.Add(Me.dtimeLabel)
        Me.Controls.Add(Me.pickUpTime)
        Me.Controls.Add(Me.ptimeLabel)
        Me.Controls.Add(Me.dropLabel)
        Me.Controls.Add(Me.pickLabel)
        Me.Controls.Add(Me.locationCombBox)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChooseLocation"
        Me.Text = "ChooseLocation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents locationLabel As Label
    Friend WithEvents locationCombBox As ComboBox
    Friend WithEvents pickLabel As Label
    Friend WithEvents dropLabel As Label
    Friend WithEvents ptimeLabel As Label
    Friend WithEvents pickUpTime As ComboBox
    Friend WithEvents dtimeLabel As Label
    Friend WithEvents dropOffTime As ComboBox
    Friend WithEvents nextButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents pickUp As MonthCalendar
    Friend WithEvents dropOff As MonthCalendar
    Friend WithEvents helpButton As Button
    Friend WithEvents invalidPdate As Label
    Friend WithEvents invalidDDate As Label
    Friend WithEvents errorLocation As Label
    Friend WithEvents invalidPT As Label
    Friend WithEvents InvalidDT As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
