'Imports Ransa.Negocio.UbicacionPlanta.Condicion
'Imports Ransa.TypeDef.UbicacionPlanta.Condicion

Public Class ucCondicion_Cmb01

    Private _CCMPRN_CodigoCondicion As String
    Public Property CCMPRN_CodigoCondicion() As String
        Get
            Return _CCMPRN_CodigoCondicion
        End Get
        Set(ByVal value As String)
            _CCMPRN_CodigoCondicion = value
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

    Private _oBeCondicion As New Condicion.beCondicion
    Public Property oBeCondicion() As Condicion.beCondicion
        Get
            Return _oBeCondicion
        End Get
        Set(ByVal value As Condicion.beCondicion)
            _oBeCondicion = value
        End Set
    End Property

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub

    Private Sub CargarCondicion()

        cmbCondicion.DataSource = ObtenerListCondicion()
        cmbCondicion.ValueMember = "CCMPRN_CodigoCondicion"
        cmbCondicion.DisplayMember = "TDSDES_DescripcionCondicion"

    End Sub

    Private Function ObtenerListCondicion() As List(Of Condicion.beCondicion)
        Dim oLisCondicion As New List(Of Condicion.beCondicion)
        Try
            Dim encontrado As Boolean = False
            Dim obrCondicion As New Condicion.brCondicion

            oLisCondicion = obrCondicion.Lista_Condicion("SACDMP")
        Catch ex As Exception
        End Try

        Return oLisCondicion
    End Function

    Public Sub pActualizar()
        CargarCondicion()
    End Sub

    Private Sub ucTipoMaterial_Cmb01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pActualizar()
    End Sub

    Public Property Habilitar() As Boolean
        Get
            Return cmbCondicion.ComboBox.Enabled
        End Get
        Set(ByVal value As Boolean)
            cmbCondicion.ComboBox.Enabled = value
        End Set
    End Property

    Private Sub cmbCondicion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCondicion.SelectedIndexChanged
        Dim oBeCondicion As New Condicion.beCondicion
        If cmbCondicion.SelectedItem Is Nothing Then Exit Sub
        oBeCondicion = CType(cmbCondicion.SelectedItem, Condicion.beCondicion)
        _CCMPRN_CodigoCondicion = oBeCondicion.CCMPRN_CodigoCondicion
        _CCMPRN_DESCRIPCION = oBeCondicion.TDSDES_DescripcionCondicion
        RaiseEvent Seleccionar(oBeCondicion)
    End Sub

    Private Sub cmbCondicion_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCondicion.SelectionChangeCommitted
        If cmbCondicion.SelectedItem Is Nothing Then
            _oBeCondicion = Nothing
            Exit Sub
        End If
        oBeCondicion = CType(cmbCondicion.SelectedItem, Condicion.beCondicion)
        If oBeCondicion IsNot Nothing Then
            oBeCondicion.CCMPRN_CodigoCondicion = oBeCondicion.CCMPRN_CodigoCondicion.Trim
            oBeCondicion.TDSDES_DescripcionCondicion = oBeCondicion.TDSDES_DescripcionCondicion.Trim
        End If
        _CCMPRN_CodigoCondicion = oBeCondicion.CCMPRN_CodigoCondicion
        _CCMPRN_DESCRIPCION = oBeCondicion.TDSDES_DescripcionCondicion
        RaiseEvent SelectionChangeCommitted(oBeCondicion)
    End Sub

    Public Event Seleccionar(ByVal obeCompania As Condicion.beCondicion)
    Public Event SelectionChangeCommitted(ByVal obeCompania As Condicion.beCondicion)
End Class
