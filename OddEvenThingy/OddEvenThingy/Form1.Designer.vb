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
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Go
        '
        Me.btn_Go.Location = New System.Drawing.Point(13, 153)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(259, 97)
        Me.btn_Go.TabIndex = 0
        Me.btn_Go.Text = "Check Number"
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(102, 107)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Output.TabIndex = 1
        Me.lbl_Output.Text = "Odd or Even"
        '
        'txt_input
        '
        Me.txt_input.Location = New System.Drawing.Point(13, 23)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(259, 20)
        Me.txt_input.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter a WHOLE number."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_input)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.btn_Go)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Go As System.Windows.Forms.Button
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents txt_input As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
