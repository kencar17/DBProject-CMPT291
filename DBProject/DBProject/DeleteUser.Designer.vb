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
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserSelection
        '
        Me.UserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserSelection.FormattingEnabled = True
        Me.UserSelection.Location = New System.Drawing.Point(443, 431)
        Me.UserSelection.Margin = New System.Windows.Forms.Padding(6)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(488, 32)
        Me.UserSelection.TabIndex = 0
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(619, 481)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(138, 42)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(797, 481)
        Me.DoneButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(138, 42)
        Me.DoneButton.TabIndex = 2
        Me.DoneButton.Text = "Close"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(443, 481)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(138, 42)
        Me.HelpButton.TabIndex = 3
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UserSelection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserSelection As ComboBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents DoneButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
