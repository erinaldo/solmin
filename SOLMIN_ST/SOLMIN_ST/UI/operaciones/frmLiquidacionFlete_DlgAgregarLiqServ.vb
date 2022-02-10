Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Unidad
Imports Ransa.TypeDef.Moneda


Public Class frmLiquidacionFlete_DlgAgregarLiqServ

#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------
    Private sDetalleServicio As String = ""
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInfServicio As TD_Obj_GRemAgregarServCargadasGTranspLiq = New SOLMIN_ST.ENTIDADES.mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq
    Private oInfLiquServ As TD_Obj_GRemLiquServCargadasGTranspLiq = New SOLMIN_ST.ENTIDADES.mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq
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
    Public ReadOnly Property pInfoServicioLiq() As TD_Obj_GRemLiquServCargadasGTranspLiq
        Get
            Return oInfLiquServ
        End Get
    End Property

#End Region

    Sub New(ByVal Compania As String, ByVal Division As String, ByVal oTemp As TD_Obj_GRemLiquServCargadasGTranspLiq)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oInfLiquServ = oTemp
        strCompania = Compania
        strDivision = Division
    End Sub

    Private Sub frmLiquidacionFlete_DlgAgregarLiqServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_InfoServicio()
        Cargar_Proveedor()
    End Sub
    Private Sub Cargar_InfoServicio()

        With oInfLiquServ
            lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
            lblServicio.Text &= "   " & .pCSRVC_Servicio & " - " & .pTCMTRF_DetalleServicio
            lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
            txtCorrelativoServ.Text = .pNCRRGU_CorrServ
            txtImporteLiq.Text = .pILQDTR_ImporteLiquidacionTransp
            txtCantidadLiq.Text = .pQCNDLG_CantidadServicioLiquidacion

            If .pSLQDTR_StatusLiquTransporte = "" Then
                chkLiquTransporte.CheckState = CheckState.Unchecked
            Else
                chkLiquTransporte.CheckState = CheckState.Checked
            End If
            'Unidad
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
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
            cboUnidadLiq.DataSource = Nothing

            Dim ref As String = ""
            'Dim obr3 As New Ransa.DAO.Unidad.cUnidad
            Dim obr3 As New Ransa.Controls.Unidad.cUnidad
            'cboUnidadLiq.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
            cboUnidadLiq.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
            Me.cboUnidadLiq.ListColumnas = oListColum
            Me.cboUnidadLiq.Cargas()
            Me.cboUnidadLiq.Limpiar()
            Me.cboUnidadLiq.ValueMember = "pCUNDMD_Unidad"
            Me.cboUnidadLiq.DispleyMember = "pTABRUN_Descripcion"
            Me.cboUnidadLiq.Valor = .pCUNDTR_Unidad.ToString.Trim

            ' Moneda Liq. Servicio
            Dim obr5 As New NEGOCIO.ServicioMercaderia_BLL
            'cmbMoneda_1.DataSource = HelpClass.CreateObjectsFromDataTable(Of TD_Moneda)(obr5.fdtListar_Moneda_L01())
            cmbMoneda_1.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Moneda.TD_Moneda)(obr5.fdtListar_Moneda_L01())
            cmbMoneda_1.ValueMember = "pCMNDA1_Codigo"
            cmbMoneda_1.DisplayMember = "pTMNDA_Detalle"
            cmbMoneda_1.SelectedValue = .pCMNLQT_Moneda.ToString
        End With

    End Sub
    Private Sub Cargar_Proveedor()
        'Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'obeTransportista.pCCMPN_Compania = strCompania
        'cboTransportista.pCargar(obeTransportista)

        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        With oInfLiquServ
            obeTransportista.pCCMPN_Compania = strCompania
            obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
            cboTransportista.pCargar(obeTransportista)
        End With

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'Liquidacion Servicio
            If cboTransportista.pRucTransportista.Trim.Equals("") Then Exit Sub
            If cboUnidadLiq.Resultado Is Nothing Then Exit Sub
            If cmbMoneda_1.SelectedValue Is Nothing Then Exit Sub

            With oInfLiquServ
                .pNRUCTR_RucProveedor = cboTransportista.pRucTransportista
                .pCMNLQT_Moneda = cmbMoneda_1.SelectedValue
                .pILQDTR_ImporteLiquidacionTransp = txtImporteLiq.Text
                .pQCNDLG_CantidadServicioLiquidacion = txtCantidadLiq.Text
                '.pCUNDTR_Unidad = CType(cboUnidadLiq.Resultado, TD_Inf_Unidad_L02).pCUNDMD_Unidad
                .pCUNDTR_Unidad = CType(cboUnidadLiq.Resultado, Ransa.Controls.Unidad.TD_Inf_Unidad_L02).pCUNDMD_Unidad
                If chkLiquTransporte.CheckState = CheckState.Checked Then
                    .pSLQDTR_StatusLiquTransporte = "X"
                Else
                    .pSLQDTR_StatusLiquTransporte = ""
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        oInfLiquServ.pClear()
        Me.Close()
    End Sub

End Class
