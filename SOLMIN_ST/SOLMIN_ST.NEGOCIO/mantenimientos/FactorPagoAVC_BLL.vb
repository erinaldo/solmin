Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES


Public Class FactorPagoAVC_BLL

    Dim objDataAccessLayer As New FactorPagoAVC_DAL

    Public Function ListarFactorPagoAVC_Cliente(ByVal objEntidad As FactorPagoAVC) As List(Of FactorPagoAVC)
        Return objDataAccessLayer.ListarFactorPagoAVC_Cliente(objEntidad)
    End Function

    Public Sub Mantenimiento_Factor_Pago_AVC(ByVal objEntidad As FactorPagoAVC)
        Try
            objDataAccessLayer.Mantenimiento_Factor_Pago_AVC(objEntidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
