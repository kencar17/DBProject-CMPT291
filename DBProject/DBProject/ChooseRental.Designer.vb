<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseRental
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

        Me.vehicleTable = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.typeCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.makeCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.seatsCombo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BothRadio = New System.Windows.Forms.RadioButton()
        Me.autoRadio = New System.Windows.Forms.RadioButton()
        Me.stanRadio = New System.Windows.Forms.RadioButton()
        Me.backButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.VehiclePicture = New System.Windows.Forms.PictureBox()
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vehicleTable
        '
        Me.vehicleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicleTable.Location = New System.Drawing.Point(28, 106)
        Me.vehicleTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.vehicleTable.MinimumSize = New System.Drawing.Size(571, 288)
        Me.vehicleTable.MultiSelect = False
        Me.vehicleTable.Name = "vehicleTable"
        Me.vehicleTable.ReadOnly = True
        Me.vehicleTable.RowTemplate.Height = 31
        Me.vehicleTable.Size = New System.Drawing.Size(665, 288)
        Me.vehicleTable.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Type:"
        '
        'typeCombo
        '
        Me.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeCombo.FormattingEnabled = True
        Me.typeCombo.Location = New System.Drawing.Point(111, 20)
        Me.typeCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.typeCombo.Name = "typeCombo"
        Me.typeCombo.Size = New System.Drawing.Size(98, 21)
        Me.typeCombo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choose Make:"
        '
        'makeCombo
        '
        Me.makeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.makeCombo.FormattingEnabled = True
        Me.makeCombo.Location = New System.Drawing.Point(111, 47)
        Me.makeCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.makeCombo.Name = "makeCombo"
        Me.makeCombo.Size = New System.Drawing.Size(98, 21)
        Me.makeCombo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Seats:"
        '
        'seatsCombo
        '
        Me.seatsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seatsCombo.FormattingEnabled = True
        Me.seatsCombo.Location = New System.Drawing.Point(111, 74)
        Me.seatsCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.seatsCombo.Name = "seatsCombo"
        Me.seatsCombo.Size = New System.Drawing.Size(98, 21)
        Me.seatsCombo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Transmission:"
        '
        'BothRadio
        '
        Me.BothRadio.AutoSize = True
        Me.BothRadio.Location = New System.Drawing.Point(253, 44)
        Me.BothRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BothRadio.Name = "BothRadio"
        Me.BothRadio.Size = New System.Drawing.Size(47, 17)
        Me.BothRadio.TabIndex = 8
        Me.BothRadio.TabStop = True
        Me.BothRadio.Text = "Both"
        Me.BothRadio.UseVisualStyleBackColor = True
        '
        'autoRadio
        '
        Me.autoRadio.AutoSize = True
        Me.autoRadio.Location = New System.Drawing.Point(314, 44)
        Me.autoRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.autoRadio.Name = "autoRadio"
        Me.autoRadio.Size = New System.Drawing.Size(72, 17)
        Me.autoRadio.TabIndex = 9
        Me.autoRadio.TabStop = True
        Me.autoRadio.Text = "Automatic"
        Me.autoRadio.UseVisualStyleBackColor = True
        '
        'stanRadio
        '
        Me.stanRadio.AutoSize = True
        Me.stanRadio.Location = New System.Drawing.Point(394, 44)
        Me.stanRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stanRadio.Name = "stanRadio"
        Me.stanRadio.Size = New System.Drawing.Size(68, 17)
        Me.stanRadio.TabIndex = 10
        Me.stanRadio.TabStop = True
        Me.stanRadio.Text = "Standard"
        Me.stanRadio.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(28, 412)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(51, 22)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(642, 412)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(51, 22)
        Me.nextButton.TabIndex = 12
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(98, 412)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(51, 22)
        Me.helpButton.TabIndex = 13
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'VehiclePicture
        '
        Me.VehiclePicture.Location = New System.Drawing.Point(580, 20)
        Me.VehiclePicture.Name = "VehiclePicture"
        Me.VehiclePicture.Size = New System.Drawing.Size(113, 75)
        Me.VehiclePicture.TabIndex = 14
        Me.VehiclePicture.TabStop = False
        '
        'ChooseRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 487)
        Me.Controls.Add(Me.VehiclePicture)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.stanRadio)
        Me.Controls.Add(Me.autoRadio)
        Me.Controls.Add(Me.BothRadio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.seatsCombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.makeCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.typeCombo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vehicleTable)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ChooseRental"
        Me.Text = "ChooseRental"
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents vehicleTable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents typeCombo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents makeCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents seatsCombo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BothRadio As RadioButton
    Friend WithEvents autoRadio As RadioButton
    Friend WithEvents stanRadio As RadioButton
    Friend WithEvents backButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents VehiclePicture As PictureBox
End Class
