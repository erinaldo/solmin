Imports SOLMIN_ST.DATOS 
Public Class UrlServicios_BLL

    Public Function Listar_Url_Servicio(Proceso As String, SubProceso As String, TipoProc As String, CodCliente As Decimal) As DataTable
        Dim odaUrlServicio As New UrlServicios
        Return odaUrlServicio.Listar_Url_Servicio(Proceso, SubProceso, TipoProc, CodCliente)
    End Function
End Class
