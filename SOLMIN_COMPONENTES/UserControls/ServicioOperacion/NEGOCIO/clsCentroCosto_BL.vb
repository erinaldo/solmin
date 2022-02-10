
Public Class clsCentroCosto_BL
    Private oCentroCostos As New clsCentroCosto_DAL
    'Public Function Lista_CentroBeneficio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
    '                                 ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
    '                                 ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto_BE)

    '    Return oCentroCostos.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, _
    '                                            codSedeSAP, codUnidadProductivaSAP, tipoCentroSAP)
    'End Function

    Public Function Lista_CentroBeneficio_Tokio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                    ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                    ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto_BE)

        Return oCentroCostos.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, _
                                                codSedeSAP, codUnidadProductivaSAP, tipoCentroSAP)
    End Function

    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Public Function Listar_CentroCosto_Origen_Tarifa(ByVal pstrCompania As String) As List(Of CentroCosto_BE)
        Return oCentroCostos.Listar_CentroCosto_Origen_Tarifa(pstrCompania)
    End Function

    Public Function Listar_CentroCosto_Destino_Tarifa(ByVal pstrCompania As String, ByVal pdblCentroBeneficio As Double) As List(Of CentroCosto_BE)
        Return oCentroCostos.Listar_CentroCosto_Destino_Tarifa(pstrCompania, pdblCentroBeneficio)
    End Function

End Class
