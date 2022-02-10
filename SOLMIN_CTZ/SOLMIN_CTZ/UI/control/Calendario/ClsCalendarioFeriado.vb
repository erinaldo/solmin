Imports Ransa.Utilitario
Public Class ClsCalendarioFeriado

    Public Shared Sub MaxDiasAbrevMes(ByVal Anio As Int32, ByVal Mes As Int32, ByRef MaxDiaMes As Int32, ByRef AbrevMes As String)

        Dim ci As Globalization.CultureInfo
        ci = New Globalization.CultureInfo("es-ES")

        Dim odtMeses As New DataTable()
        Dim keymes As String = ""
        Dim filtro As String = ""
        MaxDiaMes = Date.DaysInMonth(Anio, Mes)
        AbrevMes = Convert.ToDateTime(HelpClass.CNumero8Digitos_a_FechaDefault(Anio.ToString & StringRight("0" & Mes.ToString, 2) & "01")).ToString("MMMM", ci)
        AbrevMes = StrConv(AbrevMes, VbStrConv.ProperCase)
    End Sub


    ''' <summary>
    ''' convierte fecha(string) en número yyyymmdd
    ''' </summary>
    ''' <param name="fecha"> fecha(string)</param>
    ''' <returns>Fecha en Número</returns>
    ''' <remarks></remarks>
    Public Shared Function CFecha_a_Numero8Digitos(ByVal fecha As String) As String
        Dim y As String = fecha.Substring(6, 4)
        Dim m As String = fecha.Substring(3, 2)
        Dim d As String = fecha.Substring(0, 2)
        Return y & m & d
    End Function


    ''' <summary>
    ''' Convierte número de ocho yyyymmdd digitos a cadena en formato (dd/mm/yyyy)
    ''' </summary>
    ''' <param name="oFecha">Número en formato yyyymmdd</param>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    ''' 
    Public Shared Function CNumero8Digitos_a_FechaDefault(ByVal oFechaNumero As Int64) As String
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""
        Dim FechaFormada As String = ""
        Dim oFecha As String = oFechaNumero.ToString()
        If (Val(oFecha) = 0) Then
            FechaFormada = ""
        Else
            y = Left(oFecha.ToString(), 4)
            m = Right(Left(oFecha.ToString(), 6), 2)
            d = Right(oFecha.ToString(), 2)
            FechaFormada = d & "/" & m & "/" & y

        End If
        Return FechaFormada
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>Right</returns>
    ''' <remarks></remarks>
    Public Shared Function MaxFecha() As Int32
        Dim Fecha As Int32 = 0
        Dim ci As Globalization.CultureInfo
        ci = New Globalization.CultureInfo("es-ES")

        Try
            Fecha = Date.MaxValue.ToString("yyyy", ci)
        Catch ex As Exception
        End Try
        Return Fecha
    End Function

    ''' <summary>
    ''' Cadena por la derecha
    ''' </summary>
    ''' <returns>Right</returns>
    ''' <remarks></remarks>
    Public Shared Function StringRight(ByVal cadena As String, ByVal numCaracteres As Int32) As String
        Try
            cadena = cadena.Trim
            If (cadena <> "") Then
                If (numCaracteres > cadena.Length) Then
                    numCaracteres = 0
                End If
                cadena = cadena.Substring(cadena.Length - numCaracteres, numCaracteres)
            End If

        Catch ex As Exception

        End Try

        Return cadena
    End Function
    ''' <summary>
    ''' Cadena por la derecha
    ''' </summary>
    ''' <returns>Right</returns>
    ''' <remarks></remarks>
    Private Shared Function DiaSemanaInicioFin(ByVal anio As Int32, ByVal mes As Int32, ByVal I_Inicio_F_Fin As String) As Int32
        Dim dia As Int32 = 0
        Try
            If (I_Inicio_F_Fin.ToUpper = "I") Then
                dia = Convert.ToDateTime("01" & "/" & StringRight("0" & mes, 2) & "/" & anio).DayOfWeek()
            Else
                dia = Convert.ToDateTime(Date.DaysInMonth(anio, mes) & "/" & StringRight("0" & mes, 2) & "/" & anio).DayOfWeek()
            End If
            dia = dia + 1
            'domingo =1
            'lunes =2
            'martes =3
        Catch ex As Exception
        End Try
        Return dia
    End Function



    ''' <summary>
    ''' Retorna tabla Calendario
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CalendarioFormato(ByVal anio As Int64, ByVal numMes As Int64) As DataTable
        Dim odtMes As New DataTable()
        Dim Encontrado As Boolean = False
        Dim cont As Int32 = 1, minDiaMes = 1, DiaSemInicio = 1, DiaSemFin = 0, MaxDiaMesAct = 0
        Dim abrMesAct As String = "", dia = ""
        odtMes = dtEstructuraDiasMes()
        MaxDiasAbrevMes(anio, numMes, MaxDiaMesAct, abrMesAct)
        DiaSemInicio = DiaSemanaInicioFin(anio, numMes, "I")
        DiaSemFin = DiaSemanaInicioFin(anio, numMes, "F")
        odtMes.Rows(0).Item(nomColDiaSemana(DiaSemInicio)) = 100

        For FILA As Integer = 0 To 5
            For COLUMNA As Integer = 1 To 7
                dia = odtMes.Rows(FILA).Item(nomColDiaSemana(COLUMNA))
                If (dia <> "") Then
                    If (dia = 100) Then
                        cont = 1
                        Encontrado = True
                    End If
                End If
                If (Encontrado = True And cont <= MaxDiaMesAct) Then
                    odtMes.Rows(FILA).Item(nomColDiaSemana(COLUMNA)) = cont
                    cont += 1
                End If
            Next
        Next
        Return odtMes
    End Function
    Private Shared Function nomColDiaSemana(ByVal dia As Int32)
        Dim strNomDia As String = dia.ToString
        strNomDia = "0" & strNomDia
        strNomDia = StringRight(strNomDia, 2)
        strNomDia = "DIASEM" & strNomDia
        Return strNomDia
    End Function


    Private Shared Function dtEstructuraDiasMes() As DataTable
        Dim odt As New DataTable
        Dim dr As DataRow
        odt.Columns.Add("DIASEM01")
        odt.Columns.Add("DIASEM02")
        odt.Columns.Add("DIASEM03")
        odt.Columns.Add("DIASEM04")
        odt.Columns.Add("DIASEM05")
        odt.Columns.Add("DIASEM06")
        odt.Columns.Add("DIASEM07")

        For FILA As Integer = 0 To 5
            dr = odt.NewRow()
            For COLUMNA As Integer = 1 To 7
                dr.Item(nomColDiaSemana(COLUMNA)) = ""
            Next
            odt.Rows.Add(dr)
        Next
        Return odt.Copy
    End Function
    ''' <summary>
    ''' Retorna el año actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TodayAnio() As Int64
        Return Today.Year
    End Function

    ''' <summary>
    ''' Retorna numero mes actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TodayMes() As Int64
        Return Today.Month
    End Function

    ''' <summary>
    ''' Retorna cantidad de dias de febrero
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function EsBisiesto(ByVal anio As Int64) As Boolean
        Dim bisiesto As Boolean = False
        'If ((anio Mod 4) = 0) And ((anio Mod 100) <> 0 Or (anio Mod 400) = 0) Then
        '    bisiesto = True
        'Else
        '    bisiesto = False
        'End If
        If (Date.IsLeapYear(anio)) Then
            bisiesto = True
        Else
            bisiesto = False
        End If
        Return bisiesto
    End Function

    ''' <summary>
    ''' Retorna cantidad de dias del mes segun año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DiasMesPorAño(ByVal anio As Int64, ByVal mes As Int64) As Int64
        Dim dias As Int64 = 0
        Dim odtMeses As New DataTable()
        Dim filtro As String = ""
        Dim MaxDiasMesNum As Int32 = 0
        Dim keymes As String = ""
        odtMeses = Meses(anio)
        keymes = mes.ToString
        If (keymes.Length <= 1) Then
            keymes = "0" & keymes
        End If
        filtro = "key='" & keymes & "'"
        dias = odtMeses.Select(filtro)(0).Item("max")
        Return dias

    End Function


    ''' <summary>
    ''' Retorna cantidad de dias de febrero
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DiasFebreroAnio(ByVal anio As Int64) As Int64
        Dim dias As Int64 = 0
        If (Date.IsLeapYear(anio)) Then
            dias = 29
        Else
            dias = 28
        End If

        'Dim dias As Int64 = 0
        'If ((anio Mod 4) = 0) And ((anio Mod 100) <> 0 Or (anio Mod 400) = 0) Then
        '    dias = 29
        'Else
        '    dias = 28
        'End If
        Return dias
    End Function

    ''' <summary>
    ''' Retorna meses del año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Meses(ByVal anio As Int64) As DataTable
        Dim odt As New DataTable()
        odt.Columns.Add("key")
        odt.Columns.Add("value")
        odt.Columns.Add("value2")
        odt.Columns.Add("min")
        odt.Columns.Add("max")
        Dim dr As DataRow
        Dim dia As Integer = Date.Today.Month
        Dim ci As Globalization.CultureInfo
        ci = New Globalization.CultureInfo("es-ES")
        Dim Mes As String = ""
        Dim MesAbr As String = ""
        Dim NumMes As String = ""
        For index As Integer = 1 To 12
            dr = odt.NewRow()
            NumMes = StringRight("0" & index, 2)
            Mes = Convert.ToDateTime(HelpClass.CNumero8Digitos_a_FechaDefault(anio.ToString & StringRight("0" & NumMes, 2) & "01")).ToString("MMMM", ci)
            Mes = StrConv(Mes, VbStrConv.ProperCase)
            dr.Item("key") = NumMes
            dr.Item("value") = Mes
            dr.Item("value2") = Mes.Substring(0, 3)
            dr.Item("min") = 1
            dr.Item("max") = Date.DaysInMonth(anio, index)
            odt.Rows.Add(dr)
        Next
        Return odt
    End Function
End Class
