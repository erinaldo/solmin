Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho
Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho.Procesos
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Db2Manager.RansaData.iSeries.DataObjects

Module mPreDespacho
#Region " Atributos "

#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
    '-------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'
    Public Function mfblnExiste_BultoParaPreDespacho(ByVal objBulto As clsPrimaryKey_BultoPreDespacho, ByVal blnMsgSiExiste As Boolean, _
                                                     ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = clsPreDespacho.fblnExiste_BultoParaPreDespacho(strMensajeError, objBulto)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si existe información
        If blnMsgSiExiste And Not blnResultado Then _
            MessageBox.Show("El Bulto " & objBulto.pstrCodigoRecepcion_CREFFW & " ya se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si no existe información
        If blnMsgSiNoExiste And Not blnResultado Then _
            MessageBox.Show("El Bulto " & objBulto.pstrCodigoRecepcion_CREFFW & " no se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    Public Function mfblnExiste_BultoParaPreDespacho(ByVal intCliente As Int64, ByVal strBulto As String, ByVal blnMsgSiExiste As Boolean, _
                                                     ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim blnResultado As Boolean = False
        Dim objBulto As clsPrimaryKey_BultoPreDespacho = New clsPrimaryKey_BultoPreDespacho
        With objBulto
            .pintCodigoCliente_CCLNT = intCliente
            .pstrCodigoRecepcion_CREFFW = strBulto
        End With
        Dim strMensajeError As String = ""
        blnResultado = clsPreDespacho.fblnExiste_BultoParaPreDespacho(strMensajeError, objBulto)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si existe información
        If blnMsgSiExiste And blnResultado Then _
            MessageBox.Show("El Bulto " & objBulto.pstrCodigoRecepcion_CREFFW & " ya se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Mostrar mensaje si no existe información
        If blnMsgSiNoExiste And Not blnResultado Then _
            MessageBox.Show("El Bulto " & objBulto.pstrCodigoRecepcion_CREFFW & " no se encuentra registra " & vbNewLine & _
                            "en el PreDespacho.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return blnResultado
    End Function

    '-----------------------------------------------------'
    '- Procedimiento para Obtener Información del Objeto -'
    '-----------------------------------------------------'
    Public Function mfobjInformacion_PreDespacho(ByVal objPrimaryKey_PreDespacho As clsPrimaryKey_PreDespacho) As clsInformacion_PreDespacho
        Dim objInformacion_PreDespacho As clsInformacion_PreDespacho
        Dim strMensajeError As String = ""
        objInformacion_PreDespacho = clsPreDespacho.fobjInformacion_PreDespacho(strMensajeError, objPrimaryKey_PreDespacho)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return objInformacion_PreDespacho
    End Function

    '-----------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_PreDespachos(ByVal objFiltros As clsFiltrosParaPreDespachos) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsPreDespacho.fdtListar_PreDespachos(objFiltros, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_BultosPreDespachos(ByVal objFiltros As clsPrimaryKey_PreDespacho) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsPreDespacho.fdtListar_BultosPreDespachos(objFiltros, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_ItemsBultoPreDespachos(ByVal objFiltros As clsPrimaryKey_BultoPreDespacho) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsPreDespacho.fdtListar_ItemsBultoPreDespachos(objFiltros, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_SubItemsBultoPreDespachos(ByVal objFiltros As TD_ItemOCPK) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim objSqlManager As SqlManager = New SqlManager()
        dtResultado = Ransa.DAO.OrdenCompra.CSubItemOrdenCompra.fdtListar_Bulto_SubItemsOC_L01(objSqlManager, objFiltros, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '----------------------------------------------'
    '- Procedimiento de Agregación de Información -'
    '----------------------------------------------'
    Public Function mfblnAgregar_BultoPreDespachos(ByVal objInformacion_AgregarBultoPreDespacho As clsInformacion_AgregarBultoPreDespacho) As Boolean
        Dim objPreDespacho As clsPreDespacho = New clsPreDespacho(objSeguridadBN.pUsuario)
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        blnResultado = objPreDespacho.fblnAgregar_BultoPreDespachos(objInformacion_AgregarBultoPreDespacho, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objPreDespacho = Nothing
        Return blnResultado
    End Function

    '-----------------------------------------------'
    '- Procedimiento de Eliminación de Información -'
    '-----------------------------------------------'
    'Public Function mfblnEliminar_BultoPreDespachos(ByVal objPrimaryKey_BultoPreDespacho As clsPrimaryKey_BultoPreDespacho) As Boolean
    '    Dim objPreDespacho As clsPreDespacho = New clsPreDespacho(objSeguridadBN.pUsuario)
    '    Dim blnResultado As Boolean = False
    '    Dim strMensajeError As String = ""
    '    blnResultado = objPreDespacho.fblnEliminar_BultoPreDespachos(objPrimaryKey_BultoPreDespacho, strMensajeError)
    '    If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    objPreDespacho = Nothing
    '    Return blnResultado
    'End Function
#End Region
End Module
