Imports Ransa.TypeDef.Transportista

Public Class ucTracto_FTracto
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
    Private oQry_Tracto_L01 As TD_Qry_Tracto_L01 = New Ransa.TypeDef.Transportista.TD_Qry_Tracto_L01
    Private oInf_Tracto As TD_Inf_Tracto_L01 = New Ransa.TypeDef.Transportista.TD_Inf_Tracto_L01

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
    Public ReadOnly Property pSeleccion() As TD_Inf_Tracto_L01
        Get
            Return oInf_Tracto
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Tracto_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Tracto_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pUsuario() As String
        Get
            Return oQry_Tracto_L01.pUsuario
        End Get
        Set(ByVal value As String)
            oQry_Tracto_L01.pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If sCondicion01 <> txtNPLCUN.Text.ToUpper.Trim Or sCondicion02 <> txtMarcaModelo.Text.ToUpper.Trim Or _
           sCondicion03 <> txtNroMTC.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "*"
            ' Validamos de que exista información ingresada
            With oQry_Tracto_L01
                If txtNPLCUN.Text.Trim <> "" Then
                    .pNPLCUN_NroPlacaUnidad = sTemp & txtNPLCUN.Text.Trim & "*"
                Else
                    .pNPLCUN_NroPlacaUnidad = ""
                End If

                If txtMarcaModelo.Text.Trim <> "" Then
                    .pTMRCTR_Marca_Modelo = sTemp & txtMarcaModelo.Text.Trim & "*"
                Else
                    .pTMRCTR_Marca_Modelo = ""
                End If
                If txtNroMTC.Text.Trim <> "" Then
                    .pNRGMT1_NroMTC = sTemp & txtNroMTC.Text.Trim & "*"
                Else
                    .pNRGMT1_NroMTC = ""
                End If
            End With
            sCondicion01 = txtNPLCUN.Text.ToUpper.Trim
            sCondicion02 = txtMarcaModelo.Text.ToUpper.Trim
            sCondicion03 = txtNroMTC.Text.ToUpper.Trim

            dgTracto.pActualizar(oQry_Tracto_L01)
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As TD_Qry_Tracto_L01)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNPLCUN.Text = .pNPLCUN_NroPlacaUnidad
            txtMarcaModelo.Text = .pTMRCTR_Marca_Modelo
            txtNroMTC.Text = Filtro.pNRGMT1_NroMTC

            oQry_Tracto_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Tracto_L01.pUsuario = .pUsuario
            oQry_Tracto_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Tracto_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            Call pCargarInformacion()
        End With
    End Sub

    Sub New(ByVal Filtro As TD_Qry_Tracto_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtNPLCUN.Text = .pNPLCUN_NroPlacaUnidad
            txtMarcaModelo.Text = .pTMRCTR_Marca_Modelo
            txtNroMTC.Text = Filtro.pNRGMT1_NroMTC

            oQry_Tracto_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Tracto_L01.pNPLCUN_NroPlacaUnidad = .pNPLCUN_NroPlacaUnidad
            oQry_Tracto_L01.pTMRCTR_Marca_Modelo = .pTMRCTR_Marca_Modelo
            oQry_Tracto_L01.pNRGMT1_NroMTC = .pNRGMT1_NroMTC
            oQry_Tracto_L01.pUsuario = .pUsuario
            oQry_Tracto_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Tracto_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            dgTracto.LoadDataSource(Filtro, DataSource, iTPag)
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInf_Tracto.pClearAll()
        Me.Close()
    End Sub

    Private Sub dgTracto_SalirDobleClick(ByVal Tracto As TypeDef.Transportista.TD_Inf_Tracto_L01) Handles dgTracto.SalirDobleClick
        oInf_Tracto.pCCMPN_Compania = dgTracto.pSeleccion.pCCMPN_Compania
        oInf_Tracto.pNPLCUN_NroPlacaUnidad = dgTracto.pSeleccion.pNPLCUN_NroPlacaUnidad
        oInf_Tracto.pTMRCTR_Marca_Modelo = dgTracto.pSeleccion.pTMRCTR_Marca_Modelo
        oInf_Tracto.pNRGMT1_NroMTC = dgTracto.pSeleccion.pNRGMT1_NroMTC
        Me.Close()
    End Sub

    Private Sub txtNPLCUN_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNPLCUN.GotFocus
        txtNPLCUN.SelectAll()
    End Sub

    Private Sub txtNPLCUN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNPLCUN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtNPLCUN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNPLCUN.TextChanged
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

    Private Sub txtNroMTC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroMTC.GotFocus
        txtNroMTC.SelectAll()
    End Sub

    Private Sub txtNroMTC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroMTC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtNroMTC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroMTC.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucTracto_FTracto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgTracto.pPermitirSalirDoubleClick = True
        oQry_Tracto_L01.pNROPAG_NroPagina = 1
        If txtNPLCUN.Text <> "" Or txtMarcaModelo.Text <> "" Then
            Call pCargarInformacion()
            dgTracto.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
