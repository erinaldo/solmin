Imports RANSA.TYPEDEF.Reportes
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daPreDespachoBulto

    ''' <summary>
    ''' Lista para reporte de ingreso por Almacen
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstPredespachoLectura(ByVal obeFiltro As bePreDespacho) As DataSet
        Dim oDt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSql As New SqlManager

        ' Ingresamos los parametros del Procedure 
        objParametros.Add("PSCCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("PSCDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeFiltro.PNCPLNDV)

        objParametros.Add("PNCCLNT", obeFiltro.PNCCLNT)
        objParametros.Add("PNPREDESPACHO", obeFiltro.PNPREDESPACHO)

        objParametros.Add("PNFECHAINI", obeFiltro.PNFECHAINI)
        objParametros.Add("PNFECHAFIN", obeFiltro.PNFECHAFIN)
        objParametros.Add("PSTIPOVISTA", obeFiltro.PSTIPOVISTA)
        Dim ds As New DataSet
        ds = objSql.ExecuteDataSet("SP_SOLMIN_SA_REPORTE_LISTAR_PREDESPACHOS_LECTURA", objParametros)

        If obeFiltro.PSTIPOVISTA = "BLT" Then
            For Each item As DataRow In ds.Tables(0).Rows
                item("F_LECT") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("F_LECT"))
                item("H_LECT") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("H_LECT"))

                item("FPREDESPACHO") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FPREDESPACHO"))

            Next
        End If

        If obeFiltro.PSTIPOVISTA = "PRED" Then
            For Each item As DataRow In ds.Tables(0).Rows
                item("FINI_LECT") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FINI_LECT"))
                item("FFIN_LECT") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FFIN_LECT"))
                item("HINI_LECT") = RANSA.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HINI_LECT"))
                item("HFIN_LECT") = RANSA.Utilitario.HelpClass.HoraNum_a_Hora_Default(item("HFIN_LECT"))

            

            Next
        End If
        Return ds



    End Function


    Public Function Listar_Paletizados_Todos(ByVal obeFiltro As bePreDespacho, NroPag As Decimal, PageSize As Decimal, ByRef TotPag As Decimal) As DataTable
        Dim oDt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSql As New SqlManager

        ' Ingresamos los parametros del Procedure
        objParametros.Add("PNCCLNT", obeFiltro.PNCCLNT)
        objParametros.Add("PSCCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("PSCDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("PNFECHAINI", obeFiltro.PNFECHAINI)
        objParametros.Add("PNFECHAFIN", obeFiltro.PNFECHAFIN)
        objParametros.Add("PSCREFFW", obeFiltro.PSCREFFW)
        objParametros.Add("PSNRPLTS", obeFiltro.PSNRPLTS)
        objParametros.Add("IN_NROPAG", NroPag)
        objParametros.Add("PAGESIZE", PageSize)
        Dim ds As New DataSet
        ds = objSql.ExecuteDataSet("SP_SOLMIN_SAT_LISTAR_PALETIZADOS", objParametros)
        TotPag = ds.Tables(1).Rows(0)("NUM_PAG")
        For Each item As DataRow In ds.Tables(0).Rows
            item("FELPLT") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FELPLT"))
        Next
        Return ds.Tables(0).Copy


    End Function




    Public Function Listar_Bultos_X_DetPaletizado(ByVal obeFiltro As bePreDespacho) As DataTable
        Dim oDt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSql As New SqlManager

        ' Ingresamos los parametros del Procedure
        objParametros.Add("PNCCLNT", obeFiltro.PNCCLNT)
        objParametros.Add("PNIDPALLET", obeFiltro.PNNROPLT)
        objParametros.Add("PSCCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("PSCDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("PNNSEQIN", obeFiltro.PNNSEQIN)

 
        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SAT_LISTAR_BULTOS_DETALLE_X_PALETIZADO", objParametros)

        Return dt

    End Function


    Public Function Listar_Bultos_X_Det_Formato01_Paletizado(ByVal obeFiltro As bePreDespacho) As DataTable
        Dim oDt As New DataTable
        Dim objParametros As Parameter = New Parameter
        Dim objSql As New SqlManager

        ' Ingresamos los parametros del Procedure
        objParametros.Add("PNCCLNT", obeFiltro.PNCCLNT)
        objParametros.Add("PNIDPALLET", obeFiltro.PNNROPLT)
        objParametros.Add("PSCCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("PSCDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("PNCPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("PNNSEQIN", obeFiltro.PNNSEQIN)


        Dim dt As New DataTable
        dt = objSql.ExecuteDataTable("SP_SOLMIN_SAT_LISTAR_BULTOS_DETALLE_F1_X_PALETIZADO", objParametros)
        For Each item As DataRow In dt.Rows
            item("FREFFW") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FREFFW"))
            item("FELPLT") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FELPLT"))

        Next

        Return dt

    End Function



End Class
