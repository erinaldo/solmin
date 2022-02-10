Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.DAO.OrdenCompra
Imports RANSA.TYPEDEF.OrdenCompra.OrdenCompra
Imports RANSA.TYPEDEF.OrdenCompra.ItemOC
Imports RANSA.DAO.Proveedor
Imports ransa.TYPEDEF.Proveedor

Imports RANSA.TYPEDEF.PartArancelaria
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.PartidaArancelaria

Imports RANSA.DATA.slnSOLMIN.DAO
Imports RANSA.DATA.slnSOLMIN_SAT.DAO

Namespace slnSOLMIN_SAT.Recepcion.Procesos
    Public Class clsRecepcion
        Inherits clsBasicClass
#Region " TiposDatos "
        Structure NewType_OrdenCompra
            Dim pCodigoCliente_CCLNT As Int32
            Dim pNroOrdenCompra_NORCML As String
        End Structure

        Structure NewType_ItemOC
            Dim pCodigoCliente_CCLNT As Int32
            Dim pNroOrdenCompra_NORCML As String
            Dim pNroItemOrdenCompra_NRITOC As Int32
        End Structure

        Enum ENUM_EstadosEliminacion
            SeEliminoItem
            SeEliminoItemyCabecera
            NoSeEliminoItem
            NoSeEliminoItemPorError
        End Enum

        Enum ENUM_ResultadoConsulta
            Verdadero
            Falso
            DatosIncompletos
            GeneroError
        End Enum

        Enum eTipoConsulta
            ResumenPorSelec
            ResumenSelecc
            DetalladoSelec
        End Enum
#End Region
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
        ''' <summary>
        ''' Funcion que se encarga de obtener la cadena de conexion para los procesos realizados desde el Servicio Web swSolminSAT
        ''' que permite la Integración con otros Sistemas de nuestros clientes.
        ''' </summary>
        Private Shared Function pstrObtenerCadenaConexion(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String) As String
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Return ConnStr
        End Function
#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_ItemsOrdenCompra(ByVal TipoConsulta As eTipoConsulta, ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra, _
                                                          ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            Dim strConsulta As String = ""
            Select Case TipoConsulta
                Case eTipoConsulta.ResumenPorSelec : strConsulta = "RECE_LSTIOC_01"
                Case eTipoConsulta.ResumenSelecc : strConsulta = "RECE_LSTIOC_02"
                Case eTipoConsulta.DetalladoSelec : strConsulta = "RECE_LSTIOC_03"
            End Select
            dtResultado = fdtResultadoConsulta(strMensajeError, strConsulta, objOrdenCompra.pintCodigoCliente_CCLNT, objOrdenCompra.pstrNroOrdenCompra_NORCML, _
             objOrdenCompra.Compania, objOrdenCompra.Division, objOrdenCompra.Planta)
            dtResultado.TableName = "ListaDeItemsOrdenCompra"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_MovimientoItemOrdenCompra(ByVal strCliente As String, ByVal strOrdenCompra As String, _
                                                                   ByVal strItemOrdenCompra As String, ByRef strMensajeError As String, _
                                                                   Optional ByVal Compania As String = "", _
                                                                   Optional ByVal Division As String = "", _
                                                                   Optional ByVal Planta As Double = 0) As DataTable
            Dim dtResultado As DataTable = Nothing
            Dim strConsulta As String = ""
            dtResultado = fdtResultadoConsulta(strMensajeError, "RECE_MOVIOC_01", strCliente, strOrdenCompra, strItemOrdenCompra, Compania, Division, Planta)
            dtResultado.TableName = "ListaMovimientoItemOrdenCompra"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_InfOrdenComprasPendientesWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                                     ByVal strCliente As String, ByVal strNroOC As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_RECE_LOCITE_01", strCliente, strNroOC)
            dtResultado.TableName = "OrdenCompras"
            Return dtResultado
        End Function

        ''' <summary>
        ''' Listado de Órdenes de Compras e Items para ser procesado por el Servicios Web swSolminSAT
        ''' que permite la Integración con otros Sistemas de nuestros clientes.
        ''' </summary>
        Public Shared Function fdtListar_OrdenesComprasWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                          ByVal strCliente As String, ByVal strNroOC As String, ByRef strMensajeError As String) As DataTable
            Dim objSqlManager As SqlManager = New SqlManager(pstrObtenerCadenaConexion(strUsuario, strPassword, strServidor))
            Return daoOrdenCompra.fdtListar_OrdenesComprasWS(objSqlManager, strCliente, strNroOC, strMensajeError)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Detalle de la Información -'
        '--------------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Shared Function fstrInformacion_ObservacionesItemOC(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra, ByRef strMensajeError As String) As String
            Dim dtResultado As DataTable = Nothing
            Dim strResultado As String = ""
            dtResultado = fdtResultadoConsulta(strMensajeError, "RECE_OBSIOC_01", objOrdenCompra.pintCodigoCliente_CCLNT, objOrdenCompra.pstrNroOrdenCompra_NORCML)
            dtResultado.TableName = "ObservacionesItemOC"
            If dtResultado.Rows.Count > 0 Then
                Dim dwRowTemp As DataRow
                For Each dwRowTemp In dtResultado.Rows
                    strResultado &= dwRowTemp.Item("TNOTAS").ToString
                Next
            End If
            Return strResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_OrdenCompraConMovimiento(ByRef strMensajeError As String, ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra) As Boolean
            Return fblnExisteInformacion(strMensajeError, "SAT_RECE_OCCMOV", objOrdenCompra.pintCodigoCliente_CCLNT, objOrdenCompra.pstrNroOrdenCompra_NORCML)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnCambiarClienteOC(ByRef strMensajeError As String, ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra, _
                                             ByVal strClienteDestino As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim intCount As Integer = 0
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objOrdenCompra
                objParametros.Add("IN_CCLNT_ORIG", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_NORCML", .pstrNroOrdenCompra_NORCML)
                objParametros.Add("IN_CCLNT_DEST", strClienteDestino)
                objParametros.Add("IN_USUARIO", strUsuarioSistema)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_OC_CHG", objParametros)
                Return True
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnCambiarClienteOC >> de la clase << clsRecepcion >> " & vbNewLine & _
                                  "Tipo de Operación : << Cambiar Cliente en una Orden de Compra >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Return False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
        End Function

        'Public Function fblnSaveOCsWithItem(ByVal objOrdenCompra As TD_OrdenCompra, ByVal lstItems As List(Of TD_ItemOC), _
        '                                    ByRef strMensajeError As String) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    Dim blnResultado As Boolean = True
        '    objSqlManager.TransactionController(TransactionType.Manual)
        '    objSqlManager.BeginGlobalTransaction()
        '    ' Ingresamos los parametros del Procedure
        '    If cOrdenCompra.Grabar(objSqlManager, objOrdenCompra, strUsuarioSistema, strMensajeError) Then
        '        Dim objItem As TD_ItemOC
        '        For Each objItem In lstItems
        '            If Not cItemOrdenCompra.Grabar(objSqlManager, objItem, strUsuarioSistema, strMensajeError) Then
        '                blnResultado = False
        '                objSqlManager.RollBackGlobalTransaction()
        '                Exit For
        '            End If
        '        Next
        '        If blnResultado Then objSqlManager.CommitGlobalTransaction()
        '    Else
        '        objSqlManager.RollBackGlobalTransaction()
        '        blnResultado = False
        '    End If
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        '    Return blnResultado
        'End Function

        ''' <summary>
        ''' Grabar las Órdenes de Compras y sus Items para ser procesado por el Servicios Web swSolminSAT
        ''' que permite la Integración con otros Sistemas de nuestros clientes.
        ''' </summary>
        'Public Shared Function fblnGrabar_OrdenesCompras(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
        '                                                 ByVal boListaOrdenesCompras As boOrdenesComprasWSInt, ByRef objWSErrorOC As clsWSErrorOrdenCompra) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager(pstrObtenerCadenaConexion(strUsuario, strPassword, strServidor))
        '    ' Variables para recorrer las Órdenes de Compras y sus respectivos Items
        '    Dim boOrdenCompra As boOrdenCompraWSInt
        '    Dim boItemOC As boItemOrdenCompraWSInt
        '    ' Variables para almacenar los valores de las Órdenes de Compras y sus respectivos Items
        '    Dim oOC As TD_OrdenCompra
        '    Dim oOCItem As TD_ItemOC
        '    Dim oProveedor As TD_Proveedor
        '    Dim oPartArencTemp As TD_PartArancelaria
        '    Dim intCodigoProveedor As Int32 = 0

        '    Dim strMensajeError As String = ""

        '    Dim blnResultado As Boolean = True
        '    objSqlManager.TransactionController(TransactionType.Manual)
        '    objSqlManager.BeginGlobalTransaction()
        '    ' Recorremos todas las Paletas
        '    For Each boOrdenCompra In boListaOrdenesCompras.Items
        '        oOC = New TD_OrdenCompra
        '        ' Recorremos los Bultos y grabamos uno x uno cada Bulto
        '        With oOC
        '            .pCCLNT_CodigoCliente = boOrdenCompra.pintCodigoCliente_CCLNT
        '            .pNORCML_NroOrdenCompra = boOrdenCompra.pstrNroOrdenCompra_NORCML
        '            .pTDSCML_Descripcion = boOrdenCompra.pstrDescripcion_TDSCML
        '            .pFORCML_FechaOCDte = boOrdenCompra.pdteFechaOrdenCompra_FORCML
        '            .pTCTCST_CentroCosto = boOrdenCompra.pstrDescripcionCentroCosto_TCTCST
        '            .pTTINTC_TerminoIntern = boOrdenCompra.pstrTerminoInternacioanlCarga_TTINTC
        '            '.pstrTerminoPago_TPAGME = boOrdenCompra.pstrTerminoPago_TPAGME
        '            '.pstrSimboloMoneda_NMONOC = boOrdenCompra.pstrSimboloMoneda_NMONOC
        '            '.pstrCodigoMedioTransporte_TNMMDT = boOrdenCompra.pstrCodigoMedioTransporte_TNMMDT
        '            '.pintTipoDespacho_NTPDES = boOrdenCompra.pintTipoDespacho_NTPDES
        '            '.pstrPaisEmbarque_TPAISEM = boOrdenCompra.pstrPaisEmbarque_TPAISEM
        '            '.pstrLugarEmbarque_TLUGEM = boOrdenCompra.pstrLugarEmbarque_TLUGEM
        '            .pTDEFIN_DestinoFinal = boOrdenCompra.pstrDestinoFinal_TDEFIN
        '            .pTEMPFAC_EmpresaFacturar = boOrdenCompra.pstrEmpresaFacturar_TEMPFAC
        '            .pCREGEMB_RegEmbarque = boOrdenCompra.pstrRegionEmbarque_CREGEMB
        '            .pTNOMCOM_NombreComprador = boOrdenCompra.pstrNombreComprador_TNOMCOM
        '        End With
        '        ' Verificamos el proveedor registrado en la Orden de Compra
        '        oProveedor = New TD_Proveedor
        '        With oProveedor
        '            .pNRUCPR_NroRUC = boOrdenCompra.pintNroRUCProveedor_NRUCPR
        '            .pTPRVCL_DescripcionProveedor = boOrdenCompra.pstrDescripcionProveedor_TPRVCL
        '            .pTLFNO1_TelefonoProveedor = boOrdenCompra.pstrTelefonoProveedor_TLFNO1
        '            .pTNROFX_NroFAX = boOrdenCompra.pstrNroFAX_TNROFX
        '            .pTPRSCN_ContactoProveedor = boOrdenCompra.pstrContactoProveedor_TPRSCN
        '            .pTLFNO2_TelefonoContacto = boOrdenCompra.pstrTelefonoContacto_TLFNO2
        '            .pTEMAI3_EmailContacto = boOrdenCompra.pstrEmailContacto_TEMAI3
        '            .pTDRPRC_DireccionProveedor = boOrdenCompra.pstrDireccionProveedor_TDRPRC
        '        End With
        '        ' Realizamos la grabación del Proveedor
        '        intCodigoProveedor = 0
        '        If cProveedor.Grabar(strServidor, strUsuario, strPassword, oProveedor, intCodigoProveedor, strMensajeError) Then
        '            oOC.pCPRVCL_CodigoClienteTercero = intCodigoProveedor
        '            ' Realizamos el proceso de Registrar la Orden de Compra para luego realizar el proceso de Registro de cada Item
        '            If cOrdenCompra.Grabar(strServidor, strUsuario, strPassword, oOC, strMensajeError) Then
        '                ' Recorremos los Items del Bulto y grabamos uno x uno cada Item
        '                For Each boItemOC In boOrdenCompra.Items
        '                    ' Si la Partida Arancelaria no es vacia, se procede analiza y se graba
        '                    If boItemOC.pstrPartidaArancelaria_CPTDAR.Trim <> "" Then
        '                        oPartArencTemp = New TD_PartArancelaria
        '                        With oPartArencTemp
        '                            .pCPTDAR_PartArancelaria = boItemOC.pstrPartidaArancelaria_CPTDAR
        '                            .pTDEPTD_Detalle = boItemOC.pstrDescripcionPartidaArancelaria_TDEPTD
        '                        End With
        '                        ' Registro la Partida Arancelaria
        '                        If Not daoPartidaArancelaria.Grabar(strServidor, strUsuario, strPassword, oPartArencTemp, strMensajeError) Then
        '                            objWSErrorOC.pAddError("", strMensajeError, boOrdenCompra.pintCodigoCliente_CCLNT, boOrdenCompra.pstrNroOrdenCompra_NORCML, _
        '                                                   boItemOC.pintNroItemOrdenCompra_NRITOC)
        '                            blnResultado = False
        '                        End If
        '                    End If
        '                    ' Si no hubo errores en el registro de la Partida Arancelaria, se procede a registrar el Item
        '                    If blnResultado Then
        '                        ' Registro el Item de la Orden de Compra-
        '                        oOCItem = New TD_ItemOC
        '                        With oOCItem
        '                            .pCCLNT_CodigoCliente = boOrdenCompra.pintCodigoCliente_CCLNT
        '                            .pNORCML_NroOrdenCompra = boOrdenCompra.pstrNroOrdenCompra_NORCML
        '                            '-- Propiedades --
        '                            .pNRITOC_NroItemOC = boItemOC.pintNroItemOrdenCompra_NRITOC
        '                            .pTCITCL_CodigoCliente = boItemOC.pstrNroItemOrdenCompraCliente_TCITCL
        '                            .pTCITPR_CodigoProveedor = boItemOC.pstrNroItemOrdenCompraProveedor_TCITPR
        '                            .pQCNTIT_Cantidad = boItemOC.pdecCantidadItem_QCNTIT
        '                            .pTUNDIT_Unidad = boItemOC.pstrUnidadMedida_TUNDIT
        '                            .pTDITES_DescripcionES = boItemOC.pstrDescripcionItemES_TDITES
        '                            .pTDITIN_DescripcionIN = boItemOC.pstrDescripcionItemIN_TDITIN
        '                            .pIVUNIT_ImporteUnitario = boItemOC.pdecImporteUnitario_IVUNIT
        '                            .pFMPDME_FechaEstEntregaDte = boItemOC.pdteFechaMaxProveedorDespacha_FMPDME
        '                            .pFMPIME_FechaReqPlantaDte = boItemOC.pdteFechaMaxIngresoAlmacenEmbarque_FMPIME
        '                            .pCPTDAR_PartidaArancelaria = boItemOC.pstrPartidaArancelaria_CPTDAR
        '                            .pTLUGEN_LugarEntrega = boItemOC.pstrLugarEntrega_TLUGEN
        '                            .pTLUGOR_LugarOrigen = boItemOC.pstrLugarOrigen_TLUGOR
        '                            .pQTOLMIN_ToleranciaMin = boItemOC.pdecCantidadToleranciaMinItem_QTOLMIN
        '                            .pQTOLMAX_ToleranciaMax = boItemOC.pdecCantidadToleranciaMaxItem_QTOLMAX
        '                        End With
        '                        ' Registramos el Item asociado a la Orden de Compra
        '                        If Not cItemOrdenCompra.Grabar(strServidor, strUsuario, strPassword, oOCItem, strMensajeError) Then
        '                            ' Si hubo algún error, lo registramos en la clase que administra los errores
        '                            objWSErrorOC.pAddError("", strMensajeError, boOrdenCompra.pintCodigoCliente_CCLNT, boOrdenCompra.pstrNroOrdenCompra_NORCML, _
        '                                                   boItemOC.pintNroItemOrdenCompra_NRITOC)
        '                            blnResultado = False
        '                        End If
        '                    End If
        '                Next
        '            Else
        '                ' Si hubo algún error, lo registramos en la clase que administra los errores
        '                objWSErrorOC.pAddError("", strMensajeError, boOrdenCompra.pintCodigoCliente_CCLNT, boOrdenCompra.pstrNroOrdenCompra_NORCML, "")
        '                blnResultado = False
        '            End If
        '        Else
        '            ' Si hubo algún error, lo registramos en la clase que administra los errores
        '            objWSErrorOC.pAddError("", strMensajeError, boOrdenCompra.pintCodigoCliente_CCLNT, boOrdenCompra.pstrNroOrdenCompra_NORCML, "")
        '            blnResultado = False
        '        End If
        '    Next
        '    objSqlManager.CommitGlobalTransaction()
        '    Return blnResultado
        'End Function
#End Region
#Region " Modificar a Procedure "
        Public Function fstrObtenerNuevoCodigo(ByVal blnStatusDefinitivo As Boolean, _
                                               ByRef strMensaje As String) As String
            Dim strResultado As String = ""
            Dim strNroRegistro As String = ""
            Dim intNroRegistro As Integer = 0
            Dim strSentenciaSQL As String
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Do
                strSentenciaSQL = " Select  IFNULL(NULCTR,0)" & _
                                  " From    RZZM04 " & _
                                  " where   CTPCTR = 'ATR002'"
                Try
                    ' Llamar al procedimiento de la capa de Datos
                    strResultado = objSqlManager.ExecuteScalar(strSentenciaSQL)
                Catch ex As Exception
                    strMensaje = "No se pudo generar el correlativo de la Orden de Compra." & vbNewLine & _
                                 "Comunicarse con el Administrador del Sistema." & vbNewLine & vbNewLine & _
                                 "Lectura de la Tabla : RZZM04"
                    Return ""
                    Exit Function
                End Try
                strResultado = Right("0000000000" & strResultado, 10)
                ' Valido que el codigo no exista
                strSentenciaSQL = " Select Count(NORCML) " & _
                                  " From   RZOL38 " & _
                                  " Where  Ucase(Trim(NORCML)) = '" & strResultado & "'"
                Try
                    ' Actualizamos el Correlativo
                    strNroRegistro = objSqlManager.ExecuteScalar(strSentenciaSQL)
                    Int32.TryParse(strNroRegistro, intNroRegistro)
                Catch ex As Exception
                    strMensaje = "Error al consultar la existencia del registro..." & vbNewLine & _
                                 "Comunicarse con el Administrador del Sistema." & vbNewLine & vbNewLine & _
                                 "Lectura de la Tabla : RZOL38"
                    Return ""
                    Exit Function
                End Try
                If intNroRegistro <> 0 Or blnStatusDefinitivo Then
                    ' Actualizar el correlativo
                    strSentenciaSQL = " Update RZZM04 Set NULCTR = NULCTR + 1, " & _
                                                        " NCTRRL = NULCTR + 1, " & _
                                                        " FULTAC =  " & Date.Now.ToString("yyyyMMdd") & ", " & _
                                                        " HULTAC =  " & Date.Now.Hour * 10000 + _
                                                                        Date.Now.Minute * 100 + _
                                                                        Date.Now.Second & ", " & _
                                                        " CULUSA = '" & strUsuarioSistema & "' " & _
                                      " where   CTPCTR = 'ATR002'"
                    Try
                        ' Actualizamos el Correlativo
                        objSqlManager.ExecuteNonQuery(strSentenciaSQL)
                    Catch ex As Exception
                        strMensaje = "Error actualizando el último Correlativo.." & vbNewLine & _
                                     "Comunicarse con el Administrador del Sistema." & vbNewLine & vbNewLine & _
                                     "Lectura de la Tabla : RZZM04"
                        Return ""
                        Exit Function
                    End Try
                End If

                If Not blnStatusDefinitivo And intNroRegistro = 0 Then
                    Return strResultado
                    Exit Function
                End If
            Loop While intNroRegistro <> 0
            strMensaje = ""
            Return strResultado
        End Function
#End Region
    End Class
End Namespace