Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daDespachoMovimientos
    Inherits daBase(Of beDespachoMovimientos)
    Private objSql As New SqlManager
    Public Function ListarMovimientoFecha(ByVal obe_DespachoMovimientos_BE As beDespachoMovimientos) As List(Of beDespachoMovimientos)

        Dim objParam As New Parameter
        Dim objDataTable As New List(Of beDespachoMovimientos)
        Try
            objParam.Add("PSCCMPN", obe_DespachoMovimientos_BE.PSCCMPN)
            objParam.Add("PSCDVSN", obe_DespachoMovimientos_BE.PSCDVSN)
            objParam.Add("PNCPLNDV", obe_DespachoMovimientos_BE.PNCPLNDV)
            objParam.Add("PNCCLNT", obe_DespachoMovimientos_BE.PNCCLNT)
            objParam.Add("PSNORCML", obe_DespachoMovimientos_BE.PSNORCML)
            objParam.Add("PSTIPO", obe_DespachoMovimientos_BE.PSSTPING)
            objParam.Add("PSSENTIDO", obe_DespachoMovimientos_BE.PSSSNCRG)
            objParam.Add("PNFECINI", obe_DespachoMovimientos_BE.PNFECINI)
            objParam.Add("PNFECFIN", obe_DespachoMovimientos_BE.PNFECFIN)
            objParam.Add("PSFLGCNL", obe_DespachoMovimientos_BE.PSFLGCNL.ToString.ToUpper)
            objParam.Add("PNMEDENVIO", obe_DespachoMovimientos_BE.PNCODMEDENVIO)
            objParam.Add("PSTLUGEN", obe_DespachoMovimientos_BE.PSTLUGEN)
            objParam.Add("PSTCMAEM", obe_DespachoMovimientos_BE.PSTCMAEM)
            objParam.Add("PSNRUCPR", obe_DespachoMovimientos_BE.PSNRUCPR)
            objParam.Add("PAGESIZE", obe_DespachoMovimientos_BE.PageSize)
            objParam.Add("PAGENUMBER", obe_DespachoMovimientos_BE.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.InputOutput)
            'objDataTable = Listar("SP_SOLMIN_WEB_SA_MOVIMIENTO_DESPACHO_X_ITEM", objParam)
            objDataTable = Listar("SP_SOLMIN_SA_MOVIMIENTO_DESPACHO_ITEM_PROVEEDOR", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function ListarMovimientoFecha_OC(ByVal obe_DespachoMovimientos_BE As beDespachoMovimientos, ByRef PageCount As Integer) As DataTable

        Dim objParam As New Parameter
        Dim objDataTable As New DataTable

        'Try
        objParam.Add("PSCCMPN", obe_DespachoMovimientos_BE.PSCCMPN)
        objParam.Add("PSCDVSN", obe_DespachoMovimientos_BE.PSCDVSN)
        objParam.Add("PNCPLNDV", obe_DespachoMovimientos_BE.PNCPLNDV)
        objParam.Add("PNCCLNT", obe_DespachoMovimientos_BE.PNCCLNT)
        objParam.Add("PSNORCML", obe_DespachoMovimientos_BE.PSNORCML)
        objParam.Add("PSTIPO", obe_DespachoMovimientos_BE.PSSTPING)
        objParam.Add("PSSENTIDO", obe_DespachoMovimientos_BE.PSSSNCRG)
        objParam.Add("PNFECINI", obe_DespachoMovimientos_BE.PNFECINI)
        objParam.Add("PNFECFIN", obe_DespachoMovimientos_BE.PNFECFIN)
        objParam.Add("PSFLGCNL", obe_DespachoMovimientos_BE.PSFLGCNL.ToString.ToUpper)
        objParam.Add("PNMEDENVIO", obe_DespachoMovimientos_BE.PNCODMEDENVIO)
        objParam.Add("PSTLUGEN", obe_DespachoMovimientos_BE.PSTLUGEN)
        objParam.Add("PSTCMAEM", obe_DespachoMovimientos_BE.PSTCMAEM)
        objParam.Add("PSNRUCPR", obe_DespachoMovimientos_BE.PSNRUCPR)
        objParam.Add("PAGESIZE", obe_DespachoMovimientos_BE.PageSize)
        objParam.Add("PAGENUMBER", obe_DespachoMovimientos_BE.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.InputOutput)
        'objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WEB_SA_MOVIMIENTO_DESPACHO_BULTO_PROVEEDOR", objParam)
        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_SA_MOVIMIENTO_DESPACHO_BULTO_PROVEEDOR_LM2", objParam)
        If objParam.Count > 0 Then
            'PageCount = objParam.Item(objParam.Count).Value
            If objParam.Item(objParam.Count).ParameterName = "PAGECOUNT" Then
                PageCount = Convert.ToInt32(objParam.Item(objParam.Count).Value) + 1
            End If
        End If


        'Catch ex As Exception
        'End Try

        Return objDataTable
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beDespachoMovimientos)

    End Sub
End Class
