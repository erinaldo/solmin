Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
'Imports Ransa.TypeDef.Cliente
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.TYPEDEF.Proveedor
Imports Ransa.Controls.Cliente
Public Class frmListaClienteTercero

#Region "Atributos"
    Private CCLNT As Decimal = 0
#End Region

#Region "Variables"

#End Region

#Region "Metodos y Funciones"

    Private Sub ActualizarLista()
        Try           
            UcProveedor_DgCab1.pCCLNT = txtCliente.pCodigo
            UcProveedor_DgCab1.pNRUCPRSTR = txtRuc.Text.Trim
            UcProveedor_DgCab1.pUsuario = objSeguridadBN.pUsuario
            UcProveedor_DgCab1.pPSTPRVCL = txtProveedor.Text.Trim
            If (txtTipo.Resultado IsNot Nothing) Then
                UcProveedor_DgCab1.pPSSTPORL = CType(Me.txtTipo.Resultado, Ransa.TypeDef.beGeneral).PSCCMPRN.Trim
            End If
            If (txtTipo.Resultado Is Nothing) Then
                UcProveedor_DgCab1.pPSSTPORL = ""
            End If
            UcProveedor_DgCab1.ActualizarListaProveedor()
            CCLNT = txtCliente.pCodigo

            RefreshPlanta()

        Catch : End Try
      
    End Sub

    Private Sub RefreshPlanta()

        Dim oBR As New brPlantaClienteProveedor
        'Dim oInfoProveedor As New Ransa.TYPEDEF.Proveedor.beProveedor
        Dim oInfoProveedor As New Ransa.Controls.Proveedor.beProveedor
        oInfoProveedor = UcProveedor_DgCab1.infoProveedor
        If (oInfoProveedor Is Nothing) Then
            dgPlantaCliente.DataSource = Nothing
        Else
            Dim lis As List(Of bePlantaClienteProveedor) = oBR.Listar(oInfoProveedor.PNCPRVCL, ucpPlanta)
            dgPlantaCliente.DataSource = lis
        End If       
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmListaClienteTercero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgPlantaCliente.AutoGenerateColumns = False
            Dim objAppConfig As cAppConfig = New cAppConfig
            Dim intTemp As Int64 = 0
            Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            CargarControles()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            If (txtCliente.pCodigo = 0) Then
                MessageBox.Show("Seleccione Cliente", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ActualizarLista()
        Catch : End Try


    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        Try

            If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
                ActualizarLista()
            Else
                If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                    e.Handled = True
                End If
                Select Case AscW(e.KeyChar)
                    Case 8
                        e.Handled = False
                End Select
            End If
        Catch : End Try

    End Sub

    Private Sub CargarControles()
        Dim ListaTipo As New List(Of beGeneral)
        Dim obrGeneral As New Ransa.NEGO.brGeneral

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
        'Dim Tipo As New beGeneral
        'Tipo.PSCCMPRN = "0"
        'Tipo.PSTDSDES = ""
        'ListaTipo.Add(Tipo)
        'txtTipo.DataSource = ListaTipo
        txtTipo.ListColumnas = oListColum
        txtTipo.Cargas()
        txtTipo.ValueMember = "PSCCMPRN"
        txtTipo.DispleyMember = "PSTDSDES"

        'txtTipo.Valor = "0"
        txtTipo.Refresh()

    End Sub

    Private Sub btnAgregar_Planta_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Planta.Click
        If (UcProveedor_DgCab1.Count > 0) Then
            Dim frm As New frmEPlantaProveedor
            Dim oBE As New bePlantaClienteProveedor
            'Dim oInfoProveedor As New Ransa.TYPEDEF.Proveedor.beProveedor
            Dim oInfoProveedor As New Ransa.Controls.Proveedor.beProveedor
            oInfoProveedor = UcProveedor_DgCab1.infoProveedor
            oBE.PNCPRVCL = oInfoProveedor.PNCPRVCL
            frm.Tag = oBE
            frm.IsNuevo = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshPlanta()
            End If
        End If     
    End Sub
    Private Sub btnModificar_Planta_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Planta.Click
        Try
            If dgPlantaCliente.CurrentRow IsNot Nothing Then
                Dim frm As New frmEPlantaProveedor
                frm.IsNuevo = False
                frm.Tag = dgPlantaCliente.CurrentRow.DataBoundItem
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    RefreshPlanta()
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub btnEliminar_Planta_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_PLanta.Click
        Try
            If dgPlantaCliente.CurrentRow Is Nothing Then Exit Sub
            Dim retorno As Int32 = 0
            If MessageBox.Show("Está seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim obr As New brPlantaClienteProveedor()
                Dim obePlantaClienteProveedor As New bePlantaClienteProveedor
                obePlantaClienteProveedor = dgPlantaCliente.CurrentRow.DataBoundItem
                retorno = obr.EliminarPlantaClienteTercero(obePlantaClienteProveedor)
                If (retorno = 1) Then
                    MessageBox.Show("El registro se eliminó satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshPlanta()
                Else
                    MessageBox.Show("No se pudo realizar la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If
        Catch : End Try
    End Sub

#End Region

    Private Sub UcProveedor_DgCab1_eventChange() Handles UcProveedor_DgCab1.eventChange
        RefreshPlanta()
    End Sub
   
    Private Sub txtProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProveedor.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                ActualizarLista()
            End If
        Catch : End Try

    End Sub

  

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        If (CCLNT <> txtCliente.pCodigo) Then
            UcProveedor_DgCab1.DataSourceNothing(True)
            dgPlantaCliente.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbCliente_InformationChanged() Handles txtCliente.InformationChanged
        If (CCLNT <> txtCliente.pCodigo) Then
            UcProveedor_DgCab1.DataSourceNothing(True)
            dgPlantaCliente.DataSource = Nothing
        End If
    End Sub

End Class
