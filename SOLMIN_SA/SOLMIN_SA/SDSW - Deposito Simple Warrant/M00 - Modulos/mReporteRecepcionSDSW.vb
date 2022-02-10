Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes.Generador
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador

' Agregado para Almaceneras
Module mReporteRecepcionSDSW
    '-------------------------------------------
    '-- Imprimir Reporte de Guia de Recepcion --
    '-------------------------------------------
    Public Sub mpObtenerGuiaRecepcionSDSW(ByVal objFiltro As clsFiltros_SDSWReporteGuiaRecepcion)
        Dim objReportes As clsSDSWReportesRecepcion = New clsSDSWReportesRecepcion(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .crpVisorRPT.ReportSource = objReportes.frptObtenerGuiaRecepcionSDSW(objFiltro, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
    End Sub
    Public Function mfrptObtenerGuiaRecepcionSDSW(ByVal objFiltro As clsFiltros_SDSWReporteGuiaRecepcion) As ReportDocument
        Dim objReportes As clsSDSWReportesRecepcion = New clsSDSWReportesRecepcion(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReportes.frptObtenerGuiaRecepcionSDSW(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function
    '-------------------------------------------
    '-- Imprimir Reporte de Ticket --
    '-------------------------------------------
    Public Sub mpObtenerTicketSDSW(ByVal objparametroticket As clsFiltros_ReporteTicket)
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
    '-------------------------------------------
    '-- Imprimir Ticket Despacho --
    '-------------------------------------------
    Public Sub mpObtenerTicketRecepcionW(ByVal objparametroticket As clsFiltros_ReporteTicket)
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

    'Public Function mfrptObtenerTicketRecepcionW(ByVal objparametroticket As clsFiltros_ReporteTicket) As ReportDocument
    '    Dim objReporte As clsReportesTicket = New clsReportesTicket(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    Dim rptTemp As ReportDocument = Nothing
    '    rptTemp = objReporte.frptTicket_Recepcion_Despacho(objparametroticket, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Return rptTemp
    'End Function
End Module
