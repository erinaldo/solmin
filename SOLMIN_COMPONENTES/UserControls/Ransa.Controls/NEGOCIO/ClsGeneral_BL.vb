Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class ClsGeneral_BL

    Public Function fdtBuscar_TipoAlmacen(ByRef strMensajeError As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As New DataTable
        'SP_SOLMIN_CONTROL_BUSQ_TIPO_ALMACEN
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("ISTR_PARAM_001", strCadenaBusqueda)
        dtResultado = objSql.ExecuteDataTable("SP_SOLMIN_CONTROL_BUSQ_TIPO_ALMACEN", objParam)
        'dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_TIPALM_01", strCadenaBusqueda)
        dtResultado.TableName = "Tipo de Almacén"
        Return dtResultado
    End Function


    Public Function fdtBuscar_Almacen(ByRef strMensajeError As String, ByVal strTipoAlmacen As String, ByVal strCadenaBusqueda As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        'dtResultado = fdtResultadoBusqueda(strMensajeError, "GENE_ALMACE_01", strTipoAlmacen, strCadenaBusqueda)
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("ISTR_PARAM_001", strTipoAlmacen)
        objParam.Add("ISTR_PARAM_002", strCadenaBusqueda)
        dtResultado = objSql.ExecuteDataTable("SP_SOLMIN_CONTROL_BUSQ_ALMACEN", objParam)
        dtResultado.TableName = "Almacenes"
        Return dtResultado
    End Function


End Class
