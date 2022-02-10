
Public Class clsCompaniaNeg
    Private oCompaniaDato As clsCompania
    Private oDt As DataTable

    Sub New()
        oCompaniaDato = New clsCompania
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Sub Crea_Lista(ByVal Usuario As String)
        oDt = oCompaniaDato.Lista_Compania_X_Usuario(Usuario)
        'oDt = oCompaniaDato.Lista_Compania()
    End Sub

    Public Function Lista_Region_Venta(ByVal pdblCodCompania As String) As String
        Dim objListaDr As DataRow()

        objListaDr = oDt.Select("CCMPN='" & pdblCodCompania.Trim & "'")

        Return objListaDr(0).Item("CRGVTA")
    End Function

End Class