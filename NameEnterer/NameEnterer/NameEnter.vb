Public Class NameEnter

    Private Sub btn_Confirm_Click(sender As System.Object, e As System.EventArgs) Handles btn_Confirm.Click
        NameList.lst_Names.Items.Add(txt_GetName.Text)
        Me.Visible = False
    End Sub
End Class