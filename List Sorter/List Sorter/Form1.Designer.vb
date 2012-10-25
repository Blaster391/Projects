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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lst_list = New System.Windows.Forms.ListBox()
        Me.txt_add = New System.Windows.Forms.TextBox()
        Me.btn_sort = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(109, 61)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Add To List"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lst_list
        '
        Me.lst_list.FormattingEnabled = True
        Me.lst_list.Location = New System.Drawing.Point(12, 90)
        Me.lst_list.Name = "lst_list"
        Me.lst_list.Size = New System.Drawing.Size(260, 121)
        Me.lst_list.TabIndex = 1
        '
        'txt_add
        '
        Me.txt_add.Location = New System.Drawing.Point(97, 12)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(100, 20)
        Me.txt_add.TabIndex = 2
        '
        'btn_sort
        '
        Me.btn_sort.Location = New System.Drawing.Point(109, 217)
        Me.btn_sort.Name = "btn_sort"
        Me.btn_sort.Size = New System.Drawing.Size(75, 23)
        Me.btn_sort.TabIndex = 3
        Me.btn_sort.Text = "Sort"
        Me.btn_sort.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(191, 226)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_sort)
        Me.Controls.Add(Me.txt_add)
        Me.Controls.Add(Me.lst_list)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents lst_list As System.Windows.Forms.ListBox
    Friend WithEvents txt_add As System.Windows.Forms.TextBox
    Friend WithEvents btn_sort As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label

End Class
