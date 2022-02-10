Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data

Public Class frmDetalleSolicitudTransporte_1

#Region "Variables"
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private _estado As Integer = 0
  Private _resultado As Boolean = False
  Private _indice As Integer = -1
  Private _eliminar As Integer = 0
  Public _obj_Entidad As New Detalle_Solicitud_Transporte
#End Region

#Region "Metodos y Funciones"

  Private Sub Alinear_Columnas_Grilla()
    For lint_contador As Integer = 0 To Me.dgDatosGeneral.ColumnCount - 1
      Me.dgDatosGeneral.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dgSolicitud.ColumnCount - 1
      Me.dgSolicitud.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.dgVehiculos.ColumnCount - 1
      Me.dgVehiculos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next

    'Alineando el orden de las Columnas
    Me.dgDatosGeneral.Columns.Item(0).DisplayIndex = 0
    Me.dgDatosGeneral.Columns.Item(3).DisplayIndex = 1
    Me.dgDatosGeneral.Columns.Item(4).DisplayIndex = 2
    Me.dgDatosGeneral.Columns.Item(9).DisplayIndex = 3
    Me.dgDatosGeneral.Columns.Item(11).DisplayIndex = 4
    Me.dgDatosGeneral.Columns.Item(13).DisplayIndex = 5
    Me.dgDatosGeneral.Columns.Item(15).DisplayIndex = 6
    Me.dgDatosGeneral.Columns.Item(22).DisplayIndex = 7
    Me.dgDatosGeneral.Columns.Item(18).DisplayIndex = 8
    Me.dgDatosGeneral.Columns.Item(19).DisplayIndex = 9
    Me.dgDatosGeneral.Columns.Item(20).DisplayIndex = 10
    Me.dgDatosGeneral.Columns.Item(21).DisplayIndex = 11
    Me.dgDatosGeneral.Columns.Item(5).DisplayIndex = 12
    Me.dgDatosGeneral.Columns.Item(6).DisplayIndex = 13

    Me.dgSolicitud.Columns.Item(0).DisplayIndex = 0
    Me.dgSolicitud.Columns.Item(1).DisplayIndex = 1
    Me.dgSolicitud.Columns.Item(2).DisplayIndex = 2
    Me.dgSolicitud.Columns.Item(3).DisplayIndex = 3
    Me.dgSolicitud.Columns.Item(10).DisplayIndex = 4
    Me.dgSolicitud.Columns.Item(4).DisplayIndex = 5
    Me.dgSolicitud.Columns.Item(5).DisplayIndex = 6
    Me.dgSolicitud.Columns.Item(6).DisplayIndex = 7
    Me.dgSolicitud.Columns.Item(7).DisplayIndex = 8
    Me.dgSolicitud.Columns.Item(8).DisplayIndex = 9
    Me.dgSolicitud.Columns.Item(9).DisplayIndex = 10

  End Sub

  Private Sub AccionCancelar()
    dgVehiculos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    For lint_Contador As Integer = 1 To 3
      Me.Limpiar_Controles(lint_Contador)
    Next
    For lint_Contador As Integer = 0 To Me.dgVehiculos.RowCount - 1
      If Me.dgVehiculos.CurrentRow.DefaultCellStyle.BackColor <> Color.YellowGreen Then Me.dgVehiculos.Item(0, lint_Contador).Value = True
    Next
  End Sub

  Private Sub Limpiar_Controles(ByVal lint_Caso As Integer)
    Select Case lint_Caso
      Case 0
        If Me.dgSolicitud.Rows.Count > 0 Then
          Me.dgSolicitud.CurrentRow.Selected = False
        End If
      Case 1
        If Me.dgVehiculos.Rows.Count > 0 Then
          Me.dgVehiculos.CurrentRow.Selected = False
        End If
      Case 2
      Case 3
        If Me.dgDatosGeneral.Rows.Count > 0 Then
          Me.dgDatosGeneral.CurrentRow.Selected = False
        End If
    End Select
  End Sub

  Private Sub Cargar_Combo()
    Dim obj_Logica_Carroceria As New TipoCarroceria_BLL
    Dim obj_Logica_Transporte As New Transportista_BLL
    Dim obj_Logica_Unidad As New NEGOCIO.UnidadMedida_BLL
    Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
    Dim obj_Logica_Mercaderia As New NEGOCIO.mantenimientos.MercaderiaTransportes_BLL
    Dim obj_Entidad_Mercaderia As New ENTIDADES.mantenimientos.MercaderiaTransportes
    Dim obj_Logica_Servicio As New NEGOCIO.mantenimientos.ServicioTransporte_BLL
    Dim obj_Entidad_Servicio As New ENTIDADES.mantenimientos.ServicioTransporte
    Try
      With ctbTipoCarroceria
        .DataSource = HelpClass.GetDataSetNative(obj_Logica_Carroceria.Listar_TipoCarroceria(_obj_Entidad.CCMPN))
        .KeyField = "CTPCRA"
        .ValueField = "TCMCRA"
        .DataBind()
      End With
      'With ctbTransportista
      '  .DataSource = HelpClass.GetDataSetNative(obj_Logica_Transporte.Listar_TransportistaCbo())
      '  .KeyField = "NRUCTR"
      '  .ValueField = "TCMTRT"
      '  .DataBind()
      'End With
      'Cargando los CodeTextBox del Display de Solicitud de Transporte
      With Me.ctlCliente
        .DataSource = CType(MainModule.gobj_TablasGeneralesdelSistema("CLIENTE"), DataTable).Copy()
        .KeyField = "CCLNT"
        .ValueField = "TCMPCL"
        .DataBind()
      End With
      obj_Entidad_Mercaderia.CCMPN = Me._obj_Entidad.CCMPN
      With Me.ctbMercaderias
        .DataSource = HelpClass.GetDataSetNative(obj_Logica_Mercaderia.Listar_MercaderiaTransportes(obj_Entidad_Mercaderia)) 'CType(MainModule.gobj_TablasGeneralesdelSistema("MERCADERIA"), DataTable).Copy()
        .KeyField = "CMRCDR"
        .ValueField = "TCMRCD"
        .DataBind()
      End With

      Dim objTipoCarroceria As New TipoCarroceria_BLL
      With Me.ctlTipoVehiculo
        .DataSource = HelpClass.GetDataSetNative(objTipoCarroceria.Listar_TipoCarroceria(_obj_Entidad.CCMPN))
        .KeyField = "CTPCRA"
        .ValueField = "TCMCRA"
        .DataBind()
      End With
      obj_Entidad_Servicio.CCMPN = Me._obj_Entidad.CCMPN
      With Me.txtTipoServicio
        .DataSource = HelpClass.GetDataSetNative(obj_Logica_Servicio.Listar_ServicioTransporte(obj_Entidad_Servicio)) 'CType(MainModule.gobj_TablasGeneralesdelSistema("SERVICIO"), DataTable).Copy()
        .KeyField = "CTPOSR"
        .ValueField = "TCMTPS"
        .DataBind()
      End With
      Dim objDt As DataTable
      objDt = obj_Logica_Localidad.Listar_Localidades_Combo(Me._obj_Entidad.CCMPN)
      With Me.ctlLocalidadOrigen
        .DataSource = objDt.Copy '(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        .KeyField = "CLCLD"
        .ValueField = "TCMLCL"
        .DataBind()
      End With

      With Me.ctlLocalidadDestino
        .DataSource = objDt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        .KeyField = "CLCLD"
        .ValueField = "TCMLCL"
        .DataBind()
      End With

      With Me.txtUnidadMedida
        .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(Me._obj_Entidad.CCMPN) 'CType(MainModule.gobj_TablasGeneralesdelSistema("UNIDAD"), DataTable)
        .KeyField = "CUNDMD"
        .ValueField = "TCMPUN"
        .DataBind()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ListarJuntaGeneral()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objParametro As New Hashtable
    Dim dwvrow As DataGridViewRow
    Me.dgDatosGeneral.Rows.Clear()
    objParametro.Add("PNNPLNJT", Me.txtNroJunta.Text.Trim)
    objParametro.Add("PNNCRRPL", Me.txtCorrelativoJunta.Text.Trim)
    objParametro.Add("PSCCMPN", _obj_Entidad.CCMPN)
    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_Logica.Listar_Detalle_Solicitud(objParametro)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.dgDatosGeneral)
      dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
      dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
      dwvrow.Cells(2).Value = obj_Entidad.CCLNT
      dwvrow.Cells(3).Value = obj_Entidad.TCMPCL
      dwvrow.Cells(4).Value = obj_Entidad.RUTA
      dwvrow.Cells(5).Value = obj_Entidad.FASGTR
      dwvrow.Cells(6).Value = obj_Entidad.HASGTR
      dwvrow.Cells(7).Value = obj_Entidad.NPLNJT
      dwvrow.Cells(8).Value = obj_Entidad.NCRRPL
      dwvrow.Cells(9).Value = obj_Entidad.NRUCTR
      dwvrow.Cells(11).Value = obj_Entidad.NPLCUN
      dwvrow.Cells(12).Value = obj_Entidad.TDETRA
      dwvrow.Cells(13).Value = obj_Entidad.NPLCAC
      dwvrow.Cells(15).Value = obj_Entidad.CBRCNT
      dwvrow.Cells(17).Value = obj_Entidad.ESTADO
      dwvrow.Cells(18).Value = obj_Entidad.NOPRCN
      dwvrow.Cells(19).Value = obj_Entidad.NPLNMT
      dwvrow.Cells(20).Value = obj_Entidad.NORINS
      dwvrow.Cells(22).Value = obj_Entidad.CBRCN2
      dwvrow.Cells(23).Value = obj_Entidad.GPSLAT
      dwvrow.Cells(24).Value = obj_Entidad.GPSLON
      dwvrow.Cells(25).Value = obj_Entidad.FECGPS
      dwvrow.Cells(26).Value = obj_Entidad.HORGPS
      dwvrow.Cells(27).Value = Lista.Images.Item(4)
      dwvrow.Cells(28).Value = obj_Entidad.SEGUIMIENTO

      If obj_Entidad.NORINS.Trim.ToString = "" OrElse obj_Entidad.NORINS <= 0 Then
        dwvrow.Cells(20).Style.ForeColor = Color.Blue
        dwvrow.Cells(20).Value = "Enviar SAP"
        dwvrow.Cells(20).ToolTipText = "Click para " & Chr(10) & "enviar Orden Interna al SAP"
      End If
      dwvrow.Cells(21).Value = Lista.Images.Item(0)
      Me.dgDatosGeneral.Rows.Add(dwvrow)
    Next
    Me.Limpiar_Controles(4)
  End Sub

  Private Sub ListarSolicitud()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objParamList As New List(Of String)
    Dim dwvrow As DataGridViewRow
    Dim intCantRow As Integer
    Dim dblCliente As String

    intCantRow = Me.dgSolicitud.Rows.Count
    objParamList.Add(Me.txtNroSolicitud.Text)
    If txtCliente.pCodigo = 0 Then
      dblCliente = ""
    Else
      dblCliente = txtCliente.pCodigo
    End If
    objParamList.Add(dblCliente)
    objParamList.Add("")
    objParamList.Add("P")
    objParamList.Add(_obj_Entidad.CCMPN)
    objParamList.Add(_obj_Entidad.CDVSN)
    objParamList.Add(_obj_Entidad.CPLNDV)

    Me.dgSolicitud.Rows.Clear()

    For Each obj_Entidad As Solicitud_Transporte In obj_Logica.Listar_Cliente_Solicitud(objParamList)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.dgSolicitud)
      dwvrow.Cells(0).Value = My.Resources.runprog
      dwvrow.Cells(1).Value = obj_Entidad.NCSOTR
      dwvrow.Cells(2).Value = obj_Entidad.CCLNT
      dwvrow.Cells(3).Value = obj_Entidad.TCMPCL
      dwvrow.Cells(4).Value = obj_Entidad.CUNDVH
      dwvrow.Cells(5).Value = obj_Entidad.CTPOSR
      dwvrow.Cells(6).Value = obj_Entidad.QSLCIT
      dwvrow.Cells(7).Value = obj_Entidad.QATNDR
      dwvrow.Cells(8).Value = obj_Entidad.CLCLDS
      dwvrow.Cells(9).Value = obj_Entidad.SESSLC
      dwvrow.Cells(10).Value = obj_Entidad.CLCLOR_CLCLDS

      If Me.checkFiltroAsignados.Checked = True Then
        If CType(obj_Entidad.QSLCIT, Double) > CType(obj_Entidad.QATNDR, Double) Then
          dwvrow.DefaultCellStyle.SelectionBackColor = Color.White
          dwvrow.DefaultCellStyle.SelectionForeColor = Color.Black
          Me.dgSolicitud.Rows.Add(dwvrow)
        End If
      Else
        If CType(obj_Entidad.QSLCIT, Double) = CType(obj_Entidad.QATNDR, Double) Then
          dwvrow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204) ' Color.FromArgb(227, 227, 197) ' Color.FromArgb(255, 255, 204)
          dwvrow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 204)
          dwvrow.DefaultCellStyle.SelectionForeColor = Color.Black
        End If
        If CType(obj_Entidad.QSLCIT, Double) < CType(obj_Entidad.QATNDR, Double) Then
          dwvrow.DefaultCellStyle.BackColor = Color.FromArgb(251, 47, 25)
          dwvrow.DefaultCellStyle.ForeColor = Color.White
          dwvrow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 47, 25)
          dwvrow.DefaultCellStyle.SelectionForeColor = Color.White
        End If
        If CType(obj_Entidad.QSLCIT, Double) > CType(obj_Entidad.QATNDR, Double) Then
          dwvrow.DefaultCellStyle.BackColor = Color.White
          dwvrow.DefaultCellStyle.SelectionBackColor = Color.White
          dwvrow.DefaultCellStyle.SelectionForeColor = Color.Black
        End If
        Me.dgSolicitud.Rows.Add(dwvrow)
      End If
    Next

    If Me.dgSolicitud.RowCount > 0 Then
      If _indice = -1 Then
        SeleccionarSolicitud(0)
      Else
        If intCantRow = Me.dgSolicitud.Rows.Count Then
          Me.dgSolicitud.Rows(_indice).Selected = True
          Me.dgSolicitud.Rows(_indice).Cells(0).Value = My.Resources.button_ok1
        Else
          SeleccionarSolicitud(0)
        End If
      End If
    End If
    Me.Limpiar_Controles(1)
  End Sub

  Private Sub ListarVehiculo()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objEntidad As New Detalle_Solicitud_Transporte
    Dim dwvrow As DataGridViewRow
    objEntidad.NPLNJT = Me.txtNroJunta.Text
    objEntidad.NCRRPL = Me.txtCorrelativoJunta.Text
    objEntidad.NPLCUN = IIf(Me.txtVehiculo.Text.Trim.Length = 6, Me.txtVehiculo.Text, "")
    objEntidad.CTPCRA = Me.ctbTipoCarroceria.Codigo.Trim
    objEntidad.NRUCTR = Me.ctbTransportista.pRucTransportista
    objEntidad.CCMPN = _obj_Entidad.CCMPN
    objEntidad.CDVSN = _obj_Entidad.CDVSN
    objEntidad.CPLNDV = _obj_Entidad.CPLNDV

    Me.dgVehiculos.Rows.Clear()
    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_Logica.Listar_Vehiculo_Solicitud(objEntidad)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.dgVehiculos)
      dwvrow.Cells(1).Value = obj_Entidad.NPLCUN
      dwvrow.Cells(2).Value = obj_Entidad.CTPCRA
      dwvrow.Cells(3).Value = obj_Entidad.TCMCRA
      dwvrow.Cells(4).Value = obj_Entidad.NRUCTR
      dwvrow.Cells(5).Value = obj_Entidad.TCMTRT
      dwvrow.Cells(6).Value = obj_Entidad.CTRSPT
      dwvrow.Cells(7).Value = obj_Entidad.NPLCAC
      dwvrow.Cells(8).Value = obj_Entidad.CBRCNT
      dwvrow.Cells(9).Value = obj_Entidad.NOMBRE
      dwvrow.Cells(10).Value = Lista.Images.Item(0)
      dwvrow.Cells(11).Value = obj_Entidad.SESTCM
      dwvrow.Cells(12).Value = obj_Entidad.SEGUIMIENTO
      dwvrow.Cells(13).Value = obj_Entidad.GPSLAT
      dwvrow.Cells(14).Value = obj_Entidad.GPSLON
      dwvrow.Cells(15).Value = obj_Entidad.FECGPS
      dwvrow.Cells(16).Value = obj_Entidad.HORGPS
      If obj_Entidad.SESTRG > 0 Then
        dwvrow.Cells(0).Value = True
        dwvrow.Cells(0).ReadOnly = True
        dwvrow.DefaultCellStyle.BackColor = Color.YellowGreen
      End If
      If obj_Entidad.HORGPS <> "" Then
        dwvrow.Cells(17).Value = My.Resources.button_ok1
      Else
        dwvrow.Cells(17).Value = My.Resources.Nada_1
      End If
      Me.dgVehiculos.Rows.Add(dwvrow)
    Next
    Me.Limpiar_Controles(2)
  End Sub

  Private Function Validar_Check() As Boolean
    Dim lbool_Estado As Boolean = False
    For lint_Contador As Integer = 0 To Me.dgVehiculos.RowCount - 1
      If Me.dgVehiculos.Item(0, lint_Contador).Value = True And Me.dgVehiculos.Rows(lint_Contador).DefaultCellStyle.BackColor <> Color.YellowGreen Then
        lbool_Estado = True
        Exit For
      End If
    Next
    Return lbool_Estado
  End Function

  Private Sub SeleccionarSolicitud(ByVal intCount As Integer)
    For Each obj As DataGridViewRow In Me.dgSolicitud.Rows
      obj.Cells(0).Value = My.Resources.runprog
    Next
    If intCount < 0 Then
      _indice = -1
      Exit Sub
    End If
    If _indice = -1 Then
      _indice = Me.dgSolicitud.CurrentRow.Index
    End If
    If Validar_Check() Then
      Me.ctbTipoCarroceria.Name = Me.dgSolicitud.Item(3, _indice).Value
      Me.dgSolicitud.Rows(_indice).Cells(0).Value = My.Resources.button_ok1
      Me.dgSolicitud.Rows(_indice).Selected = True
      HelpClass.MsgBox("Para elegir otra solicitud presionar cancelar")
    Else
      _indice = Me.dgSolicitud.CurrentRow.Index
      Me.dgSolicitud.Rows(_indice).Selected = True
      Me.dgSolicitud.Rows(intCount).Cells(0).Value = My.Resources.button_ok1
    End If
    Cargar_Datos_Solicitados(Me.dgSolicitud.Rows(intCount).Cells(1).Value.ToString.Trim)
    dgSolicitud.CommitEdit(DataGridViewDataErrorContexts.Commit)
  End Sub

  Private Sub Cargar_Datos_Solicitados(ByVal NroSolicitud As String)
    Try
      Dim objEntidad As New Solicitud_Transporte
      Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
      objEntidad.NCSOTR = NroSolicitud
      objEntidad.CCMPN = Me._obj_Entidad.CCMPN
      objEntidad = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidad)
      Me.Codigo.Text = objEntidad.NCSOTR
      Me.ctlCliente.Codigo = objEntidad.CCLNT
      Me.dtpFechaSolicitud.Text = HelpClass.CNumero_a_Fecha(objEntidad.FECOST)
      Me.ctlLocalidadOrigen.Codigo = objEntidad.CLCLOR
      Me.txtDireccionLocalidadCarga.Text = objEntidad.TDRCOR
      Me.ctlLocalidadDestino.Codigo = objEntidad.CLCLDS
      Me.txtDireccionLocalidadEntrega.Text = objEntidad.TDRENT
      Me.txtCantidadSolicitada.Text = objEntidad.QSLCIT
      Me.txtTipoServicio.Codigo = objEntidad.CTPOSR
      Me.ctlTipoVehiculo.Codigo = objEntidad.CUNDVH
      Me.ctbMercaderias.Codigo = objEntidad.CMRCDR
      txtUnidadMedida.Codigo = objEntidad.CUNDMD
      txtCantidadMercaderia.Text = objEntidad.QMRCDR
      Me.txtObservaciones.Text = objEntidad.TOBS.Trim
      Me.dtpFechaInicioCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FINCRG)
      Me.dtpFinCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FENTCL)
      Me.txtHoraCarga.Text = HelpClass.CompletarCadena(objEntidad.HINCIN, 6, "0", HorizontalAlignment.Right)
      Me.txtHoraEntrega.Text = HelpClass.CompletarCadena(objEntidad.HRAENT, 6, "0", HorizontalAlignment.Right)
    Catch : End Try
  End Sub

  Private Sub PintarCeldaSolicitud(ByVal intCelda As Integer)
    If CType(Me.dgSolicitud.Rows(_indice).Cells(6).Value, Integer) = (CType(Me.dgSolicitud.Rows(intCelda).Cells(7).Value, Integer)) Then
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204) ' Color.FromArgb(227, 227, 197) ' Color.FromArgb(255, 255, 204)
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 204)
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionForeColor = Color.Black
    End If
    If CType(Me.dgSolicitud.Rows(intCelda).Cells(6).Value, Integer) < (CType(Me.dgSolicitud.Rows(intCelda).Cells(7).Value, Integer)) Then
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.BackColor = Color.FromArgb(251, 47, 25)
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.ForeColor = Color.White
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 47, 25)
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionForeColor = Color.White
    End If
    If CType(Me.dgSolicitud.Rows(intCelda).Cells(6).Value, Integer) > (CType(Me.dgSolicitud.Rows(intCelda).Cells(7).Value, Integer)) Then
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.BackColor = Color.White
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionBackColor = Color.White
      Me.dgSolicitud.Rows(intCelda).DefaultCellStyle.SelectionForeColor = Color.Black
    End If
  End Sub

  Private Sub Eliminar_Asignacion_Solicitud(ByVal lint_RowIndex As Integer, ByVal ldgv_DataGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView)
    Try
      Dim obj_Entidad As New Detalle_Solicitud_Transporte
      Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
      obj_Entidad.NCSOTR = ldgv_DataGridView.Item(0, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.NCRRSR = ldgv_DataGridView.Item(1, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.NPLNJT = ldgv_DataGridView.Item(7, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.NCRRPL = ldgv_DataGridView.Item(8, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.NRUCTR = ldgv_DataGridView.Item(9, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.NPLCUN = ldgv_DataGridView.Item(11, lint_RowIndex).Value.ToString.Trim
      obj_Entidad.CULUSA = MainModule.USUARIO
      obj_Entidad.FULTAC = HelpClass.TodayNumeric
      obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

      obj_Entidad.CCMPN = Me._obj_Entidad.CCMPN
      obj_Entidad.CDVSN = Me._obj_Entidad.CDVSN
      obj_Entidad.CPLNDV = Me._obj_Entidad.CPLNDV

      obj_Entidad.NCSOTR = obj_Logica.Elimina_Solicitud_Detalle(obj_Entidad).NCSOTR
      If obj_Entidad.NCSOTR <> "0" Then
        HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
      Else
        HelpClass.ErrorMsgBox()
        Exit Sub
      End If
      Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
      Me.dgDatosGeneral.Rows.RemoveAt(lint_RowIndex)
      Me.ListarSolicitud()
      Me.ListarVehiculo()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Imprimir(ByVal objParamList As List(Of String))
    Dim objRep As New Junta_Transporte_BLL
    Dim objCrep As New rptJuntaTransportista
    Dim objDt As DataTable
    Dim objDs As New DataSet
    Dim objPrintForm As New PrintForm
    Try
      objDt = HelpClass.GetDataSetNative(objRep.Listar_Junta_Transporte_Detalle(objParamList))
      objDt.TableName = "RZST21"
      objDs.Tables.Add(objDt.Copy)
      objCrep.SetDataSource(objDs)
      objPrintForm.ShowForm(objCrep, Me)
    Catch : End Try
  End Sub

  Private Sub Enviar_Orden_Interna_SAP()
    If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value.ToString.Trim = "0" Then
      HelpClass.MsgBox("No hay nro de operación asignada")
      Exit Sub
    End If
    If HelpClass.RspMsgBox("Desea generar la orden interna a la operación de transporte nro " & Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value & " ?") = Windows.Forms.DialogResult.No Then
      Exit Sub
    End If
    Generar_Orden_Interna()
  End Sub

  Private Function Validar_Recursos_Asignados(ByVal lint_indice As Integer) As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    'Evaluando la Asignación: Tracto, Acoplado y Conductor
    If Me.dgDatosGeneral.Item(11, lint_indice).Value.ToString = "" Then
      lstr_validacion += "* TRACTO" & Chr(13)
    End If
    If Me.dgDatosGeneral.Item(15, lint_indice).Value.ToString = "" Then
      lstr_validacion += "* CONDUCTOR" & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub Registrar_Operacion_Transporte(ByVal OrdenServicio As String)
    Try
      'Objetos para referenciar parametros del Stored Procedure
      Dim objEntidad As New List(Of String)
      'Clase DAO para acceso a la capa de Negocio y Datos
      Dim objOperacionTransporte As New OperacionTransporte_BLL
      'resultado local
      Dim lstr_resultado As String = ""
      'Variable que retiene el indice seleccionado
      Dim lint_indice As Integer = dgDatosGeneral.CurrentCellAddress.Y
      'Numero de Operacion (En el caso que la solicitud ya tenga uno generado)
      Dim lint_nrooperacion As Double = 0
      'Lista Temporal para analizar si es que la solicitud ya tiene numero de operacion generado
      Dim objListaTemporal As New List(Of String)
      Dim objEntidadOperacion As New OperacionTransporte

      objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)  'PARAM_NPLNJT
      objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)  'PARAM_NCRRPL 
      objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)  'PARAM_NCSOTR 
      objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)  'PARAM_NCRRSR 
      objEntidad.Add(OrdenServicio)  'PARAM_NORSRT 
      objEntidad.Add(Me._obj_Entidad.CCMPN) 'HelpClass.getSetting("Compania"))  'PARAM_CCMPN 
      objEntidad.Add(Me._obj_Entidad.CDVSN) 'HelpClass.getSetting("Division"))  'PARAM_CDVSN 
      objEntidad.Add(Me._obj_Entidad.CPLNDV) 'HelpClass.getSetting("Planta"))  'PARAM_CPLNDV 
      objEntidad.Add(MainModule.USUARIO)  'PARAM_CUSCRT 
      objEntidad.Add(HelpClass.TodayNumeric)  'PARAM_FCHCRT 
      objEntidad.Add(HelpClass.NowNumeric)  'PARAM_HRACRT 
            objEntidad.Add(Ransa.Utilitario.HelpClass.NombreMaquina)  'PARAM_NTRMCR 
      'Validando la Existencia de la Operación 
      objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)
      objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)
      objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)
      objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)

      lint_nrooperacion = CInt(objOperacionTransporte.Verificacion_Existencia_Operacion_Solicitud(objListaTemporal))
      If lint_nrooperacion > 0 Then
        HelpClass.MsgBox("Este Item ya tiene Operación Generada es el Nro " & lint_nrooperacion)
        Exit Sub
      End If
      objEntidad.Add("NUEVO")
      objEntidad.Add("")
      lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
      objEntidadOperacion.NOPRCN = lstr_resultado
      'Obteniendo los datos del planeamiento
      objEntidadOperacion = objOperacionTransporte.Obtener_Numero_Planeamiento(objEntidadOperacion)
      If IsNumeric(lstr_resultado) Then
        If lstr_resultado.Trim.Equals("-1") OrElse lstr_resultado.Trim.Equals("0") Then
          HelpClass.ErrorMsgBox()
          Exit Sub
        Else
          HelpClass.MsgBox("Operación Generada N° " & lstr_resultado)
          'Imprimiendo los datos de la operacion y orden interna generadas
          Me.dgDatosGeneral.Rows(lint_indice).Cells(18).Value = objEntidadOperacion.NOPRCN
          Me.dgDatosGeneral.Rows(lint_indice).Cells(19).Value = objEntidadOperacion.NPLNMT
          'Generando la Orden Interna
          Me.Generar_Orden_Interna()
        End If
      Else
        HelpClass.MsgBox(lstr_resultado, MessageBoxIcon.Error)
      End If
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub Generar_Orden_Interna()
    If Me.dgDatosGeneral.CurrentRow Is Nothing OrElse Me.dgDatosGeneral.CurrentCellAddress.Y = -1 Then
      Exit Sub
    End If
    If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value.ToString.Trim = "0" Then
      HelpClass.MsgBox("No hay nro de operación asignada")
      Exit Sub
    End If
    If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString.Trim <> "0" AndAlso Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString.Trim <> "Enviar SAP" Then
      HelpClass.MsgBox("La Operación ya tiene orden Interna Asignada es el N° " + Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString)
      Exit Sub
    End If
    Dim objOrdenInterna As New OrdenInterna_BLL
    Dim objEntidad As New Planeamiento
    Dim objParametros As New List(Of String)
    'fila Seleccionada de la grilla
    Dim objFila As DataGridViewRow = Me.dgDatosGeneral.CurrentRow
    'Llenando el parametros de valores
    objParametros.Add(objFila.Cells("NOPRCN").Value.ToString())
    objParametros.Add(MainModule.USUARIO)
    objParametros.Add(HelpClass.TodayNumeric)
    objParametros.Add(HelpClass.NowNumeric)
        objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
    objParametros.Add(objFila.Cells("G_NPLCUN").Value.ToString())
    objParametros.Add(objFila.Cells("G_NPLCAC").Value.ToString())
    objParametros.Add(objFila.Cells("G_CBRCNT").Value.ToString())
    objParametros.Add(Me._obj_Entidad.CCMPN)
    objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
    If objEntidad.NORINS <> 0 Then
      HelpClass.MsgBox("Orden Interna N° " + CStr(objEntidad.NORINS) + " enviada a SAP")
    End If
    'Imprimiendo el numero de orden interna
    Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value = objEntidad.NORINS
    Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Style.ForeColor = Color.Black
  End Sub
#End Region

#Region "Eventos"

  Private Sub frmDetalleSolicitudTransporte_1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.Cargar_Combo()
    Me.Alinear_Columnas_Grilla()
    Me.ListarSolicitud()
    Me.ListarJuntaGeneral()
    Me.AccionCancelar()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    obeTransportista.pCCMPN_Compania = Me._obj_Entidad.CCMPN
    obeTransportista.pNRUCTR_RucTransportista = "20100039207"
    ctbTransportista.pCargar(obeTransportista)
    ' Inicializamos el usuario para tenerlo presente en el control, por si cambia la propiedad pAccesoPorUsuario
    txtCliente.pUsuario = USUARIO
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    ListarVehiculo()
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    gint_Estado = 1
    Me.Close()
  End Sub

  Private Sub btnBuscarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSolicitud.Click
    If Validar_Check() Then Exit Sub
    Me.ListarSolicitud()
    Me.TabSolicitudFlete.SelectedIndex = 1
  End Sub

  Private Sub btnBuscarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarVehiculo.Click
    If Not Me.ctbTransportista.pRucTransportista.Trim.Equals("") Or Me.ctbTipoCarroceria.Texto.TextLength > 0 Or Me.txtVehiculo.Text.Trim.Length > 0 Then
      Me.ListarVehiculo()
    End If
  End Sub

  Private Sub dgVehiculos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVehiculos.CellClick
    If e.RowIndex < 0 Then
      Exit Sub
    End If
    If e.ColumnIndex = 10 Then
      If Me.dgVehiculos.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen Then Exit Sub
      Dim frmAcoplado_Conductor As New frmBuscarAcoplado_Conductor
      With frmAcoplado_Conductor
        ._NumeroRuc = Me.dgVehiculos.Item(4, e.RowIndex).Value.ToString.Trim
        .strAcoplado = Me.dgVehiculos.Item(7, e.RowIndex).Value
        .strConductor = Me.dgVehiculos.Item(8, e.RowIndex).Value
        .CCMPN = Me._obj_Entidad.CCMPN
        .CDVSN = Me._obj_Entidad.CDVSN
        .CPLNDV = Me._obj_Entidad.CPLNDV
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Me.dgVehiculos.Item(7, e.RowIndex).Value = .ctbAcoplado.pNroAcoplado
          Me.dgVehiculos.Item(8, e.RowIndex).Value = .cmbConductor.pBrevete
        End If
      End With
    End If
    If e.ColumnIndex = 0 Then
      dgVehiculos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End If
  End Sub

  Private Sub dgVehiculos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVehiculos.CellDoubleClick
    Try
      If e.RowIndex < 0 Then
        Exit Sub
      End If
      'Informacion GPS
      If e.ColumnIndex = 17 Then
        If Me.dgVehiculos.Item(16, Me.dgVehiculos.CurrentCellAddress.Y).Value.ToString <> "" Then
          Dim objGpsBrowser As New frmMapa
          With objGpsBrowser
            .Latitud = Me.dgVehiculos.Item(13, e.RowIndex).Value
            .Longitud = Me.dgVehiculos.Item(14, e.RowIndex).Value
            .Fecha = Me.dgVehiculos.Item(15, e.RowIndex).Value.ToString
            .Hora = dgVehiculos.Item(16, e.RowIndex).Value
            If CType(.Hora.Substring(0, 2), Integer) > 0 And CType(.Hora.Substring(0, 2), Integer) < 5 Then
              .Fecha = HelpClass.ConvertFechaGPS_Fecha(.Fecha)
            End If
            .WindowState = FormWindowState.Maximized
            .ShowForm(.Latitud, .Longitud, Me)
          End With
        End If
      End If
      Dim hash As New Hashtable()
      hash("CCMPN") = _obj_Entidad.CCMPN
      If e.ColumnIndex = 1 Then Informacion_Detallada_Transportista(1, Me.dgVehiculos.Item(e.ColumnIndex, e.RowIndex).Value, hash)
      If e.ColumnIndex = 7 Then Informacion_Detallada_Transportista(2, Me.dgVehiculos.Item(e.ColumnIndex, e.RowIndex).Value, hash)
      If e.ColumnIndex = 8 Then Informacion_Detallada_Transportista(3, Me.dgVehiculos.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    Catch : End Try
  End Sub

  Private Sub dgSolicitud_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSolicitud.CellClick
    SeleccionarSolicitud(e.RowIndex)
  End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim llist_Entidad As New List(Of Detalle_Solicitud_Transporte)
    Dim lint_Asignado As Integer = 0
    dgVehiculos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    If _indice = -1 Then Exit Sub
    If Me.dgSolicitud.RowCount = 0 Then Exit Sub
    If Me.dgSolicitud.Rows(_indice).Selected = False Then
      _indice = Me.dgSolicitud.CurrentCellAddress.Y
    End If
    Dim intCantRow = Me.dgSolicitud.Rows.Count
    Try
      For lint_Contador As Integer = 0 To Me.dgVehiculos.RowCount - 1
        If Me.dgVehiculos.Item(0, lint_Contador).Value = True And Me.dgVehiculos.Rows(lint_Contador).DefaultCellStyle.BackColor <> Color.YellowGreen Then
          Dim obj_Entidad As New Detalle_Solicitud_Transporte
          obj_Entidad.NCSOTR = Me.dgSolicitud.Item(1, _indice).Value
          obj_Entidad.CCLNT = Me.dgSolicitud.Item(2, _indice).Value
          obj_Entidad.FASGTR = HelpClass.TodayNumeric
          obj_Entidad.HASGTR = HelpClass.ConvertHoraNumeric(HelpClass.Now_Hora)
          obj_Entidad.NPLNJT = Me.txtNroJunta.Text.Trim
          obj_Entidad.NCRRPL = Me.txtCorrelativoJunta.Text.Trim
          obj_Entidad.NPLCUN = Me.dgVehiculos.Item(1, lint_Contador).Value
          obj_Entidad.NRUCTR = Me.dgVehiculos.Item(4, lint_Contador).Value
          obj_Entidad.NPLCAC = Me.dgVehiculos.Item(7, lint_Contador).Value
          obj_Entidad.CBRCNT = Me.dgVehiculos.Item(8, lint_Contador).Value
          obj_Entidad.CUSCRT = MainModule.USUARIO
          obj_Entidad.FCHCRT = HelpClass.TodayNumeric
          obj_Entidad.HRACRT = HelpClass.NowNumeric
                    obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
          obj_Entidad.CCMPN = _obj_Entidad.CCMPN
          obj_Entidad.CDVSN = _obj_Entidad.CDVSN
          obj_Entidad.CPLNDV = _obj_Entidad.CPLNDV

          llist_Entidad.Add(obj_Entidad)
          lint_Asignado = lint_Asignado + 1
        End If
      Next
      If lint_Asignado > 0 Then
        If obj_Logica.Registra_Solicitud_Detalle(llist_Entidad).NCSOTR <> "0" Then
          HelpClass.MsgBox("Se registro satisfactoriamente")
          Me.ListarJuntaGeneral()
          Me.TabSolicitudFlete.SelectedIndex = 1
          Me.AccionCancelar()
          Me.ListarVehiculo()
          If Me.checkFiltroAsignados.Checked = False Then
            Me.dgSolicitud.Rows(_indice).Cells(7).Value = CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value + lint_Asignado, Integer).ToString
            PintarCeldaSolicitud(_indice)
            Exit Sub
          End If
          If CType(Me.dgSolicitud.Rows(_indice).Cells(6).Value, Integer) > (CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value, Integer) + lint_Asignado) Then
            Me.dgSolicitud.Rows(_indice).Cells(7).Value = CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value + lint_Asignado, Integer).ToString
          Else
            Me.dgSolicitud.Rows.RemoveAt(_indice)
            _indice = -1
            Me.SeleccionarSolicitud(0)
          End If
        Else
          HelpClass.ErrorMsgBox()
        End If
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If dgDatosGeneral.Rows.Count > 0 Then
      If Me.dgDatosGeneral.CurrentRow.Selected = False Then Exit Sub
      If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value = 0 Then
        If HelpClass.RspMsgBox("Desea eliminar este registro") = MsgBoxResult.Yes Then Me.Eliminar_Asignacion_Solicitud(Me.dgDatosGeneral.CurrentCellAddress.Y, Me.dgDatosGeneral)
      Else
        HelpClass.MsgBox("Esta Junta tiene asignada N° de Operacion; si quiere eliminar comuniquese al Dpto. de Sistemas")
      End If
    End If
  End Sub

  Private Sub dgDatosDetallado_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    If e.RowIndex < 0 Then
      Exit Sub
    End If
    If Me.MenuBar.Enabled = True Then Me.btnEliminar.Enabled = True
  End Sub

  Private Sub dgSolicitud_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSolicitud.CellDoubleClick
    If e.ColumnIndex = 1 Then
      If e.RowIndex = -1 Then Exit Sub
      Dim objInformacionSolicitud As New frmInformacionSolicitud(Me.dgSolicitud.Rows(e.RowIndex).Cells(1).Value.ToString.Trim)
      objInformacionSolicitud.CCMPN = _obj_Entidad.CCMPN
      objInformacionSolicitud.CDVSN = _obj_Entidad.CDVSN
      objInformacionSolicitud.CPLNDV = _obj_Entidad.CPLNDV
      If objInformacionSolicitud.ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.ListarSolicitud()
      End If
    End If
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim objParamList As New List(Of String)
    If Me.dgDatosGeneral.RowCount > 0 Then
      objParamList.Add(Me.txtNroJunta.Text)
      objParamList.Add(Me.txtCorrelativoJunta.Text)
      objParamList.Add(_obj_Entidad.CCMPN)
      objParamList.Add(_obj_Entidad.CDVSN)
      objParamList.Add(_obj_Entidad.CPLNDV)

      Imprimir(objParamList)
    Else
      HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
    End If
  End Sub

  Private Sub frmDetalleSolicitudTransporte_1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    If gint_Estado = 2 Then Exit Sub
    gint_Estado = 1
  End Sub

  Private Sub txtVehiculo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVehiculo.KeyUp
    If e.KeyCode = Keys.Enter Then
      If Me.txtVehiculo.Text.Trim.Length = 6 Then
        Me.ListarVehiculo()
      End If
    End If
  End Sub

  Private Sub dgDatosGeneral_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosGeneral.CellClick
    If e.RowIndex = -1 Then Exit Sub
    If e.ColumnIndex = 20 Then
      If dgDatosGeneral.Item(20, e.RowIndex).Value.ToString = "Enviar SAP" OrElse dgDatosGeneral.Item(20, e.RowIndex).Value.ToString = "0" Then
        Enviar_Orden_Interna_SAP()
      End If
    End If
    If e.ColumnIndex = 28 Then
      If Me.dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value = "" Then
        Exit Sub
      End If
      Dim NPLCUN As String = dgDatosGeneral.Item("G_NPLCUN", e.RowIndex).Value.ToString.Trim()
      Dim strExiste As String = dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value.ToString.Trim()
      If strExiste = vbNullString Then Exit Sub
      Dim f As New frmRegistroWAP(NPLCUN)
      f.ShowForm(Me)
    End If

  End Sub

  'Generar Orden Interna SAP

  Private Sub dgDatosGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosGeneral.CellDoubleClick
    Try
      If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
      If e.RowIndex < 0 Then Exit Sub


      If e.ColumnIndex = 27 Then
        If Me.dgDatosGeneral.Item(26, e.RowIndex).Value.ToString <> "" Then
          Dim objGpsBrowser As New frmMapa
          With objGpsBrowser
            .Latitud = Me.dgDatosGeneral.Item(23, e.RowIndex).Value
            .Longitud = Me.dgDatosGeneral.Item(24, e.RowIndex).Value
            .Fecha = Me.dgDatosGeneral.Item(25, e.RowIndex).Value.ToString
            .Hora = dgDatosGeneral.Item(26, e.RowIndex).Value
            If CType(.Hora.Substring(0, 2), Integer) > 0 And CType(.Hora.Substring(0, 2), Integer) < 5 Then
              .Fecha = HelpClass.ConvertFechaGPS_Fecha(.Fecha)
            End If
            .WindowState = FormWindowState.Maximized
            .ShowForm(.Latitud, .Longitud, Me)
          End With
        End If
      End If

      Dim hash As New Hashtable()
      hash("CCMPN") = _obj_Entidad.CCMPN
      If e.ColumnIndex = 11 Then Informacion_Detallada_Transportista(1, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
      If e.ColumnIndex = 13 Then Informacion_Detallada_Transportista(2, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
      If e.ColumnIndex = 15 Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
      If e.ColumnIndex = 21 Then
        'If Me.dgDatosGeneral.Item(18, e.RowIndex).Value <> 0 Then Exit Sub
        Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
        Dim obj_Entidad As New Detalle_Solicitud_Transporte
        Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
        Dim lstr_Estado As String = ""

        obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item(0, lint_indice).Value
        obj_Entidad.NCRRSR = Me.dgDatosGeneral.Item(1, lint_indice).Value
        obj_Entidad.NPLNJT = Me.dgDatosGeneral.Item(7, lint_indice).Value
        obj_Entidad.NCRRPL = Me.dgDatosGeneral.Item(8, lint_indice).Value

        obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Existencias_PAG(obj_Entidad)

        If obj_Entidad.NGUITR <> "0" Then
          lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
          If obj_Entidad.NCTAVC <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
          If obj_Entidad.NCSLPE <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
          If obj_Entidad.NCTAV2 <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
          If obj_Entidad.NCSLP2 <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
          lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
          HelpClass.MsgBox(lstr_Estado)
          Exit Sub
        End If

        obj_Entidad.NRUCTR = Me.dgDatosGeneral.Item(9, lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
        obj_Entidad.NPLCUN = Me.dgDatosGeneral.Item(11, lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
        obj_Entidad.NPLCAC = Me.dgDatosGeneral.Item(13, lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
        obj_Entidad.CBRCNT = Me.dgDatosGeneral.Item(15, lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
        obj_Entidad.CBRCN2 = Me.dgDatosGeneral.Item(22, lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value

        Dim frmReasignarRecurso As New frmReasignarRecurso
        frmReasignarRecurso.IsMdiContainer = True
        With frmReasignarRecurso
          '.txtNroSolicitud.Text = obj_Entidad.NCSOTR 'Me.dgDatosGeneral.Item(0, lint_indice).Value
          '.txtItemSolicitud.Text = obj_Entidad.NCRRSR 'Me.dgDatosGeneral.Item(1, lint_indice).Value
          '.txtJunta.Text = obj_Entidad.NPLNJT 'Me.dgDatosGeneral.Item(7, lint_indice).Value
          '.txtItemJunta.Text = obj_Entidad.NCRRPL 'Me.dgDatosGeneral.Item(8, lint_indice).Value
          '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
          '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
          '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
          '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
          '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value
          ._obj_Entidad = obj_Entidad
          .CCMPN = Me._obj_Entidad.CCMPN
          .CDVSN = Me._obj_Entidad.CDVSN
          .CPLNDV = Me._obj_Entidad.CPLNDV

          If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
          Me.dgDatosGeneral.Item(9, lint_indice).Value = .ctbTransportista.pRucTransportista
          Me.dgDatosGeneral.Item(11, lint_indice).Value = .ctbTracto.pNroPlacaUnidad
          Me.dgDatosGeneral.Item(13, lint_indice).Value = .ctbAcoplado.pNroAcoplado
          Me.dgDatosGeneral.Item(15, lint_indice).Value = .cmbConductor.pBrevete
          Me.dgDatosGeneral.Item(22, lint_indice).Value = .cmbSegundoConductor.pBrevete
        End With
        Me.ListarVehiculo()
      End If
    Catch : End Try
  End Sub

  Private Sub btnAsignarTerceros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarTerceros.Click
    If _indice = -1 Then Exit Sub
    If Me.dgSolicitud.RowCount = 0 Then Exit Sub
    If Me.dgSolicitud.Rows(_indice).Selected = False Then
      _indice = Me.dgSolicitud.CurrentCellAddress.Y
    End If
    Dim frmReasignarRecurso As New frmReasignarRecurso
    Dim lint_indice As Integer = Me.dgSolicitud.CurrentCellAddress.Y
    frmReasignarRecurso.IsMdiContainer = True
    With frmReasignarRecurso
      ._Estado = False
      .txtNroSolicitud.Text = Me.dgSolicitud.Item(1, lint_indice).Value
      .txtItemSolicitud.Text = "?"
      .txtJunta.Text = Me.txtNroJunta.Text
      .txtItemJunta.Text = Me.txtCorrelativoJunta.Text
      .CCMPN = Me._obj_Entidad.CCMPN
      .CDVSN = Me._obj_Entidad.CDVSN
      .CPLNDV = Me._obj_Entidad.CPLNDV
      '._Transportista = ""
      '._Tracto = ""
      '._Acoplado = ""
      '._Conductor = ""

      If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      Dim intCantRow = Me.dgSolicitud.Rows.Count
      Dim llist_Entidad As New List(Of Detalle_Solicitud_Transporte)
      Dim obj_Entidad As New Detalle_Solicitud_Transporte
      Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
      obj_Entidad.NCSOTR = Me.dgSolicitud.Item(1, Me.dgSolicitud.SelectedRows(0).Index).Value
      obj_Entidad.CCLNT = Me.dgSolicitud.Item(2, Me.dgSolicitud.SelectedRows(0).Index).Value
      obj_Entidad.FASGTR = HelpClass.TodayNumeric
      obj_Entidad.HASGTR = HelpClass.ConvertHoraNumeric(HelpClass.Now_Hora)
      obj_Entidad.NPLNJT = Me.txtNroJunta.Text.Trim
      obj_Entidad.NCRRPL = Me.txtCorrelativoJunta.Text.Trim
      obj_Entidad.NPLCUN = .ctbTracto.pNroPlacaUnidad
      obj_Entidad.NRUCTR = .ctbTransportista.pRucTransportista
      obj_Entidad.NPLCAC = .ctbAcoplado.pNroAcoplado
      obj_Entidad.CBRCNT = .cmbConductor.pBrevete
      obj_Entidad.CUSCRT = MainModule.USUARIO
      obj_Entidad.FCHCRT = HelpClass.TodayNumeric
      obj_Entidad.HRACRT = HelpClass.NowNumeric
            obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
      llist_Entidad.Add(obj_Entidad)
      If obj_Logica.Registra_Solicitud_Detalle(llist_Entidad).NCSOTR <> "0" Then
        HelpClass.MsgBox("Se registro satisfactoriamente")
        ' Me.ListarJuntaEspecifica(Me.dgSolicitud.SelectedRows(0).Index)
        ' Me.dgDatosDetallado.Rows.Clear()
        Me.TabSolicitudFlete.SelectedIndex = 1
        Me.ListarJuntaGeneral()
        Me.AccionCancelar()
        Me.ListarVehiculo()
        If Me.checkFiltroAsignados.Checked = False Then
          Me.dgSolicitud.Rows(_indice).Cells(7).Value = CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value + 1, Integer).ToString
          PintarCeldaSolicitud(_indice)
          Exit Sub
        End If
        If CType(Me.dgSolicitud.Rows(_indice).Cells(6).Value, Integer) > (CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value, Integer) + 1) Then
          Me.dgSolicitud.Rows(_indice).Cells(7).Value = CType(Me.dgSolicitud.Rows(_indice).Cells(7).Value + 1, Integer).ToString
        Else
          Me.dgSolicitud.Rows.RemoveAt(_indice)
          _indice = -1
          Me.SeleccionarSolicitud(0)
        End If
      Else
        HelpClass.ErrorMsgBox()
      End If
    End With
  End Sub

  Private Sub txtNroSolicitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroSolicitud.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnGenerarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOperacion.Click
    If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
    If Me.dgDatosGeneral.CurrentRow.Selected = False Then Exit Sub
    Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
    If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
    If Me.dgDatosGeneral.Item("NOPRCN", lint_indice).Value <> 0 Then
      HelpClass.MsgBox("Ya tiene asignado una Operación y Planeamiento")
      Exit Sub
    End If
    If HelpClass.RspMsgBox("Desea generar la operación de transporte?") = Windows.Forms.DialogResult.No Then
      Exit Sub
    End If
    Me.Cursor = Cursors.WaitCursor
    Dim obj_Entidad As New Solicitud_Transporte
    Dim obj_LogicaSolicitud As New Solicitud_Transporte_BLL
    Dim frmBuscarServicio As New frmBuscarOrdenServicio
    Dim obj_LogicaOperacion As New OperacionTransporte_BLL
    Dim objEntidad As New List(Of String)
    Dim lstr_resultado As String = ""
    Dim lstr_ordenservicio As String = ""
    frmBuscarServicio.IsMdiContainer = True
    obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item(0, Me.dgDatosGeneral.CurrentCellAddress.Y).Value
    obj_Entidad.CCMPN = Me._obj_Entidad.CCMPN
    lstr_ordenservicio = obj_LogicaSolicitud.Obtener_Solicitud_Transporte(obj_Entidad).NORSRT
    If lstr_ordenservicio <> "0" Then
      Registrar_Operacion_Transporte(lstr_ordenservicio)
      Me.Cursor = Cursors.Default
      Exit Sub
    Else
      With frmBuscarServicio
        .CodigoCliente = Me.dgDatosGeneral.Item(2, Me.dgDatosGeneral.CurrentCellAddress.Y).Value
        .CCMPN = _obj_Entidad.CCMPN
        .ShowDialog()
        objEntidad.Add(obj_Entidad.NCSOTR)
        objEntidad.Add(.OrdenServicio)
        objEntidad.Add(.CodigoCliente)
        lstr_ordenservicio = .OrdenServicio
        If .OrdenServicio = "" Then Exit Sub
      End With
      lstr_resultado = obj_LogicaOperacion.Validar_Asignacion_Operacion_Transporte(objEntidad)
      If lstr_resultado.Trim.Contains("ERROR") = True Then
        HelpClass.MsgBox(lstr_resultado)
      Else
        obj_Entidad.CCMPN = Me._obj_Entidad.CCMPN
        If obj_LogicaSolicitud.Asignar_Orden_Servicio_A_Solicitud(obj_Entidad).NCSOTR <> "0" Then
          HelpClass.MsgBox("Se asigno satisfactoriamente la Orden de Servicio N°" & objEntidad(1))
        End If
        Registrar_Operacion_Transporte(lstr_ordenservicio)
        Exit Sub
      End If
    End If
  End Sub

  Private Sub btnReasignarRecursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReasignarRecursos.Click
    If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
    Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
    Dim obj_Entidad As New Detalle_Solicitud_Transporte
    Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
    Dim frmReasignarRecurso As New frmReasignarRecurso
    frmReasignarRecurso.IsMdiContainer = True
    With frmReasignarRecurso
      .txtNroSolicitud.Text = Me.dgDatosGeneral.Item(0, lint_indice).Value
      .txtItemSolicitud.Text = Me.dgDatosGeneral.Item(1, lint_indice).Value
      .txtJunta.Text = Me.dgDatosGeneral.Item(7, lint_indice).Value
      .txtItemJunta.Text = Me.dgDatosGeneral.Item(7, lint_indice).Value
      .CCMPN = Me._obj_Entidad.CCMPN
      .CDVSN = Me._obj_Entidad.CDVSN
      .CPLNDV = Me._obj_Entidad.CPLNDV
      .Tag = Me.dgDatosGeneral.Item(9, lint_indice).Value.ToString & "-" & Me.dgDatosGeneral.Item(11, lint_indice).Value.ToString
      If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
    End With
    Me.ListarJuntaGeneral()
  End Sub

  Private Sub txtNroSolicitud_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroSolicitud.KeyUp
    If e.KeyCode = Keys.Back Then
      Me.txtNroSolicitud.Text = ""
    End If
  End Sub

  Private Sub txtNroSolicitud_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroSolicitud.Leave
    If Me.txtNroSolicitud.TextLength > 0 Then
      Me.checkFiltroAsignados.Checked = False
    Else
      Me.checkFiltroAsignados.Checked = True
    End If
  End Sub

  Private Sub btnLeyenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeyenda.Click
    Dim objLeyenda As New frmLeyenda
    objLeyenda.ShowDialog()
  End Sub

  Private Sub dgSolicitud_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSolicitud.KeyUp
    SeleccionarSolicitud(Me.dgSolicitud.CurrentRow.Index)
  End Sub

  Private Sub btnOrdenInterna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenInterna.Click
    If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value.ToString.Trim = "0" Then
      HelpClass.MsgBox("No hay nro de operación asignada")
      Exit Sub
    End If
    If HelpClass.RspMsgBox("Desea generar la orden interna a la operación de transporte nro " & Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value & " ?") = Windows.Forms.DialogResult.No Then
      Exit Sub
    End If
    Generar_Orden_Interna()
  End Sub

#End Region

End Class