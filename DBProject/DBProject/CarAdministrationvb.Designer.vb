<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarAdministrationvb
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
        Me.AddVehicleB = New System.Windows.Forms.Button()
        Me.RemoveVehicleB = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddVehicleB
        '
        Me.AddVehicleB.Location = New System.Drawing.Point(12, 28)
        Me.AddVehicleB.Name = "AddVehicleB"
        Me.AddVehicleB.Size = New System.Drawing.Size(204, 48)
        Me.AddVehicleB.TabIndex = 0
        Me.AddVehicleB.Text = "Add Vehicle"
        Me.AddVehicleB.UseVisualStyleBackColor = True
        '
        'RemoveVehicleB
        '
        Me.RemoveVehicleB.Location = New System.Drawing.Point(12, 136)
        Me.RemoveVehicleB.Name = "RemoveVehicleB"
        Me.RemoveVehicleB.Size = New System.Drawing.Size(204, 48)
        Me.RemoveVehicleB.TabIndex = 3
        Me.RemoveVehicleB.Text = "Remove Vehicle"
        Me.RemoveVehicleB.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 461)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(204, 48)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseCompatibleTextRendering = True
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(12, 82)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(204, 48)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "Update Vehicle"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CarAdministrationvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 521)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RemoveVehicleB)
        Me.Controls.Add(Me.AddVehicleB)
        Me.Name = "CarAdministrationvb"
        Me.Text = "CarAdministrationvb"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddVehicleB As Button
    Friend WithEvents RemoveVehicleB As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents UpdateButton As Button
End Class
