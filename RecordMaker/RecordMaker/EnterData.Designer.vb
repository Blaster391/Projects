<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterData
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
        Me.btn_EnterInformation = New System.Windows.Forms.Button()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_Coder = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_SecondName = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_EnterInformation
        '
        Me.btn_EnterInformation.Location = New System.Drawing.Point(38, 227)
        Me.btn_EnterInformation.Name = "btn_EnterInformation"
        Me.btn_EnterInformation.Size = New System.Drawing.Size(75, 23)
        Me.btn_EnterInformation.TabIndex = 0
        Me.btn_EnterInformation.Text = "ENTER!"
        Me.btn_EnterInformation.UseVisualStyleBackColor = True
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(13, 13)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(18, 13)
        Me.lbl_ID.TabIndex = 1
        Me.lbl_ID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Second Name"
        '
        'chk_Coder
        '
        Me.chk_Coder.AutoSize = True
        Me.chk_Coder.Location = New System.Drawing.Point(12, 104)
        Me.chk_Coder.Name = "chk_Coder"
        Me.chk_Coder.Size = New System.Drawing.Size(101, 17)
        Me.chk_Coder.TabIndex = 5
        Me.chk_Coder.Text = "Can You Code?"
        Me.chk_Coder.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(147, 10)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ID.TabIndex = 6
        '
        'txt_SecondName
        '
        Me.txt_SecondName.Location = New System.Drawing.Point(147, 53)
        Me.txt_SecondName.Name = "txt_SecondName"
        Me.txt_SecondName.Size = New System.Drawing.Size(100, 20)
        Me.txt_SecondName.TabIndex = 7
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Location = New System.Drawing.Point(147, 32)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(100, 20)
        Me.txt_FirstName.TabIndex = 8
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(197, 227)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(75, 23)
        Me.btn_Load.TabIndex = 9
        Me.btn_Load.Text = "LOAD"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'EnterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.txt_SecondName)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.chk_Coder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.btn_EnterInformation)
        Me.Name = "EnterData"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_EnterInformation As System.Windows.Forms.Button
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_Coder As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_SecondName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents btn_Load As System.Windows.Forms.Button

End Class
