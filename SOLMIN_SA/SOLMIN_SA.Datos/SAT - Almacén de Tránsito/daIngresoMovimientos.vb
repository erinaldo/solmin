Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.Utilitario
Public Class daIngresoMovimientos
    Inherits daBase(Of beIngresoMovimientos)

    Private objSql As New SqlManager

    Public Function ListarMovimientoFecha(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As List(Of beIngresoMovimientos)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obe_IngresoMovimientos.PSCCMPN)
        objParam.Add("PSCDVSN", obe_IngresoMovimientos.PSCDVSN)
        objParam.Add("PNCPLNDV", obe_IngresoMovimientos.PNCPLNDV)
        objParam.Add("PNCCLNT", obe_IngresoMovimientos.PNCCLNT)
        objParam.Add("PSNORCML", obe_IngresoMovimientos.PSNORCML)
        objParam.Add("PSTIPO", obe_IngresoMovimientos.PSSTPING)
        objParam.Add("PSSENTIDO", obe_IngresoMovimientos.PSSSNCRG)
        objParam.Add("PNFECINI", obe_IngresoMovimientos.PNFECINI)
        objParam.Add("PNFECFIN", obe_IngresoMovimientos.PNFECFIN)
        objParam.Add("PSTLUGEN", obe_IngresoMovimientos.PSTLUGEN)
        objParam.Add("PSTCMAEM", obe_IngresoMovimientos.PSTCMAEM)
        objParam.Add("PSNRUCPR", obe_IngresoMovimientos.PSNRUCPR)
        objParam.Add("PAGESIZE", obe_IngresoMovimientos.PageSize)
        objParam.Add("PAGENUMBER", obe_IngresoMovimientos.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.InputOutput)
        'Return Listar("SP_SOLMIN_WEB_SA_MOVIMIENTO_INGRESO_X_ITEM", objParam)
        Return Listar("SP_SOLMIN_SA_MOVIMIENTO_INGRESO_ITEM_PROVEEDOR", objParam)
        'Catch ex As Exception
        '    Return New List(Of beIngresoMovimientos)
        'End Try
    End Function

    Public Function ListarMovimientoFecha_OC(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As List(Of beIngresoMovimientos)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obe_IngresoMovimientos.PSCCMPN)
        objParam.Add("PSCDVSN", obe_IngresoMovimientos.PSCDVSN)
        objParam.Add("PNCPLNDV", obe_IngresoMovimientos.PNCPLNDV)
        objParam.Add("PNCCLNT", obe_IngresoMovimientos.PNCCLNT)
        objParam.Add("PSNORCML", obe_IngresoMovimientos.PSNORCML)
        objParam.Add("PSTIPO", obe_IngresoMovimientos.PSSTPING)
        objParam.Add("PSSENTIDO", obe_IngresoMovimientos.PSSSNCRG)
        objParam.Add("PNFECINI", obe_IngresoMovimientos.PNFECINI)
        objParam.Add("PNFECFIN", obe_IngresoMovimientos.PNFECFIN)
        objParam.Add("PSTLUGEN", obe_IngresoMovimientos.PSTLUGEN)
        objParam.Add("PSTCMAEM", obe_IngresoMovimientos.PSTCMAEM)
        objParam.Add("PSNRUCPR", obe_IngresoMovimientos.PSNRUCPR)
        objParam.Add("PAGESIZE", obe_IngresoMovimientos.PageSize)
        objParam.Add("PAGENUMBER", obe_IngresoMovimientos.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.InputOutput)
        'Return Listar("SP_SOLMIN_WEB_SA_MOVIMIENTO_INGRESO_X_BULTO_NSEQIN", objParam)
        Return Listar("SP_SOLMIN_SA_MOVIMIENTO_INGRESO_BULTO_PROVEEDOR", objParam)

        'Catch ex As Exception
        '    Return New List(Of beIngresoMovimientos)
        'End Try

    End Function



    Public Function dtListarConsultaIntegralOC(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As DataTable
        Dim objParam As New Parameter
        Dim odtConsultaIntegral As New DataTable
        objParam.Add("PSCCMPN", obe_IngresoMovimientos.PSCCMPN)
        objParam.Add("PSCDVSN", obe_IngresoMovimientos.PSCDVSN)
        objParam.Add("PNCPLNDV", obe_IngresoMovimientos.PNCPLNDV)
        objParam.Add("PNCCLNT", obe_IngresoMovimientos.PNCCLNT)
        objParam.Add("PNFECINI", obe_IngresoMovimientos.PNFECINI)
        objParam.Add("PNFECFIN", obe_IngresoMovimientos.PNFECFIN)
        objParam.Add("PSTIPOMOV", obe_IngresoMovimientos.PSTIPOMOV)
        objParam.Add("PNMEDIOSUG", obe_IngresoMovimientos.PNMEDIOSUG)
        objParam.Add("PNMEDIOCONF", obe_IngresoMovimientos.PNMEDIOCONF)
        objParam.Add("PSNORCML", obe_IngresoMovimientos.PSNORCML)
        objParam.Add("PNGUIAREMISION", obe_IngresoMovimientos.PNGUIAREMISION)
        objParam.Add("PSGUIAPROV", obe_IngresoMovimientos.PSGUIAPROV)
        objParam.Add("PSBULTO", obe_IngresoMovimientos.PSBULTO)

        odtConsultaIntegral = objSql.ExecuteDataTable("SP_SOLMIN_SA_CONSULTA_INTEGRAL_X_ORDEN_COMPRA", objParam)
        For Each Item As DataRow In odtConsultaIntegral.Rows
            Item("FREFFW") = HelpClass.FechaNum_a_Fecha(Item("FREFFW"))
            Item("F_RECEP_ALMACEN_OL") = HelpClass.FechaNum_a_Fecha(Item("F_RECEP_ALMACEN_OL"))
            Item("F_RECEP_CL") = HelpClass.FechaNum_a_Fecha(Item("F_RECEP_CL"))
            Item("F_SALIDA_ALMACEN_OL") = HelpClass.FechaNum_a_Fecha(Item("F_SALIDA_ALMACEN_OL"))
            Item("F_SALIDA_CL") = HelpClass.FechaNum_a_Fecha(Item("F_SALIDA_CL"))
            Item("FECHA_SALIDA_REAL") = HelpClass.FechaNum_a_Fecha(Item("FECHA_SALIDA_REAL"))
            Item("FECHA_ESTIMADA_LLEGADA") = HelpClass.FechaNum_a_Fecha(Item("FECHA_ESTIMADA_LLEGADA"))
            Item("FECHA_LLEGADA_REAL") = HelpClass.FechaNum_a_Fecha(Item("FECHA_LLEGADA_REAL"))
            Item("FECHA_CONF_LLEGADA") = HelpClass.FechaNum_a_Fecha(Item("FECHA_CONF_LLEGADA"))

        Next
        Return odtConsultaIntegral
    End Function


    Public Function dtListarConsultaIntegralItem(ByVal obe_IngresoMovimientos As beIngresoMovimientos) As DataTable
        Dim objParam As New Parameter
        Dim odtConsultaIntegral As New DataTable

        objParam.Add("PSCCMPN", obe_IngresoMovimientos.PSCCMPN)
        objParam.Add("PSCDVSN", obe_IngresoMovimientos.PSCDVSN)
        objParam.Add("PNCPLNDV", obe_IngresoMovimientos.PNCPLNDV)
        objParam.Add("PNCCLNT", obe_IngresoMovimientos.PNCCLNT)
        objParam.Add("PNFECINI", obe_IngresoMovimientos.PNFECINI)
        objParam.Add("PNFECFIN", obe_IngresoMovimientos.PNFECFIN)
        objParam.Add("PSTIPOMOV", obe_IngresoMovimientos.PSTIPOMOV)
        objParam.Add("PNMEDIOSUG", obe_IngresoMovimientos.PNMEDIOSUG)
        objParam.Add("PNMEDIOCONF", obe_IngresoMovimientos.PNMEDIOCONF)
        objParam.Add("PSNORCML", obe_IngresoMovimientos.PSNORCML)
        objParam.Add("PSCODITEM", obe_IngresoMovimientos.PSCODITEM)
        objParam.Add("PNGUIAREMISION", obe_IngresoMovimientos.PNGUIAREMISION)
        objParam.Add("PSGUIAPROV", obe_IngresoMovimientos.PSGUIAPROV)
        objParam.Add("PSBULTO", obe_IngresoMovimientos.PSBULTO)

        odtConsultaIntegral = objSql.ExecuteDataTable("SP_SOLMIN_SA_CONSULTA_INTEGRAL_X_ORDEN_COMPRA_ITEM", objParam)

        For Each Item As DataRow In odtConsultaIntegral.Rows
            Item("FREFFW") = HelpClass.FechaNum_a_Fecha(Item("FREFFW"))
            Item("F_RECEP_ALMACEN_OL") = HelpClass.FechaNum_a_Fecha(Item("F_RECEP_ALMACEN_OL"))
            Item("F_RECEP_CL") = HelpClass.FechaNum_a_Fecha(Item("F_RECEP_CL"))
            Item("F_SALIDA_ALMACEN_OL") = HelpClass.FechaNum_a_Fecha(Item("F_SALIDA_ALMACEN_OL"))
            Item("F_SALIDA_CL") = HelpClass.FechaNum_a_Fecha(Item("F_SALIDA_CL"))
            Item("FECHA_SALIDA_REAL") = HelpClass.FechaNum_a_Fecha(Item("FECHA_SALIDA_REAL"))
            Item("FECHA_ESTIMADA_LLEGADA") = HelpClass.FechaNum_a_Fecha(Item("FECHA_ESTIMADA_LLEGADA"))
            Item("FECHA_LLEGADA_REAL") = HelpClass.FechaNum_a_Fecha(Item("FECHA_LLEGADA_REAL"))
            Item("FECHA_CONF_LLEGADA") = HelpClass.FechaNum_a_Fecha(Item("FECHA_CONF_LLEGADA"))

        Next

        Return odtConsultaIntegral
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beIngresoMovimientos)

    End Sub
End Class
