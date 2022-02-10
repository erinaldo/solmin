  
Public Class clsDatoGeneral_BLL
    Dim objGeneral As New clsDatoGeneral_DAL
    'JM
    Public Function Lista_Tipo_Dato_General(ByVal CCMPN As String, ByVal CODVAR As String) As List(Of TipoDatoGeneral)
        Return objGeneral.Lista_Tipo_Dato_General(CCMPN, CODVAR)
    End Function

End Class


