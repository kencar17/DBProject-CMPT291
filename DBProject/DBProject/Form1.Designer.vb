<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.NotFoundLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(75, 12)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(100, 20)
        Me.UserBox.TabIndex = 0
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(75, 38)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(100, 20)
        Me.PassBox.TabIndex = 1
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(12, 103)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(75, 23)
        Me.SignInButton.TabIndex = 2
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(164, 103)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 3
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'NotFoundLabel
        '
        Me.NotFoundLabel.AutoSize = True
        Me.NotFoundLabel.ForeColor = System.Drawing.Color.Red
        Me.NotFoundLabel.Location = New System.Drawing.Point(87, 129)
        Me.NotFoundLabel.Name = "NotFoundLabel"
        Me.NotFoundLabel.Size = New System.Drawing.Size(0, 13)
        Me.NotFoundLabel.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 179)
        Me.Controls.Add(Me.NotFoundLabel)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Car Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents SignInButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents NotFoundLabel As Label
End Class
