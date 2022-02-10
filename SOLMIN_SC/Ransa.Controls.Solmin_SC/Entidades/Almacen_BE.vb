Imports System.Reflection
Public Class Almacen_BE
    Inherits Base_BE
    Public Sub New()
        Dim Propiedades() As PropertyInfo = Me.GetType.GetProperties()
        For Each Propiedad As PropertyInfo In Propiedades
            Dim Valor As Object = Propiedad.PropertyType.ToString
            Select Case Valor
                Case "System.String"
                    Propiedad.SetValue(Me, "", Nothing)
                Case "System.Int8", "System.Int16", "System.Int32", "System.Int64"
                    Propiedad.SetValue(Me, 0, Nothing)
                Case "System.Decimal", "System.Double"
                    Propiedad.SetValue(Me, 0D, Nothing)
                Case "System.DateTime"
                    Propiedad.SetValue(Me, #12:00:00 AM#, Nothing)
            End Select
        Next
    End Sub

    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCTPALM_CALMC As String
    Private _PSTCMPAL As String
    Private _PSTABRAL As String
    Private _PNCPLNFC As Decimal
    Private _PSCALMDC As String
    Private _PSCUBIAL As String
    Private _PNQVLMAL As Decimal
    Private _PNQLRGO1 As Decimal
    Private _PNQANCH1 As Decimal
    Private _PNQALTO1 As Decimal
    Private _PNQVLMCR As Decimal
    Private _PNQLRGO As Decimal
    Private _PNQANCH As Decimal
    Private _PNQALTO As Decimal
    Private _PNNPTOAT As Decimal
    Private _PNNPTATL As Decimal
    Private _PNQTMPMR As Decimal
    Private _PSCCMPN As String
    Private _PNCCNCST As Decimal
    Private _PSSESTAL As String
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSNTRMNL As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal

    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property

    Public Property PSCTPALM_CALMC() As String
        Get
            Return (_PSCTPALM_CALMC)
        End Get
        Set(ByVal value As String)
            _PSCTPALM_CALMC = value
        End Set
    End Property





    Public Property PSTCMPAL() As String
        Get
            Return (_PSTCMPAL)
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property
    Public Property PSTABRAL() As String
        Get
            Return (_PSTABRAL)
        End Get
        Set(ByVal value As String)
            _PSTABRAL = value
        End Set
    End Property
    Public Property PNCPLNFC() As Decimal
        Get
            Return (_PNCPLNFC)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNFC = value
        End Set
    End Property
    Public Property PSCALMDC() As String
        Get
            Return (_PSCALMDC)
        End Get
        Set(ByVal value As String)
            _PSCALMDC = value
        End Set
    End Property
    Public Property PSCUBIAL() As String
        Get
            Return (_PSCUBIAL)
        End Get
        Set(ByVal value As String)
            _PSCUBIAL = value
        End Set
    End Property
    Public Property PNQVLMAL() As Decimal
        Get
            Return (_PNQVLMAL)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLMAL = value
        End Set
    End Property
    Public Property PNQLRGO1() As Decimal
        Get
            Return (_PNQLRGO1)
        End Get
        Set(ByVal value As Decimal)
            _PNQLRGO1 = value
        End Set
    End Property
    Public Property PNQANCH1() As Decimal
        Get
            Return (_PNQANCH1)
        End Get
        Set(ByVal value As Decimal)
            _PNQANCH1 = value
        End Set
    End Property
    Public Property PNQALTO1() As Decimal
        Get
            Return (_PNQALTO1)
        End Get
        Set(ByVal value As Decimal)
            _PNQALTO1 = value
        End Set
    End Property
    Public Property PNQVLMCR() As Decimal
        Get
            Return (_PNQVLMCR)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLMCR = value
        End Set
    End Property
    Public Property PNQLRGO() As Decimal
        Get
            Return (_PNQLRGO)
        End Get
        Set(ByVal value As Decimal)
            _PNQLRGO = value
        End Set
    End Property
    Public Property PNQANCH() As Decimal
        Get
            Return (_PNQANCH)
        End Get
        Set(ByVal value As Decimal)
            _PNQANCH = value
        End Set
    End Property
    Public Property PNQALTO() As Decimal
        Get
            Return (_PNQALTO)
        End Get
        Set(ByVal value As Decimal)
            _PNQALTO = value
        End Set
    End Property
    Public Property PNNPTOAT() As Decimal
        Get
            Return (_PNNPTOAT)
        End Get
        Set(ByVal value As Decimal)
            _PNNPTOAT = value
        End Set
    End Property
    Public Property PNNPTATL() As Decimal
        Get
            Return (_PNNPTATL)
        End Get
        Set(ByVal value As Decimal)
            _PNNPTATL = value
        End Set
    End Property
    Public Property PNQTMPMR() As Decimal
        Get
            Return (_PNQTMPMR)
        End Get
        Set(ByVal value As Decimal)
            _PNQTMPMR = value
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
    Public Property PNCCNCST() As Decimal
        Get
            Return (_PNCCNCST)
        End Get
        Set(ByVal value As Decimal)
            _PNCCNCST = value
        End Set
    End Property
    Public Property PSSESTAL() As String
        Get
            Return (_PSSESTAL)
        End Get
        Set(ByVal value As String)
            _PSSESTAL = value
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
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
End Class
