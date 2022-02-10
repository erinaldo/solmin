
Imports SOLMIN_CTZ.Entidades
Public Class frmTarifaFleteRuta

    Private oDsImporteTarifa As New DataSet
    Private olstRango As New List(Of DetalleTarifaTipoFlete)
    Public EsOSSeguimiento As Boolean = False

    Public Es_Cobro_Rango As Boolean = False
    Public Es_Pago_Rango As Boolean = False
    Public Es_Cobro_Rango_Exceso As Boolean = False
    Public Es_Pago_Rango_Exceso As Boolean = False
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _DetalleTarifaFlete = New List(Of DetalleTarifaTipoFlete)
    End Sub

    Private Function EsRango() As Boolean
        Dim es_rango As Boolean = False
        es_rango = (Es_Cobro_Rango = True Or Es_Pago_Rango = True Or Es_Cobro_Rango_Exceso = True Or Es_Pago_Rango_Exceso = True)
        Return es_rango
    End Function

    Private Sub stbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stbGuardar.Click
        If Validar_Tarifa_Flete_Ruta() Then
            If Not Validar_Servicio_Flete_Ruta() Then
                HelpClass.MsgBox("Existe una Ruta Asignada")
                Exit Sub
            Else
                If Validar_Grilla_Importe() = True Then
                    Guardar_Servicio_Flete_Ruta()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub



    Private _DetalleTarifaFlete As List(Of DetalleTarifaTipoFlete)

    Public Property DetalleTarifaFlete() As List(Of DetalleTarifaTipoFlete)
        Get
            Return _DetalleTarifaFlete
        End Get
        Set(ByVal value As List(Of DetalleTarifaTipoFlete))
            _DetalleTarifaFlete = value
        End Set
    End Property

    Private _DetalleTarifaFleteMod As DetalleTarifaTipoFlete

    Public Property DetalleTarifaFleteMod() As DetalleTarifaTipoFlete
        Get
            Return _DetalleTarifaFleteMod
        End Get
        Set(ByVal value As DetalleTarifaTipoFlete)
            _DetalleTarifaFleteMod = value
        End Set
    End Property



    'Validamos Si es Rango 
    'Private _Tarifa_Tipo_Rango As Boolean
    'Public Property Tarifa_Tipo_Rango() As Boolean
    '    Get
    '        Return _Tarifa_Tipo_Rango
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _Tarifa_Tipo_Rango = value
    '    End Set
    'End Property
    'Public EsRangoTarifaExceso As Boolean = False

    'Private Function Validar_Parametro_Rango() As Boolean
    '    Dim _dblCFRMPG1 As Double = 0
    '    Dim _dblCFRMPG2 As Double = 0
    '    If cboParametroFacturar.Resultado IsNot Nothing Then
    '        _dblCFRMPG1 = CType(cboParametroFacturar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
    '    Else
    '        _dblCFRMPG1 = 0
    '    End If

    '    If cboParametroPagar.Resultado IsNot Nothing Then
    '        _dblCFRMPG2 = CType(cboParametroPagar.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CFRMPG
    '    Else
    '        _dblCFRMPG2 = 0
    '    End If

    '    If _dblCFRMPG1 = 8 Or _dblCFRMPG1 = 15 Or _dblCFRMPG2 = 8 Or _dblCFRMPG2 = 15 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function


    Private Sub Guardar_Servicio_Flete_Ruta()
        Dim obeDetalleTarifaTipoFlete As New DetalleTarifaTipoFlete
        With obeDetalleTarifaTipoFlete
            'dwvrow.Cells(3).Value = intNCRRSR + 1 'objEntidad.NCRRSR

            .CUBORI = CType(cboOrigenUbigeo.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).UBIGEO
            .UBIGEO_O = CType(cboOrigenUbigeo.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).DESCRIPCION
            .CLCLOR = CType(cboLocalidadOrigen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD
            .ORIGEN = CType(cboLocalidadOrigen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TCMLCL
            .CUBDES = CType(cboDestinoUbigeo.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).UBIGEO
            .UBIGEO_D = CType(cboDestinoUbigeo.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).DESCRIPCION
            .CLCLDS = CType(cboLocalidadDestino.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD
            .DESTINO = CType(cboLocalidadDestino.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TCMLCL

            If cboMonedaLiquidacion.Resultado IsNot Nothing Then
                .CMNTRN = CType(cboMonedaLiquidacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMNDA1
                .MONEDA_COBRAR = CType(cboMonedaLiquidacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TMNDA
            Else
                .CMNTRN = 0
                .MONEDA_COBRAR = ""
            End If

            .TOBSSR = txtObservacion.Text.Trim
            .QDSTVR = txtDistancia.Text
            .CSTNDT = IIf(IsNumeric(Me.txtCostoPorTonelada.Text.Trim), txtCostoPorTonelada.Text, 0)
            .ITRSRT = Me.txtTarifaServicio.Text
            'MOneda_Cobrar
            '.MONEDA_COBRAR = CType(cboMonedaLiquidacion.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TMNDA
            If cboMonedaLiquidacionTransportista.Resultado IsNot Nothing Then
                .CMNLQT = CType(cboMonedaLiquidacionTransportista.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMNDA1
                .MONEDA_PAGAR = CType(cboMonedaLiquidacionTransportista.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TMNDA
            Else
                .CMNLQT = 0
                .MONEDA_PAGAR = ""
            End If
            .ILSFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            '.CMNLQT = CType(cboMonedaLiquidacionTransportista.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMNDA1
            'Moneda a Pagar
            '.MONEDA_PAGAR = CType(cboMonedaLiquidacionTransportista.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TMNDA          
            .SFCRTV = IIf(Me.chkRetornoVacio.Checked = True, "I", "V")
            .SSRVFE = IIf(Me.rbtFijo.Checked, "F", "E")
            .ILCFTR = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            .ILQFMX = IIf(Me.txtImportePagarTransportista.Text.Trim.Length = 0, 0, Me.txtImportePagarTransportista.Text)
            .CUNSRA = CType(cboUnidadMedidaRuta.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CUNDMD
            .SSRVCB = IIf(txtTarifaServicio.Text.Trim.Length > 0, "X", "")
            .SSRVPG = IIf(txtImportePagarTransportista.Text.Trim.Length > 0, "X", "")
            'RCS-HUNDRED-INICIO
            'Tarifa interna
            '.CMNDTI = CType(cboMonedaTarifaInterna.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CMNDA1
            .CMNDTI = 0
            '.MONEDA_TARINT = CType(cboMonedaTarifaInterna.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).TMNDA
            .MONEDA_TARINT = ""
            '.ISRVTI = IIf(txtTarifaInterna.Text.Trim.Length = 0, 0, txtTarifaInterna.Text)
            .ISRVTI = 0
            .SNTVJE = CType(cbosentido.Resultado, SOLMIN_CTZ.Entidades.beAyudaGeneral).PSCODIGO
            .SNTVJE_DESC = CType(cbosentido.Resultado, SOLMIN_CTZ.Entidades.beAyudaGeneral).PSDESCRIPCION

            'RCS-HUNDRED-FIN
        End With

        'EsRango
        'If _Tarifa_Tipo_Rango Then
        If EsRango() Then
            Dim olistRango As New List(Of RangoTarifaXTarifaFlete)
            For Each obeRango As RangoTarifaXTarifaFlete In dtgImporte.DataSource
                olistRango.Add(obeRango)
            Next
            If olistRango.Count > 0 Then
                obeDetalleTarifaTipoFlete.RangoTarifa = olistRango
            End If
        End If
        'Eliimimos Si es que es por modificación
        If _DetalleTarifaFleteMod IsNot Nothing Then
            obeDetalleTarifaTipoFlete.NCRRSR = _DetalleTarifaFleteMod.NCRRSR
            _DetalleTarifaFlete.Remove(_DetalleTarifaFleteMod)
        End If
        'Agregamos
        _DetalleTarifaFlete.Add(obeDetalleTarifaTipoFlete)

    End Sub

    Private Function Validar_Grilla_Importe() As Boolean
        Dim bolRspta As Boolean = True
        'DDD()
        For i As Integer = 0 To dtgImporte.Rows.Count - 2
            If dtgImporte.Rows(i).Cells("QIMPIN").Value Is Nothing Then
                MessageBox.Show("El Importe Inicial debe ser mayor a cero.")
                bolRspta = False
                Exit For
            End If
            If dtgImporte.Rows(i).Cells("QIMPFN").Value Is Nothing Then
                MessageBox.Show("El Importe Final debe ser mayor a cero.")
                bolRspta = False
                Exit For
            End If
            'RCS-HUNDRED-INICIO
            'If dtgImporte.Rows(i).Cells("ISRVTI").Value Is Nothing Then
            '    MessageBox.Show("La Tarifa Interna debe ser mayor a cero.")
            '    bolRspta = False
            '    Exit For
            'End If
            'RCS-HUNDRED-FIN
        Next
        Return bolRspta
    End Function


    Private Function Validar_Servicio_Flete_Ruta() As Boolean
        For Each obeDetalleTarifa As DetalleTarifaTipoFlete In _DetalleTarifaFlete
            If _DetalleTarifaFleteMod Is Nothing OrElse (obeDetalleTarifa IsNot _DetalleTarifaFleteMod) Then
                If obeDetalleTarifa.CLCLOR = CType(cboLocalidadOrigen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD And obeDetalleTarifa.CLCLDS = CType(cboLocalidadDestino.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD Then
                    Return False
                End If
            End If

        Next
        Return True
        'Dim objEntidad As New DetalleTarifaTipoFlete
        'Dim intCont As Integer
        'Dim lintEncontrado As Integer = 0
        'objEntidad.CCMPN = oTarifa.CCMPN
        'objEntidad.NRCTSL = oTarifa.NRCTSL
        'objEntidad.CLCLOR = CType(cboLocalidadOrigen.Resultado, mantenimientos.ClaseGeneral).CLCLD
        'objEntidad.CLCLDS = CType(cboLocalidadDestino.Resultado, mantenimientos.ClaseGeneral).CLCLD
        'If oDetTarTipFlete.Existe_Flete_Ruta(objEntidad) = 1 Then
        '    Return False
        'Else
        '    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
        '        If Me.dtgTarifaFleteRuta.Rows.Count > 0 Then
        '            With Me.dtgTarifaFleteRuta
        '                For intCont = 0 To .Rows.Count - 1
        '                    If .Rows(intCont).Cells("CLCLOR").Value = CType(cboLocalidadOrigen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD And _
        '                   .Rows(intCont).Cells("CLCLDS").Value = CType(cboLocalidadDestino.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD Then
        '                        lintEncontrado = 1
        '                        Return False
        '                        Exit For
        '                    End If
        '                Next
        '            End With

        '            If lintEncontrado = 0 Then
        '                Return True
        '            End If

        '        Else
        '            Return True
        '        End If
        '    ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        '        If Me.dtgTarifaFleteRuta.Rows.Count - 1 > 0 Then
        '            With Me.dtgTarifaFleteRuta
        '                For intCont = 0 To .Rows.Count - 1
        '                    If Me.dtgTarifaFleteRuta.CurrentRow.Index <> intCont Then
        '                        If .Rows(intCont).Cells("CLCLOR").Value = CType(cboLocalidadOrigen.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD And _
        '                       .Rows(intCont).Cells("CLCLDS").Value = CType(cboLocalidadDestino.Resultado, SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral).CLCLD Then
        '                            lintEncontrado = 1
        '                            Return False
        '                            Exit For
        '                        End If
        '                    End If
        '                Next
        '            End With

        '            If lintEncontrado = 0 Then
        '                Return True
        '            End If

        '        Else
        '            Return True
        '        End If
        '    End If

        '    ' Return True
        '    'End If
        '    Return True
    End Function


    Private Function Validar_Tarifa_Flete_Ruta() As Boolean
        dtgImporte.EndEdit()

        'Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
        Dim strError As String = ""
        If cboOrigenUbigeo.Resultado Is Nothing Then
            strError += "* Origen Ubigeo" & Chr(13)
        End If
        If cboDestinoUbigeo.Resultado Is Nothing Then
            strError += "* Origen Ubigeo" & Chr(13)
        End If

        If cboLocalidadOrigen.Resultado Is Nothing Then
            strError += "* Localidad Origen" & Chr(13)
        End If

        If cboLocalidadDestino.Resultado Is Nothing Then
            strError += "* Localidad Destino" & Chr(13)
        End If
        If txtDistancia.Text = "" Then
            strError += "* Distancia" & Chr(13)
        End If
        If txtCostoPorTonelada.Text = "" Then
            strError += "* Valor Referencial" & Chr(13)
        End If
        'If txtTarifaServicio.Text = "" Then
        '    strError += "* Tarifa Cobrar" & Chr(13)
        'End If
        'If cboMonedaLiquidacion.Resultado Is Nothing Then
        '    strError += "* Moneda de Tarifa Cobrar" & Chr(13)
        'End If
        'If txtImportePagarTransportista.Text = "" Then
        '    strError += "* Tarifa Pagar" & Chr(13)
        'End If
        'If cboMonedaLiquidacionTransportista.Resultado Is Nothing Then
        '    strError += "* Moneda de Tarifa Pagar" & Chr(13)
        'End If

        If EsOSSeguimiento = False Then

            'If Es_Cobro_Rango = True Or Es_Cobro_Rango_Exceso = True Then
            '    txtTarifaServicio.Enabled = False
            'End If
            'If Es_Cobro_Rango = True Or Es_Cobro_Rango_Exceso = True Then
            '    txtImportePagarTransportista.Enabled = False
            'End If

            If (txtTarifaServicio.Enabled = True And Val(txtTarifaServicio.Text) = 0) AndAlso (txtImportePagarTransportista.Enabled = True And Val(txtImportePagarTransportista.Text) = 0) Then
                strError += "* Ingreso cobro o pago mayor a 0." & Chr(13)
            End If
            
            'If Val(txtImportePagarTransportista.Text) = 0 AndAlso Val(txtTarifaServicio.Text) = 0 Then
            '    strError += "* Ingreso cobro o pago mayor a 0." & Chr(13)
            'End If
     
        End If



        If txtTarifaServicio.Text = "" Then
            strError += "* Tarifa Cobrar" & Chr(13)
        End If
        If cboMonedaLiquidacion.Resultado Is Nothing And Val(txtTarifaServicio.Text) <> 0 Then
            strError += "* Moneda de Tarifa Cobrar" & Chr(13)
        End If
        If txtImportePagarTransportista.Text = "" Then
            strError += "* Tarifa Pagar" & Chr(13)
        End If
        If cboMonedaLiquidacionTransportista.Resultado Is Nothing And Val(txtImportePagarTransportista.Text) <> 0 Then
            strError += "* Moneda de Tarifa Pagar" & Chr(13)
        End If



        'RCS-HUNDRED-INICIO
        'If txtTarifaInterna.Text = "" Then
        '    strError += "* Tarifa Interna" & Chr(13)
        'End If
        'If cboMonedaTarifaInterna.Resultado Is Nothing Then
        '    strError += "* Moneda de Tarifa Interna" & Chr(13)
        'End If
        'RCS-HUNDRED-FIN
        If cboUnidadMedidaRuta.Resultado Is Nothing Then
            strError += "* Unidad Medida" & Chr(13)
        End If
        If cbosentido.Resultado Is Nothing Then
            strError += "* Sentido" & Chr(13)
        End If

        'EsRango
        If EsRango() = True Then
            'If _Tarifa_Tipo_Rango = True Then
            If dtgImporte.Rows.Count = 0 Then
                strError += "* Rango(s) de Tarifa" & Chr(13)
            End If
            For Each obeRango As RangoTarifaXTarifaFlete In Me.dtgImporte.DataSource
                If obeRango.QIMPIN = 0 Then
                    strError += "* En el Rango de Tarifa el Rango Inicial debe de ser mayor que cero" & Chr(13)
                End If
                If obeRango.QIMPIN > obeRango.QIMPFN Then
                    strError += "* En el Rango de Tarifa el Rango Final debe ser mayor que el Importe Inicial " & Chr(13)
                    Exit For
                End If
            Next
        End If


        'If EsRangoTarifaExceso = True Then
        If Es_Cobro_Rango_Exceso = True Or Es_Pago_Rango_Exceso = True Then
            For Each obeRango As RangoTarifaXTarifaFlete In Me.dtgImporte.DataSource
                If obeRango.QRNGBS < obeRango.QIMPIN OrElse obeRango.QRNGBS > obeRango.QIMPFN Then
                    strError += "* En el Rango de Tarifa la base debe estar en los rango inicial y final." & Chr(13)
                End If
            Next
        End If


        If strError.Trim.Length > 0 Then
            HelpClass.MsgBox("DEBE DE INGRESAR: " & Chr(13) & strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub stbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        Try

            Dim obeRangoTarifaXTarifaFlete As New RangoTarifaXTarifaFlete
            BindingSource1.Add(obeRangoTarifaXTarifaFlete)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If Me.dtgImporte.CurrentCellAddress.Y = -1 Then Exit Sub

            If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
                If Me.dtgImporte.CurrentRow.DataBoundItem.NSEQIN <> 0 Then
                    'Dim objEntidad As New RangoTarifaXTarifaFlete
                    Dim oRangoTarifaFlete As New SOLMIN_CTZ.NEGOCIO.clsRangoTarifaXTarifaFlete
                    'objEntidad.CCMPN = oTarifa.CCMPN
                    'objEntidad.NRCTSL = oTarifa.NRCTSL
                    'objEntidad.NRTFSV = txtCodTarifa.Text.Trim
                    'objEntidad.NCRRSR = dtgImporte.Rows(li_index).Cells(0).Value
                    'objEntidad.NSEQIN = dtgImporte.Rows(li_index).Cells(1).Value
                    If Not oRangoTarifaFlete.Eliminar_Rango_X_Tarifa_Flete(Me.dtgImporte.CurrentRow.DataBoundItem) Then
                        HelpClass.ErrorMsgBox()
                    End If
                    BindingSource1.Remove(Me.dtgImporte.CurrentRow.DataBoundItem)

                Else
                    BindingSource1.Remove(Me.dtgImporte.CurrentRow.DataBoundItem)

                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmTarifaFleteRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'If Not _Tarifa_Tipo_Rango Then
            '    'KryptonSplitContainer1.Panel2Collapsed = True
            '    ToolStrip1.Enabled = False
            'Else
            '    ToolStrip1.Enabled = False
            'End If
            'If _Tarifa_Tipo_Rango = True Then
            If EsRango() = True Then
                ToolStrip1.Enabled = True
            Else
                ToolStrip1.Enabled = False
            End If

            If Es_Cobro_Rango = True Or Es_Cobro_Rango_Exceso = True Then
                txtTarifaServicio.Enabled = False
            End If
            If Es_Pago_Rango = True Or Es_Pago_Rango_Exceso = True Then
                txtImportePagarTransportista.Enabled = False
            End If

            'If EsRangoTarifaExceso = False Then

            If (Es_Cobro_Rango_Exceso = False And Es_Pago_Rango_Exceso = False) Then
                dtgImporte.Columns("QRNGBS").ReadOnly = True
            End If
            If Es_Cobro_Rango_Exceso = False Then
                dtgImporte.Columns("ITRCAD").ReadOnly = True
            End If
            If Es_Pago_Rango_Exceso = False Then
                dtgImporte.Columns("ITRPAD").ReadOnly = True
            End If

            'If (Es_Cobro_Rango_Exceso = False Or Es_Pago_Rango_Exceso = False) Then
            '    dtgImporte.Columns("QRNGBS").ReadOnly = True
            '    dtgImporte.Columns("ITRCAD").ReadOnly = True
            '    dtgImporte.Columns("ITRPAD").ReadOnly = True
            'End If


            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            Dim oUM As New SOLMIN_CTZ.NEGOCIO.clsUM
            oColumnas.Name = "PSCODIGO"
            oColumnas.DataPropertyName = "PSCODIGO"
            oColumnas.HeaderText = "Código"
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSDESCRIPCION"
            oColumnas.DataPropertyName = "PSDESCRIPCION"
            oColumnas.HeaderText = "Sentido"
            oListColum.Add(2, oColumnas)


            Dim oListbeAyudaGeneral As New List(Of beAyudaGeneral)
            Dim blclsAyudaGeneral As New SOLMIN_CTZ.NEGOCIO.clsAyudaGeneral
            oListbeAyudaGeneral = blclsAyudaGeneral.ListaTablaAyudaGeneral("SDSNVJ", "")

            If oListbeAyudaGeneral.Count > 0 Then
                cbosentido.DataSource = oListbeAyudaGeneral
            Else
                cbosentido.DataSource = Nothing
            End If
            cbosentido.ListColumnas = oListColum
            cbosentido.Cargas()
            cbosentido.Limpiar()
            cbosentido.ValueMember = "PSCODIGO"
            cbosentido.DispleyMember = "PSDESCRIPCION"



            Cargar_UnidadMedida()
            Cargar_Localidad()
            Cargar_Ubigeo()
            Cargar_Moneda_Liquidacion()
            txtCostoPorTonelada.Text = Val("0.000")
            txtTarifaServicio.Text = Val("0.000")
            txtImportePagarTransportista.Text = Val("0.000")
            'txtTarifaInterna.Text = Val("0.000") 'RCS-HUNDRED
            If _DetalleTarifaFleteMod IsNot Nothing Then
                Mostrar_Tarifa_Flete_Ruta()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    'cbosentido


    Private Sub Mostrar_Tarifa_Flete_Ruta()
        'Try
        cboOrigenUbigeo.Valor = _DetalleTarifaFleteMod.CUBORI
        cboLocalidadOrigen.Valor = _DetalleTarifaFleteMod.CLCLOR
        cboDestinoUbigeo.Valor = _DetalleTarifaFleteMod.CUBDES
        cboLocalidadDestino.Valor = _DetalleTarifaFleteMod.CLCLDS
        cboMonedaLiquidacion.Valor = _DetalleTarifaFleteMod.CMNTRN
        txtObservacion.Text = _DetalleTarifaFleteMod.TOBSSR
        txtDistancia.Text = _DetalleTarifaFleteMod.QDSTVR
        txtCostoPorTonelada.Text = Val(_DetalleTarifaFleteMod.CSTNDT) 'String.Format("{0:n}", _DetalleTarifaFleteMod.CSTNDT)
        txtTarifaServicio.Text = Val(_DetalleTarifaFleteMod.ITRSRT) 'String.Format("{0:n}", _DetalleTarifaFleteMod.ITRSRT)
        cboMonedaLiquidacion.Valor = _DetalleTarifaFleteMod.CMNTRN
        txtImportePagarTransportista.Text = Val(_DetalleTarifaFleteMod.ILSFTR) 'String.Format("{0:n}", _DetalleTarifaFleteMod.ILSFTR)
        cboMonedaLiquidacionTransportista.Valor = _DetalleTarifaFleteMod.CMNLQT
        'RCS-HUNDRED-INICIO
        'txtTarifaInterna.Text = Val(_DetalleTarifaFleteMod.ISRVTI)
        'cboMonedaTarifaInterna.Valor = _DetalleTarifaFleteMod.CMNDTI
        'RCS-HUNDRED-FIN
        Me.chkRetornoVacio.Checked = IIf(_DetalleTarifaFleteMod.SFCRTV.ToString.Trim = "I", True, False)
        Me.rbtFijo.Checked = IIf(_DetalleTarifaFleteMod.SSRVFE.ToString.Trim = "F", True, False)
        Me.rbtEventual.Checked = IIf(_DetalleTarifaFleteMod.SSRVFE.ToString.Trim = "E", True, False)
        cboUnidadMedidaRuta.Valor = _DetalleTarifaFleteMod.CUNSRA

        cbosentido.Valor = _DetalleTarifaFleteMod.SNTVJE
        ''Rango de Tarifa

        If _DetalleTarifaFleteMod.RangoTarifa IsNot Nothing Then
            For Each obeRango As RangoTarifaXTarifaFlete In _DetalleTarifaFleteMod.RangoTarifa
                BindingSource1.Add(obeRango)
            Next
        End If
        'Catch ex As Exception

        'End Try

    End Sub

#Region "Cargar información"
    Private Sub Cargar_UnidadMedida()
        'Try
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim oUM As New SOLMIN_CTZ.NEGOCIO.clsUM
        oColumnas.Name = "CUNDMD"
        oColumnas.DataPropertyName = "CUNDMD"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPUN"
        oColumnas.DataPropertyName = "TCMPUN"
        oColumnas.HeaderText = "Unidad de Medida"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "CUNDMD"
        oColumnas2.DataPropertyName = "CUNDMD"
        oColumnas2.HeaderText = "Código"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "TCMPUN"
        oColumnas2.DataPropertyName = "TCMPUN"
        oColumnas2.HeaderText = "Unidad de Medida"
        oListColum2.Add(2, oColumnas2)

        Dim oListColum3 As New Hashtable
        Dim oColumnas3 As New DataGridViewTextBoxColumn
        oColumnas3.Name = "CUNDMD"
        oColumnas3.DataPropertyName = "CUNDMD"
        oColumnas3.HeaderText = "Código"
        oListColum3.Add(1, oColumnas3)

        oColumnas3 = New DataGridViewTextBoxColumn
        oColumnas3.Name = "TCMPUN"
        oColumnas3.DataPropertyName = "TCMPUN"
        oColumnas3.HeaderText = "Unidad de Medida"
        oListColum3.Add(2, oColumnas3)
        oUM.Crear_UM()
        Dim olUM As New List(Of mantenimientos.ClaseGeneral)
        olUM = oUM.Listar_UnidadMedida()


        If olUM.Count > 0 Then
            cboUnidadMedidaRuta.DataSource = olUM
        Else
            cboUnidadMedidaRuta.DataSource = Nothing
        End If
        cboUnidadMedidaRuta.ListColumnas = oListColum3
        cboUnidadMedidaRuta.Cargas()
        cboUnidadMedidaRuta.Limpiar()
        cboUnidadMedidaRuta.ValueMember = "CUNDMD"
        cboUnidadMedidaRuta.DispleyMember = "TCMPUN"
        'End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Cargar_Localidad()
        'Try
        Dim oListColum As New Hashtable
        Dim oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Cod. Localidad"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Localidad"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "CLCLD"
        oColumnas2.DataPropertyName = "CLCLD"
        oColumnas2.HeaderText = "Cod. Localidad"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "TCMLCL"
        oColumnas2.DataPropertyName = "TCMLCL"
        oColumnas2.HeaderText = "Localidad"
        oListColum2.Add(2, oColumnas2)

        Dim olLocalidad As New List(Of mantenimientos.ClaseGeneral)
        olLocalidad = oClaseGeneral.Listar_Localidad_Origen()

        If olLocalidad.Count > 0 Then
            cboLocalidadOrigen.DataSource = olLocalidad
            cboLocalidadDestino.DataSource = olLocalidad
        Else
            cboLocalidadOrigen.DataSource = Nothing
            cboLocalidadDestino.DataSource = Nothing
        End If
        cboLocalidadOrigen.ListColumnas = oListColum
        cboLocalidadOrigen.Cargas()
        cboLocalidadOrigen.Limpiar()
        cboLocalidadOrigen.ValueMember = "CLCLD"
        cboLocalidadOrigen.DispleyMember = "TCMLCL"

        cboLocalidadDestino.ListColumnas = oListColum2
        cboLocalidadDestino.Cargas()
        cboLocalidadDestino.Limpiar()
        cboLocalidadDestino.ValueMember = "CLCLD"
        cboLocalidadDestino.DispleyMember = "TCMLCL"

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Cargar_Ubigeo()
        'Try
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
        oColumnas.Name = "UBIGEO"
        oColumnas.DataPropertyName = "UBIGEO"
        oColumnas.HeaderText = "Ubigeo"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESCRIPCION"
        oColumnas.DataPropertyName = "DESCRIPCION"
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "UBIGEO"
        oColumnas2.DataPropertyName = "UBIGEO"
        oColumnas2.HeaderText = "Ubigeo"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "DESCRIPCION"
        oColumnas2.DataPropertyName = "DESCRIPCION"
        oColumnas2.HeaderText = "Descripción"
        oListColum2.Add(2, oColumnas2)

        Dim olUbigeo As New List(Of mantenimientos.ClaseGeneral)
        olUbigeo = oClaseGeneral.Listar_Ubigeo()

        If olUbigeo.Count > 0 Then
            cboOrigenUbigeo.DataSource = olUbigeo
            cboDestinoUbigeo.DataSource = olUbigeo
        Else
            cboOrigenUbigeo.DataSource = Nothing
            cboDestinoUbigeo.DataSource = Nothing
        End If
        cboOrigenUbigeo.ListColumnas = oListColum
        cboOrigenUbigeo.Cargas()
        cboOrigenUbigeo.Limpiar()
        cboOrigenUbigeo.ValueMember = "UBIGEO"
        cboOrigenUbigeo.DispleyMember = "DESCRIPCION"

        cboDestinoUbigeo.ListColumnas = oListColum2
        cboDestinoUbigeo.Cargas()
        cboDestinoUbigeo.Limpiar()
        cboDestinoUbigeo.ValueMember = "UBIGEO"
        cboDestinoUbigeo.DispleyMember = "DESCRIPCION"

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Cargar_Moneda_Liquidacion()
        'Try
        'RCS-HUNDRED-INICIO
        Dim oListColum, oListColum2, oListColum3 As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim oClaseGeneral As New SOLMIN_CTZ.NEGOCIO.clsClaseGeneral
        oColumnas.Name = "CMNDA1"
        oColumnas.DataPropertyName = "CMNDA1"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oListColum2.Add(1, oColumnas.Clone())
        oListColum3.Add(1, oColumnas.Clone())

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMNDA"
        oColumnas.DataPropertyName = "TMNDA"
        oColumnas.HeaderText = "Moneda"
        oListColum.Add(2, oColumnas)
        oListColum2.Add(2, oColumnas.Clone())
        oListColum3.Add(2, oColumnas.Clone())

        Dim olMoneda As New List(Of mantenimientos.ClaseGeneral)
        olMoneda = oClaseGeneral.Listar_Moneda()

        If olMoneda.Count > 0 Then
            cboMonedaLiquidacion.DataSource = olMoneda
            cboMonedaLiquidacionTransportista.DataSource = olMoneda
            'cboMonedaTarifaInterna.DataSource = olMoneda
        Else
            cboMonedaLiquidacion.DataSource = Nothing
            cboMonedaLiquidacionTransportista.DataSource = Nothing
            'cboMonedaTarifaInterna.DataSource = Nothing
        End If
        cboMonedaLiquidacion.ListColumnas = oListColum
        cboMonedaLiquidacion.Cargas()
        cboMonedaLiquidacion.Limpiar()
        cboMonedaLiquidacion.ValueMember = "CMNDA1"
        cboMonedaLiquidacion.DispleyMember = "TMNDA"

        cboMonedaLiquidacionTransportista.ListColumnas = oListColum2
        cboMonedaLiquidacionTransportista.Cargas()
        cboMonedaLiquidacionTransportista.Limpiar()
        cboMonedaLiquidacionTransportista.ValueMember = "CMNDA1"
        cboMonedaLiquidacionTransportista.DispleyMember = "TMNDA"

        'cboMonedaTarifaInterna.ListColumnas = oListColum3
        'cboMonedaTarifaInterna.Cargas()
        'cboMonedaTarifaInterna.ValueMember = "CMNDA1"
        'cboMonedaTarifaInterna.DispleyMember = "TMNDA"
        'RCS-HUNDRED-FIN
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub


#End Region

    Private Sub dtgImporte_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dtgImporte.DataError

    End Sub

    Private Sub dtgImporte_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgImporte.EditingControlShowing

        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = dtgImporte.Columns(dtgImporte.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "QIMPIN"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "QIMPFN"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "ITRSRT1"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "ITRAPG"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"

                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
                Case "ISRVTI"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "QRNGBS"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "ITRCAD"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "ITRPAD"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-3"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub txtDistancia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDistancia.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCostoPorTonelada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoPorTonelada.KeyPress
        Try
            CType(sender, TextBox).Tag = "10-3"
            Dim bolSel As Boolean = False
            If txtCostoPorTonelada.SelectedText.Length > 0 Then
                bolSel = True
            End If
            Event_KeyPress_NumeroWithDecimal2(sender, e, bolSel)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCostoPorTonelada_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostoPorTonelada.Leave
        Try
            If txtCostoPorTonelada.Text.EndsWith(".") Then
                txtCostoPorTonelada.Text = txtCostoPorTonelada.Text.Replace(".", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTarifaServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarifaServicio.KeyPress
        CType(sender, TextBox).Tag = "10-3"
        Dim bolSel As Boolean = False
        If txtTarifaServicio.SelectedText.Length > 0 Then
            bolSel = True
        End If
        Event_KeyPress_NumeroWithDecimal2(sender, e, bolSel)
    End Sub

    Private Sub txtTarifaServicio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTarifaServicio.Leave
        If txtTarifaServicio.Text.EndsWith(".") Then
            txtTarifaServicio.Text = txtTarifaServicio.Text.Replace(".", "")
        End If
    End Sub

    Private Sub txtImportePagarTransportista_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportePagarTransportista.KeyPress
        CType(sender, TextBox).Tag = "10-3"
        Dim bolSel As Boolean = False
        If txtImportePagarTransportista.SelectedText.Length > 0 Then
            bolSel = True
        End If
        Event_KeyPress_NumeroWithDecimal2(sender, e, bolSel)
    End Sub

    Private Sub txtImportePagarTransportista_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImportePagarTransportista.Leave
        If txtImportePagarTransportista.Text.EndsWith(".") Then
            txtImportePagarTransportista.Text = txtImportePagarTransportista.Text.Replace(".", "")
        End If
        If sender.Text.ToString.Trim = "" Then
            txtImportePagarTransportista.Text = "0.000" 'RCS-HUNDRED
        End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal estado As Boolean)
        If clsComun.SoloNumerosConDecimal2(CType(sender, TextBox), CShort(Asc(e.KeyChar)), estado) = 0 Then
            e.Handled = True
        End If
        'If clsComun.SoloNumerosConDecimal2(CType(sender, TextBox), CShort(Asc(e.KeyChar)), estado) = 8 Then
        'e.Handled = True
        'End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If clsComun.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgImporte_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtgImporte.CellValidating
        Try
          
                If e.RowIndex = -1 Then Exit Sub
                Dim row As DataGridViewRow = dtgImporte.CurrentRow
                If IsNumeric(e.FormattedValue) Then

                    Dim value As Object = e.FormattedValue 'row.Cells("QIMPIN").Value
                    If (row.IsNewRow) Then Return
                    If (Not (IsNumeric(value))) Then
                    stbGuardar.Enabled = False

                        e.Cancel = True
                        HelpClass.MsgBox("Debe de Ingresar el Importe Inicial." & Chr(10), MessageBoxIcon.Warning)
                        'dtgImporte.Rows(e.RowIndex).ErrorText = "Debe de Ingresar el Importe Inicial."
                        Return
                    End If
                    Dim columnName As String = dtgImporte.Columns(e.ColumnIndex).Name
                    For i As Integer = 0 To dtgImporte.Rows.Count - 2
                        If i < e.RowIndex Then
                            If columnName = "QIMPIN" Then
                                If Convert.ToDouble(dtgImporte.Item("QIMPIN", i).Value) = Convert.ToDouble(e.FormattedValue) Then
                                    'dtgImporte.Rows(e.RowIndex).ErrorText = "Debe de Ingresar el Importe Inicial diferente."
                                stbGuardar.Enabled = False

                                    e.Cancel = True
                                    HelpClass.MsgBox("Debe de ingresar el Importe Inicial diferente." & Chr(10), MessageBoxIcon.Warning)
                                    Return
                                    Exit For
                                End If

                                If Convert.ToDouble(dtgImporte.Item("QIMPIN", i).Value) <= Convert.ToDouble(e.FormattedValue) And Convert.ToDouble(e.FormattedValue) <= Convert.ToDouble(dtgImporte.Item("QIMPFN", i).Value) Then
                                    'dtgImporte.Rows(e.RowIndex).ErrorText = "Debe de Ingresar el Importe Inicial diferente."
                                stbGuardar.Enabled = False

                                    e.Cancel = True
                                    HelpClass.MsgBox("Debe de ingresar el Importe Inicial diferente." & Chr(10), MessageBoxIcon.Warning)
                                    Return
                                    Exit For
                                End If
                            End If
                        End If
                    Next

                    If columnName = "QIMPFN" Then
                        If e.FormattedValue IsNot Nothing Then
                            If Convert.ToDouble(e.FormattedValue) < Convert.ToDouble(row.Cells("QIMPIN").Value) Then
                                'dtgImporte.Rows(e.RowIndex).ErrorText = "El Importe Final debe ser mayor que el Importe Inicial."
                            stbGuardar.Enabled = False

                                e.Cancel = True
                                HelpClass.MsgBox("El Importe Final debe ser mayor que el Importe Inicial." & Chr(10), MessageBoxIcon.Warning)
                                Return
                            End If

                        End If
                    End If

                'If columnName = "QIMPIN" Then
                '    If Convert.ToDouble(e.FormattedValue) > Convert.ToDouble(row.Cells("QIMPFN").Value) Then
                '    stbGuardar.Enabled = False

                '        'e.Cancel = True
                '        HelpClass.MsgBox("El Importe Final debe ser mayor que el Importe Inicial." & Chr(10), MessageBoxIcon.Warning)
                '        Return
                '    End If

                'End If

                    If e.Cancel = False Then
                    stbGuardar.Enabled = True

                    End If
                'Else
                '    e.Cancel = True
                'stbGuardar.Enabled = False

                '    HelpClass.MsgBox("Debe ingresar un Importe válido" & Chr(10), MessageBoxIcon.Warning)
                '    Exit Sub
                End If
            If Val("" & e.FormattedValue & "") < 0 Then


                e.Cancel = True
                stbGuardar.Enabled = False

                HelpClass.MsgBox("Debe ingresar un Importe mayor o igual a cero" & Chr(10), MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'RCS-HUNDRED-INICIO
    'Private Sub txtTarifaInterna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    CType(sender, TextBox).Tag = "10-3"
    '    Dim bolSel As Boolean = False
    '    If txtTarifaInterna.SelectedText.Length > 0 Then
    '        bolSel = True
    '    End If
    '    Event_KeyPress_NumeroWithDecimal2(sender, e, bolSel)
    'End Sub

    'Private Sub txtTarifaInterna_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtTarifaInterna.Text.EndsWith(".") Then
    '        txtTarifaInterna.Text = txtTarifaInterna.Text.Replace(".", "")
    '    End If
    '    If sender.Text.ToString.Trim = "" Then
    '        txtTarifaInterna.Text = "0.000"
    '    End If
    'End Sub
    'RCS-HUNDRED-FIN


End Class
