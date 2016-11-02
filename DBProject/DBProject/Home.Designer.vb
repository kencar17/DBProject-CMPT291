<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(12, 12)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(80, 23)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "Register User"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RegisterButton)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterButton As Button
End Class
