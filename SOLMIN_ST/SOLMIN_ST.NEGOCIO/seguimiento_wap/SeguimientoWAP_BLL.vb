Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace seguimiento_wap
  Public Class SeguimientoWAP_BLL

    Private objDAO As New SeguimientoWap_DAL

    Public Function Listar_Eventos_Distinct_WapST_1(ByVal CSGWP As String) As DataTable
      Return objDAO.Listar_Eventos_Distinct_WapST_1(CSGWP)
    End Function

    Public Function Listar_Detalle_Eventos_Distinct_WapST_1(ByVal objparametros As Hashtable) As DataTable
      Return objDAO.Listar_Detalle_Eventos_Distinct_WapST_1(objparametros)
    End Function

    Public Function Listar_Diferencias_Tiempos_x_Config_Eventos_Wap_Workflow_V3_1(ByVal lstr_pFecIni As Integer, _
                                                                                  ByVal lstr_pFecFin As Integer, _
                                                                                  ByVal lstr_pPlaca As String, _
                                                                                  ByVal lstr_pGrupSeg As String, _
                                                                                  ByVal lstr_CSGWP As String) As DataTable

      Dim objParametros As New Hashtable
      objParametros.Add("PARAM_CSWP", lstr_CSGWP)
      objParametros.Add("PARAM_NPLCTR", lstr_pPlaca)
      objParametros.Add("PARAM_FECINI", lstr_pFecIni)
      objParametros.Add("PARAM_FECFIN", lstr_pFecFin)
      objParametros.Add("PARAM_NGSGWP", lstr_pGrupSeg)

      Dim dtbEventos As New DataTable
      Dim dtbDetalleEventos As New DataTable
      Dim dtbNiveles As New DataTable

      dtbEventos = Listar_Eventos_Distinct_WapST_1(lstr_CSGWP)
      dtbDetalleEventos = Listar_Detalle_Eventos_Distinct_WapST_1(objParametros)
      dtbNiveles = Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow()

      Dim dtbReporte As New DataTable

      dtbReporte.Columns.Add("NCOREG")
      dtbReporte.Columns.Add("SESTRG")
      dtbReporte.Columns.Add("FCHCRT")
      dtbReporte.Columns.Add("HRACRT")
      dtbReporte.Columns.Add("NPLCTR")

      Dim keys(0) As DataColumn
      keys(0) = dtbReporte.Columns("NCOREG")
      dtbReporte.PrimaryKey = keys

      For Each rowEvento As DataRow In dtbEventos.Rows
        dtbReporte.Columns.Add(rowEvento("TNMCEV").ToString.Trim)
      Next
      dtbReporte.Columns.Add("TIEMPO ACUMULADO")
      dtbReporte.Columns.Add("OBSERVACIONES")

      Dim NCOREG As String = String.Empty
      Dim FRGTRO As String = String.Empty
      Dim HRGTRO As String = String.Empty
      Dim NPLCTR As String = String.Empty
      Dim FCHCRT As String = String.Empty
      Dim HRACRT As String = String.Empty
      Dim TNMCEV As String = String.Empty
      Dim SESTRG As String = String.Empty

      For Each rowDetalleEventos As DataRow In dtbDetalleEventos.Rows
        NPLCTR = rowDetalleEventos("NPLCTR").ToString
        FRGTRO = rowDetalleEventos("FRGTRO").ToString
        HRGTRO = rowDetalleEventos("HRGTRO").ToString
        FCHCRT = rowDetalleEventos("FCHCRT").ToString
        HRACRT = rowDetalleEventos("HRACRT").ToString
        TNMCEV = rowDetalleEventos("TNMCEV").ToString.Trim
        SESTRG = rowDetalleEventos("SESTRG").ToString
        If NCOREG = rowDetalleEventos("NCOREG").ToString Then
          NCOREG = rowDetalleEventos("NCOREG").ToString
          Dim dr As DataRow = dtbReporte.Rows.Find(NCOREG)
          If TNMCEV IsNot String.Empty Then dr(TNMCEV) = FRGTRO + " " + HRGTRO
        Else
          NCOREG = rowDetalleEventos("NCOREG").ToString
          Dim dr As DataRow = dtbReporte.NewRow
          dr("NCOREG") = NCOREG
          dr("FCHCRT") = FCHCRT
          dr("HRACRT") = HRACRT
          dr("NPLCTR") = NPLCTR
          dr("SESTRG") = SESTRG
          If TNMCEV IsNot String.Empty Then dr(TNMCEV) = FRGTRO + " " + HRGTRO
          dtbReporte.Rows.Add(dr)
        End If
      Next

      Dim drSum As DataRow = dtbReporte.NewRow
      drSum("NCOREG") = ""
      drSum("NPLCTR") = "TOTALES"
      dtbReporte.Rows.Add(drSum)

      For Each rowNiveles As DataRow In dtbNiveles.Rows
        Dim NIVEL1 As String = rowNiveles("NIVEL1").ToString
        Dim NIVEL2 As String = rowNiveles("NIVEL2").ToString
        Dim Nv1TNMEV As String = String.Empty
        Dim Nv2TNMEV As String = String.Empty

        For Each rowEvento As DataRow In dtbEventos.Rows
          If NIVEL1 = rowEvento("NCOEVT").ToString.Trim Then
            Nv1TNMEV = rowEvento("TNMCEV").ToString.Trim
          End If
          If NIVEL2 = rowEvento("NCOEVT").ToString.Trim Then
            Nv2TNMEV = rowEvento("TNMCEV").ToString.Trim
          End If
        Next
        Dim TOBS As String = rowNiveles("TOBS").ToString

        If Nv2TNMEV <> String.Empty Then
          For Each columnReporte As DataColumn In dtbReporte.Columns
            If columnReporte.ColumnName = Nv2TNMEV Then
              dtbReporte.Columns.Add(TOBS)
              dtbReporte.Columns(TOBS).SetOrdinal(columnReporte.Ordinal + 1)
              Dim f3 As TimeSpan = TimeSpan.Zero

              For Each rowReporte As DataRow In dtbReporte.Rows
                Dim f1, f2 As DateTime
                Dim f1s, f2s As String
                f1s = rowReporte(Nv1TNMEV).ToString()
                f2s = rowReporte(Nv2TNMEV).ToString()
                If f1s.Trim <> String.Empty And f2s.Trim <> String.Empty Then
                  f1 = Convert.ToDateTime(f1s)
                  f2 = Convert.ToDateTime(f2s)
                  Dim f As TimeSpan = f2.Subtract(f1)
                  rowReporte(TOBS) = f
                  f3 += f
                End If
              Next
              dtbReporte.Rows(dtbReporte.Rows.Count - 1)(TOBS) = f3
              Exit For
            End If
          Next
        End If
      Next


      For r As Integer = 0 To dtbReporte.Rows.Count - 1
        Dim enMinTotal As Double = 0
        For c As Integer = 0 To dtbReporte.Columns.Count - 1
          Dim Tiempo As String = String.Empty
          If dtbReporte.Columns(c).ColumnName.StartsWith("TIEMPO") And _
             dtbReporte.Rows(r)(c).ToString() IsNot String.Empty Then
            Tiempo = dtbReporte.Rows(r)(c).ToString()

            If Tiempo.Length < 10 Then
              If Tiempo.Substring(0, 1) = "-" Then
                Dim hor As Integer = CInt(Tiempo.Substring(1, 2))
                Dim min As Integer = CInt(Tiempo.Substring(4, 2))
                Dim seg As Integer = CInt(Tiempo.Substring(7, 2))
                Dim enMin As Double = (hor * -1) * 60 + (min * -1) + (seg * -1) / 60
                enMinTotal = enMinTotal + enMin
              Else
                Dim hor As Integer = CInt(Tiempo.Substring(0, 2))
                Dim min As Integer = CInt(Tiempo.Substring(3, 2))
                Dim seg As Integer = CInt(Tiempo.Substring(6, 2))
                Dim enMin As Double = hor * 60 + min + seg / 60
                enMinTotal = enMinTotal + enMin
              End If
            Else
              Dim punto As Integer = Tiempo.IndexOf(".")
              If Tiempo.Substring(0, 1) = "-" Then
                Dim dia As Integer = CInt(Tiempo.Substring(1, punto))
                Dim hor As Integer = CInt(Tiempo.Substring(punto + 1, 2))
                Dim min As Integer = CInt(Tiempo.Substring(punto + 4, 2))
                Dim seg As Integer = CInt(Tiempo.Substring(punto + 7, 2))
                Dim enMin As Double = ((dia * -1) * 24 * 60) + ((hor * -1) * 60) + (min * -1) + ((seg * -1) / 60)
                enMinTotal = enMinTotal + enMin
              Else
                Dim dia As Integer = CInt(Tiempo.Substring(0, punto))
                Dim hor As Integer = CInt(Tiempo.Substring(punto + 1, 2))
                Dim min As Integer = CInt(Tiempo.Substring(punto + 4, 2))
                Dim seg As Integer = CInt(Tiempo.Substring(punto + 7, 2))
                Dim enMin As Double = (dia * 24 * 60) + (hor * 60) + min + (seg / 60)
                enMinTotal = enMinTotal + enMin
              End If
            End If
          End If
          If dtbReporte.Columns(c).ColumnName = "TIEMPO ACUMULADO" Then
            dtbReporte.Rows(r)(c) = Convert.ToInt32(enMinTotal).ToString() + " min."
          End If
        Next
      Next
      Return dtbReporte
    End Function





    ''' <summary>
    ''' ''''''''''''
    ''' </summary>
    ''' <param name="objEntidad"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Info_RegistroWAP(ByVal objEntidad As RegistroWAP) As RegistroWAP
      Return objDAO.Obtener_Info_RegistroWAP(objEntidad)
    End Function

    Public Function Listar_Roles_Wap() As List(Of RolWap)
      Return objDAO.Listar_Roles_Wap()
    End Function

    Public Function Listar_Accion_Wap_Hijo() As List(Of AccionWap)
      Return objDAO.Listar_Accion_Wap_Hijo()
    End Function

    Public Function Listar_Eventos_Wap() As List(Of AccionWap)
      Return objDAO.Listar_Eventos_Wap()
    End Function

    Public Function Listar_Usuarios_Wap() As List(Of UsuarioWap)
      Return objDAO.Listar_Usuario_Wap
    End Function

    Public Function Listar_Unidades_Asignadas_Por_Fecha(ByVal lp_Placa As String, ByVal lp_FecIni As String, ByVal lp_FecFin As String) As List(Of ClaseGeneral)
      Try
        Return objDAO.Listar_Unidades_Asignadas_Por_Fecha(lp_Placa, lp_FecIni, lp_FecFin)
      Catch ex As Exception
        Throw New Exception(ex.ToString())
      End Try
    End Function

    Public Function Listar_Acciones_Wap(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Acciones_Wap(objParametros)
    End Function

    Public Function Listar_Acciones_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Acciones_Wap_Workflow(objParametros)
    End Function

    Public Function Listar_Actividades_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Actividades_Wap_Workflow(objParametros)
    End Function

    Public Function Listar_Tractos_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Tractos_Wap_Workflow(objParametros)
    End Function

    Public Function Listar_Usuarios_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Usuarios_Wap_Workflow(objParametros)
    End Function

    Public Function Listar_Diferencia_Tiempos_Wap(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Diferencias_Tiempos(objParametros)
    End Function

    Public Function Listar_Posiciones_GPS(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Posiciones_GPS_X_Fehas(objParametros)
    End Function

    Public Function Listar_Ultima_Ubicacion(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Tractos_X_Ultima_Ubicacion(objParametros)
    End Function

    Public Function Listar_Ultima_Ubicacion_ManttOpTransporte(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Tractos_X_Ultima_Ubicacion_ManttOpTransporte(objParametros)
    End Function

    Public Function Listar_Estado_Flota(ByVal objHash As Hashtable) As DataTable
      Return objDAO.Listar_Estado_Flota(objHash)
    End Function

    Public Function Listar_Eventos_Wap_WorkFlow() As DataTable
      Return objDAO.Listar_Eventos_Wap_WorkFlow()
    End Function

    Public Function Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow() As DataTable
      Return objDAO.Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow()
    End Function

    Public Function Generar_Archivo_KML_google_earth(ByVal objList As List(Of String)) As Text.StringBuilder
      Return Nothing
    End Function

    Public Function Registrar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal lint_pNIVEL2 As Integer, ByVal lint_pNIVEL1 As Integer, ByVal lstr_pDescripcionDelta As String) As String
      Return objDAO.Registrar_Configuracion_Delta_Eventos_Workflow_Wap(lint_pNIVEL2, lint_pNIVEL1, lstr_pDescripcionDelta)
    End Function

    Public Function Modificar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal objParametros As Hashtable) As String
      Return objDAO.Modificar_Configuracion_Delta_Eventos_Workflow_Wap(objParametros)
    End Function

    Public Function Eliminar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal objParametros As Hashtable) As String
      Return objDAO.Eliminar_Configuracion_Delta_Eventos_Workflow_Wap(objParametros)
    End Function

    Public Function Listar_Eventos_WapST(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Eventos_WapST(objParametros)
    End Function

    Public Function Listar_Eventos_Distinct_WapST() As DataTable
      Return objDAO.Listar_Eventos_Distinct_WapST()
    End Function

    Public Function Listar_Ciclos_Distinct_WapST(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Ciclos_Distinct_WapST(objParametros)
    End Function

    Public Function Listar_Ultimo_Ciclo_Tracto(ByVal objParametros As Hashtable) As DataTable
      Return objDAO.Listar_Ultimo_Ciclo_Tracto(objParametros)
    End Function

    Public Function Listar_Ultimo_Ciclo_Tracto_Multimodal(ByVal objparametros As Hashtable) As DataTable
      Return objDAO.Listar_Ultimo_Ciclo_Tracto_Multimodal(objparametros)
    End Function

    Public Function Modificar_Registro_WAP(ByVal objEntidad As RegistroWAP) As String
      Return objDAO.Modificar_Registro_WAP(objEntidad)
    End Function

    Public Function Obtener_Informacion_Registro_Wap(ByVal Obj_Entidad As RegistroWAP) As UsuarioWap
      Return objDAO.Obtener_Informacion_Registro_Wap(Obj_Entidad)
    End Function

    Public Function Obtener_Informacion_Ciclo_Wap(ByVal Obj_Entidad As RegistroWAP) As RegistroWAP
      Return objDAO.Obtener_Informacion_Ciclo_Wap(Obj_Entidad)
    End Function

    Public Function Listar_Diferencias_Tiempos_Wap_Workflow(ByVal lint_pCodigoRol As Integer, _
                                                            ByVal lint_pIndiceReporte As Integer, _
                                                            ByVal lstr_pFecIni As String, _
                                                            ByVal lstr_pFecFin As String, _
                                                            ByVal lstr_pPlaca As String, _
                                                            ByVal lstr_pNroMov As String) As DataTable()
      Dim dtbRetDatatable(2) As DataTable
      Dim lstr_nomColVariable As String = ""
      Dim objSeguimientoWap As New SeguimientoWAP_BLL
      Dim objParametros As New Hashtable
      Dim dwvColVar As New DataView
      Dim dwvWapWF As New DataView
      Dim dtbAcciones As New DataTable
      Dim dtbColAcciones As New DataTable
      Dim dtbColVariable As New DataTable
      Dim dtbActividades As New DataTable

      If lint_pCodigoRol = 0 Then
        objParametros.Add("NCOROL", "")
      Else
        objParametros.Add("NCOROL", lint_pCodigoRol.ToString.Trim)
      End If

      objParametros.Add("FECINI", lstr_pFecIni)
      objParametros.Add("FECFIN", lstr_pFecFin)

      If lstr_pPlaca.ToString.Trim <> "" Then
        objParametros.Add("NPLCTR", lstr_pPlaca)
      Else
        objParametros.Add("NPLCTR", "")
      End If

      'TABLA 1 : ACCIONES
      dtbAcciones = objSeguimientoWap.Listar_Acciones_Wap_Workflow(objParametros)

      dwvColVar = objSeguimientoWap.Listar_Tractos_Wap_Workflow(objParametros).DefaultView
      If lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_TRACTO Then
        lstr_nomColVariable = "PLACA DE TRACTO"
        dwvColVar.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"
      ElseIf lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_USUARIO Then
        lstr_nomColVariable = "USUARIO"
        If dwvColVar.RowFilter.Length > 0 Then
          dwvColVar.RowFilter += " AND NROMOV LIKE '%" & lstr_pNroMov & "%'"
        Else
          dwvColVar.RowFilter += " NROMOV LIKE '%" & lstr_pNroMov & "%'"
        End If

      End If

      'TABLA 2 : COLUMNA VARIABLE 
      dtbColVariable = dwvColVar.ToTable

      dwvWapWF = objSeguimientoWap.Listar_Actividades_Wap_Workflow(objParametros).DefaultView
      If lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_TRACTO Then
        dwvWapWF.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"
      ElseIf lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_USUARIO Then
        If dwvWapWF.RowFilter.Length > 0 Then
          dwvWapWF.RowFilter += " AND NROMOV LIKE '%" & lstr_pNroMov & "%'"
        Else
          dwvWapWF.RowFilter += " NROMOV LIKE '%" & lstr_pNroMov & "%'"
        End If
      End If

      'TABLA 3 : ACTIVIDADES
      dtbActividades = dwvWapWF.ToTable

      'crea columna variable
      dtbColAcciones.Columns.Add(lstr_nomColVariable)

      'crea columnas de acciones
      For Each row As DataRow In dtbAcciones.Rows
        If dtbColAcciones.Columns.Count <> 1 Then
          dtbColAcciones.Columns.Add("Delta" & dtbColAcciones.Columns.Count)
        End If
        dtbColAcciones.Columns.Add(row("NCOACC").ToString.Trim)
      Next

      'crea tantos rows como tractos (dtbColVariable.Rows) existan
      For Each colVarRow As DataRow In dtbColVariable.Rows
        Dim lstr_DataColVar As String = colVarRow.Item(0).ToString().Trim

        'inserta data en la columna variable
        Dim row As DataRow = dtbColAcciones.NewRow
        row(lstr_nomColVariable) = lstr_DataColVar

        'inserta data en las columnas de acciones
        Dim lstr_CODACC_ColAccion As String
        For lint_i As Integer = 1 To dtbColAcciones.Columns.Count - 1 Step 2 'el idx de cols acciones son impares, las col delta son pares
          lstr_CODACC_ColAccion = dtbColAcciones.Columns.Item(lint_i).ColumnName.ToString.Trim

          'itera rows del objDtActividades: busca la hora y fecha donde concuerden el CODACC y la columna variable
          Dim lstr_Fecha As String = ""
          Dim lstr_Hora As String = ""
          For j As Integer = 0 To dtbActividades.Rows.Count - 1
            Dim lstr_colName As String = ""
            If lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_TRACTO Then
              lstr_colName = "NPLCTR"
            ElseIf lint_pIndiceReporte = ReportesWAP.DIFERENCIAS_DE_TIEMPO_ENTRE_EVENTOS_WAP_POR_USUARIO Then
              lstr_colName = "NROMOV"
            End If

            If dtbActividades.Rows(j).Item(lstr_colName).ToString.Trim = lstr_DataColVar Then
              If lstr_CODACC_ColAccion = dtbActividades.Rows(j).Item("NCOACC").ToString.Trim Then
                lstr_Fecha = dtbActividades.Rows(j).Item(6).ToString
                lstr_Hora = dtbActividades.Rows(j).Item(5).ToString
                row(lstr_CODACC_ColAccion) = lstr_Fecha & " " & lstr_Hora
              End If
            End If
          Next
        Next

        Dim t1 As DateTime
        Dim t2 As DateTime
        Dim lbool_t1Stored As Boolean = False
        Dim lbool_t2Stored As Boolean = False

        'cuando el tiempo1 y el tiempo2 esten llenos => pintar su diferencia en el campo anterio al tiempo2
        For lint_q As Integer = 1 To dtbColAcciones.Columns.Count - 1 Step 2
          If row(lint_q).ToString.Trim <> "" Then
            If lbool_t1Stored = False Then
              t1 = CDate(row(lint_q).ToString.Trim)
              lbool_t1Stored = True
            ElseIf lbool_t2Stored = False Then
              t2 = CDate(row(lint_q).ToString.Trim)
              lbool_t1Stored = True
              '--------------- inicio cálculo diferencia tiempo --------------
              Dim lstr_hora() As String
              Dim lint_h As Integer
              Dim lint_m As Integer
              Dim lint_s As Integer
              Dim lstr_diff_t As String 'diferencia tiempo

              'diff de al menos 1 dia
              If (t2 - t1).ToString.IndexOf(".") <> -1 Then
                Dim lstr_lapso() As String
                Dim lint_cantDias As Integer
                lstr_lapso = (t2 - t1).ToString.Split(".")
                lint_cantDias = System.Math.Abs(CInt(lstr_lapso(0)))
                lstr_hora = lstr_lapso(1).ToString.Split(":")
                lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                lstr_diff_t = lint_cantDias & "d : " & lint_h & "h " & lint_m & "m " & lint_s & "s"
              Else
                lstr_hora = (t2 - t1).ToString.Split(":")
                lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                lstr_diff_t = lint_h & "h " & lint_m & "m " & lint_s & "s"
              End If
              '--------------- fin cálculo diferencia tiempo --------------
              row(lint_q - 1) = lstr_diff_t
              lbool_t1Stored = False
              lbool_t2Stored = False
              lint_q -= 2
            End If
          End If
        Next
        dtbColAcciones.Rows.Add(row)
      Next

      'calculo de sumatorias de las columnas "Delta T"
      Dim rowSumatorias As DataRow = dtbColAcciones.NewRow

      For Each r As DataRow In dtbColAcciones.Rows
        For lint_col As Integer = 2 To dtbColAcciones.Columns.Count - 2 Step 2
          If lint_col Mod 2 = 0 Then

            If r(lint_col).ToString <> "" Then
              If rowSumatorias(lint_col).ToString = "" Then
                rowSumatorias(lint_col) = 0
              End If
              rowSumatorias(lint_col) = CInt(rowSumatorias(lint_col)) + convertirTiempoEnMinutos(r(lint_col))
            End If

          End If
        Next
      Next

      'convierte el total de segundos en horas
      For lint_q As Integer = 2 To rowSumatorias.ItemArray.Length - 2
        If rowSumatorias(lint_q).ToString.Length > 0 Then
          If CInt(rowSumatorias(lint_q)) < 3600 Then
            rowSumatorias(lint_q) = "0 h"
          Else
            rowSumatorias(lint_q) = rowSumatorias(lint_q) / 3600 & " h"
          End If
        End If
      Next

      dtbColAcciones.Rows.Add(rowSumatorias)

      dtbRetDatatable(0) = dtbAcciones
      dtbRetDatatable(1) = dtbColAcciones

      Return dtbRetDatatable

    End Function

    Private Function convertirTiempoEnMinutos(ByVal lstr_lapso As String) As Integer
      Dim lint_sumTotal As Integer
      Dim lstr_tiempo() As String
      Dim lstr_hora() As String

      Dim lint_dias As Integer = 0
      Dim lint_horas As Integer = 0
      Dim lint_min As Integer = 0
      'Dim lint_seg As Integer = 0

      If lstr_lapso.Contains(":") Then
        lstr_tiempo = lstr_lapso.Split(" ")
        lint_dias = lstr_tiempo(0).Substring(0, lstr_tiempo(0).Length - 1)
        lint_horas = lstr_tiempo(2).ToString.Substring(0, lstr_tiempo(2).ToString.Length - 1)
        lint_min = lstr_tiempo(3).ToString.Substring(0, lstr_tiempo(3).ToString.Length - 1)
        'lint_seg = lstr_tiempo(4).ToString.Substring(0, lstr_tiempo(4).ToString.Length - 1)
      Else
        lstr_hora = lstr_lapso.Split(" ")
        lint_horas = lstr_hora(0).ToString.Substring(0, lstr_hora(0).ToString.Length - 1)
        lint_min = lstr_hora(1).ToString.Substring(0, lstr_hora(1).ToString.Length - 1)
        'lint_seg = lstr_hora(2).ToString.Substring(0, lstr_hora(2).ToString.Length - 1)
      End If

      'suma expresada en minutos:
      lint_dias = System.Math.Abs(CInt(lint_dias * 24 * 60))
      lint_horas = System.Math.Abs(CInt(lint_horas * 60))
      lint_min = System.Math.Abs(CInt(lint_min))
      lint_sumTotal = lint_dias + lint_horas + lint_min '+ lint_seg

      Return lint_sumTotal

    End Function

    Public Function listado_Registro_Eventos_Wap_Workflow(ByVal lint_pcodigoRol As Integer, _
                                                            ByVal lint_pIndiceReporte As Integer, _
                                                            ByVal lstr_pFecIni As String, _
                                                            ByVal lstr_pFecFin As String, _
                                                            ByVal lstr_pPlaca As String, _
                                                            ByVal lstr_pNroMov As String) As DataTable()
      Dim dtbRetDatatable(2) As DataTable
      Dim lstr_nomColVariable As String = ""
      Dim objSeguimientoWap As New SeguimientoWAP_BLL
      Dim objParametros As New Hashtable
      Dim dwvColVar As New DataView
      Dim dwvWapWF As New DataView
      Dim dtbAcciones As New DataTable
      Dim dtbColAcciones As New DataTable
      Dim dtbColVariable As New DataTable
      Dim dtbActividades As New DataTable

      If lint_pcodigoRol = 0 Then
        objParametros.Add("NCOROL", "")
      Else
        objParametros.Add("NCOROL", lint_pcodigoRol.ToString.Trim)
      End If

      objParametros.Add("FECINI", lstr_pFecIni)
      objParametros.Add("FECFIN", lstr_pFecFin)

      If lstr_pPlaca.ToString.Trim <> "" Then
        objParametros.Add("NPLCTR", lstr_pPlaca)
      Else
        objParametros.Add("NPLCTR", "")
      End If

      'TABLA 1 : ACCIONES 
      dtbAcciones = objSeguimientoWap.Listar_Acciones_Wap_Workflow(objParametros)

      dwvColVar = objSeguimientoWap.Listar_Tractos_Wap_Workflow(objParametros).DefaultView
      If lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_TRACTO Then
        lstr_nomColVariable = "PLACA DE TRACTO"
        dwvColVar.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"
      ElseIf lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_USUARIO Then
        lstr_nomColVariable = "USUARIO"
        If dwvColVar.RowFilter.Length > 0 Then
          dwvColVar.RowFilter += " AND NROMOV LIKE '%" & lstr_pNroMov & "%'"
        Else
          dwvColVar.RowFilter += " NROMOV LIKE '%" & lstr_pNroMov & "%'"
        End If
      End If

      'TABLA 2 : COLUMNA VARIABLE 
      dtbColVariable = dwvColVar.ToTable

      dwvWapWF = objSeguimientoWap.Listar_Actividades_Wap_Workflow(objParametros).DefaultView
      If lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_TRACTO Then

        dwvWapWF.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"
      ElseIf lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_USUARIO Then
        If dwvWapWF.RowFilter.Length > 0 Then
          dwvWapWF.RowFilter += " AND NROMOV LIKE '%" & lstr_pNroMov & "%'"
        Else
          dwvWapWF.RowFilter += " NROMOV LIKE '%" & lstr_pNroMov & "%'"
        End If
      End If

      ''TABLA 3 : ACTIVIDADES
      dtbActividades = dwvWapWF.ToTable

      ''crea columna variable
      dtbColAcciones.Columns.Add(lstr_nomColVariable)

      'crea columnas de acciones
      For Each row As DataRow In dtbAcciones.Rows
        dtbColAcciones.Columns.Add(row("NCOACC").ToString.Trim)
      Next

      'crea tantos rows como tractos (objDtColVariable.Rows) existan
      For Each colVarRow As DataRow In dtbColVariable.Rows
        Dim lstr_DataColVar As String = colVarRow.Item(0).ToString().Trim

        'inserta data en la columna variable
        Dim row As DataRow = dtbColAcciones.NewRow
        row(lstr_nomColVariable) = lstr_DataColVar

        'inserta data en las columnas de acciones
        Dim lstr_CODACC_ColAccion As String
        For lint_i As Integer = 1 To dtbColAcciones.Columns.Count - 1
          lstr_CODACC_ColAccion = dtbColAcciones.Columns.Item(lint_i).ColumnName.ToString.Trim()
          'itera rows del objDtActividades: busca la hora y fecha donde concuerden el CODACC y la columna variable
          Dim lstr_Fecha As String = ""
          Dim lstr_Hora As String = ""
          For lint_j As Integer = 0 To dtbActividades.Rows.Count - 1
            Dim lstr_colName As String = ""
            If lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_TRACTO Then
              lstr_colName = "NPLCTR"
            ElseIf lint_pIndiceReporte = ReportesWAP.FLUJO_DE_ACTIVIDADES_POR_USUARIO Then
              lstr_colName = "NROMOV"
            End If
            If dtbActividades.Rows(lint_j).Item(lstr_colName).ToString.Trim = lstr_DataColVar Then
              If lstr_CODACC_ColAccion = dtbActividades.Rows(lint_j).Item("NCOACC").ToString.Trim Then
                lstr_Fecha = dtbActividades.Rows(lint_j).Item(6).ToString
                lstr_Hora = dtbActividades.Rows(lint_j).Item(5).ToString
                row(lstr_CODACC_ColAccion) = lstr_Fecha & " " & lstr_Hora
              End If
            End If
          Next
        Next
        dtbColAcciones.Rows.Add(row)
      Next
      dtbRetDatatable(0) = dtbAcciones
      dtbRetDatatable(1) = dtbColAcciones

      Return dtbRetDatatable

    End Function

    Public Function Listar_Diferencias_Tiempos_x_Config_Eventos_Wap_Workflow_V3(ByVal lstr_pFecIni As String, _
                                                                       ByVal lstr_pFecFin As String, _
                                                                       ByVal lstr_pPlaca As String, _
                                                                        ByVal lstr_gruposeguimiento As String) As DataTable()

      Dim objParametros As New Hashtable

      Dim dtbCiclosxEvento As New DataTable
      Dim dtbEventos As New DataTable
      Dim dtbReporte As New DataTable
      Dim dtbEventosCfgDeltaT As New DataTable
      Dim dtbCiclosDistinct As New DataTable
      Dim dtbRetDatatable(3) As DataTable
      Dim dwvTracto As New DataView
      Dim startIndex As Integer = -1

      objParametros.Add("PARAM_FECINI", lstr_pFecIni)
      objParametros.Add("PARAM_FECFIN", lstr_pFecFin)
      objParametros.Add("PARAM_NGSGWP", lstr_gruposeguimiento)

      If lstr_pPlaca.ToString.Trim <> "" Then
        objParametros.Add("NPLCTR", lstr_pPlaca)
      Else
        objParametros.Add("NPLCTR", "")
      End If

      'TABLA 1 : CICLOS
      dtbCiclosxEvento = Listar_Eventos_WapST(objParametros)

      'TABLA 2 : EVENTOS DISTINCT
      dtbEventos = Listar_Eventos_Distinct_WapST()

      'TABLA 3 : TABLA REPORTE
      dtbReporte.Columns.Add("CICLO")
      dtbReporte.Columns.Add("FCHCRT")
      dtbReporte.Columns.Add("HRACRT")
      dtbReporte.Columns.Add("NPLCTR")
      startIndex = dtbReporte.Columns.Count

      'TABLA 4: LISTADO DE EVENTOS A DIFERENCIARSE X TIEMPO
      dtbEventosCfgDeltaT = Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow()

      'TABLA 5: CICLOS DISTINCT
      dwvTracto = Listar_Ciclos_Distinct_WapST(objParametros).DefaultView
      dwvTracto.RowFilter = "TRIM(NPLCTR) LIKE '%" & lstr_pPlaca.Trim & "%'"
      dtbCiclosDistinct = dwvTracto.ToTable

      'crea todas las columnas de eventos del supervisor y solo los deltas establecidos en objDtEventosCfgDeltaT
      For Each rowEvento As DataRow In dtbEventos.Rows
        For Each rowCfgDeltaEventos As DataRow In dtbEventosCfgDeltaT.Rows
          If rowEvento("NCOEVT").ToString.Trim.Equals(rowCfgDeltaEventos("NIVEL2").ToString.Trim) Then
            dtbReporte.Columns.Add("Delta:" & _
                                         rowCfgDeltaEventos("NIVEL2").ToString.Trim & _
                                         "-" & _
                                         rowCfgDeltaEventos("NIVEL1").ToString.Trim)
          End If
        Next
        dtbReporte.Columns.Add(rowEvento("NCOEVT").ToString.Trim)
      Next

      'crea tantos rows como CICLOS existan
      For Each rowCiclo As DataRow In dtbCiclosDistinct.Rows

        'inserta data en las dos primeras cols de dtbReporte
        Dim row As DataRow = dtbReporte.NewRow
        row("CICLO") = rowCiclo.Item("CICLO").ToString().Trim
        row("FCHCRT") = rowCiclo.Item("FCHCRT").ToString().Trim
        row("HRACRT") = rowCiclo.Item("HRACRT").ToString().Trim
        row("NPLCTR") = rowCiclo.Item("NPLCTR").ToString().Trim

        'inserta data solo en las cols de eventos de dtbReporte
        Dim lstr_NCOEVT As String = ""
        For lint_i As Integer = startIndex To dtbReporte.Columns.Count - 1
          'verifica q sea una columna de evento
          If Not dtbReporte.Columns.Item(lint_i).ColumnName.Contains("Delta:") Then
            lstr_NCOEVT = dtbReporte.Columns.Item(lint_i).ColumnName.ToString.Trim

            Dim lstr_Fecha As String = ""
            Dim lstr_Hora As String = ""

            For lint_j As Integer = 0 To dtbCiclosxEvento.Rows.Count - 1

              If dtbCiclosxEvento.Rows(lint_j).Item("CICLO").ToString.Trim = row("CICLO").ToString AndAlso _
                   dtbCiclosxEvento.Rows(lint_j).Item("NPLCTR").ToString.Trim = row("NPLCTR").ToString AndAlso _
                   lstr_NCOEVT = dtbCiclosxEvento.Rows(lint_j).Item("NCOEVT").ToString.Trim Then

                lstr_Fecha = dtbCiclosxEvento.Rows(lint_j).Item("FECREG").ToString.Trim
                lstr_Hora = dtbCiclosxEvento.Rows(lint_j).Item("HORA").ToString.Trim

                If lstr_Fecha <> "00/00/0000" AndAlso lstr_Hora <> "00:00:00" Then
                  row(lstr_NCOEVT) = lstr_Fecha & " " & lstr_Hora
                Else
                  row(lstr_NCOEVT) = ""
                End If

              End If

            Next
          End If
        Next

        'calculo de diferencia de tiempos (Deltas)
        Dim lstr_ncoaccEv1 As String = ""
        Dim lstr_ncoaccEv2 As String = ""
        Dim t1 As DateTime
        Dim t2 As DateTime
        Dim lbool_t1Stored As Boolean = False
        Dim lbool_t2Stored As Boolean = False

        'For lint_q As Integer = 2 To dtbReporte.Columns.Count - 1
        For lint_q As Integer = startIndex To dtbReporte.Columns.Count - 2
          If dtbReporte.Columns.Item(lint_q).ColumnName.Contains("Delta:") Then
            Dim lstr_colDeltaName As String = dtbReporte.Columns.Item(lint_q).ColumnName
            lstr_colDeltaName = lstr_colDeltaName.Replace("Delta:", "")
            lstr_ncoaccEv2 = (lstr_colDeltaName.Split("-"))(0)
            lstr_ncoaccEv1 = (lstr_colDeltaName.Split("-"))(1)

            If row(lstr_ncoaccEv2).ToString.Trim <> "" AndAlso row(lstr_ncoaccEv1).ToString.Trim <> "" Then
              Try
                t2 = CDate(row(lstr_ncoaccEv2).ToString.Trim)
                t1 = CDate(row(lstr_ncoaccEv1).ToString.Trim)

                '--------------- inicio cálculo diferencia tiempo --------------
                Dim lstr_hora() As String
                Dim lint_h As Integer
                Dim lint_m As Integer
                'Dim lint_s As Integer
                Dim lstr_diff_t As String 'diferencia tiempo
                'diff de al menos 1 dia
                If (t2 - t1).ToString.IndexOf(".") <> -1 Then
                  Dim lstr_lapso() As String
                  Dim lint_cantDias As Integer
                  lstr_lapso = (t2 - t1).ToString.Split(".")

                  'lint_cantDias = System.Math.Abs(CInt(lstr_lapso(0)))
                  lint_cantDias = CInt(lstr_lapso(0))


                  lstr_hora = lstr_lapso(1).ToString.Split(":")
                  lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                  lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                  'lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                  lstr_diff_t = lint_cantDias & "d : " & lint_h & "h " & lint_m & "m " '& lint_s & "s"
                Else
                  lstr_hora = (t2 - t1).ToString.Split(":")

                  'lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                  lint_h = CInt(lstr_hora(0))
                  lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                  'lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                  lstr_diff_t = lint_h & "h " & lint_m & "m " '& lint_s & "s"
                End If
                '--------------- fin cálculo diferencia tiempo --------------
                row("Delta:" & lstr_ncoaccEv2 & "-" & lstr_ncoaccEv1) = lstr_diff_t

              Catch ex As InvalidCastException
              End Try

            End If
          End If
        Next
        dtbReporte.Rows.Add(row)
      Next

      'calculo de sumatorias de las columnas "Delta T"
      Dim rowSumatorias As DataRow = dtbReporte.NewRow

      For Each r As DataRow In dtbReporte.Rows
        For lint_col As Integer = startIndex To dtbReporte.Columns.Count - 2

          If dtbReporte.Columns.Item(lint_col).ColumnName.Contains("Delta:") AndAlso r(lint_col).ToString <> "" Then
            If rowSumatorias(lint_col).ToString = "" Then
              rowSumatorias(lint_col) = 0
            End If
            rowSumatorias(lint_col) = System.Math.Abs(CInt(rowSumatorias(lint_col))) + convertirTiempoEnMinutos(r(lint_col))
          End If

        Next
      Next

      'expresa el tiempo en formato horas minutos
      For lint_q As Integer = startIndex To rowSumatorias.ItemArray.Length - 2
        If rowSumatorias(lint_q).ToString.Length > 0 Then
          If CInt(rowSumatorias(lint_q)) < 60 Then
            rowSumatorias(lint_q) = "0 h " & rowSumatorias(lint_q) & " m"
          Else
            'rowSumatorias(lint_q) = String.Format("{0:n2}", rowSumatorias(lint_q) / 60) & " m"

            Dim totalMM As Integer = 0 'tiempo total en minutos
            Dim dias As Integer = 0
            Dim horas As Integer = 0
            Dim minutos As Integer = 0

            totalMM = CInt(rowSumatorias(lint_q))
            dias = Math.Floor(totalMM / (24 * 60))

            totalMM = totalMM - dias * 24 * 60
            horas = Math.Floor(totalMM / 60)
            minutos = totalMM - horas * 60

            If Not dias = 0 Then
              rowSumatorias(lint_q) = dias & " d " & horas & " h " & minutos & " m"
            Else
              rowSumatorias(lint_q) = horas & " h " & minutos & " m"
            End If


          End If
        End If
      Next
      dtbReporte.Rows.Add(rowSumatorias)

      dtbRetDatatable(0) = dtbEventos
      dtbRetDatatable(1) = dtbReporte
      dtbRetDatatable(2) = dtbEventosCfgDeltaT
      Return dtbRetDatatable

    End Function

    Public Function Listar_Diferencias_Tiempos_x_Config_Eventos_Wap_Workflow_V2(ByVal lstr_pFecIni As String, _
                                                                            ByVal lstr_pFecFin As String, _
                                                                            ByVal lstr_pPlaca As String) As DataTable()

      Dim objParametros As New Hashtable

      Dim dtbCiclosxEvento As New DataTable
      Dim dtbEventos As New DataTable
      Dim dtbReporte As New DataTable
      Dim dtbEventosCfgDeltaT As New DataTable
      Dim dtbCiclosDistinct As New DataTable
      Dim dtbRetDatatable(3) As DataTable
      Dim dwvTracto As New DataView

      objParametros.Add("PARAM_FECINI", lstr_pFecIni)
      objParametros.Add("PARAM_FECFIN", lstr_pFecFin)
      If lstr_pPlaca.ToString.Trim <> "" Then
        objParametros.Add("NPLCTR", lstr_pPlaca)
      Else
        objParametros.Add("NPLCTR", "")
      End If

      'TABLA 1 : CICLOS
      dtbCiclosxEvento = Listar_Eventos_WapST(objParametros)

      'TABLA 2 : EVENTOS DISTINCT
      dtbEventos = Listar_Eventos_Distinct_WapST()

      'TABLA 3 : TABLA REPORTE
      dtbReporte.Columns.Add("CICLO")
      dtbReporte.Columns.Add("NPLCTR")

      'TABLA 4: LISTADO DE EVENTOS A DIFERENCIARSE X TIEMPO
      dtbEventosCfgDeltaT = Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow()

      'TABLA 5: CICLOS DISTINCT
      dwvTracto = Listar_Ciclos_Distinct_WapST(objParametros).DefaultView
      dwvTracto.RowFilter = "TRIM(NPLCTR) LIKE '%" & lstr_pPlaca.Trim & "%'"
      dtbCiclosDistinct = dwvTracto.ToTable

      'crea todas las columnas de eventos del supervisor y solo los deltas establecidos en objDtEventosCfgDeltaT
      For Each rowEvento As DataRow In dtbEventos.Rows
        For Each rowCfgDeltaEventos As DataRow In dtbEventosCfgDeltaT.Rows
          If rowEvento("NCOEVT").ToString.Trim.Equals(rowCfgDeltaEventos("NIVEL2").ToString.Trim) Then
            dtbReporte.Columns.Add("Delta:" & _
                                         rowCfgDeltaEventos("NIVEL2").ToString.Trim & _
                                         "-" & _
                                         rowCfgDeltaEventos("NIVEL1").ToString.Trim)
          End If
        Next
        dtbReporte.Columns.Add(rowEvento("NCOEVT").ToString.Trim)
      Next

      'crea tantos rows como CICLOS existan
      For Each rowCiclo As DataRow In dtbCiclosDistinct.Rows

        'inserta data en las dos primeras cols de dtbReporte
        Dim row As DataRow = dtbReporte.NewRow
        row("CICLO") = rowCiclo.Item("CICLO").ToString().Trim
        row("NPLCTR") = rowCiclo.Item("NPLCTR").ToString().Trim

        'inserta data solo en las cols de eventos de dtbReporte
        Dim lstr_NCOEVT As String = ""
        For lint_i As Integer = 2 To dtbReporte.Columns.Count - 1
          'verifica q sea una columna de evento
          If Not dtbReporte.Columns.Item(lint_i).ColumnName.Contains("Delta:") Then
            lstr_NCOEVT = dtbReporte.Columns.Item(lint_i).ColumnName.ToString.Trim

            Dim lstr_Fecha As String = ""
            Dim lstr_Hora As String = ""
            For lint_j As Integer = 0 To dtbCiclosxEvento.Rows.Count - 1

              If dtbCiclosxEvento.Rows(lint_j).Item("CICLO").ToString.Trim = row("CICLO").ToString AndAlso _
                   dtbCiclosxEvento.Rows(lint_j).Item("NPLCTR").ToString.Trim = row("NPLCTR").ToString AndAlso _
                   lstr_NCOEVT = dtbCiclosxEvento.Rows(lint_j).Item("NCOEVT").ToString.Trim Then

                lstr_Fecha = dtbCiclosxEvento.Rows(lint_j).Item("FECREG").ToString.Trim
                lstr_Hora = dtbCiclosxEvento.Rows(lint_j).Item("HORA").ToString.Trim

                If lstr_Fecha <> "00/00/0000" AndAlso lstr_Hora <> "00:00:00 am" Then
                  row(lstr_NCOEVT) = lstr_Fecha & " " & lstr_Hora
                Else
                  row(lstr_NCOEVT) = ""
                End If

              End If

            Next
          End If
        Next

        'calculo de diferencia de tiempos (Deltas)
        Dim lstr_ncoaccEv1 As String = ""
        Dim lstr_ncoaccEv2 As String = ""
        Dim t1 As DateTime
        Dim t2 As DateTime
        Dim lbool_t1Stored As Boolean = False
        Dim lbool_t2Stored As Boolean = False

        For lint_q As Integer = 2 To dtbReporte.Columns.Count - 1
          If dtbReporte.Columns.Item(lint_q).ColumnName.Contains("Delta:") Then
            Dim lstr_colDeltaName As String = dtbReporte.Columns.Item(lint_q).ColumnName
            lstr_colDeltaName = lstr_colDeltaName.Replace("Delta:", "")
            lstr_ncoaccEv2 = (lstr_colDeltaName.Split("-"))(0)
            lstr_ncoaccEv1 = (lstr_colDeltaName.Split("-"))(1)

            If row(lstr_ncoaccEv2).ToString.Trim <> "" AndAlso row(lstr_ncoaccEv1).ToString.Trim <> "" Then
              Try
                t2 = CDate(row(lstr_ncoaccEv2).ToString.Trim)
                t1 = CDate(row(lstr_ncoaccEv1).ToString.Trim)

                '--------------- inicio cálculo diferencia tiempo --------------
                Dim lstr_hora() As String
                Dim lint_h As Integer
                Dim lint_m As Integer
                Dim lint_s As Integer
                Dim lstr_diff_t As String 'diferencia tiempo
                'diff de al menos 1 dia
                If (t2 - t1).ToString.IndexOf(".") <> -1 Then
                  Dim lstr_lapso() As String
                  Dim lint_cantDias As Integer
                  lstr_lapso = (t2 - t1).ToString.Split(".")

                  'lint_cantDias = System.Math.Abs(CInt(lstr_lapso(0)))
                  lint_cantDias = CInt(lstr_lapso(0))


                  lstr_hora = lstr_lapso(1).ToString.Split(":")
                  lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                  lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                  lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                  lstr_diff_t = lint_cantDias & "d : " & lint_h & "h " & lint_m & "m " & lint_s & "s"
                Else
                  lstr_hora = (t2 - t1).ToString.Split(":")

                  'lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                  lint_h = CInt(lstr_hora(0))

                  lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                  lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                  lstr_diff_t = lint_h & "h " & lint_m & "m " & lint_s & "s"
                End If
                '--------------- fin cálculo diferencia tiempo --------------
                row("Delta:" & lstr_ncoaccEv2 & "-" & lstr_ncoaccEv1) = lstr_diff_t

              Catch ex As InvalidCastException
              End Try

            End If
          End If
        Next
        dtbReporte.Rows.Add(row)
      Next

      ''calculo de sumatorias de las columnas "Delta T"
      Dim rowSumatorias As DataRow = dtbReporte.NewRow

      For Each r As DataRow In dtbReporte.Rows
        For lint_col As Integer = 2 To dtbReporte.Columns.Count - 2

          If dtbReporte.Columns.Item(lint_col).ColumnName.Contains("Delta:") AndAlso r(lint_col).ToString <> "" Then
            If rowSumatorias(lint_col).ToString = "" Then
              rowSumatorias(lint_col) = 0
            End If
            rowSumatorias(lint_col) = System.Math.Abs(CInt(rowSumatorias(lint_col))) + convertirTiempoEnMinutos(r(lint_col))
          End If

        Next
      Next

      'convierte el total de segundos en horas
      For lint_q As Integer = 2 To rowSumatorias.ItemArray.Length - 2
        If rowSumatorias(lint_q).ToString.Length > 0 Then
          If CInt(rowSumatorias(lint_q)) < 60 Then
            rowSumatorias(lint_q) = "0 m"
          Else
            rowSumatorias(lint_q) = rowSumatorias(lint_q) / 60 & " m"
          End If
        End If
      Next
      dtbReporte.Rows.Add(rowSumatorias)

      dtbRetDatatable(0) = dtbEventos
      dtbRetDatatable(1) = dtbReporte
      dtbRetDatatable(2) = dtbEventosCfgDeltaT
      Return dtbRetDatatable

    End Function

    Public Function Listar_Diferencias_Tiempos_x_Config_Eventos_Wap_Workflow(ByVal lstr_pFecIni As String, _
                                                                            ByVal lstr_pFecFin As String, _
                                                                            ByVal lstr_pPlaca As String) As DataTable()

      Dim dtbRetDatatable(3) As DataTable
      Dim objSeguimientoWap As New SeguimientoWAP_BLL
      Dim objParametros As New Hashtable
      Dim dwvColTracto As New DataView
      Dim dwvWapWF As New DataView
      Dim dtbAcciones As New DataTable
      Dim dtbColAcciones As New DataTable
      Dim dtbColTracto As New DataTable
      Dim dtbActividades As New DataTable
      Dim dtbEventosCfgDeltaT As New DataTable
      Dim dtbAuxColAcciones As New DataTable

      'TABLA 1: ACCIONES (no rekiere parametros: si no hay data se listan las col de eventos vacias)
      dtbAcciones = Listar_Eventos_Wap_WorkFlow()
      objParametros.Add("NCOROL", "") '4: codigo de supervisor
      objParametros.Add("FECINI", lstr_pFecIni)
      objParametros.Add("FECFIN", lstr_pFecFin)
      If lstr_pPlaca.ToString.Trim <> "" Then
        objParametros.Add("NPLCTR", lstr_pPlaca)
      Else
        objParametros.Add("NPLCTR", "")
      End If
      dwvColTracto = objSeguimientoWap.Listar_Tractos_Wap_Workflow(objParametros).DefaultView
      dwvColTracto.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"

      'TABLA 2 : COLUMNA VARIABLE 
      dtbColTracto = dwvColTracto.ToTable

      objParametros("NCOROL") = ""
      dwvWapWF = objSeguimientoWap.Listar_Actividades_Wap_Workflow(objParametros).DefaultView
      dwvWapWF.RowFilter = "NPLCTR LIKE '%" & lstr_pPlaca.Trim & "%'"

      'TABLA 3 : ACTIVIDADES
      dtbActividades = dwvWapWF.ToTable
      'dtbActividades.WriteXml("c:\midata1.xml")
      'crea la columna TRACTO
      dtbColAcciones.Columns.Add("PLACA DE TRACTO")

      'TABLA 4: LISTADO DE EVENTOS A DIFERENCIARSE X TIEMPO
      dtbEventosCfgDeltaT = objSeguimientoWap.Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow

      'crea todas las columnas de acciones del supervisor y solo los deltas establecidos en objDtEventosCfgDeltaT
      For Each rowTblAcciones As DataRow In dtbAcciones.Rows
        For Each rowCfgDeltaEventos As DataRow In dtbEventosCfgDeltaT.Rows
          If rowTblAcciones("NCOEVT").ToString.Trim.Equals(rowCfgDeltaEventos("NIVEL2").ToString.Trim) Then
            dtbColAcciones.Columns.Add("Delta:" & _
                                         rowCfgDeltaEventos("NIVEL2").ToString.Trim & _
                                         "-" & _
                                         rowCfgDeltaEventos("NIVEL1").ToString.Trim)
          End If
        Next
        dtbColAcciones.Columns.Add(rowTblAcciones("NCOEVT").ToString.Trim)
      Next

      'crea tantos rows como tractos (objDtColTracto.Rows) existan
      For Each colTractoRow As DataRow In dtbColTracto.Rows
        Dim lstr_DataColTracto As String = colTractoRow.Item(0).ToString().Trim

        'inserta data en la columna variable
        Dim row As DataRow = dtbColAcciones.NewRow
        row("PLACA DE TRACTO") = lstr_DataColTracto

        'inserta data en las columnas de acciones
        Dim lstr_CODACC_ColAccion As String = ""
        For lint_i As Integer = 1 To dtbColAcciones.Columns.Count - 1

          'verifica q sea una columna de accion
          If Not dtbColAcciones.Columns.Item(lint_i).ColumnName.Contains("Delta:") Then
            'si es columna de accion se obtiene su codigo
            lstr_CODACC_ColAccion = dtbColAcciones.Columns.Item(lint_i).ColumnName.ToString.Trim
            Dim lstr_Fecha As String = ""
            Dim lstr_Hora As String = ""
            For lint_j As Integer = 0 To dtbActividades.Rows.Count - 1
              Dim lstr_colName As String = ""
              If dtbActividades.Rows(lint_j).Item("NPLCTR").ToString.Trim = lstr_DataColTracto Then
                If lstr_CODACC_ColAccion = dtbActividades.Rows(lint_j).Item("NCOEVT").ToString.Trim Then
                  lstr_Fecha = dtbActividades.Rows(lint_j).Item(6).ToString
                  lstr_Hora = dtbActividades.Rows(lint_j).Item(5).ToString
                  ' If dtbActividades.Rows(lint_j).Item(6).ToString <> "" Then
                  row(lstr_CODACC_ColAccion) = lstr_Fecha & " " & lstr_Hora
                  'End If
                End If
              End If

            Next
          End If
        Next


        'calculo de diferencia de tiempos (Deltas)
        Dim lstr_ncoaccEv1 As String = ""
        Dim lstr_ncoaccEv2 As String = ""
        Dim t1 As DateTime
        Dim t2 As DateTime
        Dim lbool_t1Stored As Boolean = False
        Dim lbool_t2Stored As Boolean = False

        For lint_q As Integer = 1 To dtbColAcciones.Columns.Count - 1
          If dtbColAcciones.Columns.Item(lint_q).ColumnName.Contains("Delta:") Then
            Dim lstr_colDeltaName As String = dtbColAcciones.Columns.Item(lint_q).ColumnName
            lstr_colDeltaName = lstr_colDeltaName.Replace("Delta:", "")
            lstr_ncoaccEv2 = (lstr_colDeltaName.Split("-"))(0)
            lstr_ncoaccEv1 = (lstr_colDeltaName.Split("-"))(1)

            If row(lstr_ncoaccEv2).ToString.Trim <> "" And row(lstr_ncoaccEv1).ToString.Trim <> "" Then
              t2 = CDate(row(lstr_ncoaccEv2).ToString.Trim)
              t1 = CDate(row(lstr_ncoaccEv1).ToString.Trim)
              '--------------- inicio cálculo diferencia tiempo --------------
              Dim lstr_hora() As String
              Dim lint_h As Integer
              Dim lint_m As Integer
              Dim lint_s As Integer
              Dim lstr_diff_t As String 'diferencia tiempo
              'diff de al menos 1 dia
              If (t2 - t1).ToString.IndexOf(".") <> -1 Then
                Dim lstr_lapso() As String
                Dim lint_cantDias As Integer
                lstr_lapso = (t2 - t1).ToString.Split(".")

                'lint_cantDias = System.Math.Abs(CInt(lstr_lapso(0)))
                lint_cantDias = CInt(lstr_lapso(0))


                lstr_hora = lstr_lapso(1).ToString.Split(":")
                lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                lstr_diff_t = lint_cantDias & "d : " & lint_h & "h " & lint_m & "m " & lint_s & "s"
              Else
                lstr_hora = (t2 - t1).ToString.Split(":")

                'lint_h = System.Math.Abs(CInt(lstr_hora(0)))
                lint_h = CInt(lstr_hora(0))

                lint_m = System.Math.Abs(CInt(lstr_hora(1)))
                lint_s = System.Math.Abs(CInt(lstr_hora(2)))
                lstr_diff_t = lint_h & "h " & lint_m & "m " & lint_s & "s"
              End If
              '--------------- fin cálculo diferencia tiempo --------------
              row("Delta:" & lstr_ncoaccEv2 & "-" & lstr_ncoaccEv1) = lstr_diff_t
            End If
          End If
        Next
        dtbColAcciones.Rows.Add(row)
      Next

      'calculo de sumatorias de las columnas "Delta T"
      Dim rowSumatorias As DataRow = dtbColAcciones.NewRow

      For Each r As DataRow In dtbColAcciones.Rows
        For lint_col As Integer = 2 To dtbColAcciones.Columns.Count - 2
          If dtbColAcciones.Columns.Item(lint_col).ColumnName.Contains("Delta:") Then
            If r(lint_col).ToString <> "" Then
              If rowSumatorias(lint_col).ToString = "" Then
                rowSumatorias(lint_col) = 0
              End If
              rowSumatorias(lint_col) = System.Math.Abs(CInt(rowSumatorias(lint_col))) + convertirTiempoEnMinutos(r(lint_col))
            End If
          End If
        Next
      Next

      'convierte el total de segundos en horas
      For lint_q As Integer = 2 To rowSumatorias.ItemArray.Length - 2
        If rowSumatorias(lint_q).ToString.Length > 0 Then
          If CInt(rowSumatorias(lint_q)) < 60 Then
            rowSumatorias(lint_q) = "0 m"
          Else
            rowSumatorias(lint_q) = rowSumatorias(lint_q) / 60 & " m"
          End If
        End If
      Next
      dtbColAcciones.Rows.Add(rowSumatorias)

      dtbRetDatatable(0) = dtbAcciones
      dtbRetDatatable(1) = dtbColAcciones
      dtbRetDatatable(2) = dtbEventosCfgDeltaT
      Return dtbRetDatatable

    End Function

    Public Function Reiniciar_Ciclo_Wap(ByVal objEntidadSeguimientoWap As SeguimientoWap) As Int64
      Return objDAO.Reiniciar_Ciclo_Wap(objEntidadSeguimientoWap)
    End Function

    Public Function Lista_Eventos_Wap(ByVal strCompania As String) As List(Of SeguimientoWap)
      Return objDAO.Lista_Eventos_Wap(strCompania)
    End Function

    Public Function Listar_Grupo_Seguimiento_Wap()
      Return objDAO.Listar_Grupo_Seguimiento_Wap()
    End Function

  End Class
End Namespace