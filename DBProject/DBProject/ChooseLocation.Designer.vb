﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.timeComboOne = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timeComboTwo = New System.Windows.Forms.ComboBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
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
        Me.locationCombBox.Size = New System.Drawing.Size(255, 32)
        Me.locationCombBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick up:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(479, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drop Off:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:"
        '
        'timeComboOne
        '
        Me.timeComboOne.FormattingEnabled = True
        Me.timeComboOne.Location = New System.Drawing.Point(74, 478)
        Me.timeComboOne.Name = "timeComboOne"
        Me.timeComboOne.Size = New System.Drawing.Size(190, 32)
        Me.timeComboOne.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time:"
        '
        'timeComboTwo
        '
        Me.timeComboTwo.FormattingEnabled = True
        Me.timeComboTwo.Location = New System.Drawing.Point(484, 478)
        Me.timeComboTwo.Name = "timeComboTwo"
        Me.timeComboTwo.Size = New System.Drawing.Size(195, 32)
        Me.timeComboTwo.TabIndex = 9
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(709, 575)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(128, 39)
        Me.nextButton.TabIndex = 10
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(74, 575)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(96, 39)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(74, 138)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(484, 138)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 13
        '
        'ChooseLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 709)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.timeComboTwo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.timeComboOne)
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
    Friend WithEvents timeComboOne As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents timeComboTwo As ComboBox
    Friend WithEvents nextButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
End Class
