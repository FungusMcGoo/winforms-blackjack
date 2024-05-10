Imports System.Drawing.Text
Imports System.Security.Cryptography

Public Class Game
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Public Shared rRnd As New Random()
    Public Function RandomNumber(ByVal intNum As Integer) As Integer
        Return rRnd.Next(1, intNum)
    End Function

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_hit.Enabled = False
        Button_stand.Enabled = False
    End Sub

    Private Sub Button_deal_Click(sender As Object, e As EventArgs) Handles Button_deal.Click
        Dim PlayerScore As Integer = Val(Label_score_player.Text)
        Dim DealerScore As Integer = Val(Label_score_dealer.Text)
        Dim newCard As Integer = RandomNumber(21)

        'Deal cards and enable player controls
        Label_score_dealer.Text = RandomNumber(21)
        Label_score_player.Text = RandomNumber(21)
        Button_deal.Enabled = False
        Button_hit.Enabled = True
        Button_stand.Enabled = True

        If PlayerScore = 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
        End If

        If DealerScore = 21 Then 'DEALER WINS (BLACKJACK)
            MessageBox.Show("Har har har! It be all in the cards matey!")
        End If

        If PlayerScore = 0 Then
            PlayerScore = newCard
        End If

        If DealerScore = 0 Then
            DealerScore = newCard
        End If
    End Sub

    Private Sub Button_hit_Click(sender As Object, e As EventArgs) Handles Button_hit.Click
        Dim PlayerScore As Integer = Val(Label_score_player.Text)
        Dim DealerScore As Integer = Val(Label_score_dealer.Text)
        Dim newCard As Integer = RandomNumber(21)

        'PLAYER draws a card
        If PlayerScore < 21 Then
            PlayerScore += newCard
            Label_score_player.Text = PlayerScore.ToString()
        End If

        'DEALER draws a card
        If DealerScore < 17 Then
            DealerScore += RandomNumber(21)
            Label_score_dealer.Text = DealerScore.ToString()
        End If

        If PlayerScore >= 21 Then 'PLAYER BUST OR WIN
            If PlayerScore = 21 Then
                MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
            Else
                MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
            End If
        End If

        If DealerScore >= 21 Then 'DEALER BUST OR WIN
            If DealerScore = 21 Then
                MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
            Else
                MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
            End If
        End If

        If PlayerScore >= 21 OrElse DealerScore >= 21 Then 'GAME OVER - HIT AND STAND DISABLED
            Button_hit.Enabled = False
            Button_stand.Enabled = False
        End If
    End Sub

    Private Sub Button_stand_Click(sender As Object, e As EventArgs) Handles Button_stand.Click
        Dim PlayerScore As Integer = Val(Label_score_player.Text)
        Dim DealerScore As Integer = Val(Label_score_dealer.Text)

        'DEALER draws a card until >= 17
        While DealerScore < 17
            DealerScore += RandomNumber(21)
            Label_score_dealer.Text = DealerScore.ToString()
        End While

        'Compare scores and decide on a winner
        If PlayerScore = 21 And DealerScore <> 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
        ElseIf DealerScore = 21 And PlayerScore <> 21 Then
            MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
        ElseIf PlayerScore > 21 And DealerScore <= 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
        ElseIf DealerScore > 21 And PlayerScore <= 21 Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
        ElseIf PlayerScore > DealerScore Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
        ElseIf DealerScore > PlayerScore Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
        ElseIf PlayerScore = DealerScore Then
            MessageBox.Show("Avast!") ' DRAW
        ElseIf PlayerScore < 21 And DealerScore = 21 Then
            MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
        ElseIf DealerScore < 21 And PlayerScore = 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
        ElseIf PlayerScore < 21 And DealerScore > 21 Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS (DEALER BUST)
        ElseIf PlayerScore And DealerScore > 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS (PLAYER & DEALER BUST)
        End If

        'Game over - Disable player controls 
        If PlayerScore >= 21 OrElse DealerScore >= 21 Then 'GAME OVER - HIT AND STAND DISABLED
            Button_hit.Enabled = False
            Button_stand.Enabled = False
        Else
            Button_hit.Enabled = True
            Button_stand.Enabled = True
        End If

    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Label_score_player.Text = ""
        Label_score_dealer.Text = ""
        Button_deal.Enabled = True
    End Sub
End Class

'Current Bugs/implementations/improvements:
'*When player stands and dealer draws less than 21, player controls will be disabled
'*Standoff will occur less than 21 and end the game, standoff should only occur greater than 21
'*Buttons do not disable after a win occurs below 21. i.e. dealer is 17> and cannot draw, player is 17> but also <21; when player stands it should be a player win but no logic in place for recognising that
'*No logic in place for applying a player loss when BOTH dealer and player bust



