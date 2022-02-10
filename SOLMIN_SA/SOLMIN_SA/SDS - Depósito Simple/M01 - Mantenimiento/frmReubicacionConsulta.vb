Imports Ransa.TypeDef
Imports Ransa.NEGO
Public Class frmReubicacionConsulta
    Public obeMercaderia As New beMercaderia()
    Public myDialogResult As Boolean = False
    Private Sub ListarUbicacionxOrdenServicio()
        Try

            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            dgMercaderiaUbicacion.DataSource = oblInventarioMercaderia.ListarInventarioMercaderiaxUbicacion(obeMercaderia).Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmReubicacionConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgMercaderiaUbicacion.AutoGenerateColumns = False
            ListarUbicacionxOrdenServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function ObtenerDatosUbicacion() As beUbicacion
        Dim obeUbicacion As New beUbicacion
        obeUbicacion.PNNORDSR = dgMercaderiaUbicacion.CurrentRow.Cells("NORDSR").Value 'OS
        obeUbicacion.PSCTPALM_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("CTPALM").Value).ToString.Trim 'COD TIPO ALMACEN
        obeUbicacion.PSTALMC_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("TALMC").Value).ToString.Trim    ' TIPO ALMACEN
        obeUbicacion.PSCALMC_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("CALMC").Value).ToString.Trim   'COD ALMACEN
        obeUbicacion.PSTCMPAL_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("TCMPAL").Value).ToString.Trim   ' ALMACEN
        obeUbicacion.PSCZNALM_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("CZNALM").Value).ToString.Trim   'COD ZONA 
        obeUbicacion.PSTCMZNA_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("TCMZNA").Value).ToString.Trim  ' ZONA ALMACEN
        obeUbicacion.PSCSECTR_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("CSECTR").Value).ToString.Trim  'COD SECTOR
        obeUbicacion.PSTNMSCT_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("TNMSCT").Value).ToString.Trim   ' SECTOR
        obeUbicacion.PSCPSCN_I = ("" & dgMercaderiaUbicacion.CurrentRow.Cells("CPSCN").Value).ToString.Trim  'CODIO POSICION
        obeUbicacion.PNQTRMC_I = dgMercaderiaUbicacion.CurrentRow.Cells("QSLETQ").Value   ' CANTIDAD
        obeUbicacion.PNCCLNT = dgMercaderiaUbicacion.CurrentRow.Cells("CCLNT2").Value ' CLIENTE
        Return obeUbicacion
    End Function

    Private Sub btnReubicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReubicar.Click
        Try
            If (dgMercaderiaUbicacion.Rows.Count = 0) Then
                MessageBox.Show("No hay Datos", "Reubicar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obeUbicacion As New beUbicacion
            obeUbicacion = ObtenerDatosUbicacion()           
            Dim ofrmMantenimientoReubicacion As New frmMantenimientoReubicacion
            ofrmMantenimientoReubicacion.obeInfoUbicacion = obeUbicacion
            If (ofrmMantenimientoReubicacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                myDialogResult = True
                ListarUbicacionxOrdenServicio()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
