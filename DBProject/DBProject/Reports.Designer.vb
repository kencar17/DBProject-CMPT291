<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.ViewUsersButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.FeedbackButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BothOption = New System.Windows.Forms.RadioButton()
        Me.ExcelOption = New System.Windows.Forms.RadioButton()
        Me.PDFOption = New System.Windows.Forms.RadioButton()
        Me.BranchButton = New System.Windows.Forms.Button()
        Me.TypeButton = New System.Windows.Forms.Button()
        Me.VehicleButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewUsersButton
        '
        Me.ViewUsersButton.Location = New System.Drawing.Point(525, 277)
        Me.ViewUsersButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ViewUsersButton.Name = "ViewUsersButton"
        Me.ViewUsersButton.Size = New System.Drawing.Size(138, 42)
        Me.ViewUsersButton.TabIndex = 0
        Me.ViewUsersButton.Text = "Users"
        Me.ViewUsersButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(525, 616)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(138, 42)
        Me.HelpButton.TabIndex = 1
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(674, 616)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(138, 42)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'FeedbackButton
        '
        Me.FeedbackButton.Location = New System.Drawing.Point(525, 332)
        Me.FeedbackButton.Margin = New System.Windows.Forms.Padding(6)
        Me.FeedbackButton.Name = "FeedbackButton"
        Me.FeedbackButton.Size = New System.Drawing.Size(138, 42)
        Me.FeedbackButton.TabIndex = 3
        Me.FeedbackButton.Text = "Feedback"
        Me.FeedbackButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BothOption)
        Me.Panel1.Controls.Add(Me.ExcelOption)
        Me.Panel1.Controls.Add(Me.PDFOption)
        Me.Panel1.Location = New System.Drawing.Point(711, 277)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(114, 185)
        Me.Panel1.TabIndex = 4
        '
        'BothOption
        '
        Me.BothOption.AutoSize = True
        Me.BothOption.Location = New System.Drawing.Point(7, 92)
        Me.BothOption.Margin = New System.Windows.Forms.Padding(6)
        Me.BothOption.Name = "BothOption"
        Me.BothOption.Size = New System.Drawing.Size(77, 29)
        Me.BothOption.TabIndex = 2
        Me.BothOption.Text = "Both"
        Me.BothOption.UseVisualStyleBackColor = True
        '
        'ExcelOption
        '
        Me.ExcelOption.AutoSize = True
        Me.ExcelOption.Location = New System.Drawing.Point(7, 50)
        Me.ExcelOption.Margin = New System.Windows.Forms.Padding(6)
        Me.ExcelOption.Name = "ExcelOption"
        Me.ExcelOption.Size = New System.Drawing.Size(85, 29)
        Me.ExcelOption.TabIndex = 1
        Me.ExcelOption.Text = "Excel"
        Me.ExcelOption.UseVisualStyleBackColor = True
        '
        'PDFOption
        '
        Me.PDFOption.AutoSize = True
        Me.PDFOption.Checked = True
        Me.PDFOption.Location = New System.Drawing.Point(7, 7)
        Me.PDFOption.Margin = New System.Windows.Forms.Padding(6)
        Me.PDFOption.Name = "PDFOption"
        Me.PDFOption.Size = New System.Drawing.Size(76, 29)
        Me.PDFOption.TabIndex = 0
        Me.PDFOption.TabStop = True
        Me.PDFOption.Text = "PDF"
        Me.PDFOption.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Location = New System.Drawing.Point(525, 388)
        Me.BranchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(138, 42)
        Me.BranchButton.TabIndex = 5
        Me.BranchButton.Text = "Branches"
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'TypeButton
        '
        Me.TypeButton.Location = New System.Drawing.Point(524, 441)
        Me.TypeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.TypeButton.Name = "TypeButton"
        Me.TypeButton.Size = New System.Drawing.Size(139, 42)
        Me.TypeButton.TabIndex = 6
        Me.TypeButton.Text = "Types"
        Me.TypeButton.UseVisualStyleBackColor = True
        '
        'VehicleButton
        '
        Me.VehicleButton.Location = New System.Drawing.Point(525, 495)
        Me.VehicleButton.Margin = New System.Windows.Forms.Padding(6)
        Me.VehicleButton.Name = "VehicleButton"
        Me.VehicleButton.Size = New System.Drawing.Size(138, 42)
        Me.VehicleButton.TabIndex = 7
        Me.VehicleButton.Text = "Vehicles"
        Me.VehicleButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.VehicleButton)
        Me.Controls.Add(Me.TypeButton)
        Me.Controls.Add(Me.BranchButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FeedbackButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.ViewUsersButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewUsersButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents FeedbackButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BothOption As RadioButton
    Friend WithEvents ExcelOption As RadioButton
    Friend WithEvents PDFOption As RadioButton
    Friend WithEvents BranchButton As Button
    Friend WithEvents TypeButton As Button
    Friend WithEvents VehicleButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
