Imports Ransa.TYPEDEF
Imports Ransa.NEGO

Public Class frmAddZona
    Dim obeZonaAlmacen As beZonaAlmacen

    Private _PNBOTTON As Integer
    Public Property PNBOTTON() As Integer
        Get
            Return _PNBOTTON
        End Get
        Set(ByVal value As Integer)
            _PNBOTTON = value
        End Set
    End Property

    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Private _PSCTPALM As String
    Public Property PSCTPALM() As String
        Get
            Return _PSCTPALM
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property

    Private _PSCALMC As String
    Public Property PSCALMC() As String
        Get
            Return _PSCALMC
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property


    Private _beZonaAlmacen As beZonaAlmacen
    Public Property pbeZonaAlmacen() As beZonaAlmacen
        Get
            Return _beZonaAlmacen
        End Get
        Set(ByVal value As beZonaAlmacen)
            _beZonaAlmacen = value
        End Set
    End Property


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If PNBOTTON = 1 Then
            If validar() Then
                grabar()
            End If
        ElseIf PNBOTTON = 2 Then
            If validar() Then
                actualizar()
            End If
        End If
    End Sub
    Private Sub grabar()

        Dim obrZonaAlmacen As New brZonaAlmacen
        Try
            crearEntity()
            If obrZonaAlmacen.mantenimiento_zona_almacem(obeZonaAlmacen, 1) > 0 Then
                MessageBox.Show("se grabó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error al grabar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub actualizar()

        Dim obrZonaAlmacen As New brZonaAlmacen
        Try
            crearEntity()
            If obrZonaAlmacen.mantenimiento_zona_almacem(obeZonaAlmacen, 2) > 0 Then
                MessageBox.Show("se grabó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error al grabar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub crearEntity()
        obeZonaAlmacen = New beZonaAlmacen

        obeZonaAlmacen.PSCTPALM = CType(Me.txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        obeZonaAlmacen.PSCALMC = CType(Me.txtAlmacen.Resultado, beAlmacen).PSCALMC
        obeZonaAlmacen.PSCZNALM = Me.txtCodigo.Text
        obeZonaAlmacen.PSTCMZNA = Me.txtDescCompleta.Text
        obeZonaAlmacen.PSTABZNA = Me.txtDescAbreviado.Text
        obeZonaAlmacen.PNQARMTS = IIf(Me.txtCantidad.Text = "", 0, Me.txtCantidad.Text)
        obeZonaAlmacen.PSSDISAT = Me.cmbAtencion.SelectedValue
        obeZonaAlmacen.PSUSUARIO = objSeguridadBN.pUsuario
        obeZonaAlmacen.PSNTRMNL = objSeguridadBN.pstrPCName
    End Sub
    Private Sub frmAddZona_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        Dim dtAtencion As New DataTable
        Dim drFilas As DataRow
        dtAtencion.Columns.Add("SDISAT")
        dtAtencion.Columns.Add("DDISAT")
        drFilas = dtAtencion.NewRow
        drFilas("SDISAT") = "S"
        drFilas("DDISAT") = "SI"
        dtAtencion.Rows.Add(drFilas)
        drFilas = dtAtencion.NewRow
        drFilas("SDISAT") = "N"
        drFilas("DDISAT") = "NO"
        dtAtencion.Rows.Add(drFilas)
        Me.cmbAtencion.DataSource = dtAtencion
        Me.cmbAtencion.DisplayMember = "DDISAT"
        Me.cmbAtencion.ValueMember = "SDISAT"

        If PNBOTTON = 1 Then
            txtTipoAlmacen.Valor = PSCTPALM
            txtAlmacen.Valor = PSCALMC
            txtTipoAlmacen.Enabled = False
            txtAlmacen.Enabled = False
        ElseIf PNBOTTON = 2 Then
            txtTipoAlmacen.Valor = pbeZonaAlmacen.PSCTPALM
            txtAlmacen.Valor = pbeZonaAlmacen.PSCALMC
            txtCodigo.Text = pbeZonaAlmacen.PSCZNALM
            txtTipoAlmacen.Enabled = False
            txtAlmacen.Enabled = False
            txtCodigo.Enabled = False
            txtDescCompleta.Text = pbeZonaAlmacen.PSTCMZNA
            txtDescAbreviado.Text = pbeZonaAlmacen.PSTABZNA
            txtCantidad.Text = Math.Round(pbeZonaAlmacen.PNQARMTS, 2)
            cmbAtencion.Text = pbeZonaAlmacen.PSSDISAT
        End If
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
            CType(objData, beAlmacen).PNCPLNFC = PNCPLNDV
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
    Private Function validar() As Boolean
        Dim strMensajeError As String = ""
        If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén" & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén." & vbNewLine
        If txtCodigo.Text = "" Then strMensajeError &= "Debe escibir un Código." & vbNewLine
        If txtDescCompleta.Text = "" Then strMensajeError &= "Debe escibir una Descripción Completa." & vbNewLine
        If txtDescAbreviado.Text = "" Then strMensajeError &= "Debe escibir una Descripción Abreviada." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtDescAbreviado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescAbreviado.TextChanged

    End Sub
End Class
