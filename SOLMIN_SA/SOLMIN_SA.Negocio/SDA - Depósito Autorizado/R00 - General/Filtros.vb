Namespace slnSOLMIN_SDA
    Public Class clsFiltro_ListarOS
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCTPDP As String = ""
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

        Public Property pstrTipoDeposito_CTPDP() As String
            Get
                Return strCTPDP
            End Get
            Set(ByVal value As String)
                strCTPDP = value
            End Set
        End Property

        Public Property pstrNroOrdenServicio_NORDSR() As String
            Get
                Return strNORDSR
            End Get
            Set(ByVal value As String)
                strNORDSR = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltro_ListarDetalleOS
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private intCSRVC As Integer = 0
        Private intNORDSR As Int64 = 0
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

        Public Property pintNroOrdenServicio_NORDSR() As Int64
            Get
                Return intNORDSR
            End Get
            Set(ByVal value As Int64)
                intNORDSR = value
            End Set
        End Property

        Public Property pstrCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property

        Public Property pstrDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property

        Public Property pintServicio_CSRVC() As Integer
            Get
                Return intCSRVC
            End Get
            Set(ByVal value As Integer)
                intCSRVC = value
            End Set
        End Property
#End Region
    End Class
End Namespace