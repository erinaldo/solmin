Imports Ransa.TypeDef
Imports Ransa.NEGO
Public Class frmMovimientoPosicion
    Public obeAlmacen As beAlmacen
    Private Sub frmMovimientoPosicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgDatos.AutoGenerateColumns = False
            Limpiar()
            Habilitar(False)
            txtOS.Text = obeAlmacen.PNNORDSR
            txtPosicion.Text = obeAlmacen.PSCPSCN
            txtSector.Text = obeAlmacen.PSTNMSCT
            txtTipoAlmacen.Text = obeAlmacen.PSTALMC
            txtZona.Text = obeAlmacen.PSTCMZNA
            txtAlmacen.Text = obeAlmacen.PSTALMC

            Dim oblInventarioMercaderia As New blInventarioMercaderia()
            Dim odt As New DataTable()
            odt = oblInventarioMercaderia.Lista_Movimiento_por_Posicion(obeAlmacen).Tables(0)
            dgDatos.DataSource = odt
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Limpiar()
        txtAlmacen.Text = ""
        txtOS.Text = ""
        txtTipoAlmacen.Text = ""
        txtZona.Text = ""
        txtPosicion.Text = ""
        txtSector.Text = ""
    End Sub
    Private Sub Habilitar(ByVal habilitar As Boolean)
        txtAlmacen.Enabled = habilitar
        txtOS.Enabled = habilitar
        txtTipoAlmacen.Enabled = habilitar
        txtZona.Enabled = habilitar
        txtPosicion.Enabled = habilitar
        txtSector.Enabled = habilitar
    End Sub
  

    
    Private Sub dgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatos.CellContentClick
        Try
            If dgDatos.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            Dim obeUsuario As New beUsuario()
            Dim fila As Int32 = e.RowIndex

            If (e.ColumnIndex = 4) Then
                obeUsuario.FECHA_CREACION = ("" & dgDatos.Item("FCHCRT", fila).Value).ToString.Trim
                obeUsuario.FECHA_ACTUALIZACION = ("" & dgDatos.Item("FULTAC", fila).Value).ToString.Trim
                obeUsuario.HORA_ACTUALIZACION = ("" & dgDatos.Item("HULTAC", fila).Value).ToString.Trim
                obeUsuario.HORA_CREACION = ("" & dgDatos.Item("HRACRT", fila).Value).ToString.Trim
                obeUsuario.TERMINAL_ACTUALIZACION = ("" & dgDatos.Item("NTRMNL", fila).Value).ToString.Trim
                obeUsuario.TERMINAL_CREACION = ("" & dgDatos.Item("NTRMCR", fila).Value).ToString.Trim
                obeUsuario.USUARIO_ACTUALIZACION = ("" & dgDatos.Item("CULUSA", fila).Value).ToString.Trim
                obeUsuario.USUARIO_CREACION = ("" & dgDatos.Item("CUSCRT", fila).Value).ToString.Trim
                Dim ofrmAuditoria As New frmAuditoria
                ofrmAuditoria.obeUsuario = obeUsuario
                ofrmAuditoria.ShowDialog(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
