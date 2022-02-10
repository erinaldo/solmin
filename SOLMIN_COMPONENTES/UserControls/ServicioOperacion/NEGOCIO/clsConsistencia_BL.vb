Public Class clsConsistencia_BL
    Private oServicioDat As clsConsistencia_DAL
    Sub New()
        oServicioDat = New clsConsistencia_DAL
    End Sub
    Public Function Lista_Detalle_Servicios_SIL(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Reporte_SIL(oServicioSIL)
    End Function
    Public Function Lista_Detalle_Servicios_Almacen(ByVal oServicioSIL As Servicio_BE) As DataTable
        Return oServicioDat.Lista_Reporte_Almacen(oServicioSIL)
    End Function
    Public Function Lista_Detalle_Servicios_Almacen_All(ByVal oServicioSIL As Servicio_BE) As DataSet
        Return oServicioDat.Lista_Detalle_Servicios_Almacen_All(oServicioSIL)
    End Function
    Public Function Obtener_Tipo_Cambio(ByVal oServ As Servicio_BE) As Double
        Return oServicioDat.Obtener_Tipo_Cambio(oServ)
    End Function
    Public Function Obtener_igv_actual(ByVal oServ As Servicio_BE) As Double
        Return oServicioDat.Obtener_igv_actual(oServ)
    End Function
    Public Function ListaCriterioBusqueda() As DataTable
        Dim oTabla As New DataTable
        Dim oDr As DataRow
        oTabla.Columns.Add("COD")
        oTabla.Columns.Add("VAL")
        oDr = oTabla.NewRow
        oDr("COD") = "1"
        oDr("VAL") = "POR CLIENTE"
        oTabla.Rows.Add(oDr) '----
        oDr = oTabla.NewRow
        oDr("COD") = "2"
        oDr("VAL") = "POR NRO. DE OPERACIÓN"
        oTabla.Rows.Add(oDr) '----
        oDr = oTabla.NewRow
        oDr("COD") = "3"
        oDr("VAL") = "POR NRO. DE REVISIÓN"
        oTabla.Rows.Add(oDr) '----
        Return oTabla
    End Function
End Class
