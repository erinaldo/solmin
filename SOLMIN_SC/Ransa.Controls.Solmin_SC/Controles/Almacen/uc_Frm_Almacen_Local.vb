Public Class uc_Frm_Almacen_Local
    Private oInfoAlmacen As New TipoDato_Info_BE()
    Public oFiltroAlmacen As New TipoDato_Info_BE()
    Private paginaInicial As Int32 = 0

    Private obeAlmacen As New TipoDato_BE
    Public oListInicialAlmacen As New List(Of TipoDato_BE)

    Private _CCLNT As Decimal = 0
    Public WriteOnly Property CCLNT() As Decimal
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public ReadOnly Property pSeleccion() As TipoDato_Info_BE
        Get
            Return oInfoAlmacen
        End Get
    End Property

    Private Sub uc_Frm_Almacen_Local_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvAlmacen.AutoGenerateColumns = False
            dgvAlmacen.DataSource = Nothing
            If (oListInicialAlmacen.Count <> 0) Then
                dgvAlmacen.DataSource = oListInicialAlmacen
                If TryCast(dgvAlmacen.DataSource, List(Of TipoDato_BE)).Count > 0 Then
                    UcPaginacion.PageCount = TryCast(dgvAlmacen.DataSource, List(Of TipoDato_BE)).Item(0).PageCount
                End If
            Else
                pCargarInformacion()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub pCargarInformacion()
        Try
            dgvAlmacen.DataSource = Nothing
            Dim oLisAlmacen As New List(Of TipoDato_BE)
            Dim oblAlmacen As New TipoDato_BLL
            Dim obeQueryAlmacen As New TipoDato_Info_BE
            With obeQueryAlmacen
                .PNCCLNT = Me._CCLNT
                .PSTDSCRG = txtDescripcion.Text.Trim
                .PageSize = Me.UcPaginacion.PageSize
                .PageNumber = Me.UcPaginacion.PageNumber
                .PSBUSQUEDA = ""
            End With
            oLisAlmacen = oblAlmacen.ListarAlmacenLocaL(obeQueryAlmacen)
            dgvAlmacen.DataSource = oLisAlmacen
            If TryCast(dgvAlmacen.DataSource, List(Of TipoDato_BE)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgvAlmacen.DataSource, List(Of TipoDato_BE)).Item(0).PageCount
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            pCargarInformacion()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvAlmacen_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlmacen.CellDoubleClick
        Try

            Dim index As Int32 = dgvAlmacen.CurrentCellAddress.Y
            obeAlmacen = dgvAlmacen.Rows(index).DataBoundItem
            oInfoAlmacen.PSTDSCRG = obeAlmacen.PSTDSCRG
            oInfoAlmacen.PNNTPODT = obeAlmacen.PNNTPODT
            oInfoAlmacen.PNNCODRG = obeAlmacen.PNNCODRG
            oInfoAlmacen.PNCCLNT = obeAlmacen.PNCCLNT
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

End Class
