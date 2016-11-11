<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrder
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
        Me.VOl1 = New System.Windows.Forms.Label()
        Me.VOt1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'VOl1
        '
        Me.VOl1.AutoSize = True
        Me.VOl1.Location = New System.Drawing.Point(37, 22)
        Me.VOl1.Name = "VOl1"
        Me.VOl1.Size = New System.Drawing.Size(147, 25)
        Me.VOl1.TabIndex = 0
        Me.VOl1.Text = "Order Number"
        '
        'VOt1
        '
        Me.VOt1.Location = New System.Drawing.Point(190, 22)
        Me.VOt1.Name = "VOt1"
        Me.VOt1.Size = New System.Drawing.Size(100, 31)
        Me.VOt1.TabIndex = 1
        '
        'ViewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 662)
        Me.Controls.Add(Me.VOt1)
        Me.Controls.Add(Me.VOl1)
        Me.Name = "ViewOrder"
        Me.Text = "ViewOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VOl1 As Label
    Friend WithEvents VOt1 As TextBox
End Class
