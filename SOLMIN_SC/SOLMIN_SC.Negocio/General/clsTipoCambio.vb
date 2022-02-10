Public Class clsTipoCambio
    Public Function Lista_TipoCambio(ByVal pdblFecha As Double) As Decimal
        Dim otipoCambio As New Datos.clsTipoCambio
        Return otipoCambio.Lista_TipoCambio(pdblFecha)
    End Function

End Class
