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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(604, 355)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(158, 42)
        Me.CreateButton.TabIndex = 0
        Me.CreateButton.Text = "Create a Type"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(604, 410)
        Me.ModifyButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(158, 42)
        Me.ModifyButton.TabIndex = 1
        Me.ModifyButton.Text = "Modify a Type"
        Me.ModifyButton.UseVisualStyleBackColor = True
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(604, 466)
        Me.HButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(158, 42)
        Me.HButton.TabIndex = 2
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(604, 521)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(158, 42)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TypesAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.ModifyButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "TypesAdministration"
        Me.Text = "TypesAdministration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateButton As Button
    Friend WithEvents ModifyButton As Button
    Friend WithEvents HButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
