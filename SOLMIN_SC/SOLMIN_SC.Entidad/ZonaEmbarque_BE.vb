Imports System.ComponentModel
Imports System.Reflection
Public Class ZonaEmbarque_BE
    Private _PNCCLNT As Decimal = 0
    Private _PSCZNAEM As String = ""
    Private _PSTZNAEM As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PSNTRMCR As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSNTRMNL As String = ""
    Private _PSSESTRG As String = ""
    'Private _PNUPDATE_IDENT As Decimal = 0
    Private _PNCPAIS As Decimal = 0
    Private _PSTCMPPS As String = ""
    Private _PSTCMPCL As String = ""
    Private _PNCPAIS_INICIAL As Decimal = 0

    Private _PSCPRTOE As String = ""
    Private _PSTCMPR1 As String = ""
    Public Property PSCPRTOE() As String
        Get
            Return _PSCPRTOE
        End Get
        Set(ByVal value As String)
            _PSCPRTOE = value
        End Set
    End Property
    Public Property PSTCMPR1() As String
        Get
            Return _PSTCMPR1
        End Get
        Set(ByVal value As String)
            _PSTCMPR1 = value
        End Set
    End Property

    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
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
    
    <Description("Codigo de Zona Embarque")> _
    Public Property PSCZNAEM() As String
        Get
            Return (_PSCZNAEM)
        End Get
        Set(ByVal value As String)
            _PSCZNAEM = value
        End Set
    End Property
    <Description("Descripcion de Zona Embarque")> _
    Public Property PSTZNAEM() As String
        Get
            Return (_PSTZNAEM)
        End Get
        Set(ByVal value As String)
            _PSTZNAEM = value
        End Set
    End Property
    <Description("Codigo Pais")> _
    Public Property PNCPAIS() As Decimal
        Get
            Return (_PNCPAIS)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
        End Set
    End Property

    Public Property PNCPAIS_INICIAL() As Decimal
        Get
            Return (_PNCPAIS_INICIAL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS_INICIAL = value
        End Set
    End Property

    <Description("Descripcion Pais")> _
    Public Property PSTCMPPS() As String
        Get
            Return (_PSTCMPPS)
        End Get
        Set(ByVal value As String)
            _PSTCMPPS = value
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
    'Public Property PNUPDATE_IDENT() As Decimal
    '    Get
    '        Return (_PNUPDATE_IDENT)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNUPDATE_IDENT = value
    '    End Set
    'End Property

   


    
End Class
