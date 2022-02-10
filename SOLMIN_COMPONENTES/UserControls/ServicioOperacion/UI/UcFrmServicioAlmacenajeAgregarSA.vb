Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Web
Public Class UcFrmServicioAlmacenajeAgregarSA
    Private dblFecha As Double
    Private oPlantaNeg As clsPlantaNeg
    Private oServicio As Servicio_BE
    Private oServicioSILNeg As clsServicio_BL
    Private bolBuscar As Boolean
    Private dtResultado As New DataTable
    Private blnCargando As Boolean
    Private intFilaActual As Int32 = 0

    Public Sub New(ByVal poServicioAlmacen As Servicio_BE)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oServicioSILNeg = New clsServicio_BL
        oServicio = New Servicio_BE
        oServicio = poServicioAlmacen

    End Sub
    Private Sub frmServicioV2AgregarSA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oPlantaNeg = New clsPlantaNeg
        oPlantaNeg.Crea_Lista(ConfigurationWizard.UserName)
        oPlantaNeg.Lista = oPlantaNeg.Lista.Copy
        cargarPlanta()
        cargaProceso()
        ValidarModificar()
        cargarCliente()
        cargarCampos()
    End Sub

    Private Sub ValidarModificar()
        If oServicio.TIPO = "M" Then
            Me.cmbPlanta.Enabled = False
            Me.UcClienteOperacion.Enabled = False
            dteFechaOperacion.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    
    Private Sub cmbRubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRubro.SelectedIndexChanged
        If bolBuscar Then
            cargarServicio()
        End If
    End Sub

    Private Sub dtpFinPeriodoFacturar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFinPeriodoFacturar.Validating

        If Me.dtpFinPeriodoFacturar.Value.Date < Me.dtpInicioPeriodoFacturar.Value.Date Then
            MsgBox("El periodo de facturación final no puede ser menor que el periodo de facturación inicial", MsgBoxStyle.Information, "Información")
            e.Cancel = True
        End If
    End Sub

    Private Sub dtpInicioPeriodoFacturar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpInicioPeriodoFacturar.Validating
        If Me.dtpFinPeriodoFacturar.Value.Date < Me.dtpInicioPeriodoFacturar.Value.Date Then
            MsgBox("El periodo de facturación inicial no puede ser mayo al periodo de facturación final", MsgBoxStyle.Information, "Información")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtClienteFacturar_InformationChanged() Handles txtClienteFacturar.InformationChanged
        oServicio.CCLNFC = txtClienteFacturar.pCodigo
    End Sub


#Region "Carga Inicial"
    Private Sub cargarCampos()
        If oServicio.TIPO <> "M" Then Exit Sub
        dteFechaOperacion.Enabled = False
        cmbTipoAlmacen.Enabled = False
        'txtNroOperacion.Text = oServicio.NOPRCN
        'Me.hgTitulo.ValuesPrimary.Heading = "Nro. Operación " & oServicio.NOPRCN.ToString
        dteFechaOperacion.Text = Comun.FormatoFecha(oServicio.FOPRCN)
        cargarTarifaServicio()
    End Sub

    Private Sub cargarTarifaServicio()
        Dim oDt As New DataTable
        Dim oDs As New DataSet
        oDs = oServicioSILNeg.fdtObtenerServiciosFacturacionSA(oServicio)
        If oDs.Tables.Count > 0 Then
            oDt = oDs.Tables(0).Copy
            oServicio.NOPRCN = oDt.Rows(0).Item("NOPRCN")
            oServicio.NRTFSV = oDs.Tables(1).Rows(0).Item("NRTFSV")
            Me.cmbPlanta.SelectedValue = oServicio.CPLNDV
            Me.cmbRubro.SelectedValue = oDs.Tables(1).Rows(0).Item("NRRUBR")
            cmbTipoAlmacen.SelectedValue = oDt.Rows(0).Item("CTPALJ")
            Me.cmbServicios.SelectedValue = oServicio.NRTFSV
            oServicio.TAG = "R"
            Me.dtpInicioPeriodoFacturar.Value = IIf(oDs.Tables(1).Rows(0).Item("FINPRF") Is DBNull.Value, Now, oDs.Tables(1).Rows(0).Item("FINPRF"))
            Me.dtpFinPeriodoFacturar.Value = IIf(oDs.Tables(1).Rows(0).Item("FFNPRF") Is DBNull.Value, Now, oDs.Tables(1).Rows(0).Item("FFNPRF"))
            Me.dteFechaOperacion.Value = IIf(oDt.Rows(0).Item("FOPRCN") Is DBNull.Value, Now, oDt.Rows(0).Item("FOPRCN"))
        End If
    End Sub

    Private Sub cargarCliente()
        Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(oServicio.CCLNT, ConfigurationWizard.UserName)
        UcClienteOperacion.pCargar(ClientePK)
        ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(oServicio.CCLNFC, ConfigurationWizard.UserName)
        txtClienteFacturar.pCargar(ClientePK)
    End Sub

    Private Sub cargarPlanta()
        bolBuscar = False
        cmbPlanta.DataSource = oPlantaNeg.Lista_Planta(oServicio.CCMPN, oServicio.CDVSN)
        cmbPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        If oServicio.CPLNDV <> 0 Then
            cmbPlanta.SelectedValue = oServicio.CPLNDV
        Else
            cmbPlanta.SelectedValue = 1
        End If
        cmbPlanta.DisplayMember = "TPLNTA"
        bolBuscar = True
    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar Then
            cargarRubro()
        End If
    End Sub

    Private Sub cargarRubro()
        oServicio.CPLNDV = cmbPlanta.SelectedValue
        oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        bolBuscar = False
        dtResultado = oServicioSILNeg.fdtListaRubroXCompaniaDivision(oServicio)
        dtResultado.DefaultView.RowFilter = "NRRUBR <> '7'"
        dtResultado = dtResultado.DefaultView.ToTable
        cmbRubro.ComboBox.DataSource = dtResultado
        cmbRubro.ComboBox.ValueMember = "NRRUBR"
        bolBuscar = True
        cmbRubro.ComboBox.DisplayMember = "NOMRUB"
    End Sub

    Private Sub cargarServicio()
        oServicio.CPLNDV = cmbPlanta.SelectedValue
        oServicio.NRRUBR = Me.cmbRubro.SelectedValue
        oServicio.FOPRCN = Format(dteFechaOperacion.Value, "yyyyMMdd")
        bolBuscar = False
        dtResultado = oServicioSILNeg.Cargar_Servicios_Tarifa_Cliente(oServicio)
        cmbServicios.ComboBox.DataSource = dtResultado
        cmbServicios.ComboBox.ValueMember = "NRTFSV"
        bolBuscar = True
        cmbServicios.ComboBox.DisplayMember = "DESTAR"
        cmbServicios_SelectionChangeCommitted(Nothing, Nothing)
    End Sub

 

    Private Sub CargaProceso()
        cmbTipoAlmacen.DataSource = oServicioSILNeg.Listar_TablaAyuda_L01("TIPFAL")
        cmbTipoAlmacen.ValueMember = "CCMPRN"
        cmbTipoAlmacen.DisplayMember = "TDSDES"
        If oServicio.STIPPR <> "" Then
            cmbTipoAlmacen.SelectedValue = oServicio.STIPPR
        End If

    End Sub

#End Region



#Region "Guardar Servicio"

    Private Function fblnValidar() As Boolean
        Dim strErrr As String = ""
        If Me.cmbPlanta.SelectedValue Is Nothing Then
            strErrr = strErrr & "- Seleccione planta" & Chr(10)
        End If
        If Me.cmbServicios.SelectedValue Is Nothing Then
            strErrr = strErrr & "- Seleccione servicio" & Chr(10)
        End If
        If Me.UcClienteOperacion.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione Cliente " & Chr(10)
        End If
        If Me.txtClienteFacturar.pCodigo = 0 Then
            strErrr = strErrr & "- Seleccione Cliente a Facturar" & Chr(10)
        End If

        If strErrr.Trim.Equals("") Then
            Return True
        Else
            MessageBox.Show(strErrr, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' Rutinas de Validación
        ' Variables de Trabajo
        ' Rutinas de Validación
        If Not fblnValidar() Then
            Exit Sub
        End If
        '---------------------------------------------

        ' Rutinas para registrar todos los servicios
        '---------------------------------------------
        'Limpiamos el Variable

        ' Registramos cada uno de los Servicios Asociados
        Dim intNroOperacion As Int64 = 0
        ' Recorremos cada uno de los servicios seleccionados

        With oServicio
            .CCLNT = UcClienteOperacion.pCodigo
            .FOPRCN = Comun.FormatoFechaAS400(dteFechaOperacion.Text)
            .CCLNFC = txtClienteFacturar.pCodigo
            .CPLNDV = Me.cmbPlanta.SelectedValue
            .STPODP = oServicio.STPODP
            .CTPALJ = cmbTipoAlmacen.SelectedValue
            .STIPPR = "A"
            If .NOPRCN = 0 Then
                .TIPO = "N"
                .NOPRCN = oServicioSILNeg.fdecInsertarOperacionFacturacionSA(oServicio)
                If .NOPRCN <> 0 Then
                    Me.hgTitulo.ValuesPrimary.Heading = "Nr. Operacion : " & oServicio.NOPRCN.ToString
                Else
                    MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Information, "Validación")
                    Exit Sub
                End If
            Else
                oServicio.SESTRG = "A"
                If oServicioSILNeg.fdecActualizarOperacionFacturacionSA(oServicio) = 0 Then
                    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                End If
            End If
        End With

        With oServicio
            .FOPRCN = Comun.FormatoFechaAS400(dteFechaOperacion.Text)
            .NRTFSV = Me.cmbServicios.SelectedValue
            .QATNAN = 1
            .CPLNDV = Me.cmbPlanta.SelectedValue
            .STPODP = oServicio.STPODP
            .CTPALJ = cmbTipoAlmacen.SelectedValue
            .STIPPR = "A"
            .NCRROP = 1
            .FINPRF = Comun.FormatoFechaAS400(dtpInicioPeriodoFacturar.Value.Date)
            .FFNPRF = Comun.FormatoFechaAS400(dtpFinPeriodoFacturar.Value.Date)
            'Rutina para registrar servicio '=========intNroOperacion SE DEBE QUITAR
            If oServicio.TAG <> "R" Then
                oServicio.TAG = "N"

                Dim msgserv As String = ""
                Dim corr_servicio As Decimal = 0

                msgserv = oServicioSILNeg.fdecInsertarServiciosFacturacionSA(oServicio, corr_servicio)
                .NCRROP = corr_servicio
                '.NCRROP = oServicioSILNeg.fdecInsertarServiciosFacturacionSA(oServicio)
                If .NCRROP <> 0 Then
                    Me.hgTitulo.ValuesPrimary.Heading = "Nr. Operacion : " & oServicio.NOPRCN.ToString
                Else
                    'MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Error)
                    MessageBox.Show(msgserv, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                oServicio.TAG = "R"
                Dim mssgUpd As String = ""

                mssgUpd = oServicioSILNeg.fintActualizarServiciosFacturacionSA(oServicio)

                If mssgUpd.Length > 0 Then
                    MessageBox.Show(mssgUpd, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                'If oServicioSILNeg.fintActualizarServiciosFacturacionSA(oServicio) = 0 Then
                '    MsgBox("Error Comuniquese con el departamento de sistemas", MessageBoxIcon.Error)
                'End If

            End If
        End With
        '---------------------------------------------
        ' Rutinas para la Gestion de Detalle
        '---------------------------------------------
        ' Bloqueamos la salida hasta que se guarde toda la información sin problemas
        Dim bStatusSalir As Boolean
        Select Case oServicio.STPODP
            'Case "1"
            '    bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            'Case "5"
            '    bStatusSalir = pGrabarMercaderias(intNroOperInicial)
            Case "7"
                bStatusSalir = GrabarBultos()
        End Select
        If bStatusSalir Then
            MsgBox(Comun.Mensaje("MENSAJE.EXITO") & Chr(10) & " Nr. Operación: " & oServicio.NOPRCN.ToString, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub


    Private Function GrabarBultos() As Boolean
        Dim blnResultado As Boolean = True

        If oServicio.TAG = "N" Then
            If oServicioSILNeg.fintInsertarServiciosFacturacionAlmacenajeSA(oServicio) = 0 Then
                MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Error)
            End If
        Else
            If oServicioSILNeg.fintActulizarServiciosFacturacionAlmacenajeSA(oServicio) = 0 Then
                MsgBox(Comun.Mensaje("MENSAJE.ERROR"), MessageBoxIcon.Error)
            End If
        End If


        Return blnResultado
    End Function

    Private Sub UcClienteOperacion_InformationChanged() Handles UcClienteOperacion.InformationChanged
        oServicio.CCLNT = UcClienteOperacion.pCodigo
        If (UcClienteOperacion.pCodigo <> 0) Then
            cargarServicio()
            Dim ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(UcClienteOperacion.pCodigo, ConfigurationWizard.UserName)
            txtClienteFacturar.pCargar(ClientePK)
            oServicio.CCLNFC = UcClienteOperacion.pCodigo
        End If
    End Sub


    'Private Sub cmbServicios_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbServicios.SelectedIndexChanged
    '    txtCentroCosto.Clear()
    '    txtMoneda.Clear()
    '    txtTarifaAplicar.Clear()
    '    txtValor.Clear()
    '    txtValorServicio.Clear()
    '    txtUnidadMedida.Clear()
    '    If bolBuscar Then
    '        If (Not cmbServicios.SelectedValue Is Nothing) Then
    '            Dim odtTarifa As New DataTable
    '            Dim obrclsServicioSC_BL As New clsServicioSC_BL
    '            odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(cmbServicios.SelectedValue)
    '            If (odtTarifa.Rows.Count > 0) Then
    '                txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
    '                txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
    '                txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA").ToString.Trim
    '                txtValor.Text = odtTarifa.Rows(0)("VALCTE").ToString.Trim
    '                txtValorServicio.Text = odtTarifa.Rows(0)("IVLSRV").ToString.Trim
    '                txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
    '            End If
    '        End If
    '    End If
    'End Sub



#End Region


 
 
    
    Private Sub cmbServicios_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbServicios.SelectionChangeCommitted
        txtCentroCosto.Clear()
        txtMoneda.Clear()
        txtTarifaAplicar.Clear()
        txtValor.Clear()
        txtValorServicio.Clear()
        txtUnidadMedida.Clear()
        If bolBuscar Then
            If (Not cmbServicios.SelectedValue Is Nothing) Then
                Dim odtTarifa As New DataTable
                Dim obrclsServicioSC_BL As New clsServicioSC_BL
                odtTarifa = obrclsServicioSC_BL.Lista_Datos_Tarifa(cmbServicios.SelectedValue)
                If (odtTarifa.Rows.Count > 0) Then
                    txtCentroCosto.Text = odtTarifa.Rows(0)("CCNTCS").ToString.Trim & "-" & odtTarifa.Rows(0)("TCNTCS").ToString.Trim
                    txtMoneda.Text = odtTarifa.Rows(0)("TSGNMN").ToString.Trim
                    txtTarifaAplicar.Text = odtTarifa.Rows(0)("STPTRA").ToString.Trim
                    txtValor.Text = odtTarifa.Rows(0)("VALCTE").ToString.Trim
                    txtValorServicio.Text = odtTarifa.Rows(0)("IVLSRV").ToString.Trim
                    txtUnidadMedida.Text = odtTarifa.Rows(0)("CUNDMD").ToString.Trim
                End If
            End If
        End If
    End Sub
End Class
