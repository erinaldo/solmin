Imports System.Runtime.InteropServices
Imports System.ComponentModel
<StructLayout(LayoutKind.Sequential)> _
Public Class TD_Inf_Unidad_L02
#Region " Atributos "
    Private _pCUNDMD_Unidad As String
    Private _pTABRUN_Descripcion As String
    <Description("CUNDMD")> _
    Public Property pCUNDMD_Unidad() As String
        Get
            Return _pCUNDMD_Unidad
        End Get
        Set(ByVal value As String)
            _pCUNDMD_Unidad = value
        End Set
    End Property
    <Description("TABRUN")> _
    Public Property pTABRUN_Descripcion() As String
        Get
            Return _pTABRUN_Descripcion
        End Get
        Set(ByVal value As String)
            _pTABRUN_Descripcion = value
        End Set
    End Property


#End Region
#Region " Métodos "
    Public Sub pClear()
        pCUNDMD_Unidad = 0
        pTABRUN_Descripcion = ""
    End Sub
#End Region
End Class