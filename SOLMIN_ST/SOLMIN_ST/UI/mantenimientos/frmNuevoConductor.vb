Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones

Public Class frmNuevoConductor

    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private pbolTipo As Boolean
    Public objEntidad As Chofer

    Public Sub New(Optional ByVal bolTipo As Boolean = False)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        pbolTipo = bolTipo
        'If bolTipo Then
        '    txtCodigoBrevete.Visible = True
        'End If
    End Sub


    Private _CBRCNT As String

    ''' <summary>
    ''' Brevete
    ''' </summary>
    ''' <returns>Brevete</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CBRCNT() As String
        Get
            Return _CBRCNT
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


    Private Sub frmNuevoConductor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Pone el flag en neutral
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False

            'Limpia los controles
            Limpiar_Controles_Chofer()
            CargarComboTipoLicenciaConducir()

            'bloquea los controles de los tabs
            'Estado_Controles_Chofer(False)
            'EstadoBoton(gEnum_Mantenimiento)
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)

            If pbolTipo = True Then
                txtCodigoBrevete.Enabled = True
                'Else
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            'btnNuevo.Enabled = False

            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            'btnNuevo.Enabled = False
            'btnGuardar.Text = "Guardar"
            'btnGuardar.Enabled = True
            'btnCancelar.Enabled = True
            'btnEliminar.Enabled = False
            Limpiar_Controles_Chofer()
            'Estado_Controles_Chofer(True)
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            'btnNuevo.Enabled = True

            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If validarChofer() = 1 Then
                    Nuevo_Registro_Chofer()
          'Accion_cancelar()
                End If
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If txtCodigoBrevete.Text <> "" And validarChofer() = 1 Then
                    Modificar_Registro_Chofer()
          'Accion_cancelar()
                End If
                'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                '    Estado_Controles_Chofer(True)
                '    'btnGuardar.Text = "Guardar"
                '    'controles habilitados para cancelar una modificacion
                '    'btnNuevo.Enabled = False
                '    'btnCancelar.Enabled = True
                '    'btnEliminar.Enabled = False
                '    'prepara para la sgte accion del btnGuardar (guardar en BD)
                '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#Region "CONDUCTOR"

  Private Sub Nuevo_Registro_Chofer()
    objEntidad = New Chofer
    Dim objChofer As New Chofer_BLL

    objEntidad.CBRCNT = Me.txtCodigoBrevete.Text
    objEntidad.TNMCMC = Me.txtNombres.Text
    objEntidad.TAPPAC = Me.txtApellidoPaterno.Text
    objEntidad.TAPMAC = Me.txtApellidoMaterno.Text
    objEntidad.NLELCH = Me.txtDni.Text
    objEntidad.CSGRSC = Me.txtSeguroSocial.Text
    objEntidad.TGRPSN = Me.txtGrupoSanguineo.Text
    objEntidad.NCLICO = CboTipoLicenciaConducir.Codigo
    objEntidad.FVEDNI = Format(Me.dtpDatFecVencDNI.Value, "yyyyMMdd")
    objEntidad.FEMLIC = Format(Me.dtpDatFecEmLic.Value, "yyyyMMdd")
    objEntidad.FVELIC = Format(Me.dtpDatFecVencLic.Value, "yyyyMMdd")
    objEntidad.CODSAP = Me.txtDatCodSAP.Text
    objEntidad.FCHING = Format(Me.dtpDatFecIng.Value, "yyyyMMdd")
    objEntidad.TDRCC = Me.txtDatDireccion.Text
    objEntidad.NRORPM = IIf(Me.txtDatRPM.Text = "", 0, Me.txtDatRPM.Text)
    objEntidad.TOBS = Me.txtDatObservaciones.Text
    objEntidad.CUSCRT = MainModule.USUARIO
    objEntidad.FCHCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.SINDRC = IIf(chkTercero.Checked, "T", "P")
    objEntidad.CCMPN = _CCMPN

    objEntidad = objChofer.Registrar_Chofer(objEntidad)

        _CBRCNT = objEntidad.CBRCNT
        _TOBS = Me.txtDatObservaciones.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK

        'If objEntidad.CBRCNT = "0" Then
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'Else
        '  _CBRCNT = objEntidad.CBRCNT
        '  _TOBS = Me.txtDatObservaciones.Text
        '  Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If
  End Sub

  Private Sub Modificar_Registro_Chofer()
    objEntidad = New Chofer
    Dim objChofer As New Chofer_BLL

    objEntidad.CBRCNT = Me.txtCodigoBrevete.Text
    objEntidad.TNMCMC = Me.txtNombres.Text
    objEntidad.TAPPAC = Me.txtApellidoPaterno.Text
    objEntidad.TAPMAC = Me.txtApellidoMaterno.Text
    objEntidad.NLELCH = Me.txtDni.Text
    objEntidad.CSGRSC = Me.txtSeguroSocial.Text
    objEntidad.TGRPSN = Me.txtGrupoSanguineo.Text
    objEntidad.NCLICO = CboTipoLicenciaConducir.Codigo
    objEntidad.FVEDNI = Format(Me.dtpDatFecVencDNI.Value, "yyyyMMdd")
    objEntidad.FEMLIC = Format(Me.dtpDatFecEmLic.Value, "yyyyMMdd")
    objEntidad.FVELIC = Format(Me.dtpDatFecVencLic.Value, "yyyyMMdd")
    objEntidad.CODSAP = Me.txtDatCodSAP.Text
    objEntidad.FCHING = Format(Me.dtpDatFecIng.Value, "yyyyMMdd")
    objEntidad.TDRCC = Me.txtDatDireccion.Text
    objEntidad.NRORPM = IIf(Me.txtDatRPM.Text.Trim.ToString = "", 0, Me.txtDatRPM.Text)
    objEntidad.TOBS = Me.txtDatObservaciones.Text
    objEntidad.CUSCRT = MainModule.USUARIO
    objEntidad.FCHCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.SINDRC = IIf(chkTercero.Checked, "T", "P")
    objEntidad.CCMPN = _CCMPN

    objEntidad = objChofer.Modificar_Chofer(objEntidad)

        _CBRCNT = Me.txtCodigoBrevete.Text
        _TOBS = Me.txtDatObservaciones.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK

        'If objEntidad.CBRCNT = "0" Then
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'Else
        '  _CBRCNT = Me.txtCodigoBrevete.Text
        '  _TOBS = Me.txtDatObservaciones.Text
        '  Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If

  End Sub

  Private Sub Eliminar_Chofer()
    Dim objEntidad As New Chofer
    Dim objChofer As New Chofer_BLL

    objEntidad.CBRCNT = Me.txtCodigoBrevete.Text
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objChofer.Eliminar_Chofer(objEntidad)

        Limpiar_Controles_Chofer()

        'If objEntidad.CBRCNT = "0" Then
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'Else
        '  Limpiar_Controles_Chofer()
        'End If
  End Sub


  Private Function validarChofer() As Integer
    If Me.txtCodigoBrevete.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el código de brevete.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtNombres.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el nombre del chofer.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtApellidoPaterno.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el apellido paterno.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtApellidoMaterno.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el apellido materno.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.CboTipoLicenciaConducir.Codigo = "" Or Me.CboTipoLicenciaConducir.Codigo = "0" Then
      MsgBox("Seleccione el tipo de licencia.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtDni.Text.Trim = "" Then
      HelpClass.MsgBox("Ingrese el DNI.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Me.txtDni.Text.Length <> 8 Then
      HelpClass.MsgBox("El DNI debe tener 8 digitos.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf dtpDatFecEmLic.Value > dtpDatFecVencLic.Value Then
      HelpClass.MsgBox("La fecha de vencimiento debe ser posterior a la fecha de emisión de licencia.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf chkTercero.Checked AndAlso txtDatCodSAP.Text.Trim <> "" Then
      HelpClass.MsgBox("Los terceros no pueden tener Código SAP.", MsgBoxStyle.Exclamation)
      Return 0
    ElseIf Not chkTercero.Checked AndAlso txtDatCodSAP.Text.Trim = "" Then
      HelpClass.MsgBox("Debe especificar un Código SAP.", MsgBoxStyle.Exclamation)
      Return 0
    End If

    Return 1
  End Function

  Private Sub Limpiar_Controles_Chofer()
    txtApellidoMaterno.Text = ""
    txtApellidoPaterno.Text = ""
    txtCodigoBrevete.Text = ""
    txtDni.Text = ""
    txtGrupoSanguineo.Text = ""
    txtNombres.Text = ""
    txtSeguroSocial.Text = ""
    CboTipoLicenciaConducir.Limpiar()

    Me.dtpDatFecVencDNI.Value = Now
    Me.dtpDatFecEmLic.Value = Now
    Me.dtpDatFecVencLic.Value = Now
    Me.txtDatCodSAP.Text = ""
    Me.dtpDatFecIng.Value = Now
    Me.txtDatDireccion.Text = ""
    Me.txtDatRPM.Text = ""
    Me.txtDatObservaciones.Text = ""

    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Conductor."
    Me.imgConductor.Image = Nothing
  End Sub

    'Private Sub Estado_Controles_Chofer(ByVal lbool_Estado As Boolean)
    '  If Not pbolTipo Then Me.txtCodigoBrevete.Enabled = lbool_Estado
    '  If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
    '    Me.txtCodigoBrevete.Enabled = Not lbool_Estado
    '  End If
    '  Me.txtApellidoMaterno.Enabled = lbool_Estado
    '  Me.txtApellidoPaterno.Enabled = lbool_Estado
    '  Me.txtDni.Enabled = lbool_Estado
    '  Me.txtGrupoSanguineo.Enabled = lbool_Estado
    '  Me.txtNombres.Enabled = lbool_Estado
    '  Me.txtSeguroSocial.Enabled = lbool_Estado
    '  Me.CboTipoLicenciaConducir.Enabled = lbool_Estado
    '  Me.KryptonButton1.Enabled = lbool_Estado

    '  Me.dtpDatFecVencDNI.Enabled = lbool_Estado
    '  Me.dtpDatFecEmLic.Enabled = lbool_Estado
    '  Me.dtpDatFecVencLic.Enabled = lbool_Estado
    '  Me.txtDatCodSAP.Enabled = lbool_Estado
    '  Me.dtpDatFecIng.Enabled = lbool_Estado
    '  Me.txtDatDireccion.Enabled = lbool_Estado
    '  Me.txtDatRPM.Enabled = lbool_Estado
    '  Me.txtDatObservaciones.Enabled = lbool_Estado
    '  Me.chkTercero.Enabled = lbool_Estado

    'End Sub


    'Private Sub Accion_cancelar()
    '  btnNuevo.Enabled = True
    '  If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
    '    Limpiar_Controles_Chofer()
    '    Estado_Controles_Chofer(False)
    '  ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '    Estado_Controles_Chofer(False)
    '    Limpiar_Controles_Chofer()
    '  End If

    '  gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '  btnNuevo.Enabled = True
    '  btnGuardar.Text = "Modificar" '
    '  btnGuardar.Enabled = False
    '  btnCancelar.Enabled = False
    '  btnEliminar.Enabled = False
    'End Sub

#End Region

    Private Sub CargarComboTipoLicenciaConducir()
        'Try
        Dim obj As New TipoLicenciaConducir_BLL
        Dim objEntidad As New TipoLicenciaConducir
        objEntidad.CCATLI = ""
        CboTipoLicenciaConducir.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tipo_Licencia_Conducir(objEntidad))

        CboTipoLicenciaConducir.ValueField = "CCATLI"
        CboTipoLicenciaConducir.KeyField = "NCLICO"
        CboTipoLicenciaConducir.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Try
            uploadImagenConductor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub uploadImagenConductor()
        If Me.txtCodigoBrevete.Text <> "" Then
            Dim objformLoad As New frmUploadImagen
            objformLoad.ShowForm("conductor", txtCodigoBrevete.Text, Me)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Accion_cancelar()
        Try
            Limpiar_Controles_Chofer()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            If pbolTipo = True Then
                txtCodigoBrevete.Enabled = True
            End If

          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


  Private Sub BuscarConductor()
    If Me.txtCodigoBrevete.Text.Trim.Equals("") Then Exit Sub
    Dim obeChofer As New Chofer
    Dim _vBrevete As String
    Dim obrChofer As New Chofer_BLL
    Dim olbeChofer As New List(Of Chofer)
    obeChofer.CBRCNT = Me.txtCodigoBrevete.Text
    obeChofer.CCMPN = _CCMPN
    obeChofer.ESTADO = "A"

    olbeChofer = obrChofer.Listar_Chofer(obeChofer)
    If olbeChofer.Count > 0 Then
            'btnNuevo_Click(Nothing, Nothing)
            btnModificar_Click(Nothing, Nothing)
            'Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
      _vBrevete = olbeChofer.Item(0).CBRCNT
      txtCodigoBrevete.Text = _vBrevete
      Me.txtNombres.Text = olbeChofer.Item(0).TNMCMC
      Me.txtApellidoPaterno.Text = olbeChofer.Item(0).TAPPAC
      Me.txtApellidoMaterno.Text = olbeChofer.Item(0).TAPMAC
      Me.CboTipoLicenciaConducir.Codigo = olbeChofer.Item(0).NCLICO
      Me.txtDni.Text = olbeChofer.Item(0).NLELCH
      Me.txtSeguroSocial.Text = olbeChofer.Item(0).CSGRSC
      Me.txtGrupoSanguineo.Text = olbeChofer.Item(0).TGRPSN
      chkTercero.Checked = olbeChofer.Item(0).SINDRC.ToString().Trim().Equals("T") 'Me.gwdDatos.Item("SINDRC", lint_indice).Value.ToString().Trim().Equals("T")

      'fecha vencimiento dni
      If olbeChofer.Item(0).FVEDNI.ToString().Trim() = "" Then
        Me.dtpDatFecVencDNI.Value = Today
      Else
        'La conversión de la cadena "0" en el tipo 'Date' no es válida.
        Me.dtpDatFecVencDNI.Value = olbeChofer.Item(0).FVEDNI.ToString().Trim()
      End If

      If olbeChofer.Item(0).FEMLIC.ToString().Trim() = "" Then
        Me.dtpDatFecEmLic.Value = Today
      Else
        Me.dtpDatFecEmLic.Value = olbeChofer.Item(0).FEMLIC.ToString().Trim()
      End If

      If olbeChofer.Item(0).FVELIC.ToString().Trim() = "" Then
        Me.dtpDatFecVencLic.Value = Today
      Else
        Me.dtpDatFecVencLic.Value = olbeChofer.Item(0).FVELIC.ToString().Trim()
      End If

      Me.txtDatCodSAP.Text = olbeChofer.Item(0).CODSAP ' Me.gwdDatos.Item("CODSAP", lint_indice).Value.ToString().Trim()

      If olbeChofer.Item(0).FCHING.ToString().Trim() = "" Then
        Me.dtpDatFecIng.Value = Today
      Else
        Me.dtpDatFecIng.Value = olbeChofer.Item(0).FCHING.ToString().Trim()
      End If

      Me.txtDatDireccion.Text = olbeChofer.Item(0).TDRCC.ToString().Trim()
      Me.txtDatRPM.Text = olbeChofer.Item(0).NRORPM.ToString().Trim()
      Me.txtDatObservaciones.Text = olbeChofer.Item(0).TOBS

      'tratando de cargar la foto del conductor 
      Dim objImage As Image
      Try
        objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/" & _vBrevete & ".jpg", True)
      Catch ex As Exception
        objImage = MainModule.LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/conductor/truck.jpg", True)
      End Try

      Me.imgConductor.Image = objImage
    Else
      If pbolTipo Then
        If Not (gEnum_Mantenimiento = MANTENIMIENTO.NUEVO) Then
                    'Accion_cancelar()
                    'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                    'EstadoBoton(gEnum_Mantenimiento)
        Else
          Dim strPlaca As String
          strPlaca = Me.txtCodigoBrevete.Text
          Limpiar_Controles_Chofer()
          Me.txtCodigoBrevete.Text = strPlaca
        End If
        HelpClass.MsgBox("Conductor no encontrado")
      Else
        Dim strPlaca As String
        strPlaca = Me.txtCodigoBrevete.Text
        Limpiar_Controles_Chofer()
        Me.txtCodigoBrevete.Text = strPlaca
      End If
    End If

  End Sub

    Private Sub txtCodigoBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBrevete.TextChanged
        Me.txtCodigoBrevete.CausesValidation = True
    End Sub

    Private Sub txtCodigoBrevete_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoBrevete.Validating
        Try
            BuscarConductor()
            Me.txtCodigoBrevete.CausesValidation = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
  End Sub

  Private Sub txtCodigoBrevete_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoBrevete.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    Me.BuscarConductor()
                    Me.txtCodigoBrevete.CausesValidation = False
            End Select
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


        'If Not pbolTipo Then Me.txtCodigoBrevete.Enabled = lbool_estado

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Me.txtCodigoBrevete.Enabled = True
        Else
            Me.txtCodigoBrevete.Enabled = False
        End If
        Me.txtApellidoMaterno.Enabled = lbool_estado
        Me.txtApellidoPaterno.Enabled = lbool_estado
        Me.txtDni.Enabled = lbool_estado
        Me.txtGrupoSanguineo.Enabled = lbool_estado
        Me.txtNombres.Enabled = lbool_estado
        Me.txtSeguroSocial.Enabled = lbool_estado
        Me.CboTipoLicenciaConducir.Enabled = lbool_estado
        Me.KryptonButton1.Enabled = lbool_estado

        Me.dtpDatFecVencDNI.Enabled = lbool_estado
        Me.dtpDatFecEmLic.Enabled = lbool_estado
        Me.dtpDatFecVencLic.Enabled = lbool_estado
        Me.txtDatCodSAP.Enabled = lbool_estado
        Me.dtpDatFecIng.Enabled = lbool_estado
        Me.txtDatDireccion.Enabled = lbool_estado
        Me.txtDatRPM.Enabled = lbool_estado
        Me.txtDatObservaciones.Enabled = lbool_estado
        Me.chkTercero.Enabled = lbool_estado


    End Sub

End Class
