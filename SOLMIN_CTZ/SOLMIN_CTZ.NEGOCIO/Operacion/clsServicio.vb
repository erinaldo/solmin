Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsServicio
    Private oServicioDato As SOLMIN_CTZ.DATOS.clsServicio
    Private oDt As DataTable

    Sub New()
        oServicioDato = New SOLMIN_CTZ.DATOS.clsServicio
    End Sub

    'Public Function Lista_Servicio(ByVal pobjServicio As Servicio, ByVal pobjFiltro As Filtro) As DataTable
    '    Return oServicioDato.Lista_Servicio(pobjServicio, pobjFiltro)
    'End Function

    Public Function Lista_Servicio_X_Compania(ByVal pobjFiltro As Filtro) As DataTable
        Return oServicioDato.Lista_Servicio_X_Compania(pobjFiltro)
    End Function

    Public Function Lista_Servicio_X_Compania_Division(ByVal pobjFiltro As Filtro) As List(Of Servicio_X_Rubro) 'As DataTable
        Return oServicioDato.Lista_Servicio_X_Compania_Division(pobjFiltro)
    End Function

    Public Function Lista_Servicio_X_Compania_Division_OS(ByVal pobjFiltro As Filtro) As List(Of Servicio_X_Rubro)
        Return oServicioDato.Lista_Servicio_X_Compania_Division_OS(pobjFiltro)
    End Function

    Public Function Lista_Servicio_X_Compania_Division_X_Rubro(ByVal pobjFiltro As Filtro) As DataTable
        Return oServicioDato.Lista_Servicio_X_Compania_Division_X_Rubro(pobjFiltro)
    End Function

    Public Function Lista_Servicio_X_Compania_Division_X_Rubro_Servicio(ByVal pobjFiltro As Filtro) As DataTable
        Return oServicioDato.Lista_Servicio_X_Compania_Division_X_Rubro_Servicio(pobjFiltro)
    End Function

    Public Sub Crear_Servicio(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
        Try
            oServicioDato.Crear_Servicio(pobjServicio_X_Rubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub Actualizar_Servicio(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
        Try
            oServicioDato.Actualizar_Servicio(pobjServicio_X_Rubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_Servicio(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro)
        Try
            oServicioDato.Eliminar_Servicio(pobjServicio_X_Rubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Verificar_Servicio(ByVal pobjServicio_X_Rubro As Servicio_X_Rubro) As DataTable
        Return oServicioDato.Verificar_Servicio(pobjServicio_X_Rubro)
    End Function

    Public Function Lista_Servicio_General(ByVal pobjServicioGral As Servicio_X_Rubro) As List(Of Servicio_X_Rubro)
        Return oServicioDato.Lista_Servicio_General(pobjServicioGral)
    End Function

    Public Function Lista_Servicio_X_Rubro_X_Compania_Division(ByVal pobjFiltro As Filtro) As DataTable
        Return oServicioDato.Lista_Servicio_X_Rubro_X_Compania_Division(pobjFiltro)
    End Function

    Public Function VerificarConfiguracionOrdenServicio(ByVal pobjFiltro As Filtro) As String
        Return oServicioDato.VerificarConfiguracionOrdenServicio(pobjFiltro)
    End Function

End Class
