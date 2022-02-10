Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO

Public Class frmAsignarGuiaRemision
#Region " Atributos "
  Private oInfGRemCargada As TD_Obj_InfGRemCargada
  Public Objeto_Entidad_Guia As New GuiaTransportista
  Private bResultado As Boolean = True
  Private mTPOPRCN As String
  Private mCCMPN As String
  Private mCDVSN As String
  Private mSGUIFC As String
  Private mSESGRP As String
  Private mSESTRG As String
#End Region
#Region " Propiedades "
  Public WriteOnly Property TPOPRCN() As String
    Set(ByVal value As String)
      mTPOPRCN = value
    End Set
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property SGUIFC() As String
    Set(ByVal value As String)
      mSGUIFC = value
    End Set
  End Property

  Public WriteOnly Property SESGRP() As String
    Set(ByVal value As String)
      mSESGRP = value
    End Set
  End Property

#End Region
#Region " Procedimientos y Funciones "

#End Region
#Region " Eventos "

  Private Sub frmLiquidacionFlete_DlgCargarGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Me.mSGUIFC = "F" OrElse Me.mSESGRP = "L" Then
      Me.btnAceptar.Enabled = False
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    With oInfGRemCargada
      If dteFechaSalidaCamion.Checked Then
        .pFSLDCM_FechaSalidaCamion = dteFechaSalidaCamion.Value
      Else
        .pFSLDCM_FechaSalidaCamion = New Date
      End If
      If dteFechaLlegadaCamion.Checked Then
        .pFLLGCM_FechaLlegadaCamion = dteFechaLlegadaCamion.Value
      Else
        .pFLLGCM_FechaLlegadaCamion = New Date
      End If
      .pCPRCN1_CodigoPropietarioContenedor1 = txtPropContenedor1.Text
      .pNSRCN1_SerieContenedor1 = txtSerieContenedor1.Text
      .pCPRCN2_CodigoPropietarioContenedor2 = txtPropContenedor2.Text
      .pNSRCN2_SerieContenedor2 = txtSerieContenedor2.Text
      .pQGLGSL_CantidadGlsGasolina = txtCantGlnGsl.Text
      .pQGLDSL_CantidadGlsDiesel = txtCantGlnDsl.Text
      .pNRHJCR_NroHojasCargui = txtNroHojaCarguio.Text
      .pQKLMRC_KilometrosRecorridos = txtKmRecorrido.Text
      .pQBLRMS_CantidadBultosRemision = txtBultosRemision.Text
      .pQBLRCP_CantidadBultosRecepcion = txtBultosRecepcion.Text
      .pPBRTOR_PesoBrutoRemision = txtPesoBrutoRemision.Text
      .pPBRDST_PesoBrutoRecepcion = txtPesoBrutoRecepcion.Text
      .pPTRAOR_PesoTaraRemision = txtPesoTaraRemision.Text
      .pPTRDST_PesoTaraRecepcion = txtPesoTaraRecepcion.Text
      .pQVLMOR_VolumenRemision = txtVolumenRemision.Text
      .pQVLMDS_VolumenRecepcion = txtVolumenRecepcion.Text
      .pQHRSRV_CantidadHorasServicio = txtHrasServicio.Text
      .pCCMPN_Compania = Me.mCCMPN
    End With
    Dim Objeto_Logica As New GuiaTransportista_BLL
    Dim sErrorMesage As String = ""
    If mTPOPRCN = 1 Then
      bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oInfGRemCargada, sErrorMesage)
    Else
      bResultado = Objeto_Logica.Modificar_GuiaRemisionLiqTransp(oInfGRemCargada, sErrorMesage)
    End If
    If Not bResultado Or sErrorMesage <> "" Then
      MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Else
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    bResultado = True
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmLiquidacionFlete_DlgCargarGuia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    e.Cancel = Not bResultado
  End Sub

  Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click
    Me.mSESTRG = IIf(Me.mSGUIFC.Trim.Equals(""), Me.mSESGRP, Me.mSGUIFC)
        'Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
        '        mCCMPN, mCDVSN, CType(txtNroOperacion.Text.Trim, Int64), CType(txtNroGuiaRemision.Text.Trim, Int64), mSESTRG, 0)
        Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
           mCCMPN, mCDVSN, CType(txtNroOperacion.Text.Trim, Int64), CType(txtNroGuiaRemision.Text.Trim, Int64), mSESTRG)
    ' No validamos el resultado obtenido por la ventana
    fMostrarInfAdic.ShowDialog()
  End Sub

#End Region
#Region " Métodos "
  Sub New(ByVal Datos As TD_Obj_InfGRemCargada)
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    If Not Datos Is Nothing Then
      oInfGRemCargada = Datos
      With oInfGRemCargada
        txtNroOperacion.Text = .pNOPRCN_NroOperacion
        txtNroLiquidacion.Text = .pNLQDCN_NroLiquidacion
        txtNroGuiaRemision.Text = .pNGUITR_GuiaRemisionCargada
        txtFechaGuiaRemision.Text = .pFGUITR_FechaGuiaRemision.ToString("dd/MM/yyyy")
        txtFechaRecepGuiaRemision.Text = .pFRCGRM_FechaRecepGuiaRemision.ToString("dd/MM/yyyy")
        txtNroGuiaTransporte.Text = .pNGUIRM_NroGuiaTransportista
        txtTransportista.Text = .pCTRSPT_Transportista & " - " & .pTCMTRT_RazSocialTransportista
        txtNroPlaca.Text = .pNPLVHT_Tracto
        txtNroBrevete.Text = .pCBRCNT_Brevete
        txtOrigen.Text = .pCLCLOR_CodigoLocalidadOrigen & " - " & .pTCMLCO_LocalidadOrigen
        txtDestino.Text = .pCLCLDS_CodigoLocalidadDestino & " - " & .pTCMLCD_LocalidadDestino
        If .pFSLDCM_FechaSalidaCamionFNum > 0 Then
          dteFechaSalidaCamion.Value = .pFSLDCM_FechaSalidaCamion
          dteFechaSalidaCamion.Checked = True
        Else
          dteFechaSalidaCamion.Checked = False
        End If
        If .pFLLGCM_FechaLlegadaCamionFNum > 0 Then
          dteFechaLlegadaCamion.Value = .pFLLGCM_FechaLlegadaCamion
          dteFechaLlegadaCamion.Checked = True
        Else
          dteFechaLlegadaCamion.Checked = False
        End If
        txtMercaderia.Text = .pCMRCDR_Mercaderia & " - " & .pTAMRCD_DetalleMercaderia
        txtPropContenedor1.Text = .pCPRCN1_CodigoPropietarioContenedor1
        txtSerieContenedor1.Text = .pNSRCN1_SerieContenedor1
        txtPropContenedor2.Text = .pCPRCN2_CodigoPropietarioContenedor2
        txtSerieContenedor2.Text = .pNSRCN2_SerieContenedor2
        txtCantGlnGsl.Text = .pQGLGSL_CantidadGlsGasolina
        txtCantGlnDsl.Text = .pQGLDSL_CantidadGlsDiesel
        txtNroHojaCarguio.Text = .pNRHJCR_NroHojasCargui
        txtKmRecorrido.Text = .pQKLMRC_KilometrosRecorridos
        txtBultosRemision.Text = .pQBLRMS_CantidadBultosRemision
        txtBultosRecepcion.Text = .pQBLRCP_CantidadBultosRecepcion
        txtPesoBrutoRemision.Text = .pPBRTOR_PesoBrutoRemision
        txtPesoBrutoRecepcion.Text = .pPBRDST_PesoBrutoRecepcion
        txtPesoTaraRemision.Text = .pPTRAOR_PesoTaraRemision
        txtPesoTaraRecepcion.Text = .pPTRDST_PesoTaraRecepcion
        txtVolumenRemision.Text = .pQVLMOR_VolumenRemision
        txtVolumenRecepcion.Text = .pQVLMDS_VolumenRecepcion
        txtHrasServicio.Text = .pQHRSRV_CantidadHorasServicio
        txtGuiasSeleccionadas.Text = .pRELGUI_RelacionGuiaHijas
      End With
    Else
      btnAceptar.Enabled = False
    End If
  End Sub
#End Region

End Class