Imports RANSA.NEGO
Imports RANSA.TYPEDEF
imports Ransa .Utilitario 

Public Class frmListaMantenimientoIncidencia

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obrIncidencia As New brIncidencias
        Dim obeIncidencias As New beIncidencias
        Dim DS As New DataSet
        With obeIncidencias
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = ListaCodigoDivisiones()
            .ANIO = CInt(txtAnio.Text)
        End With
        dtgIncidencias.AutoGenerateColumns = False
        DS = obrIncidencia.olistListarMaestroIncidencias(obeIncidencias)
        DS.Tables(0).Columns.Remove("CODIGO")
        Me.dtgIncidencias.DataSource = DS.Tables(0).Copy

    End Sub

    Private Sub frmListaRegistroIncidencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        txtAnio.Text = Now.Year
    End Sub

    Function ListaCodigoDivisiones() As String

        Dim strCadDocumentos As String = ""

        For i As Integer = 0 To cmbDivision.Properties.Items.Count - 1
            If cmbDivision.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbDivision.Properties.Items.Item(i).Value & ","
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        'UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        'UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        'UcDivision_Cmb011.pActualizar()
        Cargar_Divisiones()
    End Sub

    Private Sub Cargar_Divisiones()
        Dim objDAL As New Ransa.Controls.UbicacionPlanta.Division.daoDivision
        'Dim objDAL As New RANSA.DAO.UbicacionPlanta.Division.daoDivision
        Dim dt As DataTable = Nothing

        dt = objDAL.Lista_Division_X_Usuario_Y_Compania(objSeguridadBN.pUsuario, UcCompania_Cmb011.CCMPN_CodigoCompania)

        cmbDivision.Properties.DataSource = dt
        cmbDivision.Properties.ValueMember = "CDVSN"
        cmbDivision.Properties.DisplayMember = "TCMPDV"
        Me.Cursor = System.Windows.Forms.Cursors.Default
        cmbDivision.CheckAll()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ofrmMIncidencias As New frmMIncidencias
        With ofrmMIncidencias
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        End With
        If ofrmMIncidencias.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnBuscar_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dtgIncidencias.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmMIncidencias As New frmMIncidencias
        With ofrmMIncidencias
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = ("" & Me.dtgIncidencias.CurrentRow.Cells("CDVSN").Value).ToString.Trim 'Me.dtgIncidencias.CurrentRow.DataBoundItem.CDVSN
            .PSTCMPDV = ("" & Me.dtgIncidencias.CurrentRow.Cells("TCMPDV").Value).ToString.Trim 'Me.dtgIncidencias.CurrentRow.DataBoundItem.TCMPDV.ToString.Trim
            .PNCINCID = Me.dtgIncidencias.CurrentRow.Cells("CINCID").Value 'Me.dtgIncidencias.CurrentRow.DataBoundItem.CINCID
            .PSTINCSI = ("" & Me.dtgIncidencias.CurrentRow.Cells("TINCSI").Value).ToString.Trim 'Me.dtgIncidencias.CurrentRow.DataBoundItem.TINCSI
        End With
        If ofrmMIncidencias.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnBuscar_Click(Nothing, Nothing)
        End If

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.dtgIncidencias.CurrentCellAddress.Y = -1 Then Exit Sub
        If MessageBox.Show("Eliminar el registro", "Desea eliminar el registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
        Dim obr As New brIncidencias
        Dim obe As New beIncidencias
        With obe
            .PSCCMPN = ("" & Me.dtgIncidencias.CurrentRow.Cells("CCMPN").Value).ToString.Trim 'Me.dtgIncidencias.CurrentRow.DataBoundItem.CCMPN
            .PSCDVSN = ("" & Me.dtgIncidencias.CurrentRow.Cells("CDVSN").Value).ToString.Trim 'Me.dtgIncidencias.CurrentRow.DataBoundItem.CDVSN
            .PNCINCID = Me.dtgIncidencias.CurrentRow.Cells("CINCID").Value 'Me.dtgIncidencias.CurrentRow.DataBoundItem.CINCID
            .PSNTRMNL = objSeguridadBN.pstrPCName
            .PSUSUARIO = objSeguridadBN.pUsuario
            .PSSESTRG = "*"
        End With
        If obr.intEliminarMaestroIncidencias(obe) = 1 Then
            MessageBox.Show("Se Eliminó el registro satisfactoriamente")
            btnBuscar_Click(Nothing, Nothing)
        Else
            MessageBox.Show("El registro contiene incidencias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Compañia: \n " & UcCompania_Cmb011.CCMPN_Descripcion)


        Dim strCadDocumentos As String = ""
        For i As Integer = 0 To cmbDivision.Properties.Items.Count - 1
            If cmbDivision.Properties.Items.Item(i).CheckState = 1 Then
                strCadDocumentos += cmbDivision.Properties.Items.Item(i).Description.Trim & " ;  "
            End If
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        strlTitulo.Add("División: \n " & strCadDocumentos)
        strlTitulo.Add("Año: \n " & Me.txtAnio.Text)

        HelpClass.ExportExcelConTitulos(Me.dtgIncidencias, Me.Text, strlTitulo)

    End Sub
End Class
