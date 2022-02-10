Public Class frmSolicInforDesAlmacen
#Region " Tipo de Datos "

#End Region
#Region " Atributos "
    Dim blnResultado As Boolean = False
    Dim decCantidadTope As Decimal = 0
    Dim decPesoTope As Decimal = 0
#End Region
#Region " Propiedades "
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

    Public Property pdecRecCantidad() As Decimal
        Get
            Return txtDesCantidad.Text
        End Get
        Set(ByVal value As Decimal)
            txtDesCantidad.Text = value
        End Set
    End Property

    Public Property pdecRecPeso() As Decimal
        Get
            Return txtDesPeso.Text
        End Get
        Set(ByVal value As Decimal)
            txtDesPeso.Text = value
        End Set
    End Property

    Public Property pstrTipoDespacho() As String
        Get
            Return "" & CType(txtTipoDesOutotec.Resultado, Ransa.TypeDef.beGeneral).PSSTPING
        End Get
        Set(ByVal value As String)
            txtTipoDesOutotec.Valor = value
            txtTipoDesOutotec.Refresh()
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return CType(txtTipoDesOutotec.Resultado, Ransa.TYPEDEF.beGeneral).PSTTPING
        End Get
        Set(ByVal value As String)
            txtTipoDesOutotec.Valor = value
            txtTipoDesOutotec.Refresh()
        End Set
    End Property

    Public Property pintNroVigencia() As Integer
        Get
            Return txtVigencia.Text
        End Get
        Set(ByVal value As Integer)
            txtVigencia.Text = value
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


    Private pintCCLNT As Integer
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarInfItemDespacho() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal
        Dim decPeso As Decimal

        blnResultado = True
        Decimal.TryParse(txtDesCantidad.Text, decCantidad)
        If decCantidad < 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
        If decCantidad > decCantidadTope Then strResultado &= "Debe ingresar una Cantidad menor o igual al Tope." & vbNewLine
        Decimal.TryParse(txtDesPeso.Text, decPeso)
        If decPeso < 0 Then strResultado &= "Debe ingresar un Peso mayor o igual a Cero." & vbNewLine
        If decPeso > decPesoTope Then strResultado &= "Debe ingresar un Peso menor o igual al Tope." & vbNewLine
        If txtTipoDesOutotec.Resultado Is Nothing Then strResultado &= "- Debe seleccionar Tipo de Despacho." & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
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
        oColumnas.HeaderText = "Tipo Despacho "
        oListColum.Add(2, oColumnas)
        Dim obrGeneral As New Ransa.NEGO.brGeneral
        txtTipoDesOutotec.DataSource = obrGeneral.floListaTipoMovimientoDespachoCliente(pintCCLNT)
        txtTipoDesOutotec.ListColumnas = oListColum
        txtTipoDesOutotec.Cargas()
        txtTipoDesOutotec.ValueMember = "PSSTPING"
        txtTipoDesOutotec.DispleyMember = "PSTTPING"
      


        If obrGeneral.bolElClienteEsOutotec(pintCCLNT) Then
            txtTipoDesOutotec.Valor = "A"
            txtTipoDesOutotec.Refresh()
        Else
            txtTipoDesOutotec.Valor = "N"
            txtTipoDesOutotec.Refresh()
        End If


    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal TopeQta As Decimal, ByVal TopePeso As Decimal, ByVal intCCLNT As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        decCantidadTope = TopeQta
        decPesoTope = TopePeso
        pintCCLNT = intCCLNT
    End Sub


    Private Sub btnAgregarDespachoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDespachoItem.Click
      
        If fblnValidarInfItemDespacho() Then Me.Close()

    End Sub

    Private Sub frmSolicInforDesAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDesCantidad.Text = decCantidadTope
        txtDesPeso.Text = decPesoTope
        CargarControles()
        ' Obtengo el Tipo de Movimiento por defecto
        'Call mfstrDefecto_TipoMovimientoDespacho(txtTipoDespacho.Tag, txtTipoDespacho.Text)
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
End Class
