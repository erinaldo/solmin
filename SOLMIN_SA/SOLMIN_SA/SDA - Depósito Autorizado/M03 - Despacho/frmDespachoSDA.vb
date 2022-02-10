Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDA
'Imports RANSA.NEGO.slnSOLMIN_SDA.DespachoSDS

Public Class frmDespachoSDA
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region " Atributos "
    Private blnRealizarDespacho As Boolean = False
    Private blnStatusNuevoAcoplado As Boolean = False
    '-- Tipo de Movimiento
    Private strTipoMovimiento_STPING As String = ""
    Private strDetalleTipoMovimiento_TTPING As String = ""
    '-- Desglose
    Private strDesglose_CTPOCN As String = "N"
    '-- Tipo Almacen
    Private strTipoAlmacen_CTPALM As String = ""
    Private strDetalleTipoAlmacen_TALMC As String = ""
    Private strAlmacen_CALMC As String = ""
    Private strDetalleAlmacen_TCMPAL As String = ""
    '-- Persiana
    Private strPersiana As String = ""
    '-- Contiene la información de la Cabecera
    'Private objMovimientoMercaderia As clsMovimientoMercaderia
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
                '.pstrCompania_CCMPN = GLOBAL_COMPANIA
                '.pstrDivision_CDVSN = GLOBAL_DIVISION
                '.pintServicio_CSRVC = 1
            End With
            blnRealizarDespacho = False
            'dgMercaderias.DataSource = mfdtListar_OrdenServicioPendientes(objFiltro)
            '-- Se libera los procesos automáticos
            '-- Se habilita el botón para realizar una nueva Despacho
            bsaRealizarDespacho.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            '-- Limpiamos la información de la cabecera
            hgMercaderiaSeleccionada.Visible = False
            grpLeyenda.Visible = False
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pMercadería_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'Case Keys.F2
            '    Call pGuardarMercadería()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub pProcesarDespacho()
        'If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
        '    MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    If mfblnDespacho_Mercaderia(objMovimientoMercaderia) Then Call pActualizarInformacion()
        'End If
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub bsaRealizarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRealizarDespacho.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgMercaderias.RowCount <= 0 Then Exit Sub
        ' Procedemos a habilitar los controles para el registro de la Despacho
        dtMercaderiaSeleccionadas.Rows.Clear()
        hgMercaderiaSeleccionada.Visible = True
        bsaRealizarDespacho.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        blnRealizarDespacho = True
        grpLeyenda.Visible = True
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub bsaAgregarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregarMercaderia.Click
        If dgMercaderias.CurrentRow.Cells("M_FUNDS3").Value = "C" Then
            Call mpMsjeVarios(enumMsjVarios.Despacho_OrdenServicioCerrada)
            Exit Sub
        Else
            Dim fSolicInforMovAlmacen As frmSolicInforRecAlmacen = New frmSolicInforRecAlmacen
            With fSolicInforMovAlmacen
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' INICIO
                    Dim rwTemp As DataRow = dtMercaderiaSeleccionadas.NewRow
                    With rwTemp
                        rwTemp.Item("TCMPMR") = dgMercaderias.CurrentRow.Cells("M_TCMPMR").Value
                        rwTemp.Item("NORDSR") = dgMercaderias.CurrentRow.Cells("M_NORDSR").Value
                        rwTemp.Item("NORCCL") = fSolicInforMovAlmacen.pstrNroOrdenCompra
                        rwTemp.Item("NGUICL") = fSolicInforMovAlmacen.pstrNroGuiaCliente
                        rwTemp.Item("NRUCLL") = fSolicInforMovAlmacen.pstrNroRUCCliente
                        'rwTemp.Item("STPING") = fSolicInforMovAlmacen.pstrTipoRecepcion 
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
                        rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion
                        rwTemp.Item("CUNCN6") = dgMercaderias.CurrentRow.Cells("M_CUNCN6").Value
                        rwTemp.Item("CUNPS6") = dgMercaderias.CurrentRow.Cells("M_CUNPS6").Value
                        rwTemp.Item("CUNVL6") = dgMercaderias.CurrentRow.Cells("M_CUNVL6").Value
                        rwTemp.Item("FUNDS3") = fSolicInforMovAlmacen.pstrRecObservacion
                    End With
                    dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                    dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
                End If
                .Dispose()
                fSolicInforMovAlmacen = Nothing
            End With
        End If
    End Sub

    Private Sub bsaProcesarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarDespacho.Click
        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen
            .pintCodigoCliente = txtCliente.pCodigo
            .pstrRazonSocialCliente = txtCliente.pRazonSocial
            ' modificar luego
            .pintServicio = 2
            .pstrAdicinarInfTitulo = "Despacho"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                ' objMovimientoMercaderia = .pobjInformacionIngresada
                ' Procedemos con el procesamiento de la información
                ' Call pProcesarDespacho()
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With
    End Sub

    Private Sub frmDespachoSDA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
        ' Obtengo los últimos almacenes para este cliente
        Call mfblnObtener_InfUltimoAlmacenSegunCliente(intTemp, strTipoAlmacen_CTPALM, strDetalleTipoAlmacen_TALMC, strAlmacen_CALMC, strDetalleAlmacen_TCMPAL)
        ' Obtengo el Tipo de Movimiento por defecto
        Call mfstrDefecto_TipoMovimientoDespacho(strTipoMovimiento_STPING, strDetalleTipoMovimiento_TTPING)
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgMercaderias.DataSource = Nothing
    End Sub
#End Region
End Class