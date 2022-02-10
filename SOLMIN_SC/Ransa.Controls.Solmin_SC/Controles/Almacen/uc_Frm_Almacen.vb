Public Class uc_Frm_Almacen
    Private oInfoAlmacen As New Almacen_Info_BE()
    Public oFiltroAlmacen As New Almacen_Info_BE()
    Private paginaInicial As Int32 = 0

    Private obeAlmacen As New Almacen_BE
    Public oListInicialAlmacen As New List(Of Almacen_BE)
    Public ReadOnly Property pSeleccion() As Almacen_Info_BE
        Get
            Return oInfoAlmacen
        End Get
    End Property

    Private Sub uc_Frm_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvAlmacen.AutoGenerateColumns = False
            dgvAlmacen.DataSource = Nothing
            If (oListInicialAlmacen.Count <> 0) Then
                dgvAlmacen.DataSource = oListInicialAlmacen
                If TryCast(dgvAlmacen.DataSource, List(Of Almacen_BE)).Count > 0 Then
                    UcPaginacion.PageCount = TryCast(dgvAlmacen.DataSource, List(Of Almacen_BE)).Item(0).PageCount
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
            Dim oLisAlmacen As New List(Of Almacen_BE)
            Dim oblAlmacen As New Almacen_BLL
            Dim obeQueryAlmacen As New Almacen_Info_BE
            With obeQueryAlmacen
                .PSTCMPAL = txtDescripcion.Text.Trim
                .PageSize = Me.UcPaginacion.PageSize
                .PageNumber = Me.UcPaginacion.PageNumber
                .PSBUSQUEDA = ""
            End With
            oLisAlmacen = oblAlmacen.ListarAlmacen(obeQueryAlmacen)
            dgvAlmacen.DataSource = oLisAlmacen
            If TryCast(dgvAlmacen.DataSource, List(Of Almacen_BE)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgvAlmacen.DataSource, List(Of Almacen_BE)).Item(0).PageCount
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
            oInfoAlmacen.PSCTPALM = obeAlmacen.PSCTPALM
            oInfoAlmacen.PSCALMC = obeAlmacen.PSCALMC
            oInfoAlmacen.PSTCMPAL = obeAlmacen.PSTCMPAL
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
