<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveVehicle
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
        Me.RMVButton = New System.Windows.Forms.Button()
        Me.removeLabel = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.VinBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RMVButton
        '
        Me.RMVButton.Location = New System.Drawing.Point(614, 410)
        Me.RMVButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RMVButton.Name = "RMVButton"
        Me.RMVButton.Size = New System.Drawing.Size(139, 41)
        Me.RMVButton.TabIndex = 0
        Me.RMVButton.Text = "Remove"
        Me.RMVButton.UseVisualStyleBackColor = True
        '
        'removeLabel
        '
        Me.removeLabel.AutoSize = True
        Me.removeLabel.Location = New System.Drawing.Point(507, 249)
        Me.removeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.removeLabel.Name = "removeLabel"
        Me.removeLabel.Size = New System.Drawing.Size(327, 25)
        Me.removeLabel.TabIndex = 1
        Me.removeLabel.Text = "Remove a vehicle from the database"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(575, 356)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(211, 29)
        Me.ErrorLabel.TabIndex = 4
        Me.ErrorLabel.Text = "Invalid Argurments"
        Me.ErrorLabel.Visible = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(513, 505)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(141, 63)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(707, 505)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(141, 63)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'VinBox
        '
        Me.VinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VinBox.FormattingEnabled = True
        Me.VinBox.Location = New System.Drawing.Point(513, 310)
        Me.VinBox.Margin = New System.Windows.Forms.Padding(6)
        Me.VinBox.Name = "VinBox"
        Me.VinBox.Size = New System.Drawing.Size(332, 32)
        Me.VinBox.TabIndex = 7
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
        'RemoveVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.VinBox)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.removeLabel)
        Me.Controls.Add(Me.RMVButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RemoveVehicle"
        Me.Text = "RemoveVehicle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMVButton As Button
    Friend WithEvents removeLabel As Label
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents VinBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
