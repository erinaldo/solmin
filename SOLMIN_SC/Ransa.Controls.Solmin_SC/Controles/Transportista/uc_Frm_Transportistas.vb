Public Class uc_Frm_Transportistas
    Private oInfoTransportista As New Transportista_Info_BE()
    Public oFiltroTransportista As New Transportista_Info_BE()
    Private paginaInicial As Int32 = 0

    Private obeTransportista As New Transportista_BE
    Public oListInicialTransportista As New List(Of Transportista_BE)
    Public ReadOnly Property pSeleccion() As Transportista_Info_BE
        Get
            Return oInfoTransportista
        End Get
    End Property

    Private Sub uc_Frm_Transportistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvTransportista.AutoGenerateColumns = False
            dgvTransportista.DataSource = Nothing
            If (oListInicialTransportista.Count <> 0) Then
                dgvTransportista.DataSource = oListInicialTransportista
                If TryCast(dgvTransportista.DataSource, List(Of Transportista_BE)).Count > 0 Then
                    UcPaginacion.PageCount = TryCast(dgvTransportista.DataSource, List(Of Transportista_BE)).Item(0).PageCount
                End If
            Else
                pCargarInformacion()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub pCargarInformacion()
        Try
            dgvTransportista.DataSource = Nothing
            Dim oLisTransportista As New List(Of Transportista_BE)
            Dim oblTransportista As New Transportista_BLL
            Dim obeQueryTransportista As New Transportista_Info_BE
            With obeQueryTransportista
                If (txtCodigo.Text.Trim = "") Then
                    .PNCTRSPT = 0
                Else
                    .PNCTRSPT = Decimal.Parse(txtCodigo.Text.Trim)
                End If
                .PSNRUCTR = txtRUC.Text.Trim
                .PSTCMTRT = txtDescripcion.Text.Trim
                .PageSize = Me.UcPaginacion.PageSize
                .PageNumber = Me.UcPaginacion.PageNumber
                If (txtCodigo.Text.Trim <> "") Then
                    .PSBUSQUEDA = "C" 'BUSQUEDA POR CODIGO
                Else
                    .PSBUSQUEDA = ""
                End If

            End With
            oLisTransportista = oblTransportista.ListarTransportista(obeQueryTransportista)
            dgvTransportista.DataSource = oLisTransportista
            If TryCast(dgvTransportista.DataSource, List(Of Transportista_BE)).Count > 0 Then
                UcPaginacion.PageCount = TryCast(dgvTransportista.DataSource, List(Of Transportista_BE)).Item(0).PageCount
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

    Private Sub dgvTransportista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransportista.CellDoubleClick
        Try

            Dim index As Int32 = dgvTransportista.CurrentCellAddress.Y
            obeTransportista = dgvTransportista.Rows(index).DataBoundItem
            oInfoTransportista.PNCTRSPT = obeTransportista.PNCTRSPT
            oInfoTransportista.PSNRUCTR = obeTransportista.PSNRUCTR
            oInfoTransportista.PSTCMTRT = obeTransportista.PSTCMTRT
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UcPaginacion.PageNumber = 1
            Call pCargarInformacion()
        End If
    End Sub

   
    Private Sub ValidaEnteros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress, txtRUC.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13, 32
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

   
End Class
