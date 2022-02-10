Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class frmSolicitudEfectivoAVC

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub

#Region "Variables"
  Private bolBuscar As Boolean
  Private lstrCuentaSap As String
  Private lbolEstadoGuardado As Boolean = False
  Private lbolEstadoEnviadoSAP As Boolean = False
  Public obeEntidad As New AVC

#End Region

#Region "Propiedades"

  Private _NRAVC As Double = 0
  Private _NRSOL As Double = 0
  Private _TIPOCON As Double
  Private _TIPCUEN As String = ""
  Private _RETORNO As Double = 0
  Private mCCMPN As String = ""
  Private mCDVSN As String = ""
  Private mCPLNDV As Int32 = 0

  Public Property CCMPN() As String
    Get
      Return mCCMPN
    End Get
    Set(ByVal value As String)
      mCCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      mCDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int32
    Set(ByVal value As Int32)
      mCPLNDV = value
    End Set
  End Property

  Public Property NRAVC() As Double
    Get
      Return _NRAVC
    End Get
    Set(ByVal Value As Double)
      _NRAVC = Value
    End Set
  End Property

  Public Property NRSOL() As Double
    Get
      Return _NRSOL
    End Get
    Set(ByVal Value As Double)
      _NRSOL = Value
    End Set
  End Property

  Public Property TIPOCON() As Double
    Get
      Return _TIPOCON
    End Get
    Set(ByVal value As Double)
      _TIPOCON = value
    End Set
  End Property

  Public Property TIPCUEN() As String
    Get
      Return _TIPCUEN
    End Get
    Set(ByVal value As String)
      _TIPCUEN = value
    End Set
  End Property


  Public Property RETORNO() As Double
    Get
      Return _RETORNO
    End Get
    Set(ByVal value As Double)
      _RETORNO = value
    End Set
  End Property



#End Region

#Region "Eventos"

    Private Sub frmSolicitudEfectivoAVC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Limpiar_Detalle()
            Cargar_Combos()
            Me.cmbMedioTransporte.SelectedValue = -1
            Cargar_Grilla_Detalle_GastoRuta()
            If obeEntidad.NCSLPE <> 0 Then
                ckbGenerarPedidoEfectivo.Enabled = False
            End If
            If Me._RETORNO = 1 Then
                ckbGenerarPedidoEfectivo.Visible = False
            End If
            PanelImporte.Location = New Point(0, 170)
            Me.Size = New Size(620, 400)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

    Private Sub btnBuscarGastosRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGastosRuta.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Validar_Datos() Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            Guardar_AVC()
            If Me.ckbGenerarPedidoEfectivo.Checked Then
                Guardar_Pedido_Efectivo()
            End If
            If lbolEstadoGuardado Then
                If lbolEstadoEnviadoSAP Then
                    Imprimir_Reporte_Pedido_Efectivo()
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub cmbMedioTransporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedioTransporte.SelectedIndexChanged
    '      Try
    '          If bolBuscar Then
    '              Calcular_Importe_Ruta()
    '          End If
    '      Catch ex As Exception
    '          MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '      End Try

    'End Sub

  Private Sub ckbGenerarPedidoEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbGenerarPedidoEfectivo.CheckedChanged
        Try
            If Me.ckbGenerarPedidoEfectivo.Checked Then
                ocultar_Controles(True)
            Else
                ocultar_Controles(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
  End Sub

  Private Sub txtImporteSolEfectivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteSolEfectivo.KeyPress

    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtImporteSolEfectivo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If IsNumeric(txtImporteSolEfectivo.Text) Then
      txtImporteSolEfectivo.Text = Format(CType(txtImporteSolEfectivo.Text, Double), "###,###,##0.00")
    Else
      txtImporteSolEfectivo.Text = "0"
    End If
  End Sub

#End Region

#Region "Metodos y Funciones"

  Private Sub Limpiar_Detalle()
    Me.txtComentario.Text = ""
    Me.txtMotivoGiro.Text = ""
    Me.cmbObrero.SelectedValue = -1
    Me.txtNroAVC.Text = ""
    Me.txtNroBrevete.Text = ""
    Me.txtNroOperacion.Text = ""
    Me.txtNroSolEfectivo.Text = ""
    Me.txtOrigen.Text = ""
    Me.cmbPlaca.SelectedIndex = -1
    Me.dtpFechaAvc.Value = Now
    Me.KryptonLabel12.Visible = True
    Me.cmbMedioTransporte.Enabled = True
    Me.txtImporteAVC.Text = "0.00"
    Me.txtAdelanto.Text = "0.00"
    Me.txtImporteSolEfectivo.Text = "0.00"
  End Sub

  Private Sub Calcular_Importe_Ruta()
    Dim dblCantidad As Double
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objListEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objetoParametro As New Hashtable
    Dim strError As String = ""
    lblErrorAVC.Text = ""
    If Me.cmbMedioTransporte.SelectedValue <> Nothing Then
      objetoParametro.Add("PSCCMPN", Me.mCCMPN)
      objetoParametro.Add("PSCBRCNT", Me.txtNroBrevete.Text)
      objetoParametro.Add("PNCCLNT", obeEntidad.CCLNT)
      objetoParametro.Add("PNCTPMDT", Me.cmbMedioTransporte.SelectedValue)
      objetoParametro.Add("PNCLCLOR", obeEntidad.CLCLOR)
      objetoParametro.Add("PNCLCLDS", obeEntidad.CLCLDS)
      objListEntidad = Objeto_Logica.Calular_Importe_Ruta(objetoParametro)
      If objListEntidad.Count > 0 Then
        dblCantidad = objListEntidad.Item(0).IARAVC
        If objListEntidad.Item(0).QDSTKM = 0 Then
          strError = strError & " * No está definido asignación de ruta AVC " & Chr(10) & "     Ruta: " & Me.txtOrigen.Text & Chr(10) & "     Medio de transporte :" & Me.cmbMedioTransporte.Text & Chr(10)
        ElseIf objListEntidad.Item(0).IFCTPG = 0 Then
          strError = " * No está definido factor AVC" & Chr(10) & "     Medio de transporte :" & Me.cmbMedioTransporte.Text
        End If
        If strError.Length > 0 Then Me.lblErrorAVC.Text = strError
        Me.txtImporteAVC.Text = Format(dblCantidad, "###,###,##0.00")
        If chkAvcRetorno.Checked Then
          Me.txtAdelanto.Text = 0
        Else
          Me.txtAdelanto.Text = Format(Math.Floor(txtImporteAVC.Text / 2), "###,###,##0.00")
        End If

        Me.txtImporteSolEfectivo.Text = objListEntidad.Item(0).IGSTVJ
      Else
        Me.txtImporteAVC.Text = "0.00"
        Me.txtAdelanto.Text = "0.00"
        Me.txtImporteSolEfectivo.Text = "0.00"
        strError = strError & " * No está definido asignación de ruta AVC " & Chr(10) & "     Ruta: " & Me.txtOrigen.Text & Chr(10) & "     Medio de transporte :" & Me.cmbMedioTransporte.Text & Chr(10)
        strError = " * No está definido factor AVC" & Chr(10) & "     Medio de transporte :" & Me.cmbMedioTransporte.Text
        If strError.Length > 0 Then Me.lblErrorAVC.Text = strError
      End If
    End If
  End Sub

  Private Sub Guardar_AVC()

    Me.Cursor = Cursors.WaitCursor
    Dim objEntidad As New ENTIDADES.AVC
    Dim objLogic As New NEGOCIO.AVC_BLL
        'Try
        objEntidad.FINAVC = HelpClass.CtypeDate(Now)
        objEntidad.NCSOTR = obeEntidad.NCSOTR
        objEntidad.NCRRSR = obeEntidad.NCRRSR
        objEntidad.COBRR = Me.cmbObrero.SelectedValue
        objEntidad.NOPRCN = Me.txtNroOperacion.Text
        objEntidad.CTPMDT = Me.cmbMedioTransporte.SelectedValue
        objEntidad.CLCLOR = obeEntidad.CLCLOR
        objEntidad.CLCLDS = obeEntidad.CLCLDS
        objEntidad.IRTAVC = Me.txtImporteAVC.Text
        objEntidad.IARAVC = txtAdelanto.Text
        objEntidad.SESAVC = "P"
        objEntidad.NPLCUN = cmbPlaca.Text
        objEntidad.CBRCNT = Me.txtNroBrevete.Text
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.USRCRT = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NORSRT = obeEntidad.NORSRT
        objEntidad.TIPOCON = _TIPOCON
        objEntidad.RETORNO = _RETORNO
        objEntidad = objLogic.Guardar_AVC(objEntidad)

        If objEntidad.NCTAVC <> 0 Then
            If objEntidad.NCTAVC = -1 Then
                HelpClass.MsgBox("Ya se ha Generado AVC para el conductor :" + cmbObrero.Text + "" & Chr(10) & " con el número de operación: " & txtNroOperacion.Text & " y placa :" & Me.cmbPlaca.Text & " ")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            HelpClass.MsgBox("El registro se guardó satisfactoriamente")
            _NRAVC = objEntidad.NCTAVC
            txtNroAVC.Text = objEntidad.NCTAVC
            If Not chkAvcRetorno.Checked Then
                Guardar_Solicitud_Efectivo_SAP(objEntidad.NCTAVC, 1)
            End If
            Imprimir_Solicitud_Efectivo()
            lbolEstadoGuardado = True
        Else
            HelpClass.MsgBox("Error al Guardar")
            lbolEstadoGuardado = False
            Me.Cursor = Cursors.Default
        End If

        'Catch ex As Exception
        '    End Try

        Me.Cursor = Cursors.Default
  End Sub

  Private Sub Guardar_Solicitud_Efectivo_SAP(ByVal pdblNrAVC As Double, ByVal pintTipo As Double)
    Dim objEntidad As New ENTIDADES.SolicitudEfectivoSAP
    Dim objNegocio As New SOLMIN_ST.NEGOCIO.SolicitudEfectivoSAP_BLL
        'Try
        objEntidad.CCMPN = obeEntidad.CCMPN
        objEntidad.NMSLPE = pdblNrAVC
        objEntidad.FCSLPE = HelpClass.CtypeDate(Now)
        objEntidad.CMSLPE = 1
        If pintTipo = 1 Then
            objEntidad.ICTMYS = "E"
            objEntidad.ISLPES = txtAdelanto.Text
            objEntidad.TCBDCS = "ADELANTO AVC"
            objEntidad.TADSAP = obeEntidad.NPLCUN
        Else
            objEntidad.ICTMYS = "A"
            objEntidad.ISLPES = txtImporteSolEfectivo.Text
            If Me._TIPCUEN = "" Then
                objEntidad.TCBDCS = "Rxx- A RENDIR CUENTA"
            Else
                objEntidad.TCBDCS = Me._TIPCUEN & "- A RENDIR CUENTA"
            End If
            objEntidad.TADSAP = obeEntidad.NPLCUN & " - " & obeEntidad.RUTA
        End If
        objEntidad.FVENDP = HelpClass.CtypeDate(Now)
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CDVSN = obeEntidad.CDVSN
        objEntidad.CMTCDS = lstrCuentaSap
        objEntidad.NPLCUN = Me.cmbPlaca.Text
        objEntidad.NOPRCN = txtNroOperacion.Text
        objEntidad = objNegocio.Guardar_Solicitud_Efectivo_SAP(objEntidad)
        If objEntidad.NRFSAP <> 0 Then
            HelpClass.MsgBox("Envió Satisfactoriamente al SAP")
            If objEntidad.ICTMYS = "A" Then
                Actualizar_Supervisor(pdblNrAVC)
            End If
            lbolEstadoEnviadoSAP = True
        Else
            HelpClass.MsgBox("Error al Enviar a SAP " & Chr(13) & objEntidad.TSTERS, MessageBoxIcon.Error)
            lbolEstadoEnviadoSAP = False
            Me.Cursor = Cursors.Default
        End If
        'Catch ex As Exception
        '        HelpClass.MsgBox("Error al Enviar a SAP")
        '        lbolEstadoEnviadoSAP = False
        '    End Try
  End Sub

  Private Sub Actualizar_Supervisor(ByVal pdblNrAVC As Double)
    Dim objLogica As New NEGOCIO.PedidoEfectivo_BLL
    Dim objEntidad As New PedidoEfectivo
        'Try
        objEntidad.CCMPN = obeEntidad.CCMPN
        objEntidad.CDVSN = obeEntidad.CDVSN
        objEntidad.CPLNDV = obeEntidad.CPLNDV
        objEntidad.NMSLPE = pdblNrAVC
        objEntidad.FCUSPV = HelpClass.CtypeDate(Now)
        objEntidad.HRUSPV = HelpClass.NowNumeric
        objEntidad.USRSPV = MainModule.USUARIO
        objLogica.Actualizar_Supervisor(objEntidad)
        'Catch ex As Exception
        '        HelpClass.MsgBox("Error al Enviar a SAP")
        '    End Try
  End Sub

  Private Sub Guardar_Pedido_Efectivo()
    Dim objEntidad As New ENTIDADES.PedidoEfectivo
    Dim objLogic As New NEGOCIO.PedidoEfectivo_BLL

    If Me.cmbObrero.SelectedValue = vbNullString Then
      Exit Sub
    End If
    If Me.txtImporteSolEfectivo.Text = 0 Then
      Exit Sub
    End If
    Me.Cursor = Cursors.WaitCursor
    objEntidad.NCSOTR = obeEntidad.NCSOTR
    objEntidad.NCRRSR = obeEntidad.NCRRSR
    objEntidad.CCMPN = obeEntidad.CCMPN
    objEntidad.CDVSN = obeEntidad.CDVSN
    objEntidad.CPLNDV = obeEntidad.CPLNDV
    objEntidad.TPSLPE = "P"
    objEntidad.FCJSPE = HelpClass.CtypeDate(Now)

    If Me.txtImporteSolEfectivo.Text.Trim = "" Then
      objEntidad.ISLPES = 0
    Else
      objEntidad.ISLPES = Me.txtImporteSolEfectivo.Text
    End If
    If txtMotivoGiro.Text.Length >= 30 Then
      objEntidad.MOTIVO = txtMotivoGiro.Text.Substring(0, 30)
    Else
      objEntidad.MOTIVO = txtMotivoGiro.Text
    End If
    objEntidad.NPLCUN = Me.cmbPlaca.Text
    objEntidad.NORDSR = Me.txtNroOperacion.Text
    objEntidad.MTVGRO = txtComentario.Text
    objEntidad.CODDES = cmbObrero.SelectedValue
    objEntidad.SESTRG = "A"
    objEntidad.DATCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
    objEntidad.USRCRT = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CBRCNT = Me.txtNroBrevete.Text
    objEntidad.NOPRCN = Me.txtNroOperacion.Text
    objEntidad = objLogic.Guardar_Pedido_Efectivo(objEntidad)
    If objEntidad.NMSLPE <> 0 Then
      HelpClass.MsgBox("El registro se guardó satisfactoriamente")
      txtNroSolEfectivo.Text = objEntidad.NMSLPE
      _NRSOL = objEntidad.NMSLPE
      Guardar_Solicitud_Efectivo_SAP(objEntidad.NMSLPE, 2)
      lbolEstadoGuardado = True
    Else
      HelpClass.MsgBox("Error al Guardar")
      Me.Cursor = Cursors.Default
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Cargar_Combos()
    Dim objEntidadTracto As New ENTIDADES.mantenimientos.TransportistaTracto
        'Try
        bolBuscar = False
        Dim objMedioTransporte As New NEGOCIO.MedioTransporte_BLL
        With Me.cmbMedioTransporte
            .DataSource = objMedioTransporte.Lista_Medio_Transporte()
            .ValueMember = "CTPMDT"
            .DisplayMember = "TTPMDT"
        End With
        bolBuscar = True
        cmbMedioTransporte_SelectionChangeCommitted(cmbMedioTransporte, Nothing)
        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub cargar_Obrero_operacion_Placa()
        'Try
        Dim objEntidad As New Hashtable
        Dim objLogical As New Obrero_BLL
        Dim listObrero As New List(Of Obrero)
        Me.cmbObrero.DataSource = Nothing

        If Me.txtNroOperacion.Text.Length > 0 And Me.cmbPlaca.Text <> Nothing Then
            objEntidad.Add("NOPRCN", Me.txtNroOperacion.Text)
            objEntidad.Add("NPLCTR", Me.cmbPlaca.Text)
            Me.cmbObrero.DataSource = Nothing
            With Me.cmbObrero
                Me.bolBuscar = False
                .DataSource = objLogical.Lista_Obreros_Operacion_Placa(objEntidad)
                Me.bolBuscar = True
                .ValueMember = "COBRR"
                .DisplayMember = "TNMBOB"
            End With
            cmbObrero_SelectionChangeCommitted(cmbObrero, Nothing)
        End If

        'Catch : End Try
  End Sub

  Private Sub ocultar_Controles(ByVal bolEstado As Boolean)
    txtNroSolEfectivo.Visible = bolEstado
    KryptonLabel19.Visible = bolEstado
    KryptonLabel24.Visible = bolEstado
    txtMotivoGiro.Visible = bolEstado
    KryptonLabel26.Visible = bolEstado
    txtComentario.Visible = bolEstado
    txtImporteSolEfectivo.Visible = bolEstado
    KryptonLabel22.Visible = bolEstado
    If Not bolEstado Then
      PanelImporte.Location = New Point(0, 170)
      Me.Size = New Size(620, 400)

    Else
      PanelImporte.Location = New Point(0, 236)
      Me.Size = New Size(620, 450)
    End If

  End Sub

  Private Function Validar_Datos() As Double
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
    If cmbObrero.SelectedValue = Nothing Then
      strError = strError & "* Código de conductor valido " & Chr(13)
    End If
    If Me.txtNroOperacion.Text = vbNullString Then
      strError = strError & "* Número de operación" & Chr(13)
    End If
    If cmbMedioTransporte.SelectedValue = -1 OrElse cmbMedioTransporte.SelectedValue = Nothing Then
      strError = strError & "* Medio de Transporte " & Chr(13)
    End If
    If txtImporteAVC.Text.Length = 0 OrElse Not IsNumeric(txtImporteAVC.Text) OrElse CType(txtImporteAVC.Text.Trim.Trim, Double) = 0 Then
      strError = strError & "* Importe Ruta AVC mayor que cero " & Chr(13)
    End If
    If Not Me.chkAvcRetorno.Checked Then
      If (txtAdelanto.Text.Trim.Length = 0) OrElse txtAdelanto.Text = "0" OrElse txtAdelanto.Text = "0.00" Then
        strError = strError & "* El monto de adelanto AVC  mayor que 0" & Chr(13)
      End If
    End If
    If ckbGenerarPedidoEfectivo.Checked Then
      If txtImporteSolEfectivo.Text.Trim.Length = 0 OrElse txtImporteSolEfectivo.Text = "0" Then
        strError = strError & "* El monto de importe solicitud pedido efectivo  mayor que 0" & Chr(13)
      Else
        If CType(txtImporteSolEfectivo.Text.Trim.Split(".").GetValue(0).ToString, Double).ToString.Length > 12 Then
          strError = strError & "* El monto de importe solicitud pedido efectivo  valido" & Chr(13)
        End If
      End If
    End If
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Information)
      Return False
      Exit Function
    End If
    Return True
  End Function

  Private Sub Imprimir_Solicitud_Efectivo()
        'Try
        Dim objParametro As New Hashtable
        Dim oDt As DataTable
        Dim oDs As New DataSet
        Dim objPrintForm As New PrintForm

        'Me.Cursor = Cursors.WaitCursor
        Dim objReporte As New rptGastosRuta
        Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL
        objParametro.Add("NCTAVC", txtNroAVC.Text)
        oDt = HelpClass.GetDataSetNative(objLogical.ReporteControlGastos(objParametro))
        oDt.TableName = "GastosRuta"
        oDs.Tables.Add(oDt.Copy)
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)
        '-- ACTUALIZAR ESTADO DE IMPRESIÓN
        Dim intResultado As Int32 = objLogical.Actualizar_Estado_Imprimir_AVC(txtNroAVC.Text, "A")
        Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '        Me.Cursor = Cursors.Default
        '        HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
        '    End Try

  End Sub

  Private Sub Imprimir_Reporte_Pedido_Efectivo()
        'Try
        Dim objParametro As New Hashtable
        Dim oDt As DataTable
        Dim oDs As New DataSet
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptSolicitudEfectivo
        Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL

        'Me.Cursor = Cursors.WaitCursor
        If Me.ckbGenerarPedidoEfectivo.Checked Then
            objParametro.Add("NCSLPE", txtNroSolEfectivo.Text)
            oDt = HelpClass.GetDataSetNative(objLogical.Reporte_Pedido_Efectivo(objParametro))
            oDt.TableName = "GastosRuta"
            oDs.Tables.Add(oDt.Copy)
            objReporte.SetDataSource(oDs)
            objPrintForm.ShowForm(objReporte, Me)
            Dim intResultado As Int32 = objLogical.Actualizar_Estado_Imprimir_AVC(txtNroSolEfectivo.Text, "P")
        End If
        'Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '        Me.Cursor = Cursors.Default
        '        HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
        '    End Try


  End Sub

  Private Sub Cargar_Grilla_Detalle_GastoRuta()
    Dim Objeto_Logica As New NEGOCIO.AVC_BLL

    Me.Cursor = Cursors.WaitCursor

    Cargar_Avc()
    Cargar_Pedido_Efectivo()
    Me.txtNroOperacion.Text = obeEntidad.NOPRCN
    Placa_X_Operacion()
    cargar_Obrero_operacion_Placa()
    CargarObrero()
    Me.cmbPlaca.Text = obeEntidad.NPLCUN
    Me.txtOrigen.Text = obeEntidad.RUTA
    Me.txtNroBrevete.Text = obeEntidad.CBRCNT


    Me.Cursor = Cursors.Default
  End Sub

  Private Sub CargarObrero()
    Dim Objeto_Logica As New NEGOCIO.Gastos_Ruta_BLL
    Dim objListEntidad As New Obrero
    Dim objetoParametro As New Hashtable

    objetoParametro.Add("PSCBRCNT", obeEntidad.CBRCNT)
    objListEntidad = Objeto_Logica.Obtener_Datos_Obrero(objetoParametro)
    lstrCuentaSap = objListEntidad.CMTCDS
    Me.cmbObrero.SelectedValue = objListEntidad.COBRR
  End Sub


  Private Sub Cargar_Avc()
    Dim Objeto_Logica As New NEGOCIO.AVC_BLL
    txtNroAVC.Text = Objeto_Logica.Generar_Codigo()
    Calcular_Importe_Ruta()
  End Sub

  Private Sub Cargar_Pedido_Efectivo()
    Dim Objeto_Logica As New NEGOCIO.PedidoEfectivo_BLL

    Me.txtNroSolEfectivo.Text = Objeto_Logica.Generar_Codigo(obeEntidad.CCMPN, obeEntidad.CPLNDV)
    txtMotivoGiro.Text = obeEntidad.RUTA
  End Sub

#End Region

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click
        Try
            Dim objBuscarOperacion As New frmBuscarOperacion
            With objBuscarOperacion
                .CCMPN = mCCMPN
                .CDVSN = mCDVSN
                .CPLNDV = mCPLNDV
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtNroOperacion.Text = .NOPRCN_1
                    Placa_X_Operacion()
                    cargar_Obrero_operacion_Placa()
                    Calcular_Importe_Ruta()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

  Private Sub Placa_X_Operacion()
    Dim objEntidad As New Hashtable
    Dim objLisEntidad As New List(Of SolicitudEfectivoSAP)
    Dim objLogical As New SolicitudPedidoEfectivo_BLL()

    cmbPlaca.DataSource = Nothing
    objEntidad.Add("NOPRCN", Me.txtNroOperacion.Text)
    objLisEntidad = objLogical.Obtener_Placa_X_Operacion(objEntidad)
    If objLisEntidad.Count > 0 Then
      bolBuscar = False
      With cmbPlaca
        .DataSource = objLisEntidad
        .DisplayMember = "NPLCUN"
        .ValueMember = "NORINS"
                bolBuscar = True

        txtOrigen.Text = objLisEntidad.Item(0).RUTA
        Me.txtMotivoGiro.Text = objLisEntidad.Item(0).RUTA
        obeEntidad.CLCLOR = objLisEntidad(0).CLCLOR
        obeEntidad.CLCLDS = objLisEntidad(0).CLCLDS
        obeEntidad.NORSRT = objLisEntidad(0).NORSRT
        obeEntidad.CCLNT = objLisEntidad(0).CCLNT
            End With

            bolBuscar = True
            cmbPlaca_SelectionChangeCommitted(cmbPlaca, Nothing)

    Else
      txtOrigen.Text = ""
      Me.txtMotivoGiro.Text = ""
      obeEntidad.CLCLOR = 0
      obeEntidad.CLCLDS = 0
      obeEntidad.NORSRT = 0
      obeEntidad.CCLNT = 0
    End If
  End Sub

    'Private Sub cmbPlaca_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaca.SelectedValueChanged
    '      Try
    '          If Me.bolBuscar Then
    '              cargar_Obrero_operacion_Placa()
    '          End If
    '      Catch ex As Exception
    '          MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '      End Try

    'End Sub

    'Private Sub cmbObrero_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObrero.SelectedValueChanged
    '      Try
    '          If Me.bolBuscar Then
    '              Obtener_brevete()
    '          End If
    '      Catch ex As Exception
    '          MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '      End Try

    'End Sub

  Private Sub Obtener_brevete()
        'Try
        Dim objEntidad As New Chofer()
        Dim objNegocio As New Chofer_BLL
        objEntidad.CODSAP = cmbObrero.SelectedValue
        objEntidad.CCMPN = Me.obeEntidad.CCMPN
        objEntidad = objNegocio.Obtener_brevete(objEntidad)
        Me.txtNroBrevete.Text = objEntidad.CBRCNT
        Calcular_Importe_Ruta()
        'Catch ex As Exception
        '    End Try

  End Sub

    Private Sub txtNroOperacion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOperacion.Leave
        Try
            Me.Cursor = Cursors.WaitCursor
            Placa_X_Operacion()
            cargar_Obrero_operacion_Placa()
            Calcular_Importe_Ruta()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  Private Sub txtNroOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOperacion.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
    If e.KeyChar = Chr(13) Then
      Me.Cursor = Cursors.WaitCursor
      Placa_X_Operacion()
      cargar_Obrero_operacion_Placa()
      Calcular_Importe_Ruta()
      Me.Cursor = Cursors.Default
    End If
  End Sub


    Private Sub btnRutas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRutas.Click
        Try
            Dim objfrmCambioRuta As New frmCambioRuta
            objfrmCambioRuta.COMPANIA = "EZ"
            If objfrmCambioRuta.ShowDialog = Windows.Forms.DialogResult.OK Then
                obeEntidad.CLCLOR = objfrmCambioRuta.CLCLOR
                obeEntidad.CLCLDS = objfrmCambioRuta.CLCLDS
                Me.txtOrigen.Text = objfrmCambioRuta.ORIGEN.Trim & " - " & objfrmCambioRuta.DESTINO.Trim
                Me.txtMotivoGiro.Text = objfrmCambioRuta.ORIGEN.Trim & " - " & objfrmCambioRuta.DESTINO.Trim
                Calcular_Importe_Ruta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

  Private Sub chkAvcRetorno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAvcRetorno.CheckedChanged

        Try
            If chkAvcRetorno.Checked Then
                txtAdelanto.Text = 0.0
            ElseIf bolBuscar Then
                Calcular_Importe_Ruta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
  End Sub


    Private Sub cmbObrero_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbObrero.SelectionChangeCommitted
        Try
            Obtener_brevete()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbMedioTransporte_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMedioTransporte.SelectionChangeCommitted
        Try
            Calcular_Importe_Ruta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPlaca.SelectionChangeCommitted
        Try
            cargar_Obrero_operacion_Placa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
