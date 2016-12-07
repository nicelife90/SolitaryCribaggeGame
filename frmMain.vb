Option Strict On
Option Explicit On

Public Class frmMain

    ''' <summary>
    ''' Required by DragDrop operation
    ''' </summary>
    ''' <param name="handle"></param>
    ''' <returns></returns>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function DestroyIcon(handle As IntPtr) As Boolean
    End Function

    ''' <summary>
    ''' Game Chronometer
    ''' </summary>
    Private gameChrono As Single

    ''' <summary>
    ''' Deck of card for this game
    ''' </summary>
    Private deck As Deck = New Deck()


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GameTimer.Enabled = True
        GameTimer.Interval = 1000

        'Display initial card 
        Dim card As Control
        For Each card In Controls
            If TypeOf card Is PictureBox Then
                card.AllowDrop = True
                card.Visible = False

                Dim cardsToShow As String() = {"card1", "card2", "card3", "card4", "imgDeck", "imgCard"}
                For Each c In cardsToShow
                    If card.Name = c Then
                        card.Visible = True
                        Exit For
                    End If
                Next
            End If
        Next

        'Pick new card from deck
        Dim CurrentCard As Card = deck.newCard()
        imgCard.Image = CurrentCard.getImage()
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        'Affichage du temps de la partie
        gameChrono += 1
        If gameChrono >= 3600 Then
            Dim SecondeRestante As Single = gameChrono Mod 3600
            lblGameTimer.Text = "Temps : " & Int(gameChrono / 3600) & " Heures " & Int(SecondeRestante / 60) & " Minutes " & SecondeRestante Mod 60 & " Secondes"
        Else
            If gameChrono >= 60 Then
                lblGameTimer.Text = "Temps : " & Int(gameChrono / 60) & " Minutes " & gameChrono Mod 60 & " Secondes"
            Else
                lblGameTimer.Text = "Temps : " & gameChrono & " Secondes"
            End If
        End If


    End Sub


    Private Sub NouvellePartieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvellePartieToolStripMenuItem.Click
        gameChrono = -1
    End Sub


    Private Sub imgCard_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgCard.MouseDown
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
    Private Sub picDropTarget_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
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
    End Sub

    ' Accept the drop.
    Private Sub picDropTarget_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
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


        'show second row
        If CInt(card1.Tag) = 1 AndAlso
            CInt(card2.Tag) = 1 AndAlso
            CInt(card3.Tag) = 1 AndAlso
            CInt(card4.Tag) = 1 Then

            card5.Visible = True
            card6.Visible = True
            card7.Visible = True
            card8.Visible = True
        End If

        'show third row
        If CInt(card5.Tag) = 1 AndAlso
            CInt(card6.Tag) = 1 AndAlso
            CInt(card7.Tag) = 1 AndAlso
            CInt(card8.Tag) = 1 Then
            card9.Visible = True
            card10.Visible = True
            card11.Visible = True
            card12.Visible = True
        End If

        'show last row
        If CInt(card9.Tag) = 1 AndAlso
            CInt(card10.Tag) = 1 AndAlso
            CInt(card11.Tag) = 1 AndAlso
            CInt(card12.Tag) = 1 Then
            card13.Visible = True
            card14.Visible = True
            card15.Visible = True
            card16.Visible = True
        End If

        'rand new card
        Dim CurrentCard As Card = deck.newCard()
        imgCard.Image = CurrentCard.getImage()

    End Sub

End Class
