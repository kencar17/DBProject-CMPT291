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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.locationCombBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pickUpTime = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Location"
        '
        'locationCombBox
        '
        Me.locationCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.locationCombBox.FormattingEnabled = True
        Me.locationCombBox.Location = New System.Drawing.Point(235, 47)
        Me.locationCombBox.Name = "locationCombBox"
        Me.locationCombBox.Size = New System.Drawing.Size(379, 32)
        Me.locationCombBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick up:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drop Off:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 547)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:"
        '
        'pickUpTime
        '
        Me.pickUpTime.FormattingEnabled = True
        Me.pickUpTime.Location = New System.Drawing.Point(74, 575)
        Me.pickUpTime.Name = "pickUpTime"
        Me.pickUpTime.Size = New System.Drawing.Size(190, 32)
        Me.pickUpTime.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(523, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time:"
        '
        'dropOffTime
        '
        Me.dropOffTime.FormattingEnabled = True
        Me.dropOffTime.Location = New System.Drawing.Point(528, 575)
        Me.dropOffTime.Name = "dropOffTime"
        Me.dropOffTime.Size = New System.Drawing.Size(195, 32)
        Me.dropOffTime.TabIndex = 9
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(753, 699)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(128, 39)
        Me.nextButton.TabIndex = 10
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(79, 699)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(96, 39)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'pickUp
        '
        Me.pickUp.Location = New System.Drawing.Point(74, 199)
        Me.pickUp.MaxSelectionCount = 1
        Me.pickUp.Name = "pickUp"
        Me.pickUp.TabIndex = 12
        '
        'dropOff
        '
        Me.dropOff.Location = New System.Drawing.Point(528, 199)
        Me.dropOff.MaxSelectionCount = 1
        Me.dropOff.Name = "dropOff"
        Me.dropOff.TabIndex = 13
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(192, 699)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(96, 39)
        Me.helpButton.TabIndex = 14
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'invalidPdate
        '
        Me.invalidPdate.AutoSize = True
        Me.invalidPdate.Location = New System.Drawing.Point(69, 505)
        Me.invalidPdate.Name = "invalidPdate"
        Me.invalidPdate.Size = New System.Drawing.Size(186, 25)
        Me.invalidPdate.TabIndex = 15
        Me.invalidPdate.Text = "*Invalid Pickup Date"
        Me.invalidPdate.Visible = False
        '
        'invalidDDate
        '
        Me.invalidDDate.AutoSize = True
        Me.invalidDDate.Location = New System.Drawing.Point(523, 505)
        Me.invalidDDate.Name = "invalidDDate"
        Me.invalidDDate.Size = New System.Drawing.Size(195, 25)
        Me.invalidDDate.TabIndex = 16
        Me.invalidDDate.Text = "*Invalid DropOff Date"
        Me.invalidDDate.Visible = False
        '
        'errorLocation
        '
        Me.errorLocation.AutoSize = True
        Me.errorLocation.Location = New System.Drawing.Point(235, 97)
        Me.errorLocation.Name = "errorLocation"
        Me.errorLocation.Size = New System.Drawing.Size(282, 25)
        Me.errorLocation.TabIndex = 17
        Me.errorLocation.Text = "*Please select Branch Lcoation"
        Me.errorLocation.Visible = False
        '
        'invalidPT
        '
        Me.invalidPT.AutoSize = True
        Me.invalidPT.Location = New System.Drawing.Point(74, 614)
        Me.invalidPT.Name = "invalidPT"
        Me.invalidPT.Size = New System.Drawing.Size(205, 25)
        Me.invalidPT.TabIndex = 18
        Me.invalidPT.Text = "*Please Select a Time"
        Me.invalidPT.Visible = False
        '
        'InvalidDT
        '
        Me.InvalidDT.AutoSize = True
        Me.InvalidDT.Location = New System.Drawing.Point(528, 614)
        Me.InvalidDT.Name = "InvalidDT"
        Me.InvalidDT.Size = New System.Drawing.Size(205, 25)
        Me.InvalidDT.TabIndex = 19
        Me.InvalidDT.Text = "*Please Select a Time"
        Me.InvalidDT.Visible = False
        '
        'ChooseLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 857)
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pickUpTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.locationCombBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChooseLocation"
        Me.Text = "ChooseLocation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents locationCombBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pickUpTime As ComboBox
    Friend WithEvents Label5 As Label
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
End Class
