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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.VinBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'RMVButton
        '
        Me.RMVButton.Location = New System.Drawing.Point(401, 164)
        Me.RMVButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RMVButton.Name = "RMVButton"
        Me.RMVButton.Size = New System.Drawing.Size(76, 22)
        Me.RMVButton.TabIndex = 0
        Me.RMVButton.Text = "Remove"
        Me.RMVButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Remove a vehicle from the database"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(247, 189)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(125, 17)
        Me.ErrorLabel.TabIndex = 4
        Me.ErrorLabel.Text = "Invalid Argurments"
        Me.ErrorLabel.Visible = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(213, 270)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(77, 34)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(319, 270)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(77, 34)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'VinBox
        '
        Me.VinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VinBox.FormattingEnabled = True
        Me.VinBox.Location = New System.Drawing.Point(213, 164)
        Me.VinBox.Name = "VinBox"
        Me.VinBox.Size = New System.Drawing.Size(183, 21)
        Me.VinBox.TabIndex = 7
        '
        'RemoveVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.VinBox)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RMVButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RemoveVehicle"
        Me.Text = "RemoveVehicle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMVButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents VinBox As ComboBox
End Class
