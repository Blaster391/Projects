Public Class Form1



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '  If Dir("../../../data.txt") <> "" Then
        'MessageBox.Show("File Exists")
        'End If
        FileOpen(1, "../../../data.txt", OpenMode.Input)

        Dim Number(1) As Decimal
        Dim Counter As Integer = 0


        Do While Not EOF(1)

            Number(Counter) = LineInput(1)
            Counter = Counter + 1



        Loop

        lbl_Value1.Text = Number(0)
        lbl_Value2.Text = Number(1)


        FileClose(1)

    End Sub

    Private Sub btn_ValueSave_Click(sender As System.Object, e As System.EventArgs) Handles btn_ValueSave.Click

        Dim Value(1) As Decimal

        FileOpen(1, "../../../data/data.text", OpenMode.Output)

        PrintLine(1, txt_Value1.Text)
        PrintLine(1, txt_Value2.Text)


        FileClose(1)


        FileOpen(1, "../../../data.txt", OpenMode.Input)

        Dim Number(1) As Decimal
        Dim Counter As Integer = 0


        Do While Not EOF(1)

            Number(Counter) = LineInput(1)
            Counter = Counter + 1



        Loop

        lbl_Value1.Text = Number(0)
        lbl_Value2.Text = Number(1)


        FileClose(1)



    End Sub
End Class
