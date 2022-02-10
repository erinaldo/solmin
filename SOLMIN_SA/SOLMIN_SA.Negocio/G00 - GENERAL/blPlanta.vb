Imports RANSA.DATA
Public Class blPlanta
    Public Function Obtener_Planta_Cliente_Tercero(ByVal PNCPRVCL_CodigoClienteTercero As Int64) As DataTable
        Return New daPlanta().Obtener_Planta_Cliente_Tercero(PNCPRVCL_CodigoClienteTercero)
    End Function
    Public Function Obtener_Planta_Cliente_Propio(ByVal CCLNT_CodigoCliente As Int64) As DataTable
        Return New daPlanta().Obtener_Planta_Cliente_Propio(CCLNT_CodigoCliente)
    End Function
End Class
