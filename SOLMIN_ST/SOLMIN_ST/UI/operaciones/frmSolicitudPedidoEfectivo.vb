Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES

Public Class frmSolicitudPedidoEfectivo

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
  Private lstrCuentaSap As String = ""
  Private lindice As Integer = 0
  Private bs As New BindingSource
  Private strEstadoImprimir As String = ""
#End Region

#Region "Eventos"

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    If Me.dtgSolicitudEfectivo.RowCount = 0 Then Exit Sub
    Select Case Me.txtNrReferenciaSAPPedido.Text
      Case Is < 0
        HelpClass.ErrorMsgBox()
        Exit Sub
      Case 0
        If MsgBox("Desea Anular este registro?", MsgBoxStyle.YesNo, "Anular") = MsgBoxResult.No Then Exit Sub
      Case Is > 0
        Dim frm_MensajeGeneral As New frmMensajeGeneral
        With frm_MensajeGeneral
          .Text = "Mensaje - " & "Anular Pedido SAP N° : " & Me.txtNrReferenciaSAPPedido.Text.Trim
          .Mensaje = "Para proceder Anular el Pedido SAP se tiene que haber anulado en Caja primero, está seguro de Anular el Pedido."
          If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        End With
    End Select
    Me.AnularPedidoEfectivo()
    Me.Listar_Pedido_Efectivo()
  End Sub

  Private Sub dtgSolicitudEfectivo_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSolicitudEfectivo.SelectionChanged
    Limpiar_Detalle_Pedido_Efectivo()
    Listar_Detalle_Pedido_Efectivo()
  End Sub

  Private Sub frmSolicitudPedidoEfectivo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    btnBuscar_Click(Nothing, Nothing)
  End Sub

  Private Sub frmSolicitudPedidoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Me.Alinear_Columnas_Grilla()
      Me.Cargar_Compania()
      'Me.Listar_Pedido_Efectivo()
      'Me.Listar_Detalle_Pedido_Efectivo()
      Me.Validar_Usuario_Autoridado()
      Me.CargarObreros()
    Catch : End Try
  End Sub

  Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Division()
    End If
  End Sub

  Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
    If bolBuscar Then
      Cargar_Planta()
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Cursor = Cursors.WaitCursor
    Limpiar_Detalle_Pedido_Efectivo()
    Listar_Pedido_Efectivo()
    Listar_Detalle_Pedido_Efectivo()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnAutorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutorizar.Click
    If dtgSolicitudEfectivo.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If

    Dim objEntidad As New Hashtable
    With Me.dtgSolicitudEfectivo.CurrentRow
      objEntidad.Add("NMSLPE", .Cells("NMSLPE").Value)
      objEntidad.Add("ISLPES", .Cells("ISLPES").Value)
      objEntidad.Add("NORDSR", .Cells("NORDSR").Value)
      objEntidad.Add("MOTIVO", .Cells("MOTIVO").Value)
    End With

    Dim objAutorizar As New frmAutorizarPedidoEfectivo(objEntidad)
    If objAutorizar.ShowDialog = Windows.Forms.DialogResult.OK Then
      Guardar_Solicitud_Efectivo_SAP()
    End If
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Dim objParametro As New Hashtable
    objParametro.Add("COMPANIA", Me.cmbCompania.SelectedValue)
    objParametro.Add("PLANTA", Me.cmbPlanta.SelectedValue)
    objParametro.Add("DIVISION", Me.cmbDivision.SelectedValue)
    objParametro.Add("TIPCUEN", lstrTipoCuenta) 'Tipo de cuenta 
    Dim objNuevoPedido As New frmNuevoPedidoEfectivo(objParametro)
    If objNuevoPedido.ShowDialog() = Windows.Forms.DialogResult.OK Then
      Me.Cursor = Cursors.WaitCursor
      Listar_Pedido_Efectivo()
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub btnEnviarSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarSAP.Click
    Guardar_Solicitud_Efectivo_SAP()
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Imprimir_Reporte_Pedido_Efectivo()
  End Sub

  Private Sub btnImprimirLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirLista.Click
    Imprimir_Lista_Pedido_Efectivo()
  End Sub

  Private Sub Imprimir_Lista_Pedido_Efectivo()
    'rptLista_Pedido_Efectivo
    Dim objetoParametro As New Hashtable

    objetoParametro.Add("FECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
    objetoParametro.Add("FECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
    objetoParametro.Add("USUARIO", MainModule.USUARIO)
    objetoParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)
    objetoParametro.Add("CDVSN", Me.cmbDivision.SelectedValue)
    objetoParametro.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
    objetoParametro.Add("COBRR", IIf(Me.ctbObrero.Codigo.Trim = vbNullString, 0, ctbObrero.Codigo))


    Dim objParametro As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet

    Me.Cursor = Cursors.WaitCursor
    Dim objPrintForm As New PrintForm
    Dim objReporte As New rptLista_Pedido_Efectivo
    Dim objLogical As New SolicitudPedidoEfectivo_BLL
    oDt = HelpClass.GetDataSetNative(objLogical.Reporte_Lista_Pedido_Efectivo(objetoParametro))
    If oDt.Rows.Count = 0 Then
      Me.Cursor = Cursors.Default
      Exit Sub
    End If
    oDt.TableName = "PED_EFECTIVO"
    oDs.Tables.Add(oDt.Copy)
    objReporte.SetDataSource(oDs)
    objPrintForm.ShowForm(objReporte, Me)
    'IMPRIMIR DIRECTO SIN MOSTRAR EL VISOR REPORTVIEWER
    'objPrintForm.ReportViewer.ReportSource = objReporte
    'objPrintForm.ReportViewer.PrintReport() rptLista_Pedido_Efectivo.rpt
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub btnAuditoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria.Click
    Auditoria_PedidoEfectivo(Me.txtNroSolEfectivo.Text)
  End Sub

#End Region

#Region "Metodos y Funciones"

  Private Sub Validar_Usuario_Autoridado()
    Dim objParametro As New Hashtable
    Dim objLogica As New SolicitudPedidoEfectivo_BLL
    Dim objEntidad As New mantenimientos.ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

    If objEntidad.STSOP1 = "" Then
      btnAutorizar.Visible = False
      ToolStripSeparator1.Visible = False
      btnAnular.Visible = False
      ToolStripSeparator4.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      btnImprimir.Visible = False
      ToolStripSeparator3.Visible = False
      btnImprimirLista.Visible = False
    End If
    If objEntidad.STSADI = "" Then
      btnNuevo.Visible = False
    End If
  End Sub

  Private Sub Limpiar_Grilla_Solicitud_Pedido()
    Me.dtgSolicitudEfectivo.DataSource = Nothing
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
                cmbPlanta.DisplayMember = "TPLNTA"
                bolBuscar = True
        If objLisEntidad.Count > 0 Then
          lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
        Else
          lstrTipoCuenta = ""
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
    End Try
  End Sub

  Private Sub CargarObreros()
    Dim objLogicalObrero As New SolicitudPedidoEfectivo_BLL
    With Me.ctbObrero
      .DataSource = HelpClass.GetDataSetNative(objLogicalObrero.Lista_Obrero)
      .KeyField = "COBRR"
      .ValueField = "TNMBOB"
      .DataBind()
    End With
  End Sub


  Private Sub Listar_Pedido_Efectivo()
    Dim objLogicas As New SolicitudPedidoEfectivo_BLL()
    Dim objEntidad As New PedidoEfectivo

    objEntidad.FECINI = HelpClass.CtypeDate(dtpFechaInicio.Value)
    objEntidad.FECFIN = HelpClass.CtypeDate(dtpFechaFin.Value)
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
    objEntidad.COBRR = IIf(Me.ctbObrero.Codigo.Trim = vbNullString, 0, ctbObrero.Codigo)

    bs.DataSource = HelpClass.GetDataSetNative(objLogicas.ListaSolicitud_Pedido_Efectivo(objEntidad))
    Me.dtgSolicitudEfectivo.DataSource = bs
  End Sub

  Private Sub Listar_Detalle_Pedido_Efectivo()
    If dtgSolicitudEfectivo.CurrentCellAddress.Y < 0 Then Exit Sub

    Me.Cursor = Cursors.WaitCursor
    With dtgSolicitudEfectivo.CurrentRow
      txtNroSolEfectivo.Text = .Cells("NMSLPE").Value
      txtNroOperacionPedido.Text = .Cells("NORDSR").Value
      txtConductor.Text = .Cells("CODDES").Value.ToString.Trim & " - " & .Cells("TNMBOB").Value.ToString.Trim
      txtImporteSolEfectivo.Text = Format(.Cells("ISLPES").Value, "###,###,##0.00")
      txtMotivoGiro.Text = .Cells("MOTIVO").Value
      dtpFecSolEfectivo.Value = .Cells("FCSLPE").Value
      txtComentario.Text = .Cells("MTVGRO").Value
      txtNroOrdenInternaSAP.Text = .Cells("NORINS").Value
      txtNrReferenciaSAPPedido.Text = .Cells("NRFSAP").Value

      'btnAnular.Enabled = .Cells("ESTADO").Value.ToString.Equals("P")
      btnImprimir.Enabled = .Cells("FSTTRS").Value.ToString.Equals("T")
      If .Cells("USRSPV").Value <> "" Then
        txtUsuario.Text = .Cells("USRSPV").Value
        Me.dtpFechaLiquidacion.Value = .Cells("FCUSPV").Value
        Me.dtpHoraLiquidacion.Value = .Cells("FCUSPV").Value & " " & .Cells("HRUSPV").Value
        txtUsuario.Visible = True
        Me.dtpFechaLiquidacion.Visible = True
        Me.dtpHoraLiquidacion.Visible = True
        KryptonLabel3.Visible = True
        KryptonLabel2.Visible = True
        KryptonLabel1.Visible = True
        KryptonLabel4.Visible = True
        KryptonBorderEdge1.Visible = True
      Else
        txtUsuario.Visible = False
        Me.dtpFechaLiquidacion.Visible = False
        Me.dtpHoraLiquidacion.Visible = False
        KryptonLabel3.Visible = False
        KryptonLabel2.Visible = False
        KryptonLabel1.Visible = False
        KryptonLabel4.Visible = False
        KryptonBorderEdge1.Visible = False
      End If
      strEstadoImprimir = .Cells("SCNTR").Value
      If .Cells("ESTADO").Value.ToString.Equals("*") Or .Cells("ESTADO").Value.ToString.Equals("S") Then
        Activar_Autorizar(False)
        If .Cells("FSTTRS").Value.ToString.Equals("P") And .Cells("ESTADO").Value.ToString.Equals("S") Then
          btnEnviarSAP.Visible = True
          ToolStripSeparator2.Visible = False
        End If
      Else
        Activar_Autorizar(True)
      End If
    End With
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Activar_Autorizar(ByVal bolEstado As Boolean)
    Me.btnAutorizar.Enabled = bolEstado
  End Sub

  Private Sub Limpiar_Detalle_Pedido_Efectivo()
    txtNroSolEfectivo.Text = ""
    txtNroOperacionPedido.Text = ""
    txtConductor.Text = 0
    txtImporteSolEfectivo.Text = 0
    txtMotivoGiro.Text = ""
    dtpFecSolEfectivo.Value = Now
    txtComentario.Text = ""
    btnEnviarSAP.Visible = False
    ToolStripSeparator2.Visible = False
    txtNroOrdenInternaSAP.Text = ""
    strEstadoImprimir = ""
  End Sub

  Private Sub Guardar_Solicitud_Efectivo_SAP()
    If dtgSolicitudEfectivo.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    Me.Cursor = Cursors.WaitCursor
    Dim objEntidad As New ENTIDADES.SolicitudEfectivoSAP
    Dim objNegocio As New SOLMIN_ST.NEGOCIO.SolicitudEfectivoSAP_BLL
    Dim objSolicitudNegocio As New SolicitudPedidoEfectivo_BLL
    Dim objTable As New Hashtable
    Dim lstrCuentaSap As String

    Try
      With Me.dtgSolicitudEfectivo.CurrentRow
        objTable.Add("COBRR", .Cells("CODDES").Value)
        lstrCuentaSap = objSolicitudNegocio.Lista_Obrero_x_Codigo(objTable).CMTCDS
        If lstrCuentaSap = "" Then
          Me.Cursor = Cursors.Default
          HelpClass.MsgBox("El Obrero no posee Código Matchcode SAP")
          Exit Sub
        End If
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.NMSLPE = .Cells("NMSLPE").Value
        objEntidad.FCSLPE = HelpClass.CtypeDate(.Cells("FCSLPE").Value)
        objEntidad.CMSLPE = 1
        objEntidad.ICTMYS = "A"
        objEntidad.ISLPES = .Cells("ISLPES").Value
        If Me.lstrTipoCuenta = "" Then
          objEntidad.TCBDCS = "Rxx- A RENDIR CUENTA"
        Else
          objEntidad.TCBDCS = lstrTipoCuenta & "- A RENDIR CUENTA"
        End If
        objEntidad.TADSAP = .Cells("NPLCUN").Value
        objEntidad.FVENDP = HelpClass.CtypeDate(Now)
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.CUSCRT = MainModule.USUARIO
                objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CMTCDS = lstrCuentaSap
        objEntidad.NPLCUN = .Cells("NPLCUN").Value
        objEntidad.NOPRCN = .Cells("NORDSR").Value
        objEntidad = objNegocio.Guardar_Solicitud_Efectivo_SAP(objEntidad)
        If objEntidad.NRFSAP <> 0 Then
          HelpClass.MsgBox("Envió Satisfactoriamente al SAP")
          .Cells("NRFSAP").Value = objEntidad.NRFSAP
          Actualizar_Supervisor()
          Imprimir_Reporte_Pedido_Efectivo()
          lindice = dtgSolicitudEfectivo.CurrentCellAddress.Y
          Listar_Pedido_Efectivo()
          dtgSolicitudEfectivo.SelectedRows(0).Selected = False
          Me.dtgSolicitudEfectivo.Rows(lindice).Selected = True
          Limpiar_Detalle_Pedido_Efectivo()
          Listar_Detalle_Pedido_Efectivo()
          Me.Cursor = Cursors.Default
        Else
          HelpClass.MsgBox("Error al Enviar a SAP " & Chr(13) & objEntidad.TSTERS, MessageBoxIcon.Error)
          Me.Cursor = Cursors.Default
        End If
      End With
    Catch ex As Exception
      HelpClass.ErrorMsgBox()
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub Actualizar_Supervisor()
    Dim objLogica As New NEGOCIO.PedidoEfectivo_BLL
    Dim objEntidad As New PedidoEfectivo
    Try
      With Me.dtgSolicitudEfectivo.CurrentRow
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.NMSLPE = .Cells("NMSLPE").Value
        objEntidad.FCUSPV = HelpClass.CtypeDate(Now)
        objEntidad.HRUSPV = HelpClass.NowNumeric
        objEntidad.USRSPV = MainModule.USUARIO
        objLogica.Actualizar_Supervisor(objEntidad)
        .Cells("ESTADO").Value = "S"
      End With
    Catch ex As Exception
      HelpClass.MsgBox("Error al Enviar a SAP")
    End Try
  End Sub

  Private Sub Imprimir_Reporte_Pedido_Efectivo()
    If dtgSolicitudEfectivo.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If

    Dim objParametro As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet

    Me.Cursor = Cursors.WaitCursor
    Dim objPrintForm As New PrintForm
    With Me.dtgSolicitudEfectivo.CurrentRow
      If .Cells("NRFSAP").Value <> 0 Then
        Dim objReporte As New rptSolicitudEfectivo
        Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL
        objParametro.Add("NCSLPE", .Cells("NMSLPE").Value)
        oDt = HelpClass.GetDataSetNative(objLogical.Reporte_Pedido_Efectivo(objParametro))
        oDt.TableName = "GastosRuta"
        oDs.Tables.Add(oDt.Copy)
        'HelpClass.CrystalReportTextObject(objReporte, "lblEstadoImprimir", strEstadoImprimir)
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)
        'IMPRIMIR DIRECTO SIN MOSTRAR EL VISOR REPORTVIEWER
        'objPrintForm.ReportViewer.ReportSource = objReporte
        'objPrintForm.ReportViewer.PrintReport()
      End If
    End With

    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.dtgSolicitudEfectivo.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgSolicitudEfectivo.ColumnCount - 1
      Me.dtgSolicitudEfectivo.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
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

  Private Sub AnularPedidoEfectivo()

    Dim objEntidad As New PedidoEfectivo
    Dim objLogical As New NEGOCIO.PedidoEfectivo_BLL
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
    objEntidad.NMSLPE = Me.txtNroSolEfectivo.Text
    objEntidad.SESTRG = "*"
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
    If objLogical.Anular_Pedido_Efectivo(objEntidad) = 0 Then
      HelpClass.ErrorMsgBox()
    End If

  End Sub

#End Region


End Class

