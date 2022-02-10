Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmSolicInforRecOCAlmacen

    Public Sub New(Optional ByVal RecepcionInterfazSap As Boolean = False) 'Nuevo ......
        InitializeComponent()
        mostrarGrillaInterfazSAp(RecepcionInterfazSap)
    End Sub

#Region " Tipo de Datos "

#End Region

#Region " Atributos "
    Private objMovimientoMercaderia As clsMovimientoMercaderia = Nothing
    Private intCliente_CCLNT As Int64 = 0
    Private strRazonSocialCliente As String = ""
    Private strCodProvCliente As String = ""
    Private strTipoRelacion As String = ""
    Private blnResultado As Boolean = False
    Private strNroPlacaCamion As String = ""
    Private intAnio As String = ""
    Private strMarca As String = ""
    Private strNombreChofer As String = ""
    Private strBreveteChofer As String = ""
    Private intDocIdentidadChofer As String = ""
    Private intCodEmpresaTransporte As String = ""
    Private intRazonSocialTransporte As String = ""
    Private intNroRUCEmpresaTransporte As String = ""
    Private bolEsClienteOutotec As Boolean = False
    Private strRucProveedor As String = ""
    Private RecepcionInterfazSap As Boolean = False
#End Region

#Region " Propiedades "


    Private _PNNORSCI As Decimal
    Public Property pdecEmbarque() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property pstrNroOrdenCompra() As String
        Get
            Return txtNroOrdenCompra.Text
        End Get
        Set(ByVal value As String)
            txtNroOrdenCompra.Text = value
        End Set
    End Property

    Public Property pstrNroGuiaCliente() As String
        Get
            Return txtNroGuiaCliente.Text
        End Get
        Set(ByVal value As String)
            txtNroGuiaCliente.Text = value
        End Set
    End Property

    Public ReadOnly Property pstrNroRUCCliente() As String
        Get
            If Not UcClienteTerceroOrigen.ItemActual Is Nothing Then
                Return CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNNRUCPR
            Else
                Return 0
            End If

        End Get
        'Set(ByVal value As String)
        '    txtNroRUCCliente.Text = value
        '    strRucProveedor = value
        'End Set
    End Property

    Public Property pstrTipoAlmacen() As String
        Get
            Return "" & txtTipoAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Tag = value
        End Set
    End Property

    Public ReadOnly Property pstrTipoOrigen_TIPORG() As String
        Get
            Return CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN
        End Get
    End Property


    Public ReadOnly Property pstrTipoDocumentoOrigen_TIPORI() As String
        Get
            Return CType(Me.txtTipoDoc.Resultado, beGeneral).PSCCMPRN
        End Get
    End Property

    Public Property pstrDetalleTipoAlmacen() As String
        Get
            Return txtTipoAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Text = value
        End Set
    End Property

    Public Property pstrAlmacen() As String
        Get
            Return "" & txtAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtAlmacen.Tag = value
        End Set
    End Property

    Public Property pstrDetalleAlmacen() As String
        Get
            Return "" & txtAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtAlmacen.Text = value
        End Set
    End Property

    Public Property pstrZonaAlmacen() As String
        Get
            Return "" & txtZonaAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Tag = value
        End Set
    End Property

    Public Property pstrDetalleZonaAlmacen() As String
        Get
            Return "" & txtZonaAlmacen.Text
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Text = value
        End Set
    End Property


    Public Property pstrTipoRecepcion() As String
        Get
            Return CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING
        End Get
        Set(ByVal value As String)
            txtTipoMovimientoIng.Valor = value
            txtTipoMovimientoIng.Refresh()
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return CType(txtTipoMovimientoIng.Resultado, beGeneral).PSTTPING
        End Get
        Set(ByVal value As String)
            txtTipoMovimientoIng.Valor = value
            txtTipoMovimientoIng.Refresh()
        End Set
    End Property

    Public Property pblnDesglose() As Boolean
        Get
            Return chkDesglose.Checked
        End Get
        Set(ByVal value As Boolean)
            chkDesglose.Checked = value
        End Set
    End Property

    ''' <summary>
    ''' Control de embalaje según O/C
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property pstrEmbalajaOC() As String
        Get
            Return IIf(chkSi.Checked, "S", "N")
        End Get
    End Property

    Public Property pstrContenedor() As String
        Get
            Return txtContenedor.Text
        End Get
        Set(ByVal value As String)
            txtContenedor.Text = value
        End Set
    End Property

    Public WriteOnly Property pintCliente() As Int64
        Set(ByVal value As Int64)
            intCliente_CCLNT = value
        End Set
    End Property

    Public WriteOnly Property pstrRazonSocialCliente() As String
        Set(ByVal value As String)
            strRazonSocialCliente = value
        End Set
    End Property
    Public Property pstrCodProvCliente() As String
        Set(ByVal value As String)
            strCodProvCliente = value
        End Set
        Get
            If Not UcClienteTerceroOrigen.ItemActual Is Nothing Then
                Return CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNCPRVCL
            Else
                Return 0
            End If

        End Get
    End Property

    Public WriteOnly Property pstrTipoRelacion() As String
        Set(ByVal value As String)
            strTipoRelacion = value
        End Set
    End Property


    Public ReadOnly Property pobjInformacionIngresada() As clsMovimientoMercaderia
        Get
            Return objMovimientoMercaderia
        End Get
    End Property
    Private strTerminoInternacional As String
    Public WriteOnly Property pstrTerminoInternacional() As String
        Set(ByVal value As String)
            strTerminoInternacional = value
        End Set
    End Property

    Private strCodProveedor As String = "0"
    Public WriteOnly Property pstrCodProveedor() As String
        Set(ByVal value As String)
            strCodProveedor = value
        End Set
    End Property


    Private _EsDevolucion As Boolean = False
    Public Property EsDevolucion() As Boolean
        Get
            Return _EsDevolucion
        End Get
        Set(ByVal value As Boolean)
            _EsDevolucion = value
        End Set
    End Property



    Public ReadOnly Property pstrObservaciones_TOBSER() As String
        Get
            Return txtTobs.Text
        End Get
    End Property


    Private _ListaOrdenCompraInterfazSap As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
    Public Property ListaOrdenCompraInterfazSap() As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill)
        Get
            Return _ListaOrdenCompraInterfazSap
        End Get
        Set(ByVal value As List(Of OrdenCompra.ItemOC.TD_ItemOCForWayBill))
            _ListaOrdenCompraInterfazSap = value
        End Set
    End Property


#End Region

#Region " Funciones y Procedimientos "

    Private Sub mostrarGrillaInterfazSAp(ByVal estado As Boolean)
        RecepcionInterfazSap = estado
        If RecepcionInterfazSap = False Then
            'Me.Size = New Size(507, 420) '545) 
        Else
            dgvOCRecepcion.Visible = True
        End If
    End Sub


    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""
        Dim obrGeneral As New Ransa.NEGO.brGeneral

        blnResultado = True
        If txtNroGuiaCliente.Text.Trim = "" Or txtNroGuiaCliente.Text.Trim = "0" Then strResultado &= "- Debe ingresar Nro." & vbNewLine
        If txtTipoAlmacen.Text = "" Then strResultado &= "- Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Text = "" Then strResultado &= "- Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Text = "" Then strResultado &= "- Debe seleccionar una Zona de Almacén." & vbNewLine
        If txtTipoMovimientoIng.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Recepción." & vbNewLine

        'Validamos si es devolucion
        If Not txtTipoMovimientoIng.Resultado Is Nothing AndAlso _EsDevolucion Then
            If bolEsClienteOutotec Then
                If Not obrGeneral.fbolTipoIngEsDevolucion(CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING) Then
                    strResultado &= "- El tipo de Rec. debe de ser devolución." & vbNewLine
                End If
            Else
                If CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING <> "D" Then
                    strResultado &= "- El tipo de Rec. debe de ser devolución." & vbNewLine
                End If
            End If


        End If

        If Not txtTipoMovimientoIng.Resultado Is Nothing Then
            If CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING = "T" And Not bolEsClienteOutotec Then
                strResultado &= "- El tipo de Rec. : T-> Transferencia no se puede realizar por esta opción." & vbNewLine
            End If
        End If


        If txtOrigen.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Origen." & vbNewLine
        If txtTipoDoc.Resultado Is Nothing Then strResultado &= "- Debe seleccionar el Tipo de Doc. de origen." & vbNewLine
        If txtEmpresaTransporte.Text = "" Then strResultado &= "- Debe seleccionar Empresa de Transporte. " & vbNewLine
        'Validamos que el clientes sea Outotec
        If txtZonaAlmacen.Text <> "" AndAlso bolEsClienteOutotec AndAlso Not txtTipoDoc.Resultado Is Nothing AndAlso Not txtOrigen.Resultado Is Nothing Then
            If UcClienteTerceroOrigen.ItemActual.PNCPRVCL = 0 OrElse UcClienteTerceroOrigen.ItemActual.PSCPRPCL = Nothing Then _
                        strResultado &= "- Debe de seleccionar el Ruc" & vbNewLine

            If UcClienteTerceroOrigen.ItemActual.PNCPRVCL <> 0 Then
                If CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL.ToString.Trim = "" Then
                    strResultado &= "- El Ruc no cuenta con su equivalencia en la interfaz" & vbNewLine
                End If
            End If

            'If CType(txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim = "P" AndAlso UcClienteTerceroOrigen.ItemActual.PSCPRPCL <> Nothing Then
            '    Dim obrInterfaz As New brInterfazOutoTec
            '    Dim obeInterfaz As New beCabInfzOutotec
            '    With obeInterfaz
            '        .cprove = CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL.Trim
            '        .calmac = obrGeneral.fstrAlmacenVituralOutotec(intCliente_CCLNT, txtZonaAlmacen.Text.Trim.Substring(0, 2))
            '    End With
            '    If Not obrInterfaz.fintProveedorPerteneceAlmacen(obeInterfaz) Then
            '        strResultado &= "- La Zona de Almacén no pertenece al proveedor. " & vbNewLine
            '    End If
            'End If

        End If

        'If strTerminoInternacional <> "LOC" AndAlso (Me.txtEmbarque.Text = "" OrElse Me.txtEmbarque.Text = 0) Then strResultado &= "Debe Ingresar Embarque " & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function


    Private Sub CargarControles()

        Dim obrGeneral As New Ransa.NEGO.brGeneral
        bolEsClienteOutotec = obrGeneral.bolElClienteEsOutotec(intCliente_CCLNT)

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "STPING"
        oColumnas.DataPropertyName = "PSSTPING"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TTPING"
        oColumnas.DataPropertyName = "PSTTPING"
        oColumnas.HeaderText = "Tipo Movimiento"
        oListColum.Add(2, oColumnas)

        txtTipoMovimientoIng.DataSource = obrGeneral.floListaTipoMovimientoRecepcionCliente(intCliente_CCLNT)
        txtTipoMovimientoIng.ListColumnas = oListColum
        txtTipoMovimientoIng.Cargas()
        txtTipoMovimientoIng.ValueMember = "PSSTPING"
        txtTipoMovimientoIng.DispleyMember = "PSTTPING"


        ''==========tipo Origen
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

        txtOrigen.DataSource = obrGeneral.olTipoOrigen(intCliente_CCLNT)
        txtOrigen.ListColumnas = oListColum
        txtOrigen.Cargas()
        txtOrigen.ValueMember = "PSCCMPRN"
        txtOrigen.DispleyMember = "PSTDSDES"

        If Not bolEsClienteOutotec Then
            txtOrigen.Valor = "P"
            txtOrigen.Refresh()
            txtOrigen.Enabled = False
            'UcClienteTerceroOrigen.Enabled = False
            txtTipoDoc.Enabled = False
        Else
            txtOrigen.Valor = IIf(strTipoRelacion.Trim.Equals(""), "P", strTipoRelacion)
            txtOrigen.Refresh()
        End If

        ''Tipo Documento origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Documento de Origen"
        oListColum.Add(2, oColumnas)

        txtTipoDoc.DataSource = obrGeneral.olTipoDocumentoOrigen(intCliente_CCLNT)
        txtTipoDoc.ListColumnas = oListColum
        txtTipoDoc.Cargas()
        txtTipoDoc.ValueMember = "PSCCMPRN"
        txtTipoDoc.DispleyMember = "PSTDSDES"

        dgvOCRecepcion.Rows.Clear()
        If RecepcionInterfazSap Then  'JM
            If ListaOrdenCompraInterfazSap.Count > 0 Then
                Dim row() As Object
                For Each item As OrdenCompra.ItemOC.TD_ItemOCForWayBill In ListaOrdenCompraInterfazSap
                    row = New Object() {item.pNRITOC_NroItemOC, item.pTMRCD2_MercaDescripcion, item.pQCNREC_QtaRecibida, item.pCUNCN5_UnidadCantidad}
                    dgvOCRecepcion.Rows.Add(row)
                Next
            End If

            'txtTipoDoc.Valor = "PE"
        Else
            'txtTipoDoc.Valor = "GR"

        End If
        txtTipoDoc.Valor = "GR"
        txtTipoDoc.Refresh()

        UcClienteTerceroOrigen.MostrarRuc = True
        UcClienteTerceroOrigen.CodCliente = intCliente_CCLNT
        UcClienteTerceroOrigen.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
        Dim obePlantaDeEntrega As New PlantaDeEntrega.bePlantaDeEntrega
        With obePlantaDeEntrega
            .PNCCLNT = intCliente_CCLNT
            .PNCPRVCL = strCodProveedor
            .PSSTPORL = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
        End With
        UcClienteTerceroOrigen.pCargar(obePlantaDeEntrega)
    End Sub

#End Region

    Private Function fblnValidarInCodigoEmbarque() As String
        Dim strResultado As String = ""
        If (strTerminoInternacional <> "LOC" And bolEsClienteOutotec = False) Then
            If (Me.txtEmbarque.Text = "" OrElse Me.txtEmbarque.Text = 0) Then
                strResultado = "Este ingreso no tiene asignado el número de Embarque." & vbNewLine
                strResultado &= "¿Desea continuar de todas maneras ?"
            End If
        End If
        Return strResultado
    End Function
#Region " Eventos "

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionItem.Click
        Try

            Dim strValidarCodEmb As String = ""
            If Not fblnValidarInfItemRecepcion() Then Exit Sub
            strValidarCodEmb = fblnValidarInCodigoEmbarque()
            If (strValidarCodEmb <> "") Then
                If (MessageBox.Show(strValidarCodEmb, "Verificación Embarque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    Me.pProcesarRegistroInfCabecera()
                    GuardarControlesUsados()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                Me.pProcesarRegistroInfCabecera()
                GuardarControlesUsados()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
            Case Keys.Delete
                txtAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
        txtAlmacen.Tag = ""
        ' Si modificamos el Almacén - debe limpiarse la Zona
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    If e IsNot Nothing Then
                        e.Cancel = True
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAlmacen.TextChanged
        txtTipoAlmacen.Tag = ""
        ' Si modificamos el Tipo de Almacén - debe limpiarse el Almacén y la Zona
        txtAlmacen.Text = ""
        txtZonaAlmacen.Text = ""
    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    If e IsNot Nothing Then
                        e.Cancel = True
                    End If

                End If
            End If
        End If
    End Sub


    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
            Case Keys.Delete
                txtZonaAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtZonaAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZonaAlmacen.TextChanged
        txtZonaAlmacen.Tag = ""
    End Sub

    Private Sub txtZonaAlmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZonaAlmacen.Validating
        If txtZonaAlmacen.Text = "" Then
            txtZonaAlmacen.Tag = ""
        Else
            If txtZonaAlmacen.Text <> "" And "" & txtZonaAlmacen.Tag = "" Then
                Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    If e IsNot Nothing Then
                        e.Cancel = True
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub bsaUnidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadListar.Click
        If Me.txtEmpresaTransporte.Text = "" Then Exit Sub
        Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "", "", intAnio, strMarca, "")
        txtUnidad.Tag = txtUnidad.Text
    End Sub

    Private Sub bsaBreveteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBreveteListar.Click
        Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtBrevete.Text, strNombreChofer, intDocIdentidadChofer)
        txtBrevete.Tag = txtBrevete.Text
    End Sub

    Private Sub bsaEmpresaTransporteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEmpresaTransporteListar.Click
        Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, intNroRUCEmpresaTransporte)
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                If Me.txtEmpresaTransporte.Text = "" Then Exit Sub
                Call mfblnBuscar_PlacaUnidad("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "", "", intAnio, strMarca, "")
                txtUnidad.Tag = txtUnidad.Text
            Case Keys.Delete
                txtUnidad.Text = ""
        End Select
    End Sub

    Private Sub txtUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidad.TextChanged
        txtUnidad.Tag = ""
    End Sub

    Private Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidad.Validating
        If txtUnidad.Text = "" Or txtEmpresaTransporte.Text = "" Then
            ' Limpio los controles
            txtUnidad.Tag = ""
            intAnio = ""
            strMarca = ""
        Else
            If mfblnExiste_PlacaCamion("" & txtEmpresaTransporte.Tag, txtUnidad.Text, "") Then
                If txtUnidad.Text <> "" And "" & txtUnidad.Tag = "" Then
                    Call mfblnObtenerDetalle_SDSPlacaCamion("" & txtEmpresaTransporte.Tag, txtUnidad.Text, intAnio, strMarca)
                    txtUnidad.Tag = txtUnidad.Text
                End If
            Else
                If strMarca = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                txtUnidad.Tag = ""
                txtUnidad.Text = ""
            End If
        End If
    End Sub

    Private Sub txtBrevete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrevete.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                If Me.txtEmpresaTransporte.Text = "" Then Exit Sub
                Call mfblnBuscar_Brevete("" & txtEmpresaTransporte.Tag, txtBrevete.Text, strNombreChofer, intDocIdentidadChofer)
                txtBrevete.Tag = txtBrevete.Text
            Case Keys.Delete
                txtBrevete.Text = ""
        End Select
    End Sub

    Private Sub txtBrevete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrevete.TextChanged
        txtBrevete.Tag = ""
    End Sub

    Private Sub txtBrevete_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBrevete.Validating
        If txtBrevete.Text = "" Then
            txtBrevete.Tag = ""
            strNombreChofer = ""
            intDocIdentidadChofer = 0
        Else
            If mfblnExiste_Chofer("" & txtEmpresaTransporte.Tag, txtBrevete.Text, "") Then
                If txtBrevete.Text <> "" And "" & txtBrevete.Tag = "" Then
                    Call mfblnObtenerDetalle_SDSChofer("" & txtEmpresaTransporte.Tag, txtBrevete.Text, strNombreChofer, intDocIdentidadChofer)
                    txtBrevete.Tag = txtBrevete.Text
                End If
            Else
                If strNombreChofer = "" Then mpMsjeVarios(enumMsjVarios.NOEXIST_Registrar)
                txtBrevete.Tag = ""
                txtBrevete.Text = ""
            End If
        End If
    End Sub

    Private Sub txtEmpresaTransporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpresaTransporte.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, intNroRUCEmpresaTransporte)
            Case Keys.Delete
                txtEmpresaTransporte.Text = ""
        End Select
    End Sub

    Private Sub txtEmpresaTransporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresaTransporte.TextChanged
        txtEmpresaTransporte.Tag = ""
    End Sub

    'Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
    '  If txtEmpresaTransporte.Text = "" Then
    '    txtEmpresaTransporte.Tag = ""
    '    strNroRUCEmpresaTransporte = ""
    '  Else
    '    If txtEmpresaTransporte.Text <> "" And "" & txtEmpresaTransporte.Tag = "" Then
    '      Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, strNroRUCEmpresaTransporte)
    '      If txtEmpresaTransporte.Text = "" Then
    '        e.Cancel = True
    '      End If
    '    End If
    '  End If
    'End Sub
    Private Sub txtMantCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMantCamiones.Click
        If Me.txtEmpresaTransporte.Tag = String.Empty Or Me.txtEmpresaTransporte.Tag = "0" Then Return
        Dim ofrmCamion As New frmCamion
        ofrmCamion.CTRSP = Convert.ToInt32(Me.txtEmpresaTransporte.Tag)
        If ofrmCamion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtUnidad.Text = ofrmCamion.Placa
            Me.txtUnidad.Tag = ofrmCamion.Placa
            Me.txtUnidad_Validating(Nothing, Nothing)

        End If
    End Sub

    Private Sub txtManChoferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManChoferes.Click
        If Me.txtEmpresaTransporte.Tag = "0" Or Me.txtEmpresaTransporte.Tag = String.Empty Then Return
        Dim ofrmChofer As New frmChofer
        ofrmChofer.CTRSP = Convert.ToInt32(Me.txtEmpresaTransporte.Tag)
        If ofrmChofer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtBrevete.Text = ofrmChofer.Brevete
            txtBrevete.Tag = ofrmChofer.Brevete
            txtBrevete_Validating(Nothing, Nothing)
        End If

    End Sub

    Private Sub frmSolicInforRecOCAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            CargarControles()
            CargarCodigoUsado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
#End Region
#Region " Métodos "
    Private Sub pProcesarRegistroInfCabecera()
        objMovimientoMercaderia = New clsMovimientoMercaderia
        With objMovimientoMercaderia
            ' Cliente
            .pintCodigoCliente_CCLNT = intCliente_CCLNT
            .pstrRazonSocialCliente_TCMPCL = strRazonSocialCliente
            ' Servicio
            .pintServicio_CSRVC = 1
            ' Empresa de Transporte
            Int32.TryParse("" & txtEmpresaTransporte.Tag, .pintEmpresaTransporte_CTRSP)
            .pstrRazonSocialEmpTransporte_TCMPTR = txtEmpresaTransporte.Text
            Int64.TryParse(IIf(intNroRUCEmpresaTransporte.Trim.Equals(""), 0, intNroRUCEmpresaTransporte), .pintNroRUCEmpTransporte_NRUCT)
            ' Unidad
            .pstrNroPlacaCamion_NPLCCM = txtUnidad.Text
            .pstrMarcaUnidad_TMRCCM = strMarca
            Int16.TryParse(IIf(intAnio.Trim.Equals(""), 0, intAnio), .pintAnioUnidad_NANOCM)
            ' Brevete
            .pstrNroBrevete_NBRVCH = txtBrevete.Text
            .pstrChofer_TNMBCH = strNombreChofer
            Int32.TryParse(IIf(intDocIdentidadChofer.Trim.Equals(""), 0, intDocIdentidadChofer), .pintNroDocIdentidadChofer_NLELCH)
            ' Observacion
            .pstrObservaciones_TOBSER = ""
            ' Compañía y División
            .pstrCompania_CCMPN = GLOBAL_COMPANIA
            .pstrDivision_CDVSN = GLOBAL_DIVISION
            .pstrTipoOrigen_TIPORG = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN
            .pstrTipoDocumentoOrigen_TIPORI = CType(Me.txtTipoDoc.Resultado, beGeneral).PSCCMPRN
            .pstrObservaciones_TOBSRV = Me.txtObservaciones.Text.Trim
            If Not UcClienteTerceroOrigen.ItemActual Is Nothing Then
                .pstrCodigoProveedor_CPRVCL = CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PNCPRVCL
                .pstrCodigoProveedor_cliente_CPRPCL = ("" & CType(UcClienteTerceroOrigen.ItemActual, PlantaDeEntrega.bePlantaDeEntrega).PSCPRPCL & "").Trim
            Else
                .pstrCodigoProveedor_CPRVCL = "0"
                .pstrCodigoProveedor_cliente_CPRPCL = "0"
            End If
            .pstrObservaciones_TOBSER = Me.txtTobs.Text
            .pstrFechaRealizacion_FRLZSR = dteFechaRecepcion.Value.Date
        End With
    End Sub



    Private Sub CargarCodigoUsado()
        ' Recuperamos los ultimos valores seleccionados
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim codTransportista As Int64 = 0
        Me.txtTipoMovimientoIng.Valor = objAppConfig.GetValue("Recepcion_TipoRecepcion", GetType(System.String))
        txtTipoMovimientoIng.Refresh()

        txtTipoAlmacen.Tag = objAppConfig.GetValue("Recepcion_TipoAlmacen", GetType(System.String))
        txtTipoAlmacen.Text = txtTipoAlmacen.Tag
        txtAlmacen.Tag = objAppConfig.GetValue("Recepcion_Almacen", GetType(System.String))
        txtAlmacen.Text = txtAlmacen.Tag
        txtZonaAlmacen.Tag = objAppConfig.GetValue("Recepcion_Zona", GetType(System.String))
        txtZonaAlmacen.Text = txtZonaAlmacen.Tag

        txtTipoAlmacen_Validating(Nothing, Nothing)
        txtAlmacen_Validating(Nothing, Nothing)
        txtZonaAlmacen_Validating(Nothing, Nothing)
        objAppConfig = Nothing
    End Sub


    Private Sub GuardarControlesUsados()
        '-- Registro los nuevos valores de los campos de los clientes
        Dim objAppConfig As cAppConfig = New cAppConfig
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("Recepcion_TipoRecepcion", txtTipoMovimientoIng.Text)
        objAppConfig.SetValue("Recepcion_TipoAlmacen", txtTipoAlmacen.Text)
        objAppConfig.SetValue("Recepcion_Almacen", txtAlmacen.Text)
        objAppConfig.SetValue("Recepcion_Zona", txtZonaAlmacen.Text)
        objAppConfig = Nothing
        '-- Reinicio las persianas
    End Sub

#End Region

    Private Sub txtEmpresaTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmpresaTransporte.Validating
        If txtEmpresaTransporte.Text = "" Then
            txtEmpresaTransporte.Tag = ""
        Else
            If txtEmpresaTransporte.Text <> "" And "" & txtEmpresaTransporte.Tag = "" Then
                Call mfblnBuscar_EmpresaTransporte(txtEmpresaTransporte.Tag, txtEmpresaTransporte.Text, intNroRUCEmpresaTransporte)
                If txtEmpresaTransporte.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtEmpresaTransporte_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAdjuntarEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarEmbarque.Click
        Dim ofrmEmbarque As New frmEmbarqueAsociadosOC
        ofrmEmbarque.Cliente = intCliente_CCLNT
        ofrmEmbarque.OrdeDeCompra = txtNroOrdenCompra.Text
        If ofrmEmbarque.ShowDialog = Windows.Forms.DialogResult.OK Then
            _PNNORSCI = ofrmEmbarque.Embarque
            Me.txtEmbarque.Text = ofrmEmbarque.Embarque
        End If
    End Sub



    Private Sub txtEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
        If e.KeyChar = Chr(13) Then
            BuscarOcEnEmbarque()
        End If
    End Sub

    Private Sub BuscarOcEnEmbarque()
        Dim obeOrdenCompra As New beOrdenCompra
        Dim obrOrdenDeCompra As New brOrdenDeCompra
        With obeOrdenCompra
            .PNCCLNT = intCliente_CCLNT
            .PSNORCML = txtNroOrdenCompra.Text
            .PNNORSCI = Val(txtEmbarque.Text)
        End With
        Dim olistOC As New List(Of beOrdenCompra)
        With obrOrdenDeCompra
            If .ListaEmbarquePorOC(obeOrdenCompra).Count = 0 Then
                Me.txtEmbarque.Text = 0
                MessageBox.Show("Embarque no Existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub


    Private Sub txtEmbarque_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmbarque.LostFocus
        BuscarOcEnEmbarque()
    End Sub

    Private Sub txtOrigen_CambioDeTexto(ByVal objData As Object) Handles txtOrigen.CambioDeTexto
        If Not objData Is Nothing Then
            UcClienteTerceroOrigen.CodCliente = intCliente_CCLNT
            UcClienteTerceroOrigen.TipoRelacion = CType(Me.txtOrigen.Resultado, beGeneral).PSCCMPRN.Trim
            UcClienteTerceroOrigen.pClear()
        End If
    End Sub



End Class