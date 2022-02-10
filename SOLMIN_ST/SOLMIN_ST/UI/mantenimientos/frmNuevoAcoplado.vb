Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmNuevoAcoplado

    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private pbolTipo As Boolean
    Public objEntidad As New Acoplado

    Public Sub New(Optional ByVal bolTipo As Boolean = False)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        pbolTipo = bolTipo
        'If bolTipo Then
        '    txtObsAcopladoTransportista.Visible = True
        '    lblObservaciones.Visible = True
        '    txtPlacaAcoplado.Enabled = True
        'End If

       

    End Sub


    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Private _NPLCAC As String

    Public ReadOnly Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
    End Property

    Private _TOBS As String

    ''' <summary>
    ''' Observación
    ''' </summary>
    ''' <value></value>
    ''' <returns>Observaciones</returns>
    ''' <remarks></remarks>
    ''' 

    Public ReadOnly Property TOBS() As String
        Get
            Return _TOBS
        End Get
    End Property


    Private _TIPO As String
    Public Property TIPO() As String
        Get
            Return _TIPO
        End Get
        Set(ByVal value As String)
            _TIPO = value
        End Set
    End Property

    Private _STPACP As String
    Public Property STPACP() As String
        Get
            Return _STPACP
        End Get
        Set(ByVal value As String)
            _STPACP = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CPLNDV As Decimal
    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property


    Private _NRUCTR As String
    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Private Sub frmNuevoAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Pone el flag en neutral
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False

            If _TIPO = "T" Then
                lblTipo.Visible = False
                cboTipo.Visible = False

            Else
                lblTipo.Visible = True
                cboTipo.Visible = True
            End If

            Cargar_Tipo()
            'Limpia los controles
            Me.Limpiar_Controles()
            'Estado_Controles(False)
            CargarComboTipoAcoplado()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)

            If pbolTipo = True Then
                txtObsAcopladoTransportista.Visible = True
                lblObservaciones.Visible = True
                txtPlacaAcoplado.Enabled = True
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            'btnNuevo.Enabled = False
            'btnGuardar.Text = "Guardar"
            'btnGuardar.Enabled = True
            'btnCancelar.Enabled = True
            'btnEliminar.Enabled = False
            Limpiar_Controles()
            'Estado_Controles(True)
            'CargarComboTipoAcoplado()
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Function validarAcoplado() As Integer
        If txtPlacaAcoplado.Text = "" Then
            HelpClass.MsgBox("Debe ingresar la placa del acoplado.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf cboTipoAcoplado.Codigo = "" Then
            HelpClass.MsgBox("Debe seleccionar el tipo de acoplado.", MsgBoxStyle.Exclamation)
            Return 0
        End If

        If _TIPO = "P" Then
            If cboTipo.SelectedValue = "0" Then
                HelpClass.MsgBox("Debe seleccionar un tipo.", MsgBoxStyle.Exclamation)
                Return 0
            End If
        End If

        Return 1
    End Function

    Sub Cargar_Tipo()

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("STPVHP", Type.GetType("System.String"))
        dt.Columns.Add("STPVHP_S", Type.GetType("System.String"))

        dr = dt.NewRow
        dr("STPVHP") = "0"
        dr("STPVHP_S") = "::Seleccione::"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("STPVHP") = "P"
        dr("STPVHP_S") = "Propio"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("STPVHP") = "A"
        dr("STPVHP_S") = "Alquilado"
        dt.Rows.Add(dr)

        cboTipo.DataSource = dt.Copy
        cboTipo.DisplayMember = "STPVHP_S"
        cboTipo.ValueMember = "STPVHP"

    End Sub

    Sub CargarComboTipoAcoplado()
        'Try
        Dim objTipoAcoplado As New TipoAcoplado_BLL
        Dim objEntidad As New TipoAcoplado
        Dim dtTipoAcoplado As New DataTable
        dtTipoAcoplado = objTipoAcoplado.Listar_Tipo_Acoplado_Seleccion(_CCMPN)
        'cboTipoAcoplado.DataSource = HelpClass.GetDataSetNative(objTipoAcoplado.Listar_Tipo_Acoplado(objEntidad))
        cboTipoAcoplado.DataSource = dtTipoAcoplado
        cboTipoAcoplado.ValueField = "TDEACP"
        cboTipoAcoplado.KeyField = "CTIACP"
        cboTipoAcoplado.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If validarAcoplado() = 1 Then
                    Nuevo_Registro()
                    'AccionCancelar()
                End If

            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If validarAcoplado() = 1 Then
                    Modificar_Registro()
                    'AccionCancelar()
                End If
                'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                '    Me.Estado_Controles(True)
                '    btnGuardar.Text = "Guardar"
                '    btnNuevo.Enabled = False
                '    btnCancelar.Enabled = True
                '    btnEliminar.Enabled = False
                '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub AccionCancelar()
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    Limpiar_Controles()
    '    Estado_Controles(False)
    '    'btnNuevo.Enabled = True
    '    'btnGuardar.Enabled = False
    '    'btnCancelar.Enabled = False
    '    'btnEliminar.Enabled = False
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'AccionCancelar()
        Try
            Limpiar_Controles()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            If pbolTipo = True Then
                txtObsAcopladoTransportista.Visible = True
                lblObservaciones.Visible = True
                txtPlacaAcoplado.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If Me.txtPlacaAcoplado.Text <> "" And Me.txtPlacaAcoplado.Text <> "0" Then
            Dim objEntidad As New Acoplado
            Dim objTransAc As New TransportistaAcoplado_BLL
            Dim tieneDetalles As Boolean = False
            objEntidad.NPLCAC = txtPlacaAcoplado.Text
            tieneDetalles = objTransAc.Listar_Transportista_x_Acoplado(objEntidad).Count > 0

            If tieneDetalles Then
                If MsgBox("Este acoplado esta asignado a un tranportista. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    Eliminar_Registro()
                    'AccionCancelar()
                End If
            Else
                If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    Eliminar_Registro()
                    'AccionCancelar()
                End If
            End If


        End If
    End Sub



    Private Sub Nuevo_Registro()
        'Procedimiento para registrar una nuevo acoplado
        objEntidad = New Acoplado
        Dim objTipoAcoplado As New Acoplado_BLL

        Dim PesoTara As String = Me.txtPesoTara.Text.Trim
        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text.Trim
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        If PesoTara <> "" AndAlso IsNumeric(PesoTara) Then
            objEntidad.QPSTRA = Double.Parse(PesoTara)
        Else
            objEntidad.QPSTRA = 0
        End If
        objEntidad.NEJSUN = IIf(Me.txtNroEjes.Text.Trim = "", "0", Me.txtNroEjes.Text.Trim)
        objEntidad.NCPCRU = IIf(Me.txtCapacidadCarga.Text.Trim = "", "0", Me.txtCapacidadCarga.Text.Trim)
        objEntidad.NSRCHU = Me.txtNroChasis.Text.Trim
        objEntidad.QLNGAC = IIf(Me.txtLongitudAcoplado.Text.Trim = "", "0", Me.txtLongitudAcoplado.Text.Trim)
        objEntidad.QANCAC = IIf(Me.txtAnchoAcoplado.Text.Trim = "", "0", Me.txtAnchoAcoplado.Text.Trim)
        objEntidad.QALTAC = IIf(Me.txtAltoAcoplado.Text.Trim = "", "0", Me.txtAltoAcoplado.Text.Trim)
        objEntidad.CTIACP = cboTipoAcoplado.Codigo
        objEntidad.NRGMT2 = Me.txtNumeroMTC.Text.Trim
        objEntidad.TCNFG2 = Me.txtConfiguracionEjes.Text.Trim
        objEntidad.TMRCVH = Me.txtMarcaVehiculo.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = _CCMPN
        _TOBS = Me.txtObsAcopladoTransportista.Text.Trim
        Dim v_NPLCAC As String = objEntidad.NPLCAC
        objEntidad = objTipoAcoplado.Registrar_Acoplado(objEntidad)
        If objEntidad.NPLCAC = "-1" Then ' -1 : El acoplado existe en la tabla
            objEntidad.NPLCAC = v_NPLCAC
            objEntidad.CULUSA = objEntidad.CUSCRT
            objEntidad.FULTAC = objEntidad.FCHCRT
            objEntidad.HULTAC = objEntidad.HRACRT
            objEntidad.CCMPN = _CCMPN
            objEntidad = objTipoAcoplado.Modificar_Acoplado(objEntidad)
        End If
        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        _NPLCAC = objEntidad.NPLCAC
        If _TIPO = "P" Then
            _STPACP = cboTipo.SelectedValue
        Else
            _STPACP = ""
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If
    End Sub

    Private Sub Modificar_Registro()
        'Procedimiento para modificar una nueva solicitud de transporte
        Dim objEntidad As New Acoplado
        Dim objAcoplado As New Acoplado_BLL
        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text.Trim
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        objEntidad.QPSTRA = IIf(Me.txtPesoTara.Text.Trim = "", "0", Me.txtPesoTara.Text.Trim)
        objEntidad.NEJSUN = IIf(Me.txtNroEjes.Text.Trim = "", 0, Me.txtNroEjes.Text.Trim)
        objEntidad.NCPCRU = IIf(Me.txtCapacidadCarga.Text.Trim = "", 0, Me.txtCapacidadCarga.Text.Trim)
        objEntidad.NSRCHU = Me.txtNroChasis.Text.Trim
        objEntidad.QLNGAC = IIf(Me.txtLongitudAcoplado.Text.Trim = "", 0, Me.txtLongitudAcoplado.Text.Trim)
        objEntidad.QANCAC = IIf(Me.txtAnchoAcoplado.Text.Trim = "", 0, Me.txtAnchoAcoplado.Text.Trim)
        objEntidad.QALTAC = IIf(Me.txtAltoAcoplado.Text.Trim = "", 0, Me.txtAltoAcoplado.Text.Trim)
        objEntidad.CTIACP = cboTipoAcoplado.Codigo
        objEntidad.NRGMT2 = Me.txtNumeroMTC.Text.Trim
        objEntidad.TCNFG2 = Me.txtConfiguracionEjes.Text.Trim
        objEntidad.TMRCVH = Me.txtMarcaVehiculo.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = _CCMPN
        objEntidad = objAcoplado.Modificar_Acoplado(objEntidad)

        _TOBS = Me.txtObsAcopladoTransportista.Text.Trim
        _NPLCAC = objEntidad.NPLCAC
        If _TIPO = "P" Then
            _STPACP = cboTipo.SelectedValue
        Else
            _STPACP = ""
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'End If

    End Sub

    Private Sub Eliminar_Registro()
        Dim objEntidad As New Acoplado
        Dim obj As New Acoplado_BLL

        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = _CCMPN
        objEntidad = obj.Eliminar_Acoplado(objEntidad)

        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'End If
    End Sub

    Private Sub Limpiar_Controles()
        txtColorUnidad.Text = ""
        txtAltoAcoplado.Text = ""
        txtAnchoAcoplado.Text = ""
        txtPlacaAcoplado.Text = ""
        txtConfiguracionEjes.Text = ""
        txtMarcaVehiculo.Text = ""
        txtLongitudAcoplado.Text = ""
        txtCapacidadCarga.Text = ""
        txtNroChasis.Text = ""
        txtNroEjes.Text = ""
        txtNumeroMTC.Text = ""
        txtPesoTara.Text = ""
        cboTipoAcoplado.Limpiar()
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de acoplado"
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
    '    If Not pbolTipo Then Me.txtPlacaAcoplado.Enabled = lbool_Estado
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
    '        Me.txtPlacaAcoplado.Enabled = Not lbool_Estado
    '    End If
    '    Me.txtAltoAcoplado.Enabled = lbool_Estado
    '    Me.txtAnchoAcoplado.Enabled = lbool_Estado
    '    Me.txtColorUnidad.Enabled = lbool_Estado
    '    Me.txtConfiguracionEjes.Enabled = lbool_Estado
    '    Me.txtMarcaVehiculo.Enabled = lbool_Estado
    '    Me.txtLongitudAcoplado.Enabled = lbool_Estado
    '    Me.txtCapacidadCarga.Enabled = lbool_Estado
    '    Me.txtNroChasis.Enabled = lbool_Estado
    '    Me.txtNroEjes.Enabled = lbool_Estado
    '    Me.txtNumeroMTC.Enabled = lbool_Estado
    '    Me.txtPesoTara.Enabled = lbool_Estado
    '    Me.cboTipo.Enabled = lbool_Estado
    '    Me.cboTipo.SelectedIndex = 0
    '    Me.cboTipoAcoplado.Enabled = lbool_Estado
    '    txtObsAcopladoTransportista.Enabled = lbool_Estado
    'End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    

    Private Sub BuscarAcoplado()
        If txtPlacaAcoplado.Text.Trim.Equals("") Then Exit Sub
        Dim obeAcoplado As New Acoplado
        Dim obrAcoplado As New Acoplado_BLL
        Dim olbeAcoplado As New List(Of Acoplado)
        Dim Lista As New List(Of Acoplado)

        obeAcoplado.NPLCAC = Me.txtPlacaAcoplado.Text
        obeAcoplado.CCMPN = _CCMPN

        olbeAcoplado = obrAcoplado.BuscarAcoplado(obeAcoplado)

        obeAcoplado = New Acoplado

        obeAcoplado.CCMPN = _CCMPN
        obeAcoplado.CDVSN = _CDVSN
        obeAcoplado.CPLNDV = _CPLNDV
        obeAcoplado.NRUCTR = _NRUCTR
        obeAcoplado.NPLCAC = Me.txtPlacaAcoplado.Text



        If olbeAcoplado.Count > 0 Then
            'btnNuevo_Click(Nothing, Nothing)
            btnModificar_Click(Nothing, Nothing)
            Me.txtPlacaAcoplado.Text = olbeAcoplado.Item(0).NPLCAC
            Me.txtColorUnidad.Text = olbeAcoplado.Item(0).TCLRUN
            Me.txtPesoTara.Text = olbeAcoplado.Item(0).QPSTRA
            Me.txtNroEjes.Text = olbeAcoplado.Item(0).NEJSUN
            Me.txtCapacidadCarga.Text = olbeAcoplado.Item(0).NCPCRU
            Me.txtNroChasis.Text = olbeAcoplado.Item(0).NSRCHU
            Me.txtLongitudAcoplado.Text = olbeAcoplado.Item(0).QLNGAC
            Me.txtAnchoAcoplado.Text = olbeAcoplado.Item(0).QANCAC
            Me.txtAltoAcoplado.Text = olbeAcoplado.Item(0).QALTAC
            Me.cboTipoAcoplado.Codigo = olbeAcoplado.Item(0).CTIACP
            Me.txtNumeroMTC.Text = olbeAcoplado.Item(0).NRGMT2
            Me.txtConfiguracionEjes.Text = olbeAcoplado.Item(0).TCNFG2
            Me.txtMarcaVehiculo.Text = olbeAcoplado.Item(0).TMRCVH

            If _TIPO = "P" Then
                Lista = obrAcoplado.Obtener_Datos_Asignacion_Acoplado_Transportista(obeAcoplado)

                If Lista.Count > 0 Then
                    If Lista.Item(0).STPACP.Trim = "" Then
                        Me.cboTipo.SelectedValue = "0"
                    Else
                        Me.cboTipo.SelectedValue = Lista.Item(0).STPACP
                    End If
                End If
            End If

        Else
            If pbolTipo Then
                If Not (gEnum_Mantenimiento = MANTENIMIENTO.NUEVO) Then
                    'AccionCancelar()
                Else
                    Dim strPlaca As String
                    strPlaca = Me.txtPlacaAcoplado.Text
                    Limpiar_Controles()
                    Me.txtPlacaAcoplado.Text = strPlaca
        End If
      Else
        Dim strPlaca As String
        strPlaca = Me.txtPlacaAcoplado.Text
        Limpiar_Controles()
        Me.txtPlacaAcoplado.Text = strPlaca
      End If

        End If
    End Sub

    Private Sub txtPlacaAcoplado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacaAcoplado.TextChanged
        txtPlacaAcoplado.CausesValidation = True
    End Sub

    Private Sub txtPlacaAcoplado_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlacaAcoplado.Validating
        Try
            BuscarAcoplado()
            txtPlacaAcoplado.CausesValidation = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    Private Sub txtPlacaAcoplado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacaAcoplado.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                BuscarAcoplado()
                txtPlacaAcoplado.CausesValidation = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try

            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EstadoBoton(ByVal op As MANTENIMIENTO)

        Dim lbool_estado As Boolean = False
        Select Case op
            Case MANTENIMIENTO.NEUTRAL

                btnNuevo.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnModificar.Enabled = True
                btnEliminar.Enabled = True

                lbool_estado = False

            Case MANTENIMIENTO.EDITAR

                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False

                lbool_estado = True

            Case MANTENIMIENTO.NUEVO
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False

                lbool_estado = True
        End Select




        'If Not pbolTipo Then Me.txtPlacaAcoplado.Enabled = lbool_estado
        'If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
        '    Me.txtPlacaAcoplado.Enabled = Not lbool_estado
        'End If
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Me.txtPlacaAcoplado.Enabled = True
        Else
            Me.txtPlacaAcoplado.Enabled = False
        End If
        Me.txtAltoAcoplado.Enabled = lbool_estado
        Me.txtAnchoAcoplado.Enabled = lbool_estado
        Me.txtColorUnidad.Enabled = lbool_estado
        Me.txtConfiguracionEjes.Enabled = lbool_estado
        Me.txtMarcaVehiculo.Enabled = lbool_estado
        Me.txtLongitudAcoplado.Enabled = lbool_estado
        Me.txtCapacidadCarga.Enabled = lbool_estado
        Me.txtNroChasis.Enabled = lbool_estado
        Me.txtNroEjes.Enabled = lbool_estado
        Me.txtNumeroMTC.Enabled = lbool_estado
        Me.txtPesoTara.Enabled = lbool_estado
        Me.cboTipo.Enabled = lbool_estado
        Me.cboTipo.SelectedIndex = 0
        Me.cboTipoAcoplado.Enabled = lbool_estado
        txtObsAcopladoTransportista.Enabled = lbool_estado


        If pbolTipo = True Then
            txtObsAcopladoTransportista.Visible = True
            lblObservaciones.Visible = True
            txtPlacaAcoplado.Enabled = True
        End If

    End Sub

End Class
