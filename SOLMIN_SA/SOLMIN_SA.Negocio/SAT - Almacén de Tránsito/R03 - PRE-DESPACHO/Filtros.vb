Namespace slnSOLMIN_SAT.PreDespacho
    Public Class clsPrimaryKey_PreDespacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private intNROCTL As Int32 = 0

        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private dblCPLNDV As Double = 0
#End Region
#Region " Propiedades "
        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property
        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property
        Public Property pdblCodigoPlanta_CPLNDV() As Double
            Get
                Return dblCPLNDV
            End Get
            Set(ByVal value As Double)
                dblCPLNDV = value
            End Set
        End Property
        Public Property pintCodigoCliente_CCLNT() As Int64
            Get
                Return intCCLNT
            End Get
            Set(ByVal value As Int64)
                intCCLNT = value
            End Set
        End Property

        Public Property pintNroControl_NROCTL() As Int32
            Get
                Return intNROCTL
            End Get
            Set(ByVal value As Int32)
                intNROCTL = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsPrimaryKey_BultoPreDespacho
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strCREFFW As String = ""

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

        Public Property pstrCodigoRecepcion_CREFFW() As String
            Get
                Return strCREFFW
            End Get
            Set(ByVal value As String)
                strCREFFW = value
            End Set
        End Property
#End Region
    End Class

    Public Class clsFiltrosParaPreDespachos
#Region " Atributos "
        Private intCCLNT As Int64 = 0
        Private strNROCTL As String = ""
        Private strCCMPN As String = ""
        Private strCDVSN As String = ""
        Private dblCPLNDV As Double = 0
        Private _pstrTipoTransporte_STPDES As String = ""

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

        Public Property pstrNroControl_NROCTL() As String
            Get
                Return strNROCTL
            End Get
            Set(ByVal value As String)
                strNROCTL = value
            End Set
        End Property

        Public Property pstrCodigoCompania_CCMPN() As String
            Get
                Return strCCMPN
            End Get
            Set(ByVal value As String)
                strCCMPN = value
            End Set
        End Property
        Public Property pstrCodigoDivision_CDVSN() As String
            Get
                Return strCDVSN
            End Get
            Set(ByVal value As String)
                strCDVSN = value
            End Set
        End Property
        Public Property pdblCodigoPlanta_CPLNDV() As Double
            Get
                Return dblCPLNDV
            End Get
            Set(ByVal value As Double)
                dblCPLNDV = value
            End Set
        End Property

        Public Property pstrTipoTransporte_STPDES() As String
            Get
                Return _pstrTipoTransporte_STPDES
            End Get
            Set(ByVal value As String)
                _pstrTipoTransporte_STPDES = value
            End Set
        End Property

#End Region
    End Class
End Namespace