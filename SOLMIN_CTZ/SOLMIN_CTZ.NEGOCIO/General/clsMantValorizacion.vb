Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
Public Class clsMantValorizacion
    Private oMantValorizacion As SOLMIN_CTZ.DATOS.clsManteniValorizacion
    Private oDt As DataTable

    Sub New()
        oMantValorizacion = New SOLMIN_CTZ.DATOS.clsManteniValorizacion
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Public Function Listar_MantValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim ds As New DataSet
        Dim dtVLR As New DataTable
        Dim dtEnvio As New DataTable
        Dim dtEnvio_x_VLR As New DataTable
        Dim pCCMPN As String = ""
        Dim pNROVLR As Decimal = 0
        Dim pFecha1 As Date
        Dim pFecha2 As Date
        Dim dr() As DataRow
        Dim drEnvio() As DataRow
        ds = oMantValorizacion.ListarManteniValorizacion(obeMantValorizacion)
        dtVLR = ds.Tables(0)
        dtVLR.Columns.Add("FENV_INI_RANSA")
        dtVLR.Columns.Add("FENV_INI_CLIENTE")
        dtVLR.Columns.Add("FAPROB_INI_CLIENTE")
        dtVLR.Columns.Add("QDTRANSCURRIDOS")
        dtVLR.Columns.Add("QDATRASADOS")
        dtVLR.Columns.Add("QDIASLIMITE")
        Dim FechaEnvioIniCalculo As String = ""
        dtEnvio = ds.Tables(1)
        For Each item As DataRow In dtVLR.Rows
            pCCMPN = item("CCMPN")
            pNROVLR = item("NROVLR")
            item("FENV_INI_RANSA") = ""
            item("FENV_INI_CLIENTE") = ""
            item("FAPROB_INI_CLIENTE") = ""
            item("QDTRANSCURRIDOS") = ""
            FechaEnvioIniCalculo = ""

            dr = dtEnvio.Select("CCMPN='" & pCCMPN & "' AND NROVLR='" & pNROVLR & "'")
            dtEnvio_x_VLR = HelpClass.RowToDatatable(dr, dtEnvio)
            drEnvio = dtEnvio_x_VLR.Select("COD_DESTINO='R'")
            item("FECHA_ACTUAL") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(item("FECHA_ACTUAL"))
            If drEnvio.Length > 0 Then
                item("FENV_INI_RANSA") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(drEnvio(0)("FCHASG"))
                FechaEnvioIniCalculo = item("FENV_INI_RANSA")
            End If
            drEnvio = dtEnvio_x_VLR.Select("COD_DESTINO='C'")
            If drEnvio.Length > 0 Then
                item("FENV_INI_CLIENTE") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(drEnvio(0)("FCHASG"))
                If FechaEnvioIniCalculo = "" Then
                    FechaEnvioIniCalculo = item("FENV_INI_CLIENTE")
                End If
            End If
            drEnvio = dtEnvio_x_VLR.Select("COD_DESTINO='C' AND ESTADO_APROB='A' ")
            If drEnvio.Length > 0 Then
                item("FAPROB_INI_CLIENTE") = Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(drEnvio(0)("FCHAPR"))
            End If
            If item("FAPROB_INI_CLIENTE") <> "" AndAlso FechaEnvioIniCalculo <> "" Then
                pFecha1 = Format(CDate(item("FAPROB_INI_CLIENTE")), "dd/MM/yyyy")
                pFecha2 = Format(CDate(FechaEnvioIniCalculo), "dd/MM/yyyy")
                item("QDTRANSCURRIDOS") = DateDiff(DateInterval.Day, pFecha2, pFecha1)
            End If
            If item("FAPROB_INI_CLIENTE") = "" AndAlso FechaEnvioIniCalculo <> "" Then
                pFecha1 = Format(CDate(FechaEnvioIniCalculo), "dd/MM/yyyy")
                pFecha2 = Format(CDate(item("FECHA_ACTUAL")), "dd/MM/yyyy")
                item("QDTRANSCURRIDOS") = DateDiff(DateInterval.Day, pFecha1, pFecha2)
                item("QDIASLIMITE") = 0
            End If
            If item("QDTRANSCURRIDOS") <> "" Then
                If Val("" & item("QDTRANSCURRIDOS")) > item("QDAPVL") Then
                    item("QDATRASADOS") = Val("" & item("QDTRANSCURRIDOS")) - item("QDAPVL")
                Else
                    item("QDATRASADOS") = 0
                End If
              
            End If

            If item("QDTRANSCURRIDOS") <> "" And item("FAPROB_INI_CLIENTE") = "" Then
                If Val("" & item("QDTRANSCURRIDOS")) <= item("QDAPVL") Then
                    item("QDIASLIMITE") = item("QDAPVL") - Val("" & item("QDTRANSCURRIDOS"))
                End If
            End If

          

        Next
        'QDIASLIMITE


        Return dtVLR



    End Function

    'Public Function Generar_MantValorizacion(ByVal oMantValorizacionUpd As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
    '    Return oMantValorizacion.Generar_MantValorizacion(oMantValorizacionUpd)
    'End Function

    Public Function RegistrarEnvioValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Return oMantValorizacion.RegistrarEnvioValorizacion(obeMantValorizacion)
    End Function

    Public Function RegistrarAprobacionValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Return oMantValorizacion.RegistrarAprobacionValorizacion(obeMantValorizacion)
    End Function
    Public Function Anular_MantValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Return oMantValorizacion.Anular_MantValorizacion(obeMantValorizacion)
    End Function

    Public Function AdicionarOper_MantValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Return oMantValorizacion.AdicionarOper_MantValorizacion(obeMantValorizacion)
    End Function

    Public Function EliminarOper_MantValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Return oMantValorizacion.EliminarOper_MantValorizacion(obeMantValorizacion)
    End Function

    Public Function EliminarOper_MantValorizacion_Op_List(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Return oMantValorizacion.EliminarOper_MantValorizacion_Op_List(obeMantValorizacion)
    End Function

    '

    'Public Function ListarOPxValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
    '    Dim dt As New DataTable
    '    Dim ColName As String = ""
    '    dt = oMantValorizacion.ListarOPxValorizacion(obeMantValorizacion)
    '    dt.Columns.Add("IMPORTE_S")
    '    dt.Columns.Add("IMPORTE_D")
    '    dt.Columns.Add("VISITADO")
    '    Dim Cantidad As Decimal = 0
    '    Dim Tarifa As Decimal = 0
    '    Dim SubImporteSol As Decimal = 0
    '    Dim SubImporteDol As Decimal = 0
    '    Dim drBusc() As DataRow
    '    Dim TipoOp As String = ""
    '    Dim Operacion As Decimal = 0
    '    Dim CodMeda As Decimal = 0
    '    Dim TCVenta As Decimal = 0
    '    Dim drVisitado() As DataRow
    '    Dim Vistado As Boolean = False
    '    For Each item As DataRow In dt.Rows
    '        TipoOp = item("TPOPER")
    '        Operacion = item("NOPRCN")
    '        CodMeda = item("COD_MONEDA")
    '        SubImporteSol = 0
    '        SubImporteDol = 0
    '        drBusc = dt.Select("TPOPER='" & TipoOp & "' AND NOPRCN='" & Operacion & "'")
    '        drVisitado = dt.Select("VISITADO='X' AND TPOPER='" & TipoOp & "' AND NOPRCN='" & Operacion & "'")
    '        Vistado = drVisitado.Length > 0
    '        If Vistado = 0 Then
    '            For Each itemOper As DataRow In drBusc
    '                Cantidad = itemOper("QATNAN")
    '                Tarifa = itemOper("IVLSRV")
    '                TCVenta = itemOper("TC_VENTA")
    '                'TC_VENTA
    '                If CodMeda = 1 Then
    '                    SubImporteSol = SubImporteSol + Math.Round(Cantidad * Tarifa, 5, MidpointRounding.AwayFromZero)
    '                    SubImporteDol = SubImporteDol + Math.Round(Cantidad * Tarifa / TCVenta, 5, MidpointRounding.AwayFromZero)
    '                End If
    '                If CodMeda = 100 Then
    '                    SubImporteSol = SubImporteSol + Math.Round(Cantidad * Tarifa * TCVenta, 5, MidpointRounding.AwayFromZero)
    '                    SubImporteDol = SubImporteDol + Math.Round(Cantidad * Tarifa, 5, MidpointRounding.AwayFromZero)
    '                End If
    '            Next
    '            item("VISITADO") = "X"
    '            item("IMPORTE_S") = SubImporteSol
    '            item("IMPORTE_D") = SubImporteDol
    '        End If
    '    Next

    '    Dim Visita As String = ""
    '    For i As Integer = dt.Rows.Count - 1 To 0 Step -1
    '        Visita = ("" & dt.Rows(i)("VISITADO"))
    '        If Visita = "" Then
    '            dt.Rows.RemoveAt(i)
    '        End If
    '    Next
    '    Return dt
    'End Function
    Public Function ListarOPxEnvioValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataSet
        Dim ds As New DataSet
        Dim dtoperaciones As New DataTable
        Dim dtVistaOpConsistencia As New DataTable
        dtoperaciones = oMantValorizacion.ListarOPxEnvioValorizacion(obeMantValorizacion)
        dtVistaOpConsistencia = dtoperaciones.Copy

        dtVistaOpConsistencia.Columns.Add("VISITADO")

        Dim drVisitado() As DataRow
        Dim dr() As DataRow
        Dim NroConsistencia As Decimal = 0
        Dim TotImpoSol As Decimal = 0
        Dim TotImpoDol As Decimal = 0
        Dim dtOP_X_Consist As DataTable
        For Each item As DataRow In dtVistaOpConsistencia.Rows
            If item("TPOPER") = "T" Then
                item("VISITADO") = "X"
            End If

            NroConsistencia = item("NSECFC")
            If item("TPOPER") = "A" Then
                'If item("TPOPER") = "A" And NroConsistencia <> 0 Then
                drVisitado = dtVistaOpConsistencia.Select("VISITADO='X' AND TPOPER='A' AND NSECFC='" & NroConsistencia & "'")

                If drVisitado.Length = 0 Then
                    dr = dtVistaOpConsistencia.Select("TPOPER='A' AND NSECFC='" & NroConsistencia & "'")
                    dtOP_X_Consist = HelpClass.RowToDatatable(dr, dtVistaOpConsistencia)
                    TotImpoSol = 0
                    TotImpoDol = 0
                    For Each itemDet As DataRow In dtOP_X_Consist.Rows
                        TotImpoSol = TotImpoSol + itemDet("IMPORTE_S")
                        TotImpoDol = TotImpoDol + itemDet("IMPORTE_D")
                    Next
                    item("NOPRCN") = 0
                    item("IMPORTE_S") = TotImpoSol
                    item("IMPORTE_D") = TotImpoDol
                    item("VISITADO") = "X"
                End If

            End If

            If item("TPOPER") = "A" Then

            End If
        Next


       


        For i As Integer = dtVistaOpConsistencia.Rows.Count - 1 To 0 Step -1
            If ("" & dtVistaOpConsistencia.Rows(i)("VISITADO")) = "" Then
                dtVistaOpConsistencia.Rows.RemoveAt(i)
            End If
        Next
        dtoperaciones.TableName = "dtoperacion"
        dtVistaOpConsistencia.TableName = "dtConsistencia"
        ds.Tables.Add(dtoperaciones)
        ds.Tables.Add(dtVistaOpConsistencia)
        Return ds

    End Function

 


    Public Function ListarOperPendientesValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        'Dim ds As New DataSet
        Dim dtOperacion As New DataTable
        'Dim dtVistaOpConsistencia As New DataTable
        dtOperacion = oMantValorizacion.ListarOperPendientesValorizacion(obeMantValorizacion)

        'dtVistaOpConsistencia = dtOperacion.Copy
        'dtVistaOpConsistencia.Columns.Add("VISITADO")

        'Dim drVisitado() As DataRow
        'Dim dr() As DataRow
        'Dim NroConsistencia As Decimal = 0
        'Dim TotImpoSol As Decimal = 0
        'Dim TotImpoDol As Decimal = 0
        'Dim dtOP_X_Consist As DataTable
        'For Each item As DataRow In dtVistaOpConsistencia.Rows
        '    If item("TPOPER") = "T" Then
        '        item("VISITADO") = "X"
        '    End If

        '    NroConsistencia = item("NSECFC")

        '    If item("TPOPER") = "A" And NroConsistencia <> 0 Then
        '        drVisitado = dtVistaOpConsistencia.Select("VISITADO='X' AND TPOPER='A' AND NSECFC='" & NroConsistencia & "'")

        '        If drVisitado.Length = 0 Then
        '            dr = dtVistaOpConsistencia.Select("TPOPER='A' AND NSECFC='" & NroConsistencia & "'")
        '            dtOP_X_Consist = HelpClass.RowToDatatable(dr, dtVistaOpConsistencia)
        '            TotImpoSol = 0
        '            TotImpoDol = 0
        '            For Each itemDet As DataRow In dtOP_X_Consist.Rows
        '                TotImpoSol = TotImpoSol + itemDet("IMPORTE_S")
        '                TotImpoDol = TotImpoDol + itemDet("IMPORTE_D")
        '            Next
        '            item("NOPRCN") = 0
        '            item("IMPORTE_S") = TotImpoSol
        '            item("IMPORTE_D") = TotImpoDol

        '        End If

        '    End If
        'Next

        'For i As Integer = dtVistaOpConsistencia.Rows.Count - 1 To 0 Step -1
        '    If ("" & dtVistaOpConsistencia.Rows(i)("VISITADO")) = "" Then
        '        dtVistaOpConsistencia.Rows.RemoveAt(i)
        '    End If
        'Next
        'ds.Tables.Add(dtOperacion)
        'ds.Tables.Add(dtVistaOpConsistencia)
        'Return ds
        Return dtOperacion
    End Function



    'Public Function ListarOperPendientesValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
    '    Dim dt As New DataTable
    '    Dim ColName As String = ""
    '    dt = oMantValorizacion.ListarOperPendientesValorizacion(obeMantValorizacion)
    '    dt.Columns.Add("IMPORTE_S")
    '    dt.Columns.Add("IMPORTE_D")
    '    dt.Columns.Add("VISITADO")
    '    Dim Cantidad As Decimal = 0
    '    Dim Tarifa As Decimal = 0
    '    Dim SubImporteSol As Decimal = 0
    '    Dim SubImporteDol As Decimal = 0
    '    Dim drBusc() As DataRow
    '    Dim TipoOp As String = ""
    '    Dim Operacion As Decimal = 0
    '    Dim CodMeda As Decimal = 0
    '    Dim TCVenta As Decimal = 0
    '    Dim drVisitado() As DataRow
    '    Dim Vistado As Boolean = False
    '    For Each item As DataRow In dt.Rows
    '        TipoOp = item("TPOPER")
    '        Operacion = item("NOPRCN")
    '        CodMeda = item("COD_MONEDA")
    '        SubImporteSol = 0
    '        SubImporteDol = 0
    '        drBusc = dt.Select("TPOPER='" & TipoOp & "' AND NOPRCN='" & Operacion & "'")
    '        drVisitado = dt.Select("VISITADO='X' AND TPOPER='" & TipoOp & "' AND NOPRCN='" & Operacion & "'")
    '        Vistado = drVisitado.Length > 0
    '        If Vistado = 0 Then
    '            For Each itemOper As DataRow In drBusc
    '                Cantidad = itemOper("QATNAN")
    '                Tarifa = itemOper("IVLSRV")
    '                TCVenta = itemOper("TC_VENTA")
    '                'TC_VENTA
    '                If CodMeda = 1 Then
    '                    SubImporteSol = SubImporteSol + Math.Round(Cantidad * Tarifa, 2, MidpointRounding.AwayFromZero)
    '                    SubImporteDol = SubImporteDol + Math.Round(Cantidad * Tarifa / TCVenta, 2, MidpointRounding.AwayFromZero)
    '                End If
    '                If CodMeda = 100 Then
    '                    SubImporteSol = SubImporteSol + Math.Round(Cantidad * Tarifa * TCVenta, 2, MidpointRounding.AwayFromZero)
    '                    SubImporteDol = SubImporteDol + Math.Round(Cantidad * Tarifa, 2, MidpointRounding.AwayFromZero)
    '                End If
    '            Next
    '            item("VISITADO") = "X"
    '            item("IMPORTE_S") = SubImporteSol
    '            item("IMPORTE_D") = SubImporteDol
    '        End If
    '    Next

    '    Dim Visita As String = ""
    '    For i As Integer = dt.Rows.Count - 1 To 0 Step -1
    '        Visita = ("" & dt.Rows(i)("VISITADO"))
    '        If Visita = "" Then
    '            dt.Rows.RemoveAt(i)
    '        End If
    '    Next


    '    Return dt
    'End Function

    Public Function RegistrarValorizacionCabecera(ByRef NROVLR As Decimal, ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Return oMantValorizacion.RegistrarValorizacionCabecera(NROVLR, obeMantValorizacion)
    End Function

    Public Sub InsertaDetalleOperValorizacionPendiente(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion)
        oMantValorizacion.InsertaDetalleOperValorizacionPendiente(obeMantValorizacion)
    End Sub

    Public Function GenerarDocValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Return oMantValorizacion.GenerarDocValorizacion(obeMantValorizacion)
    End Function

    Public Sub InsertaDetalleDocValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion)
        oMantValorizacion.InsertaDetalleDocValorizacion(obeMantValorizacion)
    End Sub
    Public Function ValidarGeneracionEnvio(ByVal obeMantValorizacion As beMantValorizacion) As String
        Return oMantValorizacion.ValidarGeneracionEnvio(obeMantValorizacion)
    End Function
    Public Function ListarEnvioValorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
        Return oMantValorizacion.ListarEnvioValorizacion(obeMantValorizacion)
    End Function
    Public Function EliminarEnvioxDocSEg(ByVal obeMantValorizacion As beMantValorizacion) As String
        Return oMantValorizacion.EliminarEnvioxDocSEg(obeMantValorizacion)
    End Function
    'Public Function EliminarDocumentoSeguimiento(ByVal obeMantValorizacion As beMantValorizacion) As String
    '    Return oMantValorizacion.EliminarDocumentoSeguimiento(obeMantValorizacion)
    'End Function
    'Public Function ListarDocSeguimiento_x_Valorizacion(ByVal obeMantValorizacion As beMantValorizacion) As DataTable
    '    Return oMantValorizacion.ListarDocSeguimiento_x_Valorizacion(obeMantValorizacion)
    'End Function

    Public Function ListarEnvioxDocSEg(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Return oMantValorizacion.ListarEnvioxDocSEg(obeMantValorizacion)
    End Function

    Public Function AnularAprobacionValorizacion(ByVal obeMantValorizacion As beMantValorizacion, ByRef RequiereAutorizacion As Boolean) As String
        Return oMantValorizacion.AnularAprobacionValorizacion(obeMantValorizacion, RequiereAutorizacion)
    End Function


    Public Function AnularAprobacionCliente(ByVal obeMantValorizacion As beMantValorizacion) As String
        Return oMantValorizacion.AnularAprobacionCliente(obeMantValorizacion)
    End Function





    'Public Function LiberarDocumentoEnviado(ByVal obeMantValorizacion As beMantValorizacion) As String
    '    Return oMantValorizacion.LiberarDocumentoEnviado(obeMantValorizacion)
    'End Function

    Public Function LiberarDocumentoGenerado(ByVal obeMantValorizacion As beMantValorizacion) As String
        Return oMantValorizacion.LiberarDocumentoGenerado(obeMantValorizacion)
    End Function

    Public Function ActualizarValorizacionCabecera(ByVal obeMantValorizacion As beMantValorizacion) As String
        Return oMantValorizacion.ActualizarValorizacionCabecera(obeMantValorizacion)
    End Function

    Public Function ListarServicioDetalleValorizacionExport(ByVal obeMantValorizacion As beMantValorizacion) As DataSet
        Dim dsresult As New DataSet
        Dim dtservicios As New DataTable
        Dim dtOC As New DataTable


        dsresult = oMantValorizacion.ListarServicioDetalleValorizacionExport(obeMantValorizacion)


        Return dsresult

    End Function
    'Public Function ListarUsuarioValorizacionAnulacion() As DataTable
    '    Return oMantValorizacion.ListarUsuarioValorizacionAnulacion()
    'End Function



    Public Function ListarOPXDivisionValorizacion(ByVal obeMantValorizacion As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Return oMantValorizacion.ListarOPXDivisionValorizacion(obeMantValorizacion)
    End Function

    Public Function Listar_Servicios_Valorizacion(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Listar_Servicios_Valorizacion(Entidad)

    End Function

    Public Function Adicionar_Operacion_Administrativa(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Adicionar_Operacion_Administrativa(Entidad)

    End Function

    Public Function Lista_Operaciones_Sustento_Por_Operacion_Administrativa(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Lista_Operaciones_Sustento_Por_Operacion_Administrativa(Entidad)

    End Function

    Public Function Lista_Operacion_Administracion_Valorizacion(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Lista_Operacion_Administracion_Valorizacion(Entidad)

    End Function

    Public Function Generar_Operacion_Rango_Valorizacion(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Generar_Operacion_Rango_Valorizacion(Entidad)

    End Function

    Public Function Lista_Tarifas_Rango_Validacion(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Lista_Tarifas_Rango_Validacion(Entidad)

    End Function

    Public Function Lista_Operaciones_Pendientes_Sustento_Rango_Viaje(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataSet
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Lista_Operaciones_Pendientes_Sustento_Rango_Viaje(Entidad)

    End Function

    Public Function Listar_Tarifas_Rango_Valorizacion(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As DataTable
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Listar_Tarifas_Rango_Valorizacion(Entidad)

    End Function

    Public Function Eliminar_Operacion_Administrativa(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Eliminar_Operacion_Administrativa(Entidad)

    End Function

    Public Function Calcular_Validar_Sustento_Viajes(ByVal Entidad As SOLMIN_CTZ.Entidades.beMantValorizacion) As String
        Dim Datos As New SOLMIN_CTZ.DATOS.clsManteniValorizacion

        Return Datos.Calcular_Validar_Sustento_Viajes(Entidad)

    End Function

    Public Function ListarServicioDetalleTipoRangoValorizacionExport(ByVal obeMantValorizacion As beMantValorizacion) As DataSet
        Dim dsresult As New DataSet
        Dim dtservicios As New DataTable
        Dim dtOC As New DataTable


        dsresult = oMantValorizacion.ListarServicioDetalleTipoRangoValorizacionExport(obeMantValorizacion)


        Return dsresult

    End Function



End Class
