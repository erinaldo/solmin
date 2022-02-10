Public Class boCamion
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
    Private strNBRVC1 As String = ""
    Private strNPLCAC As String = ""
    Private intNTRNLL As Int32 = 0
    Private decFASGTR As Date
    Private intHASGTR As Int32 = 0
    Private strNTRMNL As String = ""
    Private strSTACTU As String = "S"
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
#End Region
End Class
