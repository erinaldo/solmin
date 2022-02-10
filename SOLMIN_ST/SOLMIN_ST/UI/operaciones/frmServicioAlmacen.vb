Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmServicioAlmacen
  Private _estado As Boolean = False
  Public _NOPRCN As Double = 0
  Public _NCSOTR As String = ""
  Public _NCRRSR As String = ""
  Public _NPLNJT As String = ""
  Public _NCRRPL As String = ""
  Public _CCMPN As String = ""
  Public ObjetoServicio_Entidad_Guia As New GuiaTransportista
  Private lintEstado As Int32 = 0
  Private lintOperacion As Int32

  Public Property ProcesoEjecutar() As Int32
    Get
      Return lintOperacion
    End Get
    Set(ByVal value As Int32)
      lintOperacion = value
    End Set
  End Property

  Public Property Estado() As Int32
    Get
      Return lintEstado
    End Get
    Set(ByVal value As Int32)
      lintEstado = value
    End Set
  End Property

  Private Sub txtGuiaTransporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransporte.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Dim obj_Entidad As Detalle_Solicitud_Transporte
    Dim obj_Logica As Solicitud_Transporte_BLL
    Select Case lintOperacion
      Case 0
        If Validar() = True Then Exit Sub
        If Me.txtGuiaTransporte.TextLength = 0 Then Exit Sub
        If Verificación_Existencia_Guia_Transportista() = False Then Exit Sub
        Try
          obj_Entidad = New Detalle_Solicitud_Transporte
          obj_Logica = New Solicitud_Transporte_BLL
          obj_Entidad.NCSOTR = _NCSOTR
          obj_Entidad.NCRRSR = _NCRRSR
          obj_Entidad.NPLNJT = _NPLNJT
          obj_Entidad.NCRRPL = _NCRRPL
          obj_Entidad.NGUITR = Me.txtGuiaTransporte.Text
          obj_Entidad.FATALM = HelpClass.CtypeDate(Me.dtpFechaAtencion.Value)
          obj_Entidad.HATALM = HelpClass.ConvertHoraNumeric(Me.txtHoraAtencion.Text.Substring(0, 8))
          obj_Entidad.FSLALM = HelpClass.CtypeDate(Me.dtpFechaSalida.Value)
          obj_Entidad.HSLALM = HelpClass.ConvertHoraNumeric(Me.txtHoraSalida.Text.Substring(0, 8))
          obj_Entidad.CULUSA = MainModule.USUARIO
          obj_Entidad.FULTAC = HelpClass.TodayNumeric
          obj_Entidad.HULTAC = HelpClass.NowNumeric
                    obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
          obj_Entidad.CCMPN = Me._CCMPN
          obj_Entidad.NCSOTR = obj_Logica.Actualizar_Fechas_Servicio_Almacen(obj_Entidad).NCSOTR
          If obj_Entidad.NCSOTR <> "0" Then
            HelpClass.MsgBox("Se actualizo satisfactoriamente")
            Me.Tag = obj_Entidad.NGUITR
            Me.DialogResult = Windows.Forms.DialogResult.OK
          Else
            HelpClass.ErrorMsgBox()
          End If
        Catch : End Try
      Case 1
        Try
          obj_Entidad = New Detalle_Solicitud_Transporte
          obj_Logica = New Solicitud_Transporte_BLL
          obj_Entidad.NCSOTR = _NCSOTR
          obj_Entidad.NCRRSR = _NCRRSR
          obj_Entidad.FATALM = HelpClass.CtypeDate(Me.dtpFechaAtencion.Value)
          obj_Entidad.HATALM = HelpClass.ConvertHoraNumeric(Me.txtHoraAtencion.Text.Substring(0, 8))
          obj_Entidad.FSLALM = HelpClass.CtypeDate(Me.dtpFechaSalida.Value)
          obj_Entidad.HSLALM = HelpClass.ConvertHoraNumeric(Me.txtHoraSalida.Text.Substring(0, 8))
          obj_Entidad.CULUSA = MainModule.USUARIO
          obj_Entidad.FULTAC = HelpClass.TodayNumeric
          obj_Entidad.HULTAC = HelpClass.NowNumeric
                    obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
          obj_Entidad.CCMPN = Me._CCMPN

          If obj_Logica.Actualizar_Salida_Avion(obj_Entidad) <> 0 Then
            HelpClass.MsgBox("Se actualizo satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
          Else
            HelpClass.ErrorMsgBox()
          End If
        Catch : End Try
    End Select

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmServicioAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.dtpFechaAtencion.Value = Today.Date
    Me.dtpFechaSalida.Value = Today.Date
  End Sub

  Private Function Verificación_Existencia_Guia_Transportista() As Boolean
    Dim obj_Logica As New Solicitud_Transporte_BLL
    Dim obj_Entidad As New ClaseGeneral
    obj_Entidad.NRUCTR = Me.Tag.ToString
    obj_Entidad.NGUITR = Me.txtGuiaTransporte.Text
    obj_Entidad.CCMPN = Me._CCMPN
    obj_Entidad.NCSOTR = Me._NCSOTR
    obj_Entidad.NCRRSR = Me._NCRRSR

    obj_Entidad = obj_Logica.Verificar_Existencia_Guia_Transportista(obj_Entidad)

    'OJO REVISAR ESTO URGENTE
    '-----------------------
    If CType(obj_Entidad.NGUITR, Double) = 1 And CType(obj_Entidad.SESPLN, Integer) = -1 Then
      HelpClass.MsgBox("Existe esta Guía de Transportista; pero ya esta asignada a un Tracto")
      _estado = True
    End If
    If CType(obj_Entidad.NGUITR, Double) = 1 And CType(obj_Entidad.SESPLN, Integer) = 1 Then
      _estado = True
    End If
    If CType(obj_Entidad.NGUITR, Double) = -1 Then
      HelpClass.MsgBox("No, Existe esta Guía de Transportista")
      Me.txtGuiaTransporte.Text = ""
      _estado = False
    End If
    If obj_Entidad.NGUITR = 0 Then
      HelpClass.ErrorMsgBox()
      _estado = False
    End If
    Return _estado
  End Function

  Private Function Validar() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    If Not IsDate(Me.txtHoraAtencion.Text) Then
      lstr_validacion += "* ATENCION" & Chr(13)
    End If
    If Not IsDate(Me.txtHoraSalida.Text) Then
      lstr_validacion += "* SALIDA" & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR CORRECTAMENTE LA HORA:" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub txtGuiaTransporte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGuiaTransporte.KeyDown
    If Me.txtGuiaTransporte.TextLength = 0 Then
      Exit Sub
    End If
    If e.KeyCode = Keys.Enter Then Me.Verificación_Existencia_Guia_Transportista()
  End Sub

  Private Sub btnGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuiaTransporte.Click
    Dim frm_GuiaTransportista As New frmGuiaTransportista
    With frm_GuiaTransportista
      .IsMdiContainer = True
      .AutoSize = True
      Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
      With Comp_Guia
        .ESTADO = False
        .Dock = DockStyle.Fill
                .pCOMPANIA = Me.ObjetoServicio_Entidad_Guia.CCMPN
                .pDIVISION = Me.ObjetoServicio_Entidad_Guia.CDVSN
                .pPLANTA = Me.ObjetoServicio_Entidad_Guia.CPLNDV
                .pNOPRCN = Me._NOPRCN
                .pUSUARIO = MainModule.USUARIO
                '.Guia_Transporte = Me.ObjetoServicio_Entidad_Guia
        .Tag = 0
        .TipoViaje = 0
                .pNCSOTR = Me._NCSOTR
                .pNCRRSR = Me._NCRRSR
                '.objTable = Operacion_Guia_Transporte()
                '.MedioTransporte = lintEstado
        .ChargeForm()
      End With
      .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
            .panelGuia.Controls.Add(Comp_Guia)
            .ShowDialog()
            'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
            '  Me.txtGuiaTransporte.Text = IIf(Comp_Guia.Guia_Transporte.NGUIRM = -1, 0, Comp_Guia.Guia_Transporte.NGUIRM)
            'End If
    End With

  End Sub

  Private Function Operacion_Guia_Transporte() As DataTable
    Dim objRow As DataRow
    Dim objTable As New DataTable
    objTable.Columns.Add("TCMPCL", Type.GetType("System.String"))
    objTable.Columns.Add("NOPRCN", Type.GetType("System.Int64"))
    objTable.Columns.Add("CCMPN", Type.GetType("System.String"))
    objRow = objTable.NewRow
    objRow("TCMPCL") = ObjetoServicio_Entidad_Guia.TNMBRM '.Item("D_TCMPCL", intContador).Value
    objRow("NOPRCN") = Me._NOPRCN
    objRow("CCMPN") = Me.ObjetoServicio_Entidad_Guia.CCMPN
    objTable.Rows.Add(objRow)

    Return objTable
  End Function
End Class
