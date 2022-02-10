Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine

Namespace slnSOLMIN_SDS.PreFacturaVehiculoW
    Public Class clsFiltros_PreFacturaVehiculo
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private strEmpresa As String = ""
        Private intNGUIRN As Int64 = 0
        Private strFECHAInicio As String = ""
        Private strFechaFin As String = ""
        Private dteFECINI As Date
        Private dteFECFIN As Date
#End Region
#Region " Propiedades "

        Public Property pdteFechaFin() As Date
            Get
                Return dteFECFIN
            End Get
            Set(ByVal value As Date)
                dteFECFIN = value
            End Set
        End Property
        Public ReadOnly Property pstrFechaFin() As String
            Get
                Dim strResultado As String = ""
                If dteFECFIN.Year > 1 Then strResultado = dteFECFIN.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaFin() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFECFIN.Year > 1 Then Integer.TryParse(dteFECFIN.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
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

        Public Property pstrRazonSocialCliente_TCMPCL() As String
            Get
                Return strTCMPCL
            End Get
            Set(ByVal value As String)
                strTCMPCL = value
            End Set
        End Property

        Public Property pstrRazonSocialEmpresa() As String
            Get
                Return strEmpresa
            End Get
            Set(ByVal value As String)
                strEmpresa = value
            End Set
        End Property

        Public Property pintNroGuiaRansa_NGUIRN() As Int64
            Get
                Return intNGUIRN
            End Get
            Set(ByVal value As Int64)
                intNGUIRN = value
            End Set
        End Property
#End Region
    End Class
End Namespace

Namespace slnSOLMIN_SDS.PreFactVehiculoW.Reportes.Generador
    Public Class clsPreFacturaVehiculo
        Inherits clsBasicClassSDSW
#Region " Atributos "
        Private strUsuarioSistema As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frptObtenerPreFactVehiculo(ByVal objFiltro As slnSOLMIN_SDS.PreFacturaVehiculoW.clsFiltros_PreFacturaVehiculo, ByRef strMensajeError As String) As ReportDocument
            Dim rdocPreFactVehiculo As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_PREFACTREPORVEHI01", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pintFechaInicio, objFiltro.pintFechaFin)
            dtResultado.TableName = "dtPreFacturaVehiculo"
            If strMensajeError = "" Then
                rdocPreFactVehiculo = New rptReportePreFactVeh
                rdocPreFactVehiculo.SetDataSource(dtResultado)
                rdocPreFactVehiculo.Refresh()
                rdocPreFactVehiculo.SetParameterValue("pUsuario", strUsuarioSistema)

            End If
            Return rdocPreFactVehiculo
        End Function
#End Region
    End Class
End Namespace
