Public Class beRutaTienda
    Inherits beBase(Of beRutaTienda)

#Region "Variables"


    Private _PNCCLNT As Decimal
    Private _PNCPLNCL As Decimal
    Private _PNCPRVCL As Decimal
    Private _PNCPLCLP As Decimal
    Private _PSTCMPPL As String
    Private _PSTDRCPL As String
    Private _PSCRUTAT As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

    Private _PSTCMPCL As String
    Private _PSV_TCMPPL As String
    Private _PSTPRVCL As String
    Private _PSV_TDRPCP As String


    Private _PNHRAINI As Decimal
    Private _PNHRAFIN As Decimal
    Private _PSGPSLAT As String
    Private _PSGPSLON As String
    Private _PNNCRRRT As Decimal

    Private _PNHRAINI_D As Date
    Private _PNHRAFIN_D As Date






    Private _PNCDPEPL As Double
    Private _PSDESCLIP As String
    Private _PSDESCLIT As String
    Private _PSTCMPCP As String
    Private _PSTABRUT As String
    Private _PNFECDES As Double
    Private _PNFECDES_D As Date

    Private _PNHRAINI_S As String
    Private _PNHRAFIN_S As String
    Private _PNNCRRRT_S As String


#End Region

#Region "Propiedades"
    Public Property PNHRAINI_S() As String
        Get
            Return (_PNHRAINI_S)
        End Get
        Set(ByVal value As String)
            _PNHRAINI_S = value
        End Set
    End Property
    Public Property PNHRAFIN_S() As String
        Get
            Return (_PNHRAFIN_S)
        End Get
        Set(ByVal value As String)
            _PNHRAFIN_S = value
        End Set
    End Property
    Public Property PNNCRRRT_S() As String
        Get
            Return (_PNNCRRRT_S)
        End Get
        Set(ByVal value As String)
            _PNNCRRRT_S = value
        End Set
    End Property



    Public Property PNFECDES() As Double
        Get
            Return (_PNFECDES)
        End Get
        Set(ByVal value As Double)
            _PNFECDES = value
        End Set
    End Property

    Public Property PNFECDES_D() As Date
        Get
            Return (_PNFECDES_D)
        End Get
        Set(ByVal value As Date)
            _PNFECDES_D = value
        End Set
    End Property




    Public Property PNCDPEPL() As Double
        Get
            Return (_PNCDPEPL)
        End Get
        Set(ByVal value As Double)
            _PNCDPEPL = value
        End Set
    End Property
    Public Property PSDESCLIP() As String
        Get
            Return (_PSDESCLIP)
        End Get
        Set(ByVal value As String)
            _PSDESCLIP = value
        End Set
    End Property
    Public Property PSDESCLIT() As String
        Get
            Return (_PSDESCLIT)
        End Get
        Set(ByVal value As String)
            _PSDESCLIT = value
        End Set
    End Property
    Public Property PSTCMPCP() As String
        Get
            Return (_PSTCMPCP)
        End Get
        Set(ByVal value As String)
            _PSTCMPCP = value
        End Set
    End Property
    Public Property PSTABRUT() As String
        Get
            Return (_PSTABRUT)
        End Get
        Set(ByVal value As String)
            _PSTABRUT = value
        End Set
    End Property







    Public Property PNHRAINI_D() As Date
        Get
            Return (_PNHRAINI_D)
        End Get
        Set(ByVal value As Date)
            _PNHRAINI_D = value
        End Set
    End Property


    Public Property PNHRAFIN_D() As Date
        Get
            Return (_PNHRAFIN_D)
        End Get
        Set(ByVal value As Date)
            _PNHRAFIN_D = value
        End Set
    End Property



    Public Property PNHRAINI() As Decimal
        Get
            Return (_PNHRAINI)
        End Get
        Set(ByVal value As Decimal)
            _PNHRAINI = value
        End Set
    End Property
    Public Property PNHRAFIN() As Decimal
        Get
            Return (_PNHRAFIN)
        End Get
        Set(ByVal value As Decimal)
            _PNHRAFIN = value
        End Set
    End Property
    Public Property PSGPSLAT() As String
        Get
            Return (_PSGPSLAT)
        End Get
        Set(ByVal value As String)
            _PSGPSLAT = value
        End Set
    End Property
    Public Property PSGPSLON() As String
        Get
            Return (_PSGPSLON)
        End Get
        Set(ByVal value As String)
            _PSGPSLON = value
        End Set
    End Property





    Public Property PSTCMPCL() As String
        Get
            Return (_PSTCMPCL)
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property PSV_TCMPPL() As String
        Get
            Return (_PSV_TCMPPL)
        End Get
        Set(ByVal value As String)
            _PSV_TCMPPL = value
        End Set
    End Property

    Public Property PSTPRVCL() As String
        Get
            Return (_PSTPRVCL)
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property

    Public Property PSV_TDRPCP() As String
        Get
            Return (_PSV_TDRPCP)
        End Get
        Set(ByVal value As String)
            _PSV_TDRPCP = value
        End Set
    End Property

    Public Property PSTCMPPL() As String
        Get
            Return (_PSTCMPPL)
        End Get
        Set(ByVal value As String)
            _PSTCMPPL = value
        End Set
    End Property

    Public Property PSTDRCPL() As String
        Get
            Return (_PSTDRCPL)
        End Get
        Set(ByVal value As String)
            _PSTDRCPL = value
        End Set
    End Property

    Public Property PSCRUTAT() As String
        Get
            Return (_PSCRUTAT)
        End Get
        Set(ByVal value As String)
            _PSCRUTAT = value
        End Set
    End Property

    Public Property PNNCRRRT() As Decimal
        Get
            Return (_PNNCRRRT)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRRT = value
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

    Public Property PNCPLNCL() As Decimal
        Get
            Return (_PNCPLNCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNCL = value
        End Set
    End Property

    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Public Property PNCPLCLP() As Decimal
        Get
            Return (_PNCPLCLP)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
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

    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
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


End Class