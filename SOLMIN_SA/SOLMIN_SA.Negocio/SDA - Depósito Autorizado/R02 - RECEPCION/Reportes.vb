Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine

Namespace slnSOLMIN_SDA.RecepcionSDA.Reportes
    Public Class clsFiltros_ReporteGuiaRecepcion
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private strEmpresa As String = ""
        Private intNGUIRN As Int64 = 0
        Private strCTPDPS As String = ""
        Private strTCMDPS As String = ""
#End Region
#Region " Propiedades "
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

        Public Property pstrTipoDeposito_CTPDPS() As String
            Get
                Return strCTPDPS
            End Get
            Set(ByVal value As String)
                strCTPDPS = value
            End Set
        End Property

        Public Property pstrDetalleTipoDeposito_TCMDPS() As String
            Get
                Return strTCMDPS
            End Get
            Set(ByVal value As String)
                strTCMDPS = value
            End Set
        End Property
#End Region
    End Class
End Namespace

Namespace slnSOLMIN_SDA.RecepcionSDA.Reportes.Generador
    Public Class clsReportesRecepcion
        Inherits clsBasicClass
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

        Public Function frptObtenerGuiaRecepcion(ByVal objFiltro As clsFiltros_ReporteGuiaRecepcion, ByRef strMensajeError As String) As ReportDocument
            Dim rdocGuiaRemision As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDA_RECE_GRCRNS_01", objFiltro.pintNroGuiaRansa_NGUIRN)
            dtResultado.TableName = "dtInformacionGuiaRecepcion"
            If strMensajeError = "" Then
                rdocGuiaRemision = New rptGuiaRecepcionSDA
                rdocGuiaRemision.SetDataSource(dtResultado)
                rdocGuiaRemision.Refresh()
                rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.pintCodigoCliente_CCLNT)
                rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", objFiltro.pstrRazonSocialCliente_TCMPCL)
                rdocGuiaRemision.SetParameterValue("pUsuario", strUsuarioSistema)
                rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.pintNroGuiaRansa_NGUIRN)
                rdocGuiaRemision.SetParameterValue("pEmpresa", objFiltro.pstrRazonSocialEmpresa)
                rdocGuiaRemision.SetParameterValue("pTipoDeposito", objFiltro.pstrTipoDeposito_CTPDPS)
                rdocGuiaRemision.SetParameterValue("pDetalleTipoDeposito", objFiltro.pstrDetalleTipoDeposito_TCMDPS)
            End If
            Return rdocGuiaRemision
        End Function
#End Region
    End Class
End Namespace