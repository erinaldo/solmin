Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class TD_TipoAyuda
#Region " Atributos "
    Public pCCMPRN_Codigo As String = ""
    Public pTDSDES_Detalle As String = ""
#End Region
#Region " Métodos "
    Public Sub pClear()
        pCCMPRN_Codigo = ""
        pTDSDES_Detalle = ""
    End Sub
#End Region
End Class