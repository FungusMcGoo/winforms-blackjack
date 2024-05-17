Imports System.Drawing.Text
Imports System.Security.Cryptography

Public Class Game
    Private Const PlayerCoins As Integer = 100
    Private Const MaxBet As Integer = 500
    Private Coins As Integer = PlayerCoins
    Private BetAmount As Integer = 0
    Public Shared rRnd As New Random()

    Private Sub Button_exit_Click(sender As Object, e As EventArgs) Handles Button_exit.Click
        Application.Exit()
    End Sub

    Public Function RandomNumber(ByVal intNum As Integer) As Integer
        Return rRnd.Next(1, intNum)
    End Function

    Private Sub UpdateCoinCounter()
        label_score_coins.Text = Coins.ToString
        Label_Bet_Amount.Text = BetAmount.ToString
    End Sub

    Private Sub DeductCoins(amount As Integer)
        Coins -= amount
        UpdateCoinCounter()
    End Sub

    Private Sub AddCoins(amount As Integer)
        Coins += amount
        UpdateCoinCounter()
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_hit.Enabled = False
        Button_stand.Enabled = False
        UpdateCoinCounter()
    End Sub

    '********* WIP *********
    Private Sub ResetGame() 'RESET FUNCTION
        Label_score_player.Text = "0"
        Label_score_dealer.Text = "0"
        Button_deal.Enabled = False
        Button_hit.Enabled = True
        Button_stand.Enabled = True
    End Sub

    Private Sub DealFirstHand() 'DEAL FIRST HAND
        Label_score_player.Text = RandomNumber(11).ToString()
        Label_score_player.Text = RandomNumber(11).ToString()
        Label_score_player.Text = (CInt(Label_score_player.Text) + RandomNumber(10))
        Label_score_dealer.Text = (CInt(Label_score_dealer.Text) + RandomNumber(10))
    End Sub

    Private Sub CheckForBlackjack() 'CHECKING FOR IMMEDIATE BLACKJACK
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)

        If PlayerScore = 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
            AddCoins(BetAmount * 2)
            '*END GAME FUNCTION HERE*
        ElseIf DealerScore = 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS (BLACKJACK)
            DeductCoins(BetAmount)
            '*END GAME FUNCTION HERE*
        End If
    End Sub


    'TODO: Create EndGame and CheckForEndGame functions before overhauling logic in player controls
    '********* WIP *********

    Private Sub Button_deal_Click(sender As Object, e As EventArgs) Handles Button_deal.Click
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)
        Dim newCard As Integer = RandomNumber(21)

        'Deal cards and enable player controls
        Label_score_dealer.Text = RandomNumber(21)
        Label_score_player.Text = RandomNumber(21)
        Button_deal.Enabled = False
        Button_hit.Enabled = True
        Button_stand.Enabled = True

        If PlayerScore = 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
            AddCoins(50)
        End If

        If DealerScore = 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS (BLACKJACK)
            DeductCoins(50)
        End If

        If PlayerScore = 0 Then
            PlayerScore = newCard
        End If

        If DealerScore = 0 Then
            DealerScore = newCard
        End If
    End Sub

    Private Sub Button_hit_Click(sender As Object, e As EventArgs) Handles Button_hit.Click
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)
        Dim newCard As Integer = RandomNumber(21)

        'If stand button has been disabled to prevent player looping, reenable when player hits
        If Button_stand.Enabled = False Then
            Button_stand.Enabled = True
        End If

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
                AddCoins(50)
            Else
                MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
                DeductCoins(50)
            End If
        End If

        If DealerScore >= 21 Then 'DEALER BUST OR WIN
            If DealerScore = 21 Then
                MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
                DeductCoins(50)
            Else
                MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
                AddCoins(50)
            End If
        End If

        If PlayerScore >= 21 OrElse DealerScore >= 21 Then 'GAME OVER - HIT AND STAND DISABLED
            Button_hit.Enabled = False
            Button_stand.Enabled = False
        End If
    End Sub

    Private Sub Button_stand_Click(sender As Object, e As EventArgs) Handles Button_stand.Click
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)

        'DEALER draws a card until >= 17
        While DealerScore < 17
            DealerScore += RandomNumber(21)
            Label_score_dealer.Text = DealerScore.ToString()
        End While

        'Compare scores and decide on a winner
        If PlayerScore = 21 And DealerScore <> 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
            AddCoins(50)
        ElseIf DealerScore = 21 And PlayerScore <> 21 Then
            MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
            DeductCoins(50)
        ElseIf PlayerScore > 21 And DealerScore <= 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
            DeductCoins(50)
        ElseIf DealerScore > 21 And PlayerScore <= 21 Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
            AddCoins(50)
        ElseIf PlayerScore > DealerScore Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
            AddCoins(50)
        ElseIf DealerScore > PlayerScore Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
            DeductCoins(50)
        ElseIf PlayerScore And DealerScore = 21 Then
            MessageBox.Show("Avast!") ' DRAW - STANDOFF
        ElseIf PlayerScore < 21 And DealerScore = 21 Then
            MessageBox.Show("Har har har! BLAAAAAGJAAAAGG!") 'DEALER WINS (BLACKJACK)
            DeductCoins(50)
        ElseIf DealerScore < 21 And PlayerScore = 21 Then
            MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
            AddCoins(50)
        ElseIf PlayerScore < 21 And DealerScore > 21 Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS (DEALER BUST)
            AddCoins(50)
        ElseIf PlayerScore And DealerScore > 21 Then
            MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS (PLAYER & DEALER BUST)
            DeductCoins(50)
        End If


        'Game over - Disable player controls 
        If PlayerScore >= 21 OrElse DealerScore >= 21 Then 'GAME OVER - HIT AND STAND DISABLED
            Button_hit.Enabled = False
            Button_stand.Enabled = False
        Else
            Button_hit.Enabled = True 'KEEP PLAYER CONTROLS ACTIVE UNTIL PLAYER OR DEALER 21>
            Button_stand.Enabled = True
        End If
    End Sub

    'RESET
    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Label_score_player.Text = ""
        Label_score_dealer.Text = ""
        Button_deal.Enabled = True
    End Sub

    'Increase Bet
    Private Sub Button_bet_increase_Click(sender As Object, e As EventArgs) Handles Button_bet_increase.Click
        If BetAmount + 10 <= MaxBet AndAlso BetAmount + 10 <= Coins Then
            BetAmount += 10
            DeductCoins(10)
        End If
    End Sub

    'Decrease Bet
    Private Sub Button_bet_decrease_Click(sender As Object, e As EventArgs) Handles Button_bet_decrease.Click
        If BetAmount - 10 >= 0 Then
            BetAmount -= 10
            AddCoins(10)
        End If
    End Sub

    'Max Bet
    Private Sub Button_bet_maximum_Click(sender As Object, e As EventArgs) Handles Button_bet_maximum.Click
        If Coins >= MaxBet Then 'Make fixing
            BetAmount = MaxBet
            Coins -= MaxBet
            UpdateCoinCounter()
        Else
            BetAmount = Coins
            Coins = 0
            UpdateCoinCounter()
        End If
    End Sub
End Class

