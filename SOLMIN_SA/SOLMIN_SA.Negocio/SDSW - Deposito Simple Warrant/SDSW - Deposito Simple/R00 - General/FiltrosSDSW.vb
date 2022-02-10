Namespace slnSOLMIN_SDSW_FILTRO
    Public Class clsFiltro_SDSWListarMercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strCMRCLR As String = ""
        Private strFPUWEB As String = ""
        Private dteFVNCMR As Date
        Private dteFINVRN As Date
        Private intNAUTR As Int64 = 0

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
        Public Property pintAutorizacion_NAUTR() As Int64
            Get
                Return intNAUTR
            End Get
            Set(ByVal value As Int64)
                intNAUTR = value

            End Set
        End Property

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrCodigoGrupo_CGRCLR() As String
            Get
                Return strCGRCLR
            End Get
            Set(ByVal value As String)
                strCGRCLR = value
            End Set
        End Property

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property

        Public Property pstrStatusPublicacionWEB_FPUWEB() As String
            Get
                Return strFPUWEB
            End Get
            Set(ByVal value As String)
                If value = "S" Then strFPUWEB = value
                If Not value = "S" Then strFPUWEB = "N"
            End Set
        End Property

        Public Property pblnStatusPublicacionWEB_FPUWEB() As Boolean
            Get
                Dim blnResultado As Boolean = False
                If strFPUWEB <> "N" Then blnResultado = True
                Return blnResultado
            End Get
            Set(ByVal value As Boolean)
                If value Then strFPUWEB = "S"
                If Not value Then strFPUWEB = "N"
            End Set
        End Property

        Public Property pdteFechaVencimiento_FVNCMR() As Date
            Get
                Return dteFVNCMR
            End Get
            Set(ByVal value As Date)
                dteFVNCMR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaVencimiento_FVNCMR() As String
            Get
                Dim strResultado As String = ""
                If dteFVNCMR.Year > 1 Then strResultado = dteFVNCMR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaVencimiento_FVNCMR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFVNCMR.Year > 1 Then Integer.TryParse(dteFVNCMR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaInventario_FINVRN() As Date
            Get
                Return dteFINVRN
            End Get
            Set(ByVal value As Date)
                dteFINVRN = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaInventario_FINVRN() As String
            Get
                Dim strResultado As String = ""
                If dteFINVRN.Year > 1 Then strResultado = dteFINVRN.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaInventario_FINVRN() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFINVRN.Year > 1 Then Integer.TryParse(dteFINVRN.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
#End Region
    End Class
    'Agregado para Almaceneras
    Public Class clsFiltro_SDSWConsultaSolicitud
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strCMRCLR As String = ""
        Private dteFSLCSR As Date
        Private dteFSLCSRI As Date
        Private dteFSLCSRF As Date
        Private strCTPALM As String = ""
        Private strCALMC As String = ""
        Private strCZNALM As String = ""
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

        Public Property pstrCodigoFamilia_CFMCLR() As String
            Get
                Return strCFMCLR
            End Get
            Set(ByVal value As String)
                strCFMCLR = value
            End Set
        End Property

        Public Property pstrCodigoGrupo_CGRCLR() As String
            Get
                Return strCGRCLR
            End Get
            Set(ByVal value As String)
                strCGRCLR = value
            End Set
        End Property

        Public Property pstrCodigoTipo_CTPALM() As String
            Get
                Return strCTPALM
            End Get
            Set(ByVal value As String)
                strCTPALM = value
            End Set
        End Property
        Public Property pstrCodigoAlmacen_CALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property
        Public Property pstrCodigoZona_CZNALM() As String
            Get
                Return strCZNALM
            End Get
            Set(ByVal value As String)
                strCZNALM = value
            End Set
        End Property

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property
        Public Property pdteFechaSolicitud_FSLCSR() As Date
            Get
                Return dteFSLCSR
            End Get
            Set(ByVal value As Date)
                dteFSLCSR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaSolicitud_FSLCSR() As String
            Get
                Dim strResultado As String = ""
                If dteFSLCSR.Year > 1 Then strResultado = dteFSLCSR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaSolicitud_FSLCSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLCSR.Year > 1 Then Integer.TryParse(dteFSLCSR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pdteFechaISolicitud_FSLCSR() As Date
            Get
                Return dteFSLCSRI
            End Get
            Set(ByVal value As Date)
                dteFSLCSRI = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaISolicitud_FSLCSR() As String
            Get
                Dim strResultado As String = ""
                If dteFSLCSRI.Year > 1 Then strResultado = dteFSLCSRI.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaISolicitud_FSLCSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLCSRI.Year > 1 Then Integer.TryParse(dteFSLCSRI.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pdteFechaFSolicitud_FSLCSR() As Date
            Get
                Return dteFSLCSRF
            End Get
            Set(ByVal value As Date)
                dteFSLCSRF = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaFSolicitud_FSLCSR() As String
            Get
                Dim strResultado As String = ""
                If dteFSLCSRF.Year > 1 Then strResultado = dteFSLCSRF.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaFSolicitud_FSLCSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLCSRF.Year > 1 Then Integer.TryParse(dteFSLCSRF.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
#End Region
    End Class
    'Agregado para Almaceneras
    Public Class clsFiltro_SDSWListaPreFactura
#Region "Atributos"
        Private intCCLNT As Int64 = 0
        Private dteFATNSRI As Date
        Private dteFATNSRF As Date
        'Private intCSVRNV As Int64 = 0
        Private strCSVRNV As String
#End Region
#Region "Propiedades"
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property
        'Public Property pintCodigoServicio_CSVRNV() As Int64
        '    Get
        '        Return intCSVRNV
        '    End Get
        '    Set(ByVal value As Int64)
        '        intCSVRNV = value
        '    End Set
        'End Property

        Public Property strCodigoServicio_CSVRNV() As String
            Get
                Return strCSVRNV
            End Get
            Set(ByVal value As String)
                strCSVRNV = value
            End Set
        End Property


        Public Property pdteFechaISolicitud_FATNSR() As Date
            Get
                Return dteFATNSRI
            End Get
            Set(ByVal value As Date)
                dteFATNSRI = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaISolicitud_FATNSR() As String
            Get
                Dim strResultado As String = ""
                If dteFATNSRI.Year > 1 Then strResultado = dteFATNSRI.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaISolicitud_FATNSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFATNSRI.Year > 1 Then Integer.TryParse(dteFATNSRI.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaFSolicitud_FATNSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFATNSRF.Year > 1 Then Integer.TryParse(dteFATNSRF.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pdteFechaFSolicitud_FATNSR() As Date
            Get
                Return dteFATNSRF
            End Get
            Set(ByVal value As Date)
                dteFATNSRF = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaFSolicitud_FATNSR() As String
            Get
                Dim strResultado As String = ""
                If dteFATNSRF.Year > 1 Then strResultado = dteFATNSRF.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
#End Region
    End Class
    'Agregado para Almaceneras
    Public Class clsFiltros_SDSWAnularTicket
#Region " Atributos "
        'Private strSESDCM As String = ""
        'Private strSESTRGA As String = ""
        Private intNORDSR As Integer
        Private intNRTOCK As Integer
        Private intNSLCSR As Integer
#End Region
#Region " Propiedades "

        Public Property intNumOrden_NORDSR() As Integer
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Integer)
                intNORDSR = value
            End Set
        End Property

        Public Property intNumTicket_NRTOCK() As Integer
            Get
                Return intNRTOCK
            End Get
            Set(ByVal value As Integer)
                intNRTOCK = value
            End Set
        End Property
        Public Property intNumSolicitud_NSLCSR() As Integer
            Get
                Return intNSLCSR
            End Get
            Set(ByVal value As Integer)
                intNSLCSR = value
            End Set
        End Property


#End Region
    End Class
    'Agregado para Almaceneras
    Public Class clsFiltros_SDSWListaTicket
#Region " Atributos "
        'Private strSESDCM As String = ""
        'Private strSESTRGA As String = ""
        Private intNORDSR As Integer
        Private intNSLCSR As Integer
#End Region
#Region " Propiedades "

        Public Property intNumOrden_NORDSR() As Integer
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Integer)
                intNORDSR = value
            End Set
        End Property
        Public Property intNumSolicitud_NSLCSR() As Integer
            Get
                Return intNSLCSR
            End Get
            Set(ByVal value As Integer)
                intNSLCSR = value
            End Set
        End Property

#End Region
    End Class
    'Agregado para Almaceneras
    Public Class clsFiltros_SDSWConsultaOrden
#Region " Atributos "
        Private dteFSLCSR As Date
        Private intCCLNT As Int64

#End Region
#Region " Propiedades "
        Public Property pdteFechaSolicitud_FSLCSR() As Date
            Get
                Return dteFSLCSR
            End Get
            Set(ByVal value As Date)
                dteFSLCSR = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaSolicitud_FSLCSR() As String
            Get
                Dim strResultado As String = ""
                If dteFSLCSR.Year > 1 Then strResultado = dteFSLCSR.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property
        Public ReadOnly Property pintFechaSolicitud_FSLCSR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLCSR.Year > 1 Then Integer.TryParse(dteFSLCSR.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
        Public Property pintCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property
#End Region
    End Class
    'Agregado para Almacenes
    Public Class clsFiltros_SDSWConsultaVehiculos
#Region "Atributos"
        Private dteFECINI As Date
        Private dteFECFIN As Date
        Private strNCHSVH As String = ""
        Private strESTADO As String = ""
        Private strCCLNT As String = ""
        Private strCTPOAL As String = ""
        Private strCALMCM As String = ""

#End Region
#Region "Propiedades"
        Public Property pstrCCLNT() As String
            Get
                Return strCCLNT
            End Get
            Set(ByVal value As String)
                strCCLNT = value
            End Set
        End Property
        Public Property pstrCTPOAL() As String
            Get
                Return strCTPOAL
            End Get
            Set(ByVal value As String)
                strCTPOAL = value
            End Set
        End Property
        Public Property pstrCALMCM() As String
            Get
                Return strCALMCM
            End Get
            Set(ByVal value As String)
                strCALMCM = value
            End Set
        End Property
        Public Property pstrNCHSVH() As String
            Get
                Return strNCHSVH
            End Get
            Set(ByVal value As String)
                strNCHSVH = value
            End Set
        End Property
        Public Property pstrEstado() As String
            Get
                Return strESTADO
            End Get
            Set(ByVal value As String)
                strESTADO = value
            End Set
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
#End Region
    End Class

End Namespace