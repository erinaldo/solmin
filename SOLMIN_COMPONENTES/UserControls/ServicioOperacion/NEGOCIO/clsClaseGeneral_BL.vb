Public Class clsClaseGeneral_BL
    '<[AHM]>
    Private oclsClaseGeneral_DAL As New clsClaseGeneral_DAL
    Public Function Listar_Tipo_Servicio_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral_BE)
        Return oclsClaseGeneral_DAL.Listar_Tipo_Servicio_SAP(PSCDSRSP)
    End Function

    Public Function Listar_Tipo_UnidadProductiva_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral_BE)
        Return oclsClaseGeneral_DAL.Listar_Tipo_UnidadProductiva_SAP(PSCDSRSP)
    End Function


    


    Public Function Listar_Tipo_Activo_SAP() As List(Of ClaseGeneral_BE)
        Return oclsClaseGeneral_DAL.Listar_Tipo_Activo_SAP()
    End Function
End Class
