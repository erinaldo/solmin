Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF.Cliente
Public Class frmRecepcionesPendienteAprobacion

    Private Sub frmRecepcionesPendienteAprobacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '-- Crear status por control con F4
        ' Me.bsaPuntoEntrega.Visible = False
        ' Me.bsaAnularItemGS.Visible = False
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Iniciar la fecha de los controles
        dtpFechaInicial.Value = Now.Date
        dtpFechaFinal.Value = Now.Date
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("DespachoClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
    End Sub


    Private Sub Buscar()
        Dim obrDespacho As New brDespacho
        Dim obeDespacho As New beDespacho
        With obeDespacho
            .PNCCLNT = Me.txtCliente.pCodigo
            .PNNGUIRN = Val(Me.txtNroGuiaRANSA.Text)
            .PNFECINI = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaInicial.Value.Date)
            .PNFECFIN = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaFinal.Value.Date)
        End With
        dtgGuiasRansa.AutoGenerateColumns = False
        Me.dtgGuiasRansa.DataSource = obrDespacho.ListaGuiaRansaPendienteAprobacion(obeDespacho)
    End Sub

    Private Sub dgGuiasRansa_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgGuiasRansa.SelectionChanged
        If Me.dtgGuiasRansa.CurrentCellAddress.Y = -1 Then Exit Sub
        Dim obrDespacho As New brDespacho

        dtgDetalleGuiaRansa.AutoGenerateColumns = False
        Me.dtgDetalleGuiaRansa.DataSource = obrDespacho.ListaDetalleGuiaRansaPendienteAprobacion(Me.dtgGuiasRansa.CurrentRow.DataBoundItem)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Buscar()
    End Sub
End Class
