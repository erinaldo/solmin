Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.OrdenCompra
'Imports RANSA.TYPEDEF.Waybill
Imports RANSA.DATA
'Imports RANSA.DAO.WayBill
Imports RANSA.DATA.slnSOLMIN_SAT.DAO

Namespace slnSOLMIN_SAT.Almacen.Procesos
    Public Class clsAlmacen
        Inherits clsBasicClass
#Region " Tipos Definidos "
        Structure NewType_Bulto
            Dim pCodigoCliente_CCLNT As Int64
            Dim pCodigoRecepcion_CREFFW As String
            Dim pCCMPN_CodigoCompania As String
            Dim pCDVSN_CodigoDivision As String
            Dim pCPLNDV_CodigoPlanta As Decimal
        End Structure

        Structure NewType_ItemBulto
            Dim pCodigoCliente_CCLNT As Int64
            Dim pCodigoInterno_NSEQIN As Int32
            Dim pCodigoRecepcion_CREFFW As String
            Dim pCodigoIdentificacionPaquete_CIDPAQ As String
        End Structure

        Structure NewType_BultoInterfase
            Dim pCodigoCliente_CCLNT As Int64
            Dim pDocumentoEntradaSalida_DCENSA As String
        End Structure

        Structure STRUCT_BultosParaPaletizar
            Dim pCodigoCliente_CCLNT As Int64
            Dim pCodigosRecepcion_CREFFW As List(Of String)
            Dim pUsuarioModifica_CULUSA As String
        End Structure
#End Region
#Region " Atributos "
        Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
        Private Shared Function _fstrObtener_NroBulto(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                      ByVal objParametros As Parameter) As String
            Dim htResultado As Hashtable
            Dim strNroBulto As String = ""
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_NROCORR", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strNroBulto = htResultado("OU_NROBTO")
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fstrObtener_NroBulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_BULTO_NROCORR " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return strNroBulto
        End Function

        Private Shared Function _fintObtener_NroPaleta(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                       ByVal objParametros As Parameter) As Int64
            Dim htResultado As Hashtable
            Dim intNroPaleta As Int64 = 0
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PALETA_NROPALETA", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                intNroPaleta = htResultado("OU_NROPLT")
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fstrObtener_NroPaleta >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PALETA_NROPALETA " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return intNroPaleta
        End Function

        Private Shared Function _fblnRegistrar_Bulto(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                     ByVal objParametros As Parameter) As Boolean
            Dim htResultado As Hashtable
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_INS", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fblnRegistrar_Bulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_BULTO_INS " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Shared Function _fblnRegistrar_ItemBulto(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                         ByVal objParametros As Parameter) As Boolean
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_ITEM_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fblnRegistrar_ItemBulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_BULTO_ITEM_INS " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Shared Function _fblnEliminar_Bulto(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                    ByVal objParametros As Parameter) As Boolean
            Dim htResultado As Hashtable
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_DEL", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fblnEliminar_Bulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_BULTO_DEL " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Shared Function _fblnEliminar_ItemBulto(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                        ByVal objParametros As Parameter) As Boolean
            Dim htResultado As Hashtable
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_ITEM_DEL", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fblnEliminar_ItemBulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_BULTO_ITEM_DEL " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Shared Function _fblnRegistrar_Paleta(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                      ByVal objParametros As Parameter) As Boolean
            Dim htResultado As Hashtable
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PALETA_INS", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR").ToString
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << _fblnRegistrar_Paleta >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PALETA_INS " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'
        Public Shared Function fdtBuscar_MotivoRecepcion(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "ALMA_MOTREC", strCadenaBusqueda)
            dtResultado.TableName = "Motivo Recepcion"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_TipoMovimiento(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "ALMA_TIPMOV", strCadenaBusqueda)
            dtResultado.TableName = "Tipo de Movimiento"
            Return dtResultado
        End Function

        Public Shared Function fdtBuscar_Paletizado(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoBusqueda(strMensajeError, "ALMA_PLTZDO", strCadenaBusqueda)
            dtResultado.TableName = "Paletizado"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListarBultos(ByVal objFiltrosParaBultos As clsFiltrosParaBultos, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            With objFiltrosParaBultos
                dtResultado = fdtResultadoConsulta(strMensajeError, "ALMA_LSTBTO_01", .pintCodigoCliente_CCLNT, .pstrCodigoRecepcion_CREFFW, _
                                                   .pstrNroPaletizado_NROPLT, .pstrFechaRecepcionInicio_FREFFW, .pstrFechaRecepcionFinal_FREFFW, _
                                                   .pstrUbicacionReferencial_TUBRFR, .pstrCriterioLote_CRTLTE)
            End With
            dtResultado.TableName = "ListaDeBultos"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_ItemsBulto(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strBulto As String, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As DataTable
            Dim dtResultado As DataTable = Nothing
            'clsFiltrosParaItemsBulto
            dtResultado = fdtResultadoConsulta(strMensajeError, "SAT_ALMA_LSTITM_01", strCliente, strBulto, strCompania, strDivision, dblPlanta)
            dtResultado.Columns.Add("X_MARRET")
            For Each oDr As DataRow In dtResultado.Rows
                If Not oDr.Item("MARRET").ToString.Trim.Equals("") Then
                    oDr.Item("X_MARRET") = "X"
                End If
            Next
            dtResultado.TableName = "ListaDeItemsBulto"
            Return dtResultado
        End Function
        Public Shared Function fdtListar_ItemsBulto_HT(ByRef strMensajeError As String, ByVal htFiltro As Hashtable) As DataTable
            Dim dtResultado As DataTable = Nothing
            'ENVIO LOS PARAMETROS DEL HASHTABLE
            dtResultado = fdtResultadoConsulta(strMensajeError, "SAT_ALMA_LSTITM_01", htFiltro.Item("CCLNT"), _
                                                htFiltro.Item("CREFFW"), htFiltro.Item("CCMPN"), htFiltro.Item("CDVSN"), htFiltro.Item("CPLNDV"))
            dtResultado.Columns.Add("X_MARRET")
            For Each oDr As DataRow In dtResultado.Rows
                If Not oDr.Item("MARRET").ToString.Trim.Equals("") Then
                    oDr.Item("X_MARRET") = "X"
                End If
            Next
            dtResultado.TableName = "ListaDeItemsBulto"
            Return dtResultado
        End Function
        Public Shared Function fdtListar_ItemsBultoSaldo(ByRef strMensajeError As String, ByVal strCliente As String, ByVal strBulto As String, _
                                                            ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double, _
                                                            ByVal strItemsSeleccionados As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SAT_ALMA_LSTITM_02", strCliente, strBulto, strItemsSeleccionados, strCompania, strDivision, dblPlanta)
            dtResultado.TableName = "dtBultoItemsSaldo"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_MotivoRecepcionWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                          ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_ALMA_MOTREC_01")
            dtResultado.TableName = "MotivoRecepcion"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_TipoMovimientoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                          ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_ALMA_TIPMOV_01")
            dtResultado.TableName = "TipoDeMovimiento"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_StockBultosWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                           ByVal strCliente As String, ByVal strBulto As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_ALMA_LBTITM_01", strCliente, strBulto)
            dtResultado.TableName = "StockBultos"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_StockPaletasWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                        ByVal strCliente As String, ByVal strNroPaleta As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_ALMA_LSTPLT_01", strCliente, strNroPaleta)
            dtResultado.TableName = "StockPaletas"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_PaletasSinEtiquetas(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim objSqlManager As SqlManager = New SqlManager
            Dim dtResultado As DataTable = Nothing
            dtResultado = daoEtiquetasBarras.fdtListar_PaletaSinEtiquetas(objSqlManager, intCliente, strMensajeError)
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return dtResultado
        End Function

        Public Shared Function fdtListar_BultosSinEtiquetas(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim objSqlManager As SqlManager = New SqlManager
            Dim dtResultado As DataTable = Nothing
            dtResultado = daoEtiquetasBarras.fdtListar_BultosSinEtiquetas(objSqlManager, intCliente, strMensajeError)
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Function fstrObtener_NroBulto(ByRef strMensajeError As String, ByVal blnStatusDefinitivo As Boolean, ByVal dblCliente As Double, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCMPN", strCompania)
            objParametros.Add("IN_CDVSN", strDivision)
            objParametros.Add("IN_CPLNDV", dblPlanta)
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", "")
            objParametros.Add("IN_CCLNT", dblCliente)
            objParametros.Add("OU_NROBTO", "", ParameterDirection.Output)
            Return _fstrObtener_NroBulto(strMensajeError, objSqlManager, objParametros)
        End Function

   

        Public Function fintObtener_NroPaleta(ByRef strMensajeError As String, ByVal blnStatusDefinitivo As Boolean) As Int64
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_NROPLT", 0, ParameterDirection.Output)
            Return _fintObtener_NroPaleta(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Shared Function fintObtener_NroPaletaWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                       ByRef strMensajeError As String, ByVal blnStatusDefinitivo As Boolean) As Int64
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
            Dim objParametros As Parameter = New Parameter
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", strUsuario)
            objParametros.Add("OU_NROPLT", 0, ParameterDirection.Output)
            Return _fintObtener_NroPaleta(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Shared Function fobjObtener_InfRepacking(ByRef strMensajeError As String, ByVal strCliente As Int64, ByVal strBulto As String, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As clsInfRepacking
            Dim dtResultado As DataTable = Nothing
            Dim objInfRepacking As clsInfRepacking = New clsInfRepacking

            dtResultado = fdtResultadoConsulta(strMensajeError, "SAT_ALMA_LSTBTO_02", strCliente, strBulto, strCompania, strDivision, dblPlanta)
            If dtResultado.Rows.Count > 0 Then
                With objInfRepacking
                    Int64.TryParse("" & dtResultado.Rows(0).Item("CCLNT"), .pintCodigoCliente_CCLNT)
                    .pstrCodigoRecepcion_CREFFW = ("" & dtResultado.Rows(0).Item("CREFFW")).ToString.Trim
                    Date.TryParse("" & dtResultado.Rows(0).Item("FREFFW"), .pdteFechaRecepcionAlmacen_FREFFW)
                    .pstrCodigoBultoOrigen_CBLTOR = ("" & dtResultado.Rows(0).Item("CBLTOR")).ToString.Trim
                    Decimal.TryParse("" & dtResultado.Rows(0).Item("QREFFW"), .pdecCantidadRecibida_QREFFW)
                    .pstrTipoBulto_TIPBTO = ("" & dtResultado.Rows(0).Item("TIPBTO")).ToString.Trim
                    Decimal.TryParse("" & dtResultado.Rows(0).Item("QPSOBL"), .pdecPesoBulto_QPSOBL)
                    .pstrUnidadPeso_TUNPSO = ("" & dtResultado.Rows(0).Item("TUNPSO")).ToString.Trim
                    Decimal.TryParse("" & dtResultado.Rows(0).Item("QVLBTO"), .pdecVolumenBulto_QVLBTO)
                    .pstrUnidadVolumen_TUNVOL = ("" & dtResultado.Rows(0).Item("TUNVOL")).ToString.Trim
                    .pstrUbicacionReferencial_TUBRFR = ("" & dtResultado.Rows(0).Item("TUBRFR")).ToString.Trim
                    Decimal.TryParse("" & dtResultado.Rows(0).Item("QAROCP"), .pdecCantidadAreaOcupada_QAROCP)
                    .pstrDescripcionWayBill_DESCWB = ("" & dtResultado.Rows(0).Item("DESCWB")).ToString.Trim
                End With
            End If
            Return objInfRepacking
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'
        Public Shared Function fdtDefecto_MotivoRecepcion(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "ALMA_MOTREC_01")
            dtResultado.TableName = "Motivo Recepción"
            Return dtResultado
        End Function

        Public Shared Function fdtDefecto_TipoMovimiento(ByRef strMensajeError As String, ByVal blnStatusBultoNormal As Boolean) As DataTable
            Dim dtResultado As DataTable = Nothing

            If blnStatusBultoNormal Then
                dtResultado = fdtResultadoConsulta(strMensajeError, "ALMA_TIPMOV_01")
            Else
                dtResultado = fdtResultadoConsulta(strMensajeError, "ALMA_TIPMOV_02")
            End If
            dtResultado.TableName = "Tipo de Movimiento"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_Bulto(ByRef strMensajeError As String, ByVal objBulto As clsPrimaryKey_Bulto) As Boolean
            Return fblnExisteInformacion(strMensajeError, "ALMA_EXBULTO", objBulto.pintCodigoCliente_CCLNT.ToString, objBulto.pstrCodigoRecepcion_CREFFW)
        End Function

        Public Shared Function fblnExiste_ItemBulto(ByRef strMensajeError As String, ByVal objItemBulto As clsPrimaryKey_ItemBulto) As Boolean
            Return fblnExisteInformacion(strMensajeError, "ALMA_ITEMBTO", objItemBulto.pintCodigoCliente_CCLNT.ToString, objItemBulto.pstrCodigoRecepcion_CREFFW, _
                                         objItemBulto.pstrCodigoIdentificacionPaquete_CIDPAQ)
        End Function

        Public Shared Function fblnExiste_ItemsBulto(ByRef strMensajeError As String, ByVal objBulto As clsPrimaryKey_Bulto) As Boolean
            Return fblnExisteInformacion(strMensajeError, "ALMA_EITSBTO", objBulto.pintCodigoCliente_CCLNT.ToString, objBulto.pstrCodigoRecepcion_CREFFW)
        End Function

        Public Shared Function fblnExiste_BultoParaTransferir(ByRef strMensajeError As String, ByVal strNroDocumentoES As String) As Boolean
            Return fblnExisteInformacion(strMensajeError, "ALMA_EBTOPTR", strNroDocumentoES)
        End Function

        Public Shared Function fblnExiste_BultosSinEtiqueta(ByRef strMensajeError As String, ByVal intCliente As Int64) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            blnResultado = daoEtiquetasBarras.fblnExiste_BultosSinEtiqueta(objSqlManager, intCliente, strMensajeError)
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return blnResultado
        End Function

        Public Shared Function fblnExiste_PaletasSinEtiqueta(ByRef strMensajeError As String, ByVal intCliente As Int64) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            blnResultado = daoEtiquetasBarras.fblnExiste_PaletasSinEtiqueta(objSqlManager, intCliente, strMensajeError)
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return blnResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnRealizar_TransferenciaBulto(ByVal intCliente As Int64, ByVal strNroDocumentoES As String, _
                                                        ByRef strCodigoBulto As String, ByRef strMensajeError As String, _
                                                        ByVal strCCMPN As String, ByVal strCDVSN As String, ByVal dblCPLNDV As Double) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_DCENSA", strNroDocumentoES)
            objParametros.Add("OUT_CREFFW", "", ParameterDirection.Output)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("IN_CCMPN", strCCMPN)
            objParametros.Add("IN_CDVSN", strCDVSN)
            objParametros.Add("IN_CPLNDV", dblCPLNDV)
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_BULTO_TRA", objParametros)
                Dim htResultado As Hashtable
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strCodigoBulto = htResultado("OUT_CREFFW")
            Catch ex As Exception
                blnResultado = False
                strMensajeError = "Error producido en la funcion : << fblnRealizar_TransferenciaBulto >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnRegistrar_BultoRepacking(ByVal objBultoRepacking As clsBultoRepacking, ByRef strMensajeError As String) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Variables para obtener el valor devuelto por el procedure 
            Dim htResultado As Hashtable
            Dim strNroBulto As String = ""
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objBultoRepacking
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CCMPN", .pstrCodigoCompania_CCMPN)
                objParametros.Add("IN_CDVSN", .pstrCodigoDivision_CDVSN)
                objParametros.Add("IN_CPLNDV", .pdblCodigoPlanta_CPLNDV)
                objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                objParametros.Add("IN_NSEQIN", .pdblCorrelativo_NSEQIN)
                objParametros.Add("IN_FREFFW", .pstrFechaRecepcionAlmacen_FNum_FREFFW)
                objParametros.Add("IN_CBLTOR", .pstrCodigoBultoOrigen_CBLTOR)
                objParametros.Add("IN_TIPBTO", .pstrTipoBulto_TIPBTO)
                objParametros.Add("IN_QREFFW", .pdecCantidadRecibida_QREFFW)
                objParametros.Add("IN_QAROCP", .pdecCantidadAreaOcupada_QAROCP)
                objParametros.Add("IN_QPSOBL", .pdecPesoBulto_QPSOBL)
                objParametros.Add("IN_QVLBTO", .pdecVolumenBulto_QVLBTO)
                objParametros.Add("IN_DESCWB", .pstrDescripcionWayBill_DESCWB)
                objParametros.Add("IN_TUBRFR", .pstrUbicacionReferencial_TUBRFR)



                objParametros.Add("IN_USUARI", strUsuarioSistema)
                objParametros.Add("OU_CREFFW", "", ParameterDirection.Output)
            End With
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_REPACKING_INS", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strNroBulto = htResultado("OU_CREFFW")
                If strNroBulto <> objBultoRepacking.pstrCodigoRecepcion_CREFFW Then
                    blnResultado = False
                    strMensajeError = "Nro. de Bulto ya fue registrado. "
                Else
                    For Each objTemp As clsItemBultoRepacking In objBultoRepacking.plstItemBultoRepacking
                        objParametros = New Parameter
                        objParametros.Add("IN_CCLNT", objBultoRepacking.pintCodigoCliente_CCLNT)
                        objParametros.Add("IN_CREFFW", objBultoRepacking.pstrCodigoRecepcion_CREFFW)
                        objParametros.Add("IN_NSEQIN", objBultoRepacking.pdblCorrelativo_NSEQIN)
                        objParametros.Add("IN_CBLTOR", objBultoRepacking.pstrCodigoBultoOrigen_CBLTOR)
                        objParametros.Add("IN_CIDPAQ", objTemp.pstrCodigoIdentificacionPaquete_CIDPAQ)
                        objParametros.Add("IN_NORCML", objTemp.pstrNroOrdenCompra_NORCML)
                        objParametros.Add("IN_NRITOC", objTemp.pintNroItemOrdenCompra_NRITOC)
                        objParametros.Add("IN_QBLTRP", objTemp.pdecCantidadRepacking_QBLTRP)
                        objParametros.Add("IN_TDAITM", objTemp.Observaciones_Item_Bulto_TDAITM)
                        objParametros.Add("IN_USUARI", strUsuarioSistema)
                        objParametros.Add("IN_CCMPN", objTemp.pstrCodigoCompania_CCMPN)
                        objParametros.Add("IN_CDVSN", objTemp.pstrCodigoDivision_CDVSN)
                        objParametros.Add("IN_CPLNDV", objTemp.pdblCodigoPlanta_CPLNDV)
                        ' Llamada al procedure de inserción de items
                        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_REPACKING_ITEM_INS", objParametros)
                    Next

                    For Each objSubTemp As clsSubItemBultoRepacking In objBultoRepacking.plstSubItemBultoRepacking
                        objParametros = New Parameter
                        objParametros.Add("IN_CCLNT", objBultoRepacking.pintCodigoCliente_CCLNT)
                        objParametros.Add("IN_CREFFW", objBultoRepacking.pstrCodigoRecepcion_CREFFW)
                        objParametros.Add("IN_CBLTOR", objBultoRepacking.pstrCodigoBultoOrigen_CBLTOR)
                        objParametros.Add("IN_CIDPAQ", objSubTemp.pstrCodigoIdentificacionPaquete_CIDPAQ)
                        objParametros.Add("IN_NORCML", objSubTemp.pstrNroOrdenCompra_NORCML)
                        objParametros.Add("IN_NRITOC", objSubTemp.pintNroItemOrdenCompra_NRITOC)
                        objParametros.Add("IN_SBITOC", objSubTemp.pstrCodigoSubItem_SBITOC)

                        objParametros.Add("IN_QCNRCP", objSubTemp.pdecCantidadRepacking_QCNRCP)
                        objParametros.Add("IN_USUARI", strUsuarioSistema)
                        objParametros.Add("IN_CCMPN", objSubTemp.pstrCodigoCompania_CCMPN)
                        objParametros.Add("IN_CDVSN", objSubTemp.pstrCodigoDivision_CDVSN)
                        objParametros.Add("IN_CPLNDV", objSubTemp.pdblCodigoPlanta_CPLNDV)
                        ' Llamada al procedure de inserción de items
                        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_REPACKING_SUBITEM_INS", objParametros)
                    Next
                End If
            Catch ex As Exception
                blnResultado = False
                strMensajeError = "Error producido en la funcion : << fblnRegistrar_BultoRepacking >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return strNroBulto
        End Function

        Public Function fblnRegistrar_Bulto(ByVal objBultoSAT As clsBultoSAT, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objBultoSAT
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                objParametros.Add("IN_QREFFW", .pdecCantidadRecibida_QREFFW)
                objParametros.Add("IN_TIPBTO", .pstrTipoBulto_TIPBTO)
                objParametros.Add("IN_QPSOBL", .pdecPesoBulto_QPSOBL)
                objParametros.Add("IN_TUNPSO", .pstrUnidadPeso_TUNPSO)
                objParametros.Add("IN_QVLBTO", .pdecVolumenBulto_QVLBTO)
                objParametros.Add("IN_TUNVOL", .pstrUnidadVolumen_TUNVOL)
                objParametros.Add("IN_TUBRFR", .pstrUbicacionReferencial_TUBRFR)
                objParametros.Add("IN_QAROCP", .pdecCantidadAreaOcupada_QAROCP)
                objParametros.Add("IN_DESCWB", .pstrDescripcionWayBill_DESCWB)
                objParametros.Add("IN_SMTRCP", .pstrMotivoRecepcion_SMTRCP)
                objParametros.Add("IN_SSNCRG", .pstrSentidoCarga_SSNCRG)
                objParametros.Add("IN_NTCKPS", .pintNroTicketBalanza_NTCKPS)
                objParametros.Add("IN_STPING", .pstrTipoMovimiento_STPING)
                objParametros.Add("IN_STPIMP", .pstrStatusImpEtiqBarra)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
                objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
            End With
            Return _fblnRegistrar_Bulto(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Function fblnEliminar_Bulto(ByVal strCliente As String, ByVal strBulto As String, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", strCliente)
            objParametros.Add("IN_CREFFW", strBulto)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
            Return _fblnEliminar_Bulto(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Function fblnEliminar_ItemBulto(ByVal strCliente As String, ByVal strBulto As String, ByVal strItemPaq As String, _
                                               ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_CCLNT", strCliente)
            objParametros.Add("IN_CREFFW", strBulto)
            objParametros.Add("IN_CIDPAQ", strItemPaq)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
            Return _fblnEliminar_ItemBulto(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Shared Function fblnRegistrar_BultosWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                      ByVal lstWSBultos As clsWSBultos, ByRef objWSErrorBulto As clsWSErrorBulto) As Boolean
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
            Dim objParametros As Parameter = Nothing
            Dim objWSBulto As clsWSBulto
            Dim objWSItemBulto As clsWSItemBulto
            Dim strMensajeError As String = ""
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Recorremos todas las Paletas
            For Each objWSBulto In lstWSBultos.plstWSBultos
                objParametros = New Parameter
                ' Recorremos los Bultos y grabamos uno x uno cada Bulto
                With objWSBulto
                    objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                    objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                    objParametros.Add("IN_QREFFW", .pdecCantidadRecibida_QREFFW)
                    objParametros.Add("IN_TIPBTO", .pstrTipoBulto_TIPBTO)
                    objParametros.Add("IN_QPSOBL", .pdecPesoBulto_QPSOBL)
                    objParametros.Add("IN_TUNPSO", .pstrUnidadPeso_TUNPSO)
                    objParametros.Add("IN_QVLBTO", .pdecVolumenBulto_QVLBTO)
                    objParametros.Add("IN_TUNVOL", .pstrUnidadVolumen_TUNVOL)
                    objParametros.Add("IN_TUBRFR", .pstrUbicacionReferencial_TUBRFR)
                    objParametros.Add("IN_QAROCP", .pdecCantidadAreaOcupada_QAROCP)
                    objParametros.Add("IN_DESCWB", .pstrDescripcionWayBill_DESCWB)
                    objParametros.Add("IN_SMTRCP", .pstrMotivoRecepcion_SMTRCP)
                    objParametros.Add("IN_SSNCRG", .pstrSentidoCarga_SSNCRG)
                    objParametros.Add("IN_NTCKPS", .pintNroTicketBalanza_NTCKPS)
                    objParametros.Add("IN_STPING", .pstrTipoMovimiento_STPING)
                    objParametros.Add("IN_STPIMP", "N")
                    objParametros.Add("IN_USUARI", strUsuario)
                    objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
                    ' Realizamos el proceso de Registrar el Bulto para luego realizar el proceso de Registrar cada Item
                    If _fblnRegistrar_Bulto(strMensajeError, objSqlManager, objParametros) Then
                        ' Recorremos los Items del Bulto y grabamos uno x uno cada Item
                        For Each objWSItemBulto In objWSBulto.plstWSItemsBulto
                            objParametros = New Parameter
                            ' Ingresamos los parametros del Procedure
                            objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                            objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                            objParametros.Add("IN_NORCML", .pstrNroOrdenCompra_NORCML)
                            objParametros.Add("IN_NRITOC", objWSItemBulto.pintNroItemOrdenCompra_NRITOC)
                            objParametros.Add("IN_NFACPR", .pstrNroFacturaProveedor_NFACPR)
                            objParametros.Add("IN_FFACPR", .pintFechaFacturaProveedor_FFACPR)
                            objParametros.Add("IN_NGRPRV", .pstrNroGuiaRemisionProveedor_NGRPRV)
                            objParametros.Add("IN_QBLTSR", objWSItemBulto.pdecCantidadRecibida_QCNREC)
                            objParametros.Add("IN_TDAITM", objWSItemBulto.pstrObservacionItemBulto_TDAITM)
                            objParametros.Add("IN_USUARI", strUsuario)
                            ' Registramos el Bulto asociado a la Paleta
                            If Not _fblnRegistrar_ItemBulto(strMensajeError, objSqlManager, objParametros) Then
                                ' Si hubo algún error, lo registramos en la clase que administra los errores
                                objWSErrorBulto.pAddError("", strMensajeError, .pstrNroOrdenCompra_NORCML, .pstrCodigoRecepcion_CREFFW, _
                                                         .pintCodigoCliente_CCLNT, objWSItemBulto.pintNroItemOrdenCompra_NRITOC)
                                blnResultado = False
                            End If
                        Next
                    Else
                        ' Si hubo algún error, lo registramos en la clase que administra los errores
                        objWSErrorBulto.pAddError("", strMensajeError, .pstrNroOrdenCompra_NORCML, .pstrCodigoRecepcion_CREFFW, .pintCodigoCliente_CCLNT, "")
                        blnResultado = False
                    End If
                End With
            Next
            Return blnResultado
        End Function

        Public Shared Function fblnRegistrar_PaletasWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                       ByVal lstWSPaletas As clsWSPaletas, ByRef objWSErrorPaletizado As clsWSErrorPaletizado) As Boolean
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
            Dim objParametros As Parameter = Nothing
            Dim objWSPaleta As clsWSPaleta
            Dim objWSBultoPorPaleta As clsWSBultoPorPaleta
            Dim strMensajeError As String = ""
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Recorremos todas las Paletas
            For Each objWSPaleta In lstWSPaletas.plstWSPaletas
                ' Recorremos todos los Bultos asociados a la paleta
                For Each objWSBultoPorPaleta In objWSPaleta.plstWSBultosPorPaleta
                    objParametros = New Parameter
                    ' Ingresamos los parametros del Procedure
                    With objWSBultoPorPaleta
                        objParametros.Add("IN_CCLNT", objWSPaleta.pintCodigoCliente_CCLNT)
                        objParametros.Add("IN_NROPLT", objWSPaleta.pstrNroPaleta_NROPLT)
                        objParametros.Add("IN_CRTLTE", objWSPaleta.pstrCriterioLote_CRTLTE)
                        objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                        objParametros.Add("IN_QREFFW", .pdecCantidadRecibida_QREFFW)
                        objParametros.Add("IN_QREPLT", .pdecCantidadPorPaleta_QREPLT)
                        objParametros.Add("IN_USUARI", strUsuario)
                        objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
                        ' Registramos el Bulto asociado a la Paleta
                        If Not _fblnRegistrar_Paleta(strMensajeError, objSqlManager, objParametros) Then
                            ' Si hubo algún error, lo registramos en la clase que administra los errores
                            objWSErrorPaletizado.pAddError("", strMensajeError, objWSPaleta.pintCodigoCliente_CCLNT, objWSPaleta.pstrNroPaleta_NROPLT, .pstrCodigoRecepcion_CREFFW)
                            blnResultado = False
                        End If
                    End With
                Next
            Next
            Return blnResultado
        End Function

        Public Function fblnEliminar_BultoPaleta(ByVal intCliente As Int64, ByVal intNroPaleta As Int64, ByVal strBulto As String, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Variables para obtener el valor devuelto por el procedure 
            Dim htResultado As Hashtable
            Dim strNroBulto As String = ""
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            'With objBultoRepacking
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_NROPLT", intNroPaleta)
            objParametros.Add("IN_CREFFW", strBulto)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_CREFFW", "", ParameterDirection.Output)
            'End With
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PALETA_DEL", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                blnResultado = False
                'strMensajeError = "Error producido en la funcion : << fblnEliminar_BultoPaleta >> de la clase << clsAlmacen >> " & vbNewLine & _
                '                  "Stored Procedure : SP_SOLMIN_SA_SAT_PALETA_DEL " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message

                strMensajeError = ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnEliminar_BultoPaleta_V2(ByVal intCliente As Int64, ByVal intNroPaleta As Int64, ByVal strBulto As String, ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Variables para obtener el valor devuelto por el procedure 
            'Dim htResultado As Hashtable
            Dim strNroBulto As String = ""
            Dim dt As New DataTable
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            'With objBultoRepacking
            objParametros.Add("IN_CCLNT", intCliente)
            objParametros.Add("IN_NROPLT", intNroPaleta)
            objParametros.Add("IN_CREFFW", strBulto)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            'objParametros.Add("OU_CREFFW", "", ParameterDirection.Output)
            'End With
            Try
                dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_PALETA_DEL_V2", objParametros)
                strMensajeError = ""
                For Each ITEM As DataRow In dt.rows
                    If ITEM("STATUS") = "E" Then
                        strMensajeError = strMensajeError & ITEM("OBSRESULT") & Chr(10)
                    End If
                Next
                ' Obteniendo los valores devueltos
                'htResultado = objSqlManager.ParameterCollection
                'strMensajeError = htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                blnResultado = False
                'strMensajeError = "Error producido en la funcion : << fblnEliminar_BultoPaleta >> de la clase << clsAlmacen >> " & vbNewLine & _
                '                  "Stored Procedure : SP_SOLMIN_SA_SAT_PALETA_DEL " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message

                strMensajeError = ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function


        Public Function fblnRegistar_PaletaEtiquetada(ByVal intCliente As Int64, ByVal lstPaletas As List(Of Int64), ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim oPaleta As daoEtiquetasBarras.TD_PaletaParaEtiquetar
            Dim intNroPaleta As Int64 = 0
            Dim blnResultado As Boolean = True
            ' Inciamos el proceso
            objSqlManager.TransactionController(TransactionType.Manual)
            objSqlManager.BeginGlobalTransaction()
            For Each intNroPaleta In lstPaletas
                oPaleta = New daoEtiquetasBarras.TD_PaletaParaEtiquetar
                With oPaleta
                    .pintCliente = intCliente
                    .pintNroPaleta = intNroPaleta
                    .pstrUsuario = strUsuarioSistema
                End With
                If Not daoEtiquetasBarras.fblnRegistrar_PaletaEtiquetada(objSqlManager, oPaleta, strMensajeError) Then
                    objSqlManager.RollBackGlobalTransaction()
                    blnResultado = False
                    Exit For
                End If
            Next
            If blnResultado Then objSqlManager.CommitGlobalTransaction()
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return blnResultado
        End Function

        Public Function fblnRegistar_BultoEtiquetada(ByVal intCliente As Int64, ByVal lstBultos As List(Of String), ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim oBulto As daoEtiquetasBarras.TD_BultoParaEtiquetar
            Dim strBultoTemp As String = ""
            Dim blnResultado As Boolean = True
            ' Inciamos el proceso
            objSqlManager.TransactionController(TransactionType.Manual)
            objSqlManager.BeginGlobalTransaction()
            For Each strBultoTemp In lstBultos
                oBulto = New daoEtiquetasBarras.TD_BultoParaEtiquetar
                With oBulto
                    .pintCliente = intCliente
                    .pstrBulto = strBultoTemp
                    .pstrUsuario = strUsuarioSistema
                End With
                If Not daoEtiquetasBarras.fblnRegistrar_BultoEtiquetado(objSqlManager, oBulto, strMensajeError) Then
                    objSqlManager.RollBackGlobalTransaction()
                    blnResultado = False
                    Exit For
                End If
            Next
            If blnResultado Then objSqlManager.CommitGlobalTransaction()
            objSqlManager.Dispose()
            objSqlManager = Nothing
            Return blnResultado
        End Function

        Public Shared Function flstrEtiqueta_Bulto(ByVal intCliente As Int64, ByVal strBulto As String, ByVal blnStNroEtiqSegunBulto As Boolean, _
                                                   ByVal intNroCopias As Int32, ByRef strMensajeError As String) As List(Of String)
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Return daoEtiquetasBarras.flstrEtiquetas_Bulto(objSqlManager, intCliente, strBulto, blnStNroEtiqSegunBulto, intNroCopias, strMensajeError)
        End Function

        Public Shared Function flstrEtiqueta_Paleta(ByVal intCliente As Int64, ByVal intNroPaleta As Int64, ByVal intNroCopias As Int32, _
                                                    ByRef strMensajeError As String) As List(Of String)
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Return daoEtiquetasBarras.flstrEtiquetas_Paleta(objSqlManager, intCliente, intNroPaleta, intNroCopias, strMensajeError)
        End Function

        Public Shared Function flstrEtiquetas_SecuenciaBultos(ByVal intCliente As Int64, ByVal strPrefijo As String, ByVal intInicial As Int64, _
                                                              ByVal intFinal As Int64, ByVal intNroCopias As Int32, ByRef strMensajeError As String) As List(Of String)
            Dim objSqlManager As SqlManager = New SqlManager
            objSqlManager.TransactionController(TransactionType.Automatic)
            Return daoEtiquetasBarras.flstrEtiquetas_SecuenciaBultos(objSqlManager, intCliente, strPrefijo, intInicial, intFinal, intNroCopias, strMensajeError)
        End Function

        ''' <summary>
        ''' Reporte Receiving 
        ''' </summary>
        ''' <param name="oBulto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function fdtReporteMaterialReceivingReport(ByVal oBulto As daoEtiquetasBarras.TD_BultoParaEtiquetar) As TipoDato_ResultaReporte
            Dim objTemp As TipoDato_ResultaReporte = New TipoDato_ResultaReporte
            Dim dstTemp As DataSet = Nothing
            Dim rptTemp As CrystalDecisions.CrystalReports.Engine.ReportDocument
            dstTemp = daoEtiquetasBarras.fdtReporteMaterialReceivingReport(oBulto).Copy
            If dstTemp.Tables.Count > 0 Then
                rptTemp = New rptReceivingReport
                dstTemp.Tables(0).TableName = "MaterialReport"
                If dstTemp.Tables(0).Rows.Count >= 0 Then
                    Dim intCantidadRows As Integer = 0
                    Dim intCantidadLineasAgregar As Integer
                    Dim oDr As DataRow
                    Dim strItem As String = ""
                    For Each oDr2 As DataRow In dstTemp.Tables(0).Rows
                        If oDr2.Item("NRITOC") <> strItem Then
                            intCantidadRows += 1
                            strItem = oDr2.Item("NRITOC")
                        End If
                        If Not oDr2.Item("SBITOC").ToString.Trim.Equals("") Then
                            intCantidadRows += 1
                        End If
                    Next
                    intCantidadLineasAgregar = 25 * (-1) * (Math.Floor(-intCantidadRows / 25)) - intCantidadRows
                    If intCantidadLineasAgregar = 0 Then
                        For intRows As Integer = 0 To 24
                            oDr = dstTemp.Tables(0).NewRow
                            If intRows = 0 Then
                                oDr.Item(0) = 0
                                oDr.Item("NRITOC") = "-------"
                                oDr.Item("QBLTSR") = "-------"
                                oDr.Item("TDITES") = "--------------------------------------------------------------------------------------------------------------"
                                oDr.Item("TLUGEN") = "----------------------------------------------"
                            Else
                                oDr.Item(0) = 0
                            End If
                            dstTemp.Tables(0).Rows.Add(oDr)
                        Next
                    Else
                        For intRows As Integer = 0 To intCantidadLineasAgregar - 1
                            oDr = dstTemp.Tables(0).NewRow
                            If intRows = 0 Then
                                oDr.Item(0) = 0
                                oDr.Item("NRITOC") = "-------"
                                oDr.Item("QBLTSR") = "-------"
                                oDr.Item("TDITES") = "--------------------------------------------------------------------------------------------------------------"
                                oDr.Item("TLUGEN") = "----------------------------------------------"
                            Else
                                oDr.Item(0) = 0 ' intRows
                                oDr.Item("OCITEM") = "P" & intRows
                            End If

                            oDr.Item("FINGAL") = dstTemp.Tables(0).Rows(0).Item("FINGAL")
                            dstTemp.Tables(0).Rows.Add(oDr)
                        Next
                    End If

                End If
                rptTemp.SetDataSource(dstTemp.Tables(0))
                rptTemp.Refresh()
                ' Ingresamos parametros adicionales
                rptTemp.SetParameterValue("pUsuario", oBulto.pstrUsuario)
                ' Generamos el Nuevo Tipo de Datos
                objTemp.add_Tables(dstTemp)
                objTemp.pReporte = rptTemp
            End If
            'Return objTemp
            Return objTemp
        End Function

        ''' <summary>
        ''' obtiene parcial de la orden de compra 
        ''' </summary>
        ''' <returns>Último parcial de la orden de compra más uno</returns>
        ''' <remarks></remarks>
        Public Function fstrObtener_NroParcial(ByVal strOrdeCompra As String, ByVal dblCliente As Double, ByRef strMensajeError As String) As String
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim htResultado As Hashtable
            Dim strNroParcial As String = ""
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            'With objBultoRepacking
            objParametros.Add("IN_NORCML", strOrdeCompra)
            objParametros.Add("IN_CCLNT", dblCliente)
            objParametros.Add("OUT_PARCIAL", "", ParameterDirection.Output)
            'End With
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_OBTENER_PARCIAL_DE_OC", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strNroParcial = htResultado("OUT_PARCIAL")
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fdblNroParcial >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Stored Procedure : SP_SOLMIN_SA_SAT_OBTENER_PARCIAL_DE_OC " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return strNroParcial

        End Function

#End Region

#Region " Modificar a Procedure "
        Public Function fblnObtenerBulto(ByRef obeBultoFiltro As beBulto) As beBulto
            Dim dtResultado As DataTable
            Dim objParametros As Parameter = New Parameter
            Dim obeBulto As New beBulto
            Dim objSqlManager As SqlManager = New SqlManager()
            objSqlManager.TransactionController(TransactionType.Automatic)



            objParametros.Add("PSCCMPN", obeBultoFiltro.PSCCMPN)
            objParametros.Add("PSCDVSN", obeBultoFiltro.PSCDVSN)
            objParametros.Add("PNCPLNDV", obeBultoFiltro.PNCPLNDV)
            objParametros.Add("PNCCLNT", obeBultoFiltro.PNCCLNT)
            objParametros.Add("PSCREFFW", obeBultoFiltro.PSCREFFW.ToString.Trim)
            objParametros.Add("PNNSEQIN", obeBultoFiltro.PNNSEQIN)
            Try
                dtResultado = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_DATOS_BULTO", objParametros)
            Catch ex As Exception
                objSqlManager = Nothing
                obeBulto.PSERROR = "Se produjo un error en la Lectura de la Base de Datos" & vbNewLine & _
                                  "para la Obtención del Bulto."
                Return obeBulto
            End Try

            If dtResultado.Rows.Count <> 1 Then
                obeBulto.PSERROR = "El resultado de la consulta para la Obtención del Item del Bulto" & vbNewLine & _
                                  "devolvió mas de un registro."
                Return obeBulto
            End If

            Try
                With obeBulto
                    '.pCodigoCliente_CCLNT = varBulto.pCodigoCliente_CCLNT
                    .PSCREFFW = dtResultado.Rows(0).Item("CREFFW").ToString.Trim
                    .PNFREFFW = dtResultado.Rows(0).Item("FREFFW")
                    .PNFSLFFW = dtResultado.Rows(0).Item("FSLFFW")  ' CType(strFecha, Date)
                    .PSCBLTOR = dtResultado.Rows(0).Item("CBLTOR").ToString.Trim
                    .PNQREFFW = dtResultado.Rows(0).Item("QREFFW")
                    .PSTIPBTO = dtResultado.Rows(0).Item("TIPBTO").ToString.Trim
                    .PNQPSOBL = dtResultado.Rows(0).Item("QPSOBL")
                    .PSTUNPSO = dtResultado.Rows(0).Item("TUNPSO").ToString.Trim
                    .PNQVLBTO = dtResultado.Rows(0).Item("QVLBTO")
                    .PSTUNVOL = dtResultado.Rows(0).Item("TUNVOL").ToString.Trim
                    .PNQMTALT = dtResultado.Rows(0).Item("QMTALT")
                    .PNQMTANC = dtResultado.Rows(0).Item("QMTANC")
                    .PNQMTLRG = dtResultado.Rows(0).Item("QMTLRG")
                    .PSSSTINV = dtResultado.Rows(0).Item("SSTINV").ToString.Trim
                    .PNFSLDAL = dtResultado.Rows(0).Item("FSLDAL")
                    .PNNGUIRM = dtResultado.Rows(0).Item("NGUIRM")
                    .PNNROCTL = dtResultado.Rows(0).Item("NROCTL")
                    .PSSTRNSM = dtResultado.Rows(0).Item("STRNSM").ToString.Trim
                    .PSTDSCIT = dtResultado.Rows(0).Item("TDSCIT").ToString.Trim
                    .PSTUBRFR = dtResultado.Rows(0).Item("TUBRFR").ToString.Trim
                    .PSCREEMB = dtResultado.Rows(0).Item("CREEMB").ToString.Trim
                    .PNQAROCP = dtResultado.Rows(0).Item("QAROCP")
                    .PNNORAGN = dtResultado.Rows(0).Item("NORAGN")
                    .PSDESCWB = dtResultado.Rows(0).Item("DESCWB").ToString.Trim
                    .PSSALTEM = dtResultado.Rows(0).Item("SALTEM").ToString.Trim
                    .PSSMTRCP = dtResultado.Rows(0).Item("SMTRCP").ToString.Trim
                    .PSSMTRCP_D = dtResultado.Rows(0).Item("SMTRCP_D").ToString.Trim
                    .PSSSNCRG = dtResultado.Rows(0).Item("SSNCRG").ToString.Trim
                    .PSSSNCRG_D = dtResultado.Rows(0).Item("SSNCRG_D").ToString.Trim
                    .PSCRTLTE = dtResultado.Rows(0).Item("CRTLTE").ToString.Trim
                    .PNNTCKPS = dtResultado.Rows(0).Item("NTCKPS")
                    .PSDCENSA = dtResultado.Rows(0).Item("DCENSA").ToString.Trim
                    .PSSTPING = dtResultado.Rows(0).Item("STPING").ToString.Trim
                    .PSSTPING_D = dtResultado.Rows(0).Item("STPING_D").ToString.Trim
                    '.pFlagEstadoRegistro_SESTRG = dtResultado.Rows(0).Item("SESTRG").ToString.Trim

                    .PSCCMPN = dtResultado.Rows(0).Item("CCMPN").ToString.Trim
                    .PSCDVSN = dtResultado.Rows(0).Item("CDVSN").ToString.Trim
                    .PNCPLNDV = dtResultado.Rows(0).Item("CPLNDV")

                    .PSTCTCST = dtResultado.Rows(0).Item("TCTCST").ToString.Trim
                    .PSTCTCSA = dtResultado.Rows(0).Item("TCTCSA").ToString.Trim
                    .PSTCTCSF = dtResultado.Rows(0).Item("TCTCSF").ToString.Trim
                    .PSTCTAFE = dtResultado.Rows(0).Item("TCTAFE").ToString.Trim
                    .PSNORCML = dtResultado.Rows(0).Item("NORCML").ToString.Trim
                    .PSCTPALM = dtResultado.Rows(0).Item("CTPALM").ToString.Trim
                    .PSCALMC = dtResultado.Rows(0).Item("CALMC").ToString.Trim
                    .PSCZNALM = dtResultado.Rows(0).Item("CZNALM").ToString.Trim
                    .PNCMEDTS = dtResultado.Rows(0).Item("CMEDTS").ToString.Trim
                    .PSTLUGOR = dtResultado.Rows(0).Item("TLUGOR").ToString.Trim
                    .PSTLUGEN = dtResultado.Rows(0).Item("TLUGEN").ToString.Trim
                    .PSNGRPRV = dtResultado.Rows(0).Item("NGRPRV").ToString.Trim
                    .MEDIOENVIO = dtResultado.Rows(0).Item("MEDENVIO")
                    .PNISDIST = dtResultado.Rows(0).Item("ISDIST")
                    .PSCPRCN1 = dtResultado.Rows(0).Item("CPRCN1")
                    .PSNSRCN1 = dtResultado.Rows(0).Item("NSRCN1")
                    .PSDSREFE = dtResultado.Rows(0).Item("DSREFE")




                End With
            Catch ex As Exception
                obeBulto.PSERROR = "Se produjo un error en la correspondencia de los valores" & vbNewLine & _
                                  "con las propiedades de la clase. "
                Return obeBulto
            End Try
            Dim objParametrosImpor As New Parameter

            objParametrosImpor.Add("PSCREFFW", obeBulto.PSCREFFW.ToString.Trim)
            objParametrosImpor.Add("PNCCLNT", obeBulto.PNCCLNT)

            ' Obteniendo el importe del Bulto
            Dim strResultado As String = ""
            Try
                strResultado = objSqlManager.ExecuteScalar("SP_SOLMIN_SA_OBTENER_IMPORTE_BULTO", objParametrosImpor)
                Decimal.TryParse(strResultado, obeBulto.PNIPBULT)
            Catch ex As Exception
                objSqlManager = Nothing
                obeBulto.PSERROR = "Se produjo un error al hallar el Importe del Bulto. " & vbNewLine & _
                                  "Mensaje del Sistemna : " & ex.Message & vbNewLine & vbNewLine
                Return obeBulto
            End Try

            Dim objParametrosPeso As New Parameter
            objParametrosPeso.Add("PNNTCKPS", obeBulto.PNNTCKPS.ToString)
            ' Obteniendo el Peso del Ticket
            If obeBulto.PNNTCKPS <> 0 Then
                Try
                    strResultado = objSqlManager.ExecuteScalar("SP_SOLMIN_SA_OBTENER_PESO_TICKET", objParametrosPeso)
                    Decimal.TryParse(strResultado, obeBulto.PNQPSTKI)
                Catch ex As Exception
                    obeBulto.PSERROR = "Se produjo un error al hallar el Peso del Ticket. " & vbNewLine
                    Return obeBulto
                End Try
            End If
            Return obeBulto
        End Function

        'Public Function fblnGrabarBulto(ByVal obeBulto As beBulto, ByVal booIsNew As Boolean, ByRef strMensajeResultado As String, Optional ByVal blnIsParcial As Boolean = False) As Boolean
        '    'Dim strSQL As String = ""
        '    Dim retorno As Int32 = 0
        '    Dim odaBulto As New daBulto
        '    If booIsNew Then
        '        obeBulto.PSSESTRG = "A"
        '        obeBulto.PNISPARCIAL = IIf(blnIsParcial = True, 1, 0)
        '        retorno = odaBulto.fintInsertarBulto(obeBulto)
        '        If (retorno = 1) Then
        '            strMensajeResultado = "El Bulto fue registrado satisfactoriamente." & Chr(13)
        '            strMensajeResultado &= "Código Bulto: " & obeBulto.PSCREFFW
        '        Else
        '            strMensajeResultado = "El proceso no pudo terminar satisfactoriamente."
        '            Return False

        '        End If

        '    Else
        '        Try
        '            retorno = odaBulto.fintActualizarBulto(obeBulto)
        '            If (retorno = 1) Then
        '                strMensajeResultado = "El Bulto fue actualizado satisfactoriamente."
        '            Else
        '                strMensajeResultado = "El proceso no pudo terminar satisfactoriamente."
        '            End If
        '        Catch
        '            strMensajeResultado = "El proceso no pudo terminar satisfactoriamente."
        '            Return False
        '            Exit Function
        '        End Try
        '    End If
        '    'End With
        '    Return True
        'End Function

        Public Function fdtListarInformacionItem(ByVal varItemBulto As NewType_ItemBulto, _
                                                 ByRef strMensajeError As String) As String
            Dim objSqlManager As SqlManager = Nothing
            Dim dtResultado As DataTable = Nothing
            Dim objParametros As Parameter = New Parameter

            objParametros.Add("PNCCLNT", varItemBulto.pCodigoCliente_CCLNT)
            objParametros.Add("PSCREFFW", varItemBulto.pCodigoRecepcion_CREFFW.ToString.Trim)
            objParametros.Add("PSCIDPAQ", varItemBulto.pCodigoIdentificacionPaquete_CIDPAQ.ToString.Trim)
            objParametros.Add("PNNSEQIN", varItemBulto.pCodigoInterno_NSEQIN)

            Try
                strMensajeError = ""
                ' Llamar al procedimiento de la capa de Datos
                objSqlManager = New SqlManager
                objSqlManager.TransactionController(TransactionType.Automatic)
                dtResultado = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTA_INFORMACION_ITEM_BULTO", objParametros)
            Catch ex As Exception
                strMensajeError = "Se produjo un error al Listar la Información del Item seleccionado."
                objSqlManager = Nothing
                Return ""
                Exit Function
            End Try

            If dtResultado IsNot Nothing Then
                '-- Armando la cadena informativa del item
                With dtResultado
                    Return " Información del Item: " & vbNewLine & _
                           " ======================" & vbNewLine & _
                           " No. Orden Compra : " & .Rows(0).Item("NORCML").ToString.Trim & vbNewLine & _
                           " Detalle O/C      : " & .Rows(0).Item("TDSCML").ToString.Trim & vbNewLine & _
                           " Proveedor        : " & .Rows(0).Item("TPRVCL").ToString.Trim & vbNewLine & _
                           " Nro. Item O/C    : " & .Rows(0).Item("TCITCL").ToString.Trim & vbNewLine & _
                           " Área Solicitante : " & .Rows(0).Item("TCMAEM").ToString.Trim & vbNewLine & _
                           " Cantidad         : " & .Rows(0).Item("QCNTIT").ToString.Trim & vbNewLine & _
                           " Unidad           : " & .Rows(0).Item("TUNDIT").ToString.Trim & vbNewLine & _
                           " Precio Unitario  : " & .Rows(0).Item("IVUNIT").ToString.Trim & vbNewLine & _
                           " Precio Total     : " & .Rows(0).Item("IVTOIT").ToString.Trim & vbNewLine & _
                           " Lugar de Origen  : " & .Rows(0).Item("TLUGOR").ToString.Trim & vbNewLine & _
                           " Lugar de Destino : " & .Rows(0).Item("TLUGEN").ToString.Trim
                End With
            Else
                Return ""
            End If
        End Function

        Public Function fstrObservacionesItemBulto(ByVal varItemBulto As NewType_ItemBulto) As String
            Dim strObservacionTemp As String = ""
            Dim strSQL As String
            Dim objSqlManager As SqlManager = Nothing
            Dim dtResultado As DataTable
            Dim dwRowTemp As DataRow
            Try
                With varItemBulto
                    strSQL = " Select TDAITM " & _
                             " From   RZOL66K " & _
                             " Where  RZOL66.CCLNT = " & .pCodigoCliente_CCLNT.ToString & _
                             " And    RZOL66.CREFFW = '" & .pCodigoRecepcion_CREFFW.Trim & "' " & _
                             " And    RZOL66.CIDPAQ = '" & .pCodigoIdentificacionPaquete_CIDPAQ.Trim & "'" & _
                             " Order by NCRRDC "
                End With
                ' Llenamos el DataTable
                objSqlManager = New SqlManager
                objSqlManager.TransactionController(TransactionType.Automatic)
                dtResultado = objSqlManager.ExecuteDataTable(strSQL)
                For Each dwRowTemp In dtResultado.Rows
                    strObservacionTemp &= dwRowTemp.Item("TDAITM").ToString
                Next
                Return strObservacionTemp.Trim
            Catch ex As Exception
                objSqlManager = Nothing
                Return ""
            End Try
        End Function

        Public Function fobjObtenerItemBulto(ByVal varItemBulto As NewType_ItemBulto, _
                                             ByRef strMensaje As String) As clsItemBulto
            Dim objSqlManager As SqlManager = Nothing
            Dim dtResultado As DataTable
            Dim objBultoDetalle As clsItemBulto = New clsItemBulto
            Dim strSQL As String
            Dim strFecha As String
            ' SQL
            With varItemBulto
                strSQL = " Select CCLNT,  CREFFW, CIDPAQ, NORCML, NRITOC, NFACPR, NRITFP, FFACPR," & _
                         "        NGUIPR, QCNTDC, QBLTSR, QSLCNB, SSTBLT, SITMAT, QBLRCO, TTIPPQ," & _
                         "        QPEPQT, TUNPSO, QVOPQT, TUNVOL, QMTALT, QMTANC, QMTLRG, NRWBLL," & _
                         "        NFACMR, NGUIRM, SESTRG, FLGQDM, CREEMB, LANCOS, NFCPRT, NITPRT," & _
                         "        FFCPRT, NGRPRV, STRNSM, NRGUSA, NSEQCR, CUSCRT, FCHCRT, HRACRT," & _
                         "        CULUSA, FULTAC, HULTAC, UPDATE_IDENT " & _
                         " From   RZOL66 " & _
                         " Where  CCLNT = " & .pCodigoCliente_CCLNT & _
                         " And    CREFFW = '" & .pCodigoRecepcion_CREFFW.ToString.Trim & "'" & _
                         " And    CIDPAQ = '" & .pCodigoIdentificacionPaquete_CIDPAQ.ToString.Trim & "'"
            End With
            Try
                objSqlManager = New SqlManager
                objSqlManager.TransactionController(TransactionType.Automatic)
                dtResultado = objSqlManager.ExecuteDataTable(strSQL)
            Catch ex As Exception
                objSqlManager = Nothing
                strMensaje = "Se produjo un error en la Lectura de la Base de Datos" & vbNewLine & _
                             "para la Obtención del Item del Bulto."
                Return Nothing
                Exit Function
            End Try

            If dtResultado.Rows.Count <> 1 Then
                strMensaje = "El resultado de la consulta para la Obtención del Item del Bulto" & vbNewLine & _
                             "devolvió mas de un registro."
                Return Nothing
                Exit Function
            End If

            Try
                With objBultoDetalle
                    .pCodigoCliente_CCLNT = dtResultado.Rows(0).Item("CCLNT")
                    .pCodigoRecepcion_CREFFW = dtResultado.Rows(0).Item("CREFFW").ToString.Trim
                    .pCodigoIdentificacionPaquete_CIDPAQ = dtResultado.Rows(0).Item("CIDPAQ").ToString.Trim
                    .pNroOrdenCompra_NORCML = dtResultado.Rows(0).Item("NORCML").ToString.Trim
                    .pNroItemOrdenCompra_NRITOC = dtResultado.Rows(0).Item("NRITOC")
                    .pNroFacturaProveedor_NFACPR = dtResultado.Rows(0).Item("NFACPR").ToString.Trim
                    .pNroItemFacturaProveedor_NRITFP = dtResultado.Rows(0).Item("NRITFP").ToString.Trim
                    If dtResultado.Rows(0).Item("FFACPR") <> 0 Then
                        strFecha = dtResultado.Rows(0).Item("FFACPR")
                        strFecha = strFecha.Substring(6, 2) & "/" & _
                                   strFecha.Substring(4, 2) & "/" & _
                                   strFecha.Substring(0, 4)
                        .pFechaFacturaProveedor_FFACPR = CType(strFecha, Date)
                    End If
                    .pNroGuiaRemisionProveedor_NGUIPR = dtResultado.Rows(0).Item("NGUIPR")
                    .pCantidadDeclarada_QCNTDC = dtResultado.Rows(0).Item("QCNTDC")
                    .pCantidadBultosRecibidos_QBLTSR = dtResultado.Rows(0).Item("QBLTSR")
                    .pSaldoCantidadBultos_QSLCNB = dtResultado.Rows(0).Item("QSLCNB")
                    .pEstadoBulto_SSTBLT = dtResultado.Rows(0).Item("SSTBLT").ToString.Trim
                    .pFlagItemAutorizado_SITMAT = dtResultado.Rows(0).Item("SITMAT").ToString.Trim
                    .pCantidadBultosRecibidosOriginal_QBLRCO = dtResultado.Rows(0).Item("QBLRCO")
                    .pTipoPaquete_TTIPPQ = dtResultado.Rows(0).Item("TTIPPQ").ToString.Trim
                    .pPesoPaquete_QPEPQT = dtResultado.Rows(0).Item("QPEPQT")
                    .pUnidadPeso_TUNPSO = dtResultado.Rows(0).Item("TUNPSO").ToString.Trim
                    .pVolumenPaquete_QVOPQT = dtResultado.Rows(0).Item("QVOPQT")
                    .pUnidadVolumen_TUNVOL = dtResultado.Rows(0).Item("TUNVOL").ToString.Trim
                    .pAltura_QMTALT = dtResultado.Rows(0).Item("QMTALT")
                    .pAncho_QMTANC = dtResultado.Rows(0).Item("QMTANC")
                    .pLargo_QMTLRG = dtResultado.Rows(0).Item("QMTLRG")
                    .pNroWayBill_NRWBLL = dtResultado.Rows(0).Item("NRWBLL")
                    .pNroFacturaMR_NFACMR = dtResultado.Rows(0).Item("NFACMR").ToString.Trim
                    '.pNroGuiaRemision_NGUIRM = dtResultado.Rows(0).Item("NGUIRM")
                    .pFlagEstadoRegistro_SESTRG = dtResultado.Rows(0).Item("SESTRG").ToString.Trim
                    .pFlagDctoQuadrem_FLGQDM = dtResultado.Rows(0).Item("FLGQDM").ToString.Trim
                    .pCodigoBarraEmbarcador_CREEMB = dtResultado.Rows(0).Item("CREEMB").ToString.Trim
                    .pLandedCostValue_LANCOS = dtResultado.Rows(0).Item("LANCOS")
                    .pNroFacturaProveedor_NFCPRT = dtResultado.Rows(0).Item("NFCPRT").ToString.Trim
                    .pNroItemFacturaProveedor_NITPRT = dtResultado.Rows(0).Item("NITPRT").ToString.Trim
                    If dtResultado.Rows(0).Item("FFCPRT") <> 0 Then
                        strFecha = dtResultado.Rows(0).Item("FFCPRT")
                        strFecha = strFecha.Substring(6, 2) & "/" & _
                                   strFecha.Substring(4, 2) & "/" & _
                                   strFecha.Substring(0, 4)
                        .pFechaFacturaProveedor_FFCPRT = CType(strFecha, Date)
                    End If
                    .pNroGuiaRemisionProveedor_NGRPRV = dtResultado.Rows(0).Item("NGRPRV").ToString.Trim
                    .pEstadoTransmision_STRNSM = dtResultado.Rows(0).Item("STRNSM").ToString.Trim
                    .pNroGuiaSalida_NRGUSA = dtResultado.Rows(0).Item("NRGUSA")
                    .pNroSecuencia_NSEQCR = dtResultado.Rows(0).Item("NSEQCR")
                    .pObservacionItemBulto_TDAITM = fstrObservacionesItemBulto(varItemBulto)
                End With
                strMensaje = ""
                Return objBultoDetalle
            Catch ex As Exception
                strMensaje = "Se produjo un error en la correspondencia de los valores" & vbNewLine & _
                             "con las propiedades de la clase. "
                Return Nothing
            End Try
        End Function

        Public Function frptIndicadorTiempoEntrega(ByVal TD_Filtro As TD_Qry_SegOC_L01) As DataTable
            Dim objSqlManager As New SqlManager
            Dim dtResultado As DataTable = Nothing
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = String.Empty

            With objParametros
                .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
                .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
                .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
                .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
                .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
                .Add("IN_FORCMI", TD_Filtro.pFORCMI_FechaOCInicial_Int)
                .Add("IN_FORCMF", TD_Filtro.pFORCMF_FechaOCFinal_Int)
                .Add("IN_FMPDMI", TD_Filtro.pFMPDMI_FechaCompInicial_Int)
                .Add("IN_FMPDMF", TD_Filtro.pFMPDMF_FechaCompFinal_Int)
                .Add("IN_STATOC", TD_Filtro.pSTATOC_StatusOC)
            End With
            Try

                Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_FECHA_ENTREGA", objParametros)
            Catch ex As Exception

                strMensajeError = "Error producido en la funcion : << fdtListar_SegOCSegunFechaEntrega_L01 >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_FECHA_ENTREGA >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Throw New Exception(strMensajeError)

            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return dtResultado
        End Function


        Public Function frptIndicadorTiempoEntregaProveedor(ByVal TD_Filtro As TD_Qry_SegOC_L01) As DataTable
            Dim objSqlManager As New SqlManager
            Dim dtResultado As DataTable = Nothing
            Dim objParametros As Parameter = New Parameter
            Dim strMensajeError As String = String.Empty

            With objParametros
                .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
                .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
                .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
                .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
                .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
                .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
                .Add("IN_TTINTC", TD_Filtro.pTTINTC_TermInterCarga)
                .Add("IN_FORCMI", TD_Filtro.pFORCMI_FechaOCInicial_Int)
                .Add("IN_FORCMF", TD_Filtro.pFORCMF_FechaOCFinal_Int)
                .Add("IN_FMPDMI", TD_Filtro.pFMPDMI_FechaCompInicial_Int)
                .Add("IN_FMPDMF", TD_Filtro.pFMPDMF_FechaCompFinal_Int)
                .Add("IN_STATOC", TD_Filtro.pSTATOC_StatusOC)
            End With
            Try

                Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_PROVEEDOR", objParametros)
            Catch ex As Exception

                strMensajeError = "Error producido en la funcion : << fdtListar_SegOCSegunFechaEntrega_L01 >> de la clase << daoOrdenCompra >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_PROVEEDOR >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                Throw New Exception(strMensajeError)

            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return dtResultado
        End Function
#End Region



    End Class
End Namespace
