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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewUsersButton
        '
        Me.ViewUsersButton.Location = New System.Drawing.Point(250, 138)
        Me.ViewUsersButton.Name = "ViewUsersButton"
        Me.ViewUsersButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewUsersButton.TabIndex = 0
        Me.ViewUsersButton.Text = "Users"
        Me.ViewUsersButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(250, 322)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 1
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(331, 322)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'FeedbackButton
        '
        Me.FeedbackButton.Location = New System.Drawing.Point(250, 168)
        Me.FeedbackButton.Name = "FeedbackButton"
        Me.FeedbackButton.Size = New System.Drawing.Size(75, 23)
        Me.FeedbackButton.TabIndex = 3
        Me.FeedbackButton.Text = "Feedback"
        Me.FeedbackButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BothOption)
        Me.Panel1.Controls.Add(Me.ExcelOption)
        Me.Panel1.Controls.Add(Me.PDFOption)
        Me.Panel1.Location = New System.Drawing.Point(351, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 100)
        Me.Panel1.TabIndex = 4
        '
        'BothOption
        '
        Me.BothOption.AutoSize = True
        Me.BothOption.Location = New System.Drawing.Point(4, 50)
        Me.BothOption.Name = "BothOption"
        Me.BothOption.Size = New System.Drawing.Size(47, 17)
        Me.BothOption.TabIndex = 2
        Me.BothOption.Text = "Both"
        Me.BothOption.UseVisualStyleBackColor = True
        '
        'ExcelOption
        '
        Me.ExcelOption.AutoSize = True
        Me.ExcelOption.Location = New System.Drawing.Point(4, 27)
        Me.ExcelOption.Name = "ExcelOption"
        Me.ExcelOption.Size = New System.Drawing.Size(51, 17)
        Me.ExcelOption.TabIndex = 1
        Me.ExcelOption.Text = "Excel"
        Me.ExcelOption.UseVisualStyleBackColor = True
        '
        'PDFOption
        '
        Me.PDFOption.AutoSize = True
        Me.PDFOption.Checked = True
        Me.PDFOption.Location = New System.Drawing.Point(4, 4)
        Me.PDFOption.Name = "PDFOption"
        Me.PDFOption.Size = New System.Drawing.Size(46, 17)
        Me.PDFOption.TabIndex = 0
        Me.PDFOption.TabStop = True
        Me.PDFOption.Text = "PDF"
        Me.PDFOption.UseVisualStyleBackColor = True
        '
        'BranchButton
        '
        Me.BranchButton.Location = New System.Drawing.Point(250, 198)
        Me.BranchButton.Name = "BranchButton"
        Me.BranchButton.Size = New System.Drawing.Size(75, 23)
        Me.BranchButton.TabIndex = 5
        Me.BranchButton.Text = "Branches"
        Me.BranchButton.UseVisualStyleBackColor = True
        '
        'TypeButton
        '
        Me.TypeButton.Location = New System.Drawing.Point(249, 227)
        Me.TypeButton.Name = "TypeButton"
        Me.TypeButton.Size = New System.Drawing.Size(76, 23)
        Me.TypeButton.TabIndex = 6
        Me.TypeButton.Text = "Types"
        Me.TypeButton.UseVisualStyleBackColor = True
        '
        'VehicleButton
        '
        Me.VehicleButton.Location = New System.Drawing.Point(250, 256)
        Me.VehicleButton.Name = "VehicleButton"
        Me.VehicleButton.Size = New System.Drawing.Size(75, 23)
        Me.VehicleButton.TabIndex = 7
        Me.VehicleButton.Text = "Vehicles"
        Me.VehicleButton.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.VehicleButton)
        Me.Controls.Add(Me.TypeButton)
        Me.Controls.Add(Me.BranchButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FeedbackButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.ViewUsersButton)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
