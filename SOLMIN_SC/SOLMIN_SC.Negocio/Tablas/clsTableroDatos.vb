Imports SOLMIN_SC.Entidad
Public Class clsTableroDatos
    Private oTableroDatos As Datos.clsTableroDatos
    Sub New()
        oTableroDatos = New Datos.clsTableroDatos
    End Sub

    Public Function Llenar_Tabla_X_Opcion(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSCTPAPP As String, ByVal PNNRORPT As Decimal, ByVal PSSTPCRE As String) As DataTable
        Return oTableroDatos.Columnas_X_Tablero_X_Visibilidad(PSCCMPN, PNCCLNT, PSCTPAPP, PNNRORPT, PSSTPCRE)
    End Function

    Public Function Listar_Detalle_Asignacion_ItemB(ByVal pstrCodCli As Double, ByVal CodReporte As Double) As DataTable
        Return oTableroDatos.Listar_Detalle_Asignacion_Item(pstrCodCli, CodReporte)
    End Function

    Public Sub Actualizar_Estado_ItemB(ByVal pdblCodigo As Double, ByVal pstrEstadoreg As String)
        Try
            oTableroDatos.Actualizar_Estado_Item(pdblCodigo, pstrEstadoreg)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Listar_Estado_ReporteB() As DataTable
        Return oTableroDatos.Listar_Estado_Reporte()
    End Function


    Public Sub Actualizar_Secuencia_ItemB(ByVal pstrCodCli As Double, ByVal pdCodReporte As Double, ByVal pstrActual As String, ByVal pstrArriba As String, ByVal pstrAbajo As String)

        Try
            oTableroDatos.Actualizar_Secuencia_Item(pstrCodCli, pdCodReporte, pstrActual, pstrArriba, pstrAbajo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Columna_Embarque(ByVal obeCampoReporte As beTrableroDatos)
        oTableroDatos.Actualizar_Columna_Embarque(obeCampoReporte)
    End Sub

    Public Sub Eliminar_Columna_Embarque(ByVal PNNMRCRL As Decimal)
        oTableroDatos.Eliminar_Columna_Embarque(PNNMRCRL)
    End Sub
    Public Sub Insertar_Columna_Embarque(ByVal obeCampoReporte As beTrableroDatos)
        oTableroDatos.Insertar_Columna_Embarque(obeCampoReporte)
    End Sub
End Class
