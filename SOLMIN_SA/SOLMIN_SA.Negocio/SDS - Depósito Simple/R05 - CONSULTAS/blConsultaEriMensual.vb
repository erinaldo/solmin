Imports RANSA.DATA
Imports RANSA.TYPEDEF

Public Class blConsultaEriMensual
    'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-INICIO
    Public Function ListarCabeceraERI(ByVal objConsultaEri As beConsultaEriMensual) As DataSet
        Dim oDs As New DataSet
        Dim odRegistoConsultaEri As New daConsultaEriMensual
        oDs = odRegistoConsultaEri.ListarEriMensual(objConsultaEri)
        Return oDs
    End Function
End Class
'CSR-HUNDRED-REPUESTOS-ON-SIDE-PIURA-FIN
