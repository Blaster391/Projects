Public Class Start

    Private Sub Start_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        SeatingSelect.Enabled = False

        Me.SetTopLevel(True)
        Me.SetDesktopLocation(200, 200)
        Me.Focus()
        SeatingSelect.Hide()



    End Sub

    Private Sub btn_Exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_Exit.Click

        End

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btn_New.Click

        SeatingSelect.Enabled = True
        Me.Hide()

    End Sub
End Class