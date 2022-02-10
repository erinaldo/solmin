Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsPlanta
    Public Function Lista_Planta_X_Usuario() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_PLANTA_X_USUARIO", lobjParams)
        Return dt
    End Function

    Public Function Listar_Planta_X_Compania(ByVal ccmpn As String, ByVal cdvsn As String) As DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
        Dim output As New DataTable
        Try
            Dim sqlManager As New SqlManager
            Dim parameter As New Parameter

            parameter.Add("PSCCMPN", ccmpn)
            parameter.Add("PSCDVSN", cdvsn)
            sqlManager.DefaultSchema = Autenticacion_DAL.GetLibrary(ccmpn)
            output = sqlManager.ExecuteDataTable("SP_SOLCT_LISTA_PLANTA_X_COMPANIA_DIV", parameter)

        Catch ex As Exception
            Return Nothing
        End Try

        Return output
    End Function


    Public Function Lista_Planta() As List(Of bePlanta)

        Dim output As New List(Of bePlanta)
        Dim dt As New DataTable
        Dim sqlManager As New SqlManager
        Dim parameter As New Parameter
        dt = sqlManager.ExecuteDataTable("SP_SOLMIN_CT_LISTA_PLANTAS_TODOS", parameter)



        Dim entidad As bePlanta
        For Each dr As DataRow In dt.Rows
            entidad = New bePlanta
            entidad.Cplndv = dr("CPLNDV")
            entidad.Tplnta = dr("TPLNTA")
            output.Add(entidad)
        Next


        Return output
    End Function
End Class

