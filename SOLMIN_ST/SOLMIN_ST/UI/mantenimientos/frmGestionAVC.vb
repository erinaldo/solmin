Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO


Public Class frmGestionAVC

  Private bs As New BindingSource
  'Private strEstadoImprimir As String = ""

  Private Sub frmGestionAVC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Carga_Estado()
      Alinear_Columnas_Grilla()
      Cargar_Compania()
      Cargar_Combos()
      Lista_GestionAVC()
      Validar_Usuario_Autoridado()
    Catch : End Try
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    For lint_contador As Integer = 0 To Me.dtgGestionAVC.ColumnCount - 1
      Me.dtgGestionAVC.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Validar_Usuario_Autoridado()
    Dim objEntidad As New Hashtable
    Dim objLogica As New NEGOCIO.Operaciones.SolicitudPedidoEfectivo_BLL
    Dim objEntidadValidar As New ENTIDADES.mantenimientos.ClaseGeneral

    objEntidad.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objEntidad.Add("MMCUSR", MainModule.USUARIO)
    objEntidad.Add("MMNPVB", Me.Name.Trim)
    objEntidadValidar = objLogica.Validar_Usuario_Autorizado(objEntidad)

    If objEntidadValidar.STSOP2 = "" Then
      btnImprimir.Visible = False
      ToolStripSeparator1.Visible = False
      btnImprimirGeneral.Visible = False
    End If
    If objEntidadValidar.STSADI = "" Then
      btnGenerarAVC.Visible = False
    End If
  End Sub


  Private Sub btnBuscarGastosRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGastosRuta.Click
    Me.Cursor = Cursors.WaitCursor
    Limpiar_Detalle()
    Lista_GestionAVC()
    Me.Cursor = Cursors.Default
  End Sub

#Region "Ubicación Organizacional"
  Private bolBuscar As Boolean
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private _lstrTipoCuenta As String

  Public Property lstrTipoCuenta() As String
    Get
      Return _lstrTipoCuenta
    End Get
    Set(ByVal value As String)
      _lstrTipoCuenta = value
    End Set
  End Property

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
        'cmbCompania.SelectedIndex = 0
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
        Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
        objEntidad.CPLNDV = "0"
        objEntidad.TPLNTA = "TODOS"
        objLisEntidad.Insert(0, objEntidad)
        cmbPlanta.DataSource = objLisEntidad
        cmbPlanta.ValueMember = "CPLNDV"
        cmbPlanta.DisplayMember = "TPLNTA"
        bolBuscar = True
        If objLisEntidad.Count > 0 Then
          _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
        Else
          _lstrTipoCuenta = ""
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
    End Try
  End Sub

  Private Sub Cargar_Combos()
    Dim objEntidadTracto As New ENTIDADES.mantenimientos.TransportistaTracto

    Try
      bolBuscar = False
      CargarTransportista()

      Dim objLogicalObrero As New NEGOCIO.Operaciones.SolicitudPedidoEfectivo_BLL
      Try
        With Me.ctbObrero
          .DataSource = HelpClass.GetDataSetNative(objLogicalObrero.Lista_Obrero)
          .KeyField = "COBRR"
          .ValueField = "TNMBOB"
          .DataBind()
        End With
      Catch : End Try
      bolBuscar = True
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CargarTransportista()

    Dim pNRUCTR_RucTransportista As String = String.Empty
    If Me.cmbCompania.SelectedValue = "EZ" Then
      pNRUCTR_RucTransportista = "20100039207"
    End If

    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    obeTransportista.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeTransportista.pNRUCTR_RucTransportista = pNRUCTR_RucTransportista
    cboTransportista.pCargar(obeTransportista)
  End Sub

  Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Division()
      CargarTransportista()
    End If
  End Sub

  Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Planta()
    End If
  End Sub
#End Region

  Private Sub Lista_GestionAVC()
    Me.dtgGestionAVC.AutoGenerateColumns = False

    bs.DataSource = ListaAVC()
    Me.dtgGestionAVC.DataSource = bs
    If Me.dtgGestionAVC.Rows.Count > 0 Then
      CargarDetalle_GestionAVC()
    End If
  End Sub

  Private Function ListaAVC() As DataTable
    Dim objetoParametro As New Hashtable
    Dim objLogical As New AVC_BLL()
    Dim oblListEntidad As New List(Of AVC)

    objetoParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)
    objetoParametro.Add("CDVSN", Me.cmbDivision.SelectedValue)
    objetoParametro.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
    objetoParametro.Add("TIPO", IIf(Me.rbtnFechaAVC.Checked, 0, 1))
    objetoParametro.Add("FECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
    objetoParametro.Add("FECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
    If Me.ctbObrero.Codigo = vbNullString Then
      objetoParametro.Add("PNCOBRR", 0) 'CHOFER
    Else
      objetoParametro.Add("PNCOBRR", Me.ctbObrero.Codigo) 'CHOFER
    End If
    objetoParametro.Add("SESAVC", cmbEstado.SelectedValue)
    objetoParametro.Add("NCTAVC", IIf(IsNumeric(Me.txtAVCbusqueda.Text), Me.txtAVCbusqueda.Text, 0))
    Me.dtgGestionAVC.AutoGenerateColumns = False
    Return HelpClass.GetDataSetNative(objLogical.Lista_Mantenimiento_AVC(objetoParametro))
  End Function

  Private Function ListaReporteAVC() As DataTable
    Dim objetoParametro As New Hashtable
    Dim objLogical As New AVC_BLL()
    Dim oblListEntidad As New List(Of AVC)

    objetoParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)
    objetoParametro.Add("CDVSN", Me.cmbDivision.SelectedValue)
    objetoParametro.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
    objetoParametro.Add("TIPO", IIf(Me.rbtnFechaAVC.Checked, 0, 1))
    objetoParametro.Add("FECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
    objetoParametro.Add("FECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
    If Me.ctbObrero.Codigo = vbNullString Then
      objetoParametro.Add("PNCOBRR", 0) 'CHOFER
    Else
      objetoParametro.Add("PNCOBRR", Me.ctbObrero.Codigo) 'CHOFER
    End If
    objetoParametro.Add("SESAVC", cmbEstado.SelectedValue)
    objetoParametro.Add("NCTAVC", IIf(IsNumeric(Me.txtAVCbusqueda.Text), Me.txtAVCbusqueda.Text, 0))
    Me.dtgGestionAVC.AutoGenerateColumns = False
    Return HelpClass.GetDataSetNative(objLogical.Lista_Reporte_AVC(objetoParametro))
  End Function


  Private Sub btnGenerarAVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAVC.Click
    GenerarAVC()
  End Sub

  Private Sub GenerarAVC(Optional ByVal intTipo As Integer = 0)
    Dim objParametros As New Hashtable
    Dim obeEntidad As New AVC

    objParametros.Add("COMPANIA", Me.cmbCompania.SelectedValue)
    obeEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objParametros.Add("PLANTA", Me.cmbPlanta.SelectedValue)
    obeEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
    objParametros.Add("DIVISION", Me.cmbDivision.SelectedValue)
    obeEntidad.CDVSN = Me.cmbCompania.SelectedValue
    objParametros.Add("TIPCUEN", lstrTipoCuenta) 'Tipo de cuenta 
    objParametros.Add("NCSLPE", 0) 'Tiene pedido


    Dim objFrmSolicitudEfectivoAVC As New frmSolicitudEfectivoAVC()
    objFrmSolicitudEfectivoAVC.TIPOCON = intTipo
    objFrmSolicitudEfectivoAVC.TIPCUEN = lstrTipoCuenta
    objFrmSolicitudEfectivoAVC.ckbGenerarPedidoEfectivo.Visible = False
    objFrmSolicitudEfectivoAVC.Text = "Nuevo AVC"
    If objFrmSolicitudEfectivoAVC.ShowDialog = Windows.Forms.DialogResult.OK Then
      Lista_GestionAVC()
    End If
  End Sub

  Private Sub CargarDetalle_GestionAVC()
    If dtgGestionAVC.CurrentCellAddress.Y < 0 Then Exit Sub
    Me.Cursor = Cursors.WaitCursor

    Dim Objeto_Logica As New NEGOCIO.AVC_BLL
    With dtgGestionAVC.CurrentRow
      Me.txtNroOperacion.Text = .Cells("NOPRCN").Value
      Me.txtPlaca.Text = .Cells("NPLCUN").Value
      Me.txtOrigen.Text = .Cells("RUTA").Value
      Me.txtNroBrevete.Text = .Cells("CBRCNT").Value
      Me.txtPlaca.Text = .Cells("NPLCUN").Value
      Me.txtNombreObrero.Text = .Cells("TNMBOB").Value
      Me.dtpFechaAvc.Value = .Cells("FINAVC").Value
      Me.txtMedioTransporte.Text = .Cells("TTPMDT").Value
      Me.txtObrero.Text = .Cells("COBRR").Value
      Me.txtNroAVC.Text = .Cells("NCTAVC").Value
      Me.txtImporteAVC.Text = .Cells("IRTAVC").Value
      Me.txtAdelanto.Text = .Cells("IARAVC").Value
      txtNroOrdenInternaSAP.Text = .Cells("NORINS").Value
      txtNrReferenciaSAPAVC.Text = .Cells("NRFSAP").Value
      dtpFechaLiquidacion.Visible = Not .Cells("FCHLQD").Value.Equals("")
      KryptonLabel4.Visible = dtpFechaLiquidacion.Visible
      dtpFechaLiquidacion.Value = IIf(dtpFechaLiquidacion.Visible, .Cells("FCHLQD").Value.ToString, Now)
      If Not (txtImporteAVC.Text > 0 And txtAdelanto.Text = 0) Then
        If .Cells("NRFSAP").Value = 0 And txtImporteAVC.Text <> 0 Then
          btnReenviarSAP.Visible = True
          ToolStripSeparator4.Visible = True
        End If
      End If
      Select Case .Cells("SESAVC").Value
        Case "P"
          Me.txtEstado2.Text = "PENDIENTE"
        Case "L"
          Me.txtEstado2.Text = "LIQUIDADO"
        Case "*"
          Me.txtEstado2.Text = "ANULADO"
      End Select
      btnAnular.Enabled = .Cells("SESAVC").Value.ToString.Equals("P")
      btnImprimir.Enabled = Not .Cells("SESAVC").Value.ToString.Equals("*")
      'strEstadoImprimir = .Cells("SFLSPE").Value
    End With
    Me.Cursor = Cursors.Default

  End Sub

  Private Sub btnImprimirGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirGeneral.Click
    Imprimir_AVC()
  End Sub

  Private Sub Imprimir_AVC()
    Dim objDt As New DataTable
    Dim oDs As New DataSet
    Me.Cursor = Cursors.WaitCursor

    Dim objReporte As New rptLista_Gestion_AVC 'por mientras
    Dim objPrintForm As New PrintForm
    objDt = ListaReporteAVC()
    objDt.TableName = "AVC"
    If objDt.Rows.Count > 0 Then
      oDs.Tables.Add(objDt.Copy)
      objReporte.SetDataSource(oDs)
      objReporte.SetParameterValue("pUsuario", MainModule.USUARIO)
      objReporte.SetParameterValue("pFecIni", dtpFechaInicio.Value)
      objReporte.SetParameterValue("pFecFin", dtpFechaFin.Value)
      objReporte.SetParameterValue("pCompania", Me.cmbCompania.Text)
      objReporte.SetParameterValue("pDivision", Me.cmbDivision.Text)
      objReporte.SetParameterValue("pPlanta", Me.cmbPlanta.Text)

      If Me.rbtnFechaAVC.Checked Then
        objReporte.SetParameterValue("pEstado", cmbEstado.Text)
        objReporte.SetParameterValue("pTipo", "FECHA AVC")
      Else
        objReporte.SetParameterValue("pEstado", "LIQUIDADOS")
        objReporte.SetParameterValue("pTipo", "FECHA LIQUIDACIÓN")
      End If

      objPrintForm.ShowForm(objReporte, Me)
    End If

    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnReenviarSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenviarSAP.Click
    If dtgGestionAVC.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    If Me.dtgGestionAVC.SelectedRows(0).Cells("NCTAVC").Value.ToString.Trim <> 0 Then
      Guardar_Solicitud_Efectivo_SAP(Me.dtgGestionAVC.SelectedRows(0).Cells("NCTAVC").Value)
    End If
    Limpiar_Detalle()
    CargarDetalle_GestionAVC()
  End Sub

  Private Sub Guardar_Solicitud_Efectivo_SAP(ByVal pdblNrAVC As Double)
    Dim objEntidad As New ENTIDADES.SolicitudEfectivoSAP
    Dim objNegocio As New SOLMIN_ST.NEGOCIO.SolicitudEfectivoSAP_BLL

    Try
      Me.Cursor = Cursors.WaitCursor
      objEntidad.CCMPN = cmbCompania.SelectedValue
      objEntidad.NMSLPE = pdblNrAVC
      objEntidad.FCSLPE = HelpClass.CtypeDate(Now)
      objEntidad.CMSLPE = 1
      objEntidad.ICTMYS = "E"
      objEntidad.ISLPES = txtAdelanto.Text
      objEntidad.TCBDCS = "ADELANTO AVC"
      objEntidad.TADSAP = Me.dtgGestionAVC.SelectedRows(0).Cells("NPLCUN").Value
      objEntidad.FVENDP = HelpClass.CtypeDate(Now)
      objEntidad.FCHCRT = HelpClass.TodayNumeric
      objEntidad.HRACRT = HelpClass.NowNumeric
      objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      objEntidad.CDVSN = cmbDivision.SelectedValue

      'Buscar el Código Sap del Obrero ("Chofer")
      Dim objEntidadObrero As New Obrero
      objEntidadObrero = CargarObrero(txtNroBrevete.Text.Trim)

      objEntidad.CMTCDS = objEntidadObrero.CMTCDS
      objEntidad.NPLCUN = Me.dtgGestionAVC.SelectedRows(0).Cells("NPLCUN").Value
      objEntidad.NOPRCN = Me.dtgGestionAVC.SelectedRows(0).Cells("NOPRCN").Value
      objEntidad = objNegocio.Guardar_Solicitud_Efectivo_SAP(objEntidad)
      If objEntidad.NRFSAP <> 0 Then
        HelpClass.MsgBox("Envió Satisfactoriamente al SAP")
        Imprimir_Solicitud_Efectivo(objEntidad.NMSLPE, "")
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

  Private Function CargarObrero(ByVal strBrevete As String) As Obrero
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objListEntidad As New Obrero
    Dim objetoParametro As New Hashtable

    objetoParametro.Add("PSCBRCNT", strBrevete)
    objListEntidad = Objeto_Logica.Obtener_Datos_Obrero(objetoParametro)
    Return objListEntidad
  End Function

  Private Sub Imprimir_Solicitud_Efectivo(ByVal dblNumeroAVC As Double, ByVal strEstadoImprimir As String)

    Try
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
        If strEstadoImprimir <> "" Then
          HelpClass.CrystalReportTextObject(objReporte, "lblRePrint1", "COPIA")
          HelpClass.CrystalReportTextObject(objReporte, "lblRePrint2", "COPIA")
          HelpClass.CrystalReportTextObject(objReporte, "lblRePrint3", "COPIA")
          HelpClass.CrystalReportTextObject(objReporte, "lblRePrint4", "COPIA")
        End If
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)

      End If
      Me.Cursor = Cursors.Default
    Catch ex As Exception
      Me.Cursor = Cursors.Default
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
    End Try

  End Sub

  Private Sub Limpiar_Detalle()
    btnReenviarSAP.Visible = False
    ToolStripSeparator4.Visible = False
    Me.txtNroOperacion.Text = ""
    Me.txtPlaca.Text = ""
    Me.txtOrigen.Text = ""
    Me.txtNroBrevete.Text = ""
    Me.txtPlaca.Text = ""
    Me.txtNombreObrero.Text = ""
    Me.dtpFechaAvc.Value = Now
    Me.txtMedioTransporte.Text = ""
    Me.txtObrero.Text = ""
    Me.txtNroAVC.Text = ""
    Me.txtImporteAVC.Text = ""
    Me.txtAdelanto.Text = ""
    Me.txtEstado2.Text = ""
    txtNroOrdenInternaSAP.Text = ""
    txtNrReferenciaSAPAVC.Text = "0"
    btnAnular.Enabled = False
    'strEstadoImprimir = ""
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    If dtgGestionAVC.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    Imprimir_Solicitud_Efectivo(dtgGestionAVC.CurrentRow.Cells("NCTAVC").Value, dtgGestionAVC.CurrentRow.Cells("SFLSPE").Value)
  End Sub

  Private Sub Carga_Estado()
    Me.cmbEstado.DataSource = Estado()
    Me.cmbEstado.ValueMember = "COD"
    Me.cmbEstado.DisplayMember = "NOM"
  End Sub

  Private Function Estado() As DataTable
    Dim oDt As New DataTable

    oDt.Columns.Add("COD")
    oDt.Columns.Add("NOM")

    Dim oDr As DataRow

    oDr = oDt.NewRow
    oDr.Item(0) = ""
    oDr.Item(1) = "TODOS"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "P"
    oDr.Item(1) = "PENDIENTES"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "L"
    oDr.Item(1) = "LIQUIDADOS"
    oDt.Rows.Add(oDr)

    Return oDt

  End Function

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    If Not txtNrReferenciaSAPAVC.Text.ToString.Equals("0") Then
      If MsgBox("Este registro fue enviada al SAP, Desea Anular ?", MsgBoxStyle.YesNo, "Anular") = MsgBoxResult.No Then
        Exit Sub
      End If
    Else
      If MsgBox("Desea Anular este registro?", MsgBoxStyle.YesNo, "Anular") = MsgBoxResult.No Then
        Exit Sub
      End If
    End If
    Anular_AVC()
    Me.Lista_GestionAVC()

  End Sub

  Private Sub Anular_AVC()
    Dim objLogical As New AVC_BLL
    Dim objEntidad As New AVC
    objEntidad.NCTAVC = Me.txtNroAVC.Text
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
    objEntidad.SESAVC = "*"
    If objLogical.Anular(objEntidad) = 0 Then
      HelpClass.ErrorMsgBox()
    End If
  End Sub

  Private Sub dtgGastosRuta_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgGestionAVC.SelectionChanged
    Me.Limpiar_Detalle()
    CargarDetalle_GestionAVC()
  End Sub

  Private Sub txtAVCbusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAVCbusqueda.KeyPress
    If e.KeyChar = Chr(13) Then
      Me.Cursor = Cursors.WaitCursor
      Limpiar_Detalle()
      Lista_GestionAVC()
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub Auditoria(ByVal dblNrAVC As String)
    If dblNrAVC.Trim.Length = 0 OrElse dblNrAVC = 0 Then Exit Sub

    Me.Cursor = Cursors.WaitCursor
    Dim objLogica As New NEGOCIO.AVC_BLL
    Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
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

  Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
    Auditoria(Me.txtNroAVC.Text)
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If Me.dtgGestionAVC.RowCount = 0 Then Exit Sub
    Dim objDt As New DataTable
    Dim objListDt As New List(Of DataTable)
    Dim objetoParametro As New Hashtable
    Dim objLogical As New AVC_BLL()
    Me.Cursor = Cursors.WaitCursor
    Try
      objetoParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)
      objetoParametro.Add("CDVSN", Me.cmbDivision.SelectedValue)
      objetoParametro.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
      objetoParametro.Add("TIPO", IIf(Me.rbtnFechaAVC.Checked, 0, 1))
      objetoParametro.Add("FECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
      objetoParametro.Add("FECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
      If Me.ctbObrero.Codigo = vbNullString Then
        objetoParametro.Add("PNCOBRR", 0) 'CHOFER
      Else
        objetoParametro.Add("PNCOBRR", Me.ctbObrero.Codigo) 'CHOFER
      End If
      objetoParametro.Add("SESAVC", cmbEstado.SelectedValue)
      objetoParametro.Add("NCTAVC", IIf(IsNumeric(Me.txtAVCbusqueda.Text), Me.txtAVCbusqueda.Text, 0))
      Me.dtgGestionAVC.AutoGenerateColumns = False
      objDt = objLogical.Lista_Reporte_AVC_Tabla(objetoParametro)
      objListDt.Add(objDt.Copy)
      Ransa.Utilitario.HelpClass_NPOI.ExportExcel(objListDt, "PLANILLA DE CONDUCTORES")
    Catch ex As Exception
      Me.Cursor = Cursors.Default
    End Try

    Me.Cursor = Cursors.Default
  End Sub
End Class
