Public Class beBitacora
    Inherits Base_BE(Of beBitacora)


    Private _PNNESTDO As Decimal
    Private _PSCCMPN As String
    Private _PSCDVSN As String

    Private _PSTDESES As String
    Private _PSTABRST As String
    Private _PSCEMB As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

#Region "BITACORAS"
    Private _PNTFCOBS As Decimal
    Public Property PNTFCOBS() As Decimal
        Get
            Return _PNTFCOBS
        End Get
        Set(ByVal value As Decimal)
            _PNTFCOBS = value
        End Set
    End Property

    Private _PSTOBS As String
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
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

#End Region



#Region "Propiedades Operaciones"
    Private _PNFESEST As Double
    Private _PSTOBEST As String = ""
    Private _PNFRETES As Decimal
    Private _PNMESTDO As Decimal = 0
    Private _PNFECFIN As Decimal = 0
    Private _PNFECINI As Decimal = 0


    Private _PNNGUIRM As Decimal
    Public Property PNNGUIRM() As Decimal
        Get
            Return _PNNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property

    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property

    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
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



    Public Property PSFECESTIMADA() As String
        Get
            Return NumeroAFecha(_PNFESEST)
        End Get
        Set(ByVal value As String)
            _PNFESEST = CtypeDate(value)
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


    Public Property PNFESEST() As Decimal
        Get
            Return _PNFESEST
        End Get
        Set(ByVal value As Decimal)
            _PNFESEST = value
        End Set
    End Property


    Public Property PNFRETES() As Decimal
        Get
            Return _PNFRETES
        End Get
        Set(ByVal value As Decimal)
            _PNFRETES = value
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


#End Region


    Private _PNCCLNT As Decimal

    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
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
    Public Property PSTDESES() As String
        Get
            Return (_PSTDESES)
        End Get
        Set(ByVal value As String)
            _PSTDESES = value
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
    Public Property PSCEMB() As String
        Get
            Return (_PSCEMB)
        End Get
        Set(ByVal value As String)
            _PSCEMB = value
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
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
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



    Private _PNBITACORA As Integer
    Public Property PNBITACORA() As Integer
        Get
            Return _PNBITACORA
        End Get
        Set(ByVal value As Integer)
            _PNBITACORA = value
        End Set
    End Property


    Public Property PSFECHACREACION() As String
        Get
            Return NumeroAFecha(_PNFCHCRT)
        End Get
        Set(ByVal value As String)
            _PNFCHCRT = CtypeDate(value)
        End Set
    End Property

    Public Property PSHORACREACION() As String
        Get
            Return HoraNum_a_Hora(_PNHRACRT)
        End Get
        Set(ByVal value As String)
            _PNHRACRT = ConvertHoraNumeric(value)
        End Set
    End Property

 
 
    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub
End Class

