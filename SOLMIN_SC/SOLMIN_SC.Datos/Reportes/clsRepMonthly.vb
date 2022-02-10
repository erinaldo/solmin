Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports System.Text
Imports Ransa.Utilitario
Public Class clsRepMonthly
    Public Function dtRepMonthlyOperaciones(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal ListaRegimen As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim ds As New DataSet
        Dim dtOC As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", ListaRegimen)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_ADUANAS_AJUSTE", lobjParams)
        dt = ds.Tables(0).Copy
        dt.Columns.Add("NORCML")
        dtOC = ds.Tables(1).Copy

        Dim NORSCI As Decimal = 0
        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
        Next

        Return dt
    End Function


    Public Function RepMonthlyAduanasUnificado(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal ListaRegimen As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataSet
        Dim ds As New DataSet
        Dim dtOC As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", ListaRegimen)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_ADUANAS_AJUSTE_UNIFICADO", lobjParams)
        Return ds
    End Function


    Private Function DistinctOrdenCompra(ByVal dtOrdenCompra As DataTable, ByVal NORSCI As Decimal) As String
        Dim dr() As DataRow
        Dim sbOC As New StringBuilder
        Dim norcml As String = ""
        Dim listVisitados As New List(Of String)
        dr = dtOrdenCompra.Select("NORSCI='" & NORSCI & "'")
        For Each Item As DataRow In dr
            norcml = HelpClass.ToStringCvr(Item("NORCML"))
            If norcml.Length > 0 AndAlso (Not listVisitados.Contains(norcml)) Then
                listVisitados.Add(norcml)
                sbOC.Append(norcml)
                sbOC.Append(",")
            End If
        Next
        norcml = sbOC.ToString.Trim
        If norcml.Length > 0 Then
            norcml = norcml.Substring(0, norcml.LastIndexOf(","))
        End If
        Return norcml
    End Function

    Public Function dtRepMonthlyOperacionesAgencias(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_ADUANAS_AGENCIAS", lobjParams)
        Return dt
    End Function

    Public Function dtRepMonthlyFacturacion(ByVal PNCCLNT As Decimal, ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable '(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_FACTURA_ADUANAS", lobjParams)
        Return dt
    End Function

    Public Function dtRepMonthlyFacturacionImportacionDatos(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable '(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_FACTURA_ADUANAS_IMPORTACION", lobjParams)
        Return dt
    End Function



    Public Function dtRepMonthlyDetalleDebito(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable '(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_DETALLE_DEBITO", lobjParams)
        Return dt
    End Function


    Public Function dtRepMonthlyCostoAgencias(ByVal obeDetalleGastoXOS As beDetalleGastoXOS) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", obeDetalleGastoXOS.PNNORDSR)
        lobjParams.Add("PSCZNFCC", obeDetalleGastoXOS.PNCZNFCC)
        lobjParams.Add("PSTPSRVA", obeDetalleGastoXOS.PSTPSRVA)
        lobjParams.Add("PNCPLNDV", obeDetalleGastoXOS.PNCPLNDV)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_REPMONTHLY_IMPORTACION_COSTOS_AGENCIAS_AJUSTE", lobjParams)
        ds.Tables(0).TableName = "odtCostosOperativos"
        ds.Tables(1).TableName = "odtComision"
        Return ds
    End Function


    Public Function dtRepMonthlyContenedores(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As New DataTable
        Dim dtOC As New DataTable
        Dim ds As New DataSet

        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjSql.TimeOutCommand = 1000
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_CONTENEDORES_AJUSTE", lobjParams)
        dt = ds.Tables(0).Copy
        dt.Columns.Add("NORCML")
        dtOC = ds.Tables(1).Copy
        Dim NORSCI As Decimal = 0
        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
        Next
        Return dt
    End Function

    'Public Function dtRepMonthlyTiempoEntrega(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim dtOC As New DataTable
    '    Dim ds As New DataSet
    '    Dim lobjParams As New Parameter

    '    lobjSql.TimeOutCommand = 1000
    '    lobjParams.Add("PSCCMPN", PSCCMPN)
    '    lobjParams.Add("PNCCLNT", PNCCLNT)
    '    lobjParams.Add("PNFECINI", PNFECINI)
    '    lobjParams.Add("PNFECFIN", PNFECFIN)
    '    lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
    '    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    '    lobjParams.Add("PNNESTDO", PNNESTDO)
    '    lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
    '    ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_TIEMPO_ENTREGA_AJUSTE", lobjParams)
    '    dt = ds.Tables(0).Copy
    '    dtOC = ds.Tables(1).Copy
    '    dt.Columns.Add("NORCML")
    '    Dim NORSCI As Decimal = 0
    '    For Each Item As DataRow In dt.Rows
    '        NORSCI = Item("NORSCI")
    '        Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
    '        Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
    '    Next
    '    Return dt
    'End Function

    Public Function dtRepMonthlyTiempoEntrega(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim dtOC As New DataTable
        Dim ds As New DataSet
        Dim lobjParams As New Parameter

        lobjSql.TimeOutCommand = 1000
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_TIEMPO_ENTREGA_AJUSTE", lobjParams)
        dt = ds.Tables(0).Copy
        dtOC = ds.Tables(1).Copy
        dt.Columns.Add("NORCML")
        Dim NORSCI As Decimal = 0
        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
            Item("NORCML") = DistinctOrdenCompra(dtOC, NORSCI)
        Next
        Return dt
    End Function


    Public Function dtRepMonthlyNavieras(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjSql.TimeOutCommand = 1000
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_NAVIERAS_AJUSTE", lobjParams)
        Return dt
    End Function

    Public Function dtRepMonthlyFechaDocumentos(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_FECHA_DOCUMENTOS_AJUSTE", lobjParams)
        Return dt
    End Function

    Enum EnumCheckPoint
        Entrega_Almacen = 124
        Levante = 123
        Volante = 116
        Documentos = 120
        Numeracion = 121
        Derechos = 122
    End Enum

    Private Function BuscarCheckPointAduana(ByVal dtCheckPoint As DataTable, ByVal NORSCI As Decimal, ByVal pNESTDO As EnumCheckPoint) As String
        Dim dr() As DataRow
        Dim chk As String = ""
        Dim NESTDO As Decimal = pNESTDO
        dr = dtCheckPoint.Select("NORSCI='" & NORSCI & "' AND NESTDO='" & NESTDO & "'")
        If dr.Length > 0 Then
            chk = HelpClass.FechaNum_a_Fecha(dr(0)("FRETES"))
        End If
        Return chk
    End Function

    Public Function dtRepMonthlyTiempoAduanas(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSLISTAREGIMEN As String, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim dtCheckPoint As New DataTable
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSLISTAREGIMEN", PSLISTAREGIMEN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPMONTHLY_TIEMPO_ADUANAS_AJUSTE", lobjParams)
        dt = ds.Tables(0).Copy
        dt.Columns.Add("DOCCOM")
        dt.Columns.Add("ALMCLI")
        dtCheckPoint = ds.Tables(1).Copy

        Dim NORSCI As Decimal = 0
        For Each Item As DataRow In dt.Rows
            NORSCI = Item("NORSCI")
            Item("FAPRAR") = HelpClass.FechaNum_a_Fecha(Item("FAPRAR"))
            Item("DOCCOM") = BuscarCheckPointAduana(dtCheckPoint, NORSCI, EnumCheckPoint.Documentos)
            Item("ALMCLI") = BuscarCheckPointAduana(dtCheckPoint, NORSCI, EnumCheckPoint.Entrega_Almacen)
        Next

        Return dt
    End Function

    Public Function dtNoLaborables(ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_NOLABORABLE", lobjParams)
        Return dt
    End Function


    Public Function dtRepMonthlyTiempoEntregaordenCompra(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable '(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_TIEMPO_ENTREGA_OC", lobjParams)
        Return dt
    End Function


    Public Function dtRepMonthlyDetalleDebito_Costo_Operativo(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_DETALLE_DEBITO_COSTO_OPERATIVO", lobjParams)
        Return dt
    End Function

    Public Function dtRepMonthlyDetalleDebito_Costo_Operativo_ImportacionDatos(ByVal PNNORDSR As Double, ByVal PSCZNFCC As String, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", PNNORDSR)
        lobjParams.Add("PSCZNFCC", PSCZNFCC)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMONTHLY_DETALLE_DEBITO_COSTO_OPERATIVO_IMPORTACION", lobjParams)
        Return dt
    End Function
End Class
