Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports Ransa.Utilitario
Imports System.Threading

Public Class frmAtencionRequerimiento

    Private gEnumOpc As EnumMan = EnumMan.Neutro
    Enum EnumMan
        Neutro
        Nuevo
        Editar
    End Enum
    Private TabSeleccionado As String = ""
    Private oHebraReqServ As Thread
    Dim dtNegocio As DataTable

    Private Sub frmReqServicio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try

            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

            If dgvDatos.CurrentRow IsNot Nothing Then
                dgvPreAsignacion.DataSource = Nothing
                dgvDatosSolicitud.DataSource = Nothing
                ''Listar_Unidades_Programadas()
                ''Listar_Solicitudes()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private isCheckRequerimiento As Boolean = False
    Private Sub frmReqServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

            ''TabRequerimiento.TabPages.Remove(TabDatosRequerimiento)

            TabSeleccionado = TabRequerimiento.SelectedTab.Name

            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
            Estado_Controles(False)

            dgvDatos.AutoGenerateColumns = False
            dgvDatosSolicitud.AutoGenerateColumns = False
            dgvPreAsignacion.AutoGenerateColumns = False
            ''dgvDimensiones.AutoGenerateColumns = False
            dgvDimension.AutoGenerateColumns = False
            Cargar_Compania()
            txtClienteFiltro.CCMPN = cmbCompania.CCMPN_CodigoCompania
            Cargar_Estado()
            'Cargar_Prioridad()
            Cargar_Prioridad_Filtro()

            'Lista_Tipo_Mercaderia()
            'Carga_MedioTransporte()

            dtpHoraIniReq.Enabled = False
            dtpHoraFinReq.Enabled = False
            dtpHoraIniAtencion.Enabled = False
            dtpHoraFinAtencion.Enabled = False
            txtNroReqFiltro.Enabled = False
            chkFechaAtencion.Checked = False
            chkHora.Checked = False
            chkHoraAtencion.Checked = False

            chkSolicitud.Checked = False
            txtSolicitudFiltro.Enabled = False

            'Habilitar_Botones(Estado)
            'Habilitar_Controles(Estado)

            Validar_Acceso_Opciones_Usuario()

            chkFechaRequerimiento.Checked = True
            chkFechaRequerimiento_CheckedChanged(Nothing, Nothing)

            'Validad_Botones(False)

            cargarComboNegocio()
            Cargar_Responsable()

            TabRequerimiento.TabPages.Remove(TabSolicitud)
            TabRequerimiento.TabPages.Remove(TabUnidadesProg)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub cargarComboNegocio()


        Dim objBE As New AtencionRequerimiento
        Dim objBLL As New AtencionRequerimiento_BLL

        Dim dtNegocio_data As New DataTable
        Dim dr As DataRow

        Dim Lista1 As New List(Of AtencionRequerimiento)
        Dim entidad1 As AtencionRequerimiento
        Dim Lista2 As New List(Of AtencionRequerimiento)
        Dim entidad2 As New AtencionRequerimiento

        dtNegocio_data = objBLL.Lista_Negocio(cmbCompania.CCMPN_CodigoCompania)

        dr = dtNegocio_data.NewRow
        dr("CCMPN") = "EZ"
        dr("CRGVTA") = "0"
        dr("TCRVTA") = "TODOS"
        dtNegocio_data.Rows.InsertAt(dr, 0)

        For Each item As DataRow In dtNegocio_data.Rows

            entidad1 = New AtencionRequerimiento
            entidad1.CRGVTA = item("CRGVTA")
            entidad1.TCRVTA = item("TCRVTA")
            Lista1.Add(entidad1)
        Next

        cmbNegocio.DisplayMember = "TCRVTA"
        cmbNegocio.ValueMember = "CRGVTA"
        Me.cmbNegocio.DataSource = Lista1

        For i As Integer = 0 To cmbNegocio.Items.Count - 1
            If cmbNegocio.Items.Item(i).Value = "0" Then
                cmbNegocio.SetItemChecked(i, True)
            End If
        Next

        If cmbNegocio.Text = "" Then
            cmbNegocio.SetItemChecked(1, True)
        End If

        dtNegocio = New DataTable
        Dim dr1 As DataRow

        dtNegocio.Columns.Add("CRGVTA_Codigo")
        dtNegocio.Columns.Add("TCRVTA_Descripcion")

        For Each item As DataRow In dtNegocio_data.Rows
            dr1 = dtNegocio.NewRow
            dr1("CRGVTA_Codigo") = item("CRGVTA")
            dr1("TCRVTA_Descripcion") = item("TCRVTA")
            dtNegocio.Rows.Add(dr1)
        Next


    End Sub

    Private Function Lista_Negocios() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
            For j As Integer = 0 To dtNegocio.Rows.Count - 1
                If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
                For j As Integer = 0 To dtNegocio.Rows.Count - 1
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") <> "0") Then
                        strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbNegocio.CheckedItems.Count - 1
                For j As Integer = 0 To dtNegocio.Rows.Count - 1
                    If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") = cmbNegocio.CheckedItems(i).Value) Then
                        strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        'If strCadDocumentos = "" Then
        '    For j As Integer = 0 To dtNegocio.Rows.Count - 1
        '        If (dtNegocio.Rows(j).Item("CRGVTA_Codigo") <> "0") Then
        '            strCadDocumentos += dtNegocio.Rows(j).Item("CRGVTA_Codigo") & ","
        '        End If
        '    Next
        '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)

        'End If

        Return strCadDocumentos

    End Function


    Private Sub Cargar_Responsable()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrIncidencias As New AtencionRequerimiento_BLL
        Dim obeResponsable As New beDestinatario
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNNCRRIT"
        oColumnas.DataPropertyName = "PNNCRRIT"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.Visible = False
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMYAP"
        oColumnas.DataPropertyName = "PSTNMYAP"
        oColumnas.HeaderText = "Nombre"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSEMAILTO"
        oColumnas.DataPropertyName = "PSEMAILTO"
        oColumnas.HeaderText = "Correo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        With obeResponsable
            .PNCCLNT = 999999
            .PSTIPO_ENVIO = "ST_REQSERV"
        End With

        Etiquetas.Add("Nombre")
        Etiquetas.Add("Email")

        'Me.ucResponsable.Etiquetas_Form = Etiquetas
        'Me.ucResponsable.DataSource = obrIncidencias.olisListarResponsables(obeResponsable)
        'Me.ucResponsable.ListColumnas = oListColum
        'Me.ucResponsable.Cargas()
        'Me.ucResponsable.DispleyMember = "PSEMAILTO"
        'Me.ucResponsable.ValueMember = "PSTNMYAP"
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        'If objEntidad.STSADI = "" Then
        '    Me.btnNuevo.Visible = False
        'End If
        'If objEntidad.STSCHG = "" Then
        '    Me.btnModificar.Visible = False
        'End If
        'If objEntidad.STSELI = "" Then
        '    Me.btnEliminar.Visible = False
        'End If
        If objEntidad.STSOP1 = "" Then
            Me.btnCerrarReq.Visible = False
        End If
        If objEntidad.STSOP2 = "" Then
            'Me.btnAtender.Visible = False
        End If

    End Sub

    'Private Sub Carga_MedioTransporte()
    '    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    '    Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(cmbCompania.CCMPN_CodigoCompania)
    '    Me.cboMedioTransporte.DataSource = objTabla.Copy
    '    Me.cboMedioTransporte.ValueMember = "CMEDTR"
    '    Me.cboMedioTransporte.DisplayMember = "TNMMDT"
    'End Sub


    'Sub Lista_Tipo_Mercaderia()

    '    Dim objBLL As New AtencionRequerimiento_BLL
    '    Dim dtIncPara As New DataTable
    '    Dim dr As DataRow

    '    dtIncPara = objBLL.Lista_Tipo_Mercaderia

    '    dr = dtIncPara.NewRow
    '    dr("TIPOCNT") = 0
    '    dr("TIPOCNT_S") = ":: Seleccione ::"
    '    dtIncPara.Rows.InsertAt(dr, 0)

    '    cmbMercaderia.DataSource = dtIncPara
    '    cmbMercaderia.DisplayMember = "TIPOCNT_S"
    '    cmbMercaderia.ValueMember = "TIPOCNT"
    '    cmbMercaderia.SelectedValue = 0

    'End Sub



    Private Function TipoSolicitud()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        Dim oDr As DataRow

        oDr = oDt.NewRow
        oDr.Item(0) = "I"
        oDr.Item(1) = "Ida"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "R"
        oDr.Item(1) = "Retorno"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "V"
        oDr.Item(1) = "Ida y Vuelta"
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


    Private Sub Cargar_Compania()

        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted

        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "T"
            End If
            cmbDivision.pActualizar()
            cmbDivision_SelectionChangeCommitted(Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Me.cmbPlanta.Usuario = MainModule.USUARIO
        Me.cmbPlanta.CodigoCompania = cmbDivision.Compania
        Me.cmbPlanta.CodigoDivision = cmbDivision.Division
        Me.cmbPlanta.PlantaDefault = 1
        Me.cmbPlanta.pActualizar()
    End Sub

    Sub Cargar_Estado()

        Dim dtEstado As New DataTable
        Dim dr As DataRow

        dtEstado.Columns.Add("SESREQ", Type.GetType("System.String"))
        dtEstado.Columns.Add("SESREQ_S", Type.GetType("System.String"))

        dr = dtEstado.NewRow
        dr("SESREQ") = "0"
        dr("SESREQ_S") = "Todos"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("SESREQ") = "P"
        dr("SESREQ_S") = "Pendiente"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("SESREQ") = "A"
        dr("SESREQ_S") = "En Atención"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("SESREQ") = "C"
        dr("SESREQ_S") = "Cerrado"
        dtEstado.Rows.Add(dr)

        cmbEstado.DataSource = dtEstado
        cmbEstado.DisplayMember = "SESREQ_S"
        cmbEstado.ValueMember = "SESREQ"
        cmbEstado.SelectedValue = "P"

    End Sub

    Sub Cargar_Prioridad_Filtro()

        Dim dtPrioridad As New DataTable
        Dim dr As DataRow

        dtPrioridad.Columns.Add("SPRSTR", Type.GetType("System.String"))
        dtPrioridad.Columns.Add("SPRSTR_S", Type.GetType("System.String"))

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "0"
        dr("SPRSTR_S") = "Todos"
        dtPrioridad.Rows.Add(dr)

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "N"
        dr("SPRSTR_S") = "Normal"
        dtPrioridad.Rows.Add(dr)

        dr = dtPrioridad.NewRow
        dr("SPRSTR") = "U"
        dr("SPRSTR_S") = "Urgente"
        dtPrioridad.Rows.Add(dr)

        cmbPrioridadFiltro.DataSource = dtPrioridad
        cmbPrioridadFiltro.DisplayMember = "SPRSTR_S"
        cmbPrioridadFiltro.ValueMember = "SPRSTR"
        cmbPrioridadFiltro.SelectedValue = "0"

    End Sub


    'Sub Cargar_Prioridad()

    '    Dim dtPrioridad As New DataTable
    '    Dim dr As DataRow

    '    dtPrioridad.Columns.Add("SPRSTR", Type.GetType("System.String"))
    '    dtPrioridad.Columns.Add("SPRSTR_S", Type.GetType("System.String"))


    '    dr = dtPrioridad.NewRow
    '    dr("SPRSTR") = "N"
    '    dr("SPRSTR_S") = "Normal"
    '    dtPrioridad.Rows.Add(dr)

    '    dr = dtPrioridad.NewRow
    '    dr("SPRSTR") = "U"
    '    dr("SPRSTR_S") = "Urgente"
    '    dtPrioridad.Rows.Add(dr)

    '    cmbPrioridad.DataSource = dtPrioridad
    '    cmbPrioridad.DisplayMember = "SPRSTR_S"
    '    cmbPrioridad.ValueMember = "SPRSTR"
    '    cmbPrioridad.SelectedValue = "N"

    'End Sub

    Private Sub NroReq_Solo_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Obtener_Filtro() As AtencionRequerimiento
        Dim Entidad As New AtencionRequerimiento
        Entidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        Entidad.CDVSN = cmbDivision.Division
        Entidad.CPLNDV = cmbPlanta.Planta
        Entidad.SESREQ = cmbEstado.SelectedValue
        Entidad.CCLNT = txtClienteFiltro.pCodigo
        Entidad.SPRSTR = cmbPrioridadFiltro.SelectedValue

        If chkFechaRequerimiento.Checked = True Then
            Entidad.FECREQ_INI = CDec(String.Format("{0:yyyyMMdd}", dtpFechaInicioReq.Value))
        Else
            Entidad.FECREQ_INI = 0D
        End If

        If chkFechaRequerimiento.Checked = True Then
            Entidad.FECREQ_FIN = CDec(String.Format("{0:yyyyMMdd}", dtpFechaFinReq.Value))
        Else
            Entidad.FECREQ_FIN = 0D
        End If

        If chkHora.Checked = True Then
            Entidad.HRAREQ_INI = CDec(String.Format("{0:HHmmss}", dtpHoraIniReq.Value))
            Entidad.HRAREQ_FIN = CDec(String.Format("{0:HHmmss}", dtpHoraFinReq.Value))
        Else
            Entidad.HRAREQ_INI = 0D
            Entidad.HRAREQ_FIN = 0D
        End If

        'FECHA DE REQUERIMIENTO ATENDIDO

        If chkFechaAtencion.Checked = True Then
            Entidad.FCHATN_INI = CDec(String.Format("{0:yyyyMMdd}", dtpFechaInicioAtencion.Value))
            Entidad.FCHATN_FIN = CDec(String.Format("{0:yyyyMMdd}", dtpFechaFinAtencion.Value))
        Else
            Entidad.FCHATN_INI = 0D
            Entidad.FCHATN_FIN = 0D
        End If

        If chkHoraAtencion.Checked = True Then
            Entidad.HRAATN_INI = CDec(String.Format("{0:HHmmss}", dtpHoraIniAtencion.Value))
            Entidad.HRAATN_FIN = CDec(String.Format("{0:HHmmss}", dtpHoraFinAtencion.Value))
        Else
            Entidad.HRAATN_INI = 0D
            Entidad.HRAATN_FIN = 0D
        End If

        If chkNumReq.Checked = True Then
            Entidad.NUMREQT = CDec(Val(txtNroReqFiltro.Text))
        Else
            Entidad.NUMREQT = 0D
        End If

        If chkSolicitud.Checked = True Then
            Entidad.NCSOTR = CDec(Val(txtSolicitudFiltro.Text))
        Else
            Entidad.NCSOTR = 0D
        End If

        Entidad.CRGVTA = Lista_Negocios()

        If chkEnJunta.Checked = True Then
            Entidad.SJTTR = "X"
        Else
            Entidad.SJTTR = "T"
        End If

        Return Entidad
    End Function

    Private Sub Listar_Atencion_Requerimiento()
        Try

            Dim Negocio As New AtencionRequerimiento_BLL
            Dim Mensaje As String = ""

            'If txtClienteFiltro.pCodigo = 0 Then
            '    Mensaje = "Seleccione un cliente" & Environment.NewLine
            'End If

            If Lista_Negocios.ToString.Trim = "" Then
                Mensaje = Mensaje & "Seleccione un Negocio"
            End If

            If Mensaje.ToString.Trim.Length > 0 Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            dgvDatos.DataSource = Nothing
            dgvDatosSolicitud.DataSource = Nothing
            dgvPreAsignacion.DataSource = Nothing
            Limpiar_Controles()
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)


            dgvDatos.DataSource = Negocio.Lista_Atencion_Requerimiento(Obtener_Filtro)

            If dgvDatos.RowCount > 0 Then
                For Each Item As DataGridViewRow In dgvDatos.Rows
                    If (Item.Cells("NMRGIM").Value > 0) Then
                        Item.Cells("IMG_NMRGIM").Value = My.Resources.text_block
                    Else
                        Item.Cells("IMG_NMRGIM").Value = My.Resources.CuadradoBlanco
                    End If

                    If (Item.Cells("NROENV").Value > 0) Then
                        Item.Cells("IMG_ENVIO").Value = My.Resources.text_block
                    Else
                        Item.Cells("IMG_ENVIO").Value = My.Resources.CuadradoBlanco
                    End If

                    If (Item.Cells("SJTTR").Value = "X") Then
                        Item.Cells("IMG_UNPROG").Value = My.Resources.text_block
                    Else
                        Item.Cells("IMG_UNPROG").Value = My.Resources.CuadradoBlanco
                    End If

                    If (Item.Cells("SOLICT").Value > 0) Then
                        Item.Cells("IMG_SOL").Value = My.Resources.text_block
                    Else
                        Item.Cells("IMG_SOL").Value = My.Resources.CuadradoBlanco
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Listar_Atencion_Requerimiento()

    End Sub

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If Me.txtCliente.Text.Trim = "" Then
            strMensajeError &= "* Ingresar cliente" & vbNewLine
        End If

        If txtPrioridad.Text.Trim = "" Then strMensajeError &= "* Ingrese tipo prioridad" & vbNewLine
        If txtTipoMerc.Text.Trim = "" Then strMensajeError &= "* Seleccione tipo mercadería" & vbNewLine
        'If chkReparto.Checked = False And chkTraslado.Checked = False Then strMensajeError &= "* Seleccione tipo requerimiento" & vbNewLine
        If txtPeso.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese peso(kg)" & vbNewLine
        'If txtLargo.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese largo(m)" & vbNewLine
        'If txtAncho.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese ancho(m)" & vbNewLine
        'If txtAlto.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese alto(m)" & vbNewLine

        If txtOS.Text.ToString.Trim = "" Then
            strMensajeError &= "* Seleccione  orden de servicio" & vbNewLine
        Else
            If txtLugarOrigen.Text.ToString.Trim = "" Then strMensajeError &= "* Asignar localidad origen" & vbNewLine
            If txtLugarDestino.Text.ToString.Trim = "" Then strMensajeError &= "* Asignar localidad destino" & vbNewLine
        End If
        If txtResponsable.Text.ToString.Trim = "" Then
            strMensajeError &= "* Seleccione un Responsable" & vbNewLine
        End If
        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    'Private Sub Eliminar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    '    Try
    '        If dgvDatos.CurrentRow Is Nothing Then Exit Sub

    '        Dim Negocio As New RequerimientoServicio_BLL

    '        If dgvDatosSolicitud.Rows.Count > 0 Then
    '            MessageBox.Show("No se puede eliminar, existen solicitudes asignadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        'If dgvDatos.CurrentRow.Cells("SESREQ").Value.ToString.Trim = "P" Then
    '        Dim Entidad As New RequerimientoServicio

    '        If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            Entidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
    '            Entidad.NUMREQT = CDec(dgvDatos.CurrentRow.Cells("NUMREQT").Value)
    '            Entidad.CUSCRT = MainModule.USUARIO
    '            Entidad.NTRMCR = Environment.MachineName
    '            Negocio.intEliminarRequerimientoServicio(Entidad)
    '            Buscar(Nothing, Nothing)
    '        End If
    '        'End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If dgvDatos.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
            Dim ListaExcel As List(Of AtencionRequerimiento) = Me.dgvDatos.DataSource
            Dim dtExcel As New DataTable
            Dim dtExcel_1 As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NUMREQT").Caption = NPOI_SC.FormatDato("Nro. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORSRT").Caption = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLOR_S").Caption = NPOI_SC.FormatDato("Lugar Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDS_S").Caption = NPOI_SC.FormatDato("Lugar Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCLNT_S").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCLNFC_S").Caption = NPOI_SC.FormatDato("Cliente (Facturación)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIPOCNT_S").Caption = NPOI_SC.FormatDato("Tipo Mercadería", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECREQ_S").Caption = NPOI_SC.FormatDato("Fecha Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAREQ_S").Caption = NPOI_SC.FormatDato("Hora Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("FCHATN_D").Caption = NPOI_SC.FormatDato("Fecha para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAATN_D").Caption = NPOI_SC.FormatDato("Hora para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("SPRSTR_S").Caption = NPOI_SC.FormatDato("Prioridad", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QSLCIT").Caption = NPOI_SC.FormatDato("Cant. Vehículos", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDJUNTA").Caption = NPOI_SC.FormatDato("Unid. Programadas (Junta)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDSOLICITADAS").Caption = NPOI_SC.FormatDato("Unid. Solicitadas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDATENDIDAS").Caption = NPOI_SC.FormatDato("Unid. Atendidas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TNMMDT_1").Caption = NPOI_SC.FormatDato("Medio Transporte", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBERV").Caption = NPOI_SC.FormatDato("Descripción Mercadería", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("REFDO1").Caption = NPOI_SC.FormatDato("Doc. Referencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QPSOMR").Caption = NPOI_SC.FormatDato("Peso total (kg)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TDRCOR").Caption = NPOI_SC.FormatDato("Dirección Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDRENT").Caption = NPOI_SC.FormatDato("Dirección Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIRALC").Caption = NPOI_SC.FormatDato("Responsable", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PRSCNT").Caption = NPOI_SC.FormatDato("Contacto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SESREQ_S").Caption = NPOI_SC.FormatDato("Estado Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CUSCRT").Caption = NPOI_SC.FormatDato("Usuario Creador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CULUSA").Caption = NPOI_SC.FormatDato("Usuario Actualizador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORSRTSR").Caption = NPOI_SC.FormatDato("O/S Sol. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLORSR_S").Caption = NPOI_SC.FormatDato("Lugar Origen Sol. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDSSR_S").Caption = NPOI_SC.FormatDato("Lugar Destino Sol. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NDCORMSR").Caption = NPOI_SC.FormatDato("Nro. Doc. Origen Sol. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PNCDTRSR").Caption = NPOI_SC.FormatDato("Nro. Ope. Agencias Sol. Req.", NPOI_SC.keyDatoTexto)


            'dtExcel_1 = HelpClass.GetDataSetNative(ListaExcel).Copy

            Dim columna As String = ""

            For FilaGrid As Integer = 0 To dgvDatos.Rows.Count - 1
                dr = dtExcel.NewRow
                For Each ItemCol As DataColumn In dtExcel.Columns
                    columna = ItemCol.ColumnName
                    If dgvDatos.Columns(columna) IsNot Nothing Then
                        dr(columna) = dgvDatos.Rows(FilaGrid).Cells(columna).Value
                    End If
                Next
                dtExcel.Rows.Add(dr)
            Next
            'For Each columna As DataColumn In dtExcel_1.Columns
            '    For Each columna1 As DataColumn In dtExcel.Columns


            '    Next
            'Next

            'For Each item As AtencionRequerimiento In ListaExcel
            '    dr = dtExcel.NewRow
            '    dr("TCRVTA") = item.TCRVTA
            '    dr("CCLNFC_S") = item.CCLNFC_S
            '    dr("NORSRT") = item.NORSRT
            '    dr("CCLNT_S") = item.CCLNT_S
            '    dr("NUMREQT") = item.NUMREQT
            '    dr("SPRSTR_S") = item.SPRSTR_S
            '    dr("TIPOCNT_S") = item.TIPOCNT_S

            '    dr("FECREQ_S") = item.FECREQ_S
            '    dr("HRAREQ_S") = item.HRAREQ_S

            '    dr("FCHATN_D") = item.FCHATN_D
            '    dr("HRAATN_D") = item.HRAATN_D

            '    dr("QSLCIT") = item.QSLCIT
            '    dr("QUNIDJUNTA") = item.QUNIDJUNTA
            '    dr("QUNIDSOLICITADAS") = item.QUNIDSOLICITADAS

            '    dr("QPSOMR") = item.QPSOMR
            '    ''dr("QMTLRG") = item.QMTLRG
            '    ''dr("QMTALT") = item.QMTALT
            '    '' dr("QMTANC") = item.QMTANC

            '    dr("NDCORM") = item.NDCORM
            '    dr("CLCLOR_S") = item.CLCLOR_S
            '    dr("CLCLDS_S") = item.CLCLDS_S
            '    dr("TDRCOR") = item.TDRCOR
            '    dr("TDRENT") = item.TDRENT

            '    ''dr("TIPSRV_S") = item.TIPSRV_S
            '    dr("REFDO1") = item.REFDO1
            '    dr("TOBS") = item.TOBS
            '    dr("CUSCRT") = item.CUSCRT
            '    dr("CULUSA") = item.CULUSA
            '    dr("SESREQ_S") = item.SESREQ_S

            '    dr("TIRALC") = item.TIRALC
            '    dr("PRSCNT") = item.PRSCNT

            '    dtExcel.Rows.Add(dr)
            'Next

            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "REQUERIMIENTO_SERVICIO"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("LISTA DE REQUERIMIENTOS DE SERVICIO")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cmbDivision.DivisionDescripcion)
            F.Add(2, "Planta:| " & cmbPlanta.DescripcionPlanta)

            'If chkFecha.Checked = True Then
            '    F.Add(5, "Fecha:| " & Me.dtpFechaInicioReq.Value.Date & " - " & Me.dtpFechaFinReq.Value.Date)
            'End If
            'F.Add(5, "Fecha:| " & Me.dtpFechaInicioReq.Value.Date & " - " & Me.dtpFechaFinReq.Value.Date)

            oLisFiltro.Add(F)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub







    'Private Sub dgvDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Try

    '        Dim lint_indice As Integer = Me.dgvDatos.CurrentCellAddress.Y

    '        Select Case ("" & dgvDatos.Item("SESREQ", lint_indice).Value).ToString().Trim()

    '            Case "P"
    '                'btnAsignarSolicitud.Enabled = False
    '                'btnModificarSolicitud.Enabled = False
    '                'btnCancelar.Enabled = False
    '                'btnAnularSolicitud.Enabled = False
    '                'Validad_Botones(False)
    '                'Valida_Botones(True)

    '                btnModificar.Enabled = True
    '                btnEliminar.Enabled = True
    '                btnAtender.Enabled = True

    '            Case "R"
    '                'btnAsignarSolicitud.Enabled = True
    '                'btnModificarSolicitud.Enabled = False
    '                'btnCancelar.Enabled = False
    '                'btnAnularSolicitud.Enabled = False
    '                'Validad_Botones(False)
    '                'Valida_Botones(False)

    '                btnModificar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False

    '            Case "A"
    '                'btnAsignarSolicitud.Enabled = False
    '                'btnModificarSolicitud.Enabled = True
    '                'btnModificarSolicitud.Text = "Modificar"
    '                'btnCancelar.Enabled = True
    '                'btnAnularSolicitud.Enabled = True
    '                'Validad_Botones(False)
    '                'Cargar_Informacion()
    '                'Valida_Botones(False)

    '                btnModificar.Enabled = False
    '                btnEliminar.Enabled = False
    '                btnAtender.Enabled = False

    '        End Select



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    'Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        dgvDatos_SelectionChanged(Nothing, Nothing)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub chkHora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHora.CheckedChanged
        Try
            dtpHoraIniReq.Enabled = chkHora.Checked
            dtpHoraFinReq.Enabled = chkHora.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KryptonCheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHoraAtencion.CheckedChanged

        Try
            dtpHoraIniAtencion.Enabled = chkHoraAtencion.Checked
            dtpHoraFinAtencion.Enabled = chkHoraAtencion.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dgvDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    '    If dgvDatos.Columns.Item(e.ColumnIndex).Name = "CHK" Then
    '        If dgvDatos.CurrentRow.Cells("SESREQ").Value <> "P" Then
    '            dgvDatos.CurrentRow.Cells("CHK").Value = False
    '            dgvDatos.EndEdit()
    '        End If
    '    End If


    'End Sub


    Private Sub txtCantidadSolicitada_SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadSolicitada.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Limpiar_Controles()

        'UcCliente_TxtF011.pClear()
        txtCliente.Text = ""
        txtNroReq.Text = ""
        'cmbMercaderia.SelectedValue = 0
        'cmbPrioridad.SelectedValue = "N"
        'cboMedioTransporte.SelectedValue = 4
        txtCantidadSolicitada.Text = ""
        txtPeso.Text = ""
        'txtLargo.Text = ""
        'txtAncho.Text = ""
        'txtAlto.Text = ""
        txtOS.Text = ""
        txtOSAgencia.Text = ""
        txtOSAgencia.Tag = ""
        txtUbigeoOrigen.Text = ""
        txtUbigeoDestino.Text = ""
        txtLugarOrigen.Text = ""
        txtLugarDestino.Text = ""
        txtTipoUnidad.Text = ""
        'txtMercaderia.Text = ""
        txtDireccionOrigen.Text = ""
        txtDireccionDestino.Text = ""
        txtDocRef.Text = ""
        txtObservaciones.Text = ""
        txtLugarOrigen.Tag = ""
        txtLugarDestino.Tag = ""
        dtpFechaReg.Value = Now.Date
        dtpFechaAten.Value = Now.Date

        txtDescripcionMercaderia.Text = ""
        txtContacto.Text = ""
        txtResponsable.Text = ""
        'txtEmail.Text = ""

    End Sub


    'UTILIZAR SOLO PARA INHABILITAR
    Private Sub Estado_Controles(ByVal estado As Boolean)
        ''UcCliente_TxtF011.Enabled = estado
        txtCliente.Enabled = estado
        txtTipoMerc.Enabled = estado
        'cmbMercaderia.Enabled = estado
        'cboMedioTransporte.SelectedValue = 4
        txtMedioTransp.Enabled = estado
        'cboMedioTransporte.Enabled = estado
        txtPrioridad.Enabled = estado
        'cmbPrioridad.Enabled = estado
        'cboMedioTransporte.Enabled = estado
        txtCantidadSolicitada.Enabled = estado
        txtPeso.Enabled = estado
        'txtLargo.Enabled = estado
        'txtAncho.Enabled = estado
        'txtAlto.Enabled = estado
        txtDireccionOrigen.Enabled = estado
        txtDireccionDestino.Enabled = estado
        txtDocRef.Enabled = estado
        txtObservaciones.Enabled = estado
        'btnBuscaOrdenServicio.Enabled = estado
        'btnAsignarOSAgencias.Enabled = estado
        dtpFechaReg.Enabled = estado
        dtpHoraReg.Enabled = estado
        dtpFechaAten.Enabled = estado
        dtpHoraAten.Enabled = estado

        txtDescripcionMercaderia.Enabled = estado
        txtContacto.Enabled = estado
        'ucResponsable.Enabled = estado

        'chkReparto.Enabled = estado
        'chkTraslado.Enabled = estado
    End Sub


    'Sub Habilitar_Controles(ByVal Estado As Mantenimiento)

    '    Select Case Estado

    '        Case Mantenimiento.Neutro

    '            UcCliente_TxtF011.Enabled = False
    '            cmbMercaderia.Enabled = False
    '            cboMedioTransporte.SelectedValue = 4
    '            cmbPrioridad.Enabled = False
    '            cboMedioTransporte.Enabled = False
    '            txtCantidadSolicitada.Enabled = False
    '            txtPeso.Enabled = False
    '            txtLargo.Enabled = False
    '            txtAncho.Enabled = False
    '            txtAlto.Enabled = False
    '            txtDireccionOrigen.Enabled = False
    '            txtDireccionDestino.Enabled = False
    '            txtDocRef.Enabled = False
    '            txtObservaciones.Enabled = False
    '            btnBuscaOrdenServicio.Enabled = False
    '            btnAsignarOSAgencias.Enabled = False

    '            dtpFechaReg.Enabled = False
    '            dtpHoraReg.Enabled = False
    '            dtpFechaAten.Enabled = False
    '            dtpHoraAten.Enabled = False

    '            chkReparto.Enabled = False
    '            chkTraslado.Enabled = False

    '        Case Mantenimiento.Nuevo

    '            UcCliente_TxtF011.Enabled = True
    '            cmbMercaderia.Enabled = True
    '            cmbMercaderia.SelectedValue = 4
    '            cmbPrioridad.Enabled = True
    '            cboMedioTransporte.Enabled = True
    '            cboMedioTransporte.SelectedValue = 4
    '            txtCantidadSolicitada.Enabled = True
    '            txtPeso.Enabled = True
    '            txtLargo.Enabled = True
    '            txtAncho.Enabled = True
    '            txtAlto.Enabled = True
    '            txtDireccionOrigen.Enabled = True
    '            txtDireccionDestino.Enabled = True
    '            txtDocRef.Enabled = True
    '            txtObservaciones.Enabled = True
    '            btnBuscaOrdenServicio.Enabled = True
    '            btnAsignarOSAgencias.Enabled = True

    '            dtpFechaReg.Enabled = True
    '            dtpHoraReg.Enabled = True
    '            dtpFechaAten.Enabled = True
    '            dtpHoraAten.Enabled = True

    '            chkReparto.Enabled = True
    '            chkTraslado.Enabled = True
    '            chkTraslado.Checked = True


    '        Case Mantenimiento.Modificar

    '            UcCliente_TxtF011.Enabled = False
    '            cmbMercaderia.Enabled = True
    '            cmbPrioridad.Enabled = True
    '            cboMedioTransporte.Enabled = True
    '            txtCantidadSolicitada.Enabled = True
    '            txtPeso.Enabled = True
    '            txtLargo.Enabled = True
    '            txtAncho.Enabled = True
    '            txtAlto.Enabled = True
    '            txtDireccionOrigen.Enabled = True
    '            txtDireccionDestino.Enabled = True
    '            txtDocRef.Enabled = True
    '            txtObservaciones.Enabled = True
    '            btnBuscaOrdenServicio.Enabled = True
    '            btnAsignarOSAgencias.Enabled = True

    '            dtpFechaReg.Enabled = True
    '            dtpHoraReg.Enabled = True
    '            dtpFechaAten.Enabled = True
    '            dtpHoraAten.Enabled = True

    '            chkReparto.Enabled = True
    '            chkTraslado.Enabled = True


    '    End Select



    'End Sub

    'Sub Habilitar_Botones(ByVal Estado As Mantenimiento)


    '    Select Case Estado

    '        Case Mantenimiento.Neutro

    '            btnNuevo.Enabled = True
    '            btnModificar.Enabled = True
    '            btnCancelar.Enabled = False
    '            btnEliminar.Enabled = True
    '            btnModificar.Text = "Modificar"
    '            btnAtender.Enabled = True
    '            btnCerrarReq.Enabled = True

    '        Case Mantenimiento.Nuevo

    '            btnNuevo.Enabled = False
    '            btnModificar.Enabled = True
    '            btnCancelar.Enabled = True
    '            btnEliminar.Enabled = False
    '            btnAtender.Enabled = False
    '            btnCerrarReq.Enabled = False

    '        Case Mantenimiento.Modificar

    '            btnNuevo.Enabled = False
    '            btnModificar.Enabled = True
    '            btnCancelar.Enabled = True
    '            btnEliminar.Enabled = False
    '            btnAtender.Enabled = False
    '            btnCerrarReq.Enabled = False

    '    End Select


    'End Sub

    'Sub Habilitar_Botones_A(ByVal Estado As Mantenimiento)


    '    Select Case Estado

    '        Case Mantenimiento.Neutro

    '            btnNuevo.Enabled = True
    '            btnModificar.Enabled = False
    '            btnCancelar.Enabled = False
    '            btnEliminar.Enabled = False
    '            btnModificar.Text = "Modificar"
    '            btnAtender.Enabled = True

    '        Case Mantenimiento.Nuevo

    '            btnNuevo.Enabled = False
    '            btnModificar.Enabled = True
    '            btnCancelar.Enabled = True
    '            btnEliminar.Enabled = False
    '            btnAtender.Enabled = False

    '    End Select

    'End Sub

    Private Sub HabilitarOpcion(ByVal opc As EnumMan, ByVal tabActivo As String)

        Select Case tabActivo
            Case "TabDatosRequerimiento"
                Select Case opc
                    Case EnumMan.Neutro
                        ''btnNuevo.Enabled = True
                        ''btnModificar.Enabled = True
                        ''btnGuardar.Visible = False
                        ''btnGuardar.Enabled = False
                        ''btnCancelar.Enabled = False
                        ''btnEliminar.Enabled = True
                        btnCerrarReq.Enabled = True
                        'btnAtender.Enabled = True
                        ''btnExportarExcel.Enabled = True
                        btnModificarOS.Enabled = True

                    Case EnumMan.Nuevo
                        ''btnNuevo.Enabled = False
                        ''btnModificar.Enabled = False
                        ''btnGuardar.Visible = True
                        ''btnGuardar.Enabled = True
                        ''btnCancelar.Enabled = True
                        ''btnEliminar.Enabled = False
                        btnCerrarReq.Enabled = False
                        'btnAtender.Enabled = False
                        btnExportarExcel.Enabled = False
                        btnModificarOS.Enabled = True

                    Case EnumMan.Editar
                        ''btnNuevo.Enabled = False
                        ''btnModificar.Enabled = False
                        ''btnGuardar.Visible = True
                        ''btnGuardar.Enabled = True
                        ''btnCancelar.Enabled = True
                        ''btnEliminar.Enabled = False
                        btnCerrarReq.Enabled = False
                        'btnAtender.Enabled = False
                        ''btnExportar.Enabled = False
                        btnModificarOS.Enabled = True
                End Select
            Case "TabUnidadesProg"
                'btnNuevo.Enabled = False
                ''btnModificar.Enabled = False
                ''btnGuardar.Visible = False
                ''btnGuardar.Enabled = False
                ''btnCancelar.Enabled = False
                ''btnEliminar.Enabled = False
                btnCerrarReq.Enabled = True
                'btnAtender.Enabled = True
                ''btnExportar.Enabled = True
                btnModificarOS.Enabled = False

            Case "TabSolicitud"
                'btnNuevo.Enabled = False
                'btnModificar.Enabled = False
                'btnGuardar.Visible = False
                'btnGuardar.Enabled = False
                ''btnCancelar.Enabled = False
                ''btnEliminar.Enabled = False
                btnCerrarReq.Enabled = True
                'btnAtender.Enabled = True
                ''btnExportar.Enabled = True
                btnModificarOS.Enabled = False
        End Select

    End Sub


    Private Sub btnCerrarReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarReq.Click
        Try

            Dim ReqServ As New ENTIDADES.AtencionRequerimiento
            Dim ReqServ_Estado As New ENTIDADES.AtencionRequerimiento
            Dim Negocio As New AtencionRequerimiento_BLL

            If dgvDatos.CurrentRow IsNot Nothing Then

                ReqServ.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                ReqServ.CDVSN = dgvDatos.CurrentRow.Cells("CDVSN").Value
                ReqServ.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value

                ReqServ_Estado = Negocio.Lista_Requerimiento_Servicio_Estado_Actual(ReqServ)

                If ReqServ_Estado.SESREQ.ToString.Trim = "C" Then
                    MessageBox.Show("El requerimiento ya se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                For Each fila As DataGridViewRow In dgvDatosSolicitud.Rows
                    If fila.Cells("SESSLC").Value.ToString.Trim <> "C" Then
                        MessageBox.Show("El requerimiento no se puede cerrar. Las solicitudes asignadas deben estar cerradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next

                If MessageBox.Show("Está seguro de cerrar la atención del requerimiento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    ReqServ.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                    ReqServ.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                    ReqServ.CUSCRT = MainModule.USUARIO
                    ReqServ.NTRMCR = Environment.MachineName
                    ReqServ.SESREQ = "C"
                    Negocio.intActualizarRequerimientoSolicitud(ReqServ)
                    Buscar(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Nuevo_Requerimiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    '    Try

    '        Limpiar_Controles()
    '        gEnumOpc = EnumMan.Nuevo
    '        HabilitarOpcion(EnumMan.Nuevo, TabRequerimiento.SelectedTab.Name)

    '        dgvDimensiones.DataSource = Nothing
    '        UcCliente_TxtF011.Enabled = True
    '        cmbMercaderia.SelectedValue = 4
    '        cmbPrioridad.SelectedValue = "N"
    '        cboMedioTransporte.SelectedValue = 4

    '        cmbMercaderia.Enabled = True
    '        cboMedioTransporte.Enabled = True
    '        cmbPrioridad.Enabled = True
    '        txtCantidadSolicitada.Enabled = True
    '        txtPeso.Enabled = True
    '        'txtLargo.Enabled = True
    '        'txtAncho.Enabled = True
    '        'txtAlto.Enabled = True
    '        txtDireccionOrigen.Enabled = True
    '        txtDireccionDestino.Enabled = True
    '        txtDocRef.Enabled = True
    '        txtObservaciones.Enabled = True
    '        btnBuscaOrdenServicio.Enabled = True
    '        btnAsignarOSAgencias.Enabled = True
    '        dtpFechaReg.Enabled = True
    '        dtpHoraReg.Enabled = True
    '        dtpFechaAten.Enabled = True
    '        dtpHoraAten.Enabled = True

    '        txtDescripcionMercaderia.Enabled = True
    '        txtContacto.Enabled = True

    '        ucResponsable.Enabled = True

    '        'chkReparto.Enabled = True
    '        'chkTraslado.Enabled = True
    '        'chkTraslado.Checked = True
    '        'Estado = Mantenimiento.Nuevo
    '        'Habilitar_Controles(Estado)
    '        'Habilitar_Botones(Estado)
    '        'btnModificar.Text = "Guardar"
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Function AsignarEntRequerimiento() As AtencionRequerimiento
        Dim Entidad As New AtencionRequerimiento
        Dim Negocio As New AtencionRequerimiento_BLL
        ' With Entidad
        Entidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        Entidad.CDVSN = cmbDivision.Division
        Entidad.CPLNDV = cmbPlanta.Planta
        ''Entidad.CCLNT = UcCliente_TxtF011.pCodigo
        ''Entidad.CCLNT_S = UcCliente_TxtF011.pRazonSocial

        Entidad.NORSRT = Val(txtOS.Text)
        Entidad.NDCORM = Val(txtOSAgencia.Text)

        Entidad.SESREQ = "P"
        Entidad.SPRSTR = txtPrioridad.Tag 'cmbPrioridad.SelectedValue
        Entidad.SPRSTR_S = txtPrioridad.Text.Trim 'cmbPrioridad.Text.ToString.Trim
        Entidad.TIPOCNT = txtTipoMerc.Tag 'cmbMercaderia.SelectedValue
        Entidad.TIPOCNT_S = txtTipoMerc.Text.Trim 'cmbMercaderia.Text.ToString.Trim

        'If chkReparto.Checked = True Then
        '    Entidad.TIPSRV = "R"
        '    Entidad.TIPSRV_S = "Reparto"
        'Else
        '    Entidad.TIPSRV = "T"
        '    Entidad.TIPSRV_S = "Traslado"
        'End If
        Entidad.TIPSRV = "T"

        Entidad.FECREQ = CDec(String.Format("{0:yyyyMMdd}", dtpFechaReg.Value))
        Entidad.FECREQ_S = String.Format("{0:d/M/yyyy}", dtpFechaReg.Value)
        Entidad.HRAREQ = CDec(String.Format("{0:HHmmss}", dtpHoraReg.Value))
        Entidad.HRAREQ_S = String.Format("{0:HH:mm:ss}", dtpHoraReg.Value)

        Entidad.FCHATN = CDec(String.Format("{0:yyyyMMdd}", dtpFechaAten.Value))
        Entidad.FCHATN_D = String.Format("{0:d/M/yyyy}", dtpFechaAten.Value)
        Entidad.HRAATN = CDec(String.Format("{0:HHmmss}", dtpHoraAten.Value))
        Entidad.HRAATN_D = String.Format("{0:HH:mm:ss}", dtpHoraAten.Value)

        Entidad.QPSOMR = CDec(Val(txtPeso.Text))
        'Entidad.QMTLRG = CDec(Val(txtLargo.Text))
        'Entidad.QMTALT = CDec(Val(txtAlto.Text))
        'Entidad.QMTANC = CDec(Val(txtAncho.Text))
        Entidad.REFDO1 = txtDocRef.Text.ToString.Trim
        Entidad.TOBS = txtObservaciones.Text.ToString.Trim

        Entidad.CLCLOR = txtLugarOrigen.Tag
        Entidad.CLCLOR_S = txtLugarOrigen.Text
        Entidad.CLCLDS = txtLugarDestino.Tag
        Entidad.CLCLDS_S = txtLugarDestino.Text

        Entidad.TDRCOR = txtDireccionOrigen.Text.ToString.Trim
        Entidad.TDRENT = txtDireccionDestino.Text.ToString.Trim

        Entidad.CMEDTR = txtMedioTransp.Tag
        Entidad.QSLCIT = Val(txtCantidadSolicitada.Text)
        'Entidad.PNCDTR = _PNCDTR_Operacion
        Entidad.PNCDTR = ("" & txtOSAgencia.Tag).ToString.Trim

        ' txtOSAgencia.Tag 

        Entidad.CUSCRT = MainModule.USUARIO
        Entidad.NTRMCR = Environment.MachineName

        Entidad.NUMREQT = CDec(Val(txtNroReq.Text))
        Entidad.CULUSA = MainModule.USUARIO
        Entidad.NTRMNL = Environment.MachineName

        Entidad.TOBERV = txtDescripcionMercaderia.Text.Trim
        Entidad.PRSCNT = txtContacto.Text

        Entidad.TIRALC = txtResponsable.Text.Trim

        Return Entidad
    End Function

    Private Num_RequerimientoEnvio As Decimal = 0D

    'Private Sub Enviar_Requerimiento_Servicio()
    '    Try
    '        Dim Entidad As New RequerimientoServicio
    '        Control.CheckForIllegalCrossThreadCalls = False
    '        Dim Envio As New RequerimientoServicioEnvio_BLL
    '        Envio.CULUSA = MainModule.USUARIO
    '        Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
    '        Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")
    '        Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
    '        Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
    '        Envio.Mailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
    '        ' Entidad.NUMREQT = Num_RequerimientoEnvio
    '        If Envio.EnviarEmail_RequerimientoServicio(Num_RequerimientoEnvio, cmbCompania.CCMPN_CodigoCompania) = 1 Then
    '            'OK
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '    Try
    '        Dim TabSelect As String = TabRequerimiento.SelectedTab.Name
    '        Dim Num_Requerimiento As Decimal = 0
    '        Select Case TabSelect
    '            Case "TabDatosRequerimiento"
    '                Select Case gEnumOpc
    '                    Case EnumMan.Nuevo

    '                        If Validar() Then Exit Sub
    '                        Dim Entidad As New RequerimientoServicio
    '                        Dim Negocio As New RequerimientoServicio_BLL
    '                        Entidad = AsignarEntRequerimiento()
    '                        Num_Requerimiento = Negocio.intInsertarRequerimientoServicio(Entidad)

    '                        If MessageBox.Show("Requerimiento ingresado con Código:  " & Num_Requerimiento & Environment.NewLine & "¿Desea agregar dimensiones a la mercadería?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

    '                            Dim ObjFrm As New frmDimensiones

    '                            ObjFrm.pCCMPN = cmbCompania.CCMPN_CodigoCompania
    '                            ObjFrm.pNUMREQT = Num_Requerimiento
    '                            ObjFrm.ShowDialog()

    '                            dgvDatos_SelectionChanged(Nothing, Nothing)

    '                        End If

    '                        'If Entidad.SPRSTR = "U" Then
    '                        Num_RequerimientoEnvio = Num_Requerimiento
    '                        oHebraReqServ = New Thread(AddressOf Enviar_Requerimiento_Servicio)
    '                        oHebraReqServ.Start()
    '                        'End If

    '                        gEnumOpc = EnumMan.Neutro
    '                        HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
    '                        Estado_Controles(False)
    '                        Buscar(Nothing, Nothing)

    '                    Case EnumMan.Editar

    '                        If Validar() Then Exit Sub
    '                        Dim Entidad As New RequerimientoServicio
    '                        Dim Negocio As New RequerimientoServicio_BLL
    '                        Entidad = AsignarEntRequerimiento()
    '                        Negocio.intActualizarRequerimientoServicio(Entidad)
    '                        gEnumOpc = EnumMan.Neutro
    '                        HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
    '                        Estado_Controles(False)
    '                        MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        Buscar(Nothing, Nothing)


    '                End Select
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    'Private Sub Modificar_Requerimiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    '    Try

    '        If dgvDatos.CurrentRow Is Nothing Then Exit Sub


    '        Dim TabSelect As String = TabRequerimiento.SelectedTab.Name

    '        Select Case TabSelect
    '            Case "TabDatosRequerimiento"

    '                If dgvDatosSolicitud.Rows.Count > 0 Then
    '                    MessageBox.Show("No se puede modificar, existen solicitudes asignadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Exit Sub
    '                End If

    '                gEnumOpc = EnumMan.Editar
    '                HabilitarOpcion(EnumMan.Editar, TabRequerimiento.SelectedTab.Name)

    '                UcCliente_TxtF011.Enabled = False
    '                cmbMercaderia.Enabled = True
    '                cmbPrioridad.Enabled = True
    '                cboMedioTransporte.Enabled = True
    '                txtCantidadSolicitada.Enabled = True
    '                txtPeso.Enabled = True
    '                'txtLargo.Enabled = True
    '                'txtAncho.Enabled = True
    '                'txtAlto.Enabled = True
    '                txtDireccionOrigen.Enabled = True
    '                txtDireccionDestino.Enabled = True
    '                txtDocRef.Enabled = True
    '                txtObservaciones.Enabled = True
    '                btnBuscaOrdenServicio.Enabled = True
    '                btnAsignarOSAgencias.Enabled = True

    '                dtpFechaReg.Enabled = True
    '                dtpHoraReg.Enabled = True
    '                dtpFechaAten.Enabled = True
    '                dtpHoraAten.Enabled = True

    '                txtDescripcionMercaderia.Enabled = True
    '                txtContacto.Enabled = True

    '                'chkReparto.Enabled = True
    '                'chkTraslado.Enabled = True
    '        End Select

    '        'If btnModificar.Text = "Guardar" Then

    '        '    If Validar() Then Exit Sub

    '        '    Dim Entidad As New RequerimientoServicio
    '        '    Dim Negocio As New RequerimientoServicio_BLL

    '        '    With Entidad
    '        '        .CCMPN = cmbCompania.CCMPN_CodigoCompania
    '        '        .CDVSN = cmbDivision.Division
    '        '        .CPLNDV = cmbPlanta.Planta
    '        '        .CCLNT = UcCliente_TxtF011.pCodigo
    '        '        .CCLNT_S = UcCliente_TxtF011.pRazonSocial

    '        '        .NORSRT = Val(txtOS.Text)
    '        '        .NDCORM = Val(txtOSAgencia.Text)

    '        '        .SESREQ = "P"
    '        '        .SPRSTR = cmbPrioridad.SelectedValue
    '        '        .SPRSTR_S = cmbPrioridad.Text.ToString.Trim
    '        '        .TIPOCNT = cmbMercaderia.SelectedValue
    '        '        .TIPOCNT_S = cmbMercaderia.Text.ToString.Trim

    '        '        If chkReparto.Checked = True Then
    '        '            .TIPSRV = "R"
    '        '            .TIPSRV_S = "Reparto"
    '        '        Else
    '        '            .TIPSRV = "T"
    '        '            .TIPSRV_S = "Traslado"
    '        '        End If

    '        '        .FRGTRO = CDec(String.Format("{0:yyyyMd}", dtpFechaReg.Value))
    '        '        .FRGTRO_S = String.Format("{0:d/M/yyyy}", dtpFechaReg.Value)
    '        '        .HRGTRO = CDec(String.Format("{0:HHmmss}", dtpHoraReg.Value))
    '        '        .HRGTRO_S = String.Format("{0:HH:mm:ss}", dtpHoraReg.Value)

    '        '        .FECREQ = CDec(String.Format("{0:yyyyMd}", dtpFechaAten.Value))
    '        '        .FECREQ_S = String.Format("{0:d/M/yyyy}", dtpFechaAten.Value)
    '        '        .HRAREQ = CDec(String.Format("{0:HHmmss}", dtpHoraAten.Value))
    '        '        .HRAREQ_S = String.Format("{0:HH:mm:ss}", dtpHoraAten.Value)

    '        '        .QPSOMR = CDec(Val(txtPeso.Text))
    '        '        .QMTLRG = CDec(Val(txtLargo.Text))
    '        '        .QMTALT = CDec(Val(txtAlto.Text))
    '        '        .QMTANC = CDec(Val(txtAncho.Text))
    '        '        .REFDO1 = txtDocRef.Text.ToString.Trim
    '        '        .TOBS = txtObservaciones.Text.ToString.Trim

    '        '        .CLCLOR = txtLugarOrigen.Tag
    '        '        .CLCLOR_S = txtLugarOrigen.Text
    '        '        .CLCLDS = txtLugarDestino.Tag
    '        '        .CLCLDS_S = txtLugarDestino.Text

    '        '        .TDRCOR = txtDireccionOrigen.Text.ToString.Trim
    '        '        .TDRENT = txtDireccionDestino.Text.ToString.Trim

    '        '        .CMEDTR = cboMedioTransporte.SelectedValue
    '        '        .QSLCIT = txtCantidadSolicitada.Text
    '        '        .PNCDTR = _PNCDTR_Operacion

    '        '    End With

    '        '    Dim Num_Requerimiento As Integer = 0

    '        '    If Val(txtNroReq.Text) > 0 Then

    '        '        Entidad.NUMREQT = CDec(Val(txtNroReq.Text))
    '        '        Entidad.CULUSA = MainModule.USUARIO
    '        '        Entidad.NTRMNL = Environment.MachineName

    '        '        Negocio.intActualizarRequerimientoServicio(Entidad)
    '        '        MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


    '        '    Else

    '        '        Entidad.CUSCRT = MainModule.USUARIO
    '        '        Entidad.NTRMCR = Environment.MachineName

    '        '        Num_Requerimiento = Negocio.intInsertarRequerimientoServicio(Entidad)
    '        '        MessageBox.Show("Requerimiento ingresado" & Environment.NewLine & " Código: " & Num_Requerimiento, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        '        If Entidad.SPRSTR = "U" Then

    '        '            Dim Envio As New RequerimientoServicioEnvio_BLL

    '        '            Envio.CULUSA = MainModule.USUARIO
    '        '            Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
    '        '            Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")

    '        '            Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
    '        '            Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")

    '        '            Entidad.NUMREQT = Num_Requerimiento

    '        '            If Envio.EnviarEmail_RequerimientoServicio(Entidad) = 1 Then
    '        '                'OK
    '        '            End If

    '        '        End If

    '        '    End If

    '        '    Buscar(Nothing, Nothing)
    '        '    btnModificar.Text = "Modificar"
    '        '    Estado = MANTENIMIENTO.Neutro
    '        '    Habilitar_Controles(Estado)
    '        '    Habilitar_Botones(Estado)

    '        'Else
    '        '    If dgvDatos.CurrentRow Is Nothing Then
    '        '        Exit Sub
    '        '    End If

    '        '    btnModificar.Text = "Guardar"
    '        '    Estado = MANTENIMIENTO.MODIFICAR
    '        '    Habilitar_Controles(Estado)
    '        '    Habilitar_Botones(Estado)
    '        'End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    ''Me.AccionCancelar()
    '    Try
    'Dim tabSelect As String = TabSolicitudFlete.SelectedTab.Name
    '        gEnumOpc = EnumMan.Neutro
    '        HabilitarOpcion(EnumMan.Neutro, tabSelect)
    '        Limpiar_Controles()
    '        Estado_Controles(False)
    '        Cargar_Datos_Solicitud()
    '        Cargar_Unidades_Asignadas_Solicitud()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    Private Sub Cancelar_Requerimiento(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim tabSelect As String = TabRequerimiento.SelectedTab.Name
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, tabSelect)
            Limpiar_Controles()
            dgvPreAsignacion.DataSource = Nothing
            dgvDatosSolicitud.DataSource = Nothing
            '    Estado_Controles(False)
            ' Estado = Mantenimiento.Neutro
            'Habilitar_Controles(Estado)
            'Habilitar_Botones(False)
            Estado_Controles(False)
            CargarDatosRequerimiento()
            ''Listar_Unidades_Programadas()

            ''Listar_Solicitudes()
            '  btnModificar.Text = "Modificar"
            ' Cargar_Informacion(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosRequerimiento()
        Limpiar_Controles()
        If dgvDatos.CurrentRow Is Nothing Then Exit Sub
        Dim Entidad As New AtencionRequerimiento
        txtCliente.Text = dgvDatos.CurrentRow.Cells("CCLNT_S").Value
        txtCliente.Tag = dgvDatos.CurrentRow.Cells("CCLNT").Value
        'UcCliente_TxtF011.pCargar(CLng(dgvDatos.CurrentRow.Cells("CCLNT").Value))
        txtNroReq.Text = dgvDatos.CurrentRow.Cells("NUMREQT").Value
        txtPrioridad.Text = dgvDatos.CurrentRow.Cells("SPRSTR_S").Value
        txtPrioridad.Tag = dgvDatos.CurrentRow.Cells("SPRSTR").Value
        txtTipoMerc.Text = dgvDatos.CurrentRow.Cells("TIPOCNT_S").Value
        txtTipoMerc.Tag = dgvDatos.CurrentRow.Cells("TIPOCNT").Value

        dtpFechaReg.Value = Date.Parse(dgvDatos.CurrentRow.Cells("FECREQ").Value.ToString.Trim)
        dtpHoraReg.Value = Date.Parse(dgvDatos.CurrentRow.Cells("HRAREQ").Value.ToString.Trim)

        dtpFechaAten.Value = Date.Parse(dgvDatos.CurrentRow.Cells("FCHATN").Value.ToString.Trim)
        dtpHoraAten.Value = Date.Parse(dgvDatos.CurrentRow.Cells("HRAATN").Value)

        txtPeso.Text = Val(dgvDatos.CurrentRow.Cells("QPSOMR").Value)
        'txtLargo.Text = Val(dgvDatos.CurrentRow.Cells("QMTLRG").Value)
        'txtAlto.Text = Val(dgvDatos.CurrentRow.Cells("QMTALT").Value)
        'txtAncho.Text = Val(dgvDatos.CurrentRow.Cells("QMTANC").Value)
        txtDireccionOrigen.Text = dgvDatos.CurrentRow.Cells("TDRCOR").Value.ToString.Trim
        txtDireccionDestino.Text = dgvDatos.CurrentRow.Cells("TDRENT").Value.ToString.Trim
        txtOS.Text = dgvDatos.CurrentRow.Cells("NORSRT").Value
        txtOSAgencia.Text = dgvDatos.CurrentRow.Cells("NDCORM").Value
        txtOSAgencia.Tag = dgvDatos.CurrentRow.Cells("PNCDTR").Value
        'If dgvDatos.CurrentRow.Cells("TIPSRV").Value.ToString.Trim = "R" Then
        '    chkReparto.Checked = True
        'Else
        '    chkTraslado.Checked = True
        'End If
        txtDocRef.Text = dgvDatos.CurrentRow.Cells("REFDO1").Value
        txtObservaciones.Text = dgvDatos.CurrentRow.Cells("TOBS").Value
        txtMedioTransp.Text = dgvDatos.CurrentRow.Cells("CMEDTR").Value.ToString.Trim
        txtMedioTransp.Tag = IIf(dgvDatos.CurrentRow.Cells("CMEDTR").Value = 0D, 0D, dgvDatos.CurrentRow.Cells("CMEDTR").Value)
        txtCantidadSolicitada.Text = Val(dgvDatos.CurrentRow.Cells("QSLCIT").Value)
        If dgvDatos.CurrentRow.Cells("CLCLOR").Value > 0 Then
            txtLugarOrigen.Text = dgvDatos.CurrentRow.Cells("CLCLOR").Value & " -> " & dgvDatos.CurrentRow.Cells("CLCLOR_S").Value
            txtLugarOrigen.Tag = dgvDatos.CurrentRow.Cells("CLCLOR").Value
        Else
            txtLugarOrigen.Text = ""
            txtLugarOrigen.Tag = 0D
        End If
        If dgvDatos.CurrentRow.Cells("CLCLDS").Value > 0 Then
            txtLugarDestino.Text = dgvDatos.CurrentRow.Cells("CLCLDS").Value & " -> " & dgvDatos.CurrentRow.Cells("CLCLDS_S").Value
            txtLugarDestino.Tag = dgvDatos.CurrentRow.Cells("CLCLDS").Value
        Else
            txtLugarDestino.Text = ""
            txtLugarDestino.Tag = 0D
        End If

        txtUbigeoOrigen.Text = dgvDatos.CurrentRow.Cells("CUBORI_S").Value.ToString.Trim
        txtUbigeoDestino.Text = dgvDatos.CurrentRow.Cells("CUBDES_S").Value.ToString.Trim
        txtTipoUnidad.Text = dgvDatos.CurrentRow.Cells("CUNDVH_D").Value.ToString.Trim
        'txtMercaderia.Text = dgvDatos.CurrentRow.Cells("CMRCDR_D").Value.ToString.Trim

        txtDescripcionMercaderia.Text = dgvDatos.CurrentRow.Cells("TOBERV").Value.ToString.Trim
        txtContacto.Text = dgvDatos.CurrentRow.Cells("PRSCNT").Value.ToString.Trim

        txtResponsable.Text = dgvDatos.CurrentRow.Cells("TIRALC").Value.ToString.Trim
        ''ucResponsable_CambioDeTexto(txtResponsable.Text)

        'Dim objOrdenServicio As New NEGOCIO.Operaciones.OrdenServicio_BLL

        'Dim Lista As New List(Of ENTIDADES.Operaciones.OrdenServicioTransporte)
        'Dim objParametros As New List(Of String)
        'objParametros.Add(dgvDatos.CurrentRow.Cells("NORSRT").Value)
        'objParametros.Add(CLng(dgvDatos.CurrentRow.Cells("CCLNT").Value))
        'objParametros.Add(dgvDatos.CurrentRow.Cells("CCMPN").Value)
        'objParametros.Add(dgvDatos.CurrentRow.Cells("CDVSN").Value)
        'objParametros.Add(dgvDatos.CurrentRow.Cells("CPLNDV").Value)
        'Lista = objOrdenServicio.Listar_Ordenes_Servicio(objParametros)
        'For Each Registro As ENTIDADES.Operaciones.OrdenServicioTransporte In Lista
        '    If Registro.PNTORG = dgvDatos.CurrentRow.Cells("CLCLOR").Value And Registro.PNTDES = dgvDatos.CurrentRow.Cells("CLCLDS").Value Then
        '        txtUbigeoOrigen.Text = IIf(Registro.CUBORI = 0, "", Registro.CUBORI & " -> " & Registro.UBIGEO_O)
        '        txtUbigeoDestino.Text = IIf(Registro.CUBDES = 0, "", Registro.CUBDES & " -> " & Registro.UBIGEO_O)
        '        txtTipoUnidad.Text = Registro.CTPUNV
        '        txtMercaderia.Text = Registro.CMRCDR
        '    End If
        'Next

        Entidad.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
        Entidad.NCSOTR = dgvDatos.CurrentRow.Cells("NORSRT").Value
        Entidad.CCLNT = dgvDatos.CurrentRow.Cells("CCLNT").Value
        Entidad.CMEDTR = IIf(dgvDatos.CurrentRow.Cells("CMEDTR").Value = 0D, 0D, dgvDatos.CurrentRow.Cells("CMEDTR").Value)
        Entidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
        Entidad.CDVSN = dgvDatos.CurrentRow.Cells("CDVSN").Value
        Entidad.CPLNDV = dgvDatos.CurrentRow.Cells("CPLNDV").Value
        Entidad.CUSCRT = dgvDatos.CurrentRow.Cells("CUSCRT").Value
        Entidad.SPRSTR = dgvDatos.CurrentRow.Cells("SPRSTR").Value

        ' Lista Dimensiones

        'Dim ObjDimensiones As New Dimensiones
        'Dim objDimensiones_BLL As New Dimensiones_BLL


        'With ObjDimensiones
        '    .NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
        '    .CCMPN = cmbCompania.CCMPN_CodigoCompania
        'End With

        ''dgvDimensiones.DataSource = objDimensiones_BLL.fListar_Dimensiones(ObjDimensiones)

    End Sub

    Private Sub dgvDatos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellContentDoubleClick
        If (dgvDatos.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim Columna As String = dgvDatos.Columns(e.ColumnIndex).Name
        Try
            If Columna = "IMG_NMRGIM" AndAlso dgvDatos.CurrentRow.Cells("NMRGIM").Value > 0 Then
                Dim CCLNT As Decimal = dgvDatos.CurrentRow.Cells("CCLNT").Value
                Dim CCMPN As String = dgvDatos.CurrentRow.Cells("CCMPN").Value
                Dim NMRGIM As Decimal = dgvDatos.CurrentRow.Cells("NMRGIM").Value
                Dim TABLE_NAME As String = "RZST48"
                Dim USER_NAME As String = ""
                'Dim ofrmAdjuntarDocumentos As New Ransa.Controls.Transporte.frmAdjuntarDocumentos(NMRGIM, Nothing, CCLNT, TABLE_NAME, CCMPN, USER_NAME, Ransa.Controls.Transporte.frmAdjuntarDocumentos.EnumAdjunto.Requerimiento)
                'ofrmAdjuntarDocumentos.TipoModo = Ransa.Controls.Transporte.frmAdjuntarDocumentos.EnumModo.Neutro
                'ofrmAdjuntarDocumentos.ShowDialog()
            Else If Columna = "IMG_ENVIO" Then
                Dim beSegEnvioReq As New Ransa.Controls.Transporte.SegEnvioRequerimiento
                beSegEnvioReq.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                beSegEnvioReq.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                Dim ofrmListaNotificacion As New Ransa.Controls.Transporte.frmListaNotificacion(beSegEnvioReq)
                ofrmListaNotificacion.ShowDialog()
            ElseIf Columna = "IMG_UNPROG" AndAlso dgvDatos.CurrentRow.Cells("SJTTR").Value = "X" Then
                Dim ofrmVerUnidadesProgramadas As New frmVerUnidadesProgramadasXReq
                ofrmVerUnidadesProgramadas.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                ofrmVerUnidadesProgramadas.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                ofrmVerUnidadesProgramadas.ShowDialog()
            ElseIf Columna = "IMG_SOL" AndAlso dgvDatos.CurrentRow.Cells("SOLICT").Value > 0 Then
                Dim ofrmVerSolicitudes As New frmVerSolicitudes
                Dim Entidad As New Solicitud_Transporte
                Entidad.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                Entidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                ofrmVerSolicitudes.Entidad = Entidad
                ofrmVerSolicitudes.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dgvDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
    '    Try

    '        Dim NameColumna As String = ""
    '        If e.RowIndex <= -1 Then
    '            Exit Sub
    '        End If
    '        NameColumna = dgvDatos.Columns(dgvDatos.CurrentCell.ColumnIndex).Name
    '        If NameColumna = "IMAGEN_DIM" Then
    '            If Val(dgvDatos.Item("DIMENSIONES", e.RowIndex).Value) > 0 Then

    '                Dim ObjFrm As New frmDimensiones

    '                ObjFrm.pSoloVisualizar = True
    '                ObjFrm.pCCMPN = dgvDatos.Item("CCMPN", e.RowIndex).Value
    '                ObjFrm.pNUMREQT = dgvDatos.Item("NUMREQT", e.RowIndex).Value
    '                ObjFrm.ShowDialog()

    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub dgvDatos_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvDatos.DataBindingComplete
    '    Try
    '        For Each Item As DataGridViewRow In dgvDatos.Rows
    '            If (Item.Cells("DIMENSIONES").Value > 0) Then
    '                Item.Cells("IMAGEN_DIM").Value = My.Resources.text_block
    '            Else
    '                Item.Cells("IMAGEN_DIM").Value = My.Resources.CuadradoBlanco
    '            End If
    '        Next

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub dgvDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDatos.SelectionChanged
        Try
            If dgvDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
            Estado_Controles(False)
            'HabilitarOpcionxEstadoRequerimiento()
            Limpiar_Controles()
            dgvPreAsignacion.DataSource = Nothing
            dgvDatosSolicitud.DataSource = Nothing
            ''dgvDimensiones.DataSource = Nothing
            CargarDatosRequerimiento()

            ' Lista Dimensiones
            ''--------------------------------------------------------------------------------------------
            Dim ObjDimensiones As New Dimensiones
            Dim objDimensiones_BLL As New Dimensiones_BLL


            With ObjDimensiones
                .NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                .CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
            End With

            dgvDimension.DataSource = objDimensiones_BLL.fListar_Dimensiones(ObjDimensiones)
            ''--------------------------------------------------------------------------------------------

            'Listar_Unidades_Programadas()
            'Listar_Solicitudes()
            Listar_Unidades_Solicitadas()
            ' TabRequerimiento_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub Listar_Unidades_Programadas()
    '    dgvPreAsignacion.DataSource = Nothing
    '    If dgvDatos.CurrentRow IsNot Nothing Then
    '        Dim Negocio As New Programacion_Unid_Junta_BLL
    '        ' dgvPreAsignacion.AutoGenerateColumns = False
    '        Dim numRequerimiento As Decimal = dgvDatos.CurrentRow.Cells("NUMREQT").Value
    '        Dim ccmpnReq As String = dgvDatos.CurrentRow.Cells("CCMPN").Value
    '        dgvPreAsignacion.DataSource = Negocio.Lista_Unidades_Programadas(ccmpnReq, numRequerimiento, "T")
    '    End If
    'End Sub


    'Private Sub Listar_Solicitudes()
    '    dgvDatosSolicitud.DataSource = Nothing
    '    If dgvDatos.CurrentRow IsNot Nothing Then
    '        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
    '        Dim numRequerimiento As Decimal = dgvDatos.CurrentRow.Cells("NUMREQT").Value
    '        Dim objSolicitud As New Solicitud_Transporte
    '        objSolicitud.NUMREQT = numRequerimiento
    '        dgvDatosSolicitud.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Estado_Requerimiento(objSolicitud)
    '    End If
    'End Sub

    Private Sub Listar_Unidades_Solicitadas()
        dtgRecursosAsignados.DataSource = Nothing
        If dgvDatos.CurrentRow IsNot Nothing Then
            Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
            dtgRecursosAsignados.AutoGenerateColumns = False
            Dim objEntidad As New ClaseGeneral

            objEntidad.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
            objEntidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
            dtgRecursosAsignados.DataSource = objAtencionRequerimiento.Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(objEntidad)

        End If
    End Sub
    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim objFormBuscarOrdenServicio As New frmBuscarOrdenServicio
            With objFormBuscarOrdenServicio
                .CodigoCliente = txtCliente.Tag ''UcCliente_TxtF011.pCodigo
                .CCMPN = cmbCompania.CCMPN_CodigoCompania
                .CDVSN = cmbDivision.Division
                .WindowState = FormWindowState.Maximized
            End With

            objFormBuscarOrdenServicio.ShowDialog()


            If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE IsNot Nothing Then

                txtOS.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT

                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR.ToString.Trim = "0" Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR.ToString.Trim = "" Then
                    txtLugarOrigen.Text = ""
                    txtLugarOrigen.Tag = 0
                Else
                    txtLugarOrigen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTORG
                    txtLugarOrigen.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR

                End If

                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS.ToString.Trim = "0" Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS.ToString.Trim = "" Then
                    txtLugarDestino.Text = ""
                    txtLugarDestino.Tag = 0
                Else
                    txtLugarDestino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.PNTDES
                    txtLugarDestino.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS
                End If

                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI = 0 Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI.ToString.Trim = "" Then
                    txtUbigeoOrigen.Text = ""
                Else
                    txtUbigeoOrigen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBORI & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_O
                End If

                If objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES = 0 Or objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES.ToString.Trim = "" Then
                    txtUbigeoDestino.Text = ""
                Else
                    txtUbigeoDestino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUBDES & " -> " & objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.UBIGEO_D
                End If

                txtTipoUnidad.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPUNV
                'txtMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsignarOSAgencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim objfrmOSAgenciasRansa As New frmOperacionAgenciasRansaPopup
            objfrmOSAgenciasRansa.Codigo_Cliente = txtClienteFiltro.pCodigo
            objfrmOSAgenciasRansa.ShowDialog(Me)
            Me.txtOSAgencia.Text = objfrmOSAgenciasRansa.OrdenServio_AgenciasRansa
            txtOSAgencia.Tag = objfrmOSAgenciasRansa.Operacion_Agencias
            '_PNCDTR_Operacion = objfrmOSAgenciasRansa.Operacion_Agencias
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Atender(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderReq.Click

        Try
            ''Dim objFrm As New frmAtenderRequerimiento
            Dim objFrm As New frmSolicitudTransporteReqto()
            Dim Prioridad As String = ""
            Dim objAteReq As New AtencionRequerimiento
            If dgvDatos.CurrentRow IsNot Nothing Then
                Dim objAtencionReqBLL As New AtencionRequerimiento_BLL
                objAteReq.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                objAteReq.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                Dim Entidad As New AtencionRequerimiento
                Dim olstSolTrnsp As New List(Of ENTIDADES.Operaciones.Solicitud_Transporte)
                olstSolTrnsp = objAtencionReqBLL.Verificar_Estado_Requerimiento(objAteReq)
                If olstSolTrnsp.Count > 0 Then
                    If olstSolTrnsp.Item(0).ESTADO_REQ = "*" Then
                        MessageBox.Show("El Requerimiento no se puede atender. El Req. está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                Dim dt As New DataTable
                dt = objAtencionReqBLL.Obtener_Datos_OrdenServicio_Requerimiento(objAteReq)

                With Entidad

                    .NUMREQT = dt.Rows(0)("NUMREQT").ToString.Trim '' dgvDatos.CurrentRow.Cells("NUMREQT").Value
                    .CCMPN = dt.Rows(0)("CCMPN").ToString.Trim '''dgvDatos.CurrentRow.Cells("CCMPN").Value
                    .CDVSN = dt.Rows(0)("CDVSN").ToString.Trim ''dgvDatos.CurrentRow.Cells("CDVSN").Value
                    .CPLNDV = dt.Rows(0)("CPLNDV").ToString.Trim ''dgvDatos.CurrentRow.Cells("CPLNDV").Value
                    .CCLNT = dt.Rows(0)("CCLNT").ToString.Trim ''dgvDatos.CurrentRow.Cells("CCLNT").Value
                    '.CCLNT_S = dgvDatos.CurrentRow.Cells("CCLNT_S").Value

                    .NORSRT = dt.Rows(0)("NORSRT").ToString.Trim ''dgvDatos.CurrentRow.Cells("NORSRT").Value
                    .NDCORM = dt.Rows(0)("NDCORM").ToString.Trim ''dgvDatos.CurrentRow.Cells("NDCORM").Value
                    .PNCDTR = dt.Rows(0)("PNCDTR").ToString.Trim ''dgvDatos.CurrentRow.Cells("PNCDTR").Value
                    ''.SESREQ = "P"
                    '.SPRSTR = ("" & dgvDatos.CurrentRow.Cells("SPRSTR").Value).ToString.Trim
                    'If Prioridad = "C" Then
                    '    Prioridad = "U"
                    'End If
                    .SPRSTR = dt.Rows(0)("SPRSTR").ToString.Trim ''Prioridad
                    '.SPRSTR_S = dgvDatos.CurrentRow.Cells("SPRSTR_S").Value
                    ''.TIPOCNT = dgvDatos.CurrentRow.Cells("TIPOCNT").Value
                    '.TIPOCNT_S = dgvDatos.CurrentRow.Cells("TIPOCNT_S").Value

                    ''.TIPSRV = dt.Rows(0)("TIPSRV").ToString.Trim ''dgvDatos.CurrentRow.Cells("TIPSRV").Value
                    '.TIPSRV_S = dgvDatos.CurrentRow.Cells("TIPSRV_S").Value

                    '.FECREQ = CDec(String.Format("{0:yyyyMMdd}", CDate(dgvDatos.CurrentRow.Cells("FECREQ_S").Value)))
                    '.FECREQ_S = dgvDatos.CurrentRow.Cells("FECREQ_S").Value.ToString.Trim

                    '.HRAREQ = CDec(String.Format("{0:HHmmss}", CDate(dgvDatos.CurrentRow.Cells("HRAREQ_S").Value)))
                    '.HRAREQ_S = dgvDatos.CurrentRow.Cells("HRAREQ_S").Value.ToString.Trim

                    '.FCHATN = CDec(String.Format("{0:yyyyMMdd}", CDate(dgvDatos.CurrentRow.Cells("FCHATN_D").Value)))
                    '.FCHATN_D = dgvDatos.CurrentRow.Cells("FCHATN_D").Value

                    '.HRAATN = CDec(String.Format("{0:HHmmss}", CDate(dgvDatos.CurrentRow.Cells("HRAATN_D").Value)))
                    '.HRAATN_D = dgvDatos.CurrentRow.Cells("HRAATN_D").Value

                    '.QPSOMR = dgvDatos.CurrentRow.Cells("QPSOMR").Value
                    ''.QMTLRG = dgvDatos.CurrentRow.Cells("QMTLRG").Value
                    ''.QMTALT = dgvDatos.CurrentRow.Cells("QMTALT").Value
                    ''.QMTANC = dgvDatos.CurrentRow.Cells("QMTANC").Value
                    .REFDO1 = dt.Rows(0)("REFDO1").ToString.Trim ''dgvDatos.CurrentRow.Cells("REFDO1").Value
                    '.TOBS = dt.Rows(0)("TOBS").ToString.Trim ''dgvDatos.CurrentRow.Cells("TOBS").Value

                    .CLCLOR = dt.Rows(0)("CLCLOR").ToString.Trim ''dgvDatos.CurrentRow.Cells("CLCLOR").Value
                    .CLCLOR_S = dt.Rows(0)("CLCLOR_S").ToString.Trim ''dgvDatos.CurrentRow.Cells("CLCLOR_S").Value
                    .CLCLDS = dt.Rows(0)("CLCLDS").ToString.Trim ''dgvDatos.CurrentRow.Cells("CLCLDS").Value
                    .CLCLDS_S = dt.Rows(0)("CLCLDS_S").ToString.Trim ''dgvDatos.CurrentRow.Cells("CLCLDS_S").Value

                    .TDRCOR = dt.Rows(0)("TDRCOR").ToString.Trim ''dgvDatos.CurrentRow.Cells("TDRCOR").Value.ToString.Trim
                    .TDRENT = dt.Rows(0)("TDRENT").ToString.Trim ''dgvDatos.CurrentRow.Cells("TDRENT").Value.ToString.Trim

                    .CMEDTR = dt.Rows(0)("CMEDTR").ToString.Trim ''dgvDatos.CurrentRow.Cells("CMEDTR").Value
                    .QSLCIT = dt.Rows(0)("QSLCIT").ToString.Trim ''dgvDatos.CurrentRow.Cells("QSLCIT").Value

                    .CMRCDR = dt.Rows(0)("CMRCDR").ToString.Trim ''dgvDatos.CurrentRow.Cells("CMRCDR").Value
                    .CTPOSR = dt.Rows(0)("CTPOSR").ToString.Trim ''dgvDatos.CurrentRow.Cells("CTPOSR").Value.ToString.Trim
                    '.CUNDVH = dt.Rows(0)("CUNDVH").ToString.Trim 'dgvDatos.CurrentRow.Cells("CUNDVH_D").Value
                    '.CUNDVH_D = dt.Rows(0)("CUNDVH_D").ToString.Trim
                    .CUNDMD = dt.Rows(0)("CUNDMD").ToString.Trim ''dgvDatos.CurrentRow.Cells("CUNDMD").Value.ToString.Trim
                    .QMRCDR = dt.Rows(0)("QMRCDR").ToString.Trim ''dgvDatos.CurrentRow.Cells("QMRCDR_2").Value

                    '.SESREQ = dt.Rows(0)("SESREQ").ToString.Trim ''dgvDatos.CurrentRow.Cells("SESREQ").Value.ToString.Trim
                    .CUBORI = dt.Rows(0)("CUBORI").ToString.Trim
                    .CUBORI_S = dt.Rows(0)("CUBORI_S").ToString.Trim
                    .CUBDES = dt.Rows(0)("CUBDES").ToString.Trim
                    .CUBDES_S = dt.Rows(0)("CUBDES_S").ToString.Trim
                End With

                objFrm.pEsRequerimiento = True
                objFrm.pRequerimientoServicio = Entidad
                'objFrm.MdiParent = Me.Parent.Parent
                'objFrm.WindowState = FormWindowState.Maximized

                ''objFrm.pUsuario = MainModule.USUARIO

                objFrm.ShowDialog()

                'If objFrm.myDialogResult = True Then
                '    Buscar(Nothing, Nothing)
                'End If

                'If objFrm.Respuesta = "SI" Then
                '    Buscar(Nothing, Nothing)
                'End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    'Private Sub TabRequerimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRequerimiento.SelectedIndexChanged
    '    Try
    '        If TabSelect <> TabRequerimiento.SelectedTab.Name Then
    '            If (gEnumOpc = Mantenimiento.Modificar Or gEnumOpc = Mantenimiento.Nuevo) Then
    '                TabRequerimiento.SelectTab(TabSelect)
    '                MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Sub
    '            ElseIf gEnumOpc = Mantenimiento.Neutro Then
    '                gEnumOpc = Mantenimiento.Neutro
    '                'HabilitarOpcion(Mantenimiento.Neutro, TabSolicitudFlete.SelectedTab.Name)
    '                '  HabilitarOpcionxEstadoSolicitud()
    '            End If
    '        End If
    '        TabSeleccionado = TabSolicitudFlete.SelectedTab.Name
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    'Private Sub HabilitarOpcionxEstadoRequerimiento()
    '    'Dim Estado_Actual_Eliminar As Boolean = Me.btnEliminar.Enabled
    '    Dim TabSelect As String = TabRequerimiento.SelectedTab.Name
    '    Dim EstadoReq As String = ""
    '    If dgvDatos.Rows.Count > 0 Then
    '        EstadoReq = ("" & dgvDatos.CurrentRow.Cells("SESREQ").Value).ToString.Trim
    '    End If
    '    Select Case EstadoReq
    '        'Case "P"
    '        '    Select Case TabSelect
    '        '        Case "TabDatosRequerimiento"
    '        '            btnModificar.Enabled = False
    '        '            btnGuardar.Visible = False
    '        '            btnEliminar.Enabled = False
    '        '            btnNuevo.Enabled = False
    '        '    End Select
    '        'Case "A"
    '        '    Select Case TabSelect
    '        '        Case "TabDatosRequerimiento"

    '        '            btnModificar.Enabled = False
    '        '            btnEliminar.Enabled = False
    '        '            btnNuevo.Enabled = False
    '        '            btnAtender.Enabled = False
    '        '            btnCancelar.Enabled = False

    '        '    End Select
    '        Case "C"
    '            Select Case TabSelect
    '                Case "TabDatosRequerimiento"
    '                    btnModificar.Enabled = False
    '                    btnCerrarReq.Enabled = False
    '                    btnEliminar.Enabled = False
    '                    btnAtender.Enabled = False
    '            End Select
    '        Case "A"
    '            Select Case TabSelect
    '                Case "TabDatosRequerimiento"
    '                    btnModificar.Enabled = False
    '                    btnCerrarReq.Enabled = True
    '                    btnEliminar.Enabled = False
    '                    btnAtender.Enabled = True
    '            End Select
    '    End Select

    'End Sub

    'Private Sub TabRequerimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRequerimiento.SelectedIndexChanged
    '    Try
    '        If TabSeleccionado <> TabRequerimiento.SelectedTab.Name Then
    '            If (gEnumOpc = EnumMan.Editar Or gEnumOpc = EnumMan.Nuevo) Then
    '                TabRequerimiento.SelectTab(TabSeleccionado)
    '                MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Sub
    '            ElseIf gEnumOpc = EnumMan.Neutro Then
    '                gEnumOpc = EnumMan.Neutro
    '                HabilitarOpcion(EnumMan.Neutro, TabRequerimiento.SelectedTab.Name)
    '                'HabilitarOpcionxEstadoRequerimiento()
    '            End If
    '        End If
    '        TabSeleccionado = TabRequerimiento.SelectedTab.Name
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



    'Private Sub TabRequerimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRequerimiento.SelectedIndexChanged

    '    Try

    '        If dgvDatos.CurrentRow IsNot Nothing Then

    '            Select Case dgvDatos.CurrentRow.Cells("SESREQ").Value.ToString.Trim

    '                Case "P"

    '                    Select Case TabRequerimiento.SelectedTab.Name

    '                        Case "TabDatosRequerimiento"
    '                            If Estado = Mantenimiento.Modificar Or Estado = Mantenimiento.Nuevo Then
    '                                Exit Select
    '                            End If
    '                            Habilitar_Botones(Estado)
    '                            Habilitar_Controles(Estado)
    '                            'Habilitar_Botones(Mantenimiento.Neutro)

    '                        Case Else

    '                            If Estado = Mantenimiento.Modificar Or Estado = Mantenimiento.Nuevo Then
    '                                MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                TabRequerimiento.SelectTab("TabDatosRequerimiento")
    '                                Exit Select
    '                            End If
    '                            btnModificar.Enabled = False
    '                            btnEliminar.Enabled = False
    '                            btnNuevo.Enabled = False

    '                    End Select

    '                Case "A"

    '                    Select Case TabRequerimiento.SelectedTab.Name

    '                        Case "TabDatosRequerimiento"
    '                            If Estado = Mantenimiento.Modificar Or Estado = Mantenimiento.Nuevo Then
    '                                Exit Select
    '                            End If
    '                            Habilitar_Botones_A(Estado)
    '                            Habilitar_Controles(Estado)
    '                            'Habilitar_Botones(Mantenimiento.Neutro)
    '                            btnEliminar.Enabled = False

    '                        Case Else

    '                            If Estado = Mantenimiento.Modificar Or Estado = Mantenimiento.Nuevo Then
    '                                MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                                TabRequerimiento.SelectTab("TabDatosRequerimiento")
    '                                Exit Select
    '                            End If
    '                            btnModificar.Enabled = False
    '                            btnEliminar.Enabled = False
    '                            btnNuevo.Enabled = False

    '                    End Select


    '                Case "C"

    '                    btnModificar.Enabled = False
    '                    btnEliminar.Enabled = False
    '                    btnNuevo.Enabled = False
    '                    btnAtender.Enabled = False
    '                    btnCancelar.Enabled = False

    '            End Select

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dgvDatosSolicitud_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatosSolicitud.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If dgvDatosSolicitud.Columns(e.ColumnIndex).Name = "IMAGEN" Then
                Dim ObjFrm As New frmVerUnidadesAsignadas
                Dim Entidad As New AtencionRequerimiento
                Entidad.NCSOTR = dgvDatosSolicitud.CurrentRow.Cells("NCSOTR").Value
                Entidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
                ObjFrm.Entidad = Entidad
                ObjFrm.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDatosSolicitud_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvDatosSolicitud.DataBindingComplete
        Try
            For Each Item As DataGridViewRow In dgvDatosSolicitud.Rows
                If (Item.Cells("UNIDADES").Value > 0) Then
                    Item.Cells("IMAGEN").Value = My.Resources.text_block
                Else
                    Item.Cells("IMAGEN").Value = My.Resources.EnBlanco
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkFechaAtencion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaAtencion.CheckedChanged
        Try
            dtpFechaAten.Enabled = chkFechaAtencion.Checked
            dtpFechaFinAtencion.Enabled = chkFechaAtencion.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNumReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumReq.CheckedChanged
        Try

            dtpFechaInicioReq.Enabled = Not chkNumReq.Checked
            dtpFechaFinReq.Enabled = Not chkNumReq.Checked
            txtNroReqFiltro.Enabled = chkNumReq.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkSolicitud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSolicitud.CheckedChanged
        Try

            txtSolicitudFiltro.Enabled = chkSolicitud.Checked

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Ver_Medidas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDimensiones.Click
    '    Try

    '        If dgvDatos.Rows.Count = 0 Then
    '            Exit Sub
    '        End If

    '        If Val(txtNroReq.Text) = 0 Then
    '            MessageBox.Show("Debe registrar el requerimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        If dgvDatosSolicitud.Rows.Count > 0 Then
    '            MessageBox.Show("No se pueden agregar medidas, existen solicitudes asignadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        Dim ObjFrm As New frmDimensiones

    '        ObjFrm.pCCMPN = cmbCompania.CCMPN_CodigoCompania
    '        ObjFrm.pNUMREQT = Val(txtNroReq.Text)

    '        ObjFrm.ShowDialog()
    '        dgvDatos_SelectionChanged(Nothing, Nothing)


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub chkFechaRequerimiento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFechaRequerimiento.CheckedChanged
        Try
            dtpFechaInicioReq.Enabled = chkFechaRequerimiento.Checked
            dtpFechaFinReq.Enabled = chkFechaRequerimiento.Checked
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ucResponsable_CambioDeTexto(ByVal objData As Object)

        'If ucResponsable.Resultado IsNot Nothing Then
        '    txtResponsable.Text = CType(ucResponsable.Resultado, beDestinatario).PSTNMYAP
        '    txtEmail.Text = CType(ucResponsable.Resultado, beDestinatario).PSEMAILTO
        'End If
    End Sub

    Private Sub txtResponsable_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtResponsable.TextChanged

        'txtEmail.Text = ""

    End Sub

    Private Sub txtNroReqFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroReqFiltro.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Ver_UnidadesProgramadas(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        'Dim ObjFrm As New frmVerUnidadesProgramadas
    '        'ObjFrm.CCMPN=
    '        ' ObjFrm.NCSOTR=
    '        'ObjFrm.Show()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub txtSolicitudFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolicitudFiltro.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub

    Private Sub dgvDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        If (dgvDatos.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim Columna As String = dgvDatos.Columns(e.ColumnIndex).Name
        Try
            If Columna = "QUNIDJUNTA" Then
                Dim ofrmVerUnidadesProgramadas As New frmVerUnidadesProgramadasXReq
                ofrmVerUnidadesProgramadas.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                ofrmVerUnidadesProgramadas.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                ofrmVerUnidadesProgramadas.ShowDialog()
            ElseIf Columna = "QUNIDSOLICITADAS" Then
                Dim ofrmVerSolicitudes As New frmVerSolicitudes
                Dim Entidad As New Solicitud_Transporte
                Entidad.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
                Entidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
                ofrmVerSolicitudes.Entidad = Entidad
                ofrmVerSolicitudes.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarOS.Click

        If dgvDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
        Dim Respuesta As New List(Of AtencionRequerimiento)
        Dim numRequerimiento As Decimal = dgvDatos.CurrentRow.Cells("NUMREQT").Value
        Dim objAtencionReq As New AtencionRequerimiento

        objAtencionReq.NUMREQT = numRequerimiento
        objAtencionReq.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Respuesta = objAtencionRequerimiento.Listar_Estado_Solicitud_Requerimiento(objAtencionReq)
        If Respuesta.Count > 0 Then
            If Respuesta.Item(0).SESREQ = "A" Or Respuesta.Item(0).SESREQ = "C" Or Respuesta.Item(0).SJTTR = "X" Then
                MessageBox.Show("No se puede modificar. El Requerimiento está en Atención, Cerrado y/o en Junta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Dim ofrmModificarOrdenServicio As New frmModificarOrdenServicio
        Dim objEntidad As New AtencionRequerimiento
        objEntidad.CCLNT = dgvDatos.CurrentRow.Cells("CCLNT").Value
        objEntidad.NUMREQT = dgvDatos.CurrentRow.Cells("NUMREQT").Value
        objEntidad.CCMPN = dgvDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad.CDVSN = dgvDatos.CurrentRow.Cells("CDVSN").Value
        objEntidad.QSLCIT = Val(dgvDatos.CurrentRow.Cells("QSLCIT").Value)

        objEntidad.NORSRT = dgvDatos.CurrentRow.Cells("NORSRT").Value
        objEntidad.NDCORM = dgvDatos.CurrentRow.Cells("NDCORM").Value 'txtOSAgencia.text
        objEntidad.PNCDTR = dgvDatos.CurrentRow.Cells("PNCDTR").Value 'txtOSAgencia.Tag

        If dgvDatos.CurrentRow.Cells("CLCLOR").Value > 0 Then
            objEntidad.CLCLOR_S = dgvDatos.CurrentRow.Cells("CLCLOR_S").Value 'dgvDatos.CurrentRow.Cells("CLCLOR").Value & " -> " & 
            objEntidad.CLCLOR = dgvDatos.CurrentRow.Cells("CLCLOR").Value
        Else
            objEntidad.CLCLOR_S = "" 'txtLugarOrigen.Text = ""
            objEntidad.CLCLOR = 0D
        End If
        If dgvDatos.CurrentRow.Cells("CLCLDS").Value > 0 Then
            objEntidad.CLCLDS_S = dgvDatos.CurrentRow.Cells("CLCLDS_S").Value 'dgvDatos.CurrentRow.Cells("CLCLDS").Value & " -> " & 
            objEntidad.CLCLDS = dgvDatos.CurrentRow.Cells("CLCLDS").Value
        Else
            objEntidad.CLCLDS_S = "" 'txtLugarDestino.Text = ""
            objEntidad.CLCLDS = 0D 'txtLugarDestino.Tag = 0D
        End If

        objEntidad.CUBORI_S = dgvDatos.CurrentRow.Cells("CUBORI_S").Value.ToString.Trim
        objEntidad.CUBDES_S = dgvDatos.CurrentRow.Cells("CUBDES_S").Value.ToString.Trim

        ofrmModificarOrdenServicio.objEntidad = objEntidad
        If ofrmModificarOrdenServicio.ShowDialog = Windows.Forms.DialogResult.OK Then
            Listar_Atencion_Requerimiento()
        End If

    End Sub

    Private Sub btnExportarGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarGeneral.Click
        Try

            'If dgvDatos.Rows.Count = 0 Then
            '    Exit Sub
            'End If
            Dim Mensaje As String = ""
            If Lista_Negocios.ToString.Trim = "" Then
                Mensaje = Mensaje & "Seleccione un Negocio"
            End If

            If Mensaje.ToString.Trim.Length > 0 Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If


            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NUMREQT").Caption = NPOI_SC.FormatDato("Nro. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORSRT").Caption = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLOR_S").Caption = NPOI_SC.FormatDato("Lugar Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDS_S").Caption = NPOI_SC.FormatDato("Lugar Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCLNT_S").Caption = NPOI_SC.FormatDato("Cliente", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCLNFC_S").Caption = NPOI_SC.FormatDato("Cliente (Facturación)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIPOCNT_S").Caption = NPOI_SC.FormatDato("Tipo Mercadería", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FECREQ").Caption = NPOI_SC.FormatDato("Fecha Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAREQ").Caption = NPOI_SC.FormatDato("Hora Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("FCHATN").Caption = NPOI_SC.FormatDato("Fecha para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAATN").Caption = NPOI_SC.FormatDato("Hora para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("SPRSTR_S").Caption = NPOI_SC.FormatDato("Prioridad", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QSLCIT").Caption = NPOI_SC.FormatDato("Cant. Vehículos", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDJUNTA").Caption = NPOI_SC.FormatDato("Unid. Programadas (Junta)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QUNIDSOLICITADAS").Caption = NPOI_SC.FormatDato("Unid. Solicitadas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QATNAN").Caption = NPOI_SC.FormatDato("Unid. Atendidas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio Transporte", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBERV").Caption = NPOI_SC.FormatDato("Descripción Mercadería", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("REFDO1").Caption = NPOI_SC.FormatDato("Doc. Referencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QPSOMR").Caption = NPOI_SC.FormatDato("Peso total (kg)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TDRCOR").Caption = NPOI_SC.FormatDato("Dirección Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDRENT").Caption = NPOI_SC.FormatDato("Dirección Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIRALC").Caption = NPOI_SC.FormatDato("Responsable", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PRSCNT").Caption = NPOI_SC.FormatDato("Contacto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SESREQ_S").Caption = NPOI_SC.FormatDato("Estado Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("NORSRT_SREQ").Caption = NPOI_SC.FormatDato("O/S (Sol. Req.)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLOR_SREQ").Caption = NPOI_SC.FormatDato("Lugar Origen (Sol. Req.)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDS_SREQ").Caption = NPOI_SC.FormatDato("Lugar Destino (Sol. Req.)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NDCORMSR_SREQ").Caption = NPOI_SC.FormatDato("O/S Agencia (Sol. Req).", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CUSOSAR").Caption = NPOI_SC.FormatDato("Usuario Actualizador O/S.", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("CUSCRT").Caption = NPOI_SC.FormatDato("Usuario Creador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CULUSA").Caption = NPOI_SC.FormatDato("Usuario Actualizador", NPOI_SC.keyDatoTexto)


            Dim columna As String = ""
            Dim odtAteReq As New DataTable
            Dim Negocio As New AtencionRequerimiento_BLL

            odtAteReq = Negocio.Lista_Atencion_Requerimiento(Obtener_Filtro)
            CopiarDatosTo(odtAteReq, dtExcel)


            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "REQUERIMIENTO_SERVICIO"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("LISTA DE REQUERIMIENTOS DE SERVICIO")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cmbDivision.DivisionDescripcion)
            F.Add(2, "Planta:| " & cmbPlanta.DescripcionPlanta)


            oLisFiltro.Add(F)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CopiarDatosTo(ByVal dtOrigen As DataTable, ByRef dtDestino As DataTable) As DataTable
        dtDestino.Rows.Clear()
        Dim NameColumna As String = ""
        Dim dr As DataRow
        For Fila As Integer = 0 To dtOrigen.Rows.Count - 1
            dr = dtDestino.NewRow
            For Columna As Integer = 0 To dtDestino.Columns.Count - 1
                NameColumna = dtDestino.Columns(Columna).ColumnName
                If dtOrigen.Columns(NameColumna) IsNot Nothing Then
                    dr(NameColumna) = dtOrigen.Rows(Fila)(NameColumna)
                End If
            Next
            dtDestino.Rows.Add(dr)
        Next
        Return dtDestino.Copy
    End Function

    Private Sub btnExportarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarDetalle.Click
        Try

            'If dgvDatos.Rows.Count = 0 Then
            '    Exit Sub
            'End If
            Dim Mensaje As String = ""
            If Lista_Negocios.ToString.Trim = "" Then
                Mensaje = Mensaje & "Seleccione un Negocio"
            End If

            If Mensaje.ToString.Trim.Length > 0 Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If


            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NUMREQT").Caption = NPOI_SC.FormatDato("Requerimiento | Nro. Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORSRT_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Orden de Servicio", NPOI_SC.keyDatoTexto)

            ''dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Requerimiento | Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLOR_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Lugar Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDS_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Lugar Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCLNT_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Cliente", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("CCLNFC_S").Caption = NPOI_SC.FormatDato("Requerimiento | Cliente (Facturación)", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIPOCNT_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Tipo Mercadería", NPOI_SC.keyDatoTexto)

            ''dtExcel.Columns.Add("NORSRT_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | O/S (Sol. Req.)", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("CLCLOR_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Lugar Origen (Sol. Req.)", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("CLCLDS_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Lugar Destino (Sol. Req.)", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("NDCORMSR_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | O/S Agencia (Sol. Req).", NPOI_SC.keyDatoTexto)


            dtExcel.Columns.Add("FECREQ_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Fecha Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAREQ_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Hora Req.", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("FCHATN_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Fecha para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HRAATN_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Hora para Atención", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("SPRSTR_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Prioridad", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("QSLCIT").Caption = NPOI_SC.FormatDato("Requerimiento | Cant. Vehículos", NPOI_SC.keyDatoNumero)
            'dtExcel.Columns.Add("QUNIDJUNTA").Caption = NPOI_SC.FormatDato("Requerimiento | Unid. Programadas (Junta)", NPOI_SC.keyDatoNumero)
            'dtExcel.Columns.Add("QUNIDSOLICITADAS").Caption = NPOI_SC.FormatDato("Requerimiento | Unid. Solicitadas", NPOI_SC.keyDatoNumero)
            'dtExcel.Columns.Add("QATNAN").Caption = NPOI_SC.FormatDato("Requerimiento | Unid. Atendidas", NPOI_SC.keyDatoNumero)
            ''dtExcel.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Requerimiento | Medio Transporte", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBERV_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Descripción Mercadería", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("REFDO1_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Doc. Referencia", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QPSOMR_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Peso total (kg)", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TDRCOR_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Dirección Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TDRENT_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Dirección Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TIRALC_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Responsable", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PRSCNT_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Contacto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SESREQ_SREQ").Caption = NPOI_SC.FormatDato("Requerimiento | Estado Req.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TOBS_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Observaciones", NPOI_SC.keyDatoTexto)


            dtExcel.Columns.Add("CUSCRT_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Usuario Creador", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CULUSA_REQ").Caption = NPOI_SC.FormatDato("Requerimiento | Usuario Actualizador", NPOI_SC.keyDatoTexto)
            '***********************************************solicitud*******************************************'
            dtExcel.Columns.Add("NCSOTR_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Nro. Solicitud", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("FECOST_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Fecha Solicitud", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("NORSRT_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Orden de Servicio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLOR_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Lugar Origen", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CLCLDS_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Lugar Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CUSOSAR").Caption = NPOI_SC.FormatDato("Solicitud | Usuario Actualizador O/S.", NPOI_SC.keyDatoTexto)


            dtExcel.Columns.Add("QANPRG_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Unidades Programadas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QSLCIT_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Unidades Solicitadas", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("QATNAN_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Unidades Atendidas", NPOI_SC.keyDatoNumero)
            ''dtExcel.Columns.Add("UBIGEO_O").Caption = NPOI_SC.FormatDato("Solicitud | Ubigeo Origen", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("UBIGEO_D").Caption = NPOI_SC.FormatDato("Solicitud | Ubigeo Destino", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SESSLC_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Estado Sol.", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("SESTRG_SOL").Caption = NPOI_SC.FormatDato("Solicitud | Estado de Registro", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("TRFRN").Caption = NPOI_SC.FormatDato("Solicitud | Usuario Solicitante", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("FULTAC").Caption = NPOI_SC.FormatDato("Solicitud | Última Actualización", NPOI_SC.keyDatoTexto)
            '***************************************unidades asignadas**********************************'
            ''dtExcel.Columns.Add("NCSOTR2").Caption = NPOI_SC.FormatDato("Unidades Asignadas | N° Solicitud", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NGUITR").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Guía Trans.", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NOPRCN").Caption = NPOI_SC.FormatDato("Unidades Asignadas | N° Operación", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("NORINSS").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Orden Interna", NPOI_SC.keyDatoTexto)
            ''dtExcel.Columns.Add("NPLNMT").Caption = NPOI_SC.FormatDato("Unidades Asignadas | N° Planeamiento", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TCMTRT").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Transportista", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NPLCUN").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Tracto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NPLCAC").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Acoplado", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CBRCNT").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Conductor N°1", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CBRCND").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Nombre", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CBRCN2").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Conductor N° 2", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FASGTR").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Fecha Asignación", NPOI_SC.keyDatoFecha)
            dtExcel.Columns.Add("HASGTR").Caption = NPOI_SC.FormatDato("Unidades Asignadas | Hora Asignación", NPOI_SC.keyDatoTexto)

            Dim columna As String = ""
            Dim odtAteReq As New DataTable
            Dim Negocio As New AtencionRequerimiento_BLL

            odtAteReq = Negocio.Lista_Atencion_Requerimiento_Detalle_Exportar(Obtener_Filtro)
            CopiarDatosTo(odtAteReq, dtExcel)


            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "REQUERIMIENTO_SERVICIO"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("LISTA DE REQUERIMIENTOS DE SERVICIO")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cmbDivision.DivisionDescripcion)
            F.Add(2, "Planta:| " & cmbPlanta.DescripcionPlanta)


            oLisFiltro.Add(F)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabRequerimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabRequerimiento.SelectedIndexChanged
        Try
            Dim tabSel As String = TabRequerimiento.SelectedTab.Name
            Select Case tabSel
                Case "TabDatosRequerimiento"
                    btnModificarOS.Enabled = True
                Case "TabDimensiones"
                    btnModificarOS.Enabled = False
                Case "TabUnidadesSolicitadas"
                    btnModificarOS.Enabled = False
                    'TabDimensiones
                    'TabUnidadesProg
                    'TabSolicitud
                    'TabUnidadesSolicitadas
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
