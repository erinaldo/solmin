Imports SOLMIN_SC.Entidad
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsBitacora
    Inherits Base_DAL(Of beBitacora)


#Region "Bitacoras"
    Public Function listar_bitacoras_itemOC(ByVal obeCheckPoint As beBitacora) As List(Of beBitacora)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SC_LISTAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            Return New List(Of beBitacora)
        End Try
    End Function

    Public Function ListaLogDeCheckPointXItemsDeOC(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Dim lobjParams As New Parameter
      
        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SC_LISTA_LOG_DE_CHECKPOINT_X_ITEM_DE_OC", lobjParams)

        Catch ex As Exception
            Return New List(Of beBitacora)
        End Try
    End Function
    Public Function ListaCheckPointXItemsDeOC(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Dim lobjParams As New Parameter
     

        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            Return Listar("SP_SOLMIN_SC_LISTA_CHECKPOINT_X_OC", lobjParams)

        Catch ex As Exception
            Return New List(Of beBitacora)
        End Try
    End Function
    Public Function ListaCheckPointXCliente(ByVal obeCheckpoint As beBitacora) As List(Of beBitacora)
        Dim lobjParams As New Parameter

        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSCCMPN", obeCheckpoint.PSCCMPN)
            lobjParams.Add("PSCDVSN", obeCheckpoint.PSCDVSN)
            lobjParams.Add("PSCEMB", obeCheckpoint.PSCEMB)
            Return Listar("SP_SOLMIN_SC_CHECKPOINT_X_CLIENTE", lobjParams)

        Catch ex As Exception
            Return New List(Of beBitacora)
        End Try
    End Function
    Public Function insertar_bitacora_intemOC(ByVal obeCheckPoint As beBitacora) As Boolean
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Dim result As Boolean = True
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            objParam.Add("PNNRITEM", obeCheckPoint.PNNRITEM)
            objParam.Add("PNTFCOBS", obeCheckPoint.PNTFCOBS)
            objParam.Add("PSTOBS", obeCheckPoint.PSTOBS)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_INSERTAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function

    Public Function eliminar_bitacora_intemOC(ByVal obeCheckPoint As beBitacora) As Boolean
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Dim result As Boolean = True
        Try
            objParam.Add("PNCCLNT", obeCheckPoint.PNCCLNT)
            objParam.Add("PSNORCML", obeCheckPoint.PSNORCML)
            objParam.Add("PNNRITOC", obeCheckPoint.PNNRITOC)
            objParam.Add("PNNRITEM", obeCheckPoint.PNNRITEM)
            objParam.Add("PSCUSCRT", obeCheckPoint.PSCUSCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_ELIMINAR_BITACORA_ITEM_OC", objParam)
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
    Public Function InsertarCheckPointXItemDeOc(ByVal obeCheckpoint As beBitacora) As Integer
        Dim lobjParams As New Parameter
        Dim objSql As New SqlManager
        Try
            lobjParams.Add("PNCCLNT", obeCheckpoint.PNCCLNT)
            lobjParams.Add("PSNORCML", obeCheckpoint.PSNORCML)
            lobjParams.Add("PNNRITOC", obeCheckpoint.PNNRITOC)
            lobjParams.Add("PNNESTDO", obeCheckpoint.PNNESTDO)
            lobjParams.Add("PNFESEST", obeCheckpoint.PNFESEST)
            lobjParams.Add("PNFRETES", obeCheckpoint.PNFRETES)
            lobjParams.Add("PSTOBEST", obeCheckpoint.PSTOBEST)
            lobjParams.Add("PSCUSCRT", obeCheckpoint.PSCUSCRT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_CHECKPOINT_X_ITEMS_DE_OC_INSERT", lobjParams)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region



    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidad.beBitacora)

    End Sub
End Class
