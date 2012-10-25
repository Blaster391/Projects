<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameList
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
        Me.lst_Names = New System.Windows.Forms.ListBox()
        Me.btn_NameEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_Names
        '
        Me.lst_Names.FormattingEnabled = True
        Me.lst_Names.Location = New System.Drawing.Point(13, 58)
        Me.lst_Names.Name = "lst_Names"
        Me.lst_Names.Size = New System.Drawing.Size(259, 199)
        Me.lst_Names.TabIndex = 0
        '
        'btn_NameEnter
        '
        Me.btn_NameEnter.Location = New System.Drawing.Point(92, 12)
        Me.btn_NameEnter.Name = "btn_NameEnter"
        Me.btn_NameEnter.Size = New System.Drawing.Size(88, 23)
        Me.btn_NameEnter.TabIndex = 1
        Me.btn_NameEnter.Text = "Enter Names"
        Me.btn_NameEnter.UseVisualStyleBackColor = True
        '
        'NameList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_NameEnter)
        Me.Controls.Add(Me.lst_Names)
        Me.Name = "NameList"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_Names As System.Windows.Forms.ListBox
    Friend WithEvents btn_NameEnter As System.Windows.Forms.Button

End Class
