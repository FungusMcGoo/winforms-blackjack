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
        Label_score_dealer.Text = RandomNumber(21)
        Label_score_player.Text = RandomNumber(21)
        Button_deal.Enabled = False
        Button_hit.Enabled = True
        Button_stand.Enabled = True


        If Label_score_player.Text = 21 Then 'PLAYER WINS
            MessageBox.Show("Arr... Ye bested me this time, scallywag!")
        End If

        If Label_score_dealer.Text = 21 Then 'DEALER WINS
            MessageBox.Show("Har har har! It be all in the cards matey!")
        End If

        If Label_score_player.Text = 0 Then
            Label_score_player.Text = RandomNumber(21)
        End If

        If Label_score_dealer.Text = 0 Then
            Label_score_dealer.Text = RandomNumber(21)
        End If
    End Sub

    Private Sub Button_hit_Click(sender As Object, e As EventArgs) Handles Button_hit.Click
        Dim PlayerScore As Integer = Val(Label_score_player.Text)
        Dim DealerScore As Integer = Val(Label_score_dealer.Text)
        Dim newCard As Integer = RandomNumber(21)

        If PlayerScore < 21 Then
            PlayerScore += newCard
            Label_score_player.Text = PlayerScore.ToString()
        End If

        If DealerScore < 17 Then
            DealerScore += RandomNumber(21)
            Label_score_dealer.Text = DealerScore.ToString()
        End If

        If PlayerScore > 21 Then 'BUST OR WIN
            If PlayerScore = 21 Then
                MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
            Else
                MessageBox.Show("Har har har! It be all in the cards matey!") 'DEALER WINS
            End If
        End If

        If PlayerScore > 21 OrElse DealerScore >= 21 Then
            Button_hit.Enabled = False
            Button_stand.Enabled = False
        End If

    End Sub

    Private Sub Button_stand_Click(sender As Object, e As EventArgs) Handles Button_stand.Click
        Dim PlayerScore As Integer = Val(Label_score_player.Text)
        Dim DealerScore As Integer = Val(Label_score_dealer.Text)

        'DEALER DRAWS UNTIL >= 17
        While DealerScore < 17
            DealerScore += RandomNumber(21)
            Label_score_dealer.Text = DealerScore.ToString()
        End While

        'COMPARE SCORES AND DECIDE WINNER
        If DealerScore > 21 OrElse (PlayerScore <= 21 AndAlso PlayerScore > DealerScore) Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!") 'PLAYER WINS
        ElseIf PlayerScore = DealerScore Then
            MessageBox.Show("Avast!") 'DRAW
        Else
            MessageBox.Show("Har har har! It be all in the cards matey!")
        End If
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Label_score_player.Text = ""
        Label_score_dealer.Text = ""
        Button_deal.Enabled = True
    End Sub


End Class


