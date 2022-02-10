Imports System.Reflection

Public Class beZonaAlmacen
    Inherits beBase(Of beZonaAlmacen)


    Private _CTPALM As String
    Public Property PSCTPALM() As String
        Get
            Return _CTPALM
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property


    Private _CALMC As String
    Public Property PSCALMC() As String
        Get
            Return _CALMC
        End Get
        Set(ByVal value As String)
            _CALMC = value
        End Set
    End Property

    Private _CZNALM As String
    Public Property PSCZNALM() As String
        Get
            Return _CZNALM
        End Get
        Set(ByVal value As String)
            _CZNALM = value
        End Set
    End Property
    Private _TCMZNA As String
    Public Property PSTCMZNA() As String
        Get
            Return _TCMZNA
        End Get
        Set(ByVal value As String)
            _TCMZNA = value
        End Set
    End Property

    Private _TABZNA As String
    Public Property PSTABZNA() As String
        Get
            Return _TABZNA
        End Get
        Set(ByVal value As String)
            _TABZNA = value
        End Set
    End Property

    Private _QARMTS As Decimal
    Public Property PNQARMTS() As Decimal
        Get
            Return _QARMTS
        End Get
        Set(ByVal value As Decimal)
            _QARMTS = value
        End Set
    End Property


    Private _SDISAT As String
    Public Property PSSDISAT() As String
        Get
            Return _SDISAT
        End Get
        Set(ByVal value As String)
            _SDISAT = value
        End Set
    End Property

End Class
