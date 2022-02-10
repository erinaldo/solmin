Imports RANSA.NEGO
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.Mercaderia
Imports Ransa.Rpt.Mercaderia
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS.Reportes.Generador
Imports CrystalDecisions.CrystalReports.Engine

Module mReporteRecepcionSDS
    '-------------------------------------------
    '-- Imprimir Reporte de Guia de Recepcion --
    '-------------------------------------------
    'Public Sub mpObtenerGuiaRecepcion(ByVal objFiltro As clsFiltros_ReporteGuiaRecepcion)
    '    Dim objReportes As clsReportesRecepcion = New clsReportesRecepcion(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    With frmVisorRPT
    '        .WindowState = FormWindowState.Maximized
    '        .Dock = DockStyle.Fill
    '        .pReportDocument = objReportes.frptObtenerGuiaRecepcion(objFiltro, strMensajeError)
    '        If strMensajeError <> "" Then
    '            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            .ShowDialog()
    '        End If
    '    End With
    'End Sub

    'Public Function mfrptObtenerGuiaRecepcion(ByVal objFiltro As clsFiltros_ReporteGuiaRecepcion) As ReportDocument
    '    Dim objReportes As clsReportesRecepcion = New clsReportesRecepcion(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    Dim rptTemp As ReportDocument = Nothing
    '    rptTemp = objReportes.frptObtenerGuiaRecepcion(objFiltro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Return rptTemp
    'End Function

    '----------------------
    '-- Imprimir Reporte --
    '----------------------
    'comentar
    'Public Function mfrptGeneradorReporte(ByVal Filtro As TD_Qry_StockProductosF01) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptStockProductosR01(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporte(ByVal Filtro As TD_Qry_StockProductosPorUbicacionF01) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    If Filtro.pSTQRY_StatusValorizado = 0 Then
    '        'objTemp = objReporteSDS.frptStockProductosPorUbicacionR01(Filtro, strMensajeError)
    '    Else
    '        'objTemp = objReporteSDS.frptStockProductosPorUbicacionR02(Filtro, strMensajeError)
    '    End If
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporte(ByVal Filtro As TD_FiltroRepMovProductos) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte = Nothing
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    Select Case Filtro.pSTQRY_StatusValorizado
    '        Case 0
    '            'objTemp = objReporteSDS.frptMovimientoProductosR01(Filtro, strMensajeError)
    '        Case 1
    '            'objTemp = objReporteSDS.frptMovimientoProductosR02(Filtro, strMensajeError)
    '        Case 2
    '            'objTemp = objReporteSDS.frptMovimientoProductosR03(Filtro, strMensajeError)


    '    End Select
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporte(ByVal Filtro As TD_Rpt_RepMovProductos_R03) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptMovimientoProductosR03(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporteCentroCosto(ByVal Filtro As TD_Rpt_RepMovProductos_R03) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptListar_MovMercaderias_x_CentroCosto(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporteLugarEntrega(ByVal Filtro As TD_Rpt_RepMovProductos_R03) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptListar_MovMercaderias_x_LugarEntrega(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporteInventarioPosicion(ByVal Filtro As TD_Rpt_Mercaderia_R01) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptListar_Inventario_x_Posicion(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporteIndicadorMensual(ByVal Filtro As TD_Rpt_Indicador) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptListar_Resumen_Indicador_Mensual(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporteIndicadorAnual(ByVal Filtro As TD_Rpt_Indicador) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    'objTemp = objReporteSDS.frptListar_Resumen_Indicador_Anual(Filtro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    ''comentar
    'Public Function mfrptGeneradorReporte(ByVal Filtro As TD_FiltroRepMovProductosPorUbicacion) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte = Nothing
    '    Dim objReporteSDS As ReporteSDS = New ReporteSDS(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    Select Case Filtro.pSTQRY_StatusValorizado
    '        Case 0
    '            'objTemp = objReporteSDS.frptMovimientoProductosPorUbicacionR01(Filtro, strMensajeError)
    '        Case 1
    '            objTemp = objReporteSDS.frptMovimientoProductosPorUbicacionR02(Filtro, strMensajeError)
    '    End Select

    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
End Module
