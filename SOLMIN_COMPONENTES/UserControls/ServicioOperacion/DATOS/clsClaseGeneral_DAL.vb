Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsClaseGeneral_DAL
    '<[AHM]>
    Public Function Listar_Tipo_Servicio_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral_BE)
        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim oList As New List(Of ClaseGeneral_BE)
        Dim obeClaseGeneral_BE As ClaseGeneral_BE
        objParam.Add("PSCDSRSP", PSCDSRSP)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_TIPO_SERVICIO_SAP", objParam)
        For Each item As DataRow In dt.Rows
            obeClaseGeneral_BE = New ClaseGeneral_BE
            obeClaseGeneral_BE.CDTSSP = ("" & item("CDTSSP")).ToString.Trim
            'obeClaseGeneral_BE.TDTSSP = ("" & item("CDTSSP")).ToString.Trim
            obeClaseGeneral_BE.TDTSSP = ("" & item("TDTSSP")).ToString.Trim
            oList.Add(obeClaseGeneral_BE)
        Next
        Return oList
        'Return Listar("SP_SOLMIN_CT_LISTA_TIPO_SERVICIO_SAP", objParam)
     
    End Function

    Public Function Listar_Tipo_UnidadProductiva_SAP(ByVal PSCDSRSP As String) As List(Of ClaseGeneral_BE)

        Dim objParam As New Parameter
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim oList As New List(Of ClaseGeneral_BE)
        Dim obeClaseGeneral_BE As ClaseGeneral_BE
        objParam.Add("PSCDSRSP", PSCDSRSP)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_UNIDAD_PRODUCTIVA_SAP", objParam)
        For Each item As DataRow In dt.Rows
            obeClaseGeneral_BE = New ClaseGeneral_BE
            obeClaseGeneral_BE.CDSPSP = ("" & item("CDSPSP")).ToString.Trim
            obeClaseGeneral_BE.CDUPSP = ("" & item("CDUPSP")).ToString.Trim
            obeClaseGeneral_BE.TDUPSP = ("" & item("TDUPSP")).ToString.Trim
            oList.Add(obeClaseGeneral_BE)
        Next
        Return oList


        'Return Listar("SP_SOLMIN_CT_LISTA_UNIDAD_PRODUCTIVA_SAP", objParam)

    End Function

    'Public Function Listar_Tipo_UnidadProductiva_SAP_SEDEMACRO(ByVal PSCDSRSP As String, ByVal PSCDSPSP As String) As List(Of ClaseGeneral_BE)
    '    Dim objParam As New Parameter


    '    objParam.Add("PSCDSRSP", PSCDSRSP)
    '    objParam.Add("PSCDSPSP", PSCDSPSP)

    '    Return Listar("SP_SOLMIN_CT_LISTA_UNIDAD_PRODUCTIVA_SAP_X_SEDE_MACRO", objParam)

    'End Function



    Public Function Listar_Tipo_Activo_SAP() As List(Of ClaseGeneral_BE)

        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim oList As New List(Of ClaseGeneral_BE)
        Dim obeClaseGeneral_BE As ClaseGeneral_BE

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_LISTA_TIPO_ACTIVO_SAP", Nothing)
        For Each item As DataRow In dt.Rows
            obeClaseGeneral_BE = New ClaseGeneral_BE
            obeClaseGeneral_BE.PRCODI = ("" & item("PRCODI")).ToString.Trim
            obeClaseGeneral_BE.PRDESC = ("" & item("PRDESC")).ToString.Trim
            oList.Add(obeClaseGeneral_BE)
        Next
        Return oList

        'Return Listar("SP_SOLMIN_CT_LISTA_TIPO_ACTIVO_SAP", objParam)

    End Function
    '</[AHM]>
End Class
