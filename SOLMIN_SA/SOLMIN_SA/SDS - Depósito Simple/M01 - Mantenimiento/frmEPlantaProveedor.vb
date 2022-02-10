Imports RANSA.TypeDef

Public Class frmEPlantaProveedor

#Region "Atributos"
    Public Property IsNuevo() As Boolean
        Get
            Return _IsNuevo
        End Get
        Set(ByVal value As Boolean)
            _IsNuevo = value
        End Set
    End Property


    Private _PNCPLCLP As Decimal
    Public Property PNCPLCLP() As Decimal
        Get
            Return _PNCPLCLP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property

#End Region

#Region "Variables"

    Private oEntidad As bePlantaClienteProveedor
    Private _IsNuevo As Boolean

#End Region

#Region "Metodos y Funciones"

    Private Sub SetDataSource(ByVal obj As bePlantaClienteProveedor)
        If Not IsNuevo Then
            With obj
                txtNombrePlanta.Text = .PSTCMPCP.Trim
                txtDireccionPlanta.Text = .PSTDRPCP.Trim
                txtDireccionDestinatario.Text = .PSTDRDST.Trim
                txtMailDestino.Text = .PSMAILDS.Trim
                If .PNCUBGE2 <> 0 Then
                    txtUbigeo.Valor = .PNCUBGE2
                End If
            End With
        End If
    End Sub

    Private Sub GetDataSource()
        With oEntidad
            .PSTCMPCP = txtNombrePlanta.Text
            .PSTDRPCP = txtDireccionPlanta.Text
            .PSTDRDST = txtDireccionDestinatario.Text
            .PSMAILDS = txtMailDestino.Text
        End With
    End Sub

    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtNombrePlanta.Enabled = True
        txtDireccionPlanta.Enabled = True
        txtDireccionDestinatario.Enabled = True
        txtMailDestino.Enabled = True
    End Sub

    Private Sub cargarUbigeo()
        'Cargar Ubigeo
        Dim oBR As New Ransa.NEGO.brPlantaClienteProveedor
        Dim oListColumTD As New Hashtable
        Dim oColumnasTD As New DataGridViewTextBoxColumn
        oColumnasTD = New DataGridViewTextBoxColumn
        oColumnasTD.Name = "PNCUBGE2"
        oColumnasTD.DataPropertyName = "PNCUBGE2"
        oColumnasTD.HeaderText = "Código "
        oListColumTD.Add(1, oColumnasTD)
        oColumnasTD = New DataGridViewTextBoxColumn
        oColumnasTD.Name = "PSUBIGEO"
        oColumnasTD.DataPropertyName = "PSUBIGEO"
        oColumnasTD.HeaderText = "Ubigeo"
        oListColumTD.Add(2, oColumnasTD)
       
        txtUbigeo.DataSource = oBR.CargarUbigeo()
        txtUbigeo.ListColumnas = oListColumTD
        txtUbigeo.Cargas()
        txtUbigeo.ValueMember = "PNCUBGE2"
        txtUbigeo.DispleyMember = "PSUBIGEO"
        'txtUbigeo.Valor = 1
        txtUbigeo.Refresh()
    End Sub



#End Region

#Region "Eventos"

    Private Sub frmEPlantaProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oEntidad = TryCast(Me.Tag, bePlantaClienteProveedor)
        SetDataSource(oEntidad)
        cargarUbigeo()
        If IsNuevo Then
            SetEnabled(True)
        Else
            SetEnabled(False)
        End If
    End Sub
    Private Function ValidarIngreso() As String
        Dim str As String = ""
        If (txtNombrePlanta.Text.Trim.Equals("") = True) Then
            str = "* Debe de ingresar el nombre de la planta" & Chr(13)
        End If
        Return str
    End Function
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim strMensaje As String = ""
        txtNombrePlanta.Focus()
        strMensaje = ValidarIngreso()
        If (Not strMensaje.Equals("")) Then
            MessageBox.Show(strMensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim obrEntidad As New Ransa.NEGO.brPlantaClienteProveedor
        Dim strText As String
        GetDataSource()
        If IsNuevo Then
            oEntidad.PSCUSCRT = objSeguridadBN.pUsuario
            oEntidad.PNFCHCRT = Now.Date.ToString("yyyyMMdd")
            oEntidad.PNHRACRT = Now.Date.ToString("hhmmss")

            If Not txtUbigeo.Resultado Is Nothing Then
                oEntidad.PNCUBGE2 = CType(txtUbigeo.Resultado, bePlantaClienteProveedor).PNCUBGE2
            Else
                oEntidad.PNCUBGE2 = 0
            End If
            'oEntidad.PNCUBGE2 = CType(txtUbigeo.Resultado, bePlantaClienteProveedor).PNCUBGE2
            oEntidad.PNUPDATE_IDENT = 1
            _PNCPLCLP = obrEntidad.fintInsertarPlantaClienteTercero(oEntidad)
            strText = "El registro se insertó satisfactoriamente."
        Else
            oEntidad.PSCULUSA = objSeguridadBN.pUsuario
            oEntidad.PNFULTAC = Now.Date.ToString("yyyyMMdd")
            oEntidad.PNHULTAC = Now.Date.ToString("hhmmss")
            If Not txtUbigeo.Resultado Is Nothing Then
                oEntidad.PNCUBGE2 = CType(txtUbigeo.Resultado, bePlantaClienteProveedor).PNCUBGE2
            Else
                oEntidad.PNCUBGE2 = 0
            End If
            oEntidad.PNUPDATE_IDENT += 1
            obrEntidad.Update(oEntidad)
            strText = "El registro se actualizó satisfactoriamente"
        End If
        MessageBox.Show(strText, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

    Private Sub frmEPlantaProveedor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Not IsNuevo Then
            txtUbigeo.Focus()
            txtUbigeo.Refresh()
            txtNombrePlanta.Focus()
        End If
    End Sub
 
End Class
