﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnRockPaperScissors = New System.Windows.Forms.Button()
        Me.BtnForNextDemo2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPG3461 = New System.Windows.Forms.Button()
        Me.btnPG3462 = New System.Windows.Forms.Button()
        Me.btnPG3469 = New System.Windows.Forms.Button()
        Me.btnPG34619 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRockPaperScissors
        '
        Me.btnRockPaperScissors.Location = New System.Drawing.Point(29, 77)
        Me.btnRockPaperScissors.Name = "btnRockPaperScissors"
        Me.btnRockPaperScissors.Size = New System.Drawing.Size(75, 37)
        Me.btnRockPaperScissors.TabIndex = 1
        Me.btnRockPaperScissors.Text = "Rock Paper Scissors"
        Me.btnRockPaperScissors.UseVisualStyleBackColor = True
        '
        'BtnForNextDemo2
        '
        Me.BtnForNextDemo2.Location = New System.Drawing.Point(149, 77)
        Me.BtnForNextDemo2.Name = "BtnForNextDemo2"
        Me.BtnForNextDemo2.Size = New System.Drawing.Size(75, 47)
        Me.BtnForNextDemo2.TabIndex = 2
        Me.BtnForNextDemo2.Text = "For Next Demo 2"
        Me.BtnForNextDemo2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(149, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Program Menu"
        '
        'btnPG3461
        '
        Me.btnPG3461.Location = New System.Drawing.Point(29, 152)
        Me.btnPG3461.Name = "btnPG3461"
        Me.btnPG3461.Size = New System.Drawing.Size(75, 23)
        Me.btnPG3461.TabIndex = 6
        Me.btnPG3461.Text = "Pg346#1"
        Me.btnPG3461.UseVisualStyleBackColor = True
        '
        'btnPG3462
        '
        Me.btnPG3462.Location = New System.Drawing.Point(125, 152)
        Me.btnPG3462.Name = "btnPG3462"
        Me.btnPG3462.Size = New System.Drawing.Size(75, 23)
        Me.btnPG3462.TabIndex = 7
        Me.btnPG3462.Text = "Pg346#2"
        Me.btnPG3462.UseVisualStyleBackColor = True
        '
        'btnPG3469
        '
        Me.btnPG3469.Location = New System.Drawing.Point(226, 152)
        Me.btnPG3469.Name = "btnPG3469"
        Me.btnPG3469.Size = New System.Drawing.Size(75, 23)
        Me.btnPG3469.TabIndex = 8
        Me.btnPG3469.Text = "Pg346#9"
        Me.btnPG3469.UseVisualStyleBackColor = True
        '
        'btnPG34619
        '
        Me.btnPG34619.Location = New System.Drawing.Point(323, 152)
        Me.btnPG34619.Name = "btnPG34619"
        Me.btnPG34619.Size = New System.Drawing.Size(75, 23)
        Me.btnPG34619.TabIndex = 9
        Me.btnPG34619.Text = "Pg346#19"
        Me.btnPG34619.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 265)
        Me.Controls.Add(Me.btnPG34619)
        Me.Controls.Add(Me.btnPG3469)
        Me.Controls.Add(Me.btnPG3462)
        Me.Controls.Add(Me.btnPG3461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnForNextDemo2)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
    Friend WithEvents BtnForNextDemo2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPG3461 As System.Windows.Forms.Button
    Friend WithEvents btnPG3462 As System.Windows.Forms.Button
    Friend WithEvents btnPG3469 As System.Windows.Forms.Button
    Friend WithEvents btnPG34619 As System.Windows.Forms.Button
End Class
