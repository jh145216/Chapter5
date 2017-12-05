<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combo_Box_Demo
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnShowSelections = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtPlay = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.cboPlay = New System.Windows.Forms.ComboBox()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(428, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.Location = New System.Drawing.Point(297, 284)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(75, 23)
        Me.btnResetForm.TabIndex = 18
        Me.btnResetForm.Text = "Rest Form"
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'btnShowSelections
        '
        Me.btnShowSelections.Location = New System.Drawing.Point(145, 277)
        Me.btnShowSelections.Name = "btnShowSelections"
        Me.btnShowSelections.Size = New System.Drawing.Size(75, 36)
        Me.btnShowSelections.TabIndex = 17
        Me.btnShowSelections.Text = "Show Selections"
        Me.btnShowSelections.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.txtPlay)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(374, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 201)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(54, 155)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 20)
        Me.txtArtist.TabIndex = 2
        '
        'txtPlay
        '
        Me.txtPlay.Location = New System.Drawing.Point(54, 92)
        Me.txtPlay.Name = "txtPlay"
        Me.txtPlay.Size = New System.Drawing.Size(100, 20)
        Me.txtPlay.TabIndex = 1
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(54, 27)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 20)
        Me.txtCountry.TabIndex = 0
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(84, 217)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(83, 13)
        Me.lblArtist.TabIndex = 15
        Me.lblArtist.Text = "Choose an artist"
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.Location = New System.Drawing.Point(84, 146)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(74, 13)
        Me.lblPlay.TabIndex = 14
        Me.lblPlay.Text = "Choose a play"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(84, 81)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(91, 13)
        Me.lblCountry.TabIndex = 13
        Me.lblCountry.Text = "Choose a Country"
        '
        'cboArtist
        '
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtist.Location = New System.Drawing.Point(204, 214)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 12
        '
        'cboPlay
        '
        Me.cboPlay.FormattingEnabled = True
        Me.cboPlay.Items.AddRange(New Object() {"Hamlet", "Romeo and Juliet", "Much Ado abot Nothing", "A Comedy of Errors", "The Merchant"})
        Me.cboPlay.Location = New System.Drawing.Point(204, 146)
        Me.cboPlay.Name = "cboPlay"
        Me.cboPlay.Size = New System.Drawing.Size(121, 21)
        Me.cboPlay.TabIndex = 11
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"England", "Ireland", "Whales"})
        Me.cboCountry.Location = New System.Drawing.Point(204, 81)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 21)
        Me.cboCountry.TabIndex = 10
        '
        'Combo_Box_Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 369)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnShowSelections)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.cboPlay)
        Me.Controls.Add(Me.cboCountry)
        Me.Name = "Combo_Box_Demo"
        Me.Text = "Combo_Box_Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnResetForm As System.Windows.Forms.Button
    Friend WithEvents btnShowSelections As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtPlay As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents cboArtist As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlay As System.Windows.Forms.ComboBox
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
End Class
