Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes
Imports ransa.NEGO.slnSOLMIN_SDS.PreFacturaVehiculoW
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_SDS.PreFactVehiculoW.Reportes.Generador

Module mReportePreFactVehSDSW
    Public Sub mpObtenerPreFacturaVehiculoSDSW(ByVal objFiltro As clsFiltros_PreFacturaVehiculo)
        Dim objReportes As clsPreFacturaVehiculo = New clsPreFacturaVehiculo(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        With FrmVisor
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .crpVisorRPT.ReportSource = objReportes.frptObtenerPreFactVehiculo(objFiltro, strMensajeError)
            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .ShowDialog()
            End If
        End With
    End Sub
End Module
