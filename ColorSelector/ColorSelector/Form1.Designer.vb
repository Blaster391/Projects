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
        Me.txt_Text = New System.Windows.Forms.Label()
        Me.btn_Color = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'txt_Text
        '
        Me.txt_Text.AutoSize = True
        Me.txt_Text.Location = New System.Drawing.Point(104, 62)
        Me.txt_Text.Name = "txt_Text"
        Me.txt_Text.Size = New System.Drawing.Size(35, 13)
        Me.txt_Text.TabIndex = 0
        Me.txt_Text.Text = "TEXT"
        '
        'btn_Color
        '
        Me.btn_Color.Location = New System.Drawing.Point(86, 155)
        Me.btn_Color.Name = "btn_Color"
        Me.btn_Color.Size = New System.Drawing.Size(75, 23)
        Me.btn_Color.TabIndex = 1
        Me.btn_Color.Text = "Pick Color"
        Me.btn_Color.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_Color)
        Me.Controls.Add(Me.txt_Text)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Text As System.Windows.Forms.Label
    Friend WithEvents btn_Color As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
