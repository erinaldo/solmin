Public Class frmTipoEtiqueta

    Dim _accept As Boolean = False
    Dim _normal As Boolean = True
    Dim _extendida As Boolean = False
    Dim nro_oc As String = ""
    Dim uni_med As String = ""
    Dim cant As Int32 = 1
    Dim _cantu As String = ""
    Private _referencia As String = ""
    Private _ubicacion As String = ""
    Private _vs_almacen As String = ""
    Private _CZNALM As String = ""
    Private _lote As String = ""    'EGL - HUNDRED


    Public Property CZNALM() As String
        Get
            Return _CZNALM
        End Get
        Set(ByVal value As String)
            _CZNALM = value
        End Set
    End Property


    Public Property vs_almacen() As String
        Get
            Return _vs_almacen
        End Get
        Set(ByVal value As String)
            _vs_almacen = value
        End Set
    End Property


    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property

    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    'EGL - HUNDRED
    Public Property Lote() As String
        Get
            Return _lote
        End Get
        Set(ByVal value As String)
            _lote = value
        End Set
    End Property

    Public Property NroOC() As String
        Get
            Return nro_oc
        End Get
        Set(ByVal value As String)
            nro_oc = value
        End Set
    End Property

    Public Property UniMed() As String
        Get
            Return uni_med
        End Get
        Set(ByVal value As String)
            uni_med = value
        End Set
    End Property

    Public Property CantUnidad() As String
        Get
            Return _cantu
        End Get
        Set(ByVal value As String)
            _cantu = value
        End Set
    End Property

    Public Property Accept() As Boolean
        Get
            Return _accept
        End Get
        Set(ByVal value As Boolean)
            _accept = value
        End Set
    End Property

    Public Property cantidad() As Int32
        Get
            Return cant
        End Get
        Set(ByVal value As Int32)
            cant = value
        End Set
    End Property

    Public ReadOnly Property TipoEtiqueta() As String
        Get
            If Me._normal = True Then
                Return "NORMAL"
            Else
                Return "MERCADERIA"
            End If
        End Get
    End Property
    Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton2.Click
        If Me.rdmercaderia.Checked = True Then
            If Me.txtReferencia.Text.Trim = "" Then
                MsgBox("Debe de ingresar el numero de la orden de compra")
                Exit Sub
            End If
        End If
        If Me.txtCantidad.Text.Trim = "" Then
            MsgBox("Debe de ingresar el numero de copias")
            Exit Sub
        End If
        Me.cant = CInt(Me.txtCantidad.Text)
        Me.nro_oc = Me.txtOrdenCompra.Text
        Me.uni_med = ""
        Me._cantu = Me.txtcantidadU.Text
        Me._accept = True
        Me._ubicacion = Me.txtUbicacion.Text
        Me._referencia = Me.txtReferencia.Text

        Me._vs_almacen = Me.txtAlmacen.Text
        'Me.CZNALM = 

        Me._lote = Me.txtLote.Text  'EGL - HUNDRED

        Me.Close()
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me._accept = False
        Me.Close()
    End Sub

    Private Sub frmTipoEtiqueta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me._normal = True
        Me._extendida = False
    End Sub

    Private Sub KryptonRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdnormal.CheckedChanged
        If Me.rdnormal.Checked = True Then
            Me.lblcompra.Visible = False
            Me.txtReferencia.Visible = False
            Me.lblcompra.Visible = False
            Me.txtReferencia.Visible = False
            Me.lblcantidad.Visible = False
            Me.txtcantidadU.Visible = False
            Me.txtOrdenCompra.Visible = False
            Me.txtUbicacion.Visible = False
            Me.lblOrdenCompra.Visible = False
            Me.lblUbicacion.Visible = False
            Me._normal = True
            Me._extendida = False
            Me.txtAlmacen.Visible = False
            Me.txtLote.Visible = False 'EGL - HUNDRED
            Me.lblLote.Visible = False 'EGL - HUNDRED
            KryptonLabel1.Visible = False
           

        End If
    End Sub

    Private Sub KryptonRadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdmercaderia.CheckedChanged
        If Me.rdmercaderia.Checked = True Then
            Me.lblcompra.Visible = True
            Me.txtReferencia.Visible = True
            Me.lblcantidad.Visible = True
            Me.txtcantidadU.Visible = True
            Me.txtOrdenCompra.Visible = True
            Me.txtUbicacion.Visible = True
            Me.lblOrdenCompra.Visible = True
            Me.lblUbicacion.Visible = True
            Me._normal = False
            Me._extendida = True
            Me.txtAlmacen.Visible = True
            Me.txtLote.Visible = True 'EGL - HUNDRED
            Me.lblLote.Visible = True 'EGL - HUNDRED
            KryptonLabel1.Visible = True
           


        End If
    End Sub
End Class
