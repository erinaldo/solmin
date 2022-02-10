Namespace slnSOLMIN_SAT.Despacho


    Public Class clsPrimaryKey_Despacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNRGUSA As String = ""
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

        Public Property pstrNroGuiaSalida_NRGUSA() As String
            Get
                Return strNRGUSA
            End Get
            Set(ByVal value As String)
                strNRGUSA = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsDespachoFiltros
#Region " Atributos "
        Private intCCLNT As Int32 = 0
        Private strNROCTL As String = ""
        Private strNRGUSA As String = ""
#End Region
#Region " Propiedades "
        Public Property pCodigoCliente_CCLNT() As Int32
            Get
                pCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int32)
                intCCLNT = value
            End Set
        End Property

        Public Property pNroControl_NROCTL() As String
            Get
                pNroControl_NROCTL = strNROCTL
            End Get
            Set(ByVal value As String)
                strNROCTL = value
            End Set
        End Property

        Public Property pNroGuiaSalida_NRGUSA() As String
            Get
                pNroGuiaSalida_NRGUSA = strNRGUSA
            End Get
            Set(ByVal value As String)
                strNRGUSA = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltro_GSalidaConGRemision
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNRGUSA As String = ""
        Private dteFSLDAL_INI As Date
        Private dteFSLDAL_FIN As Date
        Private strNGUIRM As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroGuiaSalida_NRGUSA() As String
            Get
                Return strNRGUSA
            End Get
            Set(ByVal value As String)
                strNRGUSA = value
            End Set
        End Property

        Public Property pdteFechaGuiaSalidaInicial_FSLDAL() As Date
            Get
                Return dteFSLDAL_INI
            End Get
            Set(ByVal value As Date)
                dteFSLDAL_INI = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaGuiaSalidaInicial_FFec_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_INI.Year > 1 Then strResultado = dteFSLDAL_INI.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaGuiaSalidaInicial_FNum_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_INI.Year > 1 Then strResultado = dteFSLDAL_INI.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaGuiaSalidaInicial_FSLDAL() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLDAL_INI.Year > 1 Then Integer.TryParse(dteFSLDAL_INI.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaGuiaSalidaFinal_FSLDAL() As Date
            Get
                Return dteFSLDAL_FIN
            End Get
            Set(ByVal value As Date)
                dteFSLDAL_FIN = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaGuiaSalidaFinal_FFec_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_FIN.Year > 1 Then strResultado = dteFSLDAL_FIN.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaGuiaSalidaFinal_FNum_FSLDAL() As String
            Get
                Dim strResultado As String = ""
                If dteFSLDAL_FIN.Year > 1 Then strResultado = dteFSLDAL_FIN.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaGuiaSalidaFinal_FSLDAL() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFSLDAL_FIN.Year > 1 Then Integer.TryParse(dteFSLDAL_FIN.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pstrNroGuiaRemisionInicial_NGUIRM() As String
            Get
                Return strNGUIRM
            End Get
            Set(ByVal value As String)
                strNGUIRM = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltroGuiaSalida
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNRGUSA As String = ""
        Private strSTGUSA As String = ""
        Private strFSLDAL_INICIAL As String = ""
        Private strFSLDAL_FINAL As String = ""
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private dblCPLNDV As Double = 0
#End Region
#Region " Propiedades "

        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                pstrCodigoCompania_CCMPN = strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                pstrCodigoDivision_CDVSN = strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Public Property pdblCodigoPlanta_CPLNDV() As Double
            Get
                pdblCodigoPlanta_CPLNDV = dblCPLNDV
            End Get
            Set(ByVal value As Double)
                dblCPLNDV = value
            End Set
        End Property


        Public Property pstrEstadoGuiaSalida_STGUSA() As String
            Get
                pstrEstadoGuiaSalida_STGUSA = strSTGUSA
            End Get
            Set(ByVal value As String)
                strSTGUSA = value
            End Set
        End Property
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroGuiaSalida_NRGUSA() As String
            Get
                Return strNRGUSA
            End Get
            Set(ByVal value As String)
                strNRGUSA = value
            End Set
        End Property

        Public Property pstrFechaGuiaSalidaInicial_FSLDAL() As String
            Get
                pstrFechaGuiaSalidaInicial_FSLDAL = strFSLDAL_INICIAL
            End Get
            Set(ByVal value As String)
                strFSLDAL_INICIAL = value
            End Set
        End Property

        Public WriteOnly Property pdteFechaGuiaSalidaInicial_FSLDAL() As Date
            Set(ByVal value As Date)
                strFSLDAL_INICIAL = value.ToString("yyyyMMdd")
            End Set
        End Property

        Public Property pstrFechaGuiaSalidaFinal_FSLDAL() As String
            Get
                pstrFechaGuiaSalidaFinal_FSLDAL = strFSLDAL_FINAL
            End Get
            Set(ByVal value As String)
                strFSLDAL_FINAL = value
            End Set
        End Property

        Public WriteOnly Property pdteFechaGuiaSalidaFinal_FSLDAL() As Date
            Set(ByVal value As Date)
                strFSLDAL_FINAL = value.ToString("yyyyMMdd")
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltroGuiaRemision
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNGUIRM As String = ""
        Private strFGUIRM_INICIAL As String = ""
        Private strFGUIRM_FINAL As String = ""
#End Region
#Region " Propiedades "
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                pintCodigoCliente_CCLNT = intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pstrNroGuiaRemisionInicial_NGUIRM() As String
            Get
                Return strNGUIRM
            End Get
            Set(ByVal value As String)
                strNGUIRM = value
            End Set
        End Property

        Public Property pstrFechaGuiaRemisionInicial_FGUIRM() As String
            Get
                pstrFechaGuiaRemisionInicial_FGUIRM = strFGUIRM_INICIAL
            End Get
            Set(ByVal value As String)
                strFGUIRM_INICIAL = value
            End Set
        End Property

        Public WriteOnly Property pdteFechaGuiaRemisionInicial_FGUIRM() As Date
            Set(ByVal value As Date)
                strFGUIRM_INICIAL = value.ToString("yyyyMMdd")
            End Set
        End Property

        Public Property pstrFechaGuiaRemisionFinal_FGUIRM() As String
            Get
                pstrFechaGuiaRemisionFinal_FGUIRM = strFGUIRM_FINAL
            End Get
            Set(ByVal value As String)
                strFGUIRM_FINAL = value
            End Set
        End Property

        Public WriteOnly Property pdteFechaGuiaRemisionFinal_FGUIRM() As Date
            Set(ByVal value As Date)
                strFGUIRM_FINAL = value.ToString("yyyyMMdd")
            End Set
        End Property
#End Region
    End Class

End Namespace