Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.UbicacionPlanta.Condicion

Namespace Condicion

    Public Class daoCondicion

        Public Function Lista_Condicion(ByVal Valor) As List(Of beCondicion)
            Dim oDt As DataTable
            Dim olbeCondicion As New List(Of beCondicion)
            Dim obeCondicion As beCondicion
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("IN_CODVAR", Valor)
                oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_CODVAR", lobjParams)

                obeCondicion = New beCondicion
                obeCondicion.CCMPRN_CodigoCondicion = "T"
                obeCondicion.TDSDES_DescripcionCondicion = "Todos"
                olbeCondicion.Add(obeCondicion)

                For Each objDataRow As DataRow In oDt.Rows
                    obeCondicion = New beCondicion
                    obeCondicion.CCMPRN_CodigoCondicion = objDataRow("CCMPRN").ToString.Trim
                    obeCondicion.TDSDES_DescripcionCondicion = objDataRow("TDSDES").ToString.Trim
                    olbeCondicion.Add(obeCondicion)
                Next
            Catch ex As Exception
            End Try
            Return olbeCondicion

        End Function

    End Class

End Namespace
