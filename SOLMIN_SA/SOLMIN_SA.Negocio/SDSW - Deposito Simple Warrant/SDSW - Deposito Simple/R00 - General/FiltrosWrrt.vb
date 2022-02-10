Namespace slnSOLMIN_R02
    Public Class FiltrosWrrt
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCMRCLR As String = ""
        Private dteFVNCMR As Date
        Private dteFINVRN As Date
        Private strSESTRG As String = ""
        Private strNORDSR As String = ""

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

        Public Property pstrCodigoMercaderia_CMRCLR() As String
            Get
                Return strCMRCLR
            End Get
            Set(ByVal value As String)
                strCMRCLR = value
            End Set
        End Property
        Public Property pstrNORDSR() As String
            Get
                Return strNORDSR
            End Get
            Set(ByVal value As String)
                strNORDSR = value
            End Set
        End Property

        Public Property pstrSESTRG() As String
            Get
                Return strSESTRG

            End Get
            Set(ByVal value As String)
                strSESTRG = value
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
