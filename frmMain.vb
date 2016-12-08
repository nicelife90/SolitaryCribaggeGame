Option Strict On
Option Explicit On

Public Class frmMain


    ''' <summary>
    ''' Required by DragDrop
    ''' </summary>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function DestroyIcon(handle As IntPtr) As Boolean
    End Function


    ''' <summary>
    ''' Game timer
    ''' </summary>
    Private timer As Single

    ''' <summary>
    ''' Current card to play
    ''' </summary>
    Dim currentCard As Card

    ''' <summary>
    ''' Deck of card for this game
    ''' </summary>
    Private deck As Deck = New Deck()


    ''' <summary>
    ''' Store current game
    ''' </summary>
    Private game As Game


    ''' <summary>
    ''' Store original target card size
    ''' </summary>
    Private originalTargetWidth As Integer
    Private originalTargetHeight As Integer


    ''' <summary>
    ''' Store value indicating if row of card is complete
    ''' </summary>
    Private Row1Full As Boolean = False
    Private Row2Full As Boolean = False
    Private Row3Full As Boolean = False
    Private Row4Full As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        imgPinRed1.BackColor = Color.Transparent
        imgPinRed1.Parent = imgBoard
        imgPinRed1.Location = New Point(586, 108)

        imgPinRed2.BackColor = Color.Transparent
        imgPinRed2.Parent = imgBoard
        imgPinRed2.Location = New Point(600, 108)


        'Accept drop on current form
        AllowDrop = True

        'Create new game
        game = New Game()

        'Start Timer
        GameTimer.Enabled = True
        GameTimer.Interval = 1000

        'Initialize game table 
        Dim card As Control
        For Each card In Controls
            If TypeOf card Is PictureBox Then
                card.AllowDrop = True
                card.Visible = False

                Dim cardsToShow As String() = {
                    "card1", "card2", "card3", "card4",
                    "imgDeck", "imgCard", "imgBoard",
                    "imgPinBlue1", "imgPinBlue2", "imgPinRed1", "imgPinRed2"}

                For Each c In cardsToShow
                    If card.Name = c Then
                        card.Visible = True
                        Exit For
                    End If
                Next
            End If
        Next

        'Pick new card from deck
        currentCard = deck.newCard()
        imgCard.Image = currentCard.getImage()
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        'Affichage du temps de la partie
        timer += 1
        If timer >= 3600 Then
            Dim SecondeRestante As Single = timer Mod 3600
            lblGameTimer.Text = "Temps : " & Int(timer / 3600) & " Heures " & Int(SecondeRestante / 60) & " Minutes " & SecondeRestante Mod 60 & " Secondes"
        Else
            If timer >= 60 Then
                lblGameTimer.Text = "Temps : " & Int(timer / 60) & " Minutes " & timer Mod 60 & " Secondes"
            Else
                lblGameTimer.Text = "Temps : " & timer & " Secondes"
            End If
        End If


    End Sub


    Private Sub NouvellePartieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvellePartieToolStripMenuItem.Click
        timer = -1
    End Sub


    Private Sub Source_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgCard.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim dragImage = DirectCast(imgCard.Image, Bitmap)
            Dim cur = New Bitmap(dragImage, New Size(imgCard.Width, imgCard.Height))
            Dim icon As IntPtr = cur.GetHicon()
            Cursor.Current = New Cursor(icon)
            DoDragDrop(imgCard.Image, DragDropEffects.Copy)
            DestroyIcon(icon)
        End If
    End Sub

    Private Sub frmMain_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles MyBase.GiveFeedback
        e.UseDefaultCursors = False
    End Sub

    ' Allow a copy of an image.
    Private Sub Target_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
        card1.DragEnter, card2.DragEnter, card3.DragEnter, card4.DragEnter,
        card5.DragEnter, card6.DragEnter, card7.DragEnter, card8.DragEnter,
        card9.DragEnter, card10.DragEnter, card11.DragEnter, card12.DragEnter,
        card13.DragEnter, card14.DragEnter, card15.DragEnter, card16.DragEnter

        ' See if this is a copy and the data includes an image.
        If (e.Data.GetDataPresent(DataFormats.Bitmap) AndAlso (e.AllowedEffect And DragDropEffects.Copy) <> 0) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

        'Small oversize effect on mouse over
        Dim target As PictureBox = DirectCast(sender, PictureBox)
        originalTargetWidth = target.Width
        originalTargetHeight = target.Height
        Dim newWidth As Integer = target.Width + CInt(5 * target.Width / 100)
        Dim newHeight As Integer = target.Height + CInt(5 * target.Height / 100)
        target.Size() = New Size(newWidth, newHeight)
    End Sub

    Private Sub Target_DragLeave(sender As Object, e As EventArgs) Handles _
        card9.DragLeave, card8.DragLeave, card7.DragLeave, card6.DragLeave,
        card5.DragLeave, card4.DragLeave, card3.DragLeave, card2.DragLeave,
        card16.DragLeave, card15.DragLeave, card14.DragLeave, card13.DragLeave,
        card12.DragLeave, card11.DragLeave, card10.DragLeave, card1.DragLeave

        'Recover original size after mouse leave
        Dim target As PictureBox = DirectCast(sender, PictureBox)
        target.Size() = New Size(originalTargetWidth, originalTargetHeight)
    End Sub

    ' Accept the drop.
    Private Sub Target_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
        card1.DragDrop, card2.DragDrop, card3.DragDrop, card4.DragDrop,
        card5.DragDrop, card6.DragDrop, card7.DragDrop, card8.DragDrop,
        card9.DragDrop, card10.DragDrop, card11.DragDrop, card12.DragDrop,
        card13.DragDrop, card14.DragDrop, card15.DragDrop, card16.DragDrop

        'drop in right picture box
        Dim picBox As PictureBox = DirectCast(sender, PictureBox)
        Dim bm As Bitmap = DirectCast(e.Data.GetData(DataFormats.Bitmap, True), Bitmap)
        picBox.Image = bm
        picBox.Tag = 1
        picBox.AllowDrop = False


        'Recover original size after mouse leave
        Dim target As PictureBox = DirectCast(sender, PictureBox)
        target.Size() = New Size(originalTargetWidth, originalTargetHeight)

        'Add card to right hand
        Select Case picBox.Name

            Case "card1", "card5", "card9", "card13"
                game.StoreCardInHand(1, currentCard)

            Case "card2", "card6", "card10", "card14"
                game.StoreCardInHand(2, currentCard)

            Case "card3", "card7", "card11", "card15"
                game.StoreCardInHand(3, currentCard)

            Case "card4", "card8", "card12", "card16"
                game.StoreCardInHand(4, currentCard)

        End Select

        'show second row
        If CInt(card1.Tag) = 1 AndAlso
            CInt(card2.Tag) = 1 AndAlso
            CInt(card3.Tag) = 1 AndAlso
            CInt(card4.Tag) = 1 AndAlso
            Row1Full = False Then

            card5.Visible = True
            card6.Visible = True
            card7.Visible = True
            card8.Visible = True

            'Add first card to crib
            game.StoreCardInHand(0, deck.newCard())
            cribCard1.Visible = True

            'Prevent new card to be added to the crib
            Row1Full = True
        End If

        'show third row
        If CInt(card5.Tag) = 1 AndAlso
            CInt(card6.Tag) = 1 AndAlso
            CInt(card7.Tag) = 1 AndAlso
            CInt(card8.Tag) = 1 AndAlso
            Row2Full = False Then

            card9.Visible = True
            card10.Visible = True
            card11.Visible = True
            card12.Visible = True

            'Add second card to crib
            game.StoreCardInHand(0, deck.newCard())
            cribCard2.Visible = True

            'Prevent new card to be added to the crib
            Row2Full = True
        End If

        'show last row
        If CInt(card9.Tag) = 1 AndAlso
            CInt(card10.Tag) = 1 AndAlso
            CInt(card11.Tag) = 1 AndAlso
            CInt(card12.Tag) = 1 AndAlso
            Row3Full = False Then

            card13.Visible = True
            card14.Visible = True
            card15.Visible = True
            card16.Visible = True

            'Add third card to crib
            game.StoreCardInHand(0, deck.newCard())
            cribCard3.Visible = True

            'Prevent new card to be added to the crib
            Row3Full = True
        End If

        'Add last card to crib
        If CInt(card13.Tag) = 1 AndAlso
            CInt(card14.Tag) = 1 AndAlso
            CInt(card15.Tag) = 1 AndAlso
            CInt(card16.Tag) = 1 AndAlso
            Row4Full = False Then

            'Add last card to crib
            game.StoreCardInHand(0, deck.newCard())
            cribCard4.Visible = True

            'Prevent new card to be added to the crib
            Row4Full = True

            'Display crib card
            Dim cribHand As List(Of Card) = game.getHand(0)
            cribCard1.Image = cribHand(0).getImage()
            cribCard2.Image = cribHand(1).getImage()
            cribCard3.Image = cribHand(2).getImage()
            cribCard4.Image = cribHand(3).getImage()

            'Put source card on deck like if someone cut the deck
            imgDeck.Image = deck.newCard.getImage()
            imgCard.Visible = False


        End If

        'Rand new source card if all row not full
        If Row4Full <> True Then
            currentCard = deck.newCard()
            imgCard.Image = currentCard.getImage()
        End If


    End Sub

End Class
