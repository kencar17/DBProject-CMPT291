<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBranch
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
        Me.BranchSelection = New System.Windows.Forms.ComboBox()
        Me.HButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BranchSelection
        '
        Me.BranchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchSelection.FormattingEnabled = True
        Me.BranchSelection.Location = New System.Drawing.Point(214, 211)
        Me.BranchSelection.Name = "BranchSelection"
        Me.BranchSelection.Size = New System.Drawing.Size(273, 21)
        Me.BranchSelection.TabIndex = 0
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(214, 238)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(75, 23)
        Me.HButton.TabIndex = 1
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(313, 238)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(412, 238)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ErrLabel
        '
        Me.ErrLabel.AutoSize = True
        Me.ErrLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrLabel.Location = New System.Drawing.Point(310, 264)
        Me.ErrLabel.Name = "ErrLabel"
        Me.ErrLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrLabel.TabIndex = 4
        Me.ErrLabel.Text = "Label1"
        Me.ErrLabel.Visible = False
        '
        'DeleteBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 496)
        Me.Controls.Add(Me.ErrLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.BranchSelection)
        Me.Name = "DeleteBranch"
        Me.Text = "DeleteBranch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BranchSelection As ComboBox
    Friend WithEvents HButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrLabel As Label
End Class
