'Imports Ransa.TypeDef.UbicacionPlanta.Division
Imports Db2Manager.RansaData.iSeries.DataObjects

Namespace Division

    Public Class daoDivision
        ''' <summary>
        ''' Lista de Division por Usuario
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Lista_Division_X_Usuario(ByVal strUsuario As String) As List(Of beDivision)
            Dim objDataTable As DataTable
            Dim olbeDivision As New List(Of beDivision)
            Dim obeDivision As beDivision
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSMMCUSR", strUsuario)
                objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_DIVISION_X_USUARIO", lobjParams)

                For Each objDataRow As DataRow In objDataTable.Rows
                    obeDivision = New beDivision
                    obeDivision.CDVSN_CodigoDivision = objDataRow("CDVSN").ToString.Trim
                    obeDivision.TCMPDV_DescripcionDivision = objDataRow("TCMPDV").ToString.Trim
                    obeDivision.CCMPN_CodigoCompania = objDataRow("CCMPN").ToString.Trim
                    olbeDivision.Add(obeDivision)
                Next
            Catch ex As Exception
            End Try
            Return olbeDivision
        End Function

        Public Function Lista_Division_X_Usuario_Y_Compania(ByVal strUsuario As String, ByVal compania As String) As DataTable
            Dim objDataTable As DataTable
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            lobjParams.Add("PSMMCUSR", strUsuario)
            lobjParams.Add("PSCCMPN", compania)
            objDataTable = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_DIVISION_X_USUARIO_NEW", lobjParams)

            Return objDataTable

        End Function




    End Class

End Namespace
