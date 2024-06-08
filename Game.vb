Public Class Game
    Private Const StartingCoins As Integer = 100
    Private Const MaxBet As Integer = 500
    Private Coins As Integer = StartingCoins
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

    Private Sub PlayerBlackjack()
        MessageBox.Show("Arr... Ye got a blagjag!") 'PLAYER WINS (BLACKJACK)
        AddCoins(50)
    End Sub

    Private Sub PlayerWin()
        MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
        AddCoins(50)
    End Sub

    Private Sub DealerBlackJack()
        MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS (BLACKJACK)
        DeductCoins(50)
    End Sub

    Private Sub DealerWin()
        MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
        DeductCoins(50)
    End Sub

    Private Sub Standoff()
        MessageBox.Show("Avast!") ' DRAW - STANDOFF
    End Sub

    Private Sub ResetGame() 'RESET FUNCTION - Set player & dealer score to 0, re-enable buttons
        Label_score_player.Text = "0"
        Label_score_dealer.Text = "0"
        Button_deal.Enabled = False
        Button_hit.Enabled = True
        Button_stand.Enabled = True
    End Sub

    Private Sub DealFirstHand() 'DEAL FIRST HAND
        Label_score_player.Text = (RandomNumber(11) + RandomNumber(10)).ToString()
        Label_score_dealer.Text = (RandomNumber(11) + RandomNumber(10)).ToString()
    End Sub

    Private Sub CheckForBlackjack() 'CHECKING FOR IMMEDIATE BLACKJACK
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)

        If PlayerScore = 21 Then
            PlayerBlackjack()
            EndGame()
        ElseIf DealerScore = 21 Then
            DealerBlackJack()
            EndGame()
        End If
    End Sub

    Private Sub CheckForEndgame()
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)

        If PlayerScore > 21 Then
            DealerWin()
        ElseIf DealerScore > 21 OrElse PlayerScore > DealerScore Then
            PlayerWin()
        ElseIf PlayerScore < DealerScore Then
            DealerWin()
        Else
            Standoff()
        End If
        EndGame()
    End Sub

    Private Sub EndGame()
        Button_deal.Enabled = True
        Button_hit.Enabled = False
        Button_stand.Enabled = False
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Coins = StartingCoins
        BetAmount = 0
        UpdateCoinCounter()
        ResetGame()
        Button_deal.Enabled = True
    End Sub

    Private Sub Button_deal_Click(sender As Object, e As EventArgs) Handles Button_deal.Click
        ResetGame()
        DealFirstHand()
        CheckForBlackjack()
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
        If Coins >= MaxBet Then
            BetAmount = MaxBet
            Coins -= MaxBet
        Else
            BetAmount = Coins
            Coins = 0
        End If
        UpdateCoinCounter()
    End Sub

    Private Sub Button_hit_Click(sender As Object, e As EventArgs) Handles Button_hit.Click
        Dim PlayerScore As Integer = CInt(Label_score_player.Text)
        PlayerScore += RandomNumber(10)
        Label_score_player.Text = CStr(PlayerScore)

        If PlayerScore >= 21 Then
            CheckForBlackjack()
        End If
    End Sub

    Private Sub Button_stand_Click(sender As Object, e As EventArgs) Handles Button_stand.Click
        Dim DealerScore As Integer = CInt(Label_score_dealer.Text)
        While DealerScore < 17
            DealerScore += RandomNumber(10)
        End While
        Label_score_dealer.Text = DealerScore.ToString
        CheckForEndgame()
    End Sub
End Class
