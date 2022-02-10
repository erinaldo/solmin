Imports SOLMIN_ST.DATOS
Imports System.Data

Public Class ParametroFacturacion_BLL

    Private objDatos As New ParametroFacturacion_DAL

    Public Function Listar_Parametros_Facturacion_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Parametros_Facturacion_Combo(strCompania)
    End Function

End Class
