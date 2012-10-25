Public Class Form1

    Private Sub btn_Run_Click(sender As System.Object, e As System.EventArgs) Handles btn_Run.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim multiplier As Integer
        Dim answer As Integer
        Dim i As Integer

        number1 = txt_Start.Text
        number2 = txt_End.Text
        multiplier = txt_multiplier.Text


        Do While multiplier < 30
            For i = number1 To number2
                answer = i * multiplier
                list_list.Items.Add(i & " Times " & multiplier & " = " & answer)
            Next i
            multiplier = multiplier + 1
        Loop

    End Sub

    Private Sub list_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_list.SelectedIndexChanged

    End Sub
End Class
