Public Class Loop1


    Private Sub btn_LoopStart_Click(sender As System.Object, e As System.EventArgs) Handles btn_LoopStart.Click
        Dim LoopValue
        LoopValue = txt_LoopStart.Text
        Do While LoopValue <= txt_EndValue.Text
            LoopValue = LoopValue + 1
            ListBox1.Items.Add(LoopValue)
        Loop

    End Sub
End Class
