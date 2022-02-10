Public Class frmSDSWSolicInforDesAlmacen
#Region " Tipo de Datos "

#End Region
#Region " Atributos "
    Dim blnResultado As Boolean = False
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
            Return "" & txtTipoDespacho.Tag
        End Get
        Set(ByVal value As String)
            txtTipoDespacho.Tag = value
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return txtTipoDespacho.Text
        End Get
        Set(ByVal value As String)
            txtTipoDespacho.Text = value
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
    'Agregado para Almaceneras
    Public Property pstrDescripcion() As String
        Get
            Return txtProducto.Text
        End Get
        Set(ByVal value As String)
            txtProducto.Text = value

        End Set
    End Property
#End Region

#Region " Funciones y Procedimientos "
    Private Function fblnValidarInfItemDespacho() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal

        blnResultado = True
        Decimal.TryParse(txtDesCantidad.Text, decCantidad)
        If decCantidad <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
        If txtTipoDespacho.Text = "" Then strResultado &= "Debe seleccionar el Tipo de Despacho." & vbNewLine

        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region

#Region " Eventos "
    Private Sub bsaTipoDespachoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoDespachoListar.Click

        Call mfblnBuscar_SDSWTipoMovimiento(txtTipoDespacho.Tag, txtTipoDespacho.Text)
    End Sub

    Private Sub btnAgregarDespachoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDespachoItem.Click
        If fblnValidarInfItemDespacho() Then Me.Close()
        'frmDespachoSDSA.bsaGenerarTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub frmSolicInforDesAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Obtengo el Tipo de Movimiento por defecto
        Call mfstrDefecto_TipoMovimientoDespacho_SDSW(txtTipoDespacho.Tag, txtTipoDespacho.Text)
    End Sub

    Private Sub txtTipoDespacho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoDespacho.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_SDSWTipoMovimiento(txtTipoDespacho.Tag, txtTipoDespacho.Text)
        End Select
    End Sub

    Private Sub txtTipoDespacho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoDespacho.TextChanged
        txtTipoDespacho.Tag = ""
    End Sub

    Private Sub txtTipoDespacho_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoDespacho.Validating
        If txtTipoDespacho.Text = "" Then
            txtTipoDespacho.Tag = ""
        Else
            If txtTipoDespacho.Text <> "" And "" & txtTipoDespacho.Tag = "" Then
                Call mfblnBuscar_SDSWTipoMovimiento(txtTipoDespacho.Tag, txtTipoDespacho.Text)
                If txtTipoDespacho.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
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
