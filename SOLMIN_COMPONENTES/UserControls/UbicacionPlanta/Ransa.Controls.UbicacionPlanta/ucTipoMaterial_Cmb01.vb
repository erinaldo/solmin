Imports Ransa.Negocio.UbicacionPlanta.TipoMaterial
Imports Ransa.TypeDef.UbicacionPlanta.TipoMaterial

Public Class ucTipoMaterial_Cmb01

    Private _CCMPRN_CodigoTipoMaterial As String
    Public Property CCMPRN_CodigoTipoMaterial() As String
        Get
            Return _CCMPRN_CodigoTipoMaterial
        End Get
        Set(ByVal value As String)
            _CCMPRN_CodigoTipoMaterial = value
        End Set
    End Property

    Private _CCMPRN_DESCRIPCION As String
    Public Property CCMPRN_Descripcion() As String
        Get
            Return _CCMPRN_DESCRIPCION
        End Get
        Set(ByVal value As String)
            _CCMPRN_DESCRIPCION = value
        End Set
    End Property

    Private _oBeTipoMaterial As New TipoMaterial.beTipoMaterial
    Public Property oBeTipoMaterial() As TipoMaterial.beTipoMaterial
        Get
            Return _oBeTipoMaterial
        End Get
        Set(ByVal value As TipoMaterial.beTipoMaterial)
            _oBeTipoMaterial = value
        End Set
    End Property

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub

    Private Sub CargarTipoMaterial()

        cmbTipoMaterial.DataSource = ObtenerListTipoMaterial()
        cmbTipoMaterial.ValueMember = "CCMPRN_CodigoTipoMaterial"
        cmbTipoMaterial.DisplayMember = "TDSDES_DescripcionTipoMaterial"

    End Sub

    Private Function ObtenerListTipoMaterial() As List(Of TipoMaterial.beTipoMaterial)
        Dim oLisTipoMaterial As New List(Of TipoMaterial.beTipoMaterial)
        Try
            Dim encontrado As Boolean = False
            Dim obrTipoMaterial As New TipoMaterial.brTipoMaterial

            oLisTipoMaterial = obrTipoMaterial.Lista_TipoMaterial("TIPMAT")
        Catch ex As Exception
        End Try

        Return oLisTipoMaterial
    End Function

    Public Sub pActualizar()
        CargarTipoMaterial()
    End Sub

    Private Sub ucTipoMaterial_Cmb01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pActualizar()
    End Sub

    Public Property Habilitar() As Boolean
        Get
            Return cmbTipoMaterial.ComboBox.Enabled
        End Get
        Set(ByVal value As Boolean)
            cmbTipoMaterial.ComboBox.Enabled = value
        End Set
    End Property

    Private Sub cmbTipoMaterial_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoMaterial.SelectedIndexChanged
        Dim oBeTipoMaterial As New TipoMaterial.beTipoMaterial
        If cmbTipoMaterial.SelectedItem Is Nothing Then Exit Sub
        oBeTipoMaterial = CType(cmbTipoMaterial.SelectedItem, TipoMaterial.beTipoMaterial)
        _CCMPRN_CodigoTipoMaterial = oBeTipoMaterial.CCMPRN_CodigoTipoMaterial
        _CCMPRN_DESCRIPCION = oBeTipoMaterial.TDSDES_DescripcionTipoMaterial
        RaiseEvent Seleccionar(oBeTipoMaterial)
    End Sub

    Private Sub cmbTipoMaterial_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoMaterial.SelectionChangeCommitted
        If cmbTipoMaterial.SelectedItem Is Nothing Then
            _oBeTipoMaterial = Nothing
            Exit Sub
        End If
        oBeTipoMaterial = CType(cmbTipoMaterial.SelectedItem, TipoMaterial.beTipoMaterial)
        If oBeTipoMaterial IsNot Nothing Then
            oBeTipoMaterial.CCMPRN_CodigoTipoMaterial = oBeTipoMaterial.CCMPRN_CodigoTipoMaterial.Trim
            oBeTipoMaterial.TDSDES_DescripcionTipoMaterial = oBeTipoMaterial.TDSDES_DescripcionTipoMaterial.Trim
        End If
        _CCMPRN_CodigoTipoMaterial = oBeTipoMaterial.CCMPRN_CodigoTipoMaterial
        _CCMPRN_DESCRIPCION = oBeTipoMaterial.TDSDES_DescripcionTipoMaterial
        RaiseEvent SelectionChangeCommitted(oBeTipoMaterial)
    End Sub

    Public Event Seleccionar(ByVal obeCompania As TipoMaterial.beTipoMaterial)
    Public Event SelectionChangeCommitted(ByVal obeCompania As TipoMaterial.beTipoMaterial)
End Class
