Imports Db2Manager.RansaData.iSeries.DataObjects
Imports CrystalDecisions.CrystalReports.Engine

Namespace slnSOLMIN_SDS.RecepcionSDSW.Reportes
    Public Class clsFiltros_SDSWReporteGuiaRecepcion
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strTCMPCL As String = ""
        Private strEmpresa As String = ""
        Private intNGUIRN As Int64 = 0
        Private intNORDSR As Integer = 0
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

        Public Property pintNroOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property
#End Region
    End Class
End Namespace

Namespace slnSOLMIN_SDS.RecepcionSDSW.Reportes.Generador
    Public Class clsSDSWReportesRecepcion
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

        Public Function frptObtenerGuiaRecepcionSDSW(ByVal objFiltro As clsFiltros_SDSWReporteGuiaRecepcion, ByRef strMensajeError As String) As ReportDocument
            Dim rdocGuiaRemision As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            Dim dtCaracteristica As DataTable = Nothing
            Dim DesCaracteristica As String = ""
            Dim I As Int32 = 0
            Dim J As Int32 = 0
            Dim NumdeOrden As Int64 = 0
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_RECE_GRCRNS_01", objFiltro.pintNroGuiaRansa_NGUIRN)
            dtResultado.TableName = "dtInformacionGuiaRecepcionW"
            dtResultado.Columns.Add("TOBSRL")
            For I = 0 To dtResultado.Rows.Count - 1
                If Val(dtResultado.Rows(I).Item("NORDSR")) <> NumdeOrden Then
                    NumdeOrden = Val(dtResultado.Rows(I).Item("NORDSR"))
                    DesCaracteristica = ""
                End If

                dtCaracteristica = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_RECE_GRCORD_01", dtResultado.Rows(I).Item("NORDSR"))
                For J = 0 To dtCaracteristica.Rows.Count - 1
                    DesCaracteristica = DesCaracteristica + dtCaracteristica.Rows(J).Item(0)
                Next
                dtResultado.Rows(I).Item("TOBSRL") = DesCaracteristica

            Next
            If strMensajeError = "" Then
                rdocGuiaRemision = New rptGuiaRecepcionAlma
                rdocGuiaRemision.SetDataSource(dtResultado)
                rdocGuiaRemision.Refresh()
                rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.pintCodigoCliente_CCLNT)
                rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", objFiltro.pstrRazonSocialCliente_TCMPCL)
                rdocGuiaRemision.SetParameterValue("pUsuario", strUsuarioSistema)
                rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.pintNroGuiaRansa_NGUIRN)
                rdocGuiaRemision.SetParameterValue("pEmpresa", objFiltro.pstrRazonSocialEmpresa)
            End If
            Return rdocGuiaRemision
        End Function


#End Region
    End Class
End Namespace