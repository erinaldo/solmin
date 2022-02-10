Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsServicioSILDat

    Public Sub Agregar_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSTIPO", pobjServicioSIL.TIPO)
            lobjParams.Add("PNCCLNT", pobjServicioSIL.CCLNT)
            lobjParams.Add("PNCCLNFC", pobjServicioSIL.CCLNFC)
            lobjParams.Add("PNNRTFSV", pobjServicioSIL.NRTFSV)
            lobjParams.Add("PSCCMPN", pobjServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", pobjServicioSIL.CDVSN)
            lobjParams.Add("PNQATNAN", pobjServicioSIL.QATNAN)
            lobjParams.Add("PNFECINI", pobjServicioSIL.FECINI)
            lobjParams.Add("PNFECFIN", pobjServicioSIL.FECFIN)
            lobjParams.Add("PSTOBS", pobjServicioSIL.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_AGREGAR_SERVICIO_SIL", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Agregar_Detalle_Servicio(ByVal pobjServicioSILDet As ServicioSILDet)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjServicioSILDet.NOPRCN)
            lobjParams.Add("PNNRPEMB", pobjServicioSILDet.NRPEMB)
            lobjParams.Add("PNCCLNT", pobjServicioSILDet.CCLNT)
            lobjParams.Add("PSNORCML", pobjServicioSILDet.NORCML)
            lobjParams.Add("PNNRPARC", pobjServicioSILDet.NRPARC)
            lobjParams.Add("PNNRITOC", pobjServicioSILDet.NRITOC)
            lobjParams.Add("PNQRLCSC", pobjServicioSILDet.QRLCSC)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_AGREGAR_SERVICIO_SIL_DETALLE", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Servicio_X_Embarque(ByVal pdblCli As Double, ByVal pdblEmbarque As Double, ByVal pstrCompania As String, ByVal pstrDivision As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSCCMPN", pstrCompania)
        lobjParams.Add("PSCDVSN", pstrDivision)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_SERVICIO_X_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Sub Actualiza_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)
            lobjParams.Add("PNCCLNT", pobjServicioSIL.CCLNT)
            lobjParams.Add("PNCCLNFC", pobjServicioSIL.CCLNFC)
            lobjParams.Add("PNNRTFSV", pobjServicioSIL.NRTFSV)
            lobjParams.Add("PSCCMPN", pobjServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", pobjServicioSIL.CDVSN)
            lobjParams.Add("PNQATNAN", pobjServicioSIL.QATNAN)
            lobjParams.Add("PNFECINI", pobjServicioSIL.FECINI)
            lobjParams.Add("PNFECFIN", pobjServicioSIL.FECFIN)
            lobjParams.Add("PSTOBS", pobjServicioSIL.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_ACT_SERVICIO_SIL", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Quitar_Servicio(ByVal pobjServicioSIL As ServicioSIL)
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PNNOPRCN", pobjServicioSIL.NOPRCN)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_QUITAR_SERVICIO_SIL", lobjParams)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Servicios_x_Cliente(ByVal oServicioSIL As ServicioSIL) As DataTable
        Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNFECINI", oServicioSIL.FECINI)
            lobjParams.Add("PNFECFIN", oServicioSIL.FECFIN)
            lobjParams.Add("PSFLGFAC", oServicioSIL.FLGFAC)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_SERVICIOS_X_CLIENTE", lobjParams)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function Guardar_Servicios_Atendidos(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim oDt As DataTable
        Try

            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)
            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNCCLNFC", oServicioSIL.CCLNFC)
            lobjParams.Add("PNQATNAN", oServicioSIL.QATNAN)
            lobjParams.Add("PNFOPRCN", oServicioSIL.FOPRCN)
            lobjParams.Add("PNFECINI", oServicioSIL.FECINI)
            lobjParams.Add("PNFECFIN", oServicioSIL.FECFIN)
            lobjParams.Add("PSTOBS", oServicioSIL.TOBS)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))

            oDt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_AGREGAR_SERVICIO_SIL", lobjParams)
            Return oDt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub Guardar_Detalle_Servicios_SIL(ByVal oServicioSIL As ServicioSIL)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Try
            lobjParams.Add("PSTIPO", oServicioSIL.TIPO)
            lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)
            lobjParams.Add("PNNORSCI", oServicioSIL.NORSCI)
            lobjParams.Add("PSNORCML", oServicioSIL.NORCML)
            lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
            lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
            lobjParams.Add("PNHORA", Format(Now, "HHmmss"))

            lobjSql.ExecuteNonQuery(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_GUARDAR_DETALLE_SERVICIOS_SIL", lobjParams)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function Lista_Detalle_Servicios_SIL(ByVal pdblCliente As Double, ByVal pdblOperacion As Double, ByVal pdblTarifaServicio As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNNOPRCN", pdblOperacion)
        lobjParams.Add("PNNRTFSV", pdblTarifaServicio)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_DETALLE_SERVICIOS_SIL", lobjParams)
        Return dt
    End Function

    Public Function Verificar_Servicios_Atendidos(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_VERIFICA_SERVICIO_FACTURADO", lobjParams)
        Return dt
    End Function

End Class
