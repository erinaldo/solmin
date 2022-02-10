

Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daOrdenCompra
    Inherits daBase(Of beOrdenCompra)


    Private objSql As New SqlManager

    Public Function ListaPendienteRecepcionOrdenCompra(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        'Try
        objParam.Add("IN_CCLNT", obeOrdenCompra.pCCLNT_CodigoCliente)
        objParam.Add("IN_FORCML_IN", obeOrdenCompra.pFORCML_INI_FechaOCInicial)
        objParam.Add("IN_FORCML_FIN", obeOrdenCompra.pFORCML_FIN_FechaOCFin)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_PENDIENTE_RECEPCION_X_OC", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function ListaEmbarquePorOC(ByVal obeOc As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOc.PNCCLNT)
        objParam.Add("PSNORCML", obeOc.PSNORCML)
        If obeOc.PNNORSCI <> 0 Then
            objParam.Add("PNNORSCI", obeOc.PNNORSCI)
        End If
        Return Listar("SP_SOLMIN_SA_LISTA_EMBARQUE_POR_OC", objParam)
        'Catch ex As Exception
        '    Return New List(Of beOrdenCompra)
        'End Try
    End Function

    Public Function InsertarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Dim retorno As Integer = 0
        Dim Cadena As String
        Cadena = obeOrdenDeCompra.PSTDSCML
        If (Cadena.Length > 50) Then
            Cadena = Cadena.Substring(0, 49)
        End If


        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML.Trim)
        objParam.Add("PNCPRVCL", obeOrdenDeCompra.PNCPRVCL)
        objParam.Add("PSCPRPCL", obeOrdenDeCompra.PSCPRPCL)
        objParam.Add("PNFORCML", obeOrdenDeCompra.PNFORCML)
        objParam.Add("PNFROCMP", obeOrdenDeCompra.PNFROCMP)
        objParam.Add("PSTDSCML", Cadena)
        objParam.Add("PSTCTCST", obeOrdenDeCompra.PSTCTCST)
        objParam.Add("PSNSVP", obeOrdenDeCompra.PSNSVP)
        objParam.Add("PSTTINTC", obeOrdenDeCompra.PSTTINTC)
        objParam.Add("PSTPAGME", obeOrdenDeCompra.PSTPAGME)
        objParam.Add("PSTLUGEM", obeOrdenDeCompra.PSTLUGEM)
        objParam.Add("PSTDEFIN", obeOrdenDeCompra.PSTDEFIN)
        objParam.Add("PNIVCOTO", obeOrdenDeCompra.PNIVCOTO)
        objParam.Add("PNIVTOCO", obeOrdenDeCompra.PNIVTOCO)
        objParam.Add("PNIVTOIM", obeOrdenDeCompra.PNIVTOIM)
        objParam.Add("PNCMNDA1", obeOrdenDeCompra.PNCMNDA1)
        objParam.Add("PSNMONOC", obeOrdenDeCompra.PSNMONOC)
        objParam.Add("PSSFACTU", obeOrdenDeCompra.PSSFACTU)
        objParam.Add("PNFFACTU", obeOrdenDeCompra.PNFFACTU)
        objParam.Add("PSSTRANS", obeOrdenDeCompra.PSSTRANS)
        objParam.Add("PSNREFCL", obeOrdenDeCompra.PSNREFCL)
        objParam.Add("PSREFDO1", obeOrdenDeCompra.PSREFDO1)
        objParam.Add("PNFSOLIC", obeOrdenDeCompra.PNFSOLIC)
        objParam.Add("PSTCMAEM", obeOrdenDeCompra.PSTCMAEM)
        objParam.Add("PSTEMPFAC", obeOrdenDeCompra.PSTEMPFAC)
        objParam.Add("PSTNOMCOM", obeOrdenDeCompra.PSTNOMCOM)
        objParam.Add("PSCREGEMB", obeOrdenDeCompra.PSCREGEMB)
        objParam.Add("PSTPAISEM", obeOrdenDeCompra.PSTPAISEM)
        objParam.Add("PNCMEDTR", obeOrdenDeCompra.PNCMEDTR)
        objParam.Add("PNNTPDES", obeOrdenDeCompra.PNNTPDES)
        objParam.Add("PNFLGMAI", obeOrdenDeCompra.PNFLGMAI)
        objParam.Add("PSSFLGES", obeOrdenDeCompra.PSSFLGES)

        objParam.Add("PSTPRSCN", obeOrdenDeCompra.PSTPRSCN)
        objParam.Add("PSTLFNO2", obeOrdenDeCompra.PSTLFNO2)
        objParam.Add("PSTEMAI3", obeOrdenDeCompra.PSTEMAI3)

        objParam.Add("PSCUSCRT", obeOrdenDeCompra.PSCUSCRT)
        objParam.Add("PSCULUSA", obeOrdenDeCompra.PSCULUSA)
        objParam.Add("PSSESTRG", obeOrdenDeCompra.PSSESTRG)
        objParam.Add("PSTPOOCM", obeOrdenDeCompra.PSTPOOCM)
        objParam.Add("PSTDAITM", obeOrdenDeCompra.PSTDAITM)
        objParam.Add("PSPTCNDPG", obeOrdenDeCompra.PSTCNDPG)

        objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)

        'objSql.ExecuteNonQuery("SP_SOLMIN_SA_ORDEN_DE_COMPRA_INSERT", objParam)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_ORDEN_DE_COMPRA_INSERT_V2", objParam)

        retorno = 1
        Return retorno
       
    End Function

    Public Function ListarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        objParam.Add("PNCPRVCL", obeOrdenDeCompra.PNCPRVCL)
        objParam.Add("PSTTINTC", obeOrdenDeCompra.PSTTINTC)
        objParam.Add("PNFORCMI", obeOrdenDeCompra.PNFORCMI)
        objParam.Add("PNFORCMF", obeOrdenDeCompra.PNFORCMF)
        objParam.Add("PAGESIZE", obeOrdenDeCompra.PageSize)
        objParam.Add("PAGENUMBER", obeOrdenDeCompra.PageNumber)
        objParam.Add("PAGECOUNT", obeOrdenDeCompra.PageCount, ParameterDirection.Output)
        Return Listar("SP_SOLMIN_SA_ORDEN_DE_COMPRA_LIST", objParam)
        'Catch ex As Exception
        '    Return New List(Of beOrdenCompra)
        'End Try
    End Function

    Public Function ObtenerOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        olbebeOrdenDeCompra = Listar("SP_SOLMIN_SA_ORDE_DE_COMPRA_OBTENER", objParam)
        'Catch ex As Exception
        'End Try
        Return olbebeOrdenDeCompra
    End Function

    Public Function ListarOrdenDeCompraItems(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PNNGUIRN", obeOrdenDeCompra.PNGUIRN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_LISTAR_OC_ITEMS", objParam)
        For Each objDataRow As DataRow In oDt.Rows
            Dim objDatos As New beOrdenCompra
            objDatos.NROITEM = objDataRow("ROWNUMBER").ToString
            objDatos.CodOC = objDataRow("OC").ToString
            objDatos.PSCZNALM = objDataRow("CZNALM").ToString
            objDatos.PSCTPALM = objDataRow("CTPALM").ToString
            objDatos.PSTCMPAL = objDataRow("TCMPAL").ToString
            objDatos.PSCALMC = objDataRow("CALMC").ToString
            objDatos.PSTALMC = objDataRow("TALMC").ToString
            objDatos.PSCMRCLR = objDataRow("CMRCLR").ToString
            objDatos.PSTMRCD2 = objDataRow("TMRCD2").ToString
            objDatos.PSTMRCD3 = objDataRow("TMRCD3").ToString
            objDatos.CODPROV = objDataRow("COD_PRO").ToString
            objDatos.CODPROVOUT = objDataRow("TDSDES").ToString
            objDatos.PSNRUCPR = objDataRow("RUC_PRO").ToString
            objDatos.PSTPRVCL = objDataRow("NOM_PRO").ToString
            objDatos.PSCUNCN5 = objDataRow("CUNCN5").ToString
            objDatos.PNQTRMC = objDataRow("QTRMC")
            objDatos.PSTCMZNA = objDataRow("TCMZNA")


            olbebeOrdenDeCompra.Add(objDatos)
        Next
        'Catch ex As Exception
        'End Try
        Return olbebeOrdenDeCompra
    End Function

    Public Function ActualizarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PNCPRVCL", obeOrdenDeCompra.PNCPRVCL)
            objParam.Add("PSCPRPCL", obeOrdenDeCompra.PSCPRPCL)
            objParam.Add("PNFORCML", obeOrdenDeCompra.PNFORCML)
            objParam.Add("PNFROCMP", obeOrdenDeCompra.PNFROCMP)
            objParam.Add("PSTDSCML", obeOrdenDeCompra.PSTDSCML)
            objParam.Add("PSTCTCST", obeOrdenDeCompra.PSTCTCST)
            objParam.Add("PSNSVP", obeOrdenDeCompra.PSNSVP)
            objParam.Add("PSTTINTC", obeOrdenDeCompra.PSTTINTC)
            objParam.Add("PSTPAGME", obeOrdenDeCompra.PSTPAGME)
            objParam.Add("PSTLUGEM", obeOrdenDeCompra.PSTLUGEM)
            objParam.Add("PSTDEFIN", obeOrdenDeCompra.PSTDEFIN)
            objParam.Add("PNIVCOTO", obeOrdenDeCompra.PNIVCOTO)
            objParam.Add("PNIVTOCO", obeOrdenDeCompra.PNIVTOCO)
            objParam.Add("PNIVTOIM", obeOrdenDeCompra.PNIVTOIM)
            objParam.Add("PNCMNDA1", obeOrdenDeCompra.PNCMNDA1)
            objParam.Add("PSNMONOC", obeOrdenDeCompra.PSNMONOC)
            objParam.Add("PSSFACTU", obeOrdenDeCompra.PSSFACTU)
            objParam.Add("PNFFACTU", obeOrdenDeCompra.PNFFACTU)
            objParam.Add("PSSTRANS", obeOrdenDeCompra.PSSTRANS)
            objParam.Add("PSNREFCL", obeOrdenDeCompra.PSNREFCL)
            objParam.Add("PSREFDO1", obeOrdenDeCompra.PSREFDO1)
            objParam.Add("PNFSOLIC", obeOrdenDeCompra.PNFSOLIC)
            objParam.Add("PSTCMAEM", obeOrdenDeCompra.PSTCMAEM)
            objParam.Add("PSTEMPFAC", obeOrdenDeCompra.PSTEMPFAC)
            objParam.Add("PSTNOMCOM", obeOrdenDeCompra.PSTNOMCOM)
            objParam.Add("PSCREGEMB", obeOrdenDeCompra.PSCREGEMB)
            objParam.Add("PSTPAISEM", obeOrdenDeCompra.PSTPAISEM)
            objParam.Add("PNCMEDTR", obeOrdenDeCompra.PNCMEDTR)
            objParam.Add("PNNTPDES", obeOrdenDeCompra.PNNTPDES)
            objParam.Add("PNFLGMAI", obeOrdenDeCompra.PNFLGMAI)
            objParam.Add("PSSFLGES", obeOrdenDeCompra.PSSFLGES)
            objParam.Add("PSCUSCRT", obeOrdenDeCompra.PSCUSCRT)
            objParam.Add("PSCULUSA", obeOrdenDeCompra.PSCULUSA)
            objParam.Add("PSSESTRG", obeOrdenDeCompra.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_ORDE_DE_COMPRA_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
#Region "Mantenimiento Detalle OC"

    Public Function InsertarDetalleOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        'Try
        Dim retorno As Integer = 0
        Dim objParam As New Parameter
        objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
        objParam.Add("PNNRITOC", obeOrdenCompra.PNNRITOC)
        objParam.Add("PSTCITCL", obeOrdenCompra.PSTCITCL)
        objParam.Add("PSTCITPR", obeOrdenCompra.PSTCITPR)
        objParam.Add("PSTDITES", obeOrdenCompra.PSTDITES)
        objParam.Add("PSTDITIN", obeOrdenCompra.PSTDITIN)
        objParam.Add("PSCPTDAR", obeOrdenCompra.PSCPTDAR)
        objParam.Add("PSCODTPN", obeOrdenCompra.PSCODTPN)
        objParam.Add("PNQCNTIT", obeOrdenCompra.PNQCNTIT)
        'objParam.Add("PNQCNPEM", obeOrdenCompra.PNQCNPEM)
        'objParam.Add("PNQCNEMB", obeOrdenCompra.PNQCNEMB)
        'objParam.Add("PNQSDOIT", obeOrdenCompra.PNQSDOIT)
        'objParam.Add("PNQINEMP", obeOrdenCompra.PNQINEMP)
        objParam.Add("PSTUNDIT", obeOrdenCompra.PSTUNDIT)
        objParam.Add("PNIVUNIT", obeOrdenCompra.PNIVUNIT)
        objParam.Add("PNIVTOIT", obeOrdenCompra.PNIVTOIT)
        objParam.Add("PNFMPDME", obeOrdenCompra.PNFMPDME)
        objParam.Add("PNFMPIME", obeOrdenCompra.PNFMPIME)
        objParam.Add("PSTCTCST", obeOrdenCompra.PSTCTCST)
        objParam.Add("PSTLUGEN", obeOrdenCompra.PSTLUGEN)
        objParam.Add("PSTLUGOR", obeOrdenCompra.PSTLUGOR)
        objParam.Add("PSFLGPEN", obeOrdenCompra.PSFLGPEN)
        'objParam.Add("PNQCNRCP", obeOrdenCompra.PNQCNRCP)
        'objParam.Add("PNQCNDPC", obeOrdenCompra.PNQCNDPC)
        objParam.Add("PSSFLGES", obeOrdenCompra.PSSFLGES)
        'objParam.Add("PNQSTKIT", obeOrdenCompra.PNQSTKIT)
        objParam.Add("PNQTOLMIN", obeOrdenCompra.PNQTOLMIN)
        objParam.Add("PNQTOLMAX", obeOrdenCompra.PNQTOLMAX)
        objParam.Add("PNQCNVRS", obeOrdenCompra.PNQCNVRS)
        objParam.Add("PSTUNDCN", obeOrdenCompra.PSTUNDCN)
        objParam.Add("PSTRFRN", obeOrdenCompra.PSTRFRN)
        objParam.Add("PSTRFRNA", obeOrdenCompra.PSTRFRNA)
        objParam.Add("PSTRFRNB", obeOrdenCompra.PSTRFRNB)
        objParam.Add("PSTRFRN1", obeOrdenCompra.PSTRFRN1)
        objParam.Add("PSTRFRN2", obeOrdenCompra.PSTRFRN2)
        objParam.Add("PSTRFRN3", obeOrdenCompra.PSTRFRN3)
        objParam.Add("PSSESEND", obeOrdenCompra.PSSESEND)
        objParam.Add("PSCUSCRT", obeOrdenCompra.PSCUSCRT)
        objParam.Add("PSCULUSA", obeOrdenCompra.PSCULUSA)
        objParam.Add("PSSESTRG", obeOrdenCompra.PSSESTRG)
        'objParam.Add("OUTNRITOC", 0, ParameterDirection.Output)
        objParam.Add("PSNTRMNL", obeOrdenCompra.PSNTRMNL)

        Dim dt As New DataTable
        'objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_INSERT_OUT", objParam)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_INSERT_OUT_V2", objParam)

        'retorno = objSql.ParameterCollection.Item("OUTNRITOC")
        retorno = dt.Rows(0)("NRITOC")
        'Catch ex As Exception
        '    Return 0
        'End Try
        Return retorno
    End Function

    Public Function ActualizarDetalleOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML)
            objParam.Add("PNNRITOC", obeOrdenCompra.PNNRITOC)
            objParam.Add("PSTCITCL", obeOrdenCompra.PSTCITCL)
            objParam.Add("PSTCITPR", obeOrdenCompra.PSTCITPR)
            objParam.Add("PSTDITES", obeOrdenCompra.PSTDITES)
            objParam.Add("PSTDITIN", obeOrdenCompra.PSTDITIN)
            objParam.Add("PSCPTDAR", obeOrdenCompra.PSCPTDAR)
            objParam.Add("PSCODTPN", obeOrdenCompra.PSCODTPN)
            objParam.Add("PNQCNTIT", obeOrdenCompra.PNQCNTIT)
            objParam.Add("PNQCNPEM", obeOrdenCompra.PNQCNPEM)
            objParam.Add("PNQCNEMB", obeOrdenCompra.PNQCNEMB)
            objParam.Add("PNQSDOIT", obeOrdenCompra.PNQSDOIT)
            objParam.Add("PNQINEMP", obeOrdenCompra.PNQINEMP)
            objParam.Add("PSTUNDIT", obeOrdenCompra.PSTUNDIT)
            objParam.Add("PNIVUNIT", obeOrdenCompra.PNIVUNIT)
            objParam.Add("PNIVTOIT", obeOrdenCompra.PNIVTOIT)
            objParam.Add("PNFMPDME", obeOrdenCompra.PNFMPDME)
            objParam.Add("PNFMPIME", obeOrdenCompra.PNFMPIME)
            objParam.Add("PSTCTCST", obeOrdenCompra.PSTCTCST)
            objParam.Add("PSTLUGEN", obeOrdenCompra.PSTLUGEN)
            objParam.Add("PSTLUGOR", obeOrdenCompra.PSTLUGOR)
            objParam.Add("PSFLGPEN", obeOrdenCompra.PSFLGPEN)
            objParam.Add("PNQCNRCP", obeOrdenCompra.PNQCNRCP)
            objParam.Add("PNQCNDPC", obeOrdenCompra.PNQCNDPC)
            objParam.Add("PSSFLGES", obeOrdenCompra.PSSFLGES)
            objParam.Add("PNQSTKIT", obeOrdenCompra.PNQSTKIT)
            objParam.Add("PNQTOLMIN", obeOrdenCompra.PNQTOLMIN)
            objParam.Add("PNQTOLMAX", obeOrdenCompra.PNQTOLMAX)
            objParam.Add("PNQCNVRS", obeOrdenCompra.PNQCNVRS)
            objParam.Add("PSTUNDCN", obeOrdenCompra.PSTUNDCN)
            objParam.Add("PSTRFRN", obeOrdenCompra.PSTRFRN)
            objParam.Add("PSTRFRNA", obeOrdenCompra.PSTRFRNA)
            objParam.Add("PSTRFRNB", obeOrdenCompra.PSTRFRNB)
            objParam.Add("PSTRFRN1", obeOrdenCompra.PSTRFRN1)
            objParam.Add("PSTRFRN2", obeOrdenCompra.PSTRFRN2)
            objParam.Add("PSTRFRN3", obeOrdenCompra.PSTRFRN3)
            objParam.Add("PSSESEND", obeOrdenCompra.PSSESEND)
            objParam.Add("PSCUSCRT", obeOrdenCompra.PSCUSCRT)
            objParam.Add("PNFCHCRT", obeOrdenCompra.PNFCHCRT)
            objParam.Add("PNHRACRT", obeOrdenCompra.PNHRACRT)
            objParam.Add("PSCULUSA", obeOrdenCompra.PSCULUSA)
            objParam.Add("PNFULTAC", obeOrdenCompra.PNFULTAC)
            objParam.Add("PNHULTAC", obeOrdenCompra.PNHULTAC)
            objParam.Add("PSSESTRG", obeOrdenCompra.PSSESTRG)
            objParam.Add("PNUPDATE_IDENT", obeOrdenCompra.PNUPDATE_IDENT)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarDetalleOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        Try
            objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
            objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
            objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
            objParam.Add("PAGESIZE", obeOrdenCompra.PageSize)
            objParam.Add("PAGENUMBER", obeOrdenCompra.PageNumber)
            objParam.Add("PAGECOUNT", obeOrdenCompra.PageCount, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_LIST", objParam)
        Catch ex As Exception
            Return New List(Of beOrdenCompra)
        End Try
    End Function

    Public Function InsertarObservacionOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
            objParam.Add("PNNCRRLT", obeOrdenCompra.PNNCRRLT)
            objParam.Add("PSTNOTAS", obeOrdenCompra.PSTNOTAS)
            objParam.Add("PSCULUSA", obeOrdenCompra.PSCULUSA)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_OBSERVACION_ORDEN_DE_COMPRA_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function EliminarObservacionOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_OBSERVACION_ORDEN_DE_COMPRA_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Public Function ListarObservacionOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
    '    Dim oDt As New DataTable
    '    Dim olbebeOrdenCompra As New List(Of beOrdenCompra)
    '    Dim objParam As New Parameter
    '    Try
    '        objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
    '        objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML)
    '        Return Listar("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_LIST", objParam)
    '    Catch ex As Exception
    '        Return New List(Of beOrdenCompra)
    '    End Try
    'End Function

    ''' <summary>
    ''' Listado de orden de compra que muestra la cantidad pendiente, cantidad atendida.
    ''' </summary>
    ''' <param name="obeOrdenCompra"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarDetalleOrdenDeCompraPendientes(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
        objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
        objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
        objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML)
        objParam.Add("PSCREFFW", obeOrdenCompra.PSCREFFW)
        Return Listar("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_PENDIENTE_LIST", objParam)
        'Catch ex As Exception
        '    Return New List(Of beOrdenCompra)
        'End Try
    End Function





#End Region

#Region "Mantenimiento Detalle Pedido OC"
    Public Function InsertarDetalleOrdenDePedCompra(ByVal obeOrdenCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
            objParam.Add("PNNRITOC", obeOrdenCompra.PNNRITOC)
            objParam.Add("PSNRFRPD", obeOrdenCompra.PSNRFRPD)
            objParam.Add("PNQCNTIT", obeOrdenCompra.PNQCNTIT)
            objParam.Add("PSNTRMCR", obeOrdenCompra.PSNTRMCR)
            objParam.Add("PSNTRMNL", obeOrdenCompra.PSNTRMNL)
            objParam.Add("PSCUSCRT", obeOrdenCompra.PSCUSCRT)
            objParam.Add("PSCULUSA", obeOrdenCompra.PSCULUSA)
            objParam.Add("PSSESTRG", obeOrdenCompra.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_PED_ORDEN_DE_COMPRA_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "CUENTAS IMPUTACION POR ORDEN COMPRA "

    Public Function fintInsertarCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra, Optional ByRef _PNNSEQINOUT As Integer = 0) As Integer
        'Try
        Dim objParam As New Parameter
        Dim PNNSEQINOUT As Integer = 0
        objParam.Add("PNNSEQINOUT", 1, ParameterDirection.Output)
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        objParam.Add("PSTLUGEN", obeOrdenDeCompra.PSTLUGEN)
        objParam.Add("PNFINCVG", obeOrdenDeCompra.PNFECHAINI)
        objParam.Add("PNFFINVG", obeOrdenDeCompra.PNFECHAFIN)
        objParam.Add("PSTCTCST", obeOrdenDeCompra.PSTCTCST)
        objParam.Add("PSTCTCSA", obeOrdenDeCompra.PSTCTCSA)
        objParam.Add("PSTCTCSF", obeOrdenDeCompra.PSTCTCSF)
        objParam.Add("PSTCTAFE", obeOrdenDeCompra.PSTCTAFE)

        objParam.Add("PSCCNCOS", obeOrdenDeCompra.PSCCNCOS)
        objParam.Add("PSNORSAP", obeOrdenDeCompra.PSNORSAP)
        objParam.Add("PSNGFSAP", obeOrdenDeCompra.PSNGFSAP)
        objParam.Add("PSNCTAMA", obeOrdenDeCompra.PSNCTAMA)
        objParam.Add("PSNELPEP", obeOrdenDeCompra.PSNELPEP)



        objParam.Add("PNDISTR", obeOrdenDeCompra.PNDISTR)
        objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
        objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
        objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)

        'Alberto 26-10-2018
        objParam.Add("PSTCTCAL", obeOrdenDeCompra.PSTCTCAL)

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_INSERT_V3", objParam)

        PNNSEQINOUT = Convert.ToInt32(objParam.Item(1).Value)
        _PNNSEQINOUT = PNNSEQINOUT
        Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

    Public Function fintEliminaCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
            objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function flistListarCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        objParam.Add("PNNSEQIN", 0)
        Return Listar("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_LISTAR", objParam)
        'Catch ex As Exception
        'End Try
        'Return olbebeOrdenDeCompra
    End Function
    Public Function flistListCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        objParam.Add("PSTLUGEN", obeOrdenDeCompra.PSTLUGEN)
        objParam.Add("PNFINCVG", obeOrdenDeCompra.PNFECHAINI)
        objParam.Add("PNFFINVG", obeOrdenDeCompra.PNFECHAFIN)
        objParam.Add("PNDISTR", obeOrdenDeCompra.PNDISTR)
        objParam.Add("PAGESIZE", obeOrdenDeCompra.PageSize)
        objParam.Add("PAGENUMBER", obeOrdenDeCompra.PageNumber)
        objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

        Return Listar("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_LIST", objParam)
        'Catch ex As Exception
        '    Throw New Exception(ex.ToString)
        'End Try
        'Return olbebeOrdenDeCompra
    End Function
    Public Function flistObtenerCuentaImputacionOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNFECVIG)
        Return Listar("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_SELECT", objParam)
        'Catch ex As Exception
        'End Try
        'Return olbebeOrdenDeCompra
    End Function


    Public Function fintInsertarCuentaImputacionOrdenDeCompra_Excel(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNNSEQINOUT", 1, ParameterDirection.Output)
            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PSTLUGEN", obeOrdenDeCompra.PSTLUGEN)
            objParam.Add("PNFINCVG", obeOrdenDeCompra.PNFECHAINI)
            objParam.Add("PNFFINVG", obeOrdenDeCompra.PNFECHAFIN)
            objParam.Add("PSTCTCST", obeOrdenDeCompra.PSTCTCST)
            objParam.Add("PSTCTCSA", obeOrdenDeCompra.PSTCTCSA)
            objParam.Add("PSTCTCSF", obeOrdenDeCompra.PSTCTCSF)

            objParam.Add("PSTPIMSA", obeOrdenDeCompra.PSTPIMSA)
            objParam.Add("PSTPPOSA", obeOrdenDeCompra.PSTPPOSA)
            objParam.Add("PSCCNCOS", obeOrdenDeCompra.PSCCNCOS)
            objParam.Add("PSCCEBEN", obeOrdenDeCompra.PSCCEBEN)
            objParam.Add("PSNGFSAP", obeOrdenDeCompra.PSNGFSAP)
            objParam.Add("PSNORSAP", obeOrdenDeCompra.PSNORSAP)


            objParam.Add("PNDISTR", obeOrdenDeCompra.PNDISTR)
            objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
            objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
            objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_INSERT_V2", objParam)

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function




#End Region

#Region "CUENTAS IMPUTACION POR DISTRIBUCION "
    Public Function flistListCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim oDt As New DataTable
        Dim olbebeOrdenDeCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
        objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
        objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
        If obeOrdenDeCompra.PageSize <> 0 Then
            objParam.Add("PAGESIZE", obeOrdenDeCompra.PageSize)
            objParam.Add("PAGENUMBER", obeOrdenDeCompra.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
        End If
        Return Listar("SP_SOLMIN_SA_CUENTA_IMPUTACION_POR_DISTRIBUCION_LISTA", objParam)
        'Catch ex As Exception
        '    Throw New Exception(ex.ToString)
        ''End Try
        'Return olbebeOrdenDeCompra
    End Function

    Public Function fintInsertarCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
            objParam.Add("PNNCRRDT", obeOrdenDeCompra.PNNCRRDT)

            objParam.Add("PSTCTCST", obeOrdenDeCompra.PSTCTCST)
            objParam.Add("PSTCTCSA", obeOrdenDeCompra.PSTCTCSA)
            objParam.Add("PSTCTCSF", obeOrdenDeCompra.PSTCTCSF)
            objParam.Add("PSTCTAFE", obeOrdenDeCompra.PSTCTAFE)

            objParam.Add("PNIPRCTJ", obeOrdenDeCompra.PNIPRCTJ)
            objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
            objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_POR_DISTRIBUCION_INSERT", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function fintEliminaCuentaImputacionDistribucion(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PNNSEQIN", obeOrdenDeCompra.PNNSEQIN)
            objParam.Add("PNNCRRDT", obeOrdenDeCompra.PNNCRRDT)
            objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)
            objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_POR_DISTRIBUCION_DELETE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function finActualizarEstadoSeguimiento(ByVal olbeOrdenDeCompra As List(Of beOrdenCompra)) As Integer
        Try

            For Each obeOc As beOrdenCompra In olbeOrdenDeCompra
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obeOc.PNCCLNT)
                objParam.Add("PSNORCML", obeOc.PSNORCML)
                objParam.Add("PNNRITOC", obeOc.PNNRITOC)
                objParam.Add("PNNSEQIN", obeOc.PSFLGPEN)
                objParam.Add("PSUSUARIO", obeOc.PSUSUARIO)
                objParam.Add("PSNTRMNL", obeOc.PSNTRMNL)
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_ITEM_OC_ACTUALIZAR_ESTADO_SEGUIMIENTO", objParam)
            Next

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region

#Region "Reporte  "

#End Region

    Public Function fdtExportarOrdenDeCompraXFechaEntrega(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim oDt As New DataTable
        Dim olbebeOrdenCompra As New List(Of beOrdenCompra)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
        objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
        objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
        objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
        objParam.Add("PNCPRVCL", obeOrdenCompra.PNCPRVCL)
        objParam.Add("PNFMPDMI", obeOrdenCompra.PNFMPDMI)
        objParam.Add("PNFMPDMF", obeOrdenCompra.PNFMPDMF)
        Return objSql.ExecuteDataTable("SP_SOLMIN_SA_SAT_EXPORTAR_OC_X_FECHA_ENTREGA", objParam)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    Public Function fdtIndicadorTiempoEntregaProveedor(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", obeOrdenCompra.PSNORCML)
            .Add("IN_CPRVCL", obeOrdenCompra.PNCPRVCL)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_FORCMI", obeOrdenCompra.PNFORCMI)
            .Add("IN_FORCMF", obeOrdenCompra.PNFORCMF)
            .Add("IN_FMPDMI", obeOrdenCompra.PNFMPDMI)
            .Add("IN_FMPDMF", obeOrdenCompra.PNFMPDMF)
            .Add("IN_STATOC", obeOrdenCompra.PSSTATOC)
        End With
        'Try

        Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_PROVEEDOR", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

    'With objParametros
    '           .Add("IN_CCMPN", TD_Filtro.pCCMPN_Compania)
    '           .Add("IN_CDVSN", TD_Filtro.pCDVSN_Division)
    '           .Add("IN_CPLNDV", TD_Filtro.pCPLNDV_Planta)
    '           .Add("IN_CCLNT", TD_Filtro.pCCLNT_CodigoCliente)
    '           .Add("IN_NORCML", TD_Filtro.pNORCML_NroOrdenCompra)
    '           .Add("IN_CPRVCL", TD_Filtro.pCPRVCL_Proveedor)
    '           .Add("IN_FORCMI", TD_Filtro.pFORCMI_FechaOCInicial_Int)
    '           .Add("IN_FORCMF", TD_Filtro.pFORCMF_FechaOCFinal_Int)
    '           .Add("IN_FMPDMI", TD_Filtro.pFMPDMI_FechaCompInicial_Int)
    '           .Add("IN_FMPDMF", TD_Filtro.pFMPDMF_FechaCompFinal_Int)
    '           .Add("IN_STATOC", TD_Filtro.pSTATOC_StatusOC)
    '       End With

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beOrdenCompra)

    End Sub
    Public Function fdtIndicadorTiempoEntregaProveedor_v2(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", obeOrdenCompra.PSNORCML)
            .Add("IN_CPRVCL", obeOrdenCompra.PNCPRVCL)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_FORCMI", obeOrdenCompra.PNFORCMI)
            .Add("IN_FORCMF", obeOrdenCompra.PNFORCMF)
            .Add("IN_FMPDMI", obeOrdenCompra.PNFMPDMI)
            .Add("IN_FMPDMF", obeOrdenCompra.PNFMPDMF)
            .Add("IN_STATOC", obeOrdenCompra.PSSTATOC)
        End With
        'Try

        Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_X_PROVEEDOR_MODELO2", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

    Public Function fdsReporteAnualSegOC(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_ANIO", obeOrdenCompra.PNANIO)
        End With
        'Try

        Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_SEGUIMIENTO_OC_LOCAL_ANUAL", objParametros)
        'Catch ex As Exception
        '    Return New DataSet
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

    'GASTON
    Public Function CuentaImputacionOrdenDeCompraInsert(ByVal obeOrdenDeCompra As beOrdenCompra) As Integer
        Try
            Dim objParam As New Parameter

            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PSTLUGEN", obeOrdenDeCompra.PSTLUGEN)
            objParam.Add("PNFINCVG", obeOrdenDeCompra.PNFECHAINI)
            objParam.Add("PNFFINVG", obeOrdenDeCompra.PNFECHAFIN)
            objParam.Add("PSCCNCOS", obeOrdenDeCompra.PSCCNCOS)
            objParam.Add("PSNORSAP", obeOrdenDeCompra.PSNORSAP)
            objParam.Add("PSNGFSAP", obeOrdenDeCompra.PSNGFSAP)
            objParam.Add("PSTPPOSA", obeOrdenDeCompra.PSTPPOSA)
            objParam.Add("PSTPIMSA", obeOrdenDeCompra.PSTPIMSA)
            objParam.Add("PSNCTAMA", obeOrdenDeCompra.PSNCTAMA)
            objParam.Add("PSNELPEP", obeOrdenDeCompra.PSNELPEP)
            objParam.Add("PSNTRMNL", obeOrdenDeCompra.PSNTRMNL)
            objParam.Add("PSUSUARIO", obeOrdenDeCompra.PSUSUARIO)

            objSql.ExecuteNonQuery("SP_SOLMIN_SA_CUENTA_IMPUTACION_ORDEN_DE_COMPRA_INSERT_PPC", objParam)

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListCuentasImputacion(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            .Add("PSNORCML ", obeOrdenCompra.PSNORCML)

        End With
        'Try

        Return objSqlManager.ExecuteDataTable("SP_SOLIMIN_CUENTAS_IMPUTACION_LIST", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Public Function ObtenerValoresGrilla(ByVal ValorEnvio As String) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        objParam.Add("IN_CODVAR", ValorEnvio)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_CODVAR", objParam)
        Return oDt
    End Function


    Public Function ListaGuiaProveedor_OC(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        'Try
        objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
        objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
        objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
        objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
        objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML)
        objParam.Add("PSCREFFW", obeOrdenCompra.PSCREFFW)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_GUIA_PROV_X_OC", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDt
    End Function

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN 

End Class
