Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos

Public Class frmNuevoTracto


    Private gEnum_Mantenimiento As MANTENIMIENTO
    Public objEntidad As Tracto
    Private pbolTipo As Boolean

    Public Sub New(Optional ByVal bolTipo As Boolean = False)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        objEntidad = New Tracto
        pbolTipo = bolTipo

        'If bolTipo Then
        '    txtObsTractoTransportista.Visible = True
        '    lblObservaciones.Visible = True
        '    txtNumPlacaUnidad.Enabled = True
        'End If
    End Sub


#Region "Propiedades"

    Private _NPLCUN As String
    ''' <summary>
    ''' Número de Placa
    ''' </summary>
    Public ReadOnly Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
    End Property


    Private _TOBS As String
    ''' <summary>
    ''' Observación
    ''' </summary>
    ''' <value></value>
    ''' <returns>Observaciones</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TOBS() As String
        Get
            Return _TOBS
        End Get
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
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

    Private _TIPO As String
    Public Property TIPO() As String
        Get
            Return _TIPO
        End Get
        Set(ByVal value As String)
            _TIPO = value
        End Set
    End Property

    Private _STPVHP As String
    Public Property STPVHP() As String
        Get
            Return _STPVHP
        End Get
        Set(ByVal value As String)
            _STPVHP = value
        End Set
    End Property




#End Region

    Private Sub frmTracto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            If _TIPO = "T" Then
                lblTipo.Visible = False
                cboTipo.Visible = False

            Else
                lblTipo.Visible = True
                cboTipo.Visible = True
            End If

            Cargar_Tipo()
            Cargar_ComboTipoTracto()
            Limpiar_Textos()
            ''Me.Estado_Controles(False)
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)

            If pbolTipo = True Then
                'txtObsTractoTransportista.Visible = True
                'lblObservaciones.Visible = True
                txtNumPlacaUnidad.Enabled = True
                'Else
            End If
            'EstadoBoton(gEnum_Mantenimiento)
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
            Limpiar_Textos()
            'Estado_Controles(True)
            'Cargar_ComboTipoTracto()
            EstadoBoton(gEnum_Mantenimiento)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If validarTracto() = 1 Then
                    Registrar()
                    'AccionCancelar()
                End If

            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If validarTracto() = 1 Then
                    Modificar()
                    'AccionCancelar()
                End If
                'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                '    Me.Estado_Controles(True)
                '    'btnGuardar.Text = "Guardar"
                '    'btnNuevo.Enabled = False
                '    'btnCancelar.Enabled = True
                '    'btnEliminar.Enabled = False
                '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub AccionCancelar()
    '    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
    '        Limpiar_Textos()
    '        Estado_Controles(False)
    '    ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '        Estado_Controles(False)
    '    End If
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    btnNuevo.Enabled = True
    '    btnGuardar.Enabled = False
    '    btnCancelar.Enabled = False
    '    btnEliminar.Enabled = False
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'AccionCancelar()
        Limpiar_Textos()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
        If pbolTipo = True Then
            txtNumPlacaUnidad.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.txtNumPlacaUnidad.Text <> "" Then
                Dim objEntidad As New Tracto
                Dim objTranspoTracto As New TransportistaTracto_BLL
                Dim tieneDetalles As Boolean = False
                objEntidad.NPLCUN = txtNumPlacaUnidad.Text
                objEntidad.CCMPN = CCMPN
                tieneDetalles = objTranspoTracto.Listar_Transportista_x_Tracto(objEntidad).Count > 0

                If tieneDetalles Then
                    If MsgBox("Este tracto esta asignado a un tranportista. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar()
                        'AccionCancelar()
                    End If
                Else
                    If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar()
                        'AccionCancelar()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub

    Private Function validarTracto() As Integer
        If txtNumPlacaUnidad.Text = "" Then
            HelpClass.MsgBox("Ingrese la placa.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf txtCodigoTipoTracto.Codigo = "" Then
            HelpClass.MsgBox("Debe seleccionar el tipo de tracto.", MsgBoxStyle.Exclamation)
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

    Public Sub Registrar()
        objEntidad = New Tracto
        Dim objTracto As New Tracto_BLL

        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text.Trim = "", 0, Me.txtNumEjes.Text.Trim)
        objEntidad.NSRCHU = Me.txtNumChasis.Text.Trim
        objEntidad.NSRMTU = Me.txtSerieMotor.Text.Trim
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text.Trim = "", 0, Me.txtFechaFabricacion.Text.Trim)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text.Trim
        objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text.Trim = "", 0, Me.txtCapCargaUnidad.Text.Trim)
        objEntidad.CTITRA = IIf(Me.txtCodigoTipoTracto.Codigo = "", 0, Me.txtCodigoTipoTracto.Codigo)
        objEntidad.QPSOTR = IIf(Me.txtPesoTracto.Text.Trim = "", 0, Me.txtPesoTracto.Text.Trim)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text.Trim
        objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text.Trim
        objEntidad.NTERPM = Me.txtNroRPM.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = _CCMPN
        _TOBS = Me.txtObsTractoTransportista.Text.Trim


        Dim v_NPLCUN As String = objEntidad.NPLCUN
        objEntidad = objTracto.Registrar_Tracto(objEntidad)

        If objEntidad.NPLCUN = "-1" Then ' -1 : El tracto existe en la tabla
            objEntidad.NPLCUN = v_NPLCUN
            objEntidad.CULUSA = objEntidad.CUSCRT
            objEntidad.FULTAC = objEntidad.FCHCRT
            objEntidad.HULTAC = objEntidad.HRACRT
            objEntidad.NTRMNL = objEntidad.NTRMCR
            objEntidad.CCMPN = _CCMPN
            objEntidad = objTracto.Modificar_Tracto(objEntidad)
        End If

        _NPLCUN = objEntidad.NPLCUN
        If _TIPO = "P" Then
            _STPVHP = cboTipo.SelectedValue
        Else
            _STPVHP = ""
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK

        'If objEntidad.NPLCUN = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    _NPLCUN = objEntidad.NPLCUN
        '    If _TIPO = "P" Then
        '        _STPVHP = cboTipo.SelectedValue
        '    Else
        '        _STPVHP = ""
        '    End If
        '    Me.DialogResult = Windows.Forms.DialogResult.OK

        'End If

    End Sub

    Public Sub Modificar()
        Dim objEntidad As New Tracto
        Dim objTracto As New Tracto_BLL

        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text.Trim = "", 0, Me.txtNumEjes.Text.Trim)
        objEntidad.NSRCHU = Me.txtNumChasis.Text.Trim
        objEntidad.NSRMTU = Me.txtSerieMotor.Text.Trim
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text.Trim = "", 0, Me.txtFechaFabricacion.Text.Trim)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text.Trim
        objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text.Trim = "", 0, Me.txtCapCargaUnidad.Text.Trim)
        objEntidad.CTITRA = Me.txtCodigoTipoTracto.Codigo
        objEntidad.QPSOTR = IIf(Me.txtPesoTracto.Text.Trim = "", 0, Me.txtPesoTracto.Text.Trim)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text.Trim
        objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text.Trim
        objEntidad.NTERPM = Me.txtNroRPM.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

     
        objEntidad = objTracto.Modificar_Tracto(objEntidad)

        _NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        _TOBS = Me.txtObsTractoTransportista.Text.Trim
        If _TIPO = "P" Then
            _STPVHP = cboTipo.SelectedValue
        Else
            _STPVHP = ""
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        'If objEntidad.NPLCUN = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'End If

    End Sub

    Public Sub Eliminar()
        Dim objEntidad As New Tracto
        Dim objTracto As New Tracto_BLL

        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objTracto.Eliminar_Tracto(objEntidad)

        'If objEntidad.NPLCUN = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'End If

    End Sub

    Private Sub Limpiar_Textos()
        Me.txtCodigoTipoTracto.Limpiar()
        Me.txtCapCargaUnidad.Text = ""
        Me.txtCarroceriaUnidad.Text = ""
        Me.txtColorUnidad.Text = ""
        Me.txtFechaFabricacion.Text = ""
        Me.txtMarcaModelo.Text = ""
        Me.txtNumChasis.Text = ""
        Me.txtNumEjes.Text = ""
        Me.txtNumEmpadMTC.Text = ""
        Me.txtNumPlacaUnidad.Text = ""
        Me.txtPesoTracto.Text = ""
        Me.txtSerieMotor.Text = ""
        Me.txtNroRPM.Text = ""
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_estado As Boolean)

    '    If Not pbolTipo Then Me.txtNumPlacaUnidad.Enabled = lbool_estado
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
    '        Me.txtNumPlacaUnidad.Enabled = Not lbool_estado
    '    End If
    '    Me.txtCodigoTipoTracto.Enabled = lbool_estado
    '    Me.txtCapCargaUnidad.Enabled = lbool_estado
    '    Me.txtCarroceriaUnidad.Enabled = lbool_estado
    '    Me.txtColorUnidad.Enabled = lbool_estado
    '    Me.txtFechaFabricacion.Enabled = lbool_estado
    '    Me.txtMarcaModelo.Enabled = lbool_estado
    '    Me.txtNumChasis.Enabled = lbool_estado
    '    Me.txtNumEjes.Enabled = lbool_estado
    '    Me.txtNumEmpadMTC.Enabled = lbool_estado
    '    Me.txtPesoTracto.Enabled = lbool_estado
    '    Me.txtSerieMotor.Enabled = lbool_estado
    '    Me.txtNroRPM.Enabled = lbool_estado
    '    cboTipo.Enabled = lbool_estado
    '    cboTipo.SelectedIndex = 0
    '    txtObsTractoTransportista.Enabled = lbool_estado


    'End Sub

    Private Sub Cargar_ComboTipoTracto()
        'Try
        Dim objTipoTracto As New TipodeTracto_BLL
        Dim objEntidad As New TipodeTracto
        objEntidad.TDETRA = ""
        objEntidad.CCMPN = _CCMPN
        Dim dtTipoTracto As New DataTable
        dtTipoTracto = objTipoTracto.Listar_TipodeTracto_seleccion(_CCMPN)
        With Me.txtCodigoTipoTracto
            '.DataSource = HelpClass.GetDataSetNative(objTipoTracto.Listar_TipodeTracto(objEntidad))
            .DataSource = dtTipoTracto
            .KeyField = "CTITRA"
            .ValueField = "TDETRA"
            .DataBind()
        End With
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BuscarPlaca()
        If Me.txtNumPlacaUnidad.Text.Trim.Equals("") Then Exit Sub
        Dim olbeEntidad As New List(Of Tracto)
        Dim Lista As New List(Of Tracto)
        Dim obeEntidad As New Tracto
        Dim objTracto As New Tracto_BLL
        obeEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        obeEntidad.CCMPN = _CCMPN
        olbeEntidad = objTracto.Obtener_Tracto(obeEntidad)

        obeEntidad = New Tracto
        obeEntidad.CCMPN = _CCMPN
        obeEntidad.CDVSN = _CDVSN
        obeEntidad.CPLNDV = _CPLNDV
        obeEntidad.NRUCTR = _NRUCTR
        obeEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim


        If olbeEntidad.Count > 0 Then
            'btnNuevo_Click(Nothing, Nothing)

            btnModificar_Click(Nothing, Nothing)
            Me.txtNumPlacaUnidad.Text = olbeEntidad.Item(0).NPLCUN
            Me.txtNumEjes.Text = olbeEntidad.Item(0).NEJSUN
            Me.txtNumChasis.Text = olbeEntidad.Item(0).NSRCHU
            Me.txtSerieMotor.Text = olbeEntidad.Item(0).NSRMTU
            Me.txtFechaFabricacion.Text = olbeEntidad.Item(0).FFBRUN
            Me.txtColorUnidad.Text = olbeEntidad.Item(0).TCLRUN
            Me.txtCarroceriaUnidad.Text = olbeEntidad.Item(0).TCRRUN
            Me.txtCapCargaUnidad.Text = olbeEntidad.Item(0).NCPCRU
            If olbeEntidad.Item(0).CTITRA.Trim.Equals("") Then
                Me.txtCodigoTipoTracto.Limpiar()
            Else
                Me.txtCodigoTipoTracto.Codigo = olbeEntidad.Item(0).CTITRA
            End If
            Me.txtPesoTracto.Text = olbeEntidad.Item(0).QPSOTR
            Me.txtMarcaModelo.Text = olbeEntidad.Item(0).TMRCTR
            Me.txtNumEmpadMTC.Text = olbeEntidad.Item(0).NRGMT1
            Me.txtNroRPM.Text = olbeEntidad.Item(0).NTERPM

            If _TIPO = "P" Then
                Lista = objTracto.Obtener_Asignacion_Tracto_Transportista(obeEntidad)
                If Lista.Count > 0 Then
                    If Lista.Item(0).STPVHP.Trim = "" Then
                        Me.cboTipo.SelectedValue = "0"
                    Else
                        Me.cboTipo.SelectedValue = Lista.Item(0).STPVHP
                    End If
                End If
            End If
        Else
            If pbolTipo Then
                If Not (gEnum_Mantenimiento = MANTENIMIENTO.NUEVO) Then
                    'AccionCancelar()
                Else
                    Dim strPlaca As String
                    strPlaca = Me.txtNumPlacaUnidad.Text
                    Limpiar_Textos()
                    Me.txtNumPlacaUnidad.Text = strPlaca
                End If
            Else
                Dim strPlaca As String
                strPlaca = Me.txtNumPlacaUnidad.Text
                Limpiar_Textos()
                Me.txtNumPlacaUnidad.Text = strPlaca
            End If

        End If

    End Sub




    Private Sub txtNumPlacaUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumPlacaUnidad.TextChanged
        txtNumPlacaUnidad.CausesValidation = True
    End Sub

    Private Sub txtNumPlacaUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumPlacaUnidad.Validating
        BuscarPlaca()
        txtNumPlacaUnidad.CausesValidation = False
    End Sub

    Private Sub txtNumPlacaUnidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumPlacaUnidad.KeyPress
        If e.KeyChar = Chr(13) Then
            BuscarPlaca()
            txtNumPlacaUnidad.CausesValidation = False
        End If
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

        'If Not pbolTipo Then Me.txtNumPlacaUnidad.Enabled = lbool_estado
        'If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
        '    Me.txtNumPlacaUnidad.Enabled = Not lbool_estado
        'End If
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Me.txtNumPlacaUnidad.Enabled = True
        Else
            Me.txtNumPlacaUnidad.Enabled = False
        End If
        Me.txtCodigoTipoTracto.Enabled = lbool_estado
        Me.txtCapCargaUnidad.Enabled = lbool_estado
        Me.txtCarroceriaUnidad.Enabled = lbool_estado
        Me.txtColorUnidad.Enabled = lbool_estado
        Me.txtFechaFabricacion.Enabled = lbool_estado
        Me.txtMarcaModelo.Enabled = lbool_estado
        Me.txtNumChasis.Enabled = lbool_estado
        Me.txtNumEjes.Enabled = lbool_estado
        Me.txtNumEmpadMTC.Enabled = lbool_estado
        Me.txtPesoTracto.Enabled = lbool_estado
        Me.txtSerieMotor.Enabled = lbool_estado
        Me.txtNroRPM.Enabled = lbool_estado
        cboTipo.Enabled = lbool_estado
        cboTipo.SelectedIndex = 0
        txtObsTractoTransportista.Enabled = lbool_estado

      
     

    End Sub

End Class
