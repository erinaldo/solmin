
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Imports System.Text
Imports SOLMIN_ST.ENTIDADES
Imports System.Threading

Public Class ucSolicitudTransportes
    Private oSeguridad As Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private _estado As Integer = 0
    Private objFormBuscarOrdenServicio As frmBuscarOrdenServicio
    Private _CTPOVJ As String = "E"
    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"

    Private oHebraEnvioEmailReq As Thread

    Private _pRequerimientoServicio As AtencionRequerimiento = Nothing
    Public Property pRequerimientoServicio() As AtencionRequerimiento
        Get
            Return _pRequerimientoServicio
        End Get
        Set(ByVal value As AtencionRequerimiento)
            _pRequerimientoServicio = value
        End Set
    End Property

    Private _pEsRequerimiento As Boolean = False
    Public Property pEsRequerimiento() As Boolean
        Get
            Return _pEsRequerimiento
        End Get
        Set(ByVal value As Boolean)
            _pEsRequerimiento = value
        End Set
    End Property


    Private _pNombreForm As String = ""
    Public Property pNombreForm() As String
        Get
            Return _pNombreForm
        End Get
        Set(ByVal value As String)
            _pNombreForm = value
        End Set
    End Property

    Public oHasLimiteCredito As New Hashtable
    Public oHasHomologacionTransportista As New Hashtable
    Sub Activateds()

        If gintEstado = 0 Then
            txtOrdenServicio.Text = ""


            txtUbigeoOrigen1.Text = ""
            txtUbigeoOrigen1.Tag = 0
            txtUbigeoDestino1.Text = ""
            txtUbigeoDestino1.Tag = 0

            txtLocalidadCarga1.Text = ""
            txtLocalidadCarga1.Tag = 0
            txtLocalidadEntrega1.Text = ""
            txtLocalidadEntrega1.Tag = 0


        End If
        If gintEstado = 2 Then
            LimpiarDatosGenerales()

            txtOrdenServicio.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
            txtTipoServicio.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPOSR
            ctbMercaderias.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR

            txtUnidadMed.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD


            txtCantidadMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.QMRCDR

            txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
            If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI = 0 Then
                txtUbigeoOrigen1.Text = ""
            Else
                txtUbigeoOrigen1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_O
                txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
            End If
            txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
            If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES = 0 Then
                txtUbigeoDestino1.Text = ""
            Else
                txtUbigeoDestino1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_D
                txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
            End If
            txtLocalidadCarga1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG
            txtLocalidadCarga1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
            txtLocalidadEntrega1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
            txtLocalidadEntrega1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

            ucNivelServ.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTTRAN

            ucTipoCarga.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTIPCG



            Dim sntViaje As String = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.COD_SNT_VJE
            If sntViaje <> "" Then
                cmbSentidoViaje.SelectedValue = sntViaje
            Else
                cmbSentidoViaje.SelectedValue = "I"
            End If

            Exit Sub
        End If
        gintEstado = -1
    End Sub


    Private Sub TipoSolicitudViaje()
        Dim oDt As New DataTable
        Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL

        Dim dtb As New List(Of TipoDatoGeneral)
        dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "TPOSOL")

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        For Each o As TipoDatoGeneral In dtb
            oDt.Rows.Add(New Object() {o.CODIGO_TIPO, o.DESC_TIPO})
        Next

        cboTipoSolViaje.DataSource = oDt
        cboTipoSolViaje.DisplayMember = "NOM"
        cboTipoSolViaje.ValueMember = "COD"
        cboTipoSolViaje.SelectedValue = "01"

    End Sub

    Sub pInicializar()
        Try

            dtgRecursosAsignados.AutoGenerateColumns = False

            Me.ckbRangoFechas.Checked = True
            KryptonCheckBox1.Checked = False
            Me.txtCantidadMercaderia.TextValidationType = ValidationInputType.Numeric
            Me.txtCantidadSolicitada.TextValidationType = ValidationInputType.Numeric
            ddlEstado.SelectedIndex = 1

            Me.Cargar_Compania()
            Me.Limpiar_Controles()


            TipoSolicitudViaje()
            'cboTipoSolViaje_SelectionChangeCommitted(cboTipoSolViaje, Nothing)

            Me.Carga_SentidoViaje()




            Me.Carga_Usuario()
            Me.Carga_TipoPrioridad()
            Me.ddlPrioridad.SelectedValue = "N"
            Me.Cargar_Combos()
            Me.Carga_MedioTransporte()
            Me.Cargar_NivelTransporte()
            Me.Cargar_TipoCarga()
            Me.Estado_Controles(False)
            Me.cboMedioTransporteFiltro.SelectedValue = 4
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            gintEstado = 0

            Me.Validar_Acceso_Opciones_Usuario()
            'Me.btnAdjuntarDocumentos.Visible = False

            If _pEsRequerimiento = True Then
                chkNumReq.Enabled = False
                chkNumReq.Checked = True
                txtNroReqFiltro.Enabled = False
                txtNroReqFiltro.Text = _pRequerimientoServicio.NUMREQT

                cmbDivision.Division = _pRequerimientoServicio.CDVSN
                cmbDivision.DivisionDefault = _pRequerimientoServicio.CDVSN
                cmbDivision.pActualizar()
                cmbDivision.pHabilitado = False

                cmbPlanta.Planta = _pRequerimientoServicio.CPLNDV
                cmbPlanta.PlantaDefault = _pRequerimientoServicio.CPLNDV
                cmbPlanta.pActualizar()
                cmbPlanta.pHabilitado = False

                txtClienteFiltro.pCargar(_pRequerimientoServicio.CCLNT)
                txtClienteFiltro.Enabled = False
                cboMedioTransporteFiltro.SelectedValue = _pRequerimientoServicio.CMEDTR
                cboMedioTransporteFiltro.Enabled = False
                ddlEstado.SelectedIndex = 0

                Listar()

            Else
                chkNumReq.Checked = False
                txtNroReqFiltro.Enabled = False
            End If
            TabSolicitudFlete.TabPages.Remove(tbUnidadProgramada)

            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            AsignarEstadoBotones(gEnum_Mantenimiento)

            TabSolicitudFlete.TabPages.Remove(tpg_recursos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

   

    Private Sub Cargar_Combos()
        Dim obj_Logica_Unidad As New NEGOCIO.UnidadMedida_BLL
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim obj_Logica_Servicio As New NEGOCIO.mantenimientos.ServicioTransporte_BLL
        Dim obj_Entidad_Servicio As New ENTIDADES.mantenimientos.ServicioTransporte
        Dim obj_Logica_Mercaderia As New NEGOCIO.mantenimientos.MercaderiaTransportes_BLL
        Dim obj_Entidad_Mercaderia As New ENTIDADES.mantenimientos.MercaderiaTransportes
        obj_Entidad_Mercaderia.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Dim obj_Logica_Ubigeo As New NEGOCIO.mantenimientos.LocalidadRuta_BLL

        Dim objTipoCarroceria As New TipoCarroceria_BLL
        With Me.ctlTipoVehiculo
            .DataSource = HelpClass.GetDataSetNative(objTipoCarroceria.Listar_TipoCarroceria(Me.cmbCompania.CCMPN_CodigoCompania))
            .KeyField = "CTPCRA"
            .ValueField = "TCMCRA"
            .DataBind()
        End With

        With Me.ctbMercaderias
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Mercaderia.Listar_MercaderiaTransportes(obj_Entidad_Mercaderia))
            .KeyField = "CMRCDR"
            .ValueField = "TCMRCD"
            .DataBind()
        End With

        obj_Entidad_Servicio.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        With Me.txtTipoServicio
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Servicio.Listar_ServicioTransporte(obj_Entidad_Servicio))
            .KeyField = "CTPOSR"
            .ValueField = "TCMTPS"
            .DataBind()
        End With



        'With Me.txtUnidadMedida
        '    .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim)
        '    .KeyField = "CUNDMD"
        '    .ValueField = "TCMPUN"
        '    .DataBind()
        'End With




    End Sub

#Region "Cargar Compania Division Planta"

    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
        Me.cboMedioTransporte.DataSource = objTabla.Copy
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"

        Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
        Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
        Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
    End Sub

    Private Sub Cargar_NivelTransporte()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New SOLMIN_ST.NEGOCIO.Consultas.AtributosOI_BLL()
        Dim lista As New List(Of SOLMIN_ST.ENTIDADES.consultas.AtributosOI)
        lista = obj.DevolverTipoSap("TIPOTRANSPSAP")
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.ucNivelServ.Etiquetas_Form = Etiquetas
        Me.ucNivelServ.DataSource = lista
        Me.ucNivelServ.ListColumnas = oListColum
        Me.ucNivelServ.Cargas()
        Me.ucNivelServ.DispleyMember = "Descripcion"
        Me.ucNivelServ.ValueMember = "Codigo"
    End Sub

    Private Sub Cargar_TipoCarga()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New SOLMIN_ST.NEGOCIO.Consultas.AtributosOI_BLL()
        Dim lista As New List(Of SOLMIN_ST.ENTIDADES.consultas.AtributosOI)
        lista = obj.DevolverTipoSap("TIPOCARGASAP")
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

        Me.ucTipoCarga.Etiquetas_Form = Etiquetas
        Me.ucTipoCarga.DataSource = lista
        Me.ucTipoCarga.ListColumnas = oListColum
        Me.ucTipoCarga.Cargas()
        Me.ucTipoCarga.DispleyMember = "Descripcion"
        Me.ucTipoCarga.ValueMember = "Codigo"
    End Sub

#End Region

    Private Function Asignar_Valor() As String

        Dim cadena As String = ""

        If Me.ddlEstado.SelectedIndex = 0 Then
            cadena = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Then
            cadena = "P"
        ElseIf Me.ddlEstado.SelectedIndex = 2 Then
            cadena = "C"
        ElseIf ddlEstado.SelectedIndex = 3 Then
            cadena = ""
        End If
        Return cadena
    End Function

    Private Function Asignar_Valor_Estado() As String
        Dim estado As String = ""

        If Me.ddlEstado.SelectedIndex = 0 Then
            estado = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Or Me.ddlEstado.SelectedIndex = 2 Then
            estado = "A"
        ElseIf ddlEstado.SelectedIndex = 3 Then
            estado = "*"
        End If
        Return estado
    End Function

    Private Sub Listar()

        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitud As New Solicitud_Transporte
        Dim objParamList As New List(Of String)

        Dim lstr_FecIni As Int32 = 0
        Dim lstr_FecFin As Int32 = 0
        Dim lstr_HoraIni As Int32 = 0
        Dim lstr_HoraFin As Int32 = 0

        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        Else
            lstr_FecIni = 0
            lstr_FecFin = 0
        End If

        If KryptonCheckBox1.Checked = True Then
            lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
            lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
        Else
            lstr_HoraIni = 0
            lstr_HoraFin = 0
        End If

        If Me.txtNroSolicitud.Text.Trim.Equals("") Then
            objSolicitud.NCSOTR = 0 'objParamList.Add("0")
        Else
            objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
        End If
        If txtClienteFiltro.pCodigo <> 0 Then
            objSolicitud.CCLNT = txtClienteFiltro.pCodigo
        Else
            objSolicitud.CCLNT = 0
        End If
        If Me.txtNroOperacion.Text.Trim.Equals("") Then
            objSolicitud.NOPRCN = 0
        Else
            objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim
        End If
        objSolicitud.SESSLC = Asignar_Valor()
        objSolicitud.SESTRG = Asignar_Valor_Estado()
        objSolicitud.FE_INI = lstr_FecIni
        objSolicitud.FE_FIN = lstr_FecFin
        objSolicitud.HR_INI = lstr_HoraIni
        objSolicitud.HR_FIN = lstr_HoraFin
        objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
        objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objSolicitud.CDVSN = Me.cmbDivision.Division
        objSolicitud.CPLNDV = Me.cmbPlanta.Planta
        If ckbUsuarioCreador.Checked = True Then
            objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
        Else
            objSolicitud.CUSCRT = ""
        End If
        objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim

        objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue

        If chkNumReq.Checked = True And txtNroReqFiltro.Text.Trim.Length > 0 Then
            objSolicitud.NUMREQT = CDec(Val(txtNroReqFiltro.Text))
        Else
            objSolicitud.NUMREQT = 0D
        End If

        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Requerimiento(objSolicitud)

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        AsignarEstadoBotones(gEnum_Mantenimiento)

    End Sub




    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then

                If validar_inputs() = True Then
                    Exit Sub
                End If
                REM ECM-HUNDRED-INICIO
                Dim CCMPN As String = Me.cmbCompania.CCMPN_CodigoCompania
                Dim CDVSN As String = Me.cmbDivision.Division
                Dim NORSRT As Decimal = txtOrdenServicio.Text.Trim
                Dim solicitudTransporteBLL As New Solicitud_Transporte_BLL
                Dim solicitudTransporteBE = New Solicitud_Transporte


                REM ECM-HUNDRED-FIN
                Me.Nuevo_Registro()

            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If validar_inputs() = True Then
                    Exit Sub
                End If
                Me.Modificar_Registro()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        AsignarEstadoBotones(gEnum_Mantenimiento)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.RowCount = 0 OrElse gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

            If Me.gwdDatos.CurrentRow.Cells("CANTOP").Value <> 0 Then
                MessageBox.Show("La solicitud tiene unidades asignadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim objSolicitudLogica As New Solicitud_Transporte_BLL
                Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
                Select Case lintStatus

                    Case Is > 0
                        MessageBox.Show("La solicitud tiene unidades asignadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select
                Dim lintCantSol As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
                Select Case lintCantSol
                    Case -1
                        HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                        Exit Sub
                    Case -2
                        HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                        Exit Sub

                End Select
            End If
            If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            Cambiar_Estado_Solicitud("*")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cambiar_Estado_Solicitud(ByVal lstr_Estado As String)
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
        'Try
        objEntidad.NCSOTR = Me.Codigo.Text
        objEntidad.SESTRG = lstr_Estado
        objEntidad.CULUSA = MainModule.USUARIO

        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = Me.cmbDivision.Division
        objEntidad.CPLNDV = Me.cmbPlanta.Planta

        objEntidad = objSolicitudTransporte.Cambiar_Estado_Solicitud_Transporte(objEntidad)
        HelpClass.MsgBox("Se Eliminó Satisfactoriamente")


        If gwdDatos.CurrentRow.Cells("NUMREQT").Value > 0 Then
            Dim objAteReq As New AtencionRequerimiento
            objAteReq.NUMREQT = gwdDatos.CurrentRow.Cells("NUMREQT").Value
            objAteReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objAteReq.CUSCRT = MainModule.USUARIO
            objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)
        End If

        Me.Listar()

    End Sub

    Private Sub Cerrar_Solicitud()
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
        'Try
        objEntidad.NCSOTR = Me.Codigo.Text
        objEntidad.SESSLC = "C"

        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = Me.cmbDivision.Division
        objEntidad.CPLNDV = Me.cmbPlanta.Planta

        objEntidad = objSolicitudTransporte.Cerrar_Solicitud_Transporte(objEntidad)
        HelpClass.MsgBox("Se Cerró Satisfactoriamente")

        If gwdDatos.CurrentRow.Cells("NUMREQT").Value > 0 Then
            Dim objAteReq As New AtencionRequerimiento
            objAteReq.NUMREQT = gwdDatos.CurrentRow.Cells("NUMREQT").Value
            objAteReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objAteReq.CUSCRT = MainModule.USUARIO
            objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)
        End If

        Me.Listar()


    End Sub

    Private Sub Nuevo_Registro()

        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objSolicitudTransporteRequerimiento As New AtencionRequerimiento_BLL


        objEntidad.NCSOTR = "0"
        objEntidad.CCLNT = txtCliente.pCodigo
        objEntidad.CMRCDR = Me.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.NORSRT = IIf(Me.txtOrdenServicio.Text = "", 0, Me.txtOrdenServicio.Text)

        If _estado = 1 Then
            objEntidad.FECOST = HelpClass.TodayNumeric
            _estado = 0
        Else
            objEntidad.FECOST = HelpClass.CtypeDate(Me.dtpFechaSolicitud.Value)
        End If

        objEntidad.CLCLOR = txtLocalidadCarga1.Tag 'Me.ctlLocalidadOrigen.Codigo
        objEntidad.TDRCOR = Me.txtDireccionLocalidadCarga.Text
        objEntidad.CLCLDS = txtLocalidadEntrega1.Tag 'Me.ctlLocalidadDestino.Codigo
        objEntidad.TDRENT = Me.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = txtUnidadMedida.Codigo
        objEntidad.CUNDMD = txtUnidadMed.Text.Trim
        objEntidad.QSLCIT = IIf(Me.txtCantidadSolicitada.Text = "", "0", Me.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(Me.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(Me.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(Me.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(Me.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text = "", "0", Me.txtCantidadMercaderia.Text)
        objEntidad.SESTRG = "A"
        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CUNDVH = Me.ctlTipoVehiculo.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO

        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO

        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = Me.txtObservaciones.Text
        'NUEVO 
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = Me.cmbDivision.Division
        objEntidad.CPLNDV = Me.cmbPlanta.Planta
        objEntidad.SFCRTV = Me.cmbSentidoViaje.SelectedValue
        objEntidad.CMEDTR = Me.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = Me.txtRefCliente.Text.Trim
        objEntidad.TRFRN = Me.txtUsuarioSolicitante.Text.Trim
        objEntidad.CTPOVJ = Me._CTPOVJ
        objEntidad.SPRSTR = Me.ddlPrioridad.SelectedValue

        objEntidad.CUBORI = txtUbigeoOrigen1.Tag 'txtUbigeoOrigen.Codigo
        objEntidad.CUBDES = txtUbigeoDestino1.Tag 'txtUbigeoDestino.Codigo
        objEntidad.CTTRAN = CType(Me.ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(Me.ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo

        Dim oTipoSolicitud As String = ("" & cboTipoSolViaje.SelectedValue)
         
        objEntidad.FATNSR = 0
        objEntidad.HATNSR = 0

        objEntidad.TPSOTR = cboTipoSolViaje.SelectedValue

        Dim msgError As String = ""
        If _pEsRequerimiento = True Then
            objEntidad.NUMREQT = _pRequerimientoServicio.NUMREQT
            objEntidad = objSolicitudTransporteRequerimiento.Registrar_Solicitud_Transporte_Requerimiento(objEntidad)

            Dim objAteReq As New AtencionRequerimiento
            objAteReq.NUMREQT = _pRequerimientoServicio.NUMREQT
            objAteReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objAteReq.CUSCRT = MainModule.USUARIO
            objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objSolicitudTransporteRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)

        Else

            objEntidad = objSolicitudTransporte.Registrar_Solicitud_Transporte(objEntidad, msgError)
        End If

        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        MessageBox.Show("Se Registró Satisfactoriamente la Solicitud N° " & objEntidad.NCSOTR, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        


        Me.Listar()

    End Sub

    Private Function SendMail(ByVal objEntidad As Solicitud_Transporte) As Boolean
        Dim strSMSRespuesta As String = ""
        Dim strServer As String = System.Configuration.ConfigurationSettings.AppSettings("ServerMail").ToString()
        Dim strMailCo As String = System.Configuration.ConfigurationSettings.AppSettings("MailCO").ToString()
        Dim strMailFrom As String = System.Configuration.ConfigurationSettings.AppSettings("MailFrom").ToString()
        Dim strMailFromClave As String = System.Configuration.ConfigurationSettings.AppSettings("MailFromClave").ToString()
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim strAdress As String = objSolicitudTransporte.Lista_Destinatarios(objEntidad)
        Dim strAsunto As String
        strAsunto = "Solicitud de Transporte -  " & Date.Today.ToString("yyyy/MM/dd") & " - " & String.Format("{0:HH:mm:ss tt}", Date.Today.Now) & " - " & "Urgente"
        If Not Ransa.Utilitario.HelpClass.flSendMail(strServer, strMailCo, strMailFrom, strMailFromClave, _
               strAdress, "", strAsunto.Trim, CrearDatosCuerpoOperacion(objEntidad), True, strSMSRespuesta) Then
            MessageBox.Show(strSMSRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    Private Function CrearDatosCuerpoOperacion(ByVal objEntidad As Solicitud_Transporte) As String
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim dt As DataTable = objSolicitudTransporte.Lista_ObtenerSolicitud_Envio(objEntidad)
        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<b> Sres. OPERACIONES TRANSPORTES.</b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")

        bodyemail.Append(" Se ha registrado la siguiente solicitud de Transporte - Urgente : ")
        bodyemail.Append(dt.Rows(0).Item("""Planta""").ToString.Trim)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)
        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        Dim color As String = ""
        Dim colum As String
        Dim strValor As String = ""

        For Each dc As Data.DataColumn In dt.Columns
            colum = dc.ColumnName.Replace("""", "")
            strValor = dt.Rows(0).Item(dc.ColumnName).ToString.Trim
            Select Case colum
                Case "Nro Solicitud"
                    strValor = strValor & "     " & dt.Rows(0).Item("""Medio Envio""").ToString.Trim & " -  " & Date.Today.ToString("yyyy/MM/dd") & " - " & String.Format("{0:HH:mm:ss tt}", Date.Today.Now)
                Case "Medio Envio", "Planta"
                    Continue For
                Case "Unidades Solicitadas", "Cliente", "Ruta"
                    color = " style= 'color:red '"
                Case Else
                    color = ""
            End Select
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='text-align:left; font-weight: bold;'> <b> ")
            bodyemail.Append("<span ")
            bodyemail.Append(color)
            bodyemail.Append(">")
            bodyemail.Append(dc.ColumnName.Replace("""", ""))
            bodyemail.Append("</span >")
            bodyemail.Append(" </b>")
            bodyemail.Append("</td>")
            bodyemail.Append("<td style='text-align:left'>")
            bodyemail.Append("<span ")
            bodyemail.Append(color)
            bodyemail.Append(">")
            bodyemail.Append(strValor)
            bodyemail.Append("</span >")
            bodyemail.Append("</td>")
            bodyemail.Append("</tr>")
        Next

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='")
        bodyemail.Append(dt.Columns.Count)
        bodyemail.Append("'; font-weight: bold>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=100%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)
        Return bodyemail.ToString.Trim
    End Function

    Private Sub Modificar_Registro()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
        Dim lintCantSol As Int32 = objSolicitudTransporte.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintCantSol
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub

        End Select

        objEntidad.NCSOTR = Me.Codigo.Text
        objEntidad.NORSRT = IIf(Me.txtOrdenServicio.Text = "", 0, Me.txtOrdenServicio.Text)
        objEntidad.CCLNT = txtCliente.pCodigo
        objEntidad.CMRCDR = Me.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.FECOST = HelpClass.CtypeDate(Me.dtpFechaSolicitud.Value)
        objEntidad.CLCLOR = txtLocalidadCarga1.Tag
        objEntidad.TDRCOR = Me.txtDireccionLocalidadCarga.Text
        objEntidad.CLCLDS = txtLocalidadEntrega1.Tag
        objEntidad.TDRENT = Me.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = txtUnidadMedida.Codigo
        objEntidad.CUNDMD = txtUnidadMed.Text.Trim
        objEntidad.QSLCIT = IIf(Me.txtCantidadSolicitada.Text = "", "0", Me.txtCantidadSolicitada.Text)
        objEntidad.FINCRG = HelpClass.CtypeDate(Me.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(Me.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(Me.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(Me.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(Me.txtCantidadMercaderia.Text = "", "0", Me.txtCantidadMercaderia.Text)
        objEntidad.CTPOSR = Me.txtTipoServicio.Codigo
        objEntidad.CUNDVH = Me.ctlTipoVehiculo.Codigo
        objEntidad.CULUSA = MainModule.USUARIO

        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = Me.txtObservaciones.Text
        objEntidad.SFCRTV = Me.cmbSentidoViaje.SelectedValue
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = Me.cmbDivision.Division
        objEntidad.CPLNDV = Me.cmbPlanta.Planta
        objEntidad.CMEDTR = Me.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = Me.txtRefCliente.Text.Trim
        objEntidad.TRFRN = Me.txtUsuarioSolicitante.Text.Trim
        objEntidad.SPRSTR = Me.ddlPrioridad.SelectedValue

        objEntidad.CUBORI = txtUbigeoOrigen1.Tag
        objEntidad.CUBDES = txtUbigeoDestino1.Tag
        objEntidad.CTTRAN = CType(ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo




        objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte(objEntidad)

        Dim numRequerimiento As Decimal = Me.gwdDatos.CurrentRow.Cells("NUMREQT").Value
        If numRequerimiento > 0 Then
            Dim objAteReq As New AtencionRequerimiento
            objAteReq.NUMREQT = numRequerimiento
            objAteReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objAteReq.CUSCRT = MainModule.USUARIO
            objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)
        End If

        MessageBox.Show("Se Modificó Satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Listar()


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If _pEsRequerimiento = True Then
                Dim olstSolReq As New List(Of Solicitud_Transporte)
                Dim objSolTrsp As New Solicitud_Transporte
                Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
                objSolTrsp.NUMREQT = _pRequerimientoServicio.NUMREQT
                objSolTrsp.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                olstSolReq = objSolicitudTransporte.Listar_Estado_Solicitud_Requerimiento(objSolTrsp)
                If olstSolReq.Count > 0 And olstSolReq.Item(0).SESREQ = "C" Then
                    MessageBox.Show("No se puede crear solicitudes, el requerimiento se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

                    Limpiar_Controles()
                    Estado_Controles(True)

                    AsignarEstadoBotones(gEnum_Mantenimiento)

                    Me.cboMedioTransporte.SelectedValue = 4

                    Cargar_Informacion()
                End If
            Else
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

                Limpiar_Controles()
                Estado_Controles(True)
                AsignarEstadoBotones(gEnum_Mantenimiento)

                Me.cboMedioTransporte.SelectedValue = 4

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Sub Cargar_Informacion()

        Me.txtOrdenServicio.Text = _pRequerimientoServicio.NORSRT
        txtCliente.pCargar(CLng(_pRequerimientoServicio.CCLNT))
        If _pRequerimientoServicio.CLCLOR_S.ToString.Trim = "" Then
        Else
            txtLocalidadCarga1.Text = _pRequerimientoServicio.CLCLOR_S
            txtLocalidadCarga1.Tag = _pRequerimientoServicio.CLCLOR
            txtLocalidadCarga1.Enabled = False
        End If

        If _pRequerimientoServicio.CLCLDS_S.ToString.Trim = "" Then
        Else
            txtLocalidadEntrega1.Text = _pRequerimientoServicio.CLCLDS_S
            txtLocalidadEntrega1.Tag = _pRequerimientoServicio.CLCLDS
            txtLocalidadEntrega1.Enabled = False
        End If

        If _pRequerimientoServicio.TDRCOR.ToString.Trim <> "" Then
            Me.txtDireccionLocalidadCarga.Text = _pRequerimientoServicio.TDRCOR.Trim
        Else
            Me.txtDireccionLocalidadCarga.Enabled = True
        End If

        If _pRequerimientoServicio.TDRENT.ToString.Trim <> "" Then
            Me.txtDireccionLocalidadEntrega.Text = _pRequerimientoServicio.TDRENT.Trim
        Else
            Me.txtDireccionLocalidadEntrega.Enabled = True
        End If

        If _pRequerimientoServicio.QSLCIT = 0D Then
            Me.txtCantidadSolicitada.Text = ""
        Else
            Me.txtCantidadSolicitada.Text = Val(_pRequerimientoServicio.QSLCIT)
        End If

        txtCantidadMercaderia.Text = _pRequerimientoServicio.QMRCDR

        If _pRequerimientoServicio.SPRSTR <> "" Then
            Me.ddlPrioridad.SelectedValue = _pRequerimientoServicio.SPRSTR
        Else
            Me.ddlPrioridad.SelectedValue = "N"
        End If

        If _pRequerimientoServicio.CMEDTR > 0 Then
            Me.cboMedioTransporte.SelectedValue = _pRequerimientoServicio.CMEDTR
        Else
            Me.cboMedioTransporte.SelectedIndex = 4
        End If
        Me.cboMedioTransporte.Enabled = False

        If _pRequerimientoServicio.CMRCDR <> "0" Then
            ctbMercaderias.Codigo = _pRequerimientoServicio.CMRCDR
        Else
            ctbMercaderias.Limpiar()
            ctbMercaderias.Enabled = True
        End If

        If _pRequerimientoServicio.CTPOSR.ToString.Trim <> "" Then
            txtTipoServicio.Codigo = _pRequerimientoServicio.CTPOSR
        Else
            txtTipoServicio.Limpiar()
            txtTipoServicio.Enabled = True
        End If

        If _pRequerimientoServicio.CUNDVH = 0D Then
            ctlTipoVehiculo.Limpiar()
            ctlTipoVehiculo.Enabled = True
        Else
            ctlTipoVehiculo.Codigo = _pRequerimientoServicio.CUNDVH
        End If

        If _pRequerimientoServicio.CUNDMD.ToString.Trim <> "" Then
            'txtUnidadMedida.Codigo = _pRequerimientoServicio.CUNDMD
            txtUnidadMed.Text = _pRequerimientoServicio.CUNDMD
        Else
            'txtUnidadMedida.Enabled = True
            'txtUnidadMedida.Limpiar()
            txtUnidadMed.Text = ""
        End If

        If _pRequerimientoServicio.CUBORI > 0 Then
            txtUbigeoOrigen1.Text = _pRequerimientoServicio.CUBORI_S
            txtUbigeoOrigen1.Tag = _pRequerimientoServicio.CUBORI
        End If

        If _pRequerimientoServicio.CUBDES > 0 Then
            txtUbigeoDestino1.Text = _pRequerimientoServicio.CUBDES_S
            txtUbigeoDestino1.Tag = _pRequerimientoServicio.CUBDES

        End If

        txtUsuarioSolicitante.Enabled = True
        cmbUsuarioSolicitante.Enabled = True

        txtCliente.Enabled = False
        txtOrdenServicio.Enabled = False
        btnBuscaOrdenServicio.Enabled = False

    End Sub


    Private Function validar_inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        'Evaluando llaves primaria de la tabla
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtCliente.pCodigo = 0 Then
                lstr_validacion = "* CODIGO DE CLIENTE " & Chr(13)
            End If
        End If

        If txtLocalidadCarga1.Tag Is Nothing OrElse txtLocalidadCarga1.Tag.ToString.Trim = "0" Then
            lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        End If
        If txtDireccionLocalidadCarga.Text.Trim = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE CARGA " & Chr(13)
        End If
        If Me.ctbMercaderias.NoHayCodigo = True Then
            lstr_validacion += "* MERCADERIA DE TRASLADO " & Chr(13)
        End If

        If txtLocalidadEntrega1.Tag Is Nothing OrElse txtLocalidadEntrega1.Tag.ToString.Trim = "0" Then
            lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        End If

        If txtDireccionLocalidadEntrega.Text.Trim = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If Me.txtOrdenServicio.Text = "" Then
            lstr_validacion += "* ORDEN DE SERVICIO" & Chr(13)
        End If
        If txtCantidadSolicitada.Text = "" Or IsNumeric(Me.txtCantidadSolicitada.Text) = False Then
            lstr_validacion += "* CANTIDAD DE VEHICULOS" & Chr(13)
        Else
            Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            If txtCantidadSolicitada.Text < lintStatus Then
                lstr_validacion += "* LA CANTIDAD DE VEHICULOS ES MENOR A LAS UNIDADES ASIGNADAS" & Chr(13)
            End If
        End If
        If txtTipoServicio.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE SERVICIO" & Chr(13)
        End If
        If Me.ctlTipoVehiculo.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
        End If
        'If Me.txtUnidadMedida.NoHayCodigo = True Then
        '    lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        'End If

        If Me.txtUsuarioSolicitante.Text.Trim = "" Then
            lstr_validacion += "* USUARIO SOLICITANTE" & Chr(13)
        End If

        If ucNivelServ.Resultado Is Nothing Then
            lstr_validacion += "* NIVEL SERVICIO" & Chr(13)
        End If

        If ucTipoCarga.Resultado Is Nothing Then
            lstr_validacion += "* TIPO CARGA" & Chr(13)
        End If

       

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)

        txtCliente.Enabled = lbool_Estado
        Me.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        Me.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
        Me.txtCantidadSolicitada.Enabled = lbool_Estado
        btnDirecciones.Enabled = lbool_Estado
        Me.txtTipoServicio.Enabled = lbool_Estado
        Me.ctlTipoVehiculo.Enabled = lbool_Estado
        Me.ctbMercaderias.Enabled = lbool_Estado
        'Me.txtUnidadMedida.Enabled = lbool_Estado
        Me.txtCantidadMercaderia.Enabled = lbool_Estado

        Me.dtpFechaInicioCarga.Enabled = lbool_Estado
        Me.dtpFinCarga.Enabled = lbool_Estado
        Me.txtObservaciones.Enabled = lbool_Estado
        Me.txtHoraCarga.Enabled = lbool_Estado
        Me.txtHoraEntrega.Enabled = lbool_Estado
        Me.txtOrdenServicio.Enabled = lbool_Estado
        Me.btnBuscaOrdenServicio.Enabled = lbool_Estado
        Me.cmbSentidoViaje.Enabled = lbool_Estado
        Me.cboMedioTransporte.Enabled = lbool_Estado
        Me.txtRefCliente.Enabled = lbool_Estado
        Me.txtUsuarioSolicitante.Enabled = lbool_Estado
        Me.cmbUsuarioSolicitante.Enabled = lbool_Estado
        Me.ddlPrioridad.Enabled = lbool_Estado

        Me.ucNivelServ.Enabled = lbool_Estado
        Me.ucTipoCarga.Enabled = lbool_Estado

        cboTipoSolViaje.Enabled = lbool_Estado

    End Sub

    Private Sub Limpiar_Controles()
        Me.Codigo.Text = 0
        txtCliente.pClear()

        Me.txtLocalidadEntrega1.Text = ""
        Me.txtLocalidadEntrega1.Tag = 0
        Me.txtLocalidadCarga1.Text = ""
        Me.txtLocalidadCarga1.Tag = 0

        Me.txtUbigeoOrigen1.Text = ""
        Me.txtUbigeoOrigen1.Tag = 0
        Me.txtUbigeoDestino1.Text = ""
        Me.txtUbigeoDestino1.Tag = 0


        Me.dtpFechaSolicitud.Value = Date.Now


        Me.txtDireccionLocalidadCarga.Text = ""


        Me.txtDireccionLocalidadEntrega.Text = ""
        Me.txtCantidadSolicitada.Text = ""
        Me.txtTipoServicio.Limpiar()
        Me.ctlTipoVehiculo.Limpiar()
        Me.ctbMercaderias.Limpiar()
        'Me.txtUnidadMedida.Limpiar()
        Me.txtCantidadMercaderia.Text = ""
        Me.txtObservaciones.Text = ""
       
        Me.txtHoraCarga.Text = "00:00"
        Me.txtHoraEntrega.Text = "00:00"

       

        Me.txtOrdenServicio.Text = ""
        Me.txtUsuarioSolicitante.Text = ""
        Me.txtRefCliente.Text = ""
        kgvUnidadProgramada.DataSource = Nothing
        Me.ucTipoCarga.Valor = String.Empty
        Me.ucNivelServ.Valor = String.Empty

    End Sub






   

    Private Sub Cargar_Datos_Grilla()
        Me.Limpiar_Controles()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", lint_indice).Value.ToString().Trim()

        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidad)
        Me.Codigo.Text = objEntidad.NCSOTR
        Me.txtOrdenServicio.Text = objEntidad.NORSRT
        txtCliente.pCargar(objEntidad.CCLNT)
        Me.dtpFechaSolicitud.Text = HelpClass.CNumero_a_Fecha(objEntidad.FECOST)

        txtUbigeoOrigen1.Tag = objEntidad.CUBORI
        If objEntidad.CUBORI <> 0 Then

            txtUbigeoOrigen1.Text = objEntidad.UBIGEO_O
        End If


        txtUbigeoDestino1.Tag = objEntidad.CUBDES
        If objEntidad.CUBDES <> 0 Then

            txtUbigeoDestino1.Text = objEntidad.UBIGEO_D
        End If


        txtLocalidadCarga1.Text = objEntidad.CLCLOR_D
        txtLocalidadCarga1.Tag = objEntidad.CLCLOR_C


        txtLocalidadEntrega1.Text = objEntidad.CLCLDS_D
        txtLocalidadEntrega1.Tag = objEntidad.CLCLDS_C



        Me.txtDireccionLocalidadCarga.Text = objEntidad.TDRCOR

        Me.txtDireccionLocalidadEntrega.Text = objEntidad.TDRENT
        Me.txtCantidadSolicitada.Text = objEntidad.QSLCIT
        Me.txtTipoServicio.Codigo = objEntidad.CTPOSR
        Me.ctlTipoVehiculo.Codigo = objEntidad.CUNDVH
        Me.ctbMercaderias.Codigo = objEntidad.CMRCDR
        'txtUnidadMedida.Codigo = objEntidad.CUNDMD
        txtUnidadMed.Text = objEntidad.CUNDMD
        txtCantidadMercaderia.Text = objEntidad.QMRCDR
        Me.txtObservaciones.Text = objEntidad.TOBS.Trim
        Me.dtpFechaInicioCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FINCRG)
        Me.dtpFinCarga.Text = HelpClass.CNumero_a_Fecha(objEntidad.FENTCL)
        Me.txtHoraCarga.Text = HelpClass.CompletarCadena(objEntidad.HINCIN, 6, "0", HorizontalAlignment.Left)
        Me.txtHoraEntrega.Text = HelpClass.CompletarCadena(objEntidad.HRAENT, 6, "0", HorizontalAlignment.Left)


       

        cboTipoSolViaje.SelectedValue = objEntidad.TPSOTR



        Me.ddlPrioridad.SelectedValue = objEntidad.SPRSTR

        'Pintando los datos de cabecera
        Me.HeaderDatos.ValuesPrimary.Heading = " Nro : " & objEntidad.NCSOTR & " | Clte : " + txtCliente.pRazonSocial & " | Ori : " & Me.txtLocalidadCarga1.Text & " | Dest : " & Me.txtLocalidadEntrega1.Text
        'Marcando el estado de Edicion

        
        Me.cmbSentidoViaje.SelectedValue = objEntidad.SFCRTV

        Me.cboMedioTransporte.SelectedValue = objEntidad.CMEDTR
        Me.txtRefCliente.Text = objEntidad.CCTCSC
        Me.txtUsuarioSolicitante.Text = objEntidad.TRFRN
        Me.ucNivelServ.Valor = objEntidad.CTTRAN
        Me.ucNivelServ.Tag = objEntidad.CTTRAN

        Me.ucTipoCarga.Valor = objEntidad.CTIPCG
        Me.ucTipoCarga.Tag = objEntidad.CTIPCG






        txtCliente.Focus()



    End Sub



    Private Sub Cargar_Detalle_Solicitud()

      
        Dim objEntidad As New ClaseGeneral
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim oListUnidades As New List(Of ClaseGeneral)

        objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        oListUnidades = objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)

        dtgRecursosAsignados.DataSource = oListUnidades
        For Each item As DataGridViewRow In dtgRecursosAsignados.Rows
            If Val("" & item.Cells("NORINS").Value) = 0 Then
                item.Cells("NORINS").Style.ForeColor = Color.Blue
                item.Cells("NORINS").Value = "Enviar SAP"
                item.Cells("NORINS").ToolTipText = "Dar Click para " & Chr(10) & "enviar Orden Interna a SAP"
            End If

        Next


        



    End Sub

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.Limpiar_Controles()
            Me.Listar()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimirSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirSolicitud.Click
        Try
            'Imprime la solicitud de flete por estado
            Me.Cursor = Cursors.WaitCursor

            Dim ListaParametros As New Hashtable
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            End If
            Dim NroSol As Int32
            If Me.txtNroSolicitud.Text.Trim = "" Then
                NroSol = 0
            Else
                NroSol = Convert.ToInt32(Me.txtNroSolicitud.Text)
            End If


            ListaParametros("PNNCSOTR") = NroSol
            If txtClienteFiltro.pCodigo <> 0 Then
                ListaParametros("PNCCLNT") = gwdDatos.Item("CCLNT_COD", gwdDatos.CurrentCellAddress.Y).Value.ToString

            Else
                ListaParametros("PNCCLNT") = "0"

            End If

            ListaParametros("PSSESSLC") = Asignar_Valor()

            ListaParametros("PNCMEDTR") = cboMedioTransporte.SelectedValue

            ListaParametros("PNFECINI") = lstr_FecIni
            ListaParametros("PNFECFIN") = lstr_FecFin

            ListaParametros("PSCCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
            ListaParametros("PSCDVSN") = cmbDivision.Division.ToString.Trim
            ListaParametros("PNCPLNDV") = Me.cmbPlanta.Planta.ToString.Trim

            Imprimir2(ListaParametros)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Imprimir2(ByVal ListaParametros As Hashtable)
        Dim objRep As New Solicitud_Transporte_BLL

        Dim objCrep As New rptSolicitudPendiente1 'nuevas modificaciones

        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        objDt = objRep.Lista_Solicitudes_Transporte2(ListaParametros)
        objDt.TableName = "RZST07"
        objDs.Tables.Add(objDt.Copy)
        objDt = objRep.Listar_Solicitudes_Vehiculo(ListaParametros)
        objDt.TableName = "RZST071"
        objDs.Tables.Add(objDt.Copy)

        HelpClass.CrystalReportTextObject(objCrep, "lblEstado", Me.ddlEstado.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.DivisionDescripcion)
        HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.DescripcionPlanta)
        HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
        If Me.ckbRangoFechas.Checked Then
            HelpClass.CrystalReportTextObject(objCrep, "lblFiltro", Me.dtpFechaInicio.Value.ToShortDateString & " AL " & Me.dtpFechaFin.Value.ToShortDateString)
        End If
        objCrep.SetDataSource(objDs)
        objPrintForm.ShowForm(objCrep, Me)
    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged

        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
        Me.KryptonCheckBox1.Enabled = ckbRangoFechas.Checked
        Me.KryptonCheckBox1.Checked = False 'ckbRangoFechas.Checked

    End Sub






    Private Sub btnImprimirDetalleSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetalleSolicitud.Click
        Try

            Dim ListaParametros As New Hashtable
            If Me.gwdDatos.Rows.Count > 0 Then

                ListaParametros("PNNCSOTR") = gwdDatos.Item("NCSOTR", gwdDatos.CurrentCellAddress.Y).Value.ToString
                ListaParametros("PNCCLNT") = gwdDatos.Item("CCLNT_COD", gwdDatos.CurrentCellAddress.Y).Value.ToString
                ListaParametros("PSSESSLC") = ""
                ListaParametros("PNCMEDTR") = cboMedioTransporte.SelectedValue
                ListaParametros("PNFECINI") = ""
                ListaParametros("PNFECFIN") = ""
                ListaParametros("PSCCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                ListaParametros("PSCDVSN") = cmbDivision.Division.ToString.Trim
                ListaParametros("PNCPLNDV") = cmbPlanta.Planta.ToString.Trim




                Dim objRep As New Solicitud_Transporte_BLL
                Dim objCrep As New rptSolicitudTransp_RecursosAsignados

                Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
                Dim objReporteSolicitudAsignada As New rptSolicitudAsignada

                Dim objDt As DataTable
                Dim objDs As New DataSet
                Dim objPrintForm As New PrintForm
                objDt = objRep.Lista_Solicitudes_Transporte(ListaParametros)
                objDt.TableName = "RZST07"
                objDs.Tables.Add(objDt.Copy)
                objDt = objRep.Listar_Solicitudes_Vehiculo(ListaParametros)
                'ListaParametros
                objDt.TableName = "RZST071"
                objDs.Tables.Add(objDt.Copy)


                HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
                HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.DivisionDescripcion)
                HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.DescripcionPlanta)
                HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
                Dim objEntidad As New ClaseGeneral
                objEntidad.NCSOTR = Me.gwdDatos.Item("NCSOTR", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()

                objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
                'Subreporte Recursos Asignados
                Dim dtbRecursosAsignados As DataTable = HelpClass.GetDataSetNative(objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad))

                If dtbRecursosAsignados.Rows.Count > 0 Then
                    objCrep.OpenSubreport("rptSolicitudAsignada.rpt").SetDataSource(dtbRecursosAsignados)
                End If

                objCrep.SetDataSource(objDs)
                objPrintForm.ShowForm(objCrep, Me)

                objCrep.Close()
                objCrep.Dispose()

                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dtgRecursosAsignados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            Dim hash As New Hashtable()
            hash("CCMPN") = cmbCompania.CCMPN_CodigoCompania.ToString()
            Dim ColName As String = dtgRecursosAsignados.Columns(e.ColumnIndex).Name
            Select Case ColName

                'Case "UBICACION"
                '    If Me.dtgRecursosAsignados.Item("GPSLON", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then
                '        Dim objGpsBrowser As New frmMapa
                '        With objGpsBrowser
                '            .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT", e.RowIndex).Value
                '            .Longitud = Me.dtgRecursosAsignados.Item("GPSLON", e.RowIndex).Value
                '            .Fecha = Me.dtgRecursosAsignados.Item("FECGPS", e.RowIndex).Value
                '            .Hora = Me.dtgRecursosAsignados.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                '            .WindowState = FormWindowState.Maximized
                '            .ShowForm(.Latitud, .Longitud, Me)
                '        End With
                '    End If

                Case "NPLCUN"

                    Informacion_Detallada_Transportista(1, Me.dtgRecursosAsignados.Item("NPLCUN", e.RowIndex).Value, hash)

                Case "NPLCAC"

                    Informacion_Detallada_Transportista(2, Me.dtgRecursosAsignados.Item("NPLCAC", e.RowIndex).Value, hash)

                Case "CBRCNT"

                    Informacion_Detallada_Transportista(3, Me.dtgRecursosAsignados.Item("CBRCNT", e.RowIndex).Value, hash)

                Case "NORINS"
                 

                    Dim OS_TipoSeguimiento As Boolean = (("" & Me.gwdDatos.CurrentRow.Cells("FTRTSG").Value).ToString.Trim = "X")
                    If OS_TipoSeguimiento = True Then
                        MessageBox.Show("No puede generar. OS tipo seguimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If dtgRecursosAsignados.Item("NORINS", e.RowIndex).Value.ToString = "Enviar SAP" Then
                            Enviar_Orden_Interna_SAP()
                        End If
                    End If


                Case "MODIFICAR"
                    Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
                    Dim obj_Entidad As New Detalle_Solicitud_Transporte
                    Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
                    Dim lstr_Estado As String = ""
                    Dim es_modificable As Boolean = False

                    obj_Entidad.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", lint_indice).Value
                    obj_Entidad.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
                   
                    obj_Entidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                    obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Operacion_Solicitud(obj_Entidad)


                    If obj_Entidad.NGUITR <> "0" Then
                        lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
                        If obj_Entidad.NCTAVC <> "0" Then
                            lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
                        End If
                        If obj_Entidad.NCSLPE <> "0" Then
                            lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
                        End If
                        If obj_Entidad.NCTAV2 <> "0" Then
                            lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
                        End If
                        If obj_Entidad.NCSLP2 <> "0" Then
                            lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
                        End If

                        If obj_Entidad.NCTAVC <> "0" AndAlso obj_Entidad.NCSLPE <> "0" And obj_Entidad.NCTAV2 <> "0" And obj_Entidad.NCSLP2 <> "0" Then
                            lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
                            MessageBox.Show(lstr_Estado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                    End If
                    If obj_Entidad.SESGRP = "L" Then
                        MessageBox.Show("No puede modificar. Guía Liquidada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    obj_Entidad.NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
                    obj_Entidad.NPLCUN = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
                    obj_Entidad.NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
                    obj_Entidad.CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
                    obj_Entidad.CBRCN2 = Me.dtgRecursosAsignados.Item("CBRCN2", lint_indice).Value


                    Dim frmReasignarRecurso As New frmReasignarRecurso
                    frmReasignarRecurso.IsMdiContainer = True
                    With frmReasignarRecurso
                        ._obj_Entidad = obj_Entidad
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                        .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
                        If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub


                      

                        Me.dtgRecursosAsignados.CurrentRow.Cells("NRUCTR").Value = .ctbTransportista.pRucTransportista
                        Me.dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value = .ctbTracto.pNroPlacaUnidad
                        Me.dtgRecursosAsignados.CurrentRow.Cells("NPLCAC").Value = .ctbAcoplado.pNroAcoplado
                        Me.dtgRecursosAsignados.CurrentRow.Cells("CBRCNT").Value = .cmbConductor.pBrevete
                        Me.dtgRecursosAsignados.CurrentRow.Cells("CBRCND").Value = .cmbConductor.pNombreChofer
                        Me.dtgRecursosAsignados.CurrentRow.Cells("CBRCN2").Value = .cmbSegundoConductor.pBrevete


                    End With


                Case "F_ATENCION"

                    Dim frmEditarFechaHora As New frmEditarFechaHoraAtencionServicio
                    frmEditarFechaHora.pNOPRCN = Me.dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value
                    frmEditarFechaHora.pFATNSR = Me.dtgRecursosAsignados.CurrentRow.Cells("FATNSR").Value
                    frmEditarFechaHora.pHATNSR = Me.dtgRecursosAsignados.CurrentRow.Cells("HATNSR").Value
                    frmEditarFechaHora.pCCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    frmEditarFechaHora.pNGUITR = Me.dtgRecursosAsignados.CurrentRow.Cells("NGUITR").Value
                    frmEditarFechaHora.pCTRMNC = Me.dtgRecursosAsignados.CurrentRow.Cells("CTRSPT").Value
                    If Me.dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value = 0 Then
                        Exit Sub
                    End If
                    If frmEditarFechaHora.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    HelpClass.MsgBox("Fecha y hora actualizadas")
                    Me.Cargar_Detalle_Solicitud()


            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click

        Try
            If txtCliente.pCodigo = 0 Then
                MsgBox("Debe de seleccionar el cliente para buscar las ordenes de servicio relacionadas")
                Exit Sub
            End If
            gintEstado = 0

            Dim objSolicitudLogica As New SOLMIN_ST.NEGOCIO.Operaciones.Solicitud_Transporte_BLL
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Unidades_Asignadas(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            Select Case lintStatus

                Case Is > 0
                    HelpClass.MsgBox("No se puede cambiar la O/S porque cuenta con unidades asignadas")
                    Exit Sub
            End Select

            objFormBuscarOrdenServicio = New frmBuscarOrdenServicio

            gintEstado = -1
            objFormBuscarOrdenServicio.CodigoCliente = txtCliente.pCodigo
            objFormBuscarOrdenServicio.CCMPN = cmbCompania.CCMPN_CodigoCompania.ToString().Trim()
            objFormBuscarOrdenServicio.CDVSN = cmbDivision.Division
            objFormBuscarOrdenServicio.CPLNDV = cmbPlanta.Planta

            If objFormBuscarOrdenServicio.ShowDialog() = DialogResult.OK Then

                LimpiarDatosGenerales()
                txtOrdenServicio.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
                txtTipoServicio.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPOSR
                ctbMercaderias.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR
                'txtUnidadMedida.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD
                txtUnidadMed.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD
                txtCantidadMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.QMRCDR

                txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI = 0 Then
                    txtUbigeoOrigen1.Text = ""
                Else
                    txtUbigeoOrigen1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_O
                    txtUbigeoOrigen1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI
                End If
                txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES = 0 Then
                    txtUbigeoDestino1.Text = ""
                Else
                    txtUbigeoDestino1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_D
                    txtUbigeoDestino1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES
                End If
                txtLocalidadCarga1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG
                txtLocalidadCarga1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
                txtLocalidadEntrega1.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS & " - " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
                txtLocalidadEntrega1.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

                ucNivelServ.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTTRAN

                ucTipoCarga.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTIPCG



                Dim sntViaje As String = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.COD_SNT_VJE
                If sntViaje <> "" Then
                    cmbSentidoViaje.SelectedValue = sntViaje
                Else
                    cmbSentidoViaje.SelectedValue = "I"
                End If


            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim N As String = "ok"

    End Sub



    Private Sub LimpiarDatosGenerales()

        txtTipoServicio.Limpiar()
        ctbMercaderias.Limpiar()
        'txtUnidadMedida.Limpiar()
        txtUnidadMed.Text = ""
        txtCantidadMercaderia.Text = ""

        txtUbigeoOrigen1.Text = ""
        txtUbigeoOrigen1.Tag = 0
        txtUbigeoDestino1.Text = ""
        txtUbigeoDestino1.Tag = 0

        txtLocalidadCarga1.Text = ""
        txtLocalidadCarga1.Tag = 0
        txtLocalidadEntrega1.Text = ""
        txtLocalidadEntrega1.Tag = 0

    End Sub

    Private Function Validar_Recursos_Asignados(ByVal lint_indice As Integer) As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        'Evaluando la Asignación: Tracto, Acoplado y Conductor

        If Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value.ToString = "" Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If

        Select Case Me.cboMedioTransporte.SelectedValue
            Case 4

                If Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value.ToString = "" Then
                    lstr_validacion += "* CONDUCTOR" & Chr(13)
                End If
        End Select

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private VisualizarControlesMantenimiento As Boolean = False
    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", _pNombreForm) ''Me.Name.Trim)

        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False

        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False

        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False

        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False


        End If
        If objEntidad.STSVIS = "" Then
            Me.btnAnularOperacion.Visible = False

        End If
        If objEntidad.STSOP2 = "" Then

            tbnAsignarGT.Visible = False

        End If

        If objEntidad.STSOP3 = "" Then
            'Me.btnAdjuntarDocumentos.Visible = False
            Me.btnAsignacionManual_1.Visible = False
            btnasignar_recursos.Visible = False
        End If

        If objEntidad.STSOP1 = "X" Then
            VisualizarControlesMantenimiento = True
        Else
            VisualizarControlesMantenimiento = False
        End If



    End Sub



    Private Sub btnLimpiarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtOrdenServicio.Text = ""


        Me.txtLocalidadEntrega1.Text = ""
        Me.txtLocalidadEntrega1.Tag = 0
        Me.txtLocalidadCarga1.Text = ""
        Me.txtLocalidadCarga1.Tag = 0

        Me.txtUbigeoOrigen1.Text = ""
        Me.txtUbigeoOrigen1.Tag = 0
        Me.txtUbigeoDestino1.Text = ""
        Me.txtUbigeoDestino1.Tag = 0

    End Sub



    Private Sub TabSolicitudFlete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSolicitudFlete.SelectedIndexChanged

        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            AsignarEstadoBotones(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAdjuntarDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarDocumentos.Click

        Try
            'Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            'Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            'Select Case lintStatus
            '    Case -1
            '        HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
            '        Exit Sub
            '    Case -2
            '        HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
            '        Exit Sub

            'End Select

            ''==========New============
            'Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
            ''============NUEVO =============
            'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumento
            'With ofrmAdjuntarDocumento
            '    .docsAdjunto.CCMPN = cmbCompania.CCMPN_CodigoCompania
            '    .docsAdjunto.CDVSN = cmbDivision.Division
            '    .docsAdjunto.CPLNDV = cmbPlanta.Planta
            '    .docsAdjunto.CTRSPT = Me.dtgRecursosAsignados.Item("CTRSPT", lint_indice).Value
            '    .docsAdjunto.NGUITR = Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value
            'End With
            'If ofrmAdjuntarDocumento.ShowDialog() Then
            'End If

            'Dim ofrmAdjuntarDocumento As New frmAdjuntarDocumentos
            'Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            'If Me.gwdDatos.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            'With ofrmAdjuntarDocumento
            '    .pTABLE_NAME = "RZTR96"
            '    .pUSER_NAME = USUARIO
            '    .PSCCMPN = cmbCompania.CCMPN_CodigoCompania
            '    .PSCDVSN = cmbDivision.Division
            '    '.PNCPLNDV = cmbPlanta.Planta
            '    .PNCPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
            '    .PNCCLNT = gwdDatos.Item("CCLNT", lint_indice).Value
            '    .pNGUIRM = dtgRecursosAsignados.Item("NGUITR", lint_indice).Value
            '    .pNMRGIM = dtgRecursosAsignados.Item("NMRGIM", lint_indice).Value

            '    .ShowDialog()
            'End With


            If dtgRecursosAsignados.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If



            If dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value = 0 Then
                MessageBox.Show("No tiene número operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim CodCompania As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
            Dim NroOperacion As String = dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pNroImagen = dtgRecursosAsignados.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZTR05
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR05", "01")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR05(CodCompania, NroOperacion)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                dtgRecursosAsignados.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dtgRecursosAsignados.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    dtgRecursosAsignados.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCantidadSolicitada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadSolicitada.KeyPress, txtNroSolicitud.KeyPress, txtNroOperacion.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub CargarControles()
        Me.txtClienteFiltro.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Me.txtCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania

    End Sub

    Private Sub Carga_SentidoViaje()
        Me.cmbSentidoViaje.DataSource = TipoSolicitud()
        Me.cmbSentidoViaje.ValueMember = "COD"
        Me.cmbSentidoViaje.DisplayMember = "NOM"
    End Sub

    Private Sub Carga_TipoPrioridad()
        Me.ddlPrioridad.DataSource = TipoPrioridad()
        Me.ddlPrioridad.ValueMember = "COD"
        Me.ddlPrioridad.DisplayMember = "NOM"

        Me.cboPrioridadFiltro.DataSource = TipoPrioridadFiltro()
        Me.cboPrioridadFiltro.ValueMember = "COD"
        Me.cboPrioridadFiltro.DisplayMember = "NOM"

    End Sub

    Private Sub Carga_Usuario()
        ckbUsuarioCreador.Checked = False
        cmbUsuarioCreador.Enabled = False
    End Sub

    Private Function TipoSolicitud()
        Dim oDt As New DataTable
        Dim objTipoDatoGeneral As New TipoDatoGeneral_BLL

        Dim dtb As New List(Of TipoDatoGeneral)
        dtb = objTipoDatoGeneral.Lista_Tipo_Dato_General(Me.cmbCompania.CCMPN_CodigoCompania, "STTPSL")

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        For Each o As TipoDatoGeneral In dtb

            oDt.Rows.Add(New Object() {o.CODIGO_TIPO, o.DESC_TIPO})
        Next

       

        Return oDt

    End Function

    Private Function TipoPrioridadFiltro()
        Dim oDt As New DataTable
        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item(0) = "T"
        oDr.Item(1) = "TODOS"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "N"
        oDr.Item(1) = "NORMAL"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "U"
        oDr.Item(1) = "URGENTE"
        oDt.Rows.Add(oDr)
        Return oDt

    End Function


    Private Function TipoPrioridad()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")
        Dim oDr As DataRow
        oDr = oDt.NewRow
        oDr.Item(0) = "N"
        oDr.Item(1) = "NORMAL"
        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "U"
        oDr.Item(1) = "URGENTE"
        oDt.Rows.Add(oDr)
        Return oDt

    End Function

    Private Sub btnAuditoria1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditoria1.Click
        If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim NrSol As String = Me.gwdDatos.CurrentRow.Cells("NCSOTR").Value
        Auditoria(NrSol)
    End Sub

    Private Sub Auditoria(ByVal pdblNroSolicitud As String)
        If pdblNroSolicitud.Trim.Length = 0 OrElse pdblNroSolicitud = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Dim objLogica As New Solicitud_Transporte_BLL
        Dim objEntidad As New Solicitud_Transporte
        objEntidad.NCSOTR = pdblNroSolicitud
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
        objEntidad = objLogica.Auditoria(objEntidad)
        Dim objfrmAuditoria As New frmAuditoria
        objfrmAuditoria.USUARIO_CREACION = objEntidad.CUSCRT
        objfrmAuditoria.FECHA_CREACION = objEntidad.FCHCRT
        objfrmAuditoria.HORA_CREACION = objEntidad.HRACRT
        objfrmAuditoria.TERMINAL_CREACION = objEntidad.NTRMCR
        objfrmAuditoria.USUARIO_ACTUALIZACION = objEntidad.CULUSA
        objfrmAuditoria.FECHA_ACTUALIZACION = objEntidad.FULTAC
        objfrmAuditoria.HORA_ACTUALIZACION = objEntidad.HULTAC
        objfrmAuditoria.TERMINAL_ACTUALIZACION = objEntidad.NTRMNL
        objfrmAuditoria.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

   

    Private Sub btnAsignacionManual_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignacionManual_1.Click

        Dim objSolicitudLogica As New Solicitud_Transporte_BLL



        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If


 

        Dim CantAtendida As Integer = 0
        Dim CantSolicitada As Integer = 0
        Dim NroSolicitud As Decimal = 0

        CantAtendida = CType(Me.gwdDatos.CurrentRow.Cells("QATNAN").Value, Integer)
        CantSolicitada = CType(gwdDatos.CurrentRow.Cells("QSLCIT").Value, Integer)
        NroSolicitud = gwdDatos.CurrentRow.Cells("NCSOTR").Value

        If CantAtendida >= CantSolicitada Then Exit Sub

      
        If NroSolicitud = 0 Then
            MessageBox.Show("Seleccione la solicitud Transporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(NroSolicitud, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub

        End Select
        Try

            Dim RucCargaTransportista As String = ""
            If chkCargarTransportista.Checked = True Then
                If dtgRecursosAsignados.CurrentRow IsNot Nothing Then
                    RucCargaTransportista = dtgRecursosAsignados.CurrentRow.Cells("NRUCTR").Value
                End If
            End If

            Dim frm_frmAsignacionManual As New frmAsignacionManual()
            With frm_frmAsignacionManual



                frm_frmAsignacionManual.es_OS_TipoSeguimiento = (("" & Me.gwdDatos.CurrentRow.Cells("FTRTSG").Value).ToString.Trim = "X")


                .obj_Entidad.NCSOTR = gwdDatos.CurrentRow.Cells("NCSOTR").Value
                



                .obj_Entidad.NORSRT = gwdDatos.CurrentRow.Cells("NORSRT").Value
                .obj_Entidad.CCLNT = gwdDatos.CurrentRow.Cells("CCLNT_COD").Value  ' Me.txtCliente.pCodigo
                .obj_Entidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                .obj_Entidad.CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                .obj_Entidad.CTPOVJ = Me._CTPOVJ
                .obj_Entidad.CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                .CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                .CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value

                .MedioTransporte = gwdDatos.CurrentRow.Cells("CMEDTR").Value

                .CLCLOR = gwdDatos.CurrentRow.Cells("CLCLOR_C").Value 'origen - string
                .CLCLDS = gwdDatos.CurrentRow.Cells("CLCLDS_C").Value 'destino - string
                .CDDRSP = gwdDatos.CurrentRow.Cells("CDDRSP").Value 'ECM-HUNDRED-20150821

                If _pEsRequerimiento = True Then
                    .NUMREQT = _pRequerimientoServicio.NUMREQT
                    .NDCORM = _pRequerimientoServicio.NDCORM
                    .PNCDTR = _pRequerimientoServicio.PNCDTR
                End If

                .oHasLimiteCredito = oHasLimiteCredito
                .oHasHomologacionTransportista = oHasHomologacionTransportista
                .RucCargaTransportista = RucCargaTransportista
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                oHasLimiteCredito = .oHasLimiteCredito
                oHasHomologacionTransportista = .oHasHomologacionTransportista

                HelpClass.MsgBox("Se Asignó Satisfactoriamente")

                Me.gwdDatos.CurrentRow.Cells("QATNAN").Value = Me.gwdDatos.CurrentRow.Cells("QATNAN").Value + 1

                CantAtendida = CType(Me.gwdDatos.CurrentRow.Cells("QATNAN").Value, Integer)
                CantSolicitada = CType(gwdDatos.CurrentRow.Cells("QSLCIT").Value, Integer)

                If CantAtendida >= CantSolicitada Then

                    Me.Listar()

                Else
                    Me.Cargar_Detalle_Solicitud()
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    
    Private Sub tsmLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLimpiar.Click
        Me.txtOrdenServicio.Text = ""


        txtUbigeoOrigen1.Text = ""
        txtUbigeoOrigen1.Tag = 0
        txtUbigeoDestino1.Text = ""
        txtUbigeoDestino1.Tag = 0

        txtLocalidadEntrega1.Text = ""
        txtLocalidadEntrega1.Tag = 0
        txtLocalidadCarga1.Text = ""
        txtLocalidadCarga1.Tag = 0


    End Sub

   

    Private Sub txtNroSolicitud_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroSolicitud.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.txtNroSolicitud.Text.Trim.Equals("") Then Exit Sub
            Me.btnProcesarConsulta_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Enviar_Orden_Interna_SAP()
        Dim intIndice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        If Me.dtgRecursosAsignados.Item("NOPRCN", intIndice).Value = 0 Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        If Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value.ToString.Trim <> "Enviar SAP" Then
            HelpClass.MsgBox("La Operación tiene Orden Interna Asignada N° " & _
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value.ToString)
            Exit Sub
        End If
        If HelpClass.RspMsgBox("Desea generar la Orden Interna a la Operación de Transporte Nro " & _
           Me.dtgRecursosAsignados.Item("NOPRCN", intIndice).Value & " ?") = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Generar_Orden_Interna(intIndice)
    End Sub

    Private Sub Generar_Orden_Interna(ByVal intIndice As Integer)
      
        If intIndice < 0 Then
            Exit Sub
        End If
        Dim objFila As DataGridViewRow = Me.dtgRecursosAsignados.CurrentRow
        Dim objBLL As New Solicitud_Transporte_BLL
        Dim msgValidacion As String = objBLL.Valida_OrdenInterna_CentroCosto(CDec(objFila.Cells("NOPRCN").Value))
        msgValidacion = msgValidacion.Trim
        If msgValidacion.Length > 0 Then
            MessageBox.Show("La orden Interna no puede ser generada." & Chr(10) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim objOrdenInterna As New OrdenInterna_BLL
         


        Dim msg_oi As String = ""
        Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
        oFiltroRecurso.NOPRCN = dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value
        oFiltroRecurso.NCRRPL = dtgRecursosAsignados.CurrentRow.Cells("NCRRPL").Value
        oFiltroRecurso.NSBCRP = dtgRecursosAsignados.CurrentRow.Cells("NSBCRP").Value
        oFiltroRecurso.CULUSA = MainModule.USUARIO
        oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina


        Dim orptaOI As New ENTIDADES.beRespuestaOperacion
        orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)

        If msg_oi.Length > 0 Then
            MessageBox.Show(msg_oi, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            HelpClass.MsgBox("Orden Interna N° " + orptaOI.OI_SAP + " se envió al SAP satisfactoriamente")
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Value = orptaOI.OI_SAP
            Me.dtgRecursosAsignados.Item("NORINS", intIndice).Style.ForeColor = Color.Black

        End If

        

    End Sub


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "T"
            End If
            cmbDivision.pActualizar()
            Me.CargarControles()
            Me.gwdDatos.DataSource = Nothing
          
            Me.Limpiar()
            Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania

            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO

            Me.cmbPlanta.CodigoCompania = cmbDivision.Compania
            Me.cmbPlanta.CodigoDivision = cmbDivision.Division
            Me.cmbPlanta.PlantaDefault = 1

            Me.cmbPlanta.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Limpiar()
       

        Me.Limpiar_Controles()

        Me.Cargar_Combos()
        Me.Carga_MedioTransporte()

        Me.Estado_Controles(False)
        gintEstado = 0

    End Sub

    'Private Sub btnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If (Me.dtgRecursosAsignados.Rows.Count = 0) OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
    '        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
    '        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
    '        Select Case lintStatus
    '            Case -1
    '                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
    '                Exit Sub

    '                Exit Sub
    '        End Select

    '        Dim vNPLCUN As String = ""
    '        Dim NCSOTR As Decimal = 0
    '        Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
    '        vNPLCUN = dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value
    '        NCSOTR = dtgRecursosAsignados.CurrentRow.Cells("NCSOT").Value
    '        obeSeguimientoGPS.NPLCTR = vNPLCUN
    '        obeSeguimientoGPS.NCSOTR = NCSOTR
    '        obeSeguimientoGPS.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '        obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value)
    '        obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(dtgRecursosAsignados.CurrentRow.Cells("NGSGWP").Value)
    '        obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCOREG").Value)
    '        Dim ofrmGPSWAP As New frmGPSWAP()
    '        ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
    '        ofrmGPSWAP.ShowDialog(Me)
    '        Me.Cargar_Detalle_Solicitud()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnAnularOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularOperacion.Click

        Try
            If gwdDatos.CurrentRow Is Nothing Or dtgRecursosAsignados.CurrentRow Is Nothing Then
                Exit Sub
            End If
 

            Dim objLogica As New Solicitud_Transporte_BLL
            Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
            


            Dim TipoSolicitud As String = gwdDatos.CurrentRow.Cells("TPSOTR").Value

            If TipoSolicitud = "02" Then
                Anular_Detalle_Solicitud_Transporte()
            Else
                Anular_Operacion_Transporte()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Anular_Operacion_Transporte()



        If MessageBox.Show("Está seguro de anular la operación.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim objLogica As New Solicitud_Transporte_BLL
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
        Dim objEntidad As New Solicitud_Transporte
        objEntidad.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        objEntidad.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        '------------------------------------------------------------

        Dim msgError As String = ""
        Dim anulado_sin_op As String = ""
        msgError = objLogica.Anulacion_Operacion_Transporte_Salm(objEntidad, anulado_sin_op)
        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If anulado_sin_op = "S" Then
            MessageBox.Show("Asignación anulada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cargar_Detalle_Solicitud()
            Exit Sub
        End If
        

        Dim frmAnulacion As New frmAnularOperacion
        frmAnulacion.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        frmAnulacion.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        frmAnulacion.Operacion = Me.dtgRecursosAsignados.Item("NOPRCN", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        frmAnulacion.CCLINT = txtClienteFiltro.pCodigo
        frmAnulacion.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        frmAnulacion.CDVSN = Me.cmbDivision.Division
        If frmAnulacion.ShowDialog() = DialogResult.OK Then

            If gwdDatos.CurrentRow.Cells("NUMREQT").Value > 0 Then
                Dim objAteReq As New AtencionRequerimiento
                objAteReq.NUMREQT = gwdDatos.CurrentRow.Cells("NUMREQT").Value
                objAteReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
                objAteReq.CUSCRT = MainModule.USUARIO
                objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)
            End If
            '==========================================================================================
            Me.gwdDatos.Item("QATNAN", Me.gwdDatos.CurrentCellAddress.Y).Value = CType(Me.gwdDatos.Item("QATNAN", Me.gwdDatos.CurrentCellAddress.Y).Value, Int32) - 1
            Me.gwdDatos.Item("SESSLC", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
            Me.Cargar_Detalle_Solicitud()
        End If



    End Sub
    Private Sub Anular_Detalle_Solicitud_Transporte()

        Dim objLogica As New Solicitud_Transporte_BLL
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL

        Dim objEntidad As New Solicitud_Transporte
        objEntidad.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        objEntidad.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        '------------------------------------------------------------
       

        Dim msgAlerta As String = ""
        Dim msgError As String = ""
        msgError = objLogica.Anulacion_Detalle_Solicitud_Transporte_SALM(objEntidad)
        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Cargar_Detalle_Solicitud()


    End Sub
    

    Private Sub ckbUsuarioCreador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbUsuarioCreador.CheckedChanged
        If ckbUsuarioCreador.Checked = True Then

            cmbUsuarioCreador.Enabled = True
        Else
            cmbUsuarioCreador.pClear()
            cmbUsuarioCreador.Enabled = False
        End If
    End Sub

    Private Sub btnCerrarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSolicitud.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Dim lintStatus As Int32 = objSolicitudTransporte.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
        Select Case lintStatus
            Case -1
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                Exit Sub
            Case -2
                HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                Exit Sub
               
        End Select

        If MsgBox("Desea cerrar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Cerrar_Solicitud()


    End Sub

    

    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged

        If ckbRangoFechas.Enabled = True Then
            Me.dtpHora_Ini.Enabled = KryptonCheckBox1.Checked
            Me.dtpHora_Ini.Value = Date.Parse("08:00:00")
            Me.dtpHora_Fin.Enabled = KryptonCheckBox1.Checked
            Me.dtpHora_Fin.Value = Date.Parse("18:00:00")
        End If

    End Sub

    Private Sub btnProgramadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgramadas.Click

        Try
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUDES_PROGRAMADAS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUDES_PROGRAMADAS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "LISTA DE SOLICITUDES DE TRANSPORTE - PROGRAMADAS"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim objSolicitud As New Solicitud_Transporte
            Dim objParamList As New List(Of String)
            Dim lstr_FecIni As Int32 = 0
            Dim lstr_FecFin As Int32 = 0
            Dim lstr_HoraIni As Int32 = 0
            Dim lstr_HoraFin As Int32 = 0

            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            Else
                lstr_FecIni = 0
                lstr_FecFin = 0
            End If
            If KryptonCheckBox1.Checked = True Then
                lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
                lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
            Else
                lstr_HoraIni = 0
                lstr_HoraFin = 0
            End If

            If Me.txtNroSolicitud.Text.Trim.Equals("") Then
                objSolicitud.NCSOTR = 0
            Else
                objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
            End If
            If txtClienteFiltro.pCodigo <> 0 Then
                objSolicitud.CCLNT = txtClienteFiltro.pCodigo
            Else
                objSolicitud.CCLNT = 0
            End If

            objSolicitud.SESSLC = Asignar_Valor()
            objSolicitud.SESTRG = Asignar_Valor_Estado()
            objSolicitud.FE_INI = lstr_FecIni
            objSolicitud.FE_FIN = lstr_FecFin
            objSolicitud.HR_INI = lstr_HoraIni
            objSolicitud.HR_FIN = lstr_HoraFin
            objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
            objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objSolicitud.CDVSN = Me.cmbDivision.Division
            objSolicitud.CPLNDV = Me.cmbPlanta.Planta
            If ckbUsuarioCreador.Checked = True Then
                objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
            Else
                objSolicitud.CUSCRT = ""
            End If

            If Me.cboPrioridadFiltro.SelectedValue = "T" Then
                objSolicitud.SPRSTR = ""
            Else
                objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
            End If
            If chkNumReq.Checked = True Then
                objSolicitud.NUMREQT = Val(txtNroReqFiltro.Text)
            Else
                objSolicitud.NUMREQT = 0
            End If

            ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(objSolicitud).Copy)
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                    Case "Unidades Solicitadas", "Unidades Atendidas", "Cantidad", "Cantidades Programadas"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                    Case Else
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                End Select
            Next

            HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUrgentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUrgentes.Click

        Try
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUDES_URGENTES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUDES_URGENTES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "LISTA DE SOLICITUDES DE TRANSPORTE - URGENTES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim objSolicitud As New Solicitud_Transporte
            Dim objParamList As New List(Of String)
            Dim lstr_FecIni As Int32 = 0
            Dim lstr_FecFin As Int32 = 0
            Dim lstr_HoraIni As Int32 = 0
            Dim lstr_HoraFin As Int32 = 0

            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            Else
                lstr_FecIni = 0
                lstr_FecFin = 0
            End If

            If KryptonCheckBox1.Checked = True Then
                lstr_HoraIni = CInt(String.Format("{0:HHmmss}", dtpHora_Ini.Value))
                lstr_HoraFin = CInt(String.Format("{0:HHmmss}", dtpHora_Fin.Value))
            Else
                lstr_HoraIni = 0
                lstr_HoraFin = 0
            End If

            If Me.txtNroSolicitud.Text.Trim.Equals("") Then
                objSolicitud.NCSOTR = 0
            Else
                objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
            End If
            If txtClienteFiltro.pCodigo <> 0 Then
                objSolicitud.CCLNT = txtClienteFiltro.pCodigo
            Else
                objSolicitud.CCLNT = 0
            End If

            objSolicitud.SESSLC = Asignar_Valor()
            objSolicitud.SESTRG = Asignar_Valor_Estado()
            objSolicitud.FE_INI = lstr_FecIni
            objSolicitud.FE_FIN = lstr_FecFin
            objSolicitud.HR_INI = lstr_HoraIni
            objSolicitud.HR_FIN = lstr_HoraFin
            objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
            objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objSolicitud.CDVSN = Me.cmbDivision.Division
            objSolicitud.CPLNDV = Me.cmbPlanta.Planta
            If ckbUsuarioCreador.Checked = True Then
                objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
            Else
                objSolicitud.CUSCRT = ""
            End If


            objSolicitud.SPRSTR = "U"
            If chkNumReq.Checked = True Then
                objSolicitud.NUMREQT = Val(txtNroReqFiltro.Text)
            Else
                objSolicitud.NUMREQT = 0
            End If
            ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export_Solicitudes_Programadas_Urgentes(objSolicitud).Copy)
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                    Case "Unidades Solicitadas", "Unidades Atendidas", "Cantidad", "Cantidades Programadas"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                    Case Else
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneral.Click
        Try
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "SOLICITUD_DE_TRANSPORTE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "SOLICITUD_TRANSPORTE"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "SOLICITUD DE TRANSPORTE - GENERAL"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim objSolicitud As New Solicitud_Transporte
            Dim objParamList As New List(Of String)
            Dim lstr_FecIni As Int32 = 0
            Dim lstr_FecFin As Int32 = 0
            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            End If
            If Me.txtNroSolicitud.Text.Trim.Equals("") Then
                objSolicitud.NCSOTR = 0
            Else
                objSolicitud.NCSOTR = Me.txtNroSolicitud.Text.Trim
            End If
            If txtClienteFiltro.pCodigo <> 0 Then
                objSolicitud.CCLNT = txtClienteFiltro.pCodigo
            Else
                objSolicitud.CCLNT = 0
            End If
            If Me.txtNroOperacion.Text.Trim.Equals("") Then
                objSolicitud.NOPRCN = 0
            Else
                objSolicitud.NOPRCN = Me.txtNroOperacion.Text.Trim
            End If
            objSolicitud.SESSLC = Asignar_Valor()
            objSolicitud.SESTRG = Asignar_Valor_Estado()
            objSolicitud.FE_INI = lstr_FecIni
            objSolicitud.FE_FIN = lstr_FecFin
            objSolicitud.CMEDTR = Me.cboMedioTransporteFiltro.SelectedValue
            objSolicitud.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            objSolicitud.CDVSN = Me.cmbDivision.Division
            objSolicitud.CPLNDV = Me.cmbPlanta.Planta
            If ckbUsuarioCreador.Checked = True Then
                objSolicitud.CUSCRT = cmbUsuarioCreador.pPSMMCUSR.ToString.Trim
            Else
                objSolicitud.CUSCRT = ""
            End If
            objSolicitud.TRFRN = txtUsuarioSoli.Text.ToUpper.Trim
            objSolicitud.SPRSTR = Me.cboPrioridadFiltro.SelectedValue
            If chkNumReq.Checked = True Then
                objSolicitud.NUMREQT = Val(txtNroReqFiltro.Text)
            Else
                objSolicitud.NUMREQT = 0
            End If
            ODs.Tables.Add(objSolicitudTransporte.Listar_Solicitudes_Transporte_Export(objSolicitud).Copy)
            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "Fecha Solicitud", "Hora Solicitud", "Fecha Carga", "Hora Carga", "Fecha Entrega", "Hora Entrega"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_FECHA)
                    Case "Unidades Solicitadas", "Unidades  Atendidas", "Cantidad", "Requerimiento"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)
                    Case Else
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico_V1(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbUsuarioSolicitante_InformationChanged() Handles cmbUsuarioSolicitante.InformationChanged
        txtUsuarioSolicitante.Text = cmbUsuarioSolicitante.pPSMMNUSR.ToString.Trim
    End Sub

    Private Sub chkNumReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumReq.CheckedChanged

        txtNroReqFiltro.Enabled = chkNumReq.Checked

    End Sub

    Private Sub txtNroReqFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroReqFiltro.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub stbIncidenciaEvalOperativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stbIncidenciaEvalOperativa.Click
        If Me.dtgRecursosAsignados.CurrentCellAddress.Y <= -1 Then Exit Sub
        Dim intIndice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        If Me.dtgRecursosAsignados.Item("NOPRCN", intIndice).Value = 0 Then
            HelpClass.MsgBox("No Tiene Operación Asignada")
            Exit Sub
        End If
        MostrarIncidencias()
    End Sub

    Private Sub MostrarIncidencias()
        ' Agregando el FrmRegistroIncidencias
        Dim objEntidad As New GuiaTransportista
        Dim lint_indice As Integer
        lint_indice = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        objEntidad.NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        objEntidad.TCMTRT = Me.dtgRecursosAsignados.Item("TCMTRT", lint_indice).Value

        Dim fRegistroIncidencias As frmRegistroIncidencias = New frmRegistroIncidencias()
        fRegistroIncidencias._CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        fRegistroIncidencias._NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        fRegistroIncidencias._NGUITR = Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value
        fRegistroIncidencias.cargarIncidencia(objEntidad)
        fRegistroIncidencias.ShowDialog()
    End Sub




 


   

    Private Sub btnLineaCreditoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineaCreditoCliente.Click
        Dim frm As frmValidaCliente = New frmValidaCliente()
        frm._CCMPN_COD = cmbCompania.CCMPN_CodigoCompania
        If gwdDatos.CurrentRow IsNot Nothing Then
            frm._CCLNT_COD = gwdDatos.CurrentRow.Cells("CCLNT_COD").Value
        End If

        frm.ShowDialog()

    End Sub



    Private Sub btnDirecciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirecciones.Click, btnDireccionEntrega.Click

        Dim texto As TextBox

        If sender.name = "btnDirecciones" Then
            texto = txtDireccionLocalidadCarga
        Else
            texto = txtDireccionLocalidadEntrega
        End If

        texto.Text = ""

        If (txtCliente.pCodigo = "11731" Or txtCliente.pCodigo = "30507") Then

            Dim objControl As New Ransa.Controls.Menu.UC_Frm_CboAyuda

            Dim dtbDatosAyuda As New DataTable
            Dim objAyuda As New Ransa.Controls.TipoAyuda.TipoAyuda_DAL
            dtbDatosAyuda = objAyuda.fdtListar_TablaAyuda_Filtro("STDRCL", txtCliente.pCodigo)

            objControl.setDataSource(dtbDatosAyuda)

            objControl.ShowDialog(Me)
            If (objControl.pSeleccionarValor() IsNot Nothing) Then
                texto.Text = objControl.pSeleccionarValor.TDSDES
            End If


        End If


    End Sub

    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If Me.gwdDatos.RowCount = 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Me.Estado_Controles(False)

            Dim TipoSolicitud As String = gwdDatos.CurrentRow.Cells("TPSOTR").Value

            Me.Cargar_Datos_Grilla()
            If TipoSolicitud = "02" Then
                If Not TabSolicitudFlete.TabPages.Contains(tpg_recursos) Then
                    TabSolicitudFlete.TabPages.Add(tpg_recursos)
                End If
            Else
                If TabSolicitudFlete.TabPages.Contains(tpg_recursos) Then
                    TabSolicitudFlete.TabPages.Remove(tpg_recursos)
                End If
            End If
            Me.Cargar_Detalle_Solicitud()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AsignarEstadoBotones(opcion As MANTENIMIENTO)

        Dim NameTabSelected As String = TabSolicitudFlete.SelectedTab.Name
        Dim Reg As String = ""
        If gwdDatos.CurrentRow IsNot Nothing Then
            Dim EstadoSolicitud As String = "N"
            Dim EstadoReg As String = "N"
            EstadoReg = gwdDatos.CurrentRow.Cells("SESTRG").Value.ToString.Trim
            EstadoSolicitud = gwdDatos.CurrentRow.Cells("SESSLC").Value.ToString.Trim
            If EstadoReg = "*" Then
                Reg = "C"
            End If
            If EstadoSolicitud = "C" Then
                Reg = "C"
            End If
        End If

        Select Case NameTabSelected
            Case "tbInformacionGeneral"
                Me.btnAdjuntarDocumentos.Enabled = False
                tbnAsignarGT.Enabled = False
                btnAnularOperacion.Enabled = False
                btnAsignacionManual_1.Enabled = False

                btnasignar_recursos.Enabled = False

                stbIncidenciaEvalOperativa.Enabled = False
                btnCerrarSolicitud.Enabled = True

                Select Case opcion

                    Case MANTENIMIENTO.NEUTRAL

                        Me.Estado_Controles(False)
                        Me.btnNuevo.Enabled = True
                        Me.btnEliminar.Enabled = True
                        btnModificar.Enabled = True

                        btnGuardar.Visible = False
                        btnCancelar.Visible = False

                    Case MANTENIMIENTO.NUEVO

                        btnNuevo.Enabled = False
                        btnEliminar.Enabled = False
                        btnCerrarSolicitud.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnCancelar.Visible = True

                    Case MANTENIMIENTO.EDITAR

                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = False
                        btnCerrarSolicitud.Enabled = False
                        btnGuardar.Visible = True
                        btnCancelar.Visible = True

                End Select

            Case "tbAsignacion"

                Me.btnCerrarSolicitud.Enabled = False
                Me.btnAnularOperacion.Enabled = True
                Me.btnAdjuntarDocumentos.Enabled = True
                tbnAsignarGT.Enabled = True
                'btnSeguimiento.Enabled = True
                stbIncidenciaEvalOperativa.Enabled = True
                btnNuevo.Enabled = False
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                Me.btnEliminar.Enabled = False
                btnAsignacionManual_1.Enabled = True
                btnasignar_recursos.Enabled = False
                If Reg = "C" Then
                    Me.btnAsignacionManual_1.Enabled = False
                End If
               
            Case "tpg_recursos"

                Me.btnCerrarSolicitud.Enabled = False
                Me.btnAnularOperacion.Enabled = True
                Me.btnAdjuntarDocumentos.Enabled = True
                tbnAsignarGT.Enabled = True

                stbIncidenciaEvalOperativa.Enabled = True
                btnNuevo.Enabled = False
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                Me.btnEliminar.Enabled = False
                btnAsignacionManual_1.Enabled = False
                btnasignar_recursos.Enabled = True
               

        End Select


    End Sub

    Private Sub dtgRecursosAsignados_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtgRecursosAsignados.DataError

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

            Dim EstadoSolicitud As String = ""
            EstadoSolicitud = gwdDatos.CurrentRow.Cells("SESSLC").Value.ToString.Trim
            If EstadoSolicitud = "C" Then
                MessageBox.Show("No se puede modificar , se encuentra cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.Estado_Controles(True)
            cboTipoSolViaje.Enabled = False
            
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            AsignarEstadoBotones(gEnum_Mantenimiento)

            If dtgRecursosAsignados.Rows.Count > 0 Then
                btnBuscaOrdenServicio.Enabled = False
            Else
                btnBuscaOrdenServicio.Enabled = True
            End If

            If Me.gwdDatos.CurrentRow.Cells("NUMREQT").Value > 0 Then
                txtCliente.Enabled = False
                txtOrdenServicio.Enabled = False
                btnBuscaOrdenServicio.Enabled = False
                cboMedioTransporte.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub tbnAsignarGT_Click(sender As Object, e As EventArgs) Handles tbnAsignarGT.Click

    '    Try
    '        Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
    '        Dim frm_frmServicioAlmacen As New frmServicioAlmacen

    '        If Me.dtgRecursosAsignados.RowCount = 0 Then Exit Sub

    '        If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub
    '        If Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value = 0 Then
    '            HelpClass.MsgBox("No tiene una Operación asignada")
    '            Exit Sub
    '        End If
    '        If Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value <> 0 Then
    '            HelpClass.MsgBox("Ya tiene una Guía de Transporte")
    '            Exit Sub
    '        End If
    '        Dim objSolicitudLogica As New Solicitud_Transporte_BLL
    '        Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
    '        Select Case lintStatus
    '            Case -1
    '                HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
    '                Exit Sub

    '        End Select

    '        frm_frmServicioAlmacen.IsMdiContainer = True
    '        'Try
    '        With frm_frmServicioAlmacen
    '            .txtFechaSolicitud.Text = Me.txtFechaSolicitud.Text
    '            .txtFechaAsignacion.Text = Me.dtgRecursosAsignados.Item(11, lint_indice).Value
    '            .Tag = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
    '            ._NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
    '            ._NCSOTR = Me.dtgRecursosAsignados.Item("NCSOT", lint_indice).Value
    '            ._NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
    '            ._NPLNJT = Me.dtgRecursosAsignados.Item("NPLNJT", lint_indice).Value
    '            ._NCRRPL = Me.dtgRecursosAsignados.Item("NCRRPL", lint_indice).Value
    '            ._CCMPN = Me.cmbCompania.CCMPN_CodigoCompania.ToString.Trim
    '            .Estado = Me.cboMedioTransporte.SelectedValue
    '            .ProcesoEjecutar = 0
    '            If txtLocalidadCarga1.Tag.ToString.Trim = "" Then
    '                .ObjetoServicio_Entidad_Guia.CLCLOR = 0
    '            Else
    '                .ObjetoServicio_Entidad_Guia.CLCLOR = CType(txtLocalidadCarga1.Tag, Double)
    '            End If
    '            If txtLocalidadEntrega1.Tag.ToString.Trim = "" Then
    '                .ObjetoServicio_Entidad_Guia.CLCLDS = 0
    '            Else
    '                .ObjetoServicio_Entidad_Guia.CLCLDS = CType(txtLocalidadEntrega1.Tag, Double)
    '            End If
    '            .ObjetoServicio_Entidad_Guia.TDIROR = Me.txtDireccionLocalidadCarga.Text
    '            .ObjetoServicio_Entidad_Guia.TDIRDS = Me.txtDireccionLocalidadEntrega.Text
    '            .ObjetoServicio_Entidad_Guia.QMRCMC = IIf(Me.txtCantidadMercaderia.Text = "", 0, CType(Me.txtCantidadMercaderia.Text, Double))
    '            .ObjetoServicio_Entidad_Guia.CUNDMD = Me.txtUnidadMedida.Codigo
    '            .ObjetoServicio_Entidad_Guia.NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
    '            .ObjetoServicio_Entidad_Guia.NPLCTR = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
    '            .ObjetoServicio_Entidad_Guia.NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
    '            .ObjetoServicio_Entidad_Guia.CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
    '            .ObjetoServicio_Entidad_Guia.CBRCND = Me.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value

    '            .ObjetoServicio_Entidad_Guia.CMEDTR = Me.cboMedioTransporte.SelectedValue
    '            .ObjetoServicio_Entidad_Guia.CTPOVJ = _CTPOVJ

    '            Dim obj_Logica_Guia As New GuiaTransportista_BLL
    '            Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
    '            obj_Entidad_Guia_Transporte.NOPRCN = ._NOPRCN
    '            obj_Entidad_Guia_Transporte.CCMPN = cmbCompania.CCMPN_CodigoCompania.ToString.Trim
    '            obj_Entidad_Guia_Transporte.NPLCTR = .ObjetoServicio_Entidad_Guia.NPLCTR



    '            .ObjetoServicio_Entidad_Guia.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '            .ObjetoServicio_Entidad_Guia.CDVSN = Me.cmbDivision.Division
    '            .ObjetoServicio_Entidad_Guia.CPLNDV = Me.cmbPlanta.Planta

    '            .ObjetoServicio_Entidad_Guia.CUBORI = obj_Entidad_Guia_Transporte.CUBORI
    '            .ObjetoServicio_Entidad_Guia.CUBDES = obj_Entidad_Guia_Transporte.CUBDES

    '            'If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            '    'Me.Listar()
    '            '    Dim NCOREG As String = ""
    '            '    Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
    '            '    obeSeguimientoGPS.NPLCTR = Me.dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value
    '            '    obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCSOT").Value)
    '            '    obeSeguimientoGPS.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
    '            '    obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value)
    '            '    obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me.dtgRecursosAsignados.CurrentRow.Cells("NGSGWP").Value)
    '            '    obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.CurrentRow.Cells("NCOREG").Value)
    '            '    Dim ofrmGPSWAP As New frmGPSWAP()
    '            '    ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
    '            '    ofrmGPSWAP.Estado = 1
    '            '    ofrmGPSWAP.ShowDialog(Me)
    '            '    Me.Cargar_Detalle_Solicitud()
    '            '    Me.gwdDatos.Rows(Me.gwdDatos.CurrentCellAddress.Y).Selected = True
    '            'End If
    '        End With


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

   

    Private Sub tbnAsignarGT_Click(sender As Object, e As EventArgs) Handles tbnAsignarGT.Click

        Try
            

            If dtgRecursosAsignados.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim frm_frmServicioAlmacen As New frmServicioAlmacen
            Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
            If Validar_Recursos_Asignados(lint_indice) = True Then Exit Sub

            If dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value = 0 Then
                HelpClass.MsgBox("No tiene una Operación asignada")
                Exit Sub
            End If

            If dtgRecursosAsignados.CurrentRow.Cells("NGUITR").Value <> 0 Then
                HelpClass.MsgBox("Ya tiene una Guía de Transporte")
                Exit Sub
            End If
            Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(Me.Codigo.Text, Me.cmbCompania.CCMPN_CodigoCompania)
            Select Case lintStatus
                Case -1
                    HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                    Exit Sub

            End Select

            Dim frm_GuiaTransportista As New frmGuiaTransportista
            With frm_GuiaTransportista
                .IsMdiContainer = True
                .AutoSize = True
                Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
                With Comp_Guia
                    .ESTADO = False
                    .Dock = DockStyle.Fill
                    .pCOMPANIA = gwdDatos.CurrentRow.Cells("CCMPN").Value  ' Me.ObjetoServicio_Entidad_Guia.CCMPN
                    .pDIVISION = gwdDatos.CurrentRow.Cells("CDVSN").Value
                    .pPLANTA = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                    .pPLANTA_DESC = cmbPlanta.DescripcionPlanta
                    .pNOPRCN = dtgRecursosAsignados.CurrentRow.Cells("NOPRCN").Value
                    .pUSUARIO = MainModule.USUARIO

                    .Tag = 0
                    .TipoViaje = 0
                    .pNCSOTR = dtgRecursosAsignados.CurrentRow.Cells("NCSOT").Value
                    .pNCRRSR = dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value
                    .pCTPOVJ = dtgRecursosAsignados.CurrentRow.Cells("CTPOVJ_TPOVJE").Value
                   
                    .ChargeForm()


                End With
                .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
                .panelGuia.Controls.Add(Comp_Guia)
                .ShowDialog()
                If Comp_Guia.pDialogOK = True Then
                    dtgRecursosAsignados.CurrentRow.Cells("NGUITR").Value = Comp_Guia.pNGUITR
                End If
               

               
            End With




          


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnadjuntardoc_Click(sender As Object, e As EventArgs) Handles btnadjuntardoc.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim CodCompania As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
            Dim NroSolicitud As Decimal = gwdDatos.CurrentRow.Cells("NCSOTR").Value

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pNroImagen = gwdDatos.CurrentRow.Cells("NMRGIM_S").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZST07
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZST07", "01")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZST07(CodCompania, NroSolicitud)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                gwdDatos.CurrentRow.Cells("NMRGIM_S").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG_S").Value = "X"
                Else
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG_S").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnasignar_recursos_Click(sender As Object, e As EventArgs) Handles btnasignar_recursos.Click

        Try

            If gwdDatos.CurrentRow.Cells Is Nothing Then
                Exit Sub
            End If
            Dim NroSolicitud As Decimal = gwdDatos.CurrentRow.Cells("NCSOTR").Value
            Dim CodCompania As String = gwdDatos.CurrentRow.Cells("CCMPN").Value


            Dim objSolicitudLogica As New Solicitud_Transporte_BLL
            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub

        
            Dim lintStatus As Int32 = objSolicitudLogica.Validar_Solicitud_Transporte(NroSolicitud, CodCompania)
            Select Case lintStatus
                Case -1
                    HelpClass.MsgBox("La Solicitud de Transporte se encuentra anulada")
                    Exit Sub
                Case -2
                    HelpClass.MsgBox("La Solicitud de Transporte se encuentra cerrada")
                    Exit Sub

            End Select


            Dim frm_frmAsignacionManual As New frmAsignacionManualRecurso
            With frm_frmAsignacionManual
                frm_frmAsignacionManual.es_OS_TipoSeguimiento = (("" & Me.gwdDatos.Item("FTRTSG", lint_Indice).Value).ToString.Trim = "X")
                .obj_Entidad.NCSOTR = gwdDatos.CurrentRow.Cells("NCSOTR").Value
                '.obj_Entidad.NCRRSR = 1
                .obj_Entidad.NORSRT = gwdDatos.CurrentRow.Cells("NORSRT").Value
                .obj_Entidad.CCLNT = Me.txtCliente.pCodigo
                .obj_Entidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                .obj_Entidad.CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                .obj_Entidad.CTPOVJ = Me._CTPOVJ
                .obj_Entidad.CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
                .CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                .CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value
                .CPLNDV = gwdDatos.CurrentRow.Cells("CPLNDV").Value
               

                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.gwdDatos.Item("QATNAN", lint_Indice).Value = Me.gwdDatos.Item("QATNAN", lint_Indice).Value + 1
                If CType(Me.gwdDatos.Item("QATNAN", lint_Indice).Value, Int64) >= CType(Me.gwdDatos.Item("QSLCIT", lint_Indice).Value, Int64) Then
                    Me.Listar()

                Else
                    Me.Cargar_Detalle_Solicitud()
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub gv_recursos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gv_recursos.CellDoubleClick
        Try

            Dim columna As String = gv_recursos.Columns(e.ColumnIndex).Name
            Select Case columna
                Case "GENERAR"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    

    Private Sub btnGen_operacion_Click(sender As Object, e As EventArgs) Handles btnGen_operacion.Click
        Try

          
            Dim ofrmAsignacionManualGenOp As New frmAsignacionManualGenOp
            If ofrmAsignacionManualGenOp.ShowDialog() = DialogResult.OK Then

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   

End Class
