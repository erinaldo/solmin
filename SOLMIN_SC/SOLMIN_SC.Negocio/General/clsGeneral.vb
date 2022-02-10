Public Class clsGeneral
    Public Function olistTipoOC() As DataTable
        Dim oDt As New DataTable
        oDt.Columns.Add("ID")
        oDt.Columns.Add("DESC")
        Dim odr As DataRow

        odr = oDt.NewRow()
        odr.Item("ID") = "LOC"
        odr.Item("DESC") = "LOCAL"
        oDt.Rows.Add(odr)

        odr = oDt.NewRow()
        odr.Item("ID") = "IMP"
        odr.Item("DESC") = "IMPORTACIÓN"
        oDt.Rows.Add(odr)

        odr = oDt.NewRow()
        odr.Item("ID") = "OTR"
        odr.Item("DESC") = "OTROS"
        oDt.Rows.Add(odr)

        Return oDt
    End Function

    Public Function olistFechasParaFiltro() As DataTable
        Dim oDt As New DataTable
        oDt.Columns.Add("ID")
        oDt.Columns.Add("DESC")
        Dim odr As DataRow

        odr = oDt.NewRow()
        odr.Item("ID") = "FORCML"
        odr.Item("DESC") = "Orden de Compra"
        oDt.Rows.Add(odr)

        odr = oDt.NewRow()
        odr.Item("ID") = "FMPDME"
        odr.Item("DESC") = "Estimada de Entrega"
        oDt.Rows.Add(odr)

   
        Return oDt
    End Function


    Public Sub RegistrarLog(ByVal oDatosLog As SOLMIN_SC.Entidad.BEDatosLog)
        Dim oclsGeneral As New SOLMIN_SC.Datos.clsTipoDatosGeneral
        oclsGeneral.RegistrarLog(oDatosLog)
    End Sub
    Public Sub RegistraEnvioRespuestaTracking(ByVal obeEnvioInterfazLog As SOLMIN_SC.Entidad.beEnvioInterfazLog)
        Dim oclsGeneral As New SOLMIN_SC.Datos.clsTipoDatosGeneral
        oclsGeneral.RegistraEnvioRespuestaTracking(obeEnvioInterfazLog)
    End Sub


End Class
