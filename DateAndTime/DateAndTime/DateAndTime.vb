Public Class DateAndTime

    Private Sub btn_Set_Click(sender As System.Object, e As System.EventArgs) Handles btn_Set.Click
        lbl_time.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        Dim Time As Integer

        If Time <= 120 Then

            lbl_timer.Text = Time + 1

        ElseIf lbl_timer.Text >= 120 Then
            lbl_timer.Text = "Fail"
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Do
            Timer.Enabled = True
        Loop
    End Sub

    Private Sub btn_Countdown_Click(sender As System.Object, e As System.EventArgs) Handles btn_Countdown.Click
        Dim CountdownCount As Integer

    End Sub
End Class
