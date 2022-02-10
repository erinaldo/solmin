Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class rMercaderia
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    ''' <summary>
    ''' RZOL11 - Catálogo de Mercaderías de Productos por Clientes - Reporte R01
    ''' </summary>
    Public Shared Function frptListar_Mercaderias_R01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Mercaderia_R01, _
                                                      ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CFMCLR", TD_Filtro.pCFMCLR_Familia)
            .Add("IN_CGRCLR", TD_Filtro.pCGRCLR_Grupo)
            .Add("IN_CMRCLR", TD_Filtro.pCMRCLR_Mercaderia)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_MERCADERIA_RZOL11_R01", objParametros)
            dtTemp.TableName = "ucMercaderia_DgF01A"
            oResultado.TableAdd(dtTemp.Copy)
            If strMensajeError = "" Then
                oResultado.pReport = New ucMercaderia_DgF01A
                oResultado.pReport.SetDataSource(dtTemp)
                oResultado.pReport.Refresh()
                oResultado.pReport.SetParameterValue("pUsuario", TD_Filtro.pUsuario)
            End If
        Catch ex As Exception
            oResultado = New TD_Rpt_Resultado
            strMensajeError = "Error producido en la funcion : << frptListar_Mercaderias_R01 >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_MERCADERIA_RZOL11_R01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function

    ''' <summary>
    ''' RZIT05 - Movimiento de Mercaderías de Productos por Clientes - Reporte R01
    ''' </summary>
    Public Shared Function frptListar_MovMercaderias_R03(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_RepMovProductos_R03, _
                                                         ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_FMOVI", TD_Filtro.pFMOVI_FechaMovIniInt)
            .Add("IN_FMOVF", TD_Filtro.pFMOVF_FechaMovFinInt)
            .Add("IN_STPODP", TD_Filtro.pSTPODP_TipoDeposito)
        End With
        Try
            strMensajeError = ""
            Dim dtTemp As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R03", objParametros)
            dtTemp.TableName = "dtMovMercaderias_F03"
            oResultado.TableAdd(dtTemp.Copy)
            'If strMensajeError = "" Then
            '    oResultado.pReport = New ucMovMercaderias_F03
            '    oResultado.pReport.SetDataSource(dtTemp)
            '    oResultado.pReport.Refresh()
            '    oResultado.pReport.SetParameterValue("pUsuario", TD_Filtro.pUsuario)
            '    oResultado.pReport.SetParameterValue("pFechaInicial", TD_Filtro.pFMOVI_FechaMovIniDte)
            '    oResultado.pReport.SetParameterValue("pFechaFinal", TD_Filtro.pFMOVF_FechaMovFinDte)
            'End If
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_R03 >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SDS_SOLIC_SERV_RZIT06_R03 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function

    'TD_Rpt_Mercaderia_R01

    ''' <summary>
    ''' Inventario por Posicion
    ''' </summary>
    Public Shared Function frptListar_Inventario_x_Posicion(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Mercaderia_R01, _
                                                         ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado


        Try
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("PSCTPALM", TD_Filtro.pCTPALM_CodTipoAlmacen)
                .Add("PSCALMC", TD_Filtro.pCALMC_CodAlmacen)
                .Add("PSCZNALM", TD_Filtro.pCZNALM_CodZona)
                .Add("PNORDENACION", TD_Filtro.pORDENACION)
            End With
            strMensajeError = ""
            Dim ds As DataSet = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION", objParametros)
            oResultado.TableAdd(ds.Tables(0).Copy)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_Inventario_x_Posicion >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function


    ''' <summary>
    ''' RZIT05 - Movimiento de Mercaderías de Productos por Centro Costo
    ''' </summary>
    Public Shared Function frptListar_MovMercaderias_x_CentroCosto(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_RepMovProductos_R03, _
                                                         ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
       
      
        Try
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("PNFECINI", HelpClass.CDate_a_Numero8Digitos(TD_Filtro.pFMOVI_FechaMovIniDte))
                .Add("PNFECFIN", HelpClass.CDate_a_Numero8Digitos(TD_Filtro.pFMOVF_FechaMovFinDte))
            End With
            strMensajeError = ""
            Dim ds As DataSet = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTOS_X_CENTRO_COSTO", objParametros)
            oResultado.TableAdd(ds.Tables(0).Copy)
            oResultado.TableAdd(ds.Tables(1).Copy)
            oResultado.TableAdd(ds.Tables(2).Copy)
            oResultado.TableAdd(ds.Tables(3).Copy)

        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_x_CentroCosto >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : frptListar_MovMercaderias_x_CentroCosto >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function

    ''' <summary>
    ''' Funcion que realiza un resumen mensual diario
    ''' </summary>
    Public Shared Function frptListar_Resumen_Indicador_Mensual(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Indicador, _
                                                         ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado

        Dim dt As New DataTable
        Dim Monto As Decimal = 0
        dt.Columns.Add("Item", Type.GetType("System.String"))
        dt.Columns.Add("Total", Type.GetType("System.Decimal"))

        Dim odtSKU As New DataTable
        Dim odtERISKU As New DataTable

        Dim odtUBICACION As New DataTable
        Dim odtERIUBICACION As New DataTable

        Dim odtOCUPACION As New DataTable
        Dim odtNIVELOCUPACION As New DataTable

        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim dr3 As DataRow


        Try
            Dim objParametros As Parameter = New Parameter
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
                .Add("PNMES", TD_Filtro.PNMESEMI)
                .Add("PNMAXDIAS", TD_Filtro.PNMAXDIAS)
            End With
            strMensajeError = ""
            Dim dtResumenGrafico As New DataTable
            Dim dtDatos As DataTable = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT", objParametros)
            oResultado.TableAdd(dtDatos)

            dtResumenGrafico = frptListar_Resumen_Indicador_UnPivot(objSqlManager, TD_Filtro)
            dtResumenGrafico.TableName = "dtGrafico"
            oResultado.TableAdd(dtResumenGrafico)


            Dim odsGraficoResumen As New DataSet
            odsGraficoResumen = frptGraficosResumen(objSqlManager, TD_Filtro)
            odtSKU = odsGraficoResumen.Tables(0).Copy
            odtSKU.TableName = "dtGraficoSKU"
            oResultado.Tables.Add(odtSKU)


            odtERISKU = dt.Clone()
            odtERISKU.TableName = "dtGraficoERISKU"
            If (odtSKU.Select("CTPOIN=11").Length > 0) Then
                dr1 = odtERISKU.NewRow()
                dr1("Item") = "ERI SKU"
                Monto = IIf(odtSKU.Select("CTPOIN=12")(0).Item("QAINSM") = 0, 0, Math.Round((odtSKU.Select("CTPOIN=11")(0).Item("QAINSM") / odtSKU.Select("CTPOIN=12")(0).Item("QAINSM")) * 100, 2))
                dr1("Total") = Monto
                odtERISKU.Rows.Add(dr1)
                odtERISKU.Rows.Add("Total", 100 - Monto)
            End If           
            oResultado.Tables.Add(odtERISKU)
            '--------------------------------------------

            'Ubicacion----------------------------------

            odtUBICACION.TableName = "dtGraficoUbicacion"
            odtUBICACION = odsGraficoResumen.Tables(1).Copy
            oResultado.Tables.Add(odtUBICACION)


            odtERIUBICACION = dt.Clone()
            odtERIUBICACION.TableName = "dtGraficoERIUbicacion"
            If (odtUBICACION.Select("CTPOIN=21").Length > 0) Then
                dr2 = odtERIUBICACION.NewRow()
                dr2("Item") = "ERI UBICACION"
                Monto = IIf(odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM") = 0, 0, Math.Round((odtUBICACION.Select("CTPOIN=21")(0).Item("QAINSM") / odtUBICACION.Select("CTPOIN=22")(0).Item("QAINSM")) * 100, 2))
                dr2("Total") = Monto
                odtERIUBICACION.Rows.Add(dr2)
                odtERIUBICACION.Rows.Add("Total", 100 - Monto)
            End If          
            oResultado.Tables.Add(odtERIUBICACION)

            'Ocupacion-------------------------------------------

            odtOCUPACION = odsGraficoResumen.Tables(2).Copy
            odtOCUPACION.TableName = "dtGraficoOcupacion"
            oResultado.Tables.Add(odtOCUPACION)


            odtNIVELOCUPACION = dt.Clone()
            odtNIVELOCUPACION.TableName = "dtGraficoNivelOcupacion"
            If (odtOCUPACION.Select("CTPOIN=31").Length > 0) Then
                dr3 = odtNIVELOCUPACION.NewRow()
                dr3("Item") = "POSICIONES OCUPADAS"
                Monto = IIf(odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM") = 0, 0, Math.Round((odtOCUPACION.Select("CTPOIN=31")(0).Item("QAINSM") / odtOCUPACION.Select("CTPOIN=32")(0).Item("QAINSM")) * 100, 2))
                dr3("Total") = Monto
                odtNIVELOCUPACION.Rows.Add(dr3)
                odtNIVELOCUPACION.Rows.Add("Total", 100 - Monto)
            End If          
            oResultado.Tables.Add(odtNIVELOCUPACION)


        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_Resumen_Indicador_Mensual >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function
    Private Shared Function frptGraficosResumen(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Indicador) As DataSet
        Dim objParametros As Parameter = New Parameter
        Dim ods As New DataSet
        With objParametros
            .Add("PNCCLNT", TD_Filtro.PNCCLNT)
            .Add("PSCCMPN", TD_Filtro.PSCCMPN)
            .Add("PSCDVSN", TD_Filtro.PSCDVSN)
            .Add("PNANIO", TD_Filtro.PNANIOEMI)
            .Add("PNMES", TD_Filtro.PNMESEMI)
        End With
        ods = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_PIVOT_RPT_GRAFICO", objParametros)
        Return ods
    End Function

    ''' <summary>
    ''' Funcion que realiza un resumen mensual diario
    ''' </summary>
    Private Shared Function frptListar_Resumen_Indicador_UnPivot(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Indicador _
                                                         ) As DataTable
        Dim odt As New DataTable

        Try
            Dim objParametros As Parameter = New Parameter
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
                .Add("PNMES", TD_Filtro.PNMESEMI)
            End With
            odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_DIARIOS_UNPIVOT", objParametros)
        Catch ex As Exception

        End Try
        Return odt
    End Function

    Private Shared Function FormatoNombreColumnaMes(ByVal numeroMes As Int32) As String
        Dim retorno As String = "MES"
        Dim strDia As String = ""
        strDia = numeroMes.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function
    Public Shared Function frptListar_Resumen_Anual(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Indicador, _
                                                           ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
        Dim odt As New DataTable
        Dim MaxMes As Int32 = 12
        Dim nomColumnaMes As String = ""
        Dim CTPOIN As Int32 = 0
        Dim FLAG_PORCENTUAL As Boolean = False
        Dim TOTAL As String = ""
        Try
            odt = frptListar_Resumen_Anual_Pivot(objSqlManager, TD_Filtro)
            For Each dr As DataRow In odt.Rows
                CTPOIN = HelpClass.ObjectToInt32(dr.Item("CTPOIN"))
                FLAG_PORCENTUAL = False
                Select Case CTPOIN
                    Case 10 Or 20 Or 30
                        FLAG_PORCENTUAL = True
                    Case 11, 12, 21, 22
                        dr.Item("TTPOIN") = "    " & HelpClass.ObjectToString(dr.Item("TTPOIN"))
                        FLAG_PORCENTUAL = False
                    Case Else
                        FLAG_PORCENTUAL = False
                End Select

                If (FLAG_PORCENTUAL = True) Then
                    For index As Integer = 1 To 12
                        nomColumnaMes = FormatoNombreColumnaMes(index)
                        If (dr.Item(nomColumnaMes) IsNot Nothing And dr.Item(nomColumnaMes) IsNot DBNull.Value) Then
                            dr.Item(nomColumnaMes) = dr.Item(nomColumnaMes) & "%"
                        End If
                    Next
                End If
            Next
            oResultado.TableAdd(odt.Copy)
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_Resumen_Indicador_Anual>> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_LISTA_INDICADORES_ANUAL_PIVOT >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function

    Private Shared Function frptListar_Resumen_Anual_Pivot(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_Indicador _
                                                        ) As DataTable
        Dim dt As New DataTable


        Try
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("PNCCLNT", TD_Filtro.PNCCLNT)
                .Add("PSCCMPN", TD_Filtro.PSCCMPN)
                .Add("PSCDVSN", TD_Filtro.PSCDVSN)
                .Add("PNANIO", TD_Filtro.PNANIOEMI)
            End With
            dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INDICADORES_ANUAL_PIVOT", objParametros)
        Catch ex As Exception
        End Try
        Return dt
    End Function





    ''' <summary>
    ''' RZIT05 - Movimiento de Mercaderías de Productos por Centro Costo
    ''' </summary>
    Public Shared Function frptListar_MovMercaderias_x_LugarEntrega(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_Rpt_RepMovProductos_R03, _
                                                         ByRef strMensajeError As String) As TD_Rpt_Resultado
        Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado


        Try
            Dim objParametros As Parameter = New Parameter
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("PNCCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("PNFECINI", HelpClass.CDate_a_Numero8Digitos(TD_Filtro.pFMOVI_FechaMovIniDte))
                .Add("PNFECFIN", HelpClass.CDate_a_Numero8Digitos(TD_Filtro.pFMOVF_FechaMovFinDte))
            End With
            strMensajeError = ""
            Dim ds As DataSet = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTO_DESPACHO", objParametros)
            oResultado.TableAdd(ds.Tables(0).Copy)
            oResultado.TableAdd(ds.Tables(1).Copy)

        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << frptListar_MovMercaderias_x_lugarEntrega >> de la clase << rMercaderia >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SDS_REPORTE_MOVIMIENTO_DESPACHO >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return oResultado
    End Function


#End Region
End Class
