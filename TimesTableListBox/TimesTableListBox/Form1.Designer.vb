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
        Me.btn_Run = New System.Windows.Forms.Button()
        Me.list_list = New System.Windows.Forms.ListBox()
        Me.txt_Start = New System.Windows.Forms.TextBox()
        Me.txt_End = New System.Windows.Forms.TextBox()
        Me.txt_multiplier = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Run
        '
        Me.btn_Run.Location = New System.Drawing.Point(99, 64)
        Me.btn_Run.Name = "btn_Run"
        Me.btn_Run.Size = New System.Drawing.Size(75, 23)
        Me.btn_Run.TabIndex = 0
        Me.btn_Run.Text = "Button1"
        Me.btn_Run.UseVisualStyleBackColor = True
        '
        'list_list
        '
        Me.list_list.FormattingEnabled = True
        Me.list_list.Location = New System.Drawing.Point(78, 93)
        Me.list_list.Name = "list_list"
        Me.list_list.Size = New System.Drawing.Size(120, 95)
        Me.list_list.TabIndex = 1
        '
        'txt_Start
        '
        Me.txt_Start.Location = New System.Drawing.Point(89, 12)
        Me.txt_Start.Name = "txt_Start"
        Me.txt_Start.Size = New System.Drawing.Size(100, 20)
        Me.txt_Start.TabIndex = 2
        '
        'txt_End
        '
        Me.txt_End.Location = New System.Drawing.Point(89, 38)
        Me.txt_End.Name = "txt_End"
        Me.txt_End.Size = New System.Drawing.Size(100, 20)
        Me.txt_End.TabIndex = 3
        '
        'txt_multiplier
        '
        Me.txt_multiplier.Location = New System.Drawing.Point(89, 194)
        Me.txt_multiplier.Name = "txt_multiplier"
        Me.txt_multiplier.Size = New System.Drawing.Size(100, 20)
        Me.txt_multiplier.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txt_multiplier)
        Me.Controls.Add(Me.txt_End)
        Me.Controls.Add(Me.txt_Start)
        Me.Controls.Add(Me.list_list)
        Me.Controls.Add(Me.btn_Run)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Run As System.Windows.Forms.Button
    Friend WithEvents list_list As System.Windows.Forms.ListBox
    Friend WithEvents txt_Start As System.Windows.Forms.TextBox
    Friend WithEvents txt_End As System.Windows.Forms.TextBox
    Friend WithEvents txt_multiplier As System.Windows.Forms.TextBox

End Class
