<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateVehicle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VINUpdate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.ClassBox = New System.Windows.Forms.TextBox()
        Me.KmBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.SeatBox = New System.Windows.Forms.TextBox()
        Me.GVWRBox = New System.Windows.Forms.TextBox()
        Me.TransBox = New System.Windows.Forms.TextBox()
        Me.PlateBox = New System.Windows.Forms.TextBox()
        Me.AvailBox = New System.Windows.Forms.TextBox()
        Me.CoverageBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the VIN of the vehicle you want to update"
        '
        'VINUpdate
        '
        Me.VINUpdate.Location = New System.Drawing.Point(18, 56)
        Me.VINUpdate.Name = "VINUpdate"
        Me.VINUpdate.Size = New System.Drawing.Size(295, 31)
        Me.VINUpdate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vehicle Information"
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(171, 182)
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(198, 31)
        Me.MakeBox.TabIndex = 3
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(553, 182)
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(198, 31)
        Me.ModelBox.TabIndex = 4
        '
        'ClassBox
        '
        Me.ClassBox.Location = New System.Drawing.Point(171, 219)
        Me.ClassBox.Name = "ClassBox"
        Me.ClassBox.Size = New System.Drawing.Size(198, 31)
        Me.ClassBox.TabIndex = 5
        '
        'KmBox
        '
        Me.KmBox.Location = New System.Drawing.Point(553, 219)
        Me.KmBox.Name = "KmBox"
        Me.KmBox.Size = New System.Drawing.Size(198, 31)
        Me.KmBox.TabIndex = 6
        '
        'YearBox
        '
        Me.YearBox.Location = New System.Drawing.Point(171, 256)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(198, 31)
        Me.YearBox.TabIndex = 7
        '
        'SeatBox
        '
        Me.SeatBox.Location = New System.Drawing.Point(553, 256)
        Me.SeatBox.Name = "SeatBox"
        Me.SeatBox.Size = New System.Drawing.Size(198, 31)
        Me.SeatBox.TabIndex = 8
        '
        'GVWRBox
        '
        Me.GVWRBox.Location = New System.Drawing.Point(171, 293)
        Me.GVWRBox.Name = "GVWRBox"
        Me.GVWRBox.Size = New System.Drawing.Size(198, 31)
        Me.GVWRBox.TabIndex = 9
        '
        'TransBox
        '
        Me.TransBox.Location = New System.Drawing.Point(553, 293)
        Me.TransBox.Name = "TransBox"
        Me.TransBox.Size = New System.Drawing.Size(198, 31)
        Me.TransBox.TabIndex = 10
        '
        'PlateBox
        '
        Me.PlateBox.Location = New System.Drawing.Point(171, 330)
        Me.PlateBox.Name = "PlateBox"
        Me.PlateBox.Size = New System.Drawing.Size(198, 31)
        Me.PlateBox.TabIndex = 11
        '
        'AvailBox
        '
        Me.AvailBox.Location = New System.Drawing.Point(553, 330)
        Me.AvailBox.Name = "AvailBox"
        Me.AvailBox.Size = New System.Drawing.Size(198, 31)
        Me.AvailBox.TabIndex = 12
        '
        'CoverageBox
        '
        Me.CoverageBox.Location = New System.Drawing.Point(171, 367)
        Me.CoverageBox.Name = "CoverageBox"
        Me.CoverageBox.Size = New System.Drawing.Size(198, 31)
        Me.CoverageBox.TabIndex = 13
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(553, 378)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(198, 58)
        Me.SubmitButton.TabIndex = 16
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(147, 443)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(108, 48)
        Me.BackButton.TabIndex = 17
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(261, 443)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(108, 48)
        Me.HelpButton.TabIndex = 18
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(276, 511)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(204, 25)
        Me.ErrorLabel.TabIndex = 19
        Me.ErrorLabel.Text = "Incorrect Arguments"
        Me.ErrorLabel.Visible = False
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(319, 48)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(161, 47)
        Me.FindButton.TabIndex = 20
        Me.FindButton.Text = "Find Vehicle"
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Coverage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "PlateNum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "GVWR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Class"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(421, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 25)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Availablity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 25)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Transmission"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(460, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 25)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Seats"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(460, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 25)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "KM"
        '
        'UpdateVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 628)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.CoverageBox)
        Me.Controls.Add(Me.AvailBox)
        Me.Controls.Add(Me.PlateBox)
        Me.Controls.Add(Me.TransBox)
        Me.Controls.Add(Me.GVWRBox)
        Me.Controls.Add(Me.SeatBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.KmBox)
        Me.Controls.Add(Me.ClassBox)
        Me.Controls.Add(Me.ModelBox)
        Me.Controls.Add(Me.MakeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VINUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateVehicle"
        Me.Text = "UpdateVehicle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents VINUpdate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents ClassBox As TextBox
    Friend WithEvents KmBox As TextBox
    Friend WithEvents YearBox As TextBox
    Friend WithEvents SeatBox As TextBox
    Friend WithEvents GVWRBox As TextBox
    Friend WithEvents TransBox As TextBox
    Friend WithEvents PlateBox As TextBox
    Friend WithEvents AvailBox As TextBox
    Friend WithEvents CoverageBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents FindButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
