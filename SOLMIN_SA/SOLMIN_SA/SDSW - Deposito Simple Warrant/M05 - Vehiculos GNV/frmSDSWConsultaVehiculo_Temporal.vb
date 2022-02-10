Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDSW
Public Class frmSDSWConsultaVehiculo_Temporal
    Dim MyNumber(2) As String
    Private Sub frmConsultaVehiculo_Temporal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgvVehiculos.DataSource = mfdtListar_SDSWVehiculo_Temporal()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ActualizaInfo()
    End Sub
    Public Sub ActualizaInfo()

    End Sub
End Class
