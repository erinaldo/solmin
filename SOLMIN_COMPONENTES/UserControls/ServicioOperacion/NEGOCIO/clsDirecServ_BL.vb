Public Class clsDirecServ_BL
    Private direcserv As New clsDirecServ_DAL
    Public Function Buscar_Direccion_Servicio(ByVal codigo As Decimal, _
                                          ByVal direccion As String, _
                                          ByVal ubigeo As Decimal, _
                                          ByVal referencia As String) As DataTable

        Dim output As DataTable = direcserv.Buscar_Direccion_Servicio(codigo, _
                                                                      direccion, _
                                                                      ubigeo, _
                                                                      referencia)
        Return output
    End Function

End Class
