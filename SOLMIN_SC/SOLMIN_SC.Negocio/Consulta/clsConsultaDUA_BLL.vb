Imports SOLMIN_SC.Datos
Imports Ransa.Utilitario


Public Class clsConsultaDUA_BLL

    Function Load_Data_General(ByVal DUA As String) As DataTable

        Dim dtGeneral As New DataTable
        Dim objDAL As New clsConsultaDUA_DAL
        dtGeneral = objDAL.Load_Data_General(DUA)
        Return dtGeneral
    End Function

    Function Load_Data_Detail(ByVal CODI_ADUAN As Decimal, ByVal ANO_PRESE As Decimal, ByVal CODI_REGI As Decimal, ByVal NUME_ORDEN As Decimal) As DataSet

        Dim dsDetail As New DataSet
        Dim objDAL As New clsConsultaDUA_DAL
        dsDetail = objDAL.Load_Data_Detail(CODI_ADUAN, ANO_PRESE, CODI_REGI, NUME_ORDEN)

        Return dsDetail
    End Function

End Class
