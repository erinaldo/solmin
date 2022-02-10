Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones

Public Class frmReasignarRecurso

#Region "Variables"
  'Public _Transportista As String = "" 
  'Public _Tracto As String = "" 
  'Public _Acoplado As String = "" 
  'Public _Conductor As String = "" 
  'Public _SegundoConductor As String = "" 
  Public _Estado As Boolean = True
  Public _obj_Entidad As Detalle_Solicitud_Transporte


  Private _CCMPN As String
  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property


  Private _CDVSN As String
  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property


  Private _CPLNDV As Double
  Public Property CPLNDV() As Double
    Get
      Return _CPLNDV
    End Get
    Set(ByVal value As Double)
      _CPLNDV = value
    End Set
  End Property
    'Private _NGUITR As Double
    'Public Property NGUITR() As Double
    '    Get
    '        Return _NGUITR
    '    End Get
    '    Set(ByVal value As Double)
    '        _NGUITR = value
    '    End Set
    'End Property

#End Region

#Region "Properties"

#End Region

#Region "Eventos"

    Private Sub frmReasignarRecurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            Me.txtNroSolicitud.Text = Me._obj_Entidad.NCSOTR
            Me.txtItemSolicitud.Text = Me._obj_Entidad.NCRRSR
            Me.txtJunta.Text = Me._obj_Entidad.NPLNJT
            Me.txtItemJunta.Text = Me._obj_Entidad.NCRRPL

            Me.Cargar_Combo_Transportista()
            Me.Cargar_Combo_Vehiculo()

            If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("") Then
                Me.ctbTransportista.Enabled = False
                Me.ctbTracto.Enabled = False
                Me.Cargar_Combo_Acoplado_Conductor()
            End If
            If _obj_Entidad.NGUITR <> 0 Then
                ctbAcoplado.Enabled = False
                cmbConductor.Enabled = False
            End If
            Cargar_Combo_Acoplado()
            If _obj_Entidad.NCTAVC <> "0" OrElse _obj_Entidad.NCSLPE <> "0" Then Me.cmbConductor.Enabled = False
            If _obj_Entidad.NCTAV2 <> "0" OrElse _obj_Entidad.NCSLP2 <> "0" Then Me.cmbSegundoConductor.Enabled = False

            Cargar_Combo_Acoplado_Conductor(Me._obj_Entidad.CBRCNT, Me._obj_Entidad.CBRCN2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

 


  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Try
      If _Estado = False Then Exit Try
      If Validar_Recursos_Asignados() = True Then Exit Sub

      Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
      Dim Objeto_Logica As New Detalle_Solicitud_Transporte_BLL
      Objeto_Entidad.NCSOTR = Me.txtNroSolicitud.Text.Trim
      Objeto_Entidad.NCRRSR = Me.txtItemSolicitud.Text.Trim
      Objeto_Entidad.NPLNJT = Me.txtJunta.Text.Trim
      Objeto_Entidad.NCRRPL = Me.txtItemJunta.Text.Trim
      Objeto_Entidad.NRUCTR = Me.ctbTransportista.pRucTransportista
      Objeto_Entidad.NPLCUN = Me.ctbTracto.pNroPlacaUnidad
      Objeto_Entidad.NPLCAC = Me.ctbAcoplado.pNroAcoplado
      Objeto_Entidad.CBRCNT = Me.cmbConductor.pBrevete
      Objeto_Entidad.CBRCN2 = Me.cmbSegundoConductor.pBrevete
      Objeto_Entidad.CULUSA = MainModule.USUARIO
            'Objeto_Entidad.FULTAC = HelpClass.TodayNumeric
            'Objeto_Entidad.HULTAC = HelpClass.NowNumeric
            Objeto_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      Objeto_Entidad.CCMPN = _CCMPN
      Objeto_Entidad.CDVSN = _CDVSN
      Objeto_Entidad.CPLNDV = _CPLNDV

      Objeto_Entidad.NCSOTR = Objeto_Logica.Actualizar_Recursos_Asignados_Solicitud(Objeto_Entidad).NCSOTR
            'If Objeto_Entidad.NCSOTR = 0 Then
            '  HelpClass.ErrorMsgBox()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  'Private Sub ctbTransportista_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    If Me.ctbTransportista.pNRUCTR_RucTransportista.Trim.Equals("") Or Me.ctbTransportista.pNRUCTR_RucTransportista <> Me._obj_Entidad.NRUCTR Then
  '        Me.ctbTracto.pClear()
  '        Me.ctbAcoplado.pClear()
  '        Me.ctbConductor.Limpiar()
  '        Me.ctbSegundoConductor.Limpiar()
  '    End If
  '    'Me.Cargar_Combo_Vehiculo()
  '    Me.Cargar_Combo_Acoplado_Conductor()
  '    Me._obj_Entidad.NRUCTR = Me.ctbTransportista.pNRUCTR_RucTransportista
  'End Sub

#End Region

#Region "Metodos y Funciones"

  Private Sub Cargar_Combo_Transportista()
        'Try
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = _CCMPN
        If Not Me._obj_Entidad.NRUCTR.Trim.Equals("") Then
            obeTransportista.pNRUCTR_RucTransportista = Me._obj_Entidad.NRUCTR
        End If
        ctbTransportista.pCargar(obeTransportista)
        'Catch : End Try
  End Sub

  Private Sub Cargar_Combo_Vehiculo()

        'Try
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
        obeTracto.pCCMPN_Compania = _CCMPN
        obeTracto.pCDVSN_Division = _CDVSN
        obeTracto.pCPLNDV_Planta = _CPLNDV
        obeTracto.pNRUCTR_RucTransportista = Me._obj_Entidad.NRUCTR
        If Not Me._obj_Entidad.NPLCUN.Trim.Equals("") Then
            obeTracto.pNPLCUN_NroPlacaUnidad = Me._obj_Entidad.NPLCUN
        End If
        ctbTracto.pCargar(obeTracto)
        'Catch : End Try
  End Sub

  Private Sub Cargar_Combo_Acoplado_Conductor(Optional ByVal strConductor As String = "", Optional ByVal strSegundoConductor As String = "")
        'Try
        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        obeConductor.pCCMPN_Compania = _CCMPN
        obeConductor.pNRUCTR_RucTransportista = Me.ctbTransportista.pRucTransportista.Trim

        obeConductor.pCBRCNT_Brevete = strConductor
        Me.cmbConductor.pCargar(obeConductor)

        obeConductor.pCBRCNT_Brevete = strSegundoConductor
        Me.cmbSegundoConductor.pCargar(obeConductor)

        'Catch : End Try
  End Sub

  Private Function Validar_Recursos_Asignados() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    'Evaluando la Asignación: Transportista, Tracto, Acoplado y Conductor
    If Me.ctbTracto.pNroPlacaUnidad.Trim.Equals("") Then
      lstr_validacion += "* TRANSPORTISTA" & Chr(13)
    End If

    If Me.ctbTracto.pNroPlacaUnidad.Trim.Equals("") Then
      lstr_validacion += "* TRACTO" & Chr(13)
    End If



    If lstr_validacion <> "" Then
      HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If

    Return lbool_existe_error
  End Function

#End Region

  Private Sub ctbTransportista_InformationChanged() Handles ctbTransportista.InformationChanged
    If Not (ctbTransportista.pRucTransportista.ToString.Trim.Equals(_obj_Entidad.NRUCTR)) Then
      Me.ctbTracto.pClear()
      Me.ctbAcoplado.pClear()
      Me.cmbConductor.pClear()
      Me.cmbSegundoConductor.pClear()
    End If

    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    obeTracto.pCCMPN_Compania = _obj_Entidad.CCMPN
    obeTracto.pCDVSN_Division = _obj_Entidad.CDVSN
    obeTracto.pCPLNDV_Planta = _obj_Entidad.CPLNDV
    obeTracto.pNRUCTR_RucTransportista = Me.ctbTransportista.pRucTransportista
    ctbTracto.pCargar(obeTracto)

    Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    obeAcoplado.pCCMPN_Compania = _obj_Entidad.CCMPN
    obeAcoplado.pCDVSN_Division = _obj_Entidad.CDVSN
    obeAcoplado.pCPLNDV_Planta = _obj_Entidad.CPLNDV
    obeAcoplado.pNRUCTR_RucTransportista = Me.ctbTransportista.pRucTransportista
    Me.ctbAcoplado.pCargar(obeAcoplado)

    Me.Cargar_Combo_Acoplado_Conductor()
    Me._obj_Entidad.NRUCTR = Me.ctbTransportista.pRucTransportista

  End Sub

  Private Sub Cargar_Combo_Tracto(Optional ByVal NroRucTransportista As String = "", Optional ByVal NroPlacaUnidad As String = "")

    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    obeTracto.pCCMPN_Compania = _obj_Entidad.CCMPN
    obeTracto.pCDVSN_Division = _obj_Entidad.CDVSN
    obeTracto.pCPLNDV_Planta = _obj_Entidad.CPLNDV
    obeTracto.pNRUCTR_RucTransportista = NroRucTransportista
    obeTracto.pNPLCUN_NroPlacaUnidad = NroPlacaUnidad
  End Sub

  Private Sub Cargar_Combo_Acoplado()
    Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
    obeAcoplado.pCCMPN_Compania = _CCMPN
    obeAcoplado.pCDVSN_Division = _CDVSN
    obeAcoplado.pCPLNDV_Planta = _CPLNDV
    obeAcoplado.pNRUCTR_RucTransportista = Me._obj_Entidad.NRUCTR
    If Not Me._obj_Entidad.NPLCAC.Trim.Equals("") Then
      obeAcoplado.pNPLCAC_NroAcoplado = Me._obj_Entidad.NPLCAC
    End If
    Me.ctbAcoplado.pCargar(obeAcoplado)

  End Sub

End Class

