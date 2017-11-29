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
        Me.btnEnterSales = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterSales
        '
        Me.btnEnterSales.Location = New System.Drawing.Point(35, 111)
        Me.btnEnterSales.Name = "btnEnterSales"
        Me.btnEnterSales.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterSales.TabIndex = 0
        Me.btnEnterSales.Text = "Enter Sales"
        Me.btnEnterSales.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(31, 37)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(88, 19)
        Me.lblTotalSales.TabIndex = 3
        Me.lblTotalSales.Text = "Total Sales:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(148, 37)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 182)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterSales)
        Me.Name = "Form1"
        Me.Text = "Running Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterSales As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
