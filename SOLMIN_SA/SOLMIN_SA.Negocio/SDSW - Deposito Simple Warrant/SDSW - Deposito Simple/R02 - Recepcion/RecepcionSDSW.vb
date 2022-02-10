Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDSW

Namespace slnSOLMIN_SDS.RecepcionSDSW.Procesos
    Public Class clsRecepcion
        Inherits clsBasicClassSDSW
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " M�todos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Informaci�n para Filtros -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Informaci�n para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_SDSWContratosVigentes(ByVal strCliente As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_LSTCNT_01", strCliente)
            dtResultado.TableName = "Contratos Vigentes"
            Return dtResultado
        End Function

        'Agregado para Almaceneras
        Public Shared Function fdtListar_ContratosVigentesW(ByVal strCliente As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_RECE_LSTCNT_01", strCliente)
            dtResultado.TableName = "Contratos Vigentes"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Detalle de la Informaci�n -'
        '--------------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Informaci�n  -'
        '-------------------------------------------'
        Public Shared Function fdtObtener_SDSWInfUltimoAlmacenSegunOS(ByVal strNroOS As String, ByVal strServicio As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_INFALM_01", strNroOS, strServicio)
            dtResultado.TableName = "Informaci�n de Almac�n"
            Return dtResultado
        End Function

        Public Shared Function fdtObtener_SDSWInfUltimoAlmacenSegunCliente(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_INFALM_02", intCliente)
            dtResultado.TableName = "Informaci�n de Almac�n"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Informaci�n por Defecto -'
        '----------------------------------------------------'
        Public Shared Function fdtDefecto_SDSWServicioRecepcion(ByVal strCompania As String, ByVal strDivision As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_DEFREC_01", strCompania, strDivision)
            dtResultado.TableName = "Servicio de Recepcion"
            Return dtResultado
        End Function

        Public Shared Function fdtDefecto_SDSWTipoMovimientoRecepcion(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_DEFTMV_01")
            dtResultado.TableName = "Tipo de Recepci�n"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnExiste_SDSWTarifaRubro(ByRef strMensajeError As String, _
                                                      ByVal Compania As String, ByVal Division As String, _
                                                      ByVal Cliente As String, _
                                                      ByVal objITEMticket As clsSDSWItemTicket) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_RUBRO_TARIFA_02", Compania, Division, Cliente, objITEMticket.pstrTipoServicio_CSRVNV)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnExiste_SDSWRubroIGV(ByRef strMensajeError As String, _
                                                   ByVal Compania As String, ByVal Division As String, _
                                                   ByVal objITEMticket As clsSDSWItemTicket) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_IGV_RUBRO_01", Compania, Division, objITEMticket.pstrTipoServicio_CSRVNV)
        End Function
        Public Shared Function fblnExiste_SDSWCentroCosto_Rubro(ByRef strMensajeError As String, _
                                                           ByVal Compania As String, ByVal Division As String, _
                                                           ByVal objITEMticket As clsSDSWItemTicket) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_CENTCOST_RUBRO_01", Compania, Division, objITEMticket.pstrTipoServicio_CSRVNV, objITEMticket.pstrAlmacen_CALMCM)
        End Function


        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gesti�n de la Informaci�n -'
        '-----------------------------'
        Public Function fblnRecepcion_SDSMercaderia(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                 ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepci�n '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas
                Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
                    Case Is > 120
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
                        strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
                    .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", strPCUSER)
                    .Add("IN_USUARI", strUsuarioSistema)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_OBSERV_INS", objParametros)


                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_OBSERV_INS", objParametros)
                ' -------------------------------------------------'
                ' Segundo Paso - Recorremos los Item recepcionados '
                ' -------------------------------------------------'
                For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                        .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)
                        .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)
                        .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                        .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
                        .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                        .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
                        .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
                        .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
                        .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
                        .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

                        .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
                        .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)

                        .Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
                        .Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
                        .Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)

                        .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
                        .Add("IN_CTPOCN", objItemMovimientoMercaderia.pstrDesglose_CTPOCN)
                        .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                        .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                        .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                        .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)
                        .Add("IN_CCNTD", objItemMovimientoMercaderia.pstrContenedor_CCNTD)

                        .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                        .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                        .Add("IN_NTRMNL", strPCUSER)
                        .Add("IN_USUARI", strUsuarioSistema)

                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_INS", objParametros)

                    'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_INS", objParametros)
                Next
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRecepcion_Mercaderia >> de la clase << clsRecepcion >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnRecepcion_SDSWMercaderia(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia, _
                                                 ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            Dim Posicion As Int32 = 0
            Dim NumCorrelativo As Int32 = 0
            Dim Descripcion As String = ""
            Dim Caracteristica As String = ""
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepci�n '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas
                Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
                    Case Is > 120
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
                        strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
                    .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", strPCUSER)
                    .Add("IN_USUARI", strUsuarioSistema)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_OBSERV_INS", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_OBSERV_INS", objParametros)
                '-------------------------------------------------'
                'Segundo Paso - Recorremos los Item recepcionados '
                '-------------------------------------------------'
                For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                        .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)
                        .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)
                        .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                        .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
                        .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                        .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
                        .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
                        .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
                        .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
                        .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

                        .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
                        .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)

                        .Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
                        .Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
                        .Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)

                        .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
                        .Add("IN_CTPOCN", objItemMovimientoMercaderia.pstrDesglose_CTPOCN)
                        .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                        .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                        .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                        .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)
                        .Add("IN_CCNTD", objItemMovimientoMercaderia.pstrContenedor_CCNTD)

                        .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                        .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                        .Add("IN_NTRMNL", strPCUSER)
                        .Add("IN_USUARI", strUsuarioSistema)
                        .Add("IN_CDPRDC", objItemMovimientoMercaderia.pstrCodigoRANSA_CMRCD)
                        .Add("IN_FECING", objItemMovimientoMercaderia.pdteFechaIngreso_FRLZSR.ToString("yyyyMMdd"))

                        .Add("IN_FECSAL", objItemMovimientoMercaderia.pdteFechaSalida_FCNTSL.ToString("yyyyMMdd"))

                        .Add("IN_NPDUA", objMovimientoMercaderia.pintNPDUA)
                        .Add("IN_CADNA", objMovimientoMercaderia.pintCADNA)

                        .Add("IN_NANDCL", objMovimientoMercaderia.pintNANDCL)
                        .Add("IN_NSRIE1", objItemMovimientoMercaderia.pintSerie_NSRIE)
                        .Add("IN_CRGMN", objMovimientoMercaderia.pstrCRGMN)
                    End With

                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_INS", objParametros)
                    'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_INS", objParametros)

                    'Agregamos las Caracteristicas del Item
                    If objItemMovimientoMercaderia.pstrCaracteristicas_TOBSRL.Length > 0 Then

                        Descripcion = objItemMovimientoMercaderia.pstrCaracteristicas_TOBSRL
                        Do While Len(Trim(Descripcion)) > 0
                            NumCorrelativo = NumCorrelativo + 1
                            Posicion = InStr(1, Descripcion, vbCrLf, vbTextCompare)
                            If Posicion <= 50 And Posicion > 0 Then
                                Caracteristica = Left(Descripcion, Posicion - 1)
                                Descripcion = Right(Descripcion, Len(Descripcion) - (Posicion + 1))
                            Else
                                Caracteristica = Left(Descripcion, IIf(Len(Descripcion) >= 48, 48, Len(Descripcion)))
                                Descripcion = Right(Descripcion, IIf(Len(Descripcion) > 48, Len(Descripcion) - 48, 0))
                            End If

                            If Caracteristica <> "" Then
                                objParametros = New Parameter
                                With objParametros
                                    .Add("IN_STPODC", "A")
                                    .Add("IN_NRGSRL", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                                    .Add("IN_NCRRLT", NumCorrelativo)
                                    .Add("IN_TOBSRL", Caracteristica)
                                    .Add("IN_USUARI", strUsuarioSistema)
                                End With

                                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_ALMACEN_CARAC_INS", objParametros)

                                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_CARAC_INS", objParametros)

                            End If
                        Loop
                    End If

                Next

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRecepcion_MercaderiaW >> de la clase << clsRecepcion >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnOrdenIngreso_SDSWTicket(ByRef strMensajeError As String, _
                                              ByVal objMovimientoTicket As clsSDSWMovimientoTicket) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                'Agregamos los cabecera de ticket 
                For Each objticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NORDSR", objticket.pintOrdenServicio_NORDSR)
                        .Add("IN_CTPOAT", objMovimientoTicket.pstrZonaAlmacen_CTPOAT)
                        .Add("IN_CTPALM", objMovimientoTicket.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objMovimientoTicket.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objMovimientoTicket.pstrZonaAlmacen_CZNALM)
                        .Add("IN_USUARI", strUsuarioSistema)
                        .Add("IN_OBSER", objMovimientoTicket.pstrObservacion_OBSER)
                        .Add("IN_FATNSR", objticket.pintFecha_FATNSR)

                    End With
                Next

                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_TICKET_CABECERA", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_TICKET_CABECERA", objParametros)

                'Agregamos detalle de ticket 
                For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NORDSR", objItemticket.pintOrdenServicio_NORDSR)
                        .Add("IN_USUARI", strUsuarioSistema)
                        .Add("IN_CSRVNV", objItemticket.pstrTipoServicio_CSRVNV)
                        .Add("IN_HORAINI", objItemticket.pintHoraInicio_HORAINI.Replace(":", ""))
                        .Add("IN_HORAFIN", objItemticket.pintHoraFin_HORAFIN.Replace(":", ""))
                        .Add("IN_NHRCAL", objItemticket.pdecHoraCalculada_NHRCAL)
                        .Add("IN_NHRFAC", objItemticket.pdecHoraFacturada_NHRFAC)
                        .Add("IN_OBSER", objItemticket.pstrObservacion_OBSER)
                        .Add("IN_FATNSR", objItemticket.pintFecha_FATNSR)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_TICKET_DETALLE", objParametros)
                    ' Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_TICKET_DETALLE", objParametros)


                Next

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRecepcion_MercaderiaW >> de la clase << clsRecepcion >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnPreFactura_SDSWTicket(ByRef strMensajeError As String, _
                                                     ByVal objMovimientoTicket As clsSDSWMovimientoTicket, _
                                                     ByVal Compania As String, ByVal Division As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            Dim htResultado As Hashtable
            ' variables de Trabajo
            Dim intNroPreFact As Int64 = 0

            objSqlManager.TransactionController(TransactionType.Automatic)
            Try

                'Agregamos Cabecera de Pre - Factura
                objParametros = New Parameter
                With objParametros
                    .Add("IN_CCLNT", objMovimientoTicket.pintCodigoCliente_CCLNT)
                    .Add("IN_CSRVNV", objMovimientoTicket.pintCodigoRubro_CSRVNV)
                    '.Add("IN_NHRFAC", objMovimientoTicket.pdecHoraFacturada_NHRFAC)
                    .Add("IN_USUARIO", strUsuarioSistema)
                    .Add("IN_COMPANIA", Compania)
                    .Add("IN_DIVISION", Division)
                    .Add("OU_PREFACT", "", ParameterDirection.Output)

                End With

                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_PREFACT_CABECERA", objParametros)
                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_PREFACT_CABECERA", objParametros)
                htResultado = objSqlManager.ParameterCollection
                Int64.TryParse("" & htResultado("OU_PREFACT"), intNroPreFact)

                'Agregamos los detalle de Pre-Factura
                For Each objdetalle As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoTicket.pintCodigoCliente_CCLNT)
                        .Add("IN_NROTCK", objdetalle.pintNumControlTicket_NROTCK)
                        .Add("IN_NORDSR", objdetalle.pintOrdenServicio_NORDSR)
                        .Add("IN_CSRVNV", objdetalle.pstrTipoServicio_CSRVNV)
                        .Add("IN_NHRFAC", objdetalle.pdecHoraFacturada_NHRFAC)
                        .Add("IN_USUARIO", strUsuarioSistema)
                        .Add("IN_COMPANIA", Compania)
                        .Add("IN_DIVISION", Division)
                        .Add("IN_NDCCT2", intNroPreFact)

                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDSW_ALMACEN_PREFACT_DETALLE", objParametros)
                    'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_ALMACEN_PREFACT_DETALLE", objParametros)

                Next

                'Verifica el Valor del Importe en Cabecera y Detalle
                objParametros = New Parameter
                With objParametros
                    .Add("IN_CCLNT", objMovimientoTicket.pintCodigoCliente_CCLNT)
                    .Add("IN_CSRVNV", objMovimientoTicket.pintCodigoRubro_CSRVNV)
                    .Add("IN_COMPANIA", Compania)
                    .Add("IN_DIVISION", Division)
                    .Add("IN_NDCCT2", intNroPreFact)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_SUM_PREFACT", objParametros)

                'Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SAW_SUM_PREFACT", objParametros)

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnPreFactura_TicketW >> de la clase << clsRecepcion >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

#End Region
    End Class
End Namespace

