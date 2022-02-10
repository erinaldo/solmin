Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Servicios
Imports RANSA.DATA.slnSOLMIN_SA.DAO.Servicios

Public Class ucServicios_FServF01
#Region " Atributos "
    Private TD_InfServF02 As TD_Inf_Servicio_F02 = New TD_Inf_Servicio_F02
    ' Datos de Seguridad 
    Private strUsuario As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargaInformacion(ByVal InfServ As TD_Inf_Servicio_F02)
        With InfServ
            txtNroOperacion.Text = .pNOPRCN_Operacion
            If .pFOPRCN_FechaOperacion_FNum = 0 Then
                dteFechaOperacion.Value = Date.Now
                dteFechaOperacion.Enabled = True
            Else
                dteFechaOperacion.Value = .pFOPRCN_FechaOperacion
                dteFechaOperacion.Enabled = False
            End If
            txtClienteFacturar.pCargarPorCodigo = .pCCLNFC_ClienteFacturar
            txtTipoProceso.pCargarPorCodigo = .pSTIPPR_Proceso
            txtCodigoContenedor.Text = .pCPRCN1_Contenedor
            txtSerieContenedor.Text = .pNSRCN1_SerieContenedor

            ' Cargamos el datagrid con la información respectiva
            Dim oTemp1 As TD_Servicios = New TD_Servicios
            oTemp1.pCCMPN_Compania = .pCCMPN_Compania
            oTemp1.pCDVSN_Division = .pCDVSN_Division
            oTemp1.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            oTemp1.pNOPRCN_Operacion = .pNOPRCN_Operacion
            oTemp1.pFOPRCN_FechaOperacion = .pFOPRCN_FechaOperacion
            ' Atributos Necesarios para realizar los registros de la información
            dgServicios.pClienteFacturar = .pCCLNFC_ClienteFacturar
            dgServicios.pContenedor = .pCPRCN1_Contenedor
            dgServicios.pSerieContenedor = .pNSRCN1_SerieContenedor
            dgServicios.pTipoProceso = .pSTIPPR_Proceso
            dgServicios.pUsuario = strUsuario
            ' Actualizamos la información a visualizar
            dgServicios.pActualizar(oTemp1)

            ' Cargamos el datagrid con la información de los bultos por operación 
            Dim oTemp2 As TD_OperacionPK = New TD_OperacionPK
            oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
            dgBultos.pActualizar(oTemp2)
        End With
    End Sub

    '    Private Function fblnValidar() As Boolean
    '        Dim strMensajeError As String = ""
    '        If Me.txtServicio.Text.Trim = "" Then _
    '            strMensajeError &= "Debe el Servicio dado al Cliente..." & vbNewLine
    '        If Me.txtCliente.pClienteSeleccionado.pCCLNT_Cliente = 0 Then _
    '            strMensajeError &= "Debe seleccionar el Cliente a Facturar..." & vbNewLine
    '        If Me.txtCodigoContenedor.Text.Trim <> "" And Me.txtCodigoContenedor.Text.Length <> 4 Then _
    '            strMensajeError &= "Debe ingresar Cuatro (4) Letras para el Código del Contenedor..." & vbNewLine
    '        If Me.txtSerieContenedor.Text.Trim <> "" And Me.txtSerieContenedor.Text.Length <> 7 Then _
    '            strMensajeError &= "Debe ingresar Siete (7) Dígitos para la Serie del Contenedor..." & vbNewLine
    '        If Me.txtCantidadAtendida.Text = "" Then Me.txtCantidadAtendida.Text = "0.00"
    '        If Me.txtCantidadAtendida.Text <= 0 Then _
    '            strMensajeError &= "Debe Cantidad Mayor a Cero..." & vbNewLine
    '        If blnEsNuevo Then
    '            If Me.txtNroOrdenCompra.Text = "" Then _
    '                strMensajeError &= "Debe Ingresar Nro de Orden Compra..." & vbNewLine
    '            If Me.txtDetalleOC.Text = "" Then _
    '                strMensajeError &= "Debe Ingresar Detalle de la Orden Compra..." & vbNewLine
    '            If Me.txtProveedor.pProveedorSelec.pCPRVCL_Proveedor = 0 Then _
    '                strMensajeError &= "Debe Ingresar el Proveedor..." & vbNewLine
    '        End If
    '        If strMensajeError <> "" Then
    '            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return False
    '            Exit Function
    '        End If
    '        Return True
    '    End Function

    '    Private Sub pActualizarServicio()
    '        Dim objTarifa As clsTarifa = New clsTarifa
    '        Dim varTarifa As clsServicio.NewType_Tarifa
    '        With varTarifa
    '            .pintCodigoCliente_CCLNT = intCCLNT
    '            .pstrCodigoCIA_CCMPN = GLOBAL_COMPANIA
    '            .pstrCodigoDivision_CDVSN = GLOBAL_DIVISION
    '            .pstrCodigoServicio_CSRVNV = txtServicio.Tag
    '        End With
    '    End Sub

    '    Private Sub pCargarServicio()
    '        If blnEsNuevo Then
    '            txtNroOperacion.Text = mfstrObtenerNuevoNroServicio()
    '            txtFechaOperacion.Text = Date.Now
    '            rbtProcManipuleo.Checked = True
    '            grpOrdenCompra.Enabled = True
    '            Me.Height = 500
    '        Else
    '            Me.Height = 397
    '            Dim objServicioCliente As clsServicioCliente = New clsServicioCliente
    '            Dim varServicioCliente As clsServiciosAdquiridos.NewType_ServicioCliente
    '            With varServicioCliente
    '                .pintCodigoCliente_CCLNT = intCCLNT
    '                .pintNumeroOperacion_NOPRCN = intNOPRCN
    '            End With
    '            If mfblnObtenerServicioCliente(varServicioCliente, objServicioCliente) Then
    '                With objServicioCliente
    '                    txtNroOperacion.Text = .pintNumeroOperacion_NOPRCN
    '                    txtFechaOperacion.Text = .pdteFechaTarifa_FTRFVG
    '                    txtServicio.Text = .pstrDetalleServicio_TCMTRF
    '                    txtServicio.Tag = .pintCodigoServicio_CSRVNV
    '                    txtTipoBulto.Text = .pstrTipoBulto_TIPBTO
    '                    txtPesoBulto.Text = .pdecPesoBulto_QPSOBL
    '                    txtCliente.pCargarPorCodigo = .pintCodigoClienteFacturar_CCLNFC
    '                    txtCantidadAtendida.Text = .pdecCantidadAtendida_QATNAN
    '                    txtImporteTotalDolar.Text = .pdecImporteTotalDolar_ITTOPD
    '                    txtImporteTotalSoles.Text = .pdecImporteTotalSoles_ITTOPS
    '                    txtCodigoContenedor.Text = .pstrCodigoContenedor_CPRCN1
    '                    txtSerieContenedor.Text = .pstrNroSerieContenedor_NSRCN1
    '                    txtUbicacionReferencial.Text = .pstrUbicacionReferencial_TUBRFR
    '                    If .pstrFlagEstadoFacturacion_SFCTOP = "F" Then
    '                        chkEstadoServicio.CheckState = CheckState.Checked
    '                        btnGuardar.Enabled = False
    '                    Else
    '                        chkEstadoServicio.CheckState = CheckState.Unchecked
    '                    End If
    '                    If .pstrFlagTipoProceso_STIPPR = "R" Then _
    '                        rbtProcRecepcion.Checked = True : rbtProcManipuleo.Enabled = False : rbtProcMontacarga.Enabled = False

    '                    If .pstrFlagTipoProceso_STIPPR = "D" Then _
    '                        rbtProcDespacho.Checked = True : rbtProcManipuleo.Enabled = False : rbtProcMontacarga.Enabled = False

    '                    If .pstrFlagTipoProceso_STIPPR = "M" Then _
    '                        rbtProcManipuleo.Checked = True

    '                    If .pstrFlagTipoProceso_STIPPR = "C" Then _
    '                        rbtProcMontacarga.Checked = True
    '                End With
    '            End If
    '            objServicioCliente = Nothing
    '        End If
    '    End Sub

    '    Private Sub pGuardarServicio()
    '        If Not fblnValidar() Then Exit Sub
    '        Dim varNuevoServicioCliente As clsServiciosAdquiridos.NewType_NuevoServicioCliente
    '        Dim objServicioCliente As clsServicioCliente = New clsServicioCliente
    '        With objServicioCliente
    '            .pintCodigoCliente_CCLNT = intCCLNT
    '            .pstrCodigoCIA_CCMPN = GLOBAL_COMPANIA
    '            .pstrCodigoDivision_CDVSN = GLOBAL_DIVISION
    '            .pintNumeroOperacion_NOPRCN = txtNroOperacion.Text
    '            Date.TryParse(txtFechaOperacion.Text, .pdteFechaTarifa_FTRFVG)
    '            .pintCodigoServicio_CSRVNV = txtServicio.Tag
    '            .pdecPesoBulto_QPSOBL = txtPesoBulto.Text
    '            .pintCodigoClienteFacturar_CCLNFC = txtCliente.pClienteSeleccionado.pCCLNT_Cliente
    '            .pdecCantidadAtendida_QATNAN = txtCantidadAtendida.Text
    '            .pdecImporteTotalDolar_ITTOPD = txtImporteTotalDolar.Text
    '            .pdecImporteTotalSoles_ITTOPS = txtImporteTotalSoles.Text
    '            .pstrCodigoContenedor_CPRCN1 = txtCodigoContenedor.Text.ToUpper
    '            .pstrNroSerieContenedor_NSRCN1 = txtSerieContenedor.Text
    '            .pstrUbicacionReferencial_TUBRFR = txtUbicacionReferencial.Text
    '            If Me.chkEstadoServicio.CheckState = CheckState.Checked Then
    '                .pstrFlagEstadoFacturacion_SFCTOP = "F"
    '            Else
    '                .pstrFlagEstadoFacturacion_SFCTOP = "P"
    '            End If
    '            If rbtProcRecepcion.Checked Then _
    '                .pstrFlagTipoProceso_STIPPR = "R"

    '            If rbtProcDespacho.Checked Then _
    '                .pstrFlagTipoProceso_STIPPR = "D"

    '            If rbtProcManipuleo.Checked Then _
    '                .pstrFlagTipoProceso_STIPPR = "M"

    '            If rbtProcMontacarga.Checked Then _
    '                .pstrFlagTipoProceso_STIPPR = "C"

    '        End With
    '        With varNuevoServicioCliente
    '            .objServicioCliente = objServicioCliente
    '            .pstrNroOrdenCompra_NORCML = Me.txtNroOrdenCompra.Text
    '            .pstrDetalleOrdenCompra_TDITES = Me.txtDetalleOC.Text
    '            .pintCodigoClienteTercero_CPRVCL = Me.txtProveedor.pProveedorSelec.pCPRVCL_Proveedor
    '        End With
    '        If mfblnGrabarServicioCliente(varNuevoServicioCliente, blnEsNuevo) Then
    '            objServicioCliente = Nothing
    '            Me.Close()
    '            Exit Sub
    '        End If
    '        objServicioCliente = Nothing
    '    End Sub

    '    Public Sub pCargarClienteFacturar(ByVal strCodigo As String)
    '        If strCodigo <> 0 Then txtCliente.pCargarPorCodigo = strCodigo
    '    End Sub
#End Region
#Region " Eventos "
    '    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '        Call pGuardarServicio()
    '    End Sub

    Sub New(ByVal value As TD_Inf_Servicio_F02, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With TD_InfServF02
            .pCCMPN_Compania = value.pCCMPN_Compania
            .pCDVSN_Division = value.pCDVSN_Division
            .pNOPRCN_Operacion = value.pNOPRCN_Operacion
            .pFOPRCN_FechaOperacion = value.pFOPRCN_FechaOperacion
            .pCCLNT_CodigoCliente = value.pCCLNT_CodigoCliente
            .pCCLNFC_ClienteFacturar = value.pCCLNFC_ClienteFacturar
            .pCPRCN1_Contenedor = value.pCPRCN1_Contenedor
            .pNSRCN1_SerieContenedor = value.pNSRCN1_SerieContenedor
            .pSTIPPR_Proceso = value.pSTIPPR_Proceso
        End With
        strUsuario = Usuario
    End Sub

    Private Sub ucServicios_FServF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TD_InfServF02.pCCLNT_CodigoCliente <> 0 Then Call pCargaInformacion(TD_InfServF02)
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class