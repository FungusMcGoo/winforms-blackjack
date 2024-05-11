<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        Button_exit = New Button()
        Button_enter = New Button()
        PictureBox_pirate = New PictureBox()
        CType(PictureBox_pirate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_exit
        ' 
        Button_exit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button_exit.Font = New Font("Algerian", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Button_exit.Location = New Point(497, 564)
        Button_exit.Name = "Button_exit"
        Button_exit.RightToLeft = RightToLeft.No
        Button_exit.Size = New Size(163, 41)
        Button_exit.TabIndex = 0
        Button_exit.Text = "Arr..."
        Button_exit.UseVisualStyleBackColor = True
        ' 
        ' Button_enter
        ' 
        Button_enter.Font = New Font("Algerian", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Button_enter.Location = New Point(418, 471)
        Button_enter.Name = "Button_enter"
        Button_enter.RightToLeft = RightToLeft.No
        Button_enter.Size = New Size(316, 87)
        Button_enter.TabIndex = 1
        Button_enter.Text = "Ahoy!"
        Button_enter.UseVisualStyleBackColor = True
        ' 
        ' PictureBox_pirate
        ' 
        PictureBox_pirate.Image = CType(resources.GetObject("PictureBox_pirate.Image"), Image)
        PictureBox_pirate.Location = New Point(365, 111)
        PictureBox_pirate.Name = "PictureBox_pirate"
        PictureBox_pirate.Size = New Size(467, 354)
        PictureBox_pirate.TabIndex = 12
        PictureBox_pirate.TabStop = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 617)
        ControlBox = False
        Controls.Add(PictureBox_pirate)
        Controls.Add(Button_enter)
        Controls.Add(Button_exit)
        Font = New Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "Home"
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox_pirate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button_exit As Button
    Friend WithEvents Button_enter As Button
    Friend WithEvents PictureBox_pirate As PictureBox
End Class
