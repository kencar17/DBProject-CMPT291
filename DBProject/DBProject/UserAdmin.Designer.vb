<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAdmin
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
        Me.NewButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(84, 12)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(88, 23)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Text = "Add New User"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(84, 42)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(88, 23)
        Me.RemoveButton.TabIndex = 1
        Me.RemoveButton.Text = "Delete a User"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(84, 72)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(88, 23)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update a User"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'UserAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 108)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.NewButton)
        Me.Name = "UserAdmin"
        Me.Text = "User Administration"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents UpdateButton As Button
End Class
