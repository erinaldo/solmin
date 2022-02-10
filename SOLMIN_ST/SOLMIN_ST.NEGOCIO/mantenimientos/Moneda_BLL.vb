Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES

Public Class Moneda_BLL
    Private objDatos As New Moneda_DAL

    Public Function Tipo_Cambio(ByVal pobjEntidad As Moneda) As Double
        Return objDatos.Tipo_Cambio(pobjEntidad)
    End Function


    Public Function Listar_Monedas_Combo(ByVal strCompania As String) As DataTable
        Return objDatos.Listar_Monedas_Combo(strCompania)
    End Function

    Public Function Listar_Monedas_Basica() As DataTable
        Return objDatos.Listar_Monedas_Basica()
    End Function

End Class
