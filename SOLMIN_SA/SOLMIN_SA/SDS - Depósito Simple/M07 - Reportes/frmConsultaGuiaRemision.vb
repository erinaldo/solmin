Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes.Generador

Public Class frmConsultaGuiaRemision

    Private Function fnValidarInformacion() As String
        Dim Mensaje As String = String.Empty
        If txtCliente.pCodigo = 0 Then
            Mensaje &= "Falta Seleccionar un Cliente. "
        End If
        Return Mensaje
    End Function

    Private Sub fnSelGuiasRemision()
        Try
            dgGuiasRemision.AutoGenerateColumns = False
            dgGuiasRemision.DataSource = Nothing
            dgDetalleGR.DataSource = Nothing
            dgObservacionGR.DataSource = Nothing
            Dim obeFiltroGuia As New beGuiaRemision
            With obeFiltroGuia
                .PNCCLNT = txtCliente.pCodigo

                If dtpFechaInicio.Checked Then
                    .PNFECINI = HelpClass.CDate_a_Numero8Digitos(dtpFechaInicio.Value)
                End If
                If dtpFechaFin.Checked Then
                    .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(dtpFechaFin.Value)
                End If
                If IsNumeric(txtNroGuia.Text) Then
                    .PSNGUIRM = txtNroGuia.Text
                End If
                .PageCount = 10
                .PageNumber = 20
                .PageSize = 20
            End With
            dgGuiasRemision.DataSource = New DespachoSAT.brGuiasRemision().fnListGuiasRemision(obeFiltroGuia)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fnSelDetalleGR()
        Try
            dgDetalleGR.AutoGenerateColumns = False
            dgDetalleGR.DataSource = Nothing
            Dim ht As Hashtable = New Hashtable()
            ht.Add("CCLNT", dgGuiasRemision.CurrentRow.Cells("CCLNT").Value)
            ht.Add("NGUIRM", dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value)
            ' dgDetalleGR.DataSource = New brGuiasRemision().fnSelDetalleGuiaDS(ht)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fnSelObservacionesGR()
        Try
            dgObservacionGR.AutoGenerateColumns = False
            dgObservacionGR.DataSource = Nothing
            Dim ht As Hashtable = New Hashtable()
            ht.Add("CCLNT", dgGuiasRemision.CurrentRow.Cells("CCLNT").Value)
            ht.Add("NGUIRM", dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value)
            dgObservacionGR.DataSource = New DespachoSDS.brGuiasRemision().fnSelObservacionGR(ht)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmConsultaGuiaRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientePK As TD_ClientePK = New TD_ClientePK(0, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
        Catch : End Try
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            dgGuiasRemision.DataSource = Nothing
            Dim Mensaje As String = fnValidarInformacion()
            If Mensaje <> String.Empty Then
                MessageBox.Show(Mensaje, "Actualizar Indicadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            fnSelGuiasRemision()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgGuiasRemision_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGuiasRemision.CellClick
        Try
            fnSelDetalleGR()
            fnSelObservacionesGR()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        If dgGuiasRemision.RowCount = 0 Then Exit Sub
        Dim objFiltro As clsFiltros_ReporteGuiaRemision = New clsFiltros_ReporteGuiaRemision()
        ' Filtros
        With objFiltro
            .pintCodigoCliente_CCLNT = txtCliente.pCodigo
            .pintNroGuiaRemision_NGUIRM = Convert.ToInt64(dgGuiasRemision.CurrentRow.Cells("NGUIRM").Value)
        End With

        Dim strMensajeError As String = String.Empty
        With frmVisorRPT
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .pReportDocument = mfrptReporteGuiaRemisionDS(objFiltro)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
    End Sub

    Private Sub dgGuiasRemision_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGuiasRemision.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Up, Keys.Down, Keys.Enter
                    fnSelDetalleGR()
                    fnSelObservacionesGR()
            End Select
        Catch ex As Exception
        End Try

    End Sub
End Class
