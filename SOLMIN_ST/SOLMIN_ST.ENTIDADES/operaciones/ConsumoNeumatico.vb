Namespace Operaciones

    Public Class ConsumoNeumatico
#Region "Atributo"
        'Consumo Neumatico - Vehiculo
        Private _NCONEU As Double = 0
        Private _NPLCUN As String = ""
        Private _FECREG As Double = 0
        Private _TDETRA As String = ""
        Private _TCRVTA As String = ""
        Private _NROSER As String = ""
        Private _TRFDIS As String = ""
        Private _TRFMED As String = ""
        Private _TMRCTR As String = ""
        Private _QATNAN As Double = 0
        Private _IMPUNI As Double = 0
        Private _IMPTTL As Double = 0
        Private _TOBS As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _NTRMCR As String = ""
        Private _CCMPN As String = ""
        Private _MES As String = ""
        Private _ANIO As String = ""
        'Consumo Neumatico - Operación
        Private _NLQNEM As Double = 0
        Private _FLQCNM As Double = 0
        Private _NOPRCN As Double = 0
        Private _NKMRCR As Double = 0
        Private _PMRCMC As Double = 0
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _IGSTOP As Double = 0
#End Region

#Region "Properties"
        'Consumo Neumatico - Vehiculo
        Public Property NCONEU() As Double
            Get
                Return _NCONEU
            End Get
            Set(ByVal Value As Double)
                _NCONEU = Value
            End Set
        End Property

        Public Property NPLCUN() As String
            Get
                Return _NPLCUN
            End Get
            Set(ByVal Value As String)
                _NPLCUN = Value
            End Set
        End Property

        Public Property FECREG() As Double
            Get
                Return _FECREG
            End Get
            Set(ByVal Value As Double)
                _FECREG = Value
            End Set
        End Property

        Public Property TDETRA() As String
            Get
                Return _TDETRA
            End Get
            Set(ByVal Value As String)
                _TDETRA = Value
            End Set
        End Property
        Public Property TCRVTA() As String
            Get
                Return _TCRVTA
            End Get
            Set(ByVal Value As String)
                _TCRVTA = Value
            End Set
        End Property
        Public Property NROSER() As String
            Get
                Return _NROSER
            End Get
            Set(ByVal Value As String)
                _NROSER = Value
            End Set
        End Property

        Public Property TRFDIS() As String
            Get
                Return _TRFDIS
            End Get
            Set(ByVal Value As String)
                _TRFDIS = Value
            End Set
        End Property

        Public Property TRFMED() As String
            Get
                Return _TRFMED
            End Get
            Set(ByVal Value As String)
                _TRFMED = Value
            End Set
        End Property

        Public Property TMRCTR() As String
            Get
                Return _TMRCTR
            End Get
            Set(ByVal Value As String)
                _TMRCTR = Value
            End Set
        End Property

        Public Property QATNAN() As Double
            Get
                Return _QATNAN
            End Get
            Set(ByVal Value As Double)
                _QATNAN = Value
            End Set
        End Property

        Public Property IMPUNI() As Double
            Get
                Return _IMPUNI
            End Get
            Set(ByVal Value As Double)
                _IMPUNI = Value
            End Set
        End Property

        Public Property IMPTTL() As Double
            Get
                Return _IMPTTL
            End Get
            Set(ByVal Value As Double)
                _IMPTTL = Value
            End Set
        End Property

        Public Property TOBS() As String
            Get
                Return _TOBS
            End Get
            Set(ByVal Value As String)
                _TOBS = Value
            End Set
        End Property

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal Value As String)
                _SESTRG = Value
            End Set
        End Property

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal Value As String)
                _CUSCRT = Value
            End Set
        End Property
        Public Property NTRMCR() As String
            Get
                Return _NTRMCR
            End Get
            Set(ByVal Value As String)
                _NTRMCR = Value
            End Set
        End Property

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal Value As String)
                _CCMPN = Value
            End Set
        End Property

        'Consumo Neumatico - Operación

        Public Property NLQNEM() As Double
            Get
                Return _NLQNEM
            End Get
            Set(ByVal Value As Double)
                _NLQNEM = Value
            End Set
        End Property

        Public Property FLQCNM() As Double
            Get
                Return _FLQCNM
            End Get
            Set(ByVal Value As Double)
                _FLQCNM = Value
            End Set
        End Property

        Public Property NOPRCN() As Double
            Get
                Return _NOPRCN
            End Get
            Set(ByVal Value As Double)
                _NOPRCN = Value
            End Set
        End Property

        Public Property NKMRCR() As Double
            Get
                Return _NKMRCR
            End Get
            Set(ByVal Value As Double)
                _NKMRCR = Value
            End Set
        End Property

        Public Property PMRCMC() As Double
            Get
                Return _PMRCMC
            End Get
            Set(ByVal Value As Double)
                _PMRCMC = Value
            End Set
        End Property

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal Value As Double)
                _FULTAC = Value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal Value As Double)
                _HULTAC = Value
            End Set
        End Property

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal value As String)
                _CULUSA = value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal Value As String)
                _NTRMNL = Value
            End Set
        End Property

        Public Property IGSTOP() As Double
            Get
                Return _IGSTOP
            End Get
            Set(ByVal Value As Double)
                _IGSTOP = Value
            End Set
        End Property

        Public Property MES() As String
            Get
                Return _MES
            End Get
            Set(ByVal Value As String)
                _MES = Value
            End Set
        End Property

        Public Property ANIO() As String
            Get
                Return _ANIO
            End Get
            Set(ByVal Value As String)
                _ANIO = Value
            End Set
        End Property
#End Region
    End Class

End Namespace


