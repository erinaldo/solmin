Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
Imports CrystalDecisions.CrystalReports.Engine
' slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador


Module mReporteDespachoSDSW
    '-------------------------------------------
    '-- Imprimir Reporte de Guia de Despacho --
    '-------------------------------------------
    Public Sub mpObtenerGuiaDespachoSDSW(ByVal objFiltro As clsFiltros_ReporteGuiaDespacho)
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With frmVisorRPT

        End With
        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill

            .crpVisorRPT.ReportSource = objReportes.frptObtenerGuiaDespacho(objFiltro, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With

    End Sub

    Public Function mfrptObtenerGuiaDespachoSDSW(ByVal objFiltro As clsFiltros_ReporteGuiaDespacho) As ReportDocument
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReportes.frptObtenerGuiaDespacho(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function

    '-------------------------------------------
    '-- Imprimir Ticket Despacho --
    '-------------------------------------------
    Public Sub mpObtenerTicketDespachoSDSW(ByVal objparametroticket As clsFiltros_ReporteTicket)
        Dim objReporte As clsReportesTicket = New clsReportesTicket(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""

        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .crpVisorRPT.ReportSource = objReporte.frptTicket_Recepcion_Despacho(objparametroticket, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With


    End Sub

    Public Function mfrptObtenerTicketSDSW(ByVal objparametroticket As clsFiltros_ReporteTicket) As ReportDocument
        Dim objReporte As clsReportesTicket = New clsReportesTicket(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReporte.frptTicket_Recepcion_Despacho(objparametroticket, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function

    '------------------------------------------
    '-- Imprimir Reporte de Guia de Remisión --
    '------------------------------------------
    Public Sub mpGenerarGuiaRemisionSDSW(ByVal objParam As clsPARAM_GuiaRemisionDS)
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill

            .crpVisorRPT.ReportSource = objReportes.frptGenerarGuiaRemision(objParam, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
      
    End Sub

    Public Function mfrptReporteGuiaRemisionSDSW(ByVal objFiltro As clsFiltros_ReporteGuiaRemision) As ReportDocument
        Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReportes.frptObtenerGuiaRemision(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function
End Module
