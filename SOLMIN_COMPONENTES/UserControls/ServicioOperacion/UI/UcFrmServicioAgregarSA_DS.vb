Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Web
'Imports SOLMIN_CTZ.NEGOCIO


Public Class UcFrmServicioAgregarSA_DS
    Private _codigoDireccionServicio As Decimal
    Public Property codigoDireccionServicio() As Decimal
        Get
            Return _codigoDireccionServicio
        End Get
        Set(ByVal value As Decimal)
            _codigoDireccionServicio = value
        End Set
    End Property

#Region "Propiedades"
    Private bolBuscar As Boolean = False

    ''' <summary>
    ''' Variable
    ''' </summary>
    ''' <remarks></remarks>
    Private _oServicio As Servicio_BE
    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property

    Private olServicio As New List(Of Servicio_BE)
    Private estatico As New Estaticos
    Private oDtListaPorServicio As New DataTable
    Private oServicioOpeNeg As New clsServicio_BL
    Private bolDiferenteLote As Boolean = True
    Private bolLoteBulto As Boolean = True
    Private _CDREF As String = ""
    Private _ConsistenciaFac As Boolean
    Public Property ConsistenciaFac() As Boolean
        Get
            Return _ConsistenciaFac
        End Get
        Set(ByVal value As Boolean)
            _ConsistenciaFac = value
        End Set
    End Property
    Public strNrOperacion_ As Decimal = 0

    '<[AHM]>
    Public pCodigoCompania As String = ""
    '</[AHM]>
    Private ClienteFactTemp As Integer = 0
    Private AccesoModif_OPValorizada As Boolean = True
#End Region

#Region "Eventos"
    ''' <summary>
    ''' Inicializa la ventana principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub UcFrmServicioAgregarSA_DS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(_oServicio.CCLNT, _oServicio.PSUSUARIO)
        UcClienteOperacion.pCargar(ClientePK)

        ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(_oServicio.CCLNFC, _oServicio.PSUSUARIO)
        ucClienteFacturar.pCargar(ClientePK)
        ClienteFactTemp = _oServicio.CCLNFC  'JM

        Select Case _oServicio.CDVSN
            Case "R"
                Select Case oServicio.STPODP
                    Case Comun.eTipoAlmacen.AlmTransito
                        Me.dtgMercaderia.Visible = False
                        Me.dtgEmbarque.Visible = False
                        Me.dtgBultos.Visible = True
                        dtgBultos.Dock = DockStyle.Fill
                        Me.dtgBultos.AutoGenerateColumns = False
                        cmbTerminoBusquedaDS.Visible = False
                        Me.cmbTerminoBusquedaSIL.Visible = False
                        Me.cmbTerminoBusquedaSAT.Visible = True
                        rbOperacion.Checked = True
                    Case Comun.eTipoAlmacen.DepAutorizado, Comun.eTipoAlmacen.DepSimple
                        Me.dtgBultos.Visible = False
                        Me.dtgEmbarque.Visible = False
                        Me.dtgMercaderia.Visible = True
                        dtgMercaderia.Dock = DockStyle.Fill
                        dtgMercaderia.AutoGenerateColumns = False
                        Me.dtgBultos.AutoGenerateColumns = True
                        cmbTerminoBusquedaDS.Visible = True
                        Me.cmbTerminoBusquedaSIL.Visible = False
                        Me.cmbTerminoBusquedaSAT.Visible = False
                        cmbTipoServicio.Enabled = False

                End Select
            Case "S"
                KryptonHeaderGroup3.ValuesSecondary.Heading = "Embarque"
                Me.dtgMercaderia.Visible = False
                Me.dtgEmbarque.Visible = True
                Me.dtgBultos.Visible = False
                dtgEmbarque.Dock = DockStyle.Fill
                Me.dtgEmbarque.AutoGenerateColumns = False
                cmbTerminoBusquedaDS.Visible = False
                Me.cmbTerminoBusquedaSIL.Visible = True
                Me.cmbTerminoBusquedaSAT.Visible = False

            Case Else
                KryptonHeaderGroup3.ValuesSecondary.Heading = "Embarque"
                Me.dtgMercaderia.Visible = False
                Me.dtgEmbarque.Visible = False
                Me.dtgBultos.Visible = False
                dtgEmbarque.Dock = DockStyle.Fill
                Me.dtgEmbarque.AutoGenerateColumns = False
                cmbTerminoBusquedaDS.Visible = False
                Me.cmbTerminoBusquedaSIL.Visible = False
                Me.cmbTerminoBusquedaSAT.Visible = False


        End Select
        CargarPlanta()
        cargaProceso()
        CargarCampos()
        rbOperacion.Checked = True
        Dim sProceso As String = _oServicio.CTPALJ
        Dim oDtProceso As New DataTable
        oDtProceso = oServicioOpeNeg.ListaServiciosEsp(_oServicio.CDVSN, 1)
        If _oServicio.TIPO = Comun.ESTADO_Modificado Then
            oDtProceso.DefaultView.RowFilter = "CCMPRN = '" & _oServicio.CTPALJ & "'"
            oDtProceso = oDtProceso.DefaultView.ToTable
            Me.cmbTipoServicio.DataSource = oDtProceso
            Me.cmbTipoServicio.ValueMember = "CCMPRN"
            Me.cmbTipoServicio.DisplayMember = "TDSDES"

            Me.cmbPlanta.SelectedValue = _oServicio.CPLNDV
            Me.txtReferencia.Text = _oServicio.TRFSRC
            CargarTarifaServicio()
            If _oServicio.FLGPEN = "S" Then
                Me.ucClienteFacturar.Enabled = False
            End If
            Me.cmbTipoServicio.Enabled = False
            Me.cmbProceso.Enabled = False

            cmbPlanta.Enabled = False

        Else
            '===Carga los Servicios Especiales===
            oDtProceso.DefaultView.RowFilter = "SMARCA >= 0 AND NOT SMARCA IN (4)"
            oDtProceso = oDtProceso.DefaultView.ToTable
            Me.cmbTipoServicio.DataSource = oDtProceso
            Me.cmbTipoServicio.ValueMember = "CCMPRN"
            Me.cmbTipoServicio.SelectedValue = sProceso
            bolBuscar = True
            Me.cmbTipoServicio.DisplayMember = "TDSDES"

        End If
        If _oServicio.CDVSN = "S" Then
            cmbTipoServicio.Enabled = False
            cmbProceso.Enabled = False
            If Not Me.oServicio.NORSCI.ToString.Equals("0") Then
                If oServicio.CTPALJ = estatico.E_ESP_Adicional Then
                    txtCodigo.Enabled = False
                    btnAgregarTermino.Visible = False
                    BtnEliminarTermino.Visible = False
                    rbNinguno.Enabled = False
                    rbServicio.Enabled = False
                End If
            End If
        End If
        _oServicio.CTPALJ = sProceso

        'If _ConsistenciaFac = True Then
        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
            InHabilitarControlesConsistenciaFac()
        End If
        'End If
        If _oServicio.TIPO = Comun.ESTADO_Nuevo Then
            CargarDirServicioXDefecto()
        End If

        ' validar si será posible adicionar/modificar/eliminar
   

    End Sub


    



    ''' <summary>
    ''' Se ejecuta cuando el dato se la planta seleccionado cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            Me.dtgBultos.Rows.Clear()
        End If


    End Sub

    ''' <summary>
    ''' Se ejecuta cuando se selecciona al cliente de la operación
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UcClienteOperacion_InformationChanged() Handles UcClienteOperacion.InformationChanged
        oServicio.CCLNT = UcClienteOperacion.pCodigo
        If (UcClienteOperacion.pCodigo <> 0) Then
            Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(UcClienteOperacion.pCodigo, ConfigurationWizard.UserName)
            ucClienteFacturar.pCargar(ClientePK)
            Me.dtgBultos.Rows.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Selecciona informacion del cliente a facturar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ucClienteFacturar_InformationChanged() Handles ucClienteFacturar.InformationChanged
        oServicio.CCLNFC = ucClienteFacturar.pCodigo

        'JM
        Dim msj As String = ValidarClientes()
        If msj.Trim.Length > 0 Then
            MessageBox.Show(msj, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ucClienteFacturar.pClear()
            ucClienteFacturar.Focus()
            Exit Sub
        End If


        '<[AHM]>
        'SI LA COMPAÑIA PERTENECE A SALMON SE APLICA CON LAS SIGUIENTES VALIDACIONES
        If (Not (New clsCliente_BL).PerteneceASalmon(Me.pCodigoCompania)) Then
            Exit Sub
        End If
        'SI TIENE SERVICIOS PARA REGISTRAR Y EL NEGOCIO DE LOS CLIENTES SON DIFERENTES SE ELIMINAN LOS SERVICIOS
        If (dgServicio.RowCount > 0) Then
            If (UcClienteOperacion.pNegocio <> ucClienteFacturar.pNegocio) Then
                If (MessageBox.Show("Si cambia de Cliente a Facturar se eliminaran los servicios existentes, ¿desea continuar?", _
                                    "Servicios", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                    dgServicio.DataSource = Nothing
                    dgServicio.Rows.Clear()
                Else
                    'ucClienteFacturar.pClear()
                    Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(ClienteFactTemp, _oServicio.PSUSUARIO)
                    ucClienteFacturar.pCargar(ClientePK)
                    'ucClienteFacturar.Focus()
                End If
            End If
        End If
        '</[AHM]>


    End Sub

    ''' <summary>
    ''' Guardar la información y se genera el nr. de la operación
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Realiza la consulta cuando hace enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If oServicio.CCLNT = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            'If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "" OrElse cmbTerminoBusquedaSIL.Text <> "") And txtCodigo.Text <> "" Then
            Select Case _oServicio.CDVSN
                Case "S"
                    If cmbTerminoBusquedaSIL.Text <> "" And txtCodigo.Text <> "" Then
                        BuscarSustentoSIL()
                    End If
                Case "R"
                    If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "") And txtCodigo.Text <> "" Then
                        If _oServicio.STPODP = "7" Then
                            BuscarBultos()
                        Else
                            BuscarSolicituServicio()
                        End If
                    End If
            End Select

        End If
    End Sub

#End Region

#Region "Metodos"
    ''' <summary>
    ''' Cargar Proceso
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargaProceso()
        Dim oServicioBL As New clsServicio_BL
        cmbProceso.DataSource = oServicioBL.Listar_TablaAyuda_L01("TIPROC")
        cmbProceso.ValueMember = "CCMPRN"
        cmbProceso.DisplayMember = "TDSDES"
        If oServicio.STIPPR <> "" Then
            cmbProceso.SelectedValue = oServicio.STIPPR
        End If
    End Sub

    Private Sub CargarCampos()
        Select Case _oServicio.CDVSN
            Case "R"
                If oServicio.STPODP = "7" Then
                    If Not Me.oServicio.CREFFW.Trim.Equals("") OrElse Not oServicio.NRGUSA.ToString.Equals("0") Then
                        Me.cmbProceso.SelectedValue = _oServicio.STIPPR
                        CargarBultos(_oServicio)
                    End If
                Else
                    If Not Me.oServicio.NGUIRN.ToString.Equals("0") Then
                        Me.cmbProceso.SelectedValue = _oServicio.STIPPR
                        BuscarOS(_oServicio)
                    End If
                End If
            Case "S"
                If Not Me.oServicio.NORSCI.ToString.Equals("0") Then
                    Me.cmbProceso.SelectedValue = _oServicio.STIPPR
                    _oServicio.PSBUSQUEDA = "E"
                    BuscarEmbarque(_oServicio)
                    If oServicio.CTPALJ = estatico.E_ESP_Adicional Then
                        txtCodigo.Enabled = False
                        btnAgregarTermino.Visible = False
                        BtnEliminarTermino.Visible = False
                        rbNinguno.Enabled = False
                        rbServicio.Enabled = False
                    End If
                End If
        End Select

    End Sub

    ''' <summary>
    ''' Carga Planta
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarPlanta()
        Dim oPlanta As New clsPlantaNeg
        bolBuscar = False
        oPlanta.Crea_Lista(_oServicio.PSUSUARIO)
        cmbPlanta.DataSource = oPlanta.Lista_Planta(_oServicio.CCMPN, _oServicio.CDVSN)
        cmbPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        If oServicio.CPLNDV <> 0 Then
            cmbPlanta.SelectedValue = _oServicio.CPLNDV
        Else
            cmbPlanta.SelectedValue = 1
        End If
        cmbPlanta.DisplayMember = "TPLNTA"
        cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Guardar()

        ' Rutinas de Validación
        If Not fblnValidar() Then
            Exit Sub
        End If

        Dim msgContinuar As String = ""
        If Not rbNinguno.Checked Then
            Select Case _oServicio.CDVSN
                Case "R"
                    If (_oServicio.STPODP = "7" And Me.dtgBultos.Rows.Count = 0 And _oServicio.CTPALJ <> "RE") Then
                        msgContinuar = "No hay ningún bulto asignado, Desea Continuar Guardando la operación? "
                    End If
                    If (_oServicio.STPODP = "1" And Me.dtgMercaderia.Rows.Count = 0) Then
                        msgContinuar = "No hay ningún orden de servicio asignado, Desea Continuar Guardando la operación? "
                    End If

                Case "S"
                    If Me.dtgEmbarque.Rows.Count = 0 Then
                        msgContinuar = "No hay ningún orden de servicio asignado, Desea continuar guardando la operación? "
                    End If
            End Select

        End If

        If msgContinuar.Length > 0 Then
            If MessageBox.Show(msgContinuar, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

     
        

        'Select Case _oServicio.CDVSN
        '    Case "R"
        '        If (_oServicio.STPODP = "7" And Me.dtgBultos.Rows.Count = 0 And _oServicio.CTPALJ <> "RE") Then
        '            If Not rbNinguno.Checked Then
        '                If MsgBox("No hay ningún bulto asignado, Desea Continuar Guardando la operación? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '                    Exit Sub
        '                End If
        '            End If
        '        End If
        '        If (_oServicio.STPODP = "1" And Me.dtgMercaderia.Rows.Count = 0) Then
        '            If Not rbNinguno.Checked Then
        '                If MsgBox("No hay ningún orden de servicio asignado, Desea Continuar Guardando la operación? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '                    Exit Sub
        '                End If
        '            End If
        '        End If

        '    Case "S"

        '        If Me.dtgEmbarque.Rows.Count = 0 And Not rbNinguno.Checked Then
        '            If MsgBox("No hay ningún orden de servicio asignado, Desea continuar guardando la operación? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '                Exit Sub
        '            End If
        '        End If

        'End Select


        ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
        Dim bStatusSalir As Boolean = False
        Dim strNrOperacion As String = ""
        Dim oServicioBL As New clsServicio_BL
        'Inserta o Actualiza la operacion
        With _oServicio
            .CCLNT = UcClienteOperacion.pCodigo
            .FOPRCN = Comun.FormatoFechaAS400(dteFechaOperacion.Text)
            .CCLNFC = ucClienteFacturar.pCodigo
            .CPLNDV = Me.cmbPlanta.SelectedValue
            .STIPPR = cmbProceso.SelectedValue
            .TRDCCL = Me.txtReferencia.Text
            .CDIRSE = _codigoDireccionServicio

            If .NOPRCN = 0 Then
                .TIPO = Comun.ESTADO_Nuevo
                .NOPRCN = oServicioBL.fdecInsertarOperacionFacturacionSA(oServicio)
                If .NOPRCN <> 0 Then
                    Me.hgTitulo.ValuesPrimary.Heading = "Nr. Operación : " & oServicio.NOPRCN.ToString
                    'Else
                    '    MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Information, "Validación")
                    '    Exit Sub
                End If
            Else
                _oServicio.SESTRG = "A"

                oServicioBL.fdecActualizarOperacionFacturacionSA(oServicio)

                'If oServicioBL.fdecActualizarOperacionFacturacionSA(oServicio) = 0 Then
                '    MsgBox("Error Comuníquese con el departamento de sistemas", MessageBoxIcon.Error)
                'End If
            End If
        End With

        '=================================
        'Inserta o Actualiza los Servicios

        For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
            With _oServicio
                .CCLNT = UcClienteOperacion.pCodigo
                .NRTFSV = Me.dgServicio.Rows(intCont).Cells("NRTFSV").Value
                .NCRROP = Val("" & Me.dgServicio.Rows(intCont).Cells("NCRROP").Value & "")
                .QATNAN = Val(Me.dgServicio.Rows(intCont).Cells("QATNAN").Value)
                .QATNRL = Val(Me.dgServicio.Rows(intCont).Cells("QATNRL").Value)
                .STIPPR = cmbProceso.SelectedValue

                If Val("" & Me.dgServicio.Rows(intCont).Cells("FINPRF").Value & "").ToString.Length > 1 Then
                    .FINPRF = Comun.FormatoFechaAS400(Me.dgServicio.Rows(intCont).Cells("FINPRF").Value)
                    .FFNPRF = Comun.FormatoFechaAS400(Me.dgServicio.Rows(intCont).Cells("FFNPRF").Value)
                End If


                .NORCML = Me.dgServicio.Rows(intCont).Cells("NORCML").Value 'OC
                .CCNTCS = Me.dgServicio.Rows(intCont).Cells("CCNTCS").Value 'OC
                .TCTCST = Me.dgServicio.Rows(intCont).Cells("TCTCST").Value 'CI
                .TSRVC = Me.dgServicio.Rows(intCont).Cells("TSRVC").Value 'OBSERVACION
                .TRFSRC = Me.dgServicio.Rows(intCont).Cells("TRFSRC").Value 'OBSERVACION
                .FATNSR = Comun.FormatoFechaAS400(Me.dgServicio.Rows(intCont).Cells("FATNSR").Value.ToString.Replace(" ", "")) 'Fecha del Servicio

                'JM
                .CENCO2 = Me.dgServicio.Rows(intCont).Cells("CENCO2").Value 'CENCO2
                .CENCOS = Me.dgServicio.Rows(intCont).Cells("CENCOS").Value 'CENCOS
                '.ISRVTI = Me.dgServicio.Rows(intCont).Cells("ISRVTI").Value 'ISRVTI

                If Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value = "0" Then  'Lote
                    .TLUGEN = ""
                Else
                    .TLUGEN = Me.dgServicio.Rows(intCont).Cells("TLUGEN").Value
                End If
                If rbNinguno.Checked Then
                    bStatusSalir = True
                End If


                Dim msgserv As String = ""
                Dim corr_servicio As Decimal = 0

                If .NCRROP = 0 Then
                    .TIPO = Comun.ESTADO_Nuevo
                    msgserv = oServicioBL.fdecInsertarServiciosFacturacionSA(oServicio, corr_servicio)
                    .NCRROP = corr_servicio

                    If msgserv.Length > 0 Then
                        MessageBox.Show(msgserv, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    '.NCRROP = oServicioBL.fdecInsertarServiciosFacturacionSA(oServicio)
                    'If .NCRROP = 0 Then
                    '    MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Information, "Validación")
                    '    Exit Sub
                    'Else
                    
                    Select Case _oServicio.CDVSN
                        Case "R"
                            If Not _oServicio.CTPALJ = estatico.E_ESP_Reembolso Then
                                If rbServicio.Checked Then
                                    bStatusSalir = GrabarBultosPorServicio(.NCRROP, intCont + 1)
                                End If
                            End If
                        Case "S"
                            If rbServicio.Checked Then
                                bStatusSalir = GrabarSustentoSILxServicio(.NCRROP, intCont + 1)
                            End If
                    End Select
                    'End If
                Else
                    _oServicio.SESTRG = "A"
                    Dim mssgUpd As String = ""
                    mssgUpd = oServicioBL.fdecInsertarServiciosFacturacionSA(oServicio, corr_servicio)
                    If mssgUpd.Length > 0 Then
                        MessageBox.Show(mssgUpd, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    'If oServicioBL.fintActualizarServiciosFacturacionSA(oServicio) = 0 Then
                    '    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                    '    Exit Sub
                    'Else
                    Select Case _oServicio.CDVSN
                        Case "R"
                            If Not _oServicio.CTPALJ = estatico.E_ESP_Reembolso And rbServicio.Checked Then bStatusSalir = ActualizaBultos(.NCRROP)
                        Case "S"
                            If rbServicio.Checked Then bStatusSalir = ActualizaEmbarques(.NCRROP)

                    End Select

                    'End If
                End If
            End With

            Select Case _oServicio.CDVSN
                Case "R"
                    Select Case oServicio.CTPALJ
                        Case estatico.E_ESP_Reembolso
                            Dim oReembolso As New ServicioReembolso_BE
                            ' Guardamos los Reembolsos RZSC24 por cada servicio
                            '--------------------------------------------------
                            '================================================
                            oReembolso.TOBSSR = Me.dgServicio.Rows(intCont).Cells("TOBSSR").Value
                            oReembolso.TPRVD = Me.dgServicio.Rows(intCont).Cells("TPRVD").Value
                            oReembolso.NRUCPR = Me.dgServicio.Rows(intCont).Cells("NRUCPR").Value
                            oReembolso.TPODOC = Me.dgServicio.Rows(intCont).Cells("TPODOC").Value
                            oReembolso.NUMDOC = Me.dgServicio.Rows(intCont).Cells("NUMDOC").Value
                            oReembolso.IMPFAC = Me.dgServicio.Rows(intCont).Cells("IMPFAC").Value
                            oReembolso.FCHDOC = Me.dgServicio.Rows(intCont).Cells("FCHDOC").Value
                            oReembolso.ITPCMT = Me.dgServicio.Rows(intCont).Cells("ITPCMT").Value
                            oReembolso.NGUITR = Me.dgServicio.Rows(intCont).Cells("NGUITR").Value
                            oReembolso.CTRMNC = Me.dgServicio.Rows(intCont).Cells("CTRMNC").Value

                            bStatusSalir = GrabarReembolsoDetalle(oReembolso)
                    End Select
            End Select
        Next

        '---------------------------------------------
        ' Rutinas para la Gestion de Detalle
        '---------------------------------------------

        Select Case _oServicio.CDVSN
            Case "R"
                Select Case oServicio.STPODP
                    Case "1"
                        Me.dtgMercaderia.EndEdit()
                        bStatusSalir = GrabarSolicitudServicio()

                    Case "7"
                        Select Case oServicio.CTPALJ
                            Case estatico.E_ESP_General, estatico.E_ESP_AlmacenajePeso, estatico.E_ESP_ManipuleoPeso, estatico.E_ESP_Permanencia
                                Me.dtgBultos.EndEdit()
                                If rbOperacion.Checked Then
                                    bStatusSalir = GrabarBultosOperacion()
                                Else
                                    bStatusSalir = True
                                End If
                        End Select
                End Select
            Case "S"
                If rbOperacion.Checked Then
                    bStatusSalir = GrabarSustentoSIL()
                End If

        End Select
        If Not bStatusSalir Then
            Exit Sub
        Else
            strNrOperacion = strNrOperacion & oServicio.NOPRCN & ". "
        End If

        If bStatusSalir Then
            MsgBox(Comun.Mensaje("MENSAJE.EXITO") & Chr(10) & " Nr. Operación: " & strNrOperacion, MessageBoxIcon.Information)
            strNrOperacion_ = oServicio.NOPRCN
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub
    Private Function GrabarReembolsoDetalle(ByVal oReembolso As ServicioReembolso_BE) As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim oServicioReembolso As New ServicioReembolso_BE
        Dim blnResultado As Boolean = True
        '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --- -- -- --
        ' Rutinas para registrar el Reembolso
        '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --- -- -- --
        With oServicioReembolso
            .CCLNT = UcClienteOperacion.pCodigo
            .NOPRCN = _oServicio.NOPRCN
            .NCRRDC = _oServicio.NCRROP 'Copiamos el correlativo del servicio al correlativo del reembolso - deben ser lo mismo
            .TOBSSR = oReembolso.TOBSSR
            .TPRVD = oReembolso.TPRVD
            .NRUCPR = oReembolso.NRUCPR
            .TPODOC = oReembolso.TPODOC
            .NUMDOC = oReembolso.NUMDOC
            .IMPFAC = oReembolso.IMPFAC
            .FCHDOC = oReembolso.FCHDOC
            .NGUITR = oReembolso.NGUITR
            .CTRMNC = oReembolso.CTRMNC
            .ITPCMT = oReembolso.ITPCMT
            .SESTRG = "A"
            .PSUSUARIO = oServicio.PSUSUARIO.Trim
        End With
        If oServicio.TIPO = Comun.ESTADO_Nuevo Then
            oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFactReembolsoSA(oServicioReembolso)
            If Not oServicio.PSERROR.Equals("") Then
                MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                blnResultado = False
            End If
        Else


            If oServicioBL.fintActualizarDetalleServiciosFactReembolsoSA(oServicioReembolso) = "0" Then
                MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                blnResultado = False
            End If

        End If
        Return blnResultado
    End Function


    ''' <summary>
    ''' Valida la información al guardar la operación
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnValidar() As Boolean
        Dim strErrr As String = ""
        If Me.cmbPlanta.SelectedValue Is Nothing Then
            strErrr = strErrr & "- Seleccione la planta " & Chr(10)
        End If
        If Me.dgServicio.Rows.Count = 0 Then
            strErrr = strErrr & "- Debe Agregar Servicios " & Chr(10)
        End If
        If Me.UcClienteOperacion.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione el cliente " & Chr(10)
        End If
        If Me.ucClienteFacturar.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione cliente a facturar" & Chr(10)
        End If

        Select Case _oServicio.CDVSN
            Case "S"
                If rbOperacion.Checked = True Then
                    If (dtgEmbarque.Rows.Count = 0) Then
                        strErrr = strErrr & "- Debe ingresar por lo menos un embarque. *" & Chr(10)
                    End If
                End If
        End Select

        'Dim oServicioBL As New clsServicio_BL 'ECM-HUNDRED-SOPORTE[180716]
        'If oServicioBL.Validar_Dirección_Servicio(_oServicio.CCMPN) Then   'ECM-HUNDRED-SOPORTE[180716]
        '    If _codigoDireccionServicio = 0 Then
        '        strErrr = strErrr & "- Seleccionar Dirección de Servicio" & Chr(10)
        '    End If
        'End If


        '<[AHM]>
        'SI LA COMPAÑIA PERTENECE A SALMON SE APLICA CON LAS SIGUIENTES VALIDACIONES

        'If (New clsCliente).PerteneceASalmon(Me.pCodigoCompania) Then
        '    'AMBOS CLIENTES DEBEN PERTENECER A LA MISMA REGION DE VENTA (NEGOCIO)
        '    If (UcClienteOperacion.pNegocio <> ucClienteFacturar.pNegocio) Then
        '        strErrr = strErrr & "- El Negocio de cliente a facturar no debe ser distinta al del cliente de la operación. *" & Chr(10)
        '    End If
        'End If
        '</[AHM]>

        If strErrr.Trim.Equals("") Then
            Return True
        Else
            MessageBox.Show(strErrr, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function

    ''' <summary>
    ''' Busca Solicitud de servicio por Nr. guia Ingreso, Nr. Guia Salida o Nr. Guia Proveedor
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarSolicituServicio()
        Dim oServicioAlmacen As New Servicio_BE
        With oServicioAlmacen
            .CCLNT = Me.UcClienteOperacion.pCodigo
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = cmbPlanta.SelectedValue
            Select Case Mid(cmbTerminoBusquedaDS.Text, 1, 1)
                Case "P"
                    .NGUICL = txtCodigo.Text.ToUpper
                Case "I"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.INGRESO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 1
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NGUIRN = intTemp
                        .CSRVC = 2
                    End If
            End Select
            txtCodigo.Text = ""
            txtCodigo.Focus()
        End With
        BuscarOS(oServicioAlmacen)
    End Sub

    ''' <summary>
    ''' Busca Orden de servicio 
    ''' </summary>
    ''' <param name="oServicioAlmacen"></param>
    ''' <remarks></remarks>
    Private Sub BuscarOS(ByVal oServicioAlmacen As Servicio_BE)
        Dim oServicioBL As New clsServicio_BL

        Dim dtTemp As DataTable = oServicioBL.fdtListaSolicitudDeServicioSDS(oServicioAlmacen)
        If Me.dtgMercaderia.DataSource Is Nothing And Not dtTemp Is Nothing Then
            dtTemp.Columns.Add("CPRCN1")
            dtTemp.Columns.Add("NSRCN1")
            dtTemp.Columns.Add("NCRRDC", GetType(String))
            Me.dtgMercaderia.DataSource = dtTemp
            lblItems.Text = dtTemp.Rows.Count.ToString
        ElseIf (Not dtTemp Is Nothing) Then
            For Each oDr As DataRow In dtTemp.Rows
                If Not fblnBuscarSolicitudServicio(oDr) Then
                    Dim oDrMercaderia As DataRow
                    oDrMercaderia = Me.dtgMercaderia.DataSource.NewRow
                    For intColumna As Integer = 0 To dtTemp.Columns.Count - 1
                        oDrMercaderia.Item(intColumna) = oDr.Item(intColumna)
                    Next
                    Me.dtgMercaderia.DataSource.Rows.Add(oDrMercaderia)

                    lblItems.Text = Val(lblItems.Text) + 1
                    dtgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgMercaderia.CurrentRow.Cells("CPRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    dtgMercaderia.CurrentRow.Cells("NSRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' Buscan  en o los bultos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuscarBultos()
        Dim oSerAlmacen As New Servicio_BE
        With oSerAlmacen
            .CCLNT = Me.UcClienteOperacion.pCodigo
            .NOPRCN = _oServicio.NOPRCN
            .CCMPN = _oServicio.CCMPN
            .CDVSN = _oServicio.CDVSN
            .CPLNDV = cmbPlanta.SelectedValue
            Select Case Mid(cmbTerminoBusquedaSAT.Text, 1, 1)
                Case "B"
                    .CREFFW = txtCodigo.Text.ToUpper
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.PALETA"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROPLT = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NROCTL = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        MsgBox(Comun.Mensaje("MENSAJE.VALIDA.DESPACHO"), MsgBoxStyle.Information)
                        Exit Sub
                    Else
                        .NRGUSA = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    Dim str_val As String = txtCodigo.Text.Trim.ToUpper
                    If str_val.Length <= 10 Then
                        If Not Int64.TryParse(str_val, intTemp) Then
                            'If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                            MsgBox(Comun.Mensaje("MENSAJE.VALIDA.GUIA"), MsgBoxStyle.Information)
                            Exit Sub
                            'Else
                            '    .NGUIRM = intTemp
                        End If
                        'Else
                        '.NGUIRM = intTemp
                    End If
                    .NGUIRS = str_val
                   
                Case "V"
                    .NGRPRV = txtCodigo.Text.ToUpper
            End Select
            CargarBultos(oSerAlmacen)
        End With

    End Sub

    Private Sub CargaEmbarqueOfServicio(ByVal oDt As DataTable)

        If Me.dtgEmbarque.DataSource Is Nothing And Not oDt Is Nothing Then
            dtgEmbarque.DataSource = oDt
        Else
            If oDt.Rows.Count > 0 Then
                DeleteDetalisEmbarque(oDt)
                Dim dr As DataRow = Nothing
                For Each dr In oDt.Rows

                    If Not fblnBuscarEmbarquesServicio(dr("NORSCI"), dr("NCRROP5")) Then
                        dtgEmbarque.DataSource.ImportRow(dr)
                    End If

                Next

            End If

        End If


    End Sub

    Private Sub CargaBultoOfServicio(ByVal mList As List(Of Servicio_BE), ByVal Estado As String)

        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then

            dtgBultos.Columns("NDIAPL").Visible = True
            dtgBultos.Columns("FINGAL").Visible = True
            dtgBultos.Columns("FSLDAL").Visible = True
        Else

            dtgBultos.Columns("NDIAPL").Visible = False
            dtgBultos.Columns("FINGAL").Visible = False
            dtgBultos.Columns("FSLDAL").Visible = False

        End If


        If _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso Or _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso _
        Or _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
            fblnDeleteRowsOperation(mList)
        End If
        Dim oDrVw As DataGridViewRow
        For Each obe As Servicio_BE In mList
            If Not fblnBuscarBultosServicio(obe.CREFFW.ToString.Trim, obe.NSEQIN.ToString.Trim, obe.NCRROP) Then

                oDrVw = New DataGridViewRow
                oDrVw.CreateCells(Me.dtgBultos)
                If Estado = Comun.ESTADO_Modificado Then Me.dtgBultos.Rows.Insert(0, oDrVw) Else Me.dtgBultos.Rows.Add(oDrVw)


                oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                With Me.dtgBultos

                    Dim pos As Integer = dtgBultos.Rows.Count - 1

                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CREFFW").Value = obe.CREFFW.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NCRRDC").Value = DBNull.Value
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("DESCWB").Value = obe.DESCWB.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TUBRFR").Value = obe.TUBRFR.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("QREFFW").Value = obe.QREFFW
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TIPBTO").Value = obe.TIPBTO.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("QPSOBL").Value = obe.QPSOBL
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TUNPSO").Value = obe.TUNPSO.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("QVLBTO").Value = obe.QVLBTO
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TUNVOL").Value = obe.TUNVOL.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("QAROCP").Value = obe.QAROCP
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("SESTRG").Value = obe.SESTRG.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NSRCN1").Value = obe.NSRCN1
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CPRCN1").Value = obe.CPRCN1
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CTPALM").Value = obe.CTPALM.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CALMC").Value = obe.CALMC.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("CZNALM").Value = obe.CZNALM.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NSEQIN").Value = obe.NSEQIN.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NCRROP3").Value = obe.NCRROP.ToString.Trim
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("SSNCRG").Value = Convert.ToString(obe.SSNCRG)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("SSNCRG_D").Value = Convert.ToString(obe.SSNCRG_D)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TLUGEN2").Value = Convert.ToString(obe.TLUGEN)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TCMZNA").Value = Convert.ToString(obe.TCMZNA)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TALMC").Value = Convert.ToString(obe.TALMC)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("TCMPAL").Value = Convert.ToString(obe.TCMPAL)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NCRRDC").Value = obe.NCRRDC
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("QPRDFC").Value = obe.QPRDFC
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NDIAPL").Value = obe.TOTALDIAS
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("FINGAL").Value = Convert.ToString(obe.FINGAL)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("FSLDAL").Value = Convert.ToString(obe.FSLDAL)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NGRPRV").Value = Convert.ToString(obe.NGRPRV)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NGUIRM").Value = Convert.ToString(obe.NGUIRM)
                    .Rows(IIf(Estado = Comun.ESTADO_Modificado, 0, pos)).Cells("NRGUSA").Value = Convert.ToString(obe.NRGUSA)


                End With
            Else
                'se actualiza los cnt que haya modificado
                For intIndice As Integer = 0 To dtgBultos.RowCount - 1
                    If obe.CREFFW.ToString.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim And _
                    obe.NSEQIN.ToString.Trim = CType(dtgBultos.Rows(intIndice).Cells("NSEQIN").Value.ToString.Trim, Decimal) And _
                    obe.NCRROP = Val("" & dtgBultos.Rows(intIndice).Cells("NCRROP3").Value & "") Then
                        dtgBultos.Rows(intIndice).Cells("NSRCN1").Value = obe.NSRCN1
                        dtgBultos.Rows(intIndice).Cells("CPRCN1").Value = obe.CPRCN1
                    End If
                Next
            End If
        Next
        Dim dt As New DataTable
        dt = CType(dtgBultos.DataSource, DataTable)


    End Sub

    Private Sub CargarBultos(ByVal oSerAlmacen As Servicio_BE)

        Dim oServicioBL As New clsServicio_BL
        Dim bolLote As Boolean = False
        Dim strMensaje As String = String.Empty

        If dgServicio.RowCount = 0 Then
            MsgBox("Debe agregar un servicio", MsgBoxStyle.Information, "Información")
            Exit Sub

        End If
        Dim dtTemp As DataTable = oServicioBL.fdtListaBultoFacturarSA(oSerAlmacen)

        If Not oSerAlmacen.PSERROR.Trim.Equals("") Then
            MsgBox(oSerAlmacen.PSERROR, MsgBoxStyle.Information, "Información")
        End If



        For i As Integer = 0 To dtTemp.Rows.Count - 1
            bolLote = flValidaLote(dtTemp.Rows(i).Item("TLUGEN").ToString.Trim, strMensaje)
            If bolLote Then Exit For
        Next

        If Not bolLote And dtTemp.Rows.Count > 0 Then
            If MessageBox.Show(strMensaje, "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                bolLoteBulto = False
            End If
        End If


        Dim dtWayBill As DataTable
        Dim oDrVw As DataGridViewRow
        ' Si el proceso devolvió items, se ingresa a la tabla de Bultos
        If dtTemp.Rows.Count > 0 Then
            Dim dwFila As DataRow
            dtWayBill = dtTemp.Clone
            For Each dwFila In dtTemp.Rows
                If cmbProceso.SelectedValue = "R" Then
                    If dwFila.Item("CBLTOR").ToString.Trim <> "" Then Continue For
                End If
                If Not fblnBuscarBulto(dwFila.Item("CREFFW").ToString.Trim, dwFila.Item("NSEQIN").ToString.Trim) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgBultos)

                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgBultos.Rows.Insert(0, oDrVw)
                    With Me.dtgBultos

                        .Rows(0).Cells("CREFFW").Value = dwFila.Item("CREFFW").ToString.Trim
                        .Rows(0).Cells("NCRRDC").Value = DBNull.Value
                        .Rows(0).Cells("DESCWB").Value = dwFila.Item("DESCWB").ToString.Trim
                        .Rows(0).Cells("TUBRFR").Value = dwFila.Item("TUBRFR").ToString.Trim


                        If cmbProceso.SelectedValue = "R" Then
                            .Rows(0).Cells("QREFFW").Value = dwFila.Item("QREFBO") 'Cantidad de Bulto Origen
                            .Rows(0).Cells("QPSOBL").Value = dwFila.Item("QPSOBO") 'Peso Bultos Origen      
                            .Rows(0).Cells("QVLBTO").Value = dwFila.Item("QVOLBO") 'Volumen del Bulto Origen 
                            .Rows(0).Cells("QAROCP").Value = dwFila.Item("QAROBO") 'Cant.Area Origen   
                        Else
                            .Rows(0).Cells("QREFFW").Value = dwFila.Item("QREFFW") 'Cantidad recibida por el Freight Forward
                            .Rows(0).Cells("QPSOBL").Value = dwFila.Item("QPSOBL") 'Peso Bultos
                            .Rows(0).Cells("QVLBTO").Value = dwFila.Item("QVLBTO") 'Volumen del Bulto
                            .Rows(0).Cells("QAROCP").Value = dwFila.Item("QAROCP") 'Cant.Area Ocupada mt2 
                        End If



                        .Rows(0).Cells("TIPBTO").Value = dwFila.Item("TIPBTO").ToString.Trim


                        .Rows(0).Cells("TUNPSO").Value = dwFila.Item("TUNPSO").ToString.Trim

                        .Rows(0).Cells("TUNVOL").Value = dwFila.Item("TUNVOL").ToString.Trim

                        .Rows(0).Cells("SESTRG").Value = dwFila.Item("SESTRG").ToString.Trim
                        .Rows(0).Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(0).Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                        .Rows(0).Cells("CTPALM").Value = dwFila.Item("CTPALM").ToString.Trim
                        .Rows(0).Cells("CALMC").Value = dwFila.Item("CALMC").ToString.Trim
                        .Rows(0).Cells("CZNALM").Value = dwFila.Item("CZNALM").ToString.Trim
                        .Rows(0).Cells("NSEQIN").Value = CInt(dwFila.Item("NSEQIN").ToString.Trim)
                        .Rows(0).Cells("NGRPRV").Value = dwFila.Item("NGRPRV").ToString.Trim
                        .Rows(0).Cells("NGUIRM").Value = dwFila.Item("NGUIRM").ToString.Trim

                        .Rows(0).Cells("NGUIRS").Value = dwFila.Item("NGUIRS").ToString.Trim

                        .Rows(0).Cells("NRGUSA").Value = dwFila.Item("NRGUSA").ToString.Trim
                        .Rows(0).Cells("TLUGEN2").Value = dwFila.Item("TLUGEN").ToString.Trim


                        lblItems.Text = Val(lblItems.Text) + 1
                    End With
                    txtCodigo.Text = ""
                    txtCodigo.Focus()
                End If
            Next
        End If
    End Sub
    Private Function flValidaLote(ByVal strLote As String, ByRef strMensaje As String) As Boolean
        Dim intIndice As Integer = 0
        Dim bolBultos As Boolean = False

        If bolDiferenteLote And bolLoteBulto Then

            For intIndice = 0 To dgServicio.RowCount - 1
                If Not dgServicio.Rows(intIndice).Cells("TLUGEN").Value.ToString.Trim.Equals("") Then
                    If strLote = dgServicio.Rows(intIndice).Cells("TLUGEN").Value.ToString.Trim Then
                        Return True
                    End If
                Else
                    bolBultos = True
                    Exit For
                End If
            Next

            strMensaje = "El Lote del bulto que esta agregando debe ser igual al lote del Servicio, desea agregar?"

            'En caso de que el lote sea igual a vacio, se valida que los bultos tengan los mismos lotes
            If bolBultos Then
                strMensaje = String.Empty
                For intIndice = 0 To dtgBultos.RowCount - 1
                    If strLote = ("" & dtgBultos.Rows(intIndice).Cells("TLUGEN2").Value & "").ToString.Trim Then
                        Return True

                    End If
                Next
                strMensaje = "El Lote del bulto que esta agregando debe ser igual al anterior, desea agregar?"
            End If

            If dtgBultos.RowCount = 0 And bolBultos Then
                Return True
            End If


        Else
            Return True
        End If


        Return False
    End Function

    ''' <summary>
    ''' Busca si el bulto ya esta asignado a la operación 
    ''' </summary>
    ''' <param name="strCodigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarBulto(ByVal strCodigo As String, ByVal strSeq As String) As Boolean
        Dim intIndice As Integer
        For intIndice = 0 To dtgBultos.RowCount - 1
            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim And _
            strSeq = CType(dtgBultos.Rows(intIndice).Cells("NSEQIN").Value.ToString.Trim, Decimal) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function fblnBuscarBultosServicio(ByVal strCodigo As String, ByVal strSeq As String, ByVal NCRROP As String) As Boolean
        Dim intIndice As Integer

        For intIndice = 0 To dtgBultos.RowCount - 1

            If strCodigo.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim And _
            CType(strSeq, Decimal) = CType(dtgBultos.Rows(intIndice).Cells("NSEQIN").Value.ToString.Trim, Decimal) And _
            NCRROP = Val("" & dtgBultos.Rows(intIndice).Cells("NCRROP3").Value & "") Then
                dtgBultos.Rows(intIndice).Cells("SESTRG").Value = "A"
                Return True
            End If
        Next
        Return False
    End Function

    Private Function fblnBuscarEmbarquesServicio(ByVal strEmbarque As String, ByVal NCRROP As String) As Boolean
        For Each dr As DataRow In dtgEmbarque.DataSource.Rows
            If strEmbarque = dr("NORSCI") And dr("NCRROP5") = NCRROP Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub DeleteDetalisEmbarque(ByVal oDt As DataTable)
        Dim Count As Integer = 0
        Dim blExisteEmbarque As Boolean = False
        Dim NSEC As Integer = 0
        NSEC = oDt.Rows(0).Item("NCRROP5")

        For Each dr As DataRow In dtgEmbarque.DataSource.Rows
            If NSEC = dr("NCRROP5") Then
                Count += 1
            End If
        Next

        If Count > oDt.Rows.Count Then
            For i As Integer = 0 To dtgEmbarque.DataSource.Rows.Count - 1

                If NSEC = dtgEmbarque.DataSource.Rows(i).Item("NCRROP5") Then

                    For indice As Integer = 0 To oDt.Rows.Count - 1
                        blExisteEmbarque = False
                        Dim val As String = dtgEmbarque.DataSource.Rows(i).Item("NORSCI")
                        If dtgEmbarque.DataSource.Rows(i).Item("NORSCI") = oDt.Rows(indice).Item("NORSCI") Then
                            blExisteEmbarque = True
                            If blExisteEmbarque Then Exit For
                        End If
                    Next

                    If Not blExisteEmbarque Then
                        dtgEmbarque.DataSource.Rows(i).Item("SESTRG_EMB") = "*"
                    End If

                End If

            Next
        End If

    End Sub

    Private Sub fblnDeleteRowsOperation(ByVal lista As List(Of Servicio_BE))
        Dim Count As Integer = 0
        Dim blExisteBulto As Boolean = False
        Dim NSEC As Integer = 0
        For intIndice As Integer = 0 To dtgBultos.Rows.Count - 1

            If lista(0).NCRROP = Val("" & dtgBultos.Rows(intIndice).Cells("NCRROP3").Value & "") Then
                Count += 1
            End If

        Next
        NSEC = lista(0).NCRROP

        If Count > lista.Count Then
            Count = 0
            For intIndice As Integer = 0 To dtgBultos.Rows.Count - 1
                blExisteBulto = False
                If NSEC = dtgBultos.Rows(intIndice).Cells("NCRROP3").Value Then

                    For Each obe As Servicio_BE In lista
                        If obe.CREFFW.Trim = dtgBultos.Rows(intIndice).Cells("CREFFW").Value.ToString.Trim And _
                      obe.NSEQIN = CType(dtgBultos.Rows(intIndice).Cells("NSEQIN").Value, Decimal) Then
                            blExisteBulto = True
                            If blExisteBulto Then Exit For
                        End If
                    Next

                    If Not blExisteBulto Then
                        dtgBultos.Rows(intIndice).Cells("SESTRG").Value = "*"
                        Count += 1
                    End If
                End If
            Next


        End If
    End Sub



    ''' <summary>
    ''' Busca si la solicitud de servicio ya esta asignada a la operación
    ''' </summary>
    ''' <param name="oDr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarSolicitudServicio(ByVal oDr As DataRow) As Boolean
        Dim dt As DataTable = CType(dtgMercaderia.DataSource, DataTable)
        For Each oDrMercaderia As DataRow In Me.dtgMercaderia.DataSource.Rows
            If oDrMercaderia.Item("NORDSR") = oDr.Item("NORDSR") And oDrMercaderia.Item("NSLCSR") = oDr.Item("NSLCSR") Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function fblnBuscarSolicitudServicioTemp(ByVal oDr As DataRow) As Boolean
        Dim dt As DataTable = CType(dtgMercaderia.DataSource, DataTable)
        For Each oDrMercaderia As DataRow In Me.dtgMercaderia.DataSource.Rows
            If oDrMercaderia.Item("NORDSR") = oDr.Item("NORDSR") And oDrMercaderia.Item("NSLCSR") = oDr.Item("NSLCSR") And oDrMercaderia.Item("NCRROP4") = oDr.Item("NCRROP4") Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Busca si el servicio ya esta asignada a la operacion
    ''' </summary>
    ''' <param name="oServAgre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fblnBuscarServicio(ByVal oServAgre As Servicio_BE) As Boolean 'ByVal oDr As DataRow
        For Each oDrServicio As DataGridViewRow In Me.dgServicio.Rows
            'If Not (oDrServicio.Cells("CCNTCS").Value = oServAgre.CCNTCS AndAlso oDrServicio.Cells("TSGNMN").Value.ToString.Trim = oServAgre.TSGNMN.Trim) Then
            '    Return True
            'End If
            If Not (oDrServicio.Cells("TSGNMN").Value.ToString.Trim = oServAgre.TSGNMN.Trim) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Carga La tarifa asignada a la operación
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarTarifaServicio()
        Try
            Dim oServicioBL As New clsServicio_BL
            Dim NCRROP_SERVICIO As Decimal = 0
            Dim oDs As New DataSet
            Dim oDt As New DataTable

            If _oServicio.CTPALJ = "RE" Then
                oDs = oServicioBL.fdtObtenerServiciosFacturacionReembolso(_oServicio)
            Else
                oDs = oServicioBL.fdtObtenerServiciosFacturacionSA(_oServicio)
            End If



            If oDs.Tables.Count > 0 Then
                Dim oDtLote As New DataTable
                oDt = oDs.Tables(0).Copy
                oServicio.NOPRCN = oDt.Rows(0).Item("NOPRCN")
                Me.hgTitulo.ValuesPrimary.Heading = "Nr. Operación :" & oServicio.NOPRCN.ToString
                cmbProceso.SelectedValue = oDt.Rows(0).Item("STIPPR")
                Me.UcClienteOperacion.pCargar(_oServicio.CCLNT)
                Me.ucClienteFacturar.pCargar(oDt.Rows(0).Item("CCLNFC"))
                Me.dteFechaOperacion.Value = IIf(oDt.Rows(0).Item("FOPRCN") Is DBNull.Value, Now, oDt.Rows(0).Item("FOPRCN"))
                Me.dgServicio.AutoGenerateColumns = False
                Dim oDtServicio As DataTable
                oDtServicio = oDs.Tables(1).Copy
                Me.txtReferencia.Text = oDt.Rows(0).Item("TRDCCL")

                If oDtServicio.Rows.Count > 0 Then
                    NCRROP_SERVICIO = oDtServicio.Rows(0).Item("NCRROP")
                End If
                oDtLote = oDtServicio.DefaultView.ToTable(True, "TLUGEN")

                If oDtLote.Rows.Count = 1 Then bolDiferenteLote = True Else bolDiferenteLote = False

                For intCont As Integer = 0 To oDtServicio.Rows.Count - 1
                    Dim oDrvW As DataGridViewRow
                    oDrvW = New DataGridViewRow
                    oDrvW.CreateCells(Me.dgServicio)
                    Me.dgServicio.Rows.Add(oDrvW)
                    With dgServicio.Rows(intCont)
                        .Cells("NCRROP_1").Value = oDtServicio.Rows(intCont).Item("NCRROP")
                        .Cells("NRTFSV").Value = oDtServicio.Rows(intCont).Item("NRTFSV")
                        .Cells("DESTAR").Value = oDtServicio.Rows(intCont).Item("DESTAR")
                        .Cells("VALCTE").Value = oDtServicio.Rows(intCont).Item("VALCTE")
                        .Cells("CUNDMD").Value = oDtServicio.Rows(intCont).Item("CUNDMD")
                        .Cells("QATNAN").Value = oDtServicio.Rows(intCont).Item("QATNAN")
                        .Cells("QATNRL").Value = oDtServicio.Rows(intCont).Item("QATNRL")
                        .Cells("TSGNMN").Value = oDtServicio.Rows(intCont).Item("TSGNMN")
                        .Cells("CCNTCS").Value = oDtServicio.Rows(intCont).Item("CCNTCS")
                        .Cells("IVLSRV").Value = oDtServicio.Rows(intCont).Item("IVLSRV")
                        .Cells("FATNSR").Value = oDtServicio.Rows(intCont).Item("FATNSR")
                        .Cells("NOPRCN").Value = oDtServicio.Rows(intCont).Item("NOPRCN")
                        .Cells("NCRROP").Value = oDtServicio.Rows(intCont).Item("NCRROP")
                        .Cells("TLUGEN").Value = oDtServicio.Rows(intCont).Item("TLUGEN")
                        .Cells("TCTCST").Value = oDtServicio.Rows(intCont).Item("TCTCST")
                        .Cells("NORCML").Value = oDtServicio.Rows(intCont).Item("NORCML")
                        .Cells("TSRVC").Value = oDtServicio.Rows(intCont).Item("TSRVC")
                        .Cells("NRRUBR").Value = oDtServicio.Rows(intCont).Item("NRRUBR")
                        .Cells("NCRROP2").Value = oDtServicio.Rows(intCont).Item("NCRROP2")
                        .Cells("SRBAFD").Value = oDtServicio.Rows(intCont).Item("SRBAFD")

                        .Cells("IPRCDT").Value = oDtServicio.Rows(intCont).Item("IPRCDT")


                        .Cells("CRGVTA").Value = oDtServicio.Rows(intCont).Item("CRGVTA")

                        .Cells("TRFSRC").Value = oDtServicio.Rows(intCont).Item("TRFSRC")

                        'NUEVOS CAMPOS
                        .Cells("CTPALM2").Value = oDtServicio.Rows(intCont).Item("CTPALM")
                        .Cells("TTPOMR").Value = oDtServicio.Rows(intCont).Item("TTPOMR")

                        '<[AHM]>
                        .Cells("CDTSSP").Value = oDtServicio.Rows(intCont).Item("CDTSSP")
                        .Cells("CDUPSP").Value = oDtServicio.Rows(intCont).Item("CDUPSP")
                        .Cells("PRCODI").Value = oDtServicio.Rows(intCont).Item("CDTASP")
                        '</[AHM]>


                        'JM 
                        .Cells("CENCOS").Value = oDtServicio.Rows(intCont).Item("CENCOS")
                        .Cells("CENCO2").Value = oDtServicio.Rows(intCont).Item("CENCO2")
                        .Cells("ISRVTI").Value = oDtServicio.Rows(intCont).Item("ISRVTI")
                        .Cells("CCNBNS").Value = oDtServicio.Rows(intCont).Item("CCNBNS") 'JM

                        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                            .Cells("STPTRA").Value = oDtServicio.Rows(intCont).Item("STPTRA")
                            .Cells("NRTFSV_T").Value = oDtServicio.Rows(intCont).Item("NRTFSV_ORIGEN")
                            .Cells("TARIFAFIJA").Value = oDtServicio.Rows(intCont).Item("FLG_FIJA")
                            .Cells("NDIAPL_").Value = oDtServicio.Rows(intCont).Item("NDIAPL")
                            _CDREF = oDtServicio.Rows(intCont).Item("NRTFSV_ORIGEN").ToString.Trim
                        End If


                        Select Case _oServicio.CTPALJ

                            Case estatico.E_ESP_ManipuleoPeso, estatico.E_ESP_AlmacenajePeso
                                .Cells("FINPRF").Value = oDtServicio.Rows(intCont).Item("FINPRF")
                                .Cells("FFNPRF").Value = oDtServicio.Rows(intCont).Item("FFNPRF")

                            Case estatico.E_ESP_Reembolso

                                .Cells("TOBSSR").Value = oDtServicio.Rows(intCont).Item("TOBSSR")
                                .Cells("TPRVD").Value = oDtServicio.Rows(intCont).Item("TPRVD")
                                .Cells("NRUCPR").Value = oDtServicio.Rows(intCont).Item("NRUCPR")
                                .Cells("TPODOC").Value = oDtServicio.Rows(intCont).Item("TPODOC")
                                .Cells("NUMDOC").Value = oDtServicio.Rows(intCont).Item("NUMDOC")
                                .Cells("IMPFAC").Value = oDtServicio.Rows(intCont).Item("IMPFAC")
                                .Cells("CTRMNC").Value = oDtServicio.Rows(intCont).Item("CTRMNC")
                                .Cells("NGUITR").Value = oDtServicio.Rows(intCont).Item("NGUITR")
                                .Cells("FCHDOC").Value = oDtServicio.Rows(intCont).Item("FCHDOC")
                                .Cells("ITPCMT").Value = oDtServicio.Rows(intCont).Item("ITPCMT")
                        End Select

                    End With
                Next

                Select Case _oServicio.CDVSN
                    Case "R"
                        If _oServicio.STPODP = "7" Then
                            cargarBultosServicio()
                            If _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Or _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso Then
                                cargarSumaCantidades()
                            End If
                        Else
                            CargarSolicitudServicio()
                        End If

                    Case "S"
                        Llenar_Embarques_x_Operacion(_oServicio.CCLNT, _oServicio.NOPRCN)
                End Select

            End If
        Catch : End Try
    End Sub

    Private Sub CargarDirServicioXDefecto()

        Dim oDt As New DataTable
        Dim oServicioBL As New clsServicio_BL
        oDt = oServicioBL.fdtListaDirServicxDefecto(_oServicio.CCMPN, _oServicio.CDVSN, UcClienteOperacion.pCodigo, ucClienteFacturar.pCodigo, cmbPlanta.SelectedValue, 0)
        If oDt.Rows.Count > 0 Then

            txtDireccion.Text = oDt.Rows.Item(0)("DEDISE").ToString()
            txtUbigeo.Text = oDt.Rows.Item(0)("UBIGEO").ToString()
            _codigoDireccionServicio = oDt.Rows.Item(0)("CDIRSE").ToString()

        Else
            txtDireccion.Text = String.Empty
            txtUbigeo.Text = String.Empty
            _codigoDireccionServicio = 0

        End If
    End Sub

    ''' <summary>
    ''' Cargar el detalle del servicio asignada a la operacion 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarSolicitudServicio()

        Dim oServicioBL As New clsServicio_BL
        Dim oDt As New DataTable
        Dim nNCRROP As Integer = 0
        Dim oDtCorr As New DataTable
        _oServicio.CPLNDV = cmbPlanta.SelectedValue
        oDt = oServicioBL.fdtListaDetalleServiciosFacturacionSA(_oServicio)
        oDtCargaBulto = oDt
        oDtCorr = oDt.DefaultView.ToTable(True, "NCRROP4")

        If oDtCorr.Rows.Count = 1 Then
            nNCRROP = oDtCorr.Rows(0).Item(0)
        Else
            nNCRROP = oDtCorr.Rows.Count
        End If

        If nNCRROP > 0 Then
            rbNinguno.Enabled = False
            rbOperacion.Enabled = False
            rbServicio.Checked = True
        Else
            If oDt.Rows.Count = 0 Then
                rbServicio.Enabled = False
                rbOperacion.Enabled = False
                rbNinguno.Checked = True
            Else
                rbServicio.Enabled = False
                rbNinguno.Enabled = False
                rbOperacion.Checked = True
            End If
        End If

        Me.dtgMercaderia.DataSource = oDt
        lblItems.Text = oDt.Rows.Count.ToString
    End Sub

    Private oDtCargaBulto As New DataTable
    Private Sub cargarBultosServicio()
        Dim oServicioBL As New clsServicio_BL
        Dim Items As Integer = 0


        Dim oDrVw As DataGridViewRow
        Dim NCRROP As Integer = 0
        Me.dtgBultos.Rows.Clear()
        oServicio.CPLNDV = cmbPlanta.SelectedValue

        oDtCargaBulto = oServicioBL.fdtListaDetalleServiciosFacturacionSA(oServicio)

        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then

            dtgBultos.Columns("NDIAPL").Visible = True
            dtgBultos.Columns("FINGAL").Visible = True
            dtgBultos.Columns("FSLDAL").Visible = True


        Else

            dtgBultos.Columns("NDIAPL").Visible = False
            dtgBultos.Columns("FINGAL").Visible = False
            dtgBultos.Columns("FSLDAL").Visible = False


        End If

        For i As Integer = 0 To oDtCargaBulto.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgBultos)
            Me.dtgBultos.Rows.Add(oDrVw)
            With Me.dtgBultos

                Dim pos As Integer = i
                .Rows(pos).Cells("CREFFW").Value = oDtCargaBulto.Rows(i).Item("CREFFW").ToString.Trim
                .Rows(pos).Cells("NCRRDC").Value = oDtCargaBulto.Rows(i).Item("NCRRDC").ToString.Trim
                .Rows(pos).Cells("DESCWB").Value = oDtCargaBulto.Rows(i).Item("DESCWB").ToString.Trim
                .Rows(pos).Cells("CPRCN1").Value = oDtCargaBulto.Rows(i).Item("CPRCN1").ToString.Trim
                .Rows(pos).Cells("NSRCN1").Value = oDtCargaBulto.Rows(i).Item("NSRCN1")
                .Rows(pos).Cells("TUBRFR").Value = oDtCargaBulto.Rows(i).Item("TUBRFR").ToString.Trim
                .Rows(pos).Cells("QREFFW").Value = oDtCargaBulto.Rows(i).Item("QREFFW")
                .Rows(pos).Cells("TIPBTO").Value = oDtCargaBulto.Rows(i).Item("TIPBTO").ToString.Trim
                .Rows(pos).Cells("QPSOBL").Value = oDtCargaBulto.Rows(i).Item("QPSOBL")
                .Rows(pos).Cells("TUNPSO").Value = oDtCargaBulto.Rows(i).Item("TUNPSO").ToString.Trim
                .Rows(pos).Cells("QVLBTO").Value = oDtCargaBulto.Rows(i).Item("QVLBTO")
                .Rows(pos).Cells("TUNVOL").Value = oDtCargaBulto.Rows(i).Item("TUNVOL").ToString.Trim
                .Rows(pos).Cells("QAROCP").Value = oDtCargaBulto.Rows(i).Item("QAROCP")
                .Rows(pos).Cells("SESTRG").Value = oDtCargaBulto.Rows(i).Item("SESTRG").ToString.Trim
                .Rows(pos).Cells("CTPALM").Value = oDtCargaBulto.Rows(i).Item("CTPALM").ToString.Trim
                .Rows(pos).Cells("CALMC").Value = oDtCargaBulto.Rows(i).Item("CALMC").ToString.Trim
                .Rows(pos).Cells("CZNALM").Value = oDtCargaBulto.Rows(i).Item("CZNALM").ToString.Trim
                .Rows(pos).Cells("NSEQIN").Value = oDtCargaBulto.Rows(i).Item("NSEQIN").ToString.Trim
                .Rows(pos).Cells("NCRROP3").Value = oDtCargaBulto.Rows(i).Item("NCRROP").ToString.Trim

                .Rows(pos).Cells("SSNCRG").Value = oDtCargaBulto.Rows(i).Item("SSNCRG").ToString.Trim
                .Rows(pos).Cells("SSNCRG_D").Value = oDtCargaBulto.Rows(i).Item("SSNCRG_D").ToString.Trim
                .Rows(pos).Cells("TLUGEN2").Value = oDtCargaBulto.Rows(i).Item("TLUGEN").ToString.Trim
                .Rows(pos).Cells("TCMZNA").Value = oDtCargaBulto.Rows(i).Item("TCMZNA").ToString.Trim

                .Rows(pos).Cells("TALMC").Value = oDtCargaBulto.Rows(i).Item("TALMC").ToString.Trim
                .Rows(pos).Cells("TCMPAL").Value = oDtCargaBulto.Rows(i).Item("TCMPAL").ToString.Trim

                NCRROP = oDtCargaBulto.Rows(i).Item("NCRROP")


                .Rows(pos).Cells("NCRRDC").Value = oDtCargaBulto.Rows(i).Item("NCRRDC").ToString.Trim
                .Rows(pos).Cells("QPRDFC").Value = oDtCargaBulto.Rows(i).Item("QPRDFC").ToString.Trim
                .Rows(pos).Cells("NDIAPL").Value = oDtCargaBulto.Rows(i).Item("NDIAPL").ToString.Trim

                .Rows(pos).Cells("FINGAL").Value = oDtCargaBulto.Rows(i).Item("FINGAL").ToString.Trim
                .Rows(pos).Cells("FSLDAL").Value = oDtCargaBulto.Rows(i).Item("FSLDAL").ToString.Trim

                .Rows(pos).Cells("NGRPRV").Value = oDtCargaBulto.Rows(i).Item("NGRPRV").ToString.Trim
                .Rows(pos).Cells("NGUIRM").Value = oDtCargaBulto.Rows(i).Item("NGUIRM").ToString.Trim
                .Rows(pos).Cells("NGUIRS").Value = oDtCargaBulto.Rows(i).Item("NGUIRS").ToString.Trim
                .Rows(pos).Cells("NRGUSA").Value = oDtCargaBulto.Rows(i).Item("NRGUSA").ToString.Trim

                Items += 1


            End With
        Next
        lblItems.Text = Items.ToString
        If _oServicio.CTPALJ <> "RE" Then
            If NCRROP > 0 Then
                rbNinguno.Enabled = False
                rbOperacion.Enabled = False
                rbServicio.Checked = True
            Else
                If oDtCargaBulto.Rows.Count = 0 Then
                    rbServicio.Enabled = False
                    rbOperacion.Enabled = False
                    rbNinguno.Checked = True
                Else
                    rbServicio.Enabled = False
                    rbNinguno.Enabled = False
                    rbOperacion.Checked = True
                End If
            End If
        End If

    End Sub

    Private Function GrabarSolicitudServicio() As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim oServicioAlmacen As New Servicio_BE

        Dim blnResultado As Boolean = True
        If Me.dtgMercaderia.Rows.Count > 0 And _oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            'Dim DT As DataTable = CType(dtgMercaderia.DataSource, DataTable).Copy
            For Each oDrmercaderia As DataRow In dtgMercaderia.DataSource.Rows  'Registros Hechos
                With oServicioAlmacen
                    .NOPRCN = _oServicio.NOPRCN
                    .CCLNT = UcClienteOperacion.pCodigo
                    .NORDSR = oDrmercaderia.Item("NORDSR")
                    .NSLCSR = oDrmercaderia.Item("NSLCSR")
                    .CPRCN1 = "" & oDrmercaderia.Item("CPRCN1") & ""
                    .NSRCN1 = "" & oDrmercaderia.Item("NSRCN1") & ""
                    .NCRRDC = Val(IIf(oDrmercaderia.Item("NCRRDC") Is DBNull.Value, 0, oDrmercaderia.Item("NCRRDC")))
                    If rbServicio.Checked Then
                        .NCRROP = Val(IIf(oDrmercaderia.Item("NCRROP4") Is DBNull.Value, 0, oDrmercaderia.Item("NCRROP4")))
                    Else
                        .NCRROP = 0
                    End If

                    .CPLNDV = cmbPlanta.SelectedValue
                    .STPODP = oServicio.STPODP
                End With
                If oDrmercaderia.Item("NCRRDC").ToString.Equals("") Or oDrmercaderia.Item("NCRRDC").ToString.Equals("0") Then 'OrElse oServicio.TIPO = "N"
                    oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA(oServicioAlmacen)
                    If Not oServicio.PSERROR.Equals("") Then
                        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                        blnResultado = False
                        Exit For
                    End If
                Else
                    If oServicioBL.fintActualizarDetalleServiciosFacturacionSA(oServicioAlmacen) = 0 Then
                        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
                        blnResultado = False
                        Exit For
                    End If
                End If
            Next
        End If
        Return blnResultado
    End Function

    Private Function GrabarBultosPorServicio(ByVal NCRROP As Integer, ByVal NSECUENCIA As Integer) As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim blnResultado As Boolean = True
        If dtgBultos.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dtgBultos.Rows.Count > 0 Then
                Dim oServicioSAT As New Servicio_BE
                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos

                    If dtgBultos.Rows(i).Cells("NCRROP3").Value = NSECUENCIA.ToString And dtgBultos.Rows(i).Cells("SESTRG").Value <> "*" Then


                        _oServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                        _oServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                        _oServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                        _oServicio.NCRRDC = Val("" & dtgBultos.Rows(i).Cells("NCRRDC").Value & "")
                        _oServicio.CPLNDV = cmbPlanta.SelectedValue

                        _oServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value 'Tipo almacen
                        _oServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value 'Almacen
                        _oServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value  'Zona

                        _oServicio.NSEQIN = dtgBultos.Rows(i).Cells("NSEQIN").Value  'Secuencia
                        _oServicio.QPRDFC = dtgBultos.Rows(i).Cells("QPRDFC").Value  'Secuencia
                        _oServicio.TOTALDIAS = dtgBultos.Rows(i).Cells("NDIAPL").Value
                        _oServicio.NCRROP = IIf(rbServicio.Checked, NCRROP, 0)

                        'If dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("") Or dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("0") Then

                        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                            oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(oServicio)
                        Else
                            oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA(oServicio)
                        End If

                        If Not oServicio.PSERROR.Equals("") Then
                            MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                            blnResultado = False
                            Exit For
                        End If
                        'Else
                        '    If oServicioBL.fintActualizarDetalleServiciosFacturacionSA(oServicio) = 0 Then
                        '        MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                        '        blnResultado = False
                        '        Exit For
                        '    End If
                        'End If

                    End If
                Next

            End If
        End If
        Return blnResultado
    End Function

    Private Function GrabarBultosOperacion() As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim blnResultado As Boolean = True
        If dtgBultos.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dtgBultos.Rows.Count > 0 Then
                Dim oServicioSAT As New Servicio_BE
                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos

                    _oServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                    _oServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                    _oServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                    _oServicio.NCRRDC = Val("" & dtgBultos.Rows(i).Cells("NCRRDC").Value & "")
                    _oServicio.CPLNDV = cmbPlanta.SelectedValue

                    _oServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value 'Tipo almacen
                    _oServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value 'Almacen
                    _oServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value  'Zona

                    _oServicio.NSEQIN = dtgBultos.Rows(i).Cells("NSEQIN").Value  'Secuencia

                    _oServicio.TOTALDIAS = dtgBultos.Rows(i).Cells("NDIAPL").Value

                    _oServicio.NCRROP = IIf(rbServicio.Checked, Val("" & dtgBultos.Rows(i).Cells("NCRROP3").Value & ""), 0)



                    If dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("") Or dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("0") Then

                        If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                            oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(oServicio)
                        Else
                            oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA(oServicio)
                        End If

                        If Not oServicio.PSERROR.Equals("") Then
                            MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                            blnResultado = False
                            Exit For
                        End If
                    Else

                        If oServicioBL.fintActualizarDetalleServiciosFacturacionSA(oServicio) = 0 Then
                            MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                            blnResultado = False
                            Exit For

                        End If

                    End If
                Next
            End If
        End If
        Return blnResultado
    End Function

    Private Function ActualizaBultos(ByVal SECUENCIA As Integer) As Boolean
        Dim oServicioBL As New clsServicio_BL
        Dim blnResultado As Boolean = True
        If dtgBultos.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dtgBultos.Rows.Count > 0 Then
                Dim oServicioSAT As New Servicio_BE
                For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
                    If SECUENCIA = Val("" & dtgBultos.Rows(i).Cells("NCRROP3").Value & "") Then


                        _oServicio.CREFFW = dtgBultos.Rows(i).Cells("CREFFW").Value
                        _oServicio.CPRCN1 = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                        _oServicio.NSRCN1 = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                        _oServicio.NCRRDC = Val("" & dtgBultos.Rows(i).Cells("NCRRDC").Value & "")
                        _oServicio.CPLNDV = cmbPlanta.SelectedValue

                        _oServicio.CTPALM = dtgBultos.Rows(i).Cells("CTPALM").Value 'Tipo almacen
                        _oServicio.CALMC = dtgBultos.Rows(i).Cells("CALMC").Value 'Almacen
                        _oServicio.CZNALM = dtgBultos.Rows(i).Cells("CZNALM").Value  'Zona

                        _oServicio.NSEQIN = dtgBultos.Rows(i).Cells("NSEQIN").Value  'Secuencia

                        _oServicio.TOTALDIAS = dtgBultos.Rows(i).Cells("NDIAPL").Value

                        _oServicio.NCRROP = IIf(rbServicio.Checked, Val("" & dtgBultos.Rows(i).Cells("NCRROP3").Value & ""), 0)

                        If ("" & dtgBultos.Rows(i).Cells("SESTRG").Value & "") = "*" Then

                            oServicioBL.fintEliminarDetalleServiciosFacturacionSA(_oServicio)

                        Else

                            If dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("") Or dtgBultos.Rows(i).Cells("NCRRDC").Value.ToString.Equals("0") Then

                                If _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                                    oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA_SDS_Permanencia(oServicio)
                                Else
                                    oServicio.PSERROR = oServicioBL.fstrInsertarDetalleServiciosFacturacionSA(oServicio)
                                End If

                                If Not oServicio.PSERROR.Equals("") Then
                                    MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                                    blnResultado = False
                                    Exit For
                                End If
                            Else
                                If oServicioBL.fintActualizarDetalleServiciosFacturacionSA(oServicio) = 0 Then
                                    MsgBox(oServicio.PSERROR, MessageBoxIcon.Information)
                                    blnResultado = False
                                    Exit For
                                End If
                            End If

                        End If

                    End If
                Next
            End If
        End If
        Return blnResultado
    End Function

    ''' <summary>
    ''' Elimna el detalle de la operacion 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EliminarDetalleOperacion()
        Select Case _oServicio.CDVSN
            Case "R"
                If _oServicio.STPODP = "7" Then
                    Dim oServicioBL As New clsServicio_BL
                    If Me.dtgBultos.RowCount <= 0 Then
                        MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    If Val("" & Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value & "") = 0 Then
                        dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                        lblItems.Text = dtgBultos.Rows.Count.ToString
                        If dtgBultos.RowCount = 0 Then
                            bolLoteBulto = True
                            rbNinguno.Checked = True
                        End If

                        Exit Sub
                    End If
                    If MessageBox.Show("Está seguro de eliminar el bulto seleccionado?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicioDel As New Servicio_BE
                        oServicioDel.NOPRCN = _oServicio.NOPRCN
                        oServicioDel.CCLNT = UcClienteOperacion.pCodigo
                        oServicioDel.NCRRDC = Me.dtgBultos.CurrentRow.Cells("NCRRDC").Value
                        oServicioDel.STPODP = _oServicio.STPODP
                        If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                        Else
                            dtgBultos.Rows.Remove(dtgBultos.CurrentRow)
                            lblItems.Text = dtgBultos.Rows.Count.ToString

                            If dtgBultos.RowCount = 0 Then bolLoteBulto = True

                        End If
                    End If

                Else
                    Dim oServicioBL As New clsServicio_BL
                    If Me.dtgMercaderia.RowCount <= 0 Then
                        MsgBox("No existe elementos para poder ser eliminados.", MessageBoxIcon.Exclamation, "Validación")
                        Exit Sub
                    End If
                    If Me.dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC").ToString.Trim.Equals("") Then
                        CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                        lblItems.Text = dtgMercaderia.Rows.Count.ToString
                        Exit Sub
                    End If
                    If MessageBox.Show("Está seguro de eliminar el registro seleccionado ?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicioDel As New Servicio_BE
                        oServicioDel.NOPRCN = _oServicio.NOPRCN
                        oServicioDel.CCLNT = UcClienteOperacion.pCodigo
                        oServicioDel.NCRRDC = dtgMercaderia.CurrentRow.DataBoundItem.Item("NCRRDC")
                        oServicioDel.STPODP = _oServicio.STPODP
                        If oServicioBL.fintEliminarDetalleServiciosFacturacionSA(oServicioDel) = 0 Then
                            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                        Else
                            CType(dtgMercaderia.DataSource, DataTable).Rows.Remove(CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, DataRowView).Row)
                            lblItems.Text = dtgMercaderia.Rows.Count.ToString
                        End If
                    End If

                End If
            Case "S"
                Dim msgInformativo As String = ""
                Dim PNNORSCI As Decimal = 0
                Dim PNNRITEM As Decimal = 0
                Dim obrclsServicioSC_BL As New clsServicioSC_BL
                Dim retorno As Int32 = 0
                Dim PNFLAG_REGISTRO As Int32 = 0
                If (dtgEmbarque.CurrentRow IsNot Nothing) Then
                    PNFLAG_REGISTRO = Val("" & dtgEmbarque.CurrentRow.Cells("FLAG_REGISTRO").Value & "")
                    PNNORSCI = dtgEmbarque.CurrentRow.Cells("NORSCI").Value
                    PNNRITEM = dtgEmbarque.CurrentRow.Cells("NRITEM").Value
                    If (PNFLAG_REGISTRO = 1) Then
                        msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                        If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                            Dim oEmbarqueServicio As New Servicio_BE
                            oEmbarqueServicio.CCLNT = UcClienteOperacion.pCodigo
                            oEmbarqueServicio.NOPRCN = _oServicio.NOPRCN
                            oEmbarqueServicio.NORSCI = PNNORSCI
                            oEmbarqueServicio.PSUSUARIO = ConfigurationWizard.UserName
                            oEmbarqueServicio.NRITEM = PNNRITEM

                            If (obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio) = -1) Then
                                MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                            Else
                                CType(dtgEmbarque.DataSource, DataTable).Rows.Remove(CType(Me.dtgEmbarque.CurrentRow.DataBoundItem, DataRowView).Row)
                                lblItems.Text = dtgEmbarque.Rows.Count.ToString
                            End If
                        End If
                    Else
                        CType(dtgEmbarque.DataSource, DataTable).Rows.Remove(CType(Me.dtgEmbarque.CurrentRow.DataBoundItem, DataRowView).Row)
                        lblItems.Text = dtgEmbarque.Rows.Count.ToString
                    End If
                End If
        End Select


        If dtgEmbarque.DataSource IsNot Nothing Then
            If dtgEmbarque.DataSource.Rows.Count = 0 Then
                dtgEmbarque.DataSource = Nothing
            End If
        End If

        If dtgMercaderia.DataSource IsNot Nothing Then
            If dtgMercaderia.DataSource.Rows.Count = 0 Then
                dtgMercaderia.DataSource = Nothing
            End If
        End If
    End Sub

    Private mListaBultoServicio As New List(Of Servicio_BE)
    Private mListaServicioDetalleEmbarque As New List(Of Servicio_BE)

    Private Sub AgregarServicio()


        Dim por_detracion_primer_reg As Decimal = 0
        Dim cant_reg As Decimal = dgServicio.Rows.Count
        If cant_reg > 0 Then
            por_detracion_primer_reg = dgServicio.Rows(0).Cells("IPRCDT").Value
        End If



        Dim oServAgre As New Servicio_BE
        Dim ListaoServAgre As New List(Of Servicio_BE)
        Dim oServAgre_BE As New clsServicio_BL
        Dim oServReembAgre As New ServicioReembolso_BE
        Dim frmServAdd As Object = Nothing
        Dim strLote As String = String.Empty
        oServicio.CTPALJ = cmbTipoServicio.SelectedValue
        oServAgre.CCMPN = _oServicio.CCMPN
        oServAgre.CDVSN = _oServicio.CDVSN
        oServAgre.CPLNDV = cmbPlanta.SelectedValue
        oServAgre.CCLNT = UcClienteOperacion.pCodigo
        oServAgre.SSTINV = cmbProceso.SelectedValue
        oServAgre.TIPO = Comun.ESTADO_Nuevo
        oServAgre.CTPALJ = _oServicio.CTPALJ
        oServAgre.STPODP = _oServicio.STPODP
        oServAgre.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")

        oServAgre.CCLNFC = ucClienteFacturar.pCodigo 'JM

        Select Case oServicio.CTPALJ
            Case estatico.E_ESP_General
                frmServAdd = New frmAgregaServicioGral
                If Me.dgServicio.Rows.Count > 0 Then
                    frmServAdd.strLote = Me.dgServicio.Rows(0).Cells("TLUGEN").Value()
                End If

                frmServAdd.por_det_primer_reg = por_detracion_primer_reg
                frmServAdd.cant_reg_adic = cant_reg


                If Not bolDiferenteLote Then frmServAdd.bolLoteDiferente = Not bolDiferenteLote
            Case estatico.E_ESP_AlmacenajePeso ' almacenaje por fecha de corte
                frmServAdd = New frmBultosConfirma_2
            Case estatico.E_ESP_ManipuleoPeso 'manipuleo por fecha
                frmServAdd = New frmBultosConfirmarManipuleo
            Case estatico.E_ESP_Permanencia

                frmServAdd = New frmAgregarServicioPermanencia
                'Tarija fija--------------------------------------------------
                If _ConsistenciaFac = True Then
                    oServAgre.CTPALM = _oServicio.CTPALM.Trim
                    oServAgre.TTPOMR = _oServicio.TTPOMR.Trim
                    oServAgre.NRTFSV = _oServicio.NRTFSV
                    oServAgre.NDIAPL = _oServicio.NDIAPL

                    oServAgre.CDTREF = _oServicio.CDTREF

                    frmServAdd.ConsistenciaFac = _ConsistenciaFac
                End If
                '-------------------------------------------------------------
            Case estatico.E_ESP_PesoPromedio
            Case estatico.E_ESP_Reembolso
                frmServAdd = New frmAgregarServicioReembolso
                frmServAdd.oServicioReembolso = oServReembAgre
                'valida datos de numero de documento por proveedor
                Dim oDtDocumento As New DataTable
                Dim dr As DataRow
                oDtDocumento.Columns.Add("NRUCPR", GetType(String))
                oDtDocumento.Columns.Add("NUMDOC", GetType(String))
                oDtDocumento.Columns.Add("TPODOC", GetType(String))
                For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
                    dr = oDtDocumento.NewRow
                    dr(0) = Me.dgServicio.Rows(intCont).Cells("NRUCPR").Value
                    dr(1) = Me.dgServicio.Rows(intCont).Cells("NUMDOC").Value
                    dr(2) = Me.dgServicio.Rows(intCont).Cells("TPODOC").Value
                    oDtDocumento.Rows.Add(dr)
                Next
                frmServAdd.oDtValidaDocumento = oDtDocumento
                '================================================
            Case estatico.E_ESP_Adicional, estatico.E_ESP_Manual
                frmServAdd = New frmAgregaServicioGral

                frmServAdd.por_det_primer_reg = por_detracion_primer_reg
                frmServAdd.cant_reg_adic = cant_reg
 

        End Select

        frmServAdd.oServicio = oServAgre
        If Not oServicio.CTPALJ = estatico.E_ESP_Reembolso Then
            If Not rbServicio.Checked Then
                frmServAdd.Tipofrm = 1
            End If

            For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
                frmServAdd.nCorr = Val("" & Me.dgServicio.Rows(intCont).Cells("NCRROP").Value & "")
            Next
            If dgServicio.Rows.Count > 0 And frmServAdd.nCorr = 0 Then
                For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
                    frmServAdd.nCorr = Val("" & Me.dgServicio.Rows(intCont).Cells("NCRROP2").Value & "")
                Next
            End If
        End If

        'valida  la detraccion y region venta que sea el mismo 
        Dim oDtDetra As New DataTable
        Dim dre As DataRow
        oDtDetra.Columns.Add("SRBAFD", GetType(String))
        oDtDetra.Columns.Add("CRGVTA", GetType(String))

        For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
            dre = oDtDetra.NewRow
            dre(0) = Me.dgServicio.Rows(intCont).Cells("SRBAFD").Value
            dre(1) = Me.dgServicio.Rows(intCont).Cells("CRGVTA").Value
            oDtDetra.Rows.Add(dre)
        Next
        frmServAdd.oDtValidaDetraccion = oDtDetra
        '<[AHM]>
        frmServAdd.pCodigoCompania = Me.pCodigoCompania
        frmServAdd.pNegocio = ucClienteFacturar.pNegocio
        '</[AHM]>
        If frmServAdd.ShowDialog = Windows.Forms.DialogResult.OK Then
            oServAgre = frmServAdd.oServicio
            _oServicio.CCNTCS = oServAgre.CCNTCS
        Else
            Exit Sub
        End If

        '=============================================================
        If Not fblnBuscarServicio(oServAgre) Then
            If bolDiferenteLote Then
                If oServicio.CTPALJ = estatico.E_ESP_General Then

                    bolDiferenteLote = Not frmServAdd.bolLoteDiferente 'ValidaLotesIguales(oServAgre.TLUGEN.Trim)
                    'If Not bolDiferenteLote Then
                    '    If MessageBox.Show("El Lote que esta agregando es diferente al anterior, Desea continuar?", "Validación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    '        bolDiferenteLote = True
                    '        Exit Sub
                    '    End If
                    'End If
                End If
            End If

            If Me.rbServicio.Checked Then
                If Val("" & _oServicio.STPODP & "") = Comun.eTipoAlmacen.AlmTransito Then
                    If Not cmbTipoServicio.SelectedValue.ToString = estatico.E_ESP_Reembolso Then
                        mListaBultoServicio = frmServAdd.mListaBultoServicio
                        CargaBultoOfServicio(mListaBultoServicio, oServAgre.TIPO)
                    End If
                Else
                    Select Case _oServicio.CDVSN
                        Case "R"  ' cuando es depisito simple
                            CargarMercaderiaOfServicio(frmServAdd.oDtMercaderia)
                        Case "S" ' tipo SIL
                            CargaEmbarqueOfServicio(frmServAdd.oDtEmbarques)
                    End Select
                End If
            End If

            Select Case oServicio.CTPALJ
                Case estatico.E_ESP_AlmacenajePeso, estatico.E_ESP_ManipuleoPeso
                    cargarSumaCantidades()
            End Select


            If oServicio.CTPALJ = estatico.E_ESP_Permanencia Then   'tipo “ SERVICIO ALMACENAJE POR PERMANENCIA”
                CargarTarifaFija(oServAgre, oServReembAgre)
                CargarTarifaVariable(oServAgre, oServReembAgre)
                btnAgregar.Enabled = False
            Else
                Dim oDrvW As DataGridViewRow
                oDrvW = New DataGridViewRow
                oDrvW.CreateCells(Me.dgServicio)
                Me.dgServicio.Rows.Add(oDrvW)


                With dgServicio.Rows(dgServicio.Rows.Count - 1)
                    .Cells("NRTFSV").Value = oServAgre.NRTFSV
                    .Cells("IPRCDT").Value = oServAgre.IPRCDT

                    .Cells("DESTAR").Value = oServAgre.TARIFA_DESC
                    .Cells("VALCTE").Value = oServAgre.VALCTE
                    .Cells("CUNDMD").Value = oServAgre.CUNDMD
                    Select Case oServicio.CTPALJ
                        Case estatico.E_ESP_AlmacenajePeso
                            '.Cells("QATNAN").Value = frmServAdd.txtCantidadServicio.txtDecimales.Text
                            .Cells("QATNAN").Value = oServAgre.QATNAN
                            .Cells("QATNRL").Value = oServAgre.QATNRL
                            .Cells("FINPRF").Value = 0
                            .Cells("FFNPRF").Value = 0
                        Case estatico.E_ESP_ManipuleoPeso
                            .Cells("QATNAN").Value = oServAgre.QATNAN
                            .Cells("QATNRL").Value = oServAgre.QATNRL
                            .Cells("FINPRF").Value = Comun.FormatoFecha(oServAgre.FINPRF)
                            .Cells("FFNPRF").Value = Comun.FormatoFecha(oServAgre.FFNPRF)
                        Case estatico.E_ESP_Reembolso
                            .Cells("IVLSRV").Value = oServReembAgre.IMPFAC * oServAgre.VALCTE * 0.01
                            .Cells("TOBSSR").Value = oServReembAgre.TOBSSR
                            .Cells("TPRVD").Value = oServReembAgre.TPRVD
                            .Cells("IMPFAC").Value = oServReembAgre.IMPFAC
                            .Cells("CTRMNC").Value = oServReembAgre.CTRMNC
                            .Cells("NGUITR").Value = oServReembAgre.NGUITR
                            .Cells("NRUCPR").Value = oServReembAgre.NRUCPR
                            .Cells("TPODOC").Value = oServReembAgre.TPODOC
                            .Cells("NUMDOC").Value = oServReembAgre.NUMDOC
                            .Cells("QATNAN").Value = oServAgre.QATNAN
                            .Cells("FCHDOC").Value = oServReembAgre.FCHDOC
                            .Cells("ITPCMT").Value = oServReembAgre.ITPCMT
                        Case estatico.E_ESP_General, estatico.E_ESP_Permanencia, estatico.E_ESP_Manual, estatico.E_ESP_Adicional
                            .Cells("QATNAN").Value = oServAgre.QATNAN
                            .Cells("QATNRL").Value = oServAgre.QATNRL
                            .Cells("IVLSRV").Value = oServAgre.IVLSRV
                    End Select
                    .Cells("TSGNMN").Value = oServAgre.TSGNMN
                    .Cells("TLUGEN").Value = oServAgre.TLUGEN
                    .Cells("NORCML").Value = oServAgre.NORCML
                    .Cells("TCTCST").Value = oServAgre.TCTCST
                    .Cells("TRFSRC").Value = oServAgre.TRFSRC
                    .Cells("TSRVC").Value = oServAgre.TSRVC
                    .Cells("FATNSR").Value = Comun.FormatoFecha(oServAgre.FATNSR)
                    .Cells("NRRUBR").Value = oServAgre.NRRUBR
                    .Cells("NOPRCN").Value = 0
                    .Cells("NCRROP2").Value = (Me.dgServicio.RowCount - 1) + 1
                    .Cells("SRBAFD").Value = oServAgre.SRBAFD
                    .Cells("CRGVTA").Value = oServAgre.CRGVTA
                    'nuevos campos
                    .Cells("CTPALM2").Value = oServAgre.CTPALM
                    .Cells("TTPOMR").Value = oServAgre.TTPOMR
                    '<[AHM]>
                    .Cells("CDTSSP").Value = oServAgre.CDTSSP
                    .Cells("CDUPSP").Value = oServAgre.CDUPSP
                    .Cells("PRCODI").Value = oServAgre.PRCODI
                    .Cells("CCNTCS").Value = oServAgre.CCNTCS
                    '</[AHM]>

                    'JM
                    .Cells("CENCO2").Value = oServAgre.CENCO2
                    .Cells("CENCOS").Value = oServAgre.CENCOS
                    .Cells("ISRVTI").Value = oServAgre.ISRVTI
                    '.Cells("IVLSRV").Value = oServAgre.IVLSRV
                    .Cells("CCNBNS").Value = oServAgre.CCNBNS
                End With
            End If

            If dgServicio.Rows.Count > 0 Then cmbTipoServicio.Enabled = False
        End If
    End Sub
    Private Sub CargarTarifaVariable(ByVal oServAgre As Servicio_BE, ByVal oServReembAgre As ServicioReembolso_BE)

        If oServAgre.NRTFSV <> 0 AndAlso (oServAgre.QATNAN <> 0 Or oServAgre.QATNAN <> "0.00") Then

            Dim oDrvW As DataGridViewRow
            oDrvW = New DataGridViewRow
            oDrvW.CreateCells(Me.dgServicio)
            Me.dgServicio.Rows.Add(oDrvW)
            With dgServicio.Rows(dgServicio.Rows.Count - 1)
                .Cells("NRTFSV_T").Value = oServAgre.NRTFSV_F
                .Cells("NRTFSV").Value = oServAgre.NRTFSV
                .Cells("DESTAR").Value = oServAgre.TARIFA_DESC
                .Cells("VALCTE").Value = oServAgre.VALCTE
                .Cells("CUNDMD").Value = oServAgre.CUNDMD
                .Cells("NDIAPL_").Value = oServAgre.NDIAPL
                .Cells("TARIFAFIJA").Value = ""
                Select Case oServicio.CTPALJ
                    Case estatico.E_ESP_AlmacenajePeso
                        '.Cells("QATNAN").Value = frmServAdd.txtCantidadServicio.txtDecimales.Text
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("FINPRF").Value = 0
                        .Cells("FFNPRF").Value = 0
                    Case estatico.E_ESP_ManipuleoPeso
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("FINPRF").Value = Comun.FormatoFecha(oServAgre.FINPRF)
                        .Cells("FFNPRF").Value = Comun.FormatoFecha(oServAgre.FFNPRF)
                    Case estatico.E_ESP_Reembolso
                        .Cells("IVLSRV").Value = oServReembAgre.IMPFAC * oServAgre.VALCTE * 0.01
                        .Cells("TOBSSR").Value = oServReembAgre.TOBSSR
                        .Cells("TPRVD").Value = oServReembAgre.TPRVD
                        .Cells("IMPFAC").Value = oServReembAgre.IMPFAC
                        .Cells("CTRMNC").Value = oServReembAgre.CTRMNC
                        .Cells("NGUITR").Value = oServReembAgre.NGUITR
                        .Cells("NRUCPR").Value = oServReembAgre.NRUCPR
                        .Cells("TPODOC").Value = oServReembAgre.TPODOC
                        .Cells("NUMDOC").Value = oServReembAgre.NUMDOC
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("FCHDOC").Value = oServReembAgre.FCHDOC
                        .Cells("ITPCMT").Value = oServReembAgre.ITPCMT
                    Case estatico.E_ESP_General, estatico.E_ESP_Permanencia, estatico.E_ESP_Manual, estatico.E_ESP_Adicional
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("IVLSRV").Value = oServAgre.IVLSRV
                End Select
                .Cells("TSGNMN").Value = oServAgre.TSGNMN
                .Cells("CCNTCS").Value = oServAgre.CCNTCS
                .Cells("TLUGEN").Value = oServAgre.TLUGEN
                .Cells("NORCML").Value = oServAgre.NORCML
                .Cells("TCTCST").Value = oServAgre.TCTCST
                .Cells("TRFSRC").Value = oServAgre.TRFSRC
                .Cells("TSRVC").Value = oServAgre.TSRVC
                .Cells("FATNSR").Value = Comun.FormatoFecha(oServAgre.FATNSR)
                .Cells("NRRUBR").Value = oServAgre.NRRUBR
                .Cells("NOPRCN").Value = 0
                .Cells("NCRROP2").Value = (Me.dgServicio.RowCount - 1) + 1
                .Cells("SRBAFD").Value = oServAgre.SRBAFD
                .Cells("CRGVTA").Value = oServAgre.CRGVTA
                'nuevos campos
                .Cells("CTPALM2").Value = oServAgre.CTPALM
                .Cells("TTPOMR").Value = oServAgre.TTPOMR
                '<[AHM]>
                .Cells("CDTSSP").Value = oServAgre.CDTSSP
                .Cells("CDUPSP").Value = oServAgre.CDUPSP
                .Cells("PRCODI").Value = oServAgre.PRCODI
                .Cells("CCNTCS").Value = oServAgre.CCNTCS
                '</[AHM]>
                'JM
                .Cells("CENCO2").Value = oServAgre.CENCO2
                .Cells("CENCOS").Value = oServAgre.CENCOS
                .Cells("ISRVTI").Value = oServAgre.ISRVTI
                .Cells("CCNBNS").Value = oServAgre.CCNBNS
            End With
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CargarTarifaFija(ByVal oServAgre As Servicio_BE, ByVal oServReembAgre As ServicioReembolso_BE)
        If oServAgre.NRTFSV_F.ToString.Trim <> 0 AndAlso (oServAgre.QATNAN_F <> 0 Or oServAgre.QATNAN_F <> "0.00") Then
            Dim oDrvW2 As DataGridViewRow
            oDrvW2 = New DataGridViewRow
            oDrvW2.CreateCells(Me.dgServicio)
            Me.dgServicio.Rows.Add(oDrvW2)
            With dgServicio.Rows(dgServicio.Rows.Count - 1)
                .Cells("NRTFSV_T").Value = oServAgre.NRTFSV_F ' Tarifa  
                .Cells("NRTFSV").Value = oServAgre.NRTFSV_F  'Tarifa Referencial
                .Cells("DESTAR").Value = oServAgre.TARIFA_DESC
                .Cells("VALCTE").Value = oServAgre.VALCTE
                .Cells("CUNDMD").Value = oServAgre.CUNDMD
                .Cells("NDIAPL_").Value = oServAgre.NDIAPL
                .Cells("TARIFAFIJA").Value = "X"
                Select Case oServicio.CTPALJ
                    Case estatico.E_ESP_AlmacenajePeso
                        '.Cells("QATNAN").Value = frmServAdd.txtCantidadServicio.txtDecimales.Text
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("FINPRF").Value = 0
                        .Cells("FFNPRF").Value = 0
                    Case estatico.E_ESP_ManipuleoPeso
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("FINPRF").Value = Comun.FormatoFecha(oServAgre.FINPRF)
                        .Cells("FFNPRF").Value = Comun.FormatoFecha(oServAgre.FFNPRF)
                    Case estatico.E_ESP_Reembolso
                        .Cells("IVLSRV").Value = oServReembAgre.IMPFAC * oServAgre.VALCTE * 0.01
                        .Cells("TOBSSR").Value = oServReembAgre.TOBSSR
                        .Cells("TPRVD").Value = oServReembAgre.TPRVD
                        .Cells("IMPFAC").Value = oServReembAgre.IMPFAC
                        .Cells("CTRMNC").Value = oServReembAgre.CTRMNC
                        .Cells("NGUITR").Value = oServReembAgre.NGUITR
                        .Cells("NRUCPR").Value = oServReembAgre.NRUCPR
                        .Cells("TPODOC").Value = oServReembAgre.TPODOC
                        .Cells("NUMDOC").Value = oServReembAgre.NUMDOC
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("FCHDOC").Value = oServReembAgre.FCHDOC
                        .Cells("ITPCMT").Value = oServReembAgre.ITPCMT
                    Case estatico.E_ESP_General, estatico.E_ESP_Permanencia, estatico.E_ESP_Manual, estatico.E_ESP_Adicional
                        .Cells("QATNAN").Value = oServAgre.QATNAN_F   'Aca si va
                        .Cells("QATNRL").Value = oServAgre.QATNRL
                        .Cells("IVLSRV").Value = oServAgre.IVLSRV_F 'oServAgre.IVLSRV
                End Select
                .Cells("TSGNMN").Value = oServAgre.TSGNMN
                .Cells("CCNTCS").Value = oServAgre.CCNTCS
                .Cells("TLUGEN").Value = oServAgre.TLUGEN
                .Cells("NORCML").Value = oServAgre.NORCML
                .Cells("TCTCST").Value = oServAgre.TCTCST
                .Cells("TRFSRC").Value = oServAgre.TRFSRC
                .Cells("TSRVC").Value = oServAgre.TSRVC
                .Cells("FATNSR").Value = Comun.FormatoFecha(oServAgre.FATNSR)
                .Cells("NRRUBR").Value = oServAgre.NRRUBR
                .Cells("NOPRCN").Value = 0
                If _ConsistenciaFac = True Then
                    .Cells("NCRROP2").Value = (Me.dgServicio.RowCount - 1) + 1
                Else
                    .Cells("NCRROP2").Value = dgServicio.Rows(0).Cells("NCRROP").Value + 1
                End If
                .Cells("SRBAFD").Value = oServAgre.SRBAFD
                .Cells("CRGVTA").Value = oServAgre.CRGVTA
                'nuevos campos
                .Cells("CTPALM2").Value = oServAgre.CTPALM
                .Cells("TTPOMR").Value = oServAgre.TTPOMR
                '<[AHM]>
                .Cells("CDTSSP").Value = oServAgre.CDTSSP
                .Cells("CDUPSP").Value = oServAgre.CDUPSP
                .Cells("PRCODI").Value = oServAgre.PRCODI
                .Cells("CCNTCS").Value = oServAgre.CCNTCS
                '</[AHM]>
                'JM
                .Cells("CENCO2").Value = oServAgre.CENCO2
                .Cells("CENCOS").Value = oServAgre.CENCOS
                .Cells("ISRVTI").Value = oServAgre.ISRVTI_F
                .Cells("CCNBNS").Value = oServAgre.CCNBNS
            End With
        Else
            Exit Sub
        End If
    End Sub




    Private Function ValidaLotesIguales(ByVal strLote As String) As Boolean

        For i As Integer = 0 To dgServicio.RowCount - 1
            If strLote <> dgServicio.Rows(i).Cells("TLUGEN").Value.ToString.Trim Then
                Return False
            End If
        Next

        Return True
    End Function
    Private Sub cargarSumaCantidades()

        Dim RsumTNM As Double = 0D
        Dim RsumMT2 As Double = 0D
        Dim RsumMT3 As Double = 0D
        For intCont As Integer = 0 To Me.dtgBultos.Rows.Count - 1
            RsumMT2 += Me.dtgBultos.Rows(intCont).Cells("QAROCP").Value
            RsumMT3 += Me.dtgBultos.Rows(intCont).Cells("QVLBTO").Value
            RsumTNM += Me.dtgBultos.Rows(intCont).Cells("QPSOBL").Value
        Next

        txtTNM.Text = RsumTNM
        txtMT2.Text = RsumMT2
        txtMT3.Text = RsumMT3
    End Sub

    Private Sub CargarMercaderiaOfServicio(ByVal dtTemp As DataTable)

        If Me.dtgMercaderia.DataSource Is Nothing And Not dtTemp Is Nothing Then

            Me.dtgMercaderia.DataSource = dtTemp

        ElseIf (Not dtTemp Is Nothing) Then

            For Each oDr As DataRow In dtTemp.Rows
                If Not fblnBuscarSolicitudServicioTemp(oDr) Then
                    Dim oDrMercaderia As DataRow
                    oDrMercaderia = Me.dtgMercaderia.DataSource.NewRow
                    For intColumna As Integer = 0 To dtTemp.Columns.Count - 1
                        oDrMercaderia.Item(intColumna) = oDr.Item(intColumna)
                        oDrMercaderia.Item("NCRROP4") = oDr("NCRROP4")
                        oDrMercaderia.Item("NCRRDC") = oDr("NCRRDC")
                    Next
                    Me.dtgMercaderia.DataSource.Rows.Add(oDrMercaderia)
                    dtgMercaderia.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgMercaderia.CurrentRow.Cells("CPRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                    dtgMercaderia.CurrentRow.Cells("NSRCN2").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
                End If
            Next

        End If
    End Sub

    Private Sub ModificarServicio()
        If dgServicio.Rows.Count = 0 Then Exit Sub
        Dim oServAgre As New Servicio_BE
        Dim oServAgre_BE As New clsServicio_BL
        Dim frmServAdd As Object = Nothing
        Dim oServReembAgre As New ServicioReembolso_BE
        '===============Para Ver el Detalle Sustento===============
        With dgServicio.CurrentRow
            oServAgre.SSTINV = cmbProceso.SelectedValue
            oServAgre.CCMPN = _oServicio.CCMPN
            oServAgre.CDVSN = _oServicio.CDVSN
            oServAgre.CTPALJ = _oServicio.CTPALJ
            oServAgre.CPLNDV = cmbPlanta.SelectedValue
            oServAgre.CCLNT = UcClienteOperacion.pCodigo
            oServAgre.CCLNFC = ucClienteFacturar.pCodigo
            oServAgre.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
            oServAgre.NRTFSV = .Cells("NRTFSV").Value
            oServAgre.TARIFA_DESC = .Cells("DESTAR").Value
            oServAgre.VALCTE = .Cells("VALCTE").Value
            oServAgre.CUNDMD = .Cells("CUNDMD").Value
            oServAgre.QATNAN = .Cells("QATNAN").Value
            oServAgre.QATNRL = .Cells("QATNRL").Value
            oServAgre.TSGNMN = .Cells("TSGNMN").Value
            oServAgre.CCNTCS = .Cells("CCNTCS").Value
            oServAgre.IVLSRV = .Cells("IVLSRV").Value
            oServAgre.TLUGEN = .Cells("TLUGEN").Value
            oServAgre.NORCML = .Cells("NORCML").Value
            oServAgre.TCTCST = .Cells("TCTCST").Value
            oServAgre.TSRVC = .Cells("TSRVC").Value

            oServAgre.TRFSRC = .Cells("TRFSRC").Value

            oServAgre.NOPRCN = .Cells("NOPRCN").Value
            oServAgre.NRRUBR = .Cells("NRRUBR").Value
            oServAgre.FATNSR = Comun.FormatoFechaAS400(.Cells("FATNSR").Value.ToString.Trim.Replace(" ", ""))
            oServAgre.FOPRCN = oServAgre.FATNSR
            oServAgre.TIPO = Comun.ESTADO_Modificado
            oServAgre.STPODP = _oServicio.STPODP
            oServicio.CTPALJ = cmbTipoServicio.SelectedValue
            'adicionamos campos tipo de almacen y tipo de material
            oServAgre.CTPALM = .Cells("CTPALM2").Value
            oServAgre.TTPOMR = .Cells("TTPOMR").Value
            '<[AHM]>
            oServAgre.CDTSSP = .Cells("CDTSSP").Value
            oServAgre.CDUPSP = .Cells("CDUPSP").Value
            oServAgre.PRCODI = .Cells("PRCODI").Value
            oServAgre.CCNTCS = .Cells("CCNTCS").Value
            '</[AHM]>
            'JM
            oServAgre.CENCO2 = .Cells("CENCO2").Value
            oServAgre.CENCOS = .Cells("CENCOS").Value


            Select Case oServicio.CTPALJ

                Case estatico.E_ESP_General
                    frmServAdd = New frmAgregaServicioGral
                    frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP").Value & "")
                    If frmServAdd.nCorr = 0 And oServAgre.TIPO = "M" Then frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP2").Value & "")
                    If dgServicio.RowCount = 1 Then frmServAdd.strLote = dgServicio.Rows(0).Cells("TLUGEN").Value.ToString.Trim

                Case estatico.E_ESP_AlmacenajePeso
                    frmServAdd = New frmBultosConfirma_2 'frmServEspAlmacenaje
                    oServAgre.FINPRF = Comun.FormatoFechaAS400(.Cells("FINPRF").Value)
                    oServAgre.FFNPRF = Comun.FormatoFechaAS400(.Cells("FFNPRF").Value)
                    frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP").Value & "")
                    If frmServAdd.nCorr = 0 And oServAgre.TIPO = "M" Then frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP2").Value & "")

                Case estatico.E_ESP_ManipuleoPeso
                    frmServAdd = New frmBultosConfirmarManipuleo
                    oServAgre.FINPRF = Comun.FormatoFechaAS400(.Cells("FINPRF").Value)
                    oServAgre.FFNPRF = Comun.FormatoFechaAS400(.Cells("FFNPRF").Value)
                    frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP").Value & "")
                    If frmServAdd.nCorr = 0 And oServAgre.TIPO = "M" Then frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP2").Value & "")

                Case estatico.E_ESP_Permanencia
                    frmServAdd = New frmAgregarServicioPermanencia 'frmServEspPorPermanencia
                    Dim Variable As Int32 = 0
                    Dim Fija As Int32 = 0



                    'oServAgre.NRTFSV = .Cells("NRTFSV").Value '.Cells("NRTFSV").Value
                    'oServAgre.CDTREF = .Cells("NRTFSV_T").Value
                    oServAgre.NDIAPL = .Cells("NDIAPL_").Value
                    frmServAdd.ConsistenciaFac = _ConsistenciaFac
                    If _ConsistenciaFac = True Then 'JM 
                        oServAgre.NRTFSV = _oServicio.NRTFSV
                        oServAgre.CDTREF = _oServicio.CDTREF

                        For i As Int32 = 0 To dgServicio.Rows.Count - 1
                            If dgServicio.Rows(i).Cells("TARIFAFIJA").Value = "X" Then
                                oServAgre.QATNAN_F = dgServicio.Rows(i).Cells("QATNAN").Value
                                oServAgre.IVLSRV_F = dgServicio.Rows(i).Cells("IVLSRV").Value

                                oServAgre.QATNAN = 0
                                oServAgre.IVLSRV = 0
                                Fija = 1
                            Else
                                oServAgre.QATNAN = dgServicio.Rows(i).Cells("QATNAN").Value
                                oServAgre.IVLSRV = dgServicio.Rows(i).Cells("IVLSRV").Value
                                Variable = 1

                            End If
                        Next
                        frmServAdd.Variable = Variable
                        frmServAdd.Fija = Fija
                    Else
                        oServAgre.NRTFSV = _oServicio.NRTFSV
                        oServAgre.CDTREF = _CDREF
                        For i As Int32 = 0 To dgServicio.Rows.Count - 1
                            If dgServicio.Rows(i).Cells("TARIFAFIJA").Value = "X" Then
                                oServAgre.QATNAN_F = dgServicio.Rows(i).Cells("QATNAN").Value
                                oServAgre.IVLSRV_F = dgServicio.Rows(i).Cells("IVLSRV").Value
                                oServAgre.QATNAN = 0
                                oServAgre.IVLSRV = 0
                                Fija = 1
                            Else
                                oServAgre.QATNAN = dgServicio.Rows(i).Cells("QATNAN").Value
                                oServAgre.IVLSRV = dgServicio.Rows(i).Cells("IVLSRV").Value
                                Variable = 1
                            End If
                        Next
                        frmServAdd.Variable = Variable
                        frmServAdd.Fija = Fija
                    End If

                Case estatico.E_ESP_PesoPromedio
                    frmServAdd = New frmServEspPorPromedio
                Case estatico.E_ESP_Reembolso
                    frmServAdd = New frmAgregarServicioReembolso 'frmServEspReembolso

                    oServAgre.NCRROP = Val("" & .Cells("NCRROP").Value & "")
                    If oServAgre.NCRROP = 0 Then oServAgre.NCRROP = .Cells("NCRROP2").Value

                    oServReembAgre.TOBSSR = .Cells("TOBSSR").Value
                    oServReembAgre.TPRVD = .Cells("TPRVD").Value
                    oServReembAgre.NRUCPR = .Cells("NRUCPR").Value
                    oServReembAgre.TPODOC = .Cells("TPODOC").Value
                    oServReembAgre.NUMDOC = .Cells("NUMDOC").Value
                    oServReembAgre.IMPFAC = .Cells("IMPFAC").Value
                    oServReembAgre.CTRMNC = .Cells("CTRMNC").Value
                    oServReembAgre.NGUITR = .Cells("NGUITR").Value
                    oServReembAgre.FCHDOC = .Cells("FCHDOC").Value
                    oServReembAgre.ITPCMT = .Cells("ITPCMT").Value
                    oServAgre.CTRMNC = .Cells("CTRMNC").Value
                    frmServAdd.oServicioReembolso = oServReembAgre
                    'valida datos de numero de documento por proveedor
                    Dim oDtDocumento As New DataTable
                    Dim dr As DataRow
                    oDtDocumento.Columns.Add("NRUCPR", GetType(String))
                    oDtDocumento.Columns.Add("NUMDOC", GetType(String))
                    oDtDocumento.Columns.Add("TPODOC", GetType(String))


                    For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
                        dr = oDtDocumento.NewRow
                        dr(0) = Me.dgServicio.Rows(intCont).Cells("NRUCPR").Value
                        dr(1) = Me.dgServicio.Rows(intCont).Cells("NUMDOC").Value
                        dr(2) = Me.dgServicio.Rows(intCont).Cells("TPODOC").Value
                        oDtDocumento.Rows.Add(dr)
                    Next
                    frmServAdd.oDtValidaDocumento = oDtDocumento
                    '================================================
                Case estatico.E_ESP_Adicional, estatico.E_ESP_Manual
                    frmServAdd = New frmAgregaServicioGral
                    frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP").Value & "")
                    If frmServAdd.nCorr = 0 And oServAgre.TIPO = "M" Then frmServAdd.nCorr = Val("" & dgServicio.CurrentRow.Cells("NCRROP2").Value & "")

            End Select



        End With

        '<[AHM]>
        frmServAdd.pNegocio = ucClienteFacturar.pNegocio
        '</[AHM]>

        frmServAdd.oServicio = oServAgre

        If Not rbServicio.Checked Then
            If _oServicio.CTPALJ = estatico.E_ESP_General Or _oServicio.CTPALJ = estatico.E_ESP_Adicional Or _oServicio.CTPALJ = estatico.E_ESP_Manual Or _oServicio.STPODP = Comun.eTipoAlmacen.DepSimple Then
                frmServAdd.Tipofrm = 1
            End If

        Else
            Select Case _oServicio.CDVSN
                Case "R"
                    If _oServicio.STPODP = Comun.eTipoAlmacen.AlmTransito Then
                        If _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso Or _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Or _
                             _oServicio.CTPALJ = estatico.E_ESP_General Or _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                            frmServAdd.oDtListaPorServicio = oDtCargaBulto

                            If _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso Or _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Then
                                frmServAdd.oDtListaPorServicio = oDtTempBultos()
                            End If
                            If Val("" & dgServicio.CurrentRow.Cells("NCRROP").Value & "") = 0 And dgServicio.RowCount > 0 Then
                                frmServAdd.oDtListaPorServicio = oDtTempBultos()
                            End If

                            If _oServicio.CTPALJ = estatico.E_ESP_Permanencia And dgServicio.RowCount > 0 Then
                                frmServAdd.oDtListaPorServicio = oDtTempBultos()
                            End If

                        End If
                    Else
                        If _oServicio.STPODP = Comun.eTipoAlmacen.DepSimple Then
                            frmServAdd.oDtListaPorServicio = ListaTempMercaderia(CType(dtgMercaderia.DataSource, DataTable).Copy)
                        End If
                    End If
                Case "S"
                    frmServAdd.oDtEmbarques = ListaTempEmbarques(CType(dtgEmbarque.DataSource, DataTable))
            End Select
        End If
        _oServicio.CCNTCS = oServAgre.CCNTCS
        '================= datos para validar detraccion y region venta=======================
        Dim oDtDetra As New DataTable
        Dim dre As DataRow
        oDtDetra.Columns.Add("SRBAFD", GetType(String))
        oDtDetra.Columns.Add("CRGVTA", GetType(String))
        For intCont As Integer = 0 To Me.dgServicio.Rows.Count - 1
            dre = oDtDetra.NewRow
            dre(0) = Me.dgServicio.Rows(intCont).Cells("SRBAFD").Value
            dre(1) = Me.dgServicio.Rows(intCont).Cells("CRGVTA").Value
            oDtDetra.Rows.Add(dre)
        Next
        frmServAdd.oDtValidaDetraccion = oDtDetra
        '========================================================================
        If frmServAdd.ShowDialog = Windows.Forms.DialogResult.OK Then
            oServAgre = frmServAdd.oServicio
            _oServicio.CCNTCS = oServAgre.CCNTCS
            'If _ConsistenciaFac = True AndAlso oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
            If oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                'oServReembAgre = frmServAdd.oServicioReembolso
                ActualizarTarifas(oServAgre, oServReembAgre)
            Else
                With dgServicio.CurrentRow
                    .Cells("NRTFSV").Value = oServAgre.NRTFSV
                    .Cells("DESTAR").Value = oServAgre.TARIFA_DESC
                    .Cells("VALCTE").Value = oServAgre.VALCTE
                    .Cells("CUNDMD").Value = oServAgre.CUNDMD
                    .Cells("QATNAN").Value = oServAgre.QATNAN
                    .Cells("QATNRL").Value = oServAgre.QATNRL
                    .Cells("TSGNMN").Value = oServAgre.TSGNMN
                    .Cells("CCNTCS").Value = oServAgre.CCNTCS
                    .Cells("IVLSRV").Value = oServAgre.IVLSRV
                    .Cells("TLUGEN").Value = oServAgre.TLUGEN
                    .Cells("NORCML").Value = oServAgre.NORCML
                    .Cells("TCTCST").Value = oServAgre.TCTCST
                    .Cells("TSRVC").Value = oServAgre.TSRVC
                    .Cells("FATNSR").Value = Comun.FormatoFecha(oServAgre.FATNSR)
                    .Cells("CUNDMD").Value = oServAgre.CUNDMD
                    .Cells("TRFSRC").Value = oServAgre.TRFSRC
                    .Cells("CENCO2").Value = oServAgre.CENCO2
                    .Cells("CENCOS").Value = oServAgre.CENCOS
                    '.Cells("IVLSRV").Value = oServicio.IVLSRV
                    Select Case oServicio.CTPALJ
                        Case estatico.E_ESP_AlmacenajePeso
                            '.Cells("QATNAN").Value = frmServAdd.txtCantidadServicio.txtDecimales.Text
                            'oServAgre.QATNAN = frmServAdd.txtCantidadServicio.txtDecimales.Text
                            .Cells("FINPRF").Value = 0
                            .Cells("FFNPRF").Value = 0
                        Case estatico.E_ESP_ManipuleoPeso
                            'cargarSumaCantidades()
                            'Select Case .Cells("CUNDMD").Value

                            '    Case Comun.UNIDAD_MT2
                            '        .Cells("QATNAN").Value = txtMT2.Text
                            '    Case Comun.UNIDAD_MT3
                            '        .Cells("QATNAN").Value = txtMT3.Text
                            '    Case Comun.UNIDAD_KGS
                            '        .Cells("QATNAN").Value = txtTNM.Text

                            'End Select

                            .Cells("FINPRF").Value = Comun.FormatoFecha(oServAgre.FINPRF)
                            .Cells("FFNPRF").Value = Comun.FormatoFecha(oServAgre.FFNPRF)

                        Case estatico.E_ESP_Reembolso
                            oServReembAgre = frmServAdd.oServicioReembolso
                            .Cells("IVLSRV").Value = oServReembAgre.IMPFAC * oServAgre.VALCTE * 0.01

                            .Cells("TOBSSR").Value = oServReembAgre.TOBSSR
                            .Cells("TPRVD").Value = oServReembAgre.TPRVD
                            .Cells("IMPFAC").Value = oServReembAgre.IMPFAC
                            .Cells("CTRMNC").Value = oServReembAgre.CTRMNC
                            .Cells("NGUITR").Value = oServReembAgre.NGUITR
                            .Cells("NRUCPR").Value = oServReembAgre.NRUCPR
                            .Cells("TPODOC").Value = oServReembAgre.TPODOC
                            .Cells("NUMDOC").Value = oServReembAgre.NUMDOC
                            .Cells("FCHDOC").Value = oServReembAgre.FCHDOC
                            .Cells("QATNAN").Value = oServAgre.QATNAN
                            .Cells("ITPCMT").Value = oServReembAgre.ITPCMT ' TIPO DE CAMBIO

                    End Select
                End With
            End If


            Select Case oServicio.CDVSN
                Case "R"
                    If _oServicio.STPODP = Comun.eTipoAlmacen.AlmTransito Then

                        If _oServicio.CTPALJ = estatico.E_ESP_AlmacenajePeso Or _oServicio.CTPALJ = estatico.E_ESP_ManipuleoPeso Or _
                              _oServicio.CTPALJ = estatico.E_ESP_General Or _oServicio.CTPALJ = estatico.E_ESP_Permanencia Then
                            mListaBultoServicio = frmServAdd.mListaBultoServicio
                            CargaBultoOfServicio(mListaBultoServicio, oServAgre.TIPO)

                            'With dgServicio.CurrentRow
                            '    Select Case oServicio.CTPALJ

                            '        Case estatico.E_ESP_AlmacenajePeso, estatico.E_ESP_ManipuleoPeso
                            '            cargarSumaCantidades()
                            '            Select Case .Cells("CUNDMD").Value

                            '                Case Comun.UNIDAD_MT2
                            '                    .Cells("QATNAN").Value = txtMT2.Text
                            '                Case Comun.UNIDAD_MT3
                            '                    .Cells("QATNAN").Value = txtMT3.Text
                            '                Case Comun.UNIDAD_KGS
                            '                    .Cells("QATNAN").Value = txtTNM.Text

                            '            End Select
                            '    End Select
                            'End With
                        End If

                    Else
                        If Me.rbServicio.Checked Then
                            CargarMercaderiaOfServicio(frmServAdd.oDtMercaderia)
                        End If
                    End If

                Case "S" 'SIL
                    If Me.rbServicio.Checked Then
                        CargaEmbarqueOfServicio(frmServAdd.oDtEmbarques)
                    End If
            End Select


        End If
    End Sub
#End Region

    Private Sub ActualizarTarifas(ByVal oServAgre As Servicio_BE, ByVal oServReembAgre As ServicioReembolso_BE)
        Dim tarifaVariable As Integer = 0
        Dim tarifaFija As Integer = 0
        For i As Integer = 0 To dgServicio.Rows.Count - 1
            With dgServicio.Rows(i)
                .Cells("DESTAR").Value = oServAgre.TARIFA_DESC
                .Cells("VALCTE").Value = oServAgre.VALCTE
                .Cells("CUNDMD").Value = oServAgre.CUNDMD
                '.Cells("QATNAN").Value = oServAgre.QATNAN
                .Cells("QATNRL").Value = oServAgre.QATNRL
                .Cells("TSGNMN").Value = oServAgre.TSGNMN
                .Cells("CCNTCS").Value = oServAgre.CCNTCS
                .Cells("IVLSRV").Value = oServAgre.IVLSRV
                .Cells("TLUGEN").Value = oServAgre.TLUGEN
                .Cells("NORCML").Value = oServAgre.NORCML
                .Cells("TCTCST").Value = oServAgre.TCTCST
                .Cells("TSRVC").Value = oServAgre.TSRVC
                .Cells("FATNSR").Value = Comun.FormatoFecha(oServAgre.FATNSR)
                .Cells("CUNDMD").Value = oServAgre.CUNDMD
                .Cells("TRFSRC").Value = oServAgre.TRFSRC
                Select Case oServicio.CTPALJ
                    Case estatico.E_ESP_AlmacenajePeso
                        '.Cells("QATNAN").Value = frmServAdd.txtCantidadServicio.txtDecimales.Text
                        'oServAgre.QATNAN = frmServAdd.txtCantidadServicio.txtDecimales.Text
                        .Cells("FINPRF").Value = 0
                        .Cells("FFNPRF").Value = 0
                    Case estatico.E_ESP_ManipuleoPeso
                        'cargarSumaCantidades()
                        'Select Case .Cells("CUNDMD").Value

                        '    Case Comun.UNIDAD_MT2
                        '        .Cells("QATNAN").Value = txtMT2.Text
                        '    Case Comun.UNIDAD_MT3
                        '        .Cells("QATNAN").Value = txtMT3.Text
                        '    Case Comun.UNIDAD_KGS
                        '        .Cells("QATNAN").Value = txtTNM.Text

                        'End Select
                        .Cells("FINPRF").Value = Comun.FormatoFecha(oServAgre.FINPRF)
                        .Cells("FFNPRF").Value = Comun.FormatoFecha(oServAgre.FFNPRF)

                    Case estatico.E_ESP_Reembolso
                        'oServReembAgre = frmServAdd.oServicioReembolso
                        .Cells("IVLSRV").Value = oServReembAgre.IMPFAC * oServAgre.VALCTE * 0.01
                        .Cells("TOBSSR").Value = oServReembAgre.TOBSSR
                        .Cells("TPRVD").Value = oServReembAgre.TPRVD
                        .Cells("IMPFAC").Value = oServReembAgre.IMPFAC
                        .Cells("CTRMNC").Value = oServReembAgre.CTRMNC
                        .Cells("NGUITR").Value = oServReembAgre.NGUITR
                        .Cells("NRUCPR").Value = oServReembAgre.NRUCPR
                        .Cells("TPODOC").Value = oServReembAgre.TPODOC
                        .Cells("NUMDOC").Value = oServReembAgre.NUMDOC
                        .Cells("FCHDOC").Value = oServReembAgre.FCHDOC
                        .Cells("QATNAN").Value = oServAgre.QATNAN
                        .Cells("ITPCMT").Value = oServReembAgre.ITPCMT ' TIPO DE CAMBIO
                End Select
                If dgServicio.Rows(i).Cells("TARIFAFIJA").Value = "X" Then
                    .Cells("NRTFSV").Value = oServAgre.NRTFSV_F
                    .Cells("QATNAN").Value = oServAgre.QATNAN_F
                    .Cells("IVLSRV").Value = oServAgre.IVLSRV_F
                    .Cells("ISRVTI").Value = oServAgre.ISRVTI_F
                    .Cells("CENCO2").Value = oServAgre.CENCO2
                    .Cells("CENCOS").Value = oServAgre.CENCOS
                    .Cells("CCNBNS").Value = oServAgre.CCNBNS
                    tarifaFija = 1
                Else
                    .Cells("NRTFSV").Value = oServAgre.NRTFSV
                    .Cells("QATNAN").Value = oServAgre.QATNAN
                    .Cells("IVLSRV").Value = oServAgre.IVLSRV
                    .Cells("ISRVTI").Value = oServAgre.ISRVTI
                    .Cells("CENCO2").Value = oServAgre.CENCO2
                    .Cells("CENCOS").Value = oServAgre.CENCOS
                    .Cells("CCNBNS").Value = oServAgre.CCNBNS
                    tarifaVariable = 1
                End If
            End With
        Next

        'AGREGA--------------------------------------------------
        If tarifaFija = 0 Then
            CargarTarifaFija(oServAgre, oServReembAgre)
            'tarifaFija = 1
        End If
        If tarifaVariable = 0 And oServAgre.QATNAN <> 0 Then
            CargarTarifaVariable(oServAgre, oServReembAgre)
            'tarifaVariable = 1
        End If
        '---------------------------------------------------------

        'ELIMINA ------------------------------------------------
        If dgServicio.Rows.Count > 0 Then

            If tarifaVariable <> 0 Then
                For i As Integer = 0 To dgServicio.Rows.Count - 1
                    If String.IsNullOrEmpty(dgServicio.Rows(i).Cells("NCRROP_1").Value) Then
                        If dgServicio.Rows(i).Cells("QATNAN").Value = 0 And dgServicio.Rows(i).Cells("TARIFAFIJA").Value = String.Empty Then
                            Me.dgServicio.Rows.RemoveAt(i)
                            tarifaVariable = 0
                        End If
                    Else
                        If dgServicio.Rows(i).Cells("QATNAN").Value = 0 And dgServicio.Rows(i).Cells("TARIFAFIJA").Value = String.Empty Then
                            Dim oServicio_BE As New Servicio_BE
                            Dim oServicioBL As New clsServicio_BL
                            oServicio_BE.CCLNT = Me.UcClienteOperacion.pCodigo
                            oServicio_BE.NOPRCN = dgServicio.Rows(i).Cells("NOPRCN").Value
                            oServicio_BE.NCRROP = dgServicio.Rows(i).Cells("NCRROP").Value
                            oServicio_BE.SESTRG = "*"
                            oServicio_BE.CCNTCS = dgServicio.Rows(i).Cells("CCNTCS").Value
                            oServicio_BE.PSUSUARIO = _oServicio.PSUSUARIO
                            oServicio_BE.TIPO_PROCESO = IIf(rbServicio.Checked, 1, 0)
                            'If Not String.IsNullOrEmpty(dgServicio.Rows(i).Cells("NCRROP_1").Value.ToString.Trim) Then
                            If oServicioBL.EliminarServiciosFacturacionAlmacenaje(oServicio_BE) = 0 Then
                                MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                                Exit For
                            Else
                                Me.dgServicio.Rows.RemoveAt(i)
                                tarifaVariable = 0
                            End If
                            'End If
                        End If
                    End If
                Next
            End If
        End If
        '------------------------------------------------------------------
    End Sub
    Private Sub formatTable(ByVal oDt As DataTable)
        oDt.Columns.Add("CREFFW", GetType(String))
        oDt.Columns.Add("DESCWB", GetType(String))
        oDt.Columns.Add("TUBRFR", GetType(String))
        oDt.Columns.Add("QREFFW", GetType(Integer))
        oDt.Columns.Add("TIPBTO", GetType(String))
        oDt.Columns.Add("QPSOBL", GetType(String))
        oDt.Columns.Add("TUNPSO", GetType(String))
        oDt.Columns.Add("QVLBTO", GetType(String))
        oDt.Columns.Add("TUNVOL", GetType(String))
        oDt.Columns.Add("SESTRG", GetType(String))
        oDt.Columns.Add("CPRCN1", GetType(String))
        oDt.Columns.Add("QAROCP", GetType(String))
        oDt.Columns.Add("NSRCN1", GetType(String))

        oDt.Columns.Add("CTPALM", GetType(String))
        oDt.Columns.Add("CZNALM", GetType(String))
        oDt.Columns.Add("NSEQIN", GetType(String))
        oDt.Columns.Add("NCRROP", GetType(String))
        oDt.Columns.Add("NCRRDC", GetType(String))
        oDt.Columns.Add("CALMC", GetType(String))

        oDt.Columns.Add("SSNCRG", GetType(String))
        oDt.Columns.Add("SSNCRG_D", GetType(String))
        oDt.Columns.Add("TLUGEN", GetType(String))

        oDt.Columns.Add("TCMZNA", GetType(String))
        oDt.Columns.Add("TCMPAL", GetType(String))

        oDt.Columns.Add("TALMC", GetType(String))

        oDt.Columns.Add("FOPRCN", GetType(String))
        oDt.Columns.Add("FINPRF", GetType(String))
        oDt.Columns.Add("FFNPRF", GetType(String))

        oDt.Columns.Add("QPRDFC", GetType(String))
        oDt.Columns.Add("NDIAPL", GetType(String))
        oDt.Columns.Add("FINGAL", GetType(String))
        oDt.Columns.Add("FSLDAL", GetType(String))

        oDt.Columns.Add("NGRPRV", GetType(String))
        oDt.Columns.Add("NGUIRM", GetType(String))
        oDt.Columns.Add("NRGUSA", GetType(String))

    End Sub

    Private Function oDtTempBultos() As DataTable

        Dim NCRROP2 As Integer = 0
        Dim drAux As DataRow
        oDtCargaBulto = oDtCargaBulto.Clone
        Dim dtAux As New DataTable
        formatTable(dtAux)

        For i As Integer = 0 To dtgBultos.Rows.Count - 1 'Registros Hechos
            drAux = dtAux.NewRow
            If dgServicio.CurrentRow.Cells("NCRROP2").Value = dtgBultos.Rows(i).Cells("NCRROP3").Value And dtgBultos.Rows(i).Cells("SESTRG").Value <> "*" Then
                drAux("CREFFW") = dtgBultos.Rows(i).Cells("CREFFW").Value
                drAux("DESCWB") = dtgBultos.Rows(i).Cells("DESCWB").Value
                drAux("TUBRFR") = dtgBultos.Rows(i).Cells("TUBRFR").Value
                drAux("QREFFW") = dtgBultos.Rows(i).Cells("QREFFW").Value
                drAux("TIPBTO") = dtgBultos.Rows(i).Cells("TIPBTO").Value
                drAux("QPSOBL") = dtgBultos.Rows(i).Cells("QPSOBL").Value
                drAux("TUNPSO") = dtgBultos.Rows(i).Cells("TUNPSO").Value
                drAux("QVLBTO") = dtgBultos.Rows(i).Cells("QVLBTO").Value
                drAux("TUNVOL") = dtgBultos.Rows(i).Cells("TUNVOL").Value
                drAux("QAROCP") = dtgBultos.Rows(i).Cells("QAROCP").Value
                drAux("SESTRG") = dtgBultos.Rows(i).Cells("SESTRG").Value
                drAux("CPRCN1") = "" & dtgBultos.Rows(i).Cells("CPRCN1").Value & ""
                drAux("NSRCN1") = "" & dtgBultos.Rows(i).Cells("NSRCN1").Value & ""
                drAux("CTPALM") = dtgBultos.Rows(i).Cells("CTPALM").Value
                drAux("CALMC") = Convert.ToString(dtgBultos.Rows(i).Cells("CALMC").Value)
                drAux("CZNALM") = dtgBultos.Rows(i).Cells("CZNALM").Value
                drAux("NSEQIN") = dtgBultos.Rows(i).Cells("NSEQIN").Value
                drAux("NCRROP") = dtgBultos.Rows(i).Cells("NCRROP3").Value

                drAux("SSNCRG") = Convert.ToString(dtgBultos.Rows(i).Cells("SSNCRG").Value)
                drAux("SSNCRG_D") = Convert.ToString(dtgBultos.Rows(i).Cells("SSNCRG_D").Value)
                drAux("TLUGEN") = Convert.ToString(dtgBultos.Rows(i).Cells("TLUGEN2").Value)
                drAux("TCMZNA") = Convert.ToString(dtgBultos.Rows(i).Cells("TCMZNA").Value)

                drAux("TALMC") = Convert.ToString(dtgBultos.Rows(i).Cells("TALMC").Value)
                drAux("TCMPAL") = Convert.ToString(dtgBultos.Rows(i).Cells("TCMPAL").Value)

                drAux("QPRDFC") = Convert.ToString(dtgBultos.Rows(i).Cells("QPRDFC").Value)
                drAux("NDIAPL") = Convert.ToString(dtgBultos.Rows(i).Cells("NDIAPL").Value)
                drAux("FINGAL") = Convert.ToString(dtgBultos.Rows(i).Cells("FINGAL").Value)
                drAux("FSLDAL") = Convert.ToString(dtgBultos.Rows(i).Cells("FSLDAL").Value)

                drAux("NGRPRV") = Convert.ToString(dtgBultos.Rows(i).Cells("NGRPRV").Value)
                drAux("NGUIRM") = Convert.ToString(dtgBultos.Rows(i).Cells("NGUIRM").Value)
                drAux("NRGUSA") = Convert.ToString(dtgBultos.Rows(i).Cells("NRGUSA").Value)



                dtAux.Rows.Add(drAux)
            End If

        Next
        oDtCargaBulto = dtAux

        Return oDtCargaBulto
    End Function

    Private Function ListaTempMercaderia(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        dtTemp = dt.Clone
        For Each dr As DataRow In dt.Select("NCRROP4=" & dgServicio.CurrentRow.Cells("NCRROP2").Value)
            dtTemp.ImportRow(dr)
        Next
        Return dtTemp
    End Function

    Private Function ListaTempEmbarques(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        dtTemp = dt.Clone
        For Each dr As DataRow In dt.Select("NCRROP5=" & dgServicio.CurrentRow.Cells("NCRROP2").Value & " AND SESTRG_EMB <> '*' ")
            dtTemp.ImportRow(dr)
        Next
        Return dtTemp
    End Function

    Private Sub btnAgregarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTermino.Click
        If UcClienteOperacion.pCodigo = 0 Then Exit Sub
        If (Me.cmbTerminoBusquedaSAT.Text <> "" OrElse cmbTerminoBusquedaDS.Text <> "" OrElse cmbTerminoBusquedaSIL.Text <> "") And txtCodigo.Text <> "" Then
            If _oServicio.CDVSN = "S" Then
                BuscarSustentoSIL()
            Else
                If _oServicio.STPODP = "7" Then
                    BuscarBultos()
                Else
                    BuscarSolicituServicio()
                End If
            End If

        End If
    End Sub

    Private Sub BtnEliminarTermino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTermino.Click
        EliminarDetalleOperacion()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'If AccesoModif_OPValorizada = False Then
        '    MessageBox.Show("La operación se encuentra valorizada.")
        '    Exit Sub
        'End If
        If oServicio.NSECFC > 0 Then
            MessageBox.Show("No puede ejecutar la acción a una operación consistenciada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        AgregarServicio()


    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If oServicio.NSECFC > 0 Then
            MessageBox.Show("No puede ejecutar la acción a una operación consistenciada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ModificarServicio()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If Me.dgServicio.CurrentCellAddress.Y = -1 Then Exit Sub

        If oServicio.NSECFC > 0 Then
            MessageBox.Show("No puede ejecutar la acción a una operación consistenciada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.dgServicio.Rows.Count > 0 Then

            If Me.dgServicio.CurrentRow.Cells("NOPRCN").Value = 0 Then

                If _ConsistenciaFac = True AndAlso oServicio.CTPALJ = estatico.E_ESP_Permanencia Then ' TARIFA FIJA
                    dgServicio.Rows.Clear()
                    btnAgregar.Enabled = True
                Else
                    Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)
                    If dgServicio.RowCount < 2 Then
                        bolDiferenteLote = True
                    End If
                End If
                'Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)   'DESCOMENTAR JM
                'If dgServicio.RowCount < 2 Then
                '    bolDiferenteLote = True
                'End If
            Else
                If oServicio.CTPALJ = estatico.E_ESP_Permanencia Then 'TARIFA FIJA
                    If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                        For i As Integer = 0 To dgServicio.Rows.Count - 1
                            Dim oServicio_BE As New Servicio_BE
                            Dim oServicioBL As New clsServicio_BL
                            oServicio_BE.CCLNT = Me.UcClienteOperacion.pCodigo
                            oServicio_BE.NOPRCN = dgServicio.Rows(i).Cells("NOPRCN").Value
                            oServicio_BE.NCRROP = dgServicio.Rows(i).Cells("NCRROP").Value
                            oServicio_BE.SESTRG = "*"
                            oServicio_BE.CCNTCS = dgServicio.Rows(i).Cells("CCNTCS").Value
                            oServicio_BE.PSUSUARIO = _oServicio.PSUSUARIO
                            oServicio_BE.TIPO_PROCESO = IIf(rbServicio.Checked, 1, 0)

                            If Not String.IsNullOrEmpty(dgServicio.Rows(i).Cells("NCRROP_1").Value.ToString.Trim) Then
                                If oServicioBL.EliminarServiciosFacturacionAlmacenaje(oServicio_BE) = 0 Then
                                    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                                    Exit For
                                End If
                            End If
                        Next
                        dgServicio.Rows.Clear()
                        btnAgregar.Enabled = True
                    End If
                Else
                    'Original solo este if
                    If Comun.RspMsgBox(Comun.Mensaje("MENSAJE.CONFIRMA.ELIMINA.SERVICIO")) = Windows.Forms.DialogResult.Yes Then
                        Dim oServicio_BE As New Servicio_BE
                        Dim oServicioBL As New clsServicio_BL
                        oServicio_BE.CCLNT = Me.UcClienteOperacion.pCodigo
                        oServicio_BE.NOPRCN = dgServicio.CurrentRow.Cells("NOPRCN").Value
                        oServicio_BE.NCRROP = dgServicio.CurrentRow.Cells("NCRROP").Value
                        oServicio_BE.SESTRG = "*"
                        oServicio_BE.CCNTCS = dgServicio.CurrentRow.Cells("CCNTCS").Value
                        oServicio_BE.PSUSUARIO = _oServicio.PSUSUARIO
                        oServicio_BE.TIPO_PROCESO = IIf(rbServicio.Checked, 1, 0)
                        If oServicioBL.EliminarServiciosFacturacionAlmacenaje(oServicio_BE) = 0 Then
                            MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                        Else
                            If dgServicio.RowCount < 2 Then
                                bolDiferenteLote = True
                            End If
                            Me.dgServicio.Rows.RemoveAt(Me.dgServicio.CurrentCellAddress.Y)
                            ' Me.DialogResult = Windows.Forms.DialogResult.OK

                        End If
                    End If
                End If
            End If

            Select Case _oServicio.CDVSN
                Case "R"
                    If dgServicio.Rows.Count = 0 Then
                        cmbTipoServicio.Enabled = True
                        dtgBultos.Rows.Clear()
                    End If
                Case "S"
                    cmbTipoServicio.Enabled = False
            End Select



        End If
    End Sub

    Private Function ValidarTamanioNrIntero(ByVal decNr As Decimal, ByVal intCant As Integer) As Boolean
        If decNr.ToString.Split(".").Length > 2 Then
            Return False
        Else
            If decNr.ToString.Split(".").GetValue(0).ToString.Length > 10 Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub dtgMercaderia_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dtgMercaderia.UserAddedRow
        e.Row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
        e.Row.Cells("CPRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        e.Row.Cells("NSRCN1").Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    Private Sub rbOperacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOperacion.CheckedChanged
        If rbOperacion.Checked Then
            KryptonSplitContainer1.Panel1MinSize = 25
            KryptonSplitContainer1.SplitterDistance = 187
            KryptonSplitContainer1.IsSplitterFixed = False
        End If
    End Sub

    Private Sub rbServicio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbServicio.CheckedChanged
        If rbServicio.Checked Then
            KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
            KryptonSplitContainer1.Panel2MinSize = 0
            KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height
            KryptonSplitContainer1.IsSplitterFixed = True
            Me.Size = New Size(930, 607)
        End If

    End Sub

    Private Sub rbNinguno_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNinguno.CheckedChanged
        If rbNinguno.Checked Then
            KryptonSplitContainer1.SplitterDistance = KryptonSplitContainer1.Height
            KryptonSplitContainer1.Panel2MinSize = 0
            KryptonSplitContainer1.Panel1MinSize = KryptonSplitContainer1.Height
            KryptonSplitContainer1.IsSplitterFixed = True
            Me.Size = New Size(930, 607)
        End If
    End Sub


    Private Sub cmbTipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoServicio.SelectedIndexChanged
        Try
            If Not cmbTipoServicio.SelectedValue.ToString Is Nothing Then
                If cmbTipoServicio.SelectedValue.ToString = "MP" Or cmbTipoServicio.SelectedValue.ToString = "AP" _
                   Or cmbTipoServicio.SelectedValue.ToString = "RE" Or cmbTipoServicio.SelectedValue.ToString = "PE" Then
                    rbServicio.Checked = True
                    rbServicio.Enabled = True
                    rbNinguno.Enabled = False
                    rbOperacion.Enabled = False
                Else
                    If Not _oServicio.TIPO = Comun.ESTADO_Modificado Then

                        Select Case _oServicio.CDVSN
                            Case "R", "S"

                                rbOperacion.Checked = True

                                rbNinguno.Enabled = True
                                rbOperacion.Enabled = True
                                rbServicio.Enabled = True

                            Case Else
                                rbNinguno.Enabled = True
                                rbOperacion.Enabled = False
                                rbServicio.Enabled = False
                                rbNinguno.Checked = True
                                rbOperacion_CheckedChanged(Nothing, Nothing)
                        End Select
                    End If
                End If
                If Not _oServicio.TIPO = Comun.ESTADO_Modificado Then
                    _oServicio.CTPALJ = Me.cmbTipoServicio.SelectedValue.ToString
                    If _oServicio.CTPALJ = "AP" Or oServicio.CTPALJ = "PE" Then
                        cmbProceso.SelectedValue = "A"
                    Else
                        If _oServicio.CDVSN = "R" Then
                            cmbProceso.SelectedValue = "R"
                        Else
                            cmbProceso.SelectedValue = "O"
                        End If

                    End If

                    Select Case _oServicio.CTPALJ
                        Case estatico.E_ESP_General
                            Me.Text = "SERVICIO GENERAL - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                        Case estatico.E_ESP_AlmacenajePeso
                            Me.Text = "SERVICIO DE ALMACENAJE POR FECHA DE CORTE - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                        Case estatico.E_ESP_ManipuleoPeso
                            Me.Text = "SERVICIO DE MANIPULEO  POR FECHA DE CORTE - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                        Case estatico.E_ESP_Reembolso
                            Me.Text = "SERVICIO POR REEMBOLSO - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                        Case estatico.E_ESP_Permanencia
                            Me.Text = "SERVICIO DE ALMACENAJE POR PERMANENCIA - " & Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")

                    End Select

                End If
            End If

        Catch : End Try
    End Sub

    Private Sub calcularMontoTotal()

        Dim dblTotalizaR As Double = 0
        Dim dblTotalizaD As Double = 0
        If dgServicio.Rows.Count > 0 Then
            For i As Integer = 0 To dgServicio.Rows.Count - 1
                dblTotalizaR = dblTotalizaR + (dgServicio.Rows(i).Cells("QATNAN").Value * dgServicio.Rows(i).Cells("IVLSRV").Value)
            Next
        End If

        txtMontoTotal.Text = dblTotalizaR.ToString("N2")
    End Sub


    Private Sub BuscarSustentoSIL()
        Dim oSerAlmacen As New Servicio_BE
        Dim CodigoBusqueda As Decimal = 0
        Dim IsValidoCodigo As Boolean = False
        If Decimal.TryParse(txtCodigo.Text.Trim, CodigoBusqueda) Then
            With oSerAlmacen
                .CCLNT = Me.UcClienteOperacion.pCodigo
                .NOPRCN = _oServicio.NOPRCN
                .CCMPN = _oServicio.CCMPN
                .CDVSN = _oServicio.CDVSN
                .CPLNDV = cmbPlanta.SelectedValue
                Select Case Mid(Me.cmbTerminoBusquedaSIL.Text, 1, 1)
                    Case "E"
                        .NORSCI = CodigoBusqueda
                        .PSBUSQUEDA = "E"
                    Case "O"
                        .PNNMOS = CodigoBusqueda
                        .PSBUSQUEDA = "O"
                End Select
            End With
            BuscarEmbarque(oSerAlmacen)
        End If
    End Sub


    Private Sub BuscarEmbarque(ByVal oSerAlmacen As Servicio_BE)

        Dim msgValidacionEmbarque As String = ""

        Dim oDt As DataTable

        If cmbTipoServicio.SelectedValue = estatico.E_ESP_General Or cmbTipoServicio.SelectedValue = estatico.E_ESP_Adicional Then
            If dtgEmbarque.Rows.Count = 1 Then
                MessageBox.Show("No se puede agregar más de un embarque cuando es de tipo " & cmbTipoServicio.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        msgValidacionEmbarque = obrclsServicioSC_BL.ValidaIngresoEmbarqueAOperacion(oSerAlmacen)

        If (msgValidacionEmbarque.Length <> 0) Then
            MessageBox.Show(msgValidacionEmbarque, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        oDt = obrclsServicioSC_BL.Lista_OC_X_Embarque_OS(oSerAlmacen)

        With oDt
            If oDt.Rows.Count > 0 Then
                For intRow As Integer = 0 To dtgEmbarque.Rows.Count - 1
                    For intCont As Integer = .Rows.Count - 1 To 0 Step -1
                        If (dtgEmbarque.Rows(intRow).Cells("NORSCI").Value.ToString.Trim = .Rows(intCont).Item("NORSCI").ToString.Trim) Then
                            oDt.Rows.RemoveAt(intCont)
                        End If
                    Next intCont
                Next
            End If
        End With


        If oDt.Rows.Count > 0 Then
            If dtgEmbarque.DataSource Is Nothing Then dtgEmbarque.DataSource = oDt.Clone
            lblItems.Text = oDt.Rows.Count + Val(lblItems.Text)
            For Each dr As DataRow In oDt.Rows
                dtgEmbarque.DataSource.ImportRow(dr)

            Next

            txtCodigo.Text = ""
            txtCodigo.Focus()
        End If



    End Sub


    Private Function GrabarSustentoSIL() As Boolean
        Dim oServicioDetalleEmbarque As Servicio_BE
        Dim oListServicioDetalleEmbarque As New List(Of Servicio_BE)
        For Fila As Int32 = 0 To Me.dtgEmbarque.Rows.Count - 1
            oServicioDetalleEmbarque = New Servicio_BE
            oServicioDetalleEmbarque.NOPRCN = _oServicio.NOPRCN
            oServicioDetalleEmbarque.CCLNT = _oServicio.CCLNT
            oServicioDetalleEmbarque.NORSCI = dtgEmbarque.Rows(Fila).Cells("NORSCI").Value
            oServicioDetalleEmbarque.PSUSUARIO = ConfigurationWizard.UserName
            oListServicioDetalleEmbarque.Add(oServicioDetalleEmbarque)
        Next
        Dim obrServicio As New clsServicioSC_BL

        If obrServicio.Insertar_Servicio_Facturar_Embarques(oListServicioDetalleEmbarque) = -1 Then
            MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
            Return False
        End If
        Return True

    End Function

    Private Function GrabarSustentoSILxServicio(ByVal NCRROP As Integer, ByVal NSECUENCIA As Integer) As Boolean
        Dim obrServicio As New clsServicioSC_BL
        Dim bolResultado As Boolean = True
        Dim oServicioDetalleEmbarque As Servicio_BE
        Dim oListServicioDetalleEmbarque As New List(Of Servicio_BE)
        For Each dr As DataRow In Me.dtgEmbarque.DataSource.Rows
            oServicioDetalleEmbarque = New Servicio_BE

            If dr("NCRROP5") = NSECUENCIA And dr("SESTRG_EMB") <> "*" Then
                oServicioDetalleEmbarque.NOPRCN = _oServicio.NOPRCN
                oServicioDetalleEmbarque.CCLNT = _oServicio.CCLNT
                oServicioDetalleEmbarque.NORSCI = dr("NORSCI")
                oServicioDetalleEmbarque.NCRROP = NCRROP
                oServicioDetalleEmbarque.PSUSUARIO = ConfigurationWizard.UserName
                oListServicioDetalleEmbarque.Add(oServicioDetalleEmbarque)
            End If

        Next

        If obrServicio.Insertar_Servicio_Facturar_Embarques(oListServicioDetalleEmbarque) = -1 Then
            MsgBox(oServicio.PSERROR, MessageBoxIcon.Information, "Validación")
            bolResultado = False
        End If
        Return bolResultado

    End Function

    Private Function ActualizaEmbarques(ByVal SECUENCIA As Integer) As Boolean
        Dim obrServicio As New clsServicioSC_BL
        Dim oServicioDetalleEmbarque As New Servicio_BE
        Dim Retorno As Integer = 0
        Dim blnResultado As Boolean = True

        If dtgEmbarque.Rows.Count > 0 And oServicio.NOPRCN <> 0 Then

            For Each dr As DataRow In Me.dtgEmbarque.DataSource.Rows
                If SECUENCIA = Val("" & dr("NCRROP5") & "") Then

                    oServicioDetalleEmbarque.CCLNT = oServicio.CCLNT
                    oServicioDetalleEmbarque.NOPRCN = oServicio.NOPRCN
                    oServicioDetalleEmbarque.NCRROP = SECUENCIA
                    oServicioDetalleEmbarque.NORSCI = dr("NORSCI")
                    oServicioDetalleEmbarque.NRITEM = dr("NRITEM")
                    oServicioDetalleEmbarque.PSUSUARIO = oServicio.PSUSUARIO

                    If dr("NRITEM") = 0 And dr("SESTRG_EMB") <> "*" Then
                        Retorno = obrServicio.Insertar_Servicio_Facturar_Embarques(oServicioDetalleEmbarque)

                    End If
                End If
            Next
        End If
        If Retorno = -1 Then
            MsgBox("Error al actualizar detalle de embarques", MessageBoxIcon.Information, "Error")
            Return False
        End If
        Return blnResultado
    End Function

    Private Sub Llenar_Embarques_x_Operacion(ByVal CCLNT As Decimal, ByVal NOPRCN As Decimal)
        Dim oDt As New DataTable
        Dim obeServicio As New Servicio_BE
        Dim NCRROP As Integer = 0
        obeServicio.CCLNT = CCLNT
        obeServicio.NOPRCN = NOPRCN
        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        Dim odtServicioSC As New DataTable
        oDt = obrclsServicioSC_BL.Lista_Detalle_Servicios_SC(obeServicio)
        If oDt.Rows.Count > 0 Then NCRROP = oDt.Rows(0).Item("NCRROP")

        dtgEmbarque.DataSource = oDt
        lblItems.Text = oDt.Rows.Count.ToString

        If NCRROP > 0 Then
            rbNinguno.Enabled = False
            rbOperacion.Enabled = False
            rbServicio.Checked = True
        Else
            If oDt.Rows.Count = 0 Then
                rbServicio.Enabled = False
                rbOperacion.Enabled = False
                rbNinguno.Checked = True
            Else
                rbServicio.Enabled = False
                rbNinguno.Enabled = False
                rbOperacion.Checked = True
            End If
        End If
    End Sub

    Private Sub lblMontoRecepción_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblMontoRecepción.Paint

    End Sub

    Public Sub InHabilitarControlesConsistenciaFac()
        cmbProceso.Enabled = False
        cmbTipoServicio.Enabled = False
        If dgServicio.Rows.Count > 0 Then
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Function ValidarClientes() As String
        Dim ClientOpe As Int32 = ClineteInterno(_oServicio.CCMPN, UcClienteOperacion.pCodigo)
        Dim ClientFac As Int32 = ClineteInterno(_oServicio.CCMPN, ucClienteFacturar.pCodigo)
        Dim mensaje As String = ""
        If ClientOpe <> ClientFac Then
            mensaje = "Tipo de cliente a Facturar  es distinto al cliente de la operación."
        End If
        Return mensaje
    End Function


    Private Function ClineteInterno(ByVal CCMPN As String, ByVal pCodigoCliente As String) As Int32
        Dim Interno As Int32 = 0
        Dim objNcliente As New clsCliente_BL
        Dim ListaCliente As New List(Of Cliente_BE)
        ListaCliente = objNcliente.Validar_Cliente_Interno_v2(CCMPN, pCodigoCliente)
        If ListaCliente.Count > 0 Then
            Interno = 1
        End If
        Return Interno
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim ofrm As New Ransa.Utilitario.frmBuscarDireccionServicio
        ofrm.PSCCMPN = _oServicio.CCMPN
        ofrm.PSCDVSN = _oServicio.CDVSN
        ofrm.PNCCLNTOP = UcClienteOperacion.pCodigo
        ofrm.PNCCLNTFC = ucClienteFacturar.pCodigo
        ofrm.PNCPLNDVOP = cmbPlanta.SelectedValue
        ofrm.PNCPLNDVFC = 0
        ofrm.PSTIPODIR = "P"

        If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDireccion.Text = ofrm.DatoDireccion
            txtUbigeo.Text = ofrm.DatoUbigeo
            _codigoDireccionServicio = ofrm.DatoCodigo

        End If
    End Sub

    Private Sub cmbPlanta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectionChangeCommitted
        Try
            'If _codigoDireccionServicio = 0 Then
            CargarDirServicioXDefecto()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


