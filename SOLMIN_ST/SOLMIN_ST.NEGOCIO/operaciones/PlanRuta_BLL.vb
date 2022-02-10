Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class PlanRuta_BLL
    Dim objDataAccessLayer As New PlanRuta_DAL

    Public Function Registrar_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Registrar_PlanRutaInicial(objEntidad)
    End Function

    Public Function Registrar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Registrar_PlanRutaViaje(objEntidad)
    End Function

    Public Function Listar_PlanRutaInicial(ByVal objEntidad As PlanRuta) As DataTable
        Dim dtTemp As DataTable = objDataAccessLayer.Listar_PlanRutaInicial(objEntidad)
        dtTemp.Columns.Add("FECSEG_STRG", Type.GetType("System.String"))
        dtTemp.Columns.Add("HRASEG_STRG", Type.GetType("System.String"))
        Dim blSgt As Boolean = True
        Dim intOrd As Int32 = 1
        'Crea el Correlativo
        For Each row As DataRow In dtTemp.Rows()
            row("FECSEG_STRG") = FechaNum_a_Fecha(row("FECSEG"))
            row("HRASEG_STRG") = IIf(row("HRASEG") = 0, "", CNumero_a_Hora_string(row("HRASEG")))
            row.AcceptChanges()
            intOrd = intOrd + 1
        Next
        Return dtTemp
    End Function


    Public Function Eliminar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Eliminar_PlanRutaViaje(objEntidad)
    End Function

    Public Function Actualiza_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Actualiza_PlanRutaInicial(objEntidad)
    End Function

    Public Function Listar_PrioridadCarga(ByVal objEntidad As PlanRuta) As DataTable
        Return objDataAccessLayer.Listar_PrioridadCarga(objEntidad)
    End Function

    Public Function Actualiza_PlanRutaViaje(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Actualiza_PlanRutaViaje(objEntidad)
    End Function

    Public Function Actualizar_PrioridadCarga(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Actualizar_PrioridadCarga(objEntidad)
    End Function

    Public Function Elimina_PlanRutaInicial(ByVal objEntidad As PlanRuta) As Integer
        Return objDataAccessLayer.Elimina_PlanRutaInicial(objEntidad)
    End Function

    Public Shared Function CNumero_a_Hora_string(ByVal oHora As Object) As String
        Dim h As String
        Dim m As String
        Dim s As String
        If oHora.ToString.Trim.Length < 6 Then
            oHora = "0" & oHora
        End If

        h = Left(oHora.ToString(), 2)
        m = Right(Left(oHora.ToString(), 4), 2)
        s = Right(oHora.ToString(), 2)
        Return h + ":" + m + ":" + s

    End Function

    Public Shared Function FechaNum_a_Fecha(ByVal xFecha As Object) As String
        Dim FechaNum As String = ("" & xFecha).ToString.Trim
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        If (Val(FechaNum) = 0 OrElse FechaNum = "") Then
            FechaFormada = ""
        Else
            y = Left(FechaNum, 4).PadLeft(2, "0")
            m = Right(Left(FechaNum, 6), 2).PadLeft(2, "0")
            d = Right(FechaNum, 2).PadLeft(2, "0")
            FechaFormada = d & "/" & m & "/" & y
        End If
        Return FechaFormada
    End Function

    Public Function Reporte_PlanRutaViaje(ByVal objEntidad As PlanRuta) As DataTable
        Dim dtTemp As New DataTable
        dtTemp = objDataAccessLayer.Reporte_PlanRutaViaje(objEntidad)
        dtTemp.Columns.Add("ORD", Type.GetType("System.Int32"))
        dtTemp.Columns.Add("FECSEG_STRG", Type.GetType("System.String"))
        dtTemp.Columns.Add("HRASEG_STRG", Type.GetType("System.String"))
        Dim blSgt As Boolean = True
        Dim intOrd As Int32 = 1
        'Crea el Correlativo
        For Each row As DataRow In dtTemp.Rows()
            If blSgt Then
                If intOrd <> 1 Then
                    row("ORD") = intOrd / 2
                    blSgt = False
                Else
                    row("ORD") = 1
                End If
            Else
                row("ORD") = (intOrd + 1) / 2
                blSgt = True
            End If
            row("FECSEG_STRG") = FechaNum_a_Fecha(row("FECHA"))
            row("HRASEG_STRG") = IIf(row("HORA") = 0, "", CNumero_a_Hora_string(row("HORA")))
            row.AcceptChanges()
            intOrd = intOrd + 1
        Next

        dtTemp.Columns.Add("FechaMin", Type.GetType("System.Int32"))
        dtTemp.Columns.Add("HoraMin", Type.GetType("System.Int32"))
        Dim Dt As DataTable = dtTemp.Clone

        'Fecha y Hora Minima 
        Dim j As Integer = 0
        Dim drSelect As DataRow() = Nothing
        Dim strMinimo As String = ""
        Dim strHoraMinimo As String = ""
        For i As Integer = 0 To dtTemp.Rows.Count - 1
            j = 0
            drSelect = dtTemp.Select("ORD = '" + dtTemp.Rows(i)("ORD").ToString.Trim + "'", "TPOREG_VAL ASC")
            strMinimo = ""
            For Each dr As DataRow In drSelect
                Dt.ImportRow(dr)
                If j = 0 Then
                    strMinimo = dr.Item("FECHA").ToString
                    strHoraMinimo = dr.Item("HORA").ToString
                End If
                Dt.Rows(i + j)("FechaMin") = strMinimo
                Dt.Rows(i + j)("HoraMin") = strHoraMinimo
                dr.AcceptChanges()
                j = j + 1
            Next
            i = i + drSelect.Length - 1
        Next i

        'Ordena la El dt Temporal
        Dt.Columns.Remove("FECHA")
        Dt.Columns.Remove("HORA")
        Dt.Columns("FECSEG_STRG").ColumnName = "FECHA"
        Dt.Columns("HRASEG_STRG").ColumnName = "HORA"
        drSelect = Dt.Select("", "FechaMin ASC , HoraMin ASC")
        intOrd = 1
        blSgt = True

        Dim DtResult As DataTable
        DtResult = Dt.Clone
        'Reinicia el Correlativo
        For Each dr As DataRow In drSelect
            If blSgt Then
                If intOrd <> 1 Then
                    dr("ORD") = intOrd / 2
                    blSgt = False
                Else
                    dr("ORD") = 1
                End If
            Else
                dr("ORD") = (intOrd + 1) / 2
                blSgt = True
            End If
            DtResult.ImportRow(dr)
            intOrd = intOrd + 1
        Next
        Return DtResult
    End Function

    Public Function Listar_PlanRutaViaje(ByVal objEntidad As PlanRuta) As DataTable
        Dim dtTemp As New DataTable
        dtTemp = objDataAccessLayer.Listar_PlanRutaViaje(objEntidad)
        dtTemp.Columns.Add("ORD", Type.GetType("System.Int32"))
        dtTemp.Columns.Add("FECSEG_STRG", Type.GetType("System.String"))
        dtTemp.Columns.Add("HRASEG_STRG", Type.GetType("System.String"))
        Dim blSgt As Boolean = True
        Dim intOrd As Int32 = 1
        'Crea el Correlativo
        For Each row As DataRow In dtTemp.Rows()
            If blSgt Then
                If intOrd <> 1 Then
                    row("ORD") = intOrd / 2
                    blSgt = False
                Else
                    row("ORD") = 1
                End If
            Else
                row("ORD") = (intOrd + 1) / 2
                blSgt = True
            End If
            row("FECSEG_STRG") = FechaNum_a_Fecha(row("FECSEG"))
            row("HRASEG_STRG") = IIf(row("HRASEG") = 0, "", CNumero_a_Hora_string(row("HRASEG")))
            row.AcceptChanges()
            intOrd = intOrd + 1
        Next

        dtTemp.Columns.Add("FechaMin", Type.GetType("System.Int32"))
        dtTemp.Columns.Add("HoraMin", Type.GetType("System.Int32"))
        Dim Dt As DataTable = dtTemp.Clone

        'Fecha y Hora Minima 
        Dim j As Integer = 0
        Dim drSelect As DataRow() = Nothing
        Dim strMinimo As String = ""
        Dim strHoraMinimo As String = ""
        For i As Integer = 0 To dtTemp.Rows.Count - 1
            j = 0
            drSelect = dtTemp.Select("ORD = '" + dtTemp.Rows(i)("ORD").ToString.Trim + "'", "TPOREG_VAL ASC")
            strMinimo = ""
            For Each dr As DataRow In drSelect
                Dt.ImportRow(dr)
                If j = 0 Then
                    strMinimo = dr.Item("FECSEG").ToString
                    strHoraMinimo = dr.Item("HRASEG").ToString
                End If
                Dt.Rows(i + j)("FechaMin") = strMinimo
                Dt.Rows(i + j)("HoraMin") = strHoraMinimo
                dr.AcceptChanges()
                j = j + 1
            Next
            i = i + drSelect.Length - 1
        Next i

        'Ordena la El dt Temporal
        drSelect = Dt.Select("", "FechaMin ASC , HoraMin ASC")
        intOrd = 1
        blSgt = True
        Dim DtResult As DataTable
        DtResult = Dt.Clone
        'Reinicia el Correlativo
        For Each dr As DataRow In drSelect
            If blSgt Then
                If intOrd <> 1 Then
                    dr("ORD") = intOrd / 2
                    blSgt = False
                Else
                    dr("ORD") = 1
                End If
            Else
                dr("ORD") = (intOrd + 1) / 2
                blSgt = True
            End If
            DtResult.ImportRow(dr)
            intOrd = intOrd + 1
        Next
        Return DtResult
    End Function
End Class
