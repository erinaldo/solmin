Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsRubro
    Private oRubroDato As SOLMIN_CTZ.DATOS.clsRubro

    Sub New()
        oRubroDato = New SOLMIN_CTZ.DATOS.clsRubro
    End Sub

    'Public Function Lista_Rubro(ByVal pobjRubro As Rubro, ByVal pobjFiltro As Filtro) As DataTable
    '    Return oRubroDato.Lista_Rubro(pobjRubro, pobjFiltro)
    'End Function

    Public Sub Crear_Rubro(ByVal pobjRubro As Rubro)
        Try
            oRubroDato.Crear_Rubro(pobjRubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Rubro(ByVal pobjRubro As Rubro)
        Try
            oRubroDato.Actualizar_Rubro(pobjRubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Quitar_Rubro_X_Division(ByVal pobjRubro As Rubro)
        Try
            oRubroDato.Quitar_Rubro_X_Division(pobjRubro)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Verificar_Rubro(ByVal pobjRubro As Rubro) As DataTable
        Return oRubroDato.Verificar_Rubro(pobjRubro)
    End Function
End Class
