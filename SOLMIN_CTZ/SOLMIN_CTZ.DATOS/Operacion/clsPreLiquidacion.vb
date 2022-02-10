Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
Public Class clsPreLiquidacion

    Public Function Registrar_PL_Transporte_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByRef NPRLQD As Decimal) As String
        'Public Function Registrar_PreLiquidacion_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByVal NDCPRF As String, ByRef NPRLQD As Decimal, ACCION As String) As String
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim msg As String = ""



        '
        objParam.Add("PNNROVLR", objEntidad.NROVLR)
        'objParam.Add("PNNPRLQD", NPRLQD)
        'objParam.Add("PSACCION", ACCION)
        'objParam.Add("PSNDCPRF", NDCPRF)
        'objParam.Add("PSTIPO_PL", objEntidad.TIPO_PL)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSLISTA_A_PL", objEntidad.LISTA_A_PL)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        'objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
        objParam.Add("PSTPDCPE", objEntidad.TPDCPE)
        objParam.Add("PSDCCLNT", objEntidad.DCCLNT)
        objParam.Add("PSSBCLNT", objEntidad.SBCLNT)
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_REGISTRAR_PRE_LIQUIDACION_LA", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim
        If msg.Length = 0 And dt.Rows.Count > 0 Then
            NPRLQD = dt.Rows(0)("NPRLQD")
        End If

        Return msg
    End Function


    Public Function Registrar_PL_Admin_X_Valorizacion(ByVal objEntidad As beFactura_Transporte, ByRef NPRLQD As Decimal) As String
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim objParam As New Parameter
        Dim msg As String = ""


        objParam.Add("PNNROVLR", objEntidad.NROVLR)
        objParam.Add("PNCCLNT", objEntidad.CCLNT)
        objParam.Add("PSLISTA_A_PL", objEntidad.LISTA_A_PL)
        objParam.Add("PSCULUSA", objEntidad.CULUSA)
        objParam.Add("PSNTRMNL", objEntidad.NTRMNL)
        objParam.Add("PSCCMPN", objEntidad.CCMPN)
        objParam.Add("PSCDVSN", objEntidad.CDVSN)
        'objParam.Add("PNCPLNDV", objEntidad.CPLNCL)
        objParam.Add("PSTPDCPE", objEntidad.TPDCPE)
        objParam.Add("PSDCCLNT", objEntidad.DCCLNT)
        objParam.Add("PSSBCLNT", objEntidad.SBCLNT)
        lobjSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_REGISTRAR_PRE_LIQUIDACION_ADMIN_X_VALORIZACION", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT").ToString.Trim & Chr(13)
            End If
        Next
        msg = msg.Trim
        If msg.Length = 0 And dt.Rows.Count > 0 Then
            NPRLQD = dt.Rows(0)("NPRLQD")
        End If

        Return msg
    End Function

End Class
