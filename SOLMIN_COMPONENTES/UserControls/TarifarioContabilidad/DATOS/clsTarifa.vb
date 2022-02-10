Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTarifa
    Public Function Lista_Tarifa_X_Contrato(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_CONTRATO", lobjParams)
        Return dt
    End Function

    Public Sub Eliminar_Tarifa(ByVal pobjTarifa As Tarifa)
        Try
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager

            lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery("SP_SOLCT_ELIMINAR_TARIFA", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Crear_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
            lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
            lobjParams.Add("PNCMNDA1", pobjTarifa.CMNDA1)
            lobjParams.Add("PSDESRNG", pobjRango.DESRNG)
            lobjParams.Add("PSTOBS", pobjTarifa.TOBS)
            lobjParams.Add("PNIVLSRV", pobjTarifa.IVLSRV)
            lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
            lobjParams.Add("PSCUNDMD", pobjRango.CUNDMD)
            lobjParams.Add("PNVALMAX", pobjRango.VALMAX)
            lobjParams.Add("PNVALMIN", pobjRango.VALMIN)
            lobjParams.Add("PNVALCTE", pobjRango.VALCTE)
            lobjParams.Add("PSSTPTRA", pobjRango.STPTRA)
            lobjParams.Add("PSDESTAR", pobjTarifa.DESTAR)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            oSqlMan.ExecuteNonQuery("SP_SOLCT_CREAR_TARIFA", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Tarifa(ByRef oSqlMan As SqlManager, ByVal pobjTarifa As Tarifa, ByVal pobjRango As Rango)
        Try
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNRTFSV", pobjTarifa.NRTFSV)
            lobjParams.Add("PNNRRNGO", pobjTarifa.NRRNGO)
            lobjParams.Add("PNNRCTSL", pobjTarifa.NRCTSL)
            lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
            lobjParams.Add("PNCMNDA1", pobjTarifa.CMNDA1)
            lobjParams.Add("PSTOBS", pobjTarifa.TOBS)
            lobjParams.Add("PNIVLSRV", pobjTarifa.IVLSRV)
            lobjParams.Add("PNCPLNDV", pobjTarifa.CPLNDV)
            lobjParams.Add("PSCUNDMD", pobjRango.CUNDMD)
            lobjParams.Add("PSDESRNG", pobjRango.DESRNG)
            lobjParams.Add("PNVALMAX", pobjRango.VALMAX)
            lobjParams.Add("PNVALMIN", pobjRango.VALMIN)
            lobjParams.Add("PNVALCTE", pobjRango.VALCTE)
            lobjParams.Add("PSSTPTRA", pobjRango.STPTRA)
            lobjParams.Add("PSDESTAR", pobjTarifa.DESTAR)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            oSqlMan.ExecuteNonQuery("SP_SOLCT_ACTUALIZAR_TARIFA", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Tarifa_Servicio(ByVal pobjTarifa As Tarifa) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", pobjTarifa.CCMPN)
        lobjParams.Add("PSCDVSN", pobjTarifa.CDVSN)
        lobjParams.Add("PNNRSRRB", pobjTarifa.NRSRRB)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_TARIFA_X_SERVICIO", lobjParams)
        Return dt
    End Function
End Class

