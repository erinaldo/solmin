Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TYPEDEF.Proveedor
Public Class frmListaLotes

#Region "Atributos"
    Private CCLNT As Decimal = 0
#End Region

#Region "Variables"

    Dim obrLote As New brLote


#End Region

#Region "Delegados"


    Private Sub frmListaLotes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        CargarPlanta()
    End Sub


    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        If txtCliente.pCodigo <> 0 Then
            Dim objLote As New beLote
            With objLote
                .CCLNT = txtCliente.pCodigo
                .CRTLTE = txtCriterioLote.Text.Trim
                .CMRCLR = txtMercaderia.Text.Trim
            End With
            dgvLotes.AutoGenerateColumns = False
            dgvLotes.DataSource = obrLote.ListarLotesPorCliente(objLote)
        Else
            MessageBox.Show("Seleccione un CLiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvLotes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLotes.CellClick
        ListarUbicacionesPorLote()
    End Sub

    Private Sub dgvLotes_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLotes.CurrentCellChanged
        ListarUbicacionesPorLote()
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If dgvLotes.Rows.Count > 0 Then
            Dim objLotes As New beLote
            With objLotes
                .NUEVO = False
                .CCLNT = txtCliente.pCodigo
                .NORDSR = Val(dgvLotes.CurrentRow.Cells("NORDSR").Value)
                .NCRRIN = Val(dgvLotes.CurrentRow.Cells("NCRRIN").Value)
                .CRTLTE = dgvLotes.CurrentRow.Cells("CRTLTE").Value.ToString.Trim
                .CPRVCL = Val(dgvLotes.CurrentRow.Cells("CPRVCL").Value)
                .NDCMPV = dgvLotes.CurrentRow.Cells("NDCMPV").Value.ToString.Trim
                .CMNCT = Val(dgvLotes.CurrentRow.Cells("CMNCT").Value)
                .IMPTTL = Val(dgvLotes.CurrentRow.Cells("IMPTTL").Value)
                .CMNVTA = Val(dgvLotes.CurrentRow.Cells("CMNVTA").Value)
                .IMPVTA = Val(dgvLotes.CurrentRow.Cells("IMPVTA").Value)
                .FINGAL = Val(dgvLotes.CurrentRow.Cells("FINGAL").Value)
                .FPRDMR = Val(dgvLotes.CurrentRow.Cells("FPRDMR").Value)
                .FVNLTE = Val(dgvLotes.CurrentRow.Cells("FVNLTE").Value)
                .NTRNO = Val(dgvLotes.CurrentRow.Cells("NTRNO").Value)
                .TOBSCR = dgvLotes.CurrentRow.Cells("TOBSCR").Value.ToString.Trim
            End With
            Dim frmManteniemtoLotes As New frmMantenimientoLote()
            frmManteniemtoLotes.NUEVO = False
            frmManteniemtoLotes._objBeLote = objLotes
            If frmManteniemtoLotes.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Se ha modificado el lote de manera satisfactoria", "Avido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tsbBuscar_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnAgregarLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLotes.Click
        If txtCliente.pCodigo <> 0 Then
            Dim frmMantenimientoLote As New frmMantenimientoLote()
            frmMantenimientoLote.NUEVO = True
            frmMantenimientoLote.CCLNT = txtCliente.pCodigo
            If frmMantenimientoLote.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Se ha creado el lote de manera satisfactoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tsbBuscar_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Seleccione un CLiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            If dgvLotes.RowCount > 0 Then
                Dim oDtgExcel As New DataGridView
                oDtgExcel = dgvLotes
                For intCont As Integer = oDtgExcel.ColumnCount - 1 To 1 Step -1
                    If Not oDtgExcel.Columns(intCont).Visible Then
                        oDtgExcel.Columns.RemoveAt(intCont)
                    End If
                Next
                Dim strlTitulo As New List(Of String)
                strlTitulo.Add("\n Reporte de Lotes \n")
                strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
                strlTitulo.Add("Planta  :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
                If Not String.IsNullOrEmpty(txtCriterioLote.Text.Trim) Then
                    strlTitulo.Add("Criterio de lote :\n" & txtCriterioLote.Text.Trim)
                End If
                If Not String.IsNullOrEmpty(txtMercaderia.Text.Trim) Then
                    strlTitulo.Add("Mercadería :\n" & txtMercaderia.Text.Trim)
                End If
                HelpClass.ExportExcelConTitulos(oDtgExcel, "Reporte de Lotes", strlTitulo)
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub
    Private Sub btnEliminarLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarLotes.Click
        Dim cantidadIngresada As Decimal = 0
        Dim cantidadDespachada As Decimal = 0
        Dim cantiodadSaldo As Decimal = 0
        If dgvLotes.Rows.Count > 0 Then
            Dim objLotes As New beLote
            cantidadIngresada = Val(dgvLotes.CurrentRow.Cells("QINMC2").Value) ' cantidad ingresada
            cantidadDespachada = Val(dgvLotes.CurrentRow.Cells("QDSMC2").Value) 'cantidad despachada
            cantiodadSaldo = Val(dgvLotes.CurrentRow.Cells("QMRCSL").Value) 'cantidad saldo
            If cantidadIngresada <> 0 OrElse cantidadDespachada <> 0 OrElse cantiodadSaldo <> 0 Then
                MessageBox.Show("No se puede eliminar porque tiene moviemiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If dgvUbicacionLote.RowCount > 0 Then
                MessageBox.Show("No se puede eliminar porque tiene ubicaciones asociadas. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea eliminar el lote seleccionado?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                objLotes.NORDSR = Val(dgvLotes.CurrentRow.Cells("NORDSR").Value)
                objLotes.NCRRIN = Val(dgvLotes.CurrentRow.Cells("NCRRIN").Value)
                objLotes.CULUSA = objSeguridadBN.pUsuario
                If obrLote.AnularLotes(objLotes) = True Then
                    MessageBox.Show("Se eliminó el lote de manera satisfactoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tsbBuscar_Click(Nothing, Nothing)
                Else
                    MessageBox.Show("No se puede eliminar el Lote", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnAgregar_Ubicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Ubicacion.Click
        Dim frmAgregarPosicion As New frmAgregarPosicion()
        If dgvLotes.RowCount > 0 Or dgvLotes.CurrentRow IsNot Nothing Then
            frmAgregarPosicion.NORDSR = Val(dgvLotes.CurrentRow.Cells("NORDSR").Value)
            frmAgregarPosicion.NCRRIN = Val(dgvLotes.CurrentRow.Cells("NCRRIN").Value)
            frmAgregarPosicion.USUARIO = objSeguridadBN.pUsuario
            frmAgregarPosicion.PLANTA = UcPLanta_Cmb011.Planta
            If frmAgregarPosicion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MessageBox.Show("Se agregó la ubicación de manera satisfactoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarUbicacionesPorLote()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Ubicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Ubicacion.Click
        If dgvUbicacionLote.RowCount > 0 Or dgvUbicacionLote.CurrentRow IsNot Nothing Then
            If dgvUbicacionLote.CurrentRow.Cells("QINETQ").Value <> 0 OrElse dgvUbicacionLote.CurrentRow.Cells("QSLETQ").Value <> 0 Then
                MessageBox.Show("No se puede eliminar la ubicación porque tiene saldo en el inventario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea eliminar el lote seleccionado?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim objUbicacionLote As New BeUbicacionesLotes
                objUbicacionLote.NETQCB = dgvUbicacionLote.CurrentRow.Cells("NETQCB").Value
                objUbicacionLote.PSCULUSA = objSeguridadBN.pUsuario
                If obrLote.AnularUbicacionLotes(objUbicacionLote) = True Then
                    MessageBox.Show("Se eliminó la ubicación de manera satisfactoria .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarUbicacionesPorLote()
                End If
            End If
        End If
    End Sub

#End Region

#Region "Metodos y Funciones"

    Private Sub ListarUbicacionesPorLote()
        If dgvLotes.RowCount > 0 Then
            If dgvLotes.CurrentRow IsNot Nothing Then
                Dim objLote As New beLote
                With objLote
                    .NORDSR = Val(dgvLotes.CurrentRow.Cells("NORDSR").Value)
                    .NCRRIN = Val(dgvLotes.CurrentRow.Cells("NCRRIN").Value)
                End With
                dgvUbicacionLote.AutoGenerateColumns = False
                dgvUbicacionLote.DataSource = obrLote.ListarUbicacionesPorLoteCLiente(objLote)
            Else
                dgvUbicacionLote.DataSource = Nothing
            End If
        Else
            dgvUbicacionLote.DataSource = Nothing
        End If
    End Sub

    Private Sub CargarPlanta()
        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

#End Region

End Class
