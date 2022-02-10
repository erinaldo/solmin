Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsTableroDatos
    Public Function Columnas_X_Tablero(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal PNCCLNT As Decimal, ByVal PSCTPAPP As String, ByVal PNNRORPT As Decimal)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCTPAPP", PSCTPAPP)
        lobjParams.Add("PNNRORPT", PNNRORPT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_COLUMNAS_X_REPORTE", lobjParams)
        Return dt
    End Function

    Public Function Listar_Detalle_Asignacion_Item(ByVal PNCCLNT As Double, ByVal PNNRORPT As Double)
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCLNT", PNCCLNT)
        lobjParams.Add("PSNRORPT", PNNRORPT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DETALLE_ASIGNACION_ITEM", lobjParams)
        Return dt
    End Function


    Public Sub Actualizar_Estado_Item(ByVal pdblCodigo As Double, ByVal pstrEstadoreg As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNMRCRL", pdblCodigo)
        lobjParams.Add("PSSESTRG", pstrEstadoreg)
        lobjSql.ExecuteNonQuery("SP_SOLSC_Act_Estado_Item", lobjParams)
    End Sub


    Public Function Listar_Estado_Reporte() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_ESTADO_REPORTE", Nothing)
        Return dt
    End Function



    Public Sub Actualizar_Secuencia_Item(ByVal pstrCodCli As Double, ByVal pdCodReporte As Double, ByVal pstrActual As String, ByVal pstrArriba As String, ByVal pstrAbajo As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pstrCodCli)
        lobjParams.Add("PNNRORPT", pdCodReporte)
        lobjParams.Add("PSactual", pstrActual)
        lobjParams.Add("PSarriba", pstrArriba)
        lobjParams.Add("PSabajo", pstrAbajo)
        lobjSql.ExecuteNonQuery("SP_SOLSC_Act_Secuencia_Item", lobjParams)
    End Sub

    Public Function Columnas_X_Tablero_X_Visibilidad(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSCTPAPP As String, ByVal PNNRORPT As Decimal, ByVal PSSTPCRE As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSCTPAPP", PSCTPAPP)
        lobjParams.Add("PNNRORPT", PNNRORPT)
        lobjParams.Add("PSSTPCRE", PSSTPCRE)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_COLUMNAS_X_REPORTE_OPCION_VISIBILIDAD", lobjParams)
        Return dt
    End Function


    Public Sub Actualizar_Columna_Embarque(ByVal obeCampoReporte As beTrableroDatos)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNMRCRL", obeCampoReporte.PNNMRCRL)
        lobjParams.Add("PSTCOLUM", obeCampoReporte.PSTCOLUM)
        lobjParams.Add("PSTDITIN", obeCampoReporte.PSTDITIN)
        lobjParams.Add("PNNSEPRE", obeCampoReporte.PNNSEPRE)
        lobjParams.Add("PSSTPCRE", obeCampoReporte.PSSTPCRE)
        lobjParams.Add("PNQANCOL", obeCampoReporte.PNQANCOL)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_COLUMNA_EMBARQUE", lobjParams)
    End Sub

    Public Sub Eliminar_Columna_Embarque(ByVal PNNMRCRL As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNMRCRL", PNNMRCRL)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_COLUMNA_EMBARQUE", lobjParams)
    End Sub

    Public Sub Insertar_Columna_Embarque(ByVal obeCampoReporte As beTrableroDatos)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeCampoReporte.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeCampoReporte.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeCampoReporte.PNCCLNT)
        lobjParams.Add("PSTNMBCM", obeCampoReporte.PSTNMBCM)
        lobjParams.Add("PSTCOLUM", obeCampoReporte.PSTCOLUM)
        lobjParams.Add("PSTDITIN", obeCampoReporte.PSTDITIN)
        lobjParams.Add("PSSTPCRE", obeCampoReporte.PSSTPCRE)
        lobjParams.Add("PNQANCOL", obeCampoReporte.PNQANCOL)
        lobjSql.ExecuteNonQuery("SP_SOLSC_INSERTAR_COLUMNA_EMBARQUE", lobjParams)
    End Sub


End Class






