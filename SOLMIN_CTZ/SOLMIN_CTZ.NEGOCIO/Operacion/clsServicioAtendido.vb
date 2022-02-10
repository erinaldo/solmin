Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsServicioAtendido
    Private oServicioAtendido As SOLMIN_CTZ.DATOS.clsServicioAtendido

    Sub New()
        oServicioAtendido = New SOLMIN_CTZ.DATOS.clsServicioAtendido
    End Sub

    Public Function Lista_ParaFaturacion(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Lista_ParaFaturacion(poServiciosAtendidos)
    End Function

    Public Function Lista_Servicio_Atendido(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Lista_Servicio_Atendido(poServiciosAtendidos)
    End Function

    Public Sub ActualizarServicio_Atendido(ByVal poServiciosAtendidos As Servicio_Atendido)
        Try
            oServicioAtendido.ActualizarServicio_Atendido(poServiciosAtendidos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerCodigoConsistencia() As DataTable
        Return oServicioAtendido.ObtenerCodigoConsistencia()
    End Function

    Public Sub AnularFactura(ByVal poServiciosAtendidos As Servicio_Atendido)
        Try
            oServicioAtendido.AnularFactura(poServiciosAtendidos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function DetalleFactura(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.DetalleFactura(poServiciosAtendidos)
    End Function

    Public Function Lista_Datos_Consistencia(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Lista_Datos_Consistencia(poServiciosAtendidos)
    End Function
    Public Function Cargar_Operaciones(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Cargar_Operaciones(poServiciosAtendidos)
    End Function
    Public Function Cargar_Servicios(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Cargar_Servicios(poServiciosAtendidos)
    End Function
    Public Function Cargar_Bultos(ByVal poServiciosAtendidos As Servicio_Atendido) As DataTable
        Return oServicioAtendido.Cargar_Bultos(poServiciosAtendidos)
    End Function
End Class

