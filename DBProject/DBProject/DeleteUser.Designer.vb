<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
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
        Me.UserSelection = New System.Windows.Forms.ComboBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserSelection
        '
        Me.UserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserSelection.FormattingEnabled = True
        Me.UserSelection.Location = New System.Drawing.Point(69, 12)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(121, 21)
        Me.UserSelection.TabIndex = 0
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(94, 39)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(94, 68)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(75, 23)
        Me.DoneButton.TabIndex = 2
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 103)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UserSelection)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserSelection As ComboBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents DoneButton As Button
End Class
