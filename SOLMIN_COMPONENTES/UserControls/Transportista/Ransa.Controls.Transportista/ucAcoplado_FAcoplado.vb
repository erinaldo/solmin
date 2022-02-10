Imports Ransa.TypeDef.Transportista

Public Class ucAcoplado_FAcoplado
#Region " Definición Eventos "

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Información
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_Acoplado_L01 As TD_Qry_Acoplado_L01 = New Ransa.TypeDef.Transportista.TD_Qry_Acoplado_L01
    Private oInf_Acoplado As TD_Inf_Acoplado_L01 = New Ransa.TypeDef.Transportista.TD_Inf_Acoplado_L01

    Private sCondicion01 As String = " "
    Private sCondicion02 As String = " "
    Private sCondicion03 As String = " "
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public ReadOnly Property pSeleccion() As TD_Inf_Acoplado_L01
        Get
            Return oInf_Acoplado
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Acoplado_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pUsuario() As String
        Get
            Return oQry_Acoplado_L01.pUsuario
        End Get
        Set(ByVal value As String)
            oQry_Acoplado_L01.pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If sCondicion01 <> txtNPLCAC.Text.ToUpper.Trim Or sCondicion02 <> txtMarcaModelo.Text.ToUpper.Trim Or _
           sCondicion03 <> txtTipoAcoplado.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "*"
            ' Validamos de que exista información ingresada
            With oQry_Acoplado_L01
                If txtNPLCAC.Text.Trim <> "" Then
                    .pNPLCAC_NroAcoplado = sTemp & txtNPLCAC.Text.Trim & "*"
                Else
                    .pNPLCAC_NroAcoplado = ""
                End If

                If txtMarcaModelo.Text.Trim <> "" Then
                    .pTMRCVH_Marca = sTemp & txtMarcaModelo.Text.Trim & "*"
                Else
                    .pTMRCVH_Marca = ""
                End If
                If txtTipoAcoplado.Text.Trim <> "" Then
                    .pTDEACP_DetTipoAcoplado = sTemp & txtTipoAcoplado.Text.Trim & "*"
                Else
                    .pTDEACP_DetTipoAcoplado = ""
                End If
            End With
            sCondicion01 = txtNPLCAC.Text.ToUpper.Trim
            sCondicion02 = txtMarcaModelo.Text.ToUpper.Trim
            sCondicion03 = txtTipoAcoplado.Text.ToUpper.Trim

            dgAcoplado.pActualizar(oQry_Acoplado_L01)
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As TD_Qry_Acoplado_L01)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNPLCAC.Text = .pNPLCAC_NroAcoplado
            txtMarcaModelo.Text = .pTMRCVH_Marca
            txtTipoAcoplado.Text = Filtro.pTDEACP_DetTipoAcoplado

            oQry_Acoplado_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Acoplado_L01.pUsuario = .pUsuario
            oQry_Acoplado_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            Call pCargarInformacion()
        End With
    End Sub

    Sub New(ByVal Filtro As TD_Qry_Acoplado_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNPLCAC.Text = .pNPLCAC_NroAcoplado
            txtMarcaModelo.Text = .pTMRCVH_Marca
            txtTipoAcoplado.Text = Filtro.pTDEACP_DetTipoAcoplado

            oQry_Acoplado_L01.pNPLCAC_NroAcoplado = .pNPLCAC_NroAcoplado
            oQry_Acoplado_L01.pTMRCVH_Marca = .pTMRCVH_Marca
            oQry_Acoplado_L01.pTDEACP_DetTipoAcoplado = .pTDEACP_DetTipoAcoplado
            oQry_Acoplado_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Acoplado_L01.pUsuario = .pUsuario
            oQry_Acoplado_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Acoplado_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            dgAcoplado.LoadDataSource(Filtro, DataSource, iTPag)
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInf_Acoplado.pClearAll()
        Me.Close()
    End Sub

    Private Sub dgAcoplado_SalirDobleClick(ByVal Acoplado As TypeDef.Transportista.TD_Inf_Acoplado_L01) Handles dgAcoplado.SalirDobleClick
        oInf_Acoplado.pCCMPN_Compania = dgAcoplado.pSeleccion.pCCMPN_Compania
        oInf_Acoplado.pNPLCAC_NroAcoplado = dgAcoplado.pSeleccion.pNPLCAC_NroAcoplado
        oInf_Acoplado.pTMRCVH_Marca = dgAcoplado.pSeleccion.pTMRCVH_Marca
        oInf_Acoplado.pTDEACP_DetTipoAcoplado = dgAcoplado.pSeleccion.pTDEACP_DetTipoAcoplado
        Me.Close()
    End Sub

    Private Sub txtNPLCAC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNPLCAC.GotFocus
        txtNPLCAC.SelectAll()
    End Sub

    Private Sub txtNPLCAC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNPLCAC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtNPLCAC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNPLCAC.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtMarcaModelo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMarcaModelo.GotFocus
        txtMarcaModelo.SelectAll()
    End Sub

    Private Sub txtMarcaModelo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMarcaModelo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtMarcaModelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarcaModelo.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtTipoAcoplado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoAcoplado.GotFocus
        txtTipoAcoplado.SelectAll()
    End Sub

    Private Sub txtTipoAcoplado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoAcoplado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtTipoAcoplado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoAcoplado.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucAcoplado_FAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgAcoplado.pPermitirSalirDoubleClick = True
        oQry_Acoplado_L01.pNROPAG_NroPagina = 1
        If txtNPLCAC.Text <> "" Or txtMarcaModelo.Text <> "" Then
            Call pCargarInformacion()
            dgAcoplado.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class