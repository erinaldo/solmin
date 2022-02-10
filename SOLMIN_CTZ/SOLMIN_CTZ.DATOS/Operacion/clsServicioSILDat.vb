Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

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
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_SERVICIOS_X_CLIENTE", lobjParams)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Lista_Servicios_x_Operacion(ByVal oServicioSIL As ServicioSIL) As DataTable
        Try
            Dim dt As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
            lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
            lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
            lobjParams.Add("PSNOPRCN", oServicioSIL.NOPRCN)
            dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_SERVICIOS_X_OPERACION", lobjParams)
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

            oDt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_AGREGAR_SERVICIO_SIL", lobjParams)
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

    Public Function Lista_Detalle_Servicios_SIL(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_DETALLE_SERVICIOS_SIL", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_Servicios_Almacen(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("PNNOPRCN", oServicioSIL.NOPRCN)
        lobjParams.Add("PNNRTFSV", oServicioSIL.NRTFSV)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_DETALLE_SERVICIOS_ALMACEN", lobjParams)
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

    Public Function Lista_Tarifa_Servicios_Cliente(ByVal oServicioSIL As ServicioSIL) As DataTable
        'ByVal pstrComp As String, ByVal pstrDiv As String, ByVal pstrPlt As String, ByVal pdblCliente As Double, ByVal pdblFecSer As Double
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", oServicioSIL.CCMPN)
        lobjParams.Add("PSCDVSN", oServicioSIL.CDVSN)
        lobjParams.Add("PNCPLNDV", oServicioSIL.CPLNDV)
        lobjParams.Add("PNCCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("PNFECSER", oServicioSIL.FECSER)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLCT_LISTA_TARIFA_SERVICIO_CLIENTE_X_DIVISION", lobjParams)
        Return dt
    End Function
    Public Function Lista_OC_X_Embarque_OS(ByVal dblCliente As Double, ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", dblCliente)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLSC_LISTA_OC_X_EMBARQUE_OS", lobjParams)
        Return dt
    End Function
    Public Function Listar_TablaAyuda_L01(ByVal strCategoria As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CODVAR", strCategoria)
        Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_TBLAYU_RZO103_L01", lobjParams)
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function
    Public Function Lista_Servicio_Almacen_Modificar(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCMPN", oServicioSIL.CCMPN)
        lobjParams.Add("IN_CDVSN", oServicioSIL.CDVSN)
        lobjParams.Add("IN_CCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("IN_NOPRCN", oServicioSIL.NOPRCN)
        Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_SERVICIOS_ALMACEN", lobjParams)
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function

    Public Function Lista_Bultos_Servicio_Almacen_Modificar(ByVal oServicioSIL As ServicioSIL) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCLNT", oServicioSIL.CCLNT)
        lobjParams.Add("IN_NOPRCN", oServicioSIL.NOPRCN)
        lobjParams.Add("IN_CCMPN", oServicioSIL.CCMPN)
        lobjParams.Add("IN_CDVSN", oServicioSIL.CDVSN)
        lobjParams.Add("IN_CPLNDV", oServicioSIL.CPLNDV)
        Try
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_SERVICIOS_DETALLE_BULTOS", lobjParams)
        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function
    Public Function AgregarDetalleServicio(ByVal DetalleServicio As ServicioAlmacen) As Boolean
        Dim blnResultado As Boolean = True
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        With lobjParams
            .Add("IN_CCLNT", DetalleServicio.CCLNT)
            .Add("IN_NOPRCN", DetalleServicio.NOPRCN)
            .Add("IN_STPODP", DetalleServicio.TIPOALM)
            .Add("IN_CREFFW", DetalleServicio.CREFFW)
            .Add("IN_NROPLT", DetalleServicio.NROPLT)
            .Add("IN_NROCTL", DetalleServicio.NROCTL)
            .Add("IN_NRGUSA", DetalleServicio.NRGUSA)
            .Add("IN_NGUIRM", DetalleServicio.NGUIRM)
            .Add("IN_NORDSR", 0) 'DetalleServicio.NORDSR
            .Add("IN_NSLCSR", 0) 'DetalleServicio.NSLCSR
            .Add("IN_NGUIRN", 0) 'DetalleServicio.NGUIRN
            .Add("IN_USUARI", ConfigurationWizard.UserName)
            .Add("IN_CCMPN", DetalleServicio.CCMPN)
            .Add("IN_CDVSN", DetalleServicio.CDVSN)
            .Add("IN_CPLNDV", DetalleServicio.CPLNDV)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
            Dim strMensajeError As String = ""
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS", lobjParams)
            Dim htResultado As Hashtable
            htResultado = lobjSql.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
            strMensajeError = strMensajeError.Replace("%", vbNewLine)
            If strMensajeError <> "" Then blnResultado = False
        End With
        Return blnResultado
    End Function
    Public Function fdtServicios_Detalle_L02(ByVal TD_Filtro As ServicioAlmacen) As DataTable
        Dim dtTemp As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        ' Ingresamos los parametros del Procedure
        With lobjParams
            .Add("IN_CCLNT", TD_Filtro.CCLNT)
            .Add("IN_NOPRCN", TD_Filtro.NOPRCN)
            .Add("IN_CREFFW", TD_Filtro.CREFFW)
            .Add("IN_NROPLT", TD_Filtro.NROPLT)
            .Add("IN_NROCTL", TD_Filtro.NROCTL)
            .Add("IN_NRGUSA", TD_Filtro.NRGUSA)
            .Add("IN_NGUIRM", TD_Filtro.NGUIRM)
            .Add("IN_CCMPN", TD_Filtro.CCMPN)
            .Add("IN_CDVSN", TD_Filtro.CDVSN)
            .Add("IN_CPLNDV", TD_Filtro.CPLNDV)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            dtTemp = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02", lobjParams)
            Dim htResultado As Hashtable
            htResultado = lobjSql.ParameterCollection
            Dim strMensajeError As String = htResultado("OU_MSGERR")
        Catch ex As Exception
            dtTemp = New DataTable
        End Try
        Return dtTemp
    End Function

    Public Function AgregarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen, ByVal intOperacion As Int64) As Boolean
        Dim dtTemp As DataTable = Nothing
        Dim blnResultado As Boolean = True
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Ingresamos los parametros del Procedure
        With lobjParams
            .Add("IN_CCLNT", oServAlm.CCLNT)
            .Add("IN_NOPRCN", oServAlm.NOPRCN)
            .Add("IN_NRTFSV", oServAlm.NRTFSV)
            .Add("IN_FOPRCN", oServAlm.FOPRCN)
            .Add("IN_FECINI", oServAlm.FECINI)
            .Add("IN_FECFIN", oServAlm.FECFIN)
            .Add("IN_CCMPN", oServAlm.CCMPN)
            .Add("IN_CDVSN", oServAlm.CDVSN)
            .Add("IN_CPLNDV", oServAlm.CPLNDV)
            .Add("IN_QCNESP", oServAlm.QCNESP)
            .Add("IN_TUNDIT", oServAlm.TUNDIT)
            .Add("IN_STPODP", oServAlm.TIPOALM)
            .Add("IN_STIPPR", oServAlm.TIPO)
            .Add("IN_CCLNFC", oServAlm.CCLNFC)
            .Add("IN_QATNAN", oServAlm.QATNAN)
            .Add("IN_CPRCN1", oServAlm.CPRCN1)
            .Add("IN_NSRCN1", oServAlm.NSRCN1)
            .Add("IN_USUARI", ConfigurationWizard.UserName)
            .Add("OU_NOPRCN", "", ParameterDirection.Output)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_RZSC30_INS", lobjParams)
            Dim htResultado As Hashtable
            htResultado = lobjSql.ParameterCollection
            Dim strMensajeError As String = htResultado("OU_MSGERR")
            intOperacion = htResultado("OU_NOPRCN")
            oServAlm.NOPRCN = intOperacion
        Catch ex As Exception
            blnResultado = False
            intOperacion = 0
            oServAlm.NOPRCN = intOperacion
        End Try
        Return blnResultado
    End Function
    Public Function EditarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen) As Boolean
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim dtTemp As DataTable = Nothing
        Dim blnResultado As Boolean = True
        Dim strMensajeError As String = ""
        ' Ingresamos los parametros del Procedure
        With lobjParams
            .Add("IN_CCLNT", oServAlm.CCLNT)
            .Add("IN_NOPRCN", oServAlm.NOPRCN)
            .Add("IN_STIPPR", oServAlm.TIPO)
            .Add("IN_CCLNFC", oServAlm.CCLNFC)
            .Add("IN_FECINI", oServAlm.FECINI)
            .Add("IN_FECFIN", oServAlm.FECFIN)
            .Add("IN_CPRCN1", oServAlm.CPRCN1)
            .Add("IN_NSRCN1", oServAlm.NSRCN1)
            .Add("IN_USUARI", ConfigurationWizard.UserName)
            .Add("OU_MSGERR", "", ParameterDirection.Output)
        End With
        Try
            lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD", lobjParams)
            Dim htResultado As Hashtable
            htResultado = lobjSql.ParameterCollection
            strMensajeError = htResultado("OU_MSGERR")
        Catch ex As Exception
            blnResultado = False
            strMensajeError = "Error producido en la funcion : << EditarServicioAdquirido >> de la clase << daoServicio >> " & vbNewLine & _
                              "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD >> " & vbNewLine & _
                              "Motivo del Error : " & ex.Message
        End Try
        Return blnResultado
    End Function
    Public Function EliminarServicioAdquiridoSA(ByVal oServAlm As ServicioAlmacen) As Boolean
        Return True
    End Function
    Public Function EliminarDetalleServicioSA(ByVal oServAlm As ServicioAlmacen) As Boolean
        Return True
    End Function
End Class
