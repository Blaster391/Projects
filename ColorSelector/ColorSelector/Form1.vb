Public Class Form1

    Private Sub btn_Color_Click(sender As System.Object, e As System.EventArgs) Handles btn_Color.Click
        ColorDialog1.ShowDialog()
        txt_Text.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub btn_Color_MouseDown(sender As System.Object, e As System.EventArgs) Handles btn_Color.MouseDown
        btn_Color.BackColor = Color.Red
    End Sub
    Private Sub btn_Color_MouseUp(sender As System.Object, e As System.EventArgs) Handles btn_Color.MouseUp
        btn_Color.BackColor = Color.AliceBlue
    End Sub
End Class
