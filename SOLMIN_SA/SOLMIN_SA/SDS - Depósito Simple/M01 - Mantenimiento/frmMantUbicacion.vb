
Imports Ransa.TYPEDEF


Public Class frmMantUbicacion

    Private _obeMercaderia As beMercaderia

    Public Property obeMercaderia() As beMercaderia
        Get
            Return _obeMercaderia
        End Get
        Set(ByVal value As beMercaderia)
            _obeMercaderia = value
        End Set
    End Property

    Private _IdPlanta As String
    Public Property IdPlanta() As String
        Get
            Return _IdPlanta
        End Get
        Set(ByVal value As String)
            _IdPlanta = value
        End Set
    End Property

    Private Sub frmMantUbicacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarControles()

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        UcUbicaciones_Dg1.Guardar()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        
    End Sub


    Private Sub CargarControles()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New Ransa.NEGO.brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New Ransa.NEGO.brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = IdPlanta 'por de fecto callao
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
        txtZonaAlmacen.Limpiar() 'CCR - HUNDRED

    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        'CSR-HUNDRED-INICIO

        'If objData Is Nothing Then
        '    Exit Sub
        'End If
        '_obeMercaderia.PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'txtTipoAlmacen.Tag
        '_obeMercaderia.PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC 'txtAlmacen.Tag

        'UcUbicaciones_Dg1.Regularizacion = True

        'If _obeMercaderia.PSTIPO = "DES" Then
        '    UcUbicaciones_Dg1.ModoGrid = Ransa.Controls.eModoGrid.Despacho
        '    Me.UcUbicaciones_Dg1.fListaDesp(0, _
        '         _obeMercaderia.PNNORDSR, _
        '          _obeMercaderia.PSCTPALM, _
        '          _obeMercaderia.PSCALMC, _
        '          _obeMercaderia.PNQUBICACION, _
        '          _obeMercaderia.PSUSUARIO, _
        '          False, _
        '          1)
        'Else

        '    Dim obrMercaderia As New RANSA.NEGO.brMercaderia
        '    Dim olstMercaderia As New List(Of beMercaderia)
        '    olstMercaderia = obrMercaderia.ListaKardexAlmacen(_obeMercaderia)

        '    _obeMercaderia.PNQALMC = 0
        '    If olstMercaderia.Count > 0 Then
        '        For intx As Integer = 0 To olstMercaderia.Count - 1
        '            _obeMercaderia.PNQALMC += olstMercaderia.Item(intx).PNQSLMC2
        '        Next
        '    Else
        '        _obeMercaderia.PNQALMC = 0
        '    End If

        '    txtStockAlmacen.Text = _obeMercaderia.PNQALMC

        '    UcUbicaciones_Dg1.ModoGrid = Ransa.Controls.eModoGrid.Ingreso

        '    Me.UcUbicaciones_Dg1.fListaIng(_obeMercaderia.PNNORDSR, _
        '         _obeMercaderia.PNCCLNT, _
        '         _obeMercaderia.PSCMRCLR, _
        '         _obeMercaderia.PSCTPALM, _
        '         _obeMercaderia.PSCALMC, _
        '          _obeMercaderia.PNQALMC, _
        '         _obeMercaderia.PSUSUARIO, _
        '        False)
        'End If


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New Ransa.NEGO.brAlmacen
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"

        'CSR-HUNDRED-FIN

    End Sub

    Private Sub txtZonaAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtZonaAlmacen.CambioDeTexto

        'CSR-HUNDRED-INICIO
        If objData Is Nothing Then
            Exit Sub
        End If
        _obeMercaderia.PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'txtTipoAlmacen.Tag
        _obeMercaderia.PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC 'txtAlmacen.Tag

        _obeMercaderia.PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM

        UcUbicaciones_Dg1.Regularizacion = True

        If _obeMercaderia.PSTIPO = "DES" Then
            UcUbicaciones_Dg1.ModoGrid = Ransa.Controls.eModoGrid.Despacho
            Me.UcUbicaciones_Dg1.fListaDesp(0, _
                  _obeMercaderia.PNNORDSR, _
                  _obeMercaderia.PSCTPALM, _
                  _obeMercaderia.PSCALMC, _
                  _obeMercaderia.PSCZNALM, _
                  _obeMercaderia.PNQUBICACION, _
                  _obeMercaderia.PSUSUARIO, _
                  False, _
                  1)
        Else


            Dim obrMercaderia As New Ransa.NEGO.brMercaderia
            Dim olstMercaderia As New List(Of beMercaderia)
            olstMercaderia = obrMercaderia.ListaKardexAlmacen(_obeMercaderia)

            _obeMercaderia.PNQALMC = 0
            If olstMercaderia.Count > 0 Then
                For intx As Integer = 0 To olstMercaderia.Count - 1
                    _obeMercaderia.PNQALMC += olstMercaderia.Item(intx).PNQSLMC2
                Next
            Else
                _obeMercaderia.PNQALMC = 0
            End If

            txtStockAlmacen.Text = _obeMercaderia.PNQALMC

            UcUbicaciones_Dg1.ModoGrid = Ransa.Controls.eModoGrid.Ingreso


            Me.UcUbicaciones_Dg1.fListaIng(_obeMercaderia.PNNORDSR, _
                 _obeMercaderia.PNCCLNT, _
                 _obeMercaderia.PSCMRCLR, _
                 _obeMercaderia.PSCTPALM, _
                 _obeMercaderia.PSCALMC, _
                 _obeMercaderia.PSCZNALM, _
                 _obeMercaderia.PNQALMC, _
                 _obeMercaderia.PSUSUARIO, _
                False)

        End If

        'CSR-HUNDRED-FIN
    End Sub

End Class
