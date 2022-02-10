Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsFleteMargen
    Dim objSql As New SqlManager


    Public Function ListaNegocioxCentroCosto(ByVal PSCCMPN As String, ByVal PNCCNTCS As Decimal) As DataTable

        Dim objParam As New Parameter
        Dim oDt As New DataTable
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNCCNTCS", PNCCNTCS)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_NEGOCIO_X_CENTROCOSTO", objParam)
        Return oDt

    End Function


    Public Sub ListaMargenPemitidoxNegocio(ByVal PSCCMPN As String, ByVal PSCRGVTA As String, ByRef MARGEN As Decimal, ByRef DebeValidar As Boolean)
        DebeValidar = False
        Dim objParam As New Parameter
        Dim dtMargen As New DataTable
        Dim MargenPor As Decimal = 0
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        dtMargen = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TIPO_LIBERACIONES_X_OS", Nothing)
        Dim drRet() As DataRow
        drRet = dtMargen.Select("CCMPN='" & PSCCMPN & "' AND CRGVTA='" & PSCRGVTA & "'")
        If drRet.Length > 0 Then
            MargenPor = drRet(0)("MRGVAL")
            DebeValidar = True
        End If
        'Return MargenPor
    End Sub

    Public Function ListaServicioMercaderiaValidacion(ByVal PSCCMPN As String, ByVal PNRTFSV As Decimal, ByVal PNNRCTSL As Decimal, ByVal MargenNegocio As Decimal) As DataTable
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        'objParam.Add("PNNCTZCN", PNNCTZCN)
        'objParam.Add("PNNCRRCT", PNNCRRCT)

        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNNRTFSV", PNRTFSV)
        objParam.Add("PNNRCTSL", PNNRCTSL)


        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        ' oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_MERCADERIA_VALIDACION", objParam)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_MERCADERIA_VALIDACION_V2", objParam)
        oDt = FormatMargenPorcentualNegocio(oDt, MargenNegocio)
        Return oDt
    End Function


    Private Function FormatMargenPorcentualNegocio(ByVal dtServicios As DataTable, ByVal MargenNegocio As Decimal) As DataTable
        dtServicios.Columns.Add("MONTOCOBRO_SOLES", Type.GetType("System.Decimal"))
        dtServicios.Columns.Add("MONTOPAGO_SOLES", Type.GetType("System.Decimal"))
        dtServicios.Columns.Add("DIF_SOLES", Type.GetType("System.Decimal"))
        dtServicios.Columns.Add("MARGENPOR", Type.GetType("System.Decimal"))
        dtServicios.Columns.Add("MARCA")
        For Each Item As DataRow In dtServicios.Rows
            'MONEDA DE COBRO
            If Item("CMNTRN") = 1 Then
                Item("MONTOCOBRO_SOLES") = Item("ITRSRT")
            Else
                Item("MONTOCOBRO_SOLES") = Item("ITRSRT") * Item("TIPO_CAMBIO")
            End If
            'MONEDA DE PAGO
            If Item("CMNLQT") = 1 Then
                Item("MONTOPAGO_SOLES") = Item("ILSFTR")
            Else
                Item("MONTOPAGO_SOLES") = Item("ILSFTR") * Item("TIPO_CAMBIO")
            End If
            'EVALUADO MARGEN CON RESPECTO AL COBRO
            If Item("MONTOCOBRO_SOLES") = 0 Then
                Item("MARGENPOR") = 0
            Else
                Item("MARGENPOR") = (Item("MONTOCOBRO_SOLES") - Item("MONTOPAGO_SOLES")) / Item("MONTOCOBRO_SOLES") * 100
                Item("MARGENPOR") = Math.Round(Item("MARGENPOR"), 2)
            End If
            Item("DIF_SOLES") = Math.Round((Item("MONTOCOBRO_SOLES") - Item("MONTOPAGO_SOLES")), 2)

            If Item("MARGENPOR") < MargenNegocio Then
                Item("MARCA") = "X" 'MARGENES POR DEBAJO DE LO PERMITIDO
                'OrdenServicioValidado = False
            Else
                Item("MARCA") = ""
            End If
        Next
        Return dtServicios
    End Function

    Public Function ListaServicioCentroCosto(ByVal PSCCMPN As String, ByVal PNRTFSV As Integer, ByVal PNNRCTSL As Decimal) As DataTable

        Dim objParam As New Parameter
        Dim oDt As New DataTable

        objParam.Add("PNNRTFSV", PNRTFSV)
        objParam.Add("PSCCMPN", PSCCMPN)
        objParam.Add("PNNRCTSL", PNNRCTSL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_MARGEN_OS", objParam)
        Return oDt

    End Function
    Public Sub ActualizarEstadoOrdenServicio(ByVal obeOrdenServicio As OrdenServicioTransporte)
        Dim objParam As New Parameter
        'objParam.Add("PNNCTZCN", obeOrdenServicio.NCTZCN)
        'objParam.Add("PNNCRRCT", obeOrdenServicio.NCRRCT)

        objParam.Add("PNNORSRT", obeOrdenServicio.NORSRT)
        objParam.Add("PSSESTOS", obeOrdenServicio.SESTOS)
        objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
        objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)
        objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ESTADO_ORDEN_SERVICIO", objParam)
    End Sub

    '--------------------Nueva validadcion

    Public Function Listar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete, ByVal MargenNegocio As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", objEntidad.CCMPN)
        lobjParams.Add("PNNRCTSL", objEntidad.NRCTSL)
        lobjParams.Add("PNNRTFSV", objEntidad.NRTFSV)

        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_SERVICIO_TARIFA_MARGEN", lobjParams)
        dt = FormatMargenPorcentualNegocio(dt, MargenNegocio)
        Return dt
    End Function

    'Public Function ListaServicioCentroCostoTarifa(ByVal PSCCMPN As String, ByVal PNRTFSV As Integer) As DataTable

    '    Dim objParam As New Parameter
    '    Dim oDt As New DataTable
    '    objParam.Add("P_NRTFSV", PNRTFSV)
    '    objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(PSCCMPN)
    '    oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_SERVICIO_J2", objParam)
    '    Return oDt

    'End Function
End Class
