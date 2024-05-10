Imports System.Drawing.Text
Imports System.Security.Cryptography

Public Class Game
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Public Function RandomNumber(ByVal intNum As Integer) As Integer
        Dim rRnd As New Random(System.DateTime.Now.Millisecond)
        Return rRnd.Next(1, intNum)
    End Function

    Private Sub Button_deal_Click(sender As Object, e As EventArgs) Handles Button_deal.Click
        Label_score_dealer.Text = RandomNumber(21)
        Label_score_player.Text = RandomNumber(21)
        Button_deal.Enabled = False

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
        Label_score_player.Text = Val(Label_score_player.Text) + RandomNumber(21)
        Label_score_dealer.Text = Val(Label_score_dealer.Text) + RandomNumber(21)

        If Label_score_player.Text >= 21 Then 'DEALER WINS

        End If

        If Label_score_dealer.Text >= 21 Then 'PLAYER WINS
            MessageBox.Show("Arr... Ye bested me this time, scallywag!")
        End If

        If Label_score_player.Text >= 21 & Label_score_dealer.Text >= 21 Then
            MessageBox.Show("Avast!") 'DRAW
        End If

    End Sub

    Private Sub Button_stand_Click(sender As Object, e As EventArgs) Handles Button_stand.Click
        If Val(Label_score_player) >= Val(Label_score_dealer.Text) Then
            MessageBox.Show("Arr... Ye bested me this time, scallywag!")
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


