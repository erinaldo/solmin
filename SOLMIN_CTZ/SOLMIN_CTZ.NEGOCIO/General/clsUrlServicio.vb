Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS
Public Class clsUrlServicio
    Public Function Listar_Url_Servicio(Proceso As String, SubProceso As String, TipoProc As String, CodCliente As Decimal) As DataTable
        Dim odaUrlServicio As New DATOS.clsUrlServicio
        Return odaUrlServicio.Listar_Url_Servicio(Proceso, SubProceso, TipoProc, CodCliente)
    End Function
End Class
