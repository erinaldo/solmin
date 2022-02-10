
Imports RANSA.TypeDef
Imports RANSA.NEGO


Public Class frmAgregarPosicion


#Region "Variables"
    Public NORDSR As Decimal = 0
    Public NCRRIN As Decimal = 0
    Public USUARIO As String = ""
    Public PLANTA As String = ""
#End Region

#Region "Delegados"
 
    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Dim ofrmListaDeSloting As New frmListaPosiciones

        If txtTipoAlmacen.Resultado Is Nothing Then
            MessageBox.Show("Debe de seleccionar el Tipo de Almacen.")
            Exit Sub
        End If
        If txtAlmacen.Resultado Is Nothing Then
            MessageBox.Show("Debe de seleccionar Almacen.")
            Exit Sub
        End If
        ofrmListaDeSloting.PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM 'Me.txtTipoAlmacen.Tag
        ofrmListaDeSloting.PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC ' Me.txtAlmacen.Tag
        ofrmListaDeSloting.PSCSECTR = "G"
        If ofrmListaDeSloting.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtAyuda.Text = ofrmListaDeSloting.obeUbicacion.PSCPSCN
            'txtPosicion.Text = ofrmListaDeSloting.obeUbicacion.PSCPSCN
            'txtPasillo.Text = ofrmListaDeSloting.obeUbicacion.PSCPSLL
            'Me.txtColumna.Text = ofrmListaDeSloting.obeUbicacion.PSCCLMN
        End If
        txtTipoAlmacen.Focus()
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
            CType(objData, beAlmacen).PNCPLNFC = PLANTA
            'CType(objData, beAlmacen).PNCPLNFC = pintPlanta
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

    Private Sub CargarControlTipoAlmacen()
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
        txtTipoAlmacen.Limpiar()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"
    End Sub
 
    Private Sub frmAgregarPosicion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            CargarControlTipoAlmacen()
        Catch ex As Exception
        End Try
      

    End Sub
 
    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
 
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        If valiar().Length > 0 Then
            MessageBox.Show(valiar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim objUbicacion As New BeUbicacionesLotes
        Dim obrLotes As New brLote
        objUbicacion.NORDSR = NORDSR
        objUbicacion.NCRRIN = NCRRIN
        objUbicacion.CTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        objUbicacion.CALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
        objUbicacion.CPSCN = txtAyuda.Text
        objUbicacion.CSECTR = "G"
        objUbicacion.PSCULUSA = USUARIO
        If obrLotes.InsertarUbicacionLotes(objUbicacion) Then
            limpiarControels()
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub txtTipoAlmacen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoAlmacen.Validating
        If txtTipoAlmacen.Text = "" Then
            txtTipoAlmacen.Tag = ""
        Else
            If txtTipoAlmacen.Text <> "" And "" & txtTipoAlmacen.Tag = "" Then
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
                If txtTipoAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAlmacen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen.Validating
        If txtAlmacen.Text = "" Then
            txtAlmacen.Tag = ""
        Else
            If txtAlmacen.Text <> "" And "" & txtAlmacen.Tag = "" Then
                Call mfblnBuscar_Almacen("" & txtTipoAlmacen.Tag, txtAlmacen.Tag, txtAlmacen.Text)
                If txtAlmacen.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoAlmacen_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAlmacen.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Call mfblnBuscar_TipoAlmacen(txtTipoAlmacen.Tag, txtTipoAlmacen.Text)
            Case Keys.Delete
                txtTipoAlmacen.Text = ""
        End Select
    End Sub
#End Region

#Region "Metodos y Funciones"

    Private Sub limpiarControels()
        txtTipoAlmacen.Tag = ""
        txtTipoAlmacen.Text = ""
        txtAlmacen.Tag = ""
        txtAlmacen.Text = ""
        txtAyuda.Text = String.Empty
        NORDSR = 0
        NCRRIN = 0
    End Sub

    Private Function valiar() As String
        Dim strMensajeError As String = ""
        If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén." & Environment.NewLine
        If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén" & Environment.NewLine
        If txtAyuda.Text = "" Then strMensajeError &= "Debe seleccionar una Posición." & Environment.NewLine
        Return strMensajeError
    End Function
#End Region

End Class
