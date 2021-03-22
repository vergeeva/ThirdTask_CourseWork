
Public Class EquilateralTriangle 'Равносторонний труегольник
    Private BackRoundColor As Brush 'Цвет заливки фигуры
    Private points(2) As PointF 'Координаты вершин треугольника
    Private side As Double  'Длина стороны треугольникка

    Public Property SideTriangle() As Double
        Set(Value As Double)
            side = Value
        End Set
        Get
            Return side
        End Get
    End Property

    Public Property UpPoint() As PointF
        Set(Value As PointF)
            points(0) = Value
            points(1) = New PointF(UpPoint.X - side / 2, UpPoint.Y + (side * Math.Sqrt(3.0)) / 2)
            points(2) = New PointF(UpPoint.X + side / 2, UpPoint.Y + (side * Math.Sqrt(3.0)) / 2)
        End Set
        Get
            Return points(0)
        End Get
    End Property
    Public Sub New()
        BackRoundColor = Brushes.Chocolate
        'Dim R As Double = side / Math.Sqrt(3.0)
    End Sub
    Public Sub New(side As Double, uppoint As PointF, BackRoundColor As Brush)
        If side <> 0 Then
            Me.side = side
        Else Me.side = 50
        End If
        Me.points(0) = New PointF(uppoint.X, uppoint.Y)
        points(1) = New PointF(uppoint.X - side / 2, uppoint.Y + (side * Math.Sqrt(3.0)) / 2)
        points(2) = New PointF(uppoint.X + side / 2, uppoint.Y + (side * Math.Sqrt(3.0)) / 2)
        Me.BackRoundColor = BackRoundColor
    End Sub

    Public Sub New(Obj As EquilateralTriangle)
        Me.side = Obj.side
        Me.points(0) = Obj.points(0)
        Me.points(1) = Obj.points(1)
        Me.points(2) = Obj.points(2)
        Me.BackRoundColor = Obj.BackRoundColor
    End Sub
    Public Function P() As Double 'Найти периметр

        Return side * 3
    End Function

    Public Function S() As Double 'Найти площадь

        Return (Math.Pow(side, 2) * Math.Sqrt(3.0)) / 4
    End Function

    Public Function Draw(g As Graphics) As Boolean 'Нарисовать равносторонний треугольник

        g.FillPolygon(BackRoundColor, points)
        Return 0
    End Function

    Public Function CheckPoints(Frm As Form) As Boolean 'Проверка выходит ли за пределы формы треугольник
        If points(1).X < 0 Or points(0).Y < 30 Or points(2).X > Frm.Width - 20 Or points(2).Y > Frm.Height - 40 Then
            Return False
        End If
        Return True
    End Function

End Class
