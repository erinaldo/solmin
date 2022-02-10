Public Class frmSolicInforRecSAut
#Region " Tipo de Datos "

#End Region
#Region " Atributos "
    Dim intCliente As Int64 = 0
    Dim blnResultado As Boolean = False
    Dim blnProcOSConLBS As Boolean = False
#End Region
#Region " Propiedades "
    Public WriteOnly Property pblnProcesarOSConLiberacion() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                blnProcOSConLBS = value
                grpInfOS.Visible = False
                grpSerie.Left = 10
                grpSerie.Top = 12
                Me.Height = 380
            End If
        End Set
    End Property

    Public WriteOnly Property pintCliente() As Int64
        Set(ByVal value As Int64)
            intCliente = value
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

    Public Property pstrTipoRecepcion() As String
        Get
            Return "" & txtTipoRecepcion.Tag
        End Get
        Set(ByVal value As String)
            txtTipoRecepcion.Tag = value
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

    Public Property pstrRecObservacion() As String
        Get
            Return txtRecObservacion.Text
        End Get
        Set(ByVal value As String)
            txtRecObservacion.Text = value
        End Set
    End Property

    Public Property pstrCodigoEquipoManipuleo() As String
        Get
            Return txtEquipoManipuleo.Tag
        End Get
        Set(ByVal value As String)
            txtEquipoManipuleo.Tag = value
        End Set
    End Property

    Public Property pstrDetalleEquipoManipuleo() As String
        Get
            Return txtEquipoManipuleo.Text
        End Get
        Set(ByVal value As String)
            txtEquipoManipuleo.Text = value
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

    Public WriteOnly Property pintSerie() As Int32
        Set(ByVal value As Int32)
            txtSerie.Text = value
        End Set
    End Property

    Public WriteOnly Property pstrCodigoMercaderia() As String
        Set(ByVal value As String)
            txtCodigoMercaderia.Text = value
        End Set
    End Property

    Public WriteOnly Property pstrMercaderia() As String
        Set(ByVal value As String)
            txtMercaderia.Text = value
        End Set
    End Property

    Public WriteOnly Property pstrDetalleMercaderia() As String
        Set(ByVal value As String)
            txtDetalleMercaderia.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecCantidadBultoDeclarada() As Decimal
        Set(ByVal value As Decimal)
            txtCantidadDeclarada.Text = value
        End Set
    End Property

    Public WriteOnly Property pstrUnidadBulto() As String
        Set(ByVal value As String)
            lblUnidadBulto.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecPesoNetoDeclarada() As Decimal
        Set(ByVal value As Decimal)
            txtPesoNetoDeclarado.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecPesoBrutoDeclarada() As Decimal
        Set(ByVal value As Decimal)
            txtPesoBrutoDeclarado.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecCantidadBultoRecepcionada() As Decimal
        Set(ByVal value As Decimal)
            txtCantidadRecepcionada.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecPesoNetoRecepcionada() As Decimal
        Set(ByVal value As Decimal)
            txtPesoNetoRecepcionada.Text = value
        End Set
    End Property

    Public WriteOnly Property pdecPesoBrutoRecepcionada() As Decimal
        Set(ByVal value As Decimal)
            txtPesoBrutoRecepcionada.Text = value
        End Set
    End Property

    Public ReadOnly Property pdecCantidadSerie() As Decimal
        Get
            Dim decTemp As Decimal = 0
            Decimal.TryParse(Me.txtCantidadSerie.Text, decTemp)
            Return decTemp
        End Get
    End Property

    Public ReadOnly Property pdecPesoSerie() As Decimal
        Get
            Dim decTemp As Decimal = 0
            Decimal.TryParse(Me.txtPesoSerie.Text, decTemp)
            Return decTemp
        End Get
    End Property

    Public ReadOnly Property pstrObservacionSerie() As String
        Get
            Return txtObservacionSerie.Text
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnValidarInfItemRecepcion() As Boolean
        Dim strResultado As String = ""
        Dim decTemp As Decimal
        blnResultado = True
        ' Se evalua solo sin no posee liberación
        If Not blnProcOSConLBS Then
            If txtTipoAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
            If txtAlmacen.Text = "" Then strResultado &= "Debe seleccionar un Almacén" & vbNewLine
            If txtZonaAlmacen.Text = "" Then strResultado &= "Debe seleccionar una Zona de Almacén." & vbNewLine
            Decimal.TryParse(txtRecCantidad.Text, decTemp)
            If decTemp <= 0 Then strResultado &= "Debe ingresar una Cantidad mayor a Cero." & vbNewLine
            If txtTipoRecepcion.Text = "" Then strResultado &= "Debe seleccionar el Tipo de Recepción." & vbNewLine
        End If
        ' Se evalua en cualquier caso
        Decimal.TryParse(txtCantidadSerie.Text, decTemp)
        If decTemp <= 0 Then strResultado &= "Debe ingresar una Cantidad para la Serie mayor a Cero." & vbNewLine
        Decimal.TryParse(txtPesoSerie.Text, decTemp)
        If decTemp <= 0 Then strResultado &= "Debe ingresar un Peso para la Serie mayor a Cero." & vbNewLine
        ' Evaluamos si se presentó algún error
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAlmacenListar.Click
        Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
    End Sub

    Private Sub bsaEquipoManipuleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEquipoManipuleo.Click
        Call mfblnBuscar_EquipoManipuleo(txtEquipoManipuleo.Tag, txtEquipoManipuleo.Text)
    End Sub

    Private Sub bsaTipoAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoAlmacenListar.Click
        Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
    End Sub

    Private Sub bsaTipoRecepcionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoRecepcionListar.Click
        Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
    End Sub

    Private Sub bsaZonaAlmacenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaZonaAlmacenListar.Click
        Call mfblnBuscar_ZonasAlmacen("" & txtTipoAlmacen.Tag, "" & txtAlmacen.Tag, txtZonaAlmacen.Tag, txtZonaAlmacen.Text)
    End Sub

    Private Sub btnAgregarRecepcionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionItem.Click
        If fblnValidarInfItemRecepcion() Then Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnResultado = True
        Me.Close()
    End Sub

    Private Sub frmSolicInforRecSAut_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnResultado Then e.Cancel = True
    End Sub

    Private Sub frmSolicInforRecSAut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Obtengo el Tipo de Movimiento por defecto
        Call mfstrDefecto_TipoMovimientoRecepcion(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
        ' Obtengo los últimos almacenes para este cliente
        Call mfblnObtener_InfUltimoAlmacenSegunCliente(intCliente, txtTipoAlmacen.Tag, txtTipoAlmacen.Text, txtAlmacen.Tag, txtAlmacen.Text)
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
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtEquipoManipuleo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEquipoManipuleo.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_EquipoManipuleo(txtEquipoManipuleo.Tag, txtEquipoManipuleo.Text)
            Case Keys.Delete
                txtEquipoManipuleo.Text = ""
        End Select
    End Sub

    Private Sub txtEquipoManipuleo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEquipoManipuleo.TextChanged
        txtEquipoManipuleo.Tag = ""
    End Sub

    Private Sub txtEquipoManipuleo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEquipoManipuleo.Validating
        If txtEquipoManipuleo.Text = "" Then
            txtEquipoManipuleo.Tag = ""
        Else
            If txtEquipoManipuleo.Text <> "" And "" & txtEquipoManipuleo.Tag = "" Then
                Call mfblnBuscar_EquipoManipuleo(txtEquipoManipuleo.Tag, txtEquipoManipuleo.Text)
                If txtEquipoManipuleo.Text = "" Then
                    e.Cancel = True
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
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoRecepcion.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
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
                Call mfblnBuscar_SDSTipoMovimiento(txtTipoRecepcion.Tag, txtTipoRecepcion.Text)
                If txtTipoRecepcion.Text = "" Then
                    e.Cancel = True
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
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
