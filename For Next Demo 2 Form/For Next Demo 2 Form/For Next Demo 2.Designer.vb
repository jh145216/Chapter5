<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Next_Demo_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Next_Demo_2))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picMcLarenP1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.picLamborghiniAventadorSVRoadster = New System.Windows.Forms.PictureBox()
        Me.picLaFerrari = New System.Windows.Forms.PictureBox()
        CType(Me.picMcLarenP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLamborghiniAventadorSVRoadster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaFerrari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(138, 376)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(462, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picMcLarenP1
        '
        Me.picMcLarenP1.Image = CType(resources.GetObject("picMcLarenP1.Image"), System.Drawing.Image)
        Me.picMcLarenP1.Location = New System.Drawing.Point(52, 31)
        Me.picMcLarenP1.Name = "picMcLarenP1"
        Me.picMcLarenP1.Size = New System.Drawing.Size(129, 68)
        Me.picMcLarenP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMcLarenP1.TabIndex = 2
        Me.picMcLarenP1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(300, 376)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'picLamborghiniAventadorSVRoadster
        '
        Me.picLamborghiniAventadorSVRoadster.Image = CType(resources.GetObject("picLamborghiniAventadorSVRoadster.Image"), System.Drawing.Image)
        Me.picLamborghiniAventadorSVRoadster.Location = New System.Drawing.Point(52, 133)
        Me.picLamborghiniAventadorSVRoadster.Name = "picLamborghiniAventadorSVRoadster"
        Me.picLamborghiniAventadorSVRoadster.Size = New System.Drawing.Size(129, 75)
        Me.picLamborghiniAventadorSVRoadster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLamborghiniAventadorSVRoadster.TabIndex = 4
        Me.picLamborghiniAventadorSVRoadster.TabStop = False
        '
        'picLaFerrari
        '
        Me.picLaFerrari.Image = CType(resources.GetObject("picLaFerrari.Image"), System.Drawing.Image)
        Me.picLaFerrari.Location = New System.Drawing.Point(52, 241)
        Me.picLaFerrari.Name = "picLaFerrari"
        Me.picLaFerrari.Size = New System.Drawing.Size(129, 77)
        Me.picLaFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaFerrari.TabIndex = 5
        Me.picLaFerrari.TabStop = False
        '
        'For_Next_Demo_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 429)
        Me.Controls.Add(Me.picLaFerrari)
        Me.Controls.Add(Me.picLamborghiniAventadorSVRoadster)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.picMcLarenP1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "For_Next_Demo_2"
        Me.Text = "For_Next_Demo_2"
        CType(Me.picMcLarenP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLamborghiniAventadorSVRoadster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaFerrari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picMcLarenP1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents picLamborghiniAventadorSVRoadster As System.Windows.Forms.PictureBox
    Friend WithEvents picLaFerrari As System.Windows.Forms.PictureBox

End Class
