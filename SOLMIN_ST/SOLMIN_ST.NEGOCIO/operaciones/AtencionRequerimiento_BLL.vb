
Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES

Public Class AtencionRequerimiento_BLL

    Dim oDatos As New AtencionRequerimiento_DAL


    'Public Function Lista_Requerimiento_Servicio(ByVal ObjEntidad As RequerimientoServicio) As List(Of RequerimientoServicio)

    '    Return oDatos.Lista_Requerimiento_Servicio(ObjEntidad)

    'End Function

    Public Function Lista_Tipo_Mercaderia() As DataTable
        Dim dt As New DataTable

        dt = oDatos.Lista_Tipo_Mercaderia()

        Return dt
    End Function


    'Public Function intInsertarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Decimal

    '    Return oDatos.intInsertarRequerimientoServicio(ObjEntidad)

    'End Function


    'Public Sub intActualizarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio)

    '    oDatos.intActualizarRequerimientoServicio(ObjEntidad)

    'End Sub

    'Public Function intEliminarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Integer

    '    Return oDatos.intEliminarRequerimientoServicio(ObjEntidad)

    'End Function


    ''Public Function intRevisarRequerimientoServicio(ByVal ObjEntidad As RequerimientoServicio) As Integer

    ''    Return oDatos.intRevisarRequerimientoServicio(ObjEntidad)

    ''End Function


    Public Function intActualizarRequerimientoSolicitud(ByVal ObjEntidad As AtencionRequerimiento) As Integer

        Return oDatos.intActualizarRequerimientoSolicitud(ObjEntidad)

    End Function


    Public Function Registrar_Solicitud_Transporte_Requerimiento(ByVal objEntidad As ENTIDADES.Operaciones.Solicitud_Transporte) As ENTIDADES.Operaciones.Solicitud_Transporte
        Return oDatos.Registrar_Solicitud_Transporte_Requerimiento(objEntidad)
    End Function

    Public Function Lista_Requerimiento_Servicio_Estado_Actual(ByVal ObjEntidad As AtencionRequerimiento) As AtencionRequerimiento

        Return oDatos.Lista_Requerimiento_Servicio_Estado_Actual(ObjEntidad)

    End Function

    Public Function Lista_Negocio(ByVal CCMPN As String) As DataTable
        Dim dt As New DataTable

        dt = oDatos.Lista_Negocio(CCMPN)

        Return dt
    End Function

    'Public Function olisListarResponsables(ByVal obeResponsable As beDestinatario) As List(Of beDestinatario)
    '    Dim oEnvioEmailNotificacion As New EnvioEmailNotificacion
    '    Return oEnvioEmailNotificacion.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(obeResponsable)
    'End Function

    Public Function olisListarResponsables(ByVal PNCCLNT As Decimal, ByVal PSTIPPROC As String) As List(Of beDestinatario)
        Dim oEnvioEmailNotificacion As New EnvioEmailNotificacion
        Return oEnvioEmailNotificacion.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(PNCCLNT, PSTIPPROC)
    End Function

    Public Function Lista_Atencion_Requerimiento(ByVal ObjEntidad As AtencionRequerimiento) As DataTable ''List(Of AtencionRequerimiento)

        Return oDatos.Lista_Atencion_Requerimiento(ObjEntidad)

    End Function

    Public Sub Verificar_Solicitudes_Actualizar_Requerimiento(ByVal objAtenReq As AtencionRequerimiento) '' ByVal NUMREQT As Decimal, ByVal CCMPN As String)
        Dim objSolicitudTransporte As New Operaciones.Solicitud_Transporte_BLL
        Dim objSolicitudTransporteRequerimiento As New AtencionRequerimiento_BLL
        Dim olstSolReq As New List(Of ENTIDADES.Operaciones.Solicitud_Transporte)
        Dim objSolTrsp As New ENTIDADES.Operaciones.Solicitud_Transporte
        ''Dim objAtenReq As New AtencionRequerimiento
        objSolTrsp.NUMREQT = objAtenReq.NUMREQT ''NUMREQT '_pRequerimientoServicio.NUMREQT
        objSolTrsp.CCMPN = objAtenReq.CCMPN ''CCMPN 'Me.cmbCompania.CCMPN_CodigoCompania
        olstSolReq = objSolicitudTransporte.Listar_Estado_Solicitud_Requerimiento(objSolTrsp)

        If olstSolReq.Count > 0 Then
            If (CDec(Val(olstSolReq.Item(0).NCSOTR)) > 0) Then
                For Each obeSolReq As ENTIDADES.Operaciones.Solicitud_Transporte In olstSolReq
                    If obeSolReq.SESSLC = "P" Then
                        objAtenReq.SESREQ = "A"
                        Exit For
                    ElseIf obeSolReq.SESSLC = "C" Then
                        objAtenReq.SESREQ = "C"
                    End If
                Next
            Else
                If olstSolReq.Item(0).SJTTR = "X" Then
                    objAtenReq.SESREQ = "A"
                Else
                    objAtenReq.SESREQ = "P"
                End If
            End If

        End If

        If objAtenReq.SESREQ <> "" Then
            'objAtenReq.NUMREQT = obeAtencionReq.NUMREQT '_pRequerimientoServicio.NUMREQT
            'objAtenReq.CCMPN = obeAtencionReq.CCMPN ''CCMPN 'Me.cmbCompania.CCMPN_CodigoCompania
            'objAtenReq.CUSCRT = obeAtencionReq.CUSCRT ''MainModule.USUARIO
            'objAtenReq.NTRMCR = obeAtencionReq.NTRMCR ''HelpClass.NombreMaquina
            If objSolicitudTransporteRequerimiento.intActualizarRequerimientoSolicitud(objAtenReq) = 1 Then
                'OK
            End If
        End If
    End Sub

    Public Function Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(ByVal objEntidad As ENTIDADES.mantenimientos.ClaseGeneral) As List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Return oDatos.Obtener_Detalle_Solicitud_Asignada_X_Requerimiento(objEntidad)
    End Function

    Public Function Listar_Estado_Solicitud_Requerimiento(ByVal objEntidad As AtencionRequerimiento) As List(Of AtencionRequerimiento)
        Return oDatos.Listar_Estado_Solicitud_Requerimiento(objEntidad)
    End Function

    Public Function Actualizar_OS_Requerimiento(ByVal objEntidad As AtencionRequerimiento) As Integer
        Return oDatos.intActualizar_OS_Requerimiento(objEntidad)
    End Function

    Public Function Lista_Atencion_Requerimiento_Detalle_Exportar(ByVal ObjEntidad As AtencionRequerimiento) As DataTable ''List(Of AtencionRequerimiento)
        Return oDatos.Lista_Atencion_Requerimiento_Detalle_Exportar(ObjEntidad)
    End Function

    Public Function Obtener_Datos_OrdenServicio_Requerimiento(ByVal ObjEntidad As AtencionRequerimiento) As DataTable ''List(Of AtencionRequerimiento)
        Return oDatos.Obtener_Datos_OrdenServicio_Requerimiento(ObjEntidad)
    End Function

    Public Function Verificar_Estado_Requerimiento(ByVal objAtenReq As AtencionRequerimiento) As List(Of ENTIDADES.Operaciones.Solicitud_Transporte)
        Dim objSolicitudTransporte As New Operaciones.Solicitud_Transporte_BLL
        Dim objSolTrsp As New ENTIDADES.Operaciones.Solicitud_Transporte
        objSolTrsp.NUMREQT = objAtenReq.NUMREQT
        objSolTrsp.CCMPN = objAtenReq.CCMPN
        Return objSolicitudTransporte.Listar_Estado_Solicitud_Requerimiento(objSolTrsp)
    End Function


End Class
