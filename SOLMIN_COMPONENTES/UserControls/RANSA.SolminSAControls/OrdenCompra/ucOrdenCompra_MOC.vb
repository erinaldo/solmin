Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.OrdenCompra
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.OrdenCompra

Public Class ucOrdenCompra_MOC
#Region " Tipo "

#End Region
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private TD_OCPK As TD_OrdenCompraPK = New TD_OrdenCompraPK
    Private strUsuario As String = ""
    Private strMensajeError As String = ""
    Private blnResultado As Boolean = False
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCliente() As Int64
        Set(ByVal value As Int64)
            TD_OCPK.pCCLNT_CodigoCliente = value
        End Set
    End Property

    Public WriteOnly Property pOrdenCompra() As TD_OrdenCompraPK
        Set(ByVal value As TD_OrdenCompraPK)
            TD_OCPK.pCCLNT_CodigoCliente = value.pCCLNT_CodigoCliente
            TD_OCPK.pNORCML_NroOrdenCompra = value.pNORCML_NroOrdenCompra
            txtNroOrdenCompra.Enabled = False
        End Set
    End Property

    Public WriteOnly Property pUsuario() As String
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pCargarOC(ByVal objOCPK As TD_OrdenCompraPK) As Boolean
        Dim objOC As TD_OrdenCompra = daoOrdenCompra.Obtener(objSqlManager, objOCPK, strMensajeError)
        Dim blnExiste As Boolean = False
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If objOC.pNORCML_NroOrdenCompra <> "" Then
                With objOC
                    TD_OCPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
                    txtNroOrdenCompra.Text = .pNORCML_NroOrdenCompra
                    txtFechaOrdenCompra.Value = .pFORCML_FechaOCDte
                    If .pFSOLIC_FechaSolicOCInt > 0 Then
                        txtFechaSolicitud.Checked = True
                        txtFechaSolicitud.Value = .pFSOLIC_FechaSolicOCDte
                    Else
                        txtFechaSolicitud.Checked = False
                    End If
                    txtDescripcion.Text = .pTDSCML_Descripcion
                    txtProveedor.pCargarPorCodigo = .pCPRVCL_CodigoClienteTercero
                    txtAreaSolicitante.Text = .pTCMAEM_DescAreaEmpresa
                    cmbTermItern.pCargarPorCodigo = .pTTINTC_TerminoIntern
                    cmbMoneda.pCargarPorCodigo = .pCMNDA1_Moneda
                    txtEmpresaFacturar.Text = .pTEMPFAC_EmpresaFacturar
                    txtComprador.Text = .pTNOMCOM_NombreComprador
                    txtCentroCosto.Text = .pTCTCST_CentroCosto
                    txtRegionEmbarque.Text = .pCREGEMB_RegEmbarque
                    cmbMedioEmbarque.pCargarPorCodigo = .pCMEDTR_MedioTransporte
                    txtDestinoFinal.Text = .pTDEFIN_DestinoFinal
                    txtObservaciones.Text = .pTDAITM_Observaciones
                    txtCostoTotal.Text = .pIVCOTO_ImporteCostoTotal
                    txtTotalImpuesto.Text = .pIVTOIM_ImporteTotalImpuesto
                    txtTotalCompra.Text = .pIVTOCO_ImporteTotalCompra
                End With
                blnExiste = True
            Else
                Call pClear()
                TD_OCPK.pNORCML_NroOrdenCompra = ""
            End If
        End If
        Return blnExiste
    End Function

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtNroOrdenCompra.Text.Trim = "" Then strMensajeError &= "Falta : Nro. de Orden de Compra..." & vbNewLine
        If txtProveedor.pProveedorSelec.pCPRVCL_Proveedor = 0 Then strMensajeError &= "Falta : Proveedor..." & vbNewLine
        If txtDescripcion.Text.Trim = "" Then strMensajeError &= "Falta : Detalle de la Orden de Compra..." & vbNewLine
        If cmbTermItern.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Termino Internacional." & vbNewLine
        If cmbMoneda.pInformacionSelec.pCMNDA1_Codigo = "" Then strMensajeError &= "Falta : Moneda." & vbNewLine
        If cmbMedioEmbarque.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Medio de Transporte." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not fblnValidar() Then Exit Sub
        Dim objOCTemp As TD_OrdenCompra = New TD_OrdenCompra
        With objOCTemp
            .pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
            .pNORCML_NroOrdenCompra = txtNroOrdenCompra.Text.Trim
            .pFORCML_FechaOCDte = txtFechaOrdenCompra.Value
            If txtFechaSolicitud.Checked Then .pFSOLIC_FechaSolicOCDte = txtFechaSolicitud.Value
            .pCPRVCL_CodigoClienteTercero = txtProveedor.pProveedorSelec.pCPRVCL_Proveedor
            .pTDSCML_Descripcion = txtDescripcion.Text.Trim
            .pTCMAEM_DescAreaEmpresa = txtAreaSolicitante.Text.Trim
            .pTTINTC_TerminoIntern = cmbTermItern.pInformacionSelec.pCCMPRN_Codigo
            .pCMNDA1_Moneda = cmbMoneda.pInformacionSelec.pCMNDA1_Codigo
            .pTEMPFAC_EmpresaFacturar = txtEmpresaFacturar.Text.Trim
            .pTNOMCOM_NombreComprador = txtComprador.Text.Trim
            .pTCTCST_CentroCosto = txtCentroCosto.Text.Trim
            .pCREGEMB_RegEmbarque = txtRegionEmbarque.Text.Trim
            .pCMEDTR_MedioTransporte = cmbMedioEmbarque.pInformacionSelec.pCCMPRN_Codigo
            .pTDEFIN_DestinoFinal = txtDestinoFinal.Text.Trim
            Decimal.TryParse(txtCostoTotal.Text, .pIVCOTO_ImporteCostoTotal)
            Decimal.TryParse(txtTotalCompra.Text, .pIVTOCO_ImporteTotalCompra)
            Decimal.TryParse(txtTotalImpuesto.Text, .pIVTOIM_ImporteTotalImpuesto)
            .pTDAITM_Observaciones = txtObservaciones.Text.Trim
        End With
        If daoOrdenCompra.Grabar(objSqlManager, objOCTemp, strUsuario, strMensajeError) Then
            ' Validamos si es un nuevo registro
            If TD_OCPK.pNORCML_NroOrdenCompra = "" Then
                TD_OCPK.pNORCML_NroOrdenCompra = txtNroOrdenCompra.Text.Trim
                ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
                Dim fItem As ucItemOC_MItem = New ucItemOC_MItem
                With fItem
                    .pHabilitarNroItem = True
                    .pOrdenCompra = TD_OCPK
                    .pUsuario = strUsuario
                    .ShowDialog()
                End With
                Call pClear()
                txtNroOrdenCompra.Focus()
            Else
                blnResultado = True
                Me.Close()
            End If
        Else
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub txtNroOrdenCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrdenCompra.TextChanged
        txtNroOrdenCompra.CausesValidation = True
    End Sub

    Private Sub txtNroOrdenCompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroOrdenCompra.Validating
        If txtNroOrdenCompra.Text <> "" Then
            Dim objTemp As TD_OrdenCompraPK = New TD_OrdenCompraPK
            objTemp.pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
            objTemp.pNORCML_NroOrdenCompra = txtNroOrdenCompra.Text.Trim
            If Not pCargarOC(objTemp) Then txtNroOrdenCompra.Text = objTemp.pNORCML_NroOrdenCompra
        End If
        txtNroOrdenCompra.CausesValidation = False
    End Sub

    Private Sub ucOrdenCompra_MOC_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucOrdenCompra_MOC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub ucOrdenCompra_MOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager
        If TD_OCPK.pNORCML_NroOrdenCompra <> "" Then pCargarOC(TD_OCPK)
    End Sub
#End Region
#Region " Métodos "
    Public Sub pClear()
        txtNroOrdenCompra.Text = ""
        txtFechaOrdenCompra.Checked = False
        txtFechaSolicitud.Checked = False
        txtDescripcion.Text = ""
        txtProveedor.pClear()
        txtAreaSolicitante.Text = ""
        cmbTermItern.pClear()
        cmbMoneda.pClear()
        txtEmpresaFacturar.Clear()
        txtComprador.Clear()
        txtCentroCosto.Clear()
        txtRegionEmbarque.Clear()
        cmbMedioEmbarque.pClear()
        txtDestinoFinal.Clear()
        txtObservaciones.Clear()
        txtCostoTotal.Clear()
        txtTotalImpuesto.Clear()
        txtTotalCompra.Clear()
    End Sub
#End Region
End Class