
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text

Public Class ucRefacturacionTransporte

#Region "Atributos"

    Private _pUsuario As String = ""
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pSystem_Prefix As String = ""
    Public Property pSystem_Prefix() As String
        Get
            Return _pSystem_Prefix
        End Get
        Set(ByVal value As String)
            _pSystem_Prefix = value
        End Set
    End Property

    Private _pNameFormulario As String = ""
    Public Property pNameFormulario() As String
        Get
            Return _pNameFormulario
        End Get
        Set(ByVal value As String)
            _pNameFormulario = value
        End Set
    End Property
    '
    Enum MANTENIMIENTO
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum

    Private gEnum_Mantenimiento As mantenimiento
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New Compania_BLL
    Private objPlanta As New Planta_BLL
    Private objDivision As New Division_BLL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    Private cOrgVenta As String = ""
    Private dOrgVenta As String = ""
    Dim TipoDocumento As String = ""
    Dim NumeroDocumento As String = ""
    Dim intContadorFacturas As Int32 = 0
    Dim intMonedaFactura As Integer
#End Region

#Region "Eventos"
    Sub pInicializar()

        Me.Cargar_Compania()
        Me.Cargar_Tipo_Documento()
        'Me.ckbRangoFechas.Checked = True
        Me.Alinear_Columnas_Grilla()

    End Sub

    Private Sub Cargar_Tipo_Documento()
        Dim objTipoDocumento_BLL As New mantenimientos.TipoDocumento_BLL
        Dim objEntidad As New mantenimientos.TipoDocumento
        objEntidad.CCMPN = Me.cboCompania.SelectedValue
        Me.cmbTipoDoc.DataSource = objTipoDocumento_BLL.Listar_Tipo_Documentos_Para_Refacturar(objEntidad)
        Me.cmbTipoDoc.DisplayMember = "TCMTPD"
        Me.cmbTipoDoc.ValueMember = "CTPODC"
    End Sub

    'Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    '    Me.Close()
    'End Sub

    Private Sub Listar_Operaciones_Facturadas()
        Dim parametros As New Hashtable
        Dim ReFacturaDAL As New Operaciones.ReFacturacion_BLL
        Dim rowData As DataRow
        Dim strCodPlanta As String = ""
        Dim dwvrow As DataGridViewRow
        Try
            Me.NumeroDocumento = ""
            Me.TipoDocumento = ""
            Me.intContadorFacturas = 0
            For i As Integer = 0 To Me.cmbPlanta.CheckedItems.Count - 1
                strCodPlanta += Me.cmbPlanta.CheckedItems(i).Value & ","
            Next
            If strCodPlanta.Trim.Length > 0 Then
                strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
            Else
                'HelpClassST.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
                MessageBox.Show("Seleccione algunas plantas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.chkNumeroDoc.Checked And Me.txtNroDocumento.Text = "" Then
                'HelpClassST.MsgBox("Ingrese el Numero de Factura", MessageBoxIcon.Information)
                MessageBox.Show("Ingrese el Numero de Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            parametros.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            parametros.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            parametros.Add("PNCPLNDV", strCodPlanta)
            parametros.Add("PNCCLNT", IIf(Me.txtClienteFiltro.pCodigo = 0, 0, Me.txtClienteFiltro.pCodigo))
            parametros.Add("PNCTPDCF", Me.cmbTipoDoc.SelectedValue)
            parametros.Add("PNNDCMFC", IIf(Me.txtNroDocumento.Text = "", 0, Me.txtNroDocumento.Text))
            parametros.Add("PNFECINI", IIf(Me.dtpFechaInicio.Enabled = False, 0, HelpClassST.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value)))
            parametros.Add("PNFECFIN", IIf(Me.dtpFechaFin.Enabled = False, 0, HelpClassST.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value)))
            'dtQuery = ReFacturaDAL.Listar_Operaciones_Liquidadas(parametros)
            'For indice As Integer = 0 To dtQuery.Rows.Count - 1
            '    dtQuery.Rows(indice).Item("FECFAC") = HelpClass.CFecha_de_8_a_10(dtQuery.Rows(indice).Item("FECFAC").ToString.Trim)
            'Next

            Me.dgwGuiaRemision.Rows.Clear()
            Me.gwdDatos.Rows.Clear()
            For Each rowData In ReFacturaDAL.Listar_Operaciones_Liquidadas(parametros).Rows
                dwvrow = New DataGridViewRow
                dwvrow.CreateCells(Me.gwdDatos)
                'dwvrow.Cells(0).Value = False
                'dwvrow.Cells(1).Value = rowData.Item("NOPRCN")
                'dwvrow.Cells(2).Value = rowData.Item("NORSRT")
                dwvrow.Cells(0).Value = rowData.Item("TCMTPD")
                dwvrow.Cells(1).Value = rowData.Item("NDCMFC")
                dwvrow.Cells(2).Value = HelpClassST.CFecha_de_8_a_10(rowData.Item("FECFAC").ToString.Trim)
                dwvrow.Cells(3).Value = rowData.Item("CMNDA")
                dwvrow.Cells(4).Value = rowData.Item("MONEDA")
                dwvrow.Cells(5).Value = rowData.Item("CCLNT")
                dwvrow.Cells(6).Value = rowData.Item("TCMPCL")
                dwvrow.Cells(7).Value = rowData.Item("CCLNFC")
                dwvrow.Cells(8).Value = rowData.Item("CPLNCL")
                dwvrow.Cells(9).Value = rowData.Item("TCMPCF")
                dwvrow.Cells(10).Value = rowData.Item("TPLNTA")
                dwvrow.Cells(11).Value = rowData.Item("CTPOSR")
                dwvrow.Cells(12).Value = rowData.Item("TCMTPS")
                dwvrow.Cells(13).Value = rowData.Item("TCMSBS")
                'dwvrow.Cells(14).Value = rowData.Item("CMRCDR")
                'dwvrow.Cells(15).Value = rowData.Item("TCMRCD")
                dwvrow.Cells(14).Value = rowData.Item("TCNTCS")
                dwvrow.Cells(15).Value = rowData.Item("TCRVTA")
                'dwvrow.Cells(18).Value = rowData.Item("SESTOP")
                dwvrow.Cells(16).Value = rowData.Item("TDRCNS")
                dwvrow.Cells(17).Value = rowData.Item("NRUCCN")
                'dwvrow.Cells(21).Value = rowData.Item("SORGMV")
                dwvrow.Cells(18).Value = rowData.Item("CRGVTA")
                'dwvrow.Cells(26).Value = rowData.Item("CPLNDV")

                Me.gwdDatos.Rows.Add(dwvrow)
            Next
        Catch : End Try
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            Me.dgwGuiaRemision.Rows.Clear()
            Me.Lista_GR_x_Operacion(e.RowIndex)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function Validar_Cliente(ByVal lint_Indice As Integer) As Integer
        Dim lint_Resultado As Integer = 0
        Me.gwdDatos.EndEdit()
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
                If Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value <> Me.gwdDatos.Item("CCLNFC_C", lint_Indice).Value OrElse _
                   Me.gwdDatos.Item("SORGMV_C", lint_Contador).Value <> Me.gwdDatos.Item("SORGMV_C", lint_Indice).Value Then
                    lint_Resultado = 2
                    Return lint_Resultado
                End If
            End If
        Next
        Return lint_Resultado
    End Function
    Private Sub Lista_GR_x_Operacion(ByVal Indice As Integer)
        Dim parametros As New Hashtable
        Dim rowData As DataRow
        Dim ReFacturaDAL As New Operaciones.ReFacturacion_BLL
        Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
        Dim lintEstado As Int32 = 0
        Dim lintGuiaRemi As Int64 = 0
        Dim lintOperacion As Int64 = 0
        Dim dwvrow As DataGridViewRow

        parametros.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        parametros.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        parametros.Add("PNCPLNDV", PlantaSeleccionada)
        parametros.Add("PNNDCMFC", Me.gwdDatos.Item("NDCMFC_C", Indice).Value)

        For Each rowData In ReFacturaDAL.Listar_Guias_X_Operaciones(parametros).Rows
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dgwGuiaRemision)
            If rowData.Item("NOPRCN") = lintOperacion Then
                dwvrow.Cells(0).Value = ""
                dwvrow.Cells(13).Value = ""
            Else
                dwvrow.Cells(0).Value = rowData.Item("NOPRCN")
                lintOperacion = rowData.Item("NOPRCN")
                dwvrow.Cells(13).Value = "Ver Historial"
            End If
            If (rowData.Item("NGUITR") = lintGuiaRemi) Then
                dwvrow.Cells(1).Value = ""
            Else
                dwvrow.Cells(1).Value = rowData.Item("NGUITR")
                lintGuiaRemi = rowData.Item("NGUITR")
            End If
            dwvrow.Cells(2).Value = rowData.Item("NDCMFC")
            dwvrow.Cells(3).Value = HelpClassST.CFecha_de_8_a_10(rowData.Item("FECFAC").ToString)
            dwvrow.Cells(4).Value = rowData.Item("CSRVC")
            dwvrow.Cells(5).Value = rowData.Item("QCNDTG")
            dwvrow.Cells(6).Value = rowData.Item("CUNDSR")
            dwvrow.Cells(7).Value = rowData.Item("ISRVGU")
            dwvrow.Cells(8).Value = rowData.Item("CMNDA")
            dwvrow.Cells(9).Value = rowData.Item("CMNDGU")
            dwvrow.Cells(10).Value = rowData.Item("IMPORTE")
            dwvrow.Cells(11).Value = rowData.Item("NOPRCN")
            dwvrow.Cells(12).Value = rowData.Item("NGUITR")

            Me.dgwGuiaRemision.Rows.Add(dwvrow)
            lintEstado = 1
        Next
    End Sub
    Private Sub Eliminar_Guias_X_Operacion(ByVal lintOperacion As Int64)
        If Me.dgwGuiaRemision.RowCount = 0 Then Exit Sub
        Dim lint_contador As Int32 = 0
        While lint_contador <= Me.dgwGuiaRemision.RowCount - 1
            If Me.dgwGuiaRemision.Item("NOPRCN1", lint_contador).Value.ToString = lintOperacion.ToString Then
                Me.dgwGuiaRemision.Rows.RemoveAt(lint_contador)
                lint_contador -= 1
            End If
            lint_contador += 1
        End While
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Me.Listar_Operaciones_Facturadas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function BuscarIndice(ByVal intOperacion As Double) As Int32
        Dim row As Integer
        For row = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item("NOPRCN_C", row).Value = intOperacion Then
                Exit For
            End If
        Next
        Return row
    End Function

    Private Function ObtenerPlantaSeleccionada() As Decimal
        Dim Planta As Decimal = -1
        For i As Integer = 0 To Me.cmbPlanta.CheckedItems.Count - 1
            Planta = Me.cmbPlanta.CheckedItems(i).Value
            Exit For
        Next
        Return Planta
    End Function
    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
        Try
            If bolBuscar Then
                Cargar_Division()
                ' InicializarFormulario()
            End If
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub InicializarFormulario()
        Me.gwdDatos.Rows.Clear()
        Me.dgwGuiaRemision.Rows.Clear()
        Me.txtNroDocumento.Text = ""
        'Me.ckbRangoFechas.Checked = False
        Me.txtClienteFiltro.pClear()
        Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
        Try
            If bolBuscar Then
                'Me.Cargar_Planta()
                Me.cargarComboPlanta()
                InicializarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar = True Then
            InicializarFormulario()
        End If
    End Sub


#End Region

#Region "Métodos"

    Private Sub Cargar_Compania()
        Try
            objCompaniaBLL.Crea_Lista()
            bolBuscar = False
            Me.cboCompania.DataSource = objCompaniaBLL.Lista
            Me.cboCompania.ValueMember = "CCMPN"
            Me.cboCompania.DisplayMember = "TCMPCM"
            bolBuscar = True
            'cboCompania.SelectedIndex = 0
            'Me.cboCompania.SelectedValue = "EZ"
            'If cboCompania.SelectedIndex = -1 Then
            '    cboCompania.SelectedIndex = 0
            'End If
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cboCompania_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            'HelpClassST.MsgBox(ex.Message)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Division()
        Try
            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objDivision.Crea_Lista()
                Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
                Me.cboDivision.ValueMember = "CDVSN"
                bolBuscar = True
                Me.cboDivision.DisplayMember = "TCMPDV"
                Me.cboDivision.SelectedValue = "T"
                If Me.cboDivision.SelectedIndex = -1 Then
                    Me.cboDivision.SelectedIndex = 0
                End If
                cboDivision_SelectedIndexChanged(Nothing, Nothing)
            End If

        Catch ex As Exception
            'HelpClassST.MsgBox(ex.Message)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Cargar_Planta()
    '  Try
    '    If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
    '      bolBuscar = False
    '      objPlanta.Crea_Lista()
    '      Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
    '      Me.cboPlanta.ValueMember = "CPLNDV"
    '      bolBuscar = True
    '      Me.cboPlanta.DisplayMember = "TPLNTA"
    '      Me.cboPlanta.SelectedIndex = 0
    '      cboPlanta_SelectedIndexChanged(Nothing, Nothing)
    '    End If
    '  Catch ex As Exception
    '    HelpClass.MsgBox(ex.Message)
    '  End Try
    'End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        Me.dgwGuiaRemision.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_Contador As Integer = 0 To Me.dgwGuiaRemision.ColumnCount - 1
            Me.dgwGuiaRemision.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of mantenimientos.ClaseGeneral)
        Dim objLogica As New Planta_BLL
        Try
            Me.cmbPlanta.Text = ""
            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objLogica.Crea_Lista()
                objLisEntidad2 = objLogica.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
                Dim objEntidad As New mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                cmbPlanta.DisplayMember = "TPLNTA"
                cmbPlanta.ValueMember = "CPLNDV"
                Me.cmbPlanta.DataSource = objLisEntidad
                For i As Integer = 0 To cmbPlanta.Items.Count - 1
                    If cmbPlanta.Items.Item(i).Value = "1" Then
                        Me.cmbPlanta.SetItemChecked(i, True)
                    End If
                Next
                If Me.cmbPlanta.Text = "" Then
                    Me.cmbPlanta.SetItemChecked(0, True)
                End If
                'If objLisEntidad.Count > 0 Then
                '  _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
                'Else
                '  _lstrTipoCuenta = ""
                'End If
                bolBuscar = True
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub btnNotaDebito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaDebito.Click
        Try
            Dim objParametro As New Hashtable
            Dim obj_Logica As New Operaciones.Factura_Transporte_BLL
            Dim objLogica As New Operaciones.ReFacturacion_BLL
            Dim objetoParametro As New Hashtable
            Dim lint_Numerador As Int64 = 0
            Dim dblTipoCambio As Double
            If Me.gwdDatos.Rows.Count = 0 Then Exit Sub

            If Me.Consistencia_Cliente = 0 Then Exit Sub
            If mConsistenciaPlanta Then
                'HelpClassST.MsgBox("Planta no existe", MessageBoxIcon.Information)
                MessageBox.Show("Planta no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Consistencia_Organizacion_Venta() = False Then
                'HelpClassST.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
                MessageBox.Show("La Organización de Venta de las Operaciones seleccionadas no son iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
            objetoParametro.Add("PNCCLNT", Me.Consistencia_Cliente)
            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            objetoParametro.Add("PNCPLNDV", PlantaSeleccionada)
            'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
            objetoParametro.Add("PON_NRODOCU", 0)
            lint_Numerador = obj_Logica.Verificar_Cliente_Especial(objetoParametro)
            If lint_Numerador = 0 Then
                'HelpClassST.ErrorMsgBox()
                MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            Else 'If lint_Numerador = -1 Then
                Dim frm_OpcionFactura As New frmOpcionFactura
                With frm_OpcionFactura
                    .Compania = Me.cboCompania.SelectedValue
                    .Division = Me.cboDivision.SelectedValue
                    .Estado = 1
                    .rbtnFactura.Checked = True
                    .pUsuario = _pUsuario
                    '  For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                    'If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                    Dim lint_Contador As Integer = Me.gwdDatos.CurrentCellAddress.Y
                    .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
                    .txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
                    .txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
                    .txtOperacion.Text = ListUnique(ListOperaciones())
                    .txtPreFactura.Text = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                    .txtOrganizacionVenta.Text = dOrgVenta
                    .rbtnDolares.Checked = IIf(Me.gwdDatos.Item("CMNDA", lint_Contador).Value = 100, True, False)

                    'Exit For
                    ' End If
                    ' Next

                    .txtPreFactura.Tag = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                    'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    'If .rbtnPreFactura.Checked Then
                    '  objetoParametro.Add("PNNOPRCN", lstr_Consistencia.Trim)
                    '  objetoParametro.Add("PSCULUSA", MainModule.USUARIO)
                    '  objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
                    '  objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
                    '  objetoParametro.Add("PSNTRMNL", HelpClass.NombreMaquina)
                    '  obj_Logica.Pre_Facturar_Operacion(objetoParametro)
                    '  Me.Listar_Operaciones_Facturadas()
                    'Else

                    Dim frm_ListaOpeCredito As New frmConsultaOperacionesNotaCredito
                    frm_ListaOpeCredito.ListaOperacion = Consistencia_Operacion_Facturas()
                    ' frm_ListaOpeCredito.DtSource = GetOperaciones()
                    frm_ListaOpeCredito.Compania = Me.cboCompania.SelectedValue
                    frm_ListaOpeCredito.Division = Me.cboDivision.SelectedValue
                    frm_ListaOpeCredito.PlantaSeleccionada = ObtenerPlantaSeleccionada()
                    frm_ListaOpeCredito.TipoCambio = dblTipoCambio
                    frm_ListaOpeCredito.TipoDocumentoReFactura = 2
                    frm_ListaOpeCredito.pUsuario = _pUsuario

                    If frm_ListaOpeCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
                        'lstr_Consistencia = frm_ListaOpeCredito.ListaOperacion
                        Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                        Dim FechaAtencion As Int64 = 0
                        If .dtpFechaServicio.Enabled = True Then
                            FechaAtencion = (CType(HelpClassST.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                        End If
                        Dim strZonaFacturacion As Int32 = 0
                        If .cboZonaFacturacion.NoHayCodigo = False Then
                            strZonaFacturacion = .cboZonaFacturacion.Codigo
                        End If
                        Dim frm_VistaReFactura As frmVistaReFactura
                        frm_VistaReFactura = New frmVistaReFactura(frm_ListaOpeCredito.ListaOperacion, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), PlantaSeleccionada, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
                        With frm_VistaReFactura
                            .Tag = 1 'frm_OpcionFactura.Tag
                            .pTipoOperacion = 2
                            .pTipoDocumento = 2
                            .pTipoDocumentoReferencia = cmbTipoDoc.SelectedValue
                            .TipoNC = frm_ListaOpeCredito.TipoNotaCredito
                            .pUsuario = _pUsuario
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.Listar_Operaciones_Facturadas()
                        End With
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Insertar_Operaciones_X_Importes_Facturados()
        Dim RefacturaBLL As New Operaciones.ReFacturacion_BLL
        Dim param As New Hashtable
        Try
            param.Add("PNNOPRCN", ListUnique(ListOperaciones))
            param.Add("PNNDCMFC", ListUnique(ListFacturas))
            param.Add("PNCTPDFC", 1)
            param.Add("PSCCPMN", Me.cboCompania.SelectedValue)
            RefacturaBLL.Insertar_Importes_X_Operaciones_Facturadas(param)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaCredito.Click
        Try
            Dim objParametro As New Hashtable
            Dim obj_Logica As New Operaciones.Factura_Transporte_BLL
            Dim objLogica As New Operaciones.ReFacturacion_BLL
            Dim objetoParametro As New Hashtable
            Dim lint_Numerador As Int64 = 0
            'Dim ConsistenciaFacturas As Integer = Consistencia_Facturas()
            Dim dtImporteFact As DataTable
            Dim dblSaldoRefactura As Double = 0
            Dim dblImporteRefactura As Double = 0
            Dim dblTipoCambioFactura As Double
            If Me.gwdDatos.Rows.Count = 0 Then Exit Sub

            'Dim lstr_Consistencia_facturas As String = Me.Consistencia_Facturas
            'If ConsistenciaFacturas > 1 Then
            '    HelpClass.MsgBox("No se puede Emitir una Nota de Credito a " & ConsistenciaFacturas & " Facturas", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If Me.Consistencia_Cliente = 0 Then Exit Sub
            'If mConsistenciaPlanta Then
            '    HelpClass.MsgBox("Planta no existe", MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If Consistencia_Organizacion_Venta() = False Then
                'HelpClassST.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
                MessageBox.Show("La Organización de Venta de las Operaciones seleccionadas no son iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ' Consistencia = lstr_Consistencia.Split("-")
            'Validar si se puede seguir Aplicando Notas de Credito

            objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            objParametro.Add("PNNDCMFC", Me.gwdDatos.CurrentRow.Cells("NDCMFC_C").Value)
            'objParametro.Add("PNNDCMFC", Me.ListUnique(ListFacturas))
            'objParametro.Add("PNCTPODC_FC", Me.cmbTipoDoc.SelectedValue)
            ' objParametro.Add("PNCTPODC_RF", 3)
            'objParametro.Add("PNITCALC", 0)

            dtImporteFact = objLogica.Traer_Importe_Refactura(objParametro)
            If dtImporteFact.Rows.Count > 0 Then
                For indice As Integer = 0 To dtImporteFact.Rows.Count - 1
                    dblSaldoRefactura += dtImporteFact.Rows(indice).Item("IMPORTE")
                Next
                dblTipoCambioFactura = dtImporteFact.Rows(0).Item("ITCCTC")
                intMonedaFactura = dtImporteFact.Rows(0).Item("CMNDA")
            Else
                'HelpClassST.MsgBox("No se encontro el documento", MessageBoxIcon.Exclamation)
                MessageBox.Show("No se encontro el documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'For index As Integer = 0 To Me.dgwGuiaRemision.RowCount - 1
            '    'Comparamos las monedas
            '    If intMonedaFactura = 1 Then ' FACTURA EN SOLES
            '        If Me.dgwGuiaRemision.Item("CMNDA_D", index).Value.ToString.Trim = 1 Then
            '            dblImporteRefactura += Me.dgwGuiaRemision.Item("IMPORTE", index).Value

            '        Else
            '            dblImporteRefactura += Me.dgwGuiaRemision.Item("IMPORTE", index).Value * dblTipoCambioFactura
            '        End If
            '    Else
            '        If Me.dgwGuiaRemision.Item("CMNDA_D", index).Value.ToString.Trim = 1 Then
            '            dblImporteRefactura += Me.dgwGuiaRemision.Item("IMPORTE", index).Value / dblTipoCambioFactura

            '        Else
            '            dblImporteRefactura += Me.dgwGuiaRemision.Item("IMPORTE", index).Value
            '        End If

            '    End If

            'Next

            ' dblImporteRefactura = Me.dgwGuiaRemision.Item("ISRVGU_D", dgwGuiaRemision.CurrentCellAddress.Y).Value

            'VER MAS ADELANTE
            'If dblImporteRefactura > dblSaldoRefactura Then
            '    HelpClass.MsgBox("No se Puede Aplicar Nota de Credito, Importe Minimo " & dblSaldoRefactura & " " & Me.gwdDatos.Item("MONEDA", gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim, MessageBoxIcon.Exclamation)
            '    '    Exit Sub
            'End If

            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
            objetoParametro.Add("PNCCLNT", Me.Consistencia_Cliente)
            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            objetoParametro.Add("PNCPLNDV", PlantaSeleccionada)

            'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
            objetoParametro.Add("PON_NRODOCU", 0)
            lint_Numerador = obj_Logica.Verificar_Cliente_Especial(objetoParametro)
            If lint_Numerador = 0 Then
                'HelpClassST.ErrorMsgBox()
                MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else 'If lint_Numerador = -1 Then
                Dim frm_OpcionFactura As New frmOpcionFactura
                With frm_OpcionFactura
                    .Compania = Me.cboCompania.SelectedValue
                    .Division = Me.cboDivision.SelectedValue
                    .Estado = 1
                    .rbtnFactura.Checked = True
                    .pUsuario = _pUsuario
                    'For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                    'If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                    Dim lint_Contador As Integer = Me.gwdDatos.CurrentCellAddress.Y
                    .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
                    .txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
                    .txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
                    .txtOperacion.Text = ListUnique(ListOperaciones())
                    .txtPreFactura.Text = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                    .txtOrganizacionVenta.Text = dOrgVenta.Trim
                    .rbtnDolares.Checked = IIf(Me.gwdDatos.Item("CMNDA", lint_Contador).Value = 100, True, False)

                    'Exit For
                    ' End If
                    '  Next

                    .txtPreFactura.Tag = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                    'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    'If .rbtnPreFactura.Checked Then
                    '  objetoParametro.Add("PNNOPRCN", lstr_Consistencia.Trim)
                    '  objetoParametro.Add("PSCULUSA", MainModule.USUARIO)
                    '  objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
                    '  objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
                    '  objetoParametro.Add("PSNTRMNL", HelpClass.NombreMaquina)
                    '  obj_Logica.Pre_Facturar_Operacion(objetoParametro)
                    '  Me.Listar_Operaciones_Facturadas()
                    'Else

                    Dim frm_ListaOpeCredito As New frmConsultaOperacionesNotaCredito
                    frm_ListaOpeCredito.ListaOperacion = Consistencia_Operacion_Facturas()
                    'frm_ListaOpeCredito.DtSource = GetOperaciones()
                    frm_ListaOpeCredito.Compania = Me.cboCompania.SelectedValue
                    frm_ListaOpeCredito.Division = Me.cboDivision.SelectedValue
                    frm_ListaOpeCredito.PlantaSeleccionada = ObtenerPlantaSeleccionada()
                    frm_ListaOpeCredito.TipoCambio = dblTipoCambioFactura
                    frm_ListaOpeCredito.TipoDocumentoReFactura = 3
                    frm_ListaOpeCredito.ImporteSaldoFactura = dblSaldoRefactura
                    frm_ListaOpeCredito.MonedaFactura = intMonedaFactura
                    frm_ListaOpeCredito.pUsuario = _pUsuario

                    If frm_ListaOpeCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
                        'lstr_Consistencia = frm_ListaOpeCredito.ListaOperacion
                        Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                        Dim FechaAtencion As Int64 = 0
                        If .dtpFechaServicio.Enabled = True Then
                            FechaAtencion = (CType(HelpClassST.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                        End If
                        Dim strZonaFacturacion As Int32 = 0
                        If .cboZonaFacturacion.NoHayCodigo = False Then
                            strZonaFacturacion = .cboZonaFacturacion.Codigo
                        End If
                        Dim frm_VistaReFactura As frmVistaReFactura
                        frm_VistaReFactura = New frmVistaReFactura(frm_ListaOpeCredito.ListaOperacion, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), PlantaSeleccionada, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
                        With frm_VistaReFactura
                            .Tag = 1 'frm_OpcionFactura.Tag
                            .pTipoOperacion = 2
                            .pTipoDocumento = 3
                            .pTipoDocumentoReferencia = cmbTipoDoc.SelectedValue
                            .TipoNC = frm_ListaOpeCredito.TipoNotaCredito
                            .pUsuario = _pUsuario
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.Listar_Operaciones_Facturadas()
                        End With
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Moneda_Facturas() As String
        Dim moneda As String = ""
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                moneda = Me.gwdDatos.Item("MONEDA", lint_Contador).Value.ToString.Trim
                Exit For
            End If
        Next
        Return moneda
    End Function
    Private Function Codigo_Moneda_Facturas() As Double
        Dim moneda As Double
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                moneda = Me.gwdDatos.Item("CMNDA", lint_Contador).Value
                Exit For
            End If
        Next
        Return moneda
    End Function
    'Private Function Consistencia_Facturas() As Integer
    '  Dim contador As Integer = 0
    '  Dim NumeroFactura As String = ""
    '  If Me.dgwGuiaRemision.RowCount = 0 OrElse Me.dgwGuiaRemision.CurrentCellAddress.Y < 0 Then Exit Function

    '  For indiceRow As Integer = 0 To Me.dgwGuiaRemision.Rows.Count - 1
    '    If NumeroFactura <> Me.dgwGuiaRemision.Item("NDCMFC_D", indiceRow).Value.ToString Then
    '      NumeroFactura = Me.dgwGuiaRemision.Item("NDCMFC_D", indiceRow).Value.ToString
    '      contador = contador + 1
    '    End If
    '  Next
    '  Return contador
    'End Function
    Private Function Consistencia_Operacion() As String
        Dim lstr_Cadena As String = ""
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Return lstr_Cadena
            Exit Function
        End If
        mConsistenciaPlanta = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item(0, lint_Contador).Value Then
                lstr_Cadena = lstr_Cadena + Me.gwdDatos.Item("NOPRCN_C", lint_Contador).Value.ToString.Trim + ","
                If Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value.ToString.Trim.Equals("") Then mConsistenciaPlanta = True
            End If
        Next
        If lstr_Cadena.Length <> 0 Then
            lstr_Cadena = lstr_Cadena.Substring(0, lstr_Cadena.Length - 1)
        End If
        Return lstr_Cadena
    End Function
    Private Function Consistencia_Operacion_Facturas() As List(Of ConsistenciaOperacion)
        Dim lstr_Operaciones As String = ""
        Dim lstr_Facturas As String = ""
        Dim lstr_Fechas As String = ""
        Dim objConsistenciaOperacion As ConsistenciaOperacion
        Dim lstConsistenciaOperacion As New List(Of ConsistenciaOperacion)
        If Me.dgwGuiaRemision.RowCount = 0 OrElse Me.dgwGuiaRemision.CurrentCellAddress.Y < 0 Then
            Return Nothing
            Exit Function
        End If
        'mConsistenciaPlanta = False
        For lint_Contador As Integer = 0 To Me.dgwGuiaRemision.RowCount - 1
            objConsistenciaOperacion = New ConsistenciaOperacion
            objConsistenciaOperacion.Operacion = Me.dgwGuiaRemision.Item("NOPRCN1", lint_Contador).Value.ToString.Trim
            objConsistenciaOperacion.Factura = Me.dgwGuiaRemision.Item("NDCMFC_D", lint_Contador).Value.ToString.Trim
            objConsistenciaOperacion.Fecha = HelpClassST.CFecha_10_10(Me.dgwGuiaRemision.Item("FECFAC_D", lint_Contador).Value.ToString.Trim)
            objConsistenciaOperacion.MonedaImporte = Me.dgwGuiaRemision.Item("CMNDGU_D", lint_Contador).Value.ToString.Trim
            objConsistenciaOperacion.MonedaFactura = intMonedaFactura
            lstConsistenciaOperacion.Add(objConsistenciaOperacion)
        Next
        Return lstConsistenciaOperacion
    End Function
    'Private Function Consistencia_Facturas() As String
    '    Dim lstr_Cadena As String = ""
    '    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '        Return lstr_Cadena
    '        Exit Function
    '    End If
    '    mConsistenciaPlanta = False
    '    For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
    '        If Me.gwdDatos.Item(0, lint_Contador).Value Then
    '            lstr_Cadena = lstr_Cadena + Me.gwdDatos.Item("NOPRCN_C", lint_Contador).Value.ToString.Trim + ","
    '            If Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value.ToString.Trim.Equals("") Then mConsistenciaPlanta = True
    '        End If
    '    Next
    '    If lstr_Cadena.Length <> 0 Then
    '        lstr_Cadena = lstr_Cadena.Substring(0, lstr_Cadena.Length - 1)
    '    End If
    '    Return lstr_Cadena
    'End Function
    Private Function Consistencia_Cliente() As Int64
        Dim lstr_CCLNT As Int64 = 0
        Dim lint_Contador As Integer = Me.gwdDatos.CurrentCellAddress.Y
        'For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
        'If Me.gwdDatos.Item(0, lint_Contador).Value Then
        lstr_CCLNT = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value
        mCPLNDV = Me.gwdDatos.Item("CPLNCL_C", lint_Contador).Value
        'Exit For
        'End If
        ' Next
        Return lstr_CCLNT
    End Function
    Private Function Consistencia_Organizacion_Venta() As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Dim lint_Contador As Integer = Me.gwdDatos.CurrentCellAddress.Y
        ' Me.gwdDatos.EndEdit()
        'For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
        'If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
        If intIndice = 0 Then
            cOrgVenta = Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value
            dOrgVenta = Me.gwdDatos.Item("TCRVTA_C", lint_Contador).Value
            lstr_Estado = True
            intIndice += 1
        Else
            If Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value <> cOrgVenta Then
                lstr_Estado = False
            End If
        End If
        ' End If
        'Next
        Return lstr_Estado
    End Function

    Private Sub btnReFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReFacturar.Click
        Try

            Dim obj_Logica As New Operaciones.Factura_Transporte_BLL
            Dim objetoParametro As New Hashtable
            Dim lint_Numerador As Int64 = 0
            Dim lstr_Consistencia As String = Me.Consistencia_Operacion
            If Me.Consistencia_Cliente = 0 Then Exit Sub
            If mConsistenciaPlanta Then
                'HelpClassST.MsgBox("Planta no existe", MessageBoxIcon.Information)
                MessageBox.Show("Planta no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Consistencia_Organizacion_Venta() = False Then
                'HelpClassST.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
                MessageBox.Show("La Organización de Venta de las Operaciones seleccionadas no son iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
            objetoParametro.Add("PNCCLNT", Me.Consistencia_Cliente)
            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            objetoParametro.Add("PNCPLNDV", PlantaSeleccionada)
            'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
            objetoParametro.Add("PON_NRODOCU", 0)
            lint_Numerador = obj_Logica.Verificar_Cliente_Especial(objetoParametro)
            If lint_Numerador = 0 Then
                'HelpClassST.ErrorMsgBox()
                MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else 'If lint_Numerador = -1 Then
                Dim frm_OpcionFactura As New frmOpcionFactura
                With frm_OpcionFactura
                    .Compania = Me.cboCompania.SelectedValue
                    .Division = Me.cboDivision.SelectedValue
                    .Estado = 1
                    .pUsuario = _pUsuario
                    For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                        If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                            .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
                            .txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
                            .txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
                            .txtOperacion.Text = lstr_Consistencia.Trim
                            .txtPreFactura.Text = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                            .txtOrganizacionVenta.Text = dOrgVenta
                            .CodigoMoneda = Me.gwdDatos.Item("CMNDA", lint_Contador).Value
                            Exit For
                        End If
                    Next
                    .txtPreFactura.Tag = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    If .rbtnPreFactura.Checked Then
                        objetoParametro.Add("PNNOPRCN", lstr_Consistencia.Trim)
                        objetoParametro.Add("PSCULUSA", _pUsuario) 'MainModule.USUARIO)
                        objetoParametro.Add("PNFULTAC", HelpClassST.TodayNumeric)
                        objetoParametro.Add("PNHULTAC", HelpClassST.NowNumeric)
                        objetoParametro.Add("PSNTRMNL", HelpClassST.NombreMaquina)
                        obj_Logica.Pre_Facturar_Operacion(objetoParametro)
                        Me.Listar_Operaciones_Facturadas()
                    Else
                        Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                        Dim FechaAtencion As Int64 = 0
                        If .dtpFechaServicio.Enabled = True Then
                            FechaAtencion = (CType(HelpClassST.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                        End If
                        Dim strZonaFacturacion As Int32 = 0
                        If .cboZonaFacturacion.NoHayCodigo = False Then
                            strZonaFacturacion = .cboZonaFacturacion.Codigo
                        End If
                        Dim frm_VistaFactura As frmVistaFactura
                        frm_VistaFactura = New frmVistaFactura(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), PlantaSeleccionada, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
                        'frm_VistaFactura = New frmVistaFactura(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), Me.cboPlanta.SelectedValue, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
                        With frm_VistaFactura
                            .Tag = frm_OpcionFactura.Tag
                            .pTipoOperacion = 1
                            .FlagFactura = 1
                            .pUsuario = _pUsuario
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.Listar_Operaciones_Facturadas()

                        End With
                    End If

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNumeroDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumeroDoc.CheckedChanged
        If chkNumeroDoc.Checked Then
            txtNroDocumento.Enabled = True
            txtNroDocumento.Text = ""
            Me.txtClienteFiltro.Enabled = False
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        Else
            txtNroDocumento.Enabled = False
            txtNroDocumento.Text = ""
            Me.txtClienteFiltro.Enabled = True
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim NumeroFactura As String = Me.dgwGuiaRemision.Item("NDCMFC_D", Me.dgwGuiaRemision.CurrentCellAddress.Y).Value.ToString
        Dim operacion As Int32 = 0
        Dim guia As Int64 = 0
        If Me.dgwGuiaRemision.RowCount = 0 Then Exit Sub
        'If Me.dgwGuiaRemision.Item("NOPRCN_D", Me.dgwGuiaRemision.CurrentCellAddress.Y).Value.ToString <> "" Then Exit Sub

        Dim lint_contador As Int32 = 0
        While lint_contador <= Me.dgwGuiaRemision.RowCount - 1
            If Me.dgwGuiaRemision.Item("NDCMFC_D", lint_contador).Value.ToString = NumeroFactura Then
                Me.dgwGuiaRemision.Rows.RemoveAt(lint_contador)
                lint_contador -= 1
            End If
            lint_contador += 1
        End While
        If Me.dgwGuiaRemision.Rows.Count = 0 Then Exit Sub
        For index As Integer = 0 To Me.dgwGuiaRemision.Rows.Count - 1

            If Me.dgwGuiaRemision.Item("NOPRCN1", index).Value = operacion Then
                Me.dgwGuiaRemision.Item("NOPRCN_D", index).Value = ""
            Else
                Me.dgwGuiaRemision.Item("NOPRCN_D", index).Value = Me.dgwGuiaRemision.Item("NOPRCN1", index).Value
                operacion = Me.dgwGuiaRemision.Item("NOPRCN1", index).Value
            End If
            If Me.dgwGuiaRemision.Item("NGUITR1", index).Value = guia Then
                Me.dgwGuiaRemision.Item("NGUITR_D", index).Value = ""
            Else
                Me.dgwGuiaRemision.Item("NGUITR_D", index).Value = Me.dgwGuiaRemision.Item("NGUITR1", index).Value
                guia = Me.dgwGuiaRemision.Item("NGUITR1", index).Value
            End If
        Next
    End Sub

    Private Sub txtNroDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Function ListUnique(ByVal listaFactuas As String) As String
        Dim lista() As String = listaFactuas.Split(",")
        Dim oHas As New Hashtable
        Dim Factura As String = ""
        Dim sbLista As New StringBuilder
        Dim Texto As String = ""
        For intX As Integer = 0 To lista.Length - 1
            Factura = ("" & lista(intX)).Trim
            If Factura.Length > 0 Then
                If Not oHas.Contains(Factura) Then
                    oHas(Factura) = Factura
                    sbLista.Append(Factura & ",")
                End If
            End If
        Next
        Texto = sbLista.ToString
        Texto = Texto.Substring(0, Texto.LastIndexOf(","))
        Return Texto
    End Function
    Private Function ListOperaciones() As String
        Dim result As String = ""
        Dim list As String = ""
        Dim lista As List(Of ConsistenciaOperacion) = Consistencia_Operacion_Facturas()
        For a As Integer = 0 To lista.Count - 1
            result += lista(a).Operacion & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        Dim lista As List(Of ConsistenciaOperacion) = Consistencia_Operacion_Facturas()
        For a As Integer = 0 To lista.Count - 1
            result += lista(a).Factura & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        Try
            Dim indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            If indice < 0 Then Exit Sub
            Me.dgwGuiaRemision.Rows.Clear()
            Me.Lista_GR_x_Operacion(indice)
        Catch : End Try
    End Sub

    Private Sub dgwGuiaRemision_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGuiaRemision.CellContentClick
        Try
            If Me.gwdDatos.RowCount < 0 OrElse e.RowIndex < 0 Then Exit Sub
            Select Case e.ColumnIndex
                Case 13
                    Dim frmHistorialOperaciones As FormHistorialOperaciones = New FormHistorialOperaciones
                    frmHistorialOperaciones.Compania = Me.cboCompania.SelectedValue
                    frmHistorialOperaciones.Division = Me.cboDivision.SelectedValue
                    frmHistorialOperaciones.Operacion = dgwGuiaRemision.CurrentRow.Cells("NOPRCN1").Value
                    frmHistorialOperaciones.ShowDialog()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick

    End Sub
End Class

