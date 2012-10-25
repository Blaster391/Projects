Public Class HelloWorld

    Private Sub txt_Name_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Name.TextChanged

    End Sub

    Private Sub btn_Hello_Click(sender As System.Object, e As System.EventArgs) Handles btn_Hello.Click
        lbl_Hello.Text = "Hello: " & txt_Name.Text
        lbl_Hello.ForeColor = Color.Azure 'This changes the font color
        btn_Hello.Visible = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_coloryeallow.Click
        lbl_Hello.ForeColor = Color.Yellow
        btn_Hello.Visible = True
    End Sub

    Private Sub HelloWorld_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_Hello.Text = "HIIIIIIIIIIIIIIIIII"
    End Sub
End Class
