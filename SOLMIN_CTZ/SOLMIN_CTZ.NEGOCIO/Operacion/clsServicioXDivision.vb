Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsServicioXDivision
    Private oServicioXDivision As SOLMIN_CTZ.DATOS.clsServicioXDivision

    Sub New()
        oServicioXDivision = New SOLMIN_CTZ.DATOS.clsServicioXDivision
    End Sub

    Public Function Lista_Servicio_X_Division(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro, ByVal pobjFiltro As Filtro) As DataTable
        Return oServicioXDivision.Lista_Servicio_X_Division(pobjServicio_X_Rubro, pobjFiltro)
    End Function

    'Public Sub Agregar_Servicio_X_Division(ByRef oSqlMan As SqlManager, ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
    '    Try
    '        oServicioXDivision.Agregar_Servicio_X_Division(oSqlMan, pobjServicio_X_Rubro)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub Quitar_Servicio_X_Division(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
        Try
            oServicioXDivision.Quitar_Servicio_X_Division(pobjServicio_X_Rubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Function fdtListaServiciosGenerales(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable
        Return oServicioXDivision.fdtListaServiciosGenerales(pobjFiltro)
    End Function

    Public Function fdtListaServiciosEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable
        Return oServicioXDivision.fdtListaServiciosEspecificos(pobjFiltro)
    End Function


    Public Function fintGuardarServicioGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Return oServicioXDivision.fintGuardarServicioGeneral(pobjFiltro)
    End Function

    Public Function fintGuardarServicioEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Return oServicioXDivision.fintGuardarServicioEspecificos(pobjFiltro)
    End Function

    Public Function fbolVerificarServicoGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Boolean
        Return oServicioXDivision.fbolVerificarServicoGeneral(pobjFiltro)
    End Function

    Public Function fintQuitarServicoGeneral(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Return oServicioXDivision.fintQuitarServicoGeneral(pobjFiltro)
    End Function

    Public Function fbolVerificarServicioEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As Boolean
        Return oServicioXDivision.fbolVerificarServicioEspecificos(pobjFiltro)
    End Function

    Public Function fintEliminarServicioEspecificos(ByVal pobjFiltro As Servicio_X_Rubro) As Integer
        Return oServicioXDivision.fintEliminarServicioEspecificos(pobjFiltro)
    End Function

    Public Function fdtListaParaExportarExcel(ByVal pobjFiltro As Servicio_X_Rubro) As DataTable
        Return oServicioXDivision.fdtListaParaExportarExcel(pobjFiltro)
    End Function

End Class
