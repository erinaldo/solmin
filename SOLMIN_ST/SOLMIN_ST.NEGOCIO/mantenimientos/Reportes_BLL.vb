Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

  Public Class Reportes_BLL

    Dim objDataAccessLayer As New Reportes_DAL

    Public Function Listado_Tarifas_por_Cliente_Ordenes_Servicio(ByVal objEntidad As ReporteListadoTarifas) As DataSet
      Return objDataAccessLayer.Listado_Tarifas_por_Cliente_Ordenes_Servicio(objEntidad)
    End Function
    Public Function Listado_Ordenes_ServicioxCliente(ByVal objEntidad As ReporteListadoTarifas) As DataSet
      Return objDataAccessLayer.Listado_Ordenes_ServicioxCliente(objEntidad)
    End Function
    Public Function Lista_Detalle_Operaciones_X_OS(ByVal NumOs As String) As DataSet
      Return objDataAccessLayer.Lista_Detalle_Operaciones_X_OS(NumOs)
    End Function
    Public Function Lista_Planeamiento_X_Operacion(ByVal oPlaneamientoBE As Planeamiento) As DataSet
      Return objDataAccessLayer.Lista_Planeamiento_X_Operacion(oPlaneamientoBE)
    End Function

        Public Function Reporte_Rendimiento_Vehicular(ByVal objEntidad As List(Of String)) As DataTable
            Dim dtb As New DataTable
            dtb = objDataAccessLayer.Reporte_Rendimiento_Vehicular(objEntidad)
            'Procesando el resumen
            'Agregando las columnas faltantes
            dtb.Columns.Add("RENDIM", Type.GetType("System.Double"))
            dtb.Columns.Add("PORENT", Type.GetType("System.Double"))
            'Por cada fila Procesa el Rendimiento
            Dim TOTAL As Double = 0
            Dim ldbl_venta As Double = 0
            Dim ldbl_descuentos As Double = 0
            For i As Integer = 0 To dtb.Rows.Count - 1
                With dtb.Rows(i)
                    ldbl_venta = CDbl(IIf(.Item("ISRVGU").ToString() = "", 0, .Item("ISRVGU"))) + CDbl(IIf(.Item("ISRVGU_A").ToString() = "", 0, .Item("ISRVGU_A")))
                    ldbl_descuentos = 0
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPPET").ToString() = "", 0, .Item("IMPPET")))
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPAVC").ToString() = "", 0, .Item("IMPAVC")))
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPGST").ToString() = "", 0, .Item("IMPGST")))
                    .Item("RENDIM") = ldbl_venta - ldbl_descuentos
                    If .Item("RENDIM") <> 0 Then
                        .Item("PORENT") = FormatNumber(CDbl((CDbl(.Item("RENDIM")) * 100) / ldbl_venta), 3)
                    Else
                        .Item("PORENT") = FormatNumber(0, 3)
                    End If
                    'TOTAL = TOTAL + CDbl(.Item("RENDIM"))
                End With
            Next
            ''Hallando el porcentaje
            'For i As Integer = 0 To dtb.Rows.Count - 1
            '  With dtb.Rows(i)
            '    .Item("PORENT") = FormatNumber(CDbl((CDbl(.Item("RENDIM")) * 100) / TOTAL), 3)
            '  End With
            'Next
            Return dtb
        End Function

        Public Function Reporte_Rendimiento_Vehicular_Operacion(ByVal objEntidad As List(Of String)) As DataTable
            Dim dtb As New DataTable
            dtb = objDataAccessLayer.Reporte_Rendimiento_Vehicular_Operacion(objEntidad)
            'Procesando el resumen
            'Agregando las columnas faltantes
            dtb.Columns.Add("RENDIM", Type.GetType("System.Double"))
            dtb.Columns.Add("PORENT", Type.GetType("System.Double"))
            'Por cada fila Procesa el Rendimiento
            Dim TOTAL As Double = 0
            Dim ldbl_venta As Double = 0
            Dim ldbl_descuentos As Double = 0
            For i As Integer = 0 To dtb.Rows.Count - 1
                With dtb.Rows(i)
                    ldbl_venta = CDbl(IIf(.Item("ISRVGU").ToString() = "", 0, .Item("ISRVGU"))) + CDbl(IIf(.Item("ISRVGU_A").ToString() = "", 0, .Item("ISRVGU_A")))
                    ldbl_descuentos = 0
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPPET").ToString() = "", 0, .Item("IMPPET")))
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPAVC").ToString() = "", 0, .Item("IMPAVC")))
                    ldbl_descuentos = ldbl_descuentos + CDbl(IIf(.Item("IMPGST").ToString() = "", 0, .Item("IMPGST")))
                    .Item("RENDIM") = ldbl_venta - ldbl_descuentos
                    If .Item("RENDIM") <> 0 Then
                        .Item("PORENT") = FormatNumber(CDbl((CDbl(.Item("RENDIM")) * 100) / ldbl_venta), 3)
                    Else
                        .Item("PORENT") = FormatNumber(0, 3)
                    End If
                End With
            Next
            Return dtb
        End Function
    End Class

End Namespace