Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA
Public Class brRutaTienda
    Dim oDatos As New daRutaTienda
    Public Function Insertar(ByVal obe_beRutaTienda As beRutaTienda) As Integer
        Return oDatos.Insertar(obe_beRutaTienda)
    End Function
    Public Function Actualizar(ByVal obe_beRutaTienda As beRutaTienda) As Integer
        Return oDatos.Actualizar(obe_beRutaTienda)
    End Function
    Public Function Listar(ByVal obe_beRutaTienda As beRutaTienda) As List(Of beRutaTienda)
        Return oDatos.Listar(obe_beRutaTienda)
    End Function
    Public Function Eliminar(ByVal obe_beRutaTienda As beRutaTienda) As Integer
        Return oDatos.Eliminar(obe_beRutaTienda)
    End Function

    Public Function ListarRuteoxPuntoEntrega(ByVal obe_beRutaTienda As beRutaTienda) As List(Of beRutaTienda)
        Return oDatos.ListarRuteoxPuntoEntrega(obe_beRutaTienda)
    End Function
End Class