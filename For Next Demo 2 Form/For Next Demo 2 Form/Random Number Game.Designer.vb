<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Number_Game
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
        Me.lblAnwser = New System.Windows.Forms.Label()
        Me.lblGotWrong = New System.Windows.Forms.Label()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess a number between 1 and 100"
        '
        'lblAnwser
        '
        Me.lblAnwser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnwser.Location = New System.Drawing.Point(12, 46)
        Me.lblAnwser.Name = "lblAnwser"
        Me.lblAnwser.Size = New System.Drawing.Size(350, 91)
        Me.lblAnwser.TabIndex = 1
        '
        'lblGotWrong
        '
        Me.lblGotWrong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGotWrong.Location = New System.Drawing.Point(12, 153)
        Me.lblGotWrong.Name = "lblGotWrong"
        Me.lblGotWrong.Size = New System.Drawing.Size(350, 80)
        Me.lblGotWrong.TabIndex = 2
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(89, 248)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 3
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(190, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Random_Number_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 283)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblGotWrong)
        Me.Controls.Add(Me.lblAnwser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Random_Number_Game"
        Me.Text = "Random_Number_Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAnwser As System.Windows.Forms.Label
    Friend WithEvents lblGotWrong As System.Windows.Forms.Label
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
