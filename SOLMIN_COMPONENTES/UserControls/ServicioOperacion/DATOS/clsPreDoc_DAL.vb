Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsPreDoc_DAL

    Public Function ListarPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PNNRLQD", obePreDoc.PNNRLQD)
        lobjParams.Add("PNCMNDGU", obePreDoc.PNCMNDGU)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_PRE_DOC", lobjParams)
        For Each item As DataRow In dt.Rows
            item("IMPORTE") = Val("" & item("IMPORTE"))
        Next


        Return dt
    End Function

    Public Function ListarCabMonedaPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_MONEDA_CAB_PREDOC", lobjParams)
        Return dt
    End Function


    Public Function ListarOperacionesXPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable

        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTPCTRL", obePreDoc.PSTPCTRL)
        lobjParams.Add("PNNCRRPD", obePreDoc.PNNCRRPD)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OPERACIONES_POR_PREDOCUMENTOS", lobjParams)
        For Each item As DataRow In dt.Rows
            item("IVLSRV") = Val("" & item("IVLSRV"))
        Next
        Return dt
    End Function

    '------------------------------------------------------
    Public Function LiberarPL(ByVal obePreDoc As PreDoc_BE) As String
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
        lobjParams.Add("PNCMNDA1", obePreDoc.PNCMNDA1)
        lobjParams.Add("PNIMPOPEND", obePreDoc.PNIMPOPEND)
        lobjParams.Add("PSCULUSA", obePreDoc.PSCULUSA)
        lobjParams.Add("PSNTRMNL", obePreDoc.PSNTRMNL)

 

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LIBERAR_PL", lobjParams)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim
        
        Return msg

    End Function
    Public Function RegistrarCabeceraPDoc(ByVal obePreDoc As PreDoc_BE, ByRef pNCRPD As Decimal) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim sStatus As String = ""
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL) ' PSTPCTRL
        lobjParams.Add("PNCMNDA1", obePreDoc.PNCMNDA1)
        lobjParams.Add("PSTPDCPE", obePreDoc.PSTPDCPE)
        lobjParams.Add("PSDCCLNT", obePreDoc.PSDCCLNT)
        lobjParams.Add("PSSBCLNT", obePreDoc.PSSBCLNT)
        lobjParams.Add("PSTOBS", obePreDoc.PSTOBS)
        lobjParams.Add("PSNTRMNL", obePreDoc.PSNTRMNL)
        lobjParams.Add("PSCULUSA", obePreDoc.PSCULUSA)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_CAB_PRE_DOCPL", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim
        If msg.Length = 0 And dt.Rows.Count > 0 Then
            pNCRPD = dt.Rows(0)("OBSRESULT").ToString
        End If

        Return msg


    End Function
    Public Function RegistrarDetallePDoc(ByVal obePreDoc As PreDoc_BE, ByRef pNCRPD As Decimal) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim sStatus As String = ""
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
        lobjParams.Add("PNNCRRPD", pNCRPD)
        lobjParams.Add("PNNOPRCN", obePreDoc.PNNOPRCN)
        lobjParams.Add("PSTPOPER", obePreDoc.PSTPOPER)
        lobjParams.Add("PNNGUIRM", obePreDoc.PNNGUIRM)
        lobjParams.Add("PNNCRROP", obePreDoc.PNNCRROP)
        lobjParams.Add("PNNGUITR", obePreDoc.PNNGUITR)
        lobjParams.Add("PNNCRRGU", obePreDoc.PNNCRRGU)
        lobjParams.Add("PSCDVSN", obePreDoc.PSCDVSN)
        lobjParams.Add("PNCPLNDV", obePreDoc.PNCPLNDV)
        lobjParams.Add("PNCSRVC", obePreDoc.PNCSRVC)
        lobjParams.Add("PNCMNDA1", obePreDoc.PNCMNDA1)
        lobjParams.Add("PNQATNAN", obePreDoc.PNQATNAN)
        lobjParams.Add("PNIVLSRV", obePreDoc.PNIVLSRV)
        lobjParams.Add("PSTOBS", obePreDoc.PSTOBS)
        lobjParams.Add("PSFAJIMP", obePreDoc.PSFAJIMP)
        lobjParams.Add("PSNTRMNL", obePreDoc.PSNTRMNL)
        lobjParams.Add("PSCULUSA", obePreDoc.PSCULUSA)
        lobjParams.Add("PNCCLNT", obePreDoc.PNCCNLT)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_REGISTRAR_DET_PRE_DOCPL", lobjParams)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim

        Return msg


    End Function
    Public Function EliminarCabeceraPDoc(ByVal obePreDoc As PreDoc_BE) As String
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim sStatus As String = ""
        Dim sErrorMesage As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTPCTRL", obePreDoc.PSTPCTRL)
        lobjParams.Add("PNNCRRPD", obePreDoc.PNNCRRPD)
        lobjParams.Add("PSNTRMNL", obePreDoc.PSNTRMNL)
        lobjParams.Add("PSCULUSA", obePreDoc.PSCULUSA)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ELIMINAR_CAB_PRE_DOCPL", lobjParams)
        For Each row As DataRow In dt.Rows
            sStatus = row("STATUS").ToString.Trim
            If sStatus = "E" Then
                sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
            End If
        Next
        sErrorMesage = sErrorMesage.Trim

        Return sErrorMesage
    End Function

    Public Function ListarPendDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNCCLNT", obePreDoc.PNCCNLT)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
        lobjParams.Add("PNCMNDGU", obePreDoc.PNCMNDGU)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_OPERACIONES_PEND_PREDOCUMENTOS", lobjParams)
        For Each item As DataRow In dt.Rows
            item("IMPORTE_PENDTE") = Val("" & item("IMPORTE_PENDTE"))
        Next

        Return dt
    End Function

    Public Sub ActualizarPreDocumento(ByVal objParametros As Hashtable)

        Dim objParam As New Parameter
        Dim objDataTable As New DataTable
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objParametros("PSCCMPN"))
        objParam.Add("PNNRCTRL", objParametros("PNNRCTRL"))
        objParam.Add("PNNCRRPD", objParametros("PNNCRRPD"))
        objParam.Add("PSTPCTRL", objParametros("PSTPCTRL"))
        objParam.Add("PSTPDCPE", objParametros("PSTPDCPE"))
        objParam.Add("PSDCCLNT", objParametros("PSDCCLNT"))
        objParam.Add("PSSBCLNT", objParametros("PSSBCLNT"))
        objParam.Add("PSCULUSA", objParametros("PSCULUSA"))
        objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_UPDATE_LISTA_PREDOC", objParam)

    End Sub
    Public Function ListarPLDocumentos(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        '' dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CAB_PRE_DOCPL", lobjParams)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CAB_PRE_DOCPL", lobjParams)

        For Each item As DataRow In dt.Rows
            item("IMPORTE") = Val("" & item("IMPORTE"))
        Next


        Return dt
    End Function

    Public Function ValidarAjuste(ByVal obePreDoc As PreDoc_BE) As String
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        lobjParams.Add("PNAJUSTE", obePreDoc.PNAJUSTE)
        lobjParams.Add("PNCMNDA1", obePreDoc.PNCMNDA1)
        lobjParams.Add("PNIMPOPEND", obePreDoc.PNIMPOPEND)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_VALIDAR_AJUSTE", lobjParams)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(10)
            End If
        Next
        msg = msg.Trim

        Return msg

    End Function


    Public Function ListarEstadoPL(ByVal obePreDoc As PreDoc_BE) As DataTable
        Dim lobjSql As New SqlManager
        Dim dt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_ESTADO_PL", lobjParams)
        Return dt
    End Function


    Public Function ListarDetallePL_ValorReferencial(ByVal obePreDoc As PreDoc_BE) As DataSet
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim ds As New DataSet
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_CT_LISTAR_DETALLE_PREDOC_VALOR_REF", lobjParams)
       
        Return ds
    End Function

    Public Sub ActualizarDetallePL_ValorReferencial(ByVal obePreDoc As PreDoc_BE)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        'Dim ds As New DataSet
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

        lobjParams.Add("PNNCRRPD", obePreDoc.PNNCRRPD)
        lobjParams.Add("PNCRIPD", obePreDoc.PNCRIPD)
        lobjParams.Add("PNVLRFDT", obePreDoc.PNVLRFDT)

        lobjSql.ExecuteNonQuery("SP_SOLMIN_CT_LISTAR_ACTUALIZAR_DETALLE_PREDOC_VALOR_REF", lobjParams)


    End Sub

    Public Function AnularLiberacionPL(ByVal obePreDoc As PreDoc_BE) As String
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim msg As String = ""
        lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
        lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
        lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
        lobjParams.Add("PSCULUSA", obePreDoc.PSCULUSA)
        lobjParams.Add("PSNTRMNL", obePreDoc.PSNTRMNL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_ANULAR_LIBERACION_PL", lobjParams)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim

        Return msg

    End Function


    'Public Function ListarPLDocumentos_ADMIN(ByVal obePreDoc As PreDoc_BE) As DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
    '    lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
    '    lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)

    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_CAB_PRE_DOCPL", lobjParams)
    '    For Each item As DataRow In dt.Rows
    '        item("IMPORTE") = Val("" & item("IMPORTE"))
    '    Next


    '    Return dt
    'End Function
    'Public Function ListarDatosPreDoc(ByVal obePreDoc As PreDoc_BE) As DataTable
    '    Dim lobjParams As New Parameter
    '    Dim lobjSql As New SqlManager
    '    Dim dt As New DataTable
    '    lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
    '    lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
    '    lobjParams.Add("PNNCRRPD", obePreDoc.PNNCRRPD)

    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_DATOS_PREDOC", lobjParams)

    '    Return dt
    'End Function


    'Public Function LiberarPL(ByVal obePreDoc As PreDoc_BE) As String
    '    Dim dt As New DataTable
    '    Dim lobjSql As New SqlManager
    '    Dim lobjParams As New Parameter
    '    Dim msg As String = ""
    '    lobjParams.Add("PSCCMPN", obePreDoc.PSCCMPN)
    '    lobjParams.Add("PNNRCTRL", obePreDoc.PNNRCTRL)
    '    lobjParams.Add("PSTIPOPL", obePreDoc.PSTIPOPL)
    '    lobjParams.Add("PNCMNDA1", obePreDoc.PNCMNDA1)
    '    lobjParams.Add("PNIMPOPEND", obePreDoc.PNIMPOPEND)


    '    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTAR_DETALLE_PREDOC_VALOR_REF", lobjParams)


    '    Return msg

    'End Function


End Class
