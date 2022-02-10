Namespace mantenimientos
    '****************************************************************************************************
    '** Autor: Rafael Gamboa
    '** Descripción: entidades.
    '****************************************************************************************************
    Public Class RecordGeneral
        Private _CBRCNT As String = ""
        Private _NCRRLT As Double = 0
        Private _STPRCD As String = ""
        Private _FRGTRO As String = ""
        Private _HRGTRO As Double = 0
        Private _FECINI As String = ""
        Private _FECTER As String = ""
        Private _NRPPLT As Double = 0
        Private _MTVEVN As String = ""
        Private _TOBSMD As String = ""
        Private _QCNESP As Double = 0
        Private _CUNCNA As String = ""
        Private _TTPRCD As String = ""
        Private _SESTRG As String = ""
        Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
        Private _HRACRT As Double = 0
        Private _NTRMCR As String = ""
        Private _CULUSA As String = ""
        Private _FULTAC As Double = 0
        Private _HULTAC As Double = 0
        Private _NTRMNL As String = ""
        Private _ESTADOABR As String = ""
        Private _TNMCMC As String = ""
        Private _TAPPAC As String = ""
        Private _TAPMAC As String = ""
        Private _BRCNT As String = ""

        Private _CCMPN As String

        Public Property TNMCMC() As String
            Get
                Return _TNMCMC
            End Get
            Set(ByVal value As String)
                _TNMCMC = value
            End Set
        End Property
        Public Property TAPPAC() As String
            Get
                Return _TAPPAC
            End Get
            Set(ByVal value As String)
                _TAPPAC = value
            End Set
        End Property

        Public Property TAPMAC() As String
            Get
                Return _TAPMAC
            End Get
            Set(ByVal value As String)
                _TAPMAC = value
            End Set
        End Property
        Public Property BRCNT() As String
            Get
                Return _BRCNT
            End Get
            Set(ByVal value As String)
                _BRCNT = value
            End Set
        End Property

        Public Property ESTADOABR() As String
            Get
                Return _ESTADOABR
            End Get
            Set(ByVal value As String)
                _ESTADOABR = value
            End Set
        End Property



        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property


        Public Property CBRCNT() As String
            Get
                Return _CBRCNT
            End Get
            Set(ByVal value As String)
                _CBRCNT = value
            End Set
        End Property

        Public Property NCRRLT() As Double
            Get
                Return _NCRRLT
            End Get
            Set(ByVal value As Double)
                _NCRRLT = value
            End Set
        End Property

        Public Property STPRCD() As String
            Get
                Return _STPRCD
            End Get
            Set(ByVal value As String)
                _STPRCD = value
            End Set
        End Property

        Public Property FRGTRO() As String
            Get
                Return _FRGTRO
            End Get
            Set(ByVal value As String)
                _FRGTRO = value
            End Set
        End Property

        Public Property HRGTRO() As Double
            Get
                Return _HRGTRO
            End Get
            Set(ByVal value As Double)
                _HRGTRO = value
            End Set
        End Property

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal value As String)
                _FECINI = value
            End Set
        End Property

        Public Property FECTER() As String
            Get
                Return _FECTER
            End Get
            Set(ByVal value As String)
                _FECTER = value
            End Set
        End Property

        Public Property NRPPLT() As Double
            Get
                Return _NRPPLT
            End Get
            Set(ByVal value As Double)
                _NRPPLT = value
            End Set
        End Property

        Public Property MTVEVN() As String
            Get
                Return _MTVEVN
            End Get
            Set(ByVal value As String)
                _MTVEVN = value
            End Set
        End Property


        Public Property TOBSMD() As String
            Get
                Return _TOBSMD
            End Get
            Set(ByVal value As String)
                _TOBSMD = value
            End Set
        End Property

        Public Property QCNESP() As Double
            Get
                Return _QCNESP
            End Get
            Set(ByVal value As Double)
                _QCNESP = value
            End Set
        End Property

        Public Property CUNCNA() As String
            Get
                Return _CUNCNA
            End Get
            Set(ByVal value As String)
                _CUNCNA = value
            End Set
        End Property

        Public Property TTPRCD() As String
            Get
                Return _TTPRCD
            End Get
            Set(ByVal value As String)
                _TTPRCD = value
            End Set
        End Property

        Public Property SESTRG() As String
            Get
                Return _SESTRG
            End Get
            Set(ByVal value As String)
                _SESTRG = value
            End Set
        End Property

        Public Property CUSCRT() As String
            Get
                Return _CUSCRT
            End Get
            Set(ByVal value As String)
                _CUSCRT = value
            End Set
        End Property

        Public Property FCHCRT() As Double
            Get
                Return _FCHCRT
            End Get
            Set(ByVal value As Double)
                _FCHCRT = value
            End Set
        End Property

        Public Property HRACRT() As Double
            Get
                Return _HRACRT
            End Get
            Set(ByVal value As Double)
                _HRACRT = value
            End Set
        End Property

        Public Property NTRMCR() As String
            Get
                Return _NTRMCR
            End Get
            Set(ByVal value As String)
                _NTRMCR = value
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

        Public Property FULTAC() As Double
            Get
                Return _FULTAC
            End Get
            Set(ByVal value As Double)
                _FULTAC = value
            End Set
        End Property

        Public Property HULTAC() As Double
            Get
                Return _HULTAC
            End Get
            Set(ByVal value As Double)
                _HULTAC = value
            End Set
        End Property

        Public Property NTRMNL() As String
            Get
                Return _NTRMNL
            End Get
            Set(ByVal value As String)
                _NTRMNL = value
            End Set
        End Property
    End Class
End Namespace
