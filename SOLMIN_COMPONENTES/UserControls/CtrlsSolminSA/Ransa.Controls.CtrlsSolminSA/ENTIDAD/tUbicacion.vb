Imports System.Runtime.InteropServices

Namespace Ubicacion
    <StructLayout(LayoutKind.Sequential)> _
    Public Class TD_Ubicacion
#Region " Atributos "
        Public pCCLNT_Cliente As String = ""
        Public pTUBRFR_Ubicacion As String = ""
#End Region
#Region " Métodos "
        Sub New(Optional ByVal Cliente As Int64 = 0, Optional ByVal Ubicacion As String = "")
            pCCLNT_Cliente = Cliente
            pTUBRFR_Ubicacion = Ubicacion
        End Sub

        Public Sub pClear()
            pCCLNT_Cliente = ""
            pTUBRFR_Ubicacion = ""
        End Sub
#End Region
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class TF_Ubicacion
#Region " Atributos "
        Public pCCLNT_Cliente As String = ""
        Public pCondicion As String = ""
#End Region
#Region " Métodos "
        Sub New(Optional ByVal Cliente As Int64 = 0, Optional ByVal Condicion As String = "")
            pCCLNT_Cliente = Cliente
            pCondicion = Condicion
        End Sub

        Public Sub pClear()
            pCCLNT_Cliente = ""
            pCondicion = ""
        End Sub
#End Region
    End Class
End Namespace