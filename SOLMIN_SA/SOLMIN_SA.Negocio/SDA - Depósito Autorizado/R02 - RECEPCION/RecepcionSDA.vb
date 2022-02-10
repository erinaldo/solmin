Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDA

Namespace slnSOLMIN_SDA.RecepcionSDA.Procesos
    Public Class clsRecepcion
        Inherits clsBasicClass
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

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

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Detalle de la Información -'
        '--------------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'
        Public Shared Function fdtDefecto_ServicioRecepcion(ByVal strCompania As String, ByVal strDivision As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_DEFREC_01", strCompania, strDivision)
            dtResultado.TableName = "Servicio de Recepcion"
            Return dtResultado
        End Function

        Public Shared Function fdtDefecto_TipoMovimientoRecepcion(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_DEFTMV_01")
            dtResultado.TableName = "Tipo de Recepción"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        'Public Function fblnRecepcion_Mercaderia(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
        '                                         ByVal objMovimientoMercaderia As clsMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
        '    Dim objSqlManager As SqlManager = New SqlManager
        '    Dim objParametros As Parameter
        '    Dim blnResultado As Boolean = True
        '    objSqlManager.TransactionController(TransactionType.Automatic)
        '    Dim strTemp1, strTemp2, strTemp3 As String
        '    Try
        '        ' ---------------------------------------------------------'
        '        ' Primer Paso - Ingresar las Observaciones de la Recepción '
        '        ' ---------------------------------------------------------'
        '        ' Separando las observaciones en las Tres (3) cadenas respectivas
        '        Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
        '            Case Is > 120
        '                strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
        '                strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
        '                strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
        '            Case Is > 60
        '                strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
        '                strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
        '                strTemp3 = ""
        '            Case Else
        '                strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
        '                strTemp2 = ""
        '                strTemp3 = ""
        '        End Select

        '        objParametros = New Parameter
        '        With objParametros
        '            .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
        '            .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
        '            .Add("IN_TOBSG1", strTemp1)
        '            .Add("IN_TOBSG2", strTemp2)
        '            .Add("IN_TOBSG3", strTemp3)
        '            .Add("IN_NTRMNL", strPCUSER)
        '            .Add("IN_USUARI", strUsuarioSistema)
        '        End With
        '        Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_OBSERV_INS", objParametros)
        '        ' -------------------------------------------------'
        '        ' Segundo Paso - Recorremos los Item recepcionados '
        '        ' -------------------------------------------------'
        '        For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
        '            objParametros = New Parameter
        '            With objParametros
        '                .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
        '                .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
        '                .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)
        '                .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)
        '                .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
        '                .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
        '                .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
        '                .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
        '                .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
        '                .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
        '                .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
        '                .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
        '                .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
        '                .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
        '                .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

        '                .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
        '                .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)

        '                .Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
        '                .Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
        '                .Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)

        '                .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
        '                .Add("IN_CTPOCN", objItemMovimientoMercaderia.pstrDesglose_CTPOCN)
        '                .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
        '                .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
        '                .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
        '                .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)
        '                .Add("IN_CCNTD", objItemMovimientoMercaderia.pstrContenedor_CCNTD)

        '                .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
        '                .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
        '                .Add("IN_NTRMNL", strPCUSER)
        '                .Add("IN_USUARI", strUsuarioSistema)
        '            End With
        '            Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDA_ALMACEN_INS", objParametros)
        '        Next
        '    Catch ex As Exception
        '        strMensajeError = "Error producido en la funcion : << fblnRecepcion_Mercaderia >> de la clase << clsRecepcion >> " & vbNewLine & _
        '                          "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
        '                          "Motivo del Error : " & ex.Message
        '        blnResultado = False
        '    Finally
        '        objSqlManager = Nothing
        '        objParametros = Nothing
        '    End Try
        '    Return blnResultado
        'End Function
#End Region
    End Class
End Namespace

