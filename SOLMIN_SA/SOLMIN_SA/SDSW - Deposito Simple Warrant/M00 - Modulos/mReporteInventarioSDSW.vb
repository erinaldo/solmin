Imports RANSA.NEGO.SOLMIN.ReporteInventarioW
'Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes.Generador
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
Module mReporteInventarioSDSW

    '-------------------------------------------
    '-- Imprimir Reporte de Inventario --
    '-------------------------------------------

    Public Sub mpObtenerReporteInventarioSDSW(ByVal objfiltro As FiltrosReporteInventario)
        Dim objReportes As clsInventario = New clsInventario(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .crpVisorRPT.ReportSource = objReportes.frpt_Inventario(objfiltro, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
    End Sub
    Public Function frptObtenerReporteInventarioSDSW(ByVal objFiltro As FiltrosReporteInventario) As ReportDocument
        Dim objReportes As clsInventario = New clsInventario(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim rptTemp As ReportDocument = Nothing
        rptTemp = objReportes.frpt_Inventario(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return rptTemp
    End Function

End Module
