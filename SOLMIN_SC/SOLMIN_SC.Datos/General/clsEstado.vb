Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsEstado

    Public Function Estado_CartaFianza() As DataTable

        Dim dtEstadoCF As New DataTable
        Dim drCF As DataRow
        dtEstadoCF.Columns.Add("VALUE")
        dtEstadoCF.Columns.Add("DISPLAY")
        drCF = dtEstadoCF.NewRow
        drCF("VALUE") = "V"
        drCF("DISPLAY") = "VIGENTE"
        dtEstadoCF.Rows.Add(drCF)

        drCF = dtEstadoCF.NewRow
        drCF("VALUE") = "C"
        drCF("DISPLAY") = "CERRADO"
        dtEstadoCF.Rows.Add(drCF)

        Return dtEstadoCF
    End Function
    Public Function Estado_Aduanero() As DataTable
        Dim objDr As DataRow
        Dim objTabla As New DataTable

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "EN ATENCION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "C"
        objDr.Item(1) = "CERRADA"
        objTabla.Rows.Add(objDr)

        Return objTabla
    End Function

    Public Function Listar_TipoOperacionEmbarque() As DataTable
        Dim objTabla As New DataTable
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item("COD") = "IM"
        objDr.Item("TEX") = "IMPORTACION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item("COD") = "EX"
        objDr.Item("TEX") = "EXPORTACION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item("COD") = "NA"
        objDr.Item("TEX") = "LOCAL"
        objTabla.Rows.Add(objDr)

        Return objTabla.Copy
    End Function

    Public Function Listar_Status_Embarque() As DataTable
        Dim objTabla As New DataTable
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item("COD") = "1"
        objDr.Item("TEX") = "EN FABRICACION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item("COD") = "2"
        objDr.Item("TEX") = "EN EMBARCADOR"
        objTabla.Rows.Add(objDr)


        objDr = objTabla.NewRow
        objDr.Item("COD") = "3"
        objDr.Item("TEX") = "EN TRANSITO"
        objTabla.Rows.Add(objDr)


        objDr = objTabla.NewRow
        objDr.Item("COD") = "4"
        objDr.Item("TEX") = "EN DESPACHO DE ADUANAS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item("COD") = "5"
        objDr.Item("TEX") = "ENTREGADO"
        objTabla.Rows.Add(objDr)

        Return objTabla.Copy
    End Function


End Class
