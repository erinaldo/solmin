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

Public Class frmRptSegOCxFechaEntrega

#Region "Declaracion de Variables"
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

#Region "Procedimientos y funciones"

    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        'Case "O01"*****************************
        pReporteSegOCSegunFechaEntrega()
        strDetalleReporte = "Seguimiento O/C según Fecha Entrega"
    End Sub

    Private Sub mtoDtFormater(ByVal cpoDataTable As DataTable)

        cpoDataTable.Columns.Add("Proveedor", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("EnPlazo", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("Anticipado", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("Atrazado", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("PORCENTAJE", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("Cliente", System.Type.GetType("System.String"))

    End Sub

    Private Sub pReporteSegOCSegunFechaEntrega()
        DtReporte = New DataTable
        DtResumen = New DataTable
        Dim obrAlmacenSat As New clsAlmacen(objSeguridadBN.pUsuario)
        Dim strTemp As String = ""
        Dim objFiltro As TD_Qry_SegOC_L01 = New TD_Qry_SegOC_L01
        Dim objReporte As New rptIndicadorTiempoEntrega
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


        DtReporte = obrAlmacenSat.frptIndicadorTiempoEntrega(objFiltro)

        'Generacion de tabla resumen
        Dim strProveedor As String = String.Empty
        Dim nEnPlazo As Integer = 0
        Dim nAnticipado As Integer = 0
        Dim nAtrazado As Integer = 0
        Dim nTotal As Integer = 0
        Dim nPorcentaje As Decimal = 0
        Dim blExisteProveedor As Boolean = False
        Dim drResumen As DataRow

        mtoDtFormater(DtResumen)

        For Each dr As DataRow In DtReporte.Rows
            nEnPlazo = 0
            nAnticipado = 0
            nAtrazado = 0
            nTotal = 0
            nPorcentaje = 0
            blExisteProveedor = False

            For Each drAux As DataRow In DtResumen.Select("Proveedor = '" & ("" & dr("TPRVCL")) & "'")
                blExisteProveedor = True
            Next


            If blExisteProveedor Then
                Continue For
            Else


                For Each drAux As DataRow In DtReporte.Select("ISNULL(TPRVCL,'') = '" & ("" & dr("TPRVCL")) & "'")

                    Select Case drAux("STFENT").ToString.Trim
                        Case "EN EL PLAZO"
                            nEnPlazo = nEnPlazo + 1
                        Case "ANTICIPADO"
                            nAnticipado = nAnticipado + 1
                        Case "ATRASADO"
                            nAtrazado = nAtrazado + 1
                    End Select

                Next
                nTotal = (nEnPlazo + nAnticipado + nAtrazado)
                If nAtrazado > 0 Then
                    nPorcentaje = Math.Round((nAtrazado / nTotal) * 100, 2)
                Else
                    nPorcentaje = 0
                End If


                drResumen = DtResumen.NewRow()
                drResumen("Proveedor") = ("" & dr("TPRVCL"))
                drResumen("EnPlazo") = nEnPlazo
                drResumen("Anticipado") = nAnticipado
                drResumen("Atrazado") = nAtrazado
                drResumen("PORCENTAJE") = nPorcentaje
                drResumen("Cliente") = dr("CCLNT")
                DtResumen.Rows.Add(drResumen)
            End If


        Next

        'Fin de generacion de tabla resumen'


        Dim dtw As New DataView(DtResumen)

        dtw.Sort = "PORCENTAJE DESC"

        DtResumen = dtw.ToTable

        DtReporte.TableName = "SegOCPorFechaEntrega"
        DtResumen.TableName = "ResumenTiempoEntrega"
        objReporte.SetDataSource(DtReporte)

        objReporte.Subreports(0).SetDataSource(DtResumen)

        objReporte.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
        objReporte.SetParameterValue("pRangoFecha", strTemp)


        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = objReporte


        ' Visualizamos la información en el visor
        ' objTemp = mfrptGeneradorReportes(objFiltro)
    End Sub

    Private Sub ExportarExcelOC()
        Dim oDs As New DataSet
        Dim oDt As New DataTable
        Dim oDtResumen As New DataTable
        oDt = DtReporte.Copy

        oDt.TableName = "Reporte"
        DtResumen.TableName = "Resumen"

        oDtResumen = DtResumen.Copy
        oDtResumen.Columns.Remove("Cliente")

        oDtResumen.Columns("Proveedor").ColumnName = "Proveedor"
        oDtResumen.Columns("EnPlazo").ColumnName = "En el Plazo"
        oDtResumen.Columns("Anticipado").ColumnName = "Anticipado"
        oDtResumen.Columns("Atrazado").ColumnName = "Atrasado"
        oDtResumen.Columns("PORCENTAJE").ColumnName = "% Atraso"



        oDt.Columns("CCLNT").SetOrdinal(0)
        oDt.Columns("TCMPCL").SetOrdinal(1)
        oDt.Columns("CPRVCL").SetOrdinal(2)
        oDt.Columns("TPRVCL").SetOrdinal(3)
        oDt.Columns("NORCML").SetOrdinal(4)
        oDt.Columns("NRITOC").SetOrdinal(5)
        oDt.Columns("TDITES").SetOrdinal(6)
        oDt.Columns("FORCML").SetOrdinal(7)
        oDt.Columns("FMPDME").SetOrdinal(8)
        oDt.Columns("FREFFW").SetOrdinal(9)
        oDt.Columns("NDIATR").SetOrdinal(10)
        oDt.Columns("QCNTIT").SetOrdinal(11)
        oDt.Columns("QBLTSR").SetOrdinal(12)
        oDt.Columns("QCNPEN").SetOrdinal(13)
        oDt.Columns("STFREC").SetOrdinal(14)
        oDt.Columns("STFENT").SetOrdinal(15)


        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("CPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TDITES").ColumnName = "DETALLE"
        oDt.Columns("FORCML").ColumnName = "FECHA EMISION O/C"
        oDt.Columns("FMPDME").ColumnName = "FECHA POSIBLE ENTREGA"
        oDt.Columns("FREFFW").ColumnName = "FECHA ENTREGA AT"
        oDt.Columns("NDIATR").ColumnName = "DIAS ATRASO"
        oDt.Columns("QCNTIT").ColumnName = "QTA O/C"
        oDt.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
        oDt.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
        oDt.Columns("STFREC").ColumnName = "STATUS RECEPCION"
        oDt.Columns("STFENT").ColumnName = "STATUS ENTREGAL"

        oDs.Tables.Add(oDt)
        oDs.Tables.Add(oDtResumen.Copy)

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


        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
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
        tsbEnviarCorreo.Enabled = True
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
