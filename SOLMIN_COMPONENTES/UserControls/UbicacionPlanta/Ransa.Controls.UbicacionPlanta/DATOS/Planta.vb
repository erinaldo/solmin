Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.UbicacionPlanta.Planta

Namespace Planta
    ''' <summary>
    ''' Lista de Planta por Usuario
    ''' </summary>
    ''' <remarks></remarks>
    Public Class daoPlanta
        Public Function Lista_Planta_X_Usuario(ByVal strUsuario As String) As List(Of bePlanta)
            Dim oDt As DataTable
            Dim olbePlanta As New List(Of bePlanta)
            Dim obePlanta As bePlanta
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSMMCUSR", strUsuario)
                oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_PLANTA_X_USUARIO", lobjParams)
                For Each objDataRow As DataRow In oDt.Rows
                    obePlanta = New bePlanta
                    obePlanta.TPLNTA_DescripcionPlanta = objDataRow("TPLNTA").ToString.Trim
                    obePlanta.CPLNDV_CodigoPlanta = objDataRow("CPLNDV").ToString.Trim
                    obePlanta.CDVSN_CodigoDivision = objDataRow("CDVSN").ToString.Trim
                    obePlanta.CCMPN_CodigoCompania = objDataRow("CCMPN").ToString.Trim
                    '<[AHM]>
                    obePlanta.CDSPSP_CodSedeSAP = objDataRow("CDSPSP").ToString.Trim
                    '</[AHM]>
                    olbePlanta.Add(obePlanta)
                Next
            Catch ex As Exception
            End Try
            Return olbePlanta
        End Function

        Public Function Lista_Planta_X_Nombre(ByVal strPlanta As String) As Integer

            Dim nCodigo As Integer = 0
            Dim htResultado As Hashtable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSTPLNTA", strPlanta)
                lobjParams.Add("PNCPLNDV", 0, ParameterDirection.Output)

                lobjSql.ExecuteNonQuery("SP_SOLMIN_SA_LISTA_PLANTA_X_NOMBRE", lobjParams)
                htResultado = lobjSql.ParameterCollection

                nCodigo = htResultado("PNCPLNDV")

            Catch ex As Exception
            End Try
            Return nCodigo
        End Function

        Public Function Lista_Planta_X_Usuario_All(ByVal strUsuario As String) As List(Of bePlanta)
            Dim oDt As DataTable
            Dim olbePlanta As New List(Of bePlanta)
            Dim obePlanta As bePlanta
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSMMCUSR", strUsuario)
                oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_PLANTA_X_USUARIO_ALL", lobjParams)
                For Each objDataRow As DataRow In oDt.Rows
                    obePlanta = New bePlanta
                    obePlanta.TPLNTA_DescripcionPlanta = objDataRow("TPLNTA").ToString.Trim
                    obePlanta.CPLNDV_CodigoPlanta = objDataRow("CPLNDV").ToString.Trim
                    obePlanta.CCMPN_CodigoCompania = objDataRow("CCMPN").ToString.Trim
                    '<[AHM]>
                    obePlanta.CDSPSP_CodSedeSAP = objDataRow("CDSPSP").ToString.Trim
                    '</[AHM]>
                    olbePlanta.Add(obePlanta)
                Next
            Catch ex As Exception
            End Try
            Return olbePlanta
        End Function
    End Class
End Namespace