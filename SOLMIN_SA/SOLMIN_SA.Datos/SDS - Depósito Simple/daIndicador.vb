Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class daIndicador
    Inherits daBase(Of beIndicador)

    Private objSql As New SqlManager

    Public Function CalcularListarIndicadorDiarioMensual(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            objParam.Add("PNMES", obeIndicador.PNMESEMI)
            objParam.Add("PNMAXDIAS", obeIndicador.PNMAXDIAS)
            objParam.Add("PSFILTRO_CTPOIN", obeIndicador.PSFILTRO_CTPOIN)
            ods = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_CALCULAR_LISTAR_INDICADORES", objParam)
        Catch ex As Exception
            ods = Nothing
        End Try
        Return ods
    End Function
    Public Function ActualizarResumenIndicadorMensual(ByVal obeIndicador As beIndicador, ByVal MaxDias As Int32) As Int32
        Dim retorno As Int32 = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PNANIOEMI", obeIndicador.PNANIOEMI)
            objParam.Add("PNMESEMI", obeIndicador.PNMESEMI)
            objParam.Add("PNDDEMI", obeIndicador.PNDDEMI)
            objParam.Add("PNCTPOIN", obeIndicador.PNCTPOIN)
            objParam.Add("PNQAINSM", obeIndicador.PNQAINSM)
            objParam.Add("PNNTRMNL", obeIndicador.PSNTRMNL)
            objParam.Add("PSCULUSA", obeIndicador.PSCULUSA)
            objParam.Add("PNMAXDIAS", MaxDias)
            objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_ACTUALIZAR_RESUMEN_INDICADORES_X_CLIENTE", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function

    Public Function ActualizarResumenIndicadorMensual2(ByVal obeIndicador As beIndicador, ByVal MaxDias As Int32) As Int32
        Dim retorno As Int32 = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PNANIOEMI", obeIndicador.PNANIOEMI)
            objParam.Add("PNMESEMI", obeIndicador.PNMESEMI)
            objParam.Add("PNDDEMI", obeIndicador.PNDDEMI)
            objParam.Add("PNCTPOIN", obeIndicador.PNCTPOIN)
            objParam.Add("PNQAINSM", obeIndicador.PNQAINSM)
            objParam.Add("PNNTRMNL", obeIndicador.PSNTRMNL)
            objParam.Add("PSCULUSA", obeIndicador.PSCULUSA)
            objParam.Add("PNMAXDIAS", MaxDias)
            objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_ACTUALIZAR_RESUMEN_INDICADORES_X_CLIENTE2", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function
    Public Function ListarTipoIndicador() As DataTable
        Dim ods As New DataTable
        Try
            Dim objParam As New Parameter
            ods = objSql.ExecuteDataTable("SP_SOLMIN_SA_TIPO_INDICADOR", Nothing)
        Catch ex As Exception
            ods = Nothing
        End Try
        Return ods
    End Function

    Public Function Listar_Indicadores_x_Tipo(ByVal Tipo As String) As DataTable
        Dim ods As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_TTPOIN", Tipo)
            ods = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_INDICADORES_X_TIPO", objParam)
        Catch ex As Exception
            ods = Nothing
        End Try
        Return ods

    End Function
    Public Function ActualizarDatosIndicador(ByVal obeIndicador As beIndicador) As Int32
        Dim retorno As Int32 = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PNANIOEMI", obeIndicador.PNANIOEMI)
            objParam.Add("PNMESEMI", obeIndicador.PNMESEMI)
            objParam.Add("PNDDEMI", obeIndicador.PNDDEMI)
            objParam.Add("PNCTPOIN", obeIndicador.PNCTPOIN)
            objParam.Add("PSTOBACT", obeIndicador.PSTOBACT)
            objParam.Add("PNNTRMNL", obeIndicador.PSNTRMNL)
            objParam.Add("PSCULUSA", obeIndicador.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ACTUALIZAR_DATOS_INDICADOR", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function

    Public Function ListarDatosIndicador(ByVal obeIndicador As beIndicador) As beIndicador
        Dim odt As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PNANIOEMI", obeIndicador.PNANIOEMI)
            objParam.Add("PNMESEMI", obeIndicador.PNMESEMI)
            objParam.Add("PNDDEMI", obeIndicador.PNDDEMI)
            objParam.Add("PNCTPOIN", obeIndicador.PNCTPOIN)
            odt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTAR_DATOS_INDICADOR", objParam)
            If (odt.Rows.Count > 0) Then
                obeIndicador.PSTOBACT = odt.Rows(0).Item("TOBACT")
                obeIndicador.PSTOBACT = obeIndicador.PSTOBACT.Trim
            End If
        Catch ex As Exception
        End Try
        Return obeIndicador
    End Function


    Public Function ListarIndicadorDiarioMensualPivot(ByVal obeIndicador As beIndicador) As DataSet
        Dim odt As New DataSet()
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            objParam.Add("PNMES", obeIndicador.PNMESEMI)
            objParam.Add("PNMAXDIAS", obeIndicador.PNMAXDIAS)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT", objParam)
        Catch ex As Exception
        End Try
        Return odt
    End Function

    Public Function ListarIndicadorDiarioMensualRpt(ByVal obeIndicador As beIndicador) As DataSet
        Dim odt As New DataSet()
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            objParam.Add("PNMES", obeIndicador.PNMESEMI)
            objParam.Add("PNMAXDIAS", obeIndicador.PNMAXDIAS)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT", objParam)
        Catch ex As Exception
        End Try
        Return odt
    End Function
    Public Function ListarIndicadorDiarioMensualRptGraficos(ByVal obeIndicador As beIndicador) As DataSet
        Dim odt As New DataSet()
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            objParam.Add("PNMES", obeIndicador.PNMESEMI)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT_GRAFICO", objParam)
        Catch ex As Exception
        End Try
        Return odt
    End Function

    Public Function ListarIndicadorDiarioMensualUnPivot(ByVal obeIndicador As beIndicador) As DataSet
        Dim odt As New DataSet()
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            objParam.Add("PNMES", obeIndicador.PNMESEMI)
            Return objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_UNPIVOT", objParam)
        Catch ex As Exception
        End Try
        Return odt
    End Function

    Public Function ListarIndicadorAnual(ByVal obeIndicador As beIndicador) As DataSet
        Dim ods As New DataSet()
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeIndicador.PNCCLNT)
            objParam.Add("PSCCMPN", obeIndicador.PSCCMPN)
            objParam.Add("PSCDVSN", obeIndicador.PSCDVSN)
            objParam.Add("PNANIO", obeIndicador.PNANIOEMI)
            ods = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_ANUAL_PIVOT", objParam)
        Catch ex As Exception
        End Try
        Return ods
    End Function

    Public Function Listar_Tab_Gen_Indicadores() As List(Of beIndicador)
        Dim oListbeIndicador As New List(Of beIndicador)
        Try
            Return Listar(" SP_SOLMIN_SA_LISTA_TAB_GEN_INDICADORES", Nothing)
        Catch ex As Exception
        End Try
        Return oListbeIndicador
    End Function




    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overloads Overrides Sub ToParameters(ByVal obj As TYPEDEF.beIndicador)

    End Sub
End Class
