
Imports Ransa.TypeDef.OrdenServicio
Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.Mercaderia
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS

Public Class frmMantenimientoSDS
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region " Atributos "
    Private booStatus As Boolean = False
#End Region
#Region " Propiedades "

#End Region
#Region " Procedimientos y Funciones "
    Private Sub pActualizarInformacion(ByVal intNivelActualizacion As Integer)
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False
            '-- Cargamos las Familias
            If intNivelActualizacion <= 0 Then Call pListarFamilia()
            ' Cargamos los Grupos
            If intNivelActualizacion <= 1 Then Call pListarGrupos()
            ' Cargamos las Mercaderías
            If intNivelActualizacion <= 2 Then Call pListarMercaderia()
            booStatus = True
            '-- Registro los nuevos valores de los campos de los clientes
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("MANSDS_ClienteCodigo", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Public Sub pCargarOrdServPorMercaderia()
        With dgMercaderia.pMercaderiaSeleccionada
            If .pCMRCLR_Mercaderia <> dgOrdenServicio.pCurrentOrdServ.pCMRCLR_Mercaderia Then
                'Dim oQry_OrdServ As TD_Qry_LstOrdenServPorMercaderia_F01 = New TD_Qry_LstOrdenServPorMercaderia_F01()
                Dim oQry_OrdServ As Ransa.Controls.OrdenServicio.TD_Qry_LstOrdenServPorMercaderia_F01 = New Ransa.Controls.OrdenServicio.TD_Qry_LstOrdenServPorMercaderia_F01()
                oQry_OrdServ.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
                oQry_OrdServ.pCMRCLR_Mercaderia = .pCMRCLR_Mercaderia
                oQry_OrdServ.pCTPDPS_TipoDeposito = objSeguridadBN.pstrTipoAlmacen
                oQry_OrdServ.pNTRMNL_NombreTerminal = objSeguridadBN.pstrPCName
                oQry_OrdServ.pUsuario = objSeguridadBN.pUsuario
                dgOrdenServicio.pCargar(oQry_OrdServ)
            End If
        End With
    End Sub

    Public Sub pCargarSolicOrdServ()
        With dgOrdenServicio.pCurrentOrdServ
            'Dim oQry_SolicOrdServ As TD_Qry_LstSolicOrdenServ_F01 = New TD_Qry_LstSolicOrdenServ_F01
            Dim oQry_SolicOrdServ As Ransa.Controls.OrdenServicio.TD_Qry_LstSolicOrdenServ_F01 = New Ransa.Controls.OrdenServicio.TD_Qry_LstSolicOrdenServ_F01
            oQry_SolicOrdServ.pCCLNT_CodigoCliente = .pCCLNT_CodigoCliente
            oQry_SolicOrdServ.pCMRCLR_Mercaderia = .pCMRCLR_Mercaderia
            oQry_SolicOrdServ.pCTPDPS_TipoDeposito = .pCTPDPS_TipoDeposito
            oQry_SolicOrdServ.pNORDSR_OrdenServicio = .pNORDSR_OrdenServicio
            oQry_SolicOrdServ.pNTRMNL_NombreTerminal = objSeguridadBN.pstrPCName
            oQry_SolicOrdServ.pUsuario = objSeguridadBN.pUsuario
            dgSolicOrdenServicio.pCargar(oQry_SolicOrdServ)
        End With
    End Sub

    Private Sub pListarFamilia()
        dgFamilias.DataSource = mfdtListar_SDSFamilias(txtCliente.pCodigo)
    End Sub

    Private Sub pListarGrupos()
        If dgFamilias.RowCount = 0 Or dgFamilias.CurrentRow Is Nothing Then
            dgGrupos.DataSource = Nothing
            Exit Sub
        End If
        dgGrupos.DataSource = mfdtListar_SDSGrupos(txtCliente.pCodigo, dgFamilias.CurrentRow.Cells("F_CFMCLR").Value)
    End Sub

    Private Sub pListarMercaderia()
        If dgGrupos.RowCount = 0 Or dgGrupos.CurrentRow Is Nothing Then
            dgMercaderia.pClear()
            Exit Sub
        End If
        tcMercaderia.SelectedIndex = 0
        'Dim oTemp As TD_Qry_Mercaderia_L01 = New TD_Qry_Mercaderia_L01
        Dim oTemp As Ransa.Controls.Mercaderia.TD_Qry_Mercaderia_L01 = New Ransa.Controls.Mercaderia.TD_Qry_Mercaderia_L01
        With oTemp
            .pCCLNT_CodigoCliente = txtCliente.pCodigo
            .pCFMCLR_Familia = dgFamilias.CurrentRow.Cells("F_CFMCLR").Value
            .pCGRCLR_Grupo = dgGrupos.CurrentRow.Cells("G_CGRCLR").Value
            .pUsuario = objSeguridadBN.pUsuario
        End With
        dgMercaderia.pActualizar(oTemp)
    End Sub

    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
    Private Sub bsaAdministrarFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAdministrarFamilia.Click
        If txtCliente.pCodigo <> 0 Then
            Dim fFamiliaSDS As frmFamiliaSDS = New frmFamiliaSDS
            With fFamiliaSDS
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pActualizarInformacion(0)
                End If
                .Dispose()
                fFamiliaSDS = Nothing
            End With
        End If
    End Sub

    Private Sub bsaAdministrarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAdministrarGrupo.Click
        If Me.dgFamilias.RowCount > 0 Then
            Dim fGrupoSDS As frmGrupoSDS = New frmGrupoSDS
            With fGrupoSDS
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                .pstrCodigoFamilia_CFMCLR = dgFamilias.CurrentRow.Cells("F_CFMCLR").Value.ToString.Trim
                .pstrDescripcionFamilia_TFMCLR = dgFamilias.CurrentRow.Cells("F_TFMCLR").Value.ToString.Trim
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pActualizarInformacion(1)
                End If
                .Dispose()
                fGrupoSDS = Nothing
            End With
        End If
    End Sub

    Private Sub dgMercaderia_Add() Handles dgMercaderia.Add
        If dgGrupos.RowCount > 0 Then
            Dim fMercaderiaSDS As frmMercaderiaSDS = New frmMercaderiaSDS
            With fMercaderiaSDS
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                .pstrCodigoFamilia_CFMCLR = dgFamilias.CurrentRow.Cells("F_CFMCLR").Value.ToString.Trim
                .pstrDescripcionFamilia_TFMCLR = dgFamilias.CurrentRow.Cells("F_TFMCLR").Value.ToString.Trim
                .pstrCodigoGrupo_CGRCLR = dgGrupos.CurrentRow.Cells("G_CGRCLR").Value.ToString.Trim
                .pstrDescripcionGrupo_TGRCLR = dgGrupos.CurrentRow.Cells("G_TGRCLR").Value.ToString.Trim
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pListarMercaderia()
                End If
                .Dispose()
                fMercaderiaSDS = Nothing
            End With
        End If
    End Sub

    'Private Sub dgMercaderia_Edit(ByVal Mercaderia As TD_Inf_Mercaderia_L01) Handles dgMercaderia.Edit
    Private Sub dgMercaderia_Edit(ByVal Mercaderia As Ransa.Controls.Mercaderia.TD_Inf_Mercaderia_L01) Handles dgMercaderia.Edit
        If dgMercaderia.pMercaderiaSeleccionada.pCMRCLR_Mercaderia <> "" Then
            Dim fMercaderia As frmMercaderiaSDS = New frmMercaderiaSDS
            With fMercaderia
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                .pstrCodigoFamilia_CFMCLR = dgFamilias.CurrentRow.Cells("F_CFMCLR").Value.ToString.Trim
                .pstrDescripcionFamilia_TFMCLR = dgFamilias.CurrentRow.Cells("F_TFMCLR").Value.ToString.Trim
                .pstrCodigoGrupo_CGRCLR = dgGrupos.CurrentRow.Cells("G_CGRCLR").Value.ToString.Trim
                .pstrDescripcionGrupo_TGRCLR = dgGrupos.CurrentRow.Cells("G_TGRCLR").Value.ToString.Trim
                .pstrCodigoMercaderia_CMRCLR = dgMercaderia.pMercaderiaSeleccionada.pCMRCLR_Mercaderia
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pActualizarInformacion(2)
                End If
            End With
        End If
    End Sub

    Private Sub dgMercaderia_ErrorMessage(ByVal ErrorMsg As String) Handles dgMercaderia.ErrorMessage
        MessageBox.Show(ErrorMsg, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgMercaderia_ImprimirReporte(ByVal Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument) Handles dgMercaderia.ImprimirReporte
        Dim fVisorRPT As frmVisorRPT = New frmVisorRPT(Reporte)
        fVisorRPT.ShowDialog()
        fVisorRPT.Dispose()
        fVisorRPT = Nothing
    End Sub

    Private Sub dgMercaderia_Message(ByVal Mensaje As String) Handles dgMercaderia.Message
        MessageBox.Show(Mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgMercaderia_TableWithOutData() Handles dgMercaderia.TableWithOutData
        dgOrdenServicio.pClear()
    End Sub

    'Private Sub dgOrdenServicio_CurrentRowChanged(ByVal OrdServSelec As Ransa.TYPEDEF.OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01) Handles dgOrdenServicio.CurrentRowChanged
    '    Call pCargarSolicOrdServ()
    'End Sub
    Private Sub dgOrdenServicio_CurrentRowChanged(ByVal OrdServSelec As Ransa.Controls.OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01) Handles dgOrdenServicio.CurrentRowChanged
        Call pCargarSolicOrdServ()
    End Sub

    'Private Sub dgOrdenServicio_DataLoadCompleted(ByVal OrdServSelec As Ransa.TYPEDEF.OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01) Handles dgOrdenServicio.DataLoadCompleted
    '    Call pCargarSolicOrdServ()
    'End Sub
    Private Sub dgOrdenServicio_DataLoadCompleted(ByVal OrdServSelec As Ransa.Controls.OrdenServicio.TD_Inf_LstOrdenServPorMercaderia_F01) Handles dgOrdenServicio.DataLoadCompleted
        Call pCargarSolicOrdServ()
    End Sub

    Private Sub dgOrdenServicio_ErrorMessage(ByVal strMensaje As String) Handles dgOrdenServicio.ErrorMessage
        Call MessageError(strMensaje)
    End Sub

    Private Sub dgOrdenServicio_TableWithOutData() Handles dgOrdenServicio.TableWithOutData
        dgSolicOrdenServicio.pClear()
    End Sub

    Private Sub dgSolicOrdenServicio_AfterDelete() Handles dgSolicOrdenServicio.AfterDelete
        dgOrdenServicio.pRefrescar()
    End Sub

    Private Sub dgSolicOrdenServicio_ErrorMessage(ByVal strMensaje As String) Handles dgSolicOrdenServicio.ErrorMessage
        Call MessageError(strMensaje)
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion(0)
    End Sub

    Private Sub dgFamilias_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFamilias.CurrentCellChanged
        If booStatus Then
            booStatus = False
            ' Cargamos los Grupos
            Call pListarGrupos()
            ' Cargamos las Mercaderías
            Call pListarMercaderia()
            booStatus = True
        End If
    End Sub

    Private Sub dgGrupos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrupos.CurrentCellChanged
        If booStatus Then
            booStatus = False
            ' Cargamos las Mercaderías
            Call pListarMercaderia()
            booStatus = True
        End If
    End Sub

    Private Sub frmMantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0

            Int64.TryParse(objAppConfig.GetValue("MANSDS_ClienteCodigo", GetType(System.String)), intTemp)
            If intTemp <> 0 Then
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
                txtCliente.pCargar(ClientePK)
            End If
            txtCliente.pUsuario = objSeguridadBN.pUsuario
            dgMercaderia.pMostrarColFamilia = False
            dgMercaderia.pMostrarColGrupo = False
            dgMercaderia.pMostrarBotonBuscar = True
            objAppConfig = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tcMercaderia_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tcMercaderia.Selected
        Try
            If e.TabPageIndex = 1 Then
                Call pCargarOrdServPorMercaderia()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgFamilias.DataSource = Nothing
        dgGrupos.DataSource = Nothing
        dgMercaderia.pClear()
    End Sub

    Private Sub dgMercaderia_btnBuscar_Click() Handles dgMercaderia.Buscar
        Try
            If dgGrupos.RowCount = 0 Or dgGrupos.CurrentRow Is Nothing Then
                dgMercaderia.pClear()
                Exit Sub
            End If
            tcMercaderia.SelectedIndex = 0
            'Dim oTemp As TD_Qry_Mercaderia_L01 = New TD_Qry_Mercaderia_L01
            Dim oTemp As Ransa.Controls.Mercaderia.TD_Qry_Mercaderia_L01 = New Ransa.Controls.Mercaderia.TD_Qry_Mercaderia_L01
            With oTemp
                .pCCLNT_CodigoCliente = txtCliente.pCodigo
                .pCMRCLR_Mercaderia = dgMercaderia.pTextoBusqueda
                .pCFMCLR_Familia = dgFamilias.CurrentRow.Cells("F_CFMCLR").Value
                .pCGRCLR_Grupo = dgGrupos.CurrentRow.Cells("G_CGRCLR").Value
                .pUsuario = objSeguridadBN.pUsuario
            End With
            dgMercaderia.pActualizar(oTemp)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


#End Region
End Class