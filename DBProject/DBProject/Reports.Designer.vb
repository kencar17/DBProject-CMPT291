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
        Me.SuspendLayout()
        '
        'ViewUsersButton
        '
        Me.ViewUsersButton.Location = New System.Drawing.Point(13, 13)
        Me.ViewUsersButton.Name = "ViewUsersButton"
        Me.ViewUsersButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewUsersButton.TabIndex = 0
        Me.ViewUsersButton.Text = "View Users"
        Me.ViewUsersButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(13, 197)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 1
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(13, 226)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 261)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.ViewUsersButton)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewUsersButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents CloseButton As Button
End Class
