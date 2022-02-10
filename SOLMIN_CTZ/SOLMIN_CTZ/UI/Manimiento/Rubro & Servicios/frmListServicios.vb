Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class frmListServicios

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        AgregarRubro()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModificarRubro()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Not VerificarServicioGeneral() Then
                QuitarServicioGeneral()
            Else
                HelpClass.MsgBox("El servico general no se puede eliminar por tener servicios específicos")
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarRubros()
    End Sub

    Private Sub BuscarRubros()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim pobjFiltro As New Servicio_X_Rubro

            With pobjFiltro
                .CCMPN = ucCompania.CCMPN_CodigoCompania
                .CDVSN = UcDivision.Division
                .SESTRG = "A"
            End With

            dtgRubro.DataSource = Nothing
            dtgServiciosXRubro.DataSource = Nothing

            Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
            dtgRubro.AutoGenerateColumns = False
            Me.dtgRubro.DataSource = oServicioXDivisionNeg.fdtListaServiciosGenerales(pobjFiltro)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BuscarServiciosXRubros()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim pobjFiltro As New Servicio_X_Rubro

            With pobjFiltro
                .NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
                .CCMPN = dtgRubro.CurrentRow.Cells("CCMPN").Value
            End With

            Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
            dtgServiciosXRubro.AutoGenerateColumns = False
            Me.dtgServiciosXRubro.DataSource = oServicioXDivisionNeg.fdtListaServiciosEspecificos(pobjFiltro)

            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDet.Click
        AgregarServicios()
    End Sub

    Private Sub btnModificarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDet.Click

        ModificarServicios()
    End Sub

    Private Sub btnEliminarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDet.Click
        Try
            If Not fbolVerificarServicioEspecifico() Then
                QuitarServicioEspecifico()
            Else
                HelpClass.MsgBox("El servicio no se puede eliminar por tener tarifas asociadas")
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub


    Private Sub ModificarRubro()
        If Me.dtgRubro.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmMantRubro As New frmMantServicioGeneral
        With ofrmMantRubro.obeServicios
            '.NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
            '.NOMRUB = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NOMRUB")
            .NRRUBR = dtgRubro.CurrentRow.Cells("NRRUBR").Value
            .NOMRUB = ("" & dtgRubro.CurrentRow.Cells("NOMRUB").Value).ToString.Trim
            'CSR-HUNDRED-INICIO
            .CCMPN = dtgRubro.CurrentRow.Cells("CCMPN").Value
            .CDVSN = UcDivision.Division
            'CSR-HUNDRED-FIN
        End With
        If ofrmMantRubro.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BuscarRubros()
        End If
    End Sub

    Private Sub AgregarRubro()
        Dim ofrmMantRubro As New frmMantServicioGeneral
        With ofrmMantRubro.obeServicios
            .CCMPN = ucCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
        End With
        If ofrmMantRubro.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BuscarRubros()
        End If
    End Sub

    Private Sub AgregarServicios()
        If Me.dtgRubro.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmMantServicio As New frmMantServicio
        With ofrmMantServicio.obeServicios
            .NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
            .CCMPN = ucCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
        End With
        If ofrmMantServicio.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dtgRubro_SelectionChanged(Nothing, Nothing)
        End If

    End Sub

    Private Sub ModificarServicios()
        If Me.dtgServiciosXRubro.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim ofrmMantServicio As New frmMantServicio
        With ofrmMantServicio.obeServicios
            .CCMPN = ucCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
            .NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
            .NRSRRB = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRSRRB")
            .NOMSER = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NOMSER")
            .CSRVNV = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("CSRVNV")
        End With
        If ofrmMantServicio.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dtgRubro_SelectionChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtgRubro_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgRubro.SelectionChanged
        If Me.dtgRubro.CurrentCellAddress.Y <> -1 Then
            BuscarServiciosXRubros()
        End If
    End Sub

    Private Sub frmListServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarInformacion()
    End Sub


    Private Sub CargarInformacion()
        'Cargamos compania por usuario
        ucCompania.Usuario = ConfigurationWizard.UserName
        ucCompania.pActualizar()
        ucCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles ucCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()
    End Sub


    Private Function VerificarServicioGeneral() As Boolean
        Try
            Dim pobjFiltro As New Servicio_X_Rubro
            With pobjFiltro
                .NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
                .CCMPN = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("CCMPN") 'CSR-HUNDRED
            End With

            Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision

            Return oServicioXDivisionNeg.fbolVerificarServicoGeneral(pobjFiltro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Private Sub QuitarServicioGeneral()
        Try
            If HelpClass.RspMsgBox("Está seguro de quitar el rubro y los servicios asociados?") = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
                Dim pobjFiltro As New Servicio_X_Rubro
                With pobjFiltro
                    .NRRUBR = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
                    .CCMPN = CType(Me.dtgRubro.CurrentRow.DataBoundItem, DataRowView).Item("CCMPN") 'CSR-HUNDRED
                End With


                If oServicioXDivisionNeg.fintQuitarServicoGeneral(pobjFiltro) = -1 Then
                    HelpClass.ErrorMsgBox()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
                BuscarRubros()
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el rubro")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Function fbolVerificarServicioEspecifico() As Boolean
        Try
            Dim objEntidad As New Servicio_X_Rubro
            Dim oServicioNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
            objEntidad.NRRUBR = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
            objEntidad.NRSRRB = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRSRRB")
            objEntidad.CCMPN = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("CCMPN") 'CSR-HUNDRED

            Return oServicioNeg.fbolVerificarServicioEspecificos(objEntidad)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Throw New Exception(ex.Message)

        End Try
    End Function


    Private Sub QuitarServicioEspecifico()
        Try
            If HelpClass.RspMsgBox("Está seguro que desea quitar el servicio seleccionado?") = Windows.Forms.DialogResult.Yes Then

                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim objEntidad As New Servicio_X_Rubro
                Dim oServicioNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision

                objEntidad.NRRUBR = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRRUBR")
                objEntidad.NRSRRB = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("NRSRRB")
                objEntidad.CCMPN = CType(Me.dtgServiciosXRubro.CurrentRow.DataBoundItem, DataRowView).Item("CCMPN") 'CSR-HUNDRED

                If oServicioNeg.fintEliminarServicioEspecificos(objEntidad) = -1 Then
                    HelpClass.ErrorMsgBox()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If

                dtgRubro_SelectionChanged(Nothing, Nothing)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se quitó correctamente el servicio")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim oDt As DataTable
        Dim oDs As New DataSet
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim pobjFiltro As New Servicio_X_Rubro
        Dim oServicioXDivisionNeg As New SOLMIN_CTZ.NEGOCIO.clsServicioXDivision
        With pobjFiltro
            .CCMPN = ucCompania.CCMPN_CodigoCompania
            .CDVSN = UcDivision.Division
            .SESTRG = "A"
        End With

        Try
            oDt = oServicioXDivisionNeg.fdtListaParaExportarExcel(pobjFiltro)
            oDt.TableName = "REPORTE DE SERVICIOS"
            oDs.Tables.Add(oDt)
            Dim mTitulos As New List(Of String)
            'mTitulos.Add("REPORTE DE SERVICIOS ")
            'mTitulos.Add("\n ")
            mTitulos.Add("COMPAÑIA : \n" & ucCompania.CCMPN_Descripcion)
            mTitulos.Add("DIVISIÓN : \n" & UcDivision.DivisionDescripcion)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, mTitulos)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class
