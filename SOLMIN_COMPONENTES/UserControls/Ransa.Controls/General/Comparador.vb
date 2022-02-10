Imports System.Collections.Generic

Public Class Comparador(Of T)
    Implements IComparer(Of T)
    Private mCriterio As String
    Private mTipo As TipoOrden

    Public Enum TipoOrden
        Ascendente = 0
        Descendente = 1
    End Enum

    Public Sub New()
        mTipo = TipoOrden.Ascendente
    End Sub

    Public Sub New(ByVal vCriterio As String)
        mTipo = TipoOrden.Ascendente
        mCriterio = vCriterio
    End Sub

    Public Sub New(ByVal vCriterio As String, ByVal vTipo As TipoOrden)
        mCriterio = vCriterio
        mTipo = vTipo
    End Sub

    Public Function Compare(ByVal x As T, ByVal y As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare
        Dim res As Integer
        If (mTipo = TipoOrden.Ascendente) Then
            res = x.GetType.GetProperty(mCriterio).GetValue(x, Nothing).CompareTo(y.GetType.GetProperty(mCriterio).GetValue(y, Nothing))
        Else
            res = y.GetType.GetProperty(mCriterio).GetValue(y, Nothing).CompareTo(x.GetType.GetProperty(mCriterio).GetValue(x, Nothing))
        End If
        Return (res)
    End Function
End Class
