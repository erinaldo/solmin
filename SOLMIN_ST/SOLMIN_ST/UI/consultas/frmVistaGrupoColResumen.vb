

 

Public Class frmVistaGrupoColResumen
    Public listVista As List(Of String)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVistaGrupoColResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtGrupoVista As New DataTable
        dtGrupoVista.Columns.Add("GRUPO")
        dtGrupoVista.Columns.Add("CODGRUPO")
        Dim dr As DataRow
        dr = dtGrupoVista.NewRow
        dr("GRUPO") = "Liquidación Combustible"
        dr("CODGRUPO") = "GLCOMB"
        dtGrupoVista.Rows.Add(dr)

        dr = dtGrupoVista.NewRow
        dr("GRUPO") = "Valorización servicios"
        dr("CODGRUPO") = "GVLRZ"
        dtGrupoVista.Rows.Add(dr)


        dr = dtGrupoVista.NewRow
        dr("CODGRUPO") = "GESTV"
        dr("GRUPO") = "Estimación Venta"
        dtGrupoVista.Rows.Add(dr)


        dr = dtGrupoVista.NewRow
        dr("CODGRUPO") = "GSECDOC"
        dr("GRUPO") = "Seguimiento documento"
        dtGrupoVista.Rows.Add(dr)


        dr = dtGrupoVista.NewRow
        dr("CODGRUPO") = "GANOP"
        dr("GRUPO") = "Anulación operación"
        dtGrupoVista.Rows.Add(dr)


        dr = dtGrupoVista.NewRow
        dr("CODGRUPO") = "GTRFOS"
        dr("GRUPO") = "Tarifas Orden Servicio"
        dtGrupoVista.Rows.Add(dr)

       
        gwLista.DataSource = dtGrupoVista


        For Each item As DataGridViewRow In gwLista.Rows

            If listVista.Contains(item.Cells("CODGRUPO").Value) Then
                item.Cells("chk").Value = True
            End If

        Next

        gwLista.EndEdit()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        gwLista.EndEdit()

        listVista.Clear()
        For Each item As DataGridViewRow In gwLista.Rows

            If item.Cells("chk").Value = True Then
                listVista.Add(item.Cells("CODGRUPO").Value)
            End If
        Next

        DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class