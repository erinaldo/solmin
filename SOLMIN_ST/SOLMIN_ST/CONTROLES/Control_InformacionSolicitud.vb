Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class Control_InformacionSolicitud

#Region "Propiedades"
    Private _NCSOTR_1 As String = ""
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Int16 = 0
    Private _CantidadOperaciones As Integer = 0
    Private _TipoOperacion As Int16 = 0
    Private _OPCION As Int16 = 0

    'Codigo agregado por MREATEGUIP - Ajuste Moneda
    '----- Ini -----
    Private _pCTPOVJ As String = ""
    Private _pNOPRCN As Decimal = 0
    '----- Fin -----

    ''' <summary>
    ''' Cantidad de Operaciones
    ''' </summary>

    Public Property CantidadOperaciones() As Integer
        Get
            Return _CantidadOperaciones
        End Get
        Set(ByVal value As Integer)
            _CantidadOperaciones = value
        End Set
    End Property

    Public WriteOnly Property NCSOTR_1() As String
        Set(ByVal value As String)
            _NCSOTR_1 = value
        End Set
    End Property

    Public WriteOnly Property TipoOperacion() As Int16
        Set(ByVal value As Int16)
            _TipoOperacion = value
        End Set
    End Property

    Public WriteOnly Property OPCION() As Int16
        Set(ByVal value As Int16)
            _OPCION = value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public WriteOnly Property pCDVSN() As String
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Public WriteOnly Property pCPLNDV() As Int16
        Set(ByVal value As Int16)
            _CPLNDV = value
        End Set
    End Property

    'Codigo agregado por MREATEGUIP - Ajuste Moneda
    '----- Ini -----
    Public Property pCTPOVJ() As String
        Get
            Return _pCTPOVJ
        End Get
        Set(ByVal value As String)
            _pCTPOVJ = value
        End Set
    End Property

    Public Property pNOPRCN() As Decimal
        Get
            Return _pNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _pNOPRCN = value
        End Set
    End Property
    '----- Fin -----

#End Region

#Region "Eventos"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            txtUnidadMed.Enabled = False

            dtgRecursosAsignados.AutoGenerateColumns = False
            txtCliente.pUsuario = USUARIO
            Select Case _TipoOperacion
                Case 0
                    Carga_TipoSolicitud()
                    Cargar_Combo()
                    'Ordenar_Columna_RecursosAsignados()
                    Cargar_Datos_Solicitados(_NCSOTR_1)
                    Cargar_Detalle_Solicitud(_NCSOTR_1)

                Case 1
                    Carga_TipoSolicitud()
                    Cargar_Combo()
                    Cargar_Datos_Solicitados(_NCSOTR_1)
                Case 2, 4
                    Carga_TipoSolicitud()
                    Cargar_Combo()

                Case 3
                    'Ordenar_Columna_RecursosAsignados()
                    Cargar_Detalle_Solicitud(_NCSOTR_1)
                    If _OPCION = 2 Then Me.dtgRecursosAsignados.Columns("DETASIG").Visible = True
            End Select
            Me.cboMedioTransporte.SelectedValue = 4
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Public Sub Actualizar_Datos()
        txtCliente.pUsuario = USUARIO
        Select Case _TipoOperacion
            Case 0
                Carga_TipoSolicitud()
                'Ordenar_Columna_RecursosAsignados()
                Cargar_Datos_Solicitados(_NCSOTR_1)
                Cargar_Detalle_Solicitud(_NCSOTR_1)
            Case 1
                Cargar_Datos_Solicitados(_NCSOTR_1)
            Case 3
                'Ordenar_Columna_RecursosAsignados()
                Cargar_Detalle_Solicitud(_NCSOTR_1)
                If _OPCION = 2 Then Me.dtgRecursosAsignados.Columns("DETASIG").Visible = True
        End Select

    End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click
        Try
            If Me.txtCliente.pCodigo = 0 Then
                MsgBox("Debe de seleccionar el cliente para buscar las ordenes de servicio relacionadas")
                Exit Sub
            End If
            gintEstado = 0
            Dim objFormBuscarOrdenServicio As New frmBuscarOrdenServicio

            gintEstado = -1
            objFormBuscarOrdenServicio.CCMPN = Me.CCMPN
            objFormBuscarOrdenServicio.CDVSN = Me._CDVSN
            objFormBuscarOrdenServicio.CPLNDV = Me._CPLNDV
            objFormBuscarOrdenServicio.CodigoCliente = Me.txtCliente.pCodigo
          
            objFormBuscarOrdenServicio.StartPosition = FormStartPosition.CenterParent
            If objFormBuscarOrdenServicio.ShowDialog() = DialogResult.OK Then
                Dim objEntidad As New Solicitud_Transporte
                objEntidad.CCMPN = Me.CCMPN
                objEntidad.CDVSN = Me._CDVSN
                objEntidad.CPLNDV = Me._CPLNDV
                objEntidad.CCLNT = Me.txtCliente.pCodigo
                objEntidad.CTPOVJ = Me.pCTPOVJ
                objEntidad.NOPRCN = Me.pNOPRCN
                objEntidad.NORSRT = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
                objEntidad.CLCLOR = Convert.ToDouble(objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR)
                objEntidad.CLCLDS = Convert.ToDouble(objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS)

                Dim objSolicitudLogica As New Solicitud_Transporte_BLL
                Dim Resultado As String = objSolicitudLogica.Valida_Moneda_Sollicitud(objEntidad)
                If (Resultado <> "") Then
                    MessageBox.Show(Resultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                '----- Fin -----

                Select Case _TipoOperacion
                    Case 0, 1
                      
                        txt_localidad_origen.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
                        txt_localidad_destino.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

                        txt_localidad_origen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.TCMLCL_O
                        txt_localidad_destino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.TCMLCL_D

                    

                        txtOrdenServicio.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
                    Case 2, 4
                       
                        txt_localidad_origen.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLOR
                        txt_localidad_destino.Tag = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CLCLDS

                        txt_localidad_origen.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.TCMLCL_O
                        txt_localidad_destino.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.TCMLCL_D


                        txtOrdenServicio.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.NORSRT
                        txtTipoServicio.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTPOSR
                        ctbMercaderias.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CMRCDR
                        'txtUnidadMedida.Codigo = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD
                        txtUnidadMed.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CUNDMD

                        txtCantidadMercaderia.Text = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.QMRCDR
                        ucTipoCarga.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTIPCG
                        ucNivelServ.Valor = objFormBuscarOrdenServicio.objOrdenServicioTransporteBE.CTTRAN
                End Select

            End If

           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnLimpiarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarOS.Click
        Me.txtOrdenServicio.Text = ""

        txt_localidad_origen.Text = ""
        txt_localidad_origen.Tag = "0"

        txt_localidad_destino.Tag = "0"
        txt_localidad_destino.Text = ""
        Me.txtDireccionLocalidadCarga.Text = ""
        Me.txtDireccionLocalidadEntrega.Text = ""
    End Sub

    Private Sub dtgRecursosAsignados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellDoubleClick
        Try
            If e.RowIndex < 0 Then
                Exit Sub
            End If
            Dim ColName As String = ""
            ColName = dtgRecursosAsignados.Columns(e.ColumnIndex).Name
            If ColName = "UBICACION" Then

                If Me.dtgRecursosAsignados.Item("SEGUIMIENTO", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then

                    Dim objGpsBrowser As New frmMapa
                    With objGpsBrowser
                       
                        .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT", e.RowIndex).Value
                        .Longitud = Me.dtgRecursosAsignados.Item("GPSLON", e.RowIndex).Value
                        .Fecha = Me.dtgRecursosAsignados.Item("FECGPS", e.RowIndex).Value
                        .Hora = dtgRecursosAsignados.Item("HORGPS", e.RowIndex).Value
                        .WindowState = FormWindowState.Maximized
                        .ShowForm(.Latitud, .Longitud, Me)
                    End With
                End If
            End If
            Dim hash As New Hashtable()
            hash("CCMPN") = CCMPN.ToString()
         
            If ColName = "NPLCUN" Then Informacion_Detallada_Transportista(1, Me.dtgRecursosAsignados.Item("NPLCUN", e.RowIndex).Value, hash)
            If ColName = "NPLCAC" Then Informacion_Detallada_Transportista(2, Me.dtgRecursosAsignados.Item("NPLCAC", e.RowIndex).Value, hash)
            If ColName = "CBRCNT" Then Informacion_Detallada_Transportista(3, Me.dtgRecursosAsignados.Item("CBRCNT", e.RowIndex).Value, hash)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Metodos"

   

    Private Sub Cargar_Datos_Solicitados(ByVal lp_NroSolicitud As String)

        Dim objEntidad As New ENTIDADES.Operaciones.Solicitud_Transporte
        Dim objSolicitudTransporte As New NEGOCIO.Operaciones.Solicitud_Transporte_BLL

        objEntidad.NCSOTR = lp_NroSolicitud
        objEntidad.CCMPN = Me.CCMPN
        objEntidad = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidad)


        Me.Codigo.Text = lp_NroSolicitud
        Me.txtOrdenServicio.Text = objEntidad.NORSRT
        Me.txtCliente.pCargar(objEntidad.CCLNT)
        Me.dtpFechaSolicitud.Text = HelpClass.CNumero_a_Fecha(objEntidad.FECOST)
        'Me.ctlLocalidadOrigen.Codigo = objEntidad.CLCLOR
        txt_localidad_origen.Tag = objEntidad.CLCLOR
        txt_localidad_origen.Text = objEntidad.CLCLOR_D

        Me.txtDireccionLocalidadCarga.Text = objEntidad.TDRCOR
        'Me.ctlLocalidadDestino.Codigo = objEntidad.CLCLDS
        Me.txt_localidad_destino.Tag = objEntidad.CLCLDS
        txt_localidad_destino.Text = objEntidad.CLCLDS_D
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
        Me.txtHoraCarga.Text = HelpClass.CompletarCadena(objEntidad.HINCIN, 6, "0", HorizontalAlignment.Right)
        Me.txtHoraEntrega.Text = HelpClass.CompletarCadena(objEntidad.HRAENT, 6, "0", HorizontalAlignment.Right)
        Me.cmbTipoSolicitud.SelectedValue = objEntidad.SFCRTV
        Me.cboMedioTransporte.SelectedValue = objEntidad.CMEDTR
        Me.txtCentroCostoCliente.Text = objEntidad.CCTCSC
        Me.txtUsuarioSolicitante.Text = objEntidad.TRFRN
        Me.ucNivelServ.Valor = objEntidad.CTTRAN
        'Me.ucTipoCarga.ValueMember = objEntidad.CTIPCG
        Me.ucTipoCarga.Valor = objEntidad.CTIPCG.Trim
        'Pintando los datos de cabecera
        'Catch : End Try

    End Sub

   
    Public Sub Lista_Unidades_Asignadas(ByVal lp_NroSolicitud As String)

        Dim objEntidad As New ClaseGeneral
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL


        objEntidad.NCSOTR = lp_NroSolicitud
        objEntidad.CCMPN = Me.CCMPN
        Dim oListUnidades As New List(Of ClaseGeneral)
        oListUnidades = objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)
        dtgRecursosAsignados.DataSource = oListUnidades
        
    End Sub

    Private Sub Cargar_Detalle_Solicitud(ByVal lp_NroSolicitud As String)
        Dim dwvrow As DataGridViewRow
        Dim objEntidad As New ClaseGeneral
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL


        objEntidad.NCSOTR = lp_NroSolicitud
        objEntidad.CCMPN = Me.CCMPN
        Dim oListUnidades As New List(Of ClaseGeneral)
        oListUnidades = objSolicitudTransporte.Obtener_Detalle_Solicitud_Asignada(objEntidad)
        Dim FilaReg As Integer = 0
        For Each obj_Entidad As ClaseGeneral In oListUnidades
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgRecursosAsignados)
            Me.dtgRecursosAsignados.Rows.Add(dwvrow)
            FilaReg = dtgRecursosAsignados.Rows.Count - 1

            dtgRecursosAsignados.Rows(FilaReg).Cells("SEGUIMIENTO").Value = obj_Entidad.SEGUIMIENTO
            dtgRecursosAsignados.Rows(FilaReg).Cells("NCSOTR").Value = obj_Entidad.NCSOTR
            dtgRecursosAsignados.Rows(FilaReg).Cells("NCRRSR").Value = obj_Entidad.NCRRSR
            dtgRecursosAsignados.Rows(FilaReg).Cells("NPLNJT").Value = obj_Entidad.NPLNJT
            dtgRecursosAsignados.Rows(FilaReg).Cells("NCRRPL").Value = obj_Entidad.NCRRPL
            dtgRecursosAsignados.Rows(FilaReg).Cells("NRUCTR").Value = obj_Entidad.NRUCTR
            dtgRecursosAsignados.Rows(FilaReg).Cells("NPLCUN").Value = obj_Entidad.NPLCUN
            dtgRecursosAsignados.Rows(FilaReg).Cells("NPLCAC").Value = obj_Entidad.NPLCAC
            dtgRecursosAsignados.Rows(FilaReg).Cells("CBRCNT").Value = obj_Entidad.CBRCND
            dtgRecursosAsignados.Rows(FilaReg).Cells("CBRCND").Value = obj_Entidad.CBRCNT
            dtgRecursosAsignados.Rows(FilaReg).Cells("FASGTR").Value = obj_Entidad.FASGTR
            dtgRecursosAsignados.Rows(FilaReg).Cells("HASGTR").Value = obj_Entidad.HASGTR
            dtgRecursosAsignados.Rows(FilaReg).Cells("FATALM").Value = obj_Entidad.FATALM
            dtgRecursosAsignados.Rows(FilaReg).Cells("HATALM").Value = obj_Entidad.HATALM
            dtgRecursosAsignados.Rows(FilaReg).Cells("FSLALM").Value = obj_Entidad.FSLALM
            dtgRecursosAsignados.Rows(FilaReg).Cells("HSLALM").Value = obj_Entidad.HSLALM
            dtgRecursosAsignados.Rows(FilaReg).Cells("NGUITR").Value = obj_Entidad.NGUITR
            dtgRecursosAsignados.Rows(FilaReg).Cells("SESPLN").Value = obj_Entidad.SESPLN
            dtgRecursosAsignados.Rows(FilaReg).Cells("GPSLAT").Value = obj_Entidad.GPSLAT
            dtgRecursosAsignados.Rows(FilaReg).Cells("GPSLON").Value = obj_Entidad.GPSLON
            dtgRecursosAsignados.Rows(FilaReg).Cells("FECGPS").Value = obj_Entidad.FECGPS
            dtgRecursosAsignados.Rows(FilaReg).Cells("HORGPS").Value = obj_Entidad.HORGPS

            If obj_Entidad.HORGPS <> "" Then
                dtgRecursosAsignados.Rows(FilaReg).Cells("UBICACION").Value = My.Resources.button_ok1
            Else
                dtgRecursosAsignados.Rows(FilaReg).Cells("UBICACION").Value = My.Resources.Nada_1
            End If
            dtgRecursosAsignados.Rows(FilaReg).Cells("NOPRCN").Value = obj_Entidad.NOPRCN
            dtgRecursosAsignados.Rows(FilaReg).Cells("CBRCN2").Value = obj_Entidad.CBRCN2
            dtgRecursosAsignados.Rows(FilaReg).Cells("NORINS").Value = obj_Entidad.NORINSS
            dtgRecursosAsignados.Rows(FilaReg).Cells("NPLNMT").Value = obj_Entidad.NPLNMT
            dtgRecursosAsignados.Rows(FilaReg).Cells("MODIFICAR").Value = ImageList1.Images.Item(0)
            dtgRecursosAsignados.Rows(FilaReg).Cells("TCMTRT").Value = obj_Entidad.TCMTRT
            If obj_Entidad.NGUITR <> 0 Then
                dtgRecursosAsignados.Rows(FilaReg).Cells("SEGUIMIENTO").Value = ""
                dtgRecursosAsignados.Rows(FilaReg).Cells("UBICACION").Value = My.Resources.EnBlanco
            End If

            dtgRecursosAsignados.Rows(FilaReg).Cells("CTRMNC").Value = obj_Entidad.CTRMNC
            dtgRecursosAsignados.Rows(FilaReg).Cells("CUNDMD_DESC").Value = obj_Entidad.CUNDMD_DESC
            dtgRecursosAsignados.Rows(FilaReg).Cells("CPLNDV_DESC").Value = obj_Entidad.CPLNDV_DESC


           
        Next

    End Sub

    Private Sub Cargar_Combo()
        Dim obj_Logica_Localidad As New NEGOCIO.Localidad_BLL
        Dim obj_Logica_Carroceria As New NEGOCIO.mantenimientos.TipoCarroceria_BLL
        Dim obj_Logica_Transporte As New NEGOCIO.mantenimientos.Transportista_BLL
        Dim obj_Logica_Servicio As New NEGOCIO.mantenimientos.ServicioTransporte_BLL
        Dim obj_Entidad_Servicio As New ENTIDADES.mantenimientos.ServicioTransporte
        Dim obj_Logica_Mercaderia As New NEGOCIO.mantenimientos.MercaderiaTransportes_BLL
        Dim obj_Entidad_Mercaderia As New ENTIDADES.mantenimientos.MercaderiaTransportes
        Dim obj_Logica_Unidad As New NEGOCIO.UnidadMedida_BLL
        
        'Cargando los CodeTextBox del Display de Solicitud de Transporte
        obj_Entidad_Mercaderia.CCMPN = Me.CCMPN
        With Me.ctbMercaderias
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Mercaderia.Listar_MercaderiaTransportes(obj_Entidad_Mercaderia)) 'CType(MainModule.gobj_TablasGeneralesdelSistema("MERCADERIA"), DataTable).Copy()
            .KeyField = "CMRCDR"
            .ValueField = "TCMRCD"
            .DataBind()
        End With

        Dim objTipoCarroceria As New NEGOCIO.mantenimientos.TipoCarroceria_BLL
        With Me.ctlTipoVehiculo
            .DataSource = HelpClass.GetDataSetNative(objTipoCarroceria.Listar_TipoCarroceria(_CCMPN))
            .KeyField = "CTPCRA"
            .ValueField = "TCMCRA"
            .DataBind()
        End With
        obj_Entidad_Servicio.CCMPN = Me.CCMPN
        With Me.txtTipoServicio
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_Servicio.Listar_ServicioTransporte(obj_Entidad_Servicio)) 'CType(MainModule.gobj_TablasGeneralesdelSistema("SERVICIO"), DataTable).Copy()
            .KeyField = "CTPOSR"
            .ValueField = "TCMTPS"
            .DataBind()
        End With
        'Dim dt As DataTable = obj_Logica_Localidad.Listar_Localidades_Combo(Me.CCMPN)
        'With Me.ctlLocalidadOrigen
        '    .DataSource = dt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        '    .KeyField = "CLCLD"
        '    .ValueField = "TCMLCL"
        '    .DataBind()
        'End With

        'With Me.ctlLocalidadDestino
        '    .DataSource = dt.Copy 'CType(MainModule.gobj_TablasGeneralesdelSistema("LOCALIDADES"), DataTable).Copy()
        '    .KeyField = "CLCLD"
        '    .ValueField = "TCMLCL"
        '    .DataBind()
        'End With

        'With Me.txtUnidadMedida
        '    .DataSource = obj_Logica_Unidad.Listar_Unidad_Medida_Combo(Me.CCMPN) 'CType(MainModule.gobj_TablasGeneralesdelSistema("UNIDAD"), DataTable)
        '    .KeyField = "CUNDMD"
        '    .ValueField = "TCMPUN"
        '    .DataBind()
        'End With

        Carga_MedioTransporte()
        Me.Cargar_TipoCarga()
        Cargar_NivelTransporte()
       
    End Sub

    Private Function TipoSolicitud()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("NOM")

        Dim oDr As DataRow

        oDr = oDt.NewRow
        oDr.Item(0) = "I"
        oDr.Item(1) = "IDA"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "R"
        oDr.Item(1) = "RETORNO"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "V"
        oDr.Item(1) = "IDA y RETORNO"
        oDt.Rows.Add(oDr)
        Return oDt

    End Function

    Private Sub Carga_TipoSolicitud()
        Me.cmbTipoSolicitud.DataSource = TipoSolicitud()
        Me.cmbTipoSolicitud.ValueMember = "COD"
        Me.cmbTipoSolicitud.DisplayMember = "NOM"
    End Sub

    Private Sub Carga_MedioTransporte()
        Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
        Me.cboMedioTransporte.DataSource = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(_CCMPN)
        Me.cboMedioTransporte.ValueMember = "CMEDTR"
        Me.cboMedioTransporte.DisplayMember = "TNMMDT"
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

End Class
