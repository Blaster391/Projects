Public Class Factors

    Private Sub btn_FindFactors_Click(sender As System.Object, e As System.EventArgs) Handles btn_FindFactors.Click

        lst_Factors.Items.Clear()


        Dim EnteredNumber As Long
        Dim Divider As Long = 1

        EnteredNumber = txt_FactorEnter.Text

        Do Until Divider = EnteredNumber / 2


            If EnteredNumber Mod Divider = 0 Then
                lst_Factors.Items.Add(Divider)

            End If
            Divider = Divider + 1

        Loop



    End Sub
End Class
