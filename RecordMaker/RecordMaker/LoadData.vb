Public Class LoadData

    Structure MemberRecord
        Dim ID As Integer
        Dim FirstName As String
        Dim SecondName As String
        Dim Actor As Boolean
    End Structure

    Private Sub btn_Search_Click(sender As System.Object, e As System.EventArgs) Handles btn_Search.Click
        Dim Member As MemberRecord


        Try

            Member.ID = txt_ID.Text
            Member.FirstName = 1
            Member.SecondName = 1
            Member.Actor = False

        Catch
            MessageBox.Show("Please Enter a valid ID")
            Member.ID = 1001
        End Try


        'Allocate a file number - (let the computer do it!)
        Dim FileNum As Integer
        FileNum = FreeFile()

        'Open the file for Random Access - Change the file path if needed
        FileOpen(FileNum, "M:\Record.dat", OpenMode.Random)


        Dim RecNum As Integer
        RecNum = Member.ID - 1000

        FileGet(FileNum, Member, RecNum)

        txt_FirstName.Text = Member.FirstName
        txt_SecondName.Text = Member.SecondName

        'Close the file
        FileClose(FileNum)
    End Sub

    Private Sub btn_EnterDataGo_Click(sender As System.Object, e As System.EventArgs) Handles btn_EnterDataGo.Click
        EnterData.Show()
        Me.Hide()
    End Sub
End Class