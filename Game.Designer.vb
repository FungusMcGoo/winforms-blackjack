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
        CType(PictureBox_pirate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_deal
        ' 
        Button_deal.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Button_hit.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Button_stand.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label_dealer.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label_player.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label_score_dealer.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label_score_player.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_score_player.Location = New Point(172, 87)
        Label_score_player.Margin = New Padding(4, 0, 4, 0)
        Label_score_player.Name = "Label_score_player"
        Label_score_player.Size = New Size(28, 28)
        Label_score_player.TabIndex = 7
        Label_score_player.Text = "0"
        ' 
        ' Button_exit
        ' 
        Button_exit.Font = New Font("Algerian", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Label_coins.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_coins.Location = New Point(1292, 729)
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
        label_score_coins.Font = New Font("Algerian", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        label_score_coins.Location = New Point(1406, 729)
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
        ' Game
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1692, 793)
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
        Font = New Font("Algerian", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
End Class
