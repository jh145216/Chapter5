<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sum_of_Number_form
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
        Me.btnEnterNumber = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnterNumber
        '
        Me.btnEnterNumber.Location = New System.Drawing.Point(47, 52)
        Me.btnEnterNumber.Name = "btnEnterNumber"
        Me.btnEnterNumber.Size = New System.Drawing.Size(92, 23)
        Me.btnEnterNumber.TabIndex = 0
        Me.btnEnterNumber.Text = "Enter Number"
        Me.btnEnterNumber.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 52)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Sum_of_Number_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 120)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNumber)
        Me.Name = "Sum_of_Number_form"
        Me.Text = "Sum_of_Number_form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterNumber As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
