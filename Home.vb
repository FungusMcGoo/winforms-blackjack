Public Class Home
    Private Sub Button_exit_Click(sender As Object, e As EventArgs) Handles Button_exit.Click
        Application.Exit()
    End Sub

    Private Sub Button_enter_Click(sender As Object, e As EventArgs) Handles Button_enter.Click
        Dim Game As New Game
        'Game.StartPosition = FormStartPosition.Manual
        ''Game.DesktopLocation = Me.DesktopLocation
        'Game.TopMost = True
        'Game.FormBorderStyle = FormBorderStyle.None
        'Game.WindowState = FormWindowState.Maximized
        Game.Show()
        Me.Close()
    End Sub
End Class