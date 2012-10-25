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
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_Display = New System.Windows.Forms.Button()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.txt_Age = New System.Windows.Forms.TextBox()
        Me.lst_display = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_write
        '
        Me.btn_write.Location = New System.Drawing.Point(197, 102)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(75, 23)
        Me.btn_write.TabIndex = 0
        Me.btn_write.Text = "Button1"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(197, 131)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "Button2"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_Display
        '
        Me.btn_Display.Location = New System.Drawing.Point(13, 227)
        Me.btn_Display.Name = "btn_Display"
        Me.btn_Display.Size = New System.Drawing.Size(75, 23)
        Me.btn_Display.TabIndex = 2
        Me.btn_Display.Text = "Button3"
        Me.btn_Display.UseVisualStyleBackColor = True
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Location = New System.Drawing.Point(13, 13)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(100, 20)
        Me.txt_FirstName.TabIndex = 3
        '
        'txt_LastName
        '
        Me.txt_LastName.Location = New System.Drawing.Point(13, 40)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(100, 20)
        Me.txt_LastName.TabIndex = 4
        '
        'txt_Age
        '
        Me.txt_Age.Location = New System.Drawing.Point(13, 67)
        Me.txt_Age.Name = "txt_Age"
        Me.txt_Age.Size = New System.Drawing.Size(100, 20)
        Me.txt_Age.TabIndex = 5
        '
        'lst_display
        '
        Me.lst_display.FormattingEnabled = True
        Me.lst_display.Location = New System.Drawing.Point(152, 160)
        Me.lst_display.Name = "lst_display"
        Me.lst_display.Size = New System.Drawing.Size(120, 95)
        Me.lst_display.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lst_display)
        Me.Controls.Add(Me.txt_Age)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.btn_Display)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_write)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_write As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_Display As System.Windows.Forms.Button
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_LastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_Age As System.Windows.Forms.TextBox
    Friend WithEvents lst_display As System.Windows.Forms.ListBox

End Class
