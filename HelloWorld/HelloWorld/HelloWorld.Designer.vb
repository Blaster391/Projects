<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
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
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.btn_Hello = New System.Windows.Forms.Button()
        Me.lbl_Hello = New System.Windows.Forms.Label()
        Me.btn_coloryeallow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(286, 35)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(322, 20)
        Me.txt_Name.TabIndex = 0
        Me.txt_Name.Text = "Enter Name"
        '
        'btn_Hello
        '
        Me.btn_Hello.Location = New System.Drawing.Point(511, 61)
        Me.btn_Hello.Name = "btn_Hello"
        Me.btn_Hello.Size = New System.Drawing.Size(97, 23)
        Me.btn_Hello.TabIndex = 1
        Me.btn_Hello.Text = "Click to say hi"
        Me.btn_Hello.UseVisualStyleBackColor = True
        '
        'lbl_Hello
        '
        Me.lbl_Hello.AutoSize = True
        Me.lbl_Hello.Location = New System.Drawing.Point(508, 87)
        Me.lbl_Hello.Name = "lbl_Hello"
        Me.lbl_Hello.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Hello.TabIndex = 2
        '
        'btn_coloryeallow
        '
        Me.btn_coloryeallow.Location = New System.Drawing.Point(0, 0)
        Me.btn_coloryeallow.Name = "btn_coloryeallow"
        Me.btn_coloryeallow.Size = New System.Drawing.Size(75, 23)
        Me.btn_coloryeallow.TabIndex = 3
        Me.btn_coloryeallow.Text = "Yellow"
        Me.btn_coloryeallow.UseVisualStyleBackColor = True
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(900, 429)
        Me.Controls.Add(Me.btn_coloryeallow)
        Me.Controls.Add(Me.lbl_Hello)
        Me.Controls.Add(Me.btn_Hello)
        Me.Controls.Add(Me.txt_Name)
        Me.Name = "HelloWorld"
        Me.Text = "Hi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents btn_Hello As System.Windows.Forms.Button
    Friend WithEvents lbl_Hello As System.Windows.Forms.Label
    Friend WithEvents btn_coloryeallow As System.Windows.Forms.Button

End Class
