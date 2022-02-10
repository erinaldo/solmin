Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmInformacionSolicitud

#Region "Atributos"
  Private boolEstadoSalida As Boolean = False
  Private strSolicitud As String = ""
  Private controlInformacion As Control_InformacionSolicitud
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Int16 = 0
  Private _TipoOperacion As Int16 = 0
  Private _OPCION As Int16 = 0
  Private _CCLNT As Int32 = 0
  Private _NMOPMM As Int64 = 0
  Private _NMOPRP As Int64 = 0
  Private _QSLCIT As Int32 = 0
  Private _NORSRT As Int64 = 0
  Private _NroUnidadesAsignadas As Int64 = 0
  Private _NPLCUN As String = ""
  Private _NRUCTR As Int64 = 0
  Private _LocalidadOrigen As Int32 = 0
  Private _LocalidadDestino As Int32 = 0
  Private _DireccionOrigen As String = ""
  Private _DireccionDestino As String = ""
  Private _CantidadMercaderia As Double = 0
  Private _UnidadMedida As String = ""
  Private _FechaSolicitud As String = ""
  Private _CANTOP As Int32 = 0
  Private _CantidadSolicitada As Int32 = 0
  Private _CTPOVJ As String = "E"
#End Region

#Region "Properties"

  Public WriteOnly Property LocalidadOrigen() As Int32
    Set(ByVal value As Int32)
      _LocalidadOrigen = value
    End Set
  End Property

  Public WriteOnly Property LocalidadDestino() As Int32
    Set(ByVal value As Int32)
      _LocalidadDestino = value
    End Set
  End Property

  Public WriteOnly Property DireccionOrigen() As String
    Set(ByVal value As String)
      _DireccionOrigen = value
    End Set
  End Property

  Public WriteOnly Property DireccionDestino() As String
    Set(ByVal value As String)
      _DireccionDestino = value
    End Set
  End Property

  Public WriteOnly Property CantidadMercaderia() As Double
    Set(ByVal value As Double)
      _CantidadMercaderia = value
    End Set
  End Property

  Public WriteOnly Property UnidadMedida() As String
    Set(ByVal value As String)
      _UnidadMedida = value
    End Set
  End Property

  Public WriteOnly Property FechaSolicitud() As String
    Set(ByVal value As String)
      _FechaSolicitud = value
    End Set
  End Property

  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Int16
    Set(ByVal value As Int16)
      _CPLNDV = value
    End Set
  End Property

  Public WriteOnly Property TipoOperacion() As Int16
    Set(ByVal value As Int16)
      _TipoOperacion = value
    End Set
  End Property

  Public WriteOnly Property Cliente() As Int32
    Set(ByVal value As Int32)
      _CCLNT = value
    End Set
  End Property

  Public WriteOnly Property NMOPMM() As Int64
    Set(ByVal value As Int64)
      _NMOPMM = value
    End Set
  End Property

  Public WriteOnly Property NMOPRP() As Int64
    Set(ByVal value As Int64)
      _NMOPRP = value
    End Set
  End Property

  Public WriteOnly Property QSLCIT() As Int32
    Set(ByVal value As Int32)
      _QSLCIT = value
    End Set
  End Property

  Public WriteOnly Property NORSRT() As Int64
    Set(ByVal value As Int64)
      _NORSRT = value
    End Set
  End Property

  Public WriteOnly Property CANTOP() As Int32
    Set(ByVal value As Int32)
      _CANTOP = value
    End Set
  End Property

  Public ReadOnly Property UnidadesAsignadas() As Int64
    Get
      Return _NroUnidadesAsignadas
    End Get
  End Property

  Public WriteOnly Property NPLCUN() As String
    Set(ByVal value As String)
      _NPLCUN = value
    End Set
  End Property

  Public WriteOnly Property NRUCTR() As Int64
    Set(ByVal value As Int64)
      _NRUCTR = value
    End Set
  End Property

  Public WriteOnly Property OPCION() As Int16
    Set(ByVal value As Int16)
      _OPCION = value
    End Set
  End Property

#End Region

#Region "Métodos y Funciones"

    Public Sub New(ByVal pstrSolicitud As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        strSolicitud = pstrSolicitud
    End Sub

  Private Sub Nuevo_Registro()
    'Procedimiento para registrar una nueva solicitud de transporte
    Dim objEntidad As New Solicitud_Transporte
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        'Try
        objEntidad.NCSOTR = "0"
        objEntidad.CCLNT = controlInformacion.txtCliente.pCodigo
        objEntidad.CMRCDR = controlInformacion.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.NORSRT = IIf(controlInformacion.txtOrdenServicio.Text = "", 0, controlInformacion.txtOrdenServicio.Text)
        objEntidad.FECOST = HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value)
        'objEntidad.CLCLOR = controlInformacion.ctlLocalidadOrigen.Codigo
        objEntidad.CLCLOR = Val("" & controlInformacion.txt_localidad_origen.Tag)
        objEntidad.TDRCOR = controlInformacion.txtDireccionLocalidadCarga.Text
        'objEntidad.CLCLDS = controlInformacion.ctlLocalidadDestino.Codigo
        objEntidad.CLCLDS = Val("" & controlInformacion.txt_localidad_destino.Tag)
        objEntidad.TDRENT = controlInformacion.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = controlInformacion.txtUnidadMedida.Codigo
        objEntidad.CUNDMD = controlInformacion.txtUnidadMed.Text.Trim
        objEntidad.QSLCIT = IIf(controlInformacion.txtCantidadSolicitada.Text = "", "0", controlInformacion.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(controlInformacion.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(controlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(controlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(controlInformacion.txtCantidadMercaderia.Text = "", "0", controlInformacion.txtCantidadMercaderia.Text)
        objEntidad.SESTRG = "A"
        objEntidad.CTPOSR = controlInformacion.txtTipoServicio.Codigo
        objEntidad.CUNDVH = controlInformacion.ctlTipoVehiculo.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = controlInformacion.txtObservaciones.Text
        objEntidad.CCMPN = Me._CCMPN
        objEntidad.CDVSN = Me._CDVSN
        objEntidad.CPLNDV = Me._CPLNDV
        objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.NMOPMM = Me._NMOPMM
        objEntidad.NMOPRP = Me._NMOPRP
        objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad.CTPOVJ = Me._CTPOVJ

        Dim msgReg As String = ""
        objEntidad = objSolicitudTransporte.Registrar_Solicitud_Transporte(objEntidad, msgReg)
        If msgReg.Length > 0 Then
            MessageBox.Show(msgReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        HelpClass.MsgBox("Se Registró Satisfactoriamente")
        boolEstadoSalida = True
        Me.Limpiar_Controles()
        'If objEntidad.NCSOTR = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    HelpClass.MsgBox("Se Registró Satisfactoriamente")
        '    boolEstadoSalida = True
        '    Me.Limpiar_Controles()
        'End If
        'Catch : End Try

  End Sub

  Private Sub Modificar_Registro()
    'Procedimiento para registrar una nueva solicitud de transporte
    Dim objEntidad As New Solicitud_Transporte
    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        'Try
        objEntidad.NCSOTR = controlInformacion.Codigo.Text
        objEntidad.NORSRT = IIf(controlInformacion.txtOrdenServicio.Text = "", 0, controlInformacion.txtOrdenServicio.Text)
        objEntidad.CCLNT = controlInformacion.txtCliente.pCodigo
        objEntidad.CMRCDR = controlInformacion.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.FECOST = HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value)
        'objEntidad.CLCLOR = controlInformacion.ctlLocalidadOrigen.Codigo
        objEntidad.CLCLOR = Val("" & controlInformacion.txt_localidad_origen.Tag)
        objEntidad.TDRCOR = controlInformacion.txtDireccionLocalidadCarga.Text
        'objEntidad.CLCLDS = controlInformacion.ctlLocalidadDestino.Codigo
        objEntidad.CLCLDS = Val("" & controlInformacion.txt_localidad_destino.Tag)
        objEntidad.TDRENT = controlInformacion.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = controlInformacion.txtUnidadMedida.Codigo
        objEntidad.CUNDMD = controlInformacion.txtUnidadMed.Text.Trim
        objEntidad.QSLCIT = IIf(controlInformacion.txtCantidadSolicitada.Text = "", "0", controlInformacion.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(controlInformacion.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(controlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(controlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(controlInformacion.txtCantidadMercaderia.Text = "", "0", controlInformacion.txtCantidadMercaderia.Text)
        objEntidad.CTPOSR = controlInformacion.txtTipoServicio.Codigo
        objEntidad.CUNDVH = controlInformacion.ctlTipoVehiculo.Codigo
        objEntidad.CCMPN = Me._CCMPN
        objEntidad.CDVSN = Me._CDVSN
        objEntidad.CPLNDV = Me._CPLNDV
        objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.TOBS = controlInformacion.txtObservaciones.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte(objEntidad)
        If objEntidad.NCSOTR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Se Modificó Satisfactoriamente")
        End If
        'Catch : End Try
  End Sub

  Private Sub Limpiar_Controles()
    'controlInformacion.Codigo.Text = 0
    'controlInformacion.txtCliente.pClear()
    controlInformacion.dtpFechaSolicitud.Value = Date.Now.Date
        'controlInformacion.ctlLocalidadOrigen.Limpiar()
        controlInformacion.txt_localidad_origen.Text = ""
        controlInformacion.txt_localidad_origen.Tag = "0"
    controlInformacion.txtDireccionLocalidadCarga.Text = ""
        'controlInformacion.ctlLocalidadDestino.Limpiar()
        controlInformacion.txt_localidad_destino.Text = ""
        controlInformacion.txt_localidad_destino.Tag = "0"
    controlInformacion.txtDireccionLocalidadEntrega.Text = ""
    controlInformacion.txtCantidadSolicitada.Text = ""
    controlInformacion.txtTipoServicio.Limpiar()
    controlInformacion.ctlTipoVehiculo.Limpiar()
    controlInformacion.ctbMercaderias.Limpiar()
        'controlInformacion.txtUnidadMedida.Limpiar()
        controlInformacion.txtUnidadMed.Text = ""

    controlInformacion.txtCantidadMercaderia.Text = ""
    controlInformacion.txtObservaciones.Text = ""
    controlInformacion.txtHoraCarga.Text = "00:00:00"
    controlInformacion.txtHoraEntrega.Text = "00:00:00"
    controlInformacion.txtFechaSolicitud.Text = ""
    controlInformacion.txtFechaEntrega.Text = ""
    controlInformacion.txtFechaCarga.Text = ""
    'controlInformacion.dtgRecursosAsignados.Rows.Clear()
    controlInformacion.txtOrdenServicio.Text = ""
  End Sub

  Private Function validar_inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

        'If controlInformacion.ctlLocalidadOrigen.NoHayCodigo = True Then
        If Val("" & controlInformacion.txt_localidad_origen.Tag) = 0 Then
            lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        End If
        If controlInformacion.txtDireccionLocalidadCarga.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE CARGA " & Chr(13)
        End If
        If controlInformacion.ctbMercaderias.NoHayCodigo = True Then
            lstr_validacion += "* MERCADERIA DE TRANSLADO " & Chr(13)
        End If
        'If controlInformacion.ctlLocalidadDestino.NoHayCodigo = True Then
        If Val("" & controlInformacion.txt_localidad_destino.Tag) Then
            lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If controlInformacion.txtDireccionLocalidadEntrega.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If controlInformacion.txtOrdenServicio.Text = "" Then
            lstr_validacion += "* ORDEN DE SERVICIO" & Chr(13)
        End If
        If controlInformacion.txtCantidadSolicitada.Text = "" Or IsNumeric(controlInformacion.txtCantidadSolicitada.Text) = False Then
            lstr_validacion += "* CANTIDAD DE VEHICULOS" & Chr(13)
        End If
        If controlInformacion.txtTipoServicio.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE SERVICIO" & Chr(13)
        End If
        If controlInformacion.ctlTipoVehiculo.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
        End If
        If controlInformacion.txtUnidadMed.Text = "" Then
            'If controlInformacion.txtUnidadMedida.NoHayCodigo = True Then
            lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
  End Function

  Private Function Validar_Recursos_Asignados(ByVal lint_indice As Integer) As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    'Evaluando la Asignación: Tracto, Acoplado y Conductor
    If Me.controlInformacion.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value.ToString = "" Then
      lstr_validacion += "* TRACTO" & Chr(13)
    End If
    If Me.controlInformacion.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value.ToString = "" Then
      lstr_validacion += "* CONDUCTOR" & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

#End Region

#Region "Eventos"

  Private Sub frmInformacionSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    controlInformacion = New Control_InformacionSolicitud()
    controlInformacion.CCMPN = Me._CCMPN
    controlInformacion.pCDVSN = Me._CDVSN
    controlInformacion.pCPLNDV = Me._CPLNDV
    controlInformacion.NCSOTR_1 = strSolicitud
    controlInformacion.TipoOperacion = _TipoOperacion
    controlInformacion.OPCION = _OPCION

    Me.KryptonGroup1.Panel.Controls.Add(controlInformacion)
    'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    ActivarEstadoEnabled(True)
    Select Case _TipoOperacion
      Case 0
        _CantidadSolicitada = CType(controlInformacion.txtCantidadSolicitada.Text, Int32)
        Me.btnAsignarUnidad.Visible = False
        Me.btnConfirmarAtencion.Visible = False
        Me.btnAgregarGuiaTransporte.Visible = False
      Case 1
        _CantidadSolicitada = CType(controlInformacion.txtCantidadSolicitada.Text, Int32)
        Me.btnAsignarUnidad.Visible = False
        Me.btnConfirmarAtencion.Visible = False
        Me.btnAgregarGuiaTransporte.Visible = False
        Me.controlInformacion.dtpFechaSolicitud.Enabled = False
        Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
      Case 2
        Me.btnAsignarUnidad.Visible = False
        Me.btnConfirmarAtencion.Visible = False
        Me.btnAgregarGuiaTransporte.Visible = False
        Me.Limpiar_Controles()
        Me.controlInformacion.txtCliente.pCargar(_CCLNT)
        Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
      Case 3
        Me.btnModificar.Visible = False
        Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(0)
      Case 4
        Me.btnAsignarUnidad.Visible = False
        Me.btnConfirmarAtencion.Visible = False
        Me.btnAgregarGuiaTransporte.Visible = False
        Me.Limpiar_Controles()
        Me.controlInformacion.txtCliente.pCargar(_CCLNT)
        Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
        Me.controlInformacion.cboMedioTransporte.Enabled = False
        Me.controlInformacion.cboMedioTransporte.SelectedValue = 4

    End Select

    If Me._CANTOP > 0 Then
      ActivarEstadoEnabled(False)
      Me.controlInformacion.txtCantidadSolicitada.Enabled = True
      Me.controlInformacion.ctlTipoVehiculo.Enabled = True
    End If

    Select Case _TipoOperacion
      Case 0, 1, 2, 3
        Me.controlInformacion.txtCliente.Enabled = False
      Case 4
        Me.controlInformacion.txtCliente.Enabled = True
    End Select

  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    If boolEstadoSalida Then
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Else
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End If
  End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Select Case _TipoOperacion
                Case 0, 1
                    If Not Me.validar_inputs Then
                        If Me._CantidadSolicitada > CType(Me.controlInformacion.txtCantidadSolicitada.Text, Int32) And Me._CANTOP > 0 Then
                            HelpClass.MsgBox("Cantidad de Unidades Solicitadas menor a la nueva Cantidad Asignada", MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        Me.Modificar_Registro()
                    End If
                Case 2, 4
                    If Not Me.validar_inputs Then
                        Me.Nuevo_Registro()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub ActivarEstadoEnabled(ByVal lbool_Estado As Boolean)

    Select Case _TipoOperacion
      Case 0
        controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
        controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
        controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
        controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
        controlInformacion.txtObservaciones.Enabled = lbool_Estado
        controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
      Case Else
        controlInformacion.txtCliente.Enabled = lbool_Estado
        controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
        controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
        controlInformacion.txtTipoServicio.Enabled = lbool_Estado
        controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
        controlInformacion.ctbMercaderias.Enabled = lbool_Estado
                'controlInformacion.txtUnidadMedida.Enabled = lbool_Estado

        controlInformacion.txtCantidadMercaderia.Enabled = lbool_Estado
        controlInformacion.dtpFechaSolicitud.Enabled = lbool_Estado
        controlInformacion.dtpFechaInicioCarga.Enabled = lbool_Estado
        controlInformacion.dtpFinCarga.Enabled = lbool_Estado
        controlInformacion.txtObservaciones.Enabled = lbool_Estado
        controlInformacion.txtHoraCarga.Enabled = lbool_Estado
        controlInformacion.txtHoraEntrega.Enabled = lbool_Estado
        controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
        controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
        'controlInformacion.btnNuevoOS.Enabled = lbool_Estado
        controlInformacion.btnLimpiarOS.Enabled = lbool_Estado
        controlInformacion.cmbTipoSolicitud.Enabled = lbool_Estado
        controlInformacion.cboMedioTransporte.Enabled = lbool_Estado
    End Select
    'If _TipoOperacion = 0 Then
    'Else
    'End If
  End Sub

  Private Sub btnAsignarUnidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsignarUnidad.Click
    If Me._QSLCIT = Me.controlInformacion.dtgRecursosAsignados.RowCount Then
      HelpClass.MsgBox("Unidades Asignadas Completas", MessageBoxIcon.Information)
      Exit Sub
    End If
    Try
            'Dim frm_frmAsignacionManual As New frmAsignacionManual(False)
            Dim frm_frmAsignacionManual As New frmAsignacionManual()
      With frm_frmAsignacionManual
        .obj_Entidad.NCSOTR = Me.strSolicitud
        .obj_Entidad.NCRRSR = 1
        .obj_Entidad.NORSRT = Me._NORSRT
        .obj_Entidad.CCLNT = Me._CCLNT
        .obj_Entidad.CCMPN = Me._CCMPN
        .obj_Entidad.CDVSN = Me._CDVSN
        .obj_Entidad.CPLNDV = Me._CPLNDV
        .CCMPN = Me._CCMPN
        .CDVSN = Me._CDVSN
        .CPLNDV = Me._CPLNDV
        If Me._NPLCUN <> "" And Me._NRUCTR <> 0 Then
          Dim Transportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
          Dim Tracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
          Transportista.pCCMPN_Compania = Me._CCMPN
          Transportista.pNRUCTR_RucTransportista = Me._NRUCTR
          .cboTransportista.pCargar(Transportista)
          Tracto.pCCMPN_Compania = Me._CCMPN
          Tracto.pCDVSN_Division = Me._CDVSN
          Tracto.pCPLNDV_Planta = Me._CPLNDV
          Tracto.pNRUCTR_RucTransportista = Me._NRUCTR
          Tracto.pNPLCUN_NroPlacaUnidad = Me._NPLCUN
          .cboTracto.pCargar(Tracto)
          .cboTransportista.Enabled = False
          .cboTransportista.Enabled = False
        End If
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        HelpClass.MsgBox("Se Asignó Satisfactoriamente")
        Me._NroUnidadesAsignadas = _NroUnidadesAsignadas + 1
        Me.controlInformacion.Lista_Unidades_Asignadas(strSolicitud)
        boolEstadoSalida = True
      End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub btnConfirmarAtencion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmarAtencion.Click
    Dim lint_indice As Integer = Me.controlInformacion.dtgRecursosAsignados.CurrentCellAddress.Y
    Dim frm_frmServicioAlmacen As New frmServicioAlmacen
    If Me.controlInformacion.dtgRecursosAsignados.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
    If Me.controlInformacion.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
    If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
    If Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value = 0 Then
      HelpClass.MsgBox("No tiene una Operación asignada")
      Exit Sub
    End If
    If Me.controlInformacion.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value <> 0 Then
      HelpClass.MsgBox("Ya tiene una Guía de Transportista")
      Exit Sub
    End If
    frm_frmServicioAlmacen.IsMdiContainer = True
    Try
      With frm_frmServicioAlmacen
        .txtFechaSolicitud.Text = Me._FechaSolicitud
        .txtFechaAsignacion.Text = Me.controlInformacion.dtgRecursosAsignados.Item("FASGTR", lint_indice).Value
        .Tag = Me.controlInformacion.dtgRecursosAsignados.Item(6, lint_indice).Value
        ._NOPRCN = Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        ._NCSOTR = Me.controlInformacion.dtgRecursosAsignados.Item("NCSOTR", lint_indice).Value
        ._NCRRSR = Me.controlInformacion.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
        ._NPLNJT = Me.controlInformacion.dtgRecursosAsignados.Item("NPLNJT", lint_indice).Value
        ._NCRRPL = Me.controlInformacion.dtgRecursosAsignados.Item("NCRRPL", lint_indice).Value
        ._CCMPN = Me._CCMPN
        .ObjetoServicio_Entidad_Guia.CLCLOR = Me._LocalidadOrigen
        .ObjetoServicio_Entidad_Guia.CLCLDS = Me._LocalidadDestino
        .ObjetoServicio_Entidad_Guia.TDIROR = Me._DireccionOrigen
        .ObjetoServicio_Entidad_Guia.TDIRDS = Me._DireccionDestino
        .ObjetoServicio_Entidad_Guia.QMRCMC = Me._CantidadMercaderia
        .ObjetoServicio_Entidad_Guia.CUNDMD = Me._UnidadMedida
        .ObjetoServicio_Entidad_Guia.NRUCTR = Me.controlInformacion.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        .ObjetoServicio_Entidad_Guia.NPLCTR = Me.controlInformacion.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
        .ObjetoServicio_Entidad_Guia.NPLCAC = Me.controlInformacion.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
        .ObjetoServicio_Entidad_Guia.CBRCNT = Me.controlInformacion.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
        .ObjetoServicio_Entidad_Guia.CBRCND = Me.controlInformacion.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value

        Dim obj_Logica_Guia As New GuiaTransportista_BLL
        Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        obj_Entidad_Guia_Transporte.NOPRCN = ._NOPRCN
        obj_Entidad_Guia_Transporte.CCMPN = Me._CCMPN
        obj_Entidad_Guia_Transporte.NPLCTR = .ObjetoServicio_Entidad_Guia.NPLCTR
        obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
        .ObjetoServicio_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        .ObjetoServicio_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        .ObjetoServicio_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
        .ObjetoServicio_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        .ObjetoServicio_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        .ObjetoServicio_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        .ObjetoServicio_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        .ObjetoServicio_Entidad_Guia.TDRCNS = .ObjetoServicio_Entidad_Guia.TDIRDS
        .ObjetoServicio_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        .ObjetoServicio_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        .ObjetoServicio_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        .ObjetoServicio_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
        .ObjetoServicio_Entidad_Guia.CCMPN = Me._CCMPN
        .ObjetoServicio_Entidad_Guia.CDVSN = Me._CDVSN
        .ObjetoServicio_Entidad_Guia.CPLNDV = Me._CPLNDV
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Me.controlInformacion.Lista_Unidades_Asignadas(Me.strSolicitud)
        End If
      End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

#End Region

  Private Sub btnAgregarGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGuiaTransporte.Click
    Dim lint_indice As Integer = Me.controlInformacion.dtgRecursosAsignados.CurrentCellAddress.Y
    If Me.controlInformacion.dtgRecursosAsignados.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
    If Me.controlInformacion.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
    If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
    If Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value = 0 Then
      HelpClass.MsgBox("No tiene una Operación asignada")
      Exit Sub
    End If
    If Me.controlInformacion.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value = 0 Then
      HelpClass.MsgBox("No tiene Guía Transporte Principal", MessageBoxIcon.Information)
      Exit Sub
    End If
        'Dim ObjetoServicio_Entidad_Guia As New GuiaTransportista

        'Try
        'With ObjetoServicio_Entidad_Guia
        '.txtFechaSolicitud.Text = Me._FechaSolicitud
        '.txtFechaAsignacion.Text = Me.controlInformacion.dtgRecursosAsignados.Item("FASGTR", lint_indice).Value
        '.Tag = Me.controlInformacion.dtgRecursosAsignados.Item(6, lint_indice).Value
        '._NOPRCN = Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        '._NCSOTR = Me.controlInformacion.dtgRecursosAsignados.Item("NCSOTR", lint_indice).Value
        '._NCRRSR = Me.controlInformacion.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
        '._NPLNJT = Me.controlInformacion.dtgRecursosAsignados.Item("NPLNJT", lint_indice).Value
        '._NCRRPL = Me.controlInformacion.dtgRecursosAsignados.Item("NCRRPL", lint_indice).Value
        '._CCMPN = Me._CCMPN


        '.CLCLOR = Me._LocalidadOrigen
        '.CLCLDS = Me._LocalidadDestino
        '.TDIROR = Me._DireccionOrigen
        '.TDIRDS = Me._DireccionDestino
        '.QMRCMC = Me._CantidadMercaderia
        '.CUNDMD = Me._UnidadMedida
        '.NRUCTR = Me.controlInformacion.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        '.NPLCTR = Me.controlInformacion.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
        '.NPLCAC = Me.controlInformacion.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
        '.CBRCNT = Me.controlInformacion.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
        '.CBRCND = Me.controlInformacion.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value

        '.NPLNMT = Me.controlInformacion.dtgRecursosAsignados.Item("NPLNMT", lint_indice).Value
        '.TCMTRT = Me.controlInformacion.dtgRecursosAsignados.Item("TCMTRT", lint_indice).Value

        '.CPLNDV_DESC = Me.controlInformacion.dtgRecursosAsignados.Item("CPLNDV_DESC", lint_indice).Value
        '.CTRMNC = Me.controlInformacion.dtgRecursosAsignados.Item("CTRMNC", lint_indice).Value


        '.CUNDMD_DESC = Me.controlInformacion.dtgRecursosAsignados.Item("CUNDMD_DESC", lint_indice).Value

        'Dim obj_Logica_Guia As New GuiaTransportista_BLL
        'Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        'obj_Entidad_Guia_Transporte.NOPRCN = Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        'obj_Entidad_Guia_Transporte.CCMPN = Me._CCMPN
        'obj_Entidad_Guia_Transporte.NPLCTR = .NPLCTR
        'obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)
        '.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        '.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        '.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
        '.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        '.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        '.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        '.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        '.TDRCNS = .TDIRDS
        '.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        '.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        '.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        '.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
        '.CCMPN = Me._CCMPN
        '.CDVSN = Me._CDVSN
        '.CPLNDV = Me._CPLNDV
        '.CMNFLTDESC = obj_Entidad_Guia_Transporte.CMNFLTDESC
        ' Me.controlInformacion.Lista_Unidades_Asignadas(Me.strSolicitud)
        'End With

        Try
            Dim frm_GuiaTransportista As New frmGuiaTransportista
            With frm_GuiaTransportista
                .IsMdiContainer = True
                .AutoSize = True
                Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
                With Comp_Guia
                    .ESTADO = False
                    .Dock = DockStyle.Fill
                    .pCOMPANIA = Me._CCMPN
                    .pDIVISION = Me._CDVSN
                    .pPLANTA = Me._CPLNDV
                    .pNOPRCN = Me.controlInformacion.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
                    .pUSUARIO = MainModule.USUARIO
                    '.Guia_Transporte = ObjetoServicio_Entidad_Guia
                    .Tag = 0
                    .pNCSOTR = Me.controlInformacion.dtgRecursosAsignados.Item("NCSOTR", lint_indice).Value
                    .pNCRRSR = Me.controlInformacion.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
                   
                    .ChargeForm()
                End With
                .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
                .panelGuia.Controls.Add(Comp_Guia)
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Me.controlInformacion.Lista_Unidades_Asignadas(Me.strSolicitud)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

