Public Class clsAcceso
    Private objAcceso As SOLMIN_CTZ.DATOS.clsAcceso

    Sub New()
        objAcceso = New SOLMIN_CTZ.DATOS.clsAcceso
    End Sub

    Public Function Verifica_Archivo() As Boolean
        Return objAcceso.Verifica_Archivo
    End Function

    Public Function Valida_Acceso(ByVal pstrUser As String, ByVal pstrPass As String) As Boolean
        Return objAcceso.Valida_Acceso(pstrUser, pstrPass)
    End Function

    Public Sub Destruir()
        objAcceso.Destruir()
    End Sub
End Class
