Imports RANSA.Utilitario
Imports RANSA.TypeDef
Imports RANSA.NEGO


Public Class frmMantenimientoLote


#Region "Variables"

    Dim objbrLote As New brLote
    Dim OrdenServicio As Decimal = 0
    Public _objBeLote As New beLote
    Public NUEVO As Boolean
    Public NCRRIN As Decimal = 0
    Public CCLNT As Decimal = 0
    Public FlagRecepcion As Integer = 0
    Public NORDSR As String = ""

#End Region

#Region "Delegados"


    Private Sub frmMantLote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarMoneda()

        If NUEVO = False Then
            Me.Text = "Modificar Lote"
            CargarDatosLote(_objBeLote)
        End If

        If FlagRecepcion = 1 Then
            txtAyuda.Text = NORDSR
        End If


    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        Dim objLote As New beLote
        Dim msj As String = ""
        If String.IsNullOrEmpty(txtAyuda.Text.Trim) Then
            msj = msj & "Ingrese Orden de Servicio" & Environment.NewLine
            'Else
            '    If String.IsNullOrEmpty(txtCriterioLote.Text.Trim) Then
            '        msj = msj & "Ingrese Criterio de Lote" & Environment.NewLine
            '    End If
        End If
        If msj.Length > 0 Then
            MessageBox.Show(msj, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        With objLote
            .NUEVO = NUEVO
            .NORDSR = Val(txtAyuda.Text)
            .NCRRIN = NCRRIN ' Nueo
            .CCLNT = CCLNT
            .CPRVCL = Val(txtProveedor.pCodigo)
            .NDCMPV = txtDocProveedor.Text.Trim  'Documento del Proveedor
            If UcAyuda2.Resultado IsNot Nothing Then
                .CMNCT = CType(UcAyuda2.Resultado, Ransa.TypeDef.beGeneral).PNCMNDA1 'Moneda del Proveed  oer
            End If
            .IMPTTL = Val(txtImportProveedor.Text)  'importe del proveedor
            If UcAyuda3.Resultado IsNot Nothing Then
                .CMNVTA = CType(UcAyuda3.Resultado, Ransa.TypeDef.beGeneral).PNCMNDA1 'Moneda de la venta
            End If

            If rbtCriterioLote.Checked Then
                If String.IsNullOrEmpty(txtCriterioLote.Text.Trim) Then
                    MessageBox.Show("Ingrese Criterio de Lote", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCriterioLote.Focus()
                    Exit Sub
                Else
                    .CRTLTE = txtCriterioLote.Text.Trim
                End If
            End If

            If rbtFechaIngreso.Checked Then .FINGAL = HelpClass.CDate_a_Numero8Digitos(dtpFechaIngreso.Value.Date)
            If rbtFechaProduccion.Checked Then .FPRDMR = HelpClass.CDate_a_Numero8Digitos(dtpFechaProduccion.Value.Date)
            If rbtFechaVencimiento.Checked Then .FVNLTE = HelpClass.CDate_a_Numero8Digitos(dtpFechaVencimiento.Value.Date)
            .IMPVTA = Val(txtImportVenta.Text)
            .NTRNO = Val(txtNrTurno.Text.Trim)
            .TOBSCR = txtObservacion.Text.Trim.ToUpper
            .PSCULUSA = objSeguridadBN.pUsuario
        End With
        If objbrLote.InsertarActualizarLotes(objLote) = True Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        LimpiarControles()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Dim ofrmListaDeMercaderiasSDS As New frmListaDeMercaderiasSDS
        ofrmListaDeMercaderiasSDS.CHK.Visible = False
        ofrmListaDeMercaderiasSDS.PNCCLNT = CCLNT    'Cleinete 
        If ofrmListaDeMercaderiasSDS.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtAyuda.Text = ofrmListaDeMercaderiasSDS.obeMercaderia.PNNORDSR
            'txtCriterioLote.Focus()
            'OrdenServicio = ofrmListaDeMercaderiasSDS.obeMercaderia.PNNORDSR
            'Me.txtDescMerca01.Text = ofrmListaDeMercaderiasSDS.obeMercaderia.PSTMRCD2
        End If
    End Sub


    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub txtNrTurno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrTurno.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtDocProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocProveedor.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtImportProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportProveedor.KeyPress
        NumerosyDecimal(txtImportProveedor, e)
    End Sub

    Private Sub txtImportVenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportVenta.KeyPress
        NumerosyDecimal(txtImportVenta, e, 5)
    End Sub


#End Region

#Region "Metodos"

    Private Sub LimpiarControles()
        txtAyuda.Text = String.Empty
        NCRRIN = 0
        txtCriterioLote.Text = String.Empty
        CCLNT = 0
        txtProveedor.pCodigo = 0
        txtDocProveedor.Text = String.Empty
        txtImportProveedor.Text = String.Empty
        txtImportVenta.Text = String.Empty
        dtpFechaIngreso.Value = Date.Now
        dtpFechaProduccion.Value = Date.Now
        dtpFechaVencimiento.Value = Date.Now
        txtNrTurno.Text = 0
        txtObservacion.Text = String.Empty
    End Sub


    Private Sub CargarDatosLote(ByVal objLote As beLote)
        txtAyuda.Enabled = False
        txtCriterioLote.Enabled = False
        GroupBox1.Enabled = False
        With objLote
            NCRRIN = .NCRRIN
            CCLNT = .CCLNT
            txtAyuda.Text = .NORDSR

            If .CRTLTE.Trim <> "" Then
                rbtCriterioLote.Checked = True
                txtCriterioLote.Text = .CRTLTE
            End If
            txtProveedor.pCodigo = .CPRVCL
            txtDocProveedor.Text = .NDCMPV
            UcAyuda2.Valor = .CMNCT 'Moneda del Proveed  oer
            txtImportProveedor.Text = .IMPTTL  'importe del proveedor
            UcAyuda3.Valor = .CMNVTA ' 0 'Moneda de la venta
            txtImportVenta.Text = .IMPVTA
            If .FINGAL <> 0 Then
                rbtFechaIngreso.Checked = True
                dtpFechaIngreso.Value = HelpClass.CNumero8Digitos_a_Fecha(.FINGAL)
            End If

            If .FPRDMR <> 0 Then
                rbtFechaProduccion.Checked = True
                dtpFechaProduccion.Value = HelpClass.CNumero8Digitos_a_Fecha(.FPRDMR)
            End If
            If .FVNLTE <> 0 Then
                rbtFechaVencimiento.Checked = True
                dtpFechaVencimiento.Value = HelpClass.CNumero8Digitos_a_Fecha(.FVNLTE)
            End If
            txtNrTurno.Text = .NTRNO
            txtObservacion.Text = .TOBSCR
        End With

    End Sub


    Private Sub CargarMoneda()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrGeneral As New Ransa.NEGO.brGeneral

        oColumnas.Name = "PNCMNDA1" '"TSGNMN" '"CMNDA1" 
        oColumnas.DataPropertyName = "PSTSGNMN" '"PNCMNDA1"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMNDA"
        oColumnas.DataPropertyName = "PSTMNDA"
        oColumnas.HeaderText = "Moneda"
        oListColum.Add(2, oColumnas)

        Dim oListColum2 As New Hashtable
        Dim oColumnas2 As New DataGridViewTextBoxColumn
        oColumnas2.Name = "PNCMNDA1" '"TSGNMN" '"PNCMNDA1"
        oColumnas2.DataPropertyName = "PSTSGNMN" '"CMNDA1"
        oColumnas2.HeaderText = "Código"
        oListColum2.Add(1, oColumnas2)

        oColumnas2 = New DataGridViewTextBoxColumn
        oColumnas2.Name = "TMNDA"
        oColumnas2.DataPropertyName = "PSTMNDA"
        oColumnas2.HeaderText = "Moneda"
        oListColum2.Add(2, oColumnas2)

        Dim olMoneda As New List(Of beGeneral)
        olMoneda = obrGeneral.ListaMoneda()
        UcAyuda2.DataSource = olMoneda
        UcAyuda3.DataSource = olMoneda


        UcAyuda2.ListColumnas = oListColum
        UcAyuda2.Cargas()
        UcAyuda2.Limpiar()
        UcAyuda2.ValueMember = "PNCMNDA1"
        UcAyuda2.DispleyMember = "PSTMNDA"

        UcAyuda3.ListColumnas = oListColum2
        UcAyuda3.Cargas()
        UcAyuda3.Limpiar()
        UcAyuda3.ValueMember = "PNCMNDA1"
        UcAyuda3.DispleyMember = "PSTMNDA"

    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, Optional ByVal decimales As Int32 = 2)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region


    Private Sub txtCriterioLote_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterioLote.Leave
        'If String.IsNullOrEmpty(txtAyuda.Text) Or String.IsNullOrEmpty(txtCriterioLote.Text.Trim) Then Exit Sub

        'Dim obrLote As New brLote
        'Dim obeLote As New beLote
        'Dim rsl As Integer = -1
        'obeLote.NORDSR = Val(txtAyuda.Text)
        'obeLote.CCLNT = CCLNT
        'obeLote.CRTLTE = txtCriterioLote.Text.Trim
        'rsl = obrLote.ValidarExistenciaCriterioLote(obeLote)
        'Select Case (rsl)
        '    Case 1
        '        MessageBox.Show("Existe Lote con el mismo criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtCriterioLote.Focus()
        '    Case -1
        '        MessageBox.Show("Error de conexión ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Select
 

    End Sub

    Private Sub rbtFechaIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechaIngreso.CheckedChanged
        If rbtFechaIngreso.Checked Then
            HabilidarControles(2, True)
        End If
    End Sub


    Private Sub HabilidarControles(ByVal Control As Integer, ByVal Estado As Boolean)

        Select Case (Control)

            Case 1 'Criterio de Lote
                txtCriterioLote.Enabled = Estado
                dtpFechaIngreso.Enabled = Not (Estado)
                dtpFechaProduccion.Enabled = Not (Estado)
                dtpFechaVencimiento.Enabled = Not (Estado)
                rbtFechaIngreso.Checked = Not (Estado)
                rbtFechaProduccion.Checked = Not (Estado)
                rbtFechaVencimiento.Checked = Not (Estado)
            Case 2  'Fecha de ingreso
                txtCriterioLote.Enabled = Not (Estado)
                dtpFechaIngreso.Enabled = Estado
                dtpFechaProduccion.Enabled = Not (Estado)
                dtpFechaVencimiento.Enabled = Not (Estado)
                rbtFechaProduccion.Checked = Not (Estado)
                rbtFechaVencimiento.Checked = Not (Estado)
                rbtCriterioLote.Checked = Not (Estado)
            Case 3 'Fecha Produccion
                txtCriterioLote.Enabled = Not (Estado)
                dtpFechaIngreso.Enabled = Not (Estado)
                dtpFechaProduccion.Enabled = Estado
                dtpFechaVencimiento.Enabled = Not (Estado)
                rbtFechaIngreso.Checked = Not (Estado)
                rbtFechaVencimiento.Checked = Not (Estado)
                rbtCriterioLote.Checked = Not (Estado)
            Case 4 'Fecha Vencimiento
                txtCriterioLote.Enabled = Not (Estado)
                dtpFechaIngreso.Enabled = Not (Estado)
                dtpFechaProduccion.Enabled = Not (Estado)
                dtpFechaVencimiento.Enabled = Estado
                rbtFechaIngreso.Checked = Not (Estado)
                rbtFechaProduccion.Checked = Not (Estado)
                rbtCriterioLote.Checked = Not (Estado)
        End Select
    End Sub

    Private Sub rbtCriterioLote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCriterioLote.CheckedChanged

        If rbtCriterioLote.Checked Then
            HabilidarControles(1, True)
        End If


    End Sub

    Private Sub rbtFechaProduccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechaProduccion.CheckedChanged
        If rbtFechaProduccion.Checked Then
            HabilidarControles(3, True)
        End If
    End Sub

    Private Sub rbtFechaVencimiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechaVencimiento.CheckedChanged
        If rbtFechaVencimiento.Checked Then
            HabilidarControles(4, True)
        End If
    End Sub
End Class
