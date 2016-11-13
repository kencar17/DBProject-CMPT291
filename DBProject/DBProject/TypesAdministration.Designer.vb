<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TypesAdministration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.HButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(13, 13)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(86, 23)
        Me.CreateButton.TabIndex = 0
        Me.CreateButton.Text = "Create a Type"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(13, 43)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(86, 23)
        Me.ModifyButton.TabIndex = 1
        Me.ModifyButton.Text = "Modify a Type"
        Me.ModifyButton.UseVisualStyleBackColor = True
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(13, 73)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(86, 23)
        Me.HButton.TabIndex = 2
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(13, 103)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(86, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TypesAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 139)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.ModifyButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Name = "TypesAdministration"
        Me.Text = "TypesAdministration"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateButton As Button
    Friend WithEvents ModifyButton As Button
    Friend WithEvents HButton As Button
    Friend WithEvents CloseButton As Button
End Class
