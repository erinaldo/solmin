'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef
Imports RANSA.NEGO
Imports RANSA.Utilitario
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRptMovimientoContenedor

#Region "Declaracion de variables"
    Private objTemp As TipoDato_ResultaReporte
    Private obeContenedor As New beContenedor
    Private obrContenedor As New brContenedor
    Private dtReporte As New DataTable
    Private dtReporteDetallado As New DataTable
#End Region

#Region "Procedimientos y funciones"

    Private Sub frmRptMovimientoContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        If txtCliente.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Reporte de Contenedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        pcxEspera.Visible = True
        pcxEspera.Left = (KryptonHeaderGroup2.Width / 2) - (pcxEspera.Width / 2)
        pcxEspera.Top = (KryptonHeaderGroup2.Height / 2) - (pcxEspera.Height / 2)

        tsbExportarExcel.Enabled = False
        btnGenerarReporte.Enabled = False
        crvReporte.Visible = False

        obeContenedor.PNCCLNT = txtCliente.pCodigo
        obeContenedor.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        obeContenedor.PSCDVSN = UcDivision_Cmb011.Division
        obeContenedor.PNFREFFW = HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
        obeContenedor.PNFSLFFW = HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)

        bgwGifAnimado.RunWorkerAsync()

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pGenerarReporte()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        btnGenerarReporte.Enabled = True
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
        Me.Cursor = Cursors.Default
        pcxEspera.Cursor = Cursors.Default
        tsReporte.Cursor = Cursors.Default
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        Dim dtExcel As New DataTable
        Dim objDsExcel As New DataSet

        If chkDetallado.Checked Then

            dtExcel = dtReporteDetallado.Copy
            dtExcel.Columns.Remove("FECHA_ING")

        Else
            dtExcel = dtReporte.Copy

        End If


        dtExcel.Columns("CONTENEDOR").ColumnName = "DATOS DE CONTENEDOR \n CONTENEDOR"
        dtExcel.Columns("DESCMTRCN").ColumnName = "DATOS DE CONTENEDOR \n MATERIAL"
        dtExcel.Columns("DESCCLOR").ColumnName = "DATOS DE CONTENEDOR \n COLOR"
        dtExcel.Columns("DESCTPOC1").ColumnName = "DATOS DE CONTENEDOR \n TIPO"
        dtExcel.Columns("CDMNCN").ColumnName = "DATOS DE CONTENEDOR \n DIMENSION"
        dtExcel.Columns("TPLNTA").ColumnName = "DATOS DE INGRESO \n PLANTA"
        dtExcel.Columns("CREFFW").ColumnName = "DATOS DE INGRESO \n BULTO"
        dtExcel.Columns("FREFFW").ColumnName = "DATOS DE INGRESO \n FECHA DE INGRESO"
        dtExcel.Columns("NGRPRV").ColumnName = "DATOS DE INGRESO \n GUIA PROVEEDOR"
        dtExcel.Columns("FSLFFW").ColumnName = "DATOS DE SALIDA \n FECHA DE SALIDA"
        dtExcel.Columns("NGUIRM").ColumnName = "DATOS DE SALIDA \n GUIA DE REMISION"
        dtExcel.Columns("TCMTRT").ColumnName = "DATOS DE SALIDA \n TRANSPORTISTA"
        dtExcel.Columns("GUIA_TRANS").ColumnName = "DATOS DE SALIDA \n GUIA DE TRANSPORTE"
        dtExcel.Columns("TCMLCL_OR").ColumnName = "DATOS DE SALIDA \n ORIGEN"
        dtExcel.Columns("TCMLCL_DES").ColumnName = "DATOS DE SALIDA \n DESTINO"
        dtExcel.Columns("TNMMDT").ColumnName = "DATOS DE SALIDA \n MEDIO ENVIO"
        objDsExcel.Tables.Add(dtExcel)
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Compañia :\n" & UcCompania_Cmb011.CCMPN_Descripcion)
        strlTitulo.Add("División :\n" & UcDivision_Cmb011.DivisionDescripcion)
        strlTitulo.Add("Fecha  :\n" & "Del  " & dteFechaInicial.Value.ToShortDateString & "  al  " & dteFechaFinal.Value.ToShortDateString)

        HelpClass.ExportExcelConTitulos(objDsExcel, "Reporte de Movimientos de Contenedores", strlTitulo)
    End Sub

#End Region

#Region "Eventos de Control"

    Private Sub pGenerarReporte()

        Dim DtAux As New DataTable
        Dim dsReporte As New DataSet
        Dim dsReporteResult As New DataSet
        Dim drAux As DataRow
        Dim blExisteCnt As Boolean = False

        dsReporte = obrContenedor.dtListaReporteContenedores(obeContenedor)
        dtReporte = dsReporte.Tables(0)
        dtReporteDetallado = dsReporte.Tables(1)
        DtAux = dsReporte.Tables(2)

        For Each dr As DataRow In DtAux.Rows
            blExisteCnt = False
            For Each dr2 As DataRow In dtReporte.Select("CONTENEDOR = '" & dr("CONTENEDOR") & "'")
                blExisteCnt = True
            Next
            If blExisteCnt = False Then
                drAux = dtReporte.NewRow
                drAux("CONTENEDOR") = dr("CONTENEDOR")
                drAux("DESCMTRCN") = dr("DESCMTRCN")
                drAux("DESCCLOR") = dr("DESCCLOR")
                drAux("DESCTPOC1") = dr("DESCTPOC1")
                drAux("CDMNCN") = dr("CDMNCN")
                dtReporte.Rows.Add(drAux)
            End If
        Next


        If chkDetallado.Checked Then
            dtReporteDetallado.TableName = "DataTable1"
            dsReporteResult.Tables.Add(dtReporteDetallado.Copy)
            Dim objReporteDet As New rptMovimientoDetalladoContenedor

            objReporteDet.SetDataSource(dsReporteResult)

            Dim Fechas As String = "Del " & dteFechaInicial.Value.ToShortDateString & " al " & dteFechaFinal.Value.ToShortDateString
            objReporteDet.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            objReporteDet.SetParameterValue("pCliente", txtCliente.pCodigo & " - " & txtCliente.pRazonSocial)
            objReporteDet.SetParameterValue("pFecha", Fechas)

            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = objReporteDet
        Else
            dtReporte.TableName = "DataTable1"
            dsReporteResult.Tables.Add(dtReporte.Copy)
            Dim objReporte As New rptMovimientoContenedor

            objReporte.SetDataSource(dsReporteResult)

            Dim Fechas As String = "Del " & dteFechaInicial.Value.ToShortDateString & " al " & dteFechaFinal.Value.ToShortDateString
            objReporte.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            objReporte.SetParameterValue("pCliente", txtCliente.pCodigo & " - " & txtCliente.pRazonSocial)
            objReporte.SetParameterValue("pFecha", Fechas)


            objTemp = New TipoDato_ResultaReporte
            objTemp.pReporte = objReporte
        End If

        


    End Sub
#End Region


    Private Sub chkDetallado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetallado.CheckedChanged
        If chkDetallado.Checked Then
            dteFechaInicial.Enabled = True
            dteFechaFinal.Enabled = True
        Else
            dteFechaInicial.Enabled = False
            dteFechaFinal.Enabled = False
        End If
    End Sub
End Class
