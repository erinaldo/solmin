Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.CtrlsSolmin
Imports RANSA.TypeDef.Servicios.Almacenaje
Imports RANSA.DAO.Servicios.Almacenaje
Imports Ransa.Rpt.Servicios.Almacenaje

Public Class ucAlmacenaje_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal Mensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirm(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    ' Eventos a Procesar
    Public Event Agregar()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal Almacenaje As TD_Inf_LstAlmacenaje_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal Almacenaje As TD_Inf_LstAlmacenaje_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private oAlmacenaje As cAlmacenaje = New Ransa.DAO.Servicios.Almacenaje.cAlmacenaje
    Private oRepAlmacenaje As rAlmacenaje = New Ransa.Rpt.Servicios.Almacenaje.rAlmacenaje
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_LstAlmacenaje_L01 As TD_Qry_LstAlmacenaje_L01 = New Ransa.TypeDef.Servicios.Almacenaje.TD_Qry_LstAlmacenaje_L01
    Private oInf_LstAlmacenaje_L01 As TD_Inf_LstAlmacenaje_L01 = New Ransa.TypeDef.Servicios.Almacenaje.TD_Inf_LstAlmacenaje_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private intFilaActual As Int32 = 0
    Private blnConfirm As Boolean = True
    Private blnCargando As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property AskForConfirmation() As Boolean
        Get
            Return blnConfirm
        End Get
        Set(ByVal value As Boolean)
            blnConfirm = value
        End Set
    End Property

    Public Property BackGround() As Color
        Get
            Return dgAlmacenaje.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgAlmacenaje.StateCommon.Background.Color1 = value
        End Set
    End Property

    Public ReadOnly Property pNroOperacion() As Int64
        Get
            Return oInf_LstAlmacenaje_L01.pNPRALM_NroOperacion
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente <> 0 Then
            blnCargando = True
            dgAlmacenaje.DataSource = oAlmacenaje.Listar(oQry_LstAlmacenaje_L01)
            blnCargando = False
            If oAlmacenaje.ErrorMessage <> "" Then
                oInf_LstAlmacenaje_L01.pClear()
                RaiseEvent ErrorMessage(oAlmacenaje.ErrorMessage)
            Else
                ' Carga el Item y lanzo el evento respectivo
                If dgAlmacenaje.RowCount > 0 Then
                    With oInf_LstAlmacenaje_L01
                        .pCCLNT_CodigoCliente = oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente
                        .pNPRALM_NroOperacion = dgAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                        .pNANPRC_AnoProceso = dgAlmacenaje.CurrentRow.Cells("M_NANPRC").Value
                        .pNMES_MesProceso = dgAlmacenaje.CurrentRow.Cells("M_NMES").Value
                    End With
                    intFilaActual = 0
                    RaiseEvent DataLoadCompleted(oInf_LstAlmacenaje_L01)
                Else
                    oInf_LstAlmacenaje_L01.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If            
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgAlmacenaje.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        oInf_LstAlmacenaje_L01.pClear()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim fAlmacenaje As ucAlmacenaje_FAlmF01
        With oQry_LstAlmacenaje_L01
            fAlmacenaje = New ucAlmacenaje_FAlmF01(.pCCMPN_Compania, .pCDVSN_Division, .pCPLNDV_Planta, .pCCLNT_CodigoCliente, .pSTPODP_TipoSistAlm)
        End With
        ' Mostramos el Formulario
        fAlmacenaje.ShowDialog()
        ' Recogemos toda la información del Formulario
        Dim oInf_AddAlmacenaje_L01 As TD_Inf_AddAlmacenaje_L01 = New TD_Inf_AddAlmacenaje_L01
        Dim iNroOperacion As Int64 = 0
        With fAlmacenaje.pDatos
            If .pCCLNT_CodigoCliente Then
                oInf_AddAlmacenaje_L01.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
                oInf_AddAlmacenaje_L01.pCCMPN_Compania = .pCCMPN_Compania
                oInf_AddAlmacenaje_L01.pCDVSN_Division = .pCDVSN_Division
                oInf_AddAlmacenaje_L01.pCPLNDV_Planta = .pCPLNDV_Planta
                oInf_AddAlmacenaje_L01.pSTPODP_TipoSistAlm = .pSTPODP_TipoSistAlm
                oInf_AddAlmacenaje_L01.pNANPRC_Ano = .pNANPRC_Ano
                oInf_AddAlmacenaje_L01.pNMES_Mes = .pNMES_Mes
                oInf_AddAlmacenaje_L01.pFECINI_FechaInicial = .pFECINI_FechaInicial
                oInf_AddAlmacenaje_L01.pFECFIN_FechaFinal = .pFECFIN_FechaFinal
                oInf_AddAlmacenaje_L01.pOBSERV_Observacion = .pOBSERV_Observacion
                oInf_AddAlmacenaje_L01.pNDIALI_NroDiaLibres = .pNDIALI_NroDiaLibres

                oInf_AddAlmacenaje_L01.pNRTFSV_Tarifa_Servicio = .pNRTFSV_Tarifa_Servicio
                oInf_AddAlmacenaje_L01.pQCNESP_Cantidad_Base = .pQCNESP_Cantidad_Base
                oInf_AddAlmacenaje_L01.pTUNDIT_Unidad = .pTUNDIT_Unidad
                oInf_AddAlmacenaje_L01.pSTPOUN_TipoUnidad = .pSTPOUN_TipoUnidad
                oInf_AddAlmacenaje_L01.pCMNDA1_Moneda = .pCMNDA1_Moneda
                oInf_AddAlmacenaje_L01.pVALUNI_ValorUnitario = .pVALUNI_ValorUnitario

                oInf_AddAlmacenaje_L01.pSTPFLT_ConsiderarFiltros = .pSTPFLT_ConsiderarFiltros
                oInf_AddAlmacenaje_L01.pCREFFW_CodigoBulto = .pCREFFW_CodigoBulto
                oInf_AddAlmacenaje_L01.pNROPLT_NroPaleta = .pNROPLT_NroPaleta
                oInf_AddAlmacenaje_L01.pTTINTC_TermInterCarga = .pTTINTC_TermInterCarga
                oInf_AddAlmacenaje_L01.pTUBRFR_Ubicacion = .pTUBRFR_Ubicacion
                'oInf_AddAlmacenaje_L01.pSTPING_TipoMovimiento = ""
                'oInf_AddAlmacenaje_L01.pCRTLTE_CriterioLote = ""
                oInf_AddAlmacenaje_L01.pUsuario = oQry_LstAlmacenaje_L01.pUsuario
            End If
        End With
        If oAlmacenaje.Add(oInf_AddAlmacenaje_L01, iNroOperacion) Then
            RaiseEvent Message("Proceso Culminó satisfactoriamente." & vbNewLine & "Nro. Proceso : " & iNroOperacion)
            Call pCargarInformacion()
        Else
            RaiseEvent ErrorMessage(oAlmacenaje.ErrorMessage)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgAlmacenaje.RowCount <= 0 Then Exit Sub
        Dim blnConfirm As Boolean = False
        RaiseEvent Confirm("Desea eliminar el Bulto.", blnConfirm)
        If blnConfirm Then Exit Sub

        Dim oInf_DeleteAlmacenaje_L01 As TD_Inf_DeleteAlmacenaje_L01 = New TD_Inf_DeleteAlmacenaje_L01
        With oInf_DeleteAlmacenaje_L01
            .pCCLNT_CodigoCliente = oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente
            .pNPRALM_NroOperacion = dgAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
            .pUsuario = oQry_LstAlmacenaje_L01.pUsuario
        End With
        If oAlmacenaje.Delete(oInf_DeleteAlmacenaje_L01) Then
            dgAlmacenaje.Rows.Remove(dgAlmacenaje.CurrentRow)
            RaiseEvent Message("Proceso culminó satisfactoriamente.")
        Else
            RaiseEvent ErrorMessage(oAlmacenaje.ErrorMessage)
        End If
    End Sub

    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        If dgAlmacenaje.RowCount <= 0 Then Exit Sub
        
        Dim oPkey_Almacenaje As TD_Pkey_Almacenaje = New TD_Pkey_Almacenaje
        With oPkey_Almacenaje
            .pCCLNT_CodigoCliente = oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente
            .pNPRALM_NroOperacion = dgAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
        End With
        Dim fVisorRPT As ucCrlsVisorRpt_F01 = New ucCrlsVisorRpt_F01(oRepAlmacenaje.rCalculoAlmacenaje(oPkey_Almacenaje, oQry_LstAlmacenaje_L01.pUsuario))
        If oRepAlmacenaje.ErrorMessage = "" Then
            fVisorRPT.ShowDialog()
        Else
            RaiseEvent ErrorMessage(oRepAlmacenaje.ErrorMessage)
        End If
        fVisorRPT.Dispose()
        fVisorRPT = Nothing
    End Sub

    Private Sub ucItemAlmacenaje_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oAlmacenaje.Dispose()
        oAlmacenaje = Nothing
        oRepAlmacenaje.Dispose()
        oRepAlmacenaje = Nothing
    End Sub

    Private Sub dgAlmacenaje_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAlmacenaje.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgAlmacenaje.CurrentCell Is Nothing Then
            intFilaActual = -1
            oInf_LstAlmacenaje_L01.pClear()
        Else
            If dgAlmacenaje.CurrentCell.RowIndex <> intFilaActual Then
                intFilaActual = dgAlmacenaje.CurrentCell.RowIndex
                With oInf_LstAlmacenaje_L01
                    .pCCLNT_CodigoCliente = oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente
                    .pNPRALM_NroOperacion = dgAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                    .pNANPRC_AnoProceso = dgAlmacenaje.CurrentRow.Cells("M_NANPRC").Value
                    .pNMES_MesProceso = dgAlmacenaje.CurrentRow.Cells("M_NMES").Value
                End With
                RaiseEvent CurrentRowChanged(oInf_LstAlmacenaje_L01)
            End If
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pUpdateCurrentRow()
        If blnCargando Then Exit Sub
        If oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente <> 0 Then
            If dgAlmacenaje.RowCount > 0 Then
                Dim oPKey_Almacenaje As TD_Pkey_Almacenaje = New TD_Pkey_Almacenaje
                oPKey_Almacenaje.pCCLNT_CodigoCliente = oQry_LstAlmacenaje_L01.pCCLNT_CodigoCliente
                oPKey_Almacenaje.pNPRALM_NroOperacion = dgAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                Dim dtTemp As DataTable = oAlmacenaje.GetObj(oPKey_Almacenaje)
                If oAlmacenaje.ErrorMessage <> "" Then
                    RaiseEvent ErrorMessage(oAlmacenaje.ErrorMessage)
                Else
                    Dim iCont As Int32 = 0
                    Dim sNameCol As String = ""
                    While iCont < dgAlmacenaje.Columns.Count
                        sNameCol = dgAlmacenaje.Columns(iCont).DataPropertyName
                        dgAlmacenaje.CurrentRow.Cells(iCont).Value = dtTemp.Rows(0).Item(sNameCol)
                        iCont += 1
                    End While
                End If
            End If
        End If
    End Sub

    Public Sub pActualizar(ByVal Filtro As TD_Qry_LstAlmacenaje_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With oQry_LstAlmacenaje_L01
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pCCMPN_Compania = Filtro.pCCMPN_Compania
            .pCDVSN_Division = Filtro.pCDVSN_Division
            .pCPLNDV_Planta = Filtro.pCPLNDV_Planta
            .pSTPODP_TipoSistAlm = Filtro.pSTPODP_TipoSistAlm
            .pNPRALM_NroOperacion = Filtro.pNPRALM_NroOperacion
            .pNANPRC_AnoProceso = Filtro.pNANPRC_AnoProceso
            .pNMES_MesProceso = Filtro.pNMES_MesProceso
            .pUsuario = Filtro.pUsuario
        End With
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub
#End Region
End Class