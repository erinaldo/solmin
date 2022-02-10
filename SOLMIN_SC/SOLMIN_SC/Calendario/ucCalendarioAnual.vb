Public Class ucCalendarioAnual
    Private ANIO As Int32 = 0
    Public Sub ActualizarCalendario(ByVal PNANIO As Int32, ByVal Cargar As Boolean)
        ANIO = PNANIO
        UcCalendario1.ActualizarCalendario(ANIO, 1, Cargar)
        UcCalendario2.ActualizarCalendario(ANIO, 2, Cargar)
        UcCalendario3.ActualizarCalendario(ANIO, 3, Cargar)
        UcCalendario4.ActualizarCalendario(ANIO, 4, Cargar)
        UcCalendario5.ActualizarCalendario(ANIO, 5, Cargar)
        UcCalendario6.ActualizarCalendario(ANIO, 6, Cargar)
        UcCalendario7.ActualizarCalendario(ANIO, 7, Cargar)
        UcCalendario8.ActualizarCalendario(ANIO, 8, Cargar)
        UcCalendario9.ActualizarCalendario(ANIO, 9, Cargar)
        UcCalendario10.ActualizarCalendario(ANIO, 10, Cargar)
        UcCalendario11.ActualizarCalendario(ANIO, 11, Cargar)
        UcCalendario12.ActualizarCalendario(ANIO, 12, Cargar)
    End Sub
End Class
