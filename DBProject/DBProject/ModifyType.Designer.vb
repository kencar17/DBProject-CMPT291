<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyType
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
        Me.TypeSelection = New System.Windows.Forms.ComboBox()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.DailyRate = New System.Windows.Forms.NumericUpDown()
        Me.WeeklyRate = New System.Windows.Forms.NumericUpDown()
        Me.MonthlyRate = New System.Windows.Forms.NumericUpDown()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        CType(Me.DailyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeklyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeSelection
        '
        Me.TypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeSelection.FormattingEnabled = True
        Me.TypeSelection.Location = New System.Drawing.Point(270, 152)
        Me.TypeSelection.Name = "TypeSelection"
        Me.TypeSelection.Size = New System.Drawing.Size(121, 21)
        Me.TypeSelection.TabIndex = 0
        '
        'Type
        '
        Me.Type.Enabled = False
        Me.Type.Location = New System.Drawing.Point(270, 179)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(121, 20)
        Me.Type.TabIndex = 1
        '
        'DailyRate
        '
        Me.DailyRate.DecimalPlaces = 2
        Me.DailyRate.Enabled = False
        Me.DailyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.DailyRate.Location = New System.Drawing.Point(270, 206)
        Me.DailyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.DailyRate.Name = "DailyRate"
        Me.DailyRate.Size = New System.Drawing.Size(121, 20)
        Me.DailyRate.TabIndex = 2
        '
        'WeeklyRate
        '
        Me.WeeklyRate.DecimalPlaces = 2
        Me.WeeklyRate.Enabled = False
        Me.WeeklyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.WeeklyRate.Location = New System.Drawing.Point(270, 233)
        Me.WeeklyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.WeeklyRate.Name = "WeeklyRate"
        Me.WeeklyRate.Size = New System.Drawing.Size(121, 20)
        Me.WeeklyRate.TabIndex = 3
        '
        'MonthlyRate
        '
        Me.MonthlyRate.DecimalPlaces = 2
        Me.MonthlyRate.Enabled = False
        Me.MonthlyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.MonthlyRate.Location = New System.Drawing.Point(270, 260)
        Me.MonthlyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.MonthlyRate.Name = "MonthlyRate"
        Me.MonthlyRate.Size = New System.Drawing.Size(121, 20)
        Me.MonthlyRate.TabIndex = 4
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(203, 286)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 5
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(296, 286)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(388, 286)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(296, 316)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrLabel.TabIndex = 8
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
        '
        'ModifyType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.MonthlyRate)
        Me.Controls.Add(Me.WeeklyRate)
        Me.Controls.Add(Me.DailyRate)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.TypeSelection)
        Me.Name = "ModifyType"
        Me.Text = "ModifyType"
        CType(Me.DailyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeklyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TypeSelection As ComboBox
    Friend WithEvents Type As TextBox
    Friend WithEvents DailyRate As NumericUpDown
    Friend WithEvents WeeklyRate As NumericUpDown
    Friend WithEvents MonthlyRate As NumericUpDown
    Friend WithEvents HelpButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
End Class
