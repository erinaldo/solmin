Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class daPlantaClienteProveedor
    Inherits daBase(Of bePlantaClienteProveedor)
    Private objSql As New SqlManager

    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_LIST"
        SPUpdate = "SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_UPDATE"
        SPInsert = "SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_INSERT"
        SPDelete = "SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_DELETE"
    End Sub

    Public Function EliminarPlantaClienteTercero(ByVal obj As TYPEDEF.bePlantaClienteProveedor) As Integer
        Dim retorno As Int32 = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCPRVCL", obj.PNCPRVCL)
            objParam.Add("PNCPLCLP", obj.PNCPLCLP)
            objParam.Add("PSCULUSA", obj.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_DELETE", objParam)
            retorno = 1
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function

    Public Function fintInsertarPlantaClienteTercero(ByVal obj As TYPEDEF.bePlantaClienteProveedor) As Integer
        Dim retorno As Int32 = 0
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCPRVCL", obj.PNCPRVCL)
            objParam.Add("PSTCMPCP", obj.PSTCMPCP)
            objParam.Add("PSTDRPCP", obj.PSTDRPCP)
            objParam.Add("PSNRCLED", obj.PSNRCLED)
            objParam.Add("PSTDRDST", obj.PSTDRDST)
            objParam.Add("PSMAILDS", obj.PSMAILDS)
            objParam.Add("PSCRUTAT", obj.PSCRUTAT)
            objParam.Add("PNNCRRRT", obj.PNNCRRRT)
            objParam.Add("PSCZNAVN", obj.PSCZNAVN)
            objParam.Add("PSCVNDRC", obj.PSCVNDRC)
            objParam.Add("PSCCLTTM", obj.PSCCLTTM)
            objParam.Add("PNCUBGE2", obj.PNCUBGE2) '[JM]
            objParam.Add("PSCUSCRT", obj.PSCUSCRT)
            objParam.Add("PNFCHCRT", obj.PNFCHCRT)
            objParam.Add("PNHRACRT", obj.PNHRACRT)
            objParam.Add("PSCULUSA", obj.PSCULUSA)
            objParam.Add("PNFULTAC", obj.PNFULTAC)
            objParam.Add("PNHULTAC", obj.PNHULTAC)
            objParam.Add("PNCPLCLP", obj.PNCPLCLP, ParameterDirection.Output)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PLANTA_CLIENTE_TERCERO_INSERT", objParam)
            retorno = objSql.ParameterCollection.Item("PNCPLCLP")
        Catch ex As Exception
            retorno = 0
        End Try
        Return retorno
    End Function





    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.bePlantaClienteProveedor)
        SetParameter(obj.PNCPRVCL)
        SetParameter(obj.PNCPLCLP)
        SetParameter(obj.PSTCMPCP)
        SetParameter(obj.PSTDRPCP)
        SetParameter(obj.PSNRCLED)
        SetParameter(obj.PSTDRDST)
        SetParameter(obj.PSMAILDS)
        SetParameter(obj.PSCRUTAT)
        SetParameter(obj.PNNCRRRT)
        SetParameter(obj.PSCZNAVN)
        SetParameter(obj.PSCVNDRC)
        SetParameter(obj.PSCCLTTM)
        SetParameter(obj.PNCUBGE2) '[JM]
        SetParameter(obj.PSCUSCRT)
        SetParameter(obj.PNFCHCRT)
        SetParameter(obj.PNHRACRT)
        SetParameter(obj.PSCULUSA)
        SetParameter(obj.PNFULTAC)
        SetParameter(obj.PNHULTAC)
        SetParameter(obj.PSSESTRG)
        SetParameter(obj.PNUPDATE_IDENT)
    End Sub


    Public Function Listado_Planta_x_Cliente_Tercero(ByVal objParametros As List(Of String)) As DataTable
        Dim objDatatable As New DataTable
        Try
            Dim objParam As New Parameter
            objParam.Add("PARAM_CPRVCL", objParametros(0))

            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTADO_PLANTA_X_CLTE_TERCERO", objParam)

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
        Return objDatatable
    End Function

    'JM
    Public Function CargarUbigeo() As List(Of bePlantaClienteProveedor)
        Dim objDatatable As New DataTable
        Dim lista As New List(Of bePlantaClienteProveedor)
        Try
            Dim objParam As New Parameter
            objDatatable = objSql.ExecuteDataTable("SP_SOLMIN_SA_UBIGEO_LISTAR", objParam)
            For Each Item As DataRow In objDatatable.Rows
                Dim Entidad As New bePlantaClienteProveedor
                Entidad.PNCUBGE2 = Item("CUBGEO")
                Entidad.PSUBIGEO = Item("UBIGEO")
                lista.Add(Entidad)
            Next

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
        Return lista
    End Function



    Public Function Listado_Planta_x_Cliente_Tercero_RZOL05A(pCodCliente As Decimal, RUC As String, RAZON_SOCIAL As String, CodProvCliente As String, pNROPAG As Decimal, pPAGESIZE As Decimal, ByRef pCANT_PAG As Decimal) As DataTable
        Dim objDatatable As New DataTable
        Dim ds As New DataSet
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCLNT", pCodCliente)
        objParam.Add("PARAM_NRUCTR", RUC)
        objParam.Add("PARAM_TPRVCL", RAZON_SOCIAL)
        objParam.Add("PARAM_CODPROVCLIENTE", CodProvCliente)
        objParam.Add("IN_NROPAG", pNROPAG)
        objParam.Add("PAGESIZE", pPAGESIZE)



        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_CLIENTES_TERCEROS_X_PROVEEDOR_CMASIVO", objParam)
        objDatatable = ds.Tables(0).Copy

        If ds.Tables(1).Rows.Count > 0 Then
            pCANT_PAG = ds.Tables(1).Rows(0)("NUM_PAG")
        End If

        Return objDatatable
    End Function


    Public Function EliminarRelacionTercero_RZOL05A(pCodCliente As Decimal, pCodProvCliente As String) As String
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCLNT", pCodCliente)
        objParam.Add("PARAM_CPRPCL", pCodProvCliente)

        objParam.Add("PARAM_USUARIO", ConfigurationWizard.UserName)
        objParam.Add("PARAM_TERMINAL", ConfigurationWizard.NombreMaquina)


        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_ELIMINAR_RELACION_CLIENTES_TERCEROS_RZOL05A", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim

        Return msg
    End Function

    Public Function RegistrarRelacionTercero_Cmasivo_RZOL05A(pCodCliente As Decimal, RucProv As String, pCodProvCliente As String) As String
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objParam As New Parameter
        objParam.Add("PARAM_CCLNT", pCodCliente)
        objParam.Add("PARAM_NRUCPROV", RucProv)
        objParam.Add("PARAM_CPRPCL", pCodProvCliente)
        objParam.Add("PARAM_USUARIO", ConfigurationWizard.UserName)
        objParam.Add("PARAM_TERMINAL", ConfigurationWizard.NombreMaquina)


        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_REGISTRAR_CODPROVCLIENTE_CMASIVO_RZOL05A", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim

        Return msg
    End Function

    Public Function ValidarRUCProveedor_Cmasivo_RZOL05A(RucProv As String) As String
        Dim dt As New DataTable
        Dim msg As String = ""
        Dim objParam As New Parameter
        objParam.Add("PARAM_NRUCPROV", RucProv)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_RUCPROVEEDOR_CMASIVO_RZOL05A", objParam)

        For Each item As DataRow In dt.Rows
            If item("STATUS") = "E" Then
                msg = msg & item("OBSRESULT") & Chr(10)
            End If
        Next
        msg = msg.Trim

        Return msg
    End Function

    '

    

End Class
