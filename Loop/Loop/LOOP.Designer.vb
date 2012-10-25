<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loop1
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
        Me.btn_LoopStart = New System.Windows.Forms.Button()
        Me.txt_LoopStart = New System.Windows.Forms.TextBox()
        Me.txt_EndValue = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_LoopStart
        '
        Me.btn_LoopStart.Location = New System.Drawing.Point(96, 85)
        Me.btn_LoopStart.Name = "btn_LoopStart"
        Me.btn_LoopStart.Size = New System.Drawing.Size(75, 23)
        Me.btn_LoopStart.TabIndex = 1
        Me.btn_LoopStart.Text = "Start"
        Me.btn_LoopStart.UseVisualStyleBackColor = True
        '
        'txt_LoopStart
        '
        Me.txt_LoopStart.Location = New System.Drawing.Point(84, 32)
        Me.txt_LoopStart.Name = "txt_LoopStart"
        Me.txt_LoopStart.Size = New System.Drawing.Size(100, 20)
        Me.txt_LoopStart.TabIndex = 2
        '
        'txt_EndValue
        '
        Me.txt_EndValue.Location = New System.Drawing.Point(84, 59)
        Me.txt_EndValue.Name = "txt_EndValue"
        Me.txt_EndValue.Size = New System.Drawing.Size(100, 20)
        Me.txt_EndValue.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(74, 114)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 4
        '
        'Loop1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txt_EndValue)
        Me.Controls.Add(Me.txt_LoopStart)
        Me.Controls.Add(Me.btn_LoopStart)
        Me.Name = "Loop1"
        Me.Text = "Loop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_LoopStart As System.Windows.Forms.Button
    Friend WithEvents txt_LoopStart As System.Windows.Forms.TextBox
    Friend WithEvents txt_EndValue As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
