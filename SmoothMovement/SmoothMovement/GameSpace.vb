Public Class GameSpace

    '#########################################################################################################################
    'PLAYER MOVEMENT DO NOT TOUCH
    '#########################################################################################################################

    'Starts and stops movement for each key (wasd)
    Private Sub Form1_KeyDown_W(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            tmr_move.Enabled = True
        End If
    End Sub

    Private Sub Form1_KeyUp_W(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            tmr_move.Enabled = False
        End If
    End Sub

    Private Sub Form1_KeyDown_D(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            tmr_left.Enabled = True
        End If
    End Sub
    Private Sub Form1_KeyUp_D(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.D Then
            tmr_left.Enabled = False
        End If
    End Sub

    Private Sub Form1_KeyDown_A(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            tmr_right.Enabled = True
        End If
    End Sub
    Private Sub Form1_KeyUp_A(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then
            tmr_right.Enabled = False
        End If
    End Sub

    Private Sub Form1_KeyDown_S(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then
            tmr_down.Enabled = True
        End If
    End Sub
    Private Sub Form1_KeyUp_S(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.S Then
            tmr_down.Enabled = False
        End If
    End Sub




    'Second Part of movement, the timers that were activated in the first.
    Private Sub tmr_move_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_move.Tick
        lbl_move.Top = lbl_move.Top - 1
    End Sub

    Private Sub tmr_down_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_down.Tick
        lbl_move.Top = lbl_move.Top + 1
    End Sub

    Private Sub tmr_left_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_left.Tick
        lbl_move.Left = lbl_move.Left + 1
    End Sub

    Private Sub tmr_right_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_right.Tick
        lbl_move.Left = lbl_move.Left - 1
    End Sub

    'Turns the player

    Private Sub Form1_KeyDown_WTurn(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            'Player.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
    End Sub





    '#######################################################################################################################
    'GAME FEATURES
    '#######################################################################################################################

    'Right let's get this game started



    Dim Movement As Integer


    'This is the control for the lbl trying to get you.

    Private Sub tmr_winmove_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_winmove.Tick

        If lbl_lose.Top > lbl_move.Top Then

            lbl_lose.Top = lbl_lose.Top - 1

        End If

        If lbl_lose.Top < lbl_move.Top Then

            lbl_lose.Top = lbl_lose.Top + 1

        End If

        If lbl_lose.Left < lbl_move.Left Then

            lbl_lose.Left = lbl_lose.Left + 1

        End If

        If lbl_lose.Left > lbl_move.Left Then

            lbl_lose.Left = lbl_lose.Left - 1

        End If


    End Sub



    'Stuff that runs when the program starts
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Form_PlayerKeys()

        tmr_winmove.Enabled = True
        tmr_deathcheck.Enabled = True
    End Sub

    'Creates the players image


    '####################################################################################################################################
    'NEW MOVEMENT WIP
    '########################################################################################################################################


    Private Sub Form_PlayerKeys(ByVal e As PaintEventArgs)
        Dim Player As Image = Image.FromFile("M:\Visual Studio 2010\Projects\SmoothMovement\SmoothMovement\My Project\green.png")


        e.Graphics.DrawImage(Player, New Rectangle(0, 0, 20, 20))
        Player.RotateFlip(RotateFlipType.Rotate90FlipNone)


    End Sub





    'This timer checks whether the player and lable are on the same spot, if they are, game over...
    Private Sub tmr_deathcheck_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_deathcheck.Tick


        lbl_loc1.Text = lbl_move.Top & " " & lbl_move.Left
        lbl_loc2.Text = lbl_lose.Top & " " & lbl_lose.Left


        If lbl_move.Top < lbl_lose.Top + 20 And lbl_move.Top > lbl_lose.Top - 20 And lbl_move.Left < lbl_lose.Left + 20 And lbl_move.Left > lbl_lose.Left - 20 Then

            MessageBox.Show("Game Over")
            End


        End If

        'Basic Collison detection attempt above, use this if it fails, be aware this is really bad...

        'If lbl_move.Location = lbl_lose.Location Then
        'MessageBox.Show("You got goted by the thing")
        'End If


        'Mouse pointer Location, will be implemented into some other stuff soon...
        lbl_pointerlocation.Text = MousePosition.X & " " & MousePosition.Y



    End Sub

    Private Sub Form_PlayerKeys()
        Throw New NotImplementedException
    End Sub


End Class

