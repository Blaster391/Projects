Public Class EnterData


    'Creates the Records Structure
    Structure MemberRecord
        Dim ID As Integer
        Dim FirstName As String
        Dim SecondName As String
        Dim Actor As Boolean
    End Structure



    Private Sub btn_EnterInformation_Click(sender As System.Object, e As System.EventArgs) Handles btn_EnterInformation.Click


        'Assigns the Correct Variables to the record
        Dim Member As MemberRecord

        Try
            Member.ID = txt_ID.Text
            Member.FirstName = txt_FirstName.Text
            Member.SecondName = txt_SecondName.Text
        Catch
            MessageBox.Show("I think you did not enter a whole number silly person")
        End Try

        If chk_Coder.Checked = True Then
            Member.Actor = True
        Else
            Member.Actor = False
        End If

        'Allocate a file number - (let the computer do it!)
        Dim FileNum As Integer
        FileNum = FreeFile()



        'Open the file for Random Access - Change the file path if needed
        FileOpen(FileNum, "M:\Record.dat", OpenMode.Random)

        Dim RecNum As Integer
        Try

            If Member.ID < 0 And Member.ID < 10 Then

                Member.ID = Member.ID * 10000
                RecNum = Member.ID - 1000
                MessageBox.Show("Your ID is now " & RecNum + 1000)

            ElseIf Member.ID < 10 And Member.ID < 100 Then

                Member.ID = Member.ID * 1000 + 1
                RecNum = Member.ID - 1000
                MessageBox.Show("Your ID is now " & RecNum + 1000)

            ElseIf Member.ID < 100 And Member.ID < 1000 Then

                Member.ID = Member.ID * 100 + 1
                RecNum = Member.ID - 1000
                MessageBox.Show("Your ID is now " & RecNum + 1000)

            Else

                RecNum = Member.ID - 1000

            End If


            'Places all the data in a record
            FilePut(FileNum, Member, RecNum)
        Catch

            MessageBox.Show("An Error Has Occoured, please verify that your ID is over 1000 and try again")

        End Try

        'Close the silly thing
        FileClose(FileNum)


        'Clear The Textboxes ready for the next
        txt_FirstName.Text = ""
        txt_SecondName.Text = ""
        txt_ID.Text = ""
        chk_Coder.Checked = False





    End Sub

    Private Sub btn_Load_Click(sender As System.Object, e As System.EventArgs) Handles btn_Load.Click

        LoadData.Show()
        Me.Hide()


    End Sub
End Class
