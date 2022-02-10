Imports System.Windows.Forms
Imports Ransa.TypeDef.PlantaDeEntrega
Imports Ransa.DAO.PlantaDeEntrega

Public Class ucPlantaDeEntrega_TxtF01
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


    Private _Lectura As Boolean
    Public Property Lectura() As Boolean
        Get
            Return _Lectura
        End Get
        Set(ByVal value As Boolean)
            _Lectura = value
        End Set
    End Property

    ''' <summary>
    ''' Tipo de PLanta de Entrega Propio o Tercero
    ''' </summary>
    ''' <remarks></remarks>
    Private _TipoPlantaDeEntrega As Boolean = True

    Public Property TipoPlantaDeEntrega() As Boolean
        Get
            Return _TipoPlantaDeEntrega
        End Get
        Set(ByVal value As Boolean)
            _TipoPlantaDeEntrega = value
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
    Public Property InfPlantaDeEntrega() As bePlantaDeEntrega
        Get
            Return _InfPlantaDeEntrega
        End Get
        Set(ByVal value As bePlantaDeEntrega)
            _InfPlantaDeEntrega = value
        End Set
    End Property


    Private _CodigoPlantaCliente As Double = 0

    Public Property CodigoPlantaCliente() As Double
        Get
            Return _CodigoPlantaCliente
        End Get
        Set(ByVal value As Double)
            _CodigoPlantaCliente = value
        End Set
    End Property

    Private _CodCliente As Double = 0

    Public Property CodCliente() As Double
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Double)
            _CodCliente = value
        End Set
    End Property

    Private _CodClienteTercero As Double = 0

    Public Property CodClienteTercero() As Double
        Get
            Return _CodClienteTercero
        End Get
        Set(ByVal value As Double)
            _CodClienteTercero = value
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
        oConsultaPlantaDeEntrega.TIPOCLIENTE = _TipoPlantaDeEntrega
        oConsultaPlantaDeEntrega.PNCCLNT = _CodCliente
        oConsultaPlantaDeEntrega.PNCPRVCL = _CodClienteTercero

        If bolTipoBusqueda Then
            If IsNumeric(txtPlantaDeEntrega.Text) Then
                If txtPlantaDeEntrega.Text.Length <= 6 Then oConsultaPlantaDeEntrega.PNCPLNCL = txtPlantaDeEntrega.Text
            Else
                If txtPlantaDeEntrega.Text.Length > 0 Then
                    ' Evaluamos la Asignación
                    oConsultaPlantaDeEntrega.PSTCMPPL = txtPlantaDeEntrega.Text.Trim
                End If
                ' Busca segun los ingresado sino muestra todo
            End If
        End If
        oConsultaPlantaDeEntrega.PageNumber = 1
        oConsultaPlantaDeEntrega.PageSize = 20
        Dim odaPlantaDeEntrega As New daPlantaDeEntrega
        olbePlantaDeEntregaTemp = odaPlantaDeEntrega.ListarPlantaDeEntrega(oConsultaPlantaDeEntrega)
        '--------------
        ' Proceso
        '--------------

        If olbePlantaDeEntregaTemp.Count = 0 Then
            RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
            Me.txtPlantaDeEntrega.Text = _InfPlantaDeEntrega.PSTCMPPL
            txtPlantaDeEntrega.SelectAll()
            blnCancelar = True
        Else
            If olbePlantaDeEntregaTemp.Count = 1 Then
                _ItemActual = olbePlantaDeEntregaTemp.Item(0)
                RaiseEvent InformationChanged()
            Else
                Dim bTemp As Boolean = False
                Dim fbusqueda As ucPlantaDeEntrega = New ucPlantaDeEntrega(olbePlantaDeEntregaTemp)
                fbusqueda.CodCliente = _CodCliente
                fbusqueda.CodClienteTercero = _CodClienteTercero
                fbusqueda.TipoPlantaDeEntrega = _TipoPlantaDeEntrega

                If fbusqueda.ShowDialog() = DialogResult.OK Then
                    _ItemActual = fbusqueda.pSeleccion()
                    RaiseEvent InformationChanged()
                End If
            End If
            txtPlantaDeEntrega.Text = _ItemActual.PSTDRCPL
            RaiseEvent TextChanged()
        End If
        bolTipoBusqueda = True
        Return blnCancelar
    End Function

    Private Function pObtenerCliente() As Boolean
        Dim blnResultado As Boolean = False
        Dim olbePlantaDeEntregaTemp As New List(Of bePlantaDeEntrega)

        If _InfPlantaDeEntrega.PNCCLNT <> 0 Then
            ' Obtenemos el Cliente
            Dim odaPlantaDeEntrega As New daPlantaDeEntrega
            Dim obePlantaDeEntrega As New bePlantaDeEntrega
            olbePlantaDeEntregaTemp = odaPlantaDeEntrega.ListarPlantaDeEntrega(_InfPlantaDeEntrega)
            '--------------
            ' Proceso
            '--------------

            If olbePlantaDeEntregaTemp.Count = 0 Then
                RaiseEvent ErrorMessage("No existe información que cumpla la condición proporcionada.")
                Me.txtPlantaDeEntrega.Text = _InfPlantaDeEntrega.PSTCMPPL
                txtPlantaDeEntrega.SelectAll()
                blnResultado = True
            Else
                If olbePlantaDeEntregaTemp.Count = 1 Then
                    _ItemActual = olbePlantaDeEntregaTemp.Item(0)
                    RaiseEvent InformationChanged()
                Else
                    Dim bTemp As Boolean = False
                    Dim fbusqueda As ucPlantaDeEntrega = New ucPlantaDeEntrega(olbePlantaDeEntregaTemp)
                    fbusqueda.CodCliente = _CodCliente
                    fbusqueda.CodClienteTercero = _CodClienteTercero
                    fbusqueda.TipoPlantaDeEntrega = _TipoPlantaDeEntrega

                    If fbusqueda.ShowDialog() = DialogResult.OK Then
                        _ItemActual = fbusqueda.pSeleccion()
                        RaiseEvent InformationChanged()
                    End If
                End If
                txtPlantaDeEntrega.Text = _ItemActual.PSTDRCPL
                RaiseEvent TextChanged()
            End If
            bolTipoBusqueda = True
            Return blnResultado
        End If
       

        '    If obePlantaDeEntrega.PNCPLNCL <> 0 Then
        '        ' Realizamos la visualización en el control TextBox
        '        If Me.Focused Then
        '            Me.txtPlantaDeEntrega.Text = obePlantaDeEntrega.PSTCMPPL
        '            txtPlantaDeEntrega.SelectAll()
        '            blnResultado = True
        '        Else
        '            If obePlantaDeEntrega.PNCPLNCL <> 0 Then
        '                _ItemActual = _InfPlantaDeEntrega
        '                txtPlantaDeEntrega.Text = obePlantaDeEntrega.PNCPLNCL & " - " & obePlantaDeEntrega.PSTDRCPL
        '                blnResultado = True
        '            Else
        '                txtPlantaDeEntrega.Text = ""
        '                RaiseEvent ErrorMessage("Cliente no existe.")
        '            End If
        '        End If
        '    Else
        '        _InfPlantaDeEntrega = New bePlantaDeEntrega
        '    End If
        'End If
        'Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Private Sub bsaPlantaDeEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPlantaDeEntrega.Click
        txtPlantaDeEntrega.Focus()
        bolTipoBusqueda = False
        Call fbBuscar()
    End Sub

    Private Sub ucPlantaDeEntrega_TxtF01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtPlantaDeEntrega.Width = Width
        Me.Height = txtPlantaDeEntrega.Height
    End Sub

    Private Sub ucPlantaDeEntrega_TxtF01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtPlantaDeEntrega.Width = Width
        Me.Height = txtPlantaDeEntrega.Height
    End Sub

    Private Sub txtPlantaDeEntrega_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlantaDeEntrega.GotFocus
        txtPlantaDeEntrega.Text = _ItemActual.PSTDRCPL.ToUpper.Trim
        txtPlantaDeEntrega.SelectAll()
    End Sub

    Private Sub txtPlantaDeEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlantaDeEntrega.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                txtPlantaDeEntrega.Text = "" ' oInf_PlantaDeEntrega.pTCMPCL_DescripcionPlantaDeEntrega
                txtPlantaDeEntrega.SelectAll()
            Case Keys.Enter
                ' Busca segun los ingresado sino muestra todo
                If txtPlantaDeEntrega.Text = "" Then
                    ' oInf_PlantaDeEntrega.pClear()
                Else
                    If txtPlantaDeEntrega.Text.ToUpper.Trim <> "" Then 'oInf_PlantaDeEntrega.pTCMPCL_DescripcionPlantaDeEntrega.ToUpper Then
                        Call fbBuscar()
                    Else
                        txtPlantaDeEntrega.SelectAll()
                    End If
                End If
            Case Keys.F4
                Call fbBuscar()
        End Select
    End Sub

    Private Sub txtPlantaDeEntrega_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlantaDeEntrega.Validated
        If _ItemActual.PNCPLNCL <> 0 Then
            If _ItemActual.PNCPLNCL <> 0 Then
                txtPlantaDeEntrega.Text = _ItemActual.PNCPLNCL & " - " & _ItemActual.PSTDRCPL
            Else
                txtPlantaDeEntrega.Text = ""
                RaiseEvent TextChanged()
                _ItemActual = New bePlantaDeEntrega
                RaiseEvent ExitFocusWithOutData()
            End If
        Else
            txtPlantaDeEntrega.Text = ""
            RaiseEvent TextChanged()
            RaiseEvent ExitFocusWithOutData()
        End If
    End Sub

    Private Sub txtPlantaDeEntrega_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPlantaDeEntrega.Validating
        If txtPlantaDeEntrega.Text = "" Then
            _ItemActual = New bePlantaDeEntrega
        Else
            If IsNumeric(txtPlantaDeEntrega.Text.Trim) Then
                If txtPlantaDeEntrega.Text.Trim <> _ItemActual.PNCPLNCL Then e.Cancel = fbBuscar()
            Else
                If txtPlantaDeEntrega.Text.ToUpper.Trim <> _ItemActual.PSTDRCPL.ToUpper.Trim Then e.Cancel = fbBuscar()
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
        _InfPlantaDeEntrega.TIPOCLIENTE = _TipoPlantaDeEntrega
        _InfPlantaDeEntrega.PNCCLNT = obePlantaDeEntrega.PNCCLNT
        _InfPlantaDeEntrega.PNCPRVCL = obePlantaDeEntrega.PNCPRVCL
        _InfPlantaDeEntrega.PNCPLNCL = obePlantaDeEntrega.PNCPLNCL
        _InfPlantaDeEntrega.PSTCMPPL = obePlantaDeEntrega.PSTCMPPL
        _InfPlantaDeEntrega.PageNumber = 1
        _InfPlantaDeEntrega.PageSize = 20
        TipoPlantaDeEntrega = _TipoPlantaDeEntrega
        If _InfPlantaDeEntrega.PNCCLNT <> 0 Then Call pObtenerCliente()
    End Sub

    'Public Sub pCargar(ByVal Cliente As Int64)
    '    oClientePK.pCCLNT_Cliente = Cliente
    '    oClientePK.pCCMPN_CodigoCompania = _CCMPN
    '    If Cliente <> 0 Then Call pObtenerCliente()
    'End Sub

    Public Sub pClear()
        _CodClienteTercero = 0
        _ItemActual = New bePlantaDeEntrega
        txtPlantaDeEntrega.Text = ""
    End Sub
#End Region

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

   
End Class