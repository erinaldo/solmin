Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsDestiCorreoValorizacion

    Private oCorreoValorizacion As SOLMIN_CTZ.DATOS.clsDestMailValorizacion

    Private oDt As DataTable

    Sub New()
        oCorreoValorizacion = New SOLMIN_CTZ.DATOS.clsDestMailValorizacion
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    'Public Function ListarConfCierreValorizacion(ByVal oCorreoValorizacionListar As SOLMIN_CTZ.Entidades.beCorreoValorizacion) As List(Of beCorreoValorizacion)
    '    Return oCorreoValorizacion.ListarCorreoValorizacion(oCorreoValorizacionListar)
    'End Function
    Public Function ListarConfCierreValorizacion(ByVal oCorreoValorizacionListar As SOLMIN_CTZ.Entidades.beCorreoValorizacion) As DataTable
        Return oCorreoValorizacion.ListarCorreoValorizacion(oCorreoValorizacionListar)
    End Function

    Public Function InsertarCorreoValorizacion(ByVal oCorreoValorizacionNew As SOLMIN_CTZ.Entidades.beCorreoValorizacion) As DataTable
        Return oCorreoValorizacion.InsertarCorreo_Valorizacion(oCorreoValorizacionNew)
    End Function

    Public Sub EliminarCorreoValorizacion(ByVal oCorreoValorizacionEliminar As SOLMIN_CTZ.Entidades.beCorreoValorizacion)
        oCorreoValorizacion.EliminarCorreo_Valorizacion(oCorreoValorizacionEliminar)
    End Sub




    Public Function ActualizaCorreoValorizacion(ByVal oCorreoValorizacionUpd As SOLMIN_CTZ.Entidades.beCorreoValorizacion) As DataTable
        Return oCorreoValorizacion.ActualizaCorreoValorizacion(oCorreoValorizacionUpd)
    End Function








End Class
