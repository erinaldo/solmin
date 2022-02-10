'Imports Ransa.TypeDef.Cliente

Public Class ucCliente_FCliente
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
    'Private oQry_Cliente_L01 As TD_Qry_Cliente_L01 = New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
    'Private oInf_Cliente As TD_Inf_Cliente_L01 = New Ransa.TypeDef.Cliente.TD_Inf_Cliente_L01
    Private oQry_Cliente_L01 As TD_Qry_Cliente_L01 = New Cliente.TD_Qry_Cliente_L01
    Private oInf_Cliente As TD_Inf_Cliente_L01 = New Cliente.TD_Inf_Cliente_L01

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
    Public ReadOnly Property pSeleccion() As TD_Inf_Cliente_L01
        Get
            Return oInf_Cliente
        End Get
    End Property

    Public Property pNroRegPorPaginas() As Int32
        Get
            Return oQry_Cliente_L01.pREGPAG_NroRegPorPagina
        End Get
        Set(ByVal value As Int32)
            If value > 0 Then oQry_Cliente_L01.pREGPAG_NroRegPorPagina = value
        End Set
    End Property

    Public Property pAccesosPorUsuario() As Boolean
        Get
            Return dgCliente.pAccesoPorUsuario
        End Get
        Set(ByVal value As Boolean)
            dgCliente.pAccesoPorUsuario = value
        End Set
    End Property

    Public Property pUsuario() As String
        Get
            Return oQry_Cliente_L01.pUsuario
        End Get
        Set(ByVal value As String)
            oQry_Cliente_L01.pUsuario = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If sCondicion01 <> txtCodigo.Text.ToUpper.Trim Or sCondicion02 <> txtDescripcion.Text.ToUpper.Trim Or _
           sCondicion03 <> txtRUC.Text.ToUpper.Trim Then
            ' Si los valores del filtro han cambiado, se realiza el proceso de consulta a la Bases de Datos
            Dim sSQL As String = ""
            Dim sTemp As String = ""
            ' Si esta marcado el estatus de incluido en la cadena, colocamos el comodín al inicio
            If chkEnLaCadena.Checked Then sTemp = "*"
            ' Validamos de que exista información ingresada
            With oQry_Cliente_L01
                If txtCodigo.Text.Trim <> "" Then
                    .pCCLNT_Cliente = sTemp & txtCodigo.Text.Trim & "*"
                Else
                    .pCCLNT_Cliente = ""
                End If

                If txtDescripcion.Text.Trim <> "" Then
                    .pTCMPCL_DescripcionCliente = sTemp & txtDescripcion.Text.Trim & "*"
                Else
                    .pTCMPCL_DescripcionCliente = ""
                End If
                If txtRUC.Text.Trim <> "" Then
                    .pNRUC_NroRUC = sTemp & txtRUC.Text.Trim & "*"
                Else
                    .pNRUC_NroRUC = ""
                End If
            End With
            sCondicion01 = txtCodigo.Text.ToUpper.Trim
            sCondicion02 = txtDescripcion.Text.ToUpper.Trim
            sCondicion03 = txtRUC.Text.ToUpper.Trim

            dgCliente.pActualizar(oQry_Cliente_L01)
        End If
    End Sub
#End Region
#Region " Eventos "
    Sub New(ByVal Filtro As TD_Qry_Cliente_L01, ByVal pAccesosPorUsuario As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtCodigo.Text = .pCCLNT_Cliente
            txtDescripcion.Text = .pTCMPCL_DescripcionCliente
            txtRUC.Text = .pNRUC_NroRUC

            oQry_Cliente_L01.pUsuario = .pUsuario
            oQry_Cliente_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Cliente_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina
            oQry_Cliente_L01.pCCMPN_CodigoCompania = .pCCMPN_CodigoCompania
            dgCliente.pAccesoPorUsuario = pAccesosPorUsuario
            Call pCargarInformacion()
        End With
    End Sub

    Sub New(ByVal Filtro As TD_Qry_Cliente_L01, ByVal DataSource As DataTable, ByVal iTPag As Integer, ByVal pAccesosPorUsuario As Boolean, Optional ByVal iTClient As Integer = 0)


        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        With Filtro
            txtCodigo.Text = .pCCLNT_Cliente
            txtDescripcion.Text = .pTCMPCL_DescripcionCliente
            txtRUC.Text = .pNRUC_NroRUC

            oQry_Cliente_L01.pCCLNT_Cliente = .pCCLNT_Cliente
            oQry_Cliente_L01.pTCMPCL_DescripcionCliente = .pTCMPCL_DescripcionCliente
            oQry_Cliente_L01.pNRUC_NroRUC = .pNRUC_NroRUC
            oQry_Cliente_L01.pUsuario = .pUsuario
            oQry_Cliente_L01.pNROPAG_NroPagina = .pNROPAG_NroPagina
            oQry_Cliente_L01.pREGPAG_NroRegPorPagina = .pREGPAG_NroRegPorPagina
            oQry_Cliente_L01.pCCMPN_CodigoCompania = .pCCMPN_CodigoCompania
            oQry_Cliente_L01.pVisualizarNegocio = .pVisualizarNegocio

            dgCliente.pAccesoPorUsuario = pAccesosPorUsuario
            dgCliente.LoadDataSource(Filtro, DataSource, iTPag, iTClient)
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        oInf_Cliente.pClear()
        Me.Close()
    End Sub

    Private Sub dgCliente_SalirDobleClick(ByVal Cliente As Cliente.TD_Inf_Cliente_L01) Handles dgCliente.SalirDobleClick
        oInf_Cliente.pCCLNT_Cliente = dgCliente.pSeleccion.pCCLNT_Cliente
        oInf_Cliente.pTCMPCL_DescripcionCliente = dgCliente.pSeleccion.pTCMPCL_DescripcionCliente
        oInf_Cliente.pTDRCOR_DireccionOrigen = dgCliente.pSeleccion.pTDRCOR_DireccionOrigen
        oInf_Cliente.pNRUC_NroRUC = dgCliente.pSeleccion.pNRUC_NroRUC
        oInf_Cliente.pNLBTEL_NroDocIdentidad = dgCliente.pSeleccion.pNLBTEL_NroDocIdentidad
        '<[AHM]>
        oInf_Cliente.pCRGVTA_CodigoRegionVenta = dgCliente.pSeleccion.pCRGVTA_CodigoRegionVenta
        oInf_Cliente.pTCRVTA_DescripcionRegionVenta = dgCliente.pSeleccion.pTCRVTA_DescripcionRegionVenta
        oInf_Cliente.pCDSCSP_CodigoSector = dgCliente.pSeleccion.pCDSCSP_CodigoSector
        oInf_Cliente.pCDDRSP_CodClienteSAP = dgCliente.pSeleccion.pCDDRSP_CodClienteSAP.Trim()
        '</[AHM]>
        Me.Close()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.SelectAll()
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRUC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.GotFocus
        txtRUC.SelectAll()
    End Sub

    Private Sub txtRUC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRUC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub txtRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRUC.TextChanged
        If chkMientrasEscribe.Checked Then
            Call pCargarInformacion()
        End If
    End Sub

    Private Sub ucCliente_FCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgCliente.pPermitirSalirDoubleClick = True
        oQry_Cliente_L01.pREGPAG_NroRegPorPagina = 20
        oQry_Cliente_L01.pNROPAG_NroPagina = 1
        If txtCodigo.Text <> "" Or txtDescripcion.Text <> "" Then
            Call pCargarInformacion()
            dgCliente.Focus()
        End If
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
