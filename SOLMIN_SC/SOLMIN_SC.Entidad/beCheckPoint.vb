Public Class beCheckPoint
    Inherits Base_BE(Of beCheckPoint)
    Private _PNCCLNT As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNNORSCI As Decimal = 0
    Private _PNNRPEMB As Decimal = 0
    Private _PNNESTDO As Decimal = 0
    Private _PSNOMVAR As String = ""
    Private _PSCEMB As String = ""
    Private _PSTDESES As String = ""
    Private _PSFESEST As String = ""
    Private _PSFRETES As String = ""
    Private _PNFESEST As Decimal = 0
    Private _PNFRETES As Decimal = 0
    Private _PNNRVARB As Decimal = 0
    Private _PNNSEPRE As Decimal = 0
    Private _PSTOBS As String = ""
    Private _PSTABRST As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSNTRMNL As String = ""
    Private _PSSESTRG As String = ""
    Private _PSTCOLUM As String = ""
    Private _PSCUSCRT As String = ""
    Private _PSUSUARIO As String = ""
    Private _PSTOBEST As String = ""
    Private _PNMESTDO As Decimal = 0

    Private _PNHRAEST As Decimal = 0
    Private _PNHRAREA As Decimal = 0

    Private _PSHRAEST As String = ""
    Private _PSHRAREA As String = ""

    Private _PSSTRNSM As String = ""
    Private _PSRFCLNT As String = ""

    'Private _PNFRETES2 As Decimal = 0

    Public Property PSHRAREA() As String
        Get
            Return (_PSHRAREA)
        End Get
        Set(ByVal value As String)
            _PSHRAREA = value
        End Set
    End Property

    Public Property PSHRAEST() As String
        Get
            Return (_PSHRAEST)
        End Get
        Set(ByVal value As String)
            _PSHRAEST = value
        End Set
    End Property

    Public Property PNHRAREA() As Decimal
        Get
            Return (_PNHRAREA)
        End Get
        Set(ByVal value As Decimal)
            _PNHRAREA = value
        End Set
    End Property

    Public Property PNHRAEST() As Decimal
        Get
            Return (_PNHRAEST)
        End Get
        Set(ByVal value As Decimal)
            _PNHRAEST = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return (_PSCDVSN)
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Public Property PNFESEST() As Decimal
        Get
            Return (_PNFESEST)
        End Get
        Set(ByVal value As Decimal)
            _PNFESEST = value
        End Set
    End Property

    Public Property PNFRETES() As Decimal
        Get
            Return (_PNFRETES)
        End Get
        Set(ByVal value As Decimal)
            _PNFRETES = value
        End Set
    End Property



    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Public Property PNNRPEMB() As Decimal
        Get
            Return (_PNNRPEMB)
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
        End Set
    End Property




    Public Property PSCEMB() As String
        Get
            Return (_PSCEMB)
        End Get
        Set(ByVal value As String)
            _PSCEMB = value
        End Set
    End Property

    Public Property PSNOMVAR() As String
        Get
            Return (_PSNOMVAR)
        End Get
        Set(ByVal value As String)
            _PSNOMVAR = value
        End Set
    End Property
    Public Property PSTDESES() As String
        Get
            Return (_PSTDESES)
        End Get
        Set(ByVal value As String)
            _PSTDESES = value
        End Set
    End Property
    Public Property PSFESEST() As String
        Get
            Return (_PSFESEST)
        End Get
        Set(ByVal value As String)
            _PSFESEST = value
        End Set
    End Property
    Public Property PSFRETES() As String
        Get
            Return (_PSFRETES)
        End Get
        Set(ByVal value As String)
            _PSFRETES = value
        End Set
    End Property

    Public Property PNNESTDO() As Decimal
        Get
            Return (_PNNESTDO)
        End Get
        Set(ByVal value As Decimal)
            _PNNESTDO = value
        End Set
    End Property

    Public Property PNNRVARB() As Decimal
        Get
            Return (_PNNRVARB)
        End Get
        Set(ByVal value As Decimal)
            _PNNRVARB = value
        End Set
    End Property
    Public Property PNNSEPRE() As Decimal
        Get
            Return (_PNNSEPRE)
        End Get
        Set(ByVal value As Decimal)
            _PNNSEPRE = value
        End Set
    End Property

    Public Property PSTOBS() As String
        Get
            Return (_PSTOBS)
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property

    Public Property PSTABRST() As String
        Get
            Return (_PSTABRST)
        End Get
        Set(ByVal value As String)
            _PSTABRST = value
        End Set
    End Property

    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_PSNTRMNL)
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property

    Public Property PSTCOLUM() As String
        Get
            Return (_PSTCOLUM)
        End Get
        Set(ByVal value As String)
            _PSTCOLUM = value
        End Set

    End Property
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PSFECREAL() As String
        Get
            Return NumeroAFecha(_PNFRETES)
        End Get
        Set(ByVal value As String)
            _PNFRETES = CtypeDate(value)
        End Set
    End Property

    Public Property PSFECESTIMADA() As String
        Get
            Return NumeroAFecha(_PNFESEST)
        End Get
        Set(ByVal value As String)
            _PNFESEST = CtypeDate(value)
        End Set
    End Property
    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property
    Public Property PSTOBEST() As String
        Get
            Return _PSTOBEST
        End Get
        Set(ByVal value As String)
            _PSTOBEST = value
        End Set
    End Property
    Public Property PNMESTDO() As Decimal
        Get
            Return _PNMESTDO
        End Get
        Set(ByVal value As Decimal)
            _PNMESTDO = value
        End Set
    End Property





    Public Property PSSTRNSM() As String
        Get
            Return _PSSTRNSM
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property

    Public Property PSRFCLNT() As String
        Get
            Return _PSRFCLNT
        End Get
        Set(ByVal value As String)
            _PSRFCLNT = value
        End Set
    End Property










#Region "BITACORAS"

    Private _PSNORCML As String
    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property
    Private _PNNRITOC As Decimal
    Public Property PNNRITOC() As Decimal
        Get
            Return _PNNRITOC
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property
    Private _PNTFCOBS As Decimal
    Public Property PNTFCOBS() As Decimal
        Get
            Return _PNTFCOBS
        End Get
        Set(ByVal value As Decimal)
            _PNTFCOBS = value
        End Set
    End Property

    Private _PNNRITEM As Decimal
    Public Property PNNRITEM() As Decimal
        Get
            Return _PNNRITEM
        End Get
        Set(ByVal value As Decimal)
            _PNNRITEM = value
        End Set
    End Property




    'Public Property PNFRETES2() As Decimal
    '    Get
    '        Return (_PNFRETES2)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNFRETES2 = value
    '    End Set
    'End Property

#End Region
End Class
