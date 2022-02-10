Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
Imports System.Collections.Generic
Imports Ransa.Utilitario

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmTransportista
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private vCodTransportista As String = "0"
  Dim _indiceGrilla As Integer = 0
  Dim vFCHCRT As String = ""
    Dim vHRACRT As String = ""


  Private Sub frmTransportista_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    ActualizarTabs()
  End Sub

  Private Sub frmTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      'Pone el flag en neutral
      gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
      Me.btnGuardar.Enabled = False
      Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.Validar_Acceso_Opciones_Usuario()
            CargarEstadoTransportista()
      'Limpia los controles
      Me.Limpiar_Controles_Transportista()
      'bloquea los controles de los tabs
      Me.Estado_Controles_Transportista(False)
      Me.gwdDatos.AutoGenerateColumns = False
      Me.Cargar_Compania()
      Me.cargarComboTransportistaAS400()
            Listar_Transportista()
      Me.Alinear_Columnas_Grilla()

      Me.txtFiltroTransportista.CharacterCasing = CharacterCasing.Upper
    Catch : End Try
    End Sub

    Private Sub CargarEstadoTransportista()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")

        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("DISPLAY") = "ACTIVO"
        dr("VALUE") = "1"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "INACTIVO"
        dr("VALUE") = "2"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.ValueMember = "VALUE"

        cboEstado.SelectedValue = "1"

    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
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
            Me.Separator4.Visible = False
        End If
        If objEntidad.STSVIS = "" Then
            Me.btnImprimirTR.Visible = False
        End If

        Me.btnHabilitar.Visible = False
        'If objEntidad.STSOP1 = "" Then
        '    Me.btnHabilitar.Visible = False
        'End If

    End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdResAcopladosTransportista.AutoGenerateColumns = False
    Me.gwdResConductoresTransportista.AutoGenerateColumns = False
    Me.gwdResTractosTransportista.AutoGenerateColumns = False

    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.gwdResAcopladosTransportista.ColumnCount - 1
      Me.gwdResAcopladosTransportista.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.gwdResConductoresTransportista.ColumnCount - 1
      Me.gwdResConductoresTransportista.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.gwdResTractosTransportista.ColumnCount - 1
      Me.gwdResTractosTransportista.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  

#Region "COMPAÑIA DIVISION Y PLANTA"
  Private bolBuscar As Boolean = False

  Private Sub Cargar_Compania()
    Try
      Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
      bolBuscar = False
      objCompaniaBLL.Crea_Lista()
      cmbCompania.DataSource = objCompaniaBLL.Lista
      cmbCompania.ValueMember = "CCMPN"
      cmbCompania.DisplayMember = "TCMPCM"
            'cmbCompania.SelectedIndex = 0
            'cmbCompania.SelectedValue = "EZ"
            bolBuscar = True
            'If cmbCompania.SelectedIndex = -1 Then
            '    cmbCompania.SelectedIndex = 0
            'End If

            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
      cmbCompania_SelectedIndexChanged(Nothing, Nothing)
    Catch ex As Exception

    End Try

  End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
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
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

  Private Sub Cargar_Planta()
    Dim objPlanta As New NEGOCIO.Planta_BLL
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Try
      If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
        bolBuscar = False
        objPlanta.Crea_Lista()
        objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
        cmbPlanta.DataSource = objLisEntidad
        cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
                bolBuscar = True
        Me.cmbPlanta.SelectedIndex = 0
                cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
      End If
    Catch ex As Exception

      HelpClass.MsgBox(ex.Message)
    End Try

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
  Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
    If bolBuscar Then
      InicializarFormulario()
    End If
  End Sub
#End Region

  Private Sub InicializarFormulario()
    Limpiar_Controles_Transportista()
    Estado_Controles_Transportista(False)
    gwdResTractosTransportista.DataSource = Nothing
    gwdResAcopladosTransportista.DataSource = Nothing
    gwdResConductoresTransportista.DataSource = Nothing
    gwdDatos.DataSource = Nothing

    'Pone el flag en neutral
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    btnGuardar.Enabled = False
    btnCancelar.Enabled = False
    btnEliminar.Enabled = False
    cargarComboTransportistaAS400()

  End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim lstr_PestanaActiva As String
        lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name

        Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        Select Case lstr_PestanaActiva
            Case "TabVehiculos", "TabAcoplados", "TabConductores"
                If gwdDatos.CurrentRow Is Nothing Then
                    Exit Sub
                End If
                If estado = "*" Then
                    MessageBox.Show("No se puede adicionar detalles. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
        End Select
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False


        If lstr_PestanaActiva = "TabDatosTransportista" Then
            vCodTransportista = "0"
            chkTercero.Enabled = True
            Limpiar_Controles_Transportista()
            Estado_Controles_Transportista(True)

        ElseIf lstr_PestanaActiva = "TabVehiculos" Then
            Dim obrTracto As New Tracto_BLL

            Dim ofrmNewTracto As New frmNuevoTracto(True)

            With ofrmNewTracto
                .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                .TIPO = "T"
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Registrar_VehiculoTransportista(.NPLCUN, .TOBS)
                    .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                    obrTracto.Registrar_Tracto_Antiguo(.objEntidad)
                    Listar_ResumenVehiculos()
                End If
                AccionCancelar()
            End With
        ElseIf lstr_PestanaActiva = "TabAcoplados" Then
            Dim obrAcoplado As New Acoplado_BLL
            Dim ofrmNewAcoplado As New frmNuevoAcoplado(True)
            With ofrmNewAcoplado
                .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                .TIPO = "T"
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Registrar_AcopladoTransportista(.NPLCAC, .TOBS)
                    .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                    obrAcoplado.Registrar_Acoplado_Antiguo(.objEntidad)
                    Listar_ResumenAcoplados()
                End If
                AccionCancelar()
            End With

        ElseIf lstr_PestanaActiva = "TabConductores" Then
            Dim ofrmNuevoConductor As New frmNuevoConductor(True)
            With ofrmNuevoConductor
                .chkTercero.Visible = False
                .btnNuevo.Visible = False
                .ToolStripSeparator1.Visible = False
                .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim obrConductor As New Chofer_BLL
                    Registrar_ConductorTransportista(.CBRCNT, .TOBS)
                    .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                    obrConductor.Registrar_Chofer_Antiguo(.objEntidad)
                    Listar_ResumenConductores()
                End If
                AccionCancelar()
            End With
        End If

    End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim lstr_PestanaActiva As String
    lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name

    If lstr_PestanaActiva = "TabDatosTransportista" Then
      If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
        If Me.txtNroRuc.Text = "" Then
          MsgBox("Ingrese el RUC", MsgBoxStyle.Exclamation)
          Exit Sub
        ElseIf Me.txtNroRuc.Text.Length <> 11 Then
          MsgBox("El RUC debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
          Exit Sub
        ElseIf Me.txtRazonSocial.Text = "" Then
          MsgBox("Ingrese la razón social.", MsgBoxStyle.Exclamation)
          Exit Sub
        ElseIf Me.txtCodigoTransportista.Text = "" Then
          MsgBox("Ingrese Cuenta Acreedor SAP.", MsgBoxStyle.Exclamation)
          Exit Sub
                Else

                    Dim oTransportistaBLL As New Transportista_BLL
                    Dim dtTransportista As New DataTable
                    Dim objEntidad As Transportista
                    objEntidad = New Transportista
                    objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
                    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                    objEntidad.SESTRG = "*"
                    objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
                    dtTransportista = oTransportistaBLL.Listar_Transportista_X_RUC(objEntidad)

                    If dtTransportista.Rows.Count > 0 Then
                        Dim RUC_SOLMIN As String = ("" & dtTransportista.Rows(0)("RUC_SOLMIN")).ToString.Trim
                        Dim RUC_AS As String = ("" & dtTransportista.Rows(0)("RUC_AS")).ToString.Trim
                        If RUC_SOLMIN <> RUC_AS Then
                            'MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critica)
                            MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            If MessageBox.Show("El transportista se encuentra en estado inactivo.Desea activar y reemplazar con los datos ingresados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                objEntidad = New Transportista
                                oTransportistaBLL = New Transportista_BLL
                                objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                                objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
                                objEntidad.CULUSA = MainModule.USUARIO
                                objEntidad.NTRMNL = HelpClass.NombreMaquina
                                oTransportistaBLL.ActivarTransportista(objEntidad)
                                vCodTransportista = dtTransportista.Rows(0)("CTRSPT")
                                Modificar_Transportista()
                            End If                           
                        End If
                    Else
                        Registrar_Transportista()
                        txtNroRuc.Focus()
                    End If

                    'Registrar_Transportista()
                    'txtNroRuc.Focus()

                End If
      ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        If Me.txtNroRuc.Text <> "" Then
          If cboTranspAS400.Codigo = "" Then
            MsgBox("Seleccione un código de transportista AS400.", MsgBoxStyle.Exclamation)
            Exit Sub
                    Else

                      
                        'Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                        'If estado = "*" Then
                        '    MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Sub
                        'End If

                        Modificar_Transportista()
                        If Me.gwdDatos.Rows.Count > 0 Then
                            Me.Limpiar_Controles_Transportista()
                            Me.gwdDatos.CurrentRow.Selected = False
                        End If
          End If
        End If
        'pulso el boton 'modificar'
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then

                Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                If estado = "*" Then
                    MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Me.Estado_Controles_Transportista(True)
                btnGuardar.Text = "Guardar"
                'controles habilitados para cancelar en cualkier momento la modificacion en caliente
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                'prepara para la sgte accion del btnGuardar (guardar en BD)
                Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
      End If

    ElseIf lstr_PestanaActiva = "TabVehiculos" Then

    ElseIf lstr_PestanaActiva = "TabAcoplados" Then

    ElseIf lstr_PestanaActiva = "TabConductores" Then
    End If
    'gwdDatos.CurrentCell = gwdDatos.Item(0, _indiceGrilla)
  End Sub

  Private Sub Registrar_VehiculoTransportista(ByVal strVehiculo As String, ByVal strObservacion As String)
    Dim objEntidadTT As New TransportistaTracto
    Dim objLogica As New TransportistaTracto_BLL

    objEntidadTT.NRUCTR = txtNroRuc.Text 'Me.ctbTransportista.Codigo
    objEntidadTT.NPLCUN = strVehiculo
    objEntidadTT.FECINI = HelpClass.TodayNumeric
    objEntidadTT.FECFIN = HelpClass.TodayNumeric
    objEntidadTT.TOBS = strObservacion
    objEntidadTT.CUSCRT = MainModule.USUARIO
    objEntidadTT.FCHCRT = HelpClass.TodayNumeric
    objEntidadTT.HRACRT = HelpClass.NowNumeric
    objEntidadTT.NTRMCR = HelpClass.NombreMaquina
    objEntidadTT.NTRMNL = HelpClass.NombreMaquina
    objEntidadTT.POS_RUC_ANTERIOR = ""
    objEntidadTT.FLAG_SKIPCHECKS = 0
    objEntidadTT.SESTCM = ""
    objEntidadTT.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidadTT.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    objEntidadTT.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

    Dim objExisteTT As New TransportistaTracto
    objExisteTT = objEntidadTT
    objExisteTT = objLogica.Registrar_TransportistaTracto(objExisteTT)

        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub

        'ElseIf objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
        '  objEntidadTT.FLAG_SKIPCHECKS = 1
        '  objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '  If objEntidadTT.NRUCTR = "-1" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        '    'Else
        '    'Listar_ResumenVehiculos()
        '  End If

        'ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

        '  Dim objLogicaCia As New Transportista_BLL

        '  'valida q no se asigne a la misma cia q ya lo tiene
        '  If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
        '    'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '    If objExisteTT.SESTCM = "*" Then
        '      objEntidadTT.FLAG_SKIPCHECKS = 1
        '      objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '      If objEntidadTT.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        '   Listar_ResumenVehiculos()
        '      End If
        '    Else
        '                'HelpClass.MsgBox("Tracto ya asignado.", MessageBoxIcon.Error)
        '                MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '      Exit Sub
        '    End If

        '  Else 'cambio de otra compañia
        '    Dim objCia1 As New Transportista
        '    objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
        '    objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '    objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        '    objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value


        '    Dim olbeCia1 As New List(Of Transportista)
        '    olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '    If olbeCia1.Count = 0 Then Exit Sub
        '    objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '    Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
        '                            "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
        '                            "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                            "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
        '    If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '      objEntidadTT.FLAG_SKIPCHECKS = 1
        '      objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '      If objEntidadTT.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub

        '      End If
        '    End If

        '  End If

        'End If


        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub

        'Else
        If objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTT.FLAG_SKIPCHECKS = 1
            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
            'If objEntidadTT.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            '    'Else
            '    'Listar_ResumenVehiculos()
            'End If

        ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTT.SESTCM = "*" Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    'If objEntidadTT.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    '    'Else
                    '    '   Listar_ResumenVehiculos()
                    'End If
                Else
                    'HelpClass.MsgBox("Tracto ya asignado.", MessageBoxIcon.Error)
                    MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

            Else 'cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                ' objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
                                        "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    'If objEntidadTT.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub

                    'End If
                End If

            End If

        End If


  End Sub


  Private Sub Registrar_AcopladoTransportista(ByVal strAcoplado As String, ByVal strObservacion As String)

    Dim objEntidadTA As New TransportistaAcoplado
    Dim objLogica As New TransportistaAcoplado_BLL

    objEntidadTA.NRUCTR = txtNroRuc.Text
    objEntidadTA.NPLCAC = strAcoplado 'cboAcoplados.Codigo
    objEntidadTA.FECINI = HelpClass.TodayNumeric
    objEntidadTA.FECFIN = HelpClass.TodayNumeric
    objEntidadTA.TOBS = strObservacion
    objEntidadTA.CUSCRT = MainModule.USUARIO
    objEntidadTA.FCHCRT = HelpClass.TodayNumeric
    objEntidadTA.HRACRT = HelpClass.NowNumeric
    objEntidadTA.NTRMCR = HelpClass.NombreMaquina
    objEntidadTA.NTRMNL = HelpClass.NombreMaquina
    objEntidadTA.POS_RUC_ANTERIOR = ""
    objEntidadTA.FLAG_SKIPCHECKS = 0
    objEntidadTA.SESTAC = ""
    objEntidadTA.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidadTA.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    objEntidadTA.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

    Dim objExisteTA As New TransportistaAcoplado
    objExisteTA = objEntidadTA
    objExisteTA = objLogica.Registrar_TransportistaAcoplado(objExisteTA)

        'If objExisteTA.NRUCTR = "-1" Then 'ocurrio un error
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'ElseIf objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
        '  objEntidadTA.FLAG_SKIPCHECKS = 1
        '  objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '  If objEntidadTA.NRUCTR = "-1" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        '    'Else
        '    'Listar_ResumenAcoplados()
        '  End If

        'ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '  Dim objLogicaCia As New Transportista_BLL

        '  'valida q no se asigne a la misma cia q ya lo tiene
        '  If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
        '    'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '    If objExisteTA.SESTAC = "*" Then
        '      objEntidadTA.FLAG_SKIPCHECKS = 1
        '      objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '      If objEntidadTA.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenAcoplados()
        '      End If
        '    Else
        '                'HelpClass.MsgBox("Acoplado ya asignado.", MessageBoxIcon.Error)
        '                MessageBox.Show("Acoplado ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '      Exit Sub
        '    End If
        '  Else ' cambio de otra compañia
        '    Dim objCia1 As New Transportista
        '    objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
        '    objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '    objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        '            objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

        '            Dim olbeCia1 As New List(Of Transportista)
        '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '            If olbeCia1.Count = 0 Then Exit Sub
        '            'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '            objCia1 = olbeCia1.Item(0)

        '    Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
        '                            "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
        '                            "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                            "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

        '    If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '      objEntidadTA.FLAG_SKIPCHECKS = 1
        '      objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '      If objEntidadTA.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '      End If
        '    End If
        '  End If
        'End If


        'If objExisteTA.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else

        If objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTA.FLAG_SKIPCHECKS = 1
            objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
            'If objEntidadTA.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            '    'Else
            '    'Listar_ResumenAcoplados()
            'End If

        ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTA.SESTAC = "*" Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
                    'If objEntidadTA.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    '    'Else
                    '    'Listar_ResumenAcoplados()
                    'End If
                Else
                    'HelpClass.MsgBox("Acoplado ya asignado.", MessageBoxIcon.Error)
                    MessageBox.Show("Acoplado ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
                                        "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
                    'If objEntidadTA.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If
            End If
        End If

  End Sub

  Private Sub Registrar_ConductorTransportista(ByVal strConductor As String, ByVal strObservacion As String)
    Dim objEntidadTC As New TransportistaConductor
    Dim objLogica As New TransportistaConductor_BLL
    objEntidadTC.NRUCTR = txtNroRuc.Text
    objEntidadTC.CBRCNT = strConductor
    objEntidadTC.FECINI = HelpClass.TodayNumeric
    objEntidadTC.FECFIN = HelpClass.TodayNumeric
    objEntidadTC.TOBS = strObservacion
    objEntidadTC.CUSCRT = MainModule.USUARIO
    objEntidadTC.FCHCRT = HelpClass.TodayNumeric
    objEntidadTC.HRACRT = HelpClass.NowNumeric
    objEntidadTC.NTRMCR = HelpClass.NombreMaquina
    objEntidadTC.NTRMNL = HelpClass.NombreMaquina
    objEntidadTC.POS_RUC_ANTERIOR = ""
    objEntidadTC.FLAG_SKIPCHECKS = 0
    objEntidadTC.SESTCH = ""

    objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidadTC.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    objEntidadTC.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

    Dim objExisteTC As New TransportistaConductor
    objExisteTC = objEntidadTC
    objExisteTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)

        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'ElseIf objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
        '  objEntidadTC.FLAG_SKIPCHECKS = 1
        '  objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '  objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '  If objEntidadTC.NRUCTR = "-1" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        '    'Else
        '    'Listar_ResumenConductores()
        '  End If

        'ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '  Dim objLogicaCia As New Transportista_BLL

        '  'valida q no se asigne a la misma cia q ya lo tiene
        '  If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
        '    'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '    If objExisteTC.SESTCH = "*" Then
        '      objEntidadTC.FLAG_SKIPCHECKS = 1
        '      objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '      objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '      If objEntidadTC.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenConductores()
        '      End If
        '    Else
        '                'HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
        '                MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '      Exit Sub
        '    End If
        '  Else ' cambio de otra compañia
        '    Dim objCia1 As New Transportista
        '    objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
        '    objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '    objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        '    objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

        '            Dim olbeCia1 As New List(Of Transportista)
        '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '            If olbeCia1.Count = 0 Then Exit Sub
        '            objCia1 = olbeCia1.Item(0)
        '            'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '            Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
        '                                    "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
        '                                    "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                    "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

        '            If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '                objEntidadTC.FLAG_SKIPCHECKS = 1
        '                objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '                objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '                If objEntidadTC.NRUCTR = "-1" Then
        '                    HelpClass.ErrorMsgBox()
        '                    Exit Sub
        '                End If
        '            End If

        '        End If
        'End If


        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        If objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTC.FLAG_SKIPCHECKS = 1
            objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
            'If objEntidadTC.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            '    'Else
            '    'Listar_ResumenConductores()
            'End If
        ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTC.SESTCH = "*" Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                    'If objEntidadTC.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    '    'Else
                    '    'Listar_ResumenConductores()
                    'End If
                Else
                    'HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
                    MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                objCia1.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

                Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
                                        "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                    'If objEntidadTC.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If

            End If
        End If

  End Sub

#Region "TRANSPORTISTA"

  Private Sub cargarComboTransportistaAS400()
    Try

      Dim obrTransportistaAS400_BLL As New TransportistaAS400_BLL
      With Me.cboTranspAS400
        .DataSource = Nothing
        .DataSource = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))
        .KeyField = "CTRSPT"
        .ValueField = "TCMTRT"
        .DataBind()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Registrar_Transportista()
    Dim obj As New Transportista_BLL
    Dim objEntidad As New Transportista
    objEntidad.NRUCTR = Me.txtNroRuc.Text
    If cboTranspAS400.Codigo.Equals("") Then
      objEntidad.CTRSPT = 0
    Else
      objEntidad.CTRSPT = Integer.Parse(cboTranspAS400.Codigo)
        End If
        objEntidad.TCMTRT = Me.txtRazonSocial.Text
    objEntidad.TABTRT = Me.txtDescripcion.Text
    objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
    objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
    objEntidad.SINDRC = IIf(Me.chkTercero.Checked, "T", "P")
    objEntidad.CUSCRT = MainModule.USUARIO
    objEntidad.FCHCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
    objEntidad.NTRMCR = HelpClass.NombreMaquina
    objEntidad.NTRMNL = HelpClass.NombreMaquina
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue ' Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue ' Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue ' Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
    objEntidad.RUCPR2 = Me.txtCodigoTransportista.Text
    objEntidad = obj.Registrar_Transportista(objEntidad)

    If objEntidad.CTRSPT = 0 Then
      HelpClass.ErrorMsgBox()
      Exit Sub
    ElseIf objEntidad.CTRSPT > 0 Then
      cargarComboTransportistaAS400()
            cboTranspAS400.Codigo = objEntidad.CTRSPT
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_Transportista()
            Estado_Botones_Ultimo()
            'AccionCancelar()
    End If
  End Sub

  Private Sub Modificar_Transportista()
    Dim objEntidad As New Transportista
    Dim obj As New Transportista_BLL

    objEntidad.NRUCTR = Me.txtNroRuc.Text
    objEntidad.CTRSPT = vCodTransportista
    objEntidad.TCMTRT = Me.txtRazonSocial.Text
    objEntidad.TABTRT = Me.txtDescripcion.Text
    objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
    objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
    objEntidad.NTRMNL = HelpClass.NombreMaquina
    objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
    objEntidad.SINDRC = IIf(Me.chkTercero.Checked, "T", "P")
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidad.RUCPR2 = Me.txtCodigoTransportista.Text
    objEntidad = obj.Modificar_Transportista(objEntidad)

    If objEntidad.CTRSPT = "0" Then
      HelpClass.ErrorMsgBox()
      Exit Sub
        ElseIf objEntidad.CTRSPT > "0" Then
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_Transportista()
            Estado_Botones_Ultimo()
            'AccionCancelar()
    End If
  End Sub

  Private Sub Eliminar_Transportista()
    Dim objEntidad As New Transportista
    Dim obj As New Transportista_BLL

    objEntidad.CTRSPT = vCodTransportista
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
    objEntidad.NTRMNL = HelpClass.NombreMaquina
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

    objEntidad = obj.Eliminar_Transportista(objEntidad)

    If objEntidad.CTRSPT = 0 Then
      HelpClass.ErrorMsgBox()
      Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_Transportista()
            Estado_Botones_Ultimo()
    End If

  End Sub

    Private Sub Listar_Transportista()
        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

        Me.gwdDatos.AutoGenerateColumns = False
        objEntidad.NRUCTR = Me.txtFiltroTransportista.Text
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

        Dim estado_trans As String = cboEstado.SelectedValue
        Select Case estado_trans
            Case "1"
                objEntidad.SESTRG = "A"
            Case "2"
                objEntidad.SESTRG = "*"
        End Select
        Me.gwdDatos.DataSource = obj.Listar_Transportista(objEntidad)
        HabilitarBotonHabilitar()
        Me.gwdDatos.Columns(2).Width = 350
    End Sub

  Private Sub Limpiar_Controles_Transportista()
    cboTranspAS400.Limpiar()
    txtCodigoTransportista.Text = ""
    txtNroRuc.Text = ""
    txtRazonSocial.Text = ""
    txtDescripcion.Text = ""
    txtDireccionTransportista.Text = ""
    txtTelefonoTransportista.Text = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Transportista"
  End Sub

  Private Sub Estado_Controles_Transportista(ByVal lbool_Estado As Boolean)
    Me.txtNroRuc.Enabled = lbool_Estado
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      Me.txtNroRuc.Enabled = Not lbool_Estado
    End If
    txtCodigoTransportista.Enabled = lbool_Estado
    txtRazonSocial.Enabled = lbool_Estado
    txtDescripcion.Enabled = lbool_Estado
    txtDireccionTransportista.Enabled = lbool_Estado
    txtTelefonoTransportista.Enabled = lbool_Estado
    cboTranspAS400.Enabled = lbool_Estado
    chkTercero.Enabled = lbool_Estado
    chkTercero.Checked = lbool_Estado
  End Sub

#End Region

#Region "VEHICULO POR TRANSPORTISTA"

  Private Sub Eliminar_VehiculoTransportista()
    Dim objEntidad As New TransportistaTracto
    Dim obj As New TransportistaTracto_BLL
    Try
      objEntidad.NRUCTR = Me.txtNroRuc.Text
      objEntidad.NPLCUN = gwdResTractosTransportista.CurrentRow.Cells("NPLCUN").Value
      objEntidad.CULUSA = MainModule.USUARIO
      objEntidad.FULTAC = HelpClass.TodayNumeric
      objEntidad.HULTAC = HelpClass.NowNumeric
      objEntidad.NTRMNL = HelpClass.NombreMaquina
      objEntidad.FCHCRT = vFCHCRT
      objEntidad.HRACRT = vHRACRT
      objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
      objEntidad.CDVSN = Me.cmbDivision.SelectedValue
      objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

      objEntidad = obj.Eliminar_TransportistaTracto(objEntidad)

      If objEntidad.NRUCTR = 0 Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      Else
        Listar_ResumenVehiculos()
      End If
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message.ToString.Trim, MessageBoxIcon.Error)
    End Try
    
  End Sub

  Private Sub Listar_ResumenVehiculos()
    Dim objEntidad As New TransportistaTracto
    Dim obj As New TransportistaTracto_BLL

    objEntidad.NRUCTR = txtNroRuc.Text
    If gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    objEntidad.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
    objEntidad.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
    Me.gwdResTractosTransportista.AutoGenerateColumns = False
    gwdResTractosTransportista.DataSource = obj.Listar_TractosPorTransportista(objEntidad)
  End Sub

#End Region

#Region "ACOPLADO POR TRANSPORTISTA"

  Private Sub Eliminar_AcopladoTransportista()
    If gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "0" AndAlso _
       gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "" Then

      Dim objEntidad As New TransportistaAcoplado
      Dim obj As New TransportistaAcoplado_BLL

      objEntidad.NRUCTR = txtNroRuc.Text
      objEntidad.NPLCAC = gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value
      objEntidad.CULUSA = MainModule.USUARIO
      objEntidad.FULTAC = HelpClass.TodayNumeric
      objEntidad.HULTAC = HelpClass.NowNumeric
      objEntidad.NTRMNL = HelpClass.NombreMaquina
      objEntidad.FCHCRT = vFCHCRT
      objEntidad.HRACRT = vHRACRT
      objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
      objEntidad.CDVSN = Me.cmbDivision.SelectedValue
      objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

      objEntidad = obj.Eliminar_TransportistaAcoplado(objEntidad)

      If objEntidad.NRUCTR = "0" Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      Else
        Listar_ResumenAcoplados()
      End If
    End If
  End Sub

  Private Sub Listar_ResumenAcoplados()
    Dim objEntidad As New TransportistaAcoplado
    Dim obj As New TransportistaAcoplado_BLL

    objEntidad.NRUCTR = txtNroRuc.Text
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

    Me.gwdResAcopladosTransportista.AutoGenerateColumns = False
    gwdResAcopladosTransportista.DataSource = obj.Listar_AcopladosPorTransportista(objEntidad)
  End Sub

#End Region

#Region "CONDUCTORES POR TRANSPORTISTA"

  Private Sub Eliminar_ConductorTransportista()
    If gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "0" And _
       gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then

      Dim objEntidad As New TransportistaConductor
      Dim obj As New TransportistaConductor_BLL

      objEntidad.NRUCTR = txtNroRuc.Text
      objEntidad.CBRCNT = gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value
      objEntidad.CULUSA = MainModule.USUARIO
      objEntidad.FULTAC = HelpClass.TodayNumeric
      objEntidad.HULTAC = HelpClass.NowNumeric
      objEntidad.NTRMNL = HelpClass.NombreMaquina
      objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
      objEntidad.CDVSN = Me.cmbDivision.SelectedValue
      objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

      objEntidad = obj.Eliminar_TransportistaConductor(objEntidad)

      If objEntidad.NRUCTR = "0" Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      Else
        Listar_ResumenConductores()
      End If
    End If
  End Sub

  Private Sub Listar_ResumenConductores()
    Dim objEntidad As New TransportistaConductor
    Dim obj As New TransportistaConductor_BLL

    objEntidad.NRUCTR = txtNroRuc.Text
    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue

    Me.gwdResConductoresTransportista.AutoGenerateColumns = False
    gwdResConductoresTransportista.DataSource = obj.Listar_ConductoresPorTransportista(objEntidad)
  End Sub

#End Region

  Private Sub AccionCancelar()
    Try
      Dim lstr_PestanaActiva As String
      lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name

      If lstr_PestanaActiva = "TabDatosTransportista" Then
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
          vCodTransportista = "0"
          Limpiar_Controles_Transportista()
          Estado_Controles_Transportista(False)
          If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
          End If
        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
          Estado_Controles_Transportista(False)
          btnGuardar.Text = "Modificar"
        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
          vCodTransportista = "0"
          Limpiar_Controles_Transportista()
        End If
        btnGuardar.Visible = True
        btnCancelar.Visible = True
        Separator1.Visible = True
        Separator2.Visible = True
      Else
        If Me.gwdResTractosTransportista.RowCount > 0 AndAlso Me.gwdResTractosTransportista.CurrentCellAddress.Y > -1 Then Me.gwdResTractosTransportista.CurrentRow.Selected = False
        If Me.gwdResAcopladosTransportista.RowCount > 0 AndAlso Me.gwdResAcopladosTransportista.CurrentCellAddress.Y > -1 Then Me.gwdResAcopladosTransportista.CurrentRow.Selected = False
        If Me.gwdResConductoresTransportista.RowCount > 0 AndAlso Me.gwdResConductoresTransportista.CurrentCellAddress.Y > -1 Then Me.gwdResConductoresTransportista.CurrentRow.Selected = False
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        Separator1.Visible = False
        Separator2.Visible = False
      End If

      If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        btnGuardar.Enabled = True
        gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
      Else
        btnGuardar.Enabled = False
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
      End If
      btnNuevo.Enabled = True
      btnGuardar.Enabled = False
      btnCancelar.Enabled = False
      btnEliminar.Enabled = False
    Catch ex As Exception

    End Try

  End Sub

  Private Sub btnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqueda.Click
    Me.buscar()
  End Sub

  Private Sub buscar()
    Dim lstr_PestanaActiva As String = Me.TabTransportista.SelectedTab.Name
    If lstr_PestanaActiva <> "TabDatosTransportista" Then
      MsgBox("Debe posicionarse en la pestaña de Datos de Transportista.", MsgBoxStyle.Information)
    Else
      If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
      Else
        Listar_Transportista()
      End If
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    AccionCancelar()
  End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim lstr_PestanaActiva As String = Me.TabTransportista.SelectedTab.Name
        Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        If estado = "*" Then
            MessageBox.Show("No se puede eliminar el transportista. El transportista ya se encuentra eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

            If lstr_PestanaActiva = "TabDatosTransportista" Then
                If Me.txtNroRuc.Text <> "" Then
                    'se verifica si el transportista tiene registros relacionados
                    Dim Transportista_BLL As New Transportista_BLL
                    Dim CTRSPT As Decimal = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                    Dim CCMPN As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
                    Dim numMov As Int32 = Transportista_BLL.VerificarMovimientoTransportista(CTRSPT, CCMPN)
                    If numMov > 0 Then
                        MessageBox.Show("El transportista no puede ser eliminado.Tiene liquidaciones asociados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If Me.gwdResTractosTransportista.Rows.Count > 0 OrElse _
              Me.gwdResAcopladosTransportista.Rows.Count > 0 OrElse _
              Me.gwdResConductoresTransportista.Rows.Count > 0 Then

                        If MsgBox("Este transportista tiene asignado vehículos, acoplados y/o conductores. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                            Eliminar_Transportista()
                            'AccionCancelar()
                        Else
                            Exit Sub
                        End If
                    Else 'no tiene registros relacionados
                        Eliminar_Transportista()
                        'AccionCancelar()
                    End If
                End If


            ElseIf lstr_PestanaActiva = "TabVehiculos" Then
                If gwdResTractosTransportista.Rows.Count > 0 Then
                    Eliminar_VehiculoTransportista()
                    AccionCancelar()
                End If

            ElseIf lstr_PestanaActiva = "TabAcoplados" Then
                If gwdResAcopladosTransportista.Rows.Count > 0 Then
                    Eliminar_AcopladoTransportista()
                    AccionCancelar()
                End If

            ElseIf lstr_PestanaActiva = "TabConductores" Then
                If gwdResConductoresTransportista.Rows.Count > 0 Then
                    Eliminar_ConductorTransportista()
                    AccionCancelar()
                End If
            End If

        End If 'If del MsgBox de perg

    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Me.Asignar_Datos()
        End Select
    End Sub

  Private Sub Asignar_Datos()
    Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      If Me.gwdDatos.Rows.Count > 0 Then
        Me.gwdDatos.CurrentRow.Selected = False
      End If
      MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
      Exit Sub
    End If
    'Marcando el estado de Edición
    If Me.TabTransportista.SelectedTab.Name = "TabDatosTransportista" Then
      Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
      btnGuardar.Text = "Modificar"
      btnGuardar.Enabled = True
      btnEliminar.Enabled = True
    End If

    Limpiar_Controles_Transportista()
    _indiceGrilla = lint_indice

    vCodTransportista = Me.gwdDatos.Item("CTRSPT", lint_indice).Value.ToString().Trim()
    txtCodigoTransportista.Text = Me.gwdDatos.Item("RUCPR2", lint_indice).Value
    cboTranspAS400.Codigo = vCodTransportista
    txtNroRuc.Text = Me.gwdDatos.Item("NRUCTR", lint_indice).Value.ToString().Trim()
    txtRazonSocial.Text = Me.gwdDatos.Item("TCMTRT", lint_indice).Value.ToString().Trim()
    txtDescripcion.Text = Me.gwdDatos.Item("TABTRT", lint_indice).Value.ToString().Trim()
    txtDireccionTransportista.Text = Me.gwdDatos.Item(5, lint_indice).Value.ToString().Trim()
    txtTelefonoTransportista.Text = Me.gwdDatos.Item(4, lint_indice).Value.ToString().Trim()
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de transportista / Razón Social: " & txtRazonSocial.Text & "; RUC: " & txtNroRuc.Text.Trim
    chkTercero.Checked = Me.gwdDatos.Item("SINDRC", lint_indice).Value.ToString().Trim().ToUpper.Equals("T")
    ActualizarTabs()
  End Sub

  Private Sub ActualizarTabs()
    Listar_ResumenVehiculos()
    Listar_ResumenAcoplados()
    Listar_ResumenConductores()
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    Try
      If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = True
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub TabTransportista_Deselecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabTransportista.Deselecting
    If vCodTransportista = "0" AndAlso Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL Then
      e.Cancel = True
      HelpClass.MsgBox("Seleccione un Transportista en la parte superior del formulario.", MsgBoxStyle.Exclamation)
    ElseIf vCodTransportista = "0" AndAlso (Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR) Then
      e.Cancel = True
      HelpClass.MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
    ElseIf vCodTransportista <> "0" AndAlso (Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO) Then
      e.Cancel = True
      HelpClass.MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
    End If
  End Sub

  Private Sub txtNroRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRuc.KeyPress, txtCodigoTransportista.KeyPress
    Select Case Asc(e.KeyChar)
      Case 48 To 57
      Case 8, 13
      Case Else : e.Handled = True
    End Select
  End Sub

  Private Sub txtFiltroTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroTransportista.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter : buscar()
    End Select
  End Sub

  Private Sub txtFiltroTransportista_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroTransportista.KeyPress
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Information)
      e.Handled = True
    End If
  End Sub

  Private Sub TabTransportista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTransportista.SelectedIndexChanged
    AccionCancelar()
  End Sub

  Private Sub gwdResConductoresTransportista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResConductoresTransportista.CellClick
    If e.RowIndex < 0 OrElse Me.gwdResConductoresTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspConductor()
  End Sub

  Private Sub llenarControlesTabTranspConductor()
    Dim lint_indice As Integer = Me.gwdResConductoresTransportista.CurrentCellAddress.Y
    btnEliminar.Enabled = True
    vFCHCRT = Me.gwdResConductoresTransportista.Item("FCHCRT_TRACTO", lint_indice).Value.ToString().Trim()
    vHRACRT = Me.gwdResConductoresTransportista.Item("HRACRT_TRACTO", lint_indice).Value.ToString().Trim()
  End Sub

  Private Sub llenarControlesTabTranspAcoplado()
    Dim lint_indice As Integer = Me.gwdResAcopladosTransportista.CurrentCellAddress.Y
    btnEliminar.Enabled = True
    vFCHCRT = Me.gwdResAcopladosTransportista.Item("FCHCRT", lint_indice).Value.ToString().Trim()
    vHRACRT = Me.gwdResAcopladosTransportista.Item("HRACRT", lint_indice).Value.ToString().Trim()
  End Sub

  Private Sub gwdResAcopladosTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResAcopladosTransportista.CellDoubleClick
    If e.RowIndex < 0 OrElse gwdResAcopladosTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspAcoplado()

    If "NPLCAC" = gwdResAcopladosTransportista.Columns(gwdResAcopladosTransportista.CurrentCellAddress.X).Name Then
      Dim NPLCAC As Object = gwdResAcopladosTransportista.Item("NPLCAC", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value
      If NPLCAC IsNot Nothing AndAlso NPLCAC IsNot DBNull.Value Then
        Dim f As New frmInformacionAcoplado(NPLCAC.ToString)
        f.CCMPN = cmbCompania.SelectedValue.ToString()
        f.ShowForm(Me)
      End If
    End If

  End Sub

  Private Sub gwdResAcopladosTransportista_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdResAcopladosTransportista.DataBindingComplete
    Try
      If Me.gwdResAcopladosTransportista.Rows.Count > 0 Then
        Me.gwdResAcopladosTransportista.CurrentRow.Selected = False
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub gwdResConductoresTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResConductoresTransportista.CellDoubleClick
    If e.RowIndex < 0 OrElse gwdResConductoresTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspConductor()

    If "CBRCNT" = gwdResConductoresTransportista.Columns(gwdResConductoresTransportista.CurrentCellAddress.X).Name Then
      Dim lstr_CBRCNT As Object = gwdResConductoresTransportista.Item("CBRCNT", gwdResConductoresTransportista.CurrentCellAddress.Y).Value
      If lstr_CBRCNT IsNot Nothing AndAlso lstr_CBRCNT IsNot DBNull.Value Then
        Dim f As New frmInformacionChofer(lstr_CBRCNT.ToString)
        f.CCMPN = cmbCompania.SelectedValue.ToString()
        f.ShowForm(Me)
      End If
    End If
  End Sub

  Private Sub gwdResConductoresTransportista_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdResConductoresTransportista.DataBindingComplete
    Try
      If Me.gwdResConductoresTransportista.Rows.Count > 0 Then
        Me.gwdResConductoresTransportista.CurrentRow.Selected = False
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub gwdResAcopladosTransportista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResAcopladosTransportista.CellClick
    If e.RowIndex < 0 OrElse Me.gwdResAcopladosTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspAcoplado()
  End Sub


  Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
    dt.TableName = dtName
    Return dt
  End Function

  Private Sub gwdResTractosTransportista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResTractosTransportista.CellClick
    If e.RowIndex < 0 OrElse Me.gwdResTractosTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspTracto()
  End Sub

  Private Sub llenarControlesTabTranspTracto()
    Dim y As Integer = Me.gwdResTractosTransportista.CurrentCellAddress.Y
    btnEliminar.Enabled = True
    vFCHCRT = Me.gwdResTractosTransportista.Item("FCHCRT_VH", y).Value.ToString().Trim()
    vHRACRT = Me.gwdResTractosTransportista.Item("HRACRT_VH", y).Value.ToString().Trim()
  End Sub

  Private Sub gwdResTractosTransportista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResTractosTransportista.CellDoubleClick
    If e.RowIndex < 0 OrElse gwdResTractosTransportista.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    llenarControlesTabTranspTracto()
    Dim CCMPN As String = cmbCompania.SelectedValue.ToString()
    If "NPLCUN" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
      Dim NPLCUN As Object
      NPLCUN = gwdResTractosTransportista.Item("NPLCUN", gwdResTractosTransportista.CurrentCellAddress.Y).Value
      If NPLCUN IsNot DBNull.Value AndAlso NPLCUN IsNot Nothing Then
        Dim f As New frmInformacionTracto(NPLCUN.ToString)
        f.CCMPN = CCMPN
        f.ShowForm(Me)
      End If

    ElseIf "NPLACP" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
      Dim NPLACP As Object
      NPLACP = gwdResTractosTransportista.Item("NPLACP", gwdResTractosTransportista.CurrentCellAddress.Y).Value
      If NPLACP IsNot DBNull.Value AndAlso NPLACP IsNot Nothing AndAlso NPLACP <> vbNullString Then
        Dim f As New frmInformacionAcoplado(NPLACP.ToString)
        f.CCMPN = CCMPN
        f.ShowForm(Me)
      End If

    ElseIf "CBRCND" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
      Dim CBRCND As Object
      CBRCND = gwdResTractosTransportista.Item("CBRCND", gwdResTractosTransportista.CurrentCellAddress.Y).Value
      If CBRCND IsNot DBNull.Value AndAlso CBRCND IsNot Nothing Then
        Dim f As New frmInformacionChofer(CBRCND.ToString)
        f.CCMPN = CCMPN
        f.ShowForm(Me)
      End If

    End If

  End Sub

  Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
    gwdDatos.Visible = Not gwdDatos.Visible
    Select Case HeaderDatos.Dock
      Case DockStyle.Fill
        HeaderDatos.Dock = DockStyle.Bottom
      Case DockStyle.Bottom
        HeaderDatos.Dock = DockStyle.Fill
    End Select
  End Sub

  'CREA UN TRANSPORTISTA AS400 EN LA TABLA RZTR10
  Private Sub btnNuevoTranspAS400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If Me.txtNroRuc.Text = "" Then
      MsgBox("Ingrese el RUC.", MsgBoxStyle.Exclamation)
      Exit Sub
    ElseIf Me.txtNroRuc.Text.Length <> 11 Then
      MsgBox("El RUC debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
      Exit Sub
    ElseIf Me.txtRazonSocial.Text = "" Then
      MsgBox("Ingrese la razón social.", MsgBoxStyle.Exclamation)
      Exit Sub
    Else
      Dim objLogica As New TransportistaAS400_BLL
      Dim objEntidad As New Transportista

      objEntidad.NRUCTR = Me.txtNroRuc.Text
      objEntidad.TCMTRT = Me.txtRazonSocial.Text
      objEntidad.TABTRT = Me.txtDescripcion.Text
      objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
      objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
      objEntidad.CTRSPT = 0
      objEntidad.CUSCRT = MainModule.USUARIO
      objEntidad.FCHCRT = HelpClass.TodayNumeric
      objEntidad.HRACRT = HelpClass.NowNumeric
      objEntidad.NTRMCR = HelpClass.NombreMaquina
      objEntidad = objLogica.Registrar_TransportistaAS400(objEntidad)

      If objEntidad.CTRSPT = 0 Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      ElseIf objEntidad.CTRSPT > 0 Then
        Dim lint_CTRSPT As Integer = objEntidad.CTRSPT
        cargarComboTransportistaAS400()
        cboTranspAS400.Codigo = lint_CTRSPT
      End If
    End If
  End Sub

    Private Sub btnImprimirTRTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTRTodos.Click
        Dim objEntidad As New Transportista
        Me.Cursor = Cursors.WaitCursor
        Dim objPrintForm As New PrintForm
        Dim oDs As New DataSet
        Dim oDt As DataTable
        Dim objReporte As New rptListaTransportista
        Dim objLogical As New Transportista_BLL
        objEntidad.NRUCTR = Me.txtFiltroTransportista.Text
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        Dim estado_trans As String = cboEstado.SelectedValue
        Select Case estado_trans
            Case "1"
                objEntidad.SESTRG = "A"
            Case "2"
                objEntidad.SESTRG = "*"
        End Select
        oDt = HelpClass.GetDataSetNative(objLogical.Listar_Transportista(objEntidad))
        If oDt.Rows.Count = 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        oDt.TableName = "TRANSPORTISTA"
        oDs.Tables.Add(oDt.Copy)
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)
        Me.Cursor = Cursors.Default
    End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        'Dim objListDtg As New List(Of DataGridView)
        'objListDtg.Add(Me.gwdDatos)
        '    HelpClass.ExportarExcel_HTML(objListDtg)

        Try
            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. RUTAS : " & intCantRuta.ToString))
            'loEncabezados.Add(New Encabezados(objDt.TableName, Encabezados.TipoEncabezado.FILTRO, "CANT. PASAJEROS : " & " " & intCantPasajero.ToString))
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Transportista"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Transportista"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE TRANSPORTISTA"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            'objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy
            ' ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))
            Dim dt As DataTable = Grilla_SetDatasource()
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, dt))
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "TLFTRP"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                        '        Case "VVNTNC", "VVNTFC"
                        '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
                        '            'Case "TC_COBRAR", "TC_PAGAR"
                        '            ' dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
        End Try
  End Sub
    Private Function Grilla_SetDatasource() As DataTable
        Dim dtExportarExcel As New DataTable
        Crear_Estructura_Reporte_Transportista(dtExportarExcel)
        Dim dr As DataRow
        For i As Integer = 0 To Me.gwdDatos.Rows.Count - 1
            dr = dtExportarExcel.NewRow
            dr("NRUCTR") = Me.gwdDatos.Item("NRUCTR", i).Value
            dr("TCMTRT") = Me.gwdDatos.Item("TCMTRT", i).Value
            dr("TABTRT") = Me.gwdDatos.Item("TABTRT", i).Value
            dr("TLFTRP") = Me.gwdDatos.Item("TLFTRP", i).Value
            dr("TDRCTR") = Me.gwdDatos.Item("TDRCTR", i).Value
            dr("SINDRC") = Me.gwdDatos.Item("SINDRC", i).Value
            dr("TRACTOS_ASIGNADOS") = Me.gwdDatos.Item("TRACTOS_ASIGNADOS", i).Value
            dr("ACOPLADOS_ASIGNADOS") = Me.gwdDatos.Item("ACOPLADOS_ASIGNADOS", i).Value
            dr("CHOFERES_ASIGNADOS") = Me.gwdDatos.Item("CHOFERES_ASIGNADOS", i).Value
            Dim objNegocio As New Solicitud_Transporte_BLL
            Dim objHashTable As New Hashtable
            objHashTable.Add("CCMPN", Me.cmbCompania.SelectedValue)
            objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", i).Value)
            objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
            Dim strRESULTADO As String = objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
            dr("ESTADO_HOMOLOGACION") = IIf(strRESULTADO.Trim = "", "Apto", strRESULTADO.Trim)
            dtExportarExcel.Rows.Add(dr)
        Next
        Return dtExportarExcel

    End Function
    Private Sub Crear_Estructura_Reporte_Transportista(ByRef poDt As DataTable)
        poDt.Columns.Add(New DataColumn("NRUCTR", GetType(System.String)))  'Compañia
        poDt.Columns.Add(New DataColumn("TCMTRT", GetType(System.String))) 'Tipo de Documento
        poDt.Columns.Add(New DataColumn("TABTRT", GetType(System.String))) 'Numero de Documento
        poDt.Columns.Add(New DataColumn("TLFTRP", GetType(System.String))) 'Indice de Renovacion = 0
        poDt.Columns.Add(New DataColumn("TDRCTR", GetType(System.String))) 'Correlativo del Detalle
        poDt.Columns.Add(New DataColumn("SINDRC", GetType(System.String))) 'Servicio
        poDt.Columns.Add(New DataColumn("TRACTOS_ASIGNADOS", GetType(System.String))) 'Flag tipo control = ""
        poDt.Columns.Add(New DataColumn("ACOPLADOS_ASIGNADOS", GetType(System.String))) 'Unidad del Servicio
        poDt.Columns.Add(New DataColumn("CHOFERES_ASIGNADOS", GetType(System.String))) 'Cantidad del Servicio
        poDt.Columns.Add(New DataColumn("ESTADO_HOMOLOGACION", GetType(System.String))) 'Moneda de la Tarifa        
    End Sub
  Private Sub btnImprimirTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTR.Click
    If Me.gwdDatos.Rows.Count > 0 AndAlso Me.gwdDatos.CurrentCellAddress.Y >= 0 Then

      Dim f As New frmOpRptTransportista(Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
            f.StartPosition = FormStartPosition.CenterScreen
      With f
        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
        .Show(Me)
      End With


    End If
  End Sub
  
    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        Me.Asignar_Datos()
    End Sub
    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", Me.cmbCompania.SelectedValue)
        objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        If e.ColumnIndex = 14 Then
            Dim strResultado As String = Validar_Proveedor_Homologado()
            If strResultado.Trim = "" Then
                strResultado = "Apto"
            End If
            HelpClass.MsgBox("Estado Homologación : " & strResultado, MessageBoxIcon.Information)
            
        End If
    End Sub
    Private Sub Estado_Botones_Ultimo()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Estado_Controles_Transportista(False)
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub HabilitarBotonHabilitar()
        If gwdDatos.Rows.Count > 0 Then
            Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
            Select Case estado
                Case "A"
                    btnHabilitar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Case "*"
                    btnHabilitar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End Select
        Else
            btnHabilitar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
    End Sub
    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        HabilitarBotonHabilitar()
    End Sub

    Private Sub btnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitar.Click
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        Select Case estado
            Case "A"
                MessageBox.Show("El transportista se encuentra Activado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "*"
                If MessageBox.Show("Está seguro de Activar el transportista con RUC :" & ("" & gwdDatos.CurrentRow.Cells("NRUCTR").Value).ToString.Trim, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim oTransportista_BLL As New Transportista_BLL
                    Dim objEntidad As New Transportista
                    objEntidad.CCMPN = ("" & gwdDatos.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                    objEntidad.NRUCTR = ("" & gwdDatos.CurrentRow.Cells("NRUCTR").Value).ToString.Trim
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.NTRMNL = HelpClass.NombreMaquina
                    oTransportista_BLL.ActivarTransportista(objEntidad)
                    MessageBox.Show("El transportista ha sido Activado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Listar_Transportista()
                    'gwdDatos.CurrentRow.Cells("SESTRG").Value = "A"
                    HabilitarBotonHabilitar()
                End If
        End Select

    End Sub
End Class
