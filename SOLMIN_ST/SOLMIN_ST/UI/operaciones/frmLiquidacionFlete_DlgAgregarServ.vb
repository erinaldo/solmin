Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Unidad
Imports Ransa.TypeDef.Moneda
Imports SOLMIN_ST.NEGOCIO

Public Class frmLiquidacionFlete_DlgAgregarServ
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
    Private strCompania As String = ""
    Private strDivision As String = ""

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
        Try
            With oInfServicio
                If cmbServicio.Resultado Is Nothing Then Exit Sub
                If cboUnidad.Resultado Is Nothing Then Exit Sub
                If cboMoneda_2.SelectedValue Is Nothing Then Exit Sub

                .pCSRVC_Servicio = CType(cmbServicio.Resultado, Ransa.Controls.ServTransp.TD_Obj_ServTransp).pCSRVNV_Servicio
                .pTRFSRG_RefrenciaServicioGuia = txtReferencia.Text
                .pCMNDGU_MonedaGuia = cboMoneda_2.SelectedValue
                .pISRVGU_importeServicio = txtImporte.Text
                .pQCNDTG_CantServicioGuia = txtCantidadServ.Text
                '.pCUNDSR_Unidad = CType(cboUnidad.Resultado, TD_Inf_Unidad_L02).pCUNDMD_Unidad
                .pCUNDSR_Unidad = CType(cboUnidad.Resultado, Ransa.Controls.Unidad.TD_Inf_Unidad_L02).pCUNDMD_Unidad

                If chkFacturacionCliente.CheckState = CheckState.Checked Then
                    .pSFCTTR_StatusFacturado = "X"
                Else
                    .pSFCTTR_StatusFacturado = ""
                End If
                'If .pCSRVC_Servicio <> 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                sDetalleServicio = CType(cmbServicio.Resultado, Ransa.Controls.ServTransp.TD_Obj_ServTransp).pTCMTRF_Descripcion
                'Else
                'HelpClass.MsgBox("No se permite asignar el servicio " & .pCSRVC_Servicio & " de manera adicional", MessageBoxIcon.Information)
                'End If

            End With
        Catch ex As Exception

        End Try
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
        strCompania = Compania
        strDivision = Division
    End Sub

    Private Sub frmLiquidacionFlete_DlgLiquServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With oInfServicio
            lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
            lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
            txtCorrelativoServ.Text = .pNCRRGU_CorrServ
            'ddlServicio.pCodigoServicio = .pCSRVC_Servicio
            txtReferencia.Text = .pTRFSRG_RefrenciaServicioGuia
            'cmbMoneda.pCargarPorCodigo = .pCMNDGU_MonedaGuia
            txtImporte.Text = .pISRVGU_importeServicio
            txtCantidadServ.Text = .pQCNDTG_CantServicioGuia
            'txtUnidad.pCargarPorCodigo(.pCUNDSR_Unidad.Trim)
            If .pSFCTTR_StatusFacturado = "" Then
                chkFacturacionCliente.CheckState = CheckState.Unchecked
            Else
                chkFacturacionCliente.CheckState = CheckState.Checked
            End If
            'Carga el control de los servicios a facturar
            Try
                Dim oListColum As New Hashtable
                Dim oColumnas As New DataGridViewTextBoxColumn
                oColumnas.Name = "pCSRVNV_Servicio"
                oColumnas.DataPropertyName = "pCSRVNV_Servicio"
                oColumnas.HeaderText = "Código"
                oListColum.Add(1, oColumnas)
                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "pTCMTRF_Descripcion"
                oColumnas.DataPropertyName = "pTCMTRF_Descripcion"
                oColumnas.HeaderText = "Servicio"
                oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                oListColum.Add(2, oColumnas)
                'Dim obr As New Ransa.DAO.ServTransp.cServTransp
                Dim obr As New Ransa.Controls.ServTransp.cServTransp
                Dim obe As New Ransa.Controls.ServTransp.TD_Obj_ServTransp
                cmbServicio.DataSource = Nothing
                cmbServicio.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.ServTransp.TD_Obj_ServTransp)(obr.fdtListar(strCompania, strDivision))
                Me.cmbServicio.ListColumnas = oListColum
                Me.cmbServicio.Cargas()
                Me.cmbServicio.Limpiar()
                Me.cmbServicio.ValueMember = "pCSRVNV_Servicio"
                Me.cmbServicio.DispleyMember = "pTCMTRF_Descripcion"
                Me.cmbServicio.Valor = .pCSRVC_Servicio

                ' Moneda
                Dim obr2 As New ServicioMercaderia_BLL
                'cboMoneda_2.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Moneda)(obr2.fdtListar_Moneda_L01())
                cboMoneda_2.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Moneda.TD_Moneda)(obr2.fdtListar_Moneda_L01())
                cboMoneda_2.ValueMember = "pCMNDA1_Codigo"
                cboMoneda_2.DisplayMember = "pTMNDA_Detalle"
                cboMoneda_2.SelectedValue = .pCMNDGU_MonedaGuia.ToString

                'Unidad
                oListColum = New Hashtable
                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "pCUNDMD_Unidad"
                oColumnas.DataPropertyName = "pCUNDMD_Unidad"
                oColumnas.HeaderText = "Abreviatura"
                oListColum.Add(1, oColumnas)
                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "pTABRUN_Descripcion"
                oColumnas.DataPropertyName = "pTABRUN_Descripcion"
                oColumnas.HeaderText = "Unidad"
                oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                oListColum.Add(2, oColumnas)
                cboUnidad.DataSource = Nothing

                'Dim obr3 As New Ransa.DAO.Unidad.cUnidad
                'cboUnidad.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Inf_Unidad_L02)(obr3.fdtListar("", ""))
                'Me.cboUnidad.ListColumnas = oListColum
                'Me.cboUnidad.Cargas()
                'Me.cboUnidad.Limpiar()
                'Me.cboUnidad.ValueMember = "pCUNDMD_Unidad"
                'Me.cboUnidad.DispleyMember = "pTABRUN_Descripcion"
                'Me.cboUnidad.Valor = .pCUNDSR_Unidad.Trim
                'Me.btnAceptar.Select()
                'Dim obr3 As New Ransa.DAO.Unidad.cUnidad
                Dim obr3 As New Ransa.Controls.Unidad.cUnidad
                Dim ref As String = ""
                'cboUnidad.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
                cboUnidad.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
                Me.cboUnidad.ListColumnas = oListColum
                Me.cboUnidad.Cargas()
                Me.cboUnidad.Limpiar()
                Me.cboUnidad.ValueMember = "pCUNDMD_Unidad"
                Me.cboUnidad.DispleyMember = "pTABRUN_Descripcion"
                Me.cboUnidad.Valor = .pCUNDSR_Unidad.ToString.Trim
                Me.btnAceptar.Select()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
        sDetalleServicio = ""
    End Sub
#End Region


End Class
