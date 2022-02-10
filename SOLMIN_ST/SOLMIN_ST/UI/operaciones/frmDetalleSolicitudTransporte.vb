Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data

Public Class frmDetalleSolicitudTransporte
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Dim _list_Entidad_D As New List(Of Detalle_Solicitud_Transporte)
  Dim _list_Entidad_A As New List(Of Detalle_Solicitud_Transporte)

  Private Sub frmDetalleSolicitudTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.btnGuardar.Enabled = False
    Me.btnCancelar.Enabled = False
    Me.btnEliminar.Enabled = False
    Me.Limpiar_Controles()
    Me.Estado_Controles(False)
    Me.Cargar_Combo("")
    _list_Entidad_A.Clear()
    _list_Entidad_D.Clear()
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    Me.btnGuardar.Text = "Guardar"
    Me.btnGuardar.Enabled = True
    Me.btnCancelar.Enabled = True
    Me.btnEliminar.Enabled = False
    Me.btnAsignarTerceros.Enabled = True
    Me.Limpiar_Controles()
    Me.Estado_Controles(True)
    Me.dtpFechaAsignacion.Value = Date.Today
    Me.txtHoraAsignacion.Text = HelpClass.Now_Hora
    If Me.gwdDatos.Rows.Count > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If validar_inputs() = True Then
      Exit Sub
    End If
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      Me.Nuevo_Registro()
      Me.AccionCancelar()
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      If Me.txtSolicitud.Text.Substring(0, Me.txtSolicitud.Text.IndexOf(":") - 1) = Me.gwdDatos.Item(0, Me.gwdDatos.CurrentCellAddress.Y).Value Then
        If Validar_Cambios() <> False Then
          Me.Modificar_Registro()
          Me.AccionCancelar()
        Else
          Me.ctbAcoplado.Limpiar()
          Me.ctbConductor.Limpiar()
        End If
      Else
        HelpClass.MsgBox("No se puede  cambiar de solicitud al momento de modificar")
      End If
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      Me.Estado_Controles(True)
      Me.btnGuardar.Text = "Guardar"
      Me.btnNuevo.Enabled = False
      Me.btnCancelar.Enabled = True
      Me.btnEliminar.Enabled = False
      Me.btnAsignarTerceros.Enabled = False
      Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End If
  End Sub
  Private Function Validar_Cambios() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    If Me.txtPlacaVehiculo.Text.Trim.Length > 1 Then
      If Me.txtPlacaVehiculo.Text.Substring(0, Me.txtPlacaVehiculo.Text.IndexOf(":") - 1) <> Me.gwdDatos.Item("NPLCUN", Me.gwdDatos.CurrentCellAddress.Y).Value Then
        lstr_validacion = "* VEHICULO " & Chr(13)
      End If
    Else
      If Me.txtPlacaVehiculo.Text.Trim.Length = 0 Then
        If Me.txtPlacaVehiculo.Text.Trim <> Me.gwdDatos.Item("NPLCUN", Me.gwdDatos.CurrentCellAddress.Y).Value Then
          lstr_validacion = "* VEHICULO " & Chr(13)
        End If
      Else
        If Me.txtPlacaVehiculo.Text.Substring(0, Me.txtPlacaVehiculo.Text.IndexOf(":") - 1) <> Me.gwdDatos.Item("NPLCUN", Me.gwdDatos.CurrentCellAddress.Y).Value Then
          lstr_validacion = "* VEHICULO " & Chr(13)
        End If
      End If
    End If
    If Me.txtRucTransportista.Text.Trim <> Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value Then
      lstr_validacion += "* TRANSPORTISTA " & Chr(13)
    End If
    If Me.ctbAcoplado.Codigo <> Me.gwdDatos.Item("NPLCAC", Me.gwdDatos.CurrentCellAddress.Y).Value Then
      lstr_validacion += "* ACOPLADO " & Chr(13)
    End If
    If Me.ctbConductor.Codigo <> Me.gwdDatos.Item("CBRCNT", Me.gwdDatos.CurrentCellAddress.Y).Value Then
      lstr_validacion += "* CONDUCTOR " & Chr(13)
    End If

    If lstr_validacion <> "" Then
      HelpClass.MsgBox("SE MODIFICO : " & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function
  Private Sub AccionCancelar()
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.Limpiar_Controles()
    Me.Estado_Controles(False)
    If Me.gwdDatos.Rows.Count > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
    Me.btnNuevo.Enabled = True
    Me.btnGuardar.Enabled = False
    Me.btnCancelar.Enabled = False
    Me.btnEliminar.Enabled = False
    Me.btnAsignarTerceros.Enabled = False
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.AccionCancelar()
    Me.Cargar_Combo("")
    Dim lint_Contador As Integer = 0
    While lint_Contador < Me.gwdDatos.RowCount
      If Me.gwdDatos.Item(16, lint_Contador).Value <> "" Then
        Me.gwdDatos.Rows.RemoveAt(lint_Contador)
        lint_Contador = lint_Contador - 1
      End If
      lint_Contador = lint_Contador + 1
    End While
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If validar_inputs() = True Then
      Exit Sub
    End If
    If MsgBox("Desea eliminar esta Asignación a la Solicitud", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
    Me.Cambiar_Estado_Solicitud()
  End Sub

  Private Sub Cambiar_Estado_Solicitud()
    Try
      If Me.txtSolicitud.Text <> "" Then
        Dim obj_Entidad As New Detalle_Solicitud_Transporte
        Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
        obj_Entidad.NCSOTR = Me.gwdDatos.Item(0, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
        obj_Entidad.NCRRSR = Me.gwdDatos.Item(1, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
        obj_Entidad.NPLNJT = Me.gwdDatos.Item(6, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
        obj_Entidad.NCRRPL = Me.gwdDatos.Item(7, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
        obj_Entidad.CULUSA = MainModule.USUARIO
        obj_Entidad.FULTAC = HelpClass.TodayNumeric
        obj_Entidad.HULTAC = HelpClass.NowNumeric
                obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        obj_Entidad.NCSOTR = obj_Logica.Elimina_Solicitud_Detalle(obj_Entidad).NCSOTR
        If obj_Entidad.NCSOTR <> "0" Then
          HelpClass.MsgBox("Se Elimino Satisfactoriamente")
        Else
          HelpClass.ErrorMsgBox()
          Exit Sub
        End If
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.Listar()
        Me.AccionCancelar()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Nuevo_Registro()
    Dim obj_Entidad As New Detalle_Solicitud_Transporte
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Try
      obj_Entidad.NCSOTR = Me.txtSolicitud.Text.Substring(0, Me.txtSolicitud.Text.IndexOf(":") - 1).Trim
      obj_Entidad.CCLNT = Me.txtSolicitud.Tag.ToString.Trim
      obj_Entidad.FASGTR = HelpClass.CtypeDate(Me.dtpFechaAsignacion.Value)
      obj_Entidad.HASGTR = HelpClass.ConvertHoraNumeric(Me.txtHoraAsignacion.Text.Trim)
      obj_Entidad.NPLNJT = Me.txtNroJunta.Text.Trim
      obj_Entidad.NCRRPL = Me.txtCorrelativoJunta.Text.Trim
      obj_Entidad.NRUCTR = Me.txtRucTransportista.Text.Trim
      If Me.txtPlacaVehiculo.Text.Trim.Length > 0 Then
        obj_Entidad.NPLCUN = Me.txtPlacaVehiculo.Text.Trim.Substring(0, Me.txtPlacaVehiculo.Text.Trim.IndexOf(":") - 1).Trim
      End If
      obj_Entidad.NPLCAC = Me.ctbAcoplado.Codigo.Trim
      obj_Entidad.CBRCNT = Me.ctbConductor.Codigo.Trim
      obj_Entidad.CUSCRT = MainModule.USUARIO
      obj_Entidad.FCHCRT = HelpClass.TodayNumeric
      obj_Entidad.HRACRT = HelpClass.NowNumeric
            obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
      obj_Entidad.NCSOTR = obj_Logica.Registra_Solicitud_Detalle(obj_Entidad).NCSOTR
      If obj_Entidad.NCSOTR <> "0" Then
        HelpClass.MsgBox("Se Registro Satisfactoriamente")
      Else
        HelpClass.ErrorMsgBox()
        Exit Sub
      End If
      Me.Listar()
      Me.Limpiar_Controles()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Modificar_Registro()
    Dim obj_Entidad As New Detalle_Solicitud_Transporte
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Try
      obj_Entidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
      obj_Entidad.NCRRSR = Me.gwdDatos.Item("NCRRSR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
      obj_Entidad.FASGTR = HelpClass.CtypeDate(Me.dtpFechaAsignacion.Value)
      obj_Entidad.HASGTR = HelpClass.ConvertHoraNumeric(Me.txtHoraAsignacion.Text.Trim)
      obj_Entidad.NPLNJT = Me.txtNroJunta.Text.Trim
      obj_Entidad.NCRRPL = Me.txtCorrelativoJunta.Text.Trim
      obj_Entidad.NRUCTR = Me.txtRucTransportista.Text.Trim
      If Me.txtPlacaVehiculo.Text.Trim.Length > 1 Then
        obj_Entidad.NPLCUN = Me.txtPlacaVehiculo.Text.Trim.Substring(0, Me.txtPlacaVehiculo.Text.Trim.IndexOf(":") - 1).Trim
      End If
      obj_Entidad.NPLCAC = Me.ctbAcoplado.Codigo.Trim
      obj_Entidad.CBRCNT = Me.ctbConductor.Codigo.Trim
      obj_Entidad.CULUSA = MainModule.USUARIO
      obj_Entidad.FULTAC = HelpClass.TodayNumeric
      obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      obj_Entidad.NCSOTR = obj_Logica.Modifica_Solicitud_Detalle(obj_Entidad).NCSOTR
      If obj_Entidad.NCSOTR <> "0" Then
        HelpClass.MsgBox("Se Modifico Satisfactoriamente")
      Else
        HelpClass.ErrorMsgBox()
        Exit Sub
      End If
      Me.Listar()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Listar()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objParametro As New Hashtable
    Dim dwvrow As DataGridViewRow
    Me.gwdDatos.Rows.Clear()
    objParametro.Add("PNNPLNJT", Me.txtNroJunta.Text.Trim)
    objParametro.Add("PNNCRRPL", Me.txtCorrelativoJunta.Text.Trim)
    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_Logica.Listar_Detalle_Solicitud(objParametro)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)
      dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
      dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
      dwvrow.Cells(2).Value = obj_Entidad.CCLNT
      dwvrow.Cells(3).Value = obj_Entidad.TCMPCL
      dwvrow.Cells(4).Value = obj_Entidad.FASGTR
      dwvrow.Cells(5).Value = obj_Entidad.HASGTR
      dwvrow.Cells(6).Value = obj_Entidad.NPLNJT
      dwvrow.Cells(7).Value = obj_Entidad.NCRRPL
      dwvrow.Cells(8).Value = obj_Entidad.NRUCTR
      dwvrow.Cells(10).Value = obj_Entidad.NPLCUN
      dwvrow.Cells(11).Value = obj_Entidad.TDETRA
      dwvrow.Cells(12).Value = obj_Entidad.NPLCAC
      dwvrow.Cells(14).Value = obj_Entidad.CBRCNT
      dwvrow.Cells(16).Value = obj_Entidad.ESTADO
      Me.gwdDatos.Rows.Add(dwvrow)
    Next
    Me.Cargar_Combo("")
  End Sub

  Private Function validar_inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    If Me.txtSolicitud.Text = "" Then
      lstr_validacion = "* NUMERO DE SOLICITUD " & Chr(13)
    End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR : " & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub Limpiar_Controles()
    Me.txtSolicitud.Text = ""
    Me.txtSolicitud.Tag = ""
    Me.dtpFechaAsignacion.Value = Date.Today
    Me.txtHoraAsignacion.Text = ""
    Me.txtPlacaVehiculo.Text = ""
    Me.ctbAcoplado.Limpiar()
    Me.ctbConductor.Limpiar()
    Me.txtRucTransportista.Text = ""
    Me.dtpFechaSolicitud.Value = Date.Today
    Me.txtHoraSolicitud.Text = ""
    Me.txtMercaderia.Text = ""
    Me.txtCantidadMercaderia.Text = ""
    Me.txtServicio.Text = ""
    Me.txtVehiculo.Text = ""
    Me.txtVehiculosSolicitados.Text = ""
    Me.txtVehiculosAtendidos.Text = ""
    Me.txtLocalidadOrigen.Text = ""
    Me.txtLocalidadDestino.Text = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información del Detalle Solicitud"
  End Sub

  Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
    Me.txtSolicitud.Enabled = lbool_Estado
    Me.btnbuscarSolicitud.Enabled = lbool_Estado
    Me.txtPlacaVehiculo.Enabled = lbool_Estado
    Me.btnbuscarVehiculo.Enabled = lbool_Estado
    Me.ctbAcoplado.Enabled = lbool_Estado
    Me.ctbConductor.Enabled = lbool_Estado
  End Sub

  Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      If Me.gwdDatos.Rows.Count > 0 Then
        Me.gwdDatos.CurrentRow.Selected = False
      End If
      MsgBox("Debe guardar el nuevo detalle de solicitud o cancelarla.", MsgBoxStyle.Exclamation)
      Exit Sub
    End If
    Me.Cargar_Combo(Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
    Me.Cargar_Datos_Grilla()
  End Sub

  Private Sub Cargar_Datos_Grilla()
    Me.Limpiar_Controles()
    Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    Me.txtSolicitud.Text = Me.gwdDatos.Item("NCSOTR", lint_indice).Value & " : " & Me.gwdDatos.Item("TCMPCL", lint_indice).Value
    Me.txtPlacaVehiculo.Text = Me.gwdDatos.Item("NPLCUN", lint_indice).Value & " : " & Me.gwdDatos.Item("TDETRA", lint_indice).Value
    Me.dtpFechaAsignacion.Value = Me.gwdDatos.Item("FASGTR", lint_indice).Value
    Me.txtHoraAsignacion.Text = Me.gwdDatos.Item("HASGTR", lint_indice).Value
    Me.txtRucTransportista.Text = Me.gwdDatos.Item("NRUCTR", lint_indice).Value
    Me.ctbAcoplado.Codigo = Me.gwdDatos.Item("NPLCAC", lint_indice).Value
    Me.ctbConductor.Codigo = Me.gwdDatos.Item("CBRCNT", lint_indice).Value
    Me.HeaderDatos.ValuesPrimary.Heading = " Nro Solicitud: " & Me.gwdDatos.Item("NCSOTR", lint_indice).Value & " | Clte : " + Me.txtSolicitud.Text.Trim.Substring(Me.txtSolicitud.Text.Trim.IndexOf(":"), Me.txtSolicitud.Text.Trim.Length - Me.txtSolicitud.Text.Trim.IndexOf(":"))
    Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    Me.btnGuardar.Text = "Modificar"
    Me.btnGuardar.Enabled = True
    Me.btnEliminar.Enabled = True
  End Sub

  Private Sub gwdDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    If Me.gwdDatos.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
      Me.Cargar_Combo(Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
      Me.Cargar_Datos_Grilla()
    End If
  End Sub

  Private Sub Asignar_Valor()
    Dim obj_negocio As New Detalle_Solicitud_Transporte_BLL
    Dim objParamList As New List(Of String)
    objParamList.Add(Me.txtSolicitud.Text.Substring(0, Me.txtSolicitud.Text.IndexOf(":") - 1))
    objParamList.Add("")
    objParamList.Add("")
    objParamList.Add("")
    Dim llist_Solicitud As List(Of Solicitud_Transporte) = obj_negocio.Listar_Cliente_Solicitud(objParamList)
    Me.dtpFechaSolicitud.Value = llist_Solicitud.Item(0).FECOST
    Me.txtHoraSolicitud.Text = llist_Solicitud.Item(0).HRAOTR
    Me.txtServicio.Text = llist_Solicitud.Item(0).CTPOSR
    Me.txtVehiculo.Text = llist_Solicitud.Item(0).CUNDVH
    Me.txtMercaderia.Text = llist_Solicitud.Item(0).CMRCDR
    Me.txtCantidadMercaderia.Text = llist_Solicitud.Item(0).QMRCDR
    Me.txtVehiculosSolicitados.Text = llist_Solicitud.Item(0).QSLCIT
    Me.txtVehiculosAtendidos.Text = llist_Solicitud.Item(0).QATNAN
    Me.txtLocalidadOrigen.Text = llist_Solicitud.Item(0).CLCLOR
    Me.txtLocalidadDestino.Text = llist_Solicitud.Item(0).CLCLDS
  End Sub

  Private Sub Cargar_Combo(ByVal lstr_NumeroRuc As String)
    Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
    Try
      With Me.ctbAcoplado
        .DataSource = HelpClass.GetDataSetNative(obj_logica.Listar_Acoplado_Solicitud(lstr_NumeroRuc))
        .KeyField = "NPLCAC"
        .ValueField = "TOBS"
        .DataBind()
      End With
      With Me.ctbConductor
        .DataSource = HelpClass.GetDataSetNative(obj_logica.Listar_Conductor_Solicitud(lstr_NumeroRuc, "EZ"))
        .KeyField = "CBRCNT"
        .ValueField = "TOBS"
        .DataBind()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Function Llamada_Formulario(ByVal lfrm As ComponentFactory.Krypton.Toolkit.KryptonForm) As Integer
    lfrm.IsMdiContainer = True
    lfrm.Tag = Me.txtNroJunta.Text
    If lfrm.ShowDialog() = Windows.Forms.DialogResult.OK Then
      If lfrm.Name.Trim = "frmBuscarSolicitud" Then
        With lfrm
          Me.txtSolicitud.Text = .TextExtra.Substring(0, lfrm.TextExtra.IndexOf("-") - 1).Trim
          Me.txtSolicitud.Tag = .TextExtra.Substring(lfrm.TextExtra.IndexOf("-") + 1).Trim
          Me.Asignar_Valor()
        End With
      ElseIf lfrm.Name.Trim = "frmBuscarVehiculo" Then
        With lfrm
          Me.txtPlacaVehiculo.Text = .TextExtra.Trim.Substring(0, .TextExtra.IndexOf("-") - 1)
          Me.txtRucTransportista.Text = .TextExtra.Trim.Substring(.TextExtra.IndexOf("-") + 1, .TextExtra.Trim.Length - .TextExtra.IndexOf("-") - 1)
        End With
      End If
      Return 1
    Else
      Return 0
    End If
  End Function

  Private Sub txtSolicitud_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSolicitud.KeyUp
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      Exit Sub
    End If
    If e.KeyCode = Keys.F4 Then
      Dim lfrm_BuscarSolicitud As New frmBuscarSolicitud
      Me.Llamada_Formulario(lfrm_BuscarSolicitud)
    End If
    If e.KeyCode = Keys.Back Then
      Me.txtSolicitud.Text = ""
    End If
  End Sub

  Private Sub btnbuscarSolicitud_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbuscarSolicitud.KeyUp
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      Exit Sub
    End If
    If e.KeyCode = Keys.Enter Then
      Dim lfrm_BuscarSolicitud As New frmBuscarSolicitud
      Me.Llamada_Formulario(lfrm_BuscarSolicitud)
    End If
  End Sub

  Private Sub btnbuscarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarSolicitud.Click
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      Exit Sub
    End If
    Dim lfrm_BuscarSolicitud As New frmBuscarSolicitud
    Me.Llamada_Formulario(lfrm_BuscarSolicitud)
  End Sub

  Private Sub txtPlacaVehiculo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlacaVehiculo.KeyUp
    If e.KeyCode = Keys.F4 Then
      Dim lfrm_BuscarVehiculo As New frmBuscarVehiculo
      Me.ctbAcoplado.Limpiar()
      Me.ctbConductor.Limpiar()
      Me.Llamada_Formulario(lfrm_BuscarVehiculo)
      Me.Cargar_Combo(Me.txtRucTransportista.Text)
      Exit Sub
    End If
    If e.KeyCode = Keys.Back Then
      Me.txtPlacaVehiculo.Text = ""
      Me.txtRucTransportista.Text = ""
      Me.ctbAcoplado.Limpiar()
      Me.ctbConductor.Limpiar()
    End If
  End Sub

  Private Sub btnbuscarVehiculo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbuscarVehiculo.KeyUp
    If e.KeyCode = Keys.Enter Then
      Dim lfrm_BuscarVehiculo As New frmBuscarVehiculo
      Me.ctbAcoplado.Limpiar()
      Me.ctbConductor.Limpiar()
      Me.Llamada_Formulario(lfrm_BuscarVehiculo)
      Me.Cargar_Combo(Me.txtRucTransportista.Text)
    End If
  End Sub

  Private Sub btnbuscarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarVehiculo.Click
    Dim lfrm_BuscarVehiculo As New frmBuscarVehiculo
    Me.ctbAcoplado.Limpiar()
    Me.ctbConductor.Limpiar()
    Me.Llamada_Formulario(lfrm_BuscarVehiculo)
    Me.Cargar_Combo(Me.txtRucTransportista.Text)
  End Sub

  Private Sub txtSolicitud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSolicitud.TextChanged
    If Me.txtSolicitud.Text.Trim.Length > 0 Then
      Me.Asignar_Valor()
    End If
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    gint_Estado = 1
    Me.Close()
  End Sub

  Private Sub btnCerrarJunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarJunta.Click
    If Me.gwdDatos.RowCount = 0 Then
      Me.btnSalir_Click(Nothing, Nothing)
      Exit Sub
    Else
      Dim objeto_logica As New Junta_Transporte_BLL
      Dim obj_Entidad As New Junta_Transporte
      obj_Entidad.NPLNJT = Me.txtNroJunta.Text.Trim
      obj_Entidad.NCRRPL = Me.txtCorrelativoJunta.Text.Trim
      obj_Entidad.SESPLN = "C"
      obj_Entidad.NPLNJT = objeto_logica.Actualizar_Junta_Transporte(obj_Entidad).NPLNJT
      If obj_Entidad.NPLNJT = "-1" Then
        HelpClass.MsgBox("Existe una junta cerrada")
        Exit Sub
      End If
      If obj_Entidad.NPLNJT = "0" Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      Else
        gint_Estado = 2
        Me.Close()
      End If
    End If
  End Sub

  Private Sub btnGenerarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim objAsignacionOrdenServicio As New frmAsignacionOrdenServicio
        'objAsignacionOrdenServicio.ShowDialog(Me)
  End Sub

  Private Sub frmDetalleSolicitudTransporte_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    If gint_Estado = 2 Then Exit Sub
    gint_Estado = 1
  End Sub

  Private Sub btnAsignarTerceros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarTerceros.Click
    If Me.txtSolicitud.TextLength = 0 Then
      HelpClass.MsgBox("Seleccione la solicitud a asignar un tercero")
      Exit Sub
    End If

    If MsgBox("Desea ingresar unidades de terceros", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
      Me.Nuevo_Registro()
      Me.AccionCancelar()
    Else
      Exit Sub
    End If
  End Sub
End Class