Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsDestMailValorizacion

#Region "Lista Correo Valorizacion"

    'Public Function ListarCorreoValorizacion(ByVal oCorreoValorizacion As beCorreoValorizacion) As List(Of beCorreoValorizacion)
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim oListCorreoValorizacion As New List(Of beCorreoValorizacion)
    '    Dim obeCorreoValorizacion As beCorreoValorizacion
    '    Dim dt As New DataTable

    '    lobjParams.Add("PNCCLNT", oCorreoValorizacion.CCLNT)
    '    lobjParams.Add("PSPPROC", oCorreoValorizacion.NLTECL)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_DESTINATARIO_X_CLIENTE", lobjParams)
    '    For Each item As DataRow In dt.Rows
    '        obeCorreoValorizacion = New beCorreoValorizacion
    '        obeCorreoValorizacion.NCRRIT = item("NCRRIT")
    '        obeCorreoValorizacion.TNMYAP = item("NOMBRE")
    '        oListCorreoValorizacion.Add(obeCorreoValorizacion)
    '    Next
    '    Return oListCorreoValorizacion
    'End Function
    Public Function ListarCorreoValorizacion(ByVal oCorreoValorizacion As beCorreoValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
      
        Dim dt As New DataTable

        lobjParams.Add("PNCCLNT", oCorreoValorizacion.CCLNT)
        lobjParams.Add("PSPPROC", oCorreoValorizacion.NLTECL)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DESTINATARIO_X_CLIENTE", lobjParams)
       
        Return dt
    End Function
 
#End Region


#Region "Operaciones"
    Public Function InsertarCorreo_Valorizacion(ByVal oCorreoValorizacion As beCorreoValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNCCLNT", CType(oCorreoValorizacion.CCLNT, Double))
        lobjParams.Add("PSPROCESO", oCorreoValorizacion.NLTECL)
        lobjParams.Add("PSEMAILTO", oCorreoValorizacion.EMAILTO)
        lobjParams.Add("PSTNMYAP", oCorreoValorizacion.TNMYAP)
        lobjParams.Add("PSEMAILCC", oCorreoValorizacion.EMAILCC)
        lobjParams.Add("PSEMAILBC", oCorreoValorizacion.EMAILBC)
        lobjParams.Add("PSTIPPROC", oCorreoValorizacion.TIPPROC)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_DESTINATARIO_X_CLIENTE", lobjParams)
        Return dt

      

    End Function

    Public Function ActualizaCorreoValorizacion(ByVal oCorreoValorizacion As beCorreoValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNCCLNT", CType(oCorreoValorizacion.CCLNT, Double))
        lobjParams.Add("PSPROCESO", oCorreoValorizacion.NLTECL)

        lobjParams.Add("PNNCRRIT", CType(oCorreoValorizacion.NCRRIT, Double))
        lobjParams.Add("PSEMAILTO", oCorreoValorizacion.EMAILTO)

        lobjParams.Add("PSTNMYAP", oCorreoValorizacion.TNMYAP)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
       
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ACTUALIZAR_DESTINATARIO_X_CLIENTE", lobjParams)

        Return dt

      

    End Function

    Public Sub EliminarCorreo_Valorizacion(ByVal oCorreoValorizacion As beCorreoValorizacion)
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNCCLNT", CType(oCorreoValorizacion.CCLNT, Double))
        lobjParams.Add("PSPROCESO", oCorreoValorizacion.NLTECL)
        lobjParams.Add("PNNCRRIT", CType(oCorreoValorizacion.NCRRIT, Double))
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
       
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_ELIMINAR_DESTINATARIO_X_CLIENTE", lobjParams)


    End Sub

#End Region

End Class
