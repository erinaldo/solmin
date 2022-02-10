Imports RANSA.NEGO

Public Class frmDPosiciones

#Region "Propiedaes"

#End Region

#Region "Metodos y funciones"

    Public Overloads Sub show(ByVal sTipo As String, ByVal sAlmacen As String, ByVal sSector As String, ByVal sPosicion As String, ByVal nCliente As Decimal)
        Dim obr As New brUbicacion
        dgDetalle.AutoGenerateColumns = False
        dgDetalle.DataSource = obr.ListarDetalleUbicacion(sTipo, sAlmacen, sSector, sPosicion, nCliente)
        KryptonHeader1.Text = "Posición: " & sPosicion
        Me.ShowDialog()
    End Sub

#End Region

#Region "Eventos"

    Private Sub ButtonSpecAny1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecAny1.Click
        Close()
    End Sub

#End Region

End Class
