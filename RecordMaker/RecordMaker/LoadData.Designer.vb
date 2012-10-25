<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadData
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
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.chk_Code = New System.Windows.Forms.CheckBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_SecondName = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_EnterDataGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(99, 49)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.btn_Search.TabIndex = 0
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'chk_Code
        '
        Me.chk_Code.AutoSize = True
        Me.chk_Code.Location = New System.Drawing.Point(99, 173)
        Me.chk_Code.Name = "chk_Code"
        Me.chk_Code.Size = New System.Drawing.Size(101, 17)
        Me.chk_Code.TabIndex = 1
        Me.chk_Code.Text = "Can they code?"
        Me.chk_Code.UseVisualStyleBackColor = True
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(86, 12)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 20)
        Me.txt_ID.TabIndex = 2
        '
        'txt_SecondName
        '
        Me.txt_SecondName.Location = New System.Drawing.Point(86, 121)
        Me.txt_SecondName.Name = "txt_SecondName"
        Me.txt_SecondName.Size = New System.Drawing.Size(100, 20)
        Me.txt_SecondName.TabIndex = 3
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Location = New System.Drawing.Point(86, 95)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(100, 20)
        Me.txt_FirstName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Enter ID"
        '
        'btn_EnterDataGo
        '
        Me.btn_EnterDataGo.Location = New System.Drawing.Point(87, 227)
        Me.btn_EnterDataGo.Name = "btn_EnterDataGo"
        Me.btn_EnterDataGo.Size = New System.Drawing.Size(87, 23)
        Me.btn_EnterDataGo.TabIndex = 10
        Me.btn_EnterDataGo.Text = "Add Records"
        Me.btn_EnterDataGo.UseVisualStyleBackColor = True
        '
        'LoadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_EnterDataGo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.txt_SecondName)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.chk_Code)
        Me.Controls.Add(Me.btn_Search)
        Me.Name = "LoadData"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents chk_Code As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_SecondName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_EnterDataGo As System.Windows.Forms.Button
End Class
