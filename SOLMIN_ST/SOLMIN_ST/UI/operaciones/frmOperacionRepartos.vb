Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOperacionRepartos

#Region "Atributos"
    Private oSeguridad As Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private bolBuscar As Boolean = False
    Private Codigo As String = ""
    Private RucTransportista As String = ""

    Private controlInformacion As New Control_InformacionSolicitud


    Public Objeto_Entidad_Guia_1 As New GuiaTransportista
    Private pCTRMNC As Int32 = 0
    Private pNGUIRM As Int64 = 0
    Private pNRGUCL As Int64 = 0
    Private pFCGUCL As Date
    Private pLSTGRE As String = ""
    Private pCCMPN As String = ""

    Private _CTPOVJ As String = "R"
    Private pFechaAtencionServicio As Int32 = 0
#End Region

#Region "Properties"

 

#End Region

#Region "Eventos"

    Enum AccionServicio
        Neutral
        Nuevo
        Modificar
    End Enum
    Private oAccionServicio As AccionServicio = AccionServicio.Neutral
    Private Sub frmOperacionRepartos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            habilitarBoton(gEnum_Mantenimiento)
          
            Me.Button1.Enabled = False

            Me.gwdDatos.AutoGenerateColumns = False
            Me.gwdSolicitud.AutoGenerateColumns = False
            Me.gwGuiaTransporte.AutoGenerateColumns = False
            Me.Estado_Controles(False)
            gintEstado = 0
            Me.ddlEstado.SelectedIndex = 1
            Me.Cargar_Compania()

            Me.txtClienteFiltro.pUsuario = USUARIO
            Me.txtClienteFiltro.CCMPN = Me.cmbCompania.SelectedValue
            Me.txtClienteMnto.pUsuario = USUARIO
            Me.txtClienteMnto.CCMPN = Me.cmbCompania.SelectedValue
            Me.Validar_Acceso_Opciones_Usuario()
            Me.PanelInformacionSolicitud.Controls.Add(controlInformacion)
            Me.controlInformacion.Dock = DockStyle.Fill
            Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
            Me.txttracto.Tag = ""

            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'Me.cargarComboPlanta()
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub habilitarBoton(op As MANTENIMIENTO)
        Dim tabselect As String = tbReparto.SelectedTab.Name
        Select Case tabselect
            Case "tbMantenimiento"



                Select Case op
                    Case MANTENIMIENTO.NEUTRAL
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnCancelar.Visible = False
                        btnEliminar.Enabled = True
                        btnAsignarSolicitud.Enabled = False
                        btnReimprimir.Enabled = True
                        btnGuiaTransporte.Enabled = False


                    Case MANTENIMIENTO.NUEVO

                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnCancelar.Visible = True
                        btnEliminar.Enabled = True
                        btnAsignarSolicitud.Enabled = False
                        btnReimprimir.Enabled = False
                        btnGuiaTransporte.Enabled = False

                    Case MANTENIMIENTO.EDITAR


                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnCancelar.Visible = True
                        btnEliminar.Enabled = True
                        btnAsignarSolicitud.Enabled = False
                        btnReimprimir.Enabled = False
                        btnGuiaTransporte.Enabled = False

                End Select

            Case "tbServicio"

                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnEliminar.Enabled = True
                btnAsignarSolicitud.Enabled = True
                btnReimprimir.Enabled = True
                btnGuiaTransporte.Enabled = True

            Case "tbGuiasAsignadas"


                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnEliminar.Enabled = True
                btnAsignarSolicitud.Enabled = False
                btnReimprimir.Enabled = True
                btnGuiaTransporte.Enabled = False

        End Select

     
    End Sub


    Private Sub tbReparto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbReparto.SelectedIndexChanged


        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        habilitarBoton(gEnum_Mantenimiento)

        
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
    '    Try
    '        If bolBuscar = True Then
    '            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '            'Cargar_Planta()
    '            cargarComboPlanta()
    '            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    '''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    'Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
    '    If bolBuscar = True Then
    'Dim objFiltro As New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
    '' Seteamos los valores que hasta ese momento se ha ingresado 
    '        objFiltro.pCCLNT_Cliente = ""
    '        objFiltro.pTCMPCL_DescripcionCliente = ""
    '        objFiltro.pNRUC_NroRUC = ""
    '        objFiltro.pUsuario = USUARIO
    '        objFiltro.pNROPAG_NroPagina = 0
    '        objFiltro.pREGPAG_NroRegPorPagina = 0
    '        objFiltro.pCCMPN_CodigoCompania = objFiltro.pCCMPN_CodigoCompania
    'Call pCargarInformacion()
    '        Me.txtClienteFiltro.CCMPN = Me.cmbCompania.SelectedValue
    '        Me.txtClienteFiltro.pCargar(0)
    '        Me.Listar()
    '    End If
    'End Sub
    '''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    End Sub

    Private Sub txtNroOpReparto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOpReparto.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
 

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.Listar()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            habilitarBoton(gEnum_Mantenimiento)
            Estado_Controles(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
 
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        habilitarBoton(gEnum_Mantenimiento)
        gwdDatos_SelectionChanged(gwdDatos, Nothing)
        Estado_Controles(False)

        
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Dim tabselect As String = tbReparto.SelectedTab.Name

            Select Case tabselect
                Case "tbMantenimiento"
                  
                    If validar_inputs() = True Then Exit Sub
                    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                        Me.Nuevo_Reparto()

                    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                        Me.Modificar_Reparto()
                       
                      
                    End If
                    'Case "tbServicio"
                    '    Me.Modificar_Solicitud()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try
            Dim tabselect As String = tbReparto.SelectedTab.Name
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Select Case tabselect
                 
                Case "tbMantenimiento"

                    If Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C" Then
                        HelpClass.MsgBox("No se puede eliminar Reparto Cerrado", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Me.gwdSolicitud.RowCount > 0 Then
                        HelpClass.MsgBox("No se puede eliminar Reparto con Servicio asignado", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If MsgBox("Desea eliminar el Reparto?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                    Me.Eliminar_Reparto("*")

                Case "tbServicio"
                    If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
                    If Me.Verificar_Existencia_Guia_x_Solicitud Then
                        HelpClass.MsgBox("No se puede eliminar.Tiene Guía de Transporte asignada.", MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    Me.Eliminar_Solicitud("*")

                Case "tbGuiasAsignadas"
                    If Me.gwGuiaTransporte.RowCount = 0 Then Exit Sub
                    If (Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
                        HelpClass.MsgBox("No se Permite Eliminar Guía de Transporte , Reparto Cerrada", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If MsgBox("Desea eliminar esta Guía de Remisión", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub

                    Me.Eliminar_GuiaTransportista()
            End Select

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

   

    

 

    

    Private Sub btnAsignarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarSolicitud.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If (Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
            HelpClass.MsgBox("No se Permite Asignar Solicitud ,  Reparto cerrado", MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Dim frmConductor As New frmConsultaConductor
            Dim strCBRCNT As String = ""
            With frmConductor
                .CCMPN = Me.cmbCompania.SelectedValue
                .CDVSN = Me.cmbDivision.SelectedValue
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                '.CPLNDV = Me.cmbPlanta.SelectedValue
                .CPLNDV = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                '.CTRSPT = Me.cboTransportista.pCodigoRNS
                .NRUCTR = Me.txtciatransportista.Tag
                .pRazonSocial = Me.txtciatransportista.Text
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                txttracto.Tag = .CBRCNT
                Me.pFechaAtencionServicio = HelpClass.CtypeDate(.dtpFechaAtencionServicio.Value)

            End With
            Me.panelReparto.Visible = False
            Me.PanelFiltros.Enabled = False
            Me.gwdDatos.Enabled = False
            Me.btnCancelarSolicitud.Text = " Cancelar"
            'Me._TipoOperacion = 2
            controlInformacion.CCMPN = Me.cmbCompania.SelectedValue
            controlInformacion.pCDVSN = Me.cmbDivision.SelectedValue

            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            controlInformacion.pCPLNDV = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value
            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            oAccionServicio = AccionServicio.Nuevo
            controlInformacion.TipoOperacion = 2 ' Me._TipoOperacion
            controlInformacion.OPCION = 0

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            controlInformacion.pCTPOVJ = Me._CTPOVJ
            controlInformacion.pNOPRCN = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value
            '----- Fin -----

            Me.Limpiar_Controles_Solicitud()
            Me.ActivarEstado_Solicitud(True)
            controlInformacion.txtCliente.pCargar(Me.gwdDatos.Item("C_CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value)

            If (txtClienteMnto.pCodigo = 0) Then
                Me.controlInformacion.txtCliente.Enabled = True
            Else
                Me.controlInformacion.txtCliente.Enabled = False
            End If
            Me.controlInformacion.txtCantidadSolicitada.Enabled = False
            Me.controlInformacion.txtCantidadSolicitada.Text = 1

            Me.panelSolicitudR.Visible = True




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub gwdSolicitud_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdSolicitud.CellContentDoubleClick

        Try
            If Me.gwdSolicitud.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            Select Case Me.gwdSolicitud.Columns(e.ColumnIndex).Name
                Case "D_DETASIG"
                    Dim frmAsignacionUnidades As New frmInformacionSolicitud(Me.gwdSolicitud.Item("D_NCSOTR", e.RowIndex).Value)
                    With frmAsignacionUnidades
                        .TipoOperacion = 3
                        .Cliente = Me.txtClienteMnto.pCodigo
                        .CCMPN = Me.cmbCompania.SelectedValue
                        .CDVSN = Me.cmbDivision.SelectedValue


                        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                        .CPLNDV = Me.gwdSolicitud.Item("D_CPLNDV", e.RowIndex).Value
                        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                        '.NRUCTR = Me.cboTransportista.pCodigoRNS
                        '.NPLCUN = Me.txttracto.Tag
                        .NPLCUN = Me.txttracto.Text
                        .NORSRT = Me.gwdSolicitud.Item("D_NORSRT", e.RowIndex).Value
                        .QSLCIT = Me.gwdSolicitud.Item("D_QSLCIT", e.RowIndex).Value
                        .LocalidadOrigen = Me.gwdSolicitud.Item("D_CLCLOR_C", e.RowIndex).Value
                        .LocalidadDestino = Me.gwdSolicitud.Item("D_CLCLDS_C", e.RowIndex).Value
                        .DireccionOrigen = Me.gwdSolicitud.Item("D_TDRCOR", e.RowIndex).Value
                        .DireccionDestino = Me.gwdSolicitud.Item("D_TDRENT", e.RowIndex).Value
                        .CantidadMercaderia = IIf(Me.gwdSolicitud.Item("D_QMRCDR", e.RowIndex).Value.ToString.Trim.Equals(""), 0, Me.gwdSolicitud.Item("D_QMRCDR", e.RowIndex).Value)
                        .UnidadMedida = Me.gwdSolicitud.Item("D_CUNDMD_C", e.RowIndex).Value
                        .FechaSolicitud = Me.gwdSolicitud.Item("D_FECOST", e.RowIndex).Value
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.Listar()
                        End If
                    End With
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimirReparto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirReparto.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ListaParametros As New List(Of String)
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            End If
            ListaParametros.Add(Me.txtNroOpReparto.Text.Trim())
            If txtClienteFiltro.pCodigo <> 0 Then
                ListaParametros.Add(txtClienteFiltro.pCodigo)
            Else
                ListaParametros.Add("")
            End If
            ListaParametros.Add(Asignar_Valor)
            ListaParametros.Add(lstr_FecIni)
            ListaParametros.Add(lstr_FecFin)
            ListaParametros.Add(Me.cmbCompania.SelectedValue)
            ListaParametros.Add(Me.cmbDivision.SelectedValue)


            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


            ListaParametros.Add(UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta)
            ' ListaParametros.Add(DevuelvePlantaSeleccionadas(cboPlanta))
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



            Imprimir2(ListaParametros)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancelarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarSolicitud.Click
        Me.panelSolicitudR.Visible = False
        Me.panelReparto.Visible = True
        Me.PanelFiltros.Enabled = True
        Me.gwdDatos.Enabled = True
        Me.txttracto.Tag = ""
    End Sub

    Private Sub btnGuardarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarSolicitud.Click

        Try


            'Select Case _TipoOperacion
            '    Case 0, 1
            '        If Not Me.Validar_Input_Solicitud Then
            '            Me.Modificar_Registro_Solicitud()
            '        End If
            '    Case 2, 4
            '        If Not Me.Validar_Input_Solicitud Then
            '            Me.Nuevo_Registro_Solicitud()
            '        End If
            '    End Select
            Select Case oAccionServicio
                'Case AccionServicio.Modificar
                '    If Not Me.Validar_Input_Solicitud Then
                '        Me.Modificar_Registro_Solicitud()
                '    End If
                Case AccionServicio.Nuevo
                    If Not Me.Validar_Input_Solicitud Then
                        Me.Nuevo_Registro_Solicitud()
                    End If
            End Select

            ' oAccionServicio = AccionServicio.Nuevo


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuiaTransporte.Click

        Try

            Dim lint_indice As Integer = Me.gwdSolicitud.CurrentCellAddress.Y
            If Me.gwdSolicitud.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
            If (Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
                HelpClass.MsgBox("No se Permite Asignar Guia de Transporte , Reparto cerrado", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.gwdSolicitud.Item("D_NOPRCN", lint_indice).Value <= 0 Then
                HelpClass.MsgBox("No se Permite Asignar Guia de Transporte , Solicitud no tiene Asignada una Operación", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.gwdSolicitud.CurrentRow.Cells("NGUITR").Value <> 0 Then
                MessageBox.Show("El servicio ya tiene Guía Transportes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.Lista_Proceso_Guia_Transporte(Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
    Private Sub gwGuiaTransporte_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwGuiaTransporte.CellClick

        Try

       
        If e.RowIndex < 0 Then Exit Sub
        If gwGuiaTransporte.RowCount <= 0 Then Exit Sub
        ' Verificaos que se haya dado clic en la columna de la Guía de Remisión
        Select Case gwGuiaTransporte.Columns(e.ColumnIndex).Name
            Case "NGUIRM"

                    'Dim oTemp As TD_Obj_InfGRemCargada = New TD_Obj_InfGRemCargada
                    'Dim objEntidad As New TD_GRemServCargadasGTranspLiqPK
                    'Dim objLogica As New GuiaTransportista_BLL
                    'Dim oTemp_1 As TD_Obj_InfGRemCargada = New TD_Obj_InfGRemCargada
                    'With oTemp
                    '        '.pCTRMNC_CodigoTransportista = Me.cboTransportista.pCodigoRNS
                    '    .pNGUIRM_NroGuiaTransportista = Me.gwGuiaTransporte.Item("NMNFCR", e.RowIndex).Value
                    '    .pNGUITR_GuiaRemisionCargada = Me.gwGuiaTransporte.Item("NGUIRM", e.RowIndex).Value
                    '    .pFGUITR_FechaGuiaRemision = Me.gwGuiaTransporte.Item("FGUIRM_S", e.RowIndex).Value.ToString.Trim.Substring(0, 10)
                    '    .pCCLNT1_CodigoCliente = Me.txtClienteMnto.pCodigo
                    '    .pCLCLOR_CodigoLocalidadOrigen = Me.gwGuiaTransporte.Item("CLCLOR", e.RowIndex).Value
                    '    .pTCMLCO_LocalidadOrigen = Me.gwGuiaTransporte.Item("TDIROR", e.RowIndex).Value
                    '    .pCLCLDS_CodigoLocalidadDestino = Me.gwGuiaTransporte.Item("CLCLDS", e.RowIndex).Value
                    '    .pTCMLCD_LocalidadDestino = Me.gwGuiaTransporte.Item("TDIRDS", e.RowIndex).Value
                    '    .pNOPRCN_NroOperacion = Me.gwGuiaTransporte.Item("NOPRCN_1", e.RowIndex).Value
                    '    .pNLQDCN_NroLiquidacion = 0
                    '        '.pCTRSPT_Transportista = Me.cboTransportista.pCodigoRNS
                    '        .pTCMTRT_RazSocialTransportista = Me.txtciatransportista.Text
                    '        '.pNPLVHT_Tracto = Me.txttracto.Tag
                    '        .pNPLVHT_Tracto = txttracto.Text.Trim                      
                    '    .pCBRCNT_Brevete = Me.gwGuiaTransporte.Item("CBRCNT", e.RowIndex).Value
                    '    .pCMRCDR_Mercaderia = Me.gwGuiaTransporte.Item("CMRCDR", e.RowIndex).Value
                    '    .pTAMRCD_DetalleMercaderia = Me.gwGuiaTransporte.Item("TCMRCD", e.RowIndex).Value

                    '    'Obteniendo Datos de la RZTR06
                    '    objEntidad.pNOPRCN_NroOperacion = Me.gwGuiaTransporte.Item("NOPRCN_1", e.RowIndex).Value
                    '    objEntidad.pCCMPN_Compania = Me.cmbCompania.SelectedValue
                    '    objEntidad.pNGUITR_NroGuiaRemision = Me.gwGuiaTransporte.Item("NGUIRM", e.RowIndex).Value
                    '    oTemp_1 = objLogica.Obtener_Guia_Remision(objEntidad)
                    '    .pRELGUI_RelacionGuiaHijas = oTemp_1.pRELGUI_RelacionGuiaHijas
                    '    .pFRCGRM_FechaRecepGuiaRemision = oTemp_1.pFGUITR_FechaGuiaRemision
                    '    .pQGLGSL_CantidadGlsGasolina = oTemp_1.pQGLGSL_CantidadGlsGasolina
                    '    .pQGLDSL_CantidadGlsDiesel = oTemp_1.pQGLDSL_CantidadGlsDiesel
                    '    .pNRHJCR_NroHojasCargui = oTemp_1.pNRHJCR_NroHojasCargui
                    '    .pCPRCN1_CodigoPropietarioContenedor1 = oTemp_1.pCPRCN1_CodigoPropietarioContenedor1
                    '    .pNSRCN1_SerieContenedor1 = oTemp_1.pNSRCN1_SerieContenedor1
                    '    .pCPRCN2_CodigoPropietarioContenedor2 = oTemp_1.pCPRCN2_CodigoPropietarioContenedor2
                    '    .pNSRCN2_SerieContenedor2 = oTemp_1.pNSRCN2_SerieContenedor2
                    '    .pFLLGCM_FechaLlegadaCamion = oTemp_1.pFLLGCM_FechaLlegadaCamion
                    '    .pFSLDCM_FechaSalidaCamion = oTemp_1.pFSLDCM_FechaSalidaCamion
                    '    .pQKLMRC_KilometrosRecorridos = oTemp_1.pQKLMRC_KilometrosRecorridos
                    '    .pQHRSRV_CantidadHorasServicio = oTemp_1.pQHRSRV_CantidadHorasServicio
                    '    .pQBLRMS_CantidadBultosRemision = oTemp_1.pQBLRMS_CantidadBultosRemision
                    '    .pPBRTOR_PesoBrutoRemision = oTemp_1.pPBRTOR_PesoBrutoRemision
                    '    .pPTRAOR_PesoTaraRemision = oTemp_1.pPTRAOR_PesoTaraRemision
                    '    .pQVLMOR_VolumenRemision = oTemp_1.pQVLMOR_VolumenRemision
                    '    .pQBLRCP_CantidadBultosRecepcion = oTemp_1.pQBLRCP_CantidadBultosRecepcion
                    '    .pPBRDST_PesoBrutoRecepcion = oTemp_1.pPBRDST_PesoBrutoRecepcion
                    '    .pPTRDST_PesoTaraRecepcion = oTemp_1.pPTRDST_PesoTaraRecepcion
                    '    .pQVLMDS_VolumenRecepcion = oTemp_1.pQVLMDS_VolumenRecepcion

                    'End With
                    'Dim fDlgLiqFlete As frmLiquidacionFlete_DlgCargarGuia = New frmLiquidacionFlete_DlgCargarGuia(oTemp)
                    Dim fDlgLiqFlete As frmLiquidacionFlete_DlgCargarGuia = New frmLiquidacionFlete_DlgCargarGuia()
                    'fDlgLiqFlete.TPOPRCN = 2
                    fDlgLiqFlete.pAccion = frmLiquidacionFlete_DlgCargarGuia.Accion.Modificar
                    fDlgLiqFlete.pCCMPN = Me.cmbCompania.SelectedValue
                    fDlgLiqFlete.pCDVSN = Me.cmbDivision.SelectedValue
                    fDlgLiqFlete.pNOPRCN = Me.gwGuiaTransporte.Item("NOPRCN_1", e.RowIndex).Value
                    fDlgLiqFlete.pNGUIAREM = Me.gwGuiaTransporte.Item("NGUIRM", e.RowIndex).Value
                    fDlgLiqFlete.PSStatusLiquidacion_SESGRP = gwGuiaTransporte.Item("SESGRP", e.RowIndex).Value
                    'fDlgLiqFlete.pSESGRP = Me.gwGuiaTransporte.Item("SESGRP", e.RowIndex).Value
                    'fDlgLiqFlete.pSGUIFC = Me.gwGuiaTransporte.Item("SGUIFC", e.RowIndex).Value
                If fDlgLiqFlete.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.Listar_Guias_Transportista_Reparto()

                End If
            'Case "NCRDCO"

            '    Dim frm As New frmTarifaInterna()
            '    frm.NroOperacion = gwGuiaTransporte.CurrentRow.Cells("NOPRCN").Value
            '    frm.NroGuiaTransporte = gwGuiaTransporte.CurrentRow.Cells("NGUIRM").Value
            '    frm.BotonVisibleSAP = False
            '    frm.ShowDialog()

            Case "NLQDCN"
                Dim ofrmLiquidacionesConsultaProveedor As New frmLiquidacionesConsultaProveedor
                ofrmLiquidacionesConsultaProveedor.pNOPRCN = Me.gwGuiaTransporte.CurrentRow.Cells("NOPRCN_1").Value
                ofrmLiquidacionesConsultaProveedor.pNGUIRM = Me.gwGuiaTransporte.CurrentRow.Cells("NGUIRM").Value
                ofrmLiquidacionesConsultaProveedor.pCCMPN = Me.cmbCompania.SelectedValue
                ofrmLiquidacionesConsultaProveedor.pCDVSN = Me.cmbDivision.SelectedValue


                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                ' ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.cmbPlanta.SelectedValue
                ofrmLiquidacionesConsultaProveedor.pCPLNDV = Me.gwGuiaTransporte.CurrentRow.Cells("CPLNDV").Value
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                ofrmLiquidacionesConsultaProveedor.ShowDialog()


        End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwGuiaTransporte.RowCount > 0 Then
            HelpClass.MsgBox("No se puede eliminar tiene Guía de Transporte asignada", MessageBoxIcon.Information)
            Exit Sub
        End If
        If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Me.Eliminar_Solicitud("*")
    End Sub

    'Private Sub btnLiquidacionR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If Me.gwGuiaTransporte.RowCount = 0 Then
    '        HelpClass.MsgBox("No Existe Guía Transporte Asignada para Liquidar", MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    If (Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
    '        HelpClass.MsgBox("Operación de Reparto Cerrado, Guías de Transportes Liquidadas", MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    If MessageBox.Show("¿Desea procesar la Liquidación para la Operación de Reparto N°" & _
    '       Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value & "?", "Liquidación:", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    End If

    '    For lintContador As Integer = 0 To Me.gwdSolicitud.RowCount - 1
    '        If Me.gwdSolicitud.Item("D_NORINS", lintContador).Value <= 0 Then
    '            HelpClass.MsgBox("Falta generar Orden Interna a la Operación:" & Me.gwdSolicitud.Item("D_NOPRCN", lintContador).Value, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '    Next

    '    Dim Objeto_Logica As New GuiaTransportista_BLL
    '    Dim bolEstado As Boolean = False
    '    Dim sErrorMesage As String = ""
    '    Dim oLiquidacionGT As Repartos = New Repartos
    '    Try
    '        'For intContador As Integer = 0 To Me.gwdSolicitud.RowCount - 1
    '        With oLiquidacionGT
    '            .NMOPRP = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value
    '            .FECREP = HelpClass.TodayNumeric
    '            .CUSCRT = MainModule.USUARIO
    '            .NTRMNL = HelpClass.NombreMaquina
    '            .CCMPN = Me.cmbCompania.SelectedValue
    '            .CDVSN = Me.cmbDivision.SelectedValue

    '            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '            ' .CPLNDV = Me.cmbPlanta.SelectedValue
    '            .CPLNDV = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value
    '            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    '        End With
    '        bolEstado = Objeto_Logica.Registrar_LiquidacionGuiaTransportista_Reparto(oLiquidacionGT, sErrorMesage)

    '        If (bolEstado = False) Then
    '            HelpClass.MsgBox("Ocurrió un Error al momento de Liquidar la Operación de Reparto", MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        Me.Modificar_Estado_Operacion_Reparto()
    '        HelpClass.MsgBox("Las Guías fueron Liquidadas Satisfactoriamente", MessageBoxIcon.Information)
    '        Me.Listar()
    '        'Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    Private Sub btnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguimiento.Click
        Try
            Dim vNPLCUN As String = ""
            Dim NCOREG As String = ""
            Dim NCSOTR As Decimal = 0
            Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
            If (Me.gwdSolicitud.Rows.Count <= 0) Then Exit Sub
            vNPLCUN = HelpClass.ObjectToString(Me.gwdSolicitud.CurrentRow.Cells("D_NPLCUN").Value)
            NCSOTR = HelpClass.ObjectToDecimal(Me.gwdSolicitud.CurrentRow.Cells("D_NCSOTR").Value)
            obeSeguimientoGPS.NPLCTR = vNPLCUN
            obeSeguimientoGPS.NCSOTR = NCSOTR
            obeSeguimientoGPS.CCMPN = Me.cmbCompania.SelectedValue
            obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.gwdSolicitud.CurrentRow.Cells("D_NCRRSR").Value)
            obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me.gwdSolicitud.CurrentRow.Cells("D_NGSGWP").Value)
            obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me.gwdSolicitud.CurrentRow.Cells("D_NCOREG").Value)
            Dim ofrmGPSWAP As New frmGPSWAP()
            ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
            ofrmGPSWAP.ShowDialog(Me)
            Me.Cargar_Detalle_Solicitud()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim lint_Indice As Integer = Me.gwdSolicitud.CurrentCellAddress.Y
    '    If Me.gwdSolicitud.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
    '    If Me.gwdSolicitud.Item("D_NOPRCN", lint_Indice).Value = 0 Then
    '        HelpClass.MsgBox("No tiene Operación Asignada", MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    Dim obj_Logica As GuiaTransportista_BLL = New GuiaTransportista_BLL
    '    Dim objPrintForm As New PrintForm
    '    Dim objDs As New DataSet
    '    Dim objDt As New DataTable
    '    Dim objetoRep As New rptConsistenciaLiquidacionReparto
    '    Dim objParametro As New Hashtable
    '    objParametro.Add("PSNOPRCN", Me.gwdSolicitud.Item("D_NOPRCN", lint_Indice).Value)
    '    objParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
    '    objParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
    '    objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Consistencia_Liquidacion_Servicio_Reparto(objParametro))
    '    objDt.TableName = "RZTR32"

    '    If objDt.Rows.Count = 0 Then
    '        HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    objDs.Tables.Add(objDt.Copy)
    '    objetoRep.SetDataSource(objDs)

    '    CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
    '    CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cmbCompania.Text
    '    CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cmbDivision.Text

    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '    '  CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cmbPlanta.Text
    '    CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.gwdSolicitud.Item("D_TPLNTA", lint_Indice).Value
    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    '    objPrintForm.ShowForm(objetoRep, Me)
    'End Sub

    Private Sub btnReimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReimprimir.Click

        Try

      
        Dim frmSustentoFactura As New frmOpcionSustentoFactura
        With frmSustentoFactura
            .CCMPN = Me.cmbCompania.SelectedValue
            .CDVSN = Me.cmbDivision.SelectedValue

            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            '.CPLNDV = Me.cmbPlanta.SelectedValue
            .CPLNDV = UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta


            'If NroElementosPlanta(cboPlanta) > 1 Or NroElementosPlanta(cboPlanta) = 0 Then
            '    MsgBox("Solo Debe Tener Seleccionada Solo Una Planta", MsgBoxStyle.Information, "SOLMIN")
            '    Exit Sub
            'Else
            '    .CPLNDV = DevuelvePlantaSeleccionadas(cboPlanta)
            'End If
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        End With
            frmSustentoFactura.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Métodos y Funciones"

 

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

 
        If objEntidad.STSOP2 = "" Then
            Me.btnReimprimir.Visible = False
            Me.btnReimprimir.Tag = 1

        End If
        If objEntidad.STSOP3 = "" Then
            Me.btnSeguimiento.Visible = False
            Me.btnSeguimiento.Tag = 1

        End If
    End Sub

    Private Sub Cargar_Compania()

        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        bolBuscar = True


        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cmbCompania_SelectedIndexChanged(Nothing, Nothing)
       
    End Sub

    Private Sub Cargar_Division()

        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
            objDivision.Crea_Lista()
            bolBuscar = False
            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.cmbDivision.SelectedValue = "T"
            If Me.cmbDivision.SelectedIndex = -1 Then
                Me.cmbDivision.SelectedIndex = 0
            End If

            cmbDivision_SelectionChangeCommitted(Nothing, Nothing)
        End If
       
    End Sub

    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    ' Private Sub Cargar_Planta()
    '     Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    '     Try
    'If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then

    '            bolBuscar = False
    '           objPlanta.Crea_Lista()
    '          objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
    '          cmbPlanta.DataSource = objLisEntidad
    '         cmbPlanta.ValueMember = "CPLNDV"
    '        cmbPlanta.DisplayMember = "TPLNTA"
    '       bolBuscar = True
    '      Me.cmbPlanta.SelectedIndex = 0
    '     cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
    'End If
    'Catch ex As Exception

    '        HelpClass.MsgBox(ex.Message)
    '       End Try
    'End Sub
    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtClienteMnto.Enabled = lbool_Estado
        Me.txtReferenciaCliente.Enabled = lbool_Estado
        Me.dtpFechaReparto.Enabled = lbool_Estado
     
        Me.Button1.Enabled = lbool_Estado
    End Sub

    Private Sub Limpiar_Controles()
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentCell = Nothing
        End If
        Me.txtClienteMnto.pClear()
        Me.dtpFechaReparto.Value = Date.Today
        Me.txtciatransportista.Text = ""
        Me.txtciatransportista.Tag = ""
        Me.txttracto.Text = ""
        Me.txtacoplado.Text = ""
        Me.txttracto.Tag = ""
        Me.txtReferenciaCliente.Clear()
    End Sub

    Private Function Asignar_Valor() As String
        Dim cadena As String = ""
        If Me.ddlEstado.SelectedIndex = 0 Then
            cadena = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Then
            cadena = "A"
        ElseIf Me.ddlEstado.SelectedIndex = 2 Then
            cadena = "C"
        End If
        Return cadena
    End Function

    Private Sub Listar()
        Dim objOperacionReparto As New Repartos_BLL
        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objParamList.Add(Me.txtNroOpReparto.Text)
        If txtClienteFiltro.pCodigo <> 0 Then
            objParamList.Add(txtClienteFiltro.pCodigo)
        Else
            objParamList.Add("")
        End If
        objParamList.Add(Asignar_Valor)
        objParamList.Add(lstr_FecIni)
        objParamList.Add(lstr_FecFin)
        'nuevo Compania division y planta
        objParamList.Add(Me.cmbCompania.SelectedValue)
        objParamList.Add(Me.cmbDivision.SelectedValue)

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
 
        objParamList.Add(UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta)
        '

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        Me.gwdDatos.DataSource = objOperacionReparto.Listar_Operaciones_Reparto(objParamList)
 
        Me.gwdSolicitud.DataSource = Nothing
        Me.gwGuiaTransporte.Rows.Clear()
        Me.Limpiar_Controles()
    End Sub

    

    Private Function validar_inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If txtClienteMnto.pCodigo = 0 Then
            lstr_validacion += "* CLIENTE " & Chr(13)
        End If

        If txtciatransportista.Tag = "" Then
            lstr_validacion += "* RUC DE TRANSPORTISTA" & Chr(13)
        End If
        'If txttracto.Tag = "" Then
        '    lstr_validacion += "* PLACA UNIDAD" & Chr(13)
        'End If
        If txttracto.Text.Trim = "" Then
            lstr_validacion += "* PLACA UNIDAD" & Chr(13)
        End If

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'If NroElementosPlanta(cboPlanta) > 1 Or NroElementosPlanta(cboPlanta) = 0 Then
        '    lstr_validacion += "* Solo Debe Tener Seleccionada Solo Una Planta" & Chr(13)
        'End If
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub Cargar_Datos_Grilla()

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

 
        Dim objEntidad As New Repartos
        
        objEntidad.CCLNT = Me.gwdDatos.Item("C_CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        txtClienteMnto.pCargar(objEntidad.CCLNT)
 
        Me.txtReferenciaCliente.Text = Me.gwdDatos.Item("C_TREFCL", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        Codigo = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        Me.dtpFechaReparto.Value = Me.gwdDatos.Item("FECREP_S", Me.gwdDatos.CurrentCellAddress.Y).Value


        txtciatransportista.Text = ("" & gwdDatos.CurrentRow.Cells("TRANSPORTISTA").Value).ToString.Trim
        txtciatransportista.Tag = ("" & gwdDatos.CurrentRow.Cells("C_NRUCTR").Value).ToString.Trim

        txttracto.Text = ("" & gwdDatos.CurrentRow.Cells("C_NPLCUN").Value).ToString.Trim
        txtacoplado.Text = ("" & gwdDatos.CurrentRow.Cells("NPLCAC").Value).ToString.Trim

    End Sub

    Private Sub Cargar_Detalle_Solicitud()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim objEntidad As New Repartos
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        objEntidad.NMOPRP = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue.ToString.Trim

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        objEntidad.CPLNDV = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        Me.gwdSolicitud.DataSource = objSolicitudTransporte.Listar_Solicitudes_Transporte_Reparto(objEntidad)



    End Sub

    Private Sub Nuevo_Reparto()
        Dim objOperacionReparto As New Repartos_BLL
        Dim objEntidad As New Repartos
        'Try
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.NMOPRP = 0
        objEntidad.FECREP = HelpClass.CtypeDate(Me.dtpFechaReparto.Value)
        objEntidad.TREFCL = txtReferenciaCliente.Text
        objEntidad.CCLNT = txtClienteMnto.pCodigo
        objEntidad.NRUCTR = Me.txtciatransportista.Tag
        objEntidad.NPLCUN = Me.txttracto.Text.Trim
        objEntidad.NPLCAC = txtacoplado.Text.Trim
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        objEntidad.CPLNDV = UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        objEntidad.SESTSO = "A"
        objEntidad.SESTRG = "A"

        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objOperacionReparto.Registrar_Operacion_Reparto(objEntidad)
        MessageBox.Show("Se Registró Satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Listar()

    End Sub

    Private Sub Modificar_Reparto()
        Dim objOperacionReparto As New Repartos_BLL
        Dim objEntidad As New Repartos

        objEntidad.NMOPRP = Codigo
        objEntidad.CCLNT = txtClienteMnto.pCodigo
        objEntidad.FECREP = HelpClass.CtypeDate(Me.dtpFechaReparto.Value)
        objEntidad.NRUCTR = Me.txtciatransportista.Tag
        objEntidad.NPLCUN = Me.txttracto.Text.Trim
        objEntidad.NPLCAC = txtacoplado.Text.Trim
        objEntidad.TREFCL = Me.txtReferenciaCliente.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        objEntidad = objOperacionReparto.Modificar_Operacion_Reparto(objEntidad)
        MessageBox.Show("Se Modificó Satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Listar()

    End Sub

    Private Sub Eliminar_Reparto(ByVal lstr_Estado As String)
        Dim objOperacionReparto As New Repartos_BLL
        Dim objEntidad As New Repartos

        objEntidad.NMOPRP = Codigo
        objEntidad.SESTRG = lstr_Estado
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad = objOperacionReparto.Eliminar_Operacion_Reparto(objEntidad)
        MessageBox.Show("Se Eliminó Satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.Listar()
      
    End Sub

   

    Private Sub Imprimir2(ByVal ListaParametros As List(Of String))
        Dim objOperacionReparto As New Repartos_BLL
        Dim objCrep As New rptOperacionReparto
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        objDs = objOperacionReparto.Listar_Reporte_Operacion_Reparto(ListaParametros)
        If objDs.Tables.Count = 0 Then Exit Sub
        objDs.Tables(0).TableName = "OpReparto"
        objDs.Tables(1).TableName = "RZST071"
        HelpClass.CrystalReportTextObject(objCrep, "lblEstado", Me.ddlEstado.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.Text)
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.Text)
        'HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", DevuelveTextoPlantasSeleccionadas(cboPlanta))
        HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", UcPLanta_Cmb011.obePlanta.TPLNTA_DescripcionPlanta)
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
        objCrep.SetDataSource(objDs)
        objPrintForm.ShowForm(objCrep, Me)
    End Sub

    Private Sub Limpiar_Controles_Solicitud()
        controlInformacion.dtpFechaSolicitud.Value = Date.Now.Date
        'controlInformacion.ctlLocalidadOrigen.Limpiar()
        controlInformacion.txt_localidad_origen.Text = ""
        controlInformacion.txt_localidad_origen.Tag = "0"
        controlInformacion.txtDireccionLocalidadCarga.Text = ""
        'controlInformacion.ctlLocalidadDestino.Limpiar()
        controlInformacion.txt_localidad_destino.Tag = "0"
        controlInformacion.txt_localidad_destino.Text = ""
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
        controlInformacion.txtOrdenServicio.Text = ""
        controlInformacion.txtUsuarioSolicitante.Text = ""
    End Sub

    Private Sub ActivarEstado_Solicitud(ByVal lbool_Estado As Boolean)

        'Select Case _TipoOperacion
        '    Case 0
        '        controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
        '        controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
        '        controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
        '        controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
        '        controlInformacion.txtObservaciones.Enabled = lbool_Estado
        '        controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        '        controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
        '    Case Else
        '        controlInformacion.txtCliente.Enabled = lbool_Estado
        '        controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
        '        controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
        '        controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
        '        controlInformacion.txtTipoServicio.Enabled = lbool_Estado
        '        controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
        '        controlInformacion.ctbMercaderias.Enabled = lbool_Estado
        '        controlInformacion.txtUnidadMedida.Enabled = lbool_Estado
        '        controlInformacion.txtCantidadMercaderia.Enabled = lbool_Estado
        '        controlInformacion.dtpFechaSolicitud.Enabled = lbool_Estado
        '        controlInformacion.dtpFechaInicioCarga.Enabled = lbool_Estado
        '        controlInformacion.dtpFinCarga.Enabled = lbool_Estado
        '        controlInformacion.txtObservaciones.Enabled = lbool_Estado
        '        controlInformacion.txtHoraCarga.Enabled = lbool_Estado
        '        controlInformacion.txtHoraEntrega.Enabled = lbool_Estado
        '        controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
        '        controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
        '        controlInformacion.btnLimpiarOS.Enabled = lbool_Estado
        '        controlInformacion.cmbTipoSolicitud.Enabled = lbool_Estado
        '        controlInformacion.cboMedioTransporte.Enabled = lbool_Estado
        'End Select


        Select Case oAccionServicio
            Case AccionServicio.Nuevo
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
                controlInformacion.btnLimpiarOS.Enabled = lbool_Estado
                controlInformacion.cmbTipoSolicitud.Enabled = lbool_Estado
                controlInformacion.cboMedioTransporte.Enabled = lbool_Estado
        End Select



    End Sub

    Private Function Validar_Input_Solicitud() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If controlInformacion.txtCliente.pCodigo = 0 Then
            lstr_validacion += "* CLIENTE " & Chr(13)
        End If
        'If controlInformacion.ctlLocalidadOrigen.NoHayCodigo = True Then
        If Val("" & controlInformacion.txt_localidad_origen.Tag) Then
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
        'If controlInformacion.txtUnidadMedida.NoHayCodigo = True Then
        If controlInformacion.txtUnidadMed.Text.Trim = "" Then
            lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        End If

        If controlInformacion.ucTipoCarga.Resultado Is Nothing Then
            lstr_validacion += "* SELECCIONE TIPO CARGA" & Chr(13)
        End If

        If controlInformacion.ucNivelServ.Resultado Is Nothing Then
            lstr_validacion += "* SELECCIONE NIVEL SERVICIO" & Chr(13)
        End If

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'If NroElementosPlanta(cboPlanta) > 1 Or NroElementosPlanta(cboPlanta) = 0 Then
        '    lstr_validacion += "* Solo Debe Tener Seleccionada Solo Una Planta" & Chr(13)
        'End If
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub Nuevo_Registro_Solicitud()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        'Try

        Dim oSeguridad As NEGOCIO.Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(MainModule.USUARIO)
        Dim mensaje As String = oSeguridad.VerificarLineaCreditoCliente(Me.cmbCompania.SelectedValue, controlInformacion.txtCliente.pCodigo)
        If mensaje.ToString() <> "" Then
            MessageBox.Show(mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

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
        objEntidad.CUNDMD = controlInformacion.txtUnidadMed.Text
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
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.CPLNDV = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



        objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.NMOPMM = 0
        objEntidad.NMOPRP = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value
        objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad.CTPOVJ = Me._CTPOVJ
        objEntidad.SPRSTR = "N"
        objEntidad.TRFRN = controlInformacion.txtUsuarioSolicitante.Text.Trim
        objEntidad.CTTRAN = CType(controlInformacion.ucNivelServ.Resultado, SOLMIN_ST.ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(controlInformacion.ucTipoCarga.Resultado, SOLMIN_ST.ENTIDADES.consultas.AtributosOI).Codigo


        Dim msgReg As String = ""
        objEntidad = objSolicitudTransporte.Registrar_Solicitud_Transporte(objEntidad, msgReg)

        If msgReg.Length > 0 Then
            MessageBox.Show(msgReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'Me.Generar_Junta_Transporte(objEntidad.NCSOTR, Me.cboTracto.Tag)
        'Me.Generar_Junta_Transporte(objEntidad.NCSOTR, Me.txttracto.Tag, Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value)
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Dim pCplndv As Decimal = Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value
        Registrar_Detalle_Solicitud_Operacion(objEntidad.NCSOTR, Me.txttracto.Tag, pCplndv)

        HelpClass.MsgBox("Se Registró Satisfactoriamente la Solicitud N° " & objEntidad.NCSOTR)
        Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
        Me.btnCancelarSolicitud_Click(Nothing, Nothing)
        Me.Cargar_Detalle_Solicitud()
      

    End Sub

    'Private Sub Modificar_Registro_Solicitud()
    '    'Procedimiento para registrar una nueva solicitud de transporte
    '    Dim objEntidad As New Solicitud_Transporte
    '    Dim objSolicitudTransporte As New Solicitud_Transporte_BLL


    '    'Try
    '    objEntidad.NCSOTR = controlInformacion.Codigo.Text
    '    objEntidad.NORSRT = IIf(controlInformacion.txtOrdenServicio.Text = "", 0, controlInformacion.txtOrdenServicio.Text)
    '    objEntidad.CCLNT = controlInformacion.txtCliente.pCodigo
    '    objEntidad.CMRCDR = controlInformacion.ctbMercaderias.Codigo
    '    objEntidad.FECOST = HelpClass.TodayNumeric
    '    objEntidad.HRAOTR = HelpClass.NowNumeric
    '    objEntidad.FECOST = HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value)
    '    objEntidad.CLCLOR = controlInformacion.ctlLocalidadOrigen.Codigo
    '    objEntidad.TDRCOR = controlInformacion.txtDireccionLocalidadCarga.Text
    '    objEntidad.CLCLDS = controlInformacion.ctlLocalidadDestino.Codigo
    '    objEntidad.TDRENT = controlInformacion.txtDireccionLocalidadEntrega.Text
    '    objEntidad.CUNDMD = controlInformacion.txtUnidadMedida.Codigo
    '    objEntidad.QSLCIT = IIf(controlInformacion.txtCantidadSolicitada.Text = "", "0", controlInformacion.txtCantidadSolicitada.Text)
    '    objEntidad.QATNAN = "0"
    '    objEntidad.FINCRG = HelpClass.CtypeDate(controlInformacion.dtpFechaInicioCarga.Value)
    '    objEntidad.HINCIN = HelpClass.CompletarCadena(controlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
    '    objEntidad.FENTCL = HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value)
    '    objEntidad.HRAENT = HelpClass.CompletarCadena(controlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
    '    objEntidad.QMRCDR = IIf(controlInformacion.txtCantidadMercaderia.Text = "", "0", controlInformacion.txtCantidadMercaderia.Text)
    '    objEntidad.CTPOSR = controlInformacion.txtTipoServicio.Codigo
    '    objEntidad.CUNDVH = controlInformacion.ctlTipoVehiculo.Codigo
    '    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '    objEntidad.CDVSN = Me.cmbDivision.SelectedValue

    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

    '    objEntidad.CPLNDV = UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta

    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    '    objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
    '    objEntidad.TOBS = controlInformacion.txtObservaciones.Text
    '    objEntidad.CULUSA = MainModule.USUARIO
    '    objEntidad.FULTAC = HelpClass.TodayNumeric
    '    objEntidad.HULTAC = HelpClass.NowNumeric
    '    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '    objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
    '    objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
    '    objEntidad.SPRSTR = "N"
    '    objEntidad.TRFRN = controlInformacion.txtUsuarioSolicitante.Text.Trim
    '    objEntidad.CTTRAN = CType(controlInformacion.ucNivelServ.Resultado, SOLMIN_ST.ENTIDADES.consultas.AtributosOI).Codigo
    '    objEntidad.CTIPCG = CType(controlInformacion.ucTipoCarga.Resultado, SOLMIN_ST.ENTIDADES.consultas.AtributosOI).Codigo
    '    objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte(objEntidad)

    '    Me.btnCancelarSolicitud_Click(Nothing, Nothing)
    '    Me.Cargar_Detalle_Solicitud()
    '    'Catch : End Try
    'End Sub

    Private Sub Eliminar_Solicitud(ByVal lstr_Estado As String)
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
 


        objEntidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        objEntidad.NCRRSR = gwdSolicitud.Item("D_NCRRSR", gwdSolicitud.CurrentCellAddress.Y).Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = cmbCompania.SelectedValue
        '------------------------------------------------------------
        'Parametros nuevos
        objEntidad.PNOPAN_CGSTO = ""
        objEntidad.FLGAPG = ""
        objEntidad.NOPRCR = 0
        objEntidad.UATAOP = ""
        objEntidad.USLAOP = ""
        objEntidad.MOTAOP = ""
        objEntidad.OBSAOP = ""
        objEntidad.TRFSRC = ""
        '------------------------------------------------------------
 

        Dim msgAlerta As String = ""
        Dim msgError As String = ""
        'Dim Codigo As String = ""

        'msgError = objSolicitudTransporte.Anulacion_Operacion_Transporte_Salm(objEntidad, Codigo, msgAlerta)
        msgError = objSolicitudTransporte.Anulacion_Operacion_Transporte_Salm(objEntidad, msgAlerta)
       
        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim msj As String = ""
        If msgAlerta.Length > 0 Then
            msj = (msgAlerta & Chr(13) & "Desea continuar con anulación de la operación?").Trim
        Else
            msj = "Desea continuar con anulación de la operación?"
        End If
      
        If MessageBox.Show(msj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim frmAnulacion As New frmAnularOperacion
            frmAnulacion.NCRRSR = gwdSolicitud.Item("D_NCRRSR", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.NCSOTR = gwdSolicitud.Item("D_NCSOTR", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.Operacion = gwdSolicitud.Item("D_NOPRCN", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.CCLINT = Me.gwdSolicitud.Item("CCLNT_COD", gwdSolicitud.CurrentCellAddress.Y).Value
            frmAnulacion.CCMPN = cmbCompania.SelectedValue
            frmAnulacion.CDVSN = cmbDivision.SelectedValue
            If frmAnulacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
               
                Me.Cargar_Detalle_Solicitud()

            End If
          
        End If
       
    End Sub


    'Private Sub Generar_Junta_Transporte(ByVal intNCSOTR As Int64, ByVal strCBRCNT As String, ByVal strCPLNDV As String)
    '    'Try
    '    Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
    '    Dim Objeto_Logica As New Junta_Transporte_BLL
    '    Objeto_Entidad.NCSOTR = intNCSOTR
    '    Objeto_Entidad.CCLNT = Me.txtClienteMnto.pCodigo
    '    Objeto_Entidad.NRUCTR = Me.txtciatransportista.Tag

    '    Objeto_Entidad.NPLCUN = Me.txttracto.Text.Trim
    '    Objeto_Entidad.NPLCAC = txtacoplado.Text.Trim
    '    Objeto_Entidad.CBRCNT = strCBRCNT
    '    Objeto_Entidad.CBRCN2 = ""
    '    Objeto_Entidad.CUSCRT = MainModule.USUARIO
    '    Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
    '    Objeto_Entidad.HRACRT = HelpClass.NowNumeric
    '    Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
    '    Objeto_Entidad.CCMPN = Me.cmbCompania.SelectedValue
    '    Objeto_Entidad.CDVSN = Me.cmbDivision.SelectedValue

    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    '    'Objeto_Entidad.CPLNDV = Me.cmbPlanta.SelectedValue
    '    Objeto_Entidad.CPLNDV = CType(strCPLNDV, Double)
    '    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



    '    Objeto_Entidad.NPLNJT = Objeto_Logica.Registrar_Junta_Transporte_Manual(Objeto_Entidad).NPLNJT


    '    Dim lobj_Entidad As New Detalle_Solicitud_Transporte
    '    lobj_Entidad.NPLNJT = CType(Objeto_Entidad.NPLNJT, Double)
    '    lobj_Entidad.NCRRPL = 0
    '    lobj_Entidad.NCRRSR = CType(Objeto_Entidad.NCRRSR, Double)
    '    lobj_Entidad.NCSOTR = intNCSOTR
    '    lobj_Entidad.CBRCNT = strCBRCNT

    '    lobj_Entidad.CPLNDV = CType(Objeto_Entidad.CPLNDV, Double) ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    '    Me.Registrar_Operacion_Transporte(lobj_Entidad)

    'End Sub


    Private Sub Registrar_Detalle_Solicitud_Operacion(ByVal intNCSOTR As Int64, ByVal strCBRCNT As String, ByVal strCPLNDV As String)
        'Try
        Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        Dim Objeto_Logica As New Junta_Transporte_BLL
        'Objeto_Entidad.NCSOTR = intNCSOTR
        'Objeto_Entidad.CCLNT = Me.txtClienteMnto.pCodigo
        'Objeto_Entidad.NRUCTR = Me.txtciatransportista.Tag

        'Objeto_Entidad.NPLCUN = Me.txttracto.Text.Trim
        'Objeto_Entidad.NPLCAC = txtacoplado.Text.Trim
        'Objeto_Entidad.CBRCNT = strCBRCNT
        'Objeto_Entidad.CBRCN2 = ""
        'Objeto_Entidad.CUSCRT = MainModule.USUARIO
        'Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
        'Objeto_Entidad.HRACRT = HelpClass.NowNumeric
        'Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        'Objeto_Entidad.CCMPN = Me.cmbCompania.SelectedValue
        'Objeto_Entidad.CDVSN = Me.cmbDivision.SelectedValue

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        ''Objeto_Entidad.CPLNDV = Me.cmbPlanta.SelectedValue
        'Objeto_Entidad.CPLNDV = CType(strCPLNDV, Double)
        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        'Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        'Dim Objeto_Logica As New Junta_Transporte_BLL


        Objeto_Entidad.NCSOTR = intNCSOTR
        Objeto_Entidad.CCLNT = Me.txtClienteMnto.pCodigo
        Objeto_Entidad.NRUCTR = Me.txtciatransportista.Tag

        Objeto_Entidad.NPLCUN = Me.txttracto.Text.Trim
        Objeto_Entidad.NPLCAC = txtacoplado.Text.Trim

        Objeto_Entidad.CBRCNT = strCBRCNT
        Objeto_Entidad.CBRCN2 = ""
        Objeto_Entidad.CUSCRT = MainModule.USUARIO
        'Objeto_Entidad.FCHCRT = HelpClass.TodayNumeric
        'Objeto_Entidad.HRACRT = HelpClass.NowNumeric
        Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        Objeto_Entidad.CCMPN = Me.cmbCompania.SelectedValue
        Objeto_Entidad.CDVSN = Me.cmbDivision.SelectedValue
        Objeto_Entidad.CPLNDV = CType(strCPLNDV, Double)

        Dim msg As String = ""
        'Objeto_Entidad.NPLNJT = Objeto_Logica.Registrar_Junta_Transporte_Manual(Objeto_Entidad).NPLNJT
        Dim oRespuesta As New ENTIDADES.beRespuestaOperacion
        oRespuesta = Objeto_Logica.Registrar_Detalle_Solicitud_Transporte(Objeto_Entidad, msg)

        Dim lobj_Entidad As New Detalle_Solicitud_Transporte
        'lobj_Entidad.NPLNJT = CType(Objeto_Entidad.NPLNJT, Double)
        'lobj_Entidad.NCRRPL = 0
        'lobj_Entidad.NCRRSR = CType(Objeto_Entidad.NCRRSR, Double)
        lobj_Entidad.NCRRSR = oRespuesta.NCRRSR
        lobj_Entidad.NCSOTR = intNCSOTR
        lobj_Entidad.CBRCNT = strCBRCNT
        lobj_Entidad.CPLNDV = CType(strCPLNDV, Double)  'CType(Objeto_Entidad.CPLNDV, Double) ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        Me.Registrar_Operacion_Transporte(lobj_Entidad)

    End Sub


    Private Sub Registrar_Operacion_Transporte(ByVal obj_Entidad As Detalle_Solicitud_Transporte)

        'Dim objEntidad As New List(Of String)
        Dim objOperacionTransporte As New OperacionTransporte_BLL
        'Dim lstr_resultado As String = ""
        'Dim objListaTemporal As New List(Of String)
        'Dim objEntidadOperacion As New OperacionTransporte
        'objEntidad.Add(obj_Entidad.NPLNJT)
        'objEntidad.Add(obj_Entidad.NCRRPL)
        'objEntidad.Add(obj_Entidad.NCSOTR)
        'objEntidad.Add(obj_Entidad.NCRRSR)
        'objEntidad.Add(Me.controlInformacion.txtOrdenServicio.Text)
        'objEntidad.Add(Me.cmbCompania.SelectedValue)
        'objEntidad.Add(Me.cmbDivision.SelectedValue)

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        ''objEntidad.Add(Me.cmbPlanta.SelectedValue)
        'objEntidad.Add(obj_Entidad.CPLNDV)
        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        'objEntidad.Add(MainModule.USUARIO)
        'objEntidad.Add(HelpClass.TodayNumeric)
        'objEntidad.Add(HelpClass.NowNumeric)
        'objEntidad.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        'objEntidad.Add("NUEVO")
        'objEntidad.Add("")
        'objEntidad.Add(0)
        'objEntidad.Add("")
        'objEntidad.Add(pFechaAtencionServicio)
        'objEntidad.Add(Me._CTPOVJ)


        Dim oParam_OP As New ENTIDADES.beRespuestaOperacion
        oParam_OP.NCSOTR = obj_Entidad.NCSOTR
        oParam_OP.NCRRSR = obj_Entidad.NCRRSR
        oParam_OP.NORSRT = Me.controlInformacion.txtOrdenServicio.Text
        oParam_OP.CCMPN = Me.cmbCompania.SelectedValue
        oParam_OP.CDVSN = Me.cmbDivision.SelectedValue
        oParam_OP.CPLNDV = obj_Entidad.CPLNDV
        oParam_OP.CUSCRT = MainModule.USUARIO
        oParam_OP.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        oParam_OP.TIPO_REGISTRO = "NUEVO"
        oParam_OP.SORGMV = ""
        oParam_OP.NDCORM = 0
        oParam_OP.PNCDTR = ""
        oParam_OP.FATNSR = pFechaAtencionServicio
        oParam_OP.CTPOVJ = Me._CTPOVJ

        Dim oRespuestaOP As New ENTIDADES.beRespuestaOperacion
        Dim msgError As String = ""
        'lstr_resultado = objOperacionTransporte.Registrar_Operacion_Transporte(objEntidad)
        oRespuestaOP = objOperacionTransporte.Registrar_Operacion_Transporte(oParam_OP, msgError)
        If msgError.Length > 0 Then
            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Generar_Orden_Interna(oRespuestaOP)

        'If IsNumeric(lstr_resultado) Then
        '    If lstr_resultado.Trim.Equals("-1") OrElse lstr_resultado.Trim.Equals("0") Then
        '        HelpClass.ErrorMsgBox()
        '        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '        Exit Sub
        '    Else
        '        Me.Generar_Orden_Interna(CType(lstr_resultado, Double), obj_Entidad.CBRCNT)
        '    End If
        'Else
        '    HelpClass.MsgBox(lstr_resultado, MessageBoxIcon.Error)
        'End If
       
    End Sub

    'oRespuesta As ENTIDADES.beRespuestaOperacion

    Private Sub Generar_Orden_Interna(oRespuesta As ENTIDADES.beRespuestaOperacion)
        'Private Sub Generar_Orden_Interna(ByVal ldbl_NOPRCN As Double, ByVal strCBRCNT As String)
        Dim objOrdenInterna As New OrdenInterna_BLL
        Dim objEntidad As New Planeamiento
        Dim objParametros As New List(Of String)
        'Try
        'objParametros.Add(ldbl_NOPRCN)
        'objParametros.Add(MainModule.USUARIO)
        'objParametros.Add(HelpClass.TodayNumeric)
        'objParametros.Add(HelpClass.NowNumeric)
        'objParametros.Add(Ransa.Utilitario.HelpClass.NombreMaquina)
        ''objParametros.Add(Me.txttracto.Tag)
        'objParametros.Add(Me.txttracto.Text)
        ''objParametros.Add("")
        'objParametros.Add(txtacoplado.Text)
        'objParametros.Add(strCBRCNT)
        'objParametros.Add(Me.cmbCompania.SelectedValue)
        'objEntidad = objOrdenInterna.Generar_Orden_Interna(objParametros)
        'If objEntidad.NORINS <= 0 Then
        '    HelpClass.ErrorMsgBox()
        'End If

        Dim msg_oi As String = ""
        Dim oFiltroRecurso As New ENTIDADES.Operaciones.OperacionTransporte
        oFiltroRecurso.NOPRCN = oRespuesta.NOPRCN
        oFiltroRecurso.NCRRPL = oRespuesta.NCRRPL
        oFiltroRecurso.NSBCRP = oRespuesta.NSBCRP
        oFiltroRecurso.CULUSA = MainModule.USUARIO
        oFiltroRecurso.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        Dim orptaOI As New ENTIDADES.beRespuestaOperacion
        orptaOI = objOrdenInterna.Generar_Orden_Interna_SALM(oFiltroRecurso, msg_oi)

        If msg_oi.Length > 0 Then
            MessageBox.Show("No se generó Orden Interna", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If




    End Sub

    Private Sub Listar_Guias_Transportista_Reparto()

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Dim strTemporal As String = ""
        Dim dwvrow As DataGridViewRow
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PSCCMPN", Me.cmbCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cmbDivision.SelectedValue)
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        objetoParametro.Add("PSCPLNDV", Me.gwdDatos.Item("C_CPLNDV", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim())
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        objetoParametro.Add("PNNMOPRP", Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim())
        Me.gwGuiaTransporte.Rows.Clear()

        'asdf xrty

        Dim fila As Decimal = 0
        For Each objData As DataRow In Objeto_Logica.Listar_Guia_Transportista_Reparto(objetoParametro).Rows
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.gwGuiaTransporte)
            Me.gwGuiaTransporte.Rows.Add(dwvrow)
            fila = gwGuiaTransporte.Rows.Count - 1


            If strTemporal = objData("NOPRCN").ToString Then

                gwGuiaTransporte.Rows(fila).Cells("NOPRCN").Value = 0
            Else

                gwGuiaTransporte.Rows(fila).Cells("NOPRCN").Value = objData("NOPRCN").ToString
                strTemporal = objData("NOPRCN").ToString
            End If

            gwGuiaTransporte.Rows(fila).Cells("CTRMNC").Value = objData("CTRSPT")

            gwGuiaTransporte.Rows(fila).Cells("NMNFCR").Value = objData("NMNFCR")

            gwGuiaTransporte.Rows(fila).Cells("NGUIRM").Value = objData("NGUIRM")

            gwGuiaTransporte.Rows(fila).Cells("FGUIRM_S").Value = objData("FGUIRM_S").ToString

            gwGuiaTransporte.Rows(fila).Cells("NRHJCR").Value = objData("NRHJCR")

            gwGuiaTransporte.Rows(fila).Cells("NLQDCN").Value = objData("NLQDCN")

            gwGuiaTransporte.Rows(fila).Cells("TDIROR").Value = objData("TDIROR").ToString

            gwGuiaTransporte.Rows(fila).Cells("TDIRDS").Value = objData("TDIRDS").ToString

            gwGuiaTransporte.Rows(fila).Cells("TCMRCD").Value = objData("TCMRCD").ToString

            gwGuiaTransporte.Rows(fila).Cells("PMRCMC").Value = objData("PMRCMC")

            gwGuiaTransporte.Rows(fila).Cells("CBRCNT").Value = objData("CBRCNT").ToString

            gwGuiaTransporte.Rows(fila).Cells("CBRCND").Value = objData("CBRCND").ToString

            gwGuiaTransporte.Rows(fila).Cells("QKMREC").Value = objData("QKMREC")

            gwGuiaTransporte.Rows(fila).Cells("QGLGSL").Value = objData("QGLGSL")

            gwGuiaTransporte.Rows(fila).Cells("QGLDSL").Value = objData("QGLDSL")

            gwGuiaTransporte.Rows(fila).Cells("SESGRP").Value = objData("SESGRP").ToString

            gwGuiaTransporte.Rows(fila).Cells("SGUIFC").Value = objData("SGUIFC").ToString

            gwGuiaTransporte.Rows(fila).Cells("CLCLOR").Value = objData("CLCLOR")

            gwGuiaTransporte.Rows(fila).Cells("CLCLDS").Value = objData("CLCLDS")

            gwGuiaTransporte.Rows(fila).Cells("CMRCDR").Value = objData("CMRCDR")

            gwGuiaTransporte.Rows(fila).Cells("NOPRCN_1").Value = objData("NOPRCN")

            gwGuiaTransporte.Rows(fila).Cells("FLGSTA").Value = objData("FLGSTA")

            gwGuiaTransporte.Rows(fila).Cells("FLGGTI").Value = objData("FLGGTI")
            gwGuiaTransporte.Rows(fila).Cells("NCRDCO").Value = objData("NCRDCO")


            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            gwGuiaTransporte.Rows(fila).Cells("CPLNDV").Value = objData("CPLNDV")
            'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS



        Next

    End Sub

    Public Sub Lista_Proceso_Guia_Transporte(ByVal NroOpeReparto As Int64)

        Dim frm_GuiaTransportista As New frmGuiaTransportista
        Dim obj_Logica_Guia As New GuiaTransportista_BLL

        Dim obj_Entidad_GT As New GuiaTransportista
        Dim int_Indice As Int32 = Me.gwdSolicitud.CurrentCellAddress.Y
        With frm_GuiaTransportista
            .IsMdiContainer = True
            .AutoSize = True
            Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista
            With Comp_Guia
                .ESTADO = False
                .Dock = DockStyle.Fill
                '.EstadoGuiaRemisión = True
                .pCOMPANIA = Me.cmbCompania.SelectedValue
                .pDIVISION = Me.cmbDivision.SelectedValue
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                ' .PLANTA = Me.cmbPlanta.SelectedValue
                .pPLANTA = Me.gwdSolicitud.Item("D_CPLNDV", int_Indice).Value 'obj_Entidad.NOPRCN
                .pPLANTA_DESC = Me.UcPLanta_Cmb011.obePlanta.TPLNTA_DescripcionPlanta
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                .pNOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", int_Indice).Value 'obj_Entidad.NOPRCN
                .pUSUARIO = MainModule.USUARIO ' 

                '.Guia_Transporte.NRUCTR = Me.txtciatransportista.Tag 'obj_Entidad.NRUCTR
                '.Guia_Transporte.NPLCTR = Me.gwdSolicitud.Item("D_NPLCUN", int_Indice).Value 'obj_Entidad.NPLCUN.ToString()
                '.Guia_Transporte.NPLCAC = "" 'obj_Entidad.NPLCAC
                '.Guia_Transporte.CBRCNT = Me.gwdSolicitud.Item("D_CBRCND", int_Indice).Value 'obj_Entidad.CBRCND.ToString()
                '.Guia_Transporte.CBRCND = Me.gwdSolicitud.Item("D_CBRCNT", int_Indice).Value 'obj_Entidad.CBRCNT.ToString()

                '.Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
                '.Guia_Transporte.CDVSN = Me.cmbDivision.SelectedValue
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                '.Guia_Transporte.CPLNDV = Me.gwdSolicitud.Item("D_CPLNDV", int_Indice).Value 'obj_Entidad.NOPRCN
                '.Guia_Transporte.NOPRCN = Me.gwdSolicitud.Item("D_NOPRCN", int_Indice).Value
                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                .pNMOPRP = Me.gwdSolicitud.Item("D_NMOPRP", int_Indice).Value
                '.Guia_Transporte.NMOPRP = Me.gwdSolicitud.Item("D_NMOPRP", int_Indice).Value
                '.Guia_Transporte.CTPOVJ = Me._CTPOVJ
                .pCTPOVJ = Me._CTPOVJ
                .Tag = 0
                .TipoViaje = 0

                '.objTable = Operacion_Guia_Transporte()
                .ChargeForm()
            End With
            '.txtNombreFormulario.Text = "  NUEVA GUIA DE REMISION "
            .panelGuia.Controls.Add(Comp_Guia)

            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                If Comp_Guia.pGuiaTransporte.NGUIRM <> 0 Then
                    Dim Objeto_Logica As New GuiaTransportista_BLL
                    Dim oGuiaTransportistaPK As New TD_GuiaTransportistaPK
                    Dim sGuiaPrincipal As Int64 = 0
                    Dim dFechaGuiaPrincipal As Date = Date.Now
                    Dim sRelacionGuiasSeleccionada As String = ""

                    'LIMPIANDO EL dtgGuiasPendientes
                    oGuiaTransportistaPK.pCTRMNC_CodigoTransportista = Comp_Guia.pGuiaTransporte.CTRMNC
                    oGuiaTransportistaPK.pNGUIRM_NroGuiaTransportista = Comp_Guia.pGuiaTransporte.NGUIRM
                    oGuiaTransportistaPK.pCCMPN_Ccompania = Me.cmbCompania.SelectedValue

                    'LLENANDO EL dtgGuiasPendientes
                    Dim listTD_Obj_GuiaRemisionGTransp As List(Of TD_Obj_GuiaRemisionGTransp) = Objeto_Logica.Listar_GRemPendientesGTranspLiquidacion(oGuiaTransportistaPK)
                    Select Case listTD_Obj_GuiaRemisionGTransp.Count
                        Case 0
                            HelpClass.MsgBox("No tiene Guía de Remisión Cargada", MessageBoxIcon.Information)
                            Exit Sub
                        Case 1
                            Dim objEntidad As TD_Obj_GuiaRemisionGTransp = listTD_Obj_GuiaRemisionGTransp.Item(0)
                            sGuiaPrincipal = objEntidad.pNRGUCL_NroGuiaRemision
                            dFechaGuiaPrincipal = objEntidad.pFCGUCL_FechaGuiaRemision
                        Case Is > 1
                            Dim fMostrarGuiasRem As frmLiquidacionFlete_DlgMostrarGuiasRem = New frmLiquidacionFlete_DlgMostrarGuiasRem(Comp_Guia.pGuiaTransporte.CTRMNC, Comp_Guia.pGuiaTransporte.NGUIRM, Me.cmbCompania.SelectedValue)
                            If fMostrarGuiasRem.ShowDialog = Windows.Forms.DialogResult.OK Then
                                sGuiaPrincipal = fMostrarGuiasRem.pGuiaRemPrincipal
                                dFechaGuiaPrincipal = fMostrarGuiasRem.pFechaGuiaPrincipal
                                sRelacionGuiasSeleccionada = fMostrarGuiasRem.pListaGuiasHijas
                            End If
                    End Select
                    Dim oTemp As New TD_Obj_InfGRemCargada
                    With oTemp
                        .pCTRMNC_CodigoTransportista = Comp_Guia.pGuiaTransporte.CTRMNC
                        .pNGUIRM_NroGuiaTransportista = Comp_Guia.pGuiaTransporte.NGUIRM
                        .pNGUITR_GuiaRemisionCargada = sGuiaPrincipal
                        .pFGUITR_FechaGuiaRemision = dFechaGuiaPrincipal
                        .pRELGUI_RelacionGuiaHijas = sRelacionGuiasSeleccionada
                        .pCCLNT1_CodigoCliente = Me.txtClienteMnto.pCodigo
                        .pCLCLOR_CodigoLocalidadOrigen = Comp_Guia.pGuiaTransporte.CLCLOR
                        .pTCMLCO_LocalidadOrigen = Comp_Guia.pGuiaTransporte.TCMLCO
                        .pCLCLDS_CodigoLocalidadDestino = Comp_Guia.pGuiaTransporte.CLCLDS
                        .pTCMLCD_LocalidadDestino = Comp_Guia.pGuiaTransporte.TCMLCD
                        .pNOPRCN_NroOperacion = Comp_Guia.pGuiaTransporte.NOPRCN
                        .pNLQDCN_NroLiquidacion = 0
                        .pCTRSPT_Transportista = Comp_Guia.pGuiaTransporte.CTRSPT
                        .pTCMTRT_RazSocialTransportista = Me.txtciatransportista.Tag
                        .pNPLVHT_Tracto = Comp_Guia.pGuiaTransporte.NPLCTR
                        .pCBRCNT_Brevete = Comp_Guia.pGuiaTransporte.CBRCNT
                        .pCMRCDR_Mercaderia = Me.gwdSolicitud.Item("D_CMRCDR", int_Indice).Value
                        .pTAMRCD_DetalleMercaderia = Me.gwdSolicitud.Item("D_TCMRCD", int_Indice).Value
                        .pFRCGRM_FechaRecepGuiaRemision = Now
                        .pQGLGSL_CantidadGlsGasolina = Comp_Guia.pGuiaTransporte.QGLGSL
                        .pQGLDSL_CantidadGlsDiesel = Comp_Guia.pGuiaTransporte.QGLDSL
                        .pNRHJCR_NroHojasCargui = Comp_Guia.pGuiaTransporte.NRHJCR
                        .pCPRCN1_CodigoPropietarioContenedor1 = ""
                        .pNSRCN1_SerieContenedor1 = ""
                        .pCPRCN2_CodigoPropietarioContenedor2 = ""
                        .pNSRCN2_SerieContenedor2 = ""
                        .pFLLGCM_FechaLlegadaCamion = .pFGUITR_FechaGuiaRemision
                        .pFSLDCM_FechaSalidaCamion = .pFGUITR_FechaGuiaRemision
                        .pQKLMRC_KilometrosRecorridos = Comp_Guia.pGuiaTransporte.QKMREC
                        .pQHRSRV_CantidadHorasServicio = 0
                        .pQBLRMS_CantidadBultosRemision = Comp_Guia.pGuiaTransporte.QMRCMC
                        .pPBRTOR_PesoBrutoRemision = IIf(Comp_Guia.pGuiaTransporte.QPSOBR = 0, Comp_Guia.pGuiaTransporte.PMRCMC, Comp_Guia.pGuiaTransporte.QPSOBR)
                        If Comp_Guia.pGuiaTransporte.QPSOBR <> 0 And Comp_Guia.pGuiaTransporte.PMRCMC <> 0 Then
                            .pPTRAOR_PesoTaraRemision = Comp_Guia.pGuiaTransporte.QPSOBR - Comp_Guia.pGuiaTransporte.PMRCMC
                            .pPTRDST_PesoTaraRecepcion = Comp_Guia.pGuiaTransporte.QPSOBR - Comp_Guia.pGuiaTransporte.PMRCMC
                        Else
                            .pPTRAOR_PesoTaraRemision = 0
                            .pPTRDST_PesoTaraRecepcion = 0
                        End If
                        .pQVLMOR_VolumenRemision = Comp_Guia.pGuiaTransporte.QVLMOR
                        .pQBLRCP_CantidadBultosRecepcion = Comp_Guia.pGuiaTransporte.QMRCMC
                        .pPBRDST_PesoBrutoRecepcion = .pPBRTOR_PesoBrutoRemision
                        .pQVLMDS_VolumenRecepcion = Comp_Guia.pGuiaTransporte.QVLMOR
                        .pMMCUSR_Usuario = MainModule.USUARIO
                        .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
                        .pCCMPN_Compania = Me.cmbCompania.SelectedValue
                    End With
                    Dim bResultado As Boolean = True
                    Dim sErrorMesage As String = ""
                    Dim resultado As Int32 = 0
                    bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oTemp, sErrorMesage)
                    If Not bResultado Or sErrorMesage <> "" Then
                        MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    'Llenando los datos de la guia de Anexo    
                    'Dim NCOREG As String = ""
                    'Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
                    'obeSeguimientoGPS.NPLCTR = Me.gwdSolicitud.Item("D_NPLCUN", int_Indice).Value
                    'obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.gwdSolicitud.Item("D_NCSOTR", int_Indice).Value)
                    'obeSeguimientoGPS.CCMPN = Me.cmbCompania.SelectedValue
                    'obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.gwdSolicitud.Item("D_NCRRSR", int_Indice).Value)
                    'obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me.gwdSolicitud.Item("D_NGSGWP", int_Indice).Value)
                    'obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me.gwdSolicitud.Item("D_NCOREG", int_Indice).Value)
                    'Dim ofrmGPSWAP As New frmGPSWAP()
                    'ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
                    'ofrmGPSWAP.Estado = 1
                    'ofrmGPSWAP.ShowDialog(Me)
                    Cargar_Detalle_Solicitud()
                    Listar_Guias_Transportista_Reparto()
                End If
            End If
        End With
    End Sub

    Private Sub Eliminar_GuiaTransportista()
        If Me.gwGuiaTransporte.RowCount = 0 Then Exit Sub
        Dim lstr_Mensaje As String = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim objeto_Entidad As New GuiaTransportista
        Dim objeto_Entidad_Reparto As New Repartos
        Dim objeto_Logica As New GuiaTransportista_BLL
        Dim objeto_Logica_Reparto As New Repartos_BLL
        Dim lint_Indice As Integer = Me.gwGuiaTransporte.CurrentCellAddress.Y
        objeto_Entidad.CTRMNC = Me.gwGuiaTransporte.Item("CTRMNC", lint_Indice).Value
        objeto_Entidad.NGUIRM = Me.gwGuiaTransporte.Item("NMNFCR", lint_Indice).Value
        objeto_Entidad.NOPRCN = CType(Me.gwGuiaTransporte.Item("NOPRCN_1", lint_Indice).Value, Double)
        objeto_Entidad.CULUSA = MainModule.USUARIO
        objeto_Entidad.FULTAC = HelpClass.TodayNumeric
        objeto_Entidad.HULTAC = HelpClass.NowNumeric
        objeto_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objeto_Entidad.SESTRG = "E"
        objeto_Entidad.CCMPN = cmbCompania.SelectedValue
        objeto_Entidad_Reparto.NOPRCN = Me.gwGuiaTransporte.Item("NOPRCN_1", lint_Indice).Value
        objeto_Entidad_Reparto.NGUITR = Me.gwGuiaTransporte.Item("NGUIRM", lint_Indice).Value
        objeto_Entidad_Reparto.CCMPN = cmbCompania.SelectedValue
        objeto_Entidad.CTRMNC = objeto_Logica.Eliminar_Guia_Transportista_Reparto(objeto_Entidad).CTRMNC
        objeto_Logica_Reparto.Eliminar_Operacion_Reparto_Guia_Remision_Servicio(objeto_Entidad_Reparto)
        If objeto_Entidad.CTRMNC <> 0 Then
            HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            Cargar_Detalle_Solicitud()
            Me.Listar_Guias_Transportista_Reparto()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Else
            HelpClass.ErrorMsgBox()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub Modificar_Estado_Operacion_Reparto()
        Dim objOperacionReparto As New Repartos_BLL
        Dim objEntidad As New Repartos


        objEntidad.NMOPRP = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value
        objEntidad.SESTSO = "C"
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        objEntidad = objOperacionReparto.Modificar_Estado_Operacion_Reparto(objEntidad)


        Me.Listar()

    End Sub

    Private Sub Modificar_Solicitud()
        If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
        If (Me.gwdDatos.Item("C_SESTSO", Me.gwdDatos.CurrentCellAddress.Y).Value = "C") Then
            HelpClass.MsgBox("No se Permite Modificar Solicitud ,  Operación de Reparto cerrado", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.panelReparto.Visible = False
        Me.PanelFiltros.Enabled = False
        Me.gwdDatos.Enabled = False
        'Me._TipoOperacion = 1
        controlInformacion.CCMPN = Me.cmbCompania.SelectedValue
        controlInformacion.pCDVSN = Me.cmbDivision.SelectedValue

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'controlInformacion.pCPLNDV = Me.cmbPlanta.SelectedValue
        controlInformacion.pCPLNDV = Me.gwdSolicitud.Item("D_CPLNDV", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


        controlInformacion.NCSOTR_1 = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        controlInformacion.TipoOperacion = 1
        controlInformacion.OPCION = 0
        controlInformacion.Actualizar_Datos()
        Me.ActivarEstado_Solicitud(True)
        Me.controlInformacion.dtpFechaSolicitud.Enabled = False
        If Me.gwdSolicitud.Item("D_CANTOP", Me.gwdSolicitud.CurrentCellAddress.Y).Value > 0 Then
            Me.ActivarEstado_Solicitud(False)
            Me.controlInformacion.txtCantidadSolicitada.Enabled = False
            Me.controlInformacion.ctlTipoVehiculo.Enabled = True
            Me.controlInformacion.dtpFechaInicioCarga.Enabled = True
            Me.controlInformacion.txtHoraCarga.Enabled = True
            Me.controlInformacion.txtDireccionLocalidadCarga.Enabled = True
            Me.controlInformacion.dtpFinCarga.Enabled = True
            Me.controlInformacion.txtHoraEntrega.Enabled = True
            Me.controlInformacion.txtDireccionLocalidadEntrega.Enabled = True
        End If
        Me.controlInformacion.txtCliente.Enabled = False
        Me.btnCancelarSolicitud.Text = " Salir"
        Me.panelSolicitudR.Visible = True
    End Sub

    Private Function Verificar_Existencia_Guia_x_Solicitud() As Boolean
        Dim bool_Estado As Boolean = False
        Dim intNOPRCN As Int64 = Me.gwdSolicitud.Item("D_NOPRCN", Me.gwdSolicitud.CurrentCellAddress.Y).Value
        For intContador As Int32 = 0 To Me.gwGuiaTransporte.RowCount - 1
            If intNOPRCN = Me.gwGuiaTransporte.Item("NOPRCN_1", intContador).Value Then
                bool_Estado = True
                Exit For
            End If
        Next
        Return bool_Estado
    End Function

    Private Function Operacion_Guia_Transporte() As DataTable
        Dim intContador As Int32 = Me.gwdSolicitud.CurrentCellAddress.Y
        Dim objRow As DataRow
        Dim objTable As New DataTable
        objTable.Columns.Add("TCMPCL", Type.GetType("System.String"))
        objTable.Columns.Add("NOPRCN", Type.GetType("System.Int64"))
        objTable.Columns.Add("CCMPN", Type.GetType("System.String"))
        Me.gwdSolicitud.EndEdit()
        With Me.gwdSolicitud
            objRow = objTable.NewRow
            objRow("TCMPCL") = Me.gwdDatos.Item("C_TCMPCL", Me.gwdDatos.CurrentCellAddress.Y).Value
            objRow("NOPRCN") = .Item("D_NOPRCN", intContador).Value
            objRow("CCMPN") = Me.cmbCompania.SelectedValue
            objTable.Rows.Add(objRow)

        End With
        Return objTable
    End Function

#End Region
    'Private Sub btnVerRutaOptima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerRutaOptima.Click
    '    Dim Objeto_Logica As New GuiaTransportista_BLL
    '    Dim objEntidad As New GuiaTransportista
    '    Dim objGuia As New GuiaTransportista
    '    objGuia.CCMPN = Me.cmbCompania.Text
    '    objGuia.CDVSN = Me.cmbDivision.Text
    '    objGuia.CPLNDV_S = Me.cmbPlanta.Text
    '    objGuia.USRCRT = MainModule.USUARIO
    '    objGuia.FCHCRT = HelpClass.TodayNumeric
    '    objGuia.HRACRT = HelpClass.NowNumeric
    '    Dim objLista As New List(Of GuiaTransportista)
    '    If Me.gwdDatos.DataSource IsNot Nothing And Me.gwdDatos.RowCount > 0 Then
    '        If Me.gwdDatos.CurrentCellAddress.Y <> -1 Then
    '            objEntidad.NMOPRP = Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
    '            'objetoParametro.Add("PNNMOPRP", Me.gwdDatos.Item("C_NMOPRP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim())
    '            objLista = Objeto_Logica.Listar_Ruta_Optima_Reparto(objEntidad)
    '            Dim ofrmVerRutaOptima As New frmVerRutaOptima(objLista)
    '            With ofrmVerRutaOptima
    '                .Guia = objGuia
    '                '.Lista = objLista
    '                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '            End With
    '        Else
    '            MessageBox.Show("Debe seleccionar Nro. Operación Reparto", "Error", MessageBoxButtons.OK)
    '        End If
    '    End If


    'End Sub



    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

    Private Sub btnExportarExcel1_Click(sender As Object, e As EventArgs) Handles btnExportarExcel1.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.gwdDatos
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Operaciones de Reparto "
            strlFiltros.Add("Compañia : \n" & cmbCompania.Text)
            strlFiltros.Add("División : \n" & cmbDivision.Text)
            Dim strPlantas As String
            strPlantas = ""
            Dim strPSiguiente As String
            strPSiguiente = ""
            For i As Integer = 0 To gwdDatos.Rows.Count - 1
                strPSiguiente = CStr(gwdDatos.Rows(i).Cells("C_TPLNTA").Value)
                strPlantas += strPSiguiente + ","
            Next
            Dim rresultado As String
            rresultado = ""
            rresultado = RemoveDupes2(strPlantas, ", ")
            strlFiltros.Add("Planta : \n" & rresultado)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Function RemoveDupes2(txt As String, Optional delim As String = " ") As String
        Dim x
        'Updateby20140924
        With CreateObject("Scripting.Dictionary")
            .CompareMode = vbTextCompare
            For Each x In Split(txt, delim)
                If Trim(x) <> "" And Not .exists(Trim(x)) Then .Add(Trim(x), Nothing)
            Next
            If .Count > 0 Then RemoveDupes2 = Join(.keys, delim)
        End With
    End Function

    'Private Sub cargarComboPlanta()
    '    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    '    Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    '    Dim objLogica As New NEGOCIO.Planta_BLL
    '    cboPlanta.Text = ""
    '    If (cmbCompania.SelectedValue IsNot Nothing And cmbDivision.SelectedValue IsNot Nothing) Then
    '        objLogica.Crea_Lista()
    '        objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.SelectedValue, cmbDivision.SelectedValue)
    '        Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral

    '        Dim OPlanta As New ClaseGeneral
    '        OPlanta.CPLNDV = 0
    '        OPlanta.TPLNTA = "TODOS"
    '        objLisEntidad2.Insert(0, OPlanta)

    '        For Each objEntidad In objLisEntidad2
    '            objLisEntidad.Add(objEntidad)
    '        Next
    '        cboPlanta.DisplayMember = "TPLNTA"
    '        cboPlanta.ValueMember = "CPLNDV"
    '        Me.cboPlanta.DataSource = objLisEntidad
    '        For i As Integer = 0 To cboPlanta.Items.Count - 1
    '            If cboPlanta.Items.Item(i).Value = "1" Then
    '                cboPlanta.SetItemChecked(i, True)
    '            End If
    '        Next
    '        If cboPlanta.Text = "" Then
    '            cboPlanta.SetItemChecked(0, True)
    '        End If
    '    End If






    'End Sub

    'Private Function ValidarFiltroPlanta() As Boolean
    '    Dim lstr_validacion As String = ""
    '    Dim lbool_existe_error As Boolean = True
    '    For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
    '        lstr_validacion += cboPlanta.CheckedItems(i).Value & ","
    '    Next
    '    If lstr_validacion = "" Then
    '        lbool_existe_error = False
    '    End If
    '    If lbool_existe_error = False Then HelpClass.MsgBox("Seleccione alguna(s) Planta(s)" & Chr(13) & lstr_validacion, MessageBoxIcon.Information)
    '    Return lbool_existe_error
    'End Function

    'Private Function DevuelvePlantaSeleccionadas(MiCombo As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
    '    Dim strCodPlanta As String
    '    strCodPlanta = ""
    '    For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
    '        strCodPlanta += MiCombo.CheckedItems(i).Value & ","
    '    Next
    '    Dim v As Integer
    '    v = InStr(1, strCodPlanta, "0,")
    '    If v = 1 Then
    '        strCodPlanta = "0,"

    '    End If
    '    If strCodPlanta = "0," Then
    '        strCodPlanta = ""
    '        For i As Integer = 1 To MiCombo.Items.Count - 1
    '            strCodPlanta += MiCombo.Items(i).Value & ","
    '        Next
    '    End If
    '    If strCodPlanta.Trim.Length > 0 Then
    '        strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
    '    End If
    '    Return strCodPlanta

    'End Function

    'Private Function DevuelveTextoPlantasSeleccionadas(MiCombo As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
    '    Dim strCodPlanta As String
    '    strCodPlanta = ""
    '    Dim strCodPlanta2 As String
    '    strCodPlanta2 = ""
    '    For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
    '        strCodPlanta += MiCombo.GetItemText(MiCombo.CheckedItems(i)) & ", "
    '    Next

    '    Dim texto() As String = Split(strCodPlanta, ", ")
    '    Dim x As Integer
    '    x = 0
    '    For i As Integer = 0 To UBound(texto)
    '        x = InStr(1, texto(i), "name")
    '        If x > 0 Then
    '            strCodPlanta = Strings.Mid(texto(i), 7)
    '            strCodPlanta = Strings.Replace(strCodPlanta, "'", "") + ", "
    '            strCodPlanta2 += strCodPlanta

    '        End If
    '    Next
    '    If strCodPlanta2.Trim.Length > 0 Then
    '        strCodPlanta2 = strCodPlanta2.Trim.Substring(0, strCodPlanta2.Trim.Length - 1)
    '    End If
    '    MsgBox(strCodPlanta2)
    '    Return strCodPlanta2

    'End Function

    Private Function NroElementosPlanta(MiCombo As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As Integer
        Dim strCodPlanta As String
        Dim Contador As Integer
        Contador = 0
        strCodPlanta = ""
        For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
            strCodPlanta += MiCombo.CheckedItems(i).Value & ","
            Contador = Contador + 1
        Next

        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return Contador

    End Function

    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


    Private Sub cmbDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDivision.SelectionChangeCommitted
        Try

            Me.UcPLanta_Cmb011.Usuario = MainModule.USUARIO
            Me.UcPLanta_Cmb011.CodigoCompania = cmbCompania.SelectedValue
            Me.UcPLanta_Cmb011.CodigoDivision = cmbDivision.SelectedValue
            Me.UcPLanta_Cmb011.PlantaDefault = 1
            Me.UcPLanta_Cmb011.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim frm As frmBuscarTracAcoplado = New frmBuscarTracAcoplado()

            frm.CCMPN = Me.cmbCompania.SelectedValue
            frm.CDVSN = Me.cmbDivision.SelectedValue
            frm.CPLNDV = UcPLanta_Cmb011.obePlanta.CPLNDV_CodigoPlanta
            frm.RucTransportista = ("" & txtciatransportista.Tag).ToString.Trim
            frm.TRACTO = txttracto.Text.Trim
            frm.ACOPLADO = txtacoplado.Text.Trim

            frm.ShowDialog()
            If frm.DialogResult = DialogResult.OK Then
                Me.txtciatransportista.Text = frm.TRANSPORTISTA
                Me.txtciatransportista.Tag = frm.RucTransportista

                Me.txttracto.Text = frm.TRACTO


                Me.txtacoplado.Text = frm.ACOPLADO

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged

        Try


            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            habilitarBoton(gEnum_Mantenimiento)
            Estado_Controles(False)
            Me.txtClienteMnto.pClear()
            controlInformacion.txtCliente.pClear()
            Me.Cargar_Datos_Grilla()
            Me.Cargar_Detalle_Solicitud()
            Me.Listar_Guias_Transportista_Reparto()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim tabselect As String = tbReparto.SelectedTab.Name
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If tabselect = "tbMantenimiento" Then
                Dim codEstadoReparto As String = gwdDatos.CurrentRow.Cells("C_SESTSO").Value
                If codEstadoReparto = "A" Then
                    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    habilitarBoton(gEnum_Mantenimiento)
                    Estado_Controles(True)
                Else
                    MessageBox.Show("El reparto ya tiene servicios asignados. No puede ser modificado.")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
End Class
