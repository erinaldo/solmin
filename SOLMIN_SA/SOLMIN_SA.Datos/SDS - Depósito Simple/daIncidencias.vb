Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class daIncidencias
    Inherits daBase(Of beIncidencias)

    Private objSql As New SqlManager


    Public Function intInsertarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSTINCSI", obeIncidencias.PSTINCSI)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function intActualizarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
            objParam.Add("PSTINCSI", obeIncidencias.PSTINCSI)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
            objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_UPDATE", objParam)

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function intEliminarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Try

            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
            objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
            objParam.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_DELETE", objParam)

            Return objSql.ParameterCollection("PSRESULT")

        Catch ex As Exception

        End Try
    End Function


    'Public Function olistListarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
    '    Dim oDt As New DataTable
    '    Dim olbebeIncidencias As New List(Of beIncidencias)
    '    Dim objParam As New Parameter
    '    Try
    '        objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
    '        objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)

    '        Return Listar("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_LIST", objParam)
    '    Catch ex As Exception
    '        obeIncidencias.PSERROR = ex.Message
    '    End Try
    '    Return olbebeIncidencias
    'End Function


    Public Function olistListarMaestroIncidencias(ByVal obeIncidencias As beIncidencias) As DataSet
        Dim ds As New DataSet
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PNANIO", obeIncidencias.ANIO)
            ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_MAESTRO_INCIDENCIAS_LIST", objParam)
        Catch ex As Exception
            obeIncidencias.PSERROR = ex.Message
        End Try
        Return ds
    End Function


    Public Function intInsertarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PNFRGTRO", obeIncidencias.PNFRGTRO)
            objParam.Add("PNHRGTRO", obeIncidencias.PNHRGTRO)
            objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
            objParam.Add("PSTINCDT", obeIncidencias.PSTINCDT)
            objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM)
            objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
            objParam.Add("PSCZNALM", obeIncidencias.PSCZNALM)
            objParam.Add("PNCPRVCL", obeIncidencias.PNCPRVCL)
            objParam.Add("PNCPLCLP", obeIncidencias.PNCPLCLP)
            objParam.Add("PNQAINSM", obeIncidencias.PNQAINSM)
            objParam.Add("PSCUNDCN", obeIncidencias.PSCUNDCN)
            objParam.Add("PNICSTOS", obeIncidencias.PNICSTOS)
            objParam.Add("PNCDMNDA", obeIncidencias.PNCDMNDA)
            objParam.Add("PSTIRALC", obeIncidencias.PSTIRALC)
            objParam.Add("PSPRSCNT", obeIncidencias.PSPRSCNT)
            objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function intActualizarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PNNINCSI", obeIncidencias.PNNINCSI)
            objParam.Add("PNFRGTRO", obeIncidencias.PNFRGTRO)
            objParam.Add("PNHRGTRO", obeIncidencias.PNHRGTRO)
            objParam.Add("PNCINCID", obeIncidencias.PNCINCID)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
            objParam.Add("PSTINCDT", obeIncidencias.PSTINCDT)
            objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM)
            objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
            objParam.Add("PSCZNALM", obeIncidencias.PSCZNALM)
            objParam.Add("PNCPRVCL", obeIncidencias.PNCPRVCL)
            objParam.Add("PNCPLCLP", obeIncidencias.PNCPLCLP)
            objParam.Add("PNQAINSM", obeIncidencias.PNQAINSM)
            objParam.Add("PSCUNDCN", obeIncidencias.PSCUNDCN)
            objParam.Add("PNICSTOS", obeIncidencias.PNICSTOS)
            objParam.Add("PNCDMNDA", obeIncidencias.PNCDMNDA)
            objParam.Add("PSTIRALC", obeIncidencias.PSTIRALC)
            objParam.Add("PSPRSCNT", obeIncidencias.PSPRSCNT)
            objParam.Add("PSSESTRG", obeIncidencias.PSSESTRG)
            objParam.Add("PSUSUARIO", obeIncidencias.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeIncidencias.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function olisListarRegistroIncidencias(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
            objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
            objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)
            objParam.Add("PSCALMC", obeIncidencias.PSCALMC)

            Return Listar("SP_SOLMIN_SA_REGISTRO_INCIDENCIAS_LIST", objParam)
        Catch ex As Exception
            obeIncidencias.PSERROR = ex.Message
        End Try
        Return olbebeIncidencias
    End Function


    Public Function ConsultaIncidenciaPorFecha(ByVal obeIncidencias As beIncidencias) As DataSet
        Dim oDs As New DataSet
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PSCCLNT", obeIncidencias.PSCCLNT1)
            objParam.Add("PSCTPALM", obeIncidencias.PSCTPALM)
            objParam.Add("PSCALMC", obeIncidencias.PSCALMC)
            objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
            objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)

            oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_FECHA", objParam)

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
            Next

            oDs.Tables(0).Columns.Remove("FRGTRO1")
            oDs.Tables(0).Columns.Remove("HRGTRO1")

            Return oDs
        Catch ex As Exception
            obeIncidencias.PSERROR = ex.Message
        End Try
        Return oDs
    End Function

    Public Function ConsultaIncidenciaPorMes(ByVal obeIncidencias As beIncidencias) As DataSet
        Dim DT As New DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim DS As New DataSet
        Try
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PSCCLNT", obeIncidencias.PSCCLNT1)
            objParam.Add("PSFRGTRO", obeIncidencias.PSFRGTRO1)
            objParam.Add("PNANIO", obeIncidencias.ANIO)

            DT = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_MES", objParam)

            DT.Columns.Add("FRGTRO1", Type.GetType("System.String"))
            'DT.Columns.Add("HRGTRO1", Type.GetType("System.String"))

            For Each Item As DataRow In DT.Rows
                Item("FRGTRO1") = HelpClass.FechaNum_a_Fecha(Item("FRGTRO"))
                'Item("HRGTRO1") = HelpClass.HoraNum_a_Hora(Item("HRGTRO"))
            Next
            DT.Columns.Remove("FRGTRO")
            'DT.Columns.Remove("HRGTRO")

            DT.Columns.Add("FRGTRO", Type.GetType("System.String"))
            'DT.Columns.Add("HRGTRO", Type.GetType("System.String"))

            For Each Item As DataRow In DT.Rows
                Item("FRGTRO") = Item("FRGTRO1")
                'Item("HRGTRO") = Item("HRGTRO1")
            Next

            DT.Columns.Remove("FRGTRO1")
            'DT.Columns.Remove("HRGTRO1")

            DS.Tables.Add(DT)

            Return DS
        Catch ex As Exception
            obeIncidencias.PSERROR = ex.Message
        End Try
        Return DS
    End Function


    Public Function dtRegistroIncidenciasPorFecha(ByVal obeIncidencias As beIncidencias) As List(Of beIncidencias)
        Dim oDt As New DataTable
        Dim olbebeIncidencias As New List(Of beIncidencias)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeIncidencias.PSCCMPN)
            objParam.Add("PSCDVSN", obeIncidencias.PSCDVSN)
            objParam.Add("PNCCLNT", obeIncidencias.PNCCLNT)
            objParam.Add("PNFECINI", obeIncidencias.PNFECINI)
            objParam.Add("PNFECFIN", obeIncidencias.PNFECFIN)

            Return Listar("SP_SOLMIN_SA_RPT_REGISTRO_INCIDENCIAS_POR_FECHA", objParam)
        Catch ex As Exception
            obeIncidencias.PSERROR = ex.Message
        End Try
        Return olbebeIncidencias
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beIncidencias)

    End Sub
End Class