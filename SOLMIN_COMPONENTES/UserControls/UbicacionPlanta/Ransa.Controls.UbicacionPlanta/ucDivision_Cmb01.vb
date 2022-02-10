'Imports Ransa.TypeDef.UbicacionPlanta.Division
'Imports Ransa.Negocio.UbicacionPlanta.Division

Public Class ucDivision_Cmb01

#Region "Propiedades"
    Private _Usuario As String = ""
    ''' <summary>
    ''' Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
  End Property

    Private _CodCompania As String = ""

    ''' <summary>
    ''' Codigo de Compania
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Compania() As String
        Get
            Return _CodCompania
        End Get
        Set(ByVal value As String)
            _CodCompania = value
        End Set
    End Property

    Private _Division As String
    ''' <summary>
    ''' Código de división
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property

  Private _DivisionDefault As String
    ''' <summary>
    ''' Código de división
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DivisionDefault() As String
        Get
            Return _DivisionDefault
        End Get
        Set(ByVal value As String)
            _DivisionDefault = value
        End Set
    End Property

  Private _DivisionDescripcion As String
    ''' <summary>
    ''' Descripcion  de división
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DivisionDescripcion() As String
        Get
            Return _DivisionDescripcion
        End Get
        Set(ByVal value As String)
            _DivisionDescripcion = value
        End Set
    End Property
    Private bIsRequired As Boolean = False
    Public Property pRequerido() As Boolean
        Get
            Return bIsRequired
        End Get
        Set(ByVal value As Boolean)
            bIsRequired = value
            If Not bIsRequired Then
                cmbDivision.StateCommon.Back.Color1 = Nothing
            Else
                cmbDivision.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0") 'Color.PaleGoldenrod
            End If
        End Set
    End Property

  Private _CDVSN_ANTERIOR As String
  Public Property CDVSN_ANTERIOR() As String
    Get
      Return _CDVSN_ANTERIOR
    End Get
    Set(ByVal value As String)
      _CDVSN_ANTERIOR = value
    End Set
    End Property

    Private _ItemTodos As Boolean = False
    Public Property ItemTodos() As Boolean
        Get
            Return _ItemTodos
        End Get
        Set(ByVal value As Boolean)
            _ItemTodos = value
        End Set
    End Property
    Public Property pHabilitado() As Boolean
        Get
            Return cmbDivision.ComboBox.Enabled
        End Get
        Set(ByVal value As Boolean)
            cmbDivision.ComboBox.Enabled = value
        End Set
    End Property



    Private _obeDivision As Division.beDivision
    Public Property obeDivision() As Division.beDivision
        Get
            Return _obeDivision
        End Get
        Set(ByVal value As Division.beDivision)
            _obeDivision = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Usuario = ""
        _CodCompania = ""
    End Sub

    Private Sub ucDivision_Cmb01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pActualizar()
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        Dim obeDivision As New Division.beDivision
        If cmbDivision.SelectedItem Is Nothing Then Exit Sub
        obeDivision = CType(cmbDivision.SelectedItem, Division.beDivision)
        _Division = obeDivision.CDVSN_CodigoDivision
        _DivisionDescripcion = obeDivision.TCMPDV_DescripcionDivision
        RaiseEvent Seleccionar(obeDivision)
    End Sub


    Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
        If cmbDivision.SelectedItem Is Nothing Then
            obeDivision = Nothing
            Exit Sub
        End If
        obeDivision = CType(cmbDivision.SelectedItem, Division.beDivision)
        If obeDivision IsNot Nothing Then
            obeDivision.CDVSN_CodigoDivision = obeDivision.CDVSN_CodigoDivision.Trim
            obeDivision.TCMPDV_DescripcionDivision = obeDivision.TCMPDV_DescripcionDivision.Trim
        End If
        _Division = obeDivision.CDVSN_CodigoDivision
        _DivisionDescripcion = obeDivision.TCMPDV_DescripcionDivision
        RaiseEvent SelectionChangeCommitted(obeDivision)
    End Sub


#End Region

#Region "Metodos"

    ''' <summary>
    ''' Cargar División por Usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDivision()
        'Dim obrDivision As New brDivision
        'obrDivision.Lista_Division_X_Usuario(_Usuario)

        'If _CodCompania.Trim.Equals("") Then
        '    Me.cmbDivision.DataSource = obrDivision.Lista
        '    Me.cmbDivision.ValueMember = "CCMPN_CodigoCompania"
        '    Me.cmbDivision.DisplayMember = "TCMPDV_DescripcionDivision"
        'Else
        '    Me.cmbDivision.DataSource = obrDivision.Lista_Division_X_Usuario_X_Planta(_CodCompania)
        '    Me.cmbDivision.ValueMember = "CCMPN_CodigoCompania"
        '    Me.cmbDivision.DisplayMember = "TCMPDV_DescripcionDivision"
        'End If
        Dim oListDivision As New List(Of Division.beDivision)
        Dim oListDivisionItemTodos As New List(Of Division.beDivision)
        Dim obrDivision As New Division.brDivision
        obrDivision.Lista_Division_X_Usuario(_Usuario)
        If _CodCompania.Trim.Equals("") Then
            oListDivision = obrDivision.Lista        
        Else
            oListDivision = obrDivision.Lista_Division_X_Usuario_X_Planta(_CodCompania)
        End If
        ListDivisionDefecto(oListDivision)

        If ItemTodos Then
            Dim obeDivision As New Division.beDivision
            obeDivision.CDVSN_CodigoDivision = "-1"
            obeDivision.CCMPN_CodigoCompania = "-1"
            obeDivision.TCMPDV_DescripcionDivision = "TODOS"
            oListDivisionItemTodos.Add(obeDivision)

            For Each obe As Division.beDivision In oListDivision
                oListDivisionItemTodos.Add(obe)
            Next

            oListDivision = oListDivisionItemTodos
        End If

        Me.cmbDivision.DataSource = oListDivision
        Me.cmbDivision.ValueMember = "CCMPN_CodigoCompania"
        Me.cmbDivision.DisplayMember = "TCMPDV_DescripcionDivision"

        If ItemTodos Then cmbDivision.SelectedIndex = 0
    End Sub

    Private Sub ListDivisionDefecto(ByVal oList As List(Of Division.beDivision))

        Try
            Dim encontrado As Boolean = False
            If (_DivisionDefault <> "") Then
                For Each item As Division.beDivision In oList
                    If (item.CDVSN_CodigoDivision.Trim.ToUpper = DivisionDefault.Trim.ToUpper) Then
                        item.Orden = 0
                        encontrado = True
                    Else
                        item.Orden = 1
                    End If
                Next
                If (encontrado = True) Then
                    oList.Sort(AddressOf Sort)
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Function Sort(ByVal obe1 As Division.beDivision, ByVal obe2 As Division.beDivision) As Int32
        Return obe1.Orden.CompareTo(obe2.Orden)
    End Function


    ''' <summary>
    ''' Carga lista de División por Usuario y Compañia
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pActualizar()
        If Not _Usuario.Trim.Equals("") Then
            CargarDivision()
        End If
    End Sub

#End Region

#Region "Eventos Creados"
    ''' <summary>
    ''' Evento que se ejecuta al cambiar el Item seleccionado
    ''' </summary>
    ''' <param name="obeDivision"></param>
    ''' <remarks></remarks>
    Public Event Seleccionar(ByVal obeDivision As Division.beDivision)
    Public Event SelectionChangeCommitted(ByVal obeDivision As Division.beDivision)
#End Region

End Class
