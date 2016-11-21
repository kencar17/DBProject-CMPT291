<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewVehicle
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VINbox = New System.Windows.Forms.TextBox()
        Me.GVWRBox = New System.Windows.Forms.TextBox()
        Me.PlateBox = New System.Windows.Forms.TextBox()
        Me.CoverageBox = New System.Windows.Forms.TextBox()
        Me.SeatsBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.KMBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.MakeBox = New System.Windows.Forms.TextBox()
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
        Me.addVehicle = New System.Windows.Forms.Button()
        Me.wrongInfo = New System.Windows.Forms.Label()
        Me.GoBack = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ClassCB = New System.Windows.Forms.ComboBox()
        Me.TransCB = New System.Windows.Forms.ComboBox()
        Me.AvailCB = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BranchCB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Vehicle Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VIN"
        '
        'VINbox
        '
        Me.VINbox.Location = New System.Drawing.Point(253, 55)
        Me.VINbox.Name = "VINbox"
        Me.VINbox.Size = New System.Drawing.Size(289, 31)
        Me.VINbox.TabIndex = 1
        '
        'GVWRBox
        '
        Me.GVWRBox.Location = New System.Drawing.Point(253, 321)
        Me.GVWRBox.Name = "GVWRBox"
        Me.GVWRBox.Size = New System.Drawing.Size(289, 31)
        Me.GVWRBox.TabIndex = 8
        '
        'PlateBox
        '
        Me.PlateBox.Location = New System.Drawing.Point(253, 395)
        Me.PlateBox.Name = "PlateBox"
        Me.PlateBox.Size = New System.Drawing.Size(289, 31)
        Me.PlateBox.TabIndex = 10
        '
        'CoverageBox
        '
        Me.CoverageBox.Location = New System.Drawing.Point(253, 469)
        Me.CoverageBox.Name = "CoverageBox"
        Me.CoverageBox.Size = New System.Drawing.Size(289, 31)
        Me.CoverageBox.TabIndex = 12
        '
        'SeatsBox
        '
        Me.SeatsBox.Location = New System.Drawing.Point(253, 284)
        Me.SeatsBox.Name = "SeatsBox"
        Me.SeatsBox.Size = New System.Drawing.Size(289, 31)
        Me.SeatsBox.TabIndex = 7
        '
        'YearBox
        '
        Me.YearBox.Location = New System.Drawing.Point(253, 250)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(289, 31)
        Me.YearBox.TabIndex = 6
        '
        'KMBox
        '
        Me.KMBox.Location = New System.Drawing.Point(253, 215)
        Me.KMBox.Name = "KMBox"
        Me.KMBox.Size = New System.Drawing.Size(289, 31)
        Me.KMBox.TabIndex = 5
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(253, 135)
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(289, 31)
        Me.ModelBox.TabIndex = 3
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(253, 95)
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(289, 31)
        Me.MakeBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Available"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "License Plate Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Transmission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "GVWR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Seating Capacity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Year"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(187, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "KM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Vehicle Class"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(154, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Model"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 475)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 25)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Coverage"
        '
        'addVehicle
        '
        Me.addVehicle.Location = New System.Drawing.Point(356, 597)
        Me.addVehicle.Name = "addVehicle"
        Me.addVehicle.Size = New System.Drawing.Size(186, 50)
        Me.addVehicle.TabIndex = 13
        Me.addVehicle.Text = "Add Vehicle"
        Me.addVehicle.UseVisualStyleBackColor = True
        '
        'wrongInfo
        '
        Me.wrongInfo.AutoSize = True
        Me.wrongInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wrongInfo.ForeColor = System.Drawing.Color.Red
        Me.wrongInfo.Location = New System.Drawing.Point(55, 597)
        Me.wrongInfo.Name = "wrongInfo"
        Me.wrongInfo.Size = New System.Drawing.Size(264, 31)
        Me.wrongInfo.TabIndex = 28
        Me.wrongInfo.Text = "Incorrect Information"
        Me.wrongInfo.Visible = False
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(596, 43)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(186, 50)
        Me.GoBack.TabIndex = 29
        Me.GoBack.Text = "Back"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(596, 99)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(186, 50)
        Me.HelpButton.TabIndex = 30
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ClassCB
        '
        Me.ClassCB.FormattingEnabled = True
        Me.ClassCB.Location = New System.Drawing.Point(253, 175)
        Me.ClassCB.Name = "ClassCB"
        Me.ClassCB.Size = New System.Drawing.Size(289, 33)
        Me.ClassCB.TabIndex = 4
        '
        'TransCB
        '
        Me.TransCB.FormattingEnabled = True
        Me.TransCB.Location = New System.Drawing.Point(253, 359)
        Me.TransCB.Name = "TransCB"
        Me.TransCB.Size = New System.Drawing.Size(289, 33)
        Me.TransCB.TabIndex = 9
        '
        'AvailCB
        '
        Me.AvailCB.FormattingEnabled = True
        Me.AvailCB.Location = New System.Drawing.Point(253, 433)
        Me.AvailCB.Name = "AvailCB"
        Me.AvailCB.Size = New System.Drawing.Size(289, 33)
        Me.AvailCB.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(66, 520)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 25)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Branch Address"
        '
        'BranchCB
        '
        Me.BranchCB.FormattingEnabled = True
        Me.BranchCB.Location = New System.Drawing.Point(253, 512)
        Me.BranchCB.Name = "BranchCB"
        Me.BranchCB.Size = New System.Drawing.Size(289, 33)
        Me.BranchCB.TabIndex = 13
        '
        'AddNewVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 818)
        Me.Controls.Add(Me.BranchCB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.AvailCB)
        Me.Controls.Add(Me.TransCB)
        Me.Controls.Add(Me.ClassCB)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.wrongInfo)
        Me.Controls.Add(Me.addVehicle)
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
        Me.Controls.Add(Me.MakeBox)
        Me.Controls.Add(Me.ModelBox)
        Me.Controls.Add(Me.KMBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.SeatsBox)
        Me.Controls.Add(Me.CoverageBox)
        Me.Controls.Add(Me.PlateBox)
        Me.Controls.Add(Me.GVWRBox)
        Me.Controls.Add(Me.VINbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddNewVehicle"
        Me.Text = "AddNewVehicle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VINbox As TextBox
    Friend WithEvents GVWRBox As TextBox
    Friend WithEvents PlateBox As TextBox
    Friend WithEvents CoverageBox As TextBox
    Friend WithEvents SeatsBox As TextBox
    Friend WithEvents YearBox As TextBox
    Friend WithEvents KMBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents MakeBox As TextBox
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
    Friend WithEvents addVehicle As Button
    Friend WithEvents wrongInfo As Label
    Friend WithEvents GoBack As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents ClassCB As ComboBox
    Friend WithEvents TransCB As ComboBox
    Friend WithEvents AvailCB As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BranchCB As ComboBox
End Class
