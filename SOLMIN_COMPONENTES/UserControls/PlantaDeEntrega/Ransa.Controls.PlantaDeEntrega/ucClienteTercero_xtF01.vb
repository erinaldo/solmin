Imports System.Windows.Forms
Imports Ransa.TypeDef.PlantaDeEntrega
Imports system.ComponentModel
Imports Ransa.DAO.PlantaDeEntrega

Public Class ucClienteTercero_xtF01
#Region " Definición Eventos "
    Public Event ErrorMessage(ByVal MsgError As String)
    Public Shadows Event InformationChanged()
    Public Shadows Event ExitFocusWithOutData()
    Public Shadows Event TextChanged()
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private oConsultaPlantaDeEntrega As New bePlantaDeEntrega
    Private bolTipoBusqueda As Boolean = True

#End Region
#Region " Propiedades "
    ''' <summary>
    ''' si la propiedad esta activa se mostrar el ruc como referencia
    ''' </summary>
    ''' <remarks></remarks>
    Private _MostrarRuc As Boolean = False

    <Browsable(False)> _
    Public Property MostrarRuc() As Boolean
        Get
            Return _MostrarRuc
        End Get
        Set(ByVal value As Boolean)
            _MostrarRuc = value
        End Set
    End Property


    Private _ItemActual As New bePlantaDeEntrega
    Public Property ItemActual() As bePlantaDeEntrega
        Get
            Return _ItemActual
        End Get
        Set(ByVal value As bePlantaDeEntrega)
            _ItemActual = value
        End Set
    End Property


    Private _InfPlantaDeEntrega As New bePlantaDeEntrega
    <Browsable(0)> _
    Public Property InfPlantaDeEntrega() As bePlantaDeEntrega
        Get
            Return _InfPlantaDeEntrega
        End Get
        Set(ByVal value As bePlantaDeEntrega)
            _InfPlantaDeEntrega = value
        End Set
    End Property


    Private _CodigoPlantaCliente As Double = 0

    <Browsable(0)> _
    Public Property CodigoPlantaCliente() As Double
        Get
            Return _CodigoPlantaCliente
        End Get
        Set(ByVal value As Double)
            _CodigoPlantaCliente = value
        End Set
    End Property

    Private _CodCliente As Double = 0

    <Browsable(0)> _
    Public Property CodCliente() As Double
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Double)
            _CodCliente = value
        End Set
    End Property


    Private _TipoRelacion As String = ""
    Public Property TipoRelacion() As String
        Get
            Return _TipoRelacion
        End Get
        Set(ByVal value As String)
            _TipoRelacion = value
        End Set
    End Property


    Private _Ruc As Decimal = 0D
    Public Property Ruc() As Decimal
        Get
            Return _Ruc
        End Get
        Set(ByVal value As Decimal)
            _Ruc = value
        End Set
    End Property


#End Region
#Region " Funciones y Procedimientos "
    Private Function fbBuscar() As Boolean
        '--------------
        ' Variables
        '--------------
        Dim olbePlantaDeEntregaTemp As New List(Of bePlantaDeEntrega)
        Dim blnCancelar As Boolean = False
        ' Limpiamos los filtros existentes
        oConsultaPlantaDeEntrega = New bePlantaDeEntrega
        ' Evaluamos la condición
        oConsultaPlantaDeEntrega.PNCCLNT = _CodCliente
        oConsultaPlantaDeEntrega.PSSTPORL = _TipoRelacion
        oConsultaPlantaDeEntrega.PNNRUCPR = _Ruc
        If bolTipoBusqueda Then
            If IsNumeric(txtClienteTercero.Text) Then
                If txtClienteTercero.Text.Length <= 6 Then oConsultaPlantaDeEntrega.PNCPRVCL = txtClienteTercero.Text
            Else
                If txtClienteTercero.Text.Length > 0 Then
                    ' Evaluamos la Asignación
                    oConsultaPlantaDeEntrega.PSTPRVCL = txtClienteTercero.Text.Trim
                End If
                ' Busca segun los ingresado sino muestra todo
            End If
        End If
        oConsultaPlantaDeEntrega.PageNumber = 1
        oConsultaPlantaDeEntrega.PageSize = 20
        Dim odaPlantaDeEntrega As New daPlantaDeEntrega
        olbePlantaDeEntregaTemp = odaPlantaDeEntrega.ListarClienteTercero(oConsultaPlantaDeEntrega)
        '--------------
        ' Proceso
        '--------------

        If olbePlantaDeEntregaTemp.Count = 0 Then
            RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
            Me.txtClienteTercero.Text = _InfPlantaDeEntrega.PSTPRVCL
            txtClienteTercero.SelectAll()
            blnCancelar = True
        Else
            If olbePlantaDeEntregaTemp.Count = 1 Then
                _ItemActual = olbePlantaDeEntregaTemp.Item(0)
                RaiseEvent InformationChanged()
            Else
                Dim bTemp As Boolean = False
                Dim fbusqueda As ucClienteTercero = New ucClienteTercero(olbePlantaDeEntregaTemp)
                fbusqueda.CodCliente = _CodCliente
                fbusqueda.TipoRelacion = _TipoRelacion


                If fbusqueda.ShowDialog() = DialogResult.OK Then
                    _ItemActual = fbusqueda.pSeleccion()
                    RaiseEvent InformationChanged()
                End If
            End If
            txtClienteTercero.Text = _ItemActual.PSTPRVCL
            RaiseEvent TextChanged()
        End If
        bolTipoBusqueda = True
        Return blnCancelar
    End Function

    Private Function pObtenerCliente() As Boolean
        Dim blnCancelar As Boolean = False
        Dim olbePlantaDeEntregaTemp As New List(Of bePlantaDeEntrega)
        Dim blnResultado As Boolean = False
        If _InfPlantaDeEntrega.PNCCLNT <> 0 Then

        End If

        ' Obtenemos el Cliente
        Dim odaPlantaDeEntrega As New daPlantaDeEntrega
        olbePlantaDeEntregaTemp = odaPlantaDeEntrega.ListarClienteTercero(_InfPlantaDeEntrega)
        '--------------
        ' Proceso
        '--------------
        If olbePlantaDeEntregaTemp.Count = 0 Then
            RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
            Me.txtClienteTercero.Text = _InfPlantaDeEntrega.PSTPRVCL
            txtClienteTercero.SelectAll()
            blnCancelar = True
        Else
            If olbePlantaDeEntregaTemp.Count = 1 Then
                _ItemActual = olbePlantaDeEntregaTemp.Item(0)
                RaiseEvent InformationChanged()
            Else
                Dim bTemp As Boolean = False
                Dim fbusqueda As ucClienteTercero = New ucClienteTercero(olbePlantaDeEntregaTemp)
                fbusqueda.CodCliente = _CodCliente
                fbusqueda.TipoRelacion = _TipoRelacion
                If fbusqueda.ShowDialog() = DialogResult.OK Then
                    _ItemActual = fbusqueda.pSeleccion()
                    RaiseEvent InformationChanged()
                End If
            End If
            txtClienteTercero.Text = _ItemActual.PSTPRVCL
            RaiseEvent TextChanged()
        End If
        bolTipoBusqueda = True
        Return blnCancelar
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaPlantaDeEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlantaDeEntrega.Click
        '  txtClienteTercero.Focus()
        bolTipoBusqueda = False
        Call fbBuscar()
    End Sub

    Private Sub ucPlantaDeEntrega_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtClienteTercero.Width = Width
        Me.Height = txtClienteTercero.Height
    End Sub

    Private Sub ucPlantaDeEntrega_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtClienteTercero.Width = Width
        Me.Height = txtClienteTercero.Height
    End Sub

    Private Sub txtPlantaDeEntrega_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClienteTercero.GotFocus
        txtClienteTercero.Text = ItemActual.PSTPRVCL.ToUpper.Trim
        txtClienteTercero.SelectAll()
    End Sub

    Private Sub txtPlantaDeEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClienteTercero.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                txtClienteTercero.Text = "" ' oInf_PlantaDeEntrega.pTCMPCL_DescripcionPlantaDeEntrega
                txtClienteTercero.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtClienteTercero.Text = "" Then
                    ' oInf_PlantaDeEntrega.pClear()
                Else
                    If txtClienteTercero.Text.ToUpper.Trim <> "" Then
                        Call fbBuscar()
                    Else
                        txtClienteTercero.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtPlantaDeEntrega_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClienteTercero.Validated
        If _ItemActual.PNCPRVCL <> 0 Then
            If _ItemActual.PNCPRVCL <> 0 Then
                If _MostrarRuc Then
                    txtClienteTercero.Text = _ItemActual.PNNRUCPR & " - " & _ItemActual.PSTPRVCL
                Else
                    txtClienteTercero.Text = _ItemActual.PNCPRVCL & " - " & _ItemActual.PSTPRVCL
                End If

            Else
                txtClienteTercero.Text = ""
                RaiseEvent TextChanged()
                _ItemActual = New bePlantaDeEntrega
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtClienteTercero.Text = ""
            RaiseEvent TextChanged()
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtPlantaDeEntrega_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClienteTercero.Validating
        If txtClienteTercero.Text = "" Then
            _ItemActual = New bePlantaDeEntrega
        Else
            If IsNumeric(txtClienteTercero.Text) Then
                If txtClienteTercero.Text.Trim <> _ItemActual.PNCPRVCL Then e.Cancel = fbBuscar()
            Else
                If txtClienteTercero.Text.ToUpper.Trim <> _ItemActual.PSTPRVCL.ToUpper.Trim Then e.Cancel = fbBuscar()
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'oCliente = New cCliente
    End Sub

    Public Sub pCargar(ByVal obePlantaDeEntrega As bePlantaDeEntrega)
        _InfPlantaDeEntrega.PNCCLNT = obePlantaDeEntrega.PNCCLNT
        _InfPlantaDeEntrega.PNCPRVCL = obePlantaDeEntrega.PNCPRVCL
        _InfPlantaDeEntrega.PSTPRVCL = obePlantaDeEntrega.PSTPRVCL
        _InfPlantaDeEntrega.PageNumber = 1
        _InfPlantaDeEntrega.PageSize = 20
        _InfPlantaDeEntrega.TIPOCLIENTE = obePlantaDeEntrega.TIPOCLIENTE
        _InfPlantaDeEntrega.PSSTPORL = obePlantaDeEntrega.PSSTPORL
        _InfPlantaDeEntrega.PNNRUCPR = _InfPlantaDeEntrega.PNNRUCPR
        If _InfPlantaDeEntrega.PNCCLNT <> 0 Then Call pObtenerCliente()
    End Sub

    Public Sub pCargar2(ByVal obePlantaDeEntrega As bePlantaDeEntrega)
        _InfPlantaDeEntrega.PNCCLNT = obePlantaDeEntrega.PNCCLNT
        _InfPlantaDeEntrega.PNCPRVCL = obePlantaDeEntrega.PNCPRVCL
        _InfPlantaDeEntrega.PSTPRVCL = obePlantaDeEntrega.PSTPRVCL
        _InfPlantaDeEntrega.PageNumber = 1
        _InfPlantaDeEntrega.PageSize = 20
        _InfPlantaDeEntrega.TIPOCLIENTE = obePlantaDeEntrega.TIPOCLIENTE
        _InfPlantaDeEntrega.PSSTPORL = obePlantaDeEntrega.PSSTPORL
        _InfPlantaDeEntrega.PNNRUCPR = obePlantaDeEntrega.PNNRUCPR
        If _InfPlantaDeEntrega.PNCCLNT <> 0 Then Call pObtenerCliente()
    End Sub

    Public Sub pClear()
        _ItemActual = New bePlantaDeEntrega
        txtClienteTercero.Text = ""
    End Sub
#End Region

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


End Class