Public Class beTransportista
    Inherits beBase(Of beTransportista)

#Region "Atributos Generales"

    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSNTRMNL As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _PSTDRCTR As String = ""

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
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
    Public Property PSTDRCTR() As String
        Get
            Return (_PSTDRCTR)
        End Get
        Set(ByVal value As String)
            _PSTDRCTR = value
        End Set
    End Property
#End Region

#Region "Atributos AT"

    Private _PNCTRSPT As Decimal
    Private _PSNRUCTR As String
    Private _PSTCMTRT As String
    Private _PSTABTRT As String
    Private _PSTRPRTR As String
    Private _PSNLBELR As String
    Private _PSNEMMTC As String
    Private _PNNRKNTR As Decimal
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PSTLFTRP As String
    Private _PSTRACTO As String = ""
    Private _PSACOPLADO As String = ""
    Private _PSBREVETE As String = ""


    Public Property PSTRACTO() As String
        Get
            Return (_PSTRACTO)
        End Get
        Set(ByVal value As String)
            _PSTRACTO = value
        End Set
    End Property

    Public Property PSACOPLADO() As String
        Get
            Return (_PSACOPLADO)
        End Get
        Set(ByVal value As String)
            _PSACOPLADO = value
        End Set
    End Property

    Public Property PSBREVETE() As String
        Get
            Return (_PSBREVETE)
        End Get
        Set(ByVal value As String)
            _PSBREVETE = value
        End Set
    End Property
    Public Property PNCTRSPT() As Decimal
        Get
            Return (_PNCTRSPT)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property

    Public Property PSNRUCTR() As String
        Get
            Return (_PSNRUCTR)
        End Get
        Set(ByVal value As String)
            _PSNRUCTR = value
        End Set
    End Property
    Public Property PSTCMTRT() As String
        Get
            Return (_PSTCMTRT)
        End Get
        Set(ByVal value As String)
            _PSTCMTRT = value
        End Set
    End Property
    Public Property PSTABTRT() As String
        Get
            Return (_PSTABTRT)
        End Get
        Set(ByVal value As String)
            _PSTABTRT = value
        End Set
    End Property
    Public Property PSTRPRTR() As String
        Get
            Return (_PSTRPRTR)
        End Get
        Set(ByVal value As String)
            _PSTRPRTR = value
        End Set
    End Property
    Public Property PSNLBELR() As String
        Get
            Return (_PSNLBELR)
        End Get
        Set(ByVal value As String)
            _PSNLBELR = value
        End Set
    End Property
    Public Property PSNEMMTC() As String
        Get
            Return (_PSNEMMTC)
        End Get
        Set(ByVal value As String)
            _PSNEMMTC = value
        End Set
    End Property
    Public Property PNNRKNTR() As Decimal
        Get
            Return (_PNNRKNTR)
        End Get
        Set(ByVal value As Decimal)
            _PNNRKNTR = value
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

    Public Property PSTLFTRP() As String
        Get
            Return (_PSTLFTRP)
        End Get
        Set(ByVal value As String)
            _PSTLFTRP = value
        End Set
    End Property
#End Region

#Region "Atributos DS"
    Private _PSSESTRG As String = ""
    Private _PNCTRSP As Decimal = 0
    Private _PSTCMPTR As String = ""
    Private _PSTABRTR As String = ""
    Private _PSNLBELT As String = ""
    Private _PSNRGMRT As String = ""
    Private _PSNRGINT As String = ""
    Private _PNNRUCT As Decimal = 0
    Private _PSNTLFTR As String = ""
    Private _PSNTLFT2 As String = ""
    Private _PSNFAXTR As String = ""
    Private _PSTCNTTR As String = ""
    Private _PSTCNTT2 As String = ""
    Private _PSTCRGTR As String = ""
    Private _PSTCRGT2 As String = ""
    Private _PSSESTTR As String = ""
    Private _PSTCMPCL As String = ""

    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
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
    
    Public Property PNCTRSP() As Decimal
        Get
            Return (_PNCTRSP)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property
    Public Property PSTCMPTR() As String
        Get
            Return (_PSTCMPTR)
        End Get
        Set(ByVal value As String)
            _PSTCMPTR = value
        End Set
    End Property
    Public Property PSTABRTR() As String
        Get
            Return (_PSTABRTR)
        End Get
        Set(ByVal value As String)
            _PSTABRTR = value
        End Set
    End Property
    Public Property PSNLBELT() As String
        Get
            Return (_PSNLBELT)
        End Get
        Set(ByVal value As String)
            _PSNLBELT = value
        End Set
    End Property
    Public Property PSNRGMRT() As String
        Get
            Return (_PSNRGMRT)
        End Get
        Set(ByVal value As String)
            _PSNRGMRT = value
        End Set
    End Property
    Public Property PSNRGINT() As String
        Get
            Return (_PSNRGINT)
        End Get
        Set(ByVal value As String)
            _PSNRGINT = value
        End Set
    End Property
    Public Property PNNRUCT() As Decimal
        Get
            Return (_PNNRUCT)
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCT = value
        End Set
    End Property
    Public Property PSNTLFTR() As String
        Get
            Return (_PSNTLFTR)
        End Get
        Set(ByVal value As String)
            _PSNTLFTR = value
        End Set
    End Property
    Public Property PSNTLFT2() As String
        Get
            Return (_PSNTLFT2)
        End Get
        Set(ByVal value As String)
            _PSNTLFT2 = value
        End Set
    End Property
    Public Property PSNFAXTR() As String
        Get
            Return (_PSNFAXTR)
        End Get
        Set(ByVal value As String)
            _PSNFAXTR = value
        End Set
    End Property
    Public Property PSTCNTTR() As String
        Get
            Return (_PSTCNTTR)
        End Get
        Set(ByVal value As String)
            _PSTCNTTR = value
        End Set
    End Property
    Public Property PSTCNTT2() As String
        Get
            Return (_PSTCNTT2)
        End Get
        Set(ByVal value As String)
            _PSTCNTT2 = value
        End Set
    End Property
    Public Property PSTCRGTR() As String
        Get
            Return (_PSTCRGTR)
        End Get
        Set(ByVal value As String)
            _PSTCRGTR = value
        End Set
    End Property
    Public Property PSTCRGT2() As String
        Get
            Return (_PSTCRGT2)
        End Get
        Set(ByVal value As String)
            _PSTCRGT2 = value
        End Set
    End Property
    Public Property PSSESTTR() As String
        Get
            Return (_PSSESTTR)
        End Get
        Set(ByVal value As String)
            _PSSESTTR = value
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

    'Public Sub pClear()
    '    PSSESTRG = ""
    '    PNFULTAC = 0
    '    PNHULTAC = 0
    '    PSCULUSA = ""
    '    PSNTRMNL = ""
    '    PNCTRSP = 0
    '    PNCCLNT = 0
    '    PSTABRTR = ""
    '    PSTDRCTR = ""
    '    PSNLBELT = ""
    '    PSNRGMRT = ""
    '    PSNRGINT = ""
    '    PNNRUCT = 0
    '    PSNTLFTR = ""
    '    PSNTLFT2 = ""
    '    PSNFAXTR = ""
    '    PSTCNTTR = ""
    '    PSTCNTT2 = ""
    '    PSTCRGTR = ""
    '    PSTCRGT2 = ""
    '    PSSESTTR = ""
    '    PNUPDATE_IDENT = 0
    '    PSTCMPCL = ""
    'End Sub
    Public Sub Trim()

        PSSESTRG = PSSESTRG.Trim
        PSCULUSA = PSCULUSA.Trim
        PSNTRMNL = PSNTRMNL.Trim
        PSTABRTR = PSTABRTR.Trim
        PSTDRCTR = PSTDRCTR.Trim
        PSNLBELT = PSNLBELT.Trim
        PSNRGMRT = PSNRGMRT.Trim
        PSNRGINT = PSNRGINT.Trim
        PSNTLFTR = PSNTLFTR.Trim
        PSNTLFT2 = PSNTLFT2.Trim
        PSNFAXTR = PSNFAXTR.Trim
        PSTCNTTR = PSTCNTTR.Trim
        PSTCNTT2 = PSTCNTT2.Trim
        PSTCRGTR = PSTCRGTR.Trim
        PSTCRGT2 = PSTCRGT2.Trim
        PSSESTTR = PSSESTTR.Trim
        PSTCMPCL = PSTCMPCL.Trim

    End Sub
#End Region
   

End Class

Public Class beFiltroTransportista
    Public CCLNTSTR As String = ""
    Public CTRSPSTR As String = ""
    Public NRUCTSTR As String = ""
    Public TCMPTRSTR As String = ""
    Public PAGESIZE As Int32 = 0
    Public PAGENUMBER As Int32 = 0
    Public PAGECOUNT As Int32 = 0
    Public Sub pclear()
        CCLNTSTR = ""
        CTRSPSTR = ""
        NRUCTSTR = ""
        TCMPTRSTR = ""
        PAGESIZE = 0
        PAGENUMBER = 0
        PAGECOUNT = 0
    End Sub

End Class