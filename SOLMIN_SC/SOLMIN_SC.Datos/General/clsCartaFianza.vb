Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsCartaFianza
    Public Function Listar_Datos_Carta_Fianza(ByVal PNNORSCI As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", PNNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_CARTA_FIANZA", lobjParams)
        Return dt
    End Function

    Public Sub Mant_Carta_Fianza(ByVal obeCartaFianza As beCartaFianza)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PNNORSCI", obeCartaFianza.PNNORSCI)
        lobjParams.Add("PSNDOCUM", obeCartaFianza.PSNDOCUM)
        lobjParams.Add("PNCBNCFN", obeCartaFianza.PNCBNCFN)
        lobjParams.Add("PNFECEDC", obeCartaFianza.PNFECEDC)
        lobjParams.Add("PNFECVEN", obeCartaFianza.PNFECVEN)
        lobjParams.Add("PNITTDOC", obeCartaFianza.PNITTDOC)
        lobjParams.Add("PSNMONOC", obeCartaFianza.PSNMONOC)
        lobjParams.Add("PNCMNDA1", obeCartaFianza.PNCMNDA1)
        lobjParams.Add("PSSESFNZ", obeCartaFianza.PSSESFNZ)
        lobjParams.Add("PSTOBFNZ", obeCartaFianza.PSTOBFNZ)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_CARTA_FIANZA_V2", lobjParams)
    End Sub

End Class
