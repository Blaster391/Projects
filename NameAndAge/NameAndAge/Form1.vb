Public Class Form1

    Dim FileName As String

    Private Sub btn_write_Click(sender As System.Object, e As System.EventArgs) Handles btn_write.Click
        Dim Firstname As String
        Dim SecondName As String
        Dim Age As Integer
        Firstname = txt_FirstName.Text
        SecondName = txt_LastName.Text
        Age = txt_Age.Text


        FileOpen(1, FileName, OpenMode.Append)
        WriteLine(1, Firstname & " " & SecondName, Age)
        FileClose()

        txt_FirstName.Text = ""
        txt_LastName.Text = ""
        txt_Age.Text = ""

    End Sub


    Private Sub btn_print_Click(sender As System.Object, e As System.EventArgs) Handles btn_print.Click
        Dim Firstname As String
        Dim SecondName As String
        Dim Age As Integer
        Firstname = txt_FirstName.Text
        SecondName = txt_LastName.Text
        Age = txt_Age.Text

        FileOpen(1, FileName, OpenMode.Append)
        PrintLine(1, Firstname & " " & SecondName, Age)
        FileClose()

        txt_FirstName.Text = ""
        txt_LastName.Text = ""
        txt_Age.Text = ""


    End Sub


    Private Sub btn_Display_Click(sender As System.Object, e As System.EventArgs) Handles btn_Display.Click
        Dim Data As String
        FileOpen(1, FileName, OpenMode.Input)
        lst_display.Items.Clear()
        Do While Not EOF(1)
            Data = LineInput(1)
            lst_display.Items.Add(Data)
        Loop
        FileClose()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FileName = "Names.txt"
    End Sub

    Private Sub txt_LastName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_LastName.TextChanged

    End Sub
End Class
