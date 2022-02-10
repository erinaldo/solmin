Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmNotificacionEmail

#Region "Propiedades"

    Private _COCNTF As Decimal
    Public Property COCNTF() As Decimal
        Get
            Return _COCNTF
        End Get
        Set(ByVal value As Decimal)
            _COCNTF = value
        End Set
    End Property

#End Region

    Private Sub frmNotificacionEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Cargar_Formatos()
    End Sub
 
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim brSegNotificacion As New Negocio.clsSegNotificacion
        Dim dt As New DataTable
        Dim beSegNotificacion As New beSegNotificacion
        With beSegNotificacion
            .PNCOCNTF = COCNTF
            .PSCODFMT = cbmFormato.SelectedValue
            .PSCULUSA = HelpUtil.UserName
        End With
        brSegNotificacion.ActualizarFormatoProcesoNotificacionXCliente(beSegNotificacion)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#Region "Metodos y Fuciones"

    Private Sub Cargar_Cargar_Formatos()
        Dim oclsTipoDatoGeneral As New Negocio.clsTipoDatoGeneral
        Dim Lista As New List(Of beTipoDatoGeneral)
        Dim obtipoGeneral As New beTipoDatoGeneral
        Lista = oclsTipoDatoGeneral.Listar_Tipo_Dato_X_Codigo_General("SCFCHK")


        For Each Item As beTipoDatoGeneral In Lista
            Item.PSTDSDES = Item.PSCCMPRN & " " & Item.PSTDSDES
        Next

        obtipoGeneral.PSCCMPRN = ""
        obtipoGeneral.PSTDSDES = "Ninguno"
        Lista.Insert(0, obtipoGeneral)
        cbmFormato.DataSource = Lista
        cbmFormato.ValueMember = "PSCCMPRN"
        cbmFormato.DisplayMember = "PSTDSDES"
        cbmFormato.SelectedValue = ""
    End Sub

#End Region

End Class
