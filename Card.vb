Option Strict On
Option Explicit On

Public Class Card

    Private _image As Image
    Private _value As Integer
    Private _kind As String

    Public Sub New(ByVal image As Image, ByVal value As Integer, ByVal kind As String)
        _image = image
        _value = value
        _kind = kind
    End Sub

    Public Function getImage() As Image
        Return _image
    End Function

    Public Function getValue() As Integer
        Return _value
    End Function

    Public Function getKind() As String
        Return _kind
    End Function

End Class
