Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS.Procesos

Module mMantenimientoSDS
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Funciones para Obtener Detalle de la Información -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    Public Function mfblnObtener_Mercaderia(ByVal objPrimaryKey_Mercaderia As clsPrimaryKey_Mercaderia, ByRef objMercaderia As clsMercaderia) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim dtEntidad As DataTable = objMantenimiento.fdtObtener_Mercaderia(objPrimaryKey_Mercaderia, strMensajeError)

        If strMensajeError <> "" Then
            objMercaderia = New clsMercaderia
            blnResultado = False
        Else
            If dtEntidad.Rows.Count > 0 Then
                With objMercaderia
                    Int64.TryParse(dtEntidad.Rows(0).Item("CCLNT"), .pintCodigoCliente_CCLNT)
                    .pstrCodigoMercaderia_CMRCLR = dtEntidad.Rows(0).Item("CMRCLR").ToString.Trim
                    .pstrCodigoFamilia_CFMCLR = dtEntidad.Rows(0).Item("CFMCLR").ToString.Trim
                    .pstrCodigoGrupo_CGRCLR = dtEntidad.Rows(0).Item("CGRCLR").ToString.Trim
                    .pstrCodigoMercaderiaReemplazo_CMRCRR = dtEntidad.Rows(0).Item("CMRCRR").ToString.Trim
                    .pstrCodigoRANSA_CMRCD = dtEntidad.Rows(0).Item("CMRCD").ToString.Trim
                    .pstrDescripcion_TMRCD2 = dtEntidad.Rows(0).Item("TMRCD2").ToString.Trim
                    .pstrDescripcion_TMRCD3 = dtEntidad.Rows(0).Item("TMRCD3").ToString.Trim
                    Int64.TryParse(dtEntidad.Rows(0).Item("CPRVCL"), .pintProveedor_CPRVCL)
                    Integer.TryParse(dtEntidad.Rows(0).Item("CMNCT"), .pintCodigoMoneda_CMNCT)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QIMCT"), .pdecImporteCosto_QIMCT)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QIMCTP"), .pdecImporteCostoPromedio_QIMCTP)
                    .pstrMarcaReembolso_MARCRE = dtEntidad.Rows(0).Item("MARCRE").ToString.Trim
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QICOPS"), .pdecImporteCostoPromedioSoles_QICOPS)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("IMVTAD"), .pdecImporteVentaDolar_IMVTAD)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("IMVTAS"), .pdecImporteVentaDolar_IMVTAS)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("IMVLM2"), .pdecImportePorMts2_IMVLM2)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("PDSCTO"), .pdecPorcentajeDescuento_PDSCTO)
                    .pstrMarcaModelo_TMRCTR = dtEntidad.Rows(0).Item("TMRCTR").ToString.Trim
                    .pstrUbicacion_UBICA1 = dtEntidad.Rows(0).Item("UBICA1").ToString.Trim
                    .pstrObservacion_TOBSRV = dtEntidad.Rows(0).Item("TOBSRV").ToString.Trim
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QMRSRC"), .pdecCantidadMinimaReqServicio_QMRSRC)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QMRSRP"), .pdecPesoMinimoReqServicio_QMRSRP)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QMRODC"), .pdecCantidadMercaderiaPtoReorden_QMRODC)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QMRODP"), .pdecPesoMercaderiaPtoReorden_QMRODP)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QMRPRD"), .pdecCantidadMinimaProducir_QMRPRD)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QLRGMR"), .pdecLargoMercaderia_QLRGMR)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QANCMR"), .pdecAnchoMercaderia_QANCMR)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QALTMR"), .pdecAlturaMercaderia_QALTMR)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QARMT2"), .pdecAreaMts2_QARMT2)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QARMT3"), .pdecVolumenMts3_QARMT3)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QVOLEQ"), .pdecVolumenEquivalente_QVOLEQ)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QPSODC"), .pdecCantidadPesoDeclarado_QPSODC)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QTMPCR"), .pdecTiempoCargaMercaderia_QTMPCR)
                    Decimal.TryParse(dtEntidad.Rows(0).Item("QTMPDS"), .pdecTiempoDesargaMercaderia_QTMPDS)
                    .pstrUnidad_CUNCNC = dtEntidad.Rows(0).Item("CUNCNC").ToString.Trim
                    .pstrUnidadInventario_CUNCNI = dtEntidad.Rows(0).Item("CUNCNI").ToString.Trim
                    .pstrStatusPublicacionWEB_FPUWEB = dtEntidad.Rows(0).Item("FPUWEB").ToString.Trim
                    Date.TryParse("" & dtEntidad.Rows(0).Item("FVNCMR"), .pdteFechaVencimiento_FVNCMR)
                    Date.TryParse("" & dtEntidad.Rows(0).Item("FINVRN"), .pdteFechaInventario_FINVRN)
                    .pstrCodigoPerfumancia_CPRFMR = dtEntidad.Rows(0).Item("CPRFMR").ToString.Trim
                    .pstrCodigoInflamabilidad_CINFMR = dtEntidad.Rows(0).Item("CINFMR").ToString.Trim
                    .pstrCodigoRotacion_CROTMR = dtEntidad.Rows(0).Item("CROTMR").ToString.Trim
                    .pstrCodigoApilabilidad_CAPIMR = dtEntidad.Rows(0).Item("CAPIMR").ToString.Trim
                    .pstrCodigoDUN14 = dtEntidad.Rows(0).Item("DUN14").ToString.Trim
                    .pstrCodigoEAN13 = dtEntidad.Rows(0).Item("EAN13").ToString.Trim
                    .CPTDAR_PartidaArancelaria = ("" & dtEntidad.Rows(0).Item("CPTDAR")).ToString.Trim
                    .pstrSituacion_SESTRG = dtEntidad.Rows(0).Item("SESTRG").ToString.Trim
                    .SCNTSR_MarcaControlSerie = dtEntidad.Rows(0).Item("SCNTSR").ToString.Trim
                End With
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                objMercaderia = New clsMercaderia
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    ' FAMILIA 
    Public Function mfblnGuardar_Familia(ByVal objNuevaFamilia As clsFamilia) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Familia(objNuevaFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfblnGuardar_Familia(ByVal lstNuevaFamilia As List(Of clsFamilia)) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Familia(lstNuevaFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfblnEliminar_Familia(ByVal objFamilia As clsFamilia) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Familia(objFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfblnEliminar_Familia(ByVal lstNuevaFamilia As List(Of clsFamilia)) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Familia(lstNuevaFamilia, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    ' GRUPO
    Public Function mfblnGuardar_Grupo(ByVal objNuevaGrupo As clsGrupo) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Grupo(objNuevaGrupo, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfdtGuardar_Grupo(ByVal lstNuevaGrupo As List(Of clsGrupo)) As DataTable
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim dtResultado As DataTable = objMantenimiento.fdtGuardar_Grupo(lstNuevaGrupo)
        objMantenimiento = Nothing
        If MessageBox.Show("¿ Desea ver los resutados del proceso ?", "Resultado:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim fresultado As frmResultadoMasivo = New frmResultadoMasivo
            fresultado.pdtResultado = dtResultado
            fresultado.ShowDialog()
        End If
        Return dtResultado
    End Function

    Public Function mfblnEliminar_Grupo(ByVal objGrupo As clsGrupo) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Grupo(objGrupo, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfdtEliminar_Grupo(ByVal lstGrupo As List(Of clsGrupo)) As DataTable
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim dtResultado As DataTable = objMantenimiento.fdtEliminar_Grupo(lstGrupo)
        objMantenimiento = Nothing
        If MessageBox.Show("¿ Desea ver los resutados del proceso ?", "Resultado:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim fresultado As frmResultadoMasivo = New frmResultadoMasivo
            fresultado.pdtResultado = dtResultado
            fresultado.ShowDialog()
        End If
        Return dtResultado
    End Function

    ' MERCADERIA
    Public Function mfblnGuardar_Mercaderia(ByVal objNuevaMercaderia As clsMercaderia) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Mercaderia(strMensajeError, objNuevaMercaderia)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function fblnGuardar_MercaderiaMasivo(ByVal objMercaderia As clsMercaderia) As String
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Return objMantenimiento.fblnGuardar_MercaderiaMasivo(objMercaderia)
    End Function

    Public Function mfblnEliminar_Mercaderia(ByVal objPrimaryKey_Mercaderia As clsPrimaryKey_Mercaderia) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Mercaderia(strMensajeError, objPrimaryKey_Mercaderia)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    ' CAMION
    Public Function mfblnGuardar_Camion(ByVal objNuevoCamion As clsCamion) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Camion(objNuevoCamion, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfblnEliminar_Camion(ByVal objPrimaryKey_Camion As clsPrimaryKey_Camion) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Camion(objPrimaryKey_Camion, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    ' CHOFER
    Public Function mfblnGuardar_Chofer(ByVal objNuevoChofer As clsChofer) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnGuardar_Chofer(objNuevoChofer, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function mfblnEliminar_Chofer(ByVal objPrimaryKey_Chofer As clsPrimaryKey_Chofer) As Boolean
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = objMantenimiento.fblnEliminar_Chofer(objPrimaryKey_Chofer, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        objMantenimiento = Nothing
        Return blnResultado
    End Function

    Public Function Listar_SKU_General(PSCCMPN As String, PNCCLNT As Decimal, PSCMRCLR As String, PNTIPO As Decimal) As DataTable
        Dim objMantenimiento As clsMantenimiento = New clsMantenimiento(objSeguridadBN.pUsuario)
        Return objMantenimiento.Listar_SKU_General(PSCCMPN, PNCCLNT, PSCMRCLR, PNTIPO)
    End Function


End Module
