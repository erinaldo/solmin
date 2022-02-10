Public Class ucOrdenaS(Of T)
    Implements IComparer(Of T)
    Private _CampoOrdenar As String
    Private _TipoOrden As TiposOrden
    Private _IsDate As Boolean = False
    Public Enum TiposOrden
        'DE ACUERDO A ORDENACION DE GRILLA
        Ascendente = 1
        Descendente = 2
    End Enum
    Public Sub New(ByVal vCampoOrdenar As String)
        _CampoOrdenar = vCampoOrdenar
        _TipoOrden = ucOrdenaS(Of T).TiposOrden.Ascendente
    End Sub
    Public Sub New(ByVal vCampoOrdenar As String, ByVal vTipoOrden As TiposOrden, ByVal IsDate As Boolean)
        _CampoOrdenar = vCampoOrdenar
        _TipoOrden = vTipoOrden
        _IsDate = IsDate
    End Sub
    Public Function Compare(ByVal x As T, ByVal y As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare
        Dim ValorX As Object = x.GetType.GetProperty(_CampoOrdenar).GetValue(x, Nothing)
        Dim ValorY As Object = y.GetType.GetProperty(_CampoOrdenar).GetValue(y, Nothing)
        Dim ValorXE As Date
        Dim ValorYE As Date
        If _TipoOrden = ucOrdenaS(Of T).TiposOrden.Ascendente Then
            If _IsDate = True Then
                Date.TryParse(ValorX, ValorXE)
                Date.TryParse(ValorY, ValorYE)
                Return (ValorXE.CompareTo(ValorYE))
            Else
                Return (ValorX.CompareTo(ValorY))
            End If
        Else
            If _IsDate = True Then
                Date.TryParse(ValorX, ValorXE)
                Date.TryParse(ValorY, ValorYE)
                Return (ValorYE.CompareTo(ValorXE))
            Else
                Return (ValorY.CompareTo(ValorX))
            End If
        End If
    End Function
End Class
