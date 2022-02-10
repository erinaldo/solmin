Namespace Operaciones

    Public Class CostoMantenimiento

#Region "Atributo"
        'Consumo de Mantenimiento - Vehiculo
        Private _NCOMNT As Double = 0
        Private _FECREG As Double = 0 'Mes
        Private _TCNTCS As String = "" 'Centro de Costo
        Private _TTRBES As String = "" 'Detalle de Trabajo
        Private _SESTCT As String = "" 'Contrato de Mantenimiento
        Private _TNBPRV As String = "" 'Proveedor
        Private _NPLCUN As String = "" 'Unidad
        Private _SINDRC As String = "" 'Propietario
        Private _TMRCTR As String = "" 'Marca
        Private _TOPRC As String = "" 'Operacion
        Private _ITPCMT As Double = 0 'Tipo Cambio pendiente donde estará ubicado en Excel
        Private _IMTOTD As Double = 0  'Monto Dolares
        Private _IMTOTS As Double = 0  'Monto Soles
        Private _TFAMIL As String = "" 'Familia
        Private _CCMPN As String = ""
        Private _CUSCRT As String = ""
        Private _NTRMCR As String = ""
        Private _TOTALS As Double = 0

        'Consumo de Mantenimiento - Operacion
        Private _NLQMNT As Double = 0
        Private _FLQCMM As Double = 0
        Private _NOPRCN As Double = 0
        Private _NKMRCR As Double = 0
        Private _PMRCMC As Double = 0
        Private _IGSTOP As Double = 0
        Private _SESTRG As String = ""
        Private _CULUSA As String = ""
        Private _NTRMNL As String = ""
        Private _MES As String = ""
        Private _ANIO As String = ""
#End Region

#Region "Properties"

        Public Property NCOMNT() As Double
            Get
                Return _NCOMNT
            End Get
            Set(ByVal Value As Double)
                _NCOMNT = Value
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

        Public Property TCNTCS() As String
            Get
                Return _TCNTCS
            End Get
            Set(ByVal Value As String)
                _TCNTCS = Value
            End Set
        End Property

        Public Property TTRBES() As String
            Get
                Return _TTRBES
            End Get
            Set(ByVal Value As String)
                _TTRBES = Value
            End Set
        End Property

        Public Property SESTCT() As String
            Get
                Return _SESTCT
            End Get
            Set(ByVal Value As String)
                _SESTCT = Value
            End Set
        End Property

        Public Property TNBPRV() As String
            Get
                Return _TNBPRV
            End Get
            Set(ByVal Value As String)
                _TNBPRV = Value
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
        Public Property SINDRC() As String
            Get
                Return _SINDRC
            End Get
            Set(ByVal Value As String)
                _SINDRC = Value
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

        Public Property TOPRC() As String
            Get
                Return _TOPRC
            End Get
            Set(ByVal Value As String)
                _TOPRC = Value
            End Set
        End Property

        Public Property ITPCMT() As Double
            Get
                Return _ITPCMT
            End Get
            Set(ByVal Value As Double)
                _ITPCMT = value
            End Set
        End Property

        Public Property IMTOTD() As Double
            Get
                Return _IMTOTD
            End Get
            Set(ByVal Value As Double)
                _IMTOTD = Value
            End Set
        End Property
        Public Property IMTOTS() As Double
            Get
                Return _IMTOTS
            End Get
            Set(ByVal Value As Double)
                _IMTOTS = Value
            End Set
        End Property

        Public Property TFAMIL() As String
            Get
                Return _TFAMIL
            End Get
            Set(ByVal Value As String)
                _TFAMIL = Value
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

        Public Property TOTALS() As Double
            Get
                Return _TOTALS
            End Get
            Set(ByVal Value As Double)
                _TOTALS = Value
            End Set
        End Property

        Public Property NLQMNT() As Double
            Get
                Return _NLQMNT
            End Get
            Set(ByVal Value As Double)
                _NLQMNT = Value
            End Set
        End Property

        Public Property FLQCMM() As Double
            Get
                Return _FLQCMM
            End Get
            Set(ByVal value As Double)
                _FLQCMM = value
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
        Public Property IGSTOP() As Double
            Get
                Return _IGSTOP
            End Get
            Set(ByVal Value As Double)
                _IGSTOP = Value
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

        Public Property CULUSA() As String
            Get
                Return _CULUSA
            End Get
            Set(ByVal Value As String)
                _CULUSA = Value
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