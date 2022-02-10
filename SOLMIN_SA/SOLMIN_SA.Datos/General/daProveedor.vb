Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.beProveedor

Public Class daProveedor
    Inherits daBase(Of beProveedor)

    Public Function RegistrarProveedorGeneral(ByVal obeProveedor As beProveedor) As beProveedor
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCPRVCL", obeProveedor.PNCPRVCL, ParameterDirection.Output)
            objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
            objParam.Add("PSTPRCL1", obeProveedor.PSTPRCL1)
            objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
            objParam.Add("PSTNACPR", obeProveedor.PSTNACPR)
            objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC)
            objParam.Add("PNCPAIS", obeProveedor.PNCPAIS)
            objParam.Add("PSTNROFX", obeProveedor.PSTNROFX)
            objParam.Add("PSTLFNO1", obeProveedor.PSTLFNO1)
            objParam.Add("PSTEMAI2", obeProveedor.PSTEMAI2)
            objParam.Add("PSTPRSCN", obeProveedor.PSTPRSCN)
            objParam.Add("PSTLFNO2", obeProveedor.PSTLFNO2)
            objParam.Add("PSTEMAI3", obeProveedor.PSTEMAI3)
            objParam.Add("PNNDSDMP", obeProveedor.PNNDSDMP)
            objParam.Add("PSCULUSA", obeProveedor.PSCULUSA)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_PROVEEDOR_INSERTAR_GENERAL", objParam)
            obeProveedor.PNCPRVCL = objSqlManager.ParameterCollection("PNCPRVCL")
        Catch ex As Exception
            obeProveedor.PNCPRVCL = -1
        End Try
        Return obeProveedor

    End Function

    Public Function ObtenerProveedor(ByVal obeProveedor As beProveedor) As beProveedor

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim odt As New DataTable
        Try
            objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
            objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
            odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_PROVEEDOR", objParam)
            If (odt.Rows.Count > 0) Then
                obeProveedor.PNCPRVCL = odt.Rows(0).Item("CPRVCL")
                obeProveedor.PSTPRVCL = odt.Rows(0).Item("TPRVCL").ToString.Trim
                obeProveedor.PSTPRCL1 = odt.Rows(0).Item("TPRCL1").ToString.Trim
                obeProveedor.PNNRUCPR = odt.Rows(0).Item("NRUCPR")
                obeProveedor.PSTNACPR = odt.Rows(0).Item("TNACPR").ToString.Trim
                obeProveedor.PSTDRPRC = odt.Rows(0).Item("TDRPRC").ToString.Trim
                obeProveedor.PNCPAIS = odt.Rows(0).Item("CPAIS")
                obeProveedor.PSTNROFX = odt.Rows(0).Item("TNROFX").ToString.Trim
                obeProveedor.PSTLFNO1 = odt.Rows(0).Item("TLFNO1").ToString.Trim
                obeProveedor.PSTEMAI2 = odt.Rows(0).Item("TEMAI2").ToString.Trim
                obeProveedor.PSTPRSCN = odt.Rows(0).Item("TPRSCN").ToString.Trim
                obeProveedor.PSTLFNO2 = odt.Rows(0).Item("TLFNO2").ToString.Trim
                obeProveedor.PSTEMAI3 = odt.Rows(0).Item("TEMAI3").ToString.Trim
                obeProveedor.PNNDSDMP = odt.Rows(0).Item("NDSDMP")
                obeProveedor.PSSESTRG = odt.Rows(0).Item("SESTRG").ToString.Trim
            Else
                obeProveedor.PNCPRVCL = -1
            End If
        Catch ex As Exception
            obeProveedor.PNCPRVCL = -1
        End Try
        Return obeProveedor
    End Function

 



    Public Function fblnRegistrar_Proveedor_de_ABB(ByVal obeProveedor As beProveedor) As beProveedor
        Dim objSqlManager As New SqlManager
        Dim objParametros As New Parameter
        Try
            ' objSqlManager.TransactionController(TransactionType.Automatic)
            objParametros.Add("IN_CPRVCL", obeProveedor.CPRVCL_CodClienteTercero)
            objParametros.Add("IN_TPRVCL", obeProveedor.PSTPRVCL)
            objParametros.Add("IN_TPRCL1", obeProveedor.PSTPRCL1)
            objParametros.Add("IN_NRUCPR", obeProveedor.NRUCPR_RucProveedor)
            objParametros.Add("IN_TNACPR", obeProveedor.TNACPR_DesProvDistProveedor)
            objParametros.Add("IN_TDRPRC", obeProveedor.PSTDRPRC)
            objParametros.Add("IN_CPAIS", obeProveedor.CPAIS_CodigoPais)
            objParametros.Add("IN_TNROFX", obeProveedor.TNROFX_NroFax)
            objParametros.Add("IN_TLFNO1", obeProveedor.TLFN01_Telefono)
            objParametros.Add("IN_TEMAI2", obeProveedor.TEMAI2_NombreEmail)
            If obeProveedor.PSTPRSCN.Trim.Length > 40 Then
                objParametros.Add("IN_TPRSCN", obeProveedor.PSTPRSCN.Trim.Substring(0, 40))
            Else
                objParametros.Add("IN_TPRSCN", obeProveedor.PSTPRSCN.Trim)
            End If
            objParametros.Add("IN_TLFNO2", obeProveedor.TLFN02_FonoContacto)
            objParametros.Add("IN_TEMAI3", obeProveedor.TMAI03_EmailContacto)
            objParametros.Add("IN_NDSDMP", obeProveedor.NDSDMP_NumDiasDemoraPago)
            objParametros.Add("IN_USUARI", obeProveedor.CUSCRT_UsuarioCre)
            objParametros.Add("IN_CCLNT", obeProveedor.CCLNT_CodigoCliente)
            objParametros.Add("IN_CPRPCL", obeProveedor.CPRPCL_CodigoClienteProveedor)
            objParametros.Add("IN_CREAR_RELACION", obeProveedor.CREAR_RELACION_CrearRelacionClientevsProveedor)
            objParametros.Add("IN_NTRMNL", obeProveedor.PSNTRMNL)
            objParametros.Add("IN_NTLFPL", obeProveedor.PSNTLFPL)

            objParametros.Add("IN_TDRPCP", obeProveedor.PSTDRPCP.Trim)
            objParametros.Add("IN_TDRDST", obeProveedor.PSTDRDST.Trim)
            objParametros.Add("IN_CCLTTM", obeProveedor.PSCCLTTM.Trim)


            objParametros.Add("IN_CCTCST", obeProveedor.PSCCTCST)
            objParametros.Add("IN_TDSCNT", obeProveedor.PSTDSCNT.Trim)
            objParametros.Add("IN_CDIVSU", obeProveedor.PSCDIVSU)
            objParametros.Add("IN_CDUNNG", obeProveedor.PSCDUNNG)
            objParametros.Add("IN_CDGALM", obeProveedor.PSCDGALM)
            objParametros.Add("IN_INTERNO", obeProveedor.PSINTERNO)

            objParametros.Add("OU_CPRVCL", 0, ParameterDirection.Output)
            objParametros.Add("OU_MSGERR", "", ParameterDirection.Output)
            objParametros.Add("OU_CPLCLP", 0, ParameterDirection.Output)



            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_INS_PROVEEDOR_DE_ABB", objParametros)

            obeProveedor.CPRVCL_CodClienteTercero = objSqlManager.ParameterCollection("OU_CPRVCL").ToString()
            obeProveedor.CPLCLP_CodPlanta = objSqlManager.ParameterCollection("OU_CPLCLP").ToString()

        Catch ex As Exception
            obeProveedor.CPRVCL_CodClienteTercero = 0
            Throw New System.Exception(ex.Message)
        End Try
        Return obeProveedor
    End Function

    Public Function ListarClienteTercero_x_Cliente(ByVal obeProveedor As TYPEDEF.beProveedor) As List(Of TYPEDEF.beProveedor)

        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olbeProveedor As New List(Of TYPEDEF.beProveedor)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeProveedor.PNCCLNT)
            objParam.Add("IN_NRUCPR", obeProveedor.NRUCPR_RucProveedorSTR)
            objParam.Add("PAGESIZE", obeProveedor.PageSize)
            objParam.Add("PAGENUMBER", obeProveedor.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_LISTA_CLIENTE_TERCERO_X_CLIENTE", objParam)
            ' Return Listar("SP_SOLMIN_SA_LISTA_CLIENTE_TERCERO_X_CLIENTETMP", objParam)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

     
    Public Function RegistrarRelacionTercero_x_Cliente(ByVal obeProveedor As TYPEDEF.beProveedor) As beProveedor

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeProveedor.CCLNT_CodigoCliente)
            objParam.Add("IN_CPRVCL", obeProveedor.CPRVCL_CodClienteTercero)
            objParam.Add("IN_USUARI", obeProveedor.CUSCRT_UsuarioCre)
            'objParam.Add("IN_STPORL", obeProveedor.PSSTPORL)
            'objParam.Add("IN_CPRPCL", obeProveedor.CPRPCL_CodigoClienteProveedor)
            objParam.Add("RELACION", "", ParameterDirection.Output)
            objParam.Add("CREACION", "", ParameterDirection.Output)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_INS_RELACION_CLIENTE_VS_TERCERO", objParam)
            obeProveedor.RELACION = objSqlManager.ParameterCollection("RELACION").ToString
            obeProveedor.CREACION = objSqlManager.ParameterCollection("CREACION").ToString
        Catch ex As Exception
            obeProveedor.CREACION = "FALSE"
        End Try
        Return obeProveedor
    End Function
    Public Function EliminarRelacionTercero_x_Cliente(ByVal obeProveedor As TYPEDEF.beProveedor) As Int32
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim retorno As Int32 = 0
        Try
            objParam.Add("IN_CCLNT", obeProveedor.CCLNT_CodigoCliente)
            objParam.Add("IN_CPRVCL", obeProveedor.CPRVCL_CodClienteTercero)
            objParam.Add("IN_STPORL", obeProveedor.PSSTPORL)
            objParam.Add("IN_USUARI", obeProveedor.CULUSA_UsuarioAct)
            objSqlManager.ExecuteNoQuery("SP_SOLMIN_SA_DEL_RELACION_CLIENTE_VS_TERCERO", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno


    End Function


    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_PROVEEDOR_LISTAR"
        SPUpdate = "SP_SOLMIN_SA_PROVEEDOR_UPDATE"
        SPInsert = "SP_SOLMIN_SA_PROVEEDOR_INSERT"
        SPDelete = "SP_SOLMIN_SA_PROVEEDOR_DELETE"
    End Sub



    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beProveedor)
        SetParameter(obj.PNCPRVCL)
        SetParameter(obj.PSTPRVCL)
        SetParameter(obj.PSTPRCL1)
        SetParameter(obj.PNNRUCPR)
        SetParameter(obj.PSTNACPR)
        SetParameter(obj.PSTDRPRC)
        SetParameter(obj.PNCPAIS)
        SetParameter(obj.PSTNROFX)
        SetParameter(obj.PSTLFNO1)
        SetParameter(obj.PSTEMAI2)
        SetParameter(obj.PSTPRSCN)
        SetParameter(obj.PSTLFNO2)
        SetParameter(obj.PSTEMAI3)
        SetParameter(obj.PNNDSDMP)
        SetParameter(obj.PSSESTRG)
        SetParameter(obj.PNFULTAC)
        SetParameter(obj.PNHULTAC)
        SetParameter(obj.PSCULUSA)
        SetParameter(obj.PSCUSCRT)
        SetParameter(obj.PNFCHCRT)
        SetParameter(obj.PNHRACRT)
        SetParameter(obj.PNUPDATE_IDENT)
    End Sub


    ''' <summary>
    ''' Obtener código del proveedor de acuerdo al código del cliente EN LA TABLA RZOL05A
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerCodigoProveedorPorCodCliente(ByVal obeProveedor As beProveedor) As Decimal

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim odt As New DataTable
        'Try
        objParam.Add("PNCCLNT", obeProveedor.PNCCLNT)
        objParam.Add("PNCPRPCL", obeProveedor.PSCPRPCL)
        objParam.Add("PNCPRVCL", 0, ParameterDirection.Output)
        objSqlManager.ExecuteNoQuery("SP_SOLMIN_OBTENER_PROVEEDOR_X_COD_PROVCLIENTE", objParam)
        Return objSqlManager.ParameterCollection("PNCPRVCL")
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function


    Public Sub ObtenerDatosProveedorPorCodCliente_RZOL05A(ByVal obeProveedor As beProveedor, ByRef IdProveedor As Decimal, ByRef RucProveedor As Decimal)

        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim odt As New DataTable

        'Dim IdProveedor As Decimal = 0
        'Try
        objParam.Add("PNCCLNT", obeProveedor.PNCCLNT)
        objParam.Add("PNCPRPCL", obeProveedor.PSCPRPCL)
        'objParam.Add("PNCPRVCL", 0, ParameterDirection.Output)
        odt = objSqlManager.ExecuteDataTable("SP_SOLMIN_OBTENER_PROVEEDOR_X_COD_PROVCLIENTE_RZOL05A", objParam)
        If odt.Rows.Count > 0 Then
            IdProveedor = odt.Rows(0)("CPRVCL")
            RucProveedor = odt.Rows(0)("NRUCPR")
        End If
        'Return IdProveedor
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Sub


    ''' <summary>
    ''' Grabar proveedores de clientes terceros
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GrabarProveedorDeCliente(ByVal obeProveedor As beProveedor) As Integer
        Dim objSqlManager As New SqlManager
        Dim retorno As Integer = 0
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", obeProveedor.PNCCLNT)
        objParam.Add("PSCPRPCL", obeProveedor.PSCPRPCL.Trim)
        objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL.Trim)
        objParam.Add("PSTPRCL1", obeProveedor.PSTPRCL1)
        objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC)
        objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
        objParam.Add("PSCUSCRT", obeProveedor.PSCUSCRT)
        objParam.Add("PNCPRVCL", 0, ParameterDirection.Output)

        objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_PROVEEDOR_DE_CLIENTE_INSERT", objParam)
        retorno = objSqlManager.ParameterCollection("PNCPRVCL")
        Return retorno
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

    Public Function GrabarProveedorDeCliente_v2(ByVal obeProveedor As beProveedor) As Integer
        Dim objSqlManager As New SqlManager
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeProveedor.PNCCLNT)
            objParam.Add("PSCPRPCL", obeProveedor.PSCPRPCL)

            If obeProveedor.PSTPRVCL.Trim.Length > 30 Then
                objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL.Trim.Substring(0, 30))
                objParam.Add("PSTPRCL1", obeProveedor.PSTPRVCL.Trim.Substring(30, obeProveedor.PSTPRVCL.Trim.Length - 30))
            Else
                objParam.Add("PSTPRVCL", obeProveedor.PSTPRVCL)
                objParam.Add("PSTPRCL1", obeProveedor.PSTPRCL1)
            End If

            If obeProveedor.PSTDRPRC.Trim.Length > 35 Then
                objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC.Trim.Substring(0, 35))
            Else
                objParam.Add("PSTDRPRC", obeProveedor.PSTDRPRC.Trim)
            End If
            objParam.Add("PSTPRSCN", obeProveedor.PSTPRSCN)
            objParam.Add("PSTNACPR", obeProveedor.PSTNACPR)
            objParam.Add("PSTLFNO1", obeProveedor.PSTLFNO1.Trim)
            objParam.Add("PSTLFNO2", obeProveedor.PSTLFNO2)
            objParam.Add("PSTEMAI2", obeProveedor.PSTEMAI2.Trim)
            objParam.Add("PSTEMAI3", obeProveedor.PSTEMAI3)
            objParam.Add("PNNRUCPR", obeProveedor.PNNRUCPR)
            objParam.Add("PSCUSCRT", obeProveedor.PSUSUARIO)
            objParam.Add("PNCPRVCL", 0, ParameterDirection.Output)

            'IN PNCCLNT NUMERIC(6, 0) ,
            'IN PSCPRPCL VARCHAR(15) ,
            'IN PSTPRVCL VARCHAR(30) ,
            'IN PSTPRCL1 VARCHAR(30) ,
            'IN PSTDRPRC VARCHAR(35) ,
            'IN PSTPRSCN VARCHAR(40) ,
            'IN PSTNACPR VARCHAR(30) ,
            'IN PSTLFNO1 VARCHAR(15) ,
            'IN PSTLFNO2 VARCHAR(15) ,
            'IN PSTEMAI2 VARCHAR(40) ,
            'IN PSTEMAI3 VARCHAR(40) ,
            'IN PNNRUCPR NUMERIC(15, 0) ,
            'IN PSCUSCRT VARCHAR(10) ,
            'OUT PNCPRVCL NUMERIC(6, 0) 


            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_PROVEEDOR_DE_CLIENTE_INSERT_TXT", objParam)

            Return objSqlManager.ParameterCollection("PNCPRVCL")

        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Funcion desarrollada para Outotec
    ''' </summary>
    ''' <param name="obeProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function flistTipoClienteTercero(ByVal obeProveedor As TYPEDEF.beProveedor) As List(Of TYPEDEF.beProveedor)

        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olbeProveedor As New List(Of TYPEDEF.beProveedor)
        Dim objParam As New Parameter
        Try
            objParam.Add("IN_CCLNT", obeProveedor.PNCCLNT)
            objParam.Add("IN_NRUCPR", obeProveedor.PNNRUCPR)
            Return Listar("SP_SOLMIN_SA_TIPO_CLIENTE_TERCERO", objParam)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Listar_proveedor_X_RUC(PSNRUCPR As String) As DataTable
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("PSNRUCPR", PSNRUCPR)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_OBTENER_PROVEEDOR_X_RUC_PROVEEDOR", objParam)
        Return dt

    End Function



    'Public Function ValidarCarga_Proveedor_x_RUC(PSNRUCPR As String) As DataTable
    '    Dim objSqlManager As New SqlManager
    '    Dim objParam As New Parameter
    '    Dim dt As New DataTable
    '    objParam.Add("PSNRUCPR", PSNRUCPR)
    '    dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_OBTENER_PROVEEDOR_X_RUC_PROVEEDOR", objParam)
    '    Return dt

    'End Function

    Public Function ValidarCarga_Proveedor_ImportExcel(pTipoValidacion As String, pRucProv As String, pCodCliente As Decimal, pCodProvCliente As String, ByRef IdProveedor As Decimal) As String
        Dim objSqlManager As New SqlManager
        Dim objParam As New Parameter
        Dim dt As New DataTable
        objParam.Add("TIPO_VALIDACION", pTipoValidacion)  ' RUC / COD_PROV
        objParam.Add("NRUCPROV", pRucProv)
        objParam.Add("CODCLIENTE", pCodCliente)
        objParam.Add("CODPROVCLIENTE", pCodProvCliente)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_ROVEEDOR_IMPORTEXCEL_MASIVO", objParam)
        Dim msg As String = ""
        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(13)
            End If
        Next
        msg = msg.Trim
        If msg = "" Then
            IdProveedor = dt.Rows(0)("CPRVCL")
        End If
        Return msg

    End Function



End Class
