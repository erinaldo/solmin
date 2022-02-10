Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Reflection

Public Class SeguimientoWap_DAL

  Private objSql As New SqlManager

    ''' <summary>
    ''' Devuelve la lista de eventos del supervisor (distinct de eventos de Listar_Eventos_WapST) CSGWP, 04
    ''' </summary>
    ''' <param name="CSGWP"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_Eventos_Distinct_WapST_1(ByVal CSGWP As String) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_CSGWP", CSGWP)
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAPST_LISTAR_EVENTOS_1", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    ''' <summary>
    ''' devuelve datos para reporte
    ''' </summary>
    ''' <param name="objparametros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar_Detalle_Eventos_Distinct_WapST_1(ByVal objparametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_CSWP", objparametros("PARAM_CSWP"))
            objParam.Add("PARAM_NPLCTR", objparametros("PARAM_NPLCTR"))
            objParam.Add("PARAM_FECINI", objparametros("PARAM_FECINI"))
            objParam.Add("PARAM_FECFIN", objparametros("PARAM_FECFIN"))
            objParam.Add("PARAM_NGSGWP", objparametros("PARAM_NGSGWP"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAPST_LISTAR_DETALLE_EVENTOS_1", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Listar_Unidades_Asignadas_Por_Fecha(ByVal lp_Placa As String, ByVal lp_FecIni As String, ByVal lp_FecFin As String) As List(Of ClaseGeneral)
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Dim objGenericCollection As New List(Of ClaseGeneral)
        Dim objEntidad As New ClaseGeneral

        Try
            objParam.Add("PSNPLCUN", lp_Placa)
            objParam.Add("PNFECINI", lp_FecIni)
            objParam.Add("PNFECFIN", lp_FecFin)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_UNIDADES_ASIGNADAS_POR_FECHA", objParam)
            For Each objData As DataRow In oDt.Rows
                objEntidad = New ClaseGeneral
                objEntidad.NCSOTR = objData("NCSOTR")
                objEntidad.FECOST = objData("FECOST")
                objEntidad.CCLNT = objData("CCLNT")
                objEntidad.TCMPCL = objData("TCMPCL")
                objEntidad.CLCLOR = objData("CLCLOR")
                objEntidad.CLCLDS = objData("CLCLDS")
                objEntidad.RUTA = objData("ORIGEN") & " - " & objData("DESTIN")
                objEntidad.NPLCUN = objData("NPLCUN")
                objEntidad.NRUCTR = objData("NRUCTR")
                objEntidad.CBRCNT = objData("CBRCNT")
                objEntidad.NOMCHOFER = objData("CONDUCTOR")
                objEntidad.NOPRCN = objData("NOPRCN")
                objEntidad.NORSRT = objData("NORSRT")
                objGenericCollection.Add(objEntidad)
            Next
        Catch ex As Exception
            Throw New Exception(ex.ToString())
        End Try
        Return objGenericCollection
    End Function

  Public Function Modificar_Registro_WAP(ByVal objEntidad As RegistroWAP) As String
    Dim objParam As New Parameter
    Try
      objParam.Add("PNFRGTRO", objEntidad.FRGTRO)
      objParam.Add("PNHRGTRO", objEntidad.HRGTRO)
      objParam.Add("PNNCOREG", objEntidad.CICLO)
      objParam.Add("PSNPLCTR", objEntidad.NPLCTR)
      objParam.Add("PNNCOEVT", objEntidad.NCOEVT)
      objParam.Add("PSTOBS", objEntidad.TOBS)
      objParam.Add("PSCULUSA", objEntidad.CULUSA)
      objParam.Add("PNFULTAC", objEntidad.FULTAC)
      objParam.Add("PNHULTAC", objEntidad.HULTAC)
      objParam.Add("PSNTRMNL", objEntidad.NTRMNL)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
      objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_REGISTRO_WAP", objParam)
    Catch ex As Exception
      Return "-1"
    End Try
    Return "1"
  End Function

  Public Function Listar_Ultimo_Ciclo_Tracto(ByVal objparametros As Hashtable) As DataTable
    Dim objDataTable As New DataTable
    Dim objParam As New Parameter
        Try

            If objparametros("NCOREG") = String.Empty Then
                objParam.Add("PSNPLCTR", objparametros("NPLCTR"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objparametros("CCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ULTIMO_CICLO", objParam)
            Else
                objParam.Add("PNNCOREG", objparametros("NCOREG"))
                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objparametros("CCMPN"))
                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CICLO_NCOREG", objParam)
            End If

        Catch ex As Exception
        End Try
    Return objDataTable
    End Function

    'Public Function Listar_Ultimo_Ciclo_Tracto_Multimodal(ByVal objparametros As Hashtable) As DataTable
    '    Dim objDataTable As New DataTable
    '    Dim objParam As New Parameter
    '    Try
    '        objParam.Add("PNNCOREG", objparametros("NCOREG"))
    '        objParam.Add("PSNGSGWP", objparametros("PSNGSGWP"))
    '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objparametros("CCMPN"))
    '        objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CICLO_NCOREG_MULTIMODAL", objParam)
    '    Catch ex As Exception
    '    End Try
    '    Return objDataTable
    'End Function

    Public Function CNumero_a_Hora(ByVal numero As String) As String
        Dim hora As String = ""
        Dim hh As String = ""
        Dim mm As String = ""
        Dim ss As String = ""

        hora = numero

        While hora.Length < 6
            hora = "0" & hora
        End While

        hh = hora.ToString.Substring(0, 2)
        mm = hora.ToString.Substring(2, 2)
        ss = hora.ToString.Substring(4, 2)
        hora = hh & ":" & mm & ":" & ss

        Return hora
    End Function

    Public Function CNumero_a_Fecha(ByVal oFecha As Object) As String
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""

        y = Left(oFecha.ToString(), 4)
        m = Right(Left(oFecha.ToString(), 6), 2)
        d = Right(oFecha.ToString(), 2)


        Dim ret As String = ""
        ret = d & "/" & m & "/" & y
        Return ret
    End Function

    Public Function Listar_Ciclos_Distinct_WapST(ByVal objparametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_FECINI", objparametros("PARAM_FECINI"))
            objParam.Add("PARAM_FECFIN", objparametros("PARAM_FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAPST_LISTADO_CICLOS_DISTINCT_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    'devuelve la lista de eventos del supervisor (distinct de eventos de Listar_Eventos_WapST)
    Public Function Listar_Eventos_Distinct_WapST() As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_CROLWP", "01")
            objParam.Add("PARAM_CSGWP", "01")
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAPST_LISTAR_EVENTOS", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    'devuelve datos para reporte
    Public Function Listar_Eventos_WapST(ByVal objparametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_FECINI", objparametros("PARAM_FECINI"))
            objParam.Add("PARAM_FECFIN", objparametros("PARAM_FECFIN"))
            objParam.Add("PARAM_NGSGWP", objparametros("PARAM_NGSGWP"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAPST_LISTADO_EVENTOS_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function Registrar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal lstr_pNIVEL2 As String, ByVal lstr_pNIVEL1 As String, ByVal lstr_nomDeltaT As String) As String
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNIVEL2", lstr_pNIVEL2)
            objParam.Add("PNNIVEL1", lstr_pNIVEL1)
            objParam.Add("PSTOBS", lstr_nomDeltaT)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_REGISTRAR_CONFIGURACION_DELTA_EVENTOS_WORKFLOW_WAP", objParam)
        Catch ex As Exception
            Return "-1"
        End Try
        Return "1"
    End Function

    Public Function Eliminar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal objParametros As Hashtable) As String
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNIVEL2", objParametros("PNNIVEL2"))
            objParam.Add("PNNIVEL1", objParametros("PNNIVEL1"))
            objParam.Add("PSTOBS", objParametros("PSTOBS"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ELIMINAR_CONFIGURACION_DELTA_EVENTOS_WORKFLOW_WAP", objParam)
        Catch ex As Exception
            Return "-1"
        End Try
        Return "1"
    End Function

    Public Function Modificar_Configuracion_Delta_Eventos_Workflow_Wap(ByVal objParametros As Hashtable) As String
        Dim objParam As New Parameter
        Try
            objParam.Add("OLD_PNNIVEL2", objParametros("OLD_PNNIVEL2"))
            objParam.Add("OLD_PNNIVEL1", objParametros("OLD_PNNIVEL1"))
            objParam.Add("OLD_PSTOBS", objParametros("OLD_PSTOBS"))
            objParam.Add("PNNIVEL2", objParametros("PNNIVEL2"))
            objParam.Add("PNNIVEL1", objParametros("PNNIVEL1"))
            objParam.Add("PSTOBS", objParametros("PSTOBS"))
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_MODIFICAR_CONFIGURACION_DELTA_EVENTOS_WORKFLOW_WAP", objParam)
        Catch ex As Exception
            Return "-1"
        End Try
        Return "1"
    End Function

    Public Function Listar_Roles_Wap() As List(Of RolWap)

        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of RolWap)
        Try

            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ROLES_WAP", Nothing)

            Dim objEntidad As New RolWap
            objEntidad.NCOROL = "0"
            objEntidad.TOBS = "--- TODOS ---"
            objGenericCollection.Add(objEntidad)

            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows

                Dim objDatos As New RolWap

                objDatos.NCOROL = objData("ROL").ToString()
                objDatos.TOBS = objData("TOBS").ToString().Trim

                objGenericCollection.Add(objDatos)

            Next

        Catch ex As Exception
        End Try
        Return objGenericCollection

    End Function

    Public Function Listar_Accion_Wap_Hijo() As List(Of AccionWap)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AccionWap)
        Dim lstr_Codigo As String
        Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACCION_WAP", Nothing)

            For lint_Contador As Integer = 0 To objDataTable.Rows.Count - 1
                Dim objListaDr As DataRow()
                lstr_Codigo = objDataTable.Rows(lint_Contador).Item(0)
                objListaDr = objDataTable.Select("NCOPAD = " & lstr_Codigo.Trim)
                If objListaDr.Length = 0 Then
                    Dim objDatos As New AccionWap
                    objDatos.NCOACC = objDataTable.Rows(lint_Contador).Item(0)
                    objDatos.TABACT = objDataTable.Rows(lint_Contador).Item(1)
                    objGenericCollection.Add(objDatos)
                End If
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function

    Public Function Listar_Eventos_Wap() As List(Of AccionWap)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of AccionWap)
        Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAP_LISTAR_ACCIONES_WAP2", Nothing)

            For lint_Contador As Integer = 0 To objDataTable.Rows.Count - 1
                Dim objDatos As New AccionWap
                objDatos.NCOEVT = objDataTable.Rows(lint_Contador).Item("NCOEVT").ToString.Trim
                objDatos.TNMCEV = objDataTable.Rows(lint_Contador).Item("TNMCEV").ToString.Trim
                objGenericCollection.Add(objDatos)
            Next

        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function

    Public Function Listar_Usuario_Wap() As List(Of UsuarioWap)
        Dim objDataTable As New DataTable
        Dim objGenericCollection As New List(Of UsuarioWap)
        Try
            'Obteniendo resultados
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_USUARIO_WAP", Nothing)
            'Procesandolos como una Lista
            For Each objData As DataRow In objDataTable.Rows
                Dim objDatos As New UsuarioWap
                objDatos.NROMOV = objData("NROMOV").ToString()
                objDatos.TOBS = objData("TOBS").ToString().Trim
                objGenericCollection.Add(objDatos)
            Next
        Catch ex As Exception
        End Try
        Return objGenericCollection
    End Function

    Public Function Listar_Acciones_Wap(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACCIONES_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function Listar_Acciones_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
        Dim objDtListadoAcciones As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objParam.Add("PARAM_NPLCTR", objParametros("NPLCTR"))
            objDtListadoAcciones = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACCIONES_WORKFLOW_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDtListadoAcciones
    End Function

    Public Function Listar_Actividades_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ACTIVIDADES_WORKFLOW_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function Listar_Tractos_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_TRACTOS_WORKFLOW_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function Listar_Usuarios_Wap_Workflow(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_USUARIOS_WORKFLOW_WAP", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

    Public Function Listar_Diferencias_Tiempos(ByVal objParametros As Hashtable) As DataTable

        Dim objDataTable As New DataTable
        Dim objParam As New Parameter

        Try
            objParam.Add("PARAM_NCOROL", objParametros("NCOROL"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAP_LISTADO_DIFERENCIA_TIEMPOS", objParam)

        Catch ex As Exception
        End Try

        Return objDataTable

    End Function

    Public Function Listar_Posiciones_GPS_X_Fehas(ByVal objParametros As Hashtable) As DataTable

        Dim objDataTable As New DataTable
        Dim objParam As New Parameter

        Try
            objParam.Add("PARAM_NPLCTR", objParametros("NPLCTR"))
            objParam.Add("PARAM_FECINI", objParametros("FECINI"))
            objParam.Add("PARAM_FECFIN", objParametros("FECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAP_SEGUIMIENTO_GPS2", objParam)

        Catch ex As Exception
        End Try

        Return objDataTable

    End Function

    Public Function Listar_Tractos_X_Ultima_Ubicacion(ByVal objParametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PSNRUCTR", objParametros("NRUCTR"))
            objParam.Add("PSNPLCUN", objParametros("NPLCUN"))
            objParam.Add("PNNCOEVT", objParametros("NCOEVT"))
            objParam.Add("PSCCMPN", objParametros("CCMPN"))
            objParam.Add("PSCDVSN", objParametros("CDVSN"))
            objParam.Add("PNCPLNDV", objParametros("CPLNDV"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAP_LISTA_VEHICULOS_UBICACION", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

  Public Function Listar_Tractos_X_Ultima_Ubicacion_ManttOpTransporte(ByVal objParametros As Hashtable) As DataTable
    Dim objDataTable As New DataTable
    Dim objParam As New Parameter
    Try
      objParam.Add("PSNRUCTR", objParametros("NRUCTR"))
      objParam.Add("PSNPLCUN", objParametros("NPLCUN"))
      objParam.Add("PNNCOACC", objParametros("NCOACC"))
      objParam.Add("PSCCMPN", objParametros("CCMPN"))
      objParam.Add("PSCDVSN", objParametros("CDVSN"))
      objParam.Add("PNCPLNDV", objParametros("CPLNDV"))

      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParametros("CCMPN"))

      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_WAP_LISTA_VEHICULOS_UBICACION_MANTTOPTRANSP", objParam)
    Catch ex As Exception
    End Try
    Return objDataTable
  End Function

  Public Function Listar_Estado_Flota(ByVal objHash As Hashtable) As DataTable

    Dim objDataTable As New DataTable
    Dim objParam As New Parameter

    Try
      objParam.Add("PSCCMPN", objHash("CCMPN"))
      objParam.Add("PSCDVSN", objHash("CDVSN"))
            objParam.Add("PNCPLNDV", objHash("CPLNDV"))
            objParam.Add("PSNRUCTR", objHash("NRUCTR"))
            objParam.Add("PSNPLCUN", objHash("NPLCUN"))
            objParam.Add("PNNCOACC", objHash("NCOACC"))
      objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objHash("CCMPN"))
      objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ESTADO_FLOTA", Nothing)

    Catch ex As Exception
    End Try

    Return objDataTable

  End Function

    Public Function Listar_Eventos_Wap_WorkFlow() As DataTable
        Dim objDataTable As New DataTable
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EVENTOS_WAP", Nothing)
        Catch ex As Exception
        End Try

        Return objDataTable
    End Function

    Public Function Listar_Eventos_A_Diferenciarse_x_Tiempo_Wap_WorkFlow() As DataTable
        Dim objDataTable As New DataTable
        Try
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_EVENTOS_A_DIFERENCIARSE_X_TIEMPO_WORKFLOW_WAP", Nothing)
        Catch ex As Exception
        End Try

        Return objDataTable
    End Function

    Public Function Obtener_Informacion_Registro_Wap(ByVal Obj_Entidad As RegistroWAP) As UsuarioWap
        Dim objEntidad As New UsuarioWap
        Dim objParam As New Parameter

        Try
            objParam.Add("PNNPLCTR", Obj_Entidad.NPLCTR)
            objParam.Add("PNNCOREG", Obj_Entidad.CICLO)
            objParam.Add("PNNCOEVT", Obj_Entidad.NCOEVT)

            For Each objData As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFORMACION_REGISTRO_EVENTO_WAP", objParam).Rows
                objEntidad.USUARI = objData("USUARI").ToString.Trim
            Next
        Catch ex As Exception
        End Try

        Return objEntidad
    End Function

    Public Function Obtener_Informacion_Ciclo_Wap(ByVal Obj_Entidad As RegistroWAP) As RegistroWAP
        Dim objEntidad As New RegistroWAP
        Dim objParam As New Parameter

        Try
            objParam.Add("PNNPLCTR", Obj_Entidad.NPLCTR)
            objParam.Add("PNNCOREG", Obj_Entidad.CICLO)

            For Each objData As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFORMACION_CICLO_WAP", objParam).Rows
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.FCHCRT = objData("FCHCRT").ToString().Trim
                objEntidad.HRACRT = objData("HRACRT").ToString().Trim
            Next
        Catch ex As Exception
        End Try

        Return objEntidad
    End Function

    Public Function Obtener_Info_RegistroWAP(ByVal objEntidad As RegistroWAP) As RegistroWAP
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNCOREG", objEntidad.CICLO)
            objParam.Add("PNNCOEVT", objEntidad.NCOEVT)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)

            For Each objData As DataRow In objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_INFORMACION_REGISTRO_WAP", objParam).Rows
                objEntidad.NPLCTR = objData("NPLCTR").ToString.Trim
                objEntidad.FCHCRT = objData("FCHCRT").ToString().Trim
                objEntidad.HRACRT = objData("HRACRT").ToString().Trim
                objEntidad.FRGTRO = objData("FRGTRO").ToString().Trim
                objEntidad.HRGTRO = objData("HRGTRO").ToString().Trim
                objEntidad.TOBS = objData("TOBS").ToString().Trim
            Next
        Catch ex As Exception
        End Try

        Return objEntidad
    End Function

    Public Function Reiniciar_Ciclo_Wap(ByVal objEntidadSeguimientoWap As SeguimientoWap) As Int64
        Dim objParam As New Parameter
        Dim intNCOREG As Int64 = 0
        Try

            objParam.Add("PARAM_NPLCTR", objEntidadSeguimientoWap.NPLCTR)
            objParam.Add("PARAM_USUARIO", objEntidadSeguimientoWap.CUSCRT)
            objParam.Add("PARAM_FECHA", objEntidadSeguimientoWap.FRGTRO)
            objParam.Add("PARAM_HORA", objEntidadSeguimientoWap.HRGTRO)
            objParam.Add("PARAM_CMRCDR", 0, ParameterDirection.Output)

            If objEntidadSeguimientoWap.NCOREG = String.Empty Then
                objParam.Add("PARAM_NGSGWP", "01")
                objParam.Add("PARAM_CSGWP", "01")

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidadSeguimientoWap.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_WAPST_INICIAR_CICLO_WAPST", objParam)
                intNCOREG = objSql.ParameterCollection("PARAM_CMRCDR")
            Else
                If objEntidadSeguimientoWap.NGSGWP = "02" Then
                    objParam.Add("PARAM_CSGWP", "04")
                Else
                    objParam.Add("PARAM_CSGWP", "01")
                End If
                objParam.Add("PARAM_NGSGWP", objEntidadSeguimientoWap.NGSGWP)
                objParam.Add("PARAM_NCOREG", objEntidadSeguimientoWap.NCOREG)

                objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidadSeguimientoWap.CCMPN)
                objSql.ExecuteNonQuery("SP_SOLMIN_WAPST_INICIAR_CICLO_WAPST_NCOREG", objParam)
                intNCOREG = objSql.ParameterCollection("PARAM_CMRCDR")
            End If
        Catch ex As Exception
            Return intNCOREG = 0
        End Try
        Return intNCOREG
    End Function



    Public Function Lista_Eventos_Wap(ByVal strCompania As String) As List(Of SeguimientoWap)
        Dim objParam As New Parameter
        Dim oDt As New DataTable
        Dim olbeSeguimientoWap As New List(Of SeguimientoWap)
        Try
            objParam.Add("PSCROLWP", "01")
            objParam.Add("PSCSGWP", "01")
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCompania)
            oDt = objSql.ExecuteDataTable("PS_SOLMIN_ST_LISTA_EVENTOS_WAP", objParam).Copy
            For Each oDr As DataRow In oDt.Rows
                Dim obeolbeSeguimientoWap As New SeguimientoWap
                obeolbeSeguimientoWap.NCOEVT = oDr.Item("NCOEVT").ToString
                obeolbeSeguimientoWap.TNMEV = oDr.Item("TNMEV").ToString
                olbeSeguimientoWap.Add(obeolbeSeguimientoWap)
            Next
        Catch ex As Exception
        End Try
        Return olbeSeguimientoWap
    End Function

    Public Function Listar_Grupo_Seguimiento_Wap() As DataTable
        Dim dtb As New DataTable
        Try
            dtb = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_GRUPO_SEGUIMIENTO_WAP", Nothing)
        Catch ex As Exception

        End Try
        Return dtb
    End Function

    Public Function Listar_Ultimo_Ciclo_Tracto_Multimodal(ByVal objparametros As Hashtable) As DataTable
        Dim objDataTable As New DataTable
        Dim objParam As New Parameter
        Try
            objParam.Add("PNNCOREG", objparametros("NCOREG"))
            objParam.Add("PSNGSGWP", objparametros("NGSGWP"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objparametros("CCMPN"))
            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_CICLO_NCOREG_MULTIMODAL", objParam)
        Catch ex As Exception
        End Try
        Return objDataTable
    End Function

End Class
