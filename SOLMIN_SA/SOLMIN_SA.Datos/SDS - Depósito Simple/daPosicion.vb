Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daPosicion

    Private objSql As New SqlManager

    Public Function ListarPosicionPorSector(ByVal opbePosicion As bePosicion) As List(Of bePosicion)
        Dim oDt As New DataTable
        Dim olbebePosicion As New List(Of bePosicion)
        Dim objParam As New Parameter
        Try
            objParam.Add("PNCCLNT", opbePosicion.PNCCLNT)
            objParam.Add("PSCTPALM", opbePosicion.PSCTPALM)
            objParam.Add("PSCALMC", opbePosicion.PSCALMC)
            objParam.Add("PSCMRCLR", opbePosicion.PSCMRCLR)

            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_SDS_LISTA_POSICION_POR_SECTOR_ALMACEN_POR_CLIENTE", objParam)
            For Each objDataRow As DataRow In oDt.Rows
                Dim obePosicion As New bePosicion
                obePosicion.PSSSCPOS = objDataRow("SSCPOS").ToString.Trim
                obePosicion.PSCTPALM = objDataRow("CTPALM").ToString.Trim
                obePosicion.PNCSRVPK = objDataRow("CSRVPK").ToString.Trim
                obePosicion.PSCROTMR = objDataRow("CROTMR").ToString.Trim
                obePosicion.PSCPSCN = objDataRow("CPSCN").ToString.Trim
                obePosicion.PSCALMC = objDataRow("CALMC").ToString.Trim
                obePosicion.PSCSECTR = objDataRow("CSECTR").ToString.Trim

                olbebePosicion.Add(obePosicion)
            Next
        Catch ex As Exception
        End Try
        Return olbebePosicion

    End Function


End Class