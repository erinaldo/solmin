Public Class frmProcesarAjuste

#Region "Propiedades "
    Public Property pdecRecCantidad() As Decimal
        Get
            Return Me.txtDesCantidad.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDesCantidad.Text = value
        End Set
    End Property

    Public Property pdecRecPeso() As Decimal
        Get
            Return Me.txtDesPeso.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDesPeso.Text = value
        End Set
    End Property

    Public Property pstrTipoDespacho() As String
        Get
            Return "" & CType(Me.txtTipoDesOutotec.Resultado, Ransa.TYPEDEF.beGeneral).PSSTPING
        End Get
        Set(ByVal value As String)
            Me.txtTipoDesOutotec.Valor = value
            Me.txtTipoDesOutotec.Refresh()
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return CType(Me.txtTipoDesOutotec.Resultado, Ransa.TYPEDEF.beGeneral).PSTTPING
        End Get
        Set(ByVal value As String)
            Me.txtTipoDesOutotec.Valor = value
            Me.txtTipoDesOutotec.Refresh()
        End Set
    End Property

    Public Property pstrRecObservacion() As String
        Get
            Return Me.txtRecObservacion.Text
        End Get
        Set(ByVal value As String)
            Me.txtRecObservacion.Text = value
        End Set
    End Property

#End Region

#Region "Variables"
    Dim blnResultado As Boolean = False
    Dim strTipoAjuste As String
    Dim decCantidadTope As Decimal = 0
    Dim decPesoTope As Decimal = 0
    'Dim strStatus As String

    Private pintCCLNT As Integer = 0
#End Region

#Region "Inicializador"
    Sub New(ByVal TpoAjuste As String, ByVal TopeQta As Decimal, ByVal TopePeso As Decimal, ByVal Status As String, ByVal intCCLNT As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        strTipoAjuste = TpoAjuste
        decCantidadTope = TopeQta
        decPesoTope = TopePeso
        'strStatus = Status
        pintCCLNT = intCCLNT
    End Sub
#End Region

#Region "Metodos y Funciones"
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
        If strTipoAjuste = "P" Then
            txtTipoDesOutotec.DataSource = obrGeneral.floListaTipoMovimientoRecepcionCliente(pintCCLNT)
            txtTipoDesOutotec.ListColumnas = oListColum

            txtTipoDesOutotec.Cargas()
            txtTipoDesOutotec.ValueMember = "PSSTPING"
            txtTipoDesOutotec.DispleyMember = "PSTTPING"

            If obrGeneral.bolElClienteEsOutotec(pintCCLNT) Then
                txtTipoDesOutotec.Valor = "G"
                txtTipoDesOutotec.Refresh()
            Else
                txtTipoDesOutotec.Valor = "J"
                txtTipoDesOutotec.Refresh()
            End If
        Else
            txtTipoDesOutotec.DataSource = obrGeneral.floListaTipoMovimientoDespachoCliente(pintCCLNT)
            txtTipoDesOutotec.ListColumnas = oListColum

            txtTipoDesOutotec.Cargas()
            txtTipoDesOutotec.ValueMember = "PSSTPING"
            txtTipoDesOutotec.DispleyMember = "PSTTPING"

            If obrGeneral.bolElClienteEsOutotec(pintCCLNT) Then
                txtTipoDesOutotec.Valor = "D"
                txtTipoDesOutotec.Refresh()
            Else
                txtTipoDesOutotec.Valor = "A"
                txtTipoDesOutotec.Refresh()
            End If
        End If
    End Sub

    Private Function fblnValidarAjusteNegativo() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal
        'Dim decPeso As Decimal
        blnResultado = True
        'If strStatus = "C" Then
        '    Decimal.TryParse(txtDesPeso.Text, decPeso)

        '    If decPesoTope = 0 Then strResultado &= "Debe ingresar un Peso mayor  a Cero." & vbNewLine

        '    If decPesoTope >= 0 Then
        '        If decPeso <= 0 Then strResultado &= "Debe ingresar un Peso mayor  a Cero." & vbNewLine
        '        If decPeso > (decPesoTope) Then strResultado &= "Debe ingresar un Peso menor o igual al Tope." & vbNewLine
        '    End If
        'Else
        Decimal.TryParse(txtDesCantidad.Text, decCantidad)
        If decCantidadTope > 0 Then
            If decCantidad <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor  a Cero." & vbNewLine
            If decCantidad > decCantidadTope Then strResultado &= "Debe ingresar un Cantidad menor o igual al Tope." & vbNewLine
        End If
        'End If
        'If Me.txtTipoDesOutotec.Resultado Is Nothing Then strResultado &= "- Debe seleccionar Tipo de Despacho." & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

    Private Function fblnValidarAjustePositivo() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal
        'Dim decPeso As Decimal
        blnResultado = True
        'If strStatus = "C" Then
        '    Decimal.TryParse(txtDesPeso.Text, decPeso)
        '    If decPesoTope >= 0 Then
        '        If decPeso <= 0 Then strResultado &= "Debe ingresar un Peso mayor a Cero." & vbNewLine
        '    Else
        '        If decPeso <> -(decPesoTope) Then strResultado &= "Debe ingresar un Peso igual al Tope, pero positivo." & vbNewLine
        '    End If
        'Else
        Decimal.TryParse(txtDesCantidad.Text, decCantidad)
        If decCantidadTope >= 0 Then
            If decCantidad <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
            'Else
            '    If decCantidad <> -(decCantidadTope) Then strResultado &= "Debe ingresar una Cantidad igual al Tope, pero positivo." & vbNewLine
        End If
        'End If

        'If Me.txtTipoDesOutotec.Resultado Is Nothing Then strResultado &= "- Debe seleccionar Tipo de Despacho." & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region

#Region "Eventos de Formulario"
    Private Sub frmDlgAjustes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub frmDlgAjustes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If strStatus = "C" Then
        '    txtDesCantidad.Enabled = False
        '    txtDesCantidad.Text = "0.00"
        '    txtDesPeso.Text = "0.00"
        'Else
        '    txtDesPeso.Enabled = False
        '    txtDesPeso.Text = "0.00"
        '    txtDesCantidad.Text = "0.00"
        'End If
        CargarControles()
    End Sub

    Private Sub btnAgregarDespachoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDespachoItem.Click
        If strTipoAjuste = "P" Then
            If fblnValidarAjustePositivo() Then Me.Close()
        ElseIf strTipoAjuste = "N" Then
            If fblnValidarAjusteNegativo() Then Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub
#End Region

End Class