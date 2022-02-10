Public Class ucText
    Inherits System.Windows.Forms.TextBox

    'Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
    '    MyBase.OnPaint(pe)

    '    'Agregue su código personalizado de dibujo aquí
    'End Sub


    Private _Enteros As Integer
    Public Property Enteros() As Integer
        Get
            Return _Enteros
        End Get
        Set(ByVal value As Integer)
            _Enteros = value
        End Set
    End Property


    Private _Decimales As Integer
    Public Property Decimales() As Integer
        Get
            Return _Decimales
        End Get
        Set(ByVal value As Integer)
            _Decimales = value
        End Set
    End Property

    Protected Overloads Sub CambioDeTexto(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        'Agregue su código personalizado de dibujo aquí
    End Sub

End Class


