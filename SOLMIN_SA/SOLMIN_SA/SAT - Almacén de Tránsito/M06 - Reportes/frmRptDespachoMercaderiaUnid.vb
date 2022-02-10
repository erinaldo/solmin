Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes

Imports RANSA.Utilitario


Public Class frmRptDespachoMercaderiaUnid

    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""

    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private Sub frmRptSalidaXAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing



    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As RANSA.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
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
            btnExportar.Enabled = False
            btnGenerarReporte.Enabled = False

            bgwGifAnimado.RunWorkerAsync()
        End If
    End Sub
    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtCliente.pCodigo = 0 Then strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        Return blnResultado
    End Function

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGenerarReporte()
    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        btnGenerarReporte.Enabled = True
        tsbEnviarCorreo.Enabled = True
        tsbExportarExcel.Enabled = True
        btnExportar.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub
    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        pReporteGuiaSalidaMercaderia()
        strDetalleReporte = "Guía de Salida Mercadería"
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteGuiaSalidaMercaderia()
        Dim dstTemp As DataSet = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        With obeFiltro
            .PNCCLNT = txtCliente.pCodigo
            .PNFECINI = dteFechaInicial.Value
            .PNFECFIN = dteFechaFinal.Value
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PSNPLCUN = txtPlaca.Text.Trim.ToUpper
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte
        Dim rptTemp As ReportDocument

        dstTemp = obrReporteAT.fdstGuiaSalidaMercaderia(obeFiltro)
        If dstTemp.Tables.Count > 0 Then

            If rbtItem.Checked Then
                rptTemp = New rptDespachoMercaderiaUnidad
                dstTemp.Tables(0).TableName = "dtGuiaSalidaMercaderia"
                rptTemp.SetDataSource(dstTemp.Tables(0))
                rptTemp.Refresh()
                ' Ingresamos parametros adicionales
                rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
                rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
                ' Generamos el Nuevo Tipo de Datos
                objTemp2.add_Tables(dstTemp)
                objTemp2.pReporte = rptTemp
            Else
                rptTemp = New rptDespachoMercaderiaUnidadSubItem
                dstTemp.Tables(0).TableName = "dtGuiaSalidaMercaderia"
                rptTemp.SetDataSource(dstTemp.Tables(0))
                rptTemp.Refresh()
                ' Ingresamos parametros adicionales
                rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
                rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
                rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
                ' Generamos el Nuevo Tipo de Datos
                objTemp2.add_Tables(dstTemp)
                objTemp2.pReporte = rptTemp
            End If
          
        End If

        objTemp = objTemp2

    End Sub

    Private Function ReturnTableFormatedIngresoEgreso(ByVal tabla As DataTable, ByVal llave As String) As DataTable
        Return Nothing
    End Function

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
            If Me.rbtItem.Checked Then
                Dim oDtExcel As New DataTable
                oDtExcel = EliminarRepetidoItems(objTemp.Tables(0))
                'ExportarExcel(oDtExcel)
                ExportarExcel_Modelo1(oDtExcel)
            Else
                'ExportarExcelSubItem(objTemp.Tables(0))
                ExportarExcel_Modelo1(objTemp.Tables(0))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub ExportarExcel_Modelo1(ByVal oDtExcel As DataTable)

        Dim oDs As New DataSet

        Dim dtview As New DataView
        dtview = oDtExcel.DefaultView
        dtview.Sort = "FSLFFW ASC,NGUIRM ASC , CREFFW ASC"
        oDtExcel = dtview.ToTable()


        Dim dtExport As New DataTable
        dtExport.Columns.Add("FSLDAL")
        dtExport.Columns.Add("NGUIRM")
        dtExport.Columns.Add("NPLCUN")
        dtExport.Columns.Add("TABDES")
        dtExport.Columns.Add("NPLCAC")
        dtExport.Columns.Add("TDEACP")
        dtExport.Columns.Add("TNMBCH")
        dtExport.Columns.Add("CREFFW")
        dtExport.Columns.Add("ZONA")
        dtExport.Columns.Add("QREFFW", GetType(Decimal))

        dtExport.Columns.Add("QBLTO_X_GUIA", Type.GetType("System.Decimal"))

        dtExport.Columns.Add("TIPBTO")
        dtExport.Columns.Add("TPRVCL")
        dtExport.Columns.Add("NGRPRV")
        dtExport.Columns.Add("NORCML")
        dtExport.Columns.Add("TCITCL")
        dtExport.Columns.Add("TDITES")
        dtExport.Columns.Add("QBLTSR", GetType(Decimal))
        dtExport.Columns.Add("TUNDIT")
        dtExport.Columns.Add("QPSOBL", GetType(Decimal))
        dtExport.Columns.Add("TUNPSO")

        dtExport.Columns.Add("PBLTO_X_GUIA", GetType(Decimal))
        dtExport.Columns.Add("PGUIA", GetType(Decimal))

        dtExport.Columns.Add("IVUNIT", GetType(Decimal))
        dtExport.Columns.Add("IMPTOL", GetType(Decimal))
        dtExport.Columns.Add("TLUGEN")


        If Me.rbtsubItem.Checked Then

            dtExport.Columns.Add("SBITOC")
            dtExport.Columns.Add("TCITCL1")
            dtExport.Columns.Add("TDITES1")
            dtExport.Columns.Add("QCNRCP")
            dtExport.Columns.Add("TUNDIT1")
            dtExport.Columns.Add("IVUNIT1")
            dtExport.Columns.Add("IMPTOL1")

        End If


        Dim dr As DataRow
        Dim listFecha As New Hashtable
        Dim listGuias As New Hashtable
        Dim listGuiasPeso As New Hashtable
        Dim listGuiaBulto As New Hashtable
        Dim dato As String = ""




        Dim IndexF As Int32 = 0
        For Each item As DataRow In oDtExcel.Rows
            dr = dtExport.NewRow

            For Each itemcol As DataColumn In oDtExcel.Columns
                If (dtExport.Columns.Contains(itemcol.ColumnName)) Then
                    dr(itemcol.ColumnName) = item(itemcol.ColumnName)
                End If
            Next


            dato = dr("NGUIRM").ToString.Trim & "_" & dr("CREFFW").ToString.Trim
            If listGuiaBulto.Contains(dato) Then
                dr("PBLTO_X_GUIA") = DBNull.Value
                dr("QBLTO_X_GUIA") = DBNull.Value

            Else
                dr("PBLTO_X_GUIA") = dr("QPSOBL")
                dr("QBLTO_X_GUIA") = dr("QREFFW")
                listGuiaBulto.Add(dato, dato)
            End If


            dtExport.Rows.Add(dr)
        Next


        Dim Fila As Int32 = 0

        For Each item As DataRow In dtExport.Rows

            Fila = Fila + 1

            dato = item("NGUIRM").ToString.Trim
            If listGuiasPeso.Contains(dato) Then
                item("PGUIA") = DBNull.Value
            Else
                item("PGUIA") = dtExport.Compute("SUM(PBLTO_X_GUIA)", "NGUIRM='" & dato & "'")
                listGuiasPeso.Add(dato, dato)
            End If


            'item("FSLDAL") = Split(item("FSLDAL"))(0)
            dato = item("FSLDAL").ToString.Trim
            If listFecha.Contains(dato) Then
                IndexF = listFecha(dato)
                If IndexF + 1 = Fila Then
                    item("FSLDAL") = ""
                    listFecha(dato) = listFecha(dato) + 1
                End If
            Else
                listFecha.Add(dato, Fila)
            End If

            dato = item("NGUIRM").ToString.Trim
            If listGuias.Contains(dato) Then
                IndexF = listGuias(dato)
                If IndexF + 1 = Fila Then
                    item("NGUIRM") = ""
                    item("NPLCUN") = ""
                    item("TABDES") = ""
                    item("NPLCAC") = ""
                    item("TDEACP") = ""
                    item("TNMBCH") = ""
                    listGuias(dato) = listGuias(dato) + 1
                End If
            Else
                listGuias.Add(dato, Fila)
            End If

        Next

        dtExport.Columns("FSLDAL").ColumnName = "FECHA DESPACHO"
        dtExport.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
        dtExport.Columns("NPLCUN").ColumnName = "NRO. PLACA"
        dtExport.Columns("TABDES").ColumnName = "TIPO TRACTO"

        dtExport.Columns("NPLCAC").ColumnName = "ACOPLADO"
        dtExport.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"

        dtExport.Columns("TNMBCH").ColumnName = "CHOFER"
        dtExport.Columns("CREFFW").ColumnName = "BULTO"
        dtExport.Columns("ZONA").ColumnName = "ZONA"
        dtExport.Columns("QREFFW").ColumnName = "CANTIDAD BULTO"

        dtExport.Columns("QBLTO_X_GUIA").ColumnName = "CANT BULT POR GUIA"



        dtExport.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        dtExport.Columns("TPRVCL").ColumnName = "PROVEEDOR CLIENTE"
        dtExport.Columns("NGRPRV").ColumnName = "GUÍA DE PROVEEDOR"
        dtExport.Columns("NORCML").ColumnName = "ORDEN COMPRA/ITEM"
        dtExport.Columns("TCITCL").ColumnName = "COD. ITEM"
        dtExport.Columns("TDITES").ColumnName = "DESCRIPCION ITEM"
        dtExport.Columns("QBLTSR").ColumnName = "CANTIDAD ITEM DESPACHADO"
        dtExport.Columns("TUNDIT").ColumnName = "UNID. MEDIDA "
        dtExport.Columns("QPSOBL").ColumnName = "PESO BULTO"
        dtExport.Columns("TUNPSO").ColumnName = "UNID. MEDIDA PESO"

        dtExport.Columns("PBLTO_X_GUIA").ColumnName = "PESO X GUIA BULTO"
        dtExport.Columns("PGUIA").ColumnName = "PESO X GUIA"

        dtExport.Columns("IVUNIT").ColumnName = "IMPORTE UNID. ITEM"
        dtExport.Columns("IMPTOL").ColumnName = "IMPORTE TOTAL ITEM"
        dtExport.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"


        If Me.rbtsubItem.Checked Then

            dtExport.Columns("SBITOC").ColumnName = "SUBITEM"
            dtExport.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
            dtExport.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"""
            dtExport.Columns("QCNRCP").ColumnName = "CANTIDAD SUBITEM"
            dtExport.Columns("TUNDIT1").ColumnName = "UNIDAD DE MEDIDA"
            dtExport.Columns("IVUNIT1").ColumnName = "IMPORTE UNID. SUBITEM"
            dtExport.Columns("IMPTOL1").ColumnName = "IMPORTE TOTAL. SUBITEM"

        End If


        oDs.Tables.Add(dtExport)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

        If Me.txtPlaca.Text.Trim = "" Then
            strlTitulo.Add("Placa :\nTODOS")
        Else
            strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
        End If
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub


        'Private Sub ExportarExcel(ByVal oDtExcel As DataTable)
        '    Dim oDt As New DataTable
        '    Dim oDs As New DataSet

        '    oDt = oDtExcel.Clone

     

        '    oDt.Columns(2).DataType = GetType(String)
        '    oDt.Columns(3).DataType = GetType(String)
        '    oDt.Columns("QBLTSR").DataType = GetType(String)
        '    oDt.Columns("NGRPRV").DataType = GetType(String)
        '    'Cambiamos Orden------------------
        '    For i As Integer = 0 To oDtExcel.Rows.Count - 1
        '        oDt.ImportRow(oDtExcel.Rows(i))
        '        oDt.Rows(i).Item("FSLDAL") = Split(oDtExcel.Rows(i).Item("FSLDAL"))(0)
        '    Next
        '    'Quitamos columnas a no usar------
        '    oDt.Columns.Remove("CCLNT")
        '    oDt.Columns.Remove("TCMPCL")
        '    oDt.Columns.Remove("NRGUSA")
        '    'oDt.Columns.Remove("NPLCAC")
        '    oDt.Columns.Remove("CTRSPT")
        '    oDt.Columns.Remove("CBRCNT")
        '    oDt.Columns.Remove("TABTRT")
        '    oDt.Columns.Remove("NRUCTR")
        '    oDt.Columns.Remove("NRITOC")


        '    oDt.Columns.Remove("CIDPAQ")
        '    oDt.Columns.Remove("SBITOC")
        '    oDt.Columns.Remove("TCITCL1")
        '    oDt.Columns.Remove("TDITES1")
        '    oDt.Columns.Remove("QCNRCP")
        '    oDt.Columns.Remove("TUNDIT1")
        '    oDt.Columns.Remove("IVUNIT1")
        '    oDt.Columns.Remove("IMPTOL1")
        '    oDt.Columns.Remove("OC")
        '    oDt.Columns.Remove("ITEM")

        '    'dtTemp3.Columns.Remove("NGRPRV")
        '    '---------------------------------
        '    oDt.Columns(0).ColumnName = "FECHA DESPACHO"
        '    oDt.Columns(1).ColumnName = "GUIA REMISIÓN"
        '    oDt.Columns(2).ColumnName = "NRO. PLACA"
        '    oDt.Columns(3).ColumnName = "TIPO TRACTO"

        '    oDt.Columns(4).ColumnName = "ACOPLADO"
        '    oDt.Columns(5).ColumnName = "TIPO ACOPLADO"

        '    oDt.Columns(6).ColumnName = "CHOFER"
        '    oDt.Columns(7).ColumnName = "BULTO"
        '    oDt.Columns(8).ColumnName = "ZONA"
        '    oDt.Columns(9).ColumnName = "CANTIDAD BULTO"
        '    oDt.Columns(10).ColumnName = "TIPO BULTO"
        '    oDt.Columns(11).ColumnName = "PROVEEDOR CLIENTE"
        '    oDt.Columns(12).ColumnName = "GUÍA DE PROVEEDOR"
        '    oDt.Columns(13).ColumnName = "ORDEN COMPRA/ITEM"
        '    oDt.Columns(14).ColumnName = "COD. ITEM"
        '    oDt.Columns(15).ColumnName = "DESCRIPCION ITEM"
        '    oDt.Columns(16).ColumnName = "CANTIDAD ITEM DESPACHADO"
        '    oDt.Columns(17).ColumnName = "UNID. MEDIDA "
        '    oDt.Columns(18).ColumnName = "PESO BULTO"
        '    oDt.Columns(19).ColumnName = "UNID. MEDIDA PESO"
        '    oDt.Columns(20).ColumnName = "IMPORTE UNID. ITEM"
        '    oDt.Columns(21).ColumnName = "IMPORTE TOTAL ITEM"
        '    oDt.Columns(22).ColumnName = "LUGAR DESTINO"

        '    '=====================QUIEBRES==========================
        '    Dim itemp As Integer = 0
        '    Dim iCambia As Boolean = True
        '    For i As Integer = 0 To oDt.Rows.Count - 1
        '        If iCambia = True Then
        '            itemp = i - 1
        '        End If
        '        If i > 0 Then
        '            If oDt.Rows(i).Item("FECHA DESPACHO") = oDt.Rows(itemp).Item("FECHA DESPACHO") Then
        '                oDt.Rows(i).Item("FECHA DESPACHO") = ""
        '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
        '                iCambia = False
        '            Else
        '                iCambia = True
        '            End If
        '        End If
        '    Next
        '    '======================================================
        '    itemp = 0
        '    iCambia = True
        '    For i As Integer = 0 To oDt.Rows.Count - 1
        '        If iCambia = True Then
        '            itemp = i - 1
        '        End If
        '        If i > 0 Then
        '            If oDt.Rows(i).Item("GUIA REMISIÓN") = oDt.Rows(itemp).Item("GUIA REMISIÓN") Then
        '                oDt.Rows(i).Item("GUIA REMISIÓN") = ""
        '                oDt.Rows(i).Item("NRO. PLACA") = ""
        '                oDt.Rows(i).Item("TIPO TRACTO") = ""
        '                oDt.Rows(i).Item("ACOPLADO") = ""
        '                oDt.Rows(i).Item("TIPO ACOPLADO") = ""
        '                oDt.Rows(i).Item("CHOFER") = ""

        '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
        '                iCambia = False
        '            Else
        '                iCambia = True
        '            End If
        '        End If
        '    Next
        '    oDs.Tables.Add(oDt)

        '    Dim strlTitulo As New List(Of String)
        '    strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        '    strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

        '    If Me.txtPlaca.Text.Trim = "" Then
        '        strlTitulo.Add("Placa :\nTODOS")
        '    Else
        '        strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
        '    End If
        '    strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        '    HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
        'End Sub

    'Private Sub ExportarExcel1(ByVal oDtExcel As DataTable)
    '    Dim oDt As New DataTable
    '    Dim oDs As New DataSet
    '    oDt = oDtExcel.Clone

    '    oDt.Columns(2).DataType = GetType(String)
    '    oDt.Columns(3).DataType = GetType(String)
    '    oDt.Columns("QBLTSR").DataType = GetType(String)
    '    oDt.Columns("NGRPRV").DataType = GetType(String)
    '    'Cambiamos Orden------------------
    '    For i As Integer = 0 To oDtExcel.Rows.Count - 1
    '        oDt.ImportRow(oDtExcel.Rows(i))
    '        oDt.Rows(i).Item("FSLDAL") = Split(oDtExcel.Rows(i).Item("FSLDAL"))(0)
    '    Next

    '    'Quitamos columnas a no usar------
    '    oDt.Columns.Remove("CCLNT")
    '    oDt.Columns.Remove("TCMPCL")
    '    oDt.Columns.Remove("NRGUSA")
    '    oDt.Columns.Remove("NPLCAC")
    '    oDt.Columns.Remove("CTRSPT")
    '    oDt.Columns.Remove("CBRCNT")
    '    oDt.Columns.Remove("TABTRT")
    '    oDt.Columns.Remove("NRUCTR")
    '    oDt.Columns.Remove("NRITOC")
    '    oDt.Columns.Remove("NORCML")
    '    oDt.Columns.Remove("CIDPAQ")
    '    oDt.Columns.Remove("SBITOC")
    '    oDt.Columns.Remove("TCITCL1")
    '    oDt.Columns.Remove("TDITES1")
    '    oDt.Columns.Remove("QCNRCP")
    '    oDt.Columns.Remove("TUNDIT1")
    '    oDt.Columns.Remove("IVUNIT1")
    '    oDt.Columns.Remove("IMPTOL1")

    '    'dtTemp3.Columns.Remove("NGRPRV")
    '    '---------------------------------

    '    oDt.Columns.Remove("TDEACP")
    '    'oDt.Columns.Remove("TABDES")
    '    'oDt.Columns.Remove("NPLCUN")
    '    oDt.Columns.Remove("ZONA")
    '    oDt.Columns.Remove("NGRPRV")
    '    oDt.Columns.Remove("TCITCL")
    '    oDt.Columns.Remove("TUNPSO")
    '    oDt.Columns.Remove("IVUNIT")
    '    oDt.Columns.Remove("IMPTOL")

    '    'Mover de ubicacion las columnas
    '    oDt.Columns(6).SetOrdinal(5)
    '    oDt.Columns(3).SetOrdinal(4)
    '    oDt.Columns(6).SetOrdinal(5)
    '    oDt.Columns(7).SetOrdinal(6)
    '    oDt.Columns(12).SetOrdinal(11)
    '    oDt.Columns(13).SetOrdinal(14)

    '    'oDt.Columns(13).SetOrdinal(9)
    '    'oDt.Columns(15).SetOrdinal(10)

    '    Dim dtExcel As New DataTable
    '    Dim row As DataRow
    '    dtExcel.Columns.Add("FSLDAL")
    '    dtExcel.Columns.Add("NGUIRM")
    '    dtExcel.Columns.Add("NPLCUN")
    '    dtExcel.Columns.Add("TNMBCH")
    '    dtExcel.Columns.Add("TABDES")
    '    dtExcel.Columns.Add("CREFFW")
    '    dtExcel.Columns.Add("TIPBTO")
    '    dtExcel.Columns.Add("QREFFW", Type.GetType("System.Decimal"))
    '    dtExcel.Columns.Add("TPRVCL")
    '    dtExcel.Columns.Add("OC")
    '    dtExcel.Columns.Add("ITEM")
    '    dtExcel.Columns.Add("TDITES")
    '    dtExcel.Columns.Add("TUNDIT")
    '    dtExcel.Columns.Add("QBLTSR", Type.GetType("System.Decimal"))
    '    dtExcel.Columns.Add("TLUGEN")
    '    dtExcel.Columns.Add("QPSOBL", Type.GetType("System.Decimal"))



    '    For Each dr As DataRow In oDt.Rows
    '        row = dtExcel.NewRow
    '        For Each cl As DataColumn In dtExcel.Columns
    '            row(cl.ColumnName) = dr(cl.ColumnName)

    '        Next
    '        dtExcel.Rows.Add(row)
    '    Next

    '    dtExcel.Columns(0).ColumnName = "FECHA DESPACHO"
    '    dtExcel.Columns(1).ColumnName = "GUÍA REMISIÓN CLIENTE"
    '    dtExcel.Columns(2).ColumnName = "NRO. PLACA"
    '    dtExcel.Columns(3).ColumnName = "NOMBRE DEL CHOFER"
    '    dtExcel.Columns(4).ColumnName = "TIPO DE UNIDAD"
    '    dtExcel.Columns(5).ColumnName = "CÓDIGO BULTO"
    '    dtExcel.Columns(6).ColumnName = "TIPO BULTO"
    '    dtExcel.Columns(7).ColumnName = "CANTIDAD EN BULTO"
    '    dtExcel.Columns(8).ColumnName = "NOMBRE DEL PROVEEDOR"
    '    dtExcel.Columns(9).ColumnName = "ORDEN COMPRA"
    '    dtExcel.Columns(10).ColumnName = "NRO ITEM"
    '    dtExcel.Columns(11).ColumnName = "DESCRIPCIÓN ITEM"
    '    dtExcel.Columns(12).ColumnName = "UNID. MEDIDA"
    '    dtExcel.Columns(13).ColumnName = "ÍTEM DESPACHO"
    '    dtExcel.Columns(14).ColumnName = "LUGAR DE DESTINO"
    '    dtExcel.Columns(15).ColumnName = "PESO BULTO KG"

    '    '=====================QUIEBRES==========================
    '    Dim itemp As Integer = 0
    '    Dim iCambia As Boolean = True
    '    For i As Integer = 0 To dtExcel.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If dtExcel.Rows(i).Item("FECHA DESPACHO") = dtExcel.Rows(itemp).Item("FECHA DESPACHO") Then
    '                dtExcel.Rows(i).Item("FECHA DESPACHO") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    '======================================================
    '    itemp = 0
    '    iCambia = True
    '    For i As Integer = 0 To dtExcel.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If dtExcel.Rows(i).Item("GUÍA REMISIÓN CLIENTE") = dtExcel.Rows(itemp).Item("GUÍA REMISIÓN CLIENTE") Then
    '                dtExcel.Rows(i).Item("GUÍA REMISIÓN CLIENTE") = ""
    '                dtExcel.Rows(i).Item("NRO. PLACA") = ""
    '                'oDt.Rows(i).Item("TIPO TRACTO") = ""
    '                'oDt.Rows(i).Item("ACOPLADO") = ""
    '                'oDt.Rows(i).Item("TIPO ACOPLADO") = ""
    '                dtExcel.Rows(i).Item("NOMBRE DEL CHOFER") = ""
    '                dtExcel.Rows(i).Item("TIPO DE UNIDAD") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    dtExcel.TableName = "DESPACHO MERCADERIA"
    '    oDs.Tables.Add(dtExcel)


    '    Dim strlTitulo As New List(Of String)
    '    strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
    '    strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

    '    If Me.txtPlaca.Text.Trim = "" Then
    '        strlTitulo.Add("Placa :\nTODOS")
    '    Else
    '        strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
    '    End If
    '    strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
    '    HelpClass.ExportExcelConTitulos(oDs, "Despacho Mercadería por Unidad", strlTitulo)
    'End Sub


    Private Sub ExportarExcel_Modelo2(ByVal oDtExcel As DataTable)

        Dim oDs As New DataSet


        Dim dtview As New DataView
        dtview = oDtExcel.DefaultView
        dtview.Sort = "FSLFFW ASC,NGUIRM ASC , CREFFW ASC"
        oDtExcel = dtview.ToTable()

        '        DataView dtV = tablaUno.DefaultView;
        'dtV.Sort = "Mes DESC, Dias DESC";
        'tablaUno = dtV.ToTable();


        Dim dtExport As New DataTable
        Dim row As DataRow
        dtExport.Columns.Add("FSLDAL")
        dtExport.Columns.Add("NGUIRM")
        dtExport.Columns.Add("NPLCUN")
        dtExport.Columns.Add("TNMBCH")
        dtExport.Columns.Add("TABDES")

        dtExport.Columns.Add("NPLCAC")
        dtExport.Columns.Add("TDEACP")

     

        dtExport.Columns.Add("CREFFW")
        dtExport.Columns.Add("TIPBTO")
        dtExport.Columns.Add("QREFFW", Type.GetType("System.Decimal"))

        dtExport.Columns.Add("QBLTO_X_GUIA", Type.GetType("System.Decimal"))

        dtExport.Columns.Add("TPRVCL")
        'dtExport.Columns.Add("OC")
        dtExport.Columns.Add("NORCML")


        dtExport.Columns.Add("NGRPRV")
        dtExport.Columns.Add("TCITCL")


        dtExport.Columns.Add("ITEM")


        If Me.rbtsubItem.Checked Then
            dtExport.Columns.Add("SBITOC")
        End If

        dtExport.Columns.Add("TDITES")
        dtExport.Columns.Add("TUNDIT")
        dtExport.Columns.Add("QBLTSR", Type.GetType("System.Decimal"))
        dtExport.Columns.Add("TLUGEN")
        dtExport.Columns.Add("QPSOBL", Type.GetType("System.Decimal"))

        dtExport.Columns.Add("PBLTO_X_GUIA", GetType(Decimal))
        dtExport.Columns.Add("PGUIA", GetType(Decimal))




        Dim IndexF As Int32 = 0
        Dim dato As String = ""
        Dim listFecha As New Hashtable
        Dim listGuias As New Hashtable
        Dim listGuiasPeso As New Hashtable
        Dim listGuiaBulto As New Hashtable



        For Each dr As DataRow In oDtExcel.Rows
            row = dtExport.NewRow

            For Each cl As DataColumn In dtExport.Columns
                'row(cl.ColumnName) = dr(cl.ColumnName)
                If (oDtExcel.Columns.Contains(cl.ColumnName)) Then
                    row(cl.ColumnName) = dr(cl.ColumnName)
                End If
            Next

            dato = row("NGUIRM").ToString.Trim & "_" & row("CREFFW").ToString.Trim
            If listGuiaBulto.Contains(dato) Then
                row("PBLTO_X_GUIA") = DBNull.Value
                row("QBLTO_X_GUIA") = DBNull.Value
            Else
                row("PBLTO_X_GUIA") = row("QPSOBL")
                row("QBLTO_X_GUIA") = row("QREFFW")
                listGuiaBulto.Add(dato, dato)
            End If



            dtExport.Rows.Add(row)
        Next


        Dim Fila As Int32 = 0

        For Each item As DataRow In dtExport.Rows
            Fila = Fila + 1
            dato = item("NGUIRM").ToString.Trim
            If listGuiasPeso.Contains(dato) Then
                item("PGUIA") = DBNull.Value
            Else
                item("PGUIA") = dtExport.Compute("SUM(PBLTO_X_GUIA)", "NGUIRM='" & dato & "'")
                listGuiasPeso.Add(dato, dato)
            End If

            'item("FSLDAL") = Split(item("FSLDAL"))(0)

            dato = item("FSLDAL").ToString.Trim
            If listFecha.Contains(dato) Then
                IndexF = listFecha(dato)
                If IndexF + 1 = Fila Then
                    item("FSLDAL") = ""
                    listFecha(dato) = listFecha(dato) + 1
                End If
            Else
                listFecha.Add(dato, Fila)
            End If

            dato = item("NGUIRM").ToString.Trim
            If listGuias.Contains(dato) Then
                IndexF = listGuias(dato)
                If IndexF + 1 = Fila Then
                    item("NGUIRM") = ""
                    item("NPLCUN") = ""
                    item("TABDES") = ""
                    item("TNMBCH") = ""

                    item("NPLCAC") = ""
                    item("TDEACP") = ""

                    listGuias(dato) = listGuias(dato) + 1
                End If
            Else
                listGuias.Add(dato, Fila)
            End If


        Next


        dtExport.Columns("FSLDAL").ColumnName = "FECHA DESPACHO"
        dtExport.Columns("NGUIRM").ColumnName = "GUÍA REMISIÓN CLIENTE"
        dtExport.Columns("NPLCUN").ColumnName = "NRO. PLACA"
        dtExport.Columns("TNMBCH").ColumnName = "NOMBRE DEL CHOFER"
        dtExport.Columns("TABDES").ColumnName = "TIPO DE UNIDAD"


        dtExport.Columns("NPLCAC").ColumnName = "ACOPLADO"
        dtExport.Columns("TDEACP").ColumnName = "TIPO ACOPLADO"


        dtExport.Columns("CREFFW").ColumnName = "CÓDIGO BULTO"
        dtExport.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        dtExport.Columns("QREFFW").ColumnName = "CANTIDAD EN BULTO"


        dtExport.Columns("QBLTO_X_GUIA").ColumnName = "CANT BULT POR GUIA"


        dtExport.Columns("TPRVCL").ColumnName = "NOMBRE DEL PROVEEDOR"        
        'dtExport.Columns("OC").ColumnName = "ORDEN COMPRA"
        dtExport.Columns("NORCML").ColumnName = "ORDEN COMPRA"

        dtExport.Columns("NGRPRV").ColumnName = "GUÍA DE PROVEEDOR"
        dtExport.Columns("TCITCL").ColumnName = "COD. ITEM"


        dtExport.Columns("ITEM").ColumnName = "NRO ITEM"

        If Me.rbtsubItem.Checked Then
            dtExport.Columns("SBITOC").ColumnName = "NRO SUB ITEM"
        End If

        dtExport.Columns("TDITES").ColumnName = "DESCRIPCIÓN ITEM"
        dtExport.Columns("TUNDIT").ColumnName = "UNID. MEDIDA"
        dtExport.Columns("QBLTSR").ColumnName = "CANTIDAD ITEM DESPACHADO" 'ÍTEM DESPACHO"
        dtExport.Columns("TLUGEN").ColumnName = "LUGAR DE DESTINO"
        dtExport.Columns("QPSOBL").ColumnName = "PESO BULTO KG"

        dtExport.Columns("PBLTO_X_GUIA").ColumnName = "PESO X GUIA BULTO"
        dtExport.Columns("PGUIA").ColumnName = "PESO X GUIA"


        dtExport.TableName = "DESPACHO MERCADERIA"
        oDs.Tables.Add(dtExport)


        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

        If Me.txtPlaca.Text.Trim = "" Then
            strlTitulo.Add("Placa :\nTODOS")
        Else
            strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
        End If
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(oDs, "Despacho Mercadería por Unidad", strlTitulo)
    End Sub


    'Private Sub ExportarExcelSubItem1(ByVal oDtExcel As DataTable)
    '    Dim oDt As New DataTable
    '    Dim oDs As New DataSet
    '    oDt = oDtExcel.Clone

    '    oDt.Columns(2).DataType = GetType(String)
    '    oDt.Columns(3).DataType = GetType(String)
    '    oDt.Columns("QBLTSR").DataType = GetType(String)
    '    oDt.Columns("NGRPRV").DataType = GetType(String)
    '    'Cambiamos Orden------------------
    '    For i As Integer = 0 To oDtExcel.Rows.Count - 1
    '        oDt.ImportRow(oDtExcel.Rows(i))
    '        oDt.Rows(i).Item("FSLDAL") = Split(oDtExcel.Rows(i).Item("FSLDAL"))(0)
    '    Next
    '    'Quitamos columnas a no usar------
    '    oDt.Columns.Remove("CCLNT")
    '    oDt.Columns.Remove("TCMPCL")
    '    oDt.Columns.Remove("NRGUSA")
    '    oDt.Columns.Remove("NPLCAC")
    '    oDt.Columns.Remove("CTRSPT")
    '    oDt.Columns.Remove("CBRCNT")
    '    oDt.Columns.Remove("TABTRT")
    '    oDt.Columns.Remove("NRUCTR")



    '    oDt.Columns.Remove("CIDPAQ")

    '    oDt.Columns.Remove("TCITCL1")
    '    oDt.Columns.Remove("TDITES1")
    '    oDt.Columns.Remove("QCNRCP")
    '    oDt.Columns.Remove("TUNDIT1")
    '    oDt.Columns.Remove("IVUNIT1")
    '    oDt.Columns.Remove("IMPTOL1")


    '    '---------------------------------
    '    oDt.Columns.Remove("TDEACP")

    '    oDt.Columns.Remove("ZONA")
    '    oDt.Columns.Remove("NGRPRV")
    '    oDt.Columns.Remove("TCITCL")
    '    oDt.Columns.Remove("TUNPSO")
    '    oDt.Columns.Remove("IVUNIT")
    '    oDt.Columns.Remove("IMPTOL")
    '    oDt.Columns.Remove("NORCML")

    '    'Mover de ubicacion las columnas
    '    oDt.Columns(6).SetOrdinal(5)
    '    oDt.Columns(3).SetOrdinal(4)
    '    oDt.Columns(6).SetOrdinal(5)
    '    oDt.Columns(7).SetOrdinal(6)
    '    oDt.Columns(12).SetOrdinal(11)


    '    Dim dtExcel As New DataTable
    '    Dim row As DataRow
    '    dtExcel.Columns.Add("FSLDAL")
    '    dtExcel.Columns.Add("NGUIRM")
    '    dtExcel.Columns.Add("NPLCUN")
    '    dtExcel.Columns.Add("TNMBCH")
    '    dtExcel.Columns.Add("TABDES")
    '    dtExcel.Columns.Add("CREFFW")
    '    dtExcel.Columns.Add("TIPBTO")
    '    dtExcel.Columns.Add("QREFFW", Type.GetType("System.Decimal"))
    '    dtExcel.Columns.Add("TPRVCL")
    '    dtExcel.Columns.Add("OC")
    '    dtExcel.Columns.Add("ITEM")
    '    dtExcel.Columns.Add("SBITOC")
    '    dtExcel.Columns.Add("TDITES")
    '    dtExcel.Columns.Add("TUNDIT")
    '    dtExcel.Columns.Add("QBLTSR", Type.GetType("System.Decimal"))
    '    dtExcel.Columns.Add("TLUGEN")
    '    dtExcel.Columns.Add("QPSOBL", Type.GetType("System.Decimal"))


    '    For Each dr As DataRow In oDt.Rows
    '        row = dtExcel.NewRow
    '        For Each cl As DataColumn In dtExcel.Columns
    '            row(cl.ColumnName) = dr(cl.ColumnName)

    '        Next
    '        dtExcel.Rows.Add(row)
    '    Next

    '    dtExcel.Columns(0).ColumnName = "FECHA DESPACHO"
    '    dtExcel.Columns(1).ColumnName = "GUÍA REMISIÓN CLIENTE"
    '    dtExcel.Columns(2).ColumnName = "NRO. PLACA"
    '    dtExcel.Columns(3).ColumnName = "NOMBRE DEL CHOFER"
    '    dtExcel.Columns(4).ColumnName = "TIPO DE UNIDAD"
    '    dtExcel.Columns(5).ColumnName = "CÓDIGO BULTO"
    '    dtExcel.Columns(6).ColumnName = "TIPO BULTO"
    '    dtExcel.Columns(7).ColumnName = "CANTIDAD EN BULTO"
    '    dtExcel.Columns(8).ColumnName = "NOMBRE DEL PROVEEDOR"
    '    dtExcel.Columns(9).ColumnName = "ORDEN COMPRA"
    '    dtExcel.Columns(10).ColumnName = "NRO ITEM"
    '    dtExcel.Columns(11).ColumnName = "NRO SUB ITEM"
    '    dtExcel.Columns(12).ColumnName = "DESCRIPCIÓN ITEM"
    '    dtExcel.Columns(13).ColumnName = "UNID. MEDIDA"
    '    dtExcel.Columns(14).ColumnName = "ÍTEM DESPACHO"
    '    dtExcel.Columns(15).ColumnName = "LUGAR DE DESTINO"
    '    dtExcel.Columns(16).ColumnName = "PESO BULTO KG"

    '    '=====================QUIEBRES==========================
    '    Dim itemp As Integer = 0
    '    Dim iCambia As Boolean = True
    '    For i As Integer = 0 To dtExcel.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If dtExcel.Rows(i).Item("FECHA DESPACHO") = dtExcel.Rows(itemp).Item("FECHA DESPACHO") Then
    '                dtExcel.Rows(i).Item("FECHA DESPACHO") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    '======================================================
    '    itemp = 0
    '    iCambia = True
    '    For i As Integer = 0 To dtExcel.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If dtExcel.Rows(i).Item("GUÍA REMISIÓN CLIENTE") = dtExcel.Rows(itemp).Item("GUÍA REMISIÓN CLIENTE") Then
    '                dtExcel.Rows(i).Item("GUÍA REMISIÓN CLIENTE") = ""
    '                dtExcel.Rows(i).Item("NRO. PLACA") = ""

    '                dtExcel.Rows(i).Item("NOMBRE DEL CHOFER") = ""
    '                dtExcel.Rows(i).Item("TIPO DE UNIDAD") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    dtExcel.TableName = "DESPACHO MERCADERIA"
    '    oDs.Tables.Add(dtExcel)

    '    Dim strlTitulo As New List(Of String)
    '    strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
    '    strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

    '    If Me.txtPlaca.Text.Trim = "" Then
    '        strlTitulo.Add("Placa :\nTODOS")
    '    Else
    '        strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
    '    End If
    '    strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
    '    HelpClass.ExportExcelConTitulos(oDs, "Despacho Mercadería por Unidad", strlTitulo)
    'End Sub

    'Private Sub ExportarExcelSubItem(ByVal oDtExcel As DataTable)
    '    Dim oDt As New DataTable
    '    Dim oDs As New DataSet
    '    oDt = oDtExcel.Clone

    '    oDt.Columns(2).DataType = GetType(String)
    '    oDt.Columns(3).DataType = GetType(String)
    '    oDt.Columns("QBLTSR").DataType = GetType(String)
    '    oDt.Columns("NGRPRV").DataType = GetType(String)
    '    'Cambiamos Orden------------------
    '    For i As Integer = 0 To oDtExcel.Rows.Count - 1
    '        oDt.ImportRow(oDtExcel.Rows(i))
    '        oDt.Rows(i).Item("FSLDAL") = Split(oDtExcel.Rows(i).Item("FSLDAL"))(0)
    '    Next
    '    'Quitamos columnas a no usar------
    '    oDt.Columns.Remove("CCLNT")
    '    oDt.Columns.Remove("TCMPCL")
    '    oDt.Columns.Remove("NRGUSA")
    '    'oDt.Columns.Remove("NPLCAC")
    '    oDt.Columns.Remove("CTRSPT")
    '    oDt.Columns.Remove("CBRCNT")
    '    oDt.Columns.Remove("TABTRT")
    '    oDt.Columns.Remove("NRUCTR")
    '    oDt.Columns.Remove("NRITOC")

    '    oDt.Columns.Remove("CIDPAQ")
    '    oDt.Columns.Remove("OC")
    '    oDt.Columns.Remove("ITEM")


    '    'dtTemp3.Columns.Remove("NGRPRV")
    '    '---------------------------------
    '    oDt.Columns(0).ColumnName = "FECHA DESPACHO"
    '    oDt.Columns(1).ColumnName = "GUIA REMISIÓN"
    '    oDt.Columns(2).ColumnName = "NRO. PLACA"
    '    oDt.Columns(3).ColumnName = "TIPO TRACTO"
    '    oDt.Columns(4).ColumnName = "ACOPLADO"
    '    oDt.Columns(5).ColumnName = "TIPO ACOPLADO"
    '    oDt.Columns(6).ColumnName = "CHOFER"
    '    oDt.Columns(7).ColumnName = "BULTO"
    '    oDt.Columns(8).ColumnName = "ZONA"
    '    oDt.Columns(9).ColumnName = "CANTIDAD BULTO"
    '    oDt.Columns(10).ColumnName = "TIPO BULTO"
    '    oDt.Columns(11).ColumnName = "PROVEEDOR CLIENTE"
    '    oDt.Columns(12).ColumnName = "GUÍA DE PROVEEDOR"
    '    oDt.Columns(13).ColumnName = "ORDEN COMPRA/ITEM"
    '    oDt.Columns(14).ColumnName = "COD. ITEM"
    '    oDt.Columns(15).ColumnName = "DESCRIPCION ITEM"
    '    oDt.Columns(16).ColumnName = "CANTIDAD ITEM DESPACHADO"
    '    oDt.Columns(17).ColumnName = "UNID. MEDIDA "
    '    oDt.Columns(18).ColumnName = "PESO BULTO"
    '    oDt.Columns(19).ColumnName = "UNID. MEDIDA PESO"
    '    oDt.Columns(20).ColumnName = "IMPORTE UNID. ITEM"
    '    oDt.Columns(21).ColumnName = "IMPORTE TOTAL ITEM"
    '    oDt.Columns(22).ColumnName = "LUGAR DESTINO"

    '    oDt.Columns("SBITOC").ColumnName = "SUBITEM"
    '    oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
    '    oDt.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"""
    '    oDt.Columns("QCNRCP").ColumnName = "CANTIDAD SUBITEM"
    '    oDt.Columns("TUNDIT1").ColumnName = "UNIDAD DE MEDIDA"
    '    oDt.Columns("IVUNIT1").ColumnName = "IMPORTE UNID. SUBITEM"
    '    oDt.Columns("IMPTOL1").ColumnName = "IMPORTE TOTAL. SUBITEM"


    '    '=====================QUIEBRES==========================
    '    Dim itemp As Integer = 0
    '    Dim iCambia As Boolean = True
    '    For i As Integer = 0 To oDt.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If oDt.Rows(i).Item("FECHA DESPACHO") = oDt.Rows(itemp).Item("FECHA DESPACHO") Then
    '                oDt.Rows(i).Item("FECHA DESPACHO") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    '======================================================
    '    itemp = 0
    '    iCambia = True
    '    For i As Integer = 0 To oDt.Rows.Count - 1
    '        If iCambia = True Then
    '            itemp = i - 1
    '        End If
    '        If i > 0 Then
    '            If oDt.Rows(i).Item("GUIA REMISIÓN") = oDt.Rows(itemp).Item("GUIA REMISIÓN") Then
    '                oDt.Rows(i).Item("GUIA REMISIÓN") = ""
    '                oDt.Rows(i).Item("NRO. PLACA") = ""
    '                oDt.Rows(i).Item("TIPO TRACTO") = ""
    '                oDt.Rows(i).Item("ACOPLADO") = ""
    '                oDt.Rows(i).Item("TIPO ACOPLADO") = ""
    '                oDt.Rows(i).Item("CHOFER") = ""
    '                'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
    '                iCambia = False
    '            Else
    '                iCambia = True
    '            End If
    '        End If
    '    Next
    '    oDs.Tables.Add(oDt)

    '    Dim strlTitulo As New List(Of String)
    '    strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
    '    strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)

    '    If Me.txtPlaca.Text.Trim = "" Then
    '        strlTitulo.Add("Placa :\nTODOS")
    '    Else
    '        strlTitulo.Add("Placa :\n" & Me.txtPlaca.Text)
    '    End If
    '    strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
    '    HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    'End Sub

    


        Private Sub btnModelo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelo1.Click
            Try
                If Me.rbtItem.Checked Then
                    Dim oDtExcel As New DataTable
                    oDtExcel = EliminarRepetidoItems(objTemp.Tables(0))
                'ExportarExcel(oDtExcel)
                ExportarExcel_Modelo1(oDtExcel)
                Else
                'ExportarExcelSubItem(objTemp.Tables(0))
                ExportarExcel_Modelo1(objTemp.Tables(0))
                End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
        End Sub

        Private Sub btnModelo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelo2.Click
            Try
                If Me.rbtItem.Checked Then
                    Dim oDtExcel As New DataTable
                    oDtExcel = EliminarRepetidoItems(objTemp.Tables(0))
                'ExportarExcel1(oDtExcel)
                ExportarExcel_Modelo2(oDtExcel)
                Else
                'ExportarExcelSubItem1(objTemp.Tables(0))
                ExportarExcel_Modelo2(objTemp.Tables(0))
            End If

            Dim dtExport As New DataTable


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End Sub
    End Class


