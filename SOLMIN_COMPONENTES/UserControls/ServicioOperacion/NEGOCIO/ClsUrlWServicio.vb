Public Class ClsUrlWServicio
    Public Function Listar_Url_Servicio(Proceso As String, SubProceso As String, TipoProc As String, CodCliente As Decimal) As DataTable
        Dim oClsUrlWServicio As New clsUrlWServicio_DAL
        Return oClsUrlWServicio.Listar_Url_Servicio(Proceso, SubProceso, TipoProc, CodCliente)
    End Function

End Class
