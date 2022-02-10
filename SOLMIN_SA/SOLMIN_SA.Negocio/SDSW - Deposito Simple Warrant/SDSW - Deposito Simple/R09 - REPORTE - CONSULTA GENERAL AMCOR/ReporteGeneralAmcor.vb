Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine
Namespace slnSOLMIN_SDS.ReportesGeneralAmcor
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
Namespace slnSOLMIN_SDS.ReporteGeneralAmcor.Reportes.Generador
    Public Class ReporteGeneralAmcor
        Inherits clsBasicClassSDSW
        Private strUsuarioSistema As String = ""
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frptReporteIngresosGeneralAmcor(ByVal objFiltro As slnSOLMIN_SDS.ReportesGeneralAmcor.FiltrosIngresosAmcor, ByRef strMensajeError As String) As ReportDocument
            Dim rdocReporteIngresosAmcor As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONSULTA_GENERAL_AMCOR01")
            dtResultado.TableName = "dtConsultaGeneralAmcor"
            If strMensajeError = "" Then
                rdocReporteIngresosAmcor = New rpReporteIngresosTotalAmcor
                rdocReporteIngresosAmcor.SetDataSource(dtResultado)
                rdocReporteIngresosAmcor.Refresh()
                rdocReporteIngresosAmcor.SetParameterValue("pUsuario", strUsuarioSistema)
                ' rdocReporteIngresosAmcor.SetParameterValue("pEstado", "I")
                'rdocReporteIngresosAmcor.SetParameterValue("pFechaIngreso", objFiltro.pintFechaInicio)
            End If
            Return rdocReporteIngresosAmcor
        End Function
        Public Function frptReporteSalidasGeneralAmcor(ByVal objFiltro As slnSOLMIN_SDS.ReportesGeneralAmcor.FiltrosIngresosAmcor, ByRef strMensajeError As String) As ReportDocument
            Dim rdocReporteIngresosAmcor As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_CONSULTA_GENERAL_AMCOR02")
            dtResultado.TableName = "dtConsultaGeneralAmcor"
            If strMensajeError = "" Then
                rdocReporteIngresosAmcor = New rpReporteSalidaTotalAmcor
                rdocReporteIngresosAmcor.SetDataSource(dtResultado)
                rdocReporteIngresosAmcor.Refresh()
                rdocReporteIngresosAmcor.SetParameterValue("pUsuario", strUsuarioSistema)
                'rdocReporteIngresosAmcor.SetParameterValue("pEstado", "S")
                'rdocReporteIngresosAmcor.SetParameterValue("pFechaIngreso", objFiltro.pintFechaInicio)
            End If
            Return rdocReporteIngresosAmcor
        End Function
#End Region
    End Class
End Namespace
