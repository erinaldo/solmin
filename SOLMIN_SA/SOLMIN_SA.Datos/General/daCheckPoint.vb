Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daCheckPoint
    Inherits daBase(Of beCheckPoint)

#Region "Mantenimiento Checkpoint"
    Private objSql As New SqlManager

    Public Function InsertarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNESTDO", obeCheckPoint.PNNESTDO)
            objParam.Add("PSCCMPN", obeCheckPoint.PSCCMPN)
            objParam.Add("PSCDVSN", obeCheckPoint.PSCDVSN)
            objParam.Add("PSTDESES", obeCheckPoint.PSTDESES)
            objParam.Add("PSTABRST", obeCheckPoint.PSTABRST)
            objParam.Add("PSCEMB", obeCheckPoint.PSCEMB)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objParam.Add("PNFCHCRT", obeCheckPoint.PNFCHCRT)
            objParam.Add("PNHRACRT", obeCheckPoint.PNHRACRT)
            objParam.Add("PSCULUSA", obeCheckPoint.PSCULUSA)
            objParam.Add("PNFULTAC", obeCheckPoint.PNFULTAC)
            objParam.Add("PNHULTAC", obeCheckPoint.PNHULTAC)
            objParam.Add("PSSESTRG", obeCheckPoint.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obeCheckPoint.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CHECKPOINT_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ActualizarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNESTDO", obeCheckPoint.PNNESTDO)
            objParam.Add("PSCCMPN", obeCheckPoint.PSCCMPN)
            objParam.Add("PSCDVSN", obeCheckPoint.PSCDVSN)
            objParam.Add("PSTDESES", obeCheckPoint.PSTDESES)
            objParam.Add("PSTABRST", obeCheckPoint.PSTABRST)
            objParam.Add("PSCEMB", obeCheckPoint.PSCEMB)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objParam.Add("PNFCHCRT", obeCheckPoint.PNFCHCRT)
            objParam.Add("PNHRACRT", obeCheckPoint.PNHRACRT)
            objParam.Add("PSCULUSA", obeCheckPoint.PSCULUSA)
            objParam.Add("PNFULTAC", obeCheckPoint.PNFULTAC)
            objParam.Add("PNHULTAC", obeCheckPoint.PNHULTAC)
            objParam.Add("PSSESTRG", obeCheckPoint.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obeCheckPoint.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CHECKPOINT_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarCheckPoint(ByVal obeCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNESTDO", obeCheckPoint.PNNESTDO)
            objParam.Add("PSCCMPN", obeCheckPoint.PSCCMPN)
            objParam.Add("PSCDVSN", obeCheckPoint.PSCDVSN)
            objParam.Add("PSCEMB", obeCheckPoint.PSCEMB)
            Return Listar("SP_SOLMIN_SA_CHECKPOINT_LIST", objParam)
        Catch ex As Exception
            Return New List(Of beCheckPoint)
        End Try
    End Function

#End Region

#Region "Operaciones"
    ''' <summary>
    ''' Lista de Checkpoint por Cliente
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns>Lista de Checkpoint por cliente </returns>
    ''' <remarks></remarks>
    Public Function ListaCheckPointXCliente(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
        lobjParams.Add("PSCCMPN", obeCheckpoint.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeCheckpoint.PSCDVSN)
        lobjParams.Add("PSCEMB", obeCheckpoint.PSCEMB)
        Return Listar("SP_SOLMIN_SA_CHECKPOINT_X_CLIENTE", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of beCheckPoint)
        'End Try
    End Function

    ''' <summary>
    ''' Inserta Checkpoinst por guia de remision a la tabla RZOT01  Transaccional Checkpoint
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns>1 si se efectuo con exito y 0 si hubo algun tipo de error</returns>
    ''' <remarks></remarks>
    Public Function InsertarCheckPointXItemDeOc(ByVal obeCheckpoint As beCheckPoint) As Integer
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            lobjParams.Add("PNNESTDO", obeCheckpoint.PNNESTDO)
            lobjParams.Add("PNFESEST", obeCheckpoint.PNFESEST)
            lobjParams.Add("PNFRETES", obeCheckpoint.PNFRETES)
            lobjParams.Add("PSTOBEST", obeCheckpoint.PSTOBEST)
            lobjParams.Add("PSCUSCRT", obeCheckpoint.PSUSUARIO)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CHECKPOINT_X_ITEMS_DE_OC_INSERT", lobjParams)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Actualiza Checkpoinst por guia de remision a la tabla RZOT01  Transaccional Checkpoint
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns>1 si se efectuo con exito y 0 si hubo algun tipo de error</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCheckPointXGuiaDeRemision(ByVal obeCheckpoint As beCheckPoint) As Integer
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNMESTDO", obeCheckpoint.PNMESTDO)
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PNNGUIRM", obeCheckpoint.PNNGUIRM)
            lobjParams.Add("PNNESTDO", obeCheckpoint.PNNESTDO)
            lobjParams.Add("PNDFECEST", obeCheckpoint.PNFESEST)
            lobjParams.Add("PNDFECREA", obeCheckpoint.PNFRETES)
            lobjParams.Add("PSTOBS", obeCheckpoint.PSTOBEST)
            lobjParams.Add("PSCUSCRT", obeCheckpoint.PSCUSCRT)
            lobjParams.Add("PNFECHA", obeCheckpoint.PNFCHCRT)
            lobjParams.Add("PNHORA", obeCheckpoint.PNHRACRT)
            lobjParams.Add("PSSESTRG", obeCheckpoint.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CHECKPOINT_X_GUIA_DE_REMISION_UPDATE", lobjParams)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function



    ''' <summary>
    ''' Lista de Checkpoints por item de oc
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaCheckPointXItemsDeOC(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SA_LISTA_CHECKPOINT_X_OC", lobjParams)
        Catch ex As Exception
            Return New List(Of beCheckPoint)
        End Try
    End Function

    ''' <summary>
    ''' Lista de log de  Checkpoints por item de oc
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaLogDeCheckPointXItemsDeOC(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SA_LISTA_LOG_DE_CHECKPOINT_X_ITEM_DE_OC", lobjParams)
        Catch ex As Exception
            Return New List(Of beCheckPoint)
        End Try
    End Function

    ''' <summary>
    ''' Lista de checkpoints 
    ''' </summary>
    ''' <param name="obeCheckpoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaCheckpointExportarExcel(ByVal obeCheckpoint As beCheckPoint) As List(Of beCheckPoint)
        Dim lobjParams As New Parameter
        'Try
        lobjParams.Add("IN_CCLNT", obeCheckpoint.PNCCLNT)
        'lobjParams.Add("IN_NGUIRM", obeCheckpoint.PNNGUIRM)
        lobjParams.Add("IN_NGUIRM", obeCheckpoint.PSNGUIRM)
        lobjParams.Add("IN_FECINI", obeCheckpoint.PNFECINI)
        lobjParams.Add("IN_FECFIN", obeCheckpoint.PNFECFIN)
        Return Listar("SP_SOLMIN_SA_LISTAR_CHECKPOINT_EXPORTAR_EXCEL", lobjParams)
        'Catch ex As Exception
        '    Return New List(Of beCheckPoint)
        'End Try
    End Function


#End Region

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beCheckPoint)

    End Sub

#Region "Bitacoras"
    Public Function listar_bitacoras_itemOC(ByVal obeCheckPoint As beCheckPoint) As List(Of beCheckPoint)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SA_LISTAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            Return New List(Of beCheckPoint)
        End Try
    End Function

    Public Function insertar_bitacora_intemOC(ByVal obeCheckPoint As beCheckPoint) As boolean
        Dim objParam As New Parameter
        Dim result As Boolean = True
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            objParam.Add("PNNRITEM", obeCheckPoint.PNNRITEM)
            objParam.Add("PNTFCOBS", obeCheckPoint.PNTFCOBS)
            objParam.Add("PSTOBS", obeCheckPoint.PSTOBS)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_INSERTAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function

    Public Function eliminar_bitacora_intemOC(ByVal obeCheckPoint As beCheckPoint) As Boolean
        Dim objParam As New Parameter
        Dim result As Boolean = True
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            objParam.Add("PNNRITEM", obeCheckPoint.PNNRITEM)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ELIMINAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
#End Region
End Class
