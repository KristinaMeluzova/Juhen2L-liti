﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USwitch
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USwitch))
        Me.pbSwitch = New System.Windows.Forms.PictureBox()
        Me.imLoend = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSwitch
        '
        Me.pbSwitch.Location = New System.Drawing.Point(380, 330)
        Me.pbSwitch.Name = "pbSwitch"
        Me.pbSwitch.Size = New System.Drawing.Size(209, 48)
        Me.pbSwitch.TabIndex = 0
        Me.pbSwitch.TabStop = False
        '
        'imLoend
        '
        Me.imLoend.ImageStream = CType(resources.GetObject("imLoend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imLoend.TransparentColor = System.Drawing.Color.Transparent
        Me.imLoend.Images.SetKeyName(0, "switch off.jpg")
        Me.imLoend.Images.SetKeyName(1, "switch on.jpg")
        '
        'USwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbSwitch)
        Me.Name = "USwitch"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbSwitch As PictureBox
    Friend WithEvents imLoend As ImageList
End Class
