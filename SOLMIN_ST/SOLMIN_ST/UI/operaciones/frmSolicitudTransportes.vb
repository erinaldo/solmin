Public Class frmSolicitudTransportes

    Private Sub frmSolicitudTransportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcSolicitudTransportes1.pRequerimientoServicio = Nothing
            UcSolicitudTransportes1.pEsRequerimiento = False
            UcSolicitudTransportes1.pNombreForm = Me.Name
            UcSolicitudTransportes1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
