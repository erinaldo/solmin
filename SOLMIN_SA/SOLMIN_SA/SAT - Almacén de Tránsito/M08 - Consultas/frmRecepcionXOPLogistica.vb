
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
'Imports RANSA.TYPEDEF.Cliente

Public Class frmRecepcionXOPLogistica

#Region "ATRIBUTOS"

    Dim dt As DataTable
    Dim ListaDatatable As List(Of DataTable)
    Dim ListaTitulos As List(Of String)
    Private blnDetalleItemChanged As Boolean = False

#End Region

#Region "EVENTOS"

    Private Sub frmRecepcionXOPLogistica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dteFechaInicial.Value = Now.AddYears(-1)
            dteFechaFinal.Value = Now
            Cargar_Compania()

            ' ConfigurationAppSettings As New System.Configuration.AppSettingsReader
            Dim objAppConfig As cAppConfig = New cAppConfig

            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("RecepcionClienteCodigo", GetType(System.String)), intTemp)
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtClient.pCargar(ClientePK)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Divisiones(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar

        Try

            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Plantas(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar

        Try
            cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try
            Dim oDs As New DataSet
            Dim dt As New DataTable

            Dim objEntidad As New beBulto
            Dim objNegocio As New brBulto


            Dim NPOI As New HelpClass_NPOI_ST
            NPOI = New Ransa.Utilitario.HelpClass_NPOI_ST

            If Valida.ToString.Trim.Length > 0 Then
                MessageBox.Show(Valida.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            With objEntidad
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                If cmbPlanta.SelectedValue = "0" Then
                    .PNCPLNDV = -1
                Else
                    .PNCPLNDV = CDec(cmbPlanta.SelectedValue)
                End If
                .PSTIPO = IIf(chkRecepcion.Checked = True, "I", "S")
                .PNCCLNT = txtClient.pCodigo
                .PSCREFFW = txtCodigoRecepcion.Text
                .FECHA_INI = CInt(HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date))
                .FECHA_FIN = CInt(HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date))
            End With

            dt = objNegocio.listaExportarRecepcionXFechaOperadorLogistico(objEntidad)

            If dt.Rows.Count > 0 Then

                Dim dtExcel As New DataTable
                Dim dr As DataRow

                dtExcel.Columns.Add("TPLNTA").Caption = NPOI.FormatDato("Planta", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("CREFFW").Caption = NPOI.FormatDato("Bulto", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("DESCWB").Caption = NPOI.FormatDato("Descripción", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("FREFFW").Caption = NPOI.FormatDato("Fecha Ingreso", HelpClass_NPOI_ST.keyDatoFecha)
                dtExcel.Columns.Add("FINGAL").Caption = NPOI.FormatDato("Fecha Ingreso Operador Logistico", HelpClass_NPOI_ST.keyDatoFecha)
                dtExcel.Columns.Add("NORCML").Caption = NPOI.FormatDato("Orden de compra", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TPRVCL").Caption = NPOI.FormatDato("Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("NGRPRV").Caption = NPOI.FormatDato("Guía Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("SMTRCP").Caption = NPOI.FormatDato("Motivo recepción", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("CTPALM").Caption = NPOI.FormatDato("Tipo almacén", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("CALMC").Caption = NPOI.FormatDato("Almacén", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("CZNALM").Caption = NPOI.FormatDato("Zona", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TUBRFR").Caption = NPOI.FormatDato("Ubicación", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("SSNCRG").Caption = NPOI.FormatDato("Sentido carga", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("QREFFW").Caption = NPOI.FormatDato("Cantidad recibida", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TIPBTO").Caption = NPOI.FormatDato("Tipo", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("QPSOBL").Caption = NPOI.FormatDato("Peso", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TUNPSO").Caption = NPOI.FormatDato("Und. Peso", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("QVLBTO").Caption = NPOI.FormatDato("Volumen", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TUNVOL").Caption = NPOI.FormatDato("Und. Volumen", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("QAROCP").Caption = NPOI.FormatDato("Area Ocupada mt2", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("NTCKPS").Caption = NPOI.FormatDato("Nro. Ticket", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TLUGEN").Caption = NPOI.FormatDato("Lote", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TNMMDT").Caption = NPOI.FormatDato("Medio sugerido", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("CONFIR").Caption = NPOI.FormatDato("Medio Confirmado", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TCTCST").Caption = NPOI.FormatDato("Imp. Terrestre", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TCTCSA").Caption = NPOI.FormatDato("Imp. Áereo", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("TCTCSF").Caption = NPOI.FormatDato("Imp. Fluvial", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("FSLFFW").Caption = NPOI.FormatDato("Fecha Salida", HelpClass_NPOI_ST.keyDatoFecha)
                dtExcel.Columns.Add("FSLDAL").Caption = NPOI.FormatDato("Fecha Salida Operador Logistico", HelpClass_NPOI_ST.keyDatoFecha)
                dtExcel.Columns.Add("NGUIRM").Caption = NPOI.FormatDato("Nro. Guía", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("FLGCNL").Caption = NPOI.FormatDato("Estado transito", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("SSTINV").Caption = NPOI.FormatDato("Estado", HelpClass_NPOI_ST.keyDatoTexto)
                dtExcel.Columns.Add("DIAS_CL").Caption = NPOI.FormatDato("Nro. días C.L", HelpClass_NPOI_ST.keyDatoNumero)
                dtExcel.Columns.Add("DIAS_OL").Caption = NPOI.FormatDato("Nro. días O.L", HelpClass_NPOI_ST.keyDatoNumero)

                For Each inc As DataRow In dt.Rows
                    dr = dtExcel.NewRow
                    dr("TPLNTA") = inc("TPLNTA")
                    dr("CREFFW") = inc("CREFFW")
                    dr("DESCWB") = inc("DESCWB")
                    dr("FREFFW") = inc("FREFFW").ToString
                    dr("FINGAL") = inc("FINGAL").ToString
                    dr("NORCML") = inc("NORCML")
                    dr("TPRVCL") = inc("TPRVCL")
                    dr("NGRPRV") = inc("NGRPRV")
                    dr("SMTRCP") = inc("SMTRCP")
                    dr("CTPALM") = inc("CTPALM")
                    dr("CALMC") = inc("CALMC")
                    dr("CZNALM") = inc("CZNALM")
                    dr("TUBRFR") = inc("TUBRFR")
                    dr("SSNCRG") = inc("SSNCRG")
                    dr("QREFFW") = inc("QREFFW")
                    dr("TIPBTO") = inc("TIPBTO")
                    dr("QPSOBL") = inc("QPSOBL")
                    dr("TUNPSO") = inc("TUNPSO")
                    dr("QVLBTO") = inc("QVLBTO")
                    dr("TUNVOL") = inc("TUNVOL")
                    dr("QAROCP") = inc("QAROCP")
                    dr("NTCKPS") = inc("NTCKPS")
                    dr("TLUGEN") = inc("TLUGEN")
                    dr("TNMMDT") = inc("TNMMDT")
                    dr("CONFIR") = inc("CONFIR")
                    dr("TCTCST") = inc("TCTCST")
                    dr("TCTCSA") = inc("TCTCSA")
                    dr("TCTCSF") = inc("TCTCSF")
                    dr("FSLFFW") = inc("FSLFFW")
                    dr("FSLDAL") = inc("FSLDAL")
                    dr("NGUIRM") = inc("NGUIRM")
                    dr("FLGCNL") = inc("FLGCNL")
                    dr("SSTINV") = inc("SSTINV")
                    dr("DIAS_CL") = inc("DIAS_CL")
                    dr("DIAS_OL") = inc("DIAS_OL")
                    dtExcel.Rows.Add(dr)
                Next

                ListaDatatable = New List(Of DataTable)
                ListaDatatable.Add(dtExcel.Copy)

                ListaTitulos = New List(Of String)
                ListaTitulos.Add("CONSULTA DE BULTOS ÚNICOS")

                Dim oLisFiltro As New List(Of SortedList)
                Dim F As New SortedList
                F.Add(0, "COMPAÑIA:| " & UcCompania_Cmb011.CCMPN_Descripcion)
                F.Add(1, "DIVISION:|" & UcDivision_Cmb011.DivisionDescripcion)
                Dim row_data As DataRowView
                row_data = Me.cmbPlanta.SelectedItem
                F.Add(2, "PLANTA:| " & row_data("TPLNTA_DescripcionPlanta").ToString)
                F.Add(3, "CLIENTE:| " & txtClient.pRazonSocial)
                F.Add(4, "MOVIMIENTO:| " & IIf(Me.chkRecepcion.Checked = True, "RECEPCIÓN", "DESPACHO"))
                F.Add(6, "FECHA:| " & Me.dteFechaInicial.Value.Date & " - " & Me.dteFechaFinal.Value.Date)
                oLisFiltro.Add(F)

                Dim ListColumnNFilas As New List(Of String)
                ListColumnNFilas.Add("TPLNTA")

                NPOI.ExportExcelGeneralMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub hgDetalleItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hgDetalleItem.Click
        Try
            If hgDetalleItem.Width = 21 Then
                hgDetalleItem.Width = 400
                If blnDetalleItemChanged Then Call pMostrarInformacionItemBulto()
            Else
                hgDetalleItem.Width = 21
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_SubItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgBultos.SelectionChanged

        Try

            If dgBultos.CurrentRow IsNot Nothing And dgBultos.Rows.Count > 0 Then

                Dim lint_indice As Integer = Me.dgBultos.CurrentCellAddress.Y

                Dim obrBulto As New brBulto
                Dim obeBulto As New beBulto
                With obeBulto
                    .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = UcDivision_Cmb011.Division
                    .PNCPLNDV = Me.dgBultos.Item("CPLNDV", lint_indice).Value.ToString.Trim
                    .PSCREFFW = Me.dgBultos.Item("M_CREFFW", lint_indice).Value.ToString.Trim
                    .PNCCLNT = Me.dgBultos.Item("CCLNT", lint_indice).Value.ToString.Trim
                    .PNNSEQIN = Me.dgBultos.Item("M_NSEQIN", lint_indice).Value.ToString.Trim

                End With
                dgBultosDetalle.AutoGenerateColumns = False
                dgBultosDetalle.DataSource = obrBulto.ListarDetalleBulto(obeBulto)
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
                For Each oDgvrItemOC As DataGridViewRow In dgBultosDetalle.Rows
                    Dim NRSITEM As Integer = oDgvrItemOC.Cells("NRSITEM").Value
                    If NRSITEM > 0 Then
                        oDgvrItemOC.Cells("SUBITEM").Value = My.Resources.retencion
                    End If
                Next
            Else

                dgBultosDetalle.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgBultosDetalle_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgBultosDetalle.CurrentCellChanged
        Try
            hgDetalleItem.Width = 21
            blnDetalleItemChanged = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
    End Sub

#End Region

#Region "METODOS"

    Private Sub cargarComboPlanta()

        Dim objLisEntidad As New List(Of Ransa.Controls.UbicacionPlanta.Planta.bePlanta)
        Dim objLisEntidad2 As New List(Of Ransa.Controls.UbicacionPlanta.Planta.bePlanta)
        Dim objLogica As New Ransa.Controls.UbicacionPlanta.Planta.brPlanta
        cmbPlanta.Text = ""
        Try

            If (UcCompania_Cmb011.CCMPN_CodigoCompania IsNot Nothing And UcDivision_Cmb011.Division IsNot Nothing) Then
                objLogica.Crea_Lista(objSeguridadBN.pUsuario)
                objLisEntidad2 = objLogica.Lista_Planta_X_Usuario(UcCompania_Cmb011.CCMPN_CodigoCompania, UcDivision_Cmb011.Division)

                dt = New DataTable
                Dim dr As DataRow

                dt.Columns.Add("CPLNDV_CodigoPlanta")
                dt.Columns.Add("TPLNTA_DescripcionPlanta")
                Dim objEntidad2 As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta

                For Each objEntidad2 In objLisEntidad2
                    dr = dt.NewRow
                    dr("CPLNDV_CodigoPlanta") = objEntidad2.CPLNDV_CodigoPlanta
                    dr("TPLNTA_DescripcionPlanta") = objEntidad2.TPLNTA_DescripcionPlanta
                    dt.Rows.Add(dr)
                Next

                dr = dt.NewRow
                dr("CPLNDV_CodigoPlanta") = "0"
                dr("TPLNTA_DescripcionPlanta") = "TODOS"

                dt.Rows.InsertAt(dr, 0)
                cmbPlanta.DisplayMember = "TPLNTA_DescripcionPlanta"
                cmbPlanta.ValueMember = "CPLNDV_CodigoPlanta"
                Me.cmbPlanta.DataSource = dt
                cmbPlanta.SelectedValue = "0"

            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub Cargar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Function Valida() As String
        Dim mensaje As String = ""
        If txtClient.pCodigo = 0D Then
            mensaje = mensaje & " * Seleccione un cliente"
        End If
        Return mensaje
    End Function

    Sub Buscar()

        If Valida.ToString.Trim.Length > 0 Then
            MessageBox.Show(Valida, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim objEntidad As New beBulto
        Dim objNegocio As New brBulto

        dgBultos.AutoGenerateColumns = False

        With objEntidad
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
            If cmbPlanta.SelectedValue = "0" Then
                .PNCPLNDV = -1
            Else
                .PNCPLNDV = CDec(cmbPlanta.SelectedValue)
            End If
            .PSTIPO = IIf(chkRecepcion.Checked = True, "I", "S")
            .PNCCLNT = txtClient.pCodigo
            .PSCREFFW = txtCodigoRecepcion.Text
            .FECHA_INI = CInt(HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value.Date))
            .FECHA_FIN = CInt(HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value.Date))
            .PageNumber = UcPaginacion.PageNumber
            .PageSize = UcPaginacion.PageSize
        End With

        Dim NumPaginas As Integer = 0
        dgBultos.DataSource = objNegocio.listaRecepcionXFechaOperadorLogistico(objEntidad, NumPaginas)

        If dgBultos.Rows.Count > 0 Then
            UcPaginacion.PageCount = NumPaginas
        End If

    End Sub

    Private Sub pMostrarInformacionItemBulto()
        If dgBultosDetalle.CurrentRow Is Nothing Then
            txtInformacionItemBulto.Text = ""
            Exit Sub
        End If
        Dim obrBulto As New brBulto
        txtInformacionItemBulto.Text = obrBulto.fstrInformacionItemBulto(dgBultosDetalle.CurrentRow.DataBoundItem)
    End Sub

   
#End Region

  
End Class
