Imports RANSA.DATA
Imports RANSA.TYPEDEF.Reportes
Imports System.Text
Public Class brPreDespachoBulto
    Dim oDatos As New daPreDespachoBulto
    ''' <summary>
    ''' Lista para Predespacho
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstPredespachoLectura(ByVal obeFiltro As bePreDespacho) As DataSet
        Return oDatos.fdstPredespachoLectura(obeFiltro)
    End Function
    Public Function Listar_Paletizados_Todos(ByVal obeFiltro As bePreDespacho, NroPag As Decimal, PageSize As Decimal, ByRef TotPag As Decimal) As DataTable
        Return oDatos.Listar_Paletizados_Todos(obeFiltro, NroPag, PageSize, TotPag)
    End Function

    Public Function Listar_Bultos_X_DetPaletizado(ByVal obeFiltro As bePreDespacho) As DataTable
        Return oDatos.Listar_Bultos_X_DetPaletizado(obeFiltro)
    End Function

    Public Function Listar_Bultos_X_Det_Formato01_Paletizado(ByVal obeFiltro As bePreDespacho) As DataTable
        Return oDatos.Listar_Bultos_X_Det_Formato01_Paletizado(obeFiltro)
    End Function
    '

End Class
