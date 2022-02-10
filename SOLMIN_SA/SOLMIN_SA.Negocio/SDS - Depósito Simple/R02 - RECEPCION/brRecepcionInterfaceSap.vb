Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA

Public Class brRecepcionInterfaceSap
    Dim objDALote As New daRecepcionInterfaceSap


    Public Function ObtenerRegistroVentaCliente(ByVal obeRecepcionSap As beRecepcionInterfaceSap) As DataTable
        Return objDALote.ObtenerRegistroVentaCliente(obeRecepcionSap)
    End Function

    Public Function ObtenerDocInterfazSapRecepcion(ByRef obeRecepcionSap As beRecepcionInterfaceSap) As DataSet
        Return objDALote.ObtenerDocInterfazSapRecepcion(obeRecepcionSap)
    End Function

End Class
