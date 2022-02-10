'Imports Ransa.DAO.Proveedor
'Imports Ransa.TypeDef.Proveedor
'Imports Ransa.TypeDef.Cliente
'Imports Ransa.NEGO
Imports Ransa.Controls.Cliente

Public Class frmRelacionClienteProveedor
    Public pCCLNT As Decimal = 0
    Public pUsuario As String = ""
    Private _MostrarTituloOpcion1 As Boolean = False
    Private oInfoProveedor As New beProveedor
    Public Property pMostrarTituloOpcion1() As Boolean
        Get
            Return _MostrarTituloOpcion1
        End Get
        Set(ByVal value As Boolean)
            _MostrarTituloOpcion1 = value
        End Set
    End Property


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If (txtProveedor.pCodigo = 0) Then
                MessageBox.Show("Debe de seleccionar un Proveedor", "Relacionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim resultado As String = ""
                Dim oblProveedor As New cProveedor
                Dim obeProveedor As New beProveedor()
                obeProveedor.PNCCLNT = pCCLNT
                obeProveedor.PNCPRVCL = txtProveedor.pCodigo
                obeProveedor.PSCULUSA = pUsuario
                obeProveedor.PSSTPORL = CType(Me.txtTipo.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
                obeProveedor.PSCPRPCL = txtCodClienteProveedor.Text
                obeProveedor = oblProveedor.RegistrarRelacionTercero_x_Cliente(obeProveedor)
                If (obeProveedor.RELACION = "TRUE") Then
                    MessageBox.Show("No se puede realizar la operación .La relación ya existe" & Chr(13) & "Puede seleccionar otro proveedor")
                ElseIf obeProveedor.CREACION = "INS" Then
                    MessageBox.Show("Se ha grabado satisfactoriamente la relación")
                    Me.Close()
                ElseIf obeProveedor.CREACION = "UPD" Then
                    MessageBox.Show("Se ha actualizado satisfactoriamente la relación")
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo realizar la operación")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRelacionClienteProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientePK As TD_ClientePK = New TD_ClientePK(pCCLNT, pUsuario)
            txtCliente.pCargar(ClientePK)
            txtCliente.Enabled = False
            If (pMostrarTituloOpcion1 = True) Then
                btnNuevo.Visible = True
                Me.Text = "Relación Cliente-Proveedor"
                lblProveedor.Text = "Proveedor :"
                txtProveedor.pMostarBtnNewProv = False
            End If
            CargarControles()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim ofrmProveedor_MDatos As New frmProveedor_MDatos
            ofrmProveedor_MDatos.IsNuevo = True
            ofrmProveedor_MDatos.ShowDialog(Me)
            If (ofrmProveedor_MDatos.myDialogResult = True) Then
                oInfoProveedor = ofrmProveedor_MDatos.oInfoProveedor
                txtProveedor.ActualizarBusqueda(oInfoProveedor.PNCPRVCL)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarControles()

        '
        'Dim obrGeneral As New Ransa.NEGO.brGeneral
        Dim obrGeneral As New brGeneral_BL


        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn

        ''==========tipo Origen
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCMPRN"
        oColumnas.DataPropertyName = "PSCCMPRN"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TDSDES"
        oColumnas.DataPropertyName = "PSTDSDES"
        oColumnas.HeaderText = "Origen"
        oListColum.Add(2, oColumnas)

        txtTipo.DataSource = obrGeneral.olTipoOrigen(txtCliente.pCodigo)
        txtTipo.ListColumnas = oListColum
        txtTipo.Cargas()
        txtTipo.ValueMember = "PSCCMPRN"
        txtTipo.DispleyMember = "PSTDSDES"

        txtTipo.Valor = "P"
        txtTipo.Refresh()

    End Sub
End Class
