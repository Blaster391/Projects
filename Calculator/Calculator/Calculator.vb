Public Class frmCalculator

    Private Sub frmCalculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_Calculate.Click
        'Declare Variables to be added
        Dim First As Integer
        Dim Second As Integer



        'Make the Variables the entered values.
        First = txt_Value1.Text
        Second = txt_Value2.Text

        '##############################################################
        'This is the important bit, it takes the values and looks at the value of the radio buttons
        'to decide what operation to do.

        If lbl_CalculationDecider.Text = 1 Then
            lbl_Value.Text = First + Second
        ElseIf lbl_CalculationDecider.Text = 2 Then
            lbl_Value.Text = First * Second
        ElseIf lbl_CalculationDecider.Text = 3 Then
            lbl_Value.Text = First / Second
        End If

        '####################################################################

    End Sub

    Private Sub rbtn_Add_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtn_Add.CheckedChanged
        'Value 1 is used to tell the button to do an Addition
        lbl_CalculationDecider.Text = 1

    End Sub


    Private Sub rbtn_Multiply_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtn_Multiply.CheckedChanged
        'Value 2 tells the button to do a multiplication
        lbl_CalculationDecider.Text = 2
    End Sub

    Private Sub rbtn_Divide_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtn_Divide.CheckedChanged
        'Valie 3 tells the button to divide
        lbl_CalculationDecider.Text = 3
    End Sub
End Class
