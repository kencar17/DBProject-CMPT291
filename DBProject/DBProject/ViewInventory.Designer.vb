<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewInventory
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
        Me.backButton = New System.Windows.Forms.Button()
        Me.stanRadio = New System.Windows.Forms.RadioButton()
        Me.autoRadio = New System.Windows.Forms.RadioButton()
        Me.BothRadio = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seatsCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.makeCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.typeCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vehicleTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(32, 429)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(50, 22)
        Me.backButton.TabIndex = 24
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'stanRadio
        '
        Me.stanRadio.AutoSize = True
        Me.stanRadio.Location = New System.Drawing.Point(398, 60)
        Me.stanRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stanRadio.Name = "stanRadio"
        Me.stanRadio.Size = New System.Drawing.Size(68, 17)
        Me.stanRadio.TabIndex = 23
        Me.stanRadio.TabStop = True
        Me.stanRadio.Text = "Standard"
        Me.stanRadio.UseVisualStyleBackColor = True
        '
        'autoRadio
        '
        Me.autoRadio.AutoSize = True
        Me.autoRadio.Location = New System.Drawing.Point(318, 60)
        Me.autoRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.autoRadio.Name = "autoRadio"
        Me.autoRadio.Size = New System.Drawing.Size(72, 17)
        Me.autoRadio.TabIndex = 22
        Me.autoRadio.TabStop = True
        Me.autoRadio.Text = "Automatic"
        Me.autoRadio.UseVisualStyleBackColor = True
        '
        'BothRadio
        '
        Me.BothRadio.AutoSize = True
        Me.BothRadio.Location = New System.Drawing.Point(256, 61)
        Me.BothRadio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BothRadio.Name = "BothRadio"
        Me.BothRadio.Size = New System.Drawing.Size(47, 17)
        Me.BothRadio.TabIndex = 21
        Me.BothRadio.TabStop = True
        Me.BothRadio.Text = "Both"
        Me.BothRadio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Transmission:"
        '
        'seatsCombo
        '
        Me.seatsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seatsCombo.FormattingEnabled = True
        Me.seatsCombo.Location = New System.Drawing.Point(114, 90)
        Me.seatsCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.seatsCombo.Name = "seatsCombo"
        Me.seatsCombo.Size = New System.Drawing.Size(98, 21)
        Me.seatsCombo.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Seats:"
        '
        'makeCombo
        '
        Me.makeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.makeCombo.FormattingEnabled = True
        Me.makeCombo.Location = New System.Drawing.Point(114, 63)
        Me.makeCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.makeCombo.Name = "makeCombo"
        Me.makeCombo.Size = New System.Drawing.Size(98, 21)
        Me.makeCombo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Choose Make:"
        '
        'typeCombo
        '
        Me.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeCombo.FormattingEnabled = True
        Me.typeCombo.Location = New System.Drawing.Point(114, 36)
        Me.typeCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.typeCombo.Name = "typeCombo"
        Me.typeCombo.Size = New System.Drawing.Size(98, 21)
        Me.typeCombo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Choose Type:"
        '
        'vehicleTable
        '
        Me.vehicleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicleTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column10, Me.Column8, Me.Column9})
        Me.vehicleTable.Location = New System.Drawing.Point(32, 122)
        Me.vehicleTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.vehicleTable.MinimumSize = New System.Drawing.Size(571, 288)
        Me.vehicleTable.Name = "vehicleTable"
        Me.vehicleTable.RowTemplate.Height = 31
        Me.vehicleTable.Size = New System.Drawing.Size(659, 288)
        Me.vehicleTable.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Make"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Model"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Class"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Year"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Seats"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "Transmisson"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "GVWR"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Daily Rate"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Weekly Rate"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "Monthly Rate"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 50
        '
        'ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 487)
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
        Me.Name = "ViewInventory"
        Me.Text = "View Inventory"
        CType(Me.vehicleTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backButton As Button
    Friend WithEvents stanRadio As RadioButton
    Friend WithEvents autoRadio As RadioButton
    Friend WithEvents BothRadio As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents seatsCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents makeCombo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents typeCombo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents vehicleTable As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
