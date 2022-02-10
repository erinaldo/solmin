Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports Ransa.NEGO.slnSOLMIN_SDS.RecepcionSDS.Reportes
Imports Ransa.NEGO.slnSOLMIN_SDS.RecepcionSDS.Procesos

Imports Ransa.TYPEDEF.Servicios
Imports Ransa.Controls.Servicios
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Module mRecepcionSDS
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_ContratosVigentes(ByVal strCliente As String, ByVal strTipoDeposito As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_ContratosVigentes(strCliente, strTipoDeposito, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Detalle de la Información -'
    '--------------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    Public Function mfblnObtener_InfUltimoAlmacenSegunOS(ByVal strNroOS As String, ByVal strServicio As String, _
                                                         ByRef TipoAlmacen As String, ByRef DescripcionTipoAlmacen As String, _
                                                         ByRef Almacen As String, ByRef DescripcionAlmacen As String) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim dtEntidad As DataTable = clsRecepcion.fdtObtener_InfUltimoAlmacenSegunOS(strNroOS, strServicio, strMensajeError)

        If strMensajeError <> "" Then
            DescripcionTipoAlmacen = ""
            TipoAlmacen = ""
            DescripcionAlmacen = ""
            Almacen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                DescripcionTipoAlmacen = dtEntidad.Rows(0).Item("TALMC").ToString.Trim
                TipoAlmacen = dtEntidad.Rows(0).Item("CTPALM").ToString.Trim
                DescripcionAlmacen = dtEntidad.Rows(0).Item("TCMPAL").ToString.Trim
                Almacen = dtEntidad.Rows(0).Item("CALMC").ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                DescripcionTipoAlmacen = ""
                TipoAlmacen = ""
                DescripcionAlmacen = ""
                Almacen = ""
                blnResultado = False
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtener_InfUltimoAlmacenSegunCliente(ByVal intCliente As Int64, ByRef TipoAlmacen As String, ByRef DescripcionTipoAlmacen As String, _
                                                              ByRef Almacen As String, ByRef DescripcionAlmacen As String) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim dtEntidad As DataTable = clsRecepcion.fdtObtener_InfUltimoAlmacenSegunCliente(intCliente, strMensajeError)

        If strMensajeError <> "" Then
            DescripcionTipoAlmacen = ""
            TipoAlmacen = ""
            DescripcionAlmacen = ""
            Almacen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                DescripcionTipoAlmacen = dtEntidad.Rows(0).Item("TALMC").ToString.Trim
                TipoAlmacen = dtEntidad.Rows(0).Item("CTPALM").ToString.Trim
                DescripcionAlmacen = dtEntidad.Rows(0).Item("TCMPAL").ToString.Trim
                Almacen = dtEntidad.Rows(0).Item("CALMC").ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                DescripcionTipoAlmacen = ""
                TipoAlmacen = ""
                DescripcionAlmacen = ""
                Almacen = ""
                blnResultado = False
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'
    Public Function mfstrDefecto_ServicioRecepcion(ByVal strCompania As String, ByVal strDivision As String, ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsRecepcion.fdtDefecto_ServicioRecepcion(strCompania, strDivision, strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
            strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
            blnResultado = True
        Else
            strCodigo = "0"
            strDetalle = ""
            blnResultado = False
            MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfstrDefecto_TipoMovimientoRecepcion(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsRecepcion.fdtDefecto_TipoMovimientoRecepcion(strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
            strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
            blnResultado = True
        Else
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnRecepcion_Mercaderia(ByVal objMovimientoMercaderia As clsMovimientoMercaderia, ByVal blnCheckServicio As Boolean, ByRef intGuiaIngresoRansa As Int64, ByRef msgMigracionCliente As String) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim intNroGuiaRansa As Int64 = 0

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_NroGuiaRansa(1, 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
            intGuiaIngresoRansa = intNroGuiaRansa
            objRecepcion.fblnRecepcion_Mercaderia(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, objSeguridadBN.pstrPCName, msgMigracionCliente)
            '---------------------------
            '-- Visualizar el Reporte --
            '---------------------------
            If strMensajeError <> "" Or Not blnResultado Then
                MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If blnCheckServicio Then
                    ' Registro de Servicio
                    Dim oServicio As New Servicio_BE
                    With oServicio
                        .CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                        .CDVSN = objSeguridadBN.pDivision
                        .NOPRCN = 0
                        .CCLNFC = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .NRTFSV = 0
                        .QATNAN = 0
                        .TIPO = "N"
                        .FOPRCN = 0
                        .FECINI = 0
                        .FECFIN = 0
                        .STIPPR = "R"
                        .STPODP = objSeguridadBN.pstrTipoAlmacen
                        .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .CSRVC = 1
                        .NGUIRN = intNroGuiaRansa
                    End With
                    Dim frm As New UcFrmServicioAgregarSA_DS
                    frm.oServicio = oServicio
                    frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    End If
                    ' Fin del Registro de Servicio
                End If
            End If
        End If
        Return blnResultado
    End Function
End Module
