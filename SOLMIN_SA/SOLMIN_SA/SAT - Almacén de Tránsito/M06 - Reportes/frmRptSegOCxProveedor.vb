Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Procesos

Imports RANSA.Utilitario

Public Class frmRptSegOCxProveedor

#Region "Declaracion de variables"
    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Private DtReporte As DataTable
    Private DtResumen As DataTable
    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean
#End Region

#Region "Procedimientos y Funciones"

    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        'Case "O01"*****************************
        pReporteSegOCSegunFechaEntrega()
        strDetalleReporte = "Seguimiento O/C por Proveedor"
    End Sub

    Private Sub mtoDtFormater(ByVal cpoDataTable As DataTable)

        cpoDataTable.Columns.Add("Proveedor", GetType(String))
        cpoDataTable.Columns.Add("Ruc", GetType(String))
        cpoDataTable.Columns.Add("OrdenCompra", GetType(Integer))
        cpoDataTable.Columns.Add("DiasAtraso", GetType(String))
        cpoDataTable.Columns.Add("Cambios", GetType(String))


    End Sub

    Private Sub pReporteSegOCSegunFechaEntrega()
        DtReporte = New DataTable
        DtResumen = New DataTable
        Dim obrAlmacenSat As New clsAlmacen(objSeguridadBN.pUsuario)
        Dim strTemp As String = ""
        Dim objFiltro As TD_Qry_SegOC_L01 = New TD_Qry_SegOC_L01
        Dim objReporte As New rptIndicadorTiempoEntregaProveedor
        ' Filtros
        With objFiltro
            .pCCMPN_Compania = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .pCDVSN_Division = UcDivision_Cmb011.Division
            .pCPLNDV_Planta = UcPLanta_Cmb011.Planta
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pCPRVCL_Proveedor = txtProveedor.pCodigo
            .pNORCML_NroOrdenCompra = txtOrdenCompra.Text
            .pTTINTC_TermInterCarga = cmbTermInter.pInformacionSelec.pCCMPRN_Codigo
            If a Then .pFORCMI_FechaOCInicial = dteFechaInicial.Value
            If b Then .pFORCMF_FechaOCFinal = dteFechaFinal.Value
            If c Then .pFMPDMI_FechaCompInicial = dteFechaCompInicial.Value
            If d Then .pFMPDMF_FechaCompFinal = dteFechaCompFinal.Value
            .pSTATOC_StatusOC = cmbSituacionOC.pInformacionSelec.pCCMPRN_Codigo



            If .pFORCMI_FechaOCInicial_Int > 0 And .pFORCMF_FechaOCFinal_Int > 0 Then
                strTemp = " FECHA EMISION O/C:  Desde " & .pFORCMI_FechaOCInicial.ToString("dd/MM/yyyy") & " Hasta " & .pFORCMF_FechaOCFinal.ToString("dd/MM/yyyy")
            Else
                If .pFORCMI_FechaOCInicial_Int > 0 Then
                    strTemp = " FECHA EMISION O/C:  Desde " & .pFORCMI_FechaOCInicial.ToString("dd/MM/yyyy")
                End If
                If .pFORCMF_FechaOCFinal_Int > 0 Then
                    strTemp = " FECHA EMISION O/C:  Hasta " & .pFORCMF_FechaOCFinal.ToString("dd/MM/yyyy")
                End If
            End If
            If .pFMPDMI_FechaCompInicial_Int > 0 And .pFMPDMF_FechaCompFinal_Int > 0 Then
                If strTemp <> "" Then strTemp &= vbNewLine
                strTemp &= " FECHA DE ENTREGA:  Desde " & .pFMPDMI_FechaCompInicial.ToString("dd/MM/yyyy") & " Hasta " & .pFMPDMF_FechaCompFinal.ToString("dd/MM/yyyy")
            Else
                If .pFMPDMI_FechaCompInicial_Int > 0 Then
                    If strTemp <> "" Then strTemp &= vbNewLine
                    strTemp &= " FECHA DE ENTREGA:  Desde " & .pFMPDMI_FechaCompInicial.ToString("dd/MM/yyyy")
                End If
                If .pFMPDMF_FechaCompFinal_Int > 0 Then
                    If strTemp <> "" Then strTemp &= vbNewLine
                    strTemp &= " FECHA DE ENTREGA:  Hasta " & .pFMPDMF_FechaCompFinal.ToString("dd/MM/yyyy")
                End If
            End If

        End With


        DtReporte = obrAlmacenSat.frptIndicadorTiempoEntregaProveedor(objFiltro)

        'Generacion de tabla resumen

        Dim nOrdenCompra As Integer = 0
        Dim nDiaAtraso As Integer = 0
        Dim nCambios As Integer = 0
        Dim nTotalDiaAtraso As Decimal = 0
        Dim nTotalCambios As Decimal = 0
        Dim nCountdias As Integer = 0
        Dim blExisteProveedor As Boolean = False
        Dim strOrdenCompra As String = String.Empty
        Dim drResumen As DataRow
        mtoDtFormater(DtResumen)

        For Each dr As DataRow In DtReporte.Rows
            nOrdenCompra = 0
            nDiaAtraso = 0
            nCambios = 0
            nCountdias = 0
            nTotalDiaAtraso = 0
            nTotalCambios = 0
            strOrdenCompra = String.Empty
            blExisteProveedor = False

            For Each drAux As DataRow In DtResumen.Select("Proveedor = '" & ("" & dr("TPRVCL")) & "'")
                blExisteProveedor = True
            Next


            If blExisteProveedor Then
                Continue For
            Else


                For Each drAux As DataRow In DtReporte.Select("ISNULL(TPRVCL,'') = '" & ("" & dr("TPRVCL")) & "'")

                    If drAux("NORCML").ToString.Trim <> strOrdenCompra Then
                        nOrdenCompra = nOrdenCompra + 1
                    End If
                    nDiaAtraso = nDiaAtraso + IIf(drAux("NDIATR") > 0, drAux("NDIATR"), 0)
                    nCambios = nCambios + drAux("MOV_FECHAS")

                    nCountdias = nCountdias + 1

                    strOrdenCompra = drAux("NORCML").ToString.Trim
                Next
                nTotalDiaAtraso = nDiaAtraso / nCountdias
                nTotalCambios = nCambios / nCountdias

                drResumen = DtResumen.NewRow()
                drResumen("Proveedor") = ("" & dr("TPRVCL"))
                drResumen("Ruc") = ("" & dr("NRUCPR"))
                drResumen("OrdenCompra") = nOrdenCompra
                drResumen("DiasAtraso") = IIf(nTotalDiaAtraso.ToString.IndexOf(".") > 0, nTotalDiaAtraso.ToString("N1"), nTotalDiaAtraso)
                drResumen("Cambios") = IIf(nTotalCambios.ToString.IndexOf(".") > 0, nTotalCambios.ToString("N1"), nTotalCambios)

                DtResumen.Rows.Add(drResumen)

            End If


        Next

        'Fin de generacion de tabla resumen'

        DtReporte.TableName = "SegOCPorFechaEntrega"
        DtResumen.TableName = "ResumenSegOCProveedor"
        objReporte.SetDataSource(DtReporte)

        objReporte.Subreports(0).SetDataSource(DtResumen)

        objReporte.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
        objReporte.SetParameterValue("pRangoFecha", strTemp)


        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = objReporte


    End Sub

    Private Sub ExportarExcelOC()
        Dim oDs As New DataSet
        Dim oDt As New DataTable
        Dim oDtResumen As New DataTable

        oDt = DtReporte.Copy
        oDtResumen = DtResumen.Copy
        oDt.TableName = "SeguimientoOCProveedor"
        oDtResumen.TableName = "Resumen"

        oDt.Columns.Remove("CCLNT")
        oDt.Columns.Remove("NRUCPR")
        oDt.Columns.Remove("TCMPCL")
        oDt.Columns.Remove("CPRVCL")

        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("TIPO_DOC").ColumnName = "TIPO DE DOCUMENTO"
        oDt.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL "
        oDt.Columns("TLUGEN").ColumnName = "LOTE"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TDITES").ColumnName = "DETALLE"
        oDt.Columns("QCNTIT").ColumnName = "QTA O/C"
        oDt.Columns("FMPIME").ColumnName = "FECHA PROMETIDA DE ENTREGA"
        oDt.Columns("FMPDME").ColumnName = "FECHA POSIBLE ENTREGA"
        oDt.Columns("NDIATR").ColumnName = "DIAS ATRASO"
        oDt.Columns("MOV_FECHAS").ColumnName = "CANT. CAMBIOS"
        oDt.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
        oDt.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
        oDt.Columns("STFREC").ColumnName = "STATUS RECEPCION"
        oDt.Columns("STFENT").ColumnName = "STATUS ENTREGA"
        oDs.Tables.Add(oDt)

        oDtResumen.Columns("Proveedor").ColumnName = "RAZÓN SOCIAL"
        oDtResumen.Columns("Ruc").ColumnName = "RUC"
        oDtResumen.Columns("OrdenCompra").ColumnName = "CANT. ORDEN COMPRA"
        oDtResumen.Columns("DiasAtraso").ColumnName = "PROMEDIO DIAS ATRASO"
        oDtResumen.Columns("Cambios").ColumnName = "PROMEDIO CAMBIOS"
        oDs.Tables.Add(oDtResumen)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If Me.txtOrdenCompra.Text = "" Then
            strlTitulo.Add("Nro. O/C :\nTODOS")
        Else
            strlTitulo.Add("Nro. O/C :\n" & Me.txtOrdenCompra.Text)
        End If
        If Me.txtProveedor.pCodigo = 0 Then
            strlTitulo.Add("Proveedor :\nTODOS")
        Else
            strlTitulo.Add("TProveedor :\n" & Me.txtProveedor.pRazonSocial)
        End If

        If cmbSituacionOC.pInformacionSelec.pCCMPRN_Codigo = "" Then
            strlTitulo.Add("Status :\nTODOS")
        Else
            strlTitulo.Add("Status :\n" & cmbSituacionOC.pInformacionSelec.pTDSDES_Detalle)
        End If

        If cmbTermInter.pInformacionSelec.pCCMPRN_Codigo = "" Then
            strlTitulo.Add("Térm. Inter.:\nTODOS")
        Else
            strlTitulo.Add("Térm. Inter.:\n" & cmbTermInter.pInformacionSelec.pTDSDES_Detalle)
        End If
        strlTitulo.Add("Fecha reg. Orden de Compra:\n" & IIf(dteFechaInicial.Checked, dteFechaInicial.Value.Date, "") & " - " & IIf(dteFechaFinal.Checked, dteFechaFinal.Value.Date, ""))
        strlTitulo.Add("Fecha Comprometida Entrega:\n" & IIf(dteFechaCompInicial.Checked, dteFechaCompInicial.Value.Date, "") & " - " & IIf(dteFechaCompFinal.Checked, dteFechaCompFinal.Value.Date, ""))


        HelpClass.ExportExcelConTitulos(oDs, strlTitulo)
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Return blnResultado
    End Function


#End Region

#Region "Eventos de Control"

    Private Sub frmRptSegOCxFechaEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        'tsbAmpliar.Image = pbxAmpliar.Image
        dteFechaInicial.Value = Now
        dteFechaInicial.Checked = False
        dteFechaFinal.Value = Now
        dteFechaFinal.Checked = False
        dteFechaCompInicial.Value = Now
        dteFechaCompFinal.Value = Now
        objAppConfig = Nothing
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

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        If fblnValidaInformacion() Then
            pcxEspera.Visible = True
            pcxEspera.Left = (KryptonHeaderGroup2.Width / 2) - (pcxEspera.Width / 2)
            pcxEspera.Top = (KryptonHeaderGroup2.Height / 2) - (pcxEspera.Height / 2)
            tsbExportarPDF.Enabled = False
            tsbEnviarCorreo.Enabled = False
            tsbExportarExcel.Enabled = False
            btnGenerarReporte.Enabled = False
            crvReporte.Visible = False
            a = dteFechaInicial.Checked
            b = dteFechaFinal.Checked
            c = dteFechaCompInicial.Checked
            d = dteFechaCompFinal.Checked

            bgwGifAnimado.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGenerarReporte()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        btnGenerarReporte.Enabled = True
        tsbExportarPDF.Enabled = True
        tsbEnviarCorreo.Enabled = True
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarPDF.Click
        Dim dlgSavePDF As SaveFileDialog = New SaveFileDialog
        dlgSavePDF.Filter = "Adobe Acrobat PDF (*.pdf)|*.pdf"
        dlgSavePDF.CheckPathExists = True
        If dlgSavePDF.ShowDialog = Windows.Forms.DialogResult.OK Then
            objTemp.pReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dlgSavePDF.FileName)
        End If
        dlgSavePDF.Dispose()
        dlgSavePDF = Nothing
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            ExportarExcelOC()
        Catch : End Try
    End Sub

#End Region

End Class
