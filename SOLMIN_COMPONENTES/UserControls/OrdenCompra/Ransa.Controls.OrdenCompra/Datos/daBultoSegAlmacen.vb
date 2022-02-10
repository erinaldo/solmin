
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daBultoSegAlmacen

  ' Inherits daBase(Of beBulto)

  Private objSql As New SqlManager
  Public Function ListarMovimientoItemOrdenCompra(ByVal obeBulto As beBultoSegAlmacen) As DataTable
    Dim objSqlManager As SqlManager = New SqlManager
    Dim objParametros As Parameter = New Parameter

    Try
      With objParametros
        .Add("PNCCLNT", obeBulto.PNCCLNT)
        .Add("PSCCMPN", obeBulto.PSCCMPN)
        .Add("PSCDVSN", obeBulto.PSCDVSN)
        .Add("PNCPLNDV", obeBulto.PNCPLNDV)
        .Add("PSNORCML", obeBulto.PSNORCML)
      End With
      Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_OC", objParametros)
    Catch ex As Exception
      Return New DataTable
    End Try
  End Function

  Public Function ListarMovimientoDetalle_X_ItemOrdenCompra(ByVal obeBulto As beBultoSegAlmacen) As DataTable
    Dim objSqlManager As SqlManager = New SqlManager
    Dim objParametros As Parameter = New Parameter
    Dim dt As New DataTable
    Try
      With objParametros
        .Add("PNCCLNT", obeBulto.PNCCLNT)
        .Add("PSCCMPN", obeBulto.PSCCMPN)
        .Add("PSCDVSN", obeBulto.PSCDVSN)
        .Add("PNCPLNDV", obeBulto.PNCPLNDV)
        .Add("PSNORCML", obeBulto.PSNORCML)
        .Add("IN_NRITOC", obeBulto.PNNRITOC)
      End With
      dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTOS_X_ITEM_OC", objParametros)
      Return dt
    Catch ex As Exception
      Return New DataTable
    End Try
  End Function

  Public Function ListarDetalleBulto(ByVal obeBultoPK As beBultoSegAlmacen) As DataTable
    Dim oDt As New DataTable
    Dim objSqlManager As SqlManager = New SqlManager
    Dim olbebeBulto As New List(Of beBulto)
    Dim objParam As New Parameter
    Try
      objParam.Add("PSCCMPN", obeBultoPK.PSCCMPN)
      objParam.Add("PSCDVSN", obeBultoPK.PSCDVSN)
      objParam.Add("PNCPLNDV", obeBultoPK.PNCPLNDV)
      objParam.Add("PNCCLNT", obeBultoPK.PNCCLNT)
      objParam.Add("PSCREFFW", obeBultoPK.PSCREFFW)
      objParam.Add("PNNSEQIN", obeBultoPK.PNNSEQIN)
      oDt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_BULTO_LISTAR", objParam)
      Return oDt
    Catch ex As Exception
    End Try
    Return oDt ' olbebeBulto
  End Function
End Class
