Imports System.Reflection
Public Class TipoDato_BE
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

    Private _PNNTPODT As Decimal
    Private _PNNCODRG As Decimal
    Private _PSTDSCRG As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCULUSA As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal
    Private _PNCCLNT As Decimal
    Private _PSNTPODT_NCODRG As String
    Public Property PNNTPODT() As Decimal
        Get
            Return (_PNNTPODT)
        End Get
        Set(ByVal value As Decimal)
            _PNNTPODT = value
        End Set
    End Property
    Public Property PNNCODRG() As Decimal
        Get
            Return (_PNNCODRG)
        End Get
        Set(ByVal value As Decimal)
            _PNNCODRG = value
        End Set
    End Property
    Public Property PSTDSCRG() As String
        Get
            Return (_PSTDSCRG)
        End Get
        Set(ByVal value As String)
            _PSTDSCRG = value
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
    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSNTPODT_NCODRG() As String
        Get
            Return (_PSNTPODT_NCODRG)
        End Get
        Set(ByVal value As String)
            _PSNTPODT_NCODRG = value
        End Set
    End Property

End Class
