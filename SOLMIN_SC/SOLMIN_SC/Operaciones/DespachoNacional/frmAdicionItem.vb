Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmAdicionItem
    Enum Accion
        Nuevo
        Modificar
        Visual
    End Enum


    Private _pAccion As Accion = Accion.Nuevo
    Public Property pAccion() As Accion
        Get
            Return _pAccion
        End Get
        Set(ByVal value As Accion)
            _pAccion = value
        End Set
    End Property


    Private _obeItem As New beItemOC
    Public Property obeItem() As beItemOC
        Get
            Return _obeItem
        End Get
        Set(ByVal value As beItemOC)
            _obeItem = value
        End Set
    End Property


    Private _oHasListaItem As New Hashtable
    Public Property oHasListaItem() As Hashtable
        Get
            Return _oHasListaItem
        End Get
        Set(ByVal value As Hashtable)
            _oHasListaItem = value
        End Set
    End Property




 
    Private Sub frmAdicionItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaMoneda()

            Dim oclsDespachoNacional As New clsDespachoNacional
            'Dim dtUnidadMedida As New DataTable
            'dtUnidadMedida = oclsDespachoNacional.Listar_Unidades_Medida_Carga_Item()
            'cmbUnidMedida.DataSource = dtUnidadMedida
            'cmbUnidMedida.DisplayMember = "DETALLE"
            'cmbUnidMedida.ValueMember = "UNIDAD"
            'cmbUnidMedida.SelectedValue = "UNIDADES"


            Select Case _pAccion
                Case Accion.Modificar
                    txtNroitem.Text = Val(_obeItem.PNNRITOC)
                    txtNroitem.Enabled = False
                    txtRefNum.Text = _obeItem.PSNUMDCR
                    txtGuiaProv.Text = _obeItem.PSNGRPRV
                    txtDescripcion.Text = _obeItem.PSTDITES
                    txtCantidad.Text = Val(_obeItem.PNQCNTIT)
                    txtPrecioUniatrio.Text = Val(_obeItem.PNIVUNIT)
                    cbxUnidadMedida.Text = _obeItem.PSTUNDIT
                    'cmbUnidMedida.SelectedValue = _obeItem.PSTUNDIT
                    cmbMoneda.SelectedValue = _obeItem.PNCMNDA1
                    UcProveedor.pCodigo = _obeItem.PNCPRVCL
                Case Accion.Visual
                    txtNroitem.Text = Val(_obeItem.PNNRITOC)
                    txtRefNum.Text = _obeItem.PSNUMDCR
                    txtGuiaProv.Text = _obeItem.PSNGRPRV
                    txtDescripcion.Text = _obeItem.PSTDITES
                    txtCantidad.Text = Val(_obeItem.PNQCNTIT)
                    txtPrecioUniatrio.Text = Val(_obeItem.PNIVUNIT)
                    'cmbUnidMedida.SelectedValue = _obeItem.PSTUNDIT
                    cbxUnidadMedida.Text = _obeItem.PSTUNDIT
                    cmbMoneda.SelectedValue = _obeItem.PNCMNDA1
                    UcProveedor.pCodigo = _obeItem.PNCPRVCL

                    txtNroitem.Enabled = False
                    txtRefNum.Enabled = False
                    txtGuiaProv.Enabled = False
                    txtDescripcion.Enabled = False
                    txtCantidad.Enabled = False
                    txtPrecioUniatrio.Enabled = False
                    cbxUnidadMedida.Enabled = False
                    cmbMoneda.ComboBox.Enabled = False
                    btnGuardar.Enabled = False
                    UcProveedor.Enabled = False

            End Select
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaMoneda()
        Dim dtMoneda As New DataTable
        Dim oclMoneda As New clsMoneda
        oclMoneda.Crea_Lista()
        dtMoneda = oclMoneda.Lista_Moneda(1)

        cmbMoneda.DataSource = dtMoneda
        cmbMoneda.DisplayMember = "TSGNMN"
        cmbMoneda.ValueMember = "CMNDA1"
    End Sub
    Private Function ValidarIngresoItem() As String
        Dim cad As String = ""
        If txtNroitem.Text.Trim = "" OrElse Val(txtNroitem.Text.Trim) = 0 Then
            cad = "Ingrese número item"
        End If
        If txtDescripcion.Text.Trim = "" Then
            cad = cad & Chr(13) & "Ingrese descripción"
        End If
        If Val(txtCantidad.Text.Trim) = 0 Then
            cad = cad & Chr(13) & "Ingrese cantidad mayor a cero"
        End If
        cbxUnidadMedida.Text = cbxUnidadMedida.Text.Trim
        If cbxUnidadMedida.Text.Length > 10 Then
            cbxUnidadMedida.Text = cbxUnidadMedida.Text.Substring(0, 9)
        End If
        Return cad
    End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim msg As String = ValidarIngresoItem()
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Select Case _pAccion
                Case Accion.Nuevo
                    Dim item As String = txtNroitem.Text.Trim
                    If oHasListaItem.Contains(item) Then
                        MessageBox.Show("El item asignado ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    _obeItem.PNNRITOC = txtNroitem.Text.Trim
                    _obeItem.PSNUMDCR = txtRefNum.Text.Trim
                    _obeItem.PSTDITES = txtDescripcion.Text
                    _obeItem.PNQCNTIT = txtCantidad.Text
                    _obeItem.PNIVUNIT = Val(txtPrecioUniatrio.Text)
                    _obeItem.PSNGRPRV = txtGuiaProv.Text.Trim
                    'cbxUnidadMedida
                    '_obeItem.PSTUNDIT = cmbUnidMedida.SelectedValue
                    _obeItem.PSTUNDIT = cbxUnidadMedida.Text.Trim
                    _obeItem.PSMONEDA = cmbMoneda.Text.Trim
                    _obeItem.PNCMNDA1 = cmbMoneda.SelectedValue
                    _obeItem.PNCPRVCL = UcProveedor.pCodigo
                    _obeItem.PSTPRVCL = UcProveedor.pRazonSocial
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Case Accion.Modificar
                    _obeItem.PSNUMDCR = txtRefNum.Text.Trim
                    _obeItem.PSTDITES = txtDescripcion.Text.Trim

                    _obeItem.PNQCNTIT = txtCantidad.Text
                    _obeItem.PNIVUNIT = Val(txtPrecioUniatrio.Text)
                    _obeItem.PSNGRPRV = txtGuiaProv.Text.Trim
                    '_obeItem.PSTUNDIT = cmbUnidMedida.SelectedValue
                    _obeItem.PSTUNDIT = cbxUnidadMedida.Text.Trim
                    _obeItem.PSMONEDA = cmbMoneda.Text.Trim
                    _obeItem.PNCMNDA1 = cmbMoneda.SelectedValue
                    _obeItem.PNCPRVCL = UcProveedor.pCodigo
                    _obeItem.PSTPRVCL = UcProveedor.pRazonSocial
                    Me.DialogResult = Windows.Forms.DialogResult.OK
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
