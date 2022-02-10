Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SAT.PreDespacho.Procesos
    Public Class clsPreDespacho
        Inherits clsBasicClass
#Region " Tipos Definidos "
        Structure STRUCT_BultosParaPreDespacho
            Dim pCodigoCliente_CCLNT As Int32
            Dim pCriterioLote_CRTLTE As String
            Dim pCodigosRecepcion_CREFFW As List(Of String())
            Dim pUsuarioModifica_CULUSA As String
        End Structure

        Structure STRUCT_DeleteBultoParaPreDespacho
            Dim pCodigoCliente_CCLNT As Int32
            Dim pCodigoRecepcion_CREFFW As String
            Dim pUsuarioModifica_CULUSA As String
        End Structure
#End Region
#Region " Atributos "
        Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
        Private Shared Function fintObtener_NroPreDespacho(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                           ByVal objParametros As Parameter) As Int64
            Dim htResultado As Hashtable
            Dim intNroPaleta As Int64 = 0
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_NROCORR", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                intNroPaleta = htResultado("OU_NROPLT")
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fintObtener_NroPreDespacho >> de la clase << clsPreDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PREDESPACHO_NROCORR " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return intNroPaleta
        End Function

        Private Shared Function fblnRegistrar_PreDespacho(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                          ByVal objParametros As Parameter) As Boolean
            Dim htResultado As Hashtable
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_INS", objParametros)
                ' Obteniendo los valores devueltos
                htResultado = objSqlManager.ParameterCollection
                strMensajeError = "" & htResultado("OU_MSGERR")
                If strMensajeError <> "" Then blnResultado = False
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRegistrar_PreDespacho >> de la clase << clsPreDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PREDESPACHO_INS " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Shared Function fblnRegistrar_VerificacionPaleta(ByRef strMensajeError As String, ByVal objSqlManager As SqlManager, _
                                                                 ByVal objParametros As Parameter) As Boolean
            Dim blnResultado As Boolean = True
            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PALETA_VFN", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRegistrar_VerificacionPaleta >> de la clase << clsAlmacen >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PALETA_VFN " & vbNewLine & _
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

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_PreDespachos(ByVal objFiltrosParaPreDespachos As clsFiltrosParaPreDespachos, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            With objFiltrosParaPreDespachos
                dtResultado = fdtResultadoConsulta(strMensajeError, "PDESP_LSTPDE_01", .pintCodigoCliente_CCLNT, .pstrNroControl_NROCTL, .pstrCodigoCompania_CCMPN, .pstrCodigoDivision_CDVSN, .pdblCodigoPlanta_CPLNDV, .pstrTipoTransporte_STPDES)
            End With
            dtResultado.TableName = "ListaDePreDespacho"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_BultosPreDespachos(ByVal objPrimaryKey_PreDespacho As clsPrimaryKey_PreDespacho, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            With objPrimaryKey_PreDespacho
                dtResultado = fdtResultadoConsulta(strMensajeError, "PDESP_LSTBPD_01", .pintCodigoCliente_CCLNT, .pintNroControl_NROCTL, .pstrCodigoCompania_CCMPN, .pstrCodigoDivision_CDVSN, .pdblCodigoPlanta_CPLNDV)
            End With
            dtResultado.TableName = "ListaBultosDePreDespacho"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_ItemsBultoPreDespachos(ByVal objPrimaryKey_BultoPreDespacho As clsPrimaryKey_BultoPreDespacho, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            With objPrimaryKey_BultoPreDespacho
                dtResultado = fdtResultadoConsulta(strMensajeError, "PDESP_LSTIPD_01", .pintCodigoCliente_CCLNT, .pstrCodigoRecepcion_CREFFW)
            End With
            dtResultado.TableName = "ListaItemsDeBultoDePreDespacho"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_PaletasPreDespachadasWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                                 ByVal strCliente As String, ByVal strUnidad As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsultaWS(strUsuario, strPassword, strServidor, strMensajeError, "SAT_PDES_LSTPLT_01", strCliente, strUnidad)
            dtResultado.TableName = "PaletasPreDespachadas"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Shared Function fobjInformacion_PreDespacho(ByRef strMensajeError As String, _
                                                                   ByVal objPrimaryKey_PreDespacho As clsPrimaryKey_PreDespacho) As clsInformacion_PreDespacho
            Dim dtResultado As DataTable = Nothing
            With objPrimaryKey_PreDespacho
                dtResultado = fdtResultadoConsulta(strMensajeError, "PDESP_PREDES_01", .pintCodigoCliente_CCLNT, .pintNroControl_NROCTL)
            End With
            Dim objPreDespacho As clsInformacion_PreDespacho = New clsInformacion_PreDespacho
            If strMensajeError <> "" Then
                Return objPreDespacho
                Exit Function
            End If
            Try
                If dtResultado.Rows.Count > 0 Then
                    With objPreDespacho
                        .pintCodigoCliente_CCLNT = objPrimaryKey_PreDespacho.pintCodigoCliente_CCLNT
                        .pintNroControl_NROCTL = objPrimaryKey_PreDespacho.pintNroControl_NROCTL
                        .pintNroItems = dtResultado.Rows(0).Item("NITEMS")
                        .pstrCriterioLote_CRTLTE = dtResultado.Rows(0).Item("CRTLTE")
                        .pstrMotivoRecepcion_SMTRCP = dtResultado.Rows(0).Item("SMTRCP")
                        .pstrMotivoRecepcionDetalle_SMTRCP = "" & dtResultado.Rows(0).Item("SMTRCP_D") & ""
                        .pstrSentidoCarga_SSNCRG = dtResultado.Rows(0).Item("SSNCRG")
                        .pstrSentidoCargaDetalle_SSNCRG = dtResultado.Rows(0).Item("SSNCRG_D")
                    End With
                End If
                Return objPreDespacho
            Catch ex As Exception
                Return New clsInformacion_PreDespacho
            End Try
        End Function

        Public Function fintObtener_NroPreDespacho(ByRef strMensajeError As String, ByVal blnStatusDefinitivo As Boolean) As Int64
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim strStatusDefinitivo As String = "N"
            If blnStatusDefinitivo Then strStatusDefinitivo = "S"
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            objParametros.Add("IN_STADEF", strStatusDefinitivo)
            objParametros.Add("IN_USUARI", strUsuarioSistema)
            objParametros.Add("OU_NROPLT", "", ParameterDirection.Output)
            Return fintObtener_NroPreDespacho(strMensajeError, objSqlManager, objParametros)
        End Function

        Public Shared Function fintObtener_NroPreDespachoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
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
            objParametros.Add("OU_NROPLT", "", ParameterDirection.Output)
            Return fintObtener_NroPreDespacho(strMensajeError, objSqlManager, objParametros)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'
        Public Shared Function fblnExiste_BultoParaPreDespacho(ByRef strMensajeError As String, ByVal objBulto As clsPrimaryKey_BultoPreDespacho) As Boolean
            Return fblnExisteInformacion(strMensajeError, "PDESP_EBTOPDE", objBulto.pintCodigoCliente_CCLNT.ToString, objBulto.pstrCodigoRecepcion_CREFFW)
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Shared Function fblnRegistrar_PreDespachoWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                           ByVal lstWSPreDespachos As clsWSListaPreDespachos, ByRef objWSErrorPreDespacho As clsWSErrorPreDespacho) As Boolean
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
            Dim objParametros As Parameter = Nothing
            Dim objWSPreDespacho As clsWSPreDespacho
            Dim strNroPaleta As String = ""
            Dim strMensajeError As String = ""
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim intNroPreDespacho As Int64 = 0
            ' Recorremos todas las Paletas
            For Each objWSPreDespacho In lstWSPreDespachos.plstWSPreDespachos
                ' Recorremos todos los Bultos asociados a la paleta
                For Each strNroPaleta In objWSPreDespacho.plstWSPaletas
                    ' Obtenemos el Nro de PreDespacho para la unidad
                    intNroPreDespacho = fintObtener_NroPreDespachoWS(strUsuario, strPassword, strServidor, strMensajeError, True)
                    objParametros = New Parameter
                    ' Ingresamos los parametros del Procedure
                    With objWSPreDespacho
                        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                        objParametros.Add("IN_NROCTL", intNroPreDespacho)
                        objParametros.Add("IN_CRTLTE", "")
                        objParametros.Add("IN_CTRSPT", .pintCodigoTransportista_CTRSPT)
                        objParametros.Add("IN_NPLCUN", .pstrNroPlacaUnidad_NPLCUN)
                        objParametros.Add("IN_NPLCAC", .pstrNroPlacaAcoplado_NPLCAC)
                        objParametros.Add("IN_CBRCNT", .pstrCodigoBreveteTransportista_CBRCNT)
                        objParametros.Add("IN_NROPLT", strNroPaleta)
                        objParametros.Add("IN_USUARI", strUsuario)
                        objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
                        ' Registramos el Bulto asociado a la Paleta
                        If Not fblnRegistrar_PreDespacho(strMensajeError, objSqlManager, objParametros) Then
                            ' Si hubo algún error, lo registramos en la clase que administra los errores
                            objWSErrorPreDespacho.pAddError("5", strMensajeError, .pintCodigoCliente_CCLNT, .pintCodigoTransportista_CTRSPT, _
                                                            .pstrNroPlacaUnidad_NPLCUN, .pstrNroPlacaAcoplado_NPLCAC, .pstrCodigoBreveteTransportista_CBRCNT, _
                                                            strNroPaleta)
                            blnResultado = False
                        End If
                    End With
                Next
            Next
            Return blnResultado
        End Function

        Public Function fblnAgregar_BultoPreDespachos(ByVal objInformacion_AgregarBultoPreDespacho As clsInformacion_AgregarBultoPreDespacho, _
                                                      ByRef strMensajeError As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            strMensajeError = ""
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Ingresamos los parametros del Procedure
            With objInformacion_AgregarBultoPreDespacho
                objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
                objParametros.Add("IN_NROCTL", .pintNroControl_NROCTL)
                objParametros.Add("IN_CRTLTE", .pstrCriterioLote_CRTLTE)
                objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
                objParametros.Add("IN_USUARI", strUsuarioSistema)
            End With

            Try
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnAgregar_BultoPreDespachos >> de la clase << clsPreDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_INS " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        'Public Function fblnEliminar_BultoPreDespachos(ByVal objPrimaryKey_BultoPreDespacho As clsPrimaryKey_BultoPreDespacho, ByRef strMensajeError As String) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter = New Parameter
        '    Dim blnResultado As Boolean = True
        '    strMensajeError = ""
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    ' Ingresamos los parametros del Procedure
        '    With objPrimaryKey_BultoPreDespacho
        '        objParametros.Add("IN_CCLNT", .pintCodigoCliente_CCLNT)
        '        objParametros.Add("IN_CREFFW", .pstrCodigoRecepcion_CREFFW)
        '        objParametros.Add("IN_USUARI", strUsuarioSistema)
        '    End With

        '    Try
        '        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL", objParametros)
        '    Catch ex As Exception
        '        strMensajeError = "Error producido en la funcion : << fblnEliminar_BultoPreDespachos >> de la clase << clsPreDespacho >> " & vbNewLine & _
        '                          "Tipo de Consulta : SP_SOLMIN_SA_SAT_PREDESPACHO_BULTO_DEL " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '        blnResultado = False
        '    Finally
        '        objSqlManager = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return blnResultado
        'End Function

        Public Shared Function fblnRegistrar_VerificacionPaletasWS(ByVal strUsuario As String, ByVal strPassword As String, ByVal strServidor As String, _
                                                                   ByVal objWSListaPaletasVerifidasPorCliente As clsWSListaPaletasVerifidasPorCliente, _
                                                                   ByRef objWSError As clsWSErrorPaletasVerificadas) As Boolean
            ' Método utilizado solo para consultas de moviles
            Dim ConnStr As String = My.Settings.Item(strServidor).ToString()
            ConnStr = ConnStr.Replace("UUUUUU", strUsuario)
            ConnStr = ConnStr.Replace("PPPPPP", strPassword)
            Dim objSqlManager As SqlManager = New SqlManager(ConnStr)
            Dim objParametros As Parameter = Nothing
            Dim objWSPaletasVerificadasPorCliente As clsWSPaletasVerificadasPorCliente
            Dim objWSPaletaVerificada As clsWSPaletaVerificada
            Dim strMensajeError As String = ""
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            ' Recorremos todas las Paletas
            For Each objWSPaletasVerificadasPorCliente In objWSListaPaletasVerifidasPorCliente.Items
                ' Recorremos todos los Bultos asociados a la paleta
                For Each objWSPaletaVerificada In objWSPaletasVerificadasPorCliente.Items
                    objParametros = New Parameter
                    ' Ingresamos los parametros del Procedure
                    With objWSPaletaVerificada
                        objParametros.Add("IN_CCLNT", objWSPaletasVerificadasPorCliente.pintCodigoCliente_CCLNT)
                        objParametros.Add("IN_CUSVFN", .pstrUsuarioVerifica)
                        objParametros.Add("IN_NROPLT", .pintNroPaleta_NROPLT)
                        objParametros.Add("IN_FCHVFN", .pintFechaVerifica)
                        objParametros.Add("IN_HRAVFN", .pintHoraVerifica)
                        objParametros.Add("IN_USUARI", strUsuario)
                        ' Registramos el Bulto asociado a la Paleta
                        If Not fblnRegistrar_VerificacionPaleta(strMensajeError, objSqlManager, objParametros) Then
                            ' Si hubo algún error, lo registramos en la clase que administra los errores
                            objWSError.pAddError("", strMensajeError, objWSPaletasVerificadasPorCliente.pintCodigoCliente_CCLNT, _
                                                 .pintNroPaleta_NROPLT, .pstrUsuarioVerifica, .pintFechaVerifica, .pintHoraVerifica)
                            blnResultado = False
                        End If
                    End With
                Next
            Next
            Return blnResultado
        End Function
#End Region
    End Class
End Namespace