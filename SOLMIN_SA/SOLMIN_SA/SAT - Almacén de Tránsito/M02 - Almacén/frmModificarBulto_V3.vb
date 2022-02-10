Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports Ransa.Utilitario

Public Class frmModificarBulto_V3
#Region " Atributos "
    '-- Atributos de Entrada
    Private intCCLNT As Integer = 0
    Private strCREFFW As String = ""
    Private strCCMPN As String = ""
    Private strCDVSN As String = ""
    Private dblNSEQIN As Double = 0
    Private dblCPLNDV As Double = 0
    Private Altura As Double = 0
    Private Ancho As Double = 0
    Private Largo As Double = 0
    Private Estado As Boolean = False
    'MPS
    Private ListaPLus As New Hashtable

#End Region
#Region " Propiedades "
    Public WriteOnly Property pCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    Public WriteOnly Property pCodigoRecepcion_CREFFW() As String
        Set(ByVal value As String)
            strCREFFW = value
        End Set
    End Property

    Public WriteOnly Property pCodigoCompania_CCMPN() As String
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoDivision_CDVSN() As String
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoPlanta_CPLNDV() As String
        Set(ByVal value As String)
            dblCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property pNrCorrelativo_NSEQIN() As String
        Set(ByVal value As String)
            dblNSEQIN = value
        End Set
    End Property
    Private _strNORCML As String = ""

#End Region
#Region " Procedimientos y Funciones "
    'Private Sub pMostrarBultoCabecera()
    '    CargarControles()
    '    Dim obeBulto As beBulto = New beBulto
    '    ' Valida que se obtenga el Bulto, caso contrario se sale de procedimiento
    '    obeBulto.PSCCMPN = strCCMPN
    '    obeBulto.PSCDVSN = strCDVSN
    '    obeBulto.PNCPLNDV = dblCPLNDV
    '    obeBulto.PNCCLNT = intCCLNT
    '    obeBulto.PSCREFFW = strCREFFW
    '    obeBulto.PNNSEQIN = dblNSEQIN
    '    Dim brBulto As New brBulto
    '    obeBulto = brBulto.floObjtenerBulto(obeBulto)
    '    If obeBulto.PSERROR.Trim.Length > 0 Then
    '        HelpClass.MsgBox(obeBulto.PSERROR, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If

    '    With obeBulto
    '        _strNORCML = .PSNORCML
    '        txtCodigoRecepcion.Text = .PSCREFFW
    '        Me.dtpIngreso.Value = .FechaIngAlmacenCL
    '        txtMotivoRecepcion.Text = .PSSMTRCP_D
    '        txtMotivoRecepcion.Tag = .PSSMTRCP
    '        txtSentidoCarga.Text = .PSSSNCRG_D
    '        txtSentidoCarga.Tag = .PSSSNCRG
    '        txtNroTicketBalanza.Text = .PNNTCKPS
    '        txtPesoTicket.Text = .PNQPSTKI
    '        txtCantidadRecibida.Text = .PNQREFFW
    '        txtTipoBulto.Text = .PSTIPBTO
    '        txtPesoBulto.Text = .PNQPSOBL
    '        txtUnidadPeso.Text = .PSTUNPSO
    '        'txtVolumenBulto.Text = .PNQVLBTO
    '        txtVolumenBulto.Text = .PNQVLBTO
    '        Altura = .PNQMTALT
    '        Ancho = .PNQMTANC
    '        Largo = .PNQMTLRG
    '        txtUnidadVolumen.Text = .PSTUNVOL
    '        txtUbicacionReferencial.Valor = .PSTUBRFR
    '        txtCodigoOrigen.Text = .PSCBLTOR
    '        txtCodigoEmbarcador.Text = .PSCREEMB
    '        txtInformacionAdicional.Text = .PSTDSCIT
    '        txtCantidadAreaOcupada.Text = .PNQAROCP
    '        txtNroOrdenServicioAgencia.Text = .PNNORAGN
    '        txtTipoMovimiento.Text = .PSSTPING_D
    '        txtTipoMovimiento.Tag = .PSSTPING
    '        txtDescripcionWaybill.Text = .PSDESCWB
    '        txtImporteBulto.Text = .PNIPBULT

    '        Me.txtTerrestre.Text = .PSTCTCST
    '        Me.txtAereo.Text = .PSTCTCSA
    '        Me.txtFluvial.Text = .PSTCTCSF
    '        Me.txtAfe.Text = .PSTCTAFE
    '        Me.txtMedioSugerido.Valor = .PNCMEDTS

    '        If .PNFSLFFW > 100 Then
    '            Me.dtpFechaSalida.Value = .FechaSalAlmacenCL
    '        Else
    '            Me.dtpFechaSalida.Visible = False
    '            lblFechaSalida.Visible = False
    '        End If

    '        Me.UcMedioTransporte1.Text = .MEDIOENVIO
    '        Me.UcMedioTransporte1.Refrescar(Me.UcMedioTransporte1.Text)

    '        Me.txtGuiaProveedor.Text = .PSNGRPRV

    '        strCCMPN = .PSCCMPN
    '        strCDVSN = .PSCDVSN
    '        dblCPLNDV = .PNCPLNDV

    '        '=======CODIGO MODIFICADO POR ABRAHAM ZORRILLA 26-11-2010
    '        txtTipoAlmacen.Valor = .PSCTPALM
    '        txtAlmacen.Valor = .PSCALMC
    '        txtZonaAlmacen.Valor = .PSCZNALM
    '        Me.txtUsuarioReferencia.Text = .PSDSREFE.Trim

    '        txtSigla.Text = .PSCPRCN1.Trim
    '        txtNumeroContenedor.Text = .PSNSRCN1.Trim
    '        chkCnt.Checked = IIf(.PSSTPOCR = "1", True, False)


    '    End With
    'End Sub

    Private Sub pMostrarBultoCabecera()

        'MPS
        Dim obePlus As New beGeneral
        Dim obrGeneral As New brGeneral
        obePlus.PSCODVAR = "CLPLUS"
        obePlus.PSCCMPRN = ""
        Dim listaCliente As New List(Of beGeneral)
        listaCliente = obrGeneral.ListaTablaAyuda(obePlus)
        For Each beGen As beGeneral In listaCliente
            ListaPLus.Add(beGen.PSCCMPRN.Trim, beGen.PSCCMPRN.Trim)
        Next

        CargarControles()
        '   CargarControlesTipoMaterial()


        Dim objBulto As beBulto = New beBulto

        Dim obeBulto As New beBulto

        ' Valida que se obtenga el Bulto, caso contrario se sale de procedimiento
        objBulto.PSCCMPN = strCCMPN
        objBulto.PSCDVSN = strCDVSN
        objBulto.PNCPLNDV = dblCPLNDV
        objBulto.PNCCLNT = intCCLNT
        objBulto.PSCREFFW = strCREFFW
        objBulto.PNNSEQIN = dblNSEQIN


        obeBulto = objBulto
        Dim obrBulto As New brBulto
        objBulto = obrBulto.floObjtenerBulto(objBulto)
        If objBulto.PSERROR.Trim.Length > 0 Then
            HelpClass.MsgBox(objBulto.PSERROR, MessageBoxIcon.Error)
            Exit Sub
        End If

        With objBulto
            _strNORCML = .PSNORCML
            txtCodigoRecepcion.Text = .PSCREFFW
            dtpIngreso.Value = .FechaIngAlmacenCL
            
            txtMotivoRecepcion.Text = .PSSMTRCP_D
            txtMotivoRecepcion.Tag = .PSSMTRCP
            txtSentidoCarga.Text = .PSSSNCRG_D
            txtSentidoCarga.Tag = .PSSSNCRG
            If txtSentidoCarga.Tag = "2" And (intCCLNT = 30507 Or intCCLNT = 11731) Then
                txtEntrega.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 192)
            End If
            txtNroTicketBalanza.Text = .PNNTCKPS
            txtPesoTicket.Text = .PNQPSTKI
            txtCantidadRecibida.Text = .PNQREFFW
            txtTipoBulto.Text = .PSTIPBTO
            txtPesoBulto.Text = .PNQPSOBL
            txtUnidadPeso.Text = .PSTUNPSO
            'txtVolumenBulto.Text = .PNQVLBTO
            txtVolumenBulto.Text = .PNQVLBTO
            Altura = .PNQMTALT
            Ancho = .PNQMTANC
            Largo = .PNQMTLRG

            txtUnidadVolumen.Text = .PSTUNVOL
            txtUbicacionReferencial.Valor = .PSTUBRFR
            txtCodigoOrigen.Text = .PSCBLTOR
            txtCodigoEmbarcador.Text = .PSCREEMB
            txtInformacionAdicional.Text = .PSTDSCIT
            txtCantidadAreaOcupada.Text = .PNQAROCP
            txtNroOrdenServicioAgencia.Text = .PNNORAGN
            txtTipoMovimiento.Text = .PSSTPING_D
            txtTipoMovimiento.Tag = .PSSTPING
            txtDescripcionWaybill.Text = .PSDESCWB
            txtImporteBulto.Text = .PNIPBULT
            Me.txtTerrestre.Text = .PSTCTCST
            Me.txtAereo.Text = .PSTCTCSA
            Me.txtFluvial.Text = .PSTCTCSF
            Me.txtAfe.Text = .PSTCTAFE
            Me.txtOrigen.Text = .PSTLUGOR
            Me.txtEntrega.Text = .PSTLUGEN
            Me.txtMedioSugerido.Text = .PNCMEDTS
            Me.txtMedioSugerido.Valor = .PNCMEDTS
            Me.txtGuiaProveedor.Text = .PSNGRPRV
            strCCMPN = .PSCCMPN
            strCDVSN = .PSCDVSN
            dblCPLNDV = .PNCPLNDV
            txtSigla.Text = .PSCPRCN1.Trim
            txtNumeroContenedor.Text = .PSNSRCN1.Trim
            chkCnt.Checked = IIf(.PSSTPOCR = "1", True, False)
            '=======CODIGO MODIFICADO POR ABRAHAM ZORRILLA 26-11-2010
            txtTipoAlmacen.Valor = .PSCTPALM
            txtAlmacen.Valor = .PSCALMC
            txtZonaAlmacen.Valor = .PSCZNALM
            Me.txtUsuarioReferencia.Text = .PSDSREFE
            txtTarifa.Valor = .PSCLSTRF
            txtEtiqueta.Valor = .PSCCLRS
            '--miguel 
            Me.TxtTipoMaterial.Valor = .PSTTPOMR
            '29102018 Alberto
            KryptonTextBox1.Text = .PSTCTCAL

            If Not .FechaSolicitudMedio.Equals("") Then
                dtpFechaSolicitudMedio.Value = .FechaSolicitudMedio
            End If

            'OMVB REQ08072019
            dtgPaquetesDeBulto.AutoGenerateColumns = False
            BeBultoBindingSource.DataSource = obrBulto.flistListarBultoDetalleCarga(obeBulto)
            dtgPaquetesDeBulto.DataSource = BeBultoBindingSource
            'OMVB REQ08072019

            If .PNFSLFFW > 100 Then
                Me.dtpFechaSalida.Value = .FechaSalAlmacenCL
            Else
                Me.dtpFechaSalida.Visible = False
                lblFechaSalida.Visible = False
            End If

            'MPS
            txtTipoCarga.Valor = .PSTTPCRG
            ucIncidencia.Valor = .PSINCBLT

            'PSTPCARGA

            'OMVB REQ15072019 HORA ENTREGA
            If String.IsNullOrEmpty(.PNHORIDE) Or .PNHORIDE = "0" Then
                Me.txtHoraEntrega.Text = "00:00"
            Else
                Dim CSA As String
                CSA = Decimal.Round(.PNHORIDE, 2).ToString()
                CSA = CSA.Replace(":", "").Trim.PadLeft(6, "0")
                CSA = Mid(CSA, 1, 4)
                Me.txtHoraEntrega.Text = CSA
            End If
            'OMVB REQ15072019 HORA ENTREGA

        End With


    End Sub

    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""
        If Me.txtCodigoRecepcion.Text = "" Then strMensajeError &= "Debe ingresar Nro. de Recepción..." & vbNewLine
        If Me.txtTipoMovimiento.Text = "" Then strMensajeError &= "Debe ingresar un Tipo de Movimiento..." & vbNewLine
        If Me.txtTipoBulto.Text = "" Then strMensajeError &= "Debe ingresar un Tipo de Bulto..." & vbNewLine
        If Me.txtCantidadRecibida.Text <= 0 Then strMensajeError &= "Debe ingresar Cantidad Recibida mayor a Cero..." & vbNewLine
        If Me.txtCantidadAreaOcupada.Text = "" Then strMensajeError &= "Debe ingresar la Cantidad de Área Ocupada..." & vbNewLine
        If Me.txtMotivoRecepcion.Text = "" Then strMensajeError &= "Debe seleccionar un Motivo de Recepción..." & vbNewLine
        If Me.txtSentidoCarga.Text = "" Then strMensajeError &= "Debe seleccionar el Sentido de la Carga..." & vbNewLine
        If txtUbicacionReferencial.Resultado Is Nothing Then _
      strMensajeError &= "Debe ingresar una Ubicación para el Bulto creado..." & vbNewLine
        If Me.txtDescripcionWaybill.Text = "" Then strMensajeError &= "Debe ingresar una Descripción para el Bulto creado..." & vbNewLine
        If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar una Zona de Almacén." & vbNewLine
        If TxtTipoMaterial.Resultado Is Nothing Then strMensajeError &= "Debe Selecionar un tipo de material." & vbNewLine

        'MPS
        If ListaPLus.Contains(intCCLNT.ToString.Trim) Then '  = 30507 ' Or intCCLNT = 11731 Then
            If txtTipoCarga.Resultado Is Nothing Then
                strMensajeError &= "Debe ingresar Tipo de Carga." & vbNewLine
            End If
        End If
        ''OMVB REQ08072019
        If Me.dtgPaquetesDeBulto.Rows.Count > 0 Then
            Dim strErrorCan As String = String.Empty
            Dim strErrorAl As String = String.Empty
            Dim strErrorAn As String = String.Empty
            Dim strErrorLag As String = String.Empty

            Dim intQBulto As Decimal = 0
            Dim dbPesoBulto As Decimal = 0
            Dim dbVolumenBulto As Decimal = 0
            'Dim dbAreaBulto As Decimal = 0

            'PNQCTPQT

            For Each obeBulto As beBulto In dtgPaquetesDeBulto.DataSource
                intQBulto += obeBulto.PNQCTPQT
                'dbPesoBulto += obeBulto.PNQPSOMR
                dbPesoBulto += Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQPSOMR, 2)

                dbVolumenBulto += obeBulto.VOLUMENPAQUETE
                'dbAreaBulto += obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC 'OMVB REQ08072019
                'If obeBulto.PNQCTPQT = 0 And strErrorCan.Length = 0 Then
                '    strErrorCan = "La Cantidad Recibida Paquete no debe de ser igual a Cero" & vbNewLine
                'End If
                'If obeBulto.PNQCTPQT = 0 And strErrorCan.Length = 0 Then
                '    strErrorCan = "La Cantidad Recibida Paquete no debe de ser igual a Cero" & vbNewLine
                'End If

                '   If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0) Then 'OMVB 08072019
                If obeBulto.PNQMTLRG = 0 And strErrorLag.Length = 0 Then
                    strErrorAl = "El Largo del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
              

                If obeBulto.PNQMTANC = 0 And strErrorAn.Length = 0 Then
                    strErrorAn = "El Ancho del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
           

                If obeBulto.PNQMTALT = 0 And strErrorAl.Length = 0 Then
                    strErrorLag = "El Alto del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
              

                ' End If 'OMVB 08072019
            Next
            strMensajeError &= strErrorCan & strErrorAl & strErrorAn & strErrorLag
            If Me.txtCantidadRecibida.Text <> intQBulto Then
                strMensajeError &= "La Cantidad de la Recepción no es igual a la suma de cantidades de los paquetes" & vbNewLine
            End If
            If txtPesoBulto.Text <> dbPesoBulto Then
                strMensajeError &= "El Peso de la Recepción no es igual a la suma de Pesos de los Paquetes" & vbNewLine
            End If
            If Math.Round(Decimal.Parse(txtVolumenBulto.Text), 3) <> Math.Round(dbVolumenBulto, 3) Then
                strMensajeError &= "El Volumen de la Recepción no es igual a la suma de Volúmenes de los Paquetes" & vbNewLine
            End If
            'If Math.Round(Decimal.Parse(txtCantidadAreaOcupada.Text), 3) <> Math.Round(dbAreaBulto, 3) Then
            '    strMensajeError &= "El área de la Recepción no es igual a la suma de áreas de los Paquetes" & vbNewLine
            'End If
        End If
        ''OMVB REQ08072019

        If Me.dtpFechaSalida.Visible Then
            If Me.dtpFechaSalida.Value < Me.dtpIngreso.Value Then
                strMensajeError &= "Fecha de salida debe de ser mayor o igual a la fecha de recepción ." & vbNewLine
            End If
        End If

        'OMVB REQ15072019 HORA DE ENTREGA
        If Not IsDate(Me.txtHoraEntrega.Text) Then
            strMensajeError &= "Ingrese hora valida" & vbNewLine
        End If
        'OMVB REQ15072019 HORA DE ENTREGA


        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function ValidaContenedor(ByVal obeBultos As beBulto, ByRef strMensaje As String) As Integer
        Dim obeContenedor As New beContenedor
        Dim obrContenedor As New brContenedor

        strMensaje = "El Contenedor no se encuentra registrado"

        obeContenedor.PSCCMPN = strCCMPN
        obeContenedor.PNCCLNT = intCCLNT
        obeContenedor.PSCPRPCN = txtSigla.Text.Trim
        obeContenedor.PSNSRECN = txtNumeroContenedor.Text.Trim
        obeContenedor.PSSESCN1 = "T"
        obeContenedor.nPageNumber = 1
        obeContenedor.nPageSize = 20
        For Each obe As beContenedor In obrContenedor.ListarContenedor(obeContenedor)
            If obe.PSSESCN1 = "0" Then
                strMensaje = "El Contenedor no se encuentra disponible"
            Else
                strMensaje = ""
            End If
        Next
        If strMensaje.Length = 0 Then
            Return 1
        Else
            Return 0
        End If

    End Function


     



    Private Sub pGrabarModificaciones()
 
        ' Validamos si cumple todas las restricciones
        If Not fblnValidar() Then Exit Sub
        ' Procedemos a Grabar el Bulto
        Dim obeBulto As beBulto = New beBulto
        Dim booEstado As Boolean = False
        Dim strMensaje As String = String.Empty
        ' Valida que se obtenga el Bulto, caso contrario se sale de procedimiento
        If chkCnt.Checked Then
            If ValidaContenedor(obeBulto, strMensaje) = 0 Then
                HelpClass.MsgBox(strMensaje, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        With obeBulto
            .PSCCMPN = strCCMPN
            .PSCDVSN = strCDVSN
            .PNCPLNDV = dblCPLNDV
            .PNCCLNT = intCCLNT
            .PNNSEQIN = dblNSEQIN
            .PSCREFFW = Me.txtCodigoRecepcion.Text.Trim
            .FechaIngAlmacenCL = Me.dtpIngreso.Value.Date
            .PNQREFFW = Me.txtCantidadRecibida.Text.Trim
            .PNQAROCP = Me.txtCantidadAreaOcupada.Text.Trim
            .PSTIPBTO = Me.txtTipoBulto.Text.Trim
            .PNQPSOBL = Me.txtPesoBulto.Text.Trim
            .PSTUNPSO = Me.txtUnidadPeso.Text.Trim
            .PNQVLBTO = Me.txtVolumenBulto.Text.Trim
            .PNQMTALT = Altura
            .PNQMTANC = Ancho
            .PNQMTLRG = Largo

            .PSTUNVOL = Me.txtUnidadVolumen.Text.Trim
            .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            .PNNORAGN = Me.txtNroOrdenServicioAgencia.Text.Trim
            .PSDESCWB = Me.txtDescripcionWaybill.Text.Trim
            .PSSMTRCP = "" & Me.txtMotivoRecepcion.Tag
            .PSSSNCRG = Me.txtSentidoCarga.Tag
            .PNNTCKPS = Me.txtNroTicketBalanza.Text.Trim
            .PSSTPING = Me.txtTipoMovimiento.Tag
            .PSCBLTOR = Me.txtCodigoOrigen.Text.Trim
            .PSCREEMB = Me.txtCodigoEmbarcador.Text.Trim
            .PSTDSCIT = txtInformacionAdicional.Text.Trim

            'miguel 31.01.2014
            .PSTTPOMR = CType(TxtTipoMaterial.Resultado, beAlmacen).PSCCMPRN

            '-- Seguridad
            .PSSESTRG = "A"
            'Cambio para cliente PLuspetrol===============
            .PSTCTCST = Me.txtTerrestre.Text.Trim
            .PSTCTCSA = Me.txtAereo.Text.Trim
            .PSTCTCSF = Me.txtFluvial.Text.Trim
            .PSTCTAFE = Me.txtAfe.Text.Trim
            '=========================

            .PSTLUGOR = Me.txtOrigen.Text.Trim
            .PSTLUGEN = Me.txtEntrega.Text.Trim
            .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'Me.txtTipoAlmacen.Tag
            .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC 'Me.txtAlmacen.Tag
            .PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM 'Me.txtZonaAlmacen.Tag
            .PSNGRPRV = txtGuiaProveedor.Text.Trim
            .PSCULUSA = objSeguridadBN.pUsuario
            .PNFULTAC = Date.Now.ToString("yyyyMMdd")
            .PNHULTAC = Date.Now.ToString("hhmmss")
            .PSCPRCN1 = txtSigla.Text.Trim
            .PSNSRCN1 = txtNumeroContenedor.Text.Trim
            .PSSTPOCR = IIf(chkCnt.Checked, "1", "0")
            .PSDSREFE = Me.txtUsuarioReferencia.Text
            .FechaSolicitudMedio = IIf(dtpFechaSolicitudMedio.Checked, dtpFechaSolicitudMedio.Value, "")


            'OMVB REQ15072019 HORA DE ENTREGA
            .PNHORIDE = Me.txtHoraEntrega.Text.Replace(":", "").Trim.PadRight(6, "0")
            'OMVB REQ15072019 HORA DE ENTREGA



            '--------------------ACD-------------------

            '26102018 Alberto
            .PSTCTCAL = KryptonTextBox1.Text

            If Not txtMedioSugerido.Resultado Is Nothing Then
                .PNCMEDTS = CType(txtMedioSugerido.Resultado, Ransa.TypeDef.beGeneral).PNCMEDTR
            End If
            If Not txtTarifa.Resultado Is Nothing Then
                .PSCLSTRF = CType(txtTarifa.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            End If
            If Not txtEtiqueta.Resultado Is Nothing Then
                .PSCCLRS = CType(txtEtiqueta.Resultado, Ransa.TypeDef.beGeneral).PSCCLRS
            End If
            If Me.dtpFechaSalida.Visible Then
                .FechaSalAlmacenCL = Me.dtpFechaSalida.Value
            End If

            'MPS
            If Not txtTipoCarga.Resultado Is Nothing Then
                .PSTTPCRG = CType(txtTipoCarga.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            Else
                .PSTTPCRG = ""
            End If


            If Not ucIncidencia.Resultado Is Nothing Then
                .PSINCBLT = CType(ucIncidencia.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            Else
                .PSINCBLT = ""
            End If


            Dim obrBulto As New brBulto
            If obrBulto.fintActualizarBulto(obeBulto) Then
                If ListaPLus.Contains(intCCLNT.ToString.Trim) Then 'If intCCLNT = 30507 OrElse intCCLNT = 11731 Then
                    If .PNISDIST = 0 Then
                        InsertarCuentaImputacion()
                    End If
                End If
            End If

            'OMVB REQ08072019
            'Eliminmos los paquetes eliminados
            If olbePaquetesEliminados.Count > 0 Then
                For Each obePaquetes As beBulto In olbePaquetesEliminados
                    With obePaquetes
                        .PSCCMPN = obeBulto.PSCCMPN
                        .PSCDVSN = obeBulto.PSCDVSN
                        .PNCPLNDV = obeBulto.PNCPLNDV
                        .PNCCLNT = obeBulto.PNCCLNT
                        .PSCREFFW = obeBulto.PSCREFFW
                        .PNNSEQIN = obeBulto.PNNSEQIN
                        .PSSESTRG = "*"
                        If obrBulto.fintActualizarBultoDetalleCarga(obePaquetes) = 0 Then
                            HelpClass.ErrorMsgBox()
                            Exit Sub
                        End If
                    End With
                Next
            End If
            'Grabamos los paquetes
            If dtgPaquetesDeBulto.Rows.Count > 0 Then
                For Each obePaquetes As beBulto In dtgPaquetesDeBulto.DataSource
                    With obePaquetes
                        .PSCCMPN = obeBulto.PSCCMPN
                        .PSCDVSN = obeBulto.PSCDVSN
                        .PNCPLNDV = obeBulto.PNCPLNDV
                        .PNCCLNT = obeBulto.PNCCLNT
                        .PSCREFFW = obeBulto.PSCREFFW
                        .PNNSEQIN = obeBulto.PNNSEQIN
                        If .PNNCRRIN <> 0 Then
                            If obrBulto.fintActualizarBultoDetalleCarga(obePaquetes) = 0 Then
                                HelpClass.ErrorMsgBox()
                                Exit Sub
                            End If
                        Else
                            If obrBulto.fintInsertarBultoDetalleCarga(obePaquetes) = 0 Then
                                HelpClass.ErrorMsgBox()
                                Exit Sub
                            End If
                        End If

                    End With
                Next
            End If
            'OMVB REQ08072019

        End With
        obeBulto = Nothing

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaMotivoRecepcionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaMotivoRecepcionListar.Click
        Call mfdtBuscar_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
    End Sub

    Private Sub bsaNroTicketBalanzaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroTicketBalanzaListar.Click
        Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
        txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
    End Sub

    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click
        Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
    End Sub

    Private Sub bsaTipoBultoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoBultoListar.Click
        Call mfblnBuscar_TipoBulto(txtTipoBulto.Text)
        txtTipoBulto.Tag = txtTipoBulto.Text
    End Sub

    Private Sub bsaTipoMovimientoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoMovimientoListar.Click
        Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
    End Sub
 

    Private Sub bsaUnidadPesoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadPesoListar.Click
        Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
        txtUnidadPeso.Tag = txtUnidadPeso.Text
    End Sub

    Private Sub bsaUnidadVolumenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadVolumenListar.Click
        Call mfblnBuscar_UnidadMedida(txtUnidadVolumen.Text, "C")
        txtUnidadVolumen.Tag = txtUnidadVolumen.Text
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call pGrabarModificaciones()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmRecepcionCabecera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-- Crear status por control con F4
        booValidarServicioAtendido = False
        txtCodigoRecepcion.Enabled = False
        'OMVB REQ08072019
        dtgPaquetesDeBulto.AutoGenerateColumns = False
        'OMVB REQ08072019

        Call pMostrarBultoCabecera()
    End Sub

    Private Sub txtMotivoRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMotivoRecepcion.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfdtBuscar_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
        End If
    End Sub

    Private Sub txtMotivoRecepcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotivoRecepcion.TextChanged
        txtMotivoRecepcion.Tag = ""
    End Sub

    Private Sub txtMotivoRecepcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotivoRecepcion.Validating
        If txtMotivoRecepcion.Text = "" Then
            txtMotivoRecepcion.Tag = ""
        Else
            If txtMotivoRecepcion.Text <> "" And "" & txtMotivoRecepcion.Tag = "" Then
                Call mfdtBuscar_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
                If txtMotivoRecepcion.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtNroTicketBalanza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroTicketBalanza.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
            txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
        End If
    End Sub

    Private Sub txtNroTicketBalanza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroTicketBalanza.TextChanged
        txtNroTicketBalanza.Tag = ""
    End Sub

    Private Sub txtNroTicketBalanza_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroTicketBalanza.Validating
        If txtNroTicketBalanza.Text = "0" Or txtNroTicketBalanza.Text = "" Then
            txtPesoTicket.Text = "0.00"
            txtNroTicketBalanza.Tag = ""
        Else
            If txtNroTicketBalanza.Text <> "0" And txtNroTicketBalanza.Text <> "" And "" & txtNroTicketBalanza.Tag = "" Then
                Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
                txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
                If txtNroTicketBalanza.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoBulto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoBulto.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_TipoBulto(txtTipoBulto.Text)
            txtTipoBulto.Tag = txtTipoBulto.Text
        End If
    End Sub

    Private Sub txtTipoBulto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoBulto.TextChanged
        txtTipoBulto.Tag = ""
    End Sub

    Private Sub txtTipoBulto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoBulto.Validating
        If txtTipoBulto.Text = "" Then
            txtTipoBulto.Tag = ""
        Else
            If txtTipoBulto.Text <> "" And "" & txtTipoBulto.Tag = "" Then
                Call mfblnBuscar_TipoBulto(txtTipoBulto.Text)
                txtTipoBulto.Tag = txtTipoBulto.Text
                If txtTipoBulto.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
        End If
    End Sub

    Private Sub txtTipoMovimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMovimiento.TextChanged
        txtTipoMovimiento.Tag = ""
    End Sub

    Private Sub txtTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoMovimiento.Validating
        If txtTipoMovimiento.Text = "" Then
            txtTipoMovimiento.Tag = ""
        Else
            If txtTipoMovimiento.Text <> "" And "" & txtTipoMovimiento.Tag = "" Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
                If txtTipoMovimiento.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
        End If
    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating
        If txtSentidoCarga.Text = "" Then
            txtSentidoCarga.Tag = ""
        Else
            If txtSentidoCarga.Text <> "" And "" & txtSentidoCarga.Tag = "" Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                If txtSentidoCarga.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
 

    Private Sub txtUnidadPeso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadPeso.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
        End If
    End Sub

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadPeso.Validating
        If txtUnidadPeso.Text = "" Then
            txtUnidadPeso.Tag = ""
        Else
            If txtUnidadPeso.Text <> "" And "" & txtUnidadPeso.Tag = "" Then
                Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
                txtUnidadPeso.Tag = txtUnidadPeso.Text
                If txtUnidadPeso.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtUnidadVolumen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadVolumen.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_UnidadMedida(txtUnidadVolumen.Text, "V")
            txtUnidadVolumen.Tag = txtUnidadVolumen.Text
        End If
    End Sub

    Private Sub txtUnidadVolumen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidadVolumen.TextChanged
        txtUnidadVolumen.Tag = ""
    End Sub

    Private Sub txtUnidadVolumen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadVolumen.Validating
        If txtUnidadVolumen.Text = "" Then
            txtUnidadVolumen.Tag = ""
        Else
            If txtUnidadVolumen.Text <> "" And "" & txtUnidadVolumen.Tag = "" Then
                Call mfblnBuscar_UnidadMedida(txtUnidadVolumen.Text, "V")
                txtUnidadVolumen.Tag = txtUnidadVolumen.Text
                If txtUnidadVolumen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub txtMedioSugerido_ActivarAyuda(ByRef objData As Object)
        'dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strData)

        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
        'With obeMedioTransporte
        '    .PNCMEDTR= 
        'End With
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub


    Private Sub txtMedioSugerido_CambioDeTexto1(ByVal strData As String, ByRef objData As Object)
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New RANSA.NEGO.brGeneral
            Dim obeMedioTransporte As New RANSA.TYPEDEF.beGeneral
            With obeMedioTransporte
                .PNCMEDTR = Val(strData)
                .PSTNMMDT = strData
            End With
            objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        End If

    End Sub


    Private Sub btnAdjuntarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntarGuia.Click
        Dim obeDocumento As New BeDocumento

        If Me.txtCodigoRecepcion.Text.Trim.Equals("") Then Exit Sub
        Dim strTipo As String = "GUIA PROV"
        Dim strNombreDocumento As String = txtCodigoRecepcion.Text
        Dim strDireccion As String = "SOLMIN_SA/" & intCCLNT.ToString.Trim & "/" & strTipo

        Dim obrCargarImagen As New brCargarImagen

        With obeDocumento
            .PNCCLNT = intCCLNT
            .PSNDOCUM = strNombreDocumento
            .PSTIPODC = strTipo
            .PSCUSCRT = objSeguridadBN.pUsuario
            .PSSESTRG = "A"
        End With
        strNombreDocumento = strNombreDocumento & "_" & obeDocumento.PNNCRRDC.ToString
        Dim objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
        If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
            obeDocumento.EXTENCION = obrCargarImagen.GetFileExtencion(strDireccion, strNombreDocumento)
            strNombreDocumento = strNombreDocumento & obeDocumento.EXTENCION
            If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then
                With obeDocumento
                    .PSTOBSMD = "Guía de Proveedor"
                    .PSTNMBAR = strNombreDocumento
                    .PSURLARC = HelpClass.getURLDocLinksSolAlmacen() & strDireccion
                    .PSCULUSA = objSeguridadBN.pUsuario
                End With
                GrabarDocumento(obeDocumento)
            End If
        End If

    End Sub

    Private Function GrabarDocumento(ByVal obeDocumento As BeDocumento) As Integer
        Dim obrDocumento As New brDocumento
        Dim intResultado As Integer = 0
        intResultado = obrDocumento.DocumentoAlmacenInsertar(obeDocumento)
        If intResultado = 0 Then
            HelpClass.ErrorMsgBox()
            Return intResultado
        End If
        Return intResultado
    End Function

    Private Sub UcMedioTransporte1_ActivarAyuda(ByRef objData As Object)
        'dtEntidad = clsGeneral.fdtBuscar_TipoBulto(strMensajeError, strData)

        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
        'With obeMedioTransporte
        '    .PNCMEDTR= 
        'End With
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub


    Private Sub UcMedioTransporte1_CambioDeTexto1(ByVal strData As String, ByRef objData As Object)
        If Not strData.Trim.Equals("") Then
            Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
            Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral
            With obeMedioTransporte
                .PNCMEDTR = Val(strData)
                .PSTNMMDT = strData
            End With
            objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        End If

    End Sub

    Private Sub InsertarCuentaImputacion()
        If Me.txtTerrestre.Text.Trim.ToString.Equals("") AndAlso Me.txtAereo.Text.Trim.ToString.Equals("") AndAlso Me.txtFluvial.Text.Trim.ToString.Equals("") AndAlso Me.txtAfe.Text.ToString.Equals("") Then Exit Sub
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim obeOrdenCompra As New beOrdenCompra
        With obeOrdenCompra
            .PNCCLNT = intCCLNT
            .PSNORCML = _strNORCML
            .PSTCTCST = Me.txtTerrestre.Text
            .PSTCTCSA = Me.txtAereo.Text
            .PSTCTCSF = Me.txtFluvial.Text
            .PSTCTAFE = Me.txtAfe.Text
            .PSUSUARIO = objSeguridadBN.pUsuario
            .PSNTRMNL = objSeguridadBN.pstrPCName
            '.PSTLUGEN = Me.cm
            If Not txtMedioSugerido.Resultado Is Nothing Then
                .PNCMEDTS = CType(txtMedioSugerido.Resultado, Ransa.TYPEDEF.beGeneral).PNCMEDTR
            End If
        End With
        If obrOrdenCompra.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenCompra) = 0 Then
            HelpClass.ErrorMsgBox()
        End If
    End Sub

 

    Private Sub CargarControles()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        Dim obeFiltro As New beMercaderia
        Me.txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        Me.txtTipoAlmacen.ListColumnas = oListColum
        Me.txtTipoAlmacen.Cargas()
        Me.txtTipoAlmacen.ValueMember = "PSCTPALM"
        Me.txtTipoAlmacen.DispleyMember = "PSTALMC"

        Dim objNegocio As New brUbicacionesXCliente

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR_1"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTUBRFR"
        oColumnas.DataPropertyName = "PSTUBRFR"
        oColumnas.HeaderText = "Ubicación "
        oColumnas.Visible = False
        oListColum.Add(2, oColumnas)
        txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(intCCLNT)
        txtUbicacionReferencial.ListColumnas = oListColum
        txtUbicacionReferencial.Cargas()
        txtUbicacionReferencial.Limpiar()
        txtUbicacionReferencial.ValueMember = "PSTUBRFR"
        txtUbicacionReferencial.DispleyMember = "PSTUBRFR"


        Dim obrGeneral As New brGeneral
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)
        txtTarifa.DataSource = obrGeneral.olstListaTarifa()
        txtTarifa.ListColumnas = oListColum
        txtTarifa.Cargas()
        txtTarifa.Limpiar()
        txtTarifa.ValueMember = "PSCCMPRN"
        txtTarifa.DispleyMember = "PSTDSDES"

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCLRS"
        oColumnas.DataPropertyName = "PSCCLRS"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TABCLR"
        oColumnas.DataPropertyName = "PSTABCLR"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)
        txtEtiqueta.DataSource = obrGeneral.flstListaColores()
        txtEtiqueta.ListColumnas = oListColum
        txtEtiqueta.Cargas()
        txtEtiqueta.Limpiar()
        txtEtiqueta.ValueMember = "PSCCLRS"
        txtEtiqueta.DispleyMember = "PSTABCLR"

        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TYPEDEF.beGeneral


        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNCMEDTR"
        oColumnas.DataPropertyName = "PNCMEDTR"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTNMMDT"
        oColumnas.DataPropertyName = "PSTNMMDT"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)
        txtMedioSugerido.DataSource = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
        txtMedioSugerido.ListColumnas = oListColum
        txtMedioSugerido.Cargas()
        txtMedioSugerido.Limpiar()
        txtMedioSugerido.ValueMember = "PNCMEDTR"
        txtMedioSugerido.DispleyMember = "PSTNMMDT"

        'miguel 
        Dim obeAlmacen As New beAlmacen

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Tipo Movimiento "
        oListColum.Add(2, oColumnas)
        ' Dim obrAlmacen As New brAlmacen

        obeAlmacen.PSCODVAR = "TIPMAT"
        obeAlmacen.PSCCMPRN = ""
        TxtTipoMaterial.DataSource = obrAlmacen.ListaTipoDeMaterial(obeAlmacen)
        TxtTipoMaterial.ListColumnas = oListColum
        TxtTipoMaterial.Cargas()
        TxtTipoMaterial.ValueMember = "PSCCMPRN"
        TxtTipoMaterial.DispleyMember = "PSTDSDES"

        'mps

        Dim obeTipoCarga As New beGeneral

        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Tipo Carga "
        oListColum.Add(2, oColumnas)
        'Dim obrAlmacen As New brAlmacen

        obeTipoCarga.PSCODVAR = "SATPCG"
        obeAlmacen.PSTTPOMR = ""
        txtTipoCarga.DataSource = obrGeneral.ListaTablaAyuda(obeTipoCarga)
        txtTipoCarga.ListColumnas = oListColum
        txtTipoCarga.Cargas()
        txtTipoCarga.ValueMember = "PSCCMPRN"
        txtTipoCarga.DispleyMember = "PSTDSDES"



        Dim obeIncidencia As New beGeneral
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Incidencia"
        oListColum.Add(2, oColumnas)

        obeIncidencia.PSCODVAR = "SAICBL"
        ucIncidencia.DataSource = obrGeneral.ListaTablaAyuda(obeIncidencia)
        ucIncidencia.ListColumnas = oListColum
        ucIncidencia.Cargas()
        ucIncidencia.ValueMember = "PSCCMPRN"
        ucIncidencia.DispleyMember = "PSTDSDES"


    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        Dim obeFiltro As New beMercaderia
        '  CType(objData, beAlmacen).PNCPLNFC = dblCPLNDV
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = dblCPLNDV
            Dim obrMercaderia As New brMercaderia
            Me.txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            Me.txtAlmacen.DataSource = Nothing
        End If
        Me.txtAlmacen.ListColumnas = oListColum
        Me.txtAlmacen.Cargas()
        Me.txtAlmacen.Limpiar()
        Me.txtAlmacen.ValueMember = "PSCALMC"
        Me.txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub txtAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNALM"
        oColumnas.DataPropertyName = "PSCZNALM"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMZNA"
        oColumnas.DataPropertyName = "PSTCMZNA"
        oColumnas.HeaderText = "Zona Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        Dim obeFiltro As New beMercaderia

        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = dblCPLNDV
            Me.txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            Me.txtZonaAlmacen.DataSource = Nothing
        End If
        Me.txtZonaAlmacen.ListColumnas = oListColum
        Me.txtZonaAlmacen.Cargas()
        Me.txtZonaAlmacen.Limpiar()
        Me.txtZonaAlmacen.ValueMember = "PSCZNALM"
        Me.txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub

    Private Sub btnAyudaContenedorListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call mfblnBuscar_Contenedor(strCCMPN, intCCLNT, txtSigla.Text, txtNumeroContenedor.Text)
    End Sub

    Private Sub bsaVolumenBultoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVolumenBulto.Click
        Dim fObtenerVolumenBulto As frmObtenerVolumenBulto = New frmObtenerVolumenBulto
        With fObtenerVolumenBulto
            .QMTALT_1 = Altura 'PNQMTALT 
            .QMTANC_1 = Ancho
            .QMTLRG_1 = Largo
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Altura = .QMTALT_1
                Ancho = .QMTANC_1
                Largo = .QMTLRG_1

                Dim VolumenBulto As Double = 0
                VolumenBulto = Altura * Ancho * Largo
                VolumenBulto = Math.Round(VolumenBulto, 2)
                Dim valor As Long = Int(Altura * Ancho * Largo)
                If CType(valor, String).Length > 15 Then
                    MessageBox.Show("El Calculo del Volumen supera al número de Digitos permitidos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtVolumenBulto.Text = "0.00"
                    Exit Sub
                Else
                    txtVolumenBulto.Text = VolumenBulto.ToString
                End If
                If VolumenBulto > 0 Then
                    Estado = True
                Else
                    Estado = False
                End If

            End If
        End With
    End Sub

    Private Sub txtVolumenBulto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenBulto.KeyPress
        'If Estado = True Then
        '    If CType(txtVolumenBulto.Text, Double) = 0 Then
        '        e.Handled = False
        '    Else
        '        e.Handled = True
        '    End If
        'End If
        If Altura > 0 And Ancho > 0 And Largo > 0 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    'OMVB REQ08072019
    Private olbePaquetesEliminados As New List(Of beBulto)

    Private Sub tsbEliminarPaquete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPaquete.Click
        If Me.dtgPaquetesDeBulto.CurrentCellAddress.Y = -1 Then Exit Sub
        If CType(Me.dtgPaquetesDeBulto.CurrentRow.DataBoundItem, beBulto).PNNCRRIN <> 0 Then
            olbePaquetesEliminados.Add(Me.dtgPaquetesDeBulto.CurrentRow.DataBoundItem)
        End If
        BeBultoBindingSource.RemoveCurrent()
        Me.dtgPaquetesDeBulto_CellEndEdit(dtgPaquetesDeBulto, Nothing)
    End Sub

    Private Sub tsbAgregarPaquete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPaquete.Click
        Dim obeBulto As New beBulto
        BeBultoBindingSource.Add(obeBulto)
        If Me.dtgPaquetesDeBulto.RowCount > 1 Then
            Me.dtgPaquetesDeBulto.ClearSelection()
            Me.dtgPaquetesDeBulto.CurrentCell = Me.dtgPaquetesDeBulto.Rows(Me.dtgPaquetesDeBulto.RowCount + 1 - 2).Cells(0)
            Me.dtgPaquetesDeBulto.Refresh()
        End If
    End Sub

    Private Sub dtgPaquetesDeBulto_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPaquetesDeBulto.CellEndEdit
        Dim intPeso As Decimal = 0
        Dim intVolumen As Decimal = 0
        Dim M2 As Decimal = 0
        Dim CantPaquetes As Decimal = 0
        For Each obeBulto As beBulto In Me.dtgPaquetesDeBulto.DataSource
            If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0 OrElse obeBulto.PNQCTPQT <> 0) Then
                intPeso += Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQPSOMR, 2)
                intVolumen += obeBulto.VOLUMENPAQUETE
                'M2 = M2 + obeBulto.PNQCTPQT * Math.Round(obeBulto.PNQMTLRG, 2) * Math.Round(obeBulto.PNQMTANC, 2)
                M2 = M2 + Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC, 2)
                CantPaquetes = CantPaquetes + obeBulto.PNQCTPQT
            End If
        Next
        Me.txtPesoBulto.Text = Math.Round(intPeso, 3)
        Me.txtVolumenBulto.Text = Math.Round(intVolumen, 3)
        txtCantidadAreaOcupada.Text = M2
        txtCantidadRecibida.Text = CantPaquetes
    End Sub
    'OMVB REQ08072019

    'OMVB REQ15072019 HORA DE ENTREGA
    Private Sub txtHoraEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraEntrega.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'OMVB REQ15072019 HORA DE ENTREGA


End Class

