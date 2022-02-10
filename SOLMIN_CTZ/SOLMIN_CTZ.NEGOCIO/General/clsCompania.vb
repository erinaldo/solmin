Imports SOLMIN_CTZ.DATOS

Public Class clsCompania
    Private oCompaniaDato As SOLMIN_CTZ.DATOS.clsCompania
    Private oDt As DataTable

    Sub New()
        oCompaniaDato = New SOLMIN_CTZ.DATOS.clsCompania
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Sub Crea_Lista()
        oDt = oCompaniaDato.Lista_Compania_X_Usuario()
        'oDt = oCompaniaDato.Lista_Compania()
    End Sub

    Public Function Lista_Region_Venta(ByVal pdblCodCompania As String) As String
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "'")

        Return objListaDr(0).Item("CRGVTA")
    End Function

    Public Function Nombre_Usuario(ByVal strusuario As String) As String
        Return oCompaniaDato.Nombre_Usuario(strusuario)
    End Function

End Class