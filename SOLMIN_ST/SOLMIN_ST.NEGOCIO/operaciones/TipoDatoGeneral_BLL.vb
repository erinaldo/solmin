Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Namespace Operaciones

    Public Class TipoDatoGeneral_BLL
        Dim objGeneral As New TipoDatoGeneral_DAL
        'JM
        Public Function Lista_Tipo_Dato_General(ByVal CCMPN As String, ByVal CODVAR As String) As List(Of TipoDatoGeneral)
            Return objGeneral.Lista_Tipo_Dato_General(CCMPN, CODVAR)
        End Function

        Public Function Lista_Tipo_Dato_General_RZPR05(ByVal PRTABL As String) As List(Of TipoDatoGeneral)
            Return objGeneral.Lista_Tipo_Dato_General_RZPR05(PRTABL)
        End Function

    End Class

End Namespace
