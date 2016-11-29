<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteBranch
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
        Me.BranchSelection = New System.Windows.Forms.ComboBox()
        Me.HButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchSelection
        '
        Me.BranchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchSelection.FormattingEnabled = True
        Me.BranchSelection.Location = New System.Drawing.Point(430, 396)
        Me.BranchSelection.Margin = New System.Windows.Forms.Padding(6)
        Me.BranchSelection.Name = "BranchSelection"
        Me.BranchSelection.Size = New System.Drawing.Size(497, 32)
        Me.BranchSelection.TabIndex = 0
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(430, 445)
        Me.HButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(138, 42)
        Me.HButton.TabIndex = 1
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(612, 445)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(138, 42)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(793, 445)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(138, 42)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(606, 493)
        Me.ErrLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(71, 25)
        Me.ErrLabel.TabIndex = 4
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
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
        'DeleteBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.BranchSelection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "DeleteBranch"
        Me.Text = "DeleteBranch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BranchSelection As ComboBox
    Friend WithEvents HButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
