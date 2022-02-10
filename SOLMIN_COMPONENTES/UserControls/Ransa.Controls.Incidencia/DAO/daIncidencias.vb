Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class daIncidencias
    Inherits daBase(Of beIncidencias)
    Private objSql As New SqlManager


    Public Function intInsertarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSTINCSI", obeIncidencias.PSTINCSI)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
        objParam.Add("PSCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSSTIPPR", obeIncidencias.PSSTIPPR) 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_INSERT", objParam)
        Return objSql.ParameterCollection("PSRESULT")
    End Function
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF004]-190516
    Public Function olisListarMovimientoAlmacenSimple(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCSRVC", obeIncidencias.PSCSRVC)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNNGUIRN", obeIncidencias.PNNGUIRN)
        objParam.Add("PSNGUICL", obeIncidencias.PSNGUICL)
        objParam.Add("PNCDPEPL", obeIncidencias.PNCDPEPL)
        objParam.Add("PNFRLZSR_INI", obeIncidencias.PNFRLZSR_INI)
        objParam.Add("PNFRLZSR_FIN", obeIncidencias.PNFRLZSR_FIN)

        Return Listar("SP_SOLMIN_SA_LISTA_MOVIMIENTO_ALMACEN_SIMPLE", objParam)
    End Function
    'END: JDT-Almacén Repuestos On Side - Piura[RF004]-190516

    Public Sub intInsertarIncidenciasCliente(ByVal obeIncidencias As beIncidencias)

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_INSERT", objParam)

    End Sub

    Public Function intActualizarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSTINCSI", obeIncidencias.PSTINCSI)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSSTIPPR", obeIncidencias.PSSTIPPR) 'JDT-Almacén Repuestos On Side - Piura[RF003]-190516
        objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_UPDATE", objParam)

        Return objSql.ParameterCollection("PSRESULT")
    End Function

    Public Function intActualizarMaestroIncidencias_Confirmacion(ByVal obeIncidencias As beIncidencias, ByVal cod_anterior As Integer) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCTPINC", CDec(cod_anterior))

        Return objSql.ExecuteScalar("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_CONFIRMACION", objParam)

    End Function

    Public Function intEliminarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_DELETE", objParam)

        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Sub intGuardarImagenIncidencias(ByVal NINCSI As Decimal, ByVal NMRGIM As Decimal, ByVal usuario As String, ByVal NTRMNL As String)

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", NINCSI)
        objParam.Add("PNNMRGIM", NMRGIM)
        objParam.Add("PSUSUARIO", usuario)
        objParam.Add("PSNTRMNL", NTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_GUARDAR_IMAGEN_INCIDENCIA", objParam)

    End Sub

    Public Sub intEliminarImagenIncidencias(ByVal NINCSI As Decimal, ByVal NMRGIM As Decimal, ByVal usuario As String, ByVal NTRMNL As String)

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", NINCSI)
        objParam.Add("PNNMRGIM", 0D)
        objParam.Add("PSUSUARIO", usuario)
        objParam.Add("PSNTRMNL", NTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_GUARDAR_IMAGEN_INCIDENCIA", objParam)

    End Sub

    'Public Function olistListarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As DataSet
    '    Dim ds As New DataSet
    '    Dim objParam As New Parameter

    '    objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
    '    objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
    '    objParam.Add("PNANIO", obeIncidencias.ANIO)
    '    ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_LIST", objParam)

    '    Return ds
    'End Function


    'Public Function olistListarMaestroIncidenciasCliente(ByVal obeIncidencias As beIncidencias) As DataSet
    'Dim ds As New DataSet
    'Dim objParam As New Parameter

    '    objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
    '    objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
    '    objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
    '    objParam.Add("PNANIO", obeIncidencias.ANIO)
    '    ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_CLIENTE_LIST", objParam)
    '    Return ds
    'End Function


    Public Function olistListarMaestroIncidenciasClientePerfil(ByVal obeIncidencias As beIncidencias) As DataSet
        Dim ds As New DataSet
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_CLIENTE_LIST_PERFIL", objParam)
        Return ds
    End Function



    Public Function intInsertarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNFRGTRO", obeIncidencias.PNFRGTRO)
        objParam.Add("PNHRGTRO", obeIncidencias.PNHRGTRO)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCPLNDV", obeIncidencias.PNCPLNDV)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PSTINCDT", obeIncidencias.PSTINCDT)
        objParam.Add("PSTRDCCL", obeIncidencias.PSTRDCCL)
        objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM)
        objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
        objParam.Add("PSCZNALM", obeIncidencias.PSCZNALM)
        objParam.Add("PNCPRVCL", obeIncidencias.PNCPRVCL)
        objParam.Add("PNCPLCLP", obeIncidencias.PNCPLCLP)
        objParam.Add("PNQAINSM", obeIncidencias.PNQAINSM)
        objParam.Add("PSCUNDCN", obeIncidencias.PSCUNDCN)
        'objParam.Add("PNICSTOS", obeIncidencias.PNICSTOS)
        'objParam.Add("PNCDMNDA", obeIncidencias.PNCDMNDA)
        objParam.Add("PSTIRALC", obeIncidencias.PSTIRALC)
        objParam.Add("PSPRSCNT", obeIncidencias.PSPRSCNT)
        objParam.Add("PSSNVINC", obeIncidencias.PSSNVINC)
        objParam.Add("PSSORINC", obeIncidencias.PSSORINC)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)

        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCRGVTA", obeIncidencias.PSCRGVTA)

        objParam.Add("PSSTIPPR", obeIncidencias.PSSTIPPR) 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
        objParam.Add("PSTIPDRF", obeIncidencias.PSTIPDRF) 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516

        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_INSERT", objParam)
        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Sub intActualizarRegistroIncidencias(ByVal obeIncidencias As beIncidencias)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN.Trim)
        objParam.Add("PNNINCSI", obeIncidencias.PNNINCSI)
        objParam.Add("PNFRGTRO", obeIncidencias.PNFRGTRO)
        objParam.Add("PNHRGTRO", obeIncidencias.PNHRGTRO)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCPLNDV", obeIncidencias.PNCPLNDV)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PSTINCDT", obeIncidencias.PSTINCDT.Trim)
        objParam.Add("PSTRDCCL", obeIncidencias.PSTRDCCL.Trim)
        objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM.Trim)
        objParam.Add("PSCALMC", obeIncidencias.PSCALMC.Trim)
        objParam.Add("PSCZNALM", obeIncidencias.PSCZNALM.Trim)
        objParam.Add("PNCPRVCL", obeIncidencias.PNCPRVCL)
        objParam.Add("PNCPLCLP", obeIncidencias.PNCPLCLP)
        objParam.Add("PNQAINSM", obeIncidencias.PNQAINSM)
        objParam.Add("PSCUNDCN", obeIncidencias.PSCUNDCN.Trim)
        'objParam.Add("PNICSTOS", obeIncidencias.PNICSTOS)
        'objParam.Add("PNCDMNDA", obeIncidencias.PNCDMNDA)
        objParam.Add("PSTIRALC", obeIncidencias.PSTIRALC.Trim)
        objParam.Add("PSPRSCNT", obeIncidencias.PSPRSCNT.Trim)
        objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
        objParam.Add("PSSNVINC", obeIncidencias.PSSNVINC)
        objParam.Add("PSSORINC", obeIncidencias.PSSORINC)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)

        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCRGVTA", obeIncidencias.PSCRGVTA)

        objParam.Add("PSSTIPPR", obeIncidencias.PSSTIPPR) 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516
        objParam.Add("PSTIPDRF", obeIncidencias.PSTIPDRF) 'JDT-Almacén Repuestos On Side - Piura[RF004]-190516

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_UPDATE", objParam)

    End Sub


    Public Sub intEliminarRegistroIncidencias(ByVal obeIncidencias As beIncidencias)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNNINCSI", obeIncidencias.PNNINCSI)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_ELIMINAR", objParam)

    End Sub


    Public Function intEliminarIncidenciasCliente(ByVal obeIncidencias As beIncidencias) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_DELETE", objParam)
        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Function olisListarRegistroIncidencias(ByVal obeIncidencias As beIncidencias, ByVal PLANTAS As String) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSCPLNDV", PLANTAS)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNNINCSI", obeIncidencias.PNNINCSI)
        objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
        objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)
        objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
        objParam.Add("PSSESINC", obeIncidencias.PSSESINC)

        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCRGVTA", obeIncidencias.PSCRGVTA)
        objParam.Add("PSSORINC", obeIncidencias.PSSORINC)

        Return Listar("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_LIST_V5", objParam)

    End Function

    Public Function olisListarRegistroIncidenciasVista(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC.Trim)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
        objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
        objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)
        objParam.Add("PSCALMC", obeIncidencias.PSCALMC)

        Return Listar("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_LIST_VISTA_V2", objParam)

    End Function


    Public Function olisListarTipoIncidenciasCliente(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        Return Listar("SP_SOLMIN_SA_TIPO_INCIDENCIAS_INC_PARA_LIST", objParam)

    End Function

    Public Function ListarIncidenciasCliente(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)

        Return Listar("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_LIST", objParam)

    End Function

    Public Function ConsultaIncidenciaPorFecha(ByVal obeIncidencias As beIncidencias) As DataSet

        Dim oDs As New DataSet
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSCPLNDV", obeIncidencias.PSCPLNDV_DES)
        objParam.Add("PSCCLNT", obeIncidencias.PSCCLNT1)
        objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM)
        objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
        objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
        objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)

        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCRGVTA", obeIncidencias.PSCRGVTA)
        objParam.Add("PSSORINC", obeIncidencias.PSSORINC)

        oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_FECHA_V1", objParam)

        oDs.Tables(0).Columns.Add("FRGTRO1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRGTRO1", Type.GetType("System.String"))

        For Each Item As DataRow In oDs.Tables(0).Rows
            Item("FRGTRO1") = HelpClass.FechaNum_a_Fecha(Item("FRGTRO"))
            Item("HRGTRO1") = HelpClass.HoraNum_a_Hora(Item("HRGTRO"))
        Next
        oDs.Tables(0).Columns.Remove("FRGTRO")
        oDs.Tables(0).Columns.Remove("HRGTRO")

        oDs.Tables(0).Columns.Add("FRGTRO", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRGTRO", Type.GetType("System.String"))

        For Each Item As DataRow In oDs.Tables(0).Rows
            Item("FRGTRO") = Item("FRGTRO1")
            Item("HRGTRO") = Item("HRGTRO1")

            If Item("HRACRT") = 0 Then
                Item("CUSCRT") = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(Item("FCHCRT")) & " - "
            Else
                Item("CUSCRT") = Item("CUSCRT").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(Item("FCHCRT")) & " - " & HelpClass.HoraNum_a_Hora(Item("HRACRT"))
            End If

            If Item("HULTAC") = 0 Then
                Item("CULUSA") = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(Item("FULTAC")) & " - "
            Else
                Item("CULUSA") = Item("CULUSA").ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(Item("FULTAC")) & " - " & HelpClass.HoraNum_a_Hora(Item("HULTAC"))
            End If

            If Item("CUSCRT").ToString.Trim.Length = 4 Then
                Item("CUSCRT") = ""
            End If

            If Item("CULUSA").ToString.Trim.Length = 4 Then
                Item("CULUSA") = ""
            End If

        Next

        oDs.Tables(0).Columns.Remove("FRGTRO1")
        oDs.Tables(0).Columns.Remove("HRGTRO1")

        Return oDs

    End Function

    Public Function ConsultaIncidenciaPorMes(ByVal obeIncidencias As beIncidencias) As DataSet
        Dim DT As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim DS As New DataSet

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PSCPLNDV", obeIncidencias.PSCPLNDV_DES)
        objParam.Add("PSCCLNT", obeIncidencias.PSCCLNT1)
        objParam.Add("PSFRGTRO", obeIncidencias.PSFRGTRO1)
        objParam.Add("PNANIO", obeIncidencias.ANIO)

        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PSCRGVTA", obeIncidencias.PSCRGVTA)
        objParam.Add("PSSORINC", obeIncidencias.PSSORINC)

        DT = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_MES", objParam)

        DT.Columns.Add("FRGTRO1", Type.GetType("System.String"))
        For Each Item As DataRow In DT.Rows
            Item("FRGTRO1") = HelpClass.FechaNum_a_Fecha(Item("FRGTRO"))
        Next
        DT.Columns.Remove("FRGTRO")
        DT.Columns.Add("FRGTRO", Type.GetType("System.String"))

        For Each Item As DataRow In DT.Rows
            Item("FRGTRO") = Item("FRGTRO1")
        Next
        DT.Columns.Remove("FRGTRO1")

        DS.Tables.Add(DT)
        Return DS

    End Function

    Public Function dtRegistroIncidenciasPorFecha(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
        objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
        objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)

        Return Listar("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_FECHA", objParam)

    End Function

    Public Function dsLista_Nivel_y_Reportado() As DataSet

        Dim ds As New DataSet
        Dim objParam As New Parameter

        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_NIVELES_Y_REPORTADOS", objParam)

        Return ds

    End Function

    Public Function olistListarMaestroIncidencias_v2(ByVal obeIncidencias As beIncidencias) As DataSet

        Dim ds As New DataSet

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
        objParam.Add("PSCARINC", obeIncidencias.PSCARINC)
        objParam.Add("PNCTPINC", obeIncidencias.PNCTPINC)
        objParam.Add("PNANIO", obeIncidencias.ANIO)

        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_LIST_V3", objParam)

        Return ds

    End Function

    Public Function Lista_Incidencia_Estados() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter

        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_ESTADOS_INCIDENCIA", objParam)

        Return dt

    End Function

    Public Function Lista_Inc_Para() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PNCTPINC", 0)
        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_INCIDENCIA_PARA", objParam)
        Return dt

    End Function
    'BEGIN: JDT-Almacén Repuestos On Side - Piura[RF003]-190516
    Public Function Lista_Proceso() As DataTable

        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOMIN_SC_LISTA_PROCESOS_INCIDENCIAS", Nothing)
        Return dt
    End Function

    Public Function Lista_TipoDocRef(ByVal objBE As beIncidencias) As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", objBE.PSSTIPPR)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TIPO_DOC_REF", objParam)
        Return dt
    End Function
    'END: JDT-Almacén Repuestos On Side - Piura[RF003]-190516

    Public Function Lista_Inc_Negocio(ByVal objBE As beIncidencias) As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", objBE.PSCCMPN)
        objParam.Add("PNCTPINC", "0")
        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_INCIDENCIA_NEGOCIO", objParam)

        Return dt

    End Function

    Public Function Lista_Areas() As DataTable

        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_AREAS", Nothing)

        Return dt

    End Function

    Public Function olisListarResponsables(ByVal oResponsable As beDestinatario) As List(Of beDestinatario)
        Dim oDt As New DataTable
        Dim olbeDestinatario As New List(Of beDestinatario)
        Dim objDestinatario As beDestinatario
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", oResponsable.PNCCLNT)
        objParam.Add("PSTIPPROC", oResponsable.PSTIPPROC)

        oDt = objSql.ExecuteDataTable("SP_SOLSC_LISTAR_RESPONSABLES_INCIDENCIA", objParam)

        For Each fila As DataRow In oDt.Rows
            objDestinatario = New beDestinatario

            objDestinatario.PSTIPPROC = fila("TIPPROC")
            objDestinatario.PSNLTECL = fila("NLTECL")
            objDestinatario.PSTNMYAP = fila("TNMYAP").ToString.Trim
            objDestinatario.PSEMAILTO = fila("EMAILTO").ToString.Trim
            objDestinatario.PSNCRRIT = fila("NCRRIT")
            olbeDestinatario.Add(objDestinatario)
        Next

        Return olbeDestinatario

    End Function



    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As beIncidencias)

    End Sub
End Class
