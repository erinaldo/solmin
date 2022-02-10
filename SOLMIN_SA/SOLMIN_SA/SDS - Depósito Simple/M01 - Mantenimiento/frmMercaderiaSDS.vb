'Imports RANSA.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS.MantenimientoSDS
Imports RANSA.DAO.OrdenCompra
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.DATA

Public Class frmMercaderiaSDS
#Region " Atributos "
    Private intCCLNT As Int64 = 0
    Private strTCMPCL As String = ""
    Private strCFMCLR As String = ""
    Private strTFMCLR As String = ""
    Private strCGRCLR As String = ""
    Private strTGRCLR As String = ""
    Private strCMRCLR As String = ""


    'Pasar datos de Guia Remision
    'Private docu As Int16
    'Public pcodigo As Int32 = 0
    'Public pnguirm As Int32 = 0
    'Public pnorcml As String = ""
    'Public merca As String = ""

    Private objSqlManager As SqlManager
    Dim strMensajeError As String = ""

    Private intTipoInvoke As Int16 = 0
#End Region
#Region " Propiedades "
    ' Se proporciona el Codigo del Cliente 
    Public WriteOnly Property pintCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    'Public WriteOnly Property p_docu() As Int16
    '    Set(value As Int16)
    '        docu = value
    '    End Set
    'End Property



    ' Se proporciona la Razón Social del Cliente
    Public WriteOnly Property pstrRazonSocial_TCMPCL() As String
        Set(ByVal value As String)
            strTCMPCL = value
        End Set
    End Property
    ' Se proporciona el Codigo la Familia
    Public WriteOnly Property pstrCodigoFamilia_CFMCLR() As String
        Set(ByVal value As String)
            strCFMCLR = value
        End Set
    End Property
    ' Se proporciona el detalle de la Familia
    Public WriteOnly Property pstrDescripcionFamilia_TFMCLR() As String
        Set(ByVal value As String)
            strTFMCLR = value
        End Set
    End Property
    ' Se proporciona el Codigo la Familia
    Public WriteOnly Property pstrCodigoGrupo_CGRCLR() As String
        Set(ByVal value As String)
            strCGRCLR = value
        End Set
    End Property
    ' Se proporciona el detalle de la Familia
    Public WriteOnly Property pstrDescripcionGrupo_TGRCLR() As String
        Set(ByVal value As String)
            strTGRCLR = value
        End Set
    End Property
    ' Se proporciona el Código de la Mercadería siempre y cuando sea Modificación
    Public WriteOnly Property pstrCodigoMercaderia_CMRCLR() As String
        Set(ByVal value As String)
            strCMRCLR = value
        End Set
    End Property

    ' Se proporciona el Tipo de Llamado al Formulario
    Public WriteOnly Property pintTipoInvoke() As Int16
        Set(ByVal value As Int16)
            intTipoInvoke = value
        End Set
    End Property

#End Region
#Region " Procedimientos y Funciones "
    Private Sub pCargarControles(ByVal objMercaderia As clsMercaderia)
        With objMercaderia
            txtCodigoReemplazo.Text = .pstrCodigoMercaderiaReemplazo_CMRCRR
            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            'txtCodigoRANSA.Tag = .pstrCodigoRANSA_CMRCD
            'mfblnObtenerDetalle_SDSCodigoMercaderiaRANSA(txtCodigoRANSA.Tag, txtCodigoRANSA.Text)
            ' -----------------------
            txtDescMerca01.Text = .pstrDescripcion_TMRCD2
            txtDescMerca02.Text = .pstrDescripcion_TMRCD3
            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            txtProveedor.pCodigo = .pintProveedor_CPRVCL
            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            txtMoneda.Tag = .pintCodigoMoneda_CMNCT
            mfblnObtenerDetalle_Moneda(txtMoneda.Tag, txtMoneda.Text, "")
            ' -----------------------
            txtCostoProveedor.Text = .pdecImporteCosto_QIMCT
            txtCostoPromProveedor.Text = .pdecImporteCostoPromedio_QIMCTP
            txtCostoPromSoles.Text = .pdecImporteCostoPromedioSoles_QICOPS
            chkMarcaControl.Checked = .pblnMarcaReembolso_MARCRE
            txtValorVentaDolar.Text = .pdecImporteVentaDolar_IMVTAD
            txtValorVentaSoles.Text = .pdecImporteVentaDolar_IMVTAS
            txtValorXMts2.Text = .pdecImportePorMts2_IMVLM2
            txtDescuento.Text = .pdecPorcentajeDescuento_PDSCTO
            txtMarcaModelo.Text = .pstrMarcaModelo_TMRCTR
            txtUbicacion.Text = .pstrUbicacion_UBICA1
            txtObservaciones.Text = .pstrObservacion_TOBSRV
            txtCantidadMinServicio.Text = .pdecCantidadMinimaReqServicio_QMRSRC
            txtPesoMinServicio.Text = .pdecPesoMinimoReqServicio_QMRSRP
            txtCantidadMercReorden.Text = .pdecCantidadMercaderiaPtoReorden_QMRODC
            txtPesoMercReorden.Text = .pdecPesoMercaderiaPtoReorden_QMRODP
            txtLargoMercaderia.Text = .pdecLargoMercaderia_QLRGMR
            txtAnchoMercaderia.Text = .pdecAnchoMercaderia_QANCMR
            txtAlturaMercaderia.Text = .pdecAlturaMercaderia_QALTMR
            txtAreaMts2.Text = .pdecAreaMts2_QARMT2
            txtVolumenMts3.Text = .pdecVolumenMts3_QARMT3
            txtVolumenEquivalente.Text = .pdecVolumenEquivalente_QVOLEQ
            txtPesoDeclarado.Text = .pdecCantidadPesoDeclarado_QPSODC
            txtTiempoCarga.Text = .pdecTiempoCargaMercaderia_QTMPCR
            txtTiempoDescarga.Text = .pdecTiempoDesargaMercaderia_QTMPDS
            chkPublicacionWEB.Checked = .pblnStatusPublicacionWEB_FPUWEB
            txtUnidad.Text = .pstrUnidad_CUNCNC
            txtUnidadInventario.Text = .pstrUnidadInventario_CUNCNI
            txtFechaVencimiento.Text = .pstrFechaVencimiento_FVNCMR
            txtFechaInventario.Text = .pstrFechaInventario_FINVRN
            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            If "" & .pstrCodigoPerfumancia_CPRFMR <> "" Then
                txtPerfumancia.Tag = .pstrCodigoPerfumancia_CPRFMR
                mfblnObtenerDetalle_SDSTipoPerfumancia(txtPerfumancia.Tag, txtPerfumancia.Text)
            End If

            If .SCNTSR_MarcaControlSerie = "X" Then
                chkMarcaSerie.Checked = True
            End If
            'JM
            If .FUNCTL = "X" Then
                chkControlLote.Checked = True
            End If


            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            If "" & .pstrCodigoInflamabilidad_CINFMR <> "" Then
                txtInflamable.Tag = .pstrCodigoInflamabilidad_CINFMR
                mfblnObtenerDetalle_SDSTipoInflamable(txtInflamable.Tag, txtInflamable.Text)
            End If
            ' -----------------------
            txtRotacion.Text = .pstrCodigoRotacion_CROTMR
            ' -----------------------
            ' obtener informacion 
            ' -----------------------
            txtApilabilidad.Text = .pstrCodigoApilabilidad_CAPIMR
            txtApilabilidad.Tag = .pstrCodigoApilabilidad_CAPIMR
            ' -----------------------
            txtDUN14.Text = .pstrCodigoDUN14
            txtEAN13.Text = .pstrCodigoEAN13
            txtCantidadMinProducir.Text = .pdecCantidadMinimaProducir_QMRPRD
            txtPartidaArancelaria.Text = .CPTDAR_PartidaArancelaria
        End With
    End Sub

    Private Sub pGuardarMercaderia()
        If fblnValidarMercaderia() Then
            Dim objMercaderia As clsMercaderia = New clsMercaderia
            With objMercaderia
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrCodigoFamilia_CFMCLR = txtFamilia.Tag
                .pstrCodigoGrupo_CGRCLR = txtGrupo.Tag
                .pstrCodigoMercaderia_CMRCLR = txtCodigoMercaderia.Text
                .pstrCodigoMercaderiaReemplazo_CMRCRR = txtCodigoReemplazo.Text
                '.pstrCodigoRANSA_CMRCD = "" & txtCodigoRANSA.Tag
                .pstrCodigoRANSA_CMRCD = ""
                .pstrDescripcion_TMRCD2 = txtDescMerca01.Text
                .pstrDescripcion_TMRCD3 = txtDescMerca02.Text
                .pintProveedor_CPRVCL = txtProveedor.pCodigo
                .pintCodigoMoneda_CMNCT = Val(txtMoneda.Tag)
                Decimal.TryParse(txtCostoProveedor.Text, .pdecImporteCosto_QIMCT)
                Decimal.TryParse(txtCostoPromProveedor.Text, .pdecImporteCostoPromedio_QIMCTP)
                Decimal.TryParse(txtCostoPromSoles.Text, .pdecImporteCostoPromedioSoles_QICOPS)
                .pblnMarcaReembolso_MARCRE = chkMarcaControl.Checked
                Decimal.TryParse(txtValorVentaDolar.Text, .pdecImporteVentaDolar_IMVTAD)
                Decimal.TryParse(txtValorVentaSoles.Text, .pdecImporteVentaDolar_IMVTAS)
                Decimal.TryParse(txtValorXMts2.Text, .pdecImportePorMts2_IMVLM2)
                Decimal.TryParse(txtDescuento.Text, .pdecPorcentajeDescuento_PDSCTO)
                .pstrMarcaModelo_TMRCTR = txtMarcaModelo.Text
                .pstrUbicacion_UBICA1 = txtUbicacion.Text
                .pstrObservacion_TOBSRV = txtObservaciones.Text
                Decimal.TryParse(txtCantidadMinServicio.Text, .pdecCantidadMinimaReqServicio_QMRSRC)
                Decimal.TryParse(txtPesoMinServicio.Text, .pdecPesoMinimoReqServicio_QMRSRP)
                Decimal.TryParse(txtCantidadMercReorden.Text, .pdecCantidadMercaderiaPtoReorden_QMRODC)
                Decimal.TryParse(txtPesoMercReorden.Text, .pdecPesoMercaderiaPtoReorden_QMRODP)
                Decimal.TryParse(txtLargoMercaderia.Text, .pdecLargoMercaderia_QLRGMR)
                Decimal.TryParse(txtAnchoMercaderia.Text, .pdecAnchoMercaderia_QANCMR)
                Decimal.TryParse(txtAlturaMercaderia.Text, .pdecAlturaMercaderia_QALTMR)
                Decimal.TryParse(txtAreaMts2.Text, .pdecAreaMts2_QARMT2)
                Decimal.TryParse(txtVolumenMts3.Text, .pdecVolumenMts3_QARMT3)
                Decimal.TryParse(txtVolumenEquivalente.Text, .pdecVolumenEquivalente_QVOLEQ)
                Decimal.TryParse(txtPesoDeclarado.Text, .pdecCantidadPesoDeclarado_QPSODC)
                Decimal.TryParse(txtTiempoCarga.Text, .pdecTiempoCargaMercaderia_QTMPCR)
                Decimal.TryParse(txtTiempoDescarga.Text, .pdecTiempoDesargaMercaderia_QTMPDS)
                .pblnStatusPublicacionWEB_FPUWEB = chkPublicacionWEB.Checked
                .pstrUnidad_CUNCNC = txtUnidad.Text
                .pstrUnidadInventario_CUNCNI = txtUnidadInventario.Text
                Date.TryParse(txtFechaVencimiento.Text, .pdteFechaVencimiento_FVNCMR)
                Date.TryParse(txtFechaInventario.Text, .pdteFechaInventario_FINVRN)
                .pstrCodigoPerfumancia_CPRFMR = "" & txtPerfumancia.Tag
                .pstrCodigoInflamabilidad_CINFMR = "" & txtInflamable.Tag
                .pstrCodigoRotacion_CROTMR = txtRotacion.Text
                .pstrCodigoApilabilidad_CAPIMR = txtApilabilidad.Text
                .pstrCodigoDUN14 = txtDUN14.Text
                .pstrCodigoEAN13 = txtEAN13.Text
                Decimal.TryParse(txtCantidadMinProducir.Text, .pdecCantidadMinimaProducir_QMRPRD)
                .CPTDAR_PartidaArancelaria = txtPartidaArancelaria.Text
                .SCNTSR_MarcaControlSerie = IIf(chkMarcaSerie.Checked, "X", "")
                'JM
                .FUNCTL = IIf(chkControlLote.Checked, "X", "")
            End With
            ' Si el proceso es ok se limpia los controles.
            If mfblnGuardar_Mercaderia(objMercaderia) Then

                'If docu = 1 Then
                '    'Actualizar la mercadería
                '    objSqlManager = New SqlManager()
                '    If cItemGuiaRemision.fdt_update_itemgr(objSqlManager, pcodigo, pnguirm, pnorcml, txtCodigoMercaderia.Text.Trim, strMensajeError) Then
                '        merca = txtCodigoMercaderia.Text.Trim
                '    End If
                'End If



                Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
                Call pLimpiarControles(0)
                txtCodigoMercaderia.Focus()
            Else
                Call mpMsjeVarios(enumMsjVarios.PROCESO_Ko_Guardar)
            End If
        End If
    End Sub



    Private Sub pLimpiarControles(ByVal intNivel As Integer)
        If intNivel <= 0 Then
            txtCodigoMercaderia.Clear()
            lblMensajeMercaderia.Text = "."
        End If
        If intNivel <= 1 Then
            txtCodigoReemplazo.Clear()
            txtDescMerca01.Clear()
            txtDescMerca02.Clear()
            txtMoneda.Clear()
            txtCostoProveedor.Text = "0.000"
            txtCostoPromProveedor.Text = "0.000"
            txtCostoPromSoles.Text = "0.000"
            chkMarcaControl.Checked = False
            chkPublicacionWEB.Checked = False

            chkControlLote.Checked = False

            txtValorVentaDolar.Text = "0.000"
            txtValorVentaSoles.Text = "0.000"
            txtValorXMts2.Text = "0.000"
            txtDescuento.Text = "0.00"
            txtMarcaModelo.Clear()
            txtUbicacion.Clear()
            txtObservaciones.Clear()
            txtCantidadMinServicio.Text = "0.000"
            txtPesoMinServicio.Text = "0.000"
            txtCantidadMercReorden.Text = "0.000"
            txtPesoMercReorden.Text = "0.000"
            txtLargoMercaderia.Text = "0.000"
            txtAnchoMercaderia.Text = "0.000"
            txtAlturaMercaderia.Text = "0.000"
            txtAreaMts2.Text = "0.000"
            txtVolumenMts3.Text = "0.000"
            txtVolumenEquivalente.Text = "0.000"
            txtPesoDeclarado.Text = "0.000"
            txtTiempoCarga.Text = "0.000"
            txtTiempoDescarga.Text = "0.000"
            txtUnidad.Clear()
            txtUnidadInventario.Clear()
            txtFechaVencimiento.Clear()
            txtFechaInventario.Clear()
            txtPerfumancia.Clear()
            txtInflamable.Clear()
            txtRotacion.Clear()
            txtApilabilidad.Clear()
            txtDUN14.Clear()
            txtEAN13.Clear()
            txtPartidaArancelaria.Clear()
            txtCantidadMinProducir.Text = "0.000"
        End If
    End Sub

    Private Sub pMercaderia_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F2
                Call pGuardarMercaderia()
                If intTipoInvoke = 1 Then Me.DialogResult = Windows.Forms.DialogResult.OK
            Case Keys.Escape
                Me.Close()
                If intTipoInvoke = 1 Then Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Select
    End Sub

    Private Function fblnValidarMercaderia() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If Me.txtCliente.pCodigo = 0 Then strMensajeError &= "No ha seleccionado el Cliente. " & vbNewLine
        If Me.txtCodigoMercaderia.Text = "" Then strMensajeError &= "Debe ingresar el Código de la Mercadería. " & vbNewLine
        If Me.txtFamilia.Text = "" Then strMensajeError &= "No ha seleccionado la Familia que pertenece la Mercadería. " & vbNewLine
        If Me.txtGrupo.Text = "" Then strMensajeError &= "No ha seleccionado el Grupo que pertenece la Mercadería. " & vbNewLine
        If Me.txtDescMerca01.Text = "" Then strMensajeError &= "Debe ingresar el nombre de la Mercadería. " & vbNewLine
        'If Me.txtCodigoRANSA.Text = "" Then strMensajeError &= "No ha seleccionado Cód. RANSA" & vbNewLine

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
    Private Sub bsaApilabilidadListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaApilabilidadListar.Click
        Dim strTemp As String = txtApilabilidad.Text
        Call mfblnBuscar_SDSTipoApilabilidad(txtApilabilidad.Text, strTemp)
        txtApilabilidad.Tag = txtApilabilidad.Text
    End Sub

    'Private Sub bsaCodigoRANSAListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCodigoRANSAListar.Click
    '    Call mfblnBuscar_SDSEquivalenteMercRANSA(txtCodigoRANSA.Tag, txtCodigoRANSA.Text)
    'End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
    End Sub

    Private Sub bsaInflamableListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaInflamableListar.Click
        Call mfblnBuscar_SDSTipoInflamable(txtInflamable.Tag, txtInflamable.Text)
    End Sub

    Private Sub bsaPerfumanciaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaPerfumanciaListar.Click
        Call mfblnBuscar_SDSTipoPerfumancia(txtPerfumancia.Tag, txtPerfumancia.Text)
    End Sub

    Private Sub bsaMonedaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaMonedaListar.Click
        Call mfblnBuscar_Moneda(txtMoneda.Tag, txtMoneda.Text, "")
    End Sub

    Private Sub chkPublicacionWEB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkPublicacionWEB.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub frmMercaderia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If intTipoInvoke = 1 Then Exit Sub
        If Not mfblnSalirOpcion() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Si no se información un Cliente se asume que esta ingresando de modo directo
        If intCCLNT <> 0 Then

            txtCodigoRANSA.Enabled = False



            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intCCLNT, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)

            txtFamilia.Text = strTFMCLR
            txtFamilia.Tag = strCFMCLR
            txtGrupo.Text = strTGRCLR
            txtGrupo.Tag = strCGRCLR
            ' Si es diferente de "" entonces es modificacion
            If strCMRCLR <> "" Then
                ' Almaceno los valores en el control respectivo
                txtCodigoMercaderia.Text = strCMRCLR
                txtCodigoMercaderia.Tag = strCMRCLR

                ' Realizamos las validaciones respectivas
                Dim objPrimaryKey_Mercaderia As clsPrimaryKey_Mercaderia = New clsPrimaryKey_Mercaderia
                Dim objMercaderia As clsMercaderia = New clsMercaderia
                With objPrimaryKey_Mercaderia
                    .pintCodigoCliente_CCLNT = intCCLNT
                    .pstrCodigoFamilia_CFMCLR = strCFMCLR
                    .pstrCodigoGrupo_CGRCLR = strCGRCLR
                    .pstrCodigoMercaderia_CMRCLR = strCMRCLR
                End With
                ' Verifico si existe la Mercadería
                If mfblnExiste_Mercaderia(txtCliente.pCodigo, txtCodigoMercaderia.Tag, lblMensajeMercaderia.Text) Then
                    If mfblnObtener_Mercaderia(objPrimaryKey_Mercaderia, objMercaderia) Then Call pCargarControles(objMercaderia)
                Else
                    ' Si NO existe me posiciono en el CheckBox
                    chkMarcaControl.Focus()
                End If
            Else
                txtCodigoMercaderia.Focus()
            End If
        Else
            txtCliente.pUsuario = objSeguridadBN.pUsuario
        End If
    End Sub

    Private Sub txtAlturaMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlturaMercaderia.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtAnchoMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAnchoMercaderia.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtApilabilidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApilabilidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim strTemp As String = txtApilabilidad.Text
            Call mfblnBuscar_SDSTipoApilabilidad(txtApilabilidad.Text, strTemp)
            txtApilabilidad.Tag = txtApilabilidad.Text
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtApilabilidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApilabilidad.TextChanged
        txtApilabilidad.Tag = ""
    End Sub

    Private Sub txtApilabilidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApilabilidad.Validating
        If txtApilabilidad.Text = "" Then
            txtApilabilidad.Tag = ""
        Else
            If txtApilabilidad.Text <> "" And "" & txtApilabilidad.Tag = "" Then
                Dim strTemp As String = txtApilabilidad.Text
                Call mfblnBuscar_SDSTipoApilabilidad(txtApilabilidad.Text, strTemp)
                txtApilabilidad.Tag = txtApilabilidad.Text
                'If txtCodigoRANSA.Text = "" Then
                '    e.Cancel = True
                'End If
            End If
        End If
    End Sub

    Private Sub txtAreaMts2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaMts2.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCantidadMercReorden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidadMercReorden.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCantidadMinProducir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidadMinProducir.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCantidadMinServicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidadMinServicio.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCodigoMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoMercaderia.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCodigoMercaderia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoMercaderia.TextChanged
        txtCodigoMercaderia.Tag = ""
        lblMensajeMercaderia.Text = "."
    End Sub

    Private Sub txtCodigoMercaderia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoMercaderia.Validating
        If txtCodigoMercaderia.Text = "" Then
            txtCodigoMercaderia.Tag = ""
            Call pLimpiarControles(1)
            Exit Sub
        Else
            If txtCodigoMercaderia.Text <> "" And "" & txtCodigoMercaderia.Tag = "" Then
                Dim objPrimaryKey_Mercaderia As clsPrimaryKey_Mercaderia = New clsPrimaryKey_Mercaderia
                With objPrimaryKey_Mercaderia
                    .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                    .pstrCodigoFamilia_CFMCLR = "" & txtFamilia.Tag
                    .pstrCodigoGrupo_CGRCLR = "" & txtGrupo.Tag
                    .pstrCodigoMercaderia_CMRCLR = txtCodigoMercaderia.Text
                End With
                If Me.intTipoInvoke = 1 Then Exit Sub
                Call pLimpiarControles(1)
                If mfblnExiste_Mercaderia(txtCliente.pCodigo, txtCodigoMercaderia.Text, lblMensajeMercaderia.Text) Then
                    Dim objMercaderia As clsMercaderia = New clsMercaderia
                    If mfblnObtener_Mercaderia(objPrimaryKey_Mercaderia, objMercaderia) Then Call pCargarControles(objMercaderia)
                End If
                txtCodigoMercaderia.Tag = txtCodigoMercaderia.Text
            End If
        End If
    End Sub

    'Private Sub txtCodigoRANSA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoRANSA.KeyDown
    '    If e.KeyCode = Keys.F4 Then
    '        Call mfblnBuscar_SDSEquivalenteMercRANSA(txtCodigoRANSA.Tag, txtCodigoRANSA.Text)
    '    Else
    '        Call pMercaderia_KeyDown(e)
    '    End If
    'End Sub

    'Private Sub txtCodigoRANSA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoRANSA.TextChanged
    '    txtCodigoRANSA.Tag = ""
    'End Sub

    'Private Sub txtCodigoRANSA_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoRANSA.Validating
    '    If txtCodigoRANSA.Text = "" Then
    '        txtCodigoRANSA.Tag = ""
    '    Else
    '        If txtCodigoRANSA.Text <> "" And "" & txtCodigoRANSA.Tag = "" Then
    '            Call mfblnBuscar_SDSEquivalenteMercRANSA(txtCodigoRANSA.Tag, txtCodigoRANSA.Text)
    '            If txtCodigoRANSA.Text = "" Then
    '                e.Cancel = True
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub txtCodigoReemplazo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoReemplazo.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCostoProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoProveedor.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCostoPromProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoPromProveedor.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtCostoPromSoles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCostoPromSoles.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtDescMerca01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescMerca01.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtDescMerca02_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescMerca02.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtDescuento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescuento.Validating
        Dim decTemp As Decimal
        If Not Decimal.TryParse(txtDescuento.Text, decTemp) Then
            MessageBox.Show("Error en la Validación", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescuento.Text = "0.00"
            e.Cancel = True
        Else
            If Not (decTemp >= 0.0 And decTemp <= 100.0) Then
                MessageBox.Show("Debe ingresar un valor entre 0 y 100", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDescuento.Text = "0.00"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtFamilia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Tag = ""
        txtGrupo.Text = ""
    End Sub

    Private Sub txtFamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        If txtFamilia.Text = "" Then
            txtFamilia.Tag = ""
            Exit Sub
        Else
            If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtFechaInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaInventario.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtFechaVencimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaVencimiento.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtFechaVencimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFechaVencimiento.Validating
        If Not IsDate(txtFechaVencimiento.Text) Then txtFechaVencimiento.Clear()
    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged
        txtGrupo.Tag = ""
    End Sub

    Private Sub txtGrupo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrupo.Validating
        If txtGrupo.Text = "" Then
            txtGrupo.Tag = ""
            Exit Sub
        Else
            If txtGrupo.Text <> "" And "" & txtGrupo.Tag = "" Then
                Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                If txtGrupo.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtInflamable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInflamable.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSTipoInflamable(txtInflamable.Tag, txtInflamable.Text)
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtInflamable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInflamable.TextChanged
        txtInflamable.Tag = ""
    End Sub

    Private Sub txtInflamable_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInflamable.Validating
        If txtInflamable.Text = "" Then
            txtInflamable.Tag = ""
        Else
            If txtInflamable.Text <> "" And "" & txtInflamable.Tag = "" Then
                Call mfblnBuscar_SDSTipoInflamable(txtInflamable.Tag, txtInflamable.Text)
                If txtInflamable.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtLargoMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLargoMercaderia.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub chkMarcaControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkMarcaControl.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtMarcaModelo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMarcaModelo.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMoneda.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_Moneda(txtMoneda.Tag, txtMoneda.Text, "")
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtMoneda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMoneda.TextChanged
        txtMoneda.Tag = ""
    End Sub

    Private Sub txtMoneda_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMoneda.Validating
        If txtMoneda.Text = "" Then
            txtMoneda.Tag = ""
        Else
            If txtMoneda.Text <> "" And "" & txtMoneda.Tag = "" Then
                Call mfblnBuscar_Moneda(txtMoneda.Tag, txtMoneda.Text, "")
                If txtMoneda.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtPerfumancia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPerfumancia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSTipoPerfumancia(txtPerfumancia.Tag, txtPerfumancia.Text)
        Else
            Call pMercaderia_KeyDown(e)
        End If
    End Sub

    Private Sub txtPerfumancia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPerfumancia.TextChanged
        txtPerfumancia.Tag = ""
    End Sub

    Private Sub txtPerfumancia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPerfumancia.Validating
        If txtPerfumancia.Text = "" Then
            txtPerfumancia.Tag = ""
        Else
            If txtPerfumancia.Text <> "" And "" & txtPerfumancia.Tag = "" Then
                Call mfblnBuscar_SDSTipoPerfumancia(txtPerfumancia.Tag, txtPerfumancia.Text)
                If txtPerfumancia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtPesoDeclarado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoDeclarado.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtPesoMercReorden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoMercReorden.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtPesoMinServicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesoMinServicio.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtRotacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRotacion.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtTiempoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTiempoCarga.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtTiempoDescarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTiempoDescarga.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtUbicacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUbicacion.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtUnidadInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadInventario.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtValorVentaDolar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorVentaDolar.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtValorVentaSoles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorVentaSoles.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtValorXMts2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorXMts2.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtVolumenEquivalente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVolumenEquivalente.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtVolumenMts3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVolumenMts3.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtDUN14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDUN14.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtEAN13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEAN13.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub

    Private Sub txtPartidaArancelaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPartidaArancelaria.KeyDown
        Call pMercaderia_KeyDown(e)
    End Sub
#End Region

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Call pGuardarMercaderia()
            If intTipoInvoke = 1 Then Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
