Imports System.Runtime.InteropServices
Imports System.ComponentModel
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Moneda
#Region " Atributos "
    Private _pCMNDA1_Codigo As String = ""
    Private _pTMNDA_Detalle As String = ""

    <Description("CMNDA1")> _
    Public Property pCMNDA1_Codigo() As String
        Get
            Return _pCMNDA1_Codigo
        End Get
        Set(ByVal value As String)
            _pCMNDA1_Codigo = value
        End Set
    End Property


    <Description("TMNDA")> _
    Public Property pTMNDA_Detalle() As String
        Get
            Return _pTMNDA_Detalle
        End Get
        Set(ByVal value As String)
            _pTMNDA_Detalle = value
        End Set
    End Property

#End Region
#Region " Métodos "
    Public Sub pClear()
        pCMNDA1_Codigo = ""
        pTMNDA_Detalle = ""
    End Sub
#End Region
End Class