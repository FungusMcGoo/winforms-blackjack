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
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button_deal
        ' 
        Button_deal.Location = New Point(282, 586)
        Button_deal.Name = "Button_deal"
        Button_deal.Size = New Size(189, 63)
        Button_deal.TabIndex = 0
        Button_deal.Text = "Deal"
        Button_deal.UseVisualStyleBackColor = True
        ' 
        ' Button_hit
        ' 
        Button_hit.Location = New Point(477, 586)
        Button_hit.Name = "Button_hit"
        Button_hit.Size = New Size(189, 63)
        Button_hit.TabIndex = 1
        Button_hit.Text = "Hit"
        Button_hit.UseVisualStyleBackColor = True
        ' 
        ' Button_stand
        ' 
        Button_stand.Location = New Point(672, 586)
        Button_stand.Name = "Button_stand"
        Button_stand.Size = New Size(189, 63)
        Button_stand.TabIndex = 2
        Button_stand.Text = "Stand"
        Button_stand.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(1116, 598)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(56, 38)
        Button_reset.TabIndex = 3
        Button_reset.Text = "R"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' Label_dealer
        ' 
        Label_dealer.AutoSize = True
        Label_dealer.Location = New Point(12, 9)
        Label_dealer.Name = "Label_dealer"
        Label_dealer.Size = New Size(43, 15)
        Label_dealer.TabIndex = 4
        Label_dealer.Text = "Dealer:"
        ' 
        ' Label_player
        ' 
        Label_player.AutoSize = True
        Label_player.Location = New Point(12, 33)
        Label_player.Name = "Label_player"
        Label_player.Size = New Size(42, 15)
        Label_player.TabIndex = 5
        Label_player.Text = "Player:"
        ' 
        ' Label_score_dealer
        ' 
        Label_score_dealer.AutoSize = True
        Label_score_dealer.BorderStyle = BorderStyle.Fixed3D
        Label_score_dealer.Location = New Point(61, 9)
        Label_score_dealer.Name = "Label_score_dealer"
        Label_score_dealer.Size = New Size(15, 17)
        Label_score_dealer.TabIndex = 6
        Label_score_dealer.Text = "0"
        ' 
        ' Label_score_player
        ' 
        Label_score_player.AutoSize = True
        Label_score_player.BorderStyle = BorderStyle.Fixed3D
        Label_score_player.Location = New Point(61, 33)
        Label_score_player.Name = "Label_score_player"
        Label_score_player.Size = New Size(15, 17)
        Label_score_player.TabIndex = 7
        Label_score_player.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 598)
        Button1.Name = "Button1"
        Button1.Size = New Size(56, 38)
        Button1.TabIndex = 8
        Button1.Text = "Arr..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Game
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1184, 661)
        Controls.Add(Button1)
        Controls.Add(Label_score_player)
        Controls.Add(Label_score_dealer)
        Controls.Add(Label_player)
        Controls.Add(Label_dealer)
        Controls.Add(Button_reset)
        Controls.Add(Button_stand)
        Controls.Add(Button_hit)
        Controls.Add(Button_deal)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Game"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Blagjag: Pirate Blackjack"
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
    Friend WithEvents Button1 As Button
End Class
