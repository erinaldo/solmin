Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Procesos
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes


Module mDespacho
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    'Public Sub mpGenerarGuiaRemisionAT(ByVal objParam As clsPARAM_GuiaRemisionAT)
    '    Dim objReportes As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    Dim strAplicacion As String = ""
    '    strAplicacion = Application.StartupPath
    '    With frmVisorRPT
    '        .WindowState = FormWindowState.Maximized
    '        .Dock = DockStyle.Fill
    '        .pReportDocument = objReportes.frptGenerarGuiaRemision(objParam, strAplicacion, strMensajeError)
    '        If strMensajeError <> "" Then
    '            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            .ShowDialog()
    '        End If
    '    End With
    'End Sub

    '-------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    Public Function mfblnExiste_GuiaSalidaConGuiaRemision(ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = clsDespacho.fblnExiste_GuiaSalidaConGuiaRemision(strMensajeError, objPrimaryKey_Despacho)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return blnResultado
    End Function

    '-------------------------------------------'
    '- Funciones para los procesos de Despacho -'
    '-------------------------------------------'
    Public Function mfblnProceso_AnularGuiaSalida(ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
        blnResultado = objDespacho.fblnProceso_AnularGuiaSalida(strMensajeError, objPrimaryKey_Despacho)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objDespacho = Nothing
        Return blnResultado
    End Function

    Public Function mfblnProceso_RestaurarGuiaSalida(ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
        blnResultado = objDespacho.fblnProceso_RestaurarGuiaSalida(strMensajeError, objPrimaryKey_Despacho)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objDespacho = Nothing
        Return blnResultado
    End Function

    Public Function mfblnProceso_AnularGuiaRemision(ByVal objPrimaryKey_Despacho As clsPrimaryKey_Despacho) As Boolean
        Dim blnResultado As Boolean
        Dim strMensajeError As String = ""
        Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
        blnResultado = objDespacho.fblnProceso_AnularGuiaRemision(strMensajeError, objPrimaryKey_Despacho)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objDespacho = Nothing
        Return blnResultado
    End Function

    '---------------------------------'
    ' Funciones de Listar Información '
    '---------------------------------'
    Public Function mfdtListarGuiasSalida(ByVal objFiltro As clsFiltroGuiaSalida) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListarGuiasSalida(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListarGuiasRemision(ByVal objFiltro As clsPrimaryKey_Despacho) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListarGuiasRemision(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function


    '------------------------------------------------------------------------------------------------------------------'
    '- Generación de reportes -'
    '--------------------------'
    'Public Function mfrptGeneradorReportesDespacho(ByVal objFiltro As clsFiltros_DespachoPorAlmacen) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Dim objReportesDespacho As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
    '    Dim strMensajeError As String = ""
    '    objTemp = objReportesDespacho.frptDespachoPorAlmacen(objFiltro, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Return objTemp
    'End Function
    'Public Function mfrptGeneradorReportesGuiaSalidaMercaderia(ByVal has As Hashtable) As TipoDato_ResultaReporte
    '    Dim objTemp As TipoDato_ResultaReporte
    '    Try
    '        Dim objReportesDespacho As clsReportesDespacho = New clsReportesDespacho(objSeguridadBN.pUsuario)
    '        objTemp = objReportesDespacho.frptListaGuiaSalidaMercaderia(has)
    '    Catch ex As Exception
    '        objTemp = Nothing
    '    End Try
    '    Return objTemp
    'End Function
#End Region
End Module
