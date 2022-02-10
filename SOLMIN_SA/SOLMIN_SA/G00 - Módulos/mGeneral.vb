' Librerías del Framework
Imports System.Xml
Imports System.IO
' Librerias del Projecto
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.Rutime.HojaCalculo
Imports Ransa.NEGO
Imports Ransa.NEGO.slnSOLMIN
Imports Ransa.NEGO.slnSOLMIN_SAT
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDA
Imports Ransa.NEGO.SendFileToEMail
Imports Ransa.Utilitario
Imports System.Reflection
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Module mGeneral
#Region " Tipo de Datos "
    Enum enumPregVarios
        PROCESO_Guardar
        PROCESO_Eliminar
        PROCESO_Modificar
        PROCESO_RestaurarGuiaSalida
        PROCESO_AnularGuiaSalida
        PALETA_AgregarBulto
        PALETA_EliminarBulto
        GREMISION_AnularGuiaRemision
        GREMISION_EliminarGuiaRemision
        GREMISION_GenerarGuiaRemision
        GREMISION_RestaurarGuiaRemision
        DATA_SeleccionItemRepetido
        '===========ACD===============
        ORDEN_AnularOrden
        PROCESO_Cerrar
        '=============================
    End Enum

    Enum enumMsjVarios
        DATA_InformacionYaExiste
        DATA_SeleccionYaExiste
        DATA_NoExisteInformacion
        GREMISION_OK_AnularGuiaRemision
        GREMISION_OK_GenerarGuiaRemision
        GREMISION_OK_RestaurarGuiaRemision
        GREMISION_Ko_AnularGuiaRemision
        GREMISION_Ko_GenerarGuiaRemision
        GREMISION_Ko_RestaurarGuiaRemision
        INGRESA_SeRequiereNumero
        INGRESA_SeRequiereNumeroMYRCero
        INGRESA_SeRequiereNumeroMYICero
        INGRESA_SeRequiereNumeroMNRSaldo
        INGRESA_SeRequiereNumeroMNISaldo
        INGRESA_SeRequiereFecha
        INGRESA_SeRequiereComentario
        PROCESO_OK_Crear
        PROCESO_OK_Guardar
        PROCESO_OK_Eliminar
        PROCESO_OK_Modificar
        PROCESO_Ko_Crear
        PROCESO_Ko_Guardar
        PROCESO_Ko_Eliminar
        PROCESO_Ko_Modificar
        RECEPCION_OrdenServicioCerrada
        DESPACHO_OrdenServicioCerrada
        TABLA_ItemSeleccionadoYaExiste
        TABLA_TablaSinRegistro
        NOEXIST_Registrar
        '==============ACD=================
        PROCESO_OK_Cerrar
        '==================================
    End Enum
#End Region
#Region " Procesos Comunes "
    Public Function mfblnSalirAplicativo() As Boolean
        If MessageBox.Show(" ¿ Desea Salir del Aplicativo ? ", "Salir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Public Function mfblnSalirOpcion() As Boolean
        If MessageBox.Show(" ¿ Desea Salir ? ", "Salir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Return True
            Exit Function
        End If
        Return False
    End Function

    Public Function mfblnPreguntas(ByVal ePregVarios As enumPregVarios) As Boolean
        Dim blnResultado As Boolean = False
        Select Case ePregVarios
            Case enumPregVarios.DATA_SeleccionItemRepetido
                If MessageBox.Show(" Item ya se encuentra seleccionado ¿ Desea volver a Seleccionarlo ? ", "Selección:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_Guardar
                If MessageBox.Show(" ¿ Desea Guardar el Registro ? ", "Guardar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_Modificar
                If MessageBox.Show(" ¿ Desea Modificar el Registro ? ", "Modificar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_Eliminar
                If MessageBox.Show(" ¿ Desea Eliminar el Registro ? ", "Eliminar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PALETA_EliminarBulto
                If MessageBox.Show(" ¿ Desea Eliminar Bulto de la Paleta ? ", "Eliminar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_RestaurarGuiaSalida
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Salida ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.GREMISION_EliminarGuiaRemision
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Eliminar Guia de Remisión ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_AnularGuiaSalida
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Gúia de Salida ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.GREMISION_AnularGuiaRemision
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de la Gúia de Remisión ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.GREMISION_GenerarGuiaRemision
                If MessageBox.Show(" ¿ Desea generar la Guia de Remisión respectiva? ", "Generación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.GREMISION_RestaurarGuiaRemision
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Remisión ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
                '==================ACD=============
            Case enumPregVarios.ORDEN_AnularOrden
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Remisión ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
            Case enumPregVarios.PROCESO_Cerrar
                If MessageBox.Show(" ¿ Desea realizar el Proceso de Restaurar Guia de Remisión ? ", "Restaurar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    blnResultado = True
                End If
                '==================================
        End Select
        Return blnResultado
    End Function

    Public Sub gfMostrarFormularioEnMDI(ByVal form As Form, ByVal mdi As Form, Optional ByVal strTag As String = "")
        With form
            .MdiParent = mdi
            .Tag = strTag
            .Show()
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
        End With
    End Sub

    Public Sub mpMsjeVarios(ByVal eMsjVarios As enumMsjVarios)
        Dim blnResultado As Boolean = False
        Select Case eMsjVarios
            Case enumMsjVarios.DATA_InformacionYaExiste
                MessageBox.Show("Información ya se encuentra registrada en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.DATA_SeleccionYaExiste
                MessageBox.Show("Información seleccionada ya se encuentra registrada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.DATA_NoExisteInformacion
                MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.GREMISION_OK_AnularGuiaRemision
                MessageBox.Show("La Guia de Remisión fue ANULADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.GREMISION_OK_GenerarGuiaRemision
                MessageBox.Show("La Guia de Remisión fue GENERADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.GREMISION_OK_RestaurarGuiaRemision
                MessageBox.Show("La Guia de Remisión fue RESTAURADA correctamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.GREMISION_Ko_AnularGuiaRemision
                MessageBox.Show("El proceso de ANULACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.GREMISION_Ko_GenerarGuiaRemision
                MessageBox.Show("El proceso de GENERACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.GREMISION_Ko_RestaurarGuiaRemision
                MessageBox.Show("El proceso de RESTAURACIÓN no pudo culminar satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.INGRESA_SeRequiereNumero
                MessageBox.Show("Debe ingresar un Número.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereNumeroMYRCero
                MessageBox.Show("Debe ingresar un Número mayor a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereNumeroMYICero
                MessageBox.Show("Debe ingresar un Número mayor o igual a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereNumeroMNRSaldo
                MessageBox.Show("Debe ingresar un Número menor al Saldo.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereNumeroMNISaldo
                MessageBox.Show("Debe ingresar un Número menor o igual al Saldo.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereFecha
                MessageBox.Show("Debe ingresar una Fecha válida.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.INGRESA_SeRequiereComentario
                MessageBox.Show("Debe ingresar un Comentario.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.RECEPCION_OrdenServicioCerrada
                MessageBox.Show("La Orden de Servicio se encuentra cerrada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.DESPACHO_OrdenServicioCerrada
                MessageBox.Show("La Orden de Servicio se encuentra cerrada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.TABLA_ItemSeleccionadoYaExiste
                MessageBox.Show("Item seleccionado ya se encuentra registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.TABLA_TablaSinRegistro
                MessageBox.Show("No existen elementos. No se puede realizar el proceso.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.PROCESO_OK_Crear
                MessageBox.Show("Proceso CREAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.PROCESO_OK_Guardar
                MessageBox.Show("Proceso GUARDAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.PROCESO_OK_Modificar
                MessageBox.Show("Proceso MODIFICAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case enumMsjVarios.PROCESO_OK_Eliminar
                MessageBox.Show("Proceso ELIMINAR : Culminó Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case enumMsjVarios.PROCESO_Ko_Crear
                MessageBox.Show("Proceso CREAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case enumMsjVarios.PROCESO_Ko_Guardar
                MessageBox.Show("Proceso GUARDAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case enumMsjVarios.PROCESO_Ko_Modificar
                MessageBox.Show("Proceso MODIFICAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case enumMsjVarios.PROCESO_Ko_Eliminar
                MessageBox.Show("Proceso ELIMINAR : No se pudo culminar Satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case enumMsjVarios.NOEXIST_Registrar
                MessageBox.Show("No existe información, Debe ingresar la información respectiva.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '=======================ACD=========================            
            Case enumMsjVarios.PROCESO_OK_Cerrar
                MessageBox.Show("No existe información, Debe ingresar la información respectiva.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '===================================================
        End Select
    End Sub

    Public Sub mpMostrarClienteMDI(ByVal strCliente As String)
        ' MDIAlmacen.lblCliente.Text = strCliente
        MDIPrincipal2.SolminStatusStrip1.CLIENTE = strCliente
    End Sub

    Public Sub MessageError(ByVal MsgErr As String)
        MessageBox.Show(MsgErr, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region
#Region " Funciones y Procedimientos "
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'
    Public Function mfblnBuscar_Almacen(ByVal strTipoAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_Almacen(strMensajeError, strTipoAlmacen, strDescripcion)
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

    Public Function mfblnBuscar_Brevete(ByVal strEmpresaTransporte As String, ByRef strNroBrevete As String, ByRef strNombreChofer As String, _
                                        ByRef strNroDocIdentidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtEntidad = clsGeneral.fdtBuscar_BreveteAT(strMensajeError, strEmpresaTransporte, strNroBrevete)
            Case "03"
                dtEntidad = clsGeneral.fdtBuscar_BreveteDS(strMensajeError, strEmpresaTransporte, strNroBrevete)
            Case "04", "05"
                dtEntidad = clsGeneral.fdtBuscar_BreveteDS(strMensajeError, strEmpresaTransporte, strNroBrevete)
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

    Public Function mfblnBuscar_EmpresaTransporte(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                  ByRef strNroRUC As String, Optional ByRef _strDireccionTransportista As String = "") As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Buscamos todas las Incidencias
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtEntidad = clsGeneral.fdtBuscar_EmpresaTransporteAT(strMensajeError, strDetalleEmpresaTransporte)
            Case "03"
                dtEntidad = clsGeneral.fdtBuscar_EmpresaTransporteDS(strMensajeError, strDetalleEmpresaTransporte)
            Case "04", "05"
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
                    _strDireccionTransportista = "" & dtEntidad.Rows(0)(4)
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 2
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strCodigoEmpresaTransporte = ("" & .SelectedRow(0)).ToString.Trim
                            strDetalleEmpresaTransporte = ("" & .SelectedRow(1)).ToString.Trim
                            strNroRUC = ("" & .SelectedRow(2)).ToString.Trim
                            _strDireccionTransportista = ("" & .SelectedRow(4)).ToString.Trim
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

    Public Function mfblnBuscar_EquipoManipuleo(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_EquipoManipuleo(strMensajeError, strDescripcion)
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

    Public Function mfblnBuscar_Moneda(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strSimbolo As String) As Boolean
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

    Public Function mfblnBuscar_MotivoTraslado(ByRef strCodigoMotivo As String, ByRef strDetalleMotivo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtEntidad = clsGeneral.fdtBuscar_MotivoGuiaRemisionAT(strMensajeError, strDetalleMotivo)
            Case "03"
                dtEntidad = clsGeneral.fdtBuscar_MotivoGuiaRemisionDS(strMensajeError, strDetalleMotivo)
            Case "04", "05"
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

    Public Function mfblnBuscar_PlacaUnidad(ByVal strEmpresaTransporte As String, ByRef strPlacaUnidad As String, ByRef strPlacaAcoplado As String, _
                                            ByRef strNroBrevete As String, ByRef strAnio As String, ByRef strMarca As String, ByRef strMTC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtEntidad = clsGeneral.fdtBuscar_PlacaUnidadAT(strMensajeError, strEmpresaTransporte, strPlacaUnidad)
            Case "03"
                dtEntidad = clsGeneral.fdtBuscar_PlacaUnidadDS(strMensajeError, strEmpresaTransporte, strPlacaUnidad)
            Case "04", "05"
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
                    strMTC = ("" & dtEntidad.Rows(0)(7)).ToString.Trim
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
                            strMTC = ("" & .SelectedRow(7)).ToString.Trim
                        Else
                            strPlacaUnidad = ""
                            strPlacaAcoplado = ""
                            strNroBrevete = ""
                            strAnio = ""
                            strMarca = ""
                            strMTC = ""
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

    Public Function mfblnBuscar_PlantaRANSA(ByRef strCodigoPltaOrigen As String, ByRef strDireccionPltaOrigen As String) As Boolean
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

    Public Function mfblnBuscar_PlantaPorClientes(ByVal intCliente As Int64, ByRef strCodigoPltaOrigen As String, ByRef strDireccionPltaOrigen As String) As Boolean
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

    Public Function mfblnBuscar_PlantaPorProveedor(ByVal intProveedor As Int64, ByRef strCodigoPltaOrigen As String, ByRef strDireccionPltaOrigen As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral.fdtBuscar_PlantasPorProveedor(strMensajeError, intProveedor, strDireccionPltaOrigen)
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

    Public Function mfblnBuscar_TipoAlmacen(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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

    Public Function mfblnBuscar_TipoBulto(ByRef strUnidad As String) As Boolean
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

    Public Function mfblnBuscar_UnidadMedida(ByRef strUnidad As String, ByVal strTipoUnidad As String) As Boolean
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

    Public Function mfblnBuscar_ZonasAlmacen(ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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
    Public Function mfblnBuscar_MedioTransporte(ByRef strCodigoMedioTransporte As String, ByRef strDetalleMedioTransporte As String) As Boolean
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

    Public Function mfblnBuscar_Nave(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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

    Public Function mfblnBuscar_SentidoCarga(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
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

    Public Function mfblnBuscar_TerminoInternacional(ByRef strCodigoTermIntern As String, ByRef strDetalleTermIntern As String) As Boolean
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

    Public Function mfDtblnBuscar_Ticket(ByVal obeMedioTransporte As Ransa.TYPEDEF.beGeneral, ByRef strNroTicket As String, ByRef strPesoTicket As String, ByRef strPlaca As String, ByRef strBrevete As String) As Boolean
        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        'Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral

        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False


        dtEntidad = obrMedioTransporte.DtListaTicked(obeMedioTransporte)

        If strMensajeError <> "" Then
            strNroTicket = "0"
            strPesoTicket = "0.00"
            blnResultado = False
            strPlaca = ""
            strBrevete = ""

            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strNroTicket = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strPesoTicket = ("" & dtEntidad.Rows(0)(3)).ToString.Trim

                    strPlaca = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                    strBrevete = ("" & dtEntidad.Rows(0)(7)).ToString.Trim


                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strNroTicket = ("" & .SelectedRow(0)).ToString.Trim
                            strPesoTicket = ("" & .SelectedRow(3)).ToString.Trim
                            strPlaca = ("" & .SelectedRow(1)).ToString.Trim
                            strBrevete = ("" & .SelectedRow(7)).ToString.Trim


                        Else
                            strNroTicket = "0"
                            strPesoTicket = "0.00"
                            strPlaca = ""
                            strBrevete = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strNroTicket = "0"
                strPesoTicket = "0.00"
                blnResultado = False
                strPlaca = ""
                strBrevete = ""
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_Ticket(ByRef strNroTicket As String, ByRef strPesoTicket As String) As Boolean
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

    Public Function mfblnBuscar_VolumenBulto(ByRef strVolumenBulto As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SAT.fdtBuscar_Ticket(strMensajeError, strVolumenBulto)

        If strMensajeError <> "" Then
            strVolumenBulto = "0.0"
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    'strNroTicket = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    'strPesoTicket = ("" & dtEntidad.Rows(0)(2)).ToString.Trim
                    strVolumenBulto = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            'strNroTicket = ("" & .SelectedRow(0)).ToString.Trim
                            'strPesoTicket = ("" & .SelectedRow(2)).ToString.Trim
                        Else
                            'strNroTicket = "0"
                            'strPesoTicket = "0.00"
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                'strNroTicket = "0"
                'strPesoTicket = "0.00"
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_TipoDespacho(ByRef strTipoDespacho As String, ByRef strDetalleTipoDespacho As String) As Boolean
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


    Public Function mfblnBuscar_Contenedor(ByVal strCompania As String, ByVal dblCodigoCliente As Double, ByRef strSerie As String, ByRef strNumero As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim obrContenedor As New brContenedor
        Dim obeContenedor As New Ransa.TYPEDEF.beContenedor
        With obeContenedor
            .PSCCMPN = strCompania
            .PNCCLNT = dblCodigoCliente

        End With
        dtEntidad = obrContenedor.dtListarContenedor(obeContenedor)
        If strMensajeError <> "" Then
            strSerie = ""
            strNumero = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strSerie = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strNumero = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    With frmBusqueda
                        .Titulo = dtEntidad.TableName
                        .CampoDefault = 1
                        .DataSource = dtEntidad
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            strSerie = ("" & .SelectedRow(0)).ToString.Trim
                            strNumero = ("" & .SelectedRow(1)).ToString.Trim
                        Else
                            strSerie = ""
                            strNumero = ""
                        End If
                        .Dispose()
                    End With
                End If
                blnResultado = True
            Else
                strSerie = ""
                strNumero = ""
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
    Public Function mfblnBuscar_SDSFamilia(ByVal intCliente As Int64, ByRef strFamilia As String, ByRef strDetalle As String) As Boolean
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

    Public Function mfblnBuscar_SDSGrupo(ByVal intCliente As Int64, ByVal strFamilia As String, ByRef strGrupo As String, ByRef strDetalle As String) As Boolean
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

    Public Function mfblnBuscar_SDSEquivalenteMercRANSA(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
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

    Public Function mfblnBuscar_SDSProveedor(ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, ByRef strRUCProveedor As String) As Boolean
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

    Public Function mfblnBuscar_SDSTipoApilabilidad(ByRef strTipoApilabilidad As String, ByRef strDetalleTipoApilibilidad As String) As Boolean
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

    Public Function mfblnBuscar_SDSTipoInflamable(ByRef strTipoInflamable As String, ByRef strDetalleTipoInflamable As String) As Boolean
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

    Public Function mfblnBuscar_SDSTipoPerfumancia(ByRef strTipoPerfumancia As String, ByRef strDetalleTipoPerfumancia As String) As Boolean
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

    Public Function mfblnBuscar_SDSTipoMovimiento(ByRef strTipoRecepcion As String, ByRef strDetalleTipoRecepcion As String) As Boolean
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
    Public Function mfdtListar_SDSFamilias(ByVal intCliente As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Familias(intCliente, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SDSGrupos(ByVal intCliente As Int64, ByVal strFamilia As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Grupos(intCliente, strFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_OrdenesServicioPorMercaderia(ByVal intCliente As Int64, ByVal strMercaderia As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_OrdenServicioMercaderia(intCliente, strMercaderia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_Mercaderias(ByVal intCliente As Int64, ByVal strFamilia As String, ByVal strGrupo As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Mercaderias(intCliente, strFamilia, strGrupo, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_Mercaderias(ByVal objFiltro As clsFiltro_ListarMercaderia) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDS.fdtListar_Mercaderias(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '-------------------------------SE AGREGO-----------------------------------------------------------------------
    Public Function mfdtListar_OrdenesServicioPorMercaderiaGuia(ByVal intCliente As Int64, ByVal strGuiaRemision As String) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_OrdenServicioMercaderiaGuia(intCliente, strGuiaRemision, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_OrdenesServicioPorMercaderiaGuia_Info_Adicional(ByVal intOrdenServicio) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsGeneral_SDS.fdtListar_OrdenServicioMercaderiaGuia_Info_Adicional(intOrdenServicio, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    '-----------------------------'
    ' SISTEMA DEPÓSITO AUTORIZADO '
    '-----------------------------'
    Public Function mfdtListar_OrdenesServicios(ByVal objFiltro As clsFiltro_ListarOS) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_OrdenesServicios(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_DetalleOrdenServicio(ByVal objFiltro As clsFiltro_ListarDetalleOS) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_DetalleOrdenServicio(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_Series(ByVal intNroDepositoRansa As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsGeneral_SDA.fdtListar_Series(intNroDepositoRansa, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Funciones para Obtener Detalle de la Información -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'
    Public Function mfblnObtenerDetalle_Almacen(ByVal strTipoAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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

    Public Function mfblnObtenerDetalle_Moneda(ByRef strCodigo As String, ByRef strDescripcion As String, ByRef strSimbolo As String) As Boolean
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
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_TipoAlmacen(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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

    Public Function mfblnObtenerDetalle_ZonaAlmacen(ByVal strTipoAlmacen As String, ByVal strAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
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
    Public Function mfblnObtenerDetalle_EmpresaTransporte(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                          ByRef strNroRUC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Obtengo la información de la empresa de transporte
        Select Case objSeguridadBN.pstrTipoSistema
            Case "01"
                dtEntidad = clsGeneral_SAT.fdtObtenerDetalle_EmpresaTransporte(strMensajeError, strCodigoEmpresaTransporte)
            Case "03"
                dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_EmpresaTransporteSDS(strMensajeError, strCodigoEmpresaTransporte)
            Case "04", "05"
                dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_EmpresaTransporteSDS(strMensajeError, strCodigoEmpresaTransporte)
        End Select

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

    Public Function mfblnObtenerDetalle_Proveedor(ByVal strCliente As String, ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, _
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
    Public Function mfblnObtenerDetalle_SDSChofer(ByVal strEmpresaTransporte As String, ByRef strNroBrevete As String, ByRef strNombreChofer As String, _
                                                  ByRef strNroDocIdentidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_Chofer(strMensajeError, strEmpresaTransporte, strNroBrevete)

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

    Public Function mfblnObtenerDetalle_SDSCodigoMercaderiaRANSA(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_CodigoMercaderiaRANSA(strMensajeError, strCodigo)

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

    Public Function mfblnObtenerDetalle_SDSEmpresaTransporteSDS(ByRef strCodigoEmpresaTransporte As String, ByRef strDetalleEmpresaTransporte As String, _
                                                             ByRef strNroRUC As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Obtengo la información de la empresa de transporte
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_EmpresaTransporteSDS(strMensajeError, strCodigoEmpresaTransporte)

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

    Public Function mfblnObtenerDetalle_SDSFamilia(ByVal strCliente As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_FamiliaSDS(strMensajeError, strCliente, strCodigo)

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

    Public Function mfblnObtenerDetalle_SDSGrupo(ByVal strCliente As String, ByVal strFamilia As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_GrupoSDS(strMensajeError, strCliente, strFamilia, strCodigo)

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

    Public Function mfblnObtenerDetalle_SDSPlacaCamion(ByVal strEmpresaTransporte As String, ByRef strPlaca As String, ByRef strAnio As String, _
                                                       ByRef strMarca As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_PlacaCamion(strMensajeError, strEmpresaTransporte, strPlaca)

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

    Public Function mfblnObtenerDetalle_SDSProveedor(ByRef strCodigoProveedor As String, ByRef strDetalleProveedor As String, ByRef strRUCProveedor As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_Proveedor(strMensajeError, strCodigoProveedor)

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

    Public Function mfblnObtenerDetalle_SDSTipoApilabilidad(ByRef strTipoApilabilidad As String, ByRef strDetalleApilabilidad As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_TipoApilabilidad(strMensajeError, strDetalleApilabilidad)

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

    Public Function mfblnObtenerDetalle_SDSTipoInflamable(ByRef strTipoInflamable As String, ByRef strDetalleInflamable As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_TipoInflamable(strMensajeError, strTipoInflamable)

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
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtenerDetalle_SDSTipoPerfumancia(ByRef strTipoPerfumancia As String, ByRef strDetallePerfumancia As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsGeneral_SDS.fdtObtenerDetalle_TipoPerfumancia(strMensajeError, strTipoPerfumancia)

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
                MessageBox.Show("No existe Información.", "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Public Function mfblnObtener_NroGuiaRansa(ByVal intNroServicio As Integer, ByVal strTipoDeposito As String, _
                                              ByVal blnStatusDefinitivo As Boolean, ByRef intNroGuiaRansa As Int64) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim objGeneral_SDS As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        intNroGuiaRansa = objGeneral_SDS.fintObtener_NroGuiaRansa(strMensajeError, intNroServicio, strTipoDeposito, blnStatusDefinitivo)

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

    Public Function mfblnObtener_UltimoNroControlRecepcion(ByVal intCliente As Int64, ByRef intNroResultado As Int64) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        intNroResultado = clsGeneral_SAT.fintObtener_UltimoNroControlRecepcion(strMensajeError, intCliente)
        If strMensajeError <> "" Then
            intNroResultado = 0
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If intNroResultado > 0 Then
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                intNroResultado = 0
                MessageBox.Show(strMensajeError, "No Existe información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                blnResultado = False
            End If
        End If
        Return blnResultado
    End Function

    '-------------------------'
    ' SISTEMA DEPÓSITO SIMPLE '
    '-------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Function mstrDefecto_SentidoCarga(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
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
    Public Function mfblnExiste_Ticket(ByVal strNroTicketBalanza As String) As Boolean
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
    Public Function mfblnExiste_PlacaCamion(ByVal strEmpresaTransporte As String, ByVal strPlacaCamion As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_PlacaCamion(strMensajeError, strEmpresaTransporte, strPlacaCamion)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado
    End Function

    Public Function mfblnExiste_Chofer(ByVal strEmpresaTransporte As String, ByVal strNroBrevete As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_Chofer(strMensajeError, strEmpresaTransporte, strNroBrevete)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "Código YA FUE REGISTRADO"
        Else
            strMensajeResultado = "Código NO EXISTE"
        End If
        Return blnResultado
    End Function

    Public Function mfblnExiste_Mercaderia(ByVal strCliente As String, ByVal strMercaderia As String, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsGeneral_SDS.fblnExiste_Mercaderia(strMensajeError, strCliente, strMercaderia)
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
    Public Function mfblnGrabar_Camion(ByVal objCamion As boCamion) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral As clsGeneral = New clsGeneral(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral.fblnGrabar_Camion(strMensajeError, objCamion, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnGrabar_Camion(ByVal intEmpresaTransporte As Int32, ByVal strNroPlacaCamion As String, ByVal intNroAnioCamion As Int32, _
                                         ByVal strDescripcionMarca As String) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral As clsGeneral = New clsGeneral(objSeguridadBN.pUsuario)
        Dim objCamion As boCamion = New boCamion
        With objCamion
            .pintEmpresaTransporte_CTRSP = intEmpresaTransporte
            .pstrNroPlacaCamion_NPLCCM = strNroPlacaCamion
            .pintNroAnioCamion_NANOCM = intNroAnioCamion
            .pstrDescripcionMarcaCamion_TMRCCM = strDescripcionMarca
        End With
        Dim blnResultado As Boolean = objGeneral.fblnGrabar_Camion(strMensajeError, objCamion, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnGrabar_Chofer(ByVal oChofer As boChofer) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral As clsGeneral = New clsGeneral(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = objGeneral.fblnGrabar_Chofer(strMensajeError, oChofer, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnGrabar_Chofer(ByVal intEmpresaTransporte As Int32, ByVal strNroBrevete As String, ByVal strChofer As String, _
                                         ByVal intNroDocIdentidadChofer As Int32) As Boolean
        Dim strMensajeError As String = ""
        Dim objGeneral As clsGeneral = New clsGeneral(objSeguridadBN.pUsuario)
        Dim oChofer As boChofer = New boChofer
        With oChofer
            .pintEmpresaTransporte_CTRSP = intEmpresaTransporte
            .pstrNroBrevete_NBRVCH = strNroBrevete
            .pstrChofer_TNMBCH = strChofer
            .pintNroDocIdentidadChofer_NLELCH = intNroDocIdentidadChofer
        End With
        Dim blnResultado As Boolean = objGeneral.fblnGrabar_Chofer(strMensajeError, oChofer, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnCrearOrdenServicio(ByVal objOrdenServicio As clsCrearOrdenServicio) As Boolean
        Dim strMensajeError As String = ""
        Dim intNroGuiaRansa As Int64 = 0
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblnCrearOrdenServicio(strMensajeError, objOrdenServicio, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function
    '------------------------------SE AGREGO--------------------------------------
    Public Function mfblnActualizarOrdenServicio(ByVal objOrdenServicio As clsCrearOrdenServicio) As Boolean
        Dim strMensajeError As String = ""
        Dim intNroGuiaRansa As Int64 = 0
        Dim blnResultado As Boolean = True
        Dim objRecepcion As clsGeneral_SDS = New clsGeneral_SDS(objSeguridadBN.pUsuario)
        blnResultado = objRecepcion.fblnActualizarOrdenServicio(strMensajeError, objOrdenServicio, objSeguridadBN.pstrPCName)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Generación de Archivos XLS -'
    '------------------------------'
    ' GENERAL '
    '---------'

    '--------------------------------'
    ' SISTEMA DE ALMACEN DE TRÁNSITO '
    '--------------------------------'
    Public Sub mpGenerarXLS(ByVal strReporteseleccionado As String, ByVal dtTemp2 As DataTable, Optional ByVal strTitulo As String = "", Optional ByVal filtro As Hashtable = Nothing, Optional ByVal strlTitulo As List(Of String) = Nothing)
        Dim oQProRansa As cQProRansa = New cQProRansa()
        Dim dtTemp As New DataTable
        dtTemp = dtTemp2.Copy
        Select Case strReporteseleccionado
            Case "Lote_X_Solicitante"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltIngresosPorAlmacenxLote.xlt", 2, 8, dtTemp)
            Case "O01"
                Dim objListdt As New List(Of DataTable)
                dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
                dtTemp.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
                dtTemp.Columns("CPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL "
                dtTemp.Columns("NORCML").ColumnName = "ORDEN COMPRA"
                dtTemp.Columns("NRITOC").ColumnName = "ITEM"
                dtTemp.Columns("TDITES").ColumnName = "DETALLE"
                dtTemp.Columns("QCNTIT").ColumnName = "QTA O/C"
                dtTemp.Columns("FORCML").ColumnName = "FECHA EMISION O/C"
                dtTemp.Columns("FMPDME").ColumnName = "FECHA POSIBLE ENTREGA"
                dtTemp.Columns("FREFFW").ColumnName = "FECHA ENTREGA AT"
                dtTemp.Columns("NDIATR").ColumnName = "DIAS ATRASO"
                dtTemp.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
                dtTemp.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
                dtTemp.Columns("STFREC").ColumnName = "STATUS RECEPCION"
                dtTemp.Columns("STFENT").ColumnName = "STATUS ENTREGAL"
                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)



                ' Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltSegOCSegunFechaEntrega.xlt", 2, 8, dtTemp)
            Case "O02"
                Dim objListdt As New List(Of DataTable)
                dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
                dtTemp.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
                dtTemp.Columns("TCITCL").ColumnName = "CÓDIGO MERCADERÍA"
                dtTemp.Columns("TDITES").ColumnName = "DETALLE MERCADERÍA"
                dtTemp.Columns("TUNDIT").ColumnName = "UNIDAD"
                dtTemp.Columns("QSLINI").ColumnName = "SALDO INICIAL"
                dtTemp.Columns("VSLINI").ColumnName = "VALOR INICIAL"
                dtTemp.Columns("QMVING").ColumnName = "CANTIDAD INGRESO"
                dtTemp.Columns("VMVING").ColumnName = "VALOR INGRESO"
                dtTemp.Columns("QMVSAL").ColumnName = "CANTIDAD SALIDA"
                dtTemp.Columns("VMVSAL").ColumnName = "VALOR SALIDA "
                dtTemp.Columns("QSLFIN").ColumnName = "STOCK FINAL"
                dtTemp.Columns("VSLFIN").ColumnName = "VALOR FINAL"

                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoProductosR06.xlt", 2, 8, dtTemp)
            Case "A01"

                Dim objListdt As New List(Of DataTable)
                dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
                dtTemp.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
                dtTemp.Columns("TUBRFR").ColumnName = "UBICACIÓN"
                dtTemp.Columns("FREFFW").ColumnName = "FECHA"
                dtTemp.Columns("CREFFW").ColumnName = "BULTO"
                dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD"
                dtTemp.Columns("TIPBTO").ColumnName = "TIPO BULTO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO"
                dtTemp.Columns("TUNPSO").ColumnName = "UNIDAD"
                dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN"
                dtTemp.Columns("TUNVOL").ColumnName = "UNIDAD "
                dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("NGRPRV").ColumnName = "N° GUIA PROV."
                dtTemp.Columns("NORCML").ColumnName = "N° O/C"
                dtTemp.Columns("NRITOC").ColumnName = "ITEM "
                dtTemp.Columns("TCITCL").ColumnName = "COD. CLIENTE"
                dtTemp.Columns("TDITES").ColumnName = " DESCRIPCION DEL ITEM "
                dtTemp.Columns("QBLTSR").ColumnName = "CANT. ITEM"
                dtTemp.Columns("QPEPQT").ColumnName = "PESO ITEM"
                dtTemp.Columns("TUNDCN").ColumnName = "UNIDAD  "
                dtTemp.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
                dtTemp.Columns("SSTINV").ColumnName = "ESTADO"
                dtTemp.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
                dtTemp.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
                dtTemp.Columns.Remove("CMEDTS")
                dtTemp.Columns.Remove("CMEDTC")
                dtTemp.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO "
                dtTemp.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
                dtTemp.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
                dtTemp.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"
                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)
                ' Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltIngresosPorAlmacen.xlt", 2, 8, dtTempp)?
            Case "A02"
                Dim objListdt As New List(Of DataTable)


                dtTemp.Columns("TUBRFR").ColumnName = "UBICACIÓN"
                dtTemp.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
                dtTemp.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
                dtTemp.Columns("QREFFW").ColumnName = "QTA  BULTO"
                dtTemp.Columns("TIPBTO").ColumnName = "TIPO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO  BULTO"
                dtTemp.Columns("QVLBTO").ColumnName = "VOL. BULTO"
                dtTemp.Columns("TTINTC").ColumnName = "ORIGEN"
                dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("QAROCP").ColumnName = "AREA BULTO"
                dtTemp.Columns("TNOMCOM").ColumnName = "COMPRADOR "
                dtTemp.Columns("NORCML").ColumnName = "ORDEN COMPRA"
                dtTemp.Columns("NRITOC").ColumnName = "ITEM"
                dtTemp.Columns("TCITCL").ColumnName = "COD. ITEM"
                dtTemp.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
                dtTemp.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
                dtTemp.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
                dtTemp.Columns("TUNDIT").ColumnName = "UNIDAD"
                dtTemp.Columns("QPEPQT").ColumnName = "PESO ITEM  "
                dtTemp.Columns("QVOPQT").ColumnName = "VOL ITEM"
                dtTemp.Columns("NGRPRV").ColumnName = "Nro GUIA"
                dtTemp.Columns("TLUGEN").ColumnName = "LUGAR"
                dtTemp.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)
                'dtTempp = oDtInventarioAlmacen(dtTempp)
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltInventarioAlmacen.xlt", 2, 8, dtTempp)
            Case "A03"

                Dim objListdt As New List(Of DataTable)

                dtTemp.Columns("CREFFW").ColumnName = "BULTO"
                dtTemp.Columns("NORCML").ColumnName = "O/C"
                dtTemp.Columns("NRITOC").ColumnName = "ITEM"
                dtTemp.Columns("TCITCL").ColumnName = "COD. CLIENTE"
                dtTemp.Columns("TDITES").ColumnName = "DETALLE ITEM"
                dtTemp.Columns("CPRVCL").ColumnName = "COD. PROVEEDOR"
                dtTemp.Columns("TPRVCL").ColumnName = "DETALLE. PROVEEDOR"
                dtTemp.Columns("NGRPRV").ColumnName = "GUÍA DE PROVEEDOR"
                dtTemp.Columns("FREFFW").ColumnName = "FECHA INGRESO"
                dtTemp.Columns("NGUIRM").ColumnName = "GUÍA DE REMISIÓN"
                dtTemp.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
                dtTemp.Columns("TTINTC").ColumnName = "TIPO MERCADERIA"
                dtTemp.Columns("QCNTIT").ColumnName = "CANTIDAD SOLICITADA"
                dtTemp.Columns("TUNDIT").ColumnName = "UNID "
                dtTemp.Columns("QCNPEN").ColumnName = "CANTIDAD PENDIENTE"
                dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD BULTOS"
                dtTemp.Columns("TIPBTO").ColumnName = "TIPO BULTO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO  BULTO"
                dtTemp.Columns("TUNPSO").ColumnName = "UNID  "
                dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN"
                dtTemp.Columns("TUNVOL").ColumnName = " UNID "
                dtTemp.Columns("TNOMCOM").ColumnName = "COMPRADOR"
                dtTemp.Columns("TUBRFR").ColumnName = "UBICACIÓN"
                dtTemp.Columns("TLUGEN").ColumnName = "LUGAR ENTREGA "
                dtTemp.Columns("ESTCAR").ColumnName = "ESTADO CARGA"
                dtTemp.Columns("TIMALM").ColumnName = "TIEMPO ALMACEN"


                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)

                '  Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltActividadesPorAlmacen.xlt", 2, 8, dtTempp)
            Case "A05"

                'Dim dsTemp As New DataSet
                'Dim oDt As DataTable

                'Dim strAnterio As String = ""
                'Dim oDr As DataRow
                'Dim bolNuevo As Boolean = True

                'For i As Integer = dtTemp.Rows.Count - 1 To 0 Step -1
                '    If i = 0 Then
                '        strAnterio = ""
                '    Else
                '        strAnterio = dtTemp.Rows(i - 1).Item("PSLOTE").ToString.Trim.ToUpper
                '    End If

                '    If bolNuevo Then
                '        oDt = New DataTable
                '        oDt = dtTemp.Clone
                '        oDt.TableName = dtTemp.Rows(i).Item("PSLOTE").ToString.Trim.ToUpper

                '        bolNuevo = False
                '    End If
                '    If dtTemp.Rows(i).Item("PSLOTE").ToString.Trim.ToUpper = strAnterio Then
                '        oDr = oDt.NewRow
                '        For x As Integer = 0 To dtTemp.Columns.Count - 1
                '            oDr.Item(x) = dtTemp.Rows(i).Item(x)
                '        Next
                '        oDt.Rows.Add(oDr)
                '        bolNuevo = False
                '    Else
                '        oDr = oDt.NewRow
                '        For x As Integer = 0 To dtTemp.Columns.Count - 1
                '            oDr.Item(x) = dtTemp.Rows(i).Item(x)
                '        Next
                '        oDt.Rows.Add(oDr)
                '        dsTemp.Tables.Add(oDt)
                '        bolNuevo = True
                '    End If
                'Next

                Dim objListdt As New List(Of DataTable)
                ' For Each oDt In dtTemp.Tables
                dtTemp2.Columns("FechaIngAlmacenCL").SetOrdinal(0)
                dtTemp2.Columns("FechaIngAlmacenCL").ColumnName = "FECHA INGRESO"
                dtTemp2.Columns("PSNORCML").SetOrdinal(1)
                dtTemp2.Columns("PSNORCML").ColumnName = "O/C"
                dtTemp2.Columns("PSNREFCL").SetOrdinal(2)
                dtTemp2.Columns("PSNREFCL").ColumnName = "OR"
                dtTemp2.Columns("PSTPRVCL").SetOrdinal(3)
                dtTemp2.Columns("PSTPRVCL").ColumnName = "PROVEEDOR"
                dtTemp2.Columns("PSCREFFW").SetOrdinal(4)
                dtTemp2.Columns("PSCREFFW").ColumnName = "BULTO"
                dtTemp2.Columns("PSNGRPRV").SetOrdinal(5)
                dtTemp2.Columns("PSNGRPRV").ColumnName = "GUÍA DEL PROVEEDOR"
                dtTemp2.Columns("PSDESCWB").SetOrdinal(6)
                dtTemp2.Columns("PSDESCWB").ColumnName = "DESCRIPCION"
                dtTemp2.Columns("PNQREFFW").SetOrdinal(7)
                dtTemp2.Columns("PNQREFFW").ColumnName = "CANTIDAD"
                dtTemp2.Columns("PNQPSOBL").SetOrdinal(8)
                dtTemp2.Columns("PNQPSOBL").ColumnName = "PESO"
                dtTemp2.Columns("PNQVLBTO").SetOrdinal(9)
                dtTemp2.Columns("PNQVLBTO").ColumnName = "M3"
                dtTemp2.Columns("PSMEDSUG").SetOrdinal(10)
                dtTemp2.Columns("PSMEDSUG").ColumnName = "VIA SUGERIDA"
                dtTemp2.Columns("PSMEDCONF").SetOrdinal(11)
                dtTemp2.Columns("PSMEDCONF").ColumnName = "VIA CONFIRMADA"
                dtTemp2.Columns("PSFechaReqAlmacen").SetOrdinal(12)
                dtTemp2.Columns("PSFechaReqAlmacen").ColumnName = "FECHA REQ. ALM. DEL CLIENTE"
                dtTemp2.Columns("PSTCTCST").SetOrdinal(13)
                dtTemp2.Columns("PSTCTCST").ColumnName = "CUENTA IMPUTACIÓN TERRESTRE"
                dtTemp2.Columns("PSTCTCSA").SetOrdinal(14)
                dtTemp2.Columns("PSTCTCSA").ColumnName = "CUENTA IMPUTACIÓN AEREO"
                dtTemp2.Columns("PSTCTCSF").SetOrdinal(15)
                dtTemp2.Columns("PSTCTCSF").ColumnName = "CUENTA IMPUTACIÓN FLUVIAL"
                dtTemp2.Columns("PSTCTAFE").SetOrdinal(16)
                dtTemp2.Columns("PSTCTAFE").ColumnName = "CUENTA DE AFECTACIÓN(AFE)"
                dtTemp2.Columns("PSLOTE").SetOrdinal(17)
                dtTemp2.Columns("PSLOTE").ColumnName = "LOTE"
                'oDt.Columns.Add().ColumnName = "CUENTA DE IMPUTACIÓN"
                objListdt.Add(dtTemp2)
                'Next
                HelpClass.ExportExcel(objListdt, strTitulo)
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltIngresoPorLote1.xlt", 2, 6, dsTemp, 0, 0, "ya ta")

            Case "A05B"
                Dim dsTemp As New DataSet
                Dim oDt As DataTable
                Dim strAnterio As String = ""
                Dim oDr As DataRow
                Dim bolNuevo As Boolean = True
                For i As Integer = dtTemp.Rows.Count - 1 To 0 Step -1
                    If i = 0 Then
                        strAnterio = ""
                    Else
                        strAnterio = dtTemp.Rows(i - 1).Item("LOTE")
                    End If
                    If bolNuevo Then
                        oDt = New DataTable
                        oDt = dtTemp.Clone
                        oDt.TableName = dtTemp.Rows(i).Item("LOTE")

                        bolNuevo = False
                    End If
                    If dtTemp.Rows(i).Item("LOTE").ToString.Trim.ToUpper = strAnterio.Trim.ToUpper Then
                        oDr = oDt.NewRow
                        For x As Integer = 0 To dtTemp.Columns.Count - 1
                            oDr.Item(x) = dtTemp.Rows(i).Item(x)
                        Next
                        oDt.Rows.Add(oDr)
                        bolNuevo = False
                    Else
                        oDr = oDt.NewRow
                        For x As Integer = 0 To dtTemp.Columns.Count - 1
                            oDr.Item(x) = dtTemp.Rows(i).Item(x)
                        Next
                        oDt.Rows.Add(oDr)
                        dsTemp.Tables.Add(oDt)
                        bolNuevo = True
                    End If
                Next
                Dim objListdt As New List(Of DataTable)
                For Each oDt In dsTemp.Tables
                    oDt.Columns("FREFFW").ColumnName = "FECHA INGRESO ALMACEN"
                    oDt.Columns("NORCML").ColumnName = "O/C"
                    oDt.Columns("NRITOC").ColumnName = "NR. ITEM"
                    oDt.Columns("NREFCL").ColumnName = "OR"
                    oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                    oDt.Columns("NGRPRV").ColumnName = "GRR DEL PROVEEDOR"
                    oDt.Columns("DESCWB").ColumnName = "DESCRIPCION"
                    oDt.Columns("QREFFW").ColumnName = "BULTOS X GRR"
                    oDt.Columns("QPSOBL").ColumnName = "PESO X GRR"
                    oDt.Columns("QVLBTO").ColumnName = "M3"
                    oDt.Columns("CREFFW").ColumnName = "BULTO"
                    oDt.Columns("LOTE").ColumnName = "LOTE"
                    oDt.Columns("MEDSUG").ColumnName = "VIA SUGERIDA"
                    oDt.Columns("MEDTRANS").ColumnName = "MEDIO DE ENVIO"
                    oDt.Columns.Add().ColumnName = "CUENTA DE IMPUTACIÓN"
                    objListdt.Add(oDt)
                Next
                HelpClass.ExportExcel(objListdt, strTitulo)
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltIngresoPorLote1.xlt", 2, 6, dsTemp, 0, 0, "ya ta")

            Case "D01"
                Dim objListdt As New List(Of DataTable)

                dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
                dtTemp.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
                dtTemp.Columns("TUBRFR").ColumnName = "UBICACIÓN"
                dtTemp.Columns("FSLDAL").ColumnName = "FECHA"
                dtTemp.Columns("NGUIRM").ColumnName = "GUIA REMISIÓN"
                dtTemp.Columns("NPLCCM").ColumnName = "PLACA"
                dtTemp.Columns("TNMBCH").ColumnName = "CHOFER"
                dtTemp.Columns("CREFFW").ColumnName = "BULTO"
                dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD"
                dtTemp.Columns("TIPBTO").ColumnName = "TIPO BULTO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO "
                dtTemp.Columns("TUNPSO").ColumnName = "UNIDAD"

                dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN"
                dtTemp.Columns("TUNVOL").ColumnName = "UNIDAD "
                dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("NGRPRV").ColumnName = "N° GUIA PROV."

                dtTemp.Columns("NORCML").ColumnName = "N° O/C	"
                dtTemp.Columns("NRITOC").ColumnName = "ITEM "
                dtTemp.Columns("TCITCL").ColumnName = "COD. CLIENTE "
                dtTemp.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM "
                dtTemp.Columns("QBLTSR").ColumnName = "CANT. ITEM "
                dtTemp.Columns("QPEPQT").ColumnName = "PESO ITEM "
                dtTemp.Columns("TUNDCN").ColumnName = "UNIDAD  "
                dtTemp.Columns("TLUGEN").ColumnName = "LUGAR DESTINO"
                dtTemp.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVIO"
                dtTemp.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
                dtTemp.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
                dtTemp.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"

                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)
                ' Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltSalidasPorAlmacen.xlt", 2, 8, dtTemp2)
            Case "D02"
                '===============================Despacho Mercaderia por Unidad==========================
                Dim dtTemp3 As New DataTable
                dtTemp3 = dtTemp2.Clone

                dtTemp3.Columns(2).DataType = GetType(String)
                dtTemp3.Columns(3).DataType = GetType(String)
                dtTemp3.Columns("QBLTSR").DataType = GetType(String)
                dtTemp3.Columns("NGRPRV").DataType = GetType(String)

                'Cambiamos Orden------------------
                For i As Integer = 0 To dtTemp2.Rows.Count - 1
                    dtTemp3.ImportRow(dtTemp2.Rows(i))
                    dtTemp3.Rows(i).Item("FSLDAL") = Split(dtTemp2.Rows(i).Item("FSLDAL"))(0)
                Next
                'Quitamos columnas a no usar------
                dtTemp3.Columns.Remove("CCLNT")
                dtTemp3.Columns.Remove("TCMPCL")
                dtTemp3.Columns.Remove("NRGUSA")
                dtTemp3.Columns.Remove("NPLCAC")
                dtTemp3.Columns.Remove("CTRSPT")
                dtTemp3.Columns.Remove("CBRCNT")
                dtTemp3.Columns.Remove("TABTRT")
                dtTemp3.Columns.Remove("NRUCTR")
                dtTemp3.Columns.Remove("NRITOC")
                'dtTemp3.Columns.Remove("NGRPRV")
                '---------------------------------
                dtTemp3.Columns(0).ColumnName = "FECHA DESPACHO"
                dtTemp3.Columns(1).ColumnName = "GUIA REMISIÓN"
                dtTemp3.Columns(2).ColumnName = "NRO. PLACA"
                dtTemp3.Columns(3).ColumnName = "CHOFER"
                dtTemp3.Columns(4).ColumnName = "BULTO"
                dtTemp3.Columns(5).ColumnName = "CANTIDAD BULTO"
                dtTemp3.Columns(6).ColumnName = "TIPO BULTO"
                dtTemp3.Columns(7).ColumnName = "PROVEEDOR CLIENTE"
                dtTemp3.Columns(8).ColumnName = "GUÍA DE PROVEEDOR"
                dtTemp3.Columns(9).ColumnName = "ORDEN COMPRA/ITEM"
                dtTemp3.Columns(10).ColumnName = "COD. ITEM"
                dtTemp3.Columns(11).ColumnName = "DESCRIPCION ITEM"


                dtTemp3.Columns(12).ColumnName = "CANTIDAD ITEM DESPACHADO"
                dtTemp3.Columns(13).ColumnName = "UNID. MEDIDA "
                dtTemp3.Columns(14).ColumnName = "PESO BULTO"
                dtTemp3.Columns(15).ColumnName = "UNID. MEDIDA PESO"
                dtTemp3.Columns(16).ColumnName = "IMPORTE UNID. ITEM"
                dtTemp3.Columns(17).ColumnName = "IMPORTE TOTAL ITEM"
                dtTemp3.Columns(18).ColumnName = "LUGAR DESTINO"

                '=====================QUIEBRES==========================
                Dim itemp As Integer = 0
                Dim iCambia As Boolean = True
                For i As Integer = 0 To dtTemp3.Rows.Count - 1
                    If iCambia = True Then
                        itemp = i - 1
                    End If
                    If i > 0 Then
                        If dtTemp3.Rows(i).Item("FECHA DESPACHO") = dtTemp3.Rows(itemp).Item("FECHA DESPACHO") Then
                            dtTemp3.Rows(i).Item("FECHA DESPACHO") = ""
                            'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
                            iCambia = False
                        Else
                            iCambia = True
                        End If
                    End If
                Next
                '======================================================
                itemp = 0
                iCambia = True
                For i As Integer = 0 To dtTemp3.Rows.Count - 1
                    If iCambia = True Then
                        itemp = i - 1
                    End If
                    If i > 0 Then
                        If dtTemp3.Rows(i).Item("GUIA REMISIÓN") = dtTemp3.Rows(itemp).Item("GUIA REMISIÓN") Then
                            dtTemp3.Rows(i).Item("GUIA REMISIÓN") = ""
                            dtTemp3.Rows(i).Item("NRO. PLACA") = ""
                            dtTemp3.Rows(i).Item("CHOFER") = ""
                            'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
                            iCambia = False
                        Else
                            iCambia = True
                        End If
                    End If
                Next
                '==============================================================
                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp3)
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo, filtro)
            Case "AI01"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltIngresosPorAlmacenEXF01.xlt", 1, 5, dtTemp)
            Case "AS01"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltDespachosPorAlmacenEXF01.xlt", 1, 5, dtTemp)
            Case "STK01"
                dtTemp.Columns(0).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(1).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(2).ColumnName = "CODIGO \n RANSA"
                dtTemp.Columns(3).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(4).ColumnName = "FECHA ULT MOV \n INGRESO"
                dtTemp.Columns(5).ColumnName = "FECHA ULT MOV \n SALIDA"
                dtTemp.Columns(6).ColumnName = "SALDO \n CANTIDAD"
                dtTemp.Columns(7).ColumnName = "SALDO \n UNIDAD"
                dtTemp.Columns(8).ColumnName = "SALDO \n PESO"
                dtTemp.Columns(9).ColumnName = "SALDO \nUNIDAD "

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "INVENTARIO DE PRODUCTOS"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo, filtro)
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltStockProductosR01.xlt", 2, 8, dtTemp)

            Case "STK02"
                dtTemp.Columns(0).ColumnName = "TIPO ALMACEN \n COD"
                dtTemp.Columns(1).ColumnName = "TIPO ALMACEN \n DETALLE"
                dtTemp.Columns(2).ColumnName = "ALMACEN \n COD"
                dtTemp.Columns(3).ColumnName = "ALMACEN \n DETALLE"
                dtTemp.Columns(4).ColumnName = "ZONA ALMACEN \n COD"
                dtTemp.Columns(5).ColumnName = "ZONA ALMACEN \n DETALLE "
                dtTemp.Columns(6).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(7).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(8).ColumnName = "CODIGO \n RANSA"
                dtTemp.Columns(9).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(10).ColumnName = "SALDO \n CANTIDAD"
                dtTemp.Columns(11).ColumnName = "SALDO \n UNIDAD"
                dtTemp.Columns(12).ColumnName = "SALDO \n PESO"
                dtTemp.Columns(13).ColumnName = "SALDO \nUNIDAD "

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "INVENTARIO DE PRODUCTOS POR UBICACIÓN"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltStockProductosPorAlmacenR01.xlt", 2, 8, dtTemp)
            Case "STK03"
                dtTemp.Columns(0).ColumnName = "TIPO ALMACÉN \n COD"
                dtTemp.Columns(1).ColumnName = "TIPO ALMACÉN \n DETALLE"
                dtTemp.Columns(2).ColumnName = "ALMACÉN \n COD"
                dtTemp.Columns(3).ColumnName = "ALMACÉN \n DETALLE"
                dtTemp.Columns(4).ColumnName = "ZONA ALMACEN \n COD"
                dtTemp.Columns(5).ColumnName = "ZONA ALMACEN \n DETALLE"
                dtTemp.Columns(6).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(7).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(8).ColumnName = "CÓDIGO \n RANSA"
                dtTemp.Columns(9).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(10).ColumnName = " \n STOCK"
                dtTemp.Columns(11).ColumnName = " \n UNIDAD"
                dtTemp.Columns(12).ColumnName = " \n VALOR"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "INVENTARIO DE PRODUCTOS POR UBICACIÓN"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltStockProductosPorAlmacenR02.xlt", 2, 8, dtTemp)
            Case "MOV01"
                dtTemp.Columns(0).ColumnName = " \n MOVIMIENTO"
                dtTemp.Columns(1).ColumnName = "\n FECHA"
                dtTemp.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(3).ColumnName = "CODIGO \n RANSA"
                dtTemp.Columns(4).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(5).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(6).ColumnName = "NRO. \n SOLICITUD"
                dtTemp.Columns(7).ColumnName = "TIPO \n ALMACEN"
                dtTemp.Columns(8).ColumnName = " \n ALMACEN"
                dtTemp.Columns(9).ColumnName = "MOVIMIENTO \n CANTIDAD"
                dtTemp.Columns(10).ColumnName = "MOVIMIENTO \n UNIDAD"
                dtTemp.Columns(11).ColumnName = "MOVIMIENTO \n PESO"
                dtTemp.Columns(12).ColumnName = "MOVIMIENTO \nUNIDAD "
                dtTemp.Columns(13).ColumnName = "GUIA \n RANSA"
                dtTemp.Columns(14).ColumnName = "GUIA \n CLIENTE"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoProductosR01.xlt", 2, 8, dtTemp)
            Case "MOV02"
                dtTemp.Columns(0).ColumnName = "TIPO ALMACÉN \n COD"
                dtTemp.Columns(1).ColumnName = "TIPO ALMACÉN \n DETALLE"
                dtTemp.Columns(2).ColumnName = "ALMACÉN \n COD"
                dtTemp.Columns(3).ColumnName = "ALMACÉN \n DETALLE"
                dtTemp.Columns(4).ColumnName = "ZONA ALMACÉN \n COD"
                dtTemp.Columns(5).ColumnName = "ZONA ALMACÉN \n DETALLE"
                dtTemp.Columns(6).ColumnName = " \n MOVIMIENTO"
                dtTemp.Columns(7).ColumnName = " \n FECHA"
                dtTemp.Columns(8).ColumnName = " CÓDIGO\n MERCADERIA"
                dtTemp.Columns(9).ColumnName = "CÓDIGO \n RANSA"
                dtTemp.Columns(10).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(11).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(12).ColumnName = "NRO. \nSOLICITUD"
                dtTemp.Columns(13).ColumnName = "MOVIMIENTO \n CANTIDAD"
                dtTemp.Columns(14).ColumnName = "MOVIMIENTO \n UNIDAD"
                dtTemp.Columns(15).ColumnName = "MOVIMIENTO \n PESO"
                dtTemp.Columns(16).ColumnName = "MOVIMIENTO \nUNIDAD "
                dtTemp.Columns(17).ColumnName = " GUIA \n RANSA"
                dtTemp.Columns(18).ColumnName = "GUIA \n CLIENTE"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "MOVIMIENTO PRODUCTOS POR UBICACIÓN"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovProductosPorUbicacionR01.xlt", 2, 8, dtTemp)
            Case "MOV03"
                dtTemp.Columns(0).ColumnName = " \n MOVIMIENTO"
                dtTemp.Columns(1).ColumnName = "\n FECHA"
                dtTemp.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(3).ColumnName = "CODIGO \n RANSA"
                dtTemp.Columns(4).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(5).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(6).ColumnName = "NRO. \n SOLICITUD"
                dtTemp.Columns(7).ColumnName = "TIPO \n ALMACEN"
                dtTemp.Columns(8).ColumnName = " \n ALMACEN"
                dtTemp.Columns(9).ColumnName = " \nMOVIMIENTO "
                dtTemp.Columns(10).ColumnName = " \n UNIDAD"
                dtTemp.Columns(11).ColumnName = "\n VALOR"
                dtTemp.Columns(12).ColumnName = " GUIA \n RANSA"
                dtTemp.Columns(13).ColumnName = "GUIA\n CLIENTE"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoProductosR03.xlt", 2, 8, dtTemp)
            Case "MOV04"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovProductosPorUbicacionR02.xlt", 2, 8, dtTemp)
            Case "MOV05"
                dtTemp.Columns(0).ColumnName = " \n CLIENTE"
                dtTemp.Columns(1).ColumnName = "\n RAZON SOCIAL"
                dtTemp.Columns(2).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(3).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(4).ColumnName = "CODIGO \n RANSA"
                dtTemp.Columns(5).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(6).ColumnName = "\n UNIDAD"
                dtTemp.Columns(7).ColumnName = "SALDO\n INICIAL"
                dtTemp.Columns(8).ColumnName = "VALOR \n INICIAL"
                dtTemp.Columns(9).ColumnName = "CANTIDAD \n INGRESO"
                dtTemp.Columns(10).ColumnName = "VALOR \n INGRESO"
                dtTemp.Columns(11).ColumnName = "CANTIDAD \n SALIDA"
                dtTemp.Columns(12).ColumnName = "VALOR\n SALIDA"
                dtTemp.Columns(13).ColumnName = "STOCK \n FINAL"
                dtTemp.Columns(14).ColumnName = "VALOR\n FINAL"
                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "LISTADO DE MOVIMIENTOS DE PRODUCTOS"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoProductosR04.xlt", 2, 8, dtTemp)
            Case "X03"
                dtTemp.Columns(0).ColumnName = "CÓDIGO \n MERCADERIA"
                dtTemp.Columns(1).ColumnName = "DETALLE \n MERCADERIA"
                dtTemp.Columns(2).ColumnName = "CÓDIGO \n RANSA"
                dtTemp.Columns(3).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(4).ColumnName = "NRO. \n SOLICITUD"
                dtTemp.Columns(5).ColumnName = "TIPO \n MOVIMIENTO"
                dtTemp.Columns(6).ColumnName = " TIPO\n ALMACÉN"
                dtTemp.Columns(7).ColumnName = " \n ALMACÉN"
                dtTemp.Columns(8).ColumnName = "GUIA\n RANSA"
                dtTemp.Columns(9).ColumnName = "\n FECHA"
                dtTemp.Columns(10).ColumnName = "MOVIMIENTO \n CANTIDAD"
                dtTemp.Columns(11).ColumnName = "MOVIMIENTO \n UNIDAD"
                dtTemp.Columns(12).ColumnName = "MOVIMIENTO \n PESO"
                dtTemp.Columns(13).ColumnName = "MOVIMIENTO \nUNIDAD "
                dtTemp.Columns(14).ColumnName = "GUIA \n CLIENTE"
                dtTemp.Columns(15).ColumnName = "\nOBSERVACIÓN"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "LISTADO DE MOVIMIENTOS DE PRODUCTOS"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoProductosR02.xlt", 2, 8, dtTemp)
            Case "INPOS"
                dtTemp.Columns(0).ColumnName = "ALMACÉN \n TIPO"
                dtTemp.Columns(1).ColumnName = "ALMACÉN \n ALMACÉN"
                dtTemp.Columns(2).ColumnName = "ALMACÉN \n ZONA"
                dtTemp.Columns(3).ColumnName = "ALMACÉN \n POSICION"
                dtTemp.Columns(4).ColumnName = "MERCADERIA \n CÓDIGO"
                dtTemp.Columns(5).ColumnName = "MERCADERIA \n DESCRIPCIÓN"
                dtTemp.Columns(6).ColumnName = "STOCK \n ORDEN"
                dtTemp.Columns(7).ColumnName = "ORDEN \n SERVICIO"
                dtTemp.Columns(8).ColumnName = "STOCK \n POSICIÓN"

                Dim oList As New List(Of DataTable)
                oList.Add(dtTemp)
                strTitulo = "INVENTARIO POR POSICIÓN"
                '==========================Exportamos==========================
                HelpClass.ExportExcel(oList, strTitulo.ToUpper, filtro)
                '==============================================================
                'Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltMovimientoMercaderiaPosicion.xlt", 2, 8, dtTemp)
            Case "TomaInventario"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltTomaInventario.xlt", 2, 8, dtTemp)
            Case "CentroCostoXIngreso"
                Call oQProRansa.pExportarToXLS(Application.StartupPath & "\ExportToXLS\xltCentroCostoXIngreso.xlt", 2, 8, dtTemp)

            Case "BULTO"


                Dim objListdt As New List(Of DataTable)
                dtTemp.Columns("CREFFW").ColumnName = "BULTO"
                dtTemp.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
                dtTemp.Columns("FREFFW").ColumnName = "FECHA INGRESO"
                dtTemp.Columns("HORIDE").ColumnName = "HORA INGRESO"
                dtTemp.Columns("SMTRCP").ColumnName = "MOTIVO RECEPCIÓN "
                dtTemp.Columns("CTPALM").ColumnName = "TIPO ALMACEN"
                dtTemp.Columns("CALMC").ColumnName = "ALMACEN"
                dtTemp.Columns("CZNALM").ColumnName = "ZONA"
                dtTemp.Columns("TUBRFR").ColumnName = "UBICACIÓN"
                dtTemp.Columns("SSNCRG").ColumnName = "SENTIDO DE CARGA"

                dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD BULTO"
                dtTemp.Columns("TIPBTO").ColumnName = "TIPO DE BULTO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO BULTO"
                dtTemp.Columns("TUNPSO").ColumnName = "UNIDAD PESO"
                dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN BULTO"
                dtTemp.Columns("TUNVOL").ColumnName = "UNIDAD VOLUMEN"
                dtTemp.Columns("QAROCP").ColumnName = "AREA OCUPADA"
                dtTemp.Columns("NTCKPS").ColumnName = "TICKED "

                dtTemp.Columns("NORCML").ColumnName = "N° O/C"
                dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("NGRPRV").ColumnName = "N° GUÍA PROVEEDOR"
                dtTemp.Columns("TLUGEN").ColumnName = "LOTE"
                dtTemp.Columns("TNMMDT").ColumnName = "MEDIO SUGERIDO"
                dtTemp.Columns("CONFIR").ColumnName = "MEDIO CONFIRMADO"
                dtTemp.Columns("TCTCST").ColumnName = "CUENTA IMPUTACION TERRESTRE"
                dtTemp.Columns("TCTCSA").ColumnName = "CUENTA IMPUTACION AEREO"
                dtTemp.Columns("TCTCSF").ColumnName = "CUENTA IMPUTACION FLUVIAL"

                dtTemp.Columns("FSLFFW").ColumnName = "FECHA DESPACHO"
                dtTemp.Columns("MEDIENV").ColumnName = "MEDIO DE ENVIO"
                dtTemp.Columns("NGUIRM").ColumnName = "N° GUÍA REMISIÓN"
                dtTemp.Columns("FLGCNL").ColumnName = "ESTADO DE CONFIRMACIÓN"
                dtTemp.Columns("FCNFCL").ColumnName = "FECHA CONFIRMADO"
                dtTemp.Columns("HCNFCL").ColumnName = "HORA CONFIRMADO"
                dtTemp.Columns("TOBSEN").ColumnName = "OBSERVACIONES CONFORMACIÓN"
                dtTemp.Columns("SSTINV").ColumnName = "ESTADO DE BULTO"
                objListdt.Add(dtTemp)
                HelpClass.ExportExcel(objListdt, strTitulo)

            Case "INVENTARIO_BULTO"
                dtTemp.Columns("UBICACION").ColumnName = "UBICACIÓN"
                dtTemp.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
                dtTemp.Columns("FREFFW").ColumnName = "FECHA INGRESO"
                dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD BULTO"
                dtTemp.Columns("QPSOBL").ColumnName = "PESO BULTO"
                dtTemp.Columns("QMTALT").ColumnName = "ALTURA"
                dtTemp.Columns("QMTANC").ColumnName = "ANCHO"
                dtTemp.Columns("QMTLRG").ColumnName = "LARGO"
                dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN BULTO"
                dtTemp.Columns("NORCML").ColumnName = "N° O/C"
                dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
                dtTemp.Columns("NGRPRV").ColumnName = "N° GUÍA PROVEEDOR"
                dtTemp.Columns("TLUGEN").ColumnName = "LOTE"
                dtTemp.Columns("TNMMDT").ColumnName = "MEDIO SUGERIDO"
                dtTemp.Columns("CONFIR").ColumnName = "MEDIO CONFIRMADO"
                dtTemp.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
                dtTemp.Columns("TOBSEN").ColumnName = "OBSERVACIONES CONFORMACIÓN"

                Dim oDtFiltro As New DataTable
                Dim objListdt As New List(Of DataTable)
                Dim oDt2 As DataTable
                Dim oDtv1 As DataView = New DataView(dtTemp)
                oDt2 = oDtv1.ToTable(True, "LOTE")

                For intRows As Integer = 0 To oDt2.Rows.Count - 1
                    oDtFiltro = SelectDataTable(dtTemp, "[LOTE] = '" + oDt2.Rows(intRows).Item(0) + "'")
                    oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim) & "  "
                    objListdt.Add(oDtFiltro)
                Next
                HelpClass.ExportExcel_ConTitulos(objListdt, strlTitulo)
        End Select
        oQProRansa.Dispose()
        oQProRansa = Nothing
        cMemory.ClearMemory()
    End Sub


    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable
        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        Return dtNew
    End Function

    Private Function NombreTabla(ByVal strNombreTabla As String) As String
        strNombreTabla = strNombreTabla.Replace(":", "-")
        strNombreTabla = strNombreTabla.Replace("?", "")
        strNombreTabla = strNombreTabla.Replace("/", "-")
        Return strNombreTabla
    End Function

    Private Function oDtInventarioAlmacen(ByVal oDt As DataTable) As DataTable
        Dim oDtReturn As New DataTable
        Dim oDr As DataRow
        oDtReturn = oDt.Copy
        For intRow As Integer = oDt.Rows.Count - 1 To 1 Step -1
            oDr = oDtReturn.NewRow
            If oDt.Rows(intRow).Item(0) = oDt.Rows(intRow - 1).Item(0) And oDt.Rows(intRow).Item(1) = oDt.Rows(intRow - 1).Item(1) Then
                For intCell As Integer = 0 To 10
                    oDtReturn.Rows(intRow).Item(intCell) = DBNull.Value
                Next
            End If
            oDtReturn.Rows.Add(oDr)
        Next
        Return oDtReturn
    End Function


    Public Sub mpEnviarEMail(ByVal objTemp As TipoDato_ResultaReporte, ByVal strAsunto As String, ByVal strContenidoEMail As String)
        Dim strMensajeError As String = ""
        Dim strFileName As String = Application.StartupPath & "\EnvioEMail\" & strAsunto.Replace(" ", "_").Replace("/", "") & ".PDF"
        ' & Now.ToString("_yyyyMMdd_hhmmss") ' Agregar al Nombre de Archivo para hacerlo único
        Dim oMapi As MAPI = New MAPI
        Directory.CreateDirectory(Application.StartupPath + "\EnvioEMail")
        objTemp.pReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, strFileName)
        oMapi.AddAttachment(strFileName)
        oMapi.SendMailPopup(strAsunto, strContenidoEMail, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub



    ' RUTINA A SER CONVERTIDAS A PROCEDURE
    Public Sub pBuscarPlacaAcoplado(ByVal strEmpresaTransporte As String, ByRef strPlacaAcoplado As String, ByRef Status As Boolean)
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






#End Region
#Region " Rutinas AppConfig "
    Public Enum ConfigFileType
        WebConfig
        AppConfig
    End Enum

    Public Class cAppConfig
        Inherits System.Configuration.AppSettingsReader

        Public docName As String = String.Empty
        Private node As XmlNode = Nothing
        Private _configType As Integer

        Public Property ConfigType() As Integer
            Get
                Return _configType
            End Get
            Set(ByVal Value As Integer)
                _configType = Value
            End Set
        End Property

        Public Function SetValue(ByVal key As String, ByVal value As String) As Boolean
            Dim cfgdoc As New XmlDocument()
            Call loadConfigDoc(cfgdoc)

            node = cfgdoc.SelectSingleNode("//appSettings")
            If node Is Nothing Then
                Throw New System.InvalidOperationException("appSettings section not found")
            End If

            Try
                Dim addElem As XmlElement = CType(node.SelectSingleNode("//add[@key='" + key + "']"), XmlElement)

                If Not addElem Is Nothing Then
                    addElem.SetAttribute("value", value)
                Else
                    Dim enTry As XmlElement = cfgdoc.CreateElement("add")
                    enTry.SetAttribute("key", key)
                    enTry.SetAttribute("value", value)
                    node.AppendChild(enTry)
                End If
                Call saveConfigDoc(cfgdoc, docName)
                Return True
            Catch
                Return False
            End Try
        End Function

        Private Sub saveConfigDoc(ByVal cfgDoc As XmlDocument, ByVal cfgDocPath As String)
            Try
                Dim writer As XmlTextWriter = New XmlTextWriter(Application.StartupPath & "\" & cfgDocPath, Nothing)
                writer.Formatting = Formatting.Indented
                cfgDoc.WriteTo(writer)
                writer.Flush()
                writer.Close()
                Return
            Catch
                Throw
            End Try
        End Sub

        Public Function removeElement(ByVal elementKey As String) As Boolean
            Try
                Dim cfgDoc As XmlDocument = New XmlDocument()
                loadConfigDoc(cfgDoc)
                ' recupero el nodo appSettings
                node = cfgDoc.SelectSingleNode("//appSettings")
                If node Is Nothing Then
                    Throw New System.InvalidOperationException("appSettings section not found")
                End If
                ' XPath selecionamos el elemento "add" que contiene la clave a remover
                node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"))

                saveConfigDoc(cfgDoc, docName)
                Return True
            Catch
                Return False
            End Try
        End Function

        Private Function loadConfigDoc(ByVal cfgDoc As XmlDocument) As XmlDocument
            Dim Asm As System.Reflection.Assembly
            ' cargamos el archivo de configuración
            If Convert.ToInt32(ConfigType) = Convert.ToInt32(ConfigFileType.AppConfig) Then
                docName = ((Asm.GetEntryAssembly()).GetName()).Name
                docName += ".exe.config"
                'Else
                '    docName = System.Web.HttpContext.Current.Server.MapPath("web.config")
            End If
            cfgDoc.Load(Application.StartupPath & "\" & docName)
            Return cfgDoc
        End Function
    End Class
#End Region
End Module
