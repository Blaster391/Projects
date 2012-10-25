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
        Me.txt_Save = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_LoadData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Save
        '
        Me.txt_Save.Location = New System.Drawing.Point(12, 51)
        Me.txt_Save.Multiline = True
        Me.txt_Save.Name = "txt_Save"
        Me.txt_Save.Size = New System.Drawing.Size(131, 131)
        Me.txt_Save.TabIndex = 0
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(79, 12)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "SAVE!"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(181, 11)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(75, 23)
        Me.btn_Load.TabIndex = 2
        Me.btn_Load.Text = "LOAD"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_LoadData
        '
        Me.lbl_LoadData.AutoSize = True
        Me.lbl_LoadData.Location = New System.Drawing.Point(161, 51)
        Me.lbl_LoadData.Name = "lbl_LoadData"
        Me.lbl_LoadData.Size = New System.Drawing.Size(39, 13)
        Me.lbl_LoadData.TabIndex = 3
        Me.lbl_LoadData.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Me.lbl_LoadData)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_Save)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Save As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Load As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_LoadData As System.Windows.Forms.Label

End Class
