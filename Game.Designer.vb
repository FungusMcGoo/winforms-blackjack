<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Game))
        Button_deal = New Button()
        Button_hit = New Button()
        Button_stand = New Button()
        Button_reset = New Button()
        Label_dealer = New Label()
        Label_player = New Label()
        Label_score_dealer = New Label()
        Label_score_player = New Label()
        Button_exit = New Button()
        Label_coins = New Label()
        label_score_coins = New Label()
        PictureBox_pirate = New PictureBox()
        Label1 = New Label()
        Label_Bet_Amount = New Label()
        Button_bet_increase = New Button()
        Button_bet_decrease = New Button()
        Button_bet_maximum = New Button()
        CType(PictureBox_pirate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_deal
        ' 
        Button_deal.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button_deal.Location = New Point(402, 703)
        Button_deal.Margin = New Padding(4, 3, 4, 3)
        Button_deal.Name = "Button_deal"
        Button_deal.Size = New Size(270, 75)
        Button_deal.TabIndex = 0
        Button_deal.Text = "Deal"
        Button_deal.UseVisualStyleBackColor = True
        ' 
        ' Button_hit
        ' 
        Button_hit.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button_hit.Location = New Point(682, 703)
        Button_hit.Margin = New Padding(4, 3, 4, 3)
        Button_hit.Name = "Button_hit"
        Button_hit.Size = New Size(270, 75)
        Button_hit.TabIndex = 1
        Button_hit.Text = "Hit"
        Button_hit.UseVisualStyleBackColor = True
        ' 
        ' Button_stand
        ' 
        Button_stand.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button_stand.Location = New Point(960, 703)
        Button_stand.Margin = New Padding(4, 3, 4, 3)
        Button_stand.Name = "Button_stand"
        Button_stand.Size = New Size(270, 75)
        Button_stand.TabIndex = 2
        Button_stand.Text = "Stand"
        Button_stand.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(1594, 717)
        Button_reset.Margin = New Padding(4, 3, 4, 3)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(80, 45)
        Button_reset.TabIndex = 3
        Button_reset.Text = "R"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' Label_dealer
        ' 
        Label_dealer.AutoSize = True
        Label_dealer.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_dealer.Location = New Point(22, 19)
        Label_dealer.Margin = New Padding(4, 0, 4, 0)
        Label_dealer.Name = "Label_dealer"
        Label_dealer.Size = New Size(108, 26)
        Label_dealer.TabIndex = 4
        Label_dealer.Text = "Dealer:"
        Label_dealer.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_player
        ' 
        Label_player.AutoSize = True
        Label_player.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_player.Location = New Point(22, 87)
        Label_player.Margin = New Padding(4, 0, 4, 0)
        Label_player.Name = "Label_player"
        Label_player.Size = New Size(108, 26)
        Label_player.TabIndex = 5
        Label_player.Text = "Player:"
        ' 
        ' Label_score_dealer
        ' 
        Label_score_dealer.AutoSize = True
        Label_score_dealer.BorderStyle = BorderStyle.Fixed3D
        Label_score_dealer.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_score_dealer.Location = New Point(172, 19)
        Label_score_dealer.Margin = New Padding(4, 0, 4, 0)
        Label_score_dealer.Name = "Label_score_dealer"
        Label_score_dealer.Size = New Size(28, 28)
        Label_score_dealer.TabIndex = 6
        Label_score_dealer.Text = "0"
        ' 
        ' Label_score_player
        ' 
        Label_score_player.AutoSize = True
        Label_score_player.BorderStyle = BorderStyle.Fixed3D
        Label_score_player.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_score_player.Location = New Point(172, 87)
        Label_score_player.Margin = New Padding(4, 0, 4, 0)
        Label_score_player.Name = "Label_score_player"
        Label_score_player.Size = New Size(28, 28)
        Label_score_player.TabIndex = 7
        Label_score_player.Text = "0"
        ' 
        ' Button_exit
        ' 
        Button_exit.Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button_exit.Location = New Point(34, 720)
        Button_exit.Margin = New Padding(4, 3, 4, 3)
        Button_exit.Name = "Button_exit"
        Button_exit.Size = New Size(102, 41)
        Button_exit.TabIndex = 8
        Button_exit.Text = "Arr..."
        Button_exit.UseVisualStyleBackColor = True
        ' 
        ' Label_coins
        ' 
        Label_coins.AutoSize = True
        Label_coins.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_coins.Location = New Point(1512, 32)
        Label_coins.Margin = New Padding(4, 0, 4, 0)
        Label_coins.Name = "Label_coins"
        Label_coins.Size = New Size(81, 26)
        Label_coins.TabIndex = 9
        Label_coins.Text = "Coins:"
        ' 
        ' label_score_coins
        ' 
        label_score_coins.AutoSize = True
        label_score_coins.BorderStyle = BorderStyle.Fixed3D
        label_score_coins.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        label_score_coins.Location = New Point(1608, 32)
        label_score_coins.Margin = New Padding(4, 0, 4, 0)
        label_score_coins.Name = "label_score_coins"
        label_score_coins.Size = New Size(28, 28)
        label_score_coins.TabIndex = 10
        label_score_coins.Text = "0"
        ' 
        ' PictureBox_pirate
        ' 
        PictureBox_pirate.Image = CType(resources.GetObject("PictureBox_pirate.Image"), Image)
        PictureBox_pirate.Location = New Point(576, 80)
        PictureBox_pirate.Margin = New Padding(4, 3, 4, 3)
        PictureBox_pirate.Name = "PictureBox_pirate"
        PictureBox_pirate.Size = New Size(472, 609)
        PictureBox_pirate.TabIndex = 11
        PictureBox_pirate.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(1248, 664)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 26)
        Label1.TabIndex = 12
        Label1.Text = "Bet:"
        ' 
        ' Label_Bet_Amount
        ' 
        Label_Bet_Amount.AutoSize = True
        Label_Bet_Amount.BorderStyle = BorderStyle.Fixed3D
        Label_Bet_Amount.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Bet_Amount.Location = New Point(1328, 664)
        Label_Bet_Amount.Margin = New Padding(4, 0, 4, 0)
        Label_Bet_Amount.Name = "Label_Bet_Amount"
        Label_Bet_Amount.Size = New Size(28, 28)
        Label_Bet_Amount.TabIndex = 13
        Label_Bet_Amount.Text = "0"
        ' 
        ' Button_bet_increase
        ' 
        Button_bet_increase.Location = New Point(1248, 568)
        Button_bet_increase.Name = "Button_bet_increase"
        Button_bet_increase.Size = New Size(112, 80)
        Button_bet_increase.TabIndex = 14
        Button_bet_increase.Text = "UP"
        Button_bet_increase.UseVisualStyleBackColor = True
        ' 
        ' Button_bet_decrease
        ' 
        Button_bet_decrease.Location = New Point(1248, 704)
        Button_bet_decrease.Name = "Button_bet_decrease"
        Button_bet_decrease.Size = New Size(112, 80)
        Button_bet_decrease.TabIndex = 15
        Button_bet_decrease.Text = "DOWN"
        Button_bet_decrease.UseVisualStyleBackColor = True
        ' 
        ' Button_bet_maximum
        ' 
        Button_bet_maximum.Location = New Point(1376, 664)
        Button_bet_maximum.Name = "Button_bet_maximum"
        Button_bet_maximum.Size = New Size(56, 32)
        Button_bet_maximum.TabIndex = 16
        Button_bet_maximum.Text = "MAX"
        Button_bet_maximum.UseVisualStyleBackColor = True
        ' 
        ' Game
        ' 
        AutoScaleDimensions = New SizeF(10F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1692, 793)
        Controls.Add(Button_bet_maximum)
        Controls.Add(Button_bet_decrease)
        Controls.Add(Button_bet_increase)
        Controls.Add(Label_Bet_Amount)
        Controls.Add(Label1)
        Controls.Add(PictureBox_pirate)
        Controls.Add(label_score_coins)
        Controls.Add(Label_coins)
        Controls.Add(Button_exit)
        Controls.Add(Label_score_player)
        Controls.Add(Label_score_dealer)
        Controls.Add(Label_player)
        Controls.Add(Label_dealer)
        Controls.Add(Button_reset)
        Controls.Add(Button_stand)
        Controls.Add(Button_hit)
        Controls.Add(Button_deal)
        Font = New Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Game"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Blagjag: Pirate Blackjack"
        CType(PictureBox_pirate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_deal As Button
    Friend WithEvents Button_hit As Button
    Friend WithEvents Button_stand As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Label_dealer As Label
    Friend WithEvents Label_player As Label
    Friend WithEvents Label_score_dealer As Label
    Friend WithEvents Label_score_player As Label
    Friend WithEvents Button_exit As Button
    Friend WithEvents Label_coins As Label
    Friend WithEvents label_score_coins As Label
    Friend WithEvents PictureBox_pirate As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Bet_Amount As Label
    Friend WithEvents Button_bet_increase As Button
    Friend WithEvents Button_bet_decrease As Button
    Friend WithEvents Button_bet_maximum As Button
End Class
