<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factors
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
        Me.btn_FindFactors = New System.Windows.Forms.Button()
        Me.lst_Factors = New System.Windows.Forms.ListBox()
        Me.txt_FactorEnter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_FindFactors
        '
        Me.btn_FindFactors.Location = New System.Drawing.Point(12, 199)
        Me.btn_FindFactors.Name = "btn_FindFactors"
        Me.btn_FindFactors.Size = New System.Drawing.Size(286, 167)
        Me.btn_FindFactors.TabIndex = 0
        Me.btn_FindFactors.Text = "Find Factors"
        Me.btn_FindFactors.UseVisualStyleBackColor = True
        '
        'lst_Factors
        '
        Me.lst_Factors.FormattingEnabled = True
        Me.lst_Factors.Location = New System.Drawing.Point(321, 4)
        Me.lst_Factors.Name = "lst_Factors"
        Me.lst_Factors.Size = New System.Drawing.Size(264, 368)
        Me.lst_Factors.TabIndex = 1
        '
        'txt_FactorEnter
        '
        Me.txt_FactorEnter.Location = New System.Drawing.Point(12, 118)
        Me.txt_FactorEnter.Name = "txt_FactorEnter"
        Me.txt_FactorEnter.Size = New System.Drawing.Size(141, 20)
        Me.txt_FactorEnter.TabIndex = 2
        '
        'Factors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 378)
        Me.Controls.Add(Me.txt_FactorEnter)
        Me.Controls.Add(Me.lst_Factors)
        Me.Controls.Add(Me.btn_FindFactors)
        Me.Name = "Factors"
        Me.Text = "Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_FindFactors As System.Windows.Forms.Button
    Friend WithEvents lst_Factors As System.Windows.Forms.ListBox
    Friend WithEvents txt_FactorEnter As System.Windows.Forms.TextBox

End Class
