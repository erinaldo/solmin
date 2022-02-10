Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.TYPEDEF.OrdenCompra.ItemOC
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.DATA
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmOrdenServicioSDS

#Region " Tipo de Datos "
#End Region

#Region " Atributos "
    '--Mercadería
    Private strMercaderia_CMRCLR As String = ""

    Private objMovimientoMercaderia As clsMovimientoMercaderia
    Private objSqlManager As SqlManager
    '-- Persiana
    Private strPersiana As String = ""

    '--Cliente
    Private intCliente_CCLNT As Int64 = 0

    '--Orden Servicio
    Private intOrdenServicio As Int64 = 0

    '--Contrato
    Private intNroContrato As Int64 = 0
    Private intNroCorrelativoContrato As Int64 = 0
    Private intNroAutorizacionContrato As Int64 = 0
    Private strTipoDeposito As String = ""
    Private strEstado As String = ""
    Private intTipoInvoke As Int16 = 0
    Private NORDSR As String = ""
    Private NCNTRR As String = ""
    Private CUNCN5 As String = ""
    Private CUNPS5 As String = ""
    Private CUNVL5 As String = ""
    'Public docu As Integer = 0
    'Public pcodigo As Int32 = 0
    'Public pnguirm As Int32 = 0
    'Public pnorcml As String = ""


    Dim strMensajeError As String = ""

    Public Property pCUNVL5() As String
        Get
            Return CUNVL5
        End Get

        Set(value As String)
            CUNVL5 = value
        End Set
    End Property




    Public Property pCUNPS5() As String
        Get
            Return CUNPS5
        End Get

        Set(value As String)
            CUNPS5 = value
        End Set
    End Property





    Public Property pCUNCN5() As String
        Get
            Return CUNCN5
        End Get

        Set(value As String)
            CUNCN5 = value
        End Set
    End Property







    Public Property pNORDSR() As String
        Get
            Return NORDSR
        End Get

        Set(value As String)
            NORDSR = value
        End Set
    End Property

    Public Property pNCNTR() As String
        Get
            Return NCNTRR
        End Get

        Set(value As String)
            NCNTRR = value
        End Set
    End Property












    '--Información
    Private objHashTable As New Hashtable
#End Region

#Region " Propiedades "
    Public WriteOnly Property pintTipoInvoke() As Int16
        Set(value As Int16)
            intTipoInvoke = value
        End Set
    End Property
    Public WriteOnly Property Cliente_CCLNT() As Int64
        Set(ByVal value As Int64)
            intCliente_CCLNT = value
        End Set
    End Property

    Public WriteOnly Property Mercaderia_CMRCLR() As String
        Set(ByVal value As String)
            strMercaderia_CMRCLR = value
        End Set
    End Property

    Public ReadOnly Property pobjHashTable() As Hashtable
        Get
            Return objHashTable
        End Get
    End Property

    'Public ReadOnly Property OrdenServicio() As Int64
    '  Get
    '    Return intOrdenServicio
    '  End Get
    'End Property

    'Public ReadOnly Property NroContrato() As Int64
    '  Get
    '    Return intNroContrato
    '  End Get
    'End Property

    'Public ReadOnly Property NroCorrelativoContrato() As Int64
    '  Get
    '    Return intNroCorrelativoContrato
    '  End Get
    'End Property

    'Public ReadOnly Property NroAutorizacionContrato() As Int64
    '  Get
    '    Return intNroAutorizacionContrato
    '  End Get
    'End Property

    'Public ReadOnly Property TipoDeposito() As String
    '  Get
    '    Return strTipoDeposito
    '  End Get
    'End Property

    'Public ReadOnly Property Estado() As String
    '  Get
    '    Return strEstado
    '  End Get
    'End Property

#End Region

#Region " Procedimientos y Funciones "

#End Region

#Region " Métodos "

    Private Sub pPersiana(Optional ByVal strPersianaActual As String = "")
        If strPersianaActual <> "" Then strPersiana = strPersianaActual
        Select Case strPersiana
            Case "I" ' Ingreso de Mercadería
                hgParametrosCrearOS.Dock = DockStyle.Bottom
                hgParametrosCrearOS.Height = 20
                hgParametrosModificarOS.Visible = False
                dgListaOrdenesServicio.Visible = True
                dgListaOrdenesServicio.Dock = DockStyle.Fill
            Case "C" ' Crear O/S                
                dgListaOrdenesServicio.Visible = False
                hgParametrosModificarOS.Visible = False
                hgParametrosCrearOS.Visible = True
                hgParametrosCrearOS.Dock = DockStyle.Fill
            Case "M" ' Modificar O/S               
                hgParametrosCrearOS.Dock = DockStyle.Bottom
                hgParametrosCrearOS.Height = 20
                dgListaOrdenesServicio.Visible = False
                hgParametrosModificarOS.Visible = True
                hgParametrosModificarOS.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub pProcesarCargarInformación()
        Dim lint_Indice As Int32 = Me.dgListaOrdenesServicio.CurrentCellAddress.Y
        Me.lblOrdenServicio.Text = Me.dgListaOrdenesServicio.Item(0, lint_Indice).Value
        Me.txtCantidad_M.Text = Me.dgListaOrdenesServicio.Item(14, lint_Indice).Value
        Me.txtPeso_M.Text = Me.dgListaOrdenesServicio.Item(15, lint_Indice).Value
        Me.txtValor_M.Text = Me.dgListaOrdenesServicio.Item(16, lint_Indice).Value
        Me.txtUnidadCantidad_M.Text = Me.dgListaOrdenesServicio.Item(7, lint_Indice).Value
        Me.txtUnidadPeso_M.Text = Me.dgListaOrdenesServicio.Item(9, lint_Indice).Value
        Me.txtUnidadValor_M.Text = Me.dgListaOrdenesServicio.Item(11, lint_Indice).Value
        Me.cbxControlDespacho_M.SelectedIndex = IIf(Me.dgListaOrdenesServicio.Item(12, lint_Indice).Value = "C", 0, 1)
        Me.cbxControlLote_M.Checked = IIf(Me.dgListaOrdenesServicio.Item(13, lint_Indice).Value = "S", True, False)
    End Sub

    Private Sub pCerrarCrearOS()
        ' Ponemos la persiana lista para realizar la recepción
        Call pPersiana("I")
        ' Limpiamos los controles
        dgContratosVigentes.DataSource = Nothing
        txtCantidad.Clear()
        txtUnidadCantidad.Clear()
        txtPeso.Clear()
        txtUnidadPeso.Clear()
        txtValor.Clear()
        txtUnidadValor.Clear()
        cbxControlLote.Checked = False
        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub pCerrarModificarOS()
        ' Ponemos la persiana lista para realizar la recepción
        Call pPersiana("I")
        ' Limpiamos los controles      
        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Function pProcesarCrearOS() As Boolean
        Dim blnResultado As Boolean = True
        If Not fblnValidarInfNuevaOS() Then
            blnResultado = False
        Else
            Dim Mensaje As String = ""
            'add 12/04/2018 validacion contrato 
            'inicio
            Dim ListaP As New Hashtable
            Dim objGeneral As New clsGeneral_SDS("")
            ListaP("IN_CCLNT") = intCliente_CCLNT
            ListaP("IN_CMRCLR") = strMercaderia_CMRCLR
            ListaP("IN_NCNTR") = dgContratosVigentes.CurrentRow.Cells("M_NCNTR").Value
            ListaP("IN_CTPDP3") = dgContratosVigentes.CurrentRow.Cells("M_CTPDP3").Value

            Mensaje = objGeneral.ValidarRegOrdenServicio(ListaP)

            If Mensaje <> "" Then
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Function

            End If
            'fin 
            Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
            With objNuevaOrdenServicio
                .pintCodigoCliente_CCLNT = intCliente_CCLNT
                .pstrCodigoMercaderia_CMRCLR = strMercaderia_CMRCLR
                .pintNroContrato_NCNTR = dgContratosVigentes.CurrentRow.Cells("M_NCNTR").Value
                .pstrTipoDeposito_CTPDP3 = dgContratosVigentes.CurrentRow.Cells("M_CTPDP3").Value
                .pstrProducto_CTPPR1 = dgContratosVigentes.CurrentRow.Cells("M_CTPPR1").Value
                Decimal.TryParse(txtCantidad.Text, .pdecCantidadDeclarada_QMRCD)
                .pstrUnidadCantidad_CUNCND = txtUnidadCantidad.Text
                Decimal.TryParse(txtPeso.Text, .pdecPesoDeclarado_QPSMR)
                .pstrUnidadPeso_CUNPS0 = txtUnidadPeso.Text
                Decimal.TryParse(txtValor.Text, .pdecValorDeclarado_QVLMR)
                .pstrUnidadValor_CUNVLR = txtUnidadValor.Text
                .pstrControlLotes_FUNCTL = "N"
                If cbxControlLote.Checked = True Then .pstrControlLotes_FUNCTL = "S"
                .pstrUnidadDespacho_FUNDS = cbxUnidadDespacho.Text
            End With
            blnResultado = mfblnCrearOrdenServicio(objNuevaOrdenServicio)
            objNuevaOrdenServicio = Nothing
            If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
        End If
        Return blnResultado
    End Function

    Private Sub pProcesarActualizarOS()
        Dim blnResultado As Boolean = True
        Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
        With objNuevaOrdenServicio
            .pintOrdenServicio_NORDSR = dgListaOrdenesServicio.Item(0, dgListaOrdenesServicio.CurrentCellAddress.Y).Value
            .pintCodigoCliente_CCLNT = intCliente_CCLNT
            Decimal.TryParse(txtCantidad_M.Text, .pdecCantidadDeclarada_QMRCD)
            Decimal.TryParse(txtPeso_M.Text, .pdecPesoDeclarado_QPSMR)
            Decimal.TryParse(txtValor_M.Text, .pdecValorDeclarado_QVLMR)
        End With
        blnResultado = mfblnActualizarOrdenServicio(objNuevaOrdenServicio)
        objNuevaOrdenServicio = Nothing
        If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Modificar)

    End Sub

    Private Function fblnValidarInfNuevaOS() As Boolean
        Dim strResultado As String = ""
        Dim blnResultado As Boolean = True
        Dim decTemp As Decimal
        Decimal.TryParse(txtCantidad.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar una Cantidad mayor o igual a cero. " & vbNewLine
        If txtUnidadCantidad.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de las Cantidades. " & vbNewLine
        Decimal.TryParse(txtPeso.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Peso mayor o igual a cero. " & vbNewLine
        If txtUnidadPeso.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de los Pesos. " & vbNewLine
        Decimal.TryParse(txtValor.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Valor mayor o igual a cero. " & vbNewLine
        If txtUnidadValor.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información del Valor. " & vbNewLine
        If cbxControlLote.Text = "" Then strResultado &= "No ha seleccionado la Unidad de Despacho . " & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function

#End Region

#Region " Eventos "

    Private Sub frmOrdenServicioSDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(intCliente_CCLNT, strMercaderia_CMRCLR)
            cbxUnidadDespacho.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCrearOS.Click
        Try
            If intCliente_CCLNT = 0 Then Exit Sub
            ' Obtenemos los contratos vigentes del cliente
            Dim dtTemp As DataTable = mfdtListar_ContratosVigentes(intCliente_CCLNT, objSeguridadBN.pstrTipoAlmacen)
            ' Si no tuviese contratos vigentes, mostramos el mensaje de que no existe información
            If dtTemp.Rows.Count <= 0 Then
                Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
            Else
                ' Inicializamos las persinas
                Call pPersiana("C")
                dgContratosVigentes.DataSource = dtTemp
                bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaModificarOS.Click
        Try
            If intCliente_CCLNT = 0 OrElse Me.dgListaOrdenesServicio.RowCount = 0 Then Exit Sub
            ' Inicializamos las persinas
            Call pPersiana("M")
            bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Me.pProcesarCargarInformación()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnProcesarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCrearOS.Click
        Try
            If dgContratosVigentes.Rows.Count > 1 Then
                MessageBox.Show("No es posible crear O/S" & Chr(13) & "Solo debe haber un contrato vigente Depósito Simple", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If pProcesarCrearOS() Then
                Call pCerrarCrearOS()
                dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(intCliente_CCLNT, strMercaderia_CMRCLR)
                bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                NORDSR = dgListaOrdenesServicio.Rows(dgListaOrdenesServicio.RowCount - 1).Cells("O_NORDSR").Value.ToString.Trim
                Dim nordern As Integer = Integer.Parse(NORDSR)



                NCNTRR = dgListaOrdenesServicio.Rows(dgListaOrdenesServicio.RowCount - 1).Cells("O_NCNTR").Value.ToString.Trim
                CUNCN5 = dgListaOrdenesServicio.Rows(dgListaOrdenesServicio.RowCount - 1).Cells("O_CUNCN5").Value.ToString.Trim
                CUNPS5 = dgListaOrdenesServicio.Rows(dgListaOrdenesServicio.RowCount - 1).Cells("O_CUNPS5").Value.ToString.Trim
                CUNVL5 = dgListaOrdenesServicio.Rows(dgListaOrdenesServicio.RowCount - 1).Cells("O_CUNVL5").Value.ToString.Trim

                'If docu = 1 Then
                '    'Actualizar la mercadería
                '    objSqlManager = New SqlManager()

                '    If cItemGuiaRemision.fdt_update_itemgr2(objSqlManager, pcodigo, pnguirm, pnorcml, nordern, strMensajeError) Then

                '    End If
                'End If




                If intTipoInvoke = 1 Then Me.DialogResult = Windows.Forms.DialogResult.OK





            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnActualizarModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarModificarOS.Click
        Try
            Me.pProcesarActualizarOS()
            dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(intCliente_CCLNT, strMercaderia_CMRCLR)
            hgOS.Visible = True
            Call pPersiana("I")
            bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaListarUnidadCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadCantidad.Click
        Try
            Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
            txtUnidadCantidad.Tag = txtUnidadCantidad.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bsaListarUnidadPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadPeso.Click
        Try
            Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadCantidad.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
                txtUnidadCantidad.Tag = txtUnidadCantidad.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUnidadCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadCantidad.TextChanged
        txtUnidadCantidad.Tag = ""
    End Sub

    Private Sub txtUnidadCantidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadCantidad.Validating
        Try
            If txtUnidadCantidad.Text = "" Then
                txtUnidadCantidad.Tag = ""
            Else
                If txtUnidadCantidad.Text <> "" And "" & txtUnidadCantidad.Tag = "" Then
                    Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
                    txtUnidadCantidad.Tag = txtUnidadCantidad.Text
                    If txtUnidadCantidad.Text = "" Then
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

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadPeso.Validating
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

    Private Sub dgContratosVigentes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgContratosVigentes.CurrentCellChanged
        If dgContratosVigentes.CurrentRow Is Nothing Then Exit Sub
        txtUnidadCantidad.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNCN3").Value
        txtUnidadCantidad.Tag = "" & txtUnidadCantidad.Text
        txtUnidadPeso.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNPS3").Value
        txtUnidadPeso.Tag = "" & txtUnidadPeso.Text
        txtUnidadValor.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNVL3").Value
        txtUnidadValor.Tag = "" & txtUnidadPeso.Text
    End Sub

    Private Sub btnCancelarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCancelarModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarModificarOS.Click
        Try
            Call pCerrarModificarOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCrearOS.Click
        Try
            Call pCerrarCrearOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgListaOrdenesServicio_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgListaOrdenesServicio.CellDoubleClick
        If Me.dgListaOrdenesServicio.RowCount = 0 OrElse Me.dgListaOrdenesServicio.CurrentCellAddress.Y < 0 Then Exit Sub
        'intOrdenServicio = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value
        'intNroContrato = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NCNTR").Value
        'intNroCorrelativoContrato = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value
        'intNroAutorizacionContrato = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NAUTR").Value
        'strTipoDeposito = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
        'strEstado = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value

        objHashTable.Add("M_NORDSR", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
        objHashTable.Add("M_NCNTR", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NCNTR").Value)
        objHashTable.Add("M_NCRCTC", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value)
        objHashTable.Add("M_NAUTR", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NAUTR").Value)
        objHashTable.Add("M_CTPDPS", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value)
        objHashTable.Add("M_FUNDS2", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value)
        objHashTable.Add("M_CUNCN5", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CUNCN5").Value)
        objHashTable.Add("M_CUNPS5", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CUNPS5").Value)
        objHashTable.Add("M_CUNVL5", Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CUNVL5").Value)

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub bsaCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

    Private Sub frmOrdenServicioSDS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If intTipoInvoke = 1 Then Exit Sub
        If Not mfblnSalirOpcion() Then
            e.Cancel = True
        End If
    End Sub


End Class
