Imports SOLMIN_ST.ENTIDADES.mantenimientos
 
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmLiquidacionFlete_DlgAgregarServicio

#Region " Atributos "
 
    Private sDetalleServicio As String = ""
 
    Private oInfServicio As TD_Obj_GRemAgregarServCargadasGTranspLiq = New SOLMIN_ST.ENTIDADES.mantenimientos.TD_Obj_GRemAgregarServCargadasGTranspLiq
 
    Private strCompania As String = ""
    Private strDivision As String = ""
    Private lintMedioTransporte As Int32 = 0
    Private SESGRP As String = ""
    Private strTipoAdicionModif As String = ""
    Private _pModificarProv As Boolean = True
    Private _pModificarServ As Boolean = True
    Private _CRGVTA As String = ""   'ECM-HUNDRED-20150821
    Public pFlagTarifaOS As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pInformacionServicio() As TD_Obj_GRemAgregarServCargadasGTranspLiq
        Get
            Return oInfServicio
        End Get
    End Property

    Public ReadOnly Property pDetalleServicio() As String
        Get
            Return sDetalleServicio
        End Get
    End Property


    Public Property pModificarProv() As Boolean
        Get
            Return _pModificarProv
        End Get
        Set(ByVal value As Boolean)
            _pModificarProv = value
        End Set
    End Property
    Public Property pModificarServ() As Boolean
        Get
            Return _pModificarServ
        End Get
        Set(ByVal value As Boolean)
            _pModificarServ = value
        End Set
    End Property

    Private _PStatusTarInt As String
    Public Property PStatusTarInt() As String
        Get
            Return _PStatusTarInt
        End Get
        Set(ByVal value As String)
            _PStatusTarInt = value
        End Set
    End Property

    Private _PSStatusLiquidacion As String
    Public Property PSStatusLiquidacion() As String
        Get
            Return _PSStatusLiquidacion
        End Get
        Set(ByVal value As String)
            _PSStatusLiquidacion = value
        End Set
    End Property

    Public pbeAutorizacionLiq As New beAutorizacionLiquidacion

#End Region
#Region " Eventos "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then Exit Sub
            Dim strResultado As String = ""
            

            REM ECM-HUNDRED-INICIO
            Dim solicitudTransporte As New Operaciones.Solicitud_Transporte_BLL
            Dim operacion As Decimal = oInfServicio.pNOPRCN_NroOperacion
            Dim cod_servicioSAP As String = CType(cmbServicio.Resultado, ServicioLiquidacion).TSRVIN

            'ECM-ActualizacionTarifario[RF002]-160516
            Dim resultadoValidacion As String = solicitudTransporte.ValidarServicioSAP(operacion, oInfServicio.pCCMPN_Compania, _CRGVTA, cod_servicioSAP)
            If resultadoValidacion.Trim <> "" Then
                MessageBox.Show(resultadoValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            REM ECM-HUNDRED-FIN

            With oInfServicio
                .pNRUCTR_RucProveedor = cboProveedor.pRucTransportista
                .pCCMPN_Compania = strCompania
                .pCSRVC_Servicio = CType(cmbServicio.Resultado, ServicioLiquidacion).CSRVNV
                .pTRFSRG_RefrenciaServicioGuia = txtReferencia.Text
                .pCMNDGU_MonedaGuia = cboMoneda_2.SelectedValue
                .pISRVGU_importeServicio = txtImporte.Text
                .pQCNDTG_CantServicioGuia = txtCantidadServ.Text               
                .pCUNDSR_Unidad = CType(cboUnidad.Resultado, Ransa.Controls.Unidad.TD_Inf_Unidad_L02).pCUNDMD_Unidad

                If chkFacturacionCliente.CheckState = CheckState.Checked Then
                    .pSFCTTR_StatusFacturado = "X"
                Else
                    .pSFCTTR_StatusFacturado = ""
                End If

         
                sDetalleServicio = CType(cmbServicio.Resultado, ServicioLiquidacion).TCMTRF

                Me.DialogResult = Windows.Forms.DialogResult.OK
              
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        oInfServicio.pClear()
        sDetalleServicio = ""
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmLiquidacionFlete_DlgAgregarServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Carga el control de los servicios a facturar
        Try
            Cargar_Proveedor()
            With oInfServicio
                lblOperacion.Text &= "   " & .pNOPRCN_NroOperacion
                lblNroGuiaRemision.Text &= "   " & .pNGUITR_NroGuiaRemision
                txtCorrelativoServ.Text = .pNCRRGU_CorrServ
                txtReferencia.Text = .pTRFSRG_RefrenciaServicioGuia
                txtImporte.Text = Val(.pISRVGU_importeServicio)
                txtCantidadServ.Text = Val(.pQCNDTG_CantServicioGuia)
                
                If .pSFCTTR_StatusFacturado = "" Then
                    chkFacturacionCliente.CheckState = CheckState.Unchecked
                Else
                    chkFacturacionCliente.CheckState = CheckState.Checked
                End If

                Dim oListColum As New Hashtable
                Dim oColumnas As New DataGridViewTextBoxColumn
                oColumnas.Name = "CSRVNV"
                oColumnas.DataPropertyName = "CSRVNV"
                oColumnas.HeaderText = "Código"
                oListColum.Add(1, oColumnas)
                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "TCMTRF"
                oColumnas.DataPropertyName = "TCMTRF"
                oColumnas.HeaderText = "Servicio"
                oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                oListColum.Add(2, oColumnas)


                Dim obr As New Ransa.Controls.ServTransp.cServTransp
                Dim obe As New Ransa.Controls.ServTransp.TD_Obj_ServTransp
                Dim logica As New ServicioTransporte_BLL
                cmbServicio.DataSource = Nothing
                cmbServicio.DataSource = logica.Listar_ServicioTransporteLiquidacion(strCompania, strDivision)
                Me.cmbServicio.ListColumnas = oListColum
                Me.cmbServicio.Cargas()
                Me.cmbServicio.Limpiar()
                Me.cmbServicio.ValueMember = "CSRVNV"
                Me.cmbServicio.DispleyMember = "TCMTRF"
                Me.cmbServicio.Valor = .pCSRVC_Servicio
                ' Moneda
                Dim obr2 As New ServicioMercaderia_BLL

                Dim listaMonedas As List(Of Ransa.Controls.Moneda.TD_Moneda) = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Moneda.TD_Moneda)(obr2.fdtListar_Moneda_L01())
                cboMoneda_2.DataSource = listaMonedas
                cboMoneda_2.ValueMember = "pCMNDA1_Codigo"
                cboMoneda_2.DisplayMember = "pTMNDA_Detalle"
                cboMoneda_2.SelectedValue = .pCMNDGU_MonedaGuia.ToString


                 



                Dim obr3 As New Ransa.Controls.Unidad.cUnidad()
                Dim ref As String = String.Empty

                Dim listaUN As List(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02) = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02)(obr3.fdtListar("", "", ref, strCompania))
                CargarControlucAyuda(cboUnidad, .pCUNDSR_Unidad.ToString().Trim(), listaUN)



                'pbeAutorizacionLiq
                lblmensaje.Text = ""
                If pFlagTarifaOS = "X" Then
                    If pbeAutorizacionLiq.ModifTarifaOS = "X" Then
                        txtImporte.Enabled = True
                    Else
                        txtImporte.Enabled = False
                        lblmensaje.Text = "[No autorizado a modificar tarifa]"
                    End If

                End If


                Me.btnAceptar.Select()


            End With
            sDetalleServicio = String.Empty

           

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarControlucAyuda(ByRef control As Ransa.Utilitario.ucAyuda, ByVal valor As String, ByVal listaUN As List(Of Ransa.Controls.Unidad.TD_Inf_Unidad_L02))

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "pCUNDMD_Unidad"
        oColumnas.DataPropertyName = "pCUNDMD_Unidad"
        oColumnas.HeaderText = "Abreviatura"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "pTABRUN_Descripcion"
        oColumnas.DataPropertyName = "pTABRUN_Descripcion"
        oColumnas.HeaderText = "Unidad"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        control.DataSource = Nothing


        control.DataSource = listaUN

        control.ListColumnas = oListColum
        control.Cargas()
        control.Limpiar()
        control.ValueMember = "pCUNDMD_Unidad"
        control.DispleyMember = "pTABRUN_Descripcion"
        control.Valor = valor
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtCantidadServ_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadServ.KeyPress
        CType(sender, TextBox).Tag = "8-3"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtImporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.Leave
        Dim cajaTexto As TextBox = CType(sender, TextBox)
        If cajaTexto.Text.EndsWith(".") Then
            cajaTexto.Text = cajaTexto.Text.Replace(".", "")
        End If
    End Sub

    Private Sub txtCantidadServ_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadServ.Leave, txtCantidadServ.Leave
        Dim cajaTexto As TextBox = CType(sender, TextBox)
        If cajaTexto.Text.EndsWith(".") Then
            cajaTexto.Text = cajaTexto.Text.Replace(".", "")
        End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region " Metodos "
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal oTemp As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByVal mSESTRG As String, ByVal mTipoAdicionModif As String, ByVal CRGVTA As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicializacion despues de la llamada a InitializeComponent().
        oInfServicio = oTemp
        strCompania = Compania
        strDivision = Division
        SESGRP = mSESTRG
        strTipoAdicionModif = mTipoAdicionModif
        _CRGVTA = CRGVTA

    End Sub

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""


        If cmbServicio.Resultado Is Nothing Then strMensajeError &= "* Seleccione Servicio" & vbNewLine
        If cboProveedor.pRucTransportista.Trim.Equals("") Then strMensajeError &= "* Ingrese Proveedor" & vbNewLine
        If cboMoneda_2.SelectedValue Is Nothing Then strMensajeError &= "* Seleccione Moneda" & vbNewLine
        If cboUnidad.Resultado Is Nothing Then strMensajeError &= "* Seleccione Unidad" & vbNewLine


        If chkFacturacionCliente.Checked = True Then
            If txtImporte.Text.Trim <> "" Then
                If IsNumeric(txtImporte.Text.Trim) Then
                    If txtImporte.Text.Trim = 0 Then
                        strMensajeError &= "* Ingrese Importe" & vbNewLine
                    End If
                ElseIf Not IsNumeric(txtImporte.Text.Trim) Then
                    txtImporte.Text = "0"
                    strMensajeError &= "* Ingrese Importe" & vbNewLine
                End If
            Else
                strMensajeError &= "* Ingrese Importe" & vbNewLine
            End If

            If txtCantidadServ.Text.Trim <> "" Then
                If IsNumeric(txtCantidadServ.Text.Trim) Then
                    If txtCantidadServ.Text.Trim = 0 Then
                        strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                    End If
                ElseIf Not IsNumeric(txtCantidadServ.Text.Trim) Then
                    txtCantidadServ.Text = "0"
                    strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                Else
                    strMensajeError &= "* Ingrese Cantidad" & vbNewLine
                End If

            End If
        End If


       
        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

   

    Private Sub Cargar_Proveedor()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        If oInfServicio.pNRUCTR_RucProveedor = "0" Then
            obeTransportista.pCCMPN_Compania = strCompania
            cboProveedor.pCargar(obeTransportista)
        Else
            With oInfServicio
                obeTransportista.pCCMPN_Compania = strCompania
                obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
                cboProveedor.pCargar(obeTransportista)
                cboProveedor.Enabled = pModificarProv
                cmbServicio.Enabled = pModificarServ
            End With

            If oInfServicio.pNCRRGU_CorrServ = 1 And strTipoAdicionModif = "M" Then
                cboProveedor.Enabled = False
            End If

        End If

    End Sub
#End Region




End Class
