Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.UbicacionPlanta.TipoMaterial

Namespace TipoMaterial

    Public Class daoTipoMaterial

        Public Function Lista_TipoMaterial(ByVal Valor) As List(Of beTipoMaterial)
            Dim oDt As DataTable
            Dim olbeTipoMaterial As New List(Of beTipoMaterial)
            Dim obeTipoMaterial As beTipoMaterial
            Dim lobjSql As New SqlManager
            Dim lobjParams As New Parameter
            Try
                lobjParams.Add("IN_CODVAR", Valor)
                oDt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_LISTA_CODVAR", lobjParams)

                obeTipoMaterial = New beTipoMaterial
                obeTipoMaterial.CCMPRN_CodigoTipoMaterial = "T"
                obeTipoMaterial.TDSDES_DescripcionTipoMaterial = "Todos"
                olbeTipoMaterial.Add(obeTipoMaterial)

                For Each objDataRow As DataRow In oDt.Rows
                    obeTipoMaterial = New beTipoMaterial
                    obeTipoMaterial.CCMPRN_CodigoTipoMaterial = objDataRow("CCMPRN").ToString.Trim
                    obeTipoMaterial.TDSDES_DescripcionTipoMaterial = objDataRow("TDSDES").ToString.Trim
                    olbeTipoMaterial.Add(obeTipoMaterial)
                Next
            Catch ex As Exception
            End Try
            Return olbeTipoMaterial
        End Function

    End Class

End Namespace
