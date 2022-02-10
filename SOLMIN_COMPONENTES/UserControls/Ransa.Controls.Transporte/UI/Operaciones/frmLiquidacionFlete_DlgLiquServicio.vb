
'Imports Ransa.TypeDef.Unidad
Imports Ransa.TypeDef.Moneda
Imports System.Windows.Forms
Imports Ransa.Controls.Unidad
Public Class frmLiquidacionFlete_DlgLiquServicio
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oInfLiquServ As mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq = New mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strCompania As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pInformacionServicio() As mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq
        Get
            Return oInfLiquServ
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "

#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cboUnidad.Resultado Is Nothing Then Exit Sub
            If cboMoneda_2.SelectedValue Is Nothing Then Exit Sub

            With oInfLiquServ
                .pCMNLQT_Moneda = cboMoneda_2.SelectedValue
                .pILQDTR_ImporteLiquidacionTransp = txtTarifa.Text
                .pQCNDLG_CantidadServicioLiquidacion = txtImporte.Text
                .pCUNDTR_Unidad = CType(cboUnidad.Resultado, TD_Inf_Unidad_L02).pCUNDMD_Unidad
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        oInfLiquServ.pClear()
        Me.Close()
    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal oTemp As mantenimientos.TD_Obj_GRemLiquServCargadasGTranspLiq)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oInfLiquServ = oTemp
        strCompania = oTemp.pCCMPN_Compania
    End Sub

    Private Sub frmLiquidacionFlete_DlgLiquServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With oInfLiquServ
            lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
            lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
            lblServicio.Text &= "   " & .pCSRVC_Servicio & " - " & .pTCMTRF_DetalleServicio
            lblCorrelativoServ.Text &= "   " & .pNCRRGU_CorrServ
            txtTarifa.Text = .pILQDTR_ImporteLiquidacionTransp
            txtImporte.Text = .pQCNDLG_CantidadServicioLiquidacion
            If .pSLQDTR_StatusLiquTransporte = "" Then
                chkLiquTransporte.CheckState = CheckState.Unchecked
            Else
                chkLiquTransporte.CheckState = CheckState.Checked
            End If

            ' Moneda
            Dim obr2 As New ServicioMercaderia_BLL
            'cboMoneda_2.DataSource = HelpClassST.CreateObjectsFromDataTable(Of TD_Moneda)(obr2.fdtListar_Moneda_L01())
            cboMoneda_2.DataSource = HelpClassST.CreateObjectsFromDataTable(Of Ransa.Controls.Moneda.TD_Moneda)(obr2.fdtListar_Moneda_L01())
            cboMoneda_2.ValueMember = "pCMNDA1_Codigo"
            cboMoneda_2.DisplayMember = "pTMNDA_Detalle"
            cboMoneda_2.SelectedValue = .pCMNLQT_Moneda.ToString

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
            cboUnidad.DataSource = Nothing

            Dim ref As String = ""
            'Dim obr3 As New Ransa.DAO.Unidad.cUnidad
            Dim obr3 As New Unidad.cUnidad
            cboUnidad.DataSource = HelpClassST.CreateObjectsFromDataTable(Of TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
            Me.cboUnidad.ListColumnas = oListColum
            Me.cboUnidad.Cargas()
            Me.cboUnidad.Limpiar()
            Me.cboUnidad.ValueMember = "pCUNDMD_Unidad"
            Me.cboUnidad.DispleyMember = "pTABRUN_Descripcion"
            Me.cboUnidad.Valor = .pCUNDTR_Unidad.ToString.Trim
            Me.btnAceptar.Select()

        End With
    End Sub
#End Region
End Class