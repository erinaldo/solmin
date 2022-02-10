Imports Ransa.TypeDef.Transportista

Public Class ucTransportista_FTransportista
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
    Private oQry_Transportista_L01 As TD_Qry_Transportista_L01 = New Ransa.TypeDef.Transportista.TD_Qry_Transportista_L01
    Private oInf_Transportista As TD_Inf_Transportista_L01 = New Ransa.TypeDef.Transportista.TD_Inf_Transportista_L01

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
    Public ReadOnly Property pSeleccion() As TD_Inf_Transportista_L01
        Get
            Return oInf_Transportista
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Transportista_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Transportista_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pUsuario() As String
        Get
            Return oQry_Transportista_L01.pUsuario
        End Get
        Set(ByVal value As String)
            oQry_Transportista_L01.pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If sCondicion01 <> txtNRUCTR.Text.ToUpper.Trim Or sCondicion02 <> txtRazonSocial.Text.ToUpper.Trim Or _
           sCondicion03 <> txtCodRNS.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "*"
            ' Validamos de que exista información ingresada
            With oQry_Transportista_L01
                If txtNRUCTR.Text.Trim <> "" Then
                    .pNRUCTR_RucTransportista = sTemp & txtNRUCTR.Text.Trim & "*"
                Else
                    .pNRUCTR_RucTransportista = ""
                End If

                If txtRazonSocial.Text.Trim <> "" Then
                    .pTCMTRT_RazonSocial = sTemp & txtRazonSocial.Text.Trim & "*"
                Else
                    .pTCMTRT_RazonSocial = ""
                End If
                If txtCodRNS.Text.Trim <> "" Then
                    .pCTRSPT_CodTransportista = sTemp & txtCodRNS.Text.Trim & "*"
                Else
                    .pCTRSPT_CodTransportista = ""
                End If
            End With
            sCondicion01 = txtNRUCTR.Text.ToUpper.Trim
            sCondicion02 = txtRazonSocial.Text.ToUpper.Trim
            sCondicion03 = txtCodRNS.Text.ToUpper.Trim

            dgTransportista.pActualizar(oQry_Transportista_L01)
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As TD_Qry_Transportista_L01)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNRUCTR.Text = .pNRUCTR_RucTransportista
            txtRazonSocial.Text = .pTCMTRT_RazonSocial
            txtCodRNS.Text = Filtro.pCTRSPT_CodTransportista

            oQry_Transportista_L01.pSINDRC_PropioTercero = Filtro.pSINDRC_PropioTercero
            oQry_Transportista_L01.pCCMPN_Compania = Filtro.pCCMPN_Compania
            oQry_Transportista_L01.pUsuario = .pUsuario
            oQry_Transportista_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Transportista_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            Call pCargarInformacion()
        End With
    End Sub

    Sub New(ByVal Filtro As TD_Qry_Transportista_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNRUCTR.Text = .pNRUCTR_RucTransportista
            txtRazonSocial.Text = .pTCMTRT_RazonSocial
            txtCodRNS.Text = Filtro.pCTRSPT_CodTransportista

            oQry_Transportista_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Transportista_L01.pNRUCTR_RucTransportista = .pNRUCTR_RucTransportista
            oQry_Transportista_L01.pSINDRC_PropioTercero = .pSINDRC_PropioTercero
            oQry_Transportista_L01.pTCMTRT_RazonSocial = .pTCMTRT_RazonSocial
            oQry_Transportista_L01.pCTRSPT_CodTransportista = .pCTRSPT_CodTransportista
            oQry_Transportista_L01.pUsuario = .pUsuario
            oQry_Transportista_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Transportista_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            dgTransportista.LoadDataSource(Filtro, DataSource, iTPag)
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInf_Transportista.pClearAll()
        Me.Close()
    End Sub

    Private Sub dgTransportista_SalirDobleClick(ByVal Transportista As TypeDef.Transportista.TD_Inf_Transportista_L01) Handles dgTransportista.SalirDobleClick
        oInf_Transportista.pCCMPN_Compania = dgTransportista.pSeleccion.pCCMPN_Compania
        oInf_Transportista.pNRUCTR_RucTransportista = dgTransportista.pSeleccion.pNRUCTR_RucTransportista
        oInf_Transportista.pTCMTRT_RazonSocial = dgTransportista.pSeleccion.pTCMTRT_RazonSocial
        oInf_Transportista.pCTRSPT_CodTransportista = dgTransportista.pSeleccion.pCTRSPT_CodTransportista
        oInf_Transportista.pSINDRC_PropioTercero = dgTransportista.pSeleccion.pSINDRC_PropioTercero
        Me.Close()
    End Sub

    Private Sub txtNRUCTR_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNRUCTR.GotFocus
        txtNRUCTR.SelectAll()
    End Sub

    Private Sub txtNRUCTR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNRUCTR.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtNRUCTR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNRUCTR.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub


    Private Sub txtRazonSocial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.GotFocus
        txtRazonSocial.SelectAll()
    End Sub

    Private Sub txtRazonSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRazonSocial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRazonSocial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtCodRNS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodRNS.GotFocus
        txtCodRNS.SelectAll()
    End Sub

    Private Sub txtCodRNS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodRNS.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtCodRNS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodRNS.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucTransportista_FTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTransportista.pPermitirSalirDoubleClick = True
        oQry_Transportista_L01.pNROPAG_NroPagina = 1
        If txtNRUCTR.Text <> "" Or txtRazonSocial.Text <> "" Then
            Call pCargarInformacion()
            dgTransportista.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
