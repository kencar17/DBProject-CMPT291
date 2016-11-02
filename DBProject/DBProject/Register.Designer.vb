<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.UserNameBox = New System.Windows.Forms.TextBox()
        Me.UserPassBox = New System.Windows.Forms.TextBox()
        Me.ActualFirstNameBox = New System.Windows.Forms.TextBox()
        Me.ActualLastNameBox = New System.Windows.Forms.TextBox()
        Me.PostBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserNameBox
        '
        Me.UserNameBox.Location = New System.Drawing.Point(12, 12)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameBox.TabIndex = 0
        '
        'UserPassBox
        '
        Me.UserPassBox.Location = New System.Drawing.Point(118, 12)
        Me.UserPassBox.Name = "UserPassBox"
        Me.UserPassBox.Size = New System.Drawing.Size(100, 20)
        Me.UserPassBox.TabIndex = 1
        '
        'ActualFirstNameBox
        '
        Me.ActualFirstNameBox.Location = New System.Drawing.Point(12, 38)
        Me.ActualFirstNameBox.Name = "ActualFirstNameBox"
        Me.ActualFirstNameBox.Size = New System.Drawing.Size(100, 20)
        Me.ActualFirstNameBox.TabIndex = 2
        '
        'ActualLastNameBox
        '
        Me.ActualLastNameBox.Location = New System.Drawing.Point(118, 38)
        Me.ActualLastNameBox.Name = "ActualLastNameBox"
        Me.ActualLastNameBox.Size = New System.Drawing.Size(100, 20)
        Me.ActualLastNameBox.TabIndex = 3
        '
        'PostBox
        '
        Me.PostBox.Location = New System.Drawing.Point(12, 91)
        Me.PostBox.Name = "PostBox"
        Me.PostBox.Size = New System.Drawing.Size(100, 20)
        Me.PostBox.TabIndex = 4
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(13, 65)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(205, 20)
        Me.AddressBox.TabIndex = 5
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(119, 92)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 6
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(13, 118)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(100, 20)
        Me.StateBox.TabIndex = 7
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(120, 118)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryBox.TabIndex = 8
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(13, 145)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailBox.TabIndex = 9
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(120, 142)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 177)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.PostBox)
        Me.Controls.Add(Me.ActualLastNameBox)
        Me.Controls.Add(Me.ActualFirstNameBox)
        Me.Controls.Add(Me.UserPassBox)
        Me.Controls.Add(Me.UserNameBox)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserNameBox As TextBox
    Friend WithEvents UserPassBox As TextBox
    Friend WithEvents ActualFirstNameBox As TextBox
    Friend WithEvents ActualLastNameBox As TextBox
    Friend WithEvents PostBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents SubmitButton As Button
End Class
