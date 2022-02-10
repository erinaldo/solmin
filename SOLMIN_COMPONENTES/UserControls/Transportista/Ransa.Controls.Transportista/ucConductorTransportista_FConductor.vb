Imports Ransa.TypeDef.Transportista

Public Class ucConductorTransportista_FConductor
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
    Private oQry_Conductor_L01 As TD_Qry_ConductorTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Qry_ConductorTransportista_L01
    Private oInf_Conductor As TD_Inf_ConductorTransportista_L01 = New Ransa.TypeDef.Transportista.TD_Inf_ConductorTransportista_L01

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
    Public ReadOnly Property pSeleccion() As TD_Inf_ConductorTransportista_L01
        Get
            Return oInf_Conductor
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Conductor_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Conductor_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pUsuario() As String
        Get
            Return oQry_Conductor_L01.pUsuario
        End Get 
        Set(ByVal value As String)
            oQry_Conductor_L01.pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If sCondicion01 <> txtCBRCNT.Text.ToUpper.Trim Or sCondicion02 <> txtConductor.Text.ToUpper.Trim Or _
           sCondicion03 <> txtStatusRecurso.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "*"
            ' Validamos de que exista información ingresada
            With oQry_Conductor_L01
                If txtCBRCNT.Text.Trim <> "" Then
                    .pCBRCNT_Brevete = sTemp & txtCBRCNT.Text.Trim & "*"
                Else
                    .pCBRCNT_Brevete = ""
                End If

                If txtConductor.Text.Trim <> "" Then
                    .pNombreApellidoChofer = sTemp & txtConductor.Text.Trim & "*"
                Else
                    .pNombreApellidoChofer = ""
                End If
                If txtStatusRecurso.Text.Trim <> "" Then
                    .pSINDRC_StatusRecurso = sTemp & txtStatusRecurso.Text.Trim & "*"
                Else
                    .pSINDRC_StatusRecurso = ""
                End If
            End With
            sCondicion01 = txtCBRCNT.Text.ToUpper.Trim
            sCondicion02 = txtConductor.Text.ToUpper.Trim
            sCondicion03 = txtStatusRecurso.Text.ToUpper.Trim

                dgConductor.pActualizar(oQry_Conductor_L01)
        End If
        End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As TD_Qry_ConductorTransportista_L01)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtCBRCNT.Text = .pCBRCNT_Brevete
            txtConductor.Text = .pNombreApellidoChofer
            txtStatusRecurso.Text = Filtro.pSINDRC_StatusRecurso
            oQry_Conductor_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Conductor_L01.pCDVSN = .pCDVSN
            oQry_Conductor_L01.pUsuario = .pUsuario
            oQry_Conductor_L01.pNRUCTR_RucTransportista = .pNRUCTR_RucTransportista
            oQry_Conductor_L01.pPlanta = .pPlanta
            oQry_Conductor_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Conductor_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            Call pCargarInformacion()
        End With
    End Sub

    Sub New(ByVal Filtro As TD_Qry_ConductorTransportista_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtCBRCNT.Text = .pCBRCNT_Brevete
            txtConductor.Text = .pNombreApellidoChofer
            txtStatusRecurso.Text = Filtro.pSINDRC_StatusRecurso

            oQry_Conductor_L01.pCBRCNT_Brevete = .pCBRCNT_Brevete
            oQry_Conductor_L01.pNombreApellidoChofer = .pNombreApellidoChofer
            oQry_Conductor_L01.pSINDRC_StatusRecurso = .pSINDRC_StatusRecurso
            oQry_Conductor_L01.pCCMPN_Compania = .pCCMPN_Compania
            oQry_Conductor_L01.pCDVSN = .pCDVSN
            oQry_Conductor_L01.pUsuario = .pUsuario
            oQry_Conductor_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Conductor_L01.pNRUCTR_RucTransportista = .pNRUCTR_RucTransportista
            oQry_Conductor_L01.pPlanta = .pPlanta
            oQry_Conductor_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina

            dgConductor.LoadDataSource(Filtro, DataSource, iTPag)
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInf_Conductor.pClearAll()
        Me.Close()
    End Sub

    Private Sub dgConductor_SalirDobleClick(ByVal Conductor As TypeDef.Transportista.TD_Inf_ConductorTransportista_L01) Handles dgConductor.SalirDobleClick
        oInf_Conductor.pCCMPN_Compania = dgConductor.pSeleccion.pCCMPN_Compania
        oInf_Conductor.pCBRCNT_Brevete = dgConductor.pSeleccion.pCBRCNT_Brevete
        oInf_Conductor.pTNMCMC_NombreChofer = dgConductor.pSeleccion.pTNMCMC_NombreChofer
        oInf_Conductor.pAPEPAT_ApPaterno = dgConductor.pSeleccion.pAPEPAT_ApPaterno
        oInf_Conductor.pAPEMAT_ApMaterno = dgConductor.pSeleccion.pAPEMAT_ApMaterno
        oInf_Conductor.pSINDRC_StatusRecurso = dgConductor.pSeleccion.pSINDRC_StatusRecurso
        Me.Close()
    End Sub

    Private Sub txtCBRCNT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCBRCNT.GotFocus
        txtCBRCNT.SelectAll()
    End Sub

    Private Sub txtCBRCNT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCBRCNT.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
            End Sub

    Private Sub txtCBRCNT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCBRCNT.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtConductor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConductor.GotFocus
        txtConductor.SelectAll()
    End Sub

    Private Sub txtConductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtConductor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConductor.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtStatusRecurso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStatusRecurso.GotFocus
        txtStatusRecurso.SelectAll()
    End Sub

    Private Sub txtStatusRecurso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStatusRecurso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtStatusRecurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatusRecurso.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucConductor_FConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgConductor.pPermitirSalirDoubleClick = True
        oQry_Conductor_L01.pNROPAG_NroPagina = 1
        If txtCBRCNT.Text <> "" Or txtConductor.Text <> "" Then
            Call pCargarInformacion()
            dgConductor.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region

  
End Class
