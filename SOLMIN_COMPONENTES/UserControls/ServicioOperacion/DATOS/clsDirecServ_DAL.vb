Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsDirecServ_DAL

    Public Function Buscar_Direccion_Servicio(ByVal codigo As Decimal, _
                                         ByVal direccion As String, _
                                         ByVal ubigeo As Decimal, _
                                         ByVal referencia As String) As DataTable

        Dim output As DataTable

        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter

        parameter.Add("PNCDIRSE", codigo)
        parameter.Add("PSDEDISE", direccion)
        parameter.Add("PSDREFSE", referencia)
        parameter.Add("PNUBIGEO", ubigeo)

        output = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_BUSCA_DIRECCION_SERVICIO", parameter)

        Return output

    End Function

End Class
