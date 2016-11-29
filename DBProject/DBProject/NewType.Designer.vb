<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewType
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
        Me.TypeBox = New System.Windows.Forms.TextBox()
        Me.DailyRate = New System.Windows.Forms.NumericUpDown()
        Me.dailyLabel = New System.Windows.Forms.Label()
        Me.WeeklyRate = New System.Windows.Forms.NumericUpDown()
        Me.weeklyLabel = New System.Windows.Forms.Label()
        Me.MonthlyRate = New System.Windows.Forms.NumericUpDown()
        Me.monthlyLabel = New System.Windows.Forms.Label()
        Me.HButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DailyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeklyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeBox
        '
        Me.TypeBox.Location = New System.Drawing.Point(238, 180)
        Me.TypeBox.MaxLength = 50
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(260, 20)
        Me.TypeBox.TabIndex = 0
        '
        'DailyRate
        '
        Me.DailyRate.DecimalPlaces = 2
        Me.DailyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.DailyRate.Location = New System.Drawing.Point(379, 206)
        Me.DailyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.DailyRate.Name = "DailyRate"
        Me.DailyRate.Size = New System.Drawing.Size(120, 20)
        Me.DailyRate.TabIndex = 1
        Me.DailyRate.ThousandsSeparator = True
        '
        'dailyLabel
        '
        Me.dailyLabel.AutoSize = True
        Me.dailyLabel.Location = New System.Drawing.Point(236, 209)
        Me.dailyLabel.Name = "dailyLabel"
        Me.dailyLabel.Size = New System.Drawing.Size(56, 13)
        Me.dailyLabel.TabIndex = 2
        Me.dailyLabel.Text = "Daily Rate"
        '
        'WeeklyRate
        '
        Me.WeeklyRate.DecimalPlaces = 2
        Me.WeeklyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.WeeklyRate.Location = New System.Drawing.Point(379, 232)
        Me.WeeklyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.WeeklyRate.Name = "WeeklyRate"
        Me.WeeklyRate.Size = New System.Drawing.Size(120, 20)
        Me.WeeklyRate.TabIndex = 3
        Me.WeeklyRate.ThousandsSeparator = True
        '
        'weeklyLabel
        '
        Me.weeklyLabel.AutoSize = True
        Me.weeklyLabel.Location = New System.Drawing.Point(236, 235)
        Me.weeklyLabel.Name = "weeklyLabel"
        Me.weeklyLabel.Size = New System.Drawing.Size(69, 13)
        Me.weeklyLabel.TabIndex = 4
        Me.weeklyLabel.Text = "Weekly Rate"
        '
        'MonthlyRate
        '
        Me.MonthlyRate.DecimalPlaces = 2
        Me.MonthlyRate.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.MonthlyRate.Location = New System.Drawing.Point(379, 258)
        Me.MonthlyRate.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.MonthlyRate.Name = "MonthlyRate"
        Me.MonthlyRate.Size = New System.Drawing.Size(120, 20)
        Me.MonthlyRate.TabIndex = 5
        Me.MonthlyRate.ThousandsSeparator = True
        '
        'monthlyLabel
        '
        Me.monthlyLabel.AutoSize = True
        Me.monthlyLabel.Location = New System.Drawing.Point(236, 261)
        Me.monthlyLabel.Name = "monthlyLabel"
        Me.monthlyLabel.Size = New System.Drawing.Size(70, 13)
        Me.monthlyLabel.TabIndex = 6
        Me.monthlyLabel.Text = "Monthly Rate"
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(238, 284)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(75, 23)
        Me.HButton.TabIndex = 7
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(331, 284)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 8
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(423, 284)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(331, 315)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrLabel.TabIndex = 10
        Me.ErrLabel.Text = "Label4"
        Me.ErrLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 533)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'NewType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 532)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.monthlyLabel)
        Me.Controls.Add(Me.MonthlyRate)
        Me.Controls.Add(Me.weeklyLabel)
        Me.Controls.Add(Me.WeeklyRate)
        Me.Controls.Add(Me.dailyLabel)
        Me.Controls.Add(Me.DailyRate)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NewType"
        Me.Text = "NewType"
        CType(Me.DailyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeklyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TypeBox As TextBox
    Friend WithEvents DailyRate As NumericUpDown
    Friend WithEvents dailyLabel As Label
    Friend WithEvents WeeklyRate As NumericUpDown
    Friend WithEvents weeklyLabel As Label
    Friend WithEvents MonthlyRate As NumericUpDown
    Friend WithEvents monthlyLabel As Label
    Friend WithEvents HButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
