Imports IBM.Data.DB2.iSeries
Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
    Public Class clsFiltros_ReporteTicket
#Region "Atributos"
        Private intNORDSR As Int64 = 0
        Private intNSLCSR As Int64 = 0
        Private intNROTCK As Int64 = 0
        Private pstrCom As String
#End Region
#Region "Propiedades"
        Public Property pintOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property
        Public Property pintNumSolicitudServicio_NSLCSR() As Int64
            Get
                Return intNSLCSR
            End Get
            Set(ByVal value As Int64)
                intNSLCSR = value
            End Set
        End Property
        Public Property pintNumControlTicket_NROTCK() As String
            Get
                Return intNROTCK
            End Get
            Set(ByVal value As String)
                intNROTCK = value
            End Set
        End Property
        Public Property pstrCompania() As String
            Get
                Return pstrCom
            End Get
            Set(ByVal value As String)
                pstrCom = value
            End Set
        End Property
#End Region

    End Class

    'Agregado para Almaceneras
    Public Class clsReportesTicket
        Inherits clsBasicClassSDSW

        Private strUsuarioSistema As String = ""
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frptTicket_Recepcion_Despacho(ByVal objFiltro As clsFiltros_ReporteTicket, ByRef strMensajeError As String) As ReportDocument
            Dim rdocTicket As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "TICKET_RECEPCION", objFiltro.pstrCompania, objFiltro.pintNumControlTicket_NROTCK)
            dtResultado.TableName = "dtTicketOrdenServicio"

            If strMensajeError = "" Then
                rdocTicket = New rptTicketOrdenServicio
                rdocTicket.SetDataSource(dtResultado)
                rdocTicket.Refresh()
                'rdocTicket.SetParameterValue("pNumOrden", objFiltro.pintOrdenServicio_NORDSR)
                'rdocTicket.SetParameterValue("pNumSolicitud", objFiltro.pintNumSolicitudServicio_NSLCSR)
                rdocTicket.SetParameterValue("pNumTicket", objFiltro.pintNumControlTicket_NROTCK)
            End If
            Return rdocTicket
        End Function
    End Class
End Namespace