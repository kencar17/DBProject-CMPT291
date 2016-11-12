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
        Me.VINRemoveBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RMVButton
        '
        Me.RMVButton.Location = New System.Drawing.Point(392, 101)
        Me.RMVButton.Name = "RMVButton"
        Me.RMVButton.Size = New System.Drawing.Size(152, 42)
        Me.RMVButton.TabIndex = 0
        Me.RMVButton.Text = "Remove"
        Me.RMVButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Remove a vehicle from the database"
        '
        'VINRemoveBox
        '
        Me.VINRemoveBox.Location = New System.Drawing.Point(17, 101)
        Me.VINRemoveBox.Name = "VINRemoveBox"
        Me.VINRemoveBox.Size = New System.Drawing.Size(369, 31)
        Me.VINRemoveBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter the VIN of the vehicle to remove"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(83, 150)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(240, 31)
        Me.ErrorLabel.TabIndex = 4
        Me.ErrorLabel.Text = "Invalid Argurments"
        Me.ErrorLabel.Visible = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(17, 411)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(154, 65)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(177, 411)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(154, 65)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'RemoveVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 488)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VINRemoveBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RMVButton)
        Me.Name = "RemoveVehicle"
        Me.Text = "RemoveVehicle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMVButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents VINRemoveBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents HelpButton As Button
End Class
