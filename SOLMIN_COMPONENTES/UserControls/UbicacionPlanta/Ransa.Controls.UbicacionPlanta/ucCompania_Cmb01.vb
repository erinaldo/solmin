

'Imports Ransa.Negocio.UbicacionPlanta.Compania
'Imports Ransa.TypeDef.UbicacionPlanta.Compania

Public Class ucCompania_Cmb01


#Region "Atributos"
#End Region

#Region "Propiedades"

    Private _Usuario As String
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

    Private _CCMPN_CodigoCompania As String
    ''' <summary>
    ''' Código de Compañia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CCMPN_CodigoCompania() As String
        Get
            Return _CCMPN_CodigoCompania
        End Get
        Set(ByVal value As String)
            _CCMPN_CodigoCompania = value
        End Set
    End Property


    Private _CCMPN_CompaniaDefault As String
    Public Property CCMPN_CompaniaDefault() As String
        Get
            Return _CCMPN_CompaniaDefault
        End Get
        Set(ByVal value As String)
            _CCMPN_CompaniaDefault = value
        End Set
    End Property


    Private _CCMPN_ANTERIOR As String
    Public Property CCMPN_ANTERIOR() As String
        Get
            Return _CCMPN_ANTERIOR
        End Get
        Set(ByVal value As String)
            _CCMPN_ANTERIOR = value
        End Set
    End Property

    Private _CCMPN_DESCRIPCION As String
    Public Property CCMPN_Descripcion() As String
        Get
            Return _CCMPN_DESCRIPCION
        End Get
        Set(ByVal value As String)
            _CCMPN_DESCRIPCION = value
        End Set
    End Property

    Private _Habilitar As Boolean = True
    Public Property Habilitar() As Boolean
        Get
            Return cmbCompania.ComboBox.Enabled
        End Get
        Set(ByVal value As Boolean)
            cmbCompania.ComboBox.Enabled = value
        End Set
    End Property


    Public Sub HabilitarCompaniaActual(ByVal CodCompania As String)
        'Dim oListCompania As New List(Of beCompania)
        Dim oListCompania As New List(Of Compania.beCompania)
        oListCompania = cmbCompania.DataSource
        Dim encontrado As Boolean = False
        For Each oCompania As Compania.beCompania In oListCompania
            'For Each oCompania As beCompania In oListCompania
            If (oCompania.CCMPN_CodigoCompania.Trim.ToUpper = CodCompania.ToUpper) Then
                cmbCompania.SelectedValue = CodCompania
                cmbCompania.ComboBox.Enabled = False
                encontrado = True
                Exit For
            End If
        Next
        If encontrado = False Then
            cmbCompania.SelectedIndex = 0
        End If
        cmbCompania_SelectionChangeCommitted(cmbCompania, Nothing)
    End Sub

    Private _oBeCompania As New Compania.beCompania
    'Private _oBeCompania As New beCompania
    'Public Property oBeCompania() As beCompania
    '    Get
    '        Return _oBeCompania
    '    End Get
    '    Set(ByVal value As beCompania)
    '        _oBeCompania = value
    '    End Set
    'End Property
    Public Property oBeCompania() As Compania.beCompania
        Get
            Return _oBeCompania
        End Get
        Set(ByVal value As Compania.beCompania)
            _oBeCompania = value
        End Set
    End Property

#End Region

#Region "Evento"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Usuario = ""
    End Sub

    Private Sub ucCompania_Cmb01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pActualizar()
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        'Dim oBeCompania As New beCompania
        Dim oBeCompania As New Compania.beCompania
        If cmbCompania.SelectedItem Is Nothing Then Exit Sub
        'oBeCompania = CType(cmbCompania.SelectedItem, beCompania)
        oBeCompania = CType(cmbCompania.SelectedItem, Compania.beCompania)
        _CCMPN_CodigoCompania = oBeCompania.CCMPN_CodigoCompania
        _CCMPN_DESCRIPCION = oBeCompania.TCMPCM_DescripcionCompania
        RaiseEvent Seleccionar(oBeCompania)
    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectionChangeCommitted
        If cmbCompania.SelectedItem Is Nothing Then
            _oBeCompania = Nothing
            Exit Sub
        End If
        'oBeCompania = CType(cmbCompania.SelectedItem, beCompania)
        oBeCompania = CType(cmbCompania.SelectedItem, Compania.beCompania)
        If oBeCompania IsNot Nothing Then
            oBeCompania.CCMPN_CodigoCompania = oBeCompania.CCMPN_CodigoCompania.Trim
            oBeCompania.TCMPCM_DescripcionCompania = oBeCompania.TCMPCM_DescripcionCompania.Trim
        End If
        _CCMPN_CodigoCompania = oBeCompania.CCMPN_CodigoCompania
        _CCMPN_DESCRIPCION = oBeCompania.TCMPCM_DescripcionCompania
        RaiseEvent SelectionChangeCommitted(oBeCompania)
    End Sub


#End Region

#Region "Metodo"

    Private Sub CargarCompania()

        cmbCompania.DataSource = ObtenerListCompania()
        cmbCompania.ValueMember = "CCMPN_CodigoCompania"
        cmbCompania.DisplayMember = "TCMPCM_DescripcionCompania"

    End Sub

    'Private Function ObtenerListCompania() As List(Of beCompania)
    '    Dim oListCompania As New List(Of beCompania)
    '    Try
    '        Dim encontrado As Boolean = False
    '        Dim obrCompania As New brCompania

    '        oListCompania = obrCompania.Lista_Compania_X_Usuario(_Usuario)
    '        If (CCMPN_CompaniaDefault <> "") Then
    '            For Each oCompania As beCompania In oListCompania
    '                If (oCompania.CCMPN_CodigoCompania.Trim.ToUpper = CCMPN_CompaniaDefault.Trim.ToUpper) Then
    '                    oCompania.Orden = 0
    '                    encontrado = True
    '                Else
    '                    oCompania.Orden = 1
    '                End If
    '            Next
    '            If (encontrado = True) Then
    '                oListCompania.Sort(AddressOf SortCompania)
    '            End If
    '        End If

    '    Catch ex As Exception
    '    End Try

    '    Return oListCompania
    'End Function

    Private Function ObtenerListCompania() As List(Of Compania.beCompania)
        Dim oListCompania As New List(Of Compania.beCompania)
        Try
            Dim encontrado As Boolean = False
            Dim obrCompania As New Compania.brCompania

            oListCompania = obrCompania.Lista_Compania_X_Usuario(_Usuario)
            If (CCMPN_CompaniaDefault <> "") Then
                For Each oCompania As Compania.beCompania In oListCompania
                    If (oCompania.CCMPN_CodigoCompania.Trim.ToUpper = CCMPN_CompaniaDefault.Trim.ToUpper) Then
                        oCompania.Orden = 0
                        encontrado = True
                    Else
                        oCompania.Orden = 1
                    End If
                Next
                If (encontrado = True) Then
                    oListCompania.Sort(AddressOf SortCompania)
                End If
            End If

        Catch ex As Exception
        End Try

        Return oListCompania
    End Function

    Private Function SortCompania(ByVal obe1 As Compania.beCompania, ByVal obe2 As Compania.beCompania) As Int32
        Return obe1.Orden.CompareTo(obe2.Orden)
    End Function

    ''' <summary>
    '''Carga lista de compañia por Usuario
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pActualizar()
        If _Usuario <> "" Then
            CargarCompania()
        End If
    End Sub

#End Region

#Region "Eventos declarados"
    ''' <summary>
    ''' Evento que se ejecuta al cambiar el Item seleccionado
    ''' </summary>
    ''' <param name="obeCompania"></param>
    ''' <remarks></remarks>
    Public Event Seleccionar(ByVal obeCompania As Compania.beCompania)
    Public Event SelectionChangeCommitted(ByVal obeCompania As Compania.beCompania)

#End Region

End Class
