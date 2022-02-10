Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports System.Data

Public Class frmJuntaTransporte

#Region "Variables"
    Private gEnum_Mantenimiento As MANTENIMIENTO
  Private _strNPLNJT As String = ""
  Private _strNCRRPL As String = ""
  Private bolBuscar As Boolean
#End Region

#Region "Metodos y Funciones"
    'Enum TAB_SEL
    '    DATO_GENERAL
    '    PROG_UNIDAD
    '    ASIG_UNIDAD
    'End Enum

    Private TabActualSeleccionado As Int32 = 0

    Const TabDatoGeneral As String = "tbInformacionGeneral"
    Const TabAsignarUnidad As String = "tbInformacionJunta"
    Const TabProgUnidad As String = "tabInfoUnidadProgramada"

    '   Case "tbInformacionGeneral" 'DATOS GENERALES
    ''Me.MenuBar.Enabled = True
    '            HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TAB_SEL.DATO_GENERAL)
    '            Me.btnGenerarOperacion.Enabled = False
    '        Case "tabInfoUnidadProgramada"
    '            HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TAB_SEL.PROG_UNIDAD)
    '        Case "tbInformacionJunta" 'UNIDADES ASIGNADAS

    Private Sub frmJuntaTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            kdgvUnidadProgramada.AutoGenerateColumns = False
            gwdDatos.AutoGenerateColumns = False
            dgDatosGeneral.AutoGenerateColumns = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
                Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
            For lint_contador As Integer = 0 To Me.dgDatosGeneral.ColumnCount - 1
                Me.dgDatosGeneral.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
            'Me.btnGuardar.Enabled = False
            'Me.btnCancelar.Enabled = False
            'Me.btnEliminar.Enabled = False
            ckbRangoFechas.Checked = False
            CargarFiltro()
            Limpiar_Datos_General_Junta()
            'Me.Limpiar_Controles()
            'Me.Estado_Controles(False)
            'Me.Alinear_Columnas_Grilla()
            Me.Validar_Acceso_Opciones_Usuario()
            Me.Cargar_Compania()
            'gint_Estado 
            Me.HeaderDatos.ValuesPrimary.Heading = "Información de Junta Transportista"

            HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSolicitudFlete.SelectedTab.Name, Estado_Actual_Junta)
            'HabilitarBotonEstado(ByVal _Tipo As MANTENIMIENTO, ByVal _TAB As String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub HabilitarBotonOpcion(ByVal _Tipo As MANTENIMIENTO, ByVal _TAB As String, ByVal EstadoJunta As String)
        ' CUANDO LA JUNTA SE ENCUENTRE CERRADO 'C' LAS OPCIONES ESTARAN DESABILITADA CASO CONTRARIO SE HABILITAN 
        'DE ACUERDO AL TAB SELECCIONADO.
        Select Case _TAB
            Case TabDatoGeneral
                If EstadoJunta = "C" Then

                    btnNuevo.Enabled = False

                    btnModificar.Visible = True
                    btnGuardar.Visible = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False

                    btnCancelar.Enabled = False
                    btnEliminar.Enabled = False
                    btnAsignacionUnidades.Enabled = False
                    btnProgramarUnidades.Enabled = False
                    btnImprimir.Enabled = True

                    dtpFechaJunta.Enabled = False
                    txtHoraJunta.Enabled = False
                    txtResponsableJunta.Enabled = False
                    txtCantidadJunta.Enabled = False
                    txtDescripcionJunta.Enabled = False

                Else
                    Select Case _Tipo
                        Case MANTENIMIENTO.NEUTRAL
                            btnNuevo.Enabled = True

                            btnModificar.Visible = True
                            btnGuardar.Visible = False
                            btnModificar.Enabled = True
                            btnGuardar.Enabled = False


                            btnCancelar.Enabled = False
                            btnEliminar.Enabled = True
                            btnAsignacionUnidades.Enabled = False
                            btnProgramarUnidades.Enabled = False
                            btnImprimir.Enabled = True

                            dtpFechaJunta.Enabled = False
                            txtHoraJunta.Enabled = False
                            txtResponsableJunta.Enabled = False
                            txtCantidadJunta.Enabled = False
                            txtDescripcionJunta.Enabled = False

                        Case MANTENIMIENTO.NUEVO
                            btnNuevo.Enabled = False

                            btnModificar.Visible = False
                            btnGuardar.Visible = True
                            btnModificar.Enabled = False
                            btnGuardar.Enabled = True

                            btnCancelar.Enabled = True
                            btnEliminar.Enabled = False
                            btnAsignacionUnidades.Enabled = False
                            btnProgramarUnidades.Enabled = False
                            btnImprimir.Enabled = False

                            dtpFechaJunta.Enabled = True
                            txtHoraJunta.Enabled = True
                            txtResponsableJunta.Enabled = True
                            txtCantidadJunta.Enabled = True
                            txtDescripcionJunta.Enabled = True

                        Case MANTENIMIENTO.EDITAR
                            btnNuevo.Enabled = False

                            btnModificar.Visible = False
                            btnGuardar.Visible = True
                            btnModificar.Enabled = False
                            btnGuardar.Enabled = True

                            btnCancelar.Enabled = True
                            btnEliminar.Enabled = False
                            btnAsignacionUnidades.Enabled = False
                            btnProgramarUnidades.Enabled = False
                            btnImprimir.Enabled = False

                            dtpFechaJunta.Enabled = True
                            txtHoraJunta.Enabled = True
                            txtResponsableJunta.Enabled = True
                            txtCantidadJunta.Enabled = True
                            txtDescripcionJunta.Enabled = True
                    End Select
                End If

            Case TabProgUnidad

                If EstadoJunta = "C" Then

                    btnNuevo.Enabled = False
                    btnModificar.Visible = True
                    btnGuardar.Visible = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False

                    btnCancelar.Enabled = False
                    btnEliminar.Enabled = False
                    btnAsignacionUnidades.Enabled = False
                    btnProgramarUnidades.Enabled = False
                    btnImprimir.Enabled = False

                    dtpFechaJunta.Enabled = False
                    txtHoraJunta.Enabled = False
                    txtResponsableJunta.Enabled = False
                    txtCantidadJunta.Enabled = False
                    txtDescripcionJunta.Enabled = False

                Else

                    btnNuevo.Enabled = False
                    btnModificar.Visible = True
                    btnModificar.Enabled = False
                    btnGuardar.Visible = False
                    btnGuardar.Enabled = False

                    btnCancelar.Enabled = False
                    btnEliminar.Enabled = True
                    btnAsignacionUnidades.Enabled = False
                    btnProgramarUnidades.Enabled = True
                    btnImprimir.Enabled = False

                    dtpFechaJunta.Enabled = False
                    txtHoraJunta.Enabled = False
                    txtResponsableJunta.Enabled = False
                    txtCantidadJunta.Enabled = False
                    txtDescripcionJunta.Enabled = False

                  
                End If


            Case TabAsignarUnidad

                If EstadoJunta = "C" Then

                    btnNuevo.Enabled = False
                    btnModificar.Visible = True
                    btnGuardar.Visible = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False

                    btnCancelar.Enabled = False
                    btnEliminar.Enabled = False
                    btnAsignacionUnidades.Enabled = False
                    btnProgramarUnidades.Enabled = False
                    btnImprimir.Enabled = False

                    dtpFechaJunta.Enabled = False
                    txtHoraJunta.Enabled = False
                    txtResponsableJunta.Enabled = False
                    txtCantidadJunta.Enabled = False
                    txtDescripcionJunta.Enabled = False

                Else
                    btnNuevo.Enabled = False
                    btnModificar.Visible = True
                    btnGuardar.Visible = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False

                    btnCancelar.Enabled = False
                    btnEliminar.Enabled = False
                    btnAsignacionUnidades.Enabled = True
                    btnProgramarUnidades.Enabled = False
                    btnImprimir.Enabled = False

                    dtpFechaJunta.Enabled = False
                    txtHoraJunta.Enabled = False
                    txtResponsableJunta.Enabled = False
                    txtCantidadJunta.Enabled = False
                    txtDescripcionJunta.Enabled = False
                End If


        End Select

    End Sub
    'Private Sub Cargar_Datos_Grilla()
    '    'Me.Limpiar_Controles()
    '    Limpiar_Datos_General_Junta()
    '    Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    '    Dim objEntidad As New Junta_Transporte
    '    Dim objJuntaTransporte As New Junta_Transporte_BLL
    '    _strNPLNJT = Me.gwdDatos.Item("NPLNJT", lint_indice).Value
    '    _strNCRRPL = Me.gwdDatos.Item("NCRRPL", lint_indice).Value
    '    Me.dtpFechaJunta.Value = Me.gwdDatos.Item("FPLNJT", lint_indice).Value
    '    Me.txtHoraJunta.Text = Me.gwdDatos.Item("HPLNJT", lint_indice).Value
    '    Me.txtResponsableJunta.Text = Me.gwdDatos.Item("TRSPAT", lint_indice).Value
    '    Me.txtDescripcionJunta.Text = Me.gwdDatos.Item("TDSCPL", lint_indice).Value
    '    Me.txtCantidadJunta.Text = Me.gwdDatos.Item("QCNASI", lint_indice).Value
    '    'Quitar_Valor(Me.gwdDatos.Item("SESPLN", lint_indice).Value.ToString, Me.cboEstadoJunta)
    '    Me.cboEstadoJunta.SelectedValue = Me.gwdDatos.Item("SESPLN", lint_indice).Value
    '    Me.HeaderDatos.ValuesPrimary.Heading = " Nro : " & _strNPLNJT & " | Responsable Junta : " + Me.txtResponsableJunta.Text & " | Estado Junta : " & Me.cboEstadoJunta.Text
    '    'If Me.gwdDatos.Item("SESPLN", lint_indice).Value.ToString = "P" Then
    '    '  Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '    '  Me.btnGuardar.Text = "Modificar"
    '    '  Me.btnGuardar.Enabled = True
    '    '  Me.btnEliminar.Enabled = True
    '    'Else
    '    '  Me.btnGuardar.Text = "Guardar"
    '    '  Me.btnGuardar.Enabled = False
    '    '  Me.btnEliminar.Enabled = False
    '    'End If
    'End Sub

    Private Sub Listar_Solicitudes_Asignadas_X_Junta_Transportista()
        Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
        Dim objParametro As New Hashtable
        Dim dwvrow As DataGridViewRow
        Me.dgDatosGeneral.Rows.Clear()

        objParametro.Add("PNNPLNJT", Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
        objParametro.Add("PNNCRRPL", Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
        'objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objParametro.Add("PSCCMPN", Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)


        Dim Fila As Int32 = 0
        Dim oListDetSolicitudTransporte As New List(Of Detalle_Solicitud_Transporte)
        oListDetSolicitudTransporte = obj_Logica.Listar_Detalle_Solicitud(objParametro)
        For Each obj_Entidad As Detalle_Solicitud_Transporte In oListDetSolicitudTransporte
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dgDatosGeneral)
            Me.dgDatosGeneral.Rows.Add(dwvrow)
            Fila = dgDatosGeneral.Rows.Count - 1

            'dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
            'dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
            'dwvrow.Cells(2).Value = obj_Entidad.CCLNT
            'dwvrow.Cells(3).Value = obj_Entidad.TCMPCL
            'dwvrow.Cells(4).Value = obj_Entidad.RUTA
            'dwvrow.Cells(5).Value = obj_Entidad.FASGTR
            'dwvrow.Cells(6).Value = obj_Entidad.HASGTR
            'dwvrow.Cells(7).Value = obj_Entidad.NPLNJT
            'dwvrow.Cells(8).Value = obj_Entidad.NCRRPL

            dgDatosGeneral.Rows(Fila).Cells("G_NCSOTR").Value = obj_Entidad.NCSOTR
            dgDatosGeneral.Rows(Fila).Cells("G_NCRRSR").Value = obj_Entidad.NCRRSR
            dgDatosGeneral.Rows(Fila).Cells("G_CCLNT").Value = obj_Entidad.CCLNT
            dgDatosGeneral.Rows(Fila).Cells("G_TCMPCL").Value = obj_Entidad.TCMPCL
            dgDatosGeneral.Rows(Fila).Cells("RUTA").Value = obj_Entidad.RUTA
            dgDatosGeneral.Rows(Fila).Cells("G_FASGTR").Value = obj_Entidad.FASGTR
            dgDatosGeneral.Rows(Fila).Cells("G_HASGTR").Value = obj_Entidad.HASGTR
            dgDatosGeneral.Rows(Fila).Cells("G_NPLNJT").Value = obj_Entidad.NPLNJT
            dgDatosGeneral.Rows(Fila).Cells("G_NCRRPL").Value = obj_Entidad.NCRRPL


            'dwvrow.Cells(9).Value = obj_Entidad.NRUCTR
            'dwvrow.Cells(11).Value = obj_Entidad.NPLCUN
            'dwvrow.Cells(12).Value = obj_Entidad.TDETRA
            'dwvrow.Cells(13).Value = obj_Entidad.NPLCAC
            'dwvrow.Cells(15).Value = obj_Entidad.CBRCNT
            'dwvrow.Cells(17).Value = obj_Entidad.ESTADO
            'dwvrow.Cells(18).Value = obj_Entidad.NOPRCN
            'dwvrow.Cells(19).Value = obj_Entidad.NPLNMT
            'dwvrow.Cells(20).Value = obj_Entidad.NORINS
            'dwvrow.Cells(22).Value = obj_Entidad.CBRCN2

            dgDatosGeneral.Rows(Fila).Cells("G_NRUCTR").Value = obj_Entidad.NRUCTR
            dgDatosGeneral.Rows(Fila).Cells("G_NPLCUN").Value = obj_Entidad.NPLCUN
            dgDatosGeneral.Rows(Fila).Cells("G_TDETRA").Value = obj_Entidad.TDETRA
            dgDatosGeneral.Rows(Fila).Cells("G_NPLCAC").Value = obj_Entidad.NPLCAC
            dgDatosGeneral.Rows(Fila).Cells("G_CBRCNT").Value = obj_Entidad.CBRCNT
            dgDatosGeneral.Rows(Fila).Cells("G_ESTADO").Value = obj_Entidad.ESTADO
            dgDatosGeneral.Rows(Fila).Cells("NOPRCN").Value = obj_Entidad.NOPRCN
            dgDatosGeneral.Rows(Fila).Cells("NPLNMT").Value = obj_Entidad.NPLNMT
            dgDatosGeneral.Rows(Fila).Cells("NORINS").Value = obj_Entidad.NORINS
            dgDatosGeneral.Rows(Fila).Cells("CBRCN2").Value = obj_Entidad.CBRCN2


            'dwvrow.Cells(23).Value = obj_Entidad.GPSLAT
            'dwvrow.Cells(24).Value = obj_Entidad.GPSLON
            'dwvrow.Cells(25).Value = obj_Entidad.FECGPS
            'dwvrow.Cells(26).Value = obj_Entidad.HORGPS
            'dwvrow.Cells(27).Value = Lista.Images.Item(4)
            'dwvrow.Cells(28).Value = obj_Entidad.SEGUIMIENTO

            dgDatosGeneral.Rows(Fila).Cells("GPSLAT").Value = obj_Entidad.GPSLAT
            dgDatosGeneral.Rows(Fila).Cells("GPSLON").Value = obj_Entidad.GPSLON
            dgDatosGeneral.Rows(Fila).Cells("FECGPS").Value = obj_Entidad.FECGPS
            dgDatosGeneral.Rows(Fila).Cells("HORGPS").Value = obj_Entidad.HORGPS
            dgDatosGeneral.Rows(Fila).Cells("Column1").Value = Lista.Images.Item(4)
            dgDatosGeneral.Rows(Fila).Cells("SEGUIMIENTO").Value = obj_Entidad.SEGUIMIENTO

            If obj_Entidad.NORINS.Trim.ToString = "" OrElse obj_Entidad.NORINS <= 0 Then
                'dwvrow.Cells(20).Style.ForeColor = Color.Blue
                'dwvrow.Cells(20).Value = "Enviar SAP"
                'dwvrow.Cells(20).ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
                dgDatosGeneral.Rows(Fila).Cells("NORINS").Style.ForeColor = Color.Blue
                dgDatosGeneral.Rows(Fila).Cells("NORINS").Value = "Enviar SAP"
                dgDatosGeneral.Rows(Fila).Cells("NORINS").ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
            End If
            'dwvrow.Cells(21).Value = Lista.Images.Item(0)
            dgDatosGeneral.Rows(Fila).Cells("MODIFICAR").Value = Lista.Images.Item(0)
            'Me.dgDatosGeneral.Rows.Add(dwvrow)
        Next
    End Sub

    'Private Sub Eliminar_Junta_Transporte()
    '  Dim obj_Entidad As New Junta_Transporte
    '  Dim obj_Logica As New Junta_Transporte_BLL
    '      'Try
    '      obj_Entidad.NPLNJT = _strNPLNJT
    '      obj_Entidad.NCRRPL = _strNCRRPL
    '      obj_Entidad.CULUSA = MainModule.USUARIO
    '      obj_Entidad.FULTAC = HelpClass.TodayNumeric
    '      obj_Entidad.HULTAC = HelpClass.NowNumeric
    '      obj_Entidad.NTRMNL = HelpClass.NombreMaquina
    '      obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
    '      obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
    '      obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue

    '      obj_Entidad.NPLNJT = obj_Logica.Eliminar_Junta_Transporte(obj_Entidad).NPLNJT
    '      If obj_Entidad.NPLNJT <> "0" Then
    '          HelpClass.MsgBox("Se eliminó satisfactoriamente")
    '      Else
    '          HelpClass.ErrorMsgBox()
    '          Exit Sub
    '      End If
    '      Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '      Me.Listar(obj_Entidad.NPLNJT)

    '      Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
    '      HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TabSeleccionado)
    '      'Me.AccionCancelar()
    '      'Catch ex As Exception
    '      '    End Try
    'End Sub

    'Private Sub Nueva_Junta()
    '    Dim obj_Entidad As New Junta_Transporte
    '    Dim obj_Logica As New Junta_Transporte_BLL
    '    'Try
    '    obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
    '    obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
    '    obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
    '    obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
    '    obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
    '    'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
    '    obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
    '    obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
    '    obj_Entidad.CDVSN = Me.cboDivision.SelectedValue.ToString.Trim
    '    obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
    '    obj_Entidad.CUSCRT = MainModule.USUARIO
    '    obj_Entidad.FCHCRT = HelpClass.TodayNumeric
    '    obj_Entidad.HRACRT = HelpClass.NowNumeric
    '    obj_Entidad.NTRMCR = HelpClass.NombreMaquina
    '    obj_Entidad.NPLNJT = obj_Logica.Registrar_Junta_Transporte(obj_Entidad).NPLNJT
    '    MessageBox.Show("Se registró satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    'Me.ddlEstado.SelectedValue = "P"
    '    Listar_Junta(obj_Entidad.NPLNJT)

    '    'If obj_Entidad.NPLNJT <> "0" Then
    '    '    'HelpClass.MsgBox("Se registró satisfactoriamente")
    '    '    MessageBox.Show("Se registró satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    Me.ddlEstado.SelectedValue = "P"
    '    '    Listar_Junta(obj_Entidad.NPLNJT)
    '    '    'Me.ddlEstado.SelectedIndex = 0
    '    '    'Else
    '    '    '  HelpClass.ErrorMsgBox()
    '    'End If
    '    ''Catch ex As Exception
    '    ''    End Try
    'End Sub

    'Private Sub Modificar_Junta()
    '    Dim obj_Entidad As New Junta_Transporte
    '    Dim obj_Logica As New Junta_Transporte_BLL
    '    'Try
    '    obj_Entidad.NPLNJT = _strNPLNJT
    '    obj_Entidad.NCRRPL = _strNCRRPL
    '    obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
    '    obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
    '    obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
    '    obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
    '    obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
    '    'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
    '    obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
    '    obj_Entidad.CULUSA = MainModule.USUARIO
    '    obj_Entidad.FULTAC = HelpClass.TodayNumeric
    '    obj_Entidad.HULTAC = HelpClass.NowNumeric
    '    obj_Entidad.NTRMNL = HelpClass.NombreMaquina
    '    obj_Entidad.NPLNJT = obj_Logica.Modificar_Junta_Transporte(obj_Entidad).NPLNJT
    '    HelpClass.MsgBox("Se modificó satisfactoriamente")
    '    Listar_Junta(obj_Entidad.NPLNJT)
    '    'If obj_Entidad.NPLNJT <> "0" Then
    '    '    HelpClass.MsgBox("Se modificó satisfactoriamente")
    '    '    Listar_Junta(obj_Entidad.NPLNJT)
    '    'Else
    '    '    HelpClass.ErrorMsgBox()
    '    'End If
    '    'Catch ex As Exception
    '    '    End Try
    'End Sub

    'Private Function Asignar_Valor(ByVal lcontrol As ComponentFactory.Krypton.Toolkit.KryptonComboBox) As String
    '  Dim cadena As String = ""
    '      'If lcontrol.SelectedIndex = 0 Then
    '      '  cadena = "P"
    '      'ElseIf lcontrol.SelectedIndex = 1 Then
    '      '  cadena = "C"
    '      'ElseIf lcontrol.SelectedIndex = 2 Then
    '      '  cadena = ""
    '      'End If
    '      If lcontrol.SelectedValue = "0" Then
    '          cadena = ""
    '      Else
    '          cadena = lcontrol.SelectedValue
    '      End If
    '  Return cadena
    'End Function

    'Private Sub Quitar_Valor(ByVal lstr As String, ByVal lcontrol As ComponentFactory.Krypton.Toolkit.KryptonComboBox)
    '    If lstr.Trim = "P" Then
    '        lcontrol.SelectedIndex = 0
    '    ElseIf lstr.Trim = "C" Then
    '        lcontrol.SelectedIndex = 1
    '    ElseIf lstr.Trim = "" Then
    '        lcontrol.SelectedIndex = 2
    '    End If
    'End Sub

    Public Sub Listar_Junta(ByVal lstr_NroJunta As String)

        Me.dgDatosGeneral.Rows.Clear()
        kdgvUnidadProgramada.DataSource = Nothing
        Limpiar_Datos_General_Junta()

        Dim obj_Logica As New Junta_Transporte_BLL
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        'If gEnum_Mantenimiento <> MANTENIMIENTO.NEUTRAL Then
        'objParamList.Add(lstr_NroJunta)
        ''objParamList.Add(Asignar_Valor(Me.ddlEstado))

        'If ddlEstado.SelectedValue = "0" Then
        '    objParamList.Add("")
        'Else
        '    objParamList.Add(ddlEstado.SelectedValue)
        'End If
        'objParamList.Add("")
        'objParamList.Add("")
        'objParamList.Add(Me.cboCompania.SelectedValue)
        'objParamList.Add(Me.cboDivision.SelectedValue)
        'objParamList.Add(Me.cboPlanta.SelectedValue)
        'Else
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objParamList.Add(Me.txtNroJunta.Text.Trim)
        'objParamList.Add(Asignar_Valor(Me.ddlEstado))
        If ddlEstado.SelectedValue = "0" Then
            objParamList.Add("")
        Else
            objParamList.Add(ddlEstado.SelectedValue)
        End If
        objParamList.Add(lstr_FecIni)
        objParamList.Add(lstr_FecFin)
        objParamList.Add(Me.cboCompania.SelectedValue)
        objParamList.Add(Me.cboDivision.SelectedValue)
        objParamList.Add(Me.cboPlanta.SelectedValue)
        'End If
        Me.gwdDatos.DataSource = obj_Logica.Listar_Junta_Transporte(objParamList)
        If gwdDatos.Rows.Count = 0 Then
            Limpiar_Datos_General_Junta()
            dgDatosGeneral.Rows.Clear()
            kdgvUnidadProgramada.DataSource = Nothing
        End If
        'Me.btnGuardar.Text = "Guardar"
    End Sub

    Private Function Validar_Ingreso_Junta() As String
        Dim lstr_validacion As String = ""
        txtCantidadJunta.Text = txtCantidadJunta.Text.Trim
        'Dim lbool_existe_error As Boolean = False
        If Me.txtResponsableJunta.Text = "" Then
            lstr_validacion = "* Responsable de Junta"
        End If
        Dim QJunta As Decimal = 0
        Decimal.TryParse(txtCantidadJunta.Text, QJunta)
        If QJunta = 0 Then
            lstr_validacion = lstr_validacion & Chr(13) & "* La cantidad de asistentes debe ser mayor cero(0)." & Chr(13)
        End If

        'If Me.cboEstadoJunta.SelectedIndex = 3 Then
        '  lstr_validacion += "* ESTADO DE JUNTA" & Chr(13)
        'End If
        'If lstr_validacion <> "" Then
        'HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
        'lbool_existe_error = True

        'End If
        Return lstr_validacion.Trim
    End Function

    'Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
    '  Me.txtResponsableJunta.Enabled = lbool_Estado
    '  Me.txtCantidadJunta.Enabled = lbool_Estado
    '  Me.txtDescripcionJunta.Enabled = lbool_Estado
    'End Sub

    Private Sub Limpiar_Datos_General_Junta()
        Me.txtHoraJunta.Text = ""
        Me.txtResponsableJunta.Text = ""
        Me.txtCantidadJunta.Text = ""
        Me.cboEstadoJunta.SelectedValue = "P"
        'Me.cboEstadoJunta.SelectedIndex = 3
        'Me.cboEstadoJunta.SelectedValue = "P"
        Me.txtDescripcionJunta.Text = ""
        'Me.HeaderDatos.ValuesPrimary.Heading = "Información de Junta Transportista"
    End Sub

    'Private Sub AccionCancelar()
    '  Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '  Me.Limpiar_Controles()
    '  Me.Estado_Controles(False)
    '  If Me.gwdDatos.Rows.Count > 0 Then
    '    Me.gwdDatos.CurrentRow.Selected = False
    '  End If
    '  Me.btnNuevo.Enabled = True
    '  Me.btnGuardar.Enabled = False
    '  Me.btnCancelar.Enabled = False
    '  Me.btnEliminar.Enabled = False
    '  Me.dgDatosGeneral.Rows.Clear()
    'End Sub

    'Private Sub Alinear_Columnas_Grilla()
    '  Me.gwdDatos.AutoGenerateColumns = False
    '  Me.dgDatosGeneral.AutoGenerateColumns = False
    '  For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
    '    Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next
    '  For lint_contador As Integer = 0 To Me.dgDatosGeneral.ColumnCount - 1
    '    Me.dgDatosGeneral.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '  Next

    '  'Alineando el orden de las Columnas
    '      'Me.dgDatosGeneral.Columns.Item(0).DisplayIndex = 0
    '      'Me.dgDatosGeneral.Columns.Item(3).DisplayIndex = 1
    '      'Me.dgDatosGeneral.Columns.Item(4).DisplayIndex = 2
    '      'Me.dgDatosGeneral.Columns.Item(9).DisplayIndex = 3
    '      'Me.dgDatosGeneral.Columns.Item(11).DisplayIndex = 4
    '      'Me.dgDatosGeneral.Columns.Item(13).DisplayIndex = 5
    '      'Me.dgDatosGeneral.Columns.Item(15).DisplayIndex = 6
    '      'Me.dgDatosGeneral.Columns.Item(22).DisplayIndex = 7
    '      'Me.dgDatosGeneral.Columns.Item(18).DisplayIndex = 8
    '      'Me.dgDatosGeneral.Columns.Item(19).DisplayIndex = 9
    '      'Me.dgDatosGeneral.Columns.Item(20).DisplayIndex = 10
    '      'Me.dgDatosGeneral.Columns.Item(21).DisplayIndex = 11
    '      'Me.dgDatosGeneral.Columns.Item(5).DisplayIndex = 12
    '      'Me.dgDatosGeneral.Columns.Item(6).DisplayIndex = 13

    'End Sub

  'Private Sub Asignacion_Individual()
  '  Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
  '  Dim lfrm_DetalleSolicitud As New frmDetalleSolicitudTransporte
  '  Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
  '  lfrm_DetalleSolicitud.MdiParent = Me.Parent.Parent
  '  Try
  '    With lfrm_DetalleSolicitud
  '      .txtNroJunta.Text = Me.gwdDatos.Item("NPLNJT", lint_Indice).Value
  '      .txtCorrelativoJunta.Text = Me.gwdDatos.Item("NCRRPL", lint_Indice).Value
  '      .txtFechaJunta.Text = Me.gwdDatos.Item("FPLNJT", lint_Indice).Value
  '      .txtHoraJunta.Text = Me.gwdDatos.Item("HPLNJT", lint_Indice).Value
  '      .txtResponsableJunta.Text = Me.gwdDatos.Item("TRSPAT", lint_Indice).Value
  '      .txtDescripcionJunta.Text = Me.gwdDatos.Item("TDSCPL", lint_Indice).Value
  '      .gwdDatos.AutoGenerateColumns = False
  '      Dim dwvrow As DataGridViewRow
  '      Dim objParametro As New Hashtable
  '      objParametro.Add("PNNPLNJT", Me.gwdDatos.Item("NPLNJT", lint_Indice).Value.ToString.Trim)
  '      objParametro.Add("PNNCRRPL", Me.gwdDatos.Item("NCRRPL", lint_Indice).Value.ToString.Trim)
  '      Dim llist_Entidad As List(Of Detalle_Solicitud_Transporte) = obj_Logica.Listar_Detalle_Solicitud(objParametro)
  '      For Each obj_Entidad As Detalle_Solicitud_Transporte In llist_Entidad
  '        dwvrow = New DataGridViewRow
  '        dwvrow.CreateCells(.gwdDatos)
  '        dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
  '        dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
  '        dwvrow.Cells(2).Value = obj_Entidad.CCLNT
  '        dwvrow.Cells(3).Value = obj_Entidad.TCMPCL
  '        dwvrow.Cells(4).Value = obj_Entidad.FASGTR
  '        dwvrow.Cells(5).Value = obj_Entidad.HASGTR
  '        dwvrow.Cells(6).Value = obj_Entidad.NPLNJT
  '        dwvrow.Cells(7).Value = obj_Entidad.NCRRPL
  '        dwvrow.Cells(8).Value = obj_Entidad.NRUCTR
  '        dwvrow.Cells(10).Value = obj_Entidad.NPLCUN
  '        dwvrow.Cells(11).Value = obj_Entidad.TDETRA
  '        dwvrow.Cells(12).Value = obj_Entidad.NPLCAC
  '        dwvrow.Cells(14).Value = obj_Entidad.CBRCNT
  '        dwvrow.Cells(16).Value = obj_Entidad.ESTADO
  '        .gwdDatos.Rows.Add(dwvrow)
  '      Next
  '      If Me.gwdDatos.Item(7, lint_Indice).Value.ToString <> "P" Then
  '        .MenuBar.Enabled = False
  '        .btnCerrarJunta.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
  '      End If
  '      If .gwdDatos.RowCount > 0 Then
  '        .gwdDatos.CurrentRow.Selected = False
  '      End If
  '      .WindowState = FormWindowState.Maximized
  '      .Show()
  '    End With
  '  Catch ex As Exception
  '  End Try
  'End Sub

    'Private Sub Asignacion_Masiva()
    '  Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    '  Dim lfrm_DetalleSolicitud As New frmDetalleSolicitudTransporte_1
    '  Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    '  lfrm_DetalleSolicitud.MdiParent = Me.Parent.Parent

    '      With lfrm_DetalleSolicitud
    '          .txtNroJunta.Text = Me.gwdDatos.Item("NPLNJT", lint_Indice).Value
    '          .txtCorrelativoJunta.Text = Me.gwdDatos.Item("NCRRPL", lint_Indice).Value
    '          .txtFechaJunta.Text = Me.gwdDatos.Item("FPLNJT", lint_Indice).Value
    '          .txtHoraJunta.Text = Me.gwdDatos.Item("HPLNJT", lint_Indice).Value
    '          .txtResponsableJunta.Text = Me.gwdDatos.Item("TRSPAT", lint_Indice).Value
    '          .txtDescripcionJunta.Text = Me.gwdDatos.Item("TDSCPL", lint_Indice).Value
    '          ._obj_Entidad.CCMPN = Me.gwdDatos.Item("CCMPN", lint_Indice).Value
    '          ._obj_Entidad.CDVSN = Me.gwdDatos.Item("CDVSN", lint_Indice).Value
    '          ._obj_Entidad.CPLNDV = Me.gwdDatos.Item("CPLNDV", lint_Indice).Value

    '          'If Me.gwdDatos.Item(7, lint_Indice).Value.ToString <> "P" Then
    '          '  .ctbTransportista.Enabled = False
    '          '  .ctbTipoCarroceria.Enabled = False
    '          '  .txtVehiculo.Enabled = False
    '          '  .MenuBar.Enabled = False
    '          '  .btnBuscarVehiculo.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    '          'End If
    '          .WindowState = FormWindowState.Maximized
    '          .Show()
    '      End With
    '      'Catch ex As Exception
    '      '    End Try
    'End Sub

    'Private Sub Imprimir(ByVal objParamList As List(Of String))
    '  Dim objRep As New Junta_Transporte_BLL
    '  Dim objCrep As New rptJuntaTransportista
    '  Dim objDt As DataTable
    '  Dim objDs As New DataSet
    '  Dim objPrintForm As New PrintForm
    '      'Try
    '      objDt = HelpClass.GetDataSetNative(objRep.Listar_Junta_Transporte_Detalle(objParamList))
    '      If objDt.Rows.Count = 0 Then
    '          HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
    '          Exit Sub
    '      End If
    '      objDt.TableName = "RZST21"
    '      'objDt.WriteXml("D:\xlee.xml")
    '      objDs.Tables.Add(objDt.Copy)
    '      objCrep.SetDataSource(objDs)
    '      objPrintForm.ShowForm(objCrep, Me)
    '      'Catch ex As Exception
    '      '    End Try
    'End Sub

    'Private Sub Registrar_Operacion_Transporte(ByVal OrdenServicio As String)
    '  Try
    '    'Objetos para referenciar parametros del Stored Procedure
    '    Dim objEntidad As New List(Of String)
    '    'Clase DAO para acceso a la capa de Negocio y Datos
    '    Dim objOperacionTransporte As New OperacionTransporte_BLL
    '    'resultado local
    '    Dim lstr_resultado As String = ""
    '    'Variable que retiene el indice seleccionado
    '    Dim lint_indice As Integer = dgDatosGeneral.CurrentCellAddress.Y
    '    'Numero de Operacion (En el caso que la solicitud ya tenga uno generado)
    '    Dim lint_nrooperacion As Double = 0
    '    'Lista Temporal para analizar si es que la solicitud ya tiene numero de operacion generado
    '    Dim objListaTemporal As New List(Of String)
    '    Dim objEntidadOperacion As New OperacionTransporte

    '    objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)  'PARAM_NPLNJT
    '    objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)  'PARAM_NCRRPL 
    '    objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)  'PARAM_NCSOTR 
    '    objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)  'PARAM_NCRRSR 
    '    objEntidad.Add(OrdenServicio)  'PARAM_NORSRT 
    '    objEntidad.Add(Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Compañia"))  PARAM_CCMPN 
    '    objEntidad.Add(Me.gwdDatos.Item("CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Division"))  PARAM_CDVSN 
    '    objEntidad.Add(Me.gwdDatos.Item("CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Planta"))  'PARAM_CPLNDV 
    '    objEntidad.Add(MainModule.USUARIO)  'PARAM_CUSCRT 
    '    objEntidad.Add(HelpClass.TodayNumeric)  'PARAM_FCHCRT 
    '    objEntidad.Add(HelpClass.NowNumeric)  'PARAM_HRACRT 
    '    objEntidad.Add(HelpClass.NombreMaquina)  'PARAM_NTRMCR 
    '    'Validando la Existencia de la Operación 
    '    objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)
    '    objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)
    '    objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)
    '    objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)

    '    lint_nrooperacion = CInt(objOperacionTransporte.Verificacion_Existencia_Operacion_Solicitud(objListaTemporal))
    '    If lint_nrooperacion > 0 Then
    '      HelpClass.MsgBox("Este Item ya tiene Operación Generada es el Nro " & lint_nrooperacion)
    '      Exit Sub
    '    End If
    '    'Dim objForm As New frmOpRegistroOperacion
    '    'objForm.showForm(Me)
    '    'If objForm.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '    'obteniendo si es que el usuario desea reutilizar la misma operacion y el mismo planeamiento
    '    'objEntidad.Add(objForm.Respuesta)
    '    objEntidad.Add("NUEVO")
    '    lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
    '    objEntidadOperacion.NOPRCN = lstr_resultado
    '    'Obteniendo los datos del planeamiento
    '    objEntidadOperacion = objOperacionTransporte.Obtener_Numero_Planeamiento(objEntidadOperacion)
    '    If lstr_resultado = "-1" Then
    '      HelpClass.ErrorMsgBox()
    '      Exit Sub
    '    Else
    '      HelpClass.MsgBox("Operación Generada N° " & lstr_resultado)
    '      'Imprimiendo los datos de la operacion y orden interna generadas
    '      Me.dgDatosGeneral.Rows(lint_indice).Cells(18).Value = objEntidadOperacion.NOPRCN
    '      Me.dgDatosGeneral.Rows(lint_indice).Cells(19).Value = objEntidadOperacion.NPLNMT
    '      'Generando la Orden Interna
    '      Me.Generar_Orden_Interna()
    '    End If
    '    'Sub rutina para imprimir la operacion
    '  Catch ex As Exception
    '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
    '  End Try
    'End Sub


    Private Sub Registrar_Operacion_Transporte(ByVal OrdenServicio As String)
        'Try
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

        ' objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)  'PARAM_NPLNJT
        objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NPLNJT").Value.ToString.Trim)  'PARAM_NPLNJT
        'objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)  'PARAM_NCRRPL 
        objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCRRP").Value.ToString.Trim)  'PARAM_NCRRPL 
        'objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)  'PARAM_NCSOTR 
        objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCSOTR").Value.ToString.Trim)  'PARAM_NCSOTR 
        'objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)  'PARAM_NCRRSR 
        objEntidad.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCRRSR").Value.ToString.Trim)  'PARAM_NCRRSR 
        objEntidad.Add(OrdenServicio)  'PARAM_NORSRT 
        objEntidad.Add(Me.gwdDatos.Item("CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Compañia"))  PARAM_CCMPN 
        objEntidad.Add(Me.gwdDatos.Item("CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Division"))  PARAM_CDVSN 
        objEntidad.Add(Me.gwdDatos.Item("CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value) 'HelpClass.getSetting("Planta"))  'PARAM_CPLNDV 
        objEntidad.Add(MainModule.USUARIO)  'PARAM_CUSCRT 
        objEntidad.Add(HelpClass.TodayNumeric)  'PARAM_FCHCRT 
        objEntidad.Add(HelpClass.NowNumeric)  'PARAM_HRACRT 
        objEntidad.Add(Ransa.Utilitario.HelpClass.NombreMaquina)  'PARAM_NTRMCR 
        'Validando la Existencia de la Operación 
        'objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(0).Value.ToString.Trim)
        objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCSOTR").Value.ToString.Trim)
        'objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(1).Value.ToString.Trim)
        objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCRRSR").Value.ToString.Trim)
        'objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(7).Value.ToString.Trim)
        objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NPLNJT").Value.ToString.Trim)
        'objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells(8).Value.ToString.Trim)
        objListaTemporal.Add(Me.dgDatosGeneral.Rows(lint_indice).Cells("G_NCRRPL").Value.ToString.Trim)


        lint_nrooperacion = CInt(objOperacionTransporte.Verificacion_Existencia_Operacion_Solicitud(objListaTemporal))
        If lint_nrooperacion > 0 Then
            HelpClass.MsgBox("Este Item ya tiene Operación Generada es el Nro " & lint_nrooperacion)
            Exit Sub
        End If
        'Dim objForm As New frmOpRegistroOperacion
        'objForm.showForm(Me)
        'If objForm.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        'obteniendo si es que el usuario desea reutilizar la misma operacion y el mismo planeamiento
        'objEntidad.Add(objForm.Respuesta)
        objEntidad.Add("NUEVO")
        'lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
        objEntidadOperacion.NOPRCN = lstr_resultado
        'Obteniendo los datos del planeamiento
        objEntidadOperacion = objOperacionTransporte.Obtener_Numero_Planeamiento(objEntidadOperacion)
        If lstr_resultado = "-1" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            HelpClass.MsgBox("Operación Generada N° " & lstr_resultado)
            'Imprimiendo los datos de la operacion y orden interna generadas
            'Me.dgDatosGeneral.Rows(lint_indice).Cells(18).Value = objEntidadOperacion.NOPRCN
            Me.dgDatosGeneral.Rows(lint_indice).Cells("NOPRCN").Value = objEntidadOperacion.NOPRCN
            'Me.dgDatosGeneral.Rows(lint_indice).Cells(19).Value = objEntidadOperacion.NPLNMT
            Me.dgDatosGeneral.Rows(lint_indice).Cells("NPLNMT").Value = objEntidadOperacion.NPLNMT
            'Generando la Orden Interna
            Me.Generar_Orden_Interna()
        End If
        'Sub rutina para imprimir la operacion
        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
        'End Try
    End Sub


  Private Function Validar_Recursos_Asignados(ByVal lint_indice As Integer) As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False
    'Evaluando la Asignación: Tracto, Acoplado y Conductor
        'If Me.dgDatosGeneral.Item(11, lint_indice).Value.ToString = "" Then
        '  lstr_validacion += "* TRACTO" & Chr(13)
        'End If
        If Me.dgDatosGeneral.Item("G_NPLCUN", lint_indice).Value.ToString = "" Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If
        'If Me.dgDatosGeneral.Item(15, lint_indice).Value.ToString = "" Then
        '  lstr_validacion += "* CONDUCTOR" & Chr(13)
        'End If
        If Me.dgDatosGeneral.Item("G_CBRCNT", lint_indice).Value.ToString = "" Then
            lstr_validacion += "* CONDUCTOR" & Chr(13)
        End If
    If lstr_validacion <> "" Then
      HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub Enviar_Orden_Interna_SAP()
        'If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value.ToString.Trim = "0" Then
        '  HelpClass.MsgBox("No Tiene Operación Asignada")
        '  Exit Sub
        'End If
        If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NOPRCN").Value.ToString.Trim = "0" Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        'If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value & " ?") = Windows.Forms.DialogResult.No Then
        '  Exit Sub
        'End If
        If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NOPRCN").Value & " ?") = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    Generar_Orden_Interna()
  End Sub

  Private Sub Generar_Orden_Interna()
    If Me.dgDatosGeneral.CurrentRow Is Nothing OrElse Me.dgDatosGeneral.CurrentCellAddress.Y = -1 Then
      Exit Sub
    End If
        'If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(18).Value.ToString.Trim = "0" Then
        '  HelpClass.MsgBox("No Tiene Operación Asignada")
        '  Exit Sub
        'End If
        If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NOPRCN").Value.ToString.Trim = "0" Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        'If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString.Trim <> "0" AndAlso Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString.Trim <> "Enviar SAP" Then
        '  HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " + Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value.ToString)
        '  Exit Sub
        'End If

        If Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NORINS").Value.ToString.Trim <> "0" AndAlso Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NORINS").Value.ToString.Trim <> "Enviar SAP" Then
            HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " + Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NORINS").Value.ToString)
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
    objParametros.Add(Me.cboCompania.SelectedValue)
        'objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
    If objEntidad.NORINS <> 0 Then
      HelpClass.MsgBox("Orden Interna N° " + CStr(objEntidad.NORINS) + " se envió al SAP satisfactoriamente")
    End If
        'Imprimiendo el numero de orden interna
        'NORINS
        'Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Value = objEntidad.NORINS
        'Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells(20).Style.ForeColor = Color.Black
        Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NORINS").Value = objEntidad.NORINS
        Me.dgDatosGeneral.Rows(Me.dgDatosGeneral.CurrentCellAddress.Y).Cells("NORINS").Style.ForeColor = Color.Black
  End Sub

  Private Sub Validar_Acceso_Opciones_Usuario()
    Dim objParametro As New Hashtable
    Dim objLogica As New Acceso_Opciones_Usuario_BLL
    Dim objEntidad As New ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

    If objEntidad.STSADI = "" Then
      Me.btnNuevo.Visible = False
      Me.Separator1.Visible = False
    End If
    If objEntidad.STSCHG = "" Then
      Me.btnGuardar.Visible = False
      Me.Separator2.Visible = False
    End If
    If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
      Me.btnCancelar.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSELI = "" Then
      Me.btnEliminar.Visible = False
      Me.Separator5.Visible = False
    End If
    If objEntidad.STSOP1 = "" Then
      Me.btnCerrarJunta.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      Me.btnAsignacionUnidades.Visible = False
    End If
    If objEntidad.STSOP3 = "" Then
      Me.btnGenerarOperacion.Visible = False
    End If

  End Sub

  Private Sub Cargar_Compania()
    Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
    objCompaniaBLL.Crea_Lista()
    bolBuscar = False
    cboCompania.DataSource = objCompaniaBLL.Lista
    cboCompania.ValueMember = "CCMPN"
        cboCompania.DisplayMember = "TCMPCM"
        'cboCompania.SelectedValue = "EZ"
        bolBuscar = True
        'cboCompania.SelectedIndex = 0
        'If cboCompania.SelectedIndex = -1 Then
        '    cboCompania.SelectedIndex = 0
        'End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    cboCompania_SelectedIndexChanged(Nothing, Nothing)
  End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        Try
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            objDivision.Crea_Lista()
            cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
            cboDivision.ValueMember = "CDVSN"
            cboDivision.DisplayMember = "TCMPDV"
            Me.cboDivision.SelectedValue = "T"
            bolBuscar = True
            If Me.cboDivision.SelectedIndex = -1 Then
                Me.cboDivision.SelectedIndex = 0
            End If
            cboDivision_SelectedIndexChanged(Nothing, Nothing)
            'Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            'Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

  Private Sub Cargar_Planta()
    Dim objPlanta As New NEGOCIO.Planta_BLL
    Try
      If bolBuscar Then
                'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        bolBuscar = False
        objPlanta.Crea_Lista()
        cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
        cboPlanta.ValueMember = "CPLNDV"
                cboPlanta.DisplayMember = "TPLNTA"
                cboPlanta.SelectedValue = "1"
                bolBuscar = True
                If cboPlanta.SelectedIndex = -1 Then
                    cboPlanta.SelectedIndex = 0
                End If
                'Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
            'Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

#End Region

#Region "Eventos"

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    '      If Me.gwdDatos.Rows.Count > 0 Then
    '          Me.gwdDatos.CurrentRow.Selected = False
    '      End If
    '      'Try

    '      'Catch ex As Exception
    '      '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '      'End Try
    'End Sub

    'Private Sub ckbRangoFechas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckbRangoFechas.KeyUp
    '  If e.KeyCode = Keys.A Then
    '    Me.ckbRangoFechas.Checked = True
    '  ElseIf e.KeyCode = Keys.D Then
    '    Me.ckbRangoFechas.Checked = False
    '  End If
    'End Sub

    'Private Sub btnAsignacionIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionIndividual.Click
    '  If Me.gwdDatos.RowCount > 0 Then
    '    If Me.gwdDatos.CurrentRow.Selected = True Then
    '      ' Me.Asignacion_Individual()
    '    End If
    '  End If
    'End Sub

    'Private Sub frmJuntaTransporte_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    Try
    '        'If gint_Estado = 1 Then
    '        '    Me.Listar_Solicitudes_Asignadas_X_Junta_Transportista()
    '        '    Exit Sub
    '        'End If
    '        'If gint_Estado = 0 Then
    '        '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '        '    'Me.ddlEstado.SelectedIndex = 0
    '        '    Me.ddlEstado.SelectedValue = "P"
    '        '    Me.Listar("")
    '        '    Exit Sub
    '        'End If
    '        ''If gint_Estado = 2 Then
    '        ''  Me.ddlEstado.SelectedIndex = 1
    '        ''  Me.Listar(Me.gwdDatos.Item(0, Me.gwdDatos.CurrentCellAddress.Y).Value)
    '        ''  Exit Sub
    '        ''End If
    '        'Me.Listar_Solicitudes_Asignadas_X_Junta_Transportista()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try

    'End Sub

    'Private Sub dgDatosGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosGeneral.CellDoubleClick
    '      Try
    '          Dim ColName As String = ""
    '          If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
    '          If e.RowIndex < 0 Then Exit Sub



    '          If e.ColumnIndex = 27 Then
    '              If Me.dgDatosGeneral.Item("GPSLON", Me.dgDatosGeneral.CurrentCellAddress.Y).Value.ToString <> "" Then
    '                  Dim objGpsBrowser As New frmMapa
    '                  With objGpsBrowser
    '                      .Latitud = Me.dgDatosGeneral.Item("GPSLAT", e.RowIndex).Value
    '                      .Longitud = Me.dgDatosGeneral.Item("GPSLON", e.RowIndex).Value
    '                      .Fecha = Me.dgDatosGeneral.Item("FECGPS", e.RowIndex).Value
    '                      .Hora = Me.dgDatosGeneral.Item("HORGPS", e.RowIndex).Value.ToString.Trim
    '                      .WindowState = FormWindowState.Maximized
    '                      .ShowForm(.Latitud, .Longitud, Me)
    '                  End With
    '              End If
    '          End If

    '          Dim hash As New Hashtable()
    '          hash("CCMPN") = cboCompania.SelectedValue.ToString()

    '          If e.ColumnIndex = 11 Then Informacion_Detallada_Transportista(1, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '          If e.ColumnIndex = 13 Then Informacion_Detallada_Transportista(2, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '          If e.ColumnIndex = 15 Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '          If e.ColumnIndex = 22 Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
    '          If e.ColumnIndex = 21 Then

    '              'If Me.dgDatosGeneral.Item(18, e.RowIndex).Value <> 0 Then Exit Sub
    '              Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
    '              Dim obj_Entidad As New Detalle_Solicitud_Transporte
    '              Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
    '              Dim lstr_Estado As String = ""

    '              obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item(0, lint_indice).Value
    '              obj_Entidad.NCRRSR = Me.dgDatosGeneral.Item(1, lint_indice).Value
    '              obj_Entidad.NPLNJT = Me.dgDatosGeneral.Item(7, lint_indice).Value
    '              obj_Entidad.NCRRPL = Me.dgDatosGeneral.Item(8, lint_indice).Value

    '              obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Existencias_PAG(obj_Entidad)

    '              If obj_Entidad.NGUITR <> "0" Then
    '                  lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
    '                  If obj_Entidad.NCTAVC <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
    '                  If obj_Entidad.NCSLPE <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
    '                  If obj_Entidad.NCTAV2 <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
    '                  If obj_Entidad.NCSLP2 <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
    '                  lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
    '                  HelpClass.MsgBox(lstr_Estado)
    '                  Exit Sub
    '              End If

    '              obj_Entidad.NRUCTR = Me.dgDatosGeneral.Item(9, lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
    '              obj_Entidad.NPLCUN = Me.dgDatosGeneral.Item(11, lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
    '              obj_Entidad.NPLCAC = Me.dgDatosGeneral.Item(13, lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
    '              obj_Entidad.CBRCNT = Me.dgDatosGeneral.Item(15, lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
    '              obj_Entidad.CBRCN2 = Me.dgDatosGeneral.Item(22, lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value

    '              Dim frmReasignarRecurso As New frmReasignarRecurso
    '              frmReasignarRecurso.IsMdiContainer = True
    '              With frmReasignarRecurso
    '                  '.txtNroSolicitud.Text = obj_Entidad.NCSOTR 'Me.dgDatosGeneral.Item(0, lint_indice).Value
    '                  '.txtItemSolicitud.Text = obj_Entidad.NCRRSR 'Me.dgDatosGeneral.Item(1, lint_indice).Value
    '                  '.txtJunta.Text = obj_Entidad.NPLNJT 'Me.dgDatosGeneral.Item(7, lint_indice).Value
    '                  '.txtItemJunta.Text = obj_Entidad.NCRRPL 'Me.dgDatosGeneral.Item(8, lint_indice).Value
    '                  '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
    '                  '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
    '                  '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
    '                  '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
    '                  '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value
    '                  ._obj_Entidad = obj_Entidad
    '                  .CCMPN = Me.cboCompania.SelectedValue
    '                  .CDVSN = Me.cboDivision.SelectedValue
    '                  .CPLNDV = Me.cboPlanta.SelectedValue

    '                  If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '                  Me.dgDatosGeneral.Item(9, lint_indice).Value = .ctbTransportista.pRucTransportista
    '                  Me.dgDatosGeneral.Item(11, lint_indice).Value = .ctbTracto.pNroPlacaUnidad
    '                  Me.dgDatosGeneral.Item(13, lint_indice).Value = .ctbAcoplado.pNroAcoplado
    '                  Me.dgDatosGeneral.Item(15, lint_indice).Value = .cmbConductor.pBrevete
    '                  Me.dgDatosGeneral.Item(22, lint_indice).Value = .cmbSegundoConductor.pBrevete
    '              End With
    '          End If
    '      Catch : End Try
    'End Sub

    Private Sub dgDatosGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosGeneral.CellDoubleClick
        Try
            Dim ColName As String = ""
            If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            ColName = dgDatosGeneral.Columns(e.ColumnIndex).Name

            If ColName = "Column1" Then
                If Me.dgDatosGeneral.Item("GPSLON", Me.dgDatosGeneral.CurrentCellAddress.Y).Value.ToString <> "" Then
                    Dim objGpsBrowser As New frmMapa
                    With objGpsBrowser
                        .Latitud = Me.dgDatosGeneral.Item("GPSLAT", e.RowIndex).Value
                        .Longitud = Me.dgDatosGeneral.Item("GPSLON", e.RowIndex).Value
                        .Fecha = Me.dgDatosGeneral.Item("FECGPS", e.RowIndex).Value
                        .Hora = Me.dgDatosGeneral.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                        .WindowState = FormWindowState.Maximized
                        .ShowForm(.Latitud, .Longitud, Me)
                    End With
                End If
            End If

            Dim hash As New Hashtable()
            hash("CCMPN") = cboCompania.SelectedValue.ToString()

       
            'If e.ColumnIndex = 11 Then Informacion_Detallada_Transportista(1, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            'If e.ColumnIndex = 13 Then Informacion_Detallada_Transportista(2, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            'If e.ColumnIndex = 15 Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            'If e.ColumnIndex = 22 Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            'If e.ColumnIndex = 21 Then

            If ColName = "G_NPLCUN" Then Informacion_Detallada_Transportista(1, Me.dgDatosGeneral.Item("G_NPLCUN", e.RowIndex).Value, hash)
            If ColName = "G_NPLCAC" Then Informacion_Detallada_Transportista(2, Me.dgDatosGeneral.Item("G_NPLCAC", e.RowIndex).Value, hash)
            If ColName = "G_CBRCNT" Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item("G_CBRCNT", e.RowIndex).Value, hash)
            If ColName = "CBRCN2" Then Informacion_Detallada_Transportista(3, Me.dgDatosGeneral.Item("CBRCN2", e.RowIndex).Value, hash)
            If ColName = "MODIFICAR" Then

                Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
                Dim obj_Entidad As New Detalle_Solicitud_Transporte
                Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
                Dim lstr_Estado As String = ""

                'obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item(0, lint_indice).Value
                'obj_Entidad.NCRRSR = Me.dgDatosGeneral.Item(1, lint_indice).Value
                'obj_Entidad.NPLNJT = Me.dgDatosGeneral.Item(7, lint_indice).Value
                'obj_Entidad.NCRRPL = Me.dgDatosGeneral.Item(8, lint_indice).Value

                obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item("G_NCSOTR", lint_indice).Value
                obj_Entidad.NCRRSR = Me.dgDatosGeneral.Item("G_NCRRSR", lint_indice).Value
                obj_Entidad.NPLNJT = Me.dgDatosGeneral.Item("G_NPLNJT", lint_indice).Value
                obj_Entidad.NCRRPL = Me.dgDatosGeneral.Item("G_NCRRPL", lint_indice).Value


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

                'obj_Entidad.NRUCTR = Me.dgDatosGeneral.Item(9, lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
                'obj_Entidad.NPLCUN = Me.dgDatosGeneral.Item(11, lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
                'obj_Entidad.NPLCAC = Me.dgDatosGeneral.Item(13, lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
                'obj_Entidad.CBRCNT = Me.dgDatosGeneral.Item(15, lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
                'obj_Entidad.CBRCN2 = Me.dgDatosGeneral.Item(22, lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value

                obj_Entidad.NRUCTR = Me.dgDatosGeneral.Item("G_NRUCTR", lint_indice).Value '._Transportista = Me.dgDatosGeneral.Item(9, lint_indice).Value
                obj_Entidad.NPLCUN = Me.dgDatosGeneral.Item("G_NPLCUN", lint_indice).Value '._Tracto = Me.dgDatosGeneral.Item(11, lint_indice).Value
                obj_Entidad.NPLCAC = Me.dgDatosGeneral.Item("G_NPLCAC", lint_indice).Value '._Acoplado = Me.dgDatosGeneral.Item(13, lint_indice).Value
                obj_Entidad.CBRCNT = Me.dgDatosGeneral.Item("G_CBRCNT", lint_indice).Value '._Conductor = Me.dgDatosGeneral.Item(15, lint_indice).Value
                obj_Entidad.CBRCN2 = Me.dgDatosGeneral.Item("CBRCN2", lint_indice).Value '._SegundoConductor = Me.dgDatosGeneral.Item(22, lint_indice).Value



                Dim frmReasignarRecurso As New frmReasignarRecurso
                frmReasignarRecurso.IsMdiContainer = True
                With frmReasignarRecurso
                    ._obj_Entidad = obj_Entidad
                    .CCMPN = Me.cboCompania.SelectedValue
                    .CDVSN = Me.cboDivision.SelectedValue
                    .CPLNDV = Me.cboPlanta.SelectedValue

                    If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    'Me.dgDatosGeneral.Item(9, lint_indice).Value = .ctbTransportista.pRucTransportista
                    'Me.dgDatosGeneral.Item(11, lint_indice).Value = .ctbTracto.pNroPlacaUnidad
                    'Me.dgDatosGeneral.Item(13, lint_indice).Value = .ctbAcoplado.pNroAcoplado
                    'Me.dgDatosGeneral.Item(15, lint_indice).Value = .cmbConductor.pBrevete
                    'Me.dgDatosGeneral.Item(22, lint_indice).Value = .cmbSegundoConductor.pBrevete
                    Me.dgDatosGeneral.Item("G_NRUCTR", lint_indice).Value = .ctbTransportista.pRucTransportista
                    Me.dgDatosGeneral.Item("G_NPLCUN", lint_indice).Value = .ctbTracto.pNroPlacaUnidad
                    Me.dgDatosGeneral.Item("G_NPLCAC", lint_indice).Value = .ctbAcoplado.pNroAcoplado
                    Me.dgDatosGeneral.Item("G_CBRCNT", lint_indice).Value = .cmbConductor.pBrevete
                    Me.dgDatosGeneral.Item("CBRCN2", lint_indice).Value = .cmbSegundoConductor.pBrevete

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


  Private Sub btnCerrarJunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarJunta.Click
    If Me.gwdDatos.RowCount = 0 Then Exit Sub
        Try
            'If Me.dgDatosGeneral.RowCount = 0 Then
            '    HelpClass.MsgBox("No se puede cerrar la Junta; no tiene ninguna asignación", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                HelpClass.MsgBox("Esta Junta de Transporte esta cerrada", MessageBoxIcon.Information)
                Exit Sub
            End If
            'For lint_Contador As Integer = 0 To Me.dgDatosGeneral.RowCount - 1
            '    If Me.dgDatosGeneral.Item("G_NPLCUN", lint_Contador).Value.ToString.Trim = "" Or Me.dgDatosGeneral.Item("G_CBRCNT", lint_Contador).Value.ToString.Trim = "" Then
            '        HelpClass.MsgBox(" Falta Asignar Tracto y/o Conductor a Solicitud(es) ", MessageBoxIcon.Warning)
            '        Exit Sub
            '    End If
            'Next
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            Dim objeto_logica As New Junta_Transporte_BLL
            Dim obj_Entidad As New Junta_Transporte
            obj_Entidad.NPLNJT = Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            obj_Entidad.NCRRPL = Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim
            obj_Entidad.SESPLN = "C"
            obj_Entidad.NPLNJT = objeto_logica.Actualizar_Junta_Transporte(obj_Entidad).NPLNJT
            'If obj_Entidad.NPLNJT = "0" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            'Else
            'HelpClass.MsgBox("La Junta de Transportes se cerró satisfactoriamente")
            'Me.ddlEstado.SelectedIndex = 1
            'Me.ddlEstado.SelectedValue = "C"
            MessageBox.Show("La Junta de Transportes se cerró satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Listar_Junta(Me.gwdDatos.Item("NPLNJT", lint_Indice).Value.ToString.Trim)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim objParamList As New List(Of String)
        Try
            If Me.gwdDatos.RowCount > 0 Then
                If gwdDatos.CurrentRow IsNot Nothing Then
                    'If Me.gwdDatos.CurrentRow.Selected = True Then
                    Dim lestado_Junta As String = Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
                    objParamList.Add(Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParamList.Add(Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParamList.Add(Me.cboCompania.SelectedValue)
                    objParamList.Add(Me.cboDivision.SelectedValue)
                    objParamList.Add(Me.cboPlanta.SelectedValue)
                    'Imprimir(objParamList)
                    Dim objRep As New Junta_Transporte_BLL
                    Dim objCrep As New rptJuntaTransportista
                    Dim objDt As DataTable
                    Dim objDs As New DataSet
                    Dim objPrintForm As New PrintForm
                    'Try
                    objDt = HelpClass.GetDataSetNative(objRep.Listar_Junta_Transporte_Detalle(objParamList))
                    If objDt.Rows.Count = 0 Then
                        HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
                        Exit Sub
                    End If
                    objDt.TableName = "RZST21"
                    'objDt.WriteXml("D:\xlee.xml")
                    objDs.Tables.Add(objDt.Copy)
                    objCrep.SetDataSource(objDs)
                    objPrintForm.ShowForm(objCrep, Me)
                    'Catch ex As Exception
                    '    End Try
                    'End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged
    '  Select Case TabSolicitudFlete.SelectedIndex
    '    Case 0
    '      'Me.MenuBar.Enabled = True
    '      Me.btnGenerarOperacion.Enabled = False
    '    Case 1
    '      'Me.MenuBar.Enabled = False
    '      Me.btnGenerarOperacion.Enabled = True
    '  End Select
    'End Sub
    'Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged
    '    Dim NameTab As String = TabSolicitudFlete.SelectedTab.Name
    '    Select Case NameTab
    '        Case "tbInformacionGeneral"
    '            'Me.MenuBar.Enabled = True
    '            Me.btnGenerarOperacion.Enabled = False
    '        Case "tbInformacionJunta"
    '            'Me.MenuBar.Enabled = False
    '            Me.btnGenerarOperacion.Enabled = True
    '        Case "tabInfoUnidadProgramada"
    '    End Select
    'End Sub


    Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged
        If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            'MessageBox.Show("Debe guardar o cancelar", "Aviso", MessageBoxButtons.OK)
            TabSolicitudFlete.SelectedIndex = TabActualSeleccionado
            ' TabSolicitudFlete.SelectedTab.Name =
            Exit Sub
        End If
        TabActualSeleccionado = TabSolicitudFlete.SelectedIndex
        Dim NameTab As String = TabSolicitudFlete.SelectedTab.Name

        'Dim estadoActual As String = ""
        'If gwdDatos.CurrentRow Is Nothing Then
        '    estadoActual = "C"
        'Else
        '    estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
        'End If

        Select Case NameTab
            'FLFLLF
            Case TabDatoGeneral  'DATOS GENERALES
                'Me.MenuBar.Enabled = True
                HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
                Me.btnGenerarOperacion.Enabled = False
            Case TabProgUnidad
                HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
            Case TabAsignarUnidad  'UNIDADES ASIGNADAS
                'Me.MenuBar.Enabled = False
                HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, NameTab, Estado_Actual_Junta)
                Me.btnGenerarOperacion.Enabled = True

        End Select
    End Sub
    Private Function Estado_Actual_Junta() As String
        Dim estadoActual As String = ""
        If gwdDatos.CurrentRow Is Nothing Then
            estadoActual = "P"
        Else
            estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
        End If
        Return estadoActual
    End Function

    Private Sub btnAsignacionUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionUnidades.Click
        Try
            If Me.gwdDatos.RowCount > 0 Then
                If Me.gwdDatos.CurrentRow.Selected = True Then
                    If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString <> "C" Then
                        'Me.Asignacion_Masiva()
                    Else
                        HelpClass.MsgBox("No se puede Asignar Unidades, esta Junta de Transportes está cerrada", MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
       
    End Sub

  Private Sub btnGenerarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOperacion.Click
        If Me.dgDatosGeneral.RowCount = 0 Then Exit Sub
        If Me.dgDatosGeneral.CurrentRow.Selected = False Then Exit Sub
        Try
            Dim lint_indice As Integer = Me.dgDatosGeneral.CurrentCellAddress.Y
            If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
            If Me.dgDatosGeneral.Item("NOPRCN", lint_indice).Value <> 0 Then
                HelpClass.MsgBox("Ya tiene asignado una Operación y Planeamiento")
                Exit Sub
            End If
            If HelpClass.RspMsgBox("Desea generar la operación de transporte?") = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim obj_Entidad As New Solicitud_Transporte
            Dim obj_LogicaSolicitud As New Solicitud_Transporte_BLL
            Dim frmBuscarServicio As New frmBuscarOrdenServicio
            Dim obj_LogicaOperacion As New OperacionTransporte_BLL
            Dim objEntidad As New List(Of String)
            Dim lstr_resultado As String = ""
            Dim lstr_ordenservicio As String = ""
            frmBuscarServicio.IsMdiContainer = True
            'obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item(0, lint_indice).Value
            obj_Entidad.NCSOTR = Me.dgDatosGeneral.Item("G_NCSOTR", lint_indice).Value
            obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
            lstr_ordenservicio = obj_LogicaSolicitud.Obtener_Solicitud_Transporte(obj_Entidad).NORSRT
            If lstr_ordenservicio <> "0" Then
                Registrar_Operacion_Transporte(lstr_ordenservicio)
                Exit Sub
            Else
                With frmBuscarServicio
                    '.CodigoCliente = Me.dgDatosGeneral.Item(2, lint_indice).Value
                    .CodigoCliente = Me.dgDatosGeneral.Item("G_CCLNT", lint_indice).Value
                    .CCMPN = Me.cboCompania.SelectedValue.ToString().Trim()
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
                    obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
                    If obj_LogicaSolicitud.Asignar_Orden_Servicio_A_Solicitud(obj_Entidad).NCSOTR <> "0" Then
                        HelpClass.MsgBox("Se asignó satisfactoriamente la Orden de Servicio N°" & objEntidad(1))
                    End If
                    Registrar_Operacion_Transporte(lstr_ordenservicio)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
   
  End Sub

    Private Sub dgDatosGeneral_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosGeneral.CellClick
        Try
            If e.RowIndex = -1 Then Exit Sub
            Dim ColName As String = dgDatosGeneral.Columns(e.ColumnIndex).Name
            'If e.ColumnIndex = 20 Then
            '  If dgDatosGeneral.Item(20, e.RowIndex).Value.ToString = "Enviar SAP" Then
            '    Enviar_Orden_Interna_SAP()
            '  End If
            'End If
            If ColName = "NORINS" Then
                If dgDatosGeneral.Item("NORINS", e.RowIndex).Value.ToString = "Enviar SAP" Then
                    Enviar_Orden_Interna_SAP()
                End If
            End If

            If ColName = "SEGUIMIENTO" Then
                If Me.dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value = "" Then
                    Exit Sub
                End If
                Dim NPLCUN As String = dgDatosGeneral.Item("G_NPLCUN", e.RowIndex).Value.ToString.Trim()
                Dim strExiste As String = dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value.ToString.Trim()
                If strExiste = vbNullString Then Exit Sub
                Dim f As New frmRegistroWAP(NPLCUN)
                f.ShowForm(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

        'If e.ColumnIndex = 28 Then
        '  If Me.dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value = "" Then
        '    Exit Sub
        '  End If
        '  Dim NPLCUN As String = dgDatosGeneral.Item("G_NPLCUN", e.RowIndex).Value.ToString.Trim()
        '  Dim strExiste As String = dgDatosGeneral.Item("SEGUIMIENTO", e.RowIndex).Value.ToString.Trim()
        '  If strExiste = vbNullString Then Exit Sub
        '  Dim f As New frmRegistroWAP(NPLCUN)
        '  f.ShowForm(Me)
        'End If

    End Sub



    Private Sub CargarFiltro()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("DISPLAY") = "::TODOS::"
        dr("VALUE") = "0"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "Pendiente"
        dr("VALUE") = "P"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "Cerrado"
        dr("VALUE") = "C"
        dtEstado.Rows.Add(dr)

        ddlEstado.DataSource = dtEstado
        ddlEstado.DisplayMember = "DISPLAY"
        ddlEstado.ValueMember = "VALUE"
        ddlEstado.SelectedValue = "P"


        Dim dtEstadoJunta As New DataTable
        dtEstadoJunta.Columns.Add("DISPLAY")
        dtEstadoJunta.Columns.Add("VALUE")
        Dim drJunta As DataRow
       
        drJunta = dtEstadoJunta.NewRow
        drJunta("DISPLAY") = "Pendiente"
        drJunta("VALUE") = "P"
        dtEstadoJunta.Rows.Add(drJunta)

        drJunta = dtEstadoJunta.NewRow
        drJunta("DISPLAY") = "Cerrado"
        drJunta("VALUE") = "C"
        dtEstadoJunta.Rows.Add(drJunta)

        cboEstadoJunta.DataSource = dtEstadoJunta
        cboEstadoJunta.DisplayMember = "DISPLAY"
        cboEstadoJunta.ValueMember = "VALUE"

    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim obj_Entidad As New Junta_Transporte
        Dim obj_Logica As New Junta_Transporte_BLL
        Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        Try
            Select Case TabSeleccionado
                Case TabDatoGeneral
                    obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
                    obj_Entidad.CDVSN = Me.cboDivision.SelectedValue.ToString.Trim
                    obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                    obj_Entidad.NPLNJT = obj_Logica.Existe_Junta_Pendiente_Transporte(obj_Entidad).NPLNJT
                    If obj_Entidad.NPLNJT = "-1" Then
                        'HelpClass.MsgBox("Existe una Junta Pendiente")
                        MessageBox.Show("Existe una Junta Pendiente.Debe cerrar la Junta Pendiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                        'ElseIf obj_Entidad.NPLNJT = "0" Then
                        '  HelpClass.ErrorMsgBox()
                        '  Exit Sub
                    End If
                    Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
                    'DDD()
                    'Me.btnGuardar.Text = "Guardar"
                    'Me.btnGuardar.Enabled = True
                    'Me.btnCancelar.Enabled = True
                    'Me.btnEliminar.Enabled = False
                    'Me.Limpiar_Controles()
                    'Me.Estado_Controles(True)
                    Limpiar_Datos_General_Junta()
                    'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                    HabilitarBotonOpcion(MANTENIMIENTO.NUEVO, TabDatoGeneral, "P")
                    Me.dtpFechaJunta.Value = Date.Today
                    Me.txtHoraJunta.Text = HelpClass.Now_Hora
                    'Me.cboEstadoJunta.SelectedIndex = 0
                    Me.cboEstadoJunta.SelectedValue = "P"
                    'If Me.gwdDatos.Rows.Count > 0 Then
                    '    Me.gwdDatos.CurrentRow.Selected = False
                    'End If
            End Select
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            '    Case "tbInformacionGeneral" 'DATOS GENERALES
            ''Me.MenuBar.Enabled = True
            'HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, NameTab)
            'Me.btnGenerarOperacion.Enabled = False
            'Case "tabInfoUnidadProgramada"
            'HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, NameTab)
            'Case "tbInformacionJunta" 'UNIDADES ASIGNADAS
            Dim NameTab As String = TabSolicitudFlete.SelectedTab.Name
            'Dim TabSel As String = jj
            Dim Validar As String = ""

            Select Case NameTab
                Case TabDatoGeneral
                   
                    'If Validar_Ingreso_Junta() = True Then
                    '    Exit Sub
                    'End If
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                        Validar = Validar_Ingreso_Junta()
                        If Validar.Length > 0 Then
                            MessageBox.Show(Validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        'Me.Nueva_Junta()
                        'Me.AccionCancelar()
                        Dim obj_Entidad As New Junta_Transporte
                        Dim obj_Logica As New Junta_Transporte_BLL
                        'Try
                        obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
                        obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
                        obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
                        obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
                        obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
                        'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
                        obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
                        obj_Entidad.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
                        obj_Entidad.CDVSN = Me.cboDivision.SelectedValue.ToString.Trim
                        obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                        obj_Entidad.CUSCRT = MainModule.USUARIO
                        obj_Entidad.FCHCRT = HelpClass.TodayNumeric
                        obj_Entidad.HRACRT = HelpClass.NowNumeric
                        obj_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                        obj_Entidad.NPLNJT = obj_Logica.Registrar_Junta_Transporte(obj_Entidad).NPLNJT
                        MessageBox.Show("Se registró satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Me.ddlEstado.SelectedValue = "P"
                        'Listar_Junta(obj_Entidad.NPLNJT)
                        Listar_Junta("")
                        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                        HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabDatoGeneral, Estado_Actual_Junta)

                    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then

                      

                        If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString = "P" Then
                            'Me.Modificar_Junta()
                            'Me.AccionCancelar()
                            Validar = Validar_Ingreso_Junta()
                            If Validar.Length > 0 Then
                                MessageBox.Show(Validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            Dim obj_Entidad As New Junta_Transporte
                            Dim obj_Logica As New Junta_Transporte_BLL
                            'Try
                            'obj_Entidad.NPLNJT = _strNPLNJT
                            'obj_Entidad.NCRRPL = _strNCRRPL
                            obj_Entidad.NPLNJT = gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.NCRRPL = gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.FPLNJT = HelpClass.CtypeDate(Me.dtpFechaJunta.Value)
                            obj_Entidad.HPLNJT = HelpClass.ConvertHoraNumeric(Me.txtHoraJunta.Text.Substring(0, 8))
                            obj_Entidad.TRSPAT = Me.txtResponsableJunta.Text.Trim
                            obj_Entidad.TDSCPL = Me.txtDescripcionJunta.Text.Trim
                            obj_Entidad.QCNASI = IIf(Me.txtCantidadJunta.Text.Trim = "", "0", Me.txtCantidadJunta.Text.Trim)
                            'obj_Entidad.SESPLN = Asignar_Valor(Me.cboEstadoJunta)
                            obj_Entidad.SESPLN = cboEstadoJunta.SelectedValue
                            obj_Entidad.CULUSA = MainModule.USUARIO
                            obj_Entidad.FULTAC = HelpClass.TodayNumeric
                            obj_Entidad.HULTAC = HelpClass.NowNumeric
                            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                            obj_Entidad.NPLNJT = obj_Logica.Modificar_Junta_Transporte(obj_Entidad).NPLNJT
                            HelpClass.MsgBox("Se modificó satisfactoriamente")
                            'Listar_Junta(obj_Entidad.NPLNJT)
                            Listar_Junta("")
                            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                            'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                            HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabDatoGeneral, Estado_Actual_Junta)
                        End If
                        'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                        '    'Me.Estado_Controles(True)
                        '    Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                        '    HabilitarBotonEstado(MANTENIMIENTO.NEUTRAL, TabSeleccionado)

                        '    'Me.btnGuardar.Text = "Guardar"
                        '    'Me.btnNuevo.Enabled = False
                        '    'Me.btnCancelar.Enabled = True
                        '    'Me.btnEliminar.Enabled = False
                        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Me.AccionCancelar()
        Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        Select Case TabSeleccionado
            Case TabDatoGeneral
                'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
        End Select
    
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'Me.AccionCancelar()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        Select Case TabSeleccionado
            Case TabDatoGeneral
                Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                Dim estadoActual As String = ""
                'If gwdDatos.CurrentRow Is Nothing Then
                '    estadoActual = "C"
                'Else
                '    estadoActual = gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
                'End If
                HabilitarBotonOpcion(MANTENIMIENTO.EDITAR, TabDatoGeneral, "P")
            Case TabProgUnidad

        End Select
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim obj_LogicaJunta As New Detalle_Solicitud_Transporte_BLL
        Dim objParametro As New Hashtable
        Dim validar As String = ""
        Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
            'TabSeleccionado
            Select Case TabSeleccionado
                Case TabDatoGeneral
                    objParametro.Add("PNNPLNJT", Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParametro.Add("PNNCRRPL", Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
                    objParametro.Add("PSCCMPN", cboCompania.SelectedValue)
                    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_LogicaJunta.Listar_Detalle_Solicitud(objParametro)
                        If obj_Entidad.NOPRCN <> 0 Then
                            validar = "No se puede eliminar la junta." & Chr(13) & "* Esta Junta tiene asignada N° de Operación"
                            'HelpClass.MsgBox("Esta Junta tiene asignada N° de Operacion; si quiere eliminar comuniquese al Dpto. de Sistemas")
                            'MessageBox.Show("No se puede eliminar la junta" & Chr(13) & "Esta Junta tiene asignada N° de Operación", "Aviso")
                            Exit For
                        End If
                    Next
                    If kdgvUnidadProgramada.Rows.Count > 0 Then
                        '  MessageBox.Show("No se puede eliminar la junta " & Chr(13) & "Tiene unidades programadas", "Aviso", MessageBoxButtons.OK)
                        validar = validar & Chr(13) & "Tiene unidades programadas"
                        'Exit Sub
                    End If
                    'If MsgBox("Desea eliminar esta Junta de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    'Me.Eliminar_Junta_Transporte()
                    If validar.Length > 0 Then
                        MessageBox.Show(validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If MessageBox.Show("Está seguro de eliminar esta Junta de Transporte ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

                            Dim obj_Entidad As New Junta_Transporte
                            Dim obj_Logica As New Junta_Transporte_BLL
                            obj_Entidad.NPLNJT = Me.gwdDatos.Item("NPLNJT", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.NCRRPL = Me.gwdDatos.Item("NCRRPL", Me.gwdDatos.CurrentCellAddress.Y).Value
                            obj_Entidad.CULUSA = MainModule.USUARIO
                            obj_Entidad.FULTAC = HelpClass.TodayNumeric
                            obj_Entidad.HULTAC = HelpClass.NowNumeric
                            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                            obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
                            obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
                            obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                            obj_Entidad.NPLNJT = obj_Logica.Eliminar_Junta_Transporte(obj_Entidad).NPLNJT
                            'If obj_Entidad.NPLNJT <> "0" Then
                            '    HelpClass.MsgBox("Se eliminó satisfactoriamente")
                            'Else
                            '    HelpClass.ErrorMsgBox()
                            '    Exit Sub
                            'End If
                            MessageBox.Show("Se eliminó satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                            Me.Listar_Junta("")
                            'Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
                            HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)

                        End If
                        'Me.Eliminar_Junta_Transporte()
                    End If

                Case TabProgUnidad

                    If Me.gwdDatos.Item("SESPLN", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim = "C" Then
                        HelpClass.MsgBox("Esta Junta de Transporte esta cerrada", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If kdgvUnidadProgramada.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    Dim objDetalle_Junta_Transporte As New Detalle_Junta_Transporte
                    Dim oblJunta_Transporte_BLL As New Junta_Transporte_BLL
                    objDetalle_Junta_Transporte.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                    objDetalle_Junta_Transporte.NPLNJT = kdgvUnidadProgramada.CurrentRow.Cells("NPLNJT_UP").Value
                    objDetalle_Junta_Transporte.NCRRPL = kdgvUnidadProgramada.CurrentRow.Cells("NCRRPL_UP").Value
                    objDetalle_Junta_Transporte.NCSOTR = kdgvUnidadProgramada.CurrentRow.Cells("NCSOTR").Value
                    objDetalle_Junta_Transporte.CULUSA = MainModule.USUARIO
                    objDetalle_Junta_Transporte.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    If MessageBox.Show("Está seguro de eliminar la programación para la junta", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        oblJunta_Transporte_BLL.Eliminar_Junta_Solicitud_Programado(objDetalle_Junta_Transporte)
                        Listar_Unidades_Programadas_x_Junta()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '  If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '    Exit Sub
    '      End If
    '      Try
    '          If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '              If Me.gwdDatos.Rows.Count > 0 Then
    '                  Me.gwdDatos.CurrentRow.Selected = False
    '              End If
    '              MsgBox("Debe guardar la junta de transportista o cancelarla.", MsgBoxStyle.Exclamation)
    '              Exit Sub
    '          ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL Then
    '              Me.AccionCancelar()
    '              If Me.gwdDatos.Rows.Count > 0 Then
    '                  Me.gwdDatos.CurrentRow.Selected = True
    '              End If
    '          End If
    '          kdgvUnidadProgramada.DataSource = Nothing
    '          Me.dgDatosGeneral.Rows.Clear()
    '          Me.Cargar_Datos_Grilla()
    '          Me.Listar_Solicitudes_Asignadas_X_Junta_Transportista()
    '          Listar_Unidades_Programadas_x_Junta()
    '      Catch ex As Exception
    '          MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '      End Try

    'End Sub


    Private Sub Listar_Unidades_Programadas_x_Junta()
        Dim obj_LogicaJunta As New Junta_Transporte_BLL
        Dim dtSolProgJunta As New DataTable
        kdgvUnidadProgramada.DataSource = Nothing
        If gwdDatos Is Nothing Then
            Exit Sub
        End If
        Dim obj As New Junta_Transporte
        If gwdDatos.CurrentRow IsNot Nothing Then
            obj.NPLNJT = gwdDatos.CurrentRow.Cells("NPLNJT").Value
            obj.NCRRPL = gwdDatos.CurrentRow.Cells("NCRRPL").Value
            obj.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            dtSolProgJunta = obj_LogicaJunta.Lista_Solicitud_Programas_x_Junta(obj)
            kdgvUnidadProgramada.DataSource = dtSolProgJunta
        End If

    End Sub

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Limpiar_Datos_General_Junta()
            kdgvUnidadProgramada.DataSource = Nothing
            dgDatosGeneral.DataSource = Nothing
            Me.Listar_Junta("")
            'Me.AccionCancelar()
            Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
            HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

  Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
    If Me.ckbRangoFechas.Checked = True Then
      Me.dtpFechaInicio.Enabled = True
      Me.dtpFechaFin.Enabled = True
    Else
      Me.dtpFechaInicio.Enabled = False
      Me.dtpFechaFin.Enabled = False
    End If
  End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    '    Try
    '        If Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '            Exit Sub
    '        End If
    '        Select Case e.KeyCode
    '            Case Keys.Up, Keys.Down, Keys.Enter
    '                Me.Cargar_Datos_Grilla()
    '                Me.Listar_Solicitudes_Asignadas_X_Junta_Transportista()
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

  Private Sub txtNroJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroJunta.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtCantidadJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadJunta.KeyPress
    If e.KeyChar = "." Then
      e.Handled = True
      Exit Sub
    End If
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtResponsableJunta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponsableJunta.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloLetras(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
        If bolBuscar Then
            Me.Cargar_Division()
        End If
    End Sub

  Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
    If bolBuscar Then
      Me.Cargar_Planta()
    End If
  End Sub

    Private Sub btnImprimirLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirLista.Click
        Try

     
            'Me.Cursor = Cursors.WaitCursor
            Dim obj_Logica As New Junta_Transporte_BLL
            Dim objParamList As New List(Of String)
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            'objParamList.Add(Asignar_Valor(Me.ddlEstado))
            If ddlEstado.SelectedValue = "0" Then
                objParamList.Add("")
            Else
                objParamList.Add(ddlEstado.SelectedValue)
            End If
            objParamList.Add(Me.txtNroJunta.Text)
            If Not ckbRangoFechas.Checked Then
                objParamList.Add(0)
                objParamList.Add(0)
            Else
                objParamList.Add(lstr_FecIni)
                objParamList.Add(lstr_FecFin)
            End If
            objParamList.Add(Me.cboCompania.SelectedValue)
            objParamList.Add(Me.cboDivision.SelectedValue)
            objParamList.Add(Me.cboPlanta.SelectedValue)
            Dim objCrep As New rptReporteListaJuntaTransportista
            Dim objDt As DataTable
            Dim objDs As New DataSet
            Dim objPrintForm As New PrintForm

            objDt = HelpClass.GetDataSetNative(obj_Logica.Lista_Reporte_Junta_Transporte(objParamList))
            If objDt.Rows.Count = 0 Then
                HelpClass.MsgBox("Esta Junta no tiene solicitudes para atender")
                Exit Sub
            End If
            objDt.TableName = "RZST21"
            'objDt.WriteXml("D:\xlee.xml")
            objDs.Tables.Add(objDt.Copy)
            objCrep.SetDataSource(objDs)
            objPrintForm.ShowForm(objCrep, Me)
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region



    Private Sub btnProgramarUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgramarUnidades.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmSolicitudPendiente As New frmSolPendprogramar
            ofrmSolicitudPendiente.pCCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmSolicitudPendiente.pCDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
            ofrmSolicitudPendiente.pCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
            ofrmSolicitudPendiente.pNPLNJT = gwdDatos.CurrentRow.Cells("NPLNJT").Value
            ofrmSolicitudPendiente.pNCRRPL = gwdDatos.CurrentRow.Cells("NCRRPL").Value
            ofrmSolicitudPendiente.ShowDialog()
            If ofrmSolicitudPendiente.MyDialogResult = True Then
                Listar_Unidades_Programadas_x_Junta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            Dim TabSeleccionado As String = TabSolicitudFlete.SelectedTab.Name
            HabilitarBotonOpcion(MANTENIMIENTO.NEUTRAL, TabSeleccionado, Estado_Actual_Junta)
            'Me.Cargar_Datos_Grilla()
            Limpiar_Datos_General_Junta()
            Dim lint_indice As Integer = gwdDatos.CurrentCellAddress.Y
            Dim objEntidad As New Junta_Transporte
            Dim objJuntaTransporte As New Junta_Transporte_BLL
            _strNPLNJT = gwdDatos.Item("NPLNJT", lint_indice).Value
            _strNCRRPL = gwdDatos.Item("NCRRPL", lint_indice).Value
            dtpFechaJunta.Value = gwdDatos.Item("FPLNJT", lint_indice).Value
            txtHoraJunta.Text = gwdDatos.Item("HPLNJT", lint_indice).Value
            txtResponsableJunta.Text = gwdDatos.Item("TRSPAT", lint_indice).Value
            txtDescripcionJunta.Text = gwdDatos.Item("TDSCPL", lint_indice).Value
            txtCantidadJunta.Text = gwdDatos.Item("QCNASI", lint_indice).Value
            'Quitar_Valor(Me.gwdDatos.Item("SESPLN", lint_indice).Value.ToString, Me.cboEstadoJunta)
            cboEstadoJunta.SelectedValue = gwdDatos.Item("SESPLN", lint_indice).Value
            HeaderDatos.ValuesPrimary.Heading = " Nro : " & _strNPLNJT & " | Responsable Junta : " + Me.txtResponsableJunta.Text & " | Estado Junta : " & Me.cboEstadoJunta.Text

            Listar_Solicitudes_Asignadas_X_Junta_Transportista()
            Listar_Unidades_Programadas_x_Junta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
End Class
