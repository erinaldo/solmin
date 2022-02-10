Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daPedidoDeposito
    Inherits daBase(Of bePedidoDeposito)
    Private objSql As New SqlManager

    Public Function ListarConsultaPedidoDeposito(ByVal obePedidoDeposito As bePedidoDeposito) As List(Of bePedidoDeposito)
        Dim olbebePedidoDeposito As New List(Of bePedidoDeposito)
        Dim objParam As New Parameter
        Try
            With objParam
                .Add("IN_CCMPN", obePedidoDeposito.PSCCMPN)
                .Add("IN_CDVSN", obePedidoDeposito.PSCDVSN)
                .Add("IN_CCLNT", obePedidoDeposito.PNCCLNT)
                .Add("IN_FSLLAD_INI", obePedidoDeposito.PNFSLLADINI)
                .Add("IN_FSLLAD_FIN", obePedidoDeposito.PNFSLLADFIN)
                .Add("IN_CAGNAD", obePedidoDeposito.PNCAGNAD)
                .Add("IN_NPDDPA", obePedidoDeposito.PNNPDDPA)
                .Add("IN_NCNCEM", obePedidoDeposito.PSNCNCEM)
                .Add("IN_NFCTCM", obePedidoDeposito.PSNFCTCM)
                .Add("IN_NPDDPR", obePedidoDeposito.PNNPDDPR)
                .Add("IN_FECHA", obePedidoDeposito.PNFECHA)
                .Add("PAGESIZE", obePedidoDeposito.PageSize)
                .Add("PAGENUMBER", obePedidoDeposito.PageNumber)
                .Add("PAGECOUNT", 0, ParameterDirection.InputOutput)
            End With
            Return Listar("SP_SOLMIN_SA_LISTA_PEDIDO_DEPOSITO", objParam)

        Catch ex As Exception
            Return olbebePedidoDeposito
        End Try

    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.bePedidoDeposito)

    End Sub

End Class
