Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace slnSOLMIN.DAO
    Public Class daoCamion
        Inherits BasicClass
#Region " Tipos de Datos "

#End Region
#Region " Atributos "
        Private intCTRSP As Int32 = 0
        Private strNPLCCM As String = ""
        Private decPTRCM As Decimal = 0.0
        Private intNANOCM As Int32 = 0
        Private strTMRCCM As String = ""
        Private strNMTRCM As String = ""
        Private strSESTCM As String = ""
        Private strNROPLA As String = ""
        Private strNBRVC1 As String = ""
        Private strNPLCAC As String = ""
        Private intNTRNLL As Int32 = 0
        Private decFASGTR As Date
        Private intHASGTR As Int32 = 0
        Private strNTRMNL As String = ""
        Private strSTACTU As String = "S"

        '-- Seguridad
        Private strUSER As String = ""
#End Region
#Region " Propiedades "
        Public Property pintEmpresaTransporte_CTRSP() As Int32
            Get
                Return intCTRSP
            End Get
            Set(ByVal value As Int32)
                intCTRSP = value
            End Set
        End Property

        Public Property pstrNroPlacaCamion_NPLCCM()
            Get
                Return strNPLCCM
            End Get
            Set(ByVal value)
                strNPLCCM = value
                If strNPLCCM.Length > 3 Then strNROPLA = strNPLCCM.Substring(2)
            End Set
        End Property

        Public Property pdecCantidadPesoTara_PTRCM() As Decimal
            Get
                Return decPTRCM
            End Get
            Set(ByVal value As Decimal)
                decPTRCM = value
            End Set
        End Property

        Public Property pintNroAnioCamion_NANOCM() As Int32
            Get
                Return intNANOCM
            End Get
            Set(ByVal value As Int32)
                intNANOCM = value
            End Set
        End Property

        Public Property pstrDescripcionMarcaCamion_TMRCCM() As String
            Get
                Return strTMRCCM
            End Get
            Set(ByVal value As String)
                strTMRCCM = value
            End Set
        End Property

        Public Property pstrNroMotorCamion_NMTRCM() As String
            Get
                Return strNMTRCM
            End Get
            Set(ByVal value As String)
                strNMTRCM = value
            End Set
        End Property

        Public Property pstrStatusEstadoCamion_SESTCM() As String
            Get
                Return strSESTCM
            End Get
            Set(ByVal value As String)
                strSESTCM = value
            End Set
        End Property

        Public ReadOnly Property pstrParteNumericaPlaca_NROPLA() As String
            Get
                Return strNROPLA
            End Get
        End Property

        Public Property pstrNroBreveteChofer_NBRVC1() As String
            Get
                Return strNBRVC1
            End Get
            Set(ByVal value As String)
                strNBRVC1 = value
            End Set
        End Property

        Public Property pstrNroPlacaAcoplado_NPLCAC() As String
            Get
                Return strNPLCAC
            End Get
            Set(ByVal value As String)
                strNPLCAC = value
            End Set
        End Property

        Public Property pintNroTurnoLlegada_NTRNLL() As Int32
            Get
                Return intNTRNLL
            End Get
            Set(ByVal value As Int32)
                intNTRNLL = value
            End Set
        End Property

        Public Property pdteFechaAsignacionTurno_FASGTR() As Date
            Get
                Return decFASGTR
            End Get
            Set(ByVal value As Date)
                decFASGTR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaAsignacionTurno_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If decFASGTR.Year > 1 Then strResultado = decFASGTR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaAsignacionTurno_FASGTR() As Integer
            Get
                Dim intResultado As Integer = 0
                If decFASGTR.Year > 1 Then Integer.TryParse(decFASGTR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pintHoraAsignacionTurno_HASGTR() As Int32
            Get
                Return intHASGTR
            End Get
            Set(ByVal value As Int32)
                intHASGTR = value
            End Set
        End Property

        Public Property pstrNroTerminal_NTRMNL() As String
            Get
                Return strNTRMNL
            End Get
            Set(ByVal value As String)
                strNTRMNL = value
            End Set
        End Property

        Public ReadOnly Property pstrStatusActualizarSiExiste_STACTU() As String
            Get
                Return strSTACTU
            End Get
        End Property

        Public Property pblnStatusActualizarSiExiste_STACTU() As Boolean
            Get
                Dim blnStatus As Boolean = False
                If strSTACTU = "S" Then blnStatus = True
                Return blnStatus
            End Get
            Set(ByVal value As Boolean)
                Select Case value
                    Case True : strSTACTU = "S"
                    Case False : strSTACTU = "N"
                End Select
            End Set
        End Property

        '-- Seguridad
        Public Property pstrUsuario() As String
            Get
                Return strUSER
            End Get
            Set(ByVal value As String)
                strUSER = value
            End Set
        End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Public Shared Function Grabar(ByVal objSqlManager As SqlManager, ByVal oCamion As daoCamion, ByRef strMensajeError As String) As Boolean
            Dim objParametros As Parameter = New Parameter
            Dim blnResultado As Boolean = True
            ' Ingresamos los parametros del Procedure
            'Proc
            With oCamion
                objParametros.Add("IN_CTRSP", .pintEmpresaTransporte_CTRSP)
                objParametros.Add("IN_NPLCCM", .pstrNroPlacaCamion_NPLCCM)
                objParametros.Add("IN_PTRCM", .pdecCantidadPesoTara_PTRCM)
                objParametros.Add("IN_NANOCM", .pintNroAnioCamion_NANOCM)
                objParametros.Add("IN_TMRCCM", .pstrDescripcionMarcaCamion_TMRCCM)
                objParametros.Add("IN_NMTRCM", .pstrNroMotorCamion_NMTRCM)
                objParametros.Add("IN_SESTCM", .pstrStatusEstadoCamion_SESTCM)
                objParametros.Add("IN_NROPLA", .pstrParteNumericaPlaca_NROPLA)
                objParametros.Add("IN_NBRVC1", .pstrNroBreveteChofer_NBRVC1)
                objParametros.Add("IN_NPLCAC", .pstrNroPlacaAcoplado_NPLCAC)
                objParametros.Add("IN_NTRNLL", .pintNroTurnoLlegada_NTRNLL)
                objParametros.Add("IN_FASGTR", .pintFechaAsignacionTurno_FASGTR)
                objParametros.Add("IN_HASGTR", .pintHoraAsignacionTurno_HASGTR)
                objParametros.Add("IN_NTRMNL", .pstrNroTerminal_NTRMNL)
                objParametros.Add("IN_STACTU", .pstrStatusActualizarSiExiste_STACTU)
                '-- Seguridad
                objParametros.Add("IN_USUARI", .pstrUsuario)
            End With
            Try
                strMensajeError = ""
                objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_CAMION_RZIK04_INS", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << Grabar >> de la clase << daoCamion >> " & vbNewLine & _
                                  "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_CAMION_RZIK04_INS >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
#End Region
    End Class
End Namespace