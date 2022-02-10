Imports System.ComponentModel
Imports System.Text
Public Class ucTextBoxColumnNumero
    Inherits DataGridViewTextBoxColumn

    Private _NUMENTEROS As Int32 = 0
    <Description("Cantidad de dígitos enteros"), Category("NUMERO")> _
    Public Property NUMENTEROS() As Int32
        Get
            Return _NUMENTEROS
        End Get
        Set(ByVal value As Int32)
            _NUMENTEROS = value
        End Set
    End Property

    Private _NUMDECIMALES As Int32 = 0

    <Description("Cantidad de dígitos decimales"), Category("NUMERO")> _
    Public Property NUMDECIMALES() As Int32
        Get
            Return _NUMDECIMALES
        End Get
        Set(ByVal value As Int32)
            _NUMDECIMALES = value
        End Set
    End Property

    Public Overrides Function Clone() As Object
        Dim column As New ucTextBoxColumnNumero
        column = CType(MyBase.Clone, ucTextBoxColumnNumero)
        column.NUMENTEROS = Me._NUMENTEROS
        column.NUMDECIMALES = Me._NUMDECIMALES
        Return column
    End Function


End Class

 