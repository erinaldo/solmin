Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF

Public Class daSugerenciaMercaderia
    Inherits daBase(Of beSugerenciaMercaderia)


    Public Overrides Sub SetStoredprocedures()
        SPListar = "SP_SOLMIN_SA_SDS_LISTA_SUGERENCIA_UBICACION_MERCADERIA"
        SPUpdate = "SP_SOLMIN_SA_SDS_UPDATE_SUGERENCIA_UBICACION_MERCADERIA"
        SPDelete = "SP_SOLMIN_SA_SDS_DELETE_SUGERENCIA_UBICACION_MERCADERIA"
        SPInsert = "SP_SOLMIN_SA_SDS_INSERT_SUGERENCIA_UBICACION_MERCADERIA"

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TYPEDEF.beSugerenciaMercaderia)
        SetParameter(obj.PSCTPALM)
        SetParameter(obj.PSCALMC)
        SetParameter(obj.PSCPSLL)
        SetParameter(obj.PSCCLMN)
        SetParameter(obj.PSCPSCN)
        SetParameter(obj.PNCCLNT)
        SetParameter(obj.PSCFMCLR)
        SetParameter(obj.PSCGRCLR)
        SetParameter(obj.PSCMRCLR)
        SetParameter(obj.PNNCRPRD)
    End Sub
End Class
