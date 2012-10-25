<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.txt_Value1 = New System.Windows.Forms.TextBox()
        Me.txt_Value2 = New System.Windows.Forms.TextBox()
        Me.txt_EnterNumber = New System.Windows.Forms.Label()
        Me.lbl_Value = New System.Windows.Forms.Label()
        Me.rbtn_Multiply = New System.Windows.Forms.RadioButton()
        Me.rbtn_Add = New System.Windows.Forms.RadioButton()
        Me.rbtn_Divide = New System.Windows.Forms.RadioButton()
        Me.lbl_CalculationDecider = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(96, 188)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(84, 23)
        Me.btn_Calculate.TabIndex = 0
        Me.btn_Calculate.Text = "CALCULATE!"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'txt_Value1
        '
        Me.txt_Value1.Location = New System.Drawing.Point(12, 56)
        Me.txt_Value1.Name = "txt_Value1"
        Me.txt_Value1.Size = New System.Drawing.Size(100, 20)
        Me.txt_Value1.TabIndex = 1
        '
        'txt_Value2
        '
        Me.txt_Value2.Location = New System.Drawing.Point(172, 56)
        Me.txt_Value2.Name = "txt_Value2"
        Me.txt_Value2.Size = New System.Drawing.Size(100, 20)
        Me.txt_Value2.TabIndex = 2
        '
        'txt_EnterNumber
        '
        Me.txt_EnterNumber.AutoSize = True
        Me.txt_EnterNumber.Location = New System.Drawing.Point(113, 9)
        Me.txt_EnterNumber.Name = "txt_EnterNumber"
        Me.txt_EnterNumber.Size = New System.Drawing.Size(67, 13)
        Me.txt_EnterNumber.TabIndex = 3
        Me.txt_EnterNumber.Text = "Enter Values"
        '
        'lbl_Value
        '
        Me.lbl_Value.AutoSize = True
        Me.lbl_Value.Location = New System.Drawing.Point(130, 82)
        Me.lbl_Value.Name = "lbl_Value"
        Me.lbl_Value.Size = New System.Drawing.Size(22, 13)
        Me.lbl_Value.TabIndex = 4
        Me.lbl_Value.Text = "....."
        '
        'rbtn_Multiply
        '
        Me.rbtn_Multiply.AutoSize = True
        Me.rbtn_Multiply.Location = New System.Drawing.Point(37, 135)
        Me.rbtn_Multiply.Name = "rbtn_Multiply"
        Me.rbtn_Multiply.Size = New System.Drawing.Size(60, 17)
        Me.rbtn_Multiply.TabIndex = 5
        Me.rbtn_Multiply.TabStop = True
        Me.rbtn_Multiply.Text = "Multiply"
        Me.rbtn_Multiply.UseVisualStyleBackColor = True
        '
        'rbtn_Add
        '
        Me.rbtn_Add.AutoSize = True
        Me.rbtn_Add.Location = New System.Drawing.Point(37, 112)
        Me.rbtn_Add.Name = "rbtn_Add"
        Me.rbtn_Add.Size = New System.Drawing.Size(44, 17)
        Me.rbtn_Add.TabIndex = 6
        Me.rbtn_Add.TabStop = True
        Me.rbtn_Add.Text = "Add"
        Me.rbtn_Add.UseVisualStyleBackColor = True
        '
        'rbtn_Divide
        '
        Me.rbtn_Divide.AutoSize = True
        Me.rbtn_Divide.Location = New System.Drawing.Point(37, 159)
        Me.rbtn_Divide.Name = "rbtn_Divide"
        Me.rbtn_Divide.Size = New System.Drawing.Size(55, 17)
        Me.rbtn_Divide.TabIndex = 7
        Me.rbtn_Divide.TabStop = True
        Me.rbtn_Divide.Text = "Divide"
        Me.rbtn_Divide.UseVisualStyleBackColor = True
        '
        'lbl_CalculationDecider
        '
        Me.lbl_CalculationDecider.AutoSize = True
        Me.lbl_CalculationDecider.Location = New System.Drawing.Point(172, 135)
        Me.lbl_CalculationDecider.Name = "lbl_CalculationDecider"
        Me.lbl_CalculationDecider.Size = New System.Drawing.Size(22, 13)
        Me.lbl_CalculationDecider.TabIndex = 9
        Me.lbl_CalculationDecider.Text = "....."
        Me.lbl_CalculationDecider.Visible = False
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_CalculationDecider)
        Me.Controls.Add(Me.rbtn_Divide)
        Me.Controls.Add(Me.rbtn_Add)
        Me.Controls.Add(Me.rbtn_Multiply)
        Me.Controls.Add(Me.lbl_Value)
        Me.Controls.Add(Me.txt_EnterNumber)
        Me.Controls.Add(Me.txt_Value2)
        Me.Controls.Add(Me.txt_Value1)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents txt_Value1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Value2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_EnterNumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Value As System.Windows.Forms.Label
    Friend WithEvents rbtn_Multiply As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Add As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Divide As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_CalculationDecider As System.Windows.Forms.Label

End Class
