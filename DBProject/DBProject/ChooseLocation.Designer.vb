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
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Location"
        '
        'locationCombBox
        '
        Me.locationCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.locationCombBox.FormattingEnabled = True
        Me.locationCombBox.Location = New System.Drawing.Point(128, 25)
        Me.locationCombBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.locationCombBox.Name = "locationCombBox"
        Me.locationCombBox.Size = New System.Drawing.Size(209, 21)
        Me.locationCombBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick up:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drop Off:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 296)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:"
        '
        'pickUpTime
        '
        Me.pickUpTime.FormattingEnabled = True
        Me.pickUpTime.Location = New System.Drawing.Point(40, 311)
        Me.pickUpTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pickUpTime.Name = "pickUpTime"
        Me.pickUpTime.Size = New System.Drawing.Size(105, 21)
        Me.pickUpTime.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 296)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time:"
        '
        'dropOffTime
        '
        Me.dropOffTime.FormattingEnabled = True
        Me.dropOffTime.Location = New System.Drawing.Point(288, 311)
        Me.dropOffTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dropOffTime.Name = "dropOffTime"
        Me.dropOffTime.Size = New System.Drawing.Size(108, 21)
        Me.dropOffTime.TabIndex = 9
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(411, 379)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(70, 21)
        Me.nextButton.TabIndex = 10
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(43, 379)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(52, 21)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'pickUp
        '
        Me.pickUp.Location = New System.Drawing.Point(40, 108)
        Me.pickUp.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pickUp.MaxSelectionCount = 1
        Me.pickUp.Name = "pickUp"
        Me.pickUp.TabIndex = 12
        '
        'dropOff
        '
        Me.dropOff.Location = New System.Drawing.Point(288, 108)
        Me.dropOff.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dropOff.MaxSelectionCount = 1
        Me.dropOff.Name = "dropOff"
        Me.dropOff.TabIndex = 13
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(105, 379)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(52, 21)
        Me.helpButton.TabIndex = 14
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'invalidPdate
        '
        Me.invalidPdate.AutoSize = True
        Me.invalidPdate.Location = New System.Drawing.Point(38, 274)
        Me.invalidPdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.invalidPdate.Name = "invalidPdate"
        Me.invalidPdate.Size = New System.Drawing.Size(104, 13)
        Me.invalidPdate.TabIndex = 15
        Me.invalidPdate.Text = "*Invalid Pickup Date"
        Me.invalidPdate.Visible = False
        '
        'invalidDDate
        '
        Me.invalidDDate.AutoSize = True
        Me.invalidDDate.Location = New System.Drawing.Point(285, 274)
        Me.invalidDDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.invalidDDate.Name = "invalidDDate"
        Me.invalidDDate.Size = New System.Drawing.Size(108, 13)
        Me.invalidDDate.TabIndex = 16
        Me.invalidDDate.Text = "*Invalid DropOff Date"
        Me.invalidDDate.Visible = False
        '
        'errorLocation
        '
        Me.errorLocation.AutoSize = True
        Me.errorLocation.Location = New System.Drawing.Point(128, 53)
        Me.errorLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.errorLocation.Name = "errorLocation"
        Me.errorLocation.Size = New System.Drawing.Size(155, 13)
        Me.errorLocation.TabIndex = 17
        Me.errorLocation.Text = "*Please select Branch Lcoation"
        Me.errorLocation.Visible = False
        '
        'invalidPT
        '
        Me.invalidPT.AutoSize = True
        Me.invalidPT.Location = New System.Drawing.Point(40, 333)
        Me.invalidPT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.invalidPT.Name = "invalidPT"
        Me.invalidPT.Size = New System.Drawing.Size(111, 13)
        Me.invalidPT.TabIndex = 18
        Me.invalidPT.Text = "*Please Select a Time"
        Me.invalidPT.Visible = False
        '
        'InvalidDT
        '
        Me.InvalidDT.AutoSize = True
        Me.InvalidDT.Location = New System.Drawing.Point(288, 333)
        Me.InvalidDT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InvalidDT.Name = "InvalidDT"
        Me.InvalidDT.Size = New System.Drawing.Size(111, 13)
        Me.InvalidDT.TabIndex = 19
        Me.InvalidDT.Text = "*Please Select a Time"
        Me.InvalidDT.Visible = False
        '
        'ChooseLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 464)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
