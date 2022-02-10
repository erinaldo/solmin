Public Class Multimodal
#Region "Atributo"

    Private _CCMPN As String
    Private _NMOPMM As Double
    Private _FCOPMM As Double
    Private _FCOPMM_S As String
    Private _TOBRCP As String
    Private _CCLNT As Double
    Private _NRORTA As Double
    Private _CDVSN As String
    Private _CPLNDV As Double
    Private _SESTOP As String
    Private _SESTRG As String
    Private _CUSCRT As String
    Private _FCHCRT As Double
    Private _HRACRT As Double
    Private _NTRMCR As String
    Private _CULUSA As String
    Private _FULTAC As Double
    Private _HULTAC As Double
    Private _NTRMNL As String
    Private _TCMPCL As String
    Private _ITINERA As String

    Private _RUTA As String
    Private _NOPRCN As String 'OPERACION
    Private _TCMTRT As String 'TRANSPORTISTA
    Private _NOMBRE_VE As String 'VEHICULO
    Private _NPLCAC As String 'ACOPLADO
    Private _CBRCND As String 'CONDUCTOR
    Private _TNMMDT As String 'MEDIO DE TRASNPORTE
    Private _FASGTR As String 'FECHA ASIGNACION
    Private _HASGTR As String 'HORA ASIGNACION
    Private _STATUS As String 'STATUS
    Private _QSLCIT As String 'CANTIDAD VEHICULO
    Private _SESSLC As String 'TIPO OPERACIONES
    Private _NPLCUN As String

#End Region

#Region "Properties"


    Private _PNNMVJCS As Double
    Public Property PNNMVJCS() As Double
        Get
            Return _PNNMVJCS
        End Get
        Set(ByVal value As Double)
            _PNNMVJCS = value
        End Set
    End Property

    Public Property FCOPMM_S() As String
        Get
            Return (_FCOPMM_S)
        End Get
        Set(ByVal value As String)
            _FCOPMM_S = value
        End Set
    End Property

    Public Property TCMPCL() As String
        Get
            Return (_TCMPCL)
        End Get
        Set(ByVal value As String)
            _TCMPCL = value
        End Set
    End Property

    Public Property ITINERA() As String
        Get
            Return (_ITINERA)
        End Get
        Set(ByVal value As String)
            _ITINERA = value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return (_CCMPN)
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property NMOPMM() As Double
        Get
            Return (_NMOPMM)
        End Get
        Set(ByVal value As Double)
            _NMOPMM = value
        End Set
    End Property

    Public Property FCOPMM() As Double
        Get
            Return (_FCOPMM)
        End Get
        Set(ByVal value As Double)
            _FCOPMM = value
        End Set
    End Property

    Public Property TOBRCP() As String
        Get
            Return (_TOBRCP)
        End Get
        Set(ByVal value As String)
            _TOBRCP = value
        End Set
    End Property

    Public Property CCLNT() As Double
        Get
            Return (_CCLNT)
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property

    Public Property NRORTA() As Double
        Get
            Return (_NRORTA)
        End Get
        Set(ByVal value As Double)
            _NRORTA = value
        End Set
    End Property

    Public Property CDVSN() As String
        Get
            Return (_CDVSN)
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Public Property CPLNDV() As Double
        Get
            Return (_CPLNDV)
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property

    Public Property SESTOP() As String
        Get
            Return (_SESTOP)
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return (_SESTRG)
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return (_CUSCRT)
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Public Property FCHCRT() As Double
        Get
            Return (_FCHCRT)
        End Get
        Set(ByVal value As Double)
            _FCHCRT = value
        End Set
    End Property

    Public Property HRACRT() As Double
        Get
            Return (_HRACRT)
        End Get
        Set(ByVal value As Double)
            _HRACRT = value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return (_NTRMCR)
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return (_CULUSA)
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Public Property FULTAC() As Double
        Get
            Return (_FULTAC)
        End Get
        Set(ByVal value As Double)
            _FULTAC = value
        End Set
    End Property

    Public Property HULTAC() As Double
        Get
            Return (_HULTAC)
        End Get
        Set(ByVal value As Double)
            _HULTAC = value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return (_NTRMNL)
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property


    'NUEVAS AGREGADAS

    Public Property RUTA() As String
        Get
            Return (_RUTA)
        End Get
        Set(ByVal value As String)
            _RUTA = value
        End Set
    End Property
    Public Property NOPRCN() As String
        Get
            Return (_NOPRCN)
        End Get
        Set(ByVal value As String)
            _NOPRCN = value
        End Set
    End Property
    Public Property TCMTRT() As String
        Get
            Return (_TCMTRT)
        End Get
        Set(ByVal value As String)
            _TCMTRT = value
        End Set
    End Property
    Public Property NOMBRE_VE() As String
        Get
            Return (_NOMBRE_VE)
        End Get
        Set(ByVal value As String)
            _NOMBRE_VE = value
        End Set
    End Property
    Public Property NPLCAC() As String
        Get
            Return (_NPLCAC)
        End Get
        Set(ByVal value As String)
            _NPLCAC = value
        End Set
    End Property
    Public Property CBRCND() As String
        Get
            Return (_CBRCND)
        End Get
        Set(ByVal value As String)
            _CBRCND = value
        End Set
    End Property
    Public Property TNMMDT() As String
        Get
            Return (_TNMMDT)
        End Get
        Set(ByVal value As String)
            _TNMMDT = value
        End Set
    End Property

    Private _CTRSPT As Double
    Public Property CTRSPT() As Double
        Get
            Return _CTRSPT
        End Get
        Set(ByVal value As Double)
            _CTRSPT = value
        End Set
    End Property


    Private _CMEDTR As Double
    Public Property CMEDTR() As Double
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As Double)
            _CMEDTR = value
        End Set
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

    Public Property FASGTR() As String
        Get
            Return (_FASGTR)
        End Get
        Set(ByVal value As String)
            _FASGTR = value
        End Set
    End Property
    Public Property HASGTR() As String
        Get
            Return (_HASGTR)
        End Get
        Set(ByVal value As String)
            _HASGTR = value
        End Set
    End Property
    Public Property STATUS() As String
        Get
            Return (_STATUS)
        End Get
        Set(ByVal value As String)
            _STATUS = value
        End Set
    End Property
    Public Property QSLCIT() As String
        Get
            Return (_QSLCIT)
        End Get
        Set(ByVal value As String)
            _QSLCIT = value
        End Set
    End Property
    Public Property SESSLC() As String
        Get
            Return (_SESSLC)
        End Get
        Set(ByVal value As String)
            _SESSLC = value
        End Set
    End Property






#End Region
End Class
