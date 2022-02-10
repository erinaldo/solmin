' Librerías del Framework
Imports System.IO
Imports System.IO.File
Imports CrystalDecisions.CrystalReports.Engine
' Proceso 
Imports RANSA.TypeDef.OrdenCompra
Imports RANSA.TypeDef.Waybill
Imports RANSA.TypeDef
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Procesos
' Reporte
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes.Generador

Module mAlmacen
#Region " Tipo de Datos "

#End Region
#Region " Procesos Comunes "

#End Region
#Region " Variable Globales "

#End Region
#Region " Funciones y Procedimientos "
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'
    Public Function mfdtBuscar_MotivoRecepcion(ByRef strCodigoMotivo As String, ByRef strDetalleMotivo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsAlmacen.fdtBuscar_MotivoRecepcion(strMensajeError, strDetalleMotivo)

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            If dtEntidad.Rows.Count = 1 Then
                strCodigoMotivo = "" & dtEntidad.Rows(0)(0)
                strDetalleMotivo = "" & dtEntidad.Rows(0)(1)
            Else
                With frmBusqueda
                    .Titulo = dtEntidad.TableName
                    .CampoDefault = 2
                    .DataSource = dtEntidad
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        strCodigoMotivo = "" & .SelectedRow(0)
                        strDetalleMotivo = "" & .SelectedRow(1)
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
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfdtBuscar_TipoMovimiento(ByRef strCodigoMotivo As String, ByRef strDetalleMotivo As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsAlmacen.fdtBuscar_TipoMovimiento(strMensajeError, strDetalleMotivo)

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            If dtEntidad.Rows.Count = 1 Then
                strCodigoMotivo = "" & dtEntidad.Rows(0)(0)
                strDetalleMotivo = "" & dtEntidad.Rows(0)(1)
            Else
                With frmBusqueda
                    .Titulo = dtEntidad.TableName
                    .CampoDefault = 2
                    .DataSource = dtEntidad
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        strCodigoMotivo = "" & .SelectedRow(0)
                        strDetalleMotivo = "" & .SelectedRow(1)
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
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfdtBuscar_Paletizado(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsAlmacen.fdtBuscar_Paletizado(strMensajeError, strDetalle)

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            If dtEntidad.Rows.Count = 1 Then
                strCodigo = "" & dtEntidad.Rows(0)(0)
                strDetalle = "" & dtEntidad.Rows(0)(0)
            Else
                With frmBusqueda
                    .Titulo = dtEntidad.TableName
                    .CampoDefault = 2
                    .DataSource = dtEntidad
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        strCodigo = "" & .SelectedRow(0)
                        strDetalle = "" & .SelectedRow(0)
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
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListarBultos(ByVal objFiltros As clsFiltrosParaBultos) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListarBultos(objFiltros, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_ItemsBultos(ByVal strCliente As String, ByVal strBulto As String, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListar_ItemsBulto(strMensajeError, strCliente, strBulto, strCompania, strDivision, dblPlanta)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function
    Public Function mfdtListar_ItemsBultos_HT(ByVal htFiltro As Hashtable) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListar_ItemsBulto_HT(strMensajeError, htFiltro)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_ItemsBultoSaldo(ByVal strCliente As String, ByVal strBulto As String, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double, Optional ByVal strItemsSeleccionados As String = "") As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListar_ItemsBultoSaldo(strMensajeError, strCliente, strBulto, strCompania, strDivision, dblPlanta, strItemsSeleccionados)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_BultosSinEtiquetas(ByVal strCliente As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListar_BultosSinEtiquetas(strCliente, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_PaletasSinEtiquetas(ByVal strCliente As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsAlmacen.fdtListar_PaletasSinEtiquetas(strCliente, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    Public Function mfblnObtener_NroBulto(ByVal blnStatusDefinitivo As Boolean, ByRef strNroBulto As String, ByVal dblCliente As Double, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        strNroBulto = objAlmacen.fstrObtener_NroBulto(strMensajeError, blnStatusDefinitivo, dblCliente, strCompania, strDivision, dblPlanta)
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        objAlmacen = Nothing
        Return blnResultado
    End Function

    Public Function mfstrObtener_NroParcial(ByVal strOrdenCompra As String, ByVal dblCliente As Double) As String
        Dim strMensajeError As String = ""
        Dim strResultado As String
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        strResultado = objAlmacen.fstrObtener_NroParcial(strOrdenCompra, dblCliente, strMensajeError)
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        objAlmacen = Nothing
        Return strResultado
    End Function

    Public Function mfblnObtener_InfRepacking(ByVal strCliente As String, ByVal strBulto As String, ByRef objInfRepacking As clsInfRepacking, ByVal strCompania As String, ByVal strDivision As String, ByVal dblPlanta As Double) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        objInfRepacking = clsAlmacen.fobjObtener_InfRepacking(strMensajeError, strCliente, strBulto, strCompania, strDivision, dblPlanta)
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'
    Public Function mstrDefecto_MotivoRecepcion(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsAlmacen.fdtDefecto_MotivoRecepcion(strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = "" & dtEntidad.Rows(0)(0)
            strDetalle = "" & dtEntidad.Rows(0)(1)
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

    Public Function mfdtDefecto_TipoMovimiento(ByVal blnStatusBultoNormal As Boolean, ByRef strCodigo As String, ByRef strDetalle As String, ByVal pEstado As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsAlmacen.fdtDefecto_TipoMovimiento(strMensajeError, blnStatusBultoNormal)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            If (pEstado = "Devolucion") Then
                strCodigo = "" & "D"
                strDetalle = "" & "DEVOLUCION"
                blnResultado = True
            ElseIf (pEstado.ToUpper = "RECOJO") Then
                strCodigo = "" & "P"
                strDetalle = "" & "RECOJO"
                blnResultado = True
            Else
                strCodigo = "" & dtEntidad.Rows(0)(0)
                strDetalle = "" & dtEntidad.Rows(0)(1)
                blnResultado = True
            End If
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

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    Public Function mfblnExiste_Bulto(ByVal objBulto As clsPrimaryKey_Bulto) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_Bulto(strMensajeError, objBulto)
        If blnResultado Then MessageBox.Show("El código proporcionado ya fue registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_Bulto(ByVal intCliente As Int64, ByVal strBulto As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim objBulto As clsPrimaryKey_Bulto = New clsPrimaryKey_Bulto
        With objBulto
            .pintCodigoCliente_CCLNT = intCliente
            .pstrCodigoRecepcion_CREFFW = strBulto
        End With
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_Bulto(strMensajeError, objBulto)
        If blnResultado Then MessageBox.Show("El código proporcionado ya fue registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_ItemBulto(ByVal objItemBulto As clsPrimaryKey_ItemBulto) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_ItemBulto(strMensajeError, objItemBulto)
        If blnResultado Then MessageBox.Show("El código proporcionado ya fue registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_ItemBulto(ByVal intCliente As Int64, ByVal strBulto As String, ByVal strPaquete As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim objItemBulto As clsPrimaryKey_ItemBulto = New clsPrimaryKey_ItemBulto
        With objItemBulto
            .pintCodigoCliente_CCLNT = intCliente
            .pstrCodigoRecepcion_CREFFW = strBulto
            .pstrCodigoIdentificacionPaquete_CIDPAQ = strPaquete
        End With
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_ItemBulto(strMensajeError, objItemBulto)
        If blnResultado Then MessageBox.Show("El código proporcionado ya fue registrado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_ItemsBulto(ByVal objBulto As clsPrimaryKey_Bulto) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_ItemsBulto(strMensajeError, objBulto)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_ItemsBulto(ByVal intCliente As Int64, ByVal strBulto As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim objBulto As clsPrimaryKey_Bulto = New clsPrimaryKey_Bulto
        With objBulto
            .pintCodigoCliente_CCLNT = intCliente
            .pstrCodigoRecepcion_CREFFW = strBulto
        End With
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_ItemsBulto(strMensajeError, objBulto)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_BultoParaTransferir(ByVal strNroDocumentoES As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_BultoParaTransferir(strMensajeError, strNroDocumentoES)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_BultosSinEtiquetas(ByVal intCliente As Int64) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_BultosSinEtiqueta(strMensajeError, intCliente)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_PaletasSinEtiquetas(ByVal intCliente As Int64) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsAlmacen.fblnExiste_PaletasSinEtiqueta(strMensajeError, intCliente)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    Public Function mfblnRealizar_TransferenciaBulto(ByVal intCliente As Int64, ByVal NroDocumentoES As String, ByRef strCodigoBulto As String, ByVal strCCMPN As String, ByVal strCDVSN As String, ByVal dblCPLNDV As Double) As Boolean
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objAlmacen.fblnRealizar_TransferenciaBulto(intCliente, NroDocumentoES, strCodigoBulto, strMensajeError, strCCMPN, strCDVSN, dblCPLNDV)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objAlmacen = Nothing
        Return blnResultado
    End Function

    Public Function mfblnRegistrar_BultoRepacking(ByVal objBultoRepacking As clsBultoRepacking, ByVal strMensajeError As String) As String
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        Return objAlmacen.fblnRegistrar_BultoRepacking(objBultoRepacking, strMensajeError)
    End Function

    Public Function mfblnEliminar_ItemBulto(ByVal ItemBulto As clsAlmacen.NewType_ItemBulto) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""

        If mfblnPreguntas(enumPregVarios.PROCESO_Eliminar) Then
            Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
            blnResultado = objAlmacen.fblnEliminar_ItemBulto(ItemBulto.pCodigoCliente_CCLNT, ItemBulto.pCodigoRecepcion_CREFFW, _
                                                             ItemBulto.pCodigoIdentificacionPaquete_CIDPAQ, strMensajeError)
            If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            objAlmacen = Nothing
            Return blnResultado
        End If
        Return blnResultado
    End Function

    Public Function mfblnEliminar_BultoPaleta(ByVal intCliente As Int64, ByVal intNroPaleta As Int64, ByVal strBulto As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""

        If mfblnPreguntas(enumPregVarios.PALETA_EliminarBulto) Then
            Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
            'blnResultado = objAlmacen.fblnEliminar_BultoPaleta(intCliente, intNroPaleta, strBulto, strMensajeError)
            blnResultado = objAlmacen.fblnEliminar_BultoPaleta_V2(intCliente, intNroPaleta, strBulto, strMensajeError)
            If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            objAlmacen = Nothing
            Return blnResultado

        End If
        Return blnResultado
    End Function

    Public Function mfblRegistrar_BultosEtiquetados(ByVal intCliente As Int64, ByVal lstBultos As List(Of String)) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        blnResultado = objAlmacen.fblnRegistar_BultoEtiquetada(intCliente, lstBultos, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objAlmacen = Nothing
        Return blnResultado
    End Function

    Public Function mfblRegistrar_PaletasEtiquetadas(ByVal intCliente As Int64, ByVal lstPaletas As List(Of Int64)) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
        blnResultado = objAlmacen.fblnRegistar_PaletaEtiquetada(intCliente, lstPaletas, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objAlmacen = Nothing
        Return blnResultado
    End Function

    Public Sub mpImprimir_EtiquetaBulto(ByVal obeBulto As beBulto)
        Dim fInput As frmInput = New frmInput
        Dim strMensajeError As String = ""





        With fInput
            .pTitulo = "Etiqueta"
            .pMensaje = "¿ Desea imprimir la etiqueta ? " & vbNewLine & vbNewLine & "Ingrese el Nro. de Copias : "
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
                Dim intNroCopias As Int16 = 0
                If Int16.TryParse(.pInput, intNroCopias) Then
                    Dim obrBulto As New brBulto
                    obeBulto.PNCATCOPYA = intNroCopias
                    'Dim lstrEtiquetas As List(Of String) = clsAlmacen.flstrEtiqueta_Bulto(intCliente, strBulto, False, intNroCopias, strMensajeError)
                    Dim lstrEtiquetas As List(Of String) = obrBulto.ImprimirEtiquetaBulto(obeBulto)
                    Dim strEtiqTemp As String = ""
                    For Each strEtiqTemp In lstrEtiquetas
                        ' oPrinterZebra.Write(strEtiqTemp)
                        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                    Next
                End If
                ' Else
                '    MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
                'oPrinterZebra.EndWrite()
            End If
            .Dispose()
            fInput = Nothing
        End With
    End Sub


    Public Sub mpImprimir_EtiquetaBulto_Detalle(ByVal obeBulto As beBulto)

        Dim fInput As frmCantImpresion = New frmCantImpresion
        Dim strMensajeError As String = ""
        With fInput
            fInput.ShowDialog()
            ' If .ShowDialog = Windows.Forms.DialogResult.OK Then
            '  If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
            Dim intNroCopias As Int16 = 0
            If Int16.TryParse(.pTotal, intNroCopias) Then
                Dim obrBulto As New brBulto
                obeBulto.PNCATCOPYA = intNroCopias
                For i As Integer = 1 To intNroCopias
                    'Dim lstrEtiquetas As List(Of String) = clsAlmacen.flstrEtiqueta_Bulto(intCliente, strBulto, False, intNroCopias, strMensajeError)
                    Dim lstrEtiquetas As List(Of String) = obrBulto.ImprimirEtiquetaBultoCompleto(obeBulto, , .pInit, .pTotal, .pIdDetailled, i)
                    'Dim strEtiqTemp As String = ""

                    'Dim printername As String
                    'printername = Configuration.ConfigurationSettings.AppSettings("ZebraPrinter").ToString()

                    'If printername = "" Then
                    '    printername = Configuration.ConfigurationSettings.AppSettings("ZebraPrinter2").ToString()
                    'End If

                    ' MsgBox("Imprimira Etiquetas con la impresora " & printername)

                    For Each strEtiqTemp As String In lstrEtiquetas
                        'oPrinterZebra.Write(strEtiqTemp)
                        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                    Next
                Next

            End If
            'Else
            '   MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'oPrinterZebra.EndWrite()
            '  End If

            .Dispose()
            fInput = Nothing
        End With


    End Sub

    Public Sub mpImprimir_EtiquetaBulto_Mineria(ByVal obeBulto As beBulto)

        Dim fInput As New frmCantImpresionEtiqueta

        'Dim fInput As frmInput = New frmInput
        Dim strMensajeError As String = ""

        With fInput
            .CantBulto = obeBulto.PNQREFFW
            '    .pTitulo = "Etiqueta"
            '    .pMensaje = "¿ Desea imprimir la etiqueta ? " & vbNewLine & vbNewLine & "Ingrese el Nro. de Copias : "
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'Dim intNroCopias As Int16 = 0
                'If Int16.TryParse(.pInput, intNroCopias) Then
                Dim obrBulto As New brBulto
                'obeBulto.PNCATCOPYA = intNroCopias
                obeBulto.PNCATCOPYA = .CantCopias
                obeBulto.InicioImpresion = .InicioEtiqueta
                obeBulto.FinImpresion = .FinEtiqueta
                Dim lstrEtiquetas As List(Of String) = obrBulto.ImprimirEtiquetaBulto_Mineria(obeBulto)
                Dim strEtiqTemp As String = ""
                For Each strEtiqTemp In lstrEtiquetas
                    RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                Next
                'End If
            End If
            '.Dispose()
            'fInput = Nothing
        End With
    End Sub

    'Public Sub mpImprimir_EtiquetaBulto(ByVal obeBulto As beBulto)
    '    Dim fInput As frmInput = New frmInput
    '    Dim obrBulto As New brBulto
    '    Dim strMensajeError As String = ""
    '    With fInput
    '        .pTitulo = "Etiqueta"
    '        .pMensaje = "¿ Desea imprimir la etiqueta ? " & vbNewLine & vbNewLine & "Ingrese el Nro. de Copias : "
    '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
    '                Dim intNroCopias As Int16 = 0
    '                If Int16.TryParse(.pInput, intNroCopias) Then
    '                    'Dim lstrEtiquetas As List(Of String) = clsAlmacen.flstrEtiqueta_Bulto(intCliente, strBulto, False, intNroCopias, strMensajeError)
    '                    Dim lstrEtiquetas As List(Of beBulto) = obrBulto.ListarEtiquetas_BultoSAT(obeBulto, strMensajeError, intNroCopias, False)
    '                    Dim strEtiqTemp As String = ""
    '                    For Each strEtiqTemp In lstrEtiquetas.ToString()
    '                        oPrinterZebra.Write(strEtiqTemp)
    '                        'File.WriteAllText("c:\plEtiquetaBultoCINF.txt", strEtiqTemp)
    '                        'Shell("print /d:lpt1 c:\plEtiquetaBultoCINF.txt", AppWinStyle.Hide, True)
    '                    Next
    '                End If
    '            Else
    '                MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '            oPrinterZebra.EndWrite()
    '        End If
    '        .Dispose()
    '        fInput = Nothing
    '    End With
    'End Sub


    Public Sub mpImprimir_EtiquetaPaleta(ByVal intCliente As Int64, ByVal intNroPaleta As Int64)
        Dim fInput As frmInput = New frmInput
        Dim strMensajeError As String = ""
        With fInput
            .pTitulo = "Etiqueta"
            .pMensaje = "¿ Desea imprimir la etiqueta ? " & vbNewLine & vbNewLine & "Ingrese el Nro. de Copias : "
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
                Dim intNroCopias As Int16 = 0
                If Int16.TryParse(.pInput, intNroCopias) Then
                    Dim lstrEtiquetas As List(Of String) = clsAlmacen.flstrEtiqueta_Paleta(intCliente, intNroPaleta, intNroCopias, strMensajeError)
                    Dim strEtiqTemp As String = ""
                    For Each strEtiqTemp In lstrEtiquetas
                        'oPrinterZebra.Write(strEtiqTemp)
                        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                        'File.WriteAllText("c:\plEtiquetaPaletaSINF.txt", strEtiqTemp)
                        'Shell("print /d:lpt1 c:\plEtiquetaPaletaSINF.txt", AppWinStyle.Hide, True)
                    Next
                End If
                'Else
                '   MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
                'oPrinterZebra.EndWrite()
            End If
            .Dispose()
            fInput = Nothing
        End With
    End Sub

    Public Sub mpImprimir_BultosSinEtiquetar(ByVal intCliente As Int64)
        If mfblnExiste_BultosSinEtiquetas(intCliente) Then
            Dim fBultosSinEtiquetas As frmBultosSinEtiquetas = New frmBultosSinEtiquetas
            Dim dtTemp As DataTable = mfdtListar_BultosSinEtiquetas(intCliente)
            Dim lstBultos As List(Of String) = New List(Of String)
            Dim strMensajeError As String = ""
            With fBultosSinEtiquetas
                .pMensaje = "Ingrese el Nro de copias de Etiqueta por Bulto : "
                .pBultos = dtTemp
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
                    Dim intNroCopias As Int16 = 0
                    If Int16.TryParse(.pInput, intNroCopias) Then
                        Dim rwTemp As DataRow
                        For Each rwTemp In dtTemp.Rows
                            ' Actualizamos el Archivo Temporal para realizar la impresión
                            Dim lstrBulto As List(Of String) = clsAlmacen.flstrEtiqueta_Bulto(intCliente, rwTemp("CREFFW").ToString.Trim, False, intNroCopias, strMensajeError)
                            Dim strEtiqTemp As String = ""
                            For Each strEtiqTemp In lstrBulto
                                'oPrinterZebra.Write(strEtiqTemp)
                                RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                                'File.WriteAllText("c:\plEtiquetaBultoCINF.txt", strEtiqTemp)
                                'Shell("print /d:lpt1 c:\plEtiquetaBultoCINF.txt", AppWinStyle.Hide, True)
                            Next
                            lstBultos.Add(rwTemp("CREFFW").ToString.Trim)
                        Next
                    End If
                    'Else
                    '  MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If
                    'oPrinterZebra.EndWrite()
                End If
            End With
            ' Marcamos los Bultos
            If lstBultos.Count > 0 And mfblRegistrar_BultosEtiquetados(intCliente, lstBultos) Then
                MessageBox.Show("Proceso de impresión culminó satisfactoriamente.", "Impresión:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub mpImprimir_PaletasSinEtiquetar(ByVal intCliente As Int64)
        If mfblnExiste_PaletasSinEtiquetas(intCliente) Then
            Dim fPaletasSinEtiqueta As frmPaletasSinEtiqueta = New frmPaletasSinEtiqueta
            Dim dtTemp As DataTable = mfdtListar_PaletasSinEtiquetas(intCliente)
            Dim lstPaletas As List(Of Int64) = New List(Of Int64)
            Dim strMensajeError As String = ""
            With fPaletasSinEtiqueta
                .pMensaje = "Ingrese el Nro de copias de Etiqueta por Paleta : "
                .pPaletas = dtTemp
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
                    Dim intNroCopias As Int16 = 0
                    If Int16.TryParse(.pInput, intNroCopias) Then
                        Dim rwTemp As DataRow
                        For Each rwTemp In dtTemp.Rows
                            ' Actualizamos el Archivo Temporal para realizar la impresión
                            Dim lstrBulto As List(Of String) = clsAlmacen.flstrEtiqueta_Paleta(intCliente, rwTemp("NROPLT").ToString.Trim, intNroCopias, strMensajeError)
                            Dim strEtiqTemp As String = ""
                            For Each strEtiqTemp In lstrBulto
                                'oPrinterZebra.Write(strEtiqTemp)
                                RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strEtiqTemp)
                                'File.WriteAllText("c:\plEtiquetaPaletaSINF.txt", strEtiqTemp)
                                'Shell("print /d:lpt1 c:\plEtiquetaPaletaSINF.txt", AppWinStyle.Hide, True)
                            Next
                            lstPaletas.Add(rwTemp("NROPLT"))
                        Next
                    End If
                    'Else
                    '     MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' End If
                    '   oPrinterZebra.EndWrite()
                End If
            End With
            ' Marcamos los Bultos
            If lstPaletas.Count > 0 And mfblRegistrar_PaletasEtiquetadas(intCliente, lstPaletas) Then
                MessageBox.Show("Proceso de impresión culminó satisfactoriamente.", "Impresión:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub mpImprimir_EtiquetaSecuenciaBultos(ByVal intCliente As Int64, ByVal strPrefijo As String, ByVal intInicial As Int64, ByVal intFinal As Int64, _
                                                  ByVal intNroCopias As Int32)
        ' If oPrinterZebra.StartWrite(GLOBAL_IMPRESORA_ZEBRA) Then
        Dim strMensajeError As String = ""
        Dim lstrBultos As List(Of String) = clsAlmacen.flstrEtiquetas_SecuenciaBultos(intCliente, strPrefijo, intInicial, intFinal, intNroCopias, strMensajeError)
        Dim strTemp As String = ""
        For Each strTemp In lstrBultos
            'oPrinterZebra.Write(strTemp)
            RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, strTemp)
            ' Actualizamos el Archivo Temporal para realizar la impresión
            'File.WriteAllText("c:\plEtiquetaBultoSINF.txt", strTemp)
            'Shell("print /d:lpt1 c:\plEtiquetaBultoSINF.txt", AppWinStyle.Hide, True)
        Next
        MessageBox.Show("Proceso de impresión culminó satisfactoriamente.", "Impresión:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        ' MessageBox.Show(oPrinterZebra.ErrorMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        'oPrinterZebra.EndWrite()
    End Sub

    '------------------------------------------------------------------------------------------------------------------'
    '- Generación de reportes -'
    '--------------------------'
    'Public Function mfrptGeneradorReportes(ByVal objFiltro As clsFiltros_InventarioAlmacen) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReportesAlmacen As clsReportesAlmacen = New clsReportesAlmacen(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    objTemp = objReportesAlmacen.frptInventarioAlmacen(objFiltro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function

    Public Function mfrptGeneradorReportes(ByVal objFiltro As clsFiltros_ActividadAlmacen) As DataSet 'TipoDato_ResultaReporte
        'Dim objTemp As TipoDato_ResultaReporte
        Dim oDs As New DataSet
        Dim objReportesAlmacen As clsReportesAlmacen = New clsReportesAlmacen(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        oDs = objReportesAlmacen.frptActividadAlmacen(objFiltro, strMensajeError, objSeguridadBN.pstrServidor, objSeguridadBN.pUsuario, objSeguridadBN.pstrPassword)
        'objTemp = objReportesAlmacen.frptActividadAlmacen(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return oDs
    End Function

    'Public Function mfrptGeneradorReportes(ByVal objFiltro As clsFiltro_IngresoPorAlmacen) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReportesAlmacen As clsReportesAlmacen = New clsReportesAlmacen(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    objTemp = objReportesAlmacen.frptIngresosPorAlmacen(objFiltro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function

    Public Function mfrptGeneradorReportes(ByVal objFiltro As TD_Qry_SegOC_L01) As TipoDato_ResultaReporte
        Dim objTemp As TipoDato_ResultaReporte
        Dim objReportesAlmacen As clsReportesAlmacen = New clsReportesAlmacen(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        objTemp = objReportesAlmacen.frptSegOCSegunFechaEntrega(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return objTemp
    End Function

    'Public Function mfrptGeneradorReportes(ByVal objFiltro As TD_Qry_MovProValor_L01) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReportesAlmacen As clsReportesAlmacen = New clsReportesAlmacen(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    objTemp = objReportesAlmacen.frptMovimientoProductosValor(objFiltro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    '------------------------------------------------------------------------------------------------------------------'
    '- Información para los WEB SERVICES -'
    '-------------------------------------'
#End Region



    '    ' RUTINA A SER CONVERTIDAS A PROCEDURE
    '#Region " Funciones DAO - Almacén "
    '    'Public Function fblnGrabarBulto(ByVal olbeBulto As List(Of beBulto), ByVal blnEsNuevo As Boolean, Optional ByVal blnisParcial As Boolean = False) As Boolean
    '    '    Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
    '    '    Dim strMensajeResultado As String = ""
    '    '    For Each obeBulto As beBulto In olbeBulto
    '    '        If Not objAlmacen.fblnGrabarBulto(obeBulto, blnEsNuevo, strMensajeResultado, blnisParcial) Then
    '    '            MessageBox.Show(strMensajeResultado, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '            Return False
    '    '            Exit Function
    '    '        End If
    '    '    Next
    '    '    MessageBox.Show(strMensajeResultado, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    objAlmacen = Nothing
    '    '    Return True
    '    'End Function

    '    'Public Function fblnGrabarBulto(ByVal obeBulto As beBulto, ByVal blnEsNuevo As Boolean, Optional ByVal blnisParcial As Boolean = False) As Boolean
    '    '    Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
    '    '    Dim strMensajeResultado As String = ""
    '    '    If Not objAlmacen.fblnGrabarBulto(obeBulto, blnEsNuevo, strMensajeResultado, blnisParcial) Then
    '    '        MessageBox.Show(strMensajeResultado, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        Return False
    '    '        Exit Function
    '    '    End If

    '    '    MessageBox.Show(strMensajeResultado, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    objAlmacen = Nothing
    '    '    Return True
    '    'End Function


    '    'Public Function fblnObtenerBulto(ByRef obeBulto As beBulto) As Boolean
    '    '    Dim objAlmacen As clsAlmacen = New clsAlmacen(objSeguridadBN.pUsuario)
    '    '    Dim strMensajeError As String = ""
    '    '    Dim blnResultado As Boolean
    '    '    'With OBE
    '    '    '    .pCodigoCliente_CCLNT = intCliente
    '    '    '    .pCodigoRecepcion_CREFFW = strBulto
    '    '    '    .pCCMPN_CodigoCompania = strCCMPN
    '    '    '    .pCDVSN_CodigoDivision = strCDVSN
    '    '    '    .pCPLNDV_CodigoPlanta = dblCPLNDV
    '    '    'End With
    '    '    blnResultado = objAlmacen.fblnObtenerBulto(obeBulto)
    '    '    If strMensajeError <> "" Then
    '    '        MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '    End If
    '    '    objAlmacen = Nothing
    '    '    Return blnResultado
    '    'End Function
    '#End Region
End Module
