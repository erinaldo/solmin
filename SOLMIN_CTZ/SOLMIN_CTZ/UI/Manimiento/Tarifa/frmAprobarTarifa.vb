Imports System.Windows.Forms
Imports System.Drawing

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
 
'Imports Ransa.Controls.Transporte
Imports System.Threading

Public Class frmAprobarTarifa




    Private pTipo_Cambio As Decimal = 0D
    Private pCheck As Boolean = False
    Private Sub frmAprobarTarifa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            gvTarifa.AutoGenerateColumns = False

            'If NroTarifa > 0 Then
            '    txtTarifa.Text = NroTarifa
            '    Lista_Cotizacione_Por_Aprobar()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            If Me.gvTarifa.CurrentCellAddress.Y = -1 Then Exit Sub
            gvTarifa.EndEdit()
            Dim CantCheck As Int32 = 0

            Dim aprob_sugerido As String = ""
            'Dim aprob_sugerido_sig As String = ""
            Dim pMargen As Decimal = 0
            'APRBSG
            For Each item As DataGridViewRow In gvTarifa.Rows
                If item.Cells("CHK").Value = True Then
                    CantCheck = CantCheck + 1

                    'If CantCheck = 1 Then
                    '    aprob_sugerido = ("" & item.Cells("APRBSG").Value).ToString.Trim
                    'End If
                    'aprob_sugerido_sig = ("" & item.Cells("APRBSG").Value).ToString.Trim

                    'If aprob_sugerido <> aprob_sugerido_sig Then
                    '    MessageBox.Show("Solo puede seleccionar mismo aprobador sugerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    Exit Sub
                    'End If

                    aprob_sugerido = ("" & item.Cells("APRBSG").Value).ToString.Trim
                    pMargen = item.Cells("MRGVAL").Value
                End If
            Next

            If CantCheck = 0 Then
                MessageBox.Show("No se ha seleccionado el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oucfrmAprobarTarifa As New ucfrmAprobarTarifa()
            Dim pCCMPN As String = ""
            Dim IdContrato As Decimal = 0
            Dim IdTarifa As Decimal = 0
            'oucfrmAprobarTarifa.InicializarFormulario(Me)
            oucfrmAprobarTarifa.AprobSugerido = aprob_sugerido ' Me.gvTarifa.CurrentRow.Cells("APRBSG").Value
            oucfrmAprobarTarifa.MrgAprobacion = pMargen  ' Me.gvTarifa.CurrentRow.Cells("MRGVAL").Value
            'pCCMPN = Me.gvTarifa.CurrentRow.Cells("CCMPN").Value
            'IdContrato = Me.gvTarifa.CurrentRow.Cells("NRCTSL").Value
            'IdTarifa = Me.gvTarifa.CurrentRow.Cells("NRTFSV").Value
            'oucfrmAprobarTarifa.Compania = Me.gvTarifa.CurrentRow.Cells("CCMPN").Value
            'oucfrmAprobarTarifa.IdContrato = Me.gvTarifa.CurrentRow.Cells("NRCTSL").Value
            'oucfrmAprobarTarifa.IdTarifa = Me.gvTarifa.CurrentRow.Cells("NRTFSV").Value
            oucfrmAprobarTarifa.ShowDialog()


            If oucfrmAprobarTarifa.pDialog = True Then

                Dim objTarifa As New Tarifa
                Dim obrTarifa As New clsTarifa
                Dim oList As New List(Of Tarifa)


                For Each item As DataGridViewRow In gvTarifa.Rows
                    If item.Cells("CHK").Value = True Then
                        objTarifa = New Tarifa
                        objTarifa.CCMPN = item.Cells("CCMPN").Value
                        objTarifa.NRCTSL = item.Cells("NRCTSL").Value
                        objTarifa.NRTFSV = item.Cells("NRTFSV").Value
                        objTarifa.APRBTF = oucfrmAprobarTarifa.txtAprobadorPor.Text.Trim
                        objTarifa.FCHAPR = Format(CDate(oucfrmAprobarTarifa.dtFeInicial.Text), "yyyyMMdd")
                        objTarifa.OBSAPR = oucfrmAprobarTarifa.txtObs.Text.Trim
                        oList.Add(objTarifa)
                    End If
                Next

                Dim result As Decimal = 0
                For Each item As Tarifa In oList
                    result = obrTarifa.Actualizar_Estado_OS(item)
                Next

                Lista_Cotizacione_Por_Aprobar()

            End If

          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Exportar()
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            If Me.gvTarifa.Rows.Count = 0 Then Exit Sub
            'Dim ListaExcel As New List(Of Detalle_Cotizacion)
            'Dim objCotizacion As New Detalle_Cotizacion

            'For Each dRow As DataGridViewRow In dtgDetalleCotizacion.Rows
            '    objCotizacion = New Detalle_Cotizacion
            '    objCotizacion.NRCTSL = dRow.Cells.Item("NRCTSL").Value
            '    objCotizacion.NRTFSV = dRow.Cells.Item("NRTFSV").Value
            '    objCotizacion.NORSRT = dRow.Cells.Item("NORSRT").Value

            '    objCotizacion.TCRVTA = dRow.Cells.Item("TCRVTA").Value
            '    objCotizacion.FFACTURA = dRow.Cells.Item("FFACTURA").Value
            '    objCotizacion.FPAGO = dRow.Cells.Item("FPAGO").Value
            '    objCotizacion.MRGVAL = dRow.Cells.Item("MRGVAL").Value
            '    objCotizacion.APRBSG = dRow.Cells.Item("APRBSG").Value
            '    objCotizacion.ESTADO_DES = dRow.Cells.Item("ESTADO_DES").Value

            'Next
            'ListaExcel.Add(objCotizacion)

            Dim dtExcel As New DataTable
            Dim dr As DataRow
            dtExcel.Columns.Add("NRCTSL").Caption = NPOI_SC.FormatDato("Contrato", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NRTFSV").Caption = NPOI_SC.FormatDato("Tarifa", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("NORSRT").Caption = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)

            dtExcel.Columns.Add("TCRVTA").Caption = NPOI_SC.FormatDato("Negocio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FFACTURA").Caption = NPOI_SC.FormatDato("Param. Facturación", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FPAGO").Caption = NPOI_SC.FormatDato("Param. Pago", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("MRGVAL").Caption = NPOI_SC.FormatDato("Mrg aprobación", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("APRBSG").Caption = NPOI_SC.FormatDato("Aprobador sugerido", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("ESTADO_DES").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)


            For Each dRow As DataGridViewRow In gvTarifa.Rows

                dr = dtExcel.NewRow
                dr("NRCTSL") = dRow.Cells.Item("NRCTSL").Value
                dr("NRTFSV") = dRow.Cells.Item("NRTFSV").Value
                dr("NORSRT") = dRow.Cells.Item("NORSRT").Value

                dr("TCRVTA") = dRow.Cells.Item("TCRVTA").Value
                dr("FFACTURA") = dRow.Cells.Item("FFACTURA").Value
                dr("FPAGO") = dRow.Cells.Item("FPAGO").Value
                dr("MRGVAL") = dRow.Cells.Item("MRGVAL").Value
                dr("APRBSG") = dRow.Cells.Item("APRBSG").Value
                dr("ESTADO_DES") = dRow.Cells.Item("ESTADO_DES").Value

                dtExcel.Rows.Add(dr)

                'objCotizacion = New Detalle_Cotizacion
                'objCotizacion.NRCTSL = dRow.Cells.Item("NRCTSL").Value
                'objCotizacion.NRTFSV = dRow.Cells.Item("NRTFSV").Value
                'objCotizacion.NORSRT = dRow.Cells.Item("NORSRT").Value

                'objCotizacion.TCRVTA = dRow.Cells.Item("TCRVTA").Value
                'objCotizacion.FFACTURA = dRow.Cells.Item("FFACTURA").Value
                'objCotizacion.FPAGO = dRow.Cells.Item("FPAGO").Value
                'objCotizacion.MRGVAL = dRow.Cells.Item("MRGVAL").Value
                'objCotizacion.APRBSG = dRow.Cells.Item("APRBSG").Value
                'objCotizacion.ESTADO_DES = dRow.Cells.Item("ESTADO_DES").Value

            Next

            'For Each inc As Detalle_Cotizacion In ListaExcel
            '    dr = dtExcel.NewRow
            '    dr("NRCTSL") = inc.NRCTSL
            '    dr("NRTFSV") = inc.NRTFSV
            '    dr("NORSRT") = inc.NORSRT

            '    dr("TCRVTA") = inc.TCRVTA
            '    dr("FFACTURA") = inc.FFACTURA
            '    dr("FPAGO") = inc.FPAGO
            '    dr("MRGVAL") = inc.MRGVAL
            '    dr("APRBSG") = inc.APRBSG
            '    dr("ESTADO_DES") = inc.ESTADO_DES

            '    dtExcel.Rows.Add(dr)
            'Next

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("ORDENES DE SERVICIO POR APROBAR")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cboCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cboDivision.DivisionDescripcion)

            F.Add(3, "Cliente:| " & txtCliente.pRazonSocial)
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("NORSRT")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        Try

            Dim CantCheck As Int32 = 0
            gvTarifa.EndEdit()

            For Each item As DataGridViewRow In gvTarifa.Rows
                If item.Cells("CHK").Value = True Then
                    CantCheck = CantCheck + 1
                End If
            Next

            If CantCheck = 0 Then
                MessageBox.Show("No se ha seleccionado el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If MessageBox.Show("Está seguro de cancelar envío aprobación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim objTarifa As New Tarifa
            Dim obrTarifa As New clsTarifa
            'With objTarifa
            '    .CCMPN = cboCompania.CCMPN_CodigoCompania
            '    .NRCTSL = gvTarifa.CurrentRow.Cells("NRCTSL").Value
            '    .NRTFSV = gvTarifa.CurrentRow.Cells("NRTFSV").Value
            'End With
            'obrTarifa.Cancelar_Envio_Aprobacion_tarifa(objTarifa)
            For Each item As DataGridViewRow In gvTarifa.Rows
                If item.Cells("CHK").Value = True Then
                    objTarifa = New Tarifa
                    With objTarifa
                        .CCMPN = cboCompania.CCMPN_CodigoCompania
                        .NRCTSL = item.Cells("NRCTSL").Value
                        .NRTFSV = item.Cells("NRTFSV").Value
                    End With
                    obrTarifa.Cancelar_Envio_Aprobacion_tarifa(objTarifa)
                End If
            Next

            Lista_Cotizacione_Por_Aprobar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)
        Try
            Exportar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Lista_Cotizacione_Por_Aprobar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Lista_Cotizacione_Por_Aprobar()
        gvDetTarifa.DataSource = Nothing
        Dim objTarifa As New Tarifa
        Dim obrTarifa As New clsTarifa
        With objTarifa
            .CCMPN = cboCompania.CCMPN_CodigoCompania
            .CDVSN = cboDivision.Division
            .CCLNT = txtCliente.pCodigo
            .NORSRT = CDec(Val(txtOS.Text))
        End With
        Me.gvTarifa.DataSource = obrTarifa.Lista_Cotizacion_por_Aprobar(objTarifa)
        If gvTarifa.Rows.Count <= 0 Then
            gvDetTarifa.DataSource = Nothing
        End If



    End Sub
    Private Sub dtgDetalleCotizacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvTarifa.SelectionChanged
        Try
            If Me.gvTarifa.CurrentCellAddress.Y = -1 Then Exit Sub


            Dim objTarifa As New Tarifa
            Dim obrTarifa As New clsTarifa
            With objTarifa
                .CCMPN = Me.gvTarifa.CurrentRow.Cells("CCMPN").Value
                .NRCTSL = Me.gvTarifa.CurrentRow.Cells("NRCTSL").Value
                .NRTFSV = Me.gvTarifa.CurrentRow.Cells("NRTFSV").Value
            End With

            gvDetTarifa.AutoGenerateColumns = False
            gvDetTarifa.DataSource = obrTarifa.Lista_Servicio_Mercaderia_Aprobacion(objTarifa)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Cargar_Compania()
        cboCompania.Usuario = ConfigurationWizard.UserName()
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub
    Private Sub cboCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cboCompania.SelectionChangeCommitted
        Try

            cboDivision.Usuario = ConfigurationWizard.UserName()
            cboDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cboDivision.DivisionDefault = "T"
            cboDivision.pActualizar()

            Dim division As New Ransa.Controls.UbicacionPlanta.Division.beDivision
            division.CCMPN_CodigoCompania = obeCompania.CCMPN_CodigoCompania
            division.CDVSN_CodigoDivision = cboDivision.Division


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            If gvTarifa.CurrentRow Is Nothing Then
                Exit Sub
            End If
        
            Dim idContrato As Decimal = gvTarifa.CurrentRow.Cells("NRCTSL").Value
            Dim idTarifa As Decimal = gvTarifa.CurrentRow.Cells("NRTFSV").Value
            Dim CodCompania As String = gvTarifa.CurrentRow.Cells("CCMPN").Value

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gvTarifa.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pNroImagen = gvTarifa.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZSC03



            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZSC03", "02")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZSC03(CodCompania, idContrato, idTarifa)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                gvTarifa.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    gvTarifa.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    gvTarifa.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            pCheck = Not pCheck
            gvTarifa.EndEdit()
            For Each item As DataGridViewRow In gvTarifa.Rows
                item.Cells("CHK").Value = pCheck
            Next
            gvTarifa.EndEdit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class