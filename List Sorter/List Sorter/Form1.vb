Public Class Form1

    Dim NumberList(0 To 100) As Integer
    Dim ListSpace As Integer = 0

    Private Sub btn_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click

        Dim Number As Integer

        If IsNumeric(txt_add.Text) = True Then
            lst_list.Items.Add(txt_add.Text)
            NumberList(ListSpace) = txt_add.Text
            ListSpace = ListSpace + 1
            Number = txt_add.Text
        End If


        'Open the file for Random Access - Change the file path if needed
        FileOpen(1, "M:\Array.txt", OpenMode.Random)



        FilePut(1, ListSpace, Number)

        FileClose(1)

    End Sub

    Private Sub btn_sort_Click(sender As System.Object, e As System.EventArgs) Handles btn_sort.Click


        Dim ListCounter As Integer = 0
        Dim TotalList As Integer = lst_list.Items.Count

        lbl_total.Text = TotalList

        FileOpen(1, "M:\Array.txt", OpenMode.Input)

        Do Until EOF(1)

            lst_list.Items.Add(LineInput(ListSpace))

            ListSpace = ListSpace + 1


        Loop

        FileClose(1)


    End Sub
End Class
