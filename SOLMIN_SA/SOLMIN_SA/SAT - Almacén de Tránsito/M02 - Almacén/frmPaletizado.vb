Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TypeDef.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports Ransa.NEGO
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen
Imports Ransa.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports Ransa.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports Ransa.TypeDef
Imports Ransa.Utilitario
Public Class frmPaletizado
    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Public Lista As List(Of beCliente)
    Public objCliente As beCliente
    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private Sub frmPaletizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

       
            Dim intTemp As Int64 = 0


            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtClient.pCargar(ClientePK)

            kdgvBultos.AutoGenerateColumns = False
            dgvPaletizado.AutoGenerateColumns = False



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub
    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub
   

   
 
    Private Sub HabilitarBotones(ByVal Habilitar As Boolean)
        tsbBuscar.Enabled = Habilitar
        tsbExportarExcel.Enabled = Habilitar
    End Sub

    
    Private Sub Listar_Paletizado()


        Dim obeFiltro As New bePreDespacho
        Dim obrConsultarAT As New brPreDespachoBulto
        Dim dstTemp As DataSet = Nothing
        Dim oDtExcel As New DataTable

        If txtClient.pCodigo = 0 Then Exit Sub
        With obeFiltro
            .PNCCLNT = txtClient.pCodigo

            If txtBulto.Text.Trim <> "" Or txtPaletizado.Text.Trim <> "" Then
                .PSCREFFW = txtBulto.Text.Trim
                .PSNRPLTS = txtPaletizado.Text.Trim
                .PNFECHAINI = 0
                .PNFECHAFIN = 0
            Else
                .PNFECHAINI = dteFechaInicial.Value.ToString("yyyyMMdd")
                .PNFECHAFIN = dteFechaFinal.Value.ToString("yyyyMMdd")
            End If

            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        End With
        Dim dt As New DataTable
        Dim totpag As Decimal = 0

        kdgvBultos.DataSource = Nothing

        dt = obrConsultarAT.Listar_Paletizados_Todos(obeFiltro, UcPaginacion1.PageNumber, UcPaginacion1.PageSize, totpag)
        dgvPaletizado.DataSource = dt
        UcPaginacion1.PageCount = totpag

    End Sub
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtClient.pCodigo = 0 Then
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        End If

       
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
    
    'Private Sub ExportarExcelBulto(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
    '    Dim oDt As New DataTable
    '    Dim oDtIng As New DataTable
    '    Dim oDtResumen As New DataTable
    '    Dim NPOI As New HelpClass_NPOI_SA
    '    oDt = oDtExcel.Copy
    '    Dim oDs As New DataSet

    '    If resultado = "E" Then
    '        Dim oDtv2 As DataView = New DataView(oDtExcel)
    '        Dim oDt2 As New DataTable
    '        Dim oDtFiltro As New DataTable
    '        Dim oDr As DataRow

    '        oDt2 = oDtv2.ToTable(True)

    '        oDtResumen.Columns.Add("NRO_PRESDPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("FPREDESPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("NRPLTS", Type.GetType("System.String")).Caption = NPOI.FormatDato("Paletizado", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("Bulto", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("TOPO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Tipo", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("ULEPRD", Type.GetType("System.String")).Caption = NPOI.FormatDato("Usuario Lectura", HelpClass_NPOI_SA.keyDatoTexto)

    '        oDtResumen.Columns.Add("F_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Ini. Lect", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("H_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Ini Lect", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("FLAG_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Lectura", HelpClass_NPOI_SA.keyDatoTexto)

    '        For i As Integer = 0 To oDt2.Rows.Count - 1
    '            oDr = oDtResumen.NewRow()
    '            oDr("NRO_PRESDPACHO") = oDt2.Rows(i).Item("NRO_PRESDPACHO")
    '            oDr("FPREDESPACHO") = oDt2.Rows(i).Item("FPREDESPACHO")
    '            oDr("NRPLTS") = oDt2.Rows(i).Item("NRPLTS")
    '            oDr("CREFFW") = oDt2.Rows(i).Item("CREFFW")
    '            oDr("TOPO") = oDt2.Rows(i).Item("TOPO")

    '            oDr("ULEPRD") = oDt2.Rows(i).Item("ULEPRD")
    '            oDr("F_LECT") = oDt2.Rows(i).Item("F_LECT")
    '            oDr("H_LECT") = oDt2.Rows(i).Item("H_LECT")
    '            oDr("FLAG_LECT") = oDt2.Rows(i).Item("FLAG_LECT")
    '            oDtResumen.Rows.Add(oDr)
    '        Next

    '        oDtResumen.TableName = "Resumen"
    '        oDs.Tables.Add(oDtResumen)

    '        Dim strlTitulo2 As New List(Of String)
    '        Dim oListDtReport As New List(Of DataTable)

    '        oListDtReport.Add(oDtResumen)
    '        strlTitulo2.Add("INFORME DE PREDESPACHO - BULTO")

    '        Dim LisFiltros As New List(Of SortedList)
    '        Dim itemSortedList As SortedList
    '        itemSortedList = New SortedList
    '        itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
    '        LisFiltros.Add(itemSortedList)

    '        NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, Nothing)
    '    ElseIf resultado = "G" Then
    '        dgvPaletizado.AutoGenerateColumns = False
    '        dgvPaletizado.DataSource = oDt
    '    End If
    'End Sub
    'Private Sub ExportarExcelPreDespacho(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
    '    Dim oDt As New DataTable
    '    Dim oDtIng As New DataTable
    '    Dim oDtResumen As New DataTable
    '    Dim NPOI As New HelpClass_NPOI_SA
    '    oDt = oDtExcel.Copy
    '    Dim oDs As New DataSet

    '    If resultado = "E" Then
    '        Dim oDtv2 As DataView = New DataView(oDtExcel)
    '        Dim oDt2 As New DataTable
    '        Dim oDtFiltro As New DataTable
    '        Dim oDr As DataRow

    '        oDt2 = oDtv2.ToTable(True)
    '        oDtResumen.Columns.Add("NRO_PRESDPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("FPREDESPACHO", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha PreDespacho", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("USU_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Usuario Lectura", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("FINI_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Ini. Lect.", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("HINI_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Ini Lect.", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("FFIN_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Fecha Fin Lect.", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("HFIN_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Hora Fin Lect.", HelpClass_NPOI_SA.keyDatoTexto)
    '        oDtResumen.Columns.Add("PEND_LECT", Type.GetType("System.String")).Caption = NPOI.FormatDato("Pendiente Lectura", HelpClass_NPOI_SA.keyDatoTexto)

    '        For i As Integer = 0 To oDt2.Rows.Count - 1
    '            oDr = oDtResumen.NewRow()
    '            oDr("NRO_PRESDPACHO") = oDt2.Rows(i).Item("NRO_PRESDPACHO")
    '            oDr("FPREDESPACHO") = oDt2.Rows(i).Item("FPREDESPACHO")
    '            oDr("USU_LECT") = oDt2.Rows(i).Item("USU_LECT")
    '            oDr("FINI_LECT") = oDt2.Rows(i).Item("FINI_LECT")
    '            oDr("HINI_LECT") = oDt2.Rows(i).Item("HINI_LECT")
    '            oDr("FFIN_LECT") = oDt2.Rows(i).Item("FFIN_LECT")
    '            oDr("HFIN_LECT") = oDt2.Rows(i).Item("HFIN_LECT")
    '            oDr("PEND_LECT") = oDt2.Rows(i).Item("PEND_LECT")
    '            oDtResumen.Rows.Add(oDr)
    '        Next

    '        oDtResumen.TableName = "Resumen"
    '        oDs.Tables.Add(oDtResumen)

    '        Dim strlTitulo2 As New List(Of String)
    '        Dim oListDtReport As New List(Of DataTable)
    '        oListDtReport.Add(oDtResumen)
    '        strlTitulo2.Add("INFORME DE PREDESPACHO")

    '        Dim LisFiltros As New List(Of SortedList)
    '        Dim itemSortedList As SortedList
    '        itemSortedList = New SortedList
    '        itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
    '        LisFiltros.Add(itemSortedList)

    '        NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, Nothing)

    '    End If
    'End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            If fblnValidaInformacion() Then
                Listar_Paletizado()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    'Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
    '    Try
    '        Dim oDtExcel As New DataTable

    '        ExportarExcelBulto(objTemp.Tables(0), "E", Nothing)


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar_Paletizado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgBulto_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPaletizado.SelectionChanged
        Try
            Dim obrConsultarAT As New brPreDespachoBulto
            Dim dt As New DataTable
            Dim obeFiltro As New bePreDespacho
            With obeFiltro
                .PNCCLNT = dgvPaletizado.CurrentRow.Cells("CCLNT").Value
                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCPLNDV = dgvPaletizado.CurrentRow.Cells("CPLNDV").Value
                .PNNROPLT = dgvPaletizado.CurrentRow.Cells("NROPLT").Value
                .PNNSEQIN = dgvPaletizado.CurrentRow.Cells("NSEQIN").Value
            End With

            dt = obrConsultarAT.Listar_Bultos_X_DetPaletizado(obeFiltro)
            kdgvBultos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            If dgvPaletizado.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim pCCLNT As String = dgvPaletizado.CurrentRow.Cells("CCLNT").Value
            Dim pNROPLT As Decimal = dgvPaletizado.CurrentRow.Cells("NROPLT").Value

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaAdjuntos.pNroImagen = dgvPaletizado.CurrentRow.Cells("NMRGIM_S").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            'ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65P
            'ofrmCargaAdjuntos.pAsignarCargaMotivo("RZST07", "01")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65P(pCCLNT, pNROPLT)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                dgvPaletizado.CurrentRow.Cells("NMRGIM_S").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dgvPaletizado.CurrentRow.Cells("NMRGIM_IMG_S").Value = "X"
                Else
                    dgvPaletizado.CurrentRow.Cells("NMRGIM_IMG_S").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAdjuntoBulto_Click(sender As Object, e As EventArgs) Handles btnAdjuntoBulto.Click
        Try
            If dgvPaletizado.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim pCCLNT As String = dgvPaletizado.CurrentRow.Cells("CCLNT").Value
            'Dim pNROPLT As Decimal = dgvPaletizado.CurrentRow.Cells("NROPLT").Value
            Dim pCCMPN As String = ("" & dgvPaletizado.CurrentRow.Cells("CCMPN").Value).ToString.Trim
            Dim pCDVSN As String = ("" & dgvPaletizado.CurrentRow.Cells("CDVSN").Value).ToString.Trim
            Dim pCOD_BULTO As String = ("" & kdgvBultos.CurrentRow.Cells("COD_BULTO").Value).ToString.Trim



            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            ofrmCargaAdjuntos.pNroImagen = kdgvBultos.CurrentRow.Cells("NMRGIM_B").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            'ofrmCargaAdjuntos.pbucket_slmnsmp_2021 = True 'comentado en 2021 setiembre(nuevo bucket)
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZOL65I
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZOL65I(pCCMPN, pCDVSN, pCCLNT, pCOD_BULTO)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                kdgvBultos.CurrentRow.Cells("NMRGIM_B").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    kdgvBultos.CurrentRow.Cells("NMRGIM_IMG_B").Value = "X"
                Else
                    kdgvBultos.CurrentRow.Cells("NMRGIM_IMG_B").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub tsbExportarExcel_Click(sender As Object, e As EventArgs) Handles tsbExportarExcel.Click
        Try
            Dim obrConsultarAT As New brPreDespachoBulto
            Dim dtResult As New DataTable
            Dim obeFiltro As New bePreDespacho
            With obeFiltro
                .PNCCLNT = dgvPaletizado.CurrentRow.Cells("CCLNT").Value
                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCPLNDV = dgvPaletizado.CurrentRow.Cells("CPLNDV").Value
                .PNNROPLT = dgvPaletizado.CurrentRow.Cells("NROPLT").Value
                .PNNSEQIN = dgvPaletizado.CurrentRow.Cells("NSEQIN").Value
            End With
            dtResult = obrConsultarAT.Listar_Bultos_X_Det_Formato01_Paletizado(obeFiltro)


            Dim Paletizado As String = ""
            Dim FechaPaletizado As String = ""
            Dim Cliente As String = ""
            Dim Planta As String = ""
            If dtResult.Rows.Count > 0 Then
                Paletizado = dtResult.Rows(0)("NRPLTS")
                FechaPaletizado = dtResult.Rows(0)("FELPLT")
                Cliente = dtResult.Rows(0)("TCMPCL")
                Planta = dtResult.Rows(0)("TPLNTA")

            End If
 

            Dim ListaDatatable As New List(Of DataTable)
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim MdataColumna As String = ""

            Dim oLisBulto As New Hashtable
            Dim CodBulto As String = ""
            For Each row As DataRow In dtResult.Rows
                CodBulto = ("" & row("COD_BULTO")).ToString.Trim
                If oLisBulto.Contains(CodBulto) Then
                    row("COD_BULTO") = ""
                    row("FREFFW") = ""
                    row("CANT_BULTOS") = DBNull.Value
                    row("TIPO_UNIDAD") = ""
                    row("QPSOBL") = DBNull.Value
                Else
                    oLisBulto(CodBulto) = CodBulto
                End If
            Next

      

            Dim dtReporte As New DataTable
            Dim oDs As New DataSet
    

            dtReporte.Columns.Add("COD_BULTO")
            dtReporte.Columns.Add("FREFFW")
            dtReporte.Columns.Add("CANT_BULTOS")
            dtReporte.Columns.Add("TIPO_UNIDAD")
            dtReporte.Columns.Add("QPSOBL")
            dtReporte.Columns.Add("NORCML")
            dtReporte.Columns.Add("NGRPRV")
            dtReporte.Columns.Add("TPRVCL")


            dtReporte.Columns("COD_BULTO").Caption = NPOI_SC.FormatDato("Bulto", NPOI_SC.keyDatoTexto)
            dtReporte.Columns("FREFFW").Caption = NPOI_SC.FormatDato("Fecha Recep.", NPOI_SC.keyDatoFecha)
            dtReporte.Columns("CANT_BULTOS").Caption = NPOI_SC.FormatDato("Cant. Bultos", NPOI_SC.keyDatoNumero)
            dtReporte.Columns("TIPO_UNIDAD").Caption = NPOI_SC.FormatDato("Tipo", NPOI_SC.keyDatoTexto)
            dtReporte.Columns("QPSOBL").Caption = NPOI_SC.FormatDato("Peso", NPOI_SC.keyDatoNumero)          
            dtReporte.Columns("NORCML").Caption = NPOI_SC.FormatDato("Orden Compra", NPOI_SC.keyDatoTexto)
            dtReporte.Columns("NGRPRV").Caption = NPOI_SC.FormatDato("Guía Remisión Prov.", NPOI_SC.keyDatoTexto)
            dtReporte.Columns("TPRVCL").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)


            For Each row As DataRow In dtResult.Rows
                Dim drow As DataRow
                drow = dtReporte.NewRow
                For Each col As DataColumn In dtReporte.Columns
                    drow(col.ColumnName) = row(col.ColumnName)
                Next
                dtReporte.Rows.Add(drow)
            Next

           
            dtReporte.TableName = "Paletizado"
            'oDs.Tables.Add(dtReporte)


            ListaDatatable.Add(dtReporte.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            Dim ListTitulo As New List(Of String)
            itemSortedList = New SortedList

           
            Dim strlTitulo As New List(Of String)
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & Cliente)
            itemSortedList.Add(itemSortedList.Count, "Planta:|" & Planta)
            itemSortedList.Add(itemSortedList.Count, "Paletizado:|" & Paletizado)
            itemSortedList.Add(itemSortedList.Count, "Fecha paletizado:|" & FechaPaletizado)


            LisFiltros.Add(itemSortedList)

            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String = ""
            ListNameCombDuplicado.Add(CombCol)


            ListTitulo.Add("PALETIZADO")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class