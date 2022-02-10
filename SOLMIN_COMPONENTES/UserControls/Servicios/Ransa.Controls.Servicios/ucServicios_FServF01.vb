Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Cliente
Imports RANSA.TypeDef.Servicios
Imports RANSA.DAO.Servicios

Public Class ucServicios_FServF01
#Region " Definición Eventos "
    '-------------------------------------------------
    ' Eventos a Informar
    '-------------------------------------------------
    Public Event pDisposeForm(ByVal bStatusProceso As Boolean)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private strMensajeError As String = ""
    Private TD_InfServF01 As TD_Inf_Servicio_F01 = New Ransa.TypeDef.Servicios.TD_Inf_Servicio_F01
    Private lstIndexCbx As List(Of Int32) = New List(Of Int32)
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bStatusOperacion As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pActualizarServicios()
        ' Cargamos el datagrid con la información respectiva
        Dim oTemp1 As TD_Qry_Servicios_Adquiridos_L02 = New TD_Qry_Servicios_Adquiridos_L02
        oTemp1.pCCMPN_Compania = TD_InfServF01.pCCMPN_Compania
        oTemp1.pCDVSN_Division = TD_InfServF01.pCDVSN_Division
        oTemp1.pCPLNDV_Planta = TD_InfServF01.pCPLNDV_Planta
        oTemp1.pCCLNT_CodigoCliente = TD_InfServF01.pCCLNT_CodigoCliente
        oTemp1.pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
        oTemp1.pFOPRCN_FechaOperacion = TD_InfServF01.pFOPRCN_FechaOperacion
        oTemp1.pUsuario = TD_InfServF01.pUsuario
        ' Actualizamos la información a visualizar
        dgServicios.pActualizar(oTemp1)
    End Sub

    Private Sub pCargarInfInicial(ByVal value As TD_Inf_Servicio_F01)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With TD_InfServF01
            .pCCMPN_Compania = value.pCCMPN_Compania
            .pCDVSN_Division = value.pCDVSN_Division
            .pCPLNDV_Planta = value.pCPLNDV_Planta
            .pNOPRCN_Operacion = value.pNOPRCN_Operacion
            .pFOPRCN_FechaOperacion = value.pFOPRCN_FechaOperacion
            .pFECINI_Inicio = value.pFECINI_Inicio
            .pFECFIN_Final = value.pFECFIN_Final
            .pCCLNT_CodigoCliente = value.pCCLNT_CodigoCliente
            .pCCLNFC_ClienteFacturar = value.pCCLNFC_ClienteFacturar
            .pCPRCN1_Contenedor = value.pCPRCN1_Contenedor
            .pNSRCN1_SerieContenedor = value.pNSRCN1_SerieContenedor
            .pSTPODP_TipoSistAlm = value.pSTPODP_TipoSistAlm
            .pSTIPPR_Proceso = value.pSTIPPR_Proceso
            .pCREFFW_CodigoBulto = value.pCREFFW_CodigoBulto
            .pNROPLT_NroPaletizado = value.pNROPLT_NroPaletizado
            .pNROCTL_NroPreDespacho = value.pNROCTL_NroPreDespacho
            .pNRGUSA_NroGuiaSalida = value.pNRGUSA_NroGuiaSalida
            .pNGUIRM_NroGuiaRemision = value.pNGUIRM_NroGuiaRemision
            .pNORDSR_OrdenServicio = value.pNORDSR_OrdenServicio
            .pNSLCSR_NroSolicitud = value.pNSLCSR_NroSolicitud
            .pNGUIRN_NroGuiaRansa = value.pNGUIRN_NroGuiaRansa
            .pUsuario = value.pUsuario
        End With
    End Sub

    Private Sub pCargaInformacion()
        With TD_InfServF01
            txtNroOperacion.Text = .pNOPRCN_Operacion
            dteFechaOperacion.Value = .pFOPRCN_FechaOperacion
            dtpFechaInicial.Value = .pFECINI_Inicio
            dtpFechaFinal.Value = .pFECFIN_Final
            If .pNOPRCN_Operacion = 0 Then
                dteFechaOperacion.Enabled = True
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(.pCCLNT_CodigoCliente, TD_InfServF01.pUsuario)
                txtClienteFacturar.pCargar(ClientePK)
            Else
                dteFechaOperacion.Enabled = False
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(.pCCLNFC_ClienteFacturar, TD_InfServF01.pUsuario)
                txtClienteFacturar.pCargar(ClientePK)
            End If

            txtTipoProceso.pCargarPorCodigo = .pSTIPPR_Proceso
            txtCodigoContenedor.Text = .pCPRCN1_Contenedor
            txtSerieContenedor.Text = .pNSRCN1_SerieContenedor
            ' Actualizamos los Servicios
            Call pActualizarServicios()
            
            ' Cargamos el datagrid con la información de los bultos por operación 
            Select Case TD_InfServF01.pSTPODP_TipoSistAlm
                Case "1"
                    Dim oTemp2 As TD_Qry_Servicio_Mercaderia_F01 = New TD_Qry_Servicio_Mercaderia_F01
                    oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
                    oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
                    oTemp2.pSTPODP_TipoSistAlm = .pSTPODP_TipoSistAlm
                    oTemp2.pNORDSR_OrdenServicio = .pNORDSR_OrdenServicio
                    oTemp2.pNSLCSR_NroSolicitud = .pNSLCSR_NroSolicitud
                    oTemp2.pNGUIRN_NroGuiaRansa = .pNGUIRN_NroGuiaRansa
                    oTemp2.pUsuario = .pUsuario
                    dgMercaderias.pActualizar(oTemp2)
                Case "5"
                    Dim oTemp2 As TD_Qry_Servicio_Mercaderia_F01 = New TD_Qry_Servicio_Mercaderia_F01
                    oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
                    oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
                    oTemp2.pSTPODP_TipoSistAlm = .pSTPODP_TipoSistAlm
                    oTemp2.pNORDSR_OrdenServicio = .pNORDSR_OrdenServicio
                    oTemp2.pNSLCSR_NroSolicitud = .pNSLCSR_NroSolicitud
                    oTemp2.pNGUIRN_NroGuiaRansa = .pNGUIRN_NroGuiaRansa
                    oTemp2.pUsuario = .pUsuario
                    dgMercaderias.pActualizar(oTemp2)
                Case "7"
                    Dim oTemp2 As TD_Qry_Servicio_Bulto_F01 = New TD_Qry_Servicio_Bulto_F01
                    oTemp2.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
                    oTemp2.pNOPRCN_Operacion = .pNOPRCN_Operacion
                    oTemp2.pSTPODP_TipoSistAlm = .pSTPODP_TipoSistAlm
                    oTemp2.pCREFFW_CodigoBulto = .pCREFFW_CodigoBulto
                    oTemp2.pNROPLT_NroPaletizado = .pNROPLT_NroPaletizado
                    oTemp2.pNROCTL_NroPreDespacho = .pNROCTL_NroPreDespacho
                    oTemp2.pNRGUSA_NroGuiaSalida = .pNRGUSA_NroGuiaSalida
                    oTemp2.pNGUIRM_NroGuiaRemision = .pNGUIRM_NroGuiaRemision
                    oTemp2.pUsuario = .pUsuario
                    oTemp2.pCCMPN_Compania = .pCCMPN_Compania
                    oTemp2.pCDVSN_Division = .pCDVSN_Division
                    oTemp2.pCPLNDV_Planta = .pCPLNDV_Planta
                    dgBultos.pActualizar(oTemp2)
            End Select
        End With
    End Sub

    Private Function pGrabarBultos(ByVal intNroOperInicial As Int64) As Boolean
        Dim blnResultado As Boolean = True
        If dgBultos.pRowsCount > 0 And TD_InfServF01.pNOPRCN_Operacion <> 0 Then
            Dim oDetalleTemp As TD_Inf_Servicio_Bulto_F01
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dgBultos.pListaServiciosREG.Count > 0 Then
                Dim oDetalle As TD_Servicio_Detalle_I01
                For Each oDetalleTemp In dgBultos.pListaServiciosREG
                    oDetalle = New TD_Servicio_Detalle_I01
                    With oDetalle
                        .pCCLNT_CodigoCliente = oDetalleTemp.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                        .pSTPODP_TipoSistAlm = TD_InfServF01.pSTPODP_TipoSistAlm
                        .pCREFFW_CodigoBulto = oDetalleTemp.pCREFFW_CodigoBulto
                        .pCCMPN_Compania = TD_InfServF01.pCCMPN_Compania
                        .pCDVSN_Division = TD_InfServF01.pCDVSN_Division
                        .pCPLNDV_Planta = TD_InfServF01.pCPLNDV_Planta
                    End With
                    If Not cServicios.AgregarDetalleServicio(objSqlManager, oDetalle, TD_InfServF01.pUsuario, strMensajeError) Then
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        blnResultado = False
                        Exit For
                    End If
                Next
            End If
            '---------------------------------------------
            ' Rutinas para eliminar los servicios
            '---------------------------------------------
            ' Solo eliminamos item si existía antes, no cuando es nuevo
            If blnResultado And intNroOperInicial <> 0 Then
                If dgBultos.pListaServiciosDEL.Count > 0 Then
                    Dim oDetalle As TD_Servicio_Detalle_E01
                    For Each oDetalleTemp In dgBultos.pListaServiciosDEL
                        oDetalle = New TD_Servicio_Detalle_E01
                        With oDetalle
                            .pCCLNT_CodigoCliente = oDetalleTemp.pCCLNT_CodigoCliente
                            .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                            .pSTPODP_TipoSistAlm = TD_InfServF01.pSTPODP_TipoSistAlm
                            .pCREFFW_CodigoBulto = oDetalleTemp.pCREFFW_CodigoBulto
                        End With
                        If Not cServicios.EliminarDetalleServicio(objSqlManager, oDetalle, TD_InfServF01.pUsuario, strMensajeError) Then
                            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            blnResultado = False
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
        Return blnResultado
    End Function

    Private Function pGrabarMercaderias(ByVal intNroOperInicial As Int64) As Boolean
        Dim blnResultado As Boolean = True
        If dgMercaderias.pRowsCount > 0 And TD_InfServF01.pNOPRCN_Operacion <> 0 Then
            Dim oDetalleTemp As TD_Inf_Servicio_Mercaderia_F01
            '---------------------------------------------
            ' Rutinas para registrar todos los Bultos
            '---------------------------------------------
            If dgMercaderias.pListaServiciosREG.Count > 0 Then
                Dim oDetalle As TD_Servicio_Detalle_I01
                For Each oDetalleTemp In dgMercaderias.pListaServiciosREG
                    oDetalle = New TD_Servicio_Detalle_I01
                    With oDetalle
                        .pCCLNT_CodigoCliente = oDetalleTemp.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                        .pSTPODP_TipoSistAlm = TD_InfServF01.pSTPODP_TipoSistAlm
                        .pNORDSR_OrdenServicio = oDetalleTemp.pNORDSR_OrdenServicio
                        .pNSLCSR_NroSolicitud = oDetalleTemp.pNSLCSR_NroSolicitud
                    End With
                    If Not cServicios.AgregarDetalleServicio(objSqlManager, oDetalle, TD_InfServF01.pUsuario, strMensajeError) Then
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        blnResultado = False
                        Exit For
                    End If
                Next
            End If
            '---------------------------------------------
            ' Rutinas para eliminar los servicios
            '---------------------------------------------
            If blnResultado And intNroOperInicial <> 0 And blnResultado Then ' Solo eliminamos item si existía antes, no cuando es nuevo
                If dgMercaderias.pListaServiciosDEL.Count > 0 Then
                    Dim oDetalle As TD_Servicio_Detalle_E01
                    For Each oDetalleTemp In dgMercaderias.pListaServiciosDEL
                        oDetalle = New TD_Servicio_Detalle_E01
                        With oDetalle
                            .pCCLNT_CodigoCliente = oDetalleTemp.pCCLNT_CodigoCliente
                            .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                            .pSTPODP_TipoSistAlm = TD_InfServF01.pSTPODP_TipoSistAlm
                            .pNORDSR_OrdenServicio = oDetalleTemp.pNORDSR_OrdenServicio
                            .pNSLCSR_NroSolicitud = oDetalleTemp.pNSLCSR_NroSolicitud
                        End With
                        If Not cServicios.EliminarDetalleServicio(objSqlManager, oDetalle, TD_InfServF01.pUsuario, strMensajeError) Then
                            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            blnResultado = False
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
        Return blnResultado
    End Function
#End Region
#Region " Eventos "
    Sub New(ByVal value As TD_Inf_Servicio_F01)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Call pCargarInfInicial(value)
    End Sub

    Sub New(ByVal value As TD_Inf_Servicio_F01, ByVal dtPlantasUsuario As DataTable)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        If dtPlantasUsuario.Rows.Count > 0 Then
            Dim rwTemp As DataRow
            cbxPlanta.Items.Clear()
            lstIndexCbx.Clear()
            For Each rwTemp In dtPlantasUsuario.Rows
                cbxPlanta.Items.Add(rwTemp("CPLNDV") & " - " & rwTemp("TPLNTA").ToString.Trim)
                lstIndexCbx.Add(rwTemp("CPLNDV"))
            Next
            If lstIndexCbx.Count > 0 Then
                cbxPlanta.SelectedIndex = 0
                value.pCPLNDV_Planta = lstIndexCbx.Item(cbxPlanta.SelectedIndex)
            End If
            ' Mostramos el Combox y Cargamos la información 
            lblPlanta.Visible = True
            cbxPlanta.Visible = True
            Call pCargarInfInicial(value)
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        bStatusOperacion = False
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        '---------------------------------------------
        ' Rutinas de Validación
        '---------------------------------------------
        If dgServicios.pRowsCount <= 0 Then
            MessageBox.Show("Debe seleccionar por lo menos un servicio.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TD_InfServF01.pCPLNDV_Planta = 0 Then
            MessageBox.Show("El usuario no tiene ninguna planta asociada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '---------------------------------------------
        ' Variables de Trabajo
        '---------------------------------------------
        Dim oTemp As TD_Inf_Servicio_Adquiridos_F01
        Dim intNroOperInicial As Int64 = TD_InfServF01.pNOPRCN_Operacion
        '---------------------------------------------
        ' Rutinas para registrar todos los servicios
        '---------------------------------------------
        If dgServicios.pListaServiciosREG.Count > 0 Then
            ' Registramos cada uno de los Servicios Asociados
            Dim oServAdqu As TD_Servicio_Adquirido
            Dim intNroOperacion As Int64 = 0
            ' Recorremos cada uno de los servicios seleccionados
            For Each oTemp In dgServicios.pListaServiciosREG
                oServAdqu = New TD_Servicio_Adquirido
                With oServAdqu
                    .pCCMPN_Compania = TD_InfServF01.pCCMPN_Compania
                    .pCDVSN_Division = TD_InfServF01.pCDVSN_Division
                    .pCCLNT_CodigoCliente = TD_InfServF01.pCCLNT_CodigoCliente
                    .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                    .pFOPRCN_FechaOperacion = dteFechaOperacion.Value
                    .pFECINI_Inicio = dtpFechaInicial.Value
                    .pFECFIN_Final = dtpFechaFinal.Value
                    .pNRTFSV_Tarifa_Servicio = oTemp.pNRTFSV_Tarifa
                    .pQCNESP_Cantidad_Base = oTemp.pQCNESP_CantBase
                    .pTUNDIT_Unidad = oTemp.pTUNDIT_Unidad
                    .pQATNAN_CantAtendida = oTemp.pQATNAN_CantAtendida
                    .pCCLNFC_ClienteFacturar = txtClienteFacturar.pCodigo
                    .pSTPODP_TipoSistAlm = TD_InfServF01.pSTPODP_TipoSistAlm
                    .pSTIPPR_Proceso = txtTipoProceso.pInformacionSelec.pCCMPRN_Codigo
                    .pCPRCN1_Contenedor = txtCodigoContenedor.Text
                    .pNSRCN1_SerieContenedor = txtSerieContenedor.Text
                    ' Rutina para registrar servicio
                    If cServicios.AgregarServicioAdquirido(objSqlManager, oServAdqu, TD_InfServF01.pUsuario, intNroOperacion, strMensajeError) Then
                        If TD_InfServF01.pNOPRCN_Operacion = 0 Then
                            TD_InfServF01.pNOPRCN_Operacion = intNroOperacion
                            txtNroOperacion.Text = intNroOperacion
                        End If
                    Else
                        MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End With
            Next
        End If
        If dgServicios.pListaServiciosREG.Count = 0 And dgServicios.pRowsCount > 1 Then
            ' Si no se agregó o modificó algún registro, se procede a actualizar la información general
            Dim oTempCab As TD_Servicio_Adquirido_InfGen = New TD_Servicio_Adquirido_InfGen
            With oTempCab
                .pCCLNT_CodigoCliente = TD_InfServF01.pCCLNT_CodigoCliente
                .pNOPRCN_Operacion = txtNroOperacion.Text
                .pFECINI_Inicio = dtpFechaInicial.Value
                .pFECFIN_Final = dtpFechaFinal.Value
                .pCCLNFC_ClienteFacturar = txtClienteFacturar.pCodigo
                .pSTIPPR_Proceso = txtTipoProceso.pInformacionSelec.pCCMPRN_Codigo
                .pCPRCN1_Contenedor = txtCodigoContenedor.Text
                .pNSRCN1_SerieContenedor = txtSerieContenedor.Text
            End With
            ' Rutina para registrar servicio
            If Not cServicios.EditarServicioAdquirido(objSqlManager, oTempCab, TD_InfServF01.pUsuario, strMensajeError) Then
                MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '---------------------------------------------
        ' Rutinas para eliminar los servicios
        '---------------------------------------------
        ' Solo eliminamos item solo si existía antes, no cuando es nuevo
        If intNroOperInicial <> 0 Then
            If dgServicios.pListaServiciosDEL.Count > 0 Then
                Dim oServAdquPK As TD_Servicio_AdquiridoPK
                Dim strStatus As String = ""
                For Each oTemp In dgServicios.pListaServiciosDEL
                    oServAdquPK = New TD_Servicio_AdquiridoPK
                    With oServAdquPK
                        .pCCLNT_CodigoCliente = TD_InfServF01.pCCLNT_CodigoCliente
                        .pNOPRCN_Operacion = TD_InfServF01.pNOPRCN_Operacion
                        .pNRTFSV_Tarifa_Servicio = oTemp.pNRTFSV_Tarifa
                        If cServicios.EliminarServicioAdquirido(objSqlManager, oServAdquPK, TD_InfServF01.pUsuario, strStatus, strMensajeError) Then
                            If strStatus = "S" Then MessageBox.Show("Toda la información asociada a la Operación, fue eliminada.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End With
                Next
            End If
        End If
        '---------------------------------------------
        ' Rutinas para la Gestion de Detalle
        '---------------------------------------------
        ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
        Dim bStatusSalir As Boolean
        Select Case TD_InfServF01.pSTPODP_TipoSistAlm
            Case "1"
                bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            Case "5"
                bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            Case "7"
                bStatusSalir = pGrabarBultos(intNroOperInicial)
        End Select
        If bStatusSalir Then
            MessageBox.Show("Proceso culminó satisfactoriamente.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bStatusOperacion = True
            Me.Close()
        End If
    End Sub

    Private Sub cbxPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxPlanta.SelectedIndexChanged
        If cbxPlanta.Visible Then
            TD_InfServF01.pCPLNDV_Planta = lstIndexCbx.Item(cbxPlanta.SelectedIndex)
            Call pActualizarServicios()
        End If
    End Sub

    Private Sub ucServicios_FServF01_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent pDisposeForm(bStatusOperacion)
    End Sub

    Private Sub ucServicios_FServF01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager
        Select Case TD_InfServF01.pSTPODP_TipoSistAlm
            Case "1"
                dgBultos.Visible = False
                dgMercaderias.Top = 328
                dgMercaderias.Left = 12
                dgMercaderias.Width = dgServicios.Width
            Case "5"
                dgBultos.Visible = False
                dgMercaderias.Top = 328
                dgMercaderias.Left = 12
                dgMercaderias.Width = dgServicios.Width
            Case "7"
                dgMercaderias.Visible = False
                dgBultos.Top = 328
                dgBultos.Left = 12
                dgBultos.Width = dgServicios.Width
        End Select
        Call pCargaInformacion()
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class