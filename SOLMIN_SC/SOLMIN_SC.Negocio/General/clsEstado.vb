Imports SOLMIN_SC.Datos
Public Class clsEstado
    Public Function Estado_Aduanero() As DataTable
        Dim oclsEstado As New Datos.clsEstado
        Return oclsEstado.Estado_Aduanero
    End Function

    Public Function Listar_TipoOperacionEmbarque() As DataTable
        Dim oclsEstado As New Datos.clsEstado
        Return oclsEstado.Listar_TipoOperacionEmbarque
     
    End Function
    Public Function Listar_Status_Embarque() As DataTable
        Dim oclsEstado As New Datos.clsEstado
        Return oclsEstado.Listar_Status_Embarque
    End Function

    Public Function Estado_CartaFianza() As DataTable
        Dim oclsEstado As New Datos.clsEstado
        Return oclsEstado.Estado_CartaFianza
    End Function


End Class
