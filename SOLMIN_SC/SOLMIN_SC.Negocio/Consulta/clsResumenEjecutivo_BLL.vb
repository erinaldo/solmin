Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.DATOS
Imports SOLMIN_SC.Entidad
Public Class clsResumenEjecutivo_BLL

    Public Function Inicializa(ByVal codplanta As Integer, ByVal strPlanta As String) As DataSet
        Dim ds As New DataSet("dsResumenEjecutivo")
        Dim dtPlanta As New DataTable("dt_Planta")
        dtPlanta.Columns.Add("CODIGO", System.Type.GetType("System.Int32"))
        dtPlanta.Columns.Add("PLANTA", System.Type.GetType("System.String"))
        Dim dr As DataRow = Nothing
        dr = dtPlanta.NewRow()
        dr("CODIGO") = codplanta
        dr("PLANTA") = strPlanta
        dtPlanta.Rows.Add(dr)
        ds.Tables.Add(dtPlanta)
        Return ds
    End Function

    Public Function ResumenAlmacenes(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim obj As New clsResumenEjecutivo
        Return obj.ResumenAlmacenes(pobjFiltro)
    End Function

    Public Function ResumenTransportes(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim obj As New clsResumenEjecutivo
        Return obj.ResumenTransportes(pobjFiltro)
    End Function

    Public Function ResumenSIL(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim obj As New clsResumenEjecutivo
        Return obj.ResumenSIL(pobjFiltro)
    End Function

    Public Function ResumenSIl_CargaInternacional(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim obj As New clsResumenEjecutivo
        Return obj.ResumenSIl_CargaInternacional(pobjFiltro)
    End Function

    Public Function ResumenCuentaCorriente(ByVal pobjFiltro As beResumenEjecutivo) As DataSet
        Dim obj As New clsResumenEjecutivo
        Return obj.ResumenCuentaCorriente(pobjFiltro)
    End Function
    Public Function Listar_PLANTAS_X_USUARIO(ByVal strUsuario As String, ByVal strCodCompania As String) As DataTable
        Dim obj As New clsResumenEjecutivo
        Return obj.Listar_PLANTAS_X_USUARIO(strUsuario, strCodCompania)
    End Function

End Class
