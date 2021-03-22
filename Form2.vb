Public Class Form2
    Dim Triangle As EquilateralTriangle

    Public Sub New(Trngle As EquilateralTriangle)
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        Triangle = New EquilateralTriangle(Trngle)
        ' Добавить код инициализации после вызова InitializeComponent().

    End Sub
    Private Sub Form2_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim G As Graphics = e.Graphics
        Triangle.Draw(G)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Triangle.CheckPoints(Me) Then
            MessageBox.Show("Треугольник за пределами формы", "Предупреждение")
            Close()
        Else
            Label1.Text = "Площадь треугольника  = " & Math.Round(Triangle.S) &
"; Периметр треугольника = " & Math.Round(Triangle.P)
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'Dim k As Keys = e.KeyCode
        'Invalidate()
    End Sub
End Class