Imports Ransa.TypeDef
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class brOrdenDeCompra_DAL


    Private objSql As New SqlManager
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

        objSql.ExecuteNonQuery("SP_SOLMIN_SA_ORDEN_DE_COMPRA_INSERT", objParam)
        retorno = 1
        Return retorno

    End Function


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
        objParam.Add("OUTNRITOC", 0, ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_DETALLE_ORDEN_DE_COMPRA_INSERT_OUT", objParam)
        retorno = objSql.ParameterCollection.Item("OUTNRITOC")
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


End Class
