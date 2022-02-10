Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.WayBill

Public Class cWayBill
    Implements IDisposable
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexion
    '-------------------------------------------------
    Private oSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private sErrorMessage As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property ErrorMessage() As String
        Get
            Return sErrorMessage
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    Sub New()
        oSqlManager = New SqlManager
    End Sub

    ''' <summary>
    ''' Procedimiento para eliminar un Bulto
    ''' </summary>
    Public Function Delete(ByVal Bulto As TD_BultoPK, ByVal strUsuario As String) As Boolean
        Dim objParametros As Parameter = Nothing
        Dim blnResultado As Boolean = True
        objParametros = New Parameter
        ' Ingresamos los parametros del Procedure
        With Bulto
            objParametros.Add("IN_CCMPN", .pCCMPN_Compania)
            objParametros.Add("IN_CDVSN", .pCDVSN_Division)
            objParametros.Add("IN_CPLNDV", .pCPLNDV_Planta)
            objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
            objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
            objParametros.Add("IN_NSEQIN", .pNSEQIN_NrSecuencia)
            objParametros.Add("IN_USUARI", strUsuario)
            objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
            ' Registramos el Bulto asociado a la Paleta
            Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_BULTO_RZOL65_DELETE", objParametros)
                ' Obteniendo los valores devueltos
                Dim htResultado As Hashtable
                htResultado = oSqlManager.ParameterCollection
                sErrorMessage = htResultado("OU_MSGERR").ToString
                If sErrorMessage <> "" Then blnResultado = False
            Catch ex As Exception
                sErrorMessage = "Error producido en la funcion : << Delete >> de la clase << cWayBill >> " & vbNewLine & _
                                "Tipo de Consulta : SP_SOLMIN_SAT_BULTO_RZOL65_DEL " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
                blnResultado = False
            End Try
        End With
        Return blnResultado
    End Function

    Public Shared Function HoraNum_a_Hora_Cadena(ByVal oHora As Object) As String
        Dim Hora As String = ("" & oHora).ToString.Trim
        If CType(Hora, String) = "0" OrElse CType(Hora, String) = String.Empty Then
            Return ""
        Else
            'Dim Hora As String = ("" & oHora).ToString.Trim
            Dim h As String = ""
            Dim m As String = ""
            Dim s As String = ""
            If Hora.ToString.Trim.Length < 6 Then
                Hora = "0" & Hora
            End If
            h = Left(Hora, 2).PadLeft(2, "0")
            m = Right(Left(Hora, 4), 2).PadLeft(2, "0")
            s = Right(Hora, 2).PadLeft(2, "0")
            Return h + ":" + m + ":" + s
        End If
    End Function

    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function


    ''' <summary>
    ''' Listado de Bultos en Formato L01 para ser utilizadas en un DataGrid con opciones de Paginación - Gestión
    ''' </summary> 
    Public Function fdtListar_L01(ByVal TD_Filtro As TD_Qry_Bulto_L01, ByRef intNroTotalPaginas As Int32) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure

        'If Not TD_Filtro.pCREFFW_CodigoBulto.ToString.Trim.Equals("") Or TD_Filtro.pNGUIRM_GuiaDeRemision <> 0 Then
        '    With objParametros
        '        .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
        '        .Add("IN_CCMPN", TD_Filtro.pCCMPN_CodigoCompania)
        '        .Add("IN_CDVSN", TD_Filtro.pCDVSN_CodigoDivision)
        '        .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_CodigoPlanta)
        '        .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto)
        '        .Add("IN_NGUIRM", TD_Filtro.pNGUIRM_GuiaDeRemision)
        '        .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
        '        .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)
        '        .Add("IN_SSTINV", TD_Filtro.pSSTINV_StatusAlmacen)
        '        .Add("U_TOTPAG", 0, ParameterDirection.Output)
        '    End With
        'Else
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto.Trim)
            .Add("IN_NROPLT", TD_Filtro.pNROPLT_NroPaletizado)
            .Add("IN_FREFFW_INI", TD_Filtro.pFREFFW_FechaRecep_Ini_FNum)
            .Add("IN_FREFFW_FIN", TD_Filtro.pFREFFW_FechaRecep_Fin_FNum)
            .Add("IN_FSLFFW_INI", TD_Filtro.pFSLFFW_FechaDesp_Ini_FNum)
            .Add("IN_FSLFFW_FIN", TD_Filtro.pFSLFFW_FechaDesp_Fin_FNum)
            .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga.Trim)
            .Add("IN_SSTINV", TD_Filtro.pSSTINV_StatusAlmacen.Trim)
            .Add("IN_TUBRFR", TD_Filtro.pTUBRFR_Ubicacion.Trim)
            .Add("IN_STRNSM", TD_Filtro.pSTRNSM_StatusTransmision)
            .Add("IN_STPING", TD_Filtro.pSTPING_TipoMovimiento)
            .Add("IN_CRTLTE", TD_Filtro.pCRTLTE_CriterioLote.Trim)
            .Add("IN_NROPAG", TD_Filtro.pNROPAG_NroPagina)
            .Add("IN_REGPAG", TD_Filtro.pREGPAG_NroRegPorPagina)

            .Add("IN_CCMPN", TD_Filtro.pCCMPN_CodigoCompania.Trim)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_CodigoDivision.Trim)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_CodigoPlanta)
            .Add("IN_FLGCNL", TD_Filtro.pFLGCNL_FlagLlegada)

            .Add("IN_NGRPRV", TD_Filtro.pNGRPRV_GuiaProveedor)
            .Add("IN_NORCML", TD_Filtro.pNORCML_OrdenDeCompra)
            .Add("IN_SSNCRG", TD_Filtro.pSSNCRG_Sentido_Carga)
            .Add("OU_TOTPAG", 0, ParameterDirection.Output)
        End With
        'End If
        Try
            sErrorMessage = ""
            dtTemp = oSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_CONSULTA_DE_BULTO", objParametros)
            For Each item As DataRow In dtTemp.Rows
                item("HORIDE") = HoraNum_a_Hora_Cadena(item("HORIDE"))
                item("FREFFW") = FechaNum_a_Fecha(item("FREFFW"))
                item("FSLFFW") = FechaNum_a_Fecha(item("FSLFFW"))
                item("FCNFCL") = FechaNum_a_Fecha(item("FCNFCL"))
                item("HCNFCL") = HoraNum_a_Hora_Cadena(item("HCNFCL"))
                item("FCHCRT") = FechaNum_a_Fecha(item("FCHCRT"))
                item("HRACRT") = HoraNum_a_Hora_Cadena(item("HRACRT"))
                item("FULTAC") = FechaNum_a_Fecha(item("FULTAC"))
                item("HULTAC") = HoraNum_a_Hora_Cadena(item("HULTAC"))
                item("FRQALC") = FechaNum_a_Fecha(item("FRQALC"))

            Next

            Dim htResultado As Hashtable
            htResultado = oSqlManager.ParameterCollection
            intNroTotalPaginas = htResultado("OU_TOTPAG")
        Catch ex As Exception
            dtTemp = New DataTable
            intNroTotalPaginas = 0
            'sErrorMessage = "Error producido en la funcion : << fdtListar_L01 >> de la clase << cWayBill >> " & vbNewLine & _
            '                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL65_L01 >> " & vbNewLine & _
            '                  "Motivo del Error : " & ex.Message

            sErrorMessage = ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Listado de Items de un Bulto en Formato L01 para ser utilizadas en un DataGrid
    ''' </summary>
    Public Shared Function fdtListar_ItemsBultos_L01(ByVal objSqlManager As SqlManager, ByVal TD_Filtro As TD_BultoPK, _
                                                     ByRef strMensajeError As String) As DataTable
        Dim dtTemp As DataTable
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto)
            .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
            .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
            .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
        End With
        Try
            strMensajeError = ""
            dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_RZOL66_L01", objParametros)
        Catch ex As Exception
            dtTemp = New DataTable
            strMensajeError = "Error producido en la funcion : << fdtListar_ItemsBultos_L01 >> de la clase << daoWayBill >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL66_L01 >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return dtTemp
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de obtener el siguiente Nro de la Secuencia disponible según parametro establecido 
    ''' </summary>
    Public Function fintObtener_Secuencia(ByVal Status As TD_Secuencia) As Int64
        Dim objParametros As Parameter = New Parameter
        Dim intNroPaleta As Int64 = 0
        Dim htResultado As Hashtable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CTPCTR", Status.pCTPCTR_TipoSecuencia)
            .Add("IN_STADEF", Status.pSTADEF_StatusDefinitivo)
            .Add("IN_USUARI", Status.pUSUARI_Usuario)
            .Add("OU_NULCTR", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.ExecuteNonQuery("SP_SOLMIN_SECUENCIA_RZZM04_OBT", objParametros)
            ' Obteniendo los valores devueltos
            htResultado = oSqlManager.ParameterCollection
            intNroPaleta = htResultado("OU_NULCTR")
        Catch ex As Exception
            intNroPaleta = 0
            sErrorMessage = "Error producido en la funcion : << fintObtener_Secuencia >> de la clase << cWayBill >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SECUENCIA_RZZM04_OBT >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return intNroPaleta
    End Function


    Public Function Generar_Cab_PreDespacho(pCCMPN As String, pCDVSN As String, pCPLNDV As Decimal, pCCLNT As Decimal, pTIPOCONTROL As String, pUSUARIO As String, pTERMINAL As String, ByRef msgError As String) As Int64
        Dim objParametros As Parameter = New Parameter
        Dim dt As New DataTable
        Dim NrControl As Decimal = 0

        With objParametros
            .Add("PSCCMPN", pCCMPN)

            .Add("PSCDVSN", pCDVSN)
            .Add("PNCPLNDV", pCPLNDV)

            .Add("PNCCLNT", pCCLNT)
            .Add("PSTIPOCONTROL", pTIPOCONTROL)
            .Add("PSUSUARIO", pUSUARIO)
            .Add("PSTERMINAL", pTERMINAL)
        End With

        msgError = ""
        dt = oSqlManager.ExecuteDataTable("SP_SOLMIN_SA_GENERAR_CAB_PREDESPACHO", objParametros)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msgError = msgError & item("OBSRESULT") & Chr(10)
            End If
        Next
        msgError = msgError.Trim
        If msgError = "" Then
            NrControl = dt.Rows(0)("NRCTRL")
        End If


        Return NrControl
    End Function


    ''' <summary>
    ''' Procedimiento que se encarga de obtener el Nro de Lugares Distintos referente a la Orden de Compra - Item 
    ''' </summary>
    Public Function fintObtener_NroLugares(ByVal intCliente As Int64, ByVal strListaBultos As String, ByVal strListaPaletas As String) As Int64
        Dim objParametros As Parameter = New Parameter
        Dim intNroPaleta As Int64 = 0
        Dim htResultado As Hashtable
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", intCliente)
            .Add("IN_CREFFW", strListaBultos)
            .Add("IN_NROPLT", strListaPaletas)
            .Add("OU_NRLDST", 0, ParameterDirection.Output)
        End With
        Try
            sErrorMessage = ""
            oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_PDESPA_RZOL65_VLD", objParametros)
            ' Obteniendo los valores devueltos
            htResultado = oSqlManager.ParameterCollection
            intNroPaleta = htResultado("OU_NRLDST")
        Catch ex As Exception
            intNroPaleta = 0
            sErrorMessage = "Error producido en la funcion : << fintObtener_NroLugares >> de la clase << cWayBill >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_PDESPA_RZOL65_VLD >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return intNroPaleta
    End Function

    ''' <summary>
    ''' Procedimiento que se encarga de obtener Información básica del Bulto
    ''' </summary>
    Public Shared Function fobjObtener_Inf_Bulto_L01(ByVal objSqlManager As SqlManager, ByVal Filtro As Ransa.TypeDef.WayBill.TD_Qry_Bulto_L01, _
                                                     ByRef strMensajeError As String) As TD_Inf_Bulto_L01
        Dim objParametros As Parameter = New Parameter
        Dim objBultoInf As TD_Inf_Bulto_L01 = New TD_Inf_Bulto_L01
        ' Ingresamos los parametros del Procedure
        With objParametros

            .Add("IN_CCMPN", Filtro.pCCMPN_CodigoCompania)
            .Add("IN_CDVSN", Filtro.pCDVSN_CodigoDivision)
            .Add("IN_CPLNDV", Filtro.pCPLNDV_CodigoPlanta)
            .Add("IN_CCLNT", Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", Filtro.pCREFFW_CodigoBulto)
        End With
        'Try
        Dim dtTemp As DataTable
        strMensajeError = ""
        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_RZOL65_Q01", objParametros)
        If dtTemp.Rows.Count > 0 Then
            With objBultoInf
                .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
                .pCREFFW_CodigoBulto = ("" & dtTemp.Rows(0).Item("CREFFW")).ToString.Trim
                Decimal.TryParse("" & dtTemp.Rows(0).Item("NSEQIN"), .pNSEQIN_NrSecuencia)
                Decimal.TryParse("" & dtTemp.Rows(0).Item("QREFFW"), .pQREFFW_CantidadRecibida)
                Int64.TryParse("" & dtTemp.Rows(0).Item("NROPLT"), .pNROPLT_NroPaletizado)
                .pTLUGEN_LugarEntrega = ("" & dtTemp.Rows(0).Item("TLUGEN")).ToString.Trim
                Int64.TryParse("" & dtTemp.Rows(0).Item("NOCURR"), .pNOCURR_NroOcurrencia)
            End With
        End If
        'Catch ex As Exception
        '    strMensajeError = "Error producido en la funcion : << fobjObtener_NroLugares >> de la clase << daoWayBill >> " & vbNewLine & _
        '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL65_Q01 >> " & vbNewLine & _
        '                      "Motivo del Error : " & ex.Message
        'End Try
        Return objBultoInf
    End Function


    Public Shared Function fobjObtener_Inf_Bulto_PendientePreDespacho(ByVal objSqlManager As SqlManager, ByVal Filtro As Ransa.TypeDef.WayBill.TD_Qry_Bulto_L01, _
                                                    ByRef strMensajeError As String) As List(Of TD_Inf_Bulto_L01)
        Dim objParametros As Parameter = New Parameter
        Dim objBultoInf As TD_Inf_Bulto_L01  ' = New TD_Inf_Bulto_L01
        ' Ingresamos los parametros del Procedure
        With objParametros

            .Add("IN_CCMPN", Filtro.pCCMPN_CodigoCompania)
            .Add("IN_CDVSN", Filtro.pCDVSN_CodigoDivision)
            .Add("IN_CPLNDV", Filtro.pCPLNDV_CodigoPlanta)
            .Add("IN_CCLNT", Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", Filtro.pCREFFW_CodigoBulto)
            .Add("IN_CRTLTE", Filtro.pCRTLTE_CriterioLote)
        End With
        'Try
        Dim dtTemp As DataTable
        strMensajeError = ""
        dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_RZOL65_BULTO_PENDIENTE_PREDESPACHO", objParametros)
        Dim oList As New List(Of TD_Inf_Bulto_L01)
        If dtTemp.Rows.Count > 0 Then

            For Each item As DataRow In dtTemp.Rows
                objBultoInf = New TD_Inf_Bulto_L01

                With objBultoInf
                    .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
                    .pCREFFW_CodigoBulto = ("" & dtTemp.Rows(0).Item("CREFFW")).ToString.Trim
                    Decimal.TryParse("" & item("NSEQIN"), .pNSEQIN_NrSecuencia)
                    Decimal.TryParse("" & item("QREFFW"), .pQREFFW_CantidadRecibida)
                    Int64.TryParse("" & item("NROPLT"), .pNROPLT_NroPaletizado)
                    .pNROPLT_NroPaletizado_str = ("" & item("NRPLTS")).ToString.Trim
                    .pTLUGEN_LugarEntrega = ("" & item("TLUGEN")).ToString.Trim
                    Int64.TryParse("" & item("NOCURR"), .pNOCURR_NroOcurrencia)


                End With
                oList.Add(objBultoInf)

            Next
            
        End If
        'Catch ex As Exception
        '    strMensajeError = "Error producido en la funcion : << fobjObtener_NroLugares >> de la clase << daoWayBill >> " & vbNewLine & _
        '                      "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL65_Q01 >> " & vbNewLine & _
        '                      "Motivo del Error : " & ex.Message
        'End Try
        Return oList
    End Function


    ''' <summary>
    ''' Procedimiento que se encarga de registrar los Bultos a un Nro de Paleta ya existente
    ''' </summary>
    Public Function fblnRegistrar_Paletas(ByVal intNroPaleta As Int64, ByVal strCriterioLote As String, ByVal lstBultos As List(Of TD_Sel_Bulto_L01), _
                                          ByVal strUsuario As String) As Boolean
        Dim objParametros As Parameter = Nothing
        Dim objBultoSelecTemp As TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = True
        Dim htResultado As Hashtable
        ' Recorremos todas las Paletas
        For Each objBultoSelecTemp In lstBultos
            objParametros = New Parameter
            ' Ingresamos los parametros del Procedure
            With objBultoSelecTemp
                objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
                objParametros.Add("IN_NROPLT", intNroPaleta)
                objParametros.Add("IN_CRTLTE", strCriterioLote)
                objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
                objParametros.Add("IN_QREFFW", .pQREFFW_CantidadRecibida)
                objParametros.Add("IN_QREPLT", .pQREFFW_CantidadRecibida)
                objParametros.Add("IN_USUARI", strUsuario)
                objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
                ' Registramos el Bulto asociado a la Paleta
                Try
                    oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_PALETA_RZOL65P_INS", objParametros)
                    ' Obteniendo los valores devueltos
                    htResultado = oSqlManager.ParameterCollection
                    sErrorMessage = htResultado("OU_MSGERR").ToString
                    If sErrorMessage <> "" Then blnResultado = False
                Catch ex As Exception
                    sErrorMessage = "Error producido en la funcion : << fblnRegistrar_Paletas >> de la clase << cWayBill >> " & vbNewLine & _
                                    "Tipo de Consulta : SP_SOLMIN_SAT_PALETA_RZOL65P_INS " & vbNewLine & _
                                    "Motivo del Error : " & ex.Message
                    blnResultado = False
                End Try
                If Not blnResultado Then Exit For
            End With
        Next
        Return blnResultado
    End Function


    Public Function Registrar_Paletas_V2(ByVal intNroPaleta As Int64, NroPaletaTxt As String, ByVal strCriterioLote As String, ByVal lstBultos As List(Of TD_Sel_Bulto_L01), _
                                          ByVal strUsuario As String) As String
        Dim objParametros As Parameter = Nothing
        Dim objBultoSelecTemp As TD_Sel_Bulto_L01
        'Dim blnResultado As Boolean = True
        'Dim htResultado As Hashtable
        Dim dt As New DataTable
        Dim msg As String = ""
        ' Recorremos todas las Paletas
        For Each objBultoSelecTemp In lstBultos
            objParametros = New Parameter
            ' Ingresamos los parametros del Procedure

            '.Add("IN_CCMPN", TD_Filtro.pCCMPN_CodigoCompania.Trim)
            '.Add("IN_CDVSN", TD_Filtro.pCDVSN_CodigoDivision.Trim)
            '.Add("IN_CPLNDV", TD_Filtro.pCPLNDV_CodigoPlanta)



            With objBultoSelecTemp
                objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
                objParametros.Add("IN_NROPLT", intNroPaleta)
                objParametros.Add("IN_NRPLTS", NroPaletaTxt)
                objParametros.Add("IN_CCMPN", .pCCMPN_Compania)
                objParametros.Add("IN_CDVSN", .pCDVSN_Division)
                objParametros.Add("IN_CPLNDV", .pCPLNDV_Planta)
                objParametros.Add("IN_CRTLTE", strCriterioLote)
                objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
                objParametros.Add("IN_QREFFW", .pQREFFW_CantidadRecibida)
                objParametros.Add("IN_QREPLT", .pQREFFW_CantidadRecibida)
                'objParametros.Add("IN_TERMINAL", ConfigurationWizard.UserName)
                objParametros.Add("IN_TERMINAL", ConfigurationWizard.NombreMaquina)
                objParametros.Add("IN_USUARI", strUsuario)
                'objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
                ' Registramos el Bulto asociado a la Paleta
                'Try

                dt = oSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_PALETA_RZOL65P_INS_V2", objParametros)

                For Each item As DataRow In dt.Rows
                    If item("STATUS") = "E" Then
                        msg = msg & item("OBSRESULT") & Chr(10)
                    End If
                Next
                msg = msg.Trim
                If msg.Length > 0 Then
                    Exit For
                End If
                ' Obteniendo los valores devueltos
                'htResultado = oSqlManager.ParameterCollection
                'sErrorMessage = htResultado("OU_MSGERR").ToString
                'If sErrorMessage <> "" Then blnResultado = False
                'Catch ex As Exception
                '    sErrorMessage = "Error producido en la funcion : << fblnRegistrar_Paletas >> de la clase << cWayBill >> " & vbNewLine & _
                '                    "Tipo de Consulta : SP_SOLMIN_SAT_PALETA_RZOL65P_INS " & vbNewLine & _
                '                    "Motivo del Error : " & ex.Message
                '    blnResultado = False
                'End Try
                'If Not blnResultado Then Exit For
            End With
        Next
        Return msg
    End Function


    ''' <summary>
    ''' Procedimiento que se encarga de Pre-Despachar los Bultos a un Nro de Pre-Despacho ya existente
    ''' </summary>
    Public Function fblnRegistrar_PreDespacho(ByVal intNroPreDespacho As Int64, ByVal strCriterioLote As String, ByVal lstBultos As List(Of TD_Sel_Bulto_L01), _
                                              ByVal strUsuario As String) As Boolean
        Dim objParametros As Parameter = Nothing
        Dim objBultoSelecTemp As TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = True
        Dim htResultado As Hashtable
        ' Recorremos todas las Paletas
        For Each objBultoSelecTemp In lstBultos
            objParametros = New Parameter
            ' Ingresamos los parametros del Procedure
            With objBultoSelecTemp
                objParametros.Add("IN_CCMPN", .pCCMPN_Compania)
                objParametros.Add("IN_CDVSN", .pCDVSN_Division)
                objParametros.Add("IN_CPLNDV", .pCPLNDV_Planta)
                objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
                objParametros.Add("IN_NROCTL", intNroPreDespacho)
                objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
                objParametros.Add("IN_NSEQIN", .pNSEQIN_NrSecuencia)
                objParametros.Add("IN_NROPLT", .pNROPLT_NroPaletizado)
                objParametros.Add("IN_CRTLTE", strCriterioLote)
                objParametros.Add("IN_USUARI", strUsuario)
                objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)

                ' Registramos el Bulto asociado a la Paleta
                Try
                    oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_PDESPA_RZOL65_INS", objParametros)
                    ' Obteniendo los valores devueltos
                    htResultado = oSqlManager.ParameterCollection
                    sErrorMessage = htResultado("OU_MSGERR").ToString
                    If sErrorMessage <> "" Then blnResultado = False
                Catch ex As Exception
                    sErrorMessage = "Error producido en la funcion : << fblnRegistrar_PreDespacho >> de la clase << cWayBill >> " & vbNewLine & _
                                    "Tipo de Consulta : SP_SOLMIN_SAT_PDESPA_RZOL65_INS " & vbNewLine & _
                                    "Motivo del Error : " & ex.Message
                    blnResultado = False
                End Try
                If Not blnResultado Then Exit For
            End With
        Next
        Return blnResultado
    End Function



    Public Sub fblnRegistrar_Detalle_PreDespacho(ByVal intNroPreDespacho As Int64, ByVal strCriterioLote As String, ByVal lstBultos As List(Of TD_Sel_Bulto_L01), _
                                              ByVal strUsuario As String)
        Dim objParametros As Parameter = Nothing
        Dim objBultoSelecTemp As TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = True
        'Dim htResultado As Hashtable
        ' Recorremos todas las Paletas
        For Each objBultoSelecTemp In lstBultos
            objParametros = New Parameter
            ' Ingresamos los parametros del Procedure
            With objBultoSelecTemp
                objParametros.Add("IN_CCMPN", .pCCMPN_Compania)
                objParametros.Add("IN_CDVSN", .pCDVSN_Division)
                objParametros.Add("IN_CPLNDV", .pCPLNDV_Planta)
                objParametros.Add("IN_CCLNT", .pCCLNT_CodigoCliente)
                objParametros.Add("IN_NROCTL", intNroPreDespacho)
                objParametros.Add("IN_CREFFW", .pCREFFW_CodigoBulto)
                objParametros.Add("IN_NSEQIN", .pNSEQIN_NrSecuencia)
                objParametros.Add("IN_NROPLT", .pNROPLT_NroPaletizado)
                objParametros.Add("IN_CRTLTE", strCriterioLote)
                objParametros.Add("IN_USUARI", strUsuario)
                'objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)

                ' Registramos el Bulto asociado a la Paleta
                'Try
                oSqlManager.ExecuteNonQuery("SP_SOLMIN_SAT_REGISTRAR_DET_PREDESPACHO", objParametros)
                ' Obteniendo los valores devueltos
                '    htResultado = oSqlManager.ParameterCollection
                '    sErrorMessage = htResultado("OU_MSGERR").ToString
                '    If sErrorMessage <> "" Then blnResultado = False
                '    Catch ex As Exception
                '        sErrorMessage = "Error producido en la funcion : << fblnRegistrar_PreDespacho >> de la clase << cWayBill >> " & vbNewLine & _
                '                        "Tipo de Consulta : SP_SOLMIN_SAT_PDESPA_RZOL65_INS " & vbNewLine & _
                '                        "Motivo del Error : " & ex.Message
                '        blnResultado = False
                '    End Try
                '    If Not blnResultado Then Exit For
            End With
        Next

    End Sub


    ''' <summary>
    ''' Listado : Relación de Repceciones para ser Exportado en el formato de Ellipse / SAP - Depende del Cliente
    ''' </summary>
    Public Function fdstExportRecepcion(ByVal TD_Filtro As TD_Qry_ExportInf_F01) As DataSet
        Dim dstTemp As DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto)
            .Add("IN_FREFFW_INI", TD_Filtro.pFechaInicial_FNum)
            .Add("IN_FREFFW_FIN", TD_Filtro.pFechaFinal_FNum)
            .Add("IN_TUBRFR", TD_Filtro.pTUBRFR_Ubicacion)
            .Add("IN_STRNSM", TD_Filtro.pSTRNSM_StatusTransmision)
            .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
            .Add("IN_STUPDT", TD_Filtro.pSTUPDT_UpdateInf)
            .Add("IN_MMCUSR", TD_Filtro.pUsuario)
            .Add("PSCCMPN", TD_Filtro.PSCCMPN)
            .Add("PSCDVSN", TD_Filtro.PSCDVSN)
            .Add("PNCPLNDV", TD_Filtro.PNCPLNDV)
        End With
        Try
            sErrorMessage = ""
            dstTemp = oSqlManager.ExecuteDataSet("SP_SOLMIN_SAT_BULTO_RZOL66_L04", objParametros)
        Catch ex As Exception
            dstTemp = New DataSet
            sErrorMessage = "Error producido en la funcion : << fdstExportRecepcion >> de la clase << cWayBill >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL66_L04 >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return dstTemp
    End Function

    ''' <summary>
    ''' Listado : Relación de Despachos para ser Exportado en el formato de Ellipse
    ''' </summary>
    Public Function fdstExportDespacho(ByVal TD_Filtro As TD_Qry_ExportInf_F01) As DataSet
        Dim dstTemp As DataSet
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
            .Add("IN_CREFFW", TD_Filtro.pCREFFW_CodigoBulto)
            .Add("IN_FSLFFW_INI", TD_Filtro.pFechaInicial_FNum)
            .Add("IN_FSLFFW_FIN", TD_Filtro.pFechaFinal_FNum)
            .Add("IN_TUBRFR", TD_Filtro.pTUBRFR_Ubicacion)
            .Add("IN_STRNSM", TD_Filtro.pSTRNSM_StatusTransmision)
            .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
            .Add("IN_STUPDT", TD_Filtro.pSTUPDT_UpdateInf)
            .Add("IN_MMCUSR", TD_Filtro.pUsuario)
            .Add("PSCCMPN", TD_Filtro.PSCCMPN)
            .Add("PSCDVSN", TD_Filtro.PSCDVSN)
            .Add("PNCPLNDV", TD_Filtro.PNCPLNDV)
        End With
        Try
            sErrorMessage = ""
            dstTemp = oSqlManager.ExecuteDataSet("SP_SOLMIN_SAT_BULTO_RZOL66_L05", objParametros)
        Catch ex As Exception
            dstTemp = New DataSet
            sErrorMessage = "Error producido en la funcion : << fdstExportDespacho >> de la clase << cWayBill >> " & vbNewLine & _
                            "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SAT_BULTO_RZOL66_L05 >> " & vbNewLine & _
                            "Motivo del Error : " & ex.Message
        End Try
        Return dstTemp
    End Function



    Public Function fblnValidar_NroPallet(pCCLNT As Decimal, ByVal NroPaleta As String) As String

        Dim objParametros As Parameter = New Parameter
        objParametros.Add("PNCCLNT", pCCLNT)
        objParametros.Add("PSNRPLTS", NroPaleta)
        Dim dt As New DataTable
        Dim msg As String = ""
        dt = oSqlManager.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_PALLET", objParametros)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim
        ' Obteniendo los valores devueltos

        Return msg

    End Function


    Public Function ListarInventario(pTipo As String, NroPagina As Decimal, PageSize As Decimal, ByRef TotalPaginas As Decimal, pFiltro As TD_Sel_Bulto_L01) As DataTable
 
        Dim objParametros As Parameter = New Parameter
        objParametros.Add("PSTIPO", pTipo)
        objParametros.Add("PNCCLNT", pFiltro.pCCLNT_CodigoCliente)
        objParametros.Add("PSCCMPN", pFiltro.pCCMPN_Compania)
        objParametros.Add("PSCDVSN", pFiltro.pCDVSN_Division)
        objParametros.Add("PNCPLNDV", pFiltro.pCPLNDV_Planta)
        objParametros.Add("PNFINICIO", pFiltro.pFechaInicio)
        objParametros.Add("PNFFIN", pFiltro.pFechaFin)
        objParametros.Add("PSCODBUSQ", pFiltro.pCREFFW_CodigoBulto)
        objParametros.Add("IN_NROPAG", NroPagina)
        objParametros.Add("PAGESIZE", PageSize)

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds = oSqlManager.ExecuteDataSet("SP_SOLMIN_SAT_LISTAR_BULTOS_PALETIZADO_EN_INVENTARIO", objParametros)
        dt = ds.Tables(0).Copy
        TotalPaginas = ds.Tables(1).Rows(0)("NUM_PAG")
        'For Each item As DataRow In dt.Rows
        '    If item("STATUS") = "E" Then
        '        msg = msg & item("OBSRESULT") & Chr(10)
        '    End If
        'Next
        

        Return dt

    End Function



    Public Function ListarBulto_X_paletizado(pFiltro As TD_Sel_Bulto_L01) As DataTable

        Dim objParametros As Parameter = New Parameter

        objParametros.Add("PNCCLNT", pFiltro.pCCLNT_CodigoCliente)
        objParametros.Add("PNIDPALLET", pFiltro.pNROPLT_NroPaletizado)
        objParametros.Add("PSCCMPN", pFiltro.pCCMPN_Compania)
        objParametros.Add("PSCDVSN", pFiltro.pCDVSN_Division)
        objParametros.Add("PNCPLNDV", pFiltro.pCPLNDV_Planta)
        objParametros.Add("PNNSEQIN", pFiltro.pNSEQIN_NrSecuencia)
        Dim dt As New DataTable
        dt = oSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_LISTAR_BULTOS_X_PALETIZADO", objParametros)
        Return dt

    End Function





#End Region
#Region " IDisposable Support "
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                oSqlManager.Dispose()
                oSqlManager = Nothing
            End If
            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
