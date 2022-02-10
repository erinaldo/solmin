Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brAlmacen

    Dim oDatos As New daAlmacen
    ''' <summary>
    ''' Retorna Tipo de Almacen
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TipoDeAlmacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Return oDatos.TipoDeAlmacen(obeAlmacen)
    End Function

    Public Function ListaTipoDeAlmacen() As List(Of beAlmacen)
        Return oDatos.ListaTipoDeAlmacen()
    End Function


    ''' <summary>
    ''' Retorna Almacen 
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Almacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Return oDatos.Almacen(obeAlmacen)
    End Function


    Public Function ListaAlmacen(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Return oDatos.ListaAlmacen(obeAlmacen)
    End Function

    ''' <summary>
    ''' Retorna Zona de almacen 
    ''' </summary>
    ''' <param name="obeAlmacen"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ZonaDeAlmacen(ByVal obeAlmacen As beAlmacen) As beAlmacen
        Return oDatos.ZonaDeAlmacen(obeAlmacen)
    End Function


    Public Function ListaZonaDeAlmacen(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Return oDatos.ListaZonaDeAlmacen(obeAlmacen)
    End Function


    Public Function ListaTipoDeMaterial(ByVal obeAlmacen As beAlmacen) As List(Of beAlmacen)
        Return oDatos.TipoDeMaterial(obeAlmacen)
    End Function

    Public Function Listar_Almacen_x_Tipo(ByVal obeAlmacen As beAlmacen) As DataTable
        Return oDatos.Listar_Almacen_x_Tipo(obeAlmacen)
    End Function


End Class