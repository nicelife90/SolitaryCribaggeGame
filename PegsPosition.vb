Public Class PegsPosition

    Private _position As Integer
    Private _point As Point
    Private _color As Integer

    Public Sub New(ByVal position As Integer, ByVal point As Point, ByVal color As Integer)
        _position = position
        _point = point
        _color = color
    End Sub

    ''' <summary>
    ''' Position on board (whole)
    ''' </summary>
    Public Function getPosition() As Integer
        Return _position
    End Function

    ''' <summary>
    ''' Position (x, y) Point
    ''' </summary>
    Public Function getPoint() As Point
        Return _point
    End Function

    ''' <summary>
    ''' 0 = Red, 1 = Blue
    ''' </summary>
    ''' <returns>Color of the peg</returns>
    Public Function getColor() As Integer
        Return _color
    End Function

End Class
