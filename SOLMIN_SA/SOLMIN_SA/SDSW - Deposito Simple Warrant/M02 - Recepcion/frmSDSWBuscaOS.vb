Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Public Class frmSDSWBuscaOS
    Public flag As String

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If flag = "R" Then
            With frmSDSWRecepcionSDS
                .dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaWO(IIf(.txtCliente.Tag = "", 0, .txtCliente.Tag), .dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value, txtOrden.Text)
                Me.Close()
            End With
        Else
            'With frmSDSWDespachoSDSA
            '    .dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderiaWO(IIf(.txtCliente.Tag = "", 0, .txtCliente.Tag), .dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value, txtOrden.Text)
            '    Me.Close()
            'End With
        End If

    End Sub
End Class
