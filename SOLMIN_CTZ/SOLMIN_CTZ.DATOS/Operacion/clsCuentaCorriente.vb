Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
Public Class clsCuentaCorriente
    Public Function Lista_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV) '****modificado****'
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PFE_INICIO", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PFE_FINAL", pobjCuentaCorriente.FechaFin)
        lobjParams.Add("PSESTADO_SAP", pobjCuentaCorriente.EstadoSap)
        lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
        lobjParams.Add("PSEST_DOC", pobjCuentaCorriente.PSEST_DOC)
        lobjParams.Add("PNCDSGDC", pobjCuentaCorriente.PNCDSGDC)
        lobjParams.Add("PAGESIZE", pobjCuentaCorriente.PageSize)
        lobjParams.Add("PAGENUMBER", pobjCuentaCorriente.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_CUENTACORRIENTE", lobjParams)
        dt.Columns.Add("PageCount")

        If dt.Rows.Count > 0 Then
            dt.Rows(0).Item("PageCount") = lobjSql.ParameterCollection("PAGECOUNT") + 1
        End If
        Return dt
    End Function
    Public Function Lista_CuentaCorriente_Rubro(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV) '****modificado****'
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PFE_INICIO", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PFE_FINAL", pobjCuentaCorriente.FechaFin)
        lobjParams.Add("PSESTADO_SAP", pobjCuentaCorriente.EstadoSap)
        lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
        lobjParams.Add("PSEST_DOC", pobjCuentaCorriente.PSEST_DOC)
        lobjParams.Add("PNCDSGDC", pobjCuentaCorriente.PNCDSGDC)
        lobjParams.Add("PNCRBCTC", pobjCuentaCorriente.CRBCTC)
        lobjParams.Add("PAGESIZE", pobjCuentaCorriente.PageSize)
        lobjParams.Add("PAGENUMBER", pobjCuentaCorriente.PageNumber)
        lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_CUENTACORRIENTE_RUBRO", lobjParams)
        dt.Columns.Add("PageCount")

        If dt.Rows.Count > 0 Then
            dt.Rows(0).Item("PageCount") = lobjSql.ParameterCollection("PAGECOUNT") + 1
        End If
        Return dt
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Periodo(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.PSCPLNDV)
            lobjParams.Add("PNCCLNT", pobjCuentaCorriente.PNCCLNT)
            lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
            lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTA_CORRIENTE_X_CLIENTE", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
        Return dt
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Periodo_Detalle(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.PSCPLNDV)
            lobjParams.Add("PNCCLNT", pobjCuentaCorriente.PNCCLNT)
            lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
            lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTA_CORRIENTE_X_CLIENTE_DETALLE", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
        Return dt
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Anio(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.PSCPLNDV)
            lobjParams.Add("PNCCLNT", pobjCuentaCorriente.PNCCLNT)
            lobjParams.Add("PNANIO", pobjCuentaCorriente.PNANIO)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            lobjParams.Add("PNCMNDA  ", pobjCuentaCorriente.CMNDA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTA_CORRIENTE_X_ANIO", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
        Return dt
    End Function
    Public Function Lista_CuentaCorriente_X_Cliente_Anio_Detalle(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.PSCPLNDV)
            lobjParams.Add("PNCCLNT", pobjCuentaCorriente.PNCCLNT)
            lobjParams.Add("PNANIO", pobjCuentaCorriente.PNANIO)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            lobjParams.Add("PNCMNDA  ", pobjCuentaCorriente.CMNDA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CUENTA_CORRIENTE_X_ANIO_DETALLE", lobjParams)
        Catch ex As Exception
            Return New DataTable
        End Try
        Return dt
    End Function

    Public Function Lista_CtaCte_OrdenesInternas(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CTACTE_OI", lobjParams)
        Return dt
    End Function

    Public Function Cargar_Reporte_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCPLNDV", pobjCuentaCorriente.PNCPLNDV)
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PAGESIZE", pobjCuentaCorriente.PageSize)
        lobjParams.Add("PAGENUMBER", pobjCuentaCorriente.PageNumber)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_REPORTE_CUENTA_CORRIENTE", lobjParams)

        Return dt
    End Function

    Public Function Cargar_Reporte_Ventas_General(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCMNDA", pobjCuentaCorriente.CMNDA)
        lobjParams.Add("PSCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_GENERAL", lobjParams)

        Return dt
    End Function

    Public Function Cargar_Reporte_Ventas_Detallado(ByVal pobjCuentaCorriente As CuentaCorriente) As DataSet
        Dim dt As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCMNDA", pobjCuentaCorriente.CMNDA)
        lobjParams.Add("PSCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
       
        If pobjCuentaCorriente.CMNDA = 1 Then
            lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            'dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_DETALLADO", lobjParams)
            dt = lobjSql.ExecuteDataSet("SP_SOLCT_LISTA_VENTAS_DETALLADO_V3", lobjParams)
        Else
            'lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            dt = lobjSql.ExecuteDataSet("SP_SOLCT_LISTA_VENTAS_DETALLADO_DOLARES", lobjParams)
        End If
        Dim NumFilas As Int32 = dt.Tables(0).Rows.Count - 1
        For Fila As Int32 = 0 To NumFilas
            dt.Tables(0).Rows(Fila)("FE_CNTA_CNTE") = HelpClass.FechaNum_a_Fecha(dt.Tables(0).Rows(Fila)("FE_CNTA_CNTE"))
        Next
        Return dt
    End Function


    Public Function Cargar_Reporte_Ventas_Detallado_Documento(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCMNDA", pobjCuentaCorriente.CMNDA)
        lobjParams.Add("PSCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
      
        If pobjCuentaCorriente.CMNDA = 1 Then
            lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_DETALLADO_DOCUMENTO", lobjParams)
        Else
            lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV)
            lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
            dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_DETALLADO_DOLARES_DOCUMENTO", lobjParams)
        End If
        Dim NumFilas As Int32 = dt.Rows.Count - 1
        For Fila As Int32 = 0 To NumFilas
            dt.Rows(Fila)("FE_CNTA_CNTE") = HelpClass.FechaNum_a_Fecha(dt.Rows(Fila)("FE_CNTA_CNTE"))
        Next
        Return dt
    End Function



    Public Function Cargar_Reporte_Ventas_CentroCosto(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCMNDA", pobjCuentaCorriente.CMNDA)
        lobjParams.Add("PSCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PSFEINI", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PSFEFIN", pobjCuentaCorriente.FechaFin)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PSCPLNDV", pobjCuentaCorriente.CPLNDV)
        lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_CENTROCOSTO_V2", lobjParams)
        ' dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_VENTAS_CENTROCOSTO", lobjParams)
        Return dt
    End Function

    Public Sub Generar_SAP_CuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
            lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)

            lobjSql.ExecuteNonQuery("SP_SOLMIN_AS400_CL_RSAP104", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub AnularCuentaCorriente(ByVal pobjCuentaCorriente As CuentaCorriente)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("IN_CCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("IN_CDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("IN_CTPODC", CInt(pobjCuentaCorriente.CTPODC))
            lobjParams.Add("IN_NDCCTC", CInt(pobjCuentaCorriente.NDCCTC))
            lobjParams.Add("IN_CULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("IN_NTRMNL", pobjCuentaCorriente.NTRMNL)
            lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_DOCUMENTO_FACTURACION", lobjParams)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Listar_Sustento_Factura(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As New DataTable
        Dim oDt2 As New DataTable
        Dim oDr As DataRow
        Try
            lobjParams.Add("PNNDCMFC", pobjCuentaCorriente.NDCCTC)
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_SUSTENTO_FACTURA", lobjParams)
            oDt2 = oDt.Clone
            oDt2.Columns.Add(New DataColumn("INDICE", GetType(System.String)))
            oDt2.Columns("TMNCNT").DataType = GetType(System.String)
            oDt2.Columns("TMNCN1").DataType = GetType(System.String)
            oDt2.Columns("CMNDGU").DataType = GetType(System.String)
            oDt2.Columns("IVNTA").DataType = GetType(System.Double)
            For i As Integer = 0 To oDt.Rows.Count - 1
                oDr = oDt2.NewRow
                oDr("NOPRCN") = oDt.Rows(i).Item("NOPRCN")
                oDr("NORSRT") = oDt.Rows(i).Item("NORSRT")
                oDr("CCLNT") = oDt.Rows(i).Item("CCLNT")
                oDr("TCMPCL") = oDt.Rows(i).Item("TCMPCL").ToString.Trim
                oDr("CCLNFC") = oDt.Rows(i).Item("CCLNFC")
                oDr("TCMPFC") = oDt.Rows(i).Item("TCMPFC").ToString.Trim
                oDr("TDRCFC") = oDt.Rows(i).Item("TDRCFC").ToString.Trim
                oDr("NRUCFC") = IIf(oDt.Rows(i).Item("NRUCFC") = 0, oDt.Rows(i).Item("NLBTEL"), oDt.Rows(i).Item("NRUCFC"))
                oDr("CMRCDR") = oDt.Rows(i).Item("CMRCDR").ToString.Trim
                oDr("TCMRCD") = oDt.Rows(i).Item("TCMRCD").ToString.Trim
                oDr("CTPOSR") = oDt.Rows(i).Item("CTPOSR").ToString.Trim
                oDr("TCMTPS") = oDt.Rows(i).Item("TCMTPS").ToString.Trim
                oDr("CTPSBS") = oDt.Rows(i).Item("CTPSBS").ToString.Trim
                oDr("TCMSBS") = oDt.Rows(i).Item("TCMSBS").ToString.Trim
                oDr("NGUITR") = oDt.Rows(i).Item("NGUITR")
                oDr("FGUITR") = oDt.Rows(i).Item("FGUITR").ToString.Trim
                oDr("SRPTRM") = oDt.Rows(i).Item("SRPTRM").ToString.Trim
                oDr("RUTA") = oDt.Rows(i).Item("RUTA").ToString.Trim
                oDr("CTRSPT") = oDt.Rows(i).Item("CTRSPT")
                oDr("TCMTRT") = oDt.Rows(i).Item("TCMTRT").ToString.Trim
                oDr("NPLVHT") = oDt.Rows(i).Item("NPLVHT").ToString.Trim
                oDr("CMNDGU") = oDt.Rows(i).Item("CMNDGU").ToString.Trim
                oDr("TSGNMN_S") = oDt.Rows(i).Item("TSGNMN_S").ToString.Trim
                oDr("ISRVGU") = oDt.Rows(i).Item("ISRVGU")
                oDr("QCNDTG") = oDt.Rows(i).Item("QCNDTG")
                oDr("CUNDSR") = oDt.Rows(i).Item("CUNDSR").ToString.Trim
                oDr("CMNLQT") = oDt.Rows(i).Item("CMNLQT").ToString.Trim
                oDr("TSGNMN_L") = oDt.Rows(i).Item("TSGNMN_L").ToString.Trim
                oDr("ILQDTR") = oDt.Rows(i).Item("ILQDTR")
                oDr("VLRFDT") = oDt.Rows(i).Item("VLRFDT")
                oDr("TCMTRF") = IIf(oDt.Rows(i).Item("TCMTRF").ToString.Trim = "FLETE", "1 " & oDt.Rows(i).Item("TCMTRF").ToString.Trim, oDt.Rows(i).Item("TCMTRF").ToString.Trim)
                oDr("IVNTA") = oDt.Rows(i).Item("IVNTA")
                oDr("PBRTOR") = oDt.Rows(i).Item("PBRTOR")
                oDr("CPRCN1") = oDt.Rows(i).Item("CPRCN1")
                oDr("NSRCN1") = oDt.Rows(i).Item("NSRCN1")
                oDr("TMNCNT") = IIf(oDt.Rows(i).Item("TMNCNT") = 0, "", oDt.Rows(i).Item("TMNCNT"))
                oDr("CPRCN2") = oDt.Rows(i).Item("CPRCN2")
                oDr("NSRCN2") = oDt.Rows(i).Item("NSRCN2")
                oDr("TMNCN1") = IIf(oDt.Rows(i).Item("TMNCN1") = 0, "", oDt.Rows(i).Item("TMNCN1"))
                oDr("CTIGVA") = oDt.Rows(i).Item("CTIGVA")
                oDr("PIGVA") = oDt.Rows(i).Item("PIGVA")
                oDr("INDICE") = oDr("TCMTRF") & oDr("CUNDSR")
                oDr("TCNFVH") = oDt.Rows(i).Item("TCNFVH")
                oDr("CSTNDT") = oDt.Rows(i).Item("CSTNDT")
                oDr("PESOL") = oDt.Rows(i).Item("PESOL")
                oDt2.Rows.Add(oDr)
            Next
            Return oDt2
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Listar_Compara_Servicio(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        ' Dim oDs As New DataSet
        Dim odt As New DataTable
        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PNFEINI", pobjCuentaCorriente.FechaInicio)
            lobjParams.Add("PNFEFIN", pobjCuentaCorriente.FechaFin)
            '  oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_RPT_FACTURACION_COMP", lobjParams)
            odt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_RPT_FACTURACION_COMP_V2", lobjParams)
            Return odt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Listar_FacturadoSOLMIN(ByVal pobjCuentaCorriente As CuentaCorriente) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDs As New DataSet
        Try
            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PNFEINI", pobjCuentaCorriente.FechaInicio)
            lobjParams.Add("PNFEFIN", pobjCuentaCorriente.FechaFin)
            'oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_RPT_FACTURACION_RZSC20", lobjParams)
            oDs = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_RPT_FACTURACION_SERVICIO_CLIENTE", lobjParams)
            'SP_SOLMIN_CT_RPT_FACTURACION_SERVICIO_CLIENTE
            Return oDs
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function ActualizaEstadoDocumento(ByVal pobjCuentaCorriente As CuentaCorriente) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSEST_DOC", pobjCuentaCorriente.PSEST_DOC)
            lobjParams.Add("PSEST_DOCANT", pobjCuentaCorriente.PSEST_DOCANT)
            lobjParams.Add("PNNDCCTC", CInt(pobjCuentaCorriente.NDCCTC))
            lobjParams.Add("PNNRLENC", pobjCuentaCorriente.NRLENC)
            lobjParams.Add("PNFECHA", pobjCuentaCorriente.FENT)
            lobjParams.Add("PNFENCBD", pobjCuentaCorriente.FENCBD)
            lobjParams.Add("PNFENTCL", pobjCuentaCorriente.FENTCL)
            lobjParams.Add("PSESTADO", pobjCuentaCorriente.Estado)

            lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZA_ESTADODOC_CTACTE", lobjParams)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Buscar_PorNumero_Documento(ByVal pnNumero As Integer, ByVal pnTipo As Integer) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNDCCTC", pnNumero)
        lobjParams.Add("PNCTPODC", pnTipo)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_DOCUMENTO", lobjParams)

        Return dt
    End Function


    Public Function ObtenerCorrelativo(ByVal psCadena As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCTPCTR", psCadena)

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_CONTROL_NUMERACION", lobjParams)

        Return dt
    End Function
    ''' <summary>
    ''' Permite buscar los documentos de manera misiva
    ''' </summary>
    ''' <param name="pobjCuentaCorriente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Buscar_Documento_Masivo(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pobjCuentaCorriente.CCLNT)
        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
        lobjParams.Add("PNCPLNDV", pobjCuentaCorriente.CPLNDV)
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PSCRGVTA", pobjCuentaCorriente.CRGVTA)
        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        lobjParams.Add("PFE_INICIO", pobjCuentaCorriente.FechaInicio)
        lobjParams.Add("PFE_FINAL", pobjCuentaCorriente.FechaFin)
        lobjParams.Add("PNCDSGDC", pobjCuentaCorriente.PNCDSGDC)
        lobjParams.Add("PSURSPDC", pobjCuentaCorriente.PSURSPDC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_BUSCA_MASIVO_DOCUMENTO", lobjParams)

        Return dt
    End Function

   

    Public Function Lista_CuentaCorriente_X_NRelCobranza(ByVal pobjCuentaCorriente As CuentaCorriente) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRLENC", pobjCuentaCorriente.NRLENC)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_CUENTACORRIENTE_X_REL_COBRANZA", lobjParams)
        For Each Item As DataRow In dt.Rows
            Item("FDCCTC") = HelpClass.FechaNum_a_Fecha(Item("FDCCTC"))
        Next
        Return dt
    End Function

    Public Function Anular_Cuenta_Corriente(ByVal pobjCuentaCorriente As CuentaCorriente) As Integer
        Dim result As Int32 = 0
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
            lobjParams.Add("PSCDVSN", pobjCuentaCorriente.PSCDVSN)
            lobjParams.Add("PNCTPODC", pobjCuentaCorriente.PNCTPODC)
            lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.PNNDCCTC)
            lobjParams.Add("PNCCLNT", pobjCuentaCorriente.PNCCLNT)
            lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
            lobjParams.Add("PSNTRMNL", pobjCuentaCorriente.NTRMNL)
            lobjParams.Add("PNRESULT", 0, ParameterDirection.Output)
            lobjSql.ExecuteNonQuery("SP_SOLCT_ANULAR_CUENTA_CORRIENTE", lobjParams)
            result = lobjSql.ParameterCollection("PNRESULT")
        Catch ex As Exception
            result = 0
        End Try
        Return result
    End Function

    Public Function Lista_Tipo_Cambio_Actual(ByVal PNCMNDA1 As Decimal) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCMNDA1", PNCMNDA1)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TIPO_CAMBIO_ACTUAL", lobjParams)      
        Return dt
    End Function

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Public Function ValidarAnulacionDocumento(ByVal ccmpn As String, ByVal ctpodc As String, ByVal ndcctc As String) As DataTable
        Dim output As New DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter

            parameter.Add("PSCCMPN", ccmpn)
            parameter.Add("PNCTPODC", ctpodc)
            parameter.Add("PNNDCCTC", ndcctc)

            output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_ANULACION_DOCUMENTO", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function

    Public Function AnulacionCuentaCorriente(ByVal cuentaCorriente As CuentaCorriente) As DataTable
        Dim output As New DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter

            parameter.Add("PSCCMPN", cuentaCorriente.PSCCMPN)
            parameter.Add("PSCDVSN", cuentaCorriente.PSCDVSN)
            parameter.Add("PNCTPODC", cuentaCorriente.PNCTPODC)
            parameter.Add("PNNDCCTC", cuentaCorriente.PNNDCCTC)
            parameter.Add("PNCCLNT", cuentaCorriente.PNCCLNT)
            parameter.Add("PSCULUSA", ConfigurationWizard.UserName)
            parameter.Add("PSNTRMNL", cuentaCorriente.NTRMNL)

            output = sqlManager.ExecuteDataTable("SP_SOLCT_ANULAR_CUENTA_CORRIENTE_SALM", parameter)
        Catch ex As Exception
            output = Nothing
        End Try

        Return output
    End Function
   

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
   


End Class
