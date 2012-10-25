Public Class Form1

    Private Sub btn_Go_Click(sender As System.Object, e As System.EventArgs) Handles btn_Go.Click
        Dim Number As Integer


        Try

            Number = txt_input.Text
            If Number Mod 2 = 0 Then
                lbl_Output.Text = "Even"
                lbl_Output.ForeColor = Color.Green
                Me.BackColor = Color.Cyan
                Me.Text = "EVEN"
            Else
                lbl_Output.Text = "Odd"
                lbl_Output.ForeColor = Color.Blue
                Me.BackColor = Color.LightGreen
                Me.Text = "ODD"
            End If

        Catch

            MessageBox.Show("Please only enter a whole number below 2,147,483,647, you entered " & txt_input.Text & ".")
            lbl_Output.Text = "ERROR"
            txt_input.Text = ""

            Me.BackColor = Color.Red
            Me.Text = "ERROR"

        End Try














    End Sub

End Class
