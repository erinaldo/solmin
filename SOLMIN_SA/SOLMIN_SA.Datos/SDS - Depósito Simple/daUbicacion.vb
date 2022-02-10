Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF


Public Class daUbicacion
    Inherits daBase(Of beUbicacion)

    Private objSql As New SqlManager

    Public Function ListardetallePosicion(ByVal ParamArray params As Object()) As DataTable
        Return TraerDataTable("SP_SOLMIN_SA_SDS_LISTAR_UBICACION_DETALLE", params)
    End Function
    Public Function RegistrarReubicacionMercaderia(ByVal obeUbicacion As beUbicacion) As beUbicacion

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNNORDSR", obeUbicacion.PNNORDSR)
        objParam.Add("PNCCLNT", obeUbicacion.PNCCLNT)
        objParam.Add("PSCTPALM_I", obeUbicacion.PSCTPALM_I)
        objParam.Add("PSCALMC_I", obeUbicacion.PSCALMC_I)
        objParam.Add("PSCZNALM_I", obeUbicacion.PSCZNALM_I)
        objParam.Add("PSCPSCN_I", obeUbicacion.PSCPSCN_I)
        objParam.Add("PSCSECTR_I", obeUbicacion.PSCSECTR_I)
        objParam.Add("PSCTPALM", obeUbicacion.PSCTPALM)
        objParam.Add("PSCALMC", obeUbicacion.PSCALMC)
        objParam.Add("PSCZNALM", obeUbicacion.PSCZNALM)
        objParam.Add("PSCPSCN", obeUbicacion.PSCPSCN)
        objParam.Add("PSCSECTR", obeUbicacion.PSCSECTR)

        objParam.Add("PNNCRRIN", obeUbicacion.PNNCRRIN)


        objParam.Add("PNQTRMC", obeUbicacion.PNQTRMC)
        objParam.Add("PNQTRMP", obeUbicacion.PNQTRMP)
        objParam.Add("PSTOBSRV", obeUbicacion.PSTOBSRV)
        objParam.Add("PSCCMPN", obeUbicacion.PSCCMPN)
        objParam.Add("PSCDVSN", obeUbicacion.PSCDVSN)
        objParam.Add("PSCULUSA", obeUbicacion.PSCULUSA)
        objParam.Add("PSCUSCRT", obeUbicacion.PSCUSCRT)
        objParam.Add("PSINTERNO", obeUbicacion.PSINTERNO)
        objParam.Add("PSNTRMCR", obeUbicacion.PSNTRMCR)
        objParam.Add("PSNTRMNL", obeUbicacion.PSNTRMNL)
        objParam.Add("EXISTEUBICACION", "", ParameterDirection.Output)
        objParam.Add("REUBICACION", "", ParameterDirection.Output)
        objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_SDS_REUBICACION_MERCADERIA", objParam)
        obeUbicacion.PSEXISTEUBICACION = objSqlManager.ParameterCollection("EXISTEUBICACION").ToString
        obeUbicacion.PSREUBICACION = objSqlManager.ParameterCollection("REUBICACION").ToString
        'Catch ex As Exception
        '    obeUbicacion.PSEXISTEUBICACION = "I"
        '    obeUbicacion.PSREUBICACION = "I"
        'End Try
        Return obeUbicacion
    End Function

    Public Overrides Sub SetStoredprocedures()
        '    SPListar = "SP_SOLMIN_SA_SDS_LISTAR_UBICACION"
        SPListar = "SP_SOLMIN_SA_SDS_LISTAR_UBICACION_STOCK"
        SPInsert = "SP_SOLMIN_SA_SDS_INSER_UBICACION"
        SPUpdate = "SP_SOLMIN_SA_SDS_UPD_UBICACION"
        SPDelete = "SP_SOLMIN_SA_SDS_DELETE_UBICACION"
    End Sub



    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beUbicacion)
        SetParameter(obj.PSCTPALM)
        SetParameter(obj.PSCALMC)
        SetParameter(obj.PSCSECTR)
        SetParameter(obj.PSCPSCN)
        SetParameter(obj.PSCPSLL)
        SetParameter(obj.PSCCLMN)
        SetParameter(obj.PSCPRFMR)
        SetParameter(obj.PSCAPIMR)
        SetParameter(obj.PSCROTMR)
        SetParameter(obj.PNCSRVPK)
        SetParameter(obj.PNNCOORX)
        SetParameter(obj.PNNCOORY)
        SetParameter(obj.PNNCOORZ)
        SetParameter(obj.PNNCOOX2)
        SetParameter(obj.PNNCOOY2)
        SetParameter(obj.PNNCOOZ2)
        SetParameter(obj.PNQCMLRG)
        SetParameter(obj.PNQCMANC)
        SetParameter(obj.PNQCMALT)
        SetParameter(obj.PNCCLNRN)
        SetParameter(obj.PSSSCPOS)
        SetParameter(obj.PNPRCUSO)
        SetParameter(obj.PSCZNALM)
        SetParameter(obj.PSTFNCAC)
        SetParameter(obj.PNFULTAC)
        SetParameter(obj.PNHULTAC)
        SetParameter(obj.PSCULUSA)
        SetParameter(obj.PSSESTRG)
        SetParameter(obj.PNUPDATE_IDENT)
        
    End Sub


    Public Function ListarPosiciones(ByVal obeUbicacion As beUbicacion) As List(Of beUbicacion)

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim cant_pag As Decimal = 0
        Dim dt As New DataTable
        objParam.Add("PNCCLNT", obeUbicacion.PNCCLNT)
        objParam.Add("PSCTPALM", obeUbicacion.PSTALMC)
        objParam.Add("PSCALMC", obeUbicacion.PSCALMC)
        objParam.Add("PSCSECTR", obeUbicacion.PSCSECTR)
        objParam.Add("PSCPSCN", obeUbicacion.PSCPSCN)
        objParam.Add("PAGESIZE", obeUbicacion.PageSize)
        objParam.Add("PAGENUMBER", obeUbicacion.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTAR_UBICACION_STOCK_V2", objParam)
        cant_pag = objSqlManager.ParameterCollection("PAGECOUNT").ToString
        Dim oListUbicacion As New List(Of beUbicacion)

        For Each Item As DataRow In dt.Rows
            obeUbicacion = New beUbicacion
            obeUbicacion.PSCTPALM = Item("CTPALM").ToString.Trim
            obeUbicacion.PSCALMC = Item("CALMC").ToString.Trim
            obeUbicacion.PSCSECTR = Item("CSECTR").ToString.Trim
            obeUbicacion.PSCPSCN = Item("CPSCN").ToString.Trim
            obeUbicacion.PSCPSLL = Item("CPSLL").ToString.Trim
            obeUbicacion.PSCCLMN = Item("CCLMN").ToString.Trim
            obeUbicacion.PSCPRFMR = Item("CPRFMR").ToString.Trim
            obeUbicacion.PSCROTMR = Item("CROTMR").ToString.Trim
            obeUbicacion.PNCSRVPK = Item("CSRVPK")
            obeUbicacion.PNNCOORX = Item("NCOORX")
            obeUbicacion.PNNCOORY = Item("NCOORY")
            obeUbicacion.PNNCOORZ = Item("NCOORZ")
            obeUbicacion.PNNCOOX2 = Item("NCOOX2")
            obeUbicacion.PNNCOOY2 = Item("NCOOY2")
            obeUbicacion.PNNCOOZ2 = Item("NCOOZ2")
            obeUbicacion.PNQCMLRG = Item("QCMLRG")
            obeUbicacion.PNQCMANC = Item("QCMANC")
            obeUbicacion.PNQCMALT = Item("QCMALT")
            obeUbicacion.PNCCLNRN = Item("CCLNRN")
            obeUbicacion.PSSSCPOS = Item("SSCPOS").ToString.Trim
            obeUbicacion.PNPRCUSO = Item("PRCUSO")
            obeUbicacion.PSCZNALM = Item("CZNALM").ToString.Trim
            obeUbicacion.PSTFNCAC = Item("TFNCAC").ToString.Trim
            obeUbicacion.PSESTADO = Item("ESTADO").ToString.Trim
            obeUbicacion.PNQSLETQ = Item("QSLETQ")
            obeUbicacion.PSTMRCD2 = Item("TMRCD2").ToString.Trim
            obeUbicacion.PSTIPO_ALMACEN = Item("TIPO_ALMACEN").ToString.Trim
            obeUbicacion.PSALMACEN = Item("ALMACEN").ToString.Trim
            obeUbicacion.PSZONA = Item("ZONA").ToString.Trim
            obeUbicacion.PSCLIENTE = Item("CLIENTE").ToString.Trim

            obeUbicacion.PNCPLNFC = Item("CPLNFC").ToString.Trim
            obeUbicacion.PSTPLNTA = Item("TPLNTA").ToString.Trim


            obeUbicacion.PageCount = cant_pag
            oListUbicacion.Add(obeUbicacion)
        Next


        Return oListUbicacion
    End Function



    Public Function Listar_ubicacion_Almacen_Zona(ByVal obeUbicacion As beUbicacion) As DataTable
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim cant_pag As Decimal = 0
        Dim dt As New DataTable
        objParam.Add("PSCCMPN", obeUbicacion.PSCCMPN)
        objParam.Add("PNCCLNT", obeUbicacion.PNCCLNT)
        objParam.Add("PSCTPALM", obeUbicacion.PSTALMC)
        objParam.Add("PSCALMC", obeUbicacion.PSCALMC)
        objParam.Add("PSCZNALM", obeUbicacion.PSCZNALM)
        objParam.Add("PSCPSCN", obeUbicacion.PSCPSCN)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SDS_LISTAR_UBICACION_X_ALMACEN_ZONA", objParam)
        Return dt
    End Function

    Public Function Registrar_ubicacion_Almacen_Zona_Masivo(ByVal obeUbicacion As beUbicacion) As String
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim cant_pag As Decimal = 0
        Dim dt As New DataTable
        Dim msg As String = ""
        objParam.Add("PSCCMPN", obeUbicacion.PSCCMPN)
        objParam.Add("PSCTPALM", obeUbicacion.PSTALMC)
        objParam.Add("PSCALMC", obeUbicacion.PSCALMC)
        objParam.Add("PSCZNALM", obeUbicacion.PSCZNALM)
        objParam.Add("PSCSECTR", obeUbicacion.PSCSECTR)
        objParam.Add("PNCCLNT", obeUbicacion.PNCCLNT)
        objParam.Add("PSCPSCN", obeUbicacion.PSCPSCN)
        objParam.Add("PSCULUSA", obeUbicacion.PSUSUARIO)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SDS_INSER_MASIVO_UBICACION", objParam)
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim

        Return msg
    End Function


End Class
