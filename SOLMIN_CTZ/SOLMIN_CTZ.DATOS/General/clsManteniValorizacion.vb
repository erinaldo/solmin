Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Imports Newtonsoft
Imports Newtonsoft.Json

Public Class clsManteniValorizacion

#Region "Lista Mantenimiento Valorizacion"
    Public Function ListarManteniValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataSet
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim ds As New DataSet

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
        lobjParams.Add("PSSEGVLR", obeMantValorizacion.SEGVLR) 'ESTADO VALORIZACION
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
        lobjParams.Add("PSDOCVLR", obeMantValorizacion.DOCVLR) 'DOCVALORIZACION
        lobjParams.Add("PNFCHVLR_INI", obeMantValorizacion.FCHINI) 'FECHA INICIO VALORIZACION
        lobjParams.Add("PNFCHVLR_FIN", obeMantValorizacion.FCHFIN) 'FECHA FIN VALORIZACION
        'ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTAR_VALORIZACION", lobjParams)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTAR_VALORIZACION_V2", lobjParams)
        For Each item As DataRow In ds.Tables(0).Rows
            item("FCHVLR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHVLR"))
        Next



        Return ds


    End Function


    'Public Function ListarOPxValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
    '    lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
    '    lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DET_OP_X_VALORIZACION", lobjParams)
    '    Return dt

    'End Function

    Public Function ListarOPxEnvioValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
        lobjParams.Add("PSDOCVLR", obeMantValorizacion.NROSGV)  'DOCVALORIZACION
        lobjParams.Add("PSFLGDSG", obeMantValorizacion.DOCGENERADO)  'DOCVALORIZACION
        lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DET_OP_X_NRO_SEG_VALORIZ", lobjParams)
        Return dt

    End Function

    Public Function ListarOperPendientesValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
        lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN) 'DIVISION
        lobjParams.Add("PSCPLNDV", obeMantValorizacion.CPLNDV) 'PLANTA
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
        lobjParams.Add("PNNOPRCN", obeMantValorizacion.NOPRCN) 'CLIENTE

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_OP_PENDIENTES_VALORIZACION", lobjParams)
        Return dt

    End Function



#End Region

#Region "Operaciones"
  




    Public Function RegistrarEnvioValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDE", obeMantValorizacion.NCRRDE)

        lobjParams.Add("PNFCHASG", obeMantValorizacion.FCHASG)
        lobjParams.Add("PNHRAASG", obeMantValorizacion.HRAASG)

        lobjParams.Add("PSDESTAP", obeMantValorizacion.DESTAP)
        lobjParams.Add("PSARADST", obeMantValorizacion.ARADST)
        lobjParams.Add("PSTOBS", obeMantValorizacion.TOBS)

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_ENVIO_DOCUMENTO_VALORIZACION", lobjParams)

        Return dt



    End Function

    Public Function RegistrarAprobacionValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim msg As String = ""
        Dim sStatus As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDT", obeMantValorizacion.NCRRDE)

        lobjParams.Add("PNFCHAPR", obeMantValorizacion.FCHAPR)
        lobjParams.Add("PNHRAAPR", obeMantValorizacion.HRAAPR)
        lobjParams.Add("PSTOBSER", obeMantValorizacion.TOBSER)

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        lobjParams.Add("PSFLGAPR", obeMantValorizacion.FLGAPR)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_APROBACION_DOCUMENTO_VALORIZACION", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                msg = msg & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If

        Next


        Return msg



    End Function
    Public Function Anular_MantValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PSMOTAVL", "")

        lobjParams.Add("PSOBSAVL", obeMantValorizacion.OBSAVL)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_VALORIZACION", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If

        Next
        sErrorMesage = sErrorMesage.Trim

        Return sErrorMesage


    End Function

    Public Function AdicionarOper_MantValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_DESTINATARIO_X_CLIENTE", lobjParams)
        Return dt

    End Function

    Public Function EliminarOper_MantValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNOPRCN", obeMantValorizacion.NOPRCN)
        lobjParams.Add("PNNSECFC", obeMantValorizacion.NSECFC)
        lobjParams.Add("PSTPOPER", obeMantValorizacion.TPOPER)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ELIMINAR_OP_DETALLE_VALORIZACION", lobjParams)



        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim

        Return sErrorMesage

    End Function


    Public Function EliminarOper_MantValorizacion_Op_List(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSNOPRCN", obeMantValorizacion.NOPRCN_LIST)

        lobjParams.Add("PNNSECFC", obeMantValorizacion.NSECFC)
        lobjParams.Add("PSTPOPER", obeMantValorizacion.TPOPER)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ELIMINAR_OP_DETALLE_VALORIZACION_LIST", lobjParams)



        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim

        Return sErrorMesage

    End Function


    Public Function RegistrarValorizacionCabecera(ByRef NROVLR As Decimal, ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PNCNFCVL", obeMantValorizacion.CNFCVL)
        lobjParams.Add("PSDOCVLR", obeMantValorizacion.DOCVLR)
        lobjParams.Add("PSREFCNT", obeMantValorizacion.REFCNT)

        lobjParams.Add("PNQDAPVL", obeMantValorizacion.QDAPVL)

        lobjParams.Add("PSTPOVLR", obeMantValorizacion.TPOVLR)

        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_VALORIZACION", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim
        If sErrorMesage.Length = 0 Then
            NROVLR = dt.Rows(0)("NROVLR")
        End If

        Return sErrorMesage
    End Function

    Public Sub InsertaDetalleOperValorizacionPendiente(ByVal obeMantValorizacion As beMantValorizacion)
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSTPOPER", obeMantValorizacion.TPOPER)

        lobjParams.Add("PNNOPRCN", obeMantValorizacion.NOPRCN)
        lobjParams.Add("PNNSECFC", obeMantValorizacion.NSECFC)
        '
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN)

        lobjParams.Add("PNCPLNDV", obeMantValorizacion.CPLNDV)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)


        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REGISTRAR_OPERACION_VALORIZACION", lobjParams)
    End Sub

    'GenerarDocValorizacion


    Public Function GenerarDocValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sErrorMesage As String = ""
        Dim sStatus As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PSNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        'lobjParams.Add("PSACCION", obeMantValorizacion.ACCION)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_GENERAR_DOCUMENTO_VALORIZACION", lobjParams)



        Return dt
    End Function


    Public Sub InsertaDetalleDocValorizacion(ByVal obeMantValorizacion As beMantValorizacion)
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSTPOPER", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNOPRCN", obeMantValorizacion.NOPRCN)


        lobjParams.Add("PNNCRROP", obeMantValorizacion.NCRROP)
        lobjParams.Add("PNNGUITR", obeMantValorizacion.NGUITR)
        lobjParams.Add("PNNCRRGU", obeMantValorizacion.NCRRGU)
        lobjParams.Add("PNSESTOP", obeMantValorizacion.SESTOP)
        lobjParams.Add("PNNLQDCN", obeMantValorizacion.NLQDCN)


        lobjParams.Add("PNNSECFC", obeMantValorizacion.NSECFC)
        lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN)
        lobjParams.Add("PNCPLNDV", obeMantValorizacion.CPLNDV)
        lobjParams.Add("PNCSRVC", obeMantValorizacion.CSRVC)
        lobjParams.Add("PNCMNDA1", obeMantValorizacion.CMNDA1)


        lobjParams.Add("PNQATNAN", obeMantValorizacion.QATNAN)
        lobjParams.Add("PNIVLSRV", obeMantValorizacion.IVLSRV)
        lobjParams.Add("PNITPCMT", obeMantValorizacion.ITPCMT)
        lobjParams.Add("PNIVLDCS", obeMantValorizacion.QATNAN * obeMantValorizacion.IVLSRV)
        lobjParams.Add("PNIVLDCD", obeMantValorizacion.QATNAN * obeMantValorizacion.ITPCMT)

        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)




        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_REGISTRAR_OPERACION_VALORIZACION", lobjParams)
    End Sub

    Public Function ValidarGeneracionEnvio(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDE", obeMantValorizacion.NCRRDE)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_NUEVO_ENVIO", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim

        Return sErrorMesage
    End Function

    Public Function ListarEnvioValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDE", obeMantValorizacion.NCRRDE)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_ENVIO_VALORIZACION", lobjParams)
        Return dt
    End Function


    Public Function ListarEnvioxDocSEg(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV) 'NROVALORIZACION
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_ENVIOS_X_DOC_SEGUIMIENTO", lobjParams)
        For Each item As DataRow In dt.Rows
            item("FCHASG") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHASG")) & " " & Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HRAASG"))
            item("FCHAPR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCHAPR")) & " " & Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HRAAPR"))
            item("USU_REG_ENVIO") = item("USU_REG_ENVIO") & " " & Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_REG_ENVIO")) & " " & Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HRA_REG_ENVIO"))
            item("USU_REG_APROB") = item("USU_REG_APROB") & " " & Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_REG_APROB")) & " " & Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HRA_REG_APROB"))
        Next

        Return dt

    End Function

    'Public Function ListarDocSeguimiento_x_Valorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
    '    lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
    '    lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV) 'NROVALORIZACION
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_DOC_SEGUIMIENTO_X_VALORIZACION", lobjParams)
    '    Return dt

    'End Function


    Public Function EliminarEnvioxDocSEg(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim cad As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDT", obeMantValorizacion.NCRRDT)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_ENVIOS_X_DOC_SEGUIMIENTO", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                cad = cad & item("OBSRESULT")
            End If
        Next
        cad = cad.Trim
        Return cad
    End Function

    'Public Function EliminarDocumentoSeguimiento(ByVal obeMantValorizacion As beMantValorizacion) As String
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    Dim cad As String = ""
    '    lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
    '    lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
    '    lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
    '    lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_DOC_SEGUIMIENTO", lobjParams)
    '    For Each item As DataRow In dt.Rows
    '        If item("STATUS") = "E" Then
    '            cad = cad & item("OBSRESULT")
    '        End If
    '    Next
    '    cad = cad.Trim
    '    Return cad
    'End Function

    Public Function AnularAprobacionValorizacion(ByVal obeMantValorizacion As beMantValorizacion, ByRef RequiereAutorizacion As Boolean) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim cad As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PNNCRRDT", obeMantValorizacion.NCRRDE)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
        lobjParams.Add("PSAUTORIZADO", obeMantValorizacion.AUTORIZADO)

        Dim estado As String = ""

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_APROBACION_DOCUMENTO_VALORIZACION", lobjParams)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                cad = cad & item("OBSRESULT")
                estado = ("" & item("COD_ESTADO"))
            End If
        Next

        If estado = "RAUTR" Then
            RequiereAutorizacion = True
        Else
            RequiereAutorizacion = False
        End If
        cad = cad.Trim
        Return cad


    End Function


    Public Function AnularAprobacionCliente(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim cad As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)
 
        Dim estado As String = ""
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_APROBACION_CLIENTE", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                cad = cad & item("OBSRESULT")
            End If
        Next
        cad = cad.Trim
        Return cad

    End Function


    'Public Function LiberarDocumentoEnviado(ByVal obeMantValorizacion As beMantValorizacion) As String
    '    Dim cad As String = ""
    '    Dim dt As New DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim sErrorMesage As String = ""
    '    Dim sStatus As String = ""
    '    lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
    '    lobjParams.Add("PSNROVLR", obeMantValorizacion.NROVLR)
    '    lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
    '    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
    '    'dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_NUEVO_ENVIO_DOC", lobjParams)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIBERAR_DOCUMENTO_ENVIO", lobjParams)
    '    For Each item As DataRow In dt.Rows
    '        If item("STATUS") = "E" Then
    '            cad = cad & item("OBSRESULT")
    '        End If
    '    Next
    '    cad = cad.Trim
    '    Return cad
    'End Function

    Public Function LiberarDocumentoGenerado(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim cad As String = ""
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sErrorMesage As String = ""
        Dim sStatus As String = ""
        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PSNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIBERAR_DOCUMENTO_GENERADO", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                cad = cad & item("OBSRESULT")
            End If
        Next
        cad = cad.Trim
        Return cad
    End Function




    Public Function ActualizarValorizacionCabecera(ByVal obeMantValorizacion As beMantValorizacion) As String
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNCNFCVL", obeMantValorizacion.CNFCVL)
        lobjParams.Add("PSDOCVLR", obeMantValorizacion.DOCVLR)
        lobjParams.Add("PSREFCNT", obeMantValorizacion.REFCNT)
        lobjParams.Add("PNQDAPVL", obeMantValorizacion.QDAPVL)
        lobjParams.Add("PSCULUSA", obeMantValorizacion.CULUSA)
        lobjParams.Add("PSNTRMNL", obeMantValorizacion.NTRMNL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ACTUALIZAR_VALORIZACION", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim
     

        Return sErrorMesage
    End Function


    Public Function ListarServicioDetalleValorizacionExport(ByVal obeMantValorizacion As beMantValorizacion) As DataSet
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim ds As New DataSet
        Dim nombre_mes As String = ""

        Dim JsGt As Dictionary(Of String, Object)
        Dim listJsGT As New List(Of Dictionary(Of String, Object))
        Dim listjson As New List(Of String)
        Dim listjsmax As Int64 = 1000
        Dim StrJson As String = ""

        Dim FILA As Int64 = 0



        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_SERVICIOS_DETALLE_VALORIZACION", lobjParams)



        For Each item As DataRow In ds.Tables(0).Rows
            item("FCH_VAL") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_VAL"))
            item("FCH_ENVIO") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_ENVIO"))
            item("HRA_ENVIO") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HRA_ENVIO"))
            item("FCH_APROB") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_APROB"))
            item("HRA_APROB") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HRA_APROB"))

        Next



        ds.Tables(1).Columns.Add("PESO_ALM", Type.GetType("System.Decimal"))
        ds.Tables(1).Columns.Add("ORIGEN_PESO")
       
        Dim GuiaTransp As Decimal = 0
      
        For Each item As DataRow In ds.Tables(1).Rows


            item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
            item("FSLDCM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FSLDCM"))
            item("FLLGCM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLLGCM"))
            item("FGUIRM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FGUIRM"))
            item("FDCPRF") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FDCPRF"))

            item("MESPROV") = "" & item("MESPROV")
            If item("MESPROV") <> "" Then
                nombre_mes = CDate(Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("MESPROV") & "01")).ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"))
                item("MESPROV") = nombre_mes.ToUpper & " - " & item("MESPROV").ToString.Substring(0, 4)
            End If

             
 

        Next


        '' adicionado por calculo de los pesos de bultos según carga de alamcenes
        Dim dtGTDistinct As New DataTable
        FILA = 0
        dtGTDistinct = ds.Tables(1).DefaultView.ToTable(True, "CTRMNC", "NGUITR")
        For Each item As DataRow In dtGTDistinct.Rows
            GuiaTransp = item("NGUITR")
            If GuiaTransp > 0 Then
                JsGt = New Dictionary(Of String, Object)
                FILA = FILA + 1
                JsGt.Add("FL", FILA)
                JsGt.Add("CODT", item("CTRMNC"))
                JsGt.Add("GT", GuiaTransp)
                listJsGT.Add(JsGt)
            End If          
        Next
        StrJson = JsonConvert.SerializeObject(listJsGT)


        Dim dtPesoResumen As New DataTable
        If StrJson.Length > 0 Then
            lobjParams = New Parameter
            lobjParams.Add("PSLISTJSON", StrJson)
            dtPesoResumen = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_CALCULAR_PESOGUIACLIENTE_X_GT_VALORIZACIOM", lobjParams)

            Dim drbusq() As DataRow
            For Each item As DataRow In ds.Tables(1).Rows
                drbusq = dtPesoResumen.Select("CTRMNC='" & item("CTRMNC") & "'  AND NGUIRM='" & item("NGUITR") & "' AND CANT_GRALM>0")
                If drbusq.Length > 0 Then
                    item("PESO_ALM") = drbusq(0)("PSOALMACEN")
                    item("ORIGEN_PESO") = "ALMACEN"

                Else
                    'item("PESO_ALM") = DBNull.Value
                    item("PESO_ALM") = item("PBRTOR")
                    item("ORIGEN_PESO") = "REMISION"
                End If
            Next


        End If



        For Each item As DataRow In ds.Tables(3).Rows
            item("FLQDCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLQDCN"))
            item("FECFAC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FECFAC"))
        Next

        For Each item As DataRow In ds.Tables(5).Rows
            item("FOPRCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FOPRCN"))
            item("FREFFW") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FREFFW"))
            item("FSLFFW") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FSLFFW"))
            item("MESPROV") = "" & item("MESPROV")
            If item("MESPROV") <> "" Then
                nombre_mes = CDate(Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("MESPROV") & "01")).ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"))
                item("MESPROV") = nombre_mes.ToUpper & " - " & item("MESPROV").ToString.Substring(0, 4)
            End If
        Next

        Return ds

    End Function


    'Public Function ListarUsuarioValorizacionAnulacion() As DataTable
    '    Dim dt As New DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_USUARIO_VALORIZACION_APROBADA", lobjParams)
    '    Return dt
    'End Function

    Public Function ListarOPXDivisionValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Dim dv As New DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
        lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN) 'DIVISION
        lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR) 'NROVALORIZACION
        lobjParams.Add("PNNROSGV", obeMantValorizacion.NROSGV)  'DOCVALORIZACION
        dv = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_OP_PENDIENTES_PL_X_DIVSION", lobjParams)
        Return dv
    End Function




    Public Function Listar_Servicios_Valorizacion(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PSCDVSN", Entidad.CDVSN) 'DIVISIÓN
        lobjParams.Add("PNCPLNDV", Entidad.CPLNDV) 'PLANTA
        lobjParams.Add("PNCCLNT", Entidad.CCLNT)  'CLIENTE

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_SERVICIO_TARIFA_RANGO_VLR", lobjParams)
        Return dt

    End Function

    Public Function Adicionar_Operacion_Administrativa(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNCCLNT", Entidad.CCLNT) 'CLIENTE
        lobjParams.Add("PNNOPRSD", Entidad.NOPRSD) 'OPERACION ADM
        'lobjParams.Add("PNNCRROP", Entidad.NCRROP) 'OPERACION ADM

        lobjParams.Add("PNNROVLR", Entidad.NROVLR) 'VALORIZACIÓN
        lobjParams.Add("PNNOPRCN", Entidad.NOPRCN)  'OPERACION
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSTERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OPERACION_ADICIONAR_OP_ADMINSTRATIVA", lobjParams)
        Return dt

    End Function


    Public Function Eliminar_Operacion_Administrativa(ByVal Entidad As beMantValorizacion) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim sStatus As String = ""

        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNCCLNT", Entidad.CCLNT) 'OPERACION ADM
        lobjParams.Add("PNNROVLR", Entidad.NROVLR) 'OPERACION ADM
        lobjParams.Add("PNNOPRSD", Entidad.NOPRSD) 'VALORIZACIÓN
        lobjParams.Add("PNNRITEM", Entidad.NRITEM)  'OPERACION
        'lobjParams.Add("PNNOPRCN", Entidad.NOPRCN)  'OPERACION

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSTERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OPERACION_ELIMINAR_OP_ADMINSTRATIVA", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                msg = msg & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next

        Return msg

    End Function

    Public Function Calcular_Validar_Sustento_Viajes(ByVal Entidad As beMantValorizacion) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable

        Dim msg As String = ""
        Dim sStatus As String = ""

        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNNROVLR", Entidad.NROVLR) 'NRO VALORIZACION

        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjParams.Add("PSTERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_CALCULAR_VALIDAR_SUSTENTO_VIAJES", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                msg = msg & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next

        Return msg

    End Function



    Public Function Lista_Operaciones_Sustento_Por_Operacion_Administrativa(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNCCLNT", Entidad.CCLNT)  'CLIENTE
        lobjParams.Add("PNNOPRSD", Entidad.NOPRSD) 'NRO OP ADM

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACIONES_SUSTENTO_X_OPADMINISTRATIVA", lobjParams)

        dt.Columns.Add("MARGEN")

        For Each item As DataRow In dt.Rows
            item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
            item("FATNSR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FATNSR"))

            item("MARGEN") = item("COBRO_DOL") - item("PAGO_DOL")
        Next

        Return dt

    End Function



    Public Function Lista_Operacion_Administracion_Valorizacion(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", Entidad.CCMPN) 'COMPAÑIA
        lobjParams.Add("PNNROVLR", Entidad.NROVLR) 'NRO VALORIZACIÓN
        lobjParams.Add("PNNOPRSD", Entidad.NOPRSD)
 
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_OPERACION_ADMIN_VALORIZACION", lobjParams)
        Return dt

    End Function


    Public Function Generar_Operacion_Rango_Valorizacion(ByVal Entidad As beMantValorizacion) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable

        Dim msg As String = ""
        Dim sStatus As String = ""

        lobjParams.Add("PSCCMPN", Entidad.CCMPN)
        lobjParams.Add("PNCCLNT", Entidad.CCLNT)
        lobjParams.Add("PNNROVLR", Entidad.NROVLR)
        lobjParams.Add("PNNOPRCN", Entidad.NOPRCN)
        lobjParams.Add("PNCCLNFC", Entidad.CCLNT)
        lobjParams.Add("PNNRTFSV", Entidad.NRTFSV)
        lobjParams.Add("PNCRROP", Entidad.CRROP)
        lobjParams.Add("PNFATNSR", Entidad.FATNSR)
        lobjParams.Add("PSCDVSN", Entidad.CDVSN)
        lobjParams.Add("PNCPLNDV", Entidad.CPLNDV)
        lobjParams.Add("PSTERMINAL", Ransa.Utilitario.HelpClass.NombreMaquina)
        lobjParams.Add("PSUSUARI", ConfigurationWizard.UserName)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_GENERAR_OPERACION_RNG_VALORIZACION", lobjParams)

        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                msg = msg & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next

        Return msg

    End Function

    Public Function Lista_Operaciones_Pendientes_Sustento_Rango_Viaje(ByVal Entidad As beMantValorizacion) As DataSet
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim ds As New DataSet


        lobjParams.Add("PNCCLNT", Entidad.CCLNT)
        lobjParams.Add("PNFATNSR_INI", Entidad.FATNSR_INI)
        lobjParams.Add("PNFATNSR_FIN", Entidad.FATNSR_FIN)

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTA_OPERACIONES_PENDIENTES_SUSTENTO_RNG_VJE", lobjParams)
        ds.Tables(0).Columns.Add("MARGEN")
        ds.Tables(1).Columns.Add("MARGEN")

        For Each item As DataRow In ds.Tables(0).Rows
            item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
            item("FATNSR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FATNSR"))

            item("MARGEN") = item("COBRO_DOL") - item("PAGO_DOL")
        Next

        For Each item As DataRow In ds.Tables(1).Rows
            item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
            item("FATNSR") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FATNSR"))

            item("MARGEN") = item("COBRO_DOL") - item("PAGO_DOL")
        Next

        Return ds

    End Function


    Public Function Listar_Tarifas_Rango_Valorizacion(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable


        lobjParams.Add("PSCCMPN", Entidad.CCMPN)
        lobjParams.Add("PNCCLNT", Entidad.CCLNT)
        lobjParams.Add("PNNOPRCN", Entidad.NOPRCN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_TARIFAS_RANGO_VALIDACION", lobjParams)

        Return dt

    End Function



    Public Function Lista_Tarifas_Rango_Validacion(ByVal Entidad As beMantValorizacion) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable


        lobjParams.Add("PSCCMPN", Entidad.CCMPN)
        lobjParams.Add("PNCCLNT", Entidad.CCLNT)
        lobjParams.Add("PNNOPRCN", Entidad.NOPRCN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_TARIFAS_RANGO_VALIDACION", lobjParams)

        Return dt

    End Function

    Public Function ListarServicioDetalleTipoRangoValorizacionExport(ByVal obeMantValorizacion As beMantValorizacion) As DataSet
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim ds As New DataSet
        Dim nombre_mes As String = ""


        Dim JsGt As Dictionary(Of String, Object)
        Dim listJsGT As New List(Of Dictionary(Of String, Object))
        Dim listjson As New List(Of String)
        Dim listjsmax As Int64 = 1000
        Dim StrJson As String = ""

        Dim FILA As Int64 = 0


        lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN)
        lobjParams.Add("PNNROVLR", obeMantValorizacion.NROVLR)

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_ST_LISTAR_SERVICIOS_DETALLE_TIPO_RANGO_VALORIZACION", lobjParams)


        For Each item As DataRow In ds.Tables(0).Rows
            item("FCH_VAL") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_VAL"))
            item("FCH_ENVIO") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_ENVIO"))
            item("HRA_ENVIO") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HRA_ENVIO"))
            item("FCH_APROB") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FCH_APROB"))
            item("HRA_APROB") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HRA_APROB"))

        Next

        ds.Tables(2).Columns.Add("PESO_ALM", Type.GetType("System.Decimal"))
        ds.Tables(2).Columns.Add("ORIGEN_PESO")


        For Each item As DataRow In ds.Tables(2).Rows  ' ANTES 1
            item("FINCOP") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINCOP"))
            item("FSLDCM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FSLDCM"))
            item("FLLGCM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLLGCM"))
            item("FGUIRM") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FGUIRM"))
            item("FDCPRF") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FDCPRF"))

            item("MESPROV") = "" & item("MESPROV")
            If item("MESPROV") <> "" Then
                nombre_mes = CDate(Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("MESPROV") & "01")).ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"))
                item("MESPROV") = nombre_mes.ToUpper & " - " & item("MESPROV").ToString.Substring(0, 4)
            End If
 

        Next



        '' adicionado por calculo de los pesos de bultos según carga de alamcenes
        Dim dtGTDistinct As New DataTable
        Dim GuiaTransp As Decimal = 0
        FILA = 0
        dtGTDistinct = ds.Tables(2).DefaultView.ToTable(True, "CTRMNC", "NGUITR")
        For Each item As DataRow In dtGTDistinct.Rows
            GuiaTransp = item("NGUITR")
            If GuiaTransp > 0 Then
                JsGt = New Dictionary(Of String, Object)
                FILA = FILA + 1
                JsGt.Add("FL", FILA)
                JsGt.Add("CODT", item("CTRMNC"))
                JsGt.Add("GT", GuiaTransp)
                listJsGT.Add(JsGt)
            End If
        Next
        StrJson = JsonConvert.SerializeObject(listJsGT)


        Dim dtPesoResumen As New DataTable
        If StrJson.Length > 0 Then
            lobjParams = New Parameter
            lobjParams.Add("PSLISTJSON", StrJson)
            dtPesoResumen = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_CALCULAR_PESOGUIACLIENTE_X_GT_VALORIZACIOM", lobjParams)

            Dim drbusq() As DataRow
            For Each item As DataRow In ds.Tables(2).Rows
                drbusq = dtPesoResumen.Select("CTRMNC='" & item("CTRMNC") & "'  AND NGUIRM='" & item("NGUITR") & "' AND CANT_GRALM>0")
                If drbusq.Length > 0 Then
                    item("PESO_ALM") = drbusq(0)("PSOALMACEN")
                    item("ORIGEN_PESO") = "ALMACEN"
                Else
                    'item("PESO_ALM") = DBNull.Value
                    item("PESO_ALM") = item("PBRTOR")
                    item("ORIGEN_PESO") = "REMISION"
                End If
            Next


        End If



        For Each item As DataRow In ds.Tables(4).Rows
            item("FLQDCN") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FLQDCN"))
            item("FECFAC") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FECFAC"))
        Next

      

        Return ds

    End Function


    'Public Function ListarOperPendientesValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    lobjParams.Add("PSCCMPN", obeMantValorizacion.CCMPN) 'COMPAÑIA
    '    lobjParams.Add("PSCDVSN", obeMantValorizacion.CDVSN) 'DIVISION
    '    lobjParams.Add("PSCPLNDV", obeMantValorizacion.CPLNDV) 'PLANTA
    '    lobjParams.Add("PNCCLNT", obeMantValorizacion.CCLNT) 'CLIENTE
    '    lobjParams.Add("PNNOPRCN", obeMantValorizacion.NOPRCN) 'CLIENTE

    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_OP_PENDIENTES_VALORIZACION", lobjParams)
    '    Return dt

    'End Function


#End Region

End Class
