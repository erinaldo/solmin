Imports Ransa.TYPEDEF
Imports Ransa.NEGO

Public Class frmSolicInforRecAlmacen
#Region " Tipo de Datos "

#End Region
#Region " Atributos "
    Dim blnResultado As Boolean = False
#End Region
#Region " Propiedades "

    Private intCliente As Integer = 0
    Private intPlanta As Integer = 0

    Public WriteOnly Property pintCliente() As Decimal
        Set(ByVal value As Decimal)
            intCliente = value
        End Set
    End Property

    Public Property pintPlanta() As Decimal
        Get
            Return intPlanta
        End Get
        Set(ByVal value As Decimal)
            intPlanta = value
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

    Public Property pstrNroRUCCliente() As String
        Get
            Return txtNroRUCCliente.Text
        End Get
        Set(ByVal value As String)
            txtNroRUCCliente.Text = value
        End Set
    End Property

    Public Property pstrTipoAlmacen() As String
        Get
            Return "" & CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Valor = value
        End Set
    End Property

    Public Property pstrDetalleTipoAlmacen() As String
        Get
            Return CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Text = value
        End Set
    End Property

    Public Property pstrAlmacen() As String
        Get
            Return "" & CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
        End Get
        Set(ByVal value As String)
            txtAlmacen.Valor = value
        End Set
    End Property

    Public Property pstrDetalleAlmacen() As String
        Get
            Return "" & CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL 'tcmpal
        End Get
        Set(ByVal value As String)
            txtAlmacen.Text = value
        End Set
    End Property

    Public Property pstrZonaAlmacen() As String
        Get
            Return "" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Valor = value
        End Set
    End Property

    Public Property pstrDetalleZonaAlmacen() As String
        Get
            Return "" & CType(txtZonaAlmacen.Resultado, beAlmacen).PSTCMZNA
        End Get
        Set(ByVal value As String)
            txtZonaAlmacen.Text = value
        End Set
    End Property

    Public Property pdecRecCantidad() As Decimal
        Get
            Return txtRecCantidad.Text
        End Get
        Set(ByVal value As Decimal)
            txtRecCantidad.Text = value
        End Set
    End Property

    Public Property pdecRecPeso() As Decimal
        Get
            Return txtRecPeso.Text
        End Get
        Set(ByVal value As Decimal)
            txtRecPeso.Text = value
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

    Public Property pstrContenedor() As String
        Get
            Return txtContenedor.Text
        End Get
        Set(ByVal value As String)
            txtContenedor.Text = value
        End Set
    End Property

    Public Property pstrRecObservacion() As String
        Get
            Return txtRecObservacion.Text
        End Get
        Set(ByVal value As String)
            txtRecObservacion.Text = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal
        blnResultado = True
        If txtTipoAlmacen.Resultado Is Nothing Then strResultado &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strResultado &= "Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Resultado Is Nothing Then strResultado &= "Debe seleccionar una Zona de Almacén." & vbNewLine
        Decimal.TryParse(txtRecCantidad.Text, decCantidad)
        If decCantidad <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
        If txtTipoMovimientoIng.Resultado Is Nothing Then strResultado &= "Debe seleccionar el Tipo de Recepción." & vbNewLine
        If Not txtTipoMovimientoIng.Resultado Is Nothing Then
            If CType(txtTipoMovimientoIng.Resultado, beGeneral).PSSTPING = "T" Then
                strResultado &= "- El tipo de Rec. : T-> Transferencia no se puede realizar por esta opción." & vbNewLine
            End If
        End If
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
     

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionItem.Click
        Try
            If fblnValidarInfItemRecepcion() Then Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Try
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
            Dim obrAlmacen As New brAlmacen
            If Not objData Is Nothing Then
                'CType(objData, beAlmacen).PNCPLNFC = 1
                CType(objData, beAlmacen).PNCPLNFC = pintPlanta
                txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
            Else
                txtAlmacen.DataSource = Nothing
            End If
            txtAlmacen.ListColumnas = oListColum
            txtAlmacen.Cargas()
            txtAlmacen.Limpiar()
            txtAlmacen.ValueMember = "PSCALMC"
            txtAlmacen.DispleyMember = "PSTCMPAL"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto

        Try
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
            Dim obrAlmacen As New brAlmacen
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


#End Region
#Region " Métodos "

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub frmSolicInforMovAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub
#End Region

    Private Sub frmSolicInforRecAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            CargarControles()
            CargarControlTipoAlmacen()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub CargarControles()
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
        Dim obrGeneral As New RANSA.NEGO.brGeneral
        txtTipoMovimientoIng.DataSource = obrGeneral.floListaTipoMovimientoRecepcionCliente(intCliente)
        txtTipoMovimientoIng.ListColumnas = oListColum
        txtTipoMovimientoIng.Cargas()
        txtTipoMovimientoIng.ValueMember = "PSSTPING"
        txtTipoMovimientoIng.DispleyMember = "PSTTPING"
    End Sub

    Private Sub CargarControlTipoAlmacen()
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
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub

End Class
