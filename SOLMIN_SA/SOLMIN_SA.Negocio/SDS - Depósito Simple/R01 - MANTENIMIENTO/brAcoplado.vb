Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA
Public Class brAcoplado
    Dim objDACamion As New daAcoplado

#Region "Mantenimiento AT"

    Public Function ListarAcopladoxTransportistaAT(ByVal obeAcopladoFiltro As beAcoplado) As List(Of beAcoplado)
        Return objDACamion.ListarAcopladoxTransportistaAT(obeAcopladoFiltro)
    End Function

    Public Function SP_SOLMIN_SA_SEL_ACOPLADO_AT(ByVal NPLCAC As String, ByVal CTRSPT As String) As beAcoplado
        Return objDACamion.SP_SOLMIN_SA_SEL_ACOPLADO_AT(NPLCAC, CTRSPT)
    End Function




    Public Function SP_SOLMIN_SA_INS_ACOPLADO_AT(ByVal objBEAcoplado As beAcoplado) As Integer
        Return objDACamion.SP_SOLMIN_SA_INS_ACOPLADO_AT(objBEAcoplado)
    End Function

    Public Function SP_SOLMIN_SA_UPD_ACOPLADO_AT(ByVal objBEAcoplado As beAcoplado) As Boolean
        Return objDACamion.SP_SOLMIN_SA_UPD_ACOPLADO_AT(objBEAcoplado)
    End Function


    Public Function EliminarAcopladoAT(ByVal objBEAcoplado As beAcoplado) As Integer
        Return objDACamion.EliminarAcopladoAT(objBEAcoplado)
    End Function

#End Region

End Class