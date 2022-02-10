Public Class beChofer
    Inherits beBase(Of beChofer)

#Region "General"
    Private _PSTNMBCH As String
    Private _PNNLELCH As Decimal
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSNBRVCH As String
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Public Property PSTNMBCH() As String
        Get
            Return (_PSTNMBCH)
        End Get
        Set(ByVal value As String)
            _PSTNMBCH = value
        End Set
    End Property
    Public Property PNNLELCH() As Decimal
        Get
            Return (_PNNLELCH)
        End Get
        Set(ByVal value As Decimal)
            _PNNLELCH = value
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
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
#End Region

#Region "AT"

    Private _PNCTRSPT As Decimal
    Private _PSCBRCNT As String
    Private _PSSESTUN As String
    Private _PNNRKNCH As Decimal
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PSCSGRSC As String
    Private _PSTGRPSN As String
    Private _PSTDRCC As String
    Private _PNNROTLF As Decimal
    Private _PNNRORPM As Decimal
    Private _PSCBRANT As String
    Private _PSTAPPAC As String
    Private _PSTAPMAC As String
    Private _PSTNMCMC As String
    Private _PSTNCION As String
    Private _PSTLBTRT As String
    Private _PNUPDATE_IDENT As Decimal

    Public Property PNCTRSPT() As Decimal
        Get
            Return (_PNCTRSPT)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property
    Public Property PSCBRCNT() As String
        Get
            Return (_PSCBRCNT)
        End Get
        Set(ByVal value As String)
            _PSCBRCNT = value
        End Set
    End Property
 
    Public Property PSSESTUN() As String
        Get
            Return (_PSSESTUN)
        End Get
        Set(ByVal value As String)
            _PSSESTUN = value
        End Set
    End Property
    Public Property PNNRKNCH() As Decimal
        Get
            Return (_PNNRKNCH)
        End Get
        Set(ByVal value As Decimal)
            _PNNRKNCH = value
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
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property
    Public Property PSNTRMCR() As String
        Get
            Return (_PSNTRMCR)
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
        End Set
    End Property
    Public Property PSCSGRSC() As String
        Get
            Return (_PSCSGRSC)
        End Get
        Set(ByVal value As String)
            _PSCSGRSC = value
        End Set
    End Property
    Public Property PSTGRPSN() As String
        Get
            Return (_PSTGRPSN)
        End Get
        Set(ByVal value As String)
            _PSTGRPSN = value
        End Set
    End Property
    Public Property PSTDRCC() As String
        Get
            Return (_PSTDRCC)
        End Get
        Set(ByVal value As String)
            _PSTDRCC = value
        End Set
    End Property
    Public Property PNNROTLF() As Decimal
        Get
            Return (_PNNROTLF)
        End Get
        Set(ByVal value As Decimal)
            _PNNROTLF = value
        End Set
    End Property
    Public Property PNNRORPM() As Decimal
        Get
            Return (_PNNRORPM)
        End Get
        Set(ByVal value As Decimal)
            _PNNRORPM = value
        End Set
    End Property
    Public Property PSCBRANT() As String
        Get
            Return (_PSCBRANT)
        End Get
        Set(ByVal value As String)
            _PSCBRANT = value
        End Set
    End Property
    Public Property PSTAPPAC() As String
        Get
            Return (_PSTAPPAC)
        End Get
        Set(ByVal value As String)
            _PSTAPPAC = value
        End Set
    End Property
    Public Property PSTAPMAC() As String
        Get
            Return (_PSTAPMAC)
        End Get
        Set(ByVal value As String)
            _PSTAPMAC = value
        End Set
    End Property
    Public Property PSTNMCMC() As String
        Get
            Return (_PSTNMCMC)
        End Get
        Set(ByVal value As String)
            _PSTNMCMC = value
        End Set
    End Property
    Public Property PSTNCION() As String
        Get
            Return (_PSTNCION)
        End Get
        Set(ByVal value As String)
            _PSTNCION = value
        End Set
    End Property
    Public Property PSTLBTRT() As String
        Get
            Return (_PSTLBTRT)
        End Get
        Set(ByVal value As String)
            _PSTLBTRT = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
#End Region

#Region "DS"
    Private _PSSESTRG As String
    Private _PNCTRSP As Decimal
    Private _PSSESTCH As String
    Private _PSUPID As Decimal
    Private _PSNLELCHSTR As String


    Public Property PSNLELCHSTR() As String
        Get
            Return _PSNLELCHSTR
        End Get
        Set(ByVal value As String)
            _PSNLELCHSTR = value
        End Set
    End Property


    Public Property PNCTRSP() As Decimal
        Get
            Return (_PNCTRSP)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property

    Public Property PSNBRVCH() As String
        Get
            Return (_PSNBRVCH)
        End Get
        Set(ByVal value As String)
            _PSNBRVCH = value
        End Set
    End Property
    Public Property PSSESTCH() As String
        Get
            Return _PSSESTCH
        End Get
        Set(ByVal value As String)
            _PSSESTCH = value
        End Set
    End Property
    Public Property PSUPID() As Decimal
        Get
            Return _PSUPID
        End Get
        Set(ByVal value As Decimal)
            _PSUPID = value
        End Set
    End Property
#End Region


End Class

Public Class beChoferFiltro
    Public CTRSPSTR As String = ""
    Public PAGESIZE As Int32 = 0
    Public PAGENUMBER As Int32 = 0
    Public PAGECOUNT As Int32 = 0
    Public Sub pclar()
        CTRSPSTR = ""
        PAGESIZE = 0
        PAGENUMBER = 0
        PAGECOUNT = 0
    End Sub
End Class

