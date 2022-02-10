Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Public Class clsPreLiquidacionBL

    Public Function Registrar_PL_Transporte_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByRef NPRLQD As Decimal) As String
        ' Public Function Registrar_PreLiquidacion_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByVal NDCPRF As String, ByRef NPRLQD As Decimal, ACCION As String) As String
        Dim objDataAccessLayer As New SOLMIN_CTZ.DATOS.clsPreLiquidacion
        'Return objDataAccessLayer.Registrar_PreLiquidacion_X_Valorizacion(objEntidad, NDCPRF, NPRLQD, ACCION)
        Return objDataAccessLayer.Registrar_PL_Transporte_X_Valorizacion(objEntidad, NPRLQD)
    End Function
    Public Function Registrar_PL_Admin_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByRef NPRLQD As Decimal) As String
        Dim objDataAccessLayer As New SOLMIN_CTZ.DATOS.clsPreLiquidacion
        Return objDataAccessLayer.Registrar_PL_Admin_X_Valorizacion(objEntidad, NPRLQD)
    End Function



End Class
