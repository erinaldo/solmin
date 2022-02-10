Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsSeguimientoDocumentos

    Public Function ListaSeguimientoDocumentos(ByVal PSCCMPN As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SEGUIMIENTOS", lobjParams)
        Return dt
    End Function

    Public Function InsertaSeguimientoDocumentos(ByVal pobjSeguimiento As SeguimientoDocumentos) As Integer
        Try
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter

            lobjParams.Add("PSCCMPN", pobjSeguimiento.CCMPN)
            lobjParams.Add("PNCTPODC", pobjSeguimiento.CTPODC)
            lobjParams.Add("PNNDCCTC", pobjSeguimiento.NDCCTC)
            lobjParams.Add("PNCDSGDC", pobjSeguimiento.CDSGDC)
            lobjParams.Add("PNFDSGDC", pobjSeguimiento.FDSGDC)
            lobjParams.Add("PNHDSGDC", pobjSeguimiento.HDSGDC)
            lobjParams.Add("PSURSPDC", pobjSeguimiento.URSPDC)
            lobjParams.Add("PSTOBSSG", pobjSeguimiento.TOBSSG)
            lobjParams.Add("PSCUSCRT", pobjSeguimiento.CUSCRT)
            lobjParams.Add("PSNTRMCR", pobjSeguimiento.NTRMCR)
            lobjParams.Add("PNNRSGDC", pobjSeguimiento.NRSGDC)

            lobjSql.ExecuteNonQuery("SP_SOLCT_INSERTA_CONTROL_DOCUMENTOS", lobjParams)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListaSeguimientoPorDocumento(ByVal PNNDCCTC As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNDCCTC", PNNDCCTC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_SEGUIMIENTO_POR_DOCUMENTO", lobjParams)
        Return dt
    End Function
End Class
