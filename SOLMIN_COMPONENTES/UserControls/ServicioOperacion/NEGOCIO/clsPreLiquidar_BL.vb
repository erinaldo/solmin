Public Class clsPreLiquidar_BL

    Private objDataAccessLayer As New clsPreLiquidar_DAL
    Public Function Registrar_PreLiquidacion(ByVal objEntidad As PreLiquidar_BE, ByVal NSECFC As String, ByRef NPRLCF As Decimal) As String
        
        Return objDataAccessLayer.Registrar_PreLiquidacion(objEntidad, NSECFC, NPRLCF)
       
    End Function

End Class
