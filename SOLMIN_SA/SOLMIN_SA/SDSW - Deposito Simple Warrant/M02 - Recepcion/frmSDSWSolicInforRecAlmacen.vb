Public Class frmSDSWSolicInforRecAlmacen
#Region " Tipo de Datos "

#End Region

#Region " Atributos "
    Dim blnResultado As Boolean = False
    Private booStatusGeneral As Boolean = False
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

    Public Property pstrTipoAlmacen() As String
        Get
            Return "" & txtTipoAlmacen.Tag
        End Get
        Set(ByVal value As String)
            txtTipoAlmacen.Tag = value
        End Set
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
            Return "" & txtTipoRecepcion.Tag
        End Get
        Set(ByVal value As String)
            txtTipoRecepcion.Tag = value
        End Set
    End Property

    Public Property pstrDetalleTipoRecepcion() As String
        Get
            Return txtTipoRecepcion.Text
        End Get
        Set(ByVal value As String)
            txtTipoRecepcion.Text = value
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
    'Agregado para Almaceneras
    Public Property pstrRecCaracteristicas() As String
        Get
            Return txtCaracteristicas.Text
        End Get
        Set(ByVal value As String)
            txtCaracteristicas.Text = value
        End Set
    End Property
    'Agregado para Almaceneras
    Public Property pstrRecFechaIngreso() As String
        Get
            'Return txtFechaIngresoItem.Text
            Return dtpfecha.Text

        End Get
        Set(ByVal value As String)
            'txtFechaIngresoItem.Text = value
            dtpfecha.Text = value
        End Set
    End Property
    'Agregado para Almaceneras
    Public Property pstrRecFechaSalida() As String
        Get
            Return dtpfechafinal.Text
        End Get
        Set(ByVal value As String)
            dtpfechafinal.Text = value
        End Set
    End Property

    'Agregado para Almaceneras
    Public Property pstrSerie() As String
        Get
            Return Me.txtserie.Text
        End Get
        Set(ByVal value As String)
            txtserie.Text = value
        End Set
    End Property
#End Region

#Region " Funciones y Procedimientos "
    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""
        Dim decCantidad As Decimal
        Dim dteFechaIngreso As Date = Nothing
        blnResultado = True
        If txtTipoAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Text = "" Then strResultado &= "Debe seleccionar una Zona de Almacén." & vbNewLine
        Decimal.TryParse(txtRecCantidad.Text, decCantidad)
        If decCantidad <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
        If txtTipoRecepcion.Text = "" Then strResultado &= "Debe seleccionar el Tipo de Recepción." & vbNewLine

        If txtserie.Enabled = True Then
            If Me.txtserie.Text = 0 Or Me.txtserie.Text = "" Then strResultado &= "Debe ingresar N° de Serie" & vbNewLine
            With frmSDSWRecepcionSDS
                Dim p As Integer
                For p = 0 To .dgMercaderiaSeleccionada.RowCount - 1
                    If txtserie.Text = .dgMercaderiaSeleccionada.Item(28, p).Value Then strResultado &= "Debe cambiar de serie ya se encuentra registrada." & vbNewLine
                Next
            End With
        End If

        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
    Private Sub pMostrarCaracteristicas()

        If booStatusGeneral Then
            Me.Height = 443  '305 443
            Me.btnAgregarRecepcionItem.Top = 389 '243  389
            Me.btnCancelar.Top = 389 '389
            Me.txtCaracteristicas.Enabled = True
            Me.txtCaracteristicas.Visible = True
            Me.txtCaracteristicas.Focus()
        Else
            Me.Height = 334  '334
            Me.btnAgregarRecepcionItem.Top = 279 '282
            Me.btnCancelar.Top = 279  '282
            Me.txtCaracteristicas.Enabled = False
            Me.txtCaracteristicas.Visible = False
        End If
        booStatusGeneral = Not booStatusGeneral
    End Sub

#End Region

#Region " Eventos "

    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaTipoRecepcionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoRecepcionListar.Click
        Call mfblnBuscar_SDSWTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionItem.Click

        If fblnValidarInfItemRecepcion() Then Me.Close()
        ' frmRecepcionSDS.bsaGenerarticket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub txtAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
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
                Call mfblnBuscar_AlmacenSDSW("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
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
                Call mfblnBuscar_TipoAlmacenSDSW(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoRecepcion.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_SDSWTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub

    Private Sub txtTipoRecepcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoRecepcion.TextChanged
        txtTipoRecepcion.Tag = ""
    End Sub

    Private Sub txtTipoRecepcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoRecepcion.Validating
        If txtTipoRecepcion.Text = "" Then
            txtTipoRecepcion.Tag = ""
        Else
            If txtTipoRecepcion.Text <> "" And "" & txtTipoRecepcion.Tag = "" Then
                Call mfblnBuscar_SDSWTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
                If txtTipoRecepcion.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtZonaAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZonaAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
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
                Call mfblnBuscar_ZonasAlmacenSDSW("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
                If txtZonaAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub chkCaracteristicas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCaracteristicas.CheckedChanged

        Call pMostrarCaracteristicas()
    End Sub

#End Region

#Region " Métodos "

    Private Sub frmSolicInforMovAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub frmSolicInforRecAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Compania_Usuario = "LZ" Or Compania_Usuario = "AM" Then
            chkCaracteristicas.Visible = True
            lblFechaIngresoItem.Visible = True
            'txtFechaIngresoItem.Visible = True
            'Me.txtFechaIngresoItem.Text = Now
            Call pMostrarCaracteristicas()
        End If
    End Sub

#End Region


End Class
