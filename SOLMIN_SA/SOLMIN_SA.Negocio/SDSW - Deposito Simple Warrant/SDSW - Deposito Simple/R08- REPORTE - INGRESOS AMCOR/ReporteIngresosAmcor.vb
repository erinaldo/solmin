Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine
Namespace slnSOLMIN_SDS.ReportesIngresosAmcor
    Public Class FiltrosIngresosAmcor
        Private strFECHAInicio As String = ""
        Private dteFECInicio As Date
        Public Property pdteFechaInicio() As Date
            Get
                Return dteFECInicio
            End Get
            Set(ByVal value As Date)
                dteFECInicio = value
            End Set
        End Property
        Public ReadOnly Property pstrFechaInicio() As String
            Get
                Dim strResultado As String = ""
                If dteFECInicio.Year > 1 Then strResultado = dteFECInicio.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaInicio() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFECInicio.Year > 1 Then Integer.TryParse(dteFECInicio.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
    End Class
End Namespace
Namespace slnSOLMIN_SDS.ReporteIngresosAmcor.Reportes.Generador
    Public Class ReporteIngresosAmcor
        Inherits clsBasicClassSDSW
        Private strUsuarioSistema As String = ""
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frptReporteIngresosAmcor(ByVal objFiltro As slnSOLMIN_SDS.ReportesIngresosAmcor.FiltrosIngresosAmcor, ByRef strMensajeError As String) As ReportDocument
            Dim rdocReporteIngresosAmcor As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_INGRESOS_AMCOR01", objFiltro.pintFechaInicio)
            dtResultado.TableName = "dtReporteIngresosAmcor"
            If strMensajeError = "" Then
                rdocReporteIngresosAmcor = New rpReporteIngresosAmcor
                rdocReporteIngresosAmcor.SetDataSource(dtResultado)
                rdocReporteIngresosAmcor.Refresh()
                rdocReporteIngresosAmcor.SetParameterValue("pUsuario", strUsuarioSistema)
                rdocReporteIngresosAmcor.SetParameterValue("pFechaIngreso", objFiltro.pintFechaInicio)
            End If
            Return rdocReporteIngresosAmcor
        End Function
        Public Function frptReporteSalidasAmcor(ByVal objFiltro As slnSOLMIN_SDS.ReportesIngresosAmcor.FiltrosIngresosAmcor, ByRef strMensajeError As String) As ReportDocument
            Dim rdocReporteSalidasAmcor As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_SALIDAS_AMCOR01", objFiltro.pintFechaInicio)
            dtResultado.TableName = "dtReporteSalidasAmcor"
            If strMensajeError = "" Then
                rdocReporteSalidasAmcor = New rpReporteSalidaAmcor
                rdocReporteSalidasAmcor.SetDataSource(dtResultado)
                rdocReporteSalidasAmcor.Refresh()
                rdocReporteSalidasAmcor.SetParameterValue("pUsuario", strUsuarioSistema)
                rdocReporteSalidasAmcor.SetParameterValue("pFechaSalida", objFiltro.pintFechaInicio)
            End If
            Return rdocReporteSalidasAmcor
        End Function
#End Region

    End Class
End Namespace
