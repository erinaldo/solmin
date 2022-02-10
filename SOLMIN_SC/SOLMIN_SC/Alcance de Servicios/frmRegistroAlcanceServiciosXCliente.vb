Imports Ransa.TypeDef.Cliente
Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmRegistroAlcanceServiciosXCliente

    Private _PSACTION As String
    Public Property PSACTION() As String
        Get
            Return _PSACTION
        End Get
        Set(ByVal value As String)
            _PSACTION = value
        End Set
    End Property

    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCDVSN As String = ""
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCCLNT As Integer
    Public Property PNCCLNT() As Integer
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Integer)
            _PNCCLNT = value
        End Set
    End Property

    Private _obeAlcanceServicio As beAlcanceServicio
    Public Property BeAlcanceServicio() As beAlcanceServicio
        Get
            Return _obeAlcanceServicio
        End Get
        Set(ByVal value As beAlcanceServicio)
            _obeAlcanceServicio = value
        End Set
    End Property


    Private Sub frmRegistroAlcanceServiciosXCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtTitulo.Text = ""
            If PSACTION.Equals("ADD") Then
                UcDivision_Cmb011.Compania = _PSCCMPN
                UcDivision_Cmb011.Usuario = HelpUtil.UserName
                UcDivision_Cmb011.DivisionDefault = _PSCDVSN
                UcDivision_Cmb011.pActualizar()
                Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
                txtCliente.pCargar(ClientePK)
                txtCliente.pCargar(_PNCCLNT)
                Cargar_Mes()
                txtAnio.Text = Now.Year
                txtCantidad.txtDecimales.Text = "0.00"
                cmbMes.SelectedValue = IIf((Now.Month < 10), "0" & Now.Month, Now.Month.ToString)
                CargarAlcanceServicio()
            ElseIf PSACTION.Equals("EDIT") Then
                If BeAlcanceServicio IsNot Nothing Then
                    UcDivision_Cmb011.Compania = BeAlcanceServicio.PSCCMPN
                    UcDivision_Cmb011.Usuario = HelpUtil.UserName
                    UcDivision_Cmb011.DivisionDefault = BeAlcanceServicio.PSCDVSN
                    UcDivision_Cmb011.pActualizar()
                    UcDivision_Cmb011.pHabilitado = False
                    Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
                    txtCliente.pCargar(ClientePK)
                    txtCliente.pCargar(BeAlcanceServicio.PNCCLNT)
                    txtCliente.Enabled = False
                    Cargar_Mes()
                    CargarAlcanceServicio()
                    Me.UcAlcanceServicio.Valor = BeAlcanceServicio.PNNCRRLT
                    Me.UcAlcanceServicio.Enabled = False
                    Me.txtAnio.Text = BeAlcanceServicio.PNNANASR
                    Me.txtAnio.Enabled = False
                    Me.cmbMes.SelectedValue = IIf((BeAlcanceServicio.PNNMSASR < 10), "0" & BeAlcanceServicio.PNNMSASR, BeAlcanceServicio.PNNMSASR.ToString)
                    Me.cmbMes.ComboBox.Enabled = False
                    Me.txtCantidad.txtDecimales.Text = BeAlcanceServicio.PNQMDASC
                    Me.txtDescripcion.Text = BeAlcanceServicio.PSTSRVC
                
                End If
                End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Sub Cargar_Mes()
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Codigo", Type.GetType("System.String"))
        dtMes.Columns.Add("Descripcion", Type.GetType("System.String"))
        Dim dr As DataRow
        dr = dtMes.NewRow
        dr("Codigo") = "01"
        dr("Descripcion") = "Enero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "02"
        dr("Descripcion") = "Febrero"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "03"
        dr("Descripcion") = "Marzo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "04"
        dr("Descripcion") = "Abril"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "05"
        dr("Descripcion") = "Mayo"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "06"
        dr("Descripcion") = "Junio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "07"
        dr("Descripcion") = "Julio"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "08"
        dr("Descripcion") = "Agosto"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "09"
        dr("Descripcion") = "Septiembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "10"
        dr("Descripcion") = "Octubre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "11"
        dr("Descripcion") = "Noviembre"
        dtMes.Rows.Add(dr)
        dr = dtMes.NewRow
        dr("Codigo") = "12"
        dr("Descripcion") = "Diciembre"
        dtMes.Rows.Add(dr)

        cmbMes.DataSource = dtMes
        cmbMes.ValueMember = "Codigo"
        cmbMes.DisplayMember = "Descripcion"

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub CargarAlcanceServicio()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obrAlcanceServicio As New clsAlcanceServicio
        Dim obeAlcanceServicio As New beAlcanceServicio
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNNCRRLT"
        oColumnas.DataPropertyName = "PNNCRRLT"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTDALSR"
        oColumnas.DataPropertyName = "PSTDALSR"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PNQMDALS"
        oColumnas.DataPropertyName = "PNQMDALS"
        oColumnas.HeaderText = "Cantidad "
        oColumnas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTABRUN"
        oColumnas.DataPropertyName = "PSTABRUN"
        oColumnas.HeaderText = "Unidad"
        oColumnas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(4, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "PSTRFMED"
        oColumnas.DataPropertyName = "PSTRFMED"
        oColumnas.HeaderText = "Referencia"
        'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(5, oColumnas)
        With obeAlcanceServicio
            If PSACTION.Equals("ADD") Then
                .PSCCMPN = PSCCMPN
                .PSCDVSN = Me.UcDivision_Cmb011.Division
                .PNCCLNT = Me.txtCliente.pCodigo
            ElseIf PSACTION.Equals("EDIT") Then
                .PSCCMPN = BeAlcanceServicio.PSCCMPN
                .PSCDVSN = BeAlcanceServicio.PSCDVSN
                .PNCCLNT = BeAlcanceServicio.PNCCLNT
            End If
        End With

        Me.UcAlcanceServicio.DataSource = obrAlcanceServicio.flistListarAlcanceServicioXCliente(obeAlcanceServicio)
        Me.UcAlcanceServicio.ListColumnas = oListColum
        Me.UcAlcanceServicio.Cargas()
        Me.UcAlcanceServicio.DispleyMember = "PSTDALSR"
        Me.UcAlcanceServicio.ValueMember = "PNNCRRLT"
        Me.UcAlcanceServicio.PopupWidth = 650

    End Sub

    Private Sub UcAlcanceServicio_CambioDeTexto(ByVal objData As Object) Handles UcAlcanceServicio.CambioDeTexto
        If Me.UcAlcanceServicio.Resultado IsNot Nothing Then
            Me.lblCadena.Text = CType(Me.UcAlcanceServicio.Resultado, beAlcanceServicio).PSTABRUN
        End If
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            If validarCampos() Then
                Dim strResult As String = ""
                Dim obrAlcanceServicio As New clsAlcanceServicio
                Dim obeAlcanceServicio As New beAlcanceServicio
                If PSACTION.Equals("ADD") Then
                    obeAlcanceServicio.PSCCMPN = _PSCCMPN
                    obeAlcanceServicio.PSCDVSN = Me.UcDivision_Cmb011.Division
                    obeAlcanceServicio.PNCCLNT = Me.txtCliente.pCodigo
                    obeAlcanceServicio.PNNANASR = Me.txtAnio.Text
                    obeAlcanceServicio.PNNMSASR = Me.cmbMes.SelectedValue
                    obeAlcanceServicio.PNNCRRLT = CType(Me.UcAlcanceServicio.Resultado, beAlcanceServicio).PNNCRRLT
                    obeAlcanceServicio.PSUSUARIO = HelpUtil.UserName
                    obeAlcanceServicio.PSNTRMNL = Environment.MachineName
                ElseIf PSACTION.Equals("EDIT") Then
                    obeAlcanceServicio = BeAlcanceServicio
                End If
                obeAlcanceServicio.PNQMDASC = Me.txtCantidad.txtDecimales.Text
                obeAlcanceServicio.PSTSRVC = Me.txtDescripcion.Text
                obeAlcanceServicio.PSSESTRG = "A"

                If PSACTION.Equals("ADD") Then
                    strResult = obrAlcanceServicio.fstrInsertarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
                    If strResult.Equals("S") Then
                        If MessageBox.Show("Ya existe " & Chr(13) & "Desea Actualizar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            'actualizamos
                            strResult = obrAlcanceServicio.fstrActualizarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
                            If strResult.Equals("") Then
                                MessageBox.Show("Se registró correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            Else
                                MessageBox.Show("Ocurrió un error al registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    ElseIf strResult.Equals("N") Then
                        MessageBox.Show("Se registró correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Ocurrió un error al registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf PSACTION.Equals("EDIT") Then
                    strResult = obrAlcanceServicio.fstrActualizarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
                    If strResult.Equals("") Then
                        MessageBox.Show("Se registró correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Ocurrió un error al registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function validarCampos() As Boolean
        Dim strError As String = ""

        If UcDivision_Cmb011.Division = String.Empty Then
            strError = strError & "* Ingrese Divisón" & Chr(13)
        End If
        If txtCliente.pCodigo = 0 Then
            strError = strError & "* Ingrese Cliente" & Chr(13)
        End If
        If UcAlcanceServicio.Resultado Is Nothing Then
            strError = strError & "* Ingrese Alcance de Servicio" & Chr(13)
        End If
        If txtAnio.Text = String.Empty Or Val(txtAnio.Text) < 2000 Then
            strError = strError & "* Ingrese Año válido"
        End If
        If cmbMes.SelectedValue = String.Empty Then
            strError = strError & "* Seleccione Mes"
        End If
        If txtCantidad.txtDecimales.Text = String.Empty Or Val(txtCantidad.txtDecimales.Text) = 0 Then
            strError = strError & "* Ingrese Cantidad" & Chr(13)
        End If
        If strError.Trim.Length > 0 Then
            MessageBox.Show("Verifique: " & Chr(13) & strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub UcDivision_Cmb011_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.SelectionChangeCommitted
        UcAlcanceServicio.Valor = ""
        CargarAlcanceServicio()
    End Sub

    Private Sub txtCliente_TextChanged() Handles txtCliente.TextChanged
        UcAlcanceServicio.Valor = ""
            CargarAlcanceServicio()
    End Sub
End Class
