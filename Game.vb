Public Class Game

    ''' <summary>
    ''' All hands of this game
    ''' </summary>
    Private _hand0 As List(Of Card) = New List(Of Card) 'Crib
    Private _hand1 As List(Of Card) = New List(Of Card) 'Hand 1
    Private _hand2 As List(Of Card) = New List(Of Card) 'Hand 2
    Private _hand3 As List(Of Card) = New List(Of Card) 'Hand 3
    Private _hand4 As List(Of Card) = New List(Of Card) 'Hand 4


    ''' <summary>
    ''' Store specific card in a specific hand
    ''' </summary>
    ''' <param name="handNumber">Hand number where to store card</param>
    ''' <param name="card">Card</param>
    Public Sub StoreCardInHand(ByVal handNumber As Integer, ByVal card As Card)

        Select Case handNumber

            Case 0
                _hand0.Add(card)
            Case 1
                _hand1.Add(card)
            Case 2
                _hand2.Add(card)
            Case 3
                _hand3.Add(card)
            Case 4
                _hand4.Add(card)

        End Select

    End Sub

    ''' <summary>
    ''' Return list of card of the seleted hand
    ''' </summary>
    ''' <param name="handNumber">Hand number</param>
    Public Function getHand(ByVal handNumber As Integer) As List(Of Card)

        Dim hand As List(Of Card)

        Select Case handNumber
            Case 0
                hand = _hand0
            Case 1
                hand = _hand1
            Case 2
                hand = _hand2
            Case 3
                hand = _hand3
            Case 4
                hand = _hand4
            Case Else
                hand = Nothing
        End Select

        Return hand

    End Function

End Class
