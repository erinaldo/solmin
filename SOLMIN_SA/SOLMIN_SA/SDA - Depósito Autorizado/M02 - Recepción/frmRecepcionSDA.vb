Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDA

Public Class frmRecepcionSDA
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region " Atributos "
    Private blnRealizarRecepcion As Boolean = False
#End Region
#Region " Propiedades "

#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pActualizarInformacion()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            '-- Cargamos las Mercaderías
            Dim objFiltro As clsFiltro_ListarOS = New clsFiltro_ListarOS
            With objFiltro
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrNroOrdenServicio_NORDSR = txtOrdenServicio.Text
                .pstrTipoDeposito_CTPDP = objSeguridadBN.pstrTipoAlmacen
            End With
            blnRealizarRecepcion = False
            dgOrdenesServicios.DataSource = mfdtListar_OrdenesServicios(objFiltro)
            If dgOrdenesServicios.RowCount > 0 Then
                If dgOrdenesServicios.CurrentRow Is Nothing Then
                    Dim objFiltroDetalle As clsFiltro_ListarDetalleOS = New clsFiltro_ListarDetalleOS
                    With objFiltroDetalle
                        .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                        .pstrCompania_CCMPN = objSeguridadBN.pCompania
                        .pstrDivision_CDVSN = objSeguridadBN.pDivision
                        .pintServicio_CSRVC = 1
                        .pintNroOrdenServicio_NORDSR = "" & dgOrdenesServicios.CurrentRow.Cells("M_NORDSR").Value
                    End With
                    dgDetalleOrdenServicio.DataSource = mfdtListar_DetalleOrdenServicio(objFiltroDetalle)
                    dgSeries.DataSource = mfdtListar_Series(dgOrdenesServicios.CurrentRow.Cells("M_NPDDPR").Value)
                End If
            End If
            '-- Finalizamos la carga de información

            '-- Se libera los procesos automáticos
            '-- Se habilita el botón para realizar una nueva recepcion
            bsaRealizarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            '-- Limpiamos la información de la cabecera
            hgMercaderiaSeleccionada.Visible = False
            bsaRecepcionar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaRecepcionSeries.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            grpLeyenda.Visible = False
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDA_ClienteNombre", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pProcesarRecepcion()
        'If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
        '    MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    If mfblnRecepcion_Mercaderia(objMovimientoMercaderia) Then Call pActualizarInformacion()
        'End If
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub bsaProcesarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarRecepcion.Click
        If dgMercaderiaSeleccionada.RowCount = 0 Then
            MessageBox.Show("No hay ninguna recepción registrada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen
            .pintCodigoCliente = txtCliente.pCodigo
            .pstrRazonSocialCliente = txtCliente.pRazonSocial
            ' modificar luego
            .pintServicio = 1
            .pstrAdicinarInfTitulo = "Recepción"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                'objMovimientoMercaderia.pintAnioUnidad_NANOCM = .pobjInformacionIngresada.pintAnioUnidad_NANOCM
                'objMovimientoMercaderia.pintCodigoCliente_CCLNT = .pobjInformacionIngresada.pintCodigoCliente_CCLNT
                'objMovimientoMercaderia.pintEmpresaTransporte_CTRSP = .pobjInformacionIngresada.pintEmpresaTransporte_CTRSP
                'objMovimientoMercaderia.pintNroDocIdentidadChofer_NLELCH = .pobjInformacionIngresada.pintNroDocIdentidadChofer_NLELCH
                'objMovimientoMercaderia.pintNroRUCEmpTransporte_NRUCT = .pobjInformacionIngresada.pintNroRUCEmpTransporte_NRUCT
                'objMovimientoMercaderia.pintServicio_CSRVC = .pobjInformacionIngresada.pintServicio_CSRVC
                'objMovimientoMercaderia.pstrChofer_TNMBCH = .pobjInformacionIngresada.pstrChofer_TNMBCH
                'objMovimientoMercaderia.pstrCompania_CCMPN = .pobjInformacionIngresada.pstrCompania_CCMPN
                'objMovimientoMercaderia.pstrDivision_CDVSN = .pobjInformacionIngresada.pstrDivision_CDVSN
                'objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
                'objMovimientoMercaderia.pstrNroBrevete_NBRVCH = .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
                'objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM = .pobjInformacionIngresada.pstrNroPlacaCamion_NPLCCM
                'objMovimientoMercaderia.pstrObservaciones_TOBSER = .pobjInformacionIngresada.pstrObservaciones_TOBSER
                'objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = .pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
                'objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
                ' Procedemos con el procesamiento de la información
                'Call pProcesarRecepcion(.pCheckServicio)
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With
    End Sub

    Private Sub bsaRecepcionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRecepcionar.Click
        ' Si no tiene Item no se procesa nada
        If dgDetalleOrdenServicio.RowCount <= 0 Or dgSeries.RowCount <= 0 Then Exit Sub
        ' Verificamos si aún no se ha liberado la O/S 
        If dgDetalleOrdenServicio.CurrentRow.Cells("M_SINLBS").Value <> "P" Then
            Call mpMsjeVarios(enumMsjVarios.RECEPCION_OrdenServicioCerrada)
            Exit Sub
        End If
        ' Iniciamos el proceso de la solicitud de información para completar el registro de la O/S
        Dim fSolicInforMovAlmacen As frmSolicInforRecSAut = New frmSolicInforRecSAut
        With fSolicInforMovAlmacen
            If dgSeries.RowCount >= 0 Then
                Dim decTemp As Decimal = 0
                .pintCliente = txtCliente.pCodigo
                .pintSerie = "" & dgSeries.CurrentRow.Cells("R_NSRIE").Value
                .pstrCodigoMercaderia = "" & dgSeries.CurrentRow.Cells("R_CMRCD").Value
                .pstrMercaderia = "" & dgSeries.CurrentRow.Cells("R_TCMPMR").Value
                .pstrDetalleMercaderia = "" & dgSeries.CurrentRow.Cells("R_TMRCSR").Value
                ' Cantida Declarada
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_QBLTS").Value, decTemp)
                .pdecCantidadBultoDeclarada = decTemp
                ' Unidad
                .pstrUnidadBulto = "" & dgSeries.CurrentRow.Cells("R_CCLTPB").Value
                ' Cantidad Recepcionada
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_QBLTSR").Value, decTemp)
                .pdecCantidadBultoRecepcionada = decTemp
                ' Peso Bruto Declarado
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PBRKL").Value, decTemp)
                .pdecPesoBrutoDeclarada = decTemp
                ' Peso Bruto Recepcionada
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PBRKLR").Value, decTemp)
                .pdecPesoBrutoRecepcionada = decTemp
                ' Peso Neto Declarado
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PNTKL").Value, decTemp)
                .pdecPesoNetoDeclarada = decTemp
                ' Peso Neto Recepcionado
                Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PNTKLR").Value, decTemp)
                .pdecPesoNetoRecepcionada = decTemp
            End If

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim rwTemp As DataRow = dtSeleccion.NewRow
                With rwTemp
                    ' Información de la Orden de Servicio
                    rwTemp.Item("TCMPMR") = dgOrdenesServicios.CurrentRow.Cells("M_TCMPMR").Value
                    rwTemp.Item("NORDSR") = dgOrdenesServicios.CurrentRow.Cells("M_NORDSR").Value
                    rwTemp.Item("NSLCSR") = dgDetalleOrdenServicio.CurrentRow.Cells("M_NSLCSR").Value
                    rwTemp.Item("SINLBS") = dgDetalleOrdenServicio.CurrentRow.Cells("M_SINLBS").Value
                    ' Información solicitada al Usuario
                    rwTemp.Item("NORCCL") = fSolicInforMovAlmacen.pstrNroOrdenCompra
                    rwTemp.Item("NGUICL") = fSolicInforMovAlmacen.pstrNroGuiaCliente
                    rwTemp.Item("NRUCLL") = fSolicInforMovAlmacen.pstrNroRUCCliente
                    rwTemp.Item("STPING") = fSolicInforMovAlmacen.pstrTipoRecepcion
                    rwTemp.Item("CTPALM") = fSolicInforMovAlmacen.pstrTipoAlmacen
                    rwTemp.Item("TALMC") = fSolicInforMovAlmacen.pstrDetalleAlmacen
                    rwTemp.Item("CALMC") = fSolicInforMovAlmacen.pstrAlmacen
                    rwTemp.Item("TCMPAL") = fSolicInforMovAlmacen.pstrDetalleTipoAlmacen
                    rwTemp.Item("CZNALM") = fSolicInforMovAlmacen.pstrZonaAlmacen
                    rwTemp.Item("TCMZNA") = fSolicInforMovAlmacen.pstrDetalleZonaAlmacen
                    rwTemp.Item("QTRMC") = fSolicInforMovAlmacen.pdecRecCantidad
                    rwTemp.Item("QTRMP") = fSolicInforMovAlmacen.pdecRecPeso
                    rwTemp.Item("CCNTD") = fSolicInforMovAlmacen.pstrContenedor
                    rwTemp.Item("CTPOCN") = IIf(fSolicInforMovAlmacen.pblnDesglose, "SI", "NO")
                    rwTemp.Item("FUNDS3") = dgDetalleOrdenServicio.CurrentRow.Cells("M_FUNDS3").Value
                    rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion
                    rwTemp.Item("CEQMNS") = fSolicInforMovAlmacen.pstrCodigoEquipoManipuleo
                    rwTemp.Item("TCMEQM") = fSolicInforMovAlmacen.pstrDetalleEquipoManipuleo
                    ' Información asociada a la Serie - siempre y cuando se haya ingresado alguna cantidad o peso
                    If fSolicInforMovAlmacen.pdecCantidadSerie > 0 Or fSolicInforMovAlmacen.pdecPesoSerie > 0 Then
                        rwTemp.Item("NPDDPR") = dgOrdenesServicios.CurrentRow.Cells("M_NPDDPR").Value
                        rwTemp.Item("NSRIE") = dgSeries.CurrentRow.Cells("R_NSRIE").Value
                        rwTemp.Item("QTRMC_NSRIE") = fSolicInforMovAlmacen.pdecCantidadSerie
                        rwTemp.Item("QTRMP_NSRIE") = fSolicInforMovAlmacen.pdecPesoSerie
                        rwTemp.Item("TOBSG") = fSolicInforMovAlmacen.pstrObservacionSerie
                    End If
                End With
                dtSeleccion.Rows.Add(rwTemp)
                dgOrdenesServicios.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
            End If
            .Dispose()
            fSolicInforMovAlmacen = Nothing
        End With
    End Sub

    Private Sub bsaRealizarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRealizarRecepcion.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgOrdenesServicios.RowCount <= 0 Then Exit Sub
        ' Procedemos a habilitar los controles para el registro de la recepción
        dtSeleccion.Rows.Clear()
        hgMercaderiaSeleccionada.Visible = True
        bsaRecepcionar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaRecepcionSeries.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaRealizarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        blnRealizarRecepcion = True
        grpLeyenda.Visible = True
    End Sub

    Private Sub bsaRecepcionSeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRecepcionSeries.Click
        ' Verificamos si se ha liberado la O/S 
        If dgSeries.CurrentRow.Cells("R_NRGDES").Value = 0 Then
            MessageBox.Show("No hay Solicitudes con saldo para desglosar.")
            Exit Sub
        End If

        ' Iniciamos el proceso de la solicitud de información para completar el registro de la O/S
        Dim fSolicInforMovAlmacen As frmSolicInforRecSAut = New frmSolicInforRecSAut
        With fSolicInforMovAlmacen
            Dim decTemp As Decimal = 0
            .pintCliente = txtCliente.pCodigo
            .pblnProcesarOSConLiberacion = True
            .pintSerie = "" & dgSeries.CurrentRow.Cells("R_NSRIE").Value
            .pstrCodigoMercaderia = "" & dgSeries.CurrentRow.Cells("R_CMRCD").Value
            .pstrMercaderia = "" & dgSeries.CurrentRow.Cells("R_TCMPMR").Value
            .pstrDetalleMercaderia = "" & dgSeries.CurrentRow.Cells("R_TMRCSR").Value
            ' Cantida Declarada
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_QBLTS").Value, decTemp)
            .pdecCantidadBultoDeclarada = decTemp
            ' Unidad
            .pstrUnidadBulto = "" & dgSeries.CurrentRow.Cells("R_CCLTPB").Value
            ' Cantidad Recepcionada
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_QBLTSR").Value, decTemp)
            .pdecCantidadBultoRecepcionada = decTemp
            ' Peso Bruto Declarado
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PBRKL").Value, decTemp)
            .pdecPesoBrutoDeclarada = decTemp
            ' Peso Bruto Recepcionada
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PBRKLR").Value, decTemp)
            .pdecPesoBrutoRecepcionada = decTemp
            ' Peso Neto Declarado
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PNTKL").Value, decTemp)
            .pdecPesoNetoDeclarada = decTemp
            ' Peso Neto Recepcionado
            Decimal.TryParse("" & dgSeries.CurrentRow.Cells("R_PNTKLR").Value, decTemp)
            .pdecPesoNetoRecepcionada = decTemp

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Información asociada a la Serie - siempre y cuando se haya ingresado alguna cantidad o peso
                If fSolicInforMovAlmacen.pdecCantidadSerie > 0 Or fSolicInforMovAlmacen.pdecPesoSerie > 0 Then
                    Dim rwTemp As DataRow = dtSeleccion.NewRow
                    With rwTemp
                        ' Información de la Orden de Servicio
                        rwTemp.Item("TCMPMR") = dgOrdenesServicios.CurrentRow.Cells("M_TCMPMR").Value
                        rwTemp.Item("NORDSR") = dgOrdenesServicios.CurrentRow.Cells("M_NORDSR").Value
                        rwTemp.Item("NSLCSR") = dgDetalleOrdenServicio.CurrentRow.Cells("M_NSLCSR").Value
                        rwTemp.Item("SINLBS") = dgDetalleOrdenServicio.CurrentRow.Cells("M_SINLBS").Value
                        ' Información asociada a la Serie
                        rwTemp.Item("NPDDPR") = dgOrdenesServicios.CurrentRow.Cells("M_NPDDPR").Value
                        rwTemp.Item("NSRIE") = dgSeries.CurrentRow.Cells("R_NSRIE").Value
                        rwTemp.Item("QTRMC_NSRIE") = fSolicInforMovAlmacen.pdecCantidadSerie
                        rwTemp.Item("QTRMP_NSRIE") = fSolicInforMovAlmacen.pdecPesoSerie
                        rwTemp.Item("TOBSG") = fSolicInforMovAlmacen.pstrObservacionSerie
                    End With
                    dtSeleccion.Rows.Add(rwTemp)
                    dgOrdenesServicios.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
                End If
            End If
            .Dispose()
            fSolicInforMovAlmacen = Nothing
        End With
    End Sub

    Private Sub dgOrdenesServicios_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesServicios.CurrentCellChanged
        If dgOrdenesServicios.CurrentRow Is Nothing Then Exit Sub

        Dim objFiltroDetalle As clsFiltro_ListarDetalleOS = New clsFiltro_ListarDetalleOS
        With objFiltroDetalle
            .pintCodigoCliente_CCLNT = txtCliente.pCodigo
            .pstrCompania_CCMPN = GLOBAL_COMPANIA
            .pstrDivision_CDVSN = GLOBAL_DIVISION
            .pintServicio_CSRVC = 1
            .pintNroOrdenServicio_NORDSR = dgOrdenesServicios.CurrentRow.Cells("M_NORDSR").Value
        End With
        dgDetalleOrdenServicio.DataSource = mfdtListar_DetalleOrdenServicio(objFiltroDetalle)
        dgSeries.DataSource = mfdtListar_Series(dgOrdenesServicios.CurrentRow.Cells("M_NPDDPR").Value)
    End Sub

    Private Sub frmRecepcionSDA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intTemp As Int64 = 0
        '-- Recuperamos los ultimos valores seleccionados
        Int64.TryParse("" & objAppConfig.GetValue("RECSDA_ClienteNombre", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
    End Sub

    Private Sub hgOrdenServicio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles hgOrdenServicio.Resize
        hgDetalleOS.Height = hgOrdenServicio.Height / 2
    End Sub
#End Region
End Class