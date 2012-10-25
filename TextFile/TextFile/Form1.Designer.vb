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
        Me.btn_ValueSave = New System.Windows.Forms.Button()
        Me.lbl_Value1 = New System.Windows.Forms.Label()
        Me.lbl_Value2 = New System.Windows.Forms.Label()
        Me.txt_Value1 = New System.Windows.Forms.TextBox()
        Me.txt_Value2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ValueSave
        '
        Me.btn_ValueSave.Location = New System.Drawing.Point(106, 59)
        Me.btn_ValueSave.Name = "btn_ValueSave"
        Me.btn_ValueSave.Size = New System.Drawing.Size(75, 23)
        Me.btn_ValueSave.TabIndex = 0
        Me.btn_ValueSave.Text = "Button1"
        Me.btn_ValueSave.UseVisualStyleBackColor = True
        '
        'lbl_Value1
        '
        Me.lbl_Value1.AutoSize = True
        Me.lbl_Value1.Location = New System.Drawing.Point(37, 89)
        Me.lbl_Value1.Name = "lbl_Value1"
        Me.lbl_Value1.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Value1.TabIndex = 1
        Me.lbl_Value1.Text = "Label1"
        '
        'lbl_Value2
        '
        Me.lbl_Value2.AutoSize = True
        Me.lbl_Value2.Location = New System.Drawing.Point(200, 89)
        Me.lbl_Value2.Name = "lbl_Value2"
        Me.lbl_Value2.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Value2.TabIndex = 2
        Me.lbl_Value2.Text = "Label2"
        '
        'txt_Value1
        '
        Me.txt_Value1.Location = New System.Drawing.Point(12, 33)
        Me.txt_Value1.Name = "txt_Value1"
        Me.txt_Value1.Size = New System.Drawing.Size(100, 20)
        Me.txt_Value1.TabIndex = 3
        '
        'txt_Value2
        '
        Me.txt_Value2.Location = New System.Drawing.Point(172, 33)
        Me.txt_Value2.Name = "txt_Value2"
        Me.txt_Value2.Size = New System.Drawing.Size(100, 20)
        Me.txt_Value2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Value 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Value 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 187)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Value2)
        Me.Controls.Add(Me.txt_Value1)
        Me.Controls.Add(Me.lbl_Value2)
        Me.Controls.Add(Me.lbl_Value1)
        Me.Controls.Add(Me.btn_ValueSave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ValueSave As System.Windows.Forms.Button
    Friend WithEvents lbl_Value1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Value2 As System.Windows.Forms.Label
    Friend WithEvents txt_Value1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Value2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
