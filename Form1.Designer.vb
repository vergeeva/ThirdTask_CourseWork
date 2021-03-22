<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ValueX = New System.Windows.Forms.TextBox()
        Me.ValueY = New System.Windows.Forms.TextBox()
        Me.ValueSide = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 248)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Нарисовать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ValueX
        '
        Me.ValueX.Location = New System.Drawing.Point(90, 55)
        Me.ValueX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValueX.Name = "ValueX"
        Me.ValueX.Size = New System.Drawing.Size(241, 27)
        Me.ValueX.TabIndex = 1
        '
        'ValueY
        '
        Me.ValueY.Location = New System.Drawing.Point(90, 109)
        Me.ValueY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValueY.Name = "ValueY"
        Me.ValueY.Size = New System.Drawing.Size(241, 27)
        Me.ValueY.TabIndex = 2
        '
        'ValueSide
        '
        Me.ValueSide.Location = New System.Drawing.Point(90, 160)
        Me.ValueSide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ValueSide.Name = "ValueSide"
        Me.ValueSide.Size = New System.Drawing.Size(241, 27)
        Me.ValueSide.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Координата Х вершины"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Координата У вершины"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Длина стороны"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(90, 194)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Выбрать цвет"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 310)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ValueSide)
        Me.Controls.Add(Me.ValueY)
        Me.Controls.Add(Me.ValueX)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Равносторонний треугольник"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ValueX As TextBox
    Friend WithEvents ValueY As TextBox
    Friend WithEvents ValueSide As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button2 As Button
End Class
