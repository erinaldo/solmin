Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class Obrero_BLL
    Private objDatos As Obrero_DAL

    Public Sub New()
        objDatos = New Obrero_DAL
    End Sub

    Public Function Lista_Obreros(ByVal objEntidad As Hashtable) As List(Of Obrero)
        Try
            Return objDatos.Lista_Obreros(objEntidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Lista_Obrero_Empleado_RANSA() As List(Of ClaseGeneral)
        Try
            Return objDatos.Lista_Obrero_Empleado_RANSA()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Guardar_Obrero(ByVal objEntidad As Obrero)
        Try
            objDatos.Guardar_Obrero(objEntidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Obreros_Operacion_Placa(ByVal objEntidad As Hashtable) As List(Of Obrero)
        Return objDatos.Lista_Obreros_Operacion_Placa(objEntidad)
    End Function

  
End Class
