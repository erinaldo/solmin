' Librerías del Framework
Imports System.Xml
Imports System.IO
' Librerias del Projecto
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT
Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDA
imports RANSA.NEGO.slnSOLMIN_R02.FiltrosWrrt
Imports RANSA.NEGO.SendFileToEMail
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO

Module mGeneralSDSW
#Region " Tipo de Datos "
    Enum enumPreguntas
        '    PROCESO_Guardar
        '    PROCESO_Eliminar
        '    PROCESO_Modificar
        '    PROCESO_RestaurarGuiaSalida
        '    PROCESO_AnularGuiaSalida
        '    'Agregado para Almaceneras
        PROCESO_Cerrar
        '    GREMISION_AnularGuiaRemision
        '    GREMISION_GenerarGuiaRemision
        '    GREMISION_RestaurarGuiaRemision
        '    DATA_SeleccionItemRepetido
        TICKET_Anularticket
        ORDEN_AnularOrden
    End Enum

    Enum enumMensajes
        '    DATA_InformacionYaExiste
        '    DATA_SeleccionYaExiste
        '    DATA_NoExisteInformacion
        '    GREMISION_OK_AnularGuiaRemision
        '    GREMISION_OK_GenerarGuiaRemision
        '    GREMISION_OK_RestaurarGuiaRemision
        '    GREMISION_Ko_AnularGuiaRemision
        '    GREMISION_Ko_GenerarGuiaRemision
        '    GREMISION_Ko_RestaurarGuiaRemision
        '    INGRESA_SeRequiereNumero
        '    INGRESA_SeRequiereNumeroMYRCero
        '    INGRESA_SeRequiereNumeroMYICero
        '    INGRESA_SeRequiereNumeroMNRSaldo
        '    INGRESA_SeRequiereNumeroMNISaldo
        '    INGRESA_SeRequiereFecha
        '    INGRESA_SeRequiereComentario
        '    PROCESO_OK_Crear
        '    PROCESO_OK_Guardar
        '    PROCESO_OK_Eliminar
        '    PROCESO_OK_Modificar
        '    'Agregado para Almaceneras
        PROCESO_OK_Cerrar
        '    PROCESO_Ko_Crear
        '    PROCESO_Ko_Guardar
        '    PROCESO_Ko_Eliminar
        '    PROCESO_Ko_Modificar
        '    RECEPCION_OrdenServicioCerrada
        '    DESPACHO_OrdenServicioCerrada
        '    TABLA_ItemSeleccionadoYaExiste
        '    TABLA_TablaSinRegistro
        '    NOEXIST_Registrar

    End Enum
#End Region
#Region " Procesos Comunes "
    'Public Function mfblnSalirAplicativo() As Boolean
    '    If MessageBox.Show(" ¿ Desea Salir del Aplicativo ? ", "Salir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        Return True
    '        Exit Function
    '    End If
    '    Return False
    'End Function

    'Public Function mfblnSalirOpcion() As Boolean
    '    If MessageBox.Show(" ¿ Desea Salir ? ", "Salir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        Return True
    '        Exit Function
    '    End If
    '    Return False
    'End Function

    'Public Function mfblnPreguntas(ByVal ePregVarios As enumPregVarios) As Boolean
    '    Dim blnResultado As Boolean = False
    '    Select Case ePregVarios
    '        Case enumPregVarios.DATA_SeleccionItemRepetido
    '            If MessageBox.Show(" Item ya se encuentra seleccionado ¿ Desea volver a Seleccionarlo ? ", "Selección:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.PROCESO_Guardar
    '            If MessageBox.Show(" ¿ Desea Guardar el Registro ? ", "Guardar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.PROCESO_Modificar
    '            If MessageBox.Show(" ¿ Desea Modificar el Registro ? ", "Modificar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.PROCESO_Eliminar
    '            If MessageBox.Show(" ¿ Desea Eliminar el Registro ? ", "Eliminar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '            'Agregado para Almaceneras
    '        Case enumPregVarios.PROCESO_Cerrar
    '            If MessageBox.Show(" ¿ Desea Cerrar el Registro ? ", "Cerrar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.PROCESO_RestaurarGuiaSalida
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Salida ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.PROCESO_AnularGuiaSalida
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Gúia de Salida ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.GREMISION_AnularGuiaRemision
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Gúia de Remisión ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.TICKET_Anularticket
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de Ticket ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.GREMISION_GenerarGuiaRemision
    '            If MessageBox.Show(" ¿ Desea generar la Guia de Remisión respectiva? ", "Generación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.GREMISION_RestaurarGuiaRemision
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Remisión ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '        Case enumPregVarios.ORDEN_AnularOrden
    '            If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Orden de Servicio ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                blnResultado = True
    '            End If
    '    End Select
    '    Return blnResultado
    'End Function

    'Public Sub mpMsjeVarios(ByVal eMsjVarios As enumMsjVarios)
    '    Dim blnResultado As Boolean = False
    '    Select Case eMsjVarios
    '        Case enumMsjVarios.DATA_InformacionYaExiste
    '            MessageBox.Show("Información ya se encuentra registrada en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.DATA_SeleccionYaExiste
    '            MessageBox.Show("Información seleccionada ya se encuentra registrada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.DATA_NoExisteInformacion
    '            MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.GREMISION_OK_AnularGuiaRemision
    '            MessageBox.Show("La Guia de Remisión fue ANULADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.GREMISION_OK_GenerarGuiaRemision
    '            MessageBox.Show("La Guia de Remisión fue GENERADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.GREMISION_OK_RestaurarGuiaRemision
    '            MessageBox.Show("La Guia de Remisión fue RESTAURADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.GREMISION_Ko_AnularGuiaRemision
    '            MessageBox.Show("El proceso de ANULACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.GREMISION_Ko_GenerarGuiaRemision
    '            MessageBox.Show("El proceso de GENERACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.GREMISION_Ko_RestaurarGuiaRemision
    '            MessageBox.Show("El proceso de RESTAURACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.INGRESA_SeRequiereNumero
    '            MessageBox.Show("Debe ingresar un Número.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereNumeroMYRCero
    '            MessageBox.Show("Debe ingresar un Número mayor a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereNumeroMYICero
    '            MessageBox.Show("Debe ingresar un Número mayor o igual a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereNumeroMNRSaldo
    '            MessageBox.Show("Debe ingresar un Número menor al Saldo.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereNumeroMNISaldo
    '            MessageBox.Show("Debe ingresar un Número menor o igual al Saldo.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereFecha
    '            MessageBox.Show("Debe ingresar una Fecha válida.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.INGRESA_SeRequiereComentario
    '            MessageBox.Show("Debe ingresar un Comentario.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.RECEPCION_OrdenServicioCerrada
    '            MessageBox.Show("La Orden de Servicio se encuentra cerrada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.DESPACHO_OrdenServicioCerrada
    '            MessageBox.Show("La Orden de Servicio se encuentra cerrada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.TABLA_ItemSeleccionadoYaExiste
    '            MessageBox.Show("Item seleccionado ya se encuentra registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.TABLA_TablaSinRegistro
    '            MessageBox.Show("No existen elementos. No se puede realizar el proceso.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.PROCESO_OK_Crear
    '            MessageBox.Show("Proceso CREAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.PROCESO_OK_Guardar
    '            MessageBox.Show("Proceso GUARDAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.PROCESO_OK_Modificar
    '            MessageBox.Show("Proceso MODIFICAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Case enumMsjVarios.PROCESO_OK_Eliminar
    '            MessageBox.Show("Proceso ELIMINAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            'Agregado para Almaceneras
    '        Case enumMsjVarios.PROCESO_OK_Cerrar
    '            MessageBox.Show("Proceso CERRAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Case enumMsjVarios.PROCESO_Ko_Crear
    '            MessageBox.Show("Proceso CREAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Case enumMsjVarios.PROCESO_Ko_Guardar
    '            MessageBox.Show("Proceso GUARDAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Case enumMsjVarios.PROCESO_Ko_Modificar
    '            MessageBox.Show("Proceso MODIFICAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Case enumMsjVarios.PROCESO_Ko_Eliminar
    '            MessageBox.Show("Proceso ELIMINAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '        Case enumMsjVarios.NOEXIST_Registrar
    '            MessageBox.Show("No existe información, Debe ingresar la información respectiva.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Select
    'End Sub
#End Region
#Region " Funciones y Procedimientos "
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'
    Public Function mfblnBuscar_AlmacenSDSW(ByVal strTipoAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_SDSWAlmacen(strMensajeError, strTipoAlmacen, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_BreveteSDSW(ByVal strEmpresaTransporte As String, ByRef strNroBrevete As String, ByRef strNombreChofer As String, _
                                        ByRef strNroDocIdentidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "AT"
                dtEntidad = clsGeneralSDSW.fdtBuscar_SDSWBreveteAT(strMensajeError, strEmpresaTransporte, strNroBrevete)
            Case "DS"
                dtEntidad = clsGeneralSDSW.fdtBuscar_SDSWBreveteDS(strMensajeError, strEmpresaTransporte, strNroBrevete)
        End Select

        If strMensajeError <> "" Then
            strNroBrevete = ""
            strNombreChofer = ""
            strNroDocIdentidad = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strNroBrevete = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strNombreChofer = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strNroDocIdentidad = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strNroBrevete = ("" & .SelectedRow(0)).ToString.Trim
                            strNombreChofer = ("" & .SelectedRow(1)).ToString.Trim
                            strNroDocIdentidad = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strNroBrevete = ""
                            strNombreChofer = ""
                            strNroDocIdentidad = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strNroBrevete = ""
                strNombreChofer = ""
                strNroDocIdentidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_ClienteSDSW(ByRef strCodigoCliente As String, ByRef strDetalleCliente As String, _
                                        ByRef strRUCCliente As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim intTemp As Int64 = 0
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False

        ' Validamos la cadena a buscar
        If strDetalleCliente = "" Then
            strMensajeError = "Debe ingresar el Código del Cliente o su Razón Social debe " & vbNewLine & _
                              "tener mínimo 4 caracteres."
        Else
            If Not Int64.TryParse(strDetalleCliente, intTemp) And strDetalleCliente.Length < 4 Then
                strMensajeError = "La Razón Social debe tener mínimo 4 caracteres."
            End If
        End If
        ' Si presenta error se sale de la función


        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            strCodigoCliente = ""
            strDetalleCliente = ""
            strRUCCliente = ""
            blnResultado = False
        Else
            'Agregado para Almaceneras
            dtEntidad = clsGeneralSDSW.fdtBuscar_ClienteGeneralW(strMensajeError, strDetalleCliente)

            If strMensajeError <> "" Then
                MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                strCodigoCliente = ""
                strDetalleCliente = ""
                strRUCCliente = ""
                blnResultado = False
            Else
                ' Evaluamos si trajo mas de una fila
                If dtEntidad.Rows.Count > 0 Then
                    If dtEntidad.Rows.Count = 1 Then
                        strCodigoCliente = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                        strDetalleCliente = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                        strRUCCliente = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                    Else
                        With frmBusqueda
                            .Titulo = dtEntidad.TableName
                            .CampoDefault = 2
                            .DataSource = dtEntidad
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                strCodigoCliente = ("" & .SelectedRow(0)).ToString.Trim
                                strDetalleCliente = ("" & .SelectedRow(1)).ToString.Trim
                                strRUCCliente = ("" & .SelectedRow(2)).ToString.Trim
                            Else
                                strCodigoCliente = ""
                                strDetalleCliente = ""
                                strRUCCliente = ""
                            End If
                            .Dispose()
                        End With
                    End If
                    blnResultado = True
                Else
                    strCodigoCliente = ""
                    strDetalleCliente = ""
                    strRUCCliente = ""
                    blnResultado = False
                    MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dtEntidad.Dispose()
                dtEntidad = Nothing
            End If
        End If
        Return blnResultado
    End Function

    Public Function mfblnBuscar_EmpresaTransporteSDSW(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                  ByRef strNroRUC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Buscamos todas las Incidencias
        Select Case objSeguridadBN.pstrTipoSistema
            Case "AT"
                dtEntidad = clsGeneral.fdtBuscar_EmpresaTransporteAT(strMensajeError, strDetalleEmpresaTransporte)
            Case "DS"
                dtEntidad = clsGeneral.fdtBuscar_EmpresaTransporteDS(strMensajeError, strDetalleEmpresaTransporte)
        End Select

        If strMensajeError <> "" Then
            strCodigoEmpresaTransporte = ""
            strDetalleEmpresaTransporte = ""
            strNroRUC = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoEmpresaTransporte = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleEmpresaTransporte = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strNroRUC = "" & dtEntidad.Rows(0)(2)
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoEmpresaTransporte = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleEmpresaTransporte = ("" & .SelectedRow(1)).ToString.Trim
                            strNroRUC = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strCodigoEmpresaTransporte = ""
                            strDetalleEmpresaTransporte = ""
                            strNroRUC = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoEmpresaTransporte = ""
                strDetalleEmpresaTransporte = ""
                strNroRUC = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_MonedaSDSW(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strSimbolo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_Moneda(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            strSimbolo = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strSimbolo = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                            strSimbolo = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                            strSimbolo = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                strSimbolo = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_MotivoTrasladoSDSW(ByRef strCodigoMotivo As String, ByRef strDetalleMotivo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "AT"
                dtEntidad = clsGeneral.fdtBuscar_MotivoGuiaRemisionAT(strMensajeError, strDetalleMotivo)
            Case "DS"
                dtEntidad = clsGeneral.fdtBuscar_MotivoGuiaRemisionDS(strMensajeError, strDetalleMotivo)
        End Select

        If strMensajeError <> "" Then
            strCodigoMotivo = ""
            strDetalleMotivo = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Evaluamos si trajo mas de una fila
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoMotivo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleMotivo = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoMotivo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleMotivo = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigoMotivo = ""
                            strDetalleMotivo = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoMotivo = ""
                strDetalleMotivo = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_PlacaUnidadSDSW(ByVal strEmpresaTransporte As String, ByRef strPlacaUnidad As String, ByRef strPlacaAcoplado As String, _
                                            ByRef strNroBrevete As String, ByRef strAnio As String, ByRef strMarca As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "AT"
                dtEntidad = clsGeneral.fdtBuscar_PlacaUnidadAT(strMensajeError, strEmpresaTransporte, strPlacaUnidad)
            Case "DS"
                dtEntidad = clsGeneral.fdtBuscar_PlacaUnidadDS(strMensajeError, strEmpresaTransporte, strPlacaUnidad)
        End Select

        If strMensajeError <> "" Then
            strPlacaUnidad = ""
            strPlacaAcoplado = ""
            strNroBrevete = ""
            strAnio = ""
            strMarca = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strPlacaUnidad = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strPlacaAcoplado = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strNroBrevete = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                    strAnio = ("" & dtEntidad.Rows(0)(5)).ToString.Trim
                    strMarca = ("" & dtEntidad.Rows(0)(6)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strPlacaUnidad = ("" & .SelectedRow(0)).ToString.Trim
                            strPlacaAcoplado = ("" & .SelectedRow(1)).ToString.Trim
                            strNroBrevete = ("" & .SelectedRow(2)).ToString.Trim
                            strAnio = ("" & .SelectedRow(5)).ToString.Trim
                            strMarca = ("" & .SelectedRow(6)).ToString.Trim
                        Else
                            strPlacaUnidad = ""
                            strPlacaAcoplado = ""
                            strNroBrevete = ""
                            strAnio = ""
                            strMarca = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strPlacaUnidad = ""
                strPlacaAcoplado = ""
                strNroBrevete = ""
                strAnio = ""
                strMarca = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_PlantaRANSASDSW(ByRef strCodigoPltaOrigen As String, ByRef strDireccionPltaOrigen As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_PlantasRANSA(strMensajeError, strDireccionPltaOrigen)
        If strMensajeError <> "" Then
            strCodigoPltaOrigen = ""
            strDireccionPltaOrigen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoPltaOrigen = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDireccionPltaOrigen = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoPltaOrigen = ("" & .SelectedRow(0)).ToString.Trim
                            strDireccionPltaOrigen = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strCodigoPltaOrigen = ""
                            strDireccionPltaOrigen = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoPltaOrigen = ""
                strDireccionPltaOrigen = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_PlantaPorClientesSDSW(ByVal intCliente As Int64, ByRef strCodigoPltaOrigen As String, ByRef strDireccionPltaOrigen As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_PlantasPorClientes(strMensajeError, intCliente, strDireccionPltaOrigen)
        If strMensajeError <> "" Then
            strCodigoPltaOrigen = ""
            strDireccionPltaOrigen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoPltaOrigen = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDireccionPltaOrigen = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoPltaOrigen = ("" & .SelectedRow(0)).ToString.Trim
                            strDireccionPltaOrigen = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strCodigoPltaOrigen = ""
                            strDireccionPltaOrigen = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoPltaOrigen = ""
                strDireccionPltaOrigen = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado Para Almaceneras
    Public Function mfblnBuscar_TipoAduanaSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_TipoAduana(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    Public Function mfblnBuscar_TipoAlmacenSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_TipoAlmacen(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_Almacen01SDSW(ByRef strZona As String, ByRef strTipo As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_Almacen02(strMensajeError, strZona, strTipo, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_ZonaSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_ZonaAlmacen02(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_ServicioSDSW(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strCompania As String, ByRef strDivision As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_TipoServicio(strMensajeError, strDescripcion, strCompania, strDivision)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_UnidadSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_Unidad(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Unidad de Medida.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfblnBuscar_SectorEconomicoSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_SectorEconomico(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Sector Economico.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_FamiliaSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_Familia(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Unidad de Familia.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_Familia_ProductoSDSW(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strFamilia As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneralSDSW.fdtBuscar_FamiliaProducto(strMensajeError, strFamilia, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Familia de Producto.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almacenaras
    Public Function mfblnBuscar_Ticket1SDSW(ByVal valor As String, ByRef strticket As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsGeneralSDSW.fdtBuscar_NTicket(strMensajeError, valor)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        strticket = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
        blnResultado = True
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    'Agregado para Almacenaras
    Public Function mfblnBuscar_Ticket2SDSW(ByVal valor As String, ByRef strticket As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsGeneralSDSW.fdtBuscar_NTicket(strMensajeError, valor)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        strticket = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
        blnResultado = True
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    Public Function mfblnBuscar_TipoBultoSDSW(ByRef strUnidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strUnidad)
        If strMensajeError <> "" Then
            strUnidad = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strUnidad = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strUnidad = ("" & .SelectedRow(0)).ToString.Trim
                        Else
                            strUnidad = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strUnidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_UnidadMedidaSDSW(ByRef strUnidad As String, ByVal strTipoUnidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_UnidadMedida(strMensajeError, strUnidad, strTipoUnidad)
        If strMensajeError <> "" Then
            strUnidad = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strUnidad = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strUnidad = ("" & .SelectedRow(0)).ToString.Trim
                        Else
                            strUnidad = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strUnidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_ZonasAlmacenSDSW(ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_ZonasAlmacen(strMensajeError, strTipoAlmacen, strAlmacen, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mfblnBuscar_MedioTransporteSDSW(ByRef strCodigoMedioTransporte As String, ByRef strDetalleMedioTransporte As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_MedioTransporte(strMensajeError, strDetalleMedioTransporte)
        If strMensajeError <> "" Then
            strCodigoMedioTransporte = ""
            strDetalleMedioTransporte = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Evaluamos si trajo mas de una fila
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoMedioTransporte = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleMedioTransporte = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoMedioTransporte = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleMedioTransporte = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigoMedioTransporte = ""
                            strDetalleMedioTransporte = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoMedioTransporte = ""
                strDetalleMedioTransporte = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_NaveSDSW(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_Nave(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function



    Public Function mfblnBuscar_SentidoCargaSDSW(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_SentidoCarga(strMensajeError, strDetalle)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Evaluamos si trajo mas de una fila
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDetalle = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDetalle = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_TerminoInternacionalSDSW(ByRef strCodigoTermIntern As String, ByRef strDetalleTermIntern As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_TerminoInternacional(strMensajeError, strDetalleTermIntern)
        If strMensajeError <> "" Then
            strCodigoTermIntern = ""
            strDetalleTermIntern = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoTermIntern = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTermIntern = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoTermIntern = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTermIntern = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigoTermIntern = ""
                            strDetalleTermIntern = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoTermIntern = ""
                strDetalleTermIntern = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_TicketSDSW(ByRef strNroTicket As String, ByRef strPesoTicket As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_Ticket(strMensajeError, strNroTicket)

        If strMensajeError <> "" Then
            strNroTicket = "0"
            strPesoTicket = "0.00"
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strNroTicket = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strPesoTicket = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strNroTicket = ("" & .SelectedRow(0)).ToString.Trim
                            strPesoTicket = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strNroTicket = "0"
                            strPesoTicket = "0.00"
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strNroTicket = "0"
                strPesoTicket = "0.00"
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_TipoDespachoSDSW(ByRef strTipoDespacho As String, ByRef strDetalleTipoDespacho As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_TipoDespacho(strMensajeError, strDetalleTipoDespacho)
        If strMensajeError <> "" Then
            strTipoDespacho = ""
            strDetalleTipoDespacho = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strTipoDespacho = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTipoDespacho = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strTipoDespacho = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTipoDespacho = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strTipoDespacho = ""
                            strDetalleTipoDespacho = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strTipoDespacho = ""
                strDetalleTipoDespacho = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_UbicacionSDSW(ByVal strCliente As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_Ubicacion(strMensajeError, strCliente, strDescripcion)
        If strMensajeError <> "" Then
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strDescripcion = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strDescripcion = ("" & .SelectedRow(0)).ToString.Trim
                        Else
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'
    Public Function mfblnBuscar_SDSWFamilia(ByVal intCliente As Int64, ByRef strFamilia As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_Familia(strMensajeError, intCliente, strDetalle)
        If strMensajeError <> "" Then
            strFamilia = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strFamilia = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strFamilia = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strFamilia = ""
                            strDetalle = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strFamilia = ""
                strDetalle = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWGrupo(ByVal intCliente As Int64, ByVal strFamilia As String, ByRef strGrupo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_Grupo(strMensajeError, intCliente, strFamilia, strDetalle)
        If strMensajeError <> "" Then
            strGrupo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strGrupo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strGrupo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strGrupo = ""
                            strDetalle = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strGrupo = ""
                strDetalle = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWEquivalenteMercRANSA(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_EquivalenteMercRANSA(strMensajeError, strDetalle)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDetalle = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDetalle = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_SDSWEquivalenteMercRANSA1(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim intTemp As Int64 = 0
        ' Validamos la cadena a buscar

        If strDetalle = "" Then
            strMensajeError = "Debe ingresar el Código el descripción de Codigo de Ransa debe " & vbNewLine & _
                              "tener mínimo 4 caracteres."
        Else
            If Not Int64.TryParse(strDetalle, intTemp) And strDetalle.Length < 4 Then
                strMensajeError = "La Descipción debe tener mínimo 4 caracteres."
            End If
        End If
        ' Si presenta error se sale de la función

        If strMensajeError <> "" Then
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            dtEntidad = clsGeneral_SDS.fdtBuscar_EquivalenteMercRANSA(strMensajeError, strDetalle)

            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDetalle = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDetalle = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            dtEntidad.Dispose()
            dtEntidad = Nothing
        End If
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWProveedor(ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, ByRef strRUCProveedor As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_Proveedor(strMensajeError, strDetalleProveedor)
        If strMensajeError <> "" Then
            strCodigoProveedor = ""
            strDetalleProveedor = ""
            strRUCProveedor = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigoProveedor = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleProveedor = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strRUCProveedor = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoProveedor = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleProveedor = ("" & .SelectedRow(1)).ToString.Trim
                            strRUCProveedor = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            strCodigoProveedor = ""
                            strDetalleProveedor = ""
                            strRUCProveedor = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigoProveedor = ""
                strDetalleProveedor = ""
                strRUCProveedor = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWTipoApilabilidad(ByRef strTipoApilabilidad As String, ByRef strDetalleTipoApilibilidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_TipoApilabilidad(strMensajeError, strDetalleTipoApilibilidad)
        If strMensajeError <> "" Then
            strTipoApilabilidad = ""
            strDetalleTipoApilibilidad = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strTipoApilabilidad = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTipoApilibilidad = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strTipoApilabilidad = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTipoApilibilidad = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strTipoApilabilidad = ""
                            strDetalleTipoApilibilidad = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strTipoApilabilidad = ""
                strDetalleTipoApilibilidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWTipoInflamable(ByRef strTipoInflamable As String, ByRef strDetalleTipoInflamable As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_TipoInflamable(strMensajeError, strDetalleTipoInflamable)
        If strMensajeError <> "" Then
            strTipoInflamable = ""
            strDetalleTipoInflamable = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strTipoInflamable = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTipoInflamable = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strTipoInflamable = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTipoInflamable = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strTipoInflamable = ""
                            strDetalleTipoInflamable = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strTipoInflamable = ""
                strDetalleTipoInflamable = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_SDSWTipoPerfumancia(ByRef strTipoPerfumancia As String, ByRef strDetalleTipoPerfumancia As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_TipoPerfumancia(strMensajeError, strDetalleTipoPerfumancia)
        If strMensajeError <> "" Then
            strTipoPerfumancia = ""
            strDetalleTipoPerfumancia = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strTipoPerfumancia = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTipoPerfumancia = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strTipoPerfumancia = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTipoPerfumancia = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strTipoPerfumancia = ""
                            strDetalleTipoPerfumancia = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strTipoPerfumancia = ""
                strDetalleTipoPerfumancia = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_SDSWTipoAlmacen(ByVal strTipo As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_SDSWAlmacenTipo(strMensajeError, strTipo, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                            strDescripcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    Public Function mfblnBuscar_SDSWTipoMovimiento(ByRef strTipoRecepcion As String, ByRef strDetalleTipoRecepcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_TipoMovimiento(strMensajeError, strDetalleTipoRecepcion)
        If strMensajeError <> "" Then
            strTipoRecepcion = ""
            strDetalleTipoRecepcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strTipoRecepcion = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalleTipoRecepcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strTipoRecepcion = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleTipoRecepcion = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strTipoRecepcion = ""
                            strDetalleTipoRecepcion = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strTipoRecepcion = ""
                strDetalleTipoRecepcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBuscar_SDSWProducto(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtBuscar_SDSWProducto(strMensajeError, strCodigo)
        If strMensajeError <> "" Then
            strCodigo = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalle = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strCodigo = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strCodigo = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'
    Public Function mfdtListar_SDSWFamilias(ByVal intCliente As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Familias(intCliente, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSWGrupos(ByVal intCliente As Int64, ByVal strFamilia As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Grupos(intCliente, strFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSWOrdenesServicioPorMercaderia(ByVal intCliente As Int64, ByVal strMercaderia As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_SDSWOrdenServicioMercaderiaW(intCliente, strMercaderia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function
    'Agregado para Almaceneras 
    Public Function mfdtListar_SDSWOrdenServicioporMercaderiaRansa(ByVal intCliente As Int64, ByVal strMercaderia As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_SDSWOrdenServicioMercaderiaRansa(intCliente, strMercaderia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_SDSWOrdenesServicioPorTicket(ByVal strMercaderia As Int64) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_SDSWOrdenServicioMercaderiaOS(strMercaderia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function
    Public Function mfdtListar_SDSWOrdenesServicioPorMercaderiaW(ByVal intCliente As Int64, ByVal strMercaderia As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_SDSWOrdenServicioMercaderiaW(intCliente, strMercaderia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function
    Public Function mfdtListar_SDSWOrdenesServicioPorMercaderiaWO(ByVal intCliente As Int64, ByVal strMercaderia As String, ByVal Orden As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_OrdenServicioMercaderiaWO(intCliente, strMercaderia, Orden, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function
    Public Function mfdtListar_SDSWNorden(ByVal intorden As Int64) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_NOrden(intorden, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function
    Public Function mfdtListar_SDSWMercaderias(ByVal intCliente As Int64, ByVal strFamilia As String, ByVal strGrupo As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Mercaderias(intCliente, strFamilia, strGrupo, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSWMercaderias(ByVal objFiltro As clsFiltro_SDSWListarMercaderia) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Mercaderias(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'fdtListar_AutorizacionSalida
    Public Function mfdtListar_SDSWAutorizacionSalida(ByVal objFiltro As clsFiltro_SDSWListarMercaderia) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWAutorizacionSalida(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtListar_SDSWSolicitudes(ByVal objFiltro As clsFiltro_SDSWConsultaSolicitud) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWSolicitudes(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtListar_SDSWPreFactura(ByVal objfiltro As clsFiltro_SDSWListaPreFactura, _
                                          ByVal Compania As String, ByVal Division As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWPreFactura(objfiltro, Compania, Division, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    'Agregado para Almaceneras

    Public Function mfdtLista_SDSWIngresos(ByVal objFiltro As clsFiltros_SDSWConsultaOrden) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWIngresos(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfdtLista_SDSWSalidas(ByVal objFiltro As clsFiltros_SDSWConsultaOrden) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWSalidas(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtLista_SDSWIngSalDol(ByVal objfiltro As clsFiltros_SDSWConsultaOrden) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdt_Listar_SDSWIngSalDol(objfiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtLista_SDSWIngSalSol(ByVal objfiltro As clsFiltros_SDSWConsultaOrden) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdt_Listar_SDSWIngSalSol(objfiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtLista_SDSWGuiOS(ByVal intCliente As Int64, ByVal intOrden As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWGuiaOS(intCliente, intOrden, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function


    '-------------------------------------'
    ' SISTEMA DEPÓSITO ALMACENES WARRANTS '
    '-------------------------------------'
    Public Function mfdtListar_SDSWOrdenes_Servicio(ByVal objFiltro As slnSOLMIN_R02.FiltrosWrrt) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWOrdenes_Servicio(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '-----------------------------'
    ' SISTEMA DEPÓSITO AUTORIZADO '
    '-----------------------------'
    Public Function mfdtListar_SDSWOrdenesServicios(ByVal objFiltro As clsFiltro_ListarOS) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_OrdenesServicios(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSWDetalleOrdenServicio(ByVal objFiltro As clsFiltro_ListarDetalleOS) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_DetalleOrdenServicio(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSWSeries(ByVal intNroDepositoRansa As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_Series(intNroDepositoRansa, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfdtListar_SDSWTotalVehiculos() As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWVehiculos_Total(strMensajeError)
        Return dtResultado
    End Function
    'Agregado para Alamceneras
    Public Function mfdtListar_SDSWVehiculo(ByVal objfiltro As clsFiltros_SDSWConsultaVehiculos) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWVehiculos(objfiltro, strMensajeError)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    'Lista Vehiculos tabla Temporal
    Public Function mfdtListar_SDSWVehiculo_Temporal() As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_SDSWVehiculos_Temporal(strMensajeError)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    'Pre-Factura
    Public Function mfdtPreFactura_SDSWVehiculo(ByVal objfiltro As clsFiltros_SDSWConsultaVehiculos) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtLista_SDSWPreFactVehiculo(objfiltro, strMensajeError)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    'Genera Operacion - Vehiculo
    Public Function mfdtGenera_SDSWOperacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim objGeneral As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objGeneral.fblnIngreso_SDSWOperacion(strMensajeError, GLOBAL_PCUSUARIO)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    'Genera Orden Despacho
    Public Function mfdtGenera_SDSWOrden() As Boolean
        Dim strMensajeerror As String = ""
        'fdtListarOperacion_Liberacion
        Dim blnResultado As Boolean = True
        Dim objGeneral As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim objBase As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pstrDetalleBaseDatos)
        blnResultado = objGeneral.fdtListarOperacion_SDSWLiberacion(strMensajeerror, objSeguridadBN.pstrDetalleBaseDatos)
        If strMensajeerror <> "" Then MessageBox.Show(strMensajeerror, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Funciones para Obtener Detalle de la Información -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'
    Public Function mfblnObtenerDetalle_SDSWAlmacen(ByVal strTipoAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtObtenerDetalle_Almacen(strMensajeError, strTipoAlmacen, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWMoneda(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strSimbolo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtObtenerDetalle_Moneda(strMensajeError, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            strSimbolo = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strSimbolo = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                strSimbolo = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Moneda.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWTipoAlmacen(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtObtenerDetalle_TipoAlmacen(strMensajeError, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWZonaAlmacen(ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtObtenerDetalle_ZonasAlmacen(strMensajeError, strTipoAlmacen, strAlmacen, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mfblnObtenerDetalle_SDSWEmpresaTransporte(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                          ByRef strNroRUC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Obtengo la información de la empresa de transporte
        dtEntidad = clsGeneral_SAT.fdtObtenerDetalle_EmpresaTransporte(strMensajeError, strCodigoEmpresaTransporte)

        If strMensajeError <> "" Then
            strCodigoEmpresaTransporte = ""
            strDetalleEmpresaTransporte = ""
            strNroRUC = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigoEmpresaTransporte = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleEmpresaTransporte = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strNroRUC = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigoEmpresaTransporte = ""
                strDetalleEmpresaTransporte = ""
                strNroRUC = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWProveedor(ByVal strCliente As String, ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, _
                                           ByRef strRUCProveedor As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtObtenerDetalle_Proveedor(strMensajeError, strCliente, strCodigoProveedor)

        If strMensajeError <> "" Then
            strCodigoProveedor = ""
            strDetalleProveedor = ""
            strRUCProveedor = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigoProveedor = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleProveedor = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strRUCProveedor = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigoProveedor = ""
                strDetalleProveedor = ""
                strRUCProveedor = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'
    Public Function mfblnObtenerDetalle_SDSWChofer(ByVal strEmpresaTransporte As String, ByRef strNroBrevete As String, ByRef strNombreChofer As String, _
                                                  ByRef strNroDocIdentidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWChofer(strMensajeError, strEmpresaTransporte, strNroBrevete)

        If strMensajeError <> "" Then
            strNroBrevete = ""
            strNombreChofer = ""
            strNroDocIdentidad = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strNroBrevete = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strNombreChofer = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strNroDocIdentidad = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strNroBrevete = ""
                strNombreChofer = ""
                strNroDocIdentidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWCodigoMercaderiaRANSA(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWCodigoMercaderiaRANSA(strMensajeError, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información Codigo de Ransa.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfblnObtenerDetalle_SDSWSectorEconomico(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWSectorEconomico(strMensajeError, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información del Sector Economico.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnObtenerDetalle_SDSWUnidadMedida(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWUnidadMedida(strMensajeError, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Unidad de Medida.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWEmpresaTransporteSDS(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                             ByRef strNroRUC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Obtengo la información de la empresa de transporte
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWEmpresaTransporteSDS(strMensajeError, strCodigoEmpresaTransporte)

        If strMensajeError <> "" Then
            strCodigoEmpresaTransporte = ""
            strDetalleEmpresaTransporte = ""
            strNroRUC = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigoEmpresaTransporte = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleEmpresaTransporte = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strNroRUC = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigoEmpresaTransporte = ""
                strDetalleEmpresaTransporte = ""
                strNroRUC = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWFamilia(ByVal strCliente As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWFamiliaSDS(strMensajeError, strCliente, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWGrupo(ByVal strCliente As String, ByVal strFamilia As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWGrupoSDS(strMensajeError, strCliente, strFamilia, strCodigo)

        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWPlacaCamion(ByVal strEmpresaTransporte As String, ByRef strPlaca As String, ByRef strAnio As String, _
                                                       ByRef strMarca As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWPlacaCamion(strMensajeError, strEmpresaTransporte, strPlaca)

        If strMensajeError <> "" Then
            strPlaca = ""
            strAnio = ""
            strMarca = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strPlaca = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strAnio = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strMarca = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strPlaca = ""
                strAnio = ""
                strMarca = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWProveedor(ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, ByRef strRUCProveedor As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWProveedor(strMensajeError, strCodigoProveedor)

        If strMensajeError <> "" Then
            strCodigoProveedor = ""
            strDetalleProveedor = ""
            strRUCProveedor = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strCodigoProveedor = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleProveedor = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                strRUCProveedor = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strCodigoProveedor = ""
                strDetalleProveedor = ""
                strRUCProveedor = ""
                blnResultado = False
                MessageBox.Show("No existe Información de Proveedor.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWTipoApilabilidad(ByRef strTipoApilabilidad As String, ByRef strDetalleApilabilidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWTipoApilabilidad(strMensajeError, strDetalleApilabilidad)

        If strMensajeError <> "" Then
            strTipoApilabilidad = ""
            strDetalleApilabilidad = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strTipoApilabilidad = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleApilabilidad = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strTipoApilabilidad = ""
                strDetalleApilabilidad = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWTipoInflamable(ByRef strTipoInflamable As String, ByRef strDetalleInflamable As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWTipoInflamable(strMensajeError, strTipoInflamable)

        If strMensajeError <> "" Then
            strTipoInflamable = ""
            strDetalleInflamable = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strTipoInflamable = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetalleInflamable = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strTipoInflamable = ""
                strDetalleInflamable = ""
                blnResultado = False
                MessageBox.Show("No existe Información Tipo Inflamable.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSWTipoPerfumancia(ByRef strTipoPerfumancia As String, ByRef strDetallePerfumancia As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_SDSWTipoPerfumancia(strMensajeError, strTipoPerfumancia)

        If strMensajeError <> "" Then
            strTipoPerfumancia = ""
            strDetallePerfumancia = ""
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                strTipoPerfumancia = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                strDetallePerfumancia = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                strTipoPerfumancia = ""
                strDetallePerfumancia = ""
                blnResultado = False
                MessageBox.Show("No existe Información Tipo de Perfurmancia.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mfblnObtener_SDSWNroGuiaRansa(ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
                                              ByVal blnStatusDefinitivo As Boolean, ByRef intNroGuiaRansa As Int64) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        intNroGuiaRansa = objGeneral_SDS.fintObtener_SDSWNroGuiaRansa(strMensajeError, intNroServicio, strTipoDeposito, blnStatusDefinitivo)

        If strMensajeError <> "" Then
            intNroGuiaRansa = 0
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If intNroGuiaRansa > 0 Then
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                intNroGuiaRansa = 0
                strMensajeError = "No se generó correctamente el Nro de Guía RANSA."
                blnResultado = False
            End If
        End If
        objGeneral_SDS = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mstrDefecto_SDSWSentidoCarga(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsGeneral_SAT.fdtDefecto_SentidoCarga(strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
            strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
            blnResultado = True
        Else
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mfblnExiste_SDSWTicket(ByVal strNroTicketBalanza As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SAT.fblnExiste_Ticket(strMensajeError, strNroTicketBalanza)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If Not blnResultado Then MessageBox.Show("El código proporcionado NO existe.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'
    Public Function mfblnExiste_SDSWPlacaCamion(ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_SDSWPlacaCamion(strMensajeError, strEmpresaTransporte, strPlacaCamion)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado
    End Function

    Public Function mfblnExiste_SDSWChofer(ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_SDSWChofer(strMensajeError, strEmpresaTransporte, strNroBrevete)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado
    End Function

    Public Function mfblnExiste_SDSWMercaderia(ByVal strCliente As String, ByVal strFamilia As String, ByVal strGrupo As String, _
                                           ByVal strMercaderia As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_SDSWMercaderia(strMensajeError, strCliente, strFamilia, strGrupo, strMercaderia)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnExiste_SDSWMercaderiaW(ByVal strCliente As String, ByVal strFamilia As String, _
                                              ByVal strMercaderia As String, ByRef strMensajeResultado As String) As Boolean

        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = False
        blnResultado = clsGeneral_SDS.fblnExiste_SDSWMercaderiaW(strMensajeError, strCliente, strFamilia, strMercaderia)

        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado

    End Function


    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'
    Public Function mfblnInsertar_SDSWCamion(ByVal objCamion As clsSDSWCamion) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral_SDS.fblnInsertar_SDSWCamion(strMensajeError, objCamion)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnInsertar_SDSWCamion(ByVal intEmpresaTransporte As Int32, ByVal strNroPlacaCamion As String, ByVal intNroAnioCamion As Int32, _
                                         ByVal strDescripcionMarca As String) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim objCamion As clsSDSWCamion = New clsSDSWCamion
        With objCamion
            .pintEmpresaTransporte_CTRSP = intEmpresaTransporte
            .pstrNroPlacaCamion_NPLCCM = strNroPlacaCamion
            .pintNroAnioCamion_NANOCM = intNroAnioCamion
            .pstrDescripcionMarcaCamion_TMRCCM = strDescripcionMarca
        End With
        Dim blnResultado As Boolean = objGeneral_SDS.fblnInsertar_SDSWCamion(strMensajeError, objCamion)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnInsertar_SDSWChofer(ByVal objChofer As clsSDSWChofer) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral_SDS.fblnInsertar_SDSWChofer(strMensajeError, objChofer)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnActualizar_SDSWMercaderia(ByVal strCliente As String, ByVal strMercaderia As String, ByVal strMercaderiaRel As String) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_sds As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral_sds.fblnActualizar_SDSWMercaderia(strMensajeError, strCliente, strMercaderia, strMercaderiaRel)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnInsertar_SDSWChofer(ByVal intEmpresaTransporte As Int32, ByVal strNroBrevete As String, ByVal strChofer As String, _
                                         ByVal intNroDocIdentidadChofer As Int32) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim objChofer As clsSDSWChofer = New clsSDSWChofer
        With objChofer
            .pintEmpresaTransporte_CTRSP = intEmpresaTransporte
            .pstrNroBrevete_NBRVCH = strNroBrevete
            .pstrChofer_TNMBCH = strChofer
            .pintNroDocIdentidadChofer_NLELCH = intNroDocIdentidadChofer
        End With
        Dim blnResultado As Boolean = objGeneral_SDS.fblnInsertar_SDSWChofer(strMensajeError, objChofer)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    Public Function mfblnCrear_SDSWOrdenServicio(ByVal objOrdenServicio As clsSDSWCrearOrdenServicio) As Boolean
        Dim strMensajeError As String = ""
        Dim intNroGuiaRansa As Int64 = 0
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fbln_SDSWCrearOrdenServicio(strMensajeError, objOrdenServicio, GLOBAL_PCUSUARIO)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnEditar_SDSWOrdenServicio(ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio) As Boolean
        Dim StrMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblnSDSWActualizarOrdenServicio(StrMensajeError, objOrdenServicio, GLOBAL_PCUSUARIO)
        If StrMensajeError <> "" Then MessageBox.Show(StrMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function


    'Agregado para Almaceneras
    Public Function mfblnAnular_SDSWOrdenServicio(ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblnSDSWAnularOrdenServicio(strMensajeError, objOrdenServicio, GLOBAL_PCUSUARIO)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado = True Then MessageBox.Show("La O/S fue anulada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnCerrar_SDSWOrdenServicio(ByVal objOrdenServicio As clsSDSWMovimientoMercaderia) As Boolean
        Dim strMensajeError As String = ""
        Dim intNroGuiaRansa As Int64 = 0
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblnSDSWCerrarOrdenServicio(strMensajeError, objOrdenServicio, GLOBAL_PCUSUARIO)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnCierre_SDSWVehiculo() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim objCierre As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objCierre.fblnCierre_SDSWVehiculo(strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWIngresarVehiculo(ByVal objtemp As clsSDSWInformacionVehiculo) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objVehiculo As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objVehiculo.fblnIngreso_SDSWVehiculo(strMensajeError, objtemp)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objVehiculo = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWPreFactVehiculo(ByVal objtemp As clsSDSWInformacionVehiculo, ByVal Compania As String, ByVal Division As String) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objVehiculo As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objVehiculo.fblnRegistro_SDSWPreFact(strMensajeError, objtemp, Compania, Division)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objVehiculo = Nothing
        Return blnResultado
    End Function
   
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWIngresarInformacionAmcor(ByVal objtemp As clsSDSWInformacionAmcor) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objAmcor As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objAmcor.fblIngreso_SDSWAmcor(strMensajeError, objtemp)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objAmcor = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWActualizaEstadoAmcor(ByVal strFlag As String, ByVal strGuia As String) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objAmcor As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objAmcor.fblnActualizaEstado_SDSWAmcor(strMensajeError, strFlag, strGuia)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objAmcor = Nothing
        Return blnResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWIngresarInformacionRelacionEtiqueta(ByVal objEtiqueta As clsSDSWInformacionAmcor)
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objAmcor As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objAmcor.fblnRelacionEtiqueta(strMensajeError, objEtiqueta)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objAmcor = Nothing
        Return blnResultado

    End Function

    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWListaInformacionAmcor(ByVal GuiaI As String, ByVal GuiaS As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtLista_SDSWAmcor(GuiaI, GuiaS, strMensajeError)
        Return dtResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWDespachoInformacionAmcor(ByVal Guia As String)
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fblnIngreso_SDSWConsultaDespachoAmcor(strMensajeError, Guia)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWConsulta_Estado_Amcor(ByVal strGuia As String)
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fblnConsulta_Estado_Amcor(strMensajeError, strGuia)
        Return dtResultado
    End Function
    'fblnIngreso_SDSWConsultaDespachoAmcor
    'Agregado para Almaceneras
    Public Function mfblnProceso_BuscaOS() As DataTable
        Dim dtResultado As DataTable
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtLista_NumOS(strMensajeError)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWDetalleAmcor(ByVal Guia As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtObtener_DetalleAMcor(strMensajeError, Guia)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWCabeceraAmcor(ByVal strFecha As Date, ByVal strFlag As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtObtener_CabeceraAmcorConsulta(strMensajeError, strFecha, strFlag)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWDetalleAmcorConsulta(ByVal strNoprcn As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtObtener_DetalleAmcorConsulta(strMensajeError, strNoprcn)
        Return dtResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfblnProceso_SDSWDetalleItemAmcor(ByVal Orden As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtObtener_DetalleItemAmcorConsulta(strMensajeError, Orden)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnBusca_OrdenAmcor(ByVal Orden As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fblnConsulta_Orden_Amcor(strMensajeError, Orden)
        Return dtResultado
    End Function
    'Agregado para Almaceneras
    Public Function mfblnCrear_SDSWDespachoAmcor(ByVal Operacion As String) As Boolean
        Dim strMensajeError As String = ""
        Dim intNroGuiaRansa As Int64 = 0
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblSalida_SDSWAmcor(strMensajeError, Operacion, GLOBAL_PCUSUARIO)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    Public Function mfblnActualizar_SDSWOrdenAmcor(ByVal Orden As String, ByVal Guia As String, ByVal Articulo As String) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral_sds As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral_sds.fblnActualizar_SDSWOrdenAmcor(strMensajeError, Orden, Guia, Articulo)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function


    'Agregado para Almaceneras
    Public Function mfblnExiste_SDSWOrdenOperacion(ByVal Compania As String, ByVal Division As String, _
                                          ByVal objOrdenServicio As clsSDSWInformacionOrdenServicio, _
                                          ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        'Verifica si la O/S tiene operaciones activas en el sistema
        With objOrdenServicio
            blnResultado = clsGeneral_SDS.fblnSDSWExiste_OrdenOperacion(strMensajeError, Compania, Division, objOrdenServicio)
        End With
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado = True Then
            MessageBox.Show("La Orden de Servicio:" & objOrdenServicio.pintOrdenServicio_NORDSR & " tiene operación(es) registradas" & vbNewLine & _
                         "en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return blnResultado
        End If

        If blnResultado = False Then
            Return blnResultado
        End If
    End Function
    'Agregado para Almaceneras


    '------------------------------------------------------------------------------------------------------------------'
    '- Generación de Archivos XLS -'
    '------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'




    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'

    ' RUTINA A SER CONVERTIDAS A PROCEDURE
    Public Sub pBuscarPlacaAcopladoSDSW(ByVal strEmpresaTransporte As String, ByRef strPlacaAcoplado As String, ByRef Status As Boolean)
        Dim objGeneralBN As clsGeneral_SAT = New clsGeneral_SAT(objSeguridadBN.pUsuario)
        Dim dtEntidad As DataTable = Nothing

        strPlacaAcoplado = strPlacaAcoplado.Replace("*", "%")
        Try
            dtEntidad = objGeneralBN.fdatListarNumeroPlacaAcoplado(strEmpresaTransporte, strPlacaAcoplado)

            ' Evaluamos si trajo mas de una fila
            If dtEntidad IsNot Nothing Then
                If dtEntidad.Rows.Count = 1 Then
                    strPlacaAcoplado = "" & dtEntidad.Rows(0)(0)
                Else
                    With frmBusqueda
                        .Titulo = "Placa Acoplado"
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strPlacaAcoplado = "" & .SelectedRow(0)
                        Else
                            strPlacaAcoplado = ""
                        End If
                        .Dispose()
                    End With
                End If
            Else
                MessageBox.Show("No existe Placa Acoplado.", "Buscar Placa Acoplado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strPlacaAcoplado = ""
            End If
            Status = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Buscar Placa Acoplado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dtEntidad IsNot Nothing Then dtEntidad.Dispose()
            objGeneralBN = Nothing
            dtEntidad = Nothing
        End Try
    End Sub

    'Agregado para Almaceneras
    Public Function mfblnObtener_SDSWSaldosAutorizacion(ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
                                              ByVal blnStatusDefinitivo As Boolean, ByRef intNroGuiaRansa As Int64) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        intNroGuiaRansa = objGeneral_SDS.fintObtener_SDSWResultadoSaldoAutorizacion(strMensajeError, intNroServicio, strTipoDeposito, blnStatusDefinitivo)

        If strMensajeError <> "" Then
            intNroGuiaRansa = 0
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If intNroGuiaRansa > 0 Then
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                intNroGuiaRansa = 0
                strMensajeError = "No se generó correctamente el Nro de Guía RANSA."
                blnResultado = False
            End If
        End If
        objGeneral_SDS = Nothing
        Return blnResultado
    End Function



#End Region
#Region " Funciones de Transferencia a Excel "
    'Public Sub pExportarToXLSSDSW(ByVal strFileXLS As String, ByVal iXref As Integer, ByVal iYref As Integer, ByVal dtTemp As DataTable)
    '    Dim oExcel As Object = Nothing
    '    Dim oBook As Object = Nothing
    '    Dim oBooks As Object = Nothing
    '    Dim oWorksheet As Object
    '    Dim objType As Type
    '    Dim i As Int16 = 0
    '    Dim j As Int16 = 0
    '    Try
    '        ' Validamos que la coleccion de filas no sea nothing
    '        If Not dtTemp Is Nothing Then
    '            ' Iniciamos Excel y abrimos un libro
    '            objType = Type.GetTypeFromProgID("Excel.Application")
    '            oExcel = Activator.CreateInstance(objType)
    '            oExcel.Visible = True
    '            oBooks = oExcel.Workbooks
    '            oBook = oBooks.Open(strFileXLS)

    '            ' Asignamos el objeto Sheet
    '            oWorksheet = oBook.ActiveSheet

    '            ' Agregar las Filas de Datos
    '            For j = 0 To dtTemp.Rows.Count - 1 'intHeaders - 1
    '                ' Cargar la data
    '                For i = 0 To dtTemp.Columns.Count - 1
    '                    oWorksheet.Cells(iYref + j, i + iXref).Value = "" & dtTemp.Rows(j).Item(i)
    '                Next i
    '            Next j
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        ' Eliminamos los objetos
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
    '        oBook = Nothing
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
    '        oBooks = Nothing
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
    '        oExcel = Nothing
    '        oExcel = Nothing
    '        oBook = Nothing
    '        oBooks = Nothing
    '        oWorksheet = Nothing
    '    End Try
    'End Sub
#End Region
#Region " Rutinas AppConfig "
    'Public Enum ConfigFileType
    '    WebConfig
    '    AppConfig
    'End Enum

    'Public Class cAppConfig
    '    Inherits System.Configuration.AppSettingsReader

    '    Public docName As String = String.Empty
    '    Private node As XmlNode = Nothing
    '    Private _configType As Integer

    '    Public Property ConfigType() As Integer
    '        Get
    '            Return _configType
    '        End Get
    '        Set(ByVal Value As Integer)
    '            _configType = Value
    '        End Set
    '    End Property

    '    Public Function SetValue(ByVal key As String, ByVal value As String) As Boolean
    '        Dim cfgdoc As New XmlDocument()
    '        Call loadConfigDoc(cfgdoc)

    '        node = cfgdoc.SelectSingleNode("//appSettings")
    '        If node Is Nothing Then
    '            Throw New System.InvalidOperationException("appSettings section not found")
    '        End If

    '        Try
    '            Dim addElem As XmlElement = CType(node.SelectSingleNode("//add[@key='" + key + "']"), XmlElement)

    '            If Not addElem Is Nothing Then
    '                addElem.SetAttribute("value", value)
    '            Else
    '                Dim enTry As XmlElement = cfgdoc.CreateElement("add")
    '                enTry.SetAttribute("key", key)
    '                enTry.SetAttribute("value", value)
    '                node.AppendChild(enTry)
    '            End If
    '            Call saveConfigDoc(cfgdoc, docName)
    '            Return True
    '        Catch
    '            Return False
    '        End Try
    '    End Function

    '    Private Sub saveConfigDoc(ByVal cfgDoc As XmlDocument, ByVal cfgDocPath As String)
    '        Try
    '            Dim writer As XmlTextWriter = New XmlTextWriter(cfgDocPath, Nothing)
    '            writer.Formatting = Formatting.Indented
    '            cfgDoc.WriteTo(writer)
    '            writer.Flush()
    '            writer.Close()
    '            Return
    '        Catch
    '            Throw
    '        End Try
    '    End Sub

    '    Public Function removeElement(ByVal elementKey As String) As Boolean
    '        Try
    '            Dim cfgDoc As XmlDocument = New XmlDocument()
    '            loadConfigDoc(cfgDoc)
    '            ' recupero el nodo appSettings
    '            node = cfgDoc.SelectSingleNode("//appSettings")
    '            If node Is Nothing Then
    '                Throw New System.InvalidOperationException("appSettings section not found")
    '            End If
    '            ' XPath selecionamos el elemento "add" que contiene la clave a remover
    '            node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"))

    '            saveConfigDoc(cfgDoc, docName)
    '            Return True
    '        Catch
    '            Return False
    '        End Try
    '    End Function

    '    Private Function loadConfigDoc(ByVal cfgDoc As XmlDocument) As XmlDocument
    '        Dim Asm As System.Reflection.Assembly
    '        ' cargamos el archivo de configuración
    '        If Convert.ToInt32(ConfigType) = Convert.ToInt32(ConfigFileType.AppConfig) Then
    '            docName = ((Asm.GetEntryAssembly()).GetName()).Name
    '            docName += ".exe.config"
    '            'Else
    '            '    docName = System.Web.HttpContext.Current.Server.MapPath("web.config")
    '        End If
    '        cfgDoc.Load(Application.StartupPath & "\" & docName)
    '        Return cfgDoc
    '    End Function
    'End Class
#End Region
End Module