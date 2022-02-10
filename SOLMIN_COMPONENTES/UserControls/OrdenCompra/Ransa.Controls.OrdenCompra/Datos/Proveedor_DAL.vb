Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class Proveedor_DAL

    Inherits daBase(Of TypeDef.beProveedor)

    Public Function fblnRegistrar_Proveedor_de_ABB(ByVal obeProveedor As TypeDef.beProveedor) As TypeDef.beProveedor
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

    Public Function ListarClienteTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As List(Of TypeDef.beProveedor)

        Dim oDt As New DataTable
        Dim objSqlManager As New SqlManager
        Dim olbeProveedor As New List(Of TypeDef.beProveedor)
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


    Public Function RegistrarRelacionTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As TypeDef.beProveedor

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
    Public Function EliminarRelacionTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As Int32
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


    Public Function ObtenerCodigoProveedorPorCodCliente(ByVal obeProveedor As TypeDef.beProveedor) As Decimal

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
    Public Function GrabarProveedorDeCliente_v2(ByVal obeProveedor As TypeDef.beProveedor) As Integer
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


            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_PROVEEDOR_DE_CLIENTE_INSERT_TXT", objParam)

            Return objSqlManager.ParameterCollection("PNCPRVCL")

        Catch ex As Exception
            Return 0
        End Try
    End Function

     

    Public Function GrabarProveedorDeCliente(ByVal obeProveedor As TypeDef.beProveedor) As Integer
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

    Public Function flistTipoClienteTercero(ByVal obeProveedor As TypeDef.beProveedor) As List(Of TypeDef.beProveedor)

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



    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(obj As TypeDef.beProveedor)

    End Sub
End Class
