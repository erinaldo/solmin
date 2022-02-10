Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsConfValorizacion
    Private oValorizacion As SOLMIN_CTZ.DATOS.clsValorizacion
    Private oDt As DataTable


    Sub New()
        oValorizacion = New SOLMIN_CTZ.DATOS.clsValorizacion
    End Sub


    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function ListarConfCierreValorizacion(ByVal pobjValorizacion As SOLMIN_CTZ.Entidades.Valorizacion) As DataTable
        Return oValorizacion.ListarConfCierreValorizacion(pobjValorizacion)
    End Function



    Public Function Actualizar_Valorizacion(ByVal oValorizacionUpd As SOLMIN_CTZ.Entidades.Valorizacion) As DataTable

        Return oValorizacion.Actualizar_Valorizacion(oValorizacionUpd)

    End Function

    Public Function Insertar_Valorizacion(ByVal oValorizacionNew As SOLMIN_CTZ.Entidades.Valorizacion) As DataTable

        Return oValorizacion.Insertar_Valorizacion(oValorizacionNew)

    End Function

    Public Function AnularCerrar_Valorizacion(ByVal oValorizacionAnularCerrar As SOLMIN_CTZ.Entidades.Valorizacion) As DataTable

        Return oValorizacion.AnularCerrar_Valorizacion(oValorizacionAnularCerrar)

    End Function






End Class
