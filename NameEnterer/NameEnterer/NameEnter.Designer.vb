<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameEnter
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
        Me.txt_GetName = New System.Windows.Forms.TextBox()
        Me.btn_Confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_GetName
        '
        Me.txt_GetName.Location = New System.Drawing.Point(12, 87)
        Me.txt_GetName.Name = "txt_GetName"
        Me.txt_GetName.Size = New System.Drawing.Size(100, 20)
        Me.txt_GetName.TabIndex = 0
        '
        'btn_Confirm
        '
        Me.btn_Confirm.Location = New System.Drawing.Point(24, 12)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn_Confirm.TabIndex = 1
        Me.btn_Confirm.Text = "Enter"
        Me.btn_Confirm.UseVisualStyleBackColor = True
        '
        'NameEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(130, 126)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.txt_GetName)
        Me.Name = "NameEnter"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_GetName As System.Windows.Forms.TextBox
    Friend WithEvents btn_Confirm As System.Windows.Forms.Button
End Class
