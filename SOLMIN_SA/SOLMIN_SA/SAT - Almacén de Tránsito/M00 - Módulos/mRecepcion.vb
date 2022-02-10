Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion


Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion.Procesos

Module mRecepcion
#Region " Variable Globales "
    '-- Crear status por control con F4
    Public booValidarNroOrdenCompra As Boolean = False
    Public booValidarMotivosRecepcion As Boolean = False
    Public booValidarTipoMovimiento As Boolean = False
    Public booValidarServicio As Boolean = False
    Public booValidarServicioTarifa As Boolean = False
    Public booValidarTarifaServicio As Boolean = False
    Public booValidarServicioAtendido As Boolean = False
    Public booValidarServicioCliente As Boolean = False
    Public booValidarNroPaletizado As Boolean = False
#End Region
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_ItemOCResumenPorSeleccionar(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_ItemsOrdenCompra(clsRecepcion.eTipoConsulta.ResumenPorSelec, objOrdenCompra, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_ItemOCResumenSeleccionados(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra) As DataTable

        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_ItemsOrdenCompra(clsRecepcion.eTipoConsulta.ResumenSelecc, objOrdenCompra, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        If dtResultado.Rows.Count > 0 Then
            dtResultado.Columns.Add("COD_PAQUETE")
        End If
        Return dtResultado
    End Function

    Public Function mfdtListar_ItemOCDetalladoSeleccionados(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_ItemsOrdenCompra(clsRecepcion.eTipoConsulta.DetalladoSelec, objOrdenCompra, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_MovimientoItemOrdenCompra(ByVal strCliente As String, ByVal strOrdenCompra As String, _
                                                         ByVal strItemOrdenCompra As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_MovimientoItemOrdenCompra(strCliente, strOrdenCompra, strItemOrdenCompra, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_MovimientoItemOrdenCompraUnRegistro(ByVal strCliente As String, ByVal strOrdenCompra As String, _
                                                         ByVal strItemOrdenCompra As String, ByVal Compania As String, ByVal Division As String, ByVal Planta As Double) As DataTable

      


        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsRecepcion.fdtListar_MovimientoItemOrdenCompra(strCliente, strOrdenCompra, strItemOrdenCompra, strMensajeError, Compania, Division, Planta)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Dim dtIngresos As DataTable = dtResultado.Copy
        Dim dtSalidas As DataTable = dtResultado.Copy
        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()

        Dim drs() As DataRow
        drs = dtIngresos.Select("INGSDA = 'SDA'")
        For Each dr As DataRow In drs
            dtIngresos.Rows.Remove(dr)
        Next
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next

        dtIngresos.AcceptChanges()
        dtSalidas.AcceptChanges()


        'dtSalidas.LoadDataRow(dtResultado.Select("INGSDA" = "SAL"), True)
        Dim cols(6) As DataColumn
        dtSalidas.Columns.CopyTo(cols, 0)
        For Each col As DataColumn In cols
            If dtSalidas.Columns.CanRemove(col) Then
                dtSalidas.Columns.Remove(col)
            End If
            col.ColumnName = col.ColumnName & "1"
            dtIngresos.Columns.Add(col)
        Next
        dtIngresos.AcceptChanges()
        dtSalidas = dtResultado.Copy
        drs = dtSalidas.Select("INGSDA = 'ING'")
        For Each dr As DataRow In drs
            dtSalidas.Rows.Remove(dr)
        Next
        For Each dr As DataRow In dtIngresos.Rows
            drs = dtSalidas.Select(String.Format("CREFFW = '{0}'", dr("CREFFW")))
            If drs.Length > 0 Then
                Dim d As DataRow = drs(0)
                For Each col As DataColumn In dtSalidas.Columns
                    dr(col.ColumnName + "1") = d(col.ColumnName)
                Next

            End If
        Next

        Return dtIngresos
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Detalle de la Información -'
    '--------------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    Public Function mfstrInformacion_ObservacionesItemOC(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra) As String
        Dim strMensajeError As String = ""
        Dim strResultado As String = ""
        strResultado = clsRecepcion.fstrInformacion_ObservacionesItemOC(objOrdenCompra, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return strResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    Public Function mfblnExiste_OrdenCompraConMovimiento(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra, ByRef strMensajeResultado As String) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsRecepcion.fblnExiste_OrdenCompraConMovimiento(strMensajeError, objOrdenCompra)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If blnResultado Then
            strMensajeResultado = "La Orden de Compra " & objOrdenCompra.pstrNroOrdenCompra_NORCML & " contiene movimientos." & vbNewLine
        Else
            strMensajeResultado = "La Orden de Compra " & objOrdenCompra.pstrNroOrdenCompra_NORCML & " no contiene movimineto. " & vbNewLine
        End If
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    Public Function mfblnCambiarClienteOC(ByVal objOrdenCompra As clsPrimaryKey_OrdenCompra, ByVal strClienteDestino As String) As Boolean
        Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objRecepcion.fblnCambiarClienteOC(strMensajeError, objOrdenCompra, strClienteDestino)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objRecepcion = Nothing
        Return blnResultado
    End Function
End Module
