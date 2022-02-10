Public Class UCOrdena(Of T)
    Implements IComparer(Of T)
    Private mTipoOrdenacion As TipoOrdenacion
    Private mCriterio As String

    Public Enum TipoOrdenacion
        Ascendente = 0
        Descendente = 1
    End Enum

    Public Sub New(ByVal vCriterio As String)
        mCriterio = vCriterio
        mTipoOrdenacion = UCOrdena(Of T).TipoOrdenacion.Ascendente
    End Sub

    Public Sub New(ByVal vCriterio As String, ByVal vTipoOrdenacion As TipoOrdenacion)
        mCriterio = vCriterio
        mTipoOrdenacion = vTipoOrdenacion
    End Sub

    Public Function Compare(ByVal x As T, ByVal y As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare
        Try
            If mTipoOrdenacion = TipoOrdenacion.Ascendente Then
                Return (x.GetType.GetProperty(mCriterio).GetValue(x, Nothing).CompareTo(y.GetType.GetProperty(mCriterio).GetValue(y, Nothing)))
            Else
                Return (y.GetType.GetProperty(mCriterio).GetValue(x, Nothing).CompareTo(x.GetType.GetProperty(mCriterio).GetValue(y, Nothing)))
            End If
        Catch ex As Exception
        End Try
   
    End Function
End Class