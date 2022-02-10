Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA
Public Class brMaestroRuta
    Dim oDatos As New daMaestroRuta

    Public Function Insertar(ByVal obe_beMaestroRuta As beMaestroRuta) As Integer
        Return oDatos.Insertar(obe_beMaestroRuta)
    End Function
    Public Function Actualizar(ByVal obe_beMaestroRuta As beMaestroRuta) As Integer
        Return oDatos.Actualizar(obe_beMaestroRuta)
    End Function
    Public Function Listar() As List(Of beMaestroRuta)
        Return oDatos.Listar()
    End Function
    Public Function ListarxCodigoRuta(ByVal CRUTAT As String) As beMaestroRuta
        Return oDatos.ListarxCodigoRuta(CRUTAT)
    End Function
    Public Function Eliminar(ByVal obeMaestroRuta As beMaestroRuta) As Integer
        Return oDatos.Eliminar(obeMaestroRuta)
    End Function

End Class