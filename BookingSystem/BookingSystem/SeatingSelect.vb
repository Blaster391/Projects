Public Class SeatingSelect

    Private Sub SeatingSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Start.Show()




    End Sub

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_exit.Click

        Start.Show()
        Me.Enabled = False


    End Sub
End Class
