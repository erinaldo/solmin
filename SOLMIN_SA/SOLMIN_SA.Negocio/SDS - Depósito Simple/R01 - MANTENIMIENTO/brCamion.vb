Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Imports RANSA.DATA
Namespace slnSOLMIN_SDS
   
    Public Class brCamion
        Dim objDACamion As New daCamion

        Public Function SP_SOLMIN_SA_SEL_CAMION(ByVal NPLCCM As String, ByVal CTRSP As String) As beCamion
            Return objDACamion.SP_SOLMIN_SA_SEL_CAMION(NPLCCM, CTRSP)
        End Function

        Public Function SP_SOLMIN_SA_INS_CAMION(ByVal objBECamion As beCamion) As Integer
            Return objDACamion.SP_SOLMIN_SA_INS_CAMION(objBECamion)
        End Function

        Public Function SP_SOLMIN_SA_UPD_CAMION(ByVal objBECamion As beCamion) As Boolean
            Return objDACamion.SP_SOLMIN_SA_UPD_CAMION(objBECamion)
        End Function
        Public Function ListarCamionxTransportista(ByVal obeCamionFiltro As beCamionFiltro) As List(Of beCamion)
            Return objDACamion.ListarCamionxTransportista(obeCamionFiltro)
        End Function
        Public Function EliminarCamion(ByVal obeCamion As beCamion) As Integer
            Return objDACamion.EliminarCamion(obeCamion)
        End Function

        Public Function flisListarCamionxTransportista(ByVal obeCamionFiltro As beCamionFiltro) As List(Of beCamion)
            Return objDACamion.flisListarCamionxTransportista(obeCamionFiltro)
        End Function


#Region "Mantenimiento AT"

        Public Function ListarUnidadxTransportistaAT(ByVal obeCamionFiltro As beCamion) As List(Of beCamion)
            Return objDACamion.ListarUnidadxTransportistaAT(obeCamionFiltro)
        End Function


        Public Function SP_SOLMIN_SA_SEL_CAMION_AT(ByVal NPLCUN As String, ByVal CTRSPT As String) As beCamion
            Return objDACamion.SP_SOLMIN_SA_SEL_CAMION_AT(NPLCUN, CTRSPT)
        End Function

        Public Function SP_SOLMIN_SA_UPD_CAMION_AT(ByVal objBECamion As beCamion) As Boolean
            Return objDACamion.SP_SOLMIN_SA_UPD_CAMION_AT(objBECamion)
        End Function

        Public Function SP_SOLMIN_SA_INS_CAMION_AT(ByVal objBECamion As beCamion) As Integer
            Return objDACamion.SP_SOLMIN_SA_INS_CAMION_AT(objBECamion)
        End Function


        Public Function EliminarCamion_AT(ByVal obeCamion As beCamion) As Integer
            Return objDACamion.EliminarCamion_AT(obeCamion)
        End Function




#End Region

















    End Class


End Namespace