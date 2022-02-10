Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine

Namespace slnSOLMIN_SDS.ReporteConsistenciaW
    Public Class clsFiltroReporteConsistencia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strFECHAInicio As String = ""
        Private dteFECINI As Date
#End Region
#Region " Propiedades "

        Public Property pdteFechaInicio() As Date
            Get
                Return dteFECINI
            End Get
            Set(ByVal value As Date)
                dteFECINI = value
            End Set
        End Property
        Public ReadOnly Property pstrFechaInicio() As String
            Get
                Dim strResultado As String = ""
                If dteFECINI.Year > 1 Then strResultado = dteFECINI.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaInicio() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFECINI.Year > 1 Then Integer.TryParse(dteFECINI.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

#End Region
    End Class
End Namespace
Namespace slnSOLMIN_SDS.ReporteConsistenciaW.Reportes.Generador
    Public Class ReporteConsistencia
        Inherits clsBasicClassSDSW
        Private strUsuarioSistema As String = ""
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frptReporteConsistencia(ByVal objFiltro As slnSOLMIN_SDS.ReporteConsistenciaW.clsFiltroReporteConsistencia, ByRef strMensajeError As String) As ReportDocument
            Dim rdocReporteConsistencia As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_REPORTECONSISTENCIA", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pintFechaInicio)
            dtResultado.TableName = "dtReporteConsistencia"
            If strMensajeError = "" Then
                rdocReporteConsistencia = New rptReporteConsistencia
                rdocReporteConsistencia.SetDataSource(dtResultado)
                rdocReporteConsistencia.Refresh()
                rdocReporteConsistencia.SetParameterValue("pUsuario", strUsuarioSistema)
            End If
            Return rdocReporteConsistencia
        End Function
#End Region
    End Class
End Namespace



