Public Class Form1
    Dim Color As SolidBrush = New SolidBrush(Drawing.Color.Chocolate)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValueSide.Text <> "" And ValueX.Text <> "" And ValueY.Text <> "" Then 'Если текстовые поля не пустые
            Dim ETriangle As EquilateralTriangle 'Создаем объект класса "равносторонний треугольник
            Dim Side As Double = Convert.ToDouble(ValueSide.Text) 'Переменная для стороны
            Dim X As Double = Convert.ToDouble(ValueX.Text) 'Переменная для коорднаты Х
            Dim Y As Double = Convert.ToDouble(ValueY.Text) 'Переменная для координаты У

            ETriangle = New EquilateralTriangle(Side, New PointF(X, Y), Color) 'Инициализируем объект с помощью конструктора и ранее созданных переменных
            Dim Frm As Form2 = New Form2(ETriangle) 'Передаем объект во вторую форму
            Frm.ShowDialog() 'Открываем вторую форму
        Else MessageBox.Show("Заполните все поля", "Предупреждение") 'Если поля не заполнены, то программа попросит их заполнить
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.FullOpen = True
        ColorDialog1.Color = BackColor

        If ColorDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        Color = New SolidBrush(ColorDialog1.Color)
    End Sub

    Private Sub ValueX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValueX.KeyPress
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValueY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValueY.KeyPress
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValueSide_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValueSide.KeyPress
        If Not (Char.IsControl(e.KeyChar)) And Not (Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub
End Class
