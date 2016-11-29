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
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.typeCombo = New System.Windows.Forms.ComboBox()
        Me.makeLabel = New System.Windows.Forms.Label()
        Me.makeCombo = New System.Windows.Forms.ComboBox()
        Me.seatsLabel = New System.Windows.Forms.Label()
        Me.seatsCombo = New System.Windows.Forms.ComboBox()
        Me.transmissionLabel = New System.Windows.Forms.Label()
        Me.BothRadio = New System.Windows.Forms.RadioButton()
        Me.autoRadio = New System.Windows.Forms.RadioButton()
        Me.stanRadio = New System.Windows.Forms.RadioButton()
        Me.backButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.VehiclePicture = New System.Windows.Forms.PictureBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vehicleTable
        '
        Me.vehicleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicleTable.Location = New System.Drawing.Point(59, 292)
        Me.vehicleTable.Margin = New System.Windows.Forms.Padding(4)
        Me.vehicleTable.MinimumSize = New System.Drawing.Size(1047, 532)
        Me.vehicleTable.MultiSelect = False
        Me.vehicleTable.Name = "vehicleTable"
        Me.vehicleTable.ReadOnly = True
        Me.vehicleTable.RowTemplate.Height = 31
        Me.vehicleTable.Size = New System.Drawing.Size(1219, 532)
        Me.vehicleTable.TabIndex = 0
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(53, 150)
        Me.typeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(137, 25)
        Me.typeLabel.TabIndex = 1
        Me.typeLabel.Text = "Choose Type:"
        '
        'typeCombo
        '
        Me.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeCombo.FormattingEnabled = True
        Me.typeCombo.Location = New System.Drawing.Point(209, 144)
        Me.typeCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.typeCombo.Name = "typeCombo"
        Me.typeCombo.Size = New System.Drawing.Size(176, 32)
        Me.typeCombo.TabIndex = 2
        '
        'makeLabel
        '
        Me.makeLabel.AutoSize = True
        Me.makeLabel.Location = New System.Drawing.Point(53, 196)
        Me.makeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.makeLabel.Name = "makeLabel"
        Me.makeLabel.Size = New System.Drawing.Size(141, 25)
        Me.makeLabel.TabIndex = 3
        Me.makeLabel.Text = "Choose Make:"
        '
        'makeCombo
        '
        Me.makeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.makeCombo.FormattingEnabled = True
        Me.makeCombo.Location = New System.Drawing.Point(209, 190)
        Me.makeCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.makeCombo.Name = "makeCombo"
        Me.makeCombo.Size = New System.Drawing.Size(176, 32)
        Me.makeCombo.TabIndex = 4
        '
        'seatsLabel
        '
        Me.seatsLabel.AutoSize = True
        Me.seatsLabel.Location = New System.Drawing.Point(53, 242)
        Me.seatsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.seatsLabel.Name = "seatsLabel"
        Me.seatsLabel.Size = New System.Drawing.Size(69, 25)
        Me.seatsLabel.TabIndex = 5
        Me.seatsLabel.Text = "Seats:"
        '
        'seatsCombo
        '
        Me.seatsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seatsCombo.FormattingEnabled = True
        Me.seatsCombo.Location = New System.Drawing.Point(209, 236)
        Me.seatsCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.seatsCombo.Name = "seatsCombo"
        Me.seatsCombo.Size = New System.Drawing.Size(176, 32)
        Me.seatsCombo.TabIndex = 6
        '
        'transmissionLabel
        '
        Me.transmissionLabel.AutoSize = True
        Me.transmissionLabel.Location = New System.Drawing.Point(425, 150)
        Me.transmissionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.transmissionLabel.Name = "transmissionLabel"
        Me.transmissionLabel.Size = New System.Drawing.Size(135, 25)
        Me.transmissionLabel.TabIndex = 7
        Me.transmissionLabel.Text = "Transmission:"
        '
        'BothRadio
        '
        Me.BothRadio.AutoSize = True
        Me.BothRadio.Checked = True
        Me.BothRadio.Location = New System.Drawing.Point(469, 192)
        Me.BothRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.BothRadio.Name = "BothRadio"
        Me.BothRadio.Size = New System.Drawing.Size(77, 29)
        Me.BothRadio.TabIndex = 8
        Me.BothRadio.TabStop = True
        Me.BothRadio.Text = "Both"
        Me.BothRadio.UseVisualStyleBackColor = True
        '
        'autoRadio
        '
        Me.autoRadio.AutoSize = True
        Me.autoRadio.Location = New System.Drawing.Point(563, 192)
        Me.autoRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.autoRadio.Name = "autoRadio"
        Me.autoRadio.Size = New System.Drawing.Size(124, 29)
        Me.autoRadio.TabIndex = 9
        Me.autoRadio.Text = "Automatic"
        Me.autoRadio.UseVisualStyleBackColor = True
        '
        'stanRadio
        '
        Me.stanRadio.AutoSize = True
        Me.stanRadio.Location = New System.Drawing.Point(702, 192)
        Me.stanRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.stanRadio.Name = "stanRadio"
        Me.stanRadio.Size = New System.Drawing.Size(117, 29)
        Me.stanRadio.TabIndex = 10
        Me.stanRadio.Text = "Standard"
        Me.stanRadio.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(59, 846)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(94, 41)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(1184, 846)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(94, 41)
        Me.nextButton.TabIndex = 12
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.Location = New System.Drawing.Point(160, 846)
        Me.helpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(94, 41)
        Me.helpButton.TabIndex = 13
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'VehiclePicture
        '
        Me.VehiclePicture.Location = New System.Drawing.Point(956, 144)
        Me.VehiclePicture.Margin = New System.Windows.Forms.Padding(6)
        Me.VehiclePicture.Name = "VehiclePicture"
        Me.VehiclePicture.Size = New System.Drawing.Size(207, 138)
        Me.VehiclePicture.TabIndex = 14
        Me.VehiclePicture.TabStop = False
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(430, 229)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(192, 41)
        Me.searchButton.TabIndex = 15
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(627, 229)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(192, 41)
        Me.clearButton.TabIndex = 16
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ChooseRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.VehiclePicture)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.stanRadio)
        Me.Controls.Add(Me.autoRadio)
        Me.Controls.Add(Me.BothRadio)
        Me.Controls.Add(Me.transmissionLabel)
        Me.Controls.Add(Me.seatsCombo)
        Me.Controls.Add(Me.seatsLabel)
        Me.Controls.Add(Me.makeCombo)
        Me.Controls.Add(Me.makeLabel)
        Me.Controls.Add(Me.typeCombo)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.vehicleTable)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChooseRental"
        Me.Text = "ChooseRental"
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vehicleTable As DataGridView
    Friend WithEvents typeLabel As Label
    Friend WithEvents typeCombo As ComboBox
    Friend WithEvents makeLabel As Label
    Friend WithEvents makeCombo As ComboBox
    Friend WithEvents seatsLabel As Label
    Friend WithEvents seatsCombo As ComboBox
    Friend WithEvents transmissionLabel As Label
    Friend WithEvents BothRadio As RadioButton
    Friend WithEvents autoRadio As RadioButton
    Friend WithEvents stanRadio As RadioButton
    Friend WithEvents backButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents VehiclePicture As PictureBox
    Friend WithEvents searchButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
