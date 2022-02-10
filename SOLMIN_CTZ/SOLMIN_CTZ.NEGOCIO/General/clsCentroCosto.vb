Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Public Class clsCentroCosto
    Private oCentroCostos As SOLMIN_CTZ.DATOS.clsCentroCosto
    Private oDt As DataTable

    Sub New()
        oCentroCostos = New SOLMIN_CTZ.DATOS.clsCentroCosto
    End Sub

    Public Sub Crear_CentroCosto(ByVal strCompania As String)
        oDt = oCentroCostos.Lista_CentroCosto(strCompania)
    End Sub

    Public Function Lista() As DataTable
        Dim oDrNew As DataRow
        Dim intCont As Integer
        Dim oDtAux As DataTable

        oDtAux = oDt.Copy
        oDtAux.Rows.Clear()
        oDrNew = oDtAux.NewRow
        oDrNew.Item("CCNTCS") = 0
        oDrNew.Item("CCNBNS") = "------------------"
        oDtAux.Rows.Add(oDrNew)
        For intCont = 0 To oDt.Rows.Count - 1
            oDrNew = oDtAux.NewRow
            oDrNew.Item("CCNTCS") = oDt.Rows(intCont).Item("CCNTCS")
            oDrNew.Item("CCNBNS") = oDt.Rows(intCont).Item("CCNTCS") & " - " & oDt.Rows(intCont).Item("CCNBNS")
            oDtAux.Rows.Add(oDrNew)
        Next intCont

        Return oDtAux
    End Function


    Public Function Listar_CentroCosto() As List(Of CentroCosto)
        Dim oDrNew As DataRow
        Dim intCont As Integer
        Dim oDtAux As DataTable

        oDtAux = oDt.Copy
        oDtAux.Rows.Clear()
        'oDrNew = oDtAux.NewRow
        'oDrNew.Item("CCNTCS") = 0
        'oDrNew.Item("CCNBNS") = "------------------"
        'oDtAux.Rows.Add(oDrNew)
        For intCont = 0 To oDt.Rows.Count - 1
            oDrNew = oDtAux.NewRow
            oDrNew.Item("CCNTCS") = oDt.Rows(intCont).Item("CCNTCS")
            oDrNew.Item("CCNBNS") = oDt.Rows(intCont).Item("CCNTCS") & " - " & oDt.Rows(intCont).Item("CCNBNS")
            oDtAux.Rows.Add(oDrNew)
        Next intCont

        Dim objEntidad As CentroCosto
        Dim lbeCentroCosto As New List(Of CentroCosto)
        For Each objDataRow As DataRow In oDtAux.Rows
            objEntidad = New CentroCosto
            objEntidad.PNCCNTCS = objDataRow("CCNTCS").ToString.Trim()
            objEntidad.PSCCNBNS = objDataRow("CCNBNS").ToString.Trim()
            lbeCentroCosto.Add(objEntidad)
        Next

        Return lbeCentroCosto
    End Function

    '<[AHM]> - ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT - Cambio de nombe en el método
    Public Function Lista_CentroBeneficio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                      ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                      ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String) As List(Of CentroCosto)

        Return oCentroCostos.Lista_CentroBeneficio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, _
                                                codSedeSAP, codUnidadProductivaSAP, tipoCentroSAP)
    End Function

    Public Sub Lista_CentroBeneficio_Tokio(ByVal codCompania As String, ByVal codRegionVentaSAP As String, ByVal codMacroServicioSAP As String, _
                                     ByVal codTipoServicioSAP As String, ByVal codTipoActivoSAP As String, ByVal codSedeSAP As String, _
                                     ByVal codUnidadProductivaSAP As String, ByVal tipoCentroSAP As String, ByRef oCebePropio As CentroCosto, ByRef oCebeTercero As CentroCosto)

        oCentroCostos.Lista_CentroBeneficio_Tokio(codCompania, codRegionVentaSAP, codMacroServicioSAP, codTipoServicioSAP, codTipoActivoSAP, _
                                                codSedeSAP, codUnidadProductivaSAP, tipoCentroSAP, oCebePropio, oCebeTercero)
    End Sub

    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Public Function Listar_CentroCosto_Origen_Tarifa(ByVal pstrCompania As String) As List(Of CentroCosto)
        Return oCentroCostos.Listar_CentroCosto_Origen_Tarifa(pstrCompania)
    End Function

    Public Function Listar_CentroCosto_Destino_Tarifa(ByVal pstrCompania As String, ByVal pdblCentroBeneficio As Double) As List(Of CentroCosto)
        Return oCentroCostos.Listar_CentroCosto_Destino_Tarifa(pstrCompania, pdblCentroBeneficio)
    End Function

    Public Function Listar_CentroCosto_CeBe(ByVal pstrCompania As String, ByVal pdblCentroBeneficio As Double) As List(Of CentroCosto)
        Return oCentroCostos.Listar_CentroCosto_CeBe(pstrCompania, pdblCentroBeneficio)
    End Function
    Public Function Listar_CentroBeneficio_Id(ByVal pstrCompania As String, ByVal Cebe As Decimal) As List(Of CentroCosto)
        Return oCentroCostos.Listar_CentroBeneficio_Id(pstrCompania, Cebe)
    End Function
    '

    'RCS-HUNDRED-FIN





End Class
