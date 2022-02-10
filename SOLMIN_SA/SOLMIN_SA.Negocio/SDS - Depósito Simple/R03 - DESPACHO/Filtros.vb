Namespace slnSOLMIN_SDS.DespachoSDS
    Public Class clsPrimaryKey_Despacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNGUIRN As String = ""
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

        Public Property pstrNroGuiaRANSA_NGUIRN() As String
            Get
                Return strNGUIRN
            End Get
            Set(ByVal value As String)
                strNGUIRN = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltros_ListarGuiasRansaDS
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNGUIRN As String = ""
        Private strCTPALM As String = ""
        Private strCALMC As String = ""
        Private dteFASGTR_INI As Date
        Private dteFASGTR_FIN As Date
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

        Public Property pstrNroGuiaRANSA_NGUIRN() As String
            Get
                Return strNGUIRN
            End Get
            Set(ByVal value As String)
                strNGUIRN = value
            End Set
        End Property

        Public Property pstrTipoAlmacen_CTPALM() As String
            Get
                Return strCTPALM
            End Get
            Set(ByVal value As String)
                strCTPALM = value
            End Set
        End Property

        Public Property pstrAlmacen_CALMC() As String
            Get
                Return strCALMC
            End Get
            Set(ByVal value As String)
                strCALMC = value
            End Set
        End Property

        Public Property pdteFechaInicial_FASGTR() As Date
            Get
                Return dteFASGTR_INI
            End Get
            Set(ByVal value As Date)
                dteFASGTR_INI = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaInicial_FFec_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If dteFASGTR_INI.Year > 1 Then strResultado = dteFASGTR_INI.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaInicial_FNum_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If dteFASGTR_INI.Year > 1 Then strResultado = dteFASGTR_INI.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaInicial_FASGTR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFASGTR_INI.Year > 1 Then Integer.TryParse(dteFASGTR_INI.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property

        Public Property pdteFechaFinal_FASGTR() As Date
            Get
                Return dteFASGTR_FIN
            End Get
            Set(ByVal value As Date)
                dteFASGTR_FIN = value
            End Set
        End Property

        Public ReadOnly Property pstrFechaFinal_FFec_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If dteFASGTR_FIN.Year > 1 Then strResultado = dteFASGTR_FIN.ToString("dd/MM/yyyy")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pstrFechaFinal_FNum_FASGTR() As String
            Get
                Dim strResultado As String = ""
                If dteFASGTR_FIN.Year > 1 Then strResultado = dteFASGTR_FIN.ToString("yyyyMMdd")
                Return strResultado
            End Get
        End Property

        Public ReadOnly Property pintFechaFinal_FASGTR() As Integer
            Get
                Dim intResultado As Integer = 0
                If dteFASGTR_FIN.Year > 1 Then Integer.TryParse(dteFASGTR_FIN.ToString("yyyyMMdd"), intResultado)
                Return intResultado
            End Get
        End Property
#End Region
    End Class

    Public Class clsFiltros_ListarGuiasRemisionDS
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNGUIRN As String = ""
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

        Public Property pstrNroGuiaRANSA_NGUIRN() As String
            Get
                Return strNGUIRN
            End Get
            Set(ByVal value As String)
                strNGUIRN = value
            End Set
        End Property
#End Region
    End Class
End Namespace