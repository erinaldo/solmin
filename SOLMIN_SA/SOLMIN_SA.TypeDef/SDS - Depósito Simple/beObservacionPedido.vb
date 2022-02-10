Imports System.ComponentModel

Public Class beObservacionPedido

    Inherits beBase(Of beObservacionPedido)

    Private _PNCDPEPL As Decimal
    Private _PNCDREGP As Decimal
    Private _PNNCRRLT As Decimal
    Private _PSTOBSGS As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSSESTRG As String

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    <Description("PNCDPEPL")> _
    Public Property PNCDPEPL() As Decimal
        Get
            Return _PNCDPEPL
        End Get
        Set(ByVal value As Decimal)
            _PNCDPEPL = value
        End Set
    End Property
    <Description("PNCDREGP")> _
    Public Property PNCDREGP() As Decimal
        Get
            Return _PNCDREGP
        End Get
        Set(ByVal value As Decimal)
            _PNCDREGP = value
        End Set
    End Property
    <Description("PNNCRRLT")> _
    Public Property PNNCRRLT() As Decimal
        Get
            Return _PNNCRRLT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRLT = value
        End Set
    End Property
    <Description("Observación")> _
    Public Property PSTOBSGS() As String
        Get
            Return _PSTOBSGS
        End Get
        Set(ByVal value As String)
            _PSTOBSGS = value
        End Set
    End Property
    <Description("PNFULTAC")> _
    Public Property PNFULTAC() As Decimal
        Get
            Return _PNFULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    <Description("PNHULTAC")> _
    Public Property PNHULTAC() As Decimal
        Get
            Return _PNHULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    <Description("PSCULUSA")> _
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    <Description("PSSESTRG")> _
    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
End Class