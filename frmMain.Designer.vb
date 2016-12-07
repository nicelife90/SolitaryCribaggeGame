<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblGameTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvellePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatistiqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierLapparenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.card16 = New System.Windows.Forms.PictureBox()
        Me.card15 = New System.Windows.Forms.PictureBox()
        Me.card14 = New System.Windows.Forms.PictureBox()
        Me.card13 = New System.Windows.Forms.PictureBox()
        Me.card12 = New System.Windows.Forms.PictureBox()
        Me.card11 = New System.Windows.Forms.PictureBox()
        Me.card10 = New System.Windows.Forms.PictureBox()
        Me.card9 = New System.Windows.Forms.PictureBox()
        Me.card8 = New System.Windows.Forms.PictureBox()
        Me.card7 = New System.Windows.Forms.PictureBox()
        Me.card6 = New System.Windows.Forms.PictureBox()
        Me.card5 = New System.Windows.Forms.PictureBox()
        Me.imgCard = New System.Windows.Forms.PictureBox()
        Me.card4 = New System.Windows.Forms.PictureBox()
        Me.card3 = New System.Windows.Forms.PictureBox()
        Me.card2 = New System.Windows.Forms.PictureBox()
        Me.card1 = New System.Windows.Forms.PictureBox()
        Me.imgDeck = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.card16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblGameTimer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(968, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblGameTimer
        '
        Me.lblGameTimer.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameTimer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblGameTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblGameTimer.Name = "lblGameTimer"
        Me.lblGameTimer.Size = New System.Drawing.Size(55, 19)
        Me.lblGameTimer.Text = " : Temps"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartieToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(968, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PartieToolStripMenuItem
        '
        Me.PartieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvellePartieToolStripMenuItem, Me.ToolStripSeparator1, Me.StatistiqueToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ModifierLapparenceToolStripMenuItem, Me.ToolStripSeparator2, Me.QuiterToolStripMenuItem})
        Me.PartieToolStripMenuItem.Name = "PartieToolStripMenuItem"
        Me.PartieToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.PartieToolStripMenuItem.Text = "Partie"
        '
        'NouvellePartieToolStripMenuItem
        '
        Me.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem"
        Me.NouvellePartieToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NouvellePartieToolStripMenuItem.Text = "Nouvelle partie"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'StatistiqueToolStripMenuItem
        '
        Me.StatistiqueToolStripMenuItem.Name = "StatistiqueToolStripMenuItem"
        Me.StatistiqueToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.StatistiqueToolStripMenuItem.Text = "Statistiques"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ModifierLapparenceToolStripMenuItem
        '
        Me.ModifierLapparenceToolStripMenuItem.Name = "ModifierLapparenceToolStripMenuItem"
        Me.ModifierLapparenceToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ModifierLapparenceToolStripMenuItem.Text = "Modifier l'apparence"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        Me.QuiterToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.QuiterToolStripMenuItem.Text = "Quiter"
        '
        'GameTimer
        '
        '
        'card16
        '
        Me.card16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card16.BackColor = System.Drawing.Color.Black
        Me.card16.Image = CType(resources.GetObject("card16.Image"), System.Drawing.Image)
        Me.card16.Location = New System.Drawing.Point(635, 436)
        Me.card16.Name = "card16"
        Me.card16.Size = New System.Drawing.Size(124, 170)
        Me.card16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card16.TabIndex = 19
        Me.card16.TabStop = False
        '
        'card15
        '
        Me.card15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card15.BackColor = System.Drawing.Color.Black
        Me.card15.Image = CType(resources.GetObject("card15.Image"), System.Drawing.Image)
        Me.card15.Location = New System.Drawing.Point(493, 436)
        Me.card15.Name = "card15"
        Me.card15.Size = New System.Drawing.Size(124, 170)
        Me.card15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card15.TabIndex = 18
        Me.card15.TabStop = False
        '
        'card14
        '
        Me.card14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card14.BackColor = System.Drawing.Color.Black
        Me.card14.Image = CType(resources.GetObject("card14.Image"), System.Drawing.Image)
        Me.card14.Location = New System.Drawing.Point(351, 436)
        Me.card14.Name = "card14"
        Me.card14.Size = New System.Drawing.Size(124, 170)
        Me.card14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card14.TabIndex = 17
        Me.card14.TabStop = False
        '
        'card13
        '
        Me.card13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card13.BackColor = System.Drawing.Color.Black
        Me.card13.Image = CType(resources.GetObject("card13.Image"), System.Drawing.Image)
        Me.card13.Location = New System.Drawing.Point(209, 436)
        Me.card13.Name = "card13"
        Me.card13.Size = New System.Drawing.Size(124, 170)
        Me.card13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card13.TabIndex = 16
        Me.card13.TabStop = False
        '
        'card12
        '
        Me.card12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card12.BackColor = System.Drawing.Color.Black
        Me.card12.Image = CType(resources.GetObject("card12.Image"), System.Drawing.Image)
        Me.card12.Location = New System.Drawing.Point(635, 404)
        Me.card12.Name = "card12"
        Me.card12.Size = New System.Drawing.Size(124, 170)
        Me.card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card12.TabIndex = 15
        Me.card12.TabStop = False
        '
        'card11
        '
        Me.card11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card11.BackColor = System.Drawing.Color.Black
        Me.card11.Image = CType(resources.GetObject("card11.Image"), System.Drawing.Image)
        Me.card11.Location = New System.Drawing.Point(493, 404)
        Me.card11.Name = "card11"
        Me.card11.Size = New System.Drawing.Size(124, 170)
        Me.card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card11.TabIndex = 14
        Me.card11.TabStop = False
        '
        'card10
        '
        Me.card10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card10.BackColor = System.Drawing.Color.Black
        Me.card10.Image = CType(resources.GetObject("card10.Image"), System.Drawing.Image)
        Me.card10.Location = New System.Drawing.Point(351, 404)
        Me.card10.Name = "card10"
        Me.card10.Size = New System.Drawing.Size(124, 170)
        Me.card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card10.TabIndex = 13
        Me.card10.TabStop = False
        '
        'card9
        '
        Me.card9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card9.BackColor = System.Drawing.Color.Black
        Me.card9.Image = CType(resources.GetObject("card9.Image"), System.Drawing.Image)
        Me.card9.Location = New System.Drawing.Point(209, 404)
        Me.card9.Name = "card9"
        Me.card9.Size = New System.Drawing.Size(124, 170)
        Me.card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card9.TabIndex = 12
        Me.card9.TabStop = False
        '
        'card8
        '
        Me.card8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card8.BackColor = System.Drawing.Color.Black
        Me.card8.Image = CType(resources.GetObject("card8.Image"), System.Drawing.Image)
        Me.card8.Location = New System.Drawing.Point(635, 370)
        Me.card8.Name = "card8"
        Me.card8.Size = New System.Drawing.Size(124, 170)
        Me.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card8.TabIndex = 11
        Me.card8.TabStop = False
        '
        'card7
        '
        Me.card7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card7.BackColor = System.Drawing.Color.Black
        Me.card7.Image = CType(resources.GetObject("card7.Image"), System.Drawing.Image)
        Me.card7.Location = New System.Drawing.Point(493, 370)
        Me.card7.Name = "card7"
        Me.card7.Size = New System.Drawing.Size(124, 170)
        Me.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card7.TabIndex = 10
        Me.card7.TabStop = False
        '
        'card6
        '
        Me.card6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card6.BackColor = System.Drawing.Color.Black
        Me.card6.Image = CType(resources.GetObject("card6.Image"), System.Drawing.Image)
        Me.card6.Location = New System.Drawing.Point(351, 370)
        Me.card6.Name = "card6"
        Me.card6.Size = New System.Drawing.Size(124, 170)
        Me.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card6.TabIndex = 9
        Me.card6.TabStop = False
        '
        'card5
        '
        Me.card5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card5.BackColor = System.Drawing.Color.Black
        Me.card5.Image = CType(resources.GetObject("card5.Image"), System.Drawing.Image)
        Me.card5.Location = New System.Drawing.Point(209, 370)
        Me.card5.Name = "card5"
        Me.card5.Size = New System.Drawing.Size(124, 170)
        Me.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card5.TabIndex = 8
        Me.card5.TabStop = False
        '
        'imgCard
        '
        Me.imgCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCard.BackColor = System.Drawing.Color.Black
        Me.imgCard.Image = Global.Cribe_Chinois.My.Resources.Resources.background
        Me.imgCard.Location = New System.Drawing.Point(160, 43)
        Me.imgCard.Name = "imgCard"
        Me.imgCard.Size = New System.Drawing.Size(124, 170)
        Me.imgCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCard.TabIndex = 7
        Me.imgCard.TabStop = False
        '
        'card4
        '
        Me.card4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card4.BackColor = System.Drawing.Color.Black
        Me.card4.Image = CType(resources.GetObject("card4.Image"), System.Drawing.Image)
        Me.card4.Location = New System.Drawing.Point(635, 338)
        Me.card4.Name = "card4"
        Me.card4.Size = New System.Drawing.Size(124, 170)
        Me.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card4.TabIndex = 6
        Me.card4.TabStop = False
        '
        'card3
        '
        Me.card3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card3.BackColor = System.Drawing.Color.Black
        Me.card3.Image = CType(resources.GetObject("card3.Image"), System.Drawing.Image)
        Me.card3.Location = New System.Drawing.Point(493, 338)
        Me.card3.Name = "card3"
        Me.card3.Size = New System.Drawing.Size(124, 170)
        Me.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card3.TabIndex = 5
        Me.card3.TabStop = False
        '
        'card2
        '
        Me.card2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card2.BackColor = System.Drawing.Color.Black
        Me.card2.Image = CType(resources.GetObject("card2.Image"), System.Drawing.Image)
        Me.card2.Location = New System.Drawing.Point(351, 338)
        Me.card2.Name = "card2"
        Me.card2.Size = New System.Drawing.Size(124, 170)
        Me.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card2.TabIndex = 4
        Me.card2.TabStop = False
        '
        'card1
        '
        Me.card1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card1.BackColor = System.Drawing.Color.Black
        Me.card1.Image = CType(resources.GetObject("card1.Image"), System.Drawing.Image)
        Me.card1.Location = New System.Drawing.Point(209, 338)
        Me.card1.Name = "card1"
        Me.card1.Size = New System.Drawing.Size(124, 170)
        Me.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card1.TabIndex = 3
        Me.card1.TabStop = False
        '
        'imgDeck
        '
        Me.imgDeck.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgDeck.Image = Global.Cribe_Chinois.My.Resources.Resources.CB04
        Me.imgDeck.Location = New System.Drawing.Point(23, 43)
        Me.imgDeck.Name = "imgDeck"
        Me.imgDeck.Size = New System.Drawing.Size(124, 170)
        Me.imgDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDeck.TabIndex = 2
        Me.imgDeck.TabStop = False
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(968, 643)
        Me.Controls.Add(Me.card16)
        Me.Controls.Add(Me.card15)
        Me.Controls.Add(Me.card14)
        Me.Controls.Add(Me.card13)
        Me.Controls.Add(Me.card12)
        Me.Controls.Add(Me.card11)
        Me.Controls.Add(Me.card10)
        Me.Controls.Add(Me.card9)
        Me.Controls.Add(Me.card8)
        Me.Controls.Add(Me.card7)
        Me.Controls.Add(Me.card6)
        Me.Controls.Add(Me.card5)
        Me.Controls.Add(Me.imgCard)
        Me.Controls.Add(Me.card4)
        Me.Controls.Add(Me.card3)
        Me.Controls.Add(Me.card2)
        Me.Controls.Add(Me.card1)
        Me.Controls.Add(Me.imgDeck)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cribe Chinois"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.card16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvellePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatistiqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierLapparenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblGameTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents imgDeck As System.Windows.Forms.PictureBox
    Friend WithEvents card1 As System.Windows.Forms.PictureBox
    Friend WithEvents card2 As System.Windows.Forms.PictureBox
    Friend WithEvents card3 As System.Windows.Forms.PictureBox
    Friend WithEvents card4 As System.Windows.Forms.PictureBox
    Friend WithEvents imgCard As System.Windows.Forms.PictureBox
    Friend WithEvents card8 As System.Windows.Forms.PictureBox
    Friend WithEvents card7 As System.Windows.Forms.PictureBox
    Friend WithEvents card6 As System.Windows.Forms.PictureBox
    Friend WithEvents card5 As System.Windows.Forms.PictureBox
    Friend WithEvents card12 As System.Windows.Forms.PictureBox
    Friend WithEvents card11 As System.Windows.Forms.PictureBox
    Friend WithEvents card10 As System.Windows.Forms.PictureBox
    Friend WithEvents card9 As System.Windows.Forms.PictureBox
    Friend WithEvents card16 As System.Windows.Forms.PictureBox
    Friend WithEvents card15 As System.Windows.Forms.PictureBox
    Friend WithEvents card14 As System.Windows.Forms.PictureBox
    Friend WithEvents card13 As System.Windows.Forms.PictureBox

End Class
