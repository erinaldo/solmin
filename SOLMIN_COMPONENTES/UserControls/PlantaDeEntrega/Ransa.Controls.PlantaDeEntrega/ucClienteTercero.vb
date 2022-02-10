Imports Ransa.TypeDef.PlantaDeEntrega
Imports Ransa.DAO.PlantaDeEntrega
Imports System.Windows.Forms

Public Class ucClienteTercero
#Region " Definición Eventos "

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private oInfbePlantaDeEntrega As New bePlantaDeEntrega

    Private sCondicion01 As String = " "
    Private sCondicion02 As String = " "
    Private sCondicion03 As String = " "
#End Region
#Region " Propiedades "
    Public ReadOnly Property pSeleccion() As bePlantaDeEntrega
        Get
            Return oInfbePlantaDeEntrega
        End Get
    End Property

    Private _obePlantaDeEntrega As New bePlantaDeEntrega

    Public Property obePlantaDeEntrega() As bePlantaDeEntrega
        Get
            Return _obePlantaDeEntrega
        End Get
        Set(ByVal value As bePlantaDeEntrega)
            _obePlantaDeEntrega = value
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

    Private _TipoPlantaDeEntrega As Boolean = True

    Public Property TipoPlantaDeEntrega() As Boolean
        Get
            Return _TipoPlantaDeEntrega
        End Get
        Set(ByVal value As Boolean)
            _TipoPlantaDeEntrega = value
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


#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()

        ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
        Dim sSQL As String = ""
        Dim sTemp As String = ""
        ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
        ' Validamos de que exista información ingresada
        With _obePlantaDeEntrega
            .PNCCLNT = _CodCliente
            If IsNumeric(txtCodigo.Text.Trim) Then
                .PNCPRVCL = txtCodigo.Text.Trim
            Else
                .PNCPRVCL = 0
            End If
            If txtDescripcion.Text.Trim <> "" Then
                .PSTPRVCL = txtDescripcion.Text.Trim
            Else
                .PSTPRVCL = ""
            End If
            .PNNRUCPR = Val(txtRuc.Text.Trim)
            .PSSTPORL = _TipoRelacion
            .PageNumber = UcPaginacion1.PageNumber
            .PageSize = UcPaginacion1.PageSize
        End With
        sCondicion01 = txtCodigo.Text.ToUpper.Trim
        sCondicion02 = txtDescripcion.Text.ToUpper.Trim
        Dim odaPlantaDeEntrega As New daPlantaDeEntrega()
        Me.dtgPlantaDeEntrega.AutoGenerateColumns = False
        Me.dtgPlantaDeEntrega.DataSource = Nothing
        Me.dtgPlantaDeEntrega.DataSource = odaPlantaDeEntrega.ListarClienteTercero(_obePlantaDeEntrega)
        If CType(Me.dtgPlantaDeEntrega.DataSource, List(Of bePlantaDeEntrega)).Count > 0 Then
            UcPaginacion1.PageCount = CType(Me.dtgPlantaDeEntrega.DataSource, List(Of bePlantaDeEntrega)).Item(0).PageCount
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As bePlantaDeEntrega)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            _obePlantaDeEntrega.PNCCLNT = .PNCCLNT
            Call pCargarInformacion()
        End With
    End Sub
    Sub New(ByVal Filtro As List(Of bePlantaDeEntrega))
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.dtgPlantaDeEntrega.AutoGenerateColumns = False
        UcPaginacion1.PageCount = Filtro.Item(0).PageCount
        Me.dtgPlantaDeEntrega.DataSource = Filtro
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            UcPaginacion1.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.SelectAll()
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            UcPaginacion1.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub




#End Region
#Region " Métodos "

#End Region

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        pCargarInformacion()
    End Sub

    Private Sub dtgPlantaDeEntrega_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPlantaDeEntrega.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        oInfbePlantaDeEntrega = CType(Me.dtgPlantaDeEntrega.CurrentRow.DataBoundItem, bePlantaDeEntrega)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtRuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub
End Class
