Public Class Deck

    Private _cards As New ArrayList
    Private _index As Integer

    Public Sub New()

        'Nombre de carte total
        _index = 51

        'Définition des cartes
        _cards.Add(New Card(My.Resources.h01, 1, "Hearts"))
        _cards.Add(New Card(My.Resources.h02, 2, "Hearts"))
        _cards.Add(New Card(My.Resources.h03, 3, "Hearts"))
        _cards.Add(New Card(My.Resources.h04, 4, "Hearts"))
        _cards.Add(New Card(My.Resources.h05, 5, "Hearts"))
        _cards.Add(New Card(My.Resources.h06, 6, "Hearts"))
        _cards.Add(New Card(My.Resources.h07, 7, "Hearts"))
        _cards.Add(New Card(My.Resources.h08, 8, "Hearts"))
        _cards.Add(New Card(My.Resources.h09, 9, "Hearts"))
        _cards.Add(New Card(My.Resources.h10, 10, "Hearts"))
        _cards.Add(New Card(My.Resources.h11, 11, "Hearts"))
        _cards.Add(New Card(My.Resources.h12, 12, "Hearts"))
        _cards.Add(New Card(My.Resources.h13, 13, "Hearts"))
        _cards.Add(New Card(My.Resources.d01, 1, "Diamonds"))
        _cards.Add(New Card(My.Resources.d02, 2, "Diamonds"))
        _cards.Add(New Card(My.Resources.d03, 3, "Diamonds"))
        _cards.Add(New Card(My.Resources.d04, 4, "Diamonds"))
        _cards.Add(New Card(My.Resources.d05, 5, "Diamonds"))
        _cards.Add(New Card(My.Resources.d06, 6, "Diamonds"))
        _cards.Add(New Card(My.Resources.d07, 7, "Diamonds"))
        _cards.Add(New Card(My.Resources.d08, 8, "Diamonds"))
        _cards.Add(New Card(My.Resources.d09, 9, "Diamonds"))
        _cards.Add(New Card(My.Resources.d10, 10, "Diamonds"))
        _cards.Add(New Card(My.Resources.d11, 11, "Diamonds"))
        _cards.Add(New Card(My.Resources.d12, 12, "Diamonds"))
        _cards.Add(New Card(My.Resources.d13, 13, "Diamonds"))
        _cards.Add(New Card(My.Resources.c01, 1, "Clubs"))
        _cards.Add(New Card(My.Resources.c02, 2, "Clubs"))
        _cards.Add(New Card(My.Resources.c03, 3, "Clubs"))
        _cards.Add(New Card(My.Resources.c04, 4, "Clubs"))
        _cards.Add(New Card(My.Resources.c05, 5, "Clubs"))
        _cards.Add(New Card(My.Resources.c06, 6, "Clubs"))
        _cards.Add(New Card(My.Resources.c07, 7, "Clubs"))
        _cards.Add(New Card(My.Resources.c08, 8, "Clubs"))
        _cards.Add(New Card(My.Resources.c09, 9, "Clubs"))
        _cards.Add(New Card(My.Resources.c10, 10, "Clubs"))
        _cards.Add(New Card(My.Resources.c11, 11, "Clubs"))
        _cards.Add(New Card(My.Resources.c12, 12, "Clubs"))
        _cards.Add(New Card(My.Resources.c13, 13, "Clubs"))
        _cards.Add(New Card(My.Resources.s01, 1, "Spades"))
        _cards.Add(New Card(My.Resources.s02, 2, "Spades"))
        _cards.Add(New Card(My.Resources.s03, 3, "Spades"))
        _cards.Add(New Card(My.Resources.s04, 4, "Spades"))
        _cards.Add(New Card(My.Resources.s05, 5, "Spades"))
        _cards.Add(New Card(My.Resources.s06, 6, "Spades"))
        _cards.Add(New Card(My.Resources.s07, 7, "Spades"))
        _cards.Add(New Card(My.Resources.s08, 8, "Spades"))
        _cards.Add(New Card(My.Resources.s09, 9, "Spades"))
        _cards.Add(New Card(My.Resources.s10, 10, "Spades"))
        _cards.Add(New Card(My.Resources.s11, 11, "Spades"))
        _cards.Add(New Card(My.Resources.s12, 12, "Spades"))
        _cards.Add(New Card(My.Resources.s13, 13, "Spades"))

    End Sub

    Public Function newCard() As Card
        Randomize()
        Dim x As Integer
        x = CInt(Int((_index * Rnd()) + 1))
        Dim card As Card = _cards(x)
        _cards.RemoveAt(x)
        _index -= 1
        Return card
    End Function
End Class
