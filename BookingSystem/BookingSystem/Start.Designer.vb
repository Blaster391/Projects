<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.open_seats = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(13, 227)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(75, 23)
        Me.btn_load.TabIndex = 0
        Me.btn_load.Text = "Load"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(197, 227)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 1
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(105, 227)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(75, 23)
        Me.btn_New.TabIndex = 2
        Me.btn_New.Text = "New"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(197, 198)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(75, 23)
        Me.btn_help.TabIndex = 3
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'open_seats
        '
        Me.open_seats.FileName = "OpenFileDialog1"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_load)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents open_seats As System.Windows.Forms.OpenFileDialog
End Class
