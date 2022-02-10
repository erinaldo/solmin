Imports SOLMIN_ST.NEGOCIO.operaciones

Public Class frmValidaCliente
    Public _CCLNT_COD As Decimal
    Public _CCMPN_COD As String

   

    Private Sub frmValidaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtClienteFiltro.pUsuario = MainModule.USUARIO
        txtClienteFiltro.CCMPN = Me._CCMPN_COD
        txtClienteFiltro.pCargar(Me._CCLNT_COD)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim solicitudTransporteBL As New Solicitud_Transporte_BLL
        Dim oSeguridad As NEGOCIO.Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(MainModule.USUARIO)

        Dim mensaje As String = oSeguridad.VerificarLineaCreditoCliente(_CCMPN_COD, txtClienteFiltro.pCodigo)
        If mensaje.ToString() <> "" Then
            MessageBox.Show(mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cliente habilitado.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
