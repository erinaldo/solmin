Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmGastosRuta

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

#Region "Variables"
  Private bolBuscar As Boolean
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private lstrTipoCuenta As String = ""
  Private lstrCuentaSap1 As String = ""
  Private lstrCuentaSap2 As String = ""
  Private lstrEtsImpNCTAVC As String = ""
  Private lstrEtsImpNCTAV2 As String = ""
  Private lstrEtsImpNCTAV3 As String = ""
  Private lstrEtsImpNCTAV4 As String = ""
#End Region

#Region "Eventos"

  Private Sub frmGastosRuta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    btnBuscarGastosRuta_Click(Nothing, Nothing)
  End Sub

  Private Sub frmGastosRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Me.TabControl1.Controls.Remove(Me.TabPage2)
      bolBuscar = False
      Alinear_Columnas_Grilla()
      Cargar_Compania()
      Cargar_Combos()

      'Cargar_Grilla_GastosRuta()
      Validar_Usuario_Autoridado()
    Catch : End Try

  End Sub

  Private Sub btnBuscarGastosRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGastosRuta.Click
    Cargar_Grilla_GastosRuta()
  End Sub

  Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
    Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
    Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
  End Sub

  Private Sub btnGenerarAVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAVC.Click
    Select Case Me.TabControl1.SelectedIndex
      Case 0
        GenerarAVC()
      Case 1
        GenerarAVC(1)
    End Select
  End Sub

  Private Sub GenerarAVC(Optional ByVal intTipo As Integer = 0, Optional ByVal intRetorno As Integer = 0)
    Dim obeEntidad As New AVC
    Dim strError As String = ""

    If dtgGastosRuta.SelectedRows.Count = 0 Then Exit Sub
    Dim objParametro As New Hashtable
    If intTipo = 0 Then
      If intRetorno = 0 And Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value <> 0 Then
        strError = "Ya cuenta con  AVC generado"
      End If
      If intRetorno = 1 And Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value <> 0 Then
        strError = "Ya cuenta con  AVC de retorno"
      End If
      If strError.Trim.Length > 0 Then
        HelpClass.MsgBox(strError)
        Exit Sub
      End If
      obeEntidad.CBRCNT = Me.dtgGastosRuta.SelectedRows(0).Cells("CBRCNT").Value
    Else
      If intRetorno = 0 And Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value <> 0 Then
        strError = "Ya cuenta con  AVC generado"
      End If
      If intRetorno = 1 And Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value <> 0 Then
        strError = "Ya cuenta con  AVC generado"
      End If
      If strError.Trim.Length > 0 Then
        HelpClass.MsgBox(strError)
        Exit Sub
      End If
      obeEntidad.CBRCNT = Me.dtgGastosRuta.SelectedRows(0).Cells("CBRCN2").Value
    End If
    obeEntidad.CCLNT = Me.dtgGastosRuta.SelectedRows(0).Cells("CCLNT").Value
    obeEntidad.CLCLOR = Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLOR").Value
    obeEntidad.CLCLDS = Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLDS").Value
    obeEntidad.NOPRCN = Me.dtgGastosRuta.SelectedRows(0).Cells("NOPRCN").Value
    obeEntidad.NPLCUN = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value
    obeEntidad.RUTA = Me.dtgGastosRuta.SelectedRows(0).Cells("RUTA").Value
    obeEntidad.CCMPN = Me.cmbCompania.SelectedValue
    obeEntidad.CDVSN = Me.cmbDivision.SelectedValue
    obeEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
    obeEntidad.NCSOTR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCSOTR").Value
    obeEntidad.NCRRSR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCRRSR").Value
    obeEntidad.NORSRT = Me.dtgGastosRuta.SelectedRows(0).Cells("NORSRT").Value
    If intTipo = 0 Then
      obeEntidad.NCSLPE = Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value
    Else
      obeEntidad.NCSLPE = Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value
    End If
    Dim objFrmSolicitudEfectivoAVC As New frmSolicitudEfectivoAVC()
    objFrmSolicitudEfectivoAVC.TIPCUEN = lstrTipoCuenta
    objFrmSolicitudEfectivoAVC.TIPOCON = intTipo
    objFrmSolicitudEfectivoAVC.RETORNO = intRetorno
    objFrmSolicitudEfectivoAVC.btnBuscaOrdenServicio.Visible = False
    objFrmSolicitudEfectivoAVC.cmbPlaca.Enabled = False
    objFrmSolicitudEfectivoAVC.cmbObrero.Enabled = False
    objFrmSolicitudEfectivoAVC.txtNroOperacion.Enabled = False
    objFrmSolicitudEfectivoAVC.obeEntidad = obeEntidad
    If objFrmSolicitudEfectivoAVC.ShowDialog = Windows.Forms.DialogResult.OK Then
      If intTipo = 0 Then
        If intRetorno = 1 Then
          dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value = objFrmSolicitudEfectivoAVC.NRAVC
        Else
          dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value = objFrmSolicitudEfectivoAVC.NRAVC
          dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value = objFrmSolicitudEfectivoAVC.NRSOL
        End If

      Else
        If intRetorno = 1 Then
          dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value = objFrmSolicitudEfectivoAVC.NRAVC
        Else
          dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value = objFrmSolicitudEfectivoAVC.NRAVC
          dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value = objFrmSolicitudEfectivoAVC.NRSOL
        End If

      End If
      Limpiar_Detalle()
      Cargar_Grilla_Detalle_GastoRuta()
    End If
  End Sub

  Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Division()
      Cargar_Transportista()
      Cargar_Conductor()
    End If
  End Sub

  Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Planta()
    End If
  End Sub

  Private Sub dtgGastosRuta_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgGastosRuta.KeyUp
    Me.Cursor = Cursors.WaitCursor
    If dtgGastosRuta.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
      Limpiar_Detalle()
      Cargar_Grilla_Detalle_GastoRuta()
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnReenviarSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenviarSAP.Click
    Try
      If dtgGastosRuta.CurrentCellAddress.Y < 0 Then
        Exit Sub
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value.ToString.Trim <> 0 Then
        If Not (txtImporteAVC.Text > 0 And txtAdelanto.Text = 0) And txtNrReferenciaSAPAVC.Text = 0 Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value, 1, lstrCuentaSap1, Me.txtAdelanto.Text)
        End If
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value <> 0 Then
        If Not (Me.txtImporteAVCRetorno1.Text > 0 And txtAdelantoRetorno1.Text = 0) Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value, 1, lstrCuentaSap1, Me.txtAdelantoRetorno1.Text)
        End If
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value <> 0 Then
        If txtNrReferenciaSAPPedido.Text = 0 Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value, 2, lstrCuentaSap1, Me.txtImporteSolEfectivo.Text)
        End If
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value.ToString.Trim <> 0 Then
        If Not (txtImporteAVC2.Text > 0 And txtAdelanto2.Text = 0) And txtNrReferenciaSAPAVC2.Text = 0 Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value, 1, lstrCuentaSap2, Me.txtAdelanto2.Text)
        End If
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value.ToString.Trim <> 0 Then
        If Not (Me.txtImporteAvcRetorno2.Text > 0 And txtAdelantoRetorno2.Text = 0) And txtNrReferenciaSAPAvcRetorno2.Text = 0 Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value, 1, lstrCuentaSap2, Me.txtAdelantoRetorno2.Text)
        End If
      End If
      If Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value <> 0 Then
        If txtNrReferenciaSAPPedido2.Text = 0 Then
          Guardar_Solicitud_Efectivo_SAP(Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value, 2, lstrCuentaSap2, Me.txtImporteSolEfectivo2.Text)
        End If
      End If
      Limpiar_Detalle()
      Cargar_Grilla_Detalle_GastoRuta()
    Catch
    End Try

  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value <> 0 Then
      Imprimir_Solicitud_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value, Me.lstrEtsImpNCTAVC)
    End If
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value <> 0 Then
      Imprimir_Solicitud_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCTAV3").Value, Me.lstrEtsImpNCTAV3)
    End If
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value <> 0 Then
      Imprimir_Reporte_Pedido_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value)
    End If
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value <> 0 Then
      Imprimir_Solicitud_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCTAV2").Value, Me.lstrEtsImpNCTAV2)
    End If
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value <> 0 Then
      Imprimir_Solicitud_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCTAV4").Value, Me.lstrEtsImpNCTAV4)
    End If
    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value <> 0 Then
      Imprimir_Reporte_Pedido_Efectivo(dtgGastosRuta.SelectedRows(0).Cells("NCSLP2").Value)
    End If
  End Sub

  Private Sub btnImprimirGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirGeneral.Click
    Imprimir_Reporte_Lista_Asignacion_AVC()
  End Sub

  Private Sub btnGenerarAVCRetorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAVCRetorno.Click
    Select Case Me.TabControl1.SelectedIndex
      Case 0
        GenerarAVC(0, 1)
      Case 1
        GenerarAVC(1, 1)
    End Select
  End Sub

#End Region

#Region "Metodos y Funciones"

  Private Sub Limpiar_Grilla_GatosRuta()
    Me.dtgGastosRuta.DataSource = Nothing
  End Sub

  Private Sub Cargar_Transportista()
    Dim pNRUCTR_RucTransportista As String = String.Empty
    If Me.cmbCompania.SelectedValue = "EZ" Then
      pNRUCTR_RucTransportista = "20100039207"
    End If
    cboTransportista.pClear()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    obeTransportista.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeTransportista.pNRUCTR_RucTransportista = pNRUCTR_RucTransportista
    cboTransportista.pCargar(obeTransportista)
  End Sub

  Private Sub Cargar_Conductor()
    cmbConductor.pClear()
    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    obeConductor.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeConductor.pNRUCTR_RucTransportista = cboTransportista.pRucTransportista.Trim
    Me.cmbConductor.pCargar(obeConductor)
  End Sub

  Private Sub Cargar_Combos()
    Dim objEntidadTracto As New ENTIDADES.mantenimientos.TransportistaTracto
    Dim objMedioTransporte As New NEGOCIO.MedioTransporte_BLL
    'Dim listObjMedioTransporte As List(Of MedioTransporte) = objMedioTransporte.Lista_Medio_Transporte()
    Dim objDataTable As DataTable = HelpClass.GetDataSetNative(objMedioTransporte.Lista_Medio_Transporte())
    Try
      Cargar_Transportista()
      Cargar_Conductor()

      With Me.cmbMedioTransporte
        .DataSource = objDataTable.Copy 'listObjMedioTransporte ' objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With

      With Me.cmbMedioTransporte2
        .DataSource = objDataTable.Copy 'listObjMedioTransporte 'objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With

      With Me.cmbMedioTransporteRetorno
        .DataSource = objDataTable.Copy 'listObjMedioTransporte 'objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With

      With Me.cmbMedioTransporteRetorno2
        .DataSource = objDataTable.Copy 'listObjMedioTransporte 'objMedioTransporte.Lista_Medio_Transporte()
        .ValueMember = "CTPMDT"
        .DisplayMember = "TTPMDT"
      End With


    Catch ex As Exception
    End Try
  End Sub

  Private Sub Cargar_Compania()
    objCompaniaBLL.Crea_Lista()
    bolBuscar = False
    cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
    cmbCompania.DisplayMember = "TCMPCM"
        'cmbCompania.SelectedValue = "EZ"
        bolBuscar = True
        'If cmbCompania.SelectedIndex = -1 Then
        '    cmbCompania.SelectedIndex = 0
        'End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cmbCompania_SelectedIndexChanged(Nothing, Nothing)

  End Sub

  Private Sub Cargar_Division()
    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
      bolBuscar = False
      objDivision.Crea_Lista()
      cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            cmbDivision.DisplayMember = "TCMPDV"
            Me.cmbDivision.SelectedValue = "T"
            bolBuscar = True
      If Me.cmbDivision.SelectedIndex = -1 Then
        Me.cmbDivision.SelectedIndex = 0
      End If
            cmbDivision_SelectedIndexChanged(Nothing, Nothing)
      Me.Cursor = System.Windows.Forms.Cursors.Default
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Planta()
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Try
      If bolBuscar Then
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        bolBuscar = False
        objPlanta.Crea_Lista()
        objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
        cmbPlanta.DataSource = objLisEntidad
        cmbPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        cmbPlanta.DisplayMember = "TPLNTA"
        If objLisEntidad.Count > 0 Then
          lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
        Else
          lstrTipoCuenta = ""
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Grilla_GastosRuta()
    Me.Cursor = Cursors.WaitCursor
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objetoParametro As New Hashtable

    'objetoParametro.Add("PNCTRMNC", CType(Objeto_Logica.Obtener_Codigo_Transportista(Me.cboTransportista.Codigo), Double))
    objetoParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
    objetoParametro.Add("PNCPLNDV", Me.cmbPlanta.SelectedValue)
    'Limpiar_Grilla_GatosRuta()
    If ckbRangoFechas.Checked Then
      objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
      objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
    Else
      objetoParametro.Add("PNFECINI", 20000101)
      objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Now()), Double))
    End If
    If Me.cboTransportista.pRucTransportista <> "" Then
      objetoParametro.Add("PSNRUCTR", CType(Me.cboTransportista.pRucTransportista, Double)) 'TRANSPORTISTA
    Else
      objetoParametro.Add("PSNRUCTR", CType("0", Double)) 'TRANSPORTISTA
    End If
    objetoParametro.Add("PSCBRCNT", CType(Me.cmbConductor.pBrevete, String)) 'CHOFER
    Me.dtgGastosRuta.AutoGenerateColumns = False
    Me.dtgGastosRuta.DataSource = HelpClass.GetDataSetNative(Objeto_Logica.Lista_Solicitud_Gastos_Ruta(objetoParametro))
    'If Me.dtgGastosRuta.Rows.Count > 0 Then
    '  Limpiar_Detalle()
    '  Cargar_Grilla_Detalle_GastoRuta()
    'End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Cargar_Grilla_Detalle_GastoRuta()
    Dim Objeto_Logica As New NEGOCIO.AVC_BLL
    Dim objEntidadObrero As New Obrero
    Me.Cursor = Cursors.WaitCursor

    If Me.dtgGastosRuta.CurrentCellAddress.Y < 0 Then Exit Sub
    With dtgGastosRuta.CurrentRow
      objEntidadObrero = CargarObrero(.Cells("CBRCNT").Value)
      lstrCuentaSap1 = objEntidadObrero.CMTCDS
      Me.txtObrero.Text = objEntidadObrero.COBRR
      If .Cells("CBRCN2").Value.ToString.Trim <> vbNullString Then
        Me.TabControl1.TabPages.Add(Me.TabPage2)
        objEntidadObrero = CargarObrero(.Cells("CBRCN2").Value)
        lstrCuentaSap2 = objEntidadObrero.CMTCDS
        Me.txtObrero2.Text = objEntidadObrero.COBRR
        Me.txtNroBrevete2.Text = .Cells("CBRCN2").Value
        Me.txtNombreObrero2.Text = .Cells("CONDUCTOR2").Value
      End If
      Me.txtNroOperacion.Text = .Cells("NOPRCN").Value
      Me.txtNroOperacion2.Text = .Cells("NOPRCN").Value
      Me.txtPlaca.Text = .Cells("NPLCUN").Value
      Me.txtPlaca2.Text = .Cells("NPLCUN").Value
      Me.txtNroBrevete.Text = .Cells("CBRCNT").Value
      Me.txtPlaca.Text = .Cells("NPLCUN").Value
      Me.txtPlaca2.Text = .Cells("NPLCUN").Value
      Me.txtNombreObrero.Text = .Cells("CONDUCTOR").Value
      Me.txtNroOrdenInternaSAP.Text = .Cells("NORINS").Value
      Me.txtNrOrdenInternaSAP2.Text = .Cells("NORINS").Value
      Me.txtNrAvcRetorno1.Text = .Cells("NCTAV3").Value
      Me.txtNroAvcRetorno2.Text = .Cells("NCTAV4").Value
    End With
    Cargar_Avc(Me.dtgGastosRuta.CurrentCellAddress.Y)
    Cargar_Pedido_Efectivo(Me.dtgGastosRuta.CurrentCellAddress.Y)

    Me.Cursor = Cursors.Default
  End Sub

  Private Function CargarObrero(ByVal strBrevete As String) As Obrero
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objListEntidad As New Obrero
    Dim objetoParametro As New Hashtable

    objetoParametro.Add("PSCBRCNT", strBrevete)
    objListEntidad = Objeto_Logica.Obtener_Datos_Obrero(objetoParametro)
    Return objListEntidad
  End Function

  Private Sub Cargar_Pedido_Efectivo(ByVal intCont)
    Dim Objeto_Logica As New NEGOCIO.PedidoEfectivo_BLL

    If Me.dtgGastosRuta.Rows(intCont).Cells("NCSLPE").Value <> 0 Or Me.dtgGastosRuta.Rows(intCont).Cells("NCSLP2").Value Then
      Lista_Pedido_Efectivo(intCont)
    End If
  End Sub

  Private Sub Lista_Pedido_Efectivo(ByVal intCont As Integer)
    Dim objNegocios As New NEGOCIO.PedidoEfectivo_BLL
    Dim objEntidadCon1 As New ENTIDADES.PedidoEfectivo
    Dim objEntidadCon2 As New ENTIDADES.PedidoEfectivo

    If Me.dtgGastosRuta.Rows(intCont).Cells("NCSLPE").Value <> 0 Then
      objEntidadCon1 = objNegocios.Lista_Pedido_Efectivo(Me.dtgGastosRuta.Rows(intCont).Cells("NCSLPE").Value)
      Me.txtNroSolEfectivo.Text = objEntidadCon1.NMSLPE
      Me.txtImporteSolEfectivo.Text = Format(objEntidadCon1.ISLPES, "###,###,##0.00")
      Me.dtpFecSolEfectivo.Value = HelpClass.CNumero_a_Fecha(objEntidadCon1.FCSLPE)
      Me.txtMotivoGiro.Text = objEntidadCon1.MOTIVO
      txtComentarioSolEfectivo.Text = objEntidadCon1.MTVGRO
      txtNrReferenciaSAPPedido.Text = objEntidadCon1.NRFSAP
      btnImprimir.Enabled = True
      If objEntidadCon1.NRFSAP = 0 Then
        btnReenviarSAP.Visible = True
        ToolStripSeparator4.Visible = True
      End If

    End If
    If Me.dtgGastosRuta.Rows(intCont).Cells("NCSLP2").Value <> 0 Then
      objEntidadCon2 = objNegocios.Lista_Pedido_Efectivo(Me.dtgGastosRuta.Rows(intCont).Cells("NCSLP2").Value)
      Me.txtNroSolEfectivo2.Text = objEntidadCon2.NMSLPE
      Me.txtImporteSolEfectivo2.Text = Format(objEntidadCon2.ISLPES, "###,###,##0.00")
      Me.dtpFecSolEfectivo2.Value = HelpClass.CNumero_a_Fecha(objEntidadCon2.FCSLPE)
      Me.txtMotivoGiro2.Text = objEntidadCon2.MOTIVO
      txtComentarioSolEfectivo2.Text = objEntidadCon2.MTVGRO
      txtNrReferenciaSAPPedido2.Text = objEntidadCon2.NRFSAP
      btnImprimir.Enabled = True
      If objEntidadCon2.NRFSAP = 0 Then
        btnReenviarSAP.Visible = True
        ToolStripSeparator4.Visible = True
      End If
    End If
  End Sub

  Private Sub Cargar_Avc(ByVal intCont As Integer)
    Dim Objeto_Logica As New NEGOCIO.AVC_BLL
    If Me.dtgGastosRuta.Rows(intCont).Cells("NCTAVC").Value <> 0 Or Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV2").Value <> 0 Or Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV3").Value <> 0 Or Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV4").Value <> 0 Then
      Lista_Avc(intCont)
    End If
  End Sub

  Private Sub Lista_Avc(ByVal intCont As Integer)
    Dim obj_Negocios As New NEGOCIO.AVC_BLL
    Dim obj_EntidadCon As ENTIDADES.AVC

    'Cargar AVC conductor 1
    If dtgGastosRuta.Rows(intCont).Cells("NCTAVC").Value <> 0 Then
      obj_EntidadCon = New ENTIDADES.AVC
      obj_EntidadCon = obj_Negocios.Lista_Avc(Me.dtgGastosRuta.Rows(intCont).Cells("NCTAVC").Value)
      Me.txtNroAVC.Text = obj_EntidadCon.NCTAVC
      Me.dtpFechaAvc.Value = HelpClass.CNumero_a_Fecha(obj_EntidadCon.FINAVC)
      Me.txtImporteAVC.Text = Format(obj_EntidadCon.IRTAVC, "###,###,##0.00")
      Me.txtAdelanto.Text = Format(obj_EntidadCon.IARAVC, "###,###,##0.00")
      txtRutaAvc.Text = obj_EntidadCon.RUTA
      txtNrReferenciaSAPAVC.Text = obj_EntidadCon.NRFSAP
      lstrEtsImpNCTAVC = obj_EntidadCon.SFLSPE
      btnImprimir.Enabled = True
      If Not (txtImporteAVC.Text > 0 And txtAdelanto.Text = 0) Then
        If obj_EntidadCon.NRFSAP = 0 And obj_EntidadCon.IARAVC <> 0 Then
          btnReenviarSAP.Visible = True
          ToolStripSeparator4.Visible = True
        End If
      End If
      Select Case obj_EntidadCon.SESAVC
        Case "P"
          Me.txtEstado.Text = "PENDIENTE"
        Case "L"
          Me.txtEstado.Text = "LIQUIDADO"
        Case "*"
          Me.txtEstado.Text = "ANULADO"
      End Select
      bolBuscar = False
      Me.cmbMedioTransporte.SelectedValue = obj_EntidadCon.CTPMDT
      bolBuscar = True
      Me.KryptonLabel1.Visible = True
      Me.txtEstado.Visible = True
    End If

    'Cargar AVC conductor 2
    If Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV2").Value <> 0 Then
      obj_EntidadCon = New ENTIDADES.AVC
      obj_EntidadCon = obj_Negocios.Lista_Avc(Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV2").Value)
      Me.txtNroAVC2.Text = obj_EntidadCon.NCTAVC
      Me.dtpFechaAvc2.Value = HelpClass.CNumero_a_Fecha(obj_EntidadCon.FINAVC)
      Me.txtImporteAVC2.Text = Format(obj_EntidadCon.IRTAVC, "###,###,##0.00")
      Me.txtAdelanto2.Text = Format(obj_EntidadCon.IARAVC, "###,###,##0.00")
      txtRutaAvc2.Text = obj_EntidadCon.RUTA
      txtNrReferenciaSAPAVC2.Text = obj_EntidadCon.NRFSAP
      lstrEtsImpNCTAV2 = obj_EntidadCon.SFLSPE
      btnImprimir.Enabled = True
      If obj_EntidadCon.NRFSAP = 0 And obj_EntidadCon.IARAVC <> 0 Then
        btnReenviarSAP.Visible = True
        ToolStripSeparator4.Visible = True
      End If
      Select Case obj_EntidadCon.SESAVC
        Case "P"
          Me.txtEstado2.Text = "PENDIENTE"
        Case "L"
          Me.txtEstado2.Text = "LIQUIDADO"
        Case "*"
          Me.txtEstado2.Text = "ANULADO"
      End Select
      bolBuscar = False
      Me.cmbMedioTransporte2.SelectedValue = obj_EntidadCon.CTPMDT
      bolBuscar = True
      KryptonLabel102.Visible = True
      Me.txtEstado2.Visible = True
    End If

    'Avc de Retorno Conductor 1

    If Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV3").Value <> 0 Then
      obj_EntidadCon = New ENTIDADES.AVC
      obj_EntidadCon = obj_Negocios.Lista_Avc(Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV3").Value)
      Me.txtNrAvcRetorno1.Text = obj_EntidadCon.NCTAVC
      Me.dtpFechaAvcRetorno2.Value = HelpClass.CNumero_a_Fecha(obj_EntidadCon.FINAVC)
      txtImporteAVCRetorno1.Text = Format(obj_EntidadCon.IRTAVC, "###,###,##0.00")
      txtAdelantoRetorno1.Text = Format(obj_EntidadCon.IARAVC, "###,###,##0.00")
      txtRutaAvcRetorno.Text = obj_EntidadCon.RUTA
      txtNrReferenciaSAPAVCRetorno.Text = obj_EntidadCon.NRFSAP
      lstrEtsImpNCTAV3 = obj_EntidadCon.SFLSPE
      btnImprimir.Enabled = True
      If obj_EntidadCon.NRFSAP = 0 And obj_EntidadCon.IARAVC <> 0 Then
        btnReenviarSAP.Visible = True
        ToolStripSeparator4.Visible = True
      End If
      Select Case obj_EntidadCon.SESAVC
        Case "P"
          Me.txtEstadoRetorno.Text = "PENDIENTE"
        Case "L"
          Me.txtEstadoRetorno.Text = "LIQUIDADO"
        Case "*"
          Me.txtEstadoRetorno.Text = "ANULADO"
      End Select
      bolBuscar = False
      Me.cmbMedioTransporteRetorno.SelectedValue = obj_EntidadCon.CTPMDT
      bolBuscar = True
      KryptonLabel95.Visible = True
      Me.txtEstadoRetorno.Visible = True
    End If

    'Avc de Retorno Conductor 2
    If Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV4").Value <> 0 Then
      obj_EntidadCon = New ENTIDADES.AVC
      obj_EntidadCon = obj_Negocios.Lista_Avc(Me.dtgGastosRuta.Rows(intCont).Cells("NCTAV4").Value)
      Me.txtNroAvcRetorno2.Text = obj_EntidadCon.NCTAVC
      dtpFechaAvcRetorno2.Value = HelpClass.CNumero_a_Fecha(obj_EntidadCon.FINAVC)
      txtImporteAvcRetorno2.Text = Format(obj_EntidadCon.IRTAVC, "###,###,##0.00")
      txtAdelantoRetorno2.Text = Format(obj_EntidadCon.IARAVC, "###,###,##0.00")
      txtRutaAvcRetorno2.Text = obj_EntidadCon.RUTA
      txtNrReferenciaSAPAvcRetorno2.Text = obj_EntidadCon.NRFSAP
      lstrEtsImpNCTAV4 = obj_EntidadCon.SFLSPE
      btnImprimir.Enabled = True
      If obj_EntidadCon.NRFSAP = 0 And obj_EntidadCon.IARAVC <> 0 Then
        btnReenviarSAP.Visible = True
        ToolStripSeparator4.Visible = True
      End If
      Select Case obj_EntidadCon.SESAVC
        Case "P"
          Me.txtEstadoRetorno2.Text = "PENDIENTE"
        Case "L"
          Me.txtEstadoRetorno2.Text = "LIQUIDADO"
        Case "*"
          Me.txtEstadoRetorno2.Text = "ANULADO"
      End Select
      bolBuscar = False
      Me.cmbMedioTransporteRetorno2.SelectedValue = obj_EntidadCon.CTPMDT
      bolBuscar = True
      KryptonLabel108.Visible = True
      Me.txtEstadoRetorno2.Visible = True
    End If
  End Sub

  Private Sub Limpiar_Detalle()
    'Limpiar AVC de Retorno conductor 
    Me.txtNrAvcRetorno1.Text = "0"
    txtEstadoRetorno.Visible = False
    KryptonLabel95.Visible = False
    cmbMedioTransporteRetorno.SelectedIndex = -1
    dtpFechaAvcRetorno.Value = Now
    txtImporteAVCRetorno1.Text = "0"
    txtAdelantoRetorno1.Text = "0"
    txtNrReferenciaSAPAVCRetorno.Text = "0"
    txtRutaAvcRetorno.Text = ""

    'Limpiar AVC de Retorno conductor2
    Me.txtNroAvcRetorno2.Text = "0"
    txtEstadoRetorno2.Visible = False
    KryptonLabel108.Visible = False
    cmbMedioTransporteRetorno2.SelectedIndex = -1
    dtpFechaAvcRetorno2.Value = Now
    txtImporteAvcRetorno2.Text = "0"
    txtAdelantoRetorno2.Text = "0"
    txtNrReferenciaSAPAvcRetorno2.Text = "0"
    txtRutaAvcRetorno2.Text = ""

    'Limpiar otros
    Me.txtAdelanto2.Text = "0"
    Me.txtAdelanto.Text = "0"
    Me.txtImporteAVC.Text = "0"
    Me.txtImporteAVC2.Text = "0"
    Me.txtImporteSolEfectivo.Text = "0"
    Me.txtImporteSolEfectivo2.Text = "0"
    Me.txtComentarioSolEfectivo.Text = ""
    Me.txtComentarioSolEfectivo2.Text = ""
    Me.txtMotivoGiro.Text = ""
    Me.txtMotivoGiro2.Text = ""
    Me.txtNombreObrero.Text = ""
    Me.txtNombreObrero2.Text = ""
    Me.txtNroAVC.Text = "0"
    Me.txtNroAVC2.Text = "0"
    Me.txtNroBrevete.Text = ""
    Me.txtNroBrevete2.Text = ""
    Me.txtNroOperacion.Text = ""
    Me.txtNroOperacion2.Text = ""
    Me.txtNroSolEfectivo.Text = "0"
    Me.txtNroSolEfectivo2.Text = "0"
    Me.txtObrero.Text = ""
    Me.txtObrero2.Text = ""
    Me.txtRutaAvc.Text = ""
    Me.txtRutaAvc2.Text = ""
    Me.txtNroOrdenInternaSAP.Text = ""
    Me.txtNrOrdenInternaSAP2.Text = ""
    Me.txtPlaca.Text = ""
    Me.txtPlaca2.Text = ""
    Me.dtpFechaAvc.Value = Now
    Me.dtpFechaAvc2.Value = Now
    Me.dtpFechaLiquidacion.Value = Now
    Me.dtpHoraLiquidacion.Value = Now
    Me.dtpFecSolEfectivo.Value = Now
    Me.dtpFecSolEfectivo2.Value = Now
    Me.KryptonLabel12.Visible = True
    KryptonLabel102.Visible = False
    Me.txtEstado.Text = ""
    Me.txtEstado2.Text = ""
    Me.KryptonLabel1.Visible = False
    Me.txtEstado.Visible = False
    txtEstado2.Visible = False
    lstrCuentaSap1 = ""
    lstrCuentaSap2 = ""
    btnReenviarSAP.Visible = False
    cmbMedioTransporte.SelectedIndex = -1
    cmbMedioTransporte2.SelectedIndex = -1
    btnImprimir.Enabled = False
    ToolStripSeparator4.Visible = False
    Me.TabControl1.TabPages.Remove(Me.TabPage2)
    txtNrReferenciaSAPPedido.Text = "0"
    txtNrReferenciaSAPPedido2.Text = "0"
    txtNrReferenciaSAPAVC.Text = "0"
    txtNrReferenciaSAPAVC2.Text = "0"
    lstrEtsImpNCTAVC = ""
    lstrEtsImpNCTAV2 = ""
    lstrEtsImpNCTAV3 = ""
    lstrEtsImpNCTAV4 = ""

  End Sub

  Public Sub Limpiar_Controles(ByVal Contenedor As Object)
    Dim X As Control

    For Each X In Contenedor.Controls
      If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
      If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
      If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
      If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
      If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
      If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
      If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1
    Next

  End Sub

  Private Sub Calcular_Importe_Ruta()
    Dim dblCantidad As Double
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objListEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objetoParametro As New Hashtable

    objetoParametro.Add("PSCBRCNT", Me.dtgGastosRuta.SelectedRows(0).Cells("CBRCNT").Value)
    objetoParametro.Add("PNCCLNT", Me.dtgGastosRuta.SelectedRows(0).Cells("CCLNT").Value)
    objetoParametro.Add("PNCTPMDT", Me.cmbMedioTransporte.SelectedValue)
    objetoParametro.Add("PNCLCLOR", Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLOR").Value)
    objetoParametro.Add("PNCLCLDS", Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLDS").Value)
    objListEntidad = Objeto_Logica.Calular_Importe_Ruta(objetoParametro)
    If objListEntidad.Count > 0 Then
      dblCantidad = objListEntidad.Item(0).IARAVC
      Me.txtImporteAVC.Text = Format(dblCantidad, "###,###,##0.00")
      Me.txtAdelanto.Text = Format(Math.Floor(txtImporteAVC.Text / 2), "###,###,##0.00")
      Me.txtImporteSolEfectivo.Text = Format(Math.Floor(txtAdelanto.Text / 2), "###,###,##0.00")
    End If
  End Sub

  'Private Sub Guardar_AVC()
  '    Dim objEntidad As New ENTIDADES.AVC
  '    Dim objLogic As New NEGOCIO.AVC_BLL

  '    If dtgGastosRuta.SelectedRows.Count = 0 Then Exit Sub
  '    If Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value <> 0 Then
  '        Exit Sub
  '    End If
  '    If txtObrero.Text = "0" Then
  '        HelpClass.MsgBox("El conductor no tiene Código")
  '        Exit Sub
  '    End If
  '    If txtAdelanto.Text = 0 Then
  '        HelpClass.MsgBox("La cantidad de adelanto AVC debe de ser mayor que 0")
  '        Exit Sub
  '    End If
  '    objEntidad.FINAVC = HelpClass.CtypeDate(Now)
  '    objEntidad.NCSOTR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCSOTR").Value
  '    objEntidad.NCRRSR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCRRSR").Value
  '    objEntidad.COBRR = Me.txtObrero.Text
  '    objEntidad.NOPRCN = Me.txtNroOperacion.Text
  '    objEntidad.CTPMDT = Me.cmbMedioTransporte.SelectedValue
  '    objEntidad.CLCLOR = Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLOR").Value
  '    objEntidad.CLCLDS = Me.dtgGastosRuta.SelectedRows(0).Cells("CLCLDS").Value
  '    objEntidad.IRTAVC = Me.txtImporteAVC.Text
  '    objEntidad.IARAVC = txtAdelanto.Text
  '    objEntidad.SESAVC = "P"
  '    objEntidad.NPLCUN = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value
  '    objEntidad.CBRCNT = Me.dtgGastosRuta.SelectedRows(0).Cells("CBRCNT").Value
  '    objEntidad.FCHCRT = HelpClass.TodayNumeric
  '    objEntidad.HRACRT = HelpClass.NowNumeric
  '    objEntidad.USRCRT = MainModule.USUARIO
  '    objEntidad.NTRMNL = HelpClass.NombreMaquina
  '    objEntidad.NORSRT = Me.dtgGastosRuta.SelectedRows(0).Cells("NORSRT").Value

  '    objEntidad = objLogic.Guardar_AVC(objEntidad)
  '    If objEntidad.NCTAVC <> 0 Then
  '        HelpClass.MsgBox("El registro se guardó satisfactoriamente")
  '        Me.dtgGastosRuta.SelectedRows(0).Cells("NCTAVC").Value = objEntidad.NCTAVC
  '        txtNroAVC.Text = objEntidad.NCTAVC
  '        Guardar_Solicitud_Efectivo_SAP(objEntidad.NCTAVC, 1)
  '    Else
  '        HelpClass.MsgBox("Error al Guardar")
  '    End If
  'End Sub

  Private Sub Guardar_Solicitud_Efectivo_SAP(ByVal pdblNrAVC As Double, ByVal pintTipo As Double, ByVal lstrCuentaSap As String, ByVal Importe As Double)
    Dim objEntidad As New ENTIDADES.SolicitudEfectivoSAP
    Dim objNegocio As New SOLMIN_ST.NEGOCIO.SolicitudEfectivoSAP_BLL

    Try
      Me.Cursor = Cursors.WaitCursor
      objEntidad.CCMPN = cmbCompania.SelectedValue
      objEntidad.NMSLPE = pdblNrAVC
      objEntidad.FCSLPE = HelpClass.CtypeDate(Now)
      objEntidad.CMSLPE = 1
      If pintTipo = 1 Then
        objEntidad.ICTMYS = "E"
        objEntidad.ISLPES = Importe 'txtAdelanto.Text
        objEntidad.TCBDCS = "ADELANTO AVC"
        objEntidad.TADSAP = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value
      Else
        objEntidad.ICTMYS = "A"
        objEntidad.ISLPES = Importe 'txtImporteSolEfectivo2.Text
        If lstrTipoCuenta = "" Then
          objEntidad.TCBDCS = "Rxx- A RENDIR CUENTA"
        Else
          objEntidad.TCBDCS = lstrTipoCuenta & "- A RENDIR CUENTA"
        End If
        objEntidad.TADSAP = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value & " - " & Me.dtgGastosRuta.SelectedRows(0).Cells("RUTA").Value
      End If
      objEntidad.FVENDP = HelpClass.CtypeDate(Now)
      objEntidad.FCHCRT = HelpClass.TodayNumeric
      objEntidad.HRACRT = HelpClass.NowNumeric
      objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      objEntidad.CDVSN = cmbDivision.SelectedValue
      objEntidad.CMTCDS = lstrCuentaSap.Trim
      objEntidad.NPLCUN = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value
      objEntidad.NOPRCN = Me.dtgGastosRuta.SelectedRows(0).Cells("NOPRCN").Value
      objEntidad = objNegocio.Guardar_Solicitud_Efectivo_SAP(objEntidad)
      If objEntidad.NRFSAP <> 0 Then
        HelpClass.MsgBox("Envió Satisfactoriamente al SAP")
        Imprimir(objEntidad.NMSLPE, pintTipo)
      Else
        HelpClass.MsgBox("Error al Enviar a SAP " & Chr(13) & objEntidad.TSTERS, MessageBoxIcon.Error)
        Me.Cursor = Cursors.Default
      End If
    Catch ex As Exception
      HelpClass.ErrorMsgBox()
      Me.Cursor = Cursors.Default
    End Try
    Me.Cursor = Cursors.Default
  End Sub

  'Private Sub Guardar_Pedido_Efectivo()
  '  Dim objEntidad As New ENTIDADES.PedidoEfectivo
  '  Dim objLogic As New NEGOCIO.PedidoEfectivo_BLL

  '  If dtgGastosRuta.SelectedRows.Count = 0 Then Exit Sub

  '  If Me.dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value <> 0 Then
  '    Exit Sub
  '  End If
  '  If Me.txtObrero.Text = "0" Then
  '    HelpClass.MsgBox("El Conductor no tiene Código")
  '    Exit Sub
  '  End If
  '  If Me.txtImporteSolEfectivo.Text = 0 Then
  '    HelpClass.MsgBox("El importe de Solicitud Pedido Efectivo debe de ser mayor que 0")
  '    Exit Sub
  '  End If
  '  Me.Cursor = Cursors.WaitCursor
  '  objEntidad.NCSOTR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCSOTR").Value
  '  objEntidad.NCRRSR = Me.dtgGastosRuta.SelectedRows(0).Cells("NCRRSR").Value
  '  objEntidad.CCMPN = Me.cmbCompania.SelectedValue
  '  objEntidad.CDVSN = Me.cmbDivision.SelectedValue
  '  objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
  '  objEntidad.TPSLPE = "P"
  '  objEntidad.FCJSPE = HelpClass.CtypeDate(Now)
  '  objEntidad.ISLPES = Me.txtImporteSolEfectivo.Text
  '  objEntidad.MOTIVO = txtMotivoGiro.Text
  '  objEntidad.NPLCUN = Me.dtgGastosRuta.SelectedRows(0).Cells("NPLCUN").Value
  '  objEntidad.NORDSR = dtgGastosRuta.SelectedRows(0).Cells("NORSRT").Value
  '  objEntidad.MTVGRO = txtComentarioSolEfectivo.Text 'txtMotivoGiro.Text
  '  objEntidad.CODDES = txtObrero.Text
  '  objEntidad.SESTRG = "A"
  '  objEntidad.DATCRT = HelpClass.TodayNumeric
  '  objEntidad.HRACRT = HelpClass.NowNumeric
  '  objEntidad.USRCRT = MainModule.USUARIO
  '  objEntidad.NTRMNL = HelpClass.NombreMaquina
  '  objEntidad = objLogic.Guardar_Pedido_Efectivo(objEntidad)
  '  If objEntidad.NMSLPE <> 0 Then
  '    HelpClass.MsgBox("El registro se guardó satisfactoriamente")
  '    dtgGastosRuta.SelectedRows(0).Cells("NCSLPE").Value = objEntidad.NMSLPE
  '    txtNroSolEfectivo.Text = objEntidad.NMSLPE
  '    Guardar_Solicitud_Efectivo_SAP(objEntidad.NMSLPE, 2, )
  '  Else
  '    HelpClass.MsgBox("Error al Guardar")
  '  End If
  '  Me.Cursor = Cursors.Default
  'End Sub


  Private Sub Imprimir(ByVal dblNumeroAVC As Double, ByVal intTipo As Integer)
    If intTipo = 1 Then
      Imprimir_Solicitud_Efectivo(dblNumeroAVC, "")
    Else
      Imprimir_Reporte_Pedido_Efectivo(dblNumeroAVC)
    End If
  End Sub

  Private Sub Imprimir_Solicitud_Efectivo(ByVal dblNumeroAVC As Double, ByVal strEstPrint As String)
    Dim objParametro As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet
    Dim objPrintForm As New PrintForm

    Me.Cursor = Cursors.WaitCursor
    Dim objReporte As New rptGastosRuta
    Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL
    objParametro.Add("NCTAVC", dblNumeroAVC)
    oDt = HelpClass.GetDataSetNative(objLogical.ReporteControlGastos(objParametro))
    oDt.TableName = "GastosRuta"
    If oDt.Rows.Count > 0 Then
      oDs.Tables.Add(oDt.Copy)
      If strEstPrint <> "" Then
        HelpClass.CrystalReportTextObject(objReporte, "lblRePrint1", "COPIA")
        HelpClass.CrystalReportTextObject(objReporte, "lblRePrint2", "COPIA")
        HelpClass.CrystalReportTextObject(objReporte, "lblRePrint3", "COPIA")
        HelpClass.CrystalReportTextObject(objReporte, "lblRePrint4", "COPIA")
      End If
      objReporte.SetDataSource(oDs)
      objPrintForm.ShowForm(objReporte, Me)
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Imprimir_Reporte_Pedido_Efectivo(ByVal dblPedidoEfectivo As Double)
    Dim objParametro As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet
    Dim objPrintForm As New PrintForm

    Me.Cursor = Cursors.WaitCursor
    If dblPedidoEfectivo <> 0 Then
      Dim objReporte As New rptSolicitudEfectivo
      Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL
      If dblPedidoEfectivo = 0 Then
        objParametro.Add("NCSLPE", dblPedidoEfectivo)
      Else
        objParametro.Add("NCSLPE", dblPedidoEfectivo)
      End If
      oDt = HelpClass.GetDataSetNative(objLogical.Reporte_Pedido_Efectivo(objParametro))
      oDt.TableName = "GastosRuta"
      If oDt.Rows.Count > 0 Then
        oDs.Tables.Add(oDt.Copy)
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)
      End If
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Validar_Usuario_Autoridado()
    Dim objParametro As New Hashtable
    Dim objLogica As New NEGOCIO.Operaciones.SolicitudPedidoEfectivo_BLL
    Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

    If objEntidad.STSOP2 = "" Then
      btnImprimir.Visible = False
      ToolStripSeparator1.Visible = False
      btnImprimirGeneral.Visible = False
    End If
    If objEntidad.STSOP1 = "" Then
      btnGenerarAVC.Visible = False
      ToolStripSeparator2.Visible = False
      btnGenerarAVCRetorno.Visible = False
      ToolStripSeparator4.Visible = False
    End If
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    For lint_contador As Integer = 0 To Me.dtgGastosRuta.ColumnCount - 1
      Me.dtgGastosRuta.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Imprimir_Reporte_Lista_Asignacion_AVC()
    Dim objLogicas As New NEGOCIO.Gastos_Ruta_BLL
    Dim objetoParametro As New Hashtable
    Dim objDt As New DataTable
    Dim oDs As New DataSet
    Me.Cursor = Cursors.WaitCursor

    If ckbRangoFechas.Checked Then
      objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
      objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
    Else
      objetoParametro.Add("PNFECINI", 2007101)
      objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Now()), Double))
    End If
    objetoParametro.Add("PSNRUCTR", CType(Me.cboTransportista.pRucTransportista, Double)) 'TRANSPORTISTA
    objetoParametro.Add("PSCBRCNT", CType(Me.cmbConductor.pBrevete, String)) 'CHOFER
    objetoParametro.Add("USUARIO", CType(MainModule.USUARIO, String)) 'CHOFER
    objetoParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
    objetoParametro.Add("PNCPLNDV", Me.cmbPlanta.SelectedValue)


    Dim objReporte As New rptLista_Asignaciones_AVC 'por mientras
    Dim objPrintForm As New PrintForm
    objDt = HelpClass.GetDataSetNative(objLogicas.Reporte_Lista_Asignacion_AVC(objetoParametro))
    objDt.TableName = "AVC"
    If objDt.Rows.Count > 0 Then
      oDs.Tables.Add(objDt.Copy)
      objReporte.SetDataSource(oDs)
      objReporte.SetParameterValue("pUsuario", MainModule.USUARIO)
      objReporte.SetParameterValue("pCompania", Me.cmbCompania.Text)
      objReporte.SetParameterValue("pDivision", Me.cmbDivision.Text)
      objReporte.SetParameterValue("pPlanta", Me.cmbPlanta.Text)
      objPrintForm.ShowForm(objReporte, Me)
    End If

    Me.Cursor = Cursors.Default
  End Sub
#End Region

  Private Sub dtgGastosRuta_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgGastosRuta.SelectionChanged
    If Me.dtgGastosRuta.CurrentCellAddress.Y = -1 Then Exit Sub
    Limpiar_Detalle()
    Cargar_Grilla_Detalle_GastoRuta()
  End Sub

  Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
    Auditoria(Me.txtNroAVC.Text)
  End Sub

  Private Sub Auditoria(ByVal dblNrAVC As String)
    If dblNrAVC.Trim.Length = 0 OrElse dblNrAVC = 0 Then Exit Sub

    Me.Cursor = Cursors.WaitCursor
    Dim objLogica As New NEGOCIO.AVC_BLL
    Dim objEntidad As New mantenimientos.ClaseGeneral
    objEntidad.NCTAVC = dblNrAVC
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
    objEntidad = objLogica.Auditoria(objEntidad)

    Dim objfrmAuditoria As New frmAuditoria
    objfrmAuditoria.USUARIO_CREACION = objEntidad.CUSCRT
    objfrmAuditoria.FECHA_CREACION = objEntidad.FCHCRT
    objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT
    objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMCR
    objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
    objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC
    objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC
    objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
    objfrmAuditoria.ShowDialog()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Auditoria_PedidoEfectivo(ByVal dblNrPedidoEfectivo)
    If dblNrPedidoEfectivo.Trim.Length = 0 OrElse dblNrPedidoEfectivo = 0 Then Exit Sub

    Me.Cursor = Cursors.WaitCursor
    Dim objLogica As New NEGOCIO.PedidoEfectivo_BLL
    Dim objEntidad As New PedidoEfectivo
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
    objEntidad.TPSLPE = "P"
    objEntidad.NMSLPE = dblNrPedidoEfectivo
    objEntidad = objLogica.Auditoria(objEntidad)

    Dim objfrmAuditoria As New frmAuditoria
    objfrmAuditoria.USUARIO_CREACION = objEntidad.USRCRT
    objfrmAuditoria.FECHA_CREACION = objEntidad.DATCRT
    objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT
    objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMNL
    objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
    objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC
    objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC
    objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
    objfrmAuditoria.ShowDialog()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnAuditoriaRetorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoriaRetorno.Click
    Auditoria(Me.txtNrAvcRetorno1.Text)
  End Sub

  Private Sub btnAuditoria2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria2.Click
    Auditoria(Me.txtNroAVC2.Text)
  End Sub

  Private Sub btnAuditoriaRetorno2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoriaRetorno2.Click
    Auditoria(Me.txtNroAvcRetorno2.Text)
  End Sub

  Private Sub btnAuditoriaPedidoEfectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoriaPedidoEfectivo.Click
    Auditoria_PedidoEfectivo(Me.txtNroSolEfectivo.Text)
  End Sub

  Private Sub btnAuditoriaPedidoEfectivo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoriaPedidoEfectivo2.Click
    Auditoria_PedidoEfectivo(Me.txtNroSolEfectivo2.Text)
  End Sub

  Private Sub cboTransportista_ExitFocusWithOutDataInformationChanged() Handles cboTransportista.ExitFocusWithOutData, cboTransportista.InformationChanged
    Cargar_Conductor()
  End Sub
End Class

