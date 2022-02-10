Namespace slnSOLMIN_SDS
    Public Class clsFiltro_ListarMercaderia
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCFMCLR As String = ""
        Private strCGRCLR As String = ""
        Private strCMRCLR As String = ""
        Private strFPUWEB As String = ""
        Private dteFVNCMR As Date
        Private dteFINVRN As Date
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
End Namespace