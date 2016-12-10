Public Class Pegs

    ''' <summary>
    ''' List of all Pegs Position
    ''' </summary>
    Private pegsPositionList As List(Of PegsPosition) = New List(Of PegsPosition)

    ''' <summary>
    ''' Initialize a list of point from whole on game board.
    ''' Position -1 and -2 represent start posistion.
    ''' </summary>
    Public Sub New()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''' RED PEGS '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'START
        pegsPositionList.Add(New PegsPosition(-2, New Point(601, 129), 0))
        pegsPositionList.Add(New PegsPosition(-1, New Point(589, 129), 0))

        '5
        pegsPositionList.Add(New PegsPosition(1, New Point(563, 129), 0))
        pegsPositionList.Add(New PegsPosition(2, New Point(551, 129), 0))
        pegsPositionList.Add(New PegsPosition(3, New Point(538, 129), 0))
        pegsPositionList.Add(New PegsPosition(4, New Point(526, 129), 0))
        pegsPositionList.Add(New PegsPosition(5, New Point(513, 129), 0))

        '10
        pegsPositionList.Add(New PegsPosition(6, New Point(494, 129), 0))
        pegsPositionList.Add(New PegsPosition(7, New Point(482, 129), 0))
        pegsPositionList.Add(New PegsPosition(8, New Point(469, 129), 0))
        pegsPositionList.Add(New PegsPosition(9, New Point(457, 129), 0))
        pegsPositionList.Add(New PegsPosition(10, New Point(444, 129), 0))

        '15
        pegsPositionList.Add(New PegsPosition(11, New Point(425, 129), 0))
        pegsPositionList.Add(New PegsPosition(12, New Point(412, 129), 0))
        pegsPositionList.Add(New PegsPosition(13, New Point(400, 129), 0))
        pegsPositionList.Add(New PegsPosition(14, New Point(388, 129), 0))
        pegsPositionList.Add(New PegsPosition(15, New Point(374, 129), 0))

        '20
        pegsPositionList.Add(New PegsPosition(16, New Point(355, 129), 0))
        pegsPositionList.Add(New PegsPosition(17, New Point(343, 129), 0))
        pegsPositionList.Add(New PegsPosition(18, New Point(331, 129), 0))
        pegsPositionList.Add(New PegsPosition(19, New Point(318, 129), 0))
        pegsPositionList.Add(New PegsPosition(20, New Point(306, 129), 0))

        '25
        pegsPositionList.Add(New PegsPosition(21, New Point(287, 129), 0))
        pegsPositionList.Add(New PegsPosition(22, New Point(274, 129), 0))
        pegsPositionList.Add(New PegsPosition(23, New Point(262, 129), 0))
        pegsPositionList.Add(New PegsPosition(24, New Point(248, 129), 0))
        pegsPositionList.Add(New PegsPosition(25, New Point(237, 129), 0))

        '30
        pegsPositionList.Add(New PegsPosition(26, New Point(217, 129), 0))
        pegsPositionList.Add(New PegsPosition(27, New Point(205, 129), 0))
        pegsPositionList.Add(New PegsPosition(28, New Point(193, 129), 0))
        pegsPositionList.Add(New PegsPosition(29, New Point(180, 129), 0))
        pegsPositionList.Add(New PegsPosition(30, New Point(167, 129), 0))

        '35
        pegsPositionList.Add(New PegsPosition(31, New Point(148, 129), 0))
        pegsPositionList.Add(New PegsPosition(32, New Point(136, 129), 0))
        pegsPositionList.Add(New PegsPosition(33, New Point(123, 129), 0))
        pegsPositionList.Add(New PegsPosition(34, New Point(111, 129), 0))
        pegsPositionList.Add(New PegsPosition(35, New Point(98, 129), 0))

        '40
        pegsPositionList.Add(New PegsPosition(36, New Point(79, 129), 0))
        pegsPositionList.Add(New PegsPosition(37, New Point(65, 123), 0))
        pegsPositionList.Add(New PegsPosition(38, New Point(53, 114), 0))
        pegsPositionList.Add(New PegsPosition(39, New Point(44, 102), 0))
        pegsPositionList.Add(New PegsPosition(40, New Point(38, 88), 0))

        '45
        pegsPositionList.Add(New PegsPosition(41, New Point(38, 69), 0))
        pegsPositionList.Add(New PegsPosition(42, New Point(44, 55), 0))
        pegsPositionList.Add(New PegsPosition(43, New Point(53, 43), 0))
        pegsPositionList.Add(New PegsPosition(44, New Point(65, 34), 0))
        pegsPositionList.Add(New PegsPosition(45, New Point(79, 28), 0))

        '50
        pegsPositionList.Add(New PegsPosition(46, New Point(98, 28), 0))
        pegsPositionList.Add(New PegsPosition(47, New Point(111, 28), 0))
        pegsPositionList.Add(New PegsPosition(48, New Point(123, 28), 0))
        pegsPositionList.Add(New PegsPosition(49, New Point(136, 28), 0))
        pegsPositionList.Add(New PegsPosition(50, New Point(148, 28), 0))

        '55
        pegsPositionList.Add(New PegsPosition(51, New Point(167, 28), 0))
        pegsPositionList.Add(New PegsPosition(52, New Point(180, 28), 0))
        pegsPositionList.Add(New PegsPosition(53, New Point(193, 28), 0))
        pegsPositionList.Add(New PegsPosition(54, New Point(205, 28), 0))
        pegsPositionList.Add(New PegsPosition(55, New Point(217, 28), 0))

        '60
        pegsPositionList.Add(New PegsPosition(56, New Point(237, 28), 0))
        pegsPositionList.Add(New PegsPosition(57, New Point(248, 28), 0))
        pegsPositionList.Add(New PegsPosition(58, New Point(262, 28), 0))
        pegsPositionList.Add(New PegsPosition(59, New Point(274, 28), 0))
        pegsPositionList.Add(New PegsPosition(60, New Point(287, 28), 0))

        '65
        pegsPositionList.Add(New PegsPosition(61, New Point(306, 28), 0))
        pegsPositionList.Add(New PegsPosition(62, New Point(318, 28), 0))
        pegsPositionList.Add(New PegsPosition(63, New Point(331, 28), 0))
        pegsPositionList.Add(New PegsPosition(64, New Point(343, 28), 0))
        pegsPositionList.Add(New PegsPosition(65, New Point(355, 28), 0))

        '70
        pegsPositionList.Add(New PegsPosition(66, New Point(374, 28), 0))
        pegsPositionList.Add(New PegsPosition(67, New Point(388, 28), 0))
        pegsPositionList.Add(New PegsPosition(68, New Point(400, 28), 0))
        pegsPositionList.Add(New PegsPosition(69, New Point(412, 28), 0))
        pegsPositionList.Add(New PegsPosition(70, New Point(425, 28), 0))

        '75
        pegsPositionList.Add(New PegsPosition(71, New Point(444, 28), 0))
        pegsPositionList.Add(New PegsPosition(72, New Point(457, 28), 0))
        pegsPositionList.Add(New PegsPosition(73, New Point(469, 28), 0))
        pegsPositionList.Add(New PegsPosition(74, New Point(482, 28), 0))
        pegsPositionList.Add(New PegsPosition(75, New Point(494, 28), 0))

        '80
        pegsPositionList.Add(New PegsPosition(76, New Point(513, 28), 0))
        pegsPositionList.Add(New PegsPosition(77, New Point(526, 28), 0))
        pegsPositionList.Add(New PegsPosition(78, New Point(538, 28), 0))
        pegsPositionList.Add(New PegsPosition(79, New Point(551, 28), 0))
        pegsPositionList.Add(New PegsPosition(80, New Point(563, 28), 0))

        '85
        pegsPositionList.Add(New PegsPosition(81, New Point(582, 28), 0))
        pegsPositionList.Add(New PegsPosition(82, New Point(590, 37), 0))
        pegsPositionList.Add(New PegsPosition(83, New Point(593, 48), 0))
        pegsPositionList.Add(New PegsPosition(84, New Point(590, 59), 0))
        pegsPositionList.Add(New PegsPosition(85, New Point(582, 68), 0))

        '90
        pegsPositionList.Add(New PegsPosition(86, New Point(563, 68), 0))
        pegsPositionList.Add(New PegsPosition(87, New Point(551, 68), 0))
        pegsPositionList.Add(New PegsPosition(88, New Point(538, 68), 0))
        pegsPositionList.Add(New PegsPosition(89, New Point(526, 68), 0))
        pegsPositionList.Add(New PegsPosition(90, New Point(513, 68), 0))

        '95
        pegsPositionList.Add(New PegsPosition(91, New Point(494, 68), 0))
        pegsPositionList.Add(New PegsPosition(92, New Point(482, 68), 0))
        pegsPositionList.Add(New PegsPosition(93, New Point(469, 68), 0))
        pegsPositionList.Add(New PegsPosition(94, New Point(457, 68), 0))
        pegsPositionList.Add(New PegsPosition(95, New Point(444, 68), 0))

        '100
        pegsPositionList.Add(New PegsPosition(96, New Point(425, 68), 0))
        pegsPositionList.Add(New PegsPosition(97, New Point(412, 68), 0))
        pegsPositionList.Add(New PegsPosition(98, New Point(400, 68), 0))
        pegsPositionList.Add(New PegsPosition(99, New Point(388, 68), 0))
        pegsPositionList.Add(New PegsPosition(100, New Point(374, 68), 0))

        '105
        pegsPositionList.Add(New PegsPosition(101, New Point(355, 68), 0))
        pegsPositionList.Add(New PegsPosition(102, New Point(343, 68), 0))
        pegsPositionList.Add(New PegsPosition(103, New Point(331, 68), 0))
        pegsPositionList.Add(New PegsPosition(104, New Point(318, 68), 0))
        pegsPositionList.Add(New PegsPosition(105, New Point(306, 68), 0))

        '110
        pegsPositionList.Add(New PegsPosition(106, New Point(287, 68), 0))
        pegsPositionList.Add(New PegsPosition(107, New Point(274, 68), 0))
        pegsPositionList.Add(New PegsPosition(108, New Point(262, 68), 0))
        pegsPositionList.Add(New PegsPosition(109, New Point(248, 68), 0))
        pegsPositionList.Add(New PegsPosition(110, New Point(237, 68), 0))

        '115
        pegsPositionList.Add(New PegsPosition(111, New Point(217, 68), 0))
        pegsPositionList.Add(New PegsPosition(112, New Point(205, 68), 0))
        pegsPositionList.Add(New PegsPosition(113, New Point(193, 68), 0))
        pegsPositionList.Add(New PegsPosition(114, New Point(180, 68), 0))
        pegsPositionList.Add(New PegsPosition(115, New Point(167, 68), 0))

        '120
        pegsPositionList.Add(New PegsPosition(116, New Point(148, 68), 0))
        pegsPositionList.Add(New PegsPosition(117, New Point(136, 68), 0))
        pegsPositionList.Add(New PegsPosition(118, New Point(123, 68), 0))
        pegsPositionList.Add(New PegsPosition(119, New Point(111, 68), 0))
        pegsPositionList.Add(New PegsPosition(120, New Point(98, 68), 0))

        'WIN
        pegsPositionList.Add(New PegsPosition(121, New Point(79, 68), 0))

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''' BLUE PEGS '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'START
        pegsPositionList.Add(New PegsPosition(-2, New Point(601, 149), 1))
        pegsPositionList.Add(New PegsPosition(-1, New Point(589, 149), 1))

        '5
        pegsPositionList.Add(New PegsPosition(1, New Point(563, 149), 1))
        pegsPositionList.Add(New PegsPosition(2, New Point(551, 149), 1))
        pegsPositionList.Add(New PegsPosition(3, New Point(538, 149), 1))
        pegsPositionList.Add(New PegsPosition(4, New Point(526, 149), 1))
        pegsPositionList.Add(New PegsPosition(5, New Point(513, 149), 1))

        '10
        pegsPositionList.Add(New PegsPosition(6, New Point(494, 149), 1))
        pegsPositionList.Add(New PegsPosition(7, New Point(482, 149), 1))
        pegsPositionList.Add(New PegsPosition(8, New Point(469, 149), 1))
        pegsPositionList.Add(New PegsPosition(9, New Point(457, 149), 1))
        pegsPositionList.Add(New PegsPosition(10, New Point(444, 149), 1))

        '15
        pegsPositionList.Add(New PegsPosition(11, New Point(425, 149), 1))
        pegsPositionList.Add(New PegsPosition(12, New Point(412, 149), 1))
        pegsPositionList.Add(New PegsPosition(13, New Point(400, 149), 1))
        pegsPositionList.Add(New PegsPosition(14, New Point(388, 149), 1))
        pegsPositionList.Add(New PegsPosition(15, New Point(374, 149), 1))

        '20
        pegsPositionList.Add(New PegsPosition(16, New Point(355, 149), 1))
        pegsPositionList.Add(New PegsPosition(17, New Point(343, 149), 1))
        pegsPositionList.Add(New PegsPosition(18, New Point(331, 149), 1))
        pegsPositionList.Add(New PegsPosition(19, New Point(318, 149), 1))
        pegsPositionList.Add(New PegsPosition(20, New Point(306, 149), 1))

        '25
        pegsPositionList.Add(New PegsPosition(21, New Point(287, 149), 1))
        pegsPositionList.Add(New PegsPosition(22, New Point(274, 149), 1))
        pegsPositionList.Add(New PegsPosition(23, New Point(262, 149), 1))
        pegsPositionList.Add(New PegsPosition(24, New Point(248, 149), 1))
        pegsPositionList.Add(New PegsPosition(25, New Point(237, 149), 1))

        '30
        pegsPositionList.Add(New PegsPosition(26, New Point(217, 149), 1))
        pegsPositionList.Add(New PegsPosition(27, New Point(205, 149), 1))
        pegsPositionList.Add(New PegsPosition(28, New Point(193, 149), 1))
        pegsPositionList.Add(New PegsPosition(29, New Point(180, 149), 1))
        pegsPositionList.Add(New PegsPosition(30, New Point(167, 149), 1))

        '35
        pegsPositionList.Add(New PegsPosition(31, New Point(148, 149), 1))
        pegsPositionList.Add(New PegsPosition(32, New Point(136, 149), 1))
        pegsPositionList.Add(New PegsPosition(33, New Point(123, 149), 1))
        pegsPositionList.Add(New PegsPosition(34, New Point(111, 149), 1))
        pegsPositionList.Add(New PegsPosition(35, New Point(98, 149), 1))

        '40
        pegsPositionList.Add(New PegsPosition(36, New Point(79, 149), 1))
        pegsPositionList.Add(New PegsPosition(37, New Point(57, 141), 1))
        pegsPositionList.Add(New PegsPosition(38, New Point(38, 128), 1))
        pegsPositionList.Add(New PegsPosition(39, New Point(25, 109), 1))
        pegsPositionList.Add(New PegsPosition(40, New Point(18, 87), 1))

        '45
        pegsPositionList.Add(New PegsPosition(41, New Point(18, 69), 1))
        pegsPositionList.Add(New PegsPosition(42, New Point(25, 47), 1))
        pegsPositionList.Add(New PegsPosition(43, New Point(38, 29), 1))
        pegsPositionList.Add(New PegsPosition(44, New Point(57, 15), 1))
        pegsPositionList.Add(New PegsPosition(45, New Point(79, 8), 1))

        '50
        pegsPositionList.Add(New PegsPosition(46, New Point(98, 8), 1))
        pegsPositionList.Add(New PegsPosition(47, New Point(111, 8), 1))
        pegsPositionList.Add(New PegsPosition(48, New Point(123, 8), 1))
        pegsPositionList.Add(New PegsPosition(49, New Point(136, 8), 1))
        pegsPositionList.Add(New PegsPosition(50, New Point(148, 8), 1))

        '55
        pegsPositionList.Add(New PegsPosition(51, New Point(167, 8), 1))
        pegsPositionList.Add(New PegsPosition(52, New Point(180, 8), 1))
        pegsPositionList.Add(New PegsPosition(53, New Point(193, 8), 1))
        pegsPositionList.Add(New PegsPosition(54, New Point(205, 8), 1))
        pegsPositionList.Add(New PegsPosition(55, New Point(217, 8), 1))

        '60
        pegsPositionList.Add(New PegsPosition(56, New Point(237, 8), 1))
        pegsPositionList.Add(New PegsPosition(57, New Point(248, 8), 1))
        pegsPositionList.Add(New PegsPosition(58, New Point(262, 8), 1))
        pegsPositionList.Add(New PegsPosition(59, New Point(274, 8), 1))
        pegsPositionList.Add(New PegsPosition(60, New Point(287, 8), 1))

        '65
        pegsPositionList.Add(New PegsPosition(61, New Point(306, 8), 1))
        pegsPositionList.Add(New PegsPosition(62, New Point(318, 8), 1))
        pegsPositionList.Add(New PegsPosition(63, New Point(331, 8), 1))
        pegsPositionList.Add(New PegsPosition(64, New Point(343, 8), 1))
        pegsPositionList.Add(New PegsPosition(65, New Point(355, 8), 1))

        '70
        pegsPositionList.Add(New PegsPosition(66, New Point(374, 8), 1))
        pegsPositionList.Add(New PegsPosition(67, New Point(388, 8), 1))
        pegsPositionList.Add(New PegsPosition(68, New Point(400, 8), 1))
        pegsPositionList.Add(New PegsPosition(69, New Point(412, 8), 1))
        pegsPositionList.Add(New PegsPosition(70, New Point(425, 8), 1))

        '75
        pegsPositionList.Add(New PegsPosition(71, New Point(444, 8), 1))
        pegsPositionList.Add(New PegsPosition(72, New Point(457, 8), 1))
        pegsPositionList.Add(New PegsPosition(73, New Point(469, 8), 1))
        pegsPositionList.Add(New PegsPosition(74, New Point(482, 8), 1))
        pegsPositionList.Add(New PegsPosition(75, New Point(494, 8), 1))

        '80
        pegsPositionList.Add(New PegsPosition(76, New Point(513, 8), 1))
        pegsPositionList.Add(New PegsPosition(77, New Point(526, 8), 1))
        pegsPositionList.Add(New PegsPosition(78, New Point(538, 8), 1))
        pegsPositionList.Add(New PegsPosition(79, New Point(551, 8), 1))
        pegsPositionList.Add(New PegsPosition(80, New Point(563, 8), 1))

        '85
        pegsPositionList.Add(New PegsPosition(81, New Point(582, 8), 1))
        pegsPositionList.Add(New PegsPosition(82, New Point(590, 16), 1))
        pegsPositionList.Add(New PegsPosition(83, New Point(593, 27), 1))
        pegsPositionList.Add(New PegsPosition(84, New Point(590, 38), 1))
        pegsPositionList.Add(New PegsPosition(85, New Point(582, 47), 1))

        '90
        pegsPositionList.Add(New PegsPosition(86, New Point(563, 47), 1))
        pegsPositionList.Add(New PegsPosition(87, New Point(551, 47), 1))
        pegsPositionList.Add(New PegsPosition(88, New Point(538, 47), 1))
        pegsPositionList.Add(New PegsPosition(89, New Point(526, 47), 1))
        pegsPositionList.Add(New PegsPosition(90, New Point(513, 47), 1))

        '95
        pegsPositionList.Add(New PegsPosition(91, New Point(494, 47), 1))
        pegsPositionList.Add(New PegsPosition(92, New Point(482, 47), 1))
        pegsPositionList.Add(New PegsPosition(93, New Point(469, 47), 1))
        pegsPositionList.Add(New PegsPosition(94, New Point(457, 47), 1))
        pegsPositionList.Add(New PegsPosition(95, New Point(444, 47), 1))

        '100
        pegsPositionList.Add(New PegsPosition(96, New Point(425, 47), 1))
        pegsPositionList.Add(New PegsPosition(97, New Point(412, 47), 1))
        pegsPositionList.Add(New PegsPosition(98, New Point(400, 47), 1))
        pegsPositionList.Add(New PegsPosition(99, New Point(388, 47), 1))
        pegsPositionList.Add(New PegsPosition(100, New Point(374, 47), 1))

        '105
        pegsPositionList.Add(New PegsPosition(101, New Point(355, 47), 1))
        pegsPositionList.Add(New PegsPosition(102, New Point(343, 47), 1))
        pegsPositionList.Add(New PegsPosition(103, New Point(331, 47), 1))
        pegsPositionList.Add(New PegsPosition(104, New Point(318, 47), 1))
        pegsPositionList.Add(New PegsPosition(105, New Point(306, 47), 1))

        '110
        pegsPositionList.Add(New PegsPosition(106, New Point(287, 47), 1))
        pegsPositionList.Add(New PegsPosition(107, New Point(274, 47), 1))
        pegsPositionList.Add(New PegsPosition(108, New Point(262, 47), 1))
        pegsPositionList.Add(New PegsPosition(109, New Point(248, 47), 1))
        pegsPositionList.Add(New PegsPosition(110, New Point(237, 47), 1))

        '115
        pegsPositionList.Add(New PegsPosition(111, New Point(217, 47), 1))
        pegsPositionList.Add(New PegsPosition(112, New Point(205, 47), 1))
        pegsPositionList.Add(New PegsPosition(113, New Point(193, 47), 1))
        pegsPositionList.Add(New PegsPosition(114, New Point(180, 47), 1))
        pegsPositionList.Add(New PegsPosition(115, New Point(167, 47), 1))

        '120
        pegsPositionList.Add(New PegsPosition(116, New Point(148, 47), 1))
        pegsPositionList.Add(New PegsPosition(117, New Point(136, 47), 1))
        pegsPositionList.Add(New PegsPosition(118, New Point(123, 47), 1))
        pegsPositionList.Add(New PegsPosition(119, New Point(111, 47), 1))
        pegsPositionList.Add(New PegsPosition(120, New Point(98, 47), 1))

        'WIN
        pegsPositionList.Add(New PegsPosition(121, New Point(79, 47), 1))

    End Sub

    ''' <summary>
    ''' Get Position on game board (Point)
    ''' </summary>
    ''' <param name="position">Position on board (whole)</param>
    ''' <param name="color">0 = Red, 1 = Blue</param>
    ''' <returns>Point</returns>
    Public Function getPegsPointByPosition(ByVal position As Integer, ByVal color As Integer) As Point
        Dim PointPosition As Point = pegsPositionList.Find(Function(x) x.getColor() = color And x.getPosition() = position).getPoint()
        Return PointPosition
    End Function

End Class

