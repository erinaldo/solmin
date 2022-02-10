Imports System.Reflection
Public Class beAlmacen
    Inherits beBase(Of beAlmacen)

    Public Sub New()
        InicializeProperty(Me)
    End Sub


    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCZNALM As String
    Private _PSTCMZNA As String
    Private _PSTABZNA As String
    Private _PNQARMTS As Decimal
    Private _PSSDISAT As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSSESTRG As String
    Private _PSNTRMNL As String
    Private _PNUPDATE_IDENT As Decimal
    Private _PSTALMC As String

    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property

    Private _PNCPLNFC As Decimal
    Public Property PNCPLNFC() As Decimal
        Get
            Return _PNCPLNFC
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNFC = value
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
    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property
    Public Property PSTCMZNA() As String
        Get
            Return (_PSTCMZNA)
        End Get
        Set(ByVal value As String)
            _PSTCMZNA = value
        End Set
    End Property
    Public Property PSTABZNA() As String
        Get
            Return (_PSTABZNA)
        End Get
        Set(ByVal value As String)
            _PSTABZNA = value
        End Set
    End Property
    Public Property PNQARMTS() As Decimal
        Get
            Return (_PNQARMTS)
        End Get
        Set(ByVal value As Decimal)
            _PNQARMTS = value
        End Set
    End Property
    Public Property PSSDISAT() As String
        Get
            Return (_PSSDISAT)
        End Get
        Set(ByVal value As String)
            _PSSDISAT = value
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
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
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
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property


    Public Property PSTALMC() As String
        Get
            Return _PSTALMC
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property

    Private _PSTCMPAL As String

    Public Property PSTCMPAL() As String
        Get
            Return _PSTCMPAL
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property


    '====================cODIGO ANTIGUO
    Public PSCSECTR As String = ""
    Public PSCPSCN As String = ""
    Public PSCPSLL As String = ""
    Public PSCCLMN As String = ""
    Public PSCPRFMR As String = ""
    Public PSCAPIMR As String = ""
    Public PSCROTMR As String = ""
    Public PNNORDSR As Int64 = 0
    Public PSTNMSCT As String = ""
    Public PNNCLNT As Int64 = 0
    Public PNORDENACION As Int64 = 0

    '=================

    'Public Sub InicializeProperty(ByVal obj As beAlmacen)
    '    Dim Propiedad As PropertyInfo
    '    Dim Propiedades() As PropertyInfo = obj.GetType.GetProperties()
    '    For Each Propiedad In Propiedades
    '        Dim Valor As Object = Propiedad.PropertyType.ToString
    '        Select Case Valor
    '            Case "System.String"
    '                Propiedad.SetValue(obj, "", Nothing)
    '            Case "System.Int8", "System.Int16", "System.Int32", "System.Decimal"
    '                Propiedad.SetValue(obj, -1, Nothing)
    '            Case "System.DateTime"
    '                Propiedad.SetValue(obj, #12:00:00 AM#, Nothing)
    '        End Select
    '    Next
    'End Sub

    'miguel 31.01.2014

    Private _PSCODVAR As String
    Private _PSCCMPRN As String

    Public Property PSCODVAR() As String
        Get
            Return (_PSCODVAR)
        End Get
        Set(ByVal value As String)
            _PSCODVAR = value
        End Set
    End Property

    Public Property PSCCMPRN() As String
        Get
            Return (_PSCCMPRN)
        End Get
        Set(ByVal value As String)
            _PSCCMPRN = value
        End Set
    End Property


    Private _PSTDSDES As String
    Public Property PSTDSDES() As String
        Get
            Return _PSTDSDES
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
        End Set
    End Property



    Private _PSTTPOMR As String
    Public Property PSTTPOMR() As String
        Get
            Return _PSTTPOMR
        End Get
        Set(ByVal value As String)
            _PSTTPOMR = value
        End Set
    End Property


End Class