Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class daSeguimiento
    Inherits daBase(Of beSeguimiento)
    Private objSql As New SqlManager


    Public Function intInsertarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSTINCSI", obeSeguimiento.PSTINCSI)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_INSERT", objParam)
        Return objSql.ParameterCollection("PSRESULT")
    End Function

    Public Sub intInsertarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_INSERT", objParam)

    End Sub

    Public Sub intActualizarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSTINCSI", obeSeguimiento.PSTINCSI)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PSSESTRG", obeSeguimiento.PSSESTRG)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_UPDATE", objParam)

    End Sub

    Public Function intEliminarMaestroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PSSESTRG", obeSeguimiento.PSSESTRG)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)
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

    Public Function olistListarMaestroIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As DataSet
        Dim ds As New DataSet
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNANIO", obeSeguimiento.ANIO)
        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_CLIENTE_LIST", objParam)
        Return ds
    End Function

    Public Function olistListarMaestroIncidenciasClientePerfil(ByVal obeSeguimiento As beSeguimiento) As DataSet
        Dim ds As New DataSet
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNANIO", obeSeguimiento.ANIO)
        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_CLIENTE_LIST_PERFIL", objParam)
        Return ds
    End Function

    Public Function intInsertarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNFRGTRO", obeSeguimiento.PNFRGTRO)
        objParam.Add("PNHRGTRO", obeSeguimiento.PNHRGTRO)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCPLNDV", obeSeguimiento.PNCPLNDV)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PSTINCDT", obeSeguimiento.PSTINCDT)
        objParam.Add("PSTRDCCL", obeSeguimiento.PSTRDCCL)
        objParam.Add("PSCTPALM", obeSeguimiento.PSCTPALM)
        objParam.Add("PSCALMC", obeSeguimiento.PSCALMC)
        objParam.Add("PSCZNALM", obeSeguimiento.PSCZNALM)
        objParam.Add("PNCPRVCL", obeSeguimiento.PNCPRVCL)
        objParam.Add("PNCPLCLP", obeSeguimiento.PNCPLCLP)
        objParam.Add("PNQAINSM", obeSeguimiento.PNQAINSM)
        objParam.Add("PSCUNDCN", obeSeguimiento.PSCUNDCN)
        objParam.Add("PNICSTOS", obeSeguimiento.PNICSTOS)
        objParam.Add("PNCDMNDA", obeSeguimiento.PNCDMNDA)
        objParam.Add("PSTIRALC", obeSeguimiento.PSTIRALC)
        objParam.Add("PSPRSCNT", obeSeguimiento.PSPRSCNT)
        objParam.Add("PSSNVINC", obeSeguimiento.PSSNVINC)
        objParam.Add("PSSORINC", obeSeguimiento.PSSORINC)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_INSERT", objParam)
        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Sub intActualizarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN.Trim)
        objParam.Add("PNNINCSI", obeSeguimiento.PNNINCSI)
        objParam.Add("PNFRGTRO", obeSeguimiento.PNFRGTRO)
        objParam.Add("PNHRGTRO", obeSeguimiento.PNHRGTRO)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN.Trim)
        objParam.Add("PNCPLNDV", obeSeguimiento.PNCPLNDV)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PSTINCDT", obeSeguimiento.PSTINCDT.Trim)
        objParam.Add("PSTRDCCL", obeSeguimiento.PSTRDCCL.Trim)
        objParam.Add("PSCTPALM", obeSeguimiento.PSCTPALM.Trim)
        objParam.Add("PSCALMC", obeSeguimiento.PSCALMC.Trim)
        objParam.Add("PSCZNALM", obeSeguimiento.PSCZNALM.Trim)
        objParam.Add("PNCPRVCL", obeSeguimiento.PNCPRVCL)
        objParam.Add("PNCPLCLP", obeSeguimiento.PNCPLCLP)
        objParam.Add("PNQAINSM", obeSeguimiento.PNQAINSM)
        objParam.Add("PSCUNDCN", obeSeguimiento.PSCUNDCN.Trim)
        objParam.Add("PNICSTOS", obeSeguimiento.PNICSTOS)
        objParam.Add("PNCDMNDA", obeSeguimiento.PNCDMNDA)
        objParam.Add("PSTIRALC", obeSeguimiento.PSTIRALC.Trim)
        objParam.Add("PSPRSCNT", obeSeguimiento.PSPRSCNT.Trim)
        objParam.Add("PSSESTRG", obeSeguimiento.PSSESTRG)
        objParam.Add("PSSNVINC", obeSeguimiento.PSSNVINC)
        objParam.Add("PSSORINC", obeSeguimiento.PSSORINC)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_UPDATE", objParam)

    End Sub

    Public Sub intEliminarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNNINCSI", obeSeguimiento.PNNINCSI)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_ELIMINAR", objParam)

    End Sub

    Public Function intEliminarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As Integer

        Dim objParam As New Parameter
        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", obeSeguimiento.PSNTRMNL)
        objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_DELETE", objParam)
        Return objSql.ParameterCollection("PSRESULT")

    End Function

    Public Function olisListarRegistroIncidencias(ByVal obeSeguimiento As beSeguimiento, ByVal PLANTAS As String) As List(Of beSeguimiento)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beSeguimiento)
        Dim Lista2 As New List(Of beSeguimiento)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCARINC", obeSeguimiento.PSCARINC)
        objParam.Add("PSCPLNDV", PLANTAS)
        objParam.Add("PNNINCSI", obeSeguimiento.PNNINCSI)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNFECINI", obeSeguimiento.PNFECINI)
        objParam.Add("PNFECFIN", obeSeguimiento.PNFECFIN)
        objParam.Add("PSCALMC", obeSeguimiento.PSCALMC)
        objParam.Add("PSSESINC", obeSeguimiento.PSSESINC)
        objParam.Add("PSCUSEVI", obeSeguimiento.PSUSUARIO)

        objParam.Add("PNCTPINC", obeSeguimiento.PNCTPINC)
        objParam.Add("PSCRGVTA", obeSeguimiento.PSCRGVTA)
        objParam.Add("PSSORINC", obeSeguimiento.PSSORINC)

        olbebeIncidencias = Listar("SP_SOLMIN_SC_SEGUIMIENTO_INCIDENCIAS_LIST_V1", objParam)

        For Each inc As beSeguimiento In olbebeIncidencias

            If inc.PNHRACRT = 0 Then
                inc.PSCUSCRT = inc.PSCUSCRT.ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFCHCRT) & " - "
            Else
                inc.PSCUSCRT = inc.PSCUSCRT.ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFCHCRT) & " - " & HelpClass.HoraNum_a_Hora(inc.PNHRACRT)
            End If
            If inc.PNHULTAC = 0 Then
                inc.PSCULUSA = inc.PSCULUSA.ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFULTAC) & " - "
            Else
                inc.PSCULUSA = inc.PSCULUSA.ToString.Trim & " - " & HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFULTAC) & " - " & HelpClass.HoraNum_a_Hora(inc.PNHULTAC)
            End If

            If inc.PSCUSCRT.ToString.Trim.Length = 4 Then
                inc.PSCUSCRT = ""
            End If
            If inc.PSCULUSA.ToString.Trim.Length = 4 Then
                inc.PSCULUSA = ""
            End If

            inc.PSFCHREVISION = HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFCHRVI).ToString
            If inc.PNHRARVI > 0D Then
                inc.PSHRAREVISION = HelpClass.HoraNum_a_Hora(inc.PNHRARVI).ToString
            Else
                inc.PSHRAREVISION = ""
            End If
            inc.PSFCHCONCLUIDO = HelpClass.CNumero8Digitos_a_FechaDefault(inc.PNFCHTRI)
            If inc.PNHRATRI > 0D Then
                inc.PSHRACONCLUIDO = HelpClass.HoraNum_a_Hora(inc.PNHRATRI).ToString
            Else
                inc.PSHRACONCLUIDO = ""
            End If

            If inc.PSFCHREVISION.ToString <> "" And inc.FechaRegistro.ToString <> "" Then

                inc.PNFCH_2_1 = DateDiff(DateInterval.Day, CDate(inc.FechaRegistro.ToString), CDate(inc.PSFCHREVISION.ToString)).ToString
            Else
                inc.PNFCH_2_1 = ""
            End If

            If inc.PSFCHCONCLUIDO.ToString <> "" And inc.PSFCHREVISION.ToString <> "" Then
                inc.PNFCH_3_2 = DateDiff(DateInterval.Day, CDate(inc.PSFCHREVISION.ToString), CDate(inc.PSFCHCONCLUIDO.ToString)).ToString
            Else
                inc.PNFCH_3_2 = ""
            End If

            Lista2.Add(inc)
        Next

        Return lista2

    End Function

    Public Function olisListarRegistroIncidenciasVista(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beSeguimiento)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNCINCID", obeSeguimiento.PNCINCID)
        objParam.Add("PNFECINI", obeSeguimiento.PNFECINI)
        objParam.Add("PNFECFIN", obeSeguimiento.PNFECFIN)
        objParam.Add("PSCALMC", obeSeguimiento.PSCALMC)

        Return Listar("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_LIST_VISTA_V2", objParam)

    End Function

    Public Function olisListarTipoIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        Return Listar("SP_SOLMIN_SA_TIPO_INCIDENCIAS_CLIENTE_LIST", objParam)

    End Function

    Public Function ListarIncidenciasCliente(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)

        Return Listar("SP_SOLMIN_SA_INCIDENCIAS_CLIENTE_LIST", objParam)

    End Function

    Public Function ConsultaIncidenciaPorFecha(ByVal obeSeguimiento As beSeguimiento) As DataSet

        Dim oDs As New DataSet
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PSCPLNDV", obeSeguimiento.PSCPLNDV_DES)
        objParam.Add("PSCCLNT", obeSeguimiento.PSCCLNT1)
        objParam.Add("PSCTPALM", obeSeguimiento.PSCTPALM)
        objParam.Add("PSCALMC", obeSeguimiento.PSCALMC)
        objParam.Add("PNFECINI", obeSeguimiento.PNFECINI)
        objParam.Add("PNFECFIN", obeSeguimiento.PNFECFIN)

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

    Public Function ConsultaIncidenciaPorMes(ByVal obeSeguimiento As beSeguimiento) As DataSet
        Dim DT As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim DS As New DataSet

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PSCPLNDV", obeSeguimiento.PSCPLNDV_DES)
        objParam.Add("PSCCLNT", obeSeguimiento.PSCCLNT1)
        objParam.Add("PSFRGTRO", obeSeguimiento.PSFRGTRO1)
        objParam.Add("PNANIO", obeSeguimiento.ANIO)

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

    Public Function dtRegistroIncidenciasPorFecha(ByVal obeSeguimiento As beSeguimiento) As List(Of beSeguimiento)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNCCLNT", obeSeguimiento.PNCCLNT)
        objParam.Add("PNFECINI", obeSeguimiento.PNFECINI)
        objParam.Add("PNFECFIN", obeSeguimiento.PNFECFIN)

        Return Listar("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_FECHA", objParam)

    End Function

    Public Function dsLista_Nivel_y_Reportado() As DataSet

        Dim ds As New DataSet
        Dim objParam As New Parameter

        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_NIVELES_Y_REPORTADOS", objParam)

        Return ds

    End Function

    Public Function olistListarMaestroIncidencias_v2(ByVal obeSeguimiento As beSeguimiento) As DataSet

        Dim ds As New DataSet

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCDVSN", obeSeguimiento.PSCDVSN)
        objParam.Add("PNANIO", obeSeguimiento.ANIO)

        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_LIST_V2", objParam)

        Return ds

    End Function

    Public Function Lista_Incidencia_Estados() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter

        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_ESTADOS_INCIDENCIA", objParam)

        Return dt

    End Function

    Public Function Consulta_Estado_Actual_Seguimiento(ByVal NINCSI As Decimal) As String

        Dim Estado As String = ""

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", NINCSI)

        Estado = objSql.ExecuteScalar("SP_SOLMIN_SC_CONSULTA_ESTADO_ACTUAL_SEGUIMIENTO", objParam)

        Return Estado

    End Function


    Public Function Lista_Tipo_Solucion() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter

        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_TIPOS_SOLUCION", objParam)

        Return dt

    End Function

    Public Function Lista_Seguimiento_Asumidos() As DataTable

        Dim dt As New DataTable
        Dim objParam As New Parameter

        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_SUMIDOS", objParam)

        Return dt

    End Function


    Public Sub intActualizarSeguimiento_Revision(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter
        Dim codigo As Decimal = 0
        objParam.Add("PNNINCSI", obeSeguimiento.PNNINCSI)
        objParam.Add("PSSTPSLC", obeSeguimiento.PSSTPSLC)

        objParam.Add("PSSACPINC", obeSeguimiento.PSSACPINC)
        objParam.Add("PSSACCINC", obeSeguimiento.PSSACCINC)
        objParam.Add("PSSCLINC", obeSeguimiento.PSSCLINC)

        objParam.Add("PNFCHRVI", obeSeguimiento.PNFCHRVI)
        objParam.Add("PNHRARVI", obeSeguimiento.PNHRARVI)
        objParam.Add("PSCUSEVI", obeSeguimiento.PSCUSEVI)
        objParam.Add("PSTOBRES", obeSeguimiento.PSTOBRES)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", Environment.MachineName)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SEGUIMIENTO_REVISION_UPDATE", objParam)


    End Sub

    Public Sub intActualizarSeguimiento_Concluido(ByVal obeSeguimiento As beSeguimiento)

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", obeSeguimiento.PNNINCSI)
        objParam.Add("PSCDASCI", obeSeguimiento.PSCDASCI)
        objParam.Add("PNPRCASC", obeSeguimiento.PNPRCASC)
        objParam.Add("PNICSTOS", obeSeguimiento.PNICSTOS)
        objParam.Add("PNCDMNDA", obeSeguimiento.PNCDMNDA)
        objParam.Add("PNFCHTRI", obeSeguimiento.PNFCHTRI)
        objParam.Add("PNHRATRI", obeSeguimiento.PNHRATRI)
        objParam.Add("PSUSUARIO", obeSeguimiento.PSUSUARIO)
        objParam.Add("PSNTRMNL", Environment.MachineName)
        objParam.Add("PSTOBRES2", obeSeguimiento.PSTOBRES2)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SEGUIMIENTO_CONCLUIDO_UPDATE", objParam)

    End Sub

    Public Sub intGuardarImagenSeguimiento(ByVal NINCSI As Decimal, ByVal NMRGIA As Decimal, ByVal usuario As String, ByVal NTRMNL As String)

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", NINCSI)
        objParam.Add("PNNMRGIA", NMRGIA)
        objParam.Add("PSUSUARIO", usuario)
        objParam.Add("PSNTRMNL", NTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_GUARDAR_IMAGEN_SEGUIMIENTO", objParam)

    End Sub

    Public Sub intEliminarImagenSeguimiento(ByVal NINCSI As Decimal, ByVal NMRGIA As Decimal, ByVal usuario As String, ByVal NTRMNL As String)

        Dim objParam As New Parameter

        objParam.Add("PNNINCSI", NINCSI)
        objParam.Add("PNNMRGIA", 0D)
        objParam.Add("PSUSUARIO", usuario)
        objParam.Add("PSNTRMNL", NTRMNL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_GUARDAR_IMAGEN_SEGUIMIENTO", objParam)

    End Sub

    Public Function ConsultaSeguimientoPorFecha(ByVal obeSeguimiento As beSeguimiento) As DataSet

        Dim oDs As New DataSet
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeSeguimiento.PSCCMPN)
        objParam.Add("PSCARINC", obeSeguimiento.PSCARINC)
        objParam.Add("PSCPLNDV", obeSeguimiento.PSCPLNDV_DES)
        objParam.Add("PSCCLNT", obeSeguimiento.PSCCLNT1)
        objParam.Add("PSSESINC", obeSeguimiento.PSSESINC)
        objParam.Add("PNFECINI", obeSeguimiento.PNFECINI)
        objParam.Add("PNFECFIN", obeSeguimiento.PNFECFIN)

        objParam.Add("PNCTPINC", obeSeguimiento.PNCTPINC)
        objParam.Add("PSCRGVTA", obeSeguimiento.PSCRGVTA)
        objParam.Add("PSSORINC", obeSeguimiento.PSSORINC)

        oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_SC_RPT_SEGUIMIENTO_POR_FECHA", objParam)

        oDs.Tables(0).Columns.Add("FRGTRO1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRGTRO1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("FCHRVI1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("FCHTRI1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRARVI1", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRATRI1", Type.GetType("System.String"))

        For Each Item As DataRow In oDs.Tables(0).Rows
            Item("FRGTRO1") = HelpClass.FechaNum_a_Fecha(Item("FRGTRO"))
            Item("HRGTRO1") = IIf(HelpClass.HoraNum_a_Hora(Item("HRGTRO")) = "00:00:00", "", HelpClass.HoraNum_a_Hora(Item("HRGTRO")))
            Item("FCHRVI1") = HelpClass.FechaNum_a_Fecha(Item("FCHRVI"))
            Item("FCHTRI1") = HelpClass.FechaNum_a_Fecha(Item("FCHTRI"))
            Item("HRARVI1") = IIf(HelpClass.HoraNum_a_Hora(Item("HRARVI")) = "00:00:00", "", HelpClass.HoraNum_a_Hora(Item("HRARVI")))
            Item("HRATRI1") = IIf(HelpClass.HoraNum_a_Hora(Item("HRATRI")) = "00:00:00", "", HelpClass.HoraNum_a_Hora(Item("HRATRI")))


        Next
        oDs.Tables(0).Columns.Remove("FRGTRO")
        oDs.Tables(0).Columns.Remove("HRGTRO")
        oDs.Tables(0).Columns.Remove("FCHRVI")
        oDs.Tables(0).Columns.Remove("FCHTRI")
        oDs.Tables(0).Columns.Remove("HRARVI")
        oDs.Tables(0).Columns.Remove("HRATRI")

        oDs.Tables(0).Columns.Add("FRGTRO", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRGTRO", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("FCHRVI", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("FCHTRI", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRARVI", Type.GetType("System.String"))
        oDs.Tables(0).Columns.Add("HRATRI", Type.GetType("System.String"))


        For Each Item As DataRow In oDs.Tables(0).Rows
            Item("FRGTRO") = Item("FRGTRO1")
            Item("HRGTRO") = Item("HRGTRO1")
            Item("FCHRVI") = Item("FCHRVI1")
            Item("FCHTRI") = Item("FCHTRI1")
            Item("HRARVI") = Item("HRARVI1")
            Item("HRATRI") = Item("HRATRI1")

        Next
        oDs.Tables(0).Columns.Remove("FCHRVI1")
        oDs.Tables(0).Columns.Remove("FCHTRI1")
        oDs.Tables(0).Columns.Remove("FRGTRO1")
        oDs.Tables(0).Columns.Remove("HRGTRO1")
        oDs.Tables(0).Columns.Remove("HRARVI1")
        oDs.Tables(0).Columns.Remove("HRATRI1")

        Return oDs

    End Function


    Public Function Lista_Efectos() As DataTable

        Dim dt As New DataTable

        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_EFECTOS", Nothing)

        Return dt

    End Function

    Public Function Lista_Accion() As DataTable

        Dim dt As New DataTable

        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_ACCION", Nothing)

        Return dt

    End Function

    Public Function Lista_Clasificacion() As DataTable

        Dim dt As New DataTable

        dt = objSql.ExecuteDataTable("SP_SOLSC_LISTA_CLASIFICACION", Nothing)

        Return dt

    End Function


    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As beSeguimiento)

    End Sub
End Class

