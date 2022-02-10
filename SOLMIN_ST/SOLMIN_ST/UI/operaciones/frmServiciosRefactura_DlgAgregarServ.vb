Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmServiciosRefactura_DlgAgregarServ
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private sDetalleServicio As String = ""
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInfServicio As TD_Obj_GRemAgregarServCargadasGTranspLiq = New SOLMIN_ST.ENTIDADES.mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pInformacionServicio() As TD_Obj_GRemAgregarServCargadasGTranspLiq
        Get
            Return oInfServicio
        End Get
    End Property

    Public ReadOnly Property pDetalleServicio() As String
        Get
            Return sDetalleServicio
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "

#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        With oInfServicio
            .pCSRVC_Servicio = cmbServicio.pCodigoServicio
            .pTRFSRG_RefrenciaServicioGuia = txtReferencia.Text
            .pCMNDGU_MonedaGuia = cmbMoneda.pInformacionSelec.pCMNDA1_Codigo
            .pISRVGU_importeServicio = txtImporte.Text
            .pQCNDTG_CantServicioGuia = txtCantidadServ.Text
            .pCUNDSR_Unidad = txtUnidad.pUnidad

            If chkFacturacionCliente.CheckState = CheckState.Checked Then
                .pSFCTTR_StatusFacturado = "X"
            Else
                .pSFCTTR_StatusFacturado = ""
            End If
            'If .pCSRVC_Servicio <> 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            sDetalleServicio = cmbServicio.pDescripcionServicio
            'Else
            'HelpClass.MsgBox("No se permite asignar el servicio " & .pCSRVC_Servicio & " de manera adicional", MessageBoxIcon.Information)
            'End If

        End With
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        oInfServicio.pClear()
        sDetalleServicio = ""
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal oTemp As TD_Obj_GRemAgregarServCargadasGTranspLiq)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oInfServicio = oTemp
        cmbServicio.pCargar(Compania, Division)
        txtUnidad.pCompania = Compania
    End Sub

    'estaba en el servidor pero no bajado
    'Private Sub frmServiciosRefactura_DlgAgregarServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    With oInfServicio
    '        lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
    '        lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
    '        txtCorrelativoServ.Text = .pNCRRGU_CorrServ
    '        cmbServicio.pCodigoServicio = .pCSRVC_Servicio
    '        txtReferencia.Text = .pTRFSRG_RefrenciaServicioGuia
    '        cmbMoneda.pCargarPorCodigo = .pCMNDGU_MonedaGuia
    '        txtImporte.Text = .pISRVGU_importeServicio
    '        txtCantidadServ.Text = .pQCNDTG_CantServicioGuia
    '        txtUnidad.pCargarPorCodigo(.pCUNDSR_Unidad.Trim)
    '        'If .pSFCTTR_StatusFacturado = "" Then
    '        '    chkFacturacionCliente.CheckState = CheckState.Unchecked
    '        'Else
    '        chkFacturacionCliente.CheckState = CheckState.Checked
    '        'End If
    '    End With
    '    sDetalleServicio = ""
    'End Sub

    'se estaba trabajando de esta forma
    'Private Sub frmServiciosRefactura_DlgAgregarServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    With oInfServicio
    '        lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
    '        lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
    '        txtCorrelativoServ.Text = .pNCRRGU_CorrServ
    '        cmbServicio.pCodigoServicio = .pCSRVC_Servicio
    '        txtReferencia.Text = .pTRFSRG_RefrenciaServicioGuia
    '        cmbMoneda.pCargarPorCodigo = .pCMNDGU_MonedaGuia
    '        txtImporte.Text = .pISRVGU_importeServicio
    '        txtCantidadServ.Text = .pQCNDTG_CantServicioGuia
    '        txtUnidad.pCargarPorCodigo(.pCUNDSR_Unidad.Trim)
    '        If .pSFCTTR_StatusFacturado = "" Then
    '            chkFacturacionCliente.CheckState = CheckState.Unchecked
    '        Else
    '            chkFacturacionCliente.CheckState = CheckState.Checked
    '        End If
    '    End With
    '    sDetalleServicio = ""
    'End Sub
    'se ha quedado como se estaba trabajando
    Private Sub frmServiciosRefactura_DlgAgregarServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With oInfServicio
            lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
            lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
            txtCorrelativoServ.Text = .pNCRRGU_CorrServ
            cmbServicio.pCodigoServicio = .pCSRVC_Servicio
            txtReferencia.Text = .pTRFSRG_RefrenciaServicioGuia
            cmbMoneda.pCargarPorCodigo = .pCMNDGU_MonedaGuia
            txtImporte.Text = .pISRVGU_importeServicio
            txtCantidadServ.Text = .pQCNDTG_CantServicioGuia
            txtUnidad.pCargarPorCodigo(.pCUNDSR_Unidad.Trim)
            If .pSFCTTR_StatusFacturado = "" Then
                chkFacturacionCliente.CheckState = CheckState.Unchecked
            Else
                chkFacturacionCliente.CheckState = CheckState.Checked
            End If
        End With
        sDetalleServicio = ""
    End Sub
#End Region
End Class
