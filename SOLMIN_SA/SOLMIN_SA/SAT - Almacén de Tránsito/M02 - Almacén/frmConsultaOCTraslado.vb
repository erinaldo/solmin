'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Public Class frmConsultaOCTraslado



    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Private OrdenCompraActual As Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK

    Public oListBulto As New List(Of beBulto)
    Public Bulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01

    Public myDialogResult As Boolean = False
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            pActualizarInformacion()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pActualizarInformacion()
        Dim objAppConfig As cAppConfig = New cAppConfig

        Dim objFiltroOC As TD_Qry_OrdenCompra_L01 = New TD_Qry_OrdenCompra_L01
        objFiltroOC.pCCLNT_CodigoCliente = Bulto.pCCLNT_CodigoCliente
        objFiltroOC.pNORCML_NroOrdenCompra = txtOrdenCompra.Text.Trim
        UcOrdenCompra.pActualizar(objFiltroOC)
    End Sub

    Private Sub MostrarTrasladoOC()
        Try
            If (OrdenCompraActual IsNot Nothing) Then
                Dim ofrmTrasladoOC As New frmTrasladoOC
                ofrmTrasladoOC.oListBulto = oListBulto
                ofrmTrasladoOC.Compania = _PSCCMPN
                ofrmTrasladoOC.Division = _PSCDVSN
                ofrmTrasladoOC.Planta = _PNCPLNDV
                ofrmTrasladoOC.Bulto = Bulto
                ofrmTrasladoOC.pNORCML = OrdenCompraActual.pNORCML_NroOrdenCompra
                ofrmTrasladoOC.ShowDialog()
                myDialogResult = ofrmTrasladoOC.myDialogResult
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        MostrarTrasladoOC()
    End Sub

    Private Sub UcOrdenCompra_CurrentRowChanged(ByVal OrdenCompra As Ransa.TypeDef.OrdenCompra.OrdenCompra.TD_OrdenCompraPK) Handles UcOrdenCompra.CurrentRowChanged
        Try
            OrdenCompraActual = OrdenCompra
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtOrdenCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenCompra.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                pActualizarInformacion()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaOCTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            pActualizarInformacion()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcOrdenCompra_DblClickOc() Handles UcOrdenCompra.DblClickOc
        Try
            MostrarTrasladoOC()
        Catch ex As Exception

        End Try

    End Sub
End Class
