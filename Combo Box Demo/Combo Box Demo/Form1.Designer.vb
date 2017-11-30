<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.cboPlay = New System.Windows.Forms.ComboBox()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtPlay = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnShowSelections = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"England", "Ireland", "Whales"})
        Me.cboCountry.Location = New System.Drawing.Point(165, 61)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(121, 21)
        Me.cboCountry.TabIndex = 0
        '
        'cboPlay
        '
        Me.cboPlay.FormattingEnabled = True
        Me.cboPlay.Items.AddRange(New Object() {"Hamlet", "Romeo and Juliet", "Much Ado abot Nothing", "A Comedy of Errors", "The Merchant"})
        Me.cboPlay.Location = New System.Drawing.Point(165, 126)
        Me.cboPlay.Name = "cboPlay"
        Me.cboPlay.Size = New System.Drawing.Size(121, 21)
        Me.cboPlay.TabIndex = 1
        '
        'cboArtist
        '
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtist.Location = New System.Drawing.Point(165, 194)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 2
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(45, 61)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(91, 13)
        Me.lblCountry.TabIndex = 3
        Me.lblCountry.Text = "Choose a Country"
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.Location = New System.Drawing.Point(45, 126)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(74, 13)
        Me.lblPlay.TabIndex = 4
        Me.lblPlay.Text = "Choose a play"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(45, 197)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(83, 13)
        Me.lblArtist.TabIndex = 5
        Me.lblArtist.Text = "Choose an artist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.txtPlay)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 201)
        Me.GroupBox1.TabIndex = 6
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
        'btnShowSelections
        '
        Me.btnShowSelections.Location = New System.Drawing.Point(106, 257)
        Me.btnShowSelections.Name = "btnShowSelections"
        Me.btnShowSelections.Size = New System.Drawing.Size(75, 36)
        Me.btnShowSelections.TabIndex = 7
        Me.btnShowSelections.Text = "Show Selections"
        Me.btnShowSelections.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.Location = New System.Drawing.Point(258, 264)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(75, 23)
        Me.btnResetForm.TabIndex = 8
        Me.btnResetForm.Text = "Rest Form"
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(389, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 312)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlay As System.Windows.Forms.ComboBox
    Friend WithEvents cboArtist As System.Windows.Forms.ComboBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArtist As System.Windows.Forms.TextBox
    Friend WithEvents txtPlay As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents btnShowSelections As System.Windows.Forms.Button
    Friend WithEvents btnResetForm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
