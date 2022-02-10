Imports Ransa.NEGO
Imports Ransa.TypeDef.OrdenCompra
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Utilitario

Public Class ucOrdenCompra_MOC
#Region " Definición Eventos "
    '-------------------------------------------------
    ' Eventos a Informar
    '-------------------------------------------------
    Public Event pDisposeForm(ByVal bStatusProceso As Boolean)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private TD_OCPK As TD_OrdenCompraPK = New Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
    Private strMensajeError As String = ""
    Private nNroRegGrabados As Int16 = 0

    Private oMItemOC As ucItemOC_MItem = Nothing
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
    Private strUsuario As String = ""
    Private bolImportadoYRC As Boolean = False
    Private bolImportadoOCABB As Boolean = False
    Private bolImportadoOCOut As Boolean = False

    Private olbeOcItemTem As New List(Of beOrdenCompra)
    Private olbeOcPedTem As New List(Of beOrdenCompra)
    Private olbeDetPedOc As New List(Of beOrdenCompra)


    Private strOC As String = ""
    Private NrItemOc As String = ""
    Private strTipoOc_TPOOCM As String = ""
    Private MatchOrdenDePedCompra As New Predicate(Of beOrdenCompra)(AddressOf BuscarOrdendePedCompra)

#End Region
#Region " Propiedades "
    Private _pCCLIENT_CodigoClinteYRC As Double = 0
    Private _strTerminal As String
    Public Property pTerminal() As String
        Get
            Return _strTerminal
        End Get
        Set(ByVal value As String)
            _strTerminal = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function pCargarOC(ByVal objOCPK As TD_OrdenCompraPK) As Boolean
        Dim objOC As TD_OrdenCompra = cOrdenCompra.Obtener(objSqlManager, objOCPK, strMensajeError)
        Dim blnExiste As Boolean = False
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If objOC.pNORCML_NroOrdenCompra <> "" Then
                With objOC
                    TD_OCPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
                    txtNroOrdenCompra.Text = .pNORCML_NroOrdenCompra
                    txtFechaOrdenCompra.Value = .pFORCML_FechaOCDte
                    'pFSOLIC_FechaSolicOCstr
                    If .pFSOLIC_FechaSolicOCstr <> "" Then
                        'If .pFSOLIC_FechaSolicOCInt > 0 Then
                        txtFechaSolicitud.Checked = True
                        txtFechaSolicitud.Value = .pFSOLIC_FechaSolicOCDte
                    Else
                        txtFechaSolicitud.Checked = False
                    End If
                    txtDescripcion.Text = .pTDSCML_Descripcion
                    'txtProveedor.pCodigo = .pCPRVCL_CodigoClienteTercero
                    txtProvText.Tag = .pCPRVCL_CodigoClienteTercero
                    txtProvText.Text = .pTPRVCL_Proveedor


                    txtAreaSolicitante.Text = .pTCMAEM_DescAreaEmpresa
                    cmbTermItern.pCargarPorCodigo = .pTTINTC_TerminoIntern
                    txtReferencia.Text = .pNREFCL_ReferenciaCliente
                    txtTerminoPago.Text = .pTPAGME_TerminoPago
                    txtRefDocumento.Text = .pREFDO1_ReferenciaDocumento
                    cmbPrioridad.pCargarPorCodigo = .pNTPDES_Prioridad
                    cmbMoneda.pCargarPorCodigo = .pCMNDA1_Moneda
                    txtEmpresaFacturar.Text = .pTEMPFAC_EmpresaFacturar
                    txtComprador.Text = .pTNOMCOM_NombreComprador
                    txtCentroCosto.Text = .pTCTCST_CentroCosto
                    txtRegionEmbarque.Text = .pCREGEMB_RegEmbarque
                    cmbMedioEmbarque.pCargarPorCodigo = .pCMEDTR_MedioTransporte
                    txtDestinoFinal.Text = .pTDEFIN_DestinoFinal
                    txtObservaciones.Text = .pTDAITM_Observaciones
                    txtCostoTotal.Text = .pIVCOTO_ImporteCostoTotal
                    txtTotalImpuesto.Text = .pIVTOIM_ImporteTotalImpuesto
                    txtTotalCompra.Text = .pIVTOCO_ImporteTotalCompra
                    txtTipoOC.Valor = .pTPOOCM_TipoOC
                    txtCondPago.Text = .pTCNDPG_CondicionPago
                    txtNombreContacto.Text = .pTRSCN_NombreContacto
                    txtTelefonoContacto.Text = .pTLFNO2_TelefonoContacto
                    txtEmailContacto.Text = .pTEMAI3_EmailContacto
                    txtTipoOC.Refresh()
                    'Me.txtTipoOC.Text = .pTPOOCM_TipoOC 'DESCOMENTAR
                End With
                blnExiste = True
            Else
                Call pClear()
                TD_OCPK.pNORCML_NroOrdenCompra = ""
            End If
        End If
        Return blnExiste
    End Function

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtNroOrdenCompra.Text.Trim = "" Then strMensajeError &= "Falta : Nro. de Orden de Compra..." & vbNewLine
        'If txtProveedor.pCodigo = 0 Then strMensajeError &= "Falta : Proveedor..." & vbNewLine
        If txtProvText.Tag = "0" Then strMensajeError &= "Falta : Proveedor..." & vbNewLine
        If txtDescripcion.Text.Trim = "" Then strMensajeError &= "Falta : Detalle de la Orden de Compra..." & vbNewLine
        If cmbTermItern.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Termino Internacional." & vbNewLine
        If cmbMoneda.pInformacionSelec.pCMNDA1_Codigo = "" Then strMensajeError &= "Falta : Moneda." & vbNewLine
        If cmbMedioEmbarque.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Medio de Transporte." & vbNewLine
        If cmbPrioridad.pInformacionSelec.pCCMPRN_Codigo = "" Then strMensajeError &= "Falta : Prioridad." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Sub pDisposeFormServF01(ByVal StatusProceso As Boolean)
        ' Habilitamos el Formulario a través del KrytonPanel
        KryptonPanel.Enabled = True
        RemoveHandler oMItemOC.pDisposeForm, AddressOf pDisposeFormServF01
        oMItemOC.Dispose()
        oMItemOC = Nothing
        Call pClear()
        txtNroOrdenCompra.Focus()
    End Sub

    Public Function BuscarOrdendePedCompra(ByVal pbeOrdenCompra As beOrdenCompra) As Boolean
        If ((pbeOrdenCompra.PSNORCML.Trim.Equals(strOC.Trim)) And (pbeOrdenCompra.PNNRITOC = NrItemOc)) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region
#Region " Eventos "
    Sub New(ByVal Cliente As Int64, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TD_OCPK.pCCLNT_CodigoCliente = Cliente
        strUsuario = Usuario
    End Sub

    Sub New(ByVal OrdenCompra As TD_OrdenCompraPK, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TD_OCPK.pCCLNT_CodigoCliente = OrdenCompra.pCCLNT_CodigoCliente
        TD_OCPK.pNORCML_NroOrdenCompra = OrdenCompra.pNORCML_NroOrdenCompra
        txtNroOrdenCompra.Enabled = False
        strUsuario = Usuario
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not fblnValidar() Then Exit Sub
        Dim objOCTemp As beOrdenCompra = New beOrdenCompra
        With objOCTemp
            .PNCCLNT = TD_OCPK.pCCLNT_CodigoCliente
            .PSNORCML = txtNroOrdenCompra.Text.Trim
            If txtTipoOC.Resultado IsNot Nothing Then
                .PSTPOOCM = CType(Me.txtTipoOC.Resultado, beGeneral).PSCCMPRN.Trim 'DESCOMENTAR
            End If
            .FechaOrdenDeCompra = txtFechaOrdenCompra.Value
            If txtFechaSolicitud.Checked Then .FechaSolicitud = txtFechaSolicitud.Value
            '.PNCPRVCL = txtProveedor.pCodigo
            .PNCPRVCL = txtProvText.Tag
            .PSTDSCML = txtDescripcion.Text.Trim
            .PSTCMAEM = txtAreaSolicitante.Text.Trim
            .PSTTINTC = cmbTermItern.pInformacionSelec.pCCMPRN_Codigo
            .PSNREFCL = txtReferencia.Text
            .PSTPAGME = txtTerminoPago.Text
            .PSREFDO1 = txtRefDocumento.Text
            .PNNTPDES = cmbPrioridad.pInformacionSelec.pCCMPRN_Codigo
            .PNCMNDA1 = cmbMoneda.pInformacionSelec.pCMNDA1_Codigo
            .PSTEMPFAC = txtEmpresaFacturar.Text.Trim
            .PSTNOMCOM = txtComprador.Text.Trim
            .PSTCTCST = txtCentroCosto.Text.Trim
            .PSCREGEMB = txtRegionEmbarque.Text.Trim
            .PNCMEDTR = cmbMedioEmbarque.pInformacionSelec.pCCMPRN_Codigo
            .PSTDEFIN = txtDestinoFinal.Text.Trim
            .PSTCNDPG = txtCondPago.Text.Trim

            Decimal.TryParse(txtCostoTotal.Text, .PNIVCOTO)
            Decimal.TryParse(txtTotalCompra.Text, .PNIVTOCO)
            Decimal.TryParse(txtTotalImpuesto.Text, .PNIVTOIM)
            .PSTPRSCN = txtNombreContacto.Text
            .PSTLFNO2 = txtTelefonoContacto.Text
            .PSTEMAI3 = txtEmailContacto.Text
            .PSTDAITM = txtObservaciones.Text.Trim
            .PSCUSCRT = strUsuario
            .PSCULUSA = strUsuario
            If Not strTipoOc_TPOOCM.Trim.Equals("") Then
                .PSTPOOCM = strTipoOc_TPOOCM
            End If

        End With
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        If obrOrdenDeCompra.InsertarOrdenDeCompra(objOCTemp) Then
            nNroRegGrabados += 1

            ''AGREGANDO LA OPCION PARA IMPORTACION ABB
            ''-----------------------------------------------------------------------
            If (bolImportadoOCABB = True And txtNroOrdenCompra.Text.Trim <> "") Then
                Dim ofrmListaOc As New frmListaOC()
                Dim odtImportados As New DataTable
                Dim oDs As New DataSet
                oDs = New brIntegracion().Integracion_Lista_Orden_Compra_Detalle(TD_OCPK.pCCLNT_CodigoCliente, txtNroOrdenCompra.Text, strUsuario)

                If oDs.Tables(0).TableName.Equals("Error_Table") Then
                    Throw New Exception(oDs.Tables(0).Rows(0).Item("Error").ToString)
                End If
                If Not (oDs Is Nothing) Then
                    odtImportados = oDs.Tables(0).Copy()
                    ofrmListaOc.pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
                    ofrmListaOc.pCCLIENT_CodigoClinteYRC = 0
                    ofrmListaOc.pbolImportadoOCABB = True
                    ofrmListaOc.pdtImportacionOCABB = odtImportados
                    ofrmListaOc.pNORCML_NroOrdenCompra = Me.txtNroOrdenCompra.Text
                    ofrmListaOc.ShowDialog()
                    Me.Close()
                    Exit Sub
                End If


            End If
            ''-----------------------------------------------------------------------

            If bolImportadoYRC And _pCCLIENT_CodigoClinteYRC <> 0 Then
                Dim ofrmListaOc As New frmListaOC()
                ofrmListaOc.pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
                ofrmListaOc.pCCLIENT_CodigoClinteYRC = _pCCLIENT_CodigoClinteYRC
                ofrmListaOc.pNORCML_NroOrdenCompra = Me.txtNroOrdenCompra.Text

                ofrmListaOc.ShowDialog()
                Me.Close()
                Exit Sub
            End If

            If bolImportadoOCOut Then
                Dim obrOrdeDeCopra As New brOrdenDeCompra
                If (olbeOcItemTem.Count > 0) Then
                    For Each obeDetOc As beOrdenCompra In olbeOcItemTem
                        obeDetOc.PSCUSCRT = strUsuario
                        obeDetOc.PSCULUSA = strUsuario
                        obeDetOc.PSNTRMNL = TD_OCPK.pNTRMNL_Terminal

                        If obrOrdeDeCopra.InsertarDetalleOrdenDeCompra(obeDetOc) = 0 Then
                            HelpClass.ErrorMsgBox()
                            Exit Sub
                        Else
                            'Busca si cuenta con detalle el item
                            strOC = obeDetOc.PSNORCML
                            NrItemOc = obeDetOc.PNNRITOC
                            olbeOcPedTem = olbeDetPedOc.FindAll(MatchOrdenDePedCompra)
                            If olbeOcPedTem.Count > 0 Then
                                For Each obeDetPedOc As beOrdenCompra In olbeOcPedTem
                                    obeDetPedOc.PSCUSCRT = strUsuario
                                    obeDetPedOc.PSCULUSA = strUsuario
                                    obeDetPedOc.PSNTRMCR = TD_OCPK.pNTRMNL_Terminal
                                    obeDetPedOc.PSNTRMNL = TD_OCPK.pNTRMNL_Terminal
                                    If obrOrdeDeCopra.InsertarDetalleOrdenDePedCompra(obeDetPedOc) = 0 Then
                                        HelpClass.ErrorMsgBox()
                                        Exit Sub
                                    Else
                                        Dim objImportarOC As New OrdenCompra_DAL
                                        Dim oParametro As New Hashtable
                                        oParametro.Add("CodCliente", objOCTemp.PNCCLNT)
                                        oParametro.Add("OC", obeDetOc.NrOCCliente)
                                        oParametro.Add("CodItem", obeDetOc.NrItemCliente)
                                        oParametro.Add("TipDoc", objOCTemp.PSTPOOCM)
                                        oParametro.Add("norden", obeDetPedOc.PSNRFRPD)
                                        oParametro.Add("Usuario", obeDetPedOc.PSCULUSA)

                                        If objImportarOC.fintActualizarEstado(oParametro) = -1 Then
                                            HelpClass.ErrorMsgBox()
                                            Exit Sub
                                        End If
                                    End If
                                Next
                            Else
                                Dim objImportarOC As New OrdenCompra_DAL
                                Dim oParametro As New Hashtable
                                oParametro.Add("CodCliente", objOCTemp.PNCCLNT)
                                oParametro.Add("OC", obeDetOc.NrOCCliente)
                                oParametro.Add("CodItem", obeDetOc.NrItemCliente)
                                oParametro.Add("TipDoc", objOCTemp.PSTPOOCM)
                                oParametro.Add("norden", "")
                                oParametro.Add("Usuario", obeDetOc.PSCULUSA)
                                If objImportarOC.fintActualizarEstado(oParametro) = -1 Then
                                    HelpClass.ErrorMsgBox()
                                    Exit Sub
                                End If
                            End If
                        End If
                    Next
                End If
                HelpClass.MsgBox("Registro Satisfactorio.")
                TD_OCPK.pNORCML_NroOrdenCompra = Me.txtNroOrdenCompra.Text
                Me.Close()
            End If

            ' Validamos si es un nuevo registro
            If TD_OCPK.pNORCML_NroOrdenCompra = "" Then
                TD_OCPK.pNORCML_NroOrdenCompra = txtNroOrdenCompra.Text.Trim
                ' Deshabilitamos el Formulario a través del KrytonPanel
                'KryptonPanel.Enabled = False
                ' Instanciamos la Primery Key de la Orden de Compra
                Dim oOrdenCompraPK As TD_OrdenCompraPK = New TD_OrdenCompraPK
                oOrdenCompraPK.pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
                oOrdenCompraPK.pNORCML_NroOrdenCompra = TD_OCPK.pNORCML_NroOrdenCompra
                ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
                oMItemOC = New ucItemOC_MItem(oOrdenCompraPK, strUsuario)
                AddHandler oMItemOC.pDisposeForm, AddressOf pDisposeFormServF01
                oMItemOC.pHabilitarNroItem = True
                'oMItemOC.Show()
                oMItemOC.ShowDialog()
            Else
                Me.Close()
            End If
        Else
            MessageBox.Show("Error comuniquese con el departamento de sistemas", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCostoTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoTotal.KeyDown
        Dim decTemp1, decTemp2 As Decimal
        Decimal.TryParse(txtCostoTotal.Text, decTemp1)
        Decimal.TryParse(txtTotalImpuesto.Text, decTemp2)
        txtTotalCompra.Text = (decTemp1 * decTemp2).ToString("0.00")
    End Sub

    Private Sub txtTotalImpuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalImpuesto.KeyDown
        Dim decTemp1, decTemp2 As Decimal
        Decimal.TryParse(txtCostoTotal.Text, decTemp1)
        Decimal.TryParse(txtTotalImpuesto.Text, decTemp2)
        txtTotalCompra.Text = (decTemp1 * decTemp2).ToString("0.00")
    End Sub

    Private Sub txtNroOrdenCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrdenCompra.TextChanged
        txtNroOrdenCompra.CausesValidation = True
    End Sub

    Private Sub txtNroOrdenCompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroOrdenCompra.Validating
        If txtNroOrdenCompra.Text <> "" Then
            Dim objTemp As TD_OrdenCompraPK = New TD_OrdenCompraPK
            objTemp.pCCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
            objTemp.pNORCML_NroOrdenCompra = txtNroOrdenCompra.Text.Trim
            If Not pCargarOC(objTemp) Then txtNroOrdenCompra.Text = objTemp.pNORCML_NroOrdenCompra
        End If
        txtNroOrdenCompra.CausesValidation = False
    End Sub

    Private Sub txtProveedor_ErrorMessage(ByVal MsgError As String) Handles txtProveedor.ErrorMessage
        MessageBox.Show(MsgError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ucOrdenCompra_MOC_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not objSqlManager Is Nothing Then objSqlManager.Dispose()
        objSqlManager = Nothing
    End Sub

    Private Sub ucOrdenCompra_MOC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim bStatusOperacion As Boolean = IIf(nNroRegGrabados > 0, True, False)
        RaiseEvent pDisposeForm(bStatusOperacion)
    End Sub

    Private Sub ucOrdenCompra_MOC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not KryptonPanel.Enabled Then
            MessageBox.Show("Esta ventana aún no puede ser cerrada." & vbNewLine & "Debe terminar el Registro de los ITEM(s).", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub ucOrdenCompra_MOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoOC.Obligatorio = False
            cmbMedioEmbarque.pCargarDatos("CMEDTR", "::Seleccione::")
            cmbPrioridad.pCargarDatos("NTPDES", "::Seleccione::")
            cmbTermItern.pCargarDatos("TERINT", "::Seleccione::")
            cmbMoneda.pCargarDatos()
            CargarControles()
            objSqlManager = New SqlManager
            If TD_OCPK.pNORCML_NroOrdenCompra <> "" Then pCargarOC(TD_OCPK)
            Dim obrGeneral As New brGeneral
            'Validamos que el clientes sea Outotec
            If obrGeneral.bolElClienteEsOutotec(TD_OCPK.pCCLNT_CodigoCliente) Then
                btnImportarOC.Visible = True
            Else
                btnImportarOC.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarControles()
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Origen"
        oListColum.Add(2, oColumnas)

        txtTipoOC.DataSource = obrGeneral.olTipoOrigen(TD_OCPK.pCCLNT_CodigoCliente)
        txtTipoOC.ListColumnas = oListColum
        txtTipoOC.Cargas()
        txtTipoOC.ValueMember = "PSCCMPRN"
        txtTipoOC.DispleyMember = "PSTDSDES"
        txtTipoOC.Refresh()
    End Sub


    Private Sub btnMigrarYRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMigrarYRC.Click
        If txtNroOrdenCompra.Text.Trim.Equals("") Then Exit Sub
        Dim oImportasOC As New ImportarOC.ImportarOcYRC
        Dim oDtOc As New DataTable 'TD_OCPK.pCCLNT_CodigoCliente
        oDtOc = oImportasOC.GetOC(_pCCLIENT_CodigoClinteYRC, txtNroOrdenCompra.Text)
        If oDtOc.Rows.Count > 0 Then
            With oDtOc.Rows.Item(0)
                Me.txtNroOrdenCompra.Text = .Item("SNROOC").ToString()

                'TD_OCPK.pNORCML_NroOrdenCompra = .pNORCML_NroOrdenCompra
                'txtNroOrdenCompra.Text = .pNORCML_NroOrdenCompra
                txtFechaOrdenCompra.Value = .Item("DEMIS").ToString()
                'If .pFSOLIC_FechaSolicOCInt > 0 Then
                '    txtFechaSolicitud.Checked = True
                '    txtFechaSolicitud.Value = .pFSOLIC_FechaSolicOCDte
                'Else
                '    txtFechaSolicitud.Checked = False
                'End If
                'txtDescripcion.Text = .pTDSCML_Descripcion
                'txtProveedor.pCodigo = .pCPRVCL_CodigoClienteTercero
                txtAreaSolicitante.Text = .Item("SARECOM").ToString()
                cmbTermItern.pCargarPorCodigo = .Item("CINCOTE").ToString()
                'txtReferencia.Text = .pNREFCL_ReferenciaCliente
                'txtTerminoPago.Text = .pTPAGME_TerminoPago
                'txtRefDocumento.Text = .pREFDO1_ReferenciaDocumento
                Select Case .Item("CURG").ToString()
                    Case 0
                        cmbPrioridad.pCargarPorCodigo = 1
                    Case 1
                        cmbPrioridad.pCargarPorCodigo = 3
                    Case 2
                        cmbPrioridad.pCargarPorCodigo = 4
                End Select
                cmbMoneda.pCargarPorAbreviatura = .Item("CMONEDA").ToString()
                'txtEmpresaFacturar.Text = .pTEMPFAC_EmpresaFacturar
                'txtComprador.Text = .pTNOMCOM_NombreComprador
                'txtCentroCosto.Text = .pTCTCST_CentroCosto
                'txtRegionEmbarque.Text = .pCREGEMB_RegEmbarque
                'cmbMedioEmbarque.pCargarPorCodigo = .pCMEDTR_MedioTransporte
                'txtDestinoFinal.Text = .pTDEFIN_DestinoFinal
                'txtObservaciones.Text = .pTDAITM_Observaciones
                'txtCostoTotal.Text = .pIVCOTO_ImporteCostoTotal
                'txtTotalImpuesto.Text = .pIVTOIM_ImporteTotalImpuesto
                'txtTotalCompra.Text = .pIVTOCO_ImporteTotalCompra  
                bolImportadoYRC = True
            End With
        End If
    End Sub

#End Region
#Region " Métodos "
    Public Sub pClear()
        txtNroOrdenCompra.Text = ""
        txtFechaOrdenCompra.Checked = False
        txtFechaSolicitud.Checked = False
        txtDescripcion.Text = ""
        txtProveedor.pClear()
        txtAreaSolicitante.Text = ""
        cmbTermItern.pClear()
        cmbMoneda.pClear()
        txtEmpresaFacturar.Clear()
        txtComprador.Clear()
        txtCentroCosto.Clear()
        txtRegionEmbarque.Clear()
        cmbMedioEmbarque.pClear()
        txtDestinoFinal.Clear()
        txtObservaciones.Clear()
        txtCostoTotal.Clear()
        txtTotalImpuesto.Clear()
        txtTotalCompra.Clear()
        bolImportadoOCABB = False
    End Sub
#End Region
    Private Function EsNumerico(ByVal lstr_Cadena As String) As Boolean
        Dim EsNumero As Boolean = True
        For lint_Contador As Integer = 0 To lstr_Cadena.Trim.Length - 1
            If Not Char.IsNumber(lstr_Cadena.Substring(lint_Contador, 1).Trim) Then
                EsNumero = False
                Exit For
            End If
        Next
        Return EsNumero
    End Function

    'Private Sub btnImportarOCABB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarOCABB.Click
    '    If txtNroOrdenCompra.Text.Trim.Equals("") Then Exit Sub
    '    Try
    '        Dim obeOrdenCompra As New beOrdenCompra()
    '        Dim oblProveedor As New blProveedor()
    '        Dim obeProveedor As New beProveedor()
    '        Dim lstr_Cadena As String = ""
    '        Dim EsNumero As Boolean = True
    '        obeOrdenCompra = New brIntegracion().Integracion_Lista_Orden_Compra_Cabecera(txtNroOrdenCompra.Text.Trim, strUsuario)

    '        ''------------------insercion del provvedor de ABB -> en caso no se encontrara(rzol05)----------------
    '        obeProveedor.CPRVCL_CodClienteTercero = 0
    '        'If (EsNumerico(obeOrdenCompra.pNRUCPR_RucProveedor) = True) Then
    '        '    obeProveedor.NRUCPR_RucProveedor = obeOrdenCompra.pNRUCPR_RucProveedor
    '        'Else
    '        '    obeProveedor.NRUCPR_RucProveedor = 0
    '        'End If
    '        If IsNumeric(obeOrdenCompra.pNRUCPR_RucProveedor) Then
    '            obeProveedor.NRUCPR_RucProveedor = obeOrdenCompra.pNRUCPR_RucProveedor
    '        Else
    '            obeProveedor.NRUCPR_RucProveedor = 0
    '        End If
    '        If obeOrdenCompra.pTPDRPRC_DireccionProveedor.Trim.Length > 35 Then
    '            Dim intDir As Integer = obeOrdenCompra.pTPDRPRC_DireccionProveedor.ToString.Trim.Length
    '            obeProveedor.PSTDRPRC = obeOrdenCompra.pTPDRPRC_DireccionProveedor.ToString.Trim.Substring(0, 35)
    '            obeProveedor.PSTPRSCN = obeOrdenCompra.pTPDRPRC_DireccionProveedor.ToString.Trim.Substring(35, intDir - 35)
    '        Else
    '            obeProveedor.PSTDRPRC = obeOrdenCompra.pTPDRPRC_DireccionProveedor.ToString.Trim
    '            obeProveedor.PSTPRSCN = ""
    '        End If

    '        If obeOrdenCompra.pTPRVCL_DescripcionProveedor.ToString.Trim.Length > 30 Then
    '            Dim intDir As Integer = obeOrdenCompra.pTPRVCL_DescripcionProveedor.Trim.Length
    '            obeProveedor.PSTPRVCL = obeOrdenCompra.pTPRVCL_DescripcionProveedor.Trim.Substring(0, 30)
    '            obeProveedor.PSTPRCL1 = obeOrdenCompra.pTPRVCL_DescripcionProveedor.Trim.Substring(30, intDir - 30)
    '        Else
    '            obeProveedor.PSTPRVCL = obeOrdenCompra.pTPRVCL_DescripcionProveedor.Trim
    '            obeProveedor.PSTPRCL1 = ""
    '        End If
    '        Dim lon As Int32 = obeProveedor.TPRVCL_DesClieTercero.Length
    '        obeProveedor.TNROFX_NroFax = obeOrdenCompra.pTNROFX_FaxProveedor
    '        obeProveedor.TPRSCN_PersonaContacto = obeOrdenCompra.pTPRSCN_ContactoProveedor
    '        obeProveedor.TLFN02_FonoContacto = obeOrdenCompra.pTLFN02_TelefonoContacto
    '        obeProveedor.TMAI03_EmailContacto = obeOrdenCompra.pTEAMI3_EmailContacto
    '        obeProveedor.CULUSA_UsuarioAct = strUsuario
    '        obeProveedor.CUSCRT_UsuarioCre = strUsuario
    '        obeProveedor.CCLNT_CodigoCliente = TD_OCPK.pCCLNT_CodigoCliente
    '        obeProveedor.CPRPCL_CodigoClienteProveedor = obeOrdenCompra.PCPRPCL_CodigoClienteProveedor
    '        obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor = "P"
    '        obeProveedor = oblProveedor.fblnRegistrar_Proveedor_de_ABB(obeProveedor)

    '        ''------------------------------------------------------------------
    '        cmbTermItern.pCargarPorCodigo = obeOrdenCompra.pTTINTC_TerminoIntern
    '        Me.txtDescripcion.Text = obeOrdenCompra.pTDSCML_Descripcion
    '        Me.txtComprador.Text = obeOrdenCompra.pTNOMCOM_Nombre_Del_Comprador
    '        Me.cmbMoneda.pCargarPorAbreviatura = obeOrdenCompra.pNMONOC_MonedaDeOC

    '        'Me.txtNroOrdenCompra.Text = obeOrdenCompra.pNORCML_NroOrdenCompra
    '        Me.txtDescripcion.Text = obeOrdenCompra.pTDSCML_Descripcion
    '        If (obeOrdenCompra.pEXISTE_FechaOCDte = True) Then
    '            Me.txtFechaOrdenCompra.Value = obeOrdenCompra.pFORCML_FechaOCDte
    '        Else
    '            Me.txtFechaOrdenCompra.Value = Date.Now
    '        End If
    '        txtCentroCosto.Text = obeOrdenCompra.pTCTCST_CentroCosto

    '        Select Case obeOrdenCompra.pNTPDES_Prioridad
    '            Case 0
    '                cmbPrioridad.pCargarPorCodigo = 1
    '            Case 1
    '                cmbPrioridad.pCargarPorCodigo = 3
    '            Case 2
    '                cmbPrioridad.pCargarPorCodigo = 4
    '        End Select

    '        If (obeProveedor.CPRVCL_CodClienteTercero <> 0) Then
    '            txtProveedor.pCodigo = obeProveedor.CPRVCL_CodClienteTercero
    '        End If

    '        If cmbTermItern.pInformacionSelec.pCCMPRN_Codigo.Trim.Equals("") Then
    '            MessageBox.Show("No se importó el Incoterm desde el sistema de ABB")
    '        End If
    '        bolImportadoOCABB = True
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnImportarOCABB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarOC.Click
        If txtNroOrdenCompra.Text.Trim.Equals("") Then Exit Sub
        Try
            Dim obrGeneral As New brGeneral
            'Validamos que el clientes sea Outotec
            If obrGeneral.bolElClienteEsOutotec(TD_OCPK.pCCLNT_CodigoCliente) Then
                Dim obrInterfazOC As New brInterfazOC
                Dim obeOc As New beOrdenCompra
                obrInterfazOC.CargaArchivoPorOC(TD_OCPK.pCCLNT_CodigoCliente, Me.txtNroOrdenCompra.Text)
                obeOc = obrInterfazOC.ListaOC.Item(0)
                cmbTermItern.pCargarPorCodigo = obeOc.PSTTINTC
                Me.txtDescripcion.Text = obeOc.PSTDSCML
                Me.txtComprador.Text = obeOc.PSTNOMCOM
                Me.cmbMoneda.pCargarPorAbreviatura = obeOc.PSNMONOC
                Me.txtNroOrdenCompra.Text = obeOc.PSNORCML
                Me.txtFechaOrdenCompra.Value = obeOc.PSFORCML_INI
                txtCentroCosto.Text = obeOc.PSTCTCST
                Select Case obeOc.PNNTPDES
                    Case 0
                        cmbPrioridad.pCargarPorCodigo = 1
                    Case 1
                        cmbPrioridad.pCargarPorCodigo = 3
                    Case 2
                        cmbPrioridad.pCargarPorCodigo = 4
                End Select
                txtProveedor.pCodigo = obeOc.PNCPRVCL
                txtTipoOC.Valor = obeOc.PSTPOOCM
                bolImportadoOCOut = True
                strTipoOc_TPOOCM = obeOc.PSTPOOCM
                olbeOcItemTem = obrInterfazOC.DetalleOC
                olbeDetPedOc = obrInterfazOC.DetalleOCPed

            End If
        Catch ex As Exception
            bolImportadoOCOut = False
        End Try
    End Sub

    Private Sub txtProveedor_InformationChanged() Handles txtProveedor.InformationChanged
        Try
            txtProvText.Tag = txtProveedor.pCodigo
            txtProvText.Text = "Id:" & txtProveedor.pCodigo & " RUC:" & txtProveedor.pNroRuc & " " & txtProveedor.pRazonSocial

            txtProveedor.pClear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub
End Class
