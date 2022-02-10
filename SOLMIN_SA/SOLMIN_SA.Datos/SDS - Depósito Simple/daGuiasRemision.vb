Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects


Namespace DespachoDSD
    Public Class daGuiasRemision
        Inherits daBase(Of beGuiaRemision)

        Dim objSql As New SqlManager

        Public Function fnListGuiasRemision(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter
            Try
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                If obeFiltroGuia.PSNGUIRM.Trim.Equals("") Then
                    objParam.Add("IN_NGUIRM", 0)
                Else
                    objParam.Add("IN_NGUIRM", Val(obeFiltroGuia.PSNGUIRM))
                End If

                objParam.Add("IN_FECINI", obeFiltroGuia.PNFECINI)
                objParam.Add("IN_FECFIN", obeFiltroGuia.PNFECFIN)
                objParam.Add("PAGESIZE", obeFiltroGuia.PageSize)
                objParam.Add("PAGENUMBER", obeFiltroGuia.PageNumber)
                objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)

                Return Listar("SP_SOLMIN_SA_GUIA_REMISION_LIST", objParam)
            Catch ex As Exception
                Return olbeGuiaRemision
            End Try
        End Function

#Region "DS"
        Public Function fnSelDetalleGuiaDS(ByVal obeFiltroGuia As beGuiaRemision) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter
            Try
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                Return Listar("SP_SOLMIN_SA_SDS_DETALLE_GUIA", objParam)
            Catch ex As Exception
                Return olbeGuiaRemision
            End Try
        End Function

        ''' <summary>
        ''' Anular guia de remision  de Deposito simple
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AnularGuiaDeRemisionDSD(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                objParam.Add("IN_USUARIO", obeFiltroGuia.PSCUSCRT)

                objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ANULAR_GUIA_REMISION", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        ''' <summary>
        ''' Elimina guia de remision  de Deposito simple
        ''' </summary>
        ''' <param name="obeFiltroGuia"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function EliminarGuiaDeRemisionDSD(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Try
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ELIMINAR_GUIA_REMISION", objParam)
                Return 1
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function fboolExisteGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As Integer
            Try
                Dim oDt As New DataTable
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_EXISTE_GUIA_REMISION", objParam)
                If oDt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function fboolExisteGuiaRemision_S(ByVal obeFiltroGuia As beGuiaRemision) As Int64
            Try
                Dim oDt As New DataTable
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                'objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                objParam.Add("IN_NGUIRS", obeFiltroGuia.PSNGUIRS)
                objParam.Add("IN_CTDGRM", obeFiltroGuia.PSCTDGRM)
                'oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_EXISTE_GUIA_REMISION", objParam)
                oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_EXISTE_GUIA_REMISION_S", objParam)
                If oDt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function fObtenerMaxInferiorGuiaRemision(ByVal obeFiltroGuia As beGuiaRemision) As beGuiaRemision
            Dim objFiltroGuia As beGuiaRemision = Nothing
            Try
                Dim dt As New DataTable
                Dim objParam As New Parameter
                objParam.Add("IN_CCLNT", obeFiltroGuia.PNCCLNT)
                objParam.Add("IN_NGUIRM", obeFiltroGuia.PSNGUIRM)
                dt = objSql.ExecuteDataTable("SP_SOLMIN_SA_OBTENER_MAXINF_GUIA_REMISION", objParam)
                If dt.Rows.Count > 0 Then
                    objFiltroGuia = New beGuiaRemision
                    objFiltroGuia.PSNGUIRM = dt.Rows(0)("NGUIRM")
                    objFiltroGuia.PNFGUIRM = dt.Rows(0)("FGUIRM")
                End If
            Catch ex As Exception
                objFiltroGuia = Nothing
            End Try
            Return objFiltroGuia
        End Function


       


#End Region


        Public Function fnSelObservacionGR(ByVal ht As Hashtable) As List(Of beGuiaRemision)
            Dim olbeGuiaRemision As New List(Of beGuiaRemision)
            Dim objParam As New Parameter
            Try
                objParam.Add("IN_CCLNT", ht("CCLNT"))
                objParam.Add("IN_NGUIRM", ht("NGUIRM"))
                Return Listar("SP_SOLMIN_SA_OBSERVACION_GR", objParam)
            Catch ex As Exception
                Return olbeGuiaRemision
            End Try
        End Function




        Public Overrides Sub SetStoredprocedures()

        End Sub

        Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beGuiaRemision)

        End Sub
    End Class
End Namespace

