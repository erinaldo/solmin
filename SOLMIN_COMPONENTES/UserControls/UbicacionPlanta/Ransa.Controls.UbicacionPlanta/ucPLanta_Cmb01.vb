Imports Ransa.Negocio.UbicacionPlanta.Planta
Imports Ransa.TypeDef.UbicacionPlanta.Planta

Public Class ucPLanta_Cmb01

#Region "Propiedades"

  Private _CodigoCompania As String

  Public Property CodigoCompania() As String
    Get
      Return _CodigoCompania
    End Get
    Set(ByVal value As String)
      _CodigoCompania = value
    End Set
  End Property

  Private _CodigoDivision As String
  Public Property CodigoDivision() As String
    Get
      Return _CodigoDivision
    End Get
    Set(ByVal value As String)
      _CodigoDivision = value
    End Set
  End Property

  Private _Usuario As String
  Public Property Usuario() As String
    Get
      Return _Usuario
    End Get
    Set(ByVal value As String)
      _Usuario = value
    End Set
  End Property

  Private _Planta As Double
  Public Property Planta() As Double
    Get
      Return _Planta
    End Get
    Set(ByVal value As Double)
      _Planta = value
    End Set
  End Property


    Private _DescripcionPlanta As String = ""
    Public Property DescripcionPlanta() As String
        Get
            Return _DescripcionPlanta
        End Get
        Set(ByVal value As String)
            _DescripcionPlanta = value
        End Set
    End Property

  Private _PlantaDefault As Double = -1
  Public Property PlantaDefault() As Double
    Get
      Return _PlantaDefault
    End Get
    Set(ByVal value As Double)
      _PlantaDefault = value
    End Set
  End Property

  Private _CPLNDV_ANTERIOR As String
  Public Property CPLNDV_ANTERIOR() As String
    Get
      Return _CPLNDV_ANTERIOR
    End Get
    Set(ByVal value As String)
      _CPLNDV_ANTERIOR = value
    End Set
  End Property

    Private _ItemTodos As Boolean= False
    Public Property ItemTodos() As Boolean
        Get
            Return _ItemTodos
        End Get
        Set(ByVal value As Boolean)
            _ItemTodos = value
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
                cmbPlanta.StateCommon.Back.Color1 = Nothing
            Else
                cmbPlanta.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#FFFFC0") 'Color.PaleGoldenrod
            End If
        End Set
    End Property

    Public Property pHabilitado() As Boolean
        Get
            Return cmbPlanta.ComboBox.Enabled
        End Get
        Set(ByVal value As Boolean)
            cmbPlanta.ComboBox.Enabled = value
        End Set
    End Property

    Private _obePlanta As New Planta.bePlanta
    Public Property obePlanta() As Planta.bePlanta
        Get
            Return _obePlanta
        End Get
        Set(ByVal value As Planta.bePlanta)
            _obePlanta = value
        End Set
    End Property

    Private _CodSedeSAP As String = ""
    Public Property CodSedeSAP() As String
        Get
            Return _CodSedeSAP
        End Get
        Set(ByVal value As String)
            _CodSedeSAP = value
        End Set
    End Property

#End Region

#Region "Eventos"

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    _CodigoCompania = ""
    _CodigoDivision = ""
    _Usuario = ""
        _Planta = 0
        _DescripcionPlanta = ""
        _CodSedeSAP = ""

  End Sub

  Private Sub ucPLanta_Cmb01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    pActualizar()
  End Sub

  Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        Dim obePlanta As New Planta.bePlanta
    If cmbPlanta.SelectedItem Is Nothing Then Exit Sub
        obePlanta = CType(cmbPlanta.SelectedItem, Planta.bePlanta)
        _Planta = obePlanta.CPLNDV_CodigoPlanta
        _DescripcionPlanta = obePlanta.TPLNTA_DescripcionPlanta
        '<[AHM]>
        _CodSedeSAP = obePlanta.CDSPSP_CodSedeSAP
        '</[AHM]>
    RaiseEvent Seleccionar(obePlanta)
    End Sub


    Private Sub cmbPlanta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectionChangeCommitted
        If cmbPlanta.SelectedItem Is Nothing Then
            obePlanta = Nothing
            Exit Sub
        End If
        obePlanta = CType(cmbPlanta.SelectedItem, Planta.bePlanta)
        If obePlanta IsNot Nothing Then
            obePlanta.TPLNTA_DescripcionPlanta = obePlanta.TPLNTA_DescripcionPlanta.Trim
        End If
        _Planta = obePlanta.CPLNDV_CodigoPlanta
        _DescripcionPlanta = obePlanta.TPLNTA_DescripcionPlanta
        '<[AHM]>
        _CodSedeSAP = obePlanta.CDSPSP_CodSedeSAP
        '</[AHM]>
        RaiseEvent SelectionChangeCommitted(obePlanta)
    End Sub

    'Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
    '    obeDivision.CDVSN_CodigoDivision = ""
    '    obeDivision.TCMPDV_DescripcionDivision = ""
    '    If cmbDivision.SelectedItem Is Nothing Then
    '        obeDivision = Nothing
    '        Exit Sub
    '    End If
    '    obeDivision = CType(cmbDivision.SelectedItem, beDivision)
    '    If obeDivision IsNot Nothing Then
    '        obeDivision.CDVSN_CodigoDivision = obeDivision.CDVSN_CodigoDivision.Trim
    '        obeDivision.TCMPDV_DescripcionDivision = obeDivision.TCMPDV_DescripcionDivision.Trim
    '    End If
    '    _Division = obeDivision.CDVSN_CodigoDivision
    '    _DivisionDescripcion = obeDivision.TCMPDV_DescripcionDivision
    '    RaiseEvent SelectionChangeCommitted(obeDivision)
    'End Sub



#End Region

#Region "Metodos"

  Private Sub Cargar_Planta()
    'Dim obrPlanta As New brPlanta
    'Dim olbePlanta As New List(Of bePlanta)
    'Try
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    obrPlanta.Crea_Lista(_Usuario)
    '    olbePlanta = obrPlanta.Lista_Planta_X_Usuario(_CodigoCompania, _CodigoDivision)
    '    cmbPlanta.DataSource = olbePlanta
    '    cmbPlanta.ValueMember = "CPLNDV_CodigoPlanta"
    '    cmbPlanta.DisplayMember = "TPLNTA_DescripcionPlanta"
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'Catch ex As Exception
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Try

        Dim obrPlanta As New Planta.brPlanta
        Dim olbePlanta As New List(Of Planta.bePlanta)
        Dim olbePlantaItemTodos As New List(Of Planta.bePlanta)


    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            If _CodigoDivision.ToString.Equals("") Then
                obrPlanta.Crea_Lista_All(_Usuario)
                olbePlanta = obrPlanta.Lista_Planta_X_Usuario_All(_CodigoCompania)
            Else
                obrPlanta.Crea_Lista(_Usuario)
                olbePlanta = obrPlanta.Lista_Planta_X_Usuario(_CodigoCompania, _CodigoDivision)
            End If
            ListPlantaDefecto(olbePlanta)
            If ItemTodos Then
                Dim obePlantaItem As New Planta.bePlanta
                obePlantaItem.CPLNDV_CodigoPlanta = -1
                obePlantaItem.TPLNTA_DescripcionPlanta = "TODOS"
                olbePlantaItemTodos.Add(obePlantaItem)

                If Not _CodigoDivision = "-1" Then
                    For Each obe As Planta.bePlanta In olbePlanta
                        olbePlantaItemTodos.Add(obe)
                    Next
                End If


                olbePlanta = olbePlantaItemTodos
            End If


            cmbPlanta.DataSource = olbePlanta
            cmbPlanta.ValueMember = "CPLNDV_CodigoPlanta"
            cmbPlanta.DisplayMember = "TPLNTA_DescripcionPlanta"

            If ItemTodos Then cmbPlanta.SelectedIndex = 0

            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try


  End Sub

    Private Sub ListPlantaDefecto(ByVal oListPlanta As List(Of Planta.bePlanta))
        Try
            Dim encontrado As Boolean = False
            Dim obrPlanta As New Planta.brPlanta

            If (PlantaDefault <> -1) Then
                For Each item As Planta.bePlanta In oListPlanta
                    If (item.CPLNDV_CodigoPlanta = PlantaDefault) Then
                        item.Orden = 0
                        encontrado = True
                    Else
                        item.Orden = 1
                    End If
                Next
                If (encontrado = True) Then
                    oListPlanta.Sort(AddressOf SortCompania)
                End If
            End If

        Catch ex As Exception
        End Try


    End Sub

    Private Function SortCompania(ByVal obe1 As Planta.bePlanta, ByVal obe2 As Planta.bePlanta) As Int32
        Return obe1.Orden.CompareTo(obe2.Orden)
    End Function



  ''' <summary>
  ''' Carga Lista de Planta por Usuario, compañia y división  
  ''' </summary>
  ''' <remarks></remarks>
  Public Sub pActualizar()
        If Not _Usuario.Trim.Equals("") And Not _CodigoCompania.Trim.Equals("") Then
            Cargar_Planta()
        End If
  End Sub

#End Region

#Region "Eventos delclarados"

  ''' <summary>
  '''Evento que se ejecuta al cambiar el Item seleccionado
  ''' </summary>
  ''' <param name="obePlanta"></param>
  ''' <remarks></remarks>
    Public Event Seleccionar(ByVal obePlanta As Planta.bePlanta)
    Public Event SelectionChangeCommitted(ByVal obePlanta As Planta.bePlanta)
#End Region

End Class
