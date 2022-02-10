Imports RANSA.TYPEDEF.Proveedor

Public Class ucProveedor_FProv
#Region " Definición Eventos "

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    Private Filtro As TD_ProveedorL01 = New TD_ProveedorL01
    Private pProvselec As TD_InfBas_Proveedor = New TD_InfBas_Proveedor
#End Region
#Region " Propiedades "
    Public WriteOnly Property pFiltroCodigo() As String
        Set(ByVal value As String)
            If value <> "" Then txtCodigo.Text = value
        End Set
    End Property

    Public WriteOnly Property pFiltroDescripcion() As String
        Set(ByVal value As String)
            If value <> "" Then txtDescripcion.Text = value
        End Set
    End Property

    Public ReadOnly Property pProveedorSelec() As TD_InfBas_Proveedor
        Get
            Return pProvselec
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return Filtro.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then Filtro.pREGPAG_NroRegPorPagina = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        With Filtro
            .pCPRVCL_Proveedor = txtCodigo.Text
            .pTPRVCL_DescripcionProveedor = txtDescripcion.Text
            .pNRUCPR_NroRUC = txtRUC.Text
        End With
        txtCodigo.CausesValidation = False
        txtDescripcion.CausesValidation = False
        txtRUC.CausesValidation = False
        dgProveedor.pActualizar(Filtro)
        dgProveedor.pRefrescar()
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        pProvselec.pCPRVCL_Proveedor = 0
        pProvselec.pTPRVCL_DescripcionProveedor = ""
        pProvselec.pNRUCPR_NroRUC = 0
        Me.Close()
    End Sub

    Private Sub dgProveedor_SalirDobleClick(ByVal Proveedor As TYPEDEF.Proveedor.TD_InfBas_Proveedor) Handles dgProveedor.SalirDobleClick
        pProvselec.pCPRVCL_Proveedor = dgProveedor.pProveedorSelec.pCPRVCL_Proveedor
        pProvselec.pTPRVCL_DescripcionProveedor = dgProveedor.pProveedorSelec.pTPRVCL_DescripcionProveedor
        pProvselec.pNRUCPR_NroRUC = dgProveedor.pProveedorSelec.pNRUCPR_NroRUC
        Me.Close()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.Select(0, Len(txtCodigo.Text))
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If chkStatusOnLine.Checked Then
            If txtCodigo.Text <> "" And txtCodigo.Text <> 0 Then pCargarInformacion()
            txtCodigo.CausesValidation = False
        Else
            txtCodigo.CausesValidation = True
        End If
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        Call pCargarInformacion()
        txtCodigo.CausesValidation = False
    End Sub

    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.Select(0, Len(txtDescripcion.Text))
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If chkStatusOnLine.Checked Then
            If txtDescripcion.Text <> "" Then pCargarInformacion()
            txtDescripcion.CausesValidation = False
        Else
            txtDescripcion.CausesValidation = True
        End If
    End Sub

    Private Sub txtDescripcion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.Validated
        Call pCargarInformacion()
        txtDescripcion.CausesValidation = False
    End Sub

    Private Sub txtRUC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.GotFocus
        txtRUC.Select(0, Len(txtRUC.Text))
    End Sub

    Private Sub txtRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.TextChanged
        If chkStatusOnLine.Checked Then
            If txtRUC.Text <> "" And txtRUC.Text <> 0 Then pCargarInformacion()
            txtRUC.CausesValidation = False
        Else
            txtRUC.CausesValidation = True
        End If
    End Sub

    Private Sub txtRUC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.Validated
        Call pCargarInformacion()
        txtRUC.CausesValidation = False
    End Sub

    Private Sub ucProveedor_FProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgProveedor.pPermitirSalirDoubleClick = True
        Filtro.pREGPAG_NroRegPorPagina = 20
        Filtro.pNROPAG_NroPagina = 1
        If txtCodigo.Text <> "" Or txtDescripcion.Text <> "" Then
            Call pCargarInformacion()
            dgProveedor.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
