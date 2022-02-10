
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra

Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports Ransa.TYPEDEF
Imports RANSA.Utilitario


Public Class frmRptSalidaXAlmacen


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

    Private Sub frmRptSalidaXAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            '-- Crear status por control con F4
            'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

            Dim ClientePK As RANSA.Controls.Cliente.TD_ClientePK = New RANSA.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            'txtCliente.pCargar(ClientePK)
            CargarCliente()
            CargarUbicacion()
            objAppConfig = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try



      
    End Sub

    Private Sub CargarCliente()
       
        Dim obrcliente As New Ransa.Controls.Cliente.cCliente
        Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01
        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With obeCliente

            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        End With
        oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

        Lista = New List(Of beCliente)

        For Each dr As DataRow In oDtCliente.Rows
            objCliente = New beCliente
            objCliente.Codigo = dr("CCLNT")
            If dr("TMTVBJ").ToString.Trim = "" Then
                objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
            Else
                objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
            End If

            objCliente.RUC = dr("NRUC")
            objCliente.Estado = 0
            Lista.Add(objCliente)
        Next

        Dim oListColum As New Hashtable

        Dim oColumnas1 As New DataGridViewCheckBoxColumn
        oColumnas1.Name = "CHK"
        oColumnas1.DataPropertyName = "CHK"
        oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas1.HeaderText = "Check"
        oColumnas1.ReadOnly = False
        oColumnas1.Visible = True
        oListColum.Add(1, oColumnas1)

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "Código"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "RUC"
        oColumnas.DataPropertyName = "RUC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "RUC"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(4, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Estado"
        oColumnas.DataPropertyName = "Estado"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oColumnas.HeaderText = "Estado"
        oColumnas.Visible = False
        oColumnas.ReadOnly = True
        oListColum.Add(5, oColumnas)

        Me.txtCliente2.DataSource = Lista
        Me.txtCliente2.ListColumnas = oListColum
        Me.txtCliente2.Cargas()
        Me.txtCliente2.DispleyMember = "Descripcion"
        Me.txtCliente2.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
        Try
            If fblnValidaInformacion() Then
                
                tsbEnviarCorreo.Enabled = False
                btnExportarExcel.Enabled = False
                tsbImprimir.Enabled = False
                btnGenerarReporte.Enabled = False
                pListarReporteGrilla()
                HabilitarBotones(True)

            End If
        Catch ex As Exception
            HabilitarBotones(True)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

     
    End Sub

    Private Sub pListarReporteGrilla()
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        Dim dstTemp As DataSet = Nothing
        Dim oDtExcel As New DataTable
        If txtCliente2.Resultado IsNot Nothing Then
            Dim Est As String = txtCliente2.Resultado.GetType.ToString
            With obeFiltro

                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                Else
                    .PSCCLNT = ListaCodigoClientes()
                End If
                If txtCodigoRecepcion.Text <> "" Then .PSCREFFW = txtCodigoRecepcion.Text.Replace(" ", "").Replace(",", "','")
                .PNFECINI = dteFechaInicial.Value
                .PNFECFIN = dteFechaFinal.Value
                If txtUbicacionReferencial.Resultado IsNot Nothing Then
                    .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                Else
                    .PSTUBRFR = ""
                End If
                .PSSTPING = "" & txtTipoMovimiento.Tag
                .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            End With

            Dim objTemp2 As New TipoDato_ResultaReporte
            If rbtOrdenDeCompra.Checked Then
                dstTemp = obrReporteAT.fdstDespachoPorAlmacen(obeFiltro)
                objTemp2.add_Tables(dstTemp)
                objTemp = objTemp2
                oDtExcel = EliminarRepetido(dstTemp.Tables(0))
                ExportarExcelOC(oDtExcel, "G", Nothing)
                VisualizarGrilla("OC")
            ElseIf rbtItem.Checked Then
                dstTemp = obrReporteAT.fdstDespachoPorAlmacen(obeFiltro)
                objTemp2.add_Tables(dstTemp)
                objTemp = objTemp2
                oDtExcel = EliminarRepetidoItems(dstTemp.Tables(0))

                ExportarExcelItem(oDtExcel, "G", Nothing)
                VisualizarGrilla("IT")
            Else
                dstTemp = obrReporteAT.fdstDespachoPorAlmacen(obeFiltro)
                objTemp2.add_Tables(dstTemp)
                objTemp = objTemp2

                ExportarExcelSubItem(dstTemp.Tables(0), "G", Nothing)
                VisualizarGrilla("SU")
            End If
        End If

    End Sub

    Private Sub VisualizarGrilla(ByVal Vista As String)
        If Vista = "OC" Then
            dgSalidaOC.Visible = True
            dgSalidaItem.Visible = False
            dgSalidaSubItem.Visible = False
            dgSalidaOC.AutoGenerateColumns = False
        ElseIf Vista = "IT" Then
            dgSalidaOC.Visible = False
            dgSalidaItem.Visible = True
            dgSalidaSubItem.Visible = False
            dgSalidaItem.AutoGenerateColumns = False
        ElseIf Vista = "SU" Then
            dgSalidaOC.Visible = False
            dgSalidaItem.Visible = False
            dgSalidaSubItem.Visible = True
            dgSalidaSubItem.AutoGenerateColumns = False
        End If
    End Sub


    Private Sub HabilitarBotones(ByVal Habilitar As Boolean)
        btnGenerarReporte.Enabled = Habilitar
        btnExportarExcel.Enabled = Habilitar
        tsbImprimir.Enabled = Habilitar
    End Sub
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente2.Resultado IsNot Nothing Then

            Dim Estado As String = txtCliente2.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente2.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    btnExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente2.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    btnExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        btnExportarExcel.Enabled = False
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If

            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    'Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
    '    Call pGenerarReporte()
    'End Sub
    'Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
    '    'pcxEspera.Visible = False
    '    btnGenerarReporte.Enabled = True
    '    tsbEnviarCorreo.Enabled = True
    '    btnExportarExcel.Enabled = True
    '    crvReporte.Visible = True
    '    crvReporte.ReportSource = objTemp.pReporte
    'End Sub
    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig

        If Me.rbtOrdenDeCompra.Checked Then
            pReporteDespachoPorAlmacenOc()
        ElseIf rbtItem.Checked Then
            pReporteDespachoPorAlmacenItem()
        Else
            pReporteDespachoPorAlmacenSubItem()
        End If
        strDetalleReporte = "Despacho de Almacén"
        objAppConfig.ConfigType = 1
        'objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Function EliminarRepetidoItems(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ,CIDPAQ  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) And dtTemp.Rows(i).Item("CIDPAQ").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CIDPAQ").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Sub pReporteDespachoPorAlmacenItem()
        Dim dstTemp As New DataSet ' = Nothing

        Dim rptTemp As ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            'Convertir DataTable para reporte
            rptTemp = New rptDespachoPorAlmacenItem
            dstTemp.Tables(0).TableName = "dtDespachoPorAlmacen"
            'dstTemp.Tables(0).TableName = "IngresoPorAlmacen"
            rptTemp.SetDataSource(dstTemp.Tables(0))
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
            ' Generamos el Nuevo Tipo de Datos
            'objTemp2.add_Tables(dstTemp)
            'objTemp2.pReporte = rptTemp

            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
        'objTemp = objTemp2
    End Sub

    Private Sub pReporteDespachoPorAlmacenSubItem()
        Dim dstTemp As New DataSet ' = Nothing

        Dim rptTemp As ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            'Convertir DataTable para reporte
            rptTemp = New rptDespachoPorAlmacenSubItem
            dstTemp.Tables(0).TableName = "dtDespachoPorAlmacen"
            'dstTemp.Tables(0).TableName = "IngresoPorAlmacen"
            rptTemp.SetDataSource(dstTemp.Tables(0))
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
            ' Generamos el Nuevo Tipo de Datos
            'objTemp2.add_Tables(dstTemp)
            'objTemp2.pReporte = rptTemp

            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
        'objTemp = objTemp2
    End Sub

    Private Sub pReporteDespachoPorAlmacenOc()
        Dim dstTemp As New DataSet '= Nothing

        Dim rptTemp As ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            'Convertir DataTable para reporte
            rptTemp = New rptDespachoPorAlmacenOc
            dstTemp.Tables(0).TableName = "dtDespachoPorAlmacen"
            'dstTemp.Tables(0).TableName = "IngresoPorAlmacen"
            rptTemp.SetDataSource(dstTemp.Tables(0))
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
            ' Generamos el Nuevo Tipo de Datos
            'objTemp2.add_Tables(dstTemp)
            'objTemp2.pReporte = rptTemp
            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
        'objTemp = objTemp2
    End Sub

    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""
        Dim ListaS As New List(Of String)
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        ListaS = CType(txtCliente2.Resultado, List(Of String))
        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Function ReturnTableFormatedIngresoEgreso(ByVal oDt As DataTable, ByVal llave As String) As DataTable
        'Try
        Dim oDtv1 As DataView = New DataView(oDt)
        Dim oDtv2 As DataView = New DataView(oDt)
        Dim oDtv3 As DataView = New DataView(oDt)
        Dim oDtv4 As DataView = New DataView(oDt)
        Dim oDtFiltro As New DataTable
        Dim oDtFiltroSubTotal As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt2 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt5 As New DataTable

        oDt1 = oDtv1.ToTable(True, "CCLNT", "TUBRFR", "CREFFW", "QREFFW", "QPSOBL", "QAROCP")
        oDt2 = oDtv2.ToTable(True, "CCLNT", "TUBRFR", "NORCML")
        oDt3 = oDtv3.ToTable(True, "CCLNT", "TUBRFR", "CREFFW", "CIDPAQ", "QBLTSR")
        oDt4 = oDtv4.ToTable(True, "CCLNT")
        Dim OdtNew As New DataTable
        Dim oDr As DataRow
        OdtNew = oDt.Clone
        For j As Integer = 0 To oDt4.Rows.Count - 1
            oDtFiltroSubTotal = SelectDataTable(oDt, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'")
            For i As Integer = 0 To oDtFiltroSubTotal.Rows.Count
                'SelectDataTable(oDt1, "CCLNT = '" + oDt.Rows(i).Item("CCLNT") + "'")
                If i = oDtFiltroSubTotal.Rows.Count Then
                    oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                    oDr = OdtNew.NewRow()
                    oDr(1) = "SUB TOTALES : "
                    oDr("CREFFW") = oDtFiltro.Rows.Count
                    oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                    oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                    oDr("QAROCP") = SumarDataTable(oDtFiltro, "QAROCP")
                    oDtFiltro = SelectDataTable(oDt2, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                    oDr("NORCML") = oDtFiltro.Rows.Count
                    oDtFiltro = SelectDataTable(oDt3, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                    oDr("QBLTSR") = SumarDataTable(oDtFiltro, "QBLTSR")
                    OdtNew.Rows.Add(oDr)

                    'If oDt.Rows(i).Item("CCLNT") <> oDt.Rows(i - 1).Item("CCLNT") Then 'And oDt.Rows(i).Item("CCLNT").ToString.Trim <> ""
                    'oDt2 = oDtv2.ToTable(True, "CCLNT", "NORCML")
                    oDt5 = SelectDataTable(oDtv2.ToTable(True, "CCLNT", "NORCML"), "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'")
                    oDr = OdtNew.NewRow()
                    oDr(1) = "TOTALES : "
                    oDr("CREFFW") = SelectDataTable(oDt1, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'").Rows.Count
                    oDr("QREFFW") = SumarDataTable(SelectDataTable(oDt1, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'"), "QREFFW")
                    oDr("QPSOBL") = SumarDataTable(SelectDataTable(oDt1, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'"), "QPSOBL")
                    oDr("QAROCP") = SumarDataTable(SelectDataTable(oDt1, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'"), "QAROCP")
                    oDr("NORCML") = oDt5.Rows.Count
                    oDr("QBLTSR") = SumarDataTable(SelectDataTable(oDt3, "CCLNT = '" + oDt4.Rows(j).Item("CCLNT").ToString.Trim + "'"), "QBLTSR")
                    OdtNew.Rows.Add(oDr)
                    'End If
                    Exit For
                End If


                If i > 0 Then
                    If oDtFiltroSubTotal.Rows(i).Item("TUBRFR") <> oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") And oDtFiltroSubTotal.Rows(i).Item("CCLNT") = oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT") Then
                        oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                        oDr = OdtNew.NewRow()
                        oDr(1) = "SUB TOTALES : "
                        oDr("CREFFW") = oDtFiltro.Rows.Count
                        oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                        oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                        oDr("QAROCP") = SumarDataTable(oDtFiltro, "QAROCP")
                        oDtFiltro = SelectDataTable(oDt2, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                        oDr("NORCML") = oDtFiltro.Rows.Count
                        oDtFiltro = SelectDataTable(oDt3, "CCLNT = '" + oDtFiltroSubTotal.Rows(i - 1).Item("CCLNT").ToString.Trim + "' AND TUBRFR = '" + oDtFiltroSubTotal.Rows(i - 1).Item("TUBRFR") + "'")
                        oDr("QBLTSR") = SumarDataTable(oDtFiltro, "QBLTSR")
                        OdtNew.Rows.Add(oDr)
                    End If
                End If

                OdtNew.ImportRow(oDtFiltroSubTotal.Rows(i))
            Next
        Next

        Return OdtNew
        'Catch ex As Exception
        'End Try

    End Function

    Private Function SumarDataTable(ByVal oDt As DataTable, ByVal strNombreColumna As String) As Decimal
        Dim decSuma As Decimal = 0
        For index As Integer = 0 To oDt.Rows.Count - 1
            decSuma = decSuma + oDt.Rows(index).Item(strNombreColumna)
        Next
        Return decSuma
    End Function

    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable

        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        Return dtNew
    End Function

    Private Sub bsaTipoMovimientoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoMovimientoListar.Click
        Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
    End Sub

    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
        End If
    End Sub

    Private Sub txtTipoMovimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMovimiento.TextChanged
        txtTipoMovimiento.Tag = ""
    End Sub

    Private Sub txtTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoMovimiento.Validating
        If txtTipoMovimiento.Text = "" Then
            txtTipoMovimiento.Tag = ""
        Else
            If txtTipoMovimiento.Text <> "" And "" & txtTipoMovimiento.Tag = "" Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
                If txtTipoMovimiento.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
    End Sub

    'Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
    '    Try
    '        Dim oDtExcel As New DataTable
    '        Dim strTitulo As String = ""
    '        strTitulo = Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial

    '        If Me.rbtOrdenDeCompra.Checked Then
    '            oDtExcel = EliminarRepetido(objTemp.Tables(0))
    '            oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")
    '            ExportarExcelOC(oDtExcel, strTitulo)
    '        ElseIf rbtItem.Checked Then
    '            oDtExcel = EliminarRepetidoItems(objTemp.Tables(0))
    '            oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")
    '            ExportarExcelItem(oDtExcel, strTitulo)
    '        Else
    '            oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")
    '            ExportarExcelSubItem(oDtExcel, strTitulo)?
    '        End If
    '    Catch : End Try

    'End Sub

    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
            'And dtTemp.Rows(i).Item("CORRELATIVO").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CORRELATIVO").ToString.Trim)
        Next
        Return dtTemp
    End Function

    Private Sub ExportarExcelSubItem(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
        Dim oDt As New DataTable
        'oDt = oDtExcel.Copy
        Dim oDs As New DataSet
        Dim oDtResumen As New DataTable
        Dim oDtIng As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA



        If resultado = "E" Then
            oDt = GeneraDataTableSubItem(oDtExcel)
            oDt.Columns.Remove("CIDPAQ")
            oDt.Columns.Remove("TCTCST")
            oDt.Columns.Remove("TCTCSA")
            oDt.Columns.Remove("TCTCSF")

            oDt.Columns.Add("FSLDAL1", Type.GetType("System.String"))
            'oDt.Columns.Add("FSLFFW1", Type.GetType("System.String"))
            For i As Integer = 0 To oDtExcel.Rows.Count - 1
                'oDtExcel.Columns("FREFFW").DataType = GetType(System.String)
                If oDt.Rows(i).Item("FSLDAL").ToString.Trim <> "" Then
                    oDt.Rows(i).Item("FSLDAL1") = oDt.Rows(i).Item("FSLDAL").ToString.Substring(0, 10)
                End If
                oDt.AcceptChanges()
            Next

            oDt.Columns.Remove("FSLDAL")
            oDt.Columns("FSLDAL1").SetOrdinal("6")

            Dim oDtv1 As DataView = New DataView(oDtRe)
            Dim oDtv2 As DataView = New DataView(oDtRe)
            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtIng.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("FSLDAL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCMTRT", Type.GetType("System.String")).Caption = NPOI.FormatDato("TRANSPORTISTA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLCCM", Type.GetType("System.String")).Caption = NPOI.FormatDato("PLACA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TABDES", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO TRACTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TDEACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMBCH", Type.GetType("System.String")).Caption = NPOI.FormatDato("CHOFER", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QAROCP", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("AREA DEL BULTO (MT2)", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° GUIA PROV.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("INCONTERM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NRITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCITCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)

            oDtIng.Columns.Add("TCITPR", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. ITEM PROV.", HelpClass_NPOI_SA.keyDatoTexto)


            oDtIng.Columns.Add("TDITES", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION DEL ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QBLTSR", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("QPEPQT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNDCN", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DESTINO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMMDT_ENVIO", Type.GetType("System.String")).Caption = NPOI.FormatDato("MEDIO DE ENVIO ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("SBITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("SUBITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCITCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. SUBITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TDITES1", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QCNRCP", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD ", HelpClass_NPOI_SA.keyDatoNumero)

            For Each oDrs As DataRow In oDt.Rows
                oDtIng.ImportRow(oDrs)
            Next

            oDtIng.TableName = "SalidaPorAlmacen"
            oDs.Tables.Add(oDtIng)
            oDtResumen.TableName = "Resumen"
            oDs.Tables.Add(oDtResumen)

            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtIng)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("SALIDA POR ALMACEN")
            strlTitulo2.Add("RESUMEN SALIDA POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo = 0, "TODOS", Me.txtCliente2.Resultado))
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo = 0, "TODOS", ListaCodigoClientes))
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)
        ElseIf resultado = "G" Then
            dgSalidaSubItem.AutoGenerateColumns = False
            dgSalidaSubItem.DataSource = oDtExcel
        End If

        'oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        'oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        'oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        'oDt.Columns("FSLDAL").ColumnName = "FECHA"
        'oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        'oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
        'oDt.Columns("NPLCCM").ColumnName = "PLACA"
        'oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"
        'oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
        'oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"
        'oDt.Columns("TNMBCH").ColumnName = "CHOFER"
        'oDt.Columns("CREFFW").ColumnName = "BULTO"
        'oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        'oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        'oDt.Columns("QPSOBL").ColumnName = "PESO "
        'oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        'oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        'oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
        'oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        'oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        'oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        'oDt.Columns("NORCML").ColumnName = "N° O/C	"
        'oDt.Columns("TTINTC").ColumnName = "INCONTERM"

        'oDt.Columns("NRITOC").ColumnName = "ITEM "
        'oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE "
        'oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        'oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM "
        'oDt.Columns("QPEPQT").ColumnName = "PESO ITEM "
        'oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        'oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        'oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"

        'oDt.Columns("SBITOC").ColumnName = "SUBITEM"
        'oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        'oDt.Columns("TDITES1").ColumnName = "DESCRIPCION"
        'oDt.Columns("QCNRCP").ColumnName = "CANTIDAD "

        'oDs.Tables.Add(oDt)
        'Dim strlTitulo As New List(Of String)
        ''strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        'strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        'If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
        '    strlTitulo.Add("Ubicación :\nTODOS")
        'Else
        '    strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        'End If
        'If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
        '    strlTitulo.Add("Tipo de Mov.:\nTODOS")
        'Else
        '    strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        'End If
        'strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)

    End Sub

    Private Function GeneraDataTableSubItem(ByVal oDtSubItem As DataTable) As DataTable
        Dim oDtAux As New DataTable
        Dim bolBultosIguales As Boolean = False

        oDtAux = oDtSubItem.Copy
        For i As Integer = oDtAux.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False
            If oDtAux.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDtAux.Rows(i).Item("TCMPCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TCMPCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDtAux.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDtAux.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNPSO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNPSO").ToString.Trim) And _
            oDtAux.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDtAux.Rows(i).Item("TUNVOL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TUNVOL").ToString.Trim) And _
            oDtAux.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDtAux.Rows(i).Item("NGRPRV").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NGRPRV").ToString.Trim) And _
            oDtAux.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDtAux.Rows(i).Item("NORCML").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NORCML").ToString.Trim) Then

                oDtAux.Rows(i).Item("CCLNT") = DBNull.Value
                oDtAux.Rows(i).Item("TCMPCL") = DBNull.Value
                oDtAux.Rows(i).Item("TUBRFR") = DBNull.Value
                oDtAux.Rows(i).Item("FSLDAL") = DBNull.Value
                oDtAux.Rows(i).Item("CREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("QREFFW") = DBNull.Value
                oDtAux.Rows(i).Item("TIPBTO") = DBNull.Value
                oDtAux.Rows(i).Item("QPSOBL") = DBNull.Value
                oDtAux.Rows(i).Item("TUNPSO") = DBNull.Value
                oDtAux.Rows(i).Item("QVLBTO") = DBNull.Value
                oDtAux.Rows(i).Item("TUNVOL") = DBNull.Value
                oDtAux.Rows(i).Item("TPRVCL") = DBNull.Value
                oDtAux.Rows(i).Item("NGRPRV") = DBNull.Value
                oDtAux.Rows(i).Item("QAROCP") = DBNull.Value
                oDtAux.Rows(i).Item("NORCML") = DBNull.Value
                oDtAux.Rows(i).Item("TTINTC") = DBNull.Value
                oDtAux.Rows(i).Item("REFERENCIA") = DBNull.Value


                bolBultosIguales = True
            End If


            If oDtAux.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDtAux.Rows(i).Item("CIDPAQ").ToString.Trim.Equals(oDtAux.Rows(i - 1).Item("CIDPAQ").ToString.Trim) And _
             bolBultosIguales Then

                oDtAux.Rows(i).Item("NRITOC") = DBNull.Value
                oDtAux.Rows(i).Item("TCITCL") = DBNull.Value
                oDtAux.Rows(i).Item("TDITES") = DBNull.Value
                oDtAux.Rows(i).Item("QBLTSR") = DBNull.Value
                oDtAux.Rows(i).Item("QPEPQT") = DBNull.Value
                oDtAux.Rows(i).Item("TUNDCN") = DBNull.Value
                oDtAux.Rows(i).Item("TLUGEN") = DBNull.Value
                oDtAux.Rows(i).Item("NGUIRM") = DBNull.Value
                oDtAux.Rows(i).Item("TNMMDT_ENVIO") = DBNull.Value
                oDtAux.Rows(i).Item("FSLDAL") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCST") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSA") = DBNull.Value
                oDtAux.Rows(i).Item("TCTCSF") = DBNull.Value
                oDtAux.Rows(i).Item("REFERENCIA") = DBNull.Value

            End If
            oDtAux.AcceptChanges()
        Next


        Return oDtAux
    End Function

    Private Sub ExportarExcelItem(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
        Dim oDt As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet
        Dim oDtIng As New DataTable
        Dim oDtResumen As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")

        If resultado = "E" Then
            Dim oDtv1 As DataView = New DataView(oDtRe)
            Dim oDtv2 As DataView = New DataView(oDtRe)

            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtIng.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("FSLDAL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA", HelpClass_NPOI_SA.keyDatoFecha)
            oDtIng.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            'oDtIng.Columns.Add("NGUIRS", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("GLOSA_GR", Type.GetType("System.String")).Caption = NPOI.FormatDato("GLOSA GR", HelpClass_NPOI_SA.keyDatoTexto)

            oDtIng.Columns.Add("TCMTRT", Type.GetType("System.String")).Caption = NPOI.FormatDato("TRANSPORTISTA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLCCM", Type.GetType("System.String")).Caption = NPOI.FormatDato("PLACA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TABDES", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO TRACTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TDEACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMBCH", Type.GetType("System.String")).Caption = NPOI.FormatDato("CHOFER", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QAROCP", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("AREA DEL BULTO (MT2)", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° GUIA PROV.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NRPDTS", Type.GetType("System.String")).Caption = NPOI.FormatDato("PEDIDO DE TRASLADO", HelpClass_NPOI_SA.keyDatoTexto)

            oDtIng.Columns.Add("NROSEC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ITEM PED. TRASLADO", HelpClass_NPOI_SA.keyDatoTexto)

            oDtIng.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("INCONTERM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("REFERENCIA", Type.GetType("System.String")).Caption = NPOI.FormatDato("REFERENCIA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NRITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCITCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. ITEM CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCITPR", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. ITEM PROV.", HelpClass_NPOI_SA.keyDatoTexto)

            oDtIng.Columns.Add("TDITES", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION DEL ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QBLTSR", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("QPEPQT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNDCN", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DESTINO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMMDT_ENVIO", Type.GetType("System.String")).Caption = NPOI.FormatDato("MEDIO DE ENVIO ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCST", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION TERRESTRE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCSA", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION AEREO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCSF", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION FLUVIAL", HelpClass_NPOI_SA.keyDatoTexto)

            For Each oDrs As DataRow In oDt.Rows
                oDtIng.ImportRow(oDrs)

            Next

            oDtIng.TableName = "SalidaPorAlmacen"
            oDs.Tables.Add(oDtIng)
            oDtResumen.TableName = "Resumen"
            oDs.Tables.Add(oDtResumen)

            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtIng)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("SALIDA POR ALMACEN")
            strlTitulo2.Add("RESUMEN SALIDA POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & ListaClientes())
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & ListaClientes())
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)

        ElseIf resultado = "G" Then
            dgSalidaItem.AutoGenerateColumns = False
            dgSalidaItem.DataSource = oDt
        End If
        'oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        'oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        'oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        'oDt.Columns("FSLDAL").ColumnName = "FECHA"
        'oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        'oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
        'oDt.Columns("NPLCCM").ColumnName = "PLACA"
        'oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"
        'oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
        'oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"

        'oDt.Columns("TNMBCH").ColumnName = "CHOFER"
        'oDt.Columns("CREFFW").ColumnName = "BULTO"
        'oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
        'oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        'oDt.Columns("QPSOBL").ColumnName = "PESO "
        'oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
        'oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        'oDt.Columns("TUNVOL").ColumnName = "UNIDAD "

        'oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
        'oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        'oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
        'oDt.Columns("NORCML").ColumnName = "N° O/C	"
        'oDt.Columns("TTINTC").ColumnName = "INCONTERM"
        'oDt.Columns("NRITOC").ColumnName = "ITEM "
        'oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE "
        'oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
        'oDt.Columns("QBLTSR").ColumnName = "CANT. ITEM "
        'oDt.Columns("QPEPQT").ColumnName = "PESO ITEM "
        'oDt.Columns("TUNDCN").ColumnName = "UNIDAD  "
        'oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
        'oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
        'oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
        'oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
        'oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"
        'oDt.Columns.Remove("CIDPAQ")
        'oDt.Columns.Remove("SBITOC")
        'oDt.Columns.Remove("TCITCL1")
        'oDt.Columns.Remove("TDITES1")
        'oDt.Columns.Remove("QCNRCP")

        'oDs.Tables.Add(oDt)
        'Dim strlTitulo As New List(Of String)
        ''strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        'strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        'If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
        '    strlTitulo.Add("Ubicación :\nTODOS")
        'Else
        '    strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        'End If
        'If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
        '    strlTitulo.Add("Tipo de Mov.:\nTODOS")
        'Else
        '    strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        'End If
        'strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)

    End Sub

    Private Sub ExportarExcelOC(ByVal oDtExcel As DataTable, ByVal resultado As String, Optional ByVal oDtRe As DataTable = Nothing)
        Dim oDt As New DataTable
        Dim oDtIng As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet
        Dim oDtResumen As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA
        'Eliminado
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("QBLTSR")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("TUNDCN")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")

        If resultado = "E" Then

            Dim oDtv1 As DataView = New DataView(oDtRe)
            Dim oDtv2 As DataView = New DataView(oDtRe)
            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "CREFFW", "ZONA", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("SALIDA | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtIng.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("FSLDAL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA", HelpClass_NPOI_SA.keyDatoFecha)
            oDtIng.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("GLOSA_GR", Type.GetType("System.String")).Caption = NPOI.FormatDato("GLOSA GR", HelpClass_NPOI_SA.keyDatoTexto)
            'oDtIng.Columns.Add("NGUIRS", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCMTRT", Type.GetType("System.String")).Caption = NPOI.FormatDato("TRANSPORTISTA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLCCM", Type.GetType("System.String")).Caption = NPOI.FormatDato("PLACA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TABDES", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO TRACTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NPLACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TDEACP", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ACOPLADO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMBCH", Type.GetType("System.String")).Caption = NPOI.FormatDato("CHOFER", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("QAROCP", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("AREA DEL BULTO (MT2)", HelpClass_NPOI_SA.keyDatoNumero)
            oDtIng.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° GUIA PROV.", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("INCONTERM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DESTINO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TNMMDT_ENVIO", Type.GetType("System.String")).Caption = NPOI.FormatDato("MEDIO DE ENVIO ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCST", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION TERRESTRE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCSA", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION AEREO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtIng.Columns.Add("TCTCSF", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUENTA IMPUTACION FLUVIAL", HelpClass_NPOI_SA.keyDatoTexto)

            For Each oDrs As DataRow In oDt.Rows
                oDtIng.ImportRow(oDrs)
            Next

            oDtIng.TableName = "SalidaPorAlmacen"
            oDs.Tables.Add(oDtIng)
            oDtResumen.TableName = "Resumen"
            oDs.Tables.Add(oDtResumen)

            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtIng)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("SALIDA POR ALMACEN")
            strlTitulo2.Add("RESUMEN SALIDA POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)

            'Renombramos las columnas para exportar al excel
            'oDt.Columns("CCLNT").ColumnName = "CLIENTE"
            'oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
            'oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
            'oDt.Columns("FSLDAL").ColumnName = "FECHA"
            'oDt.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
            'oDt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
            'oDt.Columns("NPLCCM").ColumnName = "PLACA"
            'oDt.Columns("TABDES").ColumnName = "TIPO TRACTO"
            'oDt.Columns("NPLACP").ColumnName = "ACOPLADO"
            'oDt.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"
            'oDt.Columns("TNMBCH").ColumnName = "CHOFER"
            'oDt.Columns("CREFFW").ColumnName = "BULTO"
            'oDt.Columns("QREFFW").ColumnName = "CANTIDAD"
            'oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
            'oDt.Columns("QPSOBL").ColumnName = "PESO "
            'oDt.Columns("TUNPSO").ColumnName = "UNIDAD"
            'oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
            'oDt.Columns("TUNVOL").ColumnName = "UNIDAD "
            'oDt.Columns("QAROCP").ColumnName = "AREA DEL BULTO" & Chr(10) & "(MT2) "
            'oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
            'oDt.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
            'oDt.Columns("NORCML").ColumnName = "N° O/C	"
            'oDt.Columns("TTINTC").ColumnName = "INCONTERM"
            'oDt.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
            'oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
            'oDt.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
            'oDt.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
            'oDt.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"

            'oDs.Tables.Add(oDt)
            'Dim strlTitulo As New List(Of String)
            ''strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
            'strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
            'If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            '    strlTitulo.Add("Ubicación :\nTODOS")
            'Else
            '    strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
            'End If
            'If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            '    strlTitulo.Add("Tipo de Mov.:\nTODOS")
            'Else
            '    strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
            'End If
            'strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
        ElseIf resultado = "G" Then
            dgSalidaOC.AutoGenerateColumns = False
            dgSalidaOC.DataSource = oDt
        End If


    End Sub

    Private Sub CargarUbicacion()
        'Try
        If txtCliente2.Resultado IsNot Nothing Then
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            Dim objNegocio As New brUbicacionesXCliente
            Dim strCliente As String = ""
            Dim Est As String = txtCliente2.Resultado.GetType.ToString
            If Est = "Ransa.Utilitario.beCliente" Then
                strCliente = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                strCliente = ListaCodigoClientes()
            End If

            oListColum = New Hashtable

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PNCCLNT"
            oColumnas.DataPropertyName = "PNCCLNT"
            oColumnas.HeaderText = "Cod. Cliente"
            oColumnas.Visible = True
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTCMPCL"
            oColumnas.DataPropertyName = "PSTCMPCL"
            oColumnas.HeaderText = "Cliente "
            oColumnas.Visible = True
            oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTUBRFR_1"
            oColumnas.DataPropertyName = "PSTUBRFR"
            oColumnas.HeaderText = "Ubicación"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(3, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTUBRFR"
            oColumnas.DataPropertyName = "PSTUBRFR"
            oColumnas.HeaderText = "Ubicación "
            oColumnas.Visible = False
            oListColum.Add(4, oColumnas)


            txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(strCliente)
            txtUbicacionReferencial.ListColumnas = oListColum
            txtUbicacionReferencial.Cargas()
            txtUbicacionReferencial.Limpiar()
            txtUbicacionReferencial.ValueMember = "PSTUBRFR"
            txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
        Else
            txtUbicacionReferencial.DataSource = Nothing
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtCliente_InformationChanged()
        CargarUbicacion()
    End Sub


    Private Sub tsmModelo01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmModelo01.Click
        Try
            If fblnValidaInformacion() Then
                Dim oDtExcel As New DataTable
                Dim strTitulo As String = ""
                'strTitulo = Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial
                If Me.rbtOrdenDeCompra.Checked Then
                    oDtExcel = EliminarRepetido(objTemp.Tables(0))
                    oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")

                    oDtExcel.Columns.Add("FSLDAL1", Type.GetType("System.String"))

                    For i As Integer = 0 To oDtExcel.Rows.Count - 1
                        If oDtExcel.Rows(i).Item("FSLDAL").ToString.Trim <> "" Then
                            oDtExcel.Rows(i).Item("FSLDAL1") = oDtExcel.Rows(i).Item("FSLDAL").ToString.Substring(0, 10)
                        End If
                        oDtExcel.AcceptChanges()
                    Next
                    oDtExcel.Columns.Remove("FSLDAL")

                    oDtExcel.Columns("FSLDAL1").SetOrdinal("6")

                    ExportarExcelOC(oDtExcel, "E", objTemp.Tables(0))
                ElseIf rbtItem.Checked Then
                    oDtExcel = EliminarRepetidoItems(objTemp.Tables(0))
                    oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")

                    oDtExcel.Columns.Add("FSLDAL1", Type.GetType("System.String"))
                    For i As Integer = 0 To oDtExcel.Rows.Count - 1

                        If oDtExcel.Rows(i).Item("FSLDAL").ToString.Trim <> "" Then
                            oDtExcel.Rows(i).Item("FSLDAL1") = oDtExcel.Rows(i).Item("FSLDAL").ToString.Substring(0, 10)
                        End If

                        oDtExcel.AcceptChanges()
                    Next
                    oDtExcel.Columns.Remove("FSLDAL")
                    oDtExcel.Columns("FSLDAL1").SetOrdinal("6")

                    ExportarExcelItem(oDtExcel, "E", objTemp.Tables(0))
                Else
                    oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")
                    ExportarExcelSubItem(oDtExcel, "E", objTemp.Tables(0))
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

      
    End Sub

    Private Sub tsmModelo02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmModelo02.Click
        Try
            If fblnValidaInformacion() Then
                Dim obeFiltro As New beFiltrosDespachoPorAlmacen
                Dim obrReporteAT As New brReporteAT
                Dim dt As DataTable
                Dim Est As String = txtCliente2.Resultado.GetType.ToString
                With obeFiltro
                    '.PNCCLNT = txtCliente.pCodigo
                    If Est = "Ransa.Utilitario.beCliente" Then
                        .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                    Else
                        .PSCCLNT = ListaCodigoClientes()
                    End If
                    If txtCodigoRecepcion.Text <> "" Then .PSCREFFW = txtCodigoRecepcion.Text.Replace(" ", "").Replace(",", "','")
                    .PNFECINI = dteFechaInicial.Value
                    .PNFECFIN = dteFechaFinal.Value
                    If txtUbicacionReferencial.Resultado IsNot Nothing Then
                        .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                    Else
                        .PSTUBRFR = ""
                    End If
                    .PSSTPING = "" & txtTipoMovimiento.Tag
                    .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = Me.UcDivision_Cmb011.Division
                    .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
                End With
                dt = obrReporteAT.fdtDespachoPorAlmacenModeloPerenco(obeFiltro)




                dt.Columns("FCHRMD").ColumnName = "FECHA SOLICITUD"
                dt.Columns("NORCML").ColumnName = "P.O"
                dt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dt.Columns("NGUIRM").ColumnName = "N° DE GUÍA"

                dt.Columns("GLOSA_GR").ColumnName = "GLOSA GUÍA"


                'dt.Columns("NGUIRS").ColumnName = "N° DE GUÍA"
                dt.Columns("TRFRN").ColumnName = "REQUERIDO POR"
                dt.Columns("TDSDES").ColumnName = "PRIORIDAD"
                dt.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
                dt.Columns("TIPBTO").ColumnName = "TIPO DE EMPAQUE"
                dt.Columns("QCTPQT").ColumnName = "NRO. DE BULTOS"
                dt.Columns("QMTLRG").ColumnName = "LARGO (MTS)"
                dt.Columns("QMTANC").ColumnName = "ANCHO (MTS)"
                dt.Columns("QMTALT").ColumnName = "ALTO (MTS)"
                dt.Columns("QVOLMR").ColumnName = "VOLÚMEN (M3)"
                dt.Columns("QPSOBL").ColumnName = "PESO (KG)"
                dt.Columns("PESVOL").ColumnName = "PESO / VOLÚMEN"

                dt.Columns("TCMTRT").ColumnName = "TRANSPORTISTA"
                dt.Columns("NPLCTR").ColumnName = "EMBARCACIÓN / AERONAVE"
                dt.Columns("ORIGEN").ColumnName = "ORIGEN"
                dt.Columns("DESTINO").ColumnName = "DESTINO"
                dt.Columns("FSLFFW").ColumnName = "FECHA DE SALIDA"
                dt.Columns("FECETA").ColumnName = "FECHA PREVISTA DE LLEGADA"
                dt.Columns("UBICA").ColumnName = "UBICACIÓN ACTUAL"

                dt.Columns("FCHFTR").ColumnName = "FECHA DE LLEGADA"
                dt.Columns("FLGCNL").ColumnName = "ESTATUS"
                dt.Columns("OBSER").ColumnName = "OBSERVACIÓN"



                Dim oDs As New DataSet
                oDs.Tables.Add(dt)
                Dim strlTitulo As New List(Of String)
                'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
                strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
                If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                    strlTitulo.Add("Ubicación :\nTODOS")
                Else
                    strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
                End If
                If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                    strlTitulo.Add("Tipo de Mov.:\nTODOS")
                Else
                    strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
                End If
                strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
                HelpClass.ExportExcelConTitulosModeloPerenco(oDs, Me.Text, strlTitulo)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub rbtOrdenDeCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOrdenDeCompra.CheckedChanged
        tsmModelo02.Visible = True
        tsmModelo02Chinalco.Visible = False

        If rbtOrdenDeCompra.Checked = True Then
            VisualizarGrilla("OC")
            pListarReporteGrilla()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub rbtItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtItem.CheckedChanged
        tsmModelo02.Visible = False
        tsmModelo02Chinalco.Visible = True
        If rbtItem.Checked = True Then
            VisualizarGrilla("IT")
            pListarReporteGrilla()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub rbtSubitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSubitem.CheckedChanged
        tsmModelo02.Visible = False
        tsmModelo02Chinalco.Visible = False
        If rbtSubitem.Checked = True Then
            VisualizarGrilla("SU")
            pListarReporteGrilla()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If rbtOrdenDeCompra.Checked Then
            pReporteDespachoPorAlmacenOc()
        ElseIf rbtItem.Checked Then
            pReporteDespachoPorAlmacenItem()
        Else
            pReporteDespachoPorAlmacenSubItem()
        End If

    End Sub

    Private Sub txtCliente2_CambioDeTexto(ByVal objData As Object) Handles txtCliente2.CambioDeTexto
        CargarUbicacion()
    End Sub

    Private Sub tsmModelo02Chinalco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmModelo02Chinalco.Click
        Try
            If fblnValidaInformacion() Then
                Dim NPOI As New HelpClass_NPOI_SA

                Dim obeFiltro As New beFiltrosDespachoPorAlmacen
                Dim obrReporteAT As New brReporteAT
                Dim dt As New DataTable
                Dim Est As String = txtCliente2.Resultado.GetType.ToString
                With obeFiltro
                    '.PNCCLNT = txtCliente.pCodigo
                    If Est = "Ransa.Utilitario.beCliente" Then
                        .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                    Else
                        .PSCCLNT = ListaCodigoClientes()
                    End If
                    If txtCodigoRecepcion.Text <> "" Then .PSCREFFW = txtCodigoRecepcion.Text.Replace(" ", "").Replace(",", "','")
                    .PNFECINI = dteFechaInicial.Value
                    .PNFECFIN = dteFechaFinal.Value
                    If txtUbicacionReferencial.Resultado IsNot Nothing Then
                        .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                    Else
                        .PSTUBRFR = ""
                    End If
                    .PSSTPING = "" & txtTipoMovimiento.Tag
                    .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = Me.UcDivision_Cmb011.Division
                    .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
                End With

                dt.Columns.Add("ORDEN DE COMPRA", System.Type.GetType("System.String"))
                dt.Columns.Add("COD. PRODUCTO", System.Type.GetType("System.String"))
                dt.Columns.Add("DESCRIPCIÓN DEL ITEM", System.Type.GetType("System.String"))
                'dt.Columns.Add("CANTIDAD", System.Type.GetType("System.Decimal"))
                dt.Columns.Add("CANTIDAD", Type.GetType("System.Int64")) '.Caption = NPOI.FormatDato("CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero, HelpClass_NPOI_SA.keyAlinHDerecho)

                dt.Columns.Add("UNIDAD", System.Type.GetType("System.String"))
                dt.Columns.Add("FECHA", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA", HelpClass_NPOI_SA.keyDatoFecha)
                '  dt.Columns.Add("FECHA", System.Type.GetType("System.String"))


                dt.Columns.Add("CENTRO", System.Type.GetType("System.String"))

                dt.Columns.Add("ALMACÉN PROCEDENCIA", System.Type.GetType("System.String"))
                dt.Columns.Add("ALMACÉN DESTINO", System.Type.GetType("System.String"))
                dt.Columns.Add("SOLICITANTE", System.Type.GetType("System.String"))
                dt.Columns.Add("LOTE", System.Type.GetType("System.String"))
                dt.Columns.Add("DIRECCIÓN", System.Type.GetType("System.String"))
                dt.Columns.Add("CLASE DE VALORACIÓN", System.Type.GetType("System.String"))

                ''''''''''''''''''''''''''
                Dim drAlt As DataRow
                For Each dr As DataRow In objTemp.Tables(0).Rows

                    drAlt = dt.NewRow

                    drAlt("ORDEN DE COMPRA") = dr("NORCML")
                    drAlt("COD. PRODUCTO") = dr("TCITCL")
                    drAlt("DESCRIPCIÓN DEL ITEM") = dr("TDITES")
                    drAlt("CANTIDAD") = dr("QBLTSR")
                    drAlt("UNIDAD") = dr("TUNDIT")
                    If dr("FREFFW").ToString <> "" Then
                        drAlt("FECHA") = dr("FREFFW").ToString.Substring(0, 10)
                    Else
                        drAlt("FECHA") = dr("FREFFW")
                    End If
                    drAlt("CENTRO") = dr("TRFRN1")
                    drAlt("ALMACÉN PROCEDENCIA") = dr("TRFRN4")
                    drAlt("ALMACÉN DESTINO") = dr("TRFRN2")
                    drAlt("SOLICITANTE") = dr("TRFRN")
                    drAlt("LOTE") = dr("TRFRNA")
                    drAlt("DIRECCIÓN") = dr("TRFRN5")
                    drAlt("CLASE DE VALORACIÓN") = dr("TRFRN6")


                    dt.Rows.Add(drAlt)
                Next

                ''''''''''''''''''''''''''''

                Dim oDs As New DataSet
                oDs.Tables.Add(dt)
                Dim strlTitulo As New List(Of String)


                'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
                strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
                If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                    strlTitulo.Add("Ubicación :\nTODOS")
                Else
                    strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
                End If
                If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                    strlTitulo.Add("Tipo de Mov.:\nTODOS")
                Else
                    strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
                End If
                strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
                '  HelpClass.ExportExcelConTitulosModeloPerenco(oDs, Me.Text, strlTitulo)
                HelpClass.ExportExcelConTitulosAlmacen(oDs, "SALIDA POR ALMACEN FORMATO CHINALCO", strlTitulo)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
End Class


