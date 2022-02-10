Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsSegNotificacion

    Private objSql As New SqlManager

    Public Function ListarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeSegNotificacion.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeSegNotificacion.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PSCODFMT", obeSegNotificacion.PSCODFMT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_PROCESO_NOTIFICACION_X_CLIENTE", lobjParams)
        Return dt
    End Function

    Public Function RegistrarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As String

        Dim lobjParams As New Parameter
        Dim msg As String = ""
        Dim PSMENSAJE As String = ""
        lobjParams.Add("PSCCMPN", obeSegNotificacion.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeSegNotificacion.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        lobjParams.Add("PSMENSAJE", "", ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_PROCESO_NOTIFICACION_X_CLIENTE", lobjParams)
        msg = objSql.ParameterCollection("PSMENSAJE")
        Return msg
    End Function

    Public Sub EliminarClienteProcesoNotificacion(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCOCNTF", obeSegNotificacion.PNCOCNTF)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_PROCESO_NOTIFICACION_X_CLIENTE", lobjParams)
    End Sub

    Public Sub ActualizarFormatoProcesoNotificacionXCliente(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCOCNTF", obeSegNotificacion.PNCOCNTF)
        lobjParams.Add("PSCODFMT", obeSegNotificacion.PSCODFMT)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_FORMATO_PROCESO_NOTIFICACION_X_CLIENTE", lobjParams)
    End Sub

    Public Function ListarCheckPointsNotificacion(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeSegNotificacion.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeSegNotificacion.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_CHECKPOINTS_NOTIFICACION_EMAIL", lobjParams)
        Return dt
    End Function

    Public Function RegistarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion) As String
        Dim lobjParams As New Parameter
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obeSegNotificacion.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeSegNotificacion.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PSCODFMT", obeSegNotificacion.PSCODFMT)
        lobjParams.Add("PNNESTDO", obeSegNotificacion.PNNESTDO)
        lobjParams.Add("PSTCOLUM", obeSegNotificacion.PSTCOLUM)
        lobjParams.Add("PNNSEPRE", obeSegNotificacion.PNNSEPRE)
        lobjParams.Add("PSCFMCHK", obeSegNotificacion.PSCFMCHK)
        lobjParams.Add("PSFLGEST", obeSegNotificacion.PSFLGEST)
        lobjParams.Add("PSFLGNTE", obeSegNotificacion.PSFLGNTE)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        lobjParams.Add("PSMENSAJE", "", ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_CHECKPOINTS_NOTIFICACION_EMAIL", lobjParams)
        msg = objSql.ParameterCollection("PSMENSAJE")
        Return msg
    End Function

    Public Sub ModificarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCFCHK", obeSegNotificacion.PNCFCHK)
        lobjParams.Add("PSTCOLUM", obeSegNotificacion.PSTCOLUM)
        lobjParams.Add("PNNSEPRE", obeSegNotificacion.PNNSEPRE)
        lobjParams.Add("PSCFMCHK", obeSegNotificacion.PSCFMCHK)
        lobjParams.Add("PSFLGEST", obeSegNotificacion.PSFLGEST)
        lobjParams.Add("PSFLGNTE", obeSegNotificacion.PSFLGNTE)
        lobjParams.Add("PSCULUSA ", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_MODIFICAR_CHECKPOINTS_NOTIFICACION_EMAIL", lobjParams)
    End Sub
 
    Public Sub EliminarCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCFCHK", obeSegNotificacion.PNCFCHK)
        lobjParams.Add("PSCULUSA ", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_CHECKPOINTS_NOTIFICACION_EMAIL", lobjParams)
    End Sub

    Public Sub ActualizarOrdenCheckPointsNotificacionEmail(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCFCHK", obeSegNotificacion.PNCFCHK)
        lobjParams.Add("PNNSEPRE", obeSegNotificacion.PNNSEPRE)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_ORDEN_CHECKPOINTS_NOTIFICACION_EMAIL", lobjParams)
    End Sub



    Public Function ListarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTAR_EMAIL_DESTINATARIO_X_TIPO", lobjParams)
        Return dt
    End Function

    Public Sub RregistrarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PSEMAILTO", obeSegNotificacion.PSEMAILTO)
        lobjParams.Add("PSTNMYAP", obeSegNotificacion.PSTNMYAP)
        lobjParams.Add("PSTIPPROC", obeSegNotificacion.PSTIPPROC)
        lobjParams.Add("PSCULUSA ", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_REGISTRAR_EMAIL_DESTINATARIO_X_TIPO", lobjParams)
    End Sub

    Public Sub ActualizarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PNNCRRIT", obeSegNotificacion.PNNCRRIT)
        lobjParams.Add("PSEMAILTO", obeSegNotificacion.PSEMAILTO)
        lobjParams.Add("PSTNMYAP", obeSegNotificacion.PSTNMYAP)
        lobjParams.Add("PSTIPPROC", obeSegNotificacion.PSTIPPROC)
        lobjParams.Add("PSCULUSA", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_EMAIL_DESTINATARIO_X_TIPO", lobjParams)
    End Sub

    Public Sub EliminarEmailDestinatarioXTipo(ByVal obeSegNotificacion As beSegNotificacion)
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeSegNotificacion.PNCCLNT)
        lobjParams.Add("PSNLTECL", obeSegNotificacion.PSNLTECL)
        lobjParams.Add("PNNCRRIT", obeSegNotificacion.PNNCRRIT)
        lobjParams.Add("PSCULUSA ", obeSegNotificacion.PSCULUSA)
        objSql.ExecuteNonQuery("SP_SOLSC_ELIMINAR_EMAIL_DESTINATARIO_X_TIPO", lobjParams)
    End Sub


End Class
