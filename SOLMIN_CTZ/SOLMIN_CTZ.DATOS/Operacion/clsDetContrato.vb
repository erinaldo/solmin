Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsDetContrato
    'Public Function Lista_Detalle_Contrato(ByVal pobjContrato As Contrato) As DataTable
    '    Dim dt As DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter

    '    lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_DETALLE_CONTRATO", lobjParams)
    '    Return dt
    'End Function

    Public Sub Grabar_Observacion(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Detalle As Bitacora_Detalle)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjBitacora_Detalle.NRCTSL)
            lobjParams.Add("PNNRITOC", pobjBitacora_Detalle.NRITOC)
            lobjParams.Add("PNNRITEM", pobjBitacora_Detalle.NRITEM)
            lobjParams.Add("PNTFCOBS", pobjBitacora_Detalle.TFCOBS)
            lobjParams.Add("PSTOBS", pobjBitacora_Detalle.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            oSqlMan.ExecuteNonQuery("SP_SOLCT_GRABAR_OBSERVACION_DET_CONTRATO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_Observaciones(ByRef oSqlMan As SqlManager, ByVal pobjBitacora_Detalle As Bitacora_Detalle)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjBitacora_Detalle.NRCTSL)
            lobjParams.Add("PNNRITEM", pobjBitacora_Detalle.NRITEM)
            oSqlMan.ExecuteNonQuery("SP_SOLCT_BORRAR_OBSERVACIONES_DET_CONTRATO", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Observacion_Det_Contrato(ByVal pobjContrato As Contrato) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjContrato.NRCTSL)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_OBSERVACION_DET_CONTRATO", lobjParams)
        Return dt
    End Function

    'Public Sub Agregar_Detalle_Contrato(ByRef oSqlMan As SqlManager, ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        Dim lobjParams As New Parameter

    '        lobjParams.Add("PNNRCTSL", pobjDetContrato.NRCTSL)
    '        lobjParams.Add("PNNRTFSV", pobjDetContrato.NRTFSV)
    '        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
    '        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    '        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
    '        oSqlMan.ExecuteNonQuery("SP_SOLCT_AGREGAR_DETALLE_CONTRATO", lobjParams)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub Quitar_Detalle_Contrato(ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        Dim lobjSql As New SqlManager
    '        Dim lobjParams As New Parameter

    '        lobjParams.Add("PNNRCTSL", pobjDetContrato.NRCTSL)
    '        lobjParams.Add("PNNRITEM", pobjDetContrato.NRITEM)
    '        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
    '        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    '        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
    '        lobjSql.ExecuteNonQuery("SP_SOLCT_QUITAR_DETALLE_CONTRATO", lobjParams)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub Actualizar_Vigencia_Detalle_Contrato(ByVal pobjDetContrato As Detalle_Contrato)
    '    Try
    '        Dim lobjSql As New SqlManager
    '        Dim lobjParams As New Parameter

    '        lobjParams.Add("PNNRCTSL", pobjDetContrato.NRCTSL)
    '        lobjParams.Add("PNNRITEM", pobjDetContrato.NRITEM)
    '        lobjParams.Add("PNFECINI", pobjDetContrato.FECINI)
    '        lobjParams.Add("PNFECFIN", pobjDetContrato.FECFIN)
    '        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
    '        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
    '        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
    '        lobjSql.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_VIGENCIA_DETALLE_CONTRATO", lobjParams)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Function Lista_Detalle_Contrato_AS400_ALM(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjFiltro.Parametro1)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_AS400_LISTA_DET_CONTRATO_ALM", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_Contrato_AS400_SIL(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNCTZCN", pobjFiltro.Parametro1)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_AS400_LISTA_DET_CONTRATO_SIL", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_Contrato_AS400_TRP(ByVal pobjFiltro As Filtro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNCTZCN", pobjFiltro.Parametro1)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_AS400_LISTA_DET_CONTRATO_TRP", lobjParams)
        Return dt
    End Function
End Class
