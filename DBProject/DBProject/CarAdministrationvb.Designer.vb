﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarAdministrationvb
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
        Me.AddVehicleB = New System.Windows.Forms.Button()
        Me.RemoveVehicleB = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.HButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddVehicleB
        '
        Me.AddVehicleB.Location = New System.Drawing.Point(633, 363)
        Me.AddVehicleB.Margin = New System.Windows.Forms.Padding(4)
        Me.AddVehicleB.Name = "AddVehicleB"
        Me.AddVehicleB.Size = New System.Drawing.Size(187, 46)
        Me.AddVehicleB.TabIndex = 0
        Me.AddVehicleB.Text = "Add Vehicle"
        Me.AddVehicleB.UseVisualStyleBackColor = True
        '
        'RemoveVehicleB
        '
        Me.RemoveVehicleB.Location = New System.Drawing.Point(633, 466)
        Me.RemoveVehicleB.Margin = New System.Windows.Forms.Padding(4)
        Me.RemoveVehicleB.Name = "RemoveVehicleB"
        Me.RemoveVehicleB.Size = New System.Drawing.Size(187, 46)
        Me.RemoveVehicleB.TabIndex = 3
        Me.RemoveVehicleB.Text = "Remove Vehicle"
        Me.RemoveVehicleB.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(633, 577)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(187, 46)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseCompatibleTextRendering = True
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(633, 415)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(187, 46)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "Update Vehicle"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'HButton
        '
        Me.HButton.Location = New System.Drawing.Point(633, 522)
        Me.HButton.Margin = New System.Windows.Forms.Padding(6)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(187, 46)
        Me.HButton.TabIndex = 6
        Me.HButton.Text = "Help"
        Me.HButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DBProject.My.Resources.Resources.for_business_backgrounds_wallpapers_1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1342, 984)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CarAdministrationvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 982)
        Me.Controls.Add(Me.HButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RemoveVehicleB)
        Me.Controls.Add(Me.AddVehicleB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CarAdministrationvb"
        Me.Text = "CarAdministrationvb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddVehicleB As Button
    Friend WithEvents RemoveVehicleB As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents HButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
