<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class The_Coin_Toss_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(The_Coin_Toss_Form))
        Me.lblTailsTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHeadsTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnToss = New System.Windows.Forms.Button()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTailsTotal
        '
        Me.lblTailsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTailsTotal.Location = New System.Drawing.Point(588, 282)
        Me.lblTailsTotal.Name = "lblTailsTotal"
        Me.lblTailsTotal.Size = New System.Drawing.Size(68, 41)
        Me.lblTailsTotal.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(468, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Number of Tails:"
        '
        'lblHeadsTotal
        '
        Me.lblHeadsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeadsTotal.Location = New System.Drawing.Point(137, 282)
        Me.lblHeadsTotal.Name = "lblHeadsTotal"
        Me.lblHeadsTotal.Size = New System.Drawing.Size(69, 41)
        Me.lblHeadsTotal.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Number of Heads:"
        '
        'picTails
        '
        Me.picTails.Image = CType(resources.GetObject("picTails.Image"), System.Drawing.Image)
        Me.picTails.Location = New System.Drawing.Point(429, 34)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(227, 182)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTails.TabIndex = 11
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = CType(resources.GetObject("picHeads.Image"), System.Drawing.Image)
        Me.picHeads.Location = New System.Drawing.Point(32, 34)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(229, 182)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeads.TabIndex = 10
        Me.picHeads.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(370, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(242, 282)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(98, 23)
        Me.btnToss.TabIndex = 8
        Me.btnToss.Text = "Toss The Coin"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'The_Coin_Toss_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 357)
        Me.Controls.Add(Me.lblTailsTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHeadsTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Name = "The_Coin_Toss_Form"
        Me.Text = "The_Coin_Toss_Form"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTailsTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHeadsTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnToss As System.Windows.Forms.Button
End Class
