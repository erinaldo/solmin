Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine
Namespace slnSOLMIN_SDS.ReportesSalidasAmcor
    Public Class FiltrosSalidasAmcor
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
Namespace slnSOLMIN_SDS.ReporteSalidasAmcor.Reportes.Generador
    Public Class ReporteSalidaAmcor
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
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_SALIDAS_AMCOR01", objFiltro.pintFechaInicio)
            dtResultado.TableName = "dtReporteSalidasAmcor"
            If strMensajeError = "" Then
                rdocReporteIngresosAmcor = New rpReporteIngresosAmcor
                rdocReporteIngresosAmcor.SetDataSource(dtResultado)
                rdocReporteIngresosAmcor.Refresh()
                rdocReporteIngresosAmcor.SetParameterValue("pUsuario", strUsuarioSistema)
                rdocReporteIngresosAmcor.SetParameterValue("pFechaSalida", objFiltro.pintFechaInicio)

            End If
            Return rdocReporteIngresosAmcor
        End Function
#End Region
    End Class
End Namespace

