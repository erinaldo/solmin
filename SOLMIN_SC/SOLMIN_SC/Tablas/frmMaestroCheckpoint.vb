Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmMaestroCheckpoint

    Dim oCheckPoint As clsCheckPoint
    Dim dtCheckpoint As DataTable
    Dim ListaTitulos As List(Of String)
    Dim ListaDatatable As List(Of DataTable)

    Private Sub frmMaestroCheckpoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Compania()
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.pActualizar()
            cmbDivision.DivisionDefault = "S"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Sub Buscar()

        oCheckPoint = New clsCheckPoint
        dtCheckpoint = New DataTable
        dtCheckpoint = oCheckPoint.Buscar_Maestro_CheckPoint(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
        dtgMaestroCheckpoint.DataSource = dtCheckpoint

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim objFrm As New frmMantMaestroCheckpoint

            Dim fila As Int32 = 0
            fila = dtgMaestroCheckpoint.CurrentCellAddress.Y

            objFrm.pCompania = cmbCompania.CCMPN_CodigoCompania
            objFrm.pDivision = cmbDivision.Division
            objFrm.pUsuario = HelpUtil.UserName

            If objFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Buscar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If dtgMaestroCheckpoint.CurrentRow IsNot Nothing And dtgMaestroCheckpoint.Rows.Count > 0 Then

                Dim objFrm As New frmMantMaestroCheckpoint
                Dim fila As Int32 = 0
                fila = dtgMaestroCheckpoint.CurrentCellAddress.Y

                objFrm.pCompania = dtgMaestroCheckpoint.Item("CCMPN", fila).Value.ToString.Trim
                objFrm.pDivision = dtgMaestroCheckpoint.Item("CDVSN", fila).Value.ToString.Trim
                objFrm.pTipo = dtgMaestroCheckpoint.Item("CEMB", fila).Value.ToString.Trim
                objFrm.pCodigo = dtgMaestroCheckpoint.Item("NESTDO", fila).Value
                objFrm.pDescripcion = dtgMaestroCheckpoint.Item("TDESES", fila).Value.ToString.Trim
                objFrm.pUsuario = HelpUtil.UserName

                If objFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim fila As Int32 = 0
            fila = dtgMaestroCheckpoint.CurrentCellAddress.Y

            If MessageBox.Show("¿Desea eliminar el registro " & dtgMaestroCheckpoint.Item("NESTDO", fila).Value & " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                oCheckPoint = New clsCheckPoint
                oCheckPoint.Eliminar_Maestro_CheckPoint(CDec(dtgMaestroCheckpoint.Item("NESTDO", fila).Value), HelpUtil.UserName)
                Buscar()

            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC

            Dim dt As DataTable
            'NPOI = New Ransa.Utilitario.HelpClass_NPOI_ST

            If Me.dtgMaestroCheckpoint.Rows.Count = 0 Then Exit Sub
            dt = New DataTable
            dt = Me.dtgMaestroCheckpoint.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NESTDO", Type.GetType("System.Int32")).Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoNumero)
            dtExcel.Columns.Add("TDESES").Caption = NPOI_SC.FormatDato("Descripción", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NOMVAR", Type.GetType("System.String")).Caption = NPOI_SC.FormatDato("Tipo", NPOI_SC.keyDatoTexto)
            
            For Each dr2 As DataRow In dt.Rows
                dr = dtExcel.NewRow
                dr("NESTDO") = CInt(dr2("NESTDO"))
                dr("TDESES") = dr2("TDESES")
                dr("NOMVAR") = dr2("NOMVAR")

                dtExcel.Rows.Add(dr)
            Next

            ListaDatatable = New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            ListaTitulos = New List(Of String)
            ListaTitulos.Add("MAESTRO CHECKPOINT")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cmbDivision.DivisionDescripcion)

            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("NESTDO")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
