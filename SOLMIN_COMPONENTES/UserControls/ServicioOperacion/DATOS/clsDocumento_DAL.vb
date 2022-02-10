
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsDocumento_DAL
    Private objSql As New SqlManager

    Public Function fintInsertarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oDocumento_BE.PNCCLNT)
            objParam.Add("PNNOPRCN", oDocumento_BE.NOPRCN)
            objParam.Add("PSCTIIMG", oDocumento_BE.PSCTIIMG)
            objParam.Add("PSTOBSMD", oDocumento_BE.PSTOBSMD)
            objParam.Add("PSTNMBAR", oDocumento_BE.PSTNMBAR)
            objParam.Add("PSURLARC", oDocumento_BE.PSURLARC)
            objParam.Add("PSCUSCRT", oDocumento_BE.PSCUSCRT)
            objParam.Add("PSCULUSA", oDocumento_BE.PSCULUSA)
            objParam.Add("PSSESTRG", oDocumento_BE.PSSESTRG)
            objParam.Add("PNNCRRDC", oDocumento_BE.PNNCRRDC, ParameterDirection.Output)
            objSql.ExecuteNonQuery("SP_SOLMIN_CT_DOCUMENTO_INSERT", objParam)
            Return objParam.Item(objParam.Count).Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function fintActualizarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As Integer
        Try
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", oDocumento_BE.PNCCLNT)
            objParam.Add("PNNOPRCN", oDocumento_BE.NOPRCN)
            objParam.Add("PNNCRRDC", oDocumento_BE.PNNCRRDC)
            objParam.Add("PSCTIIMG", oDocumento_BE.PSCTIIMG)
            objParam.Add("PSTOBSMD", oDocumento_BE.PSTOBSMD)
            objParam.Add("PSTNMBAR", oDocumento_BE.PSTNMBAR)
            objParam.Add("PSURLARC", oDocumento_BE.PSURLARC)
            objParam.Add("PSCULUSA", oDocumento_BE.PSCULUSA)
            objParam.Add("PSSESTRG", oDocumento_BE.PSSESTRG)
            objSql.ExecuteNonQuery("SP_SOLMIN_CT_DOCUMENTO_UPDATE", objParam)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function fdtListarDocumentoServicio(ByVal oDocumento_BE As Documento_BE) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", oDocumento_BE.PNCCLNT)
        objParam.Add("PNNOPRCN", oDocumento_BE.NOPRCN)
        objParam.Add("PNNCRRDC", oDocumento_BE.PNNCRRDC)
        objParam.Add("PSCTIIMG", oDocumento_BE.PSCTIIMG)
        Return objSql.ExecuteDataTable("SP_SOLMIN_CT_DOCUMENTO_LIST", objParam)
     

    End Function

    Public Function fintObtenerCorrelativo(ByVal oDocumento_BE As Documento_BE) As Decimal
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", oDocumento_BE.PNCCLNT)
            objParam.Add("PnNOPRCN", oDocumento_BE.NOPRCN)
            objParam.Add("PNNCRRDC", 0, ParameterDirection.InputOutput)
            objSql.ExecuteNonQuery("SP_SOLMIN_CT_DOCUMENTO_OBTENER_CORRELATIVO", objParam)
            Return objParam.Item(objParam.Count).Value
        Catch ex As Exception
            Return -1
        End Try

    End Function


  


End Class