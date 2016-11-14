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
        Me.NotFoundLabel = New System.Windows.Forms.Label()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.RateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(520, 260)
        Me.UserBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(196, 31)
        Me.UserBox.TabIndex = 0
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(520, 310)
        Me.PassBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(196, 31)
        Me.PassBox.TabIndex = 1
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(520, 362)
        Me.SignInButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(200, 44)
        Me.SignInButton.TabIndex = 2
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'NotFoundLabel
        '
        Me.NotFoundLabel.AutoSize = True
        Me.NotFoundLabel.ForeColor = System.Drawing.Color.Red
        Me.NotFoundLabel.Location = New System.Drawing.Point(24, 273)
        Me.NotFoundLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NotFoundLabel.Name = "NotFoundLabel"
        Me.NotFoundLabel.Size = New System.Drawing.Size(0, 25)
        Me.NotFoundLabel.TabIndex = 4
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(520, 417)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(200, 44)
        Me.CheckButton.TabIndex = 5
        Me.CheckButton.Text = "View Inventory"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(520, 585)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(200, 44)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(520, 529)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(200, 44)
        Me.HelpButton.TabIndex = 7
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'RateButton
        '
        Me.RateButton.Location = New System.Drawing.Point(520, 473)
        Me.RateButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RateButton.Name = "RateButton"
        Me.RateButton.Size = New System.Drawing.Size(200, 44)
        Me.RateButton.TabIndex = 8
        Me.RateButton.Text = "Give Feedback"
        Me.RateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 848)
        Me.Controls.Add(Me.RateButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.NotFoundLabel)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Car Rental"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents SignInButton As Button
    Friend WithEvents NotFoundLabel As Label
    Friend WithEvents CheckButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents RateButton As Button
End Class
