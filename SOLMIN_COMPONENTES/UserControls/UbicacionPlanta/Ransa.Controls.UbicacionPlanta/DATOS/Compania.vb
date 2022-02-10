Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.UbicacionPlanta.Compania

Namespace Compania

    Public Class daoCompania
        ''' <summary>
        ''' Listado de Companias que tiene acceso el usuario
        ''' </summary>
        ''' <returns>Lista de objetos</returns>
        ''' <remarks></remarks>
        Public Function Lista_Compania_X_Usuario(ByVal strUsuario) As List(Of beCompania)
            Dim oDt As DataTable
            Dim olbeCompania As New List(Of beCompania)
            Dim obeCompania As beCompania
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("PSMMCUSR", strUsuario)
                oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_COMPANIA_X_USUARIO", lobjParams)

                For Each objDataRow As DataRow In oDt.Rows
                    obeCompania = New beCompania
                    obeCompania.CCMPN_CodigoCompania = objDataRow("CCMPN").ToString.Trim
                    obeCompania.TCMPCM_DescripcionCompania = objDataRow("TCMPCM").ToString.Trim
                    olbeCompania.Add(obeCompania)
                Next
            Catch ex As Exception
            End Try
            Return olbeCompania

        End Function

    End Class

End Namespace
