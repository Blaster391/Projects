Public Class Form1

    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click
        SaveFileDialog1.ShowDialog()
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        'Check that a filename has been entered
        If SaveFileDialog1.FileName <> "" Then
            'Write the text to the file
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txt_Save.Text & "Winning", False)
        End If
    End Sub

    Private Sub btn_Load_Click(sender As System.Object, e As System.EventArgs) Handles btn_Load.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"

        'Load The Text
        lbl_LoadData.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

    End Sub
End Class
