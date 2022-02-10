Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daLoteDeMercaderia

    Inherits daBase(Of beLoteDeMercaderia)
    Private objSql As New SqlManager
    Public Function InsertarLoteMercaderia(ByVal obeLote As beLoteDeMercaderia) As beLoteDeMercaderia
        'Try
        Dim objParam As New Parameter
        objParam.Add("PNNORDSR", obeLote.PNNORDSR)
        objParam.Add("PNCCLNT", obeLote.PNCCLNT)
        objParam.Add("PNCPRVCL", obeLote.PNCPRVCL)
        objParam.Add("PSNDCMPV", obeLote.PSNDCMPV)
        objParam.Add("PNCMNCT", obeLote.PNCMNCT)
        objParam.Add("PNQIMCT", obeLote.PNQIMCT)
        objParam.Add("PNIMPTTL", obeLote.PNIMPTTL)
        objParam.Add("PNCMNVTA", obeLote.PNCMNVTA)
        objParam.Add("PNIMPVTA", obeLote.PNIMPVTA)
        objParam.Add("PNFINGAL", obeLote.PNFINGAL)
        objParam.Add("PNFPRDMR", obeLote.PNFPRDMR)
        objParam.Add("PNFVNLTE", obeLote.PNFVNLTE)
        objParam.Add("PNNTRNO", obeLote.PNNTRNO)
        objParam.Add("PSTOBSCR", obeLote.PSTOBSCR)
        objParam.Add("PSCRTLTE", obeLote.PSCRTLTE)
        objParam.Add("PSNTONCL", obeLote.PSNTONCL)
        objParam.Add("PSNCALCL", obeLote.PSNCALCL)
        objParam.Add("PNQDSMC2", obeLote.PNQDSMC2)
        objParam.Add("PNQDSMP2", obeLote.PNQDSMP2)
        objParam.Add("PNQMRCSL", obeLote.PNQMRCSL)
        objParam.Add("PNQPSOSL", obeLote.PNQPSOSL)
        objParam.Add("PNQCMMC1", obeLote.PNQCMMC1)
        objParam.Add("PNQCMMP1", obeLote.PNQCMMP1)
        objParam.Add("PSSTRNSM", obeLote.PSSTRNSM)
        objParam.Add("PNFTRNSM", obeLote.PNFTRNSM)
        objParam.Add("PNHTRNSM", obeLote.PNHTRNSM)
        objParam.Add("PSCULUSA", obeLote.PSCULUSA)
        objParam.Add("PNQTRMC", obeLote.PNQTRMC)
        objParam.Add("PNQTRMP", obeLote.PNQTRMP)
        objParam.Add("PSCTPOAT", obeLote.PSCTPOAT)
        objParam.Add("PNNGUIRN", obeLote.PNNGUIRN)
        objParam.Add("PNNSLCS1", obeLote.PNNSLCS1)
        objParam.Add("PNFDSPAL", obeLote.PNFDSPAL)
        objParam.Add("PNIMTITE", obeLote.PNIMTITE)
        objParam.Add("PNIMPVEN", obeLote.PNIMPVEN)
        objParam.Add("PSCTPALM", obeLote.PSCTPALM)
        objParam.Add("PSCALMC", obeLote.PSCALMC)
        objParam.Add("PSCZNALM", obeLote.PSCZNALM)
        objParam.Add("CREACION", "", ParameterDirection.Output)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_SDS_INSERTAR_LOTE_MERCADERIA", objParam)
        obeLote.CREACION = objSql.ParameterCollection("CREACION").ToString()
        Return obeLote
        'Catch ex As Exception
        '    Return obeLote
        'End Try
    End Function

    Public Function ListarLoteMercaderia_x_OrdenServicio(ByVal obeLoteFiltro As beLoteDeMercaderiaFiltro) As List(Of beLoteDeMercaderia)

        Dim obeLoteMercaderia As New List(Of beLoteDeMercaderia)
        Dim objParam As New Parameter
        'Try
        objParam.Add("PNNORDSR", obeLoteFiltro.PNNORDSR)
        Return Listar("SP_SOLMIN_SA_SDS_LISTAR_LOTE_MERCADERIA_X_OS", objParam)
        'Catch ex As Exception
        'End Try
        Return obeLoteMercaderia
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TypeDef.beLoteDeMercaderia)

    End Sub

End Class