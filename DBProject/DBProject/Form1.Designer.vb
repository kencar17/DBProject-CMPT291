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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(593, 273)
        Me.UserBox.Margin = New System.Windows.Forms.Padding(6)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(180, 29)
        Me.UserBox.TabIndex = 2
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(593, 321)
        Me.PassBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(180, 29)
        Me.PassBox.TabIndex = 3
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(593, 417)
        Me.SignInButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(180, 42)
        Me.SignInButton.TabIndex = 1
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'NotFoundLabel
        '
        Me.NotFoundLabel.AutoSize = True
        Me.NotFoundLabel.ForeColor = System.Drawing.Color.Red
        Me.NotFoundLabel.Location = New System.Drawing.Point(582, 371)
        Me.NotFoundLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NotFoundLabel.Name = "NotFoundLabel"
        Me.NotFoundLabel.Size = New System.Drawing.Size(75, 25)
        Me.NotFoundLabel.TabIndex = 4
        Me.NotFoundLabel.Text = "found it"
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(593, 471)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(180, 42)
        Me.CheckButton.TabIndex = 4
        Me.CheckButton.Text = "View Inventory"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(593, 631)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(180, 42)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(593, 578)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(180, 42)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'RateButton
        '
        Me.RateButton.Location = New System.Drawing.Point(593, 524)
        Me.RateButton.Margin = New System.Windows.Forms.Padding(6)
        Me.RateButton.Name = "RateButton"
        Me.RateButton.Size = New System.Drawing.Size(180, 42)
        Me.RateButton.TabIndex = 5
        Me.RateButton.Text = "Give Feedback"
        Me.RateButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.RateButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.NotFoundLabel)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Car Rental"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
