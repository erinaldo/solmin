' Librerías del Framework  
Imports System.IO
Imports System
Imports System.Text

' Librerías del Proyecto
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Utilitario
Imports Ransa.DAO.WayBill
Imports Ransa.TypeDef.WayBill
Imports Ransa.DAO.OrdenCompra
Imports System.ComponentModel
Imports Ransa.NEGO
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.TypeDef
Public Class frmGenerarBultoN
    Public Const ProcesoExitoso As String = "S"
    Public Const ErrorProceso As String = "E"
    Public Const ErrorComunicacion As String = "F"
    Public Const ErrorConexion As String = "C"

    Private ListaPLus As New Hashtable



#Region " Atributos "
    Private intCCLNT As Int64 = 0
    Private CCLNT As Int64 = 0
    Private strNORCML As String = ""
    Private blnStatusBultoNormal As Boolean = True
    Private booStatusCargaDG As Boolean = False
    Private lstItems As List(Of TD_ItemOCForWayBill) = New List(Of Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill)
    Private lstTotalItems As List(Of TD_ItemOCForWayBill) = New List(Of Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCForWayBill)
    Private oHasSubItems As Hashtable
    Private blnIsParcial As Boolean
    Private oItemWaybill As cItemWayBill = New Ransa.DAO.WayBill.cItemWayBill(objSeguridadBN.pUsuario)
    Private strCompania As String = ""
    Private strDivision As String = ""
    Private dblPlanta As Double = 0
    Private strNrBultoInicial As String = ""
    Private _pEstado As String = ""
    Private obeDocumento As New BeDocumento
    Public strDesPlanta As String
    Private strLugarEntrega As String
    Private Altura As Double = 0
    Private Ancho As Double = 0
    Private Largo As Double = 0
    Private Estado As Boolean = False


#End Region

#Region " Propiedades "

    Public Property pEstado() As String
        Get
            Return _pEstado
        End Get
        Set(ByVal value As String)
            _pEstado = value
        End Set
    End Property
    Public Property CodigoCliente() As Int64
        Get
            Return CCLNT
        End Get
        Set(ByVal value As Int64)
            CCLNT = value
        End Set
    End Property
    Public WriteOnly Property pCodigoCliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    Public WriteOnly Property pNORCML_NroOrdenCompra() As String
        Set(ByVal value As String)
            strNORCML = value
        End Set
    End Property

    Public WriteOnly Property pStatusBultoNormal() As Boolean
        Set(ByVal value As Boolean)
            blnStatusBultoNormal = value
        End Set
    End Property

    Public WriteOnly Property pCompania() As String
        Set(ByVal value As String)
            strCompania = value
        End Set
    End Property
    Public WriteOnly Property pDivision() As String
        Set(ByVal value As String)
            strDivision = value
        End Set
    End Property
    Public WriteOnly Property pPlanta() As Double
        Set(ByVal value As Double)
            dblPlanta = value
        End Set
    End Property

    ''' <summary>
    ''' Visualiza Cantidades Solicitada, Pendiente
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>

    <Browsable(False)> _
    Public WriteOnly Property pVisualizarCantidades() As Boolean
        Set(ByVal value As Boolean)
            dgOrdenComprasSeleccionados.Columns("D_QCNTIT").Visible = value
            dgOrdenComprasSeleccionados.Columns("D_QCNPEN").Visible = value

            If value Then

               
                Me.D_QCNREC.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                Me.D_QCNREC.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            End If
            dgOrdenComprasSeleccionados.Columns("D_TUNDIT").Visible = Not value
            dgOrdenComprasSeleccionados.Columns("D_QPEPQT").Visible = Not value
            dgOrdenComprasSeleccionados.Columns("D_TUNPSO").Visible = Not value
            dgOrdenComprasSeleccionados.Columns("D_QVOPQT").Visible = Not value
            dgOrdenComprasSeleccionados.Columns("D_TUNVOL").Visible = Not value
        End Set
    End Property

    Public WriteOnly Property pSoloLectura_QCNREC() As Boolean
        Set(ByVal value As Boolean)
            dgOrdenComprasSeleccionados.Columns("D_QCNREC").ReadOnly = value
        End Set
    End Property

    Public WriteOnly Property pSoloLectura_TDAITM() As Boolean
        Set(ByVal value As Boolean)
            dgOrdenComprasSeleccionados.Columns("D_TDAITM").ReadOnly = value
        End Set
    End Property

    Public WriteOnly Property pItemsSelec() As List(Of TD_ItemOCForWayBill)
        Set(ByVal value As List(Of TD_ItemOCForWayBill))
            lstItems = value
        End Set
    End Property

    Public WriteOnly Property pTotalItems() As List(Of TD_ItemOCForWayBill)
        Set(ByVal value As List(Of TD_ItemOCForWayBill))
            lstTotalItems = value
        End Set
    End Property

    Public WriteOnly Property poHasSubItems() As Hashtable
        Set(ByVal value As Hashtable)
            oHasSubItems = value
        End Set
    End Property
#End Region

#Region " Funciones y Procedimientos "
    Private Function fblnValidar() As Boolean
        Dim strMensajeError As String = ""

        If txtCodigoRecepcion.Text = "" Then _
            strMensajeError &= "Debe ingresar Nro. de Recepción..." & vbNewLine
        If txtTipoMovimiento.Text = "" Then _
            strMensajeError &= "Debe ingresar un Tipo de Movimiento..." & vbNewLine
        If txtTipoBulto.Text = "" Then _
            strMensajeError &= "Debe ingresar un Tipo de Bulto..." & vbNewLine
        If txtCantidadRecibida.Text <= 0 Then _
            strMensajeError &= "Debe ingresar Cantidad Recibida mayor a Cero..." & vbNewLine
        If txtCantidadAreaOcupada.Text = "" Then _
            strMensajeError &= "Debe ingresar la Cantidad de Área Ocupada..." & vbNewLine
        If txtMotivoRecepcion.Text = "" Then _
            strMensajeError &= "Debe seleccionar un Motivo de Recepción..." & vbNewLine
        If txtSentidoCarga.Text = "" Then _
            strMensajeError &= "Debe seleccionar el Sentido de la Carga..." & vbNewLine
        If txtUbicacionReferencial.Resultado Is Nothing Then _
            strMensajeError &= "Debe ingresar una Ubicación para el Bulto creado..." & vbNewLine
        If txtDescripcionWaybill.Text = "" Then _
            strMensajeError &= "Debe ingresar una Descripción para el Bulto creado..." & vbNewLine
        If txtNroGuiaProveedor.Text = "" Then _
            strMensajeError &= "Debe ingresar Nro. Guía de Proveedor..." & vbNewLine
        If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén." & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén" & vbNewLine
        If txtZonaAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar una Zona de Almacén." & vbNewLine
        If TxtTipoMaterial.Resultado Is Nothing Then strMensajeError &= "Debe Selecionar un tipo de material." & vbNewLine
        If txtSentidoCarga.Tag <> "" Then
            If txtSentidoCarga.Tag = "2" Then
              
                If ListaPLus.Contains(intCCLNT) Then '  = 30507 ' Or intCCLNT = 11731 Then
                    If txtEntrega.Text.Trim.Length = 0 Then
                        strMensajeError &= "Ingrese Lugar de entrega." & vbNewLine
                    End If
                End If
            End If
        End If


        'MPS
        If ListaPLus.Contains(intCCLNT.ToString.Trim) Then '  = 30507 ' Or intCCLNT = 11731 Then
            If txtTipoCarga.Resultado Is Nothing Then
                strMensajeError &= "Debe ingresar Tipo de Carga." & vbNewLine
            End If
        End If

        If chkCnt.Checked Then
            If txtSigla.Text.Trim.Length = 0 Or txtNumeroContenedor.Text.Trim.Length = 0 Then
                If txtSigla.Text.Trim.Length = 0 Then strMensajeError &= "- Ingrese Sigla de Contenedor" & vbNewLine
                If txtNumeroContenedor.Text.Trim.Length = 0 Then strMensajeError &= "- Ingrese Número de Contenedor" & vbNewLine
            End If
        Else
            If txtSigla.Text.Trim.Length <> 0 And txtNumeroContenedor.Text.Trim.Length = 0 Then
                strMensajeError &= "- Ingrese Número de Contenedor" & vbNewLine
            ElseIf txtSigla.Text.Trim.Length = 0 And txtNumeroContenedor.Text.Trim.Length <> 0 Then
                strMensajeError &= "- Ingrese Sigla de Contenedor" & vbNewLine
            End If
        End If

        
        'OMVB REQ15072019 HORA DE ENTREGA
        If Not IsDate(Me.txtHoraEntrega.Text) Then
            strMensajeError &= "Ingrese hora válida" & vbNewLine
        End If
        'OMVB REQ15072019 HORA DE ENTREGA


        If Me.dtgPaquetesDeBulto.Rows.Count > 0 Then
            Dim strErrorCan As String = String.Empty
            Dim strErrorAl As String = String.Empty
            Dim strErrorAn As String = String.Empty
            Dim strErrorLag As String = String.Empty

            Dim intQBulto As Decimal = 0
            Dim dbPesoBulto As Decimal = 0
            Dim dbVolumenBulto As Decimal = 0


            'Dim dbAreaBulto As Decimal = 0  'OMVB REQ08072019

            For Each obeBulto As beBulto In dtgPaquetesDeBulto.DataSource
                intQBulto += obeBulto.PNQCTPQT
                'dbPesoBulto += obeBulto.PNQPSOMR
                dbPesoBulto += Math.Round(obeBulto.PNQPSOMR * obeBulto.PNQCTPQT, 2)
                dbVolumenBulto += obeBulto.VOLUMENPAQUETE

                'dbAreaBulto += obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC 'OMVB REQ08072019

                If obeBulto.PNQCTPQT = 0 And strErrorCan.Length = 0 Then
                    strErrorCan = "La Cantidad Recibida Paquete no debe de ser igual a Cero" & vbNewLine
                End If

                ' If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0) Then    'OMVB 08072019
                If obeBulto.PNQMTLRG = 0 And strErrorLag.Length = 0 Then
                    strErrorAl = "El Largo del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
                If obeBulto.PNQMTANC = 0 And strErrorAn.Length = 0 Then
                    strErrorAn = "El Ancho del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
                If obeBulto.PNQMTALT = 0 And strErrorAl.Length = 0 Then
                    strErrorLag = "El Alto del Paquete no debe de ser igual a Cero" & vbNewLine
                End If
                'End If   'OMVB 08072019

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

            ''OMVB REQ08072019
            'If Math.Round(Decimal.Parse(txtCantidadAreaOcupada.Text), 3) <> Math.Round(dbAreaBulto, 3) Then
            '    strMensajeError &= "El área de la Recepción no es igual a la suma de áreas de los Paquetes" & vbNewLine
            'End If
            ''OMVB REQ08072019

        End If

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function IsParcial() As Boolean
        blnIsParcial = False
        For Each p As TD_ItemOCForWayBill In lstTotalItems
            For Each t As TD_ItemOCForWayBill In lstItems
                If p.pNRITOC_NroItemOC = t.pNRITOC_NroItemOC Then
                    If p.pQCNREC_QtaRecibida = t.pQCNREC_QtaRecibida Then
                        blnIsParcial = False
                        Exit For
                    Else
                        blnIsParcial = True
                        Exit For
                    End If
                End If
                blnIsParcial = True
            Next
            If blnIsParcial = True Then Exit For
        Next
        Return blnIsParcial
    End Function

    Private Sub pAlistarNuevoIngreso()
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


        Dim ListaCltEtiqueta As New List(Of beGeneral)
        Dim obeEtiqueta As New beGeneral
        obeEtiqueta.PSCODVAR = "SAFSBT"
        obeEtiqueta.PSCCMPRN = intCCLNT
        ListaCltEtiqueta = obrGeneral.ListaTablaAyuda(obeEtiqueta)
        If ListaCltEtiqueta.Count > 0 Then
            rdFormatoBultoMineria.Checked = True
        End If

      

        If txtCodigoRecepcion.Text.ToString.Trim.Length = 0 Then
            If mfblnObtener_NroBulto(False, txtCodigoRecepcion.Text, intCCLNT, strCompania, strDivision, dblPlanta) Then
                strNrBultoInicial = txtCodigoRecepcion.Text
                dteFechaRecepcion.Value = Date.Now
                booStatusCargaDG = True
                ' Valores por defecto
                'Se agrego como ayuda 
                CargarCodigoUsado()
                txtUnidadPeso.Text = "KGS"
                txtUnidadVolumen.Text = "MT3"
                Call txtUnidadPeso_Validating(Nothing, Nothing)
                Call txtUnidadVolumen_Validating(Nothing, Nothing)
                Call mfdtDefecto_TipoMovimiento(blnStatusBultoNormal, txtTipoMovimiento.Tag, txtTipoMovimiento.Text, pEstado)
                Call mstrDefecto_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                Call mstrDefecto_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
                Call CargarControles()
                If IsParcial() Then
                    lblCabecera.Text = "OC: " & strNORCML & " - " & "Parcial: " & mfstrObtener_NroParcial(strNORCML, intCCLNT)
                Else
                    lblCabecera.Text = "OC: " & strNORCML
                End If
            End If
        Else
            strNrBultoInicial = ""
            dteFechaRecepcion.Value = Date.Now
            booStatusCargaDG = True
            ' Valores por defecto
            'Se agrego como ayuda 
            CargarCodigoUsado()
            txtUnidadPeso.Text = "KGS"
            txtUnidadVolumen.Text = "MT3"
            TxtTipoMaterial.Valor = "NORMAL"
            Call txtUnidadPeso_Validating(Nothing, Nothing)
            Call txtUnidadVolumen_Validating(Nothing, Nothing)
            Call mfdtDefecto_TipoMovimiento(blnStatusBultoNormal, txtTipoMovimiento.Tag, txtTipoMovimiento.Text, pEstado)
            Call mstrDefecto_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
            Call mstrDefecto_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
            Call CargarControles()
            Call CargarControlesTipoMaterial()
            If IsParcial() Then
                lblCabecera.Text = "OC: " & strNORCML & " - " & "Parcial: " & mfstrObtener_NroParcial(strNORCML, intCCLNT)
            Else
                lblCabecera.Text = "OC: " & strNORCML
            End If
            'OMVB REQ15072019 HORA ENTREGA
            ' Dim horaActual As New DateTime(DateTime.Now.TimeOfDay.Ticks)
            ' txtHoraEntrega.Text = horaActual
            txtHoraEntrega.Text = Format(Now, "HH:mm")
            'OMVB REQ15072019 HORA ENTREGA

        End If

    End Sub

    Private Function ValidaContenedor(ByVal obeBultos As beBulto, ByRef strMensaje As String) As Integer
        Dim obeContenedor As New beContenedor
        Dim obrContenedor As New brContenedor
        strMensaje = "El Contenedor no se encuentra registrado"
        obeContenedor.PSCCMPN = obeBultos.PSCCMPN
        obeContenedor.PNCCLNT = obeBultos.PNCCLNT
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

    ''' <summary>
    ''' Graba nuevo bulto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pGrabarBultoConDetalle()

        'Dim olistTD_SubItemOC As New List(Of Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC)
        Dim olbeSubItemOC As New List(Of Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC)
        BeBultoBindingSource.EndEdit()

        If Not fblnValidar() Then Exit Sub

        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
        Dim validarMatPel As String = ValidacionCamposGrilla().Trim
        If validarMatPel <> "" Then
            MessageBox.Show(validarMatPel, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN


        Dim obeBulto As beBulto = New beBulto
        Dim obrBulto As New brBulto
        ' REGISTRAMOS EL BULTO
        With obeBulto
            .PNCCLNT = intCCLNT
            .PSCCMPN = strCompania
            .PSCDVSN = strDivision
            .PNCPLNDV = dblPlanta
            .PNNSEQIN = 1

            ' Verificando la Codificación del Bulto
            Dim strCodigoBultoDefinitivo As String = ""
            If Not mfblnObtener_NroBulto(False, strCodigoBultoDefinitivo, intCCLNT, strCompania, strDivision, dblPlanta) Then Exit Sub
            If strCodigoBultoDefinitivo = txtCodigoRecepcion.Text.Trim Then
                If Not mfblnObtener_NroBulto(True, strCodigoBultoDefinitivo, intCCLNT, strCompania, strDivision, dblPlanta) Then Exit Sub
                If strCodigoBultoDefinitivo <> txtCodigoRecepcion.Text.Trim Then
                    MessageBox.Show("Se ha asignado un Nuevo Nro. de Bulto." & vbNewLine & _
                                    "Bulto No " & strCodigoBultoDefinitivo, _
                                    "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCodigoRecepcion.Text = strCodigoBultoDefinitivo
                End If
            Else
                'Si cumple esta condicion el registro de codigo bulto es manual
                If strNrBultoInicial = txtCodigoRecepcion.Text Then
                    If Not mfblnObtener_NroBulto(True, strCodigoBultoDefinitivo, intCCLNT, strCompania, strDivision, dblPlanta) Then Exit Sub
                    If strCodigoBultoDefinitivo <> txtCodigoRecepcion.Text.Trim Then
                        MessageBox.Show("Se ha asignado un Nuevo Nro. de Bulto." & vbNewLine & _
                                        "Bulto No " & strCodigoBultoDefinitivo, _
                                        "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCodigoRecepcion.Text = strCodigoBultoDefinitivo
                    End If
                Else
                    obeBulto.PSCREFFW = txtCodigoRecepcion.Text
                    'Verificamos que no exista el bulto
                    If obrBulto.floObjtenerBulto(obeBulto).PSCREFFW <> "" Then
                        MessageBox.Show("Error, el Nro. de Bulto :" & txtCodigoRecepcion.Text & " ya encuentra registrada", _
                                                                "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If

            ' Final de la Verificación de la codificación del Bulto
            .PSCREFFW = txtCodigoRecepcion.Text.Trim
            .FechaIngAlmacenCL = dteFechaRecepcion.Value.Date
            .FechaIngAlmacen = dteFechaRecepcion.Value.Date
            .PNQREFFW = txtCantidadRecibida.Text
            Decimal.TryParse(txtCantidadAreaOcupada.Text, .PNQAROCP)
            .PSTIPBTO = txtTipoBulto.Text
            .PNQPSOBL = txtPesoBulto.Text
            .PSTUNPSO = txtUnidadPeso.Text
            .PNQVLBTO = txtVolumenBulto.Text
            .PSTUNVOL = txtUnidadVolumen.Text
            .FechaIngAlmacen = dteFechaRecepcion.Value
            .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            .PNNORAGN = txtNroOrdenServicioAgencia.Text
            .PSDESCWB = txtDescripcionWaybill.Text
            .PSSMTRCP = "" & txtMotivoRecepcion.Tag
            .PSSSNCRG = txtSentidoCarga.Tag
            .PNNTCKPS = txtNroTicketBalanza.Text
            .PSSTPING = txtTipoMovimiento.Tag
            .PSCBLTOR = txtCodigoOrigen.Text
            .PSCREEMB = txtCodigoEmbarcador.Text
            .PSTDSCIT = txtInformacionAdicional.Text
            .PSNORCML = strNORCML
            .PSTLUGOR = txtOrigen.Text
            .PSTLUGEN = txtEntrega.Text
            .PSDSREFE = txtUsuarioReferencia.Text
            'Cambio para cliente PLuspetrol===============
            .PSTCTCST = txtTerrestre.Text
            .PSTCTCSA = txtAereo.Text
            .PSTCTCSF = txtFluvial.Text

            'Alberto 26-10-2018
            .PSTCTCAL = KryptonTextBox1.Text.Trim

            .PSTCTAFE = txtAfe.Text
            .PNQMTALT = Altura
            .PNQMTANC = Ancho
            .PNQMTLRG = Largo

            .PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'txtTipoAlmacen.Tag
            .PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC 'txtAlmacen.Tag
            .PSCZNALM = CType(txtZonaAlmacen.Resultado, beAlmacen).PSCZNALM 'txtZonaAlmacen.Tag
            .PSTTPOMR = CType(TxtTipoMaterial.Resultado, beAlmacen).PSCCMPRN

            If .PSTTPOMR = "" Then
                .PSTTPOMR = "NORMAL"

            End If

            .PSUSUARIO = objSeguridadBN.pUsuario
            .PNFCHCRT = Date.Now.ToString("yyyyMMdd")
            .PNHRACRT = Date.Now.ToString("hhmmss")
            .PSCULUSA = objSeguridadBN.pUsuario
            .PNFULTAC = Date.Now.ToString("yyyyMMdd")
            .PNHULTAC = Date.Now.ToString("hhmmss")
            If Not txtMedioSugerido.Resultado Is Nothing Then
                .PNCMEDTS = CType(txtMedioSugerido.Resultado, Ransa.TypeDef.beGeneral).PNCMEDTR
            End If
            .PSCPRCN1 = txtSigla.Text.Trim
            .PSNSRCN1 = txtNumeroContenedor.Text.Trim
            .PSSTPOCR = IIf(chkCnt.Checked, "1", "0")
            .PNISPARCIAL = IIf(blnIsParcial = True, 1, 0)
            If Not txtTarifa.Resultado Is Nothing Then
                .PSCLSTRF = CType(txtTarifa.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            End If
            If Not txtEtiqueta.Resultado Is Nothing Then
                .PSCCLRS = CType(txtEtiqueta.Resultado, Ransa.TypeDef.beGeneral).PSCCLRS
            End If
            .FechaSolicitudMedio = IIf(dtpFechaSolicitudMedio.Checked, dtpFechaSolicitudMedio.Value, "")

            'MPS
            If Not txtTipoCarga.Resultado Is Nothing Then
                .PSTTPCRG = CType(txtTipoCarga.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            Else
                .PSTTPCRG = ""
            End If

            .PSNGRPRV = txtNroGuiaProveedor.Text

            If Not ucIncidencia.Resultado Is Nothing Then
                .PSINCBLT = CType(ucIncidencia.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            Else
                .PSINCBLT = ""
            End If

            'ucIncidencia

            'OMVB REQ15072019 HORA DE ENTREGA
   

            .PNHORIDE = Me.txtHoraEntrega.Text.Replace(":", "").Trim.PadRight(6, "0")


            'OMVB REQ15072019 HORA DE ENTREGA



        End With

        Dim strMensaje As String = String.Empty
        If chkCnt.Checked Then
            If ValidaContenedor(obeBulto, strMensaje) = 0 Then
                HelpClass.MsgBox(strMensaje, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        ' REGISTRAMOS LOS ITEMS DEL BULTO             
        Dim lstRegItemBulto As New List(Of TD_Obj_ItemBulto)
        Dim oItemBulto As TD_Obj_ItemBulto
        '-- Recorro los items de los O/C seleccionado
        If lstItems.Count > 0 Then

           

            'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS
            For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
                oItemBulto = New TD_Obj_ItemBulto
                '-- Generamos el detalle del bulto
                With oItemBulto
                    .pCCLNT_CodigoCliente = obeBulto.PNCCLNT
                    .pCREFFW_CodigoBulto = obeBulto.PSCREFFW
                    .PNSEQIN_NrCorrelativo = obeBulto.PNNSEQIN
                    .pNORCML_NroOrdenCompra = strNORCML
                    .pNRITOC_NroItemOC = dgOrdenComprasSeleccionados.Rows(i).Cells("D_NRITOC").Value 'objTemp.pNRITOC_NroItemOC
                    .pQBLTSR_CantidadRecibida = dgOrdenComprasSeleccionados.Rows(i).Cells("D_QCNREC").Value  'objTemp.pQCNREC_QtaRecibida 

                    .pQPEPQT_PesoCantRecibida = dgOrdenComprasSeleccionados.Rows(i).Cells("QPEPQT").Value 'objTemp.pQPEPQT_QtaPeso 
                    .pTUNPSO_UnidadPeso = dgOrdenComprasSeleccionados.Rows(i).Cells("D_TUNPSO").Value 'objTemp.pTUNPSO_UnidadPeso
                    .pQVOPQT_VolumenCantRecibida = dgOrdenComprasSeleccionados.Rows(i).Cells("D_QVOPQT").Value  'objTemp.pQVOPQT_QtaVolumen   
                    .pTUNVOL_UnidadVolumen = dgOrdenComprasSeleccionados.Rows(i).Cells("D_TUNVOL").Value  'objTemp.pTUNVOL_UnidadVolumen

                    .pNGRPRV_NroGuiaRemisionProveedor = txtNroGuiaProveedor.Text
                    .pNFACPR_NroFacturaProveedor = txtNroFactProveedor.Text
                    .pTDAITM_Observaciones = dgOrdenComprasSeleccionados.Rows(i).Cells("D_TDAITM").Value 'objTemp.pTDAITM_Observaciones

                    'Adicionales
                    .pCCMPN_CodigoCompania = strCompania
                    .pCDVSN_CodigoDivision = strDivision
                    .pCPLNDV_CodigoPlanta = dblPlanta

                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
                    .pCMATPE_CboCondicionGrilla = dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value

                    If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaChkIQBF").Value Is Nothing Then
                        .pFGIQBF_CheckGrilla = ""
                    Else
                        .pFGIQBF_CheckGrilla = "SI" 'dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaChkIQBF").Value
                    End If

                    .pCCLMAT_CboValorGrilla = dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value
                    .pCPRFUN_DesUnGrilla = dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaDesUN").Value
                    .pCUNMAT_CodUnGrilla = dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUn").Value

                    If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaFechaCad").Value Is Nothing OrElse dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaFechaCad").Value.ToString.Trim = "" Then
                        .pFCHCAD_FechaGrilla = 0
                    Else
                        .pFCHCAD_FechaGrilla = Convert.ToDateTime(dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaFechaCad").Value()).ToString("yyyyMMdd")
                    End If

                    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN

                    Date.TryParse(txtFechaFactProveedor.Text, .pFFACPR_FechaFacturaProveedor)
                    Select Case pEstado.ToUpper
                        Case "DEVOLUCION"
                            .pESTADO_estado = "Devolucion"
                        Case "RECOJO"
                            .pESTADO_estado = "Recojo"
                        Case Else
                            .pESTADO_estado = ""
                    End Select
                    If Not oHasSubItems(.pNRITOC_NroItemOC.ToString.Trim) Is Nothing Then
                        For Each obeTD_SubItemOC As Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In oHasSubItems(.pNRITOC_NroItemOC.ToString.Trim)
                            obeTD_SubItemOC.pCCLNT_CodigoCliente = obeBulto.PNCCLNT
                            obeTD_SubItemOC.pCREFFW_FrdForw = obeBulto.PSCREFFW
                            olbeSubItemOC.Add(obeTD_SubItemOC)
                        Next
                    End If
                    obeBulto.PSTLUGOR = txtOrigen.Text
                    obeBulto.PSTLUGEN = txtEntrega.Text

                End With
                lstRegItemBulto.Add(oItemBulto)
            Next
            'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.
        End If

        If lstRegItemBulto.Count = 0 Then
            MessageBox.Show("No existen Items asociados para el Bulto." & vbNewLine & vbNewLine & _
                            "No se pudo terminar el Proceso.", "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstRegItemBulto = Nothing
            Exit Sub
        End If

        '==================================
        'Ca
        '=================================
        If obrBulto.fintInsertarBulto(obeBulto) Then
            If Not obeDocumento.PSNDOCUM.Trim.Equals("") Then
                If obeBulto.PSCREFFW.Trim <> obeDocumento.PSNDOCUM.Trim Then
                    Dim obrCargarImagen As New brCargarImagen
                    Dim strTipo As String = "GUIA PROV"
                    Dim strDireccion As String = "SOLMIN_SA/" & intCCLNT.ToString.Trim & "/" & strTipo
                    obrCargarImagen.RemplazarFile(strDireccion, obeDocumento.PSTNMBAR, obeBulto.PSCREFFW & "_" & obeDocumento.PNNCRRDC.ToString & obeDocumento.EXTENCION)
                End If
                With obeDocumento
                    .PSNDOCUM = obeBulto.PSCREFFW
                    .PSTNMBAR = obeBulto.PSCREFFW & "_" & obeDocumento.PNNCRRDC.ToString & obeDocumento.EXTENCION
                End With
                GrabarDocumento()
                '====================================================
            End If
            '====================================================

            If oItemWaybill.Grabar(lstRegItemBulto) Then
                Dim strError As String = ""
                For Each obeTD_SubItemOC As Ransa.TypeDef.OrdenCompra.SubItemOC.TD_SubItemOC In olbeSubItemOC
                    For Each oTemp As TD_Obj_ItemBulto In lstRegItemBulto
                        If obeTD_SubItemOC.pCREFFW_FrdForw = oTemp.pCREFFW_CodigoBulto And obeTD_SubItemOC.pNORCML_NroOrdenCompra = oTemp.pNORCML_NroOrdenCompra And obeTD_SubItemOC.pNRITOC_NroItemOC = oTemp.pNRITOC_NroItemOC Then
                            obeTD_SubItemOC.pCCMPN_Compania = strCompania
                            obeTD_SubItemOC.pCDVSN_Division = strDivision
                            obeTD_SubItemOC.pCPLNDV_Planta = dblPlanta
                            obeTD_SubItemOC.pCIDPAQ_CodIndentificacionPaquete = oTemp.pCIDPAQ_CodItentificadorPaquetes
                            Exit For
                        End If
                    Next
                    CSubItemOrdenCompra.Generar_Bultos_SubItems_OC(Nothing, obeTD_SubItemOC, strError, objSeguridadBN.pUsuario)
                Next

                If chkEtiqueta.CheckState = CheckState.Checked Then
                    ' Proceso que consulta la impresión del Bulto
                    Dim obeEtiquetaBulto As New beBulto
                    obeEtiquetaBulto.PSCCMPN = obeBulto.PSCCMPN
                    obeEtiquetaBulto.PSCDVSN = obeBulto.PSCDVSN
                    obeEtiquetaBulto.PNCPLNDV = obeBulto.PNCPLNDV
                    obeEtiquetaBulto.PSCREFFW = obeBulto.PSCREFFW
                    obeEtiquetaBulto.PNCCLNT = obeBulto.PNCCLNT
                    obeEtiquetaBulto.PNNSEQIN = obeBulto.PNNSEQIN
                    obeEtiquetaBulto.PNQREFFW = obeBulto.PNQREFFW


                    If rdFormatoSimple.Checked Then
                        Call mpImprimir_EtiquetaBulto(obeEtiquetaBulto)
                    ElseIf rdFormatoDetalle.Checked Then
                        Call mpImprimir_EtiquetaBulto_Detalle(obeEtiquetaBulto)
                    ElseIf rdFormatoBultoMineria.Checked Then
                        Call mpImprimir_EtiquetaBulto_Mineria(obeEtiquetaBulto)
                    End If
                End If
                If chkRegistrarServicio.CheckState = CheckState.Checked Then
                    Dim oServicio As New Servicio_BE
                    Cursor = Cursors.WaitCursor
                    With oServicio
                        .CCMPN = obeBulto.PSCCMPN
                        .CDVSN = obeBulto.PSCDVSN
                        .CPLNDV = obeBulto.PNCPLNDV
                        .NOPRCN = 0
                        .CCLNFC = intCCLNT
                        .CCLNT = intCCLNT
                        .NRTFSV = 0
                        .QATNAN = 0
                        .TIPO = "N"
                        .FOPRCN = 0
                        .FECINI = 0
                        .FECFIN = 0
                        .STIPPR = "R"
                        .STPODP = objSeguridadBN.pstrTipoAlmacen
                        .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .CREFFW = obeBulto.PSCREFFW
                    End With
                    Dim frm As New UcFrmServicioAgregarSA_DS
                    frm.oServicio = oServicio
                    frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    End If
                End If

                GuardarControlesUsados()
                'Enviamos Correo si es cliente PLuspetrol
                '==============comentado por mientras====================

                'If obeBulto.PNCCLNT = 11731 Or obeBulto.PNCCLNT = 30507 Then
                'MPS
                If ListaPLus.Contains(intCCLNT.ToString.Trim) Then

                    Dim obeCorreoBulto As New beBulto
                    With obeCorreoBulto
                        .PSCCMPN = obeBulto.PSCCMPN
                        .PSCDVSN = obeBulto.PSCDVSN
                        .PNCPLNDV = obeBulto.PNCPLNDV
                        .PNCCLNT = obeBulto.PNCCLNT
                        .PSCREFFW = obeBulto.PSCREFFW
                    End With
                    obrBulto.EnviarCorreoPluspetrol(obeCorreoBulto)
                    InsertarCuentaImputacion()
                End If
                '==================si es recojo=======================
                If pEstado.ToUpper = "RECOJO" Then
                    Dim ofrmGuiaDeRemision As New frmGenerarGuiaRemisionSAT
                    With ofrmGuiaDeRemision
                        .EsRecojo = True
                        .PSCREFFW = obeBulto.PSCREFFW
                        .PSCCMPN = obeBulto.PSCCMPN
                        .PSCDVSN = obeBulto.PSCDVSN
                        .PNCPLNDV = obeBulto.PNCPLNDV
                        .PNCCLNT = obeBulto.PNCCLNT
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            DialogResult = Windows.Forms.DialogResult.OK
                           
                        End If
                    End With

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
                            .PNNSEQIN = 1
                            If obrBulto.fintInsertarBultoDetalleCarga(obePaquetes) = 0 Then
                                HelpClass.ErrorMsgBox()
                                Exit Sub
                            End If
                        End With
                    Next
                End If
                HelpClass.MsgBox("El Bulto fue registrado satisfactoriamente." & Chr(13) & "Código Bulto: " & obeBulto.PSCREFFW)

                '================ Envio al MessgeBroker ===============================
                'If obrBulto.fbolVerificarClienteHabilitado(obeBulto.PNCCLNT) = True Then
                '    Dim strResultado As String = String.Empty
                '    Dim olistbebulto As New List(Of beBulto)
                '    olistbebulto.Add(obeBulto)
                '    strResultado = obrBulto.fstrEnviarWsBroker(olistbebulto)
                '    If strResultado.Length > 0 Then
                '        MessageBox.Show(strResultado, "Error al enviar a MSBroker", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End If
                'End If
                '================ Envio al MessgeBroker ===============================
                Call EnvioConfirmacion(intCCLNT, obeBulto)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                Dim obeRollbackBulto As New beBulto
                With obeRollbackBulto
                    .PSCCMPN = obeBulto.PSCCMPN
                    .PSCDVSN = obeBulto.PSCDVSN
                    .PNCPLNDV = obeBulto.PNCPLNDV
                    .PNCCLNT = obeBulto.PNCCLNT
                    .PSCREFFW = obeBulto.PSCREFFW
                End With
                If obrBulto.RollbackInsertBulto(obeRollbackBulto) = -1 Then
                    HelpClass.ErrorMsgBox()
                End If
                HelpClass.ErrorMsgBox()
            End If


        Else
            HelpClass.ErrorMsgBox()
        End If
    End Sub

    'Dagnino 09/15/2015
    ''' <summary>
    ''' Realizar proceso de envio de confirmacion
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared Sub EnvioConfirmacion(ByVal codCliente As Integer, ByVal obeBulto As beBulto)
        Dim obrBulto As New brBulto
        Dim estEnvioConfirmacion As String
        Dim mensaje As String
        Dim strMessageError As String = String.Empty
        Try

            If obrBulto.ValidarClienteParaConfirmacion(codCliente) Then
                estEnvioConfirmacion = obrBulto.EnviarInfoBulto(obeBulto, strMessageError)
                If estEnvioConfirmacion = ErrorProceso Then
                    mensaje = String.Format("Error en el proceso de envío para el bulto: {0}, Detalle del Error: {1}", obeBulto.PSCREFFW.ToString().Trim(), strMessageError)
                    MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf estEnvioConfirmacion = ErrorComunicacion Then
                    mensaje = String.Format("Error de comunicación en el proceso de envío para el bulto: {0}", obeBulto.PSCREFFW.ToString().Trim())
                    MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf estEnvioConfirmacion = ErrorConexion Then
                    MessageBox.Show("Error de conexión.", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf estEnvioConfirmacion = ProcesoExitoso Then
                    MessageBox.Show("Se realizó el envío correctamente.", "Proceso Exitoso: ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    mensaje = String.Format("Error al actualizar el estado de envío del bulto: {0}", obeBulto.PSCREFFW.ToString().Trim())
                    MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            mensaje = String.Format("Error al actualizar el estado de envío del bulto: {0}", obeBulto.PSCREFFW.ToString().Trim())
            MessageBox.Show(mensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

    

#Region " Métodos "

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Try
            If mfblnSalirOpcion() Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaMotivoRecepcionListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaMotivoRecepcionListar.Click
        Try
            Call mfdtBuscar_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaNroTicketBalanzaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNroTicketBalanzaListar.Click
        Try
            Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
            txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click, bsaSentidoCargaListar_1.Click
    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar_1.Click
        Try
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
            Call CargaLugarOrigenEntrega(txtSentidoCarga.Tag)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub bsaTipoBultoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoBultoListar.Click

        Try
            Call mfblnBuscar_TipoBulto(txtTipoBulto.Text)
            txtTipoBulto.Tag = txtTipoBulto.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoBulto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoBulto.KeyDown


        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_TipoBulto(txtTipoBulto.Text)
                txtTipoBulto.Tag = txtTipoBulto.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoBulto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoBulto.TextChanged
        txtTipoBulto.Tag = ""
    End Sub

    Private Sub txtTipoBulto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoBulto.Validating

        Try

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaTipoMovimientoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoMovimientoListar.Click

        Try
            Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub bsaUnidadPesoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadPesoListar.Click

        Try
            Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub bsaUnidadVolumenListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaUnidadVolumenListar.Click

        Try
            Call mfblnBuscar_UnidadMedida(txtUnidadVolumen.Text, "C")
            txtUnidadVolumen.Tag = txtUnidadVolumen.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Private Function ValidacionCamposGrilla() As String
        '   Dim bandera As Boolean = False
        Dim msj As String = ""


        For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
            Dim valorFila As String = dgOrdenComprasSeleccionados.Rows(i).Cells("D_NRITOC").Value
            If CType(TxtTipoMaterial.Resultado, beAlmacen).PSCCMPRN = "MATPEL" Then 'Ingresa si el tipo material es MATPEL
                If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value <> "" Then 'Valida si alguna condicion fue seleccionada
                    If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value = "RE" Then 'Valida si la condicion  seleccionada es  "Regulado (RE)" 

                        If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value = Nothing OrElse dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value = "" Then 'Valida si clase fue seleccionada

                            msj = msj & "En el Item [" + valorFila + "] - Seleccione Clase" & Chr(13)

                        End If

                        If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").Value = Nothing OrElse dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").Value = "" Then 'Valida si tiene codigo UN
                            msj = msj & "En el Item [" + valorFila + "] - Ingresar Cód. UN" & Chr(13)
                           
                        End If

                    End If
                Else
                    msj = msj & "En el Item [" + valorFila + "] - Seleccione Condición" & Chr(13)
                   
                End If
            End If
        Next
        Return msj
    End Function
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Call pGrabarBultoConDetalle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub dgOrdenComprasSeleccionados_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenComprasSeleccionados.CellEndEdit
        Try
            With dgOrdenComprasSeleccionados
                Select Case .Columns(e.ColumnIndex).Name
                    Case "D_TDAITM"
                        .CurrentCell.Value = .CurrentCell.Value.ToString.ToUpper.Trim
                    Case "D_QCNREC"
                        If .CurrentCell.Value.ToString.Trim = "" Then .CurrentCell.Value = 0
                        Dim decTemp As Decimal = 0D
                        Decimal.TryParse(.CurrentCell.Value, decTemp)
                        .CurrentCell.Value = decTemp
                End Select
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub dgOrdenComprasSeleccionados_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgOrdenComprasSeleccionados.RowValidating

        Try

            If booStatusCargaDG Then
                With dgOrdenComprasSeleccionados
                    Decimal.TryParse(.CurrentRow.Cells("D_QCNREC").Value.ToString, .CurrentRow.Cells("D_QCNREC").Value)
                    If .CurrentRow.Cells("D_QCNREC").Value < 0 Then
                        .CurrentRow.Cells("D_QCNREC").Value = 0
                    End If
                    If .CurrentRow.Cells("D_QTOMAX").Value > .CurrentRow.Cells("D_QCNTIT").Value Then
                        If .CurrentRow.Cells("D_QTOMAX").Value - _
                           .CurrentRow.Cells("D_QCNTIT").Value + _
                           .CurrentRow.Cells("D_QCNPEN").Value - _
                           .CurrentRow.Cells("D_QCNREC").Value < 0 And .CurrentRow.Cells("D_QCNREC").Value > 0 Then
                            If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", _
                                               MessageBoxButtons.YesNo, _
                                               MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                                If .CurrentRow.Cells("D_QCNPEN").Value > 0 Then
                                    .CurrentRow.Cells("D_QCNREC").Value = .CurrentRow.Cells(6).Value
                                Else
                                    .CurrentRow.Cells("D_QCNREC").Value = 0
                                End If
                            End If
                        End If
                    Else
                        If .CurrentRow.Cells("D_QCNPEN").Value - _
                           .CurrentRow.Cells("D_QCNREC").Value < 0 And .CurrentRow.Cells("D_QCNREC").Value > 0 Then
                            If MessageBox.Show("Confirma que ha recibido más de los pendiente.", "Error : ", _
                                               MessageBoxButtons.YesNo, _
                                               MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                                If .CurrentRow.Cells("D_QCNPEN").Value > 0 Then
                                    .CurrentRow.Cells("D_QCNREC").Value = .CurrentRow.Cells("D_QCNPEN").Value
                                Else
                                    .CurrentRow.Cells("D_QCNREC").Value = 0
                                End If
                            End If
                        End If
                    End If
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub frmGenerarBulto_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not oItemWaybill Is Nothing Then oItemWaybill.Dispose()
        oItemWaybill = Nothing
    End Sub

    Private Sub frmGenerarBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            '-- Se inicializan los status por control con F4
            booValidarMotivosRecepcion = False
            booValidarServicioAtendido = False
            ' Alisto nuevo ingreso
            dtgPaquetesDeBulto.AutoGenerateColumns = False
            Me.dtgPaquetesDeBulto.DataSource = BeBultoBindingSource
            Call pAlistarNuevoIngreso()
            '' nuevo CAMBIO
            Select Case pEstado.Trim.ToUpper
                Case "DEVOLUCION"
                    txtTipoMovimiento.Enabled = False
                    txtSentidoCarga.Text = "2"
                    txtSentidoCarga_Validating(Nothing, Nothing)
                Case "RECOJO"
                    txtSentidoCarga.Text = "3"
                    txtSentidoCarga_Validating(Nothing, Nothing)
                    txtTipoMovimiento.Enabled = False
                Case "RETORNO"
                    txtSentidoCarga.Text = "2"
                    txtSentidoCarga_Validating(Nothing, Nothing)
                    txtTipoMovimiento.Text = "RETORNO"
                    txtTipoMovimiento_Validating(Nothing, Nothing)
                    txtTipoMovimiento.Enabled = False
                Case Else
                    txtSentidoCarga.Text = "1"
                    txtSentidoCarga_Validating(Nothing, Nothing)

            End Select
            If lstItems.Count > 0 Then
                'Height = 650
                booStatusCargaDG = False
                CargarItems()
                CargarCuentaImputacion()
                CargaLugarOrigenEntrega(txtSentidoCarga.Tag)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarItems()
        dgOrdenComprasSeleccionados.DataSource = Nothing
        dgOrdenComprasSeleccionados.ReadOnly = True
        Dim oDrv As DataGridViewRow
        Dim fila As Integer = 0
        For Each oItemOCForWayBill As TD_ItemOCForWayBill In lstItems
            oDrv = New DataGridViewRow
            oDrv.CreateCells(dgOrdenComprasSeleccionados)
            oDrv.Cells(0).Value = strNORCML

            dgOrdenComprasSeleccionados.Rows.Add(oDrv)
            fila = dgOrdenComprasSeleccionados.Rows.Count - 1
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_NRITOC").Value = oItemOCForWayBill.pNRITOC_NroItemOC
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TDITES").Value = oItemOCForWayBill.pTDITES_DescripcionItem
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_QCNREC").Value = oItemOCForWayBill.pQCNREC_QtaRecibida
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TUNDIT").Value = oItemOCForWayBill.pTUNDIT_UnidadQta
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_QPEPQT").Value = oItemOCForWayBill.pQPEPQT_Peso
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TUNPSO").Value = oItemOCForWayBill.pTUNPSO_UnidadPeso
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_QVOPQT").Value = oItemOCForWayBill.pQVOPQT_QtaVolumen
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TUNVOL").Value = oItemOCForWayBill.pTUNVOL_UnidadVolumen
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_QTOMAX").Value = oItemOCForWayBill.pQPEPQT_Peso
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TDAITM").Value = oItemOCForWayBill.pTDAITM_Observaciones
            dgOrdenComprasSeleccionados.Rows(fila).Cells("D_TLUGEN").Value = oItemOCForWayBill.pTLUGEN_LugarDeEntrega
            strLugarEntrega = oItemOCForWayBill.pTLUGEN_LugarDeEntrega
            If Not (oHasSubItems(oItemOCForWayBill.pNRITOC_NroItemOC.ToString) Is Nothing) Then
                dgOrdenComprasSeleccionados.Rows(fila).Cells("SUBITEM").Value = My.Resources.retencion
            End If
            dgOrdenComprasSeleccionados.Rows(fila).Cells("QPEPQT").Value = oItemOCForWayBill.pQPEPQT_Peso
            dgOrdenComprasSeleccionados.Rows(fila).Cells("UNSPSC").Value = oItemOCForWayBill.pUNSPSC_CodUn

            
        Next

        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim ValorEnvio As String

        'Obtener GrillaCondicion dentro de la grilla'
        ValorEnvio = "SACDMP"
        Dim dtComboGrilla As DataTable = obrOrdenCompra.ObtenerValoresGrilla(ValorEnvio)
        Dim drCombo As DataRow
        drCombo = dtComboGrilla.NewRow
        drCombo("CODVAR") = "SACDMP"
        drCombo("CCMPRN") = ""
        drCombo("TDSDES") = ":: Seleccione ::"
        drCombo("TDSDE2") = ""
        dtComboGrilla.Rows.InsertAt(drCombo, 0)

        GrillaCboCondicion.DataSource = dtComboGrilla
        GrillaCboCondicion.DisplayMember = "TDSDES"
        GrillaCboCondicion.ValueMember = "CCMPRN"
        GrillaCboCondicion.DataGridView.ReadOnly = False

        'Obtener GrillaClase  dentro de la grilla 
        ValorEnvio = "SACLMT"
        Dim dtClaseGrilla As DataTable = obrOrdenCompra.ObtenerValoresGrilla(ValorEnvio)
        Dim drClase2 As DataRow
        drClase2 = dtClaseGrilla.NewRow
        drClase2("CODVAR") = "SACLMT"
        drClase2("CCMPRN") = ""
        drClase2("TDSDES") = ":: Seleccione ::"
        dtClaseGrilla.Rows.InsertAt(drClase2, 0)

        Dim dtClaseContatenado As New DataTable("Clase")
        dtClaseContatenado.Columns.Add("CODVAR", Type.GetType("System.String"))
        dtClaseContatenado.Columns.Add("CCMPRN", Type.GetType("System.String"))
        dtClaseContatenado.Columns.Add("TDSDES", Type.GetType("System.String"))

        If dtClaseGrilla.Rows.Count > 0 Then
            For i As Integer = 0 To dtClaseGrilla.Rows.Count - 1
                Dim CODVAR As String = dtClaseGrilla.Rows(i).Item("CODVAR").ToString.Trim
                Dim CCMPRN As String = dtClaseGrilla.Rows(i).Item("CCMPRN").ToString.Trim
                Dim TDSDES As String = dtClaseGrilla.Rows(i).Item("TDSDES").ToString.Trim
                Dim TDSDE2 As String = dtClaseGrilla.Rows(i).Item("TDSDE2").ToString.Trim
                Dim Concat As String = TDSDES + " " + TDSDE2

                Dim drClase As DataRow
                drClase = dtClaseContatenado.NewRow
                drClase("CODVAR") = CODVAR
                drClase("CCMPRN") = CCMPRN
                drClase("TDSDES") = Concat
                dtClaseContatenado.Rows.InsertAt(drClase, dtClaseGrilla.Rows.Count)
            Next
        End If

        GrillaCboClase.DataSource = dtClaseContatenado
        GrillaCboClase.DisplayMember = "TDSDES"
        GrillaCboClase.ValueMember = "CCMPRN"

        'Valor en columna descripcion UN
        For i As Integer = 0 To dgOrdenComprasSeleccionados.Rows.Count - 1
            dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value = ""
            dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value = ""
            dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaDesUN").Value = "UN"


            dgOrdenComprasSeleccionados.Rows(i).Cells("D_NORCML").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_NRITOC").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TCITCL").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TDITES").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QCNTIT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QCNPEN").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TLUGEN").ReadOnly = True

            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QCNREC").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TUNDIT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QPEPQT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TUNPSO").ReadOnly = True


            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QVOPQT").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TUNVOL").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_QTOMAX").ReadOnly = True
            dgOrdenComprasSeleccionados.Rows(i).Cells("D_TDAITM").ReadOnly = True
        Next

        'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN
    End Sub

    Private Sub txtCodigoRecepcion_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles txtCodigoRecepcion.Validating
        Try
            If txtCodigoRecepcion.Text <> "" And mfblnExiste_Bulto(intCCLNT, txtCodigoRecepcion.Text) Then
                txtCodigoRecepcion.Text = ""
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtMotivoRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMotivoRecepcion.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfdtBuscar_MotivoRecepcion(txtMotivoRecepcion.Tag, txtMotivoRecepcion.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtMotivoRecepcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMotivoRecepcion.TextChanged
        txtMotivoRecepcion.Tag = ""
    End Sub

    Private Sub txtMotivoRecepcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotivoRecepcion.Validating
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNroTicketBalanza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroTicketBalanza.KeyDown

        Try

            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_Ticket(txtNroTicketBalanza.Text, txtPesoTicket.Text)
                txtNroTicketBalanza.Tag = txtNroTicketBalanza.Text
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNroTicketBalanza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroTicketBalanza.TextChanged
        txtNroTicketBalanza.Tag = ""
    End Sub

    Private Sub txtNroTicketBalanza_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles txtNroTicketBalanza.Validating

        Try
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

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTipoMovimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMovimiento.TextChanged
        txtTipoMovimiento.Tag = ""
    End Sub

    Private Sub txtTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoMovimiento.Validating

        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating


        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadPeso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadPeso.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
                txtUnidadPeso.Tag = txtUnidadPeso.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles txtUnidadPeso.Validating

        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadVolumen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadVolumen.KeyDown

        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_UnidadMedida(txtUnidadVolumen.Text, "V")
                txtUnidadVolumen.Tag = txtUnidadVolumen.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadVolumen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidadVolumen.TextChanged
        txtUnidadVolumen.Tag = ""
    End Sub

    Private Sub txtUnidadVolumen_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles txtUnidadVolumen.Validating

        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
#End Region
    Private Sub CargarCodigoUsado()
        ' Recuperamos los ultimos valores seleccionados
        Dim objAppConfig As cAppConfig = New cAppConfig
        txtTipoAlmacen.Valor = objAppConfig.GetValue("Recepcion_TipoAlmacen", GetType(System.String))
        txtAlmacen.Valor = objAppConfig.GetValue("Recepcion_Almacen", GetType(System.String))
        txtZonaAlmacen.Valor = objAppConfig.GetValue("Recepcion_Zona", GetType(System.String))
        objAppConfig = Nothing
    End Sub

    Private Sub GuardarControlesUsados()
        '-- Registro los nuevos valores de los campos de los clientes
        Dim objAppConfig As cAppConfig = New cAppConfig
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("Recepcion_TipoAlmacen", txtTipoAlmacen.Text)
        objAppConfig.SetValue("Recepcion_Almacen", txtAlmacen.Text)
        objAppConfig.SetValue("Recepcion_Zona", txtZonaAlmacen.Text)
        objAppConfig.SetValue("Recepcion_TipoMaterial", TxtTipoMaterial.Text)
        objAppConfig = Nothing
        '-- Reinicio las persianas
    End Sub

    Private Sub dgOrdenComprasSeleccionados_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgOrdenComprasSeleccionados.CellMouseDoubleClick

        Try
            If e.RowIndex = -1 OrElse oHasSubItems Is Nothing Then Exit Sub
            Using ofrmSubItems As New frmSubItems()
                With ofrmSubItems
                    .SubItems = oHasSubItems(dgOrdenComprasSeleccionados.CurrentRow.Cells("D_NRITOC").Value.ToString)
                    If .SubItems Is Nothing Then Exit Sub
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub UcMedioTransporte1_ActivarAyuda(ByRef objData As Object)
        Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
        objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
    End Sub

    Private Sub UcMedioTransporte1_CambioDeTexto1(ByVal strData As String, ByRef objData As Object)
        Try

            If Not strData.Trim.Equals("") Then
                Dim obrMedioTransporte As New Ransa.NEGO.brGeneral
                Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral
                With obeMedioTransporte
                    .PNCMEDTR = Val(strData)
                    .PSTNMMDT = strData
                End With
                objData = obrMedioTransporte.ListaMedioTransporte(obeMedioTransporte)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GrabarDocumento() As Integer
        Dim obrDocumento As New brDocumento
        If obrDocumento.DocumentoAlmacenInsertar(obeDocumento) = 0 Then
            HelpClass.ErrorMsgBox()
            Return 1
        End If
        Return 0
    End Function

    'Private Sub bsaAdjuntarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAdjuntarDoc.Click
    '    If txtCodigoRecepcion.Text.Trim.Equals("") Then Exit Sub
    '    Dim strTipo As String = "RECEPCION/DOC"
    '    Dim strNombreDocumento As String = String.Empty
    '    strNombreDocumento = txtCodigoRecepcion.Text
    '    Dim strDireccion As String = "SOLMIN_SA/" & intCCLNT.ToString.Trim & "/" & strTipo

    '    Dim obrCargarImagen As New brCargarImagen

    '    With obeDocumento
    '        .PNCCLNT = intCCLNT
    '        .PSNDOCUM = strNombreDocumento
    '        .PSTIPODC = "RECEPCION"
    '        .PSCUSCRT = objSeguridadBN.pUsuario
    '        .PSSESTRG = "A"
    '    End With
    '    strNombreDocumento = strNombreDocumento & "_" & obeDocumento.PNNCRRDC.ToString
    '    Using objfrmSACE As New frmSubirArchivo(strDireccion, strNombreDocumento)
    '        objfrmSACE.VerObservacion = False
    '        If objfrmSACE.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            obeDocumento.EXTENCION = obrCargarImagen.GetFileExtencion(strDireccion, strNombreDocumento)
    '            strNombreDocumento = strNombreDocumento & obeDocumento.EXTENCION
    '            If obrCargarImagen.ExisteImagen(strDireccion, strNombreDocumento) Then
    '                With obeDocumento
    '                    .PSTOBSMD = "Guía de Proveedor"
    '                    .PSTNMBAR = strNombreDocumento
    '                    .PSCTIIMG = "DOC"
    '                    .PSURLARC = HelpClass.getURLDocLinksSolAlmacen() & strDireccion
    '                    .PSCULUSA = objSeguridadBN.pUsuario
    '                End With
    '            End If
    '        End If
    '    End Using
    'End Sub

    Private Sub chkEtiqueta_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEtiqueta.CheckedChanged
        rdFormatoSimple.Visible = chkEtiqueta.Checked
        rdFormatoDetalle.Visible = chkEtiqueta.Checked
    End Sub

    Private Sub CargarCuentaImputacion()
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim obeOrdenCompra As New beOrdenCompra
        Dim olistbeOrdenCompra As New List(Of beOrdenCompra)
        With obeOrdenCompra
            .PNCCLNT = intCCLNT
            .PSNORCML = strNORCML
            .FechaVigencia = dteFechaRecepcion.Value
        End With

        olistbeOrdenCompra = obrOrdenCompra.flistObtenerCuentaImputacionOrdenDeCompra(obeOrdenCompra)
        If olistbeOrdenCompra.Count > 0 Then
            obeOrdenCompra = olistbeOrdenCompra.Item(0)
            txtTerrestre.Text = obeOrdenCompra.PSTCTCST
            txtAereo.Text = obeOrdenCompra.PSTCTCSA
            txtFluvial.Text = obeOrdenCompra.PSTCTCSF
            txtAfe.Text = obeOrdenCompra.PSTCTAFE
            'Alberto 26102018
            KryptonTextBox1.Text = obeOrdenCompra.PSTCTCAL

            If obeOrdenCompra.PNFECVIG > 0 Then
                txtTerrestre.ReadOnly = True
                txtAereo.ReadOnly = True
                txtFluvial.ReadOnly = True
                txtAfe.ReadOnly = True
                'Alberto 26102018
                KryptonTextBox1.ReadOnly = True
            End If
        End If

        Dim dtListCuentasImputacion As DataTable
        dtListCuentasImputacion = obrOrdenCompra.ListCuentasImputacion(obeOrdenCompra)

        If dtListCuentasImputacion.Rows.Count > 0 Then
            dgCuentasImputadas.DataSource = dtListCuentasImputacion
            dgCuentasImputadas.ReadOnly = True
        Else
            tsbAgregarCu.Visible = True

        End If
    End Sub

    Private Sub InsertarCuentaImputacion()
        If txtTerrestre.ReadOnly Then Exit Sub
        If txtTerrestre.Text.Trim.ToString.Equals("") AndAlso txtAereo.Text.Trim.ToString.Equals("") AndAlso txtFluvial.Text.Trim.ToString.Equals("") AndAlso txtAfe.Text.Trim.ToString.Equals("") Then Exit Sub
        Dim obrOrdenCompra As New brOrdenDeCompra
        Dim obeOrdenCompra As New beOrdenCompra
        With obeOrdenCompra
            .PNCCLNT = intCCLNT
            .PSNORCML = strNORCML
            .PSTCTCST = txtTerrestre.Text
            .PSTCTCSA = txtAereo.Text
            .PSTCTCSF = txtFluvial.Text
            .PSTCTAFE = txtAfe.Text
            .PSUSUARIO = objSeguridadBN.pUsuario
            .PSNTRMNL = objSeguridadBN.pstrPCName
            .PSTCTCAL = KryptonTextBox1.Text
            If Not txtMedioSugerido.Resultado Is Nothing Then
                .PNCMEDTS = CType(txtMedioSugerido.Resultado, Ransa.TypeDef.beGeneral).PNCMEDTR
            End If
        End With
        If obrOrdenCompra.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenCompra) = 0 Then
            'HelpClass.ErrorMsgBox()
        End If
    End Sub

    Private Sub CargaLugarOrigenEntrega(ByVal strSentido As String)
        Select Case strSentido
            Case "1"
                txtOrigen.Text = strDesPlanta
                txtEntrega.Text = strLugarEntrega
                txtEntrega.StateCommon.Back.Color1 = Color.White

            Case "3"
                txtOrigen.Text = strDesPlanta
                txtEntrega.Text = strLugarEntrega
                txtEntrega.StateCommon.Back.Color1 = Color.White

            Case "2"
                txtOrigen.Text = strLugarEntrega
                txtEntrega.Text = strDesPlanta
                If ListaPLus(intCCLNT) Then
                    txtEntrega.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 192)
                End If
                'If intCCLNT = 30507 Or intCCLNT = 11731 Then
                '    txtEntrega.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 192)
                'End If
            Case Else
                txtOrigen.Text = strDesPlanta
                txtEntrega.Text = strLugarEntrega
                txtEntrega.StateCommon.Back.Color1 = Color.White
        End Select
    End Sub

    Private Sub btnAyudaContenedorListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyudaContenedor.Click
        Call mfblnBuscar_Contenedor(strCompania, intCCLNT, txtSigla.Text, txtNumeroContenedor.Text)
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
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"

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
        Dim obeMedioTransporte As New Ransa.TypeDef.beGeneral

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
        'Dim obrAlmacen As New brAlmacen

        obeAlmacen.PSCODVAR = "TIPMAT"
        obeAlmacen.PSTTPOMR = ""
        TxtTipoMaterial.DataSource = obrAlmacen.ListaTipoDeMaterial(obeAlmacen)
        TxtTipoMaterial.ListColumnas = oListColum
        TxtTipoMaterial.Cargas()
        TxtTipoMaterial.ValueMember = "PSCCMPRN"
        TxtTipoMaterial.DispleyMember = "PSTDSDES"

        TxtTipoMaterial.Valor = "NORMAL"
        'obeAlmacen.PSTTPOMR = "NORMAL"

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


        'OMVB REQ15072019 HORA DE ENTREGA
        txtHoraEntrega.Text = Format(Now, "HH:mm")
        'OMVB REQ15072019 HORA DE ENTREGA

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
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = dblPlanta
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
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
        If Not objData Is Nothing Then
            txtZonaAlmacen.DataSource = obrAlmacen.ListaZonaDeAlmacen(objData)
        Else
            txtZonaAlmacen.DataSource = Nothing
        End If
        txtZonaAlmacen.ListColumnas = oListColum
        txtZonaAlmacen.Cargas()
        txtZonaAlmacen.Limpiar()
        txtZonaAlmacen.ValueMember = "PSCZNALM".Trim()
        txtZonaAlmacen.DispleyMember = "PSTCMZNA"
    End Sub

    Private Sub bsaVolumenBultoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                Dim valor As Long = Int(Altura * Ancho * Largo)
                If CType(valor, String).Length > 15 Then
                    MessageBox.Show("El cálculo del Volumen supera al número de Digitos permitidos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                'txtVolumenBulto.Text = VolumenBulto.ToString
            End If
        End With
    End Sub

    Private Sub txtVolumenBulto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenBulto.KeyPress
        If Estado = True Then
            If txtVolumenBulto.Text <> "" Then
                If CType(txtVolumenBulto.Text, Double) = 0 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub tsbAgregarPaquete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPaquete.Click
        Dim obeBulto As New beBulto
        BeBultoBindingSource.Add(obeBulto)

        ''OMVB REQ08072019
        If Me.dtgPaquetesDeBulto.RowCount > 1 Then
            Me.dtgPaquetesDeBulto.ClearSelection()
            '  Me.dtgPaquetesDeBulto.CurrentCell = Me.dtgPaquetesDeBulto.Rows(Me.dtgPaquetesDeBulto.RowCount + 1 - 2).Cells(0)
            Me.dtgPaquetesDeBulto.CurrentCell = Me.dtgPaquetesDeBulto.Rows(Me.dtgPaquetesDeBulto.RowCount + 1 - 2).Cells("PNQCTPQT")
            'PNQCTPQT
            Me.dtgPaquetesDeBulto.Refresh()
        End If
        ''OMVB REQ08072019

    End Sub

    Private Sub tsbEliminarPaquete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPaquete.Click
        If Me.dtgPaquetesDeBulto.CurrentCellAddress.Y = -1 Then Exit Sub
        BeBultoBindingSource.RemoveCurrent()

        Me.dtgPaquetesDeBulto_CellEndEdit(dtgPaquetesDeBulto, Nothing)




    End Sub


    Private Sub dtgPaquetesDeBulto_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPaquetesDeBulto.CellEndEdit
        Try
            Dim intPeso As Decimal = 0
            Dim intVolumen As Decimal = 0
            Dim M2 As Decimal = 0
            Dim CantPaquetes As Decimal = 0
            For Each obeBulto As beBulto In Me.dtgPaquetesDeBulto.DataSource
                'OMVB REQ08072019
                ' If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0) Then
                If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0 OrElse obeBulto.PNQCTPQT <> 0) Then
                    'OMVB REQ08072019
                    'intPeso += obeBulto.PNQPSOMR
                    intPeso += Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQPSOMR, 2)

                    intVolumen += obeBulto.VOLUMENPAQUETE
                    'M2 = M2 + obeBulto.PNQCTPQT * Math.Round(obeBulto.PNQMTLRG, 2) * Math.Round(obeBulto.PNQMTANC, 2)
                    M2 = M2 + Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC, 2)
                    CantPaquetes = CantPaquetes + obeBulto.PNQCTPQT
                End If
            Next



            Me.txtPesoBulto.Text = intPeso
            Me.txtVolumenBulto.Text = intVolumen
            txtCantidadAreaOcupada.Text = M2
            txtCantidadRecibida.Text = CantPaquetes

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarControlesTipoMaterial()
        Dim obeAlmacen As New beAlmacen

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Tipo Movimiento "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen

        obeAlmacen.PSCODVAR = "TIPMAT"
        obeAlmacen.PSTTPOMR = ""
        TxtTipoMaterial.DataSource = obrAlmacen.ListaTipoDeMaterial(obeAlmacen)
        TxtTipoMaterial.ListColumnas = oListColum
        TxtTipoMaterial.Cargas()
        TxtTipoMaterial.ValueMember = "PSCCMPRN"
        TxtTipoMaterial.DispleyMember = "PSTDSDES"

        TxtTipoMaterial.Valor = "NORMAL"

    End Sub


    'Private Sub tsbAgregarCu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim rowEmpty() As String = {"", "", "", "", ""}
    '    dgCuentasImputadas.Rows.Add(rowEmpty)
    '    dgCuentasImputadas.Rows(0).ReadOnly = False
    'End Sub

    Private Sub tsbAgregarCu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarCu.Click
        Dim rowEmpty() As String = {"", "", "", "", ""}
        dgCuentasImputadas.Rows.Add(rowEmpty)
        dgCuentasImputadas.Rows(0).ReadOnly = False
        tsbGuardarCu.Visible = True
        tsbEliminarCu.Visible = True
        tsbAgregarCu.Visible = False
    End Sub

    Private Sub tsbGuardarCu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardarCu.Click

        dgCuentasImputadas.EndEdit()

        Dim nctama As String

        Dim ccncos As String
        Dim nelpep As String
        Dim norsap As String
        Dim ngfsap As String

        'If dgCuentasImputadas.Rows(0).Cells(0).Value Is Nothing Then
        '    nctama = ""
        'Else
        '    nctama = dgCuentasImputadas.Rows(0).Cells(0).Value.ToString().Trim()
        'End If

        'If dgCuentasImputadas.Rows(0).Cells(1).Value Is Nothing Then
        '    ccncos = ""
        'Else
        '    ccncos = dgCuentasImputadas.Rows(0).Cells(1).Value.ToString().Trim()
        'End If

        'If dgCuentasImputadas.Rows(0).Cells(2).Value Is Nothing Then
        '    nelpep = ""
        'Else
        '    nelpep = dgCuentasImputadas.Rows(0).Cells(2).Value.ToString().Trim()
        'End If

        'If dgCuentasImputadas.Rows(0).Cells(3).Value Is Nothing Then
        '    norsap = ""
        'Else
        '    norsap = dgCuentasImputadas.Rows(0).Cells(3).Value.ToString().Trim()
        'End If

        'If dgCuentasImputadas.Rows(0).Cells(4).Value Is Nothing Then
        '    ngfsap = ""
        'Else
        '    ngfsap = dgCuentasImputadas.Rows(0).Cells(4).Value.ToString().Trim()
        'End If

        If dgCuentasImputadas.Rows(0).Cells("NCTAMA").Value Is Nothing Then
            nctama = ""
        Else
            nctama = dgCuentasImputadas.Rows(0).Cells("NCTAMA").Value.ToString().Trim()
        End If

        If dgCuentasImputadas.Rows(0).Cells("CCNCOS").Value Is Nothing Then
            ccncos = ""
        Else
            ccncos = dgCuentasImputadas.Rows(0).Cells("CCNCOS").Value.ToString().Trim()
        End If

        If dgCuentasImputadas.Rows(0).Cells("NELPEP").Value Is Nothing Then
            nelpep = ""
        Else
            nelpep = dgCuentasImputadas.Rows(0).Cells("NELPEP").Value.ToString().Trim()
        End If

        If dgCuentasImputadas.Rows(0).Cells("NORSAP").Value Is Nothing Then
            norsap = ""
        Else
            norsap = dgCuentasImputadas.Rows(0).Cells("NORSAP").Value.ToString().Trim()
        End If

        If dgCuentasImputadas.Rows(0).Cells("NGFSAP").Value Is Nothing Then
            ngfsap = ""
        Else
            ngfsap = dgCuentasImputadas.Rows(0).Cells("NGFSAP").Value.ToString().Trim()
        End If


        If nctama = "" And ccncos = "" And nelpep = "" And norsap = "" And ngfsap = "" Then

            MessageBox.Show("No se puede guardar porque todas las columnas no poseen información", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim obrOrdenDeCompra As New brOrdenDeCompra
        Dim obeOrdenCompra As New beOrdenCompra

        obeOrdenCompra.PNCCLNT = intCCLNT
        obeOrdenCompra.PSNORCML = strNORCML
        obeOrdenCompra.PSTLUGEN = strLugarEntrega
        obeOrdenCompra.PSCCNCOS = ccncos
        obeOrdenCompra.PNFECHAINI = 0
        obeOrdenCompra.PNFECHAFIN = 0


        obeOrdenCompra.PSNCTAMA = nctama
        obeOrdenCompra.PSNELPEP = nelpep
        obeOrdenCompra.PSNORSAP = norsap
        obeOrdenCompra.PSNGFSAP = ngfsap

        obeOrdenCompra.PSNTRMNL = objSeguridadBN.pstrPCName
        obeOrdenCompra.PSUSUARIO = objSeguridadBN.pUsuario

        If obrOrdenDeCompra.CuentaImputacionOrdenDeCompraInsert(obeOrdenCompra) <> 1 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If

        HelpClass.MsgBox("Registro Satisfactorio.")

        tsbEliminarCu.Enabled = False

    End Sub

    Private Sub tsbEliminarCu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarCu.Click

        tsbGuardarCu.Visible = False
        tsbEliminarCu.Visible = False

        tsbAgregarCu.Visible = True
        dgCuentasImputadas.Rows.Clear()
    End Sub

    Private Sub txtCodigoOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoOrigen.TextChanged

    End Sub

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Private Sub dgOrdenComprasSeleccionados_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOrdenComprasSeleccionados.CellValueChanged
        Dim ColName As String = dgOrdenComprasSeleccionados.Columns(e.ColumnIndex).Name
        If TxtTipoMaterial.Resultado IsNot Nothing And ColName = "GrillaCboCondicion" Then
            For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
                If CType(TxtTipoMaterial.Resultado, beAlmacen).PSCCMPRN = "MATPEL" Then
                    dgOrdenComprasSeleccionados.Columns("GrillaChkIQBF").ReadOnly = False
                    If dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value = "RE" Then
                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").ReadOnly = False
                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").ReadOnly = False
                    Else
                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value = ""
                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").Value = ""

                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").ReadOnly = True
                        dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").ReadOnly = True
                    End If
                Else

                    'CSR-HUNDRED-311016
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaChkIQBF").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUn").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaFechaCad").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaDesUN").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").ReadOnly = True



                    'CSR-HUNDRED-311016
                End If
            Next
            dgOrdenComprasSeleccionados.EndEdit()
        End If
    End Sub

    Private Sub TxtTipoMaterial_CambioDeTexto(ByVal objData As System.Object) Handles TxtTipoMaterial.CambioDeTexto
        'CSR-HUNDRED-311016
        If TxtTipoMaterial.Resultado IsNot Nothing Then
            If CType(TxtTipoMaterial.Resultado, beAlmacen).PSCCMPRN <> "MATPEL" Then
                For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").Value = ""
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").Value = ""
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUN").Value = ""
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaChkIQBF").Value = Nothing
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaChkIQBF").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboClase").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaDesUN").ReadOnly = True
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCodUn").ReadOnly = True
                Next

            Else

                For i As Integer = 0 To dgOrdenComprasSeleccionados.RowCount - 1
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaCboCondicion").ReadOnly = False
                    dgOrdenComprasSeleccionados.Rows(i).Cells("GrillaFechaCad").ReadOnly = False
                Next
            End If
        End If
        'CSR-HUNDRED-311016
    End Sub

    Private Sub btnLimpiarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarFecha.Click
        dgOrdenComprasSeleccionados.CurrentRow.Cells("GrillaFechaCad").Value = ""
    End Sub

    Private Sub dgOrdenComprasSeleccionados_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOrdenComprasSeleccionados.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                ctmsFecha.Items(0).Visible = False
                If (dgOrdenComprasSeleccionados.Rows.Count <= 0) Then Exit Sub
                Dim ColName As String = dgOrdenComprasSeleccionados.Columns(dgOrdenComprasSeleccionados.CurrentCell.ColumnIndex).Name
                ctmsFecha.Items(0).Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

    Private Sub dgOrdenComprasSeleccionados_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgOrdenComprasSeleccionados.EditingControlShowing
        If dgOrdenComprasSeleccionados.Columns(dgOrdenComprasSeleccionados.CurrentCell.ColumnIndex).Name = "GrillaCodUn" Then
            ' referencia a la celda  
            Dim validar As TextBox = CType(e.Control, TextBox)

            ' agregar el controlador de eventos para el KeyPress  
            AddHandler validar.KeyPress, AddressOf validar_Keypress
        End If
    End Sub

    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Obtener caracter  
        Dim caracter As Char = e.KeyChar

        ' comprobar si el caracter es un número o el retroceso  
        If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    'OMVB REQ15072019 HORA DE ENTREGA
    Public Shared Function CompletarCadena(ByVal Texto As String, ByVal Longitud As Integer, ByVal Caracter As String, ByVal Orientacion As HorizontalAlignment)
        Dim longitudActual As Integer = Texto.Length

        For i As Integer = longitudActual To Longitud - 1
            If Orientacion = HorizontalAlignment.Right Then
                Texto = Texto & Caracter
            Else
                Texto = Caracter & Texto
            End If
        Next
        Return Texto
    End Function

    Private Sub txtHoraEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraEntrega.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'OMVB REQ15072019 HORA DE ENTREGA


End Class